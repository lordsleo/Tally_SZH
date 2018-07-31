Imports TALLY.DBControl
Public Class FrmCargo_hatch_list_new_edit
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter
    Dim ds_sub As New DataSet
    Dim sqlda_sub As New SqlClient.SqlDataAdapter
    Dim dw As New DataView
    Dim dsport1 As New DataSet
    Dim dsport2 As New DataSet
    Dim dsgoods As New DataSet
    Dim dscgood As New DataSet
    Dim dspack As New DataSet
    Public Shared AddFlag As Boolean
    Dim cargoid, acc, ntp As String
    Dim dstmp As New DataSet

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
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtBLNO As System.Windows.Forms.TextBox
    Friend WithEvents CombLOAD_PORT As System.Windows.Forms.ComboBox
    Friend WithEvents CombUNLOAD_PORT As System.Windows.Forms.ComboBox
    Friend WithEvents TxtMARK As System.Windows.Forms.TextBox
    Friend WithEvents TxtNETWEIGHT As System.Windows.Forms.TextBox
    Friend WithEvents TxtGROSS_WEIGHT As System.Windows.Forms.TextBox
    Friend WithEvents TxtSIZE_MEASURE As System.Windows.Forms.TextBox
    Friend WithEvents TxtTONS As System.Windows.Forms.TextBox
    Friend WithEvents TxtSENDER As System.Windows.Forms.TextBox
    Friend WithEvents TxtNOTIFY_PERSON As System.Windows.Forms.TextBox
    Friend WithEvents TxtRECEIVER As System.Windows.Forms.TextBox
    Friend WithEvents TxtAMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents TxtGOODS_ENG As System.Windows.Forms.TextBox
    Friend WithEvents TxtGOODS_CHA As System.Windows.Forms.TextBox
    Friend WithEvents BTOK As System.Windows.Forms.Button
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents combcode_goods As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CombCode_pack As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TxtPIECE_WEIGHT As System.Windows.Forms.TextBox
    Friend WithEvents CBACCESSORY As System.Windows.Forms.CheckBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cbCargo As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtLoadPortCha As System.Windows.Forms.TextBox
    Friend WithEvents txtLoadPortEng As System.Windows.Forms.TextBox
    Friend WithEvents txtUnLoadPortCha As System.Windows.Forms.TextBox
    Friend WithEvents txtUnLoadPortEng As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents C1dbg As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents TxtGROSS_WEIGHT_ori As System.Windows.Forms.TextBox
    Friend WithEvents TxtSIZE_MEASURE_ori As System.Windows.Forms.TextBox
    Friend WithEvents TxtAMOUNT_ori As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents ComboHB As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCargo_hatch_list_new_edit))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtBLNO = New System.Windows.Forms.TextBox
        Me.TxtMARK = New System.Windows.Forms.TextBox
        Me.TxtNETWEIGHT = New System.Windows.Forms.TextBox
        Me.TxtGROSS_WEIGHT = New System.Windows.Forms.TextBox
        Me.TxtSIZE_MEASURE = New System.Windows.Forms.TextBox
        Me.TxtTONS = New System.Windows.Forms.TextBox
        Me.TxtSENDER = New System.Windows.Forms.TextBox
        Me.TxtNOTIFY_PERSON = New System.Windows.Forms.TextBox
        Me.TxtRECEIVER = New System.Windows.Forms.TextBox
        Me.TxtAMOUNT = New System.Windows.Forms.TextBox
        Me.TxtGOODS_ENG = New System.Windows.Forms.TextBox
        Me.TxtGOODS_CHA = New System.Windows.Forms.TextBox
        Me.CombLOAD_PORT = New System.Windows.Forms.ComboBox
        Me.CombUNLOAD_PORT = New System.Windows.Forms.ComboBox
        Me.BTOK = New System.Windows.Forms.Button
        Me.BTQUIT = New System.Windows.Forms.Button
        Me.combcode_goods = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.CombCode_pack = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.TxtPIECE_WEIGHT = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.CBACCESSORY = New System.Windows.Forms.CheckBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.cbCargo = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtLoadPortCha = New System.Windows.Forms.TextBox
        Me.txtLoadPortEng = New System.Windows.Forms.TextBox
        Me.txtUnLoadPortCha = New System.Windows.Forms.TextBox
        Me.txtUnLoadPortEng = New System.Windows.Forms.TextBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.C1dbg = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Button1 = New System.Windows.Forms.Button
        Me.TxtGROSS_WEIGHT_ori = New System.Windows.Forms.TextBox
        Me.TxtSIZE_MEASURE_ori = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.TxtAMOUNT_ori = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.ComboHB = New System.Windows.Forms.ComboBox
        CType(Me.C1dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(18, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "提单/装单号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(76, 502)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "净重"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(18, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "实装重量"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(18, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "实装体积"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(76, 554)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "衡重"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(434, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "发货人"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(76, 582)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "通知方"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(434, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "收货人"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(436, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 20)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "装货港"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(436, 92)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 20)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "卸货港"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(392, 482)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 20)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "标志"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label14.Visible = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(18, 36)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 20)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "实装件数"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(76, 478)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 20)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "计费货类名称"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label16.Visible = False
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(392, 538)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 20)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "货物英文描述"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label17.Visible = False
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(392, 566)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 20)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "货物中文描述"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label18.Visible = False
        '
        'txtBLNO
        '
        Me.txtBLNO.Enabled = False
        Me.txtBLNO.Location = New System.Drawing.Point(102, 8)
        Me.txtBLNO.MaxLength = 20
        Me.txtBLNO.Name = "txtBLNO"
        Me.txtBLNO.Size = New System.Drawing.Size(198, 21)
        Me.txtBLNO.TabIndex = 18
        '
        'TxtMARK
        '
        Me.TxtMARK.Location = New System.Drawing.Point(476, 482)
        Me.TxtMARK.MaxLength = 30
        Me.TxtMARK.Name = "TxtMARK"
        Me.TxtMARK.Size = New System.Drawing.Size(78, 21)
        Me.TxtMARK.TabIndex = 19
        Me.TxtMARK.Visible = False
        '
        'TxtNETWEIGHT
        '
        Me.TxtNETWEIGHT.Location = New System.Drawing.Point(164, 500)
        Me.TxtNETWEIGHT.Name = "TxtNETWEIGHT"
        Me.TxtNETWEIGHT.Size = New System.Drawing.Size(168, 21)
        Me.TxtNETWEIGHT.TabIndex = 20
        Me.TxtNETWEIGHT.Visible = False
        '
        'TxtGROSS_WEIGHT
        '
        Me.TxtGROSS_WEIGHT.Location = New System.Drawing.Point(102, 62)
        Me.TxtGROSS_WEIGHT.Name = "TxtGROSS_WEIGHT"
        Me.TxtGROSS_WEIGHT.Size = New System.Drawing.Size(168, 21)
        Me.TxtGROSS_WEIGHT.TabIndex = 21
        '
        'TxtSIZE_MEASURE
        '
        Me.TxtSIZE_MEASURE.Location = New System.Drawing.Point(102, 90)
        Me.TxtSIZE_MEASURE.Name = "TxtSIZE_MEASURE"
        Me.TxtSIZE_MEASURE.Size = New System.Drawing.Size(156, 21)
        Me.TxtSIZE_MEASURE.TabIndex = 22
        '
        'TxtTONS
        '
        Me.TxtTONS.Location = New System.Drawing.Point(164, 554)
        Me.TxtTONS.Name = "TxtTONS"
        Me.TxtTONS.Size = New System.Drawing.Size(168, 21)
        Me.TxtTONS.TabIndex = 23
        Me.TxtTONS.Visible = False
        '
        'TxtSENDER
        '
        Me.TxtSENDER.Location = New System.Drawing.Point(518, 172)
        Me.TxtSENDER.MaxLength = 30
        Me.TxtSENDER.Name = "TxtSENDER"
        Me.TxtSENDER.Size = New System.Drawing.Size(186, 21)
        Me.TxtSENDER.TabIndex = 24
        '
        'TxtNOTIFY_PERSON
        '
        Me.TxtNOTIFY_PERSON.Location = New System.Drawing.Point(164, 582)
        Me.TxtNOTIFY_PERSON.MaxLength = 30
        Me.TxtNOTIFY_PERSON.Name = "TxtNOTIFY_PERSON"
        Me.TxtNOTIFY_PERSON.Size = New System.Drawing.Size(186, 21)
        Me.TxtNOTIFY_PERSON.TabIndex = 25
        Me.TxtNOTIFY_PERSON.Visible = False
        '
        'TxtRECEIVER
        '
        Me.TxtRECEIVER.Location = New System.Drawing.Point(518, 198)
        Me.TxtRECEIVER.MaxLength = 30
        Me.TxtRECEIVER.Name = "TxtRECEIVER"
        Me.TxtRECEIVER.Size = New System.Drawing.Size(186, 21)
        Me.TxtRECEIVER.TabIndex = 26
        '
        'TxtAMOUNT
        '
        Me.TxtAMOUNT.Location = New System.Drawing.Point(102, 36)
        Me.TxtAMOUNT.Name = "TxtAMOUNT"
        Me.TxtAMOUNT.Size = New System.Drawing.Size(198, 21)
        Me.TxtAMOUNT.TabIndex = 27
        '
        'TxtGOODS_ENG
        '
        Me.TxtGOODS_ENG.Location = New System.Drawing.Point(476, 538)
        Me.TxtGOODS_ENG.MaxLength = 30
        Me.TxtGOODS_ENG.Name = "TxtGOODS_ENG"
        Me.TxtGOODS_ENG.Size = New System.Drawing.Size(78, 21)
        Me.TxtGOODS_ENG.TabIndex = 29
        Me.TxtGOODS_ENG.Visible = False
        '
        'TxtGOODS_CHA
        '
        Me.TxtGOODS_CHA.Location = New System.Drawing.Point(476, 564)
        Me.TxtGOODS_CHA.MaxLength = 30
        Me.TxtGOODS_CHA.Name = "TxtGOODS_CHA"
        Me.TxtGOODS_CHA.Size = New System.Drawing.Size(78, 21)
        Me.TxtGOODS_CHA.TabIndex = 30
        Me.TxtGOODS_CHA.Visible = False
        '
        'CombLOAD_PORT
        '
        Me.CombLOAD_PORT.Location = New System.Drawing.Point(518, 10)
        Me.CombLOAD_PORT.Name = "CombLOAD_PORT"
        Me.CombLOAD_PORT.Size = New System.Drawing.Size(186, 20)
        Me.CombLOAD_PORT.TabIndex = 33
        '
        'CombUNLOAD_PORT
        '
        Me.CombUNLOAD_PORT.Location = New System.Drawing.Point(518, 92)
        Me.CombUNLOAD_PORT.Name = "CombUNLOAD_PORT"
        Me.CombUNLOAD_PORT.Size = New System.Drawing.Size(186, 20)
        Me.CombUNLOAD_PORT.TabIndex = 34
        '
        'BTOK
        '
        Me.BTOK.BackColor = System.Drawing.Color.Transparent
        Me.BTOK.Location = New System.Drawing.Point(289, 246)
        Me.BTOK.Name = "BTOK"
        Me.BTOK.Size = New System.Drawing.Size(65, 24)
        Me.BTOK.TabIndex = 36
        Me.BTOK.Text = "确认"
        Me.BTOK.UseVisualStyleBackColor = False
        '
        'BTQUIT
        '
        Me.BTQUIT.BackColor = System.Drawing.Color.Transparent
        Me.BTQUIT.Location = New System.Drawing.Point(381, 246)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 37
        Me.BTQUIT.Text = "取消"
        Me.BTQUIT.UseVisualStyleBackColor = False
        '
        'combcode_goods
        '
        Me.combcode_goods.Location = New System.Drawing.Point(164, 478)
        Me.combcode_goods.Name = "combcode_goods"
        Me.combcode_goods.Size = New System.Drawing.Size(186, 20)
        Me.combcode_goods.TabIndex = 39
        Me.combcode_goods.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(394, 594)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 20)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "包装"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Visible = False
        '
        'CombCode_pack
        '
        Me.CombCode_pack.Location = New System.Drawing.Point(478, 594)
        Me.CombCode_pack.Name = "CombCode_pack"
        Me.CombCode_pack.Size = New System.Drawing.Size(78, 20)
        Me.CombCode_pack.TabIndex = 41
        Me.CombCode_pack.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(332, 500)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 22)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "公斤"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label10.Visible = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.Location = New System.Drawing.Point(270, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 22)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "公斤"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label19.Location = New System.Drawing.Point(332, 554)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 22)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "公斤"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label19.Visible = False
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label20.Location = New System.Drawing.Point(260, 90)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 22)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "立方米"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtPIECE_WEIGHT
        '
        Me.TxtPIECE_WEIGHT.Enabled = False
        Me.TxtPIECE_WEIGHT.Location = New System.Drawing.Point(164, 526)
        Me.TxtPIECE_WEIGHT.Name = "TxtPIECE_WEIGHT"
        Me.TxtPIECE_WEIGHT.Size = New System.Drawing.Size(112, 21)
        Me.TxtPIECE_WEIGHT.TabIndex = 47
        Me.TxtPIECE_WEIGHT.Visible = False
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(76, 526)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 24)
        Me.Label21.TabIndex = 46
        Me.Label21.Text = "件重"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label21.Visible = False
        '
        'CBACCESSORY
        '
        Me.CBACCESSORY.BackColor = System.Drawing.Color.Transparent
        Me.CBACCESSORY.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CBACCESSORY.Location = New System.Drawing.Point(625, 228)
        Me.CBACCESSORY.Name = "CBACCESSORY"
        Me.CBACCESSORY.Size = New System.Drawing.Size(88, 24)
        Me.CBACCESSORY.TabIndex = 48
        Me.CBACCESSORY.Text = "是否附件"
        Me.CBACCESSORY.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label22.Location = New System.Drawing.Point(276, 526)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(30, 22)
        Me.Label22.TabIndex = 49
        Me.Label22.Text = "公斤"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label22.Visible = False
        '
        'cbCargo
        '
        Me.cbCargo.Location = New System.Drawing.Point(476, 512)
        Me.cbCargo.Name = "cbCargo"
        Me.cbCargo.Size = New System.Drawing.Size(78, 20)
        Me.cbCargo.TabIndex = 51
        Me.cbCargo.Visible = False
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Location = New System.Drawing.Point(392, 512)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 20)
        Me.Label23.TabIndex = 50
        Me.Label23.Text = "货物代码名称"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label23.Visible = False
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(436, 36)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label24.Size = New System.Drawing.Size(80, 20)
        Me.Label24.TabIndex = 52
        Me.Label24.Text = "装货港中文名"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(436, 66)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label25.Size = New System.Drawing.Size(80, 20)
        Me.Label25.TabIndex = 53
        Me.Label25.Text = "装货港英文名"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Location = New System.Drawing.Point(436, 120)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label26.Size = New System.Drawing.Size(80, 20)
        Me.Label26.TabIndex = 54
        Me.Label26.Text = "卸货港中文名"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Location = New System.Drawing.Point(436, 148)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label27.Size = New System.Drawing.Size(80, 20)
        Me.Label27.TabIndex = 55
        Me.Label27.Text = "卸货港英文名"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLoadPortCha
        '
        Me.txtLoadPortCha.Location = New System.Drawing.Point(518, 36)
        Me.txtLoadPortCha.Name = "txtLoadPortCha"
        Me.txtLoadPortCha.Size = New System.Drawing.Size(186, 21)
        Me.txtLoadPortCha.TabIndex = 56
        '
        'txtLoadPortEng
        '
        Me.txtLoadPortEng.Location = New System.Drawing.Point(518, 64)
        Me.txtLoadPortEng.Name = "txtLoadPortEng"
        Me.txtLoadPortEng.Size = New System.Drawing.Size(186, 21)
        Me.txtLoadPortEng.TabIndex = 57
        '
        'txtUnLoadPortCha
        '
        Me.txtUnLoadPortCha.Location = New System.Drawing.Point(518, 118)
        Me.txtUnLoadPortCha.Name = "txtUnLoadPortCha"
        Me.txtUnLoadPortCha.Size = New System.Drawing.Size(186, 21)
        Me.txtUnLoadPortCha.TabIndex = 58
        '
        'txtUnLoadPortEng
        '
        Me.txtUnLoadPortEng.Location = New System.Drawing.Point(518, 146)
        Me.txtUnLoadPortEng.Name = "txtUnLoadPortEng"
        Me.txtUnLoadPortEng.Size = New System.Drawing.Size(186, 21)
        Me.txtUnLoadPortEng.TabIndex = 59
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(518, 228)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(101, 24)
        Me.CheckBox1.TabIndex = 48
        Me.CheckBox1.Text = "非本港舱单"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'C1dbg
        '
        Me.C1dbg.AllowAddNew = True
        Me.C1dbg.AllowDelete = True
        Me.C1dbg.Enabled = False
        Me.C1dbg.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1dbg.Images.Add(CType(resources.GetObject("C1dbg.Images"), System.Drawing.Image))
        Me.C1dbg.Location = New System.Drawing.Point(2, 274)
        Me.C1dbg.Name = "C1dbg"
        Me.C1dbg.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1dbg.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1dbg.PreviewInfo.ZoomFactor = 75
        Me.C1dbg.PrintInfo.PageSettings = CType(resources.GetObject("C1dbg.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1dbg.Size = New System.Drawing.Size(730, 142)
        Me.C1dbg.TabIndex = 60
        Me.C1dbg.Text = "C1TrueDBGrid1"
        Me.C1dbg.PropBag = resources.GetString("C1dbg.PropBag")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(335, 422)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 24)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "确认"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TxtGROSS_WEIGHT_ori
        '
        Me.TxtGROSS_WEIGHT_ori.Location = New System.Drawing.Point(102, 146)
        Me.TxtGROSS_WEIGHT_ori.Name = "TxtGROSS_WEIGHT_ori"
        Me.TxtGROSS_WEIGHT_ori.Size = New System.Drawing.Size(168, 21)
        Me.TxtGROSS_WEIGHT_ori.TabIndex = 21
        '
        'TxtSIZE_MEASURE_ori
        '
        Me.TxtSIZE_MEASURE_ori.Location = New System.Drawing.Point(102, 172)
        Me.TxtSIZE_MEASURE_ori.Name = "TxtSIZE_MEASURE_ori"
        Me.TxtSIZE_MEASURE_ori.Size = New System.Drawing.Size(156, 21)
        Me.TxtSIZE_MEASURE_ori.TabIndex = 22
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(16, 173)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(80, 20)
        Me.Label28.TabIndex = 3
        Me.Label28.Text = "原装体积"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(16, 119)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(80, 20)
        Me.Label29.TabIndex = 14
        Me.Label29.Text = "原装件数"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label30.Location = New System.Drawing.Point(268, 145)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(30, 22)
        Me.Label30.TabIndex = 43
        Me.Label30.Text = "公斤"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label31.Location = New System.Drawing.Point(258, 171)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(42, 22)
        Me.Label31.TabIndex = 45
        Me.Label31.Text = "立方米"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Location = New System.Drawing.Point(16, 147)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(80, 20)
        Me.Label32.TabIndex = 2
        Me.Label32.Text = "原装重量"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtAMOUNT_ori
        '
        Me.TxtAMOUNT_ori.Location = New System.Drawing.Point(102, 118)
        Me.TxtAMOUNT_ori.Name = "TxtAMOUNT_ori"
        Me.TxtAMOUNT_ori.Size = New System.Drawing.Size(198, 21)
        Me.TxtAMOUNT_ori.TabIndex = 27
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Location = New System.Drawing.Point(16, 200)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(80, 20)
        Me.Label33.TabIndex = 61
        Me.Label33.Text = "合并方式"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboHB
        '
        Me.ComboHB.Items.AddRange(New Object() {"不合并", "只合并重量", "合并件数和重量"})
        Me.ComboHB.Location = New System.Drawing.Point(102, 200)
        Me.ComboHB.Name = "ComboHB"
        Me.ComboHB.Size = New System.Drawing.Size(198, 20)
        Me.ComboHB.TabIndex = 62
        '
        'FrmCargo_hatch_list_new_edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(734, 451)
        Me.Controls.Add(Me.ComboHB)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.C1dbg)
        Me.Controls.Add(Me.txtUnLoadPortEng)
        Me.Controls.Add(Me.txtUnLoadPortCha)
        Me.Controls.Add(Me.txtLoadPortEng)
        Me.Controls.Add(Me.txtLoadPortCha)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.cbCargo)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.CBACCESSORY)
        Me.Controls.Add(Me.TxtPIECE_WEIGHT)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CombCode_pack)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.combcode_goods)
        Me.Controls.Add(Me.BTQUIT)
        Me.Controls.Add(Me.BTOK)
        Me.Controls.Add(Me.CombUNLOAD_PORT)
        Me.Controls.Add(Me.CombLOAD_PORT)
        Me.Controls.Add(Me.TxtGOODS_CHA)
        Me.Controls.Add(Me.TxtGOODS_ENG)
        Me.Controls.Add(Me.TxtAMOUNT)
        Me.Controls.Add(Me.TxtRECEIVER)
        Me.Controls.Add(Me.TxtNOTIFY_PERSON)
        Me.Controls.Add(Me.TxtSENDER)
        Me.Controls.Add(Me.TxtTONS)
        Me.Controls.Add(Me.TxtSIZE_MEASURE)
        Me.Controls.Add(Me.TxtGROSS_WEIGHT)
        Me.Controls.Add(Me.TxtNETWEIGHT)
        Me.Controls.Add(Me.TxtMARK)
        Me.Controls.Add(Me.txtBLNO)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtGROSS_WEIGHT_ori)
        Me.Controls.Add(Me.TxtSIZE_MEASURE_ori)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.TxtAMOUNT_ori)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargo_hatch_list_new_edit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "件杂货进口舱单_编辑"
        CType(Me.C1dbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub FrmCargo_hatch_list_new_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim sqlstr As String
        If Hatch_in = 0 Then
            Me.Text = "件杂货进口舱单_编辑"       '唛头
        ElseIf Hatch_in = 1 Then
            Me.Text = "件杂货出口装货单_编辑"
        End If

        dw = Getdata("select isnull(PORT_ENG,' ') as port,CODE_PORT from code_port order by port ", dsport1)
        CombLOAD_PORT.DataSource = dsport1.Tables(0).DefaultView
        CombLOAD_PORT.DisplayMember = "port"
        CombLOAD_PORT.ValueMember = "CODE_PORT"

        dw = Getdata("select isnull(PORT_ENG,' ') as port,CODE_PORT from code_port order by port ", dsport2)
        CombUNLOAD_PORT.DataSource = dsport2.Tables(0).DefaultView
        CombUNLOAD_PORT.DisplayMember = "port"
        CombUNLOAD_PORT.ValueMember = "CODE_PORT"

        'dw = Getdata("select PORT_CHA+' '+isnull(PORT_ENG,' ') as port,CODE_PORT from code_port order by port ", dsport1)
        'CombLOAD_PORT.DataSource = dsport1.Tables(0).DefaultView
        'CombLOAD_PORT.DisplayMember = "port"
        'CombLOAD_PORT.ValueMember = "CODE_PORT"

        'dw = Getdata("select PORT_CHA+' '+isnull(PORT_ENG,' ') as port,CODE_PORT from code_port order by port ", dsport2)
        'CombUNLOAD_PORT.DataSource = dsport2.Tables(0).DefaultView
        'CombUNLOAD_PORT.DisplayMember = "port"
        'CombUNLOAD_PORT.ValueMember = "CODE_PORT"

        dw = Getdata("select CODE_GOODS,GOODS_CHA as goods from code_cargo order by code_goods ", dsgoods)
        combcode_goods.DataSource = dsgoods.Tables(0).DefaultView
        combcode_goods.DisplayMember = "goods"
        combcode_goods.ValueMember = "CODE_GOODS"

        dw = Getdata("select CODE,GOODS+' '+Goods_Eng as GOODS from codegoods where Flag_Dept=1 and Flag_Type=1 order by Flag_Px ", dscgood)
        cbCargo.DataSource = dscgood.Tables(0).DefaultView
        cbCargo.DisplayMember = "GOODS"
        cbCargo.ValueMember = "CODE"

        dw = Getdata("select code_pack,pack_cha+' '+isnull(pack_eng,' ') as pack from code_pack order by px ", dspack)
        CombCode_pack.DataSource = dspack.Tables(0).DefaultView
        CombCode_pack.DisplayMember = "pack"
        CombCode_pack.ValueMember = "code_pack"

        sqlstr = "select * from CARGO_HATCH_new where ID=" & ID
        dw = Updatedata(sqlda, sqlstr, ds)
        If ds.Tables(0).DefaultView.Count > 0 Then
            txtBLNO.Text = ds.Tables(0).Rows(0).Item("blno")
            TxtAMOUNT.Text = ds.Tables(0).Rows(0).Item("AMOUNT")
            TxtGROSS_WEIGHT.Text = ds.Tables(0).Rows(0).Item("TONS")
            TxtSIZE_MEASURE.Text = ds.Tables(0).Rows(0).Item("SIZE_MEASURE")
            TxtAMOUNT_ori.Text = ds.Tables(0).Rows(0).Item("AMOUNT_ORI")
            TxtGROSS_WEIGHT_ori.Text = ds.Tables(0).Rows(0).Item("TONS_ORI")
            TxtSIZE_MEASURE_ori.Text = ds.Tables(0).Rows(0).Item("MEASURE_ORI")

            TxtSENDER.Text = ds.Tables(0).Rows(0).Item("SENDER")
            TxtRECEIVER.Text = ds.Tables(0).Rows(0).Item("RECEIVER")
            CombCode_pack.SelectedValue = ds.Tables(0).Rows(0).Item("code_pack")
            CombLOAD_PORT.SelectedValue = ds.Tables(0).Rows(0).Item("load_port")
            CombUNLOAD_PORT.SelectedValue = ds.Tables(0).Rows(0).Item("unload_port")
            txtUnLoadPortCha.Text = ds.Tables(0).Rows(0).Item("unload_port_cha")
            txtUnLoadPortEng.Text = ds.Tables(0).Rows(0).Item("unload_port_eng")
            txtLoadPortCha.Text = ds.Tables(0).Rows(0).Item("load_port_cha")
            txtLoadPortEng.Text = ds.Tables(0).Rows(0).Item("load_port_eng")

            If CStr(ds.Tables(0).Rows(0).Item("MERGEMode")).Substring(0, 1) = "1" Then
                ComboHB.Text = "不合并"
            ElseIf CStr(ds.Tables(0).Rows(0).Item("MERGEMode")).Substring(0, 1) = "2" Then
                ComboHB.Text = "只合并重量"
            ElseIf CStr(ds.Tables(0).Rows(0).Item("MERGEMode")).Substring(0, 1) = "3" Then
                ComboHB.Text = "合并件数和重量"
            End If

            'If ds.Tables(0).Rows(0).Item("ACCESSORY") = "1" Then
            '    CBACCESSORY.Checked = True
            'Else
            '    CBACCESSORY.Checked = False
            'End If
        End If
        If mark = "1" Then      '溢卸，增加非本港舱单
            TxtAMOUNT.Text = 0
            TxtNETWEIGHT.Text = 0
            TxtGROSS_WEIGHT.Text = 0
            TxtPIECE_WEIGHT.Enabled = True
            TxtPIECE_WEIGHT.Visible = True
            Label22.Visible = True
            Label21.Visible = True
            TxtAMOUNT.Enabled = False
            TxtNETWEIGHT.Enabled = False
            TxtGROSS_WEIGHT.Enabled = False
            Label4.Text = "件体积"
        End If

        If Hatch_in = 0 Then
            CombUNLOAD_PORT.SelectedValue = "CNLYG"
            txtUnLoadPortCha.Text = "连云港"
            txtUnLoadPortEng.Text = "LIANYUNGANG"
        ElseIf Hatch_in = 1 Then
            CombLOAD_PORT.SelectedValue = "CNLYG"
            txtLoadPortCha.Text = "连云港"
            txtLoadPortEng.Text = "LIANYUNGANG"
        End If

        '新舱单子表信息
        dw = Updatedata(sqlda_sub, "SELECT ID, MID, BLNO, CODE_GOODS, GOODS_CHA, GOODS_ENG, MARK, CODE_PACK, AMOUNT, WEIGHT, VOLUMN, ACCESSORY, Code_Cargo, MARK_NON, USER_NAME, AMOUNT_ori, WEIGHT_ori, VOLUMN_ori FROM CARGO_HATCH_new_DETAIL where mid=" & ID, ds_sub) '1>2 ", ds_sub)  '
        Me.C1dbg.DataSource = ds_sub.Tables(0).DefaultView
        Me.C1dbg.Splits(0).DisplayColumns.Item("ID").Visible = False
        Me.C1dbg.Splits(0).DisplayColumns.Item("MID").Visible = False
        'Me.C1dbg.Splits(0).DisplayColumns.Item("GOODS_CHA").Visible = False
        'Me.C1dbg.Splits(0).DisplayColumns.Item("goods_eng").Visible = False
        Me.C1dbg.Splits(0).DisplayColumns.Item("Code_Cargo").Visible = False
        Me.C1dbg.Splits(0).DisplayColumns.Item("ACCESSORY").Visible = False
        Me.C1dbg.Splits(0).DisplayColumns.Item("MARK_NON").Visible = False
        Me.C1dbg.Splits(0).DisplayColumns.Item("USER_NAME").Visible = False

        Me.C1dbg.Columns.Item("BLNO").Caption = "提单号"
        Me.C1dbg.Columns.Item("MARK").Caption = "标志"
        Me.C1dbg.Columns.Item("code_goods").Caption = "货名代码"
        Me.C1dbg.Columns.Item("GOODS_CHA").Caption = "中文货名"
        Me.C1dbg.Columns.Item("goods_eng").Caption = "英文货名"
        Me.C1dbg.Columns.Item("CODE_PACK").Caption = "包装"
        Me.C1dbg.Columns.Item("AMOUNT").Caption = "实装件数"
        Me.C1dbg.Columns.Item("WEIGHT").Caption = "实装重量"
        Me.C1dbg.Columns.Item("VOLUMN").Caption = "实装体积"
        Me.C1dbg.Columns.Item("AMOUNT_ori").Caption = "原装件数"
        Me.C1dbg.Columns.Item("WEIGHT_ori").Caption = "原装重量"
        Me.C1dbg.Columns.Item("VOLUMN_ori").Caption = "原装体积"
        'Me.C1dbg.Columns.Item("ACCESSORY").Caption = "附件标志"
        'Me.C1dbg.Columns.Item("MARK_NON").Caption = "非本港舱单"

        Me.C1dbg.Splits(0).DisplayColumns.Item("BLNO").Width = 40
        Me.C1dbg.Splits(0).DisplayColumns.Item("MARK").Width = 100
        Me.C1dbg.Splits(0).DisplayColumns.Item("code_goods").Width = 80
        Me.C1dbg.Splits(0).DisplayColumns.Item("goods_cha").Width = 80
        Me.C1dbg.Splits(0).DisplayColumns.Item("goods_eng").Width = 120
        Me.C1dbg.Splits(0).DisplayColumns.Item("CODE_PACK").Width = 50
        Me.C1dbg.Splits(0).DisplayColumns.Item("AMOUNT").Width = 60
        Me.C1dbg.Splits(0).DisplayColumns.Item("WEIGHT").Width = 70
        Me.C1dbg.Splits(0).DisplayColumns.Item("VOLUMN").Width = 60
        Me.C1dbg.Splits(0).DisplayColumns.Item("AMOUNT_ori").Width = 60
        Me.C1dbg.Splits(0).DisplayColumns.Item("WEIGHT_ori").Width = 70
        Me.C1dbg.Splits(0).DisplayColumns.Item("VOLUMN_ori").Width = 60
        Me.C1dbg.Splits(0).DisplayColumns.Item("FREEZE_AMOUNT").Width = 60
        'Me.C1dbg.Splits(0).DisplayColumns.Item("ACCESSORY").Width = 40
        'Me.C1dbg.Splits(0).DisplayColumns.Item("MARK_NON").Width = 20
        'Me.C1dbg.Columns.Item("MARK_NON").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
        Me.C1dbg.Refresh()

        GOODS_CHA()
        code_pack()

        txtBLNO.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub BTADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtBLNO.Text = ""
        TxtMARK.Text = "N/M"
        TxtAMOUNT.Text = 0
        TxtGOODS_ENG.Text = ""
        TxtGOODS_CHA.Text = ""
        TxtNETWEIGHT.Text = 0
        TxtGROSS_WEIGHT.Text = 0
        TxtSIZE_MEASURE.Text = 0
        TxtTONS.Text = 0
        TxtSENDER.Text = ""
        TxtNOTIFY_PERSON.Text = ""
        TxtRECEIVER.Text = ""
        CBACCESSORY.Checked = False
    End Sub

    Private Sub BTOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOK.Click
        Dim dskey As New DataSet
        Try
            If Len(Trim(txtBLNO.Text)) > 0 Then
                If Len(Trim(TxtMARK.Text)) > -1 Then
                    If mark = "1" And Len(Trim(TxtPIECE_WEIGHT.Text)) = 0 Then
                        MsgBox("件重不能为空！")
                    Else
                        If mark = "1" And Trim(TxtPIECE_WEIGHT.Text) = "0" Then
                            MsgBox("件重不能为0")
                        Else
                            'If Len(Trim(combcode_goods.SelectedValue)) > 0 Then
                            If Len(Trim(TxtGOODS_CHA.Text)) > 0 Then
                            Else
                                If Len(Trim(TxtGOODS_ENG.Text)) > 0 Then
                                Else
                                    Call combcode_goods_Leave(sender, e)
                                End If
                            End If
                            If Len(Trim(TxtGOODS_CHA.Text)) > -1 Then
                                If Len(Trim(TxtGOODS_ENG.Text)) > -1 Then

                                    ds.Tables(0).Rows(0).Item("AMOUNT") = IIf(Len(Trim(TxtAMOUNT.Text)) > 0, Trim(TxtAMOUNT.Text), 0)
                                    ds.Tables(0).Rows(0).Item("TONS") = IIf(Len(Trim(TxtGROSS_WEIGHT.Text)) > 0, Trim(TxtGROSS_WEIGHT.Text), 0)
                                    ds.Tables(0).Rows(0).Item("size_MEASURE") = IIf(Len(Trim(TxtSIZE_MEASURE.Text)) > 0, Trim(TxtSIZE_MEASURE.Text), 0)

                                    ds.Tables(0).Rows(0).Item("AMOUNT_ORI") = IIf(Len(Trim(TxtAMOUNT_ori.Text)) > 0, Trim(TxtAMOUNT_ori.Text), 0)
                                    ds.Tables(0).Rows(0).Item("TONS_ORI") = IIf(Len(Trim(TxtGROSS_WEIGHT_ori.Text)) > 0, Trim(TxtGROSS_WEIGHT_ori.Text), 0)
                                    ds.Tables(0).Rows(0).Item("MEASURE_ORI") = IIf(Len(Trim(TxtSIZE_MEASURE_ori.Text)) > 0, Trim(TxtSIZE_MEASURE_ori.Text), 0)

                                    ds.Tables(0).Rows(0).Item("SENDER") = TxtSENDER.Text
                                    ds.Tables(0).Rows(0).Item("RECEIVER") = TxtRECEIVER.Text
                                    ds.Tables(0).Rows(0).Item("load_port") = CombLOAD_PORT.SelectedValue
                                    ds.Tables(0).Rows(0).Item("unload_port") = CombUNLOAD_PORT.SelectedValue
                                    ds.Tables(0).Rows(0).Item("load_port_cha") = txtLoadPortCha.Text
                                    ds.Tables(0).Rows(0).Item("load_port_eng") = txtLoadPortEng.Text
                                    ds.Tables(0).Rows(0).Item("unload_port_cha") = txtUnLoadPortCha.Text
                                    ds.Tables(0).Rows(0).Item("unload_port_eng") = txtUnLoadPortEng.Text
                                    ds.Tables(0).Rows(0).Item("USER_NAME") = Trim(G_User)

                                    ds.Tables(0).Rows(0).Item("MERGEMode") = ds.Tables(0).Rows(0).Item("MERGEMode")
                                    If Trim(ComboHB.Text) = "不合并" Then
                                        ds.Tables(0).Rows(0).Item("MERGEMode") = "1" + CStr(ds.Tables(0).Rows(0).Item("MERGEMode")).Substring(1, 2)
                                    ElseIf Trim(ComboHB.Text) = "只合并重量" Then
                                        ds.Tables(0).Rows(0).Item("MERGEMode") = "2" + CStr(ds.Tables(0).Rows(0).Item("MERGEMode")).Substring(1, 2)
                                    ElseIf Trim(ComboHB.Text) = "合并件数和重量" Then
                                        ds.Tables(0).Rows(0).Item("MERGEMode") = "3" + CStr(ds.Tables(0).Rows(0).Item("MERGEMode")).Substring(1, 2)
                                    End If

                                    If CBACCESSORY.Checked = True Then
                                        acc = "1"
                                    Else
                                        acc = "0"
                                    End If
                                    If CheckBox1.Checked = True Then
                                        ntp = "1"
                                        ds.Tables(0).Rows(0).Item("NON_THIS_PORT") = "1"
                                    Else
                                        ntp = "0"
                                        ds.Tables(0).Rows(0).Item("NON_THIS_PORT") = "0"
                                    End If
                                    sqlda.Update(ds)

                                    '新舱单子表信息
                                    Me.C1dbg.Enabled = True
                                    If ds_sub.Tables(0).Rows.Count = 0 Then
                                        Me.C1dbg.Select()
                                        Me.C1dbg.Row = Me.C1dbg.Row + 1
                                    End If

                                    'If MsgBox("再增加一条记录吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                                    '    TxtAMOUNT.Text = ""
                                    '    TxtNETWEIGHT.Text = ""
                                    '    TxtGROSS_WEIGHT.Text = ""
                                    '    TxtSIZE_MEASURE.Text = ""

                                    '    txtBLNO.Focus()
                                    'Else
                                    'Me.Close()
                                    'End If
                                Else
                                    MsgBox("货类英文描述不能为空！")
                                End If
                            Else
                                MsgBox("货类中文描述不能为空！")
                            End If

                            'Else
                            'MsgBox("货类不能为空！")
                            'End If
                        End If
                    End If
                Else
                    MsgBox("唛头不能为空！")
                End If
            Else
                MsgBox("提单号不能为空！")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message.GetHashCode & "  " & ex.Message.GetTypeCode & "  " & ex.Message)
        End Try
    End Sub

    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        AddFlag = False
        Me.Close()
    End Sub

    Private Sub combcode_goods_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles combcode_goods.Leave
        Try
            Dim dsg As New DataSet
            If Len(Trim(combcode_goods.Text)) > 0 Then
                If Mid(Trim(combcode_goods.Text), 1, 1) = "0" Or Mid(Trim(combcode_goods.Text), 1, 1) = "1" Or Mid(Trim(combcode_goods.Text), 1, 1) = "2" Or Mid(Trim(combcode_goods.Text), 1, 1) = "3" Or Mid(Trim(combcode_goods.Text), 1, 1) = "4" Or Mid(Trim(combcode_goods.Text), 1, 1) = "5" Or Mid(Trim(combcode_goods.Text), 1, 1) = "6" Or Mid(Trim(combcode_goods.Text), 1, 1) = "7" Or Mid(Trim(combcode_goods.Text), 1, 1) = "8" Or Mid(Trim(combcode_goods.Text), 1, 1) = "9" Then
                    dw = Getdata("select CODE_GOODS from code_cargo where code_goods='" & CType(combcode_goods.Text, String) & "'", dsg)
                    If dsg.Tables(0).DefaultView.Count > 0 Then
                        combcode_goods.SelectedValue = dsg.Tables(0).Rows(0).Item("code_goods")
                    End If
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CombCode_pack_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CombCode_pack.Leave
        Dim DSSELECT As New DataSet
        Try
            If Len(Trim(CombCode_pack.Text)) > 0 Then
                dw = Getdata("SELECT * FROM CODE_pack WHERE code_pack='" & Trim(CombCode_pack.Text) & "'", DSSELECT)
                If DSSELECT.Tables(0).Rows.Count > 0 Then
                    CombCode_pack.SelectedValue = DSSELECT.Tables(0).Rows(0).Item("code_pack")
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CombLOAD_PORT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CombLOAD_PORT.Leave
        Dim DSSELECT As New DataSet
        Try
            If Len(Trim(CombLOAD_PORT.Text)) > 0 Then
                dw = Getdata("SELECT * FROM CODE_port WHERE code_port like '%" & Trim(CombLOAD_PORT.Text) & "%' or port_cha like '%" & Trim(CombLOAD_PORT.Text) & "%' or port_eng like '%" & Trim(CombLOAD_PORT.Text) & "%'", DSSELECT)
                If DSSELECT.Tables(0).Rows.Count > 0 Then
                    CombLOAD_PORT.SelectedValue = DSSELECT.Tables(0).Rows(0).Item("code_port")
                    txtLoadPortCha.Text = DSSELECT.Tables(0).Rows(0).Item("PORT_CHA")
                    txtLoadPortEng.Text = DSSELECT.Tables(0).Rows(0).Item("PORT_ENG")
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CombUNLOAD_PORT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CombUNLOAD_PORT.Leave
        Dim DSSELECT As New DataSet
        Try
            If Len(Trim(CombUNLOAD_PORT.Text)) > 0 Then
                dw = Getdata("SELECT * FROM CODE_port WHERE code_port like '%" & Trim(CombUNLOAD_PORT.Text) & "%' or port_cha like '%" & Trim(CombUNLOAD_PORT.Text) & "%' or port_eng  like '%" & Trim(CombUNLOAD_PORT.Text) & "%'", DSSELECT)
                If DSSELECT.Tables(0).Rows.Count > 0 Then
                    CombUNLOAD_PORT.SelectedValue = DSSELECT.Tables(0).Rows(0).Item("code_port")
                    txtUnLoadPortCha.Text = DSSELECT.Tables(0).Rows(0).Item("PORT_CHA")
                    txtUnLoadPortEng.Text = DSSELECT.Tables(0).Rows(0).Item("PORT_ENG")
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtBLNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBLNO.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtMARK.Focus()
            txtBLNO.Text = txtBLNO.Text.ToUpper()
        End If
    End Sub
    Private Sub TxtMARK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMARK.KeyPress
        If e.KeyChar = Chr(13) Then
            cbCargo.Focus()
            TxtMARK.Text = TxtMARK.Text.ToUpper()
        End If
    End Sub
    Private Sub cbCargo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbCargo.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtGOODS_ENG.Focus()
        End If
    End Sub
    Private Sub CombCODE_GOODS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles combcode_goods.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtGOODS_ENG.Focus()
        End If
    End Sub
    Private Sub TxtGOODS_ENG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGOODS_ENG.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtGOODS_CHA.Focus()
            TxtGOODS_ENG.Text = TxtGOODS_ENG.Text.ToUpper()
        End If
    End Sub
    Private Sub TxtGOODS_CHA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGOODS_CHA.KeyPress
        If e.KeyChar = Chr(13) Then
            CombCode_pack.Focus()
        End If
    End Sub
    Private Sub TxtAMOUNT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAMOUNT.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtGROSS_WEIGHT.Focus()
        End If
    End Sub
    Private Sub CombCode_pack_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombCode_pack.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtAMOUNT.Focus()
        End If
    End Sub
    Private Sub TxtNETWEIGHT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNETWEIGHT.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtGROSS_WEIGHT.Focus()
        End If
    End Sub
    Private Sub TxtGROSS_WEIGHT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGROSS_WEIGHT.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtSIZE_MEASURE.Focus()
        End If
    End Sub
    Private Sub TxtSIZE_MEASURE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSIZE_MEASURE.KeyPress
        If e.KeyChar = Chr(13) Then
            CombLOAD_PORT.Focus()
        End If
    End Sub
    Private Sub TxtTONS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTONS.KeyPress
        If e.KeyChar = Chr(13) Then
            CombLOAD_PORT.Focus()
        End If
    End Sub
    Private Sub CombLOAD_PORT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombLOAD_PORT.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim DSSELECT As New DataSet
            Try
                If Len(Trim(CombLOAD_PORT.Text)) > 0 Then
                    dw = Getdata("SELECT * FROM CODE_port WHERE code_port like '%" & Trim(CombLOAD_PORT.Text) & "%' or port_cha like '%" & Trim(CombLOAD_PORT.Text) & "%' or port_eng like '%" & Trim(CombLOAD_PORT.Text) & "%'", DSSELECT)
                    If DSSELECT.Tables(0).Rows.Count > 0 Then
                        CombLOAD_PORT.SelectedValue = DSSELECT.Tables(0).Rows(0).Item("code_port")
                        txtLoadPortCha.Text = DSSELECT.Tables(0).Rows(0).Item("PORT_CHA")
                        txtLoadPortEng.Text = DSSELECT.Tables(0).Rows(0).Item("PORT_ENG")
                    End If
                End If
            Catch ex As System.Exception
                MsgBox(ex.Message)
            End Try
            CombUNLOAD_PORT.Focus()
        End If
    End Sub
    Private Sub CombUNLOAD_PORT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombUNLOAD_PORT.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim DSSELECT As New DataSet
            Try
                If Len(Trim(CombUNLOAD_PORT.Text)) > 0 Then
                    dw = Getdata("SELECT * FROM CODE_port WHERE code_port like '%" & Trim(CombUNLOAD_PORT.Text) & "%' or port_cha like '%" & Trim(CombUNLOAD_PORT.Text) & "%' or port_eng  like '%" & Trim(CombUNLOAD_PORT.Text) & "%'", DSSELECT)
                    If DSSELECT.Tables(0).Rows.Count > 0 Then
                        CombUNLOAD_PORT.SelectedValue = DSSELECT.Tables(0).Rows(0).Item("code_port")
                        txtUnLoadPortCha.Text = DSSELECT.Tables(0).Rows(0).Item("PORT_CHA")
                        txtUnLoadPortEng.Text = DSSELECT.Tables(0).Rows(0).Item("PORT_ENG")
                    End If
                End If
            Catch ex As System.Exception
                MsgBox(ex.Message)
            End Try
            TxtSENDER.Focus()
        End If
    End Sub
    Private Sub TxtSENDER_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSENDER.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtNOTIFY_PERSON.Focus()
        End If
    End Sub
    Private Sub TxtNOTIFY_PERSON_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNOTIFY_PERSON.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtRECEIVER.Focus()
        End If
    End Sub
    Private Sub TxtRECEIVER_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRECEIVER.KeyPress
        If e.KeyChar = Chr(13) Then
            CBACCESSORY.Focus()
        End If
    End Sub
    Private Sub CBACCESSORY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBACCESSORY.KeyPress
        If e.KeyChar = Chr(13) Then
            BTOK.Focus()
        End If
    End Sub

    Private Sub cbCargo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCargo.Leave
        Dim dsss As New DataSet
        If cbCargo.Text.Trim().Length() > 0 Then
            Dim fd As String
            Dim ss As Integer
            ss = 0
            ss = cbCargo.Text.Trim().IndexOf(" ")
            If ss > 0 Then
                fd = cbCargo.Text.Trim().Substring(0, ss)
                Getdata("select * from CODEGOODS where code like '%" & fd & "%' or goods like '%" & fd & "%' or goods_short = '" & fd & "'", dsss)
            Else
                Getdata("select * from CODEGOODS where code like '%" & cbCargo.Text.Trim() & "%' or goods like '%" & cbCargo.Text.Trim() & "%' or goods_short = '" & cbCargo.Text.Trim() & "'", dsss)
            End If

            'Getdata("select * from CODEGOODS where code like '%" & cbCargo.Text.Trim() & "%' or goods like '%" & cbCargo.Text.Trim() & "%' or goods_eng like '%" & cbCargo.Text.Trim() & "%' or goods_short like '%" & cbCargo.Text.Trim() & "%'", dsss)
            'Getdata("select * from CODEGOODS where code like '%" & cbCargo.Text.Trim() & "%' or goods like '%" & cbCargo.Text.Trim() & "%' or goods_short like '%" & cbCargo.Text.Trim() & "%'", dsss)
            'Getdata("select * from CODEGOODS where code like '%" & fd & "%' or goods like '%" & fd & "%' or goods_short like '%" & fd & "%'", dsss)
            If dsss.Tables(0).DefaultView.Count > 0 Then
                cbCargo.SelectedValue = dsss.Tables(0).Rows(0)("code")
                If Not IsDBNull(dsss.Tables(0).Rows(0)("Goods_Eng")) Then
                    If Trim(dsss.Tables(0).Rows(0)("Goods_Eng")).Length() > 0 Then
                        TxtGOODS_ENG.Text = IIf(IsDBNull(dsss.Tables(0).Rows(0)("Goods_Eng")), "", dsss.Tables(0).Rows(0)("Goods_Eng"))
                        TxtGOODS_CHA.Text = IIf(IsDBNull(dsss.Tables(0).Rows(0)("GOODS")), "", dsss.Tables(0).Rows(0)("GOODS"))
                    End If
                End If
                'TxtGOODS_CHA.Text = cbCargo.Text.Trim()
            End If
        End If
    End Sub

    Private Sub txtLoadPortCha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLoadPortCha.KeyPress
        If e.KeyChar = Chr(13) Then
            txtLoadPortEng.Focus()
        End If
    End Sub

    Private Sub txtLoadPortEng_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLoadPortEng.KeyPress
        If e.KeyChar = Chr(13) Then
            CombUNLOAD_PORT.Focus()
        End If
    End Sub

    Private Sub txtUnLoadPortCha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnLoadPortCha.KeyPress
        If e.KeyChar = Chr(13) Then
            'txtUnLoadPortCha.Focus()
            txtUnLoadPortEng.Focus()
        End If
    End Sub

    Private Sub txtUnLoadPortEng_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnLoadPortEng.KeyPress
        If e.KeyChar = Chr(13) Then
            'txtUnLoadPortCha.Focus()
            TxtSENDER.Focus()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            sqlda_sub.Update(ds_sub)
            ExecSql("get_sum_cargo_hatch_new " & ID)
            'ExecSql("update cargo_hatch_new set oldid=0 where ship_id=" & Ship_ID)
            'ExecSql("trans_cargolist " & Ship_ID)
            Call BTQUIT_Click(sender, e)
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GOODS()
        Dim DSGOODS As New DataSet
        Try
            Dim i As Integer
            DSGOODS.Reset()
            dw = Getdata("select code, goods ,goods_eng from CODEGOODS where code='" & Me.C1dbg.Columns.Item("CODE_GOODS").Text & "'", DSGOODS)
            If DSGOODS.Tables(0).Rows.Count > 0 Then
                Me.C1dbg.Columns.Item("code_goods").Value = DSGOODS.Tables(0).Rows(0).Item("code")
                Me.C1dbg.Columns.Item("goods_cha").Value = DSGOODS.Tables(0).Rows(0).Item("goods")
                Me.C1dbg.Columns.Item("goods_eng").Value = DSGOODS.Tables(0).Rows(0).Item("goods_eng")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GOODS_CHA()
        Try
            Dim i As Integer
            Dim DSGOODS_CHA As New DataSet
            dw = Getdata("select code, goods ,goods_eng from CODEGOODS where Flag_Dept=1 and Flag_Type=1 order by flag_px ", DSGOODS_CHA)
            If DSGOODS_CHA.Tables(0).Rows.Count > 0 Then
                Me.C1dbg.Columns.Item("code_goods").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
                Me.C1dbg.Columns.Item("code_goods").ValueItems.Translate = True
                Do While Me.C1dbg.Columns.Item("code_goods").ValueItems.Values.Count > 0
                    Me.C1dbg.Columns.Item("code_goods").ValueItems.Values.RemoveAt(0)
                Loop
                For i = 0 To DSGOODS_CHA.Tables(0).Rows.Count - 1
                    Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                    'vi.DisplayValue = DSGOODS_CHA.Tables(0).Rows(i)("goods_eng")
                    vi.DisplayValue = DSGOODS_CHA.Tables(0).Rows(i)("goods")
                    vi.Value = DSGOODS_CHA.Tables(0).Rows(i)("code")
                    Me.C1dbg.Columns.Item("code_goods").ValueItems.Values.Add(vi)
                Next
                'Me.C1dbg.Columns.Item("code_goods").Value = DSGOODS_CHA.Tables(0).Rows(0).Item("code")
                'Me.C1dbg.Columns.Item("goods_cha").Value = DSGOODS_CHA.Tables(0).Rows(0).Item("goods")
                'Me.C1dbg.Columns.Item("goods_eng").Value = DSGOODS_CHA.Tables(0).Rows(0).Item("goods_eng")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub code_pack()
        Try
            Dim i As Integer
            Dim dscode_pack As New DataSet
            dw = Getdata("select * from code_pack order by px ", dscode_pack)
            If dscode_pack.Tables(0).Rows.Count > 0 Then
                Me.C1dbg.Columns.Item("CODE_PACK").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
                Me.C1dbg.Columns.Item("CODE_PACK").ValueItems.Translate = True
                Do While Me.C1dbg.Columns.Item("CODE_PACK").ValueItems.Values.Count > 0
                    Me.C1dbg.Columns.Item("CODE_PACK").ValueItems.Values.RemoveAt(0)
                Loop
                For i = 0 To dscode_pack.Tables(0).Rows.Count - 1
                    Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                    vi.DisplayValue = dscode_pack.Tables(0).Rows(i)("pack_eng")
                    'vi.DisplayValue = dscode_pack.Tables(0).Rows(i)("pack_cha")
                    vi.Value = dscode_pack.Tables(0).Rows(i)("code_pack")
                    Me.C1dbg.Columns.Item("CODE_PACK").ValueItems.Values.Add(vi)
                Next
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub C1dbg_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles C1dbg.RowColChange
        Try
            If e.LastCol = 3 Then
                'Call GOODS()

                Dim DSGOODS As New DataSet
                Dim i As Integer
                DSGOODS.Reset()
                dw = Getdata("select code, goods, goods_eng from CODEGOODS where code='" & Me.C1dbg.Columns.Item("code_goods").Value & "'", DSGOODS)
                If DSGOODS.Tables(0).Rows.Count > 0 Then
                    'Me.C1dbg.Columns.Item("code_goods").Value = DSGOODS.Tables(0).Rows(0).Item("code")
                    Me.C1dbg.Columns.Item("goods_cha").Value = DSGOODS.Tables(0).Rows(0).Item("goods")
                    Me.C1dbg.Columns.Item("goods_eng").Value = DSGOODS.Tables(0).Rows(0).Item("goods_eng")
                End If
                'Call code_pack(Me.C1dbg.Columns.Item("blno").Text.ToString, Me.C1dbg.Columns.Item("mark").Text.ToString)
            End If

            'If e.LastCol = 8 Then
            '    Me.C1dbg.Columns.Item("AMOUNT_ori").Value = Me.C1dbg.Columns.Item("AMOUNT").Value
            'End If
            'If e.LastCol = 9 Then
            '    Me.C1dbg.Columns.Item("WEIGHT_ori").Value = Me.C1dbg.Columns.Item("WEIGHT").Value
            'End If
            'If e.LastCol = 10 Then
            '    Me.C1dbg.Columns.Item("VOLUMN_ori").Value = Me.C1dbg.Columns.Item("VOLUMN").Value
            'End If
            If e.LastCol = 17 Then
                Me.C1dbg.Col = 3
                If Me.C1dbg.Row + 1 = Me.C1dbg.RowCount Then
                    Me.C1dbg.Row = Me.C1dbg.Row + 1
                End If
            End If

            If e.LastRow <> -1 And Me.C1dbg.Columns.Item("mid").Text = "" Then
                Me.C1dbg.Columns.Item("mid").Text = ID
                Me.C1dbg.Columns.Item("ACCESSORY").Value = acc
                Me.C1dbg.Columns.Item("MARK_NON").Value = ntp
                Me.C1dbg.Columns.Item("USER_NAME").Value = G_User
            End If
            'If e.LastRow <> -1 And Me.C1dbg.Columns.Item("").Text.ToString <> "" And Me.C1dbg.Columns.Item("blno").Text = "" Then
            '    MsgBox("提单号不能为空！")
            'End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
