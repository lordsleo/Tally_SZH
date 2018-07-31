Imports TALLY.DBControl
Public Class FrmCargoWater_AddOg
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
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
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtWorker As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents txtFp As System.Windows.Forms.TextBox
    Friend WithEvents txtFs As System.Windows.Forms.TextBox
    Friend WithEvents txtAs As System.Windows.Forms.TextBox
    Friend WithEvents txtAp As System.Windows.Forms.TextBox
    Friend WithEvents txtMp As System.Windows.Forms.TextBox
    Friend WithEvents txtMs As System.Windows.Forms.TextBox
    Friend WithEvents txtAps As System.Windows.Forms.TextBox
    Friend WithEvents txtFps As System.Windows.Forms.TextBox
    Friend WithEvents txtMps As System.Windows.Forms.TextBox
    Friend WithEvents txtFm As System.Windows.Forms.TextBox
    Friend WithEvents txtLBP As System.Windows.Forms.TextBox
    Friend WithEvents txtdF As System.Windows.Forms.TextBox
    Friend WithEvents txtdA As System.Windows.Forms.TextBox
    Friend WithEvents lbSubtotalThing As System.Windows.Forms.Label
    Friend WithEvents txtMm As System.Windows.Forms.TextBox
    Friend WithEvents txtAm As System.Windows.Forms.TextBox
    Friend WithEvents txtTPI As System.Windows.Forms.TextBox
    Friend WithEvents txtTc As System.Windows.Forms.TextBox
    Friend WithEvents txtMTC As System.Windows.Forms.TextBox
    Friend WithEvents txtCf As System.Windows.Forms.TextBox
    Friend WithEvents txtD As System.Windows.Forms.TextBox
    Friend WithEvents txtAverageWater As System.Windows.Forms.TextBox
    Friend WithEvents txtTPC As System.Windows.Forms.TextBox
    Friend WithEvents txtWaterTon_Corres As System.Windows.Forms.TextBox
    Friend WithEvents txtOddsWater As System.Windows.Forms.TextBox
    Friend WithEvents lbFc As System.Windows.Forms.Label
    Friend WithEvents lbDM_WaterDepth As System.Windows.Forms.Label
    Friend WithEvents lbAc As System.Windows.Forms.Label
    Friend WithEvents lbMc As System.Windows.Forms.Label
    Friend WithEvents lbZ_gong As System.Windows.Forms.Label
    Friend WithEvents lbWaterTon_Density As System.Windows.Forms.Label
    Friend WithEvents lbWaterTon_Clean_G As System.Windows.Forms.Label
    Friend WithEvents lbZ_ying As System.Windows.Forms.Label
    Friend WithEvents lbWaterTon_Clean_Y As System.Windows.Forms.Label
    Friend WithEvents txtWaterDensity_Draw As System.Windows.Forms.TextBox
    Friend WithEvents txtWaterDensity_True As System.Windows.Forms.TextBox
    Friend WithEvents txtOilQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtCargoWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtWaterQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtFuelEveryday As System.Windows.Forms.TextBox
    Friend WithEvents txtWaterDensity_Draw2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSeaWater As System.Windows.Forms.TextBox
    Friend WithEvents txtWaterEverday As System.Windows.Forms.TextBox
    Friend WithEvents txtWaterTon_Empty As System.Windows.Forms.TextBox
    Friend WithEvents txtOther As System.Windows.Forms.TextBox
    Friend WithEvents txtWaterCabin As System.Windows.Forms.TextBox
    Friend WithEvents txtFuelLight As System.Windows.Forms.TextBox
    Friend WithEvents txtFuelHeavy As System.Windows.Forms.TextBox
    Friend WithEvents txtWaterLight As System.Windows.Forms.TextBox
    Friend WithEvents lbSubtotalCargo As System.Windows.Forms.Label
    Friend WithEvents dtpTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnFiqure As System.Windows.Forms.Button
    Friend WithEvents txtWaterDensity_True2 As System.Windows.Forms.TextBox
    Friend WithEvents lbT_WaterOdds As System.Windows.Forms.Label
    Friend WithEvents txtDM_WaterDep_Corres As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lbSubtotalThing = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtFp = New System.Windows.Forms.TextBox()
        Me.txtFs = New System.Windows.Forms.TextBox()
        Me.txtAs = New System.Windows.Forms.TextBox()
        Me.txtAp = New System.Windows.Forms.TextBox()
        Me.txtMp = New System.Windows.Forms.TextBox()
        Me.txtMs = New System.Windows.Forms.TextBox()
        Me.txtAps = New System.Windows.Forms.TextBox()
        Me.txtFps = New System.Windows.Forms.TextBox()
        Me.txtMps = New System.Windows.Forms.TextBox()
        Me.txtFm = New System.Windows.Forms.TextBox()
        Me.txtMm = New System.Windows.Forms.TextBox()
        Me.txtAm = New System.Windows.Forms.TextBox()
        Me.txtTPI = New System.Windows.Forms.TextBox()
        Me.txtLBP = New System.Windows.Forms.TextBox()
        Me.txtdF = New System.Windows.Forms.TextBox()
        Me.txtTc = New System.Windows.Forms.TextBox()
        Me.txtMTC = New System.Windows.Forms.TextBox()
        Me.txtCf = New System.Windows.Forms.TextBox()
        Me.txtD = New System.Windows.Forms.TextBox()
        Me.txtAverageWater = New System.Windows.Forms.TextBox()
        Me.txtDM_WaterDep_Corres = New System.Windows.Forms.TextBox()
        Me.txtTPC = New System.Windows.Forms.TextBox()
        Me.txtWaterTon_Corres = New System.Windows.Forms.TextBox()
        Me.txtdA = New System.Windows.Forms.TextBox()
        Me.txtOddsWater = New System.Windows.Forms.TextBox()
        Me.lbFc = New System.Windows.Forms.Label()
        Me.lbDM_WaterDepth = New System.Windows.Forms.Label()
        Me.lbAc = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.lbMc = New System.Windows.Forms.Label()
        Me.lbZ_gong = New System.Windows.Forms.Label()
        Me.lbWaterTon_Density = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.lbWaterTon_Clean_G = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.lbZ_ying = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.lbWaterTon_Clean_Y = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.txtWaterDensity_Draw = New System.Windows.Forms.TextBox()
        Me.txtWaterDensity_True = New System.Windows.Forms.TextBox()
        Me.txtOilQuantity = New System.Windows.Forms.TextBox()
        Me.txtCargoWeight = New System.Windows.Forms.TextBox()
        Me.txtWaterQuantity = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.txtFuelEveryday = New System.Windows.Forms.TextBox()
        Me.txtWaterDensity_Draw2 = New System.Windows.Forms.TextBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.txtWaterDensity_True2 = New System.Windows.Forms.TextBox()
        Me.txtSeaWater = New System.Windows.Forms.TextBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.txtWaterEverday = New System.Windows.Forms.TextBox()
        Me.txtWaterTon_Empty = New System.Windows.Forms.TextBox()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.txtOther = New System.Windows.Forms.TextBox()
        Me.txtWaterCabin = New System.Windows.Forms.TextBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.txtFuelLight = New System.Windows.Forms.TextBox()
        Me.txtFuelHeavy = New System.Windows.Forms.TextBox()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.txtWaterLight = New System.Windows.Forms.TextBox()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.lbSubtotalCargo = New System.Windows.Forms.Label()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtWorker = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.btnFiqure = New System.Windows.Forms.Button()
        Me.lbT_WaterOdds = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(248, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 20)
        Me.Label8.TabIndex = 289
        Me.Label8.Text = "首次测试记录单"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 283
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 20)
        Me.Label1.TabIndex = 290
        Me.Label1.Text = "测视水尺"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(212, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 291
        Me.Label3.Text = "横倾水尺校正"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 20)
        Me.Label5.TabIndex = 292
        Me.Label5.Text = "船首"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(108, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 20)
        Me.Label6.TabIndex = 293
        Me.Label6.Text = "dF"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(208, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 20)
        Me.Label9.TabIndex = 294
        Me.Label9.Text = "dA"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 20)
        Me.Label10.TabIndex = 295
        Me.Label10.Text = "LBP"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 20)
        Me.Label11.TabIndex = 296
        Me.Label11.Text = "吃水差 T"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 20)
        Me.Label12.TabIndex = 297
        Me.Label12.Text = "船尾"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(212, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 20)
        Me.Label13.TabIndex = 298
        Me.Label13.Text = "Fps"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(40, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 20)
        Me.Label14.TabIndex = 299
        Me.Label14.Text = "Fp"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 100)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 20)
        Me.Label15.TabIndex = 300
        Me.Label15.Text = "船中"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(8, 170)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 92)
        Me.Label16.TabIndex = 301
        Me.Label16.Text = "纵倾校正后的平均吃水"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(126, 52)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(24, 20)
        Me.Label17.TabIndex = 302
        Me.Label17.Text = "Fs"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(172, 218)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 20)
        Me.Label18.TabIndex = 303
        Me.Label18.Text = "Mm"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(44, 170)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 20)
        Me.Label19.TabIndex = 303
        Me.Label19.Text = "Fc"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(172, 170)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(30, 20)
        Me.Label20.TabIndex = 303
        Me.Label20.Text = "Fm"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(44, 194)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(30, 20)
        Me.Label21.TabIndex = 303
        Me.Label21.Text = "Ac"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(44, 218)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(30, 20)
        Me.Label22.TabIndex = 303
        Me.Label22.Text = "Mc"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(172, 194)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(30, 20)
        Me.Label23.TabIndex = 303
        Me.Label23.Text = "Am"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(44, 242)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(30, 20)
        Me.Label24.TabIndex = 303
        Me.Label24.Text = "D/M"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(218, 288)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(24, 20)
        Me.Label25.TabIndex = 303
        Me.Label25.Text = "TPC"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(40, 100)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(24, 20)
        Me.Label26.TabIndex = 303
        Me.Label26.Text = "Mp"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(172, 242)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(30, 20)
        Me.Label27.TabIndex = 303
        Me.Label27.Text = "Tc"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(132, 288)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(24, 20)
        Me.Label28.TabIndex = 305
        Me.Label28.Text = "Cf"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(212, 76)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(30, 20)
        Me.Label29.TabIndex = 304
        Me.Label29.Text = "Aps"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(40, 76)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(24, 20)
        Me.Label30.TabIndex = 304
        Me.Label30.Text = "Ap"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(132, 310)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(24, 20)
        Me.Label31.TabIndex = 305
        Me.Label31.Text = "TPI"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(126, 100)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(24, 20)
        Me.Label33.TabIndex = 304
        Me.Label33.Text = "Ms"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbSubtotalThing
        '
        Me.lbSubtotalThing.BackColor = System.Drawing.SystemColors.Info
        Me.lbSubtotalThing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSubtotalThing.Location = New System.Drawing.Point(536, 348)
        Me.lbSubtotalThing.Name = "lbSubtotalThing"
        Me.lbSubtotalThing.Size = New System.Drawing.Size(54, 20)
        Me.lbSubtotalThing.TabIndex = 304
        Me.lbSubtotalThing.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(316, 370)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(136, 20)
        Me.Label35.TabIndex = 305
        Me.Label35.Text = "货重/常数"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(126, 76)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(24, 20)
        Me.Label38.TabIndex = 304
        Me.Label38.Text = "As"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(46, 310)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(24, 20)
        Me.Label39.TabIndex = 305
        Me.Label39.Text = "MTC"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(212, 100)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(30, 20)
        Me.Label40.TabIndex = 304
        Me.Label40.Text = "Mps"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFp
        '
        Me.txtFp.Location = New System.Drawing.Point(64, 50)
        Me.txtFp.MaxLength = 20
        Me.txtFp.Name = "txtFp"
        Me.txtFp.Size = New System.Drawing.Size(60, 21)
        Me.txtFp.TabIndex = 306
        Me.txtFp.Text = ""
        '
        'txtFs
        '
        Me.txtFs.Location = New System.Drawing.Point(150, 50)
        Me.txtFs.MaxLength = 20
        Me.txtFs.Name = "txtFs"
        Me.txtFs.Size = New System.Drawing.Size(60, 21)
        Me.txtFs.TabIndex = 306
        Me.txtFs.Text = ""
        '
        'txtAs
        '
        Me.txtAs.Location = New System.Drawing.Point(150, 74)
        Me.txtAs.MaxLength = 20
        Me.txtAs.Name = "txtAs"
        Me.txtAs.Size = New System.Drawing.Size(60, 21)
        Me.txtAs.TabIndex = 306
        Me.txtAs.Text = ""
        '
        'txtAp
        '
        Me.txtAp.Location = New System.Drawing.Point(64, 74)
        Me.txtAp.MaxLength = 20
        Me.txtAp.Name = "txtAp"
        Me.txtAp.Size = New System.Drawing.Size(60, 21)
        Me.txtAp.TabIndex = 306
        Me.txtAp.Text = ""
        '
        'txtMp
        '
        Me.txtMp.Location = New System.Drawing.Point(64, 98)
        Me.txtMp.MaxLength = 20
        Me.txtMp.Name = "txtMp"
        Me.txtMp.Size = New System.Drawing.Size(60, 21)
        Me.txtMp.TabIndex = 306
        Me.txtMp.Text = ""
        '
        'txtMs
        '
        Me.txtMs.Location = New System.Drawing.Point(150, 98)
        Me.txtMs.MaxLength = 20
        Me.txtMs.Name = "txtMs"
        Me.txtMs.Size = New System.Drawing.Size(60, 21)
        Me.txtMs.TabIndex = 306
        Me.txtMs.Text = ""
        '
        'txtAps
        '
        Me.txtAps.Location = New System.Drawing.Point(242, 74)
        Me.txtAps.MaxLength = 20
        Me.txtAps.Name = "txtAps"
        Me.txtAps.Size = New System.Drawing.Size(60, 21)
        Me.txtAps.TabIndex = 306
        Me.txtAps.Text = ""
        '
        'txtFps
        '
        Me.txtFps.Location = New System.Drawing.Point(242, 50)
        Me.txtFps.MaxLength = 20
        Me.txtFps.Name = "txtFps"
        Me.txtFps.Size = New System.Drawing.Size(60, 21)
        Me.txtFps.TabIndex = 306
        Me.txtFps.Text = ""
        '
        'txtMps
        '
        Me.txtMps.Location = New System.Drawing.Point(242, 98)
        Me.txtMps.MaxLength = 20
        Me.txtMps.Name = "txtMps"
        Me.txtMps.Size = New System.Drawing.Size(60, 21)
        Me.txtMps.TabIndex = 306
        Me.txtMps.Text = ""
        '
        'txtFm
        '
        Me.txtFm.Location = New System.Drawing.Point(206, 168)
        Me.txtFm.MaxLength = 20
        Me.txtFm.Name = "txtFm"
        Me.txtFm.Size = New System.Drawing.Size(96, 21)
        Me.txtFm.TabIndex = 306
        Me.txtFm.Text = ""
        '
        'txtMm
        '
        Me.txtMm.Location = New System.Drawing.Point(206, 216)
        Me.txtMm.MaxLength = 20
        Me.txtMm.Name = "txtMm"
        Me.txtMm.Size = New System.Drawing.Size(96, 21)
        Me.txtMm.TabIndex = 306
        Me.txtMm.Text = ""
        '
        'txtAm
        '
        Me.txtAm.Location = New System.Drawing.Point(206, 192)
        Me.txtAm.MaxLength = 20
        Me.txtAm.Name = "txtAm"
        Me.txtAm.Size = New System.Drawing.Size(96, 21)
        Me.txtAm.TabIndex = 306
        Me.txtAm.Text = ""
        '
        'txtTPI
        '
        Me.txtTPI.Location = New System.Drawing.Point(156, 308)
        Me.txtTPI.MaxLength = 20
        Me.txtTPI.Name = "txtTPI"
        Me.txtTPI.Size = New System.Drawing.Size(60, 21)
        Me.txtTPI.TabIndex = 306
        Me.txtTPI.Text = ""
        '
        'txtLBP
        '
        Me.txtLBP.Location = New System.Drawing.Point(38, 144)
        Me.txtLBP.MaxLength = 20
        Me.txtLBP.Name = "txtLBP"
        Me.txtLBP.Size = New System.Drawing.Size(64, 21)
        Me.txtLBP.TabIndex = 306
        Me.txtLBP.Text = ""
        '
        'txtdF
        '
        Me.txtdF.Location = New System.Drawing.Point(138, 144)
        Me.txtdF.MaxLength = 20
        Me.txtdF.Name = "txtdF"
        Me.txtdF.Size = New System.Drawing.Size(64, 21)
        Me.txtdF.TabIndex = 306
        Me.txtdF.Text = ""
        '
        'txtTc
        '
        Me.txtTc.Location = New System.Drawing.Point(206, 240)
        Me.txtTc.MaxLength = 20
        Me.txtTc.Name = "txtTc"
        Me.txtTc.Size = New System.Drawing.Size(96, 21)
        Me.txtTc.TabIndex = 306
        Me.txtTc.Text = ""
        '
        'txtMTC
        '
        Me.txtMTC.Location = New System.Drawing.Point(70, 308)
        Me.txtMTC.MaxLength = 20
        Me.txtMTC.Name = "txtMTC"
        Me.txtMTC.Size = New System.Drawing.Size(60, 21)
        Me.txtMTC.TabIndex = 306
        Me.txtMTC.Text = ""
        '
        'txtCf
        '
        Me.txtCf.Location = New System.Drawing.Point(156, 286)
        Me.txtCf.MaxLength = 20
        Me.txtCf.Name = "txtCf"
        Me.txtCf.Size = New System.Drawing.Size(60, 21)
        Me.txtCf.TabIndex = 306
        Me.txtCf.Text = ""
        '
        'txtD
        '
        Me.txtD.Location = New System.Drawing.Point(70, 286)
        Me.txtD.MaxLength = 20
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(60, 21)
        Me.txtD.TabIndex = 306
        Me.txtD.Text = ""
        '
        'txtAverageWater
        '
        Me.txtAverageWater.Location = New System.Drawing.Point(88, 330)
        Me.txtAverageWater.MaxLength = 20
        Me.txtAverageWater.Name = "txtAverageWater"
        Me.txtAverageWater.Size = New System.Drawing.Size(64, 21)
        Me.txtAverageWater.TabIndex = 306
        Me.txtAverageWater.Text = ""
        '
        'txtDM_WaterDep_Corres
        '
        Me.txtDM_WaterDep_Corres.Location = New System.Drawing.Point(238, 330)
        Me.txtDM_WaterDep_Corres.MaxLength = 20
        Me.txtDM_WaterDep_Corres.Name = "txtDM_WaterDep_Corres"
        Me.txtDM_WaterDep_Corres.Size = New System.Drawing.Size(64, 21)
        Me.txtDM_WaterDep_Corres.TabIndex = 306
        Me.txtDM_WaterDep_Corres.Text = ""
        '
        'txtTPC
        '
        Me.txtTPC.Location = New System.Drawing.Point(242, 286)
        Me.txtTPC.MaxLength = 20
        Me.txtTPC.Name = "txtTPC"
        Me.txtTPC.Size = New System.Drawing.Size(60, 21)
        Me.txtTPC.TabIndex = 306
        Me.txtTPC.Text = ""
        '
        'txtWaterTon_Corres
        '
        Me.txtWaterTon_Corres.Location = New System.Drawing.Point(238, 352)
        Me.txtWaterTon_Corres.MaxLength = 20
        Me.txtWaterTon_Corres.Name = "txtWaterTon_Corres"
        Me.txtWaterTon_Corres.Size = New System.Drawing.Size(64, 21)
        Me.txtWaterTon_Corres.TabIndex = 306
        Me.txtWaterTon_Corres.Text = ""
        '
        'txtdA
        '
        Me.txtdA.Location = New System.Drawing.Point(238, 144)
        Me.txtdA.MaxLength = 20
        Me.txtdA.Name = "txtdA"
        Me.txtdA.Size = New System.Drawing.Size(64, 21)
        Me.txtdA.TabIndex = 306
        Me.txtdA.Text = ""
        '
        'txtOddsWater
        '
        Me.txtOddsWater.Location = New System.Drawing.Point(88, 352)
        Me.txtOddsWater.MaxLength = 20
        Me.txtOddsWater.Name = "txtOddsWater"
        Me.txtOddsWater.Size = New System.Drawing.Size(64, 21)
        Me.txtOddsWater.TabIndex = 306
        Me.txtOddsWater.Text = ""
        '
        'lbFc
        '
        Me.lbFc.BackColor = System.Drawing.SystemColors.Info
        Me.lbFc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbFc.Location = New System.Drawing.Point(80, 170)
        Me.lbFc.Name = "lbFc"
        Me.lbFc.Size = New System.Drawing.Size(86, 20)
        Me.lbFc.TabIndex = 307
        Me.lbFc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbDM_WaterDepth
        '
        Me.lbDM_WaterDepth.BackColor = System.Drawing.SystemColors.Info
        Me.lbDM_WaterDepth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbDM_WaterDepth.Location = New System.Drawing.Point(80, 242)
        Me.lbDM_WaterDepth.Name = "lbDM_WaterDepth"
        Me.lbDM_WaterDepth.Size = New System.Drawing.Size(86, 20)
        Me.lbDM_WaterDepth.TabIndex = 307
        Me.lbDM_WaterDepth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbAc
        '
        Me.lbAc.BackColor = System.Drawing.SystemColors.Info
        Me.lbAc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAc.Location = New System.Drawing.Point(80, 194)
        Me.lbAc.Name = "lbAc"
        Me.lbAc.Size = New System.Drawing.Size(86, 20)
        Me.lbAc.TabIndex = 307
        Me.lbAc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(8, 266)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(294, 20)
        Me.Label43.TabIndex = 307
        Me.Label43.Text = "排水量/载重量计算"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label44
        '
        Me.Label44.Location = New System.Drawing.Point(8, 332)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(80, 20)
        Me.Label44.TabIndex = 307
        Me.Label44.Text = "接近平均水尺"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbMc
        '
        Me.lbMc.BackColor = System.Drawing.SystemColors.Info
        Me.lbMc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbMc.Location = New System.Drawing.Point(80, 218)
        Me.lbMc.Name = "lbMc"
        Me.lbMc.Size = New System.Drawing.Size(86, 20)
        Me.lbMc.TabIndex = 307
        Me.lbMc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbZ_gong
        '
        Me.lbZ_gong.BackColor = System.Drawing.SystemColors.Info
        Me.lbZ_gong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbZ_gong.Location = New System.Drawing.Point(334, 78)
        Me.lbZ_gong.Name = "lbZ_gong"
        Me.lbZ_gong.Size = New System.Drawing.Size(140, 20)
        Me.lbZ_gong.TabIndex = 307
        Me.lbZ_gong.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbWaterTon_Density
        '
        Me.lbWaterTon_Density.BackColor = System.Drawing.SystemColors.Info
        Me.lbWaterTon_Density.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbWaterTon_Density.Location = New System.Drawing.Point(158, 422)
        Me.lbWaterTon_Density.Name = "lbWaterTon_Density"
        Me.lbWaterTon_Density.Size = New System.Drawing.Size(144, 20)
        Me.lbWaterTon_Density.TabIndex = 307
        Me.lbWaterTon_Density.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label48
        '
        Me.Label48.Location = New System.Drawing.Point(8, 400)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(76, 20)
        Me.Label48.TabIndex = 307
        Me.Label48.Text = "制表密度"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbWaterTon_Clean_G
        '
        Me.lbWaterTon_Clean_G.BackColor = System.Drawing.SystemColors.Info
        Me.lbWaterTon_Clean_G.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbWaterTon_Clean_G.Location = New System.Drawing.Point(494, 52)
        Me.lbWaterTon_Clean_G.Name = "lbWaterTon_Clean_G"
        Me.lbWaterTon_Clean_G.Size = New System.Drawing.Size(96, 46)
        Me.lbWaterTon_Clean_G.TabIndex = 307
        Me.lbWaterTon_Clean_G.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label50
        '
        Me.Label50.Location = New System.Drawing.Point(316, 30)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(274, 20)
        Me.Label50.TabIndex = 307
        Me.Label50.Text = "船舶纵倾排水量校正"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label51
        '
        Me.Label51.Location = New System.Drawing.Point(8, 288)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(62, 20)
        Me.Label51.TabIndex = 307
        Me.Label51.Text = "查表:   D"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label52
        '
        Me.Label52.Location = New System.Drawing.Point(316, 52)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(16, 94)
        Me.Label52.TabIndex = 307
        Me.Label52.Text = "公制 英制"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label53
        '
        Me.Label53.Location = New System.Drawing.Point(334, 52)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(140, 26)
        Me.Label53.TabIndex = 307
        Me.Label53.Text = "Z=100*Tc*Cf*TPC/LBP  +Tc2*50*MTC/LBP"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label54
        '
        Me.Label54.Location = New System.Drawing.Point(158, 332)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(80, 20)
        Me.Label54.TabIndex = 307
        Me.Label54.Text = "相应水尺D/M"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label55
        '
        Me.Label55.Location = New System.Drawing.Point(158, 354)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(80, 20)
        Me.Label55.TabIndex = 307
        Me.Label55.Text = "相应排水量"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label56
        '
        Me.Label56.Location = New System.Drawing.Point(476, 52)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(16, 94)
        Me.Label56.TabIndex = 307
        Me.Label56.Text = "校正后排水量"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label57
        '
        Me.Label57.Location = New System.Drawing.Point(8, 354)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(80, 20)
        Me.Label57.TabIndex = 307
        Me.Label57.Text = "差额水尺"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbZ_ying
        '
        Me.lbZ_ying.BackColor = System.Drawing.SystemColors.Info
        Me.lbZ_ying.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbZ_ying.Location = New System.Drawing.Point(334, 126)
        Me.lbZ_ying.Name = "lbZ_ying"
        Me.lbZ_ying.Size = New System.Drawing.Size(140, 20)
        Me.lbZ_ying.TabIndex = 309
        Me.lbZ_ying.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label59
        '
        Me.Label59.Location = New System.Drawing.Point(334, 100)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(140, 26)
        Me.Label59.TabIndex = 308
        Me.Label59.Text = "Z=12*Tc*Cf*TPI/LBP +Tc2*6*MTC/LBP"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbWaterTon_Clean_Y
        '
        Me.lbWaterTon_Clean_Y.BackColor = System.Drawing.SystemColors.Info
        Me.lbWaterTon_Clean_Y.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbWaterTon_Clean_Y.Location = New System.Drawing.Point(494, 100)
        Me.lbWaterTon_Clean_Y.Name = "lbWaterTon_Clean_Y"
        Me.lbWaterTon_Clean_Y.Size = New System.Drawing.Size(96, 46)
        Me.lbWaterTon_Clean_Y.TabIndex = 310
        Me.lbWaterTon_Clean_Y.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label61
        '
        Me.Label61.Location = New System.Drawing.Point(8, 378)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(294, 20)
        Me.Label61.TabIndex = 307
        Me.Label61.Text = "港水密度校正"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label62
        '
        Me.Label62.Location = New System.Drawing.Point(158, 400)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(76, 20)
        Me.Label62.TabIndex = 311
        Me.Label62.Text = "实测密度"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWaterDensity_Draw
        '
        Me.txtWaterDensity_Draw.Location = New System.Drawing.Point(84, 398)
        Me.txtWaterDensity_Draw.MaxLength = 20
        Me.txtWaterDensity_Draw.Name = "txtWaterDensity_Draw"
        Me.txtWaterDensity_Draw.Size = New System.Drawing.Size(68, 21)
        Me.txtWaterDensity_Draw.TabIndex = 312
        Me.txtWaterDensity_Draw.Text = ""
        '
        'txtWaterDensity_True
        '
        Me.txtWaterDensity_True.Location = New System.Drawing.Point(234, 398)
        Me.txtWaterDensity_True.MaxLength = 20
        Me.txtWaterDensity_True.Name = "txtWaterDensity_True"
        Me.txtWaterDensity_True.Size = New System.Drawing.Size(68, 21)
        Me.txtWaterDensity_True.TabIndex = 312
        Me.txtWaterDensity_True.Text = ""
        '
        'txtOilQuantity
        '
        Me.txtOilQuantity.Location = New System.Drawing.Point(396, 214)
        Me.txtOilQuantity.MaxLength = 20
        Me.txtOilQuantity.Name = "txtOilQuantity"
        Me.txtOilQuantity.Size = New System.Drawing.Size(56, 21)
        Me.txtOilQuantity.TabIndex = 312
        Me.txtOilQuantity.Text = ""
        '
        'txtCargoWeight
        '
        Me.txtCargoWeight.Location = New System.Drawing.Point(316, 390)
        Me.txtCargoWeight.MaxLength = 20
        Me.txtCargoWeight.Name = "txtCargoWeight"
        Me.txtCargoWeight.Size = New System.Drawing.Size(136, 21)
        Me.txtCargoWeight.TabIndex = 306
        Me.txtCargoWeight.Text = ""
        '
        'txtWaterQuantity
        '
        Me.txtWaterQuantity.Location = New System.Drawing.Point(396, 192)
        Me.txtWaterQuantity.MaxLength = 20
        Me.txtWaterQuantity.Name = "txtWaterQuantity"
        Me.txtWaterQuantity.Size = New System.Drawing.Size(56, 21)
        Me.txtWaterQuantity.TabIndex = 312
        Me.txtWaterQuantity.Text = ""
        '
        'Label63
        '
        Me.Label63.Location = New System.Drawing.Point(8, 422)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(144, 20)
        Me.Label63.TabIndex = 313
        Me.Label63.Text = "密度校正后排水量"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label64
        '
        Me.Label64.Location = New System.Drawing.Point(316, 150)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(274, 20)
        Me.Label64.TabIndex = 314
        Me.Label64.Text = "计算货重/常数"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label65
        '
        Me.Label65.Location = New System.Drawing.Point(316, 172)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(274, 20)
        Me.Label65.TabIndex = 315
        Me.Label65.Text = "记事"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label66
        '
        Me.Label66.Location = New System.Drawing.Point(316, 194)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(80, 20)
        Me.Label66.TabIndex = 316
        Me.Label66.Text = "上水数量"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label67
        '
        Me.Label67.Location = New System.Drawing.Point(316, 216)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(80, 20)
        Me.Label67.TabIndex = 317
        Me.Label67.Text = "上油数量"
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label68
        '
        Me.Label68.Location = New System.Drawing.Point(454, 216)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(80, 20)
        Me.Label68.TabIndex = 321
        Me.Label68.Text = "燃油日耗量"
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label69
        '
        Me.Label69.Location = New System.Drawing.Point(454, 194)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(80, 20)
        Me.Label69.TabIndex = 320
        Me.Label69.Text = "船舶制表密度"
        Me.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFuelEveryday
        '
        Me.txtFuelEveryday.Location = New System.Drawing.Point(534, 214)
        Me.txtFuelEveryday.MaxLength = 20
        Me.txtFuelEveryday.Name = "txtFuelEveryday"
        Me.txtFuelEveryday.Size = New System.Drawing.Size(56, 21)
        Me.txtFuelEveryday.TabIndex = 318
        Me.txtFuelEveryday.Text = ""
        '
        'txtWaterDensity_Draw2
        '
        Me.txtWaterDensity_Draw2.Location = New System.Drawing.Point(534, 192)
        Me.txtWaterDensity_Draw2.MaxLength = 20
        Me.txtWaterDensity_Draw2.Name = "txtWaterDensity_Draw2"
        Me.txtWaterDensity_Draw2.Size = New System.Drawing.Size(56, 21)
        Me.txtWaterDensity_Draw2.TabIndex = 319
        Me.txtWaterDensity_Draw2.Text = ""
        '
        'Label70
        '
        Me.Label70.Location = New System.Drawing.Point(316, 260)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(80, 20)
        Me.Label70.TabIndex = 321
        Me.Label70.Text = "实测港水密度"
        Me.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label71
        '
        Me.Label71.Location = New System.Drawing.Point(316, 238)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(80, 20)
        Me.Label71.TabIndex = 320
        Me.Label71.Text = "吸入/出海水"
        Me.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWaterDensity_True2
        '
        Me.txtWaterDensity_True2.Location = New System.Drawing.Point(396, 258)
        Me.txtWaterDensity_True2.MaxLength = 20
        Me.txtWaterDensity_True2.Name = "txtWaterDensity_True2"
        Me.txtWaterDensity_True2.Size = New System.Drawing.Size(56, 21)
        Me.txtWaterDensity_True2.TabIndex = 318
        Me.txtWaterDensity_True2.Text = ""
        '
        'txtSeaWater
        '
        Me.txtSeaWater.Location = New System.Drawing.Point(396, 236)
        Me.txtSeaWater.MaxLength = 20
        Me.txtSeaWater.Name = "txtSeaWater"
        Me.txtSeaWater.Size = New System.Drawing.Size(56, 21)
        Me.txtSeaWater.TabIndex = 319
        Me.txtSeaWater.Text = ""
        '
        'Label72
        '
        Me.Label72.Location = New System.Drawing.Point(454, 238)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(80, 20)
        Me.Label72.TabIndex = 325
        Me.Label72.Text = "淡水日耗量"
        Me.Label72.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label73
        '
        Me.Label73.Location = New System.Drawing.Point(454, 260)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(80, 20)
        Me.Label73.TabIndex = 324
        Me.Label73.Text = "空船排水量Do"
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWaterEverday
        '
        Me.txtWaterEverday.Location = New System.Drawing.Point(534, 236)
        Me.txtWaterEverday.MaxLength = 20
        Me.txtWaterEverday.Name = "txtWaterEverday"
        Me.txtWaterEverday.Size = New System.Drawing.Size(56, 21)
        Me.txtWaterEverday.TabIndex = 322
        Me.txtWaterEverday.Text = ""
        '
        'txtWaterTon_Empty
        '
        Me.txtWaterTon_Empty.Location = New System.Drawing.Point(534, 258)
        Me.txtWaterTon_Empty.MaxLength = 20
        Me.txtWaterTon_Empty.Name = "txtWaterTon_Empty"
        Me.txtWaterTon_Empty.Size = New System.Drawing.Size(56, 21)
        Me.txtWaterTon_Empty.TabIndex = 323
        Me.txtWaterTon_Empty.Text = ""
        '
        'Label74
        '
        Me.Label74.Location = New System.Drawing.Point(316, 282)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(274, 20)
        Me.Label74.TabIndex = 326
        Me.Label74.Text = "船载物料"
        Me.Label74.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label76
        '
        Me.Label76.Location = New System.Drawing.Point(454, 326)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(80, 20)
        Me.Label76.TabIndex = 336
        Me.Label76.Text = "其他"
        Me.Label76.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label77
        '
        Me.Label77.Location = New System.Drawing.Point(454, 304)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(80, 20)
        Me.Label77.TabIndex = 335
        Me.Label77.Text = "压载水"
        Me.Label77.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOther
        '
        Me.txtOther.Location = New System.Drawing.Point(534, 324)
        Me.txtOther.MaxLength = 20
        Me.txtOther.Name = "txtOther"
        Me.txtOther.Size = New System.Drawing.Size(56, 21)
        Me.txtOther.TabIndex = 331
        Me.txtOther.Text = ""
        '
        'txtWaterCabin
        '
        Me.txtWaterCabin.Location = New System.Drawing.Point(534, 302)
        Me.txtWaterCabin.MaxLength = 20
        Me.txtWaterCabin.Name = "txtWaterCabin"
        Me.txtWaterCabin.Size = New System.Drawing.Size(56, 21)
        Me.txtWaterCabin.TabIndex = 333
        Me.txtWaterCabin.Text = ""
        '
        'Label78
        '
        Me.Label78.Location = New System.Drawing.Point(316, 326)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(80, 20)
        Me.Label78.TabIndex = 330
        Me.Label78.Text = "轻油"
        Me.Label78.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label79
        '
        Me.Label79.Location = New System.Drawing.Point(316, 304)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(80, 20)
        Me.Label79.TabIndex = 329
        Me.Label79.Text = "重油"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFuelLight
        '
        Me.txtFuelLight.Location = New System.Drawing.Point(396, 324)
        Me.txtFuelLight.MaxLength = 20
        Me.txtFuelLight.Name = "txtFuelLight"
        Me.txtFuelLight.Size = New System.Drawing.Size(56, 21)
        Me.txtFuelLight.TabIndex = 327
        Me.txtFuelLight.Text = ""
        '
        'txtFuelHeavy
        '
        Me.txtFuelHeavy.Location = New System.Drawing.Point(396, 302)
        Me.txtFuelHeavy.MaxLength = 20
        Me.txtFuelHeavy.Name = "txtFuelHeavy"
        Me.txtFuelHeavy.Size = New System.Drawing.Size(56, 21)
        Me.txtFuelHeavy.TabIndex = 328
        Me.txtFuelHeavy.Text = ""
        '
        'Label80
        '
        Me.Label80.Location = New System.Drawing.Point(316, 348)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(80, 20)
        Me.Label80.TabIndex = 334
        Me.Label80.Text = "淡水"
        Me.Label80.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWaterLight
        '
        Me.txtWaterLight.Location = New System.Drawing.Point(396, 346)
        Me.txtWaterLight.MaxLength = 20
        Me.txtWaterLight.Name = "txtWaterLight"
        Me.txtWaterLight.Size = New System.Drawing.Size(56, 21)
        Me.txtWaterLight.TabIndex = 332
        Me.txtWaterLight.Text = ""
        '
        'Label75
        '
        Me.Label75.Location = New System.Drawing.Point(454, 348)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(80, 20)
        Me.Label75.TabIndex = 338
        Me.Label75.Text = "合计："
        Me.Label75.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label81
        '
        Me.Label81.Location = New System.Drawing.Point(454, 392)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(80, 20)
        Me.Label81.TabIndex = 340
        Me.Label81.Text = "合计："
        Me.Label81.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbSubtotalCargo
        '
        Me.lbSubtotalCargo.BackColor = System.Drawing.SystemColors.Info
        Me.lbSubtotalCargo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSubtotalCargo.Location = New System.Drawing.Point(536, 392)
        Me.lbSubtotalCargo.Name = "lbSubtotalCargo"
        Me.lbSubtotalCargo.Size = New System.Drawing.Size(54, 20)
        Me.lbSubtotalCargo.TabIndex = 339
        Me.lbSubtotalCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTime
        '
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTime.Location = New System.Drawing.Point(490, 420)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.Size = New System.Drawing.Size(100, 21)
        Me.dtpTime.TabIndex = 343
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(454, 422)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 20)
        Me.Label7.TabIndex = 344
        Me.Label7.Text = "时间"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWorker
        '
        Me.txtWorker.Location = New System.Drawing.Point(372, 420)
        Me.txtWorker.MaxLength = 20
        Me.txtWorker.Name = "txtWorker"
        Me.txtWorker.Size = New System.Drawing.Size(80, 21)
        Me.txtWorker.TabIndex = 341
        Me.txtWorker.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(316, 422)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 342
        Me.Label4.Text = "测视人员"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(342, 450)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 347
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(274, 450)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 346
        Me.btSave.Text = "确认"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(206, 450)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(65, 24)
        Me.btAdd.TabIndex = 345
        Me.btAdd.Text = "清空"
        '
        'btnFiqure
        '
        Me.btnFiqure.Location = New System.Drawing.Point(8, 448)
        Me.btnFiqure.Name = "btnFiqure"
        Me.btnFiqure.Size = New System.Drawing.Size(65, 24)
        Me.btnFiqure.TabIndex = 348
        Me.btnFiqure.Text = "计算结果"
        '
        'lbT_WaterOdds
        '
        Me.lbT_WaterOdds.BackColor = System.Drawing.SystemColors.Info
        Me.lbT_WaterOdds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbT_WaterOdds.Location = New System.Drawing.Point(126, 122)
        Me.lbT_WaterOdds.Name = "lbT_WaterOdds"
        Me.lbT_WaterOdds.Size = New System.Drawing.Size(176, 20)
        Me.lbT_WaterOdds.TabIndex = 349
        Me.lbT_WaterOdds.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCargoWater_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(598, 475)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lbT_WaterOdds, Me.btnFiqure, Me.btQuit, Me.btSave, Me.btAdd, Me.dtpTime, Me.Label7, Me.txtWorker, Me.Label4, Me.Label81, Me.lbSubtotalCargo, Me.Label75, Me.Label76, Me.Label77, Me.txtOther, Me.txtWaterCabin, Me.Label78, Me.Label79, Me.txtFuelLight, Me.txtFuelHeavy, Me.Label80, Me.txtWaterLight, Me.Label74, Me.Label72, Me.Label73, Me.txtWaterEverday, Me.txtWaterTon_Empty, Me.Label68, Me.Label69, Me.txtFuelEveryday, Me.txtWaterDensity_Draw2, Me.Label67, Me.Label66, Me.Label65, Me.Label64, Me.Label63, Me.txtWaterDensity_Draw, Me.Label62, Me.lbWaterTon_Clean_Y, Me.lbZ_ying, Me.Label59, Me.lbFc, Me.txtFp, Me.Label28, Me.Label29, Me.Label18, Me.Label17, Me.Label16, Me.Label15, Me.Label14, Me.Label13, Me.Label12, Me.Label11, Me.Label10, Me.Label9, Me.Label6, Me.Label5, Me.Label3, Me.Label1, Me.Label8, Me.txtID, Me.Label19, Me.Label20, Me.Label21, Me.Label22, Me.Label23, Me.Label24, Me.Label25, Me.Label26, Me.Label27, Me.Label30, Me.Label31, Me.Label33, Me.lbSubtotalThing, Me.Label35, Me.Label38, Me.Label39, Me.Label40, Me.txtFs, Me.txtAs, Me.txtAp, Me.txtMp, Me.txtMs, Me.txtAps, Me.txtFps, Me.txtMps, Me.txtFm, Me.txtMm, Me.txtAm, Me.txtTPI, Me.txtLBP, Me.txtdF, Me.txtTc, Me.txtMTC, Me.txtCf, Me.txtD, Me.txtAverageWater, Me.txtDM_WaterDep_Corres, Me.txtTPC, Me.txtWaterTon_Corres, Me.txtdA, Me.txtOddsWater, Me.lbDM_WaterDepth, Me.lbAc, Me.Label43, Me.Label44, Me.lbMc, Me.lbZ_gong, Me.lbWaterTon_Density, Me.Label48, Me.lbWaterTon_Clean_G, Me.Label50, Me.Label51, Me.Label52, Me.Label53, Me.Label54, Me.Label55, Me.Label56, Me.Label57, Me.Label61, Me.txtWaterDensity_True, Me.txtOilQuantity, Me.txtCargoWeight, Me.txtWaterQuantity, Me.Label70, Me.Label71, Me.txtWaterDensity_True2, Me.txtSeaWater})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargoWater_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim row As DataRow
    Dim sign As Boolean = False

    Private Sub FrmCargoWater_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String

        sqlstr = "select * from CARGO_WATER where CARGO_WATER_ID =" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        dtpTime.CustomFormat = "yyyy'-'MM'-'dd' 'hh"
        txtWaterDensity_Draw.Text = "1.025"
        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("CARGO_WATER_ID")
            txtWorker.Text = ds.Tables(0).Rows(0).Item("WORK_NO")
            dtpTime.Value = ds.Tables(0).Rows(0).Item("TIME")

            Me.txtFp.Text = ds.Tables(0).Rows(0).Item("Fp")
            Me.txtFs.Text = ds.Tables(0).Rows(0).Item("Fs")
            Me.txtFps.Text = ds.Tables(0).Rows(0).Item("Fps")
            Me.txtAp.Text = ds.Tables(0).Rows(0).Item("Ap")
            Me.txtAs.Text = ds.Tables(0).Rows(0).Item("As1")
            Me.txtAps.Text = ds.Tables(0).Rows(0).Item("Aps")
            Me.txtMp.Text = ds.Tables(0).Rows(0).Item("Mp")
            Me.txtMs.Text = ds.Tables(0).Rows(0).Item("Ms")
            Me.txtMps.Text = ds.Tables(0).Rows(0).Item("Mps")

            Me.txtLBP.Text = ds.Tables(0).Rows(0).Item("LBP")
            Me.txtdF.Text = ds.Tables(0).Rows(0).Item("dF")
            Me.txtdA.Text = ds.Tables(0).Rows(0).Item("dA")
            Me.txtFm.Text = ds.Tables(0).Rows(0).Item("Fm")
            Me.txtAm.Text = ds.Tables(0).Rows(0).Item("Am")
            Me.txtMm.Text = ds.Tables(0).Rows(0).Item("Mm")
            Me.txtTc.Text = ds.Tables(0).Rows(0).Item("Tc")

            Me.txtD.Text = ds.Tables(0).Rows(0).Item("D")
            Me.txtCf.Text = ds.Tables(0).Rows(0).Item("Cf")
            Me.txtTPC.Text = ds.Tables(0).Rows(0).Item("TPC")
            Me.txtTPI.Text = ds.Tables(0).Rows(0).Item("TPI")
            Me.txtMTC.Text = ds.Tables(0).Rows(0).Item("MTC")
            Me.txtAverageWater.Text = ds.Tables(0).Rows(0).Item("AverageWater")
            Me.txtDM_WaterDep_Corres.Text = ds.Tables(0).Rows(0).Item("DM_WaterDep_Corres")
            Me.txtOddsWater.Text = ds.Tables(0).Rows(0).Item("OddsWater")
            Me.txtWaterTon_Corres.Text = ds.Tables(0).Rows(0).Item("WaterTon_Corres")

            Me.txtWaterDensity_Draw.Text = ds.Tables(0).Rows(0).Item("WaterDensity_Draw")
            Me.txtWaterDensity_True.Text = ds.Tables(0).Rows(0).Item("WaterDensity_True")

            Me.txtWaterQuantity.Text = ds.Tables(0).Rows(0).Item("WaterQuantity")
            Me.txtOilQuantity.Text = ds.Tables(0).Rows(0).Item("OilQuantity")
            Me.txtSeaWater.Text = ds.Tables(0).Rows(0).Item("SeaWater")
            Me.txtWaterDensity_True2.Text = Me.txtWaterDensity_True.Text
            Me.txtWaterDensity_Draw2.Text = Me.txtWaterDensity_Draw.Text
            Me.txtFuelEveryday.Text = ds.Tables(0).Rows(0).Item("FuelEveryday")
            Me.txtWaterEverday.Text = ds.Tables(0).Rows(0).Item("WaterEverday")
            Me.txtWaterTon_Empty.Text = ds.Tables(0).Rows(0).Item("WaterTon_Empty")

            Me.txtFuelHeavy.Text = ds.Tables(0).Rows(0).Item("FuelHeavy")
            Me.txtFuelLight.Text = ds.Tables(0).Rows(0).Item("FuelLight")
            Me.txtWaterLight.Text = ds.Tables(0).Rows(0).Item("WaterLight")
            Me.txtWaterCabin.Text = ds.Tables(0).Rows(0).Item("WaterCabin")
            Me.txtOther.Text = ds.Tables(0).Rows(0).Item("Other")
            Me.txtCargoWeight.Text = ds.Tables(0).Rows(0).Item("CargoWeight")

            Me.lbSubtotalCargo.Text = ds.Tables(0).Rows(0).Item("SubtotalCargo")
            Me.lbSubtotalThing.Text = ds.Tables(0).Rows(0).Item("SubtotalThing")
            Me.lbWaterTon_Density.Text = ds.Tables(0).Rows(0).Item("WaterTon_Density")
            Me.lbWaterTon_Clean_G.Text = ds.Tables(0).Rows(0).Item("WaterTon_Clean_G")
            Me.lbWaterTon_Clean_Y.Text = ds.Tables(0).Rows(0).Item("WaterTon_Clean_Y")
            Me.lbZ_gong.Text = ds.Tables(0).Rows(0).Item("Z_gong")
            Me.lbZ_ying.Text = ds.Tables(0).Rows(0).Item("Z_ying")

            Me.lbDM_WaterDepth.Text = ds.Tables(0).Rows(0).Item("DM_WaterDepth")
            Me.lbFc.Text = ds.Tables(0).Rows(0).Item("Fc")
            Me.lbAc.Text = ds.Tables(0).Rows(0).Item("Ac")
            Me.lbMc.Text = ds.Tables(0).Rows(0).Item("Mc")
            Me.lbT_WaterOdds.Text = ds.Tables(0).Rows(0).Item("T_WaterOdds")

            If ds.Tables(0).Rows(0).Item("Flag") = True Then
                Me.Label8.Text = "末次测试记录单"
            End If
        End If

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim sqlExist As String
        Dim iCount As Short
        sqlExist = "select * from CARGO_WATER where SHIP_ID = '" & Ship_ID & "'"
        Try
            If Trim(txtWorker.Text) <> "" Then
                row = ds.Tables(0).NewRow

                If SetNumValue("Fp", txtFp.Text, "Fp") = False Then
                    txtFp.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("Fs", txtFs.Text, "Fs") = False Then
                    txtFs.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("Fps", txtFps.Text, "Fps") = False Then
                    txtFps.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("Ap", txtAp.Text, "Ap") = False Then
                    txtAp.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("As1", txtAs.Text, "As") = False Then
                    txtAs.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("Aps", txtAps.Text, "Aps") = False Then
                    txtAps.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("Mp", txtMp.Text, "Mp") = False Then
                    txtMp.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("Ms", txtMs.Text, "Ms") = False Then
                    txtMs.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("Mps", txtMps.Text, "Mps") = False Then
                    txtMps.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("LBP", txtLBP.Text, "LBP") = False Then
                    txtLBP.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("dF", txtdF.Text, "dF") = False Then
                    txtdF.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("dA", txtdA.Text, "dA") = False Then
                    txtdA.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("Fm", txtFm.Text, "Fm") = False Then
                    txtFm.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("Am", txtAm.Text, "Am") = False Then
                    txtAm.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("Mm", txtMm.Text, "Mm") = False Then
                    txtMm.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("Tc", txtTc.Text, "Tc") = False Then
                    txtTc.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("D", txtD.Text, "D") = False Then
                    txtD.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("Cf", txtCf.Text, "Cf") = False Then
                    txtCf.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("TPC", txtTPC.Text, "TPC") = False Then
                    txtTPC.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("TPI", txtTPI.Text, "TPI") = False Then
                    txtTPI.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("MTC", txtMTC.Text, "MTC") = False Then
                    txtMTC.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("AverageWater", txtAverageWater.Text, "接近平均水尺") = False Then
                    txtAverageWater.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("DM_WaterDep_Corres", txtDM_WaterDep_Corres.Text, "相应水尺D/M") = False Then '改掉
                    txtDM_WaterDep_Corres.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("OddsWater", txtOddsWater.Text, "差额水尺") = False Then
                    txtOddsWater.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("WaterTon_Corres", txtWaterTon_Corres.Text, "相应排水量") = False Then
                    txtWaterTon_Corres.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("WaterDensity_Draw", txtWaterDensity_Draw.Text, "制表密度") = False Then
                    txtWaterDensity_Draw.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("WaterDensity_True", txtWaterDensity_True.Text, "实测密度") = False Then
                    txtWaterDensity_True.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("WaterQuantity", txtWaterQuantity.Text, "上水数量") = False Then
                    txtWaterQuantity.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("OilQuantity", txtOilQuantity.Text, "上油数量") = False Then
                    txtOilQuantity.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("SeaWater", txtSeaWater.Text, "吸入/出海水") = False Then
                    txtSeaWater.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("FuelEveryday", txtFuelEveryday.Text, "燃油日耗量") = False Then
                    txtFuelEveryday.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("WaterEverday", txtWaterEverday.Text, "淡水日耗量") = False Then
                    txtWaterEverday.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("WaterTon_Empty", txtWaterTon_Empty.Text, "空船排水量") = False Then
                    txtWaterTon_Empty.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("FuelHeavy", txtFuelHeavy.Text, "重油") = False Then
                    txtFuelHeavy.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("FuelLight", txtFuelLight.Text, "轻油") = False Then
                    txtFuelLight.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("WaterLight", txtWaterLight.Text, "淡水") = False Then
                    txtWaterLight.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("WaterCabin", txtWaterCabin.Text, "压载水") = False Then
                    txtWaterCabin.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("Other", txtOther.Text, "其他") = False Then
                    txtOther.SelectAll()
                    Exit Sub
                ElseIf SetNumValue("CargoWeight", txtCargoWeight.Text, "货重/常数1") = False Then
                    txtCargoWeight.SelectAll()
                    Exit Sub
                End If

                If sign = True Then     '结果已算出
                    row.Item("SubtotalCargo") = Me.lbSubtotalCargo.Text
                    row.Item("SubtotalThing") = Me.lbSubtotalThing.Text
                    row.Item("WaterTon_Density") = Me.lbWaterTon_Density.Text
                    row.Item("WaterTon_Clean_G") = Me.lbWaterTon_Clean_G.Text
                    row.Item("WaterTon_Clean_Y") = Me.lbWaterTon_Clean_Y.Text
                    row.Item("Z_gong") = Me.lbZ_gong.Text
                    row.Item("Z_ying") = Me.lbZ_ying.Text

                    row.Item("DM_WaterDepth") = Me.lbDM_WaterDepth.Text
                    row.Item("Fc") = Me.lbFc.Text
                    row.Item("Ac") = Me.lbAc.Text
                    row.Item("Mc") = Me.lbMc.Text
                    row.Item("T_WaterOdds") = Me.lbT_WaterOdds.Text
                Else
                    MessageBox.Show("结果尚未计算，请计算结果。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If Trim(Me.txtWaterDensity_Draw2.Text) = Trim(Me.txtWaterDensity_Draw.Text) Then
                    If Trim(Me.txtWaterDensity_Draw2.Text) = Trim(Me.txtWaterDensity_Draw.Text) Then

                    Else
                        MessageBox.Show("船舶制表密度与制表密度不一致！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("实测港水密度与实测密度不一致！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                iCount = Filldata(sqlExist).Count
                If iCount <= 1 Then
                    If iCount = 0 Then      '原无记录，新加首次记录
                        row.Item("Flag") = 0
                    Else         'iCount=1 原有一条记录（首次），新加末次记录
                        row.Item("Flag") = 1
                    End If
                    row.Item("WORK_NO") = Trim(txtWorker.Text)
                    row.Item("TIME") = dtpTime.Value
                    row.Item("SHIP_ID") = Ship_ID
                    row.Item("USER_NAME") = G_User

                    ds.Tables(0).Rows.Add(row)
                    sqlda.Update(ds)
                    Me.Close()
                Else    'iCount=2
                    MessageBox.Show("同一船次水尺记录不能重复。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("测试人员不能为空。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function SetNumValue(ByVal strNumColumn As String, ByVal strNumValue As String, Optional ByVal message As String = "水尺记录数据") As Boolean
        Dim flag As Boolean = True
        If Trim(strNumValue) <> "" Then     '货物重量(初次)
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

    Private Sub btnFiqure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiqure.Click
        Try
            If IsNumeric(Trim(txtFps.Text)) = False Then
                MessageBox.Show("请输入正确的" + "Fps", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtFps.SelectAll()
                Exit Sub
            ElseIf IsNumeric(Trim(txtAps.Text)) = False Then
                MessageBox.Show("请输入正确的" + "Aps", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAps.SelectAll()
                Exit Sub
            ElseIf IsNumeric(Trim(txtMps.Text)) = False Then
                MessageBox.Show("请输入正确的" + "Mps", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMps.SelectAll()
                Exit Sub
            ElseIf IsNumeric(Trim(txtLBP.Text)) = False Then
                MessageBox.Show("请输入正确的" + "LBP", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtLBP.SelectAll()
                Exit Sub
            ElseIf IsNumeric(Trim(txtdF.Text)) = False Then
                MessageBox.Show("请输入正确的" + "dF", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtdF.SelectAll()
                Exit Sub
            ElseIf IsNumeric(Trim(txtdA.Text)) = False Then
                MessageBox.Show("请输入正确的" + "dA", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtdA.SelectAll()
                Exit Sub
            ElseIf IsNumeric(Trim(txtTc.Text)) = False Then
                MessageBox.Show("请输入正确的" + "Tc", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtTc.SelectAll()
                Exit Sub
            ElseIf IsNumeric(Trim(txtCf.Text)) = False Then
                MessageBox.Show("请输入正确的" + "Cf", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCf.SelectAll()
                Exit Sub
            ElseIf IsNumeric(Trim(txtTPC.Text)) = False Then
                MessageBox.Show("请输入正确的" + "TPC", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtTPC.SelectAll()
                Exit Sub
            ElseIf IsNumeric(Trim(txtTPI.Text)) = False Then
                MessageBox.Show("请输入正确的" + "TPI", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtTPI.SelectAll()
                Exit Sub
            ElseIf IsNumeric(Trim(txtMTC.Text)) = False Then
                MessageBox.Show("请输入正确的" + "MTC", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMTC.SelectAll()
                Exit Sub
            ElseIf IsNumeric(Trim(txtWaterTon_Corres.Text)) = False Then
                MessageBox.Show("请输入正确的" + "相应排水量", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtWaterTon_Corres.SelectAll()
                Exit Sub
            ElseIf IsNumeric(Trim(txtWaterDensity_Draw.Text)) = False Then
                MessageBox.Show("请输入正确的" + "制表密度", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtWaterDensity_Draw.SelectAll()
                Exit Sub
            ElseIf IsNumeric(Trim(txtWaterDensity_True.Text)) = False Then
                MessageBox.Show("请输入正确的" + "实测密度", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtWaterDensity_True.SelectAll()
                Exit Sub
            ElseIf IsNumeric(Trim(txtFuelHeavy.Text)) = False Then
                MessageBox.Show("请输入正确的" + "重油", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtFuelHeavy.SelectAll()
                Exit Sub
            ElseIf IsNumeric(Trim(txtFuelLight.Text)) = False Then
                MessageBox.Show("请输入正确的" + "轻油", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtFuelLight.SelectAll()
                Exit Sub
            ElseIf IsNumeric(Trim(txtWaterLight.Text)) = False Then
                MessageBox.Show("请输入正确的" + "淡水", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtWaterLight.SelectAll()
                Exit Sub
            ElseIf IsNumeric(Trim(txtWaterCabin.Text)) = False Then
                MessageBox.Show("请输入正确的" + "压载水", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtWaterCabin.SelectAll()
                Exit Sub
            ElseIf IsNumeric(Trim(txtOther.Text)) = False Then
                MessageBox.Show("请输入正确的" + "其他", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtOther.SelectAll()
                Exit Sub
            ElseIf IsNumeric(Trim(txtCargoWeight.Text)) = False Then
                MessageBox.Show("请输入正确的" + "货重/常数", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCargoWeight.SelectAll()
                Exit Sub
            End If

            Me.lbT_WaterOdds.Text = CDec(Trim(txtAps.Text)) - CDec(Trim(txtFps.Text))
            Dim dTemp As Decimal
            dTemp = CDec(Me.lbT_WaterOdds.Text) / (CDec(Trim(txtLBP.Text)) - (CDec(Trim(txtdF.Text)) + CDec(Trim(txtdA.Text))))
            Me.lbFc.Text = dTemp * CDec(Trim(txtdF.Text))
            Me.lbAc.Text = dTemp * CDec(Trim(txtdA.Text))
            Me.lbMc.Text = dTemp * CDec(Trim(txtdA.Text))
            Me.lbDM_WaterDepth.Text = (CDec(Trim(txtMps.Text)) * 6 + CDec(Trim(txtFps.Text)) + CDec(Trim(txtAps.Text))) / 8
            Dim dt1, dt2 As Decimal
            dt1 = CDec(Trim(txtTc.Text)) * CDec(Trim(txtCf.Text)) / CDec(Trim(txtLBP.Text))
            dt2 = CDec(Trim(txtTc.Text)) * CDec(Trim(txtTc.Text)) * CDec(Trim(txtMTC.Text)) / CDec(Trim(txtLBP.Text))
            Me.lbZ_gong.Text = dt1 * CDec(Trim(txtTPC.Text)) * 100 + dt2 * 50
            Me.lbZ_ying.Text = dt1 * CDec(Trim(txtTPI.Text)) * 12 + dt2 * 6
            Me.lbWaterTon_Clean_G.Text = CDec(Trim(txtWaterTon_Corres.Text)) + CDec(Me.lbZ_gong.Text)
            Me.lbWaterTon_Clean_Y.Text = CDec(Trim(txtWaterTon_Corres.Text)) + CDec(Me.lbZ_ying.Text)
            Me.lbWaterTon_Density.Text = (CDec(Me.lbWaterTon_Clean_G.Text) * CDec(Trim(txtWaterDensity_True.Text))) / CDec(Trim(txtWaterDensity_Draw.Text))

            Me.lbSubtotalThing.Text = CDec(Trim(txtFuelHeavy.Text)) + CDec(Trim(txtFuelLight.Text)) + CDec(Trim(txtWaterLight.Text)) + CDec(Trim(txtWaterCabin.Text)) + CDec(Trim(txtOther.Text))
            Me.lbSubtotalCargo.Text = CDec(Trim(txtCargoWeight.Text))

            'lbT_WaterOdds.Text = Format(CDec(lbT_WaterOdds.Text), "##,##0.00")
            lbT_WaterOdds.Text = Decimal.Round(Convert.ToDecimal(lbT_WaterOdds.Text), 6)
            lbFc.Text = Decimal.Round(Convert.ToDecimal(lbFc.Text), 6)
            lbAc.Text = Decimal.Round(Convert.ToDecimal(lbAc.Text), 6)
            lbMc.Text = Decimal.Round(Convert.ToDecimal(lbMc.Text), 6)
            Me.lbDM_WaterDepth.Text = Decimal.Round(Convert.ToDecimal(Me.lbDM_WaterDepth.Text), 6)

            lbZ_gong.Text = Decimal.Round(Convert.ToDecimal(lbZ_gong.Text), 6)
            lbZ_ying.Text = Decimal.Round(Convert.ToDecimal(lbZ_ying.Text), 6)
            Me.lbWaterTon_Clean_G.Text = Decimal.Round(Convert.ToDecimal(Me.lbWaterTon_Clean_G.Text), 6)
            Me.lbWaterTon_Clean_Y.Text = Decimal.Round(Convert.ToDecimal(Me.lbWaterTon_Clean_Y.Text), 6)
            Me.lbWaterTon_Density.Text = Decimal.Round(Convert.ToDecimal(Me.lbWaterTon_Density.Text), 6)
            Me.lbSubtotalThing.Text = Decimal.Round(Convert.ToDecimal(Me.lbSubtotalThing.Text), 6)
            Me.lbSubtotalCargo.Text = Decimal.Round(Convert.ToDecimal(Me.lbSubtotalCargo.Text), 6)

            sign = True     '已算出结果
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        Me.txtFs.Clear()
        Me.txtFp.Clear()
        Me.txtFps.Clear()
        Me.txtAs.Clear()
        Me.txtAp.Clear()
        Me.txtAps.Clear()
        Me.txtMs.Clear()
        Me.txtMp.Clear()
        Me.txtMps.Clear()

        Me.txtLBP.Clear()
        Me.txtdF.Clear()
        Me.txtdA.Clear()
        Me.txtFm.Clear()
        Me.txtAm.Clear()
        Me.txtMm.Clear()
        Me.txtTc.Clear()

        Me.txtAverageWater.Clear()
        Me.txtD.Clear()
        Me.txtCf.Clear()
        Me.txtTPC.Clear()
        Me.txtTPI.Clear()
        Me.txtMTC.Clear()
        Me.txtDM_WaterDep_Corres.Clear()
        Me.txtOddsWater.Clear()
        Me.txtWaterTon_Corres.Clear()

        Me.txtWaterDensity_Draw.Clear()
        Me.txtWaterDensity_True.Clear()

        Me.txtWaterQuantity.Clear()
        Me.txtOilQuantity.Clear()
        Me.txtSeaWater.Clear()
        Me.txtWaterDensity_True2.Clear()
        Me.txtWaterDensity_Draw2.Clear()
        Me.txtFuelEveryday.Clear()
        Me.txtWaterEverday.Clear()
        Me.txtWaterTon_Empty.Clear()

        Me.txtFuelHeavy.Clear()
        Me.txtFuelLight.Clear()
        Me.txtWaterLight.Clear()
        Me.txtWaterCabin.Clear()
        Me.txtOther.Clear()
        Me.txtCargoWeight.Clear()

        Me.lbSubtotalCargo.Text = ""
        Me.lbSubtotalThing.Text = ""
        Me.lbWaterTon_Density.Text = ""
        Me.lbWaterTon_Clean_G.Text = ""
        Me.lbWaterTon_Clean_Y.Text = ""
        Me.lbZ_gong.Text = ""
        Me.lbZ_ying.Text = ""

        Me.lbDM_WaterDepth.Text = ""
        Me.lbFc.Text = ""
        Me.lbAc.Text = ""
        Me.lbMc.Text = ""
        Me.lbT_WaterOdds.Text = ""

        Me.txtWorker.Clear()
        Me.dtpTime.Value = Now
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub txtWaterDensity_Draw_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtWaterDensity_Draw.Leave
        txtWaterDensity_Draw2.Text = txtWaterDensity_Draw.Text
    End Sub

    Private Sub txtWaterDensity_True_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtWaterDensity_True.Leave
        txtWaterDensity_True2.Text = txtWaterDensity_True.Text
    End Sub
End Class
