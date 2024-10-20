<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.btnlogout = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.pnlhome = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblwelcome = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.timedate = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btnexit = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btnacc = New Guna.UI2.WinForms.Guna2Button()
        Me.btnreport = New Guna.UI2.WinForms.Guna2Button()
        Me.btnevent = New Guna.UI2.WinForms.Guna2Button()
        Me.btnstudent = New Guna.UI2.WinForms.Guna2Button()
        Me.btnattendance = New Guna.UI2.WinForms.Guna2Button()
        Me.btnhome = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.data = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Student = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlhome.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.Transparent
        Me.btnlogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnlogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnlogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnlogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnlogout.FillColor = System.Drawing.Color.Transparent
        Me.btnlogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnlogout.ForeColor = System.Drawing.Color.White
        Me.btnlogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnlogout.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnlogout.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnlogout.Location = New System.Drawing.Point(-1, 568)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(269, 45)
        Me.btnlogout.TabIndex = 15
        Me.btnlogout.Text = "LOG OUT"
        Me.btnlogout.UseTransparentBackground = True
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'pnlhome
        '
        Me.pnlhome.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pnlhome.Controls.Add(Me.data)
        Me.pnlhome.Controls.Add(Me.PictureBox2)
        Me.pnlhome.Controls.Add(Me.Label1)
        Me.pnlhome.Controls.Add(Me.Label3)
        Me.pnlhome.Controls.Add(Me.Label2)
        Me.pnlhome.Controls.Add(Me.lblwelcome)
        Me.pnlhome.Controls.Add(Me.Chart1)
        Me.pnlhome.Controls.Add(Me.timedate)
        Me.pnlhome.Controls.Add(Me.PictureBox1)
        Me.pnlhome.Location = New System.Drawing.Point(245, 0)
        Me.pnlhome.Name = "pnlhome"
        Me.pnlhome.Size = New System.Drawing.Size(753, 628)
        Me.pnlhome.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(144, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 32)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Attendance"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(521, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 32)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Events Today"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(297, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(293, 32)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Event Registration System"
        '
        'lblwelcome
        '
        Me.lblwelcome.AutoSize = True
        Me.lblwelcome.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwelcome.ForeColor = System.Drawing.Color.White
        Me.lblwelcome.Location = New System.Drawing.Point(305, 75)
        Me.lblwelcome.Name = "lblwelcome"
        Me.lblwelcome.Size = New System.Drawing.Size(246, 38)
        Me.lblwelcome.TabIndex = 19
        Me.lblwelcome.Text = "Welcome, admin!"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(60, 316)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(271, 249)
        Me.Chart1.TabIndex = 18
        Me.Chart1.Text = "Chart1"
        '
        'timedate
        '
        Me.timedate.AutoSize = True
        Me.timedate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timedate.ForeColor = System.Drawing.Color.White
        Me.timedate.Location = New System.Drawing.Point(29, 8)
        Me.timedate.Name = "timedate"
        Me.timedate.Size = New System.Drawing.Size(127, 25)
        Me.timedate.TabIndex = 17
        Me.timedate.Text = "                       "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MidnightBlue
        Me.PictureBox1.Location = New System.Drawing.Point(19, 186)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(731, 47)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.DimGray
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(924, 1)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(31, 28)
        Me.Guna2ControlBox3.TabIndex = 13
        '
        'btnexit
        '
        Me.btnexit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnexit.FillColor = System.Drawing.Color.Transparent
        Me.btnexit.IconColor = System.Drawing.Color.DimGray
        Me.btnexit.Location = New System.Drawing.Point(952, 1)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(31, 28)
        Me.btnexit.TabIndex = 12
        '
        'btnacc
        '
        Me.btnacc.BackColor = System.Drawing.Color.Transparent
        Me.btnacc.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnacc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnacc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnacc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnacc.FillColor = System.Drawing.Color.Transparent
        Me.btnacc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnacc.ForeColor = System.Drawing.Color.White
        Me.btnacc.Image = Global.EventRegistrationSystem.My.Resources.Resources.icons8_select_users_96
        Me.btnacc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnacc.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btnacc.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnacc.Location = New System.Drawing.Point(-22, 418)
        Me.btnacc.Name = "btnacc"
        Me.btnacc.Size = New System.Drawing.Size(290, 45)
        Me.btnacc.TabIndex = 14
        Me.btnacc.Text = "ACCOUNTS"
        Me.btnacc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnacc.TextOffset = New System.Drawing.Point(40, 0)
        Me.btnacc.UseTransparentBackground = True
        '
        'btnreport
        '
        Me.btnreport.BackColor = System.Drawing.Color.Transparent
        Me.btnreport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnreport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnreport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnreport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnreport.FillColor = System.Drawing.Color.Transparent
        Me.btnreport.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnreport.ForeColor = System.Drawing.Color.White
        Me.btnreport.Image = Global.EventRegistrationSystem.My.Resources.Resources.icons8_report_96
        Me.btnreport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnreport.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btnreport.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnreport.Location = New System.Drawing.Point(-22, 367)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(290, 45)
        Me.btnreport.TabIndex = 13
        Me.btnreport.Text = "REPORTS"
        Me.btnreport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnreport.TextOffset = New System.Drawing.Point(40, 0)
        Me.btnreport.UseTransparentBackground = True
        '
        'btnevent
        '
        Me.btnevent.BackColor = System.Drawing.Color.Transparent
        Me.btnevent.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnevent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnevent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnevent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnevent.FillColor = System.Drawing.Color.Transparent
        Me.btnevent.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnevent.ForeColor = System.Drawing.Color.White
        Me.btnevent.Image = Global.EventRegistrationSystem.My.Resources.Resources.icons8_events_96
        Me.btnevent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnevent.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btnevent.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnevent.Location = New System.Drawing.Point(-22, 316)
        Me.btnevent.Name = "btnevent"
        Me.btnevent.Size = New System.Drawing.Size(290, 45)
        Me.btnevent.TabIndex = 12
        Me.btnevent.Text = "EVENTS"
        Me.btnevent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnevent.TextOffset = New System.Drawing.Point(40, 0)
        Me.btnevent.UseTransparentBackground = True
        '
        'btnstudent
        '
        Me.btnstudent.BackColor = System.Drawing.Color.Transparent
        Me.btnstudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnstudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnstudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnstudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnstudent.FillColor = System.Drawing.Color.Transparent
        Me.btnstudent.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnstudent.ForeColor = System.Drawing.Color.White
        Me.btnstudent.Image = Global.EventRegistrationSystem.My.Resources.Resources.icons8_student_registration_96
        Me.btnstudent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnstudent.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btnstudent.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnstudent.Location = New System.Drawing.Point(-22, 265)
        Me.btnstudent.Name = "btnstudent"
        Me.btnstudent.Size = New System.Drawing.Size(290, 45)
        Me.btnstudent.TabIndex = 11
        Me.btnstudent.Text = "STUDENT"
        Me.btnstudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnstudent.TextOffset = New System.Drawing.Point(40, 0)
        Me.btnstudent.UseTransparentBackground = True
        '
        'btnattendance
        '
        Me.btnattendance.BackColor = System.Drawing.Color.Transparent
        Me.btnattendance.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnattendance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnattendance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnattendance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnattendance.FillColor = System.Drawing.Color.Transparent
        Me.btnattendance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnattendance.ForeColor = System.Drawing.Color.White
        Me.btnattendance.Image = Global.EventRegistrationSystem.My.Resources.Resources.icons8_attendance_96
        Me.btnattendance.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnattendance.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btnattendance.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnattendance.Location = New System.Drawing.Point(-22, 214)
        Me.btnattendance.Name = "btnattendance"
        Me.btnattendance.PressedColor = System.Drawing.Color.White
        Me.btnattendance.Size = New System.Drawing.Size(290, 45)
        Me.btnattendance.TabIndex = 10
        Me.btnattendance.Text = "ATTENDANCE"
        Me.btnattendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnattendance.TextOffset = New System.Drawing.Point(40, 0)
        Me.btnattendance.UseTransparentBackground = True
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.Color.Transparent
        Me.btnhome.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnhome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnhome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnhome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnhome.FillColor = System.Drawing.Color.Transparent
        Me.btnhome.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhome.ForeColor = System.Drawing.Color.White
        Me.btnhome.Image = Global.EventRegistrationSystem.My.Resources.Resources.round_removebg_preview
        Me.btnhome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnhome.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btnhome.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnhome.Location = New System.Drawing.Point(-22, 163)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(290, 45)
        Me.btnhome.TabIndex = 9
        Me.btnhome.Text = "HOME"
        Me.btnhome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnhome.TextOffset = New System.Drawing.Point(40, 0)
        Me.btnhome.UseTransparentBackground = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2PictureBox1.Image = Global.EventRegistrationSystem.My.Resources.Resources.menu_bg
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(268, 625)
        Me.Guna2PictureBox1.TabIndex = 8
        Me.Guna2PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(396, 186)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(5, 456)
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'data
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.data.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.data.ColumnHeadersHeight = 22
        Me.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.data.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Student, Me.Column1, Me.Column2})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data.DefaultCellStyle = DataGridViewCellStyle3
        Me.data.GridColor = System.Drawing.Color.Gainsboro
        Me.data.Location = New System.Drawing.Point(399, 237)
        Me.data.Name = "data"
        Me.data.RowHeadersVisible = False
        Me.data.RowHeadersWidth = 62
        Me.data.RowTemplate.Height = 28
        Me.data.Size = New System.Drawing.Size(346, 159)
        Me.data.TabIndex = 25
        Me.data.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.data.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.data.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.data.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.data.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.data.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.data.ThemeStyle.GridColor = System.Drawing.Color.Gainsboro
        Me.data.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.data.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.data.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.data.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.data.ThemeStyle.HeaderStyle.Height = 22
        Me.data.ThemeStyle.ReadOnly = False
        Me.data.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.data.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.data.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.data.ThemeStyle.RowsStyle.Height = 28
        Me.data.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.data.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ID
        '
        Me.ID.HeaderText = "EVENT"
        Me.ID.MinimumWidth = 8
        Me.ID.Name = "ID"
        '
        'Student
        '
        Me.Student.HeaderText = "DATE"
        Me.Student.MinimumWidth = 8
        Me.Student.Name = "Student"
        '
        'Column1
        '
        Me.Column1.HeaderText = "VENUE"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "DEPT"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        '
        'adminHome
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(995, 625)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2ControlBox3)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnacc)
        Me.Controls.Add(Me.btnreport)
        Me.Controls.Add(Me.btnevent)
        Me.Controls.Add(Me.btnstudent)
        Me.Controls.Add(Me.btnattendance)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.pnlhome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminHome"
        Me.pnlhome.ResumeLayout(False)
        Me.pnlhome.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnacc As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnreport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnevent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnstudent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnattendance As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnhome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnlogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents pnlhome As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnexit As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents timedate As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents lblwelcome As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents data As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Student As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
