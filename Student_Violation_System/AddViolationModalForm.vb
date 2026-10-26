Imports System.Data.Odbc

Public Class AddViolationModalForm

    ' Variable para sa pre-selected student number kung galing sa row click
    Public Property PreloadedStudentNumber As String = ""

    Private Sub AddViolationModalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VbConnect()
        LoadStudentsToComboBox()

        ' Kung may ipinasa galing sa row click, i-select ito nang awtomatiko
        If Not String.IsNullOrEmpty(PreloadedStudentNumber) Then
            cmbStudent.SelectedValue = PreloadedStudentNumber
            FetchStudentDetails(PreloadedStudentNumber)
        End If
    End Sub

    ' --- KUNIN ANG MGA ESTUDYANTE MULA SA school_portal_db ---
    Private Sub LoadStudentsToComboBox()
        Try
            Using conn As OdbcConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT student_number, CONCAT(student_number, ' - ', first_name, ' ', last_name) AS full_info FROM school_portal_db.tbl_enrolled_students"

                Using adapter As New OdbcDataAdapter(query, conn)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    cmbStudent.DataSource = dt
                    cmbStudent.DisplayMember = "full_info"
                    cmbStudent.ValueMember = "student_number"
                    cmbStudent.SelectedIndex = -1
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error sa pag-load ng mga estudyante: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- KAPAG NAGBAGO ANG PINILI SA COMBOBOX ---
    Private Sub CmbStudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStudent.SelectedIndexChanged
        If cmbStudent.SelectedValue IsNot Nothing AndAlso TypeOf cmbStudent.SelectedValue Is String Then
            Dim studNo As String = cmbStudent.SelectedValue.ToString()
            FetchStudentDetails(studNo)
        End If
    End Sub

    ' --- KUNIN ANG DETALYE NG ESTUDYANTE (Program at Year Level) ---
    Private Sub FetchStudentDetails(studentNo As String)
        Try
            Using conn As OdbcConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT first_name, middle_name, last_name, course, year_level FROM school_portal_db.tbl_enrolled_students WHERE student_number = ?"

                Using cmd As New OdbcCommand(query, conn)
                    cmd.Parameters.AddWithValue("?", studentNo)
                    Using reader As OdbcDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim firstName As String = reader("first_name").ToString()
                            Dim middleName As String = If(reader("middle_name") Is DBNull.Value, "", reader("middle_name").ToString())
                            Dim lastName As String = reader("last_name").ToString()

                            ' I-format ang pangalan
                            txtStudentName.Text = $"{firstName} {If(String.IsNullOrEmpty(middleName), "", middleName & " ")}{lastName}"
                            txtProgram.Text = reader("course").ToString()
                            txtYearSection.Text = reader("year_level").ToString()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Huwag pansinin ang minor thread exception sa pag-load
        End Try
    End Sub

    ' --- SAVE VIOLATION BUTTON ---
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbStudent.SelectedIndex = -1 OrElse String.IsNullOrEmpty(txtStudentName.Text) Then
            MessageBox.Show("Mangyaring pumili muna ng estudyante.", "Babala", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrEmpty(cmbViolationType.Text) OrElse String.IsNullOrEmpty(cmbOffenseCount.Text) OrElse String.IsNullOrEmpty(cmbPunishment.Text) Then
            MessageBox.Show("Mangyaring punan ang lahat ng impormasyon tungkol sa violation.", "Babala", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As OdbcConnection = GetConnection()
                conn.Open()
                Dim insertQuery As String = "INSERT INTO tbl_violation_records (student_number, student_name, program, year_section, violation_type, offense_count, punishment_category, status, created_at) VALUES (?, ?, ?, ?, ?, ?, ?, 'Pending', NOW())"

                Using cmd As New OdbcCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("?", cmbStudent.SelectedValue.ToString())
                    cmd.Parameters.AddWithValue("?", txtStudentName.Text)
                    cmd.Parameters.AddWithValue("?", txtProgram.Text)
                    cmd.Parameters.AddWithValue("?", txtYearSection.Text)
                    cmd.Parameters.AddWithValue("?", cmbViolationType.Text)
                    cmd.Parameters.AddWithValue("?", cmbOffenseCount.Text)
                    cmd.Parameters.AddWithValue("?", cmbPunishment.Text)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Matagumpay na naidagdag ang violation record!", "Tagumpay", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error sa pag-save ng violation: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- CANCEL BUTTON ---
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class