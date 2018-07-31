Imports TALLY.DBControl
Public Class Frm_tally_work_stat_month
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
    Friend WithEvents c1dbg As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents dt_month As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_enter As System.Windows.Forms.Button
    Friend WithEvents btn_cancle As System.Windows.Forms.Button
    Friend WithEvents btn_export As System.Windows.Forms.Button
    Friend WithEvents btn_print As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_tally_work_stat_month))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = CType(New C1.Win.C1TrueDBGrid.Util.GridLines(), C1.Win.C1TrueDBGrid.Util.GridLines)
        Me.c1dbg = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.btn_enter = New System.Windows.Forms.Button()
        Me.btn_cancle = New System.Windows.Forms.Button()
        Me.dt_month = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_export = New System.Windows.Forms.Button()
        Me.btn_print = New System.Windows.Forms.Button()
        CType(Me.c1dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1dbg
        '
        Me.c1dbg.AllowFilter = True
        Me.c1dbg.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.c1dbg.AllowSort = True
        Me.c1dbg.CaptionHeight = 18
        Me.c1dbg.CollapseColor = System.Drawing.Color.Black
        Me.c1dbg.DataChanged = False
        Me.c1dbg.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.c1dbg.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.c1dbg.ExpandColor = System.Drawing.Color.Black
        Me.c1dbg.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1dbg.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.c1dbg.Location = New System.Drawing.Point(0, 52)
        Me.c1dbg.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.c1dbg.Name = "c1dbg"
        Me.c1dbg.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1dbg.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1dbg.PreviewInfo.ZoomFactor = 75
        Me.c1dbg.PrintInfo.ShowOptionsDialog = False
        Me.c1dbg.RecordSelectorWidth = 16
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.c1dbg.RowDivider = GridLines1
        Me.c1dbg.RowHeight = 16
        Me.c1dbg.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.c1dbg.ScrollTips = False
        Me.c1dbg.Size = New System.Drawing.Size(932, 497)
        Me.c1dbg.TabIndex = 0
        Me.c1dbg.Text = "C1TrueDBGrid1"
        Me.c1dbg.PropBag = CType(resources.GetObject("c1dbg.PropBag"), String)
        '
        'btn_enter
        '
        Me.btn_enter.Location = New System.Drawing.Point(315, 14)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(65, 24)
        Me.btn_enter.TabIndex = 1
        Me.btn_enter.Text = "确认"
        '
        'btn_cancle
        '
        Me.btn_cancle.Location = New System.Drawing.Point(400, 14)
        Me.btn_cancle.Name = "btn_cancle"
        Me.btn_cancle.Size = New System.Drawing.Size(65, 24)
        Me.btn_cancle.TabIndex = 2
        Me.btn_cancle.Text = "取消"
        '
        'dt_month
        '
        Me.dt_month.CustomFormat = "yyyy/MM"
        Me.dt_month.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_month.Location = New System.Drawing.Point(215, 16)
        Me.dt_month.Name = "dt_month"
        Me.dt_month.Size = New System.Drawing.Size(80, 21)
        Me.dt_month.TabIndex = 3
        Me.dt_month.Value = New Date(2004, 3, 23, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(145, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "统计月份"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_export
        '
        Me.btn_export.Location = New System.Drawing.Point(485, 14)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(65, 24)
        Me.btn_export.TabIndex = 2
        Me.btn_export.Text = "导出"
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(570, 14)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(65, 24)
        Me.btn_print.TabIndex = 1
        Me.btn_print.Text = "打印"
        '
        'Frm_tally_work_stat_month
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(932, 549)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label1, Me.dt_month, Me.btn_cancle, Me.btn_enter, Me.c1dbg, Me.btn_export, Me.btn_print})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_tally_work_stat_month"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "理货业务统计月报"
        CType(Me.c1dbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As New dataset()

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enter.Click
        Me.c1dbg.DataSource = Getdata("sp_tally_work_stat_month  '" & Me.dt_month.Value & "'", ds)
        caption()
        columnswidth()
    End Sub

    Private Sub caption()
        'Me.c1dbg.Splits(0).DisplayColumns.Item(0).Visible = False
        'Me.c1dbg.Splits(0).DisplayColumns.Item(1).Visible = False
        Me.c1dbg.Columns("number").Caption = "序号"
        Me.c1dbg.Columns("item").Caption = "项目"
        Me.c1dbg.Columns("unit").Caption = "单位"
        Me.c1dbg.Columns("inter_in_board").Caption = "国际进口_外轮"
        Me.c1dbg.Columns("inter_in_cosc").Caption = "国际进口_中远"
        Me.c1dbg.Columns("inter_in_other").Caption = "国际进口_其他"
        Me.c1dbg.Columns("inter_in_sum").Caption = "国际进口_小计"
        Me.c1dbg.Columns("inter_out_board").Caption = "国际出口_外轮"
        Me.c1dbg.Columns("inter_out_cosc").Caption = "国际出口_中远"
        Me.c1dbg.Columns("inter_out_other").Caption = "国际出口_其他"
        Me.c1dbg.Columns("inter_out_sum").Caption = "国际出口_小计"
        Me.c1dbg.Columns("inter_not_submit_in").Caption = "国际非委托_进口"
        Me.c1dbg.Columns("inter_not_submit_out").Caption = "国际非委托_出口"
        Me.c1dbg.Columns("inter_not_submit_sum").Caption = "国际非委托_小计"
        Me.c1dbg.Columns("national_submit_csc").Caption = "国内委托_中海"
        Me.c1dbg.Columns("national_submit_other").Caption = "国内委托_其他"
        Me.c1dbg.Columns("national_submit_sum").Caption = "国内委托_小计"
        Me.c1dbg.Columns("month_sum").Caption = "本月小计数"
        Me.c1dbg.Columns("year_sum").Caption = "累计完成数"
    End Sub

    Private Sub columnswidth()
        Dim j As Integer
        For j = 0 To Me.c1dbg.Columns.Count - 1
            Me.c1dbg.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.c1dbg.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width < 30 Then
                Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width = 30
            Else
                If Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If

        Next
        'Me.c1dbg.Splits(0).DisplayColumns.Item("fee_rate").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far
        'Me.c1dbg.Splits(0).DisplayColumns.Item("money").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far

        'Me.c1dbg.Splits(0).DisplayColumns.Item("no").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        'Me.c1dbg.Splits(0).DisplayColumns.Item("Descri").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        'Me.c1dbg.Splits(0).DisplayColumns.Item("Account_Type").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
    End Sub

    Private Sub btn_cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancle.Click
        Me.Close()
    End Sub

    Private Sub btn_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_export.Click
        MakeExcel()
    End Sub

    Private Sub btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print.Click

        Dim Row As Integer
        Dim Col As Integer

        Try
            Call MakeExcel()

            'Row = ds.Tables(0).Rows.Count + 6
            'Col = Me.c1dbg.Columns.Count
            ''**************画边框
            'For Row = 2 To ds.Tables(0).Rows.Count + 4 '画列
            '    xlSheet.Range(xlSheet.Cells(Row, 1), xlSheet.Cells(Row, c1dbg.Columns.Count - ColNum)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 7
            'Next Row
            'For Col = 1 To c1dbg.Columns.Count - ColNum + 1 '画行
            '    xlSheet.Range(xlSheet.Cells(3, Col), xlSheet.Cells(ds.Tables(0).Rows.Count + 4, Col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7
            'Next Col

        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub MakeExcel()
        Dim PathStr As String
        Dim FilePath As String
        Dim Row As Integer
        Dim Col As Integer
        PathStr = CurDir()
        Try
            FileCopy(PathStr + "\zhuweixin.xls", PathStr + "\copy_zhuweixin.xls")
            FilePath = PathStr + "\copy_zhuweixin.xls"
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)
            xlSheet = CType(xlBook.Worksheets("tally_work_stat_month"), Excel.Worksheet)
            xlApp.DisplayAlerts = False
            xlSheet.Application.Visible = True
            xlBook.Worksheets("tally_work_stat_month").select()
            '报表月份
            xlSheet.Cells(4, 6) = DatePart(DateInterval.Year, Me.dt_month.Value) & " 年 " & DatePart(DateInterval.Month, Me.dt_month.Value) & " 月份"
            '制单日期
            xlSheet.Cells(4, 12) = Today()
            Me.c1dbg.MoveFirst()
            For Row = 0 To ds.Tables(0).Rows.Count - 1 '数据
                For Col = 2 To Me.c1dbg.Columns.Count - 1
                    xlSheet.Cells(Row + 8, Col + 2) = Me.c1dbg.Columns(Col).Text.ToString     'ds.Tables(0).Rows(Row)(Col)
                Next Col
                Me.c1dbg.MoveNext()
            Next Row
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub
    Private Sub preview(ByVal Func As String) '***************权限设计
        'Dim sqlstr As String
        'Dim Previewdv As DataView
        'Dim Previewds As New DataSet()
        'Dim i As Integer
        'sqlstr = " select FUNC_CODE_Add,FUNC_CODE_Change,FUNC_CODE_Del from View_UserPreview where PART_ID=" & G_Part_Id & " and FUNC_CODE='" & Upper(Func) & "' "
        'Previewdv = Getdata(sqlstr, Previewds)
        'If Previewdv.Count > 0 Then
        '    If Previewdv(i)("FUNC_CODE_Add") = 1 Then 'ADD 按钮可见
        '        ToolBar.Buttons.Item(3).Enabled = True
        '        mnuAdd.Enabled = True
        '    Else                                      'ADD 按钮不可见
        '        Me.ToolBar.Buttons.Item(3).Enabled = False
        '        mnuAdd.Enabled = False
        '    End If
        '    If Previewdv(i)("FUNC_CODE_Change") = 1 Then '修改 按钮可见
        '        Me.ToolBar.Buttons.Item(4).Enabled = True
        '        mnuEdit.Enabled = True
        '    Else                                          '修改 按钮不可见
        '        Me.ToolBar.Buttons.Item(4).Enabled = False
        '        mnuEdit.Enabled = False
        '    End If
        '    If Previewdv(i)("FUNC_CODE_Del") = 1 Then '删除 按钮可见
        '        Me.ToolBar.Buttons.Item(5).Enabled = True
        '        mnuDelete.Enabled = True
        '    Else                                     '删除按钮不可见
        '        Me.ToolBar.Buttons.Item(5).Enabled = False
        '        mnuDelete.Enabled = False
        '    End If
        'End If

    End Sub
End Class
