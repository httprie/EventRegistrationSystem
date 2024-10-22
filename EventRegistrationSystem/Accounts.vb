Imports MySql.Data.MySqlClient
Imports Module1

Public Class Accounts

    Dim sqlQuery As String
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim conn As New MySqlConnection

    Private Sub Accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbConnect()
        LoadAccountsData()
        Timer1.Enabled = True
    End Sub

    Private Sub LoadAccountsData()
    End Sub
    Private Sub btnloaduser_Click(sender As Object, e As EventArgs) Handles btnloaduser.Click
        Dim query As String = "SELECT * FROM Accounts"
        Dim da As New MySqlDataAdapter(query, Module1.conn)
        Dim dt As New DataTable

        Try
            da.Fill(dt)
            data.DataSource = dt
            AddButtonsToDataGridView()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub



    Private Sub AddButtonsToDataGridView()
        If data.Columns.Contains("Edit") Then data.Columns.Remove("Edit")
        If data.Columns.Contains("Delete") Then data.Columns.Remove("Delete")

        Dim editButton As New DataGridViewButtonColumn()
        editButton.HeaderText = "Edit"
        editButton.Text = "Edit"
        editButton.Name = "Edit"
        editButton.UseColumnTextForButtonValue = True
        data.Columns.Add(editButton)

        Dim deleteButton As New DataGridViewButtonColumn()
        deleteButton.HeaderText = "Delete"
        deleteButton.Text = "Delete"
        deleteButton.Name = "Delete"
        deleteButton.UseColumnTextForButtonValue = True
        data.Columns.Add(deleteButton)
    End Sub

    Private Sub data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data.CellContentClick
        If e.ColumnIndex = data.Columns("Edit").Index Then
            EditRecord(e.RowIndex)
        ElseIf e.ColumnIndex = data.Columns("Delete").Index Then
            DeleteRecord(e.RowIndex)
        End If
    End Sub
    Private Sub EditRecord(rowIndex As Integer)
        Dim username As String = data.Rows(rowIndex).Cells("UserName").Value
        Dim password As String = data.Rows(rowIndex).Cells("Password").Value
        Dim fn As String = data.Rows(rowIndex).Cells("FullName").Value
        Dim role As String = data.Rows(rowIndex).Cells("Role").Value

        Dim newUsername As String = InputBox("Enter new Username", "Edit Record", username)
        Dim newPassword As String = InputBox("Enter new Password", "Edit Record", password)
        Dim newFullname As String = InputBox("Enter new Full Name", "Edit Record", fn)
        Dim newRole As String = InputBox("Enter new Role", "Edit Record", role)

        Dim query As String = "UPDATE Accounts SET UserName = @UserName, Password = @Password, FullName = @FullName, Role = @Role;"
        Dim cmd As New MySqlCommand(query, Module1.conn)

        cmd.Parameters.AddWithValue("@UserName", newUsername)
        cmd.Parameters.AddWithValue("@Password", newPassword)
        cmd.Parameters.AddWithValue("@FullName", newFullname)
        cmd.Parameters.AddWithValue("@Role", newRole)
        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record updated successfully.")

            LoadAccountsData()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub DeleteRecord(rowIndex As Integer)
        Dim id As Integer = data.Rows(rowIndex).Cells("UserID").Value

        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo)
        If confirm = DialogResult.Yes Then

            Dim query As String = "DELETE FROM Accounts WHERE UserID = @id"
            Dim cmd As New MySqlCommand(query, Module1.conn)
            cmd.Parameters.AddWithValue("@id", id)

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record deleted successfully.")

                LoadAccountsData()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim timer As String
        timer = Date.Now.ToString()
        timedate.Text = timer
    End Sub

    Private Sub btnaddacc_Click(sender As Object, e As EventArgs) Handles btnaddacc.Click
        AddAccount.Show()
    End Sub

End Class
