﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAccount
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox4 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtrole = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtpwd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtfname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtuname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnaddsave = New System.Windows.Forms.Button()
        Me.btnshowpwd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.DimGray
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(409, 11)
        Me.Guna2ControlBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(27, 16)
        Me.Guna2ControlBox3.TabIndex = 17
        '
        'Guna2ControlBox4
        '
        Me.Guna2ControlBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox4.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox4.IconColor = System.Drawing.Color.DimGray
        Me.Guna2ControlBox4.Location = New System.Drawing.Point(435, 11)
        Me.Guna2ControlBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2ControlBox4.Name = "Guna2ControlBox4"
        Me.Guna2ControlBox4.Size = New System.Drawing.Size(29, 16)
        Me.Guna2ControlBox4.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(11, 12)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Add New Account"
        '
        'txtrole
        '
        Me.txtrole.AutoRoundedCorners = True
        Me.txtrole.BorderRadius = 9
        Me.txtrole.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtrole.DefaultText = ""
        Me.txtrole.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtrole.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtrole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtrole.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtrole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtrole.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtrole.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtrole.Location = New System.Drawing.Point(120, 218)
        Me.txtrole.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtrole.Name = "txtrole"
        Me.txtrole.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtrole.PlaceholderText = ""
        Me.txtrole.SelectedText = ""
        Me.txtrole.Size = New System.Drawing.Size(307, 21)
        Me.txtrole.TabIndex = 33
        '
        'txtpwd
        '
        Me.txtpwd.AutoRoundedCorners = True
        Me.txtpwd.BorderRadius = 9
        Me.txtpwd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpwd.DefaultText = ""
        Me.txtpwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpwd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtpwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpwd.Location = New System.Drawing.Point(120, 171)
        Me.txtpwd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpwd.PlaceholderText = ""
        Me.txtpwd.SelectedText = ""
        Me.txtpwd.Size = New System.Drawing.Size(307, 21)
        Me.txtpwd.TabIndex = 32
        '
        'txtfname
        '
        Me.txtfname.AutoRoundedCorners = True
        Me.txtfname.BorderRadius = 9
        Me.txtfname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfname.DefaultText = ""
        Me.txtfname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtfname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtfname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtfname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfname.Location = New System.Drawing.Point(120, 125)
        Me.txtfname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfname.PlaceholderText = ""
        Me.txtfname.SelectedText = ""
        Me.txtfname.Size = New System.Drawing.Size(307, 21)
        Me.txtfname.TabIndex = 31
        '
        'txtuname
        '
        Me.txtuname.AutoRoundedCorners = True
        Me.txtuname.BorderRadius = 9
        Me.txtuname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtuname.DefaultText = ""
        Me.txtuname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtuname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtuname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtuname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtuname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtuname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtuname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtuname.Location = New System.Drawing.Point(120, 78)
        Me.txtuname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtuname.PlaceholderText = ""
        Me.txtuname.SelectedText = ""
        Me.txtuname.Size = New System.Drawing.Size(307, 21)
        Me.txtuname.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(71, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 15)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Role:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(41, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(40, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Full Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(44, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 15)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Password:"
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(308, 266)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(63, 24)
        Me.btnclear.TabIndex = 34
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnaddsave
        '
        Me.btnaddsave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddsave.Location = New System.Drawing.Point(375, 266)
        Me.btnaddsave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnaddsave.Name = "btnaddsave"
        Me.btnaddsave.Size = New System.Drawing.Size(63, 24)
        Me.btnaddsave.TabIndex = 35
        Me.btnaddsave.Text = "Add"
        Me.btnaddsave.UseVisualStyleBackColor = True
        '
        'btnshowpwd
        '
        Me.btnshowpwd.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshowpwd.Location = New System.Drawing.Point(200, 266)
        Me.btnshowpwd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnshowpwd.Name = "btnshowpwd"
        Me.btnshowpwd.Size = New System.Drawing.Size(104, 24)
        Me.btnshowpwd.TabIndex = 36
        Me.btnshowpwd.Text = "Show Password"
        Me.btnshowpwd.UseVisualStyleBackColor = True
        '
        'AddAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(475, 343)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnshowpwd)
        Me.Controls.Add(Me.btnaddsave)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.txtrole)
        Me.Controls.Add(Me.txtpwd)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.txtuname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Guna2ControlBox3)
        Me.Controls.Add(Me.Guna2ControlBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox4 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtrole As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtpwd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtfname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtuname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnaddsave As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnshowpwd As Button
End Class