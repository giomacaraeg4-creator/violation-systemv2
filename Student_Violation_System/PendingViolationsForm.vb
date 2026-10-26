Imports System.Data.Odbc

Public Class PendingViolationsForm

    Private Sub PendingViolationsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        VbConnect()

        ' Siguraduhing naka-enable ang auto-generate
        dgvPending.AutoGenerateColumns = True

        LoadPendingRecords()
    End Sub

    ' --- KUNIN ANG MGA RECORDS NA MAY STATUS NA PENDING ---
    Private Sub LoadPendingRecords()
        Try
            Using conn As OdbcConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT record_id, student_number, student_name, program, year_section, violation_type, offense_count, punishment_category, status, created_at FROM tbl_violation_records WHERE status = 'Pending' ORDER BY created_at DESC"

                Using adapter As New OdbcDataAdapter(query, conn)
                    Dim dt As New DataTable()

                    ' 1. Linisin muna ang lumang columns para hindi magpatong o madoble
                    dgvPending.Columns.Clear()

                    ' 2. Punuin ang DataTable at i-bind sa DataGridView
                    adapter.Fill(dt)
                    dgvPending.DataSource = dt
                End Using
            End Using

            FormatPendingGridView()

        Catch ex As Exception
            MessageBox.Show("May error sa pagkuha ng pending records: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- PAG-AYOS NG MGA HEADER NG DATAGRIDVIEW ---
    Private Sub FormatPendingGridView()
        If dgvPending.Columns.Contains("record_id") Then dgvPending.Columns("record_id").Visible = False
        If dgvPending.Columns.Contains("student_number") Then dgvPending.Columns("student_number").HeaderText = "Student Number"
        If dgvPending.Columns.Contains("student_name") Then dgvPending.Columns("student_name").HeaderText = "Student Name"
        If dgvPending.Columns.Contains("program") Then dgvPending.Columns("program").HeaderText = "Program"
        If dgvPending.Columns.Contains("year_section") Then dgvPending.Columns("year_section").HeaderText = "Year & Section"
        If dgvPending.Columns.Contains("violation_type") Then dgvPending.Columns("violation_type").HeaderText = "Violation Type"
        If dgvPending.Columns.Contains("offense_count") Then dgvPending.Columns("offense_count").HeaderText = "Offense Count"
        If dgvPending.Columns.Contains("punishment_category") Then dgvPending.Columns("punishment_category").HeaderText = "Punishment"
        If dgvPending.Columns.Contains("status") Then dgvPending.Columns("status").HeaderText = "Status"
        If dgvPending.Columns.Contains("created_at") Then dgvPending.Columns("created_at").HeaderText = "Date Recorded"

        dgvPending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPending.RowHeadersVisible = False
    End Sub

    ' --- REFRESH BUTTON ---
    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadPendingRecords()
    End Sub

    ' --- BACK TO DASHBOARD ---
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim violationsForm As New ViolationsForm()
        violationsForm.Show()
        Me.Close()
    End Sub

    ' --- COMPLETE BUTTON ---
    Private Sub BtnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        If dgvPending.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvPending.SelectedRows(0)

            If selectedRow.Cells("record_id").Value Is Nothing Then Return

            Dim recordId As String = selectedRow.Cells("record_id").Value.ToString()
            Dim studentName As String = If(selectedRow.Cells("student_name").Value IsNot Nothing, selectedRow.Cells("student_name").Value.ToString(), "Student")

            Dim result As DialogResult = MessageBox.Show("Gusto mo bang markahan bilang 'Completed' ang violation slip para kay " & studentName & "?", "Confirm Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    Using conn As OdbcConnection = GetConnection()
                        conn.Open()
                        Dim updateQuery As String = "UPDATE tbl_violation_records SET status = 'Completed' WHERE record_id = ?"

                        Using cmd As New OdbcCommand(updateQuery, conn)
                            cmd.Parameters.AddWithValue("?", recordId)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Tagumpay! Ang violation record ay na-update na bilang Completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadPendingRecords() ' Refresh list

                Catch ex As Exception
                    MessageBox.Show("Error sa pag-update ng status: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Mangyaring pumili muna ng rekord mula sa listahan.", "Babala", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class