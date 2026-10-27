Imports System.Data.Odbc

Public Class TrashBinForm

    Private Sub TrashBinForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        VbConnect()
        dgvTrash.AutoGenerateColumns = False

        ' I-setup ang Filter ComboBox para sa mga Kurso
        SetupFilterComboBox()

        ' I-load ang mga naka-archive na records
        LoadArchivedRecords()
    End Sub

    ' --- SETUP NG FILTER COMBOBOX ---
    Private Sub SetupFilterComboBox()
        cmbFilterTrash.Items.Clear()
        cmbFilterTrash.Items.Add("All Courses")
        cmbFilterTrash.Items.Add("BSIT")
        cmbFilterTrash.Items.Add("BSHM")
        cmbFilterTrash.Items.Add("BSTM")
        cmbFilterTrash.Items.Add("BSED")
        cmbFilterTrash.SelectedIndex = 0
    End Sub

    ' --- LOAD ARCHIVED RECORDS (May kasamang Course Filter) ---
    Private Sub LoadArchivedRecords()
        Try
            Using conn As OdbcConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT record_id, student_number, student_name, program, year_section, violation_type, offense_count, punishment_category, status, created_at, deleted_from FROM tbl_violation_records WHERE status = 'Archived'"

                Dim selectedCourse As String = If(cmbFilterTrash.SelectedItem IsNot Nothing, cmbFilterTrash.SelectedItem.ToString(), "All Courses")

                If selectedCourse <> "All Courses" Then
                    query &= " AND program = '" & selectedCourse & "'"
                End If

                query &= " ORDER BY created_at DESC"

                Using adapter As New OdbcDataAdapter(query, conn)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvTrash.DataSource = dt
                End Using
            End Using

            ' Itago ang ID column kung naroon
            If dgvTrash.Columns.Contains("ColumnID") Then
                dgvTrash.Columns("ColumnID").Visible = False
            End If

        Catch ex As Exception
            MessageBox.Show("Error sa pag-load ng archived records: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmbFilterTrash_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterTrash.SelectedIndexChanged
        LoadArchivedRecords()
    End Sub

    ' --- RESTORE RECORD LOGIC ---
    Private Sub BtnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        If dgvTrash.SelectedRows.Count = 0 Then
            MessageBox.Show("Mangyaring pumili muna ng rekord mula sa listahan na nais mong i-restore.", "Selection Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvTrash.SelectedRows(0)
        If selectedRow.Cells("ColumnID").Value Is Nothing Then Return

        Dim recordId As String = selectedRow.Cells("ColumnID").Value.ToString()
enicStudentName: Dim studentName As String = If(selectedRow.Cells("Column2").Value IsNot Nothing, selectedRow.Cells("Column2").Value.ToString(), "Student")

        Dim confirmResult As DialogResult = MessageBox.Show("Gusto mo bang i-restore ang violation record para kay " & studentName & "?", "Confirm Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            Try
                Using conn As OdbcConnection = GetConnection()
                    conn.Open()
                    Dim updateQuery As String = "UPDATE tbl_violation_records SET status = 'Active', deleted_from = NULL WHERE record_id = ?"
                    Using cmd As New OdbcCommand(updateQuery, conn)
                        cmd.Parameters.AddWithValue("?", recordId)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Matagumpay na naibalik (na-restore) ang rekord sa main list.", "Tagumpay", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadArchivedRecords()

            Catch ex As Exception
                MessageBox.Show("Error sa pag-restore ng record: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' --- BACK BUTTON LOGIC ---
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim violationsForm As New ViolationsForm()
        violationsForm.Show()
        Me.Close()
    End Sub

End Class