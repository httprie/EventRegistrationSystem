﻿
Public Class Login
    Dim username As String
    Dim password As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = btnLogin
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        username = txtun.Text
        password = txtpw.Text

        If username = "admin" And password = "admin" Then
            Me.Hide()
            adminHome.Show()
        ElseIf username = "" Or password = "" Then
            MessageBox.Show("Please fill in the login details.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Username or Password incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub tsRemember_CheckedChanged(sender As Object, e As EventArgs) Handles btnShow.CheckedChanged
        If btnShow.Checked Then
            txtpw.PasswordChar = ""
        Else
            txtpw.PasswordChar = "*"
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class