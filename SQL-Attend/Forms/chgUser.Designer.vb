<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class chgUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(chgUser))
        Me.fore = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Mag = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.TopPan = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Max = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Min = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Cool = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnChange = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.TopPan.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mag
        '
        Me.Mag.DockIndicatorTransparencyValue = 0.6R
        Me.Mag.UseTransparentDrag = True
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'TopPan
        '
        Me.TopPan.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.TopPan.Controls.Add(Me.Label2)
        Me.TopPan.Controls.Add(Me.Guna2PictureBox1)
        Me.TopPan.Controls.Add(Me.Max)
        Me.TopPan.Controls.Add(Me.Min)
        Me.TopPan.Controls.Add(Me.Cool)
        Me.TopPan.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPan.Location = New System.Drawing.Point(0, 0)
        Me.TopPan.Name = "TopPan"
        Me.TopPan.Size = New System.Drawing.Size(524, 38)
        Me.TopPan.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(53, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "AttendBase"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.SQL_Attend.My.Resources.Resources.data_analysis_icon_icons_com_52842
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.InitialImage = Global.SQL_Attend.My.Resources.Resources.data_analysis_icon_icons_com_52842__1_
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(19, 7)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(27, 22)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 10
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Max
        '
        Me.Max.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Max.Animated = True
        Me.Max.BackColor = System.Drawing.Color.Transparent
        Me.Max.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Max.FillColor = System.Drawing.Color.Transparent
        Me.Max.IconColor = System.Drawing.Color.White
        Me.Max.Location = New System.Drawing.Point(452, 3)
        Me.Max.Name = "Max"
        Me.Max.Size = New System.Drawing.Size(27, 31)
        Me.Max.TabIndex = 9
        '
        'Min
        '
        Me.Min.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Min.Animated = True
        Me.Min.BackColor = System.Drawing.Color.Transparent
        Me.Min.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Min.FillColor = System.Drawing.Color.Transparent
        Me.Min.IconColor = System.Drawing.Color.White
        Me.Min.Location = New System.Drawing.Point(419, 3)
        Me.Min.Name = "Min"
        Me.Min.Size = New System.Drawing.Size(27, 31)
        Me.Min.TabIndex = 8
        '
        'Cool
        '
        Me.Cool.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cool.Animated = True
        Me.Cool.BackColor = System.Drawing.Color.Transparent
        Me.Cool.FillColor = System.Drawing.Color.Transparent
        Me.Cool.IconColor = System.Drawing.Color.White
        Me.Cool.Location = New System.Drawing.Point(485, 3)
        Me.Cool.Name = "Cool"
        Me.Cool.Size = New System.Drawing.Size(27, 31)
        Me.Cool.TabIndex = 7
        '
        'txtName
        '
        Me.txtName.BorderRadius = 18
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.DefaultText = "Change Username"
        Me.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(244, 130)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PlaceholderText = ""
        Me.txtName.SelectedText = ""
        Me.txtName.Size = New System.Drawing.Size(229, 48)
        Me.txtName.TabIndex = 0
        '
        'btnChange
        '
        Me.btnChange.BorderRadius = 18
        Me.btnChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnChange.FillColor = System.Drawing.Color.Aquamarine
        Me.btnChange.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnChange.ForeColor = System.Drawing.Color.Black
        Me.btnChange.Location = New System.Drawing.Point(266, 196)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(180, 45)
        Me.btnChange.TabIndex = 1
        Me.btnChange.Text = "Change Username"
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 18
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.FillColor = System.Drawing.Color.Salmon
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(280, 260)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(153, 40)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = Global.SQL_Attend.My.Resources.Resources._40_104848
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(29, 130)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(192, 170)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 11
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'chgUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(524, 402)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.TopPan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "chgUser"
        Me.Text = "Change User"
        Me.TopPan.ResumeLayout(False)
        Me.TopPan.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents fore As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Mag As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TopPan As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Max As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Min As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Cool As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnChange As Guna.UI2.WinForms.Guna2Button
End Class
