Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FrmCargo_verify
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写 dispose 以清理组件列表。
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

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents GBV As System.Windows.Forms.GroupBox
    Friend WithEvents btResure As System.Windows.Forms.Button
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents C1DBGV As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents LabREMARKS As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents TabShipInfo As System.Windows.Forms.TabControl
    Friend WithEvents TabTALLY_LIST As System.Windows.Forms.TabPage
    Friend WithEvents TabWAIT As System.Windows.Forms.TabPage
    Friend WithEvents TabWORK_RECORD As System.Windows.Forms.TabPage
    Friend WithEvents TabMEASURE As System.Windows.Forms.TabPage
    Friend WithEvents C1DBGTALLY_LIST As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1DBGWAIT As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1DBGWORK_RECORD As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1DBGMEASURE As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFind As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuery As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrint As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExport As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCompile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAdd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarV As System.Windows.Forms.ToolBar
    Friend WithEvents S1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnOK As System.Windows.Forms.ToolBarButton
    Friend WithEvents S2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSearch As System.Windows.Forms.ToolBarButton
    Friend WithEvents S3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSort As System.Windows.Forms.ToolBarButton
    Friend WithEvents S4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnEng As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents tbbtnFind As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtndo As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuery As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnAdd As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnEdit As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnDelete As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnPrint As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnExport As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuit As System.Windows.Forms.ToolBarButton
    Friend WithEvents TabDaily As System.Windows.Forms.TabPage
    Friend WithEvents C1DBGDaily_report As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents TabDailyother As System.Windows.Forms.TabPage
    Friend WithEvents C1DBGDaily_other As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Infozwcm As System.Windows.Forms.Label
    Friend WithEvents Infojck As System.Windows.Forms.Label
    Friend WithEvents Infoywcm As System.Windows.Forms.Label
    Friend WithEvents Infozxg As System.Windows.Forms.Label
    Friend WithEvents Infops As System.Windows.Forms.Label
    Friend WithEvents Infosjds As System.Windows.Forms.Label
    Friend WithEvents Infohm As System.Windows.Forms.Label
    Friend WithEvents Infoqdds As System.Windows.Forms.Label
    Friend WithEvents Infosjjs As System.Windows.Forms.Label
    Friend WithEvents Infoqdjs As System.Windows.Forms.Label
    Friend WithEvents Infobw As System.Windows.Forms.Label
    Friend WithEvents Infohc As System.Windows.Forms.Label
    Friend WithEvents Infoywgj As System.Windows.Forms.Label
    Friend WithEvents Infocd As System.Windows.Forms.Label
    Friend WithEvents Infozwgj As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmbreport As System.Windows.Forms.ComboBox
    Friend WithEvents labreport As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmbreportOth As System.Windows.Forms.ComboBox
    Friend WithEvents labreportOth As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Cmbflag As System.Windows.Forms.ComboBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Infowgsj As System.Windows.Forms.Label
    Friend WithEvents Infokgsj As System.Windows.Forms.Label
    Friend WithEvents TabCertificate As System.Windows.Forms.TabPage
    Friend WithEvents C1DBGCertificate As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents TabFee As System.Windows.Forms.TabPage
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents TabShort As System.Windows.Forms.TabPage
    Friend WithEvents C1DBGShort As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents TabDamaged As System.Windows.Forms.TabPage
    Friend WithEvents C1DBGDamaged As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tbbtupload As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCargo_verify))
        Me.GBV = New System.Windows.Forms.GroupBox
        Me.ToolBarV = New System.Windows.Forms.ToolBar
        Me.S1 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnOK = New System.Windows.Forms.ToolBarButton
        Me.S2 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSearch = New System.Windows.Forms.ToolBarButton
        Me.S3 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSort = New System.Windows.Forms.ToolBarButton
        Me.S4 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnEng = New System.Windows.Forms.ToolBarButton
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.btResure = New System.Windows.Forms.Button
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.C1DBGV = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.GB = New System.Windows.Forms.GroupBox
        Me.ToolBar = New System.Windows.Forms.ToolBar
        Me.tbbtnFind = New System.Windows.Forms.ToolBarButton
        Me.tbbtndo = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuery = New System.Windows.Forms.ToolBarButton
        Me.tbbtnAdd = New System.Windows.Forms.ToolBarButton
        Me.tbbtnEdit = New System.Windows.Forms.ToolBarButton
        Me.tbbtnDelete = New System.Windows.Forms.ToolBarButton
        Me.tbbtnPrint = New System.Windows.Forms.ToolBarButton
        Me.tbbtnExport = New System.Windows.Forms.ToolBarButton
        Me.tbbtupload = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuit = New System.Windows.Forms.ToolBarButton
        Me.TabShipInfo = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Infowgsj = New System.Windows.Forms.Label
        Me.Infokgsj = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Infozxg = New System.Windows.Forms.Label
        Me.Infops = New System.Windows.Forms.Label
        Me.Infosjds = New System.Windows.Forms.Label
        Me.Infohm = New System.Windows.Forms.Label
        Me.Infoqdds = New System.Windows.Forms.Label
        Me.Infosjjs = New System.Windows.Forms.Label
        Me.Infoqdjs = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Infobw = New System.Windows.Forms.Label
        Me.Infojck = New System.Windows.Forms.Label
        Me.Infohc = New System.Windows.Forms.Label
        Me.Infoywgj = New System.Windows.Forms.Label
        Me.Infoywcm = New System.Windows.Forms.Label
        Me.Infocd = New System.Windows.Forms.Label
        Me.Infozwgj = New System.Windows.Forms.Label
        Me.Infozwcm = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TabTALLY_LIST = New System.Windows.Forms.TabPage
        Me.C1DBGTALLY_LIST = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TabWAIT = New System.Windows.Forms.TabPage
        Me.C1DBGWAIT = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TabWORK_RECORD = New System.Windows.Forms.TabPage
        Me.C1DBGWORK_RECORD = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TabDamaged = New System.Windows.Forms.TabPage
        Me.C1DBGDamaged = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TabShort = New System.Windows.Forms.TabPage
        Me.C1DBGShort = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TabMEASURE = New System.Windows.Forms.TabPage
        Me.C1DBGMEASURE = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TabDaily = New System.Windows.Forms.TabPage
        Me.C1DBGDaily_report = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmbreport = New System.Windows.Forms.ComboBox
        Me.labreport = New System.Windows.Forms.Label
        Me.TabDailyother = New System.Windows.Forms.TabPage
        Me.C1DBGDaily_other = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label18 = New System.Windows.Forms.Label
        Me.Cmbflag = New System.Windows.Forms.ComboBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.cmbreportOth = New System.Windows.Forms.ComboBox
        Me.labreportOth = New System.Windows.Forms.Label
        Me.TabCertificate = New System.Windows.Forms.TabPage
        Me.C1DBGCertificate = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TabFee = New System.Windows.Forms.TabPage
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.LabREMARKS = New System.Windows.Forms.Label
        Me.Label = New System.Windows.Forms.Label
        Me.MainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuFind = New System.Windows.Forms.MenuItem
        Me.mnuQuery = New System.Windows.Forms.MenuItem
        Me.mnuSep1 = New System.Windows.Forms.MenuItem
        Me.mnuPrint = New System.Windows.Forms.MenuItem
        Me.mnuExport = New System.Windows.Forms.MenuItem
        Me.mnuSep2 = New System.Windows.Forms.MenuItem
        Me.mnuQuit = New System.Windows.Forms.MenuItem
        Me.mnuCompile = New System.Windows.Forms.MenuItem
        Me.mnuAdd = New System.Windows.Forms.MenuItem
        Me.mnuEdit = New System.Windows.Forms.MenuItem
        Me.mnuDelete = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.GBV.SuspendLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB.SuspendLayout()
        Me.TabShipInfo.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabTALLY_LIST.SuspendLayout()
        CType(Me.C1DBGTALLY_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabWAIT.SuspendLayout()
        CType(Me.C1DBGWAIT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabWORK_RECORD.SuspendLayout()
        CType(Me.C1DBGWORK_RECORD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDamaged.SuspendLayout()
        CType(Me.C1DBGDamaged, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabShort.SuspendLayout()
        CType(Me.C1DBGShort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMEASURE.SuspendLayout()
        CType(Me.C1DBGMEASURE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDaily.SuspendLayout()
        CType(Me.C1DBGDaily_report, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TabDailyother.SuspendLayout()
        CType(Me.C1DBGDaily_other, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.TabCertificate.SuspendLayout()
        CType(Me.C1DBGCertificate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabFee.SuspendLayout()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBV
        '
        Me.GBV.Controls.Add(Me.ToolBarV)
        Me.GBV.Controls.Add(Me.btResure)
        Me.GBV.Controls.Add(Me.txtVoyage)
        Me.GBV.Controls.Add(Me.Label2)
        Me.GBV.Controls.Add(Me.txtShipName)
        Me.GBV.Controls.Add(Me.Label1)
        Me.GBV.Controls.Add(Me.C1DBGV)
        Me.GBV.Dock = System.Windows.Forms.DockStyle.Left
        Me.GBV.Location = New System.Drawing.Point(0, 0)
        Me.GBV.Name = "GBV"
        Me.GBV.Size = New System.Drawing.Size(174, 439)
        Me.GBV.TabIndex = 5
        Me.GBV.TabStop = False
        '
        'ToolBarV
        '
        Me.ToolBarV.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.S1, Me.tbbtnOK, Me.S2, Me.tbbtnSearch, Me.S3, Me.tbbtnSort, Me.S4, Me.tbbtnEng})
        Me.ToolBarV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBarV.DropDownArrows = True
        Me.ToolBarV.ImageList = Me.ImageList
        Me.ToolBarV.Location = New System.Drawing.Point(3, 395)
        Me.ToolBarV.Name = "ToolBarV"
        Me.ToolBarV.ShowToolTips = True
        Me.ToolBarV.Size = New System.Drawing.Size(168, 41)
        Me.ToolBarV.TabIndex = 17
        '
        'S1
        '
        Me.S1.Name = "S1"
        Me.S1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnOK
        '
        Me.tbbtnOK.ImageIndex = 8
        Me.tbbtnOK.Name = "tbbtnOK"
        Me.tbbtnOK.Text = "常规"
        '
        'S2
        '
        Me.S2.Name = "S2"
        Me.S2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnSearch
        '
        Me.tbbtnSearch.ImageIndex = 9
        Me.tbbtnSearch.Name = "tbbtnSearch"
        Me.tbbtnSearch.Text = "检索"
        '
        'S3
        '
        Me.S3.Name = "S3"
        Me.S3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnSort
        '
        Me.tbbtnSort.ImageIndex = 10
        Me.tbbtnSort.Name = "tbbtnSort"
        Me.tbbtnSort.Text = "排序"
        '
        'S4
        '
        Me.S4.Name = "S4"
        Me.S4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnEng
        '
        Me.tbbtnEng.ImageIndex = 11
        Me.tbbtnEng.Name = "tbbtnEng"
        Me.tbbtnEng.Text = "英文"
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "")
        Me.ImageList.Images.SetKeyName(1, "")
        Me.ImageList.Images.SetKeyName(2, "")
        Me.ImageList.Images.SetKeyName(3, "")
        Me.ImageList.Images.SetKeyName(4, "")
        Me.ImageList.Images.SetKeyName(5, "")
        Me.ImageList.Images.SetKeyName(6, "")
        Me.ImageList.Images.SetKeyName(7, "")
        Me.ImageList.Images.SetKeyName(8, "")
        Me.ImageList.Images.SetKeyName(9, "")
        Me.ImageList.Images.SetKeyName(10, "")
        Me.ImageList.Images.SetKeyName(11, "")
        Me.ImageList.Images.SetKeyName(12, "")
        '
        'btResure
        '
        Me.btResure.Location = New System.Drawing.Point(128, 332)
        Me.btResure.Name = "btResure"
        Me.btResure.Size = New System.Drawing.Size(42, 22)
        Me.btResure.TabIndex = 16
        Me.btResure.Text = "查询"
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(38, 332)
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(88, 21)
        Me.txtVoyage.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 14)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "航次"
        '
        'txtShipName
        '
        Me.txtShipName.Location = New System.Drawing.Point(38, 308)
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.Size = New System.Drawing.Size(132, 21)
        Me.txtShipName.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 310)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "船名"
        '
        'C1DBGV
        '
        Me.C1DBGV.AllowUpdate = False
        Me.C1DBGV.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1DBGV.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGV.Images.Add(CType(resources.GetObject("C1DBGV.Images"), System.Drawing.Image))
        Me.C1DBGV.Location = New System.Drawing.Point(3, 17)
        Me.C1DBGV.Name = "C1DBGV"
        Me.C1DBGV.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGV.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGV.PreviewInfo.ZoomFactor = 75
        Me.C1DBGV.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGV.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGV.Size = New System.Drawing.Size(168, 289)
        Me.C1DBGV.TabIndex = 0
        Me.C1DBGV.Text = "C1TrueDBGrid1"
        Me.C1DBGV.PropBag = resources.GetString("C1DBGV.PropBag")
        '
        'GB
        '
        Me.GB.Controls.Add(Me.ToolBar)
        Me.GB.Controls.Add(Me.TabShipInfo)
        Me.GB.Controls.Add(Me.LabREMARKS)
        Me.GB.Controls.Add(Me.Label)
        Me.GB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB.Location = New System.Drawing.Point(174, 0)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(650, 439)
        Me.GB.TabIndex = 6
        Me.GB.TabStop = False
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnFind, Me.tbbtndo, Me.tbbtnQuery, Me.tbbtnAdd, Me.tbbtnEdit, Me.tbbtnDelete, Me.tbbtnPrint, Me.tbbtnExport, Me.tbbtupload, Me.tbbtnQuit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.Enabled = False
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(3, 17)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(644, 41)
        Me.ToolBar.TabIndex = 16
        '
        'tbbtnFind
        '
        Me.tbbtnFind.ImageIndex = 0
        Me.tbbtnFind.Name = "tbbtnFind"
        Me.tbbtnFind.Text = "检索"
        Me.tbbtnFind.ToolTipText = "检索"
        '
        'tbbtndo
        '
        Me.tbbtndo.ImageIndex = 10
        Me.tbbtndo.Name = "tbbtndo"
        Me.tbbtndo.Text = "审核"
        Me.tbbtndo.ToolTipText = "审核"
        '
        'tbbtnQuery
        '
        Me.tbbtnQuery.ImageIndex = 1
        Me.tbbtnQuery.Name = "tbbtnQuery"
        Me.tbbtnQuery.Text = "查看"
        Me.tbbtnQuery.ToolTipText = "查看"
        '
        'tbbtnAdd
        '
        Me.tbbtnAdd.ImageIndex = 2
        Me.tbbtnAdd.Name = "tbbtnAdd"
        Me.tbbtnAdd.Text = "反审"
        Me.tbbtnAdd.ToolTipText = "撤销审核生成的数据"
        '
        'tbbtnEdit
        '
        Me.tbbtnEdit.ImageIndex = 3
        Me.tbbtnEdit.Name = "tbbtnEdit"
        Me.tbbtnEdit.Text = "完船"
        Me.tbbtnEdit.ToolTipText = "完船"
        Me.tbbtnEdit.Visible = False
        '
        'tbbtnDelete
        '
        Me.tbbtnDelete.ImageIndex = 4
        Me.tbbtnDelete.Name = "tbbtnDelete"
        Me.tbbtnDelete.Text = "删除"
        Me.tbbtnDelete.ToolTipText = "删除"
        Me.tbbtnDelete.Visible = False
        '
        'tbbtnPrint
        '
        Me.tbbtnPrint.ImageIndex = 5
        Me.tbbtnPrint.Name = "tbbtnPrint"
        Me.tbbtnPrint.Text = "打印"
        Me.tbbtnPrint.ToolTipText = "打印"
        Me.tbbtnPrint.Visible = False
        '
        'tbbtnExport
        '
        Me.tbbtnExport.ImageIndex = 6
        Me.tbbtnExport.Name = "tbbtnExport"
        Me.tbbtnExport.Text = "单条打印"
        Me.tbbtnExport.ToolTipText = "导出Excel"
        Me.tbbtnExport.Visible = False
        '
        'tbbtupload
        '
        Me.tbbtupload.ImageIndex = 12
        Me.tbbtupload.Name = "tbbtupload"
        Me.tbbtupload.Text = "存储数据"
        Me.tbbtupload.ToolTipText = "存储数据"
        Me.tbbtupload.Visible = False
        '
        'tbbtnQuit
        '
        Me.tbbtnQuit.ImageIndex = 7
        Me.tbbtnQuit.Name = "tbbtnQuit"
        Me.tbbtnQuit.Text = "退出"
        Me.tbbtnQuit.ToolTipText = "退出"
        '
        'TabShipInfo
        '
        Me.TabShipInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabShipInfo.Controls.Add(Me.TabPage1)
        Me.TabShipInfo.Controls.Add(Me.TabTALLY_LIST)
        Me.TabShipInfo.Controls.Add(Me.TabWAIT)
        Me.TabShipInfo.Controls.Add(Me.TabWORK_RECORD)
        Me.TabShipInfo.Controls.Add(Me.TabDamaged)
        Me.TabShipInfo.Controls.Add(Me.TabShort)
        Me.TabShipInfo.Controls.Add(Me.TabMEASURE)
        Me.TabShipInfo.Controls.Add(Me.TabDaily)
        Me.TabShipInfo.Controls.Add(Me.TabDailyother)
        Me.TabShipInfo.Controls.Add(Me.TabCertificate)
        Me.TabShipInfo.Controls.Add(Me.TabFee)
        Me.TabShipInfo.Location = New System.Drawing.Point(6, 97)
        Me.TabShipInfo.Name = "TabShipInfo"
        Me.TabShipInfo.SelectedIndex = 0
        Me.TabShipInfo.Size = New System.Drawing.Size(640, 339)
        Me.TabShipInfo.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(632, 313)
        Me.TabPage1.TabIndex = 6
        Me.TabPage1.Text = "理货记录簿"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Infowgsj)
        Me.Panel2.Controls.Add(Me.Infokgsj)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Infozxg)
        Me.Panel2.Controls.Add(Me.Infops)
        Me.Panel2.Controls.Add(Me.Infosjds)
        Me.Panel2.Controls.Add(Me.Infohm)
        Me.Panel2.Controls.Add(Me.Infoqdds)
        Me.Panel2.Controls.Add(Me.Infosjjs)
        Me.Panel2.Controls.Add(Me.Infoqdjs)
        Me.Panel2.Location = New System.Drawing.Point(3, 136)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(611, 158)
        Me.Panel2.TabIndex = 1
        '
        'Infowgsj
        '
        Me.Infowgsj.AutoSize = True
        Me.Infowgsj.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Infowgsj.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infowgsj.Location = New System.Drawing.Point(91, 130)
        Me.Infowgsj.Name = "Infowgsj"
        Me.Infowgsj.Size = New System.Drawing.Size(0, 16)
        Me.Infowgsj.TabIndex = 1
        '
        'Infokgsj
        '
        Me.Infokgsj.AutoSize = True
        Me.Infokgsj.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Infokgsj.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infokgsj.Location = New System.Drawing.Point(91, 108)
        Me.Infokgsj.Name = "Infokgsj"
        Me.Infokgsj.Size = New System.Drawing.Size(0, 16)
        Me.Infokgsj.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label15.Location = New System.Drawing.Point(339, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "装卸港"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label14.Location = New System.Drawing.Point(47, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "票数"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label20.Location = New System.Drawing.Point(15, 130)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 16)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "完工时间"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label19.Location = New System.Drawing.Point(15, 108)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 16)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "开工时间"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.Location = New System.Drawing.Point(47, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "货名"
        Me.Label11.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label17.Location = New System.Drawing.Point(323, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 16)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "实际吨数"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "实际件数"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label16.Location = New System.Drawing.Point(323, 38)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 16)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "清单吨数"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 38)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "清单件数"
        '
        'Infozxg
        '
        Me.Infozxg.AutoSize = True
        Me.Infozxg.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Infozxg.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infozxg.Location = New System.Drawing.Point(413, 15)
        Me.Infozxg.Name = "Infozxg"
        Me.Infozxg.Size = New System.Drawing.Size(0, 16)
        Me.Infozxg.TabIndex = 0
        '
        'Infops
        '
        Me.Infops.AutoSize = True
        Me.Infops.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Infops.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infops.Location = New System.Drawing.Point(92, 15)
        Me.Infops.Name = "Infops"
        Me.Infops.Size = New System.Drawing.Size(0, 16)
        Me.Infops.TabIndex = 0
        '
        'Infosjds
        '
        Me.Infosjds.AutoSize = True
        Me.Infosjds.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Infosjds.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infosjds.Location = New System.Drawing.Point(413, 64)
        Me.Infosjds.Name = "Infosjds"
        Me.Infosjds.Size = New System.Drawing.Size(0, 16)
        Me.Infosjds.TabIndex = 0
        '
        'Infohm
        '
        Me.Infohm.AutoSize = True
        Me.Infohm.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Infohm.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infohm.Location = New System.Drawing.Point(92, 85)
        Me.Infohm.Name = "Infohm"
        Me.Infohm.Size = New System.Drawing.Size(0, 16)
        Me.Infohm.TabIndex = 0
        Me.Infohm.Visible = False
        '
        'Infoqdds
        '
        Me.Infoqdds.AutoSize = True
        Me.Infoqdds.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Infoqdds.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infoqdds.Location = New System.Drawing.Point(413, 38)
        Me.Infoqdds.Name = "Infoqdds"
        Me.Infoqdds.Size = New System.Drawing.Size(0, 16)
        Me.Infoqdds.TabIndex = 0
        '
        'Infosjjs
        '
        Me.Infosjjs.AutoSize = True
        Me.Infosjjs.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Infosjjs.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infosjjs.Location = New System.Drawing.Point(92, 64)
        Me.Infosjjs.Name = "Infosjjs"
        Me.Infosjjs.Size = New System.Drawing.Size(0, 16)
        Me.Infosjjs.TabIndex = 0
        '
        'Infoqdjs
        '
        Me.Infoqdjs.AutoSize = True
        Me.Infoqdjs.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Infoqdjs.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infoqdjs.Location = New System.Drawing.Point(92, 38)
        Me.Infoqdjs.Name = "Infoqdjs"
        Me.Infoqdjs.Size = New System.Drawing.Size(0, 16)
        Me.Infoqdjs.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Infobw)
        Me.Panel1.Controls.Add(Me.Infojck)
        Me.Panel1.Controls.Add(Me.Infohc)
        Me.Panel1.Controls.Add(Me.Infoywgj)
        Me.Panel1.Controls.Add(Me.Infoywcm)
        Me.Panel1.Controls.Add(Me.Infocd)
        Me.Panel1.Controls.Add(Me.Infozwgj)
        Me.Panel1.Controls.Add(Me.Infozwcm)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(3, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(611, 130)
        Me.Panel1.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "航次"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(32, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "进出口"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(355, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "泊位"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(323, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "英文国籍"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "英文船名"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(355, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "船代"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(323, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "中文国籍"
        '
        'Infobw
        '
        Me.Infobw.AutoSize = True
        Me.Infobw.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Infobw.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infobw.Location = New System.Drawing.Point(413, 80)
        Me.Infobw.Name = "Infobw"
        Me.Infobw.Size = New System.Drawing.Size(0, 16)
        Me.Infobw.TabIndex = 0
        '
        'Infojck
        '
        Me.Infojck.AutoSize = True
        Me.Infojck.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Infojck.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infojck.Location = New System.Drawing.Point(92, 80)
        Me.Infojck.Name = "Infojck"
        Me.Infojck.Size = New System.Drawing.Size(0, 16)
        Me.Infojck.TabIndex = 0
        '
        'Infohc
        '
        Me.Infohc.AutoSize = True
        Me.Infohc.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Infohc.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infohc.Location = New System.Drawing.Point(93, 105)
        Me.Infohc.Name = "Infohc"
        Me.Infohc.Size = New System.Drawing.Size(0, 16)
        Me.Infohc.TabIndex = 0
        '
        'Infoywgj
        '
        Me.Infoywgj.AutoSize = True
        Me.Infoywgj.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Infoywgj.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infoywgj.Location = New System.Drawing.Point(413, 54)
        Me.Infoywgj.Name = "Infoywgj"
        Me.Infoywgj.Size = New System.Drawing.Size(0, 16)
        Me.Infoywgj.TabIndex = 0
        '
        'Infoywcm
        '
        Me.Infoywcm.AutoSize = True
        Me.Infoywcm.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Infoywcm.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infoywcm.Location = New System.Drawing.Point(92, 54)
        Me.Infoywcm.Name = "Infoywcm"
        Me.Infoywcm.Size = New System.Drawing.Size(0, 16)
        Me.Infoywcm.TabIndex = 0
        '
        'Infocd
        '
        Me.Infocd.AutoSize = True
        Me.Infocd.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Infocd.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infocd.Location = New System.Drawing.Point(413, 105)
        Me.Infocd.Name = "Infocd"
        Me.Infocd.Size = New System.Drawing.Size(0, 16)
        Me.Infocd.TabIndex = 0
        '
        'Infozwgj
        '
        Me.Infozwgj.AutoSize = True
        Me.Infozwgj.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Infozwgj.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infozwgj.Location = New System.Drawing.Point(413, 30)
        Me.Infozwgj.Name = "Infozwgj"
        Me.Infozwgj.Size = New System.Drawing.Size(0, 16)
        Me.Infozwgj.TabIndex = 0
        '
        'Infozwcm
        '
        Me.Infozwcm.AutoSize = True
        Me.Infozwcm.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Infozwcm.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infozwcm.Location = New System.Drawing.Point(92, 30)
        Me.Infozwcm.Name = "Infozwcm"
        Me.Infozwcm.Size = New System.Drawing.Size(0, 16)
        Me.Infozwcm.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "中文船名"
        '
        'TabTALLY_LIST
        '
        Me.TabTALLY_LIST.BackColor = System.Drawing.Color.Transparent
        Me.TabTALLY_LIST.Controls.Add(Me.C1DBGTALLY_LIST)
        Me.TabTALLY_LIST.Location = New System.Drawing.Point(4, 22)
        Me.TabTALLY_LIST.Name = "TabTALLY_LIST"
        Me.TabTALLY_LIST.Size = New System.Drawing.Size(632, 313)
        Me.TabTALLY_LIST.TabIndex = 0
        Me.TabTALLY_LIST.Text = "计数单"
        Me.TabTALLY_LIST.UseVisualStyleBackColor = True
        '
        'C1DBGTALLY_LIST
        '
        Me.C1DBGTALLY_LIST.AllowFilter = False
        Me.C1DBGTALLY_LIST.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGTALLY_LIST.AllowUpdate = False
        Me.C1DBGTALLY_LIST.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGTALLY_LIST.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGTALLY_LIST.Images.Add(CType(resources.GetObject("C1DBGTALLY_LIST.Images"), System.Drawing.Image))
        Me.C1DBGTALLY_LIST.Location = New System.Drawing.Point(2, 2)
        Me.C1DBGTALLY_LIST.Name = "C1DBGTALLY_LIST"
        Me.C1DBGTALLY_LIST.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGTALLY_LIST.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGTALLY_LIST.PreviewInfo.ZoomFactor = 75
        Me.C1DBGTALLY_LIST.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGTALLY_LIST.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGTALLY_LIST.Size = New System.Drawing.Size(392, 226)
        Me.C1DBGTALLY_LIST.TabIndex = 11
        Me.C1DBGTALLY_LIST.Text = "C1DBG"
        Me.C1DBGTALLY_LIST.PropBag = resources.GetString("C1DBGTALLY_LIST.PropBag")
        '
        'TabWAIT
        '
        Me.TabWAIT.BackColor = System.Drawing.Color.Transparent
        Me.TabWAIT.Controls.Add(Me.C1DBGWAIT)
        Me.TabWAIT.Location = New System.Drawing.Point(4, 22)
        Me.TabWAIT.Name = "TabWAIT"
        Me.TabWAIT.Size = New System.Drawing.Size(632, 313)
        Me.TabWAIT.TabIndex = 1
        Me.TabWAIT.Text = "待时记录"
        Me.TabWAIT.UseVisualStyleBackColor = True
        '
        'C1DBGWAIT
        '
        Me.C1DBGWAIT.AllowFilter = False
        Me.C1DBGWAIT.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGWAIT.AllowUpdate = False
        Me.C1DBGWAIT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGWAIT.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGWAIT.Images.Add(CType(resources.GetObject("C1DBGWAIT.Images"), System.Drawing.Image))
        Me.C1DBGWAIT.Location = New System.Drawing.Point(2, 2)
        Me.C1DBGWAIT.Name = "C1DBGWAIT"
        Me.C1DBGWAIT.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGWAIT.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGWAIT.PreviewInfo.ZoomFactor = 75
        Me.C1DBGWAIT.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGWAIT.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGWAIT.Size = New System.Drawing.Size(392, 226)
        Me.C1DBGWAIT.TabIndex = 12
        Me.C1DBGWAIT.Text = "C1DBG"
        Me.C1DBGWAIT.PropBag = resources.GetString("C1DBGWAIT.PropBag")
        '
        'TabWORK_RECORD
        '
        Me.TabWORK_RECORD.BackColor = System.Drawing.Color.Transparent
        Me.TabWORK_RECORD.Controls.Add(Me.C1DBGWORK_RECORD)
        Me.TabWORK_RECORD.Location = New System.Drawing.Point(4, 22)
        Me.TabWORK_RECORD.Name = "TabWORK_RECORD"
        Me.TabWORK_RECORD.Size = New System.Drawing.Size(632, 313)
        Me.TabWORK_RECORD.TabIndex = 2
        Me.TabWORK_RECORD.Text = "现场记录"
        Me.TabWORK_RECORD.UseVisualStyleBackColor = True
        '
        'C1DBGWORK_RECORD
        '
        Me.C1DBGWORK_RECORD.AllowFilter = False
        Me.C1DBGWORK_RECORD.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGWORK_RECORD.AllowUpdate = False
        Me.C1DBGWORK_RECORD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGWORK_RECORD.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGWORK_RECORD.Images.Add(CType(resources.GetObject("C1DBGWORK_RECORD.Images"), System.Drawing.Image))
        Me.C1DBGWORK_RECORD.Location = New System.Drawing.Point(2, 2)
        Me.C1DBGWORK_RECORD.Name = "C1DBGWORK_RECORD"
        Me.C1DBGWORK_RECORD.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGWORK_RECORD.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGWORK_RECORD.PreviewInfo.ZoomFactor = 75
        Me.C1DBGWORK_RECORD.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGWORK_RECORD.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGWORK_RECORD.Size = New System.Drawing.Size(384, 200)
        Me.C1DBGWORK_RECORD.TabIndex = 12
        Me.C1DBGWORK_RECORD.Text = "C1DBG"
        Me.C1DBGWORK_RECORD.PropBag = resources.GetString("C1DBGWORK_RECORD.PropBag")
        '
        'TabDamaged
        '
        Me.TabDamaged.Controls.Add(Me.C1DBGDamaged)
        Me.TabDamaged.Location = New System.Drawing.Point(4, 22)
        Me.TabDamaged.Name = "TabDamaged"
        Me.TabDamaged.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDamaged.Size = New System.Drawing.Size(632, 313)
        Me.TabDamaged.TabIndex = 10
        Me.TabDamaged.Text = "残损单"
        Me.TabDamaged.UseVisualStyleBackColor = True
        '
        'C1DBGDamaged
        '
        Me.C1DBGDamaged.AllowFilter = False
        Me.C1DBGDamaged.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGDamaged.AllowUpdate = False
        Me.C1DBGDamaged.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBGDamaged.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGDamaged.Images.Add(CType(resources.GetObject("C1DBGDamaged.Images"), System.Drawing.Image))
        Me.C1DBGDamaged.Location = New System.Drawing.Point(3, 3)
        Me.C1DBGDamaged.Name = "C1DBGDamaged"
        Me.C1DBGDamaged.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGDamaged.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGDamaged.PreviewInfo.ZoomFactor = 75
        Me.C1DBGDamaged.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGDamaged.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGDamaged.Size = New System.Drawing.Size(626, 307)
        Me.C1DBGDamaged.TabIndex = 13
        Me.C1DBGDamaged.Text = "C1DBG"
        Me.C1DBGDamaged.PropBag = resources.GetString("C1DBGDamaged.PropBag")
        '
        'TabShort
        '
        Me.TabShort.Controls.Add(Me.C1DBGShort)
        Me.TabShort.Location = New System.Drawing.Point(4, 22)
        Me.TabShort.Name = "TabShort"
        Me.TabShort.Size = New System.Drawing.Size(632, 313)
        Me.TabShort.TabIndex = 9
        Me.TabShort.Text = "溢短单"
        Me.TabShort.UseVisualStyleBackColor = True
        '
        'C1DBGShort
        '
        Me.C1DBGShort.AllowFilter = False
        Me.C1DBGShort.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGShort.AllowUpdate = False
        Me.C1DBGShort.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBGShort.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGShort.Images.Add(CType(resources.GetObject("C1DBGShort.Images"), System.Drawing.Image))
        Me.C1DBGShort.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGShort.Name = "C1DBGShort"
        Me.C1DBGShort.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGShort.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGShort.PreviewInfo.ZoomFactor = 75
        Me.C1DBGShort.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGShort.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGShort.Size = New System.Drawing.Size(632, 313)
        Me.C1DBGShort.TabIndex = 12
        Me.C1DBGShort.Text = "C1DBG"
        Me.C1DBGShort.PropBag = resources.GetString("C1DBGShort.PropBag")
        '
        'TabMEASURE
        '
        Me.TabMEASURE.BackColor = System.Drawing.Color.Transparent
        Me.TabMEASURE.Controls.Add(Me.C1DBGMEASURE)
        Me.TabMEASURE.Location = New System.Drawing.Point(4, 22)
        Me.TabMEASURE.Name = "TabMEASURE"
        Me.TabMEASURE.Size = New System.Drawing.Size(632, 313)
        Me.TabMEASURE.TabIndex = 3
        Me.TabMEASURE.Text = "丈量单"
        Me.TabMEASURE.UseVisualStyleBackColor = True
        '
        'C1DBGMEASURE
        '
        Me.C1DBGMEASURE.AllowFilter = False
        Me.C1DBGMEASURE.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGMEASURE.AllowUpdate = False
        Me.C1DBGMEASURE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGMEASURE.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGMEASURE.Images.Add(CType(resources.GetObject("C1DBGMEASURE.Images"), System.Drawing.Image))
        Me.C1DBGMEASURE.Location = New System.Drawing.Point(2, 2)
        Me.C1DBGMEASURE.Name = "C1DBGMEASURE"
        Me.C1DBGMEASURE.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGMEASURE.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGMEASURE.PreviewInfo.ZoomFactor = 75
        Me.C1DBGMEASURE.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGMEASURE.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGMEASURE.Size = New System.Drawing.Size(392, 226)
        Me.C1DBGMEASURE.TabIndex = 12
        Me.C1DBGMEASURE.Text = "C1DBG"
        Me.C1DBGMEASURE.PropBag = resources.GetString("C1DBGMEASURE.PropBag")
        '
        'TabDaily
        '
        Me.TabDaily.BackColor = System.Drawing.Color.Transparent
        Me.TabDaily.Controls.Add(Me.C1DBGDaily_report)
        Me.TabDaily.Controls.Add(Me.Panel3)
        Me.TabDaily.Location = New System.Drawing.Point(4, 22)
        Me.TabDaily.Name = "TabDaily"
        Me.TabDaily.Size = New System.Drawing.Size(632, 313)
        Me.TabDaily.TabIndex = 4
        Me.TabDaily.Text = "日报"
        Me.TabDaily.UseVisualStyleBackColor = True
        '
        'C1DBGDaily_report
        '
        Me.C1DBGDaily_report.AllowFilter = False
        Me.C1DBGDaily_report.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGDaily_report.AllowUpdate = False
        Me.C1DBGDaily_report.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGDaily_report.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGDaily_report.Images.Add(CType(resources.GetObject("C1DBGDaily_report.Images"), System.Drawing.Image))
        Me.C1DBGDaily_report.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGDaily_report.Name = "C1DBGDaily_report"
        Me.C1DBGDaily_report.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGDaily_report.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGDaily_report.PreviewInfo.ZoomFactor = 75
        Me.C1DBGDaily_report.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGDaily_report.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGDaily_report.Size = New System.Drawing.Size(392, 195)
        Me.C1DBGDaily_report.TabIndex = 12
        Me.C1DBGDaily_report.Text = "C1DBG"
        Me.C1DBGDaily_report.PropBag = resources.GetString("C1DBGDaily_report.PropBag")
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.cmbreport)
        Me.Panel3.Controls.Add(Me.labreport)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(632, 10)
        Me.Panel3.TabIndex = 13
        Me.Panel3.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(300, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "查看"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbreport
        '
        Me.cmbreport.FormattingEnabled = True
        Me.cmbreport.Location = New System.Drawing.Point(191, 25)
        Me.cmbreport.Name = "cmbreport"
        Me.cmbreport.Size = New System.Drawing.Size(87, 20)
        Me.cmbreport.TabIndex = 1
        '
        'labreport
        '
        Me.labreport.AutoSize = True
        Me.labreport.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.labreport.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.labreport.Location = New System.Drawing.Point(26, 26)
        Me.labreport.Name = "labreport"
        Me.labreport.Size = New System.Drawing.Size(128, 16)
        Me.labreport.TabIndex = 0
        Me.labreport.Text = "共有日报 0 份　"
        '
        'TabDailyother
        '
        Me.TabDailyother.BackColor = System.Drawing.Color.Transparent
        Me.TabDailyother.Controls.Add(Me.C1DBGDaily_other)
        Me.TabDailyother.Controls.Add(Me.Panel4)
        Me.TabDailyother.Location = New System.Drawing.Point(4, 22)
        Me.TabDailyother.Name = "TabDailyother"
        Me.TabDailyother.Size = New System.Drawing.Size(632, 313)
        Me.TabDailyother.TabIndex = 5
        Me.TabDailyother.Text = "翻舱日报"
        Me.TabDailyother.UseVisualStyleBackColor = True
        '
        'C1DBGDaily_other
        '
        Me.C1DBGDaily_other.AllowFilter = False
        Me.C1DBGDaily_other.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGDaily_other.AllowUpdate = False
        Me.C1DBGDaily_other.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGDaily_other.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGDaily_other.Images.Add(CType(resources.GetObject("C1DBGDaily_other.Images"), System.Drawing.Image))
        Me.C1DBGDaily_other.Location = New System.Drawing.Point(1, 0)
        Me.C1DBGDaily_other.Name = "C1DBGDaily_other"
        Me.C1DBGDaily_other.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGDaily_other.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGDaily_other.PreviewInfo.ZoomFactor = 75
        Me.C1DBGDaily_other.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGDaily_other.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGDaily_other.Size = New System.Drawing.Size(392, 226)
        Me.C1DBGDaily_other.TabIndex = 13
        Me.C1DBGDaily_other.Text = "C1DBG"
        Me.C1DBGDaily_other.PropBag = resources.GetString("C1DBGDaily_other.PropBag")
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.Cmbflag)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.cmbreportOth)
        Me.Panel4.Controls.Add(Me.labreportOth)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(632, 10)
        Me.Panel4.TabIndex = 14
        Me.Panel4.Visible = False
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(107, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 24)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "翻舱类型"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cmbflag
        '
        Me.Cmbflag.Items.AddRange(New Object() {"", "出舱", "重装"})
        Me.Cmbflag.Location = New System.Drawing.Point(190, 19)
        Me.Cmbflag.Name = "Cmbflag"
        Me.Cmbflag.Size = New System.Drawing.Size(87, 20)
        Me.Cmbflag.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(298, 43)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "查看"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmbreportOth
        '
        Me.cmbreportOth.FormattingEnabled = True
        Me.cmbreportOth.Location = New System.Drawing.Point(190, 45)
        Me.cmbreportOth.Name = "cmbreportOth"
        Me.cmbreportOth.Size = New System.Drawing.Size(87, 20)
        Me.cmbreportOth.TabIndex = 1
        '
        'labreportOth
        '
        Me.labreportOth.AutoSize = True
        Me.labreportOth.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.labreportOth.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.labreportOth.Location = New System.Drawing.Point(25, 46)
        Me.labreportOth.Name = "labreportOth"
        Me.labreportOth.Size = New System.Drawing.Size(160, 16)
        Me.labreportOth.TabIndex = 0
        Me.labreportOth.Text = "共有翻舱日报 0 份　"
        '
        'TabCertificate
        '
        Me.TabCertificate.BackColor = System.Drawing.Color.Transparent
        Me.TabCertificate.Controls.Add(Me.C1DBGCertificate)
        Me.TabCertificate.Location = New System.Drawing.Point(4, 22)
        Me.TabCertificate.Name = "TabCertificate"
        Me.TabCertificate.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCertificate.Size = New System.Drawing.Size(632, 313)
        Me.TabCertificate.TabIndex = 7
        Me.TabCertificate.Text = "理货凭证"
        Me.TabCertificate.UseVisualStyleBackColor = True
        '
        'C1DBGCertificate
        '
        Me.C1DBGCertificate.AllowFilter = False
        Me.C1DBGCertificate.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGCertificate.AllowUpdate = False
        Me.C1DBGCertificate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGCertificate.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGCertificate.Images.Add(CType(resources.GetObject("C1DBGCertificate.Images"), System.Drawing.Image))
        Me.C1DBGCertificate.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGCertificate.Name = "C1DBGCertificate"
        Me.C1DBGCertificate.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGCertificate.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGCertificate.PreviewInfo.ZoomFactor = 75
        Me.C1DBGCertificate.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGCertificate.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGCertificate.Size = New System.Drawing.Size(581, 307)
        Me.C1DBGCertificate.TabIndex = 13
        Me.C1DBGCertificate.Text = "C1DBG"
        Me.C1DBGCertificate.PropBag = resources.GetString("C1DBGCertificate.PropBag")
        '
        'TabFee
        '
        Me.TabFee.Controls.Add(Me.C1DBG)
        Me.TabFee.Location = New System.Drawing.Point(4, 22)
        Me.TabFee.Name = "TabFee"
        Me.TabFee.Size = New System.Drawing.Size(632, 313)
        Me.TabFee.TabIndex = 8
        Me.TabFee.Text = "标准账单"
        Me.TabFee.UseVisualStyleBackColor = True
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("C1DBG.Images"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG.Size = New System.Drawing.Size(632, 313)
        Me.C1DBG.TabIndex = 2
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = resources.GetString("C1DBG.PropBag")
        '
        'LabREMARKS
        '
        Me.LabREMARKS.ForeColor = System.Drawing.Color.Red
        Me.LabREMARKS.Location = New System.Drawing.Point(6, 98)
        Me.LabREMARKS.Name = "LabREMARKS"
        Me.LabREMARKS.Size = New System.Drawing.Size(563, 24)
        Me.LabREMARKS.TabIndex = 12
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.SystemColors.Control
        Me.Label.Location = New System.Drawing.Point(6, 60)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(698, 34)
        Me.Label.TabIndex = 11
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuCompile, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFind, Me.mnuQuery, Me.mnuSep1, Me.mnuPrint, Me.mnuExport, Me.mnuSep2, Me.mnuQuit})
        Me.mnuFile.Text = "文件(&F)"
        '
        'mnuFind
        '
        Me.mnuFind.Enabled = False
        Me.mnuFind.Index = 0
        Me.mnuFind.Text = "检索(&F)"
        '
        'mnuQuery
        '
        Me.mnuQuery.Enabled = False
        Me.mnuQuery.Index = 1
        Me.mnuQuery.Text = "查看(&Q)"
        '
        'mnuSep1
        '
        Me.mnuSep1.Index = 2
        Me.mnuSep1.Text = "-"
        '
        'mnuPrint
        '
        Me.mnuPrint.Enabled = False
        Me.mnuPrint.Index = 3
        Me.mnuPrint.Text = "打印(&P)..."
        '
        'mnuExport
        '
        Me.mnuExport.Enabled = False
        Me.mnuExport.Index = 4
        Me.mnuExport.Text = "导出(&E)"
        '
        'mnuSep2
        '
        Me.mnuSep2.Index = 5
        Me.mnuSep2.Text = "-"
        '
        'mnuQuit
        '
        Me.mnuQuit.Index = 6
        Me.mnuQuit.Text = "退出(&X)"
        '
        'mnuCompile
        '
        Me.mnuCompile.Index = 1
        Me.mnuCompile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAdd, Me.mnuEdit, Me.mnuDelete})
        Me.mnuCompile.Text = "编辑(&E)"
        '
        'mnuAdd
        '
        Me.mnuAdd.Enabled = False
        Me.mnuAdd.Index = 0
        Me.mnuAdd.Text = "增加(&A)"
        '
        'mnuEdit
        '
        Me.mnuEdit.Enabled = False
        Me.mnuEdit.Index = 1
        Me.mnuEdit.Text = "编辑(&E)"
        '
        'mnuDelete
        '
        Me.mnuDelete.Enabled = False
        Me.mnuDelete.Index = 2
        Me.mnuDelete.Text = "删除(&D)"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.Text = "帮助(&H)"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem9, Me.MenuItem13})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7, Me.MenuItem8})
        Me.MenuItem1.Text = "文件(&F)"
        '
        'MenuItem2
        '
        Me.MenuItem2.Enabled = False
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "检索(&F)"
        '
        'MenuItem3
        '
        Me.MenuItem3.Enabled = False
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "查看(&Q)"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Enabled = False
        Me.MenuItem5.Index = 3
        Me.MenuItem5.Text = "打印(&P)..."
        '
        'MenuItem6
        '
        Me.MenuItem6.Enabled = False
        Me.MenuItem6.Index = 4
        Me.MenuItem6.Text = "导出(&E)"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 5
        Me.MenuItem7.Text = "-"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 6
        Me.MenuItem8.Text = "退出(&X)"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 1
        Me.MenuItem9.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem10, Me.MenuItem11, Me.MenuItem12})
        Me.MenuItem9.Text = "编辑(&E)"
        '
        'MenuItem10
        '
        Me.MenuItem10.Enabled = False
        Me.MenuItem10.Index = 0
        Me.MenuItem10.Text = "增加(&A)"
        '
        'MenuItem11
        '
        Me.MenuItem11.Enabled = False
        Me.MenuItem11.Index = 1
        Me.MenuItem11.Text = "编辑(&E)"
        '
        'MenuItem12
        '
        Me.MenuItem12.Enabled = False
        Me.MenuItem12.Index = 2
        Me.MenuItem12.Text = "删除(&D)"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 2
        Me.MenuItem13.Text = "帮助(&H)"
        '
        'FrmCargo_verify
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(824, 439)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.GBV)
        Me.Menu = Me.MainMenu1
        Me.Name = "FrmCargo_verify"
        Me.Text = "数据审核"
        Me.GBV.ResumeLayout(False)
        Me.GBV.PerformLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        Me.TabShipInfo.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabTALLY_LIST.ResumeLayout(False)
        CType(Me.C1DBGTALLY_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabWAIT.ResumeLayout(False)
        CType(Me.C1DBGWAIT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabWORK_RECORD.ResumeLayout(False)
        CType(Me.C1DBGWORK_RECORD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabDamaged.ResumeLayout(False)
        CType(Me.C1DBGDamaged, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabShort.ResumeLayout(False)
        CType(Me.C1DBGShort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMEASURE.ResumeLayout(False)
        CType(Me.C1DBGMEASURE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabDaily.ResumeLayout(False)
        CType(Me.C1DBGDaily_report, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabDailyother.ResumeLayout(False)
        CType(Me.C1DBGDaily_other, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TabCertificate.ResumeLayout(False)
        CType(Me.C1DBGCertificate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabFee.ResumeLayout(False)
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim dsShip As New DataSet   '船舶数据集
    Dim SqlStrShip As String  '船舶条件语句
    Dim FirmShip As String
    Dim SortShip As String
    Dim inoutstr As String
    Dim dshatch As New DataSet
    Dim dwhatch As New DataView

    Dim dsTally_List As New DataSet '计数单
    Dim dsWait As New DataSet        '待时记录
    Dim dsWork_Record As New DataSet '现场记录
    Dim dsMeasure As New DataSet     '丈量单 
    Dim dsShort As New DataSet
    Dim dsDamaged As New DataSet
    Dim dsfee As New DataSet

    Dim SqlStr As String  '条件语句
    Dim SelectStr As String
    Dim DynaStr As String '可变的条件设计
    Dim FirmStr As String '不变的条件设计
    ', FirmTally, FirmWait, FirmWorkRecord, FirmMeasure, FirmDaily
    Dim ColNum As Integer '不显示的列数
    Dim SHIFTING_Flag As Integer '翻舱标示
    Dim aorb As String

    Dim gbno As String
    Dim lastgb As String
    Dim reportid As String
    Dim reportidpre As String
    Dim dsreport As New DataSet
    Dim dsrpt As New DataSet
    Dim gbnoOth As String
    Dim lastgbOth As String
    Dim reportidOth As String
    Dim reportidpreOth As String
    Dim dsreportOth As New DataSet
    Dim dsrptOth As New DataSet
    Dim shipstatu As String

    Private Sub FrmCargo_verify_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SHIFTING_Flag = 0
        Me.WindowState = FormWindowState.Maximized
        Me.Text = Me.Text & "_" & G_DeptName
        SortShip = " Order by Ship_Statu,Dept_Code,id desc "
        FirmShip = "where DEPT_CODE LIKE '" & G_DeptCode & "%' and code_goods<>'2' "
        SqlStrShip = "where (DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('0','3')) and code_goods<>'2' " ' OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) "
        Call myDataGridShip(SqlStrShip & inoutstr & SortShip)
        Me.C1DBGV.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        txtShipName.Text = G_ShipName
        txtVoyage.Text = G_Voyage
        'Call btResure_Click(sender, e)
    End Sub

    Private Sub myDataGridShip(ByVal Sql As String) '**************航次信息
        Dim strsql As String
        Dim i As Integer
        strsql = "select SHIP_ID as ID ,SHIP_STATU,INOUTPORT,DEPT_CODE,ENG_VESSEL,CHI_VESSEL,VOYAGE,InOutPort_Name,Dept_Short from View_SSHip " '船舶条件语句 不改部分
        strsql = strsql & Sql
        Try
            Me.C1DBGV.DataSource = Getdata(strsql, dsShip)
            For i = 0 To 4
                Me.C1DBGV.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Call SetColumnCaptionShip() '设计列标题
            Call SetColumnWidthShip() '设计列宽度
            If dsShip.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumShip(5)  '设计合计列
            End If
            Me.C1DBGV.FetchRowStyles = True
            Me.C1DBGV.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaptionShip() '*****************航次标题
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Try
            str = "select Field_Eng,Field_Cha From Field_Att where Table_Name='View_SSHip'"
            sqlconn.ConnectionString = conn
            sqlc.Connection = sqlconn
            sqlc.CommandText = str
            sqla.SelectCommand = sqlc
            dset.Reset()
            sqla.Fill(dset)
            i = 4

            Do While i < Me.C1DBGV.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGV.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBGV.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
                        Exit For
                    End If
                Next
                i = i + 1
            Loop
            sqlconn.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnWidthShip() '************航次列宽
        Dim i As Integer
        Try
            Me.C1DBGV.Splits(0).DisplayColumns.Item(4).Width = Me.C1DBGV.Width / 2 - 25
            Me.C1DBGV.Splits(0).DisplayColumns.Item(5).Width = Me.C1DBGV.Width / 2 - 25
            Me.C1DBGV.Splits(0).DisplayColumns.Item(6).Width = 35
            Me.C1DBGV.Splits(0).DisplayColumns.Item(7).Width = 24
            Me.C1DBGV.Splits(0).DisplayColumns.Item(8).Width = 18
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnSumShip(ByVal Col As Integer) '****************航次汇总行
        Me.C1DBGV.ColumnFooters = True
        Me.C1DBGV.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGV.Columns.Item(Col).FooterText = "共 " & dsShip.Tables(0).Rows.Count & " 条"
    End Sub

    Private Sub ToolBarV_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBarV.ButtonClick
        Select Case Me.ToolBarV.Buttons.IndexOf(e.Button)
            Case 1
                SqlStrShip = "where (DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('0','3'))  and code_goods<>'2' " 'OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) " '船舶可变的条件设计
                SortShip = " Order by Ship_Statu,Dept_Code,id desc "
                Call myDataGridShip(SqlStrShip & inoutstr & SortShip)

            Case 3
                Dim FrmFind As New FrmFind
                Table_Name = "SSHIP"
                FrmFind.ShowDialog()
                If Flag = 0 Then
                    Call myDataGridShip(FirmShip & inoutstr & " and (" & Sql_Find & ")  " & SortShip)    '可能要修改
                    SqlStrShip = FirmStr & " and (" & Sql_Find & ")  "    '可能要修改
                ElseIf Flag = 2 Then
                    SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('0','1','2','3','4')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0))  and code_goods<>'2' "
                    '可能要修改
                    Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '可能要修改
                End If

            Case 5
                Dim FrmSort As New FrmSort
                FrmSort.ShowDialog()
                If Len(Trim(SortStr)) > 0 Then
                    SortShip = " Order by " & SortStr
                End If
                Call myDataGridShip(SqlStrShip & inoutstr & SortShip)

            Case 7
                Me.C1DBGV.Splits(0).DisplayColumns.Item(4).Visible = True
                Me.C1DBGV.Splits(0).DisplayColumns.Item(5).Visible = False
                If dsShip.Tables(0).Rows.Count > 0 Then
                    Call SetColumnSumShip(4)  '设计合计列
                End If
                Me.C1DBGV.FetchRowStyles = True
                Me.C1DBGV.Refresh()
        End Select
    End Sub

    Private Sub C1DBGV_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBGV.FetchRowStyle
        Try
            If Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 1 Then
                e.CellStyle.BackColor = Color.White
            ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 2 Then
                e.CellStyle.BackColor = Color.PaleGreen
            ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 3 Then
                e.CellStyle.BackColor = Color.LemonChiffon
            ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 4 Then
                e.CellStyle.BackColor = Color.Pink
            ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 5 Then
                e.CellStyle.BackColor = Color.Red
            ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 0 Then
                e.CellStyle.BackColor = Color.Cyan
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub C1DBGV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBGV.DoubleClick
        On Error GoTo Err
        Dim strsql As String
        Dim dsShip As New DataSet
        Dim dw As New DataView
        Ship_ID = CType(Me.C1DBGV.Columns.Item("ID").Text.ToString, Integer)
        strsql = "select * from View_SSHIP where SHIP_ID=" & Ship_ID
        dw = Getdata(strsql, dsShip)
        Label.Text = ""
        If dsShip.Tables(0).DefaultView.Count > 0 Then
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))) > 0 Then
                Label.Text = Label.Text & "中文船名:" & Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL")) & " "
                G_ShipName = Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))
                txtShipName.Text = Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL"))) > 0 Then
                Label.Text = Label.Text & "英文船名:" & Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))) > 0 Then
                Label.Text = Label.Text & "航次:" & Trim(dsShip.Tables(0).Rows(0).Item("Voyage")) & " "
                G_Voyage = Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))
                txtVoyage.Text = Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("InOutPort_Name"))) > 0 Then
                Label.Text = Label.Text & "进出口:" & Trim(dsShip.Tables(0).Rows(0).Item("InOutPort_Name")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Trade"))) > 0 Then
                Label.Text = Label.Text & "内外贸:" & Trim(dsShip.Tables(0).Rows(0).Item("Trade")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("SHIP_TYPE"))) > 0 Then
                Label.Text = Label.Text & "国外轮:" & Trim(dsShip.Tables(0).Rows(0).Item("SHIP_TYPE")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("SHIPAGENT_CHAE"))) > 0 Then
                Label.Text = Label.Text & "船代:" & Trim(dsShip.Tables(0).Rows(0).Item("SHIPAGENT_CHA")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("GOODS"))) > 0 Then
                Label.Text = Label.Text & "货名:" & Trim(dsShip.Tables(0).Rows(0).Item("GOODS")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Tons"))) > 0 Then
                Label.Text = Label.Text & "吨数:" & Trim(dsShip.Tables(0).Rows(0).Item("Tons")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("BerthNo"))) > 0 Then
                Label.Text = Label.Text & "泊位:" & Trim(dsShip.Tables(0).Rows(0).Item("BerthNo")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("File_No"))) > 0 Then
                Label.Text = Label.Text & "档案号:" & Trim(dsShip.Tables(0).Rows(0).Item("File_No")) & " "
            End If
            shipstatu = dsShip.Tables(0).Rows(0).Item("ship_statu")
        End If

        FirmStr = "  Ship_ID=" & Ship_ID & " Order by ID " '设计初始条件  在检索后不改变的条件  '***************要修改 或 2>1
        DynaStr = " 2>1 " '设计其它初始条件    在检索后不需要的条件 ***************要修改 或 其它条件
        SelectStr = " " ' " Top 20 "
        SqlStr = " (" & DynaStr & ")  " & " and " & FirmStr
        Dim dsinoutport As New DataSet
        Dim dwinoutport As New DataView
        dwinoutport = Getdata("select inoutport from sship where ship_id='" & Ship_ID & "'", dsinoutport)
        If dsinoutport.Tables(0).Rows.Count > 0 Then
            Hatch_in = dsinoutport.Tables(0).Rows(0).Item("inoutport")
        End If

        GL_hatch = 0
        dwhatch = Getdata("SELECT HATCH FROM VESSEL INNER JOIN SSHIP ON VESSEL.VESSEL_ID = SSHIP.V_ID WHERE SHIP_ID ='" & Ship_ID & "' ", dshatch)
        GL_hatch = dwhatch(0)(0)

        Me.ToolBar.Enabled = True
        Me.mnuAdd.Enabled = True
        Me.mnuDelete.Enabled = True
        Me.mnuEdit.Enabled = True
        Me.mnuExport.Enabled = True
        Me.mnuFind.Enabled = True
        Me.mnuPrint.Enabled = True
        Me.mnuQuery.Enabled = True
        'Call preview("WL4_1")
        Call TabControl1_Click(sender, e)
        Call getlhjl()
        Call getTallylist(FirmStr)      '计数单
        Call getwait(FirmStr)           '待时记录
        Call getworkrecord(FirmStr)     '现场记录
        Call getmeasure(FirmStr)        '丈量单
        Call getShort(FirmStr)          '溢短单
        Call getDamaged(FirmStr)        '残损单
        'Call getdailyreportHis()
        'Call getdailyreportHisOth()
        getCertificate()

        dsdaily.Reset()    '日报
        OKMARK = "0"
        LabREMARKS.Text = ""
        REMARKS = ""
        trade = ""
        ds_sship.Reset()
        dw = Getdata("select * from view_outhatch_sship where ship_id='" & Ship_ID & "'", ds_sship)
        If ds_sship.Tables(0).Rows.Count > 0 Then
            trade = ds_sship.Tables(0).Rows(0).Item("s_trade")
        End If
        If Trim(dsShip.Tables(0).Rows(0).Item("InOutPort_Name")) = "出口" Then
            Hatch_in = 1
        Else
            Hatch_in = 0
        End If
        Dim str_sql As String
        str_sql = String.Format("exec SPCARGO_DAILY_REPORT_query {0}", Ship_ID)
        ExecSql(str_sql)
        getdailyreport()
        getdailyreport_other()
        getfee()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub getlhjl()
        On Error GoTo Err
        clearinfo()
        Dim dsinfoverify As New DataSet
        Getdata("infoverify " & Ship_ID, dsinfoverify)
        Infozwcm.Text = Trim(dsinfoverify.Tables(1).Rows(0).Item("zwcm"))
        Infoywcm.Text = Trim(dsinfoverify.Tables(1).Rows(0).Item("ywcm"))
        Infojck.Text = Trim(dsinfoverify.Tables(1).Rows(0).Item("jck"))
        Infozwgj.Text = Trim(dsinfoverify.Tables(1).Rows(0).Item("zwgj"))
        Infoywgj.Text = Trim(dsinfoverify.Tables(1).Rows(0).Item("ywgj"))
        Infobw.Text = Trim(dsinfoverify.Tables(1).Rows(0).Item("bw"))
        Infocd.Text = Trim(dsinfoverify.Tables(1).Rows(0).Item("cd"))
        Infohc.Text = Trim(dsinfoverify.Tables(1).Rows(0).Item("hc"))
        Infops.Text = Trim(dsinfoverify.Tables(1).Rows(0).Item("ps"))
        Infoqdjs.Text = Trim(dsinfoverify.Tables(0).Rows(0).Item("qdjs"))
        Infoqdds.Text = Trim(dsinfoverify.Tables(0).Rows(0).Item("qdds"))
        Infosjjs.Text = Trim(dsinfoverify.Tables(0).Rows(0).Item("sjjs"))
        Infosjds.Text = Trim(dsinfoverify.Tables(0).Rows(0).Item("sjds"))
        Infozxg.Text = IIf(Len(Trim(dsinfoverify.Tables(1).Rows(0).Item("zxg"))) > 0, Trim(dsinfoverify.Tables(1).Rows(0).Item("zxg")), "")
        Infokgsj.Text = dsinfoverify.Tables(1).Rows(0).Item("worktime_begin")
        Infowgsj.Text = dsinfoverify.Tables(1).Rows(0).Item("worktime_end")
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub clearinfo()
        Infozwcm.Text = ""
        Infoywcm.Text = ""
        Infojck.Text = ""
        Infozwgj.Text = ""
        Infoywgj.Text = ""
        Infobw.Text = ""
        Infocd.Text = ""
        Infohc.Text = ""
        Infops.Text = ""
        Infoqdjs.Text = ""
        Infoqdds.Text = ""
        Infosjjs.Text = ""
        Infosjds.Text = ""
        Infozxg.Text = ""
        Infokgsj.Text = ""
        Infowgsj.Text = ""
    End Sub

    Private Sub getTallylist(ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            strsql = "select  ID, SHIP_ID, TEAM_NO, NO, NAME_BERTH, DESCR, HATCH_Position, MARK, cast(amount as dec(10,0)) as amount, DATE, TIME_FROM, TIME_TO, name1, CROSS_PERSON, name2 from VIEW_Tally_sheet  where " & Sql
            Me.C1DBGTALLY_LIST.DataSource = Getdata(strsql, dsTally_List)
            ColNum = 2
            Table_Name = "VIEW_Tally_sheet"
            For i = 0 To ColNum - 1
                Me.C1DBGTALLY_LIST.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Me.C1DBGTALLY_LIST.Columns.Item("Date").NumberFormat = "yyyy/MM/dd"
            Call SetColumnCaptionTally_List()
            Call SetColumnWidthTally_list()
            If dsTally_List.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumTally_List(Sql)
            End If
            Me.C1DBGTALLY_LIST.Refresh()
            Me.C1DBGTALLY_LIST.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
            Me.C1DBGTALLY_LIST.MoveLast()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getwait(ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            strsql = "select  *  from VIEW_CARGO_WAITFOR  where " & Sql
            Me.C1DBGWAIT.DataSource = Getdata(strsql, dsWait)
            ColNum = 2
            Table_Name = "VIEW_CARGO_WAITFOR"
            For i = 0 To ColNum - 1
                Me.C1DBGWAIT.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Me.C1DBGWAIT.Columns.Item("STANDBYDATE").NumberFormat = "yyyy/MM/dd"
            Call SetColumnCaptionWait()
            Call SetColumnWidthWait()
            If dsWait.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumWait(Sql)
            End If
            Me.C1DBGWAIT.Refresh()
            Me.C1DBGWAIT.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
            Me.C1DBGWAIT.MoveLast()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getworkrecord(ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            strsql = "select  *  from VIEW_WORK_RECORD_new  where " & Sql
            Me.C1DBGWORK_RECORD.DataSource = Getdata(strsql, dsWork_Record)
            ColNum = 2
            Table_Name = "VIEW_WORK_RECORD"
            For i = 0 To ColNum - 1
                Me.C1DBGWORK_RECORD.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Me.C1DBGWORK_RECORD.Columns.Item("RECORD_DAY").NumberFormat = "yyyy/MM/dd"
            Call SetColumnCaptionWorkRecord()
            Call SetColumnWidthWork_Record()
            If dsWork_Record.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumWork_Record(Sql)
            End If
            Me.C1DBGWORK_RECORD.Refresh()
            Me.C1DBGWORK_RECORD.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
            Me.C1DBGWORK_RECORD.MoveLast()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getmeasure(ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            strsql = "select *  from VIEW_CARGO_MEASURE_LIST  where " & Sql
            Me.C1DBGMEASURE.DataSource = Getdata(strsql, dsMeasure)
            ColNum = 2
            Table_Name = "VIEW_CARGO_MEASURE_LIST"

            For i = 0 To ColNum - 1
                Me.C1DBGMEASURE.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Call SetColumnCaptionMeasure()
            Call SetColumnWidthMeasure()
            If dsMeasure.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumMeasure(Sql)
            End If
            Me.C1DBGMEASURE.Refresh()
            Me.C1DBGMEASURE.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
            Me.C1DBGMEASURE.MoveLast()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getShort(ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            '不显示的列名在最前面
            strsql = "select  *  from VIEW_CARGO_SHORT  where " & Sql '******要修改

            Me.C1DBGShort.DataSource = Getdata(strsql, dsShort)  ' class dbcontrol getdata fuction
            ColNum = 2 '不显示的列数 '******要修改
            Table_Name = "VIEW_CARGO_SHORT" '操作的数据库表名 ''******要修改

            For i = 0 To ColNum - 1 '设计部显示的列
                Me.C1DBGShort.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Translate = True
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Validate = True
            'Me.C1DBG.Splits(0).DisplayColumns.Item("Logic").Visible = False

            Call SetColumnCaptionShort() '设计列标题
            Call SetColumnWidthShort() '设计列宽度
            If dsShort.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumShort(Sql) '设计合计列
            End If
            Me.C1DBGShort.Refresh()
            Me.C1DBGShort.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色
            Me.C1DBGShort.MoveLast()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getDamaged(ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            '不显示的列名在最前面
            strsql = "select  *  from VIEW_CARGO_DAMAGED_List  where " & Sql '******要修改

            Me.C1DBGDamaged.DataSource = Getdata(strsql, dsDamaged)  ' class dbcontrol getdata fuction
            ColNum = 2 '不显示的列数 '******要修改
            Table_Name = "VIEW_CARGO_DAMAGED_List" '操作的数据库表名 ''******要修改

            For i = 0 To ColNum - 1 '设计部显示的列
                Me.C1DBGDamaged.Splits(0).DisplayColumns.Item(i).Visible = False
            Next

            Call SetColumnCaptionDamaged() '设计列标题
            Call SetColumnWidthDamaged() '设计列宽度
            If dsDamaged.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumDamaged(Sql) '设计合计列
            End If

            Me.C1DBGDamaged.Refresh()
            Me.C1DBGDamaged.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色
            Me.C1DBGDamaged.MoveLast()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getdailyreportHis()
        dsreport.Reset()
        Getdata("select id,gbno from report_his1 where ship_id=" & Ship_ID & "order by gbno", dsreport)
        If dsreport.Tables(0).Rows.Count > 0 Then
            labreport.Text = "共有日报 " & dsreport.Tables(0).Rows.Count & " 份　"
            cmbreport.Enabled = True
            Button1.Enabled = True
            cmbreport.DataSource = dsreport.Tables(0).DefaultView
            cmbreport.DisplayMember = "gbno"
            cmbreport.ValueMember = "id"
        Else
            labreport.Text = "共有日报 0 份　"
            cmbreport.Enabled = False
            Button1.Enabled = False
        End If
    End Sub

    Private Sub getfee()
        Dim strsql As String
        Dim i As Integer
        Try
            strsql = "select id,ACCOUNT_DETAIL_ID,SHIP_ID,Clear,BILL_ID,Fee_Code,NO,Tally_items_CHA,FEE_AMOUNT,UNIT_cha,cast(FEE_RATE as numeric(10,2)) as fee_rate,cast(MONEY as numeric(10,2)) as money,Descri,Account_Type,SHIPAGENT_CHA,Clear_Name from VIEW_Bill_List_New_standard where Dept_code = '" & G_DeptCode & "' and Ship_ID=" & Ship_ID & " Order by ID desc,Fee_Code" '******要修改
            Me.C1DBG.DataSource = Getdata(strsql, dsfee)  ' class dbcontrol getdata fuction
            ColNum = 6 '不显示的列数 '******要修改
            Table_Name = "VIEW_Bill_List_New" '操作的数据库表名 ''******要修改

            For i = 0 To ColNum - 1 '设计不显示的列
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Call SetColumnCaption_fee() '设计列标题
            Call SetColumnWidth_fee() '设计列宽度
            If dsfee.Tables(0).Rows.Count > 0 Then
                Call SetColumnSum_fee() '设计合计列
            End If
            C1DBG.FetchRowStyles = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaption_fee()
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Try
            str = "select Field_Eng,Field_Cha From Field_Att where Table_Name='" & Table_Name & "'"
            sqlconn.ConnectionString = conn
            sqlc.Connection = sqlconn
            sqlc.CommandText = str
            sqla.SelectCommand = sqlc
            dset.Reset()
            sqla.Fill(dset)
            i = ColNum

            Do While i < Me.C1DBG.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = _
                        Upper(Trim(Me.C1DBG.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBG.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
                        Exit For
                    End If
                Next
                i = i + 1
            Loop
            sqlconn.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnWidth_fee()
        Try
            Dim j As Integer
            For j = 0 To Me.C1DBG.Columns.Count - 1
                Me.C1DBG.Splits(0).DisplayColumns.Item(j).AutoSize()
                Me.C1DBG.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                If Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width < 65 Then
                    Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width = 65
                Else
                    If Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width > 130 Then
                        Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width = 130
                    End If
                End If
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnSum_fee()
        On Error GoTo Err
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
        Dim dset2 As New DataSet
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Dim m As Integer
        Dim num As Double
        str = "select Field_Eng,Field_Type,IsOrNoSum From Field_Att where Table_Name='" & Trim(Table_Name) & "'"
        sqlconn.ConnectionString = conn
        sqlc.Connection = sqlconn
        sqlc.CommandText = str
        sqla.SelectCommand = sqlc
        dset.Reset()
        sqla.Fill(dset)

        i = ColNum
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBG.Columns.Item(ColNum).FooterText = "合计 共" & dsfee.Tables(0).Rows.Count & "条"

        Do While i < Me.C1DBG.Columns.Count
            j = 0
            For j = 0 To dset.Tables(0).Rows.Count - 1

                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBG.Columns.Item(i).DataField.ToString)) _
                    And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then

                    num = 0
                    For m = 0 To dsfee.Tables(0).Rows.Count - 1
                        num = num + dsfee.Tables(0).Rows(m)(i)
                    Next
                    Me.C1DBG.Columns.Item(i).FooterText = CType(num, String)
                    Exit For
                End If
            Next
            i = i + 1
        Loop
        sqlconn.Close()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        gbno = ""
        lastgb = ""
        gbno = cmbreport.Text()
        reportid = cmbreport.SelectedValue
        If System.Convert.ToInt16(gbno) > 1 Then
            lastgb = System.Convert.ToInt16(gbno) - 1
            lastgb = System.Convert.ToString(lastgb).ToString.PadLeft(2, "0")
            reportidpre = dsreport.Tables(0).Select(" gbno='" & lastgb & "' ")(0)("id")
        Else
            lastgb = 0
            reportidpre = 0
        End If

        Dim dstmp As New DataSet
        dsdaily.Reset()
        Getdata("SELECT HATCH FROM VESSEL INNER JOIN SSHIP ON VESSEL.VESSEL_ID = SSHIP.V_ID WHERE SHIP_ID ='" & Ship_ID & "' ", dstmp)
        If dstmp.Tables(0).Rows(0)(0) > 6 Then
            Getdata("exec sp_daily_report_eng_gl_tol_new '" & reportid & "','" & reportidpre & "' ", dsdaily)
        Else
            Getdata("exec sp_daily_report_eng_gl_tol '" & reportid & "','" & reportidpre & "' ", dsdaily)
        End If
        REMARKS = ""
        If dsdaily.Tables(1).Rows.Count > 0 Then
            'If dsdaily.Tables(1).Rows(0).Item("shifting") <> 0 Then
            '    REMARKS = REMARKS & "SHIFTING " & dsdaily.Tables(1).Rows(0).Item("shifting") & " PKGS."
            'End If
            If dsdaily.Tables(1).Rows(0).Item("HOLIDAY") <> 0 Then
                REMARKS = REMARKS & "HOLIDAY " & dsdaily.Tables(1).Rows(0).Item("HOLIDAY") & " PKGS."
            End If
            If dsdaily.Tables(1).Rows(0).Item("NIGHT") <> 0 Then
                REMARKS = REMARKS & "NIGHT SHIFT " & dsdaily.Tables(1).Rows(0).Item("NIGHT") & " PKGS."
            End If
            If dsdaily.Tables(1).Rows(0).Item("NON_CARGOHOLD") <> 0 Then
                REMARKS = REMARKS & "NON_CARGOHOLD " & dsdaily.Tables(1).Rows(0).Item("NON_CARGOHOLD") & " PKGS."
            End If
            If dsdaily.Tables(1).Rows(0).Item("MARK_ASSORTING") <> 0 Then
                REMARKS = REMARKS & "MARK_ASSORTING " & dsdaily.Tables(1).Rows(0).Item("MARK_ASSORTING") & " PKGS."
            End If
            If dsdaily.Tables(1).Rows(0).Item("STANDBY_time") <> 0 Then
                REMARKS = REMARKS & "STANDBY_time " & dsdaily.Tables(1).Rows(0).Item("STANDBY_time") & " PKGS."
            End If
        End If
        getdailyreport()
    End Sub

    Private Sub getdailyreportHisOth()
        dsreportOth.Reset()
        Dim ff As String
        Cmbflag.Text = "出舱"
        If Cmbflag.Text.Trim() = "出舱" Then
            ff = 1
        End If
        If Cmbflag.Text.Trim() = "重装" Then
            ff = 2
        End If
        Getdata("select id,gbno from report_his1 where ship_id=" & Ship_ID & " AND other='" & ff & "' order by gbno", dsreportOth)
        If dsreportOth.Tables(0).Rows.Count > 0 Then
            labreportOth.Text = "共有翻舱日报 " & dsreportOth.Tables(0).Rows.Count & " 份　"
            cmbreportOth.Enabled = True
            Button2.Enabled = True
            cmbreportOth.DataSource = dsreportOth.Tables(0).DefaultView
            cmbreportOth.DisplayMember = "gbno"
            cmbreportOth.ValueMember = "id"
        Else
            labreportOth.Text = "共有翻舱日报 0 份　"
            cmbreportOth.Enabled = False
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        gbnoOth = ""
        lastgbOth = ""
        gbnoOth = cmbreportOth.Text()
        reportidOth = cmbreportOth.SelectedValue
        If System.Convert.ToInt16(gbnoOth) > 1 Then
            lastgbOth = System.Convert.ToInt16(gbnoOth) - 1
            lastgbOth = System.Convert.ToString(lastgbOth).ToString.PadLeft(2, "0")
            reportidpreOth = dsreportOth.Tables(0).Select(" gbno='" & lastgbOth & "' ")(0)("id")
        Else
            lastgbOth = 0
            reportidpreOth = 0
        End If

        Dim dstmp As New DataSet
        dsdaily.Reset()
        Getdata("SELECT HATCH FROM VESSEL INNER JOIN SSHIP ON VESSEL.VESSEL_ID = SSHIP.V_ID WHERE SHIP_ID ='" & Ship_ID & "' ", dstmp)
        If dstmp.Tables(0).Rows(0)(0) > 6 Then
            Getdata("exec sp_daily_report_eng_gl_tol_new '" & reportidOth & "','" & reportidpreOth & "' ", dsdaily)
        Else
            Getdata("exec sp_daily_report_eng_gl_tol '" & reportidOth & "','" & reportidpreOth & "' ", dsdaily)
        End If
        REMARKS = ""
        If dsdaily.Tables(1).Rows.Count > 0 Then
            'If dsdaily.Tables(1).Rows(0).Item("shifting") <> 0 Then
            '    REMARKS = REMARKS & "SHIFTING " & dsdaily.Tables(1).Rows(0).Item("shifting") & " PKGS."
            'End If
            If dsdaily.Tables(1).Rows(0).Item("HOLIDAY") <> 0 Then
                REMARKS = REMARKS & "HOLIDAY " & dsdaily.Tables(1).Rows(0).Item("HOLIDAY") & " PKGS."
            End If
            If dsdaily.Tables(1).Rows(0).Item("NIGHT") <> 0 Then
                REMARKS = REMARKS & "NIGHT SHIFT " & dsdaily.Tables(1).Rows(0).Item("NIGHT") & " PKGS."
            End If
            If dsdaily.Tables(1).Rows(0).Item("NON_CARGOHOLD") <> 0 Then
                REMARKS = REMARKS & "NON_CARGOHOLD " & dsdaily.Tables(1).Rows(0).Item("NON_CARGOHOLD") & " PKGS."
            End If
            If dsdaily.Tables(1).Rows(0).Item("MARK_ASSORTING") <> 0 Then
                REMARKS = REMARKS & "MARK_ASSORTING " & dsdaily.Tables(1).Rows(0).Item("MARK_ASSORTING") & " PKGS."
            End If
            If dsdaily.Tables(1).Rows(0).Item("STANDBY_time") <> 0 Then
                REMARKS = REMARKS & "STANDBY_time " & dsdaily.Tables(1).Rows(0).Item("STANDBY_time") & " PKGS."
            End If
        End If
        getdailyreport_other()
    End Sub

    Private Sub getdailyreport()
        Dim strsql As String
        Dim i As Integer
        Try
            strsql = "select * from Cargo_DAILY_REPORT where ship_id=" & Ship_ID & " and mark=0 "
            Getdata(strsql, dsdaily)
            Me.C1DBGDaily_report.DataSource = dsdaily.Tables(0).DefaultView
            LabREMARKS.Text = REMARKS
            Table_Name = "SP_daily_report"

            For i = 0 To 1
                Me.C1DBGDaily_report.Splits(0).DisplayColumns.Item(i).Visible = False
            Next

            Me.C1DBGDaily_report.Columns.Item("code_goods").Caption = "货名"
            Me.C1DBGDaily_report.Columns.Item("h17p").Caption = "小计件"
            Me.C1DBGDaily_report.Columns.Item("h17t").Caption = "小计吨"
            Me.C1DBGDaily_report.Columns.Item("h1p").Caption = "1舱件"
            Me.C1DBGDaily_report.Columns.Item("h1t").Caption = "1舱吨"
            Me.C1DBGDaily_report.Columns.Item("h2p").Caption = "2舱件"
            Me.C1DBGDaily_report.Columns.Item("h2t").Caption = "2舱吨"
            Me.C1DBGDaily_report.Columns.Item("h3p").Caption = "3舱件"
            Me.C1DBGDaily_report.Columns.Item("h3t").Caption = "3舱吨"
            Me.C1DBGDaily_report.Columns.Item("h4p").Caption = "4舱件"
            Me.C1DBGDaily_report.Columns.Item("h4t").Caption = "4舱吨"
            Me.C1DBGDaily_report.Columns.Item("h5p").Caption = "5舱件"
            Me.C1DBGDaily_report.Columns.Item("h5t").Caption = "5舱吨"
            Me.C1DBGDaily_report.Columns.Item("h6p").Caption = "6舱件"
            Me.C1DBGDaily_report.Columns.Item("h6t").Caption = "6舱吨"
            Me.C1DBGDaily_report.Columns.Item("h16p").Caption = "甲板件"
            Me.C1DBGDaily_report.Columns.Item("h16t").Caption = "甲板吨"
            If GL_hatch > 6 Then
                Me.C1DBGDaily_report.Columns.Item("h7p").Caption = "7舱件"
                Me.C1DBGDaily_report.Columns.Item("h7t").Caption = "7舱吨"
                Me.C1DBGDaily_report.Columns.Item("h8p").Caption = "8舱件"
                Me.C1DBGDaily_report.Columns.Item("h8t").Caption = "8舱吨"
                Me.C1DBGDaily_report.Columns.Item("h9p").Caption = "9舱件"
                Me.C1DBGDaily_report.Columns.Item("h9t").Caption = "9舱吨"
                Me.C1DBGDaily_report.Columns.Item("h10p").Caption = "10舱件"
                Me.C1DBGDaily_report.Columns.Item("h10t").Caption = "10舱吨"
                Me.C1DBGDaily_report.Columns.Item("h11p").Caption = "11舱件"
                Me.C1DBGDaily_report.Columns.Item("h11t").Caption = "11舱吨"
                Me.C1DBGDaily_report.Columns.Item("h12p").Caption = "12舱件"
                Me.C1DBGDaily_report.Columns.Item("h12t").Caption = "12舱吨"
                Me.C1DBGDaily_report.Columns.Item("h13p").Caption = "13舱件"
                Me.C1DBGDaily_report.Columns.Item("h13t").Caption = "13舱吨"
                Me.C1DBGDaily_report.Columns.Item("h14p").Caption = "14舱件"
                Me.C1DBGDaily_report.Columns.Item("h14t").Caption = "14舱吨"
                Me.C1DBGDaily_report.Columns.Item("h15p").Caption = "15舱件"
                Me.C1DBGDaily_report.Columns.Item("h15t").Caption = "15舱吨"
            Else
                For i = 15 To 32
                    Me.C1DBGDaily_report.Splits(0).DisplayColumns.Item(i).Visible = False
                Next
                Me.C1DBGDaily_report.Splits(0).DisplayColumns.Item("mark").Visible = False
            End If
            Call SetColumnCaptionDailyReport()
            Call SetColumnWidthDaily()
            Me.C1DBGDaily_report.Refresh()
            Me.C1DBGDaily_report.AllowSort = False
            Me.C1DBGDaily_report.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
            Me.C1DBGDaily_report.MoveLast()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getdailyreport_other()
        Dim strsql As String
        Dim i As Integer
        Try
            strsql = "select * from Cargo_DAILY_REPORT where ship_id=" & Ship_ID & " and mark<>0 "
            Getdata(strsql, dsdaily_other)
            Me.C1DBGDaily_other.DataSource = dsdaily_other.Tables(0).DefaultView
            LabREMARKS.Text = REMARKS_OTHER
            Table_Name = "SP_daily_report"
            For i = 0 To ColNum - 1
                Me.C1DBGDaily_other.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Me.C1DBGDaily_other.Columns.Item("code_goods").Caption = "货名"
            Me.C1DBGDaily_other.Columns.Item("h17p").Caption = "小计件"
            Me.C1DBGDaily_other.Columns.Item("h17t").Caption = "小计吨"
            Me.C1DBGDaily_other.Columns.Item("h1p").Caption = "1舱件"
            Me.C1DBGDaily_other.Columns.Item("h1t").Caption = "1舱吨"
            Me.C1DBGDaily_other.Columns.Item("h2p").Caption = "2舱件"
            Me.C1DBGDaily_other.Columns.Item("h2t").Caption = "2舱吨"
            Me.C1DBGDaily_other.Columns.Item("h3p").Caption = "3舱件"
            Me.C1DBGDaily_other.Columns.Item("h3t").Caption = "3舱吨"
            Me.C1DBGDaily_other.Columns.Item("h4p").Caption = "4舱件"
            Me.C1DBGDaily_other.Columns.Item("h4t").Caption = "4舱吨"
            Me.C1DBGDaily_other.Columns.Item("h5p").Caption = "5舱件"
            Me.C1DBGDaily_other.Columns.Item("h5t").Caption = "5舱吨"
            Me.C1DBGDaily_other.Columns.Item("h6p").Caption = "6舱件"
            Me.C1DBGDaily_other.Columns.Item("h6t").Caption = "6舱吨"
            Me.C1DBGDaily_other.Columns.Item("h16p").Caption = "甲板件"
            Me.C1DBGDaily_other.Columns.Item("h16t").Caption = "甲板吨"
            If GL_hatch > 6 Then
                Me.C1DBGDaily_other.Columns.Item("h7p").Caption = "7舱件"
                Me.C1DBGDaily_other.Columns.Item("h7t").Caption = "7舱吨"
                Me.C1DBGDaily_other.Columns.Item("h8p").Caption = "8舱件"
                Me.C1DBGDaily_other.Columns.Item("h8t").Caption = "8舱吨"
                Me.C1DBGDaily_other.Columns.Item("h9p").Caption = "9舱件"
                Me.C1DBGDaily_other.Columns.Item("h9t").Caption = "9舱吨"
                Me.C1DBGDaily_other.Columns.Item("h10p").Caption = "10舱件"
                Me.C1DBGDaily_other.Columns.Item("h10t").Caption = "10舱吨"
                Me.C1DBGDaily_other.Columns.Item("h11p").Caption = "11舱件"
                Me.C1DBGDaily_other.Columns.Item("h11t").Caption = "11舱吨"
                Me.C1DBGDaily_other.Columns.Item("h12p").Caption = "12舱件"
                Me.C1DBGDaily_other.Columns.Item("h12t").Caption = "12舱吨"
                Me.C1DBGDaily_other.Columns.Item("h13p").Caption = "13舱件"
                Me.C1DBGDaily_other.Columns.Item("h13t").Caption = "13舱吨"
                Me.C1DBGDaily_other.Columns.Item("h14p").Caption = "14舱件"
                Me.C1DBGDaily_other.Columns.Item("h14t").Caption = "14舱吨"
                Me.C1DBGDaily_other.Columns.Item("h15p").Caption = "15舱件"
                Me.C1DBGDaily_other.Columns.Item("h15t").Caption = "15舱吨"
            Else
                For i = 15 To 32
                    Me.C1DBGDaily_other.Splits(0).DisplayColumns.Item(i).Visible = False
                Next
                Me.C1DBGDaily_other.Splits(0).DisplayColumns.Item("mark").Visible = False
            End If

            Call SetColumnCaptionDailyReport()
            Call SetColumnWidthDaily()
            Me.C1DBGDaily_other.Refresh()
            Me.C1DBGDaily_other.AllowSort = False
            Me.C1DBGDaily_other.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
            Me.C1DBGDaily_other.MoveLast()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getCertificate()
        Dim dw As New DataView
        Dim strsql As String
        Dim i As Integer
        Try
            ds_sship.Reset()        '理货业务凭证
            dw = Getdata("select * from view_outhatch_sship where ship_id='" & Ship_ID & "'", ds_sship)
            If ds_sship.Tables(0).Rows.Count > 0 Then
                dw = Getdata("exec SP_CARGO_CERTIFICATE_eng '" & Ship_ID & "'", DS_DO)
            End If
            C1DBGCertificate.Visible = True
            C1DBGCertificate.DataSource = DS_DO.Tables(0).DefaultView
            C1DBGCertificate.Refresh()
            Me.C1DBGCertificate.Columns.Item("item").Caption = "项目"
            Me.C1DBGCertificate.Columns.Item("amount").Caption = "件数"
            Me.C1DBGCertificate.Columns.Item("unit").Caption = "单位"
            'Call SetColumnWidthCertificate()
            Me.C1DBGCertificate.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaptionTally_List()
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Try
            str = "select Field_Eng,Field_Cha From Field_Att where Table_Name='" & Table_Name & "'"
            sqlconn.ConnectionString = conn
            sqlc.Connection = sqlconn
            sqlc.CommandText = str
            sqla.SelectCommand = sqlc
            dset.Reset()
            sqla.Fill(dset)
            i = ColNum
            Do While i < Me.C1DBGTALLY_LIST.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGTALLY_LIST.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBGTALLY_LIST.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
                        Exit For
                    End If
                Next
                i = i + 1
            Loop
            sqlconn.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaptionWait()
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Try
            str = "select Field_Eng,Field_Cha From Field_Att where Table_Name='" & Table_Name & "'"
            sqlconn.ConnectionString = conn
            sqlc.Connection = sqlconn
            sqlc.CommandText = str
            sqla.SelectCommand = sqlc
            dset.Reset()
            sqla.Fill(dset)
            i = ColNum
            Do While i < Me.C1DBGWAIT.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGWAIT.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBGWAIT.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
                        Exit For
                    End If
                Next
                i = i + 1
            Loop
            sqlconn.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaptionWorkRecord()
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Try
            str = "select Field_Eng,Field_Cha From Field_Att where Table_Name='" & Table_Name & "'"
            sqlconn.ConnectionString = conn
            sqlc.Connection = sqlconn
            sqlc.CommandText = str
            sqla.SelectCommand = sqlc
            dset.Reset()
            sqla.Fill(dset)
            i = ColNum

            Do While i < Me.C1DBGWORK_RECORD.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGWORK_RECORD.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBGWORK_RECORD.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
                        Exit For
                    End If
                Next
                i = i + 1
            Loop
            sqlconn.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaptionMeasure()
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Try
            str = "select Field_Eng,Field_Cha From Field_Att where Table_Name='" & Table_Name & "'"
            sqlconn.ConnectionString = conn
            sqlc.Connection = sqlconn
            sqlc.CommandText = str
            sqla.SelectCommand = sqlc
            dset.Reset()
            sqla.Fill(dset)
            i = ColNum

            Do While i < Me.C1DBGMEASURE.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGMEASURE.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBGMEASURE.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
                        Exit For
                    End If
                Next
                i = i + 1
            Loop
            sqlconn.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub SetColumnCaptionShort()
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Try
            str = "select Field_Eng,Field_Cha From Field_Att where Table_Name='" & Table_Name & "'"
            sqlconn.ConnectionString = conn
            sqlc.Connection = sqlconn
            sqlc.CommandText = str
            sqla.SelectCommand = sqlc
            dset.Reset()
            sqla.Fill(dset)
            i = ColNum

            Do While i < Me.C1DBGShort.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGShort.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBGShort.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
                        Exit For
                    End If
                Next
                i = i + 1
            Loop
            sqlconn.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaptionDamaged()
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Try
            str = "select Field_Eng,Field_Cha From Field_Att where Table_Name='" & Table_Name & "'"
            sqlconn.ConnectionString = conn
            sqlc.Connection = sqlconn
            sqlc.CommandText = str
            sqla.SelectCommand = sqlc
            dset.Reset()
            sqla.Fill(dset)
            i = ColNum

            Do While i < Me.C1DBGDamaged.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGDamaged.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBGDamaged.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
                        Exit For
                    End If
                Next
                i = i + 1
            Loop
            sqlconn.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnWidthShort()
        Dim j As Integer
        For j = 0 To Me.C1DBGShort.Columns.Count - 1
            Me.C1DBGShort.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.C1DBGShort.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.C1DBGShort.Splits(0).DisplayColumns.Item(j).Width < 40 Then
                Me.C1DBGShort.Splits(0).DisplayColumns.Item(j).Width = 40
            Else
                If Me.C1DBGShort.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.C1DBGShort.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If
        Next
    End Sub

    Private Sub SetColumnWidthDamaged()
        Dim j As Integer
        For j = 0 To Me.C1DBGDamaged.Columns.Count - 1
            Me.C1DBGDamaged.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.C1DBGDamaged.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.C1DBGDamaged.Splits(0).DisplayColumns.Item(j).Width < 40 Then
                Me.C1DBGDamaged.Splits(0).DisplayColumns.Item(j).Width = 40
            Else
                If Me.C1DBGDamaged.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.C1DBGDamaged.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If
        Next
    End Sub

    Private Sub SetColumnSumShort(ByVal sql As String)
        On Error GoTo Err
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
        Dim dset2 As New DataSet
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Dim m As Integer
        Dim num As Double
        str = "select Field_Eng,Field_Type,IsOrNoSum From Field_Att where Table_Name='" & Trim(Table_Name) & "'"
        sqlconn.ConnectionString = conn
        sqlc.Connection = sqlconn
        sqlc.CommandText = str
        sqla.SelectCommand = sqlc
        dset.Reset()
        sqla.Fill(dset)

        i = ColNum
        Me.C1DBGShort.ColumnFooters = True
        Me.C1DBGShort.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGShort.Columns.Item(ColNum).FooterText = "合计 共" & dsShort.Tables(0).Rows.Count & "条"
        Do While i < Me.C1DBGShort.Columns.Count
            j = 0
            For j = 0 To dset.Tables(0).Rows.Count - 1
                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGShort.Columns.Item(i).DataField.ToString)) And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then
                    num = 0
                    For m = 0 To dsShort.Tables(0).Rows.Count - 1
                        num = num + dsShort.Tables(0).Rows(m)(i)
                    Next
                    Me.C1DBGShort.Columns.Item(i).FooterText = CType(num, String)
                    Exit For
                End If
            Next
            i = i + 1
        Loop

        sqlconn.Close()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub SetColumnSumDamaged(ByVal sql As String)
        On Error GoTo Err
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
        Dim dset2 As New DataSet
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Dim m As Integer
        Dim num As Double
        str = "select Field_Eng,Field_Type,IsOrNoSum From Field_Att where Table_Name='" & Trim(Table_Name) & "'"
        sqlconn.ConnectionString = conn
        sqlc.Connection = sqlconn
        sqlc.CommandText = str
        sqla.SelectCommand = sqlc
        dset.Reset()
        sqla.Fill(dset)

        i = ColNum
        Me.C1DBGDamaged.ColumnFooters = True
        Me.C1DBGDamaged.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGDamaged.Columns.Item(ColNum).FooterText = "合计 共" & dsDamaged.Tables(0).Rows.Count & "条"
        Do While i < Me.C1DBGDamaged.Columns.Count
            j = 0
            For j = 0 To dset.Tables(0).Rows.Count - 1

                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGDamaged.Columns.Item(i).DataField.ToString)) And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then

                    num = 0
                    For m = 0 To dsDamaged.Tables(0).Rows.Count - 1
                        num = num + dsDamaged.Tables(0).Rows(m)(i)
                    Next
                    Me.C1DBGDamaged.Columns.Item(i).FooterText = CType(num, String)
                    Exit For
                End If
            Next
            i = i + 1
        Loop
        sqlconn.Close()
        Exit Sub
Err:
        Resume Next
    End Sub


    Private Sub SetColumnCaptionDailyReport()
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Try
            str = "select Field_Eng,Field_Cha From Field_Att where Table_Name='" & Table_Name & "'"
            sqlconn.ConnectionString = conn
            sqlc.Connection = sqlconn
            sqlc.CommandText = str
            sqla.SelectCommand = sqlc
            dset.Reset()
            sqla.Fill(dset)
            i = ColNum

            Do While i < Me.C1DBGDaily_report.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGDaily_report.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBGDaily_report.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
                        Exit For
                    End If
                Next
                i = i + 1
            Loop
            sqlconn.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnWidthTally_list()
        Dim j As Integer
        For j = 0 To Me.C1DBGTALLY_LIST.Columns.Count - 1
            Me.C1DBGTALLY_LIST.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.C1DBGTALLY_LIST.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.C1DBGTALLY_LIST.Splits(0).DisplayColumns.Item(j).Width < 40 Then
                Me.C1DBGTALLY_LIST.Splits(0).DisplayColumns.Item(j).Width = 40
            Else
                If Me.C1DBGTALLY_LIST.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.C1DBGTALLY_LIST.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If
        Next
    End Sub

    Private Sub SetColumnWidthWait()
        Dim j As Integer
        For j = 0 To Me.C1DBGWAIT.Columns.Count - 1
            Me.C1DBGWAIT.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.C1DBGWAIT.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.C1DBGWAIT.Splits(0).DisplayColumns.Item(j).Width < 40 Then
                Me.C1DBGWAIT.Splits(0).DisplayColumns.Item(j).Width = 40
            Else
                If Me.C1DBGWAIT.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.C1DBGWAIT.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If
        Next
    End Sub

    Private Sub SetColumnWidthWork_Record()
        Dim j As Integer
        For j = 0 To Me.C1DBGWORK_RECORD.Columns.Count - 1
            Me.C1DBGWORK_RECORD.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.C1DBGWORK_RECORD.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.C1DBGWORK_RECORD.Splits(0).DisplayColumns.Item(j).Width < 40 Then
                Me.C1DBGWORK_RECORD.Splits(0).DisplayColumns.Item(j).Width = 40
            Else
                If Me.C1DBGWORK_RECORD.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.C1DBGWORK_RECORD.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If
        Next
    End Sub

    Private Sub SetColumnWidthMeasure()
        Dim j As Integer
        For j = 0 To Me.C1DBGMEASURE.Columns.Count - 1
            Me.C1DBGMEASURE.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.C1DBGMEASURE.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.C1DBGMEASURE.Splits(0).DisplayColumns.Item(j).Width < 40 Then
                Me.C1DBGMEASURE.Splits(0).DisplayColumns.Item(j).Width = 40
            Else
                If Me.C1DBGMEASURE.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.C1DBGMEASURE.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If
        Next
    End Sub

    Private Sub SetColumnWidthDaily()
        Dim j As Integer
        For j = 0 To Me.C1DBGDaily_report.Columns.Count - 1
            Me.C1DBGDaily_report.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.C1DBGDaily_report.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.C1DBGDaily_report.Splits(0).DisplayColumns.Item(j).Width < 40 Then
                Me.C1DBGDaily_report.Splits(0).DisplayColumns.Item(j).Width = 40
            Else
                If Me.C1DBGDaily_report.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.C1DBGDaily_report.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If
        Next
        For j = 0 To Me.C1DBGDaily_other.Columns.Count - 1
            Me.C1DBGDaily_other.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.C1DBGDaily_other.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.C1DBGDaily_other.Splits(0).DisplayColumns.Item(j).Width < 40 Then
                Me.C1DBGDaily_other.Splits(0).DisplayColumns.Item(j).Width = 40
            Else
                If Me.C1DBGDaily_other.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.C1DBGDaily_other.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If
        Next
    End Sub

    Private Sub SetColumnSumTally_List(ByVal sql As String)
        On Error GoTo Err
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
        Dim dset2 As New DataSet
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Dim m As Integer
        Dim num As Double
        str = "select Field_Eng,Field_Type,IsOrNoSum From Field_Att where Table_Name='" & Trim(Table_Name) & "'"
        sqlconn.ConnectionString = conn
        sqlc.Connection = sqlconn
        sqlc.CommandText = str
        sqla.SelectCommand = sqlc
        dset.Reset()
        sqla.Fill(dset)

        i = ColNum
        Me.C1DBGTALLY_LIST.ColumnFooters = True
        Me.C1DBGTALLY_LIST.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGTALLY_LIST.Columns.Item(ColNum).FooterText = "合计 共" & dsTally_List.Tables(0).Rows.Count & "条"
        Do While i < Me.C1DBGTALLY_LIST.Columns.Count
            j = 0
            For j = 0 To dset.Tables(0).Rows.Count - 1

                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGTALLY_LIST.Columns.Item(i).DataField.ToString)) And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then

                    num = 0
                    For m = 0 To dsTally_List.Tables(0).Rows.Count - 1
                        num = num + dsTally_List.Tables(0).Rows(m)(i)
                    Next
                    Me.C1DBGTALLY_LIST.Columns.Item(i).FooterText = CType(num, String)
                    Exit For
                End If
            Next
            i = i + 1
        Loop
        sqlconn.Close()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub SetColumnSumWait(ByVal sql As String)
        On Error GoTo Err
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
        Dim dset2 As New DataSet
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Dim m As Integer
        Dim num As Double
        str = "select Field_Eng,Field_Type,IsOrNoSum From Field_Att where Table_Name='" & Trim(Table_Name) & "'"
        sqlconn.ConnectionString = conn
        sqlc.Connection = sqlconn
        sqlc.CommandText = str
        sqla.SelectCommand = sqlc
        dset.Reset()
        sqla.Fill(dset)

        i = ColNum
        Me.C1DBGWAIT.ColumnFooters = True
        Me.C1DBGWAIT.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGWAIT.Columns.Item(ColNum).FooterText = "合计 共" & dsWait.Tables(0).Rows.Count & "条"
        Do While i < Me.C1DBGWAIT.Columns.Count
            j = 0
            For j = 0 To dset.Tables(0).Rows.Count - 1

                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGWAIT.Columns.Item(i).DataField.ToString)) And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then

                    num = 0
                    For m = 0 To dsWait.Tables(0).Rows.Count - 1
                        num = num + dsWait.Tables(0).Rows(m)(i)
                    Next
                    Me.C1DBGWAIT.Columns.Item(i).FooterText = CType(num, String)
                    Exit For
                End If
            Next
            i = i + 1
        Loop
        sqlconn.Close()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub SetColumnSumWork_Record(ByVal sql As String)
        On Error GoTo Err
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
        Dim dset2 As New DataSet
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Dim m As Integer
        Dim num As Double
        str = "select Field_Eng,Field_Type,IsOrNoSum From Field_Att where Table_Name='" & Trim(Table_Name) & "'"
        sqlconn.ConnectionString = conn
        sqlc.Connection = sqlconn
        sqlc.CommandText = str
        sqla.SelectCommand = sqlc
        dset.Reset()
        sqla.Fill(dset)

        i = ColNum
        Me.C1DBGWORK_RECORD.ColumnFooters = True
        Me.C1DBGWORK_RECORD.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGWORK_RECORD.Columns.Item(ColNum).FooterText = "合计 共" & dsWork_Record.Tables(0).Rows.Count & "条"
        Do While i < Me.C1DBGWORK_RECORD.Columns.Count
            j = 0
            For j = 0 To dset.Tables(0).Rows.Count - 1

                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGWORK_RECORD.Columns.Item(i).DataField.ToString)) And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then

                    num = 0
                    For m = 0 To dsWork_Record.Tables(0).Rows.Count - 1
                        num = num + dsWork_Record.Tables(0).Rows(m)(i)
                    Next
                    Me.C1DBGWORK_RECORD.Columns.Item(i).FooterText = CType(num, String)
                    Exit For
                End If
            Next
            i = i + 1
        Loop

        sqlconn.Close()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub SetColumnSumMeasure(ByVal sql As String)
        On Error GoTo Err
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
        Dim dset2 As New DataSet
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Dim m As Integer
        Dim num As Double
        str = "select Field_Eng,Field_Type,IsOrNoSum From Field_Att where Table_Name='" & Trim(Table_Name) & "'"
        sqlconn.ConnectionString = conn
        sqlc.Connection = sqlconn
        sqlc.CommandText = str
        sqla.SelectCommand = sqlc
        dset.Reset()
        sqla.Fill(dset)

        i = ColNum
        Me.C1DBGMEASURE.ColumnFooters = True
        Me.C1DBGMEASURE.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGMEASURE.Columns.Item(ColNum).FooterText = "合计 共" & dsMeasure.Tables(0).Rows.Count & "条"
        Do While i < Me.C1DBGMEASURE.Columns.Count
            j = 0
            For j = 0 To dset.Tables(0).Rows.Count - 1

                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGMEASURE.Columns.Item(i).DataField.ToString)) And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then

                    num = 0
                    For m = 0 To dsMeasure.Tables(0).Rows.Count - 1
                        num = num + dsMeasure.Tables(0).Rows(m)(i)
                    Next
                    Me.C1DBGMEASURE.Columns.Item(i).FooterText = CType(num, String)
                    Exit For
                End If
            Next
            i = i + 1
        Loop
        sqlconn.Close()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click, MenuItem8.Click
        Me.Close()
    End Sub

    Private Sub ToolBar_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar.ButtonClick
        Select Case Me.ToolBar.Buttons.IndexOf(e.Button)
            Case 0
                Call mnuFind_Click(sender, e)
            Case 1
                Call mnuDelete_Click(sender, e)
            Case 2
                Call mnuQuery_Click(sender, e)
                If SHIFTING_Flag = 1 Then
                    If OKQUERY = 1 Then
                        Call getdailyreport()
                    End If
                End If
                If SHIFTING_Flag = 2 Then
                    If OKQUERY_OTHER = 1 Then
                        Call getdailyreport_other()
                    End If
                End If
            Case 3
                sshipverify_rollbak(sender, e)
            Case 4
                Call mnuEdit_Click(sender, e)
            Case 9
                Me.Close()
        End Select
    End Sub

    Private Sub mnuFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFind.Click, MenuItem2.Click
         
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click, MenuItem12.Click
        Try
            If shipstatu <> 0 Then
                MsgBox("只能处理待审核航次！", MsgBoxStyle.OkOnly, "提示")
                Return
            End If
            Dim str_sql2 As String
            Dim dsship2 As New DataSet()
            str_sql2 = String.Format(" select ship_statu from tally_verify..sship where ship_id={0}", Ship_ID)
            Getdata(str_sql2, dsship2)
            If dsship2.Tables(0).Rows.Count > 0 Then
                MsgBox("本航次数据已审核完毕！", MsgBoxStyle.OkOnly, "提示")
                Return
            End If
            If MsgBox("确认通过本航次数据审核？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                '增加审核记录
                Dim str_sql As String
                str_sql = String.Format("insert into tally..SSHIP_verify select SHIP_ID, V_ID, ENG_VESSEL, CHI_VESSEL, VOYAGE, INOUTPORT,'{0}',getdate(),'初审1','{2}' from sship where ship_id={1}", G_User, Ship_ID, G_DeptCode)
                ExecSql(str_sql)
                str_sql = String.Format("sshipverify {0},'{1}','{2}'", Ship_ID, G_DeptCode, G_User)
                ExecSql(str_sql)

                str_sql = String.Format("sp_fee_standard  {0},'{1}','{2}'", Ship_ID, G_DeptCode, G_User)
                '生成标准账单 
                ExecSql(str_sql)
                '生成审核数据库的标准账单 
                ExecSql_ver(str_sql)
                Call btResure_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub sshipverify_rollbak(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If shipstatu <> 3 Then
                MsgBox("只能处理审核完的航次！", MsgBoxStyle.OkOnly, "提示")
                Return
            End If
            Dim str_sql2 As String
            Dim dsship2 As New DataSet()
            str_sql2 = String.Format(" select ship_statu from tally_verify..sship where ship_id={0}", Ship_ID)
            Getdata(str_sql2, dsship2)
            If dsship2.Tables(0).Rows.Count = 0 Then
                MsgBox("本航次数据未审核！", MsgBoxStyle.OkOnly, "提示")
                Return
            ElseIf dsship2.Tables(0).Rows(0)(0) = 4 Then
                MsgBox("该航次已复审完，无法撤销审核！", MsgBoxStyle.OkOnly, "提示")
                Return
            End If

            If MsgBox("确认删除本航次数据审核信息？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                '增加审核记录
                Dim str_sql As String
                str_sql = String.Format("insert into tally..SSHIP_verify select SHIP_ID, V_ID, ENG_VESSEL, CHI_VESSEL, VOYAGE, INOUTPORT,'{0}',getdate(),'撤销初审1','{2}' from sship where ship_id={1}", G_User, Ship_ID, G_DeptCode)
                ExecSql(str_sql)
                str_sql = String.Format("exec tally_verify..sshipverify_rollbak {0},'{1}','{2}'", Ship_ID, G_DeptCode, G_User)
                ExecSql(str_sql)
                Call btResure_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click, MenuItem11.Click
        Try
            If shipstatu <> 3 Then
                MsgBox("请先执行数据审核！", MsgBoxStyle.OkOnly, "提示")
                Return
            End If
            If MsgBox("你确认要将本航次完船吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                ExecSql("update sship set ship_statu='4' where ship_id=" & Ship_ID)
                Call btResure_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdd.Click, MenuItem10.Click
        
    End Sub

    Private Sub C1DBGTALLY_LIST_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1DBGTALLY_LIST.DoubleClick
        Call mnuQuery_Click(sender, e)
    End Sub

    Private Sub C1DBGWAIT_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1DBGWAIT.DoubleClick
        Call mnuQuery_Click(sender, e)
    End Sub

    Private Sub C1DBGWORK_RECORD_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1DBGWORK_RECORD.DoubleClick
        Call mnuQuery_Click(sender, e)
    End Sub

    Private Sub C1DBGMEASURE_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1DBGMEASURE.DoubleClick
        Call mnuQuery_Click(sender, e)
    End Sub

    Private Sub C1DBGTALLY_LIST_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C1DBGTALLY_LIST.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.C1DBGTALLY_LIST.Col = Me.C1DBGTALLY_LIST.Columns.Count - 1 And Me.C1DBGTALLY_LIST.Row < dsTally_List.Tables(0).Rows.Count - 1 Then
                Me.C1DBGTALLY_LIST.Row = Me.C1DBGTALLY_LIST.Row + 1
                Me.C1DBGTALLY_LIST.Col = ColNum
            End If
        End If
    End Sub

    Private Sub C1DBGWAIT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C1DBGWAIT.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.C1DBGWAIT.Col = Me.C1DBGWAIT.Columns.Count - 1 And Me.C1DBGWAIT.Row < dsWait.Tables(0).Rows.Count - 1 Then
                Me.C1DBGWAIT.Row = Me.C1DBGWAIT.Row + 1
                Me.C1DBGWAIT.Col = ColNum
            End If
        End If
    End Sub

    Private Sub C1DBGWORK_RECORD_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C1DBGWORK_RECORD.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.C1DBGWORK_RECORD.Col = Me.C1DBGWORK_RECORD.Columns.Count - 1 And Me.C1DBGWORK_RECORD.Row < dsWork_Record.Tables(0).Rows.Count - 1 Then
                Me.C1DBGWORK_RECORD.Row = Me.C1DBGWORK_RECORD.Row + 1
                Me.C1DBGWORK_RECORD.Col = ColNum
            End If
        End If
    End Sub

    Private Sub C1DBGMEASURE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C1DBGMEASURE.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.C1DBGMEASURE.Col = Me.C1DBGMEASURE.Columns.Count - 1 And Me.C1DBGMEASURE.Row < dsMeasure.Tables(0).Rows.Count - 1 Then
                Me.C1DBGMEASURE.Row = Me.C1DBGMEASURE.Row + 1
                Me.C1DBGMEASURE.Col = ColNum
            End If
        End If
    End Sub

    Private Sub mnuQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuery.Click, MenuItem3.Click
         
    End Sub
      
    Private Sub Frm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.C1DBGV.Height = Me.Height - 140
        'Me.C1DBGTALLY_LIST.Height = Me.Height - 100
        Me.C1DBGTALLY_LIST.Height = Me.TabTALLY_LIST.Height - 3
        Me.C1DBGTALLY_LIST.Width = Me.TabTALLY_LIST.Width - 3
        Me.Label.Width = Me.Panel1.Width - 3
        Me.C1DBGWAIT.Height = Me.TabWAIT.Height - 3
        Me.C1DBGWAIT.Width = Me.TabWAIT.Width - 3
        Me.C1DBGWORK_RECORD.Height = Me.TabWORK_RECORD.Height - 3
        Me.C1DBGWORK_RECORD.Width = Me.TabWORK_RECORD.Width - 3
        Me.C1DBGMEASURE.Height = Me.TabMEASURE.Height - 3
        Me.C1DBGMEASURE.Width = Me.TabMEASURE.Width - 3
        Me.C1DBGDaily_report.Height = Me.TabDaily.Height - 3
        Me.C1DBGDaily_report.Width = Me.TabDaily.Width - 3
        Me.C1DBGDaily_other.Height = Me.TabDailyother.Height - 3
        Me.C1DBGDaily_other.Width = Me.TabDailyother.Width - 3
        Me.Label1.Top = Me.C1DBGV.Height + 20
        Me.txtShipName.Top = Me.C1DBGV.Height + 20
        Me.Label2.Top = Me.C1DBGV.Height + 40
        Me.txtVoyage.Top = Me.C1DBGV.Height + 40
        Me.btResure.Top = Me.C1DBGV.Height + 40
    End Sub

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        TBar = 1
        Mnu = 1
    End Sub

    Private Sub btResure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResure.Click
        SqlStrShip = "where (((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('0','3'))) and Voyage like '" & Trim(txtVoyage.Text) & "%' and (ENG_VESSEL Like '" & Trim(txtShipName.Text) & "%' OR CHI_VESSEL like '" & Trim(txtShipName.Text) & "%' ))  and code_goods<>'2' "
        G_ShipName = Trim(txtShipName.Text)
        G_Voyage = Trim(txtVoyage.Text)
        Call myDataGridShip(SqlStrShip & inoutstr & SortShip)
        Call C1DBGV_DoubleClick(sender, e)
    End Sub

    Private Sub txtShipName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtShipName.KeyPress
        If e.KeyChar = Chr(13) Then
            txtVoyage.Focus()
        End If
    End Sub

    Private Sub txtVoyage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVoyage.KeyPress
        If e.KeyChar = Chr(13) Then
            Call btResure_Click(sender, e)
        End If
    End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabShipInfo.Click
        ToolBar.Buttons.Item(0).Enabled = False
        mnuFind.Enabled = False
        ToolBar.Buttons.Item(1).Enabled = True
        ToolBar.Buttons.Item(4).Enabled = True
        ToolBar.Buttons.Item(6).Enabled = True
        mnuPrint.Enabled = True
        ToolBar.Buttons.Item(9).Enabled = True

        Select Case Me.TabShipInfo.SelectedIndex
            Case 0
                ToolBar.Buttons.Item(2).Enabled = False
                mnuQuery.Enabled = False
                ToolBar.Buttons.Item(6).Enabled = False
                mnuPrint.Enabled = False
            Case 1
                ToolBar.Buttons.Item(0).Enabled = True
                mnuFind.Enabled = True
                ToolBar.Buttons.Item(2).Enabled = True
                mnuQuery.Enabled = True
            Case 2
                ToolBar.Buttons.Item(2).Enabled = True
                mnuQuery.Enabled = True
            Case 3
                ToolBar.Buttons.Item(2).Enabled = True
                mnuQuery.Enabled = True
            Case 4
                ToolBar.Buttons.Item(2).Enabled = True
                mnuQuery.Enabled = True
            Case 5
                ToolBar.Buttons.Item(2).Enabled = False
                mnuQuery.Enabled = True
            Case 6
                ToolBar.Buttons.Item(2).Enabled = False
                mnuQuery.Enabled = True
        End Select
    End Sub

    Private Sub cmbreport_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbreport.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub cmbreportOth_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbreportOth.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button2_Click(sender, e)
        End If
    End Sub
End Class

