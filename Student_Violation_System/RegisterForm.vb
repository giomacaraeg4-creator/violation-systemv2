Imports System.Data.Odbc

Public Class RegisterForm

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' I-setup ang mga default placeholders
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

    ' --- USERNAME PLACEHOLDER LOGIC ---
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

    ' --- PASSWORD 2 PLACEHOLDER & HIDING LOGIC ---
    Private Sub TxtPass2_Enter(sender As Object, e As EventArgs) Handles txtPass2.Enter
        If txtPass2.Text = "Password" Then
            txtPass2.Text = ""
            txtPass2.ForeColor = Color.Black
            txtPass2.UseSystemPasswordChar = True ' Siguraduhing nakatago agad
        End If
    End Sub

    Private Sub TxtPass2_Leave(sender As Object, e As EventArgs) Handles txtPass2.Leave
        If String.IsNullOrWhiteSpace(txtPass2.Text) Then
            txtPass2.Text = "Password"
            txtPass2.ForeColor = Color.Gray
            txtPass2.UseSystemPasswordChar = False
        End If
    End Sub

    ' --- PASSWORD 3 (CONFIRM) PLACEHOLDER & HIDING LOGIC ---
    Private Sub TxtPass3_Enter(sender As Object, e As EventArgs) Handles txtPass3.Enter
        If txtPass3.Text = "Confirm Password" Then
            txtPass3.Text = ""
            txtPass3.ForeColor = Color.Black
            txtPass3.UseSystemPasswordChar = True ' Siguraduhing nakatago agad
        End If
    End Sub

    Private Sub TxtPass3_Leave(sender As Object, e As EventArgs) Handles txtPass3.Leave
        If String.IsNullOrWhiteSpace(txtPass3.Text) Then
            txtPass3.Text = "Confirm Password"
            txtPass3.ForeColor = Color.Gray
            txtPass3.UseSystemPasswordChar = False
        End If
    End Sub

    ' --- SIGURADUHING NAKATAGO HABANG NAGMAMAY-ARI NG TEXT ANG PASSWORD 2 ---
    Private Sub TxtPass2_TextChanged(sender As Object, e As EventArgs) Handles txtPass2.TextChanged
        If txtPass2.Text <> "Password" AndAlso Not String.IsNullOrEmpty(txtPass2.Text) Then
            ' Kung sakaling nag-reset ang property habang nagta-type, ibalik sa pagtatago maliban na lang kung pinindot ang eye button
            If btnEye2.Text = "👁‍🗨" Then
                txtPass2.UseSystemPasswordChar = True
            End If
        End If
    End Sub

    ' --- SIGURADUHING NAKATAGO HABANG NAGMAMAY-ARI NG TEXT ANG PASSWORD 3 ---
    Private Sub TxtPass3_TextChanged(sender As Object, e As EventArgs) Handles txtPass3.TextChanged
        If txtPass3.Text <> "Confirm Password" AndAlso Not String.IsNullOrEmpty(txtPass3.Text) Then
            If btnEye3.Text = "👁‍🗨" Then
                txtPass3.UseSystemPasswordChar = True
            End If
        End If
    End Sub

    ' --- EYE TOGGLE 2 (Password) ---
    Private Sub BtnEye2_Click(sender As Object, e As EventArgs) Handles btnEye2.Click
        If txtPass2.Text <> "Password" AndAlso Not String.IsNullOrEmpty(txtPass2.Text) Then
            txtPass2.UseSystemPasswordChar = Not txtPass2.UseSystemPasswordChar
            ' Palitan ang icon ng mata batay sa estado
            btnEye2.Text = If(txtPass2.UseSystemPasswordChar, "👁‍🗨", "👁")
        End If
    End Sub

    ' --- EYE TOGGLE 3 (Confirm Password) ---
    Private Sub BtnEye3_Click(sender As Object, e As EventArgs) Handles btnEye3.Click
        If txtPass3.Text <> "Confirm Password" AndAlso Not String.IsNullOrEmpty(txtPass3.Text) Then
            txtPass3.UseSystemPasswordChar = Not txtPass3.UseSystemPasswordChar
            ' Palitan ang icon ng mata batay sa estado
            btnEye3.Text = If(txtPass3.UseSystemPasswordChar, "👁‍🗨", "👁")
        End If
    End Sub

    ' --- COMBOBOX STYLING ---
    Private Sub ComboBox1_Enter(sender As Object, e As EventArgs) Handles ComboBox1.Enter
        If ComboBox1.Text = "Role" Then
            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
        End If
    End Sub

    ' --- CREATE ACCOUNT BUTTON LOGIC ---
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim username As String = txtUsername2.Text.Trim()
        Dim password As String = txtPass2.Text.Trim()
        Dim confirmPass As String = txtPass3.Text.Trim()
        Dim role As String = ComboBox1.Text.Trim()

        ' 1. Validations
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

                ' 2. Suriin kung umiiral na ang username
                Dim checkQuery As String = "SELECT COUNT(*) FROM tbl_users WHERE username = ?"
                Using checkCmd As New OdbcCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("?", username)
                    Dim existingCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If existingCount > 0 Then
                        MessageBox.Show("Ang Username na ito ay nagagamit na. Pumili ng iba.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                ' 3. Bilangin ang kabuuang users sa database (First-User Setup Logic)
                Dim countUsersQuery As String = "SELECT COUNT(*) FROM tbl_users"
                Dim totalUsers As Integer = 0
                Using countCmd As New OdbcCommand(countUsersQuery, conn)
                    totalUsers = Convert.ToInt32(countCmd.ExecuteScalar())
                End Using

                ' Kung 0 ang totalUsers, siya ang kauna-unahang gagamit kaya 'Active' agad.
                ' Kung may laman na, ang status ay magiging 'Pending' para sa aprubal ng Admin.
                Dim accountStatus As String = If(totalUsers = 0, "Active", "Pending")

                ' 4. I-save ang bagong user kasama ang status gamit ang tamang column na password_hash
                Dim insertQuery As String = "INSERT INTO tbl_users (username, password_hash, user_role, status) VALUES (?, ?, ?, ?)"
                Using cmd As New OdbcCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("?", username)
                    cmd.Parameters.AddWithValue("?", password)
                    cmd.Parameters.AddWithValue("?", role)
                    cmd.Parameters.AddWithValue("?", accountStatus)

                    cmd.ExecuteNonQuery()
                End Using

                ' 5. I-log ang aksyon
                LogAction("CREATE_USER", "Matagumpay na nairehistro ang account para kay: " & username & " (" & role & ") - Status: " & accountStatus)

                If totalUsers = 0 Then
                    MessageBox.Show("Matagumpay na nagawa ang kauna-unahang Admin account! Maaari ka nang mag-log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Matagumpay na naipadala ang kahilingan! Mangyaring maghintay ng aprubal mula sa OSA Admin bago makapag-log in.", "Account Pending", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End Using

            ' Bumalik sa Login Form
            Dim loginForm As New LoginForm()
            loginForm.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("May error sa database habang nagrerehistro: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- BACK TO LOGIN BUTTON ---
    Private Sub BtnBacktologin_Click(sender As Object, e As EventArgs) Handles btnBacktologin.Click
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Close()
    End Sub

End Class