Imports System.Data.Odbc
Imports System.Drawing.Printing

Public Class ReportsForm

    Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        VbConnect()
        dgvReports.AutoGenerateColumns = False
        cmbFilterReports.SelectedIndex = 0
        LoadReports()
    End Sub

    ' --- LOAD & FILTER REPORTS ---
    Private Sub LoadReports(Optional filterOption As String = "All Violations")
        Try
            Using conn As OdbcConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT record_id, student_number, student_name, program, year_section, violation_type, offense_count, punishment_category, status, created_at FROM tbl_violation_records WHERE status != 'Archived'"

                If filterOption = "No Proper Uniform" Then
                    query &= " AND violation_type LIKE '%No Proper Uniform%'"
                ElseIf filterOption = "No Proper Grooming" Then
                    query &= " AND violation_type LIKE '%No Proper Grooming%'"
                ElseIf filterOption = "Other Violations" Then
                    query &= " AND violation_type LIKE '%Other%'"
                End If

                Using cmd As New OdbcCommand(query, conn)
                    Dim adapter As New OdbcDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvReports.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error sa pag-load ng reports: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmbFilterReports_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterReports.SelectedIndexChanged
        If cmbFilterReports.SelectedItem IsNot Nothing Then
            LoadReports(cmbFilterReports.SelectedItem.ToString())
        End If
    End Sub

    ' --- DELETE / TRASH LOGIC (Ginamit ang index 0 para sa record_id) ---
    Private Sub BtnDeleteReport_Click(sender As Object, e As EventArgs) Handles btnDeleteReport.Click
        If dgvReports.SelectedRows.Count = 0 Then
            MessageBox.Show("Mangyaring pumili ng record sa listahan na nais mong tanggalin.", "Selection Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirmResult = MessageBox.Show("Sigurado ka bang gusto mong ilipat ang violation record na ito sa Trash Bin?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.Yes Then
            Try
                Dim selectedRow As DataGridViewRow = dgvReports.SelectedRows(0)

                If selectedRow.Cells(0).Value Is Nothing Then Return
                Dim recordId As String = selectedRow.Cells(0).Value.ToString()

                Using conn As OdbcConnection = GetConnection()
                    conn.Open()

                    Dim updateQuery As String = "UPDATE tbl_violation_records SET status = 'Archived', deleted_from = 'Reports Form' WHERE record_id = ?"
                    Using cmd As New OdbcCommand(updateQuery, conn)
                        cmd.Parameters.AddWithValue("?", recordId)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Matagumpay na nailipat ang record sa Trash Bin.", "Tagumpay", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadReports(cmbFilterReports.SelectedItem.ToString())

            Catch ex As Exception
                MessageBox.Show("Error sa pag-delete ng record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' --- PRINT FUNCTIONALITY ---
    Private Sub BtnPrintReport_Click(sender As Object, e As EventArgs) Handles btnPrintReport.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fontTitle As New Font("Segoe UI", 16, FontStyle.Bold)
        Dim fontHeader As New Font("Segoe UI", 9, FontStyle.Bold)
        Dim fontRow As New Font("Segoe UI", 8, FontStyle.Regular)
        Dim fontSign As New Font("Segoe UI", 9, FontStyle.Bold)

        Dim startX As Integer = 40
        Dim startY As Integer = 40

        e.Graphics.DrawString("CSTA - OFFICIAL VIOLATION REPORTS", fontTitle, Brushes.Maroon, startX, startY)
        e.Graphics.DrawString("Filter: " & cmbFilterReports.SelectedItem.ToString() & " | Date Generated: " & DateTime.Now.ToString("MMM dd, yyyy"), New Font("Segoe UI", 9, FontStyle.Italic), Brushes.Gray, startX, startY + 35)

        Dim yPos As Integer = startY + 75
        Dim xPos As Integer = startX

        For Each col As DataGridViewColumn In dgvReports.Columns
            e.Graphics.DrawString(col.HeaderText, fontHeader, Brushes.Black, xPos, yPos)
            xPos += 85
        Next

        yPos += 20
        e.Graphics.DrawLine(Pens.Black, startX, yPos, 1050, yPos)
        yPos += 10

        For Each row As DataGridViewRow In dgvReports.Rows
            If row.IsNewRow Then Continue For
            xPos = startX
            For Each cell As DataGridViewCell In row.Cells
                Dim cellValue As String = If(cell.Value IsNot Nothing, cell.Value.ToString(), "")
                If cellValue.Length > 12 Then cellValue = cellValue.Substring(0, 10) & ".."
                e.Graphics.DrawString(cellValue, fontRow, Brushes.Black, xPos, yPos)
                xPos += 85
            Next
            yPos += 22

            If yPos > e.MarginBounds.Bottom + 350 Then
                e.HasMorePages = True
                Return
            End If
        Next

        yPos += 50
        If yPos > 650 Then yPos = 650

        Dim signWidth As Integer = 220

        e.Graphics.DrawLine(Pens.Black, 50, yPos, 50 + signWidth, yPos)
        e.Graphics.DrawString("Noted by: OSA Officer", fontSign, Brushes.Black, 50, yPos + 5)

        e.Graphics.DrawLine(Pens.Black, 350, yPos, 350 + signWidth, yPos)
        e.Graphics.DrawString("Affirmed by: Dean", fontSign, Brushes.Black, 350, yPos + 5)

        e.HasMorePages = False
    End Sub

    ' --- NAVIGATION MENU ---
    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Dim dashboardForm As New DashboardForm()
        dashboardForm.Show()
        Me.Close()
    End Sub

    Private Sub StudentListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentListToolStripMenuItem.Click
        Dim studentListForm As New StudentListForm()
        studentListForm.Show()
        Me.Close()
    End Sub

    Private Sub DigitalSlipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DigitalSlipToolStripMenuItem.Click
        ReportByOSAOfficerToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ViolationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViolationsToolStripMenuItem.Click
        Dim violationForm As New ViolationsForm()
        violationForm.Show()
        Me.Close()
    End Sub

    Private Sub ReportByOSAOfficerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportByOSAOfficerToolStripMenuItem.Click
        Dim violationForm As New DigitalViolationForm()
        violationForm.Show()
        Me.Close()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogoutUser(Me)
    End Sub

    Private Sub BtnTrashBim_Click(sender As Object, e As EventArgs) Handles btnTrashBim.Click
        Dim trashForm As New TrashBinForm()
        trashForm.Show()
        Me.Hide()
    End Sub

End Class