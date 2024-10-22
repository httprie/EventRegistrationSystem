<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmailForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnattach = New System.Windows.Forms.Button()
        Me.lblmessage = New System.Windows.Forms.Label()
        Me.txtmessage = New System.Windows.Forms.TextBox()
        Me.btnsend = New System.Windows.Forms.Button()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox4 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblfilename = New System.Windows.Forms.Label()
        Me.lblto = New System.Windows.Forms.Label()
        Me.lblsubject = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(66, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(37, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Subject:"
        '
        'btnattach
        '
        Me.btnattach.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnattach.Location = New System.Drawing.Point(40, 98)
        Me.btnattach.Margin = New System.Windows.Forms.Padding(2)
        Me.btnattach.Name = "btnattach"
        Me.btnattach.Size = New System.Drawing.Size(74, 23)
        Me.btnattach.TabIndex = 2
        Me.btnattach.Text = "Attach File"
        Me.btnattach.UseVisualStyleBackColor = True
        '
        'lblmessage
        '
        Me.lblmessage.AutoSize = True
        Me.lblmessage.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmessage.ForeColor = System.Drawing.Color.White
        Me.lblmessage.Location = New System.Drawing.Point(37, 130)
        Me.lblmessage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblmessage.Name = "lblmessage"
        Me.lblmessage.Size = New System.Drawing.Size(53, 15)
        Me.lblmessage.TabIndex = 3
        Me.lblmessage.Text = "Message"
        '
        'txtmessage
        '
        Me.txtmessage.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmessage.Location = New System.Drawing.Point(105, 130)
        Me.txtmessage.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmessage.Multiline = True
        Me.txtmessage.Name = "txtmessage"
        Me.txtmessage.Size = New System.Drawing.Size(332, 145)
        Me.txtmessage.TabIndex = 6
        '
        'btnsend
        '
        Me.btnsend.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsend.Location = New System.Drawing.Point(373, 295)
        Me.btnsend.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsend.Name = "btnsend"
        Me.btnsend.Size = New System.Drawing.Size(63, 24)
        Me.btnsend.TabIndex = 7
        Me.btnsend.Text = "Send"
        Me.btnsend.UseVisualStyleBackColor = True
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.DimGray
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(409, 8)
        Me.Guna2ControlBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(27, 16)
        Me.Guna2ControlBox3.TabIndex = 15
        '
        'Guna2ControlBox4
        '
        Me.Guna2ControlBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox4.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox4.IconColor = System.Drawing.Color.DimGray
        Me.Guna2ControlBox4.Location = New System.Drawing.Point(435, 8)
        Me.Guna2ControlBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2ControlBox4.Name = "Guna2ControlBox4"
        Me.Guna2ControlBox4.Size = New System.Drawing.Size(29, 16)
        Me.Guna2ControlBox4.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 8)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Email Attachment"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblfilename
        '
        Me.lblfilename.AutoSize = True
        Me.lblfilename.ForeColor = System.Drawing.Color.White
        Me.lblfilename.Location = New System.Drawing.Point(118, 104)
        Me.lblfilename.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfilename.Name = "lblfilename"
        Me.lblfilename.Size = New System.Drawing.Size(52, 13)
        Me.lblfilename.TabIndex = 17
        Me.lblfilename.Text = "               "
        '
        'lblto
        '
        Me.lblto.AutoSize = True
        Me.lblto.BackColor = System.Drawing.Color.White
        Me.lblto.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblto.Location = New System.Drawing.Point(99, 34)
        Me.lblto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblto.Name = "lblto"
        Me.lblto.Size = New System.Drawing.Size(301, 15)
        Me.lblto.TabIndex = 18
        Me.lblto.Text = "                                                                                 " &
    "                 "
        '
        'lblsubject
        '
        Me.lblsubject.AutoSize = True
        Me.lblsubject.BackColor = System.Drawing.Color.White
        Me.lblsubject.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubject.Location = New System.Drawing.Point(99, 69)
        Me.lblsubject.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblsubject.Name = "lblsubject"
        Me.lblsubject.Size = New System.Drawing.Size(301, 15)
        Me.lblsubject.TabIndex = 19
        Me.lblsubject.Text = "                                                                                 " &
    "                 "
        '
        'EmailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(475, 343)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblsubject)
        Me.Controls.Add(Me.lblto)
        Me.Controls.Add(Me.lblfilename)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Guna2ControlBox3)
        Me.Controls.Add(Me.Guna2ControlBox4)
        Me.Controls.Add(Me.btnsend)
        Me.Controls.Add(Me.txtmessage)
        Me.Controls.Add(Me.lblmessage)
        Me.Controls.Add(Me.btnattach)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "EmailForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmailForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnsend As Button
    Friend WithEvents txtmessage As TextBox
    Friend WithEvents lblmessage As Label
    Friend WithEvents btnattach As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox4 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label4 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lblfilename As Label
    Friend WithEvents lblsubject As Label
    Friend WithEvents lblto As Label
End Class
