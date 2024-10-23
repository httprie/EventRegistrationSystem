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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.btnlogout = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.pnlhome = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btnexit = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnacc = New Guna.UI2.WinForms.Guna2Button()
        Me.btnreport = New Guna.UI2.WinForms.Guna2Button()
        Me.btnevent = New Guna.UI2.WinForms.Guna2Button()
        Me.btnstudent = New Guna.UI2.WinForms.Guna2Button()
        Me.btnattendance = New Guna.UI2.WinForms.Guna2Button()
        Me.btnhome = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlhome.Location = New System.Drawing.Point(245, 0)
        Me.pnlhome.Name = "pnlhome"
        Me.pnlhome.Size = New System.Drawing.Size(753, 628)
        Me.pnlhome.TabIndex = 16
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
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Timer1 As Timer
End Class
