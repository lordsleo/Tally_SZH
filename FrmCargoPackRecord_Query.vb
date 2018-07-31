Imports TALLY.DBControl
Public Class FrmCargoPackRecord_Query
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()

    Dim dwCompany As New DataView()
    Dim dwBillNo As New DataView()
    Dim dwCodeGoods As New DataView()
    Dim sqlCodeGoods, sqlBillNo, sqlCompany As String

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
    Friend WithEvents txtPackWeight_M As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPackAmount_M As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPackWeight_P As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtPackAmount_P As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cbBillNo As System.Windows.Forms.ComboBox
    Friend WithEvents txtTestAmount_P As System.Windows.Forms.TextBox
    Friend WithEvents cbCompany As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents cbGoodsCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtLeastWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtTestAmount_M As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtEligibleAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDiseligibleAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAverageWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtStandWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMostWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSeem As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEligibleRate As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtPackWeight_M = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPackAmount_M = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPackWeight_P = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtPackAmount_P = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbBillNo = New System.Windows.Forms.ComboBox()
        Me.txtTestAmount_P = New System.Windows.Forms.TextBox()
        Me.cbCompany = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.cbGoodsCode = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtLeastWeight = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTestAmount_M = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtEligibleAmount = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDiseligibleAmount = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAverageWeight = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtStandWeight = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpTimeEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpTimeBegin = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMostWeight = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSeem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEligibleRate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPackWeight_M
        '
        Me.txtPackWeight_M.Location = New System.Drawing.Point(80, 138)
        Me.txtPackWeight_M.MaxLength = 10
        Me.txtPackWeight_M.Name = "txtPackWeight_M"
        Me.txtPackWeight_M.Size = New System.Drawing.Size(90, 21)
        Me.txtPackWeight_M.TabIndex = 432
        Me.txtPackWeight_M.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 466
        Me.Label6.Text = "机器灌包重"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPackAmount_M
        '
        Me.txtPackAmount_M.Location = New System.Drawing.Point(80, 94)
        Me.txtPackAmount_M.MaxLength = 10
        Me.txtPackAmount_M.Name = "txtPackAmount_M"
        Me.txtPackAmount_M.Size = New System.Drawing.Size(120, 21)
        Me.txtPackAmount_M.TabIndex = 430
        Me.txtPackAmount_M.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 465
        Me.Label5.Text = "机器灌包数"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPackWeight_P
        '
        Me.txtPackWeight_P.Location = New System.Drawing.Point(80, 116)
        Me.txtPackWeight_P.MaxLength = 10
        Me.txtPackWeight_P.Name = "txtPackWeight_P"
        Me.txtPackWeight_P.Size = New System.Drawing.Size(90, 21)
        Me.txtPackWeight_P.TabIndex = 431
        Me.txtPackWeight_P.Text = ""
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(6, 116)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 20)
        Me.Label22.TabIndex = 464
        Me.Label22.Text = "人力灌包重"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPackAmount_P
        '
        Me.txtPackAmount_P.Location = New System.Drawing.Point(80, 72)
        Me.txtPackAmount_P.MaxLength = 10
        Me.txtPackAmount_P.Name = "txtPackAmount_P"
        Me.txtPackAmount_P.Size = New System.Drawing.Size(120, 21)
        Me.txtPackAmount_P.TabIndex = 429
        Me.txtPackAmount_P.Text = ""
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(6, 72)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 20)
        Me.Label23.TabIndex = 463
        Me.Label23.Text = "人力灌包数"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbBillNo
        '
        Me.cbBillNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBillNo.Location = New System.Drawing.Point(80, 6)
        Me.cbBillNo.Name = "cbBillNo"
        Me.cbBillNo.Size = New System.Drawing.Size(120, 20)
        Me.cbBillNo.TabIndex = 426
        '
        'txtTestAmount_P
        '
        Me.txtTestAmount_P.Location = New System.Drawing.Point(80, 204)
        Me.txtTestAmount_P.MaxLength = 10
        Me.txtTestAmount_P.Name = "txtTestAmount_P"
        Me.txtTestAmount_P.Size = New System.Drawing.Size(120, 21)
        Me.txtTestAmount_P.TabIndex = 435
        Me.txtTestAmount_P.Text = ""
        '
        'cbCompany
        '
        Me.cbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCompany.Location = New System.Drawing.Point(80, 50)
        Me.cbCompany.Name = "cbCompany"
        Me.cbCompany.Size = New System.Drawing.Size(120, 20)
        Me.cbCompany.TabIndex = 428
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(6, 50)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 20)
        Me.Label18.TabIndex = 461
        Me.Label18.Text = "装卸公司"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(170, 254)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 446
        Me.btQuit.Text = "返回"
        '
        'cbGoodsCode
        '
        Me.cbGoodsCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGoodsCode.Location = New System.Drawing.Point(80, 28)
        Me.cbGoodsCode.Name = "cbGoodsCode"
        Me.cbGoodsCode.Size = New System.Drawing.Size(120, 20)
        Me.cbGoodsCode.TabIndex = 427
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(6, 28)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 20)
        Me.Label17.TabIndex = 460
        Me.Label17.Text = "货名代码"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLeastWeight
        '
        Me.txtLeastWeight.Location = New System.Drawing.Point(278, 72)
        Me.txtLeastWeight.MaxLength = 10
        Me.txtLeastWeight.Name = "txtLeastWeight"
        Me.txtLeastWeight.Size = New System.Drawing.Size(90, 21)
        Me.txtLeastWeight.TabIndex = 440
        Me.txtLeastWeight.Text = ""
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(204, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 20)
        Me.Label16.TabIndex = 459
        Me.Label16.Text = "最低件重"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTestAmount_M
        '
        Me.txtTestAmount_M.Location = New System.Drawing.Point(80, 226)
        Me.txtTestAmount_M.MaxLength = 10
        Me.txtTestAmount_M.Name = "txtTestAmount_M"
        Me.txtTestAmount_M.Size = New System.Drawing.Size(120, 21)
        Me.txtTestAmount_M.TabIndex = 436
        Me.txtTestAmount_M.Text = ""
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(6, 226)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 20)
        Me.Label15.TabIndex = 458
        Me.Label15.Text = "机器抽检数"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEligibleAmount
        '
        Me.txtEligibleAmount.Location = New System.Drawing.Point(278, 94)
        Me.txtEligibleAmount.MaxLength = 10
        Me.txtEligibleAmount.Name = "txtEligibleAmount"
        Me.txtEligibleAmount.Size = New System.Drawing.Size(120, 21)
        Me.txtEligibleAmount.TabIndex = 441
        Me.txtEligibleAmount.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(204, 116)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 20)
        Me.Label13.TabIndex = 457
        Me.Label13.Text = "不合格件数"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDiseligibleAmount
        '
        Me.txtDiseligibleAmount.Location = New System.Drawing.Point(278, 116)
        Me.txtDiseligibleAmount.MaxLength = 10
        Me.txtDiseligibleAmount.Name = "txtDiseligibleAmount"
        Me.txtDiseligibleAmount.Size = New System.Drawing.Size(120, 21)
        Me.txtDiseligibleAmount.TabIndex = 442
        Me.txtDiseligibleAmount.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(204, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 20)
        Me.Label12.TabIndex = 456
        Me.Label12.Text = "合格件数"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAverageWeight
        '
        Me.txtAverageWeight.Location = New System.Drawing.Point(278, 28)
        Me.txtAverageWeight.MaxLength = 10
        Me.txtAverageWeight.Name = "txtAverageWeight"
        Me.txtAverageWeight.Size = New System.Drawing.Size(90, 21)
        Me.txtAverageWeight.TabIndex = 438
        Me.txtAverageWeight.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(204, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 20)
        Me.Label11.TabIndex = 455
        Me.Label11.Text = "平均件重"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStandWeight
        '
        Me.txtStandWeight.Location = New System.Drawing.Point(278, 6)
        Me.txtStandWeight.MaxLength = 10
        Me.txtStandWeight.Name = "txtStandWeight"
        Me.txtStandWeight.Size = New System.Drawing.Size(90, 21)
        Me.txtStandWeight.TabIndex = 437
        Me.txtStandWeight.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(204, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 20)
        Me.Label10.TabIndex = 454
        Me.Label10.Text = "标准件重"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeEnd
        '
        Me.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeEnd.Location = New System.Drawing.Point(80, 182)
        Me.dtpTimeEnd.Name = "dtpTimeEnd"
        Me.dtpTimeEnd.Size = New System.Drawing.Size(120, 21)
        Me.dtpTimeEnd.TabIndex = 434
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 453
        Me.Label8.Text = "作业止时间"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeBegin
        '
        Me.dtpTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeBegin.Location = New System.Drawing.Point(80, 160)
        Me.dtpTimeBegin.Name = "dtpTimeBegin"
        Me.dtpTimeBegin.Size = New System.Drawing.Size(120, 21)
        Me.dtpTimeBegin.TabIndex = 433
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 452
        Me.Label7.Text = "作业起时间"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(6, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 451
        Me.Label4.Text = "提单号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMostWeight
        '
        Me.txtMostWeight.Location = New System.Drawing.Point(278, 50)
        Me.txtMostWeight.MaxLength = 10
        Me.txtMostWeight.Name = "txtMostWeight"
        Me.txtMostWeight.Size = New System.Drawing.Size(90, 21)
        Me.txtMostWeight.TabIndex = 439
        Me.txtMostWeight.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(204, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 450
        Me.Label3.Text = "最高件重"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSeem
        '
        Me.txtSeem.Location = New System.Drawing.Point(204, 182)
        Me.txtSeem.MaxLength = 50
        Me.txtSeem.Multiline = True
        Me.txtSeem.Name = "txtSeem"
        Me.txtSeem.Size = New System.Drawing.Size(194, 42)
        Me.txtSeem.TabIndex = 444
        Me.txtSeem.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(204, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 449
        Me.Label1.Text = "缝口质量"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEligibleRate
        '
        Me.txtEligibleRate.Enabled = False
        Me.txtEligibleRate.Location = New System.Drawing.Point(278, 138)
        Me.txtEligibleRate.MaxLength = 10
        Me.txtEligibleRate.Name = "txtEligibleRate"
        Me.txtEligibleRate.Size = New System.Drawing.Size(90, 21)
        Me.txtEligibleRate.TabIndex = 443
        Me.txtEligibleRate.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(204, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 448
        Me.Label2.Text = "抽检合格率"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 447
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(6, 204)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 20)
        Me.Label20.TabIndex = 462
        Me.Label20.Text = "人力抽检数"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(368, 138)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(30, 20)
        Me.Label25.TabIndex = 507
        Me.Label25.Text = "%"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(368, 72)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(30, 20)
        Me.Label21.TabIndex = 506
        Me.Label21.Text = "公斤"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(368, 50)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(30, 20)
        Me.Label24.TabIndex = 505
        Me.Label24.Text = "公斤"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(368, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 20)
        Me.Label14.TabIndex = 504
        Me.Label14.Text = "公斤"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(368, 6)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 20)
        Me.Label19.TabIndex = 503
        Me.Label19.Text = "公斤"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(170, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 20)
        Me.Label9.TabIndex = 502
        Me.Label9.Text = "公斤"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(170, 116)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(30, 20)
        Me.Label35.TabIndex = 501
        Me.Label35.Text = "公斤"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmCargoPackRecord_Query
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(404, 281)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label25, Me.Label21, Me.Label24, Me.Label14, Me.Label19, Me.Label9, Me.Label35, Me.txtPackWeight_M, Me.Label6, Me.txtPackAmount_M, Me.Label5, Me.txtPackWeight_P, Me.Label22, Me.txtPackAmount_P, Me.Label23, Me.cbBillNo, Me.txtTestAmount_P, Me.cbCompany, Me.Label18, Me.btQuit, Me.cbGoodsCode, Me.Label17, Me.txtLeastWeight, Me.Label16, Me.txtTestAmount_M, Me.Label15, Me.txtEligibleAmount, Me.Label13, Me.txtDiseligibleAmount, Me.Label12, Me.txtAverageWeight, Me.Label11, Me.txtStandWeight, Me.Label10, Me.dtpTimeEnd, Me.Label8, Me.dtpTimeBegin, Me.Label7, Me.Label4, Me.txtMostWeight, Me.Label3, Me.txtSeem, Me.Label1, Me.txtEligibleRate, Me.Label2, Me.txtID, Me.Label20})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargoPackRecord_Query"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "散货灌包交接单信息 查看"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCargoPackRecord_Query_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dw As New DataView()
        Dim sqlstr As String
        Try
            sqlCodeGoods = "SELECT DISTINCT CODE_GOODS, GOODS FROM View_CargoGoodsPub WHERE SHIP_ID = '" & Ship_ID & "'"
            sqlCompany = "SELECT DISTINCT CompCode, DepartMent FROM View_CargoGoodsPub WHERE SHIP_ID = '" & Ship_ID & "'"
            sqlBillNo = "SELECT DISTINCT BLNO FROM View_CargoGoodsPub WHERE SHIP_ID = '" & Ship_ID & "'"

            dwBillNo = Filldata(sqlBillNo)
            dwCodeGoods = Filldata(sqlCodeGoods)
            dwCompany = Filldata(sqlCompany)

            cbCompany.DataSource = dwCompany
            cbCompany.DisplayMember = "DepartMent"
            cbCompany.ValueMember = "CompCode"

            cbGoodsCode.DataSource = dwCodeGoods
            cbGoodsCode.DisplayMember = "GOODS"
            cbGoodsCode.ValueMember = "CODE_GOODS"

            cbBillNo.DataSource = dwBillNo
            cbBillNo.DisplayMember = "BLNO"
            cbBillNo.ValueMember = "BLNO"

            sqlstr = "select * from CARGO_PACK_RECORD where CARGO_PACK_ID =" & ID & ""
            dw = Getdata(sqlstr, ds)

            dtpTimeBegin.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"
            dtpTimeEnd.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"

            If dw.Count > 0 Then
                txtID.Text = ds.Tables(0).Rows(0).Item("CARGO_PACK_ID")
                cbBillNo.SelectedValue = ds.Tables(0).Rows(0).Item("BLNO")
                cbGoodsCode.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_GOODS")
                cbCompany.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_COMPANY")

                dtpTimeBegin.Value = ds.Tables(0).Rows(0).Item("TIME_FROM")
                dtpTimeEnd.Value = ds.Tables(0).Rows(0).Item("TIME_TO")
                txtSeem.Text = ds.Tables(0).Rows(0).Item("COMMISSURE_QUALITY")

                If Not IsDBNull(ds.Tables(0).Rows(0).Item("P_PACK")) Then
                    Me.txtPackAmount_P.Text = ds.Tables(0).Rows(0).Item("P_PACK")
                End If
                If Not IsDBNull(ds.Tables(0).Rows(0).Item("M_PACK")) Then
                    Me.txtPackAmount_M.Text = ds.Tables(0).Rows(0).Item("M_PACK")
                End If
                If Not IsDBNull(ds.Tables(0).Rows(0).Item("P_WEIGHT")) Then
                    Me.txtPackWeight_P.Text = ds.Tables(0).Rows(0).Item("P_WEIGHT")
                End If
                If Not IsDBNull(ds.Tables(0).Rows(0).Item("M_WEIGHT")) Then
                    Me.txtPackWeight_M.Text = ds.Tables(0).Rows(0).Item("M_WEIGHT")
                End If
                If Not IsDBNull(ds.Tables(0).Rows(0).Item("P_CHECKOUT")) Then
                    Me.txtTestAmount_P.Text = ds.Tables(0).Rows(0).Item("P_CHECKOUT")
                End If
                If Not IsDBNull(ds.Tables(0).Rows(0).Item("M_CHECKOUT")) Then
                    Me.txtTestAmount_M.Text = ds.Tables(0).Rows(0).Item("M_CHECKOUT")
                End If

                If Not IsDBNull(ds.Tables(0).Rows(0).Item("STAND_WEIGHT")) Then
                    Me.txtStandWeight.Text = ds.Tables(0).Rows(0).Item("STAND_WEIGHT")
                End If
                If Not IsDBNull(ds.Tables(0).Rows(0).Item("AVERAGE_WEIGHT")) Then
                    Me.txtAverageWeight.Text = ds.Tables(0).Rows(0).Item("AVERAGE_WEIGHT")
                End If
                If Not IsDBNull(ds.Tables(0).Rows(0).Item("MOST_WEIGHT")) Then
                    Me.txtMostWeight.Text = ds.Tables(0).Rows(0).Item("MOST_WEIGHT")
                End If
                If Not IsDBNull(ds.Tables(0).Rows(0).Item("LEAST_WEIGHT")) Then
                    Me.txtLeastWeight.Text = ds.Tables(0).Rows(0).Item("LEAST_WEIGHT")
                End If
                If Not IsDBNull(ds.Tables(0).Rows(0).Item("DISQUALIFICATION_AMOUNT")) Then
                    Me.txtDiseligibleAmount.Text = ds.Tables(0).Rows(0).Item("DISQUALIFICATION_AMOUNT")
                End If
                If Not IsDBNull(ds.Tables(0).Rows(0).Item("ELIGIBILITY_AMOUNT")) Then
                    Me.txtEligibleAmount.Text = ds.Tables(0).Rows(0).Item("ELIGIBILITY_AMOUNT")
                End If
                If Not IsDBNull(ds.Tables(0).Rows(0).Item("TEST_ELIGIBLE")) Then
                    Me.txtEligibleRate.Text = ds.Tables(0).Rows(0).Item("TEST_ELIGIBLE")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
