<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TrashBinForm
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
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.cmbFilterTrash = New System.Windows.Forms.ComboBox()
        Me.dgvTrash = New System.Windows.Forms.DataGridView()
        Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deleted_from = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvTrash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(40, 37)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(399, 41)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Archived Violation Records"
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblSubTitle.Location = New System.Drawing.Point(43, 80)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(463, 23)
        Me.lblSubTitle.TabIndex = 1
        Me.lblSubTitle.Text = "Manage deleted records. You can restore them if necessary."
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblFilter.Location = New System.Drawing.Point(40, 130)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(76, 23)
        Me.lblFilter.TabIndex = 5
        Me.lblFilter.Text = "Filter By:"
        '
        'cmbFilterTrash
        '
        Me.cmbFilterTrash.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilterTrash.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbFilterTrash.FormattingEnabled = True
        Me.cmbFilterTrash.Location = New System.Drawing.Point(125, 126)
        Me.cmbFilterTrash.Name = "cmbFilterTrash"
        Me.cmbFilterTrash.Size = New System.Drawing.Size(220, 31)
        Me.cmbFilterTrash.TabIndex = 6
        '
        'dgvTrash
        '
        Me.dgvTrash.AllowUserToAddRows = False
        Me.dgvTrash.AllowUserToDeleteRows = False
        Me.dgvTrash.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTrash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTrash.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.dgvTrash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTrash.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.deleted_from})
        Me.dgvTrash.Location = New System.Drawing.Point(40, 180)
        Me.dgvTrash.Name = "dgvTrash"
        Me.dgvTrash.ReadOnly = True
        Me.dgvTrash.RowHeadersVisible = False
        Me.dgvTrash.RowHeadersWidth = 51
        Me.dgvTrash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTrash.Size = New System.Drawing.Size(1260, 620)
        Me.dgvTrash.TabIndex = 2
        '
        'ColumnID
        '
        Me.ColumnID.DataPropertyName = "record_id"
        Me.ColumnID.HeaderText = "ID"
        Me.ColumnID.Name = "ColumnID"
        Me.ColumnID.ReadOnly = True
        Me.ColumnID.Visible = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "student_number"
        Me.Column1.HeaderText = "Student Number"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "student_name"
        Me.Column2.HeaderText = "Student Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "program"
        Me.Column3.HeaderText = "Course"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "year_section"
        Me.Column4.HeaderText = "Year & Section"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "violation_type"
        Me.Column5.HeaderText = "Violation Type"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "offense_count"
        Me.Column6.HeaderText = "Offense Count"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "punishment_category"
        Me.Column7.HeaderText = "Punishment Category"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "status"
        Me.Column8.HeaderText = "Status"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "created_at"
        Me.Column9.HeaderText = "Date Recorded"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'deleted_from
        '
        Me.deleted_from.DataPropertyName = "deleted_from"
        Me.deleted_from.HeaderText = "Deleted From"
        Me.deleted_from.Name = "deleted_from"
        Me.deleted_from.ReadOnly = True
        '
        'btnRestore
        '
        Me.btnRestore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestore.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnRestore.FlatAppearance.BorderSize = 0
        Me.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestore.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRestore.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRestore.Location = New System.Drawing.Point(967, 120)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(160, 43)
        Me.btnRestore.TabIndex = 3
        Me.btnRestore.Text = "Restore Record"
        Me.btnRestore.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBack.Location = New System.Drawing.Point(1140, 120)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(160, 43)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'TrashBinForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1344, 868)
        Me.Controls.Add(Me.cmbFilterTrash)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.dgvTrash)
        Me.Controls.Add(Me.lblSubTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "TrashBinForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSTA - Trash Bin"
        CType(Me.dgvTrash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents lblFilter As Label
    Friend WithEvents cmbFilterTrash As ComboBox
    Friend WithEvents dgvTrash As DataGridView
    Friend WithEvents btnRestore As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents ColumnID As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents deleted_from As DataGridViewTextBoxColumn
End Class