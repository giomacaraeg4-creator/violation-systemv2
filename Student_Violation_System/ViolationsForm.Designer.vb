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
        Me.DigitalSlipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.cmbFilterProgram = New System.Windows.Forms.ComboBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnAddviolation = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnTrashBin = New System.Windows.Forms.Button()
        Me.dgvRecent = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.student_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.student_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.program = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.year_section = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.violation_type = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.offense_count = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.punishment_category = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.endorsed_by_prof = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.created_at = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.dgvRecent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.DigitalSlipToolStripMenuItem, Me.ViolationsToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.AdminUserToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1312, 31)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DashboardToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(110, 27)
        Me.DashboardToolStripMenuItem.Text = " Dashboard"
        '
        'DigitalSlipToolStripMenuItem
        '
        Me.DigitalSlipToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DigitalSlipToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DigitalSlipToolStripMenuItem.Name = "DigitalSlipToolStripMenuItem"
        Me.DigitalSlipToolStripMenuItem.Size = New System.Drawing.Size(103, 27)
        Me.DigitalSlipToolStripMenuItem.Text = "Digital Slip"
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
        Me.LogOutToolStripMenuItem.Text = "🚪 Log Out"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(40, 55)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(351, 37)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Student Violation Records"
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblSubTitle.Location = New System.Drawing.Point(43, 92)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(395, 21)
        Me.lblSubTitle.TabIndex = 2
        Me.lblSubTitle.Text = "Manage and track student violation records and history."
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.Gray
        Me.txtSearch.Location = New System.Drawing.Point(40, 129)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(240, 37)
        Me.txtSearch.TabIndex = 3
        Me.txtSearch.Text = "Search by Student Number"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSearch.Location = New System.Drawing.Point(290, 129)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 37)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblFilter.Location = New System.Drawing.Point(505, 140)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(77, 21)
        Me.lblFilter.TabIndex = 9
        Me.lblFilter.Text = "Filter By :"
        '
        'cmbFilterProgram
        '
        Me.cmbFilterProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilterProgram.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbFilterProgram.FormattingEnabled = True
        Me.cmbFilterProgram.Location = New System.Drawing.Point(586, 132)
        Me.cmbFilterProgram.Name = "cmbFilterProgram"
        Me.cmbFilterProgram.Size = New System.Drawing.Size(130, 31)
        Me.cmbFilterProgram.TabIndex = 10
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRefresh.Location = New System.Drawing.Point(395, 129)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(90, 37)
        Me.btnRefresh.TabIndex = 11
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnAddviolation
        '
        Me.btnAddviolation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddviolation.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAddviolation.FlatAppearance.BorderSize = 0
        Me.btnAddviolation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddviolation.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnAddviolation.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddviolation.Location = New System.Drawing.Point(852, 129)
        Me.btnAddviolation.Name = "btnAddviolation"
        Me.btnAddviolation.Size = New System.Drawing.Size(148, 37)
        Me.btnAddviolation.TabIndex = 4
        Me.btnAddviolation.Text = "Add Violation"
        Me.btnAddviolation.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.Location = New System.Drawing.Point(1008, 129)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(113, 37)
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
        Me.btnTrashBin.Location = New System.Drawing.Point(1129, 129)
        Me.btnTrashBin.Name = "btnTrashBin"
        Me.btnTrashBin.Size = New System.Drawing.Size(127, 37)
        Me.btnTrashBin.TabIndex = 8
        Me.btnTrashBin.Text = "Trash Bin"
        Me.btnTrashBin.UseVisualStyleBackColor = False
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
        Me.dgvRecent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.student_number, Me.student_name, Me.program, Me.year_section, Me.violation_type, Me.offense_count, Me.punishment_category, Me.endorsed_by_prof, Me.created_at})
        Me.dgvRecent.Location = New System.Drawing.Point(40, 185)
        Me.dgvRecent.Name = "dgvRecent"
        Me.dgvRecent.ReadOnly = True
        Me.dgvRecent.RowHeadersVisible = False
        Me.dgvRecent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecent.Size = New System.Drawing.Size(1216, 554)
        Me.dgvRecent.TabIndex = 5
        '
        'ID
        '
        Me.ID.DataPropertyName = "record_id"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'student_number
        '
        Me.student_number.DataPropertyName = "student_number"
        Me.student_number.HeaderText = "Student No."
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
        Me.year_section.HeaderText = "Year & Section"
        Me.year_section.Name = "year_section"
        Me.year_section.ReadOnly = True
        '
        'violation_type
        '
        Me.violation_type.HeaderText = "Violation Type"
        Me.violation_type.Name = "violation_type"
        Me.violation_type.ReadOnly = True
        '
        'offense_count
        '
        Me.offense_count.HeaderText = "Offense Count"
        Me.offense_count.Name = "offense_count"
        Me.offense_count.ReadOnly = True
        '
        'punishment_category
        '
        Me.punishment_category.HeaderText = "Punishment"
        Me.punishment_category.Name = "punishment_category"
        Me.punishment_category.ReadOnly = True
        '
        'endorsed_by_prof
        '
        Me.endorsed_by_prof.HeaderText = "Recorded By"
        Me.endorsed_by_prof.Name = "endorsed_by_prof"
        Me.endorsed_by_prof.ReadOnly = True
        '
        'created_at
        '
        Me.created_at.HeaderText = "Date Recorded"
        Me.created_at.Name = "created_at"
        Me.created_at.ReadOnly = True
        '
        'ViolationsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1312, 777)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.cmbFilterProgram)
        Me.Controls.Add(Me.lblFilter)
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
    Friend WithEvents lblFilter As Label
    Friend WithEvents cmbFilterProgram As ComboBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents LoggedInAdminUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportByOSAOfficerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DigitalSlipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents student_number As DataGridViewTextBoxColumn
    Friend WithEvents student_name As DataGridViewTextBoxColumn
    Friend WithEvents program As DataGridViewTextBoxColumn
    Friend WithEvents year_section As DataGridViewTextBoxColumn
    Friend WithEvents violation_type As DataGridViewComboBoxColumn
    Friend WithEvents offense_count As DataGridViewComboBoxColumn
    Friend WithEvents punishment_category As DataGridViewComboBoxColumn
    Friend WithEvents endorsed_by_prof As DataGridViewComboBoxColumn
    Friend WithEvents created_at As DataGridViewComboBoxColumn
End Class