Imports System.Data.Odbc

Public Class StudentListForm

    Private Sub StudentListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        VbConnect()
        dgvStudents.AutoGenerateColumns = False
        LoadStudentList()
    End Sub


    Private Sub LoadStudentList(Optional searchTerm As String = "")
        Try
            Using conn As OdbcConnection = GetSecondDatabaseConnection()
                conn.Open()
                Dim query As String = "SELECT student_number, first_name, middle_name, last_name, course, year_level FROM tbl_enrolled_students"

                If Not String.IsNullOrEmpty(searchTerm) Then
                    query &= " WHERE student_number LIKE ? OR first_name LIKE ? OR last_name LIKE ?"
                End If

                Using cmd As New OdbcCommand(query, conn)
                    If Not String.IsNullOrEmpty(searchTerm) Then
                        Dim key As String = "%" & searchTerm & "%"
                        cmd.Parameters.AddWithValue("?", key)
                        cmd.Parameters.AddWithValue("?", key)
                        cmd.Parameters.AddWithValue("?", key)
                    End If

                    Dim adapter As New OdbcDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvStudents.DataSource = table


                    FormatDataGridView()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error sa pag-load ng listahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub FormatDataGridView()
        If dgvStudents.Columns.Count > 0 Then

            dgvStudents.Columns("student_number").HeaderText = "Student Number"
            dgvStudents.Columns("first_name").HeaderText = "First Name"
            dgvStudents.Columns("middle_name").HeaderText = "Middle Name"
            dgvStudents.Columns("last_name").HeaderText = "Last Name"
            dgvStudents.Columns("course").HeaderText = "Course"
            dgvStudents.Columns("year_level").HeaderText = "Year Level"


            dgvStudents.Columns("student_number").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvStudents.Columns("year_level").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If
    End Sub


    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadStudentList(txtSearch.Text.Trim())
    End Sub


    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Text = ""
        LoadStudentList()
    End Sub


    Private Sub TxtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadStudentList(txtSearch.Text.Trim())
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub BtnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        Dim addForm As New AddStudentForm()
        addForm.ShowDialog()
        LoadStudentList()
    End Sub


    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dash As New DashboardForm()
        dash.Show()
        Me.Close()
    End Sub

End Class