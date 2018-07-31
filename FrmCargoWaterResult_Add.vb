Imports TALLY.DBControl
Imports System.Math

Public Class FrmCargoWaterResult_Add
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        AddHandler cbConsign.KeyDown, AddressOf FrmCargoWaterResult_Add_KeyDown
        AddHandler txtAmount.KeyDown, AddressOf FrmCargoWaterResult_Add_KeyDown
        AddHandler cbPortLoad.KeyDown, AddressOf FrmCargoWaterResult_Add_KeyDown
        AddHandler cbPortUnload.KeyDown, AddressOf FrmCargoWaterResult_Add_KeyDown
        AddHandler cbTimeNumBegin.KeyDown, AddressOf FrmCargoWaterResult_Add_KeyDown
        AddHandler cbTimeNumEnd.KeyDown, AddressOf FrmCargoWaterResult_Add_KeyDown

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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents cbConsign As System.Windows.Forms.ComboBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents lbDensity1 As System.Windows.Forms.Label
    Friend WithEvents lbVerWaterTon1 As System.Windows.Forms.Label
    Friend WithEvents lbHeadWater1 As System.Windows.Forms.Label
    Friend WithEvents lbRearWater1 As System.Windows.Forms.Label
    Friend WithEvents lbMiddleWater1 As System.Windows.Forms.Label
    Friend WithEvents lbCorWaterTon1 As System.Windows.Forms.Label
    Friend WithEvents lbDesWaterTon1 As System.Windows.Forms.Label
    Friend WithEvents lbFuel1 As System.Windows.Forms.Label
    Friend WithEvents lbCleanWater1 As System.Windows.Forms.Label
    Friend WithEvents lbCabinWater1 As System.Windows.Forms.Label
    Friend WithEvents lbConstant1 As System.Windows.Forms.Label
    Friend WithEvents lbSub1 As System.Windows.Forms.Label
    Friend WithEvents lbEmptyWater1 As System.Windows.Forms.Label
    Friend WithEvents lbWeightChang As System.Windows.Forms.Label
    Friend WithEvents lbDensity2 As System.Windows.Forms.Label
    Friend WithEvents lbMiddleWater2 As System.Windows.Forms.Label
    Friend WithEvents lbDesWaterTon2 As System.Windows.Forms.Label
    Friend WithEvents lbCorWaterTon2 As System.Windows.Forms.Label
    Friend WithEvents lbHeadWater2 As System.Windows.Forms.Label
    Friend WithEvents lbVerWaterTon2 As System.Windows.Forms.Label
    Friend WithEvents lbRearWater2 As System.Windows.Forms.Label
    Friend WithEvents lbWeightGong As System.Windows.Forms.Label
    Friend WithEvents lbEmptyWater2 As System.Windows.Forms.Label
    Friend WithEvents lbSub2 As System.Windows.Forms.Label
    Friend WithEvents lbConstant2 As System.Windows.Forms.Label
    Friend WithEvents lbCabinWater2 As System.Windows.Forms.Label
    Friend WithEvents lbCleanWater2 As System.Windows.Forms.Label
    Friend WithEvents lbFuel2 As System.Windows.Forms.Label
    Friend WithEvents cbPortLoad As System.Windows.Forms.ComboBox
    Friend WithEvents cbPortUnload As System.Windows.Forms.ComboBox
    Friend WithEvents cbTimeNumBegin As System.Windows.Forms.ComboBox
    Friend WithEvents cbTimeNumEnd As System.Windows.Forms.ComboBox
    Friend WithEvents lbWorker1 As System.Windows.Forms.Label
    Friend WithEvents lbWorker2 As System.Windows.Forms.Label
    Friend WithEvents lbDM1 As System.Windows.Forms.Label
    Friend WithEvents lbDM2 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbConsign = New System.Windows.Forms.ComboBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.cbTimeNumBegin = New System.Windows.Forms.ComboBox()
        Me.cbTimeNumEnd = New System.Windows.Forms.ComboBox()
        Me.lbDensity1 = New System.Windows.Forms.Label()
        Me.lbVerWaterTon1 = New System.Windows.Forms.Label()
        Me.lbHeadWater1 = New System.Windows.Forms.Label()
        Me.lbRearWater1 = New System.Windows.Forms.Label()
        Me.lbMiddleWater1 = New System.Windows.Forms.Label()
        Me.lbDM1 = New System.Windows.Forms.Label()
        Me.lbCorWaterTon1 = New System.Windows.Forms.Label()
        Me.lbDesWaterTon1 = New System.Windows.Forms.Label()
        Me.lbFuel1 = New System.Windows.Forms.Label()
        Me.lbCleanWater1 = New System.Windows.Forms.Label()
        Me.lbCabinWater1 = New System.Windows.Forms.Label()
        Me.lbConstant1 = New System.Windows.Forms.Label()
        Me.lbSub1 = New System.Windows.Forms.Label()
        Me.lbEmptyWater1 = New System.Windows.Forms.Label()
        Me.lbWeightChang = New System.Windows.Forms.Label()
        Me.lbWorker1 = New System.Windows.Forms.Label()
        Me.lbDensity2 = New System.Windows.Forms.Label()
        Me.lbMiddleWater2 = New System.Windows.Forms.Label()
        Me.lbDesWaterTon2 = New System.Windows.Forms.Label()
        Me.lbDM2 = New System.Windows.Forms.Label()
        Me.lbCorWaterTon2 = New System.Windows.Forms.Label()
        Me.lbHeadWater2 = New System.Windows.Forms.Label()
        Me.lbVerWaterTon2 = New System.Windows.Forms.Label()
        Me.lbRearWater2 = New System.Windows.Forms.Label()
        Me.lbWorker2 = New System.Windows.Forms.Label()
        Me.lbWeightGong = New System.Windows.Forms.Label()
        Me.lbEmptyWater2 = New System.Windows.Forms.Label()
        Me.lbSub2 = New System.Windows.Forms.Label()
        Me.lbConstant2 = New System.Windows.Forms.Label()
        Me.lbCabinWater2 = New System.Windows.Forms.Label()
        Me.lbCleanWater2 = New System.Windows.Forms.Label()
        Me.lbFuel2 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.cbPortLoad = New System.Windows.Forms.ComboBox()
        Me.cbPortUnload = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "委托方"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(216, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "装货港"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(216, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "卸货港"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "申报数量"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(80, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "初测记录是第"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(248, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "末测记录是第"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(214, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "次"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(382, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "次"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "港水密度"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 20)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "船首吃水"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 122)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 20)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "船尾吃水"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 144)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 20)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "船中吃水"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 166)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 20)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "拱陷校正"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 188)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 20)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "相应排水量"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(8, 210)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 20)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "纵校排水量"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(8, 232)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 20)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "密校排水量"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(8, 254)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 20)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "船用物料重量"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(8, 276)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 20)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "燃油"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(8, 298)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 20)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "淡水"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(8, 320)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 20)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "压舱水"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(8, 342)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 20)
        Me.Label22.TabIndex = 21
        Me.Label22.Text = "常数"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(8, 364)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(88, 20)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "空船排水量"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 275
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(8, 386)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(88, 20)
        Me.Label24.TabIndex = 276
        Me.Label24.Text = "小计"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(8, 432)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 20)
        Me.Label25.TabIndex = 277
        Me.Label25.Text = "货物重量"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 408)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 278
        Me.Label2.Text = "测试人员"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbConsign
        '
        Me.cbConsign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConsign.Location = New System.Drawing.Point(88, 8)
        Me.cbConsign.MaxDropDownItems = 20
        Me.cbConsign.MaxLength = 10
        Me.cbConsign.Name = "cbConsign"
        Me.cbConsign.Size = New System.Drawing.Size(120, 20)
        Me.cbConsign.TabIndex = 279
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(88, 30)
        Me.txtAmount.MaxLength = 20
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(90, 21)
        Me.txtAmount.TabIndex = 280
        Me.txtAmount.Text = ""
        '
        'cbTimeNumBegin
        '
        Me.cbTimeNumBegin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTimeNumBegin.Location = New System.Drawing.Point(160, 56)
        Me.cbTimeNumBegin.MaxLength = 4
        Me.cbTimeNumBegin.Name = "cbTimeNumBegin"
        Me.cbTimeNumBegin.Size = New System.Drawing.Size(52, 20)
        Me.cbTimeNumBegin.TabIndex = 283
        '
        'cbTimeNumEnd
        '
        Me.cbTimeNumEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTimeNumEnd.Location = New System.Drawing.Point(328, 56)
        Me.cbTimeNumEnd.MaxLength = 4
        Me.cbTimeNumEnd.Name = "cbTimeNumEnd"
        Me.cbTimeNumEnd.Size = New System.Drawing.Size(52, 20)
        Me.cbTimeNumEnd.TabIndex = 284
        '
        'lbDensity1
        '
        Me.lbDensity1.BackColor = System.Drawing.SystemColors.Info
        Me.lbDensity1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbDensity1.Location = New System.Drawing.Point(96, 78)
        Me.lbDensity1.Name = "lbDensity1"
        Me.lbDensity1.Size = New System.Drawing.Size(106, 20)
        Me.lbDensity1.TabIndex = 308
        Me.lbDensity1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbVerWaterTon1
        '
        Me.lbVerWaterTon1.BackColor = System.Drawing.SystemColors.Info
        Me.lbVerWaterTon1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbVerWaterTon1.Location = New System.Drawing.Point(96, 210)
        Me.lbVerWaterTon1.Name = "lbVerWaterTon1"
        Me.lbVerWaterTon1.Size = New System.Drawing.Size(106, 20)
        Me.lbVerWaterTon1.TabIndex = 309
        Me.lbVerWaterTon1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbHeadWater1
        '
        Me.lbHeadWater1.BackColor = System.Drawing.SystemColors.Info
        Me.lbHeadWater1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbHeadWater1.Location = New System.Drawing.Point(96, 100)
        Me.lbHeadWater1.Name = "lbHeadWater1"
        Me.lbHeadWater1.Size = New System.Drawing.Size(106, 20)
        Me.lbHeadWater1.TabIndex = 310
        Me.lbHeadWater1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRearWater1
        '
        Me.lbRearWater1.BackColor = System.Drawing.SystemColors.Info
        Me.lbRearWater1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbRearWater1.Location = New System.Drawing.Point(96, 122)
        Me.lbRearWater1.Name = "lbRearWater1"
        Me.lbRearWater1.Size = New System.Drawing.Size(106, 20)
        Me.lbRearWater1.TabIndex = 311
        Me.lbRearWater1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbMiddleWater1
        '
        Me.lbMiddleWater1.BackColor = System.Drawing.SystemColors.Info
        Me.lbMiddleWater1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbMiddleWater1.Location = New System.Drawing.Point(96, 144)
        Me.lbMiddleWater1.Name = "lbMiddleWater1"
        Me.lbMiddleWater1.Size = New System.Drawing.Size(106, 20)
        Me.lbMiddleWater1.TabIndex = 312
        Me.lbMiddleWater1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbDM1
        '
        Me.lbDM1.BackColor = System.Drawing.SystemColors.Info
        Me.lbDM1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbDM1.Location = New System.Drawing.Point(96, 166)
        Me.lbDM1.Name = "lbDM1"
        Me.lbDM1.Size = New System.Drawing.Size(106, 20)
        Me.lbDM1.TabIndex = 313
        Me.lbDM1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCorWaterTon1
        '
        Me.lbCorWaterTon1.BackColor = System.Drawing.SystemColors.Info
        Me.lbCorWaterTon1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCorWaterTon1.Location = New System.Drawing.Point(96, 188)
        Me.lbCorWaterTon1.Name = "lbCorWaterTon1"
        Me.lbCorWaterTon1.Size = New System.Drawing.Size(106, 20)
        Me.lbCorWaterTon1.TabIndex = 314
        Me.lbCorWaterTon1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbDesWaterTon1
        '
        Me.lbDesWaterTon1.BackColor = System.Drawing.SystemColors.Info
        Me.lbDesWaterTon1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbDesWaterTon1.Location = New System.Drawing.Point(96, 232)
        Me.lbDesWaterTon1.Name = "lbDesWaterTon1"
        Me.lbDesWaterTon1.Size = New System.Drawing.Size(106, 20)
        Me.lbDesWaterTon1.TabIndex = 315
        Me.lbDesWaterTon1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbFuel1
        '
        Me.lbFuel1.BackColor = System.Drawing.SystemColors.Info
        Me.lbFuel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbFuel1.Location = New System.Drawing.Point(96, 276)
        Me.lbFuel1.Name = "lbFuel1"
        Me.lbFuel1.Size = New System.Drawing.Size(106, 20)
        Me.lbFuel1.TabIndex = 317
        Me.lbFuel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCleanWater1
        '
        Me.lbCleanWater1.BackColor = System.Drawing.SystemColors.Info
        Me.lbCleanWater1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCleanWater1.Location = New System.Drawing.Point(96, 298)
        Me.lbCleanWater1.Name = "lbCleanWater1"
        Me.lbCleanWater1.Size = New System.Drawing.Size(106, 20)
        Me.lbCleanWater1.TabIndex = 318
        Me.lbCleanWater1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCabinWater1
        '
        Me.lbCabinWater1.BackColor = System.Drawing.SystemColors.Info
        Me.lbCabinWater1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCabinWater1.Location = New System.Drawing.Point(96, 320)
        Me.lbCabinWater1.Name = "lbCabinWater1"
        Me.lbCabinWater1.Size = New System.Drawing.Size(106, 20)
        Me.lbCabinWater1.TabIndex = 319
        Me.lbCabinWater1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbConstant1
        '
        Me.lbConstant1.BackColor = System.Drawing.SystemColors.Info
        Me.lbConstant1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbConstant1.Location = New System.Drawing.Point(96, 342)
        Me.lbConstant1.Name = "lbConstant1"
        Me.lbConstant1.Size = New System.Drawing.Size(106, 20)
        Me.lbConstant1.TabIndex = 320
        Me.lbConstant1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbSub1
        '
        Me.lbSub1.BackColor = System.Drawing.SystemColors.Info
        Me.lbSub1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSub1.Location = New System.Drawing.Point(96, 386)
        Me.lbSub1.Name = "lbSub1"
        Me.lbSub1.Size = New System.Drawing.Size(106, 20)
        Me.lbSub1.TabIndex = 321
        Me.lbSub1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbEmptyWater1
        '
        Me.lbEmptyWater1.BackColor = System.Drawing.SystemColors.Info
        Me.lbEmptyWater1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbEmptyWater1.Location = New System.Drawing.Point(96, 364)
        Me.lbEmptyWater1.Name = "lbEmptyWater1"
        Me.lbEmptyWater1.Size = New System.Drawing.Size(106, 20)
        Me.lbEmptyWater1.TabIndex = 322
        Me.lbEmptyWater1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbWeightChang
        '
        Me.lbWeightChang.BackColor = System.Drawing.SystemColors.Info
        Me.lbWeightChang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbWeightChang.Location = New System.Drawing.Point(96, 432)
        Me.lbWeightChang.Name = "lbWeightChang"
        Me.lbWeightChang.Size = New System.Drawing.Size(106, 20)
        Me.lbWeightChang.TabIndex = 323
        Me.lbWeightChang.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbWorker1
        '
        Me.lbWorker1.BackColor = System.Drawing.SystemColors.Info
        Me.lbWorker1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbWorker1.Location = New System.Drawing.Point(96, 408)
        Me.lbWorker1.Name = "lbWorker1"
        Me.lbWorker1.Size = New System.Drawing.Size(106, 20)
        Me.lbWorker1.TabIndex = 324
        Me.lbWorker1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbDensity2
        '
        Me.lbDensity2.BackColor = System.Drawing.SystemColors.Info
        Me.lbDensity2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbDensity2.Location = New System.Drawing.Point(264, 78)
        Me.lbDensity2.Name = "lbDensity2"
        Me.lbDensity2.Size = New System.Drawing.Size(106, 20)
        Me.lbDensity2.TabIndex = 325
        Me.lbDensity2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbMiddleWater2
        '
        Me.lbMiddleWater2.BackColor = System.Drawing.SystemColors.Info
        Me.lbMiddleWater2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbMiddleWater2.Location = New System.Drawing.Point(264, 144)
        Me.lbMiddleWater2.Name = "lbMiddleWater2"
        Me.lbMiddleWater2.Size = New System.Drawing.Size(106, 20)
        Me.lbMiddleWater2.TabIndex = 327
        Me.lbMiddleWater2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbDesWaterTon2
        '
        Me.lbDesWaterTon2.BackColor = System.Drawing.SystemColors.Info
        Me.lbDesWaterTon2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbDesWaterTon2.Location = New System.Drawing.Point(264, 232)
        Me.lbDesWaterTon2.Name = "lbDesWaterTon2"
        Me.lbDesWaterTon2.Size = New System.Drawing.Size(106, 20)
        Me.lbDesWaterTon2.TabIndex = 327
        Me.lbDesWaterTon2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbDM2
        '
        Me.lbDM2.BackColor = System.Drawing.SystemColors.Info
        Me.lbDM2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbDM2.Location = New System.Drawing.Point(264, 166)
        Me.lbDM2.Name = "lbDM2"
        Me.lbDM2.Size = New System.Drawing.Size(106, 20)
        Me.lbDM2.TabIndex = 328
        Me.lbDM2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCorWaterTon2
        '
        Me.lbCorWaterTon2.BackColor = System.Drawing.SystemColors.Info
        Me.lbCorWaterTon2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCorWaterTon2.Location = New System.Drawing.Point(264, 188)
        Me.lbCorWaterTon2.Name = "lbCorWaterTon2"
        Me.lbCorWaterTon2.Size = New System.Drawing.Size(106, 20)
        Me.lbCorWaterTon2.TabIndex = 328
        Me.lbCorWaterTon2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbHeadWater2
        '
        Me.lbHeadWater2.BackColor = System.Drawing.SystemColors.Info
        Me.lbHeadWater2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbHeadWater2.Location = New System.Drawing.Point(264, 100)
        Me.lbHeadWater2.Name = "lbHeadWater2"
        Me.lbHeadWater2.Size = New System.Drawing.Size(106, 20)
        Me.lbHeadWater2.TabIndex = 328
        Me.lbHeadWater2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbVerWaterTon2
        '
        Me.lbVerWaterTon2.BackColor = System.Drawing.SystemColors.Info
        Me.lbVerWaterTon2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbVerWaterTon2.Location = New System.Drawing.Point(264, 210)
        Me.lbVerWaterTon2.Name = "lbVerWaterTon2"
        Me.lbVerWaterTon2.Size = New System.Drawing.Size(106, 20)
        Me.lbVerWaterTon2.TabIndex = 328
        Me.lbVerWaterTon2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRearWater2
        '
        Me.lbRearWater2.BackColor = System.Drawing.SystemColors.Info
        Me.lbRearWater2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbRearWater2.Location = New System.Drawing.Point(264, 122)
        Me.lbRearWater2.Name = "lbRearWater2"
        Me.lbRearWater2.Size = New System.Drawing.Size(106, 20)
        Me.lbRearWater2.TabIndex = 328
        Me.lbRearWater2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbWorker2
        '
        Me.lbWorker2.BackColor = System.Drawing.SystemColors.Info
        Me.lbWorker2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbWorker2.Location = New System.Drawing.Point(264, 408)
        Me.lbWorker2.Name = "lbWorker2"
        Me.lbWorker2.Size = New System.Drawing.Size(106, 20)
        Me.lbWorker2.TabIndex = 336
        Me.lbWorker2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbWeightGong
        '
        Me.lbWeightGong.BackColor = System.Drawing.SystemColors.Info
        Me.lbWeightGong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbWeightGong.Location = New System.Drawing.Point(264, 432)
        Me.lbWeightGong.Name = "lbWeightGong"
        Me.lbWeightGong.Size = New System.Drawing.Size(106, 20)
        Me.lbWeightGong.TabIndex = 335
        Me.lbWeightGong.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbEmptyWater2
        '
        Me.lbEmptyWater2.BackColor = System.Drawing.SystemColors.Info
        Me.lbEmptyWater2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbEmptyWater2.Location = New System.Drawing.Point(264, 364)
        Me.lbEmptyWater2.Name = "lbEmptyWater2"
        Me.lbEmptyWater2.Size = New System.Drawing.Size(106, 20)
        Me.lbEmptyWater2.TabIndex = 334
        Me.lbEmptyWater2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbSub2
        '
        Me.lbSub2.BackColor = System.Drawing.SystemColors.Info
        Me.lbSub2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSub2.Location = New System.Drawing.Point(264, 386)
        Me.lbSub2.Name = "lbSub2"
        Me.lbSub2.Size = New System.Drawing.Size(106, 20)
        Me.lbSub2.TabIndex = 333
        Me.lbSub2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbConstant2
        '
        Me.lbConstant2.BackColor = System.Drawing.SystemColors.Info
        Me.lbConstant2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbConstant2.Location = New System.Drawing.Point(264, 342)
        Me.lbConstant2.Name = "lbConstant2"
        Me.lbConstant2.Size = New System.Drawing.Size(106, 20)
        Me.lbConstant2.TabIndex = 332
        Me.lbConstant2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCabinWater2
        '
        Me.lbCabinWater2.BackColor = System.Drawing.SystemColors.Info
        Me.lbCabinWater2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCabinWater2.Location = New System.Drawing.Point(264, 320)
        Me.lbCabinWater2.Name = "lbCabinWater2"
        Me.lbCabinWater2.Size = New System.Drawing.Size(106, 20)
        Me.lbCabinWater2.TabIndex = 331
        Me.lbCabinWater2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCleanWater2
        '
        Me.lbCleanWater2.BackColor = System.Drawing.SystemColors.Info
        Me.lbCleanWater2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCleanWater2.Location = New System.Drawing.Point(264, 298)
        Me.lbCleanWater2.Name = "lbCleanWater2"
        Me.lbCleanWater2.Size = New System.Drawing.Size(106, 20)
        Me.lbCleanWater2.TabIndex = 330
        Me.lbCleanWater2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbFuel2
        '
        Me.lbFuel2.BackColor = System.Drawing.SystemColors.Info
        Me.lbFuel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbFuel2.Location = New System.Drawing.Point(264, 276)
        Me.lbFuel2.Name = "lbFuel2"
        Me.lbFuel2.Size = New System.Drawing.Size(106, 20)
        Me.lbFuel2.TabIndex = 329
        Me.lbFuel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label59
        '
        Me.Label59.Location = New System.Drawing.Point(202, 78)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(42, 20)
        Me.Label59.TabIndex = 337
        Me.Label59.Text = "吨/米3"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label60
        '
        Me.Label60.Location = New System.Drawing.Point(370, 78)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(42, 20)
        Me.Label60.TabIndex = 338
        Me.Label60.Text = "吨/米3"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label61
        '
        Me.Label61.Location = New System.Drawing.Point(204, 100)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(30, 20)
        Me.Label61.TabIndex = 339
        Me.Label61.Text = "米"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label62
        '
        Me.Label62.Location = New System.Drawing.Point(204, 188)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(30, 20)
        Me.Label62.TabIndex = 340
        Me.Label62.Text = "吨"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label65
        '
        Me.Label65.Location = New System.Drawing.Point(204, 122)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(30, 20)
        Me.Label65.TabIndex = 343
        Me.Label65.Text = "米"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label66
        '
        Me.Label66.Location = New System.Drawing.Point(204, 144)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(30, 20)
        Me.Label66.TabIndex = 344
        Me.Label66.Text = "米"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label67
        '
        Me.Label67.Location = New System.Drawing.Point(204, 166)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(30, 20)
        Me.Label67.TabIndex = 345
        Me.Label67.Text = "米"
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label68
        '
        Me.Label68.Location = New System.Drawing.Point(372, 100)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(30, 20)
        Me.Label68.TabIndex = 346
        Me.Label68.Text = "米"
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label69
        '
        Me.Label69.Location = New System.Drawing.Point(372, 122)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(30, 20)
        Me.Label69.TabIndex = 347
        Me.Label69.Text = "米"
        Me.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label70
        '
        Me.Label70.Location = New System.Drawing.Point(372, 144)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(30, 20)
        Me.Label70.TabIndex = 348
        Me.Label70.Text = "米"
        Me.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label71
        '
        Me.Label71.Location = New System.Drawing.Point(372, 166)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(30, 20)
        Me.Label71.TabIndex = 349
        Me.Label71.Text = "米"
        Me.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label63
        '
        Me.Label63.Location = New System.Drawing.Point(204, 210)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(30, 20)
        Me.Label63.TabIndex = 350
        Me.Label63.Text = "吨"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label64
        '
        Me.Label64.Location = New System.Drawing.Point(204, 232)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(30, 20)
        Me.Label64.TabIndex = 351
        Me.Label64.Text = "吨"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label73
        '
        Me.Label73.Location = New System.Drawing.Point(204, 342)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(30, 20)
        Me.Label73.TabIndex = 356
        Me.Label73.Text = "吨"
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label74
        '
        Me.Label74.Location = New System.Drawing.Point(204, 320)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(30, 20)
        Me.Label74.TabIndex = 355
        Me.Label74.Text = "吨"
        Me.Label74.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label75
        '
        Me.Label75.Location = New System.Drawing.Point(204, 298)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(30, 20)
        Me.Label75.TabIndex = 354
        Me.Label75.Text = "吨"
        Me.Label75.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label76
        '
        Me.Label76.Location = New System.Drawing.Point(204, 276)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(30, 20)
        Me.Label76.TabIndex = 353
        Me.Label76.Text = "吨"
        Me.Label76.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label77
        '
        Me.Label77.Location = New System.Drawing.Point(204, 386)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(30, 20)
        Me.Label77.TabIndex = 358
        Me.Label77.Text = "吨"
        Me.Label77.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label78
        '
        Me.Label78.Location = New System.Drawing.Point(204, 364)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(30, 20)
        Me.Label78.TabIndex = 357
        Me.Label78.Text = "吨"
        Me.Label78.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label80
        '
        Me.Label80.Location = New System.Drawing.Point(204, 432)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(30, 20)
        Me.Label80.TabIndex = 359
        Me.Label80.Text = "长吨"
        Me.Label80.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label81
        '
        Me.Label81.Location = New System.Drawing.Point(372, 432)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(30, 20)
        Me.Label81.TabIndex = 371
        Me.Label81.Text = "公吨"
        Me.Label81.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label82
        '
        Me.Label82.Location = New System.Drawing.Point(372, 386)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(30, 20)
        Me.Label82.TabIndex = 370
        Me.Label82.Text = "吨"
        Me.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label83
        '
        Me.Label83.Location = New System.Drawing.Point(372, 364)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(30, 20)
        Me.Label83.TabIndex = 369
        Me.Label83.Text = "吨"
        Me.Label83.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label84
        '
        Me.Label84.Location = New System.Drawing.Point(372, 342)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(30, 20)
        Me.Label84.TabIndex = 368
        Me.Label84.Text = "吨"
        Me.Label84.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label85
        '
        Me.Label85.Location = New System.Drawing.Point(372, 320)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(30, 20)
        Me.Label85.TabIndex = 367
        Me.Label85.Text = "吨"
        Me.Label85.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label86
        '
        Me.Label86.Location = New System.Drawing.Point(372, 298)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(30, 20)
        Me.Label86.TabIndex = 366
        Me.Label86.Text = "吨"
        Me.Label86.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label87
        '
        Me.Label87.Location = New System.Drawing.Point(372, 276)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(30, 20)
        Me.Label87.TabIndex = 365
        Me.Label87.Text = "吨"
        Me.Label87.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label89
        '
        Me.Label89.Location = New System.Drawing.Point(372, 232)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(30, 20)
        Me.Label89.TabIndex = 363
        Me.Label89.Text = "吨"
        Me.Label89.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label90
        '
        Me.Label90.Location = New System.Drawing.Point(372, 210)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(30, 20)
        Me.Label90.TabIndex = 362
        Me.Label90.Text = "吨"
        Me.Label90.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label91
        '
        Me.Label91.Location = New System.Drawing.Point(372, 188)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(30, 20)
        Me.Label91.TabIndex = 361
        Me.Label91.Text = "吨"
        Me.Label91.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(250, 460)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 374
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(182, 460)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 373
        Me.btSave.Text = "确认"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(114, 460)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(65, 24)
        Me.btAdd.TabIndex = 372
        Me.btAdd.Text = "清空"
        '
        'cbPortLoad
        '
        Me.cbPortLoad.Location = New System.Drawing.Point(296, 8)
        Me.cbPortLoad.MaxDropDownItems = 20
        Me.cbPortLoad.MaxLength = 5
        Me.cbPortLoad.Name = "cbPortLoad"
        Me.cbPortLoad.Size = New System.Drawing.Size(120, 20)
        Me.cbPortLoad.TabIndex = 375
        '
        'cbPortUnload
        '
        Me.cbPortUnload.Location = New System.Drawing.Point(296, 30)
        Me.cbPortUnload.MaxDropDownItems = 20
        Me.cbPortUnload.MaxLength = 5
        Me.cbPortUnload.Name = "cbPortUnload"
        Me.cbPortUnload.Size = New System.Drawing.Size(120, 20)
        Me.cbPortUnload.TabIndex = 376
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(178, 30)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(30, 20)
        Me.Label31.TabIndex = 508
        Me.Label31.Text = "公斤"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmCargoWaterResult_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(422, 487)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label31, Me.cbPortUnload, Me.cbPortLoad, Me.btQuit, Me.btSave, Me.btAdd, Me.Label81, Me.Label82, Me.Label83, Me.Label84, Me.Label85, Me.Label86, Me.Label87, Me.Label89, Me.Label90, Me.Label91, Me.Label80, Me.Label77, Me.Label78, Me.Label73, Me.Label74, Me.Label75, Me.Label76, Me.Label64, Me.Label63, Me.Label71, Me.Label70, Me.Label69, Me.Label68, Me.Label67, Me.Label66, Me.Label65, Me.Label62, Me.Label61, Me.Label60, Me.Label59, Me.lbWorker2, Me.lbWeightGong, Me.lbEmptyWater2, Me.lbSub2, Me.lbConstant2, Me.lbCabinWater2, Me.lbCleanWater2, Me.lbFuel2, Me.lbDM2, Me.lbMiddleWater2, Me.lbDensity2, Me.lbWorker1, Me.lbWeightChang, Me.lbEmptyWater1, Me.lbSub1, Me.lbConstant1, Me.lbCabinWater1, Me.lbCleanWater1, Me.lbFuel1, Me.lbDesWaterTon1, Me.lbCorWaterTon1, Me.lbDM1, Me.lbMiddleWater1, Me.lbRearWater1, Me.lbHeadWater1, Me.lbVerWaterTon1, Me.lbDensity1, Me.cbTimeNumEnd, Me.cbTimeNumBegin, Me.txtAmount, Me.cbConsign, Me.Label2, Me.Label25, Me.Label24, Me.Label23, Me.Label22, Me.Label21, Me.Label20, Me.Label19, Me.Label18, Me.Label17, Me.Label16, Me.Label15, Me.Label14, Me.Label13, Me.Label12, Me.Label11, Me.Label10, Me.Label9, Me.Label8, Me.Label7, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label1, Me.txtID, Me.lbDesWaterTon2, Me.lbCorWaterTon2, Me.lbHeadWater2, Me.lbVerWaterTon2, Me.lbRearWater2})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargoWaterResult_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "水尺计重证书信息 增加"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim TimeCount As Short
    Dim sqlWaterRecord As String
    Dim dvWaterRecord As New DataView()

    Private Sub FrmCargoWaterResult_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        sqlstr = "select * from CARGO_WATERog where CARGO_WATER_ID =" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        Dim sqlConsign, sqlTimeNum, sqlPort As String
        Dim dvConsign As New DataView()
        Dim dvTimeNumBegin As New DataView()
        Dim dvTimeNumEnd As New DataView()
        Dim dvPortStart As New DataView()
        Dim dvPortEnd As New DataView()
        'sqlConsign = "SELECT CODE_CONSIGN_WATER, CONSIGN_WATER FROM CODE_CONSIGN_WATER ORDER BY CONSIGN_WATER"
        sqlConsign = "SELECT CODE_SHIP_AGENT, SHIPAGENT_CHA, SHIPAGENT_ENG FROM CODE_SHIP_AGENT ORDER BY CODE_SHIP_AGENT"
        sqlTimeNum = "SELECT Flag FROM Cargo_Water WHERE SHIP_ID = '" & Ship_ID & "' ORDER BY SHIP_ID, Flag"
        sqlPort = "SELECT CODE_PORT, PORT_CHA, PORT_ENG FROM CODE_PORT ORDER BY CODE_PORT"
        dvConsign = Filldata(sqlConsign)
        dvTimeNumBegin = Filldata(sqlTimeNum)
        dvTimeNumEnd = Filldata(sqlTimeNum)
        dvPortStart = Filldata(sqlPort)
        dvPortEnd = Filldata(sqlPort)

        Me.cbConsign.DataSource = dvConsign
        'cbConsign.DisplayMember = "CONSIGN_WATER"
        'cbConsign.ValueMember = "CODE_CONSIGN_WATER"
        cbConsign.DisplayMember = "SHIPAGENT_CHA"
        cbConsign.ValueMember = "CODE_SHIP_AGENT"

        Me.cbTimeNumBegin.DataSource = dvTimeNumBegin
        cbTimeNumBegin.ValueMember = "Flag"
        cbTimeNumBegin.DisplayMember = "Flag"
        Me.cbTimeNumEnd.DataSource = dvTimeNumEnd
        cbTimeNumEnd.ValueMember = "Flag"
        cbTimeNumEnd.DisplayMember = "Flag"
        Me.cbPortLoad.DataSource = dvPortStart
        cbPortLoad.DisplayMember = "PORT_CHA"
        cbPortLoad.ValueMember = "CODE_PORT"
        Me.cbPortUnload.DataSource = dvPortEnd
        cbPortUnload.DisplayMember = "PORT_CHA"
        cbPortUnload.ValueMember = "CODE_PORT"

        TimeCount = dvTimeNumBegin.Count

        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("CARGO_WATER_ID")
            'Me.cbConsign.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_CONSIGN_WATER")
            Me.cbConsign.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_CONSIGN_WATER")

            Me.cbPortLoad.SelectedValue = ds.Tables(0).Rows(0).Item("Port_FROM")
            Me.cbPortUnload.SelectedValue = ds.Tables(0).Rows(0).Item("Port_TO")
            If Me.cbTimeNumBegin.SelectedValue = ds.Tables(0).Rows(0)("TimeNumStart") Then
                Call Me.cbTimeNumBegin_SelectedIndexChanged(sender, e)
            End If
            Me.cbTimeNumBegin.SelectedValue = ds.Tables(0).Rows(0).Item("TimeNumStart")
            If Me.cbTimeNumEnd.SelectedValue = ds.Tables(0).Rows(0)("TimeNumEnd") Then
                Call Me.cbTimeNumEnd_SelectedIndexChanged(sender, e)
            End If
            Me.cbTimeNumEnd.SelectedValue = ds.Tables(0).Rows(0).Item("TimeNumEnd")
            Me.txtAmount.Text = ds.Tables(0).Rows(0).Item("Amount")
            Me.lbWeightChang.Text = ds.Tables(0).Rows(0).Item("TONS_Long")
            Me.lbWeightGong.Text = ds.Tables(0).Rows(0).Item("TONS_Gong")
        End If
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim sqlExist As String
        Dim dvExist As New DataView()
        Try
            If TimeCount >= 2 Then
                If Me.cbConsign.SelectedValue <> "00" Then
                    If Me.cbPortLoad.SelectedValue <> Me.cbPortUnload.SelectedValue Or cbPortLoad.SelectedValue = "00" Or cbPortUnload.SelectedValue = "00" Then
                        If Me.cbTimeNumBegin.SelectedValue < Me.cbTimeNumEnd.SelectedValue Then
                            sqlExist = "SELECT TimeNumStart, TimeNumEnd FROM CARGO_WATERog WHERE ship_id ='" & Ship_ID & "' and TimeNumStart = '" & Me.cbTimeNumBegin.SelectedValue & "' AND TimeNumEnd = '" & Me.cbTimeNumEnd.SelectedValue & "'"
                            dvExist = Filldata(sqlExist)
                            If dvExist.Count = 0 Then
                                Dim row As DataRow
                                row = ds.Tables(0).NewRow

                                row.Item("CODE_CONSIGN_WATER") = Me.cbConsign.SelectedValue
                                row.Item("Port_FROM") = Me.cbPortLoad.SelectedValue
                                row.Item("Port_TO") = Me.cbPortUnload.SelectedValue
                                row.Item("TimeNumStart") = Me.cbTimeNumBegin.SelectedValue
                                row.Item("TimeNumEnd") = Me.cbTimeNumEnd.SelectedValue
                                If Trim(Me.txtAmount.Text) <> "" Then
                                    If IsNumeric(Trim(txtAmount.Text)) Then
                                        row.Item("Amount") = Decimal.Round(Convert.ToDecimal(Trim(txtAmount.Text)), 2)
                                    Else
                                        MessageBox.Show("申报数量应为数字", "提示")
                                        Exit Try
                                    End If
                                End If
                                If IsNumeric(lbSub1.Text) Then
                                    row.Item("TOTAL_BEGIN") = Decimal.Round(Convert.ToDecimal(Me.lbSub1.Text), 2)
                                End If
                                If IsNumeric(lbSub2.Text) Then
                                    row.Item("TOTAL_END") = Decimal.Round(Convert.ToDecimal(Me.lbSub2.Text), 2)
                                End If
                                If IsNumeric(lbWeightChang.Text) Then
                                    row.Item("TONS_Long") = Decimal.Round(Convert.ToDecimal(Me.lbWeightChang.Text), 2)
                                End If
                                If IsNumeric(lbWeightGong.Text) Then
                                    row.Item("TONS_Gong") = Decimal.Round(Convert.ToDecimal(Me.lbWeightGong.Text), 2)
                                End If
                                row.Item("WORK_NO") = Me.lbWorker1.Text
                                row.Item("SHIP_ID") = Ship_ID
                                row.Item("USER_NAME") = G_User

                                ds.Tables(0).Rows.Add(row)
                                sqlda.Update(ds)
                                Me.Close()
                            Else
                                MessageBox.Show("水尺测试记录次数不能重复", "提示")
                            End If
                        Else
                            MessageBox.Show("水尺初测应在末测之前", "提示")
                        End If
                    Else
                        MessageBox.Show("装货港卸货港不能重复", "提示")
                    End If
                Else
                    MessageBox.Show("请选择委托方", "提示")
                End If
            Else
                MessageBox.Show("没有两条以上的水尺测试记录，无法操作", "提示")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbTimeNumBegin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTimeNumBegin.SelectedIndexChanged
        Try
            If TypeName(cbTimeNumBegin.SelectedValue) = "Short" Then
                sqlWaterRecord = "SELECT * FROM Cargo_Water WHERE SHIP_ID = '" & Ship_ID & "' AND Flag = '" & Me.cbTimeNumBegin.SelectedValue & "'"
                dvWaterRecord = Filldata(sqlWaterRecord)

                If IsNumeric(dvWaterRecord.Item(0)("WaterDensity_True")) Then
                    Me.lbDensity1.Text = dvWaterRecord.Item(0)("WaterDensity_True")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("Fc")) Then
                    Me.lbHeadWater1.Text = dvWaterRecord.Item(0)("Fc")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("Ac")) Then
                    Me.lbRearWater1.Text = dvWaterRecord.Item(0)("Ac")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("Mc")) Then
                    Me.lbMiddleWater1.Text = dvWaterRecord.Item(0)("Mc")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("DM_WaterDepth")) Then
                    Me.lbDM1.Text = dvWaterRecord.Item(0)("DM_WaterDepth")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("WaterTon_Corres")) Then
                    Me.lbCorWaterTon1.Text = dvWaterRecord.Item(0)("WaterTon_Corres")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("WaterTon_Clean_G")) Then
                    Me.lbVerWaterTon1.Text = dvWaterRecord.Item(0)("WaterTon_Clean_G")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("WaterTon_Density")) Then
                    Me.lbDesWaterTon1.Text = dvWaterRecord.Item(0)("WaterTon_Density")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("Fuel")) Then
                    Me.lbFuel1.Text = dvWaterRecord.Item(0)("Fuel")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("WaterLight")) Then
                    Me.lbCleanWater1.Text = dvWaterRecord.Item(0)("WaterLight")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("WaterCabin")) Then
                    Me.lbCabinWater1.Text = dvWaterRecord.Item(0)("WaterCabin")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("ConstNum")) Then
                    Me.lbConstant1.Text = dvWaterRecord.Item(0)("ConstNum")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("WaterTon_Empty")) Then
                    Me.lbEmptyWater1.Text = dvWaterRecord.Item(0)("WaterTon_Empty")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("CargoWeight")) Then
                    Me.lbSub1.Text = dvWaterRecord.Item(0)("CargoWeight")
                End If
                Me.lbWorker1.Text = dvWaterRecord.Item(0)("WORK_NO")
                If IsNumeric(Me.lbSub1.Text) And IsNumeric(Me.lbSub2.Text) Then
                    Me.lbWeightGong.Text = Abs(CDec(lbSub1.Text) - CDec(lbSub2.Text))
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbTimeNumEnd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTimeNumEnd.SelectedIndexChanged
        Try
            If TypeName(Me.cbTimeNumEnd.SelectedValue) = "Short" Then
                sqlWaterRecord = "SELECT * FROM Cargo_Water WHERE SHIP_ID = '" & Ship_ID & "' AND Flag = '" & Me.cbTimeNumEnd.SelectedValue & "'"
                dvWaterRecord = Filldata(sqlWaterRecord)
                If IsNumeric(dvWaterRecord.Item(0)("WaterDensity_True")) Then
                    Me.lbDensity2.Text = dvWaterRecord.Item(0)("WaterDensity_True")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("Fc")) Then
                    Me.lbHeadWater2.Text = dvWaterRecord.Item(0)("Fc")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("Ac")) Then
                    Me.lbRearWater2.Text = dvWaterRecord.Item(0)("Ac")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("Mc")) Then
                    Me.lbMiddleWater2.Text = dvWaterRecord.Item(0)("Mc")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("DM_WaterDepth")) Then
                    Me.lbDM2.Text = dvWaterRecord.Item(0)("DM_WaterDepth")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("WaterTon_Corres")) Then
                    Me.lbCorWaterTon2.Text = dvWaterRecord.Item(0)("WaterTon_Corres")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("WaterTon_Clean_G")) Then
                    Me.lbVerWaterTon2.Text = dvWaterRecord.Item(0)("WaterTon_Clean_G")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("WaterTon_Density")) Then
                    Me.lbDesWaterTon2.Text = dvWaterRecord.Item(0)("WaterTon_Density")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("Fuel")) Then
                    Me.lbFuel2.Text = dvWaterRecord.Item(0)("Fuel")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("WaterLight")) Then
                    Me.lbCleanWater2.Text = dvWaterRecord.Item(0)("WaterLight")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("WaterCabin")) Then
                    Me.lbCabinWater2.Text = dvWaterRecord.Item(0)("WaterCabin")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("ConstNum")) Then
                    Me.lbConstant2.Text = dvWaterRecord.Item(0)("ConstNum")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("WaterTon_Empty")) Then
                    Me.lbEmptyWater2.Text = dvWaterRecord.Item(0)("WaterTon_Empty")
                End If
                If IsNumeric(dvWaterRecord.Item(0)("CargoWeight")) Then
                    Me.lbSub2.Text = dvWaterRecord.Item(0)("CargoWeight")
                End If
                Me.lbWorker2.Text = dvWaterRecord.Item(0)("WORK_NO")
                If IsNumeric(Me.lbSub1.Text) And IsNumeric(Me.lbSub2.Text) Then
                    Me.lbWeightGong.Text = Abs(CDec(lbSub1.Text) - CDec(lbSub2.Text))
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        Me.txtAmount.Clear()
        Me.cbConsign.SelectedValue = "00"
        Me.cbPortLoad.SelectedValue = "00"
        Me.cbPortUnload.SelectedValue = "00"
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub FrmCargoWaterResult_Add_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.cbConsign.Focused Then
                Me.txtAmount.Focus()
            ElseIf Me.txtAmount.Focused Then
                Me.cbPortLoad.Focus()
            ElseIf Me.cbPortLoad.Focused Then
                Me.cbPortUnload.Focus()
            ElseIf Me.cbPortUnload.Focused Then
                Me.cbTimeNumBegin.Focus()
            ElseIf Me.cbTimeNumBegin.Focused Then
                Me.cbTimeNumEnd.Focus()
            ElseIf Me.cbTimeNumEnd.Focused Then
                Me.btSave.Focus()
            End If
        End If
    End Sub
End Class
