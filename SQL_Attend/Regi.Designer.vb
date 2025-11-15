<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Regi
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
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtTag = New System.Windows.Forms.TextBox()
        Me.txtTnum = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.TopPan = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Max = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Min = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Cool = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Drag_Control = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.tsMulti = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TopPan.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(21, 49)
        Me.txtFirst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(112, 30)
        Me.txtFirst.TabIndex = 1
        Me.txtFirst.Text = "First"
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(162, 49)
        Me.txtLast.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(112, 30)
        Me.txtLast.TabIndex = 2
        Me.txtLast.Text = "Last"
        '
        'txtTag
        '
        Me.txtTag.Location = New System.Drawing.Point(43, 50)
        Me.txtTag.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTag.Name = "txtTag"
        Me.txtTag.Size = New System.Drawing.Size(112, 30)
        Me.txtTag.TabIndex = 3
        Me.txtTag.Text = "Tag-ID"
        '
        'txtTnum
        '
        Me.txtTnum.Location = New System.Drawing.Point(29, 51)
        Me.txtTnum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTnum.Name = "txtTnum"
        Me.txtTnum.Size = New System.Drawing.Size(112, 30)
        Me.txtTnum.TabIndex = 4
        Me.txtTnum.Text = "T-Number"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtLast)
        Me.GroupBox1.Controls.Add(Me.txtFirst)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(125, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 100)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtTnum)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(67, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 101)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Personal Info"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtTag)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(283, 176)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SmartCard"
        '
        'btnAdd
        '
        Me.btnAdd.Animated = True
        Me.btnAdd.BorderRadius = 21
        Me.btnAdd.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.FillColor = System.Drawing.Color.LightGreen
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(95, 319)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.BorderRadius = 26
        Me.btnAdd.Size = New System.Drawing.Size(180, 45)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 21
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Salmon
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.Location = New System.Drawing.Point(281, 319)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.BorderRadius = 26
        Me.Guna2Button1.Size = New System.Drawing.Size(180, 45)
        Me.Guna2Button1.TabIndex = 14
        Me.Guna2Button1.Text = "Cancel"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
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
        Me.TopPan.Size = New System.Drawing.Size(600, 38)
        Me.TopPan.TabIndex = 15
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
        Me.Max.Location = New System.Drawing.Point(528, 3)
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
        Me.Min.Location = New System.Drawing.Point(495, 3)
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
        Me.Cool.Location = New System.Drawing.Point(561, 3)
        Me.Cool.Name = "Cool"
        Me.Cool.Size = New System.Drawing.Size(27, 31)
        Me.Cool.TabIndex = 7
        '
        'Drag_Control
        '
        Me.Drag_Control.DockIndicatorTransparencyValue = 0.6R
        Me.Drag_Control.TargetControl = Me.TopPan
        Me.Drag_Control.UseTransparentDrag = True
        '
        'tsMulti
        '
        Me.tsMulti.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tsMulti.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tsMulti.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.tsMulti.CheckedState.InnerColor = System.Drawing.Color.White
        Me.tsMulti.Location = New System.Drawing.Point(495, 109)
        Me.tsMulti.Name = "tsMulti"
        Me.tsMulti.Size = New System.Drawing.Size(35, 20)
        Me.tsMulti.TabIndex = 16
        Me.tsMulti.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.tsMulti.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.tsMulti.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.tsMulti.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(458, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Add Multiple"
        '
        'Regi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 430)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tsMulti)
        Me.Controls.Add(Me.TopPan)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Regi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Regi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TopPan.ResumeLayout(False)
        Me.TopPan.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtTag As TextBox
    Friend WithEvents txtTnum As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents TopPan As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Max As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Min As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Cool As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Drag_Control As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Label1 As Label
    Friend WithEvents tsMulti As Guna.UI2.WinForms.Guna2ToggleSwitch
End Class
