Imports System.Data.Odbc
Imports System.Drawing.Printing
Imports System.IO

Public Class DigitalSignatureForm

    Public Property StudentName As String
    Public Property StudentNo As String
    Public Property Program As String
    Public Property YearSection As String
    Public Property ViolationType As String
    Public Property Offense As String
    Public Property ViolationDate As String
    Public Property Remarks As String
    Public Property Punishment As String
    Public Property Professor As String
    Public Property OsaOfficer As String
    Public Property Dean As String

    Private isDrawingProf As Boolean = False
    Private isDrawingOsa As Boolean = False
    Private isDrawingDean As Boolean = False

    Private bmpProf As Bitmap
    Private bmpOsa As Bitmap
    Private bmpDean As Bitmap
    Private gProf As Graphics
    Private gOsa As Graphics
    Private gDean As Graphics
    Private ReadOnly penSignature As New Pen(Color.Black, 2)

    Private Sub DigitalSignatureForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        InitializeDrawingSurface(picProfessor, bmpProf, gProf)
        InitializeDrawingSurface(picOsa, bmpOsa, gOsa)
        InitializeDrawingSurface(picDean, bmpDean, gDean)
    End Sub

    Private Sub InitializeDrawingSurface(picBox As PictureBox, ByRef bmp As Bitmap, ByRef g As Graphics)
        If picBox.Width > 0 AndAlso picBox.Height > 0 Then
            bmp = New Bitmap(picBox.Width, picBox.Height)
            g = Graphics.FromImage(bmp)
            g.Clear(Color.White)
            picBox.Image = bmp
        End If
    End Sub

    ' --- Professor Signature Drawing Events ---
    Private Sub PicProfessor_MouseDown(sender As Object, e As MouseEventArgs) Handles picProfessor.MouseDown
        If e.Button = MouseButtons.Left Then isDrawingProf = True
    End Sub

    Private Sub PicProfessor_MouseMove(sender As Object, e As MouseEventArgs) Handles picProfessor.MouseMove
        Static oldX As Integer, oldY As Integer
        If isDrawingProf AndAlso gProf IsNot Nothing Then
            gProf.DrawLine(penSignature, oldX, oldY, e.X, e.Y)
            picProfessor.Invalidate()
        End If
        oldX = e.X
        oldY = e.Y
    End Sub

    Private Sub PicProfessor_MouseUp(sender As Object, e As MouseEventArgs) Handles picProfessor.MouseUp
        isDrawingProf = False
    End Sub

    ' --- OSA Officer Signature Drawing Events ---
    Private Sub PicOsa_MouseDown(sender As Object, e As MouseEventArgs) Handles picOsa.MouseDown
        If e.Button = MouseButtons.Left Then isDrawingOsa = True
    End Sub

    Private Sub PicOsa_MouseMove(sender As Object, e As MouseEventArgs) Handles picOsa.MouseMove
        Static oldX As Integer, oldY As Integer
        If isDrawingOsa AndAlso gOsa IsNot Nothing Then
            gOsa.DrawLine(penSignature, oldX, oldY, e.X, e.Y)
            picOsa.Invalidate()
        End If
        oldX = e.X
        oldY = e.Y
    End Sub

    Private Sub PicOsa_MouseUp(sender As Object, e As MouseEventArgs) Handles picOsa.MouseUp
        isDrawingOsa = False
    End Sub

    ' --- Dean Signature Drawing Events ---
    Private Sub PicDean_MouseDown(sender As Object, e As MouseEventArgs) Handles picDean.MouseDown
        If e.Button = MouseButtons.Left Then isDrawingDean = True
    End Sub

    Private Sub PicDean_MouseMove(sender As Object, e As MouseEventArgs) Handles picDean.MouseMove
        Static oldX As Integer, oldY As Integer
        If isDrawingDean AndAlso gDean IsNot Nothing Then
            gDean.DrawLine(penSignature, oldX, oldY, e.X, e.Y)
            picDean.Invalidate()
        End If
        oldX = e.X
        oldY = e.Y
    End Sub

    Private Sub PicDean_MouseUp(sender As Object, e As MouseEventArgs) Handles picDean.MouseUp
        isDrawingDean = False
    End Sub

    ' --- SUBMIT BUTTON (Completed Violation Record) ---
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        SaveViolationRecord("Completed")
    End Sub

    ' --- SAVE AS PENDING BUTTON ---
    Private Sub BtnSavePending_Click(sender As Object, e As EventArgs) Handles btnSavePending.Click
        SaveViolationRecord("Pending")
    End Sub

    ' --- CENTRALIZED SAVE METHOD PARA SA DATABASE ---
    Private Sub SaveViolationRecord(recordStatus As String)
        Try
            Using conn As OdbcConnection = GetConnection()
                conn.Open()

                Dim query As String = "INSERT INTO tbl_violation_records " &
                                     "(student_number, student_name, program, year_section, violation_type, offense_count, punishment_category, status, created_at) " &
                                     "VALUES (?, ?, ?, ?, ?, ?, ?, ?, NOW())"

                Using cmd As New OdbcCommand(query, conn)
                    cmd.Parameters.AddWithValue("?", If(String.IsNullOrEmpty(StudentNo), DBNull.Value, StudentNo))
                    cmd.Parameters.AddWithValue("?", If(String.IsNullOrEmpty(StudentName), DBNull.Value, StudentName))
                    cmd.Parameters.AddWithValue("?", If(String.IsNullOrEmpty(Program), DBNull.Value, Program))
                    cmd.Parameters.AddWithValue("?", If(String.IsNullOrEmpty(YearSection), DBNull.Value, YearSection))
                    cmd.Parameters.AddWithValue("?", If(String.IsNullOrEmpty(ViolationType), DBNull.Value, ViolationType))
                    cmd.Parameters.AddWithValue("?", If(String.IsNullOrEmpty(Offense), "1st", Offense))

                    ' Inayos natin ito para hindi mag-error na null ang punishment_category
                    Dim punishmentVal As String = If(String.IsNullOrEmpty(Punishment), "Standard Warning", Punishment)
                    cmd.Parameters.AddWithValue("?", punishmentVal)

                    cmd.Parameters.AddWithValue("?", recordStatus)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            If recordStatus = "Pending" Then
                MessageBox.Show("Ang violation record ay matagumpay na nai-save bilang Pending!", "Tagumpay", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Ang violation record ay matagumpay na nai-save at na-complete!", "Tagumpay", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' Bumalik sa Dashboard matapos mag-save
            Dim dash As New DashboardForm()
            dash.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- BACK BUTTON ---
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dash As New DashboardForm()
        dash.Show()
        Me.Close()
    End Sub

    ' --- PRINT PHYSICAL SLIP BUTTON ---
    Private Sub BtnPrintSlip_Click(sender As Object, e As EventArgs) Handles btnPrintSlip.Click
        Dim printDoc As New PrintDocument()
        AddHandler printDoc.PrintPage, AddressOf PrintDocument1_PrintPage

        Using previewDialog As New PrintPreviewDialog()
            previewDialog.Document = printDoc
            previewDialog.ShowDialog()
        End Using
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim g As Graphics = e.Graphics

        Using titleFont As New Font("Arial", 11, FontStyle.Bold),
              subTitleFont As New Font("Arial", 9, FontStyle.Bold),
              bodyFont As New Font("Arial", 9, FontStyle.Regular),
              labelFont As New Font("Arial", 8, FontStyle.Italic)

            Dim startX As Integer = 50
            Dim startY As Integer = 50
            Dim width As Integer = 500
            Dim currentY As Integer = startY

            g.DrawRectangle(Pens.Black, startX, startY, width, 320)

            g.DrawString("COLEGIO DE STA. TERESA DE AVILA", titleFont, Brushes.Black, startX + 80, currentY + 10)
            g.DrawString("School of Information Technology", subTitleFont, Brushes.Black, startX + 130, currentY + 28)

            currentY += 55
            g.DrawString("VIOLATION SLIP", titleFont, Brushes.Black, startX + 180, currentY)

            currentY += 25
            Dim isUniform As String = If(Not String.IsNullOrEmpty(ViolationType) AndAlso ViolationType.Contains("No Proper Uniform"), "[ / ]", "[   ]")
            Dim isGrooming As String = If(Not String.IsNullOrEmpty(ViolationType) AndAlso ViolationType.Contains("No Proper Grooming"), "[ / ]", "[   ]")
            g.DrawString(isUniform & " No proper Uniform    " & isGrooming & " No proper grooming", bodyFont, Brushes.Black, startX + 100, currentY)

            currentY += 30
            g.DrawString("Name of Student: " & If(StudentName, ""), bodyFont, Brushes.Black, startX + 15, currentY)

            currentY += 20
            g.DrawString("Program: " & If(Program, ""), bodyFont, Brushes.Black, startX + 15, currentY)
            g.DrawString("Year & Section: " & If(YearSection, ""), bodyFont, Brushes.Black, startX + 300, currentY)

            currentY += 25
            Dim off1 As String = If(Offense = "1st", "[ / ]", "[   ]")
            Dim off2 As String = If(Offense = "2nd", "[ / ]", "[   ]")
            Dim off3 As String = If(Offense = "3rd", "[ / ]", "[   ]")
            Dim off4 As String = If(Offense = "4th and above", "[ / ]", "[   ]")
            g.DrawString("No. of offense:    " & off1 & " 1st    " & off2 & " 2nd    " & off3 & " 3rd    " & off4 & " 4th and above", bodyFont, Brushes.Black, startX + 15, currentY)

            currentY += 30
            g.DrawLine(Pens.Black, startX + 10, currentY, startX + width - 10, currentY)
            currentY += 5
            g.DrawString("Endorsed by:", bodyFont, Brushes.Black, startX + 15, currentY)
            g.DrawString("Name and signature of Professor", labelFont, Brushes.Black, startX + 170, currentY + 15)

            currentY += 35
            g.DrawLine(Pens.Black, startX + 10, currentY, startX + width - 10, currentY)
            currentY += 5
            g.DrawString("Noted by:", bodyFont, Brushes.Black, startX + 15, currentY)
            g.DrawString("Name and Signature of Guidance Counselor", labelFont, Brushes.Black, startX + 150, currentY + 15)

            currentY += 35
            g.DrawLine(Pens.Black, startX + 10, currentY, startX + width - 10, currentY)
            currentY += 5
            g.DrawString("Affirmed by:", bodyFont, Brushes.Black, startX + 15, currentY)
            g.DrawString("Name and signature of Dean", labelFont, Brushes.Black, startX + 180, currentY + 15)
        End Using
    End Sub

End Class