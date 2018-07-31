Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FrmAttemper_Query
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
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtREMARK As System.Windows.Forms.TextBox
    Friend WithEvents DTPWATCHDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbWORK_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents CmbWeather As System.Windows.Forms.ComboBox
    Friend WithEvents TxtITEM As System.Windows.Forms.TextBox
    Friend WithEvents CmbWATCH_DIRECTOR As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDIRECTOR As System.Windows.Forms.ComboBox
    Friend WithEvents TxtWATCH_ID As System.Windows.Forms.TextBox
    Friend WithEvents TxtUSER_NAME As System.Windows.Forms.TextBox
    Friend WithEvents CmbDAYNIGHTMARK As System.Windows.Forms.ComboBox
    Friend WithEvents GB1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TxtLock_Mark As System.Windows.Forms.TextBox
    Friend WithEvents CmbMARK_COMPLETE As System.Windows.Forms.ComboBox
    Friend WithEvents TxtTALLY_CARGO As System.Windows.Forms.TextBox
    Friend WithEvents TxtTOTAL_NUM As System.Windows.Forms.TextBox
    Friend WithEvents TxtREMAIN As System.Windows.Forms.TextBox
    Friend WithEvents TxtBERTHNO As System.Windows.Forms.TextBox
    Friend WithEvents TxtCOMPANY_REMARK As System.Windows.Forms.TextBox
    Friend WithEvents TxtDEPT_REMARK As System.Windows.Forms.TextBox
    Friend WithEvents GB2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbNATIONALITY_CODE As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCODE_GOODS As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPIECE As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPIECE As System.Windows.Forms.TextBox
    Friend WithEvents TxtTONS As System.Windows.Forms.TextBox
    Friend WithEvents TxtTICKET As System.Windows.Forms.TextBox
    Friend WithEvents CmbLOAD_UNLOAD_PORT As System.Windows.Forms.ComboBox
    Friend WithEvents CmbINOUTPORT As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDEPT_CODE As System.Windows.Forms.ComboBox
    Friend WithEvents BtnCLERK As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TxtREMAIN_TON As System.Windows.Forms.TextBox
    Friend WithEvents TxtTOTAL_NUM_TON As System.Windows.Forms.TextBox
    Friend WithEvents TxtTALLY_CARGO_TON As System.Windows.Forms.TextBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents tbctrl As System.Windows.Forms.TabControl
    Friend WithEvents C1DBGV As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents C1info As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1_1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1_2 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1_3 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1_4 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1_5 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmAttemper_Query))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Dim GridLines2 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Dim GridLines3 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Dim GridLines4 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Dim GridLines5 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Dim GridLines6 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Dim GridLines7 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Dim GridLines8 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Me.GB = New System.Windows.Forms.GroupBox
        Me.CmbDEPT_CODE = New System.Windows.Forms.ComboBox
        Me.DTPWATCHDATE = New System.Windows.Forms.DateTimePicker
        Me.CmbDAYNIGHTMARK = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.TxtITEM = New System.Windows.Forms.TextBox
        Me.TxtREMARK = New System.Windows.Forms.TextBox
        Me.CmbWATCH_DIRECTOR = New System.Windows.Forms.ComboBox
        Me.CmbDIRECTOR = New System.Windows.Forms.ComboBox
        Me.CmbWORK_TYPE = New System.Windows.Forms.ComboBox
        Me.TxtWATCH_ID = New System.Windows.Forms.TextBox
        Me.CmbWeather = New System.Windows.Forms.ComboBox
        Me.TxtUSER_NAME = New System.Windows.Forms.TextBox
        Me.TxtLock_Mark = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.GB2 = New System.Windows.Forms.GroupBox
        Me.C1DBGV = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.GB1 = New System.Windows.Forms.GroupBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.TxtREMAIN_TON = New System.Windows.Forms.TextBox
        Me.TxtTOTAL_NUM_TON = New System.Windows.Forms.TextBox
        Me.TxtTALLY_CARGO_TON = New System.Windows.Forms.TextBox
        Me.TxtTALLY_CARGO = New System.Windows.Forms.TextBox
        Me.TxtCOMPANY_REMARK = New System.Windows.Forms.TextBox
        Me.TxtDEPT_REMARK = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.TxtTOTAL_NUM = New System.Windows.Forms.TextBox
        Me.TxtREMAIN = New System.Windows.Forms.TextBox
        Me.CmbMARK_COMPLETE = New System.Windows.Forms.ComboBox
        Me.TxtBERTHNO = New System.Windows.Forms.TextBox
        Me.CmbNATIONALITY_CODE = New System.Windows.Forms.ComboBox
        Me.CmbCODE_GOODS = New System.Windows.Forms.ComboBox
        Me.TxtPIECE = New System.Windows.Forms.TextBox
        Me.TxtTONS = New System.Windows.Forms.TextBox
        Me.TxtTICKET = New System.Windows.Forms.TextBox
        Me.CmbINOUTPORT = New System.Windows.Forms.ComboBox
        Me.CmbLOAD_UNLOAD_PORT = New System.Windows.Forms.ComboBox
        Me.CmbPIECE = New System.Windows.Forms.ComboBox
        Me.BtnCLERK = New System.Windows.Forms.Button
        Me.tbctrl = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.C1info = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1_1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1_2 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1_3 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1_4 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1_5 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.GB.SuspendLayout()
        Me.GB2.SuspendLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB1.SuspendLayout()
        Me.tbctrl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.C1info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1_5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB
        '
        Me.GB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB.Controls.Add(Me.CmbDEPT_CODE)
        Me.GB.Controls.Add(Me.DTPWATCHDATE)
        Me.GB.Controls.Add(Me.CmbDAYNIGHTMARK)
        Me.GB.Controls.Add(Me.Label1)
        Me.GB.Controls.Add(Me.Label2)
        Me.GB.Controls.Add(Me.Label4)
        Me.GB.Controls.Add(Me.Label7)
        Me.GB.Controls.Add(Me.Label15)
        Me.GB.Controls.Add(Me.Label16)
        Me.GB.Controls.Add(Me.Label19)
        Me.GB.Controls.Add(Me.Label20)
        Me.GB.Controls.Add(Me.TxtITEM)
        Me.GB.Controls.Add(Me.TxtREMARK)
        Me.GB.Controls.Add(Me.CmbWATCH_DIRECTOR)
        Me.GB.Controls.Add(Me.CmbDIRECTOR)
        Me.GB.Controls.Add(Me.CmbWORK_TYPE)
        Me.GB.Controls.Add(Me.TxtWATCH_ID)
        Me.GB.Controls.Add(Me.CmbWeather)
        Me.GB.Controls.Add(Me.TxtUSER_NAME)
        Me.GB.Controls.Add(Me.TxtLock_Mark)
        Me.GB.Location = New System.Drawing.Point(-1, 0)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(898, 114)
        Me.GB.TabIndex = 1
        Me.GB.TabStop = False
        Me.GB.Text = "值班记录"
        '
        'CmbDEPT_CODE
        '
        Me.CmbDEPT_CODE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDEPT_CODE.Enabled = False
        Me.CmbDEPT_CODE.Location = New System.Drawing.Point(80, 142)
        Me.CmbDEPT_CODE.Name = "CmbDEPT_CODE"
        Me.CmbDEPT_CODE.Size = New System.Drawing.Size(90, 20)
        Me.CmbDEPT_CODE.TabIndex = 36
        Me.CmbDEPT_CODE.Visible = False
        '
        'DTPWATCHDATE
        '
        Me.DTPWATCHDATE.CustomFormat = "yyyy/MM/dd"
        Me.DTPWATCHDATE.Enabled = False
        Me.DTPWATCHDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPWATCHDATE.Location = New System.Drawing.Point(46, 13)
        Me.DTPWATCHDATE.Name = "DTPWATCHDATE"
        Me.DTPWATCHDATE.Size = New System.Drawing.Size(96, 21)
        Me.DTPWATCHDATE.TabIndex = 0
        '
        'CmbDAYNIGHTMARK
        '
        Me.CmbDAYNIGHTMARK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbDAYNIGHTMARK.Enabled = False
        Me.CmbDAYNIGHTMARK.Location = New System.Drawing.Point(478, 14)
        Me.CmbDAYNIGHTMARK.Name = "CmbDAYNIGHTMARK"
        Me.CmbDAYNIGHTMARK.Size = New System.Drawing.Size(84, 20)
        Me.CmbDAYNIGHTMARK.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "日期"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(294, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "班次"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(440, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "班别"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 36)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "交接班事项"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(582, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 20)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "值班主任"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(746, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 20)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "接班主任"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(6, 76)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 36)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "备注"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(154, 14)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(38, 20)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "天气"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtITEM
        '
        Me.TxtITEM.Location = New System.Drawing.Point(82, 36)
        Me.TxtITEM.MaxLength = 200
        Me.TxtITEM.Multiline = True
        Me.TxtITEM.Name = "TxtITEM"
        Me.TxtITEM.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtITEM.Size = New System.Drawing.Size(814, 37)
        Me.TxtITEM.TabIndex = 6
        Me.TxtITEM.Text = ""
        '
        'TxtREMARK
        '
        Me.TxtREMARK.Location = New System.Drawing.Point(82, 74)
        Me.TxtREMARK.MaxLength = 100
        Me.TxtREMARK.Multiline = True
        Me.TxtREMARK.Name = "TxtREMARK"
        Me.TxtREMARK.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtREMARK.Size = New System.Drawing.Size(814, 37)
        Me.TxtREMARK.TabIndex = 7
        Me.TxtREMARK.Text = ""
        '
        'CmbWATCH_DIRECTOR
        '
        Me.CmbWATCH_DIRECTOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbWATCH_DIRECTOR.Enabled = False
        Me.CmbWATCH_DIRECTOR.Location = New System.Drawing.Point(644, 14)
        Me.CmbWATCH_DIRECTOR.Name = "CmbWATCH_DIRECTOR"
        Me.CmbWATCH_DIRECTOR.Size = New System.Drawing.Size(84, 20)
        Me.CmbWATCH_DIRECTOR.TabIndex = 4
        '
        'CmbDIRECTOR
        '
        Me.CmbDIRECTOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbDIRECTOR.Enabled = False
        Me.CmbDIRECTOR.Location = New System.Drawing.Point(804, 14)
        Me.CmbDIRECTOR.Name = "CmbDIRECTOR"
        Me.CmbDIRECTOR.Size = New System.Drawing.Size(84, 20)
        Me.CmbDIRECTOR.TabIndex = 5
        '
        'CmbWORK_TYPE
        '
        Me.CmbWORK_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbWORK_TYPE.Enabled = False
        Me.CmbWORK_TYPE.Location = New System.Drawing.Point(334, 14)
        Me.CmbWORK_TYPE.Name = "CmbWORK_TYPE"
        Me.CmbWORK_TYPE.Size = New System.Drawing.Size(84, 20)
        Me.CmbWORK_TYPE.TabIndex = 2
        '
        'TxtWATCH_ID
        '
        Me.TxtWATCH_ID.Location = New System.Drawing.Point(8, 142)
        Me.TxtWATCH_ID.MaxLength = 4
        Me.TxtWATCH_ID.Name = "TxtWATCH_ID"
        Me.TxtWATCH_ID.ReadOnly = True
        Me.TxtWATCH_ID.Size = New System.Drawing.Size(22, 21)
        Me.TxtWATCH_ID.TabIndex = 34
        Me.TxtWATCH_ID.TabStop = False
        Me.TxtWATCH_ID.Text = ""
        '
        'CmbWeather
        '
        Me.CmbWeather.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbWeather.Enabled = False
        Me.CmbWeather.Location = New System.Drawing.Point(196, 14)
        Me.CmbWeather.Name = "CmbWeather"
        Me.CmbWeather.Size = New System.Drawing.Size(84, 20)
        Me.CmbWeather.TabIndex = 1
        '
        'TxtUSER_NAME
        '
        Me.TxtUSER_NAME.Location = New System.Drawing.Point(32, 142)
        Me.TxtUSER_NAME.MaxLength = 4
        Me.TxtUSER_NAME.Name = "TxtUSER_NAME"
        Me.TxtUSER_NAME.ReadOnly = True
        Me.TxtUSER_NAME.Size = New System.Drawing.Size(22, 21)
        Me.TxtUSER_NAME.TabIndex = 35
        Me.TxtUSER_NAME.TabStop = False
        Me.TxtUSER_NAME.Text = ""
        Me.TxtUSER_NAME.Visible = False
        '
        'TxtLock_Mark
        '
        Me.TxtLock_Mark.Location = New System.Drawing.Point(56, 142)
        Me.TxtLock_Mark.MaxLength = 4
        Me.TxtLock_Mark.Name = "TxtLock_Mark"
        Me.TxtLock_Mark.ReadOnly = True
        Me.TxtLock_Mark.Size = New System.Drawing.Size(22, 21)
        Me.TxtLock_Mark.TabIndex = 35
        Me.TxtLock_Mark.TabStop = False
        Me.TxtLock_Mark.Text = ""
        Me.TxtLock_Mark.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(418, 448)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(65, 24)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "返 回"
        '
        'GB2
        '
        Me.GB2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB2.Controls.Add(Me.C1DBGV)
        Me.GB2.Location = New System.Drawing.Point(678, 2)
        Me.GB2.Name = "GB2"
        Me.GB2.Size = New System.Drawing.Size(210, 302)
        Me.GB2.TabIndex = 2
        Me.GB2.TabStop = False
        Me.GB2.Text = "船派工信息"
        '
        'C1DBGV
        '
        Me.C1DBGV.AllowFilter = True
        Me.C1DBGV.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1DBGV.AllowSort = True
        Me.C1DBGV.CaptionHeight = 18
        Me.C1DBGV.CollapseColor = System.Drawing.Color.Black
        Me.C1DBGV.DataChanged = False
        Me.C1DBGV.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBGV.ExpandColor = System.Drawing.Color.Black
        Me.C1DBGV.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGV.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBGV.Location = New System.Drawing.Point(4, 18)
        Me.C1DBGV.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBGV.Name = "C1DBGV"
        Me.C1DBGV.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGV.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGV.PreviewInfo.ZoomFactor = 75
        Me.C1DBGV.PrintInfo.ShowOptionsDialog = False
        Me.C1DBGV.RecordSelectorWidth = 16
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBGV.RowDivider = GridLines1
        Me.C1DBGV.RowHeight = 16
        Me.C1DBGV.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBGV.ScrollTips = False
        Me.C1DBGV.Size = New System.Drawing.Size(204, 282)
        Me.C1DBGV.TabIndex = 0
        Me.C1DBGV.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Center;Borde" & _
        "r:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCaptionHeight=""18"" Colu" & _
        "mnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" Def" & _
        "RecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRect>0" & _
        ", 0, 200, 278</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2" & _
        """ me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent" & _
        "=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><Foot" & _
        "erStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" />" & _
        "<HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""Highligh" & _
        "tRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle " & _
        "parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""S" & _
        "tyle11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" " & _
        "me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style paren" & _
        "t="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading""" & _
        " me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me" & _
        "=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""" & _
        "Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""" & _
        "EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""Reco" & _
        "rdSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me" & _
        "=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><La" & _
        "yout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 2" & _
        "00, 278</ClientArea></Blob>"
        '
        'C1DBG
        '
        Me.C1DBG.AllowColMove = False
        Me.C1DBG.AllowDrag = True
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1DBG.AllowSort = True
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.CollapseColor = System.Drawing.Color.Black
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.DataChanged = False
        Me.C1DBG.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBG.ExpandColor = System.Drawing.Color.Black
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.ShowOptionsDialog = False
        Me.C1DBG.RecordSelectorWidth = 16
        GridLines2.Color = System.Drawing.Color.DarkGray
        GridLines2.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG.RowDivider = GridLines2
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG.ScrollTips = False
        Me.C1DBG.Size = New System.Drawing.Size(676, 302)
        Me.C1DBG.TabIndex = 0
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Style11{}Style12{}Style13{}Style5{}Style4{}Style7{}Style6{}EvenRow{Back" & _
        "Color:Aqua;}Selected{ForeColor:HighlightText;BackColor:Highlight;}Heading{Wrap:T" & _
        "rue;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:" & _
        "Center;}Inactive{ForeColor:InactiveCaptionText;BackColor:InactiveCaption;}Filter" & _
        "Bar{}Footer{}Caption{AlignHorz:Center;}Editor{}Normal{}Style27{}Style26{}Highlig" & _
        "htRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}OddRow{}RecordSelecto" & _
        "r{AlignImage:Center;}Style9{}Style8{}Style3{}Style2{}Group{AlignVert:Center;Bord" & _
        "er:None,,0, 0, 0, 0;BackColor:ControlDark;}Style10{AlignHorz:Near;}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView AllowColMove=""False"" Name="""" CaptionHe" & _
        "ight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" MarqueeStyle=""DottedC" & _
        "ellBorder"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" " & _
        "HorizontalScrollGroup=""1""><ClientRect>0, 0, 672, 298</ClientRect><BorderSide>0</" & _
        "BorderSide><CaptionStyle parent=""Heading"" me=""Style10"" /><EditorStyle parent=""Ed" & _
        "itor"" me=""Style2"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle" & _
        " parent=""FilterBar"" me=""Style27"" /><FooterStyle parent=""Footer"" me=""Style4"" /><G" & _
        "roupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style" & _
        "3"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle paren" & _
        "t=""Inactive"" me=""Style6"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSel" & _
        "ectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selecte" & _
        "d"" me=""Style5"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.Merg" & _
        "eView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal" & _
        """ me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" m" & _
        "e=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=" & _
        """Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Hig" & _
        "hlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""Od" & _
        "dRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=" & _
        """FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</" & _
        "vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16" & _
        "</DefaultRecSelWidth><ClientArea>0, 0, 672, 298</ClientArea></Blob>"
        '
        'GB1
        '
        Me.GB1.Controls.Add(Me.Label21)
        Me.GB1.Controls.Add(Me.Label24)
        Me.GB1.Controls.Add(Me.Label25)
        Me.GB1.Controls.Add(Me.TxtREMAIN_TON)
        Me.GB1.Controls.Add(Me.TxtTOTAL_NUM_TON)
        Me.GB1.Controls.Add(Me.TxtTALLY_CARGO_TON)
        Me.GB1.Controls.Add(Me.TxtTALLY_CARGO)
        Me.GB1.Controls.Add(Me.TxtCOMPANY_REMARK)
        Me.GB1.Controls.Add(Me.TxtDEPT_REMARK)
        Me.GB1.Controls.Add(Me.Label3)
        Me.GB1.Controls.Add(Me.Label5)
        Me.GB1.Controls.Add(Me.Label6)
        Me.GB1.Controls.Add(Me.Label8)
        Me.GB1.Controls.Add(Me.Label9)
        Me.GB1.Controls.Add(Me.Label10)
        Me.GB1.Controls.Add(Me.Label11)
        Me.GB1.Controls.Add(Me.Label12)
        Me.GB1.Controls.Add(Me.Label13)
        Me.GB1.Controls.Add(Me.Label14)
        Me.GB1.Controls.Add(Me.Label17)
        Me.GB1.Controls.Add(Me.Label18)
        Me.GB1.Controls.Add(Me.Label22)
        Me.GB1.Controls.Add(Me.Label23)
        Me.GB1.Controls.Add(Me.TxtTOTAL_NUM)
        Me.GB1.Controls.Add(Me.TxtREMAIN)
        Me.GB1.Controls.Add(Me.CmbMARK_COMPLETE)
        Me.GB1.Controls.Add(Me.TxtBERTHNO)
        Me.GB1.Controls.Add(Me.CmbNATIONALITY_CODE)
        Me.GB1.Controls.Add(Me.CmbCODE_GOODS)
        Me.GB1.Controls.Add(Me.TxtPIECE)
        Me.GB1.Controls.Add(Me.TxtTONS)
        Me.GB1.Controls.Add(Me.TxtTICKET)
        Me.GB1.Controls.Add(Me.CmbINOUTPORT)
        Me.GB1.Controls.Add(Me.CmbLOAD_UNLOAD_PORT)
        Me.GB1.Location = New System.Drawing.Point(44, 448)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(64, 22)
        Me.GB1.TabIndex = 3
        Me.GB1.TabStop = False
        Me.GB1.Text = "单船记录"
        Me.GB1.Visible = False
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(368, 44)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(8, 20)
        Me.Label21.TabIndex = 43
        Me.Label21.Text = "/"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(368, 68)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(8, 20)
        Me.Label24.TabIndex = 44
        Me.Label24.Text = "/"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(368, 20)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(8, 20)
        Me.Label25.TabIndex = 45
        Me.Label25.Text = "/"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtREMAIN_TON
        '
        Me.TxtREMAIN_TON.Location = New System.Drawing.Point(376, 68)
        Me.TxtREMAIN_TON.MaxLength = 9
        Me.TxtREMAIN_TON.Name = "TxtREMAIN_TON"
        Me.TxtREMAIN_TON.Size = New System.Drawing.Size(43, 21)
        Me.TxtREMAIN_TON.TabIndex = 42
        Me.TxtREMAIN_TON.Text = ""
        '
        'TxtTOTAL_NUM_TON
        '
        Me.TxtTOTAL_NUM_TON.Location = New System.Drawing.Point(376, 44)
        Me.TxtTOTAL_NUM_TON.MaxLength = 9
        Me.TxtTOTAL_NUM_TON.Name = "TxtTOTAL_NUM_TON"
        Me.TxtTOTAL_NUM_TON.Size = New System.Drawing.Size(43, 21)
        Me.TxtTOTAL_NUM_TON.TabIndex = 41
        Me.TxtTOTAL_NUM_TON.Text = ""
        '
        'TxtTALLY_CARGO_TON
        '
        Me.TxtTALLY_CARGO_TON.Location = New System.Drawing.Point(376, 20)
        Me.TxtTALLY_CARGO_TON.MaxLength = 9
        Me.TxtTALLY_CARGO_TON.Name = "TxtTALLY_CARGO_TON"
        Me.TxtTALLY_CARGO_TON.Size = New System.Drawing.Size(43, 21)
        Me.TxtTALLY_CARGO_TON.TabIndex = 40
        Me.TxtTALLY_CARGO_TON.Text = ""
        '
        'TxtTALLY_CARGO
        '
        Me.TxtTALLY_CARGO.Location = New System.Drawing.Point(321, 19)
        Me.TxtTALLY_CARGO.Name = "TxtTALLY_CARGO"
        Me.TxtTALLY_CARGO.Size = New System.Drawing.Size(45, 21)
        Me.TxtTALLY_CARGO.TabIndex = 8
        Me.TxtTALLY_CARGO.Text = ""
        '
        'TxtCOMPANY_REMARK
        '
        Me.TxtCOMPANY_REMARK.Location = New System.Drawing.Point(72, 115)
        Me.TxtCOMPANY_REMARK.MaxLength = 200
        Me.TxtCOMPANY_REMARK.Multiline = True
        Me.TxtCOMPANY_REMARK.Name = "TxtCOMPANY_REMARK"
        Me.TxtCOMPANY_REMARK.ReadOnly = True
        Me.TxtCOMPANY_REMARK.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtCOMPANY_REMARK.Size = New System.Drawing.Size(346, 37)
        Me.TxtCOMPANY_REMARK.TabIndex = 12
        Me.TxtCOMPANY_REMARK.Text = ""
        '
        'TxtDEPT_REMARK
        '
        Me.TxtDEPT_REMARK.Location = New System.Drawing.Point(72, 155)
        Me.TxtDEPT_REMARK.MaxLength = 100
        Me.TxtDEPT_REMARK.Multiline = True
        Me.TxtDEPT_REMARK.Name = "TxtDEPT_REMARK"
        Me.TxtDEPT_REMARK.ReadOnly = True
        Me.TxtDEPT_REMARK.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtDEPT_REMARK.Size = New System.Drawing.Size(346, 37)
        Me.TxtDEPT_REMARK.TabIndex = 13
        Me.TxtDEPT_REMARK.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(5, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "泊位号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "票数"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 20)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "装卸港名称"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 20)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "进出口"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(140, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 20)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "货类"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(140, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 20)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "原载件数"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(140, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 20)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "原载吨数"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(140, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 20)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "国籍"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(264, 91)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 20)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "本班完船"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(264, 67)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 20)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "余数"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(264, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 20)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "本班理货"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(264, 43)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 20)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "累计数"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(6, 115)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 36)
        Me.Label22.TabIndex = 31
        Me.Label22.Text = "公司备注"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(6, 155)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(66, 36)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "理货部备注"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTOTAL_NUM
        '
        Me.TxtTOTAL_NUM.Location = New System.Drawing.Point(321, 43)
        Me.TxtTOTAL_NUM.Name = "TxtTOTAL_NUM"
        Me.TxtTOTAL_NUM.Size = New System.Drawing.Size(45, 21)
        Me.TxtTOTAL_NUM.TabIndex = 9
        Me.TxtTOTAL_NUM.Text = ""
        '
        'TxtREMAIN
        '
        Me.TxtREMAIN.Location = New System.Drawing.Point(321, 67)
        Me.TxtREMAIN.Name = "TxtREMAIN"
        Me.TxtREMAIN.Size = New System.Drawing.Size(45, 21)
        Me.TxtREMAIN.TabIndex = 10
        Me.TxtREMAIN.Text = ""
        '
        'CmbMARK_COMPLETE
        '
        Me.CmbMARK_COMPLETE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMARK_COMPLETE.Location = New System.Drawing.Point(321, 91)
        Me.CmbMARK_COMPLETE.Name = "CmbMARK_COMPLETE"
        Me.CmbMARK_COMPLETE.Size = New System.Drawing.Size(97, 20)
        Me.CmbMARK_COMPLETE.TabIndex = 11
        '
        'TxtBERTHNO
        '
        Me.TxtBERTHNO.Location = New System.Drawing.Point(73, 19)
        Me.TxtBERTHNO.MaxLength = 2
        Me.TxtBERTHNO.Name = "TxtBERTHNO"
        Me.TxtBERTHNO.Size = New System.Drawing.Size(65, 21)
        Me.TxtBERTHNO.TabIndex = 0
        Me.TxtBERTHNO.Text = ""
        '
        'CmbNATIONALITY_CODE
        '
        Me.CmbNATIONALITY_CODE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbNATIONALITY_CODE.Location = New System.Drawing.Point(196, 19)
        Me.CmbNATIONALITY_CODE.Name = "CmbNATIONALITY_CODE"
        Me.CmbNATIONALITY_CODE.Size = New System.Drawing.Size(65, 20)
        Me.CmbNATIONALITY_CODE.TabIndex = 4
        '
        'CmbCODE_GOODS
        '
        Me.CmbCODE_GOODS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCODE_GOODS.Location = New System.Drawing.Point(196, 43)
        Me.CmbCODE_GOODS.Name = "CmbCODE_GOODS"
        Me.CmbCODE_GOODS.Size = New System.Drawing.Size(65, 20)
        Me.CmbCODE_GOODS.TabIndex = 5
        '
        'TxtPIECE
        '
        Me.TxtPIECE.Location = New System.Drawing.Point(196, 67)
        Me.TxtPIECE.Name = "TxtPIECE"
        Me.TxtPIECE.Size = New System.Drawing.Size(65, 21)
        Me.TxtPIECE.TabIndex = 6
        Me.TxtPIECE.Text = ""
        '
        'TxtTONS
        '
        Me.TxtTONS.Location = New System.Drawing.Point(196, 91)
        Me.TxtTONS.Name = "TxtTONS"
        Me.TxtTONS.Size = New System.Drawing.Size(65, 21)
        Me.TxtTONS.TabIndex = 7
        Me.TxtTONS.Text = ""
        '
        'TxtTICKET
        '
        Me.TxtTICKET.Location = New System.Drawing.Point(73, 67)
        Me.TxtTICKET.MaxLength = 2
        Me.TxtTICKET.Name = "TxtTICKET"
        Me.TxtTICKET.Size = New System.Drawing.Size(65, 21)
        Me.TxtTICKET.TabIndex = 2
        Me.TxtTICKET.Text = ""
        '
        'CmbINOUTPORT
        '
        Me.CmbINOUTPORT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbINOUTPORT.Location = New System.Drawing.Point(73, 43)
        Me.CmbINOUTPORT.Name = "CmbINOUTPORT"
        Me.CmbINOUTPORT.Size = New System.Drawing.Size(65, 20)
        Me.CmbINOUTPORT.TabIndex = 1
        '
        'CmbLOAD_UNLOAD_PORT
        '
        Me.CmbLOAD_UNLOAD_PORT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbLOAD_UNLOAD_PORT.Location = New System.Drawing.Point(73, 91)
        Me.CmbLOAD_UNLOAD_PORT.Name = "CmbLOAD_UNLOAD_PORT"
        Me.CmbLOAD_UNLOAD_PORT.Size = New System.Drawing.Size(65, 20)
        Me.CmbLOAD_UNLOAD_PORT.TabIndex = 3
        '
        'CmbPIECE
        '
        Me.CmbPIECE.Location = New System.Drawing.Point(174, 68)
        Me.CmbPIECE.Name = "CmbPIECE"
        Me.CmbPIECE.Size = New System.Drawing.Size(98, 20)
        Me.CmbPIECE.TabIndex = 1
        '
        'BtnCLERK
        '
        Me.BtnCLERK.Location = New System.Drawing.Point(126, 446)
        Me.BtnCLERK.Name = "BtnCLERK"
        Me.BtnCLERK.Size = New System.Drawing.Size(26, 24)
        Me.BtnCLERK.TabIndex = 19
        Me.BtnCLERK.Text = "派 工"
        Me.BtnCLERK.Visible = False
        '
        'tbctrl
        '
        Me.tbctrl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbctrl.Controls.Add(Me.TabPage1)
        Me.tbctrl.Controls.Add(Me.TabPage2)
        Me.tbctrl.Location = New System.Drawing.Point(2, 116)
        Me.tbctrl.Name = "tbctrl"
        Me.tbctrl.SelectedIndex = 0
        Me.tbctrl.Size = New System.Drawing.Size(896, 328)
        Me.tbctrl.TabIndex = 20
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.C1DBG)
        Me.TabPage1.Controls.Add(Me.GB2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 21)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(888, 303)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "                    船派工                    "
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.C1_5)
        Me.TabPage2.Controls.Add(Me.C1_4)
        Me.TabPage2.Controls.Add(Me.C1_3)
        Me.TabPage2.Controls.Add(Me.C1_2)
        Me.TabPage2.Controls.Add(Me.C1_1)
        Me.TabPage2.Controls.Add(Me.C1info)
        Me.TabPage2.Controls.Add(Me.Label31)
        Me.TabPage2.Controls.Add(Me.Label30)
        Me.TabPage2.Controls.Add(Me.Label29)
        Me.TabPage2.Controls.Add(Me.Label28)
        Me.TabPage2.Controls.Add(Me.Label27)
        Me.TabPage2.Controls.Add(Me.Label26)
        Me.TabPage2.Location = New System.Drawing.Point(4, 21)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(888, 303)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "                    场站                    "
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(746, 14)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(136, 23)
        Me.Label31.TabIndex = 5
        Me.Label31.Text = "驻场站五部"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(598, 14)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(136, 23)
        Me.Label30.TabIndex = 4
        Me.Label30.Text = "驻场站四部"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(450, 14)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(136, 23)
        Me.Label29.TabIndex = 3
        Me.Label29.Text = "驻场站三部"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(304, 14)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(136, 23)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "驻场站二部"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(154, 14)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(136, 23)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "驻场站一部"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(6, 14)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(136, 23)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "信息中心"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C1info
        '
        Me.C1info.AllowFilter = True
        Me.C1info.AllowSort = True
        Me.C1info.CaptionHeight = 18
        Me.C1info.CollapseColor = System.Drawing.Color.Black
        Me.C1info.DataChanged = False
        Me.C1info.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1info.ExpandColor = System.Drawing.Color.Black
        Me.C1info.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1info.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.C1info.Location = New System.Drawing.Point(6, 42)
        Me.C1info.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1info.Name = "C1info"
        Me.C1info.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1info.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1info.PreviewInfo.ZoomFactor = 75
        Me.C1info.PrintInfo.ShowOptionsDialog = False
        Me.C1info.RecordSelectorWidth = 16
        GridLines3.Color = System.Drawing.Color.DarkGray
        GridLines3.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1info.RowDivider = GridLines3
        Me.C1info.RowHeight = 16
        Me.C1info.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1info.ScrollTips = False
        Me.C1info.Size = New System.Drawing.Size(136, 256)
        Me.C1info.TabIndex = 6
        Me.C1info.Text = "C1TrueDBGrid1"
        Me.C1info.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Center;Borde" & _
        "r:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView Name="""" AllowRowSizing=""IndividualRows"" CaptionHeight=""1" & _
        "8"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBord" & _
        "er"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" Horizon" & _
        "talScrollGroup=""1""><ClientRect>0, 0, 132, 252</ClientRect><BorderSide>0</BorderS" & _
        "ide><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me" & _
        "=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=" & _
        """FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyl" & _
        "e parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><Hi" & _
        "ghLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inact" & _
        "ive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorSty" & _
        "le parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""S" & _
        "tyle6"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></" & _
        "Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""He" & _
        "ading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Capti" & _
        "on"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selecte" & _
        "d"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRo" & _
        "w"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" />" & _
        "<Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterB" & _
        "ar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSpli" & _
        "ts><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</Defaul" & _
        "tRecSelWidth><ClientArea>0, 0, 132, 252</ClientArea></Blob>"
        '
        'C1_1
        '
        Me.C1_1.AllowFilter = True
        Me.C1_1.AllowSort = True
        Me.C1_1.CaptionHeight = 18
        Me.C1_1.CollapseColor = System.Drawing.Color.Black
        Me.C1_1.DataChanged = False
        Me.C1_1.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1_1.ExpandColor = System.Drawing.Color.Black
        Me.C1_1.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1_1.Images.Add(CType(resources.GetObject("resource3"), System.Drawing.Image))
        Me.C1_1.Location = New System.Drawing.Point(154, 42)
        Me.C1_1.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1_1.Name = "C1_1"
        Me.C1_1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1_1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1_1.PreviewInfo.ZoomFactor = 75
        Me.C1_1.PrintInfo.ShowOptionsDialog = False
        Me.C1_1.RecordSelectorWidth = 16
        GridLines4.Color = System.Drawing.Color.DarkGray
        GridLines4.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1_1.RowDivider = GridLines4
        Me.C1_1.RowHeight = 16
        Me.C1_1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1_1.ScrollTips = False
        Me.C1_1.Size = New System.Drawing.Size(136, 256)
        Me.C1_1.TabIndex = 7
        Me.C1_1.Text = "C1TrueDBGrid2"
        Me.C1_1.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Bord" & _
        "er:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView Name="""" AllowRowSizing=""IndividualRows"" CaptionHeight=""1" & _
        "8"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBord" & _
        "er"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" Horizon" & _
        "talScrollGroup=""1""><ClientRect>0, 0, 132, 252</ClientRect><BorderSide>0</BorderS" & _
        "ide><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me" & _
        "=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=" & _
        """FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyl" & _
        "e parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><Hi" & _
        "ghLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inact" & _
        "ive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorSty" & _
        "le parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""S" & _
        "tyle6"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></" & _
        "Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""He" & _
        "ading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Capti" & _
        "on"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selecte" & _
        "d"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRo" & _
        "w"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" />" & _
        "<Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterB" & _
        "ar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSpli" & _
        "ts><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</Defaul" & _
        "tRecSelWidth><ClientArea>0, 0, 132, 252</ClientArea></Blob>"
        '
        'C1_2
        '
        Me.C1_2.AllowFilter = True
        Me.C1_2.AllowSort = True
        Me.C1_2.CaptionHeight = 18
        Me.C1_2.CollapseColor = System.Drawing.Color.Black
        Me.C1_2.DataChanged = False
        Me.C1_2.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1_2.ExpandColor = System.Drawing.Color.Black
        Me.C1_2.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1_2.Images.Add(CType(resources.GetObject("resource4"), System.Drawing.Image))
        Me.C1_2.Location = New System.Drawing.Point(302, 42)
        Me.C1_2.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1_2.Name = "C1_2"
        Me.C1_2.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1_2.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1_2.PreviewInfo.ZoomFactor = 75
        Me.C1_2.PrintInfo.ShowOptionsDialog = False
        Me.C1_2.RecordSelectorWidth = 16
        GridLines5.Color = System.Drawing.Color.DarkGray
        GridLines5.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1_2.RowDivider = GridLines5
        Me.C1_2.RowHeight = 16
        Me.C1_2.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1_2.ScrollTips = False
        Me.C1_2.Size = New System.Drawing.Size(136, 256)
        Me.C1_2.TabIndex = 8
        Me.C1_2.Text = "C1TrueDBGrid3"
        Me.C1_2.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Bord" & _
        "er:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView Name="""" AllowRowSizing=""IndividualRows"" CaptionHeight=""1" & _
        "8"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBord" & _
        "er"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" Horizon" & _
        "talScrollGroup=""1""><ClientRect>0, 0, 132, 252</ClientRect><BorderSide>0</BorderS" & _
        "ide><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me" & _
        "=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=" & _
        """FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyl" & _
        "e parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><Hi" & _
        "ghLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inact" & _
        "ive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorSty" & _
        "le parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""S" & _
        "tyle6"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></" & _
        "Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""He" & _
        "ading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Capti" & _
        "on"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selecte" & _
        "d"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRo" & _
        "w"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" />" & _
        "<Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterB" & _
        "ar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSpli" & _
        "ts><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</Defaul" & _
        "tRecSelWidth><ClientArea>0, 0, 132, 252</ClientArea></Blob>"
        '
        'C1_3
        '
        Me.C1_3.AllowFilter = True
        Me.C1_3.AllowSort = True
        Me.C1_3.CaptionHeight = 18
        Me.C1_3.CollapseColor = System.Drawing.Color.Black
        Me.C1_3.DataChanged = False
        Me.C1_3.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1_3.ExpandColor = System.Drawing.Color.Black
        Me.C1_3.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1_3.Images.Add(CType(resources.GetObject("resource5"), System.Drawing.Image))
        Me.C1_3.Location = New System.Drawing.Point(450, 42)
        Me.C1_3.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1_3.Name = "C1_3"
        Me.C1_3.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1_3.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1_3.PreviewInfo.ZoomFactor = 75
        Me.C1_3.PrintInfo.ShowOptionsDialog = False
        Me.C1_3.RecordSelectorWidth = 16
        GridLines6.Color = System.Drawing.Color.DarkGray
        GridLines6.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1_3.RowDivider = GridLines6
        Me.C1_3.RowHeight = 16
        Me.C1_3.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1_3.ScrollTips = False
        Me.C1_3.Size = New System.Drawing.Size(136, 256)
        Me.C1_3.TabIndex = 9
        Me.C1_3.Text = "C1TrueDBGrid4"
        Me.C1_3.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Bord" & _
        "er:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView Name="""" AllowRowSizing=""IndividualRows"" CaptionHeight=""1" & _
        "8"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBord" & _
        "er"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" Horizon" & _
        "talScrollGroup=""1""><ClientRect>0, 0, 132, 252</ClientRect><BorderSide>0</BorderS" & _
        "ide><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me" & _
        "=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=" & _
        """FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyl" & _
        "e parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><Hi" & _
        "ghLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inact" & _
        "ive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorSty" & _
        "le parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""S" & _
        "tyle6"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></" & _
        "Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""He" & _
        "ading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Capti" & _
        "on"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selecte" & _
        "d"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRo" & _
        "w"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" />" & _
        "<Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterB" & _
        "ar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSpli" & _
        "ts><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</Defaul" & _
        "tRecSelWidth><ClientArea>0, 0, 132, 252</ClientArea></Blob>"
        '
        'C1_4
        '
        Me.C1_4.AllowFilter = True
        Me.C1_4.AllowRowSelect = False
        Me.C1_4.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1_4.AllowSort = True
        Me.C1_4.CaptionHeight = 18
        Me.C1_4.CollapseColor = System.Drawing.Color.Black
        Me.C1_4.DataChanged = False
        Me.C1_4.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1_4.ExpandColor = System.Drawing.Color.Black
        Me.C1_4.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1_4.Images.Add(CType(resources.GetObject("resource6"), System.Drawing.Image))
        Me.C1_4.Location = New System.Drawing.Point(598, 42)
        Me.C1_4.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1_4.Name = "C1_4"
        Me.C1_4.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1_4.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1_4.PreviewInfo.ZoomFactor = 75
        Me.C1_4.PrintInfo.ShowOptionsDialog = False
        Me.C1_4.RecordSelectorWidth = 16
        GridLines7.Color = System.Drawing.Color.DarkGray
        GridLines7.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1_4.RowDivider = GridLines7
        Me.C1_4.RowHeight = 16
        Me.C1_4.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1_4.ScrollTips = False
        Me.C1_4.Size = New System.Drawing.Size(136, 256)
        Me.C1_4.TabIndex = 10
        Me.C1_4.Text = "C1TrueDBGrid5"
        Me.C1_4.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Bord" & _
        "er:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView AllowRowSelect=""False"" Name="""" AllowRowSizing=""None"" Cap" & _
        "tionHeight=""18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""D" & _
        "ottedCellBorder"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGrou" & _
        "p=""1"" HorizontalScrollGroup=""1""><ClientRect>0, 0, 132, 252</ClientRect><BorderSi" & _
        "de>0</BorderSide><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle paren" & _
        "t=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBar" & _
        "Style parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3""" & _
        " /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""" & _
        "Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle " & _
        "parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><Reco" & _
        "rdSelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Se" & _
        "lected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid" & _
        ".MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""N" & _
        "ormal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Headi" & _
        "ng"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal" & _
        """ me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me" & _
        "=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" m" & _
        "e=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal" & _
        """ me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplit" & _
        "s>1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWid" & _
        "th>16</DefaultRecSelWidth><ClientArea>0, 0, 132, 252</ClientArea></Blob>"
        '
        'C1_5
        '
        Me.C1_5.AllowFilter = True
        Me.C1_5.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1_5.AllowSort = True
        Me.C1_5.CaptionHeight = 18
        Me.C1_5.CollapseColor = System.Drawing.Color.Black
        Me.C1_5.DataChanged = False
        Me.C1_5.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1_5.ExpandColor = System.Drawing.Color.Black
        Me.C1_5.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1_5.Images.Add(CType(resources.GetObject("resource7"), System.Drawing.Image))
        Me.C1_5.Location = New System.Drawing.Point(746, 42)
        Me.C1_5.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1_5.Name = "C1_5"
        Me.C1_5.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1_5.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1_5.PreviewInfo.ZoomFactor = 75
        Me.C1_5.PrintInfo.ShowOptionsDialog = False
        Me.C1_5.RecordSelectorWidth = 16
        GridLines8.Color = System.Drawing.Color.DarkGray
        GridLines8.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1_5.RowDivider = GridLines8
        Me.C1_5.RowHeight = 16
        Me.C1_5.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1_5.ScrollTips = False
        Me.C1_5.Size = New System.Drawing.Size(136, 256)
        Me.C1_5.TabIndex = 11
        Me.C1_5.Text = "C1TrueDBGrid6"
        Me.C1_5.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Bord" & _
        "er:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCaptionHeight=""18"" Colu" & _
        "mnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" Def" & _
        "RecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRect>0" & _
        ", 0, 132, 252</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2" & _
        """ me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent" & _
        "=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><Foot" & _
        "erStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" />" & _
        "<HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""Highligh" & _
        "tRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle " & _
        "parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""S" & _
        "tyle11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" " & _
        "me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style paren" & _
        "t="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading""" & _
        " me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me" & _
        "=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""" & _
        "Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""" & _
        "EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""Reco" & _
        "rdSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me" & _
        "=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><La" & _
        "yout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 1" & _
        "32, 252</ClientArea></Blob>"
        '
        'FrmAttemper_Query
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(900, 477)
        Me.Controls.Add(Me.tbctrl)
        Me.Controls.Add(Me.BtnCLERK)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GB1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAttemper_Query"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "值班调度_查看"
        Me.GB.ResumeLayout(False)
        Me.GB2.ResumeLayout(False)
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB1.ResumeLayout(False)
        Me.tbctrl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.C1info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1_5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As New DataSet
    Dim ds_sub As New DataSet
    Dim dsship As New DataSet
    Dim dstmp As New DataSet
    Dim dw As New DataView
    Dim dw_sub As New DataView
    Dim dwship As New DataView
    Dim dwtmp As New DataView
    Dim sqlda As New SqlClient.SqlDataAdapter

    Dim SqlStr As String  '条件语句
    Dim DynaStr As String '可变的条件设计
    Dim FirmStr As String '不变的条件设计

    Private Sub FrmAttemper_Query_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Call FillWeather()
        Call FillWORK_TYPE()
        Call FillDAYNIGHTMARK()
        Call FillWATCH_DIRECTOR()
        Call FillDIRECTOR()
        Call FillDEPT_CODE()

        SqlStr = "select * from WATCH_RECORD where WATCH_ID=" & ID & " "
        dw = Getdata(SqlStr, ds)
        If dw.Count > 0 Then
            TxtWATCH_ID.Text = ds.Tables(0).Rows(0).Item("WATCH_ID")
            TxtLock_Mark.Text = ds.Tables(0).Rows(0).Item("Lock_Mark")
            TxtUSER_NAME.Text = Trim(G_User)
            CmbDEPT_CODE.SelectedValue = Trim(G_DeptCode)

            DTPWATCHDATE.Value = ds.Tables(0).Rows(0).Item("WATCHDATE")
            CmbWeather.SelectedValue = ds.Tables(0).Rows(0).Item("WEATHER")
            CmbWORK_TYPE.SelectedValue = ds.Tables(0).Rows(0).Item("WORK_TYPE")
            CmbDAYNIGHTMARK.SelectedValue = ds.Tables(0).Rows(0).Item("DayNightMark")
            CmbWATCH_DIRECTOR.SelectedValue = ds.Tables(0).Rows(0).Item("WATCH_DIRECTOR")
            CmbDIRECTOR.SelectedValue = ds.Tables(0).Rows(0).Item("DIRECTOR")
            TxtITEM.Text = ds.Tables(0).Rows(0).Item("ITEM")
            TxtREMARK.Text = ds.Tables(0).Rows(0).Item("REMARK")
        End If
        DTPWATCHDATE.Focus()
        Call myDataGrid()
        Exit Sub
