Imports System.Data.Odbc
Imports System.Drawing.Printing

Public Class DigitalViolationForm

    ' Mga variable para sa ipinasang data kung galing sa double-click ng listahan
    Private passStudentNumber As String
    Private passStudentName As String
    Private passProgram As String
    Private passYearSection As String
    Private isPassedFromList As Boolean = False

    ' Printer component para sa pag-print ng slip
    Private WithEvents PrintDoc As New PrintDocument()
    Private WithEvents PrintPreviewDlg As New PrintPreviewDialog()

    ' --- 1. DEFAULT CONSTRUCTOR (Kung pinindot ang + Add Violation Record) ---
    Public Sub New()
        InitializeComponent()
    End Sub

    ' --- 2. PARAMETERIZED CONSTRUCTOR (Kung galing sa double-click ng listahan) ---
    Public Sub New(sNum As String, sName As String, sProg As String, sYear As String)
        InitializeComponent()

        passStudentNumber = sNum
        passStudentName = sName
        passProgram = sProg
        passYearSection = sYear
        isPassedFromList = True
    End Sub

    Private Sub DigitalViolationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        VbConnect()
        dtpDate.Value = DateTime.Now
        SetupProgramComboBox()

        ' Kung galing sa listahan, awtomatikong ilagay at i-lock ang info
        If isPassedFromList Then
            txtStudentNo.Text = passStudentNumber
            txtStudentName.Text = passStudentName
            cmbProgram.Text = passProgram
            txtYearSection.Text = passYearSection

            txtStudentNo.ReadOnly = True
            txtStudentName.ReadOnly = True

            ' Alamin agad ang offense count ng estudyanteng ito
            CalculateStudentOffenseCount(passStudentNumber)
        End If
    End Sub

    Private Sub SetupProgramComboBox()
        If cmbProgram.Items.Count = 0 Then
            cmbProgram.Items.Add("BSIT")
            cmbProgram.Items.Add("BSHM")
            cmbProgram.Items.Add("BSTM")
            cmbProgram.Items.Add("BSED")
        End If
    End Sub

    ' --- 3. AUTO-COUNT OFFENSE KAPAG NILISAN ANG STUDENT NO. BOX ---
    Private Sub TxtStudentNo_Leave(sender As Object, e As EventArgs) Handles txtStudentNo.Leave
        If isPassedFromList Then Return

        If String.IsNullOrWhiteSpace(txtStudentNo.Text) OrElse txtStudentNo.Text = "Student Number" Then
            Return
        End If

        Dim studentNo As String = txtStudentNo.Text.Trim()
        CalculateStudentOffenseCount(studentNo)
    End Sub

    ' --- FUNCTION PARA SA AUTO-COUNT NG OFFENSE ---
    Private Sub CalculateStudentOffenseCount(studentNo As String)
        Try
            Using conn As OdbcConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM tbl_violation_records WHERE student_number = ? AND status != 'Archived'"
                Using cmd As New OdbcCommand(query, conn)
                    cmd.Parameters.AddWithValue("?", studentNo)
                    Dim existingViolations As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    Dim nextOffense As Integer = existingViolations + 1

                    rad1st.Checked = False
                    rad2nd.Checked = False
                    rad3rd.Checked = False
                    rad4th.Checked = False

                    If nextOffense = 1 Then
                        rad1st.Checked = True
                    ElseIf nextOffense = 2 Then
                        rad2nd.Checked = True
                    ElseIf nextOffense = 3 Then
                        rad3rd.Checked = True
                    Else
                        rad4th.Checked = True
                    End If
                End Using
            End Using
        Catch ex As Exception
            rad1st.Checked = True
        End Try
    End Sub

    ' --- 4. SAVE BUTTON LOGIC (Direktang Isinusulat sa Database) ---
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtStudentName.Text) OrElse
           String.IsNullOrWhiteSpace(txtStudentNo.Text) OrElse
           String.IsNullOrWhiteSpace(txtYearSection.Text) OrElse
           cmbProgram.SelectedIndex = -1 Then
            MessageBox.Show("Mangyaring punan ang lahat ng pangunahing impormasyon ng estudyante.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim studentNoText As String = txtStudentNo.Text.Trim()
        Dim studentNameText As String = txtStudentName.Text.Trim()
        Dim programText As String = cmbProgram.Text.Trim()
        Dim yearSectionText As String = txtYearSection.Text.Trim()

        ' Uri ng Paglabag
        Dim violations As New List(Of String)
        If chkUniform.Checked Then violations.Add("No Proper Uniform")
        If chkGrooming.Checked Then violations.Add("No Proper Grooming")
        If chkOther.Checked AndAlso Not String.IsNullOrWhiteSpace(txtOtherDetails.Text) Then violations.Add("Other: " & txtOtherDetails.Text.Trim())
        Dim violationType As String = String.Join(", ", violations)

        If String.IsNullOrEmpty(violationType) Then
            MessageBox.Show("Pumili kahit isang Uri ng Paglabag.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Offense Count
        Dim numberOfOffense As String = "1st Offense"
        If rad2nd.Checked Then numberOfOffense = "2nd Offense"
        If rad3rd.Checked Then numberOfOffense = "3rd Offense"
        If rad4th.Checked Then numberOfOffense = "4th Offense and above"

        Dim violationDate As String = dtpDate.Value.ToString("yyyy-MM-dd HH:mm:ss")
        Dim remarksText As String = txtRemarks.Text.Trim()

        ' Punishment Category
        Dim punishments As New List(Of String)
        If chkReprimand.Checked Then punishments.Add("A - Reprimand")
        If chkConference.Checked Then punishments.Add("B - Conference")
        If chk1DaySuspension.Checked Then punishments.Add("C.1 - One-day Suspension")
        If chk3DaySuspension.Checked Then punishments.Add("C.2 - Three-day Suspension")
        If chk5DaySuspension.Checked Then punishments.Add("C.3 - Five-day Suspension")
        If chkNonReadmission.Checked Then punishments.Add("NR - Non-readmission")
        If chkDismissal.Checked Then punishments.Add("D - Dismissal")
        If chkExpulsion.Checked Then punishments.Add("E - Expulsion")
        Dim punishmentType As String = String.Join(", ", punishments)

        If String.IsNullOrEmpty(punishmentType) Then
            MessageBox.Show("Pumili ng kaukulang parusa.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim endorsedByProf As String = txtProfessor.Text.Trim()
        Dim notedBy As String = txtOsaOfficer.Text.Trim()
        Dim affirmedBy As String = txtDean.Text.Trim()

        If String.IsNullOrWhiteSpace(endorsedByProf) Then
            MessageBox.Show("Ilagay kung sino ang nag-endorse (Professor).", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- INSERT SA DATABASE ---
        Try
            Using conn As OdbcConnection = GetConnection()
                conn.Open()
                Dim insertQuery As String = "INSERT INTO tbl_violation_records (student_number, student_name, program, year_section, violation_type, offense_count, punishment_category, remarks, endorsed_by_prof, noted_by, affirmed_by, status, created_at) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, 'Active', ?)"

                Using cmd As New OdbcCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("?", studentNoText)
                    cmd.Parameters.AddWithValue("?", studentNameText)
                    cmd.Parameters.AddWithValue("?", programText)
                    cmd.Parameters.AddWithValue("?", yearSectionText)
                    cmd.Parameters.AddWithValue("?", violationType)
                    cmd.Parameters.AddWithValue("?", numberOfOffense)
                    cmd.Parameters.AddWithValue("?", punishmentType)
                    cmd.Parameters.AddWithValue("?", If(String.IsNullOrEmpty(remarksText), DBNull.Value, remarksText))
                    cmd.Parameters.AddWithValue("?", endorsedByProf)
                    cmd.Parameters.AddWithValue("?", If(String.IsNullOrEmpty(notedBy), DBNull.Value, notedBy))
                    cmd.Parameters.AddWithValue("?", If(String.IsNullOrEmpty(affirmedBy), DBNull.Value, affirmedBy))
                    cmd.Parameters.AddWithValue("?", violationDate)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Matagumpay na naitala ang violation slip!", "Tagumpay", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim violationsForm As New ViolationsForm()
            violationsForm.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error sa pag-save: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- 5. PRINT SLIP BUTTON LOGIC ---
    Private Sub BtnPrintSlip_Click(sender As Object, e As EventArgs) Handles btnPrintSlip.Click
        Try
            Dim printDoc As New Printing.PrintDocument()

            Dim printerSettings As New PrinterSettings()
            printerSettings.PrinterName = "Microsoft Print to PDF"
            printDoc.PrinterSettings = printerSettings

            AddHandler printDoc.PrintPage, AddressOf PrintDoc_PrintPage

            Dim previewDlg As New PrintPreviewDialog()
            previewDlg.Document = printDoc
            previewDlg.WindowState = FormWindowState.Maximized
            previewDlg.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("May error sa pag-preview ng dokumento: " & ex.Message, "Print Preview Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc.PrintPage
        Dim g As Graphics = e.Graphics
        Dim fontTitle As New Font("Segoe UI", 12, FontStyle.Bold)
        Dim fontSub As New Font("Segoe UI", 9, FontStyle.Regular)
        Dim fontBody As New Font("Segoe UI", 10, FontStyle.Bold)
        Dim fontRegular As New Font("Segoe UI", 10, FontStyle.Regular)
        Dim brush As Brush = Brushes.Black

        Dim startX As Integer = 50
        Dim startY As Integer = 50

        ' Header
        g.DrawString("COLEGIO DE STA. TERESA DE AVILA", fontTitle, brush, startX + 120, startY)
        g.DrawString("School of Information Technology - Violation Slip", fontSub, brush, startX + 140, startY + 25)

        ' Border Box para sa Slip
        g.DrawRectangle(Pens.Black, startX, startY + 60, 700, 380)

        ' Violation Checkbox Statuses
        Dim unifStatus As String = If(chkUniform.Checked, "[X] No Proper Uniform", "[  ] No Proper Uniform")
        Dim groomStatus As String = If(chkGrooming.Checked, "[X] No Proper Grooming", "[  ] No Proper Grooming")
        g.DrawString(unifStatus, fontRegular, brush, startX + 30, startY + 80)
        g.DrawString(groomStatus, fontRegular, brush, startX + 250, startY + 80)

        ' Student Details
        g.DrawString("Name of Student: " & txtStudentName.Text, fontBody, brush, startX + 20, startY + 120)
        g.DrawString("Year & Section: " & txtYearSection.Text, fontBody, brush, startX + 400, startY + 120)
        g.DrawString("Program (Course): " & cmbProgram.Text, fontBody, brush, startX + 20, startY + 155)

        ' Offense Count & Violation Type
        Dim currentOffense As String = "1st"
        If rad2nd.Checked Then currentOffense = "2nd"
        If rad3rd.Checked Then currentOffense = "3rd"
        If rad4th.Checked Then currentOffense = "4th and above"

        g.DrawString("No. of Offense: " & currentOffense & " Offense", fontBody, brush, startX + 20, startY + 190)
        g.DrawString("Violation Type: " & GetSelectedViolationsText(), fontRegular, brush, startX + 20, startY + 225)

        ' Signatures Section (Blangko para sa personal na pirma)
        g.DrawLine(Pens.Black, startX + 50, startY + 290, startX + 320, startY + 290)
        g.DrawString("Name and signature of Professor", fontSub, brush, startX + 90, startY + 295)
        g.DrawString(txtProfessor.Text, fontRegular, brush, startX + 80, startY + 270)

        g.DrawLine(Pens.Black, startX + 380, startY + 290, startX + 650, startY + 290)
        g.DrawString("Name and signature of OSA Officer", fontSub, brush, startX + 410, startY + 295)
        g.DrawString(txtOsaOfficer.Text, fontRegular, brush, startX + 410, startY + 270)

        g.DrawLine(Pens.Black, startX + 200, startY + 380, startX + 500, startY + 380)
        g.DrawString("Name and signature of Dean", fontSub, brush, startX + 260, startY + 385)
        g.DrawString(txtDean.Text, fontRegular, brush, startX + 260, startY + 360)
    End Sub

    Private Function GetSelectedViolationsText() As String
        Dim list As New List(Of String)
        If chkUniform.Checked Then list.Add("Uniform")
        If chkGrooming.Checked Then list.Add("Grooming")
        If chkOther.Checked Then list.Add(txtOtherDetails.Text)
        Return String.Join(", ", list)
    End Function

    ' --- 6. BACK BUTTON ---
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim violationForm As New ViolationsForm()
        violationForm.Show()
        Me.Close()
    End Sub

End Class