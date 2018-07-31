Imports TALLY.DBControl
Imports Microsoft.VisualBasic

Public Class FrmCARGO_Monitor
    Inherits System.Windows.Forms.Form
    Dim dsShip As New DataSet() '�������ݼ�
    Dim SqlStrShip As String  '�����������
    Dim FirmShip As String
    Dim SortShip As String
    Dim inoutstr As String
    Dim dw As New DataView()

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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCARGO_Monitor))
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
        Me.mnuFile.Text = "�ļ�(&F)"
        '
        'mnuFind
        '
        Me.mnuFind.Enabled = False
        Me.mnuFind.Index = 0
        Me.mnuFind.Text = "����(&F)"
        '
        'mnuQuery
        '
        Me.mnuQuery.Enabled = False
        Me.mnuQuery.Index = 1
        Me.mnuQuery.Text = "�鿴(&Q)"
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
        Me.mnuPrint.Text = "��ӡ(&P)..."
        '
        'mnuExport
        '
        Me.mnuExport.Enabled = False
        Me.mnuExport.Index = 4
        Me.mnuExport.Text = "����(&E)"
        '
        'mnuSep2
        '
        Me.mnuSep2.Index = 5
        Me.mnuSep2.Text = "-"
        '
        'mnuQuit
        '
        Me.mnuQuit.Index = 6
        Me.mnuQuit.Text = "�˳�(&X)"
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
        'mnuEdit
        '
        Me.mnuEdit.Enabled = False
        Me.mnuEdit.Index = 1
        Me.mnuEdit.Text = "�༭(&E)"
        '
        'mnuDelete
        '
        Me.mnuDelete.Enabled = False
        Me.mnuDelete.Index = 2
        Me.mnuDelete.Text = "ɾ��(&D)"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.Text = "����(&H)"
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
        Me.btResure.Text = "��ѯ"
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
        Me.Label2.Text = "����"
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
        Me.Label1.Text = "����"
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
        'C1DBGV
        '
        Me.C1DBGV.AllowUpdate = False
        Me.C1DBGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.C1DBGV.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1DBGV.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGV.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBGV.Location = New System.Drawing.Point(3, 17)
        Me.C1DBGV.Name = "C1DBGV"
        Me.C1DBGV.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGV.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGV.PreviewInfo.ZoomFactor = 75
        Me.C1DBGV.Size = New System.Drawing.Size(168, 291)
        Me.C1DBGV.TabIndex = 0
        Me.C1DBGV.Text = "C1TrueDBGrid1"
        Me.C1DBGV.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Alig" & _
        "nVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><Height>287</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorSty" & _
        "le parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><F" & _
        "ilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=" & _
        """Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Headi" & _
        "ng"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><Inacti" & _
        "veStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9""" & _
        " /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle pa" & _
        "rent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0" & _
        ", 0, 164, 287</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderS" & _
        "tyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""" & _
        "Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Foot" & _
        "er"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactiv" & _
        "e"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /" & _
        "><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" " & _
        "/><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelecto" & _
        "r"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" " & _
        "/></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None" & _
        "</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 164, 287</" & _
        "ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle " & _
        "parent="""" me=""Style15"" /></Blob>"
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
        Me.C1DBG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(3, 92)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.Size = New System.Drawing.Size(532, 304)
        Me.C1DBG.TabIndex = 10
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Alig" & _
        "nVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" AllowRowSizing=""None"" CaptionH" & _
        "eight=""18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""Dotted" & _
        "CellBorder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1""" & _
        " HorizontalScrollGroup=""1""><Height>300</Height><CaptionStyle parent=""Style2"" me=" & _
        """Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""Eve" & _
        "nRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterSty" & _
        "le parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><Head" & _
        "ingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow""" & _
        " me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle paren" & _
        "t=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style1" & _
        "1"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""S" & _
        "tyle1"" /><ClientRect>0, 0, 528, 300</ClientRect><BorderSide>0</BorderSide><Borde" & _
        "rStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles" & _
        "><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style par" & _
        "ent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style parent" & _
        "=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=" & _
        """Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=" & _
        """Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Head" & _
        "ing"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent" & _
        "=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</h" & _
        "orzSplits><Layout>None</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth><Clien" & _
        "tArea>0, 0, 528, 300</ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" />" & _
        "<PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
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
        Me.tbbtndo.Text = "����"
        '
        'tbbtnSep2
        '
        Me.tbbtnSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnPrint
        '
        Me.tbbtnPrint.ImageIndex = 5
        Me.tbbtnPrint.Text = "��ӡ"
        Me.tbbtnPrint.ToolTipText = "��ӡ"
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
        'tbbtnQuit
        '
        Me.tbbtnQuit.ImageIndex = 7
        Me.tbbtnQuit.Text = "�˳�"
        Me.tbbtnQuit.ToolTipText = "�˳�"
        '
        'FrmCARGO_Monitor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(714, 399)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.GBV)
        Me.Menu = Me.MainMenu
        Me.Name = "FrmCARGO_Monitor"
        Me.Text = "װж���ȱ�"
        Me.GBV.ResumeLayout(False)
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB.ResumeLayout(False)
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCARGO_Monitor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        Me.Text = Me.Text & "_" & G_DeptName
        SortShip = " Order by Ship_Statu,Dept_Code,id desc " 'Ĭ�ϵ����� 
        FirmShip = "where DEPT_CODE LIKE '" & G_DeptCode & "%' and code_goods<>'2' " '����������������
        SqlStrShip = "where (DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('2','3'))  and code_goods<>'2' " 'OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) "
        Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '*****************���ú�����Ϣ
        Me.C1DBGV.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue

        txtShipName.Text = G_ShipName
        txtVoyage.Text = G_Voyage
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
            Case 1
                SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('2','3')))  and code_goods<>'2' " '�����ɱ���������
                SortShip = " Order by Ship_Statu,Dept_Code,id desc "
                Call myDataGridShip(SqlStrShip & inoutstr & SortShip)

            Case 3
                Dim FrmFind As New FrmFind
                Table_Name = "SSHIP"
                FrmFind.ShowDialog()
                If Flag = 0 Then
                    Call myDataGridShip(FirmShip & inoutstr & " and (" & Sql_Find & ")  " & SortShip)    '����Ҫ�޸�
                    SqlStrShip = FirmStr & " and (" & Sql_Find & ")  "    '����Ҫ�޸�
                ElseIf Flag = 2 Then
                    SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','4')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0))  and code_goods<>'2' "
                    '����Ҫ�޸�
                    Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '����Ҫ�޸�
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

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        If Me.C1DBG.Columns("am").CellValue(e.Row) <> 0 Then
            e.CellStyle.BackColor = System.Drawing.Color.PaleGreen
        End If
        If Me.C1DBG.Columns("ton").CellValue(e.Row) <> 0 Then
            e.CellStyle.BackColor = System.Drawing.Color.PaleGreen
        End If
        If Me.C1DBG.Columns("am").CellValue(e.Row) = 0 Then
            e.CellStyle.BackColor = System.Drawing.Color.Pink
        End If
        If Me.C1DBG.Columns("ton").CellValue(e.Row) = 0 Then
            e.CellStyle.BackColor = System.Drawing.Color.Pink
        End If
        If Me.C1DBG.Columns("amount").CellValue(e.Row) = 0 Then
            e.CellStyle.BackColor = System.Drawing.Color.White
        End If
        If Me.C1DBG.Columns("weight").CellValue(e.Row) = 0 Then
            e.CellStyle.BackColor = System.Drawing.Color.White
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
                Label.Text = Label.Text & "���Ĵ���:" & Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL")) & " "
                G_ShipName = Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))
                txtShipName.Text = Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL"))) > 0 Then
                Label.Text = Label.Text & "Ӣ�Ĵ���:" & Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))) > 0 Then
                Label.Text = Label.Text & "����:" & Trim(dsShip.Tables(0).Rows(0).Item("Voyage")) & " "
                G_Voyage = Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))
                txtVoyage.Text = Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))
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
        FirmStr = " and Ship_ID=" & Ship_ID & " Order by ID " '��Ƴ�ʼ����  �ڼ����󲻸ı������  '***************Ҫ�޸� �� 2>1
        DynaStr = " 2>1 " '���������ʼ����    �ڼ�������Ҫ������ ***************Ҫ�޸� �� ��������
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
        Call preview("WL4_1") '*****************Ȩ����� '*************Ҫ�޸�ģ���
        C1DBG.Visible = False

        'Call myDataGrid(SelectStr, SqlStr)
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '���ѡ���¼��ɫ
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
                Me.C1DBG.FetchRowStyles = True
                C1DBG.DataSource = DS_DO.Tables(0).DefaultView
                C1DBG.Refresh()
                'Me.C1DBG.Splits(0).DisplayColumns.Item(0).Visible = False
                'Me.C1DBG.Splits(0).DisplayColumns.Item(1).Visible = False

                For i = 10 To 41
                    Me.C1DBG.Splits(0).DisplayColumns.Item(i).Visible = False
                Next
                For i = 10 To DS_DO.Tables(1).Rows.Count - 1 + 10
                    j = 2 * i - 10
                    Me.C1DBG.Splits(0).DisplayColumns.Item(j).Visible = True
                    Me.C1DBG.Splits(0).DisplayColumns.Item(j + 1).Visible = True
                Next

                Me.C1DBG.Columns.Item("blno").Caption = "�ᵥ��"
                Me.C1DBG.Columns.Item("mark").Caption = "��־"
                Me.C1DBG.Columns.Item("goods_cha").Caption = "����"
                Me.C1DBG.Columns.Item("amount_ori").Caption = "ԭ�����"
                Me.C1DBG.Columns.Item("am").Caption = "ʣ�����"
                Me.C1DBG.Columns.Item("amount").Caption = "ʵװ����"
                Me.C1DBG.Columns.Item("code_pack").Caption = "��װ"
                Me.C1DBG.Columns.Item("tons_ori").Caption = "ԭ������"
                Me.C1DBG.Columns.Item("ton").Caption = "ʣ������"
                Me.C1DBG.Columns.Item("weight").Caption = "ʵװ����"
                'Me.C1DBG.Columns.Item("size_con").Caption = "�ߴ�"

                Me.C1DBG.Columns.Item("h1").Caption = "һ�ռ�"
                Me.C1DBG.Columns.Item("p1").Caption = "һ��λ"
                Me.C1DBG.Columns.Item("h2").Caption = "���ռ�"
                Me.C1DBG.Columns.Item("p2").Caption = "����λ"
                Me.C1DBG.Columns.Item("h3").Caption = "���ռ�"
                Me.C1DBG.Columns.Item("p3").Caption = "����λ"
                Me.C1DBG.Columns.Item("h4").Caption = "�Ĳռ�"
                Me.C1DBG.Columns.Item("p4").Caption = "�Ĳ�λ"
                Me.C1DBG.Columns.Item("h5").Caption = "��ռ�"
                Me.C1DBG.Columns.Item("p5").Caption = "���λ"
                Me.C1DBG.Columns.Item("h6").Caption = "���ռ�"
                Me.C1DBG.Columns.Item("p6").Caption = "����λ"
                Me.C1DBG.Columns.Item("h7").Caption = "�߲ռ�"
                Me.C1DBG.Columns.Item("p7").Caption = "�߲�λ"
                Me.C1DBG.Columns.Item("h8").Caption = "�˲ռ�"
                Me.C1DBG.Columns.Item("p8").Caption = "�˲�λ"
                Me.C1DBG.Columns.Item("h9").Caption = "�Ųռ�"
                Me.C1DBG.Columns.Item("p9").Caption = "�Ų�λ"
                Me.C1DBG.Columns.Item("h10").Caption = "ʮ�ռ�"
                Me.C1DBG.Columns.Item("p10").Caption = "ʮ��λ"
                Me.C1DBG.Columns.Item("h11").Caption = "ʮһ�ռ�"
                Me.C1DBG.Columns.Item("p11").Caption = "ʮһ��λ"
                Me.C1DBG.Columns.Item("h12").Caption = "ʮ���ռ�"
                Me.C1DBG.Columns.Item("p12").Caption = "ʮ����λ"
                Me.C1DBG.Columns.Item("h13").Caption = "ʮ���ռ�"
                Me.C1DBG.Columns.Item("p13").Caption = "ʮ����λ"
                Me.C1DBG.Columns.Item("h14").Caption = "ʮ�Ĳռ�"
                Me.C1DBG.Columns.Item("p14").Caption = "ʮ�Ĳ�λ"
                Me.C1DBG.Columns.Item("h15").Caption = "ʮ��ռ�"
                Me.C1DBG.Columns.Item("p15").Caption = "ʮ���λ"
                Me.C1DBG.Columns.Item("h16").Caption = "ʮ���ռ�"
                Me.C1DBG.Columns.Item("p16").Caption = "ʮ����λ"

                Call SetColumnWidth()
                Me.C1DBG.Splits(0).DisplayColumns.Item("tons_ori").Width = 80
                Me.C1DBG.Splits(0).DisplayColumns.Item("ton").Width = 80
                Me.C1DBG.Splits(0).DisplayColumns.Item("weight").Width = 80
                'If DS_DO.Tables(1).Rows.Count > 0 Then
                '    Call SetColumnSum(Sql) '��ƺϼ���
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

        i = 3 '3�в���ʾ
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBG.Columns.Item(3).FooterText = "�ϼ� ��" & DS_DO.Tables(1).Rows.Count & "��"

        num = 0 '����
        For m = 0 To DS_DO.Tables(1).Rows.Count - 1
            num = num + DS_DO.Tables(1).Rows(m)(3)
        Next
        Me.C1DBG.Columns.Item(3).FooterText = CType(num, String)

        num = 0 '����
        For m = 0 To DS_DO.Tables(1).Rows.Count - 1
            num = num + DS_DO.Tables(1).Rows(m)(5)
        Next
        Me.C1DBG.Columns.Item(5).FooterText = CType(num, String)

        num = 0 '1�ռ���
        For m = 0 To DS_DO.Tables(1).Rows.Count - 1
            num = num + DS_DO.Tables(1).Rows(m)(7)
        Next
        Me.C1DBG.Columns.Item(7).FooterText = CType(num, String)

        num = 0 '2�ռ���
        For m = 0 To DS_DO.Tables(1).Rows.Count - 1
            num = num + DS_DO.Tables(1).Rows(m)(9)
        Next
        Me.C1DBG.Columns.Item(9).FooterText = CType(num, String)

        num = 0 '3�ռ���
        For m = 0 To DS_DO.Tables(1).Rows.Count - 1
            num = num + DS_DO.Tables(1).Rows(m)(11)
        Next
        Me.C1DBG.Columns.Item(11).FooterText = CType(num, String)

        num = 0 '4�ռ���
        For m = 0 To DS_DO.Tables(1).Rows.Count - 1
            num = num + DS_DO.Tables(1).Rows(m)(13)
        Next
        Me.C1DBG.Columns.Item(13).FooterText = CType(num, String)

        num = 0 '5�ռ���
        For m = 0 To DS_DO.Tables(1).Rows.Count - 1
            num = num + DS_DO.Tables(1).Rows(m)(15)
        Next
        Me.C1DBG.Columns.Item(15).FooterText = CType(num, String)

        num = 0 '6�ռ���
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
                    Dim frm As New FrmCARGO_Monitor_do
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
        Call ExportExcel()
    End Sub

    Private Sub mnuExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExport.Click
        Call ExportExcel()
    End Sub

    Private Sub ExportExcel() '����Excel        
        Call MakeExcel()
    End Sub

    Private Sub PrintExcel() '��ӡ��Excel        
        Try
            'If trade = "1" Then
            '    Call china()
            'ElseIf trade = "2" Then
            Call eng()
            'End If
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
        Dim i As Integer  '�ƶ�������
        Dim j As Integer  '������
        Dim q As Integer   '����
        Try
            RecordExcelProcess()
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "Report_zlp.xls", pathstr + "Report.xls")
            Filepath = pathstr + "report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("����ֲյ�"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = False
            xlsheet.Select()
            xlsheet.Cells(9, 1) = "������ " & ds_sship.Tables(0).Rows(0).Item("CHI_VESSEL")
            xlsheet.Cells(9, 6) = "���Σ� " & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            xlsheet.Cells(9, 10) = "������ " & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_CHA")
            xlsheet.Cells(9, 16) = "��λ�� " & DS_DO.Tables(2).Rows(0).Item("berth")
            xlsheet.Cells(9, 13) = "ж���ۣ� " & UNLOADPORT

            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                xlsheet.Cells(10, 3) = Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")) & "��" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")) & "��" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")) & "��"
            End If
            xlsheet.Cells(10, 12) = Year(Now) & "��" & Month(Now) & "��" & Day(Now) & "��"

            For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                xlsheet.Cells(11, 8 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
            Next
            If DS_DO.Tables(1).Rows.Count <= 25 Then  '����
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
            Else  '����
                j = DS_DO.Tables(1).Rows.Count / 24   '������
                q = DS_DO.Tables(1).Rows.Count - 1 - j * 24   '����ϼ��У�ʣ�µ�����
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
                    'ʣ�����һ������
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
                Else 'û������
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
        Dim i As Integer  '�ƶ�������
        Dim j As Integer  '������
        Dim q As Integer   '����
        Dim ds_eng As New DataSet

        Try
            RecordExcelProcess()
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "Report_CARGO.xls", pathstr + "Report.xls")
            Filepath = pathstr + "report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("����ֲյ�(E)"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = False
            xlsheet.Select()
            dw = Getdata("select PORT_ENG from code_port where CODE_PORT='" & UNLOADPORT & "'", ds_eng)

            xlsheet.Cells(9, 1) = "Vessel: " & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
            xlsheet.Cells(9, 6) = "Voy.No: " & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            xlsheet.Cells(9, 10) = "Nationality: " & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
            xlsheet.Cells(9, 16) = "Berth: " & DS_DO.Tables(2).Rows(0).Item("berth")
            If ds_eng.Tables(0).Rows.Count > 0 Then
                xlsheet.Cells(9, 13) = "Port of discharge: " & UNLOADPORT
            End If

            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) = False Then
                xlsheet.Cells(10, 4) = Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")) & "-" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")) & "-" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
            End If
            xlsheet.Cells(10, 13) = Year(Now) & "-" & Month(Now) & "-" & Day(Now)
            For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                xlsheet.Cells(11, 8 + 2 * row) = DS_DO.Tables(0).Rows(row)(0)
            Next
            If DS_DO.Tables(1).Rows.Count <= 25 Then  '����
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
            Else  '����
                j = DS_DO.Tables(1).Rows.Count / 24   '������
                q = DS_DO.Tables(1).Rows.Count - 1 - j * 24   '����ϼ��У�ʣ�µ�����
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
                    'ʣ�����һ������
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
                Else 'û������
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

    Private Sub MakeExcel()
        Dim PathStr As String
        Dim FilePath As String
        Dim Row As Integer
        Dim Col As Integer
       
        Try
            PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
            PathStr = substr(PathStr)
            FileCopy(PathStr + "Report_CARGO.xls", PathStr + "Report.xls")
            FilePath = PathStr + "Report.xls"
            xlApp = CType(CreateObject("excel.application"), Excel.Application)
            xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)
            xlSheet = CType(xlBook.Worksheets(1), Excel.Worksheet)
            xlApp.DisplayAlerts = True
            xlSheet.Application.Visible = True

            xlSheet.Select()
            xlSheet.Cells(1, 1) = Me.Text() '����
            For Col = ColNum To Me.C1DBG.Columns.Count - 1 '�б���
                xlSheet.Cells(3, Col - ColNum + 1) = Me.C1DBG.Columns(Col).Caption
            Next Col
            Me.C1DBG.MoveFirst()
            For Row = 0 To Me.C1DBG.Splits(0).Rows.Count - 1 '����
                For Col = 0 To Me.C1DBG.Columns.Count - 1
                    xlSheet.Cells(Row + 4, Col + 1) = Me.C1DBG.Columns(Col).Text.ToString      'ds.Tables(0).Rows(Row)(Col)
                Next Col
                Me.C1DBG.MoveNext()
            Next Row
            If Me.C1DBG.ColumnFooters = True Then '�ϼ���
                For Col = 0 To Me.C1DBG.Columns.Count - 1
                    xlSheet.Cells(ds.Tables(0).Rows.Count + 4, Col + 1) = Me.C1DBG.Columns(Col).FooterText
                Next Col
            End If
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub preview(ByVal Func As String) '***************Ȩ�����
        Dim sqlstr As String
        Dim Previewdv As DataView
        Dim Previewds As New DataSet
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
            Else                                     'ɾ����ť���ɼ�
                Me.ToolBar.Buttons.Item(5).Enabled = False
                mnuDelete.Enabled = False
            End If
        End If
    End Sub

    Private Sub Frm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.C1DBGV.Height = Me.Height - 140
        Me.C1DBG.Height = Me.Height - 130
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
        SqlStrShip = "where (((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('2','3'))) and Voyage like '" & Trim(txtVoyage.Text) & "%' and (ENG_VESSEL Like '" & Trim(txtShipName.Text) & "%' OR CHI_VESSEL like '" & Trim(txtShipName.Text) & "%' ))  and code_goods<>'2' "
        '����Ҫ�޸�
        G_ShipName = Trim(txtShipName.Text)
        G_Voyage = Trim(txtVoyage.Text)
        Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '����Ҫ�޸�
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
