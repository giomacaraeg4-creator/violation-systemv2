<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViolationsForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViolationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LoggedInAdminUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportByOSAOfficerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnAddviolation = New System.Windows.Forms.Button()
        Me.dgvRecent = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnTrashBin = New System.Windows.Forms.Button()
        Me.StudentListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DigitalSlipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.student_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.student_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.program = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.year_section = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.violation_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.offense_count = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.punishment_category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.created_at = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPendingslip = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.dgvRecent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.StudentListToolStripMenuItem, Me.DigitalSlipToolStripMenuItem, Me.ViolationsToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.AdminUserToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DashboardToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(92, 23)
        Me.DashboardToolStripMenuItem.Text = " Dashboard"
        '
        'ViolationsToolStripMenuItem
        '
        Me.ViolationsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ViolationsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViolationsToolStripMenuItem.Name = "ViolationsToolStripMenuItem"
        Me.ViolationsToolStripMenuItem.Size = New System.Drawing.Size(88, 23)
        Me.ViolationsToolStripMenuItem.Text = " Violations"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ReportsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(73, 23)
        Me.ReportsToolStripMenuItem.Text = " Reports"
        '
        'AdminUserToolStripMenuItem
        '
        Me.AdminUserToolStripMenuItem.DropDown = Me.ContextMenuStrip1
        Me.AdminUserToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.AdminUserToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AdminUserToolStripMenuItem.Name = "AdminUserToolStripMenuItem"
        Me.AdminUserToolStripMenuItem.Size = New System.Drawing.Size(94, 23)
        Me.AdminUserToolStripMenuItem.Text = "Admin User"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoggedInAdminUserToolStripMenuItem, Me.ReportByOSAOfficerToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(196, 70)
        '
        'LoggedInAdminUserToolStripMenuItem
        '
        Me.LoggedInAdminUserToolStripMenuItem.Name = "LoggedInAdminUserToolStripMenuItem"
        Me.LoggedInAdminUserToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.LoggedInAdminUserToolStripMenuItem.Text = "Logged in: Admin User"
        '
        'ReportByOSAOfficerToolStripMenuItem
        '
        Me.ReportByOSAOfficerToolStripMenuItem.Name = "ReportByOSAOfficerToolStripMenuItem"
        Me.ReportByOSAOfficerToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ReportByOSAOfficerToolStripMenuItem.Text = "Report By: OSA Officer"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.LogOutToolStripMenuItem.Text = "🚪 Log Out"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(30, 45)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(281, 30)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Student Violation Records"
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblSubTitle.Location = New System.Drawing.Point(32, 75)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(335, 17)
        Me.lblSubTitle.TabIndex = 2
        Me.lblSubTitle.Text = "Manage and track student violation records and history."
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.Gray
        Me.txtSearch.Location = New System.Drawing.Point(30, 105)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 30)
        Me.txtSearch.TabIndex = 3
        Me.txtSearch.Text = "Search by Student Number"
        '
        'btnAddviolation
        '
        Me.btnAddviolation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddviolation.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAddviolation.FlatAppearance.BorderSize = 0
        Me.btnAddviolation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddviolation.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnAddviolation.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddviolation.Location = New System.Drawing.Point(531, 104)
        Me.btnAddviolation.Name = "btnAddviolation"
        Me.btnAddviolation.Size = New System.Drawing.Size(111, 30)
        Me.btnAddviolation.TabIndex = 4
        Me.btnAddviolation.Text = "Add Violation"
        Me.btnAddviolation.UseVisualStyleBackColor = False
        '
        'dgvRecent
        '
        Me.dgvRecent.AllowUserToAddRows = False
        Me.dgvRecent.AllowUserToDeleteRows = False
        Me.dgvRecent.AllowUserToResizeColumns = False
        Me.dgvRecent.AllowUserToResizeRows = False
        Me.dgvRecent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRecent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRecent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvRecent.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.dgvRecent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.student_number, Me.student_name, Me.program, Me.year_section, Me.violation_type, Me.offense_count, Me.punishment_category, Me.status, Me.created_at})
        Me.dgvRecent.Location = New System.Drawing.Point(30, 150)
        Me.dgvRecent.Name = "dgvRecent"
        Me.dgvRecent.ReadOnly = True
        Me.dgvRecent.RowHeadersVisible = False
        Me.dgvRecent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecent.Size = New System.Drawing.Size(912, 450)
        Me.dgvRecent.TabIndex = 5
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSearch.Location = New System.Drawing.Point(236, 105)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 30)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.Location = New System.Drawing.Point(756, 105)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 30)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnTrashBin
        '
        Me.btnTrashBin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTrashBin.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnTrashBin.FlatAppearance.BorderSize = 0
        Me.btnTrashBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrashBin.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnTrashBin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTrashBin.Location = New System.Drawing.Point(847, 105)
        Me.btnTrashBin.Name = "btnTrashBin"
        Me.btnTrashBin.Size = New System.Drawing.Size(95, 30)
        Me.btnTrashBin.TabIndex = 8
        Me.btnTrashBin.Text = "Trash Bin"
        Me.btnTrashBin.UseVisualStyleBackColor = False
        '
        'StudentListToolStripMenuItem
        '
        Me.StudentListToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.StudentListToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.StudentListToolStripMenuItem.Name = "StudentListToolStripMenuItem"
        Me.StudentListToolStripMenuItem.Size = New System.Drawing.Size(96, 23)
        Me.StudentListToolStripMenuItem.Text = "Student List"
        '
        'DigitalSlipToolStripMenuItem
        '
        Me.DigitalSlipToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DigitalSlipToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DigitalSlipToolStripMenuItem.Name = "DigitalSlipToolStripMenuItem"
        Me.DigitalSlipToolStripMenuItem.Size = New System.Drawing.Size(91, 23)
        Me.DigitalSlipToolStripMenuItem.Text = "Digital Slip"
        '
        'ID
        '
        Me.ID.DataPropertyName = "record_id"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'student_number
        '
        Me.student_number.DataPropertyName = "student_number"
        Me.student_number.HeaderText = "Student Number"
        Me.student_number.Name = "student_number"
        Me.student_number.ReadOnly = True
        '
        'student_name
        '
        Me.student_name.DataPropertyName = "student_name"
        Me.student_name.HeaderText = "Student Name"
        Me.student_name.Name = "student_name"
        Me.student_name.ReadOnly = True
        '
        'program
        '
        Me.program.DataPropertyName = "program"
        Me.program.HeaderText = "Program"
        Me.program.Name = "program"
        Me.program.ReadOnly = True
        '
        'year_section
        '
        Me.year_section.DataPropertyName = "year_section"
        Me.year_section.HeaderText = "Year Section"
        Me.year_section.Name = "year_section"
        Me.year_section.ReadOnly = True
        '
        'violation_type
        '
        Me.violation_type.DataPropertyName = "violation_type"
        Me.violation_type.HeaderText = "Violation Type"
        Me.violation_type.Name = "violation_type"
        Me.violation_type.ReadOnly = True
        '
        'offense_count
        '
        Me.offense_count.DataPropertyName = "offense_count"
        Me.offense_count.HeaderText = "Offense Count"
        Me.offense_count.Name = "offense_count"
        Me.offense_count.ReadOnly = True
        '
        'punishment_category
        '
        Me.punishment_category.DataPropertyName = "punishment_category"
        Me.punishment_category.HeaderText = "Punishment"
        Me.punishment_category.Name = "punishment_category"
        Me.punishment_category.ReadOnly = True
        '
        'status
        '
        Me.status.DataPropertyName = "status"
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'created_at
        '
        Me.created_at.DataPropertyName = "created_at"
        Me.created_at.HeaderText = "Date"
        Me.created_at.Name = "created_at"
        Me.created_at.ReadOnly = True
        '
        'btnPendingslip
        '
        Me.btnPendingslip.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPendingslip.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnPendingslip.FlatAppearance.BorderSize = 0
        Me.btnPendingslip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPendingslip.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnPendingslip.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPendingslip.Location = New System.Drawing.Point(648, 104)
        Me.btnPendingslip.Name = "btnPendingslip"
        Me.btnPendingslip.Size = New System.Drawing.Size(102, 30)
        Me.btnPendingslip.TabIndex = 9
        Me.btnPendingslip.Text = "Pending Slip"
        Me.btnPendingslip.UseVisualStyleBackColor = False
        '
        'ViolationsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 631)
        Me.Controls.Add(Me.btnPendingslip)
        Me.Controls.Add(Me.btnTrashBin)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dgvRecent)
        Me.Controls.Add(Me.btnAddviolation)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSubTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ViolationsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSTA - Violations Record"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.dgvRecent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViolationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnAddviolation As Button
    Friend WithEvents dgvRecent As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnTrashBin As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents LoggedInAdminUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportByOSAOfficerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DigitalSlipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents student_number As DataGridViewTextBoxColumn
    Friend WithEvents student_name As DataGridViewTextBoxColumn
    Friend WithEvents program As DataGridViewTextBoxColumn
    Friend WithEvents year_section As DataGridViewTextBoxColumn
    Friend WithEvents violation_type As DataGridViewTextBoxColumn
    Friend WithEvents offense_count As DataGridViewTextBoxColumn
    Friend WithEvents punishment_category As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents created_at As DataGridViewTextBoxColumn
    Friend WithEvents btnPendingslip As Button
End Class