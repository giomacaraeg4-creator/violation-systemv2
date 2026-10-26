Imports System.Data.Odbc

Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrWhiteSpace(TxtUser.Text) OrElse TxtUser.Text = "UserName" Then
            TxtUser.Text = "UserName"
            TxtUser.ForeColor = Color.Gray
        End If

        If String.IsNullOrWhiteSpace(TxtPass.Text) OrElse TxtPass.Text = "Password" Then
            TxtPass.Text = "Password"
            TxtPass.ForeColor = Color.Gray
            TxtPass.UseSystemPasswordChar = False
        End If

        Me.ActiveControl = PictureBox1
    End Sub

    Private Sub TxtUser_Enter(sender As Object, e As EventArgs) Handles TxtUser.Enter
        If TxtUser.Text = "UserName" Then
            TxtUser.Text = ""
            TxtUser.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtUser_Leave(sender As Object, e As EventArgs) Handles TxtUser.Leave
        If String.IsNullOrWhiteSpace(TxtUser.Text) Then
            TxtUser.Text = "UserName"
            TxtUser.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TxtPass_Enter(sender As Object, e As EventArgs) Handles TxtPass.Enter
        If TxtPass.Text = "Password" Then
            TxtPass.Text = ""
            TxtPass.ForeColor = Color.Black
            TxtPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TxtPass_Leave(sender As Object, e As EventArgs) Handles TxtPass.Leave
        If String.IsNullOrWhiteSpace(TxtPass.Text) Then
            TxtPass.Text = "Password"
            TxtPass.ForeColor = Color.Gray
            TxtPass.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub BtnEye_Click(sender As Object, e As EventArgs) Handles BtnEye.Click
        If TxtPass.Text <> "Password" AndAlso Not String.IsNullOrEmpty(TxtPass.Text) Then
            TxtPass.UseSystemPasswordChar = Not TxtPass.UseSystemPasswordChar

            If TxtPass.UseSystemPasswordChar Then
                BtnEye.Text = "👁"
            Else
                BtnEye.Text = "👁‍🗨"
            End If
        End If
    End Sub

    Private Sub BtnLogin1_Click(sender As Object, e As EventArgs) Handles BtnLogin1.Click
        Dim username As String = TxtUser.Text.Trim()
        Dim password As String = TxtPass.Text.Trim()

        If username = "" OrElse username = "UserName" OrElse password = "" OrElse password = "Password" Then
            MessageBox.Show("Mangyaring ilagay ang iyong Username at Password.", "Login Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As OdbcConnection = GetConnection()
                conn.Open()

                Dim query As String = "SELECT COUNT(*) FROM tbl_users WHERE username = ? AND password_hash = ? AND status = 'Active'"

                Using cmd As New OdbcCommand(query, conn)
                    cmd.Parameters.AddWithValue("?", username)
                    cmd.Parameters.AddWithValue("?", password)

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then
                        MessageBox.Show("Matagumpay ang pag-login!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' I-log ang aksyon
                        LogAction("LOGIN", "Nag-log in ang admin na si " & username)

                        ' ➔ DIRECT TO DASHBOARD FORM MUNA (HINDI SA REQUESTS FORM)
                        Dim dash As New DashboardForm()
                        dash.Show()
                        Me.Hide()
                    Else
                        Dim checkPendingQuery As String = "SELECT COUNT(*) FROM tbl_users WHERE username = ? AND status = 'Pending'"
                        Using cmdCheck As New OdbcCommand(checkPendingQuery, conn)
                            cmdCheck.Parameters.AddWithValue("?", username)
                            Dim pendingCount As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

                            If pendingCount > 0 Then
                                MessageBox.Show("Ang iyong account ay naghihintay pa ng aprubal ng Admin (Pending).", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Else
                                MessageBox.Show("Mali ang Username o Password, o kaya ay hindi aktibo ang account.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End Using
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("May error sa koneksyon o database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Dim regForm As New RegisterForm()
        regForm.Show()
        Me.Hide()
    End Sub

End Class