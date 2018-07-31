Imports TALLY.DBControl
Public Class FrmSShip_Add
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
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents GBV As System.Windows.Forms.GroupBox
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents BtnVesseladd As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents TxtFind As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TxtVOYAGE As System.Windows.Forms.TextBox
    Friend WithEvents DTPETA_ARRIVER_TIME As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbS_TRADE As System.Windows.Forms.ComboBox
    Friend WithEvents CmbINOUTPORT As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCODE_SHIP_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents TxtTRANSIT_ITEM As System.Windows.Forms.TextBox
    Friend WithEvents CmbNEXT_PORT As System.Windows.Forms.ComboBox
    Friend WithEvents CmbLAST_PORT As System.Windows.Forms.ComboBox
    Friend WithEvents DTPETA_SAILING_TIME As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPARRIVER_TIME As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPBERTH_TIME As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtBERTHNO As System.Windows.Forms.TextBox
    Friend WithEvents DTPWORKTIME_BEGIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbCODE_GOODS As System.Windows.Forms.ComboBox
    Friend WithEvents TxtTONS As System.Windows.Forms.TextBox
    Friend WithEvents DTPSAILING_TIME As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPWORKTIME_END As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtCLIENT As System.Windows.Forms.TextBox
    Friend WithEvents TxtCONSIGNEE As System.Windows.Forms.TextBox
    Friend WithEvents CmbAGENT As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDEPT_CODE As System.Windows.Forms.ComboBox
    Friend WithEvents CmbVOYAGE_NATURE As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSHIP_ID As System.Windows.Forms.TextBox
    Friend WithEvents TXTV_ID As System.Windows.Forms.TextBox
    Friend WithEvents TxtCHI_VESSEL As System.Windows.Forms.TextBox
    Friend WithEvents TxtENG_VESSEL As System.Windows.Forms.TextBox
    Friend WithEvents TxtSHIP_STATU As System.Windows.Forms.TextBox
    Friend WithEvents TxtUSER_NAME As System.Windows.Forms.TextBox
    Friend WithEvents ChkARRIVER_TIME As System.Windows.Forms.CheckBox
    Friend WithEvents ChkBERTH_TIME As System.Windows.Forms.CheckBox
    Friend WithEvents ChkETA_ARRIVER_TIME As System.Windows.Forms.CheckBox
    Friend WithEvents ChkETA_SAILING_TIME As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSAILING_TIME As System.Windows.Forms.CheckBox
    Friend WithEvents ChkWORKTIME_BEGIN As System.Windows.Forms.CheckBox
    Friend WithEvents ChkWORKTIME_END As System.Windows.Forms.CheckBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TxtREMARK As System.Windows.Forms.TextBox
    Friend WithEvents CmbShipOwner As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtVessel_Code As System.Windows.Forms.TextBox
    Friend WithEvents cmb_BERTH_POSITION As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cmbcode_route As System.Windows.Forms.ComboBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnVesseledit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSShip_Add))
        Me.GB = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtVessel_Code = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cmb_BERTH_POSITION = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TxtREMARK = New System.Windows.Forms.TextBox()
        Me.CmbS_TRADE = New System.Windows.Forms.ComboBox()
        Me.TxtVOYAGE = New System.Windows.Forms.TextBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.CmbShipOwner = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.CmbINOUTPORT = New System.Windows.Forms.ComboBox()
        Me.cmbcode_route = New System.Windows.Forms.ComboBox()
        Me.CmbCODE_SHIP_TYPE = New System.Windows.Forms.ComboBox()
        Me.CmbNEXT_PORT = New System.Windows.Forms.ComboBox()
        Me.CmbLAST_PORT = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtBERTHNO = New System.Windows.Forms.TextBox()
        Me.DTPWORKTIME_BEGIN = New System.Windows.Forms.DateTimePicker()
        Me.CmbCODE_GOODS = New System.Windows.Forms.ComboBox()
        Me.TxtTONS = New System.Windows.Forms.TextBox()
        Me.DTPWORKTIME_END = New System.Windows.Forms.DateTimePicker()
        Me.CmbAGENT = New System.Windows.Forms.ComboBox()
        Me.CmbDEPT_CODE = New System.Windows.Forms.ComboBox()
        Me.TxtSHIP_ID = New System.Windows.Forms.TextBox()
        Me.TXTV_ID = New System.Windows.Forms.TextBox()
        Me.TxtCHI_VESSEL = New System.Windows.Forms.TextBox()
        Me.ChkWORKTIME_BEGIN = New System.Windows.Forms.CheckBox()
        Me.ChkWORKTIME_END = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ChkARRIVER_TIME = New System.Windows.Forms.CheckBox()
        Me.DTPETA_ARRIVER_TIME = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTRANSIT_ITEM = New System.Windows.Forms.TextBox()
        Me.DTPETA_SAILING_TIME = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DTPARRIVER_TIME = New System.Windows.Forms.DateTimePicker()
        Me.DTPBERTH_TIME = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.DTPSAILING_TIME = New System.Windows.Forms.DateTimePicker()
        Me.TxtCLIENT = New System.Windows.Forms.TextBox()
        Me.TxtCONSIGNEE = New System.Windows.Forms.TextBox()
        Me.CmbVOYAGE_NATURE = New System.Windows.Forms.ComboBox()
        Me.TxtENG_VESSEL = New System.Windows.Forms.TextBox()
        Me.TxtSHIP_STATU = New System.Windows.Forms.TextBox()
        Me.TxtUSER_NAME = New System.Windows.Forms.TextBox()
        Me.ChkBERTH_TIME = New System.Windows.Forms.CheckBox()
        Me.ChkETA_ARRIVER_TIME = New System.Windows.Forms.CheckBox()
        Me.ChkETA_SAILING_TIME = New System.Windows.Forms.CheckBox()
        Me.ChkSAILING_TIME = New System.Windows.Forms.CheckBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.BtnVesseladd = New System.Windows.Forms.Button()
        Me.GBV = New System.Windows.Forms.GroupBox()
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.TxtFind = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BtnVesseledit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GB.SuspendLayout()
        Me.GBV.SuspendLayout()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB
        '
        Me.GB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB.Controls.Add(Me.Label31)
        Me.GB.Controls.Add(Me.Label1)
        Me.GB.Controls.Add(Me.Label3)
        Me.GB.Controls.Add(Me.Label4)
        Me.GB.Controls.Add(Me.Label26)
        Me.GB.Controls.Add(Me.Label6)
        Me.GB.Controls.Add(Me.Label9)
        Me.GB.Controls.Add(Me.Label13)
        Me.GB.Controls.Add(Me.Label15)
        Me.GB.Controls.Add(Me.Label16)
        Me.GB.Controls.Add(Me.Label20)
        Me.GB.Controls.Add(Me.Label5)
        Me.GB.Controls.Add(Me.TxtVessel_Code)
        Me.GB.Controls.Add(Me.Label30)
        Me.GB.Controls.Add(Me.cmb_BERTH_POSITION)
        Me.GB.Controls.Add(Me.Label29)
        Me.GB.Controls.Add(Me.TxtREMARK)
        Me.GB.Controls.Add(Me.CmbS_TRADE)
        Me.GB.Controls.Add(Me.TxtVOYAGE)
        Me.GB.Controls.Add(Me.btnQuit)
        Me.GB.Controls.Add(Me.btnSave)
        Me.GB.Controls.Add(Me.CmbShipOwner)
        Me.GB.Controls.Add(Me.btnAdd)
        Me.GB.Controls.Add(Me.CmbINOUTPORT)
        Me.GB.Controls.Add(Me.cmbcode_route)
        Me.GB.Controls.Add(Me.CmbCODE_SHIP_TYPE)
        Me.GB.Controls.Add(Me.CmbNEXT_PORT)
        Me.GB.Controls.Add(Me.CmbLAST_PORT)
        Me.GB.Controls.Add(Me.Label14)
        Me.GB.Controls.Add(Me.Label18)
        Me.GB.Controls.Add(Me.Label22)
        Me.GB.Controls.Add(Me.Label23)
        Me.GB.Controls.Add(Me.TxtBERTHNO)
        Me.GB.Controls.Add(Me.DTPWORKTIME_BEGIN)
        Me.GB.Controls.Add(Me.CmbCODE_GOODS)
        Me.GB.Controls.Add(Me.TxtTONS)
        Me.GB.Controls.Add(Me.DTPWORKTIME_END)
        Me.GB.Controls.Add(Me.CmbAGENT)
        Me.GB.Controls.Add(Me.CmbDEPT_CODE)
        Me.GB.Controls.Add(Me.TxtSHIP_ID)
        Me.GB.Controls.Add(Me.TXTV_ID)
        Me.GB.Controls.Add(Me.TxtCHI_VESSEL)
        Me.GB.Controls.Add(Me.ChkWORKTIME_BEGIN)
        Me.GB.Controls.Add(Me.ChkWORKTIME_END)
        Me.GB.Enabled = False
        Me.GB.Location = New System.Drawing.Point(248, 56)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(426, 325)
        Me.GB.TabIndex = 2
        Me.GB.TabStop = False
        '
        'Label31
        '
        Me.Label31.ForeColor = System.Drawing.Color.Red
        Me.Label31.Location = New System.Drawing.Point(1, 261)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(60, 20)
        Me.Label31.TabIndex = 123
        Me.Label31.Text = "船码"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label31.Visible = False
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(1, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "航次"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(1, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "进出口"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(1, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "贸易类别"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.ForeColor = System.Drawing.Color.Red
        Me.Label26.Location = New System.Drawing.Point(1, 105)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(60, 20)
        Me.Label26.TabIndex = 29
        Me.Label26.Text = "航线标志"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(1, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 20)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "装货港口"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(1, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 20)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "卸货港口"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(1, 194)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 20)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "泊位位置"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(1, 216)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 20)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "船舶类别"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(1, 240)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 20)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "吨数"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(1, 172)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 20)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "泊位号"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(1, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "国轮外轮"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtVessel_Code
        '
        Me.TxtVessel_Code.Location = New System.Drawing.Point(62, 261)
        Me.TxtVessel_Code.MaxLength = 9
        Me.TxtVessel_Code.Name = "TxtVessel_Code"
        Me.TxtVessel_Code.Size = New System.Drawing.Size(122, 21)
        Me.TxtVessel_Code.TabIndex = 118
        Me.TxtVessel_Code.Visible = False
        '
        'Label30
        '
        Me.Label30.ForeColor = System.Drawing.Color.Red
        Me.Label30.Location = New System.Drawing.Point(189, 261)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(80, 20)
        Me.Label30.TabIndex = 122
        Me.Label30.Text = "船公司承运人"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label30.Visible = False
        '
        'cmb_BERTH_POSITION
        '
        Me.cmb_BERTH_POSITION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_BERTH_POSITION.Items.AddRange(New Object() {"", "东", "南", "西", "北"})
        Me.cmb_BERTH_POSITION.Location = New System.Drawing.Point(62, 194)
        Me.cmb_BERTH_POSITION.Name = "cmb_BERTH_POSITION"
        Me.cmb_BERTH_POSITION.Size = New System.Drawing.Size(122, 20)
        Me.cmb_BERTH_POSITION.TabIndex = 7
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(246, 108)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(20, 151)
        Me.Label29.TabIndex = 90
        Me.Label29.Text = "备   注"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtREMARK
        '
        Me.TxtREMARK.Location = New System.Drawing.Point(271, 108)
        Me.TxtREMARK.MaxLength = 100
        Me.TxtREMARK.Multiline = True
        Me.TxtREMARK.Name = "TxtREMARK"
        Me.TxtREMARK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtREMARK.Size = New System.Drawing.Size(138, 151)
        Me.TxtREMARK.TabIndex = 31
        '
        'CmbS_TRADE
        '
        Me.CmbS_TRADE.Location = New System.Drawing.Point(62, 39)
        Me.CmbS_TRADE.Name = "CmbS_TRADE"
        Me.CmbS_TRADE.Size = New System.Drawing.Size(122, 20)
        Me.CmbS_TRADE.TabIndex = 1
        '
        'TxtVOYAGE
        '
        Me.TxtVOYAGE.Location = New System.Drawing.Point(62, 16)
        Me.TxtVOYAGE.MaxLength = 17
        Me.TxtVOYAGE.Name = "TxtVOYAGE"
        Me.TxtVOYAGE.Size = New System.Drawing.Size(122, 21)
        Me.TxtVOYAGE.TabIndex = 0
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(234, 292)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(65, 24)
        Me.btnQuit.TabIndex = 14
        Me.btnQuit.Text = "取消"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(166, 292)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(65, 24)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "确认"
        '
        'CmbShipOwner
        '
        Me.CmbShipOwner.Location = New System.Drawing.Point(271, 261)
        Me.CmbShipOwner.MaxDropDownItems = 15
        Me.CmbShipOwner.Name = "CmbShipOwner"
        Me.CmbShipOwner.Size = New System.Drawing.Size(138, 20)
        Me.CmbShipOwner.TabIndex = 28
        Me.CmbShipOwner.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(98, 292)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(65, 24)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "清空"
        '
        'CmbINOUTPORT
        '
        Me.CmbINOUTPORT.Location = New System.Drawing.Point(62, 61)
        Me.CmbINOUTPORT.Name = "CmbINOUTPORT"
        Me.CmbINOUTPORT.Size = New System.Drawing.Size(122, 20)
        Me.CmbINOUTPORT.TabIndex = 2
        '
        'cmbcode_route
        '
        Me.cmbcode_route.Location = New System.Drawing.Point(62, 105)
        Me.cmbcode_route.Name = "cmbcode_route"
        Me.cmbcode_route.Size = New System.Drawing.Size(122, 20)
        Me.cmbcode_route.TabIndex = 3
        '
        'CmbCODE_SHIP_TYPE
        '
        Me.CmbCODE_SHIP_TYPE.Enabled = False
        Me.CmbCODE_SHIP_TYPE.Location = New System.Drawing.Point(62, 83)
        Me.CmbCODE_SHIP_TYPE.Name = "CmbCODE_SHIP_TYPE"
        Me.CmbCODE_SHIP_TYPE.Size = New System.Drawing.Size(122, 20)
        Me.CmbCODE_SHIP_TYPE.TabIndex = 3
        '
        'CmbNEXT_PORT
        '
        Me.CmbNEXT_PORT.Location = New System.Drawing.Point(62, 149)
        Me.CmbNEXT_PORT.MaxDropDownItems = 15
        Me.CmbNEXT_PORT.Name = "CmbNEXT_PORT"
        Me.CmbNEXT_PORT.Size = New System.Drawing.Size(169, 20)
        Me.CmbNEXT_PORT.TabIndex = 5
        '
        'CmbLAST_PORT
        '
        Me.CmbLAST_PORT.Location = New System.Drawing.Point(62, 127)
        Me.CmbLAST_PORT.MaxDropDownItems = 15
        Me.CmbLAST_PORT.Name = "CmbLAST_PORT"
        Me.CmbLAST_PORT.Size = New System.Drawing.Size(169, 20)
        Me.CmbLAST_PORT.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(189, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 20)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "完工时间"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(189, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 20)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "开工时间"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(189, 86)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 20)
        Me.Label22.TabIndex = 29
        Me.Label22.Text = "理货站"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(189, 64)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 20)
        Me.Label23.TabIndex = 29
        Me.Label23.Text = "船舶代理公司"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtBERTHNO
        '
        Me.TxtBERTHNO.Location = New System.Drawing.Point(62, 171)
        Me.TxtBERTHNO.MaxLength = 3
        Me.TxtBERTHNO.Name = "TxtBERTHNO"
        Me.TxtBERTHNO.Size = New System.Drawing.Size(122, 21)
        Me.TxtBERTHNO.TabIndex = 6
        '
        'DTPWORKTIME_BEGIN
        '
        Me.DTPWORKTIME_BEGIN.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DTPWORKTIME_BEGIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPWORKTIME_BEGIN.Location = New System.Drawing.Point(271, 18)
        Me.DTPWORKTIME_BEGIN.Name = "DTPWORKTIME_BEGIN"
        Me.DTPWORKTIME_BEGIN.Size = New System.Drawing.Size(122, 21)
        Me.DTPWORKTIME_BEGIN.TabIndex = 20
        '
        'CmbCODE_GOODS
        '
        Me.CmbCODE_GOODS.Location = New System.Drawing.Point(62, 216)
        Me.CmbCODE_GOODS.Name = "CmbCODE_GOODS"
        Me.CmbCODE_GOODS.Size = New System.Drawing.Size(122, 20)
        Me.CmbCODE_GOODS.TabIndex = 8
        '
        'TxtTONS
        '
        Me.TxtTONS.Location = New System.Drawing.Point(62, 238)
        Me.TxtTONS.Name = "TxtTONS"
        Me.TxtTONS.Size = New System.Drawing.Size(122, 21)
        Me.TxtTONS.TabIndex = 9
        '
        'DTPWORKTIME_END
        '
        Me.DTPWORKTIME_END.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DTPWORKTIME_END.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPWORKTIME_END.Location = New System.Drawing.Point(271, 38)
        Me.DTPWORKTIME_END.Name = "DTPWORKTIME_END"
        Me.DTPWORKTIME_END.Size = New System.Drawing.Size(122, 21)
        Me.DTPWORKTIME_END.TabIndex = 22
        '
        'CmbAGENT
        '
        Me.CmbAGENT.Location = New System.Drawing.Point(271, 62)
        Me.CmbAGENT.MaxDropDownItems = 15
        Me.CmbAGENT.Name = "CmbAGENT"
        Me.CmbAGENT.Size = New System.Drawing.Size(138, 20)
        Me.CmbAGENT.TabIndex = 10
        '
        'CmbDEPT_CODE
        '
        Me.CmbDEPT_CODE.Location = New System.Drawing.Point(271, 86)
        Me.CmbDEPT_CODE.Name = "CmbDEPT_CODE"
        Me.CmbDEPT_CODE.Size = New System.Drawing.Size(138, 20)
        Me.CmbDEPT_CODE.TabIndex = 11
        '
        'TxtSHIP_ID
        '
        Me.TxtSHIP_ID.Location = New System.Drawing.Point(11, 295)
        Me.TxtSHIP_ID.MaxLength = 4
        Me.TxtSHIP_ID.Name = "TxtSHIP_ID"
        Me.TxtSHIP_ID.ReadOnly = True
        Me.TxtSHIP_ID.Size = New System.Drawing.Size(22, 21)
        Me.TxtSHIP_ID.TabIndex = 34
        Me.TxtSHIP_ID.TabStop = False
        Me.TxtSHIP_ID.Visible = False
        '
        'TXTV_ID
        '
        Me.TXTV_ID.Location = New System.Drawing.Point(33, 295)
        Me.TXTV_ID.MaxLength = 4
        Me.TXTV_ID.Name = "TXTV_ID"
        Me.TXTV_ID.ReadOnly = True
        Me.TXTV_ID.Size = New System.Drawing.Size(22, 21)
        Me.TXTV_ID.TabIndex = 35
        Me.TXTV_ID.TabStop = False
        Me.TXTV_ID.Visible = False
        '
        'TxtCHI_VESSEL
        '
        Me.TxtCHI_VESSEL.Location = New System.Drawing.Point(55, 295)
        Me.TxtCHI_VESSEL.MaxLength = 40
        Me.TxtCHI_VESSEL.Name = "TxtCHI_VESSEL"
        Me.TxtCHI_VESSEL.ReadOnly = True
        Me.TxtCHI_VESSEL.Size = New System.Drawing.Size(22, 21)
        Me.TxtCHI_VESSEL.TabIndex = 36
        Me.TxtCHI_VESSEL.TabStop = False
        Me.TxtCHI_VESSEL.Visible = False
        '
        'ChkWORKTIME_BEGIN
        '
        Me.ChkWORKTIME_BEGIN.Location = New System.Drawing.Point(395, 18)
        Me.ChkWORKTIME_BEGIN.Name = "ChkWORKTIME_BEGIN"
        Me.ChkWORKTIME_BEGIN.Size = New System.Drawing.Size(14, 20)
        Me.ChkWORKTIME_BEGIN.TabIndex = 21
        '
        'ChkWORKTIME_END
        '
        Me.ChkWORKTIME_END.Location = New System.Drawing.Point(395, 38)
        Me.ChkWORKTIME_END.Name = "ChkWORKTIME_END"
        Me.ChkWORKTIME_END.Size = New System.Drawing.Size(14, 20)
        Me.ChkWORKTIME_END.TabIndex = 23
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(7, 175)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(138, 20)
        Me.ComboBox1.TabIndex = 121
        Me.ComboBox1.Visible = False
        '
        'ChkARRIVER_TIME
        '
        Me.ChkARRIVER_TIME.Location = New System.Drawing.Point(227, 118)
        Me.ChkARRIVER_TIME.Name = "ChkARRIVER_TIME"
        Me.ChkARRIVER_TIME.Size = New System.Drawing.Size(14, 20)
        Me.ChkARRIVER_TIME.TabIndex = 17
        Me.ChkARRIVER_TIME.Visible = False
        '
        'DTPETA_ARRIVER_TIME
        '
        Me.DTPETA_ARRIVER_TIME.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DTPETA_ARRIVER_TIME.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPETA_ARRIVER_TIME.Location = New System.Drawing.Point(35, 48)
        Me.DTPETA_ARRIVER_TIME.Name = "DTPETA_ARRIVER_TIME"
        Me.DTPETA_ARRIVER_TIME.Size = New System.Drawing.Size(122, 21)
        Me.DTPETA_ARRIVER_TIME.TabIndex = 12
        Me.DTPETA_ARRIVER_TIME.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(67, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "航次性质"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Visible = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(28, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 20)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "预计进港时间"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(13, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 20)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "预计出港时间"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Visible = False
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(67, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 20)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "运输条款"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Visible = False
        '
        'TxtTRANSIT_ITEM
        '
        Me.TxtTRANSIT_ITEM.Location = New System.Drawing.Point(135, 89)
        Me.TxtTRANSIT_ITEM.Name = "TxtTRANSIT_ITEM"
        Me.TxtTRANSIT_ITEM.Size = New System.Drawing.Size(94, 21)
        Me.TxtTRANSIT_ITEM.TabIndex = 5
        Me.TxtTRANSIT_ITEM.Visible = False
        '
        'DTPETA_SAILING_TIME
        '
        Me.DTPETA_SAILING_TIME.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DTPETA_SAILING_TIME.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPETA_SAILING_TIME.Location = New System.Drawing.Point(99, 89)
        Me.DTPETA_SAILING_TIME.Name = "DTPETA_SAILING_TIME"
        Me.DTPETA_SAILING_TIME.Size = New System.Drawing.Size(122, 21)
        Me.DTPETA_SAILING_TIME.TabIndex = 14
        Me.DTPETA_SAILING_TIME.Visible = False
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(9, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 20)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "到港时间"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Visible = False
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(9, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 20)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "靠泊时间"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label12.Visible = False
        '
        'DTPARRIVER_TIME
        '
        Me.DTPARRIVER_TIME.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DTPARRIVER_TIME.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPARRIVER_TIME.Location = New System.Drawing.Point(3, 281)
        Me.DTPARRIVER_TIME.Name = "DTPARRIVER_TIME"
        Me.DTPARRIVER_TIME.Size = New System.Drawing.Size(122, 21)
        Me.DTPARRIVER_TIME.TabIndex = 16
        Me.DTPARRIVER_TIME.Visible = False
        '
        'DTPBERTH_TIME
        '
        Me.DTPBERTH_TIME.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DTPBERTH_TIME.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPBERTH_TIME.Location = New System.Drawing.Point(50, 66)
        Me.DTPBERTH_TIME.Name = "DTPBERTH_TIME"
        Me.DTPBERTH_TIME.Size = New System.Drawing.Size(122, 21)
        Me.DTPBERTH_TIME.TabIndex = 18
        Me.DTPBERTH_TIME.Visible = False
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(11, 89)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 20)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "委托人简称"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label17.Visible = False
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(11, 91)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(85, 20)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "出港时间"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label21.Visible = False
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(9, 89)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(85, 20)
        Me.Label24.TabIndex = 29
        Me.Label24.Text = "主要收货人"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label24.Visible = False
        '
        'DTPSAILING_TIME
        '
        Me.DTPSAILING_TIME.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DTPSAILING_TIME.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPSAILING_TIME.Location = New System.Drawing.Point(35, 121)
        Me.DTPSAILING_TIME.Name = "DTPSAILING_TIME"
        Me.DTPSAILING_TIME.Size = New System.Drawing.Size(122, 21)
        Me.DTPSAILING_TIME.TabIndex = 24
        Me.DTPSAILING_TIME.Visible = False
        '
        'TxtCLIENT
        '
        Me.TxtCLIENT.Location = New System.Drawing.Point(5, 202)
        Me.TxtCLIENT.MaxLength = 20
        Me.TxtCLIENT.Name = "TxtCLIENT"
        Me.TxtCLIENT.Size = New System.Drawing.Size(138, 21)
        Me.TxtCLIENT.TabIndex = 26
        Me.TxtCLIENT.Visible = False
        '
        'TxtCONSIGNEE
        '
        Me.TxtCONSIGNEE.Location = New System.Drawing.Point(11, 148)
        Me.TxtCONSIGNEE.MaxLength = 50
        Me.TxtCONSIGNEE.Name = "TxtCONSIGNEE"
        Me.TxtCONSIGNEE.Size = New System.Drawing.Size(138, 21)
        Me.TxtCONSIGNEE.TabIndex = 29
        Me.TxtCONSIGNEE.Visible = False
        '
        'CmbVOYAGE_NATURE
        '
        Me.CmbVOYAGE_NATURE.Location = New System.Drawing.Point(15, 316)
        Me.CmbVOYAGE_NATURE.Name = "CmbVOYAGE_NATURE"
        Me.CmbVOYAGE_NATURE.Size = New System.Drawing.Size(94, 20)
        Me.CmbVOYAGE_NATURE.TabIndex = 1
        Me.CmbVOYAGE_NATURE.Visible = False
        '
        'TxtENG_VESSEL
        '
        Me.TxtENG_VESSEL.Location = New System.Drawing.Point(169, 89)
        Me.TxtENG_VESSEL.MaxLength = 50
        Me.TxtENG_VESSEL.Name = "TxtENG_VESSEL"
        Me.TxtENG_VESSEL.ReadOnly = True
        Me.TxtENG_VESSEL.Size = New System.Drawing.Size(22, 21)
        Me.TxtENG_VESSEL.TabIndex = 37
        Me.TxtENG_VESSEL.TabStop = False
        Me.TxtENG_VESSEL.Visible = False
        '
        'TxtSHIP_STATU
        '
        Me.TxtSHIP_STATU.Location = New System.Drawing.Point(221, 118)
        Me.TxtSHIP_STATU.Name = "TxtSHIP_STATU"
        Me.TxtSHIP_STATU.ReadOnly = True
        Me.TxtSHIP_STATU.Size = New System.Drawing.Size(22, 21)
        Me.TxtSHIP_STATU.TabIndex = 39
        Me.TxtSHIP_STATU.TabStop = False
        Me.TxtSHIP_STATU.Visible = False
        '
        'TxtUSER_NAME
        '
        Me.TxtUSER_NAME.Location = New System.Drawing.Point(199, 118)
        Me.TxtUSER_NAME.Name = "TxtUSER_NAME"
        Me.TxtUSER_NAME.ReadOnly = True
        Me.TxtUSER_NAME.Size = New System.Drawing.Size(22, 21)
        Me.TxtUSER_NAME.TabIndex = 38
        Me.TxtUSER_NAME.TabStop = False
        Me.TxtUSER_NAME.Visible = False
        '
        'ChkBERTH_TIME
        '
        Me.ChkBERTH_TIME.Location = New System.Drawing.Point(227, 120)
        Me.ChkBERTH_TIME.Name = "ChkBERTH_TIME"
        Me.ChkBERTH_TIME.Size = New System.Drawing.Size(14, 20)
        Me.ChkBERTH_TIME.TabIndex = 19
        Me.ChkBERTH_TIME.Visible = False
        '
        'ChkETA_ARRIVER_TIME
        '
        Me.ChkETA_ARRIVER_TIME.Location = New System.Drawing.Point(229, 116)
        Me.ChkETA_ARRIVER_TIME.Name = "ChkETA_ARRIVER_TIME"
        Me.ChkETA_ARRIVER_TIME.Size = New System.Drawing.Size(14, 20)
        Me.ChkETA_ARRIVER_TIME.TabIndex = 13
        Me.ChkETA_ARRIVER_TIME.Visible = False
        '
        'ChkETA_SAILING_TIME
        '
        Me.ChkETA_SAILING_TIME.Location = New System.Drawing.Point(231, 118)
        Me.ChkETA_SAILING_TIME.Name = "ChkETA_SAILING_TIME"
        Me.ChkETA_SAILING_TIME.Size = New System.Drawing.Size(14, 20)
        Me.ChkETA_SAILING_TIME.TabIndex = 15
        Me.ChkETA_SAILING_TIME.Visible = False
        '
        'ChkSAILING_TIME
        '
        Me.ChkSAILING_TIME.Location = New System.Drawing.Point(229, 120)
        Me.ChkSAILING_TIME.Name = "ChkSAILING_TIME"
        Me.ChkSAILING_TIME.Size = New System.Drawing.Size(14, 20)
        Me.ChkSAILING_TIME.TabIndex = 25
        Me.ChkSAILING_TIME.Visible = False
        '
        'Label
        '
        Me.Label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label.BackColor = System.Drawing.SystemColors.Control
        Me.Label.Location = New System.Drawing.Point(248, 5)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(394, 52)
        Me.Label.TabIndex = 1
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(170, 32)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(40, 22)
        Me.btnFind.TabIndex = 1
        Me.btnFind.Text = "检索"
        '
        'BtnVesseladd
        '
        Me.BtnVesseladd.Location = New System.Drawing.Point(4, 56)
        Me.BtnVesseladd.Name = "BtnVesseladd"
        Me.BtnVesseladd.Size = New System.Drawing.Size(102, 24)
        Me.BtnVesseladd.TabIndex = 2
        Me.BtnVesseladd.Text = "新增船舶规范"
        '
        'GBV
        '
        Me.GBV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GBV.Controls.Add(Me.C1DBG)
        Me.GBV.Controls.Add(Me.TxtFind)
        Me.GBV.Controls.Add(Me.btnFind)
        Me.GBV.Controls.Add(Me.BtnVesseladd)
        Me.GBV.Controls.Add(Me.Label19)
        Me.GBV.Controls.Add(Me.BtnVesseledit)
        Me.GBV.Location = New System.Drawing.Point(0, 2)
        Me.GBV.Name = "GBV"
        Me.GBV.Size = New System.Drawing.Size(244, 379)
        Me.GBV.TabIndex = 1
        Me.GBV.TabStop = False
        '
        'C1DBG
        '
        Me.C1DBG.AllowColMove = False
        Me.C1DBG.AllowDrag = True
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("C1DBG.Images"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(2, 82)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75.0R
        Me.C1DBG.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG.Size = New System.Drawing.Size(240, 297)
        Me.C1DBG.TabIndex = 3
        Me.C1DBG.PropBag = resources.GetString("C1DBG.PropBag")
        '
        'TxtFind
        '
        Me.TxtFind.Location = New System.Drawing.Point(4, 32)
        Me.TxtFind.Name = "TxtFind"
        Me.TxtFind.Size = New System.Drawing.Size(162, 21)
        Me.TxtFind.TabIndex = 0
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(4, 14)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(210, 20)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = " 录入中文船名、英文船名、呼号"
        '
        'BtnVesseledit
        '
        Me.BtnVesseledit.Location = New System.Drawing.Point(110, 56)
        Me.BtnVesseledit.Name = "BtnVesseledit"
        Me.BtnVesseledit.Size = New System.Drawing.Size(104, 24)
        Me.BtnVesseledit.TabIndex = 2
        Me.BtnVesseledit.Text = "修改船舶规范"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.ChkSAILING_TIME)
        Me.Panel1.Controls.Add(Me.ChkETA_SAILING_TIME)
        Me.Panel1.Controls.Add(Me.ChkETA_ARRIVER_TIME)
        Me.Panel1.Controls.Add(Me.ChkBERTH_TIME)
        Me.Panel1.Controls.Add(Me.TxtUSER_NAME)
        Me.Panel1.Controls.Add(Me.TxtSHIP_STATU)
        Me.Panel1.Controls.Add(Me.TxtENG_VESSEL)
        Me.Panel1.Controls.Add(Me.TxtCONSIGNEE)
        Me.Panel1.Controls.Add(Me.CmbVOYAGE_NATURE)
        Me.Panel1.Controls.Add(Me.ChkARRIVER_TIME)
        Me.Panel1.Controls.Add(Me.TxtCLIENT)
        Me.Panel1.Controls.Add(Me.DTPETA_ARRIVER_TIME)
        Me.Panel1.Controls.Add(Me.DTPSAILING_TIME)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.DTPBERTH_TIME)
        Me.Panel1.Controls.Add(Me.DTPARRIVER_TIME)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.DTPETA_SAILING_TIME)
        Me.Panel1.Controls.Add(Me.TxtTRANSIT_ITEM)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(765, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(178, 355)
        Me.Panel1.TabIndex = 3
        '
        'FrmSShip_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(676, 384)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GBV)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.Label)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSShip_Add"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "船舶航次_增加"
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        Me.GBV.ResumeLayout(False)
        Me.GBV.PerformLayout()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim dsShip As New DataSet   '船舶数据集
    Dim DynaStrShip As String '船舶可变的条件设计
    Dim SqlStrShip As String  '船舶条件语句
    Dim FirmShip As String
    Dim SortShip As String
    Dim Find_Ship As String
    Dim Flag_Ship As Integer

    Dim ds As New DataSet
    Dim dw As New DataView
    Dim sqlda As New SqlClient.SqlDataAdapter
    Dim ds_tmp As New DataSet
    Dim dw_tmp As New DataView
    Dim sqlda_tmp As New SqlClient.SqlDataAdapter
    Dim SqlStr As String  '条件语句
    Dim SelectStr As String
    Dim DynaStr As String '可变的条件设计
    Dim FirmStr As String '不变的条件设计
    Dim ColNum As Integer '不显示的列数
    Dim Find_Temp As String
    Dim Flag_Temp As Integer

    Private Sub FrmSShip_Add_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FirmStr = " Order by CHI_VESSEL "  '" Use_Comp Like '" & Trim(G_DeptCode) & "%' and Hide_Company Like '" & Trim(G_Company) & "%' order by ID DESC" '设计初始条件  在检索后不改变的条件  '***************要修改 或 2>1
        DynaStr = " 2>1 " '设计其它初始条件    在检索后不需要的条件 ***************要修改 或 其它条件
        SqlStr = " (" & DynaStr & ")  " & FirmStr

        FillVOYAGE_NATURE()
        FillS_TRADE()
        FillINOUTPORT()
        FillCODE_SHIP_TYPE()
        Fill_PORT()
        FillCODE_GOODS()
        FillAGENT()
        FillShipOwner()
        FillDEPT_CODE()
        Fillcode_route()

        Call myDataGrid(FirmShip & DynaStrShip & SortShip)   '*****************调用船舶信息

        On Error GoTo Err
        If GL_ID > 0 Then
            Dim strsql As String
            strsql = "select * from View_Vessel where ID = " & GL_ID
            dw_tmp = Getdata(strsql, ds_tmp)
            Label.Text = ""
            If ds_tmp.Tables(0).DefaultView.Count > 0 Then
                If Len(Trim(ds_tmp.Tables(0).Rows(0).Item("CHI_VESSEL"))) > 0 Then
                    Label.Text = Label.Text & "中文船名:" & Trim(ds_tmp.Tables(0).Rows(0).Item("CHI_VESSEL")) & " "
                End If
                If Len(Trim(ds_tmp.Tables(0).Rows(0).Item("ENG_VESSEL"))) > 0 Then
                    Label.Text = Label.Text & "英文船名:" & Trim(ds_tmp.Tables(0).Rows(0).Item("ENG_VESSEL")) & " "
                End If
                If Len(Trim(ds_tmp.Tables(0).Rows(0).Item("SIGN"))) > 0 Then
                    Label.Text = Label.Text & "呼号:" & Trim(ds_tmp.Tables(0).Rows(0).Item("SIGN")) & " "
                End If
                If Len(Trim(ds_tmp.Tables(0).Rows(0).Item("NATIONALITY_CHA"))) > 0 Then
                    Label.Text = Label.Text & "国籍:" & Trim(ds_tmp.Tables(0).Rows(0).Item("NATIONALITY_CHA")) & " "
                End If
                If Len(Trim(ds_tmp.Tables(0).Rows(0).Item("Descri"))) > 0 Then
                    Label.Text = Label.Text & "班轮标识:" & Trim(ds_tmp.Tables(0).Rows(0).Item("Descri")) & " "
                End If
                If Len(Trim(ds_tmp.Tables(0).Rows(0).Item("Descr"))) > 0 Then
                    Label.Text = Label.Text & "船舶类型:" & Trim(ds_tmp.Tables(0).Rows(0).Item("Descr")) & " "
                End If
                If Len(Trim(ds_tmp.Tables(0).Rows(0).Item("GROSS_TONS"))) > 0 Then
                    Label.Text = Label.Text & "载重吨:" & Trim(ds_tmp.Tables(0).Rows(0).Item("GROSS_TONS")) & " "
                End If
                If Len(Trim(ds_tmp.Tables(0).Rows(0).Item("OWNER_SHIP"))) > 0 Then
                    Label.Text = Label.Text & "船公司:" & Trim(ds_tmp.Tables(0).Rows(0).Item("OWNER_SHIP")) & " "
                End If
            End If

            TXTV_ID.Text = ds_tmp.Tables(0).Rows(0).Item("ID")
            TxtCHI_VESSEL.Text = ds_tmp.Tables(0).Rows(0).Item("CHI_VESSEL")
            TxtENG_VESSEL.Text = ds_tmp.Tables(0).Rows(0).Item("ENG_VESSEL")
            TxtUSER_NAME.Text = Trim(G_User)

            SqlStr = "select * from SShip where Ship_ID=" & ID & ""
            dw = Updatedata(sqlda, SqlStr, ds)
            If dw.Count > 0 Then
                Me.GB.Enabled = True
                TxtSHIP_ID.Text = ds.Tables(0).Rows(0).Item("SHIP_ID")
                TxtVOYAGE.Text = ds.Tables(0).Rows(0).Item("VOYAGE")
                CmbVOYAGE_NATURE.SelectedValue = ds.Tables(0).Rows(0).Item("VOYAGE_NATURE")
                CmbS_TRADE.SelectedValue = ds.Tables(0).Rows(0).Item("S_TRADE")
                CmbINOUTPORT.SelectedValue = ds.Tables(0).Rows(0).Item("INOUTPORT")
                CmbCODE_SHIP_TYPE.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_SHIP_TYPE")
                cmbcode_route.SelectedValue = ds.Tables(0).Rows(0).Item("coderoute")
                TxtTRANSIT_ITEM.Text = ds.Tables(0).Rows(0).Item("TRANSIT_ITEM")
                CmbLAST_PORT.SelectedValue = ds.Tables(0).Rows(0).Item("LAST_PORT")
                CmbNEXT_PORT.SelectedValue = ds.Tables(0).Rows(0).Item("NEXT_PORT")
                DTPETA_ARRIVER_TIME.Value = ds.Tables(0).Rows(0).Item("ETA_ARRIVER_TIME")
                DTPETA_SAILING_TIME.Value = ds.Tables(0).Rows(0).Item("DTPETA_SAILING_TIME")
                DTPARRIVER_TIME.Value = ds.Tables(0).Rows(0).Item("ARRIVER_TIME")
                DTPBERTH_TIME.Value = ds.Tables(0).Rows(0).Item("BERTH_TIME")
                DTPWORKTIME_BEGIN.Value = ds.Tables(0).Rows(0).Item("WORKTIME_BEGIN")
                DTPWORKTIME_END.Value = ds.Tables(0).Rows(0).Item("WORKTIME_END")
                DTPSAILING_TIME.Value = ds.Tables(0).Rows(0).Item("SAILING_TIME")
                TxtBERTHNO.Text = ds.Tables(0).Rows(0).Item("BERTHNO")
                cmb_BERTH_POSITION.Text = ds.Tables(0).Rows(0).Item("BERTH_POSITION")
                CmbCODE_GOODS.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_GOODS")
                TxtTONS.Text = ds.Tables(0).Rows(0).Item("TONS")
                TxtCLIENT.Text = ds.Tables(0).Rows(0).Item("CLIENT")
                CmbAGENT.SelectedValue = ds.Tables(0).Rows(0).Item("AGENT")
                TxtCONSIGNEE.Text = ds.Tables(0).Rows(0).Item("TPC")
                CmbDEPT_CODE.SelectedValue = ds.Tables(0).Rows(0).Item("DEPT_CODE")
                TxtREMARK.Text = ds.Tables(0).Rows(0).Item("REMARK")
                TxtSHIP_STATU.Text = ds.Tables(0).Rows(0).Item("SHIP_STATU")
                DTPETA_ARRIVER_TIME.Enabled = False
                DTPETA_SAILING_TIME.Enabled = False
                DTPARRIVER_TIME.Enabled = False
                DTPBERTH_TIME.Enabled = False
                DTPWORKTIME_BEGIN.Enabled = False
                DTPWORKTIME_END.Enabled = False
                DTPSAILING_TIME.Enabled = False

                checkCmbCODE_GOODS()
            End If
            Exit Sub
Err:
            Resume Next
        End If
    End Sub

    Private Sub CmbCODE_GOODS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCODE_GOODS.SelectedIndexChanged
        If CmbCODE_GOODS.SelectedIndex > 0 Then
            checkCmbCODE_GOODS()
        End If
    End Sub

    Private Sub checkCmbCODE_GOODS()
        If CmbCODE_GOODS.SelectedValue = 2 Then
            Label30.Visible = True
            Label31.Visible = True
            TxtVessel_Code.Visible = True
            CmbShipOwner.Visible = True
        Else
            Label30.Visible = False
            Label31.Visible = False
            TxtVessel_Code.Visible = False
            CmbShipOwner.Visible = False
        End If
    End Sub

    Private Sub myDataGrid(ByVal Sql As String) '**************船舶信息
        Dim strsql As String
        Dim i As Integer
        strsql = "select ID,CHI_VESSEL,ENG_VESSEL,SIGN from View_Vessel " '船舶条件语句 不改部分
        strsql = strsql & Sql
        Try
            Me.C1DBG.DataSource = Getdata(strsql, dsShip)
            Me.C1DBG.Splits(0).DisplayColumns.Item(0).Visible = False
            Me.C1DBG.Columns.Item(1).Caption = "中文船名"
            Me.C1DBG.Columns.Item(2).Caption = "英文船名"
            Me.C1DBG.Columns.Item(3).Caption = "呼号"
            Me.C1DBG.Splits(0).DisplayColumns.Item(1).Width = 60
            Me.C1DBG.Splits(0).DisplayColumns.Item(2).Width = 78
            Me.C1DBG.Splits(0).DisplayColumns.Item(3).Width = 35

            If dsShip.Tables(0).Rows.Count > 0 Then
                Call SetColumnSum(1)  '设计合计列
            End If
            Me.C1DBG.FetchRowStyles = True
            Me.C1DBG.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        TxtFind.Focus()
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
    End Sub

    Private Sub SetColumnSum(ByVal Col As Integer) '****************航次汇总行
        Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBG.Columns.Item(Col).FooterText = "共" & dsShip.Tables(0).Rows.Count & "条"
    End Sub

    Private Sub C1DBG_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1DBG.DoubleClick
        On Error GoTo Err
        Dim dsShip As New DataSet
        Dim strsql As String
        Dim dv As New DataView

        Call btnAdd_Click(sender, e)
        ID = CType(Me.C1DBG.Columns.Item(0).Text.ToString, Integer)
        ' SqlStr = "select * from SShip where Ship_ID=" & ID & ""
        strsql = "select * from View_Vessel where ID =" & ID & ""
        dv = Getdata(strsql, dsShip)

        Label.Text = ""
        If dsShip.Tables(0).DefaultView.Count > 0 Then
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))) > 0 Then
                Label.Text = Label.Text & " 中文船名: " & Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL"))) > 0 Then
                Label.Text = Label.Text & " 英文船名: " & Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL"))
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("InOutPort_Name"))) > 0 Then
                Label.Text = Label.Text & " 呼号: " & Trim(dsShip.Tables(0).Rows(0).Item("SIGN"))
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))) > 0 Then
                Label.Text = Label.Text & " 国籍: " & Trim(dsShip.Tables(0).Rows(0).Item("NATIONALITY_CHA"))
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Trade"))) > 0 Then
                Label.Text = Label.Text & " 班轮标识: " & Trim(dsShip.Tables(0).Rows(0).Item("Descri"))
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("SHIP_TYPE"))) > 0 Then
                Label.Text = Label.Text & " 船舶类型: " & Trim(dsShip.Tables(0).Rows(0).Item("Descr"))
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("SHIPAGENT_CHAE"))) > 0 Then
                Label.Text = Label.Text & " 载重吨: " & Trim(dsShip.Tables(0).Rows(0).Item("TON_DEAD"))
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("GOODS"))) > 0 Then
                Label.Text = Label.Text & " 船公司: " & Trim(dsShip.Tables(0).Rows(0).Item("OWNER_SHIP"))
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Vessel_Code"))) > 0 Then
                TxtVessel_Code.Text = dsShip.Tables(0).Rows(0).Item("Vessel_Code")
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("NATIONALITY_CODE"))) > 0 Then
                If dsShip.Tables(0).Rows(0).Item("NATIONALITY_CODE") = "" Then
                    CmbCODE_SHIP_TYPE.Text = ""
                ElseIf dsShip.Tables(0).Rows(0).Item("NATIONALITY_CODE") = "CN" Then
                    CmbCODE_SHIP_TYPE.Text = "国轮"
                Else
                    CmbCODE_SHIP_TYPE.Text = "外轮"
                End If
            Else
                CmbCODE_SHIP_TYPE.Text = ""
            End If
        End If
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色

        TXTV_ID.Text = dsShip.Tables(0).Rows(0).Item("ID")
        TxtCHI_VESSEL.Text = dsShip.Tables(0).Rows(0).Item("CHI_VESSEL")
        TxtENG_VESSEL.Text = dsShip.Tables(0).Rows(0).Item("ENG_VESSEL")
        TxtUSER_NAME.Text = Trim(G_User)

        SqlStr = "select * from SShip where V_ID=" & ID & " and ship_statu in ('1','2','3')"
        dw = Updatedata(sqlda, SqlStr, ds)
        If dw.Count > 0 Then
            '    Me.GB.Enabled = False
            '    MsgBox("此船已在港或已预报！")
            '    Exit Sub
            'ElseIf dw.Count = 1 Then
            TxtSHIP_ID.Text = ds.Tables(0).Rows(0).Item("SHIP_ID")
            TxtVOYAGE.Text = ds.Tables(0).Rows(0).Item("VOYAGE")
            CmbVOYAGE_NATURE.SelectedValue = ds.Tables(0).Rows(0).Item("VOYAGE_NATURE")
            CmbS_TRADE.SelectedValue = ds.Tables(0).Rows(0).Item("S_TRADE")

            CmbCODE_SHIP_TYPE.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_SHIP_TYPE")
            cmbcode_route.SelectedValue = ds.Tables(0).Rows(0).Item("coderoute")
            TxtTRANSIT_ITEM.Text = ds.Tables(0).Rows(0).Item("TRANSIT_ITEM")
            CmbLAST_PORT.SelectedValue = ds.Tables(0).Rows(0).Item("LAST_PORT")
            CmbNEXT_PORT.SelectedValue = ds.Tables(0).Rows(0).Item("NEXT_PORT")
            CmbINOUTPORT.SelectedValue = ds.Tables(0).Rows(0).Item("INOUTPORT")

            If ChkETA_ARRIVER_TIME.Checked = True Then
                DTPETA_ARRIVER_TIME.Value = ds.Tables(0).Rows(0).Item("ETA_ARRIVER_TIME")
            End If
            If ChkETA_SAILING_TIME.Checked = True Then
                DTPETA_SAILING_TIME.Value = ds.Tables(0).Rows(0).Item("ETA_SAILING_TIME")
            End If
            If ChkARRIVER_TIME.Checked = True Then
                DTPARRIVER_TIME.Value = ds.Tables(0).Rows(0).Item("ARRIVER_TIME")
            End If
            If ChkBERTH_TIME.Checked = True Then
                DTPBERTH_TIME.Value = ds.Tables(0).Rows(0).Item("BERTH_TIME")
            End If
            If ChkWORKTIME_BEGIN.Checked = True Then
                DTPWORKTIME_BEGIN.Value = ds.Tables(0).Rows(0).Item("WORKTIME_BEGIN")
            End If
            If ChkWORKTIME_END.Checked = True Then
                DTPWORKTIME_END.Value = ds.Tables(0).Rows(0).Item("WORKTIME_END")
            End If
            If ChkSAILING_TIME.Checked = True Then
                DTPSAILING_TIME.Value = ds.Tables(0).Rows(0).Item("SAILING_TIME")
            End If
            TxtBERTHNO.Text = ds.Tables(0).Rows(0).Item("BERTHNO")
            cmb_BERTH_POSITION.SelectedValue = ds.Tables(0).Rows(0).Item("BERTH_POSITION")
            CmbCODE_GOODS.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_GOODS")
            TxtTONS.Text = ds.Tables(0).Rows(0).Item("TONS")
            TxtCLIENT.Text = ds.Tables(0).Rows(0).Item("CLIENT")
            CmbAGENT.SelectedValue = ds.Tables(0).Rows(0).Item("AGENT")
            TxtCONSIGNEE.Text = ds.Tables(0).Rows(0).Item("CONSIGNEE")
            CmbDEPT_CODE.SelectedValue = ds.Tables(0).Rows(0).Item("DEPT_CODE")
            TxtREMARK.Text = ds.Tables(0).Rows(0).Item("REMARK")
            TxtSHIP_STATU.Text = ds.Tables(0).Rows(0).Item("SHIP_STATU")
        End If
        Me.GB.Enabled = True
        TxtVOYAGE.Focus()
        Exit Sub
