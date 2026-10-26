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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DigitalViolationForm))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.grpStudentInfo = New System.Windows.Forms.GroupBox()
        Me.txtYearSection = New System.Windows.Forms.TextBox()
        Me.lblYearSection = New System.Windows.Forms.Label()
        Me.cmbProgram = New System.Windows.Forms.ComboBox()
        Me.lblProgram = New System.Windows.Forms.Label()
        Me.txtStudentNo = New System.Windows.Forms.TextBox()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.lblStudentName = New System.Windows.Forms.Label()
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
        Me.lblNumOfOffense = New System.Windows.Forms.Label()
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
        Me.txtProfessor = New System.Windows.Forms.TextBox()
        Me.lblProfessor = New System.Windows.Forms.Label()
        Me.txtOsaOfficer = New System.Windows.Forms.TextBox()
        Me.lblOsaOfficer = New System.Windows.Forms.Label()
        Me.txtDean = New System.Windows.Forms.TextBox()
        Me.lblDean = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.grpStudentInfo.SuspendLayout()
        Me.grpViolationDetails.SuspendLayout()
        Me.grpPunishment.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(30, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(325, 29)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Digital Violation Slip Form"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.ForeColor = System.Drawing.Color.DimGray
        Me.lblSubtitle.Location = New System.Drawing.Point(32, 60)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(268, 17)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Fill in the details below to record a violation."
        '
        'grpStudentInfo
        '
        Me.grpStudentInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpStudentInfo.Controls.Add(Me.txtYearSection)
        Me.grpStudentInfo.Controls.Add(Me.lblYearSection)
        Me.grpStudentInfo.Controls.Add(Me.cmbProgram)
        Me.grpStudentInfo.Controls.Add(Me.lblProgram)
        Me.grpStudentInfo.Controls.Add(Me.txtStudentNo)
        Me.grpStudentInfo.Controls.Add(Me.txtStudentName)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentName)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentNo)
        Me.grpStudentInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStudentInfo.Location = New System.Drawing.Point(120, 100)
        Me.grpStudentInfo.Name = "grpStudentInfo"
        Me.grpStudentInfo.Size = New System.Drawing.Size(550, 130)
        Me.grpStudentInfo.TabIndex = 2
        Me.grpStudentInfo.TabStop = False
        Me.grpStudentInfo.Text = "Student Information"
        '
        'txtYearSection
        '
        Me.txtYearSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYearSection.Location = New System.Drawing.Point(285, 90)
        Me.txtYearSection.Name = "txtYearSection"
        Me.txtYearSection.Size = New System.Drawing.Size(240, 23)
        Me.txtYearSection.TabIndex = 7
        '
        'lblYearSection
        '
        Me.lblYearSection.AutoSize = True
        Me.lblYearSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearSection.Location = New System.Drawing.Point(285, 70)
        Me.lblYearSection.Name = "lblYearSection"
        Me.lblYearSection.Size = New System.Drawing.Size(83, 15)
        Me.lblYearSection.TabIndex = 6
        Me.lblYearSection.Text = "Year Section :"
        '
        'cmbProgram
        '
        Me.cmbProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProgram.FormattingEnabled = True
        Me.cmbProgram.Items.AddRange(New Object() {"BSIT", "BSCS", "BSBA", "BSED"})
        Me.cmbProgram.Location = New System.Drawing.Point(20, 90)
        Me.cmbProgram.Name = "cmbProgram"
        Me.cmbProgram.Size = New System.Drawing.Size(240, 24)
        Me.cmbProgram.TabIndex = 5
        '
        'lblProgram
        '
        Me.lblProgram.AutoSize = True
        Me.lblProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgram.Location = New System.Drawing.Point(20, 70)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(60, 15)
        Me.lblProgram.TabIndex = 4
        Me.lblProgram.Text = "Program :"
        '
        'txtStudentNo
        '
        Me.txtStudentNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentNo.Location = New System.Drawing.Point(20, 45)
        Me.txtStudentNo.Name = "txtStudentNo"
        Me.txtStudentNo.Size = New System.Drawing.Size(240, 23)
        Me.txtStudentNo.TabIndex = 3
        '
        'txtStudentName
        '
        Me.txtStudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentName.Location = New System.Drawing.Point(285, 45)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(240, 23)
        Me.txtStudentName.TabIndex = 1
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.Location = New System.Drawing.Point(285, 25)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(92, 15)
        Me.lblStudentName.TabIndex = 0
        Me.lblStudentName.Text = "Student Name :"
        '
        'lblStudentNo
        '
        Me.lblStudentNo.AutoSize = True
        Me.lblStudentNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentNo.Location = New System.Drawing.Point(20, 25)
        Me.lblStudentNo.Name = "lblStudentNo"
        Me.lblStudentNo.Size = New System.Drawing.Size(103, 15)
        Me.lblStudentNo.TabIndex = 2
        Me.lblStudentNo.Text = "Student Number :"
        '
        'grpViolationDetails
        '
        Me.grpViolationDetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpViolationDetails.Controls.Add(Me.txtRemarks)
        Me.grpViolationDetails.Controls.Add(Me.lblRemarks)
        Me.grpViolationDetails.Controls.Add(Me.dtpDate)
        Me.grpViolationDetails.Controls.Add(Me.lblDate)
        Me.grpViolationDetails.Controls.Add(Me.rad4th)
        Me.grpViolationDetails.Controls.Add(Me.rad3rd)
        Me.grpViolationDetails.Controls.Add(Me.rad2nd)
        Me.grpViolationDetails.Controls.Add(Me.rad1st)
        Me.grpViolationDetails.Controls.Add(Me.lblNumOfOffense)
        Me.grpViolationDetails.Controls.Add(Me.txtOtherDetails)
        Me.grpViolationDetails.Controls.Add(Me.chkOther)
        Me.grpViolationDetails.Controls.Add(Me.chkGrooming)
        Me.grpViolationDetails.Controls.Add(Me.chkUniform)
        Me.grpViolationDetails.Controls.Add(Me.lblViolationType)
        Me.grpViolationDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpViolationDetails.Location = New System.Drawing.Point(120, 245)
        Me.grpViolationDetails.Name = "grpViolationDetails"
        Me.grpViolationDetails.Size = New System.Drawing.Size(550, 280)
        Me.grpViolationDetails.TabIndex = 3
        Me.grpViolationDetails.TabStop = False
        Me.grpViolationDetails.Text = "Violation Details"
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(20, 185)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(505, 75)
        Me.txtRemarks.TabIndex = 13
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemarks.Location = New System.Drawing.Point(20, 165)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(63, 15)
        Me.lblRemarks.TabIndex = 12
        Me.lblRemarks.Text = "Remarks *"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "MMM dd, yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(340, 130)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(185, 23)
        Me.dtpDate.TabIndex = 11
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(340, 110)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(39, 15)
        Me.lblDate.TabIndex = 10
        Me.lblDate.Text = "Date *"
        '
        'rad4th
        '
        Me.rad4th.AutoSize = True
        Me.rad4th.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad4th.Location = New System.Drawing.Point(210, 130)
        Me.rad4th.Name = "rad4th"
        Me.rad4th.Size = New System.Drawing.Size(107, 19)
        Me.rad4th.TabIndex = 9
        Me.rad4th.TabStop = True
        Me.rad4th.Text = "4th and above"
        Me.rad4th.UseVisualStyleBackColor = True
        '
        'rad3rd
        '
        Me.rad3rd.AutoSize = True
        Me.rad3rd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad3rd.Location = New System.Drawing.Point(150, 130)
        Me.rad3rd.Name = "rad3rd"
        Me.rad3rd.Size = New System.Drawing.Size(43, 19)
        Me.rad3rd.TabIndex = 8
        Me.rad3rd.TabStop = True
        Me.rad3rd.Text = "3rd"
        Me.rad3rd.UseVisualStyleBackColor = True
        '
        'rad2nd
        '
        Me.rad2nd.AutoSize = True
        Me.rad2nd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad2nd.Location = New System.Drawing.Point(85, 130)
        Me.rad2nd.Name = "rad2nd"
        Me.rad2nd.Size = New System.Drawing.Size(46, 19)
        Me.rad2nd.TabIndex = 7
        Me.rad2nd.TabStop = True
        Me.rad2nd.Text = "2nd"
        Me.rad2nd.UseVisualStyleBackColor = True
        '
        'rad1st
        '
        Me.rad1st.AutoSize = True
        Me.rad1st.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad1st.Location = New System.Drawing.Point(20, 130)
        Me.rad1st.Name = "rad1st"
        Me.rad1st.Size = New System.Drawing.Size(41, 19)
        Me.rad1st.TabIndex = 6
        Me.rad1st.TabStop = True
        Me.rad1st.Text = "1st"
        Me.rad1st.UseVisualStyleBackColor = True
        '
        'lblNumOfOffense
        '
        Me.lblNumOfOffense.AutoSize = True
        Me.lblNumOfOffense.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumOfOffense.Location = New System.Drawing.Point(20, 110)
        Me.lblNumOfOffense.Name = "lblNumOfOffense"
        Me.lblNumOfOffense.Size = New System.Drawing.Size(125, 15)
        Me.lblNumOfOffense.TabIndex = 5
        Me.lblNumOfOffense.Text = "Number of Offense *"
        '
        'txtOtherDetails
        '
        Me.txtOtherDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherDetails.Location = New System.Drawing.Point(250, 45)
        Me.txtOtherDetails.Multiline = True
        Me.txtOtherDetails.Name = "txtOtherDetails"
        Me.txtOtherDetails.Size = New System.Drawing.Size(275, 50)
        Me.txtOtherDetails.TabIndex = 4
        '
        'chkOther
        '
        Me.chkOther.AutoSize = True
        Me.chkOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOther.Location = New System.Drawing.Point(180, 45)
        Me.chkOther.Name = "chkOther"
        Me.chkOther.Size = New System.Drawing.Size(58, 19)
        Me.chkOther.TabIndex = 3
        Me.chkOther.Text = "Other"
        Me.chkOther.UseVisualStyleBackColor = True
        '
        'chkGrooming
        '
        Me.chkGrooming.AutoSize = True
        Me.chkGrooming.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGrooming.Location = New System.Drawing.Point(20, 75)
        Me.chkGrooming.Name = "chkGrooming"
        Me.chkGrooming.Size = New System.Drawing.Size(142, 19)
        Me.chkGrooming.TabIndex = 2
        Me.chkGrooming.Text = "No Proper Grooming"
        Me.chkGrooming.UseVisualStyleBackColor = True
        '
        'chkUniform
        '
        Me.chkUniform.AutoSize = True
        Me.chkUniform.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUniform.Location = New System.Drawing.Point(20, 45)
        Me.chkUniform.Name = "chkUniform"
        Me.chkUniform.Size = New System.Drawing.Size(130, 19)
        Me.chkUniform.TabIndex = 1
        Me.chkUniform.Text = "No Proper Uniform"
        Me.chkUniform.UseVisualStyleBackColor = True
        '
        'lblViolationType
        '
        Me.lblViolationType.AutoSize = True
        Me.lblViolationType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViolationType.Location = New System.Drawing.Point(20, 22)
        Me.lblViolationType.Name = "lblViolationType"
        Me.lblViolationType.Size = New System.Drawing.Size(95, 15)
        Me.lblViolationType.TabIndex = 0
        Me.lblViolationType.Text = "Violation Type *"
        '
        'grpPunishment
        '
        Me.grpPunishment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpPunishment.Controls.Add(Me.chkExpulsion)
        Me.grpPunishment.Controls.Add(Me.chkDismissal)
        Me.grpPunishment.Controls.Add(Me.chkNonReadmission)
        Me.grpPunishment.Controls.Add(Me.chk5DaySuspension)
        Me.grpPunishment.Controls.Add(Me.chk3DaySuspension)
        Me.grpPunishment.Controls.Add(Me.chk1DaySuspension)
        Me.grpPunishment.Controls.Add(Me.chkConference)
        Me.grpPunishment.Controls.Add(Me.chkReprimand)
        Me.grpPunishment.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPunishment.Location = New System.Drawing.Point(695, 100)
        Me.grpPunishment.Name = "grpPunishment"
        Me.grpPunishment.Size = New System.Drawing.Size(340, 260)
        Me.grpPunishment.TabIndex = 4
        Me.grpPunishment.TabStop = False
        Me.grpPunishment.Text = "Categories of Punishment *"
        '
        'chkExpulsion
        '
        Me.chkExpulsion.AutoSize = True
        Me.chkExpulsion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkExpulsion.Location = New System.Drawing.Point(20, 225)
        Me.chkExpulsion.Name = "chkExpulsion"
        Me.chkExpulsion.Size = New System.Drawing.Size(100, 19)
        Me.chkExpulsion.TabIndex = 7
        Me.chkExpulsion.Text = "E - Expulsion"
        Me.chkExpulsion.UseVisualStyleBackColor = True
        '
        'chkDismissal
        '
        Me.chkDismissal.AutoSize = True
        Me.chkDismissal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDismissal.Location = New System.Drawing.Point(20, 195)
        Me.chkDismissal.Name = "chkDismissal"
        Me.chkDismissal.Size = New System.Drawing.Size(101, 19)
        Me.chkDismissal.TabIndex = 6
        Me.chkDismissal.Text = "D - Dismissal"
        Me.chkDismissal.UseVisualStyleBackColor = True
        '
        'chkNonReadmission
        '
        Me.chkNonReadmission.AutoSize = True
        Me.chkNonReadmission.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNonReadmission.Location = New System.Drawing.Point(20, 165)
        Me.chkNonReadmission.Name = "chkNonReadmission"
        Me.chkNonReadmission.Size = New System.Drawing.Size(296, 19)
        Me.chkNonReadmission.TabIndex = 5
        Me.chkNonReadmission.Text = "NR - Non-readmission (for the incoming semester)"
        Me.chkNonReadmission.UseVisualStyleBackColor = True
        '
        'chk5DaySuspension
        '
        Me.chk5DaySuspension.AutoSize = True
        Me.chk5DaySuspension.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk5DaySuspension.Location = New System.Drawing.Point(20, 135)
        Me.chk5DaySuspension.Name = "chk5DaySuspension"
        Me.chk5DaySuspension.Size = New System.Drawing.Size(176, 19)
        Me.chk5DaySuspension.TabIndex = 4
        Me.chk5DaySuspension.Text = "C.3 - Five-day Suspension"
        Me.chk5DaySuspension.UseVisualStyleBackColor = True
        '
        'chk3DaySuspension
        '
        Me.chk3DaySuspension.AutoSize = True
        Me.chk3DaySuspension.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk3DaySuspension.Location = New System.Drawing.Point(20, 105)
        Me.chk3DaySuspension.Name = "chk3DaySuspension"
        Me.chk3DaySuspension.Size = New System.Drawing.Size(186, 19)
        Me.chk3DaySuspension.TabIndex = 3
        Me.chk3DaySuspension.Text = "C.2 - Three-day Suspension"
        Me.chk3DaySuspension.UseVisualStyleBackColor = True
        '
        'chk1DaySuspension
        '
        Me.chk1DaySuspension.AutoSize = True
        Me.chk1DaySuspension.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk1DaySuspension.Location = New System.Drawing.Point(20, 78)
        Me.chk1DaySuspension.Name = "chk1DaySuspension"
        Me.chk1DaySuspension.Size = New System.Drawing.Size(177, 19)
        Me.chk1DaySuspension.TabIndex = 2
        Me.chk1DaySuspension.Text = "C.1 - One-day Suspension"
        Me.chk1DaySuspension.UseVisualStyleBackColor = True
        '
        'chkConference
        '
        Me.chkConference.AutoSize = True
        Me.chkConference.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkConference.Location = New System.Drawing.Point(20, 52)
        Me.chkConference.Name = "chkConference"
        Me.chkConference.Size = New System.Drawing.Size(287, 19)
        Me.chkConference.TabIndex = 1
        Me.chkConference.Text = "B - Conference with the parents or guardians"
        Me.chkConference.UseVisualStyleBackColor = True
        '
        'chkReprimand
        '
        Me.chkReprimand.AutoSize = True
        Me.chkReprimand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReprimand.Location = New System.Drawing.Point(20, 28)
        Me.chkReprimand.Name = "chkReprimand"
        Me.chkReprimand.Size = New System.Drawing.Size(110, 19)
        Me.chkReprimand.TabIndex = 0
        Me.chkReprimand.Text = "A - Reprimand"
        Me.chkReprimand.UseVisualStyleBackColor = True
        '
        'txtProfessor
        '
        Me.txtProfessor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtProfessor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfessor.Location = New System.Drawing.Point(695, 395)
        Me.txtProfessor.Name = "txtProfessor"
        Me.txtProfessor.Size = New System.Drawing.Size(340, 23)
        Me.txtProfessor.TabIndex = 6
        '
        'lblProfessor
        '
        Me.lblProfessor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblProfessor.AutoSize = True
        Me.lblProfessor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfessor.Location = New System.Drawing.Point(695, 375)
        Me.lblProfessor.Name = "lblProfessor"
        Me.lblProfessor.Size = New System.Drawing.Size(155, 15)
        Me.lblProfessor.TabIndex = 5
        Me.lblProfessor.Text = "Endorse by (Professor)"
        '
        'txtOsaOfficer
        '
        Me.txtOsaOfficer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtOsaOfficer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOsaOfficer.Location = New System.Drawing.Point(695, 455)
        Me.txtOsaOfficer.Name = "txtOsaOfficer"
        Me.txtOsaOfficer.Size = New System.Drawing.Size(340, 23)
        Me.txtOsaOfficer.TabIndex = 8
        '
        'lblOsaOfficer
        '
        Me.lblOsaOfficer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblOsaOfficer.AutoSize = True
        Me.lblOsaOfficer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOsaOfficer.Location = New System.Drawing.Point(695, 435)
        Me.lblOsaOfficer.Name = "lblOsaOfficer"
        Me.lblOsaOfficer.Size = New System.Drawing.Size(151, 15)
        Me.lblOsaOfficer.TabIndex = 7
        Me.lblOsaOfficer.Text = "Noted by (OSA Officer)"
        '
        'txtDean
        '
        Me.txtDean.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDean.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDean.Location = New System.Drawing.Point(695, 515)
        Me.txtDean.Name = "txtDean"
        Me.txtDean.Size = New System.Drawing.Size(340, 23)
        Me.txtDean.TabIndex = 10
        '
        'lblDean
        '
        Me.lblDean.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDean.AutoSize = True
        Me.lblDean.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDean.Location = New System.Drawing.Point(695, 495)
        Me.lblDean.Name = "lblDean"
        Me.lblDean.Size = New System.Drawing.Size(127, 15)
        Me.lblDean.TabIndex = 9
        Me.lblDean.Text = "Affirmed by (Dean)"
        '
        'btnNext
        '
        Me.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNext.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(915, 560)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(120, 45)
        Me.btnNext.TabIndex = 11
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(785, 560)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(120, 45)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'DigitalViolationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 700)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "DigitalViolationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Digital Violation Slip Form"
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
    Friend WithEvents txtStudentNo As TextBox
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblStudentNo As Label
    Friend WithEvents grpViolationDetails As GroupBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents lblRemarks As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lblDate As Label
    Friend WithEvents rad4th As RadioButton
    Friend WithEvents rad3rd As RadioButton
    Friend WithEvents rad2nd As RadioButton
    Friend WithEvents rad1st As RadioButton
    Friend WithEvents lblNumOfOffense As Label
    Friend WithEvents txtOtherDetails As TextBox
    Friend WithEvents chkOther As CheckBox
    Friend WithEvents chkGrooming As CheckBox
    Friend WithEvents chkUniform As CheckBox
    Friend WithEvents lblViolationType As Label
    Friend WithEvents grpPunishment As GroupBox
    Friend WithEvents chkExpulsion As CheckBox
    Friend WithEvents chkDismissal As CheckBox
    Friend WithEvents chkNonReadmission As CheckBox
    Friend WithEvents chk5DaySuspension As CheckBox
    Friend WithEvents chk3DaySuspension As CheckBox
    Friend WithEvents chk1DaySuspension As CheckBox
    Friend WithEvents chkConference As CheckBox
    Friend WithEvents chkReprimand As CheckBox
    Friend WithEvents txtProfessor As TextBox
    Friend WithEvents lblProfessor As Label
    Friend WithEvents txtOsaOfficer As TextBox
    Friend WithEvents lblOsaOfficer As Label
    Friend WithEvents txtDean As TextBox
    Friend WithEvents lblDean As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class