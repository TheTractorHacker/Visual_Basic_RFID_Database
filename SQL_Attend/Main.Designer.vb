<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim Animation2 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.PBox = New System.Windows.Forms.PictureBox()
        Me.SidePan = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnAttend = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSettings = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDa = New Guna.UI2.WinForms.Guna2Button()
        Me.TopPan = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Max = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Min = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Cool = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.btnExport = New Guna.UI2.WinForms.Guna2Button()
        Me.cbClass = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtTag = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Window_Drag = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        CType(Me.PBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SidePan.SuspendLayout()
        Me.TopPan.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBox
        '
        Me.PBox.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.PBox, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PBox.Image = CType(resources.GetObject("PBox.Image"), System.Drawing.Image)
        Me.PBox.Location = New System.Drawing.Point(723, 52)
        Me.PBox.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.PBox.Name = "PBox"
        Me.PBox.Size = New System.Drawing.Size(310, 338)
        Me.PBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBox.TabIndex = 4
        Me.PBox.TabStop = False
        '
        'SidePan
        '
        Me.SidePan.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.SidePan.Controls.Add(Me.btnAttend)
        Me.SidePan.Controls.Add(Me.btnSettings)
        Me.SidePan.Controls.Add(Me.btnRel)
        Me.SidePan.Controls.Add(Me.btnDa)
        Me.Guna2Transition1.SetDecoration(Me.SidePan, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SidePan.Dock = System.Windows.Forms.DockStyle.Left
        Me.SidePan.Location = New System.Drawing.Point(0, 38)
        Me.SidePan.Name = "SidePan"
        Me.SidePan.Size = New System.Drawing.Size(167, 390)
        Me.SidePan.TabIndex = 5
        '
        'btnAttend
        '
        Me.btnAttend.Animated = True
        Me.btnAttend.CheckedState.FillColor = System.Drawing.Color.Red
        Me.Guna2Transition1.SetDecoration(Me.btnAttend, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnAttend.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAttend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAttend.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAttend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAttend.FillColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnAttend.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAttend.ForeColor = System.Drawing.Color.White
        Me.btnAttend.Image = Global.New_Attend_RFID.My.Resources.Resources.Attendc
        Me.btnAttend.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnAttend.Location = New System.Drawing.Point(12, 271)
        Me.btnAttend.Name = "btnAttend"
        Me.btnAttend.Size = New System.Drawing.Size(138, 81)
        Me.btnAttend.TabIndex = 9
        Me.btnAttend.Text = "Attendance"
        '
        'btnSettings
        '
        Me.btnSettings.Animated = True
        Me.btnSettings.CheckedState.FillColor = System.Drawing.Color.Red
        Me.Guna2Transition1.SetDecoration(Me.btnSettings, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSettings.FillColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnSettings.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Image = Global.New_Attend_RFID.My.Resources.Resources.Settings_30027
        Me.btnSettings.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnSettings.Location = New System.Drawing.Point(11, 188)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(138, 81)
        Me.btnSettings.TabIndex = 8
        Me.btnSettings.Text = "Settings"
        '
        'btnRel
        '
        Me.btnRel.Animated = True
        Me.btnRel.CheckedState.FillColor = System.Drawing.Color.Red
        Me.Guna2Transition1.SetDecoration(Me.btnRel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnRel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRel.FillColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnRel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRel.ForeColor = System.Drawing.Color.White
        Me.btnRel.Image = Global.New_Attend_RFID.My.Resources.Resources.reload3_78495
        Me.btnRel.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnRel.Location = New System.Drawing.Point(12, 101)
        Me.btnRel.Name = "btnRel"
        Me.btnRel.Size = New System.Drawing.Size(138, 81)
        Me.btnRel.TabIndex = 7
        Me.btnRel.Text = "Reload"
        '
        'btnDa
        '
        Me.btnDa.Animated = True
        Me.btnDa.CheckedState.FillColor = System.Drawing.Color.Red
        Me.Guna2Transition1.SetDecoration(Me.btnDa, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnDa.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDa.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDa.FillColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnDa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDa.ForeColor = System.Drawing.Color.White
        Me.btnDa.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.btnDa.Image = Global.New_Attend_RFID.My.Resources.Resources.iconfinder_database_4417104_116643
        Me.btnDa.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnDa.Location = New System.Drawing.Point(12, 14)
        Me.btnDa.Name = "btnDa"
        Me.btnDa.Size = New System.Drawing.Size(138, 81)
        Me.btnDa.TabIndex = 6
        Me.btnDa.Text = "Database"
        '
        'TopPan
        '
        Me.TopPan.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.TopPan.Controls.Add(Me.Label2)
        Me.TopPan.Controls.Add(Me.Guna2PictureBox1)
        Me.TopPan.Controls.Add(Me.Max)
        Me.TopPan.Controls.Add(Me.Min)
        Me.TopPan.Controls.Add(Me.Cool)
        Me.Guna2Transition1.SetDecoration(Me.TopPan, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TopPan.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPan.Location = New System.Drawing.Point(0, 0)
        Me.TopPan.Name = "TopPan"
        Me.TopPan.Size = New System.Drawing.Size(1063, 38)
        Me.TopPan.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.Guna2Transition1.SetDecoration(Me.Max, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Max.FillColor = System.Drawing.Color.Transparent
        Me.Max.IconColor = System.Drawing.Color.White
        Me.Max.Location = New System.Drawing.Point(991, 3)
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
        Me.Guna2Transition1.SetDecoration(Me.Min, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Min.FillColor = System.Drawing.Color.Transparent
        Me.Min.IconColor = System.Drawing.Color.White
        Me.Min.Location = New System.Drawing.Point(958, 3)
        Me.Min.Name = "Min"
        Me.Min.Size = New System.Drawing.Size(27, 31)
        Me.Min.TabIndex = 8
        '
        'Cool
        '
        Me.Cool.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cool.Animated = True
        Me.Cool.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Cool, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Cool.FillColor = System.Drawing.Color.Transparent
        Me.Cool.IconColor = System.Drawing.Color.White
        Me.Cool.Location = New System.Drawing.Point(1024, 3)
        Me.Cool.Name = "Cool"
        Me.Cool.Size = New System.Drawing.Size(27, 31)
        Me.Cool.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.BorderRadius = 15
        Me.Guna2Transition1.SetDecoration(Me.btnClear, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClear.FillColor = System.Drawing.Color.LightCoral
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(449, 349)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(165, 41)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation2
        '
        'btnExport
        '
        Me.btnExport.BorderRadius = 20
        Me.Guna2Transition1.SetDecoration(Me.btnExport, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExport.FillColor = System.Drawing.Color.Aquamarine
        Me.btnExport.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnExport.ForeColor = System.Drawing.Color.Black
        Me.btnExport.Location = New System.Drawing.Point(420, 278)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(222, 55)
        Me.btnExport.TabIndex = 4
        Me.btnExport.Text = "Export"
        '
        'cbClass
        '
        Me.cbClass.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.cbClass, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.cbClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClass.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbClass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbClass.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbClass.ForeColor = System.Drawing.Color.Black
        Me.cbClass.ItemHeight = 30
        Me.cbClass.Location = New System.Drawing.Point(431, 78)
        Me.cbClass.Name = "cbClass"
        Me.cbClass.Size = New System.Drawing.Size(200, 36)
        Me.cbClass.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(490, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Select Class:"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(420, 167)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(284, 47)
        Me.Guna2HtmlLabel1.TabIndex = 2
        Me.Guna2HtmlLabel1.Text = "Tap TAG or Scan ID"
        '
        'txtTag
        '
        Me.txtTag.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.txtTag, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtTag.DefaultText = ""
        Me.txtTag.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTag.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTag.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTag.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTag.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTag.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTag.ForeColor = System.Drawing.Color.Red
        Me.txtTag.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTag.Location = New System.Drawing.Point(404, 212)
        Me.txtTag.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTag.Name = "txtTag"
        Me.txtTag.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTag.PlaceholderText = ""
        Me.txtTag.SelectedText = ""
        Me.txtTag.Size = New System.Drawing.Size(254, 44)
        Me.txtTag.TabIndex = 3
        Me.txtTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Window_Drag
        '
        Me.Window_Drag.DockIndicatorTransparencyValue = 0.6R
        Me.Window_Drag.TargetControl = Me.TopPan
        Me.Window_Drag.UseTransparentDrag = True
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 0
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1063, 428)
        Me.Controls.Add(Me.txtTag)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbClass)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.SidePan)
        Me.Controls.Add(Me.PBox)
        Me.Controls.Add(Me.TopPan)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        CType(Me.PBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SidePan.ResumeLayout(False)
        Me.TopPan.ResumeLayout(False)
        Me.TopPan.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PBox As PictureBox
    Friend WithEvents SidePan As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TopPan As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Cool As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Max As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Min As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDa As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Window_Drag As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents cbClass As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnExport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTag As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnAttend As Guna.UI2.WinForms.Guna2Button
End Class
