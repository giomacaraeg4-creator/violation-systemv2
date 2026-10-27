<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DigitalSlipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViolationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LoggedInAdminUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportByOSAOfficerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelCard1 = New System.Windows.Forms.Panel()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblViolationsTitle = New System.Windows.Forms.Label()
        Me.PanelCard2 = New System.Windows.Forms.Panel()
        Me.lblMonthVal = New System.Windows.Forms.Label()
        Me.lblStudentsTitle = New System.Windows.Forms.Label()
        Me.PanelCard3 = New System.Windows.Forms.Panel()
        Me.lblViolationsVal = New System.Windows.Forms.Label()
        Me.lblRecordedTitle = New System.Windows.Forms.Label()
        Me.PanelCard4 = New System.Windows.Forms.Panel()
        Me.lblStudentsVal = New System.Windows.Forms.Label()
        Me.lblPendingTitle = New System.Windows.Forms.Label()
        Me.PanelCard5 = New System.Windows.Forms.Panel()
        Me.lblRequestsVal = New System.Windows.Forms.Label()
        Me.lblRequestsTitle = New System.Windows.Forms.Label()
        Me.PanelMonthly = New System.Windows.Forms.Panel()
        Me.cmbCourseFilter = New System.Windows.Forms.ComboBox()
        Me.lblFilteryBy = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lblMonthlyTitle = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.PanelCard1.SuspendLayout()
        Me.PanelCard2.SuspendLayout()
        Me.PanelCard3.SuspendLayout()
        Me.PanelCard4.SuspendLayout()
        Me.PanelCard5.SuspendLayout()
        Me.PanelMonthly.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.DigitalSlipToolStripMenuItem, Me.ViolationsToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.AdminUserToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 10, 0, 10)
        Me.MenuStrip1.Size = New System.Drawing.Size(1579, 47)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DashboardToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(105, 27)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'DigitalSlipToolStripMenuItem
        '
        Me.DigitalSlipToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DigitalSlipToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DigitalSlipToolStripMenuItem.Name = "DigitalSlipToolStripMenuItem"
        Me.DigitalSlipToolStripMenuItem.Size = New System.Drawing.Size(108, 27)
        Me.DigitalSlipToolStripMenuItem.Text = " Digital Slip"
        '
        'ViolationsToolStripMenuItem
        '
        Me.ViolationsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ViolationsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViolationsToolStripMenuItem.Name = "ViolationsToolStripMenuItem"
        Me.ViolationsToolStripMenuItem.Size = New System.Drawing.Size(102, 27)
        Me.ViolationsToolStripMenuItem.Text = " Violations"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ReportsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(86, 27)
        Me.ReportsToolStripMenuItem.Text = " Reports"
        '
        'AdminUserToolStripMenuItem
        '
        Me.AdminUserToolStripMenuItem.DropDown = Me.ContextMenuStrip1
        Me.AdminUserToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.AdminUserToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AdminUserToolStripMenuItem.Name = "AdminUserToolStripMenuItem"
        Me.AdminUserToolStripMenuItem.Size = New System.Drawing.Size(111, 27)
        Me.AdminUserToolStripMenuItem.Text = "Admin User"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoggedInAdminUserToolStripMenuItem, Me.ReportByOSAOfficerToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.OwnerItem = Me.AdminUserToolStripMenuItem
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(230, 76)
        '
        'LoggedInAdminUserToolStripMenuItem
        '
        Me.LoggedInAdminUserToolStripMenuItem.Name = "LoggedInAdminUserToolStripMenuItem"
        Me.LoggedInAdminUserToolStripMenuItem.Size = New System.Drawing.Size(229, 24)
        Me.LoggedInAdminUserToolStripMenuItem.Text = "Logged in: Admin User"
        '
        'ReportByOSAOfficerToolStripMenuItem
        '
        Me.ReportByOSAOfficerToolStripMenuItem.Name = "ReportByOSAOfficerToolStripMenuItem"
        Me.ReportByOSAOfficerToolStripMenuItem.Size = New System.Drawing.Size(229, 24)
        Me.ReportByOSAOfficerToolStripMenuItem.Text = "Report By: OSA Officer"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(229, 24)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'PanelCard1
        '
        Me.PanelCard1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.PanelCard1.Controls.Add(Me.lblCourse)
        Me.PanelCard1.Controls.Add(Me.lblViolationsTitle)
        Me.PanelCard1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelCard1.Location = New System.Drawing.Point(27, 68)
        Me.PanelCard1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelCard1.Name = "PanelCard1"
        Me.PanelCard1.Size = New System.Drawing.Size(291, 103)
        Me.PanelCard1.TabIndex = 1
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblCourse.ForeColor = System.Drawing.Color.White
        Me.lblCourse.Location = New System.Drawing.Point(13, 42)
        Me.lblCourse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(105, 37)
        Me.lblCourse.TabIndex = 2
        Me.lblCourse.Text = "Course"
        '
        'lblViolationsTitle
        '
        Me.lblViolationsTitle.AutoSize = True
        Me.lblViolationsTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblViolationsTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblViolationsTitle.Location = New System.Drawing.Point(14, 12)
        Me.lblViolationsTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblViolationsTitle.Name = "lblViolationsTitle"
        Me.lblViolationsTitle.Size = New System.Drawing.Size(63, 23)
        Me.lblViolationsTitle.TabIndex = 0
        Me.lblViolationsTitle.Text = "Course"
        '
        'PanelCard2
        '
        Me.PanelCard2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelCard2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.PanelCard2.Controls.Add(Me.lblMonthVal)
        Me.PanelCard2.Controls.Add(Me.lblStudentsTitle)
        Me.PanelCard2.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelCard2.Location = New System.Drawing.Point(335, 68)
        Me.PanelCard2.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelCard2.Name = "PanelCard2"
        Me.PanelCard2.Size = New System.Drawing.Size(291, 103)
        Me.PanelCard2.TabIndex = 2
        '
        'lblMonthVal
        '
        Me.lblMonthVal.AutoSize = True
        Me.lblMonthVal.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblMonthVal.ForeColor = System.Drawing.Color.White
        Me.lblMonthVal.Location = New System.Drawing.Point(14, 42)
        Me.lblMonthVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonthVal.Name = "lblMonthVal"
        Me.lblMonthVal.Size = New System.Drawing.Size(192, 37)
        Me.lblMonthVal.TabIndex = 1
        Me.lblMonthVal.Text = "October 2026"
        '
        'lblStudentsTitle
        '
        Me.lblStudentsTitle.AutoSize = True
        Me.lblStudentsTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblStudentsTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblStudentsTitle.Location = New System.Drawing.Point(14, 12)
        Me.lblStudentsTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentsTitle.Name = "lblStudentsTitle"
        Me.lblStudentsTitle.Size = New System.Drawing.Size(62, 23)
        Me.lblStudentsTitle.TabIndex = 0
        Me.lblStudentsTitle.Text = "Month"
        '
        'PanelCard3
        '
        Me.PanelCard3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelCard3.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.PanelCard3.Controls.Add(Me.lblViolationsVal)
        Me.PanelCard3.Controls.Add(Me.lblRecordedTitle)
        Me.PanelCard3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelCard3.Location = New System.Drawing.Point(643, 68)
        Me.PanelCard3.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelCard3.Name = "PanelCard3"
        Me.PanelCard3.Size = New System.Drawing.Size(291, 103)
        Me.PanelCard3.TabIndex = 3
        '
        'lblViolationsVal
        '
        Me.lblViolationsVal.AutoSize = True
        Me.lblViolationsVal.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblViolationsVal.ForeColor = System.Drawing.Color.White
        Me.lblViolationsVal.Location = New System.Drawing.Point(14, 42)
        Me.lblViolationsVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblViolationsVal.Name = "lblViolationsVal"
        Me.lblViolationsVal.Size = New System.Drawing.Size(40, 46)
        Me.lblViolationsVal.TabIndex = 1
        Me.lblViolationsVal.Text = "0"
        '
        'lblRecordedTitle
        '
        Me.lblRecordedTitle.AutoSize = True
        Me.lblRecordedTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblRecordedTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblRecordedTitle.Location = New System.Drawing.Point(14, 12)
        Me.lblRecordedTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRecordedTitle.Name = "lblRecordedTitle"
        Me.lblRecordedTitle.Size = New System.Drawing.Size(178, 23)
        Me.lblRecordedTitle.TabIndex = 0
        Me.lblRecordedTitle.Text = "Total violation records"
        '
        'PanelCard4
        '
        Me.PanelCard4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelCard4.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.PanelCard4.Controls.Add(Me.lblStudentsVal)
        Me.PanelCard4.Controls.Add(Me.lblPendingTitle)
        Me.PanelCard4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelCard4.Location = New System.Drawing.Point(951, 68)
        Me.PanelCard4.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelCard4.Name = "PanelCard4"
        Me.PanelCard4.Size = New System.Drawing.Size(291, 103)
        Me.PanelCard4.TabIndex = 5
        '
        'lblStudentsVal
        '
        Me.lblStudentsVal.AutoSize = True
        Me.lblStudentsVal.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblStudentsVal.ForeColor = System.Drawing.Color.White
        Me.lblStudentsVal.Location = New System.Drawing.Point(14, 42)
        Me.lblStudentsVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentsVal.Name = "lblStudentsVal"
        Me.lblStudentsVal.Size = New System.Drawing.Size(40, 46)
        Me.lblStudentsVal.TabIndex = 1
        Me.lblStudentsVal.Text = "0"
        '
        'lblPendingTitle
        '
        Me.lblPendingTitle.AutoSize = True
        Me.lblPendingTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPendingTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblPendingTitle.Location = New System.Drawing.Point(14, 12)
        Me.lblPendingTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPendingTitle.Name = "lblPendingTitle"
        Me.lblPendingTitle.Size = New System.Drawing.Size(193, 23)
        Me.lblPendingTitle.TabIndex = 0
        Me.lblPendingTitle.Text = "Students with violations"
        '
        'PanelCard5
        '
        Me.PanelCard5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelCard5.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.PanelCard5.Controls.Add(Me.lblRequestsVal)
        Me.PanelCard5.Controls.Add(Me.lblRequestsTitle)
        Me.PanelCard5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelCard5.Location = New System.Drawing.Point(1259, 68)
        Me.PanelCard5.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelCard5.Name = "PanelCard5"
        Me.PanelCard5.Size = New System.Drawing.Size(291, 103)
        Me.PanelCard5.TabIndex = 6
        '
        'lblRequestsVal
        '
        Me.lblRequestsVal.AutoSize = True
        Me.lblRequestsVal.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblRequestsVal.ForeColor = System.Drawing.Color.White
        Me.lblRequestsVal.Location = New System.Drawing.Point(29, 36)
        Me.lblRequestsVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRequestsVal.Name = "lblRequestsVal"
        Me.lblRequestsVal.Size = New System.Drawing.Size(40, 46)
        Me.lblRequestsVal.TabIndex = 1
        Me.lblRequestsVal.Text = "0"
        '
        'lblRequestsTitle
        '
        Me.lblRequestsTitle.AutoSize = True
        Me.lblRequestsTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblRequestsTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblRequestsTitle.Location = New System.Drawing.Point(20, 12)
        Me.lblRequestsTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRequestsTitle.Name = "lblRequestsTitle"
        Me.lblRequestsTitle.Size = New System.Drawing.Size(146, 23)
        Me.lblRequestsTitle.TabIndex = 0
        Me.lblRequestsTitle.Text = "Register Requests"
        '
        'PanelMonthly
        '
        Me.PanelMonthly.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMonthly.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.PanelMonthly.Controls.Add(Me.cmbCourseFilter)
        Me.PanelMonthly.Controls.Add(Me.lblFilteryBy)
        Me.PanelMonthly.Controls.Add(Me.PictureBox4)
        Me.PanelMonthly.Controls.Add(Me.lblMonthlyTitle)
        Me.PanelMonthly.Location = New System.Drawing.Point(27, 185)
        Me.PanelMonthly.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelMonthly.Name = "PanelMonthly"
        Me.PanelMonthly.Size = New System.Drawing.Size(1523, 437)
        Me.PanelMonthly.TabIndex = 4
        '
        'cmbCourseFilter
        '
        Me.cmbCourseFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCourseFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourseFilter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbCourseFilter.FormattingEnabled = True
        Me.cmbCourseFilter.Location = New System.Drawing.Point(1253, 14)
        Me.cmbCourseFilter.Name = "cmbCourseFilter"
        Me.cmbCourseFilter.Size = New System.Drawing.Size(250, 36)
        Me.cmbCourseFilter.TabIndex = 1
        '
        'lblFilteryBy
        '
        Me.lblFilteryBy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFilteryBy.AutoSize = True
        Me.lblFilteryBy.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFilteryBy.Location = New System.Drawing.Point(1155, 19)
        Me.lblFilteryBy.Name = "lblFilteryBy"
        Me.lblFilteryBy.Size = New System.Drawing.Size(81, 23)
        Me.lblFilteryBy.TabIndex = 6
        Me.lblFilteryBy.Text = "Filter By :"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(20, 15)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(37, 31)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'lblMonthlyTitle
        '
        Me.lblMonthlyTitle.AutoSize = True
        Me.lblMonthlyTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblMonthlyTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblMonthlyTitle.Location = New System.Drawing.Point(64, 15)
        Me.lblMonthlyTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonthlyTitle.Name = "lblMonthlyTitle"
        Me.lblMonthlyTitle.Size = New System.Drawing.Size(196, 32)
        Me.lblMonthlyTitle.TabIndex = 0
        Me.lblMonthlyTitle.Text = "Monthly Report"
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1579, 641)
        Me.Controls.Add(Me.PanelCard5)
        Me.Controls.Add(Me.PanelCard4)
        Me.Controls.Add(Me.PanelMonthly)
        Me.Controls.Add(Me.PanelCard3)
        Me.Controls.Add(Me.PanelCard2)
        Me.Controls.Add(Me.PanelCard1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSTA - Dashboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.PanelCard1.ResumeLayout(False)
        Me.PanelCard1.PerformLayout()
        Me.PanelCard2.ResumeLayout(False)
        Me.PanelCard2.PerformLayout()
        Me.PanelCard3.ResumeLayout(False)
        Me.PanelCard3.PerformLayout()
        Me.PanelCard4.ResumeLayout(False)
        Me.PanelCard4.PerformLayout()
        Me.PanelCard5.ResumeLayout(False)
        Me.PanelCard5.PerformLayout()
        Me.PanelMonthly.ResumeLayout(False)
        Me.PanelMonthly.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DigitalSlipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViolationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelCard1 As Panel
    Friend WithEvents lblViolationsTitle As Label
    Friend WithEvents cmbCourseFilter As ComboBox
    Friend WithEvents PanelCard2 As Panel
    Friend WithEvents lblStudentsTitle As Label
    Friend WithEvents lblMonthVal As Label
    Friend WithEvents PanelCard3 As Panel
    Friend WithEvents lblRecordedTitle As Label
    Friend WithEvents lblViolationsVal As Label
    Friend WithEvents PanelCard4 As Panel
    Friend WithEvents lblPendingTitle As Label
    Friend WithEvents lblStudentsVal As Label
    Friend WithEvents PanelCard5 As Panel
    Friend WithEvents lblRequestsTitle As Label
    Friend WithEvents lblRequestsVal As Label
    Friend WithEvents PanelMonthly As Panel
    Friend WithEvents lblMonthlyTitle As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents LoggedInAdminUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportByOSAOfficerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblFilteryBy As Label
End Class