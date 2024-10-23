<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class attendance
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.btnstartstop = New Guna.UI2.WinForms.Guna2Button()
        Me.btnscan = New Guna.UI2.WinForms.Guna2Button()
        Me.data = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Student = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timeout = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pbwebcam = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timedate = New System.Windows.Forms.Label()
        CType(Me.data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbwebcam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnstartstop
        '
        Me.btnstartstop.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnstartstop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnstartstop.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnstartstop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnstartstop.FillColor = System.Drawing.Color.White
        Me.btnstartstop.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnstartstop.ForeColor = System.Drawing.Color.Black
        Me.btnstartstop.Location = New System.Drawing.Point(216, 360)
        Me.btnstartstop.Name = "btnstartstop"
        Me.btnstartstop.Size = New System.Drawing.Size(120, 43)
        Me.btnstartstop.TabIndex = 17
        Me.btnstartstop.Text = "Start"
        '
        'btnscan
        '
        Me.btnscan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnscan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnscan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnscan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnscan.FillColor = System.Drawing.Color.White
        Me.btnscan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnscan.ForeColor = System.Drawing.Color.Black
        Me.btnscan.Location = New System.Drawing.Point(393, 360)
        Me.btnscan.Name = "btnscan"
        Me.btnscan.Size = New System.Drawing.Size(120, 43)
        Me.btnscan.TabIndex = 18
        Me.btnscan.Text = "Scan"
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
        Me.data.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Student, Me.Column1, Me.Column2, Me.Column3, Me.timeout})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data.DefaultCellStyle = DataGridViewCellStyle3
        Me.data.GridColor = System.Drawing.Color.Gainsboro
        Me.data.Location = New System.Drawing.Point(22, 482)
        Me.data.Name = "data"
        Me.data.RowHeadersVisible = False
        Me.data.RowHeadersWidth = 62
        Me.data.RowTemplate.Height = 28
        Me.data.Size = New System.Drawing.Size(733, 150)
        Me.data.TabIndex = 20
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
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 8
        Me.ID.Name = "ID"
        '
        'Student
        '
        Me.Student.HeaderText = "Student"
        Me.Student.MinimumWidth = 8
        Me.Student.Name = "Student"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Year & Section"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Date"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Time In"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        '
        'timeout
        '
        Me.timeout.HeaderText = "Time Out"
        Me.timeout.MinimumWidth = 8
        Me.timeout.Name = "timeout"
        '
        'pbwebcam
        '
        Me.pbwebcam.ImageRotate = 0!
        Me.pbwebcam.Location = New System.Drawing.Point(114, 63)
        Me.pbwebcam.Name = "pbwebcam"
        Me.pbwebcam.Size = New System.Drawing.Size(508, 279)
        Me.pbwebcam.TabIndex = 16
        Me.pbwebcam.TabStop = False
        '
        'Timer1
        '
        '
        'timedate
        '
        Me.timedate.AutoSize = True
        Me.timedate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timedate.ForeColor = System.Drawing.Color.White
        Me.timedate.Location = New System.Drawing.Point(31, 9)
        Me.timedate.Name = "timedate"
        Me.timedate.Size = New System.Drawing.Size(101, 20)
        Me.timedate.TabIndex = 25
        Me.timedate.Text = "                       "
        '
        'attendance
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 700)
        Me.Controls.Add(Me.timedate)
        Me.Controls.Add(Me.data)
        Me.Controls.Add(Me.btnscan)
        Me.Controls.Add(Me.btnstartstop)
        Me.Controls.Add(Me.pbwebcam)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "attendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "attendance"
        CType(Me.data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbwebcam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pbwebcam As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnstartstop As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnscan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents data As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents timedate As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Student As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents timeout As DataGridViewTextBoxColumn
End Class
