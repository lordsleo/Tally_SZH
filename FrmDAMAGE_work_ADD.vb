Imports TALLY.DBControl
Public Class FrmDAMAGE_work_ADD
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dw As New DataView()
    Dim dsgoods As New DataSet()
    Dim dspack As New DataSet()
    Dim dsberth As New DataSet()
    Dim dshatch_no As New DataSet()
    Dim dsclerk As New DataSet()
    Dim DSDAMAGE As New DataSet()
    Dim dsBLNO As New DataSet
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
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents TxtGOODS_CHA As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents BTADD As System.Windows.Forms.Button
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents BTOK As System.Windows.Forms.Button
    Friend WithEvents BTBLNO As System.Windows.Forms.Button
    Friend WithEvents TxtNO As System.Windows.Forms.TextBox
    Friend WithEvents CombCode_pack As System.Windows.Forms.ComboBox
    Friend WithEvents TxtAMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents combcode_goods As System.Windows.Forms.ComboBox
    Friend WithEvents TxtMARK As System.Windows.Forms.TextBox
    Friend WithEvents txtBLNO As System.Windows.Forms.TextBox
    Friend WithEvents CombDAMAGED_REMARK As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDESCR As System.Windows.Forms.TextBox
    Friend WithEvents CombTALLY_CLERK As System.Windows.Forms.ComboBox
    Friend WithEvents TxtTime_from As System.Windows.Forms.TextBox
    Friend WithEvents Txttime_to As System.Windows.Forms.TextBox
    Friend WithEvents DTPRECORD_DAY As System.Windows.Forms.DateTimePicker
    Friend WithEvents CombHATCH_NO As System.Windows.Forms.ComboBox
    Friend WithEvents CombBERTHNO As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmDAMAGE_work_ADD))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TxtGOODS_CHA = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.BTADD = New System.Windows.Forms.Button
        Me.BTQUIT = New System.Windows.Forms.Button
        Me.BTOK = New System.Windows.Forms.Button
        Me.BTBLNO = New System.Windows.Forms.Button
        Me.TxtNO = New System.Windows.Forms.TextBox
        Me.CombCode_pack = New System.Windows.Forms.ComboBox
        Me.TxtAMOUNT = New System.Windows.Forms.TextBox
        Me.combcode_goods = New System.Windows.Forms.ComboBox
        Me.TxtMARK = New System.Windows.Forms.TextBox
        Me.txtBLNO = New System.Windows.Forms.TextBox
        Me.CombDAMAGED_REMARK = New System.Windows.Forms.ComboBox
        Me.TxtDESCR = New System.Windows.Forms.TextBox
        Me.CombTALLY_CLERK = New System.Windows.Forms.ComboBox
        Me.TxtTime_from = New System.Windows.Forms.TextBox
        Me.Txttime_to = New System.Windows.Forms.TextBox
        Me.DTPRECORD_DAY = New System.Windows.Forms.DateTimePicker
        Me.CombHATCH_NO = New System.Windows.Forms.ComboBox
        Me.CombBERTHNO = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DBG
        '
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
        Me.C1DBG.Location = New System.Drawing.Point(10, 4)
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
        Me.C1DBG.Size = New System.Drawing.Size(380, 298)
        Me.C1DBG.TabIndex = 166
        Me.C1DBG.Text = "C1TrueDBGrid1"
        Me.C1DBG.Visible = False
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        ", 0, 376, 294</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2" & _
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
        "yout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 3" & _
        "76, 294</ClientArea></Blob>"
        '
        'TxtGOODS_CHA
        '
        Me.TxtGOODS_CHA.Enabled = False
        Me.TxtGOODS_CHA.Location = New System.Drawing.Point(280, 64)
        Me.TxtGOODS_CHA.MaxLength = 30
        Me.TxtGOODS_CHA.Name = "TxtGOODS_CHA"
        Me.TxtGOODS_CHA.Size = New System.Drawing.Size(108, 21)
        Me.TxtGOODS_CHA.TabIndex = 165
        Me.TxtGOODS_CHA.Text = ""
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(194, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 22)
        Me.Label15.TabIndex = 164
        Me.Label15.Text = "货物中文描述"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTADD
        '
        Me.BTADD.Location = New System.Drawing.Point(96, 276)
        Me.BTADD.Name = "BTADD"
        Me.BTADD.Size = New System.Drawing.Size(65, 24)
        Me.BTADD.TabIndex = 163
        Me.BTADD.Text = "清空"
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(242, 276)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 162
        Me.BTQUIT.Text = "取消"
        '
        'BTOK
        '
        Me.BTOK.Location = New System.Drawing.Point(170, 276)
        Me.BTOK.Name = "BTOK"
        Me.BTOK.Size = New System.Drawing.Size(65, 24)
        Me.BTOK.TabIndex = 161
        Me.BTOK.Text = "确认"
        '
        'BTBLNO
        '
        Me.BTBLNO.Location = New System.Drawing.Point(170, 176)
        Me.BTBLNO.Name = "BTBLNO"
        Me.BTBLNO.Size = New System.Drawing.Size(18, 18)
        Me.BTBLNO.TabIndex = 160
        Me.BTBLNO.Text = "…"
        '
        'TxtNO
        '
        Me.TxtNO.Location = New System.Drawing.Point(82, 64)
        Me.TxtNO.Name = "TxtNO"
        Me.TxtNO.Size = New System.Drawing.Size(106, 21)
        Me.TxtNO.TabIndex = 159
        Me.TxtNO.Text = ""
        '
        'CombCode_pack
        '
        Me.CombCode_pack.Enabled = False
        Me.CombCode_pack.Location = New System.Drawing.Point(280, 92)
        Me.CombCode_pack.Name = "CombCode_pack"
        Me.CombCode_pack.Size = New System.Drawing.Size(108, 20)
        Me.CombCode_pack.TabIndex = 158
        '
        'TxtAMOUNT
        '
        Me.TxtAMOUNT.Location = New System.Drawing.Point(280, 120)
        Me.TxtAMOUNT.Name = "TxtAMOUNT"
        Me.TxtAMOUNT.Size = New System.Drawing.Size(108, 21)
        Me.TxtAMOUNT.TabIndex = 157
        Me.TxtAMOUNT.Text = ""
        '
        'combcode_goods
        '
        Me.combcode_goods.Enabled = False
        Me.combcode_goods.Location = New System.Drawing.Point(280, 36)
        Me.combcode_goods.Name = "combcode_goods"
        Me.combcode_goods.Size = New System.Drawing.Size(108, 20)
        Me.combcode_goods.TabIndex = 156
        '
        'TxtMARK
        '
        Me.TxtMARK.Enabled = False
        Me.TxtMARK.Location = New System.Drawing.Point(280, 8)
        Me.TxtMARK.MaxLength = 30
        Me.TxtMARK.Name = "TxtMARK"
        Me.TxtMARK.Size = New System.Drawing.Size(108, 21)
        Me.TxtMARK.TabIndex = 155
        Me.TxtMARK.Text = ""
        '
        'txtBLNO
        '
        Me.txtBLNO.Enabled = False
        Me.txtBLNO.Location = New System.Drawing.Point(82, 174)
        Me.txtBLNO.MaxLength = 20
        Me.txtBLNO.Name = "txtBLNO"
        Me.txtBLNO.Size = New System.Drawing.Size(108, 21)
        Me.txtBLNO.TabIndex = 154
        Me.txtBLNO.Text = ""
        '
        'CombDAMAGED_REMARK
        '
        Me.CombDAMAGED_REMARK.Location = New System.Drawing.Point(280, 176)
        Me.CombDAMAGED_REMARK.Name = "CombDAMAGED_REMARK"
        Me.CombDAMAGED_REMARK.Size = New System.Drawing.Size(108, 20)
        Me.CombDAMAGED_REMARK.TabIndex = 153
        '
        'TxtDESCR
        '
        Me.TxtDESCR.Location = New System.Drawing.Point(82, 204)
        Me.TxtDESCR.MaxLength = 100
        Me.TxtDESCR.Multiline = True
        Me.TxtDESCR.Name = "TxtDESCR"
        Me.TxtDESCR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDESCR.Size = New System.Drawing.Size(306, 56)
        Me.TxtDESCR.TabIndex = 152
        Me.TxtDESCR.Text = ""
        '
        'CombTALLY_CLERK
        '
        Me.CombTALLY_CLERK.Location = New System.Drawing.Point(280, 148)
        Me.CombTALLY_CLERK.Name = "CombTALLY_CLERK"
        Me.CombTALLY_CLERK.Size = New System.Drawing.Size(108, 20)
        Me.CombTALLY_CLERK.TabIndex = 151
        '
        'TxtTime_from
        '
        Me.TxtTime_from.Location = New System.Drawing.Point(82, 120)
        Me.TxtTime_from.MaxLength = 4
        Me.TxtTime_from.Name = "TxtTime_from"
        Me.TxtTime_from.Size = New System.Drawing.Size(108, 21)
        Me.TxtTime_from.TabIndex = 150
        Me.TxtTime_from.Text = ""
        '
        'Txttime_to
        '
        Me.Txttime_to.Location = New System.Drawing.Point(82, 148)
        Me.Txttime_to.MaxLength = 4
        Me.Txttime_to.Name = "Txttime_to"
        Me.Txttime_to.Size = New System.Drawing.Size(108, 21)
        Me.Txttime_to.TabIndex = 149
        Me.Txttime_to.Text = ""
        '
        'DTPRECORD_DAY
        '
        Me.DTPRECORD_DAY.CustomFormat = "yyyy-MM-dd"
        Me.DTPRECORD_DAY.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPRECORD_DAY.Location = New System.Drawing.Point(82, 92)
        Me.DTPRECORD_DAY.Name = "DTPRECORD_DAY"
        Me.DTPRECORD_DAY.Size = New System.Drawing.Size(108, 21)
        Me.DTPRECORD_DAY.TabIndex = 148
        Me.DTPRECORD_DAY.Value = New Date(2004, 4, 28, 0, 0, 0, 0)
        '
        'CombHATCH_NO
        '
        Me.CombHATCH_NO.Location = New System.Drawing.Point(82, 36)
        Me.CombHATCH_NO.Name = "CombHATCH_NO"
        Me.CombHATCH_NO.Size = New System.Drawing.Size(108, 20)
        Me.CombHATCH_NO.TabIndex = 147
        '
        'CombBERTHNO
        '
        Me.CombBERTHNO.Location = New System.Drawing.Point(82, 10)
        Me.CombBERTHNO.Name = "CombBERTHNO"
        Me.CombBERTHNO.Size = New System.Drawing.Size(108, 20)
        Me.CombBERTHNO.TabIndex = 146
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(196, 148)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 22)
        Me.Label14.TabIndex = 145
        Me.Label14.Text = "理货员"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(196, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 22)
        Me.Label13.TabIndex = 144
        Me.Label13.Text = "情况编码"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(196, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 22)
        Me.Label12.TabIndex = 143
        Me.Label12.Text = "包装"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(196, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 22)
        Me.Label11.TabIndex = 142
        Me.Label11.Text = "件数"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(194, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 22)
        Me.Label10.TabIndex = 141
        Me.Label10.Text = "货名"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(194, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 22)
        Me.Label9.TabIndex = 140
        Me.Label9.Text = "标志"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(12, 174)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 22)
        Me.Label8.TabIndex = 139
        Me.Label8.Text = "提单号"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(12, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 22)
        Me.Label7.TabIndex = 138
        Me.Label7.Text = "情况描述"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 22)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "结束时间"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 22)
        Me.Label5.TabIndex = 136
        Me.Label5.Text = "开始时间"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 22)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "记录日期"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 22)
        Me.Label3.TabIndex = 134
        Me.Label3.Text = "记录单编号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 22)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "舱别"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 22)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "泊位号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmDAMAGE_work_ADD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(402, 315)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.TxtGOODS_CHA)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.BTADD)
        Me.Controls.Add(Me.BTQUIT)
        Me.Controls.Add(Me.BTOK)
        Me.Controls.Add(Me.BTBLNO)
        Me.Controls.Add(Me.TxtNO)
        Me.Controls.Add(Me.CombCode_pack)
        Me.Controls.Add(Me.TxtAMOUNT)
        Me.Controls.Add(Me.combcode_goods)
        Me.Controls.Add(Me.TxtMARK)
        Me.Controls.Add(Me.txtBLNO)
        Me.Controls.Add(Me.CombDAMAGED_REMARK)
        Me.Controls.Add(Me.TxtDESCR)
        Me.Controls.Add(Me.CombTALLY_CLERK)
        Me.Controls.Add(Me.TxtTime_from)
        Me.Controls.Add(Me.Txttime_to)
        Me.Controls.Add(Me.DTPRECORD_DAY)
        Me.Controls.Add(Me.CombHATCH_NO)
        Me.Controls.Add(Me.CombBERTHNO)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDAMAGE_work_ADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "工残记录_增加"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmDAMAGE_work_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        dw = Getdata("select CODE,GOODS from codegoods order by code ", dsgoods)
        combcode_goods.DataSource = dsgoods.Tables(0).DefaultView
        combcode_goods.DisplayMember = "GOODS"
        combcode_goods.ValueMember = "CODE"

        dw = Getdata("select code_pack,pack_cha+' '+isnull(pack_eng,' ') as pack from code_pack order by px ", dspack)
        CombCode_pack.DataSource = dspack.Tables(0).DefaultView
        CombCode_pack.DisplayMember = "pack"
        CombCode_pack.ValueMember = "code_pack"

        dw = Getdata("select CODE_BERTH,NAME_BERTH from CODE_BERTH where DEPT_CODE like '" & Trim(G_DeptCode) & "%'", dsberth)
        CombBERTHNO.DataSource = dsberth.Tables(0).DefaultView
        CombBERTHNO.DisplayMember = "NAME_BERTH"
        CombBERTHNO.ValueMember = "CODE_BERTH"

        dw = Getdata("select value,descr from codecabin", dshatch_no)
        CombHATCH_NO.DataSource = dshatch_no.Tables(0).DefaultView
        CombHATCH_NO.DisplayMember = "descr"
        CombHATCH_NO.ValueMember = "value"

        dw = Getdata("select work_no,name from TALLY_CLERK", dsclerk)
        CombTALLY_CLERK.DataSource = dsclerk.Tables(0).DefaultView
        CombTALLY_CLERK.DisplayMember = "name"
        CombTALLY_CLERK.ValueMember = "work_no"

        dw = Getdata("SELECT CODE_DAMAGE,NAME_DAMAGE FROM DAMAGE", DSDAMAGE)
        CombDAMAGED_REMARK.DataSource = DSDAMAGE.Tables(0).DefaultView
        CombDAMAGED_REMARK.DisplayMember = "NAME_DAMAGE"
        CombDAMAGED_REMARK.ValueMember = "CODE_DAMAGE"


        dw = Updatedata(sqlda, "select * from WORK_RECORD where WORK_RECORD_ID='" & ID & "'", ds)
        If ds.Tables(0).DefaultView.Count > 0 Then
            TxtTime_from.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("time_from"))), "", Trim(ds.Tables(0).Rows(0).Item("time_from")))
            Txttime_to.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("time_to"))), "", Trim(ds.Tables(0).Rows(0).Item("time_to")))
            CombHATCH_NO.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("hatch_no"))), "", Trim(ds.Tables(0).Rows(0).Item("hatch_no")))
            CombBERTHNO.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("BERTHNO"))), "", Trim(ds.Tables(0).Rows(0).Item("BERTHNO")))
            TxtDESCR.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("DESCR"))), "", Trim(ds.Tables(0).Rows(0).Item("DESCR")))
            DTPRECORD_DAY.Value = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("RECORD_DAY"))), Now, Trim(ds.Tables(0).Rows(0).Item("RECORD_DAY")))
            CombDAMAGED_REMARK.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("DAMAGED_REMARK"))), "", Trim(ds.Tables(0).Rows(0).Item("DAMAGED_REMARK")))
            TxtGOODS_CHA.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("GOODS_CHA"))), "", Trim(ds.Tables(0).Rows(0).Item("GOODS_CHA")))
            'Call clerk()
            CombTALLY_CLERK.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk"))), "00", Trim(ds.Tables(0).Rows(0).Item("tally_clerk")))
        Else
            CombTALLY_CLERK.SelectedValue = ""
        End If
        TxtAMOUNT.Text = "0"
        CombDAMAGED_REMARK.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("DAMAGED_REMARK"))), "02", Trim(ds.Tables(0).Rows(0).Item("DAMAGED_REMARK")))


        Exit Sub
