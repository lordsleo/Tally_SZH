Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FrmTally_sheet_query
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim dw As New DataView()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim ds_sub As New DataSet()
    Dim sqlda_sub As New SqlClient.SqlDataAdapter()
    Dim dsberth As New DataSet()
    Dim dshatch_no As New DataSet()
    Dim dsclerk As New DataSet()
    Dim dsclerk2 As New DataSet()
    Dim dsclerk3 As New DataSet()
    Dim DSPACK As New DataSet()
    Dim DSHARDWORK As New DataSet()
    Dim DSTALLY_SPECIAL As New DataSet()


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
    Friend WithEvents TxtCARGO_LIST_ID As System.Windows.Forms.TextBox
    Friend WithEvents TxtCROSS_PERSON As System.Windows.Forms.TextBox
    Friend WithEvents TxtTime_from As System.Windows.Forms.TextBox
    Friend WithEvents Txttime_to As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents C1dbg As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents DTPdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents CombTALLY_CLERK3 As System.Windows.Forms.ComboBox
    Friend WithEvents CombTALLY_CLERK2 As System.Windows.Forms.ComboBox
    Friend WithEvents CombTALLY_CLERK1 As System.Windows.Forms.ComboBox
    Friend WithEvents CombHATCH_NO As System.Windows.Forms.ComboBox
    Friend WithEvents CombBERTHNO As System.Windows.Forms.ComboBox
    Friend WithEvents TxtYARD_NO As System.Windows.Forms.TextBox
    Friend WithEvents TxtHATCH_Position As System.Windows.Forms.TextBox
    Friend WithEvents TxtNO As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBTALLY_OUT As System.Windows.Forms.CheckBox
    Friend WithEvents cbHOLIDAY As System.Windows.Forms.CheckBox
    Friend WithEvents CBSEA_AFFAIRE_CARGO As System.Windows.Forms.CheckBox
    Friend WithEvents cbWEIGHT As System.Windows.Forms.CheckBox
    Friend WithEvents cbMARK_STANDBY As System.Windows.Forms.CheckBox
    Friend WithEvents CBNIGHT_MARK As System.Windows.Forms.CheckBox
    Friend WithEvents CBANCHORAGE_REMARK As System.Windows.Forms.CheckBox
    Friend WithEvents CBMARK As System.Windows.Forms.CheckBox
    Friend WithEvents TxtTEAM_NO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmTally_sheet_query))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.TxtCARGO_LIST_ID = New System.Windows.Forms.TextBox()
        Me.TxtCROSS_PERSON = New System.Windows.Forms.TextBox()
        Me.TxtTime_from = New System.Windows.Forms.TextBox()
        Me.Txttime_to = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.C1dbg = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.BTQUIT = New System.Windows.Forms.Button()
        Me.DTPdate = New System.Windows.Forms.DateTimePicker()
        Me.CombTALLY_CLERK3 = New System.Windows.Forms.ComboBox()
        Me.CombTALLY_CLERK2 = New System.Windows.Forms.ComboBox()
        Me.CombTALLY_CLERK1 = New System.Windows.Forms.ComboBox()
        Me.CombHATCH_NO = New System.Windows.Forms.ComboBox()
        Me.CombBERTHNO = New System.Windows.Forms.ComboBox()
        Me.TxtYARD_NO = New System.Windows.Forms.TextBox()
        Me.TxtHATCH_Position = New System.Windows.Forms.TextBox()
        Me.TxtNO = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBTALLY_OUT = New System.Windows.Forms.CheckBox()
        Me.cbHOLIDAY = New System.Windows.Forms.CheckBox()
        Me.CBSEA_AFFAIRE_CARGO = New System.Windows.Forms.CheckBox()
        Me.cbWEIGHT = New System.Windows.Forms.CheckBox()
        Me.cbMARK_STANDBY = New System.Windows.Forms.CheckBox()
        Me.CBNIGHT_MARK = New System.Windows.Forms.CheckBox()
        Me.CBANCHORAGE_REMARK = New System.Windows.Forms.CheckBox()
        Me.CBMARK = New System.Windows.Forms.CheckBox()
        Me.TxtTEAM_NO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.C1dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtCARGO_LIST_ID
        '
        Me.TxtCARGO_LIST_ID.Location = New System.Drawing.Point(48, 452)
        Me.TxtCARGO_LIST_ID.Name = "TxtCARGO_LIST_ID"
        Me.TxtCARGO_LIST_ID.Size = New System.Drawing.Size(52, 21)
        Me.TxtCARGO_LIST_ID.TabIndex = 124
        Me.TxtCARGO_LIST_ID.Text = ""
        Me.TxtCARGO_LIST_ID.Visible = False
        '
        'TxtCROSS_PERSON
        '
        Me.TxtCROSS_PERSON.Enabled = False
        Me.TxtCROSS_PERSON.Location = New System.Drawing.Point(310, 68)
        Me.TxtCROSS_PERSON.MaxLength = 10
        Me.TxtCROSS_PERSON.Name = "TxtCROSS_PERSON"
        Me.TxtCROSS_PERSON.Size = New System.Drawing.Size(108, 21)
        Me.TxtCROSS_PERSON.TabIndex = 123
        Me.TxtCROSS_PERSON.Text = ""
        '
        'TxtTime_from
        '
        Me.TxtTime_from.Enabled = False
        Me.TxtTime_from.Location = New System.Drawing.Point(500, 40)
        Me.TxtTime_from.MaxLength = 4
        Me.TxtTime_from.Name = "TxtTime_from"
        Me.TxtTime_from.Size = New System.Drawing.Size(108, 21)
        Me.TxtTime_from.TabIndex = 122
        Me.TxtTime_from.Text = ""
        '
        'Txttime_to
        '
        Me.Txttime_to.Enabled = False
        Me.Txttime_to.Location = New System.Drawing.Point(500, 68)
        Me.Txttime_to.MaxLength = 4
        Me.Txttime_to.Name = "Txttime_to"
        Me.Txttime_to.Size = New System.Drawing.Size(108, 21)
        Me.Txttime_to.TabIndex = 121
        Me.Txttime_to.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(424, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 22)
        Me.Label13.TabIndex = 120
        Me.Label13.Text = "作业日期"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1dbg
        '
        Me.C1dbg.AllowFilter = True
        Me.C1dbg.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1dbg.AllowSort = True
        Me.C1dbg.AllowUpdate = False
        Me.C1dbg.CaptionHeight = 18
        Me.C1dbg.CollapseColor = System.Drawing.Color.Black
        Me.C1dbg.DataChanged = False
        Me.C1dbg.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1dbg.ExpandColor = System.Drawing.Color.Black
        Me.C1dbg.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1dbg.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1dbg.Location = New System.Drawing.Point(4, 128)
        Me.C1dbg.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1dbg.Name = "C1dbg"
        Me.C1dbg.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1dbg.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1dbg.PreviewInfo.ZoomFactor = 75
        Me.C1dbg.PrintInfo.ShowOptionsDialog = False
        Me.C1dbg.RecordSelectorWidth = 16
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1dbg.RowDivider = GridLines1
        Me.C1dbg.RowHeight = 16
        Me.C1dbg.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1dbg.ScrollTips = False
        Me.C1dbg.Size = New System.Drawing.Size(834, 310)
        Me.C1dbg.TabIndex = 119
        Me.C1dbg.Text = "C1TrueDBGrid1"
        Me.C1dbg.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        ", 0, 830, 306</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2" & _
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
        "yout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 8" & _
        "30, 306</ClientArea></Blob>"
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(390, 454)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 118
        Me.BTQUIT.Text = "取消"
        '
        'DTPdate
        '
        Me.DTPdate.CustomFormat = "yyyy-MM-dd"
        Me.DTPdate.Enabled = False
        Me.DTPdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPdate.Location = New System.Drawing.Point(500, 12)
        Me.DTPdate.Name = "DTPdate"
        Me.DTPdate.Size = New System.Drawing.Size(110, 21)
        Me.DTPdate.TabIndex = 115
        '
        'CombTALLY_CLERK3
        '
        Me.CombTALLY_CLERK3.Enabled = False
        Me.CombTALLY_CLERK3.Location = New System.Drawing.Point(700, 68)
        Me.CombTALLY_CLERK3.Name = "CombTALLY_CLERK3"
        Me.CombTALLY_CLERK3.Size = New System.Drawing.Size(96, 20)
        Me.CombTALLY_CLERK3.TabIndex = 114
        '
        'CombTALLY_CLERK2
        '
        Me.CombTALLY_CLERK2.Enabled = False
        Me.CombTALLY_CLERK2.Location = New System.Drawing.Point(700, 40)
        Me.CombTALLY_CLERK2.Name = "CombTALLY_CLERK2"
        Me.CombTALLY_CLERK2.Size = New System.Drawing.Size(96, 20)
        Me.CombTALLY_CLERK2.TabIndex = 113
        '
        'CombTALLY_CLERK1
        '
        Me.CombTALLY_CLERK1.Enabled = False
        Me.CombTALLY_CLERK1.Location = New System.Drawing.Point(700, 12)
        Me.CombTALLY_CLERK1.Name = "CombTALLY_CLERK1"
        Me.CombTALLY_CLERK1.Size = New System.Drawing.Size(96, 20)
        Me.CombTALLY_CLERK1.TabIndex = 112
        '
        'CombHATCH_NO
        '
        Me.CombHATCH_NO.Enabled = False
        Me.CombHATCH_NO.Location = New System.Drawing.Point(120, 66)
        Me.CombHATCH_NO.Name = "CombHATCH_NO"
        Me.CombHATCH_NO.Size = New System.Drawing.Size(108, 20)
        Me.CombHATCH_NO.TabIndex = 111
        '
        'CombBERTHNO
        '
        Me.CombBERTHNO.Enabled = False
        Me.CombBERTHNO.Location = New System.Drawing.Point(120, 38)
        Me.CombBERTHNO.Name = "CombBERTHNO"
        Me.CombBERTHNO.Size = New System.Drawing.Size(108, 20)
        Me.CombBERTHNO.TabIndex = 110
        '
        'TxtYARD_NO
        '
        Me.TxtYARD_NO.Enabled = False
        Me.TxtYARD_NO.Location = New System.Drawing.Point(310, 40)
        Me.TxtYARD_NO.MaxLength = 20
        Me.TxtYARD_NO.Name = "TxtYARD_NO"
        Me.TxtYARD_NO.Size = New System.Drawing.Size(108, 21)
        Me.TxtYARD_NO.TabIndex = 109
        Me.TxtYARD_NO.Text = ""
        '
        'TxtHATCH_Position
        '
        Me.TxtHATCH_Position.Enabled = False
        Me.TxtHATCH_Position.Location = New System.Drawing.Point(310, 12)
        Me.TxtHATCH_Position.MaxLength = 10
        Me.TxtHATCH_Position.Name = "TxtHATCH_Position"
        Me.TxtHATCH_Position.Size = New System.Drawing.Size(108, 21)
        Me.TxtHATCH_Position.TabIndex = 108
        Me.TxtHATCH_Position.Text = ""
        '
        'TxtNO
        '
        Me.TxtNO.Enabled = False
        Me.TxtNO.Location = New System.Drawing.Point(168, 10)
        Me.TxtNO.MaxLength = 10
        Me.TxtNO.Name = "TxtNO"
        Me.TxtNO.Size = New System.Drawing.Size(60, 21)
        Me.TxtNO.TabIndex = 107
        Me.TxtNO.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(234, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 22)
        Me.Label12.TabIndex = 106
        Me.Label12.Text = "交接人员"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(424, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 22)
        Me.Label11.TabIndex = 105
        Me.Label11.Text = "作业止时间"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(234, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 22)
        Me.Label10.TabIndex = 104
        Me.Label10.Text = "舱位"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(614, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 22)
        Me.Label9.TabIndex = 103
        Me.Label9.Text = "理货员3"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(614, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 22)
        Me.Label8.TabIndex = 102
        Me.Label8.Text = "理货员2"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(614, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 22)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "理货员1"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(424, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 22)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "作业起时间"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(234, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 22)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "库场车驳号"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(48, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 22)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "舱别"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(48, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 22)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "泊位号"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(136, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 22)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "编号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CBTALLY_OUT
        '
        Me.CBTALLY_OUT.Enabled = False
        Me.CBTALLY_OUT.Location = New System.Drawing.Point(617, 100)
        Me.CBTALLY_OUT.Name = "CBTALLY_OUT"
        Me.CBTALLY_OUT.Size = New System.Drawing.Size(74, 18)
        Me.CBTALLY_OUT.TabIndex = 132
        Me.CBTALLY_OUT.Text = "外出理货"
        '
        'cbHOLIDAY
        '
        Me.cbHOLIDAY.Enabled = False
        Me.cbHOLIDAY.Location = New System.Drawing.Point(213, 100)
        Me.cbHOLIDAY.Name = "cbHOLIDAY"
        Me.cbHOLIDAY.Size = New System.Drawing.Size(74, 18)
        Me.cbHOLIDAY.TabIndex = 131
        Me.cbHOLIDAY.Text = "节假日"
        '
        'CBSEA_AFFAIRE_CARGO
        '
        Me.CBSEA_AFFAIRE_CARGO.Enabled = False
        Me.CBSEA_AFFAIRE_CARGO.Location = New System.Drawing.Point(555, 100)
        Me.CBSEA_AFFAIRE_CARGO.Name = "CBSEA_AFFAIRE_CARGO"
        Me.CBSEA_AFFAIRE_CARGO.Size = New System.Drawing.Size(58, 18)
        Me.CBSEA_AFFAIRE_CARGO.TabIndex = 130
        Me.CBSEA_AFFAIRE_CARGO.Text = "海事"
        '
        'cbWEIGHT
        '
        Me.cbWEIGHT.Enabled = False
        Me.cbWEIGHT.Location = New System.Drawing.Point(431, 100)
        Me.cbWEIGHT.Name = "cbWEIGHT"
        Me.cbWEIGHT.Size = New System.Drawing.Size(58, 18)
        Me.cbWEIGHT.TabIndex = 129
        Me.cbWEIGHT.Text = "重装"
        '
        'cbMARK_STANDBY
        '
        Me.cbMARK_STANDBY.Enabled = False
        Me.cbMARK_STANDBY.Location = New System.Drawing.Point(291, 100)
        Me.cbMARK_STANDBY.Name = "cbMARK_STANDBY"
        Me.cbMARK_STANDBY.Size = New System.Drawing.Size(58, 18)
        Me.cbMARK_STANDBY.TabIndex = 128
        Me.cbMARK_STANDBY.Text = "待时"
        '
        'CBNIGHT_MARK
        '
        Me.CBNIGHT_MARK.Enabled = False
        Me.CBNIGHT_MARK.Location = New System.Drawing.Point(151, 100)
        Me.CBNIGHT_MARK.Name = "CBNIGHT_MARK"
        Me.CBNIGHT_MARK.Size = New System.Drawing.Size(58, 18)
        Me.CBNIGHT_MARK.TabIndex = 127
        Me.CBNIGHT_MARK.Text = "夜班"
        '
        'CBANCHORAGE_REMARK
        '
        Me.CBANCHORAGE_REMARK.Enabled = False
        Me.CBANCHORAGE_REMARK.Location = New System.Drawing.Point(493, 100)
        Me.CBANCHORAGE_REMARK.Name = "CBANCHORAGE_REMARK"
        Me.CBANCHORAGE_REMARK.Size = New System.Drawing.Size(58, 18)
        Me.CBANCHORAGE_REMARK.TabIndex = 126
        Me.CBANCHORAGE_REMARK.Text = "锚地"
        '
        'CBMARK
        '
        Me.CBMARK.Enabled = False
        Me.CBMARK.Location = New System.Drawing.Point(353, 100)
        Me.CBMARK.Name = "CBMARK"
        Me.CBMARK.Size = New System.Drawing.Size(74, 18)
        Me.CBMARK.TabIndex = 125
        Me.CBMARK.Text = "出舱"
        '
        'TxtTEAM_NO
        '
        Me.TxtTEAM_NO.Enabled = False
        Me.TxtTEAM_NO.Location = New System.Drawing.Point(92, 10)
        Me.TxtTEAM_NO.MaxLength = 3
        Me.TxtTEAM_NO.Name = "TxtTEAM_NO"
        Me.TxtTEAM_NO.Size = New System.Drawing.Size(42, 21)
        Me.TxtTEAM_NO.TabIndex = 134
        Me.TxtTEAM_NO.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(48, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 22)
        Me.Label4.TabIndex = 133
        Me.Label4.Text = "工班号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmTally_sheet_query
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(844, 495)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TxtTEAM_NO, Me.Label4, Me.CBTALLY_OUT, Me.cbHOLIDAY, Me.CBSEA_AFFAIRE_CARGO, Me.cbWEIGHT, Me.cbMARK_STANDBY, Me.CBNIGHT_MARK, Me.CBANCHORAGE_REMARK, Me.CBMARK, Me.TxtCARGO_LIST_ID, Me.TxtCROSS_PERSON, Me.TxtTime_from, Me.Txttime_to, Me.Label13, Me.C1dbg, Me.BTQUIT, Me.DTPdate, Me.CombTALLY_CLERK3, Me.CombTALLY_CLERK2, Me.CombTALLY_CLERK1, Me.CombHATCH_NO, Me.CombBERTHNO, Me.TxtYARD_NO, Me.TxtHATCH_Position, Me.TxtNO, Me.Label12, Me.Label11, Me.Label10, Me.Label9, Me.Label8, Me.Label7, Me.Label6, Me.Label5, Me.Label3, Me.Label2, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTally_sheet_query"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "计数单_查看"
        CType(Me.C1dbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmTally_sheet_query_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        dw = Getdata("select CODE_BERTH,NAME_BERTH from CODE_BERTH ", dsberth)
        CombBERTHNO.DataSource = dsberth.Tables(0).DefaultView
        CombBERTHNO.DisplayMember = "NAME_BERTH"
        CombBERTHNO.ValueMember = "CODE_BERTH"

        dw = Getdata("select value,descr from codecabin", dshatch_no)
        CombHATCH_NO.DataSource = dshatch_no.Tables(0).DefaultView
        CombHATCH_NO.DisplayMember = "descr"
        CombHATCH_NO.ValueMember = "value"

        'dw = Getdata("select work_no,name from TALLY_CLERK", dsclerk)
        'CombTALLY_CLERK1.DataSource = dsclerk.Tables(0).DefaultView
        'CombTALLY_CLERK1.DisplayMember = "name"
        'CombTALLY_CLERK1.ValueMember = "work_no"

        'dw = Getdata("select work_no,name from TALLY_CLERK", dsclerk2)
        'CombTALLY_CLERK2.DataSource = dsclerk2.Tables(0).DefaultView
        'CombTALLY_CLERK2.DisplayMember = "name"
        'CombTALLY_CLERK2.ValueMember = "work_no"

        'dw = Getdata("select work_no,name from TALLY_CLERK", dsclerk3)
        'CombTALLY_CLERK3.DataSource = dsclerk3.Tables(0).DefaultView
        'CombTALLY_CLERK3.DisplayMember = "name"
        'CombTALLY_CLERK3.ValueMember = "work_no"


        dw = Updatedata(sqlda, "select * from cargo_list where CARGO_LIST_ID='" & ID & "'", ds)
        If ds.Tables(0).DefaultView.Count > 0 Then
            TxtNO.Text = ds.Tables(0).Rows(0).Item("no")
            TxtHATCH_Position.Text = ds.Tables(0).Rows(0).Item("HATCH_Position")
            TxtYARD_NO.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("YARD_NO"))), "", Trim(ds.Tables(0).Rows(0).Item("YARD_NO")))
            If ds.Tables(0).Rows(0).Item("mark") = 1 Then
                CBMARK.Checked = True
            End If
            If ds.Tables(0).Rows(0).Item("NIGHT_MARK") = 1 Then
                CBNIGHT_MARK.Checked = True
            End If
            If ds.Tables(0).Rows(0).Item("HOLIDAY") = 1 Then
                cbHOLIDAY.Checked = True
            End If
            If ds.Tables(0).Rows(0).Item("ANCHORAGE_REMARK") = 1 Then
                CBANCHORAGE_REMARK.Checked = True
            End If
            If ds.Tables(0).Rows(0).Item("SEA_AFFAIRE_CARGO") = 1 Then
                CBSEA_AFFAIRE_CARGO.Checked = True
            End If
            If ds.Tables(0).Rows(0).Item("MARK_STANDBY") = 1 Then
                cbMARK_STANDBY.Checked = True
            End If
            If ds.Tables(0).Rows(0).Item("WEIGHT") = 1 Then
                cbWEIGHT.Checked = True
            End If
            If ds.Tables(0).Rows(0).Item("TALLY_OUT") = 1 Then
                CBTALLY_OUT.Checked = True
            End If
            TxtTime_from.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("time_from"))), "", Trim(ds.Tables(0).Rows(0).Item("time_from")))
            Txttime_to.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("time_to"))), "", Trim(ds.Tables(0).Rows(0).Item("time_to")))
            CombHATCH_NO.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("hatch_no"))), "", Trim(ds.Tables(0).Rows(0).Item("hatch_no")))
            CombBERTHNO.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("BERTHNO"))), "", Trim(ds.Tables(0).Rows(0).Item("BERTHNO")))
            TxtCROSS_PERSON.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("CROSS_PERSON"))), "", Trim(ds.Tables(0).Rows(0).Item("CROSS_PERSON")))
            DTPdate.Value = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("date"))), Now, Trim(ds.Tables(0).Rows(0).Item("date")))
            TxtTEAM_NO.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("team_no"))), "", Trim(ds.Tables(0).Rows(0).Item("team_no")))
            'Call clerk()
            If Not IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk1"))) Then
                dsclerk.Reset()
                dw = Getdata("select work_no,name from TALLY_CLERK where work_no='" & Trim(ds.Tables(0).Rows(0).Item("tally_clerk1")) & "'", dsclerk)
                CombTALLY_CLERK1.DataSource = dsclerk.Tables(0).DefaultView
                CombTALLY_CLERK1.DisplayMember = "name"
                CombTALLY_CLERK1.ValueMember = "work_no"
                CombTALLY_CLERK1.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk1"))), "00", Trim(ds.Tables(0).Rows(0).Item("tally_clerk1")))

            End If
            If Not IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk2"))) Then
                dsclerk2.Reset()
                dw = Getdata("select work_no,name from TALLY_CLERK where work_no='" & Trim(ds.Tables(0).Rows(0).Item("tally_clerk2")) & "'", dsclerk2)
                CombTALLY_CLERK2.DataSource = dsclerk2.Tables(0).DefaultView
                CombTALLY_CLERK2.DisplayMember = "name"
                CombTALLY_CLERK2.ValueMember = "work_no"
                CombTALLY_CLERK2.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk2"))), "00", Trim(ds.Tables(0).Rows(0).Item("tally_clerk2")))

            End If
            If Not IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk3"))) Then
                dsclerk3.Reset()
                dw = Getdata("select work_no,name from TALLY_CLERK where work_no='" & Trim(ds.Tables(0).Rows(0).Item("tally_clerk3")) & "'", dsclerk3)
                CombTALLY_CLERK3.DataSource = dsclerk3.Tables(0).DefaultView
                CombTALLY_CLERK3.DisplayMember = "name"
                CombTALLY_CLERK3.ValueMember = "work_no"
                CombTALLY_CLERK3.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk3"))), "00", Trim(ds.Tables(0).Rows(0).Item("tally_clerk3")))

            End If
            'CombTALLY_CLERK1.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk1"))), "", Trim(ds.Tables(0).Rows(0).Item("tally_clerk1")))
            'CombTALLY_CLERK2.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk2"))), "", Trim(ds.Tables(0).Rows(0).Item("tally_clerk2")))
            'CombTALLY_CLERK3.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk3"))), "", Trim(ds.Tables(0).Rows(0).Item("tally_clerk3")))

            dw = Updatedata(sqlda_sub, "select CARGO_LIST_DETAIL_ID, CARGO_LIST_ID, BLNO, MARK, CODE_GOODS, GOODS_CHA, GOODS_ENG, CODE_PACK, cast(amount as dec(10,0)) as AMOUNT, NON_CARGOHOLD, MARK_ASSORTING, Code_HardWork, FREEZE_AMOUNT, Code_Tally_SPECIAL, TALLY_SPECIAL, OVER_LENGTH_WEIGHT, SIZE_CON, EMPTY_MARK, PIECE_WEIGHT, TONS from cargo_list_detail where cargo_list_id='" & ID & "'", ds_sub)
            Me.C1dbg.DataSource = ds_sub.Tables(0).DefaultView
            Me.C1dbg.Refresh()

            Call PACK()
            Call ITEM_FILL()
            Call HARDWORK()
            Call TALLY_SPECIAL()
            Call CODE_GOODS()

            Me.C1dbg.Splits(0).DisplayColumns.Item("CARGO_LIST_DETAIL_ID").Visible = False
            Me.C1dbg.Splits(0).DisplayColumns.Item("CARGO_LIST_ID").Visible = False
            Me.C1dbg.Splits(0).DisplayColumns.Item("goods_eng").Visible = False
            Me.C1dbg.Splits(0).DisplayColumns.Item("PIECE_WEIGHT").Visible = False
            Me.C1dbg.Splits(0).DisplayColumns.Item("TONS").Visible = False

            Me.C1dbg.Columns.Item("BLNO").Caption = "提单号"
            Me.C1dbg.Columns.Item("MARK").Caption = "标志"
            Me.C1dbg.Columns.Item("code_goods").Caption = "货类"
            Me.C1dbg.Columns.Item("goods_cha").Caption = "货物描述"
            Me.C1dbg.Columns.Item("CODE_PACK").Caption = "包装"
            Me.C1dbg.Columns.Item("AMOUNT").Caption = "件数"
            Me.C1dbg.Columns.Item("NON_CARGOHOLD").Caption = "非一般货舱"
            Me.C1dbg.Columns.Item("MARK_ASSORTING").Caption = "分标志"
            Me.C1dbg.Columns.Item("FREEZE_AMOUNT").Caption = "困难作业"
            Me.C1dbg.Columns.Item("TALLY_SPECIAL").Caption = "特理"
            Me.C1dbg.Columns.Item("OVER_LENGTH_WEIGHT").Caption = "超长超重"
            Me.C1dbg.Columns.Item("SIZE_CON").Caption = "箱尺寸"
            Me.C1dbg.Columns.Item("EMPTY_MARK").Caption = "重箱"
            Me.C1dbg.Columns.Item("code_hardwork").Caption = "困难类型"
            Me.C1dbg.Columns.Item("code_TALLY_SPECIAL").Caption = "特理类型"

            Me.C1dbg.Splits(0).DisplayColumns.Item("BLNO").Width = 60
            Me.C1dbg.Splits(0).DisplayColumns.Item("MARK").Width = 70
            Me.C1dbg.Splits(0).DisplayColumns.Item("code_goods").Width = 50
            Me.C1dbg.Splits(0).DisplayColumns.Item("goods_cha").Width = 90
            Me.C1dbg.Splits(0).DisplayColumns.Item("CODE_PACK").Width = 50
            Me.C1dbg.Splits(0).DisplayColumns.Item("AMOUNT").Width = 50
            Me.C1dbg.Splits(0).DisplayColumns.Item("NON_CARGOHOLD").Width = 70
            Me.C1dbg.Splits(0).DisplayColumns.Item("MARK_ASSORTING").Width = 50
            Me.C1dbg.Splits(0).DisplayColumns.Item("FREEZE_AMOUNT").Width = 60
            Me.C1dbg.Splits(0).DisplayColumns.Item("TALLY_SPECIAL").Width = 40
            Me.C1dbg.Splits(0).DisplayColumns.Item("OVER_LENGTH_WEIGHT").Width = 60
            Me.C1dbg.Splits(0).DisplayColumns.Item("SIZE_CON").Width = 50
            Me.C1dbg.Splits(0).DisplayColumns.Item("EMPTY_MARK").Width = 50
            Me.C1dbg.Splits(0).DisplayColumns.Item("code_hardwork").Width = 60
            Me.C1dbg.Splits(0).DisplayColumns.Item("code_TALLY_SPECIAL").Width = 60
            Me.C1dbg.Refresh()

        End If

        Exit Sub
