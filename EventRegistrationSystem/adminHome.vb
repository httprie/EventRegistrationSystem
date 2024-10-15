Public Class adminHome
    Sub childform(ByVal panel As Form)
        pnlhome.Controls.Clear()
        panel.TopLevel = False
        pnlhome.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        childform(New attendance())
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        childform(New generate())
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do you really want to log out this account?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dispose()
        End If
    End Sub
End Class