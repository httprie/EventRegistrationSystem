Imports MySql.Data.MySqlClient
Imports Module1
Public Class AddAccount

    Dim cmd As New MySqlCommand
    Dim result As Integer
    Dim UserName As String
    Dim Password As String
    Dim FullName As String
    Dim Role As String

    Private Sub AddAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbConnect()
    End Sub


    Private Sub btnaddsave_Click(sender As Object, e As EventArgs) Handles btnaddsave.Click
        UserName = txtuname.Text
        Password = txtpwd.Text
        FullName = txtfname.Text
        Role = txtrole.Text

        Try
            With cmd
                .Connection = conn
                .CommandText = "INSERT INTO Accounts (Username, Password, Fullname, Role) VALUES (@UserName, @Password, @FullName, @Role)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@UserName", UserName)
                .Parameters.AddWithValue("@Password", Password)
                .Parameters.AddWithValue("@FullName", FullName)
                .Parameters.AddWithValue("@Role", Role)

                result = cmd.ExecuteNonQuery()

                If result > 0 Then
                    MessageBox.Show("Conformation:", "Do you really want to add this account?", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MessageBox.Show("Success!", "Account Added!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearTextBoxes()
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub ClearTextBoxes()
        txtuname.Text = ""
        txtpwd.Text = ""
        txtfname.Text = ""
        txtrole.Text = ""
    End Sub


    Private Sub btnshowpwd_Click(sender As Object, e As EventArgs) Handles btnshowpwd.Click
        If txtpwd.PasswordChar = "*" Then
            txtpwd.PasswordChar = ""
            btnshowpwd.Text = "Hide"
        Else
            txtpwd.PasswordChar = "*"
            btnshowpwd.Text = "Show"
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        ClearTextBoxes()
    End Sub
End Class
