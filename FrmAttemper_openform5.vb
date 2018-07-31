Imports TALLY.DBControl
Public Class FrmAttemper_openform5
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
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtPERSON As System.Windows.Forms.TextBox
    Friend WithEvents TxtCHI_VESSEL As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents CmbDAYNIGHTMARK As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbWORK_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTPWATCHDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbWork_No As System.Windows.Forms.ComboBox
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents RBgsqt As System.Windows.Forms.RadioButton
    Friend WithEvents RBbzdb As System.Windows.Forms.RadioButton
    Friend WithEvents RBbzqt As System.Windows.Forms.RadioButton
    Friend WithEvents GB2 As System.Windows.Forms.GroupBox
    Friend WithEvents RBbzdb1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbCLERK_NAME As System.Windows.Forms.ComboBox
    Friend WithEvents BtnADD As System.Windows.Forms.Button
    Friend WithEvents RBgsqt1 As System.Windows.Forms.RadioButton
    Friend WithEvents RBbzqt1 As System.Windows.Forms.RadioButton
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents TxtShip_ID As System.Windows.Forms.TextBox
    Friend WithEvents GB3 As System.Windows.Forms.GroupBox
    Friend WithEvents GB4 As System.Windows.Forms.GroupBox
    Friend WithEvents C1DBG1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmAttemper_openform5))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Dim GridLines2 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtPERSON = New System.Windows.Forms.TextBox
        Me.TxtCHI_VESSEL = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.CmbDAYNIGHTMARK = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbWORK_TYPE = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.DTPWATCHDATE = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbWork_No = New System.Windows.Forms.ComboBox
        Me.btnQuit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.GB = New System.Windows.Forms.GroupBox
        Me.BtnADD = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmbCLERK_NAME = New System.Windows.Forms.ComboBox
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.GB3 = New System.Windows.Forms.GroupBox
        Me.RBgsqt1 = New System.Windows.Forms.RadioButton
        Me.RBbzdb1 = New System.Windows.Forms.RadioButton
        Me.RBbzqt1 = New System.Windows.Forms.RadioButton
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.GB2 = New System.Windows.Forms.GroupBox
        Me.RBgsqt = New System.Windows.Forms.RadioButton
        Me.RBbzdb = New System.Windows.Forms.RadioButton
        Me.RBbzqt = New System.Windows.Forms.RadioButton
        Me.TxtShip_ID = New System.Windows.Forms.TextBox
        Me.GB4 = New System.Windows.Forms.GroupBox
        Me.C1DBG1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.GB.SuspendLayout()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB3.SuspendLayout()
        Me.GB2.SuspendLayout()
        Me.GB4.SuspendLayout()
        CType(Me.C1DBG1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(2, 82)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 20)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "理货组长"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(2, 58)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 20)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "人数"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtPERSON
        '
        Me.TxtPERSON.Location = New System.Drawing.Point(60, 56)
        Me.TxtPERSON.MaxLength = 2
        Me.TxtPERSON.Name = "TxtPERSON"
        Me.TxtPERSON.Size = New System.Drawing.Size(88, 21)
        Me.TxtPERSON.TabIndex = 4
        Me.TxtPERSON.Text = ""
        '
        'TxtCHI_VESSEL
        '
        Me.TxtCHI_VESSEL.Location = New System.Drawing.Point(60, 4)
        Me.TxtCHI_VESSEL.MaxLength = 40
        Me.TxtCHI_VESSEL.Name = "TxtCHI_VESSEL"
        Me.TxtCHI_VESSEL.ReadOnly = True
        Me.TxtCHI_VESSEL.Size = New System.Drawing.Size(88, 21)
        Me.TxtCHI_VESSEL.TabIndex = 0
        Me.TxtCHI_VESSEL.TabStop = False
        Me.TxtCHI_VESSEL.Text = ""
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(2, 5)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(56, 20)
        Me.Label27.TabIndex = 79
        Me.Label27.Text = "中文船名"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbDAYNIGHTMARK
        '
        Me.CmbDAYNIGHTMARK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbDAYNIGHTMARK.Enabled = False
        Me.CmbDAYNIGHTMARK.Location = New System.Drawing.Point(214, 30)
        Me.CmbDAYNIGHTMARK.Name = "CmbDAYNIGHTMARK"
        Me.CmbDAYNIGHTMARK.Size = New System.Drawing.Size(94, 20)
        Me.CmbDAYNIGHTMARK.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(154, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "班次"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbWORK_TYPE
        '
        Me.CmbWORK_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbWORK_TYPE.Enabled = False
        Me.CmbWORK_TYPE.Location = New System.Drawing.Point(214, 4)
        Me.CmbWORK_TYPE.Name = "CmbWORK_TYPE"
        Me.CmbWORK_TYPE.Size = New System.Drawing.Size(94, 20)
        Me.CmbWORK_TYPE.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(154, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "班别"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTPWATCHDATE
        '
        Me.DTPWATCHDATE.CustomFormat = "yyyy/MM/dd"
        Me.DTPWATCHDATE.Enabled = False
        Me.DTPWATCHDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPWATCHDATE.Location = New System.Drawing.Point(60, 30)
        Me.DTPWATCHDATE.Name = "DTPWATCHDATE"
        Me.DTPWATCHDATE.Size = New System.Drawing.Size(88, 21)
        Me.DTPWATCHDATE.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "日期"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbWork_No
        '
        Me.CmbWork_No.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbWork_No.Location = New System.Drawing.Point(60, 82)
        Me.CmbWork_No.Name = "CmbWork_No"
        Me.CmbWork_No.Size = New System.Drawing.Size(88, 20)
        Me.CmbWork_No.TabIndex = 5
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(258, 286)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(65, 24)
        Me.btnQuit.TabIndex = 9
        Me.btnQuit.Text = "取消"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(186, 286)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(65, 24)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "确定"
        '
        'GB
        '
        Me.GB.Controls.Add(Me.BtnADD)
        Me.GB.Controls.Add(Me.Label3)
        Me.GB.Controls.Add(Me.CmbCLERK_NAME)
        Me.GB.Controls.Add(Me.C1DBG)
        Me.GB.Controls.Add(Me.GB3)
        Me.GB.Controls.Add(Me.BtnDelete)
        Me.GB.Location = New System.Drawing.Point(2, 106)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(306, 174)
        Me.GB.TabIndex = 7
        Me.GB.TabStop = False
        Me.GB.Text = "理货员"
        '
        'BtnADD
        '
        Me.BtnADD.Location = New System.Drawing.Point(147, 145)
        Me.BtnADD.Name = "BtnADD"
        Me.BtnADD.Size = New System.Drawing.Size(65, 24)
        Me.BtnADD.TabIndex = 3
        Me.BtnADD.Text = "添加"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(125, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "理货员姓名"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbCLERK_NAME
        '
        Me.CmbCLERK_NAME.Location = New System.Drawing.Point(200, 116)
        Me.CmbCLERK_NAME.Name = "CmbCLERK_NAME"
        Me.CmbCLERK_NAME.Size = New System.Drawing.Size(100, 20)
        Me.CmbCLERK_NAME.TabIndex = 2
        '
        'C1DBG
        '
        Me.C1DBG.AllowColMove = False
        Me.C1DBG.AllowFilter = True
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1DBG.AllowSort = True
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.CollapseColor = System.Drawing.Color.Black
        Me.C1DBG.DataChanged = False
        Me.C1DBG.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBG.ExpandColor = System.Drawing.Color.Black
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(3, 16)
        Me.C1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.ShowOptionsDialog = False
        Me.C1DBG.RecordSelectorWidth = 16
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG.RowDivider = GridLines1
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG.ScrollTips = False
        Me.C1DBG.Size = New System.Drawing.Size(300, 94)
        Me.C1DBG.TabIndex = 0
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Style11{}Style12{}FilterBar{}Style5{}Style4{}Style7{}Style6{}EvenRow{Ba" & _
        "ckColor:Aqua;}Selected{ForeColor:HighlightText;BackColor:Highlight;}Heading{Wrap" & _
        ":True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVer" & _
        "t:Center;}Inactive{ForeColor:InactiveCaptionText;BackColor:InactiveCaption;}OddR" & _
        "ow{}Footer{}Caption{AlignHorz:Center;}Normal{}Style10{AlignHorz:Near;}HighlightR" & _
        "ow{ForeColor:HighlightText;BackColor:Highlight;}Editor{}RecordSelector{AlignImag" & _
        "e:Center;}Style9{}Style8{}Style3{}Style2{}Style13{}Group{AlignVert:Center;Border" & _
        ":None,,0, 0, 0, 0;BackColor:ControlDark;}Style1{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView AllowColMove=""False"" Name="""" CaptionHeight=""18"" ColumnCa" & _
        "ptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordS" & _
        "electorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGr" & _
        "oup=""1""><ClientRect>0, 0, 296, 90</ClientRect><BorderSide>0</BorderSide><Caption" & _
        "Style parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" />" & _
        "<EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" " & _
        "me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Gr" & _
        "oup"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowSt" & _
        "yle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Sty" & _
        "le4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""R" & _
        "ecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><St" & _
        "yle parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><Name" & _
        "dStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><St" & _
        "yle parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style" & _
        " parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style " & _
        "parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style " & _
        "parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style paren" & _
        "t=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style" & _
        " parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSpli" & _
        "ts>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>16</DefaultRecSelW" & _
        "idth><ClientArea>0, 0, 296, 90</ClientArea></Blob>"
        '
        'GB3
        '
        Me.GB3.BackColor = System.Drawing.Color.Transparent
        Me.GB3.Controls.Add(Me.RBgsqt1)
        Me.GB3.Controls.Add(Me.RBbzdb1)
        Me.GB3.Controls.Add(Me.RBbzqt1)
        Me.GB3.Location = New System.Drawing.Point(4, 108)
        Me.GB3.Name = "GB3"
        Me.GB3.Size = New System.Drawing.Size(112, 64)
        Me.GB3.TabIndex = 1
        Me.GB3.TabStop = False
        '
        'RBgsqt1
        '
        Me.RBgsqt1.BackColor = System.Drawing.Color.Transparent
        Me.RBgsqt1.Location = New System.Drawing.Point(4, 46)
        Me.RBgsqt1.Name = "RBgsqt1"
        Me.RBgsqt1.Size = New System.Drawing.Size(112, 18)
        Me.RBgsqt1.TabIndex = 2
        Me.RBgsqt1.Text = "公司其他人员"
        '
        'RBbzdb1
        '
        Me.RBbzdb1.BackColor = System.Drawing.Color.Transparent
        Me.RBbzdb1.Location = New System.Drawing.Point(4, 10)
        Me.RBbzdb1.Name = "RBbzdb1"
        Me.RBbzdb1.Size = New System.Drawing.Size(112, 18)
        Me.RBbzdb1.TabIndex = 0
        Me.RBbzdb1.Text = "本班当班人员"
        '
        'RBbzqt1
        '
        Me.RBbzqt1.BackColor = System.Drawing.Color.Transparent
        Me.RBbzqt1.Location = New System.Drawing.Point(4, 28)
        Me.RBbzqt1.Name = "RBbzqt1"
        Me.RBbzqt1.Size = New System.Drawing.Size(112, 18)
        Me.RBbzqt1.TabIndex = 1
        Me.RBbzqt1.Text = "本部其他人员"
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(216, 145)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(65, 24)
        Me.BtnDelete.TabIndex = 4
        Me.BtnDelete.Text = "删除"
        '
        'GB2
        '
        Me.GB2.BackColor = System.Drawing.Color.Transparent
        Me.GB2.Controls.Add(Me.RBgsqt)
        Me.GB2.Controls.Add(Me.RBbzdb)
        Me.GB2.Controls.Add(Me.RBbzqt)
        Me.GB2.Location = New System.Drawing.Point(154, 46)
        Me.GB2.Name = "GB2"
        Me.GB2.Size = New System.Drawing.Size(154, 56)
        Me.GB2.TabIndex = 6
        Me.GB2.TabStop = False
        '
        'RBgsqt
        '
        Me.RBgsqt.BackColor = System.Drawing.Color.Transparent
        Me.RBgsqt.Location = New System.Drawing.Point(102, 10)
        Me.RBgsqt.Name = "RBgsqt"
        Me.RBgsqt.Size = New System.Drawing.Size(50, 46)
        Me.RBgsqt.TabIndex = 2
        Me.RBgsqt.Text = "公司其他人员"
        '
        'RBbzdb
        '
        Me.RBbzdb.BackColor = System.Drawing.Color.Transparent
        Me.RBbzdb.Location = New System.Drawing.Point(2, 10)
        Me.RBbzdb.Name = "RBbzdb"
        Me.RBbzdb.Size = New System.Drawing.Size(50, 46)
        Me.RBbzdb.TabIndex = 0
        Me.RBbzdb.Text = "本班当班人员"
        '
        'RBbzqt
        '
        Me.RBbzqt.BackColor = System.Drawing.Color.Transparent
        Me.RBbzqt.Location = New System.Drawing.Point(52, 10)
        Me.RBbzqt.Name = "RBbzqt"
        Me.RBbzqt.Size = New System.Drawing.Size(50, 46)
        Me.RBbzqt.TabIndex = 1
        Me.RBbzqt.Text = "本部其他人员"
        '
        'TxtShip_ID
        '
        Me.TxtShip_ID.Location = New System.Drawing.Point(8, 290)
        Me.TxtShip_ID.MaxLength = 40
        Me.TxtShip_ID.Name = "TxtShip_ID"
        Me.TxtShip_ID.ReadOnly = True
        Me.TxtShip_ID.Size = New System.Drawing.Size(22, 21)
        Me.TxtShip_ID.TabIndex = 77
        Me.TxtShip_ID.TabStop = False
        Me.TxtShip_ID.Text = ""
        Me.TxtShip_ID.Visible = False
        '
        'GB4
        '
        Me.GB4.Controls.Add(Me.C1DBG1)
        Me.GB4.Location = New System.Drawing.Point(310, 4)
        Me.GB4.Name = "GB4"
        Me.GB4.Size = New System.Drawing.Size(196, 276)
        Me.GB4.TabIndex = 87
        Me.GB4.TabStop = False
        Me.GB4.Text = "已派工情况"
        '
        'C1DBG1
        '
        Me.C1DBG1.AllowColMove = False
        Me.C1DBG1.AllowFilter = True
        Me.C1DBG1.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1DBG1.AllowSort = True
        Me.C1DBG1.AllowUpdate = False
        Me.C1DBG1.CaptionHeight = 18
        Me.C1DBG1.CollapseColor = System.Drawing.Color.Black
        Me.C1DBG1.DataChanged = False
        Me.C1DBG1.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBG1.ExpandColor = System.Drawing.Color.Black
        Me.C1DBG1.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG1.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.C1DBG1.Location = New System.Drawing.Point(3, 16)
        Me.C1DBG1.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG1.Name = "C1DBG1"
        Me.C1DBG1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG1.PreviewInfo.ZoomFactor = 75
        Me.C1DBG1.PrintInfo.ShowOptionsDialog = False
        Me.C1DBG1.RecordSelectorWidth = 16
        GridLines2.Color = System.Drawing.Color.DarkGray
        GridLines2.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG1.RowDivider = GridLines2
        Me.C1DBG1.RowHeight = 16
        Me.C1DBG1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG1.ScrollTips = False
        Me.C1DBG1.Size = New System.Drawing.Size(189, 256)
        Me.C1DBG1.TabIndex = 0
        Me.C1DBG1.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Center;Borde" & _
        "r:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView AllowColMove=""False"" Name="""" CaptionHeight=""18"" ColumnCa" & _
        "ptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordS" & _
        "electorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGr" & _
        "oup=""1""><ClientRect>0, 0, 185, 252</ClientRect><BorderSide>0</BorderSide><Captio" & _
        "nStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /" & _
        "><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar""" & _
        " me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""G" & _
        "roup"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowS" & _
        "tyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""St" & _
        "yle4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""" & _
        "RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><S" & _
        "tyle parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><Nam" & _
        "edStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><S" & _
        "tyle parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Styl" & _
        "e parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style" & _
        " parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style" & _
        " parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style pare" & _
        "nt=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Styl" & _
        "e parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSpl" & _
        "its>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidt" & _
        "h><ClientArea>0, 0, 185, 252</ClientArea></Blob>"
        '
        'FrmAttemper_openform5
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(506, 319)
        Me.Controls.Add(Me.GB4)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.DTPWATCHDATE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbDAYNIGHTMARK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbWORK_TYPE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtCHI_VESSEL)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.TxtPERSON)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CmbWork_No)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.TxtShip_ID)
        Me.Controls.Add(Me.GB2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAttemper_openform5"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "派工"
        Me.GB.ResumeLayout(False)
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB3.ResumeLayout(False)
        Me.GB2.ResumeLayout(False)
        Me.GB4.ResumeLayout(False)
        CType(Me.C1DBG1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim sqlstr As String
    Dim ds As New DataSet()
    Dim ds_sub As New DataSet()
    Dim dw As New DataView()
    Dim dw_sub As New DataView()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim sqlda_Sub As New SqlClient.SqlDataAdapter()
    Dim p As Point

    Private Sub FrmAttemper_openform5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call FillWORK_TYPE()
        Call FillDAYNIGHTMARK()

        On Error GoTo Err
        If GL_Clerk = 1 Then
            BtnADD.Visible = False
            BtnDelete.Visible = False
            btnSave.Visible = False
            btnQuit.Text = "返 回"
            p.X = 199
            p.Y = 286
            btnQuit.Location = p
        Else
            BtnADD.Visible = True
            BtnDelete.Visible = True
            btnSave.Visible = True
        End If
        GL_Clerk = 0

        sqlstr = "select * from TALLY_TEAM where team_id=" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)
        If dw.Count > 0 Then
            TxtShip_ID.Text = ds.Tables(0).Rows(0).Item("Ship_ID")
            TxtCHI_VESSEL.Text = GL_Str
            CmbWORK_TYPE.Text = ds.Tables(0).Rows(0).Item("WORK_TYPE")
            DTPWATCHDATE.Value = ds.Tables(0).Rows(0).Item("WORK_DAY")
            CmbDAYNIGHTMARK.SelectedValue = ds.Tables(0).Rows(0).Item("DayNightMark")
            TxtPERSON.Text = ds.Tables(0).Rows(0).Item("PERSON")
            If IsDBNull(ds.Tables(0).Rows(0).Item("Work_No")) = False Then
                Dim dstmp As New DataSet()
                Dim dwtmp As New DataView()
                dwtmp = Getdata("SELECT DEPT_CODE, TALLY_TEAM, Code_DUTY FROM TALLY_CLERK where work_no='" & ds.Tables(0).Rows(0).Item("Work_No") & "'", dstmp)
                If dwtmp(0)(0) = G_DeptCode And dwtmp(0)(1) = CmbWORK_TYPE.Text And dwtmp(0)(2) = 21 Then
                    Me.RBbzdb.Checked = True
                ElseIf dwtmp(0)(0) = G_DeptCode And dwtmp(0)(1) <> CmbWORK_TYPE.Text Then
                    Me.RBbzqt.Checked = True
                ElseIf dwtmp(0)(0) <> G_DeptCode Then
                    Me.RBgsqt.Checked = True
                End If
                Call FillWork_No()
                CmbWork_No.SelectedValue = ds.Tables(0).Rows(0).Item("Work_No")
            Else
                RBbzdb.Checked = True
                Call FillWork_No()
            End If
        End If

        RBbzdb1.Checked = True
        Call FillCLERK_NAME()

        '***************初始化C1DBG
        sqlstr = "SELECT * FROM TALLY_CLERK_TEAM WHERE TEAM_ID=" & ID & ""
        dw_sub = Getdata(sqlstr, ds_sub)

        Me.C1DBG.DataSource = dw_sub
        Me.C1DBG.Splits(0).DisplayColumns.Item(0).Visible = False
        Me.C1DBG.Splits(0).DisplayColumns.Item(1).Visible = False
        Me.C1DBG.Columns.Item(2).Caption = "工号"
        Me.C1DBG.Columns.Item(3).Caption = "姓名"
        Me.C1DBG.Splits(0).DisplayColumns.Item(2).Width = 100
        Me.C1DBG.Splits(0).DisplayColumns.Item(3).Width = 100
        Me.C1DBG.Refresh()
        Call FillDataGrid()
        If G_DeptCode = "26.11" Then
            BtnADD.Visible = False
            BtnDelete.Visible = False
            btnSave.Visible = False
            btnQuit.Text = "返回"
        End If
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Len(Trim(TxtPERSON.Text)) = 0 Then
                MsgBox("请输入人数！")
                Exit Sub
            End If
            If MsgBox("你确认要修改吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
                Call OperateHistory(G_DeptName, Now, G_User, "修改", "TALLY_TEAM", ID, "team_id")

                ds.Tables(0).Rows(0).Item("Work_No") = CmbWork_No.SelectedValue
                If Len(Trim(TxtPERSON.Text)) > 0 Then
                    If IsNumeric(Trim(TxtPERSON.Text)) Then
                        ds.Tables(0).Rows(0).Item("PERSON") = Trim(TxtPERSON.Text)
                    Else
                        MsgBox("人数一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                        Exit Sub
                    End If
                End If
                ds.Tables(0).Rows(0).Item("USER_NAME") = G_User
                sqlda.Update(ds)


                'sqlstr = "update absent set Code_Holiday_Back=Code_workstat from absent,inserted where dept_code=@dept_Code and absent. Work_No=inserted.Work_No and datediff(dd,absentDate,@Work_Day)=0 and DayNightMark=@DayNightMark and Work_Type=@Work_Type"
                'ExecSql(sqlstr)

                GL_Str = 1
                Call btnQuit_Click(sender, e)
            Else
                GL_Str = 0
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnADD.Click

        sqlstr = "Insert into Tally_Clerk_Team (TEAM_ID,WORK_NO,Name) Values(" & ID & ",'" & Trim(Me.CmbCLERK_NAME.SelectedValue) & "','" & Trim(Me.CmbCLERK_NAME.Text) & "')"
        ExecSql(sqlstr)

        sqlstr = "SELECT * FROM TALLY_CLERK_TEAM WHERE TEAM_ID=" & ID & ""
        dw_sub = Getdata(sqlstr, ds_sub)

        Me.C1DBG.DataSource = dw_sub
        Me.C1DBG.Splits(0).DisplayColumns.Item(0).Visible = False
        Me.C1DBG.Splits(0).DisplayColumns.Item(1).Visible = False
        Me.C1DBG.Columns.Item(2).Caption = "工号"
        Me.C1DBG.Columns.Item(3).Caption = "姓名"
        Me.C1DBG.Splits(0).DisplayColumns.Item(2).Width = 100
        Me.C1DBG.Splits(0).DisplayColumns.Item(3).Width = 100
        Me.C1DBG.Refresh()

        Call FillDataGrid()

    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click

        sqlstr = "delete from Tally_Clerk_Team where Team_ID=" & ID & " and Work_No='" & Trim(Me.C1DBG.Columns.Item("Work_No").Text) & "'"
        ExecSql(sqlstr)

        sqlstr = "SELECT * FROM TALLY_CLERK_TEAM WHERE TEAM_ID=" & ID & ""
        dw_sub = Getdata(sqlstr, ds_sub)

        Me.C1DBG.DataSource = dw_sub
        Me.C1DBG.Splits(0).DisplayColumns.Item(0).Visible = False
        Me.C1DBG.Splits(0).DisplayColumns.Item(1).Visible = False
        Me.C1DBG.Columns.Item(2).Caption = "工号"
        Me.C1DBG.Columns.Item(3).Caption = "姓名"
        Me.C1DBG.Splits(0).DisplayColumns.Item(2).Width = 100
        Me.C1DBG.Splits(0).DisplayColumns.Item(3).Width = 100
        Me.C1DBG.Refresh()

        Call FillDataGrid()

    End Sub

    Private Sub FillWORK_TYPE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "SELECT WORK_TYPE FROM WORK_BEGIN WHERE DEPT_CODE='" & G_DeptCode & "' ORDER BY TIME_FROM, DayNightMark"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbWORK_TYPE.DataSource = dvc
        Me.CmbWORK_TYPE.DisplayMember = "WORK_TYPE"
        Me.CmbWORK_TYPE.ValueMember = "WORK_TYPE"
    End Sub

    Private Sub FillDAYNIGHTMARK()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "SELECT Code_WorkTime,WorkTime FROM Code_WorkTime"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbDAYNIGHTMARK.DataSource = dvc
        Me.CmbDAYNIGHTMARK.DisplayMember = "WorkTime"
        Me.CmbDAYNIGHTMARK.ValueMember = "Code_WorkTime"
    End Sub

    Private Sub FillWork_No()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()

        If Me.RBbzdb.Checked = True Then
            sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE Code_DUTY ='21' and DEPT_CODE='" & G_DeptCode & "' and TALLY_TEAM='" & CmbWORK_TYPE.Text & "' order by NAME "
        End If

        If Me.RBbzqt.Checked = True Then
            sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE DEPT_CODE='" & G_DeptCode & "'" ' and TALLY_TEAM!='" & CmbWORK_TYPE.Text & "' order by NAME "
        End If

        If Me.RBgsqt.Checked = True Then
            sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE DEPT_CODE!='" & G_DeptCode & "' order by NAME"
        End If
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbWork_No.DataSource = dvc
        Me.CmbWork_No.DisplayMember = "NAME"
        Me.CmbWork_No.ValueMember = "WORK_NO"
    End Sub

    Private Sub FillCLERK_NAME()
        Dim sqldc As String
        Dim dsc As New DataSet()
        Dim dvc As DataView

        If Me.RBbzdb1.Checked = True Then
            sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE DEPT_CODE='" & G_DeptCode & "' and TALLY_TEAM='" & CmbWORK_TYPE.Text & "' "
        End If

        If Me.RBbzqt1.Checked = True Then
            sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE DEPT_CODE='" & G_DeptCode & "'" ' and TALLY_TEAM!='" & CmbWORK_TYPE.Text & "' "
        End If

        If Me.RBgsqt1.Checked = True Then
            sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE DEPT_CODE!='" & G_DeptCode & "'"
        End If
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbCLERK_NAME.DataSource = dvc
        Me.CmbCLERK_NAME.DisplayMember = "NAME"
        Me.CmbCLERK_NAME.ValueMember = "WORK_NO"
    End Sub

    Private Sub FillDataGrid()                      '*******************************已派工情况
        Dim ds_tmp As New DataSet()
        Dim dw_tmp As New DataView()

        sqlstr = "select ABSENT_ID,WORK_NO,Code_HOLIDAY_TYPE,Code_workstat from ABSENT where DEPT_CODE like '" & G_DeptCode & "%' and datediff(dd,ABSENTDATE,'" & DTPWATCHDATE.Value & "')=0 and WORK_TYPE='" & CmbWORK_TYPE.Text & "' ORDER BY Code_HOLIDAY_TYPE "
        dw_tmp = Getdata(sqlstr, ds_tmp)

        If dw_tmp.Count > 0 Then
            '***************定义派工情况表
            Dim i As Integer
            Dim dst As New DataSet()
            Dim sqla As New SqlClient.SqlDataAdapter()
            Dim sqlc As New SqlClient.SqlCommand()

            Me.C1DBG1.DataSource = dw_tmp

            'For i = 0 To Me.C1DBG1.Columns.Count - 1
            '    Me.C1DBG1.Splits(0).DisplayColumns.Item(i).Visible = False
            'Next
            Me.C1DBG1.Splits(0).DisplayColumns.Item("ABSENT_ID").Visible = False
            'Me.C1DBG1.Splits(0).DisplayColumns.Item("WORK_NO").Visible = True
            'Me.C1DBG1.Splits(0).DisplayColumns.Item("Code_HOLIDAY_TYPE").Visible = True

            Me.C1DBG1.Columns.Item("WORK_NO").Caption = "姓名"
            Me.C1DBG1.Columns.Item("Code_HOLIDAY_TYPE").Caption = "假别"
            Me.C1DBG1.Columns.Item("Code_workstat").Caption = "工作状态"
            Me.C1DBG1.Splits(0).DisplayColumns.Item("WORK_NO").Width = 50
            Me.C1DBG1.Splits(0).DisplayColumns.Item("Code_HOLIDAY_TYPE").Width = 50
            Me.C1DBG1.Splits(0).DisplayColumns.Item("Code_workstat").Width = 70
            Me.C1DBG1.Refresh()

            '***************姓名
            Me.C1DBG1.Columns.Item("WORK_NO").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG1.Columns.Item("WORK_NO").ValueItems.Translate = True
            Me.C1DBG1.Columns.Item("WORK_NO").ValueItems.Validate = True
            Me.C1DBG1.Splits(0).DisplayColumns.Item("WORK_NO").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT NAME, WORK_NO FROM TALLY_CLERK"
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("NAME"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("WORK_NO"))
                Me.C1DBG1.Columns.Item("WORK_NO").ValueItems.Values.Add(vi)
            Next

            '***************假别
            Me.C1DBG1.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG1.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Translate = True
            Me.C1DBG1.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Validate = True
            Me.C1DBG1.Splits(0).DisplayColumns.Item("Code_HOLIDAY_TYPE").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT Code_Holiday_Type,Holiday_Type FROM Code_Holiday_Type order by convert(int,Code_Holiday_Type) "
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("Holiday_Type"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("Code_Holiday_Type"))
                Me.C1DBG1.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Values.Add(vi)
            Next

            '***************状态
            Me.C1DBG1.Columns.Item("Code_workstat").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG1.Columns.Item("Code_workstat").ValueItems.Translate = True
            Me.C1DBG1.Columns.Item("Code_workstat").ValueItems.Validate = True
            Me.C1DBG1.Splits(0).DisplayColumns.Item("Code_workstat").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT Code_workstat,workstat FROM Code_workstat" ' order by convert(int,Code_workstat) "
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("workstat"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("Code_workstat"))
                Me.C1DBG1.Columns.Item("Code_workstat").ValueItems.Values.Add(vi)
            Next
        End If
    End Sub

    Private Sub RBbzdb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBbzdb.CheckedChanged
        Call FillWork_No()
    End Sub

    Private Sub RBbzqt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBbzqt.CheckedChanged
        Call FillWork_No()
    End Sub

    Private Sub RBgsqt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBgsqt.CheckedChanged
        Call FillWork_No()
    End Sub

    Private Sub RBbzdb1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBbzdb1.CheckedChanged
        Call FillCLERK_NAME()
    End Sub

    Private Sub RBbzqt1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBbzqt1.CheckedChanged
        Call FillCLERK_NAME()
    End Sub

    Private Sub RBgsqt1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBgsqt1.CheckedChanged
        Call FillCLERK_NAME()
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        ID = TxtShip_ID.Text
        Me.Close()
    End Sub

End Class
