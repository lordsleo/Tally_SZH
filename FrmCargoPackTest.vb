Imports TALLY.DBControl
Public Class FrmCargoPackTest
    Inherits System.Windows.Forms.Form

    Dim dsShip As New DataSet() '�������ݼ�
    Dim SqlStrShip As String  '�����������
    Dim FirmShip As String
    Dim SortShip As String
    Dim inoutstr As String

    Dim ds As New DataSet()
    Dim SqlStr As String  '�������
    Dim SelectStr As String
    Dim DynaStr As String '�ɱ���������
    Dim FirmStr As String '������������
    Dim ColNum As Integer '����ʾ������

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    '������д��������������б�
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows ����������������
    Private components As System.ComponentModel.IContainer

    'ע�⣺���¹����� Windows ����������������
    '����ʹ�� Windows ����������޸Ĵ˹��̡�
    '��Ҫʹ�ô���༭���޸�����
    Friend WithEvents GBV As System.Windows.Forms.GroupBox
    Friend WithEvents btResure As System.Windows.Forms.Button
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolBarV As System.Windows.Forms.ToolBar
    Friend WithEvents C1DBGV As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tbbtnOK As System.Windows.Forms.ToolBarButton
    Friend WithEvents S2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSearch As System.Windows.Forms.ToolBarButton
    Friend WithEvents S3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSort As System.Windows.Forms.ToolBarButton
    Friend WithEvents S4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnEng As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents tbbtnPrint As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnSep2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuQuery As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnQuery As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuQuit As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnExport As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuPrint As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExport As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCompile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAdd As System.Windows.Forms.MenuItem
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFind As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnAdd As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuit As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnDelete As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnFind As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnEdit As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCargoPackTest))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Dim GridLines2 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.GBV = New System.Windows.Forms.GroupBox()
        Me.btResure = New System.Windows.Forms.Button()
        Me.txtVoyage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtShipName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolBarV = New System.Windows.Forms.ToolBar()
        Me.C1DBGV = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.tbbtnOK = New System.Windows.Forms.ToolBarButton()
        Me.S2 = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnSearch = New System.Windows.Forms.ToolBarButton()
        Me.S3 = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnSort = New System.Windows.Forms.ToolBarButton()
        Me.S4 = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnEng = New System.Windows.Forms.ToolBarButton()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.tbbtnPrint = New System.Windows.Forms.ToolBarButton()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.mnuSep1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.mnuDelete = New System.Windows.Forms.MenuItem()
        Me.mnuEdit = New System.Windows.Forms.MenuItem()
        Me.tbbtnSep2 = New System.Windows.Forms.ToolBarButton()
        Me.mnuQuery = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.mnuSep2 = New System.Windows.Forms.MenuItem()
        Me.mnuHelp = New System.Windows.Forms.MenuItem()
        Me.tbbtnQuery = New System.Windows.Forms.ToolBarButton()
        Me.mnuQuit = New System.Windows.Forms.MenuItem()
        Me.tbbtnExport = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnSep3 = New System.Windows.Forms.ToolBarButton()
        Me.mnuPrint = New System.Windows.Forms.MenuItem()
        Me.mnuExport = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.mnuCompile = New System.Windows.Forms.MenuItem()
        Me.mnuAdd = New System.Windows.Forms.MenuItem()
        Me.MainMenu = New System.Windows.Forms.MainMenu()
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuFind = New System.Windows.Forms.MenuItem()
        Me.tbbtnAdd = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnQuit = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnSep1 = New System.Windows.Forms.ToolBarButton()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.tbbtnDelete = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnFind = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnEdit = New System.Windows.Forms.ToolBarButton()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.GB = New System.Windows.Forms.GroupBox()
        Me.ToolBar = New System.Windows.Forms.ToolBar()
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label = New System.Windows.Forms.Label()
        Me.GBV.SuspendLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB.SuspendLayout()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBV
        '
        Me.GBV.Controls.AddRange(New System.Windows.Forms.Control() {Me.btResure, Me.txtVoyage, Me.Label2, Me.txtShipName, Me.Label1, Me.ToolBarV, Me.C1DBGV})
        Me.GBV.Dock = System.Windows.Forms.DockStyle.Left
        Me.GBV.Name = "GBV"
        Me.GBV.Size = New System.Drawing.Size(166, 431)
        Me.GBV.TabIndex = 10
        Me.GBV.TabStop = False
        '
        'btResure
        '
        Me.btResure.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.btResure.Location = New System.Drawing.Point(122, 368)
        Me.btResure.Name = "btResure"
        Me.btResure.Size = New System.Drawing.Size(42, 22)
        Me.btResure.TabIndex = 32
        Me.btResure.Text = "��ѯ"
        '
        'txtVoyage
        '
        Me.txtVoyage.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtVoyage.Location = New System.Drawing.Point(32, 368)
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(88, 21)
        Me.txtVoyage.TabIndex = 31
        Me.txtVoyage.Text = ""
        '
        'Label2
        '
        Me.Label2.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.Label2.Location = New System.Drawing.Point(2, 370)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 20)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "����"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipName
        '
        Me.txtShipName.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtShipName.Location = New System.Drawing.Point(32, 346)
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.Size = New System.Drawing.Size(132, 21)
        Me.txtShipName.TabIndex = 30
        Me.txtShipName.Text = ""
        '
        'Label1
        '
        Me.Label1.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.Label1.Location = New System.Drawing.Point(2, 348)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 20)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "����"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolBarV
        '
        Me.ToolBarV.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnOK, Me.S2, Me.tbbtnSearch, Me.S3, Me.tbbtnSort, Me.S4, Me.tbbtnEng})
        Me.ToolBarV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBarV.DropDownArrows = True
        Me.ToolBarV.ImageList = Me.ImageList
        Me.ToolBarV.Location = New System.Drawing.Point(3, 390)
        Me.ToolBarV.Name = "ToolBarV"
        Me.ToolBarV.ShowToolTips = True
        Me.ToolBarV.Size = New System.Drawing.Size(160, 38)
        Me.ToolBarV.TabIndex = 13
        '
        'C1DBGV
        '
        Me.C1DBGV.AllowFilter = True
        Me.C1DBGV.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1DBGV.AllowSort = True
        Me.C1DBGV.AllowUpdate = False
        Me.C1DBGV.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.C1DBGV.CaptionHeight = 18
        Me.C1DBGV.CollapseColor = System.Drawing.Color.Black
        Me.C1DBGV.DataChanged = False
        Me.C1DBGV.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBGV.ExpandColor = System.Drawing.Color.Black
        Me.C1DBGV.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGV.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
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
        Me.C1DBGV.Size = New System.Drawing.Size(160, 327)
        Me.C1DBGV.TabIndex = 0
        Me.C1DBGV.Text = "C1TrueDBGrid1"
        Me.C1DBGV.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        ", 0, 156, 323</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2" & _
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
        "56, 323</ClientArea></Blob>"
        '
        'tbbtnOK
        '
        Me.tbbtnOK.ImageIndex = 8
        Me.tbbtnOK.Text = "����"
        '
        'S2
        '
        Me.S2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnSearch
        '
        Me.tbbtnSearch.ImageIndex = 9
        Me.tbbtnSearch.Text = "����"
        '
        'S3
        '
        Me.S3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnSort
        '
        Me.tbbtnSort.ImageIndex = 10
        Me.tbbtnSort.Text = "����"
        '
        'S4
        '
        Me.S4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnEng
        '
        Me.tbbtnEng.ImageIndex = 11
        Me.tbbtnEng.Text = "Ӣ��"
        '
        'ImageList
        '
        Me.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'tbbtnPrint
        '
        Me.tbbtnPrint.ImageIndex = 5
        Me.tbbtnPrint.Text = "��ӡ"
        Me.tbbtnPrint.ToolTipText = "��ӡ"
        '
        'MenuItem14
        '
        Me.MenuItem14.Enabled = False
        Me.MenuItem14.Index = 0
        Me.MenuItem14.Text = "����(&F)"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 2
        Me.MenuItem15.Text = "-"
        '
        'mnuSep1
        '
        Me.mnuSep1.Index = 2
        Me.mnuSep1.Text = "-"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = -1
        Me.MenuItem21.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem22, Me.MenuItem20, Me.MenuItem1})
        Me.MenuItem21.Text = "�༭(&E)"
        '
        'MenuItem22
        '
        Me.MenuItem22.Enabled = False
        Me.MenuItem22.Index = 0
        Me.MenuItem22.Text = "����(&A)"
        '
        'MenuItem20
        '
        Me.MenuItem20.Enabled = False
        Me.MenuItem20.Index = 1
        Me.MenuItem20.Text = "�༭(&E)"
        '
        'MenuItem1
        '
        Me.MenuItem1.Enabled = False
        Me.MenuItem1.Index = 2
        Me.MenuItem1.Text = "ɾ��(&D)"
        '
        'mnuDelete
        '
        Me.mnuDelete.Enabled = False
        Me.mnuDelete.Index = 2
        Me.mnuDelete.Text = "ɾ��(&D)"
        '
        'mnuEdit
        '
        Me.mnuEdit.Enabled = False
        Me.mnuEdit.Index = 1
        Me.mnuEdit.Text = "�༭(&E)"
        '
        'tbbtnSep2
        '
        Me.tbbtnSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'mnuQuery
        '
        Me.mnuQuery.Enabled = False
        Me.mnuQuery.Index = 1
        Me.mnuQuery.Text = "�鿴(&Q)"
        '
        'MenuItem12
        '
        Me.MenuItem12.Enabled = False
        Me.MenuItem12.Index = 1
        Me.MenuItem12.Text = "�鿴(&Q)"
        '
        'mnuSep2
        '
        Me.mnuSep2.Index = 5
        Me.mnuSep2.Text = "-"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.Text = "����(&H)"
        '
        'tbbtnQuery
        '
        Me.tbbtnQuery.ImageIndex = 1
        Me.tbbtnQuery.Text = "�鿴"
        Me.tbbtnQuery.ToolTipText = "�鿴"
        '
        'mnuQuit
        '
        Me.mnuQuit.Index = 6
        Me.mnuQuit.Text = "�˳�(&X)"
        '
        'tbbtnExport
        '
        Me.tbbtnExport.ImageIndex = 6
        Me.tbbtnExport.Text = "����"
        Me.tbbtnExport.ToolTipText = "����Excel"
        '
        'tbbtnSep3
        '
        Me.tbbtnSep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'mnuPrint
        '
        Me.mnuPrint.Enabled = False
        Me.mnuPrint.Index = 3
        Me.mnuPrint.Text = "��ӡ(&P)..."
        '
        'mnuExport
        '
        Me.mnuExport.Enabled = False
        Me.mnuExport.Index = 4
        Me.mnuExport.Text = "����(&E)"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 5
        Me.MenuItem18.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Enabled = False
        Me.MenuItem17.Index = 4
        Me.MenuItem17.Text = "����(&E)"
        '
        'mnuCompile
        '
        Me.mnuCompile.Index = 1
        Me.mnuCompile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAdd, Me.mnuEdit, Me.mnuDelete})
        Me.mnuCompile.Text = "�༭(&E)"
        '
        'mnuAdd
        '
        Me.mnuAdd.Enabled = False
        Me.mnuAdd.Index = 0
        Me.mnuAdd.Text = "����(&A)"
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuCompile, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFind, Me.mnuQuery, Me.mnuSep1, Me.mnuPrint, Me.mnuExport, Me.mnuSep2, Me.mnuQuit})
        Me.mnuFile.Text = "�ļ�(&F)"
        '
        'mnuFind
        '
        Me.mnuFind.Enabled = False
        Me.mnuFind.Index = 0
        Me.mnuFind.Text = "����(&F)"
        '
        'tbbtnAdd
        '
        Me.tbbtnAdd.ImageIndex = 2
        Me.tbbtnAdd.Text = "����"
        Me.tbbtnAdd.ToolTipText = "����"
        '
        'tbbtnQuit
        '
        Me.tbbtnQuit.ImageIndex = 7
        Me.tbbtnQuit.Text = "�˳�"
        Me.tbbtnQuit.ToolTipText = "�˳�"
        '
        'tbbtnSep1
        '
        Me.tbbtnSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = -1
        Me.MenuItem13.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem14, Me.MenuItem12, Me.MenuItem15, Me.MenuItem16, Me.MenuItem17, Me.MenuItem18, Me.MenuItem2})
        Me.MenuItem13.Text = "�ļ�(&F)"
        '
        'MenuItem16
        '
        Me.MenuItem16.Enabled = False
        Me.MenuItem16.Index = 3
        Me.MenuItem16.Text = "��ӡ(&P)..."
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 6
        Me.MenuItem2.Text = "�˳�(&X)"
        '
        'tbbtnDelete
        '
        Me.tbbtnDelete.ImageIndex = 4
        Me.tbbtnDelete.Text = "ɾ��"
        Me.tbbtnDelete.ToolTipText = "ɾ��"
        '
        'tbbtnFind
        '
        Me.tbbtnFind.ImageIndex = 0
        Me.tbbtnFind.Text = "����"
        Me.tbbtnFind.ToolTipText = "����"
        '
        'tbbtnEdit
        '
        Me.tbbtnEdit.ImageIndex = 3
        Me.tbbtnEdit.Text = "�༭"
        Me.tbbtnEdit.ToolTipText = "�༭"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = -1
        Me.MenuItem19.Text = "����(&H)"
        '
        'GB
        '
        Me.GB.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GB.Controls.AddRange(New System.Windows.Forms.Control() {Me.ToolBar, Me.C1DBG, Me.Label})
        Me.GB.Location = New System.Drawing.Point(166, 0)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(518, 432)
        Me.GB.TabIndex = 11
        Me.GB.TabStop = False
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
        Me.ToolBar.Size = New System.Drawing.Size(512, 38)
        Me.ToolBar.TabIndex = 13
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.AllowSort = True
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.CollapseColor = System.Drawing.Color.Black
        Me.C1DBG.DataChanged = False
        Me.C1DBG.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBG.ExpandColor = System.Drawing.Color.Black
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource.Images1"), System.Drawing.Bitmap))
        Me.C1DBG.Location = New System.Drawing.Point(3, 92)
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
        Me.C1DBG.Size = New System.Drawing.Size(512, 337)
        Me.C1DBG.TabIndex = 10
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Bord" & _
        "er:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView Name="""" AllowRowSizing=""None"" CaptionHeight=""18"" ColumnC" & _
        "aptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" Record" & _
        "SelectorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollG" & _
        "roup=""1""><ClientRect>0, 0, 508, 333</ClientRect><BorderSide>0</BorderSide><Capti" & _
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
        "th><ClientArea>0, 0, 508, 333</ClientArea></Blob>"
        '
        'Label
        '
        Me.Label.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.Label.BackColor = System.Drawing.SystemColors.Control
        Me.Label.Location = New System.Drawing.Point(4, 56)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(512, 36)
        Me.Label.TabIndex = 11
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmCargoPackTest
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(684, 431)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GBV, Me.GB})
        Me.Menu = Me.MainMenu
        Me.Name = "FrmCargoPackTest"
        Me.Text = "ɢ����������ʼ��ձ�"
        Me.GBV.ResumeLayout(False)
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB.ResumeLayout(False)
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCargoPackTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Text = Me.Text & "_" & G_DeptName

        SortShip = " Order by Ship_Statu,Dept_Code,id desc " 'Ĭ�ϵ����� 
        FirmShip = "where DEPT_CODE LIKE '" & G_DeptCode & "%'" '����������������
        SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) "
        Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '*****************���ú�����Ϣ
        Me.C1DBGV.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue

        txtShipName.Text = G_ShipName
        txtVoyage.Text = G_Voyage
        txtShipName.Focus()
        Call btResure_Click(sender, e)
    End Sub

    Private Sub myDataGridShip(ByVal Sql As String) '**************������Ϣ
        Dim strsql As String
        Dim i As Integer
        strsql = "select SHIP_ID as ID ,SHIP_STATU,INOUTPORT,DEPT_CODE,ENG_VESSEL,CHI_VESSEL,VOYAGE,InOutPort_Name,Dept_Short from View_SSHip " '����������� ���Ĳ���
        strsql = strsql & Sql
        Try
            Me.C1DBGV.DataSource = Getdata(strsql, dsShip)
            For i = 0 To 4 '��Ʋ���ʾ����
                Me.C1DBGV.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Call SetColumnCaptionShip() '����б���
            Call SetColumnWidthShip() '����п��
            If dsShip.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumShip(5)  '��ƺϼ���
            End If
            Me.C1DBGV.FetchRowStyles = True
            Me.C1DBGV.Refresh()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaptionShip() '*****************���α���
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

    Private Sub SetColumnWidthShip() '************�����п�
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

    Private Sub SetColumnSumShip(ByVal Col As Integer) '****************���λ�����

        Me.C1DBGV.ColumnFooters = True
        Me.C1DBGV.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGV.Columns.Item(Col).FooterText = "�� " & dsShip.Tables(0).Rows.Count & " ��"

    End Sub

    Private Sub ToolBarV_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBarV.ButtonClick
        Select Case Me.ToolBarV.Buttons.IndexOf(e.Button)
            Case 0
                SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) " '�����ɱ���������
                SortShip = " Order by Ship_Statu,Dept_Code,id desc "
                Call myDataGridShip(SqlStrShip & inoutstr & SortShip)

            Case 2
                Dim FrmFind As New FrmFind()
                Table_Name = "SSHIP"
                FrmFind.ShowDialog()
                If Flag = 0 Then
                    Call myDataGridShip(FirmShip & inoutstr & " and (" & Sql_Find & ")  " & SortShip)    '����Ҫ�޸�
                    SqlStrShip = FirmStr & " and (" & Sql_Find & ")  "    '����Ҫ�޸�
                ElseIf Flag = 2 Then
                    SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','4')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) "
                    '����Ҫ�޸�
                    Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '����Ҫ�޸�
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
                    Call SetColumnSumShip(4)  '��ƺϼ���
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

        Dim dsShip As New DataSet() '��ǰ���dsShip����������ã�
        Dim strsql As String
        Dim dw As New DataView()
        Ship_ID = CType(Me.C1DBGV.Columns.Item("ID").Text.ToString, Integer)
        strsql = "select * from View_SSHIP where SHIP_ID=" & Ship_ID
        dw = Getdata(strsql, dsShip)
        Label.Text = ""
        'strCodeGoods = ""
        'strBerthNo = ""
        'iTons = Nothing
        If dsShip.Tables(0).DefaultView.Count > 0 Then

            If Len(Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))) > 0 Then
                Label.Text = Label.Text & "���Ĵ���:" & Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL"))) > 0 Then
                Label.Text = Label.Text & "Ӣ�Ĵ���:" & Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))) > 0 Then
                Label.Text = Label.Text & "����:" & Trim(dsShip.Tables(0).Rows(0).Item("Voyage")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("InOutPort_Name"))) > 0 Then
                Label.Text = Label.Text & "������:" & Trim(dsShip.Tables(0).Rows(0).Item("InOutPort_Name")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Trade"))) > 0 Then
                Label.Text = Label.Text & "����ó:" & Trim(dsShip.Tables(0).Rows(0).Item("Trade")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("SHIP_TYPE"))) > 0 Then
                Label.Text = Label.Text & "������:" & Trim(dsShip.Tables(0).Rows(0).Item("SHIP_TYPE")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("SHIPAGENT_CHAE"))) > 0 Then
                Label.Text = Label.Text & "����:" & Trim(dsShip.Tables(0).Rows(0).Item("SHIPAGENT_CHA")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("GOODS"))) > 0 Then
                Label.Text = Label.Text & "����:" & Trim(dsShip.Tables(0).Rows(0).Item("GOODS")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Tons"))) > 0 Then
                Label.Text = Label.Text & "����:" & Trim(dsShip.Tables(0).Rows(0).Item("Tons")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("BerthNo"))) > 0 Then
                Label.Text = Label.Text & "��λ:" & Trim(dsShip.Tables(0).Rows(0).Item("BerthNo")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("File_No"))) > 0 Then
                Label.Text = Label.Text & "������:" & Trim(dsShip.Tables(0).Rows(0).Item("File_No")) & " "
            End If
        End If
        FirmStr = " and Ship_ID=" & Ship_ID & " Order by ID desc" '��Ƴ�ʼ����  �ڼ����󲻸ı������  '***************Ҫ�޸� �� 2>1
        DynaStr = " 2>1 " '���������ʼ����    �ڼ�������Ҫ������ ***************Ҫ�޸� �� ��������
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
        Call preview("WL3_6_6") '*****************Ȩ����� '*************Ҫ�޸�ģ���
        Call myDataGrid(SelectStr, SqlStr)
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '���ѡ���¼��ɫ
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub myDataGrid(ByVal SelStr As String, ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            '����ʾ����������ǰ��
            strsql = "select " & SelStr & " *  from View_CargoPackSample  where " & Sql '******Ҫ�޸�

            Me.C1DBG.DataSource = Getdata(strsql, ds)  ' class dbcontrol getdata fuction
            ColNum = 13 '����ʾ������ '******Ҫ�޸�
            Table_Name = "View_CargoPackSample" '���������ݿ���� ''******Ҫ�޸�

            For i = 0 To ColNum - 1 '��Ʋ���ʾ����
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Translate = True
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Validate = True
            'Me.C1DBG.Splits(0).DisplayColumns.Item("Logic").Visible = False

            Call SetColumnCaption() '����б���
            Call SetColumnWidth() '����п��
            If ds.Tables(0).Rows.Count > 0 Then
                Call SetColumnSum(Sql) '��ƺϼ���
            End If
            'Me.C1DBG.FetchRowStyles = True
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
        Me.C1DBG.Columns.Item(ColNum).FooterText = "�ϼ� ��" & ds.Tables(0).Rows.Count & "��"
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
            Call myDataGrid(SelectStr, " (" & Sql_Find & ")  " & FirmStr)  '����Ҫ�޸�
            SqlStr = " (" & Sql_Find & ")  " & FirmStr '����Ҫ�޸�
        ElseIf Flag = 2 Then
            SelectStr = ""
            Call myDataGrid(SelectStr, DynaStr & FirmStr)  '����Ҫ�޸�
            SqlStr = DynaStr & FirmStr '����Ҫ�޸�
        End If
    End Sub

    Private Sub mnuQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuery.Click
        'Try
        '    If ds.Tables(0).Rows.Count > 0 Then
        '        Dim FrmQuery As New FrmCargoPackSheet_Query()     '***********Ҫ�޸�
        '        ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
        '        FrmQuery.ShowDialog()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("����ѡ��������")
        'End Try
    End Sub

    Private Sub mnuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdd.Click
        Dim FrmAdd As New FrmCargoPackTest_Add()     '***********Ҫ�޸�
        If ds.Tables(0).Rows.Count > 0 Then
            ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
        Else
            ID = -1
        End If
        FrmAdd.ShowDialog()
        Try
            Call myDataGrid(SelectStr, SqlStr)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        If ds.Tables(0).Rows.Count > 0 Then
            Dim FrmEdit As New FrmCargoPackTest_Edit()    '***********Ҫ�޸�
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
            Dim FrmDelete As New FrmCargoPacktest_Delete()     '***********Ҫ�޸�

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
        Call PrintExcel()
    End Sub

    Private Sub PrintExcel() '��ӡ��Excel        

        Dim Row As Integer
        Dim Col As Integer

        Try
            Call MakeExcel()

            Row = ds.Tables(0).Rows.Count + 4
            Col = Me.C1DBG.Columns.Count - ColNum
            '**************���߿�
            For Row = 2 To ds.Tables(0).Rows.Count + 4 '����
                xlSheet.Range(xlSheet.Cells(Row, 1), xlSheet.Cells(Row, C1DBG.Columns.Count - ColNum)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 7
            Next Row
            For Col = 1 To C1DBG.Columns.Count - ColNum + 1 '����
                xlSheet.Range(xlSheet.Cells(3, Col), xlSheet.Cells(ds.Tables(0).Rows.Count + 4, Col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7
            Next Col

        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try

    End Sub

    Private Sub mnuExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExport.Click
        Call ExportExcel()
    End Sub

    Private Sub ExportExcel() '����Excel        
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

            xlSheet.Cells(1, 1) = Me.Text() '����

            For Col = ColNum To Me.C1DBG.Columns.Count - 1 '�б���
                xlSheet.Cells(3, Col - ColNum + 1) = Me.C1DBG.Columns(Col).Caption

            Next Col
            Me.C1DBG.MoveFirst()
            For Row = 0 To ds.Tables(0).Rows.Count - 1 '����
                For Col = ColNum To Me.C1DBG.Columns.Count - 1
                    xlSheet.Cells(Row + 4, Col - ColNum + 1) = Me.C1DBG.Columns(Col).Text.ToString      'ds.Tables(0).Rows(Row)(Col)
                Next Col
                Me.C1DBG.MoveNext()
            Next Row
            If Me.C1DBG.ColumnFooters = True Then '�ϼ���
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

    Private Sub preview(ByVal Func As String) '***************Ȩ�����
        Dim sqlstr As String
        Dim Previewdv As DataView
        Dim Previewds As New DataSet()
        Dim i As Integer
        sqlstr = " select FUNC_CODE_Add,FUNC_CODE_Change,FUNC_CODE_Del from View_UserPreview where PART_ID=" & G_Part_Id & " and FUNC_CODE='" & Upper(Func) & "' "
        Previewdv = Getdata(sqlstr, Previewds)
        If Previewdv.Count > 0 Then
            If Previewdv(i)("FUNC_CODE_Add") = 1 Then 'ADD ��ť�ɼ�
                ToolBar.Buttons.Item(3).Enabled = True
                mnuAdd.Enabled = True
            Else                                      'ADD ��ť���ɼ�
                Me.ToolBar.Buttons.Item(3).Enabled = False
                mnuAdd.Enabled = False
            End If
            If Previewdv(i)("FUNC_CODE_Change") = 1 Then '�޸� ��ť�ɼ�
                Me.ToolBar.Buttons.Item(4).Enabled = True
                mnuEdit.Enabled = True
            Else                                          '�޸� ��ť���ɼ�
                Me.ToolBar.Buttons.Item(4).Enabled = False
                mnuEdit.Enabled = False
            End If
            If Previewdv(i)("FUNC_CODE_Del") = 1 Then 'ɾ�� ��ť�ɼ�
                Me.ToolBar.Buttons.Item(5).Enabled = True
                mnuDelete.Enabled = True
            Else                                     'ɾ�� ��ť���ɼ�
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
        '����Ҫ�޸�
        'G_ShipName = Trim(txtShipName.Text)
        'G_Voyage = Trim(txtVoyage.Text)
        Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '����Ҫ�޸�
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
