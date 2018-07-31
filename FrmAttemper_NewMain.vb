Imports TALLY.DBControl
Imports Microsoft.VisualBasic

Public Class FrmAttemper_NewMain
    Inherits Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写 dispose 以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents CmbDEPT_CODE As System.Windows.Forms.ComboBox
    Friend WithEvents DTPWATCHDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtITEM As System.Windows.Forms.TextBox
    Friend WithEvents txtSecurity As System.Windows.Forms.TextBox
    Friend WithEvents TxtWATCH_ID As System.Windows.Forms.TextBox
    Friend WithEvents TxtUSER_NAME As System.Windows.Forms.TextBox
    Friend WithEvents TxtLock_Mark As System.Windows.Forms.TextBox
    Friend WithEvents CmbWORK_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDAYNIGHTMARK As System.Windows.Forms.ComboBox
    Friend WithEvents CmbWeather As System.Windows.Forms.ComboBox
    Friend WithEvents CmbWATCH_DIRECTOR As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDIRECTOR As System.Windows.Forms.ComboBox
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GB2 As System.Windows.Forms.GroupBox
    Friend WithEvents C1DBGV As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DTPBERTH_TIME As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtBERTHNO As System.Windows.Forms.TextBox
    Friend WithEvents btQuery As System.Windows.Forms.Button
    Friend WithEvents btAttemper As System.Windows.Forms.Button
    Friend WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents btShip_Add As System.Windows.Forms.Button
    Friend WithEvents btShipInport As System.Windows.Forms.Button
    Friend WithEvents btShipQuery As System.Windows.Forms.Button
    Friend WithEvents C1DBG2 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1DBG3 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1DBG4 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DTPWORKTIME_END As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btNext As System.Windows.Forms.Button
    Friend WithEvents btnHatch As System.Windows.Forms.Button
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents C1DBG5V As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1DBG5 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents BtnMove As System.Windows.Forms.Button
    Friend WithEvents BtnChange As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btLock As System.Windows.Forms.Button
    Friend WithEvents btVessel As System.Windows.Forms.Button
    Friend WithEvents btUnLock As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAttemper_NewMain))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.BtnMove = New System.Windows.Forms.Button
        Me.BtnChange = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.DTPWORKTIME_END = New System.Windows.Forms.DateTimePicker
        Me.GB2 = New System.Windows.Forms.GroupBox
        Me.C1DBGV = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Button3 = New System.Windows.Forms.Button
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btVessel = New System.Windows.Forms.Button
        Me.btShipInport = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.DTPBERTH_TIME = New System.Windows.Forms.DateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtBERTHNO = New System.Windows.Forms.TextBox
        Me.C1DBG2 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.btnHatch = New System.Windows.Forms.Button
        Me.btNext = New System.Windows.Forms.Button
        Me.btShipQuery = New System.Windows.Forms.Button
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.C1DBG3 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.btUnLock = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.C1DBG4 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btLock = New System.Windows.Forms.Button
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.C1DBG5V = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1DBG5 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.GB = New System.Windows.Forms.GroupBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.btQuery = New System.Windows.Forms.Button
        Me.CmbDIRECTOR = New System.Windows.Forms.ComboBox
        Me.CmbWATCH_DIRECTOR = New System.Windows.Forms.ComboBox
        Me.CmbWeather = New System.Windows.Forms.ComboBox
        Me.CmbDAYNIGHTMARK = New System.Windows.Forms.ComboBox
        Me.CmbWORK_TYPE = New System.Windows.Forms.ComboBox
        Me.CmbDEPT_CODE = New System.Windows.Forms.ComboBox
        Me.DTPWATCHDATE = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtSecurity = New System.Windows.Forms.TextBox
        Me.TxtWATCH_ID = New System.Windows.Forms.TextBox
        Me.TxtUSER_NAME = New System.Windows.Forms.TextBox
        Me.TxtLock_Mark = New System.Windows.Forms.TextBox
        Me.TxtITEM = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.btAttemper = New System.Windows.Forms.Button
        Me.btClose = New System.Windows.Forms.Button
        Me.btShip_Add = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GB2.SuspendLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.C1DBG2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.C1DBG3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.C1DBG4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.C1DBG5V, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DBG5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(2, 161)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(992, 433)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.BtnMove)
        Me.TabPage1.Controls.Add(Me.BtnChange)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.DTPWORKTIME_END)
        Me.TabPage1.Controls.Add(Me.GB2)
        Me.TabPage1.Controls.Add(Me.C1DBG)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(984, 407)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "在港作业船舶"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(382, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 24)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "舱   单"
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(296, 280)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 24)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "现场资料"
        '
        'BtnMove
        '
        Me.BtnMove.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnMove.Enabled = False
        Me.BtnMove.Location = New System.Drawing.Point(564, 280)
        Me.BtnMove.Name = "BtnMove"
        Me.BtnMove.Size = New System.Drawing.Size(75, 24)
        Me.BtnMove.TabIndex = 48
        Me.BtnMove.Text = "移  泊"
        '
        'BtnChange
        '
        Me.BtnChange.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnChange.Enabled = False
        Me.BtnChange.Location = New System.Drawing.Point(480, 280)
        Me.BtnChange.Name = "BtnChange"
        Me.BtnChange.Size = New System.Drawing.Size(75, 24)
        Me.BtnChange.TabIndex = 47
        Me.BtnChange.Text = "调整站属"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(534, 330)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(65, 24)
        Me.btnSave.TabIndex = 46
        Me.btnSave.Text = "确定"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.Location = New System.Drawing.Point(346, 330)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 23)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "完工时间"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTPWORKTIME_END
        '
        Me.DTPWORKTIME_END.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.DTPWORKTIME_END.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DTPWORKTIME_END.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPWORKTIME_END.Location = New System.Drawing.Point(408, 330)
        Me.DTPWORKTIME_END.Name = "DTPWORKTIME_END"
        Me.DTPWORKTIME_END.Size = New System.Drawing.Size(122, 21)
        Me.DTPWORKTIME_END.TabIndex = 44
        '
        'GB2
        '
        Me.GB2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GB2.Controls.Add(Me.C1DBGV)
        Me.GB2.Location = New System.Drawing.Point(8, 260)
        Me.GB2.Margin = New System.Windows.Forms.Padding(0)
        Me.GB2.Name = "GB2"
        Me.GB2.Padding = New System.Windows.Forms.Padding(0)
        Me.GB2.Size = New System.Drawing.Size(212, 144)
        Me.GB2.TabIndex = 3
        Me.GB2.TabStop = False
        Me.GB2.Text = "船派工信息"
        '
        'C1DBGV
        '
        Me.C1DBGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBGV.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGV.Images.Add(CType(resources.GetObject("C1DBGV.Images"), System.Drawing.Image))
        Me.C1DBGV.Location = New System.Drawing.Point(0, 14)
        Me.C1DBGV.Name = "C1DBGV"
        Me.C1DBGV.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGV.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGV.PreviewInfo.ZoomFactor = 75
        Me.C1DBGV.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGV.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGV.Size = New System.Drawing.Size(212, 130)
        Me.C1DBGV.TabIndex = 0
        Me.C1DBGV.PropBag = resources.GetString("C1DBGV.PropBag")
        '
        'C1DBG
        '
        Me.C1DBG.AllowColMove = False
        Me.C1DBG.AllowDrag = True
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("C1DBG.Images"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(2, 2)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG.Size = New System.Drawing.Size(979, 258)
        Me.C1DBG.TabIndex = 1
        Me.C1DBG.PropBag = resources.GetString("C1DBG.PropBag")
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(838, 278)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(68, 32)
        Me.Button3.TabIndex = 42
        Me.Button3.Text = "刷新"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btVessel)
        Me.TabPage2.Controls.Add(Me.btShipInport)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.DTPBERTH_TIME)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.TxtBERTHNO)
        Me.TabPage2.Controls.Add(Me.C1DBG2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(984, 422)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "预报计划船舶"
        '
        'btVessel
        '
        Me.btVessel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btVessel.Location = New System.Drawing.Point(410, 381)
        Me.btVessel.Name = "btVessel"
        Me.btVessel.Size = New System.Drawing.Size(62, 23)
        Me.btVessel.TabIndex = 42
        Me.btVessel.Text = "航次信息"
        '
        'btShipInport
        '
        Me.btShipInport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btShipInport.Location = New System.Drawing.Point(342, 381)
        Me.btShipInport.Name = "btShipInport"
        Me.btShipInport.Size = New System.Drawing.Size(65, 24)
        Me.btShipInport.TabIndex = 41
        Me.btShipInport.Text = "船舶进港"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.Location = New System.Drawing.Point(154, 383)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 22)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "靠泊时间"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTPBERTH_TIME
        '
        Me.DTPBERTH_TIME.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DTPBERTH_TIME.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DTPBERTH_TIME.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPBERTH_TIME.Location = New System.Drawing.Point(216, 383)
        Me.DTPBERTH_TIME.Name = "DTPBERTH_TIME"
        Me.DTPBERTH_TIME.Size = New System.Drawing.Size(122, 21)
        Me.DTPBERTH_TIME.TabIndex = 38
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.Location = New System.Drawing.Point(2, 383)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 22)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "泊位号"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtBERTHNO
        '
        Me.TxtBERTHNO.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtBERTHNO.Location = New System.Drawing.Point(64, 383)
        Me.TxtBERTHNO.MaxLength = 2
        Me.TxtBERTHNO.Name = "TxtBERTHNO"
        Me.TxtBERTHNO.Size = New System.Drawing.Size(86, 21)
        Me.TxtBERTHNO.TabIndex = 37
        '
        'C1DBG2
        '
        Me.C1DBG2.AllowColMove = False
        Me.C1DBG2.AllowDrag = True
        Me.C1DBG2.AllowFilter = False
        Me.C1DBG2.AllowUpdate = False
        Me.C1DBG2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBG2.ColumnFooters = True
        Me.C1DBG2.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG2.Images.Add(CType(resources.GetObject("C1DBG2.Images"), System.Drawing.Image))
        Me.C1DBG2.Location = New System.Drawing.Point(2, 2)
        Me.C1DBG2.Name = "C1DBG2"
        Me.C1DBG2.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG2.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG2.PreviewInfo.ZoomFactor = 75
        Me.C1DBG2.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG2.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG2.Size = New System.Drawing.Size(984, 369)
        Me.C1DBG2.TabIndex = 2
        Me.C1DBG2.PropBag = resources.GetString("C1DBG2.PropBag")
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnHatch)
        Me.TabPage3.Controls.Add(Me.btNext)
        Me.TabPage3.Controls.Add(Me.btShipQuery)
        Me.TabPage3.Controls.Add(Me.DateTimePicker3)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.DateTimePicker2)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.C1DBG3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(984, 422)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "历史船舶查询"
        '
        'btnHatch
        '
        Me.btnHatch.Enabled = False
        Me.btnHatch.Location = New System.Drawing.Point(462, 6)
        Me.btnHatch.Name = "btnHatch"
        Me.btnHatch.Size = New System.Drawing.Size(75, 23)
        Me.btnHatch.TabIndex = 45
        Me.btnHatch.Text = "相关舱单"
        '
        'btNext
        '
        Me.btNext.Enabled = False
        Me.btNext.Location = New System.Drawing.Point(370, 6)
        Me.btNext.Name = "btNext"
        Me.btNext.Size = New System.Drawing.Size(90, 23)
        Me.btNext.TabIndex = 44
        Me.btNext.Text = "相关现场资料"
        '
        'btShipQuery
        '
        Me.btShipQuery.Location = New System.Drawing.Point(308, 6)
        Me.btShipQuery.Name = "btShipQuery"
        Me.btShipQuery.Size = New System.Drawing.Size(56, 23)
        Me.btShipQuery.TabIndex = 43
        Me.btShipQuery.Text = "查询"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker3.Location = New System.Drawing.Point(210, 6)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(96, 21)
        Me.DateTimePicker3.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(168, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 20)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "日期"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(46, 6)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(96, 21)
        Me.DateTimePicker2.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 20)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "日期"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1DBG3
        '
        Me.C1DBG3.AllowColMove = False
        Me.C1DBG3.AllowDrag = True
        Me.C1DBG3.AllowFilter = False
        Me.C1DBG3.AllowUpdate = False
        Me.C1DBG3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBG3.ColumnFooters = True
        Me.C1DBG3.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG3.Images.Add(CType(resources.GetObject("C1DBG3.Images"), System.Drawing.Image))
        Me.C1DBG3.Location = New System.Drawing.Point(0, 34)
        Me.C1DBG3.Name = "C1DBG3"
        Me.C1DBG3.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG3.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG3.PreviewInfo.ZoomFactor = 75
        Me.C1DBG3.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG3.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG3.Size = New System.Drawing.Size(984, 388)
        Me.C1DBG3.TabIndex = 3
        Me.C1DBG3.PropBag = resources.GetString("C1DBG3.PropBag")
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btUnLock)
        Me.TabPage4.Controls.Add(Me.btSave)
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Controls.Add(Me.btLock)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(984, 422)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "当班人员考勤"
        '
        'btUnLock
        '
        Me.btUnLock.Enabled = False
        Me.btUnLock.Font = New System.Drawing.Font("宋体", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btUnLock.ForeColor = System.Drawing.Color.Red
        Me.btUnLock.Location = New System.Drawing.Point(496, 224)
        Me.btUnLock.Name = "btUnLock"
        Me.btUnLock.Size = New System.Drawing.Size(180, 42)
        Me.btUnLock.TabIndex = 116
        Me.btUnLock.Text = "解除锁定"
        Me.btUnLock.Visible = False
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btSave.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btSave.Location = New System.Drawing.Point(96, 386)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(86, 24)
        Me.btSave.TabIndex = 115
        Me.btSave.Text = "保  存"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.C1DBG4)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 375)
        Me.GroupBox1.TabIndex = 114
        Me.GroupBox1.TabStop = False
        '
        'C1DBG4
        '
        Me.C1DBG4.AllowColMove = False
        Me.C1DBG4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBG4.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG4.Images.Add(CType(resources.GetObject("C1DBG4.Images"), System.Drawing.Image))
        Me.C1DBG4.Location = New System.Drawing.Point(3, 17)
        Me.C1DBG4.Name = "C1DBG4"
        Me.C1DBG4.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG4.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG4.PreviewInfo.ZoomFactor = 75
        Me.C1DBG4.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG4.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG4.Size = New System.Drawing.Size(338, 355)
        Me.C1DBG4.TabIndex = 0
        Me.C1DBG4.PropBag = resources.GetString("C1DBG4.PropBag")
        '
        'btLock
        '
        Me.btLock.Enabled = False
        Me.btLock.Font = New System.Drawing.Font("宋体", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btLock.ForeColor = System.Drawing.Color.Red
        Me.btLock.Location = New System.Drawing.Point(496, 146)
        Me.btLock.Name = "btLock"
        Me.btLock.Size = New System.Drawing.Size(180, 54)
        Me.btLock.TabIndex = 47
        Me.btLock.Text = "锁定考勤派工"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox2)
        Me.TabPage5.Controls.Add(Me.C1DBG5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(984, 422)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "历史派工查询"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.C1DBG5V)
        Me.GroupBox2.Location = New System.Drawing.Point(38, 262)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.Size = New System.Drawing.Size(212, 157)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "船派工信息"
        '
        'C1DBG5V
        '
        Me.C1DBG5V.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBG5V.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG5V.Images.Add(CType(resources.GetObject("C1DBG5V.Images"), System.Drawing.Image))
        Me.C1DBG5V.Location = New System.Drawing.Point(0, 14)
        Me.C1DBG5V.Name = "C1DBG5V"
        Me.C1DBG5V.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG5V.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG5V.PreviewInfo.ZoomFactor = 75
        Me.C1DBG5V.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG5V.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG5V.Size = New System.Drawing.Size(212, 143)
        Me.C1DBG5V.TabIndex = 0
        Me.C1DBG5V.PropBag = resources.GetString("C1DBG5V.PropBag")
        '
        'C1DBG5
        '
        Me.C1DBG5.AllowColMove = False
        Me.C1DBG5.AllowDrag = True
        Me.C1DBG5.AllowFilter = False
        Me.C1DBG5.AllowUpdate = False
        Me.C1DBG5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBG5.ColumnFooters = True
        Me.C1DBG5.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG5.Images.Add(CType(resources.GetObject("C1DBG5.Images"), System.Drawing.Image))
        Me.C1DBG5.Location = New System.Drawing.Point(2, 2)
        Me.C1DBG5.Name = "C1DBG5"
        Me.C1DBG5.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG5.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG5.PreviewInfo.ZoomFactor = 75
        Me.C1DBG5.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG5.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG5.Size = New System.Drawing.Size(984, 257)
        Me.C1DBG5.TabIndex = 4
        Me.C1DBG5.PropBag = resources.GetString("C1DBG5.PropBag")
        '
        'GB
        '
        Me.GB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB.Controls.Add(Me.Button4)
        Me.GB.Controls.Add(Me.DateTimePicker1)
        Me.GB.Controls.Add(Me.btQuery)
        Me.GB.Controls.Add(Me.CmbDIRECTOR)
        Me.GB.Controls.Add(Me.CmbWATCH_DIRECTOR)
        Me.GB.Controls.Add(Me.CmbWeather)
        Me.GB.Controls.Add(Me.CmbDAYNIGHTMARK)
        Me.GB.Controls.Add(Me.CmbWORK_TYPE)
        Me.GB.Controls.Add(Me.CmbDEPT_CODE)
        Me.GB.Controls.Add(Me.DTPWATCHDATE)
        Me.GB.Controls.Add(Me.Label1)
        Me.GB.Controls.Add(Me.Label2)
        Me.GB.Controls.Add(Me.Label4)
        Me.GB.Controls.Add(Me.Label15)
        Me.GB.Controls.Add(Me.Label16)
        Me.GB.Controls.Add(Me.Label20)
        Me.GB.Controls.Add(Me.txtSecurity)
        Me.GB.Controls.Add(Me.TxtWATCH_ID)
        Me.GB.Controls.Add(Me.TxtUSER_NAME)
        Me.GB.Controls.Add(Me.TxtLock_Mark)
        Me.GB.Controls.Add(Me.TxtITEM)
        Me.GB.Controls.Add(Me.Label7)
        Me.GB.Controls.Add(Me.Label19)
        Me.GB.Location = New System.Drawing.Point(4, 4)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(982, 135)
        Me.GB.TabIndex = 2
        Me.GB.TabStop = False
        Me.GB.Text = "值班记录"
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button4.Location = New System.Drawing.Point(922, 94)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 24)
        Me.Button4.TabIndex = 117
        Me.Button4.Text = "保 存"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "HH:mm"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(872, 11)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 29)
        Me.DateTimePicker1.TabIndex = 43
        '
        'btQuery
        '
        Me.btQuery.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btQuery.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btQuery.Image = CType(resources.GetObject("btQuery.Image"), System.Drawing.Image)
        Me.btQuery.Location = New System.Drawing.Point(714, 10)
        Me.btQuery.Name = "btQuery"
        Me.btQuery.Size = New System.Drawing.Size(68, 32)
        Me.btQuery.TabIndex = 42
        Me.btQuery.Text = "确认"
        '
        'CmbDIRECTOR
        '
        Me.CmbDIRECTOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDIRECTOR.Location = New System.Drawing.Point(826, 14)
        Me.CmbDIRECTOR.Name = "CmbDIRECTOR"
        Me.CmbDIRECTOR.Size = New System.Drawing.Size(40, 20)
        Me.CmbDIRECTOR.TabIndex = 41
        Me.CmbDIRECTOR.Visible = False
        '
        'CmbWATCH_DIRECTOR
        '
        Me.CmbWATCH_DIRECTOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbWATCH_DIRECTOR.Location = New System.Drawing.Point(506, 18)
        Me.CmbWATCH_DIRECTOR.Name = "CmbWATCH_DIRECTOR"
        Me.CmbWATCH_DIRECTOR.Size = New System.Drawing.Size(90, 20)
        Me.CmbWATCH_DIRECTOR.TabIndex = 40
        '
        'CmbWeather
        '
        Me.CmbWeather.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbWeather.Location = New System.Drawing.Point(638, 18)
        Me.CmbWeather.Name = "CmbWeather"
        Me.CmbWeather.Size = New System.Drawing.Size(70, 20)
        Me.CmbWeather.TabIndex = 39
        '
        'CmbDAYNIGHTMARK
        '
        Me.CmbDAYNIGHTMARK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDAYNIGHTMARK.Location = New System.Drawing.Point(268, 18)
        Me.CmbDAYNIGHTMARK.Name = "CmbDAYNIGHTMARK"
        Me.CmbDAYNIGHTMARK.Size = New System.Drawing.Size(70, 20)
        Me.CmbDAYNIGHTMARK.TabIndex = 38
        '
        'CmbWORK_TYPE
        '
        Me.CmbWORK_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbWORK_TYPE.Location = New System.Drawing.Point(384, 18)
        Me.CmbWORK_TYPE.Name = "CmbWORK_TYPE"
        Me.CmbWORK_TYPE.Size = New System.Drawing.Size(62, 20)
        Me.CmbWORK_TYPE.TabIndex = 37
        '
        'CmbDEPT_CODE
        '
        Me.CmbDEPT_CODE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDEPT_CODE.Enabled = False
        Me.CmbDEPT_CODE.Location = New System.Drawing.Point(80, 142)
        Me.CmbDEPT_CODE.Name = "CmbDEPT_CODE"
        Me.CmbDEPT_CODE.Size = New System.Drawing.Size(90, 20)
        Me.CmbDEPT_CODE.TabIndex = 36
        Me.CmbDEPT_CODE.Visible = False
        '
        'DTPWATCHDATE
        '
        Me.DTPWATCHDATE.CustomFormat = "yyyy年MM月dd日"
        Me.DTPWATCHDATE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPWATCHDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPWATCHDATE.Location = New System.Drawing.Point(88, 14)
        Me.DTPWATCHDATE.Name = "DTPWATCHDATE"
        Me.DTPWATCHDATE.Size = New System.Drawing.Size(136, 26)
        Me.DTPWATCHDATE.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "当班日期"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(352, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "班别"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(226, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "白夜班"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(450, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 20)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "值班主任"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(1012, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 20)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "接班主任"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label16.Visible = False
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(598, 20)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(38, 20)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "天气"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSecurity
        '
        Me.txtSecurity.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtSecurity.Location = New System.Drawing.Point(99, 80)
        Me.txtSecurity.MaxLength = 250
        Me.txtSecurity.Multiline = True
        Me.txtSecurity.Name = "txtSecurity"
        Me.txtSecurity.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtSecurity.Size = New System.Drawing.Size(820, 51)
        Me.txtSecurity.TabIndex = 7
        '
        'TxtWATCH_ID
        '
        Me.TxtWATCH_ID.Location = New System.Drawing.Point(8, 142)
        Me.TxtWATCH_ID.MaxLength = 4
        Me.TxtWATCH_ID.Name = "TxtWATCH_ID"
        Me.TxtWATCH_ID.ReadOnly = True
        Me.TxtWATCH_ID.Size = New System.Drawing.Size(22, 21)
        Me.TxtWATCH_ID.TabIndex = 34
        Me.TxtWATCH_ID.TabStop = False
        '
        'TxtUSER_NAME
        '
        Me.TxtUSER_NAME.Location = New System.Drawing.Point(32, 142)
        Me.TxtUSER_NAME.MaxLength = 4
        Me.TxtUSER_NAME.Name = "TxtUSER_NAME"
        Me.TxtUSER_NAME.ReadOnly = True
        Me.TxtUSER_NAME.Size = New System.Drawing.Size(22, 21)
        Me.TxtUSER_NAME.TabIndex = 35
        Me.TxtUSER_NAME.TabStop = False
        Me.TxtUSER_NAME.Visible = False
        '
        'TxtLock_Mark
        '
        Me.TxtLock_Mark.Location = New System.Drawing.Point(56, 142)
        Me.TxtLock_Mark.MaxLength = 4
        Me.TxtLock_Mark.Name = "TxtLock_Mark"
        Me.TxtLock_Mark.ReadOnly = True
        Me.TxtLock_Mark.Size = New System.Drawing.Size(22, 21)
        Me.TxtLock_Mark.TabIndex = 35
        Me.TxtLock_Mark.TabStop = False
        Me.TxtLock_Mark.Visible = False
        '
        'TxtITEM
        '
        Me.TxtITEM.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtITEM.Location = New System.Drawing.Point(99, 42)
        Me.TxtITEM.MaxLength = 200
        Me.TxtITEM.Multiline = True
        Me.TxtITEM.Name = "TxtITEM"
        Me.TxtITEM.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtITEM.Size = New System.Drawing.Size(877, 37)
        Me.TxtITEM.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 36)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "交接班事项"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label19.Location = New System.Drawing.Point(4, 82)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 36)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "安全质量  情况日报"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btAttemper
        '
        Me.btAttemper.Enabled = False
        Me.btAttemper.Location = New System.Drawing.Point(546, 154)
        Me.btAttemper.Name = "btAttemper"
        Me.btAttemper.Size = New System.Drawing.Size(78, 22)
        Me.btAttemper.TabIndex = 44
        Me.btAttemper.Text = "船舶派工"
        '
        'btClose
        '
        Me.btClose.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btClose.ForeColor = System.Drawing.Color.Blue
        Me.btClose.Image = CType(resources.GetObject("btClose.Image"), System.Drawing.Image)
        Me.btClose.Location = New System.Drawing.Point(654, 143)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(74, 36)
        Me.btClose.TabIndex = 45
        Me.btClose.Text = "退 出"
        '
        'btShip_Add
        '
        Me.btShip_Add.Location = New System.Drawing.Point(466, 154)
        Me.btShip_Add.Name = "btShip_Add"
        Me.btShip_Add.Size = New System.Drawing.Size(78, 22)
        Me.btShip_Add.TabIndex = 46
        Me.btShip_Add.Text = "增加航次"
        '
        'FrmAttemper_NewMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(994, 594)
        Me.Controls.Add(Me.btShip_Add)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.btAttemper)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GB)
        Me.Name = "FrmAttemper_NewMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "理货部值班调度派工"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GB2.ResumeLayout(False)
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.C1DBG2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.C1DBG3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.C1DBG4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.C1DBG5V, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DBG5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim PGFlag As Integer
    Dim dwShipWorkRecord As New DataView
    Dim dsShipWorkRecord As New DataSet
    Dim ds As New DataSet
    Dim dsPre As New DataSet
    Dim dsPreQ As New DataSet
    Dim dskq As New DataSet
    Dim ds_sub As New DataSet
    Dim dsship As New DataSet
    Dim dstmp As New DataSet
    Dim dw As New DataView
    Dim dwkq As New DataView
    Dim dw_sub As New DataView
    Dim dwship As New DataView
    Dim dwtmp As New DataView
    Dim sqlda As New SqlClient.SqlDataAdapter
    Dim sqldakq As New SqlClient.SqlDataAdapter

    Dim SqlStr As String  '条件语句
    Dim DynaStr As String '可变的条件设计
    Dim FirmStr As String '不变的条件设计
    Dim ResureMark As Integer
    Dim tttt As Integer
    '安全日报部分
    Dim sqlSecurity As String
    Dim dsSecurity As New DataSet
    Dim dvSecurity As New DataView
    Dim dtReportDate As Date
    Dim strDayNight As String

    Private Sub FrmAttemper_NewMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub FrmAttemper_NewMain_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        On Error GoTo Err
        'Me.WindowState = FormWindowState.Maximized
        Call FillWeather()
        Call FillWORK_TYPE()
        Call FillDAYNIGHTMARK()
        Call FillWATCH_DIRECTOR()
        Call FillDIRECTOR()
        'Call FillDEPT_CODE()
        ResureMark = 0
        CmbDAYNIGHTMARK.SelectedValue = "01"
        CmbWORK_TYPE.SelectedValue = "甲"
        DTPWATCHDATE.Focus()
        tttt = 0
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub FillWeather()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "select Code_Weather,Weather from Code_Weather"
        dvc = Getdata(sqldc, dsc)
        CmbWeather.DataSource = dvc
        CmbWeather.DisplayMember = "Weather"
        CmbWeather.ValueMember = "Code_Weather"
    End Sub

    Private Sub FillWORK_TYPE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "SELECT WORK_TYPE FROM WORK_BEGIN WHERE DEPT_CODE='" & G_DeptCode & "' and daynightmark is not null ORDER BY TIME_FROM, DayNightMark"
        dvc = Getdata(sqldc, dsc)
        CmbWORK_TYPE.DataSource = dvc
        CmbWORK_TYPE.DisplayMember = "WORK_TYPE"
        CmbWORK_TYPE.ValueMember = "WORK_TYPE"
    End Sub

    Private Sub FillWATCH_DIRECTOR()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "SELECT Code_Director,Director FROM Code_Director WHERE DEPT_CODE ='" & G_DeptCode & "'"
        dvc = Getdata(sqldc, dsc)
        CmbWATCH_DIRECTOR.DataSource = dvc
        CmbWATCH_DIRECTOR.DisplayMember = "Director"
        CmbWATCH_DIRECTOR.ValueMember = "Code_Director"
    End Sub

    Private Sub FillDIRECTOR()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "SELECT Code_Director,Director FROM Code_Director WHERE DEPT_CODE ='" & G_DeptCode & "'"
        dvc = Getdata(sqldc, dsc)
        CmbDIRECTOR.DataSource = dvc
        CmbDIRECTOR.DisplayMember = "Director"
        CmbDIRECTOR.ValueMember = "Code_Director"
    End Sub

    Private Sub FillDAYNIGHTMARK()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "SELECT Code_WorkTime,WorkTime FROM Code_WorkTime"
        dvc = Getdata(sqldc, dsc)
        CmbDAYNIGHTMARK.DataSource = dvc
        CmbDAYNIGHTMARK.DisplayMember = "WorkTime"
        CmbDAYNIGHTMARK.ValueMember = "Code_WorkTime"
    End Sub

    Private Sub FillDEPT_CODE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "select DEPT_CODE,DEPT_NAME from DEPARTMENT"
        dvc = Getdata(sqldc, dsc)
        CmbDEPT_CODE.DataSource = dvc
        CmbDEPT_CODE.DisplayMember = "DEPT_NAME"
        CmbDEPT_CODE.ValueMember = "DEPT_CODE"
    End Sub

    Private Sub btQuery_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btQuery.Click
        On Error GoTo Err
        Dim i As Integer
        If CmbDAYNIGHTMARK.Text.Trim().Length() > 0 And CmbWORK_TYPE.Text.Trim().Length() > 0 Then
            'If DTPWATCHDATE.Value.Hour.ToString() < 6 Then
            '    SqlStr = "select * from WATCH_RECORD where datediff(dd,WATCHDATE,'" & DTPWATCHDATE.Value & "')=1 and  DEPT_CODE ='" & Trim(G_DeptCode) & "' and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
            'Else
            '    SqlStr = "select * from WATCH_RECORD where datediff(dd,WATCHDATE,'" & DTPWATCHDATE.Value & "')=0 and  DEPT_CODE ='" & Trim(G_DeptCode) & "' and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
            'End If
            SqlStr = "select * from WATCH_RECORD where datediff(dd,WATCHDATE,'" & DTPWATCHDATE.Value & "')=0 and  DEPT_CODE ='" & Trim(G_DeptCode) & "' and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
            dw = Updatedata(sqlda, SqlStr, ds)
            If dw.Count > 0 Then
                PGFlag = 1
                TxtWATCH_ID.Text = ds.Tables(0).Rows(0).Item("WATCH_ID")
                TxtLock_Mark.Text = ds.Tables(0).Rows(0).Item("Lock_Mark")
                TxtUSER_NAME.Text = Trim(G_User)
                CmbDEPT_CODE.SelectedValue = Trim(G_DeptCode)

                'DTPWATCHDATE.Value = ds.Tables(0).Rows(0).Item("WATCHDATE")
                CmbWeather.SelectedValue = ds.Tables(0).Rows(0).Item("WEATHER")
                CmbWORK_TYPE.SelectedValue = ds.Tables(0).Rows(0).Item("WORK_TYPE")
                'CmbDAYNIGHTMARK.SelectedValue = ds.Tables(0).Rows(0).Item("DayNightMark")
                CmbWATCH_DIRECTOR.SelectedValue = ds.Tables(0).Rows(0).Item("WATCH_DIRECTOR")
                CmbDIRECTOR.SelectedValue = ds.Tables(0).Rows(0).Item("DIRECTOR")
                TxtITEM.Text = ds.Tables(0).Rows(0).Item("ITEM")
                CmbWORK_TYPE.Enabled = False
                CmbDAYNIGHTMARK.Enabled = False
                If Trim(Convert.ToString(ds.Tables(0).Rows(0).Item("Lock_Mark"))) = "1" Then
                    btLock.Enabled = False
                    If G_User_Serial.Trim().ToUpper() = "ADMIN" Then
                        btUnLock.Visible = True
                        btUnLock.Enabled = True
                    End If
                Else
                    If G_User_Serial.Trim().ToUpper() = "ADMIN" Then
                        btUnLock.Visible = False
                        btUnLock.Enabled = False
                    End If
                    btLock.Enabled = True
                End If
            Else
                'Dim dstmp1 As New DataSet
                'If Getdata("select * from Code_Director where Depe_code='" & G_DeptCode.Trim() & "' and Work_Type='" & CmbWORK_TYPE.Text.Trim() & "'", dstmp1).Count > 0 Then
                '    CmbWATCH_DIRECTOR.SelectedValue = System.Convert.ToString(dstmp1.Tables(0).Rows(0).Item("Code_Director")).Trim()
                'End If
                CmbWORK_TYPE.Enabled = False
                CmbDAYNIGHTMARK.Enabled = False
                PGFlag = 0
                TxtLock_Mark.Text = "0"
                btLock.Enabled = True
                If G_User_Serial.Trim().ToUpper() = "ADMIN" Then
                    btUnLock.Visible = False
                    btUnLock.Enabled = False
                End If
            End If
            Dim strtmp As String

            'If G_DeptCode Like "26.11.*" Then  //这段代码逻辑混乱
            '    strtmp = "select ITEM from WATCH_RECORD where datediff(dd,WATCHDATE,'" & DTPWATCHDATE.Value & "')=0 and  DEPT_CODE ='" & Trim(G_DeptCode) & "' and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
            '    dwtmp = Getdata(strtmp, dstmp)
            '    If dwtmp.Count > 0 Then
            '        TxtREMARK.Text = TxtREMARK.Text & "  " & dwtmp(0)(0)
            '    End If
            'End If
            '获取安全日报
            dtReportDate = DTPWATCHDATE.Value.Date
            strDayNight = CmbDAYNIGHTMARK.SelectedValue
            sqlSecurity = "select ID,REPORT_DATE,DayNightMark,CODE_DEPARTMENT,RECORD_TIME,USER_NAME,Kind,Brief,Detail " & _
                " from SecurityReport where (CODE_DEPARTMENT = '" & G_DeptCode & "')  and REPORT_DATE='" & dtReportDate & "' and DayNightMark='" & strDayNight & "'"
            dvSecurity = Getdata(sqlSecurity, dsSecurity)
            If dvSecurity.Count > 0 Then
                txtSecurity.Text = dvSecurity(0)("Detail").ToString()
                If dvSecurity.Count > 1 Then
                    MessageBox.Show("本班存在多条安全记录")
                End If
            Else
                txtSecurity.Text = ""
            End If
            Call C11Query()
            Call C12Query()
            If PGFlag = 0 Then
                If MsgBox("请问：要生成 " & CmbDAYNIGHTMARK.Text.Trim() & " 当班 " & CmbWORK_TYPE.Text.Trim() & " 班的考勤簿吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                    Call C14Query()
                End If
            Else
                Call C14Query()
            End If
            Call C15Query()
            ResureMark = 1
            btAttemper.Enabled = True
        Else
            btAttemper.Enabled = False
            ResureMark = 0
            MsgBox("白夜班和班次不能为空！")
        End If
        If btLock.Enabled = False Then
            C1DBG4.Enabled = False
            btSave.Enabled = False
            G_Lock = 1
        Else
            C1DBG4.Enabled = True
            btSave.Enabled = True
            G_Lock = 0
        End If
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub C11Query()
        On Error GoTo Err
        Dim i As Integer
        dsShipWorkRecord.Reset()
        dwShipWorkRecord = Getdata("exec LXJSelectShipWorkRecordNew  '" & DTPWATCHDATE.Value & "','" & CmbDAYNIGHTMARK.SelectedValue & "','" & Trim(G_DeptCode) & "','2'", dsShipWorkRecord)

        If dwShipWorkRecord.Count > 0 Then
            C1DBG.DataSource = dwShipWorkRecord
            C1DBG.Splits(0).DisplayColumns.Item(0).Visible = False
            C1DBG.Columns.Item("DEPT_SHORT").Caption = "部门"
            C1DBG.Columns.Item("BERTHNO").Caption = "泊位"
            C1DBG.Columns.Item("CHI_VESSEL").Caption = "船名"
            C1DBG.Columns.Item("VOYAGE").Caption = "航次"
            C1DBG.Columns.Item("NATIONALITY_CHA").Caption = "国籍"
            C1DBG.Columns.Item("InOutPort_Name").Caption = "进/出"
            C1DBG.Columns.Item("PORT_CHA").Caption = "港名"
            C1DBG.Columns.Item("GOODS_CHA").Caption = "货名"
            C1DBG.Columns.Item("PIECE").Caption = "原配件数"
            C1DBG.Columns.Item("TONS").Caption = "原配吨数"
            C1DBG.Columns.Item("TALLY_CARGO").Caption = "已理件数"
            C1DBG.Columns.Item("TALLY_CARGO_TON").Caption = "已理吨数"
            C1DBG.Columns.Item("REMAIN").Caption = "剩余件数"
            C1DBG.Columns.Item("REMAIN_TON").Caption = "剩余吨数"
            C1DBG.Columns.Item("SHIPAGENT_SHORT").Caption = "船代"
            C1DBG.Columns.Item("BERTH_TIME").Caption = "靠泊时间"
            C1DBG.Columns.Item("WORKTIME_BEGIN").Caption = "开工时间"
            C1DBG.Columns.Item("BERTH_TIME").NumberFormat = "yy/MM/dd HH:mm"
            C1DBG.Columns.Item("WORKTIME_BEGIN").NumberFormat = "yy/MM/dd HH:mm"
            C1DBG.Splits(0).DisplayColumns("WORKTIME_END").Visible = False

            For i = 1 To 17
                C1DBG.Splits(0).DisplayColumns.Item(i).AutoSize()
            Next

            C1DBG.FetchRowStyles = True
            C1DBG.ColumnFooters = True
            C1DBG.FooterStyle.BackColor = Color.PaleTurquoise
            C1DBG.Columns("CHI_VESSEL").FooterText = "合计 " & C1DBG.RowCount & " 条"

            Dim m, num As Integer
            num = 0
            For m = 0 To dwShipWorkRecord.Count - 1
                num = num + dwShipWorkRecord(m)("PIECE")
            Next
            C1DBG.Columns.Item("PIECE").FooterText = CType(num, String)
            num = 0
            For m = 0 To dwShipWorkRecord.Count - 1
                num = num + dwShipWorkRecord(m)("TALLY_CARGO")
            Next
            C1DBG.Columns.Item("TALLY_CARGO").FooterText = CType(num, String)
            num = 0
            For m = 0 To dwShipWorkRecord.Count - 1
                num = num + dwShipWorkRecord(m)("REMAIN")
            Next
            C1DBG.Columns.Item("REMAIN").FooterText = CType(num, String)

            BtnChange.Enabled = True
            BtnMove.Enabled = True
            btnSave.Enabled = True
            Button1.Enabled = True
            Button2.Enabled = True
        Else
            BtnChange.Enabled = False
            BtnMove.Enabled = False
            btnSave.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = False
        End If
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub C12Query()
        On Error GoTo Err
        Dim i As Integer
        dsPre.Reset()
        Dim strsql As String
        strsql = "select * from VIEW_Ship where SHIP_STATU='1' and Dept_Code='" & G_DeptCode & "' order by BerthNo "
        C1DBG2.DataSource = Getdata(strsql, dsPre)

        Table_Name = "VIEW_Ship"
        For i = 0 To 9
            C1DBG2.Splits(0).DisplayColumns.Item(i).Visible = False
        Next
        C1DBG2.Splits(0).DisplayColumns("BERTH_TIME").Visible = False
        C1DBG2.Splits(0).DisplayColumns("WORKTIME_BEGIN").Visible = False
        C1DBG2.Splits(0).DisplayColumns("WORKTIME_END").Visible = False
        C1DBG2.Columns("TONS").NumberFormat = "N"
        Call SetColumnCaption()
        Call SetColumnWidth()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub C14Query()

        GL_Str = CmbDAYNIGHTMARK.SelectedValue
        GL_Time = DTPWATCHDATE.Value
        On Error GoTo Err
        Dim sqlstr As String
        'sqlstr = "select * from ABSENT where (DEPT_CODE = '" & G_DeptCode & "' or DEPT_CODE='26.11.12') and DAYNIGHTMARK='" & GL_Str & "' and datediff(dd,ABSENTDATE,'" & GL_Time & "')=0 and Work_Type in ('甲','乙','丙') ORDER BY DEPT_CODE ,Code_HOLIDAY_TYPE "
        If G_DeptCode = "26.11.11" Then
            sqlstr = "select * from ABSENT where DEPT_CODE like '2_.11.11' and DAYNIGHTMARK='" & GL_Str & "' and datediff(dd,ABSENTDATE,'" & GL_Time & "')=0 and Work_Type in ('甲','乙','丙') ORDER BY DEPT_CODE ,Code_HOLIDAY_TYPE "
        Else
            sqlstr = "select * from ABSENT where DEPT_CODE like '2_.11.12' and DAYNIGHTMARK='" & GL_Str & "' and datediff(dd,ABSENTDATE,'" & GL_Time & "')=0 and Work_Type in ('甲','乙','丙') ORDER BY DEPT_CODE ,Code_HOLIDAY_TYPE "
        End If
        dwkq = Updatedata(sqldakq, sqlstr, dskq)

        If dwkq.Count = 0 Then
            '************* 添加考勤表
            If MsgBox("当班考勤还没有生成，要生成当班考勤记录吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                Dim execsqlstr As String
                Dim dayornight As String
                dayornight = "00"
                If CmbDAYNIGHTMARK.SelectedValue = "01" Then
                    dayornight = "11"
                ElseIf CmbDAYNIGHTMARK.SelectedValue = "02" Then
                    dayornight = "12"
                End If
                If G_DeptCode = "26.11.11" Then
                    execsqlstr = "insert absent(DEPT_CODE, WORK_NO, ABSENTDATE, WORK_TYPE, Code_HOLIDAY_TYPE, "
                    execsqlstr = execsqlstr & "Code_HOLIDAY_Back, DAYNIGHTMARK, Code_workstat,USER_NAME) "
                    execsqlstr = execsqlstr & "select dept_code,work_no,'" & DTPWATCHDATE.Value & "', "
                    execsqlstr = execsqlstr & "tally_team, '" & dayornight & "', '" & dayornight & "','" & Trim(CmbDAYNIGHTMARK.SelectedValue()) & "','02','" & G_User & "' from tally_clerk "
                    execsqlstr = execsqlstr & " where DEPT_CODE like '2_.11.11' and tally_team='" & Trim(CmbWORK_TYPE.SelectedValue()) & "' "
                Else
                    execsqlstr = "insert absent(DEPT_CODE, WORK_NO, ABSENTDATE, WORK_TYPE, Code_HOLIDAY_TYPE, "
                    execsqlstr = execsqlstr & "Code_HOLIDAY_Back, DAYNIGHTMARK, Code_workstat,USER_NAME) "
                    execsqlstr = execsqlstr & "select dept_code,work_no,'" & DTPWATCHDATE.Value & "', "
                    execsqlstr = execsqlstr & "tally_team, '" & dayornight & "', '" & dayornight & "','" & Trim(CmbDAYNIGHTMARK.SelectedValue()) & "','02','" & G_User & "' from tally_clerk "
                    execsqlstr = execsqlstr & " where DEPT_CODE like '2_.11.12' and tally_team='" & Trim(CmbWORK_TYPE.SelectedValue()) & "' "
                End If
                ExecSql(execsqlstr)
            End If
        End If
        dskq.Reset()
        dwkq = Updatedata(sqldakq, sqlstr, dskq)
        If dwkq.Count > 0 Then
            'CmbDEPT_CODE.SelectedValue = dskq.Tables(0).Rows(0).Item("DEPT_CODE")
            'DTPWATCHDATE.Value = dskq.Tables(0).Rows(0).Item("ABSENTDATE")
            'CmbWORK_TYPE.Text = dskq.Tables(0).Rows(0).Item("WORK_TYPE")
            'CmbDAYNIGHTMARK.SelectedValue = dskq.Tables(0).Rows(0).Item("DAYNIGHTMARK")

            '***************定义子表
            Dim i As Integer
            Dim dst As New DataSet
            Dim sqla As New SqlClient.SqlDataAdapter
            Dim sqlc As New SqlClient.SqlCommand

            C1DBG4.DataSource = dwkq

            For i = 0 To C1DBG4.Columns.Count - 1
                C1DBG4.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            C1DBG4.Splits(0).DisplayColumns.Item("dept_code").Visible = True
            C1DBG4.Splits(0).DisplayColumns.Item("WORK_NO").Visible = True
            C1DBG4.Splits(0).DisplayColumns.Item("Code_HOLIDAY_TYPE").Visible = True
            C1DBG4.Splits(0).DisplayColumns.Item("Code_workstat").Visible = True

            C1DBG4.Columns.Item("WORK_NO").Caption = "姓名"
            C1DBG4.Columns.Item("Code_HOLIDAY_TYPE").Caption = "假别"
            C1DBG4.Columns.Item("dept_code").Caption = "部门"
            C1DBG4.Columns.Item("Code_workstat").Caption = "工作状态"

            C1DBG4.Splits(0).DisplayColumns("dept_code").Width = 40
            C1DBG4.Splits(0).DisplayColumns("WORK_NO").Width = 70
            C1DBG4.Splits(0).DisplayColumns("Code_HOLIDAY_TYPE").Width = 80
            C1DBG4.Splits(0).DisplayColumns("Code_workstat").Width = 80
            C1DBG4.Refresh()

            '***************姓名
            C1DBG4.Columns.Item("WORK_NO").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            C1DBG4.Columns.Item("WORK_NO").ValueItems.Translate = True
            C1DBG4.Columns.Item("WORK_NO").ValueItems.Validate = True
            C1DBG4.Splits(0).DisplayColumns.Item("WORK_NO").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT NAME, WORK_NO FROM TALLY_CLERK"
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("NAME"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("WORK_NO"))
                C1DBG4.Columns.Item("WORK_NO").ValueItems.Values.Add(vi)
            Next

            '***************假别
            C1DBG4.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            C1DBG4.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Translate = True
            C1DBG4.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Validate = True
            If G_DeptCode = "26.11" Then
                C1DBG4.Splits(0).DisplayColumns.Item("Code_HOLIDAY_TYPE").AllowFocus = False
            End If
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT Code_Holiday_Type,Holiday_Type FROM Code_Holiday_Type where Code_Holiday_Type<98 order by orderby,convert(int,Code_Holiday_Type) "
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("Holiday_Type"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("Code_Holiday_Type"))
                C1DBG4.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Values.Add(vi)
            Next
            '***************理货部
            C1DBG4.Columns.Item("dept_code").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            C1DBG4.Columns.Item("dept_code").ValueItems.Translate = True
            C1DBG4.Columns.Item("dept_code").ValueItems.Validate = True
            C1DBG4.Splits(0).DisplayColumns.Item("dept_code").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT DEPT_CODE, DEPT_SHORT FROM DEPARTMENT"
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("DEPT_SHORT"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("DEPT_CODE"))
                C1DBG4.Columns.Item("DEPT_CODE").ValueItems.Values.Add(vi)
            Next
            '***************状态
            C1DBG4.Columns.Item("Code_workstat").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            C1DBG4.Columns.Item("Code_workstat").ValueItems.Translate = True
            C1DBG4.Columns.Item("Code_workstat").ValueItems.Validate = True
            'C1DBG.Splits(0).DisplayColumns.Item("Code_workstat").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT Code_workstat,workstat FROM Code_workstat" ' order by convert(int,Code_workstat) "
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("workstat"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("Code_workstat"))
                C1DBG4.Columns.Item("Code_workstat").ValueItems.Values.Add(vi)
            Next
        End If

        CmbDEPT_CODE.Focus()
        If G_DeptCode = "26.11" Then
            btSave.Enabled = False
            CmbDEPT_CODE.Text = "所有理货人员"
        End If
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub C15Query()
        Dim strsql As String
        Dim i As Integer
        FirmStr = " Order by Dept_Code,Ship_Statu"
        'DynaStr = " ( ship_id in (select distinct ship_id from WATCH_RECORD_SHIP where datediff(dd,WATCHSHIPDATE ,'" & DTPWATCHDATE.Value & "')=0 and  DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "') and DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3')) "
        DynaStr = " datediff(dd,WATCHSHIPDATE ,'" & DTPWATCHDATE.Value & "')=0 and  DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "' and DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('0','3','4','5') "
        SqlStr = DynaStr & FirmStr
        strsql = "select * from WATCH_RECORD_Query where " & SqlStr
        dwship = Getdata(strsql, dsship)
        Try
            C1DBG5.DataSource = dwship
            For i = 0 To 4
                C1DBG5.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            C1DBG5.Columns.Item("DEPT_SHORT").Caption = "部门"
            C1DBG5.Columns.Item("BERTHNO").Caption = "泊位"
            C1DBG5.Columns.Item("BERTH_POSITION").Caption = "位置"
            C1DBG5.Columns.Item("CHI_VESSEL").Caption = "船名"
            C1DBG5.Columns.Item("VOYAGE").Caption = "航次"
            C1DBG5.Columns.Item("NATIONALITY_CHA").Caption = "国籍"
            C1DBG5.Columns.Item("InOutPort_Name").Caption = "进/出"
            C1DBG5.Columns.Item("PORT_CHA").Caption = "港名"
            C1DBG5.Columns.Item("GOODS_CHA").Caption = "货名"
            C1DBG5.Columns.Item("PIECE").Caption = "原配件数"
            C1DBG5.Columns.Item("TONS").Caption = "原配吨数"
            C1DBG5.Columns.Item("REMAIN").Caption = "剩余件数"
            C1DBG5.Columns.Item("REMAIN_TON").Caption = "剩余吨数"
            C1DBG5.Columns.Item("SHIPAGENT_SHORT").Caption = "船代"
            C1DBG5.Columns.Item("WATCHSHIPDATE").Caption = "派工时间"
            C1DBG5.Columns.Item("WORKTIME_BEGIN").Caption = "开工时间"
            C1DBG5.Columns.Item("WORKTIME_END").Caption = "完工时间"
            C1DBG5.Columns.Item("tons_sum").Caption = "吨数"
            C1DBG5.Columns.Item("WATCHSHIPDATE").NumberFormat = "yy/MM/dd HH:mm"
            C1DBG5.Columns.Item("WORKTIME_BEGIN").NumberFormat = "yy/MM/dd HH:mm"
            C1DBG5.Columns.Item("WORKTIME_END").NumberFormat = "yy/MM/dd HH:mm"
            For i = 5 To C1DBG5.Columns.Count - 1
                C1DBG5.Splits(0).DisplayColumns.Item(i).AutoSize()
            Next

            'If dsship.Tables(0).Rows.Count > 0 Then
            '    Call SetColumnSum(0)  '设计合计列
            'End If
            C1DBG5.FetchRowStyles = True
            C1DBG5.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        C1DBG5.SelectedStyle.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub SetColumnCaption()
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Try
            str = "select Field_Eng,Field_Cha From Field_Att where Table_Name='" & Table_Name & "'"
            sqlconn.ConnectionString = conn
            sqlc.Connection = sqlconn
            sqlc.CommandText = str
            sqla.SelectCommand = sqlc
            dset.Reset()
            sqla.Fill(dset)
            i = 9

            Do While i < C1DBG2.Columns.Count
                For j = 0 To dset.Tables(0).Rows.Count - 1
                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(C1DBG2.Columns.Item(i).DataField.ToString)) Then
                        C1DBG2.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
                        Exit For
                    End If
                Next
                i = i + 1
            Loop
            sqlconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnWidth()
        Try
            Dim j As Integer
            For j = 0 To C1DBG2.Columns.Count - 1
                C1DBG2.Splits(0).DisplayColumns.Item(j).AutoSize()
                C1DBG2.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                If C1DBG2.Splits(0).DisplayColumns.Item(j).Width < 60 Then
                    C1DBG2.Splits(0).DisplayColumns.Item(j).Width = 60
                Else
                    If C1DBG2.Splits(0).DisplayColumns.Item(j).Width > 130 Then
                        C1DBG2.Splits(0).DisplayColumns.Item(j).Width = 130
                    End If
                End If
            Next

            'C1DBG.Splits(0).DisplayColumns.Item(0).Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far
            C1DBG2.Splits(0).DisplayColumns.Item("VOYAGE").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            C1DBG2.Splits(0).DisplayColumns.Item("Trade").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            C1DBG2.Splits(0).DisplayColumns.Item("InOutPort_Name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            C1DBG2.Splits(0).DisplayColumns.Item("SHIP_TYPE").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            C1DBG2.Splits(0).DisplayColumns.Item("BERTHNO").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btShip_Add_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btShip_Add.Click
        Dim Frm As New FrmSShip_Add
        Frm.ShowDialog()
        Call C12Query()
    End Sub

    Private Sub btAttemper_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btAttemper.Click
        G_Date = DTPWATCHDATE.Value
        G_BB = CmbDAYNIGHTMARK.SelectedValue
        G_BC = CmbWORK_TYPE.SelectedValue
        Dim Frm As New FrmAttemper_PG
        Frm.ShowDialog()
        Call C11Query()
        Call C14Query()
        Call C15Query()
    End Sub

    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btClose.Click
        Try
            If ResureMark = 1 Then
                If PGFlag = 0 Then
                    If MsgBox("值班记录没保存，要保存值班记录吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                        Dim row As DataRow
                        row = ds.Tables(0).NewRow()
                        row("WATCHDATE") = DTPWATCHDATE.Value
                        row("WORK_TYPE") = CmbWORK_TYPE.SelectedValue
                        row("DAYNIGHTMARK") = CmbDAYNIGHTMARK.SelectedValue
                        row("Weather") = CmbWeather.SelectedValue
                        row("WATCH_DIRECTOR") = CmbWATCH_DIRECTOR.SelectedValue
                        row("DIRECTOR") = CmbDIRECTOR.SelectedValue
                        If Len(Trim(TxtITEM.Text)) > 0 Then
                            row("ITEM") = Trim(TxtITEM.Text)
                        End If
                        row("DEPT_CODE") = Trim(G_DeptCode)
                        row("User_Name") = Trim(G_User)
                        row("Lock_Mark") = TxtLock_Mark.Text.Trim()
                        ds.Tables(0).Rows.Add(row)
                        sqlda.Update(ds)
                    End If

                ElseIf PGFlag = 1 Then
                    'ds.Tables(0).Rows(0)("WATCHDATE") = DTPWATCHDATE.Value
                    ds.Tables(0).Rows(0)("WORK_TYPE") = CmbWORK_TYPE.SelectedValue
                    ds.Tables(0).Rows(0)("DAYNIGHTMARK") = CmbDAYNIGHTMARK.SelectedValue
                    ds.Tables(0).Rows(0)("Weather") = CmbWeather.SelectedValue
                    ds.Tables(0).Rows(0)("WATCH_DIRECTOR") = CmbWATCH_DIRECTOR.SelectedValue
                    ds.Tables(0).Rows(0)("DIRECTOR") = CmbDIRECTOR.SelectedValue
                    If Len(Trim(TxtITEM.Text)) > 0 Then
                        ds.Tables(0).Rows(0)("ITEM") = Trim(TxtITEM.Text)
                    End If
                    ds.Tables(0).Rows(0)("DEPT_CODE") = Trim(G_DeptCode)
                    ds.Tables(0).Rows(0)("User_Name") = Trim(G_User)
                    ds.Tables(0).Rows(0)("Lock_Mark") = TxtLock_Mark.Text.Trim()
                    sqlda.Update(ds)
                End If
                GL_Str = CmbDAYNIGHTMARK.SelectedValue
                GL_Time = DTPWATCHDATE.Value

                Dim sqlstr As String
                If G_DeptCode = "26.11.11" Then
                    sqlstr = "select * from ABSENT where DEPT_CODE like '2_.11.11' and DAYNIGHTMARK='" & GL_Str & "' and datediff(dd,ABSENTDATE,'" & GL_Time & "')=0 and Work_Type in ('甲','乙','丙') ORDER BY DEPT_CODE ,Code_HOLIDAY_TYPE "
                Else
                    sqlstr = "select * from ABSENT where DEPT_CODE like '2_.11.12' and DAYNIGHTMARK='" & GL_Str & "' and datediff(dd,ABSENTDATE,'" & GL_Time & "')=0 and Work_Type in ('甲','乙','丙') ORDER BY DEPT_CODE ,Code_HOLIDAY_TYPE "
                End If
                dwkq = Updatedata(sqldakq, sqlstr, dskq)

                If dwkq.Count = 0 Then
                    '************* 添加考勤表
                    If MsgBox("当班考勤还没有生成，要生成当班考勤记录吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                        Dim execsqlstr As String
                        Dim dayornight As String
                        dayornight = "00"
                        If CmbDAYNIGHTMARK.SelectedValue = "01" Then
                            dayornight = "11"
                        ElseIf CmbDAYNIGHTMARK.SelectedValue = "02" Then
                            dayornight = "12"
                        End If
                        execsqlstr = "insert absent(DEPT_CODE, WORK_NO, ABSENTDATE, WORK_TYPE,Code_HOLIDAY_TYPE, "
                        execsqlstr = execsqlstr & "Code_HOLIDAY_Back, DAYNIGHTMARK,Code_workstat,USER_NAME) "
                        execsqlstr = execsqlstr & "select dept_code,work_no,'" & DTPWATCHDATE.Value & "', "
                        execsqlstr = execsqlstr & "tally_team,'" & dayornight & "', '" & dayornight & "','" & CmbDAYNIGHTMARK.SelectedValue & "','02','" & G_User & "' from tally_clerk "
                        execsqlstr = execsqlstr & " where DEPT_CODE like '2_.11.12' and tally_team='" & CmbWORK_TYPE.SelectedValue & "' "

                        ExecSql(execsqlstr)
                    End If
                End If
            End If
            tttt = 1
            Close()
        Catch ex As Exception
            Close()
        End Try
    End Sub

    Private Sub btShipInport_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btShipInport.Click
        Try
            If Len(Trim(TxtBERTHNO.Text)) = 0 And Len(Trim(C1DBG2.Columns.Item("BERTHNO").Text)) > 0 Then
                TxtBERTHNO.Text = C1DBG2.Columns.Item("BERTHNO").Text
            End If
            If Len(Trim(TxtBERTHNO.Text)) > 0 Then
                If MsgBox("你确认要修改吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
                    If IsNumeric(Trim(TxtBERTHNO.Text)) Then
                        'ds.Tables(0).Rows(0).Item("BERTHNO") = Trim(TxtBERTHNO.Text)
                    Else
                        MsgBox("泊位号一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                        Exit Sub
                    End If
                    'ds.Tables(0).Rows(0).Item("BERTH_TIME") = DTPBERTH_TIME.Value
                    'ds.Tables(0).Rows(0).Item("DEPT_CODE") = CmbDEPT_CODE.SelectedValue
                    'ds.Tables(0).Rows(0).Item("SHIP_STATU") = "2"
                    'sqlda.Update(ds)
                    ExecSql("update sship set SHIP_STATU='2',BERTHNO='" & Trim(TxtBERTHNO.Text) & "',BERTH_TIME='" & DTPBERTH_TIME.Value & "'  where ship_id='" & C1DBG2.Columns.Item("ID").Text & "'")
                    Call C11Query()
                    Call C12Query()

                End If
            Else
                MsgBox("泊位号不能为空！")
            End If
            GL_Str = 1
            GL_Time = DTPBERTH_TIME.Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub C1DBG_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles C1DBG.DoubleClick
        Dim dsClerk As New DataSet
        Dim dwClerk As New DataView
        Dim i As Integer

        If G_DeptCode = "26.11" Then
            SqlStr = "select * from TALLY_TEAM where datediff(dd,WORK_DAY,'" & DTPWATCHDATE.Value & "')=0  and DEPT_CODE Like '" & G_DeptCode & "%' and SHIP_ID=" & C1DBG.Columns.Item("SHIP_ID").Text & " and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
            dwClerk = Updatedata(sqlda, SqlStr, dsClerk)
        Else
            SqlStr = "select * from TALLY_TEAM where datediff(dd,WORK_DAY,'" & DTPWATCHDATE.Value & "')=0 and WORK_TYPE='" & CmbWORK_TYPE.SelectedValue & "' and DEPT_CODE ='" & G_DeptCode & "' and SHIP_ID=" & C1DBG.Columns.Item("SHIP_ID").Text & " and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
            dwClerk = Updatedata(sqlda, SqlStr, dsClerk)
        End If
        If dwClerk.Count > 0 Then                       '********* 派工，编辑 
            ID = dwClerk(0)(0)
            GL_Clerk = 1
            C1DBGV.Visible = True
            C1DBGV.Refresh()
        Else
            GL_Clerk = 0
            C1DBGV.Visible = False
            C1DBGV.Refresh()

            MsgBox("此船无派工信息！", MsgBoxStyle.Information, "提示")
            Exit Sub
        End If

        'Dim st As String
        'st = "exec TALLY_CLERK_Query '" & DTPWATCHDATE.Value & "','" & C1DBG.Columns.Item("DEPT_CODE").Text & "','" & CmbWORK_TYPE.SelectedValue & "'," & C1DBG.Columns.Item("SHIP_ID").Text & ",'" & CmbDAYNIGHTMARK.SelectedValue & "'"
        dwClerk = Getdata("exec TALLY_CLERK_Query '" & DTPWATCHDATE.Value & "','" & G_DeptCode & "'," & C1DBG.Columns.Item("SHIP_ID").Text & ",'" & CmbDAYNIGHTMARK.SelectedValue & "'", dsClerk)
        If dwClerk.Count > 0 Then
            C1DBGV.Visible = True

            C1DBGV.DataSource = dwClerk

            C1DBGV.Columns.Item("WORK_NO").Caption = "工号"
            C1DBGV.Columns.Item("Name").Caption = "姓名"
            C1DBGV.Columns.Item("CODE_DUTY").Caption = "职务"
            C1DBGV.Columns.Item("DEPT_CODE").Caption = "部门"

            C1DBGV.Splits(0).DisplayColumns.Item(0).Width = 45
            C1DBGV.Splits(0).DisplayColumns.Item(1).Width = 45
            C1DBGV.Splits(0).DisplayColumns.Item(2).Width = 55
            C1DBGV.Splits(0).DisplayColumns.Item(3).Width = 30

            'Dim i As Integer
            Dim dst As New DataSet
            Dim sqla As New SqlClient.SqlDataAdapter
            Dim sqlc As New SqlClient.SqlCommand
            '***************职务
            C1DBGV.Columns.Item("CODE_DUTY").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            C1DBGV.Columns.Item("CODE_DUTY").ValueItems.Translate = True
            C1DBGV.Columns.Item("CODE_DUTY").ValueItems.Validate = True
            C1DBGV.Splits(0).DisplayColumns.Item("CODE_DUTY").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT CODE_DUTY, DUTY_CHA FROM CODE_DUTY "
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("DUTY_CHA"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("CODE_DUTY"))
                C1DBGV.Columns.Item("CODE_DUTY").ValueItems.Values.Add(vi)
            Next
            '***************部门
            C1DBGV.Columns.Item("DEPT_CODE").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            C1DBGV.Columns.Item("DEPT_CODE").ValueItems.Translate = True
            C1DBGV.Columns.Item("DEPT_CODE").ValueItems.Validate = True
            C1DBGV.Splits(0).DisplayColumns.Item("CODE_DUTY").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT DEPT_CODE, DEPT_SHORT FROM DEPARTMENT "
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("DEPT_SHORT"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("DEPT_CODE"))
                C1DBGV.Columns.Item("DEPT_CODE").ValueItems.Values.Add(vi)
            Next
        Else
            MsgBox("此船无派工信息！", MsgBoxStyle.Information, "提示")
        End If
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btSave.Click
        Try
            'If (txtSecurity.Text.Length < 2) Then
            '    MessageBox.Show("请填报安全质量情况！")
            '    txtSecurity.Focus()
            '    Return
            'End If
            If MsgBox("你确认要保存吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
                sqldakq.Update(dskq)

                'If dvSecurity.Table.Rows.Count = 0 Then
                '    dvSecurity.Table.Rows.Add(dvSecurity.Table.NewRow())
                'Else
                '    dvSecurity.Table.Rows(0)("RECORD_TIME") = Now
                'End If
                'dvSecurity.Table.Rows(0)("CODE_DEPARTMENT") = G_DeptCode
                'dvSecurity.Table.Rows(0)("DayNightMark") = strDayNight
                'dvSecurity.Table.Rows(0)("REPORT_DATE") = dtReportDate
                'dvSecurity.Table.Rows(0)("USER_NAME") = G_User
                'dvSecurity.Table.Rows(0)("Kind") = "1"
                'dvSecurity.Table.Rows(0)("Brief") = ""
                'dvSecurity.Table.Rows(0)("Detail") = txtSecurity.Text
                'RunUpdata(sqlSecurity, dsSecurity)
                'dsSecurity.AcceptChanges()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSave.Click
        Try
            Dim dstmp As New DataSet
            If MsgBox("你确认要选择的船完工了吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
                If SysType = "1" Then
                    ExecSql("update sship set SHIP_STATU='0',WORKTIME_END='" & DTPWORKTIME_END.Value & "'  where ship_id='" & C1DBG.Columns.Item("Ship_ID").Text & "'")
                Else
                    Getdata("select s_trade from sship where ship_id='" & C1DBG.Columns.Item("Ship_ID").Text & "'", dstmp)
                    If dstmp.Tables(0).Rows(0)("s_trade") = 3 Then
                        ExecSql("update sship set SHIP_STATU='4',WORKTIME_END='" & DTPWORKTIME_END.Value & "' where ship_id='" & C1DBG.Columns.Item("Ship_ID").Text & "'")
                    Else
                        '船状态由3作业完改为0待审核
                        ExecSql("update sship set SHIP_STATU='0',WORKTIME_END='" & DTPWORKTIME_END.Value & "' where ship_id='" & C1DBG.Columns.Item("Ship_ID").Text & "'")
                    End If
                    '紫玉兰的信息经常不从此处完船
                    ExecSql("delete from tb_con_instruction where ship_id not in (select ship_id from sship where ship_statu in ('1','2'))")

                    Dim Address() As Net.IPAddress
                    Dim st_log As String
                    Dim a As Integer
                    Dim myname As String
                    Dim ip As String
                    'Address = Net.Dns.GetHostByName(Net.Dns.GetHostName()).AddressList
                    myname = Net.Dns.GetHostName().ToString()
                    Address = Net.Dns.GetHostEntry(myname).AddressList
                    For a = 0 To UBound(Address)
                        ip = ip & Chr(13) & Address(a).ToString()
                    Next
                    st_log = String.Format("insert into con_info(worktype, shipid, cntr, bayno, truckno, ioport, workno, instime, message, dx) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}') ", "tally", Ship_ID, "", "", " ", GL_IOPORT, G_WorkNo, Now.ToString(), myname + "." + ip, "attemper")
                    ExecSql(st_log)
                End If
                Call C11Query()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btShipQuery_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btShipQuery.Click
        On Error GoTo Err
        Dim i As Integer
        dsPreQ.Reset()
        Dim strsql As String
        strsql = "select * from VIEW_Ship where Datediff(dd,WORKTIME_END,'" & DateTimePicker2.Value & "')<=0 and Datediff(dd,WORKTIME_END,'" & DateTimePicker3.Value & "')>=0 and SHIP_STATU in ('3','0','4','5') and Dept_Code='" & G_DeptCode & "' order by BerthNo "
        C1DBG3.DataSource = Getdata(strsql, dsPreQ)

        Table_Name = "VIEW_Ship"
        For i = 0 To 9
            C1DBG3.Splits(0).DisplayColumns.Item(i).Visible = False
        Next
        C1DBG3.Columns("TONS").NumberFormat = "N"
        Call SetColumnCaption3()
        Call SetColumnWidth3()
        C1DBG3.FetchRowStyles = True
        If dsPreQ.Tables(0).Rows.Count > 0 Then
            btNext.Enabled = True
            btnHatch.Enabled = True
        Else
            btNext.Enabled = False
            btnHatch.Enabled = False
        End If
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub SetColumnCaption3()
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Try
            str = "select Field_Eng,Field_Cha From Field_Att where Table_Name='" & Table_Name & "'"
            sqlconn.ConnectionString = conn
            sqlc.Connection = sqlconn
            sqlc.CommandText = str
            sqla.SelectCommand = sqlc
            dset.Reset()
            sqla.Fill(dset)
            i = 9
            Do While i < C1DBG3.Columns.Count
                For j = 0 To dset.Tables(0).Rows.Count - 1
                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(C1DBG3.Columns.Item(i).DataField.ToString)) Then
                        C1DBG3.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
                        Exit For
                    End If
                Next
                i = i + 1
            Loop
            sqlconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnWidth3()
        Try
            Dim j As Integer
            For j = 0 To C1DBG3.Columns.Count - 1
                C1DBG3.Splits(0).DisplayColumns.Item(j).AutoSize()
                C1DBG3.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                If C1DBG3.Splits(0).DisplayColumns.Item(j).Width < 60 Then
                    C1DBG3.Splits(0).DisplayColumns.Item(j).Width = 60
                Else
                    If C1DBG3.Splits(0).DisplayColumns.Item(j).Width > 130 Then
                        C1DBG3.Splits(0).DisplayColumns.Item(j).Width = 130
                    End If
                End If
            Next

            'C1DBG.Splits(0).DisplayColumns.Item(0).Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far
            C1DBG3.Splits(0).DisplayColumns.Item("VOYAGE").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            C1DBG3.Splits(0).DisplayColumns.Item("Trade").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            C1DBG3.Splits(0).DisplayColumns.Item("InOutPort_Name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            C1DBG3.Splits(0).DisplayColumns.Item("SHIP_TYPE").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            C1DBG3.Splits(0).DisplayColumns.Item("BERTHNO").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btNext_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btNext.Click
        TBar = 0
        Mnu = 0
        G_ShipName = C1DBG3.Columns.Item("CHI_VESSEL").Text
        G_Voyage = C1DBG3.Columns.Item("Voyage").Text
        Dim Frm
        If SysType = "1" Then
            Frm = New FrmCargo_onport
        Else
            Frm = New FrmCon_Onport
        End If
        'Frm.MdiParent = Me
        Frm.ShowDialog()
    End Sub

    Private Sub btnHatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHatch.Click
        TBar = 0
        Mnu = 0
        G_ShipName = C1DBG3.Columns.Item("CHI_VESSEL").Text
        G_Voyage = C1DBG3.Columns.Item("Voyage").Text
        Dim Frm
        If SysType = "1" Then
            Frm = New FrmCARGO_HATCH_LIST
        Else
            Frm = New FrmConImageCargo
        End If
        'Frm.MdiParent = Me
        Frm.ShowDialog()
    End Sub

    Private Sub C1DBG5_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG5.DoubleClick
        Dim dsClerk As New DataSet
        Dim dwClerk As New DataView
        Dim i As Integer

        If G_DeptCode = "26.11" Then
            SqlStr = "select * from TALLY_TEAM where datediff(dd,WORK_DAY,'" & DTPWATCHDATE.Value & "')=0  and DEPT_CODE Like '" & G_DeptCode & "%' and SHIP_ID=" & C1DBG5.Columns.Item("SHIP_ID").Text & " and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
            dwClerk = Updatedata(sqlda, SqlStr, dsClerk)
        Else
            SqlStr = "select * from TALLY_TEAM where datediff(dd,WORK_DAY,'" & DTPWATCHDATE.Value & "')=0 and WORK_TYPE='" & CmbWORK_TYPE.SelectedValue & "' and DEPT_CODE ='" & G_DeptCode & "' and SHIP_ID=" & C1DBG5.Columns.Item("SHIP_ID").Text & " and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
            dwClerk = Updatedata(sqlda, SqlStr, dsClerk)
        End If
        If dwClerk.Count > 0 Then                       '********* 派工，编辑 
            ID = dwClerk(0)(0)
            GL_Clerk = 1
            C1DBG5V.Visible = True
            C1DBG5V.Refresh()
        Else
            GL_Clerk = 0
            C1DBG5V.Visible = False
            C1DBG5V.Refresh()
            MsgBox("此船无派工信息！", MsgBoxStyle.Information, "提示")
            Exit Sub
        End If

        'Dim st As String
        'st = "exec TALLY_CLERK_Query '" & DTPWATCHDATE.Value & "','" & C1DBG.Columns.Item("DEPT_CODE").Text & "','" & CmbWORK_TYPE.SelectedValue & "'," & C1DBG.Columns.Item("SHIP_ID").Text & ",'" & CmbDAYNIGHTMARK.SelectedValue & "'"
        dwClerk = Getdata("exec TALLY_CLERK_Query '" & DTPWATCHDATE.Value & "','" & G_DeptCode & "'," & C1DBG5.Columns.Item("SHIP_ID").Text & ",'" & CmbDAYNIGHTMARK.SelectedValue & "'", dsClerk)
        If dwClerk.Count > 0 Then

            C1DBG5V.DataSource = dwClerk

            C1DBG5V.Columns.Item("WORK_NO").Caption = "工号"
            C1DBG5V.Columns.Item("Name").Caption = "姓名"
            C1DBG5V.Columns.Item("CODE_DUTY").Caption = "职务"
            C1DBG5V.Columns.Item("DEPT_CODE").Caption = "部门"

            C1DBG5V.Splits(0).DisplayColumns.Item(0).Width = 45
            C1DBG5V.Splits(0).DisplayColumns.Item(1).Width = 45
            C1DBG5V.Splits(0).DisplayColumns.Item(2).Width = 55
            C1DBG5V.Splits(0).DisplayColumns.Item(3).Width = 30

            'Dim i As Integer
            Dim dst As New DataSet
            Dim sqla As New SqlClient.SqlDataAdapter
            Dim sqlc As New SqlClient.SqlCommand
            '***************职务
            C1DBG5V.Columns.Item("CODE_DUTY").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            C1DBG5V.Columns.Item("CODE_DUTY").ValueItems.Translate = True
            C1DBG5V.Columns.Item("CODE_DUTY").ValueItems.Validate = True
            C1DBG5V.Splits(0).DisplayColumns.Item("CODE_DUTY").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT CODE_DUTY, DUTY_CHA FROM CODE_DUTY "
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("DUTY_CHA"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("CODE_DUTY"))
                C1DBG5V.Columns.Item("CODE_DUTY").ValueItems.Values.Add(vi)
            Next
            '***************部门
            C1DBG5V.Columns.Item("DEPT_CODE").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            C1DBG5V.Columns.Item("DEPT_CODE").ValueItems.Translate = True
            C1DBG5V.Columns.Item("DEPT_CODE").ValueItems.Validate = True
            C1DBG5V.Splits(0).DisplayColumns.Item("CODE_DUTY").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT DEPT_CODE, DEPT_SHORT FROM DEPARTMENT "
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("DEPT_SHORT"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("DEPT_CODE"))
                C1DBG5V.Columns.Item("DEPT_CODE").ValueItems.Values.Add(vi)
            Next
        Else

            MsgBox("此船无派工信息！", MsgBoxStyle.Information, "提示")
        End If
    End Sub

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        e.CellStyle.BackColor = Color.PaleGreen
    End Sub

    Private Sub C1DBG3_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG3.FetchRowStyle
        e.CellStyle.BackColor = Color.LemonChiffon
    End Sub

    Private Sub C1DBG5_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG5.FetchRowStyle
        e.CellStyle.BackColor = Color.LemonChiffon
    End Sub

    Private Sub BtnChange_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnChange.Click
        ID = CType(C1DBG.Columns.Item("Ship_ID").Text, Integer)
        Dim FrmChange As New FrmAttemper_openform2
        FrmChange.ShowDialog()
        Try
            Call C11Query()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnMove_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnMove.Click
        ID = CType(C1DBG.Columns.Item("Ship_ID").Text, Integer)
        Dim FrmMove As New FrmAttemper_openform4
        FrmMove.ShowDialog()
        Try
            Call C11Query()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button2.Click
        TBar = 0
        Mnu = 0
        G_ShipName = C1DBG.Columns.Item("CHI_VESSEL").Text
        G_Voyage = C1DBG.Columns.Item("Voyage").Text
        Dim Frm
        If SysType = "1" Then
            Frm = New FrmCargo_onport
        Else
            Frm = New FrmCon_Onport
        End If
        'Frm.MdiParent = Me
        Frm.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        TBar = 0
        Mnu = 0
        G_ShipName = C1DBG.Columns.Item("CHI_VESSEL").Text
        G_Voyage = C1DBG.Columns.Item("Voyage").Text
        Dim Frm
        If SysType = "1" Then
            Frm = New FrmCARGO_HATCH_LIST
        Else
            Frm = New FrmConImageCargo
        End If
        'Frm.MdiParent = Me
        Frm.ShowDialog()
    End Sub

    Private Sub btLock_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btLock.Click
        Try
            If MsgBox("你要锁定值班记录吗,锁定后派工就不能修改，要修改吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                TxtLock_Mark.Text = "1"
                If ResureMark = 1 Then
                    If PGFlag = 0 Then
                        If MsgBox("值班记录没保存，要保存值班记录吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                            Dim row As DataRow
                            row = ds.Tables(0).NewRow()
                            row("WATCHDATE") = DTPWATCHDATE.Value
                            row("WORK_TYPE") = CmbWORK_TYPE.SelectedValue
                            row("DAYNIGHTMARK") = CmbDAYNIGHTMARK.SelectedValue
                            row("Weather") = CmbWeather.SelectedValue
                            row("WATCH_DIRECTOR") = CmbWATCH_DIRECTOR.SelectedValue
                            row("DIRECTOR") = CmbDIRECTOR.SelectedValue
                            If Len(Trim(TxtITEM.Text)) > 0 Then
                                row("ITEM") = Trim(TxtITEM.Text)
                            End If
                            row("DEPT_CODE") = Trim(G_DeptCode)
                            row("User_Name") = Trim(G_User)
                            row("Lock_Mark") = TxtLock_Mark.Text.Trim()
                            ds.Tables(0).Rows.Add(row)
                            sqlda.Update(ds)
                        End If

                    ElseIf PGFlag = 1 Then
                        'ds.Tables(0).Rows(0)("WATCHDATE") = DTPWATCHDATE.Value
                        ds.Tables(0).Rows(0)("WORK_TYPE") = CmbWORK_TYPE.SelectedValue
                        ds.Tables(0).Rows(0)("DAYNIGHTMARK") = CmbDAYNIGHTMARK.SelectedValue
                        ds.Tables(0).Rows(0)("Weather") = CmbWeather.SelectedValue
                        ds.Tables(0).Rows(0)("WATCH_DIRECTOR") = CmbWATCH_DIRECTOR.SelectedValue
                        ds.Tables(0).Rows(0)("DIRECTOR") = CmbDIRECTOR.SelectedValue
                        If Len(Trim(TxtITEM.Text)) > 0 Then
                            ds.Tables(0).Rows(0)("ITEM") = Trim(TxtITEM.Text)
                        End If
                        ds.Tables(0).Rows(0)("DEPT_CODE") = Trim(G_DeptCode)
                        ds.Tables(0).Rows(0)("User_Name") = Trim(G_User)
                        ds.Tables(0).Rows(0)("Lock_Mark") = TxtLock_Mark.Text.Trim()
                        sqlda.Update(ds)
                    End If
                    GL_Str = CmbDAYNIGHTMARK.SelectedValue
                    GL_Time = DTPWATCHDATE.Value

                    Dim sqlstr_t As String
                    If G_DeptCode = "26.11.11" Then
                        sqlstr_t = "select * from ABSENT where DEPT_CODE like '2_.11.11' and DAYNIGHTMARK='" & GL_Str & "' and datediff(dd,ABSENTDATE,'" & GL_Time & "')=0 and Work_Type in ('甲','乙','丙') ORDER BY DEPT_CODE ,Code_HOLIDAY_TYPE "
                    Else
                        sqlstr_t = "select * from ABSENT where DEPT_CODE like '2_.11.12' and DAYNIGHTMARK='" & GL_Str & "' and datediff(dd,ABSENTDATE,'" & GL_Time & "')=0 and Work_Type in ('甲','乙','丙') ORDER BY DEPT_CODE ,Code_HOLIDAY_TYPE "
                    End If
                    dwkq = Updatedata(sqldakq, sqlstr_t, dskq)

                    If dwkq.Count = 0 Then
                        '************* 添加考勤表
                        If MsgBox("当班考勤还没有生成，要生成当班考勤记录吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                            Dim execsqlstr As String
                            Dim dayornight As String
                            dayornight = "00"
                            If CmbDAYNIGHTMARK.SelectedValue = "01" Then
                                dayornight = "11"
                            ElseIf CmbDAYNIGHTMARK.SelectedValue = "02" Then
                                dayornight = "12"
                            End If
                            execsqlstr = "insert absent(DEPT_CODE, WORK_NO, ABSENTDATE, WORK_TYPE,Code_HOLIDAY_TYPE, "
                            execsqlstr = execsqlstr & "Code_HOLIDAY_Back, DAYNIGHTMARK,Code_workstat,USER_NAME) "
                            execsqlstr = execsqlstr & "select dept_code,work_no,'" & DTPWATCHDATE.Value & "', "
                            execsqlstr = execsqlstr & "tally_team,'" & dayornight & "', '" & dayornight & "','" & CmbDAYNIGHTMARK.SelectedValue & "','02','" & G_User & "' from tally_clerk "
                            execsqlstr = execsqlstr & " where DEPT_CODE like '2_.11.12' and tally_team='" & CmbWORK_TYPE.SelectedValue & "' "
                            ExecSql(execsqlstr)
                        End If
                    End If
                End If
                btLock.Enabled = False
                C1DBG4.Enabled = False
                btSave.Enabled = False
                If G_User_Serial.Trim().ToUpper() = "ADMIN" Then
                    btUnLock.Visible = True
                    btUnLock.Enabled = True
                End If
                G_Lock = 1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmAttemper_NewMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            If tttt = 0 And ResureMark = 1 Then
                If PGFlag = 0 Then
                    If MsgBox("值班记录没保存，要保存值班记录吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                        Dim row As DataRow
                        row = ds.Tables(0).NewRow()
                        row("WATCHDATE") = DTPWATCHDATE.Value
                        row("WORK_TYPE") = CmbWORK_TYPE.SelectedValue
                        row("DAYNIGHTMARK") = CmbDAYNIGHTMARK.SelectedValue
                        row("Weather") = CmbWeather.SelectedValue
                        row("WATCH_DIRECTOR") = CmbWATCH_DIRECTOR.SelectedValue
                        row("DIRECTOR") = CmbDIRECTOR.SelectedValue
                        If Len(Trim(TxtITEM.Text)) > 0 Then
                            row("ITEM") = Trim(TxtITEM.Text)
                        End If
                        'row("Remark") = txtSecurity.Text
                        row("DEPT_CODE") = Trim(G_DeptCode)
                        row("User_Name") = Trim(G_User)
                        row("Lock_Mark") = 0
                        ds.Tables(0).Rows.Add(row)
                        sqlda.Update(ds)
                    End If

                ElseIf PGFlag = 1 Then
                    'ds.Tables(0).Rows(0)("WATCHDATE") = DTPWATCHDATE.Value
                    ds.Tables(0).Rows(0)("WORK_TYPE") = CmbWORK_TYPE.SelectedValue
                    ds.Tables(0).Rows(0)("DAYNIGHTMARK") = CmbDAYNIGHTMARK.SelectedValue
                    ds.Tables(0).Rows(0)("Weather") = CmbWeather.SelectedValue
                    ds.Tables(0).Rows(0)("WATCH_DIRECTOR") = CmbWATCH_DIRECTOR.SelectedValue
                    ds.Tables(0).Rows(0)("DIRECTOR") = CmbDIRECTOR.SelectedValue
                    If Len(Trim(TxtITEM.Text)) > 0 Then
                        ds.Tables(0).Rows(0)("ITEM") = Trim(TxtITEM.Text)
                    End If
                    ds.Tables(0).Rows(0)("DEPT_CODE") = Trim(G_DeptCode)
                    ds.Tables(0).Rows(0)("User_Name") = Trim(G_User)
                    'ds.Tables(0).Rows(0)("Lock_Mark") = 0
                    sqlda.Update(ds)
                End If
                GL_Str = CmbDAYNIGHTMARK.SelectedValue
                GL_Time = DTPWATCHDATE.Value

                Dim sqlstr_t As String
                If G_DeptCode = "26.11.11" Then
                    sqlstr_t = "select * from ABSENT where DEPT_CODE like '2_.11.11' and DAYNIGHTMARK='" & GL_Str & "' and datediff(dd,ABSENTDATE,'" & GL_Time & "')=0 and Work_Type in ('甲','乙','丙') ORDER BY DEPT_CODE ,Code_HOLIDAY_TYPE "
                Else
                    sqlstr_t = "select * from ABSENT where DEPT_CODE like '2_.11.12' and DAYNIGHTMARK='" & GL_Str & "' and datediff(dd,ABSENTDATE,'" & GL_Time & "')=0 and Work_Type in ('甲','乙','丙') ORDER BY DEPT_CODE ,Code_HOLIDAY_TYPE "
                End If
                dwkq = Updatedata(sqldakq, sqlstr_t, dskq)

                If dwkq.Count = 0 Then
                    '************* 添加考勤表
                    If MsgBox("当班考勤还没有生成，要生成当班考勤记录吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                        Dim execsqlstr As String
                        Dim dayornight As String
                        dayornight = "00"
                        If CmbDAYNIGHTMARK.SelectedValue = "01" Then
                            dayornight = "11"
                        ElseIf CmbDAYNIGHTMARK.SelectedValue = "02" Then
                            dayornight = "12"
                        End If
                        execsqlstr = "insert absent(DEPT_CODE, WORK_NO, ABSENTDATE, WORK_TYPE,Code_HOLIDAY_TYPE, "
                        execsqlstr = execsqlstr & "Code_HOLIDAY_Back, DAYNIGHTMARK,Code_workstat,USER_NAME) "
                        execsqlstr = execsqlstr & "select dept_code,work_no,'" & DTPWATCHDATE.Value & "', "
                        execsqlstr = execsqlstr & "tally_team,'" & dayornight & "', '" & dayornight & "','" & CmbDAYNIGHTMARK.SelectedValue & "','02','" & G_User & "' from tally_clerk "
                        execsqlstr = execsqlstr & " where DEPT_CODE like '2_.11.12' and tally_team='" & CmbWORK_TYPE.SelectedValue & "' "
                        ExecSql(execsqlstr)
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btVessel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btVessel.Click
        If dsPre.Tables(0).Rows.Count > 0 Then
            ID = C1DBG2.Columns.Item("id").Text.Trim()
            Dim Frm As New FrmSShip_Edit
            Frm.ShowDialog()
        Else
            MsgBox("没有船可选择!")
        End If
    End Sub

    Private Sub btUnLock_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btUnLock.Click
        Try
            If MsgBox("你要解除锁定值班记录吗,解除锁定后派工就可以修改，要修改吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                TxtLock_Mark.Text = "0"

                ds.Tables(0).Rows(0)("Lock_Mark") = TxtLock_Mark.Text.Trim()
                sqlda.Update(ds)
                btLock.Enabled = True
                C1DBG4.Enabled = True
                btSave.Enabled = True
                G_Lock = 0
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button3.Click
        Call C11Query()
    End Sub

    Private Sub FrmAttemper_NewMain_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        TBar = 1
        Mnu = 1
    End Sub

    Private Sub txtSecurity_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSecurity.Leave
        txtSecurity.Text = txtSecurity.Text.Trim.ToUpper
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If (txtSecurity.Text.Length < 2) Then
            MessageBox.Show("请填报安全质量情况！")
            txtSecurity.Focus()
            Return
        End If
        'If MsgBox("你确认要保存吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
        'End If
        If dvSecurity.Table.Rows.Count = 0 Then
            dvSecurity.Table.Rows.Add(dvSecurity.Table.NewRow())
        Else
            dvSecurity.Table.Rows(0)("RECORD_TIME") = Now
        End If
        dvSecurity.Table.Rows(0)("CODE_DEPARTMENT") = G_DeptCode
        dvSecurity.Table.Rows(0)("DayNightMark") = strDayNight
        dvSecurity.Table.Rows(0)("REPORT_DATE") = dtReportDate
        dvSecurity.Table.Rows(0)("USER_NAME") = G_User
        dvSecurity.Table.Rows(0)("Kind") = "1"
        dvSecurity.Table.Rows(0)("Brief") = ""
        dvSecurity.Table.Rows(0)("Detail") = txtSecurity.Text
        RunUpdata(sqlSecurity, dsSecurity)
        dsSecurity.AcceptChanges()
        MessageBox.Show("安全日报已保存！")
    End Sub
End Class
