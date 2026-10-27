Imports System.Data.Odbc
Imports System.Drawing.Drawing2D

Public Class DashboardForm

    ' Listahan para sa Monthly Chart Data
    Private monthlyData As New Dictionary(Of String, Integer)()

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        VbConnect()

        ' 1. I-setup ang mga kursong available sa inyong eskwelahan
        SetupCourseComboBox()

        ' 2. I-display ang real month at year sa card (halimbawa: October 2026)
        lblMonthVal.Text = DateTime.Now.ToString("MMMM yyyy")

        ' 3. I-load ang analytics at chart
        LoadDashboardMetrics()
        LoadMonthlyChartData()
        CheckPendingAccountRequests()
    End Sub

    ' --- SETUP NG COURSE COMBOBOX (All, BSIT, BSHM, BSTM, BSED) ---
    Private Sub SetupCourseComboBox()
        cmbCourseFilter.Items.Clear()
        cmbCourseFilter.Items.Add("All")
        cmbCourseFilter.Items.Add("BSIT")
        cmbCourseFilter.Items.Add("BSHM")
        cmbCourseFilter.Items.Add("BSTM")
        cmbCourseFilter.Items.Add("BSED")
        cmbCourseFilter.SelectedIndex = 0 ' Default sa "All"
    End Sub

    ' --- KAPAG NAGPALIT NG COURSE SA COMBOBOX ---
    Private Sub CmbCourseFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCourseFilter.SelectedIndexChanged
        LoadDashboardMetrics()
        LoadMonthlyChartData()
    End Sub

    ' --- NOTIFICATION CHECKER PARA SA MGA NAG-REGISTER NA ACCOUNT ---
    Private Sub CheckPendingAccountRequests()
        Try
            Using conn As OdbcConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM tbl_users WHERE status = 'Pending'"
                Using cmd As New OdbcCommand(query, conn)
                    Dim pendingCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    lblRequestsVal.Text = pendingCount.ToString()
                End Using
            End Using
        Catch ex As Exception
            lblRequestsVal.Text = "0"
        End Try
    End Sub

    ' --- PAGKUHA NG MGA DATA MULA SA DATABASE PARA SA ANALYTICS (COURSE & REAL MONTH) ---
    Private Sub LoadDashboardMetrics()
        Try
            Using conn As OdbcConnection = GetConnection()
                conn.Open()

                Dim selectedCourse As String = If(cmbCourseFilter.SelectedItem IsNot Nothing, cmbCourseFilter.SelectedItem.ToString(), "All")

                ' I-update ang Course Card label para sumunod kung All o partikular na course ang pinili
                lblCourse.Text = selectedCourse

                Dim currentMonth As Integer = DateTime.Now.Month
                Dim currentYear As Integer = DateTime.Now.Year

                ' Base query condition para sa kasalukuyang buwan at taon
                Dim baseCondition As String = "WHERE MONTH(created_at) = ? AND YEAR(created_at) = ?"

                If selectedCourse <> "All" Then
                    baseCondition &= " AND program = ?"
                End If

                ' 1. Total Violation Records (Lahat ng violation/records para sa buwan/course na ito)
                Dim queryViolations As String = "SELECT COUNT(*) FROM tbl_violation_records " & baseCondition
                Using cmd1 As New OdbcCommand(queryViolations, conn)
                    cmd1.Parameters.AddWithValue("?", currentMonth)
                    cmd1.Parameters.AddWithValue("?", currentYear)
                    If selectedCourse <> "All" Then cmd1.Parameters.AddWithValue("?", selectedCourse)

                    Dim totalViolations As Integer = Convert.ToInt32(cmd1.ExecuteScalar())
                    lblViolationsVal.Text = totalViolations.ToString()
                End Using

                ' 2. Students with Violations (Unique students - kapag dalawa ang violation ng isang student, 1 lang ang bibilangin sa bilang ng estudyante)
                Dim queryUniqueStudents As String = "SELECT COUNT(DISTINCT student_number) FROM tbl_violation_records " & baseCondition
                Using cmd2 As New OdbcCommand(queryUniqueStudents, conn)
                    cmd2.Parameters.AddWithValue("?", currentMonth)
                    cmd2.Parameters.AddWithValue("?", currentYear)
                    If selectedCourse <> "All" Then cmd2.Parameters.AddWithValue("?", selectedCourse)

                    Dim uniqueStudents As Integer = Convert.ToInt32(cmd2.ExecuteScalar())
                    lblStudentsVal.Text = uniqueStudents.ToString()
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

                Dim currentYear As Integer = DateTime.Now.Year
                Dim selectedCourse As String = If(cmbCourseFilter.SelectedItem IsNot Nothing, cmbCourseFilter.SelectedItem.ToString(), "All")

                For i As Integer = 1 To 12
                    Dim targetDate As New DateTime(currentYear, i, 1)
                    Dim monthName As String = targetDate.ToString("MMM") ' Halimbawa: Jan, Feb, Mar...
                    Dim monthNum As Integer = targetDate.Month

                    Dim query As String = "SELECT COUNT(*) FROM tbl_violation_records WHERE MONTH(created_at) = ? AND YEAR(created_at) = ?"
                    If selectedCourse <> "All" Then
                        query &= " AND program = ?"
                    End If

                    Using cmd As New OdbcCommand(query, conn)
                        cmd.Parameters.AddWithValue("?", monthNum)
                        cmd.Parameters.AddWithValue("?", currentYear)
                        If selectedCourse <> "All" Then cmd.Parameters.AddWithValue("?", selectedCourse)

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
    Private Sub PanelCard5_Click(sender As Object, e As EventArgs) Handles PanelCard5.Click, lblRequestsVal.Click, lblRequestsTitle.Click
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

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        Dim reportsForm As New ReportsForm()
        reportsForm.Show()
        Me.Hide()
    End Sub

End Class