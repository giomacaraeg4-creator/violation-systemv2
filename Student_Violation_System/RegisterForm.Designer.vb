<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelCard = New System.Windows.Forms.Panel()
        Me.btnBacktologin = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnEye3 = New System.Windows.Forms.Button()
        Me.txtPass3 = New System.Windows.Forms.TextBox()
        Me.btnEye2 = New System.Windows.Forms.Button()
        Me.txtPass2 = New System.Windows.Forms.TextBox()
        Me.txtUsername2 = New System.Windows.Forms.TextBox()
        Me.lblSubText = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pbPassIcon = New System.Windows.Forms.PictureBox()
        Me.pbUserIcon = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelCard.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPassIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUserIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCard
        '
        Me.PanelCard.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.PanelCard.Controls.Add(Me.PictureBox3)
        Me.PanelCard.Controls.Add(Me.PictureBox2)
        Me.PanelCard.Controls.Add(Me.pbPassIcon)
        Me.PanelCard.Controls.Add(Me.pbUserIcon)
        Me.PanelCard.Controls.Add(Me.btnBacktologin)
        Me.PanelCard.Controls.Add(Me.btnCreate)
        Me.PanelCard.Controls.Add(Me.ComboBox1)
        Me.PanelCard.Controls.Add(Me.btnEye3)
        Me.PanelCard.Controls.Add(Me.txtPass3)
        Me.PanelCard.Controls.Add(Me.btnEye2)
        Me.PanelCard.Controls.Add(Me.txtPass2)
        Me.PanelCard.Controls.Add(Me.txtUsername2)
        Me.PanelCard.Controls.Add(Me.lblSubText)
        Me.PanelCard.Controls.Add(Me.lblWelcome)
        Me.PanelCard.Location = New System.Drawing.Point(437, 75)
        Me.PanelCard.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelCard.Name = "PanelCard"
        Me.PanelCard.Size = New System.Drawing.Size(285, 351)
        Me.PanelCard.TabIndex = 1
        '
        'btnBacktologin
        '
        Me.btnBacktologin.BackColor = System.Drawing.Color.Transparent
        Me.btnBacktologin.FlatAppearance.BorderSize = 0
        Me.btnBacktologin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBacktologin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline)
        Me.btnBacktologin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnBacktologin.Location = New System.Drawing.Point(82, 299)
        Me.btnBacktologin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBacktologin.Name = "btnBacktologin"
        Me.btnBacktologin.Size = New System.Drawing.Size(112, 29)
        Me.btnBacktologin.TabIndex = 9
        Me.btnBacktologin.Text = "Back to Login"
        Me.btnBacktologin.UseVisualStyleBackColor = False
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCreate.FlatAppearance.BorderSize = 0
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCreate.Location = New System.Drawing.Point(30, 260)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(225, 26)
        Me.btnCreate.TabIndex = 8
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Administrator", "Acting OSA Officer"})
        Me.ComboBox1.Location = New System.Drawing.Point(76, 211)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(162, 23)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.Text = "Role"
        '
        'btnEye3
        '
        Me.btnEye3.BackColor = System.Drawing.Color.White
        Me.btnEye3.FlatAppearance.BorderSize = 0
        Me.btnEye3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEye3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEye3.Location = New System.Drawing.Point(238, 170)
        Me.btnEye3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEye3.Name = "btnEye3"
        Me.btnEye3.Size = New System.Drawing.Size(28, 26)
        Me.btnEye3.TabIndex = 6
        Me.btnEye3.Text = "👁"
        Me.btnEye3.UseVisualStyleBackColor = False
        '
        'txtPass3
        '
        Me.txtPass3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPass3.Location = New System.Drawing.Point(76, 169)
        Me.txtPass3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPass3.Multiline = True
        Me.txtPass3.Name = "txtPass3"
        Me.txtPass3.Size = New System.Drawing.Size(162, 27)
        Me.txtPass3.TabIndex = 5
        Me.txtPass3.Text = "Confirm Password"
        Me.txtPass3.UseSystemPasswordChar = True
        '
        'btnEye2
        '
        Me.btnEye2.BackColor = System.Drawing.Color.White
        Me.btnEye2.FlatAppearance.BorderSize = 0
        Me.btnEye2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEye2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEye2.Location = New System.Drawing.Point(238, 127)
        Me.btnEye2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEye2.Name = "btnEye2"
        Me.btnEye2.Size = New System.Drawing.Size(28, 27)
        Me.btnEye2.TabIndex = 4
        Me.btnEye2.Text = "👁"
        Me.btnEye2.UseVisualStyleBackColor = False
        '
        'txtPass2
        '
        Me.txtPass2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPass2.Location = New System.Drawing.Point(76, 127)
        Me.txtPass2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPass2.Multiline = True
        Me.txtPass2.Name = "txtPass2"
        Me.txtPass2.Size = New System.Drawing.Size(162, 27)
        Me.txtPass2.TabIndex = 3
        Me.txtPass2.Text = "Password"
        Me.txtPass2.UseSystemPasswordChar = True
        '
        'txtUsername2
        '
        Me.txtUsername2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername2.Location = New System.Drawing.Point(76, 84)
        Me.txtUsername2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUsername2.Name = "txtUsername2"
        Me.txtUsername2.Size = New System.Drawing.Size(162, 23)
        Me.txtUsername2.TabIndex = 2
        Me.txtUsername2.Text = "UserName"
        '
        'lblSubText
        '
        Me.lblSubText.AutoSize = True
        Me.lblSubText.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblSubText.ForeColor = System.Drawing.Color.Gray
        Me.lblSubText.Location = New System.Drawing.Point(32, 45)
        Me.lblSubText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSubText.Name = "lblSubText"
        Me.lblSubText.Size = New System.Drawing.Size(220, 17)
        Me.lblSubText.TabIndex = 1
        Me.lblSubText.Text = "Join the CSTA Student Affairs System"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblWelcome.Location = New System.Drawing.Point(30, 19)
        Me.lblWelcome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(115, 30)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome!"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = Global.Student_Violation_System.My.Resources.Resources.user
        Me.PictureBox3.Location = New System.Drawing.Point(42, 211)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(33, 23)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.Student_Violation_System.My.Resources.Resources.lock
        Me.PictureBox2.Location = New System.Drawing.Point(42, 169)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'pbPassIcon
        '
        Me.pbPassIcon.BackColor = System.Drawing.Color.White
        Me.pbPassIcon.Image = Global.Student_Violation_System.My.Resources.Resources.lock
        Me.pbPassIcon.Location = New System.Drawing.Point(42, 127)
        Me.pbPassIcon.Name = "pbPassIcon"
        Me.pbPassIcon.Size = New System.Drawing.Size(33, 27)
        Me.pbPassIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPassIcon.TabIndex = 11
        Me.pbPassIcon.TabStop = False
        '
        'pbUserIcon
        '
        Me.pbUserIcon.BackColor = System.Drawing.Color.White
        Me.pbUserIcon.Image = Global.Student_Violation_System.My.Resources.Resources.user
        Me.pbUserIcon.Location = New System.Drawing.Point(42, 84)
        Me.pbUserIcon.Name = "pbUserIcon"
        Me.pbUserIcon.Size = New System.Drawing.Size(33, 27)
        Me.pbUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUserIcon.TabIndex = 10
        Me.pbUserIcon.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Student_Violation_System.My.Resources.Resources.download__4_
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(757, 458)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 458)
        Me.Controls.Add(Me.PanelCard)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RegisterForm"
        Me.Text = "CSTA - Create Account"
        Me.PanelCard.ResumeLayout(False)
        Me.PanelCard.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPassIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUserIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelCard As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblSubText As Label
    Friend WithEvents txtUsername2 As TextBox
    Friend WithEvents txtPass2 As TextBox
    Friend WithEvents btnEye2 As Button
    Friend WithEvents txtPass3 As TextBox
    Friend WithEvents btnEye3 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnBacktologin As Button
    Friend WithEvents pbUserIcon As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pbPassIcon As PictureBox
End Class