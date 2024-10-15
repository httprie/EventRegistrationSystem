Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.QRCode.Data
Public Class generate

    Private Sub btngenerate_Click(sender As Object, e As EventArgs) Handles btngenerate.Click

        Dim fullname As String = txtname.Text
        Dim course As String = txtcourse.Text
        Dim yrsec As String = txtyrsec.Text
        Dim studID As String = txtstudID.Text

        If String.IsNullOrWhiteSpace(fullname) OrElse String.IsNullOrWhiteSpace(course) OrElse String.IsNullOrWhiteSpace(yrsec) OrElse String.IsNullOrWhiteSpace(studID) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Dim gen As New QRCodeEncoder()
        gen.QRCodeScale = 5

        Dim qrData As String = $"{fullname},{course},{yrsec},{studID}"

        Try
            Dim qr As Bitmap = gen.Encode(qrData)

            If qr IsNot Nothing Then
                QRCode.Image = qr
            Else
                MessageBox.Show("Failed to generate QR Code.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim save As New SaveFileDialog()

        save.InitialDirectory = "C:\Users\user\Documents\BASILIO\QRCode"
        save.FileName = txtname.Text
        save.Filter = "PNG|*.png"

        If save.ShowDialog() = DialogResult.OK Then
            If QRCode.Image IsNot Nothing Then
                QRCode.Image.Save(save.FileName, Imaging.ImageFormat.Png)
            Else
                MessageBox.Show("No QR Code Image to save.")
            End If
        End If
    End Sub
End Class