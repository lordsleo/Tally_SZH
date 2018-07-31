Imports TALLY.DBControl
Public Class FrmCargo_hatch_list_delete
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dw As New DataView()
    Dim dsport1 As New DataSet()
    Dim dsport2 As New DataSet()
    Dim dsgoods As New DataSet()
    Dim dspack As New DataSet()


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
    Friend WithEvents BTDelete As System.Windows.Forms.Button
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCargo_hatch_list_delete))
        Me.BTQUIT = New System.Windows.Forms.Button
        Me.BTDelete = New System.Windows.Forms.Button
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
        Me.SuspendLayout()
        '
        'BTQUIT
        '
        Me.BTQUIT.BackColor = System.Drawing.Color.Transparent
        Me.BTQUIT.Location = New System.Drawing.Point(242, 240)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 69
        Me.BTQUIT.Text = "取消"
        '
        'BTDelete
        '
        Me.BTDelete.BackColor = System.Drawing.Color.Transparent
        Me.BTDelete.Location = New System.Drawing.Point(168, 240)
        Me.BTDelete.Name = "BTDelete"
        Me.BTDelete.Size = New System.Drawing.Size(65, 24)
        Me.BTDelete.TabIndex = 68
        Me.BTDelete.Text = "确认"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label20.Location = New System.Drawing.Point(423, 34)
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
        Me.Label19.Location = New System.Drawing.Point(435, 62)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 22)
        Me.Label19.TabIndex = 104
        Me.Label19.Text = "公斤"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.Location = New System.Drawing.Point(435, 6)
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
        Me.Label10.Location = New System.Drawing.Point(205, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 22)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "公斤"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CombCode_pack
        '
        Me.CombCode_pack.Enabled = False
        Me.CombCode_pack.Location = New System.Drawing.Point(93, 176)
        Me.CombCode_pack.Name = "CombCode_pack"
        Me.CombCode_pack.Size = New System.Drawing.Size(142, 20)
        Me.CombCode_pack.TabIndex = 101
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(9, 174)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 24)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "包装"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'combcode_goods
        '
        Me.combcode_goods.Enabled = False
        Me.combcode_goods.Location = New System.Drawing.Point(93, 64)
        Me.combcode_goods.Name = "combcode_goods"
        Me.combcode_goods.Size = New System.Drawing.Size(142, 20)
        Me.combcode_goods.TabIndex = 99
        '
        'CombUNLOAD_PORT
        '
        Me.CombUNLOAD_PORT.Enabled = False
        Me.CombUNLOAD_PORT.Location = New System.Drawing.Point(323, 120)
        Me.CombUNLOAD_PORT.Name = "CombUNLOAD_PORT"
        Me.CombUNLOAD_PORT.Size = New System.Drawing.Size(142, 20)
        Me.CombUNLOAD_PORT.TabIndex = 98
        '
        'CombLOAD_PORT
        '
        Me.CombLOAD_PORT.Enabled = False
        Me.CombLOAD_PORT.Location = New System.Drawing.Point(323, 92)
        Me.CombLOAD_PORT.Name = "CombLOAD_PORT"
        Me.CombLOAD_PORT.Size = New System.Drawing.Size(142, 20)
        Me.CombLOAD_PORT.TabIndex = 97
        '
        'TxtGOODS_CHA
        '
        Me.TxtGOODS_CHA.Enabled = False
        Me.TxtGOODS_CHA.Location = New System.Drawing.Point(93, 118)
        Me.TxtGOODS_CHA.MaxLength = 30
        Me.TxtGOODS_CHA.Name = "TxtGOODS_CHA"
        Me.TxtGOODS_CHA.Size = New System.Drawing.Size(142, 21)
        Me.TxtGOODS_CHA.TabIndex = 96
        Me.TxtGOODS_CHA.Text = ""
        '
        'TxtGOODS_ENG
        '
        Me.TxtGOODS_ENG.Enabled = False
        Me.TxtGOODS_ENG.Location = New System.Drawing.Point(93, 90)
        Me.TxtGOODS_ENG.MaxLength = 30
        Me.TxtGOODS_ENG.Name = "TxtGOODS_ENG"
        Me.TxtGOODS_ENG.Size = New System.Drawing.Size(142, 21)
        Me.TxtGOODS_ENG.TabIndex = 95
        Me.TxtGOODS_ENG.Text = ""
        '
        'TxtAMOUNT
        '
        Me.TxtAMOUNT.Enabled = False
        Me.TxtAMOUNT.Location = New System.Drawing.Point(93, 146)
        Me.TxtAMOUNT.Name = "TxtAMOUNT"
        Me.TxtAMOUNT.Size = New System.Drawing.Size(142, 21)
        Me.TxtAMOUNT.TabIndex = 94
        Me.TxtAMOUNT.Text = ""
        '
        'TxtRECEIVER
        '
        Me.TxtRECEIVER.Enabled = False
        Me.TxtRECEIVER.Location = New System.Drawing.Point(323, 202)
        Me.TxtRECEIVER.MaxLength = 30
        Me.TxtRECEIVER.Name = "TxtRECEIVER"
        Me.TxtRECEIVER.Size = New System.Drawing.Size(142, 21)
        Me.TxtRECEIVER.TabIndex = 93
        Me.TxtRECEIVER.Text = ""
        '
        'TxtNOTIFY_PERSON
        '
        Me.TxtNOTIFY_PERSON.Enabled = False
        Me.TxtNOTIFY_PERSON.Location = New System.Drawing.Point(323, 174)
        Me.TxtNOTIFY_PERSON.MaxLength = 30
        Me.TxtNOTIFY_PERSON.Name = "TxtNOTIFY_PERSON"
        Me.TxtNOTIFY_PERSON.Size = New System.Drawing.Size(142, 21)
        Me.TxtNOTIFY_PERSON.TabIndex = 92
        Me.TxtNOTIFY_PERSON.Text = ""
        '
        'TxtSENDER
        '
        Me.TxtSENDER.Enabled = False
        Me.TxtSENDER.Location = New System.Drawing.Point(323, 146)
        Me.TxtSENDER.MaxLength = 30
        Me.TxtSENDER.Name = "TxtSENDER"
        Me.TxtSENDER.Size = New System.Drawing.Size(142, 21)
        Me.TxtSENDER.TabIndex = 91
        Me.TxtSENDER.Text = ""
        '
        'TxtTONS
        '
        Me.TxtTONS.Enabled = False
        Me.TxtTONS.Location = New System.Drawing.Point(323, 62)
        Me.TxtTONS.Name = "TxtTONS"
        Me.TxtTONS.Size = New System.Drawing.Size(112, 21)
        Me.TxtTONS.TabIndex = 90
        Me.TxtTONS.Text = ""
        '
        'TxtSIZE_MEASURE
        '
        Me.TxtSIZE_MEASURE.Enabled = False
        Me.TxtSIZE_MEASURE.Location = New System.Drawing.Point(323, 34)
        Me.TxtSIZE_MEASURE.Name = "TxtSIZE_MEASURE"
        Me.TxtSIZE_MEASURE.TabIndex = 89
        Me.TxtSIZE_MEASURE.Text = ""
        '
        'TxtGROSS_WEIGHT
        '
        Me.TxtGROSS_WEIGHT.Enabled = False
        Me.TxtGROSS_WEIGHT.Location = New System.Drawing.Point(323, 6)
        Me.TxtGROSS_WEIGHT.Name = "TxtGROSS_WEIGHT"
        Me.TxtGROSS_WEIGHT.Size = New System.Drawing.Size(112, 21)
        Me.TxtGROSS_WEIGHT.TabIndex = 88
        Me.TxtGROSS_WEIGHT.Text = ""
        '
        'TxtNETWEIGHT
        '
        Me.TxtNETWEIGHT.Enabled = False
        Me.TxtNETWEIGHT.Location = New System.Drawing.Point(93, 202)
        Me.TxtNETWEIGHT.Name = "TxtNETWEIGHT"
        Me.TxtNETWEIGHT.Size = New System.Drawing.Size(112, 21)
        Me.TxtNETWEIGHT.TabIndex = 87
        Me.TxtNETWEIGHT.Text = ""
        '
        'TxtMARK
        '
        Me.TxtMARK.Enabled = False
        Me.TxtMARK.Location = New System.Drawing.Point(93, 36)
        Me.TxtMARK.MaxLength = 30
        Me.TxtMARK.Name = "TxtMARK"
        Me.TxtMARK.Size = New System.Drawing.Size(142, 21)
        Me.TxtMARK.TabIndex = 86
        Me.TxtMARK.Text = ""
        '
        'txtBLNO
        '
        Me.txtBLNO.Enabled = False
        Me.txtBLNO.Location = New System.Drawing.Point(93, 6)
        Me.txtBLNO.MaxLength = 20
        Me.txtBLNO.Name = "txtBLNO"
        Me.txtBLNO.Size = New System.Drawing.Size(142, 21)
        Me.txtBLNO.TabIndex = 85
        Me.txtBLNO.Text = ""
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(9, 118)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 24)
        Me.Label18.TabIndex = 84
        Me.Label18.Text = "货物中文描述"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(9, 90)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 24)
        Me.Label17.TabIndex = 83
        Me.Label17.Text = "货物英文描述"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(9, 62)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 24)
        Me.Label16.TabIndex = 82
        Me.Label16.Text = "货类名称"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(9, 146)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 24)
        Me.Label15.TabIndex = 81
        Me.Label15.Text = "件数"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(9, 34)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 24)
        Me.Label14.TabIndex = 80
        Me.Label14.Text = "唛头"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(239, 118)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 24)
        Me.Label13.TabIndex = 79
        Me.Label13.Text = "卸货港"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(239, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 24)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "装货港"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(239, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 24)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "收货人"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(239, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 24)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "通知方"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(239, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 24)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "发货人"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(239, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 24)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "衡重"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(239, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 24)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "体积尺寸"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(239, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 24)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "毛重"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(9, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "净重"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(9, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 24)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "提单/装单号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCargo_hatch_list_delete
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(474, 283)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CombCode_pack)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.combcode_goods)
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
        Me.Controls.Add(Me.BTQUIT)
        Me.Controls.Add(Me.BTDelete)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargo_hatch_list_delete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "件杂货进口舱单_删除"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCargo_hatch_list_delete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim sqlstr As String
        If Hatch_in = 0 Then
            Me.Text = "件杂货进口舱单_删除"
        ElseIf Hatch_in = 1 Then
            Me.Text = "件杂货出口装货单_删除"
        End If

        dw = Getdata("select PORT_CHA+' '+isnull(PORT_ENG,' ') as port,CODE_PORT from code_port order by port ", dsport1)
        CombLOAD_PORT.DataSource = dsport1.Tables(0).DefaultView
        CombLOAD_PORT.DisplayMember = "port"
        CombLOAD_PORT.ValueMember = "CODE_PORT"

        dw = Getdata("select PORT_CHA+' '+isnull(PORT_ENG,' ') as port,CODE_PORT from code_port order by port ", dsport2)
        CombUNLOAD_PORT.DataSource = dsport2.Tables(0).DefaultView
        CombUNLOAD_PORT.DisplayMember = "port"
        CombUNLOAD_PORT.ValueMember = "CODE_PORT"

        dw = Getdata("select CODE_GOODS,GOODS_CHA+' '+ISNULL(GOODS_ENG,' ') as goods from code_cargo order by goods ", dsgoods)
        combcode_goods.DataSource = dsgoods.Tables(0).DefaultView
        combcode_goods.DisplayMember = "goods"
        combcode_goods.ValueMember = "CODE_GOODS"

        dw = Getdata("select code_pack,pack_cha+' '+isnull(pack_eng,' ') as pack from code_pack order by px ", dspack)
        CombCode_pack.DataSource = dspack.Tables(0).DefaultView
        CombCode_pack.DisplayMember = "pack"
        CombCode_pack.ValueMember = "code_pack"

        sqlstr = "select * from cargo_hatch_list where cargo_hatch_list_id='" & ID & "'"
        Updatedata(sqlda, sqlstr, ds)
        If ds.Tables(0).DefaultView.Count > 0 Then
            txtBLNO.Text = ds.Tables(0).Rows(0).Item("blno")
            TxtMARK.Text = ds.Tables(0).Rows(0).Item("MARK")
            TxtAMOUNT.Text = ds.Tables(0).Rows(0).Item("AMOUNT")
            TxtGOODS_ENG.Text = ds.Tables(0).Rows(0).Item("GOODS_ENG")
            TxtGOODS_CHA.Text = ds.Tables(0).Rows(0).Item("GOODS_CHA")
            TxtNETWEIGHT.Text = ds.Tables(0).Rows(0).Item("NETWEIGHT")
            TxtGROSS_WEIGHT.Text = ds.Tables(0).Rows(0).Item("GROSS_WEIGHT")
            TxtSIZE_MEASURE.Text = ds.Tables(0).Rows(0).Item("SIZE_MEASURE")
            TxtTONS.Text = ds.Tables(0).Rows(0).Item("TONS")
            TxtSENDER.Text = ds.Tables(0).Rows(0).Item("SENDER")
            TxtNOTIFY_PERSON.Text = ds.Tables(0).Rows(0).Item("NOTIFY_PERSON")
            TxtRECEIVER.Text = ds.Tables(0).Rows(0).Item("RECEIVER")
            CombCode_pack.SelectedValue = ds.Tables(0).Rows(0).Item("code_pack")
            combcode_goods.SelectedValue = ds.Tables(0).Rows(0).Item("code_goods")
            CombLOAD_PORT.SelectedValue = ds.Tables(0).Rows(0).Item("load_port")
            CombUNLOAD_PORT.SelectedValue = ds.Tables(0).Rows(0).Item("unload_port")
        End If
        txtBLNO.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub


    Private Sub BTDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTDelete.Click
        If MsgBox("确认要删除吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
            Call OperateHistory(G_DeptName, Now, G_User, "删除", "cargo_hatch_list", ID, "cargo_hatch_list_id")
            ds.Tables(0).Rows(0).Delete()
            sqlda.Update(ds)
            MsgBox("舱单已改变，请修改相关计数单数据！")
            Call BTQUIT_Click(sender, e)

        End If
    End Sub

    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub
End Class
