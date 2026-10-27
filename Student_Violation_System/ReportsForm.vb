Imports System.Data.Odbc
Imports System.Drawing.Printing

Public Class ReportsForm

    Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        VbConnect()
        dgvReports.AutoGenerateColumns = False
        dgvReports.ReadOnly = False

        SetupFilterComboBoxes()
        LoadReports()
    End Sub

    Private Sub SetupFilterComboBoxes()
        cmbFilterReports.Items.Clear()
        cmbFilterReports.Items.Add("All Courses")
        cmbFilterReports.Items.Add("BSIT")
        cmbFilterReports.Items.Add("BSHM")
        cmbFilterReports.Items.Add("BSTM")
        cmbFilterReports.Items.Add("BSED")
        cmbFilterReports.SelectedIndex = 0

        cmbMonth.Items.Clear()
        cmbMonth.Items.Add("All Months")
        Dim months() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
        For Each m As String In months
            cmbMonth.Items.Add(m)
        Next
        cmbMonth.SelectedIndex = 0

        cmbYear.Items.Clear()
        cmbYear.Items.Add("All Years")
        Dim currentYear As Integer = DateTime.Now.Year
        For y As Integer = currentYear To 2024 Step -1
            cmbYear.Items.Add(y.ToString())
        Next
        cmbYear.SelectedIndex = 1
    End Sub

    Private Sub LoadReports()
        Try
            dgvReports.Rows.Clear()

            Using conn As OdbcConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT DISTINCT student_number, student_name, program, year_section FROM tbl_violation_records WHERE status != 'Archived'"

                Dim selectedCourse As String = If(cmbFilterReports.SelectedItem IsNot Nothing, cmbFilterReports.SelectedItem.ToString(), "All Courses")
                Dim selectedMonth As String = If(cmbMonth.SelectedItem IsNot Nothing, cmbMonth.SelectedItem.ToString(), "All Months")
                Dim selectedYear As String = If(cmbYear.SelectedItem IsNot Nothing, cmbYear.SelectedItem.ToString(), "All Years")

                If selectedCourse <> "All Courses" Then
                    query &= " AND program = '" & selectedCourse & "'"
                End If

                If selectedYear <> "All Years" Then
                    query &= " AND YEAR(created_at) = " & selectedYear
                End If

                If selectedMonth <> "All Months" Then
                    Dim monthIndex As Integer = cmbMonth.SelectedIndex
                    query &= " AND MONTH(created_at) = " & monthIndex
                End If

                Using cmd As New OdbcCommand(query, conn)
                    Using reader As OdbcDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim sNum As String = reader("student_number").ToString()
                            Dim sName As String = reader("student_name").ToString()
                            Dim sProg As String = reader("program").ToString()
                            Dim sYear As String = reader("year_section").ToString()

                            Dim reportList As New List(Of Dictionary(Of String, String))()
                            Dim subQuery As String = "SELECT record_id, violation_type, offense_count, punishment_category, status, created_at FROM tbl_violation_records WHERE student_number = ? AND status != 'Archived'"

                            Dim conditions As New List(Of String)
                            If selectedYear <> "All Years" Then conditions.Add("YEAR(created_at) = " & selectedYear)
                            If selectedMonth <> "All Months" Then conditions.Add("MONTH(created_at) = " & cmbMonth.SelectedIndex)
                            If conditions.Count > 0 Then
                                subQuery &= " AND " & String.Join(" AND ", conditions)
                            End If
                            subQuery &= " ORDER BY created_at DESC"

                            Using subCmd As New OdbcCommand(subQuery, conn)
                                subCmd.Parameters.AddWithValue("?", sNum)
                                Using subReader As OdbcDataReader = subCmd.ExecuteReader()
                                    While subReader.Read()

                                        Dim item As New Dictionary(Of String, String)()
                                        item("record_id") = subReader("record_id").ToString()
                                        item("violation_type") = subReader("violation_type").ToString()
                                        item("offense_count") = subReader("offense_count").ToString()
                                        item("punishment_category") = subReader("punishment_category").ToString()
                                        item("status") = subReader("status").ToString()
                                        item("created_at") = Convert.ToDateTime(subReader("created_at")).ToString("yyyy-MM-dd hh:mm tt")
                                        reportList.Add(item)
                                    End While
                                End Using
                            End Using

                            If reportList.Count > 0 Then
                                Dim latestRecord = reportList(0)

                                Dim rowIndex As Integer = dgvReports.Rows.Add()
                                Dim row As DataGridViewRow = dgvReports.Rows(rowIndex)

                                row.Cells("Column1").Value = latestRecord("record_id")
                                row.Cells("Column2").Value = sNum
                                row.Cells("Column3").Value = sName
                                row.Cells("Column4").Value = sProg
                                row.Cells("Column5").Value = sYear

                                row.Cells("Column2").ReadOnly = True
                                row.Cells("Column3").ReadOnly = True
                                row.Cells("Column4").ReadOnly = True
                                row.Cells("Column5").ReadOnly = True

                                SetIndependentComboBoxCell(row, "Column6", reportList, "violation_type", latestRecord("violation_type"))
                                SetIndependentComboBoxCell(row, "Column7", reportList, "offense_count", latestRecord("offense_count"))
                                SetIndependentComboBoxCell(row, "Column8", reportList, "punishment_category", latestRecord("punishment_category"))
                                SetIndependentComboBoxCell(row, "Column9", reportList, "status", latestRecord("status"))
                                SetIndependentComboBoxCell(row, "Column10", reportList, "created_at", latestRecord("created_at"))

                                row.Tag = reportList
                            End If

                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error sa pag-load ng reports: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SetIndependentComboBoxCell(row As DataGridViewRow, columnName As String, list As List(Of Dictionary(Of String, String)), key As String, defaultValue As String)
        Dim colIndex As Integer = dgvReports.Columns(columnName).Index
        Dim comboCell As New DataGridViewComboBoxCell()

        For Each item In list
            Dim val As String = item(key)
            If Not comboCell.Items.Contains(val) Then
                comboCell.Items.Add(val)
            End If
        Next

        If comboCell.Items.Contains(defaultValue) Then
            comboCell.Value = defaultValue
        ElseIf comboCell.Items.Count > 0 Then
            comboCell.Value = comboCell.Items(0)
        End If

        comboCell.ReadOnly = False
        row.Cells(colIndex) = comboCell
    End Sub

    Private Sub DgvReports_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReports.CellValueChanged
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim row As DataGridViewRow = dgvReports.Rows(e.RowIndex)
            Dim reportList = TryCast(row.Tag, List(Of Dictionary(Of String, String)))

            If reportList IsNot Nothing AndAlso reportList.Count > 0 Then
                Dim selectedDateCell As DataGridViewComboBoxCell = TryCast(row.Cells("Column10"), DataGridViewComboBoxCell)
                If selectedDateCell IsNot Nothing AndAlso selectedDateCell.Value IsNot Nothing Then
                    Dim selectedDate As String = selectedDateCell.Value.ToString()

                    For Each item In reportList
                        If item("created_at") = selectedDate Then
                            row.Cells("Column1").Value = item("record_id")
                            row.Cells("Column6").Value = item("violation_type")
                            row.Cells("Column7").Value = item("offense_count")
                            row.Cells("Column8").Value = item("punishment_category")
                            row.Cells("Column9").Value = item("status")
                            Exit For
                        End If
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub DgvReports_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvReports.CurrentCellDirtyStateChanged
        If dgvReports.IsCurrentCellDirty Then
            dgvReports.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub CmbFilterReports_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterReports.SelectedIndexChanged
        LoadReports()
    End Sub

    Private Sub CmbMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMonth.SelectedIndexChanged
        LoadReports()
    End Sub

    Private Sub CmbYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbYear.SelectedIndexChanged
        LoadReports()
    End Sub

    Private Sub BtnDeleteReport_Click(sender As Object, e As EventArgs) Handles btnDeleteReport.Click
        If dgvReports.SelectedRows.Count = 0 Then
            MessageBox.Show("Mangyaring pumili ng record sa listahan na nais mong tanggalin.", "Selection Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirmResult = MessageBox.Show("Sigurado ka bang gusto mong ilipat ang violation record na ito sa Trash Bin?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.Yes Then
            Try
                Dim selectedRow As DataGridViewRow = dgvReports.SelectedRows(0)

                If selectedRow.Cells("Column1").Value Is Nothing Then Return
                Dim recordId As String = selectedRow.Cells("Column1").Value.ToString()

                Using conn As OdbcConnection = GetConnection()
                    conn.Open()
                    Dim updateQuery As String = "UPDATE tbl_violation_records SET status = 'Archived', deleted_from = 'Reports Form' WHERE record_id = ?"
                    Using cmd As New OdbcCommand(updateQuery, conn)
                        cmd.Parameters.AddWithValue("?", recordId)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Matagumpay na nailipat ang record sa Trash Bin.", "Tagumpay", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadReports()

            Catch ex As Exception
                MessageBox.Show("Error sa pag-delete ng record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnPrintReport_Click(sender As Object, e As EventArgs) Handles btnPrintReport.Click
        Try
            Dim printDoc As New Printing.PrintDocument()

            Dim printerSettings As New PrinterSettings()
            printerSettings.PrinterName = "Microsoft Print to PDF"
            printDoc.PrinterSettings = printerSettings

            AddHandler printDoc.PrintPage, AddressOf PrintDoc_PrintPage

            Dim previewDlg As New PrintPreviewDialog()
            previewDlg.Document = printDoc
            previewDlg.WindowState = FormWindowState.Maximized
            previewDlg.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("May error sa pag-preview ng dokumento: " & ex.Message, "Print Preview Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim fontTitle As New Font("Segoe UI", 14, FontStyle.Bold)
        Dim fontHeader As New Font("Segoe UI", 8, FontStyle.Bold)
        Dim fontRow As New Font("Segoe UI", 7, FontStyle.Regular)
        Dim fontSign As New Font("Segoe UI", 9, FontStyle.Bold)

        Dim startX As Integer = 40
        Dim startY As Integer = 40

        Dim filterText As String = "Course: " & cmbFilterReports.Text & " | Month: " & cmbMonth.Text & " | Year: " & cmbYear.Text

        e.Graphics.DrawString("CSTA - OFFICIAL VIOLATION REPORTS", fontTitle, Brushes.Maroon, startX, startY)
        e.Graphics.DrawString(filterText & " | Generated: " & DateTime.Now.ToString("MMM dd, yyyy"), New Font("Segoe UI", 8, FontStyle.Italic), Brushes.Gray, startX, startY + 30)

        Dim yPos As Integer = startY + 70
        Dim xPos As Integer = startX

        For Each col As DataGridViewColumn In dgvReports.Columns
            If col.Visible Then
                e.Graphics.DrawString(col.HeaderText, fontHeader, Brushes.Black, xPos, yPos)
                xPos += 110
            End If
        Next

        yPos += 20
        e.Graphics.DrawLine(Pens.Black, startX, yPos, 1100, yPos)
        yPos += 10

        For Each row As DataGridViewRow In dgvReports.Rows
            If row.IsNewRow Then Continue For
            xPos = startX
            For Each cell As DataGridViewCell In row.Cells
                If dgvReports.Columns(cell.ColumnIndex).Visible Then
                    Dim cellValue As String = If(cell.Value IsNot Nothing, cell.Value.ToString(), "")
                    If cellValue.Length > 18 Then cellValue = cellValue.Substring(0, 15) & "..."
                    e.Graphics.DrawString(cellValue, fontRow, Brushes.Black, xPos, yPos)
                    xPos += 110
                End If
            Next
            yPos += 20

            If yPos > e.MarginBounds.Bottom + 300 Then
                e.HasMorePages = True
                Return
            End If
        Next

        yPos += 40
        If yPos > 650 Then yPos = 650

        Dim signWidth As Integer = 220
        e.Graphics.DrawLine(Pens.Black, 50, yPos, 50 + signWidth, yPos)
        e.Graphics.DrawString("Noted by: OSA Officer", fontSign, Brushes.Black, 50, yPos + 5)

        e.Graphics.DrawLine(Pens.Black, 400, yPos, 400 + signWidth, yPos)
        e.Graphics.DrawString("Affirmed by: Dean", fontSign, Brushes.Black, 400, yPos + 5)

        e.HasMorePages = False
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Dim dashboardForm As New DashboardForm()
        dashboardForm.Show()
        Me.Close()
    End Sub

    Private Sub ViolationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViolationsToolStripMenuItem.Click
        Dim violationForm As New ViolationsForm()
        violationForm.Show()
        Me.Close()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogoutUser(Me)
    End Sub

    Private Sub BtnTrashBim_Click(sender As Object, e As EventArgs) Handles btnTrashBim.Click
        If System.Windows.Forms.Application.OpenForms.OfType(Of TrashBinForm).Any() Then
            Exit Sub
        End If
        Dim trashForm As New TrashBinForm()
        trashForm.Show()
        Me.Hide()
    End Sub

End Class