Imports TALLY.DBControl
Public Class Frmreport_cargo
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet
    Dim i As Integer = 0
    Dim j As Integer = 0
    Dim row As Integer
    Dim runtime As Integer = 0


#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_export As System.Windows.Forms.Button
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents btn_cancle As System.Windows.Forms.Button
    Friend WithEvents btn_enter As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CmbDEPT_CODE As System.Windows.Forms.ComboBox
    Friend WithEvents DTPDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frmreport_cargo))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.CmbDEPT_CODE = New System.Windows.Forms.ComboBox
        Me.btn_export = New System.Windows.Forms.Button
        Me.btn_print = New System.Windows.Forms.Button
        Me.btn_cancle = New System.Windows.Forms.Button
        Me.btn_enter = New System.Windows.Forms.Button
        Me.DTPDate = New System.Windows.Forms.DateTimePicker
        Me.Label18 = New System.Windows.Forms.Label
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.GroupBox1.SuspendLayout()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.CmbDEPT_CODE)
        Me.GroupBox1.Controls.Add(Me.btn_export)
        Me.GroupBox1.Controls.Add(Me.btn_print)
        Me.GroupBox1.Controls.Add(Me.btn_cancle)
        Me.GroupBox1.Controls.Add(Me.btn_enter)
        Me.GroupBox1.Controls.Add(Me.DTPDate)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(702, 78)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(10, 52)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(85, 20)
        Me.Label22.TabIndex = 71
        Me.Label22.Text = "部门名称"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbDEPT_CODE
        '
        Me.CmbDEPT_CODE.Location = New System.Drawing.Point(118, 52)
        Me.CmbDEPT_CODE.Name = "CmbDEPT_CODE"
        Me.CmbDEPT_CODE.Size = New System.Drawing.Size(112, 20)
        Me.CmbDEPT_CODE.TabIndex = 5
        '
        'btn_export
        '
        Me.btn_export.Location = New System.Drawing.Point(424, 38)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(65, 24)
        Me.btn_export.TabIndex = 1
        Me.btn_export.Text = "导出"
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(508, 38)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(65, 24)
        Me.btn_print.TabIndex = 2
        Me.btn_print.Text = "打印"
        '
        'btn_cancle
        '
        Me.btn_cancle.Location = New System.Drawing.Point(592, 38)
        Me.btn_cancle.Name = "btn_cancle"
        Me.btn_cancle.Size = New System.Drawing.Size(65, 24)
        Me.btn_cancle.TabIndex = 3
        Me.btn_cancle.Text = "取消"
        '
        'btn_enter
        '
        Me.btn_enter.Location = New System.Drawing.Point(340, 38)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(65, 24)
        Me.btn_enter.TabIndex = 0
        Me.btn_enter.Text = "确定"
        '
        'DTPDate
        '
        Me.DTPDate.CustomFormat = "  yyyy年  MM月"
        Me.DTPDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPDate.Location = New System.Drawing.Point(118, 20)
        Me.DTPDate.Name = "DTPDate"
        Me.DTPDate.Size = New System.Drawing.Size(112, 21)
        Me.DTPDate.TabIndex = 4
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(10, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 20)
        Me.Label18.TabIndex = 66
        Me.Label18.Text = "统计时间"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = True
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1DBG.AllowSort = True
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.CollapseColor = System.Drawing.Color.Black
        Me.C1DBG.DataChanged = False
        Me.C1DBG.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBG.ExpandColor = System.Drawing.Color.Black
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(2, 82)
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
        Me.C1DBG.Size = New System.Drawing.Size(702, 428)
        Me.C1DBG.TabIndex = 1
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Center;Borde" & _
        "r:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCaptionHeight=""18"" Colu" & _
        "mnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" Def" & _
        "RecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRect>0" & _
        ", 0, 698, 424</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2" & _
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
        "yout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 6" & _
        "98, 424</ClientArea></Blob>"
        '
        'Frmreport_cargo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(706, 511)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmreport_cargo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "理货月度统计综合报表（一）"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub FillDEPT_CODE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "select DEPT_CODE,DEPT_NAME from DEPARTMENT where dept_code like '26.11.1%'"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbDEPT_CODE.DataSource = dvc
        Me.CmbDEPT_CODE.DisplayMember = "DEPT_NAME"
        Me.CmbDEPT_CODE.ValueMember = "DEPT_CODE"
    End Sub

    Private Sub btn_enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enter.Click
        Getdata("exec SPTALLY_GENERAL_CARGO '" & CmbDEPT_CODE.SelectedValue & "','" & DTPDate.Value & "'", ds)

        For i = 0 To 3
            If ds.Tables(0).Rows(i).Item("SHIPAGENT_SHORT") Is System.DBNull.Value Then
                runtime = runtime + 1
            End If
            If ds.Tables(0).Rows(i).Item("idd") Is System.DBNull.Value Then
                ds.Tables(0).Rows(i).Item("SHIPAGENT_SHORT") = "其他船代"
            Else
                If ds.Tables(0).Rows(i).Item("idd") = " 1" Then
                    ds.Tables(0).Rows(i).Item("SHIPAGENT_SHORT") = "件杂货（进口）"
                End If
                If ds.Tables(0).Rows(i).Item("idd") = " 2" Then
                    ds.Tables(0).Rows(i).Item("SHIPAGENT_SHORT") = "件杂货（出口）"
                End If
                If ds.Tables(0).Rows(i).Item("idd") = " 4" Then
                    ds.Tables(0).Rows(i).Item("SHIPAGENT_SHORT") = "散化理货"
                End If
            End If
        Next

        Me.C1DBG.DataSource = ds.Tables(0)

        Me.C1DBG.Splits(0).DisplayColumns.Item("idd").Visible = False
        Me.C1DBG.Columns.Item("SHIPAGENT_SHORT").Caption = "船代名称"
        Me.C1DBG.Columns.Item("shipamount").Caption = "艘次"
        Me.C1DBG.Columns.Item("shipamount_total").Caption = "累计艘次"
        Me.C1DBG.Columns.Item("tons").Caption = "吨数"
        Me.C1DBG.Columns.Item("tons_total").Caption = "累计吨数"
        Me.C1DBG.Columns.Item("income").Caption = "收入"
        Me.C1DBG.Columns.Item("income_total").Caption = "累计收入"

        For j = 0 To Me.C1DBG.Columns.Count - 1
            Me.C1DBG.Splits(0).DisplayColumns.Item(j).AutoSize()
            If Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width < 60 Then
                Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width = 60
            Else
                If Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If
        Next


    End Sub

    Private Sub Frmreport_cargo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillDEPT_CODE()
        If G_DeptCode = "26.11" Then
            CmbDEPT_CODE.Enabled = True
        Else
            CmbDEPT_CODE.SelectedValue = G_DeptCode
            CmbDEPT_CODE.Enabled = False
        End If
    End Sub

    Private Sub btn_cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancle.Click
        Me.Close()
    End Sub

    Private Sub btn_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_export.Click
        MakeExcel()
    End Sub

    Private Sub MakeExcel()
        Dim PathStr As String
        Dim FilePath As String
        Dim Row As Integer
        Dim Col As Integer
        Dim flag As Integer
        Dim row_ii As Integer = 9

        PathStr = CurDir()
        Try
            FileCopy(PathStr + "\REPORT_GENERAL_CARGO.xls", PathStr + "\Report.xls")
            FilePath = PathStr + "\Report.xls"
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)
            xlSheet = CType(xlBook.Worksheets(1), Excel.Worksheet)
            xlApp.DisplayAlerts = False
            xlSheet.Application.Visible = True

            xlSheet.Cells(1, 2) = "中国外轮理货总公司连云港分公司 " & CmbDEPT_CODE.Text
            xlSheet.Cells(2, 8) = DTPDate.Text
            flag = 4
            Me.C1DBG.MoveFirst()
            For Row = 0 To ds.Tables(0).Rows.Count - 1 '填充数据

                If Row >= runtime Then
                    For Col = 1 To Me.C1DBG.Columns.Count - 1
                        xlSheet.Cells(row_ii, Col) = Me.C1DBG.Columns(Col).Text.ToString
                    Next Col
                    row_ii = row_ii + 1
                Else
                    If (Me.C1DBG.Columns.Item("idd").Value Is System.DBNull.Value) = False Then

                        For Col = 1 To Me.C1DBG.Columns.Count - 1
                            xlSheet.Cells(Row + flag, Col) = Me.C1DBG.Columns(Col).Text.ToString
                        Next Col

                        If Me.C1DBG.Columns.Item("idd").Value = " 2" Then
                            flag = flag + 1
                        End If
                        If Me.C1DBG.Columns.Item("idd").Value = " 4" Then
                            flag = flag + 1
                        End If
                    Else
                        flag = flag - 1
                    End If
                End If
                Me.C1DBG.MoveNext()
            Next Row
            xlSheet.Cells(row_ii, 1) = "部门经理："
            xlSheet.Cells(row_ii, 4) = "统计员："
            xlSheet.Cells(row_ii, 8) = "统1"

            For Row = 3 To row_ii '画行
                xlSheet.Range(xlSheet.Cells(Row, 1), xlSheet.Cells(Row, C1DBG.Columns.Count)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = 7
            Next Row
            For Col = 1 To C1DBG.Columns.Count + 1 '画列
                xlSheet.Range(xlSheet.Cells(3, Col), xlSheet.Cells(row_ii - 1, Col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7
            Next Col

        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print.Click
        '记录EXCEL进程
        RecordExcelProcess()

        Dim PathStr As String
        Dim FilePath As String
        Dim Row As Integer
        Dim Col As Integer
        Dim flag As Integer
        Dim row_ii As Integer = 9

        PathStr = CurDir()
        Try
            FileCopy(PathStr + "\REPORT_GENERAL_CARGO.xls", PathStr + "\Report.xls")
            FilePath = PathStr + "\Report.xls"
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)
            xlSheet = CType(xlBook.Worksheets(1), Excel.Worksheet)
            xlApp.DisplayAlerts = False
            xlSheet.Application.Visible = False

            xlSheet.Cells(1, 2) = "中国外轮理货总公司连云港分公司 " & CmbDEPT_CODE.Text
            xlSheet.Cells(2, 8) = DTPDate.Text
            flag = 4
            Me.C1DBG.MoveFirst()
            For Row = 0 To ds.Tables(0).Rows.Count - 1 '填充数据

                If Row >= runtime Then
                    For Col = 1 To Me.C1DBG.Columns.Count - 1
                        xlSheet.Cells(row_ii, Col) = Me.C1DBG.Columns(Col).Text.ToString
                    Next Col
                    row_ii = row_ii + 1
                Else
                    If (Me.C1DBG.Columns.Item("idd").Value Is System.DBNull.Value) = False Then

                        For Col = 1 To Me.C1DBG.Columns.Count - 1
                            xlSheet.Cells(Row + flag, Col) = Me.C1DBG.Columns(Col).Text.ToString
                        Next Col

                        If Me.C1DBG.Columns.Item("idd").Value = " 2" Then
                            flag = flag + 1
                        End If
                        If Me.C1DBG.Columns.Item("idd").Value = " 4" Then
                            flag = flag + 1
                        End If
                    Else
                        flag = flag - 1
                    End If
                End If
                Me.C1DBG.MoveNext()
            Next Row

            xlSheet.Cells(row_ii, 1) = "部门经理："
            xlSheet.Cells(row_ii, 4) = "统计员："
            xlSheet.Cells(row_ii, 8) = "统1"

            For Row = 3 To row_ii '画行
                xlSheet.Range(xlSheet.Cells(Row, 1), xlSheet.Cells(Row, C1DBG.Columns.Count)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = 7
            Next Row
            For Col = 1 To C1DBG.Columns.Count + 1 '画列
                xlSheet.Range(xlSheet.Cells(3, Col), xlSheet.Cells(row_ii - 1, Col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7
            Next Col


            xlSheet.PrintOut()
            xlApp.Quit()
            KillExcelProcess()

        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub
End Class