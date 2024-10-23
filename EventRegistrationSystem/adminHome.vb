Imports System.Windows.Forms.DataVisualization.Charting
Public Class adminHome
    Sub childform(ByVal panel As Form)
        pnlhome.Controls.Clear()
        panel.TopLevel = False
        pnlhome.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnattendance_Click(sender As Object, e As EventArgs) Handles btnattendance.Click
        childform(New attendance())
    End Sub

    Private Sub btnstudent_Click(sender As Object, e As EventArgs) Handles btnstudent.Click
        childform(New generate())
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        childform(New generate())
    End Sub

    ' Declare a variable to hold the reference of eventsForm
    Private eventsFormInstance As eventsForm

    Private Sub btnevent_Click(sender As Object, e As EventArgs) Handles btnevent.Click
        ' Create an instance of eventsForm
        eventsFormInstance = New eventsForm()

        ' Load eventsForm as a childform in the panel
        childform(eventsFormInstance)
    End Sub


    Private Sub bntlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do you really want to log out this account?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dispose()
        End If
        End
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim s As String
        s = Date.Now.ToString()
        timedate.Text = s
    End Sub

    Private Sub adminHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click
        Dim series1 As Series = Chart1.Series("Series 1")
        series1.ChartType = SeriesChartType.Pie
    End Sub

End Class