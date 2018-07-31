Imports TALLY.DBControl
Public Class FrmCargoWaterResult_Addog
    Inherits System.Windows.Forms.Form

    'Overrides ReadOnly Property focused() As Boolean
    '    Get
    '        Return focused()
    '    End Get
    'End Property
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents dtpTimeEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
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
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents txtWorker As System.Windows.Forms.TextBox
    Friend WithEvents txtConsign As System.Windows.Forms.TextBox
    Friend WithEvents txtDensity_b As System.Windows.Forms.TextBox
    Friend WithEvents txtDensity_e As System.Windows.Forms.TextBox
    Friend WithEvents txtShipHeadDepth_e As System.Windows.Forms.TextBox
    Friend WithEvents txtShipHeadDepth_b As System.Windows.Forms.TextBox
    Friend WithEvents txtShipTailDepth_e As System.Windows.Forms.TextBox
    Friend WithEvents txtShipTailDepth_b As System.Windows.Forms.TextBox
    Friend WithEvents txtShipMidDepth_e As System.Windows.Forms.TextBox
    Friend WithEvents txtShipMidDepth_b As System.Windows.Forms.TextBox
    Friend WithEvents txtReviseWrap_e As System.Windows.Forms.TextBox
    Friend WithEvents txtReviseWrap_b As System.Windows.Forms.TextBox
    Friend WithEvents txtOther_e As System.Windows.Forms.TextBox
    Friend WithEvents txtOther_b As System.Windows.Forms.TextBox
    Friend WithEvents txtWaterTonEmpty_e As System.Windows.Forms.TextBox
    Friend WithEvents txtWaterTonEmpty_b As System.Windows.Forms.TextBox
    Friend WithEvents txtConstantNum_e As System.Windows.Forms.TextBox
    Friend WithEvents txtConstantNum_b As System.Windows.Forms.TextBox
    Friend WithEvents txtBallastWater_e As System.Windows.Forms.TextBox
    Friend WithEvents txtBallastWater_b As System.Windows.Forms.TextBox
    Friend WithEvents txtWater_e As System.Windows.Forms.TextBox
    Friend WithEvents txtWater_b As System.Windows.Forms.TextBox
    Friend WithEvents txtWaterTonDesityRevise_e As System.Windows.Forms.TextBox
    Friend WithEvents txtWaterTonDesityRevise_b As System.Windows.Forms.TextBox
    Friend WithEvents txtWaterTonLeanRevise_e As System.Windows.Forms.TextBox
    Friend WithEvents txtWaterTonLeanRevise_b As System.Windows.Forms.TextBox
    Friend WithEvents txtWaterTon_e As System.Windows.Forms.TextBox
    Friend WithEvents txtWaterTon_b As System.Windows.Forms.TextBox
    Friend WithEvents txtCargoTons_e As System.Windows.Forms.TextBox
    Friend WithEvents txtCargoTons_b As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal_e As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal_b As System.Windows.Forms.TextBox
    Friend WithEvents txtFuel_e As System.Windows.Forms.TextBox
    Friend WithEvents txtFuel_b As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtWorker = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConsign = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.dtpTimeEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpTimeBegin = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDensity_b = New System.Windows.Forms.TextBox()
        Me.txtDensity_e = New System.Windows.Forms.TextBox()
        Me.txtShipHeadDepth_e = New System.Windows.Forms.TextBox()
        Me.txtShipHeadDepth_b = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtShipTailDepth_e = New System.Windows.Forms.TextBox()
        Me.txtShipTailDepth_b = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtShipMidDepth_e = New System.Windows.Forms.TextBox()
        Me.txtShipMidDepth_b = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtReviseWrap_e = New System.Windows.Forms.TextBox()
        Me.txtReviseWrap_b = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtOther_e = New System.Windows.Forms.TextBox()
        Me.txtOther_b = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtWaterTonEmpty_e = New System.Windows.Forms.TextBox()
        Me.txtWaterTonEmpty_b = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtConstantNum_e = New System.Windows.Forms.TextBox()
        Me.txtConstantNum_b = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBallastWater_e = New System.Windows.Forms.TextBox()
        Me.txtBallastWater_b = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtWater_e = New System.Windows.Forms.TextBox()
        Me.txtWater_b = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtWaterTonDesityRevise_e = New System.Windows.Forms.TextBox()
        Me.txtWaterTonDesityRevise_b = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtWaterTonLeanRevise_e = New System.Windows.Forms.TextBox()
        Me.txtWaterTonLeanRevise_b = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtWaterTon_e = New System.Windows.Forms.TextBox()
        Me.txtWaterTon_b = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCargoTons_e = New System.Windows.Forms.TextBox()
        Me.txtCargoTons_b = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTotal_e = New System.Windows.Forms.TextBox()
        Me.txtTotal_b = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtFuel_e = New System.Windows.Forms.TextBox()
        Me.txtFuel_b = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtWorker
        '
        Me.txtWorker.Location = New System.Drawing.Point(92, 30)
        Me.txtWorker.MaxLength = 20
        Me.txtWorker.Name = "txtWorker"
        Me.txtWorker.Size = New System.Drawing.Size(130, 21)
        Me.txtWorker.TabIndex = 273
        Me.txtWorker.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(18, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 276
        Me.Label4.Text = "测视人员"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtConsign
        '
        Me.txtConsign.Location = New System.Drawing.Point(92, 8)
        Me.txtConsign.MaxLength = 40
        Me.txtConsign.Name = "txtConsign"
        Me.txtConsign.Size = New System.Drawing.Size(130, 21)
        Me.txtConsign.TabIndex = 272
        Me.txtConsign.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(-2, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 275
        Me.Label2.Text = "船长大副委托方"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 274
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'dtpTimeEnd
        '
        Me.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeEnd.Location = New System.Drawing.Point(302, 30)
        Me.dtpTimeEnd.Name = "dtpTimeEnd"
        Me.dtpTimeEnd.Size = New System.Drawing.Size(130, 21)
        Me.dtpTimeEnd.TabIndex = 278
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(228, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 18)
        Me.Label8.TabIndex = 280
        Me.Label8.Text = "完工时间"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeBegin
        '
        Me.dtpTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeBegin.Location = New System.Drawing.Point(302, 8)
        Me.dtpTimeBegin.Name = "dtpTimeBegin"
        Me.dtpTimeBegin.Size = New System.Drawing.Size(130, 21)
        Me.dtpTimeBegin.TabIndex = 277
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(228, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 279
        Me.Label7.Text = "开工时间"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(26, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 281
        Me.Label1.Text = "1. 港水密度"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(100, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 282
        Me.Label3.Text = "初次:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDensity_b
        '
        Me.txtDensity_b.Location = New System.Drawing.Point(100, 74)
        Me.txtDensity_b.MaxLength = 20
        Me.txtDensity_b.Name = "txtDensity_b"
        Me.txtDensity_b.Size = New System.Drawing.Size(64, 21)
        Me.txtDensity_b.TabIndex = 283
        Me.txtDensity_b.Text = ""
        '
        'txtDensity_e
        '
        Me.txtDensity_e.Location = New System.Drawing.Point(166, 74)
        Me.txtDensity_e.MaxLength = 20
        Me.txtDensity_e.Name = "txtDensity_e"
        Me.txtDensity_e.Size = New System.Drawing.Size(64, 21)
        Me.txtDensity_e.TabIndex = 284
        Me.txtDensity_e.Text = ""
        '
        'txtShipHeadDepth_e
        '
        Me.txtShipHeadDepth_e.Location = New System.Drawing.Point(166, 96)
        Me.txtShipHeadDepth_e.MaxLength = 20
        Me.txtShipHeadDepth_e.Name = "txtShipHeadDepth_e"
        Me.txtShipHeadDepth_e.Size = New System.Drawing.Size(64, 21)
        Me.txtShipHeadDepth_e.TabIndex = 287
        Me.txtShipHeadDepth_e.Text = ""
        '
        'txtShipHeadDepth_b
        '
        Me.txtShipHeadDepth_b.Location = New System.Drawing.Point(100, 96)
        Me.txtShipHeadDepth_b.MaxLength = 20
        Me.txtShipHeadDepth_b.Name = "txtShipHeadDepth_b"
        Me.txtShipHeadDepth_b.Size = New System.Drawing.Size(64, 21)
        Me.txtShipHeadDepth_b.TabIndex = 286
        Me.txtShipHeadDepth_b.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(26, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 285
        Me.Label5.Text = "船首吃水"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipTailDepth_e
        '
        Me.txtShipTailDepth_e.Location = New System.Drawing.Point(166, 118)
        Me.txtShipTailDepth_e.MaxLength = 20
        Me.txtShipTailDepth_e.Name = "txtShipTailDepth_e"
        Me.txtShipTailDepth_e.Size = New System.Drawing.Size(64, 21)
        Me.txtShipTailDepth_e.TabIndex = 290
        Me.txtShipTailDepth_e.Text = ""
        '
        'txtShipTailDepth_b
        '
        Me.txtShipTailDepth_b.Location = New System.Drawing.Point(100, 118)
        Me.txtShipTailDepth_b.MaxLength = 20
        Me.txtShipTailDepth_b.Name = "txtShipTailDepth_b"
        Me.txtShipTailDepth_b.Size = New System.Drawing.Size(64, 21)
        Me.txtShipTailDepth_b.TabIndex = 289
        Me.txtShipTailDepth_b.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(26, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 288
        Me.Label6.Text = "船尾吃水"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipMidDepth_e
        '
        Me.txtShipMidDepth_e.Location = New System.Drawing.Point(166, 140)
        Me.txtShipMidDepth_e.MaxLength = 20
        Me.txtShipMidDepth_e.Name = "txtShipMidDepth_e"
        Me.txtShipMidDepth_e.Size = New System.Drawing.Size(64, 21)
        Me.txtShipMidDepth_e.TabIndex = 293
        Me.txtShipMidDepth_e.Text = ""
        '
        'txtShipMidDepth_b
        '
        Me.txtShipMidDepth_b.Location = New System.Drawing.Point(100, 140)
        Me.txtShipMidDepth_b.MaxLength = 20
        Me.txtShipMidDepth_b.Name = "txtShipMidDepth_b"
        Me.txtShipMidDepth_b.Size = New System.Drawing.Size(64, 21)
        Me.txtShipMidDepth_b.TabIndex = 292
        Me.txtShipMidDepth_b.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(26, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 291
        Me.Label9.Text = "船中吃水"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReviseWrap_e
        '
        Me.txtReviseWrap_e.Location = New System.Drawing.Point(166, 162)
        Me.txtReviseWrap_e.MaxLength = 20
        Me.txtReviseWrap_e.Name = "txtReviseWrap_e"
        Me.txtReviseWrap_e.Size = New System.Drawing.Size(64, 21)
        Me.txtReviseWrap_e.TabIndex = 296
        Me.txtReviseWrap_e.Text = ""
        '
        'txtReviseWrap_b
        '
        Me.txtReviseWrap_b.Location = New System.Drawing.Point(100, 162)
        Me.txtReviseWrap_b.MaxLength = 20
        Me.txtReviseWrap_b.Name = "txtReviseWrap_b"
        Me.txtReviseWrap_b.Size = New System.Drawing.Size(64, 21)
        Me.txtReviseWrap_b.TabIndex = 295
        Me.txtReviseWrap_b.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 18)
        Me.Label10.TabIndex = 294
        Me.Label10.Text = "吃水拱陷校正"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOther_e
        '
        Me.txtOther_e.Location = New System.Drawing.Point(168, 388)
        Me.txtOther_e.MaxLength = 20
        Me.txtOther_e.Name = "txtOther_e"
        Me.txtOther_e.Size = New System.Drawing.Size(64, 21)
        Me.txtOther_e.TabIndex = 312
        Me.txtOther_e.Text = ""
        '
        'txtOther_b
        '
        Me.txtOther_b.Location = New System.Drawing.Point(102, 388)
        Me.txtOther_b.MaxLength = 20
        Me.txtOther_b.Name = "txtOther_b"
        Me.txtOther_b.Size = New System.Drawing.Size(64, 21)
        Me.txtOther_b.TabIndex = 311
        Me.txtOther_b.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(28, 390)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 18)
        Me.Label11.TabIndex = 310
        Me.Label11.Text = "其他"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWaterTonEmpty_e
        '
        Me.txtWaterTonEmpty_e.Location = New System.Drawing.Point(168, 366)
        Me.txtWaterTonEmpty_e.MaxLength = 20
        Me.txtWaterTonEmpty_e.Name = "txtWaterTonEmpty_e"
        Me.txtWaterTonEmpty_e.Size = New System.Drawing.Size(64, 21)
        Me.txtWaterTonEmpty_e.TabIndex = 309
        Me.txtWaterTonEmpty_e.Text = ""
        '
        'txtWaterTonEmpty_b
        '
        Me.txtWaterTonEmpty_b.Location = New System.Drawing.Point(102, 366)
        Me.txtWaterTonEmpty_b.MaxLength = 20
        Me.txtWaterTonEmpty_b.Name = "txtWaterTonEmpty_b"
        Me.txtWaterTonEmpty_b.Size = New System.Drawing.Size(64, 21)
        Me.txtWaterTonEmpty_b.TabIndex = 308
        Me.txtWaterTonEmpty_b.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(28, 368)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 18)
        Me.Label12.TabIndex = 307
        Me.Label12.Text = "空船排水量"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtConstantNum_e
        '
        Me.txtConstantNum_e.Location = New System.Drawing.Point(168, 344)
        Me.txtConstantNum_e.MaxLength = 20
        Me.txtConstantNum_e.Name = "txtConstantNum_e"
        Me.txtConstantNum_e.Size = New System.Drawing.Size(64, 21)
        Me.txtConstantNum_e.TabIndex = 306
        Me.txtConstantNum_e.Text = ""
        '
        'txtConstantNum_b
        '
        Me.txtConstantNum_b.Location = New System.Drawing.Point(102, 344)
        Me.txtConstantNum_b.MaxLength = 20
        Me.txtConstantNum_b.Name = "txtConstantNum_b"
        Me.txtConstantNum_b.Size = New System.Drawing.Size(64, 21)
        Me.txtConstantNum_b.TabIndex = 305
        Me.txtConstantNum_b.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(28, 346)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 18)
        Me.Label13.TabIndex = 304
        Me.Label13.Text = "常数"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBallastWater_e
        '
        Me.txtBallastWater_e.Location = New System.Drawing.Point(168, 322)
        Me.txtBallastWater_e.MaxLength = 20
        Me.txtBallastWater_e.Name = "txtBallastWater_e"
        Me.txtBallastWater_e.Size = New System.Drawing.Size(64, 21)
        Me.txtBallastWater_e.TabIndex = 303
        Me.txtBallastWater_e.Text = ""
        '
        'txtBallastWater_b
        '
        Me.txtBallastWater_b.Location = New System.Drawing.Point(102, 322)
        Me.txtBallastWater_b.MaxLength = 20
        Me.txtBallastWater_b.Name = "txtBallastWater_b"
        Me.txtBallastWater_b.Size = New System.Drawing.Size(64, 21)
        Me.txtBallastWater_b.TabIndex = 302
        Me.txtBallastWater_b.Text = ""
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(28, 324)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 18)
        Me.Label14.TabIndex = 301
        Me.Label14.Text = "压舱水"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWater_e
        '
        Me.txtWater_e.Location = New System.Drawing.Point(168, 300)
        Me.txtWater_e.MaxLength = 20
        Me.txtWater_e.Name = "txtWater_e"
        Me.txtWater_e.Size = New System.Drawing.Size(64, 21)
        Me.txtWater_e.TabIndex = 300
        Me.txtWater_e.Text = ""
        '
        'txtWater_b
        '
        Me.txtWater_b.Location = New System.Drawing.Point(102, 300)
        Me.txtWater_b.MaxLength = 20
        Me.txtWater_b.Name = "txtWater_b"
        Me.txtWater_b.Size = New System.Drawing.Size(64, 21)
        Me.txtWater_b.TabIndex = 299
        Me.txtWater_b.Text = ""
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(188, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 18)
        Me.Label15.TabIndex = 298
        Me.Label15.Text = "末次:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(28, 302)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 18)
        Me.Label16.TabIndex = 297
        Me.Label16.Text = "淡水"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWaterTonDesityRevise_e
        '
        Me.txtWaterTonDesityRevise_e.Location = New System.Drawing.Point(166, 210)
        Me.txtWaterTonDesityRevise_e.MaxLength = 20
        Me.txtWaterTonDesityRevise_e.Name = "txtWaterTonDesityRevise_e"
        Me.txtWaterTonDesityRevise_e.Size = New System.Drawing.Size(64, 21)
        Me.txtWaterTonDesityRevise_e.TabIndex = 321
        Me.txtWaterTonDesityRevise_e.Text = ""
        '
        'txtWaterTonDesityRevise_b
        '
        Me.txtWaterTonDesityRevise_b.Location = New System.Drawing.Point(100, 210)
        Me.txtWaterTonDesityRevise_b.MaxLength = 20
        Me.txtWaterTonDesityRevise_b.Name = "txtWaterTonDesityRevise_b"
        Me.txtWaterTonDesityRevise_b.Size = New System.Drawing.Size(64, 21)
        Me.txtWaterTonDesityRevise_b.TabIndex = 320
        Me.txtWaterTonDesityRevise_b.Text = ""
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(26, 206)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 29)
        Me.Label19.TabIndex = 319
        Me.Label19.Text = "港水密度校正的排水量"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWaterTonLeanRevise_e
        '
        Me.txtWaterTonLeanRevise_e.Location = New System.Drawing.Point(166, 238)
        Me.txtWaterTonLeanRevise_e.MaxLength = 20
        Me.txtWaterTonLeanRevise_e.Name = "txtWaterTonLeanRevise_e"
        Me.txtWaterTonLeanRevise_e.Size = New System.Drawing.Size(64, 21)
        Me.txtWaterTonLeanRevise_e.TabIndex = 318
        Me.txtWaterTonLeanRevise_e.Text = ""
        '
        'txtWaterTonLeanRevise_b
        '
        Me.txtWaterTonLeanRevise_b.Location = New System.Drawing.Point(100, 238)
        Me.txtWaterTonLeanRevise_b.MaxLength = 20
        Me.txtWaterTonLeanRevise_b.Name = "txtWaterTonLeanRevise_b"
        Me.txtWaterTonLeanRevise_b.Size = New System.Drawing.Size(64, 21)
        Me.txtWaterTonLeanRevise_b.TabIndex = 317
        Me.txtWaterTonLeanRevise_b.Text = ""
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(26, 236)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 30)
        Me.Label20.TabIndex = 316
        Me.Label20.Text = "纵倾校正后的排水量"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWaterTon_e
        '
        Me.txtWaterTon_e.Location = New System.Drawing.Point(166, 184)
        Me.txtWaterTon_e.MaxLength = 20
        Me.txtWaterTon_e.Name = "txtWaterTon_e"
        Me.txtWaterTon_e.Size = New System.Drawing.Size(64, 21)
        Me.txtWaterTon_e.TabIndex = 315
        Me.txtWaterTon_e.Text = ""
        '
        'txtWaterTon_b
        '
        Me.txtWaterTon_b.Location = New System.Drawing.Point(100, 184)
        Me.txtWaterTon_b.MaxLength = 20
        Me.txtWaterTon_b.Name = "txtWaterTon_b"
        Me.txtWaterTon_b.Size = New System.Drawing.Size(64, 21)
        Me.txtWaterTon_b.TabIndex = 314
        Me.txtWaterTon_b.Text = ""
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(26, 186)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 18)
        Me.Label21.TabIndex = 313
        Me.Label21.Text = "相应排水量"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCargoTons_e
        '
        Me.txtCargoTons_e.Location = New System.Drawing.Point(168, 432)
        Me.txtCargoTons_e.MaxLength = 20
        Me.txtCargoTons_e.Name = "txtCargoTons_e"
        Me.txtCargoTons_e.Size = New System.Drawing.Size(64, 21)
        Me.txtCargoTons_e.TabIndex = 333
        Me.txtCargoTons_e.Text = ""
        '
        'txtCargoTons_b
        '
        Me.txtCargoTons_b.Location = New System.Drawing.Point(102, 432)
        Me.txtCargoTons_b.MaxLength = 20
        Me.txtCargoTons_b.Name = "txtCargoTons_b"
        Me.txtCargoTons_b.Size = New System.Drawing.Size(64, 21)
        Me.txtCargoTons_b.TabIndex = 332
        Me.txtCargoTons_b.Text = ""
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(28, 434)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 18)
        Me.Label17.TabIndex = 331
        Me.Label17.Text = "货物重量"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotal_e
        '
        Me.txtTotal_e.Location = New System.Drawing.Point(168, 410)
        Me.txtTotal_e.MaxLength = 20
        Me.txtTotal_e.Name = "txtTotal_e"
        Me.txtTotal_e.Size = New System.Drawing.Size(64, 21)
        Me.txtTotal_e.TabIndex = 330
        Me.txtTotal_e.Text = ""
        '
        'txtTotal_b
        '
        Me.txtTotal_b.Location = New System.Drawing.Point(102, 410)
        Me.txtTotal_b.MaxLength = 20
        Me.txtTotal_b.Name = "txtTotal_b"
        Me.txtTotal_b.Size = New System.Drawing.Size(64, 21)
        Me.txtTotal_b.TabIndex = 329
        Me.txtTotal_b.Text = ""
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(28, 412)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 18)
        Me.Label18.TabIndex = 328
        Me.Label18.Text = "小计"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFuel_e
        '
        Me.txtFuel_e.Location = New System.Drawing.Point(168, 272)
        Me.txtFuel_e.MaxLength = 20
        Me.txtFuel_e.Name = "txtFuel_e"
        Me.txtFuel_e.Size = New System.Drawing.Size(64, 21)
        Me.txtFuel_e.TabIndex = 336
        Me.txtFuel_e.Text = ""
        '
        'txtFuel_b
        '
        Me.txtFuel_b.Location = New System.Drawing.Point(102, 272)
        Me.txtFuel_b.MaxLength = 20
        Me.txtFuel_b.Name = "txtFuel_b"
        Me.txtFuel_b.Size = New System.Drawing.Size(64, 21)
        Me.txtFuel_b.TabIndex = 335
        Me.txtFuel_b.Text = ""
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(38, 270)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 30)
        Me.Label22.TabIndex = 334
        Me.Label22.Text = "船用物料重量燃油"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(378, 446)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 339
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(310, 446)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 338
        Me.btSave.Text = "确认"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(242, 446)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(65, 24)
        Me.btAdd.TabIndex = 337
        Me.btAdd.Text = "清空"
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(182, 229)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 18)
        Me.Label23.TabIndex = 340
        Me.Label23.Text = "初次:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(282, 400)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 18)
        Me.Label24.TabIndex = 341
        Me.Label24.Text = "公吨"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmCargoWaterResult_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(444, 477)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label24, Me.Label23, Me.btQuit, Me.btSave, Me.btAdd, Me.txtFuel_e, Me.txtFuel_b, Me.Label22, Me.txtCargoTons_e, Me.txtCargoTons_b, Me.Label17, Me.txtTotal_e, Me.txtTotal_b, Me.Label18, Me.txtWaterTonDesityRevise_e, Me.txtWaterTonDesityRevise_b, Me.Label19, Me.txtWaterTonLeanRevise_e, Me.txtWaterTonLeanRevise_b, Me.Label20, Me.txtWaterTon_e, Me.txtWaterTon_b, Me.Label21, Me.txtOther_e, Me.txtOther_b, Me.Label11, Me.txtWaterTonEmpty_e, Me.txtWaterTonEmpty_b, Me.Label12, Me.txtConstantNum_e, Me.txtConstantNum_b, Me.Label13, Me.txtBallastWater_e, Me.txtBallastWater_b, Me.Label14, Me.txtWater_e, Me.txtWater_b, Me.Label15, Me.Label16, Me.txtReviseWrap_e, Me.txtReviseWrap_b, Me.Label10, Me.txtShipMidDepth_e, Me.txtShipMidDepth_b, Me.Label9, Me.txtShipTailDepth_e, Me.txtShipTailDepth_b, Me.Label6, Me.txtShipHeadDepth_e, Me.txtShipHeadDepth_b, Me.Label5, Me.txtDensity_e, Me.txtDensity_b, Me.Label3, Me.Label1, Me.dtpTimeEnd, Me.Label8, Me.dtpTimeBegin, Me.Label7, Me.txtWorker, Me.Label4, Me.txtConsign, Me.Label2, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargoWaterResult_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "散杂货水尺计重信息 增加"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()

    Private Sub FrmCargoWater_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String

        sqlstr = "select * from CARGO_WATER where CARGO_WATER_ID =" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        dtpTimeBegin.CustomFormat = "yyyy'-'MM'-'dd"
        dtpTimeEnd.CustomFormat = "yyyy'-'MM'-'dd"
        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("CARGO_WATER_ID")
            txtConsign.Text = ds.Tables(0).Rows(0).Item("CONSIGN")
            txtWorker.Text = ds.Tables(0).Rows(0).Item("WORK_NO")
            dtpTimeBegin.Value = ds.Tables(0).Rows(0).Item("TIME_FROM")
            dtpTimeEnd.Value = ds.Tables(0).Rows(0).Item("TIME_TO")

            txtBallastWater_b.Text = ds.Tables(0).Rows(0).Item("S_BALLASTING_BEGIN")
            txtBallastWater_e.Text = ds.Tables(0).Rows(0).Item("S_BALLASTING_END")
            txtCargoTons_b.Text = ds.Tables(0).Rows(0).Item("TONS_BEGIN")
            txtCargoTons_e.Text = ds.Tables(0).Rows(0).Item("TONS_END")

            txtConstantNum_b.Text = ds.Tables(0).Rows(0).Item("S_CONSTANT_BEGIN")
            txtConstantNum_e.Text = ds.Tables(0).Rows(0).Item("S_CONSTANT_END")
            txtDensity_b.Text = ds.Tables(0).Rows(0).Item("DENSITY_BEGIN")
            txtDensity_e.Text = ds.Tables(0).Rows(0).Item("DENSITY_END")

            txtFuel_b.Text = ds.Tables(0).Rows(0).Item("S_FUEL_BEGIN")
            txtFuel_e.Text = ds.Tables(0).Rows(0).Item("S_FUEL_END")
            txtOther_b.Text = ds.Tables(0).Rows(0).Item("S_OTHER_BEGIN")
            txtOther_e.Text = ds.Tables(0).Rows(0).Item("S_OTHER_END")
            txtReviseWrap_b.Text = ds.Tables(0).Rows(0).Item("D_REVISE_BEGIN")
            txtReviseWrap_e.Text = ds.Tables(0).Rows(0).Item("D_REVISE_END")

            txtShipHeadDepth_b.Text = ds.Tables(0).Rows(0).Item("D_PROW_BEGIN")
            txtShipHeadDepth_e.Text = ds.Tables(0).Rows(0).Item("D_PROW_END")
            txtShipMidDepth_b.Text = ds.Tables(0).Rows(0).Item("D_MIDDLE_BEGIN")
            txtShipMidDepth_e.Text = ds.Tables(0).Rows(0).Item("D_MIDDLE_END")
            txtShipTailDepth_b.Text = ds.Tables(0).Rows(0).Item("D_BUTTOCK_BEGIN")
            txtShipTailDepth_e.Text = ds.Tables(0).Rows(0).Item("D_BUTTOCK_END")

            txtTotal_b.Text = ds.Tables(0).Rows(0).Item("TOTAL_BEGIN")
            txtTotal_e.Text = ds.Tables(0).Rows(0).Item("TOTAL_END")
            txtWater_b.Text = ds.Tables(0).Rows(0).Item("S_WATER_BEGIN")
            txtWater_e.Text = ds.Tables(0).Rows(0).Item("S_WATER_END")
            txtWaterTon_b.Text = ds.Tables(0).Rows(0).Item("T_BEGIN")
            txtWaterTon_e.Text = ds.Tables(0).Rows(0).Item("T_END")
            txtWaterTonDesityRevise_b.Text = ds.Tables(0).Rows(0).Item("T_DENSITY_BEGIN")
            txtWaterTonDesityRevise_e.Text = ds.Tables(0).Rows(0).Item("T_DENSITY_END")
            txtWaterTonEmpty_b.Text = ds.Tables(0).Rows(0).Item("S_EMPTY_BEGIN")
            txtWaterTonEmpty_e.Text = ds.Tables(0).Rows(0).Item("S_EMPTY_END")
            txtWaterTonLeanRevise_b.Text = ds.Tables(0).Rows(0).Item("T_REVISE_BEGIN")
            txtWaterTonLeanRevise_e.Text = ds.Tables(0).Rows(0).Item("T_REVISE_END")
        End If
        'MessageBox.Show(txtWorker.Focus())
        'MessageBox.Show(txtWorker.Focused)
        MessageBox.Show(btQuit.Focus())
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim sqlExist As String
        sqlExist = "select * from CARGO_WATER where SHIP_ID = '" & Ship_ID & "'"
        Try
            If Trim(txtWorker.Text) <> "" Then
                Dim row As DataRow
                row = ds.Tables(0).NewRow()

                row.Item("CONSIGN") = Trim(txtConsign.Text)
                row.Item("WORK_NO") = Trim(txtWorker.Text)
                row.Item("TIME_FROM") = dtpTimeBegin.Value
                row.Item("TIME_TO") = dtpTimeEnd.Value
                row.Item("SHIP_ID") = Ship_ID
                row.Item("USER_NAME") = G_User

                If Trim(txtBallastWater_b.Text) <> "" Then      '压舱水(初次)
                    If IsNumeric(Trim(txtBallastWater_b.Text)) Then
                        row.Item("S_BALLASTING_BEGIN") = Trim(txtBallastWater_b.Text)
                    Else
                        MessageBox.Show("压舱水应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtBallastWater_e.Text) <> "" Then
                    If IsNumeric(Trim(txtBallastWater_e.Text)) Then
                        row.Item("S_BALLASTING_END") = Trim(txtBallastWater_e.Text)
                    Else
                        MessageBox.Show("压舱水应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtCargoTons_b.Text) <> "" Then     '货物重量(初次)
                    If IsNumeric(Trim(txtCargoTons_b.Text)) Then
                        row.Item("TONS_BEGIN") = Trim(txtCargoTons_b.Text)
                    Else
                        MessageBox.Show("货物重量应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtCargoTons_e.Text) <> "" Then
                    If IsNumeric(Trim(txtCargoTons_e.Text)) Then
                        row.Item("TONS_END") = Trim(txtCargoTons_e.Text)
                    Else
                        MessageBox.Show("货物重量应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtConstantNum_b.Text) <> "" Then       '常数(初次)
                    If IsNumeric(Trim(txtConstantNum_b.Text)) Then
                        row.Item("S_CONSTANT_BEGIN") = Trim(txtConstantNum_b.Text)
                    Else
                        MessageBox.Show("常数应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtConstantNum_e.Text) <> "" Then
                    If IsNumeric(Trim(txtConstantNum_e.Text)) Then
                        row.Item("S_CONSTANT_END") = Trim(txtConstantNum_e.Text)
                    Else
                        MessageBox.Show("常数应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtDensity_b.Text) <> "" Then       '港深密度(初次)
                    If IsNumeric(Trim(txtDensity_b.Text)) Then
                        row.Item("DENSITY_BEGIN") = Trim(txtDensity_b.Text)
                    Else
                        MessageBox.Show("港深密度应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtDensity_e.Text) <> "" Then
                    If IsNumeric(Trim(txtDensity_e.Text)) Then
                        row.Item("DENSITY_END") = Trim(txtDensity_e.Text)
                    Else
                        MessageBox.Show("港深密度应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtFuel_b.Text) <> "" Then      '船用物料重量燃油(初次)
                    If IsNumeric(Trim(txtFuel_b.Text)) Then
                        row.Item("S_FUEL_BEGIN") = Trim(txtFuel_b.Text)
                    Else
                        MessageBox.Show("船用物料重量燃油应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtFuel_e.Text) <> "" Then
                    If IsNumeric(Trim(txtFuel_e.Text)) Then
                        row.Item("S_FUEL_END") = Trim(txtFuel_e.Text)
                    Else
                        MessageBox.Show("船用物料重量燃油应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtOther_b.Text) <> "" Then     '其他(初次)
                    If IsNumeric(Trim(txtOther_b.Text)) Then
                        row.Item("S_OTHER_BEGIN") = Trim(txtOther_b.Text)
                    Else
                        MessageBox.Show("其他应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtOther_e.Text) <> "" Then
                    If IsNumeric(Trim(txtOther_e.Text)) Then
                        row.Item("S_OTHER_END") = Trim(txtOther_e.Text)
                    Else
                        MessageBox.Show("其他应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtReviseWrap_b.Text) <> "" Then    '吃水拱陷校正(初次)
                    If IsNumeric(Trim(txtReviseWrap_b.Text)) Then
                        row.Item("D_REVISE_BEGIN") = Trim(txtReviseWrap_b.Text)
                    Else
                        MessageBox.Show("吃水拱陷校正应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtReviseWrap_e.Text) <> "" Then
                    If IsNumeric(Trim(txtReviseWrap_e.Text)) Then
                        row.Item("D_REVISE_END") = Trim(txtReviseWrap_e.Text)
                    Else
                        MessageBox.Show("吃水拱陷校正应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtShipHeadDepth_b.Text) <> "" Then     '船首吃水(初次)
                    If IsNumeric(Trim(txtShipHeadDepth_b.Text)) Then
                        row.Item("D_PROW_BEGIN") = Trim(txtShipHeadDepth_b.Text)
                    Else
                        MessageBox.Show("船首吃水应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtShipHeadDepth_e.Text) <> "" Then
                    If IsNumeric(Trim(txtShipHeadDepth_e.Text)) Then
                        row.Item("D_PROW_END") = Trim(txtShipHeadDepth_e.Text)
                    Else
                        MessageBox.Show("船首吃水应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtShipMidDepth_b.Text) <> "" Then      '船中吃水(初次)
                    If IsNumeric(Trim(txtShipMidDepth_b.Text)) Then
                        row.Item("D_MIDDLE_BEGIN") = Trim(txtShipMidDepth_b.Text)
                    Else
                        MessageBox.Show("船中吃水应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtShipMidDepth_e.Text) <> "" Then
                    If IsNumeric(Trim(txtShipMidDepth_e.Text)) Then
                        row.Item("D_MIDDLE_END") = Trim(txtShipMidDepth_e.Text)
                    Else
                        MessageBox.Show("船中吃水应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtShipTailDepth_b.Text) <> "" Then     '船尾吃水(初次)
                    If IsNumeric(Trim(txtShipTailDepth_b.Text)) Then
                        row.Item("D_BUTTOCK_BEGIN") = Trim(txtShipTailDepth_b.Text)
                    Else
                        MessageBox.Show("船尾吃水应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtShipTailDepth_e.Text) <> "" Then
                    If IsNumeric(Trim(txtShipTailDepth_e.Text)) Then
                        row.Item("D_BUTTOCK_END") = Trim(txtShipTailDepth_e.Text)
                    Else
                        MessageBox.Show("船尾吃水应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtTotal_b.Text) <> "" Then     '小计(初次)
                    If IsNumeric(Trim(txtTotal_b.Text)) Then
                        row.Item("TOTAL_BEGIN") = Trim(txtTotal_b.Text)
                    Else
                        MessageBox.Show("小计应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtTotal_e.Text) <> "" Then
                    If IsNumeric(Trim(txtTotal_e.Text)) Then
                        row.Item("TOTAL_END") = Trim(txtTotal_e.Text)
                    Else
                        MessageBox.Show("小计应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtWater_b.Text) <> "" Then     '淡水(初次)
                    If IsNumeric(Trim(txtWater_b.Text)) Then
                        row.Item("S_WATER_BEGIN") = Trim(txtWater_b.Text)
                    Else
                        MessageBox.Show("淡水应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtWater_e.Text) <> "" Then
                    If IsNumeric(Trim(txtWater_e.Text)) Then
                        row.Item("S_WATER_END") = Trim(txtWater_e.Text)
                    Else
                        MessageBox.Show("淡水应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtWaterTon_b.Text) <> "" Then      '相应排水量(初次)
                    If IsNumeric(Trim(txtWaterTon_b.Text)) Then
                        row.Item("T_BEGIN") = Trim(txtWaterTon_b.Text)
                    Else
                        MessageBox.Show("相应排水量应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtWaterTon_e.Text) <> "" Then
                    If IsNumeric(Trim(txtWaterTon_e.Text)) Then
                        row.Item("T_END") = Trim(txtWaterTon_e.Text)
                    Else
                        MessageBox.Show("相应排水量应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtWaterTonDesityRevise_b.Text) <> "" Then      '港水密度校正的排水量(初次)
                    If IsNumeric(Trim(txtWaterTonDesityRevise_b.Text)) Then
                        row.Item("T_DENSITY_BEGIN") = Trim(txtWaterTonDesityRevise_b.Text)
                    Else
                        MessageBox.Show("港水密度校正的排水量应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtWaterTonDesityRevise_e.Text) <> "" Then
                    If IsNumeric(Trim(txtWaterTonDesityRevise_e.Text)) Then
                        row.Item("T_DENSITY_END") = Trim(txtWaterTonDesityRevise_e.Text)
                    Else
                        MessageBox.Show("港水密度校正的排水量应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtWaterTonEmpty_b.Text) <> "" Then      '空船排水量(初次)
                    If IsNumeric(Trim(txtWaterTonEmpty_b.Text)) Then
                        row.Item("S_EMPTY_BEGIN") = Trim(txtWaterTonEmpty_b.Text)
                    Else
                        MessageBox.Show("空船排水量应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtWaterTonEmpty_e.Text) <> "" Then
                    If IsNumeric(Trim(txtWaterTonEmpty_e.Text)) Then
                        row.Item("S_EMPTY_END") = Trim(txtWaterTonEmpty_e.Text)
                    Else
                        MessageBox.Show("空船排水量应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtWaterTonLeanRevise_b.Text) <> "" Then      '纵倾校正后的排水量(初次)
                    If IsNumeric(Trim(txtWaterTonLeanRevise_b.Text)) Then
                        row.Item("T_REVISE_BEGIN") = Trim(txtWaterTonLeanRevise_b.Text)
                    Else
                        MessageBox.Show("纵倾校正后的排水量应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If
                If Trim(txtWaterTonLeanRevise_e.Text) <> "" Then
                    If IsNumeric(Trim(txtWaterTonLeanRevise_e.Text)) Then
                        row.Item("T_REVISE_END") = Trim(txtWaterTonLeanRevise_e.Text)
                    Else
                        MessageBox.Show("纵倾校正后的排水量应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else    '此列留空
                End If

                If Filldata(sqlExist).Count = 0 Then
                    ds.Tables(0).Rows.Add(row)
                    sqlda.Update(ds)
                    Me.Close()
                Else
                    MessageBox.Show("同一船次水尺记录不能重复。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("测试人员不能为空。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        Me.txtConsign.Clear()
        Me.txtWorker.Clear()
        Me.txtBallastWater_b.Clear()
        Me.txtBallastWater_e.Clear()
        Me.txtCargoTons_b.Clear()
        Me.txtCargoTons_e.Clear()
        Me.txtConstantNum_b.Clear()
        Me.txtConstantNum_e.Clear()
        Me.txtDensity_b.Clear()
        Me.txtDensity_e.Clear()
        Me.txtFuel_b.Clear()
        Me.txtFuel_e.Clear()
        Me.txtOther_b.Clear()
        Me.txtOther_e.Clear()
        Me.txtReviseWrap_b.Clear()
        Me.txtReviseWrap_e.Clear()
        Me.txtShipHeadDepth_b.Clear()
        Me.txtShipHeadDepth_e.Clear()
        Me.txtShipMidDepth_b.Clear()
        Me.txtShipMidDepth_e.Clear()
        Me.txtShipTailDepth_b.Clear()
        Me.txtShipTailDepth_e.Clear()
        Me.txtTotal_b.Clear()
        Me.txtTotal_e.Clear()
        Me.txtWater_b.Clear()
        Me.txtWater_e.Clear()
        Me.txtWaterTon_b.Clear()
        Me.txtWaterTon_e.Clear()
        Me.txtWaterTonDesityRevise_b.Clear()
        Me.txtWaterTonDesityRevise_e.Clear()
        Me.txtWaterTonEmpty_b.Clear()
        Me.txtWaterTonEmpty_e.Clear()
        Me.txtWaterTonLeanRevise_b.Clear()
        Me.txtWaterTonLeanRevise_e.Clear()
        Me.dtpTimeBegin.Value = Now
        Me.dtpTimeEnd.Value = Now
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub FrmCargoWater_Add_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ControlChars.Lf And Me.txtConsign.Focused Then
            MessageBox.Show(txtConsign.Focused)
            MessageBox.Show(Me.txtWorker.Focus())
        End If
    End Sub

    Private Sub FrmCargoWater_Add_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.Enter And Me.txtConsign.Focused Then
            MessageBox.Show(txtConsign.Focused)
            MessageBox.Show(Me.txtWorker.Focus())
        End If
    End Sub

    Private Sub FrmCargoWater_Add_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        If Me.txtConsign.Focused Then
            MessageBox.Show(txtConsign.Focused)
            MessageBox.Show(Me.txtWorker.Focus())
        End If
    End Sub

End Class
