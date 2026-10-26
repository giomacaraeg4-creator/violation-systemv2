Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VbConnect()
    End Sub


    Private Sub btnStarted_Click(sender As Object, e As EventArgs) Handles btnStarted.Click

        Dim login As New LoginForm()
        login.Show()

        Me.Hide()
    End Sub

End Class