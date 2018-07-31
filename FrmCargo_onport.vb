Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Imports SMS

Public Class FrmCargo_onport
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
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
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtupload As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCargo_onport))
        Me.GBV = New System.Windows.Forms.GroupBox()
        Me.ToolBarV = New System.Windows.Forms.ToolBar()
        Me.S1 = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnOK = New System.Windows.Forms.ToolBarButton()
        Me.S2 = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnSearch = New System.Windows.Forms.ToolBarButton()
        Me.S3 = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnSort = New System.Windows.Forms.ToolBarButton()
        Me.S4 = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnEng = New System.Windows.Forms.ToolBarButton()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.btResure = New System.Windows.Forms.Button()
        Me.txtVoyage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtShipName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.C1DBGV = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.GB = New System.Windows.Forms.GroupBox()
        Me.ToolBar = New System.Windows.Forms.ToolBar()
        Me.tbbtnFind = New System.Windows.Forms.ToolBarButton()
        Me.tbbtndo = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnQuery = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnAdd = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnEdit = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnDelete = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnPrint = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnExport = New System.Windows.Forms.ToolBarButton()
        Me.tbbtupload = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnQuit = New System.Windows.Forms.ToolBarButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabTALLY_LIST = New System.Windows.Forms.TabPage()
        Me.C1DBGTALLY_LIST = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.TabWAIT = New System.Windows.Forms.TabPage()
        Me.C1DBGWAIT = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.TabWORK_RECORD = New System.Windows.Forms.TabPage()
        Me.C1DBGWORK_RECORD = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.TabMEASURE = New System.Windows.Forms.TabPage()
        Me.C1DBGMEASURE = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.TabDaily = New System.Windows.Forms.TabPage()
        Me.C1DBGDaily_report = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.TabDailyother = New System.Windows.Forms.TabPage()
        Me.C1DBGDaily_other = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.LabREMARKS = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.MainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuFind = New System.Windows.Forms.MenuItem()
        Me.mnuQuery = New System.Windows.Forms.MenuItem()
        Me.mnuSep1 = New System.Windows.Forms.MenuItem()
        Me.mnuPrint = New System.Windows.Forms.MenuItem()
        Me.mnuExport = New System.Windows.Forms.MenuItem()
        Me.mnuSep2 = New System.Windows.Forms.MenuItem()
        Me.mnuQuit = New System.Windows.Forms.MenuItem()
        Me.mnuCompile = New System.Windows.Forms.MenuItem()
        Me.mnuAdd = New System.Windows.Forms.MenuItem()
        Me.mnuEdit = New System.Windows.Forms.MenuItem()
        Me.mnuDelete = New System.Windows.Forms.MenuItem()
        Me.mnuHelp = New System.Windows.Forms.MenuItem()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.GBV.SuspendLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabTALLY_LIST.SuspendLayout()
        CType(Me.C1DBGTALLY_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabWAIT.SuspendLayout()
        CType(Me.C1DBGWAIT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabWORK_RECORD.SuspendLayout()
        CType(Me.C1DBGWORK_RECORD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMEASURE.SuspendLayout()
        CType(Me.C1DBGMEASURE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDaily.SuspendLayout()
        CType(Me.C1DBGDaily_report, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDailyother.SuspendLayout()
        CType(Me.C1DBGDaily_other, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GBV.Size = New System.Drawing.Size(174, 401)
        Me.GBV.TabIndex = 5
        Me.GBV.TabStop = False
        '
        'ToolBarV
        '
        Me.ToolBarV.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.S1, Me.tbbtnOK, Me.S2, Me.tbbtnSearch, Me.S3, Me.tbbtnSort, Me.S4, Me.tbbtnEng})
        Me.ToolBarV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBarV.DropDownArrows = True
        Me.ToolBarV.ImageList = Me.ImageList
        Me.ToolBarV.Location = New System.Drawing.Point(3, 357)
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
        Me.C1DBGV.PreviewInfo.ZoomFactor = 75.0R
        Me.C1DBGV.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGV.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGV.Size = New System.Drawing.Size(168, 289)
        Me.C1DBGV.TabIndex = 0
        Me.C1DBGV.Text = "C1TrueDBGrid1"
        Me.C1DBGV.PropBag = resources.GetString("C1DBGV.PropBag")
        '
        'GB
        '
        Me.GB.Controls.Add(Me.ToolBar)
        Me.GB.Controls.Add(Me.TabControl1)
        Me.GB.Controls.Add(Me.LabREMARKS)
        Me.GB.Controls.Add(Me.Label)
        Me.GB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB.Location = New System.Drawing.Point(174, 0)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(580, 401)
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
        Me.ToolBar.Size = New System.Drawing.Size(574, 41)
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
        Me.tbbtndo.Text = "处理"
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
        Me.tbbtnAdd.Text = "增加"
        Me.tbbtnAdd.ToolTipText = "增加"
        '
        'tbbtnEdit
        '
        Me.tbbtnEdit.ImageIndex = 3
        Me.tbbtnEdit.Name = "tbbtnEdit"
        Me.tbbtnEdit.Text = "编辑"
        Me.tbbtnEdit.ToolTipText = "编辑"
        '
        'tbbtnDelete
        '
        Me.tbbtnDelete.ImageIndex = 4
        Me.tbbtnDelete.Name = "tbbtnDelete"
        Me.tbbtnDelete.Text = "删除"
        Me.tbbtnDelete.ToolTipText = "删除"
        '
        'tbbtnPrint
        '
        Me.tbbtnPrint.ImageIndex = 5
        Me.tbbtnPrint.Name = "tbbtnPrint"
        Me.tbbtnPrint.Text = "打印"
        Me.tbbtnPrint.ToolTipText = "打印"
        '
        'tbbtnExport
        '
        Me.tbbtnExport.ImageIndex = 6
        Me.tbbtnExport.Name = "tbbtnExport"
        Me.tbbtnExport.Text = "单条打印"
        Me.tbbtnExport.ToolTipText = "导出Excel"
        '
        'tbbtupload
        '
        Me.tbbtupload.ImageIndex = 12
        Me.tbbtupload.Name = "tbbtupload"
        Me.tbbtupload.Text = "存储数据"
        Me.tbbtupload.ToolTipText = "存储数据"
        '
        'tbbtnQuit
        '
        Me.tbbtnQuit.ImageIndex = 7
        Me.tbbtnQuit.Name = "tbbtnQuit"
        Me.tbbtnQuit.Text = "退出"
        Me.tbbtnQuit.ToolTipText = "退出"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabTALLY_LIST)
        Me.TabControl1.Controls.Add(Me.TabWAIT)
        Me.TabControl1.Controls.Add(Me.TabWORK_RECORD)
        Me.TabControl1.Controls.Add(Me.TabMEASURE)
        Me.TabControl1.Controls.Add(Me.TabDaily)
        Me.TabControl1.Controls.Add(Me.TabDailyother)
        Me.TabControl1.Location = New System.Drawing.Point(6, 124)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(570, 274)
        Me.TabControl1.TabIndex = 15
        '
        'TabTALLY_LIST
        '
        Me.TabTALLY_LIST.Controls.Add(Me.C1DBGTALLY_LIST)
        Me.TabTALLY_LIST.Location = New System.Drawing.Point(4, 22)
        Me.TabTALLY_LIST.Name = "TabTALLY_LIST"
        Me.TabTALLY_LIST.Size = New System.Drawing.Size(562, 248)
        Me.TabTALLY_LIST.TabIndex = 0
        Me.TabTALLY_LIST.Text = "计数单"
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
        Me.C1DBGTALLY_LIST.PreviewInfo.ZoomFactor = 75.0R
        Me.C1DBGTALLY_LIST.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGTALLY_LIST.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGTALLY_LIST.Size = New System.Drawing.Size(322, 161)
        Me.C1DBGTALLY_LIST.TabIndex = 11
        Me.C1DBGTALLY_LIST.Text = "C1DBG"
        Me.C1DBGTALLY_LIST.PropBag = resources.GetString("C1DBGTALLY_LIST.PropBag")
        '
        'TabWAIT
        '
        Me.TabWAIT.Controls.Add(Me.C1DBGWAIT)
        Me.TabWAIT.Location = New System.Drawing.Point(4, 22)
        Me.TabWAIT.Name = "TabWAIT"
        Me.TabWAIT.Size = New System.Drawing.Size(562, 248)
        Me.TabWAIT.TabIndex = 1
        Me.TabWAIT.Text = "待时记录"
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
        Me.C1DBGWAIT.PreviewInfo.ZoomFactor = 75.0R
        Me.C1DBGWAIT.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGWAIT.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGWAIT.Size = New System.Drawing.Size(322, 161)
        Me.C1DBGWAIT.TabIndex = 12
        Me.C1DBGWAIT.Text = "C1DBG"
        Me.C1DBGWAIT.PropBag = resources.GetString("C1DBGWAIT.PropBag")
        '
        'TabWORK_RECORD
        '
        Me.TabWORK_RECORD.Controls.Add(Me.C1DBGWORK_RECORD)
        Me.TabWORK_RECORD.Location = New System.Drawing.Point(4, 22)
        Me.TabWORK_RECORD.Name = "TabWORK_RECORD"
        Me.TabWORK_RECORD.Size = New System.Drawing.Size(562, 248)
        Me.TabWORK_RECORD.TabIndex = 2
        Me.TabWORK_RECORD.Text = "现场记录"
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
        Me.C1DBGWORK_RECORD.PreviewInfo.ZoomFactor = 75.0R
        Me.C1DBGWORK_RECORD.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGWORK_RECORD.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGWORK_RECORD.Size = New System.Drawing.Size(314, 135)
        Me.C1DBGWORK_RECORD.TabIndex = 12
        Me.C1DBGWORK_RECORD.Text = "C1DBG"
        Me.C1DBGWORK_RECORD.PropBag = resources.GetString("C1DBGWORK_RECORD.PropBag")
        '
        'TabMEASURE
        '
        Me.TabMEASURE.Controls.Add(Me.C1DBGMEASURE)
        Me.TabMEASURE.Location = New System.Drawing.Point(4, 22)
        Me.TabMEASURE.Name = "TabMEASURE"
        Me.TabMEASURE.Size = New System.Drawing.Size(562, 248)
        Me.TabMEASURE.TabIndex = 3
        Me.TabMEASURE.Text = "丈量单"
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
        Me.C1DBGMEASURE.PreviewInfo.ZoomFactor = 75.0R
        Me.C1DBGMEASURE.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGMEASURE.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGMEASURE.Size = New System.Drawing.Size(322, 161)
        Me.C1DBGMEASURE.TabIndex = 12
        Me.C1DBGMEASURE.Text = "C1DBG"
        Me.C1DBGMEASURE.PropBag = resources.GetString("C1DBGMEASURE.PropBag")
        '
        'TabDaily
        '
        Me.TabDaily.Controls.Add(Me.C1DBGDaily_report)
        Me.TabDaily.Location = New System.Drawing.Point(4, 22)
        Me.TabDaily.Name = "TabDaily"
        Me.TabDaily.Size = New System.Drawing.Size(562, 248)
        Me.TabDaily.TabIndex = 4
        Me.TabDaily.Text = "日报"
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
        Me.C1DBGDaily_report.Location = New System.Drawing.Point(2, 2)
        Me.C1DBGDaily_report.Name = "C1DBGDaily_report"
        Me.C1DBGDaily_report.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGDaily_report.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGDaily_report.PreviewInfo.ZoomFactor = 75.0R
        Me.C1DBGDaily_report.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGDaily_report.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGDaily_report.Size = New System.Drawing.Size(322, 161)
        Me.C1DBGDaily_report.TabIndex = 12
        Me.C1DBGDaily_report.Text = "C1DBG"
        Me.C1DBGDaily_report.PropBag = resources.GetString("C1DBGDaily_report.PropBag")
        '
        'TabDailyother
        '
        Me.TabDailyother.Controls.Add(Me.C1DBGDaily_other)
        Me.TabDailyother.Location = New System.Drawing.Point(4, 22)
        Me.TabDailyother.Name = "TabDailyother"
        Me.TabDailyother.Size = New System.Drawing.Size(562, 248)
        Me.TabDailyother.TabIndex = 5
        Me.TabDailyother.Text = "翻舱日报"
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
        Me.C1DBGDaily_other.Location = New System.Drawing.Point(2, 2)
        Me.C1DBGDaily_other.Name = "C1DBGDaily_other"
        Me.C1DBGDaily_other.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGDaily_other.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGDaily_other.PreviewInfo.ZoomFactor = 75.0R
        Me.C1DBGDaily_other.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGDaily_other.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGDaily_other.Size = New System.Drawing.Size(322, 161)
        Me.C1DBGDaily_other.TabIndex = 13
        Me.C1DBGDaily_other.Text = "C1DBG"
        Me.C1DBGDaily_other.PropBag = resources.GetString("C1DBGDaily_other.PropBag")
        '
        'LabREMARKS
        '
        Me.LabREMARKS.Location = New System.Drawing.Point(6, 98)
        Me.LabREMARKS.Name = "LabREMARKS"
        Me.LabREMARKS.Size = New System.Drawing.Size(530, 24)
        Me.LabREMARKS.TabIndex = 12
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.SystemColors.Control
        Me.Label.Location = New System.Drawing.Point(6, 60)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(530, 34)
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
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem9, Me.MenuItem13, Me.MenuItem14})
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
        'MenuItem14
        '
        Me.MenuItem14.Index = 3
        Me.MenuItem14.Text = "短信平台"
        '
        'FrmCargo_onport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(754, 401)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.GBV)
        Me.Menu = Me.MainMenu1
        Me.Name = "FrmCargo_onport"
        Me.Text = "现场资料"
        Me.GBV.ResumeLayout(False)
        Me.GBV.PerformLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabTALLY_LIST.ResumeLayout(False)
        CType(Me.C1DBGTALLY_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabWAIT.ResumeLayout(False)
        CType(Me.C1DBGWAIT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabWORK_RECORD.ResumeLayout(False)
        CType(Me.C1DBGWORK_RECORD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMEASURE.ResumeLayout(False)
        CType(Me.C1DBGMEASURE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabDaily.ResumeLayout(False)
        CType(Me.C1DBGDaily_report, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabDailyother.ResumeLayout(False)
        CType(Me.C1DBGDaily_other, System.ComponentModel.ISupportInitialize).EndInit()
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

    Dim SqlStr As String  '条件语句
    Dim SelectStr As String
    Dim DynaStr As String '可变的条件设计
    Dim FirmStr As String '不变的条件设计
    ', FirmTally, FirmWait, FirmWorkRecord, FirmMeasure, FirmDaily
    Dim ColNum As Integer '不显示的列数
    Dim SHIFTING_Flag As Integer '翻舱标示
    Dim aorb As String

    Private Sub FrmCargo_onport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SHIFTING_Flag = 0
        Me.WindowState = FormWindowState.Maximized
        Me.Text = Me.Text & "_" & G_DeptName
        SortShip = " Order by Ship_Statu,Dept_Code,id desc " '默认的排序 
        FirmShip = "where DEPT_CODE LIKE '" & G_DeptCode & "%' and code_goods<>'2' " '船舶不变的条件设计
        SqlStrShip = "where (DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('2','3','0')) and code_goods<>'2' " ' OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) "
        Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '*****************调用航次信息
        Me.C1DBGV.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        txtShipName.Text = G_ShipName
        txtVoyage.Text = G_Voyage
        Call btResure_Click(sender, e)
    End Sub

    Private Sub myDataGridShip(ByVal Sql As String) '**************航次信息
        Dim strsql As String
        Dim i As Integer
        strsql = "select SHIP_ID as ID ,SHIP_STATU,INOUTPORT,DEPT_CODE,ENG_VESSEL,CHI_VESSEL,VOYAGE,InOutPort_Name,Dept_Short from View_SSHip " '船舶条件语句 不改部分
        strsql = strsql & Sql
        Try
            Me.C1DBGV.DataSource = Getdata(strsql, dsShip)
            For i = 0 To 4 '设计部显示的列
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
                SqlStrShip = "where (DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('2','3','0'))  and code_goods<>'2' " 'OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) " '船舶可变的条件设计
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
                    SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','4','0')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0))  and code_goods<>'2' "
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
        If Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 1 Then
            e.CellStyle.BackColor = System.Drawing.Color.White
        ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 2 Then
            e.CellStyle.BackColor = System.Drawing.Color.PaleGreen
        ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 3 Then
            e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
        ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 4 Then
            e.CellStyle.BackColor = System.Drawing.Color.Pink
        ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 0 Then
            e.CellStyle.BackColor = System.Drawing.Color.Cyan
        End If
    End Sub

    Private Sub C1DBGV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBGV.DoubleClick
        On Error GoTo Err
        Dim dsShip As New DataSet
        Dim strsql As String
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
        Call preview("WL4_1") '*****************权限设计 '*************要修改模块号
        'Call TabControl1_TabIndexChanged(sender, e)
        Call TabControl1_Click(sender, e)
        Call getTallylist(FirmStr)    '计数单
        Call getwait(FirmStr)         '待时记录
        Call getworkrecord(FirmStr)   '现场记录
        Call getmeasure(FirmStr)      '丈量单

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
        'Me.ToolBar.Buttons.Item(8).Enabled = True
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub getTallylist(ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            '不显示的列名在最前面
            strsql = "select  ID, SHIP_ID, TEAM_NO, NO, NAME_BERTH, DESCR, HATCH_Position, MARK, cast(amount as dec(10,0)) as amount, DATE, TIME_FROM, TIME_TO, name1, CROSS_PERSON, name2 from VIEW_Tally_sheet  where " & Sql '******要修改
            Me.C1DBGTALLY_LIST.DataSource = Getdata(strsql, dsTally_List)  ' class dbcontrol getdata fuction
            ColNum = 2 '不显示的列数 '******要修改
            Table_Name = "VIEW_Tally_sheet" '操作的数据库表名 ''******要修改

            For i = 0 To ColNum - 1 '设计部显示的列
                Me.C1DBGTALLY_LIST.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Translate = True
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Validate = True
            'Me.C1DBG.Splits(0).DisplayColumns.Item("Logic").Visible = False
            Me.C1DBGTALLY_LIST.Columns.Item("Date").NumberFormat = "yyyy/MM/dd"

            Call SetColumnCaptionTally_List() '设计列标题
            Call SetColumnWidthTally_list() '设计列宽度
            If dsTally_List.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumTally_List(Sql) '设计合计列
            End If
            Me.C1DBGTALLY_LIST.Refresh()
            Me.C1DBGTALLY_LIST.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色
            Me.C1DBGTALLY_LIST.MoveLast()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getwait(ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            '不显示的列名在最前面
            strsql = "select  *  from VIEW_CARGO_WAITFOR  where " & Sql '******要修改

            Me.C1DBGWAIT.DataSource = Getdata(strsql, dsWait)  ' class dbcontrol getdata fuction
            ColNum = 2 '不显示的列数 '******要修改
            Table_Name = "VIEW_CARGO_WAITFOR" '操作的数据库表名 ''******要修改

            For i = 0 To ColNum - 1 '设计部显示的列
                Me.C1DBGWAIT.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Me.C1DBGWAIT.Columns.Item("STANDBYDATE").NumberFormat = "yyyy/MM/dd"

            Call SetColumnCaptionWait() '设计列标题
            Call SetColumnWidthWait() '设计列宽度
            If dsWait.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumWait(Sql) '设计合计列
            End If

            Me.C1DBGWAIT.Refresh()
            Me.C1DBGWAIT.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色
            Me.C1DBGWAIT.MoveLast()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getworkrecord(ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            '不显示的列名在最前面
            strsql = "select  *  from VIEW_WORK_RECORD_new  where " & Sql '******要修改

            Me.C1DBGWORK_RECORD.DataSource = Getdata(strsql, dsWork_Record)  ' class dbcontrol getdata fuction
            ColNum = 2 '不显示的列数 '******要修改
            Table_Name = "VIEW_WORK_RECORD" '操作的数据库表名 ''******要修改

            For i = 0 To ColNum - 1 '设计部显示的列
                Me.C1DBGWORK_RECORD.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Translate = True
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Validate = True
            'Me.C1DBG.Splits(0).DisplayColumns.Item("Logic").Visible = False
            Me.C1DBGWORK_RECORD.Columns.Item("RECORD_DAY").NumberFormat = "yyyy/MM/dd"

            Call SetColumnCaptionWorkRecord() '设计列标题
            Call SetColumnWidthWork_Record() '设计列宽度
            If dsWork_Record.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumWork_Record(Sql) '设计合计列
            End If
            'Me.C1DBG.FetchRowStyles = True
            Me.C1DBGWORK_RECORD.Refresh()
            Me.C1DBGWORK_RECORD.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色
            Me.C1DBGWORK_RECORD.MoveLast()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getmeasure(ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            '不显示的列名在最前面
            strsql = "select *  from VIEW_CARGO_MEASURE_LIST  where " & Sql '******要修改

            Me.C1DBGMEASURE.DataSource = Getdata(strsql, dsMeasure)  ' class dbcontrol getdata fuction
            ColNum = 2 '不显示的列数 '******要修改
            Table_Name = "VIEW_CARGO_MEASURE_LIST" '操作的数据库表名 ''******要修改

            For i = 0 To ColNum - 1 '设计部显示的列
                Me.C1DBGMEASURE.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Translate = True
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Validate = True
            'Me.C1DBG.Splits(0).DisplayColumns.Item("Logic").Visible = False

            Call SetColumnCaptionMeasure() '设计列标题
            Call SetColumnWidthMeasure() '设计列宽度
            If dsMeasure.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumMeasure(Sql) '设计合计列
            End If
            'Me.C1DBG.FetchRowStyles = True
            Me.C1DBGMEASURE.Refresh()
            Me.C1DBGMEASURE.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色
            Me.C1DBGMEASURE.MoveLast()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getdailyreport()
        Dim strsql As String
        Dim i As Integer
        Try
            Me.C1DBGDaily_report.DataSource = dsdaily.Tables(0).DefaultView
            LabREMARKS.Text = REMARKS
            ColNum = 0                       '不显示的列数       '******要修改
            Table_Name = "SP_daily_report"   '操作的数据库表名   '******要修改

            For i = 0 To ColNum - 1
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
            End If

            Call SetColumnCaptionDailyReport() '设计列标题
            Call SetColumnWidthDaily() '设计列宽度
            'If dsdaily.Tables(0).Rows.Count > 0 Then
            '    Call SetColumnSum(Sql) '设计合计列
            'End If
            'Me.C1DBG.FetchRowStyles = True
            Me.C1DBGDaily_report.Refresh()
            Me.C1DBGDaily_report.AllowSort = False
            Me.C1DBGDaily_report.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色
            Me.C1DBGDaily_report.MoveLast()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getdailyreport_other()
        Dim strsql As String
        Dim i As Integer
        Try
            Me.C1DBGDaily_other.DataSource = dsdaily_other.Tables(0).DefaultView
            LabREMARKS.Text = REMARKS_OTHER
            ColNum = 0                       '不显示的列数       '******要修改
            Table_Name = "SP_daily_report"   '操作的数据库表名   '******要修改

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
            End If

            Call SetColumnCaptionDailyReport() '设计列标题
            Call SetColumnWidthDaily() '设计列宽度
            'If dsdaily.Tables(0).Rows.Count > 0 Then
            '    Call SetColumnSum(Sql) '设计合计列
            'End If
            'Me.C1DBG.FetchRowStyles = True
            Me.C1DBGDaily_other.Refresh()
            Me.C1DBGDaily_other.AllowSort = False
            Me.C1DBGDaily_other.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色
            Me.C1DBGDaily_other.MoveLast()
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
                If SHIFTING_Flag = 1 Then
                    Dim frm As New FrmCARGO_DAILY_REPORT_DO
                    frm.ShowDialog()
                    If OKMARK = 1 Then
                        Call getdailyreport()
                    End If
                End If
                If SHIFTING_Flag = 2 Then
                    Dim frm As New FrmCARGO_DAILY_REPORT_OTHER
                    frm.ShowDialog()
                    If OKMARK_OTHER = 1 Then
                        Call getdailyreport_other()
                    End If
                End If
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
                Call mnuAdd_Click(sender, e)
            Case 4
                Call mnuEdit_Click(sender, e)
            Case 5
                Call mnuDelete_Click(sender, e)
            Case 6
                Call mnuPrint_Click(sender, e)
            Case 7
                Call mnuExport_Click(sender, e)
            Case 8
                ID = CType(Me.C1DBGV.Columns.Item("ID").Text.ToString, Integer)
                If IsDBNull(ID) = False Then
                    Dim Frm As New FrmFileView
                    Frm.ShowDialog()
                End If
            Case 9
                Me.Close()
        End Select
    End Sub

    Private Sub mnuFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFind.Click, MenuItem2.Click
        Dim FrmFind As New FrmFind
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                Table_Name = "VIEW_Tally_sheet" '可能要修改
                FrmFind.ShowDialog()

                If Flag = 0 Then
                    SelectStr = ""
                    Call getTallylist(" (" & Sql_Find & ")  " & FirmStr)   '可能要修改
                    SqlStr = " (" & Sql_Find & ")  " & FirmStr '可能要修改
                ElseIf Flag = 2 Then
                    SelectStr = ""
                    Call getTallylist(DynaStr & FirmStr)   '可能要修改
                    SqlStr = DynaStr & FirmStr '可能要修改
                End If
            Case 1
                Table_Name = "VIEW_CARGO_WAITFOR" '可能要修改
                FrmFind.ShowDialog()

                If Flag = 0 Then
                    SelectStr = ""
                    Call getwait(" (" & Sql_Find & ")  " & FirmStr)   '可能要修改
                    SqlStr = " (" & Sql_Find & ")  " & FirmStr '可能要修改
                ElseIf Flag = 2 Then
                    SelectStr = ""
                    Call getwait(DynaStr & FirmStr)   '可能要修改
                    SqlStr = DynaStr & FirmStr '可能要修改
                End If
            Case 2
                Table_Name = "VIEW_WORK_RECORD" '可能要修改
                FrmFind.ShowDialog()

                If Flag = 0 Then
                    SelectStr = ""
                    Call getworkrecord(" (" & Sql_Find & ")  " & FirmStr)   '可能要修改
                    SqlStr = " (" & Sql_Find & ")  " & FirmStr '可能要修改
                ElseIf Flag = 2 Then
                    SelectStr = ""
                    Call getworkrecord(DynaStr & FirmStr)   '可能要修改
                    SqlStr = DynaStr & FirmStr '可能要修改
                End If
            Case 3
                Table_Name = "VIEW_CARGO_MEASURE_LIST" '可能要修改
                FrmFind.ShowDialog()

                If Flag = 0 Then
                    SelectStr = ""
                    Call getmeasure(" (" & Sql_Find & ")  " & FirmStr)   '可能要修改
                    SqlStr = " (" & Sql_Find & ")  " & FirmStr '可能要修改
                ElseIf Flag = 2 Then
                    SelectStr = ""
                    Call getmeasure(DynaStr & FirmStr)   '可能要修改
                    SqlStr = DynaStr & FirmStr '可能要修改
                End If

        End Select
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click, MenuItem12.Click
        Try
            Select Case Me.TabControl1.SelectedIndex
                Case 0
                    If dsTally_List.Tables(0).Rows.Count > 0 Then
                        Dim FrmDelete As New FrmTally_sheet_delete   '***********计数单
                        ID = CType(Me.C1DBGTALLY_LIST.Columns.Item("ID").Text.ToString, Integer)
                        FrmDelete.ShowDialog()
                        Try
                            Call getTallylist(SqlStr)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
                Case 1
                    If dsWait.Tables(0).Rows.Count > 0 Then
                        Dim FrmDelete As New FrmCARGO_WAITFOR_DELETE   '***********待时记录
                        ID = CType(Me.C1DBGWAIT.Columns.Item("ID").Text.ToString, Integer)
                        FrmDelete.ShowDialog()
                        Try
                            Call getwait(SqlStr)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
                Case 2
                    If dsWork_Record.Tables(0).Rows.Count > 0 Then
                        Dim FrmDelete As New FrmWORK_RECORD_DELETE   '***********现场记录
                        ID = CType(Me.C1DBGWORK_RECORD.Columns.Item("ID").Text.ToString, Integer)
                        FrmDelete.ShowDialog()
                        Try
                            Call getworkrecord(SqlStr)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
                Case 3
                    If dsMeasure.Tables(0).Rows.Count > 0 Then
                        Dim FrmDelete As New FrmCARGO_MEASURE_LIST_DELETE   '***********丈量单
                        ID = CType(Me.C1DBGMEASURE.Columns.Item("ID").Text.ToString, Integer)
                        FrmDelete.ShowDialog()
                        Try
                            Call getmeasure(SqlStr)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click, MenuItem11.Click
        Try
            Select Case Me.TabControl1.SelectedIndex
                Case 0
                    If dsTally_List.Tables(0).Rows.Count > 0 Then
                        Dim FrmEdit As New FrmTally_sheet_edit   '***********要修改
                        Dim Row As Integer
                        ID = CType(Me.C1DBGTALLY_LIST.Columns.Item("ID").Text.ToString, Integer)
                        Row = Me.C1DBGTALLY_LIST.Row
                        FrmEdit.ShowDialog()
                        Try
                            Call getTallylist(SqlStr)
                            Me.C1DBGTALLY_LIST.Row = Row
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
                Case 1
                    If dsWait.Tables(0).Rows.Count > 0 Then
                        Dim FrmEdit As New FrmCARGO_WAITFOR_EDIT   '***********要修改
                        Dim Row As Integer
                        ID = CType(Me.C1DBGWAIT.Columns.Item("ID").Text.ToString, Integer)
                        Row = Me.C1DBGWAIT.Row
                        FrmEdit.ShowDialog()
                        Try
                            Call getwait(SqlStr)
                            Me.C1DBGWAIT.Row = Row
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
                Case 2
                    If dsWork_Record.Tables(0).Rows.Count > 0 Then
                        Dim FrmEdit As New FrmWORK_RECORD_EDIT   '***********要修改
                        Dim Row As Integer
                        ID = CType(Me.C1DBGWORK_RECORD.Columns.Item("ID").Text.ToString, Integer)
                        Row = Me.C1DBGWORK_RECORD.Row
                        FrmEdit.ShowDialog()
                        Try
                            Call getworkrecord(SqlStr)
                            Me.C1DBGWORK_RECORD.Row = Row
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
                Case 3
                    If dsMeasure.Tables(0).Rows.Count > 0 Then
                        Dim FrmEdit As New FrmCARGO_MEASURE_LIST_EDIT   '***********要修改
                        Dim Row As Integer
                        ID = CType(Me.C1DBGMEASURE.Columns.Item("ID").Text.ToString, Integer)
                        Row = Me.C1DBGMEASURE.Row
                        FrmEdit.ShowDialog()
                        Try
                            Call getmeasure(SqlStr)
                            Me.C1DBGMEASURE.Row = Row
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdd.Click, MenuItem10.Click
        Try
            Select Case Me.TabControl1.SelectedIndex
                Case 0
                    Dim FrmAdd As New FrmTally_sheet_add   '***********要修改
                    If dsTally_List.Tables(0).Rows.Count > 0 Then
                        ID = CType(Me.C1DBGTALLY_LIST.Columns.Item("ID").Text.ToString, Integer)
                    Else
                        ID = -1
                    End If
                    FrmAdd.ShowDialog()
                    Try
                        Call getTallylist(SqlStr)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Case 1
                    Dim FrmAdd As New FrmCARGO_WAITFOR_ADD   '***********要修改
                    If dsWait.Tables(0).Rows.Count > 0 Then
                        ID = CType(Me.C1DBGWAIT.Columns.Item("ID").Text.ToString, Integer)
                    Else
                        ID = -1
                    End If
                    FrmAdd.ShowDialog()
                    Try
                        Call getwait(SqlStr)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Case 2
                    Dim FrmAdd As New FrmWORK_RECORD_ADD   '***********要修改
                    If dsWork_Record.Tables(0).Rows.Count > 0 Then
                        ID = CType(Me.C1DBGWORK_RECORD.Columns.Item("ID").Text.ToString, Integer)
                    Else
                        ID = -1
                    End If
                    FrmAdd.ShowDialog()
                    Try
                        Call getworkrecord(SqlStr)

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Case 3
                    Dim FrmAdd As New FrmCARGO_MEASURE_LIST_ADD   '***********要修改
                    If dsMeasure.Tables(0).Rows.Count > 0 Then
                        ID = CType(Me.C1DBGMEASURE.Columns.Item("ID").Text.ToString, Integer)
                    Else
                        ID = -1
                    End If
                    FrmAdd.ShowDialog()
                    Try
                        Call getmeasure(SqlStr)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                If dsTally_List.Tables(0).Rows.Count > 0 Then
                    Dim FrmQuery As New FrmTally_sheet_query   '***********要修改
                    ID = CType(Me.C1DBGTALLY_LIST.Columns.Item("ID").Text.ToString, Integer)
                    FrmQuery.ShowDialog()
                End If
            Case 1
                If dsWait.Tables(0).Rows.Count > 0 Then
                    Dim FrmQuery As New FrmCARGO_WAITFOR_QUERY   '***********要修改
                    ID = CType(Me.C1DBGWAIT.Columns.Item("ID").Text.ToString, Integer)
                    FrmQuery.ShowDialog()
                End If
            Case 2
                If dsWork_Record.Tables(0).Rows.Count > 0 Then
                    Dim FrmQuery As New FrmWORK_RECORD_QUERY   '***********要修改
                    ID = CType(Me.C1DBGWORK_RECORD.Columns.Item("ID").Text.ToString, Integer)
                    FrmQuery.ShowDialog()
                End If
            Case 3
                If dsMeasure.Tables(0).Rows.Count > 0 Then
                    Dim FrmQuery As New FrmCARGO_MEASURE_LIST_QUERY   '***********要修改
                    ID = CType(Me.C1DBGMEASURE.Columns.Item("ID").Text.ToString, Integer)
                    FrmQuery.ShowDialog()
                End If
            Case 4
                If SHIFTING_Flag = 1 Then
                    Dim FrmQuery As New FrmCARGO_DAILY_REPORT_QUERY
                    FrmQuery.ShowDialog()
                End If
            Case 5
                If SHIFTING_Flag = 2 Then
                    Dim FrmQuery As New FrmCARGO_DAILY_REPORT_QUERY_OTHER
                    FrmQuery.ShowDialog()
                End If

                'If dsMeasure.Tables(0).Rows.Count > 0 Then
                '    Dim FrmQuery As New FrmCARGO_MEASURE_LIST_QUERY   '***********要修改
                '    ID = CType(Me.C1DBGMEASURE.Columns.Item("ID").Text.ToString, Integer)
                '    FrmQuery.ShowDialog()
                'End If
        End Select
    End Sub

    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click, MenuItem5.Click
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                If dsTally_List.Tables(0).Rows.Count > 0 Then
                    Call PrintExcelTally_List()
                End If
            Case 1
                If dsWait.Tables(0).Rows.Count > 0 Then
                    Call PrintExcelWait()
                End If
            Case 2
                If dsWork_Record.Tables(0).Rows.Count > 0 Then
                    Call PrintExcelWork_Record()
                End If
            Case 3
                If dsMeasure.Tables(0).Rows.Count > 0 Then
                    Call PrintExcelMeasure()
                End If
            Case 4
                If dsdaily.Tables(0).Rows.Count > 0 Then
                    Call PrintExcelDaily_report()
                End If
            Case 5
                If dsdaily_other.Tables(0).Rows.Count > 0 Then
                    Call PrintExcelDaily_report_other()
                End If
        End Select
    End Sub

    Private Sub mnuExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExport.Click, MenuItem6.Click
        Call ExportExcel()
    End Sub

    Private Sub ExportExcel() '导出Excel        
        Dim frmprint As New FrmTally_sheet_print
        frmprint.ShowDialog()
    End Sub

    Private Sub PrintExcelTally_List() '打印到Excel        
        Dim Row As Integer
        Dim Col As Integer
        Try
            Call MakeExcelTally_List()
            Row = dsTally_List.Tables(0).Rows.Count + 4
            Col = Me.C1DBGTALLY_LIST.Columns.Count - ColNum
            '**************画边框
            For Row = 2 To dsTally_List.Tables(0).Rows.Count + 4 '画列
                xlSheet.Range(xlSheet.Cells(Row, 1), xlSheet.Cells(Row, C1DBGTALLY_LIST.Columns.Count - ColNum)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 7
            Next Row
            For Col = 1 To C1DBGTALLY_LIST.Columns.Count - ColNum + 1 '画行
                xlSheet.Range(xlSheet.Cells(3, Col), xlSheet.Cells(dsTally_List.Tables(0).Rows.Count + 4, Col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7
            Next Col
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub PrintExcelWait() '打印到Excel        
        Dim Row As Integer
        Dim Col As Integer
        Try
            Call MakeExcelWait()
            Row = dsWait.Tables(0).Rows.Count + 4
            Col = Me.C1DBGWAIT.Columns.Count - ColNum
            '**************画边框
            For Row = 2 To dsWait.Tables(0).Rows.Count + 4 '画列
                xlSheet.Range(xlSheet.Cells(Row, 1), xlSheet.Cells(Row, C1DBGWAIT.Columns.Count - ColNum)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 7
            Next Row
            For Col = 1 To C1DBGWAIT.Columns.Count - ColNum + 1 '画行
                xlSheet.Range(xlSheet.Cells(3, Col), xlSheet.Cells(dsWait.Tables(0).Rows.Count + 4, Col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7
            Next Col
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub PrintExcelWork_Record() '打印到Excel        
        Dim Row As Integer
        Dim Col As Integer
        Try
            Call MakeExcelWork_Record()
            Row = dsWork_Record.Tables(0).Rows.Count + 4
            Col = Me.C1DBGWORK_RECORD.Columns.Count - ColNum
            '**************画边框
            For Row = 2 To dsWork_Record.Tables(0).Rows.Count + 4 '画列
                xlSheet.Range(xlSheet.Cells(Row, 1), xlSheet.Cells(Row, C1DBGWORK_RECORD.Columns.Count - ColNum)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 7
            Next Row
            For Col = 1 To C1DBGWORK_RECORD.Columns.Count - ColNum + 1 '画行
                xlSheet.Range(xlSheet.Cells(3, Col), xlSheet.Cells(dsWork_Record.Tables(0).Rows.Count + 4, Col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7
            Next Col
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub PrintExcelMeasure() '打印到Excel        
        Dim Row As Integer
        Dim Col As Integer
        Try
            Call MakeExcelMeasure()
            Row = dsMeasure.Tables(0).Rows.Count + 4
            Col = Me.C1DBGMEASURE.Columns.Count - ColNum
            '**************画边框
            For Row = 2 To dsMeasure.Tables(0).Rows.Count + 4 '画列
                xlSheet.Range(xlSheet.Cells(Row, 1), xlSheet.Cells(Row, C1DBGMEASURE.Columns.Count - ColNum)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 7
            Next Row
            For Col = 1 To C1DBGMEASURE.Columns.Count - ColNum + 1 '画行
                xlSheet.Range(xlSheet.Cells(3, Col), xlSheet.Cells(dsMeasure.Tables(0).Rows.Count + 4, Col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7
            Next Col
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub PrintExcelDaily_report() '打印到Excel        
        Try
            If Hatch_in = 1 Then
                Inoutport_Cha = "出口"
                Inoutport_eng = "Outward"
            Else
                Inoutport_Cha = "进口"
                Inoutport_eng = "Inward"
            End If
            If trade = "1" Then
                Call china()
            ElseIf trade = "2" Then
                If GL_hatch > 6 Then
                    Call eng_16()
                Else
                    Call eng()
                End If
            End If
        Catch
            xlApp.Quit()
            SendKeys.Send("n")
        End Try
    End Sub

    Private Sub PrintExcelDaily_report_other() '打印到Excel        
        Try
            If ff = 1 Then
                Inoutport_Cha = "进口"
                Inoutport_eng = "Inward"
                aorb = "A"
            End If
            If ff = 2 Then
                Inoutport_Cha = "出口"
                Inoutport_eng = "Outward"
                aorb = "B"
            End If
            If trade = "1" Then
                Call china()
            ElseIf trade = "2" Then
                If GL_hatch > 6 Then
                    Call eng_other_16()
                Else
                    Call eng_other()
                End If
            End If
        Catch
            xlApp.Quit()
            SendKeys.Send("n")
        End Try
    End Sub

    Private Sub china()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer

        Try
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "Report_CARGO.xls", pathstr + "Report.xls")
            Filepath = pathstr + "Report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("件杂货日报（C）"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = True
            xlsheet.Select()
            xlsheet.Cells(7, 1) = "(" & Inoutport_Cha & ")"
            xlsheet.Cells(8, 2) = ds_sship.Tables(0).Rows(0).Item("CHI_VESSEL")
            xlsheet.Cells(8, 6) = ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            'xlsheet.Cells(3, 5) = "国籍： " & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_CHA")
            xlsheet.Cells(8, 8) = dsdaily.Tables(2).Rows(0).Item("berth")

            xlsheet.Cells(8, 11) = Year(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "年" & Month(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "月" & Day(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "日" & Hour(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "时"
            xlsheet.Cells(10, 11) = Year(dsdaily.Tables(4).Rows(0).Item("timeto")) & "年" & Month(dsdaily.Tables(4).Rows(0).Item("timeto")) & "月" & Day(dsdaily.Tables(4).Rows(0).Item("timeto")) & "日" & Hour(dsdaily.Tables(4).Rows(0).Item("timeto")) & "时"
            If dsdaily.Tables(0).Rows.Count >= 4 Then
                For row = 0 To dsdaily.Tables(0).Rows.Count - 4
                    xlsheet.Cells(15 + 2 * row, 1) = dsdaily.Tables(0).Rows(row)(0)
                Next row
                For row = 0 To dsdaily.Tables(0).Rows.Count - 4
                    xlsheet.Cells(15 + 2 * row, 2) = dsdaily.Tables(0).Rows(row)(1)
                    xlsheet.Cells(16 + 2 * row, 3) = dsdaily.Tables(0).Rows(row)(2)
                    xlsheet.Cells(15 + 2 * row, 4) = dsdaily.Tables(0).Rows(row)(3)
                    xlsheet.Cells(16 + 2 * row, 5) = dsdaily.Tables(0).Rows(row)(4)
                    xlsheet.Cells(15 + 2 * row, 6) = dsdaily.Tables(0).Rows(row)(5)
                    xlsheet.Cells(16 + 2 * row, 7) = dsdaily.Tables(0).Rows(row)(6)
                    xlsheet.Cells(15 + 2 * row, 8) = dsdaily.Tables(0).Rows(row)(7)
                    xlsheet.Cells(16 + 2 * row, 9) = dsdaily.Tables(0).Rows(row)(8)
                    xlsheet.Cells(15 + 2 * row, 10) = dsdaily.Tables(0).Rows(row)(9)
                    xlsheet.Cells(16 + 2 * row, 11) = dsdaily.Tables(0).Rows(row)(10)
                    xlsheet.Cells(15 + 2 * row, 12) = dsdaily.Tables(0).Rows(row)(11)
                    xlsheet.Cells(16 + 2 * row, 13) = dsdaily.Tables(0).Rows(row)(12)
                    xlsheet.Cells(15 + 2 * row, 14) = dsdaily.Tables(0).Rows(row)(13)
                    xlsheet.Cells(16 + 2 * row, 15) = dsdaily.Tables(0).Rows(row)(14)
                    xlsheet.Cells(15 + 2 * row, 16) = dsdaily.Tables(0).Rows(row)(15)
                    xlsheet.Cells(16 + 2 * row, 17) = dsdaily.Tables(0).Rows(row)(16)
                Next row
                For row = dsdaily.Tables(0).Rows.Count - 3 To dsdaily.Tables(0).Rows.Count - 1
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 2) = dsdaily.Tables(0).Rows(row)(1)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 3) = dsdaily.Tables(0).Rows(row)(2)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 4) = dsdaily.Tables(0).Rows(row)(3)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 5) = dsdaily.Tables(0).Rows(row)(4)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 6) = dsdaily.Tables(0).Rows(row)(5)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 7) = dsdaily.Tables(0).Rows(row)(6)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 8) = dsdaily.Tables(0).Rows(row)(7)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 9) = dsdaily.Tables(0).Rows(row)(8)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 10) = dsdaily.Tables(0).Rows(row)(9)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 11) = dsdaily.Tables(0).Rows(row)(10)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 12) = dsdaily.Tables(0).Rows(row)(11)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 13) = dsdaily.Tables(0).Rows(row)(12)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 14) = dsdaily.Tables(0).Rows(row)(13)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 15) = dsdaily.Tables(0).Rows(row)(14)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 16) = dsdaily.Tables(0).Rows(row)(15)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 17) = dsdaily.Tables(0).Rows(row)(16)
                Next row
            End If
            For row = 0 To dsdaily.Tables(5).Rows.Count - 1
                xlsheet.Cells(12, 2 + 2 * row) = dsdaily.Tables(5).Rows(row)(0)
            Next row
            xlsheet.Cells(31, 2) = LabREMARKS.Text
            xlsheet.PrintPreview()

        Catch
            xlapp.Quit()
            SendKeys.Send("n")
        End Try
    End Sub

    Private Sub eng()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer

        Try
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "daily_report.xls", pathstr + "Report.xls")
            Filepath = pathstr + "report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("件杂货日报（E）"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = True
            xlsheet.Select()

            xlsheet.Cells(8, 1) = "(" & Inoutport_eng & ")"
            xlsheet.Cells(9, 2) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
            xlsheet.Cells(9, 5) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            ' xlsheet.Cells(3, 5) = "Nationality: " & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
            xlsheet.Cells(9, 7) = dsdaily.Tables(2).Rows(0).Item("berth").ToString.PadLeft(2, "0")
            Dim tf As String
            Dim tfdate As String
            tf = Hour(dsdaily.Tables(3).Rows(0).Item("timefrom")).ToString.PadLeft(2, "0") & Minute(dsdaily.Tables(3).Rows(0).Item("timefrom")).ToString.PadLeft(2, "0")
            xlsheet.Cells(9, 10) = Hour(dsdaily.Tables(3).Rows(0).Item("timefrom")).ToString.PadLeft(2, "0") & ":" & Minute(dsdaily.Tables(3).Rows(0).Item("timefrom")).ToString.PadLeft(2, "0")
            tfdate = Year(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "-" & Month(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "-" & Day(dsdaily.Tables(3).Rows(0).Item("timefrom"))
            xlsheet.Cells(9, 12) = Hour(dsdaily.Tables(4).Rows(0).Item("timeto")).ToString.PadLeft(2, "0") & ":" & Minute(dsdaily.Tables(4).Rows(0).Item("timeto")).ToString.PadLeft(2, "0")
            'If (Year(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "-" & Month(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "-" & Day(dsdaily.Tables(3).Rows(0).Item("timefrom"))) = (Year(dsdaily.Tables(4).Rows(0).Item("timeto")) & "-" & Month(dsdaily.Tables(4).Rows(0).Item("timeto")) & "-" & Day(dsdaily.Tables(4).Rows(0).Item("timeto"))) Then
            '    xlsheet.Cells(9, 14) = Day(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "/" & Month(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "--" & Year(dsdaily.Tables(3).Rows(0).Item("timefrom"))
            'Else
            '    xlsheet.Cells(9, 14) = Day(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "/" & Month(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "--" & Day(dsdaily.Tables(4).Rows(0).Item("timeto")) & "/" & Month(dsdaily.Tables(4).Rows(0).Item("timeto")) & "--" & Year(dsdaily.Tables(3).Rows(0).Item("timefrom"))
            'End If

            xlsheet.Cells(9, 14) = Day(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "/" & Month(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "/" & Year(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "----" & Day(dsdaily.Tables(4).Rows(0).Item("timeto")) & "/" & Month(dsdaily.Tables(4).Rows(0).Item("timeto")) & "/" & Year(dsdaily.Tables(4).Rows(0).Item("timeto"))
            Dim gb As String
            Dim dsgb As New DataSet
            Dim dwgb As New DataView
            dwgb = Getdata("select team_no from CARGO_LIST where ship_id='" & Ship_ID & "' and datediff(dd,date,'" & tfdate & "')=0 and time_from='" & tf & "'", dsgb)
            If dsgb.Tables(0).Rows.Count > 0 Then
                gb = dsgb.Tables(0).Rows(0).Item("team_no") & GL_WCRB
            End If

            xlsheet.Cells(6, 15) = "NO. " & gb
            For row = 1 To GL_hatch
                xlsheet.Cells(12, 2 * row) = "HATCH NO." & row
            Next row
            'xlsheet.Cells(12, 2 + 2 * GL_hatch) = "ON DECK"

            If dsdaily.Tables(0).Rows.Count >= 4 Then
                For row = 0 To dsdaily.Tables(0).Rows.Count - 4
                    xlsheet.Cells(15 + 2 * row, 1) = dsdaily.Tables(0).Rows(row)(0)
                Next row
                For row = 0 To dsdaily.Tables(0).Rows.Count - 4
                    xlsheet.Cells(15 + 2 * row, 2) = dsdaily.Tables(0).Rows(row)(1)
                    xlsheet.Cells(16 + 2 * row, 3) = dsdaily.Tables(0).Rows(row)(2)
                    xlsheet.Cells(15 + 2 * row, 4) = dsdaily.Tables(0).Rows(row)(3)
                    xlsheet.Cells(16 + 2 * row, 5) = dsdaily.Tables(0).Rows(row)(4)
                    xlsheet.Cells(15 + 2 * row, 6) = dsdaily.Tables(0).Rows(row)(5)
                    xlsheet.Cells(16 + 2 * row, 7) = dsdaily.Tables(0).Rows(row)(6)
                    xlsheet.Cells(15 + 2 * row, 8) = dsdaily.Tables(0).Rows(row)(7)
                    xlsheet.Cells(16 + 2 * row, 9) = dsdaily.Tables(0).Rows(row)(8)
                    xlsheet.Cells(15 + 2 * row, 10) = dsdaily.Tables(0).Rows(row)(9)
                    xlsheet.Cells(16 + 2 * row, 11) = dsdaily.Tables(0).Rows(row)(10)
                    xlsheet.Cells(15 + 2 * row, 12) = dsdaily.Tables(0).Rows(row)(11)
                    xlsheet.Cells(16 + 2 * row, 13) = dsdaily.Tables(0).Rows(row)(12)
                    xlsheet.Cells(15 + 2 * row, 14) = dsdaily.Tables(0).Rows(row)(13)
                    xlsheet.Cells(16 + 2 * row, 15) = dsdaily.Tables(0).Rows(row)(14)
                    xlsheet.Cells(15 + 2 * row, 16) = dsdaily.Tables(0).Rows(row)(15)
                    xlsheet.Cells(16 + 2 * row, 17) = dsdaily.Tables(0).Rows(row)(16)
                Next row
                For row = dsdaily.Tables(0).Rows.Count - 3 To dsdaily.Tables(0).Rows.Count - 1
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 2) = dsdaily.Tables(0).Rows(row)(1)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 3) = dsdaily.Tables(0).Rows(row)(2)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 4) = dsdaily.Tables(0).Rows(row)(3)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 5) = dsdaily.Tables(0).Rows(row)(4)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 6) = dsdaily.Tables(0).Rows(row)(5)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 7) = dsdaily.Tables(0).Rows(row)(6)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 8) = dsdaily.Tables(0).Rows(row)(7)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 9) = dsdaily.Tables(0).Rows(row)(8)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 10) = dsdaily.Tables(0).Rows(row)(9)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 11) = dsdaily.Tables(0).Rows(row)(10)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 12) = dsdaily.Tables(0).Rows(row)(11)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 13) = dsdaily.Tables(0).Rows(row)(12)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 14) = dsdaily.Tables(0).Rows(row)(13)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 15) = dsdaily.Tables(0).Rows(row)(14)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 16) = dsdaily.Tables(0).Rows(row)(15)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 17) = dsdaily.Tables(0).Rows(row)(16)
                Next row
                If dsdaily.Tables(0).Rows(dsdaily.Tables(0).Rows.Count - 1)(13) <> 0 Or dsdaily.Tables(0).Rows(dsdaily.Tables(0).Rows.Count - 1)(14) <> 0 Then
                    xlsheet.Cells(12, 14) = "ON DECK"
                End If
            End If
            'For row = 0 To dsdaily.Tables(5).Rows.Count - 1
            '    xlsheet.Cells(12, 2 + 2 * row) = dsdaily.Tables(5).Rows(row)(0)
            'Next row
            xlsheet.Cells(31, 2) = LabREMARKS.Text
            xlsheet.PrintPreview()
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
        End Try
    End Sub

    Private Sub eng_16()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer

        Try
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "daily_report.xls", pathstr + "Report.xls")
            Filepath = pathstr + "report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("件杂货日报（大）"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = True
            xlsheet.Select()

            xlsheet.Cells(8, 15) = "(" & Inoutport_eng & ")"
            xlsheet.Cells(9, 2) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
            xlsheet.Cells(9, 9) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            ' xlsheet.Cells(3, 5) = "Nationality: " & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
            xlsheet.Cells(9, 13) = dsdaily.Tables(2).Rows(0).Item("berth").ToString.PadLeft(2, "0")
            Dim tf As String
            Dim tfdate As String
            tf = Hour(dsdaily.Tables(3).Rows(0).Item("timefrom")).ToString.PadLeft(2, "0") & Minute(dsdaily.Tables(3).Rows(0).Item("timefrom")).ToString.PadLeft(2, "0")
            xlsheet.Cells(9, 19) = Hour(dsdaily.Tables(3).Rows(0).Item("timefrom")).ToString.PadLeft(2, "0") & ":" & Minute(dsdaily.Tables(3).Rows(0).Item("timefrom")).ToString.PadLeft(2, "0")
            tfdate = Year(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "-" & Month(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "-" & Day(dsdaily.Tables(3).Rows(0).Item("timefrom"))
            xlsheet.Cells(9, 24) = Hour(dsdaily.Tables(4).Rows(0).Item("timeto")).ToString.PadLeft(2, "0") & ":" & Minute(dsdaily.Tables(4).Rows(0).Item("timeto")).ToString.PadLeft(2, "0")
            'If (Year(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "-" & Month(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "-" & Day(dsdaily.Tables(3).Rows(0).Item("timefrom"))) = (Year(dsdaily.Tables(4).Rows(0).Item("timeto")) & "-" & Month(dsdaily.Tables(4).Rows(0).Item("timeto")) & "-" & Day(dsdaily.Tables(4).Rows(0).Item("timeto"))) Then
            '    xlsheet.Cells(9, 14) = Day(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "/" & Month(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "--" & Year(dsdaily.Tables(3).Rows(0).Item("timefrom"))
            'Else
            '    xlsheet.Cells(9, 14) = Day(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "/" & Month(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "--" & Day(dsdaily.Tables(4).Rows(0).Item("timeto")) & "/" & Month(dsdaily.Tables(4).Rows(0).Item("timeto")) & "--" & Year(dsdaily.Tables(3).Rows(0).Item("timefrom"))
            'End If

            xlsheet.Cells(9, 28) = Day(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "/" & Month(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "/" & Year(dsdaily.Tables(3).Rows(0).Item("timefrom")) & "----" & Day(dsdaily.Tables(4).Rows(0).Item("timeto")) & "/" & Month(dsdaily.Tables(4).Rows(0).Item("timeto")) & "/" & Year(dsdaily.Tables(4).Rows(0).Item("timeto"))
            Dim gb As String
            Dim dsgb As New DataSet
            Dim dwgb As New DataView
            dwgb = Getdata("select team_no from CARGO_LIST where ship_id='" & Ship_ID & "' and datediff(dd,date,'" & tfdate & "')=0 and time_from='" & tf & "'", dsgb)
            If dsgb.Tables(0).Rows.Count > 0 Then
                gb = dsgb.Tables(0).Rows(0).Item("team_no") & GL_WCRB
            End If
            xlsheet.Cells(6, 31) = "NO. " & gb

            For row = 1 To GL_hatch
                xlsheet.Cells(12, 2 * row) = "HATCH NO." & row
            Next row
            'xlsheet.Cells(12, 2 + 2 * GL_hatch) = "ON DECK"

            If dsdaily.Tables(0).Rows.Count >= 4 Then
                For row = 0 To dsdaily.Tables(0).Rows.Count - 4
                    xlsheet.Cells(15 + 2 * row, 1) = dsdaily.Tables(0).Rows(row)(0)
                Next row
                For row = 0 To dsdaily.Tables(0).Rows.Count - 4
                    xlsheet.Cells(15 + 2 * row, 2) = dsdaily.Tables(0).Rows(row)(1)
                    xlsheet.Cells(16 + 2 * row, 2) = dsdaily.Tables(0).Rows(row)(2)
                    xlsheet.Cells(15 + 2 * row, 4) = dsdaily.Tables(0).Rows(row)(3)
                    xlsheet.Cells(16 + 2 * row, 4) = dsdaily.Tables(0).Rows(row)(4)
                    xlsheet.Cells(15 + 2 * row, 6) = dsdaily.Tables(0).Rows(row)(5)
                    xlsheet.Cells(16 + 2 * row, 6) = dsdaily.Tables(0).Rows(row)(6)
                    xlsheet.Cells(15 + 2 * row, 8) = dsdaily.Tables(0).Rows(row)(7)
                    xlsheet.Cells(16 + 2 * row, 8) = dsdaily.Tables(0).Rows(row)(8)
                    xlsheet.Cells(15 + 2 * row, 10) = dsdaily.Tables(0).Rows(row)(9)
                    xlsheet.Cells(16 + 2 * row, 10) = dsdaily.Tables(0).Rows(row)(10)
                    xlsheet.Cells(15 + 2 * row, 12) = dsdaily.Tables(0).Rows(row)(11)
                    xlsheet.Cells(16 + 2 * row, 12) = dsdaily.Tables(0).Rows(row)(12)
                    xlsheet.Cells(15 + 2 * row, 14) = dsdaily.Tables(0).Rows(row)(13)
                    xlsheet.Cells(16 + 2 * row, 14) = dsdaily.Tables(0).Rows(row)(14)
                    xlsheet.Cells(15 + 2 * row, 16) = dsdaily.Tables(0).Rows(row)(15)
                    xlsheet.Cells(16 + 2 * row, 16) = dsdaily.Tables(0).Rows(row)(16)
                    xlsheet.Cells(15 + 2 * row, 18) = dsdaily.Tables(0).Rows(row)(17)
                    xlsheet.Cells(16 + 2 * row, 18) = dsdaily.Tables(0).Rows(row)(18)
                    xlsheet.Cells(15 + 2 * row, 20) = dsdaily.Tables(0).Rows(row)(19)
                    xlsheet.Cells(16 + 2 * row, 20) = dsdaily.Tables(0).Rows(row)(20)
                    xlsheet.Cells(15 + 2 * row, 22) = dsdaily.Tables(0).Rows(row)(21)
                    xlsheet.Cells(16 + 2 * row, 22) = dsdaily.Tables(0).Rows(row)(22)
                    xlsheet.Cells(15 + 2 * row, 24) = dsdaily.Tables(0).Rows(row)(23)
                    xlsheet.Cells(16 + 2 * row, 24) = dsdaily.Tables(0).Rows(row)(24)
                    xlsheet.Cells(15 + 2 * row, 26) = dsdaily.Tables(0).Rows(row)(25)
                    xlsheet.Cells(16 + 2 * row, 26) = dsdaily.Tables(0).Rows(row)(26)
                    xlsheet.Cells(15 + 2 * row, 28) = dsdaily.Tables(0).Rows(row)(27)
                    xlsheet.Cells(16 + 2 * row, 28) = dsdaily.Tables(0).Rows(row)(28)
                    xlsheet.Cells(15 + 2 * row, 30) = dsdaily.Tables(0).Rows(row)(29)
                    xlsheet.Cells(16 + 2 * row, 30) = dsdaily.Tables(0).Rows(row)(30)
                    'xlsheet.Cells(15 + 2 * row, 2 + 2 * GL_hatch) = dsdaily.Tables(0).Rows(row)(31)
                    'xlsheet.Cells(16 + 2 * row, 2 + 2 * GL_hatch) = dsdaily.Tables(0).Rows(row)(32)
                    xlsheet.Cells(15 + 2 * row, 32) = dsdaily.Tables(0).Rows(row)(31)
                    xlsheet.Cells(16 + 2 * row, 32) = dsdaily.Tables(0).Rows(row)(32)
                    xlsheet.Cells(15 + 2 * row, 34) = dsdaily.Tables(0).Rows(row)(33)
                    xlsheet.Cells(16 + 2 * row, 34) = dsdaily.Tables(0).Rows(row)(34)
                Next row
                For row = dsdaily.Tables(0).Rows.Count - 3 To dsdaily.Tables(0).Rows.Count - 1
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 2) = dsdaily.Tables(0).Rows(row)(1)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 2) = dsdaily.Tables(0).Rows(row)(2)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 4) = dsdaily.Tables(0).Rows(row)(3)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 4) = dsdaily.Tables(0).Rows(row)(4)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 6) = dsdaily.Tables(0).Rows(row)(5)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 6) = dsdaily.Tables(0).Rows(row)(6)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 8) = dsdaily.Tables(0).Rows(row)(7)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 8) = dsdaily.Tables(0).Rows(row)(8)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 10) = dsdaily.Tables(0).Rows(row)(9)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 10) = dsdaily.Tables(0).Rows(row)(10)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 12) = dsdaily.Tables(0).Rows(row)(11)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 12) = dsdaily.Tables(0).Rows(row)(12)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 14) = dsdaily.Tables(0).Rows(row)(13)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 14) = dsdaily.Tables(0).Rows(row)(14)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 16) = dsdaily.Tables(0).Rows(row)(15)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 16) = dsdaily.Tables(0).Rows(row)(16)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 18) = dsdaily.Tables(0).Rows(row)(17)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 18) = dsdaily.Tables(0).Rows(row)(18)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 20) = dsdaily.Tables(0).Rows(row)(19)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 20) = dsdaily.Tables(0).Rows(row)(20)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 22) = dsdaily.Tables(0).Rows(row)(21)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 22) = dsdaily.Tables(0).Rows(row)(22)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 24) = dsdaily.Tables(0).Rows(row)(23)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 24) = dsdaily.Tables(0).Rows(row)(24)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 26) = dsdaily.Tables(0).Rows(row)(25)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 26) = dsdaily.Tables(0).Rows(row)(26)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 28) = dsdaily.Tables(0).Rows(row)(27)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 28) = dsdaily.Tables(0).Rows(row)(28)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 30) = dsdaily.Tables(0).Rows(row)(29)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 30) = dsdaily.Tables(0).Rows(row)(30)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 32) = dsdaily.Tables(0).Rows(row)(31)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 32) = dsdaily.Tables(0).Rows(row)(32)
                    'xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 2 + 2 * GL_hatch) = dsdaily.Tables(0).Rows(row)(31)
                    'xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 2 + 2 * GL_hatch) = dsdaily.Tables(0).Rows(row)(32)
                    xlsheet.Cells(25 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 34) = dsdaily.Tables(0).Rows(row)(33)
                    xlsheet.Cells(26 + 2 * (row - dsdaily.Tables(0).Rows.Count + 3), 34) = dsdaily.Tables(0).Rows(row)(34)
                Next row
                If dsdaily.Tables(0).Rows(dsdaily.Tables(0).Rows.Count - 1)(31) <> 0 Or dsdaily.Tables(0).Rows(dsdaily.Tables(0).Rows.Count - 1)(32) <> 0 Then
                    xlsheet.Cells(12, 32) = "ON DECK"
                End If
            End If


            'For row = 0 To dsdaily.Tables(5).Rows.Count - 1
            '    xlsheet.Cells(12, 2 + 2 * row) = dsdaily.Tables(5).Rows(row)(0)
            'Next row
            xlsheet.Cells(31, 2) = LabREMARKS.Text
            xlsheet.PrintPreview()

        Catch
            xlapp.Quit()
            SendKeys.Send("n")
        End Try
    End Sub

    Private Sub eng_other()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer

        Try
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "daily_report.xls", pathstr + "Report.xls")
            Filepath = pathstr + "report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("件杂货日报（E）"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = True
            xlsheet.Select()

            xlsheet.Cells(8, 1) = "(" & Inoutport_eng & ")"
            xlsheet.Cells(9, 2) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
            xlsheet.Cells(9, 5) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            ' xlsheet.Cells(3, 5) = "Nationality: " & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
            xlsheet.Cells(9, 7) = dsdaily_other.Tables(2).Rows(0).Item("berth").ToString.PadLeft(2, "0")
            Dim tf As String
            Dim tfdate As String
            tf = Hour(dsdaily_other.Tables(3).Rows(0).Item("timefrom")).ToString.PadLeft(2, "0") & Minute(dsdaily_other.Tables(3).Rows(0).Item("timefrom")).ToString.PadLeft(2, "0")
            xlsheet.Cells(9, 10) = Hour(dsdaily_other.Tables(3).Rows(0).Item("timefrom")).ToString.PadLeft(2, "0") & ":" & Minute(dsdaily_other.Tables(3).Rows(0).Item("timefrom")).ToString.PadLeft(2, "0")
            tfdate = Year(dsdaily_other.Tables(3).Rows(0).Item("timefrom")) & "-" & Month(dsdaily_other.Tables(3).Rows(0).Item("timefrom")) & "-" & Day(dsdaily_other.Tables(3).Rows(0).Item("timefrom"))
            xlsheet.Cells(9, 12) = Hour(dsdaily_other.Tables(4).Rows(0).Item("timeto")).ToString.PadLeft(2, "0") & ":" & Minute(dsdaily_other.Tables(4).Rows(0).Item("timeto")).ToString.PadLeft(2, "0")
            'If (Year(dsdaily_other.Tables(3).Rows(0).Item("timefrom")) & "-" & Month(dsdaily_other.Tables(3).Rows(0).Item("timefrom")) & "-" & Day(dsdaily_other.Tables(3).Rows(0).Item("timefrom"))) = (Year(dsdaily_other.Tables(4).Rows(0).Item("timeto")) & "-" & Month(dsdaily_other.Tables(4).Rows(0).Item("timeto")) & "-" & Day(dsdaily_other.Tables(4).Rows(0).Item("timeto"))) Then
            '    xlsheet.Cells(9, 14) = Day(dsdaily_other.Tables(3).Rows(0).Item("timefrom")) & "/" & Month(dsdaily_other.Tables(3).Rows(0).Item("timefrom")) & "--" & Year(dsdaily_other.Tables(3).Rows(0).Item("timefrom"))
            'Else
            '    xlsheet.Cells(9, 14) = Day(dsdaily_other.Tables(3).Rows(0).Item("timefrom")) & "/" & Month(dsdaily_other.Tables(3).Rows(0).Item("timefrom")) & "--" & Day(dsdaily_other.Tables(4).Rows(0).Item("timeto")) & "/" & Month(dsdaily_other.Tables(4).Rows(0).Item("timeto")) & "--" & Year(dsdaily_other.Tables(3).Rows(0).Item("timefrom"))
            'End If

            xlsheet.Cells(9, 14) = Day(dsdaily_other.Tables(3).Rows(0).Item("timefrom")) & "/" & Month(dsdaily_other.Tables(3).Rows(0).Item("timefrom")) & "/" & Year(dsdaily_other.Tables(3).Rows(0).Item("timefrom")) & "----" & Day(dsdaily_other.Tables(4).Rows(0).Item("timeto")) & "/" & Month(dsdaily_other.Tables(4).Rows(0).Item("timeto")) & "/" & Year(dsdaily_other.Tables(4).Rows(0).Item("timeto"))
            Dim gb As String
            Dim dsgb As New DataSet
            Dim dwgb As New DataView
            dwgb = Getdata("select team_no from CARGO_LIST where ship_id='" & Ship_ID & "' and datediff(dd,date,'" & tfdate & "')=0 and time_from='" & tf & "'", dsgb)
            If dsgb.Tables(0).Rows.Count > 0 Then
                gb = dsgb.Tables(0).Rows(0).Item("team_no") & GL_WCRB
            End If

            xlsheet.Cells(6, 15) = "NO. " & gb & aorb
            For row = 1 To GL_hatch
                xlsheet.Cells(12, 2 * row) = "HATCH NO." & row
            Next row
            'xlsheet.Cells(12, 2 + 2 * GL_hatch) = "ON DECK"

            If dsdaily_other.Tables(0).Rows.Count >= 4 Then
                For row = 0 To dsdaily_other.Tables(0).Rows.Count - 4
                    xlsheet.Cells(15 + 2 * row, 1) = dsdaily_other.Tables(0).Rows(row)(0)
                Next row
                For row = 0 To dsdaily_other.Tables(0).Rows.Count - 4
                    xlsheet.Cells(15 + 2 * row, 2) = dsdaily_other.Tables(0).Rows(row)(1)
                    xlsheet.Cells(16 + 2 * row, 3) = dsdaily_other.Tables(0).Rows(row)(2)
                    xlsheet.Cells(15 + 2 * row, 4) = dsdaily_other.Tables(0).Rows(row)(3)
                    xlsheet.Cells(16 + 2 * row, 5) = dsdaily_other.Tables(0).Rows(row)(4)
                    xlsheet.Cells(15 + 2 * row, 6) = dsdaily_other.Tables(0).Rows(row)(5)
                    xlsheet.Cells(16 + 2 * row, 7) = dsdaily_other.Tables(0).Rows(row)(6)
                    xlsheet.Cells(15 + 2 * row, 8) = dsdaily_other.Tables(0).Rows(row)(7)
                    xlsheet.Cells(16 + 2 * row, 9) = dsdaily_other.Tables(0).Rows(row)(8)
                    xlsheet.Cells(15 + 2 * row, 10) = dsdaily_other.Tables(0).Rows(row)(9)
                    xlsheet.Cells(16 + 2 * row, 11) = dsdaily_other.Tables(0).Rows(row)(10)
                    xlsheet.Cells(15 + 2 * row, 12) = dsdaily_other.Tables(0).Rows(row)(11)
                    xlsheet.Cells(16 + 2 * row, 13) = dsdaily_other.Tables(0).Rows(row)(12)
                    xlsheet.Cells(15 + 2 * row, 14) = dsdaily_other.Tables(0).Rows(row)(13)
                    xlsheet.Cells(16 + 2 * row, 15) = dsdaily_other.Tables(0).Rows(row)(14)
                    xlsheet.Cells(15 + 2 * row, 16) = dsdaily_other.Tables(0).Rows(row)(15)
                    xlsheet.Cells(16 + 2 * row, 17) = dsdaily_other.Tables(0).Rows(row)(16)
                Next row
                For row = dsdaily_other.Tables(0).Rows.Count - 3 To dsdaily_other.Tables(0).Rows.Count - 1
                    xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 2) = dsdaily_other.Tables(0).Rows(row)(1)
                    xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 3) = dsdaily_other.Tables(0).Rows(row)(2)
                    xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 4) = dsdaily_other.Tables(0).Rows(row)(3)
                    xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 5) = dsdaily_other.Tables(0).Rows(row)(4)
                    xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 6) = dsdaily_other.Tables(0).Rows(row)(5)
                    xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 7) = dsdaily_other.Tables(0).Rows(row)(6)
                    xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 8) = dsdaily_other.Tables(0).Rows(row)(7)
                    xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 9) = dsdaily_other.Tables(0).Rows(row)(8)
                    xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 10) = dsdaily_other.Tables(0).Rows(row)(9)
                    xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 11) = dsdaily_other.Tables(0).Rows(row)(10)
                    xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 12) = dsdaily_other.Tables(0).Rows(row)(11)
                    xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 13) = dsdaily_other.Tables(0).Rows(row)(12)
                    xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 14) = dsdaily_other.Tables(0).Rows(row)(13)
                    xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 15) = dsdaily_other.Tables(0).Rows(row)(14)
                    xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 16) = dsdaily_other.Tables(0).Rows(row)(15)
                    xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 17) = dsdaily_other.Tables(0).Rows(row)(16)
                Next row
                If dsdaily_other.Tables(0).Rows(dsdaily_other.Tables(0).Rows.Count - 1)(13) <> 0 Or dsdaily_other.Tables(0).Rows(dsdaily_other.Tables(0).Rows.Count - 1)(14) <> 0 Then
                    xlsheet.Cells(12, 14) = "ON DECK"
                End If
            End If
            'For row = 0 To dsdaily_other.Tables(5).Rows.Count - 1
            '    xlsheet.Cells(12, 2 + 2 * row) = dsdaily_other.Tables(5).Rows(row)(0)
            'Next row
            xlsheet.Cells(31, 2) = LabREMARKS.Text
            xlsheet.PrintPreview()

        Catch
            xlapp.Quit()
            SendKeys.Send("n")
        End Try
    End Sub

    Private Sub eng_other_16()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer

        Try
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "daily_report.xls", pathstr + "Report.xls")
            Filepath = pathstr + "report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("件杂货日报（大）"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = True
            xlsheet.Select()

            xlsheet.Cells(8, 15) = "(" & Inoutport_eng & ")"
            xlsheet.Cells(9, 2) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
            xlsheet.Cells(9, 9) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            ' xlsheet.Cells(3, 5) = "Nationality: " & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
            xlsheet.Cells(9, 13) = dsdaily_other.Tables(2).Rows(0).Item("berth").ToString.PadLeft(2, "0")
            Dim tf As String
            Dim tfdate As String
            tf = Hour(dsdaily_other.Tables(3).Rows(0).Item("timefrom")).ToString.PadLeft(2, "0") & Minute(dsdaily_other.Tables(3).Rows(0).Item("timefrom")).ToString.PadLeft(2, "0")
            xlsheet.Cells(9, 19) = Hour(dsdaily_other.Tables(3).Rows(0).Item("timefrom")).ToString.PadLeft(2, "0") & ":" & Minute(dsdaily_other.Tables(3).Rows(0).Item("timefrom")).ToString.PadLeft(2, "0")
            tfdate = Year(dsdaily_other.Tables(3).Rows(0).Item("timefrom")) & "-" & Month(dsdaily_other.Tables(3).Rows(0).Item("timefrom")) & "-" & Day(dsdaily_other.Tables(3).Rows(0).Item("timefrom"))
            xlsheet.Cells(9, 24) = Hour(dsdaily_other.Tables(4).Rows(0).Item("timeto")).ToString.PadLeft(2, "0") & ":" & Minute(dsdaily_other.Tables(4).Rows(0).Item("timeto")).ToString.PadLeft(2, "0")
            'If (Year(dsdaily_other.Tables(3).Rows(0).Item("timefrom")) & "-" & Month(dsdaily_other.Tables(3).Rows(0).Item("timefrom")) & "-" & Day(dsdaily_other.Tables(3).Rows(0).Item("timefrom"))) = (Year(dsdaily_other.Tables(4).Rows(0).Item("timeto")) & "-" & Month(dsdaily_other.Tables(4).Rows(0).Item("timeto")) & "-" & Day(dsdaily_other.Tables(4).Rows(0).Item("timeto"))) Then
            '    xlsheet.Cells(9, 14) = Day(dsdaily_other.Tables(3).Rows(0).Item("timefrom")) & "/" & Month(dsdaily_other.Tables(3).Rows(0).Item("timefrom")) & "--" & Year(dsdaily_other.Tables(3).Rows(0).Item("timefrom"))
            'Else
            '    xlsheet.Cells(9, 14) = Day(dsdaily_other.Tables(3).Rows(0).Item("timefrom")) & "/" & Month(dsdaily_other.Tables(3).Rows(0).Item("timefrom")) & "--" & Day(dsdaily_other.Tables(4).Rows(0).Item("timeto")) & "/" & Month(dsdaily_other.Tables(4).Rows(0).Item("timeto")) & "--" & Year(dsdaily_other.Tables(3).Rows(0).Item("timefrom"))
            'End If

            xlsheet.Cells(9, 28) = Day(dsdaily_other.Tables(3).Rows(0).Item("timefrom")) & "/" & Month(dsdaily_other.Tables(3).Rows(0).Item("timefrom")) & "/" & Year(dsdaily_other.Tables(3).Rows(0).Item("timefrom")) & "----" & Day(dsdaily_other.Tables(4).Rows(0).Item("timeto")) & "/" & Month(dsdaily_other.Tables(4).Rows(0).Item("timeto")) & "/" & Year(dsdaily_other.Tables(4).Rows(0).Item("timeto"))
            Dim gb As String
            Dim dsgb As New DataSet
            Dim dwgb As New DataView
            dwgb = Getdata("select team_no from CARGO_LIST where ship_id='" & Ship_ID & "' and datediff(dd,date,'" & tfdate & "')=0 and time_from='" & tf & "'", dsgb)
            If dsgb.Tables(0).Rows.Count > 0 Then
                gb = dsgb.Tables(0).Rows(0).Item("team_no") & GL_WCRB
            End If

            xlsheet.Cells(6, 31) = "NO. " & gb & aorb
            For row = 1 To GL_hatch
                xlsheet.Cells(12, 2 * row) = "HATCH NO." & row
            Next row
            'xlsheet.Cells(12, 2 + 2 * GL_hatch) = "ON DECK"

            If dsdaily_other.Tables(0).Rows.Count >= 4 Then
                For row = 0 To dsdaily_other.Tables(0).Rows.Count - 4
                    xlsheet.Cells(15 + 2 * row, 1) = dsdaily_other.Tables(0).Rows(row)(0)
                Next row
                For row = 0 To dsdaily_other.Tables(0).Rows.Count - 4
                    xlsheet.Cells(15 + 2 * row, 2) = dsdaily_other.Tables(0).Rows(row)(1)
                    xlsheet.Cells(16 + 2 * row, 2) = dsdaily_other.Tables(0).Rows(row)(2)
                    xlsheet.Cells(15 + 2 * row, 4) = dsdaily_other.Tables(0).Rows(row)(3)
                    xlsheet.Cells(16 + 2 * row, 4) = dsdaily_other.Tables(0).Rows(row)(4)
                    xlsheet.Cells(15 + 2 * row, 6) = dsdaily_other.Tables(0).Rows(row)(5)
                    xlsheet.Cells(16 + 2 * row, 6) = dsdaily_other.Tables(0).Rows(row)(6)
                    xlsheet.Cells(15 + 2 * row, 8) = dsdaily_other.Tables(0).Rows(row)(7)
                    xlsheet.Cells(16 + 2 * row, 8) = dsdaily_other.Tables(0).Rows(row)(8)
                    xlsheet.Cells(15 + 2 * row, 10) = dsdaily_other.Tables(0).Rows(row)(9)
                    xlsheet.Cells(16 + 2 * row, 10) = dsdaily_other.Tables(0).Rows(row)(10)
                    xlsheet.Cells(15 + 2 * row, 12) = dsdaily_other.Tables(0).Rows(row)(11)
                    xlsheet.Cells(16 + 2 * row, 12) = dsdaily_other.Tables(0).Rows(row)(12)
                    xlsheet.Cells(15 + 2 * row, 14) = dsdaily_other.Tables(0).Rows(row)(13)
                    xlsheet.Cells(16 + 2 * row, 14) = dsdaily_other.Tables(0).Rows(row)(14)
                    xlsheet.Cells(15 + 2 * row, 16) = dsdaily_other.Tables(0).Rows(row)(15)
                    xlsheet.Cells(16 + 2 * row, 16) = dsdaily_other.Tables(0).Rows(row)(16)
                    xlsheet.Cells(15 + 2 * row, 18) = dsdaily_other.Tables(0).Rows(row)(17)
                    xlsheet.Cells(16 + 2 * row, 18) = dsdaily_other.Tables(0).Rows(row)(18)
                    xlsheet.Cells(15 + 2 * row, 20) = dsdaily_other.Tables(0).Rows(row)(19)
                    xlsheet.Cells(16 + 2 * row, 20) = dsdaily_other.Tables(0).Rows(row)(20)
                    xlsheet.Cells(15 + 2 * row, 22) = dsdaily_other.Tables(0).Rows(row)(21)
                    xlsheet.Cells(16 + 2 * row, 22) = dsdaily_other.Tables(0).Rows(row)(22)
                    xlsheet.Cells(15 + 2 * row, 24) = dsdaily_other.Tables(0).Rows(row)(23)
                    xlsheet.Cells(16 + 2 * row, 24) = dsdaily_other.Tables(0).Rows(row)(24)
                    xlsheet.Cells(15 + 2 * row, 26) = dsdaily_other.Tables(0).Rows(row)(25)
                    xlsheet.Cells(16 + 2 * row, 26) = dsdaily_other.Tables(0).Rows(row)(26)
                    xlsheet.Cells(15 + 2 * row, 28) = dsdaily_other.Tables(0).Rows(row)(27)
                    xlsheet.Cells(16 + 2 * row, 28) = dsdaily_other.Tables(0).Rows(row)(28)
                    xlsheet.Cells(15 + 2 * row, 30) = dsdaily_other.Tables(0).Rows(row)(29)
                    xlsheet.Cells(16 + 2 * row, 30) = dsdaily_other.Tables(0).Rows(row)(30)
                    'xlsheet.Cells(15 + 2 * row, 2 + 2 * GL_hatch) = dsdaily_other.Tables(0).Rows(row)(31)
                    'xlsheet.Cells(16 + 2 * row, 2 + 2 * GL_hatch) = dsdaily_other.Tables(0).Rows(row)(32)
                    xlsheet.Cells(15 + 2 * row, 32) = dsdaily_other.Tables(0).Rows(row)(31)
                    xlsheet.Cells(16 + 2 * row, 32) = dsdaily_other.Tables(0).Rows(row)(32)
                    xlsheet.Cells(15 + 2 * row, 34) = dsdaily_other.Tables(0).Rows(row)(33)
                    xlsheet.Cells(16 + 2 * row, 34) = dsdaily_other.Tables(0).Rows(row)(34)
                Next row
                For row = dsdaily_other.Tables(0).Rows.Count - 3 To dsdaily_other.Tables(0).Rows.Count - 1
                    xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 2) = dsdaily_other.Tables(0).Rows(row)(1)
                    xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 2) = dsdaily_other.Tables(0).Rows(row)(2)
                    xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 4) = dsdaily_other.Tables(0).Rows(row)(3)
                    xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 4) = dsdaily_other.Tables(0).Rows(row)(4)
                    xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 6) = dsdaily_other.Tables(0).Rows(row)(5)
                    xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 6) = dsdaily_other.Tables(0).Rows(row)(6)
                    xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 8) = dsdaily_other.Tables(0).Rows(row)(7)
                    xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 8) = dsdaily_other.Tables(0).Rows(row)(8)
                    xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 10) = dsdaily_other.Tables(0).Rows(row)(9)
                    xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 10) = dsdaily_other.Tables(0).Rows(row)(10)
                    xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 12) = dsdaily_other.Tables(0).Rows(row)(11)
                    xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 12) = dsdaily_other.Tables(0).Rows(row)(12)
                    xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 14) = dsdaily_other.Tables(0).Rows(row)(13)
                    xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 14) = dsdaily_other.Tables(0).Rows(row)(14)
                    xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 16) = dsdaily_other.Tables(0).Rows(row)(15)
                    xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 16) = dsdaily_other.Tables(0).Rows(row)(16)
                    xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 18) = dsdaily_other.Tables(0).Rows(row)(17)
                    xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 18) = dsdaily_other.Tables(0).Rows(row)(18)
                    xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 20) = dsdaily_other.Tables(0).Rows(row)(19)
                    xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 20) = dsdaily_other.Tables(0).Rows(row)(20)
                    xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 22) = dsdaily_other.Tables(0).Rows(row)(21)
                    xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 22) = dsdaily_other.Tables(0).Rows(row)(22)
                    xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 24) = dsdaily_other.Tables(0).Rows(row)(23)
                    xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 24) = dsdaily_other.Tables(0).Rows(row)(24)
                    xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 26) = dsdaily_other.Tables(0).Rows(row)(25)
                    xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 26) = dsdaily_other.Tables(0).Rows(row)(26)
                    xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 28) = dsdaily_other.Tables(0).Rows(row)(27)
                    xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 28) = dsdaily_other.Tables(0).Rows(row)(28)
                    xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 30) = dsdaily_other.Tables(0).Rows(row)(29)
                    xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 30) = dsdaily_other.Tables(0).Rows(row)(30)
                    'xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 2 + 2 * GL_hatch) = dsdaily_other.Tables(0).Rows(row)(31)
                    'xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 2 + 2 * GL_hatch) = dsdaily_other.Tables(0).Rows(row)(32)
                    xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 32) = dsdaily_other.Tables(0).Rows(row)(31)
                    xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 32) = dsdaily_other.Tables(0).Rows(row)(32)
                    xlsheet.Cells(25 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 34) = dsdaily_other.Tables(0).Rows(row)(33)
                    xlsheet.Cells(26 + 2 * (row - dsdaily_other.Tables(0).Rows.Count + 3), 34) = dsdaily_other.Tables(0).Rows(row)(34)
                Next row
                If dsdaily_other.Tables(0).Rows(dsdaily_other.Tables(0).Rows.Count - 1)(31) <> 0 Or dsdaily_other.Tables(0).Rows(dsdaily_other.Tables(0).Rows.Count - 1)(32) <> 0 Then
                    xlsheet.Cells(12, 32) = "ON DECK"
                End If
            End If
            'For row = 0 To dsdaily_other.Tables(5).Rows.Count - 1
            '    xlsheet.Cells(12, 2 + 2 * row) = dsdaily_other.Tables(5).Rows(row)(0)
            'Next row
            xlsheet.Cells(31, 2) = LabREMARKS.Text
            xlsheet.PrintPreview()

        Catch
            xlapp.Quit()
            SendKeys.Send("n")
        End Try
    End Sub

    Private Sub MakeExcelTally_List()
        Dim PathStr As String
        Dim FilePath As String
        Dim Row As Integer
        Dim Col As Integer
        Try
            PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
            PathStr = substr(PathStr)
            FilePath = PathStr + "Report.xls"
            FileCopy(PathStr + "Report_CARGO.xls", PathStr + "Report.xls")
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)
            xlSheet = CType(xlBook.Worksheets("Sheet1"), Excel.Worksheet)
            xlApp.DisplayAlerts = False
            xlSheet.Application.Visible = True
            xlSheet.Select()

            'xlBook.Worksheets("sheet1").select()
            xlSheet.Cells(1, 1) = Me.Text() '标题

            For Col = ColNum To Me.C1DBGTALLY_LIST.Columns.Count - 1 '列标题
                xlSheet.Cells(3, Col - ColNum + 1) = Me.C1DBGTALLY_LIST.Columns(Col).Caption
            Next Col
            Me.C1DBGTALLY_LIST.MoveFirst()
            For Row = 0 To dsTally_List.Tables(0).Rows.Count - 1 '数据
                For Col = ColNum To Me.C1DBGTALLY_LIST.Columns.Count - 1
                    xlSheet.Cells(Row + 4, Col - ColNum + 1) = Me.C1DBGTALLY_LIST.Columns(Col).Text.ToString      'ds.Tables(0).Rows(Row)(Col)
                Next Col
                Me.C1DBGTALLY_LIST.MoveNext()
            Next Row
            If Me.C1DBGTALLY_LIST.ColumnFooters = True Then '合计项
                For Col = ColNum To Me.C1DBGTALLY_LIST.Columns.Count - 1
                    xlSheet.Cells(dsTally_List.Tables(0).Rows.Count + 4, Col - ColNum + 1) = Me.C1DBGTALLY_LIST.Columns(Col).FooterText
                Next Col
            End If
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub MakeExcelWait()
        Dim PathStr As String
        Dim FilePath As String
        Dim Row As Integer
        Dim Col As Integer
        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        Try
            FilePath = PathStr + "Report.xls"
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)
            xlSheet = CType(xlBook.Worksheets(1), Excel.Worksheet)
            xlApp.DisplayAlerts = False
            xlSheet.Application.Visible = True
            xlBook.Worksheets("sheet1").select()
            xlSheet.Cells(1, 1) = Me.Text() '标题

            For Col = ColNum To Me.C1DBGWAIT.Columns.Count - 1 '列标题
                xlSheet.Cells(3, Col - ColNum + 1) = Me.C1DBGWAIT.Columns(Col).Caption
            Next Col
            Me.C1DBGWAIT.MoveFirst()
            For Row = 0 To dsWait.Tables(0).Rows.Count - 1 '数据
                For Col = ColNum To Me.C1DBGWAIT.Columns.Count - 1
                    xlSheet.Cells(Row + 4, Col - ColNum + 1) = Me.C1DBGWAIT.Columns(Col).Text.ToString      'ds.Tables(0).Rows(Row)(Col)
                Next Col
                Me.C1DBGWAIT.MoveNext()
            Next Row
            If Me.C1DBGWAIT.ColumnFooters = True Then '合计项
                For Col = ColNum To Me.C1DBGWAIT.Columns.Count - 1
                    xlSheet.Cells(dsWait.Tables(0).Rows.Count + 4, Col - ColNum + 1) = Me.C1DBGWAIT.Columns(Col).FooterText
                Next Col
            End If
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub MakeExcelWork_Record()
        Dim PathStr As String
        Dim FilePath As String
        Dim Row As Integer
        Dim Col As Integer
        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        Try
            FilePath = PathStr + "Report.xls"
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)
            xlSheet = CType(xlBook.Worksheets(1), Excel.Worksheet)
            xlApp.DisplayAlerts = False
            xlSheet.Application.Visible = True
            xlBook.Worksheets("sheet1").select()
            xlSheet.Cells(1, 1) = Me.Text() '标题

            For Col = ColNum To Me.C1DBGWORK_RECORD.Columns.Count - 1 '列标题
                xlSheet.Cells(3, Col - ColNum + 1) = Me.C1DBGWORK_RECORD.Columns(Col).Caption
            Next Col
            Me.C1DBGWORK_RECORD.MoveFirst()
            For Row = 0 To dsWork_Record.Tables(0).Rows.Count - 1 '数据
                For Col = ColNum To Me.C1DBGWORK_RECORD.Columns.Count - 1
                    xlSheet.Cells(Row + 4, Col - ColNum + 1) = Me.C1DBGWORK_RECORD.Columns(Col).Text.ToString      'ds.Tables(0).Rows(Row)(Col)
                Next Col
                Me.C1DBGWORK_RECORD.MoveNext()
            Next Row
            If Me.C1DBGWORK_RECORD.ColumnFooters = True Then '合计项
                For Col = ColNum To Me.C1DBGWORK_RECORD.Columns.Count - 1
                    xlSheet.Cells(dsWork_Record.Tables(0).Rows.Count + 4, Col - ColNum + 1) = Me.C1DBGWORK_RECORD.Columns(Col).FooterText
                Next Col
            End If
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub MakeExcelMeasure()
        Dim PathStr As String
        Dim FilePath As String
        Dim Row As Integer
        Dim Col As Integer
        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        Try
            FilePath = PathStr + "Report.xls"
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)
            xlSheet = CType(xlBook.Worksheets(1), Excel.Worksheet)
            xlApp.DisplayAlerts = False
            xlSheet.Application.Visible = True
            xlBook.Worksheets("sheet1").select()
            xlSheet.Cells(1, 1) = Me.Text() '标题

            For Col = ColNum To Me.C1DBGMEASURE.Columns.Count - 1 '列标题
                xlSheet.Cells(3, Col - ColNum + 1) = Me.C1DBGMEASURE.Columns(Col).Caption
            Next Col
            Me.C1DBGMEASURE.MoveFirst()
            For Row = 0 To dsMeasure.Tables(0).Rows.Count - 1 '数据
                For Col = ColNum To Me.C1DBGMEASURE.Columns.Count - 1
                    xlSheet.Cells(Row + 4, Col - ColNum + 1) = Me.C1DBGMEASURE.Columns(Col).Text.ToString      'ds.Tables(0).Rows(Row)(Col)
                Next Col
                Me.C1DBGMEASURE.MoveNext()
            Next Row
            If Me.C1DBGMEASURE.ColumnFooters = True Then '合计项
                For Col = ColNum To Me.C1DBGMEASURE.Columns.Count - 1
                    xlSheet.Cells(dsMeasure.Tables(0).Rows.Count + 4, Col - ColNum + 1) = Me.C1DBGMEASURE.Columns(Col).FooterText
                Next Col
            End If
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub preview(ByVal Func As String) '***************权限设计
        Dim sqlstr As String
        Dim Previewdv As DataView
        Dim Previewds As New DataSet
        Dim i As Integer
        sqlstr = " select FUNC_CODE_Add,FUNC_CODE_Change,FUNC_CODE_Del from View_UserPreview where PART_ID=" & G_Part_Id & " and FUNC_CODE='" & Upper(Func) & "' "
        Previewdv = Getdata(sqlstr, Previewds)
        If Previewdv.Count > 0 Then
            If Previewdv(i)("FUNC_CODE_Add") = 1 Then 'ADD 按钮可见
                ToolBar.Buttons.Item(3).Enabled = True
                mnuAdd.Enabled = True
            Else                                      'ADD 按钮不可见
                Me.ToolBar.Buttons.Item(3).Enabled = False
                mnuAdd.Enabled = False
            End If
            If Previewdv(i)("FUNC_CODE_Change") = 1 Then '修改 按钮可见
                Me.ToolBar.Buttons.Item(4).Enabled = True
                mnuEdit.Enabled = True
            Else                                          '修改 按钮不可见
                Me.ToolBar.Buttons.Item(4).Enabled = False
                mnuEdit.Enabled = False
            End If
            If Previewdv(i)("FUNC_CODE_Del") = 1 Then '删除 按钮可见
                Me.ToolBar.Buttons.Item(5).Enabled = True
                mnuDelete.Enabled = True
            Else                                     '删除按钮不可见
                Me.ToolBar.Buttons.Item(5).Enabled = False
                mnuDelete.Enabled = False
            End If
        End If
    End Sub

    'Private Sub C1DBG_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
    '    If Me.C1DBG.Columns("Logic").CellValue(e.Row) = 1 Then
    '        e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
    '    End If
    'End Sub
    'Private Sub C1DBG_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
    '    If Me.C1DBG.Columns("Logic").CellValue(e.Row) = 1 Then
    '        e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
    '    End If
    'End Sub
    'Private Sub C1DBG_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
    '    If Me.C1DBG.Columns("Logic").CellValue(e.Row) = 1 Then
    '        e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
    '    End If
    'End Sub
    'Private Sub C1DBG_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
    '    If Me.C1DBG.Columns("Logic").CellValue(e.Row) = 1 Then
    '        e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
    '    End If
    'End Sub
    'Private Sub C1DBG_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
    '    If Me.C1DBG.Columns("Logic").CellValue(e.Row) = 1 Then
    '        e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
    '    End If
    'End Sub

    Private Sub Frm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.C1DBGV.Height = Me.Height - 140
        'Me.C1DBGTALLY_LIST.Height = Me.Height - 100
        Me.C1DBGTALLY_LIST.Height = Me.TabTALLY_LIST.Height - 3
        Me.C1DBGTALLY_LIST.Width = Me.TabTALLY_LIST.Width - 3
        Me.Label.Width = Me.C1DBGTALLY_LIST.Width - 3
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
        SqlStrShip = "where (((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('2','3','0'))) and Voyage like '" & Trim(txtVoyage.Text) & "%' and (ENG_VESSEL Like '" & Trim(txtShipName.Text) & "%' OR CHI_VESSEL like '" & Trim(txtShipName.Text) & "%' ))  and code_goods<>'2' "
        '可能要修改
        G_ShipName = Trim(txtShipName.Text)
        G_Voyage = Trim(txtVoyage.Text)
        Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '可能要修改
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

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                ToolBar.Buttons.Item(0).Enabled = True
                mnuFind.Enabled = True
                ToolBar.Buttons.Item(1).Enabled = False
                ToolBar.Buttons.Item(2).Enabled = True
                mnuQuery.Enabled = True
                ToolBar.Buttons.Item(3).Enabled = True
                mnuAdd.Enabled = True
                ToolBar.Buttons.Item(4).Enabled = True
                mnuEdit.Enabled = True
                ToolBar.Buttons.Item(5).Enabled = True
                mnuDelete.Enabled = True
                ToolBar.Buttons.Item(6).Enabled = True
                mnuPrint.Enabled = True
                ToolBar.Buttons.Item(7).Enabled = True
                mnuExport.Enabled = True
                ToolBar.Buttons.Item(8).Enabled = True
                mnuQuit.Enabled = True
            Case 1
                ToolBar.Buttons.Item(0).Enabled = True
                mnuFind.Enabled = True
                ToolBar.Buttons.Item(1).Enabled = False
                ToolBar.Buttons.Item(2).Enabled = True
                mnuQuery.Enabled = True
                ToolBar.Buttons.Item(3).Enabled = True
                mnuAdd.Enabled = True
                ToolBar.Buttons.Item(4).Enabled = True
                mnuEdit.Enabled = True
                ToolBar.Buttons.Item(5).Enabled = True
                mnuDelete.Enabled = True
                ToolBar.Buttons.Item(6).Enabled = True
                mnuPrint.Enabled = True
                ToolBar.Buttons.Item(7).Enabled = False
                mnuExport.Enabled = False
                ToolBar.Buttons.Item(8).Enabled = True
                mnuQuit.Enabled = True

            Case 2
                ToolBar.Buttons.Item(0).Enabled = True
                mnuFind.Enabled = True
                ToolBar.Buttons.Item(1).Enabled = False
                ToolBar.Buttons.Item(2).Enabled = True
                mnuQuery.Enabled = True
                ToolBar.Buttons.Item(3).Enabled = True
                mnuAdd.Enabled = True
                ToolBar.Buttons.Item(4).Enabled = True
                mnuEdit.Enabled = True
                ToolBar.Buttons.Item(5).Enabled = True
                mnuDelete.Enabled = True
                ToolBar.Buttons.Item(6).Enabled = True
                mnuPrint.Enabled = True
                ToolBar.Buttons.Item(7).Enabled = False
                mnuExport.Enabled = False
                ToolBar.Buttons.Item(8).Enabled = True
                mnuQuit.Enabled = True
            Case 3
                ToolBar.Buttons.Item(0).Enabled = True
                mnuFind.Enabled = True
                ToolBar.Buttons.Item(1).Enabled = False
                ToolBar.Buttons.Item(2).Enabled = True
                mnuQuery.Enabled = True
                ToolBar.Buttons.Item(3).Enabled = True
                mnuAdd.Enabled = True
                ToolBar.Buttons.Item(4).Enabled = True
                mnuEdit.Enabled = True
                ToolBar.Buttons.Item(5).Enabled = True
                mnuDelete.Enabled = True
                ToolBar.Buttons.Item(6).Enabled = True
                mnuPrint.Enabled = True
                ToolBar.Buttons.Item(7).Enabled = False
                mnuExport.Enabled = False
                ToolBar.Buttons.Item(8).Enabled = True
                mnuQuit.Enabled = True
            Case 4
                ToolBar.Buttons.Item(0).Enabled = False
                mnuFind.Enabled = False
                ToolBar.Buttons.Item(1).Enabled = True
                ToolBar.Buttons.Item(2).Enabled = True
                mnuQuery.Enabled = True
                ToolBar.Buttons.Item(3).Enabled = False
                mnuAdd.Enabled = False
                ToolBar.Buttons.Item(4).Enabled = False
                mnuEdit.Enabled = False
                ToolBar.Buttons.Item(5).Enabled = False
                mnuDelete.Enabled = False
                ToolBar.Buttons.Item(6).Enabled = True
                mnuPrint.Enabled = True
                ToolBar.Buttons.Item(7).Enabled = False
                mnuExport.Enabled = False
                ToolBar.Buttons.Item(8).Enabled = True
                mnuQuit.Enabled = True
                SHIFTING_Flag = 1
            Case 5
                ToolBar.Buttons.Item(0).Enabled = False
                mnuFind.Enabled = False
                ToolBar.Buttons.Item(1).Enabled = True
                ToolBar.Buttons.Item(2).Enabled = True
                mnuQuery.Enabled = True
                ToolBar.Buttons.Item(3).Enabled = False
                mnuAdd.Enabled = False
                ToolBar.Buttons.Item(4).Enabled = False
                mnuEdit.Enabled = False
                ToolBar.Buttons.Item(5).Enabled = False
                mnuDelete.Enabled = False
                ToolBar.Buttons.Item(6).Enabled = True
                mnuPrint.Enabled = True
                ToolBar.Buttons.Item(7).Enabled = False
                mnuExport.Enabled = False
                ToolBar.Buttons.Item(8).Enabled = True
                mnuQuit.Enabled = True
                SHIFTING_Flag = 2
        End Select
    End Sub


    Private Sub MenuItem14_Click(sender As Object, e As EventArgs) Handles MenuItem14.Click
        Dim Frm As New SMS.MessageSend

        SMS.G_User = G_User
        SMS.G_User_Serial = G_User_Serial
        SMS.G_DeptCode = G_DeptCode
        SMS.G_DeptName = G_DeptName
        SMS.G_Part_Id = G_Part_Id
        SMS.G_Part = G_Part
        SMS.G_ShipName = G_ShipName
        SMS.G_Voyage = G_Voyage
        SMS.Ship_ID = Ship_ID
        Frm.ShowDialog()
    End Sub
End Class

