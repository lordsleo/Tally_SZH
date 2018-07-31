Imports TALLY.DBControl
Public Class FrmCargo_hatch_list_edit
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet
    Dim sqlda As New SqlClient.SqlDataAdapter
    Dim dw As New DataView
    Dim dsport1 As New DataSet
    Dim dsport2 As New DataSet
    Dim dsgoods As New DataSet
    Dim dscgood As New DataSet
    Dim dspack As New DataSet
    Dim blno1 As String
    Dim mark1 As String
    Dim code_goods1 As String
    Dim goods_cha1 As String
    Dim goods_eng1 As String
    Dim blno2 As String
    Dim mark2 As String
    Dim code_goods2 As String
    Dim goods_cha2 As String
    Dim goods_eng2 As String
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
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents BTOK As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CombCode_pack As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents combcode_goods As System.Windows.Forms.ComboBox
    Friend WithEvents CombUNLOAD_PORT As System.Windows.Forms.ComboBox
    Friend WithEvents CombLOAD_PORT As System.Windows.Forms.ComboBox
    Friend WithEvents TxtGOODS_CHA As System.Windows.Forms.TextBox
    Friend WithEvents TxtGOODS_ENG As System.Windows.Forms.TextBox
    Friend WithEvents TxtAMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents TxtRECEIVER As System.Windows.Forms.TextBox
    Friend WithEvents TxtNOTIFY_PERSON As System.Windows.Forms.TextBox
    Friend WithEvents TxtSENDER As System.Windows.Forms.TextBox
    Friend WithEvents TxtTONS As System.Windows.Forms.TextBox
    Friend WithEvents TxtSIZE_MEASURE As System.Windows.Forms.TextBox
    Friend WithEvents TxtGROSS_WEIGHT As System.Windows.Forms.TextBox
    Friend WithEvents TxtNETWEIGHT As System.Windows.Forms.TextBox
    Friend WithEvents TxtMARK As System.Windows.Forms.TextBox
    Friend WithEvents txtBLNO As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBACCESSORY As System.Windows.Forms.CheckBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TxtPIECE_WEIGHT As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cbCargo As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtLoadPortEng As System.Windows.Forms.TextBox
    Friend WithEvents txtLoadPortCha As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtUnLoadPortEng As System.Windows.Forms.TextBox
    Friend WithEvents txtUnLoadPortCha As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtamount_ori As System.Windows.Forms.TextBox
    Friend WithEvents TxtGROSS_WEIGHT_ORI As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCargo_hatch_list_edit))
        Me.BTQUIT = New System.Windows.Forms.Button
        Me.BTOK = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.CombCode_pack = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.combcode_goods = New System.Windows.Forms.ComboBox
        Me.CombUNLOAD_PORT = New System.Windows.Forms.ComboBox
        Me.CombLOAD_PORT = New System.Windows.Forms.ComboBox
        Me.TxtGOODS_CHA = New System.Windows.Forms.TextBox
        Me.TxtGOODS_ENG = New System.Windows.Forms.TextBox
        Me.TxtAMOUNT = New System.Windows.Forms.TextBox
        Me.TxtRECEIVER = New System.Windows.Forms.TextBox
        Me.TxtNOTIFY_PERSON = New System.Windows.Forms.TextBox
        Me.TxtSENDER = New System.Windows.Forms.TextBox
        Me.TxtTONS = New System.Windows.Forms.TextBox
        Me.TxtSIZE_MEASURE = New System.Windows.Forms.TextBox
        Me.TxtGROSS_WEIGHT = New System.Windows.Forms.TextBox
        Me.TxtNETWEIGHT = New System.Windows.Forms.TextBox
        Me.TxtMARK = New System.Windows.Forms.TextBox
        Me.txtBLNO = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CBACCESSORY = New System.Windows.Forms.CheckBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.TxtPIECE_WEIGHT = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.cbCargo = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtLoadPortEng = New System.Windows.Forms.TextBox
        Me.txtLoadPortCha = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtUnLoadPortEng = New System.Windows.Forms.TextBox
        Me.txtUnLoadPortCha = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtamount_ori = New System.Windows.Forms.TextBox
        Me.TxtGROSS_WEIGHT_ORI = New System.Windows.Forms.TextBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'BTQUIT
        '
        Me.BTQUIT.BackColor = System.Drawing.Color.Transparent
        Me.BTQUIT.Location = New System.Drawing.Point(292, 342)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 22
        Me.BTQUIT.Text = "取消"
        '
        'BTOK
        '
        Me.BTOK.BackColor = System.Drawing.Color.Transparent
        Me.BTOK.Location = New System.Drawing.Point(218, 342)
        Me.BTOK.Name = "BTOK"
        Me.BTOK.Size = New System.Drawing.Size(65, 24)
        Me.BTOK.TabIndex = 21
        Me.BTOK.Text = "确认"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label20.Location = New System.Drawing.Point(252, 229)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 22)
        Me.Label20.TabIndex = 105
        Me.Label20.Text = "立方米"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label19.Location = New System.Drawing.Point(96, 328)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 22)
        Me.Label19.TabIndex = 104
        Me.Label19.Text = "公斤"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label19.Visible = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.Location = New System.Drawing.Point(264, 201)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 22)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "公斤"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(92, 350)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 22)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "公斤"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label10.Visible = False
        '
        'CombCode_pack
        '
        Me.CombCode_pack.Location = New System.Drawing.Point(98, 149)
        Me.CombCode_pack.Name = "CombCode_pack"
        Me.CombCode_pack.Size = New System.Drawing.Size(196, 20)
        Me.CombCode_pack.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(12, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 24)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "包装"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'combcode_goods
        '
        Me.combcode_goods.Location = New System.Drawing.Point(378, 258)
        Me.combcode_goods.Name = "combcode_goods"
        Me.combcode_goods.Size = New System.Drawing.Size(190, 20)
        Me.combcode_goods.TabIndex = 20
        Me.combcode_goods.Visible = False
        '
        'CombUNLOAD_PORT
        '
        Me.CombUNLOAD_PORT.Location = New System.Drawing.Point(378, 94)
        Me.CombUNLOAD_PORT.Name = "CombUNLOAD_PORT"
        Me.CombUNLOAD_PORT.Size = New System.Drawing.Size(190, 20)
        Me.CombUNLOAD_PORT.TabIndex = 14
        '
        'CombLOAD_PORT
        '
        Me.CombLOAD_PORT.Location = New System.Drawing.Point(378, 10)
        Me.CombLOAD_PORT.Name = "CombLOAD_PORT"
        Me.CombLOAD_PORT.Size = New System.Drawing.Size(190, 20)
        Me.CombLOAD_PORT.TabIndex = 11
        '
        'TxtGOODS_CHA
        '
        Me.TxtGOODS_CHA.Location = New System.Drawing.Point(98, 120)
        Me.TxtGOODS_CHA.MaxLength = 30
        Me.TxtGOODS_CHA.Name = "TxtGOODS_CHA"
        Me.TxtGOODS_CHA.Size = New System.Drawing.Size(196, 21)
        Me.TxtGOODS_CHA.TabIndex = 4
        Me.TxtGOODS_CHA.Text = ""
        '
        'TxtGOODS_ENG
        '
        Me.TxtGOODS_ENG.Location = New System.Drawing.Point(98, 93)
        Me.TxtGOODS_ENG.MaxLength = 30
        Me.TxtGOODS_ENG.Name = "TxtGOODS_ENG"
        Me.TxtGOODS_ENG.Size = New System.Drawing.Size(196, 21)
        Me.TxtGOODS_ENG.TabIndex = 3
        Me.TxtGOODS_ENG.Text = ""
        '
        'TxtAMOUNT
        '
        Me.TxtAMOUNT.Location = New System.Drawing.Point(98, 174)
        Me.TxtAMOUNT.Name = "TxtAMOUNT"
        Me.TxtAMOUNT.Size = New System.Drawing.Size(196, 21)
        Me.TxtAMOUNT.TabIndex = 6
        Me.TxtAMOUNT.Text = ""
        '
        'TxtRECEIVER
        '
        Me.TxtRECEIVER.Location = New System.Drawing.Point(378, 230)
        Me.TxtRECEIVER.MaxLength = 30
        Me.TxtRECEIVER.Name = "TxtRECEIVER"
        Me.TxtRECEIVER.Size = New System.Drawing.Size(190, 21)
        Me.TxtRECEIVER.TabIndex = 19
        Me.TxtRECEIVER.Text = ""
        '
        'TxtNOTIFY_PERSON
        '
        Me.TxtNOTIFY_PERSON.Location = New System.Drawing.Point(378, 202)
        Me.TxtNOTIFY_PERSON.MaxLength = 30
        Me.TxtNOTIFY_PERSON.Name = "TxtNOTIFY_PERSON"
        Me.TxtNOTIFY_PERSON.Size = New System.Drawing.Size(190, 21)
        Me.TxtNOTIFY_PERSON.TabIndex = 18
        Me.TxtNOTIFY_PERSON.Text = ""
        '
        'TxtSENDER
        '
        Me.TxtSENDER.Location = New System.Drawing.Point(378, 174)
        Me.TxtSENDER.MaxLength = 30
        Me.TxtSENDER.Name = "TxtSENDER"
        Me.TxtSENDER.Size = New System.Drawing.Size(190, 21)
        Me.TxtSENDER.TabIndex = 17
        Me.TxtSENDER.Text = ""
        '
        'TxtTONS
        '
        Me.TxtTONS.Location = New System.Drawing.Point(58, 328)
        Me.TxtTONS.Name = "TxtTONS"
        Me.TxtTONS.Size = New System.Drawing.Size(28, 21)
        Me.TxtTONS.TabIndex = 90
        Me.TxtTONS.Text = ""
        Me.TxtTONS.Visible = False
        '
        'TxtSIZE_MEASURE
        '
        Me.TxtSIZE_MEASURE.Location = New System.Drawing.Point(98, 230)
        Me.TxtSIZE_MEASURE.Name = "TxtSIZE_MEASURE"
        Me.TxtSIZE_MEASURE.Size = New System.Drawing.Size(154, 21)
        Me.TxtSIZE_MEASURE.TabIndex = 8
        Me.TxtSIZE_MEASURE.Text = ""
        '
        'TxtGROSS_WEIGHT
        '
        Me.TxtGROSS_WEIGHT.Location = New System.Drawing.Point(98, 202)
        Me.TxtGROSS_WEIGHT.Name = "TxtGROSS_WEIGHT"
        Me.TxtGROSS_WEIGHT.Size = New System.Drawing.Size(166, 21)
        Me.TxtGROSS_WEIGHT.TabIndex = 7
        Me.TxtGROSS_WEIGHT.Text = ""
        '
        'TxtNETWEIGHT
        '
        Me.TxtNETWEIGHT.Location = New System.Drawing.Point(60, 352)
        Me.TxtNETWEIGHT.Name = "TxtNETWEIGHT"
        Me.TxtNETWEIGHT.Size = New System.Drawing.Size(28, 21)
        Me.TxtNETWEIGHT.TabIndex = 87
        Me.TxtNETWEIGHT.Text = ""
        Me.TxtNETWEIGHT.Visible = False
        '
        'TxtMARK
        '
        Me.TxtMARK.Location = New System.Drawing.Point(98, 38)
        Me.TxtMARK.MaxLength = 30
        Me.TxtMARK.Name = "TxtMARK"
        Me.TxtMARK.Size = New System.Drawing.Size(196, 21)
        Me.TxtMARK.TabIndex = 1
        Me.TxtMARK.Text = ""
        '
        'txtBLNO
        '
        Me.txtBLNO.Location = New System.Drawing.Point(98, 9)
        Me.txtBLNO.MaxLength = 20
        Me.txtBLNO.Name = "txtBLNO"
        Me.txtBLNO.Size = New System.Drawing.Size(196, 21)
        Me.txtBLNO.TabIndex = 0
        Me.txtBLNO.Text = ""
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(12, 117)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 24)
        Me.Label18.TabIndex = 84
        Me.Label18.Text = "货物中文描述"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(12, 90)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 24)
        Me.Label17.TabIndex = 83
        Me.Label17.Text = "货物英文描述"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(298, 256)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 24)
        Me.Label16.TabIndex = 82
        Me.Label16.Text = "计费货类名称"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label16.Visible = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(12, 171)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 24)
        Me.Label15.TabIndex = 81
        Me.Label15.Text = "实装件数"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(12, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 24)
        Me.Label14.TabIndex = 80
        Me.Label14.Text = "标志"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(298, 90)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 24)
        Me.Label13.TabIndex = 79
        Me.Label13.Text = "卸货港"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(298, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 24)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "装货港"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(298, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 24)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "收货人"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(298, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 24)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "通知方"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(298, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 24)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "发货人"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(28, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 24)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "衡重"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 24)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "体积尺寸"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 24)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "实装毛重"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(30, 352)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 24)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "净重"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 24)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "提单/装单号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CBACCESSORY
        '
        Me.CBACCESSORY.BackColor = System.Drawing.Color.Transparent
        Me.CBACCESSORY.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CBACCESSORY.Location = New System.Drawing.Point(480, 318)
        Me.CBACCESSORY.Name = "CBACCESSORY"
        Me.CBACCESSORY.Size = New System.Drawing.Size(74, 24)
        Me.CBACCESSORY.TabIndex = 106
        Me.CBACCESSORY.Text = "是否附件"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label22.Location = New System.Drawing.Point(246, 438)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(30, 22)
        Me.Label22.TabIndex = 109
        Me.Label22.Text = "公斤"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label22.Visible = False
        '
        'TxtPIECE_WEIGHT
        '
        Me.TxtPIECE_WEIGHT.Enabled = False
        Me.TxtPIECE_WEIGHT.Location = New System.Drawing.Point(134, 438)
        Me.TxtPIECE_WEIGHT.Name = "TxtPIECE_WEIGHT"
        Me.TxtPIECE_WEIGHT.Size = New System.Drawing.Size(112, 21)
        Me.TxtPIECE_WEIGHT.TabIndex = 108
        Me.TxtPIECE_WEIGHT.Text = ""
        Me.TxtPIECE_WEIGHT.Visible = False
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Location = New System.Drawing.Point(50, 438)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 24)
        Me.Label21.TabIndex = 107
        Me.Label21.Text = "件重"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label21.Visible = False
        '
        'cbCargo
        '
        Me.cbCargo.Location = New System.Drawing.Point(98, 69)
        Me.cbCargo.Name = "cbCargo"
        Me.cbCargo.Size = New System.Drawing.Size(196, 20)
        Me.cbCargo.TabIndex = 2
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Location = New System.Drawing.Point(12, 65)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 24)
        Me.Label23.TabIndex = 110
        Me.Label23.Text = "货物代码名称"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLoadPortEng
        '
        Me.txtLoadPortEng.Location = New System.Drawing.Point(378, 68)
        Me.txtLoadPortEng.Name = "txtLoadPortEng"
        Me.txtLoadPortEng.Size = New System.Drawing.Size(190, 21)
        Me.txtLoadPortEng.TabIndex = 13
        Me.txtLoadPortEng.Text = ""
        '
        'txtLoadPortCha
        '
        Me.txtLoadPortCha.Location = New System.Drawing.Point(378, 38)
        Me.txtLoadPortCha.Name = "txtLoadPortCha"
        Me.txtLoadPortCha.Size = New System.Drawing.Size(190, 21)
        Me.txtLoadPortCha.TabIndex = 12
        Me.txtLoadPortCha.Text = ""
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(298, 65)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label25.Size = New System.Drawing.Size(80, 24)
        Me.Label25.TabIndex = 113
        Me.Label25.Text = "装货港英文名"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(298, 35)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label24.Size = New System.Drawing.Size(80, 24)
        Me.Label24.TabIndex = 112
        Me.Label24.Text = "装货港中文名"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUnLoadPortEng
        '
        Me.txtUnLoadPortEng.Location = New System.Drawing.Point(378, 148)
        Me.txtUnLoadPortEng.Name = "txtUnLoadPortEng"
        Me.txtUnLoadPortEng.Size = New System.Drawing.Size(190, 21)
        Me.txtUnLoadPortEng.TabIndex = 16
        Me.txtUnLoadPortEng.Text = ""
        '
        'txtUnLoadPortCha
        '
        Me.txtUnLoadPortCha.Location = New System.Drawing.Point(378, 120)
        Me.txtUnLoadPortCha.Name = "txtUnLoadPortCha"
        Me.txtUnLoadPortCha.Size = New System.Drawing.Size(190, 21)
        Me.txtUnLoadPortCha.TabIndex = 15
        Me.txtUnLoadPortCha.Text = ""
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Location = New System.Drawing.Point(298, 145)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label27.Size = New System.Drawing.Size(80, 24)
        Me.Label27.TabIndex = 117
        Me.Label27.Text = "卸货港英文名"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Location = New System.Drawing.Point(298, 117)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label26.Size = New System.Drawing.Size(80, 24)
        Me.Label26.TabIndex = 116
        Me.Label26.Text = "卸货港中文名"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(12, 256)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(80, 24)
        Me.Label28.TabIndex = 81
        Me.Label28.Text = "原配件数"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(12, 286)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(80, 24)
        Me.Label29.TabIndex = 72
        Me.Label29.Text = "原配毛重"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label30.Location = New System.Drawing.Point(264, 286)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(30, 22)
        Me.Label30.TabIndex = 103
        Me.Label30.Text = "公斤"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtamount_ori
        '
        Me.txtamount_ori.Location = New System.Drawing.Point(98, 256)
        Me.txtamount_ori.Name = "txtamount_ori"
        Me.txtamount_ori.Size = New System.Drawing.Size(196, 21)
        Me.txtamount_ori.TabIndex = 9
        Me.txtamount_ori.Text = ""
        '
        'TxtGROSS_WEIGHT_ORI
        '
        Me.TxtGROSS_WEIGHT_ORI.Location = New System.Drawing.Point(98, 286)
        Me.TxtGROSS_WEIGHT_ORI.Name = "TxtGROSS_WEIGHT_ORI"
        Me.TxtGROSS_WEIGHT_ORI.Size = New System.Drawing.Size(166, 21)
        Me.TxtGROSS_WEIGHT_ORI.TabIndex = 10
        Me.TxtGROSS_WEIGHT_ORI.Text = ""
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(480, 288)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(88, 24)
        Me.CheckBox1.TabIndex = 118
        Me.CheckBox1.Text = "非本港舱单"
        '
        'FrmCargo_hatch_list_edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(600, 377)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtUnLoadPortEng)
        Me.Controls.Add(Me.txtUnLoadPortCha)
        Me.Controls.Add(Me.txtLoadPortEng)
        Me.Controls.Add(Me.txtLoadPortCha)
        Me.Controls.Add(Me.TxtPIECE_WEIGHT)
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
        Me.Controls.Add(Me.txtamount_ori)
        Me.Controls.Add(Me.TxtGROSS_WEIGHT_ORI)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.cbCargo)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.CBACCESSORY)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CombCode_pack)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.combcode_goods)
        Me.Controls.Add(Me.CombUNLOAD_PORT)
        Me.Controls.Add(Me.CombLOAD_PORT)
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
        Me.Controls.Add(Me.BTQUIT)
        Me.Controls.Add(Me.BTOK)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargo_hatch_list_edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "件杂货进口舱单_编辑"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCargo_hatch_list_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sqlstr As String
        If Hatch_in = 0 Then
            Me.Text = "件杂货进口舱单_编辑"
        ElseIf Hatch_in = 1 Then
            Me.Text = "件杂货出口装货单_编辑"
        End If
        On Error GoTo Err

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

        dw = Getdata("select CODE_GOODS,GOODS_CHA+' '+ISNULL(GOODS_ENG,' ') as goods from code_cargo order by goods ", dsgoods)
        combcode_goods.DataSource = dsgoods.Tables(0).DefaultView
        combcode_goods.DisplayMember = "goods"
        combcode_goods.ValueMember = "CODE_GOODS"

        'dw = Getdata("select CODE,GOODS from codegoods order by code ", dscgood)
        dw = Getdata("select CODE,GOODS+' '+Goods_Eng as GOODS from codegoods where Flag_Dept=1 and Flag_Type=1 order by Flag_Px ", dscgood)
        cbCargo.DataSource = dscgood.Tables(0).DefaultView
        cbCargo.DisplayMember = "GOODS"
        cbCargo.ValueMember = "CODE"

        dw = Getdata("select code_pack,pack_cha+' '+isnull(pack_eng,' ') as pack from code_pack order by px ", dspack)
        CombCode_pack.DataSource = dspack.Tables(0).DefaultView
        CombCode_pack.DisplayMember = "pack"
        CombCode_pack.ValueMember = "code_pack"

        sqlstr = "select * from CARGO_HATCH_LIST where CARGO_HATCH_LIST_ID='" & ID & "'"
        dw = Updatedata(sqlda, sqlstr, ds)
        If ds.Tables(0).DefaultView.Count > 0 Then
            If ds.Tables(0).Rows(0).Item("mark_non") = "1" Then
                mark = "0"
            Else
                mark = "1"
            End If
        End If
        If mark = "1" Then
            TxtPIECE_WEIGHT.Enabled = True
            TxtPIECE_WEIGHT.Visible = True
            Label22.Visible = True
            Label21.Visible = True
            TxtAMOUNT.Enabled = False
            TxtNETWEIGHT.Enabled = False
            TxtGROSS_WEIGHT.Enabled = False
            Label4.Text = "件体积"
        End If
        If ds.Tables(0).DefaultView.Count > 0 Then
            txtBLNO.Text = ds.Tables(0).Rows(0).Item("blno")
            TxtMARK.Text = ds.Tables(0).Rows(0).Item("MARK")
            TxtAMOUNT.Text = ds.Tables(0).Rows(0).Item("AMOUNT")
            txtamount_ori.Text = ds.Tables(0).Rows(0).Item("AMOUNT_ORI")
            TxtGOODS_ENG.Text = ds.Tables(0).Rows(0).Item("GOODS_ENG")
            TxtGOODS_CHA.Text = ds.Tables(0).Rows(0).Item("GOODS_CHA")
            TxtNETWEIGHT.Text = ds.Tables(0).Rows(0).Item("NETWEIGHT")
            TxtGROSS_WEIGHT.Text = ds.Tables(0).Rows(0).Item("GROSS_WEIGHT")
            TxtGROSS_WEIGHT_ORI.Text = ds.Tables(0).Rows(0).Item("TONS_ORI")
            TxtSIZE_MEASURE.Text = ds.Tables(0).Rows(0).Item("SIZE_MEASURE")
            TxtTONS.Text = ds.Tables(0).Rows(0).Item("TONS")
            TxtSENDER.Text = ds.Tables(0).Rows(0).Item("SENDER")
            TxtNOTIFY_PERSON.Text = ds.Tables(0).Rows(0).Item("NOTIFY_PERSON")
            TxtRECEIVER.Text = ds.Tables(0).Rows(0).Item("RECEIVER")
            CombCode_pack.SelectedValue = ds.Tables(0).Rows(0).Item("code_pack")
            combcode_goods.SelectedValue = ds.Tables(0).Rows(0).Item("code_goods")
            CombLOAD_PORT.SelectedValue = ds.Tables(0).Rows(0).Item("load_port")
            txtLoadPortCha.Text = ds.Tables(0).Rows(0).Item("LOAD_PORT_CHA")
            txtLoadPortEng.Text = ds.Tables(0).Rows(0).Item("LOAD_PORT_ENG")

            CombUNLOAD_PORT.SelectedValue = ds.Tables(0).Rows(0).Item("unload_port")
            txtUnLoadPortCha.Text = ds.Tables(0).Rows(0).Item("UnLOAD_PORT_CHA")
            txtUnLoadPortEng.Text = ds.Tables(0).Rows(0).Item("UnLOAD_PORT_ENG")

            cbCargo.SelectedValue = ds.Tables(0).Rows(0).Item("Code_Cargo")
            TxtPIECE_WEIGHT.Text = ds.Tables(0).Rows(0).Item("PIECE_WEIGHT")
            If ds.Tables(0).Rows(0).Item("ACCESSORY") = "1" Then
                CBACCESSORY.Checked = True
            Else
                CBACCESSORY.Checked = False
            End If
            If ds.Tables(0).Rows(0).Item("NON_THIS_PORT") = "1" Then
                CheckBox1.Checked = True
            Else
                CheckBox1.Checked = False
            End If
            blno1 = txtBLNO.Text
            mark1 = TxtMARK.Text
            code_goods1 = combcode_goods.SelectedValue
            goods_cha1 = TxtGOODS_CHA.Text
            goods_eng1 = TxtGOODS_ENG.Text
        End If
        txtBLNO.Focus()
        Exit Sub
