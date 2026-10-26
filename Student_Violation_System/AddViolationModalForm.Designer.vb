<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddViolationModalForm
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
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblStudent = New System.Windows.Forms.Label()
        Me.cmbStudent = New System.Windows.Forms.ComboBox()
        Me.lblStudentNameTitle = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.lblProgramTitle = New System.Windows.Forms.Label()
        Me.txtProgram = New System.Windows.Forms.TextBox()
        Me.lblYearSectionTitle = New System.Windows.Forms.Label()
        Me.txtYearSection = New System.Windows.Forms.TextBox()
        Me.lblViolationTypeTitle = New System.Windows.Forms.Label()
        Me.cmbViolationType = New System.Windows.Forms.ComboBox()
        Me.lblOffenseCountTitle = New System.Windows.Forms.Label()
        Me.cmbOffenseCount = New System.Windows.Forms.ComboBox()
        Me.lblPunishmentTitle = New System.Windows.Forms.Label()
        Me.cmbPunishment = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.PanelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.lblTitle)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(484, 50)
        Me.PanelTop.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(211, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Add Student Violation"
        '
        'lblStudent
        '
        Me.lblStudent.AutoSize = True
        Me.lblStudent.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblStudent.Location = New System.Drawing.Point(25, 70)
        Me.lblStudent.Name = "lblStudent"
        Me.lblStudent.Size = New System.Drawing.Size(156, 17)
        Me.lblStudent.TabIndex = 1
        Me.lblStudent.Text = "Select Student Number :"
        '
        'cmbStudent
        '
        Me.cmbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStudent.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbStudent.FormattingEnabled = True
        Me.cmbStudent.Location = New System.Drawing.Point(28, 90)
        Me.cmbStudent.Name = "cmbStudent"
        Me.cmbStudent.Size = New System.Drawing.Size(430, 25)
        Me.cmbStudent.TabIndex = 2
        '
        'lblStudentNameTitle
        '
        Me.lblStudentNameTitle.AutoSize = True
        Me.lblStudentNameTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblStudentNameTitle.Location = New System.Drawing.Point(25, 130)
        Me.lblStudentNameTitle.Name = "lblStudentNameTitle"
        Me.lblStudentNameTitle.Size = New System.Drawing.Size(99, 17)
        Me.lblStudentNameTitle.TabIndex = 3
        Me.lblStudentNameTitle.Text = "Student Name:"
        '
        'txtStudentName
        '
        Me.txtStudentName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtStudentName.Location = New System.Drawing.Point(28, 150)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.ReadOnly = True
        Me.txtStudentName.Size = New System.Drawing.Size(430, 25)
        Me.txtStudentName.TabIndex = 4
        '
        'lblProgramTitle
        '
        Me.lblProgramTitle.AutoSize = True
        Me.lblProgramTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblProgramTitle.Location = New System.Drawing.Point(25, 190)
        Me.lblProgramTitle.Name = "lblProgramTitle"
        Me.lblProgramTitle.Size = New System.Drawing.Size(64, 17)
        Me.lblProgramTitle.TabIndex = 5
        Me.lblProgramTitle.Text = "Program:"
        '
        'txtProgram
        '
        Me.txtProgram.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtProgram.Location = New System.Drawing.Point(28, 210)
        Me.txtProgram.Name = "txtProgram"
        Me.txtProgram.ReadOnly = True
        Me.txtProgram.Size = New System.Drawing.Size(205, 25)
        Me.txtProgram.TabIndex = 6
        '
        'lblYearSectionTitle
        '
        Me.lblYearSectionTitle.AutoSize = True
        Me.lblYearSectionTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblYearSectionTitle.Location = New System.Drawing.Point(250, 190)
        Me.lblYearSectionTitle.Name = "lblYearSectionTitle"
        Me.lblYearSectionTitle.Size = New System.Drawing.Size(71, 17)
        Me.lblYearSectionTitle.TabIndex = 7
        Me.lblYearSectionTitle.Text = "Year Level:"
        '
        'txtYearSection
        '
        Me.txtYearSection.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtYearSection.Location = New System.Drawing.Point(253, 210)
        Me.txtYearSection.Name = "txtYearSection"
        Me.txtYearSection.ReadOnly = True
        Me.txtYearSection.Size = New System.Drawing.Size(205, 25)
        Me.txtYearSection.TabIndex = 8
        '
        'lblViolationTypeTitle
        '
        Me.lblViolationTypeTitle.AutoSize = True
        Me.lblViolationTypeTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblViolationTypeTitle.Location = New System.Drawing.Point(25, 250)
        Me.lblViolationTypeTitle.Name = "lblViolationTypeTitle"
        Me.lblViolationTypeTitle.Size = New System.Drawing.Size(96, 17)
        Me.lblViolationTypeTitle.TabIndex = 9
        Me.lblViolationTypeTitle.Text = "Violation Type:"
        '
        'cmbViolationType
        '
        Me.cmbViolationType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbViolationType.FormattingEnabled = True
        Me.cmbViolationType.Items.AddRange(New Object() {"No Proper Grooming", "Disrespectful Behavior", "ID Violation", "Late Attendance", "Uniform Violation", "Other"})
        Me.cmbViolationType.Location = New System.Drawing.Point(28, 270)
        Me.cmbViolationType.Name = "cmbViolationType"
        Me.cmbViolationType.Size = New System.Drawing.Size(430, 25)
        Me.cmbViolationType.TabIndex = 10
        '
        'lblOffenseCountTitle
        '
        Me.lblOffenseCountTitle.AutoSize = True
        Me.lblOffenseCountTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblOffenseCountTitle.Location = New System.Drawing.Point(25, 310)
        Me.lblOffenseCountTitle.Name = "lblOffenseCountTitle"
        Me.lblOffenseCountTitle.Size = New System.Drawing.Size(98, 17)
        Me.lblOffenseCountTitle.TabIndex = 11
        Me.lblOffenseCountTitle.Text = "Offense Count:"
        '
        'cmbOffenseCount
        '
        Me.cmbOffenseCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOffenseCount.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbOffenseCount.FormattingEnabled = True
        Me.cmbOffenseCount.Items.AddRange(New Object() {"1st", "2nd", "3rd"})
        Me.cmbOffenseCount.Location = New System.Drawing.Point(28, 330)
        Me.cmbOffenseCount.Name = "cmbOffenseCount"
        Me.cmbOffenseCount.Size = New System.Drawing.Size(205, 25)
        Me.cmbOffenseCount.TabIndex = 12
        '
        'lblPunishmentTitle
        '
        Me.lblPunishmentTitle.AutoSize = True
        Me.lblPunishmentTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblPunishmentTitle.Location = New System.Drawing.Point(250, 310)
        Me.lblPunishmentTitle.Name = "lblPunishmentTitle"
        Me.lblPunishmentTitle.Size = New System.Drawing.Size(144, 17)
        Me.lblPunishmentTitle.TabIndex = 13
        Me.lblPunishmentTitle.Text = "Punishment Category:"
        '
        'cmbPunishment
        '
        Me.cmbPunishment.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbPunishment.FormattingEnabled = True
        Me.cmbPunishment.Items.AddRange(New Object() {"C.1 - One-day Suspension", "C.2 - Three-day Suspension", "C.3 - Five-day Suspension", "D - Dismissal", "Warning / Reprimand"})
        Me.cmbPunishment.Location = New System.Drawing.Point(253, 330)
        Me.cmbPunishment.Name = "cmbPunishment"
        Me.cmbPunishment.Size = New System.Drawing.Size(205, 25)
        Me.cmbPunishment.TabIndex = 14
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(253, 385)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(105, 35)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save Violation"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(364, 385)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(94, 35)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'AddViolationModalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 441)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbPunishment)
        Me.Controls.Add(Me.lblPunishmentTitle)
        Me.Controls.Add(Me.cmbOffenseCount)
        Me.Controls.Add(Me.lblOffenseCountTitle)
        Me.Controls.Add(Me.cmbViolationType)
        Me.Controls.Add(Me.lblViolationTypeTitle)
        Me.Controls.Add(Me.txtYearSection)
        Me.Controls.Add(Me.lblYearSectionTitle)
        Me.Controls.Add(Me.txtProgram)
        Me.Controls.Add(Me.lblProgramTitle)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.lblStudentNameTitle)
        Me.Controls.Add(Me.cmbStudent)
        Me.Controls.Add(Me.lblStudent)
        Me.Controls.Add(Me.PanelTop)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddViolationModalForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSTA - Add Violation"
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTop As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblStudent As Label
    Friend WithEvents cmbStudent As ComboBox
    Friend WithEvents lblStudentNameTitle As Label
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents lblProgramTitle As Label
    Friend WithEvents txtProgram As TextBox
    Friend WithEvents lblYearSectionTitle As Label
    Friend WithEvents txtYearSection As TextBox
    Friend WithEvents lblViolationTypeTitle As Label
    Friend WithEvents cmbViolationType As ComboBox
    Friend WithEvents lblOffenseCountTitle As Label
    Friend WithEvents cmbOffenseCount As ComboBox
    Friend WithEvents lblPunishmentTitle As Label
    Friend WithEvents cmbPunishment As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class