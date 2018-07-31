Imports TALLY.DBControl
Public Class FrmCargoPackRecord_Edit
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
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
    Friend WithEvents btnGetData As System.Windows.Forms.Button
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
    Friend WithEvents btSave As System.Windows.Forms.Button
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
        Me.btnGetData = New System.Windows.Forms.Button()
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
        Me.btSave = New System.Windows.Forms.Button()
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
        'btnGetData
        '
        Me.btnGetData.Location = New System.Drawing.Point(334, 228)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(65, 24)
        Me.btnGetData.TabIndex = 403
        Me.btnGetData.Text = "提取数据"
        '
        'txtPackWeight_M
        '
        Me.txtPackWeight_M.Location = New System.Drawing.Point(80, 138)
        Me.txtPackWeight_M.MaxLength = 10
        Me.txtPackWeight_M.Name = "txtPackWeight_M"
        Me.txtPackWeight_M.Size = New System.Drawing.Size(90, 21)
        Me.txtPackWeight_M.TabIndex = 390
        Me.txtPackWeight_M.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 425
        Me.Label6.Text = "机器灌包重"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPackAmount_M
        '
        Me.txtPackAmount_M.Location = New System.Drawing.Point(80, 94)
        Me.txtPackAmount_M.MaxLength = 10
        Me.txtPackAmount_M.Name = "txtPackAmount_M"
        Me.txtPackAmount_M.Size = New System.Drawing.Size(120, 21)
        Me.txtPackAmount_M.TabIndex = 388
        Me.txtPackAmount_M.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 424
        Me.Label5.Text = "机器灌包数"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPackWeight_P
        '
        Me.txtPackWeight_P.Location = New System.Drawing.Point(80, 116)
        Me.txtPackWeight_P.MaxLength = 10
        Me.txtPackWeight_P.Name = "txtPackWeight_P"
        Me.txtPackWeight_P.Size = New System.Drawing.Size(90, 21)
        Me.txtPackWeight_P.TabIndex = 389
        Me.txtPackWeight_P.Text = ""
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(6, 116)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 20)
        Me.Label22.TabIndex = 423
        Me.Label22.Text = "人力灌包重"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPackAmount_P
        '
        Me.txtPackAmount_P.Location = New System.Drawing.Point(80, 72)
        Me.txtPackAmount_P.MaxLength = 10
        Me.txtPackAmount_P.Name = "txtPackAmount_P"
        Me.txtPackAmount_P.Size = New System.Drawing.Size(120, 21)
        Me.txtPackAmount_P.TabIndex = 387
        Me.txtPackAmount_P.Text = ""
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(6, 72)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 20)
        Me.Label23.TabIndex = 422
        Me.Label23.Text = "人力灌包数"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbBillNo
        '
        Me.cbBillNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBillNo.Location = New System.Drawing.Point(80, 6)
        Me.cbBillNo.Name = "cbBillNo"
        Me.cbBillNo.Size = New System.Drawing.Size(120, 20)
        Me.cbBillNo.TabIndex = 384
        '
        'txtTestAmount_P
        '
        Me.txtTestAmount_P.Location = New System.Drawing.Point(80, 204)
        Me.txtTestAmount_P.MaxLength = 10
        Me.txtTestAmount_P.Name = "txtTestAmount_P"
        Me.txtTestAmount_P.Size = New System.Drawing.Size(120, 21)
        Me.txtTestAmount_P.TabIndex = 393
        Me.txtTestAmount_P.Text = ""
        '
        'cbCompany
        '
        Me.cbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCompany.Location = New System.Drawing.Point(80, 50)
        Me.cbCompany.Name = "cbCompany"
        Me.cbCompany.Size = New System.Drawing.Size(120, 20)
        Me.cbCompany.TabIndex = 386
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(6, 50)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 20)
        Me.Label18.TabIndex = 420
        Me.Label18.Text = "装卸公司"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(204, 254)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 405
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(136, 254)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 404
        Me.btSave.Text = "确认"
        '
        'cbGoodsCode
        '
        Me.cbGoodsCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGoodsCode.Location = New System.Drawing.Point(80, 28)
        Me.cbGoodsCode.Name = "cbGoodsCode"
        Me.cbGoodsCode.Size = New System.Drawing.Size(120, 20)
        Me.cbGoodsCode.TabIndex = 385
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(6, 28)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 20)
        Me.Label17.TabIndex = 419
        Me.Label17.Text = "货名代码"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLeastWeight
        '
        Me.txtLeastWeight.Location = New System.Drawing.Point(278, 72)
        Me.txtLeastWeight.MaxLength = 10
        Me.txtLeastWeight.Name = "txtLeastWeight"
        Me.txtLeastWeight.Size = New System.Drawing.Size(90, 21)
        Me.txtLeastWeight.TabIndex = 398
        Me.txtLeastWeight.Text = ""
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(204, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 20)
        Me.Label16.TabIndex = 418
        Me.Label16.Text = "最低件重"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTestAmount_M
        '
        Me.txtTestAmount_M.Location = New System.Drawing.Point(80, 226)
        Me.txtTestAmount_M.MaxLength = 10
        Me.txtTestAmount_M.Name = "txtTestAmount_M"
        Me.txtTestAmount_M.Size = New System.Drawing.Size(120, 21)
        Me.txtTestAmount_M.TabIndex = 394
        Me.txtTestAmount_M.Text = ""
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(6, 226)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 20)
        Me.Label15.TabIndex = 417
        Me.Label15.Text = "机器抽检数"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEligibleAmount
        '
        Me.txtEligibleAmount.Location = New System.Drawing.Point(278, 94)
        Me.txtEligibleAmount.MaxLength = 10
        Me.txtEligibleAmount.Name = "txtEligibleAmount"
        Me.txtEligibleAmount.Size = New System.Drawing.Size(120, 21)
        Me.txtEligibleAmount.TabIndex = 399
        Me.txtEligibleAmount.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(204, 116)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 20)
        Me.Label13.TabIndex = 416
        Me.Label13.Text = "不合格件数"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDiseligibleAmount
        '
        Me.txtDiseligibleAmount.Location = New System.Drawing.Point(278, 116)
        Me.txtDiseligibleAmount.MaxLength = 10
        Me.txtDiseligibleAmount.Name = "txtDiseligibleAmount"
        Me.txtDiseligibleAmount.Size = New System.Drawing.Size(120, 21)
        Me.txtDiseligibleAmount.TabIndex = 400
        Me.txtDiseligibleAmount.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(204, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 20)
        Me.Label12.TabIndex = 415
        Me.Label12.Text = "合格件数"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAverageWeight
        '
        Me.txtAverageWeight.Location = New System.Drawing.Point(278, 28)
        Me.txtAverageWeight.MaxLength = 10
        Me.txtAverageWeight.Name = "txtAverageWeight"
        Me.txtAverageWeight.Size = New System.Drawing.Size(90, 21)
        Me.txtAverageWeight.TabIndex = 396
        Me.txtAverageWeight.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(204, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 20)
        Me.Label11.TabIndex = 414
        Me.Label11.Text = "平均件重"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStandWeight
        '
        Me.txtStandWeight.Location = New System.Drawing.Point(278, 6)
        Me.txtStandWeight.MaxLength = 10
        Me.txtStandWeight.Name = "txtStandWeight"
        Me.txtStandWeight.Size = New System.Drawing.Size(90, 21)
        Me.txtStandWeight.TabIndex = 395
        Me.txtStandWeight.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(204, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 20)
        Me.Label10.TabIndex = 413
        Me.Label10.Text = "标准件重"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeEnd
        '
        Me.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeEnd.Location = New System.Drawing.Point(80, 182)
        Me.dtpTimeEnd.Name = "dtpTimeEnd"
        Me.dtpTimeEnd.Size = New System.Drawing.Size(120, 21)
        Me.dtpTimeEnd.TabIndex = 392
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 412
        Me.Label8.Text = "作业止时间"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeBegin
        '
        Me.dtpTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeBegin.Location = New System.Drawing.Point(80, 160)
        Me.dtpTimeBegin.Name = "dtpTimeBegin"
        Me.dtpTimeBegin.Size = New System.Drawing.Size(120, 21)
        Me.dtpTimeBegin.TabIndex = 391
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 411
        Me.Label7.Text = "作业起时间"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(6, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 410
        Me.Label4.Text = "提单号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMostWeight
        '
        Me.txtMostWeight.Location = New System.Drawing.Point(278, 50)
        Me.txtMostWeight.MaxLength = 10
        Me.txtMostWeight.Name = "txtMostWeight"
        Me.txtMostWeight.Size = New System.Drawing.Size(90, 21)
        Me.txtMostWeight.TabIndex = 397
        Me.txtMostWeight.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(204, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 409
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
        Me.txtSeem.TabIndex = 402
        Me.txtSeem.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(204, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 408
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
        Me.txtEligibleRate.TabIndex = 401
        Me.txtEligibleRate.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(204, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 407
        Me.Label2.Text = "抽检合格率"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 406
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(6, 204)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 20)
        Me.Label20.TabIndex = 421
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
        'FrmCargoPackRecord_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(404, 281)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label25, Me.Label21, Me.Label24, Me.Label14, Me.Label19, Me.Label9, Me.Label35, Me.btnGetData, Me.txtPackWeight_M, Me.Label6, Me.txtPackAmount_M, Me.Label5, Me.txtPackWeight_P, Me.Label22, Me.txtPackAmount_P, Me.Label23, Me.cbBillNo, Me.txtTestAmount_P, Me.cbCompany, Me.Label18, Me.btQuit, Me.btSave, Me.cbGoodsCode, Me.Label17, Me.txtLeastWeight, Me.Label16, Me.txtTestAmount_M, Me.Label15, Me.txtEligibleAmount, Me.Label13, Me.txtDiseligibleAmount, Me.Label12, Me.txtAverageWeight, Me.Label11, Me.txtStandWeight, Me.Label10, Me.dtpTimeEnd, Me.Label8, Me.dtpTimeBegin, Me.Label7, Me.Label4, Me.txtMostWeight, Me.Label3, Me.txtSeem, Me.Label1, Me.txtEligibleRate, Me.Label2, Me.txtID, Me.Label20})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargoPackRecord_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "散货灌包交接单信息 修改"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCargoPackRecord_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            dw = Updatedata(sqlda, sqlstr, ds)

            dtpTimeBegin.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"
            dtpTimeEnd.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"

            'txtStandWeight.Text = 50.0
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

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim sqlExist As String
        sqlExist = "select * from CARGO_PACK_RECORD where SHIP_ID = '" & Ship_ID & _
                "' and BLNO = '" & cbBillNo.SelectedValue & "' and Code_Goods = '" & cbGoodsCode.SelectedValue & _
                "' and CODE_COMPANY = '" & cbCompany.SelectedValue & "' and CARGO_PACK_ID <> '" & ID & "'"
        Try
            If DateDiff(DateInterval.Minute, dtpTimeBegin.Value, dtpTimeEnd.Value) > 0 Then

                If SetNumValue("P_PACK", txtPackAmount_P.Text, "人力灌包数") = False Then
                    Exit Sub
                ElseIf SetNumValue("M_PACK", txtPackAmount_M.Text, "机器灌包数") = False Then
                    Exit Sub
                ElseIf SetNumValue("P_WEIGHT", txtPackWeight_P.Text, "人力灌包重") = False Then
                    Exit Sub
                ElseIf SetNumValue("M_WEIGHT", txtPackWeight_M.Text, "机器灌包重") = False Then
                    Exit Sub
                ElseIf SetNumValue("P_CHECKOUT", txtTestAmount_P.Text, "人力抽检数") = False Then
                    Exit Sub
                ElseIf SetNumValue("M_CHECKOUT", txtTestAmount_M.Text, "机器抽检数") = False Then
                    Exit Sub
                ElseIf SetNumValue("STAND_WEIGHT", txtStandWeight.Text, "标准件重") = False Then
                    Exit Sub
                ElseIf SetNumValue("AVERAGE_WEIGHT", txtAverageWeight.Text, "平均件重") = False Then
                    Exit Sub
                ElseIf SetNumValue("MOST_WEIGHT", txtMostWeight.Text, "最高件重") = False Then
                    Exit Sub
                ElseIf SetNumValue("LEAST_WEIGHT", txtLeastWeight.Text, "最低件重") = False Then
                    Exit Sub
                ElseIf SetNumValue("DISQUALIFICATION_AMOUNT", txtDiseligibleAmount.Text, "不合格件数") = False Then
                    Exit Sub
                ElseIf SetNumValue("ELIGIBILITY_AMOUNT", txtEligibleAmount.Text, "合格件数") = False Then
                    Exit Sub
                ElseIf SetNumValue("TEST_ELIGIBLE", txtEligibleRate.Text, "抽检合格率") = False Then
                    Exit Sub
                End If

                ds.Tables(0).Rows(0).Item("TIME_FROM") = dtpTimeBegin.Value
                ds.Tables(0).Rows(0).Item("TIME_TO") = dtpTimeEnd.Value
                ds.Tables(0).Rows(0).Item("COMMISSURE_QUALITY") = Trim(txtSeem.Text)

                ds.Tables(0).Rows(0).Item("BLNO") = cbBillNo.SelectedValue
                ds.Tables(0).Rows(0).Item("CODE_GOODS") = cbGoodsCode.SelectedValue
                ds.Tables(0).Rows(0).Item("CODE_COMPANY") = cbCompany.SelectedValue

                ds.Tables(0).Rows(0).Item("DEPT_CODE") = FrmCargoPackRecord.strCodeDept

                If MessageBox.Show("确认要修改吗？", "警告提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                    If Filldata(sqlExist).Count = 0 Then
                        '记录操作日志
                        Call OperateHistory(G_DeptName, Now, G_User, "修改", "CARGO_PACK_RECORD", Trim(txtID.Text), "CARGO_PACK_ID")
                        
                        sqlda.Update(ds)
                        Me.Close()
                    Else
                        MessageBox.Show("同一船次提单号 货名代码 装卸公司不能重复。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    Me.Close()
                End If
            Else
                MessageBox.Show("作业起时间应在止时间之前。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function SetNumValue(ByVal strNumColumn As String, ByVal strNumValue As String, Optional ByVal message As String = "数据") As Boolean
        Dim flag As Boolean = True
        If Trim(strNumValue) <> "" Then     '
            If IsNumeric(Trim(strNumValue)) Then
                ds.Tables(0).Rows(0).Item(strNumColumn) = Trim(strNumValue)
            Else
                MessageBox.Show(message + "应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                flag = False
            End If
        Else    '此列留空
        End If
        Return flag
    End Function

    Private Sub btnGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetData.Click
        Dim sqldata1 As String = "SELECT MIN(TIME_FROM) AS timeBegin, MAX(TIME_TO) AS timeEnd, MAX(STAND_WEIGHT) AS STAND, MAX(MOST_WEIGHT) AS MOST, MIN(LEAST_WEIGHT) AS LEAST, SUM(DISQUALIFICATION_AMOUNT) AS diseligib, SUM(ELIGIBILITY_AMOUNT) AS eligib ,round(sum((DISQUALIFICATION_AMOUNT + ELIGIBILITY_AMOUNT)*average_weight)/(sum(DISQUALIFICATION_AMOUNT + ELIGIBILITY_AMOUNT)),3) AS TestWeight FROM CARGO_PACK_SHEET GROUP BY SHIP_ID, BLNO, Code_Goods, COMPANY_CODE HAVING (SHIP_ID = '" & Ship_ID & _
           "') AND (BLNO = '" & cbBillNo.SelectedValue & " ') AND (Code_Goods = '" & Me.cbGoodsCode.SelectedValue & "') AND (COMPANY_CODE = '" & cbCompany.SelectedValue & "')"
        Dim sqldata2 As String = "SELECT P_M_TYPE, SUM(Pack_Amount) AS PackAmount, SUM(Pack_Weight) AS PackWeight,sum(DISQUALIFICATION_AMOUNT + ELIGIBILITY_AMOUNT)as TestAmount FROM CARGO_PACK_SHEET WHERE (SHIP_ID ='" & Ship_ID & _
                "') AND (BLNO = '" & cbBillNo.SelectedValue & " ') AND (Code_Goods = '" & Me.cbGoodsCode.SelectedValue & "') AND (COMPANY_CODE = '" & cbCompany.SelectedValue & "') GROUP BY P_M_TYPE ORDER BY P_M_TYPE"
        Dim dvdata1 As New DataView()
        Dim dvdata2 As New DataView()
        Try
            dvdata1 = Filldata(sqldata1)
            dvdata2 = Filldata(sqldata2)
            If dvdata1.Count = 1 Then
                dtpTimeBegin.Value = dvdata1.Item(0)("timeBegin")
                dtpTimeEnd.Value = dvdata1.Item(0)("timeEnd")
                If Not IsDBNull(dvdata1.Item(0)("STAND")) Then
                    txtStandWeight.Text = dvdata1.Item(0)("STAND")
                End If
                If Not IsDBNull(dvdata1.Item(0)("MOST")) Then
                    txtMostWeight.Text = dvdata1.Item(0)("MOST")
                End If
                If Not IsDBNull(dvdata1.Item(0)("LEAST")) Then
                    txtLeastWeight.Text = dvdata1.Item(0)("LEAST")
                End If
                If Not IsDBNull(dvdata1.Item(0)("eligib")) Then
                    txtEligibleAmount.Text = dvdata1.Item(0)("eligib")
                End If
                If Not IsDBNull(dvdata1.Item(0)("diseligib")) Then
                    txtDiseligibleAmount.Text = dvdata1.Item(0)("diseligib")
                End If
                If Not IsDBNull(dvdata1.Item(0)("TestWeight")) Then
                    txtAverageWeight.Text = dvdata1.Item(0)("TestWeight")
                End If
                If IsNumeric(Trim(txtEligibleAmount.Text)) And IsNumeric(Trim(txtDiseligibleAmount.Text)) Then
                    txtEligibleRate.Text = Decimal.Round(100 * CDec(Trim(txtEligibleAmount.Text)) / (CDec(Trim(txtEligibleAmount.Text)) + CDec(Trim(txtDiseligibleAmount.Text))), 3)
                End If
                If dvdata2.Item(0)("P_M_TYPE") = 1 Then
                    If Not IsDBNull(dvdata2.Item(0)("PackAmount")) Then
                        txtPackAmount_P.Text = dvdata2.Item(0)("PackAmount")
                    End If
                    If Not IsDBNull(dvdata2.Item(0)("PackWeight")) Then
                        txtPackWeight_P.Text = dvdata2.Item(0)("PackWeight")
                    End If
                    If Not IsDBNull(dvdata2.Item(0)("TestAmount")) Then
                        txtTestAmount_P.Text = dvdata2.Item(0)("TestAmount")
                    End If
                    If dvdata2.Count = 2 Then
                        If Not IsDBNull(dvdata2.Item(1)("PackAmount")) Then
                            txtPackAmount_M.Text = dvdata2.Item(1)("PackAmount")
                        End If
                        If Not IsDBNull(dvdata2.Item(1)("PackWeight")) Then
                            txtPackWeight_M.Text = dvdata2.Item(1)("PackWeight")
                        End If
                        If Not IsDBNull(dvdata2.Item(1)("TestAmount")) Then
                            txtTestAmount_M.Text = dvdata2.Item(1)("TestAmount")
                        End If
                    End If
                Else
                    If Not IsDBNull(dvdata2.Item(0)("PackAmount")) Then
                        txtPackAmount_M.Text = dvdata2.Item(0)("PackAmount")
                    End If
                    If Not IsDBNull(dvdata2.Item(0)("PackWeight")) Then
                        txtPackWeight_M.Text = dvdata2.Item(0)("PackWeight")
                    End If
                    If Not IsDBNull(dvdata2.Item(0)("TestAmount")) Then
                        txtTestAmount_M.Text = dvdata2.Item(0)("TestAmount")
                    End If
                End If
            Else
                MessageBox.Show("未能取得数据，可能灌包理货单尚未输入。", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub cbBillNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBillNo.SelectedIndexChanged
        Try
            If TypeName(cbBillNo.SelectedValue) = "String" Then
                sqlCodeGoods = "SELECT DISTINCT CODE_GOODS, GOODS FROM View_CargoGoodsPub WHERE SHIP_ID = '" & Ship_ID & "' and BLNO = '" & cbBillNo.SelectedValue & "'"
                dwCodeGoods = Filldata(sqlCodeGoods)

                cbGoodsCode.DataSource = dwCodeGoods
                cbGoodsCode.DisplayMember = "GOODS"
                cbGoodsCode.ValueMember = "CODE_GOODS"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbGoodsCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbGoodsCode.SelectedIndexChanged
        Try
            If TypeName(cbGoodsCode.SelectedValue) = "String" And TypeName(cbBillNo.SelectedValue) = "String" Then
                sqlCompany = "SELECT DISTINCT CompCode, DepartMent FROM View_CargoGoodsPub WHERE SHIP_ID = '" & Ship_ID & "' and BLNO = '" & cbBillNo.SelectedValue & "' and CODE_GOODS = '" & cbGoodsCode.SelectedValue & " '"
                dwCompany = Filldata(sqlCompany)

                cbCompany.DataSource = dwCompany
                cbCompany.DisplayMember = "DepartMent"
                cbCompany.ValueMember = "CompCode"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtEligibleAmount_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEligibleAmount.Leave
        If IsNumeric(Trim(Me.txtEligibleAmount.Text)) And IsNumeric(Trim(Me.txtDiseligibleAmount.Text)) Then
            Me.txtEligibleRate.Text = Decimal.Round(100 * CDec(Trim(Me.txtEligibleAmount.Text)) / (CDec(Trim(Me.txtEligibleAmount.Text)) + CDec(Trim(Me.txtDiseligibleAmount.Text))), 3)
        End If
    End Sub

    Private Sub txtDiseligibleAmount_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiseligibleAmount.Leave
        If IsNumeric(Trim(Me.txtEligibleAmount.Text)) And IsNumeric(Trim(Me.txtDiseligibleAmount.Text)) Then
            Me.txtEligibleRate.Text = Decimal.Round(100 * CDec(Trim(Me.txtEligibleAmount.Text)) / (CDec(Trim(Me.txtEligibleAmount.Text)) + CDec(Trim(Me.txtDiseligibleAmount.Text))), 3)
        End If
    End Sub

    Private Sub cbBillNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbBillNo.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cbGoodsCode.Focus()
        End If
    End Sub

    Private Sub cbGoodsCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbGoodsCode.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cbCompany.Focus()
        End If
    End Sub

    Private Sub cbCompany_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbCompany.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtPackAmount_P.Focus()
        End If
    End Sub

    Private Sub txtPackAmount_P_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPackAmount_P.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtPackAmount_M.Focus()
        End If
    End Sub

    Private Sub txtPackAmount_M_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPackAmount_M.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtPackWeight_P.Focus()
        End If
    End Sub

    Private Sub txtPackWeight_P_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPackWeight_P.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtPackWeight_M.Focus()
        End If
    End Sub

    Private Sub txtPackWeight_M_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPackWeight_M.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.dtpTimeBegin.Focus()
        End If
    End Sub

    Private Sub dtpTimeBegin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpTimeBegin.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.dtpTimeEnd.Focus()
        End If
    End Sub

    Private Sub dtpTimeEnd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpTimeEnd.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTestAmount_P.Focus()
        End If
    End Sub

    Private Sub txtTestAmount_P_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTestAmount_P.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTestAmount_M.Focus()
        End If
    End Sub

    Private Sub txtTestAmount_M_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTestAmount_M.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtStandWeight.Focus()
        End If
    End Sub

    Private Sub txtStandWeight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStandWeight.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtAverageWeight.Focus()
        End If
    End Sub

    Private Sub txtAverageWeight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAverageWeight.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtMostWeight.Focus()
        End If
    End Sub

    Private Sub txtMostWeight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMostWeight.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtLeastWeight.Focus()
        End If
    End Sub

    Private Sub txtLeastWeight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLeastWeight.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtEligibleAmount.Focus()
        End If
    End Sub

    Private Sub txtEligibleAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEligibleAmount.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtDiseligibleAmount.Focus()
        End If
    End Sub

    Private Sub txtDiseligibleAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiseligibleAmount.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtEligibleRate.Enabled = True Then
                Me.txtEligibleRate.Focus()
            Else
                Me.txtSeem.Focus()
            End If
        End If
    End Sub

    Private Sub txtEligibleRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEligibleRate.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtSeem.Focus()
        End If
    End Sub

    Private Sub txtSeem_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSeem.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btnGetData.Focus()
        End If
    End Sub

    Private Sub btnGetData_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnGetData.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btSave.Focus()
            Call Me.btnGetData_Click(sender, e)
        End If
    End Sub

    Private Sub btSave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btSave.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Me.btSave_Click(sender, e)
        End If
    End Sub
End Class