Err:
        Resume Next
    End Sub
    Private Sub clerk()
        Try

            dw = Getdata("exec sp_clerk '" & G_DeptCode & "','" & Ship_ID & "','" & TxtTime_from.Text & "','" & DTPdate.Value & "'", dsclerk)
            CombTALLY_CLERK1.DataSource = dsclerk.Tables(0).DefaultView
            CombTALLY_CLERK1.DisplayMember = "name"
            CombTALLY_CLERK1.ValueMember = "work_no"

            dw = Getdata("exec sp_clerk '" & G_DeptCode & "','" & Ship_ID & "','" & TxtTime_from.Text & "','" & DTPdate.Value & "'", dsclerk2)
            CombTALLY_CLERK2.DataSource = dsclerk2.Tables(0).DefaultView
            CombTALLY_CLERK2.DisplayMember = "name"
            CombTALLY_CLERK2.ValueMember = "work_no"

            dw = Getdata("exec sp_clerk '" & G_DeptCode & "','" & Ship_ID & "','" & TxtTime_from.Text & "','" & DTPdate.Value & "'", dsclerk3)
            CombTALLY_CLERK3.DataSource = dsclerk3.Tables(0).DefaultView
            CombTALLY_CLERK3.DisplayMember = "name"
            CombTALLY_CLERK3.ValueMember = "work_no"

        Catch ex As System.Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub ITEM_FILL()
        Try

            Dim i As Integer
            Dim dstrue As New DataSet()
            dstrue.Reset()
            dw = Getdata("select Value,Descri from true", dstrue)
            Me.C1dbg.Columns.Item("EMPTY_MARK").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
            Me.C1dbg.Columns.Item("EMPTY_MARK").ValueItems.Translate = True
            Do While Me.C1dbg.Columns.Item("EMPTY_MARK").ValueItems.Values.Count > 0
                Me.C1dbg.Columns.Item("EMPTY_MARK").ValueItems.Values.RemoveAt(0)
            Loop
            For i = 0 To dstrue.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                vi.DisplayValue = dstrue.Tables(0).Rows(i)("Descri")
                vi.Value = dstrue.Tables(0).Rows(i)("Value")
                Me.C1dbg.Columns.Item("EMPTY_MARK").ValueItems.Values.Add(vi)
            Next

            'Me.C1dbg.Columns.Item("TALLY_SPECIAL").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
            'Me.C1dbg.Columns.Item("TALLY_SPECIAL").ValueItems.Translate = True
            'Do While Me.C1dbg.Columns.Item("TALLY_SPECIAL").ValueItems.Values.Count > 0
            '    Me.C1dbg.Columns.Item("TALLY_SPECIAL").ValueItems.Values.RemoveAt(0)
            'Loop
            'For i = 0 To dstrue.Tables(0).Rows.Count - 1
            '    Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
            '    vi.DisplayValue = dstrue.Tables(0).Rows(i)("Descri")
            '    vi.Value = dstrue.Tables(0).Rows(i)("Value")
            '    Me.C1dbg.Columns.Item("TALLY_SPECIAL").ValueItems.Values.Add(vi)
            'Next

            'Me.C1dbg.Columns.Item("TALLY_OUT").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
            'Me.C1dbg.Columns.Item("TALLY_OUT").ValueItems.Translate = True
            'Do While Me.C1dbg.Columns.Item("TALLY_OUT").ValueItems.Values.Count > 0
            '    Me.C1dbg.Columns.Item("TALLY_OUT").ValueItems.Values.RemoveAt(0)
            'Loop
            'For i = 0 To dstrue.Tables(0).Rows.Count - 1
            '    Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
            '    vi.DisplayValue = dstrue.Tables(0).Rows(i)("Descri")
            '    vi.Value = dstrue.Tables(0).Rows(i)("Value")
            '    Me.C1dbg.Columns.Item("TALLY_OUT").ValueItems.Values.Add(vi)
            'Next

            'Me.C1dbg.Columns.Item("OUT_HATCH").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
            'Me.C1dbg.Columns.Item("OUT_HATCH").ValueItems.Translate = True
            'Do While Me.C1dbg.Columns.Item("OUT_HATCH").ValueItems.Values.Count > 0
            '    Me.C1dbg.Columns.Item("OUT_HATCH").ValueItems.Values.RemoveAt(0)
            'Loop
            'For i = 0 To dstrue.Tables(0).Rows.Count - 1
            '    Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
            '    vi.DisplayValue = dstrue.Tables(0).Rows(i)("Descri")
            '    vi.Value = dstrue.Tables(0).Rows(i)("Value")
            '    Me.C1dbg.Columns.Item("OUT_HATCH").ValueItems.Values.Add(vi)
            'Next

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub CODE_GOODS() '所有的货类填充
        Dim DSGOODS As New DataSet()
        Try
            Dim i As Integer
            DSGOODS.Reset()
            dw = Getdata("SELECT CODE_GOODS,GOODS_CHA  FROM CODE_CARGO", DSGOODS)
            If DSGOODS.Tables(0).Rows.Count > 0 Then
                Me.C1dbg.Columns.Item("CODE_GOODS").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
                Me.C1dbg.Columns.Item("CODE_GOODS").ValueItems.Translate = True
                Do While Me.C1dbg.Columns.Item("CODE_GOODS").ValueItems.Values.Count > 0
                    Me.C1dbg.Columns.Item("CODE_GOODS").ValueItems.Values.RemoveAt(0)
                Loop
                For i = 0 To DSGOODS.Tables(0).Rows.Count - 1
                    Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                    vi.DisplayValue = DSGOODS.Tables(0).Rows(i)("GOODS_CHA")
                    vi.Value = DSGOODS.Tables(0).Rows(i)("CODE_GOODS")
                    Me.C1dbg.Columns.Item("CODE_GOODS").ValueItems.Values.Add(vi)
                Next
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PACK()
        Try
            Dim i As Integer
            DSPACK.Reset()
            dw = Getdata("select CODE_PACK,PACK_CHA from CODE_PACK ", DSPACK)
            If DSPACK.Tables(0).Rows.Count > 0 Then
                Me.C1dbg.Columns.Item("CODE_PACK").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
                Me.C1dbg.Columns.Item("CODE_PACK").ValueItems.Translate = True
                Do While Me.C1dbg.Columns.Item("CODE_PACK").ValueItems.Values.Count > 0
                    Me.C1dbg.Columns.Item("CODE_PACK").ValueItems.Values.RemoveAt(0)
                Loop
                For i = 0 To DSPACK.Tables(0).Rows.Count - 1
                    Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                    vi.DisplayValue = DSPACK.Tables(0).Rows(i)("PACK_CHA")
                    vi.Value = DSPACK.Tables(0).Rows(i)("CODE_PACK")
                    Me.C1dbg.Columns.Item("CODE_PACK").ValueItems.Values.Add(vi)
                Next
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub HARDWORK()
        Try
            Dim i As Integer
            DSHARDWORK.Reset()
            dw = Getdata("select Code_HardWork,HardWork from Code_HardWork ", DSHARDWORK)
            If DSHARDWORK.Tables(0).Rows.Count > 0 Then
                Me.C1dbg.Columns.Item("Code_HardWork").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
                Me.C1dbg.Columns.Item("Code_HardWork").ValueItems.Translate = True
                Do While Me.C1dbg.Columns.Item("Code_HardWork").ValueItems.Values.Count > 0
                    Me.C1dbg.Columns.Item("Code_HardWork").ValueItems.Values.RemoveAt(0)
                Loop
                For i = 0 To DSHARDWORK.Tables(0).Rows.Count - 1
                    Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                    vi.DisplayValue = DSHARDWORK.Tables(0).Rows(i)("HardWork")
                    vi.Value = DSHARDWORK.Tables(0).Rows(i)("Code_HardWork")
                    Me.C1dbg.Columns.Item("Code_HardWork").ValueItems.Values.Add(vi)
                Next
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TALLY_SPECIAL()
        Try
            Dim i As Integer
            DSTALLY_SPECIAL.Reset()
            dw = Getdata("select Code_TALLY_SPECIAL,Tally_SPECIAL from Code_Tally_SPECIAL ", DSTALLY_SPECIAL)
            If DSTALLY_SPECIAL.Tables(0).Rows.Count > 0 Then
                Me.C1dbg.Columns.Item("Code_Tally_SPECIAL").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
                Me.C1dbg.Columns.Item("Code_Tally_SPECIAL").ValueItems.Translate = True
                Do While Me.C1dbg.Columns.Item("Code_Tally_SPECIAL").ValueItems.Values.Count > 0
                    Me.C1dbg.Columns.Item("Code_Tally_SPECIAL").ValueItems.Values.RemoveAt(0)
                Loop
                For i = 0 To DSTALLY_SPECIAL.Tables(0).Rows.Count - 1
                    Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                    vi.DisplayValue = DSTALLY_SPECIAL.Tables(0).Rows(i)("Tally_SPECIAL")
                    vi.Value = DSTALLY_SPECIAL.Tables(0).Rows(i)("Code_Tally_SPECIAL")
                    Me.C1dbg.Columns.Item("Code_Tally_SPECIAL").ValueItems.Values.Add(vi)
                Next
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub


End Class
