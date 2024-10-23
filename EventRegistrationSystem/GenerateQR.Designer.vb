<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerateQR
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btngenerate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnsave = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtcourse = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtyrsec = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtstudID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnsendEmail = New Guna.UI2.WinForms.Guna2Button()
        Me.txtemail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.timedate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.QRCode = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnclear = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.QRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(111, 461)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Student ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(136, 325)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(80, 415)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Year and Section:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(129, 368)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Course:"
        '
        'btngenerate
        '
        Me.btngenerate.AutoRoundedCorners = True
        Me.btngenerate.BorderRadius = 16
        Me.btngenerate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btngenerate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btngenerate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btngenerate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btngenerate.FillColor = System.Drawing.Color.White
        Me.btngenerate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngenerate.ForeColor = System.Drawing.Color.Black
        Me.btngenerate.Location = New System.Drawing.Point(131, 564)
        Me.btngenerate.Name = "btngenerate"
        Me.btngenerate.Size = New System.Drawing.Size(137, 35)
        Me.btngenerate.TabIndex = 13
        Me.btngenerate.Text = "Generate"
        '
        'btnsave
        '
        Me.btnsave.AutoRoundedCorners = True
        Me.btnsave.BorderRadius = 16
        Me.btnsave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnsave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnsave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnsave.FillColor = System.Drawing.Color.White
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Black
        Me.btnsave.Location = New System.Drawing.Point(312, 564)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(137, 35)
        Me.btnsave.TabIndex = 14
        Me.btnsave.Text = "Save"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(139, 512)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 25)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Email:"
        '
        'txtname
        '
        Me.txtname.AutoRoundedCorners = True
        Me.txtname.BorderRadius = 12
        Me.txtname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtname.DefaultText = ""
        Me.txtname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtname.Location = New System.Drawing.Point(184, 318)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtname.Name = "txtname"
        Me.txtname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtname.PlaceholderText = ""
        Me.txtname.SelectedText = ""
        Me.txtname.Size = New System.Drawing.Size(442, 27)
        Me.txtname.TabIndex = 17
        '
        'txtcourse
        '
        Me.txtcourse.AutoRoundedCorners = True
        Me.txtcourse.BorderRadius = 12
        Me.txtcourse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcourse.DefaultText = ""
        Me.txtcourse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcourse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcourse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtcourse.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcourse.Location = New System.Drawing.Point(184, 364)
        Me.txtcourse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcourse.Name = "txtcourse"
        Me.txtcourse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcourse.PlaceholderText = ""
        Me.txtcourse.SelectedText = ""
        Me.txtcourse.Size = New System.Drawing.Size(442, 27)
        Me.txtcourse.TabIndex = 18
        '
        'txtyrsec
        '
        Me.txtyrsec.AutoRoundedCorners = True
        Me.txtyrsec.BorderRadius = 12
        Me.txtyrsec.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtyrsec.DefaultText = ""
        Me.txtyrsec.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtyrsec.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtyrsec.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtyrsec.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtyrsec.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtyrsec.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtyrsec.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtyrsec.Location = New System.Drawing.Point(184, 411)
        Me.txtyrsec.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtyrsec.Name = "txtyrsec"
        Me.txtyrsec.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtyrsec.PlaceholderText = ""
        Me.txtyrsec.SelectedText = ""
        Me.txtyrsec.Size = New System.Drawing.Size(442, 27)
        Me.txtyrsec.TabIndex = 19
        '
        'txtstudID
        '
        Me.txtstudID.AutoRoundedCorners = True
        Me.txtstudID.BorderRadius = 12
        Me.txtstudID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtstudID.DefaultText = ""
        Me.txtstudID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtstudID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtstudID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtstudID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtstudID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtstudID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtstudID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtstudID.Location = New System.Drawing.Point(184, 457)
        Me.txtstudID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtstudID.Name = "txtstudID"
        Me.txtstudID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtstudID.PlaceholderText = ""
        Me.txtstudID.SelectedText = ""
        Me.txtstudID.Size = New System.Drawing.Size(442, 27)
        Me.txtstudID.TabIndex = 20
        '
        'btnsendEmail
        '
        Me.btnsendEmail.AutoRoundedCorners = True
        Me.btnsendEmail.BorderRadius = 16
        Me.btnsendEmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnsendEmail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnsendEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsendEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnsendEmail.FillColor = System.Drawing.Color.White
        Me.btnsendEmail.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsendEmail.ForeColor = System.Drawing.Color.Black
        Me.btnsendEmail.Location = New System.Drawing.Point(492, 564)
        Me.btnsendEmail.Name = "btnsendEmail"
        Me.btnsendEmail.Size = New System.Drawing.Size(137, 35)
        Me.btnsendEmail.TabIndex = 22
        Me.btnsendEmail.Text = "Send"
        '
        'txtemail
        '
        Me.txtemail.AutoRoundedCorners = True
        Me.txtemail.BorderRadius = 12
        Me.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtemail.DefaultText = ""
        Me.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtemail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtemail.Location = New System.Drawing.Point(184, 504)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtemail.PlaceholderText = ""
        Me.txtemail.SelectedText = ""
        Me.txtemail.Size = New System.Drawing.Size(442, 27)
        Me.txtemail.TabIndex = 23
        '
        'timedate
        '
        Me.timedate.AutoSize = True
        Me.timedate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timedate.ForeColor = System.Drawing.Color.White
        Me.timedate.Location = New System.Drawing.Point(29, 9)
        Me.timedate.Name = "timedate"
        Me.timedate.Size = New System.Drawing.Size(127, 25)
        Me.timedate.TabIndex = 24
        Me.timedate.Text = "                       "
        '
        'Timer1
        '
        '
        'QRCode
        '
        Me.QRCode.ImageRotate = 0!
        Me.QRCode.Location = New System.Drawing.Point(116, 38)
        Me.QRCode.Name = "QRCode"
        Me.QRCode.Size = New System.Drawing.Size(510, 235)
        Me.QRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.QRCode.TabIndex = 12
        Me.QRCode.TabStop = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.Transparent
        Me.btnclear.BorderColor = System.Drawing.Color.Transparent
        Me.btnclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnclear.FillColor = System.Drawing.Color.Transparent
        Me.btnclear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.White
        Me.btnclear.Location = New System.Drawing.Point(522, 279)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(137, 35)
        Me.btnclear.TabIndex = 25
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseTransparentBackground = True
        '
        'GenerateQR
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(793, 629)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.timedate)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.btnsendEmail)
        Me.Controls.Add(Me.txtstudID)
        Me.Controls.Add(Me.txtyrsec)
        Me.Controls.Add(Me.txtcourse)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btngenerate)
        Me.Controls.Add(Me.QRCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GenerateQR"
        Me.Text = "generate"
        CType(Me.QRCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents QRCode As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btngenerate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnsave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents txtstudID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtyrsec As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtcourse As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnsendEmail As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtemail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents timedate As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnclear As Guna.UI2.WinForms.Guna2Button
End Class
