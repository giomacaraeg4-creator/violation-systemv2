Imports System.Data.Odbc

Public Class DigitalViolationForm

    Public Property StudentNameText As String
    Public Property StudentNoText As String
    Public Property ProgramText As String
    Public Property YearSectionText As String
    Public Property ViolationType As String
    Public Property NumberOfOffense As String
    Public Property ViolationDate As String
    Public Property RemarksText As String
    Public Property PunishmentType As String
    Public Property ProfessorText As String
    Public Property OsaOfficerText As String
    Public Property DeanText As String

    ' Mga variable para sa ipinasang data kung galing sa double-click ng listahan
    Private passStudentNumber As String
    Private passStudentName As String
    Private passProgram As String
    Private passYearSection As String
    Private isPassedFromList As Boolean = False

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

    ' --- 3. AUTO-FILL STUDENT INFO & AUTO-COUNT OFFENSE KAPAG NILISAN ANG STUDENT NO. BOX ---
    Private Sub TxtStudentNo_Leave(sender As Object, e As EventArgs) Handles txtStudentNo.Leave
        If isPassedFromList Then Return ' Huwag nang mag-trigger kung naka-lock na galing listahan

        If String.IsNullOrWhiteSpace(txtStudentNo.Text) OrElse txtStudentNo.Text = "Student Number" Then
            Return
        End If

        Dim studentNo As String = txtStudentNo.Text.Trim()
        Dim pattern As String = "^\d{2}-\d{5}$"

        ' I-check ang tamang format ng Student Number (Halimbawa: 20-00001)
        If Not System.Text.RegularExpressions.Regex.IsMatch(studentNo, pattern) Then
            MessageBox.Show("Mali ang format ng Student Number. Ang tamang halimbawa ay 20-00001.", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStudentNo.Focus()
            ClearStudentFields()
            Return
        End If

        ' Kunin ang impormasyon ng estudyante mula sa portal/student database
        Try
            Using conn As OdbcConnection = GetSecondDatabaseConnection()
                conn.Open()
                Dim query As String = "SELECT first_name, middle_name, last_name, course, year_level FROM tbl_enrolled_students WHERE student_number = ?"

                Using cmd As New OdbcCommand(query, conn)
                    cmd.Parameters.AddWithValue("?", studentNo)

                    Using reader As OdbcDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim fName As String = reader("first_name").ToString()
                            Dim mName As String = reader("middle_name").ToString()
                            Dim lName As String = reader("last_name").ToString()

                            ' Buuin ang buong pangalan
                            If Not String.IsNullOrEmpty(mName) Then
                                txtStudentName.Text = fName & " " & mName & " " & lName
                            Else
                                txtStudentName.Text = fName & " " & lName
                            End If

                            ' I-set ang Program (Course)
                            If reader("course") IsNot DBNull.Value Then
                                cmbProgram.Text = reader("course").ToString()
                            End If

                            ' I-set ang Year & Section
                            If reader("year_level") IsNot DBNull.Value Then
                                txtYearSection.Text = reader("year_level").ToString()
                            End If

                            ' Awtomatikong alamin kung pang-ilan na niyang paglabag ngayon
                            CalculateStudentOffenseCount(studentNo)

                        Else
                            MessageBox.Show("Walang nahanap na estudyante na may ganitong Student Number sa portal database.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            ClearStudentFields()
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error sa pag-access ng kabilang database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- FUNCTION PARA SA AUTO-COUNT NG OFFENSE ---
    Private Sub CalculateStudentOffenseCount(studentNo As String)
        Try
            Using conn As OdbcConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM tbl_violation_records WHERE student_number = ?"
                Using cmd As New OdbcCommand(query, conn)
                    cmd.Parameters.AddWithValue("?", studentNo)
                    Dim existingViolations As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    ' Dagdagan ng 1 para sa kasalukuyang paglabag
                    Dim nextOffense As Integer = existingViolations + 1

                    ' Awtomatikong i-tack ang kaukulang Radio Button
                    rad1st.Checked = False
                    rad2nd.Checked = False
                    rad3rd.Checked = False
                    rad4th.Checked = False

                    If nextOffense = 1 Then
                        rad1st.Checked = True
                        NumberOfOffense = "1st"
                    ElseIf nextOffense = 2 Then
                        rad2nd.Checked = True
                        NumberOfOffense = "2nd"
                    ElseIf nextOffense = 3 Then
                        rad3rd.Checked = True
                        NumberOfOffense = "3rd"
                    Else
                        rad4th.Checked = True
                        NumberOfOffense = "4th and above"
                    End If
                End Using
            End Using
        Catch ex As Exception
            rad1st.Checked = True
            NumberOfOffense = "1st"
        End Try
    End Sub

    Private Sub ClearStudentFields()
        txtStudentName.Text = ""
        cmbProgram.SelectedIndex = -1
        txtYearSection.Text = ""
        rad1st.Checked = True
    End Sub

    ' --- 4. NEXT BUTTON LOGIC ---
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If String.IsNullOrWhiteSpace(txtStudentName.Text) OrElse
           String.IsNullOrWhiteSpace(txtStudentNo.Text) OrElse
           String.IsNullOrWhiteSpace(txtYearSection.Text) Then
            MessageBox.Show("Mangyaring punan ang mga pangunahing impormasyon ng estudyante.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        StudentNameText = txtStudentName.Text.Trim()
        StudentNoText = txtStudentNo.Text.Trim()
        ProgramText = cmbProgram.Text
        YearSectionText = txtYearSection.Text.Trim()

        Dim violations As New List(Of String)
        If chkUniform.Checked Then violations.Add("No Proper Uniform")
        If chkGrooming.Checked Then violations.Add("No Proper Grooming")
        If chkOther.Checked Then violations.Add("Other: " & txtOtherDetails.Text.Trim())
        ViolationType = String.Join(", ", violations)

        If String.IsNullOrEmpty(ViolationType) Then
            MessageBox.Show("Pumili kahit isang Uri ng Paglabag (Violation Type).", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If rad1st.Checked Then NumberOfOffense = "1st"
        If rad2nd.Checked Then NumberOfOffense = "2nd"
        If rad3rd.Checked Then NumberOfOffense = "3rd"
        If rad4th.Checked Then NumberOfOffense = "4th and above"

        ViolationDate = dtpDate.Value.ToString("yyyy-MM-dd")
        RemarksText = txtRemarks.Text.Trim()

        Dim punishments As New List(Of String)
        If chkReprimand.Checked Then punishments.Add("A - Reprimand")
        If chkConference.Checked Then punishments.Add("B - Conference")
        If chk1DaySuspension.Checked Then punishments.Add("C.1 - One-day Suspension")
        If chk3DaySuspension.Checked Then punishments.Add("C.2 - Three-day Suspension")
        If chk5DaySuspension.Checked Then punishments.Add("C.3 - Five-day Suspension")
        If chkNonReadmission.Checked Then punishments.Add("NR - Non-readmission")
        If chkDismissal.Checked Then punishments.Add("D - Dismissal")
        If chkExpulsion.Checked Then punishments.Add("E - Expulsion")
        PunishmentType = String.Join(", ", punishments)

        ProfessorText = txtProfessor.Text.Trim()
        OsaOfficerText = txtOsaOfficer.Text.Trim()
        DeanText = txtDean.Text.Trim()

        ' Pasa ang data patungo sa DigitalSignatureForm
        Dim sigForm As New DigitalSignatureForm With {
            .StudentName = StudentNameText,
            .StudentNo = StudentNoText,
            .Program = ProgramText,
            .YearSection = YearSectionText,
            .ViolationType = ViolationType,
            .Offense = NumberOfOffense,
            .ViolationDate = ViolationDate,
            .Remarks = RemarksText,
            .Punishment = PunishmentType,
            .Professor = ProfessorText,
            .OsaOfficer = OsaOfficerText,
            .Dean = DeanText
        }

        sigForm.Show()
        Me.Hide()
    End Sub

    ' --- BACK TO VIOLATIONS FORM BUTTON ---
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim violationsForm As New ViolationsForm()
        violationsForm.Show()
        Me.Close()
    End Sub

End Class