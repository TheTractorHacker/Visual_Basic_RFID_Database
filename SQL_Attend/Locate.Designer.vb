<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Locate
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
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.TopPan = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Max = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Min = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Cool = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Drag_Control = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExport = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCla = New Guna.UI2.WinForms.Guna2Button()
        Me.TopPan.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TopPan.Size = New System.Drawing.Size(576, 38)
        Me.TopPan.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(53, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Location"
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
        Me.Max.Location = New System.Drawing.Point(504, 3)
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
        Me.Min.Location = New System.Drawing.Point(471, 3)
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
        Me.Cool.Location = New System.Drawing.Point(537, 3)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(35, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Change Attendance Location"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(298, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Change Classes.txt Location"
        '
        'btnExport
        '
        Me.btnExport.BorderRadius = 20
        Me.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExport.FillColor = System.Drawing.Color.Aquamarine
        Me.btnExport.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnExport.ForeColor = System.Drawing.Color.Black
        Me.btnExport.Location = New System.Drawing.Point(89, 135)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(124, 38)
        Me.btnExport.TabIndex = 11
        Me.btnExport.Text = "Change"
        '
        'btnCla
        '
        Me.btnCla.BorderRadius = 20
        Me.btnCla.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCla.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCla.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCla.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCla.FillColor = System.Drawing.Color.Aquamarine
        Me.btnCla.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCla.ForeColor = System.Drawing.Color.Black
        Me.btnCla.Location = New System.Drawing.Point(347, 135)
        Me.btnCla.Name = "btnCla"
        Me.btnCla.Size = New System.Drawing.Size(124, 38)
        Me.btnCla.TabIndex = 12
        Me.btnCla.Text = "Change"
        '
        'Locate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(576, 263)
        Me.Controls.Add(Me.btnCla)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TopPan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Locate"
        Me.Text = "Locate"
        Me.TopPan.ResumeLayout(False)
        Me.TopPan.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Drag_Control As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCla As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnExport As Guna.UI2.WinForms.Guna2Button
End Class
