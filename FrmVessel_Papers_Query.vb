Imports TALLY.DBControl
Public Class FrmVessel_Papers_Query
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim ds_sub As New DataSet()
    Dim dw As New DataView()
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
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents TxtVESSEL_IMO As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmVessel_Papers_Query))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtENG_VESSEL = New System.Windows.Forms.TextBox()
        Me.TxtCHI_VESSEL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSIGN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtGROSS_TONS = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTON_NET = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TxtTON_DEAD = New System.Windows.Forms.TextBox()
        Me.TxtTPC = New System.Windows.Forms.TextBox()
        Me.TxtBULKS = New System.Windows.Forms.TextBox()
        Me.TxtBALE = New System.Windows.Forms.TextBox()
        Me.TxtPCTN_NUM = New System.Windows.Forms.TextBox()
        Me.TxtOWNER_SHIP = New System.Windows.Forms.TextBox()
        Me.TxtHATCH = New System.Windows.Forms.TextBox()
        Me.TxtDERRICK = New System.Windows.Forms.TextBox()
        Me.TxtLOA = New System.Windows.Forms.TextBox()
        Me.TxtBEAM = New System.Windows.Forms.TextBox()
        Me.TxtVESSEL_DRAFT = New System.Windows.Forms.TextBox()
        Me.TxtSHIP_SPEED = New System.Windows.Forms.TextBox()
        Me.GB = New System.Windows.Forms.GroupBox()
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.TxtVessel_ID = New System.Windows.Forms.TextBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.TxtLINER_ID = New System.Windows.Forms.ComboBox()
        Me.TxtNATIONALITY_CODE = New System.Windows.Forms.ComboBox()
        Me.TxtVESSEL_TYPE = New System.Windows.Forms.ComboBox()
        Me.TxtVESSEL_IMO = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GB.SuspendLayout()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "英文船名"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtENG_VESSEL
        '
        Me.TxtENG_VESSEL.Location = New System.Drawing.Point(60, 2)
        Me.TxtENG_VESSEL.Name = "TxtENG_VESSEL"
        Me.TxtENG_VESSEL.TabIndex = 1
        Me.TxtENG_VESSEL.Text = ""
        '
        'TxtCHI_VESSEL
        '
        Me.TxtCHI_VESSEL.Location = New System.Drawing.Point(60, 24)
        Me.TxtCHI_VESSEL.Name = "TxtCHI_VESSEL"
        Me.TxtCHI_VESSEL.TabIndex = 2
        Me.TxtCHI_VESSEL.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "中文船名"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "呼号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtSIGN
        '
        Me.TxtSIGN.Location = New System.Drawing.Point(60, 46)
        Me.TxtSIGN.Name = "TxtSIGN"
        Me.TxtSIGN.TabIndex = 3
        Me.TxtSIGN.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(2, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "国籍"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(2, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "班轮标识"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(2, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "船舶类型"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(324, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "总吨"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtGROSS_TONS
        '
        Me.TxtGROSS_TONS.Location = New System.Drawing.Point(382, 2)
        Me.TxtGROSS_TONS.Name = "TxtGROSS_TONS"
        Me.TxtGROSS_TONS.TabIndex = 15
        Me.TxtGROSS_TONS.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(324, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "净吨"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTON_NET
        '
        Me.TxtTON_NET.Location = New System.Drawing.Point(382, 24)
        Me.TxtTON_NET.Name = "TxtTON_NET"
        Me.TxtTON_NET.TabIndex = 16
        Me.TxtTON_NET.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(324, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "包装容积"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(324, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "散装容积"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(2, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "船公司"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(162, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 20)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "舱口数"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(324, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 20)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "载重吨"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(162, 92)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 20)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "航速"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(324, 136)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 20)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "公分吨"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(162, 70)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 20)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "最大航速"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(162, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 20)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "最大吃水"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(324, 114)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 20)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "吊杆能力"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(162, 4)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(58, 20)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "船长"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(162, 26)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(58, 20)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "船宽"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTON_DEAD
        '
        Me.TxtTON_DEAD.Location = New System.Drawing.Point(382, 46)
        Me.TxtTON_DEAD.Name = "TxtTON_DEAD"
        Me.TxtTON_DEAD.TabIndex = 17
        Me.TxtTON_DEAD.Text = ""
        '
        'TxtTPC
        '
        Me.TxtTPC.Location = New System.Drawing.Point(382, 134)
        Me.TxtTPC.MaxLength = 11
        Me.TxtTPC.Name = "TxtTPC"
        Me.TxtTPC.TabIndex = 21
        Me.TxtTPC.Text = ""
        '
        'TxtBULKS
        '
        Me.TxtBULKS.Location = New System.Drawing.Point(382, 90)
        Me.TxtBULKS.Name = "TxtBULKS"
        Me.TxtBULKS.TabIndex = 19
        Me.TxtBULKS.Text = ""
        '
        'TxtBALE
        '
        Me.TxtBALE.Location = New System.Drawing.Point(382, 68)
        Me.TxtBALE.Name = "TxtBALE"
        Me.TxtBALE.TabIndex = 18
        Me.TxtBALE.Text = ""
        '
        'TxtPCTN_NUM
        '
        Me.TxtPCTN_NUM.Location = New System.Drawing.Point(221, 90)
        Me.TxtPCTN_NUM.Name = "TxtPCTN_NUM"
        Me.TxtPCTN_NUM.TabIndex = 12
        Me.TxtPCTN_NUM.Text = ""
        '
        'TxtOWNER_SHIP
        '
        Me.TxtOWNER_SHIP.Location = New System.Drawing.Point(60, 134)
        Me.TxtOWNER_SHIP.Name = "TxtOWNER_SHIP"
        Me.TxtOWNER_SHIP.TabIndex = 7
        Me.TxtOWNER_SHIP.Text = ""
        '
        'TxtHATCH
        '
        Me.TxtHATCH.Location = New System.Drawing.Point(221, 112)
        Me.TxtHATCH.Name = "TxtHATCH"
        Me.TxtHATCH.TabIndex = 13
        Me.TxtHATCH.Text = ""
        '
        'TxtDERRICK
        '
        Me.TxtDERRICK.Location = New System.Drawing.Point(382, 112)
        Me.TxtDERRICK.Name = "TxtDERRICK"
        Me.TxtDERRICK.TabIndex = 20
        Me.TxtDERRICK.Text = ""
        '
        'TxtLOA
        '
        Me.TxtLOA.Location = New System.Drawing.Point(221, 2)
        Me.TxtLOA.Name = "TxtLOA"
        Me.TxtLOA.TabIndex = 8
        Me.TxtLOA.Text = ""
        '
        'TxtBEAM
        '
        Me.TxtBEAM.Location = New System.Drawing.Point(221, 24)
        Me.TxtBEAM.Name = "TxtBEAM"
        Me.TxtBEAM.TabIndex = 9
        Me.TxtBEAM.Text = ""
        '
        'TxtVESSEL_DRAFT
        '
        Me.TxtVESSEL_DRAFT.Location = New System.Drawing.Point(221, 46)
        Me.TxtVESSEL_DRAFT.Name = "TxtVESSEL_DRAFT"
        Me.TxtVESSEL_DRAFT.TabIndex = 10
        Me.TxtVESSEL_DRAFT.Text = ""
        '
        'TxtSHIP_SPEED
        '
        Me.TxtSHIP_SPEED.Location = New System.Drawing.Point(221, 68)
        Me.TxtSHIP_SPEED.Name = "TxtSHIP_SPEED"
        Me.TxtSHIP_SPEED.TabIndex = 11
        Me.TxtSHIP_SPEED.Text = ""
        '
        'GB
        '
        Me.GB.Controls.AddRange(New System.Windows.Forms.Control() {Me.C1DBG})
        Me.GB.Location = New System.Drawing.Point(2, 157)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(480, 142)
        Me.GB.TabIndex = 22
        Me.GB.TabStop = False
        Me.GB.Text = "分舱规范"
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = True
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1DBG.AllowSort = True
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.CollapseColor = System.Drawing.Color.Black
        Me.C1DBG.DataChanged = False
        Me.C1DBG.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBG.ExpandColor = System.Drawing.Color.Black
        Me.C1DBG.FetchRowStyles = True
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1DBG.Location = New System.Drawing.Point(4, 18)
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
        Me.C1DBG.Size = New System.Drawing.Size(474, 122)
        Me.C1DBG.TabIndex = 0
        Me.C1DBG.PropBag = CType(resources.GetObject("C1DBG.PropBag"), String)
        '
        'TxtVessel_ID
        '
        Me.TxtVessel_ID.Location = New System.Drawing.Point(14, 304)
        Me.TxtVessel_ID.Name = "TxtVessel_ID"
        Me.TxtVessel_ID.ReadOnly = True
        Me.TxtVessel_ID.Size = New System.Drawing.Size(26, 21)
        Me.TxtVessel_ID.TabIndex = 25
        Me.TxtVessel_ID.Text = ""
        Me.TxtVessel_ID.Visible = False
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(209, 306)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(65, 24)
        Me.btnQuit.TabIndex = 0
        Me.btnQuit.Text = "返回"
        '
        'TxtLINER_ID
        '
        Me.TxtLINER_ID.Location = New System.Drawing.Point(60, 90)
        Me.TxtLINER_ID.Name = "TxtLINER_ID"
        Me.TxtLINER_ID.Size = New System.Drawing.Size(100, 20)
        Me.TxtLINER_ID.TabIndex = 5
        '
        'TxtNATIONALITY_CODE
        '
        Me.TxtNATIONALITY_CODE.Location = New System.Drawing.Point(60, 68)
        Me.TxtNATIONALITY_CODE.Name = "TxtNATIONALITY_CODE"
        Me.TxtNATIONALITY_CODE.Size = New System.Drawing.Size(100, 20)
        Me.TxtNATIONALITY_CODE.TabIndex = 4
        '
        'TxtVESSEL_TYPE
        '
        Me.TxtVESSEL_TYPE.Location = New System.Drawing.Point(60, 112)
        Me.TxtVESSEL_TYPE.Name = "TxtVESSEL_TYPE"
        Me.TxtVESSEL_TYPE.Size = New System.Drawing.Size(100, 20)
        Me.TxtVESSEL_TYPE.TabIndex = 6
        '
        'TxtVESSEL_IMO
        '
        Me.TxtVESSEL_IMO.Location = New System.Drawing.Point(221, 134)
        Me.TxtVESSEL_IMO.MaxLength = 9
        Me.TxtVESSEL_IMO.Name = "TxtVESSEL_IMO"
        Me.TxtVESSEL_IMO.TabIndex = 118
        Me.TxtVESSEL_IMO.Text = ""
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(162, 136)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 20)
        Me.Label20.TabIndex = 117
        Me.Label20.Text = "船码"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmVessel_Papers_Query
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(482, 335)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TxtVESSEL_IMO, Me.Label20, Me.TxtLINER_ID, Me.TxtNATIONALITY_CODE, Me.TxtVESSEL_TYPE, Me.TxtVessel_ID, Me.GB, Me.TxtDERRICK, Me.TxtLOA, Me.TxtBEAM, Me.TxtVESSEL_DRAFT, Me.TxtSHIP_SPEED, Me.TxtTON_DEAD, Me.TxtTPC, Me.TxtBULKS, Me.TxtBALE, Me.TxtPCTN_NUM, Me.TxtOWNER_SHIP, Me.TxtHATCH, Me.btnQuit, Me.TxtENG_VESSEL, Me.Label1, Me.TxtCHI_VESSEL, Me.Label2, Me.Label3, Me.TxtSIGN, Me.Label4, Me.Label5, Me.Label6, Me.Label7, Me.TxtGROSS_TONS, Me.Label8, Me.TxtTON_NET, Me.Label9, Me.Label10, Me.Label11, Me.Label13, Me.Label14, Me.Label15, Me.Label16, Me.Label17, Me.Label18, Me.Label19, Me.Label23, Me.Label24})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmVessel_Papers_Query"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "船舶规范_查看"
        Me.GB.ResumeLayout(False)
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmVessel_Papers_Query_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Dim str As String
        Dim i As Integer
        Dim sqla As New SqlClient.SqlDataAdapter()
        Dim sqlc As New SqlClient.SqlCommand()
        Dim dsCabin As New DataSet()
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
            'TxtBUILED_DATE.Text = ds.Tables(0).Rows(0).Item("BUILED_DATE")
            TxtGROSS_TONS.Text = ds.Tables(0).Rows(0).Item("GROSS_TONS")
            TxtTON_NET.Text = ds.Tables(0).Rows(0).Item("TON_NET")
            TxtTON_DEAD.Text = ds.Tables(0).Rows(0).Item("TON_DEAD")
            TxtBALE.Text = ds.Tables(0).Rows(0).Item("BALE")
            TxtBULKS.Text = ds.Tables(0).Rows(0).Item("BULKS")
            TxtDERRICK.Text = ds.Tables(0).Rows(0).Item("DERRICK")
            TxtTPC.Text = ds.Tables(0).Rows(0).Item("TPC")
            TxtVESSEL_IMO.Text = ds.Tables(0).Rows(0).Item("Vessel_Code")

            str = "select * from VESSEL_HATCH where V_ID=" & CType(Trim(TxtVessel_ID.Text), Int32)
            ds_sub.Reset()
            dw = Updatedata(sqlda_sub, str, ds_sub)
            Me.C1DBG.DataSource = dw
            Me.C1DBG.Refresh()

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
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                vi.DisplayValue = Trim(dsCabin.Tables(0).Rows(i)("DESCR"))
                vi.Value = Trim(dsCabin.Tables(0).Rows(i)("Value"))
                Me.C1DBG.Columns.Item(5).ValueItems.Values.Add(vi)
            Next

            Me.C1DBG.Refresh()

        End If
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

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub TxtENG_VESSEL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtENG_VESSEL.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            btnQuit.Focus()
        End If
    End Sub

    Private Sub TxtCHI_VESSEL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCHI_VESSEL.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            btnQuit.Focus()
        End If
    End Sub

    Private Sub TxtSIGN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSIGN.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            btnQuit.Focus()
        End If
    End Sub

    'Private Sub TxtNATIONALITY_CODE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNATIONALITY_CODE.KeyDown
    '    If e.KeyCode = Keys.Escape Then
    '        Me.Close()
    '    End If
    '    If e.KeyCode = Keys.Enter Then
    '        btnQuit.Focus()
    '    End If
    'End Sub

    'Private Sub TxtLINER_ID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtLINER_ID.KeyDown
    '    If e.KeyCode = Keys.Escape Then
    '        Me.Close()
    '    End If
    '    If e.KeyCode = Keys.Enter Then
    '        btnQuit.Focus()
    '    End If
    'End Sub

    'Private Sub TxtVESSEL_TYPE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtVESSEL_TYPE.KeyDown
    '    If e.KeyCode = Keys.Escape Then
    '        Me.Close()
    '    End If
    '    If e.KeyCode = Keys.Enter Then
    '        btnQuit.Focus()
    '    End If
    'End Sub

    Private Sub TxtOWNER_SHIP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtOWNER_SHIP.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            btnQuit.Focus()
        End If
    End Sub

    Private Sub TxtLOA_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtLOA.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            btnQuit.Focus()
        End If
    End Sub

    Private Sub TxtBEAM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBEAM.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            btnQuit.Focus()
        End If
    End Sub

    Private Sub TxtVESSEL_DRAFT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtVESSEL_DRAFT.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            btnQuit.Focus()
        End If
    End Sub

    Private Sub TxtSHIP_SPEED_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSHIP_SPEED.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            btnQuit.Focus()
        End If
    End Sub

    Private Sub TxtPCTN_NUM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPCTN_NUM.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            btnQuit.Focus()
        End If
    End Sub

    Private Sub TxtHATCH_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtHATCH.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            btnQuit.Focus()
        End If
    End Sub

    Private Sub TxtBUILED_DATE_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            btnQuit.Focus()
        End If
    End Sub

    Private Sub TxtGROSS_TONS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtGROSS_TONS.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            btnQuit.Focus()
        End If
    End Sub

    Private Sub TxtTON_NET_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTON_NET.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            btnQuit.Focus()
        End If
    End Sub

    Private Sub TxtTON_DEAD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTON_DEAD.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            btnQuit.Focus()
        End If
    End Sub

    Private Sub TxtBALE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBALE.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            btnQuit.Focus()
        End If
    End Sub

    Private Sub TxtBULKS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBULKS.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            btnQuit.Focus()
        End If
    End Sub

    Private Sub TxtDERRICK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDERRICK.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            btnQuit.Focus()
        End If
    End Sub

    Private Sub TxtTPC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTPC.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            btnQuit.Focus()
        End If
    End Sub

    Private Sub btnQuit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnQuit.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
