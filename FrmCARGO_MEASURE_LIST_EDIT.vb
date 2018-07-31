Imports TALLY.DBControl
Public Class FrmCARGO_MEASURE_LIST_EDIT
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dw As New DataView()
    Dim dsgoods As New DataSet()
    Dim dsclerk As New DataSet()
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
    Friend WithEvents BTBLNO As System.Windows.Forms.Button
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents BTOK As System.Windows.Forms.Button
    Friend WithEvents DTPMEASUREDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtREMARK As System.Windows.Forms.TextBox
    Friend WithEvents TxtWORK_PLACE As System.Windows.Forms.TextBox
    Friend WithEvents TxtNO As System.Windows.Forms.TextBox
    Friend WithEvents CombTALLY_CLERK As System.Windows.Forms.ComboBox
    Friend WithEvents combcode_goods As System.Windows.Forms.ComboBox
    Friend WithEvents TxtMARK As System.Windows.Forms.TextBox
    Friend WithEvents txtBLNO As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtTOTAL_VOLUME As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtHIGH As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtWIDTH As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtPIECE_VOLUME As System.Windows.Forms.TextBox
    Friend WithEvents TxtLONG As System.Windows.Forms.TextBox
    Friend WithEvents TxtAMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtGOODS_CHA As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents txtteam_no As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCARGO_MEASURE_LIST_EDIT))
        Me.BTBLNO = New System.Windows.Forms.Button
        Me.BTQUIT = New System.Windows.Forms.Button
        Me.BTOK = New System.Windows.Forms.Button
        Me.DTPMEASUREDATE = New System.Windows.Forms.DateTimePicker
        Me.TxtREMARK = New System.Windows.Forms.TextBox
        Me.TxtWORK_PLACE = New System.Windows.Forms.TextBox
        Me.TxtNO = New System.Windows.Forms.TextBox
        Me.CombTALLY_CLERK = New System.Windows.Forms.ComboBox
        Me.combcode_goods = New System.Windows.Forms.ComboBox
        Me.TxtMARK = New System.Windows.Forms.TextBox
        Me.txtBLNO = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.TxtTOTAL_VOLUME = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TxtHIGH = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TxtWIDTH = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtPIECE_VOLUME = New System.Windows.Forms.TextBox
        Me.TxtLONG = New System.Windows.Forms.TextBox
        Me.TxtAMOUNT = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtGOODS_CHA = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.txtteam_no = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTBLNO
        '
        Me.BTBLNO.Location = New System.Drawing.Point(204, 124)
        Me.BTBLNO.Name = "BTBLNO"
        Me.BTBLNO.Size = New System.Drawing.Size(18, 18)
        Me.BTBLNO.TabIndex = 134
        Me.BTBLNO.Text = "…"
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(216, 312)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 132
        Me.BTQUIT.Text = "取消"
        '
        'BTOK
        '
        Me.BTOK.Location = New System.Drawing.Point(144, 312)
        Me.BTOK.Name = "BTOK"
        Me.BTOK.Size = New System.Drawing.Size(65, 24)
        Me.BTOK.TabIndex = 131
        Me.BTOK.Text = "确认"
        '
        'DTPMEASUREDATE
        '
        Me.DTPMEASUREDATE.CustomFormat = "yyyy-MM-dd"
        Me.DTPMEASUREDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPMEASUREDATE.Location = New System.Drawing.Point(96, 40)
        Me.DTPMEASUREDATE.Name = "DTPMEASUREDATE"
        Me.DTPMEASUREDATE.Size = New System.Drawing.Size(128, 21)
        Me.DTPMEASUREDATE.TabIndex = 129
        Me.DTPMEASUREDATE.Value = New Date(2004, 4, 28, 0, 0, 0, 0)
        '
        'TxtREMARK
        '
        Me.TxtREMARK.Location = New System.Drawing.Point(96, 228)
        Me.TxtREMARK.MaxLength = 100
        Me.TxtREMARK.Multiline = True
        Me.TxtREMARK.Name = "TxtREMARK"
        Me.TxtREMARK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtREMARK.Size = New System.Drawing.Size(320, 54)
        Me.TxtREMARK.TabIndex = 126
        Me.TxtREMARK.Text = ""
        '
        'TxtWORK_PLACE
        '
        Me.TxtWORK_PLACE.Location = New System.Drawing.Point(96, 68)
        Me.TxtWORK_PLACE.MaxLength = 30
        Me.TxtWORK_PLACE.Name = "TxtWORK_PLACE"
        Me.TxtWORK_PLACE.Size = New System.Drawing.Size(128, 21)
        Me.TxtWORK_PLACE.TabIndex = 125
        Me.TxtWORK_PLACE.Text = ""
        '
        'TxtNO
        '
        Me.TxtNO.Location = New System.Drawing.Point(96, 12)
        Me.TxtNO.MaxLength = 10
        Me.TxtNO.Name = "TxtNO"
        Me.TxtNO.Size = New System.Drawing.Size(128, 21)
        Me.TxtNO.TabIndex = 124
        Me.TxtNO.Text = ""
        '
        'CombTALLY_CLERK
        '
        Me.CombTALLY_CLERK.Location = New System.Drawing.Point(286, 182)
        Me.CombTALLY_CLERK.Name = "CombTALLY_CLERK"
        Me.CombTALLY_CLERK.Size = New System.Drawing.Size(128, 20)
        Me.CombTALLY_CLERK.TabIndex = 123
        '
        'combcode_goods
        '
        Me.combcode_goods.Location = New System.Drawing.Point(96, 176)
        Me.combcode_goods.Name = "combcode_goods"
        Me.combcode_goods.Size = New System.Drawing.Size(128, 20)
        Me.combcode_goods.TabIndex = 121
        '
        'TxtMARK
        '
        Me.TxtMARK.Location = New System.Drawing.Point(96, 150)
        Me.TxtMARK.MaxLength = 30
        Me.TxtMARK.Name = "TxtMARK"
        Me.TxtMARK.Size = New System.Drawing.Size(128, 21)
        Me.TxtMARK.TabIndex = 120
        Me.TxtMARK.Text = ""
        '
        'txtBLNO
        '
        Me.txtBLNO.Location = New System.Drawing.Point(96, 122)
        Me.txtBLNO.MaxLength = 20
        Me.txtBLNO.Name = "txtBLNO"
        Me.txtBLNO.Size = New System.Drawing.Size(128, 21)
        Me.txtBLNO.TabIndex = 119
        Me.txtBLNO.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(226, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 22)
        Me.Label7.TabIndex = 118
        Me.Label7.Text = "丈量人员"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 22)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "备注"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 22)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "丈量地点"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 22)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "货名"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 22)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "标志"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 22)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "提单号"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 22)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "丈量日期"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 22)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "丈量单编号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label19.Location = New System.Drawing.Point(368, 152)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 22)
        Me.Label19.TabIndex = 152
        Me.Label19.Text = "立方米"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label18.Location = New System.Drawing.Point(368, 96)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 22)
        Me.Label18.TabIndex = 151
        Me.Label18.Text = "立方米"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label17.Location = New System.Drawing.Point(394, 40)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(18, 22)
        Me.Label17.TabIndex = 150
        Me.Label17.Text = "米"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label16.Location = New System.Drawing.Point(394, 68)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 22)
        Me.Label16.TabIndex = 149
        Me.Label16.Text = "米"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label15.Location = New System.Drawing.Point(394, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(18, 22)
        Me.Label15.TabIndex = 148
        Me.Label15.Text = "米"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTOTAL_VOLUME
        '
        Me.TxtTOTAL_VOLUME.Enabled = False
        Me.TxtTOTAL_VOLUME.Location = New System.Drawing.Point(286, 152)
        Me.TxtTOTAL_VOLUME.Name = "TxtTOTAL_VOLUME"
        Me.TxtTOTAL_VOLUME.Size = New System.Drawing.Size(82, 21)
        Me.TxtTOTAL_VOLUME.TabIndex = 147
        Me.TxtTOTAL_VOLUME.Text = ""
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(226, 152)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 22)
        Me.Label14.TabIndex = 146
        Me.Label14.Text = "总体积"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtHIGH
        '
        Me.TxtHIGH.Location = New System.Drawing.Point(286, 68)
        Me.TxtHIGH.Name = "TxtHIGH"
        Me.TxtHIGH.Size = New System.Drawing.Size(108, 21)
        Me.TxtHIGH.TabIndex = 145
        Me.TxtHIGH.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(226, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 22)
        Me.Label13.TabIndex = 144
        Me.Label13.Text = "高"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtWIDTH
        '
        Me.TxtWIDTH.Location = New System.Drawing.Point(286, 40)
        Me.TxtWIDTH.Name = "TxtWIDTH"
        Me.TxtWIDTH.Size = New System.Drawing.Size(108, 21)
        Me.TxtWIDTH.TabIndex = 143
        Me.TxtWIDTH.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(226, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 22)
        Me.Label12.TabIndex = 142
        Me.Label12.Text = "宽"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtPIECE_VOLUME
        '
        Me.TxtPIECE_VOLUME.Enabled = False
        Me.TxtPIECE_VOLUME.Location = New System.Drawing.Point(286, 96)
        Me.TxtPIECE_VOLUME.Name = "TxtPIECE_VOLUME"
        Me.TxtPIECE_VOLUME.Size = New System.Drawing.Size(82, 21)
        Me.TxtPIECE_VOLUME.TabIndex = 141
        Me.TxtPIECE_VOLUME.Text = ""
        '
        'TxtLONG
        '
        Me.TxtLONG.Location = New System.Drawing.Point(286, 12)
        Me.TxtLONG.Name = "TxtLONG"
        Me.TxtLONG.Size = New System.Drawing.Size(108, 21)
        Me.TxtLONG.TabIndex = 140
        Me.TxtLONG.Text = ""
        '
        'TxtAMOUNT
        '
        Me.TxtAMOUNT.Location = New System.Drawing.Point(286, 124)
        Me.TxtAMOUNT.Name = "TxtAMOUNT"
        Me.TxtAMOUNT.Size = New System.Drawing.Size(126, 21)
        Me.TxtAMOUNT.TabIndex = 139
        Me.TxtAMOUNT.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(226, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 22)
        Me.Label5.TabIndex = 138
        Me.Label5.Text = "单件体积"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(226, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 22)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "长"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(226, 124)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 22)
        Me.Label11.TabIndex = 136
        Me.Label11.Text = "件数"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtGOODS_CHA
        '
        Me.TxtGOODS_CHA.Location = New System.Drawing.Point(96, 202)
        Me.TxtGOODS_CHA.MaxLength = 30
        Me.TxtGOODS_CHA.Name = "TxtGOODS_CHA"
        Me.TxtGOODS_CHA.Size = New System.Drawing.Size(128, 21)
        Me.TxtGOODS_CHA.TabIndex = 155
        Me.TxtGOODS_CHA.Text = ""
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(8, 202)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 22)
        Me.Label20.TabIndex = 154
        Me.Label20.Text = "货物中文描述"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1DBG
        '
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(2, 12)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.Size = New System.Drawing.Size(422, 334)
        Me.C1DBG.TabIndex = 156
        Me.C1DBG.Text = "C1TrueDBGrid1"
        Me.C1DBG.Visible = False
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style14{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" & _
        "tyle9{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Alig" & _
        "nVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><Height>330</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorSty" & _
        "le parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><F" & _
        "ilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=" & _
        """Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Headi" & _
        "ng"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><Inacti" & _
        "veStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9""" & _
        " /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle pa" & _
        "rent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0" & _
        ", 0, 418, 330</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderS" & _
        "tyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""" & _
        "Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Foot" & _
        "er"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactiv" & _
        "e"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /" & _
        "><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" " & _
        "/><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelecto" & _
        "r"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" " & _
        "/></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None" & _
        "</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 418, 330</" & _
        "ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle " & _
        "parent="""" me=""Style15"" /></Blob>"
        '
        'txtteam_no
        '
        Me.txtteam_no.Location = New System.Drawing.Point(96, 96)
        Me.txtteam_no.MaxLength = 5
        Me.txtteam_no.Name = "txtteam_no"
        Me.txtteam_no.Size = New System.Drawing.Size(128, 21)
        Me.txtteam_no.TabIndex = 158
        Me.txtteam_no.Text = ""
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(8, 98)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 22)
        Me.Label21.TabIndex = 157
        Me.Label21.Text = "工班号"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCARGO_MEASURE_LIST_EDIT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(426, 351)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.BTBLNO)
        Me.Controls.Add(Me.txtteam_no)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.TxtGOODS_CHA)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TxtTOTAL_VOLUME)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtHIGH)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtWIDTH)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtPIECE_VOLUME)
        Me.Controls.Add(Me.TxtLONG)
        Me.Controls.Add(Me.TxtAMOUNT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BTQUIT)
        Me.Controls.Add(Me.BTOK)
        Me.Controls.Add(Me.DTPMEASUREDATE)
        Me.Controls.Add(Me.TxtREMARK)
        Me.Controls.Add(Me.TxtWORK_PLACE)
        Me.Controls.Add(Me.TxtNO)
        Me.Controls.Add(Me.CombTALLY_CLERK)
        Me.Controls.Add(Me.combcode_goods)
        Me.Controls.Add(Me.TxtMARK)
        Me.Controls.Add(Me.txtBLNO)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCARGO_MEASURE_LIST_EDIT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "丈量单_编辑"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCARGO_MEASURE_LIST_EDIT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        dw = Getdata("select CODE,GOODS from codegoods order by code ", dsgoods)
        combcode_goods.DataSource = dsgoods.Tables(0).DefaultView
        combcode_goods.DisplayMember = "GOODS"
        combcode_goods.ValueMember = "CODE"

        dw = Getdata("select work_no,name from TALLY_CLERK order by name", dsclerk)
        CombTALLY_CLERK.DataSource = dsclerk.Tables(0).DefaultView
        CombTALLY_CLERK.DisplayMember = "name"
        CombTALLY_CLERK.ValueMember = "work_no"

        dw = Updatedata(sqlda, "select * from CARGO_MEASURE_LIST where MEASURE_ID='" & ID & "'", ds)
        If ds.Tables(0).DefaultView.Count > 0 Then
            TxtWORK_PLACE.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("WORK_PLACE"))), "", Trim(ds.Tables(0).Rows(0).Item("WORK_PLACE")))
            TxtLONG.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("LONG"))), "", Trim(ds.Tables(0).Rows(0).Item("LONG")))
            TxtWIDTH.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("WIDTH"))), "", Trim(ds.Tables(0).Rows(0).Item("WIDTH")))
            TxtHIGH.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("HIGH"))), "", Trim(ds.Tables(0).Rows(0).Item("HIGH")))
            TxtTOTAL_VOLUME.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("TOTAL_VOLUME"))), "", Trim(ds.Tables(0).Rows(0).Item("TOTAL_VOLUME")))
            TxtPIECE_VOLUME.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("PIECE_VOLUME"))), "", Trim(ds.Tables(0).Rows(0).Item("PIECE_VOLUME")))
            TxtREMARK.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("remark"))), "", Trim(ds.Tables(0).Rows(0).Item("remark")))
            DTPMEASUREDATE.Value = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("MEASUREDATE"))), Now, Trim(ds.Tables(0).Rows(0).Item("MEASUREDATE")))
            'Call clerk()
            CombTALLY_CLERK.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("MEASURE_WORKER"))), "00", Trim(ds.Tables(0).Rows(0).Item("MEASURE_WORKER")))
            TxtNO.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("NO"))), "", Trim(ds.Tables(0).Rows(0).Item("NO")))
            txtBLNO.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("BLNO"))), "0", Trim(ds.Tables(0).Rows(0).Item("BLNO")))
            TxtMARK.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("MARK"))), "0", Trim(ds.Tables(0).Rows(0).Item("MARK")))
            combcode_goods.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("code_goods"))), "", Trim(ds.Tables(0).Rows(0).Item("code_goods")))
            TxtGOODS_CHA.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("GOODS_CHA"))), "", Trim(ds.Tables(0).Rows(0).Item("GOODS_CHA")))
            TxtAMOUNT.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("AMOUNT"))), "0", Trim(ds.Tables(0).Rows(0).Item("AMOUNT")))
            txtteam_no.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("team_no"))), "", Trim(ds.Tables(0).Rows(0).Item("team_no")))
        End If

        Exit Sub
Err:
        Resume Next
    End Sub
    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub
    Private Sub clerk()
        Try

            dw = Getdata("exec sp_measure_clerk '" & G_DeptCode & "','" & Ship_ID & "','" & DTPMEASUREDATE.Value & "'", dsclerk)
            CombTALLY_CLERK.DataSource = dsclerk.Tables(0).DefaultView
            CombTALLY_CLERK.DisplayMember = "name"
            CombTALLY_CLERK.ValueMember = "work_no"

        Catch ex As System.Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub DTPMEASUREDATE_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTPMEASUREDATE.Leave
        'Call clerk()
        'CombTALLY_CLERK.SelectedValue = ""
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
    Private Sub TxtLONG_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtLONG.TextChanged
        Call VOLUME()
    End Sub
    Private Sub Txtwidth_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtWIDTH.TextChanged
        Call VOLUME()
    End Sub
    Private Sub Txthigh_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtHIGH.TextChanged
        Call VOLUME()
    End Sub
    Private Sub Txtamount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtAMOUNT.TextChanged
        Call VOLUME()
    End Sub
    Private Sub VOLUME()
        Try
            If Len(Trim(TxtLONG.Text)) > 0 Then
                If Len(Trim(TxtWIDTH.Text)) > 0 Then
                    If Len(Trim(TxtHIGH.Text)) > 0 Then
                        If Len(Trim(TxtAMOUNT.Text)) > 0 Then
                            TxtPIECE_VOLUME.Text = Trim(TxtLONG.Text) * Trim(TxtWIDTH.Text) * Trim(TxtHIGH.Text)
                            TxtTOTAL_VOLUME.Text = Trim(TxtPIECE_VOLUME.Text) * TxtAMOUNT.Text
                        End If
                    End If
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub C1DBG_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1DBG.DoubleClick
        txtBLNO.Text = Me.C1DBG.Columns.Item("blno").Text
        TxtMARK.Text = Me.C1DBG.Columns.Item("mark").Text
        combcode_goods.SelectedValue = Me.C1DBG.Columns.Item("code_cargo").Text
        TxtGOODS_CHA.Text = Me.C1DBG.Columns.Item("goods_cha").Text
        Me.C1DBG.Visible = False
        TxtAMOUNT.Focus()
    End Sub

    Private Sub BTOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOK.Click
        Try

            If Len(Trim(DTPMEASUREDATE.Value)) > 0 Then
                If Len(Trim(TxtNO.Text)) > 0 Then
                    If Len(Trim(txtBLNO.Text)) > 0 Then
                        If Len(Trim(TxtMARK.Text)) > 0 Then
                            If Len(Trim(combcode_goods.SelectedValue)) > 0 Then
                                If CombTALLY_CLERK.Text.Trim().Length() > 0 Then
                                    If MsgBox("确认要修改吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                                        OperateHistory(G_DeptName, Now, G_User, "编辑", "work_record", ID, "work_record_id")
                                        ds.Tables(0).Rows(0).Item("WORK_PLACE") = Trim(TxtWORK_PLACE.Text)
                                        ds.Tables(0).Rows(0).Item("LONG") = IIf(Len(Trim(TxtLONG.Text)) > 0, Trim(TxtLONG.Text), 0)
                                        ds.Tables(0).Rows(0).Item("WIDTH") = IIf(Len(Trim(TxtWIDTH.Text)) > 0, Trim(TxtWIDTH.Text), 0)
                                        ds.Tables(0).Rows(0).Item("HIGH") = IIf(Len(Trim(TxtHIGH.Text)) > 0, Trim(TxtHIGH.Text), 0)
                                        ds.Tables(0).Rows(0).Item("TOTAL_VOLUME") = IIf(Len(Trim(TxtTOTAL_VOLUME.Text)) > 0, Trim(TxtTOTAL_VOLUME.Text), 0)
                                        ds.Tables(0).Rows(0).Item("PIECE_VOLUME") = IIf(Len(Trim(TxtPIECE_VOLUME.Text)) > 0, Trim(TxtPIECE_VOLUME.Text), 0)

                                        ds.Tables(0).Rows(0).Item("MEASURE_WORKER") = IIf(Len(Trim(CombTALLY_CLERK.SelectedValue)) > 0, Trim(CombTALLY_CLERK.SelectedValue), "00")
                                        ds.Tables(0).Rows(0).Item("USER_NAME") = Trim(G_User)
                                        ds.Tables(0).Rows(0).Item("MEASUREDATE") = DTPMEASUREDATE.Value
                                        ds.Tables(0).Rows(0).Item("NO") = Trim(TxtNO.Text)
                                        ds.Tables(0).Rows(0).Item("team_no") = Trim(txtteam_no.Text)
                                        ds.Tables(0).Rows(0).Item("BLNO") = Trim(txtBLNO.Text)
                                        ds.Tables(0).Rows(0).Item("MARK") = Trim(TxtMARK.Text)
                                        ds.Tables(0).Rows(0).Item("code_goods") = combcode_goods.SelectedValue
                                        ds.Tables(0).Rows(0).Item("goods_cha") = IIf(Len(Trim(TxtGOODS_CHA.Text)) > 0, Trim(TxtGOODS_CHA.Text), "")
                                        ds.Tables(0).Rows(0).Item("AMOUNT") = IIf(Len(Trim(TxtAMOUNT.Text)) > 0, Trim(TxtAMOUNT.Text), 0)
                                        ds.Tables(0).Rows(0).Item("REMARK") = Trim(TxtREMARK.Text)
                                        sqlda.Update(ds)

                                        Call BTQUIT_Click(sender, e)
                                   
                                    End If
                                Else
                                    MsgBox("理货员不能为空。")
                                End If
                            Else
                                    MsgBox("货名不能为空！")
                            End If
                        Else
                                MsgBox("标志不能为空！")
                        End If
                    Else
                            MsgBox("提单号不能为空！")
                    End If
                Else
                        MsgBox("丈量单编号不能为空！")
                End If
            Else
                    MsgBox("丈量日期不能为空！")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub TxtNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNO.KeyPress
        If e.KeyChar = Chr(13) Then
            DTPMEASUREDATE.Focus()
        End If
    End Sub
    Private Sub DTPMEASUREDATE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DTPMEASUREDATE.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtWORK_PLACE.Focus()
        End If
    End Sub
    Private Sub TxtWORK_PLACE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtWORK_PLACE.KeyPress
        If e.KeyChar = Chr(13) Then
            txtBLNO.Focus()
        End If
    End Sub
    Private Sub TxtBLNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBLNO.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtMARK.Focus()
        End If
    End Sub
    Private Sub TxtMARK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMARK.KeyPress
        If e.KeyChar = Chr(13) Then
            combcode_goods.Focus()
        End If
    End Sub
    Private Sub CombCODE_GOODS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles combcode_goods.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtLONG.Focus()
        End If
    End Sub
    Private Sub TxtLONG_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLONG.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtWIDTH.Focus()
        End If
    End Sub
    Private Sub TxtWIDTH_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtWIDTH.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtHIGH.Focus()
        End If
    End Sub
    Private Sub TxtHIGH_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtHIGH.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtAMOUNT.Focus()
        End If
    End Sub
    Private Sub TxtAMOUNT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAMOUNT.KeyPress
        If e.KeyChar = Chr(13) Then
            CombTALLY_CLERK.Focus()
        End If
    End Sub
    Private Sub CombTALLY_CLERK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombTALLY_CLERK.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtREMARK.Focus()
        End If
    End Sub
    Private Sub TxtREMARK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtREMARK.KeyPress
        If e.KeyChar = Chr(13) Then
            BTOK.Focus()
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
End Class
