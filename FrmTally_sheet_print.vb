Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FrmTally_sheet_print
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim dsprint As New DataSet()
    Dim dw As New DataView()
    Dim dsno As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dshead As New DataSet()
    Dim dscheck As New DataSet()
    Dim holiday As String
    Dim night As String
    Dim non_cargohold As String
    Dim assorting As Integer
    Dim MARK_STANDBY As String
    Dim WEIGHT As String
    Dim ANCHORAGE As String
    Dim SEA As String
    Dim FREEZE As Integer
    Dim SPECIAL As String
    Dim OVER_LENGTH_WEIGHT As Integer
    Dim tally_clerk As String
    Dim dsclerk As New DataSet()
    Dim CROSS_PERSON As String
    Dim dstime As New DataSet
    Dim bhno As String

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
    Friend WithEvents Combno As System.Windows.Forms.ComboBox
    Friend WithEvents BTPRINT As System.Windows.Forms.Button
    Friend WithEvents BTlist As System.Windows.Forms.Button
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents RBeng As System.Windows.Forms.RadioButton
    Friend WithEvents RBchina As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTally_sheet_print))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Combno = New System.Windows.Forms.ComboBox
        Me.BTPRINT = New System.Windows.Forms.Button
        Me.BTlist = New System.Windows.Forms.Button
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.RBeng = New System.Windows.Forms.RadioButton
        Me.RBchina = New System.Windows.Forms.RadioButton
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "计数单编号："
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Combno
        '
        Me.Combno.Location = New System.Drawing.Point(100, 14)
        Me.Combno.Name = "Combno"
        Me.Combno.Size = New System.Drawing.Size(133, 20)
        Me.Combno.TabIndex = 1
        '
        'BTPRINT
        '
        Me.BTPRINT.Location = New System.Drawing.Point(484, 14)
        Me.BTPRINT.Name = "BTPRINT"
        Me.BTPRINT.Size = New System.Drawing.Size(65, 24)
        Me.BTPRINT.TabIndex = 84
        Me.BTPRINT.Text = "打印"
        '
        'BTlist
        '
        Me.BTlist.Location = New System.Drawing.Point(414, 14)
        Me.BTlist.Name = "BTlist"
        Me.BTlist.Size = New System.Drawing.Size(65, 24)
        Me.BTlist.TabIndex = 83
        Me.BTlist.Text = "表格生成"
        '
        'C1DBG
        '
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("C1DBG.Images"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(6, 68)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG.Size = New System.Drawing.Size(543, 310)
        Me.C1DBG.TabIndex = 85
        Me.C1DBG.Text = "C1TrueDBGrid1"
        Me.C1DBG.PropBag = resources.GetString("C1DBG.PropBag")
        '
        'RBeng
        '
        Me.RBeng.Location = New System.Drawing.Point(330, 16)
        Me.RBeng.Name = "RBeng"
        Me.RBeng.Size = New System.Drawing.Size(74, 20)
        Me.RBeng.TabIndex = 87
        Me.RBeng.Text = "英文格式"
        '
        'RBchina
        '
        Me.RBchina.Location = New System.Drawing.Point(244, 16)
        Me.RBchina.Name = "RBchina"
        Me.RBchina.Size = New System.Drawing.Size(74, 20)
        Me.RBchina.TabIndex = 86
        Me.RBchina.Text = "中文格式"
        '
        'FrmTally_sheet_print
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(558, 385)
        Me.Controls.Add(Me.RBeng)
        Me.Controls.Add(Me.RBchina)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.BTPRINT)
        Me.Controls.Add(Me.BTlist)
        Me.Controls.Add(Me.Combno)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTally_sheet_print"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "计数单打印"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmTally_sheet_print_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dw = getdata("select distinct no from cargo_list where ship_id='" & Ship_ID & "'", dsno)
        Combno.DataSource = dsno.Tables(0).DefaultView
        Combno.DisplayMember = "no"
        Combno.ValueMember = "no"
        RBeng.Checked = True
        ds_sship.Reset()
        dw = Getdata("select * from view_outhatch_sship where ship_id='" & Ship_ID & "'", ds_sship)
    End Sub

    Private Sub BTlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTlist.Click
        Try
            If Len(Trim(Combno.SelectedValue)) > 0 Then
                ds.Reset()
                dshead.Reset()
                dscheck.Reset()
                dstime.Reset()

                holiday = 0
                night = 0
                non_cargohold = 0
                assorting = 0
                MARK_STANDBY = 0
                WEIGHT = 0
                ANCHORAGE = 0
                SEA = 0
                FREEZE = 0
                SPECIAL = 0
                OVER_LENGTH_WEIGHT = 0
                tally_clerk = ""
                CROSS_PERSON = ""
                If RBchina.Checked = True Then
                    dw = Getdata("select blno,mark,pack_cha as pack,amount from viewcargo_tally_sheet_print where ship_id='" & Ship_ID & "' and no='" & Combno.SelectedValue & "'", ds)
                    dw = Getdata("select max(berthno) as berthno,max(descr) as hatchno,max(no) as no,max(YARD_NO) as yard_no from viewcargo_tally_sheet_print where ship_id='" & Ship_ID & "' and no='" & Combno.SelectedValue & "'", dshead)
                End If
                If RBeng.Checked = True Then
                    dw = Getdata("select blno,mark,pack_eng as pack,amount from viewcargo_tally_sheet_print where ship_id='" & Ship_ID & "' and no='" & Combno.SelectedValue & "'", ds)
                    dw = Getdata("select max(berthno) as berthno,max(descr_eng) as hatchno,max(no) as no,max(YARD_NO) as yard_no from viewcargo_tally_sheet_print where ship_id='" & Ship_ID & "' and no='" & Combno.SelectedValue & "'", dshead)
                End If
                dw = Getdata("exec SPTALLY_SHEET '" & Ship_ID & "','" & Combno.SelectedValue & "'", dstime)
                dw = Getdata("select max(holiday) as holiday,max(NIGHT_MARK) as night,max(NON_CARGOHOLD) as NON_CARGOHOLD,sum(MARK_ASSORTING) as MARK_ASSORTING,max(MARK_STANDBY) as MARK_STANDBY,max(WEIGHT) as WEIGHT,max(ANCHORAGE_REMARK) as ANCHORAGE_REMARK,max(SEA_AFFAIRE_CARGO) as SEA_AFFAIRE_CARGO,sum(FREEZE_AMOUNT) as FREEZE_AMOUNT,max(TALLY_SPECIAL) as TALLY_SPECIAL,sum(OVER_LENGTH_WEIGHT) as OVER_LENGTH_WEIGHT from viewcargo_tally_sheet_print where ship_id='" & Ship_ID & "' and no='" & Combno.SelectedValue & "'", dscheck)
                If dscheck.Tables(0).Rows.Count > 0 Then
                    holiday = dscheck.Tables(0).Rows(0).Item("holiday")
                    night = dscheck.Tables(0).Rows(0).Item("NIGHT")
                    non_cargohold = dscheck.Tables(0).Rows(0).Item("NON_CARGOHOLD")
                    assorting = dscheck.Tables(0).Rows(0).Item("MARK_ASSORTING")
                    MARK_STANDBY = dscheck.Tables(0).Rows(0).Item("MARK_STANDBY")
                    WEIGHT = dscheck.Tables(0).Rows(0).Item("WEIGHT")
                    ANCHORAGE = dscheck.Tables(0).Rows(0).Item("ANCHORAGE_REMARK")
                    SEA = dscheck.Tables(0).Rows(0).Item("SEA_AFFAIRE_CARGO")
                    FREEZE = dscheck.Tables(0).Rows(0).Item("FREEZE_AMOUNT")
                    SPECIAL = dscheck.Tables(0).Rows(0).Item("TALLY_SPECIAL")
                    OVER_LENGTH_WEIGHT = dscheck.Tables(0).Rows(0).Item("OVER_LENGTH_WEIGHT")
                End If
                dw = Getdata("select name1,name2,name3,CROSS_PERSON from view_tally_sheet where ship_id='" & Ship_ID & "' and no='" & Combno.SelectedValue & "'", dsclerk)
                If dsclerk.Tables(0).Rows.Count > 0 Then
                    tally_clerk = IIf(IsDBNull(dsclerk.Tables(0).Rows(0).Item("name1")), "", dsclerk.Tables(0).Rows(0).Item("name1")) & " " & IIf(IsDBNull(dsclerk.Tables(0).Rows(0).Item("name2")), "", dsclerk.Tables(0).Rows(0).Item("name2")) & " " & IIf(IsDBNull(dsclerk.Tables(0).Rows(0).Item("name3")), "", dsclerk.Tables(0).Rows(0).Item("name3"))
                    'CROSS_PERSON = dsclerk.Tables(0).Rows(0).Item("CROSS_PERSON")
                End If
                C1DBG.DataSource = ds.Tables(0).DefaultView
                Me.C1DBG.Columns.Item("BLNO").Caption = "提单号"
                Me.C1DBG.Columns.Item("MARK").Caption = "标志"
                Me.C1DBG.Columns.Item("pack").Caption = "包装"
                Me.C1DBG.Columns.Item("AMOUNT").Caption = "件数"
                C1DBG.Refresh()
                BTPRINT.Enabled = True
            Else
                MsgBox("请选择计数单编号！")
                Exit Sub
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTPRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTPRINT.Click
      
        'If ds.Tables(0).Rows.Count > 0 Then
        If C1DBG.Splits(0).Rows.Count > 0 Then
            If RBchina.Checked = True Then
                If Hatch_in = 0 Then
                    Inoutport_Cha = "进口"
                    bhno = "提单号"
                Else
                    Inoutport_Cha = "出口"
                    bhno = "装货单号"
                End If
                Call china()
            End If
            If RBeng.Checked = True Then
                If Hatch_in = 0 Then
                    Inoutport_eng = "Inward"
                    bhno = "B/L No."
                Else
                    Inoutport_eng = "Outward"
                    bhno = "S/O No."
                End If
                Call eng()
            End If
        Else
            MsgBox("该计数单没有内容或没有该计数单！")
            Exit Sub
        End If
    End Sub

    Private Sub china()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer
        Dim others As String

        Try
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "Report_CARGO.xls", pathstr + "Report.xls")
            Filepath = pathstr + "Report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("计数单（C）"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = True
            xlsheet.Select()
            xlsheet.Cells(9, 1) = "(" & Inoutport_Cha & ")"
            xlsheet.Cells(15, 1) = bhno
            xlsheet.Cells(11, 2) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("CHI_VESSEL"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("CHI_VESSEL")))
            xlsheet.Cells(11, 5) = dshead.Tables(0).Rows(0).Item("berthno")
            xlsheet.Cells(11, 9) = dshead.Tables(0).Rows(0).Item("hatchno")
            xlsheet.Cells(11, 13) = dshead.Tables(0).Rows(0).Item("no")
            xlsheet.Cells(12, 3) = dshead.Tables(0).Rows(0).Item("yard_no")
            xlsheet.Cells(12, 8) = dstime.Tables(0).Rows(0).Item("month_from")
            xlsheet.Cells(12, 10) = dstime.Tables(0).Rows(0).Item("day_from")
            xlsheet.Cells(12, 12) = dstime.Tables(0).Rows(0).Item("time_from")
            xlsheet.Cells(13, 8) = dstime.Tables(0).Rows(0).Item("month_to")
            xlsheet.Cells(13, 10) = dstime.Tables(0).Rows(0).Item("day_to")
            xlsheet.Cells(13, 12) = dstime.Tables(0).Rows(0).Item("time_to")

            For row = 0 To ds.Tables(0).Rows.Count - 1
                For col = 0 To 3
                    xlsheet.Cells(17 + row, col + 1) = ds.Tables(0).Rows(row)(col)
                Next col
            Next row
            If holiday = "1" Then
                xlsheet.Cells(33, 4) = "√"
            End If
            If night = "1" Then
                xlsheet.Cells(34, 4) = "√"
            End If
            If non_cargohold > 0 Then
                xlsheet.Cells(35, 3) = non_cargohold & "件"
            End If
            If assorting > 0 Then
                xlsheet.Cells(36, 4) = assorting & "件"
            End If
            If MARK_STANDBY = "1" Then
                xlsheet.Cells(37, 4) = "√"
            End If
            others = ""
            If WEIGHT = "1" Then
                others = ",重装"
            End If
            If ANCHORAGE = "1" Then
                others = others & ",锚地"
            End If
            If SEA = "1" Then
                others = others & ",海事"
            End If
            If FREEZE > 0 Then
                others = others & ",困难作业：" & FREEZE & " 件"
            End If
            If SPECIAL > 0 Then
                others = others & ",特理：" & SPECIAL & " 件"
            End If
            If OVER_LENGTH_WEIGHT > 0 Then
                others = others & ",超长超重：" & OVER_LENGTH_WEIGHT & " 件"
            End If
            If Len(Trim(others)) > 2 Then
                others = Mid(Trim(others), 2, Len(Trim(others)))
            End If
            xlsheet.Cells(38, 3) = others
            xlsheet.Cells(41, 3) = tally_clerk
            xlsheet.Cells(41, 10) = CROSS_PERSON

            xlsheet.PrintPreview()

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
        Dim others As String

        Try
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "Report_CARGO.xls", pathstr + "Report.xls")
            Filepath = pathstr + "report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("计数单（E）"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = True
            xlsheet.Select()
            xlsheet.Cells(9, 1) = "(" & Inoutport_eng & ")"
            xlsheet.Cells(15, 1) = bhno
            xlsheet.Cells(11, 2) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("eng_VESSEL"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("eng_VESSEL")))
            xlsheet.Cells(11, 6) = dshead.Tables(0).Rows(0).Item("berthno")
            xlsheet.Cells(11, 10) = dshead.Tables(0).Rows(0).Item("hatchno")
            xlsheet.Cells(11, 14) = dshead.Tables(0).Rows(0).Item("no")
            xlsheet.Cells(12, 6) = dshead.Tables(0).Rows(0).Item("yard_no")
            xlsheet.Cells(13, 9) = dstime.Tables(0).Rows(0).Item("month_from") & "." & dstime.Tables(0).Rows(0).Item("day_from") & "——" & dstime.Tables(0).Rows(0).Item("month_to") & "." & dstime.Tables(0).Rows(0).Item("day_to")
            xlsheet.Cells(13, 3) = dstime.Tables(0).Rows(0).Item("time_from")
            xlsheet.Cells(13, 6) = dstime.Tables(0).Rows(0).Item("time_to")
            xlsheet.Cells(13, 13) = dstime.Tables(0).Rows(0).Item("year")

            For row = 0 To ds.Tables(0).Rows.Count - 1
                For col = 0 To 3
                    xlsheet.Cells(17 + row, col + 1) = ds.Tables(0).Rows(row)(col)
                Next col
            Next row
            If holiday = "1" Then
                xlsheet.Cells(33, 4) = "√"
            End If
            If night = "1" Then
                xlsheet.Cells(34, 4) = "√"
            End If
            If non_cargohold > 0 Then
                xlsheet.Cells(35, 3) = non_cargohold & "P'kgs"
            End If
            If assorting > 0 Then
                xlsheet.Cells(36, 4) = assorting & "P'kgs"
            End If
            If MARK_STANDBY = "1" Then
                xlsheet.Cells(37, 4) = "√"
            End If
            others = ""
            If WEIGHT = "1" Then
                others = ",Weight"
            End If
            If ANCHORAGE = "1" Then
                others = others & ",ANCHORAGE"
            End If
            If SEA = "1" Then
                others = others & ",SEA"
            End If
            If FREEZE > 0 Then
                others = others & ",FREEZE：" & FREEZE & " P'kgs"
            End If
            If SPECIAL > 0 Then
                others = others & ",SPECIAL：" & SPECIAL & " P'kgs"
            End If
            If OVER_LENGTH_WEIGHT > 0 Then
                others = others & ",OVER_LENGTH_WEIGHT：" & OVER_LENGTH_WEIGHT & " P'kgs"
            End If
            If Len(Trim(others)) > 2 Then
                others = Mid(Trim(others), 2, Len(Trim(others)))
            End If
            xlsheet.Cells(38, 4) = others
            xlsheet.Cells(41, 3) = tally_clerk
            xlsheet.Cells(41, 10) = CROSS_PERSON

            xlsheet.PrintPreview()

        Catch
            xlapp.Quit()
            SendKeys.Send("n")
        End Try
    End Sub
End Class