Err:
        Resume Next
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
    Private Sub BTOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOK.Click
        Dim dskey As New DataSet
        Try
            If Len(Trim(txtBLNO.Text)) > 0 Then
                If Len(Trim(TxtMARK.Text)) > 0 Then
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
                            If Len(Trim(TxtGOODS_CHA.Text)) > 0 Then
                                If Len(Trim(TxtGOODS_ENG.Text)) > 0 Then
                                    dw = Getdata("select * from cargo_hatch_list where ship_id='" & Ship_ID & "' and blno='" & txtBLNO.Text & "' and mark='" & TxtMARK.Text & "'  and code_goods='" & combcode_goods.SelectedValue & "' and goods_cha='" & TxtGOODS_CHA.Text & "' and cargo_hatch_list_id<> '" & ID & "'", dskey)
                                    If dskey.Tables(0).Rows.Count > 0 Then

                                        MsgBox("该舱单已存在，请查实！")
                                    Else
                                        If MsgBox("确认要修改吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                                            OperateHistory(G_DeptName, Now, G_User, "编辑", "cargo_hatch_list", ID, "cargo_hatch_list_id")
                                            blno2 = Trim(txtBLNO.Text)
                                            mark2 = Trim(TxtMARK.Text)
                                            code_goods2 = combcode_goods.SelectedValue
                                            goods_cha2 = Trim(TxtGOODS_CHA.Text)
                                            goods_eng2 = Trim(TxtGOODS_ENG.Text)
                                            If blno1 <> blno2 Or mark1 <> mark2 Or code_goods1 <> code_goods2 Or goods_cha1 <> goods_cha2 Or goods_eng1 <> goods_eng2 Then
                                                ExecSql("exec spupdate_cargo_list '" & Ship_ID & "','" & blno2 & "','" & mark2 & "','" & code_goods2 & "','" & goods_cha2 & "','" & goods_eng2 & "','" & blno1 & "','" & mark1 & "','" & code_goods1 & "','" & goods_cha1 & "','" & goods_eng1 & "'")
                                            End If
                                            ds.Tables(0).Rows(0).Item("BLNO") = txtBLNO.Text
                                            ds.Tables(0).Rows(0).Item("MARK") = TxtMARK.Text
                                            ds.Tables(0).Rows(0).Item("AMOUNT") = IIf(Len(Trim(TxtAMOUNT.Text)) > 0, Trim(TxtAMOUNT.Text), 0)
                                            ds.Tables(0).Rows(0).Item("AMOUNT_ORI") = IIf(Len(Trim(txtamount_ori.Text)) > 0, Trim(txtamount_ori.Text), 0)
                                            ds.Tables(0).Rows(0).Item("GOODS_ENG") = TxtGOODS_ENG.Text
                                            ds.Tables(0).Rows(0).Item("GOODS_CHA") = TxtGOODS_CHA.Text
                                            ds.Tables(0).Rows(0).Item("GROSS_WEIGHT") = IIf(Len(Trim(TxtGROSS_WEIGHT.Text)) > 0, Trim(TxtGROSS_WEIGHT.Text), 0)
                                            ds.Tables(0).Rows(0).Item("TONS_ORI") = IIf(Len(Trim(TxtGROSS_WEIGHT_ORI.Text)) > 0, Trim(TxtGROSS_WEIGHT_ORI.Text), 0)
                                            ds.Tables(0).Rows(0).Item("SIZE_MEASURE") = IIf(Len(Trim(TxtSIZE_MEASURE.Text)) > 0, Trim(TxtSIZE_MEASURE.Text), 0)
                                            ds.Tables(0).Rows(0).Item("TONS") = IIf(Len(Trim(TxtTONS.Text)) > 0, Trim(TxtTONS.Text), 0)
                                            ds.Tables(0).Rows(0).Item("SENDER") = TxtSENDER.Text
                                            ds.Tables(0).Rows(0).Item("NOTIFY_PERSON") = TxtNOTIFY_PERSON.Text
                                            ds.Tables(0).Rows(0).Item("RECEIVER") = TxtRECEIVER.Text
                                            ds.Tables(0).Rows(0).Item("NETWEIGHT") = IIf(Len(Trim(TxtNETWEIGHT.Text)) > 0, Trim(TxtNETWEIGHT.Text), 0)
                                            ds.Tables(0).Rows(0).Item("CODE_PACK") = IIf(Len(Trim(CombCode_pack.SelectedValue)) > 0, Trim(CombCode_pack.SelectedValue), "000")
                                            ds.Tables(0).Rows(0).Item("CODE_Cargo") = IIf(Len(Trim(cbCargo.SelectedValue)) > 0, cbCargo.SelectedValue, "0000")
                                            If mark = "1" Then
                                                ds.Tables(0).Rows(0).Item("PIECE_WEIGHT") = TxtPIECE_WEIGHT.Text
                                            End If
                                            If Hatch_in = 0 Then
                                                ds.Tables(0).Rows(0).Item("UNLOAD_PORT") = IIf(Len(Trim(CombUNLOAD_PORT.SelectedValue)) > 0, CombUNLOAD_PORT.SelectedValue, "LYG")
                                                ds.Tables(0).Rows(0).Item("LOAD_PORT") = IIf(Len(Trim(CombLOAD_PORT.SelectedValue)) > 0, CombLOAD_PORT.SelectedValue, "00")
                                            ElseIf Hatch_in = 1 Then
                                                ds.Tables(0).Rows(0).Item("UNLOAD_PORT") = IIf(Len(Trim(CombUNLOAD_PORT.SelectedValue)) > 0, CombUNLOAD_PORT.SelectedValue, "00")
                                                ds.Tables(0).Rows(0).Item("LOAD_PORT") = IIf(Len(Trim(CombLOAD_PORT.SelectedValue)) > 0, CombLOAD_PORT.SelectedValue, "LYG")
                                            End If
                                            ds.Tables(0).Rows(0).Item("UNLOAD_PORT_CHA") = txtUnLoadPortCha.Text.Trim()
                                            ds.Tables(0).Rows(0).Item("UNLOAD_PORT_ENG") = txtUnLoadPortEng.Text.Trim()

                                            ds.Tables(0).Rows(0).Item("LOAD_PORT_CHA") = txtLoadPortCha.Text.Trim()
                                            ds.Tables(0).Rows(0).Item("LOAD_PORT_ENG") = txtLoadPortEng.Text.Trim()

                                            If CBACCESSORY.Checked = True Then
                                                ds.Tables(0).Rows(0).Item("ACCESSORY") = "1"
                                            Else
                                                ds.Tables(0).Rows(0).Item("ACCESSORY") = "0"
                                            End If
                                            If CheckBox1.Checked = True Then
                                                ds.Tables(0).Rows(0).Item("NON_THIS_PORT") = "1"
                                            Else
                                                ds.Tables(0).Rows(0).Item("NON_THIS_PORT") = "0"
                                            End If
                                            ds.Tables(0).Rows(0).Item("CODE_GOODS") = IIf(Len(Trim(combcode_goods.SelectedValue)) > 0, combcode_goods.SelectedValue, "0000")
                                            ds.Tables(0).Rows(0).Item("USER_NAME") = G_User

                                            sqlda.Update(ds)

                                            'MsgBox("舱单已改变，请修改相关计数单数据！")
                                            Call BTQUIT_Click(sender, e)

                                        End If
                                    End If
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
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
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
            txtamount_ori.Focus()
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
                    'dw = Getdata("SELECT * FROM CODE_port WHERE code_port like '%" & Trim(CombLOAD_PORT.SelectedValue) & "%' or port_cha like '%" & Trim(CombLOAD_PORT.Text) & "%' or port_eng like '%" & Trim(CombLOAD_PORT.Text) & "%'", DSSELECT)
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

    Private Sub cbCargo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbCargo.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtGOODS_ENG.Focus()
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
            txtUnLoadPortEng.Focus()
        End If
    End Sub

    Private Sub txtUnLoadPortEng_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnLoadPortEng.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtSENDER.Focus()
        End If
    End Sub

    Private Sub txtamount_ori_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamount_ori.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtGROSS_WEIGHT_ORI.Focus()
        End If
    End Sub

    Private Sub TxtGROSS_WEIGHT_ORI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGROSS_WEIGHT_ORI.KeyPress
        If e.KeyChar = Chr(13) Then
            CombLOAD_PORT.Focus()
        End If
    End Sub
End Class