Err:
        Resume Next

    End Sub

    Private Sub FillVOYAGE_NATURE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "select Voyage_Nature,Voyage_Nature_Name from Code_Voyage_Nature"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbVOYAGE_NATURE.DataSource = dvc
        Me.CmbVOYAGE_NATURE.DisplayMember = "Voyage_Nature_Name"
        Me.CmbVOYAGE_NATURE.ValueMember = "Voyage_Nature"
    End Sub

    Private Sub FillS_TRADE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "select S_Trade,Trade from Code_Trade"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbS_TRADE.DataSource = dvc
        Me.CmbS_TRADE.DisplayMember = "Trade"
        Me.CmbS_TRADE.ValueMember = "S_Trade"
    End Sub

    Private Sub FillINOUTPORT()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "select InOutPort,InOutPort_Name from Code_InOutPort"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbINOUTPORT.DataSource = dvc
        Me.CmbINOUTPORT.DisplayMember = "InOutPort_Name"
        Me.CmbINOUTPORT.ValueMember = "InOutPort"
    End Sub

    Private Sub FillCODE_SHIP_TYPE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "select CODE_SHIP_TYPE,SHIP_TYPE from CODE_SHIPTYPE"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbCODE_SHIP_TYPE.DataSource = dvc
        Me.CmbCODE_SHIP_TYPE.DisplayMember = "SHIP_TYPE"
        Me.CmbCODE_SHIP_TYPE.ValueMember = "CODE_SHIP_TYPE"
    End Sub

    Private Sub Fillcode_route()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "select coderoute,routename from code_route"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.cmbcode_route.DataSource = dvc
        Me.cmbcode_route.DisplayMember = "routename"
        Me.cmbcode_route.ValueMember = "coderoute"
    End Sub

    Dim dvPort1, dvPort2 As DataView
    Private Sub Fill_PORT()
        Dim sqlPort As String
        sqlPort = "select CODE_PORT,PORT_ENG + '|' +PORT_CHA PORT_NAME from CODE_PORT order by PORT_ENG"
        dvPort1 = DBControl.Filldata(sqlPort)
        Me.CmbLAST_PORT.DataSource = dvPort1
        Me.CmbLAST_PORT.DisplayMember = "PORT_NAME"
        Me.CmbLAST_PORT.ValueMember = "CODE_PORT"
        dvPort2 = dvPort1.ToTable().DefaultView
        Me.CmbNEXT_PORT.DataSource = dvPort2
        Me.CmbNEXT_PORT.DisplayMember = "PORT_NAME"
        Me.CmbNEXT_PORT.ValueMember = "CODE_PORT"
    End Sub

    Private Sub CombLOAD_PORT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbLAST_PORT.Leave
        Dim DSSELECT As New DataSet
        Try
            If Len(Trim(CmbLAST_PORT.Text)) > 0 Then
                'Dim str As String
                'str = "SELECT * FROM CODE_port WHERE code_port like '%" & Trim(CmbLAST_PORT.Text) & "%' or port_cha like '%" & Trim(CmbLAST_PORT.Text) & "%' or port_eng like '%" & Trim(CmbLAST_PORT.Text) & "%'"
                dw = Getdata("SELECT * FROM CODE_port WHERE code_port like '%" & Trim(CmbLAST_PORT.Text) & "%' or port_cha like '%" & Trim(CmbLAST_PORT.Text) & "%' order by port_cha ", DSSELECT)
                If DSSELECT.Tables(0).Rows.Count > 0 Then
                    Me.CmbLAST_PORT.DataSource = dw
                    Me.CmbLAST_PORT.DisplayMember = "PORT_CHA"
                    Me.CmbLAST_PORT.ValueMember = "CODE_PORT"
                    CmbLAST_PORT.SelectedValue = DSSELECT.Tables(0).Rows(0).Item("code_port")
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CombUNLOAD_PORT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbNEXT_PORT.Leave
        Dim DSSELECT As New DataSet
        Try
            If Len(Trim(CmbNEXT_PORT.Text)) > 0 Then
                dw = Getdata("SELECT * FROM CODE_port WHERE code_port like '%" & Trim(CmbNEXT_PORT.Text) & "%' or port_cha like '%" & Trim(CmbNEXT_PORT.Text) & "%' order by port_cha ", DSSELECT)
                If DSSELECT.Tables(0).Rows.Count > 0 Then
                    Me.CmbNEXT_PORT.DataSource = dw
                    Me.CmbNEXT_PORT.DisplayMember = "PORT_CHA"
                    Me.CmbNEXT_PORT.ValueMember = "CODE_PORT"
                    CmbNEXT_PORT.SelectedValue = DSSELECT.Tables(0).Rows(0).Item("code_port")
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FillCODE_GOODS()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "select Code_Cargo_Type,Cargo_Type from Code_Cargo_Type"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbCODE_GOODS.DataSource = dvc
        Me.CmbCODE_GOODS.DisplayMember = "Cargo_Type"
        Me.CmbCODE_GOODS.ValueMember = "Code_Cargo_Type"
    End Sub

    Private Sub FillAGENT()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "select SHIPAGENT_SHORT,CODE_SHIP_AGENT from CODE_SHIP_AGENT where mark='1' order by SHIPAGENT_SHORT"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbAGENT.DataSource = dvc
        Me.CmbAGENT.DisplayMember = "SHIPAGENT_SHORT"
        Me.CmbAGENT.ValueMember = "CODE_SHIP_AGENT"
    End Sub

    Private Sub FillShipOwner()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "select CODE_SHIPOWNER,SHIPOWNER_SHORT from CODE_SHIP_OWNER order by SHIPOWNER_SHORT"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbShipOwner.DataSource = dvc
        Me.CmbShipOwner.DisplayMember = "SHIPOWNER_SHORT"
        Me.CmbShipOwner.ValueMember = "CODE_SHIPOWNER"
    End Sub

    Private Sub FillDEPT_CODE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "select DEPT_CODE,DEPT_NAME from DEPARTMENT where dept_code='00' or dept_code like '26.11.1%'"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbDEPT_CODE.DataSource = dvc
        Me.CmbDEPT_CODE.DisplayMember = "DEPT_NAME"
        Me.CmbDEPT_CODE.ValueMember = "DEPT_CODE"
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Dim Sql_Find As String
        If Len(Trim(TxtFind.Text)) > 0 Then
            Sql_Find = Trim(TxtFind.Text)
            SqlStr = "where (CHI_VESSEL LIKE '%" & Sql_Find & "%') OR (ENG_VESSEL LIKE '%" & Sql_Find & "%') OR (SIGN LIKE '%" & Sql_Find & "%') "
        Else
            Sql_Find = ""
            SqlStr = ""
        End If
        Call myDataGrid(SqlStr)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        TxtVOYAGE.Text = ""
        Call FillVOYAGE_NATURE()
        Call FillS_TRADE()
        Call FillINOUTPORT()
        Call FillCODE_SHIP_TYPE()
        TxtTRANSIT_ITEM.Text = ""
        Call Fill_PORT()
        DTPETA_ARRIVER_TIME.Value = Now
        DTPETA_SAILING_TIME.Value = Now
        DTPARRIVER_TIME.Value = Now
        DTPBERTH_TIME.Value = Now
        TxtBERTHNO.Text = ""
        cmb_BERTH_POSITION.Text = ""
        DTPWORKTIME_BEGIN.Value = Now
        Call FillCODE_GOODS()
        TxtTONS.Text = ""
        DTPWORKTIME_END.Value = Now
        DTPSAILING_TIME.Value = Now
        TxtCLIENT.Text = ""
        Call FillAGENT()
        TxtCONSIGNEE.Text = ""
        Call FillDEPT_CODE()
        TxtREMARK.Text = ""

        TxtVessel_Code.Text = ""
        TxtSHIP_ID.Text = ""
        TXTV_ID.Text = ""
        TxtCHI_VESSEL.Text = ""
        TxtENG_VESSEL.Text = ""
        TxtUSER_NAME.Text = ""
        TxtSHIP_STATU.Text = ""
        TxtVOYAGE.Focus()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If CmbCODE_GOODS.SelectedValue = 2 Then
                If Len(Trim(TxtVessel_Code.Text)) = 0 Then
                    MsgBox("船码一栏不能为空！", MsgBoxStyle.Exclamation, "提示")
                    Exit Sub
                Else
                    If Getdata("select id from code_shipname where spcode ='" & TxtVessel_Code.Text & "'", ds_tmp).Count() = 0 Then
                        MsgBox("不存在此船码！", MsgBoxStyle.Exclamation, "提示")
                        Exit Sub
                    End If
                End If
            End If
            If Getdata("select * from SShip where VOYAGE='" & Trim(TxtVOYAGE.Text) & "' and V_ID =" & TXTV_ID.Text & " ", ds_tmp).Count > 0 Then
                MsgBox("可能已存在此船舶航次,请注意检查!", vbExclamation, "提示")
                Exit Sub
            End If
            If Len(Trim(CmbAGENT.Text)) = 0 Then
                MsgBox("船代一栏不能为空！", MsgBoxStyle.Exclamation, "提示")
                Exit Sub
            End If

            If Len(Trim(TxtVOYAGE.Text)) > 0 Then
                If Len(Trim(CmbS_TRADE.Text)) > 0 Then
                    If Len(Trim(CmbINOUTPORT.Text)) > 0 Then
                        If Len(Trim(CmbCODE_SHIP_TYPE.Text)) > 0 Then
                            If Len(Trim(CmbCODE_GOODS.Text)) > 0 Then
                                If MsgBox("你确认要添加数据吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
                                    Dim row As DataRow
                                    row = ds.Tables(0).NewRow()

                                    row("VOYAGE") = Trim(TxtVOYAGE.Text)
                                    If Len(Trim(CmbVOYAGE_NATURE.Text)) > 0 Then
                                        row("VOYAGE_NATURE") = CmbVOYAGE_NATURE.SelectedValue
                                    End If
                                    row("S_TRADE") = CmbS_TRADE.SelectedValue
                                    row("INOUTPORT") = CmbINOUTPORT.SelectedValue
                                    row("CODE_SHIP_TYPE") = CmbCODE_SHIP_TYPE.SelectedValue
                                    row("coderoute") = cmbcode_route.SelectedValue
                                    row("TRANSIT_ITEM") = Trim(TxtTRANSIT_ITEM.Text)
                                    If Len(Trim(CmbLAST_PORT.Text)) > 0 Then
                                        row("LAST_PORT") = CmbLAST_PORT.SelectedValue
                                    End If
                                    If Len(Trim(CmbNEXT_PORT.Text)) > 0 Then
                                        row("NEXT_PORT") = CmbNEXT_PORT.SelectedValue
                                    End If
                                    If DTPETA_ARRIVER_TIME.Enabled = True Then
                                        row("ETA_ARRIVER_TIME") = DTPETA_ARRIVER_TIME.Value
                                    End If
                                    If DTPETA_SAILING_TIME.Enabled = True Then
                                        row("ETA_SAILING_TIME") = DTPETA_SAILING_TIME.Value
                                    End If
                                    If DTPARRIVER_TIME.Enabled = True Then
                                        row("ARRIVER_TIME") = DTPARRIVER_TIME.Value
                                    End If
                                    If DTPBERTH_TIME.Enabled = True Then
                                        row("BERTH_TIME") = DTPBERTH_TIME.Value
                                    End If

                                    If Len(Trim(TxtBERTHNO.Text)) > 0 Then
                                        TxtBERTHNO.Text = Trim(TxtBERTHNO.Text) / 1

                                        If Len(Trim(CmbDEPT_CODE.Text)) = 0 Then
                                            Call TxtBERTHNO_TextChanged(sender, e)
                                        End If

                                        If IsNumeric(Trim(TxtBERTHNO.Text)) Then
                                            row("BERTHNO") = Trim(TxtBERTHNO.Text)
                                        Else
                                            MsgBox("泊位号一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                                            Exit Sub
                                        End If
                                    End If

                                    row("BERTH_POSITION") = cmb_BERTH_POSITION.Text
                                    If DTPWORKTIME_BEGIN.Enabled = True Then
                                        row("WORKTIME_BEGIN") = DTPWORKTIME_BEGIN.Value
                                    End If
                                    row("CODE_GOODS") = CmbCODE_GOODS.SelectedValue

                                    If Len(Trim(TxtTONS.Text)) > 0 Then
                                        If IsNumeric(Trim(TxtTONS.Text)) Then
                                            row("TONS") = Trim(TxtTONS.Text)
                                        Else
                                            MsgBox("吨数一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                                            Exit Sub
                                        End If
                                    End If

                                    If DTPWORKTIME_END.Enabled = True Then
                                        row("WORKTIME_END") = DTPWORKTIME_END.Value
                                    End If
                                    If DTPSAILING_TIME.Enabled = True Then
                                        row("SAILING_TIME") = DTPSAILING_TIME.Value
                                    End If
                                    row("CLIENT") = Trim(TxtCLIENT.Text)
                                    If Len(Trim(CmbAGENT.Text)) > 0 Then
                                        row("AGENT") = CmbAGENT.SelectedValue
                                    End If
                                    If Len(Trim(CmbShipOwner.Text)) > 0 Then
                                        row("Code_ShipOwner") = CmbShipOwner.SelectedValue
                                    End If
                                    row("CONSIGNEE") = Trim(TxtCONSIGNEE.Text)
                                    If G_DeptCode Like "26.11.1*" Then
                                        If CmbDEPT_CODE.SelectedValue = G_DeptCode Then
                                        Else
                                            MsgBox("部门应该为当前部门！", vbExclamation, "提示")
                                            CmbDEPT_CODE.SelectedValue = G_DeptCode
                                            Exit Sub
                                        End If
                                    End If

                                    If Len(Trim(CmbDEPT_CODE.Text)) > 0 And Len(Trim(TxtBERTHNO.Text)) > 0 Then
                                        If CmbDEPT_CODE.SelectedValue Like "2*" Then
                                            row("DEPT_CODE") = CmbDEPT_CODE.SelectedValue
                                        Else
                                            MsgBox("此时泊位号或者部门不能为空！", MsgBoxStyle.Exclamation, "提示")
                                            Exit Sub
                                        End If
                                    End If
                                    row("REMARK") = Trim(TxtREMARK.Text)
                                    row("V_ID") = Trim(TXTV_ID.Text)
                                    row("CHI_VESSEL") = Trim(TxtCHI_VESSEL.Text)
                                    row("ENG_VESSEL") = Trim(TxtENG_VESSEL.Text)
                                    row("SHIP_STATU") = "1"
                                    row("User_Name") = Trim(G_User)

                                    ds.Tables(0).Rows.Add(row)
                                    sqlda.Update(ds)

                                    ExecSql("UPDATE VESSEL SET Vessel_Code='" & Me.TxtVessel_Code.Text.Trim() & "'where VESSEL_ID=" & ID & "")

                                    If MsgBox("记录增加成功，是否要继续录入？", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "提示") = MsgBoxResult.No Then
                                        Me.Close()
                                    End If

                                End If
                            Else
                                MsgBox("船舶类别不能为空！")
                                'MsgBox("货类不能为空！")
                            End If
                        Else
                            MsgBox("国轮外轮不能为空！")
                        End If
                    Else
                        MsgBox("进出口项不能为空！")
                    End If
                Else
                    MsgBox("贸易类别不能为空！")
                End If
            Else
                MsgBox("航次不能为空！")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtFind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnFind_Click(sender, e)
        End If
        If e.KeyCode = Keys.Escape Then
            TxtFind.Text = ""
        End If
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub TxtVOYAGE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtVOYAGE.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbVOYAGE_NATURE.Focus()
            TxtVOYAGE.Text = TxtVOYAGE.Text.ToUpper()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbVOYAGE_NATURE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbVOYAGE_NATURE.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbS_TRADE.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbS_TRADE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbS_TRADE.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbINOUTPORT.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbINOUTPORT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbINOUTPORT.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbCODE_SHIP_TYPE.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbCODE_SHIP_TYPE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbCODE_SHIP_TYPE.KeyDown, cmbcode_route.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTRANSIT_ITEM.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtTRANSIT_ITEM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTRANSIT_ITEM.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbLAST_PORT.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbLAST_PORT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbLAST_PORT.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbNEXT_PORT.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbNEXT_PORT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbNEXT_PORT.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtBERTHNO.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtBERTHNO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBERTHNO.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmb_BERTH_POSITION.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub cmb_BERTH_POSITION_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmb_BERTH_POSITION.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbCODE_GOODS.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbCODE_GOODS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbCODE_GOODS.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTONS.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtTONS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTONS.KeyDown
        If e.KeyCode = Keys.Enter Then
            DTPETA_ARRIVER_TIME.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub DTPETA_ARRIVER_TIME_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DTPETA_ARRIVER_TIME.KeyDown
        If e.KeyCode = Keys.Enter Then
            DTPETA_SAILING_TIME.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub DTPETA_SAILING_TIME_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DTPETA_SAILING_TIME.KeyDown
        If e.KeyCode = Keys.Enter Then
            DTPARRIVER_TIME.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub DTPARRIVER_TIME_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DTPARRIVER_TIME.KeyDown
        If e.KeyCode = Keys.Enter Then
            DTPBERTH_TIME.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub DTPBERTH_TIME_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DTPBERTH_TIME.KeyDown
        If e.KeyCode = Keys.Enter Then
            DTPWORKTIME_BEGIN.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub DTPWORKTIME_BEGIN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DTPWORKTIME_BEGIN.KeyDown
        If e.KeyCode = Keys.Enter Then
            DTPWORKTIME_END.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub DTPWORKTIME_END_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DTPWORKTIME_END.KeyDown
        If e.KeyCode = Keys.Enter Then
            DTPSAILING_TIME.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub DTPSAILING_TIME_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DTPSAILING_TIME.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtCLIENT.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtCLIENT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCLIENT.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbAGENT.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbAGENT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbAGENT.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtCONSIGNEE.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtCONSIGNEE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCONSIGNEE.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbDEPT_CODE.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbDEPT_CODE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbDEPT_CODE.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtREMARK.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtREMARK_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnSave.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnAdd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnAdd.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnVesseladd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BtnVesseladd.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            Call BtnVesseladd_Click(sender, e)
        End If
    End Sub

    Private Sub btnQuit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnQuit.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnFind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnFind.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnSave.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub C1DBG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1DBG.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub ChkETA_ARRIVER_TIME_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkETA_ARRIVER_TIME.CheckedChanged
        If ChkETA_ARRIVER_TIME.Checked = True Then
            DTPETA_ARRIVER_TIME.Enabled = True
        Else
            DTPETA_ARRIVER_TIME.Enabled = False
        End If
    End Sub

    Private Sub ChkETA_SAILING_TIME_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkETA_SAILING_TIME.CheckedChanged
        If ChkETA_SAILING_TIME.Checked = True Then
            DTPETA_SAILING_TIME.Enabled = True
        Else
            DTPETA_SAILING_TIME.Enabled = False
        End If
    End Sub

    Private Sub ChkARRIVER_TIME_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkARRIVER_TIME.CheckedChanged
        If ChkARRIVER_TIME.Checked = True Then
            DTPARRIVER_TIME.Enabled = True
        Else
            DTPARRIVER_TIME.Enabled = False
        End If
    End Sub

    Private Sub ChkBERTH_TIME_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkBERTH_TIME.CheckedChanged
        If ChkBERTH_TIME.Checked = True Then
            DTPBERTH_TIME.Enabled = True
        Else
            DTPBERTH_TIME.Enabled = False
        End If
    End Sub

    Private Sub ChkWORKTIME_BEGIN_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkWORKTIME_BEGIN.CheckedChanged
        If ChkWORKTIME_BEGIN.Checked = True Then
            DTPWORKTIME_BEGIN.Enabled = True
        Else
            DTPWORKTIME_BEGIN.Enabled = False
        End If
    End Sub

    Private Sub ChkWORKTIME_END_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkWORKTIME_END.CheckedChanged
        If ChkWORKTIME_END.Checked = True Then
            DTPWORKTIME_END.Enabled = True
        Else
            DTPWORKTIME_END.Enabled = False
        End If
    End Sub

    Private Sub ChkSAILING_TIME_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkSAILING_TIME.CheckedChanged
        If ChkSAILING_TIME.Checked = True Then
            DTPSAILING_TIME.Enabled = True
        Else
            DTPSAILING_TIME.Enabled = False
        End If
    End Sub

    Private Sub BtnVesseladd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnVesseladd.Click
        Dim FrmAdd As New FrmVessel_Papers_Add
        FrmAdd.ShowDialog()
    End Sub

    Private Sub BtnVesseledit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVesseledit.Click
        Dim FrmEdit As New FrmVessel_Papers_Edit
        ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
        FrmEdit.ShowDialog()
    End Sub

    Private Sub TxtBERTHNO_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtBERTHNO.TextChanged
        Dim sqldc As String
        Dim sqldv As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldv = "SELECT DEPT_CODE FROM CODE_BERTH WHERE CODE_BERTH = '" & TxtBERTHNO.Text & "' "
        dvc = Getdata(sqldv, dsc)
        If dsc.Tables(0).DefaultView.Count > 0 Then
            Me.CmbDEPT_CODE.SelectedValue = dsc.Tables(0).Rows(0).Item("Dept_Code")
        End If
    End Sub

    Private Sub TxtFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFind.TextChanged
        Me.GB.Enabled = False
        Call btnFind_Click(sender, e)
    End Sub

    Private Sub CmbINOUTPORT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbINOUTPORT.SelectedIndexChanged
        If CmbINOUTPORT.Text = "进口" Then
            CmbNEXT_PORT.SelectedValue = "CNLYG"
        ElseIf CmbINOUTPORT.Text = "出口" Then
            CmbLAST_PORT.SelectedValue = "CNLYG"
        End If
    End Sub

End Class
