Imports System.Data.Odbc

Public Class ViolationsForm

    Private Sub ViolationsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        VbConnect()
        dgvRecent.AutoGenerateColumns = False
        LoadViolationsData()
    End Sub

    ' --- 1. KUNIN AT ILAGAY ANG MGA RECORDS SA DATAGRIDVIEW ---
    Private Sub LoadViolationsData()
        Try
            Using conn As OdbcConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT record_id, student_number, student_name, program, year_section, violation_type, offense_count, punishment_category, status, created_at FROM tbl_violation_records WHERE status != 'Archived' ORDER BY created_at DESC"

                Using adapter As New OdbcDataAdapter(query, conn)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvRecent.DataSource = dt
                End Using
            End Using

            FormatDataGridView()

        Catch ex As Exception
            MessageBox.Show("Error sa pagkarga ng mga records: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- 2. PAG-AYOS NG MGA HEADER NG DATAGRIDVIEW ---
    Private Sub FormatDataGridView()
        If dgvRecent.Columns.Contains("record_id") Then dgvRecent.Columns("record_id").Visible = False
        If dgvRecent.Columns.Contains("student_number") Then dgvRecent.Columns("student_number").HeaderText = "Student No."
        If dgvRecent.Columns.Contains("student_name") Then dgvRecent.Columns("student_name").HeaderText = "Student Name"
        If dgvRecent.Columns.Contains("program") Then dgvRecent.Columns("program").HeaderText = "Program"
        If dgvRecent.Columns.Contains("year_section") Then dgvRecent.Columns("year_section").HeaderText = "Year & Section"
        If dgvRecent.Columns.Contains("violation_type") Then dgvRecent.Columns("violation_type").HeaderText = "Violation Type"
        If dgvRecent.Columns.Contains("offense_count") Then dgvRecent.Columns("offense_count").HeaderText = "Offense Count"
        If dgvRecent.Columns.Contains("punishment_category") Then dgvRecent.Columns("punishment_category").HeaderText = "Punishment"
        If dgvRecent.Columns.Contains("status") Then dgvRecent.Columns("status").HeaderText = "Status"
        If dgvRecent.Columns.Contains("created_at") Then dgvRecent.Columns("created_at").HeaderText = "Date Recorded"

        dgvRecent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRecent.RowHeadersVisible = False
    End Sub

    ' --- 3. SEARCH BUTTON LOGIC ---
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim keyword As String = txtSearch.Text.Trim()

        If String.IsNullOrEmpty(keyword) OrElse keyword = "Search by Student Number" Then
            LoadViolationsData()
            Return
        End If

        Try
            Using conn As OdbcConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT record_id, student_number, student_name, program, year_section, violation_type, offense_count, punishment_category, status, created_at FROM tbl_violation_records WHERE (student_number LIKE ? OR student_name LIKE ?) AND status != 'Archived'"

                Using adapter As New OdbcDataAdapter(query, conn)
                    adapter.SelectCommand.Parameters.AddWithValue("?", "%" & keyword & "%")
                    adapter.SelectCommand.Parameters.AddWithValue("?", "%" & keyword & "%")
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvRecent.DataSource = dt

                    If dt.Rows.Count = 0 Then
                        MessageBox.Show("Walang nahanap na rekord para sa hinahanap mo.", "Walang Resulta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error sa pag-search: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- 4. SEARCH PLACEHOLDER LOGIC ---
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

    ' --- 5. ADD VIOLATION RECORD BUTTON ---
    Private Sub BtnAddviolation_Click(sender As Object, e As EventArgs) Handles btnAddviolation.Click
        Dim addForm As New AddViolationModalForm()

        ' Kung may piniling row sa DataGridView, ipasa natin ang Student Number nito
        If dgvRecent.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvRecent.SelectedRows(0)
            If selectedRow.Cells("student_number").Value IsNot Nothing Then
                addForm.PreloadedStudentNumber = selectedRow.Cells("student_number").Value.ToString()
            End If
        End If

        If addForm.ShowDialog() = DialogResult.OK Then
            ' I-refresh ang listahan ng violations dito
            LoadViolationsData()
        End If
    End Sub

    ' --- 6. DOUBLE CLICK SA ROW ---
    Private Sub DgvRecent_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecent.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvRecent.Rows(e.RowIndex)

            Dim sNum As String = If(row.Cells("student_number").Value IsNot Nothing, row.Cells("student_number").Value.ToString(), "")
            Dim sName As String = If(row.Cells("student_name").Value IsNot Nothing, row.Cells("student_name").Value.ToString(), "")
            Dim sProg As String = If(row.Cells("program").Value IsNot Nothing, row.Cells("program").Value.ToString(), "")
            Dim sYear As String = If(row.Cells("year_section").Value IsNot Nothing, row.Cells("year_section").Value.ToString(), "")

            Dim violationForm As New DigitalViolationForm(sNum, sName, sProg, sYear)
            violationForm.Show()
            Me.Close()
        End If
    End Sub

    ' --- 7. DELETE / ARCHIVE BUTTON LOGIC (Ginamit ang index 0 para sa ID at index 2 para sa Pangalan) ---
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvRecent.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvRecent.SelectedRows(0)

            If selectedRow.Cells(0).Value Is Nothing Then Return

            Dim recordId As String = selectedRow.Cells(0).Value.ToString()
            Dim studentName As String = If(selectedRow.Cells(2).Value IsNot Nothing, selectedRow.Cells(2).Value.ToString(), "Student")

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
                    MessageBox.Show("Error sa pag-delete ng record: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Mangyaring pumili muna ng rekord mula sa listahan na gusto mong i-delete.", "Babala", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' --- 8. TRASH BIN BUTTON LOGIC ---
    Private Sub BtnTrashBin_Click(sender As Object, e As EventArgs) Handles btnTrashBin.Click
        Dim trashForm As New TrashBinForm()
        trashForm.Show()
        Me.Hide()
    End Sub

    ' --- 9. NAVIGATION MENU ---
    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Dim dash As New DashboardForm()
        dash.Show()
        Me.Hide()
    End Sub

    Private Sub ViolationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViolationsToolStripMenuItem.Click
        LoadViolationsData()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        Dim reportsForm As New ReportsForm()
        reportsForm.Show()
        Me.Hide()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogoutUser(Me)
    End Sub

    Private Sub StudentListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentListToolStripMenuItem.Click
        Dim studentListForm As New StudentListForm()
        studentListForm.Show()
        Me.Hide()
    End Sub

    Private Sub DigitalSlipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DigitalSlipToolStripMenuItem.Click
        Dim violationForm As New DigitalViolationForm()
        violationForm.Show()
        Me.Hide()
    End Sub

    Private Sub BtnPendingslip_Click(sender As Object, e As EventArgs) Handles btnPendingslip.Click
        Dim pendingviolationForm As New PendingViolationsForm()
        pendingviolationForm.Show()
        Me.Hide()
    End Sub
End Class