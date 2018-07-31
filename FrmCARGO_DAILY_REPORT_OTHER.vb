Imports TALLY.DBControl
Imports Microsoft.VisualBasic

Public Class FrmCARGO_DAILY_REPORT_OTHER
    Inherits System.Windows.Forms.Form
    Dim dw As New DataView()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dswork_time As New DataSet
    Dim dschief As New DataSet
    Dim strrep As String
    Dim dsrep As New DataSet
    Dim dwrep As New DataView
    Dim sqldarep As New SqlClient.SqlDataAdapter
    Dim rep1 As String
    Dim rep2 As String

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
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents BTOK As System.Windows.Forms.Button
    Friend WithEvents DTPdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents CombWORK_TIME As System.Windows.Forms.ComboBox
    Friend WithEvents CombCHIEF_TALLY As System.Windows.Forms.ComboBox
    Friend WithEvents RBchina As System.Windows.Forms.RadioButton
    Friend WithEvents RBeng As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btexit As System.Windows.Forms.Button
    Friend WithEvents btsave As System.Windows.Forms.Button
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cmbflag As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCARGO_DAILY_REPORT_OTHER))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DTPdate = New System.Windows.Forms.DateTimePicker
        Me.CombWORK_TIME = New System.Windows.Forms.ComboBox
        Me.CombCHIEF_TALLY = New System.Windows.Forms.ComboBox
        Me.BTQUIT = New System.Windows.Forms.Button
        Me.BTOK = New System.Windows.Forms.Button
        Me.RBchina = New System.Windows.Forms.RadioButton
        Me.RBeng = New System.Windows.Forms.RadioButton
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btexit = New System.Windows.Forms.Button
        Me.btsave = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Cmbflag = New System.Windows.Forms.ComboBox
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(64, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "日报日期"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(64, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "班次"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(304, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "理货组长"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTPdate
        '
        Me.DTPdate.CustomFormat = "yyyy-MM-dd"
        Me.DTPdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPdate.Location = New System.Drawing.Point(136, 16)
        Me.DTPdate.Name = "DTPdate"
        Me.DTPdate.Size = New System.Drawing.Size(120, 21)
        Me.DTPdate.TabIndex = 5
        '
        'CombWORK_TIME
        '
        Me.CombWORK_TIME.Location = New System.Drawing.Point(136, 48)
        Me.CombWORK_TIME.Name = "CombWORK_TIME"
        Me.CombWORK_TIME.Size = New System.Drawing.Size(120, 20)
        Me.CombWORK_TIME.TabIndex = 6
        '
        'CombCHIEF_TALLY
        '
        Me.CombCHIEF_TALLY.Location = New System.Drawing.Point(376, 52)
        Me.CombCHIEF_TALLY.Name = "CombCHIEF_TALLY"
        Me.CombCHIEF_TALLY.Size = New System.Drawing.Size(120, 20)
        Me.CombCHIEF_TALLY.TabIndex = 18
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(305, 80)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 41
        Me.BTQUIT.Text = "取消"
        '
        'BTOK
        '
        Me.BTOK.Location = New System.Drawing.Point(225, 80)
        Me.BTOK.Name = "BTOK"
        Me.BTOK.Size = New System.Drawing.Size(65, 24)
        Me.BTOK.TabIndex = 40
        Me.BTOK.Text = "确认"
        '
        'RBchina
        '
        Me.RBchina.Location = New System.Drawing.Point(48, 248)
        Me.RBchina.Name = "RBchina"
        Me.RBchina.Size = New System.Drawing.Size(74, 20)
        Me.RBchina.TabIndex = 42
        Me.RBchina.Text = "中文格式"
        Me.RBchina.Visible = False
        '
        'RBeng
        '
        Me.RBeng.Location = New System.Drawing.Point(136, 248)
        Me.RBeng.Name = "RBeng"
        Me.RBeng.Size = New System.Drawing.Size(74, 20)
        Me.RBeng.TabIndex = 43
        Me.RBeng.Text = "英文格式"
        Me.RBeng.Visible = False
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(8, 120)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.Size = New System.Drawing.Size(576, 112)
        Me.C1DBG.TabIndex = 44
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
        " HorizontalScrollGroup=""1""><Height>108</Height><CaptionStyle parent=""Style2"" me=" & _
        """Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""Eve" & _
        "nRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterSty" & _
        "le parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><Head" & _
        "ingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow""" & _
        " me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle paren" & _
        "t=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style1" & _
        "1"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""S" & _
        "tyle1"" /><ClientRect>0, 0, 572, 108</ClientRect><BorderSide>0</BorderSide><Borde" & _
        "rStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles" & _
        "><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style par" & _
        "ent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style parent" & _
        "=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=" & _
        """Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=" & _
        """Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Head" & _
        "ing"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent" & _
        "=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</h" & _
        "orzSplits><Layout>None</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth><Clien" & _
        "tArea>0, 0, 572, 108</ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" />" & _
        "<PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'btexit
        '
        Me.btexit.Location = New System.Drawing.Point(304, 248)
        Me.btexit.Name = "btexit"
        Me.btexit.Size = New System.Drawing.Size(65, 24)
        Me.btexit.TabIndex = 46
        Me.btexit.Text = "退出"
        '
        'btsave
        '
        Me.btsave.Location = New System.Drawing.Point(224, 248)
        Me.btsave.Name = "btsave"
        Me.btsave.Size = New System.Drawing.Size(65, 24)
        Me.btsave.TabIndex = 45
        Me.btsave.Text = "保存"
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(64, 80)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(112, 24)
        Me.CheckBox1.TabIndex = 47
        Me.CheckBox1.Text = "修改本班数据"
        '
        'CheckBox2
        '
        Me.CheckBox2.Location = New System.Drawing.Point(432, 80)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(88, 24)
        Me.CheckBox2.TabIndex = 48
        Me.CheckBox2.Text = "完船日报"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(304, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "翻舱类型"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cmbflag
        '
        Me.Cmbflag.Items.AddRange(New Object() {"", "出舱", "重装"})
        Me.Cmbflag.Location = New System.Drawing.Point(376, 16)
        Me.Cmbflag.Name = "Cmbflag"
        Me.Cmbflag.Size = New System.Drawing.Size(120, 20)
        Me.Cmbflag.TabIndex = 6
        '
        'FrmCARGO_DAILY_REPORT_OTHER
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(594, 280)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btexit)
        Me.Controls.Add(Me.btsave)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.RBeng)
        Me.Controls.Add(Me.RBchina)
        Me.Controls.Add(Me.BTQUIT)
        Me.Controls.Add(Me.BTOK)
        Me.Controls.Add(Me.CombCHIEF_TALLY)
        Me.Controls.Add(Me.CombWORK_TIME)
        Me.Controls.Add(Me.DTPdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cmbflag)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCARGO_DAILY_REPORT_OTHER"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "翻舱日报_处理"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCARGO_DAILY_REPORT_OTHER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Height = 144
        ff = 0
        dw = Getdata("select Code_WorkTime,WorkTime from Code_WorkTime where Code_WorkTime<>'00'", dswork_time)
        CombWORK_TIME.DataSource = dswork_time.Tables(0).DefaultView
        CombWORK_TIME.DisplayMember = "WorkTime"
        CombWORK_TIME.ValueMember = "Code_WorkTime"

        'dw = Getdata("select work_no,name from tally_clerk", dschief)
        'CombCHIEF_TALLY.DataSource = dschief.Tables(0).DefaultView
        'CombCHIEF_TALLY.DisplayMember = "name"
        'CombCHIEF_TALLY.ValueMember = "work_no"

        RBeng.Checked = True
        OKMARK_OTHER = 0

    End Sub

    Private Sub chief()
        dw = Getdata("exec sp_chief_tally '" & Ship_ID & "', '" & G_DeptCode & "','" & DTPdate.Value & "','" & CombWORK_TIME.SelectedValue & "'", dschief)
        CombCHIEF_TALLY.DataSource = dschief.Tables(0).DefaultView
        CombCHIEF_TALLY.DisplayMember = "name"
        CombCHIEF_TALLY.ValueMember = "work_no"
        CombCHIEF_TALLY.Refresh()
    End Sub

    Private Sub DTPDATE_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTPdate.Leave
        CombCHIEF_TALLY.ValueMember = ""
        Call chief()
    End Sub

    Private Sub CombWORK_TIME_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CombWORK_TIME.Leave
        CombCHIEF_TALLY.ValueMember = ""
        Call chief()
    End Sub

    Private Sub BTOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOK.Click
        Try
            If Cmbflag.Text.Trim().Length = 0 Then
                ff = 0
                MsgBox("翻舱类别不能为空！")
                Exit Sub
            End If
            If CheckBox2.Checked = True Then
                GL_WCRB = ".END"
            Else
                GL_WCRB = ""
            End If

            If RBchina.Checked = True Then
                dsdaily.Reset()
                dw = Getdata("exec sp_daily_report_other '" & Ship_ID & "','" & DTPdate.Value & "','" & CombWORK_TIME.SelectedValue & "' ", dsdaily)

                REMARKS_OTHER = ""
                If dsdaily.Tables(1).Rows.Count > 0 Then
                    If dsdaily.Tables(1).Rows(0).Item("shifting") <> 0 Then
                        REMARKS_OTHER = REMARKS_OTHER & "出舱翻舱 " & dsdaily.Tables(1).Rows(0).Item("shifting") & " 件"
                    End If
                    If dsdaily.Tables(1).Rows(0).Item("HOLIDAY") <> 0 Then
                        REMARKS_OTHER = REMARKS_OTHER & "节假日 " & dsdaily.Tables(1).Rows(0).Item("HOLIDAY") & " 件；"
                    End If
                    If dsdaily.Tables(1).Rows(0).Item("NIGHT") <> 0 Then
                        REMARKS_OTHER = REMARKS_OTHER & "夜班 " & dsdaily.Tables(1).Rows(0).Item("NIGHT") & " 件；"
                    End If
                    If dsdaily.Tables(1).Rows(0).Item("NON_CARGOHOLD") <> 0 Then
                        REMARKS_OTHER = REMARKS_OTHER & "非一般货舱 " & dsdaily.Tables(1).Rows(0).Item("NON_CARGOHOLD") & " 件；"
                    End If
                    If dsdaily.Tables(1).Rows(0).Item("MARK_ASSORTING") <> 0 Then
                        REMARKS_OTHER = REMARKS_OTHER & "分标志 " & dsdaily.Tables(1).Rows(0).Item("MARK_ASSORTING") & " 件；"
                    End If
                    If dsdaily.Tables(1).Rows(0).Item("STANDBY_time") <> 0 Then
                        REMARKS_OTHER = REMARKS_OTHER & "待时 " & dsdaily.Tables(1).Rows(0).Item("STANDBY_time") & " 件；"
                    End If
                End If
                OKMARK_OTHER = 1
                trade = "1"
            End If

            Dim st As String
            Dim lastgb As String
            Dim dstmp As New DataSet
            Dim dstemp As New DataSet

            If RBeng.Checked = True Then
                If Cmbflag.Text.Trim() = "出舱" Then
                    ff = 1
                End If
                If Cmbflag.Text.Trim() = "重装" Then
                    ff = 2
                End If
                rep1 = "0"
                rep2 = "0"
                st = "select id,gbno from report_his1 where ship_id='" & Ship_ID & "' and datediff(dd,workdate,'" & DTPdate.Value & "')=0 and worktime='" & CombWORK_TIME.SelectedValue & "' AND other='" & ff & "' "
                Getdata(st, dstmp)
                If dstmp.Tables(0).Rows.Count > 0 Then
                    If MsgBox("现有条件的日报已存在，是否重新统计？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                        ExecSql("exec sp_daily_report_eng_gl_other_new '" & Ship_ID & "','" & DTPdate.Value & "','" & CombWORK_TIME.SelectedValue & "','" & ff & "' ")
                        st = "select id from report_his1 where ship_id='" & Ship_ID & "' and datediff(dd,workdate,'" & DTPdate.Value & "')=0 and worktime='" & CombWORK_TIME.SelectedValue & "' AND other='" & ff & "' "
                        Getdata(st, dstmp)
                    End If
                Else
                    ExecSql("exec sp_daily_report_eng_gl_other_new '" & Ship_ID & "','" & DTPdate.Value & "','" & CombWORK_TIME.SelectedValue & "','" & ff & "' ")
                    st = "select id from report_his1 where ship_id='" & Ship_ID & "' and datediff(dd,workdate,'" & DTPdate.Value & "')=0 and worktime='" & CombWORK_TIME.SelectedValue & "' AND other='" & ff & "' "
                    Getdata(st, dstmp)
                End If

                'If CombWORK_TIME.Text = "白班" Then
                '    st = "select id from report_his1 where ship_id='" & Ship_ID & "' and datediff(dd,workdate,'" & DTPdate.Value & "')=1 and worktime='02' AND other='" & ff & "' "
                'Else
                '    st = "select id from report_his1 where ship_id='" & Ship_ID & "' and datediff(dd,workdate,'" & DTPdate.Value & "')=0 and worktime='01' AND other='" & ff & "' "
                'End If
                'st = "select id from report_his1 where ship_id='" & Ship_ID & "' and datediff(dd,workdate,'" & DTPdate.Value & "')=0 and worktime='" & CombWORK_TIME.SelectedValue & "' "

                If dstmp.Tables(0).Rows.Count > 0 Then
                    rep1 = dstmp.Tables(0).Rows(0)(0)
                    If System.Convert.ToInt16(dstmp.Tables(0).Rows(0)(1)) > 1 Then
                        lastgb = System.Convert.ToInt16(dstmp.Tables(0).Rows(0)(1)) - 1
                        lastgb = System.Convert.ToString(lastgb).ToString.PadLeft(2, "0")
                    Else
                        lastgb = 0
                    End If
                End If

                st = "select id from report_his1 where ship_id='" & Ship_ID & "' and gbno='" & lastgb & "' and other='" & ff & "' "
                Getdata(st, dstemp)

                If dstemp.Tables(0).Rows.Count > 0 Then
                    rep2 = dstemp.Tables(0).Rows(0)(0)
                End If

                'dw = Getdata("exec sp_daily_report_eng_gl_tol '" & dstmp.Tables(0).Rows(0)(0) & "','" & dstemp.Tables(0).Rows(0)(0) & "' ", dsdaily)
                'dw = Getdata("exec sp_daily_report_eng_gl_tol '" & rep1 & "','" & rep2 & "' ", dsdaily_other)

                Getdata("SELECT HATCH FROM VESSEL INNER JOIN SSHIP ON VESSEL.VESSEL_ID = SSHIP.V_ID WHERE SHIP_ID ='" & Ship_ID & "' ", dstmp)
                If dstmp.Tables(0).Rows(0)(0) > 6 Then
                    dw = Getdata("exec sp_daily_report_eng_gl_tol_new '" & rep1 & "','" & rep2 & "' ", dsdaily_other)
                Else
                    dw = Getdata("exec sp_daily_report_eng_gl_tol '" & rep1 & "','" & rep2 & "' ", dsdaily_other)
                End If

                REMARKS_OTHER = ""
                If dsdaily_other.Tables(1).Rows.Count > 0 Then
                    If dsdaily_other.Tables(1).Rows(0).Item("shifting") <> 0 Then
                        REMARKS_OTHER = REMARKS_OTHER & "SHIFTING OUTSIDE THE HOLD " '& dsdaily.Tables(1).Rows(0).Item("shifting") & " PKGS."
                    End If
                    If dsdaily_other.Tables(1).Rows(0).Item("HOLIDAY") <> 0 Then
                        REMARKS_OTHER = REMARKS_OTHER & "HOLIDAY " & dsdaily_other.Tables(1).Rows(0).Item("HOLIDAY") & " PKGS."
                    End If
                    If dsdaily_other.Tables(1).Rows(0).Item("NIGHT") <> 0 Then
                        REMARKS_OTHER = REMARKS_OTHER & "NIGHT SHIFT " & dsdaily_other.Tables(1).Rows(0).Item("NIGHT") & " PKGS."
                    End If
                    If dsdaily_other.Tables(1).Rows(0).Item("NON_CARGOHOLD") <> 0 Then
                        REMARKS_OTHER = REMARKS_OTHER & "NON_CARGOHOLD " & dsdaily_other.Tables(1).Rows(0).Item("NON_CARGOHOLD") & " PKGS."
                    End If
                    If dsdaily_other.Tables(1).Rows(0).Item("MARK_ASSORTING") <> 0 Then
                        REMARKS_OTHER = REMARKS_OTHER & "MARK_ASSORTING " & dsdaily_other.Tables(1).Rows(0).Item("MARK_ASSORTING") & " PKGS."
                    End If
                    If dsdaily_other.Tables(1).Rows(0).Item("STANDBY_time") <> 0 Then
                        REMARKS_OTHER = REMARKS_OTHER & "STANDBY_time " & dsdaily_other.Tables(1).Rows(0).Item("STANDBY_time") & " PKGS."
                    End If
                End If
                OKMARK_OTHER = 1
                trade = "2"
            End If

            If CheckBox1.Checked = True Then

                strrep = "select * from report_his2 where hisid='" & rep1 & "' order by id "
                dwrep = Updatedata(sqldarep, strrep, dsrep)
                Me.C1DBG.DataSource = dwrep

                Me.C1DBG.Splits(0).DisplayColumns.Item("id").Visible = False
                Me.C1DBG.Splits(0).DisplayColumns.Item("hisid").Visible = False
                Me.C1DBG.Splits(0).DisplayColumns.Item("idname").Visible = False
                'Me.C1DBG.Columns.Item("itemsname").Caption = "货名"
                'Me.C1DBG.Columns.Item("h8p").Caption = "小计件"
                'Me.C1DBG.Columns.Item("h8t").Caption = "小计吨"
                'Me.C1DBG.Columns.Item("h1p").Caption = "1/件"
                'Me.C1DBG.Columns.Item("h1t").Caption = "1/吨"
                'Me.C1DBG.Columns.Item("h2p").Caption = "2/件"
                'Me.C1DBG.Columns.Item("h2t").Caption = "2/吨"
                'Me.C1DBG.Columns.Item("h3p").Caption = "3/件"
                'Me.C1DBG.Columns.Item("h3t").Caption = "3/吨"
                'Me.C1DBG.Columns.Item("h4p").Caption = "4/件"
                'Me.C1DBG.Columns.Item("h4t").Caption = "4/吨"
                'Me.C1DBG.Columns.Item("h5p").Caption = "5/件"
                'Me.C1DBG.Columns.Item("h5t").Caption = "5/吨"
                'Me.C1DBG.Columns.Item("h6p").Caption = "6/件"
                'Me.C1DBG.Columns.Item("h6t").Caption = "6/吨"
                'Me.C1DBG.Columns.Item("h7p").Caption = "7/件"
                'Me.C1DBG.Columns.Item("h7t").Caption = "7/吨"
                Me.C1DBG.Columns.Item("code_goods").Caption = "货名"
                Me.C1DBG.Columns.Item("h17p").Caption = "小计件"
                Me.C1DBG.Columns.Item("h17t").Caption = "小计吨"
                Me.C1DBG.Columns.Item("h1p").Caption = "1舱件"
                Me.C1DBG.Columns.Item("h1t").Caption = "1舱吨"
                Me.C1DBG.Columns.Item("h2p").Caption = "2舱件"
                Me.C1DBG.Columns.Item("h2t").Caption = "2舱吨"
                Me.C1DBG.Columns.Item("h3p").Caption = "3舱件"
                Me.C1DBG.Columns.Item("h3t").Caption = "3舱吨"
                Me.C1DBG.Columns.Item("h4p").Caption = "4舱件"
                Me.C1DBG.Columns.Item("h4t").Caption = "4舱吨"
                Me.C1DBG.Columns.Item("h5p").Caption = "5舱件"
                Me.C1DBG.Columns.Item("h5t").Caption = "5舱吨"
                Me.C1DBG.Columns.Item("h6p").Caption = "6舱件"
                Me.C1DBG.Columns.Item("h6t").Caption = "6舱吨"
                Me.C1DBG.Columns.Item("h16p").Caption = "甲板件"
                Me.C1DBG.Columns.Item("h16t").Caption = "甲板吨"
                If GL_hatch > 6 Then
                    Me.C1DBG.Columns.Item("h7p").Caption = "7舱件"
                    Me.C1DBG.Columns.Item("h7t").Caption = "7舱吨"
                    Me.C1DBG.Columns.Item("h8p").Caption = "8舱件"
                    Me.C1DBG.Columns.Item("h8t").Caption = "8舱吨"
                    Me.C1DBG.Columns.Item("h9p").Caption = "9舱件"
                    Me.C1DBG.Columns.Item("h9t").Caption = "9舱吨"
                    Me.C1DBG.Columns.Item("h10p").Caption = "10舱件"
                    Me.C1DBG.Columns.Item("h10t").Caption = "10舱吨"
                    Me.C1DBG.Columns.Item("h11p").Caption = "11舱件"
                    Me.C1DBG.Columns.Item("h11t").Caption = "11舱吨"
                    Me.C1DBG.Columns.Item("h12p").Caption = "12舱件"
                    Me.C1DBG.Columns.Item("h12t").Caption = "12舱吨"
                    Me.C1DBG.Columns.Item("h13p").Caption = "13舱件"
                    Me.C1DBG.Columns.Item("h13t").Caption = "13舱吨"
                    Me.C1DBG.Columns.Item("h14p").Caption = "14舱件"
                    Me.C1DBG.Columns.Item("h14t").Caption = "14舱吨"
                    Me.C1DBG.Columns.Item("h15p").Caption = "15舱件"
                    Me.C1DBG.Columns.Item("h15t").Caption = "15舱吨"
                End If

                Me.Height = 320
                Me.StartPosition = FormStartPosition.CenterScreen

                BTOK.Enabled = False
                Me.Refresh()
            Else
                Call BTQUIT_Click(sender, e)
            End If

            'If RBeng.Checked = True Then
            'dw = Getdata("exec sp_daily_report_eng_gl_tol '" & dstmp.Tables(0).Rows(0)(0) & "','" & DTPdate.Value & "','" & CombWORK_TIME.SelectedValue & "' ", dsdaily)
            'REMARKS = ""
            'If dsdaily.Tables(1).Rows.Count > 0 Then
            '    If dsdaily.Tables(1).Rows(0).Item("shifting") <> 0 Then
            '        REMARKS = REMARKS & "SHIFTING " & dsdaily.Tables(1).Rows(0).Item("shifting") & " PKGS；"
            '    End If
            '    If dsdaily.Tables(1).Rows(0).Item("HOLIDAY") <> 0 Then
            '        REMARKS = REMARKS & "HOLIDAY " & dsdaily.Tables(1).Rows(0).Item("HOLIDAY") & " PKGS；"
            '    End If
            '    If dsdaily.Tables(1).Rows(0).Item("NIGHT") <> 0 Then
            '        REMARKS = REMARKS & "NIGHT SHIFT " & dsdaily.Tables(1).Rows(0).Item("NIGHT") & " PKGS；"
            '    End If
            '    If dsdaily.Tables(1).Rows(0).Item("NON_CARGOHOLD") <> 0 Then
            '        REMARKS = REMARKS & "NON_CARGOHOLD " & dsdaily.Tables(1).Rows(0).Item("NON_CARGOHOLD") & " PKGS；"
            '    End If
            '    If dsdaily.Tables(1).Rows(0).Item("MARK_ASSORTING") <> 0 Then
            '        REMARKS = REMARKS & "MARK_ASSORTING " & dsdaily.Tables(1).Rows(0).Item("MARK_ASSORTING") & " PKGS；"
            '    End If
            '    If dsdaily.Tables(1).Rows(0).Item("STANDBY_time") <> 0 Then
            '        REMARKS = REMARKS & "STANDBY_time " & dsdaily.Tables(1).Rows(0).Item("STANDBY_time") & " PKGS；"
            '    End If
            'End If
            'OKMARK = 1
            'trade = "2"
            'Call BTQUIT_Click(sender, e)
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub
    Private Sub DTPdate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DTPdate.KeyPress
        If e.KeyChar = Chr(13) Then
            CombWORK_TIME.Focus()
        End If
    End Sub
    Private Sub CombWORK_TIME_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombWORK_TIME.KeyPress
        If e.KeyChar = Chr(13) Then
            CombCHIEF_TALLY.Focus()
        End If
    End Sub
    Private Sub CombCHIEF_TALLY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombCHIEF_TALLY.KeyPress
        If e.KeyChar = Chr(13) Then
            CheckBox1.Focus()
        End If
    End Sub

    Private Sub CheckBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CheckBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            BTOK.Focus()
        End If
    End Sub

    Private Sub btsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsave.Click
        Try
            If MsgBox("你确认要修改信息吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
                sqldarep.Update(dsrep)

                dw = Getdata("exec sp_daily_report_eng_gl_tol '" & rep1 & "','" & rep2 & "' ", dsdaily)
                REMARKS_OTHER = ""
                If dsdaily.Tables(1).Rows.Count > 0 Then
                    If dsdaily_other.Tables(1).Rows(0).Item("shifting") <> 0 Then
                        REMARKS_OTHER = REMARKS_OTHER & "SHIFTING OUTSIDE THE HOLD " '& dsdaily.Tables(1).Rows(0).Item("shifting") & " PKGS."
                    End If
                    If dsdaily_other.Tables(1).Rows(0).Item("HOLIDAY") <> 0 Then
                        REMARKS_OTHER = REMARKS_OTHER & "HOLIDAY " & dsdaily_other.Tables(1).Rows(0).Item("HOLIDAY") & " PKGS."
                    End If
                    If dsdaily_other.Tables(1).Rows(0).Item("NIGHT") <> 0 Then
                        REMARKS_OTHER = REMARKS_OTHER & "NIGHT SHIFT " & dsdaily_other.Tables(1).Rows(0).Item("NIGHT") & " PKGS."
                    End If
                    If dsdaily_other.Tables(1).Rows(0).Item("NON_CARGOHOLD") <> 0 Then
                        REMARKS_OTHER = REMARKS_OTHER & "NON_CARGOHOLD " & dsdaily_other.Tables(1).Rows(0).Item("NON_CARGOHOLD") & " PKGS."
                    End If
                    If dsdaily_other.Tables(1).Rows(0).Item("MARK_ASSORTING") <> 0 Then
                        REMARKS_OTHER = REMARKS_OTHER & "MARK_ASSORTING " & dsdaily_other.Tables(1).Rows(0).Item("MARK_ASSORTING") & " PKGS."
                    End If
                    If dsdaily_other.Tables(1).Rows(0).Item("STANDBY_time") <> 0 Then
                        REMARKS_OTHER = REMARKS_OTHER & "STANDBY_time " & dsdaily_other.Tables(1).Rows(0).Item("STANDBY_time") & " PKGS."
                    End If
                End If
                OKMARK = 1
                trade = "2"

                'Me.Close()
            End If
        Catch ex As System.Exception
            Me.Close()
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btexit.Click
        Me.Close()
    End Sub

End Class
