<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class boreader
#Region "Windows ´°ÌåÉè¼ÆÆ÷Éú³ÉµÄ´úÂë "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        '´Ëµ÷ÓÃÊÇ Windows ´°ÌåÉè¼ÆÆ÷Ëù±ØÐèµÄ¡£
        InitializeComponent()
    End Sub
    'Form ÖØÐ´ Dispose£¬ÒÔÇåÀí×é¼þÁÐ±í¡£
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Windows ´°ÌåÉè¼ÆÆ÷Ëù±ØÐèµÄ
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Command31 As System.Windows.Forms.Button
    Public WithEvents Timer2 As System.Windows.Forms.Timer
    Public WithEvents BtnLeerReg As System.Windows.Forms.Button
    Public WithEvents Command23 As System.Windows.Forms.Button
    Public WithEvents BtnTotales As System.Windows.Forms.Button
    Public WithEvents Command19 As System.Windows.Forms.Button
    Public WithEvents Command18 As System.Windows.Forms.Button
    Public WithEvents BtnReaderFile As System.Windows.Forms.Button
    Public WithEvents BtnWriteFile As System.Windows.Forms.Button
    Public WithEvents Command8 As System.Windows.Forms.Button
    Public WithEvents Command2 As System.Windows.Forms.Button
    Public WithEvents Command1 As System.Windows.Forms.Button
    '×¢Òâ: ÒÔÏÂ¹ý³ÌÊÇ Windows ´°ÌåÉè¼ÆÆ÷Ëù±ØÐèµÄ
    '¿ÉÒÔÊ¹ÓÃ Windows ´°ÌåÉè¼ÆÆ÷À´ÐÞ¸ÄËü¡£
    '²»ÒªÊ¹ÓÃ´úÂë±à¼­Æ÷ÐÞ¸ÄËü¡£
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(boreader))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Command31 = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnLeerReg = New System.Windows.Forms.Button()
        Me.Command23 = New System.Windows.Forms.Button()
        Me.BtnTotales = New System.Windows.Forms.Button()
        Me.Command19 = New System.Windows.Forms.Button()
        Me.Command18 = New System.Windows.Forms.Button()
        Me.BtnReaderFile = New System.Windows.Forms.Button()
        Me.BtnWriteFile = New System.Windows.Forms.Button()
        Me.Command8 = New System.Windows.Forms.Button()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.lblId1 = New System.Windows.Forms.Label()
        Me.RadioCom = New System.Windows.Forms.RadioButton()
        Me.RadioNet = New System.Windows.Forms.RadioButton()
        Me.lblComPort = New System.Windows.Forms.Label()
        Me.lblIp = New System.Windows.Forms.Label()
        Me.cmbComPort = New System.Windows.Forms.ComboBox()
        Me.txtIp = New System.Windows.Forms.TextBox()
        Me.BtnNetDaemon = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.BtnHora = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnGenerarTXT = New System.Windows.Forms.Button()
        Me.Command10 = New System.Windows.Forms.Button()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.lblUltima = New System.Windows.Forms.Label()
        Me.lblEstado1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.cmbId = New System.Windows.Forms.ComboBox()
        Me.lblIntervalo = New System.Windows.Forms.Label()
        Me.txtIntervalo = New System.Windows.Forms.TextBox()
        Me.txttiempo = New System.Windows.Forms.Label()
        Me.Notify_icon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblArchivo2 = New System.Windows.Forms.Label()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.cmbId2 = New System.Windows.Forms.ComboBox()
        Me.RadioCom2 = New System.Windows.Forms.RadioButton()
        Me.txtIp2 = New System.Windows.Forms.TextBox()
        Me.lblTiempo2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbComPort2 = New System.Windows.Forms.ComboBox()
        Me.RadioNet2 = New System.Windows.Forms.RadioButton()
        Me.BtnGenerarTXT2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblUltima2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblInicio1 = New System.Windows.Forms.Label()
        Me.txtInicio1 = New System.Windows.Forms.TextBox()
        Me.lblArchivo1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.lblErrorIntervalo = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Command31
        '
        Me.Command31.BackColor = System.Drawing.SystemColors.Control
        Me.Command31.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command31.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Command31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command31.Location = New System.Drawing.Point(15, 477)
        Me.Command31.Name = "Command31"
        Me.Command31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command31.Size = New System.Drawing.Size(126, 25)
        Me.Command31.TabIndex = 30
        Me.Command31.Text = "Get Device Info"
        Me.Command31.UseVisualStyleBackColor = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 100000000
        '
        'BtnLeerReg
        '
        Me.BtnLeerReg.BackColor = System.Drawing.SystemColors.Control
        Me.BtnLeerReg.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnLeerReg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnLeerReg.Location = New System.Drawing.Point(165, 574)
        Me.BtnLeerReg.Name = "BtnLeerReg"
        Me.BtnLeerReg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnLeerReg.Size = New System.Drawing.Size(126, 25)
        Me.BtnLeerReg.TabIndex = 23
        Me.BtnLeerReg.Text = "Leer &Registros"
        Me.BtnLeerReg.UseVisualStyleBackColor = False
        '
        'Command23
        '
        Me.Command23.BackColor = System.Drawing.SystemColors.Control
        Me.Command23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command23.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Command23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command23.Location = New System.Drawing.Point(15, 508)
        Me.Command23.Name = "Command23"
        Me.Command23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command23.Size = New System.Drawing.Size(127, 25)
        Me.Command23.TabIndex = 22
        Me.Command23.Text = "Get/Add Message"
        Me.Command23.UseVisualStyleBackColor = False
        '
        'BtnTotales
        '
        Me.BtnTotales.BackColor = System.Drawing.SystemColors.Control
        Me.BtnTotales.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnTotales.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnTotales.Location = New System.Drawing.Point(163, 446)
        Me.BtnTotales.Name = "BtnTotales"
        Me.BtnTotales.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnTotales.Size = New System.Drawing.Size(127, 25)
        Me.BtnTotales.TabIndex = 19
        Me.BtnTotales.Text = "Leer Totales ..."
        Me.BtnTotales.UseVisualStyleBackColor = False
        '
        'Command19
        '
        Me.Command19.BackColor = System.Drawing.SystemColors.Control
        Me.Command19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command19.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Command19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command19.Location = New System.Drawing.Point(704, 307)
        Me.Command19.Name = "Command19"
        Me.Command19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command19.Size = New System.Drawing.Size(86, 25)
        Me.Command19.TabIndex = 18
        Me.Command19.Text = "Leer &Usuarios"
        Me.Command19.UseVisualStyleBackColor = False
        '
        'Command18
        '
        Me.Command18.BackColor = System.Drawing.SystemColors.Control
        Me.Command18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command18.Location = New System.Drawing.Point(15, 541)
        Me.Command18.Name = "Command18"
        Me.Command18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command18.Size = New System.Drawing.Size(127, 25)
        Me.Command18.TabIndex = 17
        Me.Command18.Text = "Get All Message Head" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Command18.UseVisualStyleBackColor = False
        '
        'BtnReaderFile
        '
        Me.BtnReaderFile.BackColor = System.Drawing.SystemColors.Control
        Me.BtnReaderFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnReaderFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnReaderFile.Location = New System.Drawing.Point(16, 578)
        Me.BtnReaderFile.Name = "BtnReaderFile"
        Me.BtnReaderFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnReaderFile.Size = New System.Drawing.Size(127, 25)
        Me.BtnReaderFile.TabIndex = 11
        Me.BtnReaderFile.Text = "Read file,set FP"
        Me.BtnReaderFile.UseVisualStyleBackColor = False
        '
        'BtnWriteFile
        '
        Me.BtnWriteFile.BackColor = System.Drawing.SystemColors.Control
        Me.BtnWriteFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnWriteFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnWriteFile.Location = New System.Drawing.Point(8, 571)
        Me.BtnWriteFile.Name = "BtnWriteFile"
        Me.BtnWriteFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnWriteFile.Size = New System.Drawing.Size(127, 25)
        Me.BtnWriteFile.TabIndex = 10
        Me.BtnWriteFile.Text = "Get FP,write file"
        Me.BtnWriteFile.UseVisualStyleBackColor = False
        '
        'Command8
        '
        Me.Command8.BackColor = System.Drawing.SystemColors.Control
        Me.Command8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command8.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Command8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command8.Location = New System.Drawing.Point(15, 446)
        Me.Command8.Name = "Command8"
        Me.Command8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command8.Size = New System.Drawing.Size(126, 25)
        Me.Command8.TabIndex = 7
        Me.Command8.Text = "GET DATA TIME"
        Me.Command8.UseVisualStyleBackColor = False
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(14, 415)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(126, 25)
        Me.Command2.TabIndex = 1
        Me.Command2.Text = "GET NET "
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(14, 383)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(126, 25)
        Me.Command1.TabIndex = 0
        Me.Command1.Text = "Get From NET Device"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(163, 541)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(128, 25)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Set/Get HitRingInfo"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.SystemColors.Control
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnStart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStart.Location = New System.Drawing.Point(12, 351)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnStart.Size = New System.Drawing.Size(93, 25)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Conectarse..."
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.SystemColors.Control
        Me.btnEnd.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEnd.Location = New System.Drawing.Point(124, 351)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEnd.Size = New System.Drawing.Size(107, 25)
        Me.btnEnd.TabIndex = 35
        Me.btnEnd.Text = "Cerrar conexión"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Control
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button5.Location = New System.Drawing.Point(164, 508)
        Me.Button5.Name = "Button5"
        Me.Button5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button5.Size = New System.Drawing.Size(127, 25)
        Me.Button5.TabIndex = 36
        Me.Button5.Text = "Set/Get Time Section"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'lblId1
        '
        Me.lblId1.AutoSize = True
        Me.lblId1.Location = New System.Drawing.Point(25, 34)
        Me.lblId1.Name = "lblId1"
        Me.lblId1.Size = New System.Drawing.Size(22, 13)
        Me.lblId1.TabIndex = 42
        Me.lblId1.Text = "ID:"
        '
        'RadioCom
        '
        Me.RadioCom.AutoSize = True
        Me.RadioCom.Location = New System.Drawing.Point(78, 53)
        Me.RadioCom.Name = "RadioCom"
        Me.RadioCom.Size = New System.Drawing.Size(46, 17)
        Me.RadioCom.TabIndex = 43
        Me.RadioCom.Text = "Com"
        Me.RadioCom.UseVisualStyleBackColor = True
        '
        'RadioNet
        '
        Me.RadioNet.AutoSize = True
        Me.RadioNet.Checked = True
        Me.RadioNet.Location = New System.Drawing.Point(30, 53)
        Me.RadioNet.Name = "RadioNet"
        Me.RadioNet.Size = New System.Drawing.Size(42, 17)
        Me.RadioNet.TabIndex = 44
        Me.RadioNet.TabStop = True
        Me.RadioNet.Text = "Lan"
        Me.RadioNet.UseVisualStyleBackColor = True
        '
        'lblComPort
        '
        Me.lblComPort.AutoSize = True
        Me.lblComPort.Enabled = False
        Me.lblComPort.Location = New System.Drawing.Point(147, 24)
        Me.lblComPort.Name = "lblComPort"
        Me.lblComPort.Size = New System.Drawing.Size(57, 13)
        Me.lblComPort.TabIndex = 45
        Me.lblComPort.Text = "COM Port:"
        '
        'lblIp
        '
        Me.lblIp.AutoSize = True
        Me.lblIp.Location = New System.Drawing.Point(279, 26)
        Me.lblIp.Name = "lblIp"
        Me.lblIp.Size = New System.Drawing.Size(24, 13)
        Me.lblIp.TabIndex = 46
        Me.lblIp.Text = "IP :"
        '
        'cmbComPort
        '
        Me.cmbComPort.Enabled = False
        Me.cmbComPort.FormattingEnabled = True
        Me.cmbComPort.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9"})
        Me.cmbComPort.Location = New System.Drawing.Point(203, 21)
        Me.cmbComPort.Name = "cmbComPort"
        Me.cmbComPort.Size = New System.Drawing.Size(53, 21)
        Me.cmbComPort.TabIndex = 47
        '
        'txtIp
        '
        Me.txtIp.Location = New System.Drawing.Point(309, 20)
        Me.txtIp.Name = "txtIp"
        Me.txtIp.Size = New System.Drawing.Size(72, 21)
        Me.txtIp.TabIndex = 48
        Me.txtIp.Text = "10.0.0.249"
        '
        'BtnNetDaemon
        '
        Me.BtnNetDaemon.BackColor = System.Drawing.SystemColors.Control
        Me.BtnNetDaemon.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnNetDaemon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnNetDaemon.Location = New System.Drawing.Point(164, 414)
        Me.BtnNetDaemon.Name = "BtnNetDaemon"
        Me.BtnNetDaemon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnNetDaemon.Size = New System.Drawing.Size(126, 25)
        Me.BtnNetDaemon.TabIndex = 50
        Me.BtnNetDaemon.Text = "Net Daemon"
        Me.BtnNetDaemon.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.SystemColors.Control
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button11.Location = New System.Drawing.Point(163, 386)
        Me.Button11.Name = "Button11"
        Me.Button11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button11.Size = New System.Drawing.Size(126, 25)
        Me.Button11.TabIndex = 49
        Me.Button11.Text = "Com Daemon"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'BtnHora
        '
        Me.BtnHora.BackColor = System.Drawing.SystemColors.Control
        Me.BtnHora.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnHora.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnHora.Location = New System.Drawing.Point(163, 477)
        Me.BtnHora.Name = "BtnHora"
        Me.BtnHora.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnHora.Size = New System.Drawing.Size(127, 25)
        Me.BtnHora.TabIndex = 36
        Me.BtnHora.Text = "Set/Get Time Section"
        Me.BtnHora.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader13})
        Me.ListView1.Location = New System.Drawing.Point(329, 398)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(274, 183)
        Me.ListView1.TabIndex = 51
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Staffer No"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date/Time"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Status"
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Machine ID"
        Me.ColumnHeader13.Width = 79
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(421, 52)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(257, 19)
        Me.ProgressBar1.TabIndex = 52
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(15, 388)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(274, 23)
        Me.ProgressBar2.TabIndex = 53
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18})
        Me.ListView2.Location = New System.Drawing.Point(16, 430)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(274, 223)
        Me.ListView2.TabIndex = 55
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "No"
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Staffer No"
        Me.ColumnHeader15.Width = 78
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Name"
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "PWD"
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "CardNO"
        Me.ColumnHeader18.Width = 79
        '
        'BtnGenerarTXT
        '
        Me.BtnGenerarTXT.BackColor = System.Drawing.SystemColors.Control
        Me.BtnGenerarTXT.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnGenerarTXT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnGenerarTXT.Location = New System.Drawing.Point(559, 16)
        Me.BtnGenerarTXT.Name = "BtnGenerarTXT"
        Me.BtnGenerarTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnGenerarTXT.Size = New System.Drawing.Size(117, 28)
        Me.BtnGenerarTXT.TabIndex = 56
        Me.BtnGenerarTXT.Text = "Leer &Reloj ..."
        Me.BtnGenerarTXT.UseVisualStyleBackColor = False
        '
        'Command10
        '
        Me.Command10.BackColor = System.Drawing.SystemColors.Control
        Me.Command10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command10.Location = New System.Drawing.Point(15, 574)
        Me.Command10.Name = "Command10"
        Me.Command10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command10.Size = New System.Drawing.Size(126, 25)
        Me.Command10.TabIndex = 9
        Me.Command10.Text = "Get/Set finger print"
        Me.Command10.UseVisualStyleBackColor = False
        '
        'lblTiempo
        '
        Me.lblTiempo.Location = New System.Drawing.Point(20, 93)
        Me.lblTiempo.MinimumSize = New System.Drawing.Size(100, 0)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(127, 30)
        Me.lblTiempo.TabIndex = 57
        Me.lblTiempo.Text = "Sin reintentos aún"
        '
        'lblUltima
        '
        Me.lblUltima.ForeColor = System.Drawing.Color.Red
        Me.lblUltima.Location = New System.Drawing.Point(197, 84)
        Me.lblUltima.MinimumSize = New System.Drawing.Size(100, 0)
        Me.lblUltima.Name = "lblUltima"
        Me.lblUltima.Size = New System.Drawing.Size(270, 30)
        Me.lblUltima.TabIndex = 58
        Me.lblUltima.Text = "Sin Lectura"
        '
        'lblEstado1
        '
        Me.lblEstado1.Location = New System.Drawing.Point(163, 93)
        Me.lblEstado1.Name = "lblEstado1"
        Me.lblEstado1.Size = New System.Drawing.Size(44, 19)
        Me.lblEstado1.TabIndex = 59
        Me.lblEstado1.Text = "Estado:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 600000
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnSalir.Location = New System.Drawing.Point(569, 352)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSalir.Size = New System.Drawing.Size(62, 23)
        Me.BtnSalir.TabIndex = 60
        Me.BtnSalir.Text = "&Cerrar"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'cmbId
        '
        Me.cmbId.FormattingEnabled = True
        Me.cmbId.Items.AddRange(New Object() {"55555555", "55555554", "1", "76130011", "76120114", "(Sin uso)"})
        Me.cmbId.Location = New System.Drawing.Point(53, 30)
        Me.cmbId.Name = "cmbId"
        Me.cmbId.Size = New System.Drawing.Size(79, 21)
        Me.cmbId.TabIndex = 61
        Me.cmbId.Text = "55555555"
        '
        'lblIntervalo
        '
        Me.lblIntervalo.AutoSize = True
        Me.lblIntervalo.Location = New System.Drawing.Point(12, 324)
        Me.lblIntervalo.Name = "lblIntervalo"
        Me.lblIntervalo.Size = New System.Drawing.Size(106, 13)
        Me.lblIntervalo.TabIndex = 62
        Me.lblIntervalo.Text = "Intervalo de lectura:"
        '
        'txtIntervalo
        '
        Me.txtIntervalo.Location = New System.Drawing.Point(122, 320)
        Me.txtIntervalo.Name = "txtIntervalo"
        Me.txtIntervalo.Size = New System.Drawing.Size(45, 21)
        Me.txtIntervalo.TabIndex = 63
        Me.txtIntervalo.Text = "30"
        '
        'txttiempo
        '
        Me.txttiempo.AutoSize = True
        Me.txttiempo.Location = New System.Drawing.Point(170, 324)
        Me.txttiempo.Name = "txttiempo"
        Me.txttiempo.Size = New System.Drawing.Size(44, 13)
        Me.txttiempo.TabIndex = 64
        Me.txttiempo.Text = "Minutos"
        '
        'Notify_icon
        '
        Me.Notify_icon.BalloonTipText = "Leyendo relojes asociados..."
        Me.Notify_icon.BalloonTipTitle = "Zonda - Lector de Relojes"
        Me.Notify_icon.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Notify_icon.Icon = CType(resources.GetObject("Notify_icon.Icon"), System.Drawing.Icon)
        Me.Notify_icon.Text = "Zonda - Lector de Relojes"
        Me.Notify_icon.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.CerrarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(163, 48)
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AbrirToolStripMenuItem.Text = "Estado de relojes"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.CerrarToolStripMenuItem.Text = "&Cerrar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblArchivo2)
        Me.GroupBox1.Controls.Add(Me.ProgressBar3)
        Me.GroupBox1.Controls.Add(Me.cmbId2)
        Me.GroupBox1.Controls.Add(Me.RadioCom2)
        Me.GroupBox1.Controls.Add(Me.txtIp2)
        Me.GroupBox1.Controls.Add(Me.lblTiempo2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbComPort2)
        Me.GroupBox1.Controls.Add(Me.RadioNet2)
        Me.GroupBox1.Controls.Add(Me.BtnGenerarTXT2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblUltima2)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 162)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(688, 145)
        Me.GroupBox1.TabIndex = 96
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reloj N° 2"
        '
        'lblArchivo2
        '
        Me.lblArchivo2.ForeColor = System.Drawing.Color.Red
        Me.lblArchivo2.Location = New System.Drawing.Point(10, 114)
        Me.lblArchivo2.MinimumSize = New System.Drawing.Size(100, 0)
        Me.lblArchivo2.Name = "lblArchivo2"
        Me.lblArchivo2.Size = New System.Drawing.Size(666, 18)
        Me.lblArchivo2.TabIndex = 81
        Me.lblArchivo2.Text = "Sin generar aún archivo"
        Me.lblArchivo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProgressBar3
        '
        Me.ProgressBar3.Location = New System.Drawing.Point(421, 57)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(257, 19)
        Me.ProgressBar3.TabIndex = 74
        '
        'cmbId2
        '
        Me.cmbId2.FormattingEnabled = True
        Me.cmbId2.Items.AddRange(New Object() {"55555555", "55555554", "1", "76130011", "76120114", "(Sin uso)"})
        Me.cmbId2.Location = New System.Drawing.Point(43, 20)
        Me.cmbId2.Name = "cmbId2"
        Me.cmbId2.Size = New System.Drawing.Size(79, 21)
        Me.cmbId2.TabIndex = 79
        Me.cmbId2.Text = "55555554"
        '
        'RadioCom2
        '
        Me.RadioCom2.AutoSize = True
        Me.RadioCom2.Location = New System.Drawing.Point(78, 57)
        Me.RadioCom2.Name = "RadioCom2"
        Me.RadioCom2.Size = New System.Drawing.Size(46, 17)
        Me.RadioCom2.TabIndex = 68
        Me.RadioCom2.Text = "Com"
        Me.RadioCom2.UseVisualStyleBackColor = True
        '
        'txtIp2
        '
        Me.txtIp2.Location = New System.Drawing.Point(309, 22)
        Me.txtIp2.Name = "txtIp2"
        Me.txtIp2.Size = New System.Drawing.Size(72, 21)
        Me.txtIp2.TabIndex = 73
        Me.txtIp2.Text = "10.0.0.240"
        '
        'lblTiempo2
        '
        Me.lblTiempo2.Location = New System.Drawing.Point(10, 84)
        Me.lblTiempo2.MinimumSize = New System.Drawing.Size(100, 0)
        Me.lblTiempo2.Name = "lblTiempo2"
        Me.lblTiempo2.Size = New System.Drawing.Size(127, 30)
        Me.lblTiempo2.TabIndex = 76
        Me.lblTiempo2.Text = "Sin reintentos aún"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(279, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "IP :"
        '
        'cmbComPort2
        '
        Me.cmbComPort2.Enabled = False
        Me.cmbComPort2.FormattingEnabled = True
        Me.cmbComPort2.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9"})
        Me.cmbComPort2.Location = New System.Drawing.Point(203, 21)
        Me.cmbComPort2.Name = "cmbComPort2"
        Me.cmbComPort2.Size = New System.Drawing.Size(53, 21)
        Me.cmbComPort2.TabIndex = 72
        '
        'RadioNet2
        '
        Me.RadioNet2.AutoSize = True
        Me.RadioNet2.Checked = True
        Me.RadioNet2.Location = New System.Drawing.Point(30, 57)
        Me.RadioNet2.Name = "RadioNet2"
        Me.RadioNet2.Size = New System.Drawing.Size(42, 17)
        Me.RadioNet2.TabIndex = 69
        Me.RadioNet2.TabStop = True
        Me.RadioNet2.Text = "Lan"
        Me.RadioNet2.UseVisualStyleBackColor = True
        '
        'BtnGenerarTXT2
        '
        Me.BtnGenerarTXT2.BackColor = System.Drawing.SystemColors.Control
        Me.BtnGenerarTXT2.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnGenerarTXT2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnGenerarTXT2.Location = New System.Drawing.Point(561, 19)
        Me.BtnGenerarTXT2.Name = "BtnGenerarTXT2"
        Me.BtnGenerarTXT2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnGenerarTXT2.Size = New System.Drawing.Size(117, 28)
        Me.BtnGenerarTXT2.TabIndex = 75
        Me.BtnGenerarTXT2.Text = "Leer &Reloj ..."
        Me.BtnGenerarTXT2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Location = New System.Drawing.Point(147, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "COM Port:"
        '
        'lblUltima2
        '
        Me.lblUltima2.ForeColor = System.Drawing.Color.Red
        Me.lblUltima2.Location = New System.Drawing.Point(197, 84)
        Me.lblUltima2.MinimumSize = New System.Drawing.Size(100, 0)
        Me.lblUltima2.Name = "lblUltima2"
        Me.lblUltima2.Size = New System.Drawing.Size(270, 30)
        Me.lblUltima2.TabIndex = 77
        Me.lblUltima2.Text = "Sin Lectura"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblInicio1)
        Me.GroupBox2.Controls.Add(Me.txtInicio1)
        Me.GroupBox2.Controls.Add(Me.lblArchivo1)
        Me.GroupBox2.Controls.Add(Me.ProgressBar1)
        Me.GroupBox2.Controls.Add(Me.BtnGenerarTXT)
        Me.GroupBox2.Controls.Add(Me.RadioCom)
        Me.GroupBox2.Controls.Add(Me.RadioNet)
        Me.GroupBox2.Controls.Add(Me.cmbComPort)
        Me.GroupBox2.Controls.Add(Me.lblComPort)
        Me.GroupBox2.Controls.Add(Me.txtIp)
        Me.GroupBox2.Controls.Add(Me.lblIp)
        Me.GroupBox2.Controls.Add(Me.lblUltima)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(688, 145)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reloj N° 1"
        '
        'lblInicio1
        '
        Me.lblInicio1.AutoSize = True
        Me.lblInicio1.Location = New System.Drawing.Point(419, 23)
        Me.lblInicio1.Name = "lblInicio1"
        Me.lblInicio1.Size = New System.Drawing.Size(36, 13)
        Me.lblInicio1.TabIndex = 98
        Me.lblInicio1.Text = "Inicio:"
        '
        'txtInicio1
        '
        Me.txtInicio1.Location = New System.Drawing.Point(467, 20)
        Me.txtInicio1.Name = "txtInicio1"
        Me.txtInicio1.Size = New System.Drawing.Size(72, 21)
        Me.txtInicio1.TabIndex = 81
        Me.txtInicio1.Text = "0"
        '
        'lblArchivo1
        '
        Me.lblArchivo1.ForeColor = System.Drawing.Color.Red
        Me.lblArchivo1.Location = New System.Drawing.Point(10, 114)
        Me.lblArchivo1.MinimumSize = New System.Drawing.Size(100, 0)
        Me.lblArchivo1.Name = "lblArchivo1"
        Me.lblArchivo1.Size = New System.Drawing.Size(666, 18)
        Me.lblArchivo1.TabIndex = 80
        Me.lblArchivo1.Text = "Sin generar aún archivo"
        Me.lblArchivo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(163, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 19)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Estado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "ID:"
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 600000
        '
        'lblErrorIntervalo
        '
        Me.lblErrorIntervalo.ForeColor = System.Drawing.Color.Red
        Me.lblErrorIntervalo.Location = New System.Drawing.Point(232, 324)
        Me.lblErrorIntervalo.Name = "lblErrorIntervalo"
        Me.lblErrorIntervalo.Size = New System.Drawing.Size(463, 17)
        Me.lblErrorIntervalo.TabIndex = 97
        Me.lblErrorIntervalo.Text = "* El intervalo debe ser mayor que cero"
        Me.lblErrorIntervalo.Visible = False
        '
        'boreader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(707, 349)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.lblErrorIntervalo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txttiempo)
        Me.Controls.Add(Me.txtIntervalo)
        Me.Controls.Add(Me.lblIntervalo)
        Me.Controls.Add(Me.cmbId)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.lblEstado1)
        Me.Controls.Add(Me.lblTiempo)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.BtnNetDaemon)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.lblId1)
        Me.Controls.Add(Me.BtnHora)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Command31)
        Me.Controls.Add(Me.BtnLeerReg)
        Me.Controls.Add(Me.Command23)
        Me.Controls.Add(Me.BtnTotales)
        Me.Controls.Add(Me.Command19)
        Me.Controls.Add(Me.Command18)
        Me.Controls.Add(Me.BtnReaderFile)
        Me.Controls.Add(Me.BtnWriteFile)
        Me.Controls.Add(Me.Command10)
        Me.Controls.Add(Me.Command8)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(191, 74)
        Me.MaximizeBox = False
        Me.Name = "boreader"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Lector de Relojes (Anviz, BioOffice) - Zonda Gestión 2015"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Button2 As System.Windows.Forms.Button
    Public WithEvents btnStart As System.Windows.Forms.Button
    Public WithEvents btnEnd As System.Windows.Forms.Button
    Public WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents lblId1 As System.Windows.Forms.Label
    Friend WithEvents RadioCom As System.Windows.Forms.RadioButton
    Friend WithEvents RadioNet As System.Windows.Forms.RadioButton
    Friend WithEvents lblComPort As System.Windows.Forms.Label
    Friend WithEvents lblIp As System.Windows.Forms.Label
    Friend WithEvents cmbComPort As System.Windows.Forms.ComboBox
    Friend WithEvents txtIp As System.Windows.Forms.TextBox
    Public WithEvents BtnNetDaemon As System.Windows.Forms.Button
    Public WithEvents Button11 As System.Windows.Forms.Button
    Public WithEvents BtnHora As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Public WithEvents BtnGenerarTXT As System.Windows.Forms.Button
    Public WithEvents Command10 As System.Windows.Forms.Button
    Friend WithEvents lblTiempo As System.Windows.Forms.Label
    Friend WithEvents lblUltima As System.Windows.Forms.Label
    Friend WithEvents lblEstado1 As System.Windows.Forms.Label
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents cmbId As System.Windows.Forms.ComboBox
    Friend WithEvents lblIntervalo As System.Windows.Forms.Label
    Friend WithEvents txtIntervalo As System.Windows.Forms.TextBox
    Friend WithEvents txttiempo As System.Windows.Forms.Label
    Private WithEvents Notify_icon As System.Windows.Forms.NotifyIcon
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgressBar3 As System.Windows.Forms.ProgressBar
    Friend WithEvents cmbId2 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioCom2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioNet2 As System.Windows.Forms.RadioButton
    Public WithEvents BtnGenerarTXT2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTiempo2 As System.Windows.Forms.Label
    Friend WithEvents txtIp2 As System.Windows.Forms.TextBox
    Friend WithEvents cmbComPort2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblUltima2 As System.Windows.Forms.Label
    Public WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents lblErrorIntervalo As System.Windows.Forms.Label
    Friend WithEvents lblArchivo2 As System.Windows.Forms.Label
    Friend WithEvents lblArchivo1 As System.Windows.Forms.Label
    Friend WithEvents lblInicio1 As System.Windows.Forms.Label
    Friend WithEvents txtInicio1 As System.Windows.Forms.TextBox
#End Region
End Class