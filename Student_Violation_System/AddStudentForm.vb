Imports System.Data.Odbc

Public Class AddStudentForm

    Private Sub AddStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VbConnect()
    End Sub

    Private Sub BtnSaveStudent_Click(sender As Object, e As EventArgs) Handles btnSaveStudent.Click
        ' Validation kung may blangko
        If String.IsNullOrWhiteSpace(txtStudentNo.Text) OrElse
           String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse
           String.IsNullOrWhiteSpace(txtLastName.Text) OrElse
           cmbCourse.SelectedIndex = -1 OrElse
           String.IsNullOrWhiteSpace(txtYearLevel.Text) Then
            MessageBox.Show("Mangyaring punan ang lahat ng kinakailangang impormasyon.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim studentNo As String = txtStudentNo.Text.Trim()
        Dim pattern As String = "^\d{2}-\d{5}$"

        ' Regex validation para sa Student Number (Halimbawa: 20-00001)
        If Not System.Text.RegularExpressions.Regex.IsMatch(studentNo, pattern) Then
            MessageBox.Show("Mali ang format ng Student Number. Ang tamang halimbawa ay 20-00001.", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStudentNo.Focus()
            Return
        End If

        Try
            Using conn As OdbcConnection = GetSecondDatabaseConnection()
                conn.Open()
                Dim query As String = "INSERT INTO tbl_enrolled_students (student_number, first_name, middle_name, last_name, course, year_level) VALUES (?, ?, ?, ?, ?, ?)"

                Using cmd As New OdbcCommand(query, conn)
                    cmd.Parameters.AddWithValue("?", studentNo)
                    cmd.Parameters.AddWithValue("?", txtFirstName.Text.Trim())
                    cmd.Parameters.AddWithValue("?", If(String.IsNullOrWhiteSpace(txtMiddleName.Text), DBNull.Value, txtMiddleName.Text.Trim()))
                    cmd.Parameters.AddWithValue("?", txtLastName.Text.Trim())
                    cmd.Parameters.AddWithValue("?", cmbCourse.Text.Trim())
                    cmd.Parameters.AddWithValue("?", txtYearLevel.Text.Trim())

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Matagumpay na naidagdag ang bagong estudyante sa listahan!", "Tagumpay", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class