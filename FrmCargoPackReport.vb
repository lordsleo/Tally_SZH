Imports TALLY.DBControl
Public Class FrmCargoPackReport
    Inherits System.Windows.Forms.Form

    Dim dsShip As New DataSet() '船舶数据集
    Dim SqlStrShip As String  '船舶条件语句
    Dim FirmShip As String
    Dim SortShip As String
    Dim inoutstr As String

    Dim ds As New DataSet()
    Dim SqlStr As String  '条件语句
    Dim SelectStr As String
    Dim DynaStr As String '可变的条件设计
    Dim FirmStr As String '不变的条件设计
    Dim ColNum As Integer '不显示的列数

    Dim dvBeizhu As New DataView()
    Dim dwShip As New DataView()
    Dim FrmDeal As New FrmCargoPackReport_Deal()

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
    Friend WithEvents S4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents GBV As System.Windows.Forms.GroupBox
    Friend WithEvents ToolBarV As System.Windows.Forms.ToolBar
    Friend WithEvents C1DBGV As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tbbtnOK As System.Windows.Forms.ToolBarButton
    Friend WithEvents S2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSearch As System.Windows.Forms.ToolBarButton
    Friend WithEvents S3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSort As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnEng As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnDelete As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuQuit As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnSep2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnExport As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuSep1 As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnAdd As System.Windows.Forms.ToolBarButton
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents tbbtnFind As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuery As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnEdit As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnPrint As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuit As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCompile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAdd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrint As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuery As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExport As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFind As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents btResure As System.Windows.Forms.Button
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCargoPackReport))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Dim GridLines2 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Me.S4 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep3 = New System.Windows.Forms.ToolBarButton
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.GBV = New System.Windows.Forms.GroupBox
        Me.btResure = New System.Windows.Forms.Button
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolBarV = New System.Windows.Forms.ToolBar
        Me.tbbtnOK = New System.Windows.Forms.ToolBarButton
        Me.S2 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSearch = New System.Windows.Forms.ToolBarButton
        Me.S3 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSort = New System.Windows.Forms.ToolBarButton
        Me.tbbtnEng = New System.Windows.Forms.ToolBarButton
        Me.C1DBGV = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.tbbtnDelete = New System.Windows.Forms.ToolBarButton
        Me.mnuQuit = New System.Windows.Forms.MenuItem
        Me.tbbtnSep2 = New System.Windows.Forms.ToolBarButton
        Me.mnuDelete = New System.Windows.Forms.MenuItem
        Me.tbbtnExport = New System.Windows.Forms.ToolBarButton
        Me.mnuSep1 = New System.Windows.Forms.MenuItem
        Me.tbbtnAdd = New System.Windows.Forms.ToolBarButton
        Me.GB = New System.Windows.Forms.GroupBox
        Me.Label = New System.Windows.Forms.Label
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.ToolBar = New System.Windows.Forms.ToolBar
        Me.tbbtnFind = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuery = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep1 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnEdit = New System.Windows.Forms.ToolBarButton
        Me.tbbtnPrint = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuit = New System.Windows.Forms.ToolBarButton
        Me.mnuSep2 = New System.Windows.Forms.MenuItem
        Me.mnuCompile = New System.Windows.Forms.MenuItem
        Me.mnuAdd = New System.Windows.Forms.MenuItem
        Me.mnuEdit = New System.Windows.Forms.MenuItem
        Me.mnuPrint = New System.Windows.Forms.MenuItem
        Me.mnuQuery = New System.Windows.Forms.MenuItem
        Me.mnuExport = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.mnuFind = New System.Windows.Forms.MenuItem
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.MainMenu = New System.Windows.Forms.MainMenu
        Me.GBV.SuspendLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB.SuspendLayout()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'S4
        '
        Me.S4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnSep3
        '
        Me.tbbtnSep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ImageList
        '
        Me.ImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'GBV
        '
        Me.GBV.Controls.Add(Me.btResure)
        Me.GBV.Controls.Add(Me.txtVoyage)
        Me.GBV.Controls.Add(Me.Label2)
        Me.GBV.Controls.Add(Me.txtShipName)
        Me.GBV.Controls.Add(Me.Label1)
        Me.GBV.Controls.Add(Me.ToolBarV)
        Me.GBV.Controls.Add(Me.C1DBGV)
        Me.GBV.Dock = System.Windows.Forms.DockStyle.Left
        Me.GBV.Location = New System.Drawing.Point(0, 0)
        Me.GBV.Name = "GBV"
        Me.GBV.Size = New System.Drawing.Size(166, 397)
        Me.GBV.TabIndex = 6
        Me.GBV.TabStop = False
        '
        'btResure
        '
        Me.btResure.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btResure.Location = New System.Drawing.Point(122, 334)
        Me.btResure.Name = "btResure"
        Me.btResure.Size = New System.Drawing.Size(42, 22)
        Me.btResure.TabIndex = 27
        Me.btResure.Text = "查询"
        '
        'txtVoyage
        '
        Me.txtVoyage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVoyage.Location = New System.Drawing.Point(32, 334)
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(88, 21)
        Me.txtVoyage.TabIndex = 26
        Me.txtVoyage.Text = ""
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(2, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "航次"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipName
        '
        Me.txtShipName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtShipName.Location = New System.Drawing.Point(32, 312)
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.Size = New System.Drawing.Size(132, 21)
        Me.txtShipName.TabIndex = 25
        Me.txtShipName.Text = ""
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(2, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "船名"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolBarV
        '
        Me.ToolBarV.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnOK, Me.S2, Me.tbbtnSearch, Me.S3, Me.tbbtnSort, Me.S4, Me.tbbtnEng})
        Me.ToolBarV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBarV.DropDownArrows = True
        Me.ToolBarV.ImageList = Me.ImageList
        Me.ToolBarV.Location = New System.Drawing.Point(3, 353)
        Me.ToolBarV.Name = "ToolBarV"
        Me.ToolBarV.ShowToolTips = True
        Me.ToolBarV.Size = New System.Drawing.Size(160, 41)
        Me.ToolBarV.TabIndex = 1
        '
        'tbbtnOK
        '
        Me.tbbtnOK.ImageIndex = 8
        Me.tbbtnOK.Text = "常规"
        '
        'S2
        '
        Me.S2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnSearch
        '
        Me.tbbtnSearch.ImageIndex = 9
        Me.tbbtnSearch.Text = "检索"
        '
        'S3
        '
        Me.S3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnSort
        '
        Me.tbbtnSort.ImageIndex = 10
        Me.tbbtnSort.Text = "排序"
        '
        'tbbtnEng
        '
        Me.tbbtnEng.ImageIndex = 11
        Me.tbbtnEng.Text = "英文"
        '
        'C1DBGV
        '
        Me.C1DBGV.AllowFilter = True
        Me.C1DBGV.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1DBGV.AllowSort = True
        Me.C1DBGV.AllowUpdate = False
        Me.C1DBGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGV.CaptionHeight = 18
        Me.C1DBGV.CollapseColor = System.Drawing.Color.Black
        Me.C1DBGV.DataChanged = False
        Me.C1DBGV.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBGV.ExpandColor = System.Drawing.Color.Black
        Me.C1DBGV.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGV.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBGV.Location = New System.Drawing.Point(3, 17)
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
        Me.C1DBGV.Size = New System.Drawing.Size(160, 293)
        Me.C1DBGV.TabIndex = 0
        Me.C1DBGV.Text = "C1TrueDBGrid1"
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
        ", 0, 156, 289</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2" & _
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
        "56, 289</ClientArea></Blob>"
        '
        'tbbtnDelete
        '
        Me.tbbtnDelete.ImageIndex = 4
        Me.tbbtnDelete.Text = "删除"
        Me.tbbtnDelete.ToolTipText = "删除"
        '
        'mnuQuit
        '
        Me.mnuQuit.Index = 6
        Me.mnuQuit.Text = "退出(&X)"
        '
        'tbbtnSep2
        '
        Me.tbbtnSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'mnuDelete
        '
        Me.mnuDelete.Enabled = False
        Me.mnuDelete.Index = 2
        Me.mnuDelete.Text = "删除(&D)"
        '
        'tbbtnExport
        '
        Me.tbbtnExport.ImageIndex = 6
        Me.tbbtnExport.Text = "导出"
        Me.tbbtnExport.ToolTipText = "导出Excel"
        '
        'mnuSep1
        '
        Me.mnuSep1.Index = 2
        Me.mnuSep1.Text = "-"
        '
        'tbbtnAdd
        '
        Me.tbbtnAdd.ImageIndex = 2
        Me.tbbtnAdd.Text = "处理"
        Me.tbbtnAdd.ToolTipText = "处理"
        '
        'GB
        '
        Me.GB.Controls.Add(Me.Label)
        Me.GB.Controls.Add(Me.C1DBG)
        Me.GB.Controls.Add(Me.ToolBar)
        Me.GB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB.Location = New System.Drawing.Point(166, 0)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(546, 397)
        Me.GB.TabIndex = 7
        Me.GB.TabStop = False
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.SystemColors.Control
        Me.Label.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label.Location = New System.Drawing.Point(3, 58)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(540, 38)
        Me.Label.TabIndex = 11
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.AllowSort = True
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.CollapseColor = System.Drawing.Color.Black
        Me.C1DBG.DataChanged = False
        Me.C1DBG.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBG.ExpandColor = System.Drawing.Color.Black
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(3, 96)
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
        Me.C1DBG.Size = New System.Drawing.Size(540, 298)
        Me.C1DBG.TabIndex = 10
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Center;Borde" & _
        "r:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView Name="""" AllowRowSizing=""None"" CaptionHeight=""18"" ColumnC" & _
        "aptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" Record" & _
        "SelectorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollG" & _
        "roup=""1""><ClientRect>0, 0, 536, 294</ClientRect><BorderSide>0</BorderSide><Capti" & _
        "onStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" " & _
        "/><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar" & _
        """ me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""" & _
        "Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRow" & _
        "Style parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""S" & _
        "tyle4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=" & _
        """RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><" & _
        "Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><Na" & _
        "medStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><" & _
        "Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Sty" & _
        "le parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Styl" & _
        "e parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Styl" & _
        "e parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style par" & _
        "ent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Sty" & _
        "le parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSp" & _
        "lits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWid" & _
        "th><ClientArea>0, 0, 536, 294</ClientArea></Blob>"
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnFind, Me.tbbtnQuery, Me.tbbtnSep1, Me.tbbtnAdd, Me.tbbtnEdit, Me.tbbtnDelete, Me.tbbtnSep2, Me.tbbtnPrint, Me.tbbtnExport, Me.tbbtnSep3, Me.tbbtnQuit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.Enabled = False
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(3, 17)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(540, 41)
        Me.ToolBar.TabIndex = 9
        '
        'tbbtnFind
        '
        Me.tbbtnFind.ImageIndex = 0
        Me.tbbtnFind.Text = "检索"
        Me.tbbtnFind.ToolTipText = "检索"
        '
        'tbbtnQuery
        '
        Me.tbbtnQuery.ImageIndex = 1
        Me.tbbtnQuery.Text = "查看"
        Me.tbbtnQuery.ToolTipText = "查看"
        '
        'tbbtnSep1
        '
        Me.tbbtnSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnEdit
        '
        Me.tbbtnEdit.ImageIndex = 3
        Me.tbbtnEdit.Text = "编辑"
        Me.tbbtnEdit.ToolTipText = "编辑"
        '
        'tbbtnPrint
        '
        Me.tbbtnPrint.ImageIndex = 5
        Me.tbbtnPrint.Text = "打印"
        Me.tbbtnPrint.ToolTipText = "打印"
        '
        'tbbtnQuit
        '
        Me.tbbtnQuit.ImageIndex = 7
        Me.tbbtnQuit.Text = "退出"
        Me.tbbtnQuit.ToolTipText = "退出"
        '
        'mnuSep2
        '
        Me.mnuSep2.Index = 5
        Me.mnuSep2.Text = "-"
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
        Me.mnuAdd.Text = "处理(&A)"
        '
        'mnuEdit
        '
        Me.mnuEdit.Enabled = False
        Me.mnuEdit.Index = 1
        Me.mnuEdit.Text = "编辑(&E)"
        '
        'mnuPrint
        '
        Me.mnuPrint.Enabled = False
        Me.mnuPrint.Index = 3
        Me.mnuPrint.Text = "打印(&P)..."
        '
        'mnuQuery
        '
        Me.mnuQuery.Enabled = False
        Me.mnuQuery.Index = 1
        Me.mnuQuery.Text = "查看(&Q)"
        '
        'mnuExport
        '
        Me.mnuExport.Enabled = False
        Me.mnuExport.Index = 4
        Me.mnuExport.Text = "导出(&E)"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.Text = "帮助(&H)"
        '
        'mnuFind
        '
        Me.mnuFind.Enabled = False
        Me.mnuFind.Index = 0
        Me.mnuFind.Text = "检索(&F)"
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFind, Me.mnuQuery, Me.mnuSep1, Me.mnuPrint, Me.mnuExport, Me.mnuSep2, Me.mnuQuit})
        Me.mnuFile.Text = "文件(&F)"
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuCompile, Me.mnuHelp})
        '
        'FrmCargoPackReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 397)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.GBV)
        Me.Menu = Me.MainMenu
        Me.Name = "FrmCargoPackReport"
        Me.Text = "散货灌包理货日报"
        Me.GBV.ResumeLayout(False)
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB.ResumeLayout(False)
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCargoPackReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Text = Me.Text & "_" & G_DeptName

        SortShip = " Order by Ship_Statu,Dept_Code,id desc " '默认的排序 
        FirmShip = "where DEPT_CODE LIKE '" & G_DeptCode & "%'" '船舶不变的条件设计
        SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) "
        Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '*****************调用航次信息
        Me.C1DBGV.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.tbbtnDelete.Visible = False
        Me.tbbtnEdit.Visible = False
        Me.mnuEdit.Visible = False
        Me.mnuDelete.Visible = False
        Me.tbbtnQuery.Visible = False
        Me.mnuQuery.Visible = False

        txtShipName.Text = G_ShipName
        txtVoyage.Text = G_Voyage
        txtShipName.Focus()
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
        Dim sqla As New SqlClient.SqlDataAdapter()
        Dim sqlc As New SqlClient.SqlCommand()
        Dim dset As New DataSet()
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
            Case 0
                SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) " '船舶可变的条件设计
                SortShip = " Order by Ship_Statu,Dept_Code,id desc "
                Call myDataGridShip(SqlStrShip & inoutstr & SortShip)

            Case 2
                Dim FrmFind As New FrmFind()
                Table_Name = "SSHIP"
                FrmFind.ShowDialog()
                If Flag = 0 Then
                    Call myDataGridShip(FirmShip & inoutstr & " and (" & Sql_Find & ")  " & SortShip)    '可能要修改
                    SqlStrShip = FirmStr & " and (" & Sql_Find & ")  "    '可能要修改
                ElseIf Flag = 2 Then
                    SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','4')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) "
                    '可能要修改
                    Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '可能要修改
                End If

            Case 4
                Dim FrmSort As New FrmSort()
                FrmSort.ShowDialog()
                If Len(Trim(SortStr)) > 0 Then
                    SortShip = " Order by " & SortStr
                End If
                Call myDataGridShip(SqlStrShip & inoutstr & SortShip)

            Case 6
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
        G_ShipName = Me.C1DBGV.Columns("CHI_VESSEL").Text
        G_Voyage = Me.C1DBGV.Columns("Voyage").Text
        Me.txtShipName.Text = Me.C1DBGV.Columns("CHI_VESSEL").Text
        Me.txtVoyage.Text = Me.C1DBGV.Columns("Voyage").Text

        Dim dsShip As New DataSet() '与前面的dsShip重名，不大好，
        Dim strsql As String
        Ship_ID = CType(Me.C1DBGV.Columns.Item("ID").Text.ToString, Integer)
        strsql = "select * from View_SSHIP where SHIP_ID=" & Ship_ID
        dwShip = Getdata(strsql, dsShip)
        Label.Text = ""
        'strCodeGoods = ""
        'strBerthNo = ""
        'iTons = Nothing
        'Me.strCodeDept = Nothing
        Me.C1DBG.Caption = ""
        If dsShip.Tables(0).DefaultView.Count > 0 Then
            'strCodeDept = dsShip.Tables(0).Rows(0).Item("DEPT_CODE")

            If Len(Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))) > 0 Then
                Label.Text = Label.Text & "中文船名:" & Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL"))) > 0 Then
                Label.Text = Label.Text & "英文船名:" & Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))) > 0 Then
                Label.Text = Label.Text & "航次:" & Trim(dsShip.Tables(0).Rows(0).Item("Voyage")) & " "
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
        FirmStr = " and Ship_ID=" & Ship_ID & " Order by ID desc" '设计初始条件  在检索后不改变的条件  '***************要修改 或 2>1
        DynaStr = " 2>1 " '设计其它初始条件    在检索后不需要的条件 ***************要修改 或 其它条件
        SelectStr = " Top 20 "
        SqlStr = DynaStr & FirmStr

        Me.ToolBar.Enabled = True
        Me.mnuAdd.Enabled = True
        Me.mnuDelete.Enabled = True
        Me.mnuEdit.Enabled = True
        Me.mnuExport.Enabled = True
        Me.mnuFind.Enabled = True
        Me.mnuPrint.Enabled = True
        Me.mnuQuery.Enabled = True
        Call preview("WL3_6_3") '*****************权限设计 '*************要修改模块号
        Call myDataGrid(SelectStr, SqlStr)
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub myDataGrid(ByVal SelStr As String, ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            '不显示的列名在最前面
            strsql = "select " & SelStr & " *  from View_CargoPackSheet  where " & Sql '******要修改

            Me.C1DBG.DataSource = Getdata(strsql, ds)  ' class dbcontrol getdata fuction
            ColNum = 13 '不显示的列数 '******要修改
            Table_Name = "View_CargoPackSheet" '操作的数据库表名 ''******要修改

            For i = 0 To ColNum - 1 '设计部显示的列
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Translate = True
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Validate = True
            'Me.C1DBG.Splits(0).DisplayColumns.Item("Logic").Visible = False

            Call SetColumnCaption() '设计列标题
            Call SetColumnWidth() '设计列宽度
            If ds.Tables(0).Rows.Count > 0 Then
                Call SetColumnSum(Sql) '设计合计列
            End If
            'Me.C1DBG.FetchRowStyles = True
            Me.C1DBG.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ReportDataGrid(ByVal Company As String, ByVal TimeBegin As Date, ByVal TimeEnd As Date)
        Dim strsql As String
        Dim i, j As Integer
        Dim sqlBeizhu, sqlTotalCargo, sqlSumPM, sqlSumCargo As String
        Dim dvTotalCargo As New DataView()
        Dim dvSumPM As New DataView()
        Dim dvSumCargo As New DataView()

        Dim newDataRow As DataRow
        Dim PackAmount_M, PackAmount_P, PackAmount_T As Integer
        Dim PackWeight_M, PackWeight_P, PackWeight_T As Decimal
        Dim Suffix() As Short
        Try
            Me.C1DBG.Caption = "工作起迄时间是 " & TimeBegin & " 至 " & TimeEnd
            Dim timediff As String = " and (datediff(hh, '" & TimeBegin & "' ,time_from) >= 0) and (datediff(hh,time_to, '" & TimeEnd & "') >= 0) "
            sqlTotalCargo = "select code_goods,max(goods) as Goods ,sum(pack_amount) as PackAmount,sum(pack_weight) as PackWeight FROM View_CargoPackSheet WHERE (SHIP_ID = '" & Ship_ID & "') AND (COMPANY_CODE = '" & Company & "') " & timediff & " group by code_goods order by code_goods"
            dvTotalCargo = Filldata(sqlTotalCargo)

            sqlBeizhu = "SELECT  p_m_type,sum(DISQUALIFICATION_AMOUNT + ELIGIBILITY_AMOUNT)as TestAmount,round(100*cast(SUM(ELIGIBILITY_AMOUNT)as decimal)/(SUM(DISQUALIFICATION_AMOUNT)+SUM(ELIGIBILITY_AMOUNT)),3) as EligibleRate,sum((DISQUALIFICATION_AMOUNT + ELIGIBILITY_AMOUNT)*average_weight)/(sum(DISQUALIFICATION_AMOUNT + ELIGIBILITY_AMOUNT)) AS TestWeight FROM CARGO_PACK_SHEET WHERE (SHIP_ID = '" & Ship_ID & "') AND (COMPANY_CODE = '" & Company & "') " & timediff & " group by p_m_type order by p_m_type desc"
            dvBeizhu = Filldata(sqlBeizhu)

            sqlSumCargo = "select sum(pack_amount) as PackAmount,sum(pack_weight) as PackWeight FROM View_CargoPackSheet WHERE (SHIP_ID = '" & Ship_ID & "') AND (COMPANY_CODE = '" & Company & "') and (datediff(hh,time_to, '" & TimeBegin & "') >= 0)"
            dvSumCargo = Filldata(sqlSumCargo)

            sqlSumPM = "select sum(pack_amount) as PackAmount,sum(pack_weight) as PackWeight FROM View_CargoPackSheet WHERE (SHIP_ID = '" & Ship_ID & "') AND (COMPANY_CODE = '" & Company & "') AND (P_M_TYPE = '2') and (datediff(hh,time_to, '" & TimeBegin & "') >= 0)"
            dvSumPM = Filldata(sqlSumPM)

            strsql = "select code_goods,max(goods) as Goods ,sum(pack_amount) as PackAmount,sum(pack_weight) as PackWeight FROM View_CargoPackSheet  WHERE (SHIP_ID = '" & Ship_ID & "') AND (COMPANY_CODE = '" & Company & "') and (p_m_type='2') " & timediff & " group by code_goods,p_m_type order by p_m_type desc,code_goods"
            Getdata(strsql, ds)

            ds.Tables(0).Columns.Add("PackAmount_P", GetType(Integer))
            ds.Tables(0).Columns.Add("PackWeight_P", GetType(Decimal))
            ds.Tables(0).Columns.Add("SubtotalAmount", GetType(Integer))
            ds.Tables(0).Columns.Add("SubtotalWeight", GetType(Decimal))
            PackAmount_M = 0
            PackAmount_P = 0
            PackAmount_T = 0
            PackWeight_M = 0.0
            PackWeight_P = 0.0
            PackWeight_T = 0.0
            If ds.Tables(0).Rows.Count = dvTotalCargo.Count Then
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    If IsDBNull(ds.Tables(0).Rows(i)("PackAmount")) Then
                        ds.Tables(0).Rows(i)("PackAmount") = 0
                    End If
                    If IsDBNull(ds.Tables(0).Rows(i)("PackWeight")) Then
                        ds.Tables(0).Rows(i)("PackWeight") = 0.0
                    End If
                    If Not IsDBNull(dvTotalCargo.Item(i)("PackAmount")) Then
                        ds.Tables(0).Rows(i)("SubtotalAmount") = dvTotalCargo.Item(i)("PackAmount")
                    Else
                        ds.Tables(0).Rows(i)("SubtotalAmount") = 0
                    End If
                    If Not IsDBNull(dvTotalCargo.Item(i)("PackWeight")) Then
                        ds.Tables(0).Rows(i)("SubtotalWeight") = dvTotalCargo.Item(i)("PackWeight")
                    Else
                        ds.Tables(0).Rows(i)("SubtotalWeight") = 0.0
                    End If
                    ds.Tables(0).Rows(i)("PackAmount_P") = ds.Tables(0).Rows(i)("SubtotalAmount") - ds.Tables(0).Rows(i)("PackAmount")
                    ds.Tables(0).Rows(i)("PackWeight_P") = ds.Tables(0).Rows(i)("SubtotalWeight") - ds.Tables(0).Rows(i)("PackWeight")
                    PackAmount_M = PackAmount_M + ds.Tables(0).Rows(i)("PackAmount")
                    PackAmount_P = PackAmount_P + ds.Tables(0).Rows(i)("PackAmount_P")
                    PackAmount_T = PackAmount_T + ds.Tables(0).Rows(i)("SubtotalAmount")
                    PackWeight_M = PackWeight_M + ds.Tables(0).Rows(i)("PackWeight")
                    PackWeight_P = PackWeight_P + ds.Tables(0).Rows(i)("PackWeight_P")
                    PackWeight_T = PackWeight_T + ds.Tables(0).Rows(i)("SubtotalWeight")
                Next
            Else
                If ds.Tables(0).Rows.Count < dvTotalCargo.Count Then
                    'Suffix = New Short(dvTotalCargo.Count - ds.Tables(0).Rows.Count) {}
                    For i = 0 To dvTotalCargo.Count - 1
                        For j = 0 To ds.Tables(0).Rows.Count - 1    '查找
                            If dvTotalCargo.Item(i)("code_goods") = ds.Tables(0).Rows(j)("code_goods") Then
                                Exit For '找到跳出
                            End If
                        Next
                        If j <= ds.Tables(0).Rows.Count - 1 Then
                            If IsDBNull(ds.Tables(0).Rows(j)("PackAmount")) Then
                                ds.Tables(0).Rows(j)("PackAmount") = 0
                            End If
                            If IsDBNull(ds.Tables(0).Rows(j)("PackWeight")) Then
                                ds.Tables(0).Rows(j)("PackWeight") = 0.0
                            End If
                            If Not IsDBNull(dvTotalCargo.Item(i)("PackAmount")) Then
                                ds.Tables(0).Rows(j)("SubtotalAmount") = dvTotalCargo.Item(i)("PackAmount")
                            Else
                                ds.Tables(0).Rows(j)("SubtotalAmount") = 0
                            End If
                            If Not IsDBNull(dvTotalCargo.Item(i)("PackWeight")) Then
                                ds.Tables(0).Rows(j)("SubtotalWeight") = dvTotalCargo.Item(i)("PackWeight")
                            Else
                                ds.Tables(0).Rows(j)("SubtotalWeight") = 0.0
                            End If

                            ds.Tables(0).Rows(j)("PackAmount_P") = ds.Tables(0).Rows(j)("SubtotalAmount") - ds.Tables(0).Rows(j)("PackAmount")
                            ds.Tables(0).Rows(j)("PackWeight_P") = ds.Tables(0).Rows(j)("SubtotalWeight") - ds.Tables(0).Rows(j)("PackWeight")
                        Else
                            If j >= ds.Tables(0).Rows.Count Then    '增加一条
                                newDataRow = ds.Tables(0).NewRow()
                                newDataRow.Item("Goods") = dvTotalCargo.Item(i)("Goods")
                                newDataRow.Item("PackAmount") = 0
                                If Not IsDBNull(dvTotalCargo.Item(i)("PackAmount")) Then
                                    newDataRow.Item("SubtotalAmount") = dvTotalCargo.Item(i)("PackAmount")
                                Else
                                    newDataRow.Item("SubtotalAmount") = 0
                                End If
                                newDataRow.Item("PackAmount_P") = newDataRow.Item("SubtotalAmount")
                                newDataRow.Item("PackWeight") = 0.0
                                If Not IsDBNull(dvTotalCargo.Item(i)("PackWeight")) Then
                                    newDataRow.Item("SubtotalWeight") = dvTotalCargo.Item(i)("PackWeight")
                                Else
                                    newDataRow.Item("SubtotalWeight") = 0.0
                                End If
                                newDataRow.Item("PackWeight_P") = newDataRow.Item("SubtotalWeight")
                                ds.Tables(0).Rows.Add(newDataRow)
                            End If
                        End If
                        PackAmount_M = PackAmount_M + ds.Tables(0).Rows(j)("PackAmount")
                        PackAmount_P = PackAmount_P + ds.Tables(0).Rows(j)("PackAmount_P")
                        PackAmount_T = PackAmount_T + ds.Tables(0).Rows(j)("SubtotalAmount")
                        PackWeight_M = PackWeight_M + ds.Tables(0).Rows(j)("PackWeight")
                        PackWeight_P = PackWeight_P + ds.Tables(0).Rows(j)("PackWeight_P")
                        PackWeight_T = PackWeight_T + ds.Tables(0).Rows(j)("SubtotalWeight")
                    Next
                End If
            End If

            newDataRow = ds.Tables(0).NewRow()
            newDataRow.Item("Goods") = "本日小计"
            newDataRow.Item("PackAmount") = PackAmount_M
            newDataRow.Item("PackAmount_P") = PackAmount_P
            newDataRow.Item("SubtotalAmount") = PackAmount_T
            newDataRow.Item("PackWeight") = PackWeight_M
            newDataRow.Item("PackWeight_P") = PackWeight_P
            newDataRow.Item("SubtotalWeight") = PackWeight_T
            ds.Tables(0).Rows.Add(newDataRow)

            newDataRow = ds.Tables(0).NewRow()
            newDataRow.Item("Goods") = "前日累计"
            If dvSumCargo.Count = 1 Then
                If dvSumPM.Count = 1 Then
                    If Not IsDBNull(dvSumPM.Item(0)("PackAmount")) Then
                        newDataRow.Item("PackAmount") = dvSumPM.Item(0)("PackAmount")
                    Else
                        newDataRow.Item("PackAmount") = 0
                    End If
                    If Not IsDBNull(dvSumPM.Item(0)("PackWeight")) Then
                        newDataRow.Item("PackWeight") = dvSumPM.Item(0)("PackWeight")
                    Else
                        newDataRow.Item("PackWeight") = 0.0
                    End If
                Else
                    newDataRow.Item("PackAmount") = 0
                    newDataRow.Item("PackWeight") = 0.0
                End If

                If Not IsDBNull(dvSumCargo.Item(0)("PackAmount")) Then
                    newDataRow.Item("SubtotalAmount") = dvSumCargo.Item(0)("PackAmount")
                Else
                    newDataRow.Item("SubtotalAmount") = 0
                End If
                If Not IsDBNull(dvSumCargo.Item(0)("PackWeight")) Then
                    newDataRow.Item("SubtotalWeight") = dvSumCargo.Item(0)("PackWeight")
                Else
                    newDataRow.Item("SubtotalWeight") = 0.0
                End If
                newDataRow.Item("PackAmount_P") = newDataRow.Item("SubtotalAmount") - newDataRow.Item("PackAmount")
                newDataRow.Item("PackWeight_P") = newDataRow.Item("SubtotalWeight") - newDataRow.Item("PackWeight")
            Else
                newDataRow.Item("PackAmount") = 0
                newDataRow.Item("PackWeight") = 0.0
                newDataRow.Item("PackAmount_P") = 0
                newDataRow.Item("PackWeight_P") = 0.0
                newDataRow.Item("SubtotalAmount") = 0
                newDataRow.Item("SubtotalWeight") = 0.0
            End If
            ds.Tables(0).Rows.Add(newDataRow)

            newDataRow = ds.Tables(0).NewRow()
            newDataRow.Item("Goods") = "总计"
            newDataRow.Item("PackAmount") = PackAmount_M + ds.Tables(0).Rows(i + 1)("PackAmount")   'i 是本日小计的位置，i+1 就是前日累计的位置
            newDataRow.Item("PackAmount_P") = PackAmount_P + ds.Tables(0).Rows(i + 1)("PackAmount_P")
            newDataRow.Item("SubtotalAmount") = PackAmount_T + ds.Tables(0).Rows(i + 1)("SubtotalAmount")
            newDataRow.Item("PackWeight") = PackWeight_M + ds.Tables(0).Rows(i + 1)("PackWeight")
            newDataRow.Item("PackWeight_P") = PackWeight_P + ds.Tables(0).Rows(i + 1)("PackWeight_P")
            newDataRow.Item("SubtotalWeight") = PackWeight_T + ds.Tables(0).Rows(i + 1)("SubtotalWeight")
            ds.Tables(0).Rows.Add(newDataRow)


            Me.C1DBG.DataSource = ds.Tables(0).DefaultView
            Me.C1DBG.Columns("Goods").Caption = "货名"
            Me.C1DBG.Columns("PackAmount").Caption = "机器灌包件数"
            Me.C1DBG.Columns("PackWeight").Caption = "机器灌包吨重"
            Me.C1DBG.Columns("PackAmount_P").Caption = "人力灌包件数"
            Me.C1DBG.Columns("PackWeight_P").Caption = "人力灌包吨重"
            Me.C1DBG.Columns("SubtotalAmount").Caption = "件数小计"
            Me.C1DBG.Columns("SubtotalWeight").Caption = "吨重小计"
            Me.C1DBG.Splits(0).DisplayColumns.Item("code_goods").Visible = False

            Me.C1DBG.ColumnFooters = True
            Me.C1DBG.Columns("Goods").FooterText = "备注"
            Dim footer1, footer2, footer3, footer4, footer5, footer6 As String
            footer1 = "机器抽重  袋"
            footer2 = "合格率  %"
            footer3 = "均重  千克"
            footer4 = "人力抽重  袋"
            footer5 = "合格率  %"
            footer6 = "均重  千克"

            If dvBeizhu.Count = 2 Then
                If Not IsDBNull(dvBeizhu.Item(0)(1)) Then
                    footer1 = "机器抽重" & dvBeizhu.Item(0)(1) & "袋"
                End If
                If Not IsDBNull(dvBeizhu.Item(0)(2)) Then
                    footer2 = "合格率" & dvBeizhu.Item(0)(2) & "%"
                End If
                If Not IsDBNull(dvBeizhu.Item(0)(3)) Then
                    footer3 = "均重" & dvBeizhu.Item(0)(3) & "千克"
                End If
                If Not IsDBNull(dvBeizhu.Item(1)(1)) Then
                    footer4 = "人力抽重" & dvBeizhu.Item(1)(1) & "袋"
                End If
                If Not IsDBNull(dvBeizhu.Item(1)(2)) Then
                    footer5 = "合格率" & dvBeizhu.Item(1)(2) & "%"
                End If
                If Not IsDBNull(dvBeizhu.Item(1)(3)) Then
                    footer6 = "均重" & dvBeizhu.Item(1)(3) & "千克"
                End If
            ElseIf dvBeizhu.Count = 1 Then
                If dvBeizhu.Item(0)(0) = "2 " Then
                    If Not IsDBNull(dvBeizhu.Item(0)(1)) Then
                        footer1 = "机器抽重" & dvBeizhu.Item(0)(1) & "袋"
                    End If
                    If Not IsDBNull(dvBeizhu.Item(0)(2)) Then
                        footer2 = "合格率" & dvBeizhu.Item(0)(2) & "%"
                    End If
                    If Not IsDBNull(dvBeizhu.Item(0)(3)) Then
                        footer3 = "均重" & dvBeizhu.Item(0)(3) & "千克"
                    End If
                ElseIf dvBeizhu.Item(0)(0) = "1 " Then
                    If Not IsDBNull(dvBeizhu.Item(0)(1)) Then
                        footer4 = "人力抽重" & dvBeizhu.Item(0)(1) & "袋"
                    End If
                    If Not IsDBNull(dvBeizhu.Item(0)(2)) Then
                        footer5 = "合格率" & dvBeizhu.Item(0)(2) & "%"
                    End If
                    If Not IsDBNull(dvBeizhu.Item(0)(3)) Then
                        footer6 = "均重" & dvBeizhu.Item(0)(3) & "千克"
                    End If
                End If
            End If

            Me.C1DBG.Columns("PackAmount").FooterText = footer1
            Me.C1DBG.Columns("PackWeight").FooterText = footer2
            Me.C1DBG.Columns("PackAmount_P").FooterText = footer3
            Me.C1DBG.Columns("PackWeight_P").FooterText = footer4
            Me.C1DBG.Columns("SubtotalAmount").FooterText = footer5
            Me.C1DBG.Columns("SubtotalWeight").FooterText = footer6

            Me.C1DBG.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaption()
        Dim sqla As New SqlClient.SqlDataAdapter()
        Dim sqlc As New SqlClient.SqlCommand()
        Dim dset As New DataSet()
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

    Private Sub GetSheetExcel()
        Dim PathStr As String
        Dim FilePath As String
        Dim Row As Integer
        Dim Col As Integer
        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        Try
            FilePath = PathStr + "ReportCopy.xls"
            FileCopy(PathStr & "Report_Pan.xls", FilePath)

            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)
            xlSheet = CType(xlBook.Worksheets(6), Excel.Worksheet)
            xlSheet.Select(6)
            xlApp.DisplayAlerts = False
            xlSheet.Application.Visible = True

            xlSheet.Cells(3, 2) = dwShip.Item(0)("CHI_VESSEL")
            If Not IsDBNull(dwship.Item(0)("BerthNo")) Then
                xlSheet.Cells(3, 4) = dwShip.Item(0)("BerthNo")
            End If
            Row = Me.C1DBG.Row
            Me.C1DBG.Row += 1
            While Row <> Me.C1DBG.Row
                Row = Me.C1DBG.Row
                Me.C1DBG.Row += 1
            End While
            Row += 1
            If Row > 7 Then
                MessageBox.Show("货名超过四种，有错误吧", "")
                Exit Sub
            End If
            Dim i As Short
            For i = 3 To 1 Step -1
                xlSheet.Cells(15 + 2 * i, 2) = Me.C1DBG.Columns("PackAmount").CellText(Me.C1DBG.Row)
                xlSheet.Cells(16 + 2 * i, 3) = Me.C1DBG.Columns("PackWeight").CellText(Me.C1DBG.Row)
                xlSheet.Cells(15 + 2 * i, 4) = Me.C1DBG.Columns("PackAmount_P").CellText(Me.C1DBG.Row)
                xlSheet.Cells(16 + 2 * i, 5) = Me.C1DBG.Columns("PackWeight_P").CellText(Me.C1DBG.Row)
                xlSheet.Cells(15 + 2 * i, 8) = Me.C1DBG.Columns("SubtotalAmount").CellText(Me.C1DBG.Row)
                xlSheet.Cells(16 + 2 * i, 9) = Me.C1DBG.Columns("SubtotalWeight").CellText(Me.C1DBG.Row)
                Me.C1DBG.Row -= 1
            Next
            For i = 1 To Row - 3
                xlSheet.Cells(2 * i + 7, 2) = Me.C1DBG.Columns("PackAmount").CellText(i - 1)
                xlSheet.Cells(2 * i + 8, 3) = Me.C1DBG.Columns("PackWeight").CellText(i - 1)
                xlSheet.Cells(2 * i + 7, 4) = Me.C1DBG.Columns("PackAmount_P").CellText(i - 1)
                xlSheet.Cells(2 * i + 8, 5) = Me.C1DBG.Columns("PackWeight_P").CellText(i - 1)
                xlSheet.Cells(2 * i + 7, 8) = Me.C1DBG.Columns("SubtotalAmount").CellText(i - 1)
                xlSheet.Cells(2 * i + 8, 9) = Me.C1DBG.Columns("SubtotalWeight").CellText(i - 1)
                xlSheet.Cells(2 * i + 7, 1) = Me.C1DBG.Columns("Goods").CellText(i - 1)
            Next
            Dim timeT As Date
            timeT = FrmDeal.TimeBegin
            xlSheet.Cells(3, 6) = timeT.Year & "年"
            xlSheet.Cells(3, 7) = timeT.Month & "月"
            xlSheet.Cells(3, 8) = timeT.Day & "日"
            xlSheet.Cells(3, 9) = timeT.Hour & "时"
            timeT = FrmDeal.TimeEnd
            xlSheet.Cells(4, 6) = timeT.Year & "年"
            xlSheet.Cells(4, 7) = timeT.Month & "月"
            xlSheet.Cells(4, 8) = timeT.Day & "日"
            xlSheet.Cells(4, 9) = timeT.Hour & "时"

            If dvBeizhu.Count = 2 Then
                xlSheet.Cells(23, 4) = dvBeizhu.Item(0)(1)
                xlSheet.Cells(23, 6) = dvBeizhu.Item(0)(2)
                xlSheet.Cells(23, 9) = dvBeizhu.Item(0)(3)
                xlSheet.Cells(24, 4) = dvBeizhu.Item(1)(1)
                xlSheet.Cells(24, 6) = dvBeizhu.Item(1)(2)
                xlSheet.Cells(24, 9) = dvBeizhu.Item(1)(3)
            ElseIf dvBeizhu.Count = 1 Then
                If dvBeizhu.Item(0)(0) = "2 " Then
                    xlSheet.Cells(23, 4) = dvBeizhu.Item(0)(1)
                    xlSheet.Cells(23, 6) = dvBeizhu.Item(0)(2)
                    xlSheet.Cells(23, 9) = dvBeizhu.Item(0)(3)
                ElseIf dvBeizhu.Item(0)(0) = "1 " Then
                    xlSheet.Cells(24, 4) = dvBeizhu.Item(0)(1)
                    xlSheet.Cells(24, 6) = dvBeizhu.Item(0)(2)
                    xlSheet.Cells(24, 9) = dvBeizhu.Item(0)(3)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub SetColumnSum(ByVal sql As String)
        On Error GoTo Err
        Dim sqla As New SqlClient.SqlDataAdapter()
        Dim sqlc As New SqlClient.SqlCommand()
        Dim dset As New DataSet()
        Dim dset2 As New DataSet()
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
        Me.C1DBG.Columns.Item(ColNum).FooterText = "合计 共" & ds.Tables(0).Rows.Count & "条"
        Do While i < Me.C1DBG.Columns.Count
            j = 0
            For j = 0 To dset.Tables(0).Rows.Count - 1

                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBG.Columns.Item(i).DataField.ToString)) _
                    And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then

                    num = 0
                    For m = 0 To ds.Tables(0).Rows.Count - 1
                        num = num + ds.Tables(0).Rows(m)(i)
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

    Private Sub mnuFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFind.Click
        Dim FrmFind As New FrmFind()
        FrmFind.ShowDialog()
        If Flag = 0 Then
            SelectStr = ""
            Call myDataGrid(SelectStr, " (" & Sql_Find & ")  " & FirmStr)  '可能要修改
            SqlStr = " (" & Sql_Find & ")  " & FirmStr '可能要修改
        ElseIf Flag = 2 Then
            SelectStr = ""
            Call myDataGrid(SelectStr, DynaStr & FirmStr)  '可能要修改
            SqlStr = DynaStr & FirmStr '可能要修改
        End If
    End Sub

    Private Sub mnuQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuery.Click
        'If ds.Tables(0).Rows.Count > 0 Then
        '    Dim FrmQuery As New FrmCargoPackSheet_Query()     '***********要修改
        '    ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
        '    FrmQuery.ShowDialog()
        'End If
    End Sub

    Private Sub mnuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdd.Click
        FrmDeal.ShowDialog()
        Try
            If FrmDeal.Mark = True Then
                Call ReportDataGrid(FrmDeal.CodeCompany, FrmDeal.TimeBegin, FrmDeal.TimeEnd)
            Else
                SelectStr = ""
                myDataGrid(SelectStr, SqlStr)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        If ds.Tables(0).Rows.Count > 0 Then
            Dim FrmEdit As New FrmCargoPackSheet_Edit()    '***********要修改
            Dim Row As Integer

            ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
            Row = Me.C1DBG.Row
            FrmEdit.ShowDialog()
            Try
                Call myDataGrid(SelectStr, SqlStr)
                Me.C1DBG.Row = Row

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        If ds.Tables(0).Rows.Count > 0 Then
            Dim FrmDelete As New FrmCargoPackSheet_Delete()     '***********要修改

            ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
            FrmDelete.ShowDialog()
            Try
                Call myDataGrid(SelectStr, SqlStr)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
        'Call PrintExcel()
        If FrmDeal.Mark = False Then
            Call Me.mnuAdd_Click(sender, e)
        End If
        If FrmDeal.Mark = True Then
            Call Me.GetSheetExcel()
        Else
        End If
    End Sub

    Private Sub PrintExcel() '打印到Excel        
        Dim Row As Integer
        Dim Col As Integer
        Try
            Call MakeExcel()
            Row = ds.Tables(0).Rows.Count + 4
            Col = Me.C1DBG.Columns.Count - ColNum
            '**************画边框
            For Row = 2 To ds.Tables(0).Rows.Count + 4 '画列
                xlSheet.Range(xlSheet.Cells(Row, 1), xlSheet.Cells(Row, C1DBG.Columns.Count - ColNum)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 7
            Next Row
            For Col = 1 To C1DBG.Columns.Count - ColNum + 1 '画行
                xlSheet.Range(xlSheet.Cells(3, Col), xlSheet.Cells(ds.Tables(0).Rows.Count + 4, Col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7
            Next Col
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub mnuExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExport.Click
        'Call ExportExcel()
        If FrmDeal.Mark = False Then
            Call Me.mnuAdd_Click(sender, e)
        End If
        If FrmDeal.Mark = True Then
            Call Me.GetSheetExcel()
        Else
        End If
    End Sub

    Private Sub ExportExcel() '导出Excel        
        Call MakeExcel()
    End Sub

    Private Sub MakeExcel()
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

            xlSheet.Cells(1, 1) = Me.Text() '标题

            For Col = ColNum To Me.C1DBG.Columns.Count - 1 '列标题
                xlSheet.Cells(3, Col - ColNum + 1) = Me.C1DBG.Columns(Col).Caption

            Next Col
            Me.C1DBG.MoveFirst()
            For Row = 0 To ds.Tables(0).Rows.Count - 1 '数据
                For Col = ColNum To Me.C1DBG.Columns.Count - 1
                    xlSheet.Cells(Row + 4, Col - ColNum + 1) = Me.C1DBG.Columns(Col).Text.ToString      'ds.Tables(0).Rows(Row)(Col)
                Next Col
                Me.C1DBG.MoveNext()
            Next Row
            If Me.C1DBG.ColumnFooters = True Then '合计项
                For Col = ColNum To Me.C1DBG.Columns.Count - 1
                    xlSheet.Cells(ds.Tables(0).Rows.Count + 4, Col - ColNum + 1) = Me.C1DBG.Columns(Col).FooterText
                Next Col
            End If
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try

    End Sub

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        TBar = 1
        Mnu = 1
        Me.Close()
    End Sub

    Private Sub ToolBar_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar.ButtonClick
        Select Case Me.ToolBar.Buttons.IndexOf(e.Button)
            Case 0
                mnuFind_Click(sender, e)
            Case 1
                Call mnuQuery_Click(sender, e)
            Case 2

            Case 3
                Call mnuAdd_Click(sender, e)
            Case 4
                Call mnuEdit_Click(sender, e)
            Case 5
                Call mnuDelete_Click(sender, e)
            Case 6

            Case 7
                Call mnuPrint_Click(sender, e)
            Case 8
                Call mnuExport_Click(sender, e)
            Case 9

            Case 10
                Call mnuQuit_Click(sender, e)
        End Select
    End Sub

    Private Sub preview(ByVal Func As String) '***************权限设计
        Dim sqlstr As String
        Dim Previewdv As DataView
        Dim Previewds As New DataSet()
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
            Else                                     '删除 按钮不可见
                Me.ToolBar.Buttons.Item(5).Enabled = False
                mnuDelete.Enabled = False
            End If
        End If
    End Sub

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        TBar = 1
        Mnu = 1
    End Sub

    Private Sub C1DBG_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1DBG.DoubleClick
        Call mnuQuery_Click(sender, e)
    End Sub

    Private Sub SetColumnWidth()
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

    Private Sub btResure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResure.Click
        SqlStrShip = "where (((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','4')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) and Voyage like '" & Trim(txtVoyage.Text) & "%' and (ENG_VESSEL Like '" & Trim(txtShipName.Text) & "%' OR CHI_VESSEL like '" & Trim(txtShipName.Text) & "%' )) "
        '可能要修改
        'G_ShipName = Trim(txtShipName.Text)
        'G_Voyage = Trim(txtVoyage.Text)
        Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '可能要修改
        If dsShip.Tables(0).Rows.Count > 0 Then
            C1DBGV_DoubleClick(sender, e)
        End If
    End Sub

    Private Sub txtShipName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtShipName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtVoyage.Focus()
        End If
    End Sub

    Private Sub txtVoyage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVoyage.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btResure.Focus()
        End If
    End Sub
End Class
