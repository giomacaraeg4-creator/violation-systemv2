Imports System.Data.Odbc
Imports System.Drawing.Drawing2D

Public Class DashboardForm

    ' Listahan para sa Monthly Chart Data
    Private monthlyData As New Dictionary(Of String, Integer)()

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        VbConnect()
        LoadDashboardMetrics()
        LoadMonthlyChartData()
        CheckPendingAccountRequests()
    End Sub

    ' --- NOTIFICATION CHECKER PARA SA MGA NAG-REGISTER NA ACCOUNT ---
    Private Sub CheckPendingAccountRequests()
        Try
            Using conn As OdbcConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM tbl_users WHERE status = 'Pending'"
                Using cmd As New OdbcCommand(query, conn)
                    Dim pendingCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    ' I-update ang value sa PanelCard5
                    lblRequestsVal.Text = pendingCount.ToString()
                End Using
            End Using
        Catch ex As Exception
            lblRequestsVal.Text = "0"
        End Try
    End Sub

    ' --- PAGKUHA NG MGA DATA MULA SA DATABASE PARA SA ANALYTICS ---
    Private Sub LoadDashboardMetrics()
        Try
            Using conn As OdbcConnection = GetConnection()
                conn.Open()

                ' 1. Total Violations
                Dim queryViolations As String = "SELECT COUNT(*) FROM tbl_violation_records WHERE status != 'Archived'"
                Using cmd1 As New OdbcCommand(queryViolations, conn)
                    Dim totalViolations As Integer = Convert.ToInt32(cmd1.ExecuteScalar())
                    lblViolationsVal.Text = totalViolations.ToString()
                End Using

                ' 2. Total Students mula sa school_portal_db.tbl_enrolled_students
                Dim queryStudents As String = "SELECT COUNT(*) FROM school_portal_db.tbl_enrolled_students"
                Using cmd2 As New OdbcCommand(queryStudents, conn)
                    Dim totalStudents As Integer = Convert.ToInt32(cmd2.ExecuteScalar())
                    lblStudentsVal.Text = totalStudents.ToString()
                End Using

                ' 3. Total Recorded / Completed Slips
                Dim queryRecorded As String = "SELECT COUNT(*) FROM tbl_violation_records WHERE status = 'Completed'"
                Using cmd3 As New OdbcCommand(queryRecorded, conn)
                    Dim totalRecorded As Integer = Convert.ToInt32(cmd3.ExecuteScalar())
                    lblRecordedVal.Text = totalRecorded.ToString()
                End Using

                ' 4. Total Pending Slips
                Dim queryPending As String = "SELECT COUNT(*) FROM tbl_violation_records WHERE status = 'Pending'"
                Using cmd4 As New OdbcCommand(queryPending, conn)
                    Dim totalPending As Integer = Convert.ToInt32(cmd4.ExecuteScalar())
                    lblPendingVal.Text = totalPending.ToString()
                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show("May error sa pagkarga ng dashboard analytics: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- PAGKUHA NG MONTHLY DATA PARA SA BAR CHART (BUONG 12 BUWAN NG KASALUKUYANG TAON) ---
    Private Sub LoadMonthlyChartData()
        monthlyData.Clear()
        Try
            Using conn As OdbcConnection = GetConnection()
                conn.Open()

                ' Kunin ang totoong kasalukuyang taon (Real Year, halimbawa 2026)
                Dim currentYear As Integer = DateTime.Now.Year

                ' Itera ang buong 12 na buwan ng taon mula Enero (1) hanggang Disyembre (12)
                For i As Integer = 1 To 12
                    Dim targetDate As New DateTime(currentYear, i, 1)
                    Dim monthName As String = targetDate.ToString("MMM") ' Halimbawa: Jan, Feb, Mar...
                    Dim monthNum As Integer = targetDate.Month

                    Dim query As String = "SELECT COUNT(*) FROM tbl_violation_records WHERE MONTH(created_at) = ? AND YEAR(created_at) = ? AND status != 'Archived'"
                    Using cmd As New OdbcCommand(query, conn)
                        cmd.Parameters.AddWithValue("?", monthNum)
                        cmd.Parameters.AddWithValue("?", currentYear)

                        Dim count As Integer = 0
                        Dim result = cmd.ExecuteScalar()
                        If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                            count = Convert.ToInt32(result)
                        End If

                        monthlyData.Add(monthName, count)
                    End Using
                Next
            End Using
        Catch ex As Exception
            ' Fallback sakaling magka-issue sa database connection
            Dim months() As String = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
            For Each m In months
                If Not monthlyData.ContainsKey(m) Then monthlyData.Add(m, 0)
            Next
        End Try
        PanelMonthly.Invalidate()
    End Sub

    ' --- PAG-GUHIT NG BAR CHART SA PANEL MONTHLY ---
    Private Sub PanelMonthly_Paint(sender As Object, e As PaintEventArgs) Handles PanelMonthly.Paint
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        Dim panelWidth As Integer = PanelMonthly.Width
        Dim panelHeight As Integer = PanelMonthly.Height

        Dim maxVal As Integer = 60
        For Each v As Integer In monthlyData.Values
            If v > maxVal Then maxVal = CInt(Math.Ceiling(v / 10.0) * 10)
        Next

        Dim fontGrid As New Font("Segoe UI", 8, FontStyle.Regular)
        Dim penGrid As New Pen(Color.FromArgb(220, 215, 210), 1)

        For i As Integer = 0 To 6
            Dim y As Integer = 50 + CInt(i * ((panelHeight - 90) / 6.0))
            Dim currentVal As Integer = maxVal - CInt(i * (maxVal / 6.0))
            g.DrawString(currentVal.ToString(), fontGrid, Brushes.Gray, 15, y - 8)
            g.DrawString("―", fontGrid, Brushes.LightGray, 45, y - 8)
            g.DrawLine(penGrid, 65, y, panelWidth - 30, y)
        Next

        Dim totalBars As Integer = monthlyData.Count
        If totalBars = 0 Then Return

        Dim chartAreaLeft As Integer = 80
        Dim chartAreaWidth As Integer = panelWidth - 110
        Dim calcBarWidth As Double = chartAreaWidth / (totalBars * 1.8)
        Dim barWidth As Integer = CInt(Math.Min(35, If(calcBarWidth < 8, 8, calcBarWidth)))

        Dim totalBarsWidth As Integer = barWidth * totalBars
        Dim remainingWidth As Integer = chartAreaWidth - totalBarsWidth
        Dim spacing As Integer = CInt(remainingWidth / Math.Max(1, totalBars))

        Dim idx As Integer = 0
        Dim barColor As Color = Color.FromArgb(115, 45, 55)

        For Each kvp In monthlyData
            Dim mName As String = kvp.Key
            Dim mVal As Integer = kvp.Value

            Dim x As Integer = chartAreaLeft + (idx * (barWidth + spacing)) + CInt(spacing / 2)
            Dim availableHeight As Integer = panelHeight - 110
            Dim barHeight As Integer = CInt((mVal / CDbl(Math.Max(1, maxVal))) * availableHeight)
            Dim y As Integer = (panelHeight - 40) - barHeight

            Using br As New SolidBrush(barColor)
                g.FillRectangle(br, x, y, barWidth, barHeight)
            End Using

            Dim fontMonth As New Font("Segoe UI", 8, FontStyle.Bold)
            g.DrawString(mName, fontMonth, Brushes.Black, x + CInt(barWidth / 2) - 10, panelHeight - 30)

            idx += 1
        Next
    End Sub

    ' --- CARD CLICK EVENTS ---
    Private Sub PanelCard1_Click(sender As Object, e As EventArgs) Handles PanelCard1.Click, lblViolationsVal.Click, lblViolationsTitle.Click, PictureBox3.Click
        Dim violationsForm As New ViolationsForm()
        violationsForm.Show()
        Me.Hide()
    End Sub

    Private Sub PanelCard2_Click(sender As Object, e As EventArgs) Handles PanelCard2.Click, lblStudentsVal.Click, lblStudentsTitle.Click, PictureBox2.Click
        Dim studentListForm As New StudentListForm()
        studentListForm.Show()
        Me.Hide()
    End Sub

    Private Sub PanelCard3_Click(sender As Object, e As EventArgs) Handles PanelCard3.Click, lblRecordedVal.Click, lblRecordedTitle.Click, PictureBox1.Click
        Dim violationsForm As New ViolationsForm()
        violationsForm.Show()
        Me.Hide()
    End Sub

    Private Sub PanelCard4_Click(sender As Object, e As EventArgs) Handles PanelCard4.Click, lblPendingVal.Click, lblPendingTitle.Click, PictureBox5.Click
        Dim pendingForm As New PendingViolationsForm()
        pendingForm.Show()
        Me.Hide()
    End Sub

    ' Dito lamang bubukas ang RegistrationRequestsForm kapag PININDOT ang notification card
    Private Sub PanelCard5_Click(sender As Object, e As EventArgs) Handles PanelCard5.Click, lblRequestsVal.Click, lblRequestsTitle.Click, PictureBox6.Click
        Dim regForm As New RegistrationRequestsForm()
        regForm.Show()
        Me.Hide()
    End Sub

    ' --- NAVIGATION MENU ---
    Private Sub DigitalSlipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DigitalSlipToolStripMenuItem.Click
        VbConnect()
        Dim violationForm As New DigitalViolationForm()
        violationForm.Show()
        Me.Hide()
    End Sub

    Private Sub ViolationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViolationsToolStripMenuItem.Click
        Dim violationsListForm As New ViolationsForm()
        violationsListForm.Show()
        Me.Hide()
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        LoadDashboardMetrics()
        LoadMonthlyChartData()
        CheckPendingAccountRequests()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogoutUser(Me)
    End Sub

    Private Sub StudentListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentListToolStripMenuItem.Click
        Dim studentListForm As New StudentListForm()
        studentListForm.Show()
        Me.Hide()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        Dim reportsForm As New ReportsForm()
        reportsForm.Show()
        Me.Hide()
    End Sub

End Class