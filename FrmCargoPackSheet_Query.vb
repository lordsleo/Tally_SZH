Imports TALLY.DBControl
Public Class FrmCargoPackSheet_Query
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()

    Dim strTime As String
    Dim sqlClerk As String
    Dim dvClerk1 As New DataView()
    Dim dvClerk2 As New DataView()
    Dim dvclerk3 As New DataView()

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
    Friend WithEvents cbBillNo As System.Windows.Forms.ComboBox
    Friend WithEvents cbCompany As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents cbGoodsCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtLeastWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtTestPerson As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtEligibleAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDiseligibleAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAverageWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtStandWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtYardNo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbPMType As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCause As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMostWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSeem As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEligibleRate As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtPackWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtPackAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cbClerk3 As System.Windows.Forms.ComboBox
    Friend WithEvents cbClerk2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbClerk1 As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cbBillNo = New System.Windows.Forms.ComboBox()
        Me.cbCompany = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.cbGoodsCode = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtLeastWeight = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTestPerson = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtEligibleAmount = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDiseligibleAmount = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAverageWeight = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtStandWeight = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtYardNo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpTimeEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpTimeBegin = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbPMType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCause = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMostWeight = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSeem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEligibleRate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtPackWeight = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtPackAmount = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cbClerk3 = New System.Windows.Forms.ComboBox()
        Me.cbClerk2 = New System.Windows.Forms.ComboBox()
        Me.cbClerk1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cbBillNo
        '
        Me.cbBillNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBillNo.Location = New System.Drawing.Point(80, 6)
        Me.cbBillNo.Name = "cbBillNo"
        Me.cbBillNo.Size = New System.Drawing.Size(124, 20)
        Me.cbBillNo.TabIndex = 370
        '
        'cbCompany
        '
        Me.cbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCompany.Location = New System.Drawing.Point(80, 72)
        Me.cbCompany.Name = "cbCompany"
        Me.cbCompany.Size = New System.Drawing.Size(124, 20)
        Me.cbCompany.TabIndex = 331
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(6, 204)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 20)
        Me.Label19.TabIndex = 369
        Me.Label19.Text = "理货员1"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(6, 72)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 20)
        Me.Label18.TabIndex = 366
        Me.Label18.Text = "装卸公司"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(6, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 20)
        Me.Label14.TabIndex = 365
        Me.Label14.Text = "人机灌包别"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(6, 292)
        Me.txtResult.MaxLength = 100
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(198, 42)
        Me.txtResult.TabIndex = 345
        Me.txtResult.Text = ""
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(176, 340)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 347
        Me.btQuit.Text = "返回"
        '
        'cbGoodsCode
        '
        Me.cbGoodsCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGoodsCode.Location = New System.Drawing.Point(80, 28)
        Me.cbGoodsCode.Name = "cbGoodsCode"
        Me.cbGoodsCode.Size = New System.Drawing.Size(124, 20)
        Me.cbGoodsCode.TabIndex = 326
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(6, 28)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 20)
        Me.Label17.TabIndex = 364
        Me.Label17.Text = "货名代码"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLeastWeight
        '
        Me.txtLeastWeight.Location = New System.Drawing.Point(286, 72)
        Me.txtLeastWeight.MaxLength = 10
        Me.txtLeastWeight.Name = "txtLeastWeight"
        Me.txtLeastWeight.Size = New System.Drawing.Size(94, 21)
        Me.txtLeastWeight.TabIndex = 339
        Me.txtLeastWeight.Text = ""
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(212, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 20)
        Me.Label16.TabIndex = 363
        Me.Label16.Text = "最低件重"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTestPerson
        '
        Me.txtTestPerson.Location = New System.Drawing.Point(286, 160)
        Me.txtTestPerson.MaxLength = 10
        Me.txtTestPerson.Name = "txtTestPerson"
        Me.txtTestPerson.Size = New System.Drawing.Size(124, 21)
        Me.txtTestPerson.TabIndex = 335
        Me.txtTestPerson.Text = ""
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(212, 160)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 20)
        Me.Label15.TabIndex = 362
        Me.Label15.Text = "抽检员"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEligibleAmount
        '
        Me.txtEligibleAmount.Location = New System.Drawing.Point(286, 116)
        Me.txtEligibleAmount.MaxLength = 10
        Me.txtEligibleAmount.Name = "txtEligibleAmount"
        Me.txtEligibleAmount.Size = New System.Drawing.Size(124, 21)
        Me.txtEligibleAmount.TabIndex = 341
        Me.txtEligibleAmount.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(212, 116)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 20)
        Me.Label13.TabIndex = 361
        Me.Label13.Text = "合格件数"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDiseligibleAmount
        '
        Me.txtDiseligibleAmount.Location = New System.Drawing.Point(286, 94)
        Me.txtDiseligibleAmount.MaxLength = 10
        Me.txtDiseligibleAmount.Name = "txtDiseligibleAmount"
        Me.txtDiseligibleAmount.Size = New System.Drawing.Size(124, 21)
        Me.txtDiseligibleAmount.TabIndex = 340
        Me.txtDiseligibleAmount.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(212, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 20)
        Me.Label12.TabIndex = 360
        Me.Label12.Text = "不合格件数"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAverageWeight
        '
        Me.txtAverageWeight.Location = New System.Drawing.Point(286, 28)
        Me.txtAverageWeight.MaxLength = 10
        Me.txtAverageWeight.Name = "txtAverageWeight"
        Me.txtAverageWeight.Size = New System.Drawing.Size(94, 21)
        Me.txtAverageWeight.TabIndex = 337
        Me.txtAverageWeight.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(212, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 20)
        Me.Label11.TabIndex = 359
        Me.Label11.Text = "平均件重"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStandWeight
        '
        Me.txtStandWeight.Location = New System.Drawing.Point(286, 6)
        Me.txtStandWeight.MaxLength = 10
        Me.txtStandWeight.Name = "txtStandWeight"
        Me.txtStandWeight.Size = New System.Drawing.Size(94, 21)
        Me.txtStandWeight.TabIndex = 336
        Me.txtStandWeight.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(212, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 20)
        Me.Label10.TabIndex = 358
        Me.Label10.Text = "标准件重"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtYardNo
        '
        Me.txtYardNo.Location = New System.Drawing.Point(80, 50)
        Me.txtYardNo.MaxLength = 20
        Me.txtYardNo.Name = "txtYardNo"
        Me.txtYardNo.Size = New System.Drawing.Size(124, 21)
        Me.txtYardNo.TabIndex = 327
        Me.txtYardNo.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 20)
        Me.Label9.TabIndex = 357
        Me.Label9.Text = "库场号"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeEnd
        '
        Me.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeEnd.Location = New System.Drawing.Point(80, 182)
        Me.dtpTimeEnd.Name = "dtpTimeEnd"
        Me.dtpTimeEnd.Size = New System.Drawing.Size(124, 21)
        Me.dtpTimeEnd.TabIndex = 330
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 356
        Me.Label8.Text = "结束时间"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeBegin
        '
        Me.dtpTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeBegin.Location = New System.Drawing.Point(80, 160)
        Me.dtpTimeBegin.Name = "dtpTimeBegin"
        Me.dtpTimeBegin.Size = New System.Drawing.Size(124, 21)
        Me.dtpTimeBegin.TabIndex = 329
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 355
        Me.Label7.Text = "开始时间"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbPMType
        '
        Me.cbPMType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPMType.Location = New System.Drawing.Point(80, 94)
        Me.cbPMType.Name = "cbPMType"
        Me.cbPMType.Size = New System.Drawing.Size(124, 20)
        Me.cbPMType.TabIndex = 328
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 354
        Me.Label6.Text = "处理结果"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCause
        '
        Me.txtCause.Location = New System.Drawing.Point(212, 270)
        Me.txtCause.MaxLength = 100
        Me.txtCause.Multiline = True
        Me.txtCause.Name = "txtCause"
        Me.txtCause.Size = New System.Drawing.Size(198, 64)
        Me.txtCause.TabIndex = 344
        Me.txtCause.Text = ""
        '
        'Label4
        '
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(6, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 353
        Me.Label4.Text = "提单号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(212, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 352
        Me.Label5.Text = "原因"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMostWeight
        '
        Me.txtMostWeight.Location = New System.Drawing.Point(286, 50)
        Me.txtMostWeight.MaxLength = 10
        Me.txtMostWeight.Name = "txtMostWeight"
        Me.txtMostWeight.Size = New System.Drawing.Size(94, 21)
        Me.txtMostWeight.TabIndex = 338
        Me.txtMostWeight.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(212, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 351
        Me.Label3.Text = "最高件重"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSeem
        '
        Me.txtSeem.Location = New System.Drawing.Point(212, 204)
        Me.txtSeem.MaxLength = 50
        Me.txtSeem.Multiline = True
        Me.txtSeem.Name = "txtSeem"
        Me.txtSeem.Size = New System.Drawing.Size(198, 42)
        Me.txtSeem.TabIndex = 343
        Me.txtSeem.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(212, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 350
        Me.Label1.Text = "缝口质量"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEligibleRate
        '
        Me.txtEligibleRate.Location = New System.Drawing.Point(286, 138)
        Me.txtEligibleRate.MaxLength = 10
        Me.txtEligibleRate.Name = "txtEligibleRate"
        Me.txtEligibleRate.Size = New System.Drawing.Size(94, 21)
        Me.txtEligibleRate.TabIndex = 342
        Me.txtEligibleRate.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(212, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 349
        Me.Label2.Text = "抽检合格率"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 348
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(6, 248)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 20)
        Me.Label20.TabIndex = 367
        Me.Label20.Text = "理货员3"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(6, 226)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 20)
        Me.Label21.TabIndex = 368
        Me.Label21.Text = "理货员2"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPackWeight
        '
        Me.txtPackWeight.Location = New System.Drawing.Point(80, 138)
        Me.txtPackWeight.MaxLength = 10
        Me.txtPackWeight.Name = "txtPackWeight"
        Me.txtPackWeight.Size = New System.Drawing.Size(94, 21)
        Me.txtPackWeight.TabIndex = 376
        Me.txtPackWeight.Text = ""
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(6, 138)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 20)
        Me.Label22.TabIndex = 378
        Me.Label22.Text = "灌包重量"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPackAmount
        '
        Me.txtPackAmount.Location = New System.Drawing.Point(80, 116)
        Me.txtPackAmount.MaxLength = 10
        Me.txtPackAmount.Name = "txtPackAmount"
        Me.txtPackAmount.Size = New System.Drawing.Size(124, 21)
        Me.txtPackAmount.TabIndex = 375
        Me.txtPackAmount.Text = ""
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(6, 116)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 20)
        Me.Label23.TabIndex = 377
        Me.Label23.Text = "灌包件数"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(380, 138)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(30, 20)
        Me.Label25.TabIndex = 513
        Me.Label25.Text = "%"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(380, 72)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(30, 20)
        Me.Label24.TabIndex = 512
        Me.Label24.Text = "公斤"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(380, 50)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(30, 20)
        Me.Label26.TabIndex = 511
        Me.Label26.Text = "公斤"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(380, 28)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(30, 20)
        Me.Label27.TabIndex = 510
        Me.Label27.Text = "公斤"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(380, 6)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(30, 20)
        Me.Label28.TabIndex = 509
        Me.Label28.Text = "公斤"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(174, 138)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(30, 20)
        Me.Label29.TabIndex = 508
        Me.Label29.Text = "公斤"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbClerk3
        '
        Me.cbClerk3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClerk3.Location = New System.Drawing.Point(80, 248)
        Me.cbClerk3.Name = "cbClerk3"
        Me.cbClerk3.Size = New System.Drawing.Size(124, 20)
        Me.cbClerk3.TabIndex = 519
        '
        'cbClerk2
        '
        Me.cbClerk2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClerk2.Location = New System.Drawing.Point(80, 226)
        Me.cbClerk2.Name = "cbClerk2"
        Me.cbClerk2.Size = New System.Drawing.Size(124, 20)
        Me.cbClerk2.TabIndex = 518
        '
        'cbClerk1
        '
        Me.cbClerk1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClerk1.Location = New System.Drawing.Point(80, 204)
        Me.cbClerk1.Name = "cbClerk1"
        Me.cbClerk1.Size = New System.Drawing.Size(124, 20)
        Me.cbClerk1.TabIndex = 517
        '
        'FrmCargoPackSheet_Query
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(420, 367)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbClerk3, Me.cbClerk2, Me.cbClerk1, Me.Label25, Me.Label24, Me.Label26, Me.Label27, Me.Label28, Me.Label29, Me.txtPackWeight, Me.Label22, Me.txtPackAmount, Me.Label23, Me.cbBillNo, Me.cbCompany, Me.Label19, Me.Label18, Me.Label14, Me.txtResult, Me.btQuit, Me.cbGoodsCode, Me.Label17, Me.txtLeastWeight, Me.Label16, Me.txtTestPerson, Me.Label15, Me.txtEligibleAmount, Me.Label13, Me.txtDiseligibleAmount, Me.Label12, Me.txtAverageWeight, Me.Label11, Me.txtStandWeight, Me.Label10, Me.txtYardNo, Me.Label9, Me.dtpTimeEnd, Me.Label8, Me.dtpTimeBegin, Me.Label7, Me.cbPMType, Me.Label6, Me.txtCause, Me.Label4, Me.Label5, Me.txtMostWeight, Me.Label3, Me.txtSeem, Me.Label1, Me.txtEligibleRate, Me.Label2, Me.txtID, Me.Label20, Me.Label21})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargoPackSheet_Query"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "散货灌包理货单信息 查看"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCargoPackSheet_Query_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dw As New DataView()
        Dim sqlstr As String
        Dim dwBillNo As New DataView()
        Dim dwPMType As New DataView()
        Dim dwCompany As New DataView()
        Dim dwCodeGoods As New DataView()
        Dim sqlCodeGoods, sqlCompany As String
        Dim sqlBillNo, sqlPMType As String
        Try
            sqlPMType = "SELECT Code_PM, Name_PM FROM Code_PMType"
            sqlCodeGoods = "SELECT DISTINCT CODE_GOODS, GOODS FROM View_CargoGoodsPub WHERE SHIP_ID = '" & Ship_ID & "'"
            sqlCompany = "SELECT DISTINCT CompCode, DepartMent FROM View_CargoGoodsPub WHERE SHIP_ID = '" & Ship_ID & "'"
            sqlBillNo = "SELECT DISTINCT BLNO FROM View_CargoGoodsPub WHERE SHIP_ID = '" & Ship_ID & "'"

            dwBillNo = Filldata(sqlBillNo)
            dwCodeGoods = Filldata(sqlCodeGoods)
            dwCompany = Filldata(sqlCompany)
            dwPMType = Filldata(sqlPMType)

            cbCompany.DataSource = dwCompany
            cbCompany.DisplayMember = "DepartMent"
            cbCompany.ValueMember = "CompCode"

            cbGoodsCode.DataSource = dwCodeGoods
            cbGoodsCode.DisplayMember = "GOODS"
            cbGoodsCode.ValueMember = "CODE_GOODS"

            cbBillNo.DataSource = dwBillNo
            cbBillNo.DisplayMember = "BLNO"
            cbBillNo.ValueMember = "BLNO"

            cbPMType.DataSource = dwPMType
            cbPMType.DisplayMember = "Name_PM"
            cbPMType.ValueMember = "Code_PM"

            sqlstr = "select * from CARGO_PACK_SHEET where CARGO_PACK_SHEET_ID =" & ID & ""
            dw = Getdata(sqlstr, ds)

            dtpTimeBegin.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"
            dtpTimeEnd.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"

            If dw.Count > 0 Then
                txtID.Text = ds.Tables(0).Rows(0).Item("CARGO_PACK_SHEET_ID")
                cbBillNo.SelectedValue = ds.Tables(0).Rows(0).Item("BLNO")
                cbGoodsCode.SelectedValue = ds.Tables(0).Rows(0).Item("Code_Goods")
                cbCompany.SelectedValue = ds.Tables(0).Rows(0).Item("COMPANY_CODE")
                cbPMType.SelectedValue = ds.Tables(0).Rows(0).Item("P_M_TYPE")
                dtpTimeBegin.Value = ds.Tables(0).Rows(0).Item("TIME_FROM")
                dtpTimeEnd.Value = ds.Tables(0).Rows(0).Item("TIME_TO")

                txtYardNo.Text = ds.Tables(0).Rows(0).Item("YARD_NO")
                txtTestPerson.Text = ds.Tables(0).Rows(0).Item("TEST_PERSON")

                If Not IsDBNull(ds.Tables(0).Rows(0).Item("Pack_Amount")) Then
                    Me.txtPackAmount.Text = ds.Tables(0).Rows(0).Item("Pack_Amount")
                End If
                If Not IsDBNull(ds.Tables(0).Rows(0).Item("Pack_Weight")) Then
                    Me.txtPackWeight.Text = ds.Tables(0).Rows(0).Item("Pack_Weight")
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
                txtSeem.Text = ds.Tables(0).Rows(0).Item("COMMISSURE_QUALITY")
                txtCause.Text = ds.Tables(0).Rows(0).Item("CAUSE")
                txtResult.Text = ds.Tables(0).Rows(0).Item("RESULT")

                Call Me.dtpTimeBegin_Leave(sender, e)
                Me.cbClerk1.SelectedValue = ds.Tables(0).Rows(0).Item("TALLY_CLERK1")
                cbClerk2.SelectedValue = ds.Tables(0).Rows(0).Item("TALLY_CLERK2")
                cbClerk3.SelectedValue = ds.Tables(0).Rows(0).Item("TALLY_CLERK3")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub dtpTimeBegin_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            If Me.dtpTimeBegin.Value.Hour < 10 Then
                strTime = "0" & Me.dtpTimeBegin.Value.Hour
            Else
                strTime = Me.dtpTimeBegin.Value.Hour
            End If
            If Me.dtpTimeBegin.Value.Minute < 10 Then
                strTime = strTime & "0" & Me.dtpTimeBegin.Value.Minute
            Else
                strTime = strTime & Me.dtpTimeBegin.Value.Minute
            End If
            sqlClerk = "exec sp_clerk '" & G_DeptCode & "','" & Ship_ID & "','" & strTime & "','" & Me.dtpTimeBegin.Value.Date & "'"
            dvClerk1 = Filldata(sqlClerk)
            dvClerk2 = Filldata(sqlClerk)
            dvclerk3 = Filldata(sqlClerk)
            Me.cbClerk1.DataSource = dvClerk1
            Me.cbClerk1.DisplayMember = "name"
            Me.cbClerk1.ValueMember = "work_no"

            Me.cbClerk2.DataSource = dvClerk2
            Me.cbClerk2.DisplayMember = "name"
            Me.cbClerk2.ValueMember = "work_no"

            Me.cbClerk3.DataSource = dvclerk3
            Me.cbClerk3.DisplayMember = "name"
            Me.cbClerk3.ValueMember = "work_no"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
