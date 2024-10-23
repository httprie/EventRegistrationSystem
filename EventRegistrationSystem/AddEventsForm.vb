
Public Class AddNewForm
    ' Declare a public reference to eventsForm
    Public EventsFormInstance As eventsForm
    Public IsEditMode As Boolean = False
    Public EventName As String
    Public Venue As String
    Public EventDate As DateTime
    Public Department As String
    Public StartTime As DateTime
    Public EndTime As DateTime

    ' Load event for the form
    Private Sub addNewEventsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check if in edit mode
        If IsEditMode Then
            ' Populate the fields with the passed data
            txtEventName.Text = EventName
            txtVenue.Text = Venue
            dtpEventDate.Value = EventDate
            txtDepartment.Text = Department
            dtpStartTime.Value = StartTime
            dtpEndTime.Value = EndTime
        End If
    End Sub


    ' Button to add event details
    Private Sub btnAddEvent_Click(sender As Object, e As EventArgs) Handles btnAddEvent.Click
        ' Get the input data from the textboxes
        Dim eventName As String = txtEventName.Text
        Dim venue As String = txtVenue.Text
        Dim department As String = txtDepartment.Text

        Dim eventDate As DateTime = dtpEventDate.Value
        Dim startTime As DateTime = dtpStartTime.Value
        Dim endTime As DateTime = dtpEndTime.Value

        If IsEditMode Then
            Dim confirmEdit As DialogResult = MessageBox.Show("Are you sure you want to edit this event?",
                                                             "Edit Confirmation", MessageBoxButtons.YesNo,
                                                             MessageBoxIcon.Question)
            If confirmEdit = DialogResult.Yes Then
                ' Update the selected row
                Dim rowIndex As Integer = EventsFormInstance.DataGridViewEvents.CurrentCell.RowIndex
                EventsFormInstance.DataGridViewEvents.Rows(rowIndex).Cells("eventName").Value = eventName
                EventsFormInstance.DataGridViewEvents.Rows(rowIndex).Cells("venue").Value = venue
                EventsFormInstance.DataGridViewEvents.Rows(rowIndex).Cells("eventDate").Value = eventDate.ToShortDateString()
                EventsFormInstance.DataGridViewEvents.Rows(rowIndex).Cells("depart").Value = department
                EventsFormInstance.DataGridViewEvents.Rows(rowIndex).Cells("startTime").Value = startTime.ToShortTimeString()
                EventsFormInstance.DataGridViewEvents.Rows(rowIndex).Cells("endTime").Value = endTime.ToShortTimeString()
                MessageBox.Show("Event updated successfully.")

            End If 'Closing of the inner if

        Else
            ' If not in edit mode, confirmation before adding a new row
            Dim confirmAdd As DialogResult = MessageBox.Show("Are you sure you want to add this event?",
                                                             "Add Confirmation", MessageBoxButtons.YesNo,
                                                             MessageBoxIcon.Question)

            If confirmAdd = DialogResult.Yes Then
                'add new row and Add the data to the DataGridView in eventsForm
                EventsFormInstance.DataGridViewEvents.Rows.Add(eventName, venue,
                                                           eventDate.ToShortDateString(),
                                                           department, startTime.ToShortTimeString(),
                                                           endTime.ToShortTimeString())
                MessageBox.Show("Event added successfully.")
            End If 'Closing of the inner if
        End If 'Closing of the outer if

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEventName.Clear()
        txtVenue.Clear()
        txtDepartment.Clear()
    End Sub

End Class