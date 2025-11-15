<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Remov_Stud
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Remov_Stud))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.TopPan = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Max = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Min = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Cool = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.rbUsername = New System.Windows.Forms.RadioButton()
        Me.rbTNumber = New System.Windows.Forms.RadioButton()
        Me.rbTagID = New System.Windows.Forms.RadioButton()
        Me.txtSum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnRemove = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancle = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TopPan.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.TopPan.Size = New System.Drawing.Size(617, 38)
        Me.TopPan.TabIndex = 8
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
        Me.Guna2PictureBox1.Image = Global.New_Attend_RFID.My.Resources.Resources.data_analysis_icon_icons_com_52842
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.InitialImage = Global.New_Attend_RFID.My.Resources.Resources.data_analysis_icon_icons_com_52842__1_
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
        Me.Max.Location = New System.Drawing.Point(545, 3)
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
        Me.Min.Location = New System.Drawing.Point(512, 3)
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
        Me.Cool.Location = New System.Drawing.Point(578, 3)
        Me.Cool.Name = "Cool"
        Me.Cool.Size = New System.Drawing.Size(27, 31)
        Me.Cool.TabIndex = 7
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.TopPan
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderRadius = 21
        Me.Guna2GroupBox1.Controls.Add(Me.rbUsername)
        Me.Guna2GroupBox1.Controls.Add(Me.rbTNumber)
        Me.Guna2GroupBox1.Controls.Add(Me.rbTagID)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(57, 93)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(157, 198)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Select Method"
        '
        'rbUsername
        '
        Me.rbUsername.AutoSize = True
        Me.rbUsername.BackColor = System.Drawing.Color.Transparent
        Me.rbUsername.Location = New System.Drawing.Point(20, 104)
        Me.rbUsername.Name = "rbUsername"
        Me.rbUsername.Size = New System.Drawing.Size(70, 24)
        Me.rbUsername.TabIndex = 2
        Me.rbUsername.TabStop = True
        Me.rbUsername.Text = "Name"
        Me.rbUsername.UseVisualStyleBackColor = False
        '
        'rbTNumber
        '
        Me.rbTNumber.AutoSize = True
        Me.rbTNumber.BackColor = System.Drawing.Color.Transparent
        Me.rbTNumber.Location = New System.Drawing.Point(20, 143)
        Me.rbTNumber.Name = "rbTNumber"
        Me.rbTNumber.Size = New System.Drawing.Size(98, 24)
        Me.rbTNumber.TabIndex = 3
        Me.rbTNumber.TabStop = True
        Me.rbTNumber.Text = "T-Number"
        Me.rbTNumber.UseVisualStyleBackColor = False
        '
        'rbTagID
        '
        Me.rbTagID.AutoSize = True
        Me.rbTagID.BackColor = System.Drawing.Color.Transparent
        Me.rbTagID.Location = New System.Drawing.Point(20, 65)
        Me.rbTagID.Name = "rbTagID"
        Me.rbTagID.Size = New System.Drawing.Size(74, 24)
        Me.rbTagID.TabIndex = 1
        Me.rbTagID.TabStop = True
        Me.rbTagID.Text = "Tag-ID"
        Me.rbTagID.UseVisualStyleBackColor = False
        '
        'txtSum
        '
        Me.txtSum.BorderRadius = 21
        Me.txtSum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSum.DefaultText = ""
        Me.txtSum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSum.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSum.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSum.ForeColor = System.Drawing.Color.Black
        Me.txtSum.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSum.Location = New System.Drawing.Point(271, 134)
        Me.txtSum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSum.Name = "txtSum"
        Me.txtSum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSum.PlaceholderText = ""
        Me.txtSum.SelectedText = ""
        Me.txtSum.Size = New System.Drawing.Size(229, 48)
        Me.txtSum.TabIndex = 4
        '
        'btnRemove
        '
        Me.btnRemove.BorderRadius = 20
        Me.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRemove.FillColor = System.Drawing.Color.Salmon
        Me.btnRemove.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.Location = New System.Drawing.Point(305, 200)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(161, 45)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "Remove"
        '
        'btnCancle
        '
        Me.btnCancle.BorderRadius = 20
        Me.btnCancle.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancle.FillColor = System.Drawing.Color.Aquamarine
        Me.btnCancle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancle.ForeColor = System.Drawing.Color.Black
        Me.btnCancle.Location = New System.Drawing.Point(317, 251)
        Me.btnCancle.Name = "btnCancle"
        Me.btnCancle.Size = New System.Drawing.Size(136, 36)
        Me.btnCancle.TabIndex = 6
        Me.btnCancle.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(315, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 29)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Student Info"
        '
        'Remov_Stud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(617, 346)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancle)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.txtSum)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.TopPan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Remov_Stud"
        Me.Text = "Remov_Stud"
        Me.TopPan.ResumeLayout(False)
        Me.TopPan.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents TopPan As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Max As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Min As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Cool As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btnCancle As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRemove As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents rbUsername As RadioButton
    Friend WithEvents rbTNumber As RadioButton
    Friend WithEvents rbTagID As RadioButton
    Friend WithEvents Label1 As Label
End Class
