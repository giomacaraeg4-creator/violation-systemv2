<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportsForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.cmbFilterReports = New System.Windows.Forms.ComboBox()
        Me.btnPrintReport = New System.Windows.Forms.Button()
        Me.btnDeleteReport = New System.Windows.Forms.Button()
        Me.dgvReports = New System.Windows.Forms.DataGridView()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnTrashBim = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.StudentListToolStripMenuItem, Me.DigitalSlipToolStripMenuItem, Me.ViolationsToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.AdminUserToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 5, 0, 5)
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DashboardToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(88, 23)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
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
        'ViolationsToolStripMenuItem
        '
        Me.ViolationsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ViolationsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViolationsToolStripMenuItem.Name = "ViolationsToolStripMenuItem"
        Me.ViolationsToolStripMenuItem.Size = New System.Drawing.Size(84, 23)
        Me.ViolationsToolStripMenuItem.Text = "Violations"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ReportsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(69, 23)
        Me.ReportsToolStripMenuItem.Text = "Reports"
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
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoggedInAdminUserToolStripMenuItem, Me.ReportByOSAOfficerToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.OwnerItem = Me.AdminUserToolStripMenuItem
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
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(30, 45)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(215, 32)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Violation Reports"
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblSubTitle.Location = New System.Drawing.Point(32, 80)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(363, 19)
        Me.lblSubTitle.TabIndex = 2
        Me.lblSubTitle.Text = "Generate, filter, print, and manage official student records."
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblFilter.Location = New System.Drawing.Point(30, 125)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(63, 19)
        Me.lblFilter.TabIndex = 3
        Me.lblFilter.Text = "Filter By:"
        '
        'cmbFilterReports
        '
        Me.cmbFilterReports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilterReports.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cmbFilterReports.FormattingEnabled = True
        Me.cmbFilterReports.Items.AddRange(New Object() {"All Violations", "No Proper Uniform", "No Proper Grooming", "Other Violations"})
        Me.cmbFilterReports.Location = New System.Drawing.Point(100, 122)
        Me.cmbFilterReports.Name = "cmbFilterReports"
        Me.cmbFilterReports.Size = New System.Drawing.Size(220, 27)
        Me.cmbFilterReports.TabIndex = 4
        '
        'btnPrintReport
        '
        Me.btnPrintReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintReport.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnPrintReport.FlatAppearance.BorderSize = 0
        Me.btnPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintReport.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrintReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPrintReport.Location = New System.Drawing.Point(673, 120)
        Me.btnPrintReport.Name = "btnPrintReport"
        Me.btnPrintReport.Size = New System.Drawing.Size(106, 35)
        Me.btnPrintReport.TabIndex = 5
        Me.btnPrintReport.Text = "Print Report"
        Me.btnPrintReport.UseVisualStyleBackColor = False
        '
        'btnDeleteReport
        '
        Me.btnDeleteReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteReport.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnDeleteReport.FlatAppearance.BorderSize = 0
        Me.btnDeleteReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteReport.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDeleteReport.Location = New System.Drawing.Point(785, 120)
        Me.btnDeleteReport.Name = "btnDeleteReport"
        Me.btnDeleteReport.Size = New System.Drawing.Size(92, 35)
        Me.btnDeleteReport.TabIndex = 6
        Me.btnDeleteReport.Text = "Delete "
        Me.btnDeleteReport.UseVisualStyleBackColor = False
        '
        'dgvReports
        '
        Me.dgvReports.AllowUserToAddRows = False
        Me.dgvReports.AllowUserToDeleteRows = False
        Me.dgvReports.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReports.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReports.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.dgvReports.Location = New System.Drawing.Point(30, 170)
        Me.dgvReports.MultiSelect = False
        Me.dgvReports.Name = "dgvReports"
        Me.dgvReports.ReadOnly = True
        Me.dgvReports.RowHeadersWidth = 51
        Me.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReports.Size = New System.Drawing.Size(945, 500)
        Me.dgvReports.TabIndex = 7
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'btnTrashBim
        '
        Me.btnTrashBim.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTrashBim.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnTrashBim.FlatAppearance.BorderSize = 0
        Me.btnTrashBim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrashBim.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnTrashBim.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTrashBim.Location = New System.Drawing.Point(883, 120)
        Me.btnTrashBim.Name = "btnTrashBim"
        Me.btnTrashBim.Size = New System.Drawing.Size(92, 35)
        Me.btnTrashBim.TabIndex = 8
        Me.btnTrashBim.Text = "Trash Bin"
        Me.btnTrashBim.UseVisualStyleBackColor = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "record_id"
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "student_number"
        Me.Column2.HeaderText = "Student Number"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "student_name"
        Me.Column3.HeaderText = "Student Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "program"
        Me.Column4.HeaderText = "Course"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "year_section"
        Me.Column5.HeaderText = "Year & Section"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "violation_type"
        Me.Column6.HeaderText = "Violation Type"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "offense_count"
        Me.Column7.HeaderText = "Offense Count"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "punishment_category"
        Me.Column8.HeaderText = "Punishment Category"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "status"
        Me.Column9.HeaderText = "Status"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "created_at"
        Me.Column10.HeaderText = "Date Recorded"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'ReportsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 705)
        Me.Controls.Add(Me.btnTrashBim)
        Me.Controls.Add(Me.dgvReports)
        Me.Controls.Add(Me.btnDeleteReport)
        Me.Controls.Add(Me.btnPrintReport)
        Me.Controls.Add(Me.cmbFilterReports)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.lblSubTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ReportsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSTA - Violation Reports"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblFilter As Label
    Friend WithEvents cmbFilterReports As ComboBox
    Friend WithEvents btnPrintReport As Button
    Friend WithEvents btnDeleteReport As Button
    Friend WithEvents dgvReports As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents LoggedInAdminUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportByOSAOfficerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DigitalSlipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents btnTrashBim As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
End Class