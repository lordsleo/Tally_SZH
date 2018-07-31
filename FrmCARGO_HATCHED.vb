Imports TALLY.DBControl
Imports Microsoft.VisualBasic

Public Class FrmCARGO_HATCHED
    Inherits System.Windows.Forms.Form
    Dim dsShip As New DataSet   '船舶数据集
    Dim SqlStrShip As String  '船舶条件语句
    Dim FirmShip As String
    Dim SortShip As String
    Dim inoutstr As String
    Dim dw As New DataView

    Dim ds As New DataSet
    Dim SqlStr As String  '条件语句
    Dim SelectStr As String
    Dim DynaStr As String '可变的条件设计
    Dim FirmStr As String '不变的条件设计
    Dim ColNum As Integer '不显示的列数
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
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents tbbtndo As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnPrint As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnExport As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuit As System.Windows.Forms.ToolBarButton
    Friend WithEvents btResure As System.Windows.Forms.Button
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCARGO_HATCHED))
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.MainMenu = New System.Windows.Forms.MainMenu
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
        Me.btResure = New System.Windows.Forms.Button
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolBarV = New System.Windows.Forms.ToolBar
        Me.S1 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnOK = New System.Windows.Forms.ToolBarButton
        Me.S2 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSearch = New System.Windows.Forms.ToolBarButton
        Me.S3 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSort = New System.Windows.Forms.ToolBarButton
        Me.S4 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnEng = New System.Windows.Forms.ToolBarButton
        Me.C1DBGV = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.GB = New System.Windows.Forms.GroupBox
        Me.Label = New System.Windows.Forms.Label
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.ToolBar = New System.Windows.Forms.ToolBar
        Me.tbbtndo = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep2 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnPrint = New System.Windows.Forms.ToolBarButton
        Me.tbbtnExport = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep3 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuit = New System.Windows.Forms.ToolBarButton
        Me.GBV.SuspendLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB.SuspendLayout()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList
        '
        Me.ImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
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
        Me.GBV.Size = New System.Drawing.Size(174, 399)
        Me.GBV.TabIndex = 4
        Me.GBV.TabStop = False
        '
        'btResure
        '
        Me.btResure.Location = New System.Drawing.Point(127, 334)
        Me.btResure.Name = "btResure"
        Me.btResure.Size = New System.Drawing.Size(42, 22)
        Me.btResure.TabIndex = 16
        Me.btResure.Text = "查询"
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(37, 334)
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(88, 21)
        Me.txtVoyage.TabIndex = 15
        Me.txtVoyage.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 338)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 14)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "航次"
        '
        'txtShipName
        '
        Me.txtShipName.Location = New System.Drawing.Point(37, 310)
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.Size = New System.Drawing.Size(132, 21)
        Me.txtShipName.TabIndex = 13
        Me.txtShipName.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 312)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "船名"
        '
        'ToolBarV
        '
        Me.ToolBarV.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.S1, Me.tbbtnOK, Me.S2, Me.tbbtnSearch, Me.S3, Me.tbbtnSort, Me.S4, Me.tbbtnEng})
        Me.ToolBarV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBarV.DropDownArrows = True
        Me.ToolBarV.ImageList = Me.ImageList
        Me.ToolBarV.Location = New System.Drawing.Point(3, 355)
        Me.ToolBarV.Name = "ToolBarV"
        Me.ToolBarV.ShowToolTips = True
        Me.ToolBarV.Size = New System.Drawing.Size(168, 41)
        Me.ToolBarV.TabIndex = 1
        '
        'S1
        '
        Me.S1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
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
        'S4
        '
        Me.S4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnEng
        '
        Me.tbbtnEng.ImageIndex = 11
        Me.tbbtnEng.Text = "英文"
        '
        'C1DBGV
        '
        Me.C1DBGV.AllowUpdate = False
        Me.C1DBGV.CaptionHeight = 18
        Me.C1DBGV.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1DBGV.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGV.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBGV.Location = New System.Drawing.Point(3, 17)
        Me.C1DBGV.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBGV.Name = "C1DBGV"
        Me.C1DBGV.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGV.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGV.PreviewInfo.ZoomFactor = 75
        Me.C1DBGV.RecordSelectorWidth = 17
        Me.C1DBGV.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1DBGV.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBGV.RowHeight = 16
        Me.C1DBGV.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBGV.Size = New System.Drawing.Size(168, 291)
        Me.C1DBGV.TabIndex = 0
        Me.C1DBGV.Text = "C1TrueDBGrid1"
        Me.C1DBGV.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle12{}OddRow{}RecordSelector{AlignImage:Center;}Style13{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style14{}Style15{}Style9{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><ClientRect>0, 0, 164, 287</ClientRect><BorderSide>0</BorderSide><CaptionSt" & _
        "yle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><E" & _
        "venRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me" & _
        "=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Grou" & _
        "p"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyl" & _
        "e parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style" & _
        "4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""Rec" & _
        "ordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Styl" & _
        "e parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedS" & _
        "tyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Styl" & _
        "e parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style p" & _
        "arent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style pa" & _
        "rent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style pa" & _
        "rent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=" & _
        """Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style p" & _
        "arent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits" & _
        ">1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth><" & _
        "ClientArea>0, 0, 164, 287</ClientArea><PrintPageHeaderStyle parent="""" me=""Style1" & _
        "4"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'GB
        '
        Me.GB.Controls.Add(Me.Label)
        Me.GB.Controls.Add(Me.C1DBG)
        Me.GB.Controls.Add(Me.ToolBar)
        Me.GB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB.Location = New System.Drawing.Point(174, 0)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(540, 399)
        Me.GB.TabIndex = 5
        Me.GB.TabStop = False
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.SystemColors.Control
        Me.Label.Location = New System.Drawing.Point(6, 58)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(530, 32)
        Me.Label.TabIndex = 11
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(3, 92)
        Me.C1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.RecordSelectorWidth = 17
        Me.C1DBG.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1DBG.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG.Size = New System.Drawing.Size(532, 304)
        Me.C1DBG.TabIndex = 10
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle12{}OddRow{}RecordSelector{AlignImage:Center;}Style13{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style14{}Style15{}Style9{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" AllowRowSizing=""None"" CaptionH" & _
        "eight=""18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""Dotted" & _
        "CellBorder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1""" & _
        " HorizontalScrollGroup=""1""><ClientRect>0, 0, 528, 300</ClientRect><BorderSide>0<" & _
        "/BorderSide><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Ed" & _
        "itor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle" & _
        " parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><G" & _
        "roupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style" & _
        "2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle paren" & _
        "t=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSel" & _
        "ectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selecte" & _
        "d"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.Merg" & _
        "eView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal" & _
        """ me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" m" & _
        "e=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=" & _
        """Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Hig" & _
        "hlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""Od" & _
        "dRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=" & _
        """FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</" & _
        "vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17" & _
        "</DefaultRecSelWidth><ClientArea>0, 0, 528, 300</ClientArea><PrintPageHeaderStyl" & _
        "e parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob" & _
        ">"
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtndo, Me.tbbtnSep2, Me.tbbtnPrint, Me.tbbtnExport, Me.tbbtnSep3, Me.tbbtnQuit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.Enabled = False
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(3, 17)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(534, 41)
        Me.ToolBar.TabIndex = 9
        '
        'tbbtndo
        '
        Me.tbbtndo.ImageIndex = 12
        Me.tbbtndo.Text = "处理"
        '
        'tbbtnSep2
        '
        Me.tbbtnSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnPrint
        '
        Me.tbbtnPrint.ImageIndex = 5
        Me.tbbtnPrint.Text = "打印"
        Me.tbbtnPrint.ToolTipText = "打印"
        '
        'tbbtnExport
        '
        Me.tbbtnExport.ImageIndex = 6
        Me.tbbtnExport.Text = "导出"
        Me.tbbtnExport.ToolTipText = "导出Excel"
        '
        'tbbtnSep3
        '
        Me.tbbtnSep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnQuit
        '
        Me.tbbtnQuit.ImageIndex = 7
        Me.tbbtnQuit.Text = "退出"
        Me.tbbtnQuit.ToolTipText = "退出"
        '
        'FrmCARGO_HATCHED
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(714, 399)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.GBV)
        Me.Menu = Me.MainMenu
        Me.Name = "FrmCARGO_HATCHED"
        Me.Text = "货物分舱单"
        Me.GBV.ResumeLayout(False)
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB.ResumeLayout(False)
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCARGO_HATCHED_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        Me.Text = Me.Text & "_" & G_DeptName

        SortShip = " Order by Ship_Statu,Dept_Code,id desc " '默认的排序

        FirmShip = "where DEPT_CODE LIKE '" & G_DeptCode & "%' and code_goods<>'2' " '船舶不变的条件设计
        SqlStrShip = "where (DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('2','3') and code_goods<>'2') " 'OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) "
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
                SqlStrShip = "where (DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('2','3') and code_goods<>'2') " '船舶可变的条件设计

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
                    SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','4')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) "
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
        FirmStr = " and Ship_ID=" & Ship_ID & " Order by ID " '设计初始条件  在检索后不改变的条件  '***************要修改 或 2>1
        DynaStr = " 2>1 " '设计其它初始条件    在检索后不需要的条件 ***************要修改 或 其它条件
        SelectStr = " " ' " Top 20 "
        SqlStr = " (" & DynaStr & ")  " & FirmStr

        Me.ToolBar.Enabled = True
        Me.mnuAdd.Enabled = True
        Me.mnuDelete.Enabled = True
        Me.mnuEdit.Enabled = True
        Me.mnuExport.Enabled = True
        Me.mnuFind.Enabled = True
        Me.mnuPrint.Enabled = True
        Me.mnuQuery.Enabled = True
        Call preview("WL4_1") '*****************权限设计 '*************要修改模块号
        C1DBG.Visible = False

        'Call myDataGrid(SelectStr, SqlStr)
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色
        Exit Sub
Err:
        Resume Next
    End Sub
    Private Sub myDataGrid(ByVal SelStr As String, ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Dim j As Integer

        Try

            If mark = "1" Then

                C1DBG.Visible = True

                C1DBG.DataSource = DS_DO.Tables(1).DefaultView
                C1DBG.Refresh()
                For i = 7 To 38
                    Me.C1DBG.Splits(0).DisplayColumns.Item(i).Visible = False
                Next
                For i = 7 To DS_DO.Tables(0).Rows.Count - 1 + 7
                    j = 2 * i - 7
                    Me.C1DBG.Splits(0).DisplayColumns.Item(j).Visible = True
                    Me.C1DBG.Splits(0).DisplayColumns.Item(j + 1).Visible = True
                Next

                Me.C1DBG.Columns.Item("blno").Caption = "提单号"
                Me.C1DBG.Columns.Item("mark").Caption = "标志"
                Me.C1DBG.Columns.Item("goods_cha").Caption = "货名"
                Me.C1DBG.Columns.Item("amount").Caption = "件数"
                Me.C1DBG.Columns.Item("code_pack").Caption = "包装"
                Me.C1DBG.Columns.Item("weight").Caption = "重量"
                Me.C1DBG.Columns.Item("size_con").Caption = "尺寸"

                Me.C1DBG.Columns.Item("h1").Caption = "一舱件"     '7
                Me.C1DBG.Columns.Item("p1").Caption = "一舱位"     '8
                Me.C1DBG.Columns.Item("h2").Caption = "二舱件"     '9
                Me.C1DBG.Columns.Item("p2").Caption = "二舱位"     '10
                Me.C1DBG.Columns.Item("h3").Caption = "三舱件"
                Me.C1DBG.Columns.Item("p3").Caption = "三舱位"
                Me.C1DBG.Columns.Item("h4").Caption = "四舱件"
                Me.C1DBG.Columns.Item("p4").Caption = "四舱位"
                Me.C1DBG.Columns.Item("h5").Caption = "五舱件"
                Me.C1DBG.Columns.Item("p5").Caption = "五舱位"
                Me.C1DBG.Columns.Item("h6").Caption = "六舱件"
                Me.C1DBG.Columns.Item("p6").Caption = "六舱位"
                Me.C1DBG.Columns.Item("h7").Caption = "七舱件"
                Me.C1DBG.Columns.Item("p7").Caption = "七舱位"
                Me.C1DBG.Columns.Item("h8").Caption = "八舱件"
                Me.C1DBG.Columns.Item("p8").Caption = "八舱位"
                Me.C1DBG.Columns.Item("h9").Caption = "九舱件"
                Me.C1DBG.Columns.Item("p9").Caption = "九舱位"
                Me.C1DBG.Columns.Item("h10").Caption = "十舱件"
                Me.C1DBG.Columns.Item("p10").Caption = "十舱位"
                Me.C1DBG.Columns.Item("h11").Caption = "十一舱件"
                Me.C1DBG.Columns.Item("p11").Caption = "十一舱位"
                Me.C1DBG.Columns.Item("h12").Caption = "十二舱件"
                Me.C1DBG.Columns.Item("p12").Caption = "十二舱位"
                Me.C1DBG.Columns.Item("h13").Caption = "十三舱件"
                Me.C1DBG.Columns.Item("p13").Caption = "十三舱位"
                Me.C1DBG.Columns.Item("h14").Caption = "十四舱件"
                Me.C1DBG.Columns.Item("p14").Caption = "十四舱位"
                Me.C1DBG.Columns.Item("h15").Caption = "十五舱件"
                Me.C1DBG.Columns.Item("p15").Caption = "十五舱位"
                Me.C1DBG.Columns.Item("h16").Caption = "十六舱件"
                Me.C1DBG.Columns.Item("p16").Caption = "十六舱位"

                Call SetColumnWidth()
                Me.C1DBG.Splits(0).DisplayColumns.Item("weight").Width = 80
                'If DS_DO.Tables(1).Rows.Count > 0 Then
                '    Call SetColumnSum(Sql) '设计合计列
                'End If
            End If
            Me.C1DBG.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaption()
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

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBG.Columns.Item(i).DataField.ToString)) Then
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

    Private Sub SetColumnWidth()
        Dim j As Integer
        For j = 0 To Me.C1DBG.Columns.Count - 1
            Me.C1DBG.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.C1DBG.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width < 40 Then
                Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width = 40
            Else
                If Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If

        Next
    End Sub

    Private Sub SetColumnSum(ByVal sql As String)
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

        i = 3 '3列不显示
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBG.Columns.Item(3).FooterText = "合计 共" & DS_DO.Tables(1).Rows.Count & "条"

        num = 0 '件数
        For m = 0 To DS_DO.Tables(1).Rows.Count - 1
            num = num + DS_DO.Tables(1).Rows(m)(3)
        Next
        Me.C1DBG.Columns.Item(3).FooterText = CType(num, String)

        num = 0 '重量
        For m = 0 To DS_DO.Tables(1).Rows.Count - 1
            num = num + DS_DO.Tables(1).Rows(m)(5)
        Next
        Me.C1DBG.Columns.Item(5).FooterText = CType(num, String)

        num = 0 '1舱件数
        For m = 0 To DS_DO.Tables(1).Rows.Count - 1
            num = num + DS_DO.Tables(1).Rows(m)(7)
        Next
        Me.C1DBG.Columns.Item(7).FooterText = CType(num, String)

        num = 0 '2舱件数
        For m = 0 To DS_DO.Tables(1).Rows.Count - 1
            num = num + DS_DO.Tables(1).Rows(m)(9)
        Next
        Me.C1DBG.Columns.Item(9).FooterText = CType(num, String)

        num = 0 '3舱件数
        For m = 0 To DS_DO.Tables(1).Rows.Count - 1
            num = num + DS_DO.Tables(1).Rows(m)(11)
        Next
        Me.C1DBG.Columns.Item(11).FooterText = CType(num, String)

        num = 0 '4舱件数
        For m = 0 To DS_DO.Tables(1).Rows.Count - 1
            num = num + DS_DO.Tables(1).Rows(m)(13)
        Next
        Me.C1DBG.Columns.Item(13).FooterText = CType(num, String)

        num = 0 '5舱件数
        For m = 0 To DS_DO.Tables(1).Rows.Count - 1
            num = num + DS_DO.Tables(1).Rows(m)(15)
        Next
        Me.C1DBG.Columns.Item(15).FooterText = CType(num, String)

        num = 0 '6舱件数
        For m = 0 To DS_DO.Tables(1).Rows.Count - 1
            num = num + DS_DO.Tables(1).Rows(m)(17)
        Next
        Me.C1DBG.Columns.Item(17).FooterText = CType(num, String)

        sqlconn.Close()
        Exit Sub
Err:
        Resume Next

    End Sub

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        Me.Close()
    End Sub

    Private Sub ToolBar_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar.ButtonClick
        Select Case Me.ToolBar.Buttons.IndexOf(e.Button)
            Case 0
                Try
                    Dim frm As New FrmCARGO_HATCHED_do
                    frm.ShowDialog()

                    Call myDataGrid(SelectStr, SqlStr)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case 1

            Case 2
                Call mnuPrint_Click(sender, e)
            Case 3
                Call mnuExport_Click(sender, e)
            Case 4

            Case 5
                Me.Close()
            Case 6

            Case 7

            Case 8

            Case 9

            Case 10

        End Select
    End Sub

    Private Sub C1DBG_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            If Me.C1DBG.Col = Me.C1DBG.Columns.Count - 1 And Me.C1DBG.Row < ds.Tables(0).Rows.Count - 1 Then
                Me.C1DBG.Row = Me.C1DBG.Row + 1
                Me.C1DBG.Col = ColNum
            End If
        End If
    End Sub

    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
        'Call eng()
        Call PrintExcel()
    End Sub

    Private Sub mnuExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExport.Click
        If DS_DO.Tables(0).Rows.Count <= 6 Then
            eng_export_5()
        End If
        If DS_DO.Tables(0).Rows.Count > 6 And DS_DO.Tables(0).Rows.Count <= 8 Then
            eng_export_7()
        End If
        If DS_DO.Tables(0).Rows.Count > 8 And DS_DO.Tables(0).Rows.Count <= 11 Then
            eng_export_10()
        End If
        If DS_DO.Tables(0).Rows.Count > 11 And DS_DO.Tables(0).Rows.Count <= 16 Then
            eng_export_15()
        End If
        'eng_export()
        'Call ExportExcel()
    End Sub

    Private Sub ExportExcel() '导出Excel        
        Call MakeExcel()
    End Sub

    Private Sub PrintExcel() '打印到Excel        
        Try
            'If trade = "1" Then
            '    Call china()
            'ElseIf trade = "2" Then
            '    Call eng()
            'End If
            If DS_DO.Tables(0).Rows.Count <= 6 Then
                eng_5()
            End If
            If DS_DO.Tables(0).Rows.Count > 6 And DS_DO.Tables(0).Rows.Count <= 8 Then
                eng_7()
            End If
            If DS_DO.Tables(0).Rows.Count > 8 And DS_DO.Tables(0).Rows.Count <= 11 Then
                eng_10()
            End If
            If DS_DO.Tables(0).Rows.Count > 11 And DS_DO.Tables(0).Rows.Count <= 16 Then
                eng_15()
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
        Dim i As Integer  '移动自增数
        Dim j As Integer  '整张数
        Dim q As Integer   '余数
        Try
            RecordExcelProcess()
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "Report_zlp.xls", pathstr + "Report.xls")
            Filepath = pathstr + "report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("货物分舱单"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = False
            xlsheet.Select()
            xlsheet.Cells(9, 1) = "船名： " & ds_sship.Tables(0).Rows(0).Item("CHI_VESSEL")
            xlsheet.Cells(9, 6) = "航次： " & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            xlsheet.Cells(9, 10) = "国籍： " & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_CHA")
            xlsheet.Cells(9, 16) = "泊位： " & DS_DO.Tables(2).Rows(0).Item("berth")
            xlsheet.Cells(9, 13) = "卸货港： " & UNLOADPORT
            'xlsheet.Cells(9, 13) = "卸货港： " & UNLOADPORT

            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) Then
            Else
                xlsheet.Cells(10, 3) = Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")) & "年" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")) & "月" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")) & "日"
            End If
            xlsheet.Cells(10, 12) = Year(Now) & "年" & Month(Now) & "月" & Day(Now) & "日"

            For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                xlsheet.Cells(11, 8 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
            Next
            If DS_DO.Tables(1).Rows.Count <= 25 Then  '单张
                For row = 0 To DS_DO.Tables(1).Rows.Count - 2
                    For col = 0 To 18
                        xlsheet.Cells(13 + row, col + 1) = DS_DO.Tables(1).Rows(row)(col)
                    Next col
                Next row
                xlsheet.Cells(37, 4) = DS_DO.Tables(1).Rows(row)(3)
                xlsheet.Cells(37, 6) = DS_DO.Tables(1).Rows(row)(5)
                xlsheet.Cells(37, 8) = DS_DO.Tables(1).Rows(row)(7)
                xlsheet.Cells(37, 10) = DS_DO.Tables(1).Rows(row)(9)
                xlsheet.Cells(37, 12) = DS_DO.Tables(1).Rows(row)(11)
                xlsheet.Cells(37, 14) = DS_DO.Tables(1).Rows(row)(13)
                xlsheet.Cells(37, 16) = DS_DO.Tables(1).Rows(row)(15)
                xlsheet.Cells(37, 18) = DS_DO.Tables(1).Rows(row)(17)
                xlsheet.PrintOut()
            Else  '多张
                j = DS_DO.Tables(1).Rows.Count / 24   '整张数
                q = DS_DO.Tables(1).Rows.Count - 1 - j * 24   '不算合计行，剩下的行数
                If q > 0 Then

                    For i = 0 To j - 1
                        For row = 0 To 23
                            For col = 0 To 18
                                xlsheet.Cells(13 + row, col + 1) = ""
                            Next col
                        Next row
                        For row = 0 To 23
                            For col = 0 To 18
                                xlsheet.Cells(13 + row, col + 1) = DS_DO.Tables(1).Rows(row + i * 24)(col)
                            Next col
                        Next row
                        xlsheet.PrintOut()
                    Next i
                    '剩下最后一张余张
                    For row = 0 To 23
                        For col = 0 To 18
                            xlsheet.Cells(13 + row, col + 1) = ""
                        Next col
                    Next row
                    For row = 0 To q - 1
                        For col = 0 To 18
                            xlsheet.Cells(13 + row, col + 1) = DS_DO.Tables(1).Rows(row + i * 24)(col)
                        Next col
                    Next row

                    xlsheet.Cells(37, 4) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(3)
                    xlsheet.Cells(37, 6) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(5)
                    xlsheet.Cells(37, 8) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(7)
                    xlsheet.Cells(37, 10) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(9)
                    xlsheet.Cells(37, 12) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(11)
                    xlsheet.Cells(37, 14) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(13)
                    xlsheet.Cells(37, 16) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(15)
                    xlsheet.Cells(37, 18) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(17)
                    xlsheet.PrintOut()
                Else '没有余张
                    For i = 0 To j - 2
                        For row = 0 To 23
                            For col = 0 To 18
                                xlsheet.Cells(13 + row, col + 1) = ""
                            Next col
                        Next row
                        For row = 0 To 23
                            For col = 0 To 18
                                xlsheet.Cells(13 + row, col + 1) = DS_DO.Tables(1).Rows(row + i * 24)(col)
                            Next col
                        Next row
                        xlsheet.PrintOut()
                    Next i
                    For row = 0 To 23
                        For col = 0 To 18
                            xlsheet.Cells(13 + row, col + 1) = ""
                        Next col
                    Next row
                    For row = 0 To 23
                        For col = 0 To 18
                            xlsheet.Cells(13 + row, col + 1) = DS_DO.Tables(1).Rows(row + i * 24)(col)
                        Next col
                    Next row
                    xlsheet.Cells(37, 4) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(3)
                    xlsheet.Cells(37, 6) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(5)
                    xlsheet.Cells(37, 8) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(7)
                    xlsheet.Cells(37, 10) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(9)
                    xlsheet.Cells(37, 12) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(11)
                    xlsheet.Cells(37, 14) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(13)
                    xlsheet.Cells(37, 16) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(15)
                    xlsheet.Cells(37, 18) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(17)
                    xlsheet.PrintOut()
                End If
            End If

            KillExcelProcess()
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
        Dim dw As New DataView
        Dim i As Integer  '移动自增数
        Dim j As Integer  '整张数
        Dim q As Integer   '余数
        Dim ds_eng As New DataSet

        Try
            RecordExcelProcess()
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            'FileCopy(pathstr + "Report_CARGO.xls", pathstr + "Report.xls")
            FileCopy(pathstr + "货物分舱单11.xls", pathstr + "Report.xls")
            Filepath = pathstr + "report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("sheet1"), Excel.Worksheet)

            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = False
            xlsheet.Select()
            'dw = Getdata("select PORT_ENG from code_port where CODE_PORT='" & UNLOADPORT & "'", ds_eng)

            xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
            xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
            xlsheet.Cells(8, 21) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
            ' If ds_eng.Tables(0).Rows.Count > 0 Then
            xlsheet.Cells(9, 4) = UNLOADPORT
            'End If
            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
            End If
            xlsheet.Cells(9, 18) = "'" & Day(Now).ToString.PadLeft(2, "0") & "/" & Month(Now).ToString.PadLeft(2, "0") & "/" & Year(Now)
            For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
            Next
            If DS_DO.Tables(1).Rows.Count <= 21 Then  '单张
                For row = 0 To DS_DO.Tables(1).Rows.Count - 2
                    For col = 0 To 18
                        If col > 2 Then
                            xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row)(col)
                        Else
                            xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row)(col)
                        End If
                    Next col
                Next row
                xlsheet.Cells(33, 5) = DS_DO.Tables(1).Rows(row)(3)
                xlsheet.Cells(33, 7) = DS_DO.Tables(1).Rows(row)(5)
                xlsheet.Cells(33, 9) = DS_DO.Tables(1).Rows(row)(7)
                xlsheet.Cells(33, 11) = DS_DO.Tables(1).Rows(row)(9)
                xlsheet.Cells(33, 13) = DS_DO.Tables(1).Rows(row)(11)
                xlsheet.Cells(33, 15) = DS_DO.Tables(1).Rows(row)(13)
                xlsheet.Cells(33, 17) = DS_DO.Tables(1).Rows(row)(15)
                xlsheet.Cells(33, 19) = DS_DO.Tables(1).Rows(row)(17)
                xlsheet.Cells(35, 22) = "'" & "1/1"
                xlsheet.PrintOut()
            Else  '多张
                j = (DS_DO.Tables(1).Rows.Count - DS_DO.Tables(1).Rows.Count Mod 20) / 20   '整张数
                q = DS_DO.Tables(1).Rows.Count - 1 - j * 20   '不算合计行，剩下的行数
                If q > 0 Then
                    For i = 0 To j - 1
                        For row = 0 To 19
                            For col = 0 To 18
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = ""
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = ""
                                End If
                            Next col
                        Next row
                        For row = 0 To 19
                            For col = 0 To 18
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                End If
                            Next col
                        Next row
                        xlsheet.Cells(35, 22) = "'" & i + 1 & "/" & j + 1
                        'xlsheet.Cells(33, 1) = ""
                        xlsheet.PrintOut()
                        'xlsheet.Cells(33, 1) = "Total"
                    Next i
                    '剩下最后一张余张
                    For row = 0 To 19
                        For col = 0 To 18
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = ""
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = ""
                            End If
                        Next col
                    Next row
                    For row = 0 To q - 1
                        For col = 0 To 18
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            End If
                        Next col
                    Next row
                    xlsheet.Cells(33, 5) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(3)
                    xlsheet.Cells(33, 7) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(5)
                    xlsheet.Cells(33, 9) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(7)
                    xlsheet.Cells(33, 11) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(9)
                    xlsheet.Cells(33, 13) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(11)
                    xlsheet.Cells(33, 15) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(13)
                    xlsheet.Cells(33, 17) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(15)
                    xlsheet.Cells(33, 19) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(17)
                    xlsheet.Cells(35, 22) = "'" & j + 1 & "/" & j + 1
                    xlsheet.PrintOut()
                Else '没有余张
                    For i = 0 To j - 2
                        For row = 0 To 19
                            For col = 0 To 18
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = ""
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = ""
                                End If
                            Next col
                        Next row
                        For row = 0 To 19
                            For col = 0 To 18
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                End If
                            Next col
                        Next row
                        xlsheet.Cells(35, 22) = "'" & i + 1 & "/" & j
                        'xlsheet.Cells(33, 1) = ""
                        xlsheet.PrintOut()
                        'xlsheet.Cells(33, 1) = "Total"
                    Next i
                    For row = 0 To 19
                        For col = 0 To 18
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = ""
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = ""
                            End If
                        Next col
                    Next row
                    For row = 0 To 19
                        For col = 0 To 18
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            End If
                        Next col
                    Next row
                    xlsheet.Cells(33, 5) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(3)
                    xlsheet.Cells(33, 7) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(5)
                    xlsheet.Cells(33, 9) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(7)
                    xlsheet.Cells(33, 11) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(9)
                    xlsheet.Cells(33, 13) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(11)
                    xlsheet.Cells(33, 15) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(13)
                    xlsheet.Cells(33, 17) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(15)
                    xlsheet.Cells(33, 19) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(17)
                    xlsheet.Cells(35, 22) = "'" & j & "/" & j
                    xlsheet.PrintOut()
                End If
            End If
            KillExcelProcess()
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
            KillExcelProcess()
        End Try
    End Sub

    Private Sub eng_5()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer
        Dim dw As New DataView
        Dim i As Integer  '移动自增数
        Dim j As Integer  '整张数
        Dim q As Integer   '余数
        Dim ds_eng As New DataSet
        Dim sheet As String
        Try
            RecordExcelProcess()
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "货物分舱单5.xls", pathstr + "Report.xls")
            Filepath = pathstr + "Report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            sheet = "Sheet1"
            xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = False
            xlsheet.Select()


            xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
            xlsheet.Cells(9, 4) = UNLOADPORT
            xlsheet.Cells(8, 20) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
            xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")

            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
            End If
            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
            End If


            For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
            Next

            If DS_DO.Tables(1).Rows.Count <= 21 Then  '单张
                For row = 0 To DS_DO.Tables(1).Rows.Count - 2
                    For col = 0 To 18
                        If col > 1 Then
                            xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row)(col)
                        Else
                            xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row)(col)
                        End If
                    Next col
                Next row
                xlsheet.Cells(33, 5) = DS_DO.Tables(1).Rows(row)(3)
                xlsheet.Cells(33, 7) = DS_DO.Tables(1).Rows(row)(5)
                xlsheet.Cells(33, 9) = DS_DO.Tables(1).Rows(row)(7)
                xlsheet.Cells(33, 11) = DS_DO.Tables(1).Rows(row)(9)
                xlsheet.Cells(33, 13) = DS_DO.Tables(1).Rows(row)(11)
                xlsheet.Cells(33, 15) = DS_DO.Tables(1).Rows(row)(13)
                xlsheet.Cells(33, 17) = DS_DO.Tables(1).Rows(row)(15)
                xlsheet.Cells(33, 19) = DS_DO.Tables(1).Rows(row)(17)
                xlsheet.Cells(35, 20) = "'" & "1/1"
                xlsheet.PrintOut()
            Else  '多张
                j = (DS_DO.Tables(1).Rows.Count - DS_DO.Tables(1).Rows.Count Mod 20) / 20   '整张数
                q = DS_DO.Tables(1).Rows.Count - 1 - j * 20   '不算合计行，剩下的行数
                If q <> 0 Then
                    For i = 0 To j - 1
                        sheet = "Sheet" & System.Convert.ToString(i + 1)
                        xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                        xlsheet.Select()

                        xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                        xlsheet.Cells(9, 4) = UNLOADPORT
                        xlsheet.Cells(8, 20) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                        xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                        xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")

                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                            xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                        End If
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                            xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                        End If


                        For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                            xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                        Next
                        For row = 0 To 19
                            For col = 0 To 18
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = ""
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = ""
                                End If
                            Next col
                        Next row
                        For row = 0 To 19
                            For col = 0 To 18
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                End If
                            Next col
                        Next row
                        xlsheet.Cells(35, 20) = "'" & i + 1 & "/" & j + 1
                        xlsheet.PrintOut()
                        'xlsheet.Cells(33, 1) = "Total"
                    Next i
                    '剩下最后一张余张
                    sheet = "Sheet" & System.Convert.ToString(j + 1)
                    xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                    xlsheet.Select()

                    xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                    xlsheet.Cells(9, 4) = UNLOADPORT
                    xlsheet.Cells(8, 20) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                    xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                    xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")

                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                        xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                    End If
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                        xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                    End If


                    For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                        xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                    Next
                    For row = 0 To 19
                        For col = 0 To 18
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = ""
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = ""
                            End If
                        Next col
                    Next row
                    For row = 0 To q - 1
                        For col = 0 To 18
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            End If
                        Next col
                    Next row
                    xlsheet.Cells(33, 5) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(3)
                    xlsheet.Cells(33, 7) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(5)
                    xlsheet.Cells(33, 9) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(7)
                    xlsheet.Cells(33, 11) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(9)
                    xlsheet.Cells(33, 13) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(11)
                    xlsheet.Cells(33, 15) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(13)
                    xlsheet.Cells(33, 17) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(15)
                    xlsheet.Cells(33, 19) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(17)
                    xlsheet.Cells(35, 20) = "'" & j + 1 & "/" & j + 1
                    xlsheet.PrintOut()
                Else '没有余张
                    For i = 0 To j - 2
                        sheet = "Sheet" & System.Convert.ToString(i + 1)
                        xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                        xlsheet.Select()

                        xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                        xlsheet.Cells(9, 4) = UNLOADPORT
                        xlsheet.Cells(8, 20) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                        xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                        xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")

                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                            xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                        End If
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                            xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                        End If


                        For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                            xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                        Next
                        For row = 0 To 19
                            For col = 0 To 18
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = ""
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = ""
                                End If
                            Next col
                        Next row
                        For row = 0 To 19
                            For col = 0 To 18
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                End If
                            Next col
                        Next row
                        xlsheet.Cells(35, 20) = "'" & i + 1 & "/" & j
                        xlsheet.PrintOut()
                        'xlsheet.Cells(33, 1) = "Total"
                    Next i

                    sheet = "Sheet" & j
                    xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                    xlsheet.Select()

                    xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                    xlsheet.Cells(9, 4) = UNLOADPORT
                    xlsheet.Cells(8, 20) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                    xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                    xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")

                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                        xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                    End If
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                        xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                    End If


                    For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                        xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                    Next
                    For row = 0 To 19
                        For col = 0 To 18
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = ""
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = ""
                            End If
                        Next col
                    Next row
                    For row = 0 To 19
                        For col = 0 To 18
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            End If
                        Next col
                    Next row
                    xlsheet.Cells(33, 5) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(3)
                    xlsheet.Cells(33, 7) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(5)
                    xlsheet.Cells(33, 9) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(7)
                    xlsheet.Cells(33, 11) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(9)
                    xlsheet.Cells(33, 13) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(11)
                    xlsheet.Cells(33, 15) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(13)
                    xlsheet.Cells(33, 17) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(15)
                    xlsheet.Cells(33, 19) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(17)
                    xlsheet.Cells(35, 20) = "'" & j & "/" & j
                    xlsheet.PrintOut()
                End If
            End If
            KillExcelProcess()
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
            KillExcelProcess()
        End Try
    End Sub

    Private Sub eng_7()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer
        Dim dw As New DataView
        Dim i As Integer  '移动自增数
        Dim j As Integer  '整张数
        Dim q As Integer   '余数
        Dim ds_eng As New DataSet
        Dim sheet As String
        Try
            RecordExcelProcess()
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "货物分舱单7.xls", pathstr + "Report.xls")
            Filepath = pathstr + "Report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            sheet = "Sheet1"
            xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = False
            xlsheet.Select()

            xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
            xlsheet.Cells(9, 4) = UNLOADPORT
            xlsheet.Cells(8, 23) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
            xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")

            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
            End If
            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
            End If


            For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
            Next

            If DS_DO.Tables(1).Rows.Count <= 26 Then  '单张
                For row = 0 To DS_DO.Tables(1).Rows.Count - 2
                    For col = 0 To 22
                        If col > 1 Then
                            xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row)(col)
                        Else
                            xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row)(col)
                        End If
                    Next col
                Next row
                xlsheet.Cells(38, 5) = DS_DO.Tables(1).Rows(row)(3)
                xlsheet.Cells(38, 7) = DS_DO.Tables(1).Rows(row)(5)
                xlsheet.Cells(38, 9) = DS_DO.Tables(1).Rows(row)(7)
                xlsheet.Cells(38, 11) = DS_DO.Tables(1).Rows(row)(9)
                xlsheet.Cells(38, 13) = DS_DO.Tables(1).Rows(row)(11)
                xlsheet.Cells(38, 15) = DS_DO.Tables(1).Rows(row)(13)
                xlsheet.Cells(38, 17) = DS_DO.Tables(1).Rows(row)(15)
                xlsheet.Cells(38, 19) = DS_DO.Tables(1).Rows(row)(17)
                xlsheet.Cells(38, 21) = DS_DO.Tables(1).Rows(row)(19)
                xlsheet.Cells(38, 23) = DS_DO.Tables(1).Rows(row)(21)
                xlsheet.Cells(40, 24) = "'" & "1/1"
                xlsheet.PrintOut()
            Else  '多张
                j = (DS_DO.Tables(1).Rows.Count - DS_DO.Tables(1).Rows.Count Mod 25) / 25   '整张数
                q = DS_DO.Tables(1).Rows.Count - 1 - j * 25   '不算合计行，剩下的行数
                If q <> 0 Then
                    For i = 0 To j - 1
                        sheet = "Sheet" & System.Convert.ToString(i + 1)
                        xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                        xlsheet.Select()

                        xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                        xlsheet.Cells(9, 4) = UNLOADPORT
                        xlsheet.Cells(8, 20) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                        xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                        xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")

                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                            xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                        End If
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                            xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                        End If
                        For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                            xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                        Next
                        For row = 0 To 24
                            For col = 0 To 22
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = ""
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = ""
                                End If
                            Next col
                        Next row
                        For row = 0 To 24
                            For col = 0 To 22
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                End If
                            Next col
                        Next row
                        xlsheet.Cells(40, 24) = "'" & i + 1 & "/" & j + 1
                        xlsheet.PrintOut()
                        'xlsheet.Cells(33, 1) = "Total"
                    Next i
                    '剩下最后一张余张
                    sheet = "Sheet" & System.Convert.ToString(j + 1)
                    xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                    xlsheet.Select()

                    xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                    xlsheet.Cells(9, 4) = UNLOADPORT
                    xlsheet.Cells(8, 23) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                    xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                    xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")

                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                        xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                    End If
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                        xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                    End If
                    For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                        xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                    Next
                    For row = 0 To 24
                        For col = 0 To 22
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = ""
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = ""
                            End If
                        Next col
                    Next row
                    For row = 0 To q - 1
                        For col = 0 To 22
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            End If
                        Next col
                    Next row
                    xlsheet.Cells(38, 5) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(3)
                    xlsheet.Cells(38, 7) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(5)
                    xlsheet.Cells(38, 9) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(7)
                    xlsheet.Cells(38, 11) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(9)
                    xlsheet.Cells(38, 13) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(11)
                    xlsheet.Cells(38, 15) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(13)
                    xlsheet.Cells(38, 17) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(15)
                    xlsheet.Cells(38, 19) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(17)
                    xlsheet.Cells(38, 21) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(19)
                    xlsheet.Cells(38, 23) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(21)
                    xlsheet.Cells(40, 24) = "'" & j + 1 & "/" & j + 1
                    xlsheet.PrintOut()
                Else '没有余张
                    For i = 0 To j - 2
                        sheet = "Sheet" & System.Convert.ToString(i + 1)
                        xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                        xlsheet.Select()

                        xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                        xlsheet.Cells(9, 4) = UNLOADPORT
                        xlsheet.Cells(8, 20) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                        xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                        xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")

                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                            xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                        End If
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                            xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                        End If
                        For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                            xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                        Next
                        For row = 0 To 24
                            For col = 0 To 22
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = ""
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = ""
                                End If
                            Next col
                        Next row
                        For row = 0 To 24
                            For col = 0 To 22
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                End If
                            Next col
                        Next row
                        xlsheet.Cells(40, 24) = "'" & i + 1 & "/" & j
                        'xlsheet.Cells(33, 1) = ""
                        xlsheet.PrintOut()
                        'xlsheet.Cells(33, 1) = "Total"
                    Next i

                    sheet = "Sheet" & j
                    xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                    xlsheet.Select()

                    xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                    xlsheet.Cells(9, 4) = UNLOADPORT
                    xlsheet.Cells(8, 20) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                    xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                    xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")

                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                        xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                    End If
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                        xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                    End If
                    For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                        xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                    Next
                    For row = 0 To 24
                        For col = 0 To 22
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = ""
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = ""
                            End If
                        Next col
                    Next row
                    For row = 0 To 24
                        For col = 0 To 22
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            End If
                        Next col
                    Next row
                    xlsheet.Cells(38, 5) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(3)
                    xlsheet.Cells(38, 7) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(5)
                    xlsheet.Cells(38, 9) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(7)
                    xlsheet.Cells(38, 11) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(9)
                    xlsheet.Cells(38, 13) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(11)
                    xlsheet.Cells(38, 15) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(13)
                    xlsheet.Cells(38, 17) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(15)
                    xlsheet.Cells(38, 19) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(17)
                    xlsheet.Cells(38, 21) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(19)
                    xlsheet.Cells(38, 23) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(21)
                    xlsheet.Cells(40, 24) = "'" & j & "/" & j
                    xlsheet.PrintOut()
                End If
            End If
            KillExcelProcess()
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
            KillExcelProcess()
        End Try
    End Sub

    Private Sub eng_10()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer
        Dim dw As New DataView
        Dim i As Integer  '移动自增数
        Dim j As Integer  '整张数
        Dim q As Integer   '余数
        Dim ds_eng As New DataSet
        Dim sheet As String
        Try
            RecordExcelProcess()
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "货物分舱单10.xls", pathstr + "Report.xls")
            Filepath = pathstr + "Report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            sheet = "Sheet1"
            xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = False
            xlsheet.Select()

            xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
            xlsheet.Cells(9, 4) = UNLOADPORT
            xlsheet.Cells(8, 27) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
            xlsheet.Cells(8, 8) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            xlsheet.Cells(8, 17) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")

            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                xlsheet.Cells(9, 13) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
            End If
            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                xlsheet.Cells(9, 24) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
            End If
            'xlsheet.Cells(9, 24) = "'" & Day(Now).ToString.PadLeft(2, "0") & "/" & Month(Now).ToString.PadLeft(2, "0") & "/" & Year(Now)

            For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
            Next

            If DS_DO.Tables(1).Rows.Count <= 31 Then  '单张
                For row = 0 To DS_DO.Tables(1).Rows.Count - 2
                    For col = 0 To 28
                        If col > 1 Then
                            xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row)(col)
                        Else
                            xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row)(col)
                        End If
                    Next col
                Next row
                xlsheet.Cells(43, 5) = DS_DO.Tables(1).Rows(row)(3)
                xlsheet.Cells(43, 7) = DS_DO.Tables(1).Rows(row)(5)
                xlsheet.Cells(43, 9) = DS_DO.Tables(1).Rows(row)(7)
                xlsheet.Cells(43, 11) = DS_DO.Tables(1).Rows(row)(9)
                xlsheet.Cells(43, 13) = DS_DO.Tables(1).Rows(row)(11)
                xlsheet.Cells(43, 15) = DS_DO.Tables(1).Rows(row)(13)
                xlsheet.Cells(43, 17) = DS_DO.Tables(1).Rows(row)(15)
                xlsheet.Cells(43, 19) = DS_DO.Tables(1).Rows(row)(17)
                xlsheet.Cells(43, 21) = DS_DO.Tables(1).Rows(row)(19)
                xlsheet.Cells(43, 23) = DS_DO.Tables(1).Rows(row)(21)
                xlsheet.Cells(43, 25) = DS_DO.Tables(1).Rows(row)(23)
                xlsheet.Cells(43, 27) = DS_DO.Tables(1).Rows(row)(25)
                xlsheet.Cells(43, 29) = DS_DO.Tables(1).Rows(row)(27)
                xlsheet.Cells(45, 30) = "'" & "1/1"
                xlsheet.PrintOut()
            Else  '多张
                j = (DS_DO.Tables(1).Rows.Count - DS_DO.Tables(1).Rows.Count Mod 30) / 30   '整张数
                q = DS_DO.Tables(1).Rows.Count - 1 - j * 30   '不算合计行，剩下的行数
                If q <> 0 Then
                    For i = 0 To j - 1
                        sheet = "Sheet" & System.Convert.ToString(i + 1)
                        xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                        xlsheet.Select()

                        xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                        xlsheet.Cells(9, 4) = UNLOADPORT
                        xlsheet.Cells(8, 27) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                        xlsheet.Cells(8, 8) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                        xlsheet.Cells(8, 17) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")

                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                            xlsheet.Cells(9, 13) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                        End If
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                            xlsheet.Cells(9, 24) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                        End If

                        For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                            xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                        Next
                        For row = 0 To 29
                            For col = 0 To 28
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = ""
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = ""
                                End If
                            Next col
                        Next row
                        For row = 0 To 29
                            For col = 0 To 28
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                End If
                            Next col
                        Next row
                        xlsheet.Cells(45, 30) = "'" & i + 1 & "/" & j + 1
                        'xlsheet.Cells(33, 1) = ""
                        xlsheet.PrintOut()
                        'xlsheet.Cells(33, 1) = "Total"
                    Next i
                    '剩下最后一张余张
                    sheet = "Sheet" & System.Convert.ToString(j + 1)
                    xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                    xlsheet.Select()

                    xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                    xlsheet.Cells(9, 4) = UNLOADPORT
                    xlsheet.Cells(8, 27) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                    xlsheet.Cells(8, 8) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                    xlsheet.Cells(8, 17) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")

                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                        xlsheet.Cells(9, 13) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                    End If
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                        xlsheet.Cells(9, 24) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                    End If

                    For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                        xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                    Next
                    For row = 0 To 29
                        For col = 0 To 28
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = ""
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = ""
                            End If
                        Next col
                    Next row
                    For row = 0 To q - 1
                        For col = 0 To 28
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            End If
                        Next col
                    Next row
                    xlsheet.Cells(43, 5) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(3)
                    xlsheet.Cells(43, 7) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(5)
                    xlsheet.Cells(43, 9) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(7)
                    xlsheet.Cells(43, 11) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(9)
                    xlsheet.Cells(43, 13) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(11)
                    xlsheet.Cells(43, 15) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(13)
                    xlsheet.Cells(43, 17) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(15)
                    xlsheet.Cells(43, 19) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(17)
                    xlsheet.Cells(43, 21) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(19)
                    xlsheet.Cells(43, 23) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(21)
                    xlsheet.Cells(43, 25) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(23)
                    xlsheet.Cells(43, 27) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(25)
                    xlsheet.Cells(43, 29) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(27)
                    xlsheet.Cells(45, 30) = "'" & j + 1 & "/" & j + 1
                    xlsheet.PrintOut()
                Else '没有余张
                    For i = 0 To j - 2
                        sheet = "Sheet" & System.Convert.ToString(i + 1)
                        xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                        xlsheet.Select()


                        xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                        xlsheet.Cells(9, 4) = UNLOADPORT
                        xlsheet.Cells(8, 27) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                        xlsheet.Cells(8, 8) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                        xlsheet.Cells(8, 17) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                            xlsheet.Cells(9, 13) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                        End If
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                            xlsheet.Cells(9, 24) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                        End If

                        For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                            xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                        Next
                        For row = 0 To 29
                            For col = 0 To 28
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = ""
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = ""
                                End If
                            Next col
                        Next row
                        For row = 0 To 29
                            For col = 0 To 28
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                End If
                            Next col
                        Next row
                        xlsheet.Cells(45, 30) = "'" & i + 1 & "/" & j
                        'xlsheet.Cells(33, 1) = ""
                        xlsheet.PrintOut()
                        'xlsheet.Cells(33, 1) = "Total"
                    Next i

                    sheet = "Sheet" & j
                    xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                    xlsheet.Select()


                    xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                    xlsheet.Cells(9, 4) = UNLOADPORT
                    xlsheet.Cells(8, 27) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                    xlsheet.Cells(8, 8) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                    xlsheet.Cells(8, 17) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                        xlsheet.Cells(9, 13) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                    End If
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                        xlsheet.Cells(9, 24) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                    End If

                    For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                        xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                    Next
                    For row = 0 To 29
                        For col = 0 To 28
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = ""
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = ""
                            End If
                        Next col
                    Next row
                    For row = 0 To 29
                        For col = 0 To 28
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            End If
                        Next col
                    Next row
                    xlsheet.Cells(43, 5) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(3)
                    xlsheet.Cells(43, 7) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(5)
                    xlsheet.Cells(43, 9) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(7)
                    xlsheet.Cells(43, 11) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(9)
                    xlsheet.Cells(43, 13) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(11)
                    xlsheet.Cells(43, 15) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(13)
                    xlsheet.Cells(43, 17) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(15)
                    xlsheet.Cells(43, 19) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(17)
                    xlsheet.Cells(43, 21) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(19)
                    xlsheet.Cells(43, 23) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(21)
                    xlsheet.Cells(43, 25) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(23)
                    xlsheet.Cells(43, 27) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(25)
                    xlsheet.Cells(43, 29) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(27)
                    xlsheet.Cells(45, 30) = "'" & j & "/" & j
                    xlsheet.PrintOut()
                End If
            End If
            KillExcelProcess()
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
            KillExcelProcess()
        End Try
    End Sub

    Private Sub eng_15()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer
        Dim dw As New DataView
        Dim i As Integer  '移动自增数
        Dim j As Integer  '整张数
        Dim q As Integer   '余数
        Dim ds_eng As New DataSet
        Dim sheet As String
        Try
            RecordExcelProcess()
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "货物分舱单15.xls", pathstr + "Report.xls")
            Filepath = pathstr + "Report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            sheet = "Sheet1"
            xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = False
            xlsheet.Select()


            xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
            xlsheet.Cells(9, 4) = UNLOADPORT
            xlsheet.Cells(8, 37) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
            xlsheet.Cells(8, 14) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            xlsheet.Cells(8, 25) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
            End If
            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                xlsheet.Cells(9, 34) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
            End If

            For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
            Next

            If DS_DO.Tables(1).Rows.Count <= 31 Then  '单张
                For row = 0 To DS_DO.Tables(1).Rows.Count - 2
                    For col = 0 To 38
                        If col > 1 Then
                            xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row)(col)
                        Else
                            xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row)(col)
                        End If
                    Next col
                Next row
                xlsheet.Cells(43, 5) = DS_DO.Tables(1).Rows(row)(3)
                xlsheet.Cells(43, 7) = DS_DO.Tables(1).Rows(row)(5)
                xlsheet.Cells(43, 9) = DS_DO.Tables(1).Rows(row)(7)
                xlsheet.Cells(43, 11) = DS_DO.Tables(1).Rows(row)(9)
                xlsheet.Cells(43, 13) = DS_DO.Tables(1).Rows(row)(11)
                xlsheet.Cells(43, 15) = DS_DO.Tables(1).Rows(row)(13)
                xlsheet.Cells(43, 17) = DS_DO.Tables(1).Rows(row)(15)
                xlsheet.Cells(43, 19) = DS_DO.Tables(1).Rows(row)(17)
                xlsheet.Cells(43, 21) = DS_DO.Tables(1).Rows(row)(19)
                xlsheet.Cells(43, 23) = DS_DO.Tables(1).Rows(row)(21)
                xlsheet.Cells(43, 25) = DS_DO.Tables(1).Rows(row)(23)
                xlsheet.Cells(43, 27) = DS_DO.Tables(1).Rows(row)(25)
                xlsheet.Cells(43, 29) = DS_DO.Tables(1).Rows(row)(27)
                xlsheet.Cells(43, 31) = DS_DO.Tables(1).Rows(row)(29)
                xlsheet.Cells(43, 33) = DS_DO.Tables(1).Rows(row)(31)
                xlsheet.Cells(43, 35) = DS_DO.Tables(1).Rows(row)(33)
                xlsheet.Cells(43, 37) = DS_DO.Tables(1).Rows(row)(35)
                xlsheet.Cells(43, 39) = DS_DO.Tables(1).Rows(row)(37)
                xlsheet.Cells(45, 40) = "'" & "1/1"
                xlsheet.PrintOut()
            Else  '多张
                j = (DS_DO.Tables(1).Rows.Count - DS_DO.Tables(1).Rows.Count Mod 30) / 30   '整张数
                q = DS_DO.Tables(1).Rows.Count - 1 - j * 30   '不算合计行，剩下的行数
                If q <> 0 Then
                    For i = 0 To j - 1
                        sheet = "Sheet" & System.Convert.ToString(i + 1)
                        xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                        xlsheet.Select()

                        xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                        xlsheet.Cells(9, 4) = UNLOADPORT
                        xlsheet.Cells(8, 37) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                        xlsheet.Cells(8, 14) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                        xlsheet.Cells(8, 25) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                            xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                        End If
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                            xlsheet.Cells(9, 34) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                        End If

                        For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                            xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                        Next
                        For row = 0 To 29
                            For col = 0 To 38
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = ""
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = ""
                                End If
                            Next col
                        Next row
                        For row = 0 To 29
                            For col = 0 To 38
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                End If
                            Next col
                        Next row
                        xlsheet.Cells(45, 30) = "'" & i + 1 & "/" & j + 1
                        'xlsheet.Cells(33, 1) = ""
                        xlsheet.PrintOut()
                        'xlsheet.Cells(33, 1) = "Total"
                    Next i
                    '剩下最后一张余张
                    sheet = "Sheet" & System.Convert.ToString(j + 1)
                    xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                    xlsheet.Select()


                    xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                    xlsheet.Cells(9, 4) = UNLOADPORT
                    xlsheet.Cells(8, 37) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                    xlsheet.Cells(8, 14) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                    xlsheet.Cells(8, 25) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                        xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                    End If
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                        xlsheet.Cells(9, 34) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                    End If

                    For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                        xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                    Next
                    For row = 0 To 29
                        For col = 0 To 38
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = ""
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = ""
                            End If
                        Next col
                    Next row
                    For row = 0 To q - 1
                        For col = 0 To 38
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            End If
                        Next col
                    Next row
                    xlsheet.Cells(43, 5) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(3)
                    xlsheet.Cells(43, 7) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(5)
                    xlsheet.Cells(43, 9) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(7)
                    xlsheet.Cells(43, 11) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(9)
                    xlsheet.Cells(43, 13) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(11)
                    xlsheet.Cells(43, 15) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(13)
                    xlsheet.Cells(43, 17) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(15)
                    xlsheet.Cells(43, 19) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(17)
                    xlsheet.Cells(43, 21) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(19)
                    xlsheet.Cells(43, 23) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(21)
                    xlsheet.Cells(43, 25) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(23)
                    xlsheet.Cells(43, 27) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(25)
                    xlsheet.Cells(43, 29) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(27)
                    xlsheet.Cells(43, 31) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(29)
                    xlsheet.Cells(43, 33) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(31)
                    xlsheet.Cells(43, 35) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(33)
                    xlsheet.Cells(43, 37) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(35)
                    xlsheet.Cells(43, 39) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(37)
                    xlsheet.Cells(45, 30) = "'" & j + 1 & "/" & j + 1
                    xlsheet.PrintOut()
                Else '没有余张
                    For i = 0 To j - 2
                        sheet = "Sheet" & System.Convert.ToString(i + 1)
                        xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                        xlsheet.Select()


                        xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                        xlsheet.Cells(9, 4) = UNLOADPORT
                        xlsheet.Cells(8, 37) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                        xlsheet.Cells(8, 14) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                        xlsheet.Cells(8, 25) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                            xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                        End If
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                            xlsheet.Cells(9, 34) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                        End If

                        For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                            xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                        Next
                        For row = 0 To 29
                            For col = 0 To 38
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = ""
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = ""
                                End If
                            Next col
                        Next row
                        For row = 0 To 29
                            For col = 0 To 38
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                End If
                            Next col
                        Next row
                        xlsheet.Cells(45, 40) = "'" & i + 1 & "/" & j
                        'xlsheet.Cells(33, 1) = ""
                        xlsheet.PrintOut()
                        'xlsheet.Cells(33, 1) = "Total"
                    Next i

                    sheet = "Sheet" & j
                    xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                    xlsheet.Select()


                    xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                    xlsheet.Cells(9, 4) = UNLOADPORT
                    xlsheet.Cells(8, 37) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                    xlsheet.Cells(8, 14) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                    xlsheet.Cells(8, 25) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                        xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                    End If
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                        xlsheet.Cells(9, 34) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                    End If

                    For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                        xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                    Next
                    For row = 0 To 29
                        For col = 0 To 38
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = ""
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = ""
                            End If
                        Next col
                    Next row
                    For row = 0 To 29
                        For col = 0 To 38
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            End If
                        Next col
                    Next row
                    xlsheet.Cells(43, 5) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(3)
                    xlsheet.Cells(43, 7) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(5)
                    xlsheet.Cells(43, 9) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(7)
                    xlsheet.Cells(43, 11) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(9)
                    xlsheet.Cells(43, 13) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(11)
                    xlsheet.Cells(43, 15) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(13)
                    xlsheet.Cells(43, 17) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(15)
                    xlsheet.Cells(43, 19) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(17)
                    xlsheet.Cells(43, 21) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(19)
                    xlsheet.Cells(43, 23) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(21)
                    xlsheet.Cells(43, 25) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(23)
                    xlsheet.Cells(43, 27) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(25)
                    xlsheet.Cells(43, 29) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(27)
                    xlsheet.Cells(43, 31) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(29)
                    xlsheet.Cells(43, 33) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(31)
                    xlsheet.Cells(43, 35) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(33)
                    xlsheet.Cells(43, 37) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(35)
                    xlsheet.Cells(43, 39) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(37)
                    xlsheet.Cells(45, 30) = "'" & j & "/" & j
                    xlsheet.PrintOut()
                End If
            End If
            KillExcelProcess()
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
            KillExcelProcess()
        End Try
    End Sub

    Private Sub eng_export()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer
        Dim dw As New DataView
        Dim i As Integer  '移动自增数
        Dim j As Integer  '整张数
        Dim q As Integer   '余数
        Dim ds_eng As New DataSet
        Dim sheet As String
        Try
            RecordExcelProcess()
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)

            If DS_DO.Tables(0).Rows.Count <= 6 Then
                FileCopy(pathstr + "货物分舱单5.xls", pathstr + "Report.xls")
            End If
            If DS_DO.Tables(0).Rows.Count > 6 And DS_DO.Tables(0).Rows.Count <= 8 Then
                FileCopy(pathstr + "货物分舱单7.xls", pathstr + "Report.xls")
            End If
            If DS_DO.Tables(0).Rows.Count > 8 And DS_DO.Tables(0).Rows.Count <= 11 Then
                FileCopy(pathstr + "货物分舱单10.xls", pathstr + "Report.xls")
            End If
            If DS_DO.Tables(0).Rows.Count > 11 And DS_DO.Tables(0).Rows.Count <= 16 Then
                FileCopy(pathstr + "货物分舱单15.xls", pathstr + "Report.xls")
            End If

            Filepath = pathstr + "Report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            sheet = "Sheet1"
            xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
            xlapp.DisplayAlerts = True
            xlsheet.Application.Visible = True
            xlsheet.Select()

            xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
            xlsheet.Cells(9, 4) = UNLOADPORT

            If DS_DO.Tables(0).Rows.Count <= 6 Then
                xlsheet.Cells(8, 20) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                    xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                End If
                xlsheet.Cells(9, 18) = "'" & Day(Now).ToString.PadLeft(2, "0") & "/" & Month(Now).ToString.PadLeft(2, "0") & "/" & Year(Now)
            End If
            If DS_DO.Tables(0).Rows.Count > 6 And DS_DO.Tables(0).Rows.Count <= 8 Then
                xlsheet.Cells(8, 23) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                    xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                End If
                xlsheet.Cells(9, 18) = "'" & Day(Now).ToString.PadLeft(2, "0") & "/" & Month(Now).ToString.PadLeft(2, "0") & "/" & Year(Now)
            End If
            If DS_DO.Tables(0).Rows.Count > 8 And DS_DO.Tables(0).Rows.Count <= 11 Then
                xlsheet.Cells(8, 27) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                xlsheet.Cells(8, 8) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                xlsheet.Cells(8, 17) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                    xlsheet.Cells(9, 13) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                End If
                xlsheet.Cells(9, 24) = "'" & Day(Now).ToString.PadLeft(2, "0") & "/" & Month(Now).ToString.PadLeft(2, "0") & "/" & Year(Now)
            End If
            If DS_DO.Tables(0).Rows.Count > 11 And DS_DO.Tables(0).Rows.Count <= 16 Then
                xlsheet.Cells(8, 37) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                xlsheet.Cells(8, 14) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                xlsheet.Cells(8, 25) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                    xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                End If
                xlsheet.Cells(9, 34) = "'" & Day(Now).ToString.PadLeft(2, "0") & "/" & Month(Now).ToString.PadLeft(2, "0") & "/" & Year(Now)
            End If
            For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
            Next

            If DS_DO.Tables(1).Rows.Count <= 21 Then  '单张
                For row = 0 To DS_DO.Tables(1).Rows.Count - 2
                    For col = 0 To 18
                        If col > 1 Then
                            xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row)(col)
                        Else
                            xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row)(col)
                        End If
                    Next col
                Next row
                xlsheet.Cells(33, 5) = DS_DO.Tables(1).Rows(row)(3)
                xlsheet.Cells(33, 7) = DS_DO.Tables(1).Rows(row)(5)
                xlsheet.Cells(33, 9) = DS_DO.Tables(1).Rows(row)(7)
                xlsheet.Cells(33, 11) = DS_DO.Tables(1).Rows(row)(9)
                xlsheet.Cells(33, 13) = DS_DO.Tables(1).Rows(row)(11)
                xlsheet.Cells(33, 15) = DS_DO.Tables(1).Rows(row)(13)
                xlsheet.Cells(33, 17) = DS_DO.Tables(1).Rows(row)(15)
                xlsheet.Cells(33, 19) = DS_DO.Tables(1).Rows(row)(17)
                If DS_DO.Tables(0).Rows.Count <= 6 Then
                    xlsheet.Cells(35, 20) = "'" & "1/1"
                End If
                If DS_DO.Tables(0).Rows.Count > 6 And DS_DO.Tables(0).Rows.Count <= 8 Then
                    xlsheet.Cells(40, 24) = "'" & "1/1"
                End If
                If DS_DO.Tables(0).Rows.Count > 8 And DS_DO.Tables(0).Rows.Count <= 11 Then
                    xlsheet.Cells(45, 30) = "'" & "1/1"
                End If
                If DS_DO.Tables(0).Rows.Count > 11 And DS_DO.Tables(0).Rows.Count <= 16 Then
                    xlsheet.Cells(45, 40) = "'" & "1/1"
                End If
                xlsheet.PrintPreview()
            Else  '多张
                Dim ttt As Integer
                ttt = DS_DO.Tables(1).Rows.Count - 4.99
                ttt = (39 - 39 Mod 20) / 20
                ttt = (24 - 4.99) / 20
                ttt = (14 - 4.99) / 20
                ttt = (4 - 4.99) / 20

                j = (DS_DO.Tables(1).Rows.Count - DS_DO.Tables(1).Rows.Count Mod 20) / 20   '整张数
                q = DS_DO.Tables(1).Rows.Count - 1 - j * 20   '不算合计行，剩下的行数
                If q <> 0 Then
                    For i = 0 To j - 1
                        sheet = "Sheet" & System.Convert.ToString(i + 1)
                        xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                        xlsheet.Select()
                        xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                        xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                        xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                        xlsheet.Cells(8, 21) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                        xlsheet.Cells(9, 4) = UNLOADPORT
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                            xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                        End If
                        xlsheet.Cells(9, 18) = "'" & Day(Now).ToString.PadLeft(2, "0") & "/" & Month(Now).ToString.PadLeft(2, "0") & "/" & Year(Now)

                        For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                            xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                        Next
                        For row = 0 To 19
                            For col = 0 To 18
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = ""
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = ""
                                End If
                            Next col
                        Next row
                        For row = 0 To 19
                            For col = 0 To 18
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                End If
                            Next col
                        Next row
                        xlsheet.Cells(35, 22) = "'" & i + 1 & "/" & j + 1
                        'xlsheet.Cells(33, 1) = ""
                        'xlsheet.PrintPreview()
                        'xlsheet.Cells(33, 1) = "Total"
                    Next i
                    '剩下最后一张余张
                    sheet = "Sheet" & System.Convert.ToString(j + 1)
                    xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                    xlsheet.Select()
                    xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                    xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                    xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                    xlsheet.Cells(8, 21) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                    xlsheet.Cells(9, 4) = UNLOADPORT
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                        xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                    End If
                    xlsheet.Cells(9, 18) = "'" & Day(Now).ToString.PadLeft(2, "0") & "/" & Month(Now).ToString.PadLeft(2, "0") & "/" & Year(Now)
                    For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                        xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                    Next
                    For row = 0 To 19
                        For col = 0 To 18
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = ""
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = ""
                            End If
                        Next col
                    Next row
                    For row = 0 To q - 1
                        For col = 0 To 18
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            End If
                        Next col
                    Next row
                    xlsheet.Cells(33, 5) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(3)
                    xlsheet.Cells(33, 7) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(5)
                    xlsheet.Cells(33, 9) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(7)
                    xlsheet.Cells(33, 11) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(9)
                    xlsheet.Cells(33, 13) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(11)
                    xlsheet.Cells(33, 15) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(13)
                    xlsheet.Cells(33, 17) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(15)
                    xlsheet.Cells(33, 19) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(17)
                    xlsheet.Cells(35, 22) = "'" & j + 1 & "/" & j + 1
                    'xlsheet.PrintPreview()
                Else '没有余张
                    For i = 0 To j - 2
                        sheet = "Sheet" & System.Convert.ToString(i + 1)
                        xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                        xlsheet.Select()
                        xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                        xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                        xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                        xlsheet.Cells(8, 21) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                        xlsheet.Cells(9, 4) = UNLOADPORT
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                            xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                        End If
                        xlsheet.Cells(9, 18) = "'" & Day(Now).ToString.PadLeft(2, "0") & "/" & Month(Now).ToString.PadLeft(2, "0") & "/" & Year(Now)
                        For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                            xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                        Next
                        For row = 0 To 19
                            For col = 0 To 18
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = ""
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = ""
                                End If
                            Next col
                        Next row
                        For row = 0 To 19
                            For col = 0 To 18
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                End If
                            Next col
                        Next row
                        xlsheet.Cells(35, 22) = "'" & i + 1 & "/" & j
                        'xlsheet.Cells(33, 1) = ""
                        'xlsheet.PrintPreview()
                        'xlsheet.Cells(33, 1) = "Total"
                    Next i

                    sheet = "Sheet" & j
                    xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                    xlsheet.Select()
                    xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                    xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                    xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                    xlsheet.Cells(8, 21) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                    xlsheet.Cells(9, 4) = UNLOADPORT
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                        xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                    End If
                    xlsheet.Cells(9, 18) = "'" & Day(Now).ToString.PadLeft(2, "0") & "/" & Month(Now).ToString.PadLeft(2, "0") & "/" & Year(Now)
                    For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                        xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                    Next
                    For row = 0 To 19
                        For col = 0 To 18
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = ""
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = ""
                            End If
                        Next col
                    Next row
                    For row = 0 To 19
                        For col = 0 To 18
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            End If
                        Next col
                    Next row
                    xlsheet.Cells(33, 5) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(3)
                    xlsheet.Cells(33, 7) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(5)
                    xlsheet.Cells(33, 9) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(7)
                    xlsheet.Cells(33, 11) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(9)
                    xlsheet.Cells(33, 13) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(11)
                    xlsheet.Cells(33, 15) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(13)
                    xlsheet.Cells(33, 17) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(15)
                    xlsheet.Cells(33, 19) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(17)
                    xlsheet.Cells(35, 22) = "'" & j & "/" & j
                    'xlsheet.PrintPreview()
                End If
            End If
            'xlsheet.PrintPreview()
            'KillExcelProcess()
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
            KillExcelProcess()
        End Try
    End Sub

    Private Sub eng_export_5()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer
        Dim dw As New DataView
        Dim i As Integer  '移动自增数
        Dim j As Integer  '整张数
        Dim q As Integer   '余数
        Dim ds_eng As New DataSet
        Dim sheet As String
        Try
            RecordExcelProcess()
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "货物分舱单5.xls", pathstr + "Report.xls")
            Filepath = pathstr + "Report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            sheet = "Sheet1"
            xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
            xlapp.DisplayAlerts = True
            xlsheet.Application.Visible = True
            xlsheet.Select()


            xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
            xlsheet.Cells(9, 4) = UNLOADPORT
            xlsheet.Cells(8, 20) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
            xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
            End If
            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
            End If
            'xlsheet.Cells(9, 18) = "'" & Day(Now).ToString.PadLeft(2, "0") & "/" & Month(Now).ToString.PadLeft(2, "0") & "/" & Year(Now)


            For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
            Next

            If DS_DO.Tables(1).Rows.Count <= 21 Then  '单张
                For row = 0 To DS_DO.Tables(1).Rows.Count - 2
                    For col = 0 To 18
                        If col > 1 Then
                            xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row)(col)
                        Else
                            xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row)(col)
                        End If
                    Next col
                Next row
                xlsheet.Cells(33, 5) = DS_DO.Tables(1).Rows(row)(3)
                xlsheet.Cells(33, 7) = DS_DO.Tables(1).Rows(row)(5)
                xlsheet.Cells(33, 9) = DS_DO.Tables(1).Rows(row)(7)
                xlsheet.Cells(33, 11) = DS_DO.Tables(1).Rows(row)(9)
                xlsheet.Cells(33, 13) = DS_DO.Tables(1).Rows(row)(11)
                xlsheet.Cells(33, 15) = DS_DO.Tables(1).Rows(row)(13)
                xlsheet.Cells(33, 17) = DS_DO.Tables(1).Rows(row)(15)
                xlsheet.Cells(33, 19) = DS_DO.Tables(1).Rows(row)(17)
                xlsheet.Cells(35, 20) = "'" & "1/1"
                'xlsheet.PrintPreview()
            Else  '多张
                j = (DS_DO.Tables(1).Rows.Count - DS_DO.Tables(1).Rows.Count Mod 20) / 20   '整张数
                q = DS_DO.Tables(1).Rows.Count - 1 - j * 20   '不算合计行，剩下的行数
                If q <> 0 Then
                    For i = 0 To j - 1
                        sheet = "Sheet" & System.Convert.ToString(i + 1)
                        xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                        xlsheet.Select()

                        xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                        xlsheet.Cells(9, 4) = UNLOADPORT
                        xlsheet.Cells(8, 20) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                        xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                        xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                            xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                        End If
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                            xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                        End If

                        For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                            xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                        Next
                        For row = 0 To 19
                            For col = 0 To 18
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = ""
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = ""
                                End If
                            Next col
                        Next row
                        For row = 0 To 19
                            For col = 0 To 18
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                End If
                            Next col
                        Next row
                        xlsheet.Cells(35, 20) = "'" & i + 1 & "/" & j + 1
                        'xlsheet.Cells(33, 1) = ""
                        'xlsheet.PrintPreview()
                        'xlsheet.Cells(33, 1) = "Total"
                    Next i
                    '剩下最后一张余张
                    sheet = "Sheet" & System.Convert.ToString(j + 1)
                    xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                    xlsheet.Select()


                    xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                    xlsheet.Cells(9, 4) = UNLOADPORT
                    xlsheet.Cells(8, 20) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                    xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                    xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                        xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                    End If
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                        xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                    End If


                    For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                        xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                    Next
                    For row = 0 To 19
                        For col = 0 To 18
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = ""
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = ""
                            End If
                        Next col
                    Next row
                    For row = 0 To q - 1
                        For col = 0 To 18
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            End If
                        Next col
                    Next row
                    xlsheet.Cells(33, 5) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(3)
                    xlsheet.Cells(33, 7) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(5)
                    xlsheet.Cells(33, 9) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(7)
                    xlsheet.Cells(33, 11) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(9)
                    xlsheet.Cells(33, 13) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(11)
                    xlsheet.Cells(33, 15) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(13)
                    xlsheet.Cells(33, 17) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(15)
                    xlsheet.Cells(33, 19) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(17)
                    xlsheet.Cells(35, 20) = "'" & j + 1 & "/" & j + 1
                    'xlsheet.PrintPreview()
                Else '没有余张
                    For i = 0 To j - 2
                        sheet = "Sheet" & System.Convert.ToString(i + 1)
                        xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                        xlsheet.Select()

                        xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                        xlsheet.Cells(9, 4) = UNLOADPORT
                        xlsheet.Cells(8, 20) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                        xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                        xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                            xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                        End If
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                            xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                        End If

                        For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                            xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                        Next
                        For row = 0 To 19
                            For col = 0 To 18
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = ""
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = ""
                                End If
                            Next col
                        Next row
                        For row = 0 To 19
                            For col = 0 To 18
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                End If
                            Next col
                        Next row
                        xlsheet.Cells(35, 20) = "'" & i + 1 & "/" & j
                        'xlsheet.Cells(33, 1) = ""
                        'xlsheet.PrintPreview()
                        'xlsheet.Cells(33, 1) = "Total"
                    Next i

                    sheet = "Sheet" & j
                    xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                    xlsheet.Select()

                    xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                    xlsheet.Cells(9, 4) = UNLOADPORT
                    xlsheet.Cells(8, 20) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                    xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                    xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                        xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                    End If
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                        xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                    End If


                    For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                        xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                    Next
                    For row = 0 To 19
                        For col = 0 To 18
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = ""
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = ""
                            End If
                        Next col
                    Next row
                    For row = 0 To 19
                        For col = 0 To 18
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            End If
                        Next col
                    Next row
                    xlsheet.Cells(33, 5) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(3)
                    xlsheet.Cells(33, 7) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(5)
                    xlsheet.Cells(33, 9) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(7)
                    xlsheet.Cells(33, 11) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(9)
                    xlsheet.Cells(33, 13) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(11)
                    xlsheet.Cells(33, 15) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(13)
                    xlsheet.Cells(33, 17) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(15)
                    xlsheet.Cells(33, 19) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(17)
                    xlsheet.Cells(35, 20) = "'" & j & "/" & j
                    'xlsheet.PrintPreview()
                End If
            End If
            'xlsheet.PrintPreview()
            'KillExcelProcess()
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
            KillExcelProcess()
        End Try
    End Sub

    Private Sub eng_export_7()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer
        Dim dw As New DataView
        Dim i As Integer  '移动自增数
        Dim j As Integer  '整张数
        Dim q As Integer   '余数
        Dim ds_eng As New DataSet
        Dim sheet As String
        Try
            RecordExcelProcess()
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "货物分舱单7.xls", pathstr + "Report.xls")
            Filepath = pathstr + "Report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            sheet = "Sheet1"
            xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
            xlapp.DisplayAlerts = True
            xlsheet.Application.Visible = True
            xlsheet.Select()

            xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
            xlsheet.Cells(9, 4) = UNLOADPORT
            xlsheet.Cells(8, 23) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
            xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
            End If
            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
            End If

            For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
            Next

            If DS_DO.Tables(1).Rows.Count <= 26 Then  '单张
                For row = 0 To DS_DO.Tables(1).Rows.Count - 2
                    For col = 0 To 22
                        If col > 1 Then
                            xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row)(col)
                        Else
                            xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row)(col)
                        End If
                    Next col
                Next row
                xlsheet.Cells(38, 5) = DS_DO.Tables(1).Rows(row)(3)
                xlsheet.Cells(38, 7) = DS_DO.Tables(1).Rows(row)(5)
                xlsheet.Cells(38, 9) = DS_DO.Tables(1).Rows(row)(7)
                xlsheet.Cells(38, 11) = DS_DO.Tables(1).Rows(row)(9)
                xlsheet.Cells(38, 13) = DS_DO.Tables(1).Rows(row)(11)
                xlsheet.Cells(38, 15) = DS_DO.Tables(1).Rows(row)(13)
                xlsheet.Cells(38, 17) = DS_DO.Tables(1).Rows(row)(15)
                xlsheet.Cells(38, 19) = DS_DO.Tables(1).Rows(row)(17)
                xlsheet.Cells(38, 21) = DS_DO.Tables(1).Rows(row)(19)
                xlsheet.Cells(38, 23) = DS_DO.Tables(1).Rows(row)(21)
                xlsheet.Cells(40, 24) = "'" & "1/1"
                'xlsheet.PrintPreview()
            Else  '多张
                j = (DS_DO.Tables(1).Rows.Count - DS_DO.Tables(1).Rows.Count Mod 25) / 25   '整张数
                q = DS_DO.Tables(1).Rows.Count - 1 - j * 25   '不算合计行，剩下的行数
                If q <> 0 Then
                    For i = 0 To j - 1
                        sheet = "Sheet" & System.Convert.ToString(i + 1)
                        xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                        xlsheet.Select()

                        xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                        xlsheet.Cells(9, 4) = UNLOADPORT
                        xlsheet.Cells(8, 20) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                        xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                        xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                            xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                        End If
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                            xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                        End If

                        For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                            xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                        Next
                        For row = 0 To 24
                            For col = 0 To 22
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = ""
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = ""
                                End If
                            Next col
                        Next row
                        For row = 0 To 24
                            For col = 0 To 22
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                End If
                            Next col
                        Next row
                        xlsheet.Cells(40, 24) = "'" & i + 1 & "/" & j + 1

                        'xlsheet.Cells(33, 1) = "Total"
                    Next i
                    '剩下最后一张余张
                    sheet = "Sheet" & System.Convert.ToString(j + 1)
                    xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                    xlsheet.Select()

                    xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                    xlsheet.Cells(9, 4) = UNLOADPORT
                    xlsheet.Cells(8, 23) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                    xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                    xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                        xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                    End If
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                        xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                    End If

                    For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                        xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                    Next
                    For row = 0 To 24
                        For col = 0 To 22
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = ""
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = ""
                            End If
                        Next col
                    Next row
                    For row = 0 To q - 1
                        For col = 0 To 22
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            End If
                        Next col
                    Next row
                    xlsheet.Cells(38, 5) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(3)
                    xlsheet.Cells(38, 7) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(5)
                    xlsheet.Cells(38, 9) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(7)
                    xlsheet.Cells(38, 11) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(9)
                    xlsheet.Cells(38, 13) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(11)
                    xlsheet.Cells(38, 15) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(13)
                    xlsheet.Cells(38, 17) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(15)
                    xlsheet.Cells(38, 19) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(17)
                    xlsheet.Cells(38, 21) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(19)
                    xlsheet.Cells(38, 23) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(21)
                    xlsheet.Cells(40, 24) = "'" & j + 1 & "/" & j + 1
                    'xlsheet.PrintPreview()
                Else '没有余张
                    For i = 0 To j - 2
                        sheet = "Sheet" & System.Convert.ToString(i + 1)
                        xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                        xlsheet.Select()

                        xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                        xlsheet.Cells(9, 4) = UNLOADPORT
                        xlsheet.Cells(8, 20) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                        xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                        xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                            xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                        End If
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                            xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                        End If

                        For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                            xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                        Next
                        For row = 0 To 24
                            For col = 0 To 22
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = ""
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = ""
                                End If
                            Next col
                        Next row
                        For row = 0 To 24
                            For col = 0 To 22
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                End If
                            Next col
                        Next row
                        xlsheet.Cells(40, 24) = "'" & i + 1 & "/" & j
                        'xlsheet.Cells(33, 1) = ""
                        'xlsheet.PrintPreview()
                        'xlsheet.Cells(33, 1) = "Total"
                    Next i

                    sheet = "Sheet" & j
                    xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                    xlsheet.Select()

                    xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                    xlsheet.Cells(9, 4) = UNLOADPORT
                    xlsheet.Cells(8, 20) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                    xlsheet.Cells(8, 7) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                    xlsheet.Cells(8, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                        xlsheet.Cells(9, 10) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                    End If
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                        xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                    End If

                    For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                        xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                    Next
                    For row = 0 To 24
                        For col = 0 To 22
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = ""
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = ""
                            End If
                        Next col
                    Next row
                    For row = 0 To 24
                        For col = 0 To 22
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            End If
                        Next col
                    Next row
                    xlsheet.Cells(38, 5) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(3)
                    xlsheet.Cells(38, 7) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(5)
                    xlsheet.Cells(38, 9) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(7)
                    xlsheet.Cells(38, 11) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(9)
                    xlsheet.Cells(38, 13) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(11)
                    xlsheet.Cells(38, 15) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(13)
                    xlsheet.Cells(38, 17) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(15)
                    xlsheet.Cells(38, 19) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(17)
                    xlsheet.Cells(38, 21) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(19)
                    xlsheet.Cells(38, 23) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(21)
                    xlsheet.Cells(40, 24) = "'" & j & "/" & j
                    'xlsheet.PrintPreview()
                End If
            End If
            'xlsheet.PrintPreview()
            'KillExcelProcess()
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
            KillExcelProcess()
        End Try
    End Sub

    Private Sub eng_export_10()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer
        Dim dw As New DataView
        Dim i As Integer  '移动自增数
        Dim j As Integer  '整张数
        Dim q As Integer   '余数
        Dim ds_eng As New DataSet
        Dim sheet As String
        Try
            RecordExcelProcess()
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "货物分舱单10.xls", pathstr + "Report.xls")
            Filepath = pathstr + "Report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            sheet = "Sheet1"
            xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
            xlapp.DisplayAlerts = True
            xlsheet.Application.Visible = True
            xlsheet.Select()


            xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
            xlsheet.Cells(9, 4) = UNLOADPORT
            xlsheet.Cells(8, 27) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
            xlsheet.Cells(8, 8) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            xlsheet.Cells(8, 17) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                xlsheet.Cells(9, 13) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
            End If
            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                xlsheet.Cells(9, 24) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
            End If

            For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
            Next

            If DS_DO.Tables(1).Rows.Count <= 31 Then  '单张
                For row = 0 To DS_DO.Tables(1).Rows.Count - 2
                    For col = 0 To 28
                        If col > 1 Then
                            xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row)(col)
                        Else
                            xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row)(col)
                        End If
                    Next col
                Next row
                xlsheet.Cells(43, 5) = DS_DO.Tables(1).Rows(row)(3)
                xlsheet.Cells(43, 7) = DS_DO.Tables(1).Rows(row)(5)
                xlsheet.Cells(43, 9) = DS_DO.Tables(1).Rows(row)(7)
                xlsheet.Cells(43, 11) = DS_DO.Tables(1).Rows(row)(9)
                xlsheet.Cells(43, 13) = DS_DO.Tables(1).Rows(row)(11)
                xlsheet.Cells(43, 15) = DS_DO.Tables(1).Rows(row)(13)
                xlsheet.Cells(43, 17) = DS_DO.Tables(1).Rows(row)(15)
                xlsheet.Cells(43, 19) = DS_DO.Tables(1).Rows(row)(17)
                xlsheet.Cells(43, 21) = DS_DO.Tables(1).Rows(row)(19)
                xlsheet.Cells(43, 23) = DS_DO.Tables(1).Rows(row)(21)
                xlsheet.Cells(43, 25) = DS_DO.Tables(1).Rows(row)(23)
                xlsheet.Cells(43, 27) = DS_DO.Tables(1).Rows(row)(25)
                xlsheet.Cells(43, 29) = DS_DO.Tables(1).Rows(row)(27)
                xlsheet.Cells(45, 30) = "'" & "1/1"
                'xlsheet.PrintPreview()
            Else  '多张
                j = (DS_DO.Tables(1).Rows.Count - DS_DO.Tables(1).Rows.Count Mod 30) / 30   '整张数
                q = DS_DO.Tables(1).Rows.Count - 1 - j * 30   '不算合计行，剩下的行数
                If q <> 0 Then
                    For i = 0 To j - 1
                        sheet = "Sheet" & System.Convert.ToString(i + 1)
                        xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                        xlsheet.Select()

                        xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                        xlsheet.Cells(9, 4) = UNLOADPORT
                        xlsheet.Cells(8, 27) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                        xlsheet.Cells(8, 8) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                        xlsheet.Cells(8, 17) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                            xlsheet.Cells(9, 13) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                        End If
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                            xlsheet.Cells(9, 24) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                        End If

                        For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                            xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                        Next
                        For row = 0 To 29
                            For col = 0 To 28
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = ""
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = ""
                                End If
                            Next col
                        Next row
                        For row = 0 To 29
                            For col = 0 To 28
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                End If
                            Next col
                        Next row
                        xlsheet.Cells(45, 30) = "'" & i + 1 & "/" & j + 1
                        'xlsheet.Cells(33, 1) = ""
                        'xlsheet.PrintPreview()
                        'xlsheet.Cells(33, 1) = "Total"
                    Next i
                    '剩下最后一张余张
                    sheet = "Sheet" & System.Convert.ToString(j + 1)
                    xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                    xlsheet.Select()


                    xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                    xlsheet.Cells(9, 4) = UNLOADPORT
                    xlsheet.Cells(8, 27) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                    xlsheet.Cells(8, 8) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                    xlsheet.Cells(8, 17) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                        xlsheet.Cells(9, 13) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                    End If
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                        xlsheet.Cells(9, 24) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                    End If

                    For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                        xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                    Next
                    For row = 0 To 29
                        For col = 0 To 28
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = ""
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = ""
                            End If
                        Next col
                    Next row
                    For row = 0 To q - 1
                        For col = 0 To 28
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            End If
                        Next col
                    Next row
                    xlsheet.Cells(43, 5) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(3)
                    xlsheet.Cells(43, 7) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(5)
                    xlsheet.Cells(43, 9) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(7)
                    xlsheet.Cells(43, 11) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(9)
                    xlsheet.Cells(43, 13) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(11)
                    xlsheet.Cells(43, 15) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(13)
                    xlsheet.Cells(43, 17) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(15)
                    xlsheet.Cells(43, 19) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(17)
                    xlsheet.Cells(43, 21) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(19)
                    xlsheet.Cells(43, 23) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(21)
                    xlsheet.Cells(43, 25) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(23)
                    xlsheet.Cells(43, 27) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(25)
                    xlsheet.Cells(43, 29) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(27)
                    xlsheet.Cells(45, 30) = "'" & j + 1 & "/" & j + 1
                    'xlsheet.PrintPreview()
                Else '没有余张
                    For i = 0 To j - 2
                        sheet = "Sheet" & System.Convert.ToString(i + 1)
                        xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                        xlsheet.Select()


                        xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                        xlsheet.Cells(9, 4) = UNLOADPORT
                        xlsheet.Cells(8, 27) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                        xlsheet.Cells(8, 8) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                        xlsheet.Cells(8, 17) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                            xlsheet.Cells(9, 13) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                        End If
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                            xlsheet.Cells(9, 24) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                        End If

                        For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                            xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                        Next
                        For row = 0 To 29
                            For col = 0 To 28
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = ""
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = ""
                                End If
                            Next col
                        Next row
                        For row = 0 To 29
                            For col = 0 To 28
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                End If
                            Next col
                        Next row
                        xlsheet.Cells(45, 30) = "'" & i + 1 & "/" & j
                        'xlsheet.Cells(33, 1) = ""
                        'xlsheet.PrintPreview()
                        'xlsheet.Cells(33, 1) = "Total"
                    Next i

                    sheet = "Sheet" & j
                    xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                    xlsheet.Select()


                    xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                    xlsheet.Cells(9, 4) = UNLOADPORT
                    xlsheet.Cells(8, 27) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                    xlsheet.Cells(8, 8) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                    xlsheet.Cells(8, 17) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                        xlsheet.Cells(9, 13) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                    End If
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                        xlsheet.Cells(9, 24) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                    End If

                    For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                        xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                    Next
                    For row = 0 To 29
                        For col = 0 To 28
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = ""
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = ""
                            End If
                        Next col
                    Next row
                    For row = 0 To 29
                        For col = 0 To 28
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            End If
                        Next col
                    Next row
                    xlsheet.Cells(43, 5) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(3)
                    xlsheet.Cells(43, 7) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(5)
                    xlsheet.Cells(43, 9) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(7)
                    xlsheet.Cells(43, 11) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(9)
                    xlsheet.Cells(43, 13) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(11)
                    xlsheet.Cells(43, 15) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(13)
                    xlsheet.Cells(43, 17) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(15)
                    xlsheet.Cells(43, 19) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(17)
                    xlsheet.Cells(43, 21) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(19)
                    xlsheet.Cells(43, 23) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(21)
                    xlsheet.Cells(43, 25) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(23)
                    xlsheet.Cells(43, 27) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(25)
                    xlsheet.Cells(43, 29) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(27)
                    xlsheet.Cells(45, 30) = "'" & j & "/" & j
                    'xlsheet.PrintPreview()
                End If
            End If
            'xlsheet.PrintPreview()
            'KillExcelProcess()
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
            KillExcelProcess()
        End Try
    End Sub

    Private Sub eng_export_15()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer
        Dim dw As New DataView
        Dim i As Integer  '移动自增数
        Dim j As Integer  '整张数
        Dim q As Integer   '余数
        Dim ds_eng As New DataSet
        Dim sheet As String
        Try
            RecordExcelProcess()
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "货物分舱单15.xls", pathstr + "Report.xls")
            Filepath = pathstr + "Report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            sheet = "Sheet1"
            xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
            xlapp.DisplayAlerts = True
            xlsheet.Application.Visible = True
            xlsheet.Select()


            xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
            xlsheet.Cells(9, 4) = UNLOADPORT
            xlsheet.Cells(8, 37) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
            xlsheet.Cells(8, 14) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            xlsheet.Cells(8, 25) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
            End If
            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                xlsheet.Cells(9, 34) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
            End If

            For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
            Next

            If DS_DO.Tables(1).Rows.Count <= 31 Then  '单张
                For row = 0 To DS_DO.Tables(1).Rows.Count - 2
                    For col = 0 To 38
                        If col > 1 Then
                            xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row)(col)
                        Else
                            xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row)(col)
                        End If
                    Next col
                Next row
                xlsheet.Cells(43, 5) = DS_DO.Tables(1).Rows(row)(3)
                xlsheet.Cells(43, 7) = DS_DO.Tables(1).Rows(row)(5)
                xlsheet.Cells(43, 9) = DS_DO.Tables(1).Rows(row)(7)
                xlsheet.Cells(43, 11) = DS_DO.Tables(1).Rows(row)(9)
                xlsheet.Cells(43, 13) = DS_DO.Tables(1).Rows(row)(11)
                xlsheet.Cells(43, 15) = DS_DO.Tables(1).Rows(row)(13)
                xlsheet.Cells(43, 17) = DS_DO.Tables(1).Rows(row)(15)
                xlsheet.Cells(43, 19) = DS_DO.Tables(1).Rows(row)(17)
                xlsheet.Cells(43, 21) = DS_DO.Tables(1).Rows(row)(19)
                xlsheet.Cells(43, 23) = DS_DO.Tables(1).Rows(row)(21)
                xlsheet.Cells(43, 25) = DS_DO.Tables(1).Rows(row)(23)
                xlsheet.Cells(43, 27) = DS_DO.Tables(1).Rows(row)(25)
                xlsheet.Cells(43, 29) = DS_DO.Tables(1).Rows(row)(27)
                xlsheet.Cells(43, 31) = DS_DO.Tables(1).Rows(row)(29)
                xlsheet.Cells(43, 33) = DS_DO.Tables(1).Rows(row)(31)
                xlsheet.Cells(43, 35) = DS_DO.Tables(1).Rows(row)(33)
                xlsheet.Cells(43, 37) = DS_DO.Tables(1).Rows(row)(35)
                xlsheet.Cells(43, 39) = DS_DO.Tables(1).Rows(row)(37)
                xlsheet.Cells(45, 40) = "'" & "1/1"
                'xlsheet.PrintPreview()
            Else  '多张
                j = (DS_DO.Tables(1).Rows.Count - DS_DO.Tables(1).Rows.Count Mod 30) / 30   '整张数
                q = DS_DO.Tables(1).Rows.Count - 1 - j * 30   '不算合计行，剩下的行数
                If q <> 0 Then
                    For i = 0 To j - 1
                        sheet = "Sheet" & System.Convert.ToString(i + 1)
                        xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                        xlsheet.Select()

                        xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                        xlsheet.Cells(9, 4) = UNLOADPORT
                        xlsheet.Cells(8, 37) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                        xlsheet.Cells(8, 14) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                        xlsheet.Cells(8, 25) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                            xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                        End If
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                            xlsheet.Cells(9, 34) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                        End If

                        For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                            xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                        Next
                        For row = 0 To 29
                            For col = 0 To 38
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = ""
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = ""
                                End If
                            Next col
                        Next row
                        For row = 0 To 29
                            For col = 0 To 38
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                End If
                            Next col
                        Next row
                        xlsheet.Cells(45, 30) = "'" & i + 1 & "/" & j + 1
                        'xlsheet.Cells(33, 1) = ""
                        'xlsheet.PrintPreview()
                        'xlsheet.Cells(33, 1) = "Total"
                    Next i
                    '剩下最后一张余张
                    sheet = "Sheet" & System.Convert.ToString(j + 1)
                    xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                    xlsheet.Select()


                    xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                    xlsheet.Cells(9, 4) = UNLOADPORT
                    xlsheet.Cells(8, 37) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                    xlsheet.Cells(8, 14) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                    xlsheet.Cells(8, 25) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                        xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                    End If
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) = False Then
                        xlsheet.Cells(9, 34) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_END"))
                    End If

                    For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                        xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                    Next
                    For row = 0 To 29
                        For col = 0 To 38
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = ""
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = ""
                            End If
                        Next col
                    Next row
                    For row = 0 To q - 1
                        For col = 0 To 38
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            End If
                        Next col
                    Next row
                    xlsheet.Cells(43, 5) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(3)
                    xlsheet.Cells(43, 7) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(5)
                    xlsheet.Cells(43, 9) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(7)
                    xlsheet.Cells(43, 11) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(9)
                    xlsheet.Cells(43, 13) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(11)
                    xlsheet.Cells(43, 15) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(13)
                    xlsheet.Cells(43, 17) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(15)
                    xlsheet.Cells(43, 19) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(17)
                    xlsheet.Cells(43, 21) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(19)
                    xlsheet.Cells(43, 23) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(21)
                    xlsheet.Cells(43, 25) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(23)
                    xlsheet.Cells(43, 27) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(25)
                    xlsheet.Cells(43, 29) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(27)
                    xlsheet.Cells(43, 31) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(29)
                    xlsheet.Cells(43, 33) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(31)
                    xlsheet.Cells(43, 35) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(33)
                    xlsheet.Cells(43, 37) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(35)
                    xlsheet.Cells(43, 39) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(37)
                    xlsheet.Cells(45, 30) = "'" & j + 1 & "/" & j + 1
                    'xlsheet.PrintPreview()
                Else '没有余张
                    For i = 0 To j - 2
                        sheet = "Sheet" & System.Convert.ToString(i + 1)
                        xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                        xlsheet.Select()


                        xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                        xlsheet.Cells(9, 4) = UNLOADPORT
                        xlsheet.Cells(8, 37) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                        xlsheet.Cells(8, 14) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                        xlsheet.Cells(8, 25) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                        If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                            xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                        End If
                        xlsheet.Cells(9, 34) = "'" & Day(Now).ToString.PadLeft(2, "0") & "/" & Month(Now).ToString.PadLeft(2, "0") & "/" & Year(Now)


                        For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                            xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                        Next
                        For row = 0 To 29
                            For col = 0 To 38
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = ""
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = ""
                                End If
                            Next col
                        Next row
                        For row = 0 To 29
                            For col = 0 To 38
                                If col > 1 Then
                                    xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                Else
                                    xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                                End If
                            Next col
                        Next row
                        xlsheet.Cells(45, 40) = "'" & i + 1 & "/" & j
                        'xlsheet.Cells(33, 1) = ""
                        'xlsheet.PrintPreview()
                        'xlsheet.Cells(33, 1) = "Total"
                    Next i

                    sheet = "Sheet" & j
                    xlsheet = CType(xlbook.Worksheets("" & sheet & ""), Excel.Worksheet)
                    xlsheet.Select()


                    xlsheet.Cells(8, 3) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
                    xlsheet.Cells(9, 4) = UNLOADPORT
                    xlsheet.Cells(8, 37) = "'No." & DS_DO.Tables(2).Rows(0).Item("berth")
                    xlsheet.Cells(8, 14) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
                    xlsheet.Cells(8, 25) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
                    If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                        xlsheet.Cells(9, 18) = "'" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")).ToString.PadLeft(2, "0") & "/" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
                    End If
                    xlsheet.Cells(9, 34) = "'" & Day(Now).ToString.PadLeft(2, "0") & "/" & Month(Now).ToString.PadLeft(2, "0") & "/" & Year(Now)


                    For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                        xlsheet.Cells(11, 9 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
                    Next
                    For row = 0 To 29
                        For col = 0 To 38
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = ""
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = ""
                            End If
                        Next col
                    Next row
                    For row = 0 To 29
                        For col = 0 To 38
                            If col > 1 Then
                                xlsheet.Cells(13 + row, 2 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            Else
                                xlsheet.Cells(13 + row, 1 + col) = DS_DO.Tables(1).Rows(row + i * 20)(col)
                            End If
                        Next col
                    Next row
                    xlsheet.Cells(43, 5) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(3)
                    xlsheet.Cells(43, 7) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(5)
                    xlsheet.Cells(43, 9) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(7)
                    xlsheet.Cells(43, 11) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(9)
                    xlsheet.Cells(43, 13) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(11)
                    xlsheet.Cells(43, 15) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(13)
                    xlsheet.Cells(43, 17) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(15)
                    xlsheet.Cells(43, 19) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(17)
                    xlsheet.Cells(43, 21) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(19)
                    xlsheet.Cells(43, 23) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(21)
                    xlsheet.Cells(43, 25) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(23)
                    xlsheet.Cells(43, 27) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(25)
                    xlsheet.Cells(43, 29) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(27)
                    xlsheet.Cells(43, 31) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(29)
                    xlsheet.Cells(43, 33) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(31)
                    xlsheet.Cells(43, 35) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(33)
                    xlsheet.Cells(43, 37) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(35)
                    xlsheet.Cells(43, 39) = DS_DO.Tables(1).Rows(DS_DO.Tables(1).Rows.Count - 1)(37)
                    xlsheet.Cells(45, 30) = "'" & j & "/" & j
                    'xlsheet.PrintPreview()
                End If
            End If
            'xlsheet.PrintPreview()
            'KillExcelProcess()
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
            KillExcelProcess()
        End Try
    End Sub

    'Private Sub bay_eng()
    '    Dim xlapp As Excel.Application
    '    Dim xlbook As Excel.Workbook
    '    Dim xlsheet As Excel.Worksheet
    '    Dim pathstr As String
    '    Dim Filepath As String
    '    Dim col, row As Integer
    '    Dim i As Integer
    '    Dim j As Integer
    '    Dim q As Integer
    '    Dim k As Integer
    '    Dim x1 As Integer
    '    Dim x2 As Integer
    '    Dim x3 As Integer
    '    Dim x4 As Integer
    '    Dim x5 As Integer
    '    Dim x6 As Integer
    '    Try
    '        If ds_bay.Tables(0).Rows.Count > 0 Then

    '            If ds_bay.Tables(0).Rows.Count <= 30 Then  '单张
    '                RecordExcelProcess()
    '                pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
    '                pathstr = substr(pathstr)
    '                FileCopy(pathstr + "Report_zlp3.xls", pathstr + "Report.xls")
    '                Filepath = pathstr + "report.xls"
    '                xlapp = CType(CreateObject("excel.application"), Excel.Application)
    '                xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
    '                xlsheet = CType(xlbook.Worksheets("理箱单（E）"), Excel.Worksheet)
    '                xlapp.DisplayAlerts = False
    '                xlsheet.Application.Visible = False
    '                xlsheet.Select()

    '                xlsheet.Cells(11, 2) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")))
    '                xlsheet.Cells(11, 5) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("Voyage"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("Voyage")))
    '                xlsheet.Cells(11, 9) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("berthno"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("berthno")))

    '                xlsheet.Cells(11, 14) = Trim(Txtseachbay.Text)

    '                If ds_bay.Tables(0).Rows.Count <= 15 Then
    '                    For row = 0 To ds_bay.Tables(0).Rows.Count - 1
    '                        xlsheet.Cells(16 + row, 1) = ds_bay.Tables(0).Rows(row)("CONTAINER_NO")
    '                        xlsheet.Cells(16 + row, 3) = ds_bay.Tables(0).Rows(row)("SEALNO")
    '                        xlsheet.Cells(16 + row, 4) = ds_bay.Tables(0).Rows(row)("SIZE_CON")
    '                        xlsheet.Cells(16 + row, 5) = ds_bay.Tables(0).Rows(row)("FULLOREMPTY")
    '                        If ds_bay.Tables(0).Rows(row)("FULLOREMPTY") = "E" Then
    '                            xlsheet.Cells(16 + row, 3) = "────"
    '                        End If
    '                    Next row
    '                ElseIf ds_bay.Tables(0).Rows.Count > 15 And ds_bay.Tables(0).Rows.Count <= 30 Then
    '                    For row = 0 To 14
    '                        xlsheet.Cells(16 + row, 1) = ds_bay.Tables(0).Rows(row)("CONTAINER_NO")
    '                        xlsheet.Cells(16 + row, 3) = ds_bay.Tables(0).Rows(row)("SEALNO")
    '                        xlsheet.Cells(16 + row, 4) = ds_bay.Tables(0).Rows(row)("SIZE_CON")
    '                        xlsheet.Cells(16 + row, 5) = ds_bay.Tables(0).Rows(row)("FULLOREMPTY")
    '                        If ds_bay.Tables(0).Rows(row)("FULLOREMPTY") = "E" Then
    '                            xlsheet.Cells(16 + row, 3) = "────"
    '                        End If
    '                    Next row
    '                    For row = 15 To ds_bay.Tables(0).Rows.Count - 1
    '                        xlsheet.Cells(1 + row, 7) = ds_bay.Tables(0).Rows(row)("CONTAINER_NO")
    '                        xlsheet.Cells(1 + row, 11) = ds_bay.Tables(0).Rows(row)("SEALNO")
    '                        xlsheet.Cells(1 + row, 13) = ds_bay.Tables(0).Rows(row)("SIZE_CON")
    '                        xlsheet.Cells(1 + row, 15) = ds_bay.Tables(0).Rows(row)("FULLOREMPTY")
    '                        If ds_bay.Tables(0).Rows(row)("FULLOREMPTY") = "E" Then
    '                            xlsheet.Cells(1 + row, 11) = "────"
    '                        End If
    '                    Next row
    '                End If
    '                x1 = 0
    '                x2 = 0
    '                x3 = 0
    '                x4 = 0
    '                x5 = 0
    '                x6 = 0
    '                For k = 0 To ds_bay.Tables(0).Rows.Count - 1
    '                    If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 20 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
    '                        x1 += 1
    '                    End If
    '                    If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 20 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
    '                        x2 += 1
    '                    End If
    '                    If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 40 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
    '                        x3 += 1
    '                    End If
    '                    If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 40 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
    '                        x4 += 1
    '                    End If
    '                    If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 45 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
    '                        x5 += 1
    '                    End If
    '                    If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 45 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
    '                        x6 += 1
    '                    End If
    '                Next
    '                xlsheet.Cells(32, 12) = x1
    '                xlsheet.Cells(33, 12) = x2
    '                xlsheet.Cells(34, 12) = x3
    '                xlsheet.Cells(35, 12) = x4
    '                xlsheet.Cells(32, 15) = x5
    '                xlsheet.Cells(33, 15) = x6
    '                xlsheet.Cells(35, 15) = ds_bay.Tables(0).Rows.Count
    '                'xlsheet.PrintPreview()
    '                xlsheet.PrintOut()
    '                KillExcelProcess()
    '            ElseIf ds_bay.Tables(0).Rows.Count > 30 Then '多张
    '                j = ds_bay.Tables(0).Rows.Count / 30    '整张J张
    '                q = ds_bay.Tables(0).Rows.Count - j * 30 '余数
    '                RecordExcelProcess()
    '                pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
    '                pathstr = substr(pathstr)
    '                FileCopy(pathstr + "Report_zlp3.xls", pathstr + "Report.xls")
    '                Filepath = pathstr + "report.xls"
    '                xlapp = CType(CreateObject("excel.application"), Excel.Application)
    '                xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
    '                For i = 0 To j - 1

    '                    If i = 0 Then
    '                        xlsheet = CType(xlbook.Worksheets("理箱单（E）1"), Excel.Worksheet)
    '                    End If
    '                    If i = 1 Then
    '                        xlsheet = CType(xlbook.Worksheets("理箱单（E）2"), Excel.Worksheet)
    '                    End If
    '                    If i = 2 Then
    '                        xlsheet = CType(xlbook.Worksheets("理箱单（E）3"), Excel.Worksheet)
    '                    End If
    '                    If i = 3 Then
    '                        xlsheet = CType(xlbook.Worksheets("理箱单（E）4"), Excel.Worksheet)
    '                    End If
    '                    If i = 4 Then
    '                        xlsheet = CType(xlbook.Worksheets("理箱单（E）5"), Excel.Worksheet)
    '                    End If
    '                    If i = 5 Then
    '                        xlsheet = CType(xlbook.Worksheets("理箱单（E）6"), Excel.Worksheet)
    '                    End If
    '                    If i = 6 Then
    '                        xlsheet = CType(xlbook.Worksheets("理箱单（E）7"), Excel.Worksheet)
    '                    End If
    '                    If i = 7 Then
    '                        xlsheet = CType(xlbook.Worksheets("理箱单（E）8"), Excel.Worksheet)
    '                    End If
    '                    If i = 8 Then
    '                        xlsheet = CType(xlbook.Worksheets("理箱单（E）9"), Excel.Worksheet)
    '                    End If
    '                    If i = 9 Then
    '                        xlsheet = CType(xlbook.Worksheets("理箱单（E）10"), Excel.Worksheet)
    '                    End If
    '                    If i = 10 Then
    '                        xlsheet = CType(xlbook.Worksheets("理箱单（E）11"), Excel.Worksheet)
    '                    End If
    '                    If i = 11 Then
    '                        xlsheet = CType(xlbook.Worksheets("理箱单（E）12"), Excel.Worksheet)
    '                    End If

    '                    xlapp.DisplayAlerts = False
    '                    xlsheet.Application.Visible = False
    '                    xlsheet.Select()

    '                    xlsheet.Cells(11, 2) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")))
    '                    xlsheet.Cells(11, 5) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("Voyage"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("Voyage")))
    '                    xlsheet.Cells(11, 9) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("berthno"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("berthno")))

    '                    xlsheet.Cells(11, 14) = Trim(Txtseachbay.Text)

    '                    For row = 0 To 14
    '                        xlsheet.Cells(16 + row, 1) = ds_bay.Tables(0).Rows(row + i * 30)("CONTAINER_NO")
    '                        xlsheet.Cells(16 + row, 3) = ds_bay.Tables(0).Rows(row + i * 30)("SEALNO")
    '                        xlsheet.Cells(16 + row, 4) = ds_bay.Tables(0).Rows(row + i * 30)("SIZE_CON")
    '                        xlsheet.Cells(16 + row, 5) = ds_bay.Tables(0).Rows(row + i * 30)("FULLOREMPTY")
    '                        If ds_bay.Tables(0).Rows(row + i * 30)("FULLOREMPTY") = "E" Then
    '                            xlsheet.Cells(16 + row, 3) = "────"
    '                        End If
    '                    Next row
    '                    For row = 15 To 29
    '                        xlsheet.Cells(1 + row, 7) = ds_bay.Tables(0).Rows(row + i * 30)("CONTAINER_NO")
    '                        xlsheet.Cells(1 + row, 11) = ds_bay.Tables(0).Rows(row + i * 30)("SEALNO")
    '                        xlsheet.Cells(1 + row, 13) = ds_bay.Tables(0).Rows(row + i * 30)("SIZE_CON")
    '                        xlsheet.Cells(1 + row, 15) = ds_bay.Tables(0).Rows(row + i * 30)("FULLOREMPTY")
    '                        If ds_bay.Tables(0).Rows(row + i * 30)("FULLOREMPTY") = "E" Then
    '                            xlsheet.Cells(1 + row, 11) = "────"
    '                        End If
    '                    Next row
    '                    x1 = 0
    '                    x2 = 0
    '                    x3 = 0
    '                    x4 = 0
    '                    x5 = 0
    '                    x6 = 0
    '                    For k = i * 30 To i * 30 + 29
    '                        If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 20 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
    '                            x1 += 1
    '                        End If
    '                        If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 20 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
    '                            x2 += 1
    '                        End If
    '                        If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 40 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
    '                            x3 += 1
    '                        End If
    '                        If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 40 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
    '                            x4 += 1
    '                        End If
    '                        If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 45 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
    '                            x5 += 1
    '                        End If
    '                        If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 45 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
    '                            x6 += 1
    '                        End If
    '                    Next k
    '                    xlsheet.Cells(32, 12) = x1
    '                    xlsheet.Cells(33, 12) = x2
    '                    xlsheet.Cells(34, 12) = x3
    '                    xlsheet.Cells(35, 12) = x4
    '                    xlsheet.Cells(32, 15) = x5
    '                    xlsheet.Cells(33, 15) = x6
    '                    xlsheet.Cells(35, 15) = "30"
    '                    'xlsheet.PrintPreview()
    '                    xlsheet.PrintOut()

    '                Next i
    '                'KillExcelProcess()
    '                If q > 0 Then
    '                    'RecordExcelProcess()
    '                    'pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
    '                    'pathstr = substr(pathstr)
    '                    'FileCopy(pathstr + "Report_zlp3.xls", pathstr + "Report.xls")
    '                    'Filepath = pathstr + "report.xls"
    '                    'xlapp = CType(CreateObject("excel.application"), Excel.Application)
    '                    'xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
    '                    xlsheet = CType(xlbook.Worksheets("理箱单（E）13"), Excel.Worksheet)
    '                    xlapp.DisplayAlerts = False
    '                    xlsheet.Application.Visible = False
    '                    xlsheet.Select()

    '                    xlsheet.Cells(11, 2) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")))
    '                    xlsheet.Cells(11, 5) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("Voyage"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("Voyage")))
    '                    xlsheet.Cells(11, 9) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("berthno"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("berthno")))

    '                    xlsheet.Cells(11, 14) = Trim(Txtseachbay.Text)

    '                    If q <= 15 Then
    '                        For row = 0 To q - 1
    '                            xlsheet.Cells(16 + row, 1) = ds_bay.Tables(0).Rows(row + j * 30)("CONTAINER_NO")
    '                            xlsheet.Cells(16 + row, 3) = ds_bay.Tables(0).Rows(row + j * 30)("SEALNO")
    '                            xlsheet.Cells(16 + row, 4) = ds_bay.Tables(0).Rows(row + j * 30)("SIZE_CON")
    '                            xlsheet.Cells(16 + row, 5) = ds_bay.Tables(0).Rows(row + j * 30)("FULLOREMPTY")
    '                            If ds_bay.Tables(0).Rows(row + j * 30)("FULLOREMPTY") = "E" Then
    '                                xlsheet.Cells(16 + row, 3) = "────"
    '                            End If
    '                        Next row
    '                    ElseIf q > 15 And q < 30 Then
    '                        For row = 0 To 14
    '                            xlsheet.Cells(16 + row, 1) = ds_bay.Tables(0).Rows(row + j * 30)("CONTAINER_NO")
    '                            xlsheet.Cells(16 + row, 3) = ds_bay.Tables(0).Rows(row + j * 30)("SEALNO")
    '                            xlsheet.Cells(16 + row, 4) = ds_bay.Tables(0).Rows(row + j * 30)("SIZE_CON")
    '                            xlsheet.Cells(16 + row, 5) = ds_bay.Tables(0).Rows(row + j * 30)("FULLOREMPTY")
    '                            If ds_bay.Tables(0).Rows(row + j * 30)("FULLOREMPTY") = "E" Then
    '                                xlsheet.Cells(16 + row, 3) = "────"
    '                            End If
    '                        Next row
    '                        For row = 15 To q - 1
    '                            xlsheet.Cells(1 + row, 7) = ds_bay.Tables(0).Rows(row + j * 30)("CONTAINER_NO")
    '                            xlsheet.Cells(1 + row, 11) = ds_bay.Tables(0).Rows(row + j * 30)("SEALNO")
    '                            xlsheet.Cells(1 + row, 13) = ds_bay.Tables(0).Rows(row + j * 30)("SIZE_CON")
    '                            xlsheet.Cells(1 + row, 15) = ds_bay.Tables(0).Rows(row + j * 30)("FULLOREMPTY")
    '                            If ds_bay.Tables(0).Rows(row + j * 30)("FULLOREMPTY") = "E" Then
    '                                xlsheet.Cells(1 + row, 11) = "────"
    '                            End If
    '                        Next row
    '                    End If
    '                    x1 = 0
    '                    x2 = 0
    '                    x3 = 0
    '                    x4 = 0
    '                    x5 = 0
    '                    x6 = 0
    '                    For k = ds_bay.Tables(0).Rows.Count - q To ds_bay.Tables(0).Rows.Count - 1
    '                        If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 20 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
    '                            x1 += 1
    '                        End If
    '                        If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 20 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
    '                            x2 += 1
    '                        End If
    '                        If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 40 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
    '                            x3 += 1
    '                        End If
    '                        If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 40 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
    '                            x4 += 1
    '                        End If
    '                        If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 45 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
    '                            x5 += 1
    '                        End If
    '                        If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 45 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
    '                            x6 += 1
    '                        End If
    '                    Next k
    '                    xlsheet.Cells(32, 12) = x1
    '                    xlsheet.Cells(33, 12) = x2
    '                    xlsheet.Cells(34, 12) = x3
    '                    xlsheet.Cells(35, 12) = x4
    '                    xlsheet.Cells(32, 15) = x5
    '                    xlsheet.Cells(33, 15) = x6
    '                    xlsheet.Cells(35, 15) = q
    '                    'xlsheet.PrintPreview()
    '                    xlsheet.PrintOut()

    '                End If
    '                KillExcelProcess()
    '            End If
    '        Else
    '            MsgBox("该贝上没有箱，请查实！")
    '        End If
    '    Catch
    '        xlapp.Quit()
    '        SendKeys.Send("n")
    '    End Try
    'End Sub

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
            xlSheet = CType(xlBook.Worksheets("Sheet1"), Excel.Worksheet)
            xlApp.DisplayAlerts = False
            xlSheet.Application.Visible = True
            xlBook.Worksheets("sheet1").select()
            xlSheet.Cells(1, 1) = Me.Text() '标题

            For Col = ColNum To Me.C1DBG.Columns.Count - 1 '列标题
                xlSheet.Cells(3, Col - ColNum + 1) = Me.C1DBG.Columns(Col).Caption
            Next Col
            Me.C1DBG.MoveFirst()
            For Row = 0 To Me.C1DBG.Splits(0).Rows.Count - 1 ' DS_DO.Tables(0).Rows.Count(-1) '数据
                For Col = ColNum To Me.C1DBG.Columns.Count - 1
                    xlSheet.Cells(Row + 4, Col - ColNum + 1) = Me.C1DBG.Columns(Col).Text.ToString
                Next Col
                Me.C1DBG.MoveNext()
            Next Row
            If Me.C1DBG.ColumnFooters = True Then '合计项
                For Col = ColNum To Me.C1DBG.Columns.Count - 1
                    xlSheet.Cells(Me.C1DBG.Splits(0).Rows.Count + 4, Col - ColNum + 1) = Me.C1DBG.Columns(Col).FooterText
                Next Col
            End If
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
            KillExcelProcess()
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

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        If Me.C1DBG.Columns("Logic").CellValue(e.Row) = 1 Then
            e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
        End If
    End Sub

    Private Sub Frm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.C1DBGV.Height = Me.Height - 140
        Me.C1DBG.Height = Me.Height - 120
        Me.C1DBG.Width = Me.GB.Width - 5
        Me.Label.Width = Me.C1DBG.Width - 3
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
        SqlStrShip = "where (((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('2','3'))) and Voyage like '" & Trim(txtVoyage.Text) & "%' and (ENG_VESSEL Like '" & Trim(txtShipName.Text) & "%' OR CHI_VESSEL like '" & Trim(txtShipName.Text) & "%' )) "
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

End Class
