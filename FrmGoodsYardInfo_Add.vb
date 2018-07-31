Imports TALLY.DBControl
Public Class FrmGoodsYardInfo_Add
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        AddHandler txtShip.KeyDown, AddressOf FrmGoodsYardInfo_Add_KeyDown
        AddHandler txtVoyage.KeyDown, AddressOf FrmGoodsYardInfo_Add_KeyDown
        AddHandler txtBillNO.KeyDown, AddressOf FrmGoodsYardInfo_Add_KeyDown
        AddHandler txtMark.KeyDown, AddressOf FrmGoodsYardInfo_Add_KeyDown
        AddHandler txtDescCha.KeyDown, AddressOf FrmGoodsYardInfo_Add_KeyDown
        AddHandler txtDescEng.KeyDown, AddressOf FrmGoodsYardInfo_Add_KeyDown
        AddHandler txtAmount.KeyDown, AddressOf FrmGoodsYardInfo_Add_KeyDown
        AddHandler txtTotalWeight.KeyDown, AddressOf FrmGoodsYardInfo_Add_KeyDown
        AddHandler txtSize.KeyDown, AddressOf FrmGoodsYardInfo_Add_KeyDown
        AddHandler txtBargainNO.KeyDown, AddressOf FrmGoodsYardInfo_Add_KeyDown
        AddHandler txtReceiver.KeyDown, AddressOf FrmGoodsYardInfo_Add_KeyDown
        AddHandler cbGoodsCode.KeyDown, AddressOf FrmGoodsYardInfo_Add_KeyDown
        AddHandler cbConMark.KeyDown, AddressOf FrmGoodsYardInfo_Add_KeyDown
        AddHandler cbPack.KeyDown, AddressOf FrmGoodsYardInfo_Add_KeyDown
        AddHandler cbClient.KeyDown, AddressOf FrmGoodsYardInfo_Add_KeyDown

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
    Friend WithEvents txtMark As System.Windows.Forms.TextBox
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents txtTotalWeight As System.Windows.Forms.TextBox
    Friend WithEvents cbGoodsCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtDescEng As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
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
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtDescCha As System.Windows.Forms.TextBox
    Friend WithEvents txtBargainNO As System.Windows.Forms.TextBox
    Friend WithEvents cbConMark As System.Windows.Forms.ComboBox
    Friend WithEvents txtReceiver As System.Windows.Forms.TextBox
    Friend WithEvents cbPack As System.Windows.Forms.ComboBox
    Friend WithEvents txtSize As System.Windows.Forms.TextBox
    Friend WithEvents cbClient As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtMark = New System.Windows.Forms.TextBox()
        Me.txtBargainNO = New System.Windows.Forms.TextBox()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.cbConMark = New System.Windows.Forms.ComboBox()
        Me.txtTotalWeight = New System.Windows.Forms.TextBox()
        Me.cbGoodsCode = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtReceiver = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtDescEng = New System.Windows.Forms.TextBox()
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
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtDescCha = New System.Windows.Forms.TextBox()
        Me.cbClient = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(80, 74)
        Me.txtMark.MaxLength = 20
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(130, 21)
        Me.txtMark.TabIndex = 341
        Me.txtMark.Text = ""
        '
        'txtBargainNO
        '
        Me.txtBargainNO.Location = New System.Drawing.Point(292, 134)
        Me.txtBargainNO.MaxLength = 20
        Me.txtBargainNO.Name = "txtBargainNO"
        Me.txtBargainNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBargainNO.TabIndex = 345
        Me.txtBargainNO.Text = ""
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(254, 224)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 371
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(186, 224)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 370
        Me.btSave.Text = "确认"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(118, 224)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(65, 24)
        Me.btAdd.TabIndex = 369
        Me.btAdd.Text = "清空"
        '
        'cbConMark
        '
        Me.cbConMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConMark.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbConMark.Location = New System.Drawing.Point(292, 86)
        Me.cbConMark.Name = "cbConMark"
        Me.cbConMark.Size = New System.Drawing.Size(130, 20)
        Me.cbConMark.TabIndex = 372
        '
        'txtTotalWeight
        '
        Me.txtTotalWeight.Location = New System.Drawing.Point(292, 34)
        Me.txtTotalWeight.MaxLength = 10
        Me.txtTotalWeight.Name = "txtTotalWeight"
        Me.txtTotalWeight.TabIndex = 344
        Me.txtTotalWeight.Text = ""
        '
        'cbGoodsCode
        '
        Me.cbGoodsCode.Location = New System.Drawing.Point(80, 96)
        Me.cbGoodsCode.MaxDropDownItems = 20
        Me.cbGoodsCode.Name = "cbGoodsCode"
        Me.cbGoodsCode.Size = New System.Drawing.Size(130, 20)
        Me.cbGoodsCode.TabIndex = 342
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(6, 98)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 18)
        Me.Label17.TabIndex = 368
        Me.Label17.Text = "货名代码"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(218, 188)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 18)
        Me.Label16.TabIndex = 367
        Me.Label16.Text = "委托人"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReceiver
        '
        Me.txtReceiver.Location = New System.Drawing.Point(292, 160)
        Me.txtReceiver.MaxLength = 10
        Me.txtReceiver.Name = "txtReceiver"
        Me.txtReceiver.Size = New System.Drawing.Size(130, 21)
        Me.txtReceiver.TabIndex = 347
        Me.txtReceiver.Text = ""
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(218, 162)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 18)
        Me.Label15.TabIndex = 366
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
        Me.txtDescEng.TabIndex = 350
        Me.txtDescEng.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(218, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 18)
        Me.Label11.TabIndex = 362
        Me.Label11.Text = "总重量"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(292, 8)
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(130, 21)
        Me.txtAmount.TabIndex = 343
        Me.txtAmount.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(218, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 361
        Me.Label10.Text = "总件数"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 360
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
        Me.cbPack.TabIndex = 337
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(218, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 357
        Me.Label6.Text = "折装箱类别"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBillNO
        '
        Me.txtBillNO.Location = New System.Drawing.Point(80, 52)
        Me.txtBillNO.MaxLength = 20
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBillNO.TabIndex = 340
        Me.txtBillNO.Text = ""
        '
        'Label4
        '
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(6, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 356
        Me.Label4.Text = "提单号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(218, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 354
        Me.Label3.Text = "合同编号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(80, 30)
        Me.txtVoyage.MaxLength = 6
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(130, 21)
        Me.txtVoyage.TabIndex = 335
        Me.txtVoyage.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 353
        Me.Label1.Text = "航次"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShip
        '
        Me.txtShip.Location = New System.Drawing.Point(80, 8)
        Me.txtShip.MaxLength = 40
        Me.txtShip.Name = "txtShip"
        Me.txtShip.Size = New System.Drawing.Size(130, 21)
        Me.txtShip.TabIndex = 334
        Me.txtShip.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 352
        Me.Label2.Text = "中文船名"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(0, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 351
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(-2, 118)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 18)
        Me.Label12.TabIndex = 363
        Me.Label12.Text = "货物中文描述"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(-2, 168)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 18)
        Me.Label13.TabIndex = 364
        Me.Label13.Text = "货物英文描述"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(392, 36)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 20)
        Me.Label19.TabIndex = 378
        Me.Label19.Text = "公斤"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(392, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 20)
        Me.Label14.TabIndex = 381
        Me.Label14.Text = "立方"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(292, 60)
        Me.txtSize.MaxLength = 10
        Me.txtSize.Name = "txtSize"
        Me.txtSize.TabIndex = 379
        Me.txtSize.Text = ""
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(218, 62)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 18)
        Me.Label20.TabIndex = 380
        Me.Label20.Text = "体积尺寸"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(218, 112)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 18)
        Me.Label18.TabIndex = 382
        Me.Label18.Text = "包装"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDescCha
        '
        Me.txtDescCha.Location = New System.Drawing.Point(8, 136)
        Me.txtDescCha.MaxLength = 50
        Me.txtDescCha.Multiline = True
        Me.txtDescCha.Name = "txtDescCha"
        Me.txtDescCha.Size = New System.Drawing.Size(202, 30)
        Me.txtDescCha.TabIndex = 349
        Me.txtDescCha.Text = ""
        '
        'cbClient
        '
        Me.cbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClient.ItemHeight = 12
        Me.cbClient.Location = New System.Drawing.Point(292, 186)
        Me.cbClient.Name = "cbClient"
        Me.cbClient.Size = New System.Drawing.Size(130, 20)
        Me.cbClient.TabIndex = 383
        '
        'FrmGoodsYardInfo_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(430, 253)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbClient, Me.Label18, Me.Label14, Me.txtSize, Me.Label20, Me.Label19, Me.txtMark, Me.txtBargainNO, Me.btQuit, Me.btSave, Me.btAdd, Me.cbConMark, Me.txtTotalWeight, Me.cbGoodsCode, Me.Label17, Me.Label16, Me.txtReceiver, Me.Label15, Me.txtDescEng, Me.txtDescCha, Me.Label11, Me.txtAmount, Me.Label10, Me.Label9, Me.cbPack, Me.Label6, Me.txtBillNO, Me.Label4, Me.Label3, Me.txtVoyage, Me.Label1, Me.txtShip, Me.Label2, Me.txtID, Me.Label12, Me.Label13})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGoodsYardInfo_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "装拆箱场站收据信息 增加"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmGoodsYardInfo_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim sqlExist As String
        Try
            If Trim(txtShip.Text) <> "" And Trim(txtVoyage.Text) <> "" And Trim(txtBillNO.Text) <> "" And Me.cbClient.SelectedValue <> "00" Then
                Dim row As DataRow
                row = ds.Tables(0).NewRow
                If Trim(txtAmount.Text) <> "" Then
                    If IsNumeric(Trim(txtAmount.Text)) Then
                        row.Item("AMOUNT") = Trim(txtAmount.Text)
                    Else
                        MessageBox.Show("总件数应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtAmount.Focus()
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtTotalWeight.Text) <> "" Then
                    If IsNumeric(Trim(txtTotalWeight.Text)) Then
                        row.Item("TOTAL_WEIGHT") = Trim(txtTotalWeight.Text)
                    Else
                        MessageBox.Show("总重量应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtTotalWeight.Focus()
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtSize.Text) <> "" Then
                    If IsNumeric(Trim(txtSize.Text)) Then
                        row.Item("SIZE_MEASURE") = Trim(txtSize.Text)
                    Else
                        MessageBox.Show("体积尺寸应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtSize.Focus()
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                sqlExist = "select * from CON_LOAD_LIST where CONTRACT_NO = '" & Trim(txtBargainNO.Text) & _
                        "' and CHI_VESSEL = '" & Trim(txtShip.Text) & _
                        "' and VOYAGE = '" & Trim(txtVoyage.Text) & "'"
                If Filldata(sqlExist).Count = 0 Then
                    row.Item("CHI_VESSEL") = Trim(txtShip.Text)
                    row.Item("VOYAGE") = Trim(txtVoyage.Text)
                    row.Item("BLNO") = Trim(txtBillNO.Text)
                    row.Item("MARK") = Trim(txtMark.Text)
                    row.Item("Goods_Cha") = Trim(txtDescCha.Text)
                    row.Item("Goods_Eng") = Trim(txtDescEng.Text)
                    row.Item("CONTRACT_NO") = Trim(txtBargainNO.Text)
                    row.Item("RECEIVER") = Trim(txtReceiver.Text)

                    row.Item("CODE_GOODS") = cbGoodsCode.SelectedValue
                    row.Item("CONTAINER_MARK") = cbConMark.SelectedValue
                    row.Item("CODE_PACK") = cbPack.SelectedValue
                    row.Item("CLIENT") = cbClient.SelectedValue

                    row.Item("USER_NAME") = G_User
                    ds.Tables(0).Rows.Add(row)
                    sqlda.Update(ds)
                    Me.Close()
                Else
                    MessageBox.Show("船名 航次 提单号不可重复！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("船名 航次 提单号 委托人 不能为空。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        Me.txtShip.Clear()
        Me.txtVoyage.Clear()
        Me.txtBillNO.Clear()
        Me.txtMark.Clear()
        Me.txtDescCha.Clear()
        Me.txtDescEng.Clear()
        Me.txtAmount.Clear()
        Me.txtTotalWeight.Clear()
        Me.txtSize.Clear()
        Me.txtBargainNO.Clear()
        Me.txtReceiver.Clear()

        Me.cbGoodsCode.SelectedValue = ""
        Me.cbPack.SelectedValue = ""
        Me.cbConMark.SelectedValue = ""
        Me.cbClient.SelectedValue = ""
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub FrmGoodsYardInfo_Add_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtShip.Focused Then
                txtVoyage.Focus()
            ElseIf txtVoyage.Focused Then
                txtBillNO.Focus()
            ElseIf txtBillNO.Focused Then
                txtMark.Focus()
            ElseIf txtMark.Focused Then
                Me.cbGoodsCode.Focus()
            ElseIf Me.cbGoodsCode.Focused Then
                txtDescCha.Focus()
            ElseIf txtDescCha.Focused Then
                txtDescEng.Focus()
            ElseIf txtDescEng.Focused Then
                txtAmount.Focus()
            ElseIf txtAmount.Focused Then
                txtTotalWeight.Focus()
            ElseIf txtTotalWeight.Focused Then
                txtSize.Focus()
            ElseIf txtSize.Focused Then
                Me.cbConMark.Focus()
            ElseIf Me.cbConMark.Focused Then
                Me.cbPack.Focus()
            ElseIf Me.cbPack.Focused Then
                txtBargainNO.Focus()
            ElseIf txtBargainNO.Focused Then
                txtReceiver.Focus()
            ElseIf txtReceiver.Focused Then
                Me.cbClient.Focus()
            ElseIf Me.cbClient.Focused Then
                Me.btSave.Focus()
            End If
        End If
    End Sub
End Class
