Imports System.Data.Odbc

Public Module SessionModule

    Public CurrentAdminUser As String = "Admin User"
    Public CurrentReportCreator As String = "OSA Officer"
    Public CurrentUserId As Integer = 1 ' Idinagdag para sa tracking ng kung aling admin ang naka-login

    ' Global Function para sa ODBC Connection
    Public Function GetConnection() As OdbcConnection
        Dim connectionString As String = "Driver={MySQL ODBC 26.7 Unicode Driver};Server=localhost;Database=student_violation_db;Uid=root;Password=Admin@123;Port=3306;"
        Return New OdbcConnection(connectionString)
    End Function

    ' Tahimik na Connection Tester
    Public Sub VbConnect()
        Try
            Using conn As OdbcConnection = GetConnection()
                conn.Open()
            End Using
        Catch ex As Exception
            MessageBox.Show("May error sa pagkonekta: " & ex.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Global Function para sa Logout (Ginawang Public para mabasa ng lahat ng forms)
    Public Sub LogoutUser(currentForm As Form)
        Dim result As DialogResult = MessageBox.Show("Sigurado ka bang gusto mong mag-log out?", "Confirm Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim loginFrm As New LoginForm()
            loginFrm.Show()
            currentForm.Close()
        End If
    End Sub

    ' Idinagdag na Global Sub Routine para sa Audit Trail / Activity Logs
    Public Sub LogAction(action As String, details As String)
        Try
            Using conn As OdbcConnection = GetConnection()
                conn.Open()
                Dim query As String = "INSERT INTO tbl_audit_logs (user_id, action, details) VALUES (?, ?, ?)"
                Using cmd As New OdbcCommand(query, conn)
                    cmd.Parameters.AddWithValue("?", CurrentUserId)
                    cmd.Parameters.AddWithValue("?", action)
                    cmd.Parameters.AddWithValue("?", details)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            ' Tahimik na hinahawakan ang error para hindi makaabala sa pangunahing daloy ng sistema
        End Try
    End Sub

    ' Pangalawang Function para sa isa pang database (Halimbawa: School Portal DB)
    Public Function GetSecondDatabaseConnection() As OdbcConnection
        Dim connectionString As String = "Driver={MySQL ODBC 26.7 Unicode Driver};Server=localhost;Database=school_portal_db;Uid=root;Password=Admin@123;Port=3306;"
        Return New OdbcConnection(connectionString) ' Ang Return ay laging nasa dulo ng Function
    End Function



End Module