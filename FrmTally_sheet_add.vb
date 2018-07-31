Imports TALLY.DBControl
Imports Microsoft.VisualBasic

Public Class FrmTally_sheet_add
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
    Dim dsclerk3 As New DataSet
    Dim dsclerk4 As New DataSet
    Dim dshatch_list As New DataSet()
    Dim sqlda_hatch_list As New SqlClient.SqlDataAdapter()
    Dim dsmark As New DataSet()
    Dim DSPACK As New DataSet()
    Dim DSHARDWORK As New DataSet()
    Dim DSTALLY_SPECIAL As New DataSet
    Dim dss As New DataSet


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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents BTOK As System.Windows.Forms.Button
    Friend WithEvents TxtNO As System.Windows.Forms.TextBox
    Friend WithEvents CombBERTHNO As System.Windows.Forms.ComboBox
    Friend WithEvents CombHATCH_NO As System.Windows.Forms.ComboBox
    Friend WithEvents CombTALLY_CLERK1 As System.Windows.Forms.ComboBox
    Friend WithEvents CombTALLY_CLERK2 As System.Windows.Forms.ComboBox
    Friend WithEvents CombTALLY_CLERK3 As System.Windows.Forms.ComboBox
    Friend WithEvents CBMARK As System.Windows.Forms.CheckBox
    Friend WithEvents DTPdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Txttime_to As System.Windows.Forms.TextBox
    Friend WithEvents TxtTime_from As System.Windows.Forms.TextBox
    Friend WithEvents TxtCARGO_LIST_ID As System.Windows.Forms.TextBox
    Friend WithEvents C1dbg As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents CBANCHORAGE_REMARK As System.Windows.Forms.CheckBox
    Friend WithEvents CBNIGHT_MARK As System.Windows.Forms.CheckBox
    Friend WithEvents cbMARK_STANDBY As System.Windows.Forms.CheckBox
    Friend WithEvents cbWEIGHT As System.Windows.Forms.CheckBox
    Friend WithEvents cbHOLIDAY As System.Windows.Forms.CheckBox
    Friend WithEvents CBSEA_AFFAIRE_CARGO As System.Windows.Forms.CheckBox
    Friend WithEvents BTNOK As System.Windows.Forms.Button
    Friend WithEvents BTLIST As System.Windows.Forms.Button
    Friend WithEvents CBTALLY_OUT As System.Windows.Forms.CheckBox
    Friend WithEvents TxtTEAM_NO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtCROSS_PERSON As System.Windows.Forms.ComboBox
    Friend WithEvents TxtHATCH_Position1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtHATCH_Position As System.Windows.Forms.ComboBox
    Friend WithEvents TxtYARD_NO1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtYARD_NO As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmTally_sheet_add))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtNO = New System.Windows.Forms.TextBox
        Me.TxtHATCH_Position1 = New System.Windows.Forms.TextBox
        Me.TxtYARD_NO1 = New System.Windows.Forms.TextBox
        Me.CombBERTHNO = New System.Windows.Forms.ComboBox
        Me.CombHATCH_NO = New System.Windows.Forms.ComboBox
        Me.CombTALLY_CLERK1 = New System.Windows.Forms.ComboBox
        Me.CombTALLY_CLERK2 = New System.Windows.Forms.ComboBox
        Me.CombTALLY_CLERK3 = New System.Windows.Forms.ComboBox
        Me.DTPdate = New System.Windows.Forms.DateTimePicker
        Me.CBMARK = New System.Windows.Forms.CheckBox
        Me.BTQUIT = New System.Windows.Forms.Button
        Me.BTOK = New System.Windows.Forms.Button
        Me.C1dbg = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.BTNOK = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.Txttime_to = New System.Windows.Forms.TextBox
        Me.TxtTime_from = New System.Windows.Forms.TextBox
        Me.TxtCARGO_LIST_ID = New System.Windows.Forms.TextBox
        Me.CBANCHORAGE_REMARK = New System.Windows.Forms.CheckBox
        Me.CBNIGHT_MARK = New System.Windows.Forms.CheckBox
        Me.cbMARK_STANDBY = New System.Windows.Forms.CheckBox
        Me.cbWEIGHT = New System.Windows.Forms.CheckBox
        Me.cbHOLIDAY = New System.Windows.Forms.CheckBox
        Me.CBSEA_AFFAIRE_CARGO = New System.Windows.Forms.CheckBox
        Me.BTLIST = New System.Windows.Forms.Button
        Me.CBTALLY_OUT = New System.Windows.Forms.CheckBox
        Me.TxtTEAM_NO = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtCROSS_PERSON = New System.Windows.Forms.ComboBox
        Me.TxtHATCH_Position = New System.Windows.Forms.ComboBox
        Me.TxtYARD_NO = New System.Windows.Forms.ComboBox
        CType(Me.C1dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(88, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "编号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(50, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "泊位号"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(238, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "舱别"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(236, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "库场车驳号"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(424, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "作业起时间"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(628, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 22)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "理货员"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(622, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 22)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "理货员2"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(616, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 22)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "复核人员"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(236, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 22)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "舱位"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(424, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 22)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "作业止时间"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(616, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 22)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "交接人员"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtNO
        '
        Me.TxtNO.Location = New System.Drawing.Point(122, 42)
        Me.TxtNO.MaxLength = 10
        Me.TxtNO.Name = "TxtNO"
        Me.TxtNO.Size = New System.Drawing.Size(106, 21)
        Me.TxtNO.TabIndex = 1
        Me.TxtNO.Text = ""
        '
        'TxtHATCH_Position1
        '
        Me.TxtHATCH_Position1.Location = New System.Drawing.Point(110, 130)
        Me.TxtHATCH_Position1.MaxLength = 10
        Me.TxtHATCH_Position1.Name = "TxtHATCH_Position1"
        Me.TxtHATCH_Position1.Size = New System.Drawing.Size(58, 21)
        Me.TxtHATCH_Position1.TabIndex = 13
        Me.TxtHATCH_Position1.Text = ""
        Me.TxtHATCH_Position1.Visible = False
        '
        'TxtYARD_NO1
        '
        Me.TxtYARD_NO1.Location = New System.Drawing.Point(180, 132)
        Me.TxtYARD_NO1.MaxLength = 20
        Me.TxtYARD_NO1.Name = "TxtYARD_NO1"
        Me.TxtYARD_NO1.Size = New System.Drawing.Size(66, 21)
        Me.TxtYARD_NO1.TabIndex = 14
        Me.TxtYARD_NO1.Text = ""
        Me.TxtYARD_NO1.Visible = False
        '
        'CombBERTHNO
        '
        Me.CombBERTHNO.Location = New System.Drawing.Point(122, 70)
        Me.CombBERTHNO.Name = "CombBERTHNO"
        Me.CombBERTHNO.Size = New System.Drawing.Size(106, 20)
        Me.CombBERTHNO.TabIndex = 15
        '
        'CombHATCH_NO
        '
        Me.CombHATCH_NO.Location = New System.Drawing.Point(310, 12)
        Me.CombHATCH_NO.Name = "CombHATCH_NO"
        Me.CombHATCH_NO.Size = New System.Drawing.Size(108, 20)
        Me.CombHATCH_NO.TabIndex = 16
        '
        'CombTALLY_CLERK1
        '
        Me.CombTALLY_CLERK1.Location = New System.Drawing.Point(702, 12)
        Me.CombTALLY_CLERK1.Name = "CombTALLY_CLERK1"
        Me.CombTALLY_CLERK1.Size = New System.Drawing.Size(96, 20)
        Me.CombTALLY_CLERK1.TabIndex = 17
        '
        'CombTALLY_CLERK2
        '
        Me.CombTALLY_CLERK2.Location = New System.Drawing.Point(708, 132)
        Me.CombTALLY_CLERK2.Name = "CombTALLY_CLERK2"
        Me.CombTALLY_CLERK2.Size = New System.Drawing.Size(96, 20)
        Me.CombTALLY_CLERK2.TabIndex = 18
        Me.CombTALLY_CLERK2.Visible = False
        '
        'CombTALLY_CLERK3
        '
        Me.CombTALLY_CLERK3.Location = New System.Drawing.Point(702, 42)
        Me.CombTALLY_CLERK3.Name = "CombTALLY_CLERK3"
        Me.CombTALLY_CLERK3.Size = New System.Drawing.Size(96, 20)
        Me.CombTALLY_CLERK3.TabIndex = 19
        '
        'DTPdate
        '
        Me.DTPdate.CustomFormat = "yyyy-MM-dd"
        Me.DTPdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPdate.Location = New System.Drawing.Point(500, 12)
        Me.DTPdate.Name = "DTPdate"
        Me.DTPdate.Size = New System.Drawing.Size(110, 21)
        Me.DTPdate.TabIndex = 22
        Me.DTPdate.Value = New Date(2004, 4, 28, 0, 0, 0, 0)
        '
        'CBMARK
        '
        Me.CBMARK.Location = New System.Drawing.Point(352, 102)
        Me.CBMARK.Name = "CBMARK"
        Me.CBMARK.Size = New System.Drawing.Size(74, 18)
        Me.CBMARK.TabIndex = 23
        Me.CBMARK.Text = "出舱"
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(424, 136)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 39
        Me.BTQUIT.Text = "取消"
        '
        'BTOK
        '
        Me.BTOK.Location = New System.Drawing.Point(352, 136)
        Me.BTOK.Name = "BTOK"
        Me.BTOK.Size = New System.Drawing.Size(65, 24)
        Me.BTOK.TabIndex = 38
        Me.BTOK.Text = "确认"
        '
        'C1dbg
        '
        Me.C1dbg.AllowAddNew = True
        Me.C1dbg.AllowDelete = True
        Me.C1dbg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.C1dbg.Enabled = False
        Me.C1dbg.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1dbg.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1dbg.Location = New System.Drawing.Point(4, 176)
        Me.C1dbg.Name = "C1dbg"
        Me.C1dbg.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1dbg.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1dbg.PreviewInfo.ZoomFactor = 75
        Me.C1dbg.Size = New System.Drawing.Size(836, 246)
        Me.C1dbg.TabIndex = 40
        Me.C1dbg.Text = "C1TrueDBGrid1"
        Me.C1dbg.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><Height>242</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorSty" & _
        "le parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><F" & _
        "ilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=" & _
        """Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Headi" & _
        "ng"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><Inacti" & _
        "veStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9""" & _
        " /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle pa" & _
        "rent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0" & _
        ", 0, 832, 242</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderS" & _
        "tyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""" & _
        "Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Foot" & _
        "er"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactiv" & _
        "e"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /" & _
        "><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" " & _
        "/><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelecto" & _
        "r"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" " & _
        "/></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None" & _
        "</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 832, 242</" & _
        "ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle " & _
        "parent="""" me=""Style15"" /></Blob>"
        '
        'BTNOK
        '
        Me.BTNOK.Enabled = False
        Me.BTNOK.Location = New System.Drawing.Point(430, 438)
        Me.BTNOK.Name = "BTNOK"
        Me.BTNOK.Size = New System.Drawing.Size(65, 24)
        Me.BTNOK.TabIndex = 41
        Me.BTNOK.Text = "确认"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(426, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 22)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "作业日期"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txttime_to
        '
        Me.Txttime_to.Location = New System.Drawing.Point(500, 70)
        Me.Txttime_to.MaxLength = 4
        Me.Txttime_to.Name = "Txttime_to"
        Me.Txttime_to.Size = New System.Drawing.Size(108, 21)
        Me.Txttime_to.TabIndex = 43
        Me.Txttime_to.Text = ""
        '
        'TxtTime_from
        '
        Me.TxtTime_from.Location = New System.Drawing.Point(500, 42)
        Me.TxtTime_from.MaxLength = 4
        Me.TxtTime_from.Name = "TxtTime_from"
        Me.TxtTime_from.Size = New System.Drawing.Size(108, 21)
        Me.TxtTime_from.TabIndex = 44
        Me.TxtTime_from.Text = ""
        '
        'TxtCARGO_LIST_ID
        '
        Me.TxtCARGO_LIST_ID.Location = New System.Drawing.Point(48, 130)
        Me.TxtCARGO_LIST_ID.Name = "TxtCARGO_LIST_ID"
        Me.TxtCARGO_LIST_ID.Size = New System.Drawing.Size(52, 21)
        Me.TxtCARGO_LIST_ID.TabIndex = 46
        Me.TxtCARGO_LIST_ID.Text = ""
        Me.TxtCARGO_LIST_ID.Visible = False
        '
        'CBANCHORAGE_REMARK
        '
        Me.CBANCHORAGE_REMARK.Location = New System.Drawing.Point(492, 102)
        Me.CBANCHORAGE_REMARK.Name = "CBANCHORAGE_REMARK"
        Me.CBANCHORAGE_REMARK.Size = New System.Drawing.Size(58, 18)
        Me.CBANCHORAGE_REMARK.TabIndex = 48
        Me.CBANCHORAGE_REMARK.Text = "锚地"
        '
        'CBNIGHT_MARK
        '
        Me.CBNIGHT_MARK.Location = New System.Drawing.Point(150, 102)
        Me.CBNIGHT_MARK.Name = "CBNIGHT_MARK"
        Me.CBNIGHT_MARK.Size = New System.Drawing.Size(58, 18)
        Me.CBNIGHT_MARK.TabIndex = 50
        Me.CBNIGHT_MARK.Text = "夜班"
        '
        'cbMARK_STANDBY
        '
        Me.cbMARK_STANDBY.Location = New System.Drawing.Point(290, 102)
        Me.cbMARK_STANDBY.Name = "cbMARK_STANDBY"
        Me.cbMARK_STANDBY.Size = New System.Drawing.Size(58, 18)
        Me.cbMARK_STANDBY.TabIndex = 52
        Me.cbMARK_STANDBY.Text = "待时"
        '
        'cbWEIGHT
        '
        Me.cbWEIGHT.Location = New System.Drawing.Point(430, 102)
        Me.cbWEIGHT.Name = "cbWEIGHT"
        Me.cbWEIGHT.Size = New System.Drawing.Size(58, 18)
        Me.cbWEIGHT.TabIndex = 54
        Me.cbWEIGHT.Text = "重装"
        '
        'cbHOLIDAY
        '
        Me.cbHOLIDAY.Location = New System.Drawing.Point(212, 102)
        Me.cbHOLIDAY.Name = "cbHOLIDAY"
        Me.cbHOLIDAY.Size = New System.Drawing.Size(74, 18)
        Me.cbHOLIDAY.TabIndex = 58
        Me.cbHOLIDAY.Text = "节假日"
        '
        'CBSEA_AFFAIRE_CARGO
        '
        Me.CBSEA_AFFAIRE_CARGO.Location = New System.Drawing.Point(554, 102)
        Me.CBSEA_AFFAIRE_CARGO.Name = "CBSEA_AFFAIRE_CARGO"
        Me.CBSEA_AFFAIRE_CARGO.Size = New System.Drawing.Size(58, 18)
        Me.CBSEA_AFFAIRE_CARGO.TabIndex = 56
        Me.CBSEA_AFFAIRE_CARGO.Text = "海事"
        '
        'BTLIST
        '
        Me.BTLIST.Location = New System.Drawing.Point(350, 438)
        Me.BTLIST.Name = "BTLIST"
        Me.BTLIST.Size = New System.Drawing.Size(65, 24)
        Me.BTLIST.TabIndex = 59
        Me.BTLIST.Text = "录入舱单"
        '
        'CBTALLY_OUT
        '
        Me.CBTALLY_OUT.Location = New System.Drawing.Point(616, 102)
        Me.CBTALLY_OUT.Name = "CBTALLY_OUT"
        Me.CBTALLY_OUT.Size = New System.Drawing.Size(74, 18)
        Me.CBTALLY_OUT.TabIndex = 60
        Me.CBTALLY_OUT.Text = "外出理货"
        '
        'TxtTEAM_NO
        '
        Me.TxtTEAM_NO.Location = New System.Drawing.Point(122, 12)
        Me.TxtTEAM_NO.MaxLength = 3
        Me.TxtTEAM_NO.Name = "TxtTEAM_NO"
        Me.TxtTEAM_NO.Size = New System.Drawing.Size(106, 21)
        Me.TxtTEAM_NO.TabIndex = 0
        Me.TxtTEAM_NO.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(74, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 22)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "工班号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCROSS_PERSON
        '
        Me.TxtCROSS_PERSON.Location = New System.Drawing.Point(702, 70)
        Me.TxtCROSS_PERSON.Name = "TxtCROSS_PERSON"
        Me.TxtCROSS_PERSON.Size = New System.Drawing.Size(96, 20)
        Me.TxtCROSS_PERSON.TabIndex = 63
        '
        'TxtHATCH_Position
        '
        Me.TxtHATCH_Position.Items.AddRange(New Object() {"L.H", "T.D", "U.T.D", "ON DECK", "O.D", "L.T.D"})
        Me.TxtHATCH_Position.Location = New System.Drawing.Point(310, 40)
        Me.TxtHATCH_Position.Name = "TxtHATCH_Position"
        Me.TxtHATCH_Position.Size = New System.Drawing.Size(108, 20)
        Me.TxtHATCH_Position.TabIndex = 15
        '
        'TxtYARD_NO
        '
        Me.TxtYARD_NO.Items.AddRange(New Object() {"Warehouse/Stack yard", "Truck", "Wagon", "Lighter"})
        Me.TxtYARD_NO.Location = New System.Drawing.Point(310, 70)
        Me.TxtYARD_NO.Name = "TxtYARD_NO"
        Me.TxtYARD_NO.Size = New System.Drawing.Size(108, 20)
        Me.TxtYARD_NO.TabIndex = 15
        '
        'FrmTally_sheet_add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(844, 477)
        Me.Controls.Add(Me.TxtCROSS_PERSON)
        Me.Controls.Add(Me.TxtTEAM_NO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBTALLY_OUT)
        Me.Controls.Add(Me.BTLIST)
        Me.Controls.Add(Me.cbHOLIDAY)
        Me.Controls.Add(Me.CBSEA_AFFAIRE_CARGO)
        Me.Controls.Add(Me.cbWEIGHT)
        Me.Controls.Add(Me.cbMARK_STANDBY)
        Me.Controls.Add(Me.CBNIGHT_MARK)
        Me.Controls.Add(Me.CBANCHORAGE_REMARK)
        Me.Controls.Add(Me.TxtCARGO_LIST_ID)
        Me.Controls.Add(Me.TxtTime_from)
        Me.Controls.Add(Me.Txttime_to)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BTNOK)
        Me.Controls.Add(Me.C1dbg)
        Me.Controls.Add(Me.BTQUIT)
        Me.Controls.Add(Me.BTOK)
        Me.Controls.Add(Me.CBMARK)
        Me.Controls.Add(Me.DTPdate)
        Me.Controls.Add(Me.CombTALLY_CLERK3)
        Me.Controls.Add(Me.CombTALLY_CLERK2)
        Me.Controls.Add(Me.CombTALLY_CLERK1)
        Me.Controls.Add(Me.CombHATCH_NO)
        Me.Controls.Add(Me.CombBERTHNO)
        Me.Controls.Add(Me.TxtYARD_NO1)
        Me.Controls.Add(Me.TxtHATCH_Position1)
        Me.Controls.Add(Me.TxtNO)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtHATCH_Position)
        Me.Controls.Add(Me.TxtYARD_NO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTally_sheet_add"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "计数单_增加"
        CType(Me.C1dbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmTally_sheet_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        TxtTEAM_NO.Focus()
        dw = Getdata("select CODE_BERTH,NAME_BERTH from CODE_BERTH order by berth_id ", dsberth)
        CombBERTHNO.DataSource = dsberth.Tables(0).DefaultView
        CombBERTHNO.DisplayMember = "NAME_BERTH"
        CombBERTHNO.ValueMember = "CODE_BERTH"

        dw = Getdata("select value,descr from codecabin", dshatch_no)
        CombHATCH_NO.DataSource = dshatch_no.Tables(0).DefaultView
        CombHATCH_NO.DisplayMember = "descr"
        CombHATCH_NO.ValueMember = "value"

        dw = Getdata("select work_no,name from TALLY_CLERK order by name", dsclerk)
        CombTALLY_CLERK1.DataSource = dsclerk.Tables(0).DefaultView
        CombTALLY_CLERK1.DisplayMember = "name"
        CombTALLY_CLERK1.ValueMember = "work_no"

        dw = Getdata("select work_no,name from TALLY_CLERK order by name", dsclerk2)
        CombTALLY_CLERK2.DataSource = dsclerk2.Tables(0).DefaultView
        CombTALLY_CLERK2.DisplayMember = "name"
        CombTALLY_CLERK2.ValueMember = "work_no"

        dw = Getdata("select work_no,name from TALLY_CLERK order by name", dsclerk3)
        CombTALLY_CLERK3.DataSource = dsclerk3.Tables(0).DefaultView
        CombTALLY_CLERK3.DisplayMember = "name"
        CombTALLY_CLERK3.ValueMember = "work_no"

        dw = Getdata("select work_no,name from TALLY_CLERK order by name", dsclerk3)
        TxtCROSS_PERSON.DataSource = dsclerk3.Tables(0).DefaultView
        TxtCROSS_PERSON.DisplayMember = "name"
        TxtCROSS_PERSON.ValueMember = "work_no"
        '**************理货员
        'sqldc = "SELECT NAME, WORK_NO,Tally_Short FROM TALLY_CLERK order by NAME"

        dw = Updatedata(sqlda, "select * from cargo_list where CARGO_LIST_ID='" & ID & "'", ds)
        If ds.Tables(0).DefaultView.Count > 0 Then
            'TxtCARGO_LIST_ID.Text = ds.Tables(0).Rows(0).Item("cargo_list_id")
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
            CombHATCH_NO.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("HATCH_NO"))), "", Trim(ds.Tables(0).Rows(0).Item("HATCH_NO")))
            CombBERTHNO.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("BERTHNO"))), "", Trim(ds.Tables(0).Rows(0).Item("BERTHNO")))
            'TxtCROSS_PERSON.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("CROSS_PERSON"))), "", Trim(ds.Tables(0).Rows(0).Item("CROSS_PERSON")))
            DTPdate.Value = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("date"))), Now, Trim(ds.Tables(0).Rows(0).Item("date")))
            TxtTEAM_NO.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("team_no"))), "", Trim(ds.Tables(0).Rows(0).Item("team_no")))
            'Call clerk()

            'CombTALLY_CLERK1.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk1"))), "00", Trim(ds.Tables(0).Rows(0).Item("tally_clerk1")))
            'CombTALLY_CLERK2.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk2"))), "00", Trim(ds.Tables(0).Rows(0).Item("tally_clerk2")))
            'CombTALLY_CLERK3.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk3"))), "00", Trim(ds.Tables(0).Rows(0).Item("tally_clerk3")))

            Call CBNIGHT_SELECT()
        End If
        CombTALLY_CLERK1.SelectedValue = ""
        CombTALLY_CLERK2.SelectedValue = ""
        CombTALLY_CLERK3.SelectedValue = ""
        TxtCROSS_PERSON.SelectedValue = ""
        'dw = Updatedata(sqlda_sub, "select CARGO_LIST_DETAIL_ID, CARGO_LIST_ID, BLNO, MARK, CODE_GOODS, GOODS_CHA, GOODS_ENG, CODE_PACK, cast(amount as dec(10,0)) as AMOUNT, NON_CARGOHOLD, MARK_ASSORTING, Code_HardWork, FREEZE_AMOUNT, Code_Tally_SPECIAL, TALLY_SPECIAL, OVER_LENGTH_WEIGHT, SIZE_CON, EMPTY_MARK, PIECE_WEIGHT, TONS from cargo_list_detail where cargo_list_id='" & TxtCARGO_LIST_ID.Text & "'", ds_sub) '1>2 ", ds_sub) '
        dw = Updatedata(sqlda_sub, "select CARGO_LIST_DETAIL_ID, CARGO_LIST_ID, BLNO, MARK, CODE_GOODS, GOODS_CHA, GOODS_ENG, CODE_PACK, AMOUNT, NON_CARGOHOLD, MARK_ASSORTING, Code_HardWork, FREEZE_AMOUNT, Code_Tally_SPECIAL, TALLY_SPECIAL, OVER_LENGTH_WEIGHT, SIZE_CON, EMPTY_MARK, PIECE_WEIGHT, TONS from cargo_list_detail where cargo_list_id='" & TxtCARGO_LIST_ID.Text & "'", ds_sub) '1>2 ", ds_sub) '
        Me.C1dbg.DataSource = ds_sub.Tables(0).DefaultView
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
        Me.C1dbg.Columns.Item("FREEZE_AMOUNT").Caption = "困难件数"
        Me.C1dbg.Columns.Item("TALLY_SPECIAL").Caption = "特理"
        Me.C1dbg.Columns.Item("OVER_LENGTH_WEIGHT").Caption = "超长超重"
        Me.C1dbg.Columns.Item("SIZE_CON").Caption = "箱尺寸"
        Me.C1dbg.Columns.Item("EMPTY_MARK").Caption = "重箱"
        Me.C1dbg.Columns.Item("Code_HardWork").Caption = "困难类型"
        Me.C1dbg.Columns.Item("Code_TALLY_SPECIAL").Caption = "特理类型"

        Me.C1dbg.Splits(0).DisplayColumns.Item("BLNO").Width = 100
        Me.C1dbg.Splits(0).DisplayColumns.Item("MARK").Width = 140
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

    Private Sub CBNIGHT_SELECT()
        CBNIGHT_MARK.Enabled = True
        If Len(Trim(TxtTime_from.Text)) = 4 Then
            If CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) < 24 And CType(Mid(Trim(TxtTime_from.Text), 3, 2), Integer) < 60 Then
                If CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) >= 6 And CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) < 22 Then
                    CBNIGHT_MARK.Checked = False
                    CBNIGHT_MARK.Enabled = False
                End If
                If CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) < 6 Or CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) = 22 Or CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) = 23 Then
                    CBNIGHT_MARK.Checked = True
                    CBNIGHT_MARK.Enabled = True
                End If
            Else
                MsgBox("开始时间输入有误！")
                TxtTime_from.Focus()
            End If
        Else
            MsgBox("开始时间输入有误！")
            TxtTime_from.Focus()
        End If
    End Sub

    Private Sub DTPdate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTPdate.Leave
        'Call clerk()
        'CombTALLY_CLERK1.SelectedValue = ""
        'CombTALLY_CLERK2.SelectedValue = ""
        'CombTALLY_CLERK3.SelectedValue = ""
    End Sub

    Private Sub TxtTime_from_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTime_from.Leave
        'Call clerk()
        'CombTALLY_CLERK1.SelectedValue = ""
        'CombTALLY_CLERK2.SelectedValue = ""
        'CombTALLY_CLERK3.SelectedValue = ""
        Call CBNIGHT_SELECT()
    End Sub

    Private Sub BTOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOK.Click
        Dim i As Integer
        Dim dwsub As New DataView
        Dim dsid As New DataSet
        Dim dskey As New DataSet
        Dim cmark As String
        Dim holiday As String
        Dim night As String
        Dim MARK_STANDBY As String
        Dim WEIGHT As String
        Dim ANCHORAGE_REMARK As String
        Dim SEA_AFFAIRE_CARGO As String
        Dim tally_out As String

        If Len(Trim(TxtNO.Text)) > 0 Then
            If Len(Trim(DTPdate.Value)) > 0 Then
                If Len(Trim(TxtTime_from.Text)) = 4 Then
                    If CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) < 24 And CType(Mid(Trim(TxtTime_from.Text), 3, 2), Integer) < 60 Then
                        If Len(Trim(Txttime_to.Text)) = 4 Then
                            If CType(Mid(Trim(Txttime_to.Text), 1, 2), Integer) < 24 And CType(Mid(Trim(Txttime_to.Text), 3, 2), Integer) < 60 Then
                                If CombTALLY_CLERK1.Text.Trim().Length() > 0 Then
                                    Try
                                        If CBMARK.Checked = True Then
                                            cmark = "1"
                                        Else
                                            cmark = "0"
                                        End If
                                        dw = Getdata("select * from CARGO_LIST where ship_id='" & Ship_ID & "' and no='" & TxtNO.Text & "' and mark='" & cmark & "' ", dskey)
                                        If dskey.Tables(0).Rows.Count > 0 Then
                                            MsgBox("该计数单已经存在！")
                                        Else
                                            Dim row As DataRow
                                            row = ds.Tables(0).NewRow

                                            row("ship_id") = Trim(Ship_ID)
                                            row("NO") = Trim(TxtNO.Text)
                                            row("berthno") = IIf(Len(Trim(CombBERTHNO.SelectedValue)) > 0, Trim(CombBERTHNO.SelectedValue), "")
                                            row("HATCH_NO") = IIf(Len(Trim(CombHATCH_NO.SelectedValue)) > 0, Trim(CombHATCH_NO.SelectedValue), "")
                                            row("HATCH_Position") = IIf(Len(Trim(TxtHATCH_Position.Text)) > 0, Trim(TxtHATCH_Position.Text), "")
                                            If CBMARK.Checked = True Then
                                                row("mark") = "1"
                                                cmark = "1"
                                            Else
                                                row("mark") = "0"
                                                cmark = "0"
                                            End If
                                            If cbHOLIDAY.Checked = True Then
                                                row("HOLIDAY") = "1"
                                                holiday = "1"
                                            Else
                                                row("HOLIDAY") = "0"
                                                holiday = "0"
                                            End If
                                            If cbMARK_STANDBY.Checked = True Then
                                                row("MARK_STANDBY") = "1"
                                                MARK_STANDBY = "1"
                                            Else
                                                row("MARK_STANDBY") = "0"
                                                MARK_STANDBY = "0"
                                            End If
                                            If cbWEIGHT.Checked = True Then
                                                row("WEIGHT") = "1"
                                                WEIGHT = "1"
                                            Else
                                                row("WEIGHT") = "0"
                                                WEIGHT = "0"
                                            End If
                                            If CBNIGHT_MARK.Checked = True Then
                                                row("NIGHT_MARK") = "1"
                                                night = "1"
                                            Else
                                                row("NIGHT_MARK") = "0"
                                                night = "0"
                                            End If
                                            If CBANCHORAGE_REMARK.Checked = True Then
                                                row("ANCHORAGE_REMARK") = "1"
                                                ANCHORAGE_REMARK = "1"
                                            Else
                                                row("ANCHORAGE_REMARK") = "0"
                                                ANCHORAGE_REMARK = "0"
                                            End If
                                            If CBSEA_AFFAIRE_CARGO.Checked = True Then
                                                row("SEA_AFFAIRE_CARGO") = "1"
                                                SEA_AFFAIRE_CARGO = "1"
                                            Else
                                                row("SEA_AFFAIRE_CARGO") = "0"
                                                SEA_AFFAIRE_CARGO = "0"
                                            End If
                                            If CBTALLY_OUT.Checked = True Then
                                                row("TALLY_OUT") = "1"
                                                tally_out = "1"
                                            Else
                                                row("TALLY_OUT") = "0"
                                                tally_out = "0"
                                            End If

                                            row("YARD_NO") = IIf(Len(Trim(TxtYARD_NO.Text)) > 0, Trim(TxtYARD_NO.Text), "")
                                            row("team_no") = IIf(Len(Trim(TxtTEAM_NO.Text)) > 0, Trim(TxtTEAM_NO.Text), "")
                                            row("DATE") = DTPdate.Value
                                            row("time_from") = TxtTime_from.Text
                                            row("time_to") = Txttime_to.Text
                                            row("TALLY_CLERK1") = IIf(Len(Trim(CombTALLY_CLERK1.SelectedValue)) > 0, Trim(CombTALLY_CLERK1.SelectedValue), "00")
                                            row("TALLY_CLERK2") = IIf(Len(Trim(CombTALLY_CLERK2.SelectedValue)) > 0, Trim(CombTALLY_CLERK2.SelectedValue), "00")
                                            row("TALLY_CLERK3") = IIf(Len(Trim(CombTALLY_CLERK3.SelectedValue)) > 0, Trim(CombTALLY_CLERK3.SelectedValue), "00")
                                            row("CROSS_PERSON") = IIf(Len(Trim(TxtCROSS_PERSON.Text)) > 0, Trim(TxtCROSS_PERSON.Text), "")
                                            row("user_name") = Trim(G_User)

                                            ds.Tables(0).Rows.Add(row)
                                            sqlda.Update(ds)
                                            ds.Reset()
                                            dw = Getdata("select * from cargo_list where ship_id='" & Ship_ID & "' order by CARGO_LIST_ID desc", ds)
                                            If ds.Tables(0).Rows.Count > 0 Then
                                                For i = 0 To ds.Tables(0).Rows.Count - 1
                                                    If CType(ds.Tables(0).Rows(i).Item("NO"), String) = Trim(TxtNO.Text) Then
                                                        TxtCARGO_LIST_ID.Text = ds.Tables(0).Rows(i).Item("cargo_list_id")
                                                        Exit For
                                                        'If CType(ds.Tables(0).Rows(i).Item("BERTHNO"), String) = IIf(Len(Trim(CombBERTHNO.SelectedValue)) > 0, Trim(CombBERTHNO.SelectedValue), "") Then
                                                        '    If CType(ds.Tables(0).Rows(i).Item("HATCH_NO"), String) = IIf(Len(Trim(CombHATCH_NO.SelectedValue)) > 0, Trim(CombHATCH_NO.SelectedValue), "") Then
                                                        '        If CType(ds.Tables(0).Rows(i).Item("HATCH_Position"), String) = IIf(Len(Trim(TxtHATCH_Position.Text)) > 0, Trim(TxtHATCH_Position.Text), "") Then
                                                        '            If CType(ds.Tables(0).Rows(i).Item("mark"), String) = cmark Then
                                                        '                If CType(ds.Tables(0).Rows(i).Item("holiday"), String) = holiday Then
                                                        '                    If CType(ds.Tables(0).Rows(i).Item("NIGHT_MARK"), String) = night Then
                                                        '                        If CType(ds.Tables(0).Rows(i).Item("MARK_STANDBY"), String) = MARK_STANDBY Then
                                                        '                            If CType(ds.Tables(0).Rows(i).Item("WEIGHT"), String) = WEIGHT Then
                                                        '                                If CType(ds.Tables(0).Rows(i).Item("ANCHORAGE_REMARK"), String) = ANCHORAGE_REMARK Then
                                                        '                                    If CType(ds.Tables(0).Rows(i).Item("SEA_AFFAIRE_CARGO"), String) = SEA_AFFAIRE_CARGO Then
                                                        '                                        If CType(ds.Tables(0).Rows(i).Item("TALLY_OUT"), String) = tally_out Then
                                                        '                                            If CType(ds.Tables(0).Rows(i).Item("YARD_NO"), String) = IIf(Len(Trim(TxtYARD_NO.Text)) > 0, Trim(TxtYARD_NO.Text), "") Then
                                                        '                                                If Year(ds.Tables(0).Rows(i).Item("date")) = Year(DTPdate.Value) And Month(ds.Tables(0).Rows(i).Item("date")) = Month(DTPdate.Value) And Day(ds.Tables(0).Rows(i).Item("date")) = Day(DTPdate.Value) Then
                                                        '                                                    If CType(ds.Tables(0).Rows(i).Item("TIME_FROM"), String) = TxtTime_from.Text Then
                                                        '                                                        If CType(ds.Tables(0).Rows(i).Item("time_to"), String) = Txttime_to.Text Then
                                                        '                                                            If CType(ds.Tables(0).Rows(i).Item("TALLY_CLERK1"), String) = IIf(Len(Trim(CombTALLY_CLERK1.SelectedValue)) > 0, Trim(CombTALLY_CLERK1.SelectedValue), "") Then
                                                        '                                                                If CType(ds.Tables(0).Rows(i).Item("TALLY_CLERK2"), String) = IIf(Len(Trim(CombTALLY_CLERK2.SelectedValue)) > 0, Trim(CombTALLY_CLERK2.SelectedValue), "") Then
                                                        '                                                                    If CType(ds.Tables(0).Rows(i).Item("TALLY_CLERK3"), String) = IIf(Len(Trim(CombTALLY_CLERK3.SelectedValue)) > 0, Trim(CombTALLY_CLERK3.SelectedValue), "") Then
                                                        '                                                                        If CType(ds.Tables(0).Rows(i).Item("NO"), String) = Trim(TxtNO.Text) Then
                                                        '                                                                            TxtCARGO_LIST_ID.Text = ds.Tables(0).Rows(i).Item("cargo_list_id")
                                                        '                                                                            Exit For
                                                        '                                                                        End If
                                                        '                                                                    End If
                                                        '                                                                End If
                                                        '                                                            End If
                                                        '                                                        End If
                                                        '                                                    End If
                                                        '                                                End If
                                                        '                                            End If
                                                        '                                        End If
                                                        '                                    End If
                                                        '                                End If
                                                        '                            End If
                                                        '                        End If
                                                        '                    End If
                                                        '                End If
                                                        '            End If
                                                        '        End If
                                                        '    End If
                                                        'End If
                                                    End If
                                                Next i
                                            End If

                                            BTNOK.Enabled = True
                                            BTLIST.Enabled = True

                                            Me.C1dbg.Enabled = True
                                            TxtNO.Enabled = False
                                            CombBERTHNO.Enabled = False
                                            CombHATCH_NO.Enabled = False
                                            TxtHATCH_Position.Enabled = False
                                            TxtYARD_NO.Enabled = False
                                            TxtCROSS_PERSON.Enabled = False
                                            DTPdate.Enabled = False
                                            TxtTime_from.Enabled = False
                                            Txttime_to.Enabled = False
                                            CombTALLY_CLERK1.Enabled = False
                                            CombTALLY_CLERK2.Enabled = False
                                            CombTALLY_CLERK3.Enabled = False
                                            CBMARK.Enabled = False
                                            cbHOLIDAY.Enabled = False
                                            cbMARK_STANDBY.Enabled = False
                                            cbWEIGHT.Enabled = False
                                            CBNIGHT_MARK.Enabled = False
                                            CBANCHORAGE_REMARK.Enabled = False
                                            CBSEA_AFFAIRE_CARGO.Enabled = False
                                            CBTALLY_OUT.Enabled = False
                                            BTOK.Enabled = False
                                            TxtTEAM_NO.Enabled = False

                                            If ds_sub.Tables(0).Rows.Count = 0 Then
                                                Me.C1dbg.Select()
                                                Me.C1dbg.Row = Me.C1dbg.Row + 1
                                            End If

                                            Call blno_fill()
                                            Call PACK()
                                            Call HARDWORK()
                                            Call ITEM_FILL()
                                            Call TALLY_SPECIAL()
                                            Call CODE_GOODS()

                                            Me.C1dbg.Refresh()
                                        End If
                                    Catch ex As System.Exception
                                        MsgBox(ex.Message)
                                    End Try
                                Else
                                    MsgBox("理货员不能为空。")
                                End If
                            Else
                                MsgBox("作业止时间填写错误！请填写4位数字，不加冒号。")
                            End If
                        Else
                            MsgBox("作业止时间填写错误！请填写4位数字，不加冒号。")
                        End If
                    Else
                        MsgBox("作业起时间填写错误！请填写4位数字，不加冒号。")
                    End If
                Else
                    MsgBox("作业起时间填写错误！请填写4位数字，不加冒号。")
                End If
            Else
                MsgBox("作业日期不能为空！")
            End If
        Else
            MsgBox("编号不能为空！")
        End If
    End Sub

    Private Sub blno_fill()
        Try
            Dim i As Integer
            dshatch_list.Reset()
            dw = Updatedata(sqlda_hatch_list, "select distinct blno from cargo_hatch_list where ship_id='" & Ship_ID & "'", dshatch_list)
            If dshatch_list.Tables(0).Rows.Count > 0 Then
                Me.C1dbg.Columns.Item("blno").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
                Me.C1dbg.Columns.Item("blno").ValueItems.Translate = True
                Do While Me.C1dbg.Columns.Item("blno").ValueItems.Values.Count > 0
                    Me.C1dbg.Columns.Item("blno").ValueItems.Values.RemoveAt(0)
                Loop
                For i = 0 To dshatch_list.Tables(0).Rows.Count - 1
                    Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                    vi.DisplayValue = dshatch_list.Tables(0).Rows(i)("blno")
                    vi.Value = dshatch_list.Tables(0).Rows(i)("blno")
                    Me.C1dbg.Columns.Item("blno").ValueItems.Values.Add(vi)
                Next
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mark_fill(ByVal BL As String)
        Try
            Dim i As Integer
            If Len(Me.C1dbg.Columns.Item("blno").Value) > 0 Then
                dsmark.Reset()
                dw = Updatedata(sqlda_hatch_list, "select distinct mark from cargo_hatch_list where ship_id='" & Ship_ID & "' and blno='" & BL & "'", dsmark)
                If dsmark.Tables(0).Rows.Count > 0 Then
                    Me.C1dbg.Columns.Item("mark").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
                    Me.C1dbg.Columns.Item("mark").ValueItems.Translate = True
                    Do While Me.C1dbg.Columns.Item("mark").ValueItems.Values.Count > 0
                        Me.C1dbg.Columns.Item("mark").ValueItems.Values.RemoveAt(0)
                    Loop
                    For i = 0 To dsmark.Tables(0).Rows.Count - 1
                        Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                        vi.DisplayValue = dsmark.Tables(0).Rows(i)("mark")
                        vi.Value = dsmark.Tables(0).Rows(i)("mark")
                        Me.C1dbg.Columns.Item("mark").ValueItems.Values.Add(vi)
                    Next
                    Me.C1dbg.Columns.Item("mark").Value = dsmark.Tables(0).Rows(0).Item("mark")
                Else
                    If MsgBox("本航次舱单数据中没有此提单号！必须录入非原舱单数据", MsgBoxStyle.OKOnly, "提示") = MsgBoxResult.OK Then
                        mark = "1"
                        Dim frm As New FrmCargo_hatch_list_add
                        'frm.MdiParent = Me
                        frm.ShowDialog()
                    End If
                End If
            End If
            'Me.C1dbg.Columns.Item("mark").Text = ""
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PACK()
        Try
            Dim i As Integer
            DSPACK.Reset()
            dw = Getdata("select CODE_PACK,PACK_CHA from CODE_PACK order by px", DSPACK)
            If DSPACK.Tables(0).Rows.Count > 0 Then
                Me.C1dbg.Columns.Item("CODE_PACK").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
                Me.C1dbg.Columns.Item("CODE_PACK").ValueItems.Translate = True
                Do While Me.C1dbg.Columns.Item("CODE_PACK").ValueItems.Values.Count > 0
                    Me.C1dbg.Columns.Item("CODE_PACK").ValueItems.Values.RemoveAt(0)
                Loop
                For i = 0 To DSPACK.Tables(0).Rows.Count - 1
                    Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                    vi.DisplayValue = DSPACK.Tables(0).Rows(i)("PACK_CHA")
                    vi.Value = DSPACK.Tables(0).Rows(i)("CODE_PACK")
                    Me.C1dbg.Columns.Item("CODE_PACK").ValueItems.Values.Add(vi)
                Next
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CODE_GOODS() '所有的货类填充
        Dim DSGOODS As New DataSet
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
                    Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                    vi.DisplayValue = DSGOODS.Tables(0).Rows(i)("GOODS_CHA")
                    vi.Value = DSGOODS.Tables(0).Rows(i)("CODE_GOODS")
                    Me.C1dbg.Columns.Item("CODE_GOODS").ValueItems.Values.Add(vi)
                Next
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GOODS()
        Dim DSGOODS As New DataSet
        Try
            Dim i As Integer
            DSGOODS.Reset()
            dw = Getdata("exec SPCARGO_TALLY_SHEET_GOODSSELECT '" & Ship_ID & "','" & Me.C1dbg.Columns.Item("blno").Text & "','" & Me.C1dbg.Columns.Item("mark").Text & "'", DSGOODS)
            If DSGOODS.Tables(0).Rows.Count > 0 Then
                'Me.C1dbg.Columns.Item("CODE_GOODS").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
                'Me.C1dbg.Columns.Item("CODE_GOODS").ValueItems.Translate = True
                'Do While Me.C1dbg.Columns.Item("CODE_GOODS").ValueItems.Values.Count > 0
                '    Me.C1dbg.Columns.Item("CODE_GOODS").ValueItems.Values.RemoveAt(0)
                'Loop
                'For i = 0 To DSGOODS.Tables(0).Rows.Count - 1
                '    Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                '    vi.DisplayValue = DSGOODS.Tables(0).Rows(i)("GOODS_CHA")
                '    vi.Value = DSGOODS.Tables(0).Rows(i)("CODE_GOODS")
                '    Me.C1dbg.Columns.Item("CODE_GOODS").ValueItems.Values.Add(vi)
                'Next
                Me.C1dbg.Columns.Item("code_goods").Value = DSGOODS.Tables(0).Rows(0).Item("code_goods")
                Me.C1dbg.Columns.Item("GOODS_CHA").Value = DSGOODS.Tables(0).Rows(0).Item("GOODS_CHA")
                Me.C1dbg.Columns.Item("code_pack").Value = DSGOODS.Tables(0).Rows(0).Item("pack")

            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GOODS_CHA()
        Dim DSGOODS_CHA As New DataSet
        Try
            Dim i As Integer
            DSGOODS_CHA.Reset()
            dw = Getdata("select distinct goods_cha from cargo_hatch_list where ship_id= '" & Ship_ID & "' and blno='" & Me.C1dbg.Columns.Item("blno").Text & "' and mark='" & Me.C1dbg.Columns.Item("mark").Text & "' and code_goods='" & Me.C1dbg.Columns.Item("code_goods").Value & "'", DSGOODS_CHA)
            If DSGOODS_CHA.Tables(0).Rows.Count > 0 Then
                Me.C1dbg.Columns.Item("GOODS_CHA").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
                Me.C1dbg.Columns.Item("GOODS_CHA").ValueItems.Translate = True
                Do While Me.C1dbg.Columns.Item("GOODS_CHA").ValueItems.Values.Count > 0
                    Me.C1dbg.Columns.Item("GOODS_CHA").ValueItems.Values.RemoveAt(0)
                Loop
                For i = 0 To DSGOODS_CHA.Tables(0).Rows.Count - 1
                    Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                    vi.DisplayValue = DSGOODS_CHA.Tables(0).Rows(i)("GOODS_CHA")
                    vi.Value = DSGOODS_CHA.Tables(0).Rows(i)("GOODS_CHA")
                    Me.C1dbg.Columns.Item("GOODS_CHA").ValueItems.Values.Add(vi)
                Next
                Me.C1dbg.Columns.Item("GOODS_CHA").Value = DSGOODS_CHA.Tables(0).Rows(0).Item("GOODS_CHA")
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
                    Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
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
                    Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                    vi.DisplayValue = DSTALLY_SPECIAL.Tables(0).Rows(i)("Tally_SPECIAL")
                    vi.Value = DSTALLY_SPECIAL.Tables(0).Rows(i)("Code_Tally_SPECIAL")
                    Me.C1dbg.Columns.Item("Code_Tally_SPECIAL").ValueItems.Values.Add(vi)
                Next
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ITEM_FILL()
        Try
            Dim i As Integer
            Dim dstrue As New DataSet
            dstrue.Reset()
            dw = Getdata("select Value,Descri from true", dstrue)
            Me.C1dbg.Columns.Item("EMPTY_MARK").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
            Me.C1dbg.Columns.Item("EMPTY_MARK").ValueItems.Translate = True
            Do While Me.C1dbg.Columns.Item("EMPTY_MARK").ValueItems.Values.Count > 0
                Me.C1dbg.Columns.Item("EMPTY_MARK").ValueItems.Values.RemoveAt(0)
            Loop
            For i = 0 To dstrue.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
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

    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub

    Private Sub CODE_PACK(ByVal BL As String, ByVal MARK As String)
        Try
            Dim dscode_pack As New DataSet
            dw = Getdata("select code_pack from cargo_hatch_list where blno='" & Me.C1dbg.Columns.Item("blno").Text & "' and mark='" & Me.C1dbg.Columns.Item("mark").Text & "' and code_goods='" & Me.C1dbg.Columns.Item("code_goods").Value & "' and goods_cha='" & Me.C1dbg.Columns.Item("goods_cha").Value & "'", dscode_pack)
            If dscode_pack.Tables(0).Rows.Count > 0 Then
                Me.C1dbg.Columns.Item("code_pack").Value = dscode_pack.Tables(0).Rows(0).Item("code_pack")
            End If
            'Dim DS1 As New DataSet()
            'dw = Getdata("SELECT CARGO_HATCH_LIST_ID FROM CARGO_HATCH_LIST WHERE SHIP_ID='" & Ship_ID & "' AND BLNO='" & BL & "' AND MARK='" & MARK & "'", DS1)
            'If DS1.Tables(0).Rows.Count > 0 Then
            'Else
            '    If MsgBox("本航次舱单数据中没有此提单号！必须录入非原舱单数据", MsgBoxStyle.OKOnly, "提示") = MsgBoxResult.OK Then
            '        MARK = "1"
            '        Dim frm As New FrmCargo_hatch_list_add()
            '        'frm.MdiParent = Me
            '        frm.ShowDialog()
            '    End If
            'End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub C1dbg_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles C1dbg.RowColChange
        Try
            Call ITEM_FILL()
            If e.LastCol = 2 Then
                Me.C1dbg.Columns.Item("cargo_list_id").Text = TxtCARGO_LIST_ID.Text
                Call mark_fill(Me.C1dbg.Columns.Item("blno").Text.ToString)
                Call GOODS()
                'Call GOODS_CHA()
                'Call CODE_PACK(Me.C1dbg.Columns.Item("blno").Text.ToString, Me.C1dbg.Columns.Item("mark").Text.ToString)
            End If
            'If e.LastCol = 3 Then
            '    Me.C1dbg.Columns.Item("cargo_list_id").Text = TxtCARGO_LIST_ID.Text
            '    Call GOODS_CHA()
            '    Call CODE_PACK(Me.C1dbg.Columns.Item("blno").Text.ToString, Me.C1dbg.Columns.Item("mark").Text.ToString)
            'End If
            'If e.LastCol = 4 Then
            '    Me.C1dbg.Columns.Item("cargo_list_id").Text = TxtCARGO_LIST_ID.Text
            '    Call GOODS_CHA()
            '    Call CODE_PACK(Me.C1dbg.Columns.Item("blno").Text.ToString, Me.C1dbg.Columns.Item("mark").Text.ToString)
            'End If
            'If e.LastCol = 5 Then
            '    Me.C1dbg.Columns.Item("cargo_list_id").Text = TxtCARGO_LIST_ID.Text
            '    Call CODE_PACK(Me.C1dbg.Columns.Item("blno").Text.ToString, Me.C1dbg.Columns.Item("mark").Text.ToString)
            'End If

            If e.LastRow <> -1 And Me.C1dbg.Columns.Item("cargo_list_id").Text = "" Then
                Call blno_fill()
                Me.C1dbg.Columns.Item("cargo_list_id").Text = TxtCARGO_LIST_ID.Text
                Me.C1dbg.Columns.Item("EMPTY_MARK").Value = 0
                Me.C1dbg.Columns.Item("TALLY_SPECIAL").Value = 0
                'Me.C1dbg.Columns.Item("TALLY_OUT").Value = 0
                'Me.C1dbg.Columns.Item("OUT_HATCH").Value = 0

                Call ITEM_FILL()
                'Call PACK()
                Call HARDWORK()
                Call TALLY_SPECIAL()

                'If cbHOLIDAY.Checked = True Then
                '    Me.C1dbg.Columns.Item("HOLIDAY").Value = "1"
                'Else
                '    Me.C1dbg.Columns.Item("HOLIDAY").Value = "0"
                'End If
                'If cbMARK_STANDBY.Checked = True Then
                '    Me.C1dbg.Columns.Item("MARK_STANDBY").Value = "1"
                'Else
                '    Me.C1dbg.Columns.Item("MARK_STANDBY").Value = "0"
                'End If
                'If cbWEIGHT.Checked = True Then
                '    Me.C1dbg.Columns.Item("WEIGHT").Value = "1"
                'Else
                '    Me.C1dbg.Columns.Item("WEIGHT").Value = "0"
                'End If
                'If CBNIGHT_MARK.Checked = True Then
                '    Me.C1dbg.Columns.Item("NIGHT_MARK").Value = "1"
                'Else
                '    Me.C1dbg.Columns.Item("NIGHT_MARK").Value = "0"
                'End If
                'If CBANCHORAGE_REMARK.Checked = True Then
                '    Me.C1dbg.Columns.Item("ANCHORAGE_REMARK").Value = "1"
                'Else
                '    Me.C1dbg.Columns.Item("ANCHORAGE_REMARK").Value = "0"
                'End If
                'If CBSEA_AFFAIRE_CARGO.Checked = True Then
                '    Me.C1dbg.Columns.Item("SEA_AFFAIRE_CARGO").Value = "1"
                'Else
                '    Me.C1dbg.Columns.Item("SEA_AFFAIRE_CARGO").Value = "0"
                'End If
            End If
            'If e.LastRow <> -1 And Me.C1dbg.Columns.Item("").Text.ToString <> "" And Me.C1dbg.Columns.Item("blno").Text = "" Then
            '    MsgBox("提单号不能为空！")
            'End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub C1DBG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C1dbg.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.C1dbg.Col = 16 Then
                Me.C1dbg.Row = Me.C1dbg.Row + 1
                Me.C1dbg.Col = 0
                SendKeys.Send("{LEFT}")
            End If
        End If
    End Sub

    Private Sub BTNOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNOK.Click
        Try
            sqlda_sub.Update(ds_sub)
            Call BTQUIT_Click(sender, e)
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTLIST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTLIST.Click
        mark = "1"
        Dim frm As New FrmCargo_hatch_list_add
        'frm.MdiParent = Me
        frm.ShowDialog()
    End Sub
    Private Sub Txtteam_NO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTEAM_NO.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtNO.Focus()
        End If
    End Sub
    Private Sub TxtNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNO.KeyPress
        If e.KeyChar = Chr(13) Then
            CombBERTHNO.Focus()
            TxtNO.Text = TxtNO.Text.ToUpper()
        End If
    End Sub
    Private Sub CombBERTHNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombBERTHNO.KeyPress
        If e.KeyChar = Chr(13) Then
            CombHATCH_NO.Focus()
        End If
    End Sub
    Private Sub CombHATCH_NO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombHATCH_NO.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtHATCH_Position.Focus()
        End If
    End Sub
    Private Sub TxtHATCH_Position_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtHATCH_Position.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtYARD_NO.Focus()
        End If
    End Sub
    Private Sub TxtYARD_NO_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtYARD_NO.KeyPress
        If e.KeyChar = Chr(13) Then
            DTPdate.Focus()
        End If
    End Sub
    Private Sub TxtCROSS_PERSON_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCROSS_PERSON.KeyPress
        If e.KeyChar = Chr(13) Then
            If CBNIGHT_MARK.Enabled = True Then
                CBNIGHT_MARK.Focus()
            Else
                cbHOLIDAY.Focus()
            End If
        End If
    End Sub
    Private Sub DTPdate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DTPdate.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtTime_from.Focus()
        End If
    End Sub
    Private Sub TxtTime_from_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTime_from.KeyPress
        If e.KeyChar = Chr(13) Then
            Txttime_to.Focus()
        End If
    End Sub
    Private Sub Txttime_to_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txttime_to.KeyPress
        If e.KeyChar = Chr(13) Then
            CombTALLY_CLERK1.Focus()
        End If
    End Sub
    Private Sub CombTALLY_CLERK1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombTALLY_CLERK1.KeyPress
        If e.KeyChar = Chr(13) Then
            CombTALLY_CLERK3.Focus()
            'CombTALLY_CLERK2.Focus()
            'End If
        End If
    End Sub
    Private Sub CombTALLY_CLERK2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombTALLY_CLERK2.KeyPress
        If e.KeyChar = Chr(13) Then
            CombTALLY_CLERK3.Focus()
        End If
    End Sub
    Private Sub CombTALLY_CLERK3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombTALLY_CLERK3.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtCROSS_PERSON.Focus()
        End If
    End Sub
    Private Sub CBNIGHT_MARK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBNIGHT_MARK.KeyPress
        If e.KeyChar = Chr(13) Then
            cbHOLIDAY.Focus()
        End If
    End Sub
    Private Sub cbHOLIDAY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbHOLIDAY.KeyPress
        If e.KeyChar = Chr(13) Then
            cbMARK_STANDBY.Focus()
        End If
    End Sub
    Private Sub cbMARK_STANDBY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbMARK_STANDBY.KeyPress
        If e.KeyChar = Chr(13) Then
            CBMARK.Focus()
        End If
    End Sub
    Private Sub CBMARK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBMARK.KeyPress
        If e.KeyChar = Chr(13) Then
            cbWEIGHT.Focus()
        End If
    End Sub
    Private Sub cbWEIGHT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbWEIGHT.KeyPress
        If e.KeyChar = Chr(13) Then
            CBANCHORAGE_REMARK.Focus()
        End If
    End Sub
    Private Sub CBANCHORAGE_REMARK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBANCHORAGE_REMARK.KeyPress
        If e.KeyChar = Chr(13) Then
            CBSEA_AFFAIRE_CARGO.Focus()
        End If
    End Sub
    Private Sub CBSEA_AFFAIRE_CARGO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBSEA_AFFAIRE_CARGO.KeyPress
        If e.KeyChar = Chr(13) Then
            CBTALLY_OUT.Focus()
        End If
    End Sub
    Private Sub CBTALLY_OUT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBTALLY_OUT.KeyPress
        If e.KeyChar = Chr(13) Then
            BTOK.Focus()
        End If
    End Sub
    Private Sub CombBERTHNO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CombBERTHNO.Leave
        Dim DSSELECT As New DataSet
        Try
            If Len(Trim(CombBERTHNO.Text)) > 0 Then
                If Mid(Trim(CombBERTHNO.Text), 1, 1) = "0" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "1" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "2" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "3" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "4" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "5" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "6" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "7" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "8" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "9" Then
                    dw = Getdata("SELECT * FROM CODE_BERTH WHERE CODE_BERTH='" & Trim(CombBERTHNO.Text) & "'", DSSELECT)
                    If DSSELECT.Tables(0).Rows.Count > 0 Then
                        CombBERTHNO.SelectedValue = Trim(CombBERTHNO.Text)
                    Else
                        MsgBox("没有该泊位号，请检查输入是否正确！")
                        CombBERTHNO.Focus()
                    End If
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CombHATCH_NO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CombHATCH_NO.Leave
        Dim DSSELECT As New DataSet
        Try
            If Len(Trim(CombHATCH_NO.Text)) > 0 Then
                If Mid(Trim(CombHATCH_NO.Text), 1, 1) = "0" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "1" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "2" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "3" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "4" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "5" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "6" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "7" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "8" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "9" Then
                    If Len(Trim(CombHATCH_NO.Text)) = 1 Then
                        CombHATCH_NO.Text = "0" + CType(Trim(CombHATCH_NO.Text), String)
                    End If
                    dw = Getdata("SELECT * FROM CODECABIN WHERE VALUE='" & Trim(CombHATCH_NO.Text) & "' or DESCR='" & Trim(CombHATCH_NO.Text) & "'", DSSELECT)
                    If DSSELECT.Tables(0).Rows.Count > 0 Then
                        CombHATCH_NO.SelectedValue = DSSELECT.Tables(0).Rows(0).Item("value")
                    Else
                        MsgBox("没有该舱别，请检查输入是否正确！")
                        CombHATCH_NO.Focus()
                    End If
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CombTALLY_CLERK1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CombTALLY_CLERK1.Leave
        Dim str As String

        If CombTALLY_CLERK1.Text.Trim().Length > 0 Then
            If (Asc(Mid(CombTALLY_CLERK1.Text.Trim(), 1, 1)) >= Asc("a") And Asc(Mid(CombTALLY_CLERK1.Text.Trim(), 1, 1)) <= Asc("z")) Or (Asc(Mid(CombTALLY_CLERK1.Text.Trim(), 1, 1)) >= Asc("A") And Asc(Mid(CombTALLY_CLERK1.Text.Trim(), 1, 1)) <= Asc("Z")) Then
                dss.Reset()
                str = "SELECT NAME, WORK_NO,Tally_Short FROM TALLY_CLERK where Tally_Short='" & CombTALLY_CLERK1.Text.Trim() & "'  order by NAME"
                dw = Getdata(str, dss)
                If dw.Count > 0 Then
                    'CombTALLY_CLERK1.DataSource = dsclerk.Tables(0).DefaultView
                    'CombTALLY_CLERK1.DisplayMember = "NAME"
                    'CombTALLY_CLERK1.ValueMember = "WORK_NO"
                    CombTALLY_CLERK1.SelectedValue = dss.Tables(0).Rows(0)("WORK_NO")
                End If
            End If
        End If
    End Sub

    Private Sub CombTALLY_CLERK2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CombTALLY_CLERK2.Leave
        Dim str As String

        If CombTALLY_CLERK2.Text.Trim().Length > 0 Then
            If (Asc(Mid(CombTALLY_CLERK2.Text.Trim(), 1, 1)) >= Asc("a") And Asc(Mid(CombTALLY_CLERK2.Text.Trim(), 1, 1)) <= Asc("z")) Or (Asc(Mid(CombTALLY_CLERK2.Text.Trim(), 1, 1)) >= Asc("A") And Asc(Mid(CombTALLY_CLERK2.Text.Trim(), 1, 1)) <= Asc("Z")) Then
                dss.Reset()
                str = "SELECT NAME, WORK_NO,Tally_Short FROM TALLY_CLERK where Tally_Short='" & CombTALLY_CLERK2.Text.Trim() & "'  order by NAME"
                dw = Getdata(str, dss)
                If dw.Count > 0 Then
                    'CombTALLY_CLERK2.DataSource = dsclerk2.Tables(0).DefaultView
                    'CombTALLY_CLERK2.DisplayMember = "NAME"
                    'CombTALLY_CLERK2.ValueMember = "WORK_NO"
                    CombTALLY_CLERK2.SelectedValue = dss.Tables(0).Rows(0)("WORK_NO")
                End If
            End If
        End If
    End Sub

    Private Sub CombTALLY_CLERK3_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CombTALLY_CLERK3.Leave
        Dim str As String

        If CombTALLY_CLERK3.Text.Trim().Length > 0 Then
            If (Asc(Mid(CombTALLY_CLERK3.Text.Trim(), 1, 1)) >= Asc("a") And Asc(Mid(CombTALLY_CLERK3.Text.Trim(), 1, 1)) <= Asc("z")) Or (Asc(Mid(CombTALLY_CLERK3.Text.Trim(), 1, 1)) >= Asc("A") And Asc(Mid(CombTALLY_CLERK3.Text.Trim(), 1, 1)) <= Asc("Z")) Then
                dss.Reset()
                str = "SELECT NAME, WORK_NO,Tally_Short FROM TALLY_CLERK where Tally_Short='" & CombTALLY_CLERK3.Text.Trim() & "'  order by NAME"
                dw = Getdata(str, dss)
                If dw.Count > 0 Then
                    'CombTALLY_CLERK3.DataSource = dsclerk3.Tables(0).DefaultView
                    'CombTALLY_CLERK3.DisplayMember = "NAME"
                    'CombTALLY_CLERK3.ValueMember = "WORK_NO"
                    CombTALLY_CLERK3.SelectedValue = dss.Tables(0).Rows(0)("WORK_NO")
                End If
            End If
        End If
    End Sub

    Private Sub TxtCROSS_PERSON_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCROSS_PERSON.Leave
        Dim str As String

        If TxtCROSS_PERSON.Text.Trim().Length > 0 Then
            If (Asc(Mid(TxtCROSS_PERSON.Text.Trim(), 1, 1)) >= Asc("a") And Asc(Mid(TxtCROSS_PERSON.Text.Trim(), 1, 1)) <= Asc("z")) Or (Asc(Mid(TxtCROSS_PERSON.Text.Trim(), 1, 1)) >= Asc("A") And Asc(Mid(TxtCROSS_PERSON.Text.Trim(), 1, 1)) <= Asc("Z")) Then
                dss.Reset()
                str = "SELECT NAME, WORK_NO,Tally_Short FROM TALLY_CLERK where Tally_Short='" & TxtCROSS_PERSON.Text.Trim() & "'  order by NAME"
                dw = Getdata(str, dss)
                If dw.Count > 0 Then
                    'CombTALLY_CLERK3.DataSource = dsclerk3.Tables(0).DefaultView
                    'CombTALLY_CLERK3.DisplayMember = "NAME"
                    'CombTALLY_CLERK3.ValueMember = "WORK_NO"
                    TxtCROSS_PERSON.SelectedValue = dss.Tables(0).Rows(0)("WORK_NO")
                End If
            End If
        End If
    End Sub

End Class
