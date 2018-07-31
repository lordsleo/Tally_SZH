Imports Tally.DBControl

Public Class FrmReportNew

    Dim i, j As Integer
    Dim blNext As Boolean '检查执行条件是否满足
    Dim strDynamicTerm As String
    Dim reportdate As New DateTimePicker

    Dim sqlFeeVoyageCargo As String
    Dim dsFeeVoyageCargo As New DataSet
    Dim dvFeeVoyageCargo As New DataView
    Dim sqlFeeVoyageCon As String
    Dim dsFeeVoyageCon As New DataSet
    Dim dvFeeVoyageCon As New DataView
    Dim sqlywfs_cargo As String
    Dim dsywfs_cargo As New DataSet
    Dim dvywfs_cargo As New DataView
    Dim dsywfs_cargo1 As New DataSet
    Dim dvywfs_cargo1 As New DataView
    Dim sqlda_ywfs_cargo As New SqlClient.SqlDataAdapter
    Dim sqlywfs_con As String
    Dim dsywfs_con As New DataSet
    Dim dvywfs_con As New DataView
    Dim dsywfs_con1 As New DataSet
    Dim dvywfs_con1 As New DataView
    Dim sqlda_ywfs_con As New SqlClient.SqlDataAdapter
    Dim reportname As String
    Dim dsfileno As New DataSet
    Dim dsscqk As New DataSet
    Dim dvscqk As New DataView
    Dim dept As String
    Dim dsmx As New DataSet
    Dim dvmx As New DataView
    Dim dsxylh As New DataSet
    Dim dvxylh As New DataView
    Dim dszdhz As New DataSet
    Dim dvzdhz As New DataView
    Dim dscbtj As New DataSet
    Dim dvcbtj As New DataView

    Dim BeginNo As String
    Dim EndNo As String

    Private Sub FrmReportNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reportname = ""
        connstr = conn_ver
        sqlconn.ConnectionString = conn_ver
        If G_DeptCode = "26.11.11" Then
            dept = "1"
        Else
            dept = "2"
        End If
    End Sub

    '件杂货船舶明细
    Private Sub btnFeeVoyageCargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFeeVoyageCargo.Click
        Cursor = Cursors.WaitCursor
        btnSave.Enabled = False
        dvFeeVoyageCargo = Getdata("exec fee_report_lhb '" & dept & "','" & dtpreporttime.Value & "'", dsFeeVoyageCargo)
        Me.C1DBG.DataSource = dvFeeVoyageCargo
        reportname = "FeeVoyageCargo"
        If dvFeeVoyageCargo.Count = 0 Then
            MsgBox("请先处理该月费收数据！")
            Return
        End If
        'Grid设置
        Me.C1DBG.Caption = Me.btnFeeVoyageCargo.Text
        Me.C1DBG.Splits(0).DisplayColumns("rowno").Visible = False
        Me.C1DBG.Columns("itemname").Caption = "项目"
        Me.C1DBG.Columns("souci").Caption = "艘次"
        Me.C1DBG.Columns("soucisum").Caption = "累计艘次"
        Me.C1DBG.Columns("tons").Caption = "吨数"
        Me.C1DBG.Columns("tonssum").Caption = "累计吨数"
        Me.C1DBG.Columns("income").Caption = "收入"
        Me.C1DBG.Columns("incomesum").Caption = "累计收入"
        'Grid列宽
        For j = 0 To C1DBG.Columns.Count - 1
            C1DBG.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            'C1DBG.Splits(0).DisplayColumns.Item(j).AutoSize()
            C1DBG.Splits(0).DisplayColumns.Item(j).Width = 110
        Next
        'Grid单列统计
        'Me.C1DBG.Columns("Amount").FooterText = GetDataSum(dvFeeVoyageCargo, "Amount")
        'Me.C1DBG.Columns("Tons").FooterText = GetDataSum(dvFeeVoyageCargo, "Tons")
        'Me.C1DBG.Columns("MONEY").FooterText = GetDataSum(dvFeeVoyageCargo, "MONEY")
        'Me.C1DBG.Columns("FILE_NO").FooterText = "合计"
        'Me.C1DBG.Columns("CHI_VESSEL").FooterText = dvFeeVoyageCargo.Count & "艘次"
        'Me.C1DBG.Columns("Amount").FooterText = dsFeeVoyageCargo.Tables(1).Rows(0)("js").ToString()
        'Me.C1DBG.Columns("Tons").FooterText = dsFeeVoyageCargo.Tables(1).Rows(0)("ds").ToString()
        'Me.C1DBG.Columns("MONEY").FooterText = dsFeeVoyageCargo.Tables(1).Rows(0)("je").ToString()
        'Me.C1DBG.Columns("FILE_NO").FooterText = "合计"
        'Me.C1DBG.Columns("CHI_VESSEL").FooterText = dsFeeVoyageCargo.Tables(1).Rows(0)("hj").ToString() & "艘次"
        'End If
        Cursor = Cursors.Default
    End Sub

    ''重点货种统计
    'Private Sub btnFeeZDHZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFeeZDHZ.Click
    '    btnSave.Enabled = False
    '    Cursor = Cursors.WaitCursor
    '    dvzdhz = Getdata("select reporttime , report_begin , report_end , goodstypecode ,goodsname ,tallytons ,tallyprice ,tallymoney ,tallytons_last,tallyprice_last ,tallymoney_last,tallytons_diff ,tallyprice_diff ,tallymoney_diff from reportdata_zdhz where datediff(mm,report_begin,'" & Convert.ToDateTime(dtpreporttime.Value.Year.ToString() + "-" + dtpreporttime.Value.Month.ToString() + "-01") & "')=0 and datediff(mm,report_end,'" & Convert.ToDateTime(dtpreporttime1.Value.Year.ToString() + "-" + (dtpreporttime1.Value.Month + 1).ToString() + "-01").AddDays(-1) & "')=0 ", dszdhz)
    '    If dvzdhz.Count > 0 Then
    '        If MsgBox("当前报表已存在，是否重新统计？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
    '            dvzdhz = Getdata("fee_report_zdhz '" & dtpreporttime.Value.ToString() & "','" & dtpreporttime1.Value.ToString() & "'", dszdhz)
    '        End If
    '    Else
    '        dvzdhz = Getdata("fee_report_zdhz '" & dtpreporttime.Value.ToString() & "','" & dtpreporttime1.Value.ToString() & "'", dszdhz)
    '    End If

    '    Me.C1DBG.DataSource = dvzdhz
    '    reportname = "fee_report_zdhz"
    '    'Grid设置
    '    Me.C1DBG.Caption = Me.btnFeeZDHZ.Text
    '    Me.C1DBG.Columns("reporttime").Caption = "报表时间"
    '    Me.C1DBG.Columns("report_begin").Caption = "起"
    '    Me.C1DBG.Columns("report_end").Caption = "止"
    '    Me.C1DBG.Columns("goodstypecode").Caption = "货类代码"
    '    Me.C1DBG.Columns("goodsname").Caption = "货类名称"
    '    Me.C1DBG.Columns("tallytons").Caption = "本年数量"
    '    Me.C1DBG.Columns("tallyprice").Caption = "单价"
    '    Me.C1DBG.Columns("tallymoney").Caption = "本年收入"
    '    Me.C1DBG.Columns("tallytons_last").Caption = "上年数量"
    '    Me.C1DBG.Columns("tallyprice_last").Caption = "单价"
    '    Me.C1DBG.Columns("tallymoney_last").Caption = "上年收入"
    '    Me.C1DBG.Columns("tallytons_diff").Caption = "数量差异"
    '    Me.C1DBG.Columns("tallyprice_diff").Caption = "单价差异"
    '    Me.C1DBG.Columns("tallymoney_diff").Caption = "收入差异"
    '    Me.C1DBG.Columns("reporttime").NumberFormat = "yyyy-MM"
    '    Me.C1DBG.Columns("report_begin").NumberFormat = "yyyy-MM"
    '    Me.C1DBG.Columns("report_end").NumberFormat = "yyyy-MM"
    '    Me.C1DBG.Columns("tallytons").FooterText = GetDataSum(dvzdhz, "tallytons")
    '    Me.C1DBG.Columns("tallymoney").FooterText = GetDataSum(dvzdhz, "tallymoney")
    '    Me.C1DBG.Columns("tallyprice").FooterText = Format(GetDataSum(dvzdhz, "tallymoney") / GetDataSum(dvzdhz, "tallytons"), "0.00")
    '    Me.C1DBG.Columns("tallytons_last").FooterText = GetDataSum(dvzdhz, "tallytons_last")
    '    Me.C1DBG.Columns("tallymoney_last").FooterText = GetDataSum(dvzdhz, "tallymoney_last")
    '    Me.C1DBG.Columns("tallyprice_last").FooterText = Format(GetDataSum(dvzdhz, "tallymoney_last") / GetDataSum(dvzdhz, "tallytons_last"), "0.00")
    '    Me.C1DBG.Columns("tallytons_diff").FooterText = GetDataSum(dvzdhz, "tallytons_diff")
    '    Me.C1DBG.Columns("tallymoney_diff").FooterText = GetDataSum(dvzdhz, "tallymoney_diff")
    '    Me.C1DBG.Columns("tallyprice_diff").FooterText = Me.C1DBG.Columns("tallyprice").FooterText - Me.C1DBG.Columns("tallyprice_last").FooterText
    '    'Grid列宽
    '    For j = 0 To C1DBG.Columns.Count - 1
    '        C1DBG.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
    '        C1DBG.Splits(0).DisplayColumns.Item(j).Width = 90
    '    Next

    '    Cursor = Cursors.Default
    'End Sub

    'dv的列数值合计
    Public Shared Function GetDataSum(ByVal dvData As DataView, ByVal strColName As String) As Decimal
        Dim i As Integer
        Dim fTotal As Decimal
        For i = 0 To dvData.Count - 1
            If Convert.IsDBNull(dvData(i)(strColName)) = False Then
                fTotal += dvData(i)(strColName)
            End If
        Next
        Return fTotal
    End Function

    Private Sub btnExportEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportEdit.Click
        Cursor = Cursors.WaitCursor
        If reportname = "" Then
            Return
        ElseIf reportname = "FeeVoyageCargo" Then
            Export_FeeVoyageCargo() '导出件杂货船舶明细
        ElseIf reportname = "fee_report_zdhz" Then
            Export_fee_report_zdhz()   '导出重点货种统计
        ElseIf reportname = "fee_report_cbtj" Then
            Export_fee_report_cbtj()   '导出重点货种统计
        End If
        Cursor = Cursors.Default
    End Sub

    '导出件杂货明细
    Private Sub Export_FeeVoyageCargo()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer
        Dim ds As New DataSet
        Try
            RecordExcelProcess()
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "中理月度统计综合报表.xls", pathstr + "Report.xls")
            Filepath = pathstr + "report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("理货月报1"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = False
          
            xlsheet.Select()
            ds.Reset()
            ds = dsFeeVoyageCargo
            xlsheet.Cells(3, 2) = G_DeptName
            xlsheet.Cells(3, 5) = dtpreporttime.Value
            xlsheet.Cells(3, 8) = Date.Now

            Me.C1DBG.MoveFirst()
            '**************填数据
            For row = 0 To C1DBG.RowCount
                If row = 2 Or row = 5 Then
                    Continue For
                End If
                For col = 1 To Me.C1DBG.Columns.Count - 1
                    xlsheet.Cells(row + 6, col) = Me.C1DBG.Columns(col).Text.ToString
                Next col
                Me.C1DBG.MoveNext()
            Next row
            'If Me.C1DBG.ColumnFooters = True Then '合计项
            '    For col = 0 To Me.C1DBG.Columns.Count - 1
            '        xlsheet.Cells(ds.Tables(0).Rows.Count + 4, col + 1) = Me.C1DBG.Columns(col).FooterText
            '    Next col
            'End If
            ''**************画边框
            'For row = 2 To ds.Tables(0).Rows.Count + 4
            '    xlsheet.Range(xlsheet.Cells(row, 1), xlsheet.Cells(row, C1DBG.Columns.Count)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 7
            'Next row
            'For col = 1 To C1DBG.Columns.Count + 1
            '    xlsheet.Range(xlsheet.Cells(3, col), xlsheet.Cells(ds.Tables(0).Rows.Count + 4, col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7
            'Next col
            'xlsheet.Cells(35, 2) = "制表人："
            'If Month(dtpreporttime.Value) = 12 Then
            '    xlsheet.Cells(ds.Tables(0).Rows.Count + 6, 7) = "制表日期：" & Year(dtpreporttime.Value) + 1 & "年1月1日"
            'Else
            '    xlsheet.Cells(ds.Tables(0).Rows.Count + 6, 7) = "制表日期：" & Year(dtpreporttime.Value) & "年" & Month(dtpreporttime.Value) & "月1日"
            'End If
            xlsheet.Application.Visible = True
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
            KillExcelProcess()
        End Try
    End Sub
     
    '导出重点货种统计
    Private Sub Export_fee_report_zdhz()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim rang As Excel.Range
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer
        Dim ds As New DataSet
        Try
            RecordExcelProcess()
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "重点货种统计表.xls", pathstr + "Report.xls")
            Filepath = pathstr + "report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("Sheet1"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = False
            xlsheet.Select()
            ds.Reset()
            ds = dszdhz
            xlsheet.Cells(2, 3) = ds.Tables(0).Rows(0)(1)
            xlsheet.Cells(2, 5) = ds.Tables(0).Rows(0)(2)
            xlsheet.Cells(2, 10) = Now()
            Me.C1DBG.MoveFirst()
            '**************填数据
            For row = 0 To C1DBG.RowCount - 1
                'xlsheet.Cells(row + 8, 1) = Me.C1DBG.Columns("xydw").Text.ToString
                xlsheet.Cells(row + 6, 1) = "'" + Me.C1DBG.Columns(3).Text.ToString
                xlsheet.Cells(row + 6, 2) = Me.C1DBG.Columns(4).Text.ToString
                xlsheet.Cells(row + 6, 3) = Me.C1DBG.Columns(5).Text.ToString
                xlsheet.Cells(row + 6, 4) = Me.C1DBG.Columns(6).Text.ToString
                xlsheet.Cells(row + 6, 5) = Me.C1DBG.Columns(7).Text.ToString
                xlsheet.Cells(row + 6, 6) = Me.C1DBG.Columns(8).Text.ToString
                xlsheet.Cells(row + 6, 7) = Me.C1DBG.Columns(9).Text.ToString
                xlsheet.Cells(row + 6, 8) = Me.C1DBG.Columns(10).Text.ToString
                xlsheet.Cells(row + 6, 9) = Me.C1DBG.Columns(11).Text.ToString
                xlsheet.Cells(row + 6, 10) = Me.C1DBG.Columns(12).Text.ToString
                xlsheet.Cells(row + 6, 11) = Me.C1DBG.Columns(13).Text.ToString
                Me.C1DBG.MoveNext()
            Next row

            xlsheet.Application.Visible = True
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
            KillExcelProcess()
        End Try
    End Sub

    '导出件杂货明细
    Private Sub Export_fee_report_cbtj()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer
        Dim ds As New DataSet
        Try
            RecordExcelProcess()
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "月度统计报表.xls", pathstr + "Report.xls")
            Filepath = pathstr + "report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("船舶统计"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = False

            xlsheet.Select()
            ds.Reset()
            ds = dscbtj
            xlsheet.Cells(2, 3) = G_DeptName
            xlsheet.Cells(2, 12) = dtpreporttime.Value
            'xlsheet.Cells(3, 8) = Date.Now

            Me.C1DBG.MoveFirst()
            '**************填数据
            For row = 0 To C1DBG.RowCount - 1
                For col = 0 To Me.C1DBG.Columns.Count - 1
                    xlsheet.Cells(row + 5, col+1) = Me.C1DBG.Columns(col).Text.ToString
                Next col
                Me.C1DBG.MoveNext()
            Next row
            If Me.C1DBG.ColumnFooters = True Then '合计项
                For col = 0 To Me.C1DBG.Columns.Count - 1
                    xlsheet.Cells(ds.Tables(0).Rows.Count + 4, col + 1) = Me.C1DBG.Columns(col).FooterText
                Next col
            End If
            '**************画边框
            For row = 2 To ds.Tables(0).Rows.Count + 4
                xlsheet.Range(xlsheet.Cells(row, 1), xlsheet.Cells(row, C1DBG.Columns.Count)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 7
            Next row
            For col = 1 To C1DBG.Columns.Count + 1
                xlsheet.Range(xlsheet.Cells(3, col), xlsheet.Cells(ds.Tables(0).Rows.Count + 4, col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7
            Next col

            xlsheet.Application.Visible = True
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
            KillExcelProcess()
        End Try
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        TBar = 1
        Mnu = 1
        Me.Close()
    End Sub

    Private Sub FrmReportNew_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        TBar = 1
        Mnu = 1
        connstr = conn
        sqlconn.Close()
        sqlconn.ConnectionString = conn
    End Sub

    Private Sub btnFeeInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFeeInput.Click
        clear_info()
        If G_DeptCode = "26.11.11" Then
            dept = "1"
        Else
            dept = "2"
        End If
        dvmx = Getdata("select * from reportdata_jzh_zhtj where datediff(mm,datatime,'" & dtpreporttime.Value & "')=0 and dept=" & dept, dsmx)
        If dsmx.Tables(0).Rows.Count > 0 Then
            TextBox1.Text = dsmx.Tables(0).Rows(0)("hzwtsc")
            TextBox2.Text = dsmx.Tables(0).Rows(0)("hzwtds")
            TextBox3.Text = dsmx.Tables(0).Rows(0)("hzwtsr")
            TextBox4.Text = dsmx.Tables(0).Rows(0)("shlhsc")
            TextBox5.Text = dsmx.Tables(0).Rows(0)("shlhds")
            TextBox6.Text = dsmx.Tables(0).Rows(0)("shlhsr")
            'TextBox7.Text = dsmx.Tables(0).Rows(0)("wmsc")
            'TextBox8.Text = dsmx.Tables(0).Rows(0)("wmds")
            'TextBox9.Text = dsmx.Tables(0).Rows(0)("wmsr")
            'TextBox10.Text = dsmx.Tables(0).Rows(0)("nzxsc")
            'TextBox11.Text = dsmx.Tables(0).Rows(0)("nzxds")
            'TextBox12.Text = dsmx.Tables(0).Rows(0)("nzxsr")
            'TextBox13.Text = dsmx.Tables(0).Rows(0)("nmsc")
            'TextBox14.Text = dsmx.Tables(0).Rows(0)("nmds")
            'TextBox15.Text = dsmx.Tables(0).Rows(0)("nmsr")
            'TextBox16.Text = dsmx.Tables(0).Rows(0)("qtsc")
            'TextBox17.Text = dsmx.Tables(0).Rows(0)("qtds")
            'TextBox18.Text = dsmx.Tables(0).Rows(0)("qtsr")
        End If
        Panel4.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If dsmx.Tables(0).Rows.Count > 0 Then
            ExecSql("UPDATE reportdata_jzh_zhtj SET hzwtsc=" & TextBox1.Text & ", hzwtds=" & TextBox2.Text & ", hzwtsr=" & TextBox3.Text & ", shlhsc=" & TextBox4.Text & ", shlhds=" & TextBox5.Text & ", shlhsr=" & TextBox6.Text & ", wmsc=" & TextBox7.Text & ", wmds=" & TextBox8.Text & ", wmsr=" & TextBox9.Text & ", nzxsc=" & TextBox10.Text & ", nzxds=" & TextBox11.Text & ", nzxsr=" & TextBox12.Text & ", nmsc=" & TextBox13.Text & ", nmds=" & TextBox14.Text & ", nmsr=" & TextBox15.Text & ", qtsc=" & TextBox16.Text & ", qtds=" & TextBox17.Text & ", qtsr=" & TextBox18.Text & " where datediff(mm,datatime,'" & dtpreporttime.Value & "')=0 and dept=" & dept)
        Else
            ExecSql("INSERT reportdata_jzh_zhtj(dateinputtime, datatime, dept, hzwtsc, hzwtds, hzwtsr, shlhsc, shlhds, shlhsr, wmsc, wmds, wmsr, nzxsc, nzxds, nzxsr, nmsc, nmds, nmsr, qtsc, qtds, qtsr) VALUES('" & Date.Now() & "', '" & dtpreporttime.Value & "', '" & dept & "', " & TextBox1.Text & ", " & TextBox2.Text & ", " & TextBox3.Text & ", " & TextBox4.Text & ", " & TextBox5.Text & ", " & TextBox6.Text & ", " & TextBox7.Text & ", " & TextBox8.Text & ", " & TextBox9.Text & ", " & TextBox10.Text & ", " & TextBox11.Text & ", " & TextBox12.Text & ", " & TextBox13.Text & ", " & TextBox14.Text & ", " & TextBox15.Text & ", " & TextBox16.Text & "," & TextBox17.Text & "," & TextBox18.Text & ")")
        End If
        Panel4.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Panel4.Visible = False
    End Sub

    Private Sub clear_info()
        TextBox1.Text = 0
        TextBox2.Text = 0
        TextBox3.Text = 0
        TextBox4.Text = 0
        TextBox5.Text = 0
        TextBox6.Text = 0
        TextBox7.Text = 0
        TextBox8.Text = 0
        TextBox9.Text = 0
        TextBox10.Text = 0
        TextBox11.Text = 0
        TextBox12.Text = 0
        TextBox13.Text = 0
        TextBox14.Text = 0
        TextBox15.Text = 0
        TextBox16.Text = 0
        TextBox17.Text = 0
        TextBox18.Text = 0
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Cursor = Cursors.WaitCursor
        dvcbtj = Getdata("SELECT a.file_no,a.chi_vessel,a.voyage,a.shipagent_short,a.ioport,a.port_cha,c.berthno,a.amount,a.tons,a.fee_money MONEY,b.begindate,b.beginheader,b.enddate,b.endheader FROM reportdata_Feedetail a ,(SELECT A.Ship_ID, MAX(B.Work_NO) BeginWorkNo, MAX(B.Name) BeginHeader, MAX(A.beginDate) beginDate, MAX(C.Work_NO) EndWordNo, MAX(C.Name) EndHeader, MAX(A.EndDate) EndDate FROM (SELECT SHIP_ID, MIN(WORK_DAY) beginDate, MAX(WORK_DAY) EndDate FROM TALLY_TEAM WHERE Work_NO IS NOT NULL GROUP BY SHIP_ID) A LEFT JOIN View_TallyHeader B ON A.Ship_ID = B.Ship_ID AND A.beginDate = B.WORK_DAY LEFT JOIN View_TallyHeader C ON A.Ship_ID = C.Ship_ID AND A.EndDate = C.WORK_DAY GROUP BY A.ship_ID) b ,sship c where a.ship_id=b.ship_id and datediff(mm,datatime,'" & dtpreporttime.Value & "')=0 and datatype=1 and dept_short='" & dept & "' and a.file_no is not null and a.ship_id=c.ship_id ", dscbtj)
        Me.C1DBG.DataSource = dvcbtj
        reportname = "fee_report_cbtj"
        'Grid设置
        Me.C1DBG.Caption = Me.Button3.Text
        Me.C1DBG.Columns("FILE_NO").Caption = "档案号"
        Me.C1DBG.Columns("CHI_VESSEL").Caption = "船名"
        Me.C1DBG.Columns("VOYAGE").Caption = "航次"
        Me.C1DBG.Columns("shipagent_short").Caption = "船代"
        Me.C1DBG.Columns("ioport").Caption = "进/出"
        Me.C1DBG.Columns("port_cha").Caption = "装卸港"
        Me.C1DBG.Columns("berthno").Caption = "泊位"
        Me.C1DBG.Columns("Amount").Caption = "件数"
        Me.C1DBG.Columns("Tons").Caption = "吨数"
        Me.C1DBG.Columns("MONEY").Caption = "收入"
     
        Me.C1DBG.Columns("begindate").Caption = "开工时间"
        Me.C1DBG.Columns("BeginHeader").Caption = "接船组长"
        Me.C1DBG.Columns("enddate").Caption = "完工时间"
        Me.C1DBG.Columns("endheader").Caption = "完船组长"
        'Me.C1DBG.Splits(0).DisplayColumns("datatype").Visible = False
        'Me.C1DBG.Columns("WORKTIME_END").NumberFormat = "yy年MM月dd日"
        SetDGWidth(Me.C1DBG, 4)
        'Grid单列统计
        Me.C1DBG.Columns("Amount").FooterText = GetDataSum(dvcbtj, "Amount")
        Me.C1DBG.Columns("Tons").FooterText = GetDataSum(dvcbtj, "Tons")
        Me.C1DBG.Columns("MONEY").FooterText = GetDataSum(dvcbtj, "MONEY")
        Me.C1DBG.Columns("FILE_NO").FooterText = "合计"
        Me.C1DBG.Columns("CHI_VESSEL").FooterText = dvcbtj.Count
        Cursor = Cursors.Default
    End Sub

End Class