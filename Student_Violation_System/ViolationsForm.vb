Imports System.Data.Odbc

Public Class ViolationsForm

    Private Sub ViolationsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        VbConnect()
        dgvRecent.AutoGenerateColumns = False
        dgvRecent.ReadOnly = False

        SetupFilterComboBox()
        LoadViolationsData()
    End Sub

    Private Sub SetupFilterComboBox()
        cmbFilterProgram.Items.Clear()
        cmbFilterProgram.Items.Add("All")
        cmbFilterProgram.Items.Add("BSIT")
        cmbFilterProgram.Items.Add("BSHM")
        cmbFilterProgram.Items.Add("BSTM")
        cmbFilterProgram.Items.Add("BSED")
        cmbFilterProgram.SelectedIndex = 0
    End Sub

    Private Sub LoadViolationsData()
        Try
            dgvRecent.Rows.Clear()

            Using conn As OdbcConnection = GetConnection()
                conn.Open()

                Dim query As String = "SELECT DISTINCT student_number, student_name, program, year_section FROM tbl_violation_records WHERE status != 'Archived'"

                Dim selectedCourse As String = If(cmbFilterProgram.SelectedItem IsNot Nothing, cmbFilterProgram.SelectedItem.ToString(), "All")
                Dim keyword As String = txtSearch.Text.Trim()

                Dim conditions As New List(Of String)

                If selectedCourse <> "All" Then
                    conditions.Add("program = '" & selectedCourse & "'")
                End If

                If Not String.IsNullOrEmpty(keyword) AndAlso keyword <> "Search by Student Number" Then
                    conditions.Add("(student_number LIKE '%" & keyword & "%' OR student_name LIKE '%" & keyword & "%')")
                End If

                If conditions.Count > 0 Then
                    query &= " AND " & String.Join(" AND ", conditions)
                End If

                Using cmd As New OdbcCommand(query, conn)
                    Using reader As OdbcDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim sNum As String = reader("student_number").ToString()
                            Dim sName As String = reader("student_name").ToString()
                            Dim sProg As String = reader("program").ToString()
                            Dim sYear As String = reader("year_section").ToString()

                            Dim violationList As New List(Of Dictionary(Of String, String))()
                            Dim subQuery As String = "SELECT record_id, violation_type, offense_count, punishment_category, endorsed_by_prof, created_at FROM tbl_violation_records WHERE student_number = ? AND status != 'Archived' ORDER BY created_at DESC"

                            Using subCmd As New OdbcCommand(subQuery, conn)
                                subCmd.Parameters.AddWithValue("?", sNum)
                                Using subReader As OdbcDataReader = subCmd.ExecuteReader()
                                    While subReader.Read()
                                        Dim item As New Dictionary(Of String, String)()
                                        item("record_id") = subReader("record_id").ToString()
                                        item("violation_type") = subReader("violation_type").ToString()
                                        item("offense_count") = subReader("offense_count").ToString()
                                        item("punishment_category") = subReader("punishment_category").ToString()
                                        item("endorsed_by_prof") = subReader("endorsed_by_prof").ToString()
                                        item("created_at") = Convert.ToDateTime(subReader("created_at")).ToString("yyyy-MM-dd hh:mm tt")
                                        violationList.Add(item)
                                    End While
                                End Using
                            End Using

                            If violationList.Count > 0 Then
                                Dim latestRecord = violationList(0)

                                Dim rowIndex As Integer = dgvRecent.Rows.Add()
                                Dim row As DataGridViewRow = dgvRecent.Rows(rowIndex)

                                row.Cells("ID").Value = latestRecord("record_id")
                                row.Cells("student_number").Value = sNum
                                row.Cells("student_name").Value = sName
                                row.Cells("program").Value = sProg
                                row.Cells("year_section").Value = sYear

                                row.Cells("student_number").ReadOnly = True
                                row.Cells("student_name").ReadOnly = True
                                row.Cells("program").ReadOnly = True
                                row.Cells("year_section").ReadOnly = True

                                SetIndependentComboBoxCell(row, "violation_type", violationList, "violation_type", latestRecord("violation_type"))
                                SetIndependentComboBoxCell(row, "offense_count", violationList, "offense_count", latestRecord("offense_count"))
                                SetIndependentComboBoxCell(row, "punishment_category", violationList, "punishment_category", latestRecord("punishment_category"))
                                SetIndependentComboBoxCell(row, "endorsed_by_prof", violationList, "endorsed_by_prof", latestRecord("endorsed_by_prof"))
                                SetIndependentComboBoxCell(row, "created_at", violationList, "created_at", latestRecord("created_at"))

                                row.Tag = violationList
                            End If

                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error sa pagkarga ng mga records: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SetIndependentComboBoxCell(row As DataGridViewRow, columnName As String, list As List(Of Dictionary(Of String, String)), key As String, defaultValue As String)
        Dim colIndex As Integer = dgvRecent.Columns(columnName).Index
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

    Private Sub DgvRecent_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecent.CellValueChanged
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim row As DataGridViewRow = dgvRecent.Rows(e.RowIndex)
            Dim violationList = TryCast(row.Tag, List(Of Dictionary(Of String, String)))

            If violationList IsNot Nothing AndAlso violationList.Count > 0 Then

                Dim selectedDateCell As DataGridViewComboBoxCell = TryCast(row.Cells("created_at"), DataGridViewComboBoxCell)
                If selectedDateCell IsNot Nothing AndAlso selectedDateCell.Value IsNot Nothing Then
                    Dim selectedDate As String = selectedDateCell.Value.ToString()

                    For Each item In violationList
                        If item("created_at") = selectedDate Then
                            row.Cells("ID").Value = item("record_id")
                            row.Cells("violation_type").Value = item("violation_type")
                            row.Cells("offense_count").Value = item("offense_count")
                            row.Cells("punishment_category").Value = item("punishment_category")
                            row.Cells("endorsed_by_prof").Value = item("endorsed_by_prof")
                            Exit For
                        End If
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub DgvRecent_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvRecent.CurrentCellDirtyStateChanged
        If dgvRecent.IsCurrentCellDirty Then
            dgvRecent.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadViolationsData()
    End Sub

    Private Sub CmbFilterProgram_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterProgram.SelectedIndexChanged
        LoadViolationsData()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Text = "Search by Student Number"
        txtSearch.ForeColor = Color.Gray
        cmbFilterProgram.SelectedIndex = 0
        LoadViolationsData()
    End Sub

    Private Sub TxtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        If txtSearch.Text = "Search by Student Number" Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If String.IsNullOrWhiteSpace(txtSearch.Text) Then
            txtSearch.Text = "Search by Student Number"
            txtSearch.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub BtnAddviolation_Click(sender As Object, e As EventArgs) Handles btnAddviolation.Click
        If dgvRecent.SelectedRows.Count > 0 Then

            Dim selectedRow As DataGridViewRow = dgvRecent.SelectedRows(0)

            Dim sNum As String = If(selectedRow.Cells("student_number").Value IsNot Nothing, selectedRow.Cells("student_number").Value.ToString(), "")
            Dim sName As String = If(selectedRow.Cells("student_name").Value IsNot Nothing, selectedRow.Cells("student_name").Value.ToString(), "")
            Dim sProg As String = If(selectedRow.Cells("program").Value IsNot Nothing, selectedRow.Cells("program").Value.ToString(), "")
            Dim sYear As String = If(selectedRow.Cells("year_section").Value IsNot Nothing, selectedRow.Cells("year_section").Value.ToString(), "")

            Dim digitalForm As New DigitalViolationForm(sNum, sName, sProg, sYear)
            digitalForm.Show()
            Me.Close()
        Else
            Dim violationForm As New DigitalViolationForm()
            violationForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub DgvRecent_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecent.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvRecent.Rows(e.RowIndex)

            Dim sNum As String = If(row.Cells("student_number").Value IsNot Nothing, row.Cells("student_number").Value.ToString(), "")
            Dim sName As String = If(row.Cells("student_name").Value IsNot Nothing, row.Cells("student_name").Value.ToString(), "")
            Dim sProg As String = If(row.Cells("program").Value IsNot Nothing, row.Cells("program").Value.ToString(), "")
            Dim sYear As String = If(row.Cells("year_section").Value IsNot Nothing, row.Cells("year_section").Value.ToString(), "")

            Dim digitalForm As New DigitalViolationForm(sNum, sName, sProg, sYear)
            digitalForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvRecent.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvRecent.SelectedRows(0)

            If selectedRow.Cells("ID").Value Is Nothing Then Return

            Dim recordId As String = selectedRow.Cells("ID").Value.ToString()

            Dim studentName As String = If(selectedRow.Cells("student_name").Value IsNot Nothing, selectedRow.Cells("student_name").Value.ToString(), "Student")

            Dim confirmResult As DialogResult = MessageBox.Show("Gusto mo bang ilipat sa Trash Bin ang violation record para kay " & studentName & "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If confirmResult = DialogResult.Yes Then
                Try
                    Using conn As OdbcConnection = GetConnection()
                        conn.Open()
                        Dim updateQuery As String = "UPDATE tbl_violation_records SET status = 'Archived', deleted_from = 'Violations Form' WHERE record_id = ?"
                        Using cmd As New OdbcCommand(updateQuery, conn)
                            cmd.Parameters.AddWithValue("?", recordId)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Matagumpay na nailipat ang rekord sa Trash Bin.", "Tagumpay", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadViolationsData()

                Catch ex As Exception
                    MessageBox.Show("Error sa pag delete ng record: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Pumili muna ng rekord mula sa listahan na gusto mong i-delete.", "Babala", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnTrashBin_Click(sender As Object, e As EventArgs) Handles btnTrashBin.Click
        Dim trashForm As New TrashBinForm()
        trashForm.Show()
        Me.Hide()
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Dim dash As New DashboardForm()
        dash.Show()
        Me.Hide()
    End Sub

    Private Sub ViolationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViolationsToolStripMenuItem.Click
        LoadViolationsData()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        Dim reportsForm As New ReportsForm()
        reportsForm.Show()
        Me.Hide()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogoutUser(Me)
    End Sub

    Private Sub DigitalSlipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DigitalSlipToolStripMenuItem.Click

        Dim violationForm As New DigitalViolationForm()
        violationForm.Show()
        Me.Hide()
    End Sub

End Class