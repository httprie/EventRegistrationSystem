Imports System.Net.Mail
Public Class EmailForm
    Dim mail As New MailMessage()
    Dim smtserver As New SmtpClient("smtp.gmail.com")

    Public Property email As String
    Public Property message As String
    Public Property qrCodePath As String

    Private Sub EmailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblto.Text = email
        lblsubject.Text = "Attendance QR Code"
        txtmessage.Text = message

        If Not String.IsNullOrEmpty(qrCodePath) Then
            Dim attach As New Attachment(qrCodePath)
            mail.Attachments.Add(attach)
        End If
    End Sub

    Private Sub btnattach_Click(sender As Object, e As EventArgs) Handles btnattach.Click
        OpenFileDialog1.ShowDialog()
        lblfilename.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btnsend_Click(sender As Object, e As EventArgs) Handles btnsend.Click



        mail.From = New MailAddress("dyci.eventreg@gmail.com")
        mail.To.Add(email)
        mail.Subject = lblsubject.Text
        mail.Body = txtmessage.Text

        Dim attach As System.Net.Mail.Attachment
        attach = New System.Net.Mail.Attachment(lblfilename.Text)
        mail.Attachments.Add(attach)

        smtserver.Port = 587
        smtserver.Credentials = New System.Net.NetworkCredential("dyci.eventreg@gmail.com", "qxfc xvqr amsy wyxe
")
        smtserver.EnableSsl = True
        smtserver.Send(mail)

        MessageBox.Show("Email sent!")
        Me.Hide()

    End Sub
End Class