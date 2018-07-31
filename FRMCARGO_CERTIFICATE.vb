Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FRMCARGO_CERTIFICATE
    Inherits System.Windows.Forms.Form
    Dim dsShip As New DataSet   '船舶数据集
    Dim SqlStrShip As String  '船舶条件语句
    Dim FirmShip As String
    Dim SortShip As String
    Dim inoutstr As String

    Dim dsShort As New DataSet '溢短单
    Dim dsDamaged As New DataSet        '残损单
    Dim dsAssorting As New DataSet '分标志单
    Dim dsCertificate As New DataSet     '理货业务凭证 

    Dim SqlStr As String  '条件语句
    Dim SelectStr As String
    Dim DynaStr As String '可变的条件设计
    Dim FirmStr As String '不变的条件设计
    ', FirmTally, FirmWait, FirmWorkRecord, FirmMeasure, FirmDaily
    Dim ColNum As Integer '不显示的列数
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
    Friend WithEvents GBV As System.Windows.Forms.GroupBox
    Friend WithEvents ToolBarV As System.Windows.Forms.ToolBar
    Friend WithEvents btResure As System.Windows.Forms.Button
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents C1DBGV As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents S1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnOK As System.Windows.Forms.ToolBarButton
    Friend WithEvents S2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSearch As System.Windows.Forms.ToolBarButton
    Friend WithEvents S3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSort As System.Windows.Forms.ToolBarButton
    Friend WithEvents S4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnEng As System.Windows.Forms.ToolBarButton
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents LabREMARKS As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents tbbtnFind As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtndo As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuery As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnAdd As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnEdit As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnDelete As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnPrint As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnExport As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuit As System.Windows.Forms.ToolBarButton
    Friend WithEvents TabShort As System.Windows.Forms.TabPage
    Friend WithEvents TabCertificate As System.Windows.Forms.TabPage
    Friend WithEvents TabAssorting As System.Windows.Forms.TabPage
    Friend WithEvents C1DBGShort As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents TabDamaged As System.Windows.Forms.TabPage
    Friend WithEvents C1DBGDamaged As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1DBGCertificate As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1DBGAssorting As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMCARGO_CERTIFICATE))
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
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
        Me.tbbtnQuit = New System.Windows.Forms.ToolBarButton
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabShort = New System.Windows.Forms.TabPage
        Me.C1DBGShort = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TabDamaged = New System.Windows.Forms.TabPage
        Me.C1DBGDamaged = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TabAssorting = New System.Windows.Forms.TabPage
        Me.C1DBGAssorting = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TabCertificate = New System.Windows.Forms.TabPage
        Me.C1DBGCertificate = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.LabREMARKS = New System.Windows.Forms.Label
        Me.Label = New System.Windows.Forms.Label
        Me.GBV.SuspendLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabShort.SuspendLayout()
        CType(Me.C1DBGShort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDamaged.SuspendLayout()
        CType(Me.C1DBGDamaged, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAssorting.SuspendLayout()
        CType(Me.C1DBGAssorting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCertificate.SuspendLayout()
        CType(Me.C1DBGCertificate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GBV.TabIndex = 6
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
        Me.GB.Controls.Add(Me.TabControl1)
        Me.GB.Controls.Add(Me.LabREMARKS)
        Me.GB.Controls.Add(Me.Label)
        Me.GB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB.Location = New System.Drawing.Point(174, 0)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(484, 401)
        Me.GB.TabIndex = 7
        Me.GB.TabStop = False
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnFind, Me.tbbtndo, Me.tbbtnQuery, Me.tbbtnAdd, Me.tbbtnEdit, Me.tbbtnDelete, Me.tbbtnPrint, Me.tbbtnExport, Me.tbbtnQuit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.Enabled = False
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(3, 17)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(478, 41)
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
        Me.tbbtnExport.Text = "导出"
        Me.tbbtnExport.ToolTipText = "导出Excel"
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
        Me.TabControl1.Controls.Add(Me.TabShort)
        Me.TabControl1.Controls.Add(Me.TabDamaged)
        Me.TabControl1.Controls.Add(Me.TabAssorting)
        Me.TabControl1.Controls.Add(Me.TabCertificate)
        Me.TabControl1.Location = New System.Drawing.Point(6, 124)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(474, 274)
        Me.TabControl1.TabIndex = 15
        '
        'TabShort
        '
        Me.TabShort.Controls.Add(Me.C1DBGShort)
        Me.TabShort.Location = New System.Drawing.Point(4, 22)
        Me.TabShort.Name = "TabShort"
        Me.TabShort.Size = New System.Drawing.Size(466, 248)
        Me.TabShort.TabIndex = 0
        Me.TabShort.Text = "溢短单"
        '
        'C1DBGShort
        '
        Me.C1DBGShort.AllowFilter = False
        Me.C1DBGShort.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGShort.AllowUpdate = False
        Me.C1DBGShort.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGShort.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGShort.Images.Add(CType(resources.GetObject("C1DBGShort.Images"), System.Drawing.Image))
        Me.C1DBGShort.Location = New System.Drawing.Point(2, 2)
        Me.C1DBGShort.Name = "C1DBGShort"
        Me.C1DBGShort.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGShort.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGShort.PreviewInfo.ZoomFactor = 75
        Me.C1DBGShort.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGShort.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGShort.Size = New System.Drawing.Size(464, 247)
        Me.C1DBGShort.TabIndex = 11
        Me.C1DBGShort.Text = "C1DBG"
        Me.C1DBGShort.PropBag = resources.GetString("C1DBGShort.PropBag")
        '
        'TabDamaged
        '
        Me.TabDamaged.Controls.Add(Me.C1DBGDamaged)
        Me.TabDamaged.Location = New System.Drawing.Point(4, 22)
        Me.TabDamaged.Name = "TabDamaged"
        Me.TabDamaged.Size = New System.Drawing.Size(466, 248)
        Me.TabDamaged.TabIndex = 1
        Me.TabDamaged.Text = "残损单"
        Me.TabDamaged.Visible = False
        '
        'C1DBGDamaged
        '
        Me.C1DBGDamaged.AllowFilter = False
        Me.C1DBGDamaged.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGDamaged.AllowUpdate = False
        Me.C1DBGDamaged.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGDamaged.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGDamaged.Images.Add(CType(resources.GetObject("C1DBGDamaged.Images"), System.Drawing.Image))
        Me.C1DBGDamaged.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGDamaged.Name = "C1DBGDamaged"
        Me.C1DBGDamaged.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGDamaged.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGDamaged.PreviewInfo.ZoomFactor = 75
        Me.C1DBGDamaged.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGDamaged.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGDamaged.Size = New System.Drawing.Size(464, 247)
        Me.C1DBGDamaged.TabIndex = 12
        Me.C1DBGDamaged.Text = "C1DBG"
        Me.C1DBGDamaged.PropBag = resources.GetString("C1DBGDamaged.PropBag")
        '
        'TabAssorting
        '
        Me.TabAssorting.Controls.Add(Me.C1DBGAssorting)
        Me.TabAssorting.Location = New System.Drawing.Point(4, 22)
        Me.TabAssorting.Name = "TabAssorting"
        Me.TabAssorting.Size = New System.Drawing.Size(466, 248)
        Me.TabAssorting.TabIndex = 3
        Me.TabAssorting.Text = "分标志单"
        Me.TabAssorting.Visible = False
        '
        'C1DBGAssorting
        '
        Me.C1DBGAssorting.AllowFilter = False
        Me.C1DBGAssorting.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGAssorting.AllowUpdate = False
        Me.C1DBGAssorting.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGAssorting.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGAssorting.Images.Add(CType(resources.GetObject("C1DBGAssorting.Images"), System.Drawing.Image))
        Me.C1DBGAssorting.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGAssorting.Name = "C1DBGAssorting"
        Me.C1DBGAssorting.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGAssorting.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGAssorting.PreviewInfo.ZoomFactor = 75
        Me.C1DBGAssorting.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGAssorting.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGAssorting.Size = New System.Drawing.Size(464, 247)
        Me.C1DBGAssorting.TabIndex = 12
        Me.C1DBGAssorting.Text = "C1DBG"
        Me.C1DBGAssorting.PropBag = resources.GetString("C1DBGAssorting.PropBag")
        '
        'TabCertificate
        '
        Me.TabCertificate.Controls.Add(Me.C1DBGCertificate)
        Me.TabCertificate.Location = New System.Drawing.Point(4, 22)
        Me.TabCertificate.Name = "TabCertificate"
        Me.TabCertificate.Size = New System.Drawing.Size(466, 248)
        Me.TabCertificate.TabIndex = 2
        Me.TabCertificate.Text = "理货业务凭证"
        Me.TabCertificate.Visible = False
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
        Me.C1DBGCertificate.Size = New System.Drawing.Size(464, 247)
        Me.C1DBGCertificate.TabIndex = 12
        Me.C1DBGCertificate.Text = "C1DBG"
        Me.C1DBGCertificate.PropBag = resources.GetString("C1DBGCertificate.PropBag")
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
        'FRMCARGO_CERTIFICATE
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(658, 401)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.GBV)
        Me.Menu = Me.MainMenu
        Me.Name = "FRMCARGO_CERTIFICATE"
        Me.Text = "理货凭证"
        Me.GBV.ResumeLayout(False)
        Me.GBV.PerformLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabShort.ResumeLayout(False)
        CType(Me.C1DBGShort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabDamaged.ResumeLayout(False)
        CType(Me.C1DBGDamaged, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAssorting.ResumeLayout(False)
        CType(Me.C1DBGAssorting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCertificate.ResumeLayout(False)
        CType(Me.C1DBGCertificate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRMCARGO_CERTIFICATE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Text = Me.Text & "_" & G_DeptName
        SortShip = " Order by Ship_Statu,Dept_Code,id desc " '默认的排序 
        FirmShip = "where DEPT_CODE LIKE '" & G_DeptCode & "%' and code_goods<>'2' " '船舶不变的条件设计
        SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('2','3'))) and code_goods<>'2'  " 'OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) "
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
                SqlStrShip = "where (DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('2','3'))  and code_goods<>'2' " 'OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) " '船舶可变的条件设计
                SortShip = " Order by Ship_Statu,Dept_Code,id desc "
                Call myDataGridShip(SqlStrShip & inoutstr & SortShip)

            Case 3
                Dim FrmFind As New FrmFind
                Table_Name = "SSHIP"
                FrmFind.ShowDialog()
                If Flag = 0 Then
                    Call myDataGridShip(FirmShip & inoutstr & " and (" & Sql_Find & ")  " & SortShip)    '可能要修改
                    SqlStrShip = FirmStr & " and (" & Sql_Find & ")  "
                ElseIf Flag = 2 Then
                    SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','4')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0))  and code_goods<>'2' "
                    Call myDataGridShip(SqlStrShip & inoutstr & SortShip)
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

        If Trim(dsShip.Tables(0).Rows(0).Item("InOutPort_Name")) = "出口" Then
            Hatch_in = 1
        Else
            Hatch_in = 0
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

        Call getShort(FirmStr)    '溢短单
        Call getDamaged(FirmStr)         '残损单
        Call getAssorting(FirmStr)    '分标志单

        ds_sship.Reset()        '理货业务凭证
        dw = Getdata("select * from view_outhatch_sship1 where ship_id='" & Ship_ID & "'", ds_sship)

        If ds_sship.Tables(0).Rows.Count > 0 Then
            trade = ds_sship.Tables(0).Rows(0).Item("s_trade")
            If trade = "1" Then
                dw = Getdata("exec SP_CARGO_CERTIFICATE '" & Ship_ID & "'", DS_DO)
            ElseIf trade = "2" Then
                dw = Getdata("exec SP_CARGO_CERTIFICATE_eng '" & Ship_ID & "'", DS_DO)
            End If
        End If
        Call getCertificate()
        Exit Sub
Err:
        Resume Next
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

    Private Sub getAssorting(ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            '不显示的列名在最前面
            strsql = "select  *  from VIEW_CARGO_MARKS_ASSORT  where " & Sql '******要修改

            Me.C1DBGAssorting.DataSource = Getdata(strsql, dsAssorting)  ' class dbcontrol getdata fuction
            ColNum = 2 '不显示的列数 '******要修改
            Table_Name = "VIEW_CARGO_MARKS_ASSORT" '操作的数据库表名 ''******要修改

            For i = 0 To ColNum - 1 '设计部显示的列
                Me.C1DBGAssorting.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Translate = True
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Validate = True
            'Me.C1DBG.Splits(0).DisplayColumns.Item("Logic").Visible = False

            Call SetColumnCaptionAssorting() '设计列标题
            Call SetColumnWidthAssorting() '设计列宽度
            If dsAssorting.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumAssorting(Sql) '设计合计列
            End If
            'Me.C1DBG.FetchRowStyles = True
            Me.C1DBGAssorting.Refresh()
            Me.C1DBGAssorting.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色
            Me.C1DBGAssorting.MoveLast()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getCertificate()
        Dim strsql As String
        Dim i As Integer
        Try
            C1DBGCertificate.Visible = True
            C1DBGCertificate.DataSource = DS_DO.Tables(0).DefaultView
            C1DBGCertificate.Refresh()
            Me.C1DBGCertificate.Columns.Item("item").Caption = "项目"
            Me.C1DBGCertificate.Columns.Item("amount").Caption = "件数"
            Me.C1DBGCertificate.Columns.Item("unit").Caption = "单位"
            Call SetColumnWidthCertificate()
            Me.C1DBGCertificate.Refresh()
        Catch ex As Exception
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

    Private Sub SetColumnCaptionAssorting()
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

            Do While i < Me.C1DBGAssorting.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGAssorting.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBGAssorting.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
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

    Private Sub SetColumnWidthAssorting()
        Dim j As Integer
        For j = 0 To Me.C1DBGAssorting.Columns.Count - 1
            Me.C1DBGAssorting.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.C1DBGAssorting.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.C1DBGAssorting.Splits(0).DisplayColumns.Item(j).Width < 40 Then
                Me.C1DBGAssorting.Splits(0).DisplayColumns.Item(j).Width = 40
            Else
                If Me.C1DBGAssorting.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.C1DBGAssorting.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If
        Next
    End Sub

    Private Sub SetColumnWidthCertificate()
        Dim j As Integer
        For j = 0 To Me.C1DBGCertificate.Columns.Count - 1
            Me.C1DBGCertificate.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.C1DBGCertificate.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.C1DBGCertificate.Splits(0).DisplayColumns.Item(j).Width < 40 Then
                Me.C1DBGCertificate.Splits(0).DisplayColumns.Item(j).Width = 40
            Else
                If Me.C1DBGCertificate.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.C1DBGCertificate.Splits(0).DisplayColumns.Item(j).Width = 120
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

    Private Sub SetColumnSumAssorting(ByVal sql As String)
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
        Me.C1DBGAssorting.ColumnFooters = True
        Me.C1DBGAssorting.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGAssorting.Columns.Item(ColNum).FooterText = "合计 共" & dsAssorting.Tables(0).Rows.Count & "条"
        Do While i < Me.C1DBGAssorting.Columns.Count
            j = 0
            For j = 0 To dset.Tables(0).Rows.Count - 1

                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGAssorting.Columns.Item(i).DataField.ToString)) And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then

                    num = 0
                    For m = 0 To dsAssorting.Tables(0).Rows.Count - 1
                        num = num + dsAssorting.Tables(0).Rows(m)(i)
                    Next
                    Me.C1DBGAssorting.Columns.Item(i).FooterText = CType(num, String)
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

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        Me.Close()
    End Sub

    Private Sub ToolBar_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar.ButtonClick
        Dim dw As New DataView
        Dim dssp As New DataSet
        Select Case Me.ToolBar.Buttons.IndexOf(e.Button)
            Case 0
                Call mnuFind_Click(sender, e)
            Case 1
                Select Case Me.TabControl1.SelectedIndex
                    Case 0
                        dw = Getdata("exec sp_cargo_short '" & Ship_ID & "'", dssp)
                        If dssp.Tables(0).Rows.Count > 0 Then
                            Dim frm As New FrmCARGO_SHORT_DO
                            frm.ShowDialog()
                            Try
                                Call getShort(SqlStr)
                            Catch ex As Exception
                                MsgBox(ex.Message)
                            End Try
                        Else
                            MsgBox("没有溢短！")
                        End If
                    Case 1
                        dw = Getdata("exec sp_CARGO_DAMAGED_List  '" & Ship_ID & "'", dssp)
                        If dssp.Tables(0).Rows.Count > 0 Then
                            Dim frm As New FrmCARGO_DAMAGED_List_DO
                            frm.ShowDialog()
                            Try
                                Call getDamaged(SqlStr)
                            Catch ex As Exception
                                MsgBox(ex.Message)
                            End Try
                        Else
                            MsgBox("没有残损！")
                        End If
                    Case 2
                        dw = Getdata("exec SP_CARGO_MARKS_ASSORTING '" & Ship_ID & "'", dssp)
                        If dssp.Tables(0).Rows.Count > 0 Then
                            Dim frm As New FrmCARGO_MARKS_ASSORTING_DO
                            frm.ShowDialog()
                            Try
                                Call getAssorting(SqlStr)
                            Catch ex As Exception
                                MsgBox(ex.Message)
                            End Try
                        Else
                            MsgBox("没有分标志！")
                        End If
                End Select
            Case 2
                Call mnuQuery_Click(sender, e)
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
                Me.Close()
        End Select
    End Sub

    Private Sub mnuFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFind.Click
        Dim FrmFind As New FrmFind
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                Table_Name = "VIEW_CARGO_SHORT" '可能要修改
                FrmFind.ShowDialog()

                If Flag = 0 Then
                    SelectStr = ""
                    Call getShort(" (" & Sql_Find & ")  " & FirmStr)   '可能要修改
                    SqlStr = " (" & Sql_Find & ")  " & FirmStr '可能要修改
                ElseIf Flag = 2 Then
                    SelectStr = ""
                    Call getShort(DynaStr & FirmStr)   '可能要修改
                    SqlStr = DynaStr & FirmStr '可能要修改
                End If
            Case 1
                Table_Name = "VIEW_CARGO_DAMAGED_List" '可能要修改
                FrmFind.ShowDialog()

                If Flag = 0 Then
                    SelectStr = ""
                    Call getDamaged(" (" & Sql_Find & ")  " & FirmStr)   '可能要修改
                    SqlStr = " (" & Sql_Find & ")  " & FirmStr '可能要修改
                ElseIf Flag = 2 Then
                    SelectStr = ""
                    Call getDamaged(DynaStr & FirmStr)   '可能要修改
                    SqlStr = DynaStr & FirmStr '可能要修改
                End If
            Case 2
                Table_Name = "VIEW_CARGO_MARKS_ASSORT" '可能要修改
                FrmFind.ShowDialog()

                If Flag = 0 Then
                    SelectStr = ""
                    Call getAssorting(" (" & Sql_Find & ")  " & FirmStr)   '可能要修改
                    SqlStr = " (" & Sql_Find & ")  " & FirmStr '可能要修改
                ElseIf Flag = 2 Then
                    SelectStr = ""
                    Call getAssorting(DynaStr & FirmStr)   '可能要修改
                    SqlStr = DynaStr & FirmStr '可能要修改
                End If
        End Select
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                If dsShort.Tables(0).Rows.Count > 0 Then
                    Dim FrmDelete As New FrmCARGO_SHORT_DELETE   '***********要修改
                    ID = CType(Me.C1DBGShort.Columns.Item("ID").Text.ToString, Integer)
                    FrmDelete.ShowDialog()
                    Try
                        Call getShort(SqlStr)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Case 1
                If dsDamaged.Tables(0).Rows.Count > 0 Then
                    Dim FrmDelete As New FrmCARGO_DAMAGED_List_DELETE   '***********要修改
                    ID = CType(Me.C1DBGDamaged.Columns.Item("ID").Text.ToString, Integer)
                    FrmDelete.ShowDialog()
                    Try
                        Call getDamaged(SqlStr)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Case 2
                If dsAssorting.Tables(0).Rows.Count > 0 Then
                    Dim FrmDelete As New FrmCARGO_MARKS_ASSORTING_DELETE  '***********要修改
                    ID = CType(Me.C1DBGAssorting.Columns.Item("ID").Text.ToString, Integer)
                    FrmDelete.ShowDialog()
                    Try
                        Call getAssorting(SqlStr)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
        End Select
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                If dsShort.Tables(0).Rows.Count > 0 Then
                    Dim FrmEdit As New FrmCARGO_SHORT_EDIT   '***********要修改
                    Dim Row As Integer
                    ID = CType(Me.C1DBGShort.Columns.Item("ID").Text.ToString, Integer)
                    Row = Me.C1DBGShort.Row
                    FrmEdit.ShowDialog()
                    Try
                        Call getShort(SqlStr)
                        Me.C1DBGShort.Row = Row
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Case 1
                If dsDamaged.Tables(0).Rows.Count > 0 Then
                    Dim FrmEdit As New FrmCARGO_DAMAGED_List_EDIT  '***********要修改
                    Dim Row As Integer
                    ID = CType(Me.C1DBGDamaged.Columns.Item("ID").Text.ToString, Integer)
                    Row = Me.C1DBGDamaged.Row
                    FrmEdit.ShowDialog()
                    Try
                        Call getDamaged(SqlStr)
                        Me.C1DBGDamaged.Row = Row
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Case 2
                If dsAssorting.Tables(0).Rows.Count > 0 Then
                    Dim FrmEdit As New FrmCARGO_MARKS_ASSORTING_EDIT   '***********要修改
                    Dim Row As Integer
                    ID = CType(Me.C1DBGAssorting.Columns.Item("ID").Text.ToString, Integer)
                    Row = Me.C1DBGAssorting.Row
                    FrmEdit.ShowDialog()
                    Try
                        Call getAssorting(SqlStr)
                        Me.C1DBGAssorting.Row = Row
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
        End Select
    End Sub

    Private Sub mnuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdd.Click
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                Dim FrmAdd As New FrmCARGO_SHORT_ADD   '***********要修改
                If dsShort.Tables(0).Rows.Count > 0 Then
                    ID = CType(Me.C1DBGShort.Columns.Item("ID").Text.ToString, Integer)
                Else
                    ID = -1
                End If
                FrmAdd.ShowDialog()
                Try
                    Call getShort(SqlStr)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case 1
                Dim FrmAdd As New FrmCARGO_DAMAGED_List_ADD   '***********要修改
                If dsDamaged.Tables(0).Rows.Count > 0 Then
                    ID = CType(Me.C1DBGDamaged.Columns.Item("ID").Text.ToString, Integer)
                Else
                    ID = -1
                End If
                FrmAdd.ShowDialog()
                Try
                    Call getDamaged(SqlStr)

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case 2
                Dim FrmAdd As New FrmCARGO_MARKS_ASSORTING_ADD  '***********要修改
                If dsAssorting.Tables(0).Rows.Count > 0 Then
                    ID = CType(Me.C1DBGAssorting.Columns.Item("ID").Text.ToString, Integer)
                Else
                    ID = -1
                End If
                FrmAdd.ShowDialog()
                Try
                    Call getAssorting(SqlStr)

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
        End Select
    End Sub

    Private Sub C1DBGShort_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1DBGShort.DoubleClick
        Call mnuQuery_Click(sender, e)
    End Sub
    Private Sub C1DBGDamged_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1DBGDamaged.DoubleClick
        Call mnuQuery_Click(sender, e)
    End Sub
    Private Sub C1DBGCertificate_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1DBGCertificate.DoubleClick
        Call mnuQuery_Click(sender, e)
    End Sub
    Private Sub C1DBGAssorting_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1DBGAssorting.DoubleClick
        Call mnuQuery_Click(sender, e)
    End Sub

    Private Sub C1DBGShort_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C1DBGShort.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.C1DBGShort.Col = Me.C1DBGShort.Columns.Count - 1 And Me.C1DBGShort.Row < dsShort.Tables(0).Rows.Count - 1 Then
                Me.C1DBGShort.Row = Me.C1DBGShort.Row + 1
                Me.C1DBGShort.Col = ColNum
            End If
        End If
    End Sub
    Private Sub C1DBGDamaged_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C1DBGDamaged.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.C1DBGDamaged.Col = Me.C1DBGDamaged.Columns.Count - 1 And Me.C1DBGDamaged.Row < dsDamaged.Tables(0).Rows.Count - 1 Then
                Me.C1DBGDamaged.Row = Me.C1DBGDamaged.Row + 1
                Me.C1DBGDamaged.Col = ColNum
            End If
        End If
    End Sub
    Private Sub C1DBGAssorting_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C1DBGCertificate.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.C1DBGAssorting.Col = Me.C1DBGAssorting.Columns.Count - 1 And Me.C1DBGAssorting.Row < dsAssorting.Tables(0).Rows.Count - 1 Then
                Me.C1DBGAssorting.Row = Me.C1DBGAssorting.Row + 1
                Me.C1DBGAssorting.Col = ColNum
            End If
        End If
    End Sub

    Private Sub mnuQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuery.Click
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                If dsShort.Tables(0).Rows.Count > 0 Then
                    Dim FrmQuery As New FrmCARGO_SHORT_QUERY  '***********要修改
                    ID = CType(Me.C1DBGShort.Columns.Item("ID").Text.ToString, Integer)
                    FrmQuery.ShowDialog()
                End If
            Case 1
                If dsDamaged.Tables(0).Rows.Count > 0 Then
                    Dim FrmQuery As New FrmCARGO_DAMAGED_List_QUERY   '***********要修改
                    ID = CType(Me.C1DBGDamaged.Columns.Item("ID").Text.ToString, Integer)
                    FrmQuery.ShowDialog()
                End If
            Case 2
                If dsAssorting.Tables(0).Rows.Count > 0 Then
                    Dim FrmQuery As New FrmCARGO_MARKS_ASSORTING_QUERY   '***********要修改
                    ID = CType(Me.C1DBGAssorting.Columns.Item("ID").Text.ToString, Integer)
                    FrmQuery.ShowDialog()
                End If
        End Select
    End Sub

    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                If dsShort.Tables(0).Rows.Count > 0 Then
                    Call PrintExcelShort()
                End If
            Case 1
                If dsDamaged.Tables(0).Rows.Count > 0 Then
                    Call PrintExcelDamaged()
                End If
            Case 2
                If dsAssorting.Tables(0).Rows.Count > 0 Then
                    Call PrintExcelAssorting()
                End If
            Case 3
                If DS_DO.Tables(0).Rows.Count > 0 Then
                    Call PrintExcelCertificate()
                End If
        End Select
    End Sub

    Private Sub mnuExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExport.Click
        Call ExportExcel()
    End Sub

    Private Sub ExportExcel() '导出Excel        
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                If dsShort.Tables(0).Rows.Count > 0 Then
                    Call MakeExcelShort()
                End If
            Case 1
                If dsDamaged.Tables(0).Rows.Count > 0 Then
                    Call MakeExcelDamaged()
                End If
            Case 2
                If dsAssorting.Tables(0).Rows.Count > 0 Then
                    Call MakeExcelAssorting()
                End If
            Case 3
                If DS_DO.Tables(0).Rows.Count > 0 Then
                    ' If DS_DO.Tables(0).Rows.Count > 0 Then
                    Call MakeExcelCertificate()
                End If
        End Select
    End Sub
    Private Sub PrintExcelShort() '打印到Excel        
        Dim Row As Integer
        Dim Col As Integer
        Try
            Call MakeExcelShort()
            Row = dsShort.Tables(0).Rows.Count + 4
            Col = Me.C1DBGShort.Columns.Count - ColNum
            '**************画边框
            For Row = 2 To dsShort.Tables(0).Rows.Count + 4 '画列
                xlSheet.Range(xlSheet.Cells(Row, 1), xlSheet.Cells(Row, C1DBGShort.Columns.Count - ColNum)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 7
            Next Row
            For Col = 1 To C1DBGShort.Columns.Count - ColNum + 1 '画行
                xlSheet.Range(xlSheet.Cells(3, Col), xlSheet.Cells(dsShort.Tables(0).Rows.Count + 4, Col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7
            Next Col
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub
    Private Sub PrintExcelDamaged() '打印到Excel        
        Dim Row As Integer
        Dim Col As Integer
        Try
            Call MakeExcelDamaged()
            Row = dsDamaged.Tables(0).Rows.Count + 4
            Col = Me.C1DBGDamaged.Columns.Count - ColNum
            '**************画边框
            For Row = 2 To dsDamaged.Tables(0).Rows.Count + 4 '画列
                xlSheet.Range(xlSheet.Cells(Row, 1), xlSheet.Cells(Row, C1DBGDamaged.Columns.Count - ColNum)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 7
            Next Row
            For Col = 1 To C1DBGDamaged.Columns.Count - ColNum + 1 '画行
                xlSheet.Range(xlSheet.Cells(3, Col), xlSheet.Cells(dsDamaged.Tables(0).Rows.Count + 4, Col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7
            Next Col
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub
    Private Sub PrintExcelAssorting() '打印到Excel        
        Dim Row As Integer
        Dim Col As Integer
        Try
            Call MakeExcelAssorting()
            Row = dsAssorting.Tables(0).Rows.Count + 4
            Col = Me.C1DBGAssorting.Columns.Count - ColNum
            '**************画边框
            For Row = 2 To dsAssorting.Tables(0).Rows.Count + 4 '画列
                xlSheet.Range(xlSheet.Cells(Row, 1), xlSheet.Cells(Row, C1DBGAssorting.Columns.Count - ColNum)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 7
            Next Row
            For Col = 1 To C1DBGAssorting.Columns.Count - ColNum + 1 '画行
                xlSheet.Range(xlSheet.Cells(3, Col), xlSheet.Cells(dsAssorting.Tables(0).Rows.Count + 4, Col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7
            Next Col
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub
    Private Sub PrintExcelCertificate() '打印到Excel  
        If Hatch_in = 1 Then
            Inoutport_Cha = "出口"
            Inoutport_eng = "Outward"
        Else
            Inoutport_Cha = "进口"
            Inoutport_eng = "Inward"
        End If
        Try
            If trade = "1" Then
                Call china()
            ElseIf trade = "2" Then
                Call eng()
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
            FileCopy(pathstr + "Report_zlp.xls", pathstr + "Report.xls")
            Filepath = pathstr + "report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("理货业务凭证"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = True
            xlsheet.Cells(3, 1) = "(" & Inoutport_Cha & ")"
            xlsheet.Cells(4, 1) = "船名： " & ds_sship.Tables(0).Rows(0).Item("CHI_VESSEL")
            xlsheet.Cells(4, 4) = "航次： " & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            xlsheet.Cells(4, 7) = "国籍： " & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_CHA")
            'xlsheet.Cells(3, 5) = "泊位： " & ds.Tables(1).Rows(0).Item("berth")
            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) Then
            Else
                xlsheet.Cells(5, 1) = "开工日期：" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")) & "年" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")) & "月" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")) & "日"

            End If
            xlsheet.Cells(5, 6) = "制单日期：" & Year(Now) & "年" & Month(Now) & "月" & Day(Now) & "日"

            'For row = 0 To ds.Tables(0).Rows.Count - 1
            '    For col = 0 To 7
            '        xlsheet.Cells(6 + row, col + 1) = ds.Tables(0).Rows(row)(col)
            '    Next col
            'Next row
            xlsheet.Cells(9, 5) = DS_DO.Tables(0).Rows(0)(1)
            xlsheet.Cells(9, 7) = "节假日理货：" & DS_DO.Tables(0).Rows(1)(1)
            xlsheet.Cells(10, 7) = "夜班：" & DS_DO.Tables(0).Rows(2)(1)
            xlsheet.Cells(20, 5) = DS_DO.Tables(0).Rows(3)(1)
            xlsheet.Cells(21, 5) = DS_DO.Tables(0).Rows(4)(1)
            xlsheet.Cells(22, 5) = DS_DO.Tables(0).Rows(5)(1)
            If DS_DO.Tables(0).Rows.Count > 6 Then
                For row = 6 To DS_DO.Tables(0).Rows.Count - 1
                    xlsheet.Cells(23 + row - 6, 3) = DS_DO.Tables(0).Rows(row)(0)
                    xlsheet.Cells(23 + row - 6, 5) = DS_DO.Tables(0).Rows(row)(1)
                Next row
            End If
            'For row = 7 To ds.Tables(1).Rows.Count + 7 '*画行
            '    xlsheet.Range(xlsheet.Cells(row, 1), xlsheet.Cells(row, 19)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 7
            'Next row
            'For col = 1 To 19 '* 画列
            '    xlsheet.Range(xlsheet.Cells(7, col), xlsheet.Cells(ds.Tables(1).Rows.Count + 7, col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7
            'Next col
            'xlsheet.Range(xlsheet.Cells(ds.Tables(1).Rows.Count + 4, 1), xlsheet.Cells(ds.Tables(1).Rows.Count + 4, 1)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7
            'xlsheet.Range(xlsheet.Cells(ds.Tables(1).Rows.Count + 4, 10), xlsheet.Cells(ds.Tables(1).Rows.Count + 4, 10)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7

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
            FileCopy(pathstr + "Report_CARGO.xls", pathstr + "Report.xls")
            Filepath = pathstr + "report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("理货业务凭证(E)"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = True
            xlsheet.Select()

            xlsheet.Cells(10, 1) = "(" & Inoutport_eng & ")"
            xlsheet.Cells(11, 5) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
            xlsheet.Cells(11, 9) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            xlsheet.Cells(11, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
            'xlsheet.Cells(3, 5) = "Berth: " & ds.Tables(1).Rows(0).Item("berth")
            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                xlsheet.Cells(12, 7) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                'xlsheet.Cells(12, 7) = "'" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")) & "-" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "-" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0")
            End If
            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")) = False Then
                xlsheet.Cells(12, 12) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
            End If
            'xlsheet.Cells(12, 12) = "'" & Year(Now) & "-" & Month(Now).ToString.PadLeft(2, "0") & "-" & Day(Now).ToString.PadLeft(2, "0")
            xlsheet.Cells(18, 7) = DS_DO.Tables(0).Rows(0)(1)
            If (DS_DO.Tables(0).Rows(1)(1) > 0) Then
                xlsheet.Cells(18, 9) = DS_DO.Tables(0).Rows(1)(1) & " PKGS"
            End If
            If (DS_DO.Tables(0).Rows(2)(1) > 0) Then
                xlsheet.Cells(19, 9) = DS_DO.Tables(0).Rows(2)(1) & " PKGS"
            End If
            If (DS_DO.Tables(0).Rows(3)(1) > 0) Then
                xlsheet.Cells(29, 7) = DS_DO.Tables(0).Rows(3)(1)
                xlsheet.Cells(29, 8) = DS_DO.Tables(0).Rows(3)(2)
            End If
            If (DS_DO.Tables(0).Rows(4)(1) > 0) Then
                xlsheet.Cells(30, 7) = DS_DO.Tables(0).Rows(4)(1)
                xlsheet.Cells(30, 8) = DS_DO.Tables(0).Rows(4)(2)
            End If
            If (DS_DO.Tables(0).Rows(5)(1) > 0) Then
                xlsheet.Cells(31, 7) = DS_DO.Tables(0).Rows(5)(1)
                xlsheet.Cells(31, 8) = DS_DO.Tables(0).Rows(5)(2)
            End If
            If (DS_DO.Tables(0).Rows(6)(1) > 0) Then
                xlsheet.Cells(32, 7) = DS_DO.Tables(0).Rows(6)(1)
                xlsheet.Cells(32, 8) = DS_DO.Tables(0).Rows(6)(2)
            End If
            If DS_DO.Tables(0).Rows.Count > 7 Then
                For row = 6 To DS_DO.Tables(0).Rows.Count - 1
                    If (DS_DO.Tables(0).Rows(row)(1) > 0) Then
                        xlsheet.Cells(33 + row - 7, 3) = DS_DO.Tables(0).Rows(row)(0)
                        xlsheet.Cells(33 + row - 7, 7) = DS_DO.Tables(0).Rows(row)(1)
                        xlsheet.Cells(33 + row - 7, 8) = DS_DO.Tables(0).Rows(row)(2)
                    End If
                Next row
            End If
            xlsheet.PrintPreview()
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
        End Try
    End Sub

    Private Sub MakeExcelShort()
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

            For Col = ColNum To Me.C1DBGShort.Columns.Count - 1 '列标题
                xlSheet.Cells(3, Col - ColNum + 1) = Me.C1DBGShort.Columns(Col).Caption
            Next Col
            Me.C1DBGShort.MoveFirst()
            For Row = 0 To dsShort.Tables(0).Rows.Count - 1 '数据
                For Col = ColNum To Me.C1DBGShort.Columns.Count - 1
                    xlSheet.Cells(Row + 4, Col - ColNum + 1) = Me.C1DBGShort.Columns(Col).Text.ToString      'ds.Tables(0).Rows(Row)(Col)
                Next Col
                Me.C1DBGShort.MoveNext()
            Next Row
            If Me.C1DBGShort.ColumnFooters = True Then '合计项
                For Col = ColNum To Me.C1DBGShort.Columns.Count - 1
                    xlSheet.Cells(dsShort.Tables(0).Rows.Count + 4, Col - ColNum + 1) = Me.C1DBGShort.Columns(Col).FooterText
                Next Col
            End If
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub MakeExcelDamaged()
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

            For Col = ColNum To Me.C1DBGDamaged.Columns.Count - 1 '列标题
                xlSheet.Cells(3, Col - ColNum + 1) = Me.C1DBGDamaged.Columns(Col).Caption
            Next Col
            Me.C1DBGDamaged.MoveFirst()
            For Row = 0 To dsDamaged.Tables(0).Rows.Count - 1 '数据
                For Col = ColNum To Me.C1DBGDamaged.Columns.Count - 1
                    xlSheet.Cells(Row + 4, Col - ColNum + 1) = Me.C1DBGDamaged.Columns(Col).Text.ToString      'ds.Tables(0).Rows(Row)(Col)
                Next Col
                Me.C1DBGDamaged.MoveNext()
            Next Row
            If Me.C1DBGDamaged.ColumnFooters = True Then '合计项
                For Col = ColNum To Me.C1DBGDamaged.Columns.Count - 1
                    xlSheet.Cells(dsDamaged.Tables(0).Rows.Count + 4, Col - ColNum + 1) = Me.C1DBGDamaged.Columns(Col).FooterText
                Next Col
            End If
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub MakeExcelAssorting()
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

            For Col = ColNum To Me.C1DBGAssorting.Columns.Count - 1 '列标题
                xlSheet.Cells(3, Col - ColNum + 1) = Me.C1DBGAssorting.Columns(Col).Caption
            Next Col
            Me.C1DBGAssorting.MoveFirst()
            For Row = 0 To dsAssorting.Tables(0).Rows.Count - 1 '数据
                For Col = ColNum To Me.C1DBGAssorting.Columns.Count - 1
                    xlSheet.Cells(Row + 4, Col - ColNum + 1) = Me.C1DBGAssorting.Columns(Col).Text.ToString      'ds.Tables(0).Rows(Row)(Col)
                Next Col
                Me.C1DBGAssorting.MoveNext()
            Next Row
            If Me.C1DBGAssorting.ColumnFooters = True Then '合计项
                For Col = ColNum To Me.C1DBGAssorting.Columns.Count - 1
                    xlSheet.Cells(dsAssorting.Tables(0).Rows.Count + 4, Col - ColNum + 1) = Me.C1DBGAssorting.Columns(Col).FooterText
                Next Col
            End If
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub MakeExcelCertificate()
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
            Filepath = pathstr + "report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("理货业务凭证(E)"), Excel.Worksheet)
            xlapp.DisplayAlerts = True
            xlsheet.Application.Visible = True
            xlsheet.Select()

            If Hatch_in = 1 Then
                Inoutport_Cha = "出口"
                Inoutport_eng = "Outward"
            Else
                Inoutport_Cha = "进口"
                Inoutport_eng = "Inward"
            End If

            xlsheet.Cells(10, 1) = "(" & Inoutport_eng & ")"
            xlsheet.Cells(11, 5) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
            xlsheet.Cells(11, 9) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            xlsheet.Cells(11, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
            'xlsheet.Cells(3, 5) = "Berth: " & ds.Tables(1).Rows(0).Item("berth")
            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                xlsheet.Cells(12, 7) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "-" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "-" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
            End If
            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")) = False Then
                xlsheet.Cells(12, 12) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "-" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "-" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
            End If
            'xlsheet.Cells(12, 12) = "'" & Year(Now) & "-" & Month(Now).ToString.PadLeft(2, "0") & "-" & Day(Now).ToString.PadLeft(2, "0")
            xlsheet.Cells(18, 7) = DS_DO.Tables(0).Rows(0)(1)
            If (DS_DO.Tables(0).Rows(1)(1) > 0) Then
                xlsheet.Cells(18, 9) = DS_DO.Tables(0).Rows(1)(1) & " PKGS"
            End If
            If (DS_DO.Tables(0).Rows(2)(1) > 0) Then
                xlsheet.Cells(19, 9) = DS_DO.Tables(0).Rows(2)(1) & " PKGS"
            End If
            If (DS_DO.Tables(0).Rows(3)(1) > 0) Then
                xlsheet.Cells(29, 7) = DS_DO.Tables(0).Rows(3)(1)
                xlsheet.Cells(29, 8) = DS_DO.Tables(0).Rows(3)(2)
            End If
            If (DS_DO.Tables(0).Rows(4)(1) > 0) Then
                xlsheet.Cells(30, 7) = DS_DO.Tables(0).Rows(4)(1)
                xlsheet.Cells(30, 8) = DS_DO.Tables(0).Rows(4)(2)
            End If
            If (DS_DO.Tables(0).Rows(5)(1) > 0) Then
                xlsheet.Cells(31, 7) = DS_DO.Tables(0).Rows(5)(1)
                xlsheet.Cells(31, 8) = DS_DO.Tables(0).Rows(5)(2)
            End If
            If (DS_DO.Tables(0).Rows(6)(1) > 0) Then
                xlsheet.Cells(32, 7) = DS_DO.Tables(0).Rows(6)(1)
                xlsheet.Cells(32, 8) = DS_DO.Tables(0).Rows(6)(2)
            End If
            If DS_DO.Tables(0).Rows.Count > 7 Then
                For row = 6 To DS_DO.Tables(0).Rows.Count - 1
                    If (DS_DO.Tables(0).Rows(row)(1) > 0) Then
                        xlsheet.Cells(33 + row - 7, 3) = DS_DO.Tables(0).Rows(row)(0)
                        xlsheet.Cells(33 + row - 7, 7) = DS_DO.Tables(0).Rows(row)(1)
                        xlsheet.Cells(33 + row - 7, 8) = DS_DO.Tables(0).Rows(row)(2)
                    End If
                Next row
            End If
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
        End Try
        'Dim PathStr As String
        'Dim FilePath As String
        'Dim Row As Integer
        'Dim Col As Integer
        'PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        'PathStr = substr(PathStr)
        'Try
        '    FilePath = PathStr + "Report.xls"
        '    xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
        '    xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)
        '    xlSheet = CType(xlBook.Worksheets(1), Excel.Worksheet)
        '    xlApp.DisplayAlerts = False
        '    xlSheet.Application.Visible = True
        '    xlBook.Worksheets("sheet1").select()
        '    xlSheet.Cells(1, 1) = Me.Text() '标题

        '    For Col = ColNum To Me.C1DBGCertificate.Columns.Count - 1 '列标题
        '        xlSheet.Cells(3, Col - ColNum + 1) = Me.C1DBGCertificate.Columns(Col).Caption
        '    Next Col
        '    Me.C1DBGCertificate.MoveFirst()
        '    For Row = 0 To DS_DO.Tables(0).Rows.Count - 1 '数据
        '        For Col = ColNum To Me.C1DBGCertificate.Columns.Count - 1
        '            xlSheet.Cells(Row + 4, Col - ColNum + 1) = Me.C1DBGCertificate.Columns(Col).Text.ToString      'ds.Tables(0).Rows(Row)(Col)
        '        Next Col
        '        Me.C1DBGCertificate.MoveNext()
        '    Next Row
        '    If Me.C1DBGCertificate.ColumnFooters = True Then '合计项
        '        For Col = ColNum To Me.C1DBGCertificate.Columns.Count - 1
        '            xlSheet.Cells(DS_DO.Tables(0).Rows.Count + 4, Col - ColNum + 1) = Me.C1DBGCertificate.Columns(Col).FooterText
        '        Next Col
        '    End If
        'Catch
        '    xlApp.Quit()
        '    SendKeys.Send("N")
        'End Try
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
        Me.C1DBGShort.Height = Me.Height - 120
        Me.C1DBGShort.Width = Me.GB.Width - 5
        Me.Label.Width = Me.C1DBGShort.Width - 3
        Me.C1DBGDamaged.Height = Me.Height - 120
        Me.C1DBGDamaged.Width = Me.GB.Width - 5
        Me.C1DBGAssorting.Height = Me.Height - 120
        Me.C1DBGAssorting.Width = Me.GB.Width - 5
        Me.C1DBGCertificate.Height = Me.Height - 120
        Me.C1DBGCertificate.Width = Me.GB.Width - 5
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
        SqlStrShip = "where (((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('2','3'))) and Voyage like '" & Trim(txtVoyage.Text) & "%' and (ENG_VESSEL Like '" & Trim(txtShipName.Text) & "%' OR CHI_VESSEL like '" & Trim(txtShipName.Text) & "%' ))  and code_goods<>'2' "
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
        Dim dw As New DataView
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                ToolBar.Buttons.Item(0).Enabled = True
                mnuFind.Enabled = True
                ToolBar.Buttons.Item(1).Enabled = True
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
                ToolBar.Buttons.Item(1).Enabled = True
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
            Case 2
                ToolBar.Buttons.Item(0).Enabled = True
                mnuFind.Enabled = True
                ToolBar.Buttons.Item(1).Enabled = True
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
            Case 3
                ToolBar.Buttons.Item(0).Enabled = False
                mnuFind.Enabled = False
                ToolBar.Buttons.Item(1).Enabled = False
                ToolBar.Buttons.Item(2).Enabled = False
                mnuQuery.Enabled = False
                ToolBar.Buttons.Item(3).Enabled = False
                mnuAdd.Enabled = False
                ToolBar.Buttons.Item(4).Enabled = False
                mnuEdit.Enabled = False
                ToolBar.Buttons.Item(5).Enabled = False
                mnuDelete.Enabled = False
                ToolBar.Buttons.Item(6).Enabled = True
                mnuPrint.Enabled = True
                ToolBar.Buttons.Item(7).Enabled = True
                mnuExport.Enabled = True
                ToolBar.Buttons.Item(8).Enabled = True
                mnuQuit.Enabled = True
                If ds_sship.Tables(0).Rows.Count > 0 Then
                    trade = ds_sship.Tables(0).Rows(0).Item("s_trade")
                    If trade = "1" Then
                        dw = Getdata("exec SP_CARGO_CERTIFICATE '" & Ship_ID & "'", DS_DO)
                    ElseIf trade = "2" Then
                        dw = Getdata("exec SP_CARGO_CERTIFICATE_eng '" & Ship_ID & "'", DS_DO)
                    End If
                End If
                Call getCertificate()
        End Select
    End Sub
End Class



