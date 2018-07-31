Imports TALLY.DBControl
Public Class FrmGoodsYardInfo_Query
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
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
    Friend WithEvents cbClient As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtSize As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtMark As System.Windows.Forms.TextBox
    Friend WithEvents txtBargainNO As System.Windows.Forms.TextBox
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents cbConMark As System.Windows.Forms.ComboBox
    Friend WithEvents txtTotalWeight As System.Windows.Forms.TextBox
    Friend WithEvents cbGoodsCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtReceiver As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtDescEng As System.Windows.Forms.TextBox
    Friend WithEvents txtDescCha As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbPack As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBillNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtShip As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cbClient = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtMark = New System.Windows.Forms.TextBox()
        Me.txtBargainNO = New System.Windows.Forms.TextBox()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.cbConMark = New System.Windows.Forms.ComboBox()
        Me.txtTotalWeight = New System.Windows.Forms.TextBox()
        Me.cbGoodsCode = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtReceiver = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtDescEng = New System.Windows.Forms.TextBox()
        Me.txtDescCha = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbPack = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBillNO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVoyage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtShip = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbClient
        '
        Me.cbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClient.ItemHeight = 12
        Me.cbClient.Location = New System.Drawing.Point(292, 186)
        Me.cbClient.Name = "cbClient"
        Me.cbClient.Size = New System.Drawing.Size(130, 20)
        Me.cbClient.TabIndex = 454
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(218, 112)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 18)
        Me.Label18.TabIndex = 453
        Me.Label18.Text = "包装"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(392, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 20)
        Me.Label14.TabIndex = 452
        Me.Label14.Text = "立方"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(292, 60)
        Me.txtSize.MaxLength = 10
        Me.txtSize.Name = "txtSize"
        Me.txtSize.TabIndex = 450
        Me.txtSize.Text = ""
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(218, 62)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 18)
        Me.Label20.TabIndex = 451
        Me.Label20.Text = "体积尺寸"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(392, 36)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 20)
        Me.Label19.TabIndex = 449
        Me.Label19.Text = "公斤"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(80, 74)
        Me.txtMark.MaxLength = 20
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(130, 21)
        Me.txtMark.TabIndex = 424
        Me.txtMark.Text = ""
        '
        'txtBargainNO
        '
        Me.txtBargainNO.Location = New System.Drawing.Point(292, 134)
        Me.txtBargainNO.MaxLength = 20
        Me.txtBargainNO.Name = "txtBargainNO"
        Me.txtBargainNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBargainNO.TabIndex = 428
        Me.txtBargainNO.Text = ""
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(182, 224)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 447
        Me.btQuit.Text = "返回"
        '
        'cbConMark
        '
        Me.cbConMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConMark.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbConMark.Location = New System.Drawing.Point(292, 86)
        Me.cbConMark.Name = "cbConMark"
        Me.cbConMark.Size = New System.Drawing.Size(130, 20)
        Me.cbConMark.TabIndex = 448
        '
        'txtTotalWeight
        '
        Me.txtTotalWeight.Location = New System.Drawing.Point(292, 34)
        Me.txtTotalWeight.MaxLength = 10
        Me.txtTotalWeight.Name = "txtTotalWeight"
        Me.txtTotalWeight.TabIndex = 427
        Me.txtTotalWeight.Text = ""
        '
        'cbGoodsCode
        '
        Me.cbGoodsCode.Location = New System.Drawing.Point(80, 96)
        Me.cbGoodsCode.MaxDropDownItems = 20
        Me.cbGoodsCode.Name = "cbGoodsCode"
        Me.cbGoodsCode.Size = New System.Drawing.Size(130, 20)
        Me.cbGoodsCode.TabIndex = 425
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(6, 98)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 18)
        Me.Label17.TabIndex = 445
        Me.Label17.Text = "货名代码"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(218, 188)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 18)
        Me.Label16.TabIndex = 444
        Me.Label16.Text = "委托人"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReceiver
        '
        Me.txtReceiver.Location = New System.Drawing.Point(292, 160)
        Me.txtReceiver.MaxLength = 10
        Me.txtReceiver.Name = "txtReceiver"
        Me.txtReceiver.Size = New System.Drawing.Size(130, 21)
        Me.txtReceiver.TabIndex = 429
        Me.txtReceiver.Text = ""
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(218, 162)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 18)
        Me.Label15.TabIndex = 443
        Me.Label15.Text = "受货人"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDescEng
        '
        Me.txtDescEng.Location = New System.Drawing.Point(8, 186)
        Me.txtDescEng.MaxLength = 50
        Me.txtDescEng.Multiline = True
        Me.txtDescEng.Name = "txtDescEng"
        Me.txtDescEng.Size = New System.Drawing.Size(202, 30)
        Me.txtDescEng.TabIndex = 431
        Me.txtDescEng.Text = ""
        '
        'txtDescCha
        '
        Me.txtDescCha.Location = New System.Drawing.Point(8, 136)
        Me.txtDescCha.MaxLength = 50
        Me.txtDescCha.Multiline = True
        Me.txtDescCha.Name = "txtDescCha"
        Me.txtDescCha.Size = New System.Drawing.Size(202, 30)
        Me.txtDescCha.TabIndex = 430
        Me.txtDescCha.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(218, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 18)
        Me.Label11.TabIndex = 440
        Me.Label11.Text = "总重量"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(292, 8)
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(130, 21)
        Me.txtAmount.TabIndex = 426
        Me.txtAmount.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(218, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 439
        Me.Label10.Text = "总件数"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 438
        Me.Label9.Text = "标志"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbPack
        '
        Me.cbPack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPack.ItemHeight = 12
        Me.cbPack.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbPack.Location = New System.Drawing.Point(292, 110)
        Me.cbPack.Name = "cbPack"
        Me.cbPack.Size = New System.Drawing.Size(130, 20)
        Me.cbPack.TabIndex = 422
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(218, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 437
        Me.Label6.Text = "折装箱类别"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBillNO
        '
        Me.txtBillNO.Location = New System.Drawing.Point(80, 52)
        Me.txtBillNO.MaxLength = 20
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBillNO.TabIndex = 423
        Me.txtBillNO.Text = ""
        '
        'Label4
        '
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(6, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 436
        Me.Label4.Text = "提单号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(218, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 435
        Me.Label3.Text = "合同编号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(80, 30)
        Me.txtVoyage.MaxLength = 6
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(130, 21)
        Me.txtVoyage.TabIndex = 421
        Me.txtVoyage.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 434
        Me.Label1.Text = "航次"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShip
        '
        Me.txtShip.Location = New System.Drawing.Point(80, 8)
        Me.txtShip.MaxLength = 40
        Me.txtShip.Name = "txtShip"
        Me.txtShip.Size = New System.Drawing.Size(130, 21)
        Me.txtShip.TabIndex = 420
        Me.txtShip.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 433
        Me.Label2.Text = "中文船名"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(0, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 432
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(-2, 118)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 18)
        Me.Label12.TabIndex = 441
        Me.Label12.Text = "货物中文描述"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(-2, 168)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 18)
        Me.Label13.TabIndex = 442
        Me.Label13.Text = "货物英文描述"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmGoodsYardInfo_Query
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(430, 253)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbClient, Me.Label18, Me.Label14, Me.txtSize, Me.Label20, Me.Label19, Me.txtMark, Me.txtBargainNO, Me.btQuit, Me.cbConMark, Me.txtTotalWeight, Me.cbGoodsCode, Me.Label17, Me.Label16, Me.txtReceiver, Me.Label15, Me.txtDescEng, Me.txtDescCha, Me.Label11, Me.txtAmount, Me.Label10, Me.Label9, Me.cbPack, Me.Label6, Me.txtBillNO, Me.Label4, Me.Label3, Me.txtVoyage, Me.Label1, Me.txtShip, Me.Label2, Me.txtID, Me.Label12, Me.Label13})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGoodsYardInfo_Query"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "装拆箱场站收据信息 查看"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmGoodsYardInfo_Query_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim dvCodeGoods As New DataView()
        Dim sqlstr, sqlCodeGoods As String
        Me.StartPosition = FormStartPosition.CenterScreen

        sqlCodeGoods = "select Code,Goods from CodeGoods "
        dvCodeGoods = Filldata(sqlCodeGoods)
        cbGoodsCode.DataSource = dvCodeGoods
        cbGoodsCode.DisplayMember = "Goods"
        cbGoodsCode.ValueMember = "Code"

        Dim sqlConLoadType As String
        Dim dvConLoadType As New DataView()
        sqlConLoadType = "select Code_Tally_Type,Name_Tally_Type from Code_Tally_Type  "
        dvConLoadType = Filldata(sqlConLoadType)
        cbConMark.DataSource = dvConLoadType
        cbConMark.DisplayMember = "Name_Tally_Type"
        cbConMark.ValueMember = "Code_Tally_Type"

        Dim sqlPack As String
        Dim dvPack As New DataView()
        sqlPack = "SELECT CODE_PACK, PACK_CHA, PACK_ENG FROM CODE_PACK ORDER BY px"
        dvPack = Filldata(sqlPack)
        cbPack.DataSource = dvPack
        cbPack.DisplayMember = "PACK_CHA"
        cbPack.ValueMember = "CODE_PACK"

        Dim sqlConsign As String
        'sqlConsign = "SELECT CODE_CONSIGN_CON, CONSIGN_CON FROM CODE_CONSIGN_CON ORDER BY CONSIGN_CON"
        sqlConsign = "SELECT CODE_SHIP_AGENT, SHIPAGENT_CHA, SHIPAGENT_ENG FROM CODE_SHIP_AGENT ORDER BY CODE_SHIP_AGENT"
        cbClient.DataSource = Filldata(sqlConsign)
        cbClient.DisplayMember = "SHIPAGENT_CHA"
        cbClient.ValueMember = "CODE_SHIP_AGENT"

        sqlstr = "select * from CON_LOAD_LIST where CON_LOAD_LIST_ID =" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("CON_LOAD_LIST_ID")
            txtShip.Text = ds.Tables(0).Rows(0).Item("CHI_VESSEL")
            txtVoyage.Text = ds.Tables(0).Rows(0).Item("VOYAGE")
            txtBillNO.Text = ds.Tables(0).Rows(0).Item("BLNO")
            txtMark.Text = ds.Tables(0).Rows(0).Item("MARK")
            txtDescCha.Text = ds.Tables(0).Rows(0).Item("Goods_Cha")
            txtDescEng.Text = ds.Tables(0).Rows(0).Item("Goods_Eng")
            txtAmount.Text = ds.Tables(0).Rows(0).Item("AMOUNT")
            txtTotalWeight.Text = ds.Tables(0).Rows(0).Item("TOTAL_WEIGHT")
            txtSize.Text = ds.Tables(0).Rows(0).Item("SIZE_MEASURE")
            txtBargainNO.Text = ds.Tables(0).Rows(0).Item("CONTRACT_NO")
            txtReceiver.Text = ds.Tables(0).Rows(0).Item("RECEIVER")

            cbGoodsCode.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_GOODS")
            cbConMark.SelectedValue = ds.Tables(0).Rows(0).Item("CONTAINER_MARK")
            cbPack.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_PACK")
            cbClient.SelectedValue = ds.Tables(0).Rows(0).Item("CLIENT")
        End If
        txtShip.Focus()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
