Imports System.IO
Imports TALLY.DBControl
Public Class FrmSShip_Edit
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim dw As New DataView()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim ds_tmp As New DataSet
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cmbcode_route As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Custom_Edi As System.Windows.Forms.Button
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
    Friend WithEvents btnSave As System.Windows.Forms.Button
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
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TxtBERTHNO As System.Windows.Forms.TextBox
    Friend WithEvents DTPWORKTIME_BEGIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbCODE_GOODS As System.Windows.Forms.ComboBox
    Friend WithEvents TxtTONS As System.Windows.Forms.TextBox
    Friend WithEvents DTPSAILING_TIME As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPWORKTIME_END As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtCLIENT As System.Windows.Forms.TextBox
    Friend WithEvents TxtCONSIGNEE As System.Windows.Forms.TextBox
    Friend WithEvents TxtREMARK As System.Windows.Forms.TextBox
    Friend WithEvents CmbAGENT As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDEPT_CODE As System.Windows.Forms.ComboBox
    Friend WithEvents CmbVOYAGE_NATURE As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSHIP_ID As System.Windows.Forms.TextBox
    Friend WithEvents TXTV_ID As System.Windows.Forms.TextBox
    Friend WithEvents TxtCHI_VESSEL As System.Windows.Forms.TextBox
    Friend WithEvents TxtENG_VESSEL As System.Windows.Forms.TextBox
    Friend WithEvents TxtUSER_NAME As System.Windows.Forms.TextBox
    Friend WithEvents ChkARRIVER_TIME As System.Windows.Forms.CheckBox
    Friend WithEvents ChkBERTH_TIME As System.Windows.Forms.CheckBox
    Friend WithEvents ChkETA_ARRIVER_TIME As System.Windows.Forms.CheckBox
    Friend WithEvents ChkETA_SAILING_TIME As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSAILING_TIME As System.Windows.Forms.CheckBox
    Friend WithEvents ChkWORKTIME_BEGIN As System.Windows.Forms.CheckBox
    Friend WithEvents ChkWORKTIME_END As System.Windows.Forms.CheckBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents CmbSHIP_STATU As System.Windows.Forms.ComboBox
    Friend WithEvents TxtFILE_NO As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents CmbShipOwner As System.Windows.Forms.ComboBox
    Friend WithEvents TxtVessel_Code As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cmb_BERTH_POSITION As System.Windows.Forms.ComboBox
    Friend WithEvents BtnVesseledit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DTPETA_ARRIVER_TIME = New System.Windows.Forms.DateTimePicker
        Me.CmbS_TRADE = New System.Windows.Forms.ComboBox
        Me.TxtVOYAGE = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnQuit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
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
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.TxtBERTHNO = New System.Windows.Forms.TextBox
        Me.DTPWORKTIME_BEGIN = New System.Windows.Forms.DateTimePicker
        Me.CmbCODE_GOODS = New System.Windows.Forms.ComboBox
        Me.TxtTONS = New System.Windows.Forms.TextBox
        Me.DTPSAILING_TIME = New System.Windows.Forms.DateTimePicker
        Me.DTPWORKTIME_END = New System.Windows.Forms.DateTimePicker
        Me.TxtCLIENT = New System.Windows.Forms.TextBox
        Me.TxtCONSIGNEE = New System.Windows.Forms.TextBox
        Me.TxtREMARK = New System.Windows.Forms.TextBox
        Me.CmbAGENT = New System.Windows.Forms.ComboBox
        Me.CmbDEPT_CODE = New System.Windows.Forms.ComboBox
        Me.CmbVOYAGE_NATURE = New System.Windows.Forms.ComboBox
        Me.TxtSHIP_ID = New System.Windows.Forms.TextBox
        Me.TXTV_ID = New System.Windows.Forms.TextBox
        Me.TxtCHI_VESSEL = New System.Windows.Forms.TextBox
        Me.TxtENG_VESSEL = New System.Windows.Forms.TextBox
        Me.TxtUSER_NAME = New System.Windows.Forms.TextBox
        Me.ChkARRIVER_TIME = New System.Windows.Forms.CheckBox
        Me.ChkBERTH_TIME = New System.Windows.Forms.CheckBox
        Me.ChkETA_ARRIVER_TIME = New System.Windows.Forms.CheckBox
        Me.ChkETA_SAILING_TIME = New System.Windows.Forms.CheckBox
        Me.ChkSAILING_TIME = New System.Windows.Forms.CheckBox
        Me.ChkWORKTIME_BEGIN = New System.Windows.Forms.CheckBox
        Me.ChkWORKTIME_END = New System.Windows.Forms.CheckBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.CmbSHIP_STATU = New System.Windows.Forms.ComboBox
        Me.TxtFILE_NO = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Custom_Edi = New System.Windows.Forms.Button
        Me.Label29 = New System.Windows.Forms.Label
        Me.BtnVesseledit = New System.Windows.Forms.Button
        Me.TxtVessel_Code = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.cmbcode_route = New System.Windows.Forms.ComboBox
        Me.cmb_BERTH_POSITION = New System.Windows.Forms.ComboBox
        Me.CmbShipOwner = New System.Windows.Forms.ComboBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DTPETA_ARRIVER_TIME
        '
        Me.DTPETA_ARRIVER_TIME.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DTPETA_ARRIVER_TIME.Enabled = False
        Me.DTPETA_ARRIVER_TIME.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPETA_ARRIVER_TIME.Location = New System.Drawing.Point(106, 74)
        Me.DTPETA_ARRIVER_TIME.Name = "DTPETA_ARRIVER_TIME"
        Me.DTPETA_ARRIVER_TIME.Size = New System.Drawing.Size(122, 21)
        Me.DTPETA_ARRIVER_TIME.TabIndex = 14
        Me.DTPETA_ARRIVER_TIME.Visible = False
        '
        'CmbS_TRADE
        '
        Me.CmbS_TRADE.Location = New System.Drawing.Point(70, 84)
        Me.CmbS_TRADE.Name = "CmbS_TRADE"
        Me.CmbS_TRADE.Size = New System.Drawing.Size(118, 20)
        Me.CmbS_TRADE.TabIndex = 1
        '
        'TxtVOYAGE
        '
        Me.TxtVOYAGE.Location = New System.Drawing.Point(70, 62)
        Me.TxtVOYAGE.MaxLength = 17
        Me.TxtVOYAGE.Name = "TxtVOYAGE"
        Me.TxtVOYAGE.Size = New System.Drawing.Size(118, 21)
        Me.TxtVOYAGE.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(6, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "航次"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(219, 327)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(85, 28)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "取消"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(118, 327)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 28)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "确认"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(39, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "航次性质"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(6, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "进出口"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(6, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "贸易类别"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(6, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "国轮外轮"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbINOUTPORT
        '
        Me.CmbINOUTPORT.Location = New System.Drawing.Point(70, 105)
        Me.CmbINOUTPORT.Name = "CmbINOUTPORT"
        Me.CmbINOUTPORT.Size = New System.Drawing.Size(118, 20)
        Me.CmbINOUTPORT.TabIndex = 2
        '
        'CmbCODE_SHIP_TYPE
        '
        Me.CmbCODE_SHIP_TYPE.Location = New System.Drawing.Point(70, 126)
        Me.CmbCODE_SHIP_TYPE.Name = "CmbCODE_SHIP_TYPE"
        Me.CmbCODE_SHIP_TYPE.Size = New System.Drawing.Size(118, 20)
        Me.CmbCODE_SHIP_TYPE.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 20)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "装货港口"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(18, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 20)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "预计进港时间"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(18, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 20)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "预计出港时间"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 20)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "卸货港口"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(39, 207)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 20)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "运输条款"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Visible = False
        '
        'TxtTRANSIT_ITEM
        '
        Me.TxtTRANSIT_ITEM.Location = New System.Drawing.Point(106, 243)
        Me.TxtTRANSIT_ITEM.Name = "TxtTRANSIT_ITEM"
        Me.TxtTRANSIT_ITEM.Size = New System.Drawing.Size(118, 21)
        Me.TxtTRANSIT_ITEM.TabIndex = 4
        Me.TxtTRANSIT_ITEM.Visible = False
        '
        'CmbNEXT_PORT
        '
        Me.CmbNEXT_PORT.Location = New System.Drawing.Point(70, 189)
        Me.CmbNEXT_PORT.MaxDropDownItems = 15
        Me.CmbNEXT_PORT.Name = "CmbNEXT_PORT"
        Me.CmbNEXT_PORT.Size = New System.Drawing.Size(166, 20)
        Me.CmbNEXT_PORT.TabIndex = 5
        '
        'CmbLAST_PORT
        '
        Me.CmbLAST_PORT.Location = New System.Drawing.Point(70, 168)
        Me.CmbLAST_PORT.MaxDropDownItems = 15
        Me.CmbLAST_PORT.Name = "CmbLAST_PORT"
        Me.CmbLAST_PORT.Size = New System.Drawing.Size(166, 20)
        Me.CmbLAST_PORT.TabIndex = 4
        '
        'DTPETA_SAILING_TIME
        '
        Me.DTPETA_SAILING_TIME.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DTPETA_SAILING_TIME.Enabled = False
        Me.DTPETA_SAILING_TIME.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPETA_SAILING_TIME.Location = New System.Drawing.Point(106, 14)
        Me.DTPETA_SAILING_TIME.Name = "DTPETA_SAILING_TIME"
        Me.DTPETA_SAILING_TIME.Size = New System.Drawing.Size(122, 21)
        Me.DTPETA_SAILING_TIME.TabIndex = 16
        Me.DTPETA_SAILING_TIME.Visible = False
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(18, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 20)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "到港时间"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Visible = False
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(18, 121)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 20)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "靠泊时间"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label12.Visible = False
        '
        'DTPARRIVER_TIME
        '
        Me.DTPARRIVER_TIME.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DTPARRIVER_TIME.Enabled = False
        Me.DTPARRIVER_TIME.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPARRIVER_TIME.Location = New System.Drawing.Point(106, 36)
        Me.DTPARRIVER_TIME.Name = "DTPARRIVER_TIME"
        Me.DTPARRIVER_TIME.Size = New System.Drawing.Size(122, 21)
        Me.DTPARRIVER_TIME.TabIndex = 18
        Me.DTPARRIVER_TIME.Visible = False
        '
        'DTPBERTH_TIME
        '
        Me.DTPBERTH_TIME.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DTPBERTH_TIME.Enabled = False
        Me.DTPBERTH_TIME.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPBERTH_TIME.Location = New System.Drawing.Point(106, 121)
        Me.DTPBERTH_TIME.Name = "DTPBERTH_TIME"
        Me.DTPBERTH_TIME.Size = New System.Drawing.Size(122, 21)
        Me.DTPBERTH_TIME.TabIndex = 20
        Me.DTPBERTH_TIME.Visible = False
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(6, 233)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 20)
        Me.Label13.TabIndex = 80
        Me.Label13.Text = "泊位位置"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(190, 84)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 20)
        Me.Label14.TabIndex = 79
        Me.Label14.Text = "完工时间"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(189, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 20)
        Me.Label15.TabIndex = 82
        Me.Label15.Text = "船舶类别"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(189, 40)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 20)
        Me.Label16.TabIndex = 81
        Me.Label16.Text = "吨数"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(18, 97)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 20)
        Me.Label17.TabIndex = 70
        Me.Label17.Text = "委托人简称"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label17.Visible = False
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(190, 62)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 20)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "开工时间"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(251, 152)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(18, 122)
        Me.Label19.TabIndex = 65
        Me.Label19.Text = "备注"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(6, 211)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 20)
        Me.Label20.TabIndex = 63
        Me.Label20.Text = "泊位号"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(18, 56)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(85, 20)
        Me.Label21.TabIndex = 62
        Me.Label21.Text = "出港时间"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label21.Visible = False
        '
        'Label22
        '
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(192, 126)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(82, 20)
        Me.Label22.TabIndex = 69
        Me.Label22.Text = "所属理货站"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(190, 106)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(84, 20)
        Me.Label23.TabIndex = 66
        Me.Label23.Text = "船舶代理公司"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(33, 178)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(70, 20)
        Me.Label24.TabIndex = 67
        Me.Label24.Text = "主要收货人"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label24.Visible = False
        '
        'TxtBERTHNO
        '
        Me.TxtBERTHNO.Location = New System.Drawing.Point(70, 210)
        Me.TxtBERTHNO.MaxLength = 3
        Me.TxtBERTHNO.Name = "TxtBERTHNO"
        Me.TxtBERTHNO.Size = New System.Drawing.Size(118, 21)
        Me.TxtBERTHNO.TabIndex = 6
        '
        'DTPWORKTIME_BEGIN
        '
        Me.DTPWORKTIME_BEGIN.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DTPWORKTIME_BEGIN.Enabled = False
        Me.DTPWORKTIME_BEGIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPWORKTIME_BEGIN.Location = New System.Drawing.Point(274, 62)
        Me.DTPWORKTIME_BEGIN.Name = "DTPWORKTIME_BEGIN"
        Me.DTPWORKTIME_BEGIN.Size = New System.Drawing.Size(122, 21)
        Me.DTPWORKTIME_BEGIN.TabIndex = 22
        '
        'CmbCODE_GOODS
        '
        Me.CmbCODE_GOODS.Location = New System.Drawing.Point(274, 16)
        Me.CmbCODE_GOODS.Name = "CmbCODE_GOODS"
        Me.CmbCODE_GOODS.Size = New System.Drawing.Size(138, 20)
        Me.CmbCODE_GOODS.TabIndex = 9
        '
        'TxtTONS
        '
        Me.TxtTONS.Location = New System.Drawing.Point(274, 38)
        Me.TxtTONS.Name = "TxtTONS"
        Me.TxtTONS.Size = New System.Drawing.Size(138, 21)
        Me.TxtTONS.TabIndex = 10
        '
        'DTPSAILING_TIME
        '
        Me.DTPSAILING_TIME.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DTPSAILING_TIME.Enabled = False
        Me.DTPSAILING_TIME.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPSAILING_TIME.Location = New System.Drawing.Point(106, 56)
        Me.DTPSAILING_TIME.Name = "DTPSAILING_TIME"
        Me.DTPSAILING_TIME.Size = New System.Drawing.Size(122, 21)
        Me.DTPSAILING_TIME.TabIndex = 26
        Me.DTPSAILING_TIME.Visible = False
        '
        'DTPWORKTIME_END
        '
        Me.DTPWORKTIME_END.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DTPWORKTIME_END.Enabled = False
        Me.DTPWORKTIME_END.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPWORKTIME_END.Location = New System.Drawing.Point(274, 84)
        Me.DTPWORKTIME_END.Name = "DTPWORKTIME_END"
        Me.DTPWORKTIME_END.Size = New System.Drawing.Size(122, 21)
        Me.DTPWORKTIME_END.TabIndex = 24
        '
        'TxtCLIENT
        '
        Me.TxtCLIENT.Location = New System.Drawing.Point(106, 97)
        Me.TxtCLIENT.MaxLength = 20
        Me.TxtCLIENT.Name = "TxtCLIENT"
        Me.TxtCLIENT.Size = New System.Drawing.Size(122, 21)
        Me.TxtCLIENT.TabIndex = 27
        Me.TxtCLIENT.Visible = False
        '
        'TxtCONSIGNEE
        '
        Me.TxtCONSIGNEE.Location = New System.Drawing.Point(106, 178)
        Me.TxtCONSIGNEE.MaxLength = 50
        Me.TxtCONSIGNEE.Name = "TxtCONSIGNEE"
        Me.TxtCONSIGNEE.Size = New System.Drawing.Size(46, 21)
        Me.TxtCONSIGNEE.TabIndex = 29
        Me.TxtCONSIGNEE.Visible = False
        '
        'TxtREMARK
        '
        Me.TxtREMARK.Location = New System.Drawing.Point(274, 152)
        Me.TxtREMARK.MaxLength = 100
        Me.TxtREMARK.Multiline = True
        Me.TxtREMARK.Name = "TxtREMARK"
        Me.TxtREMARK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtREMARK.Size = New System.Drawing.Size(138, 122)
        Me.TxtREMARK.TabIndex = 31
        '
        'CmbAGENT
        '
        Me.CmbAGENT.Location = New System.Drawing.Point(274, 106)
        Me.CmbAGENT.MaxDropDownItems = 15
        Me.CmbAGENT.Name = "CmbAGENT"
        Me.CmbAGENT.Size = New System.Drawing.Size(138, 20)
        Me.CmbAGENT.TabIndex = 11
        '
        'CmbDEPT_CODE
        '
        Me.CmbDEPT_CODE.Location = New System.Drawing.Point(274, 126)
        Me.CmbDEPT_CODE.Name = "CmbDEPT_CODE"
        Me.CmbDEPT_CODE.Size = New System.Drawing.Size(138, 20)
        Me.CmbDEPT_CODE.TabIndex = 12
        '
        'CmbVOYAGE_NATURE
        '
        Me.CmbVOYAGE_NATURE.Location = New System.Drawing.Point(106, 207)
        Me.CmbVOYAGE_NATURE.Name = "CmbVOYAGE_NATURE"
        Me.CmbVOYAGE_NATURE.Size = New System.Drawing.Size(118, 20)
        Me.CmbVOYAGE_NATURE.TabIndex = 0
        Me.CmbVOYAGE_NATURE.Visible = False
        '
        'TxtSHIP_ID
        '
        Me.TxtSHIP_ID.Location = New System.Drawing.Point(10, 315)
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
        Me.TXTV_ID.Location = New System.Drawing.Point(32, 315)
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
        Me.TxtCHI_VESSEL.Location = New System.Drawing.Point(70, 18)
        Me.TxtCHI_VESSEL.MaxLength = 40
        Me.TxtCHI_VESSEL.Name = "TxtCHI_VESSEL"
        Me.TxtCHI_VESSEL.ReadOnly = True
        Me.TxtCHI_VESSEL.Size = New System.Drawing.Size(118, 21)
        Me.TxtCHI_VESSEL.TabIndex = 34
        Me.TxtCHI_VESSEL.TabStop = False
        '
        'TxtENG_VESSEL
        '
        Me.TxtENG_VESSEL.Location = New System.Drawing.Point(70, 40)
        Me.TxtENG_VESSEL.MaxLength = 50
        Me.TxtENG_VESSEL.Name = "TxtENG_VESSEL"
        Me.TxtENG_VESSEL.Size = New System.Drawing.Size(118, 21)
        Me.TxtENG_VESSEL.TabIndex = 35
        Me.TxtENG_VESSEL.TabStop = False
        '
        'TxtUSER_NAME
        '
        Me.TxtUSER_NAME.Location = New System.Drawing.Point(54, 315)
        Me.TxtUSER_NAME.Name = "TxtUSER_NAME"
        Me.TxtUSER_NAME.ReadOnly = True
        Me.TxtUSER_NAME.Size = New System.Drawing.Size(22, 21)
        Me.TxtUSER_NAME.TabIndex = 39
        Me.TxtUSER_NAME.TabStop = False
        Me.TxtUSER_NAME.Visible = False
        '
        'ChkARRIVER_TIME
        '
        Me.ChkARRIVER_TIME.Location = New System.Drawing.Point(13, 224)
        Me.ChkARRIVER_TIME.Name = "ChkARRIVER_TIME"
        Me.ChkARRIVER_TIME.Size = New System.Drawing.Size(14, 20)
        Me.ChkARRIVER_TIME.TabIndex = 17
        Me.ChkARRIVER_TIME.Visible = False
        '
        'ChkBERTH_TIME
        '
        Me.ChkBERTH_TIME.Location = New System.Drawing.Point(13, 243)
        Me.ChkBERTH_TIME.Name = "ChkBERTH_TIME"
        Me.ChkBERTH_TIME.Size = New System.Drawing.Size(14, 20)
        Me.ChkBERTH_TIME.TabIndex = 19
        Me.ChkBERTH_TIME.Visible = False
        '
        'ChkETA_ARRIVER_TIME
        '
        Me.ChkETA_ARRIVER_TIME.Location = New System.Drawing.Point(13, 154)
        Me.ChkETA_ARRIVER_TIME.Name = "ChkETA_ARRIVER_TIME"
        Me.ChkETA_ARRIVER_TIME.Size = New System.Drawing.Size(14, 20)
        Me.ChkETA_ARRIVER_TIME.TabIndex = 13
        Me.ChkETA_ARRIVER_TIME.Visible = False
        '
        'ChkETA_SAILING_TIME
        '
        Me.ChkETA_SAILING_TIME.Location = New System.Drawing.Point(13, 180)
        Me.ChkETA_SAILING_TIME.Name = "ChkETA_SAILING_TIME"
        Me.ChkETA_SAILING_TIME.Size = New System.Drawing.Size(14, 20)
        Me.ChkETA_SAILING_TIME.TabIndex = 15
        Me.ChkETA_SAILING_TIME.Visible = False
        '
        'ChkSAILING_TIME
        '
        Me.ChkSAILING_TIME.Location = New System.Drawing.Point(13, 206)
        Me.ChkSAILING_TIME.Name = "ChkSAILING_TIME"
        Me.ChkSAILING_TIME.Size = New System.Drawing.Size(14, 20)
        Me.ChkSAILING_TIME.TabIndex = 25
        Me.ChkSAILING_TIME.Visible = False
        '
        'ChkWORKTIME_BEGIN
        '
        Me.ChkWORKTIME_BEGIN.Location = New System.Drawing.Point(398, 62)
        Me.ChkWORKTIME_BEGIN.Name = "ChkWORKTIME_BEGIN"
        Me.ChkWORKTIME_BEGIN.Size = New System.Drawing.Size(14, 20)
        Me.ChkWORKTIME_BEGIN.TabIndex = 21
        '
        'ChkWORKTIME_END
        '
        Me.ChkWORKTIME_END.Location = New System.Drawing.Point(398, 82)
        Me.ChkWORKTIME_END.Name = "ChkWORKTIME_END"
        Me.ChkWORKTIME_END.Size = New System.Drawing.Size(14, 20)
        Me.ChkWORKTIME_END.TabIndex = 23
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(6, 253)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(64, 20)
        Me.Label25.TabIndex = 80
        Me.Label25.Text = "船舶状态"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(6, 40)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(64, 20)
        Me.Label26.TabIndex = 75
        Me.Label26.Text = "英文船名"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(6, 18)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 20)
        Me.Label27.TabIndex = 76
        Me.Label27.Text = "中文船名"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbSHIP_STATU
        '
        Me.CmbSHIP_STATU.Location = New System.Drawing.Point(70, 253)
        Me.CmbSHIP_STATU.Name = "CmbSHIP_STATU"
        Me.CmbSHIP_STATU.Size = New System.Drawing.Size(118, 20)
        Me.CmbSHIP_STATU.TabIndex = 8
        '
        'TxtFILE_NO
        '
        Me.TxtFILE_NO.Location = New System.Drawing.Point(106, 270)
        Me.TxtFILE_NO.MaxLength = 10
        Me.TxtFILE_NO.Multiline = True
        Me.TxtFILE_NO.Name = "TxtFILE_NO"
        Me.TxtFILE_NO.Size = New System.Drawing.Size(118, 21)
        Me.TxtFILE_NO.TabIndex = 10
        Me.TxtFILE_NO.Visible = False
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(39, 269)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(64, 20)
        Me.Label28.TabIndex = 65
        Me.Label28.Text = "档案号"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label28.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Custom_Edi)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.TxtSHIP_ID)
        Me.GroupBox1.Controls.Add(Me.BtnVesseledit)
        Me.GroupBox1.Controls.Add(Me.TxtVessel_Code)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.TXTV_ID)
        Me.GroupBox1.Controls.Add(Me.btnQuit)
        Me.GroupBox1.Controls.Add(Me.TxtUSER_NAME)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.cmbcode_route)
        Me.GroupBox1.Controls.Add(Me.cmb_BERTH_POSITION)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.TxtREMARK)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.CmbINOUTPORT)
        Me.GroupBox1.Controls.Add(Me.CmbCODE_SHIP_TYPE)
        Me.GroupBox1.Controls.Add(Me.CmbShipOwner)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.CmbS_TRADE)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CmbSHIP_STATU)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtBERTHNO)
        Me.GroupBox1.Controls.Add(Me.CmbNEXT_PORT)
        Me.GroupBox1.Controls.Add(Me.CmbLAST_PORT)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.DTPWORKTIME_BEGIN)
        Me.GroupBox1.Controls.Add(Me.DTPWORKTIME_END)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.ChkWORKTIME_BEGIN)
        Me.GroupBox1.Controls.Add(Me.ChkWORKTIME_END)
        Me.GroupBox1.Controls.Add(Me.CmbAGENT)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.CmbDEPT_CODE)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.TxtCHI_VESSEL)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.TxtENG_VESSEL)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.TxtVOYAGE)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CmbCODE_GOODS)
        Me.GroupBox1.Controls.Add(Me.TxtTONS)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 366)
        Me.GroupBox1.TabIndex = 87
        Me.GroupBox1.TabStop = False
        '
        'Custom_Edi
        '
        Me.Custom_Edi.Location = New System.Drawing.Point(326, 336)
        Me.Custom_Edi.Name = "Custom_Edi"
        Me.Custom_Edi.Size = New System.Drawing.Size(90, 24)
        Me.Custom_Edi.TabIndex = 123
        Me.Custom_Edi.Text = "海关报文"
        '
        'Label29
        '
        Me.Label29.ForeColor = System.Drawing.Color.Red
        Me.Label29.Location = New System.Drawing.Point(1, 148)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(69, 20)
        Me.Label29.TabIndex = 122
        Me.Label29.Text = "航线标志"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnVesseledit
        '
        Me.BtnVesseledit.Location = New System.Drawing.Point(326, 309)
        Me.BtnVesseledit.Name = "BtnVesseledit"
        Me.BtnVesseledit.Size = New System.Drawing.Size(90, 24)
        Me.BtnVesseledit.TabIndex = 1
        Me.BtnVesseledit.Text = "修改船舶规范"
        '
        'TxtVessel_Code
        '
        Me.TxtVessel_Code.Location = New System.Drawing.Point(70, 275)
        Me.TxtVessel_Code.MaxLength = 9
        Me.TxtVessel_Code.Name = "TxtVessel_Code"
        Me.TxtVessel_Code.Size = New System.Drawing.Size(118, 21)
        Me.TxtVessel_Code.TabIndex = 120
        Me.TxtVessel_Code.Visible = False
        '
        'Label31
        '
        Me.Label31.ForeColor = System.Drawing.Color.Red
        Me.Label31.Location = New System.Drawing.Point(6, 276)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(64, 20)
        Me.Label31.TabIndex = 119
        Me.Label31.Text = "船码"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label31.Visible = False
        '
        'cmbcode_route
        '
        Me.cmbcode_route.Location = New System.Drawing.Point(70, 147)
        Me.cmbcode_route.Name = "cmbcode_route"
        Me.cmbcode_route.Size = New System.Drawing.Size(118, 20)
        Me.cmbcode_route.TabIndex = 121
        '
        'cmb_BERTH_POSITION
        '
        Me.cmb_BERTH_POSITION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_BERTH_POSITION.Items.AddRange(New Object() {"", "东", "南", "西", "北"})
        Me.cmb_BERTH_POSITION.Location = New System.Drawing.Point(70, 232)
        Me.cmb_BERTH_POSITION.Name = "cmb_BERTH_POSITION"
        Me.cmb_BERTH_POSITION.Size = New System.Drawing.Size(118, 20)
        Me.cmb_BERTH_POSITION.TabIndex = 7
        '
        'CmbShipOwner
        '
        Me.CmbShipOwner.Location = New System.Drawing.Point(274, 275)
        Me.CmbShipOwner.MaxDropDownItems = 15
        Me.CmbShipOwner.Name = "CmbShipOwner"
        Me.CmbShipOwner.Size = New System.Drawing.Size(138, 20)
        Me.CmbShipOwner.TabIndex = 28
        Me.CmbShipOwner.Visible = False
        '
        'Label30
        '
        Me.Label30.ForeColor = System.Drawing.Color.Red
        Me.Label30.Location = New System.Drawing.Point(190, 276)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(84, 20)
        Me.Label30.TabIndex = 66
        Me.Label30.Text = "船公司承运人"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label30.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DTPETA_ARRIVER_TIME)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.DTPARRIVER_TIME)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.DTPETA_SAILING_TIME)
        Me.Panel1.Controls.Add(Me.CmbVOYAGE_NATURE)
        Me.Panel1.Controls.Add(Me.TxtTRANSIT_ITEM)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.DTPSAILING_TIME)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.TxtCONSIGNEE)
        Me.Panel1.Controls.Add(Me.TxtFILE_NO)
        Me.Panel1.Controls.Add(Me.TxtCLIENT)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.ChkSAILING_TIME)
        Me.Panel1.Controls.Add(Me.ChkETA_ARRIVER_TIME)
        Me.Panel1.Controls.Add(Me.ChkETA_SAILING_TIME)
        Me.Panel1.Controls.Add(Me.ChkARRIVER_TIME)
        Me.Panel1.Controls.Add(Me.ChkBERTH_TIME)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.DTPBERTH_TIME)
        Me.Panel1.Location = New System.Drawing.Point(816, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(149, 158)
        Me.Panel1.TabIndex = 88
        '
        'FrmSShip_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(429, 373)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSShip_Edit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "船舶航次_编辑"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmSShip_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

            CmbCODE_SHIP_TYPE.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_SHIP_TYPE")
            cmbcode_route.SelectedValue = ds.Tables(0).Rows(0).Item("coderoute")
            TxtTRANSIT_ITEM.Text = ds.Tables(0).Rows(0).Item("TRANSIT_ITEM")
            CmbLAST_PORT.SelectedValue = ds.Tables(0).Rows(0).Item("LAST_PORT")
            CmbNEXT_PORT.SelectedValue = ds.Tables(0).Rows(0).Item("NEXT_PORT")

            If IsDBNull(ds.Tables(0).Rows(0).Item("ETA_ARRIVER_TIME")) = False Then
                DTPETA_ARRIVER_TIME.Enabled = True
                ChkETA_ARRIVER_TIME.Checked = True
                DTPETA_ARRIVER_TIME.Value = ds.Tables(0).Rows(0).Item("ETA_ARRIVER_TIME")
            End If
            If IsDBNull(ds.Tables(0).Rows(0).Item("ETA_SAILING_TIME")) = False Then
                DTPETA_SAILING_TIME.Enabled = True
                ChkETA_SAILING_TIME.Checked = True
                DTPETA_SAILING_TIME.Value = ds.Tables(0).Rows(0).Item("ETA_SAILING_TIME")
            End If
            If IsDBNull(ds.Tables(0).Rows(0).Item("ARRIVER_TIME")) = False Then
                DTPARRIVER_TIME.Enabled = True
                ChkARRIVER_TIME.Checked = True
                DTPARRIVER_TIME.Value = ds.Tables(0).Rows(0).Item("ARRIVER_TIME")
            End If
            If IsDBNull(ds.Tables(0).Rows(0).Item("BERTH_TIME")) = False Then
                DTPBERTH_TIME.Enabled = True
                ChkBERTH_TIME.Checked = True
                DTPBERTH_TIME.Value = ds.Tables(0).Rows(0).Item("BERTH_TIME")
            End If
            If IsDBNull(ds.Tables(0).Rows(0).Item("WORKTIME_BEGIN")) = False Then
                DTPWORKTIME_BEGIN.Enabled = True
                ChkWORKTIME_BEGIN.Checked = True
                DTPWORKTIME_BEGIN.Value = ds.Tables(0).Rows(0).Item("WORKTIME_BEGIN")
            End If
            If IsDBNull(ds.Tables(0).Rows(0).Item("WORKTIME_END")) = False Then
                DTPWORKTIME_END.Enabled = True
                ChkWORKTIME_END.Checked = True
                DTPWORKTIME_END.Value = ds.Tables(0).Rows(0).Item("WORKTIME_END")
            End If
            If IsDBNull(ds.Tables(0).Rows(0).Item("SAILING_TIME")) = False Then
                DTPSAILING_TIME.Enabled = True
                ChkSAILING_TIME.Checked = True
                DTPSAILING_TIME.Value = ds.Tables(0).Rows(0).Item("SAILING_TIME")
            End If
            TxtBERTHNO.Text = ds.Tables(0).Rows(0).Item("BERTHNO")
            cmb_BERTH_POSITION.Text = ds.Tables(0).Rows(0).Item("BERTH_POSITION")
            CmbCODE_GOODS.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_GOODS")
            TxtTONS.Text = ds.Tables(0).Rows(0).Item("TONS")
            TxtCLIENT.Text = ds.Tables(0).Rows(0).Item("CLIENT")
            CmbAGENT.SelectedValue = ds.Tables(0).Rows(0).Item("AGENT")
            CmbShipOwner.SelectedValue = ds.Tables(0).Rows(0).Item("Code_ShipOwner")
            TxtCONSIGNEE.Text = ds.Tables(0).Rows(0).Item("CONSIGNEE")
            CmbDEPT_CODE.SelectedValue = ds.Tables(0).Rows(0).Item("DEPT_CODE")
            TxtREMARK.Text = ds.Tables(0).Rows(0).Item("REMARK")
            CmbINOUTPORT.SelectedValue = ds.Tables(0).Rows(0).Item("INOUTPORT")
            Getdata("SELECT * FROM VESSEL where VESSEL_ID=" & TXTV_ID.Text & "", dv)
            TxtVessel_Code.Text = dv.Tables(0).Rows(0)("Vessel_Code")

            checkCmbCODE_GOODS()
        End If
        CmbVOYAGE_NATURE.Focus()
        Exit Sub
Err:
        Resume Next
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

    Private Sub CombLOAD_PORT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbLAST_PORT.Leave
        Dim DSSELECT As New DataSet()
        Try
            If Len(Trim(CmbLAST_PORT.Text)) > 0 Then
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
        Dim DSSELECT As New DataSet()
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
        sqldc = "select DEPT_CODE,DEPT_NAME from DEPARTMENT where dept_code like '26.11.1%' "
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbDEPT_CODE.DataSource = dvc
        Me.CmbDEPT_CODE.DisplayMember = "DEPT_NAME"
        Me.CmbDEPT_CODE.ValueMember = "DEPT_CODE"
    End Sub

    Private Sub FillSHIP_STATU()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        If G_Part_Id = "1" Then
            sqldc = "select Ship_Statu,Ship_Statu_Name from Code_Ship_Statu "
        Else
            sqldc = "select Ship_Statu,Ship_Statu_Name from Code_Ship_Statu where Ship_Statu<3 "
        End If
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbSHIP_STATU.DataSource = dvc
        Me.CmbSHIP_STATU.DisplayMember = "Ship_Statu_Name"
        Me.CmbSHIP_STATU.ValueMember = "Ship_Statu"
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
            If CmbSHIP_STATU.Text = "作业完" Then
                If ChkWORKTIME_END.Checked = False Then
                    MsgBox("请输入完船时间！", MsgBoxStyle.OkOnly + vbExclamation, "提示")
                    Exit Sub
                End If
            End If
            If CmbSHIP_STATU.Text = "业务完" Then
                If Len(Trim(TxtFILE_NO.Text)) = 0 Then
                    MsgBox("请输入档案号！", MsgBoxStyle.OkOnly + vbExclamation, "提示")
                    Exit Sub
                End If
                If ChkWORKTIME_END.Checked = False Then
                    MsgBox("请输入完船时间！", MsgBoxStyle.OkOnly + vbExclamation, "提示")
                    Exit Sub
                End If
            End If
            If Len(Trim(CmbAGENT.Text)) = 0 Then
                MsgBox("请输入船代信息！", MsgBoxStyle.OkOnly + vbExclamation, "提示")
                Exit Sub
            End If
            If Len(Trim(CmbS_TRADE.Text)) > 0 Then
                If Len(Trim(CmbINOUTPORT.Text)) > 0 Then
                    If Len(Trim(CmbCODE_SHIP_TYPE.Text)) > 0 Then
                        If Len(Trim(CmbCODE_GOODS.Text)) > 0 Then
                            If Len(Trim(CmbDEPT_CODE.Text)) > 0 And Len(Trim(TxtBERTHNO.Text)) = 0 And CmbSHIP_STATU.SelectedValue <> 1 Then
                                MsgBox("此时泊位号不能为空！")
                            Else
                                If MsgBox("你确认要修改数据吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
                                    Call OperateHistory(G_DeptName, Now, G_User, "编辑", "SShip", Trim(TxtSHIP_ID.Text), "SHIP_ID")
                                    ds.Tables(0).Rows(0).Item("ENG_VESSEL") = TxtENG_VESSEL.Text
                                    ds.Tables(0).Rows(0).Item("VOYAGE") = TxtVOYAGE.Text
                                    ds.Tables(0).Rows(0).Item("VOYAGE_NATURE") = CmbVOYAGE_NATURE.SelectedValue
                                    ds.Tables(0).Rows(0).Item("S_TRADE") = CmbS_TRADE.SelectedValue
                                    ds.Tables(0).Rows(0).Item("INOUTPORT") = CmbINOUTPORT.SelectedValue
                                    ds.Tables(0).Rows(0).Item("CODE_SHIP_TYPE") = CmbCODE_SHIP_TYPE.SelectedValue
                                    ds.Tables(0).Rows(0).Item("coderoute") = cmbcode_route.SelectedValue
                                    If Len(Trim(TxtTRANSIT_ITEM.Text)) > 0 Then
                                        ds.Tables(0).Rows(0).Item("TRANSIT_ITEM") = TxtTRANSIT_ITEM.Text
                                    End If
                                    ds.Tables(0).Rows(0).Item("LAST_PORT") = CmbLAST_PORT.SelectedValue
                                    ds.Tables(0).Rows(0).Item("NEXT_PORT") = CmbNEXT_PORT.SelectedValue

                                    If Len(Trim(TxtBERTHNO.Text)) > 0 Then
                                        TxtBERTHNO.Text = Trim(TxtBERTHNO.Text) / 1
                                        If Len(Trim(CmbDEPT_CODE.Text)) = 0 Then
                                            Call TxtBERTHNO_TextChanged(sender, e)
                                        End If
                                        If IsNumeric(Trim(TxtBERTHNO.Text)) Then
                                            ds.Tables(0).Rows(0).Item("BERTHNO") = Trim(TxtBERTHNO.Text)
                                        Else
                                            MsgBox("泊位号一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                                            Exit Sub
                                        End If
                                    Else
                                        ds.Tables(0).Rows(0).Item("BERTHNO") = 0
                                    End If
                                    If Len(Trim(cmb_BERTH_POSITION.Text)) > 0 Then
                                        ds.Tables(0).Rows(0).Item("BERTH_POSITION") = cmb_BERTH_POSITION.Text
                                    End If
                                    ds.Tables(0).Rows(0).Item("SHIP_STATU") = CmbSHIP_STATU.SelectedValue
                                    ds.Tables(0).Rows(0).Item("NEXT_PORT") = CmbNEXT_PORT.SelectedValue

                                    'If Len(Trim(TxtFILE_NO.Text)) > 0 Then
                                    '    ds.Tables(0).Rows(0).Item("FILE_NO") = TxtFILE_NO.Text
                                    'End If
                                    ds.Tables(0).Rows(0).Item("CODE_GOODS") = CmbCODE_GOODS.SelectedValue

                                    If Len(Trim(TxtTONS.Text)) > 0 Then
                                        If IsNumeric(Trim(TxtTONS.Text)) Then
                                            ds.Tables(0).Rows(0).Item("TONS") = Trim(TxtTONS.Text)
                                        Else
                                            MsgBox("吨数一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                                            Exit Sub
                                        End If
                                    Else
                                        ds.Tables(0).Rows(0).Item("TONS") = 0
                                    End If

                                    If DTPETA_ARRIVER_TIME.Enabled = True Then
                                        ds.Tables(0).Rows(0).Item("ETA_ARRIVER_TIME") = DTPETA_ARRIVER_TIME.Value
                                    End If
                                    If DTPETA_SAILING_TIME.Enabled = True Then
                                        ds.Tables(0).Rows(0).Item("ETA_SAILING_TIME") = DTPETA_SAILING_TIME.Value
                                    End If
                                    If DTPARRIVER_TIME.Enabled = True Then
                                        ds.Tables(0).Rows(0).Item("ARRIVER_TIME") = DTPARRIVER_TIME.Value
                                    End If
                                    If DTPBERTH_TIME.Enabled = True Then
                                        ds.Tables(0).Rows(0).Item("BERTH_TIME") = DTPBERTH_TIME.Value
                                    End If
                                    If DTPWORKTIME_BEGIN.Enabled = True Then
                                        ds.Tables(0).Rows(0).Item("WORKTIME_BEGIN") = DTPWORKTIME_BEGIN.Value
                                    End If
                                    If DTPWORKTIME_END.Enabled = True Then
                                        ds.Tables(0).Rows(0).Item("WORKTIME_END") = DTPWORKTIME_END.Value
                                    End If
                                    If DTPSAILING_TIME.Enabled = True Then
                                        ds.Tables(0).Rows(0).Item("SAILING_TIME") = DTPSAILING_TIME.Value
                                    End If
                                    ds.Tables(0).Rows(0).Item("CLIENT") = TxtCLIENT.Text
                                    ds.Tables(0).Rows(0).Item("AGENT") = CmbAGENT.SelectedValue
                                    ds.Tables(0).Rows(0).Item("Code_ShipOwner") = CmbShipOwner.SelectedValue
                                    ds.Tables(0).Rows(0).Item("CONSIGNEE") = TxtCONSIGNEE.Text
                                    If Len(Trim(CmbDEPT_CODE.Text)) > 0 And Len(Trim(TxtBERTHNO.Text)) > 0 And CmbDEPT_CODE.SelectedValue <> "00" Then
                                        ds.Tables(0).Rows(0).Item("DEPT_CODE") = CmbDEPT_CODE.SelectedValue
                                    Else
                                        MsgBox("此时部门不能为空！", MsgBoxStyle.Exclamation, "提示")
                                        Exit Sub
                                        'ds.Tables(0).Rows(0).Item("DEPT_CODE") = "00"
                                    End If
                                    ds.Tables(0).Rows(0).Item("REMARK") = Trim(TxtREMARK.Text)
                                    sqlda.Update(ds)

                                    Dim ss As String
                                    ss = "update VESSEL set Vessel_Code='" & TxtVessel_Code.Text & "' where VESSEL_ID=" & TXTV_ID.Text & ""
                                    ExecSql(ss)

                                    Me.Close()
                                End If
                            End If
                        Else
                            MsgBox("船舶类别不能为空！")
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
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
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
            cmb_BERTH_POSITION.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub cmb_BERTH_POSITION_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmb_BERTH_POSITION.KeyDown
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
            ChkETA_ARRIVER_TIME.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub ChkETA_ARRIVER_TIME_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ChkETA_ARRIVER_TIME.KeyDown
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

    Private Sub TxtREMARK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtREMARK.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub CmbINOUTPORT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbINOUTPORT.SelectedIndexChanged
        If CmbINOUTPORT.Text = "进口" Then
            CmbNEXT_PORT.SelectedValue = "CNLYG"
        ElseIf CmbINOUTPORT.Text = "出口" Then
            CmbLAST_PORT.SelectedValue = "CNLYG"
        End If
    End Sub

    Private Sub CmbSHIP_STATU_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSHIP_STATU.SelectedIndexChanged
        Dim ds_ship_statu As New DataSet
        Dim dw_ship_statu As New DataView
        Dim BEGIN As String
        Dim WORKTIME_BEGIN As DateTime
        Dim WORKTIME_END As DateTime

        If CmbSHIP_STATU.Text = "作业完" Then
            ChkWORKTIME_BEGIN.Checked = True
            ChkWORKTIME_END.Checked = True

            dw_ship_statu = Getdata("SELECT min(convert(varchar(10),date,111)+' '+left(TIME_FROM,2)+':'+right(TIME_FROM,2)) FROM [CARGO_LIST] WHERE [SHIP_ID]=" & ID & "", ds_ship_statu)
            If dw_ship_statu.Count > 0 Then
                If IsDBNull(dw_ship_statu(0)(0)) = False Then
                    DTPWORKTIME_BEGIN.Value = dw_ship_statu(0)(0)
                End If
            End If
            dw_ship_statu = Getdata("SELECT min(convert(varchar(10),date,111)+' '+left(TIME_FROM,2)+':'+right(TIME_FROM,2)) FROM [CON_TALLY_LIST] WHERE [SHIP_ID]=" & ID & "", ds_ship_statu)
            If dw_ship_statu.Count > 0 Then
                If IsDBNull(dw_ship_statu(0)(0)) = False Then
                    If DateDiff(DateInterval.Day, DTPWORKTIME_BEGIN.Value, dw_ship_statu(0)(0)) < 0 Then
                        DTPWORKTIME_BEGIN.Value = dw_ship_statu(0)(0)
                    End If
                End If
            End If

            dw_ship_statu = Getdata("SELECT max(convert(varchar(10),date,111)+' '+left(TIME_TO,2)+':'+right(TIME_TO,2)) FROM [CARGO_LIST] WHERE [SHIP_ID]=" & ID & "", ds_ship_statu)
            If dw_ship_statu.Count > 0 Then
                If IsDBNull(dw_ship_statu(0)(0)) = False Then
                    DTPWORKTIME_END.Value = dw_ship_statu(0)(0)
                End If
            End If
            dw_ship_statu = Getdata("SELECT max(convert(varchar(10),date,111)+' '+left(TIME_FROM,2)+':'+right(TIME_FROM,2)) FROM [CON_TALLY_LIST] WHERE [SHIP_ID]=" & ID & "", ds_ship_statu)
            If dw_ship_statu.Count > 0 Then
                If IsDBNull(dw_ship_statu(0)(0)) = False Then

                    If DateDiff(DateInterval.Day, DTPWORKTIME_END.Value, dw_ship_statu(0)(0)) > 0 Then
                        DTPWORKTIME_END.Value = dw_ship_statu(0)(0)
                    End If
                End If
            End If
        Else
            ChkWORKTIME_BEGIN.Checked = False
            ChkWORKTIME_END.Checked = False
        End If
    End Sub

    Private Sub BtnVesseledit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVesseledit.Click
        Dim FrmEdit As New FrmVessel_Papers_Edit
        ID = TXTV_ID.Text
        FrmEdit.ShowDialog()
    End Sub

    Private Sub Custom_Edi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Custom_Edi.Click
        If TXTV_ID.Text.Trim().Length() > 0 And dv.Tables(0).Rows(0)("SIGN").ToString().Length > 0 Then
            Call CreatEdi()
        Else
            MsgBox("IMO号不能为空！")
        End If
    End Sub

    Private Sub CreatEdi()
        On Error GoTo Err
        Dim txtLine As String
        Dim i As Integer = 0 '记录行数
        Dim sj As String
        Dim strFile As String
        Dim IorExport As String
        Dim vcode As String

        If ds.Tables(0).Rows(0).Item("INOUTPORT") = "1" Then
            IorExport = "I"
        Else
            IorExport = "E"
        End If
        If dv.Tables(0).Rows(0)("Vessel_Code").ToString.Length > 0 Then
            vcode = dv.Tables(0).Rows(0)("Vessel_Code")
        Else
            vcode = "NOVESSELCODE"
        End If
        sj = DateTime.Now.ToString("yyyyMMddHHmm")
        strFile = "D:\EDI\TallyRead\申请报文" & vcode & "_" & ds.Tables(0).Rows(0).Item("VOYAGE") & "_" & sj & ".txt"
        File.Delete(strFile)
        Dim sw As New StreamWriter(strFile, FileMode.OpenOrCreate, System.Text.Encoding.Default())  '打开报文文件
        '**************写00行  '申请报文OPMA_1340E_20131011145455477
        txtLine = "00:NCREQ:NCREQ:9:LYGWL:LYGEDI:" & sj
        txtLine = txtLine + "'"
        sw.WriteLine(txtLine)
        i = 1
        '************写12 提单循环  12:OPMA:UN9609419:1:I:OPTIMA:1340E::LYGWL'
        txtLine = "12:" & vcode & ":" & dv.Tables(0).Rows(0)("SIGN") & ":" & ds.Tables(0).Rows(0)("CODE_GOODS") & ":" & IorExport & ":" & ds.Tables(0).Rows(0)("ENG_VESSEL") & ":" & ds.Tables(0).Rows(0)("VOYAGE")
        txtLine = txtLine + "::LYGWL'"
        sw.WriteLine(txtLine)
        i = i + 1
        '**************写99行 报文总行数 99:'
        txtLine = "99:" & Trim(CType(i + 1, String)) & "'"
        sw.WriteLine(txtLine)
        sw.Close()
        MsgBox("报文生成完成！ 共计 " & Trim(CType(i + 1, String)) & " 行 ")
        Exit Sub
Err:
        MsgBox(Err.Description)
    End Sub

End Class
