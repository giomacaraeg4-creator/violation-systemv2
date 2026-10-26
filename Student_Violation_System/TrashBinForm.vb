Imports System.Data.Odbc

Public Class TrashBinForm

    Private Sub TrashBinForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        VbConnect()

        ' Hayaan nating i-generate ng auto ang mga kolum mula sa database query
        dgvTrash.AutoGenerateColumns = True

        ' --- GAWING BAWAL MA-EDIT AT MAGDAGDAG NG ROW ---
        dgvTrash.ReadOnly = True
        dgvTrash.AllowUserToAddRows = False
        dgvTrash.AllowUserToDeleteRows = False
        dgvTrash.AllowUserToResizeRows = False

        LoadArchivedRecords()
    End Sub

    ' --- KUNIN ANG MGA NAKA-ARCHIVE NA RECORDS ---
    Private Sub LoadArchivedRecords()
        Try
            Using conn As OdbcConnection = GetConnection()
                conn.Open()
                ' Kasama na ang deleted_from sa query para lumitaw sa Trash Bin
                Dim query As String = "SELECT record_id, student_number, student_name, program, year_section, violation_type, offense_count, punishment_category, status, deleted_from, created_at FROM tbl_violation_records WHERE status = 'Archived' ORDER BY created_at DESC"

                Using adapter As New OdbcDataAdapter(query, conn)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvTrash.DataSource = dt
                End Using
            End Using

            ' Itago ang ID pero panatilihing magamit ang value nito sa background
            If dgvTrash.Columns.Contains("record_id") Then
                dgvTrash.Columns("record_id").Visible = False
            End If

            ' Ayusin ang mga Header Text para maging malinis tingnan
            If dgvTrash.Columns.Contains("student_number") Then dgvTrash.Columns("student_number").HeaderText = "Student No."
            If dgvTrash.Columns.Contains("student_name") Then dgvTrash.Columns("student_name").HeaderText = "Student Name"
            If dgvTrash.Columns.Contains("program") Then dgvTrash.Columns("program").HeaderText = "Program"
            If dgvTrash.Columns.Contains("year_section") Then dgvTrash.Columns("year_section").HeaderText = "Year & Section"
            If dgvTrash.Columns.Contains("violation_type") Then dgvTrash.Columns("violation_type").HeaderText = "Violation Type"
            If dgvTrash.Columns.Contains("offense_count") Then dgvTrash.Columns("offense_count").HeaderText = "Offense Count"
            If dgvTrash.Columns.Contains("punishment_category") Then dgvTrash.Columns("punishment_category").HeaderText = "Punishment"
            If dgvTrash.Columns.Contains("status") Then dgvTrash.Columns("status").HeaderText = "Status"
            If dgvTrash.Columns.Contains("deleted_from") Then dgvTrash.Columns("deleted_from").HeaderText = "Deleted From"
            If dgvTrash.Columns.Contains("created_at") Then dgvTrash.Columns("created_at").HeaderText = "Date Recorded"

            dgvTrash.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvTrash.RowHeadersVisible = False

        Catch ex As Exception
            MessageBox.Show("Error sa pagkarga ng mga archived records: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- RESTORE BUTTON LOGIC (Gamit ang index para maiwasan ang column name error) ---
    Private Sub BtnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        If dgvTrash.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvTrash.SelectedRows(0)

            ' Sinisiguro natin na may laman ang record_id sa unang kolum (index 0)
            If selectedRow.Cells(0).Value Is Nothing Then Return

            Dim recordId As String = selectedRow.Cells(0).Value.ToString()
            ' Ang index 2 ay tumutukoy sa student_name batay sa pagkakasunod-sunod sa SQL SELECT query
            Dim studentName As String = If(selectedRow.Cells(2).Value IsNot Nothing, selectedRow.Cells(2).Value.ToString(), "Student")

            Dim confirmResult As DialogResult = MessageBox.Show("Gusto mo bang ibalik sa aktibong listahan ang violation record para kay " & studentName & "?", "Confirm Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmResult = DialogResult.Yes Then
                Try
                    Using conn As OdbcConnection = GetConnection()
                        conn.Open()
                        ' Ibalik sa Pending at i-clear ang deleted_from tag
                        Dim updateQuery As String = "UPDATE tbl_violation_records SET status = 'Pending', deleted_from = NULL WHERE record_id = ?"
                        Using cmd As New OdbcCommand(updateQuery, conn)
                            cmd.Parameters.AddWithValue("?", recordId)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Matagumpay na naibalik ang rekord sa aktibong listahan!", "Tagumpay", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadArchivedRecords()

                Catch ex As Exception
                    MessageBox.Show("Error sa pag-restore ng record: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Mangyaring pumili muna ng rekord mula sa Trash Bin na gusto mong ibalik.", "Babala", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' --- BACK BUTTON ---
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim violationsForm As New ViolationsForm()
        violationsForm.Show()
        Me.Close()
    End Sub

End Class