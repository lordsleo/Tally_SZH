Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FrmAttemper_Edit
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写处置以清理组件列表。
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

    '注意：以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtREMARK As System.Windows.Forms.TextBox
    Friend WithEvents DTPWATCHDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbWORK_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents CmbWeather As System.Windows.Forms.ComboBox
    Friend WithEvents TxtITEM As System.Windows.Forms.TextBox
    Friend WithEvents CmbWATCH_DIRECTOR As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDIRECTOR As System.Windows.Forms.ComboBox
    Friend WithEvents TxtWATCH_ID As System.Windows.Forms.TextBox
    Friend WithEvents TxtUSER_NAME As System.Windows.Forms.TextBox
    Friend WithEvents CmbDAYNIGHTMARK As System.Windows.Forms.ComboBox
    Friend WithEvents GB1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TxtLock_Mark As System.Windows.Forms.TextBox
    Friend WithEvents CmbMARK_COMPLETE As System.Windows.Forms.ComboBox
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btnLock_Mark As System.Windows.Forms.Button
    Friend WithEvents BtnGetdata As System.Windows.Forms.Button
    Friend WithEvents BtnShip As System.Windows.Forms.Button
    Friend WithEvents BtnChange As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents BtnOver As System.Windows.Forms.Button
    Friend WithEvents TxtTALLY_CARGO As System.Windows.Forms.TextBox
    Friend WithEvents TxtTOTAL_NUM As System.Windows.Forms.TextBox
    Friend WithEvents TxtREMAIN As System.Windows.Forms.TextBox
    Friend WithEvents TxtBERTHNO As System.Windows.Forms.TextBox
    Friend WithEvents TxtCOMPANY_REMARK As System.Windows.Forms.TextBox
    Friend WithEvents TxtDEPT_REMARK As System.Windows.Forms.TextBox
    Friend WithEvents GB2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbNATIONALITY_CODE As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCODE_GOODS As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPIECE As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPIECE As System.Windows.Forms.TextBox
    Friend WithEvents TxtTONS As System.Windows.Forms.TextBox
    Friend WithEvents TxtTICKET As System.Windows.Forms.TextBox
    Friend WithEvents CmbLOAD_UNLOAD_PORT As System.Windows.Forms.ComboBox
    Friend WithEvents CmbINOUTPORT As System.Windows.Forms.ComboBox
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents BtnCLERK As System.Windows.Forms.Button
    Friend WithEvents CmbDEPT_CODE As System.Windows.Forms.ComboBox
    Friend WithEvents BtnMove As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents Btnattendancerecords As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TxtREMAIN_TON As System.Windows.Forms.TextBox
    Friend WithEvents TxtTOTAL_NUM_TON As System.Windows.Forms.TextBox
    Friend WithEvents TxtTALLY_CARGO_TON As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmAttemper_Edit))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Me.GB = New System.Windows.Forms.GroupBox
        Me.btnLock_Mark = New System.Windows.Forms.Button
        Me.CmbDEPT_CODE = New System.Windows.Forms.ComboBox
        Me.DTPWATCHDATE = New System.Windows.Forms.DateTimePicker
        Me.CmbDAYNIGHTMARK = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnQuit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.TxtITEM = New System.Windows.Forms.TextBox
        Me.TxtREMARK = New System.Windows.Forms.TextBox
        Me.CmbWATCH_DIRECTOR = New System.Windows.Forms.ComboBox
        Me.CmbDIRECTOR = New System.Windows.Forms.ComboBox
        Me.CmbWORK_TYPE = New System.Windows.Forms.ComboBox
        Me.TxtWATCH_ID = New System.Windows.Forms.TextBox
        Me.CmbWeather = New System.Windows.Forms.ComboBox
        Me.TxtUSER_NAME = New System.Windows.Forms.TextBox
        Me.TxtLock_Mark = New System.Windows.Forms.TextBox
        Me.Btnattendancerecords = New System.Windows.Forms.Button
        Me.GB2 = New System.Windows.Forms.GroupBox
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.GB1 = New System.Windows.Forms.GroupBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.TxtREMAIN_TON = New System.Windows.Forms.TextBox
        Me.TxtTOTAL_NUM_TON = New System.Windows.Forms.TextBox
        Me.TxtTALLY_CARGO_TON = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.BtnMove = New System.Windows.Forms.Button
        Me.TxtTALLY_CARGO = New System.Windows.Forms.TextBox
        Me.TxtCOMPANY_REMARK = New System.Windows.Forms.TextBox
        Me.TxtDEPT_REMARK = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.BtnShip = New System.Windows.Forms.Button
        Me.TxtTOTAL_NUM = New System.Windows.Forms.TextBox
        Me.TxtREMAIN = New System.Windows.Forms.TextBox
        Me.CmbMARK_COMPLETE = New System.Windows.Forms.ComboBox
        Me.BtnChange = New System.Windows.Forms.Button
        Me.BtnOver = New System.Windows.Forms.Button
        Me.btQuit = New System.Windows.Forms.Button
        Me.BtnCLERK = New System.Windows.Forms.Button
        Me.BtnGetdata = New System.Windows.Forms.Button
        Me.TxtBERTHNO = New System.Windows.Forms.TextBox
        Me.btSave = New System.Windows.Forms.Button
        Me.CmbNATIONALITY_CODE = New System.Windows.Forms.ComboBox
        Me.CmbCODE_GOODS = New System.Windows.Forms.ComboBox
        Me.TxtPIECE = New System.Windows.Forms.TextBox
        Me.TxtTONS = New System.Windows.Forms.TextBox
        Me.TxtTICKET = New System.Windows.Forms.TextBox
        Me.CmbINOUTPORT = New System.Windows.Forms.ComboBox
        Me.CmbLOAD_UNLOAD_PORT = New System.Windows.Forms.ComboBox
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.btAdd = New System.Windows.Forms.Button
        Me.CmbPIECE = New System.Windows.Forms.ComboBox
        Me.GB.SuspendLayout()
        Me.GB2.SuspendLayout()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB
        '
        Me.GB.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GB.Controls.Add(Me.btnLock_Mark)
        Me.GB.Controls.Add(Me.CmbDEPT_CODE)
        Me.GB.Controls.Add(Me.DTPWATCHDATE)
        Me.GB.Controls.Add(Me.CmbDAYNIGHTMARK)
        Me.GB.Controls.Add(Me.Label1)
        Me.GB.Controls.Add(Me.btnQuit)
        Me.GB.Controls.Add(Me.btnSave)
        Me.GB.Controls.Add(Me.Label2)
        Me.GB.Controls.Add(Me.Label4)
        Me.GB.Controls.Add(Me.Label7)
        Me.GB.Controls.Add(Me.Label15)
        Me.GB.Controls.Add(Me.Label16)
        Me.GB.Controls.Add(Me.Label19)
        Me.GB.Controls.Add(Me.Label20)
        Me.GB.Controls.Add(Me.TxtITEM)
        Me.GB.Controls.Add(Me.TxtREMARK)
        Me.GB.Controls.Add(Me.CmbWATCH_DIRECTOR)
        Me.GB.Controls.Add(Me.CmbDIRECTOR)
        Me.GB.Controls.Add(Me.CmbWORK_TYPE)
        Me.GB.Controls.Add(Me.TxtWATCH_ID)
        Me.GB.Controls.Add(Me.CmbWeather)
        Me.GB.Controls.Add(Me.TxtUSER_NAME)
        Me.GB.Controls.Add(Me.TxtLock_Mark)
        Me.GB.Controls.Add(Me.Btnattendancerecords)
        Me.GB.Location = New System.Drawing.Point(0, 0)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(572, 174)
        Me.GB.TabIndex = 0
        Me.GB.TabStop = False
        Me.GB.Text = "值班记录"
        '
        'btnLock_Mark
        '
        Me.btnLock_Mark.Location = New System.Drawing.Point(498, 139)
        Me.btnLock_Mark.Name = "btnLock_Mark"
        Me.btnLock_Mark.Size = New System.Drawing.Size(65, 24)
        Me.btnLock_Mark.TabIndex = 11
        Me.btnLock_Mark.Text = "交班锁定"
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
        Me.DTPWATCHDATE.CustomFormat = "yyyy/MM/dd"
        Me.DTPWATCHDATE.Enabled = False
        Me.DTPWATCHDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPWATCHDATE.Location = New System.Drawing.Point(84, 12)
        Me.DTPWATCHDATE.Name = "DTPWATCHDATE"
        Me.DTPWATCHDATE.Size = New System.Drawing.Size(112, 21)
        Me.DTPWATCHDATE.TabIndex = 0
        '
        'CmbDAYNIGHTMARK
        '
        Me.CmbDAYNIGHTMARK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDAYNIGHTMARK.Enabled = False
        Me.CmbDAYNIGHTMARK.Location = New System.Drawing.Point(268, 35)
        Me.CmbDAYNIGHTMARK.Name = "CmbDAYNIGHTMARK"
        Me.CmbDAYNIGHTMARK.Size = New System.Drawing.Size(114, 20)
        Me.CmbDAYNIGHTMARK.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "日期"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(289, 139)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(65, 24)
        Me.btnQuit.TabIndex = 9
        Me.btnQuit.Text = "取消"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(219, 139)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(65, 24)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "确定"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(202, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "班次"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(202, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "班别"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 36)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "交接班事项"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(387, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 20)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "值班主任"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(387, 35)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 20)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "接班主任"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(6, 94)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 36)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "备注"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(6, 34)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 20)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "天气"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtITEM
        '
        Me.TxtITEM.Location = New System.Drawing.Point(82, 55)
        Me.TxtITEM.MaxLength = 200
        Me.TxtITEM.Multiline = True
        Me.TxtITEM.Name = "TxtITEM"
        Me.TxtITEM.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtITEM.Size = New System.Drawing.Size(488, 37)
        Me.TxtITEM.TabIndex = 6
        Me.TxtITEM.Text = ""
        '
        'TxtREMARK
        '
        Me.TxtREMARK.Location = New System.Drawing.Point(82, 93)
        Me.TxtREMARK.MaxLength = 100
        Me.TxtREMARK.Multiline = True
        Me.TxtREMARK.Name = "TxtREMARK"
        Me.TxtREMARK.ReadOnly = True
        Me.TxtREMARK.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtREMARK.Size = New System.Drawing.Size(488, 37)
        Me.TxtREMARK.TabIndex = 7
        Me.TxtREMARK.Text = ""
        '
        'CmbWATCH_DIRECTOR
        '
        Me.CmbWATCH_DIRECTOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbWATCH_DIRECTOR.Location = New System.Drawing.Point(456, 14)
        Me.CmbWATCH_DIRECTOR.Name = "CmbWATCH_DIRECTOR"
        Me.CmbWATCH_DIRECTOR.Size = New System.Drawing.Size(112, 20)
        Me.CmbWATCH_DIRECTOR.TabIndex = 4
        '
        'CmbDIRECTOR
        '
        Me.CmbDIRECTOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDIRECTOR.Location = New System.Drawing.Point(456, 35)
        Me.CmbDIRECTOR.Name = "CmbDIRECTOR"
        Me.CmbDIRECTOR.Size = New System.Drawing.Size(112, 20)
        Me.CmbDIRECTOR.TabIndex = 5
        '
        'CmbWORK_TYPE
        '
        Me.CmbWORK_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbWORK_TYPE.Location = New System.Drawing.Point(268, 14)
        Me.CmbWORK_TYPE.Name = "CmbWORK_TYPE"
        Me.CmbWORK_TYPE.Size = New System.Drawing.Size(114, 20)
        Me.CmbWORK_TYPE.TabIndex = 2
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
        Me.TxtWATCH_ID.Text = ""
        Me.TxtWATCH_ID.Visible = False
        '
        'CmbWeather
        '
        Me.CmbWeather.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbWeather.Location = New System.Drawing.Point(84, 35)
        Me.CmbWeather.Name = "CmbWeather"
        Me.CmbWeather.Size = New System.Drawing.Size(112, 20)
        Me.CmbWeather.TabIndex = 1
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
        Me.TxtUSER_NAME.Text = ""
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
        Me.TxtLock_Mark.Text = ""
        Me.TxtLock_Mark.Visible = False
        '
        'Btnattendancerecords
        '
        Me.Btnattendancerecords.Location = New System.Drawing.Point(429, 139)
        Me.Btnattendancerecords.Name = "Btnattendancerecords"
        Me.Btnattendancerecords.Size = New System.Drawing.Size(65, 24)
        Me.Btnattendancerecords.TabIndex = 10
        Me.Btnattendancerecords.Text = "考勤"
        '
        'GB2
        '
        Me.GB2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GB2.Controls.Add(Me.C1DBG)
        Me.GB2.Enabled = False
        Me.GB2.Location = New System.Drawing.Point(1, 174)
        Me.GB2.Name = "GB2"
        Me.GB2.Size = New System.Drawing.Size(151, 240)
        Me.GB2.TabIndex = 1
        Me.GB2.TabStop = False
        Me.GB2.Text = "航次信息"
        '
        'C1DBG
        '
        Me.C1DBG.AllowColMove = False
        Me.C1DBG.AllowDrag = True
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1DBG.AllowSort = True
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.CollapseColor = System.Drawing.Color.Black
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.DataChanged = False
        Me.C1DBG.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBG.ExpandColor = System.Drawing.Color.Black
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 14)
        Me.C1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.ShowOptionsDialog = False
        Me.C1DBG.RecordSelectorWidth = 16
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG.RowDivider = GridLines1
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG.ScrollTips = False
        Me.C1DBG.Size = New System.Drawing.Size(148, 224)
        Me.C1DBG.TabIndex = 0
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Style11{}Style12{}Style13{}Style5{}Style4{}Style7{}Style6{}EvenRow{Back" & _
        "Color:Aqua;}Selected{ForeColor:HighlightText;BackColor:Highlight;}Heading{Wrap:T" & _
        "rue;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:" & _
        "Center;}Inactive{ForeColor:InactiveCaptionText;BackColor:InactiveCaption;}Filter" & _
        "Bar{}Footer{}Caption{AlignHorz:Center;}Editor{}Normal{}Style27{}Style26{}Highlig" & _
        "htRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}OddRow{}RecordSelecto" & _
        "r{AlignImage:Center;}Style9{}Style8{}Style3{}Style2{}Group{AlignVert:Center;Bord" & _
        "er:None,,0, 0, 0, 0;BackColor:ControlDark;}Style10{AlignHorz:Near;}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView AllowColMove=""False"" Name="""" CaptionHe" & _
        "ight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" MarqueeStyle=""DottedC" & _
        "ellBorder"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" " & _
        "HorizontalScrollGroup=""1""><ClientRect>0, 0, 144, 220</ClientRect><BorderSide>0</" & _
        "BorderSide><CaptionStyle parent=""Heading"" me=""Style10"" /><EditorStyle parent=""Ed" & _
        "itor"" me=""Style2"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle" & _
        " parent=""FilterBar"" me=""Style27"" /><FooterStyle parent=""Footer"" me=""Style4"" /><G" & _
        "roupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style" & _
        "3"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle paren" & _
        "t=""Inactive"" me=""Style6"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSel" & _
        "ectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selecte" & _
        "d"" me=""Style5"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.Merg" & _
        "eView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal" & _
        """ me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" m" & _
        "e=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=" & _
        """Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Hig" & _
        "hlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""Od" & _
        "dRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=" & _
        """FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</" & _
        "vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16" & _
        "</DefaultRecSelWidth><ClientArea>0, 0, 144, 220</ClientArea></Blob>"
        '
        'GB1
        '
        Me.GB1.Controls.Add(Me.Label21)
        Me.GB1.Controls.Add(Me.Label24)
        Me.GB1.Controls.Add(Me.Label25)
        Me.GB1.Controls.Add(Me.TxtREMAIN_TON)
        Me.GB1.Controls.Add(Me.TxtTOTAL_NUM_TON)
        Me.GB1.Controls.Add(Me.TxtTALLY_CARGO_TON)
        Me.GB1.Controls.Add(Me.Label23)
        Me.GB1.Controls.Add(Me.BtnMove)
        Me.GB1.Controls.Add(Me.TxtTALLY_CARGO)
        Me.GB1.Controls.Add(Me.TxtCOMPANY_REMARK)
        Me.GB1.Controls.Add(Me.TxtDEPT_REMARK)
        Me.GB1.Controls.Add(Me.Label3)
        Me.GB1.Controls.Add(Me.Label5)
        Me.GB1.Controls.Add(Me.Label6)
        Me.GB1.Controls.Add(Me.Label8)
        Me.GB1.Controls.Add(Me.Label9)
        Me.GB1.Controls.Add(Me.Label10)
        Me.GB1.Controls.Add(Me.Label11)
        Me.GB1.Controls.Add(Me.Label12)
        Me.GB1.Controls.Add(Me.Label13)
        Me.GB1.Controls.Add(Me.Label14)
        Me.GB1.Controls.Add(Me.Label17)
        Me.GB1.Controls.Add(Me.Label18)
        Me.GB1.Controls.Add(Me.Label22)
        Me.GB1.Controls.Add(Me.BtnShip)
        Me.GB1.Controls.Add(Me.TxtTOTAL_NUM)
        Me.GB1.Controls.Add(Me.TxtREMAIN)
        Me.GB1.Controls.Add(Me.CmbMARK_COMPLETE)
        Me.GB1.Controls.Add(Me.BtnChange)
        Me.GB1.Controls.Add(Me.BtnOver)
        Me.GB1.Controls.Add(Me.btQuit)
        Me.GB1.Controls.Add(Me.BtnCLERK)
        Me.GB1.Controls.Add(Me.BtnGetdata)
        Me.GB1.Controls.Add(Me.TxtBERTHNO)
        Me.GB1.Controls.Add(Me.btSave)
        Me.GB1.Controls.Add(Me.CmbNATIONALITY_CODE)
        Me.GB1.Controls.Add(Me.CmbCODE_GOODS)
        Me.GB1.Controls.Add(Me.TxtPIECE)
        Me.GB1.Controls.Add(Me.TxtTONS)
        Me.GB1.Controls.Add(Me.TxtTICKET)
        Me.GB1.Controls.Add(Me.CmbINOUTPORT)
        Me.GB1.Controls.Add(Me.CmbLOAD_UNLOAD_PORT)
        Me.GB1.Controls.Add(Me.BtnDelete)
        Me.GB1.Controls.Add(Me.btAdd)
        Me.GB1.Enabled = False
        Me.GB1.Location = New System.Drawing.Point(152, 174)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(422, 240)
        Me.GB1.TabIndex = 2
        Me.GB1.TabStop = False
        Me.GB1.Text = "单船记录"
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(367, 44)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(8, 20)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "/"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(367, 68)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(8, 20)
        Me.Label24.TabIndex = 38
        Me.Label24.Text = "/"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(367, 20)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(8, 20)
        Me.Label25.TabIndex = 39
        Me.Label25.Text = "/"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtREMAIN_TON
        '
        Me.TxtREMAIN_TON.Location = New System.Drawing.Point(375, 67)
        Me.TxtREMAIN_TON.MaxLength = 9
        Me.TxtREMAIN_TON.Name = "TxtREMAIN_TON"
        Me.TxtREMAIN_TON.Size = New System.Drawing.Size(43, 21)
        Me.TxtREMAIN_TON.TabIndex = 36
        Me.TxtREMAIN_TON.Text = ""
        '
        'TxtTOTAL_NUM_TON
        '
        Me.TxtTOTAL_NUM_TON.Location = New System.Drawing.Point(375, 43)
        Me.TxtTOTAL_NUM_TON.MaxLength = 9
        Me.TxtTOTAL_NUM_TON.Name = "TxtTOTAL_NUM_TON"
        Me.TxtTOTAL_NUM_TON.Size = New System.Drawing.Size(43, 21)
        Me.TxtTOTAL_NUM_TON.TabIndex = 35
        Me.TxtTOTAL_NUM_TON.Text = ""
        '
        'TxtTALLY_CARGO_TON
        '
        Me.TxtTALLY_CARGO_TON.Location = New System.Drawing.Point(375, 19)
        Me.TxtTALLY_CARGO_TON.MaxLength = 9
        Me.TxtTALLY_CARGO_TON.Name = "TxtTALLY_CARGO_TON"
        Me.TxtTALLY_CARGO_TON.Size = New System.Drawing.Size(43, 21)
        Me.TxtTALLY_CARGO_TON.TabIndex = 34
        Me.TxtTALLY_CARGO_TON.Text = ""
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(6, 155)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(66, 36)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "理货部备注"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnMove
        '
        Me.BtnMove.Enabled = False
        Me.BtnMove.Location = New System.Drawing.Point(168, 198)
        Me.BtnMove.Name = "BtnMove"
        Me.BtnMove.Size = New System.Drawing.Size(42, 36)
        Me.BtnMove.TabIndex = 17
        Me.BtnMove.Text = "移泊"
        '
        'TxtTALLY_CARGO
        '
        Me.TxtTALLY_CARGO.Location = New System.Drawing.Point(324, 19)
        Me.TxtTALLY_CARGO.MaxLength = 8
        Me.TxtTALLY_CARGO.Name = "TxtTALLY_CARGO"
        Me.TxtTALLY_CARGO.Size = New System.Drawing.Size(42, 21)
        Me.TxtTALLY_CARGO.TabIndex = 8
        Me.TxtTALLY_CARGO.Text = ""
        '
        'TxtCOMPANY_REMARK
        '
        Me.TxtCOMPANY_REMARK.Location = New System.Drawing.Point(72, 115)
        Me.TxtCOMPANY_REMARK.MaxLength = 200
        Me.TxtCOMPANY_REMARK.Multiline = True
        Me.TxtCOMPANY_REMARK.Name = "TxtCOMPANY_REMARK"
        Me.TxtCOMPANY_REMARK.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtCOMPANY_REMARK.Size = New System.Drawing.Size(346, 37)
        Me.TxtCOMPANY_REMARK.TabIndex = 12
        Me.TxtCOMPANY_REMARK.Text = ""
        '
        'TxtDEPT_REMARK
        '
        Me.TxtDEPT_REMARK.Location = New System.Drawing.Point(72, 155)
        Me.TxtDEPT_REMARK.MaxLength = 100
        Me.TxtDEPT_REMARK.Multiline = True
        Me.TxtDEPT_REMARK.Name = "TxtDEPT_REMARK"
        Me.TxtDEPT_REMARK.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtDEPT_REMARK.Size = New System.Drawing.Size(346, 37)
        Me.TxtDEPT_REMARK.TabIndex = 13
        Me.TxtDEPT_REMARK.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(5, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "泊位号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "票数"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 20)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "装卸港名称"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 20)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "进出口"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(140, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 20)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "货类"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(140, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 20)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "原载件数"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(140, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 20)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "原载吨数"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(140, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 20)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "国籍"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(268, 92)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 20)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "本班完船"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(268, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 20)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "余数"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(268, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 20)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "本班理货"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(268, 44)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 20)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "累计数"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(6, 115)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 36)
        Me.Label22.TabIndex = 31
        Me.Label22.Text = "公司备注"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnShip
        '
        Me.BtnShip.Enabled = False
        Me.BtnShip.Location = New System.Drawing.Point(36, 198)
        Me.BtnShip.Name = "BtnShip"
        Me.BtnShip.Size = New System.Drawing.Size(42, 36)
        Me.BtnShip.TabIndex = 14
        Me.BtnShip.Text = "船舶进港"
        '
        'TxtTOTAL_NUM
        '
        Me.TxtTOTAL_NUM.Location = New System.Drawing.Point(324, 43)
        Me.TxtTOTAL_NUM.MaxLength = 8
        Me.TxtTOTAL_NUM.Name = "TxtTOTAL_NUM"
        Me.TxtTOTAL_NUM.Size = New System.Drawing.Size(42, 21)
        Me.TxtTOTAL_NUM.TabIndex = 9
        Me.TxtTOTAL_NUM.Text = ""
        '
        'TxtREMAIN
        '
        Me.TxtREMAIN.Location = New System.Drawing.Point(324, 67)
        Me.TxtREMAIN.MaxLength = 8
        Me.TxtREMAIN.Name = "TxtREMAIN"
        Me.TxtREMAIN.Size = New System.Drawing.Size(42, 21)
        Me.TxtREMAIN.TabIndex = 10
        Me.TxtREMAIN.Text = ""
        '
        'CmbMARK_COMPLETE
        '
        Me.CmbMARK_COMPLETE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMARK_COMPLETE.Location = New System.Drawing.Point(324, 91)
        Me.CmbMARK_COMPLETE.Name = "CmbMARK_COMPLETE"
        Me.CmbMARK_COMPLETE.Size = New System.Drawing.Size(94, 20)
        Me.CmbMARK_COMPLETE.TabIndex = 11
        '
        'BtnChange
        '
        Me.BtnChange.Enabled = False
        Me.BtnChange.Location = New System.Drawing.Point(80, 198)
        Me.BtnChange.Name = "BtnChange"
        Me.BtnChange.Size = New System.Drawing.Size(42, 36)
        Me.BtnChange.TabIndex = 15
        Me.BtnChange.Text = "调整站属"
        '
        'BtnOver
        '
        Me.BtnOver.Enabled = False
        Me.BtnOver.Location = New System.Drawing.Point(124, 198)
        Me.BtnOver.Name = "BtnOver"
        Me.BtnOver.Size = New System.Drawing.Size(42, 36)
        Me.BtnOver.TabIndex = 16
        Me.BtnOver.Text = "船舶完工"
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(344, 198)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(42, 36)
        Me.btQuit.TabIndex = 21
        Me.btQuit.Text = "退出"
        '
        'BtnCLERK
        '
        Me.BtnCLERK.Enabled = False
        Me.BtnCLERK.Location = New System.Drawing.Point(212, 198)
        Me.BtnCLERK.Name = "BtnCLERK"
        Me.BtnCLERK.Size = New System.Drawing.Size(42, 36)
        Me.BtnCLERK.TabIndex = 18
        Me.BtnCLERK.Text = "派工"
        '
        'BtnGetdata
        '
        Me.BtnGetdata.Location = New System.Drawing.Point(6, 194)
        Me.BtnGetdata.Name = "BtnGetdata"
        Me.BtnGetdata.Size = New System.Drawing.Size(18, 22)
        Me.BtnGetdata.TabIndex = 33
        Me.BtnGetdata.Text = "自动取数"
        Me.BtnGetdata.Visible = False
        '
        'TxtBERTHNO
        '
        Me.TxtBERTHNO.Location = New System.Drawing.Point(73, 19)
        Me.TxtBERTHNO.MaxLength = 2
        Me.TxtBERTHNO.Name = "TxtBERTHNO"
        Me.TxtBERTHNO.Size = New System.Drawing.Size(65, 21)
        Me.TxtBERTHNO.TabIndex = 0
        Me.TxtBERTHNO.Text = ""
        '
        'btSave
        '
        Me.btSave.Enabled = False
        Me.btSave.Location = New System.Drawing.Point(256, 198)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(42, 36)
        Me.btSave.TabIndex = 19
        Me.btSave.Text = "保存"
        '
        'CmbNATIONALITY_CODE
        '
        Me.CmbNATIONALITY_CODE.Location = New System.Drawing.Point(196, 19)
        Me.CmbNATIONALITY_CODE.Name = "CmbNATIONALITY_CODE"
        Me.CmbNATIONALITY_CODE.Size = New System.Drawing.Size(70, 20)
        Me.CmbNATIONALITY_CODE.TabIndex = 4
        '
        'CmbCODE_GOODS
        '
        Me.CmbCODE_GOODS.Location = New System.Drawing.Point(196, 43)
        Me.CmbCODE_GOODS.Name = "CmbCODE_GOODS"
        Me.CmbCODE_GOODS.Size = New System.Drawing.Size(70, 20)
        Me.CmbCODE_GOODS.TabIndex = 5
        '
        'TxtPIECE
        '
        Me.TxtPIECE.Location = New System.Drawing.Point(196, 67)
        Me.TxtPIECE.Name = "TxtPIECE"
        Me.TxtPIECE.Size = New System.Drawing.Size(70, 21)
        Me.TxtPIECE.TabIndex = 6
        Me.TxtPIECE.Text = ""
        '
        'TxtTONS
        '
        Me.TxtTONS.Location = New System.Drawing.Point(196, 91)
        Me.TxtTONS.Name = "TxtTONS"
        Me.TxtTONS.Size = New System.Drawing.Size(70, 21)
        Me.TxtTONS.TabIndex = 7
        Me.TxtTONS.Text = ""
        '
        'TxtTICKET
        '
        Me.TxtTICKET.Location = New System.Drawing.Point(73, 67)
        Me.TxtTICKET.MaxLength = 4
        Me.TxtTICKET.Name = "TxtTICKET"
        Me.TxtTICKET.Size = New System.Drawing.Size(65, 21)
        Me.TxtTICKET.TabIndex = 2
        Me.TxtTICKET.Text = ""
        '
        'CmbINOUTPORT
        '
        Me.CmbINOUTPORT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbINOUTPORT.Location = New System.Drawing.Point(73, 43)
        Me.CmbINOUTPORT.Name = "CmbINOUTPORT"
        Me.CmbINOUTPORT.Size = New System.Drawing.Size(65, 20)
        Me.CmbINOUTPORT.TabIndex = 1
        '
        'CmbLOAD_UNLOAD_PORT
        '
        Me.CmbLOAD_UNLOAD_PORT.Location = New System.Drawing.Point(73, 91)
        Me.CmbLOAD_UNLOAD_PORT.Name = "CmbLOAD_UNLOAD_PORT"
        Me.CmbLOAD_UNLOAD_PORT.Size = New System.Drawing.Size(65, 20)
        Me.CmbLOAD_UNLOAD_PORT.TabIndex = 3
        '
        'BtnDelete
        '
        Me.BtnDelete.Enabled = False
        Me.BtnDelete.Location = New System.Drawing.Point(300, 198)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(42, 36)
        Me.BtnDelete.TabIndex = 20
        Me.BtnDelete.Text = "删除"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(6, 216)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(18, 22)
        Me.btAdd.TabIndex = 9
        Me.btAdd.Text = "清空"
        Me.btAdd.Visible = False
        '
        'CmbPIECE
        '
        Me.CmbPIECE.Location = New System.Drawing.Point(174, 68)
        Me.CmbPIECE.Name = "CmbPIECE"
        Me.CmbPIECE.Size = New System.Drawing.Size(98, 20)
        Me.CmbPIECE.TabIndex = 1
        '
        'FrmAttemper_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(574, 415)
        Me.Controls.Add(Me.GB1)
        Me.Controls.Add(Me.GB2)
        Me.Controls.Add(Me.GB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAttemper_Edit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "值班调度_编辑"
        Me.GB.ResumeLayout(False)
        Me.GB2.ResumeLayout(False)
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As New DataSet()
    Dim ds_sub As New DataSet()
    Dim dsship As New DataSet()
    Dim dstmp As New DataSet()
    Dim dw As New DataView()
    Dim dw_sub As New DataView()
    Dim dwship As New DataView()
    Dim dwtmp As New DataView()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim sqlda_sub As New SqlClient.SqlDataAdapter()
    Dim sqldatmp As New SqlClient.SqlDataAdapter()
    Dim PIECE As Integer
    Dim TONS As Double
    Dim TALLY_CARGO As Integer
    Dim TALLY_CARGO_TON As Double
    Dim TALLY_CARGO_his As Integer
    Dim TALLY_CARGO_TON_his As Double
    Dim TOTAL_NUM As Integer
    Dim TOTAL_NUM_TON As Double
    Dim REMAIN As Integer
    Dim REMAIN_TON As Double

    Dim SqlStr As String  '条件语句
    Dim DynaStr As String '可变的条件设计
    Dim FirmStr As String '不变的条件设计

    Private Sub FrmAttemper_Edit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Call FillWeather()
        Call FillWORK_TYPE()
        Call FillDAYNIGHTMARK()
        Call FillWATCH_DIRECTOR()
        Call FillDIRECTOR()
        Call FillDEPT_CODE()
        If G_DeptCode = "26.11" Then
            Label15.Text = "值班调度"
            Label16.Text = "接班调度"
        Else
            Label15.Text = "值班主任"
            Label16.Text = "接班主任"
        End If
        If GL_ID > 0 Then
            btnLock_Mark.Enabled = False
        Else
            btnLock_Mark.Enabled = True
        End If
        SqlStr = "select * from WATCH_RECORD where WATCH_ID=" & ID & " "
        dw = Updatedata(sqlda, SqlStr, ds)
        If dw.Count > 0 Then
            TxtWATCH_ID.Text = ds.Tables(0).Rows(0).Item("WATCH_ID")
            TxtLock_Mark.Text = ds.Tables(0).Rows(0).Item("Lock_Mark")
            TxtUSER_NAME.Text = Trim(G_User)
            CmbDEPT_CODE.SelectedValue = Trim(G_DeptCode)

            DTPWATCHDATE.Value = ds.Tables(0).Rows(0).Item("WATCHDATE")
            CmbWeather.SelectedValue = ds.Tables(0).Rows(0).Item("WEATHER")
            CmbWORK_TYPE.SelectedValue = ds.Tables(0).Rows(0).Item("WORK_TYPE")
            CmbDAYNIGHTMARK.SelectedValue = ds.Tables(0).Rows(0).Item("DayNightMark")
            CmbWATCH_DIRECTOR.SelectedValue = ds.Tables(0).Rows(0).Item("WATCH_DIRECTOR")
            CmbDIRECTOR.SelectedValue = ds.Tables(0).Rows(0).Item("DIRECTOR")
            TxtITEM.Text = ds.Tables(0).Rows(0).Item("ITEM")

            Dim strtmp As String

            If G_DeptCode Like "26.11.*" Then
                strtmp = "select ITEM from WATCH_RECORD where datediff(dd,WATCHDATE,'" & DTPWATCHDATE.Value & "')=0 and  DEPT_CODE ='26.11' and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
                dwtmp = Getdata(strtmp, dstmp)
                If dwtmp.Count > 0 Then
                    TxtREMARK.Text = TxtREMARK.Text & "  " & dwtmp(0)(0)
                End If
            End If
            If G_DeptCode = "26.11" Then
                'Btnattendancerecords.Enabled = False
                'BtnCLERK.Enabled = False
            End If
        End If
        DTPWATCHDATE.Focus()
        Exit Sub
Err:
        Resume Next

    End Sub

    Private Sub myDataGrid(ByVal Sql As String) '**************船舶信息
        Dim strsql As String
        Dim i As Integer
        strsql = "select * from VIEW_WATCH_RECORD_SHIP where " & Sql   '船舶条件语句 不改部分
        dwship = Getdata(strsql, dsship)
        Try
            Me.C1DBG.DataSource = dwship
            For i = 3 To Me.C1DBG.Columns.Count - 1
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Me.C1DBG.Columns.Item(0).Caption = "中文船名"
            Me.C1DBG.Columns.Item(1).Caption = "航次"
            Me.C1DBG.Columns.Item(2).Caption = "DS"
            Me.C1DBG.Splits(0).DisplayColumns.Item(0).Width = 65
            Me.C1DBG.Splits(0).DisplayColumns.Item(1).Width = 42
            Me.C1DBG.Splits(0).DisplayColumns.Item(2).Width = 18
            If dsship.Tables(0).Rows.Count > 0 Then
                Call SetColumnSum(0)  '设计合计列
            End If
            Me.C1DBG.FetchRowStyles = True
            Me.C1DBG.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
    End Sub

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        If Me.C1DBG.Columns("SHIP_STATU").CellValue(e.Row) = 1 Then
            e.CellStyle.BackColor = System.Drawing.Color.White
        End If
        If Me.C1DBG.Columns("SHIP_STATU").CellValue(e.Row) = 2 Then
            e.CellStyle.BackColor = System.Drawing.Color.PaleGreen
        End If
        If Me.C1DBG.Columns("SHIP_STATU").CellValue(e.Row) = 3 Then
            e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
        End If
        If Me.C1DBG.Columns("SHIP_STATU").CellValue(e.Row) = 4 Then
            e.CellStyle.BackColor = System.Drawing.Color.Pink
        End If
    End Sub

    Private Sub SetColumnSum(ByVal Col As Integer) '****************航次汇总行
        Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBG.Columns.Item(Col).FooterText = "共 " & dsship.Tables(0).Rows.Count & " 条"
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try

            SqlStr = "select * from WATCH_RECORD where WATCH_ID=" & ID & ""
            dw = Updatedata(sqlda, SqlStr, ds)

            If MsgBox("你确认要修改值班记录吗？", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "提示") = MsgBoxResult.Yes Then
                Call OperateHistory(G_DeptName, Now, G_User, "修改", "WATCH_RECORD", Trim(TxtWATCH_ID.Text), "WATCH_ID")
                ds.Tables(0).Rows(0).Item("WATCHDATE") = DTPWATCHDATE.Value
                ds.Tables(0).Rows(0).Item("WORK_TYPE") = CmbWORK_TYPE.SelectedValue
                ds.Tables(0).Rows(0).Item("DAYNIGHTMARK") = CmbDAYNIGHTMARK.SelectedValue
                ds.Tables(0).Rows(0).Item("Weather") = CmbWeather.SelectedValue
                ds.Tables(0).Rows(0).Item("WATCH_DIRECTOR") = CmbWATCH_DIRECTOR.SelectedValue
                ds.Tables(0).Rows(0).Item("DIRECTOR") = CmbDIRECTOR.SelectedValue
                If Len(Trim(TxtITEM.Text)) > 0 Then
                    ds.Tables(0).Rows(0).Item("ITEM") = TxtITEM.Text
                End If
                ds.Tables(0).Rows(0).Item("DEPT_CODE") = Trim(G_DeptCode)
                ds.Tables(0).Rows(0).Item("User_Name") = Trim(G_User)
                If btnLock_Mark.Enabled = False Then
                    ds.Tables(0).Rows(0).Item("Lock_Mark") = 1
                Else
                    ds.Tables(0).Rows(0).Item("Lock_Mark") = 0
                End If
                sqlda.Update(ds)


                SqlStr = "SELECT * FROM ABSENT where DEPT_CODE='" & G_DeptCode & "' and datediff(dd,ABSENTDATE,'" & DTPWATCHDATE.Value & "')=0 and DAYNIGHTMARK='" & CmbDAYNIGHTMARK.SelectedValue & "' "
                dwtmp = Getdata(SqlStr, dstmp)
                If dwtmp.Count > 0 Then

                    If dstmp.Tables(0).Rows(0).Item("WORK_TYPE") <> CmbWORK_TYPE.SelectedValue Then
                        Dim execsqlstr As String
                        execsqlstr = "DELETE FROM absent where DEPT_CODE='" & G_DeptCode & "' and WORK_TYPE='" & CmbWORK_TYPE.SelectedValue & "' "
                        ExecSql(execsqlstr)

                        execsqlstr = "insert absent(DEPT_CODE, WORK_NO, ABSENTDATE, WORK_TYPE,Code_HOLIDAY_TYPE, "
                        execsqlstr = execsqlstr & "Code_HOLIDAY_Back, DAYNIGHTMARK, USER_NAME) "
                        execsqlstr = execsqlstr & "select dept_code,work_no,'" & DTPWATCHDATE.Value & "', "
                        execsqlstr = execsqlstr & "tally_team, '98','98','" & CmbDAYNIGHTMARK.SelectedValue & "','" & G_User & "' from tally_clerk "
                        execsqlstr = execsqlstr & " where dept_code='" & G_DeptCode & "' and tally_team='" & CmbWORK_TYPE.SelectedValue & "' "

                        ExecSql(execsqlstr)
                    End If

                End If

                FirmStr = " Order by Ship_Statu,Dept_Code,id desc "  '设计初始条件  在检索后不改变的条件 
                DynaStr = " (DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0) "  '设计其它初始条件    在检索后不需要的条件 ***************要修改 或 其它条件
                SqlStr = DynaStr & FirmStr
                Call myDataGrid(SqlStr)   '*****************调用船舶信息

                btnSave.Enabled = False
                btnQuit.Enabled = False
                GB1.Enabled = True
                GB2.Enabled = True
                DTPWATCHDATE.Enabled = False
                CmbWORK_TYPE.Enabled = False
                CmbDAYNIGHTMARK.Enabled = False
                CmbWeather.Enabled = False
                CmbWATCH_DIRECTOR.Enabled = False
                CmbDIRECTOR.Enabled = False
                TxtITEM.Enabled = False

                If G_DeptCode = "26.11" Then
                    TxtCOMPANY_REMARK.Enabled = True
                    TxtDEPT_REMARK.Enabled = False
                ElseIf G_DeptCode Like "26.11.*" Then
                    TxtCOMPANY_REMARK.Enabled = False
                    TxtDEPT_REMARK.Enabled = True
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnLock_Mark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLock_Mark.Click

        If MsgBox("你确认要交班锁定吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
            SqlStr = "select * from WATCH_RECORD where datediff(dd,WATCHDATE,'" & DTPWATCHDATE.Value & "')=0 and  DEPT_CODE ='" & G_DeptCode & "' and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
            dwtmp = Updatedata(sqlda, SqlStr, dstmp)

            dstmp.Tables(0).Rows(0).Item("Lock_Mark") = 1
            sqlda.Update(dstmp)
            btnLock_Mark.Enabled = False
            dstmp.Reset()

            SqlStr = "select * from WATCH_RECORD"
            dwtmp = Updatedata(sqlda, SqlStr, dstmp)

            Dim nextdate As Date
            Dim worktype As String
            Dim worktime As String
            Dim row As DataRow
            row = dstmp.Tables(0).NewRow()
            If CmbDAYNIGHTMARK.SelectedValue = "01" Then
                row("DAYNIGHTMARK") = "02"
                row("WATCHDATE") = DTPWATCHDATE.Value
                worktime = "02"
                nextdate = DTPWATCHDATE.Value
            Else
                row("DAYNIGHTMARK") = "01"
                row("WATCHDATE") = DateAdd(DateInterval.Day, 1, DTPWATCHDATE.Value)
                worktime = "01"
                nextdate = DateAdd(DateInterval.Day, 1, DTPWATCHDATE.Value)
            End If

            Dim i As Integer
            Dim sqldc As String
            Dim dsc As New DataSet()
            Dim dvc As New DataView()
            sqldc = "SELECT WORK_TYPE FROM WORK_BEGIN WHERE DEPT_CODE='" & G_DeptCode & "' ORDER BY TIME_FROM, DayNightMark"
            dvc = Getdata(sqldc, dsc)
            For i = 0 To dvc.Count - 1
                If i <> dvc.Count - 1 Then
                    If CmbWORK_TYPE.SelectedValue = dsc.Tables(0).Rows(i).Item(0) Then
                        row("WORK_TYPE") = dvc(i + 1)(0)
                        worktype = dvc(i + 1)(0)
                        Exit For
                    End If
                Else
                    row("WORK_TYPE") = dvc(0)(0)
                    worktype = dvc(0)(0)
                End If
            Next

            If Len(Trim(TxtITEM.Text)) > 0 Then
                row("ITEM") = Trim(TxtITEM.Text)
            End If
            row("WATCH_DIRECTOR") = CmbDIRECTOR.SelectedValue
            row("Lock_Mark") = 0
            row("DEPT_CODE") = Trim(G_DeptCode)
            row("User_Name") = Trim(G_User)

            dstmp.Tables(0).Rows.Add(row)
            sqlda.Update(dstmp)

            '************* 添加考勤表
            Dim execsqlstr As String
            Dim dayornight As String
            dayornight = "00"
            If CmbDAYNIGHTMARK.SelectedValue = "01" Then
                dayornight = "12"
            ElseIf CmbDAYNIGHTMARK.SelectedValue = "02" Then
                dayornight = "11"
            End If
            execsqlstr = "insert absent(DEPT_CODE, WORK_NO, ABSENTDATE, WORK_TYPE,Code_HOLIDAY_TYPE, "
            execsqlstr = execsqlstr & "Code_HOLIDAY_Back, DAYNIGHTMARK, Code_workstat,USER_NAME) "
            execsqlstr = execsqlstr & "select dept_code,work_no,'" & nextdate & "', "
            execsqlstr = execsqlstr & "tally_team, '" & dayornight & "', '" & dayornight & "','" & worktime & "','02','" & G_User & "' from tally_clerk "
            execsqlstr = execsqlstr & " where dept_code='" & G_DeptCode & "' and tally_team='" & worktype & "' "

            ExecSql(execsqlstr)
            Me.Close()
        End If

    End Sub

    Private Sub C1DBG_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1DBG.DoubleClick
        On Error GoTo Err
        Dim i As Integer
        Dim statu As Integer
        Dim dssp As New DataSet()
        Dim dvsp As New DataView()

        GB1.Text = "单船记录： " & Me.C1DBG.Columns.Item(0).Text & " " & Me.C1DBG.Columns.Item(1).Text

        Call FillINOUTPORT()
        Call FillLOAD_UNLOAD_PORT()
        Call FillNATIONALITY_CODE()
        Call FillCODE_GOODS()
        Call FillMARK_COMPLETE()

        ID = CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Integer)
        statu = CType(Me.C1DBG.Columns.Item("SHIP_STATU").Text.ToString, Integer)

        BtnShip.Enabled = False
        BtnChange.Enabled = False
        BtnOver.Enabled = False
        BtnMove.Enabled = False
        BtnCLERK.Enabled = True

        If G_DeptCode = "26.11" Then
            If statu <> 1 Then
                BtnChange.Enabled = True
                BtnMove.Enabled = True
                'BtnCLERK.Enabled = True
            End If
        Else
            If statu = 1 Then
                BtnShip.Enabled = True
            End If
            If statu = 2 Then
                BtnOver.Enabled = True
                'BtnCLERK.Enabled = True
            End If
        End If

        btSave.Enabled = True

        SqlStr = "select * from WATCH_RECORD_SHIP where SHIP_ID=" & ID & "  order by WATCHSHIPDATE desc"
        dwtmp = Getdata(SqlStr, dstmp)
        If dwtmp.Count > 0 Then
            TxtTICKET.Text = dstmp.Tables(0).Rows(0).Item("TICKET")
            TxtPIECE.Text = dstmp.Tables(0).Rows(0).Item("PIECE")
            TxtTONS.Text = dstmp.Tables(0).Rows(0).Item("TONS")
        End If


        SqlStr = "select * from WATCH_RECORD_SHIP where SHIP_ID=" & ID & " and datediff(dd,WATCHSHIPDATE ,'" & DTPWATCHDATE.Value & "')=0 and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
        dwtmp = Getdata(SqlStr, dstmp)
        If dwtmp.Count > 0 Then  '存在对应航次的值班单船记录，提取
            If Len(Trim(dstmp.Tables(0).Rows(0).Item("BERTHNO"))) > 0 Then
                TxtBERTHNO.Text = Trim(dstmp.Tables(0).Rows(0).Item("BERTHNO"))
            Else
                TxtBERTHNO.Text = ""
            End If
            CmbINOUTPORT.SelectedValue = dstmp.Tables(0).Rows(0).Item("INOUTPORT")
            CmbLOAD_UNLOAD_PORT.SelectedValue = dstmp.Tables(0).Rows(0).Item("LOAD_UNLOAD_PORT")
            CmbNATIONALITY_CODE.SelectedValue = dstmp.Tables(0).Rows(0).Item("NATIONALITY_CODE")
            CmbCODE_GOODS.SelectedValue = dstmp.Tables(0).Rows(0).Item("CODE_GOODS")
            TxtTALLY_CARGO.Text = dstmp.Tables(0).Rows(0).Item("TALLY_CARGO")
            TxtTALLY_CARGO_TON.Text = dstmp.Tables(0).Rows(0).Item("TALLY_CARGO_TON")
            TxtTOTAL_NUM.Text = dstmp.Tables(0).Rows(0).Item("TOTAL_NUM")
            TxtTOTAL_NUM_TON.Text = dstmp.Tables(0).Rows(0).Item("TOTAL_NUM_TON")
            TxtREMAIN.Text = dstmp.Tables(0).Rows(0).Item("REMAIN")
            TxtREMAIN_TON.Text = dstmp.Tables(0).Rows(0).Item("REMAIN_TON")
            CmbMARK_COMPLETE.SelectedValue = dstmp.Tables(0).Rows(0).Item("MARK_COMPLETE")
            TxtCOMPANY_REMARK.Text = dstmp.Tables(0).Rows(0).Item("COMPANY_REMARK")
            TxtDEPT_REMARK.Text = dstmp.Tables(0).Rows(0).Item("DEPT_REMARK")
            If G_DeptCode = "26.11" Then  '填充公司备注
                If Len(Trim(TxtCOMPANY_REMARK.Text)) = 0 Then
                    If CmbDAYNIGHTMARK.SelectedValue = "01" Then
                        SqlStr = "select Company_REMARK from WATCH_RECORD_SHIP where SHIP_ID=" & ID & " and datediff(dd,WATCHSHIPDATE, DateAdd(DateInterval.Day, -1, '" & DTPWATCHDATE.Value & "'))=0 and DayNightMark='02' "
                        dwtmp = Getdata(SqlStr, dstmp)
                        TxtCOMPANY_REMARK.Text = dstmp.Tables(0).Rows(0).Item(0)
                    ElseIf CmbDAYNIGHTMARK.SelectedValue = "02" Then
                        SqlStr = "select Company_REMARK from WATCH_RECORD_SHIP where SHIP_ID=" & ID & " and datediff(dd,WATCHSHIPDATE, '" & DTPWATCHDATE.Value & "' and DayNightMark='01' "
                        dwtmp = Getdata(SqlStr, dstmp)
                        TxtCOMPANY_REMARK.Text = dstmp.Tables(0).Rows(0).Item(0)
                    End If
                End If
            ElseIf G_DeptCode Like "26.11.*" Then  '填充部门备注
                If Len(Trim(TxtDEPT_REMARK.Text)) = 0 Then
                    If CmbDAYNIGHTMARK.SelectedValue = "01" Then
                        SqlStr = "select Dept_Remark from WATCH_RECORD_SHIP where SHIP_ID=" & ID & " and datediff(dd,WATCHSHIPDATE, DateAdd(DateInterval.Day, -1, '" & DTPWATCHDATE.Value & "'))=0 and DayNightMark='02' "
                        dwtmp = Getdata(SqlStr, dstmp)
                        TxtDEPT_REMARK.Text = dstmp.Tables(0).Rows(0).Item(0)
                    ElseIf CmbDAYNIGHTMARK.SelectedValue = "02" Then
                        SqlStr = "select Dept_Remark from WATCH_RECORD_SHIP where SHIP_ID=" & ID & " and datediff(dd,WATCHSHIPDATE, '" & DTPWATCHDATE.Value & "' and DayNightMark='01' "
                        dwtmp = Getdata(SqlStr, dstmp)
                        TxtDEPT_REMARK.Text = dstmp.Tables(0).Rows(0).Item(0)
                    End If
                End If
            End If
            BtnDelete.Enabled = True
        Else                     '不存在对应航次的值班单船记录，新增
            BtnDelete.Enabled = False
            SqlStr = "select * from VIEW_WATCH_RECORD_SHIP where SHIP_ID=" & ID & ""
            dwtmp = Updatedata(sqlda, SqlStr, dstmp)
            If dwtmp.Count > 0 Then
                If Len(Trim(dstmp.Tables(0).Rows(0).Item("BERTHNO"))) > 0 Then
                    TxtBERTHNO.Text = Trim(dstmp.Tables(0).Rows(0).Item("BERTHNO"))
                Else
                    TxtBERTHNO.Text = ""
                End If
                CmbINOUTPORT.SelectedValue = dstmp.Tables(0).Rows(0).Item("INOUTPORT")
                CmbNATIONALITY_CODE.SelectedValue = dstmp.Tables(0).Rows(0).Item("NATIONALITY_CODE")
                CmbCODE_GOODS.SelectedValue = dstmp.Tables(0).Rows(0).Item("CODE_GOODS")

                TxtTALLY_CARGO.Text = ""
                TxtTALLY_CARGO_TON.Text = ""
                TxtTOTAL_NUM.Text = ""
                TxtTOTAL_NUM_TON.Text = ""
                TxtREMAIN.Text = ""
                TxtREMAIN_TON.Text = ""

                CmbMARK_COMPLETE.SelectedValue = "01"
                dvsp = Getdata("exec sp_WATCH_RECORD_SHIP '" & ID & "','" & CmbINOUTPORT.SelectedValue & "'", dssp)
                'TxtTICKET.Text = dssp.Tables(0).Rows(0).Item(0)
                'TxtPIECE.Text = dssp.Tables(0).Rows(0).Item(1)
                'TxtTONS.Text = dssp.Tables(0).Rows(0).Item(2)
                CmbLOAD_UNLOAD_PORT.SelectedValue = dssp.Tables(0).Rows(0).Item(3)

                TxtCOMPANY_REMARK.Text = ""
                TxtDEPT_REMARK.Text = ""
                If G_DeptCode = "26.11" Then    '填充公司备注
                    If CmbDAYNIGHTMARK.SelectedValue = "01" Then
                        SqlStr = "select Company_REMARK from WATCH_RECORD_SHIP where SHIP_ID=" & ID & " and datediff(dd,WATCHSHIPDATE, DateAdd(DateInterval.Day, -1, '" & DTPWATCHDATE.Value & "'))=0 and DayNightMark='02' "
                        dwtmp = Getdata(SqlStr, dstmp)
                        TxtCOMPANY_REMARK.Text = dstmp.Tables(0).Rows(0).Item(0)
                    ElseIf CmbDAYNIGHTMARK.SelectedValue = "02" Then
                        SqlStr = "select Company_REMARK from WATCH_RECORD_SHIP where SHIP_ID=" & ID & " and datediff(dd,WATCHSHIPDATE, '" & DTPWATCHDATE.Value & "' and DayNightMark='01' "
                        dwtmp = Getdata(SqlStr, dstmp)
                        TxtCOMPANY_REMARK.Text = dstmp.Tables(0).Rows(0).Item(0)
                    End If
                ElseIf G_DeptCode Like "26.11.*" Then        '填充部门备注
                    If CmbDAYNIGHTMARK.SelectedValue = "01" Then
                        SqlStr = "select Dept_Remark from WATCH_RECORD_SHIP where SHIP_ID=" & ID & " and datediff(dd,WATCHSHIPDATE, DateAdd(DateInterval.Day, -1, '" & DTPWATCHDATE.Value & "'))=0 and DayNightMark='02' "
                        dwtmp = Getdata(SqlStr, dstmp)
                        TxtDEPT_REMARK.Text = dstmp.Tables(0).Rows(0).Item(0)
                    ElseIf CmbDAYNIGHTMARK.SelectedValue = "02" Then
                        SqlStr = "select Dept_Remark from WATCH_RECORD_SHIP where SHIP_ID=" & ID & " and datediff(dd,WATCHSHIPDATE, '" & DTPWATCHDATE.Value & "' and DayNightMark='01' "
                        dwtmp = Getdata(SqlStr, dstmp)
                        TxtDEPT_REMARK.Text = dstmp.Tables(0).Rows(0).Item(0)
                    End If
                End If
            End If
        End If
        If Len(Trim(TxtTALLY_CARGO.Text)) = 0 Then
            TALLY_CARGO_his = 0
        Else
            TALLY_CARGO_his = Trim(TxtTALLY_CARGO.Text)
        End If
        If Len(Trim(TxtTALLY_CARGO_TON.Text)) = 0 Then
            TALLY_CARGO_TON_his = 0
        Else
            TALLY_CARGO_TON_his = Trim(TxtTALLY_CARGO_TON.Text)
        End If
        Call FillGetdata()
Err:
        Resume Next
    End Sub

    Private Sub FillGetdata()
        Dim dssp As New DataSet()
        Dim dvsp As New DataView()
        If Len(Trim(TxtPIECE.Text)) = 0 Or IsDBNull(TxtPIECE.Text) = True Then
            PIECE = 0
        Else
            PIECE = Trim(TxtPIECE.Text)
        End If
        If Len(Trim(TxtTONS.Text)) = 0 Or IsDBNull(TxtTONS.Text) = True Then
            TONS = 0
        Else
            TONS = Trim(TxtTONS.Text)
        End If

        If Len(Trim(TxtTALLY_CARGO.Text)) = 0 Or IsDBNull(TxtTALLY_CARGO.Text) = True Then
            TALLY_CARGO = 0
            TxtTALLY_CARGO.Text = 0
        Else
            TALLY_CARGO = Trim(TxtTALLY_CARGO.Text)
        End If
        If Len(Trim(TxtTALLY_CARGO_TON.Text)) = 0 Or IsDBNull(TxtTALLY_CARGO_TON.Text) = True Then
            TALLY_CARGO_TON = 0
            TxtTALLY_CARGO_TON.Text = 0
        Else
            TALLY_CARGO_TON = Trim(TxtTALLY_CARGO_TON.Text)
        End If
        TALLY_CARGO = TALLY_CARGO - TALLY_CARGO_his
        TALLY_CARGO_TON = TALLY_CARGO_TON - TALLY_CARGO_TON_his

        dvsp = Getdata("exec get_date '" & ID & "','" & CmbDAYNIGHTMARK.SelectedValue & "','" & DTPWATCHDATE.Value & "', '" & TALLY_CARGO & "', '" & TALLY_CARGO_TON & "', '" & PIECE & "', '" & TONS & "'", dssp)
        TxtTOTAL_NUM.Text = IIf(dssp.Tables(0).Rows(0).Item(0) < 0, 0, dssp.Tables(0).Rows(0).Item(0))
        TxtTOTAL_NUM_TON.Text = IIf(dssp.Tables(0).Rows(0).Item(1) < 0, 0, dssp.Tables(0).Rows(0).Item(1))
        TxtREMAIN.Text = IIf(dssp.Tables(0).Rows(0).Item(2) < 0, 0, dssp.Tables(0).Rows(0).Item(2))
        TxtREMAIN_TON.Text = IIf(dssp.Tables(0).Rows(0).Item(3) < 0, 0, dssp.Tables(0).Rows(0).Item(3))

    End Sub

    Private Sub TxtTALLY_CARGO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTALLY_CARGO.Leave
        Call FillGetdata()
    End Sub

    Private Sub TxtTALLY_CARGO_TON_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTALLY_CARGO_TON.Leave
        Call FillGetdata()
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            SqlStr = "select * from WATCH_RECORD_SHIP where datediff(dd,WATCHSHIPDATE,'" & DTPWATCHDATE.Value & "')=0 and  SHIP_ID=" & ID & " and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
            dw_sub = Updatedata(sqlda_sub, SqlStr, ds_sub)
            If dw_sub.Count > 0 Then
                If Len(Trim(TxtBERTHNO.Text)) > 0 Then
                    If CmbCODE_GOODS.SelectedValue <> "00" Then
                        If MsgBox("你确认要修改本单船记录吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then

                            ds_sub.Tables(0).Rows(0).Item("SHIP_ID") = ID
                            ds_sub.Tables(0).Rows(0).Item("WATCHSHIPDATE") = DTPWATCHDATE.Value
                            ds_sub.Tables(0).Rows(0).Item("DAYNIGHTMARK") = CmbDAYNIGHTMARK.SelectedValue
                            If Len(Trim(TxtBERTHNO.Text)) > 0 Then
                                If IsNumeric(Trim(TxtBERTHNO.Text)) Then
                                    ds_sub.Tables(0).Rows(0).Item("BERTHNO") = Trim(TxtBERTHNO.Text)
                                Else
                                    MsgBox("泊位号一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                                    Exit Sub
                                End If
                            End If
                            ds_sub.Tables(0).Rows(0).Item("CODE_GOODS") = CmbCODE_GOODS.SelectedValue
                            If Len(Trim(TxtTICKET.Text)) > 0 Then
                                If IsNumeric(Trim(TxtTICKET.Text)) Then
                                    ds_sub.Tables(0).Rows(0).Item("TICKET") = Trim(TxtTICKET.Text)
                                Else
                                    MsgBox("票数一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                                    Exit Sub
                                End If
                            End If
                            ds_sub.Tables(0).Rows(0).Item("LOAD_UNLOAD_PORT") = CmbLOAD_UNLOAD_PORT.SelectedValue
                            ds_sub.Tables(0).Rows(0).Item("INOUTPORT") = CmbINOUTPORT.SelectedValue
                            ds_sub.Tables(0).Rows(0).Item("NATIONALITY_CODE") = CmbNATIONALITY_CODE.SelectedValue
                            If Len(Trim(TxtPIECE.Text)) > 0 Then
                                If IsNumeric(Trim(TxtPIECE.Text)) Then
                                    ds_sub.Tables(0).Rows(0).Item("PIECE") = Trim(TxtPIECE.Text)
                                Else
                                    MsgBox("原载件数一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                                    Exit Sub
                                End If
                            End If
                            If Len(Trim(TxtTONS.Text)) > 0 Then
                                If IsNumeric(Trim(TxtTONS.Text)) Then
                                    ds_sub.Tables(0).Rows(0).Item("TONS") = Trim(TxtTONS.Text)
                                Else
                                    MsgBox("原载吨数一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                                    Exit Sub
                                End If
                            End If
                            If Len(Trim(TxtTALLY_CARGO.Text)) > 0 Then
                                If IsNumeric(Trim(TxtTALLY_CARGO.Text)) Then
                                    ds_sub.Tables(0).Rows(0).Item("TALLY_CARGO") = Trim(TxtTALLY_CARGO.Text)
                                Else
                                    MsgBox("本班理货件数应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                                    Exit Sub
                                End If
                            End If
                            If Len(Trim(TxtTALLY_CARGO_TON.Text)) > 0 Then
                                If IsNumeric(Trim(TxtTALLY_CARGO_TON.Text)) Then
                                    ds_sub.Tables(0).Rows(0).Item("TALLY_CARGO_TON") = Trim(TxtTALLY_CARGO_TON.Text)
                                Else
                                    MsgBox("本班理货吨数应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                                    Exit Sub
                                End If
                            End If
                            If Len(Trim(TxtTOTAL_NUM.Text)) > 0 Then
                                If IsNumeric(Trim(TxtTOTAL_NUM.Text)) Then
                                    ds_sub.Tables(0).Rows(0).Item("TOTAL_NUM") = Trim(TxtTOTAL_NUM.Text)
                                Else
                                    MsgBox("累计件数一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                                    Exit Sub
                                End If
                            End If
                            If Len(Trim(TxtTOTAL_NUM_TON.Text)) > 0 Then
                                If IsNumeric(Trim(TxtTOTAL_NUM_TON.Text)) Then
                                    ds_sub.Tables(0).Rows(0).Item("TOTAL_NUM_TON") = Trim(TxtTOTAL_NUM_TON.Text)
                                Else
                                    MsgBox("累计吨数一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                                    Exit Sub
                                End If
                            End If
                            If Len(Trim(TxtREMAIN.Text)) > 0 Then
                                If IsNumeric(Trim(TxtREMAIN.Text)) Then
                                    ds_sub.Tables(0).Rows(0).Item("REMAIN") = Trim(TxtREMAIN.Text)
                                Else
                                    MsgBox("余数一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                                    Exit Sub
                                End If
                            End If
                            If Len(Trim(TxtREMAIN_TON.Text)) > 0 Then
                                If IsNumeric(Trim(TxtREMAIN_TON.Text)) Then
                                    ds_sub.Tables(0).Rows(0).Item("REMAIN_TON") = Trim(TxtREMAIN_TON.Text)
                                Else
                                    MsgBox("余数一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                                    Exit Sub
                                End If
                            End If
                            ds_sub.Tables(0).Rows(0).Item("MARK_COMPLETE") = CmbMARK_COMPLETE.SelectedValue
                            ds_sub.Tables(0).Rows(0).Item("User_Name") = Trim(G_User)
                            If G_DeptCode = "26.11" Then
                                ds_sub.Tables(0).Rows(0).Item("Company_REMARK") = TxtCOMPANY_REMARK.Text
                            ElseIf G_DeptCode Like "26.11.*" Then
                                ds_sub.Tables(0).Rows(0).Item("Dept_Remark") = TxtDEPT_REMARK.Text
                            End If
                            sqlda_sub.Update(ds_sub)
                            If Len(Trim(TxtTALLY_CARGO.Text)) = 0 Then
                                TALLY_CARGO_his = 0
                            Else
                                TALLY_CARGO_his = Trim(TxtTALLY_CARGO.Text)
                            End If
                            If Len(Trim(TxtTALLY_CARGO_TON.Text)) = 0 Then
                                TALLY_CARGO_TON_his = 0
                            Else
                                TALLY_CARGO_TON_his = Trim(TxtTALLY_CARGO_TON.Text)
                            End If
                            btSave.Enabled = False
                            'Call btAdd_Click(sender, e)
                        End If
                    Else
                        MsgBox("货类不能为空！")
                    End If
                Else
                    MsgBox("泊位号不能为空！")
                End If
                If GL_Str = -1 Then
                    GL_Str = 0
                    Me.Close()
                End If
                Exit Sub
            Else
                SqlStr = "select * from WATCH_RECORD_SHIP"
                dw_sub = Updatedata(sqlda_sub, SqlStr, ds_sub)
                If Len(Trim(TxtBERTHNO.Text)) > 0 Then
                    If CmbCODE_GOODS.SelectedValue <> "00" Then
                        If MsgBox("你确认要添加本单船记录吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
                            Dim row As DataRow
                            row = ds_sub.Tables(0).NewRow()
                            row("SHIP_ID") = ID
                            row("WATCHSHIPDATE") = DTPWATCHDATE.Value
                            row("DAYNIGHTMARK") = CmbDAYNIGHTMARK.SelectedValue
                            row("BERTHNO") = Trim(TxtBERTHNO.Text)
                            row("CODE_GOODS") = CmbCODE_GOODS.SelectedValue
                            If Len(Trim(TxtTICKET.Text)) > 0 Then
                                row("TICKET") = Trim(TxtTICKET.Text)
                            End If
                            row("LOAD_UNLOAD_PORT") = CmbLOAD_UNLOAD_PORT.SelectedValue
                            row("INOUTPORT") = CmbINOUTPORT.SelectedValue
                            row("NATIONALITY_CODE") = CmbNATIONALITY_CODE.SelectedValue
                            If Len(Trim(TxtPIECE.Text)) > 0 Then
                                row("PIECE") = Trim(TxtPIECE.Text)
                            End If
                            If Len(Trim(TxtTONS.Text)) > 0 Then
                                row("TONS") = Trim(TxtTONS.Text)
                            End If
                            If Len(Trim(TxtTALLY_CARGO.Text)) > 0 Then
                                row("TALLY_CARGO") = Trim(TxtTALLY_CARGO.Text)
                            End If
                            If Len(Trim(TxtTALLY_CARGO_TON.Text)) > 0 Then
                                row("TALLY_CARGO_TON") = Trim(TxtTALLY_CARGO_TON.Text)
                            End If
                            If Len(Trim(TxtTOTAL_NUM.Text)) > 0 Then
                                row("TOTAL_NUM") = Trim(TxtTOTAL_NUM.Text)
                            End If
                            If Len(Trim(TxtTOTAL_NUM_TON.Text)) > 0 Then
                                row("TOTAL_NUM_TON") = Trim(TxtTOTAL_NUM_TON.Text)
                            End If
                            If Len(Trim(TxtREMAIN.Text)) > 0 Then
                                row("REMAIN") = Trim(TxtREMAIN.Text)
                            End If
                            If Len(Trim(TxtREMAIN_TON.Text)) > 0 Then
                                row("REMAIN_TON") = Trim(TxtREMAIN_TON.Text)
                            End If
                            row("MARK_COMPLETE") = CmbMARK_COMPLETE.SelectedValue
                            row("User_Name") = Trim(G_User)
                            If G_DeptCode = "26.11" Then
                                row("Company_REMARK") = TxtCOMPANY_REMARK.Text
                            ElseIf G_DeptCode Like "26.11.*" Then
                                row("Dept_Remark") = TxtDEPT_REMARK.Text
                            End If
                            ds_sub.Tables(0).Rows.Add(row)
                            sqlda_sub.Update(ds_sub)
                            If Len(Trim(TxtTALLY_CARGO.Text)) = 0 Then
                                TALLY_CARGO_his = 0
                            Else
                                TALLY_CARGO_his = Trim(TxtTALLY_CARGO.Text)
                            End If
                            If Len(Trim(TxtTALLY_CARGO_TON.Text)) = 0 Then
                                TALLY_CARGO_TON_his = 0
                            Else
                                TALLY_CARGO_TON_his = Trim(TxtTALLY_CARGO_TON.Text)
                            End If
                            'Call btAdd_Click(sender, e)
                        End If
                    Else
                        MsgBox("货名代码不能为空！")
                    End If
                Else
                    MsgBox("泊位号不能为空！")
                End If
            End If
            If GL_Str = -1 Then
                GL_Str = 0
                Me.Close()
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        SqlStr = "select * from WATCH_RECORD_SHIP where SHIP_ID=" & ID & " and datediff(dd,WATCHSHIPDATE ,'" & DTPWATCHDATE.Value & "')=0 and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
        dwtmp = Updatedata(sqldatmp, SqlStr, dstmp)
        Try
            If MsgBox("你确认要删除吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
                dstmp.Tables(0).Rows(0).Delete()
                sqlda.Update(dstmp)
                Me.Enabled = False
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnGetdata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGetdata.Click

    End Sub

    Private Sub BtnShip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShip.Click
        GL_Str = 0
        ID = CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Integer)
        Dim FrmShip As New FrmAttemper_openform1()
        FrmShip.ShowDialog()
        Try
            FirmStr = " Order by Ship_Statu,Dept_Code,id desc " '
            DynaStr = " (DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0) "
            SqlStr = DynaStr & FirmStr
            Call myDataGrid(SqlStr)
            Dim i As Integer
            i = 0
            Do While i < dwship.Count
                If ID = CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Integer) Then
                    Exit Do
                Else
                    Me.C1DBG.Row = Me.C1DBG.Row + 1
                End If
                i = i + 1
            Loop
            BtnShip.Enabled = False
            If GL_Str = 1 Then                                                '*********船舶进港
                TxtBERTHNO.Text = Me.C1DBG.Columns.Item("BERTHNO").Text
                If TxtCOMPANY_REMARK.Enabled = True Then
                    TxtCOMPANY_REMARK.Text = TxtCOMPANY_REMARK.Text & "   '" & Me.C1DBG.Columns.Item("CHI_VESSEL").Text & "'于" & GL_Time & "进港 "
                ElseIf TxtDEPT_REMARK.Enabled = True Then
                    TxtDEPT_REMARK.Text = TxtDEPT_REMARK.Text & "   '" & Me.C1DBG.Columns.Item("CHI_VESSEL").Text & "'于" & GL_Time & "进港 "
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChange.Click
        GL_Str = 0
        Dim FrmChange As New FrmAttemper_openform2()
        FrmChange.ShowDialog()
        Dim Deptname As String
        Deptname = Me.C1DBG.Columns.Item("DEPT_NAME").Text
        Try
            FirmStr = " Order by Ship_Statu,Dept_Code,id desc " '
            DynaStr = " (DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0) "
            SqlStr = DynaStr & FirmStr
            Call myDataGrid(SqlStr)
            Dim i As Integer
            i = 0
            Me.C1DBG.Row = 0
            Do While i < dsship.Tables(0).DefaultView.Count
                If ID = CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Integer) Then
                    Exit Do
                Else
                    Me.C1DBG.Row = Me.C1DBG.Row + 1
                End If
                i = i + 1
            Loop

            BtnChange.Enabled = False

            If GL_Str = 1 Then                                  '*********调整站属
                If TxtCOMPANY_REMARK.Enabled = True Then
                    TxtCOMPANY_REMARK.Text = TxtCOMPANY_REMARK.Text & "   '" & Me.C1DBG.Columns.Item("CHI_VESSEL").Text & "'从" & Deptname & "转到"
                    Deptname = Me.C1DBG.Columns.Item("DEPT_NAME").Text
                    TxtCOMPANY_REMARK.Text = TxtCOMPANY_REMARK.Text & Deptname
                ElseIf TxtDEPT_REMARK.Enabled = True Then
                    TxtDEPT_REMARK.Text = TxtDEPT_REMARK.Text & "   '" & Me.C1DBG.Columns.Item("CHI_VESSEL").Text & "'从" & Deptname & "转到"
                    Deptname = Me.C1DBG.Columns.Item("DEPT_NAME").Text
                    TxtDEPT_REMARK.Text = TxtDEPT_REMARK.Text & Deptname
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnOver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOver.Click
        GL_Str = 0
        Dim FrmOver As New FrmAttemper_openform3()
        FrmOver.ShowDialog()
        Try
            FirmStr = " Order by Ship_Statu,Dept_Code,id desc " '
            DynaStr = " (DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0) "
            SqlStr = DynaStr & FirmStr
            Call myDataGrid(SqlStr)
            Dim i As Integer
            i = 0
            Me.C1DBG.Row = 0
            Do While i < dsship.Tables(0).DefaultView.Count
                If ID = CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Integer) Then
                    Exit Do
                Else
                    Me.C1DBG.Row = Me.C1DBG.Row + 1
                End If
                i = i + 1
            Loop

            BtnOver.Enabled = False
            If GL_Str = 1 Then
                If TxtCOMPANY_REMARK.Enabled = True Then   '*********船舶完工
                    TxtCOMPANY_REMARK.Text = TxtCOMPANY_REMARK.Text & "   '" & Me.C1DBG.Columns.Item("CHI_VESSEL").Text & "'于" & GL_Time & "完工 "
                ElseIf TxtDEPT_REMARK.Enabled = True Then
                    TxtDEPT_REMARK.Text = TxtDEPT_REMARK.Text & "   '" & Me.C1DBG.Columns.Item("CHI_VESSEL").Text & "'于" & GL_Time & "完工 "
                End If
            End If
            CmbMARK_COMPLETE.SelectedValue = GL_Str
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMove.Click
        Dim FrmMove As New FrmAttemper_openform4()
        FrmMove.ShowDialog()
        Dim BERTH As String
        BERTH = Me.C1DBG.Columns.Item("BERTHNO").Text
        Try
            FirmStr = " Order by Ship_Statu,Dept_Code,id desc " '
            DynaStr = " (DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0) "
            SqlStr = DynaStr & FirmStr
            Call myDataGrid(SqlStr)
            Dim i As Integer
            i = 0
            Me.C1DBG.Row = 0
            Do While i < dsship.Tables(0).DefaultView.Count
                If ID = CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Integer) Then
                    Exit Do
                Else
                    Me.C1DBG.Row = Me.C1DBG.Row + 1
                End If
                i = i + 1
            Loop

            BtnMove.Enabled = False
            If GL_Str = 1 Then                                  '*********移泊
                TxtBERTHNO.Text = Me.C1DBG.Columns.Item("BERTHNO").Text
                If TxtCOMPANY_REMARK.Enabled = True Then
                    TxtCOMPANY_REMARK.Text = TxtCOMPANY_REMARK.Text & "   '" & Me.C1DBG.Columns.Item("CHI_VESSEL").Text & "'从" & BERTH & "泊位移至"
                    BERTH = Me.C1DBG.Columns.Item("BERTHNO").Text
                    TxtCOMPANY_REMARK.Text = TxtCOMPANY_REMARK.Text & BERTH & "泊位"
                ElseIf TxtDEPT_REMARK.Enabled = True Then
                    TxtDEPT_REMARK.Text = TxtDEPT_REMARK.Text & "   '" & Me.C1DBG.Columns.Item("CHI_VESSEL").Text & "'从" & BERTH & "泊位移至"
                    BERTH = Me.C1DBG.Columns.Item("BERTHNO").Text
                    TxtDEPT_REMARK.Text = TxtDEPT_REMARK.Text & BERTH & "泊位"
                End If
            End If
            CmbMARK_COMPLETE.SelectedValue = GL_Str
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCLERK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCLERK.Click
        Dim dsClerk As New DataSet()
        Dim dwClerk As New DataView()
        Dim row As DataRow

        GL_Str = Me.C1DBG.Columns.Item("CHI_VESSEL").Text
        BtnCLERK.Enabled = False
        If G_DeptCode = "26.11" Then
            SqlStr = "select * from TALLY_TEAM where datediff(dd,WORK_DAY,'" & DTPWATCHDATE.Value & "')=0  and DEPT_CODE Like '" & G_DeptCode & "%' and SHIP_ID=" & ID & " and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
            dwClerk = Updatedata(sqlda, SqlStr, dsClerk)
        Else
            SqlStr = "select * from TALLY_TEAM where datediff(dd,WORK_DAY,'" & DTPWATCHDATE.Value & "')=0 and WORK_TYPE='" & CmbWORK_TYPE.SelectedValue & "' and DEPT_CODE ='" & G_DeptCode & "' and SHIP_ID=" & ID & " and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
            dwClerk = Updatedata(sqlda, SqlStr, dsClerk)
        End If
        If dwClerk.Count > 0 Then                       '********* 派工，编辑 
            ID = dwClerk(0)(0)
        Else
            If G_DeptCode <> "26.11" Then                '********* 派工，增加
                SqlStr = "select * from TALLY_TEAM"
                dwClerk = Updatedata(sqlda, SqlStr, dsClerk)
                row = dsClerk.Tables(0).NewRow()

                row("SHIP_ID") = ID
                row("DEPT_CODE") = G_DeptCode
                row("WORK_DAY") = DTPWATCHDATE.Value
                row("DayNightMark") = CmbDAYNIGHTMARK.SelectedValue
                row("WORK_TYPE") = CmbWORK_TYPE.SelectedValue
                row("User_Name") = Trim(G_User)

                dsClerk.Tables(0).Rows.Add(row)
                sqlda.Update(dsClerk)

                SqlStr = "select * from TALLY_TEAM where datediff(dd,WORK_DAY,'" & DTPWATCHDATE.Value & "')=0 and WORK_TYPE='" & CmbWORK_TYPE.SelectedValue & "' and DEPT_CODE ='" & G_DeptCode & "' and SHIP_ID=" & ID & " and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
                dwClerk = Updatedata(sqlda, SqlStr, dsClerk)
                ID = dwClerk(0)(0)
            Else
                MsgBox("业务部无法派工！", MsgBoxStyle.Information, "提示")
                Exit Sub
            End If
        End If

        Dim FrmCLERK As New FrmAttemper_openform5()
        FrmCLERK.ShowDialog()

    End Sub

    Private Sub FillWeather()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "select Code_Weather,Weather from Code_Weather"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbWeather.DataSource = dvc
        Me.CmbWeather.DisplayMember = "Weather"
        Me.CmbWeather.ValueMember = "Code_Weather"
    End Sub

    Private Sub FillWORK_TYPE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "SELECT WORK_TYPE FROM WORK_BEGIN WHERE DEPT_CODE='" & G_DeptCode & "' ORDER BY TIME_FROM, DayNightMark"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbWORK_TYPE.DataSource = dvc
        Me.CmbWORK_TYPE.DisplayMember = "WORK_TYPE"
        Me.CmbWORK_TYPE.ValueMember = "WORK_TYPE"
    End Sub

    Private Sub FillWATCH_DIRECTOR()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "SELECT Code_Director,Director FROM Code_Director WHERE DEPT_CODE ='" & G_DeptCode & "'"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbWATCH_DIRECTOR.DataSource = dvc
        Me.CmbWATCH_DIRECTOR.DisplayMember = "Director"
        Me.CmbWATCH_DIRECTOR.ValueMember = "Code_Director"
    End Sub

    Private Sub FillDIRECTOR()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "SELECT Code_Director,Director FROM Code_Director WHERE DEPT_CODE ='" & G_DeptCode & "'"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbDIRECTOR.DataSource = dvc
        Me.CmbDIRECTOR.DisplayMember = "Director"
        Me.CmbDIRECTOR.ValueMember = "Code_Director"
    End Sub

    Private Sub FillDAYNIGHTMARK()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "SELECT Code_WorkTime,WorkTime FROM Code_WorkTime"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbDAYNIGHTMARK.DataSource = dvc
        Me.CmbDAYNIGHTMARK.DisplayMember = "WorkTime"
        Me.CmbDAYNIGHTMARK.ValueMember = "Code_WorkTime"
    End Sub

    Private Sub FillINOUTPORT()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "select InOutPort,InOutPort_Name from Code_InOutPort"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbINOUTPORT.DataSource = dvc
        Me.CmbINOUTPORT.DisplayMember = "InOutPort_Name"
        Me.CmbINOUTPORT.ValueMember = "InOutPort"
    End Sub

    Private Sub FillLOAD_UNLOAD_PORT()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "select CODE_PORT,PORT_CHA from CODE_PORT order by PORT_CHA"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbLOAD_UNLOAD_PORT.DataSource = dvc
        Me.CmbLOAD_UNLOAD_PORT.DisplayMember = "PORT_CHA"
        Me.CmbLOAD_UNLOAD_PORT.ValueMember = "CODE_PORT"
    End Sub

    Private Sub FillNATIONALITY_CODE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "select NATIONALITY_CHA,NATIONALITY_ENG from CODE_NATIONALITY order by NATIONALITY_CHA"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbNATIONALITY_CODE.DataSource = dvc
        Me.CmbNATIONALITY_CODE.DisplayMember = "NATIONALITY_CHA"
        Me.CmbNATIONALITY_CODE.ValueMember = "NATIONALITY_ENG"
    End Sub

    Private Sub FillCODE_GOODS()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "select Code_Cargo_Type,Cargo_Type from Code_Cargo_Type"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbCODE_GOODS.DataSource = dvc
        Me.CmbCODE_GOODS.DisplayMember = "Cargo_Type"
        Me.CmbCODE_GOODS.ValueMember = "Code_Cargo_Type"
    End Sub

    Private Sub FillMARK_COMPLETE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "select Descri,Value from CodeLINER_ID"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbMARK_COMPLETE.DataSource = dvc
        Me.CmbMARK_COMPLETE.DisplayMember = "Descri"
        Me.CmbMARK_COMPLETE.ValueMember = "Value"
    End Sub

    Private Sub FillDEPT_CODE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "select DEPT_CODE,DEPT_NAME from DEPARTMENT"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbDEPT_CODE.DataSource = dvc
        Me.CmbDEPT_CODE.DisplayMember = "DEPT_NAME"
        Me.CmbDEPT_CODE.ValueMember = "DEPT_CODE"
    End Sub

    Private Sub CombLOAD_PORT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbLOAD_UNLOAD_PORT.Leave
        Dim DSSELECT As New DataSet()
        Try
            If Len(Trim(CmbLOAD_UNLOAD_PORT.Text)) > 0 Then
                'dw = Getdata("SELECT * FROM CODE_port WHERE code_port='" & Trim(CmbLOAD_UNLOAD_PORT.Text) & "'", DSSELECT)
                dw = Getdata("SELECT * FROM CODE_port WHERE code_port like '%" & Trim(CmbLOAD_UNLOAD_PORT.Text) & "%' or port_cha like '%" & Trim(CmbLOAD_UNLOAD_PORT.Text) & "%' or port_eng like '%" & Trim(CmbLOAD_UNLOAD_PORT.Text) & "%'", DSSELECT)
                If DSSELECT.Tables(0).Rows.Count > 0 Then
                    CmbLOAD_UNLOAD_PORT.SelectedValue = DSSELECT.Tables(0).Rows(0).Item("code_port")
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CmbNATIONALITY_CODE_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbNATIONALITY_CODE.Leave
        Dim DSSELECT As New DataSet
        Try
            If Len(Trim(CmbNATIONALITY_CODE.Text)) > 0 Then
                dw = Getdata("SELECT * FROM CODE_NATIONALITY WHERE NATIONALITY_CHA like '%" & Trim(CmbNATIONALITY_CODE.Text) & "%' or NATIONALITY_ENG like '%" & Trim(CmbNATIONALITY_CODE.Text) & "%' or NATIONALITY_English like '%" & Trim(CmbNATIONALITY_CODE.Text) & "%'", DSSELECT)
                If DSSELECT.Tables(0).Rows.Count > 0 Then
                    CmbNATIONALITY_CODE.SelectedValue = DSSELECT.Tables(0).Rows(0).Item("NATIONALITY_ENG")
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        GB1.Text = "单船记录"
        TxtBERTHNO.Text = ""
        CmbINOUTPORT.SelectedValue = " "
        Call FillNATIONALITY_CODE()
        Call FillCODE_GOODS()
        TxtTALLY_CARGO.Text = ""
        TxtTOTAL_NUM.Text = ""
        TxtREMAIN.Text = ""
        Call FillMARK_COMPLETE()
        TxtTICKET.Text = ""
        TxtPIECE.Text = ""
        TxtTONS.Text = ""
        Call FillLOAD_UNLOAD_PORT()
        TxtCOMPANY_REMARK.Text = ""
        TxtDEPT_REMARK.Text = ""
        TxtBERTHNO.Focus()
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnQuit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnQuit.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Dim i As MsgBoxResult

        If btSave.Enabled = True Then
            i = MsgBox("当前修改没有存盘，需要保存吗？", MsgBoxStyle.YesNoCancel + vbExclamation, "提示")
            If i = MsgBoxResult.Yes Then
                GL_Str = -1
                Call btSave_Click(sender, e)
            ElseIf i = MsgBoxResult.No Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Btnattendancerecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnattendancerecords.Click
        GL_Str = CmbDAYNIGHTMARK.SelectedValue
        GL_Time = DTPWATCHDATE.Value
        Dim Frm As New Frmattendancerecords_ADD
        Frm.ShowDialog()
    End Sub

    Private Sub DTPWATCHDATE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DTPWATCHDATE.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbWeather.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbWeather_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbWeather.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbWORK_TYPE.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbWORK_TYPE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbWORK_TYPE.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbDAYNIGHTMARK.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbDAYNIGHTMARK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbDAYNIGHTMARK.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbWATCH_DIRECTOR.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbWATCH_DIRECTOR_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbWATCH_DIRECTOR.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbDIRECTOR.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbDIRECTOR_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbDIRECTOR.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtITEM.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtITEM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtITEM.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtBERTHNO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBERTHNO.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbINOUTPORT.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbINOUTPORT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbINOUTPORT.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTICKET.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtTICKET_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTICKET.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbLOAD_UNLOAD_PORT.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbLOAD_UNLOAD_PORT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbLOAD_UNLOAD_PORT.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbNATIONALITY_CODE.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbNATIONALITY_CODE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbNATIONALITY_CODE.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbCODE_GOODS.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbCODE_GOODS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbCODE_GOODS.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtPIECE.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtPIECE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPIECE.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTONS.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtTONS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTONS.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTALLY_CARGO.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtTALLY_CARGO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTALLY_CARGO.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTALLY_CARGO_TON.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtTALLY_CARGO_TON_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTALLY_CARGO_TON.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTOTAL_NUM.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtTOTAL_NUM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTOTAL_NUM.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTOTAL_NUM_TON.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtTOTAL_NUM_TON_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTOTAL_NUM_TON.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtREMAIN.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtREMAIN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtREMAIN.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtREMAIN_TON.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtREMAIN_TON_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtREMAIN_TON.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbMARK_COMPLETE.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbMARK_COMPLETE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbMARK_COMPLETE.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDEPT_REMARK.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtDEPT_REMARK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDEPT_REMARK.KeyDown
        If e.KeyCode = Keys.Enter Then
            btSave.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btSave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btSave.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class
