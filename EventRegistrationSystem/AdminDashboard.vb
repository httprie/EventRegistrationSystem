Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Public Class AdminDashboard
    Dim conn As New MySqlConnection
    Dim sqlQuery As String
    Dim da As MySqlDataAdapter
    Dim ds As New DataSet
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        Dim dbname As String = "EventRegistrationSystem"
        Dim uname As String = "root"
        Dim password As String = "password" 'mysql paswword
        Dim server As String = "127.0.0.1"

        With conn
            .ConnectionString = "server= " & server & ";user id = " & uname & "; password= " &
            password & ";database=" & dbname & ""
            .Open()
        End With
        LoadChart()
    End Sub
    Sub LoadChart()
        AttendeesChart.Series.Clear()

        Dim series1 As New Series("Attendees")
        series1.ChartType = SeriesChartType.Pie
        AttendeesChart.Series.Add(series1)

        sqlQuery = "SELECT e.eventname, COUNT(a.attendeeid) AS attendeesCount " &
                   "FROM attendees a " &
                   "JOIN events e ON a.eventid = e.eventid " &
                   "GROUP BY e.eventname"
        da = New MySqlDataAdapter(sqlQuery, conn)
        ds.Clear()
        da.Fill(ds, "Attendees")

        AttendeesChart.DataSource = ds.Tables("Attendees")
        series1.XValueMember = "eventname"
        series1.YValueMembers = "attendeesCount"

        With series1
            .LabelFormat = "{#,##0}"
            .IsValueShownAsLabel = True
            .LegendText = "#VALX (#PERCENT)"
            .Font = New Font("Arial", 10, FontStyle.Regular)
        End With

        With AttendeesChart
            .ChartAreas(0).Area3DStyle.Enable3D = True
            .Series(0)("PieLabelStyle") = "Outside"
        End With
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim timer As String
        timer = Date.Now.ToString()
        timedate.Text = timer
    End Sub
End Class