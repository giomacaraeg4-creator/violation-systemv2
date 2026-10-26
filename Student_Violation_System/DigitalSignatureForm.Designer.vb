<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DigitalSignatureForm
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
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.lblHeaderSub = New System.Windows.Forms.Label()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.lblDeanSig = New System.Windows.Forms.Label()
        Me.picDean = New System.Windows.Forms.PictureBox()
        Me.lblOsaSig = New System.Windows.Forms.Label()
        Me.picOsa = New System.Windows.Forms.PictureBox()
        Me.lblProfSig = New System.Windows.Forms.Label()
        Me.picProfessor = New System.Windows.Forms.PictureBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnPrintSlip = New System.Windows.Forms.Button()
        Me.btnSavePending = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlContainer.SuspendLayout()
        CType(Me.picDean, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOsa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProfessor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHeaderTitle.Location = New System.Drawing.Point(30, 24)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(162, 24)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "Digital Signature"
        '
        'lblHeaderSub
        '
        Me.lblHeaderSub.AutoSize = True
        Me.lblHeaderSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderSub.ForeColor = System.Drawing.Color.DimGray
        Me.lblHeaderSub.Location = New System.Drawing.Point(32, 53)
        Me.lblHeaderSub.Name = "lblHeaderSub"
        Me.lblHeaderSub.Size = New System.Drawing.Size(203, 15)
        Me.lblHeaderSub.TabIndex = 1
        Me.lblHeaderSub.Text = "Use the school's e-signature system"
        '
        'pnlContainer
        '
        Me.pnlContainer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.pnlContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pnlContainer.Controls.Add(Me.lblDeanSig)
        Me.pnlContainer.Controls.Add(Me.picDean)
        Me.pnlContainer.Controls.Add(Me.lblOsaSig)
        Me.pnlContainer.Controls.Add(Me.picOsa)
        Me.pnlContainer.Controls.Add(Me.lblProfSig)
        Me.pnlContainer.Controls.Add(Me.picProfessor)
        Me.pnlContainer.Location = New System.Drawing.Point(136, 110)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(712, 252)
        Me.pnlContainer.TabIndex = 2
        '
        'lblDeanSig
        '
        Me.lblDeanSig.AutoSize = True
        Me.lblDeanSig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeanSig.Location = New System.Drawing.Point(532, 199)
        Me.lblDeanSig.Name = "lblDeanSig"
        Me.lblDeanSig.Size = New System.Drawing.Size(115, 16)
        Me.lblDeanSig.TabIndex = 5
        Me.lblDeanSig.Text = "Signature of Dean"
        '
        'picDean
        '
        Me.picDean.BackColor = System.Drawing.Color.LightGray
        Me.picDean.Location = New System.Drawing.Point(488, 24)
        Me.picDean.Name = "picDean"
        Me.picDean.Size = New System.Drawing.Size(202, 162)
        Me.picDean.TabIndex = 4
        Me.picDean.TabStop = False
        '
        'lblOsaSig
        '
        Me.lblOsaSig.AutoSize = True
        Me.lblOsaSig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOsaSig.Location = New System.Drawing.Point(272, 199)
        Me.lblOsaSig.Name = "lblOsaSig"
        Me.lblOsaSig.Size = New System.Drawing.Size(177, 16)
        Me.lblOsaSig.TabIndex = 3
        Me.lblOsaSig.Text = "Signature Acting OSA Officer"
        '
        'picOsa
        '
        Me.picOsa.BackColor = System.Drawing.Color.LightGray
        Me.picOsa.Location = New System.Drawing.Point(255, 24)
        Me.picOsa.Name = "picOsa"
        Me.picOsa.Size = New System.Drawing.Size(202, 162)
        Me.picOsa.TabIndex = 2
        Me.picOsa.TabStop = False
        '
        'lblProfSig
        '
        Me.lblProfSig.AutoSize = True
        Me.lblProfSig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfSig.Location = New System.Drawing.Point(56, 199)
        Me.lblProfSig.Name = "lblProfSig"
        Me.lblProfSig.Size = New System.Drawing.Size(140, 16)
        Me.lblProfSig.TabIndex = 1
        Me.lblProfSig.Text = "Signature of Professor"
        '
        'picProfessor
        '
        Me.picProfessor.BackColor = System.Drawing.Color.LightGray
        Me.picProfessor.Location = New System.Drawing.Point(22, 24)
        Me.picProfessor.Name = "picProfessor"
        Me.picProfessor.Size = New System.Drawing.Size(202, 162)
        Me.picProfessor.TabIndex = 0
        Me.picProfessor.TabStop = False
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSubmit.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(627, 390)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(115, 50)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnPrintSlip
        '
        Me.btnPrintSlip.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPrintSlip.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnPrintSlip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintSlip.ForeColor = System.Drawing.Color.White
        Me.btnPrintSlip.Location = New System.Drawing.Point(508, 388)
        Me.btnPrintSlip.Name = "btnPrintSlip"
        Me.btnPrintSlip.Size = New System.Drawing.Size(114, 52)
        Me.btnPrintSlip.TabIndex = 5
        Me.btnPrintSlip.Text = " Print Slip"
        Me.btnPrintSlip.UseVisualStyleBackColor = False
        '
        'btnSavePending
        '
        Me.btnSavePending.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSavePending.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSavePending.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavePending.ForeColor = System.Drawing.Color.White
        Me.btnSavePending.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSavePending.Location = New System.Drawing.Point(389, 389)
        Me.btnSavePending.Name = "btnSavePending"
        Me.btnSavePending.Padding = New System.Windows.Forms.Padding(5)
        Me.btnSavePending.Size = New System.Drawing.Size(113, 52)
        Me.btnSavePending.TabIndex = 4
        Me.btnSavePending.Text = "Save Pending"
        Me.btnSavePending.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSavePending.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnBack.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(270, 389)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(113, 52)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'DigitalSignatureForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 631)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnPrintSlip)
        Me.Controls.Add(Me.btnSavePending)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.lblHeaderSub)
        Me.Controls.Add(Me.lblHeaderTitle)
        Me.Name = "DigitalSignatureForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Digital Signature"
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlContainer.PerformLayout()
        CType(Me.picDean, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOsa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProfessor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblHeaderSub As Label
    Friend WithEvents pnlContainer As Panel
    Friend WithEvents picProfessor As PictureBox
    Friend WithEvents lblProfSig As Label
    Friend WithEvents picOsa As PictureBox
    Friend WithEvents lblOsaSig As Label
    Friend WithEvents picDean As PictureBox
    Friend WithEvents lblDeanSig As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnSavePending As Button
    Friend WithEvents btnPrintSlip As Button
    Friend WithEvents btnBack As Button
End Class