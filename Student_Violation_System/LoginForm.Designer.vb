<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.BtnEye = New System.Windows.Forms.Button()
        Me.BtnLogin1 = New System.Windows.Forms.Button()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.PanelCard = New System.Windows.Forms.Panel()
        Me.PbUserIcon = New System.Windows.Forms.PictureBox()
        Me.PbPassIcon = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelCard.SuspendLayout()
        CType(Me.PbUserIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbPassIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtUser
        '
        Me.TxtUser.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtUser.Location = New System.Drawing.Point(64, 47)
        Me.TxtUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(252, 30)
        Me.TxtUser.TabIndex = 2
        Me.TxtUser.Text = "UserName"
        '
        'TxtPass
        '
        Me.TxtPass.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtPass.Location = New System.Drawing.Point(64, 108)
        Me.TxtPass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(213, 30)
        Me.TxtPass.TabIndex = 3
        Me.TxtPass.Text = "Password"
        Me.TxtPass.UseSystemPasswordChar = True
        '
        'BtnEye
        '
        Me.BtnEye.BackColor = System.Drawing.Color.White
        Me.BtnEye.FlatAppearance.BorderSize = 0
        Me.BtnEye.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEye.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEye.Location = New System.Drawing.Point(281, 110)
        Me.BtnEye.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEye.Name = "BtnEye"
        Me.BtnEye.Size = New System.Drawing.Size(32, 28)
        Me.BtnEye.TabIndex = 4
        Me.BtnEye.Text = "👁"
        Me.BtnEye.UseVisualStyleBackColor = False
        '
        'BtnLogin1
        '
        Me.BtnLogin1.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnLogin1.FlatAppearance.BorderSize = 0
        Me.BtnLogin1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLogin1.ForeColor = System.Drawing.Color.White
        Me.BtnLogin1.Location = New System.Drawing.Point(31, 185)
        Me.BtnLogin1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnLogin1.Name = "BtnLogin1"
        Me.BtnLogin1.Size = New System.Drawing.Size(287, 39)
        Me.BtnLogin1.TabIndex = 5
        Me.BtnLogin1.Text = "Login"
        Me.BtnLogin1.UseVisualStyleBackColor = False
        '
        'BtnRegister
        '
        Me.BtnRegister.BackColor = System.Drawing.Color.Transparent
        Me.BtnRegister.FlatAppearance.BorderSize = 0
        Me.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegister.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline)
        Me.BtnRegister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BtnRegister.Location = New System.Drawing.Point(84, 240)
        Me.BtnRegister.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(180, 31)
        Me.BtnRegister.TabIndex = 6
        Me.BtnRegister.Text = "Create Account"
        Me.BtnRegister.UseVisualStyleBackColor = False
        '
        'PanelCard
        '
        Me.PanelCard.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.PanelCard.Controls.Add(Me.PbUserIcon)
        Me.PanelCard.Controls.Add(Me.TxtUser)
        Me.PanelCard.Controls.Add(Me.PbPassIcon)
        Me.PanelCard.Controls.Add(Me.TxtPass)
        Me.PanelCard.Controls.Add(Me.BtnEye)
        Me.PanelCard.Controls.Add(Me.BtnLogin1)
        Me.PanelCard.Controls.Add(Me.BtnRegister)
        Me.PanelCard.Location = New System.Drawing.Point(613, 178)
        Me.PanelCard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelCard.Name = "PanelCard"
        Me.PanelCard.Size = New System.Drawing.Size(347, 314)
        Me.PanelCard.TabIndex = 1
        '
        'PbUserIcon
        '
        Me.PbUserIcon.BackColor = System.Drawing.Color.White
        Me.PbUserIcon.Image = Global.Student_Violation_System.My.Resources.Resources.user
        Me.PbUserIcon.Location = New System.Drawing.Point(31, 47)
        Me.PbUserIcon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PbUserIcon.Name = "PbUserIcon"
        Me.PbUserIcon.Size = New System.Drawing.Size(29, 30)
        Me.PbUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbUserIcon.TabIndex = 6
        Me.PbUserIcon.TabStop = False
        '
        'PbPassIcon
        '
        Me.PbPassIcon.BackColor = System.Drawing.Color.White
        Me.PbPassIcon.Image = Global.Student_Violation_System.My.Resources.Resources.lock
        Me.PbPassIcon.Location = New System.Drawing.Point(31, 111)
        Me.PbPassIcon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PbPassIcon.Name = "PbPassIcon"
        Me.PbPassIcon.Size = New System.Drawing.Size(29, 27)
        Me.PbPassIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbPassIcon.TabIndex = 7
        Me.PbPassIcon.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Student_Violation_System.My.Resources.Resources.download__3_
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1009, 564)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 564)
        Me.Controls.Add(Me.PanelCard)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSTA - Login"
        Me.PanelCard.ResumeLayout(False)
        Me.PanelCard.PerformLayout()
        CType(Me.PbUserIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbPassIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelCard As Panel
    Friend WithEvents PbUserIcon As PictureBox
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents PbPassIcon As PictureBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents BtnEye As Button
    Friend WithEvents BtnLogin1 As Button
    Friend WithEvents BtnRegister As Button
End Class