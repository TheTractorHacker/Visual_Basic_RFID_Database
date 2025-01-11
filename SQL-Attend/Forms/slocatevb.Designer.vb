<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class slocatevb
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
        Me.txtip = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblIP = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblUser = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblPass = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblData = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtip
        '
        Me.txtip.Location = New System.Drawing.Point(409, 26)
        Me.txtip.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtip.Name = "txtip"
        Me.txtip.Size = New System.Drawing.Size(148, 30)
        Me.txtip.TabIndex = 0
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(409, 95)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(148, 30)
        Me.txtUser.TabIndex = 1
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(409, 175)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(148, 30)
        Me.txtPass.TabIndex = 2
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(409, 251)
        Me.txtData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(148, 30)
        Me.txtData.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(304, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Server IP:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(304, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(304, 178)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(304, 256)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Database:"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Aquamarine
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(322, 322)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(235, 55)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Change"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.lblData)
        Me.Guna2GroupBox1.Controls.Add(Me.lblPass)
        Me.Guna2GroupBox1.Controls.Add(Me.lblUser)
        Me.Guna2GroupBox1.Controls.Add(Me.lblIP)
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.Silver
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(3, 12)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(276, 390)
        Me.Guna2GroupBox1.TabIndex = 9
        Me.Guna2GroupBox1.Text = "Current Settings"
        '
        'lblIP
        '
        Me.lblIP.BackColor = System.Drawing.Color.Transparent
        Me.lblIP.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIP.Location = New System.Drawing.Point(24, 58)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(83, 30)
        Me.lblIP.TabIndex = 0
        Me.lblIP.Text = "Server IP:"
        '
        'lblUser
        '
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(24, 104)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(94, 30)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "Username:"
        '
        'lblPass
        '
        Me.lblPass.BackColor = System.Drawing.Color.Transparent
        Me.lblPass.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(24, 149)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(89, 30)
        Me.lblPass.TabIndex = 2
        Me.lblPass.Text = "Password:"
        '
        'lblData
        '
        Me.lblData.BackColor = System.Drawing.Color.Transparent
        Me.lblData.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.Location = New System.Drawing.Point(24, 199)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(88, 30)
        Me.lblData.TabIndex = 3
        Me.lblData.Text = "Database:"
        '
        'slocatevb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(648, 432)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "slocatevb"
        Me.Text = "SQL Server"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtip As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtData As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblData As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblPass As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblUser As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblIP As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
