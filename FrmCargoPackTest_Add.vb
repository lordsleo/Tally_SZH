Imports TALLY.DBControl
Public Class FrmCargoPackTest_Add
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim sqlBillNo As String
    Dim dwBillNo As New DataView()
    Dim sqlPMType As String
    Dim dvPMType As New DataView()
    Dim sqlTestDate As String
    Dim dvTestDate As New DataView()
    Dim sqlDayNight As String
    Dim dvDayNight As New DataView()
    Dim sqlGetBillInfo As String
    Dim dvGetBillinfo As New DataView()

    Dim sqlGetTime As String
    Dim dvGetTime As New DataView()

    Dim row As DataRow
    Dim TestDate As Date

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        AddHandler cbBillNo.KeyDown, AddressOf FrmCargoPackTest_Add_KeyDown
        AddHandler cbTestDate.KeyDown, AddressOf FrmCargoPackTest_Add_KeyDown
        AddHandler cbDayOrNight.KeyDown, AddressOf FrmCargoPackTest_Add_KeyDown
        AddHandler cbPMType.KeyDown, AddressOf FrmCargoPackTest_Add_KeyDown
        AddHandler txtTimeBegin.KeyDown, AddressOf FrmCargoPackTest_Add_KeyDown
        AddHandler txtTimeEnd.KeyDown, AddressOf FrmCargoPackTest_Add_KeyDown
        'AddHandler txtWorkAmount.KeyDown, AddressOf FrmCargoPackTest_Add_KeyDown
        AddHandler txtTestAmount.KeyDown, AddressOf FrmCargoPackTest_Add_KeyDown
        AddHandler txtErrorAmount.KeyDown, AddressOf FrmCargoPackTest_Add_KeyDown
        AddHandler txtAverageWeight.KeyDown, AddressOf FrmCargoPackTest_Add_KeyDown
        AddHandler txtMostWeight.KeyDown, AddressOf FrmCargoPackTest_Add_KeyDown
        AddHandler txtLeastWeight.KeyDown, AddressOf FrmCargoPackTest_Add_KeyDown
        AddHandler txtQuality.KeyDown, AddressOf FrmCargoPackTest_Add_KeyDown
        AddHandler txtCause.KeyDown, AddressOf FrmCargoPackTest_Add_KeyDown
        AddHandler txtResult.KeyDown, AddressOf FrmCargoPackTest_Add_KeyDown
        AddHandler txtReMark.KeyDown, AddressOf FrmCargoPackTest_Add_KeyDown
        AddHandler txtTestPerson.KeyDown, AddressOf FrmCargoPackTest_Add_KeyDown
        AddHandler cbBillNo.KeyDown, AddressOf FrmCargoPackTest_Add_KeyDown

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
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents txtLeastWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtTestPerson As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAverageWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCause As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMostWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEligibleRate As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtGoods As System.Windows.Forms.TextBox
    Friend WithEvents cbBillNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents cbDayOrNight As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbPMType As System.Windows.Forms.ComboBox
    Friend WithEvents txtTimeEnd As System.Windows.Forms.TextBox
    Friend WithEvents txtTimeBegin As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cbTestDate As System.Windows.Forms.ComboBox
    Friend WithEvents txtTestAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtErrorAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtStandardWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtWorkAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtTestRate As System.Windows.Forms.TextBox
    Friend WithEvents txtReMark As System.Windows.Forms.TextBox
    Friend WithEvents txtQuality As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtResult = New System.Windows.Forms.TextBox
        Me.txtLeastWeight = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtTestPerson = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtTestAmount = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtErrorAmount = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtAverageWeight = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtStandardWeight = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCause = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtMostWeight = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtQuality = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtEligibleRate = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.txtGoods = New System.Windows.Forms.TextBox
        Me.cbBillNo = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.cbDayOrNight = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cbPMType = New System.Windows.Forms.ComboBox
        Me.txtTimeEnd = New System.Windows.Forms.TextBox
        Me.txtTimeBegin = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtWorkAmount = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtTestRate = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtReMark = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.cbTestDate = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(176, 274)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(30, 20)
        Me.Label25.TabIndex = 534
        Me.Label25.Text = "%"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(382, 34)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(30, 20)
        Me.Label24.TabIndex = 533
        Me.Label24.Text = "公斤"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(382, 10)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(30, 20)
        Me.Label26.TabIndex = 532
        Me.Label26.Text = "公斤"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(176, 322)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(30, 20)
        Me.Label27.TabIndex = 531
        Me.Label27.Text = "公斤"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(176, 298)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(30, 20)
        Me.Label28.TabIndex = 530
        Me.Label28.Text = "公斤"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(214, 208)
        Me.txtResult.MaxLength = 100
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(198, 42)
        Me.txtResult.TabIndex = 18
        Me.txtResult.Text = ""
        '
        'txtLeastWeight
        '
        Me.txtLeastWeight.Location = New System.Drawing.Point(288, 32)
        Me.txtLeastWeight.MaxLength = 10
        Me.txtLeastWeight.Name = "txtLeastWeight"
        Me.txtLeastWeight.Size = New System.Drawing.Size(94, 21)
        Me.txtLeastWeight.TabIndex = 15
        Me.txtLeastWeight.Text = ""
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(214, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 20)
        Me.Label16.TabIndex = 529
        Me.Label16.Text = "最低件重"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTestPerson
        '
        Me.txtTestPerson.Location = New System.Drawing.Point(288, 320)
        Me.txtTestPerson.MaxLength = 10
        Me.txtTestPerson.Name = "txtTestPerson"
        Me.txtTestPerson.Size = New System.Drawing.Size(124, 21)
        Me.txtTestPerson.TabIndex = 20
        Me.txtTestPerson.Text = ""
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(214, 320)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 20)
        Me.Label15.TabIndex = 528
        Me.Label15.Text = "抽检员"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTestAmount
        '
        Me.txtTestAmount.Location = New System.Drawing.Point(82, 200)
        Me.txtTestAmount.MaxLength = 10
        Me.txtTestAmount.Name = "txtTestAmount"
        Me.txtTestAmount.Size = New System.Drawing.Size(124, 21)
        Me.txtTestAmount.TabIndex = 8
        Me.txtTestAmount.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 200)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 20)
        Me.Label13.TabIndex = 527
        Me.Label13.Text = "抽衡件数"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtErrorAmount
        '
        Me.txtErrorAmount.Location = New System.Drawing.Point(82, 248)
        Me.txtErrorAmount.MaxLength = 10
        Me.txtErrorAmount.Name = "txtErrorAmount"
        Me.txtErrorAmount.Size = New System.Drawing.Size(124, 21)
        Me.txtErrorAmount.TabIndex = 10
        Me.txtErrorAmount.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 248)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 20)
        Me.Label12.TabIndex = 526
        Me.Label12.Text = "不合格件数"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAverageWeight
        '
        Me.txtAverageWeight.Location = New System.Drawing.Point(82, 320)
        Me.txtAverageWeight.MaxLength = 10
        Me.txtAverageWeight.Name = "txtAverageWeight"
        Me.txtAverageWeight.Size = New System.Drawing.Size(94, 21)
        Me.txtAverageWeight.TabIndex = 13
        Me.txtAverageWeight.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 320)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 20)
        Me.Label11.TabIndex = 525
        Me.Label11.Text = "平均件重"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStandardWeight
        '
        Me.txtStandardWeight.Enabled = False
        Me.txtStandardWeight.Location = New System.Drawing.Point(82, 296)
        Me.txtStandardWeight.MaxLength = 10
        Me.txtStandardWeight.Name = "txtStandardWeight"
        Me.txtStandardWeight.Size = New System.Drawing.Size(94, 21)
        Me.txtStandardWeight.TabIndex = 12
        Me.txtStandardWeight.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 296)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 20)
        Me.Label10.TabIndex = 524
        Me.Label10.Text = "标准件重"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(214, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 523
        Me.Label6.Text = "处理结果"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCause
        '
        Me.txtCause.Location = New System.Drawing.Point(214, 142)
        Me.txtCause.MaxLength = 100
        Me.txtCause.Multiline = True
        Me.txtCause.Name = "txtCause"
        Me.txtCause.Size = New System.Drawing.Size(198, 42)
        Me.txtCause.TabIndex = 17
        Me.txtCause.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(214, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 522
        Me.Label5.Text = "原因"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMostWeight
        '
        Me.txtMostWeight.Location = New System.Drawing.Point(288, 8)
        Me.txtMostWeight.MaxLength = 10
        Me.txtMostWeight.Name = "txtMostWeight"
        Me.txtMostWeight.Size = New System.Drawing.Size(94, 21)
        Me.txtMostWeight.TabIndex = 14
        Me.txtMostWeight.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(214, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 521
        Me.Label3.Text = "最高件重"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQuality
        '
        Me.txtQuality.Location = New System.Drawing.Point(214, 76)
        Me.txtQuality.MaxLength = 50
        Me.txtQuality.Multiline = True
        Me.txtQuality.Name = "txtQuality"
        Me.txtQuality.Size = New System.Drawing.Size(198, 42)
        Me.txtQuality.TabIndex = 16
        Me.txtQuality.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(214, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 520
        Me.Label1.Text = "缝口质量"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEligibleRate
        '
        Me.txtEligibleRate.Enabled = False
        Me.txtEligibleRate.Location = New System.Drawing.Point(82, 272)
        Me.txtEligibleRate.MaxLength = 10
        Me.txtEligibleRate.Name = "txtEligibleRate"
        Me.txtEligibleRate.Size = New System.Drawing.Size(94, 21)
        Me.txtEligibleRate.TabIndex = 11
        Me.txtEligibleRate.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 519
        Me.Label2.Text = "抽衡合格率"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(246, 350)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 23
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(178, 350)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 21
        Me.btSave.Text = "确认"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(110, 350)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(65, 24)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "清空"
        '
        'txtGoods
        '
        Me.txtGoods.Enabled = False
        Me.txtGoods.Location = New System.Drawing.Point(82, 32)
        Me.txtGoods.MaxLength = 20
        Me.txtGoods.Name = "txtGoods"
        Me.txtGoods.Size = New System.Drawing.Size(124, 21)
        Me.txtGoods.TabIndex = 1
        Me.txtGoods.Text = ""
        '
        'cbBillNo
        '
        Me.cbBillNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBillNo.Location = New System.Drawing.Point(82, 8)
        Me.cbBillNo.MaxLength = 20
        Me.cbBillNo.Name = "cbBillNo"
        Me.cbBillNo.Size = New System.Drawing.Size(124, 20)
        Me.cbBillNo.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(8, 32)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 20)
        Me.Label17.TabIndex = 540
        Me.Label17.Text = "货名"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(8, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 539
        Me.Label4.Text = "提单号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(4, 4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 538
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'cbDayOrNight
        '
        Me.cbDayOrNight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDayOrNight.Items.AddRange(New Object() {"白班", "夜班"})
        Me.cbDayOrNight.Location = New System.Drawing.Point(82, 80)
        Me.cbDayOrNight.Name = "cbDayOrNight"
        Me.cbDayOrNight.Size = New System.Drawing.Size(124, 20)
        Me.cbDayOrNight.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 547
        Me.Label7.Text = "白夜班"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 546
        Me.Label8.Text = "完工日期"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 20)
        Me.Label14.TabIndex = 545
        Me.Label14.Text = "人机灌包别"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbPMType
        '
        Me.cbPMType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPMType.Location = New System.Drawing.Point(82, 104)
        Me.cbPMType.Name = "cbPMType"
        Me.cbPMType.Size = New System.Drawing.Size(124, 20)
        Me.cbPMType.TabIndex = 4
        '
        'txtTimeEnd
        '
        Me.txtTimeEnd.Location = New System.Drawing.Point(82, 152)
        Me.txtTimeEnd.MaxLength = 4
        Me.txtTimeEnd.Name = "txtTimeEnd"
        Me.txtTimeEnd.Size = New System.Drawing.Size(124, 21)
        Me.txtTimeEnd.TabIndex = 6
        Me.txtTimeEnd.Text = ""
        '
        'txtTimeBegin
        '
        Me.txtTimeBegin.Location = New System.Drawing.Point(82, 128)
        Me.txtTimeBegin.MaxLength = 4
        Me.txtTimeBegin.Name = "txtTimeBegin"
        Me.txtTimeBegin.Size = New System.Drawing.Size(124, 21)
        Me.txtTimeBegin.TabIndex = 5
        Me.txtTimeBegin.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 20)
        Me.Label9.TabIndex = 550
        Me.Label9.Text = "结束时间"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(8, 128)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 20)
        Me.Label18.TabIndex = 549
        Me.Label18.Text = "开始时间"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWorkAmount
        '
        Me.txtWorkAmount.Enabled = False
        Me.txtWorkAmount.Location = New System.Drawing.Point(82, 176)
        Me.txtWorkAmount.MaxLength = 10
        Me.txtWorkAmount.Name = "txtWorkAmount"
        Me.txtWorkAmount.Size = New System.Drawing.Size(124, 21)
        Me.txtWorkAmount.TabIndex = 7
        Me.txtWorkAmount.Text = ""
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(8, 176)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 20)
        Me.Label19.TabIndex = 554
        Me.Label19.Text = "灌包件数"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(176, 226)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(30, 20)
        Me.Label20.TabIndex = 557
        Me.Label20.Text = "%"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTestRate
        '
        Me.txtTestRate.Enabled = False
        Me.txtTestRate.Location = New System.Drawing.Point(82, 224)
        Me.txtTestRate.MaxLength = 10
        Me.txtTestRate.Name = "txtTestRate"
        Me.txtTestRate.Size = New System.Drawing.Size(94, 21)
        Me.txtTestRate.TabIndex = 9
        Me.txtTestRate.Text = ""
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(8, 224)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 20)
        Me.Label21.TabIndex = 556
        Me.Label21.Text = "抽衡率"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReMark
        '
        Me.txtReMark.Location = New System.Drawing.Point(214, 274)
        Me.txtReMark.MaxLength = 100
        Me.txtReMark.Multiline = True
        Me.txtReMark.Name = "txtReMark"
        Me.txtReMark.Size = New System.Drawing.Size(198, 42)
        Me.txtReMark.TabIndex = 19
        Me.txtReMark.Text = ""
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(214, 254)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 20)
        Me.Label22.TabIndex = 559
        Me.Label22.Text = "其它说明"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbTestDate
        '
        Me.cbTestDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTestDate.Location = New System.Drawing.Point(82, 56)
        Me.cbTestDate.Name = "cbTestDate"
        Me.cbTestDate.Size = New System.Drawing.Size(124, 20)
        Me.cbTestDate.TabIndex = 2
        '
        'FrmCargoPackTest_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(420, 379)
        Me.Controls.Add(Me.cbTestDate)
        Me.Controls.Add(Me.txtReMark)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtTestRate)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtWorkAmount)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtTimeEnd)
        Me.Controls.Add(Me.txtTimeBegin)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cbDayOrNight)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbPMType)
        Me.Controls.Add(Me.txtGoods)
        Me.Controls.Add(Me.cbBillNo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtLeastWeight)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtTestPerson)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtTestAmount)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtErrorAmount)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtAverageWeight)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtStandardWeight)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCause)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMostWeight)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtQuality)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEligibleRate)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargoPackTest_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "散货灌包工班质检日报 增加"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCargoPackTest_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String

        sqlBillNo = "SELECT * FROM CARGO_GOODS WHERE SHIP_ID = '" & Ship_ID & "'"

        dwBillNo = Filldata(sqlBillNo)
        cbBillNo.DataSource = dwBillNo
        cbBillNo.DisplayMember = "BLNO"
        cbBillNo.ValueMember = "BLNO"

        sqlstr = "select * from CARGO_PACK_Sample where CARGO_PACK_Sample_ID =" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        sqlGetTime = "SELECT DAY_TIME, NIGHT_TIME FROM WORK_TIME WHERE (WORK_TIME_ID = 1)"
        dvGetTime = Filldata(sqlGetTime)

        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("CARGO_PACK_Sample_ID")
            cbBillNo.SelectedValue = ds.Tables(0).Rows(0).Item("BillNO")
            Call Me.cbBillNo_SelectedValueChanged(sender, e)
            Me.cbTestDate.SelectedValue = ds.Tables(0).Rows(0).Item("TestDate")
            Me.cbDayOrNight.SelectedValue = ds.Tables(0).Rows(0).Item("DayOrNight")
            Me.txtTimeBegin.Text = ds.Tables(0).Rows(0).Item("TIMEFROM")
            Me.txtTimeEnd.Text = ds.Tables(0).Rows(0).Item("TIMETO")
            cbPMType.SelectedValue = ds.Tables(0).Rows(0).Item("P_M_TYPE")
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("Work_Amount")) Then
                Me.txtWorkAmount.Text = ds.Tables(0).Rows(0).Item("Work_Amount")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("Test_Amount")) Then
                Me.txtTestAmount.Text = ds.Tables(0).Rows(0).Item("Test_Amount")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("TEST_Rate")) Then
                Me.txtTestRate.Text = ds.Tables(0).Rows(0).Item("TEST_Rate")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("Error_Amount")) Then
                Me.txtErrorAmount.Text = ds.Tables(0).Rows(0).Item("Error_Amount")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("ELIGIBLE_Rate")) Then
                Me.txtEligibleRate.Text = ds.Tables(0).Rows(0).Item("ELIGIBLE_Rate")
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
            Me.txtQuality.Text = ds.Tables(0).Rows(0).Item("QUALITY")
            Me.txtCause.Text = ds.Tables(0).Rows(0).Item("CAUSE")
            Me.txtResult.Text = ds.Tables(0).Rows(0).Item("RESULT")
            Me.txtReMark.Text = ds.Tables(0).Rows(0).Item("Remark")
            Me.txtTestPerson.Text = ds.Tables(0).Rows(0).Item("TEST_PERSON")
        Else
            Call Me.cbBillNo_SelectedValueChanged(sender, e)
        End If
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim sqlExist As String
        TestDate = Me.cbTestDate.SelectedValue
        sqlExist = "select * from CARGO_PACK_Sample WHERE (SHIP_ID = '" & Ship_ID & "') AND (BillNO = '" & Me.cbBillNo.SelectedValue & "') AND (YEAR(TestDate) = '" & TestDate.Year & "') AND (MONTH(TestDate) = '" & TestDate.Month & "') AND (DAY(TestDate) = '" & TestDate.Day & "') AND (DayOrNight = '" & Me.cbDayOrNight.SelectedValue & "') AND (P_M_TYPE = '" & Me.cbPMType.SelectedValue & "')"
        Try
            If dwBillNo.Count = 0 Then
                MessageBox.Show("该船次的货物情况尚未录入，无法执行操作。", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                Exit Sub
            End If
            If dvPMType.Count > 0 Then
                If Me.txtTimeBegin.Text Like "[0-1]#[0-5]#" Or Me.txtTimeBegin.Text Like "2[0-3][0-5]#" Then
                    If Me.txtTimeEnd.Text Like "[0-1]#[0-5]#" Or Me.txtTimeBegin.Text Like "2[0-3][0-5]#" Then

                        'If DateDiff(DateInterval.Minute, dtpTimeBegin.Value, dtpTimeEnd.Value) > 0 Then
                        row = ds.Tables(0).NewRow

                        If SetNumValue("Work_Amount", txtWorkAmount.Text, "灌包件数") = False Then
                            Me.txtWorkAmount.Focus()
                            Exit Sub
                        ElseIf SetNumValue("Test_Amount", txtTestAmount.Text, "抽衡件数") = False Then
                            Me.txtTestAmount.Focus()
                            Exit Sub
                        ElseIf SetNumValue("TEST_Rate", txtTestRate.Text, "抽衡率") = False Then
                            Me.txtTestRate.Focus()
                            Exit Sub
                        ElseIf SetNumValue("Error_Amount", txtErrorAmount.Text, "不合格件数") = False Then
                            Me.txtErrorAmount.Focus()
                            Exit Sub
                        ElseIf SetNumValue("ELIGIBLE_Rate", txtEligibleRate.Text, "合格率") = False Then
                            Me.txtEligibleRate.Focus()
                            Exit Sub
                        ElseIf SetNumValue("AVERAGE_WEIGHT", txtAverageWeight.Text, "平均件重") = False Then
                            Me.txtAverageWeight.Focus()
                            Exit Sub
                        ElseIf SetNumValue("MOST_WEIGHT", txtMostWeight.Text, "最高件重") = False Then
                            Me.txtMostWeight.Focus()
                            Exit Sub
                        ElseIf SetNumValue("LEAST_WEIGHT", txtLeastWeight.Text, "最低件重") = False Then
                            Me.txtLeastWeight.Focus()
                            Exit Sub
                        End If
                        row.Item("BillNO") = cbBillNo.SelectedValue
                        row.Item("TestDate") = Me.cbTestDate.SelectedValue
                        row.Item("DayOrNight") = Me.cbDayOrNight.SelectedValue
                        row.Item("TIMEFROM") = Me.txtTimeBegin.Text
                        row.Item("TIMETO") = Me.txtTimeEnd.Text
                        'TestCodeNo
                        row.Item("P_M_TYPE") = cbPMType.SelectedValue
                        row.Item("QUALITY") = Trim(txtQuality.Text)
                        row.Item("CAUSE") = Trim(txtCause.Text)
                        row.Item("RESULT") = Trim(txtResult.Text)
                        row.Item("TEST_PERSON") = Trim(txtTestPerson.Text)
                        row.Item("Remark") = Trim(Me.txtReMark.Text)

                        row.Item("SHIP_ID") = Ship_ID
                        row.Item("DEPT_CODE") = G_DeptCode
                        row.Item("USER_NAME") = G_User

                        If Filldata(sqlExist).Count = 0 Then
                            ds.Tables(0).Rows.Add(row)
                            sqlda.Update(ds)
                            Me.Close()
                        Else
                            Me.cbBillNo.Focus()
                            MessageBox.Show("同一船次 提单号 日期 白夜班 人机灌包别 不能重复。", "提示", MessageBoxButtons.OK)
                        End If
                        'Else
                        '    MessageBox.Show("作业起时间应在止时间之前。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        'End If
                    Else
                        Me.txtTimeEnd.Focus()
                        MessageBox.Show("结束时间不正确。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    Me.txtTimeBegin.Focus()
                    MessageBox.Show("开始时间不正确。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                Me.cbBillNo.Focus()
                MessageBox.Show("该船次此提单的理货单尚未录入，无法增加。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbBillNo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBillNo.SelectedValueChanged
        Try
            If TypeName(cbBillNo.SelectedValue) = "String" Then
                sqlGetBillInfo = "SELECT * FROM CARGO_GOODS WHERE SHIP_ID = '" & Ship_ID & "' and BLNO = '" & cbBillNo.SelectedValue & "'"
                dvGetBillinfo = Filldata(sqlGetBillInfo)
                If dvGetBillinfo.Count > 0 Then
                    Me.txtGoods.Text = dvGetBillinfo(0)("CODE_GOODS")
                    Me.txtStandardWeight.Text = dvGetBillinfo(0)("StandsWeight")
                End If

                sqlPMType = "SELECT DISTINCT P_M_TYPE, Name_PM FROM View_CargoGoodsPub WHERE (SHIP_ID = '" & Ship_ID & "') AND (BLNO = '" & Me.cbBillNo.SelectedValue & "')"
                dvPMType = Filldata(sqlPMType)
                cbPMType.DataSource = dvPMType
                cbPMType.DisplayMember = "Name_PM"
                cbPMType.ValueMember = "P_M_TYPE"

                sqlTestDate = "SELECT DISTINCT WorkDate, WorkDate2 FROM View_CargoGoodsPub WHERE (SHIP_ID = '" & Ship_ID & "') AND (BLNO = '" & Me.cbBillNo.SelectedValue & "')"
                dvTestDate = Filldata(sqlTestDate)
                Me.cbTestDate.DataSource = dvTestDate
                cbTestDate.DisplayMember = "WorkDate2"
                cbTestDate.ValueMember = "WorkDate"

                sqlDayNight = "SELECT DISTINCT DayOrNight, WorkTime FROM View_CargoGoodsPub WHERE (SHIP_ID = '" & Ship_ID & "') AND (BLNO = '" & Me.cbBillNo.SelectedValue & "')"
                dvDayNight = Filldata(sqlDayNight)
                Me.cbDayOrNight.DataSource = dvDayNight
                Me.cbDayOrNight.DisplayMember = "WorkTime"
                Me.cbDayOrNight.ValueMember = "DayOrNight"

                Call cbPMType_SelectedValueChanged(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function SetNumValue(ByVal strNumColumn As String, ByVal strNumValue As String, Optional ByVal message As String = "数据") As Boolean
        Dim flag As Boolean = True
        If Trim(strNumValue) <> "" Then     '
            If IsNumeric(Trim(strNumValue)) Then
                row.Item(strNumColumn) = Trim(strNumValue)
            Else
                MessageBox.Show(message + "应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                flag = False
            End If
        Else    '此列留空
        End If
        Return flag
    End Function

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.txtTestAmount.Clear()
        Me.txtTestRate.Clear()
        Me.txtErrorAmount.Clear()
        Me.txtEligibleRate.Clear()
        Me.txtAverageWeight.Clear()
        Me.txtMostWeight.Clear()
        Me.txtLeastWeight.Clear()
        Me.txtQuality.Clear()
        Me.txtCause.Clear()
        Me.txtResult.Clear()
        Me.txtTestPerson.Clear()
        Me.txtReMark.Clear()
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub txtTestAmount_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTestAmount.Leave
        Call txtWorkAmount_TextChanged(sender, e)
        Call txtErrorAmount_Leave(sender, e)
    End Sub

    Private Sub txtWorkAmount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtWorkAmount.TextChanged
        txtTestRate.Clear()
        If IsNumeric(Me.txtWorkAmount.Text) And IsNumeric(Me.txtTestAmount.Text) Then
            If CInt(Me.txtWorkAmount.Text) <> 0 Then
                Me.txtTestRate.Text = Decimal.Round(Convert.ToDecimal(Me.txtTestAmount.Text * 100 / Me.txtWorkAmount.Text), 3)
            End If
        End If
    End Sub

    Private Sub txtErrorAmount_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtErrorAmount.Leave
        txtEligibleRate.Clear()
        If IsNumeric(Me.txtErrorAmount.Text) And IsNumeric(Me.txtTestAmount.Text) Then
            If CInt(Me.txtTestAmount.Text) <> 0 Then
                Me.txtEligibleRate.Text = Decimal.Round(Convert.ToDecimal((Me.txtTestAmount.Text - Me.txtErrorAmount.Text) * 100 / Me.txtTestAmount.Text), 3)
            End If
        End If
    End Sub

    Private Sub cbPMType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPMType.SelectedValueChanged
        Me.txtWorkAmount.Clear()
        Try
            If TypeName(cbPMType.SelectedValue) = "String" Then
                Dim sqlGetWorkAmount As String
                Dim dvGetWorkAmount As New DataView()
                TestDate = Me.cbTestDate.SelectedValue
                sqlGetWorkAmount = "SELECT SUM(Pack_Amount) AS WorkAmount FROM CARGO_PACK_SHEET WHERE (SHIP_ID = '" & Ship_ID & "') AND (BLNO = '" & Me.cbBillNo.SelectedValue & "') AND (YEAR(WorkDate) = '" & TestDate.Year & "') AND (MONTH(WorkDate) = '" & TestDate.Month & "') AND (DAY(WorkDate) = '" & TestDate.Day & "') AND (DayOrNight = '" & Me.cbDayOrNight.SelectedValue & "') AND (P_M_TYPE = '" & Me.cbPMType.SelectedValue & "')"
                dvGetWorkAmount = Filldata(sqlGetWorkAmount)
                If Not IsDBNull(dvGetWorkAmount(0)("WorkAmount")) Then
                    Me.txtWorkAmount.Text = dvGetWorkAmount(0)("WorkAmount")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbDayOrNight_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDayOrNight.Leave
        Call cbPMType_SelectedValueChanged(sender, e)
    End Sub

    Private Sub cbTestDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTestDate.Leave
        Call cbPMType_SelectedValueChanged(sender, e)
    End Sub

    Private Sub cbDayOrNight_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDayOrNight.SelectedValueChanged
        If dvGetTime.Count > 0 Then
            If Me.cbDayOrNight.SelectedValue = "01" Then   '白班
                Me.txtTimeBegin.Text = dvGetTime(0)("DAY_TIME")
                Me.txtTimeEnd.Text = dvGetTime(0)("NIGHT_TIME")
            Else    '夜班
                Me.txtTimeBegin.Text = dvGetTime(0)("NIGHT_TIME")
                Me.txtTimeEnd.Text = dvGetTime(0)("DAY_TIME")
            End If
        End If
    End Sub

    Private Sub FrmCargoPackTest_Add_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.cbBillNo.Focused Then
                Me.cbTestDate.Focus()
                Exit Sub
            ElseIf Me.cbTestDate.Focused Then
                Me.cbDayOrNight.Focus()
            ElseIf Me.cbDayOrNight.Focused Then
                Me.cbPMType.Focus()
            ElseIf Me.cbPMType.Focused Then
                Me.txtTimeBegin.Focus()
            ElseIf Me.txtTimeBegin.Focused Then
                Me.txtTimeEnd.Focus()
            ElseIf Me.txtTimeEnd.Focused Then
                '    Me.txtWorkAmount.Focus()
                'ElseIf Me.txtWorkAmount.Focused Then
                Me.txtTestAmount.Focus()
            ElseIf Me.txtTestAmount.Focused Then
                Me.txtErrorAmount.Focus()
            ElseIf Me.txtErrorAmount.Focused Then
                Me.txtAverageWeight.Focus()
            ElseIf Me.txtAverageWeight.Focused Then
                Me.txtMostWeight.Focus()
            ElseIf Me.txtMostWeight.Focused Then
                Me.txtLeastWeight.Focus()
            ElseIf Me.txtLeastWeight.Focused Then
                Me.txtQuality.Focus()
            ElseIf Me.txtQuality.Focused Then
                Me.txtCause.Focus()
            ElseIf Me.txtCause.Focused Then
                Me.txtResult.Focus()
            ElseIf Me.txtResult.Focused Then
                Me.txtReMark.Focus()
            ElseIf Me.txtReMark.Focused Then
                Me.txtTestPerson.Focus()
            ElseIf Me.txtTestPerson.Focused Then
                Me.btSave.Focus()
            End If
        End If
    End Sub
End Class
