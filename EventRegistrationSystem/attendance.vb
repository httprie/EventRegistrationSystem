Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing
Public Class attendance
    Private videoSource As VideoCaptureDevice
    Private webcamRunning As Boolean = False
    Private qrReader As New ZXing.BarcodeReader()

    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pbwebcam.SizeMode = PictureBoxSizeMode.Zoom
        StartWebcam()
    End Sub

    Private Sub btnstartstop_Click(sender As Object, e As EventArgs) Handles btnstartstop.Click
        If btnstartstop.Text = "Start" Then
            StartWebcam()
            btnstartstop.Text = "Stop"
        Else
            StopWebcam()
            btnstartstop.Text = "Start"
        End If
    End Sub

    Private Sub StartWebcam()
        Dim videoDevices As New FilterInfoCollection(FilterCategory.VideoInputDevice)

        If videoDevices.Count > 0 Then
            videoSource = New VideoCaptureDevice(videoDevices(0).MonikerString)
            AddHandler videoSource.NewFrame, AddressOf VideoSource_NewFrame
            videoSource.Start()
            webcamRunning = True
        Else
            MessageBox.Show("No webcam found.")
        End If
        btnstartstop.Text = If(webcamRunning, "Stop", "Start")
    End Sub

    Private Sub StopWebcam()
        If webcamRunning Then
            videoSource.SignalToStop()
            videoSource.WaitForStop()
            webcamRunning = False
            pbwebcam.Image = Nothing
        End If
    End Sub

    Private Sub VideoSource_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        pbwebcam.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)

        Dim result = qrReader.Decode(eventArgs.Frame)

        If result IsNot Nothing Then
            Dim dataParts As String() = result.Text.Split(","c)
            If dataParts.Length >= 5 Then
                Dim row As String() = New String() {dataParts(0), dataParts(1), dataParts(2), dataParts(3), dataParts(4)}
                data.Rows.Add(row)
            End If
        End If
    End Sub

    Private Sub btnscan_Click(sender As Object, e As EventArgs) Handles btnscan.Click
        If Not webcamRunning Then
            MessageBox.Show("Please start the webcam first.")
            Return
        End If

        Dim currentFrame As Bitmap = DirectCast(pbwebcam.Image, Bitmap)

        If currentFrame IsNot Nothing Then
            Dim result = qrReader.Decode(currentFrame)

            If result IsNot Nothing Then
                Dim dataParts As String() = result.Text.Split(","c)

                If dataParts.Length >= 4 Then
                    Dim studentID As String = dataParts(3)
                    Dim studentName As String = dataParts(0)
                    Dim course As String = dataParts(1)
                    Dim yrsec As String = dataParts(2)

                    Dim yearSectionCourse As String = $"{course}-{yrsec}"

                    Dim currentDate As String = DateTime.Now.ToShortDateString()
                    Dim currentTime As String = DateTime.Now.ToShortTimeString()

                    Dim row As String() = New String() {studentID, studentName, yearSectionCourse, currentDate, currentTime}
                    data.Rows.Add(row)
                Else
                    MessageBox.Show("QR code does not contain enough data.")
                End If
            Else
                MessageBox.Show("No QR code detected.")
            End If
        Else
            MessageBox.Show("No image to scan.")
        End If
    End Sub
End Class
