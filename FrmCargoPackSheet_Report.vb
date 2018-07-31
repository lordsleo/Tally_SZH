Imports TALLY.DBControl
Public Class FrmCargoPackSheet_Report
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        AddHandler cbBillNo.KeyDown, AddressOf FrmCargoPackSheet_Report_KeyDown
        AddHandler dtpWorkDate.KeyDown, AddressOf FrmCargoPackSheet_Report_KeyDown
        AddHandler cbDayOrNight.KeyDown, AddressOf FrmCargoPackSheet_Report_KeyDown
        AddHandler cbBillNo.KeyDown, AddressOf FrmCargoPackSheet_Report_KeyDown

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbVessel As System.Windows.Forms.Label
    Friend WithEvents lbBerthNo As System.Windows.Forms.Label
    Friend WithEvents lbDate As System.Windows.Forms.Label
    Friend WithEvents lbTime1 As System.Windows.Forms.Label
    Friend WithEvents lbTime2 As System.Windows.Forms.Label
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents cbDayOrNight As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbBillNo As System.Windows.Forms.ComboBox
    Friend WithEvents dtpWorkDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lbCargo As System.Windows.Forms.Label
    Friend WithEvents lbStandWeight As System.Windows.Forms.Label
    Friend WithEvents C1DBGP As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1DBGC As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1DBGI As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1DBGA As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1DBGF As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCargoPackSheet_Report))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Dim GridLines2 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Dim GridLines3 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Dim GridLines4 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Dim GridLines5 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbVessel = New System.Windows.Forms.Label
        Me.lbBerthNo = New System.Windows.Forms.Label
        Me.lbDate = New System.Windows.Forms.Label
        Me.lbTime1 = New System.Windows.Forms.Label
        Me.lbTime2 = New System.Windows.Forms.Label
        Me.txtNo = New System.Windows.Forms.TextBox
        Me.cbDayOrNight = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbBillNo = New System.Windows.Forms.ComboBox
        Me.dtpWorkDate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.lbCargo = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.C1DBGP = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1DBGC = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lbStandWeight = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.C1DBGI = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label15 = New System.Windows.Forms.Label
        Me.C1DBGA = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label16 = New System.Windows.Forms.Label
        Me.C1DBGF = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btnPrint = New System.Windows.Forms.Button
        CType(Me.C1DBGP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DBGC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DBGI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DBGA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DBGF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "船名："
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(156, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "泊位："
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(228, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "起迄时间"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(326, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "编号："
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbVessel
        '
        Me.lbVessel.Location = New System.Drawing.Point(74, 98)
        Me.lbVessel.Name = "lbVessel"
        Me.lbVessel.Size = New System.Drawing.Size(80, 20)
        Me.lbVessel.TabIndex = 4
        Me.lbVessel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbBerthNo
        '
        Me.lbBerthNo.Location = New System.Drawing.Point(222, 98)
        Me.lbBerthNo.Name = "lbBerthNo"
        Me.lbBerthNo.Size = New System.Drawing.Size(58, 20)
        Me.lbBerthNo.TabIndex = 5
        Me.lbBerthNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbDate
        '
        Me.lbDate.Location = New System.Drawing.Point(294, 64)
        Me.lbDate.Name = "lbDate"
        Me.lbDate.Size = New System.Drawing.Size(80, 20)
        Me.lbDate.TabIndex = 6
        Me.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbTime1
        '
        Me.lbTime1.Location = New System.Drawing.Point(374, 54)
        Me.lbTime1.Name = "lbTime1"
        Me.lbTime1.Size = New System.Drawing.Size(80, 20)
        Me.lbTime1.TabIndex = 7
        Me.lbTime1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbTime2
        '
        Me.lbTime2.Location = New System.Drawing.Point(374, 74)
        Me.lbTime2.Name = "lbTime2"
        Me.lbTime2.Size = New System.Drawing.Size(80, 20)
        Me.lbTime2.TabIndex = 8
        Me.lbTime2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNo
        '
        Me.txtNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNo.Location = New System.Drawing.Point(392, 98)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(62, 21)
        Me.txtNo.TabIndex = 4
        Me.txtNo.Text = ""
        '
        'cbDayOrNight
        '
        Me.cbDayOrNight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDayOrNight.Location = New System.Drawing.Point(388, 10)
        Me.cbDayOrNight.Name = "cbDayOrNight"
        Me.cbDayOrNight.Size = New System.Drawing.Size(66, 20)
        Me.cbDayOrNight.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(328, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 520
        Me.Label5.Text = "白夜班"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(170, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 20)
        Me.Label6.TabIndex = 519
        Me.Label6.Text = "完工日期"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbBillNo
        '
        Me.cbBillNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBillNo.Location = New System.Drawing.Point(68, 8)
        Me.cbBillNo.MaxLength = 20
        Me.cbBillNo.Name = "cbBillNo"
        Me.cbBillNo.Size = New System.Drawing.Size(100, 20)
        Me.cbBillNo.TabIndex = 0
        '
        'dtpWorkDate
        '
        Me.dtpWorkDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpWorkDate.Location = New System.Drawing.Point(230, 8)
        Me.dtpWorkDate.Name = "dtpWorkDate"
        Me.dtpWorkDate.Size = New System.Drawing.Size(96, 21)
        Me.dtpWorkDate.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(8, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 20)
        Me.Label7.TabIndex = 518
        Me.Label7.Text = "提单号"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCargo
        '
        Me.lbCargo.Location = New System.Drawing.Point(74, 64)
        Me.lbCargo.Name = "lbCargo"
        Me.lbCargo.Size = New System.Drawing.Size(132, 20)
        Me.lbCargo.TabIndex = 522
        Me.lbCargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 20)
        Me.Label9.TabIndex = 521
        Me.Label9.Text = "货名："
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(406, 440)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 524
        Me.btQuit.Text = "退出"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(214, 36)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 22)
        Me.btSave.TabIndex = 3
        Me.btSave.Text = "确定"
        '
        'C1DBGP
        '
        Me.C1DBGP.AllowFilter = False
        Me.C1DBGP.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGP.AllowSort = True
        Me.C1DBGP.AllowUpdate = False
        Me.C1DBGP.CaptionHeight = 18
        Me.C1DBGP.CollapseColor = System.Drawing.Color.Black
        Me.C1DBGP.DataChanged = False
        Me.C1DBGP.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBGP.ExpandColor = System.Drawing.Color.Black
        Me.C1DBGP.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGP.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBGP.Location = New System.Drawing.Point(8, 150)
        Me.C1DBGP.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBGP.Name = "C1DBGP"
        Me.C1DBGP.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGP.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGP.PreviewInfo.ZoomFactor = 75
        Me.C1DBGP.PrintInfo.ShowOptionsDialog = False
        Me.C1DBGP.RecordSelectorWidth = 16
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBGP.RowDivider = GridLines1
        Me.C1DBGP.RowHeight = 16
        Me.C1DBGP.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBGP.ScrollTips = False
        Me.C1DBGP.Size = New System.Drawing.Size(236, 72)
        Me.C1DBGP.TabIndex = 5
        Me.C1DBGP.Text = "C1DBG"
        Me.C1DBGP.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        "roup=""1""><ClientRect>0, 0, 232, 68</ClientRect><BorderSide>0</BorderSide><Captio" & _
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
        "h><ClientArea>0, 0, 232, 68</ClientArea></Blob>"
        '
        'C1DBGC
        '
        Me.C1DBGC.AllowFilter = False
        Me.C1DBGC.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGC.AllowSort = True
        Me.C1DBGC.AllowUpdate = False
        Me.C1DBGC.CaptionHeight = 18
        Me.C1DBGC.CollapseColor = System.Drawing.Color.Black
        Me.C1DBGC.DataChanged = False
        Me.C1DBGC.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBGC.ExpandColor = System.Drawing.Color.Black
        Me.C1DBGC.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGC.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.C1DBGC.Location = New System.Drawing.Point(8, 354)
        Me.C1DBGC.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBGC.Name = "C1DBGC"
        Me.C1DBGC.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGC.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGC.PreviewInfo.ZoomFactor = 75
        Me.C1DBGC.PrintInfo.ShowOptionsDialog = False
        Me.C1DBGC.RecordSelectorWidth = 16
        GridLines2.Color = System.Drawing.Color.DarkGray
        GridLines2.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBGC.RowDivider = GridLines2
        Me.C1DBGC.RowHeight = 16
        Me.C1DBGC.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBGC.ScrollTips = False
        Me.C1DBGC.Size = New System.Drawing.Size(472, 72)
        Me.C1DBGC.TabIndex = 9
        Me.C1DBGC.Text = "C1TrueDBGrid1"
        Me.C1DBGC.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        "roup=""1""><ClientRect>0, 0, 468, 68</ClientRect><BorderSide>0</BorderSide><Captio" & _
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
        "h><ClientArea>0, 0, 468, 68</ClientArea></Blob>"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(10, 334)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 20)
        Me.Label10.TabIndex = 527
        Me.Label10.Text = "抽检结果"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(10, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 20)
        Me.Label11.TabIndex = 528
        Me.Label11.Text = "本班灌包数"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbStandWeight
        '
        Me.lbStandWeight.Location = New System.Drawing.Point(400, 124)
        Me.lbStandWeight.Name = "lbStandWeight"
        Me.lbStandWeight.Size = New System.Drawing.Size(80, 20)
        Me.lbStandWeight.TabIndex = 530
        Me.lbStandWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(334, 124)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 20)
        Me.Label13.TabIndex = 529
        Me.Label13.Text = "标准件重："
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(246, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 20)
        Me.Label14.TabIndex = 532
        Me.Label14.Text = "本日小计"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'C1DBGI
        '
        Me.C1DBGI.AllowFilter = False
        Me.C1DBGI.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGI.AllowSort = True
        Me.C1DBGI.AllowUpdate = False
        Me.C1DBGI.CaptionHeight = 18
        Me.C1DBGI.CollapseColor = System.Drawing.Color.Black
        Me.C1DBGI.DataChanged = False
        Me.C1DBGI.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBGI.ExpandColor = System.Drawing.Color.Black
        Me.C1DBGI.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGI.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.C1DBGI.Location = New System.Drawing.Point(244, 150)
        Me.C1DBGI.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBGI.Name = "C1DBGI"
        Me.C1DBGI.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGI.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGI.PreviewInfo.ZoomFactor = 75
        Me.C1DBGI.PrintInfo.ShowOptionsDialog = False
        Me.C1DBGI.RecordSelectorWidth = 16
        GridLines3.Color = System.Drawing.Color.DarkGray
        GridLines3.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBGI.RowDivider = GridLines3
        Me.C1DBGI.RowHeight = 16
        Me.C1DBGI.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBGI.ScrollTips = False
        Me.C1DBGI.Size = New System.Drawing.Size(236, 72)
        Me.C1DBGI.TabIndex = 6
        Me.C1DBGI.Text = "C1TrueDBGrid2"
        Me.C1DBGI.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        "roup=""1""><ClientRect>0, 0, 232, 68</ClientRect><BorderSide>0</BorderSide><Captio" & _
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
        "h><ClientArea>0, 0, 232, 68</ClientArea></Blob>"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(246, 226)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 20)
        Me.Label15.TabIndex = 536
        Me.Label15.Text = "总计"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'C1DBGA
        '
        Me.C1DBGA.AllowFilter = False
        Me.C1DBGA.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGA.AllowSort = True
        Me.C1DBGA.AllowUpdate = False
        Me.C1DBGA.CaptionHeight = 18
        Me.C1DBGA.CollapseColor = System.Drawing.Color.Black
        Me.C1DBGA.DataChanged = False
        Me.C1DBGA.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBGA.ExpandColor = System.Drawing.Color.Black
        Me.C1DBGA.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGA.Images.Add(CType(resources.GetObject("resource3"), System.Drawing.Image))
        Me.C1DBGA.Location = New System.Drawing.Point(244, 248)
        Me.C1DBGA.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBGA.Name = "C1DBGA"
        Me.C1DBGA.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGA.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGA.PreviewInfo.ZoomFactor = 75
        Me.C1DBGA.PrintInfo.ShowOptionsDialog = False
        Me.C1DBGA.RecordSelectorWidth = 16
        GridLines4.Color = System.Drawing.Color.DarkGray
        GridLines4.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBGA.RowDivider = GridLines4
        Me.C1DBGA.RowHeight = 16
        Me.C1DBGA.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBGA.ScrollTips = False
        Me.C1DBGA.Size = New System.Drawing.Size(236, 72)
        Me.C1DBGA.TabIndex = 8
        Me.C1DBGA.Text = "C1TrueDBGrid3"
        Me.C1DBGA.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        "roup=""1""><ClientRect>0, 0, 232, 68</ClientRect><BorderSide>0</BorderSide><Captio" & _
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
        "h><ClientArea>0, 0, 232, 68</ClientArea></Blob>"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(10, 226)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 20)
        Me.Label16.TabIndex = 534
        Me.Label16.Text = "前日累计"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'C1DBGF
        '
        Me.C1DBGF.AllowFilter = False
        Me.C1DBGF.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGF.AllowSort = True
        Me.C1DBGF.AllowUpdate = False
        Me.C1DBGF.CaptionHeight = 18
        Me.C1DBGF.CollapseColor = System.Drawing.Color.Black
        Me.C1DBGF.DataChanged = False
        Me.C1DBGF.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBGF.ExpandColor = System.Drawing.Color.Black
        Me.C1DBGF.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGF.Images.Add(CType(resources.GetObject("resource4"), System.Drawing.Image))
        Me.C1DBGF.Location = New System.Drawing.Point(8, 248)
        Me.C1DBGF.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBGF.Name = "C1DBGF"
        Me.C1DBGF.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGF.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGF.PreviewInfo.ZoomFactor = 75
        Me.C1DBGF.PrintInfo.ShowOptionsDialog = False
        Me.C1DBGF.RecordSelectorWidth = 16
        GridLines5.Color = System.Drawing.Color.DarkGray
        GridLines5.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBGF.RowDivider = GridLines5
        Me.C1DBGF.RowHeight = 16
        Me.C1DBGF.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBGF.ScrollTips = False
        Me.C1DBGF.Size = New System.Drawing.Size(236, 72)
        Me.C1DBGF.TabIndex = 7
        Me.C1DBGF.Text = "C1TrueDBGrid4"
        Me.C1DBGF.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        "roup=""1""><ClientRect>0, 0, 232, 68</ClientRect><BorderSide>0</BorderSide><Captio" & _
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
        "h><ClientArea>0, 0, 232, 68</ClientArea></Blob>"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(208, 440)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(65, 24)
        Me.btnPrint.TabIndex = 537
        Me.btnPrint.Text = "打印"
        '
        'FrmCargoPackSheet_Report
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(502, 481)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.C1DBGA)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.C1DBGF)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.C1DBGI)
        Me.Controls.Add(Me.lbStandWeight)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.C1DBGC)
        Me.Controls.Add(Me.C1DBGP)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.lbCargo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbDayOrNight)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbBillNo)
        Me.Controls.Add(Me.dtpWorkDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNo)
        Me.Controls.Add(Me.lbTime2)
        Me.Controls.Add(Me.lbTime1)
        Me.Controls.Add(Me.lbDate)
        Me.Controls.Add(Me.lbBerthNo)
        Me.Controls.Add(Me.lbVessel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargoPackSheet_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "散货灌包理货单信息 工班日报"
        CType(Me.C1DBGP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DBGC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DBGI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DBGA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DBGF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim dvBillNo As New DataView
    Dim dvDayNight As New DataView
    Dim dvDateTime As New DataView
    Dim dStandWeight As Decimal

    Private Sub FrmCargoPackSheet_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sqlBillNo As String
        sqlBillNo = "SELECT * FROM CARGO_GOODS WHERE SHIP_ID = '" & Ship_ID & "' order by CARGO_GOODS_ID desc"
        dvBillNo = Filldata(sqlBillNo)
        Me.cbBillNo.DataSource = dvBillNo
        Me.cbBillNo.DisplayMember = "BLNO"
        Me.cbBillNo.ValueMember = "BLNO"

        Dim sqlDayNight As String
        sqlDayNight = "SELECT * FROM Code_WorkTime WHERE Code_WorkTime <> '00' ORDER BY WorkTime"
        dvDayNight = Filldata(sqlDayNight)
        Me.cbDayOrNight.DataSource = dvDayNight
        Me.cbDayOrNight.DisplayMember = "WorkTime"
        Me.cbDayOrNight.ValueMember = "Code_WorkTime"

        Dim sqlDateTime As String
        sqlDateTime = "SELECT DAY_TIME, NIGHT_TIME FROM WORK_TIME WHERE (WORK_TIME_ID = 1)"
        dvDateTime = Filldata(sqlDateTime)

        dtpWorkDate.CustomFormat = "yyyy'-'MM'-'dd"

        Me.cbBillNo.SelectedValue = FrmCargoPackSheet.strBillNo
        Me.dtpWorkDate.Value = FrmCargoPackSheet.dtWorkDate
        Me.cbDayOrNight.SelectedValue = FrmCargoPackSheet.strDayNight
        Me.lbVessel.Text = FrmCargoPackSheet.strVesselName

    End Sub

    Private Sub cbBillNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBillNo.SelectedIndexChanged
        Try
            Dim a As Integer
            If GetType(String).Equals(cbBillNo.SelectedValue.GetType) Then
                Me.lbCargo.Text = dvBillNo(Me.cbBillNo.SelectedIndex)("CODE_GOODS")
                If Not IsDBNull(dvBillNo(Me.cbBillNo.SelectedIndex)("BERTHNO")) Then
                    Me.lbBerthNo.Text = dvBillNo(Me.cbBillNo.SelectedIndex)("BERTHNO")
                End If
                Me.lbStandWeight.Text = dvBillNo(Me.cbBillNo.SelectedIndex)("StandsWeight") & "公斤"
                dStandWeight = dvBillNo(Me.cbBillNo.SelectedIndex)("StandsWeight")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbDayOrNight_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDayOrNight.SelectedIndexChanged
        Try
            If GetType(String).Equals(Me.cbDayOrNight.SelectedValue.GetType) Then
                If Me.cbDayOrNight.SelectedValue = "01" Then    '白班
                    Me.lbTime1.Text = Me.dtpWorkDate.Value.Day & "日" & dvDateTime(0)("DAY_TIME") & "时"
                    Me.lbTime2.Text = Me.dtpWorkDate.Value.Day & "日" & dvDateTime(0)("NIGHT_TIME") & "时"
                Else    '夜班
                    Me.lbTime1.Text = Me.dtpWorkDate.Value.Day & "日" & dvDateTime(0)("NIGHT_TIME") & "时"
                    Me.lbTime2.Text = Me.dtpWorkDate.Value.AddDays(1).Day & "日" & dvDateTime(0)("DAY_TIME") & "时"
                End If
                Me.lbDate.Text = Me.dtpWorkDate.Value.Year & "年" & Me.dtpWorkDate.Value.Month & "月"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Dim dvGetCheck As New DataView
    Dim dvGetP As New DataView
    Dim dvGetI As New DataView
    Dim dvGetF As New DataView
    Dim dvGetA As New DataView
    Dim dsGetp As New DataSet
    Dim dsGeti As New DataSet
    Dim dsGetf As New DataSet
    Dim dsGeta As New DataSet

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim sqlGetP As String
        sqlGetP = "SELECT P_M_TYPE, Name_PM, SUM(Pack_Amount) AS Pack_Amount " & _
                    "FROM CARGO_PACK_SHEET LEFT OUTER JOIN Code_PMType ON P_M_TYPE = Code_PM " & _
                    "WHERE SHIP_ID = '" & Ship_ID & "' AND BLNO = '" & Me.cbBillNo.Text & "' AND DayOrNight = '" & Me.cbDayOrNight.SelectedValue & "' AND DATEPART(DAYOFYEAR, WorkDate) = '" & Me.dtpWorkDate.Value.DayOfYear & "' " & _
                    "GROUP BY P_M_TYPE, Name_PM ORDER BY P_M_TYPE DESC"
        Getdata(sqlGetP, dsGetp)
        Dim sqlGetI As String
        'If Me.cbDayOrNight.SelectedValue = "01" Then    '白班, 当天的白班加昨天的夜班 为当天一天的班
        '    sqlGetI = "SELECT P_M_TYPE, Name_PM, SUM(Pack_Amount) AS Pack_Amount " & _
        '            "FROM CARGO_PACK_SHEET LEFT OUTER JOIN Code_PMType ON P_M_TYPE = Code_PM " & _
        '            "WHERE SHIP_ID = '" & Ship_ID & "' AND BLNO = '" & Me.cbBillNo.Text & "' AND ((DayOrNight = '01' AND DATEPART(DAYOFYEAR, WorkDate) = '" & Me.dtpWorkDate.Value.DayOfYear & "') or (DayOrNight = '02' AND DATEPART(DAYOFYEAR, WorkDate) = '" & Me.dtpWorkDate.Value.DayOfYear - 1 & "')) " & _
        '            "GROUP BY P_M_TYPE, Name_PM "
        'Else    '夜班
        '    sqlGetI = sqlGetP
        'End If
        sqlGetI = "SELECT P_M_TYPE, Name_PM, SUM(Pack_Amount) AS Pack_Amount " & _
                    "FROM CARGO_PACK_SHEET LEFT OUTER JOIN Code_PMType ON P_M_TYPE = Code_PM " & _
                    "WHERE SHIP_ID = '" & Ship_ID & "' AND BLNO = '" & Me.cbBillNo.Text & "' AND DATEPART(DAYOFYEAR, WorkDate) = '" & Me.dtpWorkDate.Value.DayOfYear & "' " & _
                    "GROUP BY P_M_TYPE, Name_PM ORDER BY P_M_TYPE DESC"
        dvGetI = Getdata(sqlGetI, dsGeti)
        Dim sqlGetF As String   '跨元旦作业的会出错，要改的
        sqlGetF = "SELECT P_M_TYPE, Name_PM, SUM(Pack_Amount) AS Pack_Amount " & _
                    "FROM CARGO_PACK_SHEET LEFT OUTER JOIN Code_PMType ON P_M_TYPE = Code_PM " & _
                    "WHERE SHIP_ID = '" & Ship_ID & "' AND BLNO = '" & Me.cbBillNo.Text & "' AND DATEPART(DAYOFYEAR, WorkDate) < '" & Me.dtpWorkDate.Value.DayOfYear & "' " & _
                    "GROUP BY P_M_TYPE, Name_PM ORDER BY P_M_TYPE DESC"
        Getdata(sqlGetF, dsGetf)
        Dim sqlGetA As String
        sqlGetA = "SELECT P_M_TYPE, Name_PM, SUM(Pack_Amount) AS Pack_Amount " & _
                    "FROM CARGO_PACK_SHEET LEFT OUTER JOIN Code_PMType ON P_M_TYPE = Code_PM " & _
                    "WHERE SHIP_ID = '" & Ship_ID & "' AND BLNO = '" & Me.cbBillNo.Text & "' AND DATEPART(DAYOFYEAR, WorkDate) <= '" & Me.dtpWorkDate.Value.DayOfYear & "' " & _
                    "GROUP BY P_M_TYPE, Name_PM ORDER BY P_M_TYPE DESC"
        Getdata(sqlGetA, dsGeta)

        Call FillC1(dvGetP, dsGetp, Me.C1DBGP)
        Call FillC1(dvGetI, dsGeti, Me.C1DBGI)
        Call FillC1(dvGetF, dsGetf, Me.C1DBGF)
        Call FillC1(dvGetA, dsGeta, Me.C1DBGA)

        Dim sqlGetCheck As String
        sqlGetCheck = "SELECT P_M_TYPE, Name_PM, Test_Amount, ELIGIBLE_Rate, AVERAGE_WEIGHT " & _
            "FROM CARGO_PACK_Sample LEFT OUTER JOIN Code_PMType ON P_M_TYPE = Code_PM " & _
            "WHERE (SHIP_ID = '" & Ship_ID & "') AND (BillNO = '" & Me.cbBillNo.Text & "') AND (DATEPART(dy, TestDate) = '" & Me.dtpWorkDate.Value.DayOfYear & "') AND (DayOrNight = '" & Me.cbDayOrNight.SelectedValue & "') " & _
            "ORDER BY P_M_TYPE DESC"
        dvGetCheck = Filldata(sqlGetCheck)
        Me.C1DBGC.DataSource = dvGetCheck
        'Me.C1DBGC.AllowUpdate = True
        Me.C1DBGC.AllowSort = False
        Me.C1DBGC.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.C1DBGC.Splits(0).DisplayColumns("P_M_TYPE").Visible = False
        Me.C1DBGC.Columns("Name_PM").Caption = "人机别"
        Me.C1DBGC.Columns("Test_Amount").Caption = "抽重件数"
        Me.C1DBGC.Columns("ELIGIBLE_Rate").Caption = "合格率"
        Me.C1DBGC.Columns("AVERAGE_WEIGHT").Caption = "平均件重"

    End Sub
    Private Sub FillC1(ByRef dv As DataView, ByRef ds As DataSet, ByRef C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid)
        ds.Tables(0).Columns.Add("Weight", GetType(Decimal))
        dv = ds.Tables(0).DefaultView
        C1DBG.DataSource = dv
        Try
            Dim i As Integer
            C1DBG.Focus()
            For i = 0 To dv.Count - 1
                C1DBG.Row = i
                C1DBG.Columns("Weight").Text = Decimal.Round(CDec(C1DBG.Columns("Pack_Amount").Text * dStandWeight / 1000), 3)
            Next
            Me.btQuit.Focus()

            C1DBG.AllowUpdate = True
            C1DBG.AllowSort = False
            C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
            C1DBG.Splits(0).DisplayColumns("P_M_TYPE").Visible = False
            C1DBG.Columns("Name_PM").Caption = "人机别"
            C1DBG.Columns("Pack_Amount").Caption = "灌包件数"
            C1DBG.Columns("Weight").Caption = "灌包吨数"
            C1DBG.Splits(0).DisplayColumns("Name_PM").Locked = True
            C1DBG.Splits(0).DisplayColumns("Pack_Amount").Locked = True
            C1DBG.Splits(0).DisplayColumns("Name_PM").Width = 40
            C1DBG.Splits(0).DisplayColumns("Pack_Amount").Width = 80
            C1DBG.Splits(0).DisplayColumns("Weight").Width = 80
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmCargoPackSheet_Report_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.cbBillNo.Focused Then
                Me.dtpWorkDate.Focus()
            ElseIf Me.dtpWorkDate.Focused Then
                Me.cbDayOrNight.Focus()
            ElseIf Me.cbDayOrNight.Focused Then
                Me.btSave.Focus()
            End If
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
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

            xlSheet.Cells(3, 2) = Me.lbVessel.Text
            xlSheet.Cells(3, 4) = Me.lbBerthNo.Text
            xlSheet.Cells(3, 6) = Me.lbDate.Text
            xlSheet.Cells(4, 6) = Me.lbDate.Text
            xlSheet.Cells(3, 8) = Me.lbTime1.Text
            xlSheet.Cells(4, 8) = Me.lbTime2.Text
            xlSheet.Cells(4, 2) = Me.txtNo.Text

            xlSheet.Cells(9, 1) = Me.lbCargo.Text
            Dim iBase As Integer
            iBase = 9
            Call FillExcel(dvGetP, iBase)
            iBase = 17
            Call FillExcel(dvGetI, iBase)
            iBase = 19
            Call FillExcel(dvGetF, iBase)
            iBase = 21
            Call FillExcel(dvGetA, iBase)

            Dim i As Integer
            iBase = 23
            For i = 0 To dvGetCheck.Count - 1
                If dvGetCheck(i)("P_M_TYPE") = "2" Then   '机器
                    xlSheet.Cells(iBase, 4) = dvGetCheck(i)("Test_Amount")
                    xlSheet.Cells(iBase, 6) = dvGetCheck(i)("ELIGIBLE_Rate")
                    xlSheet.Cells(iBase + i, 9) = dvGetCheck(i)("AVERAGE_WEIGHT")
                ElseIf dvGetCheck(i)("P_M_TYPE") = "1" Then   '人力
                    xlSheet.Cells(iBase + 1, 4) = dvGetCheck(i)("Test_Amount")
                    xlSheet.Cells(iBase + 1, 6) = dvGetCheck(i)("ELIGIBLE_Rate")
                    xlSheet.Cells(iBase + 1, 9) = dvGetCheck(i)("AVERAGE_WEIGHT")
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub FillExcel(ByRef dv As DataView, ByVal basePos As Integer)
        Dim i As Integer
        Dim amount As Integer
        Dim weight As Decimal
        For i = 0 To dv.Count - 1
            If dv(i)("P_M_TYPE") = "2" Then   '机器
                xlSheet.Cells(basePos, 2) = dv(i)("Pack_Amount")
                xlSheet.Cells(basePos + 1, 2 + 1) = dv(i)("Weight")
            ElseIf dv(i)("P_M_TYPE") = "1" Then   '人力
                xlSheet.Cells(basePos, 4) = dv(i)("Pack_Amount")
                xlSheet.Cells(basePos + 1, 4 + 1) = dv(i)("Weight")
            End If
            If IsNumeric(dv(i)("Pack_Amount")) Then
                amount += dv(i)("Pack_Amount")
                weight += dv(i)("Weight")
            End If
        Next
        If amount <> 0 Then
            xlSheet.Cells(basePos, 8) = amount
            xlSheet.Cells(basePos + 1, 8 + 1) = Decimal.Round(weight, 2)
        End If
    End Sub
End Class
