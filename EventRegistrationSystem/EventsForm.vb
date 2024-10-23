Imports System.Data.SqlClient

Public Class eventsForm

    'Method for displaying time
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim s As String
        s = Date.Now.ToString()
        timedate.Text = s
    End Sub

    Private Sub generate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    'To show the add new event form 
    Private Sub btnAddEvent_Click(sender As Object, e As EventArgs) Handles btnAddEvent.Click
        ' Create an instance of addNewEventsForm
        Dim addNewEventFormInstance As New AddNewForm()

        ' Pass the reference of current eventsForm (Me) to the addNewEventsForm
        addNewEventFormInstance.EventsFormInstance = Me

        ' Show the addNewEventsForm
        addNewEventFormInstance.Show()
    End Sub


    'For editing the selected rows in the datagridview
    Private Sub DataGridViewEvents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewEvents.CellContentClick
        Try
            ' Ensure we are clicking on a valid row and the "Edit" column
            If e.RowIndex >= 0 AndAlso DataGridViewEvents.Columns(e.ColumnIndex).Name = "EDIT" Then

                ' Get the data from the selected row
                Dim selectedRow As DataGridViewRow = DataGridViewEvents.Rows(e.RowIndex)

                ' Extract values from the row's cells
                Dim eventName As String = selectedRow.Cells("eventName").Value.ToString()
                Dim venue As String = selectedRow.Cells("venue").Value.ToString()
                Dim eventDate As DateTime = DateTime.Parse(selectedRow.Cells("eventDate").Value.ToString())
                Dim department As String = selectedRow.Cells("depart").Value.ToString()
                Dim startTime As DateTime = DateTime.Parse(selectedRow.Cells("startTime").Value.ToString())
                Dim endTime As DateTime = DateTime.Parse(selectedRow.Cells("endTime").Value.ToString())

                ' Create an instance of addNewEventsForm
                Dim addNewEventFormInstance As New AddNewForm()

                ' Pass the data to the addNewEventsForm for editing
                addNewEventFormInstance.EventsFormInstance = Me
                addNewEventFormInstance.IsEditMode = True
                addNewEventFormInstance.EventName = eventName
                addNewEventFormInstance.Venue = venue
                addNewEventFormInstance.EventDate = eventDate
                addNewEventFormInstance.Department = department
                addNewEventFormInstance.StartTime = startTime
                addNewEventFormInstance.EndTime = endTime

                ' Show the addNewEventsForm
                addNewEventFormInstance.Show()

                'For Deleting records in the datagrid
            ElseIf e.RowIndex >= 0 AndAlso DataGridViewEvents.Columns(e.ColumnIndex).Name = "DELETE" Then
                ' If the "Delete" button is clicked, remove the selected row
                Dim confirmDelete As DialogResult = MessageBox.Show("Are you sure you want to delete this event?", "Confirm Delete", MessageBoxButtons.YesNo)

                If confirmDelete = DialogResult.Yes Then
                    ' Remove the selected row
                    DataGridViewEvents.Rows.RemoveAt(e.RowIndex)
                    MessageBox.Show("Event deleted successfully.")
                End If
            End If
        Catch ex As Exception
            'using this for easy debugging
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

    End Sub

    Private Sub btnSearchEvent_Click(sender As Object, e As EventArgs) Handles btnSearchEvent.Click
        Dim searchText As String = txtSearch.Text.Trim().ToLower()

        ' Loop through the rows of the DataGridView
        For Each row As DataGridViewRow In DataGridViewEvents.Rows
            ' Skip the new row
            If row.IsNewRow Then
                Continue For
            End If

            row.Visible = False ' Hide row by default

            ' Check each cell in the row for the search text
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing AndAlso cell.Value.ToString().ToLower().Contains(searchText) Then
                    row.Visible = True ' Show the row if the search text is found
                    Exit For
                End If
            Next
        Next
    End Sub
End Class