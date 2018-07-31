Imports TALLY.DBControl
Public Class FrmCargoPackSheet_Edit
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dwCompany As New DataView()
    Dim dwBillNo As New DataView()
    Dim dwCodeGoods As New DataView()
    Dim sqlCodeGoods, sqlBillNo, sqlCompany As String

    Dim strTime As String
    Dim sqlClerk As String
    Dim dvClerk1 As New DataView()
    Dim dvClerk2 As New DataView()
    Dim dvclerk3 As New DataView()
    Dim sqlGetTime As String
    Dim dvGetTime As New DataView()

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        AddHandler cbBillNo.KeyDown, AddressOf FrmCargoPackSheet_Add_KeyDown
        AddHandler dtpWorkDate.KeyDown, AddressOf FrmCargoPackSheet_Add_KeyDown
        AddHandler cbDayOrNight.KeyDown, AddressOf FrmCargoPackSheet_Add_KeyDown
        AddHandler cbPMType.KeyDown, AddressOf FrmCargoPackSheet_Add_KeyDown
        AddHandler txtYardNo.KeyDown, AddressOf FrmCargoPackSheet_Add_KeyDown
        AddHandler txtCargoNo.KeyDown, AddressOf FrmCargoPackSheet_Add_KeyDown
        AddHandler txtMark.KeyDown, AddressOf FrmCargoPackSheet_Add_KeyDown
        AddHandler cbPack.KeyDown, AddressOf FrmCargoPackSheet_Add_KeyDown
        AddHandler txtPackAmount.KeyDown, AddressOf FrmCargoPackSheet_Add_KeyDown
        AddHandler txtOperate.KeyDown, AddressOf FrmCargoPackSheet_Add_KeyDown
        AddHandler txtWorkGroup.KeyDown, AddressOf FrmCargoPackSheet_Add_KeyDown
        AddHandler cbYesOrNo.KeyDown, AddressOf FrmCargoPackSheet_Add_KeyDown
        AddHandler txtTimeBegin.KeyDown, AddressOf FrmCargoPackSheet_Add_KeyDown
        AddHandler txtTimeEnd.KeyDown, AddressOf FrmCargoPackSheet_Add_KeyDown
        AddHandler cbClerk1.KeyDown, AddressOf FrmCargoPackSheet_Add_KeyDown
        AddHandler cbClerk2.KeyDown, AddressOf FrmCargoPackSheet_Add_KeyDown
        AddHandler cbClerk3.KeyDown, AddressOf FrmCargoPackSheet_Add_KeyDown
        AddHandler txtRemark.KeyDown, AddressOf FrmCargoPackSheet_Add_KeyDown
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
    Friend WithEvents txtGoods As System.Windows.Forms.TextBox
    Friend WithEvents cbYesOrNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtWorkGroup As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtOperate As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbPack As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMark As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCargoNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbDayOrNight As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTimeEnd As System.Windows.Forms.TextBox
    Friend WithEvents txtTimeBegin As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbClerk3 As System.Windows.Forms.ComboBox
    Friend WithEvents cbClerk2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbClerk1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtPackAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cbBillNo As System.Windows.Forms.ComboBox
    Friend WithEvents cbCompany As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtYardNo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpWorkDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbPMType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtGoods = New System.Windows.Forms.TextBox
        Me.cbYesOrNo = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtRemark = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtWorkGroup = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtOperate = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cbPack = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMark = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCargoNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbDayOrNight = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTimeEnd = New System.Windows.Forms.TextBox
        Me.txtTimeBegin = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbClerk3 = New System.Windows.Forms.ComboBox
        Me.cbClerk2 = New System.Windows.Forms.ComboBox
        Me.cbClerk1 = New System.Windows.Forms.ComboBox
        Me.txtPackAmount = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.cbBillNo = New System.Windows.Forms.ComboBox
        Me.cbCompany = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtYardNo = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtpWorkDate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbPMType = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtGoods
        '
        Me.txtGoods.Enabled = False
        Me.txtGoods.Location = New System.Drawing.Point(80, 32)
        Me.txtGoods.MaxLength = 20
        Me.txtGoods.Name = "txtGoods"
        Me.txtGoods.Size = New System.Drawing.Size(124, 21)
        Me.txtGoods.TabIndex = 531
        Me.txtGoods.Text = ""
        '
        'cbYesOrNo
        '
        Me.cbYesOrNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbYesOrNo.Items.AddRange(New Object() {"有问题", "无问题"})
        Me.cbYesOrNo.Location = New System.Drawing.Point(286, 56)
        Me.cbYesOrNo.Name = "cbYesOrNo"
        Me.cbYesOrNo.Size = New System.Drawing.Size(124, 20)
        Me.cbYesOrNo.TabIndex = 543
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(212, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 20)
        Me.Label13.TabIndex = 573
        Me.Label13.Text = "质量"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(212, 220)
        Me.txtRemark.MaxLength = 50
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(198, 50)
        Me.txtRemark.TabIndex = 550
        Me.txtRemark.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(212, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 20)
        Me.Label12.TabIndex = 553
        Me.Label12.Text = "备注"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWorkGroup
        '
        Me.txtWorkGroup.Location = New System.Drawing.Point(286, 32)
        Me.txtWorkGroup.MaxLength = 10
        Me.txtWorkGroup.Name = "txtWorkGroup"
        Me.txtWorkGroup.Size = New System.Drawing.Size(124, 21)
        Me.txtWorkGroup.TabIndex = 542
        Me.txtWorkGroup.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(212, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 20)
        Me.Label11.TabIndex = 572
        Me.Label11.Text = "班组"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOperate
        '
        Me.txtOperate.Location = New System.Drawing.Point(286, 8)
        Me.txtOperate.MaxLength = 10
        Me.txtOperate.Name = "txtOperate"
        Me.txtOperate.Size = New System.Drawing.Size(124, 21)
        Me.txtOperate.TabIndex = 541
        Me.txtOperate.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(212, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 20)
        Me.Label10.TabIndex = 571
        Me.Label10.Text = "操作过程"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbPack
        '
        Me.cbPack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPack.ItemHeight = 12
        Me.cbPack.Location = New System.Drawing.Point(80, 224)
        Me.cbPack.MaxDropDownItems = 20
        Me.cbPack.Name = "cbPack"
        Me.cbPack.Size = New System.Drawing.Size(124, 20)
        Me.cbPack.TabIndex = 539
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 570
        Me.Label6.Text = "包装"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(80, 200)
        Me.txtMark.MaxLength = 20
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(124, 21)
        Me.txtMark.TabIndex = 538
        Me.txtMark.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 569
        Me.Label5.Text = "标志"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCargoNo
        '
        Me.txtCargoNo.Location = New System.Drawing.Point(80, 176)
        Me.txtCargoNo.MaxLength = 5
        Me.txtCargoNo.Name = "txtCargoNo"
        Me.txtCargoNo.Size = New System.Drawing.Size(124, 21)
        Me.txtCargoNo.TabIndex = 537
        Me.txtCargoNo.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 568
        Me.Label3.Text = "货位号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbDayOrNight
        '
        Me.cbDayOrNight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDayOrNight.Location = New System.Drawing.Point(80, 104)
        Me.cbDayOrNight.Name = "cbDayOrNight"
        Me.cbDayOrNight.Size = New System.Drawing.Size(124, 20)
        Me.cbDayOrNight.TabIndex = 534
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 567
        Me.Label2.Text = "白夜班"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTimeEnd
        '
        Me.txtTimeEnd.Location = New System.Drawing.Point(286, 104)
        Me.txtTimeEnd.MaxLength = 4
        Me.txtTimeEnd.Name = "txtTimeEnd"
        Me.txtTimeEnd.Size = New System.Drawing.Size(124, 21)
        Me.txtTimeEnd.TabIndex = 545
        Me.txtTimeEnd.Text = ""
        '
        'txtTimeBegin
        '
        Me.txtTimeBegin.Location = New System.Drawing.Point(286, 80)
        Me.txtTimeBegin.MaxLength = 4
        Me.txtTimeBegin.Name = "txtTimeBegin"
        Me.txtTimeBegin.Size = New System.Drawing.Size(124, 21)
        Me.txtTimeBegin.TabIndex = 544
        Me.txtTimeBegin.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 566
        Me.Label1.Text = "完工日期"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbClerk3
        '
        Me.cbClerk3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClerk3.Location = New System.Drawing.Point(286, 176)
        Me.cbClerk3.Name = "cbClerk3"
        Me.cbClerk3.Size = New System.Drawing.Size(124, 20)
        Me.cbClerk3.TabIndex = 548
        '
        'cbClerk2
        '
        Me.cbClerk2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClerk2.Location = New System.Drawing.Point(286, 152)
        Me.cbClerk2.Name = "cbClerk2"
        Me.cbClerk2.Size = New System.Drawing.Size(124, 20)
        Me.cbClerk2.TabIndex = 547
        '
        'cbClerk1
        '
        Me.cbClerk1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClerk1.Location = New System.Drawing.Point(286, 128)
        Me.cbClerk1.Name = "cbClerk1"
        Me.cbClerk1.Size = New System.Drawing.Size(124, 20)
        Me.cbClerk1.TabIndex = 546
        '
        'txtPackAmount
        '
        Me.txtPackAmount.Location = New System.Drawing.Point(80, 248)
        Me.txtPackAmount.MaxLength = 10
        Me.txtPackAmount.Name = "txtPackAmount"
        Me.txtPackAmount.Size = New System.Drawing.Size(124, 21)
        Me.txtPackAmount.TabIndex = 540
        Me.txtPackAmount.Text = ""
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(6, 248)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 20)
        Me.Label23.TabIndex = 565
        Me.Label23.Text = "灌包件数"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbBillNo
        '
        Me.cbBillNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBillNo.Location = New System.Drawing.Point(80, 8)
        Me.cbBillNo.MaxLength = 20
        Me.cbBillNo.Name = "cbBillNo"
        Me.cbBillNo.Size = New System.Drawing.Size(124, 20)
        Me.cbBillNo.TabIndex = 530
        '
        'cbCompany
        '
        Me.cbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCompany.Enabled = False
        Me.cbCompany.ItemHeight = 12
        Me.cbCompany.Location = New System.Drawing.Point(80, 56)
        Me.cbCompany.Name = "cbCompany"
        Me.cbCompany.Size = New System.Drawing.Size(124, 20)
        Me.cbCompany.TabIndex = 532
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(212, 128)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 20)
        Me.Label19.TabIndex = 562
        Me.Label19.Text = "理货员1"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(6, 56)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 20)
        Me.Label18.TabIndex = 561
        Me.Label18.Text = "装卸公司"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(6, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 20)
        Me.Label14.TabIndex = 560
        Me.Label14.Text = "人机灌包别"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(212, 278)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 552
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(144, 278)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 549
        Me.btSave.Text = "确认"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(6, 32)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 20)
        Me.Label17.TabIndex = 559
        Me.Label17.Text = "货名"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtYardNo
        '
        Me.txtYardNo.Location = New System.Drawing.Point(80, 152)
        Me.txtYardNo.MaxLength = 20
        Me.txtYardNo.Name = "txtYardNo"
        Me.txtYardNo.Size = New System.Drawing.Size(124, 21)
        Me.txtYardNo.TabIndex = 536
        Me.txtYardNo.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 20)
        Me.Label9.TabIndex = 558
        Me.Label9.Text = "库场号"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(212, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 557
        Me.Label8.Text = "结束时间"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpWorkDate
        '
        Me.dtpWorkDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpWorkDate.Location = New System.Drawing.Point(80, 80)
        Me.dtpWorkDate.Name = "dtpWorkDate"
        Me.dtpWorkDate.Size = New System.Drawing.Size(124, 21)
        Me.dtpWorkDate.TabIndex = 533
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(212, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 556
        Me.Label7.Text = "开始时间"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbPMType
        '
        Me.cbPMType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPMType.Location = New System.Drawing.Point(80, 128)
        Me.cbPMType.Name = "cbPMType"
        Me.cbPMType.Size = New System.Drawing.Size(124, 20)
        Me.cbPMType.TabIndex = 535
        '
        'Label4
        '
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(6, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 555
        Me.Label4.Text = "提单号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 554
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(212, 176)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 20)
        Me.Label20.TabIndex = 563
        Me.Label20.Text = "理货员3"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(212, 152)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 20)
        Me.Label21.TabIndex = 564
        Me.Label21.Text = "理货员2"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCargoPackSheet_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(418, 307)
        Me.Controls.Add(Me.txtGoods)
        Me.Controls.Add(Me.cbYesOrNo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtWorkGroup)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtOperate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbPack)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMark)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCargoNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbDayOrNight)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTimeEnd)
        Me.Controls.Add(Me.txtTimeBegin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbClerk3)
        Me.Controls.Add(Me.cbClerk2)
        Me.Controls.Add(Me.cbClerk1)
        Me.Controls.Add(Me.txtPackAmount)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.cbBillNo)
        Me.Controls.Add(Me.cbCompany)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtYardNo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpWorkDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbPMType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargoPackSheet_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "散货灌包理货单信息 修改"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCargoPackSheet_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dw As New DataView()
        Dim sqlstr As String
        Dim dwPMType As New DataView()
        Dim sqlPMType As String
        Try
            sqlCompany = "SELECT Code, DepartMent FROM CodeCompany order by department"
            sqlPMType = "SELECT Code_PM, Name_PM FROM Code_PMType"
            sqlBillNo = "SELECT * FROM CARGO_GOODS WHERE SHIP_ID = '" & Ship_ID & "'"

            dwBillNo = Filldata(sqlBillNo)
            dwCompany = Filldata(sqlCompany)
            dwPMType = Filldata(sqlPMType)

            cbCompany.DataSource = dwCompany
            cbCompany.DisplayMember = "DepartMent"
            cbCompany.ValueMember = "Code"

            cbBillNo.DataSource = dwBillNo
            cbBillNo.DisplayMember = "BLNO"
            cbBillNo.ValueMember = "BLNO"

            cbPMType.DataSource = dwPMType
            cbPMType.DisplayMember = "Name_PM"
            cbPMType.ValueMember = "Code_PM"

            Dim sqlPack As String
            Dim dvPack As New DataView()
            sqlPack = "SELECT * FROM CODE_PACK ORDER BY px"
            dvPack = Filldata(sqlPack)
            Me.cbPack.DataSource = dvPack
            Me.cbPack.DisplayMember = "PACK_CHA"
            Me.cbPack.ValueMember = "CODE_PACK"

            Dim sqlDayNight As String
            Dim dvDayNight As New DataView()
            sqlDayNight = "SELECT * FROM Code_WorkTime WHERE Code_WorkTime <> '00' ORDER BY WorkTime"
            dvDayNight = Filldata(sqlDayNight)
            Me.cbDayOrNight.DataSource = dvDayNight
            Me.cbDayOrNight.DisplayMember = "WorkTime"
            Me.cbDayOrNight.ValueMember = "Code_WorkTime"

            sqlstr = "select * from CARGO_PACK_SHEET where CARGO_PACK_SHEET_ID =" & ID & ""
            dw = Updatedata(sqlda, sqlstr, ds)

            sqlGetTime = "SELECT DAY_TIME, NIGHT_TIME FROM WORK_TIME WHERE (WORK_TIME_ID = 1)"
            dvGetTime = Filldata(sqlGetTime)
            dtpWorkDate.CustomFormat = "yyyy'-'MM'-'dd"

            If dw.Count > 0 Then
                txtID.Text = ds.Tables(0).Rows(0).Item("CARGO_PACK_SHEET_ID")
                cbBillNo.SelectedValue = ds.Tables(0).Rows(0).Item("BLNO")
                Me.dtpWorkDate.Value = ds.Tables(0).Rows(0).Item("WorkDate")
                Me.cbDayOrNight.SelectedValue = ds.Tables(0).Rows(0).Item("DayOrNight")
                Me.txtTimeBegin.Text = ds.Tables(0).Rows(0).Item("TIME_FROM")
                Me.txtTimeEnd.Text = ds.Tables(0).Rows(0).Item("TIME_TO")
                cbPMType.SelectedValue = ds.Tables(0).Rows(0).Item("P_M_TYPE")
                Me.txtGoods.Text = ds.Tables(0).Rows(0).Item("Code_Goods")
                cbCompany.SelectedValue = ds.Tables(0).Rows(0).Item("COMPANY_CODE")
                Me.txtYardNo.Text = ds.Tables(0).Rows(0).Item("YARD_NO")
                Me.txtCargoNo.Text = ds.Tables(0).Rows(0).Item("Cargo_No")
                Me.txtMark.Text = ds.Tables(0).Rows(0).Item("Mark")
                Me.cbPack.SelectedValue = ds.Tables(0).Rows(0).Item("Pack_Code")
                If Not IsDBNull(ds.Tables(0).Rows(0).Item("Pack_Amount")) Then
                    Me.txtPackAmount.Text = ds.Tables(0).Rows(0).Item("Pack_Amount")
                End If
                Me.txtOperate.Text = ds.Tables(0).Rows(0).Item("Operate")
                Me.txtWorkGroup.Text = ds.Tables(0).Rows(0).Item("WorkGroup")
                Me.cbYesOrNo.SelectedIndex = ds.Tables(0).Rows(0).Item("Quantity")
                Me.txtRemark.Text = ds.Tables(0).Rows(0).Item("Remark")
            End If
            Call Me.cbDayOrNight_SelectedIndexChanged(sender, e)
            If dw.Count > 0 Then
                cbClerk1.SelectedValue = ds.Tables(0).Rows(0).Item("TALLY_CLERK1")
                cbClerk2.SelectedValue = ds.Tables(0).Rows(0).Item("TALLY_CLERK2")
                cbClerk3.SelectedValue = ds.Tables(0).Rows(0).Item("TALLY_CLERK3")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim sqlExist As String
        sqlExist = "select * from CARGO_PACK_SHEET where CARGO_PACK_SHEET_ID <> '" & ID & "' and SHIP_ID = '" & Ship_ID & _
                "' and BLNO = '" & cbBillNo.SelectedValue & "' and DATEPART(dy, WorkDate)='" & Me.dtpWorkDate.Value.DayOfYear & "' and TIME_FROM='" & Me.txtTimeBegin.Text & "' and TIME_TO='" & Me.txtTimeEnd.Text & "' and P_M_TYPE = '" & cbPMType.SelectedValue & "'"
        Try
            If cbPMType.SelectedValue <> "0" Then
                If Me.txtTimeBegin.Text Like "[0-1]#[0-5]#" Or Me.txtTimeBegin.Text Like "2[0-3][0-5]#" Then
                    If Me.txtTimeEnd.Text Like "[0-1]#[0-5]#" Or Me.txtTimeBegin.Text Like "2[0-3][0-5]#" Then
                        'If DateDiff(DateInterval.Minute, dtpTimeBegin.Value, dtpTimeEnd.Value) > 0 Then

                        If SetNumValue("Pack_Amount", txtPackAmount.Text, "灌包件数") = False Then
                            Me.txtPackAmount.Focus()
                            Exit Sub
                        End If
                        If IsNumeric(txtPackAmount.Text) Then
                            ds.Tables(0).Rows(0).Item("Pack_Weight") = (txtPackAmount.Text * dwBillNo(Me.cbBillNo.SelectedIndex)("StandsWeight")) / 1000
                        End If
                        ds.Tables(0).Rows(0).Item("BLNO") = cbBillNo.SelectedValue
                        ds.Tables(0).Rows(0).Item("WorkDate") = Me.dtpWorkDate.Value
                        ds.Tables(0).Rows(0).Item("DayOrNight") = Me.cbDayOrNight.SelectedValue
                        ds.Tables(0).Rows(0).Item("TIME_FROM") = Me.txtTimeBegin.Text
                        ds.Tables(0).Rows(0).Item("TIME_TO") = Me.txtTimeEnd.Text
                        ds.Tables(0).Rows(0).Item("P_M_TYPE") = cbPMType.SelectedValue
                        ds.Tables(0).Rows(0).Item("Code_Goods") = Trim(txtGoods.Text)
                        ds.Tables(0).Rows(0).Item("COMPANY_CODE") = cbCompany.SelectedValue
                        ds.Tables(0).Rows(0).Item("YARD_NO") = Trim(txtYardNo.Text)
                        ds.Tables(0).Rows(0).Item("Cargo_No") = Trim(Me.txtCargoNo.Text)
                        ds.Tables(0).Rows(0).Item("Mark") = Trim(Me.txtMark.Text)
                        ds.Tables(0).Rows(0).Item("Pack_Code") = Me.cbPack.SelectedValue
                        ds.Tables(0).Rows(0).Item("Operate") = Trim(Me.txtOperate.Text)
                        ds.Tables(0).Rows(0).Item("WorkGroup") = Trim(Me.txtWorkGroup.Text)
                        ds.Tables(0).Rows(0).Item("Quantity") = Me.cbYesOrNo.SelectedIndex
                        ds.Tables(0).Rows(0).Item("Remark") = Trim(Me.txtRemark.Text)

                        ds.Tables(0).Rows(0).Item("TALLY_CLERK1") = Me.cbClerk1.SelectedValue
                        ds.Tables(0).Rows(0).Item("TALLY_CLERK2") = cbClerk2.SelectedValue
                        ds.Tables(0).Rows(0).Item("TALLY_CLERK3") = cbClerk3.SelectedValue
                        If MessageBox.Show("确认要修改吗？", "警告提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                            If Filldata(sqlExist).Count = 0 Then
                                '记录操作日志
                                Call OperateHistory(G_DeptName, Now, G_User, "修改", "CARGO_PACK_SHEET", Trim(txtID.Text), "CARGO_PACK_SHEET_ID")
                                sqlda.Update(ds)
                                Me.Close()
                            Else
                                MessageBox.Show("同一船次 提单号 人机灌包别 工作时间 不能重复", "提示")
                            End If
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
                Me.cbPMType.Focus()
                MessageBox.Show("请选择人机灌包别。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub cbBillNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBillNo.SelectedIndexChanged
        Try
            If TypeName(cbBillNo.SelectedValue) = "String" Then
                Dim sqlGetBillInfo As String
                Dim dvGetBillinfo As New DataView()
                sqlGetBillInfo = "SELECT * FROM CARGO_GOODS WHERE SHIP_ID = '" & Ship_ID & "' and BLNO = '" & cbBillNo.SelectedValue & "'"
                dvGetBillinfo = Filldata(sqlGetBillInfo)
                If dvGetBillinfo.Count > 0 Then
                    Me.txtGoods.Text = dvGetBillinfo(0)("CODE_GOODS")
                    Me.cbCompany.SelectedValue = dvGetBillinfo(0)("HIDE_COMPANY")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbDayOrNight_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDayOrNight.SelectedIndexChanged
        Try
            strTime = ""
            If dvGetTime.Count > 0 Then
                If Me.cbDayOrNight.SelectedValue = "01" Then   '白班
                    strTime = dvGetTime(0)("DAY_TIME")
                    Me.txtTimeBegin.Text = dvGetTime(0)("DAY_TIME")
                    Me.txtTimeEnd.Text = dvGetTime(0)("NIGHT_TIME")
                    sqlClerk = "exec sp_clerk '" & G_DeptCode & "','" & Ship_ID & "','" & strTime & "','" & Me.dtpWorkDate.Value.Date & "'"
                Else    '夜班
                    strTime = dvGetTime(0)("NIGHT_TIME")
                    Me.txtTimeBegin.Text = dvGetTime(0)("NIGHT_TIME")
                    Me.txtTimeEnd.Text = dvGetTime(0)("DAY_TIME")
                    sqlClerk = "exec sp_clerk '" & G_DeptCode & "','" & Ship_ID & "','" & strTime & "','" & Me.dtpWorkDate.Value.AddDays(-1).Date & "'"
                End If
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
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmCargoPackSheet_Add_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.cbBillNo.Focused Then
                Me.dtpWorkDate.Focus()
            ElseIf Me.dtpWorkDate.Focused Then
                Me.cbDayOrNight.Focus()
            ElseIf Me.cbDayOrNight.Focused Then
                Me.cbPMType.Focus()
            ElseIf Me.cbPMType.Focused Then
                Me.txtYardNo.Focus()
            ElseIf Me.txtYardNo.Focused Then
                Me.txtCargoNo.Focus()
            ElseIf Me.txtCargoNo.Focused Then
                Me.txtMark.Focus()
            ElseIf Me.txtMark.Focused Then
                Me.cbPack.Focus()
            ElseIf Me.cbPack.Focused Then
                Me.txtPackAmount.Focus()
            ElseIf Me.txtPackAmount.Focused Then
                Me.txtOperate.Focus()
            ElseIf Me.txtOperate.Focused Then
                Me.txtWorkGroup.Focus()
            ElseIf Me.txtWorkGroup.Focused Then
                Me.cbYesOrNo.Focus()
            ElseIf Me.cbYesOrNo.Focused Then
                Me.txtTimeBegin.Focus()
            ElseIf Me.txtTimeBegin.Focused Then
                Me.txtTimeEnd.Focus()
            ElseIf Me.txtTimeEnd.Focused Then
                Me.cbClerk1.Focus()
            ElseIf Me.cbClerk1.Focused Then
                Me.cbClerk2.Focus()
            ElseIf Me.cbClerk2.Focused Then
                Me.cbClerk3.Focus()
            ElseIf Me.cbClerk3.Focused Then
                Me.txtRemark.Focus()
            ElseIf Me.txtRemark.Focused Then
                Me.btSave.Focus()
            End If
        End If
    End Sub
End Class
