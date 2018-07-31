Imports TALLY.DBControl
Public Class FrmVessel_Papers_Edit
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim ds_sub As New DataSet()
    Dim dw As New DataView()
    Dim dw_sub As New DataView()
    Dim sqlda_sub As New SqlClient.SqlDataAdapter()
    Dim sqlda As New SqlClient.SqlDataAdapter()

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
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnSave1 As System.Windows.Forms.Button
    Friend WithEvents TxtENG_VESSEL As System.Windows.Forms.TextBox
    Friend WithEvents TxtCHI_VESSEL As System.Windows.Forms.TextBox
    Friend WithEvents TxtSIGN As System.Windows.Forms.TextBox
    Friend WithEvents TxtOWNER_SHIP As System.Windows.Forms.TextBox
    Friend WithEvents TxtLOA As System.Windows.Forms.TextBox
    Friend WithEvents TxtBEAM As System.Windows.Forms.TextBox
    Friend WithEvents TxtVESSEL_DRAFT As System.Windows.Forms.TextBox
    Friend WithEvents TxtSHIP_SPEED As System.Windows.Forms.TextBox
    Friend WithEvents TxtPCTN_NUM As System.Windows.Forms.TextBox
    Friend WithEvents TxtHATCH As System.Windows.Forms.TextBox
    Friend WithEvents TxtBUILED_DATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtGROSS_TONS As System.Windows.Forms.TextBox
    Friend WithEvents TxtTON_NET As System.Windows.Forms.TextBox
    Friend WithEvents TxtTON_DEAD As System.Windows.Forms.TextBox
    Friend WithEvents TxtBALE As System.Windows.Forms.TextBox
    Friend WithEvents TxtBULKS As System.Windows.Forms.TextBox
    Friend WithEvents TxtDERRICK As System.Windows.Forms.TextBox
    Friend WithEvents TxtTPC As System.Windows.Forms.TextBox
    Friend WithEvents TxtVessel_ID As System.Windows.Forms.TextBox
    Friend WithEvents TxtLINER_ID As System.Windows.Forms.ComboBox
    Friend WithEvents TxtNATIONALITY_CODE As System.Windows.Forms.ComboBox
    Friend WithEvents TxtVESSEL_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents TxtUSER_NAME As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents TxtVessel_Code As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVessel_Papers_Edit))
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtENG_VESSEL = New System.Windows.Forms.TextBox
        Me.TxtCHI_VESSEL = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtSIGN = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtGROSS_TONS = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtTON_NET = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.btnQuit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.TxtTON_DEAD = New System.Windows.Forms.TextBox
        Me.TxtTPC = New System.Windows.Forms.TextBox
        Me.TxtBULKS = New System.Windows.Forms.TextBox
        Me.TxtBALE = New System.Windows.Forms.TextBox
        Me.TxtPCTN_NUM = New System.Windows.Forms.TextBox
        Me.TxtOWNER_SHIP = New System.Windows.Forms.TextBox
        Me.TxtHATCH = New System.Windows.Forms.TextBox
        Me.TxtDERRICK = New System.Windows.Forms.TextBox
        Me.TxtLOA = New System.Windows.Forms.TextBox
        Me.TxtBEAM = New System.Windows.Forms.TextBox
        Me.TxtVESSEL_DRAFT = New System.Windows.Forms.TextBox
        Me.TxtSHIP_SPEED = New System.Windows.Forms.TextBox
        Me.TxtBUILED_DATE = New System.Windows.Forms.DateTimePicker
        Me.GB = New System.Windows.Forms.GroupBox
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btnSave1 = New System.Windows.Forms.Button
        Me.TxtVessel_ID = New System.Windows.Forms.TextBox
        Me.TxtLINER_ID = New System.Windows.Forms.ComboBox
        Me.TxtNATIONALITY_CODE = New System.Windows.Forms.ComboBox
        Me.TxtVESSEL_TYPE = New System.Windows.Forms.ComboBox
        Me.TxtUSER_NAME = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.TxtVessel_Code = New System.Windows.Forms.TextBox
        Me.btQuit = New System.Windows.Forms.Button
        Me.GB.SuspendLayout()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "英文船名"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtENG_VESSEL
        '
        Me.TxtENG_VESSEL.Location = New System.Drawing.Point(64, 4)
        Me.TxtENG_VESSEL.MaxLength = 50
        Me.TxtENG_VESSEL.Name = "TxtENG_VESSEL"
        Me.TxtENG_VESSEL.Size = New System.Drawing.Size(100, 21)
        Me.TxtENG_VESSEL.TabIndex = 0
        '
        'TxtCHI_VESSEL
        '
        Me.TxtCHI_VESSEL.Location = New System.Drawing.Point(64, 26)
        Me.TxtCHI_VESSEL.MaxLength = 40
        Me.TxtCHI_VESSEL.Name = "TxtCHI_VESSEL"
        Me.TxtCHI_VESSEL.Size = New System.Drawing.Size(100, 21)
        Me.TxtCHI_VESSEL.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(6, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "中文船名"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "IMO号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtSIGN
        '
        Me.TxtSIGN.Location = New System.Drawing.Point(64, 48)
        Me.TxtSIGN.MaxLength = 15
        Me.TxtSIGN.Name = "TxtSIGN"
        Me.TxtSIGN.Size = New System.Drawing.Size(100, 21)
        Me.TxtSIGN.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(6, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "国籍"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "班轮标识"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(8, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "船舶类型"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(328, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "总吨"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtGROSS_TONS
        '
        Me.TxtGROSS_TONS.Location = New System.Drawing.Point(386, 4)
        Me.TxtGROSS_TONS.Name = "TxtGROSS_TONS"
        Me.TxtGROSS_TONS.Size = New System.Drawing.Size(100, 21)
        Me.TxtGROSS_TONS.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(328, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "净吨"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTON_NET
        '
        Me.TxtTON_NET.Location = New System.Drawing.Point(386, 26)
        Me.TxtTON_NET.Name = "TxtTON_NET"
        Me.TxtTON_NET.Size = New System.Drawing.Size(100, 21)
        Me.TxtTON_NET.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(328, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "包装容积"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(328, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "散装容积"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(168, 2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "船公司"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(165, 138)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "建造日期"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(8, 95)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 20)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "舱口数"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(328, 50)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 20)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "载重吨"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(160, 121)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 20)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "航速"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(328, 138)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 20)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "公分吨"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(160, 96)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 20)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "最大航速"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(160, 72)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 20)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "最大吃水"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(328, 116)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 20)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "吊杆能力"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(160, 24)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 20)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "船长"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(160, 48)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(56, 20)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "船宽"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(248, 170)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(65, 24)
        Me.btnQuit.TabIndex = 25
        Me.btnQuit.Text = "取消"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(180, 170)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(65, 24)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "确认"
        '
        'TxtTON_DEAD
        '
        Me.TxtTON_DEAD.Location = New System.Drawing.Point(386, 48)
        Me.TxtTON_DEAD.Name = "TxtTON_DEAD"
        Me.TxtTON_DEAD.Size = New System.Drawing.Size(100, 21)
        Me.TxtTON_DEAD.TabIndex = 17
        '
        'TxtTPC
        '
        Me.TxtTPC.Location = New System.Drawing.Point(386, 136)
        Me.TxtTPC.MaxLength = 50
        Me.TxtTPC.Name = "TxtTPC"
        Me.TxtTPC.Size = New System.Drawing.Size(100, 21)
        Me.TxtTPC.TabIndex = 21
        '
        'TxtBULKS
        '
        Me.TxtBULKS.Location = New System.Drawing.Point(386, 92)
        Me.TxtBULKS.MaxLength = 50
        Me.TxtBULKS.Name = "TxtBULKS"
        Me.TxtBULKS.Size = New System.Drawing.Size(100, 21)
        Me.TxtBULKS.TabIndex = 19
        '
        'TxtBALE
        '
        Me.TxtBALE.Location = New System.Drawing.Point(386, 70)
        Me.TxtBALE.Name = "TxtBALE"
        Me.TxtBALE.Size = New System.Drawing.Size(100, 21)
        Me.TxtBALE.TabIndex = 18
        '
        'TxtPCTN_NUM
        '
        Me.TxtPCTN_NUM.Location = New System.Drawing.Point(224, 115)
        Me.TxtPCTN_NUM.Name = "TxtPCTN_NUM"
        Me.TxtPCTN_NUM.Size = New System.Drawing.Size(100, 21)
        Me.TxtPCTN_NUM.TabIndex = 12
        '
        'TxtOWNER_SHIP
        '
        Me.TxtOWNER_SHIP.Location = New System.Drawing.Point(224, 4)
        Me.TxtOWNER_SHIP.MaxLength = 50
        Me.TxtOWNER_SHIP.Name = "TxtOWNER_SHIP"
        Me.TxtOWNER_SHIP.Size = New System.Drawing.Size(100, 21)
        Me.TxtOWNER_SHIP.TabIndex = 7
        '
        'TxtHATCH
        '
        Me.TxtHATCH.Location = New System.Drawing.Point(64, 92)
        Me.TxtHATCH.Name = "TxtHATCH"
        Me.TxtHATCH.Size = New System.Drawing.Size(100, 21)
        Me.TxtHATCH.TabIndex = 4
        '
        'TxtDERRICK
        '
        Me.TxtDERRICK.Location = New System.Drawing.Point(386, 114)
        Me.TxtDERRICK.MaxLength = 7
        Me.TxtDERRICK.Name = "TxtDERRICK"
        Me.TxtDERRICK.Size = New System.Drawing.Size(100, 21)
        Me.TxtDERRICK.TabIndex = 20
        '
        'TxtLOA
        '
        Me.TxtLOA.Location = New System.Drawing.Point(224, 26)
        Me.TxtLOA.Name = "TxtLOA"
        Me.TxtLOA.Size = New System.Drawing.Size(100, 21)
        Me.TxtLOA.TabIndex = 8
        '
        'TxtBEAM
        '
        Me.TxtBEAM.Location = New System.Drawing.Point(224, 48)
        Me.TxtBEAM.MaxLength = 50
        Me.TxtBEAM.Name = "TxtBEAM"
        Me.TxtBEAM.Size = New System.Drawing.Size(100, 21)
        Me.TxtBEAM.TabIndex = 9
        '
        'TxtVESSEL_DRAFT
        '
        Me.TxtVESSEL_DRAFT.Location = New System.Drawing.Point(224, 69)
        Me.TxtVESSEL_DRAFT.Name = "TxtVESSEL_DRAFT"
        Me.TxtVESSEL_DRAFT.Size = New System.Drawing.Size(100, 21)
        Me.TxtVESSEL_DRAFT.TabIndex = 10
        '
        'TxtSHIP_SPEED
        '
        Me.TxtSHIP_SPEED.Location = New System.Drawing.Point(224, 92)
        Me.TxtSHIP_SPEED.MaxLength = 50
        Me.TxtSHIP_SPEED.Name = "TxtSHIP_SPEED"
        Me.TxtSHIP_SPEED.Size = New System.Drawing.Size(100, 21)
        Me.TxtSHIP_SPEED.TabIndex = 11
        '
        'TxtBUILED_DATE
        '
        Me.TxtBUILED_DATE.CustomFormat = "yyyy/MM/dd"
        Me.TxtBUILED_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtBUILED_DATE.Location = New System.Drawing.Point(225, 139)
        Me.TxtBUILED_DATE.Name = "TxtBUILED_DATE"
        Me.TxtBUILED_DATE.Size = New System.Drawing.Size(100, 21)
        Me.TxtBUILED_DATE.TabIndex = 14
        '
        'GB
        '
        Me.GB.Controls.Add(Me.C1DBG)
        Me.GB.Location = New System.Drawing.Point(4, 196)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(484, 142)
        Me.GB.TabIndex = 23
        Me.GB.TabStop = False
        Me.GB.Text = "分舱规范"
        '
        'C1DBG
        '
        Me.C1DBG.AllowAddNew = True
        Me.C1DBG.AllowDelete = True
        Me.C1DBG.FetchRowStyles = True
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("C1DBG.Images"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(4, 18)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG.Size = New System.Drawing.Size(478, 122)
        Me.C1DBG.TabIndex = 0
        Me.C1DBG.PropBag = resources.GetString("C1DBG.PropBag")
        '
        'btnSave1
        '
        Me.btnSave1.Enabled = False
        Me.btnSave1.Location = New System.Drawing.Point(180, 343)
        Me.btnSave1.Name = "btnSave1"
        Me.btnSave1.Size = New System.Drawing.Size(65, 24)
        Me.btnSave1.TabIndex = 24
        Me.btnSave1.Text = "确认"
        '
        'TxtVessel_ID
        '
        Me.TxtVessel_ID.Location = New System.Drawing.Point(22, 164)
        Me.TxtVessel_ID.Name = "TxtVessel_ID"
        Me.TxtVessel_ID.ReadOnly = True
        Me.TxtVessel_ID.Size = New System.Drawing.Size(22, 21)
        Me.TxtVessel_ID.TabIndex = 115
        Me.TxtVessel_ID.Visible = False
        '
        'TxtLINER_ID
        '
        Me.TxtLINER_ID.Location = New System.Drawing.Point(64, 116)
        Me.TxtLINER_ID.Name = "TxtLINER_ID"
        Me.TxtLINER_ID.Size = New System.Drawing.Size(100, 20)
        Me.TxtLINER_ID.TabIndex = 5
        '
        'TxtNATIONALITY_CODE
        '
        Me.TxtNATIONALITY_CODE.Location = New System.Drawing.Point(64, 70)
        Me.TxtNATIONALITY_CODE.MaxDropDownItems = 15
        Me.TxtNATIONALITY_CODE.Name = "TxtNATIONALITY_CODE"
        Me.TxtNATIONALITY_CODE.Size = New System.Drawing.Size(100, 20)
        Me.TxtNATIONALITY_CODE.TabIndex = 3
        '
        'TxtVESSEL_TYPE
        '
        Me.TxtVESSEL_TYPE.Location = New System.Drawing.Point(64, 140)
        Me.TxtVESSEL_TYPE.Name = "TxtVESSEL_TYPE"
        Me.TxtVESSEL_TYPE.Size = New System.Drawing.Size(100, 20)
        Me.TxtVESSEL_TYPE.TabIndex = 6
        '
        'TxtUSER_NAME
        '
        Me.TxtUSER_NAME.Location = New System.Drawing.Point(46, 164)
        Me.TxtUSER_NAME.Name = "TxtUSER_NAME"
        Me.TxtUSER_NAME.ReadOnly = True
        Me.TxtUSER_NAME.Size = New System.Drawing.Size(22, 21)
        Me.TxtUSER_NAME.TabIndex = 115
        Me.TxtUSER_NAME.Visible = False
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(328, 160)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 20)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "船码"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtVessel_Code
        '
        Me.TxtVessel_Code.Location = New System.Drawing.Point(386, 159)
        Me.TxtVessel_Code.MaxLength = 9
        Me.TxtVessel_Code.Name = "TxtVessel_Code"
        Me.TxtVessel_Code.Size = New System.Drawing.Size(100, 21)
        Me.TxtVessel_Code.TabIndex = 116
        '
        'btQuit
        '
        Me.btQuit.Enabled = False
        Me.btQuit.Location = New System.Drawing.Point(248, 343)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 117
        Me.btQuit.Text = "取消"
        '
        'FrmVessel_Papers_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(492, 371)
        Me.Controls.Add(Me.TxtNATIONALITY_CODE)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.TxtVessel_Code)
        Me.Controls.Add(Me.TxtLINER_ID)
        Me.Controls.Add(Me.TxtVessel_ID)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.TxtBUILED_DATE)
        Me.Controls.Add(Me.TxtDERRICK)
        Me.Controls.Add(Me.TxtLOA)
        Me.Controls.Add(Me.TxtBEAM)
        Me.Controls.Add(Me.TxtVESSEL_DRAFT)
        Me.Controls.Add(Me.TxtSHIP_SPEED)
        Me.Controls.Add(Me.TxtTON_DEAD)
        Me.Controls.Add(Me.TxtTPC)
        Me.Controls.Add(Me.TxtBULKS)
        Me.Controls.Add(Me.TxtBALE)
        Me.Controls.Add(Me.TxtPCTN_NUM)
        Me.Controls.Add(Me.TxtOWNER_SHIP)
        Me.Controls.Add(Me.TxtHATCH)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TxtENG_VESSEL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCHI_VESSEL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtSIGN)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtGROSS_TONS)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtTON_NET)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.btnSave1)
        Me.Controls.Add(Me.TxtVESSEL_TYPE)
        Me.Controls.Add(Me.TxtUSER_NAME)
        Me.Controls.Add(Me.Label20)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmVessel_Papers_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "船舶规范_编辑"
        Me.GB.ResumeLayout(False)
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub FrmVessel_Papers_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim sqlstr As String

        sqlstr = "select * from VESSEL where Vessel_ID=" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)
        fillNATIONALITY_CODE()
        fillLINER_ID()
        fillVESSEL_TYPE()

        If dw.Count > 0 Then
            TxtVessel_ID.Text = ds.Tables(0).Rows(0).Item("VESSEL_ID")
            TxtENG_VESSEL.Text = ds.Tables(0).Rows(0).Item("ENG_VESSEL")
            TxtCHI_VESSEL.Text = ds.Tables(0).Rows(0).Item("CHI_VESSEL")
            TxtSIGN.Text = ds.Tables(0).Rows(0).Item("SIGN")
            TxtNATIONALITY_CODE.SelectedValue = ds.Tables(0).Rows(0).Item("NATIONALITY_CODE")
            TxtLINER_ID.SelectedValue = ds.Tables(0).Rows(0).Item("LINER_ID")
            TxtVESSEL_TYPE.SelectedValue = ds.Tables(0).Rows(0).Item("VESSEL_TYPE")
            TxtOWNER_SHIP.Text = ds.Tables(0).Rows(0).Item("OWNER_SHIP")
            TxtLOA.Text = ds.Tables(0).Rows(0).Item("LOA")
            TxtBEAM.Text = ds.Tables(0).Rows(0).Item("BEAM")
            TxtVESSEL_DRAFT.Text = ds.Tables(0).Rows(0).Item("VESSEL_DRAFT")
            TxtSHIP_SPEED.Text = ds.Tables(0).Rows(0).Item("SHIP_SPEED")
            TxtPCTN_NUM.Text = ds.Tables(0).Rows(0).Item("PCTN_NUM")
            TxtHATCH.Text = ds.Tables(0).Rows(0).Item("HATCH")
            TxtBUILED_DATE.Value = ds.Tables(0).Rows(0).Item("BUILED_DATE")
            TxtGROSS_TONS.Text = ds.Tables(0).Rows(0).Item("GROSS_TONS")
            TxtTON_NET.Text = ds.Tables(0).Rows(0).Item("TON_NET")
            TxtTON_DEAD.Text = ds.Tables(0).Rows(0).Item("TON_DEAD")
            TxtBALE.Text = ds.Tables(0).Rows(0).Item("BALE")
            TxtBULKS.Text = ds.Tables(0).Rows(0).Item("BULKS")
            TxtDERRICK.Text = ds.Tables(0).Rows(0).Item("DERRICK")
            TxtTPC.Text = ds.Tables(0).Rows(0).Item("TPC")
            TxtVessel_Code.Text = ds.Tables(0).Rows(0).Item("Vessel_Code")
            TxtUSER_NAME.Text = Trim(G_User)
        End If
        TxtENG_VESSEL.Focus()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub fillNATIONALITY_CODE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "select NATIONALITY_CHA,NATIONALITY_ENG from CODE_NATIONALITY order by NATIONALITY_CHA"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.TxtNATIONALITY_CODE.DataSource = dvc
        Me.TxtNATIONALITY_CODE.DisplayMember = "NATIONALITY_CHA"
        Me.TxtNATIONALITY_CODE.ValueMember = "NATIONALITY_ENG"
    End Sub

    Private Sub fillLINER_ID()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "select Descri,Value from CodeLINER_ID"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.TxtLINER_ID.DataSource = dvc
        Me.TxtLINER_ID.DisplayMember = "Descri"
        Me.TxtLINER_ID.ValueMember = "Value"
    End Sub

    Private Sub fillVESSEL_TYPE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "select Descr,Value from CodeShipType"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.TxtVESSEL_TYPE.DataSource = dvc
        Me.TxtVESSEL_TYPE.DisplayMember = "Descr"
        Me.TxtVESSEL_TYPE.ValueMember = "Value"
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If MsgBox("你确认要修改吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
                If Len(Trim(TxtENG_VESSEL.Text)) = 0 Then
                    MsgBox("英文船名一栏不能为空！", MsgBoxStyle.Exclamation, "提示")
                    Exit Sub
                End If
                If Len(Trim(TxtNATIONALITY_CODE.Text)) = 0 Then
                    MsgBox("国籍一栏不能为空！", MsgBoxStyle.Exclamation, "提示")
                    Exit Sub
                End If
                If Len(Trim(TxtHATCH.Text)) = 0 And TxtVESSEL_TYPE.SelectedValue <> "5" Then
                    MsgBox("舱口数一栏不能为空！", MsgBoxStyle.Exclamation, "提示")
                    Exit Sub
                End If
                If Len(Trim(TxtCHI_VESSEL.Text)) > 0 Then
                    Call OperateHistory(G_DeptName, Now, G_User, "编辑", "VESSEL", Trim(TxtVessel_ID.Text), "VESSEL_ID")

                    ds.Tables(0).Rows(0).Item("ENG_VESSEL") = Trim(TxtENG_VESSEL.Text)
                    ds.Tables(0).Rows(0).Item("CHI_VESSEL") = Trim(TxtCHI_VESSEL.Text)
                    ds.Tables(0).Rows(0).Item("SIGN") = Trim(TxtSIGN.Text)
                    ds.Tables(0).Rows(0).Item("NATIONALITY_CODE") = TxtNATIONALITY_CODE.SelectedValue
                    ds.Tables(0).Rows(0).Item("LINER_ID") = TxtLINER_ID.SelectedValue
                    ds.Tables(0).Rows(0).Item("VESSEL_TYPE") = TxtVESSEL_TYPE.SelectedValue
                    ds.Tables(0).Rows(0).Item("OWNER_SHIP") = Trim(TxtOWNER_SHIP.Text)

                    If Len(Trim(TxtLOA.Text)) > 0 Then
                        If IsNumeric(Trim(TxtLOA.Text)) Then
                            ds.Tables(0).Rows(0).Item("LOA") = Trim(TxtLOA.Text)
                        Else
                            MsgBox("船长一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                            Exit Sub
                        End If
                    End If
                    If Len(Trim(TxtBEAM.Text)) > 0 Then
                        If IsNumeric(Trim(TxtBEAM.Text)) Then
                            ds.Tables(0).Rows(0).Item("BEAM") = Trim(TxtBEAM.Text)
                        Else
                            MsgBox("船宽一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                            Exit Sub
                        End If
                    End If
                    If Len(Trim(TxtVESSEL_DRAFT.Text)) > 0 Then
                        If IsNumeric(Trim(TxtVESSEL_DRAFT.Text)) Then
                            ds.Tables(0).Rows(0).Item("VESSEL_DRAFT") = Trim(TxtVESSEL_DRAFT.Text)
                        Else
                            MsgBox("最大吃水一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                            Exit Sub
                        End If
                    End If
                    If Len(Trim(TxtSHIP_SPEED.Text)) > 0 Then
                        If IsNumeric(Trim(TxtSHIP_SPEED.Text)) Then
                            ds.Tables(0).Rows(0).Item("SHIP_SPEED") = Trim(TxtSHIP_SPEED.Text)
                        Else
                            MsgBox("最大航速一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                            Exit Sub
                        End If
                    End If
                    If Len(Trim(TxtPCTN_NUM.Text)) > 0 Then
                        If IsNumeric(Trim(TxtPCTN_NUM.Text)) Then
                            ds.Tables(0).Rows(0).Item("PCTN_NUM") = Trim(TxtPCTN_NUM.Text)
                        Else
                            MsgBox("航速一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                            Exit Sub
                        End If
                    End If
                    If Len(Trim(TxtHATCH.Text)) > 0 Then
                        If IsNumeric(Trim(TxtHATCH.Text)) Then
                            ds.Tables(0).Rows(0).Item("HATCH") = Trim(TxtHATCH.Text)
                        Else
                            MsgBox("舱口数一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                            Exit Sub
                        End If
                    End If
                    ds.Tables(0).Rows(0).Item("BUILED_DATE") = TxtBUILED_DATE.Value

                    If Len(Trim(TxtGROSS_TONS.Text)) > 0 Then
                        If IsNumeric(Trim(TxtGROSS_TONS.Text)) Then
                            ds.Tables(0).Rows(0).Item("GROSS_TONS") = Trim(TxtGROSS_TONS.Text)
                        Else
                            MsgBox("总吨一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                            Exit Sub
                        End If
                    End If
                    If Len(Trim(TxtTON_NET.Text)) > 0 Then
                        If IsNumeric(Trim(TxtTON_NET.Text)) Then
                            ds.Tables(0).Rows(0).Item("TON_NET") = Trim(TxtTON_NET.Text)
                        Else
                            MsgBox("净吨一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                            Exit Sub
                        End If
                    End If
                    If Len(Trim(TxtTON_DEAD.Text)) > 0 Then
                        If IsNumeric(Trim(TxtTON_DEAD.Text)) Then
                            ds.Tables(0).Rows(0).Item("TON_DEAD") = Trim(TxtTON_DEAD.Text)
                        Else
                            MsgBox("载重吨一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                            Exit Sub
                        End If
                    End If
                    If Len(Trim(TxtBALE.Text)) > 0 Then
                        If IsNumeric(Trim(TxtBALE.Text)) Then
                            ds.Tables(0).Rows(0).Item("BALE") = Trim(TxtBALE.Text)
                        Else
                            MsgBox("包装容积一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                            Exit Sub
                        End If
                    End If
                    If Len(Trim(TxtBULKS.Text)) > 0 Then
                        If IsNumeric(Trim(TxtBULKS.Text)) Then
                            ds.Tables(0).Rows(0).Item("BULKS") = Trim(TxtBULKS.Text)
                        Else
                            MsgBox("散装容积一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                            Exit Sub
                        End If
                    End If
                    If Len(Trim(TxtDERRICK.Text)) > 0 Then
                        If IsNumeric(Trim(TxtDERRICK.Text)) Then
                            ds.Tables(0).Rows(0).Item("DERRICK") = Trim(TxtDERRICK.Text)
                        Else
                            MsgBox("吊杆能力一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                            Exit Sub
                        End If
                    End If
                    If Len(Trim(TxtTPC.Text)) > 0 Then
                        If IsNumeric(Trim(TxtTPC.Text)) Then
                            ds.Tables(0).Rows(0).Item("TPC") = Trim(TxtTPC.Text)
                        Else
                            MsgBox("公分吨一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                            Exit Sub
                        End If
                    End If

                    ds.Tables(0).Rows(0).Item("Vessel_Code") = Trim(TxtVessel_Code.Text)

                    sqlda.Update(ds)
                    btnSave.Enabled = False
                    btnQuit.Enabled = False
                    btnSave1.Enabled = True
                    btQuit.Enabled = True

                    '***************编辑子表
                    Dim str As String
                    Dim i As Integer
                    Dim dsCabin As New DataSet
                    Dim sqla As New SqlClient.SqlDataAdapter
                    Dim sqlc As New SqlClient.SqlCommand

                    str = "select * from VESSEL_HATCH where V_ID=" & CType(Trim(TxtVessel_ID.Text), Int32)
                    dw_sub = Updatedata(sqlda_sub, str, ds_sub)
                    Me.C1DBG.DataSource = dw_sub
                    '***************初始化
                    Me.C1DBG.Splits(0).DisplayColumns.Item("V_HATCH_ID").Visible = False
                    Me.C1DBG.Splits(0).DisplayColumns.Item("V_ID").Visible = False
                    Me.C1DBG.Splits(0).DisplayColumns.Item("CHI_VESSEL").Visible = False
                    Me.C1DBG.Splits(0).DisplayColumns.Item("ENG_VESSEL").Visible = False
                    Me.C1DBG.Splits(0).DisplayColumns.Item("SIGN").Visible = False
                    Me.C1DBG.Splits(0).DisplayColumns.Item("USER_NAME").Visible = False
                    Me.C1DBG.Columns.Item(5).Caption = "舱别"
                    Me.C1DBG.Columns.Item(6).Caption = "舱内层数"
                    Me.C1DBG.Splits(0).DisplayColumns.Item(5).Width = 80
                    Me.C1DBG.Splits(0).DisplayColumns.Item(6).Width = 60
                    Me.C1DBG.Splits(0).DisplayColumns.Item(5).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    Me.C1DBG.Splits(0).DisplayColumns.Item(6).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    Me.C1DBG.Splits(0).DisplayColumns.Item(5).Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    Me.C1DBG.Splits(0).DisplayColumns.Item(6).Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    Me.C1DBG.Refresh()

                    For i = 0 To ds_sub.Tables(0).Rows.Count - 1
                        Me.C1DBG.Columns.Item(2).Value = TxtCHI_VESSEL.Text
                        Me.C1DBG.Columns.Item(3).Value = TxtENG_VESSEL.Text
                        Me.C1DBG.Columns.Item(4).Value = TxtSIGN.Text
                        If i < ds_sub.Tables(0).Rows.Count - 1 Then
                            Me.C1DBG.Row = Me.C1DBG.Row + 1
                        End If
                        sqlda_sub.Update(ds_sub)
                    Next
                    Me.C1DBG.Refresh()

                    If ds_sub.Tables(0).Rows.Count = 0 Then
                        Me.C1DBG.Select()
                        Me.C1DBG.Row = Me.C1DBG.Row + 1
                        Me.C1DBG.Columns.Item("V_ID").Text = TxtVessel_ID.Text
                    End If

                    '*******舱别代码
                    Me.C1DBG.Columns.Item(5).ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
                    Me.C1DBG.Columns.Item(5).ValueItems.Translate = True
                    Me.C1DBG.Columns.Item(5).ValueItems.Validate = True
                    sqlc.Connection = sqlconn
                    sqlc.CommandText = "SELECT Value,DESCR FROM CodeCabin"
                    sqla.SelectCommand = sqlc
                    dsCabin.Reset()
                    sqla.Fill(dsCabin)
                    For i = 0 To dsCabin.Tables(0).Rows.Count - 1
                        Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                        vi.DisplayValue = Trim(dsCabin.Tables(0).Rows(i)("DESCR"))
                        vi.Value = Trim(dsCabin.Tables(0).Rows(i)("Value"))
                        Me.C1DBG.Columns.Item(5).ValueItems.Values.Add(vi)
                    Next

                    '*******其余列赋值
                    Me.C1DBG.Columns.Item(1).Text = TxtVessel_ID.Text
                    Me.C1DBG.Columns.Item(2).Text = TxtCHI_VESSEL.Text
                    Me.C1DBG.Columns.Item(3).Text = TxtENG_VESSEL.Text
                    Me.C1DBG.Columns.Item(4).Text = TxtSIGN.Text
                    Me.C1DBG.Columns.Item(7).Text = Trim(G_User)
                    Me.C1DBG.Refresh()

                    btnSave.Enabled = False
                    btnQuit.Enabled = False
                    btnSave1.Enabled = True
                Else
                    MsgBox("中文船名不能为空!", MsgBoxStyle.Critical, "提示")
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSave1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave1.Click
        Try
            If MsgBox("你确认要修改吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
                sqlda_sub.Update(ds_sub)
                Me.Close()
            End If
        Catch ex As System.Exception
            Me.Close()
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub C1DBG_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles C1DBG.RowColChange
        Try
            'If Me.C1DBG.Columns.Item("V_ID").Text = "" Then
            Me.C1DBG.Columns.Item(1).Text = TxtVessel_ID.Text
            Me.C1DBG.Columns.Item(2).Text = TxtCHI_VESSEL.Text
            Me.C1DBG.Columns.Item(3).Text = TxtENG_VESSEL.Text
            Me.C1DBG.Columns.Item(4).Text = TxtSIGN.Text
            Me.C1DBG.Columns.Item(7).Text = Trim(G_User)
            'Me.C1DBG.Refresh()
            'End If
        Catch ex As System.Exception
        End Try
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtENG_VESSEL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtENG_VESSEL.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtCHI_VESSEL.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtCHI_VESSEL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCHI_VESSEL.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtSIGN.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtSIGN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSIGN.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtNATIONALITY_CODE.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtNATIONALITY_CODE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNATIONALITY_CODE.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtHATCH.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtHATCH_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtHATCH.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtLINER_ID.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtLINER_ID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtLINER_ID.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtVESSEL_TYPE.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtVESSEL_TYPE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtVESSEL_TYPE.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtOWNER_SHIP.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtOWNER_SHIP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtOWNER_SHIP.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtLOA.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtLOA_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtLOA.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtBEAM.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtBEAM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBEAM.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtVESSEL_DRAFT.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtVESSEL_DRAFT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtVESSEL_DRAFT.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtSHIP_SPEED.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtSHIP_SPEED_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSHIP_SPEED.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtPCTN_NUM.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtPCTN_NUM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPCTN_NUM.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtBUILED_DATE.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

   Private Sub TxtBUILED_DATE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBUILED_DATE.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtGROSS_TONS.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtGROSS_TONS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtGROSS_TONS.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTON_NET.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtTON_NET_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTON_NET.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTON_DEAD.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtTON_DEAD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTON_DEAD.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtBALE.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtBALE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBALE.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtBULKS.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtBULKS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBULKS.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDERRICK.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtDERRICK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDERRICK.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTPC.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtTPC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTPC.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnSave.KeyDown
        If e.KeyCode = Keys.Enter Then
            C1DBG.Focus()
        End If
    End Sub

    Private Sub C1DBG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1DBG.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave1.Focus()
        End If
    End Sub

    Private Sub btnQuit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnQuit.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSave1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnSave1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

End Class
