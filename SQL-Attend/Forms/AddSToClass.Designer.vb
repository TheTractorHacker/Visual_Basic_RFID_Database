<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSToClass
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
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.cbClass = New System.Windows.Forms.CheckedListBox()
        Me.txtTNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnADDS = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.cbClass)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(25, 11)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(307, 419)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Classes"
        '
        'cbClass
        '
        Me.cbClass.CheckOnClick = True
        Me.cbClass.FormattingEnabled = True
        Me.cbClass.Location = New System.Drawing.Point(19, 47)
        Me.cbClass.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbClass.Name = "cbClass"
        Me.cbClass.ScrollAlwaysVisible = True
        Me.cbClass.Size = New System.Drawing.Size(261, 340)
        Me.cbClass.TabIndex = 0
        '
        'txtTNumber
        '
        Me.txtTNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTNumber.DefaultText = ""
        Me.txtTNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTNumber.ForeColor = System.Drawing.Color.Black
        Me.txtTNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTNumber.Location = New System.Drawing.Point(391, 159)
        Me.txtTNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTNumber.MaxLength = 9
        Me.txtTNumber.Name = "txtTNumber"
        Me.txtTNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTNumber.PlaceholderText = ""
        Me.txtTNumber.SelectedText = ""
        Me.txtTNumber.Size = New System.Drawing.Size(318, 66)
        Me.txtTNumber.TabIndex = 1
        '
        'btnADDS
        '
        Me.btnADDS.BackColor = System.Drawing.Color.Blue
        Me.btnADDS.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnADDS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnADDS.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnADDS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnADDS.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnADDS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnADDS.ForeColor = System.Drawing.Color.Black
        Me.btnADDS.Location = New System.Drawing.Point(445, 250)
        Me.btnADDS.Name = "btnADDS"
        Me.btnADDS.Size = New System.Drawing.Size(200, 49)
        Me.btnADDS.TabIndex = 2
        Me.btnADDS.Text = "Add Student"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(407, 120)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(302, 31)
        Me.Guna2HtmlLabel1.TabIndex = 3
        Me.Guna2HtmlLabel1.Text = "Enter Student ID (TNumber)"
        '
        'AddSToClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(851, 441)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.btnADDS)
        Me.Controls.Add(Me.txtTNumber)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "AddSToClass"
        Me.Text = "Add Student to Class"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtTNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnADDS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cbClass As CheckedListBox
End Class
