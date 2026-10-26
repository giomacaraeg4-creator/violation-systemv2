Imports System.Data.Odbc

Public Class RegistrationRequestsForm

    Private Sub RegistrationRequestsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VbConnect()
        LoadPendingRequests()
    End Sub

    ' --- KUNIN ANG MGA PENDING USERS MULA SA tbl_users ---
    Private Sub LoadPendingRequests()
        Try
            Using conn As OdbcConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT user_id, username, user_role, status FROM tbl_users WHERE status = 'Pending'"

                Using adapter As New OdbcDataAdapter(query, conn)
                    Dim dt As New DataTable()
                    dgvRequests.Columns.Clear()
                    dgvRequests.AutoGenerateColumns = True
                    adapter.Fill(dt)
                    dgvRequests.DataSource = dt
                End Using
            End Using

            ' Ayusin ang mga header ng kolum
            If dgvRequests.Columns.Contains("user_id") Then dgvRequests.Columns("user_id").Visible = False
            If dgvRequests.Columns.Contains("username") Then dgvRequests.Columns("username").HeaderText = "Username"
            If dgvRequests.Columns.Contains("user_role") Then dgvRequests.Columns("user_role").HeaderText = "Role"
            If dgvRequests.Columns.Contains("status") Then dgvRequests.Columns("status").HeaderText = "Status"

            dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvRequests.RowHeadersVisible = False

        Catch ex As Exception
            MessageBox.Show("Error sa pagkuha ng mga request: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- APPROVE / CONFIRM BUTTON ---
    Private Sub BtnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        If dgvRequests.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvRequests.SelectedRows(0)
            If selectedRow.Cells("user_id").Value Is Nothing Then Return

            Dim userId As String = selectedRow.Cells("user_id").Value.ToString()
            Dim username As String = selectedRow.Cells("username").Value.ToString()

            Dim result As DialogResult = MessageBox.Show("Gusto mo bang aprubahan at bigyan ng access ang account para kay '" & username & "'?", "Confirm Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    Using conn As OdbcConnection = GetConnection()
                        conn.Open()
                        Dim updateQuery As String = "UPDATE tbl_users SET status = 'Active' WHERE user_id = ?"
                        Using cmd As New OdbcCommand(updateQuery, conn)
                            cmd.Parameters.AddWithValue("?", userId)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Tagumpay! Na-aprubahan na ang account.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadPendingRequests() ' Refresh list

                Catch ex As Exception
                    MessageBox.Show("Error sa pag-apruba ng account: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Mangyaring pumili muna ng user mula sa listahan.", "Babala", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' --- REFRESH BUTTON ---
    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadPendingRequests()
    End Sub

    ' --- BACK BUTTON ---
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dashboard As New DashboardForm()
        dashboard.Show()
        Me.Close()
    End Sub

End Class