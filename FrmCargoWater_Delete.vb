Imports TALLY.DBControl
Public Class FrmCargoWater_Delete
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
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbWaterTon_Corres As System.Windows.Forms.Label
    Friend WithEvents lbOddsWater As System.Windows.Forms.Label
    Friend WithEvents lbDM_WaterDep_Corres As System.Windows.Forms.Label
    Friend WithEvents lbTc As System.Windows.Forms.Label
    Friend WithEvents lbMm As System.Windows.Forms.Label
    Friend WithEvents lbAm As System.Windows.Forms.Label
    Friend WithEvents lbFm As System.Windows.Forms.Label
    Friend WithEvents lbAps As System.Windows.Forms.Label
    Friend WithEvents lbMps As System.Windows.Forms.Label
    Friend WithEvents lbFps As System.Windows.Forms.Label
    Friend WithEvents txtConsign As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents lbWaterTon_Odds As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbT_WaterOdds As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents dtpTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtWorker As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbCargoWeight_ConstNum As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents txtConstNum_Empty As System.Windows.Forms.TextBox
    Friend WithEvents txtWaterCabin As System.Windows.Forms.TextBox
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents txtFuel As System.Windows.Forms.TextBox
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents txtWaterLight As System.Windows.Forms.TextBox
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents txtWaterTon_Empty As System.Windows.Forms.TextBox
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents txtWaterDensity_Draw As System.Windows.Forms.TextBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents lbWaterTon_Clean_Y As System.Windows.Forms.Label
    Friend WithEvents lbZ_ying As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents lbFc As System.Windows.Forms.Label
    Friend WithEvents txtFp As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents lbSubtotalThing As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtFs As System.Windows.Forms.TextBox
    Friend WithEvents txtAs As System.Windows.Forms.TextBox
    Friend WithEvents txtAp As System.Windows.Forms.TextBox
    Friend WithEvents txtMp As System.Windows.Forms.TextBox
    Friend WithEvents txtMs As System.Windows.Forms.TextBox
    Friend WithEvents txtTPI As System.Windows.Forms.TextBox
    Friend WithEvents txtLBP As System.Windows.Forms.TextBox
    Friend WithEvents txtdF As System.Windows.Forms.TextBox
    Friend WithEvents txtMTC As System.Windows.Forms.TextBox
    Friend WithEvents txtCf As System.Windows.Forms.TextBox
    Friend WithEvents txtD As System.Windows.Forms.TextBox
    Friend WithEvents txtAverageWater As System.Windows.Forms.TextBox
    Friend WithEvents txtTPC As System.Windows.Forms.TextBox
    Friend WithEvents txtdA As System.Windows.Forms.TextBox
    Friend WithEvents lbDM_WaterDepth As System.Windows.Forms.Label
    Friend WithEvents lbAc As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents lbMc As System.Windows.Forms.Label
    Friend WithEvents lbZ_gong As System.Windows.Forms.Label
    Friend WithEvents lbWaterTon_Density As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents lbWaterTon_Clean_G As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents txtWaterDensity_True As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbWaterTon_Corres = New System.Windows.Forms.Label()
        Me.lbOddsWater = New System.Windows.Forms.Label()
        Me.lbDM_WaterDep_Corres = New System.Windows.Forms.Label()
        Me.lbTc = New System.Windows.Forms.Label()
        Me.lbMm = New System.Windows.Forms.Label()
        Me.lbAm = New System.Windows.Forms.Label()
        Me.lbFm = New System.Windows.Forms.Label()
        Me.lbAps = New System.Windows.Forms.Label()
        Me.lbMps = New System.Windows.Forms.Label()
        Me.lbFps = New System.Windows.Forms.Label()
        Me.txtConsign = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.lbWaterTon_Odds = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbT_WaterOdds = New System.Windows.Forms.Label()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtWorker = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbCargoWeight_ConstNum = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.txtConstNum_Empty = New System.Windows.Forms.TextBox()
        Me.txtWaterCabin = New System.Windows.Forms.TextBox()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.txtFuel = New System.Windows.Forms.TextBox()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.txtWaterLight = New System.Windows.Forms.TextBox()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.txtWaterTon_Empty = New System.Windows.Forms.TextBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.txtWaterDensity_Draw = New System.Windows.Forms.TextBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.lbWaterTon_Clean_Y = New System.Windows.Forms.Label()
        Me.lbZ_ying = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.lbFc = New System.Windows.Forms.Label()
        Me.txtFp = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lbSubtotalThing = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtFs = New System.Windows.Forms.TextBox()
        Me.txtAs = New System.Windows.Forms.TextBox()
        Me.txtAp = New System.Windows.Forms.TextBox()
        Me.txtMp = New System.Windows.Forms.TextBox()
        Me.txtMs = New System.Windows.Forms.TextBox()
        Me.txtTPI = New System.Windows.Forms.TextBox()
        Me.txtLBP = New System.Windows.Forms.TextBox()
        Me.txtdF = New System.Windows.Forms.TextBox()
        Me.txtMTC = New System.Windows.Forms.TextBox()
        Me.txtCf = New System.Windows.Forms.TextBox()
        Me.txtD = New System.Windows.Forms.TextBox()
        Me.txtAverageWater = New System.Windows.Forms.TextBox()
        Me.txtTPC = New System.Windows.Forms.TextBox()
        Me.txtdA = New System.Windows.Forms.TextBox()
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
        Me.Label61 = New System.Windows.Forms.Label()
        Me.txtWaterDensity_True = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(454, 4)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(136, 20)
        Me.Label32.TabIndex = 718
        Me.Label32.Text = "前次水尺记录无"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(218, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(178, 20)
        Me.Label8.TabIndex = 717
        Me.Label8.Text = "第一次测试记录"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbWaterTon_Corres
        '
        Me.lbWaterTon_Corres.BackColor = System.Drawing.SystemColors.Info
        Me.lbWaterTon_Corres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbWaterTon_Corres.Location = New System.Drawing.Point(236, 326)
        Me.lbWaterTon_Corres.Name = "lbWaterTon_Corres"
        Me.lbWaterTon_Corres.Size = New System.Drawing.Size(66, 20)
        Me.lbWaterTon_Corres.TabIndex = 716
        Me.lbWaterTon_Corres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbOddsWater
        '
        Me.lbOddsWater.BackColor = System.Drawing.SystemColors.Info
        Me.lbOddsWater.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbOddsWater.Location = New System.Drawing.Point(88, 326)
        Me.lbOddsWater.Name = "lbOddsWater"
        Me.lbOddsWater.Size = New System.Drawing.Size(66, 20)
        Me.lbOddsWater.TabIndex = 715
        Me.lbOddsWater.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbDM_WaterDep_Corres
        '
        Me.lbDM_WaterDep_Corres.BackColor = System.Drawing.SystemColors.Info
        Me.lbDM_WaterDep_Corres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbDM_WaterDep_Corres.Location = New System.Drawing.Point(88, 306)
        Me.lbDM_WaterDep_Corres.Name = "lbDM_WaterDep_Corres"
        Me.lbDM_WaterDep_Corres.Size = New System.Drawing.Size(66, 20)
        Me.lbDM_WaterDep_Corres.TabIndex = 714
        Me.lbDM_WaterDep_Corres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTc
        '
        Me.lbTc.BackColor = System.Drawing.SystemColors.Info
        Me.lbTc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbTc.Location = New System.Drawing.Point(208, 218)
        Me.lbTc.Name = "lbTc"
        Me.lbTc.Size = New System.Drawing.Size(94, 20)
        Me.lbTc.TabIndex = 713
        Me.lbTc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbMm
        '
        Me.lbMm.BackColor = System.Drawing.SystemColors.Info
        Me.lbMm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbMm.Location = New System.Drawing.Point(208, 198)
        Me.lbMm.Name = "lbMm"
        Me.lbMm.Size = New System.Drawing.Size(94, 20)
        Me.lbMm.TabIndex = 712
        Me.lbMm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbAm
        '
        Me.lbAm.BackColor = System.Drawing.SystemColors.Info
        Me.lbAm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAm.Location = New System.Drawing.Point(208, 178)
        Me.lbAm.Name = "lbAm"
        Me.lbAm.Size = New System.Drawing.Size(94, 20)
        Me.lbAm.TabIndex = 711
        Me.lbAm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbFm
        '
        Me.lbFm.BackColor = System.Drawing.SystemColors.Info
        Me.lbFm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbFm.Location = New System.Drawing.Point(208, 158)
        Me.lbFm.Name = "lbFm"
        Me.lbFm.Size = New System.Drawing.Size(94, 20)
        Me.lbFm.TabIndex = 710
        Me.lbFm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbAps
        '
        Me.lbAps.BackColor = System.Drawing.SystemColors.Info
        Me.lbAps.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAps.Location = New System.Drawing.Point(242, 72)
        Me.lbAps.Name = "lbAps"
        Me.lbAps.Size = New System.Drawing.Size(60, 20)
        Me.lbAps.TabIndex = 709
        Me.lbAps.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbMps
        '
        Me.lbMps.BackColor = System.Drawing.SystemColors.Info
        Me.lbMps.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbMps.Location = New System.Drawing.Point(242, 92)
        Me.lbMps.Name = "lbMps"
        Me.lbMps.Size = New System.Drawing.Size(60, 20)
        Me.lbMps.TabIndex = 708
        Me.lbMps.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbFps
        '
        Me.lbFps.BackColor = System.Drawing.SystemColors.Info
        Me.lbFps.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbFps.Location = New System.Drawing.Point(242, 52)
        Me.lbFps.Name = "lbFps"
        Me.lbFps.Size = New System.Drawing.Size(60, 20)
        Me.lbFps.TabIndex = 707
        Me.lbFps.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtConsign
        '
        Me.txtConsign.Location = New System.Drawing.Point(312, 356)
        Me.txtConsign.MaxLength = 40
        Me.txtConsign.Name = "txtConsign"
        Me.txtConsign.Size = New System.Drawing.Size(90, 21)
        Me.txtConsign.TabIndex = 628
        Me.txtConsign.Text = ""
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(218, 356)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(92, 20)
        Me.Label34.TabIndex = 706
        Me.Label34.Text = "船长大副委托方"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbWaterTon_Odds
        '
        Me.lbWaterTon_Odds.BackColor = System.Drawing.SystemColors.Info
        Me.lbWaterTon_Odds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbWaterTon_Odds.Location = New System.Drawing.Point(236, 306)
        Me.lbWaterTon_Odds.Name = "lbWaterTon_Odds"
        Me.lbWaterTon_Odds.Size = New System.Drawing.Size(66, 20)
        Me.lbWaterTon_Odds.TabIndex = 705
        Me.lbWaterTon_Odds.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(156, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 704
        Me.Label2.Text = "差额排水量"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbT_WaterOdds
        '
        Me.lbT_WaterOdds.BackColor = System.Drawing.SystemColors.Info
        Me.lbT_WaterOdds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbT_WaterOdds.Location = New System.Drawing.Point(150, 112)
        Me.lbT_WaterOdds.Name = "lbT_WaterOdds"
        Me.lbT_WaterOdds.Size = New System.Drawing.Size(152, 20)
        Me.lbT_WaterOdds.TabIndex = 703
        Me.lbT_WaterOdds.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(310, 386)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 633
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(242, 386)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 632
        Me.btSave.Text = "确认"
        '
        'dtpTime
        '
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTime.Location = New System.Drawing.Point(472, 354)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.Size = New System.Drawing.Size(118, 21)
        Me.dtpTime.TabIndex = 630
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(434, 356)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 20)
        Me.Label7.TabIndex = 702
        Me.Label7.Text = "时间"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWorker
        '
        Me.txtWorker.Location = New System.Drawing.Point(64, 356)
        Me.txtWorker.MaxLength = 20
        Me.txtWorker.Name = "txtWorker"
        Me.txtWorker.Size = New System.Drawing.Size(90, 21)
        Me.txtWorker.TabIndex = 629
        Me.txtWorker.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 701
        Me.Label4.Text = "测视人员"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbCargoWeight_ConstNum
        '
        Me.lbCargoWeight_ConstNum.BackColor = System.Drawing.SystemColors.Info
        Me.lbCargoWeight_ConstNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCargoWeight_ConstNum.Location = New System.Drawing.Point(452, 326)
        Me.lbCargoWeight_ConstNum.Name = "lbCargoWeight_ConstNum"
        Me.lbCargoWeight_ConstNum.Size = New System.Drawing.Size(138, 20)
        Me.lbCargoWeight_ConstNum.TabIndex = 700
        Me.lbCargoWeight_ConstNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label75
        '
        Me.Label75.Location = New System.Drawing.Point(454, 304)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(66, 20)
        Me.Label75.TabIndex = 699
        Me.Label75.Text = "合计："
        Me.Label75.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label76
        '
        Me.Label76.Location = New System.Drawing.Point(454, 282)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(66, 20)
        Me.Label76.TabIndex = 698
        Me.Label76.Text = "重船常数"
        Me.Label76.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label77
        '
        Me.Label77.Location = New System.Drawing.Point(316, 304)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(66, 20)
        Me.Label77.TabIndex = 697
        Me.Label77.Text = "压载水"
        Me.Label77.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtConstNum_Empty
        '
        Me.txtConstNum_Empty.Location = New System.Drawing.Point(520, 280)
        Me.txtConstNum_Empty.MaxLength = 20
        Me.txtConstNum_Empty.Name = "txtConstNum_Empty"
        Me.txtConstNum_Empty.Size = New System.Drawing.Size(70, 21)
        Me.txtConstNum_Empty.TabIndex = 627
        Me.txtConstNum_Empty.Text = ""
        '
        'txtWaterCabin
        '
        Me.txtWaterCabin.Location = New System.Drawing.Point(382, 302)
        Me.txtWaterCabin.MaxLength = 20
        Me.txtWaterCabin.Name = "txtWaterCabin"
        Me.txtWaterCabin.Size = New System.Drawing.Size(70, 21)
        Me.txtWaterCabin.TabIndex = 625
        Me.txtWaterCabin.Text = ""
        '
        'Label79
        '
        Me.Label79.Location = New System.Drawing.Point(316, 260)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(66, 20)
        Me.Label79.TabIndex = 695
        Me.Label79.Text = "燃油"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFuel
        '
        Me.txtFuel.Location = New System.Drawing.Point(382, 258)
        Me.txtFuel.MaxLength = 20
        Me.txtFuel.Name = "txtFuel"
        Me.txtFuel.Size = New System.Drawing.Size(70, 21)
        Me.txtFuel.TabIndex = 623
        Me.txtFuel.Text = ""
        '
        'Label80
        '
        Me.Label80.Location = New System.Drawing.Point(316, 282)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(66, 20)
        Me.Label80.TabIndex = 696
        Me.Label80.Text = "淡水"
        Me.Label80.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWaterLight
        '
        Me.txtWaterLight.Location = New System.Drawing.Point(382, 280)
        Me.txtWaterLight.MaxLength = 20
        Me.txtWaterLight.Name = "txtWaterLight"
        Me.txtWaterLight.Size = New System.Drawing.Size(70, 21)
        Me.txtWaterLight.TabIndex = 624
        Me.txtWaterLight.Text = ""
        '
        'Label74
        '
        Me.Label74.Location = New System.Drawing.Point(316, 238)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(274, 20)
        Me.Label74.TabIndex = 694
        Me.Label74.Text = "船载物料"
        Me.Label74.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label73
        '
        Me.Label73.Location = New System.Drawing.Point(454, 260)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(66, 20)
        Me.Label73.TabIndex = 693
        Me.Label73.Text = "空船排水量"
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWaterTon_Empty
        '
        Me.txtWaterTon_Empty.Location = New System.Drawing.Point(520, 258)
        Me.txtWaterTon_Empty.MaxLength = 20
        Me.txtWaterTon_Empty.Name = "txtWaterTon_Empty"
        Me.txtWaterTon_Empty.Size = New System.Drawing.Size(70, 21)
        Me.txtWaterTon_Empty.TabIndex = 626
        Me.txtWaterTon_Empty.Text = ""
        '
        'Label64
        '
        Me.Label64.Location = New System.Drawing.Point(316, 216)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(274, 20)
        Me.Label64.TabIndex = 692
        Me.Label64.Text = "计算货重/常数"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label63
        '
        Me.Label63.Location = New System.Drawing.Point(316, 192)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(136, 20)
        Me.Label63.TabIndex = 691
        Me.Label63.Text = "密度校正后排水量"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWaterDensity_Draw
        '
        Me.txtWaterDensity_Draw.Location = New System.Drawing.Point(372, 170)
        Me.txtWaterDensity_Draw.MaxLength = 20
        Me.txtWaterDensity_Draw.Name = "txtWaterDensity_Draw"
        Me.txtWaterDensity_Draw.Size = New System.Drawing.Size(80, 21)
        Me.txtWaterDensity_Draw.TabIndex = 621
        Me.txtWaterDensity_Draw.Text = ""
        '
        'Label62
        '
        Me.Label62.Location = New System.Drawing.Point(454, 172)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(54, 20)
        Me.Label62.TabIndex = 690
        Me.Label62.Text = "实测密度"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbWaterTon_Clean_Y
        '
        Me.lbWaterTon_Clean_Y.BackColor = System.Drawing.SystemColors.Info
        Me.lbWaterTon_Clean_Y.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbWaterTon_Clean_Y.Location = New System.Drawing.Point(494, 100)
        Me.lbWaterTon_Clean_Y.Name = "lbWaterTon_Clean_Y"
        Me.lbWaterTon_Clean_Y.Size = New System.Drawing.Size(96, 46)
        Me.lbWaterTon_Clean_Y.TabIndex = 689
        Me.lbWaterTon_Clean_Y.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbZ_ying
        '
        Me.lbZ_ying.BackColor = System.Drawing.SystemColors.Info
        Me.lbZ_ying.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbZ_ying.Location = New System.Drawing.Point(334, 126)
        Me.lbZ_ying.Name = "lbZ_ying"
        Me.lbZ_ying.Size = New System.Drawing.Size(140, 20)
        Me.lbZ_ying.TabIndex = 688
        Me.lbZ_ying.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label59
        '
        Me.Label59.Location = New System.Drawing.Point(334, 100)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(140, 26)
        Me.Label59.TabIndex = 687
        Me.Label59.Text = "Z=12*Tc*Cf*TPI/LBP +Tc2*6*MTC/LBP"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbFc
        '
        Me.lbFc.BackColor = System.Drawing.SystemColors.Info
        Me.lbFc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbFc.Location = New System.Drawing.Point(80, 158)
        Me.lbFc.Name = "lbFc"
        Me.lbFc.Size = New System.Drawing.Size(86, 20)
        Me.lbFc.TabIndex = 675
        Me.lbFc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFp
        '
        Me.txtFp.Location = New System.Drawing.Point(64, 50)
        Me.txtFp.MaxLength = 20
        Me.txtFp.Name = "txtFp"
        Me.txtFp.Size = New System.Drawing.Size(60, 21)
        Me.txtFp.TabIndex = 606
        Me.txtFp.Text = ""
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(132, 264)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(24, 20)
        Me.Label28.TabIndex = 664
        Me.Label28.Text = "Cf"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(212, 72)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(30, 20)
        Me.Label29.TabIndex = 660
        Me.Label29.Text = "Aps"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(172, 198)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 20)
        Me.Label18.TabIndex = 648
        Me.Label18.Text = "Mm"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(126, 52)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(24, 20)
        Me.Label17.TabIndex = 647
        Me.Label17.Text = "Fs"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(8, 158)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 80)
        Me.Label16.TabIndex = 646
        Me.Label16.Text = "纵倾校正后的平均吃水"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 92)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 20)
        Me.Label15.TabIndex = 645
        Me.Label15.Text = "船中"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(40, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 20)
        Me.Label14.TabIndex = 644
        Me.Label14.Text = "Fp"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(212, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 20)
        Me.Label13.TabIndex = 643
        Me.Label13.Text = "Fps"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 20)
        Me.Label12.TabIndex = 642
        Me.Label12.Text = "船尾"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(142, 20)
        Me.Label11.TabIndex = 641
        Me.Label11.Text = "吃水差 T"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 20)
        Me.Label10.TabIndex = 640
        Me.Label10.Text = "LBP"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(208, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 20)
        Me.Label9.TabIndex = 639
        Me.Label9.Text = "dA"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(108, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 20)
        Me.Label6.TabIndex = 638
        Me.Label6.Text = "dF"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 20)
        Me.Label5.TabIndex = 637
        Me.Label5.Text = "船首"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(212, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 636
        Me.Label3.Text = "横倾水尺校正"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 20)
        Me.Label1.TabIndex = 635
        Me.Label1.Text = "测视水尺"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 634
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(44, 158)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 20)
        Me.Label19.TabIndex = 652
        Me.Label19.Text = "Fc"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(172, 158)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(30, 20)
        Me.Label20.TabIndex = 651
        Me.Label20.Text = "Fm"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(44, 178)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(30, 20)
        Me.Label21.TabIndex = 655
        Me.Label21.Text = "Ac"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(44, 198)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(30, 20)
        Me.Label22.TabIndex = 657
        Me.Label22.Text = "Mc"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(172, 178)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(30, 20)
        Me.Label23.TabIndex = 654
        Me.Label23.Text = "Am"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(44, 218)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(30, 20)
        Me.Label24.TabIndex = 649
        Me.Label24.Text = "D/M"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(218, 264)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(24, 20)
        Me.Label25.TabIndex = 650
        Me.Label25.Text = "TPC"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(40, 92)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(24, 20)
        Me.Label26.TabIndex = 653
        Me.Label26.Text = "Mp"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(172, 218)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(30, 20)
        Me.Label27.TabIndex = 656
        Me.Label27.Text = "Tc"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(40, 72)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(24, 20)
        Me.Label30.TabIndex = 661
        Me.Label30.Text = "Ap"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(218, 284)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(24, 20)
        Me.Label31.TabIndex = 667
        Me.Label31.Text = "TPI"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(126, 92)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(24, 20)
        Me.Label33.TabIndex = 658
        Me.Label33.Text = "Ms"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbSubtotalThing
        '
        Me.lbSubtotalThing.BackColor = System.Drawing.SystemColors.Info
        Me.lbSubtotalThing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSubtotalThing.Location = New System.Drawing.Point(520, 304)
        Me.lbSubtotalThing.Name = "lbSubtotalThing"
        Me.lbSubtotalThing.Size = New System.Drawing.Size(70, 20)
        Me.lbSubtotalThing.TabIndex = 659
        Me.lbSubtotalThing.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(316, 326)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(136, 20)
        Me.Label35.TabIndex = 666
        Me.Label35.Text = "货重 合计："
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(126, 72)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(24, 20)
        Me.Label38.TabIndex = 663
        Me.Label38.Text = "As"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(132, 284)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(24, 20)
        Me.Label39.TabIndex = 665
        Me.Label39.Text = "MTC"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(212, 92)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(30, 20)
        Me.Label40.TabIndex = 662
        Me.Label40.Text = "Mps"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFs
        '
        Me.txtFs.Location = New System.Drawing.Point(150, 50)
        Me.txtFs.MaxLength = 20
        Me.txtFs.Name = "txtFs"
        Me.txtFs.Size = New System.Drawing.Size(60, 21)
        Me.txtFs.TabIndex = 607
        Me.txtFs.Text = ""
        '
        'txtAs
        '
        Me.txtAs.Location = New System.Drawing.Point(150, 70)
        Me.txtAs.MaxLength = 20
        Me.txtAs.Name = "txtAs"
        Me.txtAs.Size = New System.Drawing.Size(60, 21)
        Me.txtAs.TabIndex = 609
        Me.txtAs.Text = ""
        '
        'txtAp
        '
        Me.txtAp.Location = New System.Drawing.Point(64, 70)
        Me.txtAp.MaxLength = 20
        Me.txtAp.Name = "txtAp"
        Me.txtAp.Size = New System.Drawing.Size(60, 21)
        Me.txtAp.TabIndex = 608
        Me.txtAp.Text = ""
        '
        'txtMp
        '
        Me.txtMp.Location = New System.Drawing.Point(64, 90)
        Me.txtMp.MaxLength = 20
        Me.txtMp.Name = "txtMp"
        Me.txtMp.Size = New System.Drawing.Size(60, 21)
        Me.txtMp.TabIndex = 610
        Me.txtMp.Text = ""
        '
        'txtMs
        '
        Me.txtMs.Location = New System.Drawing.Point(150, 90)
        Me.txtMs.MaxLength = 20
        Me.txtMs.Name = "txtMs"
        Me.txtMs.Size = New System.Drawing.Size(60, 21)
        Me.txtMs.TabIndex = 611
        Me.txtMs.Text = ""
        '
        'txtTPI
        '
        Me.txtTPI.Location = New System.Drawing.Point(242, 282)
        Me.txtTPI.MaxLength = 20
        Me.txtTPI.Name = "txtTPI"
        Me.txtTPI.Size = New System.Drawing.Size(60, 21)
        Me.txtTPI.TabIndex = 619
        Me.txtTPI.Text = ""
        '
        'txtLBP
        '
        Me.txtLBP.Location = New System.Drawing.Point(38, 134)
        Me.txtLBP.MaxLength = 20
        Me.txtLBP.Name = "txtLBP"
        Me.txtLBP.Size = New System.Drawing.Size(64, 21)
        Me.txtLBP.TabIndex = 612
        Me.txtLBP.Text = ""
        '
        'txtdF
        '
        Me.txtdF.Location = New System.Drawing.Point(138, 134)
        Me.txtdF.MaxLength = 20
        Me.txtdF.Name = "txtdF"
        Me.txtdF.Size = New System.Drawing.Size(64, 21)
        Me.txtdF.TabIndex = 613
        Me.txtdF.Text = ""
        '
        'txtMTC
        '
        Me.txtMTC.Location = New System.Drawing.Point(156, 282)
        Me.txtMTC.MaxLength = 20
        Me.txtMTC.Name = "txtMTC"
        Me.txtMTC.Size = New System.Drawing.Size(60, 21)
        Me.txtMTC.TabIndex = 618
        Me.txtMTC.Text = ""
        '
        'txtCf
        '
        Me.txtCf.Location = New System.Drawing.Point(156, 262)
        Me.txtCf.MaxLength = 20
        Me.txtCf.Name = "txtCf"
        Me.txtCf.Size = New System.Drawing.Size(60, 21)
        Me.txtCf.TabIndex = 616
        Me.txtCf.Text = ""
        '
        'txtD
        '
        Me.txtD.Location = New System.Drawing.Point(70, 262)
        Me.txtD.MaxLength = 20
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(60, 21)
        Me.txtD.TabIndex = 615
        Me.txtD.Text = ""
        '
        'txtAverageWater
        '
        Me.txtAverageWater.Location = New System.Drawing.Point(70, 282)
        Me.txtAverageWater.MaxLength = 20
        Me.txtAverageWater.Name = "txtAverageWater"
        Me.txtAverageWater.Size = New System.Drawing.Size(60, 21)
        Me.txtAverageWater.TabIndex = 620
        Me.txtAverageWater.Text = ""
        '
        'txtTPC
        '
        Me.txtTPC.Location = New System.Drawing.Point(242, 262)
        Me.txtTPC.MaxLength = 20
        Me.txtTPC.Name = "txtTPC"
        Me.txtTPC.Size = New System.Drawing.Size(60, 21)
        Me.txtTPC.TabIndex = 617
        Me.txtTPC.Text = ""
        '
        'txtdA
        '
        Me.txtdA.Location = New System.Drawing.Point(238, 134)
        Me.txtdA.MaxLength = 20
        Me.txtdA.Name = "txtdA"
        Me.txtdA.Size = New System.Drawing.Size(64, 21)
        Me.txtdA.TabIndex = 614
        Me.txtdA.Text = ""
        '
        'lbDM_WaterDepth
        '
        Me.lbDM_WaterDepth.BackColor = System.Drawing.SystemColors.Info
        Me.lbDM_WaterDepth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbDM_WaterDepth.Location = New System.Drawing.Point(80, 218)
        Me.lbDM_WaterDepth.Name = "lbDM_WaterDepth"
        Me.lbDM_WaterDepth.Size = New System.Drawing.Size(86, 20)
        Me.lbDM_WaterDepth.TabIndex = 674
        Me.lbDM_WaterDepth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbAc
        '
        Me.lbAc.BackColor = System.Drawing.SystemColors.Info
        Me.lbAc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAc.Location = New System.Drawing.Point(80, 178)
        Me.lbAc.Name = "lbAc"
        Me.lbAc.Size = New System.Drawing.Size(86, 20)
        Me.lbAc.TabIndex = 676
        Me.lbAc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(8, 242)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(294, 20)
        Me.Label43.TabIndex = 678
        Me.Label43.Text = "排水量/载重量计算"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label44
        '
        Me.Label44.Location = New System.Drawing.Point(8, 284)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(62, 20)
        Me.Label44.TabIndex = 677
        Me.Label44.Text = "平均水尺"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbMc
        '
        Me.lbMc.BackColor = System.Drawing.SystemColors.Info
        Me.lbMc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbMc.Location = New System.Drawing.Point(80, 198)
        Me.lbMc.Name = "lbMc"
        Me.lbMc.Size = New System.Drawing.Size(86, 20)
        Me.lbMc.TabIndex = 673
        Me.lbMc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbZ_gong
        '
        Me.lbZ_gong.BackColor = System.Drawing.SystemColors.Info
        Me.lbZ_gong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbZ_gong.Location = New System.Drawing.Point(334, 78)
        Me.lbZ_gong.Name = "lbZ_gong"
        Me.lbZ_gong.Size = New System.Drawing.Size(140, 20)
        Me.lbZ_gong.TabIndex = 669
        Me.lbZ_gong.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbWaterTon_Density
        '
        Me.lbWaterTon_Density.BackColor = System.Drawing.SystemColors.Info
        Me.lbWaterTon_Density.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbWaterTon_Density.Location = New System.Drawing.Point(454, 192)
        Me.lbWaterTon_Density.Name = "lbWaterTon_Density"
        Me.lbWaterTon_Density.Size = New System.Drawing.Size(136, 20)
        Me.lbWaterTon_Density.TabIndex = 668
        Me.lbWaterTon_Density.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label48
        '
        Me.Label48.Location = New System.Drawing.Point(316, 172)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(54, 20)
        Me.Label48.TabIndex = 670
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
        Me.lbWaterTon_Clean_G.TabIndex = 672
        Me.lbWaterTon_Clean_G.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label50
        '
        Me.Label50.Location = New System.Drawing.Point(316, 30)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(274, 20)
        Me.Label50.TabIndex = 671
        Me.Label50.Text = "船舶纵倾排水量校正"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label51
        '
        Me.Label51.Location = New System.Drawing.Point(8, 264)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(62, 20)
        Me.Label51.TabIndex = 684
        Me.Label51.Text = "查表:   D"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label52
        '
        Me.Label52.Location = New System.Drawing.Point(316, 52)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(16, 94)
        Me.Label52.TabIndex = 683
        Me.Label52.Text = "公制 英制"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label53
        '
        Me.Label53.Location = New System.Drawing.Point(334, 52)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(140, 26)
        Me.Label53.TabIndex = 686
        Me.Label53.Text = "Z=100*Tc*Cf*TPC/LBP  +Tc2*50*MTC/LBP"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label54
        '
        Me.Label54.Location = New System.Drawing.Point(8, 306)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(80, 20)
        Me.Label54.TabIndex = 685
        Me.Label54.Text = "相应水尺D/M"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label55
        '
        Me.Label55.Location = New System.Drawing.Point(156, 326)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(80, 20)
        Me.Label55.TabIndex = 680
        Me.Label55.Text = "相应排水量"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label56
        '
        Me.Label56.Location = New System.Drawing.Point(476, 52)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(16, 94)
        Me.Label56.TabIndex = 679
        Me.Label56.Text = "校正后排水量"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label57
        '
        Me.Label57.Location = New System.Drawing.Point(8, 326)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(80, 20)
        Me.Label57.TabIndex = 682
        Me.Label57.Text = "差额水尺"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label61
        '
        Me.Label61.Location = New System.Drawing.Point(316, 150)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(274, 20)
        Me.Label61.TabIndex = 681
        Me.Label61.Text = "港水密度校正"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtWaterDensity_True
        '
        Me.txtWaterDensity_True.Location = New System.Drawing.Point(510, 170)
        Me.txtWaterDensity_True.MaxLength = 20
        Me.txtWaterDensity_True.Name = "txtWaterDensity_True"
        Me.txtWaterDensity_True.Size = New System.Drawing.Size(80, 21)
        Me.txtWaterDensity_True.TabIndex = 622
        Me.txtWaterDensity_True.Text = ""
        '
        'FrmCargoWater_Delete
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(598, 413)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label32, Me.Label8, Me.lbWaterTon_Corres, Me.lbOddsWater, Me.lbDM_WaterDep_Corres, Me.lbTc, Me.lbMm, Me.lbAm, Me.lbFm, Me.lbAps, Me.lbMps, Me.lbFps, Me.txtConsign, Me.Label34, Me.lbWaterTon_Odds, Me.Label2, Me.lbT_WaterOdds, Me.btQuit, Me.btSave, Me.dtpTime, Me.Label7, Me.txtWorker, Me.Label4, Me.lbCargoWeight_ConstNum, Me.Label75, Me.Label76, Me.Label77, Me.txtConstNum_Empty, Me.txtWaterCabin, Me.Label79, Me.txtFuel, Me.Label80, Me.txtWaterLight, Me.Label74, Me.Label73, Me.txtWaterTon_Empty, Me.Label64, Me.Label63, Me.txtWaterDensity_Draw, Me.Label62, Me.lbWaterTon_Clean_Y, Me.lbZ_ying, Me.Label59, Me.lbFc, Me.txtFp, Me.Label28, Me.Label29, Me.Label18, Me.Label17, Me.Label16, Me.Label15, Me.Label14, Me.Label13, Me.Label12, Me.Label11, Me.Label10, Me.Label9, Me.Label6, Me.Label5, Me.Label3, Me.Label1, Me.txtID, Me.Label19, Me.Label20, Me.Label21, Me.Label22, Me.Label23, Me.Label24, Me.Label25, Me.Label26, Me.Label27, Me.Label30, Me.Label31, Me.Label33, Me.lbSubtotalThing, Me.Label35, Me.Label38, Me.Label39, Me.Label40, Me.txtFs, Me.txtAs, Me.txtAp, Me.txtMp, Me.txtMs, Me.txtTPI, Me.txtLBP, Me.txtdF, Me.txtMTC, Me.txtCf, Me.txtD, Me.txtAverageWater, Me.txtTPC, Me.txtdA, Me.lbDM_WaterDepth, Me.lbAc, Me.Label43, Me.Label44, Me.lbMc, Me.lbZ_gong, Me.lbWaterTon_Density, Me.Label48, Me.lbWaterTon_Clean_G, Me.Label50, Me.Label51, Me.Label52, Me.Label53, Me.Label54, Me.Label55, Me.Label56, Me.Label57, Me.Label61, Me.txtWaterDensity_True})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargoWater_Delete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "散杂货水尺记录信息 删除"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim iTime As Short

    Private Sub FrmCargoWater_Delete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Dim dvLastTime As New DataView()
        Dim sqlLastTime As String

        sqlstr = "select * from CARGO_WATER where CARGO_WATER_ID =" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        dtpTime.CustomFormat = "yyyy'-'MM'-'dd' 'hh"
        txtWaterDensity_Draw.Text = "1.025"
        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("CARGO_WATER_ID")
            txtWorker.Text = ds.Tables(0).Rows(0).Item("WORK_NO")
            txtConsign.Text = ds.Tables(0).Rows(0).Item("Consign")
            dtpTime.Value = ds.Tables(0).Rows(0).Item("TIME")

            Me.txtFp.Text = ds.Tables(0).Rows(0).Item("Fp")
            Me.txtFs.Text = ds.Tables(0).Rows(0).Item("Fs")
            Me.txtAp.Text = ds.Tables(0).Rows(0).Item("Ap")
            Me.txtAs.Text = ds.Tables(0).Rows(0).Item("As1")
            Me.txtMp.Text = ds.Tables(0).Rows(0).Item("Mp")
            Me.txtMs.Text = ds.Tables(0).Rows(0).Item("Ms")

            Me.txtLBP.Text = ds.Tables(0).Rows(0).Item("LBP")
            Me.txtdF.Text = ds.Tables(0).Rows(0).Item("dF")
            Me.txtdA.Text = ds.Tables(0).Rows(0).Item("dA")

            Me.txtD.Text = ds.Tables(0).Rows(0).Item("D")
            Me.txtCf.Text = ds.Tables(0).Rows(0).Item("Cf")
            Me.txtTPC.Text = ds.Tables(0).Rows(0).Item("TPC")
            Me.txtTPI.Text = ds.Tables(0).Rows(0).Item("TPI")
            Me.txtMTC.Text = ds.Tables(0).Rows(0).Item("MTC")
            Me.txtAverageWater.Text = ds.Tables(0).Rows(0).Item("AverageWater")

            Me.txtWaterDensity_Draw.Text = ds.Tables(0).Rows(0).Item("WaterDensity_Draw")
            Me.txtWaterDensity_True.Text = ds.Tables(0).Rows(0).Item("WaterDensity_True")

            Me.txtFuel.Text = ds.Tables(0).Rows(0).Item("FuelHeavy")
            Me.txtWaterLight.Text = ds.Tables(0).Rows(0).Item("WaterLight")
            Me.txtWaterCabin.Text = ds.Tables(0).Rows(0).Item("WaterCabin")
            Me.txtWaterTon_Empty.Text = ds.Tables(0).Rows(0).Item("WaterTon_Empty")
            Me.txtConstNum_Empty.Text = ds.Tables(0).Rows(0).Item("ConstNum")   '加字段

            Me.lbCargoWeight_ConstNum.Text = ds.Tables(0).Rows(0).Item("CargoWeight")
            Me.lbSubtotalThing.Text = ds.Tables(0).Rows(0).Item("SubtotalThing")

            Me.lbWaterTon_Density.Text = ds.Tables(0).Rows(0).Item("WaterTon_Density")
            Me.lbWaterTon_Clean_G.Text = ds.Tables(0).Rows(0).Item("WaterTon_Clean_G")
            Me.lbWaterTon_Clean_Y.Text = ds.Tables(0).Rows(0).Item("WaterTon_Clean_Y")
            Me.lbZ_gong.Text = ds.Tables(0).Rows(0).Item("Z_gong")
            Me.lbZ_ying.Text = ds.Tables(0).Rows(0).Item("Z_ying")

            Me.lbDM_WaterDep_Corres.Text = ds.Tables(0).Rows(0).Item("DM_WaterDepth")
            Me.lbOddsWater.Text = ds.Tables(0).Rows(0).Item("OddsWater")
            Me.lbWaterTon_Odds.Text = ds.Tables(0).Rows(0).Item("WaterTon_Odds")    '加字段
            Me.lbWaterTon_Corres.Text = ds.Tables(0).Rows(0).Item("WaterTon_Corres")

            Me.lbFm.Text = ds.Tables(0).Rows(0).Item("Fm")
            Me.lbAm.Text = ds.Tables(0).Rows(0).Item("Am")
            Me.lbMm.Text = ds.Tables(0).Rows(0).Item("Mm")
            Me.lbTc.Text = ds.Tables(0).Rows(0).Item("Tc")
            Me.lbDM_WaterDepth.Text = Me.lbDM_WaterDep_Corres.Text
            Me.lbFc.Text = ds.Tables(0).Rows(0).Item("Fc")
            Me.lbAc.Text = ds.Tables(0).Rows(0).Item("Ac")
            Me.lbMc.Text = ds.Tables(0).Rows(0).Item("Mc")

            Me.lbFps.Text = ds.Tables(0).Rows(0).Item("Fps")
            Me.lbAps.Text = ds.Tables(0).Rows(0).Item("Aps")
            Me.lbMps.Text = ds.Tables(0).Rows(0).Item("Mps")
            Me.lbT_WaterOdds.Text = ds.Tables(0).Rows(0).Item("T_WaterOdds")


            iTime = ds.Tables(0).Rows(0).Item("Flag")
            Me.Label8.Text = "第 " & iTime & " 次测试记录"
            sqlLastTime = "select Flag from Cargo_Water where Ship_ID = '" & Ship_ID & "' and Flag < '" & iTime & "'"
            dvLastTime = Filldata(sqlLastTime)
            dvLastTime.Sort = "Flag desc"
            If dvLastTime.Count > 0 Then
                Dim iLastTime As Short = dvLastTime.Item(0)(0)
                Me.Label32.Text = "前次水尺记录是第 " & iLastTime & " 次"
            End If
        End If
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            If MessageBox.Show("确认要删除吗？", "警告提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                '记录操作日志
                Call OperateHistory(G_DeptName, Now, G_User, "删除", "CARGO_WATER", Trim(txtID.Text), "CARGO_WATER_ID")
                ds.Tables(0).Rows(0).Delete()
                sqlda.Update(ds)
            End If
            Me.Close()
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
