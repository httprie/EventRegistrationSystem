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
End Class