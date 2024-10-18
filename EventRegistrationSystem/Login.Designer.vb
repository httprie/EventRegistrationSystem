<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.btnShow = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.lblremember = New System.Windows.Forms.Label()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.lbluserlogin = New System.Windows.Forms.Label()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.txtpw = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtun = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2ShadowForm1
        '
        Me.Guna2ShadowForm1.TargetForm = Me
        '
        'btnShow
        '
        Me.btnShow.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnShow.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnShow.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.btnShow.CheckedState.InnerColor = System.Drawing.Color.White
        Me.btnShow.Location = New System.Drawing.Point(584, 315)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(37, 18)
        Me.btnShow.TabIndex = 5
        Me.btnShow.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnShow.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnShow.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.btnShow.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'lblremember
        '
        Me.lblremember.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblremember.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblremember.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblremember.Location = New System.Drawing.Point(627, 308)
        Me.lblremember.Name = "lblremember"
        Me.lblremember.Size = New System.Drawing.Size(163, 30)
        Me.lblremember.TabIndex = 6
        Me.lblremember.Text = "Show Password"
        '
        'btnLogin
        '
        Me.btnLogin.Animated = True
        Me.btnLogin.AutoRoundedCorners = True
        Me.btnLogin.BorderRadius = 19
        Me.btnLogin.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor2 = System.Drawing.Color.MediumBlue
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(632, 369)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(223, 41)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "LOGIN"
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.DimGray
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(952, 13)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(31, 28)
        Me.Guna2ControlBox1.TabIndex = 8
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.DimGray
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(924, 13)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(31, 28)
        Me.Guna2ControlBox2.TabIndex = 9
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'lbluserlogin
        '
        Me.lbluserlogin.AutoSize = True
        Me.lbluserlogin.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluserlogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbluserlogin.Location = New System.Drawing.Point(653, 111)
        Me.lbluserlogin.Name = "lbluserlogin"
        Me.lbluserlogin.Size = New System.Drawing.Size(129, 31)
        Me.lbluserlogin.TabIndex = 10
        Me.lbluserlogin.Text = "User Login"
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'txtpw
        '
        Me.txtpw.Animated = True
        Me.txtpw.BorderRadius = 8
        Me.txtpw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpw.DefaultText = ""
        Me.txtpw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpw.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpw.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.txtpw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpw.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtpw.ForeColor = System.Drawing.Color.Black
        Me.txtpw.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpw.IconLeft = Global.EventRegistrationSystem.My.Resources.Resources.icons8_password_208
        Me.txtpw.Location = New System.Drawing.Point(584, 253)
        Me.txtpw.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtpw.Name = "txtpw"
        Me.txtpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpw.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtpw.PlaceholderText = "Password"
        Me.txtpw.SelectedText = ""
        Me.txtpw.Size = New System.Drawing.Size(320, 40)
        Me.txtpw.TabIndex = 4
        '
        'txtun
        '
        Me.txtun.Animated = True
        Me.txtun.BorderRadius = 8
        Me.txtun.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtun.DefaultText = ""
        Me.txtun.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtun.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtun.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtun.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.txtun.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtun.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtun.ForeColor = System.Drawing.Color.Black
        Me.txtun.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtun.IconLeft = Global.EventRegistrationSystem.My.Resources.Resources._429826810_776452404362496_5839685215586209088_n
        Me.txtun.Location = New System.Drawing.Point(584, 180)
        Me.txtun.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtun.Name = "txtun"
        Me.txtun.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtun.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtun.PlaceholderText = "Username"
        Me.txtun.SelectedText = ""
        Me.txtun.Size = New System.Drawing.Size(320, 40)
        Me.txtun.TabIndex = 3
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.EventRegistrationSystem.My.Resources.Resources.login
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-4, -3)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(461, 632)
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(995, 625)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbluserlogin)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblremember)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.txtpw)
        Me.Controls.Add(Me.txtun)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Event Registration System"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblremember As Label
    Friend WithEvents btnShow As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents txtpw As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtun As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbluserlogin As Label
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
End Class
