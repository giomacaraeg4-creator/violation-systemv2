<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DigitalViolationForm
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.grpStudentInfo = New System.Windows.Forms.GroupBox()
        Me.txtYearSection = New System.Windows.Forms.TextBox()
        Me.lblYearSection = New System.Windows.Forms.Label()
        Me.cmbProgram = New System.Windows.Forms.ComboBox()
        Me.lblProgram = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.txtStudentNo = New System.Windows.Forms.TextBox()
        Me.lblStudentNo = New System.Windows.Forms.Label()
        Me.grpViolationDetails = New System.Windows.Forms.GroupBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.rad4th = New System.Windows.Forms.RadioButton()
        Me.rad3rd = New System.Windows.Forms.RadioButton()
        Me.rad2nd = New System.Windows.Forms.RadioButton()
        Me.rad1st = New System.Windows.Forms.RadioButton()
        Me.lblOffense = New System.Windows.Forms.Label()
        Me.txtOtherDetails = New System.Windows.Forms.TextBox()
        Me.chkOther = New System.Windows.Forms.CheckBox()
        Me.chkGrooming = New System.Windows.Forms.CheckBox()
        Me.chkUniform = New System.Windows.Forms.CheckBox()
        Me.lblViolationType = New System.Windows.Forms.Label()
        Me.grpPunishment = New System.Windows.Forms.GroupBox()
        Me.chkExpulsion = New System.Windows.Forms.CheckBox()
        Me.chkDismissal = New System.Windows.Forms.CheckBox()
        Me.chkNonReadmission = New System.Windows.Forms.CheckBox()
        Me.chk5DaySuspension = New System.Windows.Forms.CheckBox()
        Me.chk3DaySuspension = New System.Windows.Forms.CheckBox()
        Me.chk1DaySuspension = New System.Windows.Forms.CheckBox()
        Me.chkConference = New System.Windows.Forms.CheckBox()
        Me.chkReprimand = New System.Windows.Forms.CheckBox()
        Me.lblProfessor = New System.Windows.Forms.Label()
        Me.txtProfessor = New System.Windows.Forms.TextBox()
        Me.lblOsaOfficer = New System.Windows.Forms.Label()
        Me.txtOsaOfficer = New System.Windows.Forms.TextBox()
        Me.lblDean = New System.Windows.Forms.Label()
        Me.txtDean = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnPrintSlip = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grpStudentInfo.SuspendLayout()
        Me.grpViolationDetails.SuspendLayout()
        Me.grpPunishment.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(430, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(394, 41)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Digital Violation Slip Form"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.Gray
        Me.lblSubtitle.Location = New System.Drawing.Point(465, 70)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(304, 20)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Fill in the details below to record a violation."
        '
        'grpStudentInfo
        '
        Me.grpStudentInfo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grpStudentInfo.Controls.Add(Me.txtYearSection)
        Me.grpStudentInfo.Controls.Add(Me.lblYearSection)
        Me.grpStudentInfo.Controls.Add(Me.cmbProgram)
        Me.grpStudentInfo.Controls.Add(Me.lblProgram)
        Me.grpStudentInfo.Controls.Add(Me.txtStudentName)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentName)
        Me.grpStudentInfo.Controls.Add(Me.txtStudentNo)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentNo)
        Me.grpStudentInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpStudentInfo.Location = New System.Drawing.Point(220, 110)
        Me.grpStudentInfo.Name = "grpStudentInfo"
        Me.grpStudentInfo.Size = New System.Drawing.Size(585, 175)
        Me.grpStudentInfo.TabIndex = 2
        Me.grpStudentInfo.TabStop = False
        Me.grpStudentInfo.Text = "Student Information"
        '
        'txtYearSection
        '
        Me.txtYearSection.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtYearSection.Location = New System.Drawing.Point(312, 125)
        Me.txtYearSection.Name = "txtYearSection"
        Me.txtYearSection.Size = New System.Drawing.Size(250, 30)
        Me.txtYearSection.TabIndex = 7
        '
        'lblYearSection
        '
        Me.lblYearSection.AutoSize = True
        Me.lblYearSection.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblYearSection.Location = New System.Drawing.Point(308, 100)
        Me.lblYearSection.Name = "lblYearSection"
        Me.lblYearSection.Size = New System.Drawing.Size(101, 20)
        Me.lblYearSection.TabIndex = 6
        Me.lblYearSection.Text = "Year & Section :"
        '
        'cmbProgram
        '
        Me.cmbProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProgram.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbProgram.FormattingEnabled = True
        Me.cmbProgram.Location = New System.Drawing.Point(20, 125)
        Me.cmbProgram.Name = "cmbProgram"
        Me.cmbProgram.Size = New System.Drawing.Size(255, 31)
        Me.cmbProgram.TabIndex = 5
        '
        'lblProgram
        '
        Me.lblProgram.AutoSize = True
        Me.lblProgram.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblProgram.Location = New System.Drawing.Point(16, 100)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(73, 20)
        Me.lblProgram.TabIndex = 4
        Me.lblProgram.Text = "Program :"
        '
        'txtStudentName
        '
        Me.txtStudentName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtStudentName.Location = New System.Drawing.Point(312, 55)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(250, 30)
        Me.txtStudentName.TabIndex = 3
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStudentName.Location = New System.Drawing.Point(308, 30)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(111, 20)
        Me.lblStudentName.TabIndex = 2
        Me.lblStudentName.Text = "Student Name :"
        '
        'txtStudentNo
        '
        Me.txtStudentNo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtStudentNo.Location = New System.Drawing.Point(20, 55)
        Me.txtStudentNo.Name = "txtStudentNo"
        Me.txtStudentNo.Size = New System.Drawing.Size(255, 30)
        Me.txtStudentNo.TabIndex = 1
        '
        'lblStudentNo
        '
        Me.lblStudentNo.AutoSize = True
        Me.lblStudentNo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStudentNo.Location = New System.Drawing.Point(16, 30)
        Me.lblStudentNo.Name = "lblStudentNo"
        Me.lblStudentNo.Size = New System.Drawing.Size(125, 20)
        Me.lblStudentNo.TabIndex = 0
        Me.lblStudentNo.Text = "Student Number :"
        '
        'grpViolationDetails
        '
        Me.grpViolationDetails.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grpViolationDetails.Controls.Add(Me.txtRemarks)
        Me.grpViolationDetails.Controls.Add(Me.lblRemarks)
        Me.grpViolationDetails.Controls.Add(Me.dtpDate)
        Me.grpViolationDetails.Controls.Add(Me.lblDate)
        Me.grpViolationDetails.Controls.Add(Me.rad4th)
        Me.grpViolationDetails.Controls.Add(Me.rad3rd)
        Me.grpViolationDetails.Controls.Add(Me.rad2nd)
        Me.grpViolationDetails.Controls.Add(Me.rad1st)
        Me.grpViolationDetails.Controls.Add(Me.lblOffense)
        Me.grpViolationDetails.Controls.Add(Me.txtOtherDetails)
        Me.grpViolationDetails.Controls.Add(Me.chkOther)
        Me.grpViolationDetails.Controls.Add(Me.chkGrooming)
        Me.grpViolationDetails.Controls.Add(Me.chkUniform)
        Me.grpViolationDetails.Controls.Add(Me.lblViolationType)
        Me.grpViolationDetails.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpViolationDetails.Location = New System.Drawing.Point(220, 300)
        Me.grpViolationDetails.Name = "grpViolationDetails"
        Me.grpViolationDetails.Size = New System.Drawing.Size(585, 330)
        Me.grpViolationDetails.TabIndex = 3
        Me.grpViolationDetails.TabStop = False
        Me.grpViolationDetails.Text = "Violation Details"
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtRemarks.Location = New System.Drawing.Point(20, 230)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(542, 80)
        Me.txtRemarks.TabIndex = 13
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblRemarks.Location = New System.Drawing.Point(16, 205)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(75, 20)
        Me.lblRemarks.TabIndex = 12
        Me.lblRemarks.Text = "Remarks *"
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(335, 155)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(227, 30)
        Me.dtpDate.TabIndex = 11
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDate.Location = New System.Drawing.Point(331, 130)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(51, 20)
        Me.lblDate.TabIndex = 10
        Me.lblDate.Text = "Date *"
        '
        'rad4th
        '
        Me.rad4th.AutoSize = True
        Me.rad4th.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rad4th.Location = New System.Drawing.Point(195, 157)
        Me.rad4th.Name = "rad4th"
        Me.rad4th.Size = New System.Drawing.Size(125, 24)
        Me.rad4th.TabIndex = 9
        Me.rad4th.TabStop = True
        Me.rad4th.Text = "4th and above"
        Me.rad4th.UseVisualStyleBackColor = True
        '
        'rad3rd
        '
        Me.rad3rd.AutoSize = True
        Me.rad3rd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rad3rd.Location = New System.Drawing.Point(135, 157)
        Me.rad3rd.Name = "rad3rd"
        Me.rad3rd.Size = New System.Drawing.Size(52, 24)
        Me.rad3rd.TabIndex = 8
        Me.rad3rd.TabStop = True
        Me.rad3rd.Text = "3rd"
        Me.rad3rd.UseVisualStyleBackColor = True
        '
        'rad2nd
        '
        Me.rad2nd.AutoSize = True
        Me.rad2nd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rad2nd.Location = New System.Drawing.Point(75, 157)
        Me.rad2nd.Name = "rad2nd"
        Me.rad2nd.Size = New System.Drawing.Size(55, 24)
        Me.rad2nd.TabIndex = 7
        Me.rad2nd.TabStop = True
        Me.rad2nd.Text = "2nd"
        Me.rad2nd.UseVisualStyleBackColor = True
        '
        'rad1st
        '
        Me.rad1st.AutoSize = True
        Me.rad1st.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rad1st.Location = New System.Drawing.Point(20, 157)
        Me.rad1st.Name = "rad1st"
        Me.rad1st.Size = New System.Drawing.Size(49, 24)
        Me.rad1st.TabIndex = 6
        Me.rad1st.TabStop = True
        Me.rad1st.Text = "1st"
        Me.rad1st.UseVisualStyleBackColor = True
        '
        'lblOffense
        '
        Me.lblOffense.AutoSize = True
        Me.lblOffense.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblOffense.Location = New System.Drawing.Point(16, 130)
        Me.lblOffense.Name = "lblOffense"
        Me.lblOffense.Size = New System.Drawing.Size(146, 20)
        Me.lblOffense.TabIndex = 5
        Me.lblOffense.Text = "Number of Offense *"
        '
        'txtOtherDetails
        '
        Me.txtOtherDetails.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtOtherDetails.Location = New System.Drawing.Point(335, 60)
        Me.txtOtherDetails.Multiline = True
        Me.txtOtherDetails.Name = "txtOtherDetails"
        Me.txtOtherDetails.Size = New System.Drawing.Size(227, 55)
        Me.txtOtherDetails.TabIndex = 4
        '
        'chkOther
        '
        Me.chkOther.AutoSize = True
        Me.chkOther.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkOther.Location = New System.Drawing.Point(260, 60)
        Me.chkOther.Name = "chkOther"
        Me.chkOther.Size = New System.Drawing.Size(68, 24)
        Me.chkOther.TabIndex = 3
        Me.chkOther.Text = "Other"
        Me.chkOther.UseVisualStyleBackColor = True
        '
        'chkGrooming
        '
        Me.chkGrooming.AutoSize = True
        Me.chkGrooming.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkGrooming.Location = New System.Drawing.Point(20, 90)
        Me.chkGrooming.Name = "chkGrooming"
        Me.chkGrooming.Size = New System.Drawing.Size(170, 24)
        Me.chkGrooming.TabIndex = 2
        Me.chkGrooming.Text = "No Proper Grooming"
        Me.chkGrooming.UseVisualStyleBackColor = True
        '
        'chkUniform
        '
        Me.chkUniform.AutoSize = True
        Me.chkUniform.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkUniform.Location = New System.Drawing.Point(20, 60)
        Me.chkUniform.Name = "chkUniform"
        Me.chkUniform.Size = New System.Drawing.Size(157, 24)
        Me.chkUniform.TabIndex = 1
        Me.chkUniform.Text = "No Proper Uniform"
        Me.chkUniform.UseVisualStyleBackColor = True
        '
        'lblViolationType
        '
        Me.lblViolationType.AutoSize = True
        Me.lblViolationType.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblViolationType.Location = New System.Drawing.Point(16, 30)
        Me.lblViolationType.Name = "lblViolationType"
        Me.lblViolationType.Size = New System.Drawing.Size(114, 20)
        Me.lblViolationType.TabIndex = 0
        Me.lblViolationType.Text = "Violation Type *"
        '
        'grpPunishment
        '
        Me.grpPunishment.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grpPunishment.Controls.Add(Me.chkExpulsion)
        Me.grpPunishment.Controls.Add(Me.chkDismissal)
        Me.grpPunishment.Controls.Add(Me.chkNonReadmission)
        Me.grpPunishment.Controls.Add(Me.chk5DaySuspension)
        Me.grpPunishment.Controls.Add(Me.chk3DaySuspension)
        Me.grpPunishment.Controls.Add(Me.chk1DaySuspension)
        Me.grpPunishment.Controls.Add(Me.chkConference)
        Me.grpPunishment.Controls.Add(Me.chkReprimand)
        Me.grpPunishment.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpPunishment.Location = New System.Drawing.Point(825, 110)
        Me.grpPunishment.Name = "grpPunishment"
        Me.grpPunishment.Size = New System.Drawing.Size(370, 310)
        Me.grpPunishment.TabIndex = 4
        Me.grpPunishment.TabStop = False
        Me.grpPunishment.Text = "Categories of Punishment *"
        '
        'chkExpulsion
        '
        Me.chkExpulsion.AutoSize = True
        Me.chkExpulsion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkExpulsion.Location = New System.Drawing.Point(20, 260)
        Me.chkExpulsion.Name = "chkExpulsion"
        Me.chkExpulsion.Size = New System.Drawing.Size(116, 24)
        Me.chkExpulsion.TabIndex = 7
        Me.chkExpulsion.Text = "E - Expulsion"
        Me.chkExpulsion.UseVisualStyleBackColor = True
        '
        'chkDismissal
        '
        Me.chkDismissal.AutoSize = True
        Me.chkDismissal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkDismissal.Location = New System.Drawing.Point(20, 225)
        Me.chkDismissal.Name = "chkDismissal"
        Me.chkDismissal.Size = New System.Drawing.Size(118, 24)
        Me.chkDismissal.TabIndex = 6
        Me.chkDismissal.Text = "D - Dismissal"
        Me.chkDismissal.UseVisualStyleBackColor = True
        '
        'chkNonReadmission
        '
        Me.chkNonReadmission.AutoSize = True
        Me.chkNonReadmission.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkNonReadmission.Location = New System.Drawing.Point(20, 190)
        Me.chkNonReadmission.Name = "chkNonReadmission"
        Me.chkNonReadmission.Size = New System.Drawing.Size(179, 24)
        Me.chkNonReadmission.TabIndex = 5
        Me.chkNonReadmission.Text = "NR - Non-readmission"
        Me.chkNonReadmission.UseVisualStyleBackColor = True
        '
        'chk5DaySuspension
        '
        Me.chk5DaySuspension.AutoSize = True
        Me.chk5DaySuspension.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chk5DaySuspension.Location = New System.Drawing.Point(20, 155)
        Me.chk5DaySuspension.Name = "chk5DaySuspension"
        Me.chk5DaySuspension.Size = New System.Drawing.Size(199, 24)
        Me.chk5DaySuspension.TabIndex = 4
        Me.chk5DaySuspension.Text = "C.3 - Five-day Suspension"
        Me.chk5DaySuspension.UseVisualStyleBackColor = True
        '
        'chk3DaySuspension
        '
        Me.chk3DaySuspension.AutoSize = True
        Me.chk3DaySuspension.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chk3DaySuspension.Location = New System.Drawing.Point(20, 120)
        Me.chk3DaySuspension.Name = "chk3DaySuspension"
        Me.chk3DaySuspension.Size = New System.Drawing.Size(210, 24)
        Me.chk3DaySuspension.TabIndex = 3
        Me.chk3DaySuspension.Text = "C.2 - Three-day Suspension"
        Me.chk3DaySuspension.UseVisualStyleBackColor = True
        '
        'chk1DaySuspension
        '
        Me.chk1DaySuspension.AutoSize = True
        Me.chk1DaySuspension.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chk1DaySuspension.Location = New System.Drawing.Point(20, 85)
        Me.chk1DaySuspension.Name = "chk1DaySuspension"
        Me.chk1DaySuspension.Size = New System.Drawing.Size(200, 24)
        Me.chk1DaySuspension.TabIndex = 2
        Me.chk1DaySuspension.Text = "C.1 - One-day Suspension"
        Me.chk1DaySuspension.UseVisualStyleBackColor = True
        '
        'chkConference
        '
        Me.chkConference.AutoSize = True
        Me.chkConference.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkConference.Location = New System.Drawing.Point(20, 50)
        Me.chkConference.Name = "chkConference"
        Me.chkConference.Size = New System.Drawing.Size(129, 24)
        Me.chkConference.TabIndex = 1
        Me.chkConference.Text = "B - Conference"
        Me.chkConference.UseVisualStyleBackColor = True
        '
        'chkReprimand
        '
        Me.chkReprimand.AutoSize = True
        Me.chkReprimand.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkReprimand.Location = New System.Drawing.Point(20, 25)
        Me.chkReprimand.Name = "chkReprimand"
        Me.chkReprimand.Size = New System.Drawing.Size(128, 24)
        Me.chkReprimand.TabIndex = 0
        Me.chkReprimand.Text = "A - Reprimand"
        Me.chkReprimand.UseVisualStyleBackColor = True
        '
        'lblProfessor
        '
        Me.lblProfessor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblProfessor.AutoSize = True
        Me.lblProfessor.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblProfessor.Location = New System.Drawing.Point(821, 435)
        Me.lblProfessor.Name = "lblProfessor"
        Me.lblProfessor.Size = New System.Drawing.Size(174, 20)
        Me.lblProfessor.TabIndex = 5
        Me.lblProfessor.Text = "Endorse by (Professor) *"
        '
        'txtProfessor
        '
        Me.txtProfessor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtProfessor.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtProfessor.Location = New System.Drawing.Point(825, 460)
        Me.txtProfessor.Name = "txtProfessor"
        Me.txtProfessor.Size = New System.Drawing.Size(370, 30)
        Me.txtProfessor.TabIndex = 6
        '
        'lblOsaOfficer
        '
        Me.lblOsaOfficer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblOsaOfficer.AutoSize = True
        Me.lblOsaOfficer.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblOsaOfficer.Location = New System.Drawing.Point(821, 505)
        Me.lblOsaOfficer.Name = "lblOsaOfficer"
        Me.lblOsaOfficer.Size = New System.Drawing.Size(166, 20)
        Me.lblOsaOfficer.TabIndex = 7
        Me.lblOsaOfficer.Text = "Noted by (OSA Officer)"
        '
        'txtOsaOfficer
        '
        Me.txtOsaOfficer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtOsaOfficer.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtOsaOfficer.Location = New System.Drawing.Point(825, 530)
        Me.txtOsaOfficer.Name = "txtOsaOfficer"
        Me.txtOsaOfficer.Size = New System.Drawing.Size(370, 30)
        Me.txtOsaOfficer.TabIndex = 8
        '
        'lblDean
        '
        Me.lblDean.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDean.AutoSize = True
        Me.lblDean.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDean.Location = New System.Drawing.Point(821, 575)
        Me.lblDean.Name = "lblDean"
        Me.lblDean.Size = New System.Drawing.Size(140, 20)
        Me.lblDean.TabIndex = 9
        Me.lblDean.Text = "Affirmed by (Dean)"
        '
        'txtDean
        '
        Me.txtDean.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDean.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtDean.Location = New System.Drawing.Point(825, 600)
        Me.txtDean.Name = "txtDean"
        Me.txtDean.Size = New System.Drawing.Size(370, 30)
        Me.txtDean.TabIndex = 10
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(795, 650)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(120, 40)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnPrintSlip
        '
        Me.btnPrintSlip.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPrintSlip.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnPrintSlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintSlip.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrintSlip.ForeColor = System.Drawing.Color.White
        Me.btnPrintSlip.Location = New System.Drawing.Point(925, 650)
        Me.btnPrintSlip.Name = "btnPrintSlip"
        Me.btnPrintSlip.Size = New System.Drawing.Size(130, 40)
        Me.btnPrintSlip.TabIndex = 12
        Me.btnPrintSlip.Text = "Print Slip"
        Me.btnPrintSlip.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(1065, 650)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(130, 40)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'DigitalViolationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1400, 750)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnPrintSlip)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtDean)
        Me.Controls.Add(Me.lblDean)
        Me.Controls.Add(Me.txtOsaOfficer)
        Me.Controls.Add(Me.lblOsaOfficer)
        Me.Controls.Add(Me.txtProfessor)
        Me.Controls.Add(Me.lblProfessor)
        Me.Controls.Add(Me.grpPunishment)
        Me.Controls.Add(Me.grpViolationDetails)
        Me.Controls.Add(Me.grpStudentInfo)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "DigitalViolationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSTA - Digital Violation Slip Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpStudentInfo.ResumeLayout(False)
        Me.grpStudentInfo.PerformLayout()
        Me.grpViolationDetails.ResumeLayout(False)
        Me.grpViolationDetails.PerformLayout()
        Me.grpPunishment.ResumeLayout(False)
        Me.grpPunishment.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents grpStudentInfo As GroupBox
    Friend WithEvents txtYearSection As TextBox
    Friend WithEvents lblYearSection As Label
    Friend WithEvents cmbProgram As ComboBox
    Friend WithEvents lblProgram As Label
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents lblStudentName As Label
    Friend WithEvents txtStudentNo As TextBox
    Friend WithEvents lblStudentNo As Label
    Friend WithEvents grpViolationDetails As GroupBox
    Friend WithEvents chkUniform As CheckBox
    Friend WithEvents lblViolationType As Label
    Friend WithEvents chkOther As CheckBox
    Friend WithEvents chkGrooming As CheckBox
    Friend WithEvents txtOtherDetails As TextBox
    Friend WithEvents lblOffense As Label
    Friend WithEvents rad1st As RadioButton
    Friend WithEvents rad4th As RadioButton
    Friend WithEvents rad3rd As RadioButton
    Friend WithEvents rad2nd As RadioButton
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lblDate As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents lblRemarks As Label
    Friend WithEvents grpPunishment As GroupBox
    Friend WithEvents chkExpulsion As CheckBox
    Friend WithEvents chkDismissal As CheckBox
    Friend WithEvents chkNonReadmission As CheckBox
    Friend WithEvents chk5DaySuspension As CheckBox
    Friend WithEvents chk3DaySuspension As CheckBox
    Friend WithEvents chk1DaySuspension As CheckBox
    Friend WithEvents chkConference As CheckBox
    Friend WithEvents chkReprimand As CheckBox
    Friend WithEvents lblProfessor As Label
    Friend WithEvents txtProfessor As TextBox
    Friend WithEvents lblOsaOfficer As Label
    Friend WithEvents txtOsaOfficer As TextBox
    Friend WithEvents lblDean As Label
    Friend WithEvents txtDean As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnPrintSlip As Button
    Friend WithEvents btnSave As Button
End Class