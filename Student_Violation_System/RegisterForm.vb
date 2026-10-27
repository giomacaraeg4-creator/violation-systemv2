Imports System.Data.Odbc

Public Class RegisterForm

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrWhiteSpace(txtUsername2.Text) OrElse txtUsername2.Text = "UserName" Then
            txtUsername2.Text = "UserName"
            txtUsername2.ForeColor = Color.Gray
        End If

        If String.IsNullOrWhiteSpace(txtPass2.Text) OrElse txtPass2.Text = "Password" Then
            txtPass2.Text = "Password"
            txtPass2.ForeColor = Color.Gray
            txtPass2.UseSystemPasswordChar = False
        End If

        If String.IsNullOrWhiteSpace(txtPass3.Text) OrElse txtPass3.Text = "Confirm Password" Then
            txtPass3.Text = "Confirm Password"
            txtPass3.ForeColor = Color.Gray
            txtPass3.UseSystemPasswordChar = False
        End If

        If ComboBox1.SelectedItem Is Nothing Then
            ComboBox1.Text = "Role"
            ComboBox1.ForeColor = Color.Gray
        End If

        Me.ActiveControl = PictureBox1
    End Sub

    Private Sub TxtUsername2_Enter(sender As Object, e As EventArgs) Handles txtUsername2.Enter
        If txtUsername2.Text = "UserName" Then
            txtUsername2.Text = ""
            txtUsername2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtUsername2_Leave(sender As Object, e As EventArgs) Handles txtUsername2.Leave
        If String.IsNullOrWhiteSpace(txtUsername2.Text) Then
            txtUsername2.Text = "UserName"
            txtUsername2.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TxtPass2_Enter(sender As Object, e As EventArgs) Handles txtPass2.Enter
        If txtPass2.Text = "Password" Then
            txtPass2.Text = ""
            txtPass2.ForeColor = Color.Black
            txtPass2.UseSystemPasswordChar = True
            btnEye2.Text = "👁‍🗨"
        End If
    End Sub

    Private Sub TxtPass2_Leave(sender As Object, e As EventArgs) Handles txtPass2.Leave
        If String.IsNullOrWhiteSpace(txtPass2.Text) Then
            txtPass2.Text = "Password"
            txtPass2.ForeColor = Color.Gray
            txtPass2.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub TxtPass3_Enter(sender As Object, e As EventArgs) Handles txtPass3.Enter
        If txtPass3.Text = "Confirm Password" Then
            txtPass3.Text = ""
            txtPass3.ForeColor = Color.Black
            txtPass3.UseSystemPasswordChar = True
            btnEye3.Text = "👁‍🗨"
        End If
    End Sub

    Private Sub TxtPass3_Leave(sender As Object, e As EventArgs) Handles txtPass3.Leave
        If String.IsNullOrWhiteSpace(txtPass3.Text) Then
            txtPass3.Text = "Confirm Password"
            txtPass3.ForeColor = Color.Gray
            txtPass3.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub BtnEye2_Click(sender As Object, e As EventArgs) Handles btnEye2.Click
        If txtPass2.Text <> "Password" AndAlso Not String.IsNullOrEmpty(txtPass2.Text) Then
            If txtPass2.UseSystemPasswordChar Then
                txtPass2.UseSystemPasswordChar = False
                btnEye2.Text = "👁"
            Else
                txtPass2.UseSystemPasswordChar = True
                btnEye2.Text = "👁‍🗨"
            End If
        End If
    End Sub

    Private Sub BtnEye3_Click(sender As Object, e As EventArgs) Handles btnEye3.Click
        If txtPass3.Text <> "Confirm Password" AndAlso Not String.IsNullOrEmpty(txtPass3.Text) Then
            If txtPass3.UseSystemPasswordChar Then
                txtPass3.UseSystemPasswordChar = False
                btnEye3.Text = "👁"
            Else
                txtPass3.UseSystemPasswordChar = True
                btnEye3.Text = "👁‍🗨"
            End If
        End If
    End Sub

    Private Sub ComboBox1_Enter(sender As Object, e As EventArgs) Handles ComboBox1.Enter
        If ComboBox1.Text = "Role" Then
            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim username As String = txtUsername2.Text.Trim()
        Dim password As String = txtPass2.Text.Trim()
        Dim confirmPass As String = txtPass3.Text.Trim()
        Dim role As String = ComboBox1.Text.Trim()

        If username = "" OrElse username = "UserName" OrElse
            password = "" OrElse password = "Password" OrElse
            confirmPass = "" OrElse confirmPass = "Confirm Password" OrElse
            role = "" OrElse role = "Role" Then
            MessageBox.Show("Mangyaring punan ang lahat ng kinakailangang impormasyon.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If password <> confirmPass Then
            MessageBox.Show("Hindi magkapareho ang Password at Confirm Password.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPass3.Focus()
            Return
        End If

        Try
            Using conn As OdbcConnection = GetConnection()
                conn.Open()

                Dim checkQuery As String = "SELECT COUNT(*) FROM tbl_users WHERE username = ?"
                Using checkCmd As New OdbcCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("?", username)
                    Dim existingCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If existingCount > 0 Then
                        MessageBox.Show("Ang Username na ito ay nagagamit na. Pumili ng iba.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                Dim countUsersQuery As String = "SELECT COUNT(*) FROM tbl_users"
                Dim totalUsers As Integer = 0
                Using countCmd As New OdbcCommand(countUsersQuery, conn)
                    totalUsers = Convert.ToInt32(countCmd.ExecuteScalar())
                End Using

                Dim accountStatus As String = If(totalUsers = 0, "Active", "Pending")

                Dim insertQuery As String = "INSERT INTO tbl_users (username, password_hash, full_name, role, status) VALUES (?, ?, ?, ?, ?)"
                Using cmd As New OdbcCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("?", username)
                    cmd.Parameters.AddWithValue("?", password)
                    cmd.Parameters.AddWithValue("?", username)
                    cmd.Parameters.AddWithValue("?", role)
                    cmd.Parameters.AddWithValue("?", accountStatus)

                    cmd.ExecuteNonQuery()
                End Using

                If totalUsers = 0 Then
                    MessageBox.Show("Matagumpay na nagawa ang kauna-unahang Admin account! Maaari ka nang mag-log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Matagumpay na naipadala ang kahilingan! Mangyaring maghintay ng aprubal mula sa OSA Admin bago makapag-log in.", "Account Pending", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End Using

            Dim loginForm As New LoginForm()
            loginForm.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("May error sa database habang nagrerehistro: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnBacktologin_Click(sender As Object, e As EventArgs) Handles btnBacktologin.Click
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Close()
    End Sub

End Class