Err:
        Resume Next
    End Sub
    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub
    Private Sub clerk()
        Try

            dw = Getdata("exec sp_waitfor_clerk '" & G_DeptCode & "','" & Ship_ID & "','" & TxtTime_from.Text & "','" & DTPRECORD_DAY.Value & "'", dsclerk)
            CombTALLY_CLERK.DataSource = dsclerk.Tables(0).DefaultView
            CombTALLY_CLERK.DisplayMember = "name"
            CombTALLY_CLERK.ValueMember = "work_no"

        Catch ex As System.Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub DTPRECORD_DAY_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPRECORD_DAY.Leave
        'Call clerk()
        CombTALLY_CLERK.SelectedValue = ""
    End Sub

    Private Sub TxtTime_from_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTime_from.Leave

        'Call clerk()
        CombTALLY_CLERK.SelectedValue = ""
    End Sub
    Private Sub CombHATCH_NO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CombHATCH_NO.Leave
        Dim DSSELECT As New DataSet()
        Try
            If Len(Trim(CombHATCH_NO.Text)) > 0 Then
                If Mid(Trim(CombHATCH_NO.Text), 1, 1) = "0" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "1" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "2" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "3" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "4" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "5" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "6" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "7" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "8" Or Mid(Trim(CombHATCH_NO.Text), 1, 1) = "9" Then
                    If Len(Trim(CombHATCH_NO.Text)) = 1 Then
                        CombHATCH_NO.Text = "0" + CType(Trim(CombHATCH_NO.Text), String)
                    End If
                    dw = Getdata("SELECT * FROM CODECABIN WHERE VALUE='" & Trim(CombHATCH_NO.Text) & "'  or DESCR='" & Trim(CombHATCH_NO.Text) & "'", DSSELECT)
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


    Private Sub BTBLNO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTBLNO.Click
        dw = Getdata("select * from VIEW_WORK_RECORD_C1DBG where ship_id='" & Ship_ID & "'", dsBLNO)
        If dsBLNO.Tables(0).Rows.Count > 0 Then

            C1DBG.DataSource = dsBLNO.Tables(0).DefaultView

            Me.C1DBG.Refresh()
            Me.C1DBG.Splits(0).DisplayColumns.Item(0).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item(1).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item(2).Visible = False


            Me.C1DBG.Columns.Item(3).Caption = "提单号"
            Me.C1DBG.Columns.Item(4).Caption = "标志"
            Me.C1DBG.Columns.Item("CODE_GOODS_CHA").Caption = "货类"
            Me.C1DBG.Columns.Item("GOODS_CHA").Caption = "货物中文描述"
            Me.C1DBG.Columns.Item("PACK_CHA").Caption = "包装"
            Me.C1DBG.Refresh()
            Me.C1DBG.Visible = True

        Else
            MsgBox("没有该航次的舱单记录！")
        End If

    End Sub

    Private Sub BTOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOK.Click
        Try
            If Len(Trim(TxtTime_from.Text)) = 4 And CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) < 24 And CType(Mid(Trim(TxtTime_from.Text), 3, 2), Integer) < 60 Then
                If Len(Trim(Txttime_to.Text)) = 4 And CType(Mid(Trim(Txttime_to.Text), 1, 2), Integer) < 24 And CType(Mid(Trim(Txttime_to.Text), 3, 2), Integer) < 60 Then
                    If Len(Trim(DTPRECORD_DAY.Value)) > 0 Then
                        If Len(Trim(TxtNO.Text)) > 0 Then


                            Dim row As DataRow
                            row = ds.Tables(0).NewRow
                            row("SHIP_ID") = Trim(Ship_ID)
                            row("berthno") = IIf(Len(Trim(CombBERTHNO.SelectedValue)) > 0, Trim(CombBERTHNO.SelectedValue), "")
                            row("HATCH_NO") = IIf(Len(Trim(CombHATCH_NO.SelectedValue)) > 0, Trim(CombHATCH_NO.SelectedValue), "")
                            row("RECORD_DAY") = DTPRECORD_DAY.Value
                            row("time_from") = TxtTime_from.Text
                            row("time_to") = Txttime_to.Text
                            row("TALLY_CLERK") = IIf(Len(Trim(CombTALLY_CLERK.SelectedValue)) > 0, Trim(CombTALLY_CLERK.SelectedValue), "00")
                            row("no") = TxtNO.Text
                            row("BLNO") = IIf(Len(Trim(txtBLNO.Text)) > 0, Trim(txtBLNO.Text), "")
                            row("MARK") = IIf(Len(Trim(TxtMARK.Text)) > 0, Trim(TxtMARK.Text), "")
                            row("Code_Goods") = IIf(Len(Trim(combcode_goods.SelectedValue)) > 0, combcode_goods.SelectedValue, "0000")
                            row("code_pack") = IIf(Len(Trim(CombCode_pack.SelectedValue)) > 0, CombCode_pack.SelectedValue, "000")
                            row("DAMAGED_REMARK") = "02"
                            row("AMOUNT") = IIf(Len(Trim(TxtAMOUNT.Text)) > 0, Trim(TxtAMOUNT.Text), 0)
                            row("goods_cha") = IIf(Len(Trim(TxtGOODS_CHA.Text)) > 0, Trim(TxtGOODS_CHA.Text), "")
                            row("DESCR") = IIf(Len(Trim(TxtDESCR.Text)) > 0, Trim(TxtDESCR.Text), "")
                            row("USER_NAME") = Trim(G_User)
                            ds.Tables(0).Rows.Add(row)
                            sqlda.Update(ds)
                            Call BTQUIT_Click(sender, e)

                        Else
                            MsgBox("记录编号不能为空！")
                        End If
                    Else
                        MsgBox("记录日期不能为空！")
                    End If

                Else
                    MsgBox("结束时间填写错误！请填写4位数字，不加冒号。")
                End If
            Else
                MsgBox("开始时间填写错误！请填写4位数字，不加冒号。")
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub BTADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTADD.Click
        TxtTime_from.Text = ""
        Txttime_to.Text = ""
        TxtNO.Text = ""
        TxtAMOUNT.Text = "0"
        TxtDESCR.Text = ""
        txtBLNO.Text = ""
        TxtMARK.Text = ""
        TxtGOODS_CHA.Text = ""

    End Sub


    Private Sub C1DBG_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1DBG.DoubleClick
        txtBLNO.Text = Me.C1DBG.Columns.Item("blno").Text
        TxtMARK.Text = Me.C1DBG.Columns.Item("mark").Text
        combcode_goods.SelectedValue = Me.C1DBG.Columns.Item("code_cargo").Text
        CombCode_pack.SelectedValue = Me.C1DBG.Columns.Item("code_pack").Text
        TxtGOODS_CHA.Text = Me.C1DBG.Columns.Item("goods_cha").Text
        Me.C1DBG.Visible = False
        TxtAMOUNT.Focus()
    End Sub
    Private Sub CombBERTHNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombBERTHNO.KeyPress
        If e.KeyChar = Chr(13) Then
            CombHATCH_NO.Focus()
        End If
    End Sub
    Private Sub CombHATCH_NO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombHATCH_NO.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtNO.Focus()
        End If
    End Sub
    Private Sub TxtNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNO.KeyPress
        If e.KeyChar = Chr(13) Then
            DTPRECORD_DAY.Focus()
        End If
    End Sub
    Private Sub DTPRECORD_DAY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DTPRECORD_DAY.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtTime_from.Focus()
        End If
    End Sub
    Private Sub TxtTime_from_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTime_from.KeyPress
        If e.KeyChar = Chr(13) Then
            Txttime_to.Focus()
        End If
    End Sub
    Private Sub TxtTime_to_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txttime_to.KeyPress
        If e.KeyChar = Chr(13) Then
            BTBLNO.Focus()
        End If
    End Sub
    Private Sub TxtAMOUNT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAMOUNT.KeyPress
        If e.KeyChar = Chr(13) Then
            CombTALLY_CLERK.Focus()
        End If
    End Sub
    Private Sub CombTALLY_CLERK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombTALLY_CLERK.KeyPress
        If e.KeyChar = Chr(13) Then
            CombDAMAGED_REMARK.Focus()
        End If
    End Sub
    Private Sub CombDAMAGED_REMARK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombDAMAGED_REMARK.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtDESCR.Focus()
        End If
    End Sub
    Private Sub TxtDESCR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDESCR.KeyPress
        If e.KeyChar = Chr(13) Then
            BTOK.Focus()
        End If
    End Sub

    Private Sub combcode_goods_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles combcode_goods.Leave
        Dim dsss As New DataSet
        If combcode_goods.Text.Trim().Length() > 0 Then
            Getdata("select * from CODEGOODS where code like '%" & combcode_goods.Text.Trim() & "%' or goods like '%" & combcode_goods.Text.Trim() & "%' or goods_eng like '%" & combcode_goods.Text.Trim() & "%' or goods_short like '%" & combcode_goods.Text.Trim() & "%'", dsss)
            If dsss.Tables(0).DefaultView.Count > 0 Then
                combcode_goods.SelectedValue = dsss.Tables(0).Rows(0)("code")
                'TxtGOODS_ENG.Text = IIf(IsDBNull(dsss.Tables(0).Rows(0)("Goods_Eng")), "", dsss.Tables(0).Rows(0)("Goods_Eng"))
                TxtGOODS_CHA.Text = combcode_goods.Text.Trim()
            End If

        End If
    End Sub

    Private Sub CombTALLY_CLERK_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CombTALLY_CLERK.Leave
        Dim str As String

        If CombTALLY_CLERK.Text.Trim().Length > 0 Then
            If (Asc(Mid(CombTALLY_CLERK.Text.Trim(), 1, 1)) >= Asc("a") And Asc(Mid(CombTALLY_CLERK.Text.Trim(), 1, 1)) <= Asc("z")) Or (Asc(Mid(CombTALLY_CLERK.Text.Trim(), 1, 1)) >= Asc("A") And Asc(Mid(CombTALLY_CLERK.Text.Trim(), 1, 1)) <= Asc("Z")) Then
                dss.Reset()
                str = "SELECT NAME, WORK_NO,Tally_Short FROM TALLY_CLERK where Tally_Short='" & CombTALLY_CLERK.Text.Trim() & "'  order by NAME"
                dw = Getdata(str, dss)
                If dw.Count > 0 Then
                    'CombTALLY_CLERK1.DataSource = dsclerk.Tables(0).DefaultView
                    'CombTALLY_CLERK1.DisplayMember = "NAME"
                    'CombTALLY_CLERK1.ValueMember = "WORK_NO"
                    CombTALLY_CLERK.SelectedValue = dss.Tables(0).Rows(0)("WORK_NO")
                End If
            End If
        End If
    End Sub
End Class
