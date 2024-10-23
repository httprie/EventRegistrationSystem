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
        childform(New GenerateQR())
    End Sub

    Private Sub bntlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do you really want to log out this account?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dispose()
        End If
        End
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub
    Private Sub adminHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub btnacc_Click(sender As Object, e As EventArgs) Handles btnacc.Click
        childform(New Accounts())
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        childform(New AdminDashboard())
    End Sub
End Class