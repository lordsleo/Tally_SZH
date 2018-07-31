Imports TALLY.DBControl
Public Class FrmSShip_Query
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim dw As New DataView()
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbcode_route As System.Windows.Forms.ComboBox
    Friend WithEvents TxtVessel_Code As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dv As New DataSet

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
    Friend WithEvents DTPETA_ARRIVER_TIME As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbS_TRADE As System.Windows.Forms.ComboBox
    Friend WithEvents TxtVOYAGE As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmbINOUTPORT As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCODE_SHIP_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtTRANSIT_ITEM As System.Windows.Forms.TextBox
    Friend WithEvents CmbNEXT_PORT As System.Windows.Forms.ComboBox
    Friend WithEvents CmbLAST_PORT As System.Windows.Forms.ComboBox
    Friend WithEvents DTPETA_SAILING_TIME As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DTPARRIVER_TIME As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPBERTH_TIME As System.Windows.Forms.DateTimePicker
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
    Friend WithEvents TxtBERTHNO As System.Windows.Forms.TextBox
    Friend WithEvents TxtBERTH_POSITION As System.Windows.Forms.TextBox
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
    Friend WithEvents TxtUSER_NAME As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents CmbSHIP_STATU As System.Windows.Forms.ComboBox
    Friend WithEvents TxtFILE_NO As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents CmbShipOwner As System.Windows.Forms.ComboBox
    Friend WithEvents TxtREMARK As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DTPETA_ARRIVER_TIME = New System.Windows.Forms.DateTimePicker
        Me.CmbS_TRADE = New System.Windows.Forms.ComboBox
        Me.TxtVOYAGE = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnQuit = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.CmbINOUTPORT = New System.Windows.Forms.ComboBox
        Me.CmbCODE_SHIP_TYPE = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtTRANSIT_ITEM = New System.Windows.Forms.TextBox
        Me.CmbNEXT_PORT = New System.Windows.Forms.ComboBox
        Me.CmbLAST_PORT = New System.Windows.Forms.ComboBox
        Me.DTPETA_SAILING_TIME = New System.Windows.Forms.DateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.DTPARRIVER_TIME = New System.Windows.Forms.DateTimePicker
        Me.DTPBERTH_TIME = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.TxtBERTHNO = New System.Windows.Forms.TextBox
        Me.TxtBERTH_POSITION = New System.Windows.Forms.TextBox
        Me.DTPWORKTIME_BEGIN = New System.Windows.Forms.DateTimePicker
        Me.CmbCODE_GOODS = New System.Windows.Forms.ComboBox
        Me.TxtTONS = New System.Windows.Forms.TextBox
        Me.DTPSAILING_TIME = New System.Windows.Forms.DateTimePicker
        Me.DTPWORKTIME_END = New System.Windows.Forms.DateTimePicker
        Me.TxtCLIENT = New System.Windows.Forms.TextBox
        Me.TxtCONSIGNEE = New System.Windows.Forms.TextBox
        Me.CmbAGENT = New System.Windows.Forms.ComboBox
        Me.CmbDEPT_CODE = New System.Windows.Forms.ComboBox
        Me.CmbVOYAGE_NATURE = New System.Windows.Forms.ComboBox
        Me.TxtSHIP_ID = New System.Windows.Forms.TextBox
        Me.TXTV_ID = New System.Windows.Forms.TextBox
        Me.TxtCHI_VESSEL = New System.Windows.Forms.TextBox
        Me.TxtENG_VESSEL = New System.Windows.Forms.TextBox
        Me.TxtUSER_NAME = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.CmbSHIP_STATU = New System.Windows.Forms.ComboBox
        Me.TxtFILE_NO = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.TxtREMARK = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.CmbShipOwner = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.cmbcode_route = New System.Windows.Forms.ComboBox
        Me.TxtVessel_Code = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'DTPETA_ARRIVER_TIME
        '
        Me.DTPETA_ARRIVER_TIME.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DTPETA_ARRIVER_TIME.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPETA_ARRIVER_TIME.Location = New System.Drawing.Point(74, 387)
        Me.DTPETA_ARRIVER_TIME.Name = "DTPETA_ARRIVER_TIME"
        Me.DTPETA_ARRIVER_TIME.Size = New System.Drawing.Size(118, 21)
        Me.DTPETA_ARRIVER_TIME.TabIndex = 17
        Me.DTPETA_ARRIVER_TIME.Visible = False
        '
        'CmbS_TRADE
        '
        Me.CmbS_TRADE.Location = New System.Drawing.Point(62, 74)
        Me.CmbS_TRADE.Name = "CmbS_TRADE"
        Me.CmbS_TRADE.Size = New System.Drawing.Size(118, 20)
        Me.CmbS_TRADE.TabIndex = 5
        '
        'TxtVOYAGE
        '
        Me.TxtVOYAGE.Location = New System.Drawing.Point(62, 50)
        Me.TxtVOYAGE.MaxLength = 17
        Me.TxtVOYAGE.Name = "TxtVOYAGE"
        Me.TxtVOYAGE.Size = New System.Drawing.Size(118, 21)
        Me.TxtVOYAGE.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "航次"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(155, 312)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(65, 24)
        Me.btnQuit.TabIndex = 0
        Me.btnQuit.Text = "返  回"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(204, 366)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "航次性质"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "进出口"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(4, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 20)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "贸易类别"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(4, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 20)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "国轮外轮"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbINOUTPORT
        '
        Me.CmbINOUTPORT.Location = New System.Drawing.Point(62, 96)
        Me.CmbINOUTPORT.Name = "CmbINOUTPORT"
        Me.CmbINOUTPORT.Size = New System.Drawing.Size(118, 20)
        Me.CmbINOUTPORT.TabIndex = 6
        '
        'CmbCODE_SHIP_TYPE
        '
        Me.CmbCODE_SHIP_TYPE.Location = New System.Drawing.Point(62, 118)
        Me.CmbCODE_SHIP_TYPE.Name = "CmbCODE_SHIP_TYPE"
        Me.CmbCODE_SHIP_TYPE.Size = New System.Drawing.Size(118, 20)
        Me.CmbCODE_SHIP_TYPE.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(4, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 20)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "装货港口"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(178, 366)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "预计进港时间"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(174, 366)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 20)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "预计出港时间"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(4, 181)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 20)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "卸货港口"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(198, 368)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 20)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "运输条款"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Visible = False
        '
        'TxtTRANSIT_ITEM
        '
        Me.TxtTRANSIT_ITEM.Location = New System.Drawing.Point(38, 418)
        Me.TxtTRANSIT_ITEM.Name = "TxtTRANSIT_ITEM"
        Me.TxtTRANSIT_ITEM.Size = New System.Drawing.Size(118, 21)
        Me.TxtTRANSIT_ITEM.TabIndex = 8
        Me.TxtTRANSIT_ITEM.Visible = False
        '
        'CmbNEXT_PORT
        '
        Me.CmbNEXT_PORT.Enabled = False
        Me.CmbNEXT_PORT.Location = New System.Drawing.Point(62, 181)
        Me.CmbNEXT_PORT.MaxDropDownItems = 15
        Me.CmbNEXT_PORT.Name = "CmbNEXT_PORT"
        Me.CmbNEXT_PORT.Size = New System.Drawing.Size(158, 20)
        Me.CmbNEXT_PORT.TabIndex = 10
        '
        'CmbLAST_PORT
        '
        Me.CmbLAST_PORT.Enabled = False
        Me.CmbLAST_PORT.Location = New System.Drawing.Point(62, 159)
        Me.CmbLAST_PORT.MaxDropDownItems = 15
        Me.CmbLAST_PORT.Name = "CmbLAST_PORT"
        Me.CmbLAST_PORT.Size = New System.Drawing.Size(158, 20)
        Me.CmbLAST_PORT.TabIndex = 9
        '
        'DTPETA_SAILING_TIME
        '
        Me.DTPETA_SAILING_TIME.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DTPETA_SAILING_TIME.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPETA_SAILING_TIME.Location = New System.Drawing.Point(237, 387)
        Me.DTPETA_SAILING_TIME.Name = "DTPETA_SAILING_TIME"
        Me.DTPETA_SAILING_TIME.Size = New System.Drawing.Size(118, 21)
        Me.DTPETA_SAILING_TIME.TabIndex = 18
        Me.DTPETA_SAILING_TIME.Visible = False
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(174, 368)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 20)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "到港时间"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Visible = False
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(178, 368)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 20)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "靠泊时间"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label12.Visible = False
        '
        'DTPARRIVER_TIME
        '
        Me.DTPARRIVER_TIME.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DTPARRIVER_TIME.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPARRIVER_TIME.Location = New System.Drawing.Point(225, 418)
        Me.DTPARRIVER_TIME.Name = "DTPARRIVER_TIME"
        Me.DTPARRIVER_TIME.Size = New System.Drawing.Size(118, 21)
        Me.DTPARRIVER_TIME.TabIndex = 19
        Me.DTPARRIVER_TIME.Visible = False
        '
        'DTPBERTH_TIME
        '
        Me.DTPBERTH_TIME.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DTPBERTH_TIME.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPBERTH_TIME.Location = New System.Drawing.Point(225, 405)
        Me.DTPBERTH_TIME.Name = "DTPBERTH_TIME"
        Me.DTPBERTH_TIME.Size = New System.Drawing.Size(118, 21)
        Me.DTPBERTH_TIME.TabIndex = 20
        Me.DTPBERTH_TIME.Visible = False
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(4, 225)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 20)
        Me.Label13.TabIndex = 80
        Me.Label13.Text = "泊位位置"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(199, 76)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 20)
        Me.Label14.TabIndex = 79
        Me.Label14.Text = "完工时间"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(199, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 20)
        Me.Label15.TabIndex = 82
        Me.Label15.Text = "货类"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(199, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 20)
        Me.Label16.TabIndex = 81
        Me.Label16.Text = "数量"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(176, 364)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 20)
        Me.Label17.TabIndex = 70
        Me.Label17.Text = "委托人简称"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label17.Visible = False
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(199, 54)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 20)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "开工时间"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(4, 203)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 20)
        Me.Label20.TabIndex = 63
        Me.Label20.Text = "泊位号"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(178, 364)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 20)
        Me.Label21.TabIndex = 62
        Me.Label21.Text = "出港时间"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label21.Visible = False
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(199, 120)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 20)
        Me.Label22.TabIndex = 69
        Me.Label22.Text = "所属理货站"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(199, 98)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 20)
        Me.Label23.TabIndex = 66
        Me.Label23.Text = "船舶代理公司"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(180, 364)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 20)
        Me.Label24.TabIndex = 67
        Me.Label24.Text = "主要收货人"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label24.Visible = False
        '
        'TxtBERTHNO
        '
        Me.TxtBERTHNO.Location = New System.Drawing.Point(62, 203)
        Me.TxtBERTHNO.MaxLength = 3
        Me.TxtBERTHNO.Name = "TxtBERTHNO"
        Me.TxtBERTHNO.Size = New System.Drawing.Size(118, 21)
        Me.TxtBERTHNO.TabIndex = 11
        '
        'TxtBERTH_POSITION
        '
        Me.TxtBERTH_POSITION.Location = New System.Drawing.Point(62, 225)
        Me.TxtBERTH_POSITION.MaxLength = 5
        Me.TxtBERTH_POSITION.Name = "TxtBERTH_POSITION"
        Me.TxtBERTH_POSITION.Size = New System.Drawing.Size(118, 21)
        Me.TxtBERTH_POSITION.TabIndex = 12
        '
        'DTPWORKTIME_BEGIN
        '
        Me.DTPWORKTIME_BEGIN.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DTPWORKTIME_BEGIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPWORKTIME_BEGIN.Location = New System.Drawing.Point(281, 52)
        Me.DTPWORKTIME_BEGIN.Name = "DTPWORKTIME_BEGIN"
        Me.DTPWORKTIME_BEGIN.Size = New System.Drawing.Size(118, 21)
        Me.DTPWORKTIME_BEGIN.TabIndex = 21
        '
        'CmbCODE_GOODS
        '
        Me.CmbCODE_GOODS.Location = New System.Drawing.Point(281, 6)
        Me.CmbCODE_GOODS.Name = "CmbCODE_GOODS"
        Me.CmbCODE_GOODS.Size = New System.Drawing.Size(118, 20)
        Me.CmbCODE_GOODS.TabIndex = 15
        '
        'TxtTONS
        '
        Me.TxtTONS.Location = New System.Drawing.Point(281, 28)
        Me.TxtTONS.Name = "TxtTONS"
        Me.TxtTONS.Size = New System.Drawing.Size(118, 21)
        Me.TxtTONS.TabIndex = 16
        '
        'DTPSAILING_TIME
        '
        Me.DTPSAILING_TIME.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DTPSAILING_TIME.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPSAILING_TIME.Location = New System.Drawing.Point(225, 391)
        Me.DTPSAILING_TIME.Name = "DTPSAILING_TIME"
        Me.DTPSAILING_TIME.Size = New System.Drawing.Size(118, 21)
        Me.DTPSAILING_TIME.TabIndex = 23
        Me.DTPSAILING_TIME.Visible = False
        '
        'DTPWORKTIME_END
        '
        Me.DTPWORKTIME_END.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DTPWORKTIME_END.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPWORKTIME_END.Location = New System.Drawing.Point(281, 74)
        Me.DTPWORKTIME_END.Name = "DTPWORKTIME_END"
        Me.DTPWORKTIME_END.Size = New System.Drawing.Size(118, 21)
        Me.DTPWORKTIME_END.TabIndex = 22
        '
        'TxtCLIENT
        '
        Me.TxtCLIENT.Location = New System.Drawing.Point(268, 360)
        Me.TxtCLIENT.MaxLength = 20
        Me.TxtCLIENT.Name = "TxtCLIENT"
        Me.TxtCLIENT.Size = New System.Drawing.Size(118, 21)
        Me.TxtCLIENT.TabIndex = 24
        Me.TxtCLIENT.Visible = False
        '
        'TxtCONSIGNEE
        '
        Me.TxtCONSIGNEE.Location = New System.Drawing.Point(38, 434)
        Me.TxtCONSIGNEE.MaxLength = 50
        Me.TxtCONSIGNEE.Name = "TxtCONSIGNEE"
        Me.TxtCONSIGNEE.Size = New System.Drawing.Size(118, 21)
        Me.TxtCONSIGNEE.TabIndex = 27
        Me.TxtCONSIGNEE.Visible = False
        '
        'CmbAGENT
        '
        Me.CmbAGENT.Location = New System.Drawing.Point(281, 98)
        Me.CmbAGENT.MaxDropDownItems = 15
        Me.CmbAGENT.Name = "CmbAGENT"
        Me.CmbAGENT.Size = New System.Drawing.Size(118, 20)
        Me.CmbAGENT.TabIndex = 25
        '
        'CmbDEPT_CODE
        '
        Me.CmbDEPT_CODE.Location = New System.Drawing.Point(281, 120)
        Me.CmbDEPT_CODE.Name = "CmbDEPT_CODE"
        Me.CmbDEPT_CODE.Size = New System.Drawing.Size(118, 20)
        Me.CmbDEPT_CODE.TabIndex = 28
        '
        'CmbVOYAGE_NATURE
        '
        Me.CmbVOYAGE_NATURE.Location = New System.Drawing.Point(237, 432)
        Me.CmbVOYAGE_NATURE.Name = "CmbVOYAGE_NATURE"
        Me.CmbVOYAGE_NATURE.Size = New System.Drawing.Size(118, 20)
        Me.CmbVOYAGE_NATURE.TabIndex = 4
        Me.CmbVOYAGE_NATURE.Visible = False
        '
        'TxtSHIP_ID
        '
        Me.TxtSHIP_ID.Location = New System.Drawing.Point(16, 360)
        Me.TxtSHIP_ID.MaxLength = 4
        Me.TxtSHIP_ID.Name = "TxtSHIP_ID"
        Me.TxtSHIP_ID.ReadOnly = True
        Me.TxtSHIP_ID.Size = New System.Drawing.Size(22, 21)
        Me.TxtSHIP_ID.TabIndex = 37
        Me.TxtSHIP_ID.TabStop = False
        Me.TxtSHIP_ID.Visible = False
        '
        'TXTV_ID
        '
        Me.TXTV_ID.Location = New System.Drawing.Point(38, 360)
        Me.TXTV_ID.MaxLength = 4
        Me.TXTV_ID.Name = "TXTV_ID"
        Me.TXTV_ID.ReadOnly = True
        Me.TXTV_ID.Size = New System.Drawing.Size(22, 21)
        Me.TXTV_ID.TabIndex = 38
        Me.TXTV_ID.TabStop = False
        Me.TXTV_ID.Visible = False
        '
        'TxtCHI_VESSEL
        '
        Me.TxtCHI_VESSEL.Location = New System.Drawing.Point(62, 6)
        Me.TxtCHI_VESSEL.MaxLength = 40
        Me.TxtCHI_VESSEL.Name = "TxtCHI_VESSEL"
        Me.TxtCHI_VESSEL.Size = New System.Drawing.Size(118, 21)
        Me.TxtCHI_VESSEL.TabIndex = 1
        Me.TxtCHI_VESSEL.TabStop = False
        '
        'TxtENG_VESSEL
        '
        Me.TxtENG_VESSEL.Location = New System.Drawing.Point(62, 28)
        Me.TxtENG_VESSEL.MaxLength = 50
        Me.TxtENG_VESSEL.Name = "TxtENG_VESSEL"
        Me.TxtENG_VESSEL.Size = New System.Drawing.Size(118, 21)
        Me.TxtENG_VESSEL.TabIndex = 2
        Me.TxtENG_VESSEL.TabStop = False
        '
        'TxtUSER_NAME
        '
        Me.TxtUSER_NAME.Location = New System.Drawing.Point(60, 360)
        Me.TxtUSER_NAME.Name = "TxtUSER_NAME"
        Me.TxtUSER_NAME.ReadOnly = True
        Me.TxtUSER_NAME.Size = New System.Drawing.Size(22, 21)
        Me.TxtUSER_NAME.TabIndex = 39
        Me.TxtUSER_NAME.TabStop = False
        Me.TxtUSER_NAME.Visible = False
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(4, 247)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(58, 20)
        Me.Label25.TabIndex = 80
        Me.Label25.Text = "船舶状态"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(3, 29)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(58, 20)
        Me.Label26.TabIndex = 75
        Me.Label26.Text = "英文船名"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(3, 7)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(58, 20)
        Me.Label27.TabIndex = 76
        Me.Label27.Text = "中文船名"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbSHIP_STATU
        '
        Me.CmbSHIP_STATU.Enabled = False
        Me.CmbSHIP_STATU.Location = New System.Drawing.Point(62, 247)
        Me.CmbSHIP_STATU.Name = "CmbSHIP_STATU"
        Me.CmbSHIP_STATU.Size = New System.Drawing.Size(118, 20)
        Me.CmbSHIP_STATU.TabIndex = 13
        '
        'TxtFILE_NO
        '
        Me.TxtFILE_NO.Location = New System.Drawing.Point(176, 431)
        Me.TxtFILE_NO.MaxLength = 10
        Me.TxtFILE_NO.Multiline = True
        Me.TxtFILE_NO.Name = "TxtFILE_NO"
        Me.TxtFILE_NO.Size = New System.Drawing.Size(118, 21)
        Me.TxtFILE_NO.TabIndex = 14
        Me.TxtFILE_NO.Visible = False
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(190, 368)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(58, 20)
        Me.Label28.TabIndex = 65
        Me.Label28.Text = "档案号"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label28.Visible = False
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(253, 142)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(18, 125)
        Me.Label29.TabIndex = 88
        Me.Label29.Text = "备注"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtREMARK
        '
        Me.TxtREMARK.Location = New System.Drawing.Point(281, 142)
        Me.TxtREMARK.MaxLength = 100
        Me.TxtREMARK.Multiline = True
        Me.TxtREMARK.Name = "TxtREMARK"
        Me.TxtREMARK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtREMARK.Size = New System.Drawing.Size(118, 125)
        Me.TxtREMARK.TabIndex = 29
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(104, 359)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(80, 20)
        Me.Label30.TabIndex = 90
        Me.Label30.Text = "船公司"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label30.Visible = False
        '
        'CmbShipOwner
        '
        Me.CmbShipOwner.Location = New System.Drawing.Point(206, 360)
        Me.CmbShipOwner.Name = "CmbShipOwner"
        Me.CmbShipOwner.Size = New System.Drawing.Size(118, 20)
        Me.CmbShipOwner.TabIndex = 26
        Me.CmbShipOwner.Visible = False
        '
        'Label19
        '
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(-7, 139)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 20)
        Me.Label19.TabIndex = 96
        Me.Label19.Text = "航线标志"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbcode_route
        '
        Me.cmbcode_route.Location = New System.Drawing.Point(62, 139)
        Me.cmbcode_route.Name = "cmbcode_route"
        Me.cmbcode_route.Size = New System.Drawing.Size(118, 20)
        Me.cmbcode_route.TabIndex = 95
        '
        'TxtVessel_Code
        '
        Me.TxtVessel_Code.Location = New System.Drawing.Point(62, 269)
        Me.TxtVessel_Code.MaxLength = 9
        Me.TxtVessel_Code.Name = "TxtVessel_Code"
        Me.TxtVessel_Code.Size = New System.Drawing.Size(118, 21)
        Me.TxtVessel_Code.TabIndex = 122
        '
        'Label31
        '
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(-2, 270)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(64, 20)
        Me.Label31.TabIndex = 121
        Me.Label31.Text = "船码"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmSShip_Query
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(452, 345)
        Me.Controls.Add(Me.TxtVessel_Code)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cmbcode_route)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.CmbShipOwner)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.TxtREMARK)
        Me.Controls.Add(Me.DTPETA_ARRIVER_TIME)
        Me.Controls.Add(Me.CmbS_TRADE)
        Me.Controls.Add(Me.TxtVOYAGE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CmbINOUTPORT)
        Me.Controls.Add(Me.CmbCODE_SHIP_TYPE)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtTRANSIT_ITEM)
        Me.Controls.Add(Me.CmbNEXT_PORT)
        Me.Controls.Add(Me.CmbLAST_PORT)
        Me.Controls.Add(Me.DTPETA_SAILING_TIME)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DTPARRIVER_TIME)
        Me.Controls.Add(Me.DTPBERTH_TIME)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.TxtBERTHNO)
        Me.Controls.Add(Me.TxtBERTH_POSITION)
        Me.Controls.Add(Me.DTPWORKTIME_BEGIN)
        Me.Controls.Add(Me.CmbCODE_GOODS)
        Me.Controls.Add(Me.TxtTONS)
        Me.Controls.Add(Me.DTPSAILING_TIME)
        Me.Controls.Add(Me.DTPWORKTIME_END)
        Me.Controls.Add(Me.TxtCLIENT)
        Me.Controls.Add(Me.TxtCONSIGNEE)
        Me.Controls.Add(Me.CmbAGENT)
        Me.Controls.Add(Me.CmbDEPT_CODE)
        Me.Controls.Add(Me.CmbVOYAGE_NATURE)
        Me.Controls.Add(Me.TxtSHIP_ID)
        Me.Controls.Add(Me.TXTV_ID)
        Me.Controls.Add(Me.TxtCHI_VESSEL)
        Me.Controls.Add(Me.TxtENG_VESSEL)
        Me.Controls.Add(Me.TxtUSER_NAME)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.CmbSHIP_STATU)
        Me.Controls.Add(Me.TxtFILE_NO)
        Me.Controls.Add(Me.Label28)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSShip_Query"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "船舶航次_查看"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub FrmSShip_Query_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim sqlstr As String

        sqlstr = "select * from SShip where SHIP_ID=" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)
        FillVOYAGE_NATURE()
        FillS_TRADE()
        FillINOUTPORT()
        FillCODE_SHIP_TYPE()
        Fill_PORT()
        FillCODE_GOODS()
        FillAGENT()
        FillShipOwner()
        FillDEPT_CODE()
        FillSHIP_STATU()
        Fillcode_route()

        If dw.Count > 0 Then
            TXTV_ID.Text = ds.Tables(0).Rows(0).Item("V_ID")
            TxtSHIP_ID.Text = ds.Tables(0).Rows(0).Item("SHIP_ID")
            TxtCHI_VESSEL.Text = ds.Tables(0).Rows(0).Item("CHI_VESSEL")
            TxtENG_VESSEL.Text = ds.Tables(0).Rows(0).Item("ENG_VESSEL")
            TxtUSER_NAME.Text = Trim(G_User)
            CmbSHIP_STATU.SelectedValue = ds.Tables(0).Rows(0).Item("SHIP_STATU")
            TxtSHIP_ID.Text = ds.Tables(0).Rows(0).Item("ID")
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
            DTPETA_SAILING_TIME.Value = ds.Tables(0).Rows(0).Item("ETA_SAILING_TIME")
            DTPARRIVER_TIME.Value = ds.Tables(0).Rows(0).Item("ARRIVER_TIME")
            DTPBERTH_TIME.Value = ds.Tables(0).Rows(0).Item("BERTH_TIME")
            TxtBERTHNO.Text = ds.Tables(0).Rows(0).Item("BERTHNO")
            TxtBERTH_POSITION.Text = ds.Tables(0).Rows(0).Item("BERTH_POSITION")
            DTPWORKTIME_BEGIN.Value = ds.Tables(0).Rows(0).Item("WORKTIME_BEGIN")
            CmbCODE_GOODS.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_GOODS")
            TxtTONS.Text = ds.Tables(0).Rows(0).Item("TONS")
            DTPWORKTIME_END.Value = ds.Tables(0).Rows(0).Item("WORKTIME_END")
            DTPSAILING_TIME.Value = ds.Tables(0).Rows(0).Item("SAILING_TIME")
            TxtCLIENT.Text = ds.Tables(0).Rows(0).Item("CLIENT")
            CmbAGENT.SelectedValue = ds.Tables(0).Rows(0).Item("AGENT")
            CmbShipOwner.SelectedValue = ds.Tables(0).Rows(0).Item("Code_ShipOwner")
            TxtCONSIGNEE.Text = ds.Tables(0).Rows(0).Item("TPC")
            CmbDEPT_CODE.SelectedValue = ds.Tables(0).Rows(0).Item("DEPT_CODE")
            TxtREMARK.Text = ds.Tables(0).Rows(0).Item("REMARK")

            Getdata("SELECT Vessel_Code FROM VESSEL where VESSEL_ID=" & TXTV_ID.Text & "", dv)
            TxtVessel_Code.Text = dv.Tables(0).Rows(0)(0)
        End If
        btnQuit.Focus()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub FillVOYAGE_NATURE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "select Voyage_Nature,Voyage_Nature_Name from Code_Voyage_Nature"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbVOYAGE_NATURE.DataSource = dvc
        Me.CmbVOYAGE_NATURE.DisplayMember = "Voyage_Nature_Name"
        Me.CmbVOYAGE_NATURE.ValueMember = "Voyage_Nature"
    End Sub

    Private Sub FillS_TRADE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "select S_Trade,Trade from Code_Trade"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbS_TRADE.DataSource = dvc
        Me.CmbS_TRADE.DisplayMember = "Trade"
        Me.CmbS_TRADE.ValueMember = "S_Trade"
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

    Private Sub FillCODE_SHIP_TYPE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
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
        Dim dsc As New DataSet()
        sqldc = "select CODE_SHIPOWNER,ShipOWNER_CHA from CODE_SHIP_OWNER"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbShipOwner.DataSource = dvc
        Me.CmbShipOwner.DisplayMember = "ShipOWNER_CHA"
        Me.CmbShipOwner.ValueMember = "CODE_SHIPOWNER"
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

    Private Sub FillSHIP_STATU()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "select Ship_Statu,Ship_Statu_Name from Code_Ship_Statu"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbSHIP_STATU.DataSource = dvc
        Me.CmbSHIP_STATU.DisplayMember = "Ship_Statu_Name"
        Me.CmbSHIP_STATU.ValueMember = "Ship_Statu"
    End Sub

    'Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        If MsgBox("你确认要删除吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
    '            Call OperateHistory(G_DeptName, Now, G_User, "编辑", "SShip", Trim(TxtSHIP_ID.Text), "SHIP_ID")
    '            ds.Tables(0).Rows(0).Delete()
    '            sqlda.Update(ds)
    '            Me.Close()
    '        End If
    '    Catch ex As System.Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub TxtBERTHNO_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtBERTHNO.TextChanged
        Dim sqldc As String
        Dim sqldv As String
        Dim dvc As DataView
        Dim dsc As New DataSet()

        sqldv = "SELECT DEPT_CODE FROM CODE_BERTH WHERE CODE_BERTH = '" & TxtBERTHNO.Text & "' "
        dvc = Getdata(sqldv, dsc)
        If dsc.Tables(0).DefaultView.Count > 0 Then
            Me.CmbDEPT_CODE.SelectedValue = dsc.Tables(0).Rows(0).Item("Dept_Code")
        End If
    End Sub

    Private Sub TxtCHI_VESSEL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCHI_VESSEL.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtENG_VESSEL.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtENG_VESSEL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtENG_VESSEL.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtVOYAGE.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtVOYAGE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtVOYAGE.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbVOYAGE_NATURE.Focus()
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

    Private Sub CmbCODE_SHIP_TYPE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbCODE_SHIP_TYPE.KeyDown
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
            TxtBERTH_POSITION.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtBERTH_POSITION_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBERTH_POSITION.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbSHIP_STATU.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbSHIP_STATU_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSHIP_STATU.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtFILE_NO.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtFILE_NO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtFILE_NO.KeyDown
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
            btnQuit.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

End Class