Err:
        Resume Next

    End Sub

    Private Sub myDataGrid() '**************船舶信息
        Dim strsql As String
        Dim i As Integer
        FirmStr = " Order by Dept_Code,Ship_Statu"
        'DynaStr = " ( ship_id in (select distinct ship_id from WATCH_RECORD_SHIP where datediff(dd,WATCHSHIPDATE ,'" & DTPWATCHDATE.Value & "')=0 and  DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "') and DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3')) "
        DynaStr = " datediff(dd,WATCHSHIPDATE ,'" & DTPWATCHDATE.Value & "')=0 and  DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "' and DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3') "
        SqlStr = DynaStr & FirmStr
        strsql = "select * from WATCH_RECORD_Query where " & SqlStr
        dwship = Getdata(strsql, dsship)
        Try
            Me.C1DBG.DataSource = dwship
            For i = 0 To 4
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            For i = 5 To 21
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).AutoSize()
            Next
            Me.C1DBG.Columns.Item("DEPT_SHORT").Caption = "部门"
            Me.C1DBG.Columns.Item("BERTHNO").Caption = "泊位"
            Me.C1DBG.Columns.Item("BERTH_POSITION").Caption = "位置"
            Me.C1DBG.Columns.Item("BERTH_TIME").Caption = "进船时间"
            Me.C1DBG.Columns.Item("CHI_VESSEL").Caption = "船名"
            Me.C1DBG.Columns.Item("VOYAGE").Caption = "航次"
            Me.C1DBG.Columns.Item("NATIONALITY_CHA").Caption = "国籍"
            Me.C1DBG.Columns.Item("InOutPort_Name").Caption = "进/出"
            Me.C1DBG.Columns.Item("PORT_CHA").Caption = "港名"
            Me.C1DBG.Columns.Item("GOODS_CHA").Caption = "货名"
            Me.C1DBG.Columns.Item("PIECE").Caption = "原配件数"
            Me.C1DBG.Columns.Item("TONS").Caption = "原配吨数"
            Me.C1DBG.Columns.Item("REMAIN").Caption = "剩余件数"
            Me.C1DBG.Columns.Item("REMAIN_TON").Caption = "剩余吨数"
            Me.C1DBG.Columns.Item("SHIPAGENT_SHORT").Caption = "船代"
            Me.C1DBG.Columns.Item("WORKTIME_END").Caption = "完船时间"
            Me.C1DBG.Columns.Item("tons_sum").Caption = "吨数"

            Me.C1DBG.Splits(0).DisplayColumns.Item("DEPT_SHORT").Width = 30
            Me.C1DBG.Splits(0).DisplayColumns.Item("BERTHNO").Width = 30
            Me.C1DBG.Splits(0).DisplayColumns.Item("BERTH_POSITION").Width = 30
            If dsship.Tables(0).Rows.Count > 0 Then
                Call SetColumnSum(0)  '设计合计列
            End If
            Me.C1DBG.FetchRowStyles = True
            Me.C1DBG.Refresh()
            tbctrl.SelectedTab = TabPage1

            If G_DeptCode = "26.11" Then
                Dim str As String
                Dim dsinfo As New DataSet
                Dim dwinfo As New DataView
                Dim ds1 As New DataSet
                Dim dw1 As New DataView
                Dim ds2 As New DataSet
                Dim dw2 As New DataView
                Dim ds3 As New DataSet
                Dim dw3 As New DataView
                Dim ds4 As New DataSet
                Dim dw4 As New DataView
                Dim ds5 As New DataSet
                Dim dw5 As New DataView

                str = "SELECT b.NAME, c.WorkTime FROM ABSENT a INNER JOIN Code_WorkTime c ON a.DAYNIGHTMARK = c.Code_WorkTime INNER JOIN TALLY_CLERK b ON a.WORK_NO = b.WORK_NO WHERE datediff(dd,absentdate ,'" & DTPWATCHDATE.Value & "')=0 and (a.DEPT_CODE = '26.11.30') order by NAME,WorkTime "
                dwinfo = Getdata(str, dsinfo)
                Me.C1info.DataSource = dwinfo
                Me.C1info.Columns.Item("NAME").Caption = "  姓名"
                Me.C1info.Columns.Item("WorkTime").Caption = " 白/夜班"
                Me.C1info.Splits(0).DisplayColumns.Item(0).Width = 50
                Me.C1info.Splits(0).DisplayColumns.Item(1).Width = 60

                str = "SELECT b.NAME, c.WorkTime FROM ABSENT a INNER JOIN Code_WorkTime c ON a.DAYNIGHTMARK = c.Code_WorkTime INNER JOIN TALLY_CLERK b ON a.WORK_NO = b.WORK_NO WHERE datediff(dd,absentdate ,'" & DTPWATCHDATE.Value & "')=0 and (a.DEPT_CODE = '26.12.11') order by NAME,WorkTime "
                dw1 = Getdata(str, ds1)
                Me.C1_1.DataSource = dw1
                Me.C1_1.Columns.Item("NAME").Caption = "  姓名"
                Me.C1_1.Columns.Item("WorkTime").Caption = " 白/夜班"
                Me.C1_1.Splits(0).DisplayColumns.Item(0).Width = 50
                Me.C1_1.Splits(0).DisplayColumns.Item(1).Width = 60


                str = "SELECT b.NAME, c.WorkTime FROM ABSENT a INNER JOIN Code_WorkTime c ON a.DAYNIGHTMARK = c.Code_WorkTime INNER JOIN TALLY_CLERK b ON a.WORK_NO = b.WORK_NO WHERE datediff(dd,absentdate ,'" & DTPWATCHDATE.Value & "')=0 and (a.DEPT_CODE = '26.12.12') order by NAME,WorkTime "
                dw2 = Getdata(str, ds2)
                Me.C1_2.DataSource = dw2
                Me.C1_2.Columns.Item("NAME").Caption = "  姓名"
                Me.C1_2.Columns.Item("WorkTime").Caption = " 白/夜班"
                Me.C1_2.Splits(0).DisplayColumns.Item(0).Width = 50
                Me.C1_2.Splits(0).DisplayColumns.Item(1).Width = 60

                str = "SELECT b.NAME, c.WorkTime FROM ABSENT a INNER JOIN Code_WorkTime c ON a.DAYNIGHTMARK = c.Code_WorkTime INNER JOIN TALLY_CLERK b ON a.WORK_NO = b.WORK_NO WHERE datediff(dd,absentdate ,'" & DTPWATCHDATE.Value & "')=0 and (a.DEPT_CODE = '26.12.13') order by NAME,WorkTime "
                dw3 = Getdata(str, ds3)
                Me.C1_3.DataSource = dw3
                Me.C1_3.Columns.Item("NAME").Caption = "  姓名"
                Me.C1_3.Columns.Item("WorkTime").Caption = " 白/夜班"
                Me.C1_3.Splits(0).DisplayColumns.Item(0).Width = 50
                Me.C1_3.Splits(0).DisplayColumns.Item(1).Width = 60

                str = "SELECT b.NAME, c.WorkTime FROM ABSENT a INNER JOIN Code_WorkTime c ON a.DAYNIGHTMARK = c.Code_WorkTime INNER JOIN TALLY_CLERK b ON a.WORK_NO = b.WORK_NO WHERE datediff(dd,absentdate ,'" & DTPWATCHDATE.Value & "')=0 and (a.DEPT_CODE = '26.12.14') order by NAME,WorkTime "
                dw4 = Getdata(str, ds4)
                Me.C1_4.DataSource = dw4
                Me.C1_4.Columns.Item("NAME").Caption = "  姓名"
                Me.C1_4.Columns.Item("WorkTime").Caption = " 白/夜班"
                Me.C1_4.Splits(0).DisplayColumns.Item(0).Width = 50
                Me.C1_4.Splits(0).DisplayColumns.Item(1).Width = 60

                str = "SELECT b.NAME, c.WorkTime FROM ABSENT a INNER JOIN Code_WorkTime c ON a.DAYNIGHTMARK = c.Code_WorkTime INNER JOIN TALLY_CLERK b ON a.WORK_NO = b.WORK_NO WHERE datediff(dd,absentdate ,'" & DTPWATCHDATE.Value & "')=0 and (a.DEPT_CODE = '26.12.15') order by NAME,WorkTime "
                dw5 = Getdata(str, ds5)
                Me.C1_5.DataSource = dw5
                Me.C1_5.Columns.Item("NAME").Caption = "  姓名"
                Me.C1_5.Columns.Item("WorkTime").Caption = " 白/夜班"
                Me.C1_5.Splits(0).DisplayColumns.Item(0).Width = 50
                Me.C1_5.Splits(0).DisplayColumns.Item(1).Width = 60
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
    End Sub

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        If Me.C1DBG.Columns("SHIP_STATU").CellValue(e.Row) = 1 Then
            e.CellStyle.BackColor = System.Drawing.Color.White
        End If
        If Me.C1DBG.Columns("SHIP_STATU").CellValue(e.Row) = 2 Then
            e.CellStyle.BackColor = System.Drawing.Color.PaleGreen
        End If
        If Me.C1DBG.Columns("SHIP_STATU").CellValue(e.Row) = 3 Then
            e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
        End If
        If Me.C1DBG.Columns("SHIP_STATU").CellValue(e.Row) = 4 Then
            e.CellStyle.BackColor = System.Drawing.Color.Pink
        End If
    End Sub

    Private Sub SetColumnSum(ByVal Col As Integer) '****************航次汇总行
        Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBG.Columns.Item(Col).FooterText = "共 " & dsship.Tables(0).Rows.Count & " 条"
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Close()
    End Sub

    Private Sub C1DBG_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1DBG.DoubleClick
        Dim dsClerk As New DataSet
        Dim dwClerk As New DataView
        Dim dstemp As New DataSet
        Dim dwtemp As New DataView
        Dim dstmp As New DataSet
        Dim dwtmp As New DataView
        Dim i As Integer

        If G_DeptCode = "26.11" Then
            SqlStr = "select * from TALLY_TEAM where datediff(dd,WORK_DAY,'" & DTPWATCHDATE.Value & "')=0  and DEPT_CODE Like '" & G_DeptCode & "%' and SHIP_ID=" & Me.C1DBG.Columns.Item("SHIP_ID").Text & " and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
            dwClerk = Updatedata(sqlda, SqlStr, dsClerk)
        Else
            SqlStr = "select * from TALLY_TEAM where datediff(dd,WORK_DAY,'" & DTPWATCHDATE.Value & "')=0 and WORK_TYPE='" & CmbWORK_TYPE.SelectedValue & "' and DEPT_CODE ='" & G_DeptCode & "' and SHIP_ID=" & Me.C1DBG.Columns.Item("SHIP_ID").Text & " and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
            dwClerk = Updatedata(sqlda, SqlStr, dsClerk)
        End If
        If dwClerk.Count > 0 Then                       '********* 派工，编辑 
            ID = dwClerk(0)(0)
            GL_Clerk = 1
        Else
            GL_Clerk = 0
            MsgBox("此船无派工信息！", MsgBoxStyle.Information, "提示")
            Exit Sub
        End If

        Dim st As String
        'st = "exec TALLY_CLERK_Query '" & DTPWATCHDATE.Value & "','" & Me.C1DBG.Columns.Item("DEPT_CODE").Text & "','" & CmbWORK_TYPE.SelectedValue & "'," & Me.C1DBG.Columns.Item("SHIP_ID").Text & ",'" & CmbDAYNIGHTMARK.SelectedValue & "'"
        dwClerk = Getdata("exec TALLY_CLERK_Query '" & DTPWATCHDATE.Value & "','" & Me.C1DBG.Columns.Item("DEPT_CODE").Text & "'," & Me.C1DBG.Columns.Item("SHIP_ID").Text & ",'" & CmbDAYNIGHTMARK.SelectedValue & "'", dsClerk)
        'MsgBox(Me.C1DBG.Columns.Item("DEPT_CODE").Text, MsgBoxStyle.Information, "提示")
        'MsgBox(G_DeptCode, MsgBoxStyle.Information, "提示")
        If dwClerk.Count > 0 Then
            Me.C1DBGV.DataSource = dwClerk

            Me.C1DBGV.Columns.Item("WORK_NO").Caption = "工号"
            Me.C1DBGV.Columns.Item("Name").Caption = "姓名"
            Me.C1DBGV.Columns.Item("CODE_DUTY").Caption = "职务"
            Me.C1DBGV.Columns.Item("DEPT_CODE").Caption = "部门"

            Me.C1DBGV.Splits(0).DisplayColumns.Item(0).Width = 45
            Me.C1DBGV.Splits(0).DisplayColumns.Item(1).Width = 45
            Me.C1DBGV.Splits(0).DisplayColumns.Item(2).Width = 55
            Me.C1DBGV.Splits(0).DisplayColumns.Item(3).Width = 30

            'Dim i As Integer
            Dim dst As New DataSet
            Dim sqla As New SqlClient.SqlDataAdapter
            Dim sqlc As New SqlClient.SqlCommand
            '***************职务
            Me.C1DBGV.Columns.Item("CODE_DUTY").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBGV.Columns.Item("CODE_DUTY").ValueItems.Translate = True
            Me.C1DBGV.Columns.Item("CODE_DUTY").ValueItems.Validate = True
            Me.C1DBGV.Splits(0).DisplayColumns.Item("CODE_DUTY").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT CODE_DUTY, DUTY_CHA FROM CODE_DUTY "
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("DUTY_CHA"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("CODE_DUTY"))
                Me.C1DBGV.Columns.Item("CODE_DUTY").ValueItems.Values.Add(vi)
            Next
            '***************部门
            Me.C1DBGV.Columns.Item("DEPT_CODE").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBGV.Columns.Item("DEPT_CODE").ValueItems.Translate = True
            Me.C1DBGV.Columns.Item("DEPT_CODE").ValueItems.Validate = True
            Me.C1DBGV.Splits(0).DisplayColumns.Item("CODE_DUTY").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT DEPT_CODE, DEPT_SHORT FROM DEPARTMENT "
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("DEPT_SHORT"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("DEPT_CODE"))
                Me.C1DBGV.Columns.Item("DEPT_CODE").ValueItems.Values.Add(vi)
            Next
        End If

    End Sub

    Private Sub C1DBG_DoubleClick1(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles C1DBG.DoubleClick
        On Error GoTo Err
        Dim i As Integer
        Dim dssp As New DataSet
        Dim dvsp As New DataView

        GB1.Text = "单船记录： " & Me.C1DBG.Columns.Item(0).Text & " " & Me.C1DBG.Columns.Item(1).Text

        Call FillINOUTPORT()
        Call FillLOAD_UNLOAD_PORT()
        Call FillNATIONALITY_CODE()
        Call FillCODE_GOODS()
        Call FillMARK_COMPLETE()

        ID = CType(Me.C1DBG.Columns.Item("SHIP_ID").Text.ToString, Integer)

        SqlStr = "select * from WATCH_RECORD_SHIP where SHIP_ID=" & ID & " and datediff(dd,WATCHSHIPDATE ,'" & DTPWATCHDATE.Value & "')=0 and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
        dwtmp = Getdata(SqlStr, dstmp)
        If dwtmp.Count > 0 Then  '存在对应航次的值班单船记录，提取
            If Len(Trim(dstmp.Tables(0).Rows(0).Item("BERTHNO"))) > 0 Then
                TxtBERTHNO.Text = Trim(dstmp.Tables(0).Rows(0).Item("BERTHNO"))
            Else
                TxtBERTHNO.Text = ""
            End If
            CmbINOUTPORT.SelectedValue = dstmp.Tables(0).Rows(0).Item("INOUTPORT")
            TxtTICKET.Text = dstmp.Tables(0).Rows(0).Item("TICKET")
            CmbLOAD_UNLOAD_PORT.SelectedValue = dstmp.Tables(0).Rows(0).Item("LOAD_UNLOAD_PORT")
            CmbNATIONALITY_CODE.SelectedValue = dstmp.Tables(0).Rows(0).Item("NATIONALITY_CODE")
            CmbCODE_GOODS.SelectedValue = dstmp.Tables(0).Rows(0).Item("CODE_GOODS")
            TxtPIECE.Text = dstmp.Tables(0).Rows(0).Item("PIECE")
            TxtTONS.Text = dstmp.Tables(0).Rows(0).Item("TONS")
            TxtTALLY_CARGO.Text = dstmp.Tables(0).Rows(0).Item("TALLY_CARGO")
            TxtTALLY_CARGO_TON.Text = dstmp.Tables(0).Rows(0).Item("TALLY_CARGO_TON")
            TxtTOTAL_NUM.Text = dstmp.Tables(0).Rows(0).Item("TOTAL_NUM")
            TxtTOTAL_NUM_TON.Text = dstmp.Tables(0).Rows(0).Item("TOTAL_NUM_TON")
            TxtREMAIN.Text = dstmp.Tables(0).Rows(0).Item("REMAIN")
            TxtREMAIN_TON.Text = dstmp.Tables(0).Rows(0).Item("REMAIN_TON")
            CmbMARK_COMPLETE.SelectedValue = dstmp.Tables(0).Rows(0).Item("MARK_COMPLETE")

            If G_DeptCode = "26.11" Then  '填充公司备注
                TxtCOMPANY_REMARK.Text = dstmp.Tables(0).Rows(0).Item("COMPANY_REMARK")
                TxtDEPT_REMARK.Text = dstmp.Tables(0).Rows(0).Item("DEPT_REMARK")
            ElseIf G_DeptCode Like "26.11.*" Then  '填充部门备注
                TxtDEPT_REMARK.Text = dstmp.Tables(0).Rows(0).Item("DEPT_REMARK")
            End If
        End If
Err:
        Resume Next
    End Sub

    Private Sub FillWeather()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "select Code_Weather,Weather from Code_Weather"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbWeather.DataSource = dvc
        Me.CmbWeather.DisplayMember = "Weather"
        Me.CmbWeather.ValueMember = "Code_Weather"
    End Sub

    Private Sub FillWORK_TYPE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "SELECT WORK_TYPE FROM WORK_BEGIN WHERE DEPT_CODE='" & G_DeptCode & "' ORDER BY TIME_FROM, DayNightMark"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbWORK_TYPE.DataSource = dvc
        Me.CmbWORK_TYPE.DisplayMember = "WORK_TYPE"
        Me.CmbWORK_TYPE.ValueMember = "WORK_TYPE"
    End Sub

    Private Sub FillWATCH_DIRECTOR()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "SELECT Code_Director,Director FROM Code_Director WHERE DEPT_CODE ='" & G_DeptCode & "'"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbWATCH_DIRECTOR.DataSource = dvc
        Me.CmbWATCH_DIRECTOR.DisplayMember = "Director"
        Me.CmbWATCH_DIRECTOR.ValueMember = "Code_Director"
    End Sub

    Private Sub FillDIRECTOR()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "SELECT Code_Director,Director FROM Code_Director WHERE DEPT_CODE ='" & G_DeptCode & "'"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbDIRECTOR.DataSource = dvc
        Me.CmbDIRECTOR.DisplayMember = "Director"
        Me.CmbDIRECTOR.ValueMember = "Code_Director"
    End Sub

    Private Sub FillDAYNIGHTMARK()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "SELECT Code_WorkTime,WorkTime FROM Code_WorkTime"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbDAYNIGHTMARK.DataSource = dvc
        Me.CmbDAYNIGHTMARK.DisplayMember = "WorkTime"
        Me.CmbDAYNIGHTMARK.ValueMember = "Code_WorkTime"
    End Sub

    Private Sub FillINOUTPORT()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "select InOutPort,InOutPort_Name from Code_InOutPort"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbINOUTPORT.DataSource = dvc
        Me.CmbINOUTPORT.DisplayMember = "InOutPort_Name"
        Me.CmbINOUTPORT.ValueMember = "InOutPort"
    End Sub

    Private Sub FillLOAD_UNLOAD_PORT()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "select CODE_PORT,PORT_CHA from CODE_PORT"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbLOAD_UNLOAD_PORT.DataSource = dvc
        Me.CmbLOAD_UNLOAD_PORT.DisplayMember = "PORT_CHA"
        Me.CmbLOAD_UNLOAD_PORT.ValueMember = "CODE_PORT"
    End Sub

    Private Sub FillNATIONALITY_CODE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "select NATIONALITY_CHA,NATIONALITY_ENG from CODE_NATIONALITY"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbNATIONALITY_CODE.DataSource = dvc
        Me.CmbNATIONALITY_CODE.DisplayMember = "NATIONALITY_CHA"
        Me.CmbNATIONALITY_CODE.ValueMember = "NATIONALITY_ENG"
    End Sub

    Private Sub FillCODE_GOODS()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "select Code_Cargo_Type,Cargo_Type from Code_Cargo_Type"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbCODE_GOODS.DataSource = dvc
        Me.CmbCODE_GOODS.DisplayMember = "Cargo_Type"
        Me.CmbCODE_GOODS.ValueMember = "Code_Cargo_Type"
    End Sub

    Private Sub FillMARK_COMPLETE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "select Descri,Value from CodeLINER_ID"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbMARK_COMPLETE.DataSource = dvc
        Me.CmbMARK_COMPLETE.DisplayMember = "Descri"
        Me.CmbMARK_COMPLETE.ValueMember = "Value"
    End Sub

    Private Sub FillDEPT_CODE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "select DEPT_CODE,DEPT_NAME from DEPARTMENT"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbDEPT_CODE.DataSource = dvc
        Me.CmbDEPT_CODE.DisplayMember = "DEPT_NAME"
        Me.CmbDEPT_CODE.ValueMember = "DEPT_CODE"
    End Sub

    Private Sub BtnCLERK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCLERK.Click
        Dim dsClerk As New DataSet
        Dim dwClerk As New DataView
        Dim row As DataRow

        GL_Str = Me.C1DBG.Columns.Item("CHI_VESSEL").Text

        If G_DeptCode = "26.11" Then
            SqlStr = "select * from TALLY_TEAM where datediff(dd,WORK_DAY,'" & DTPWATCHDATE.Value & "')=0  and DEPT_CODE Like '" & G_DeptCode & "%' and SHIP_ID=" & ID & " and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
            dwClerk = Updatedata(sqlda, SqlStr, dsClerk)
        Else
            SqlStr = "select * from TALLY_TEAM where datediff(dd,WORK_DAY,'" & DTPWATCHDATE.Value & "')=0 and WORK_TYPE='" & CmbWORK_TYPE.SelectedValue & "' and DEPT_CODE ='" & G_DeptCode & "' and SHIP_ID=" & ID & " and DayNightMark='" & CmbDAYNIGHTMARK.SelectedValue & "'"
            dwClerk = Updatedata(sqlda, SqlStr, dsClerk)
        End If
        If dwClerk.Count > 0 Then                       '********* 派工，编辑 
            ID = dwClerk(0)(0)
            GL_Clerk = 1
        Else
            GL_Clerk = 0
            MsgBox("此船无派工信息！", MsgBoxStyle.Information, "提示")
            Exit Sub
        End If

        Dim FrmCLERK As New FrmAttemper_openform5
        FrmCLERK.ShowDialog()

    End Sub
End Class
