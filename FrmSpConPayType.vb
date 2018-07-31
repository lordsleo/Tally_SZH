Imports TALLY.DBControl
Public Class FrmSpConPayType
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnCancle As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents cbManager As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents c1dbg As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cbPayType As System.Windows.Forms.ComboBox
    Friend WithEvents dtEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtStart As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmSpConPayType))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = CType(New C1.Win.C1TrueDBGrid.Util.GridLines, C1.Win.C1TrueDBGrid.Util.GridLines)
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbPayType = New System.Windows.Forms.ComboBox
        Me.btnEnter = New System.Windows.Forms.Button
        Me.btnCancle = New System.Windows.Forms.Button
        Me.btnExport = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.cbManager = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.c1dbg = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.dtEnd = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtStart = New System.Windows.Forms.DateTimePicker
        CType(Me.c1dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(238, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "结算形式："
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbPayType
        '
        Me.cbPayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPayType.Items.AddRange(New Object() {"现金", "转帐"})
        Me.cbPayType.Location = New System.Drawing.Point(320, 15)
        Me.cbPayType.Name = "cbPayType"
        Me.cbPayType.Size = New System.Drawing.Size(84, 20)
        Me.cbPayType.TabIndex = 4
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(620, 13)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(65, 24)
        Me.btnEnter.TabIndex = 8
        Me.btnEnter.Text = "确认"
        '
        'btnCancle
        '
        Me.btnCancle.Location = New System.Drawing.Point(620, 44)
        Me.btnCancle.Name = "btnCancle"
        Me.btnCancle.Size = New System.Drawing.Size(65, 24)
        Me.btnCancle.TabIndex = 8
        Me.btnCancle.Text = "取消"
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(706, 13)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(65, 24)
        Me.btnExport.TabIndex = 8
        Me.btnExport.Text = "导出"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(706, 44)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(65, 24)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "打印"
        '
        'cbManager
        '
        Me.cbManager.Location = New System.Drawing.Point(494, 15)
        Me.cbManager.Name = "cbManager"
        Me.cbManager.Size = New System.Drawing.Size(84, 20)
        Me.cbManager.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(438, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "部门主管"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.c1dbg.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.c1dbg.Location = New System.Drawing.Point(0, 97)
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
        Me.c1dbg.Size = New System.Drawing.Size(1020, 586)
        Me.c1dbg.TabIndex = 9
        Me.c1dbg.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        ", 0, 1016, 582</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style" & _
        "2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle paren" & _
        "t=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><Foo" & _
        "terStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /" & _
        "><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""Highlig" & _
        "htRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle" & _
        " parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""" & _
        "Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style parent=""Normal""" & _
        " me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style pare" & _
        "nt="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading" & _
        """ me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" m" & _
        "e=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=" & _
        """Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=" & _
        """EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""Rec" & _
        "ordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" m" & _
        "e=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><L" & _
        "ayout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, " & _
        "1016, 582</ClientArea></Blob>"
        '
        'dtEnd
        '
        Me.dtEnd.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtEnd.Location = New System.Drawing.Point(458, 55)
        Me.dtEnd.Name = "dtEnd"
        Me.dtEnd.Size = New System.Drawing.Size(120, 21)
        Me.dtEnd.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(442, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "到"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(238, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "统计期限：从"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtStart
        '
        Me.dtStart.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtStart.Location = New System.Drawing.Point(320, 55)
        Me.dtStart.Name = "dtStart"
        Me.dtStart.Size = New System.Drawing.Size(120, 21)
        Me.dtStart.TabIndex = 13
        '
        'FrmSpConPayType
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(1020, 683)
        Me.Controls.Add(Me.dtEnd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtStart)
        Me.Controls.Add(Me.c1dbg)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.cbPayType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancle)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.cbManager)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSpConPayType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "装验箱统计报表"
        CType(Me.c1dbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim i, j As Integer
    Dim dsResult As New DataSet
    Dim printed As Boolean = False
    Dim export As Boolean = False
    Dim PageNumber As Integer = 0 ' 打印的页数
    Dim row, col As Integer
    Dim payType As Integer = 0
  

    Private Sub FrmSpConPayType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '结算形式
        
        '部门主管
        Dim dsManager As New DataSet
        Getdata("select name from code_manager", dsManager)
        For i = 0 To dsManager.Tables(0).Rows.Count - 1
            Me.cbManager.Items.Add(dsManager.Tables(0).Rows(i).Item(0))
        Next

    End Sub
    Private Sub caption()
        Me.c1dbg.Columns.Item("shipagent_short").Caption = "船货代名称"
    End Sub

    Private Sub columnswidth()
        Dim j As Integer
        For j = 0 To Me.c1dbg.Columns.Count - 1
            Me.c1dbg.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.c1dbg.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width < 15 Then
                Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width = 15
            Else
                If Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If

        Next
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        PageNumber = 0
        printed = False
        export = False
        '结算形式
        If Me.cbPayType.Text = "现金" Then
            payType = 0
        Else
            payType = 1
        End If
        Me.c1dbg.DataSource = Getdata("exec spconpaytype '" & payType & "','" & Me.dtStart.Value & "','" & Me.dtEnd.Value & "'", dsResult)
        '少于28条记录，一页打印
        If CType(dsResult.Tables(0).Rows.Count, Single) / 28.0 <= 1 Then
            PageNumber = 1
        End If
        '29到56条记录，二页打印
        If CType(dsResult.Tables(0).Rows.Count, Single) / 28.0 > 1 And CType(dsResult.Tables(0).Rows.Count, Single) / 28.0 <= 2 Then
            PageNumber = 2
        End If
        '57到84条记录，三页打印
        If CType(dsResult.Tables(0).Rows.Count, Single) / 28.0 > 2 And CType(dsResult.Tables(0).Rows.Count, Single) / 28.0 <= 3 Then
            PageNumber = 3
        End If
        '85到112条记录，四页打印
        If CType(dsResult.Tables(0).Rows.Count, Single) / 28.0 > 3 And CType(dsResult.Tables(0).Rows.Count, Single) / 28.0 <= 4 Then
            PageNumber = 4
        End If

        'TOTAL
        Me.c1dbg.ColumnFooters = True
        Me.c1dbg.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.c1dbg.Columns.Item("shipagent_short").FooterText = "TOTAL"
        Dim sum As Decimal = 0
        For j = 1 To Me.c1dbg.Columns.Count - 1
            sum = 0
            For i = 0 To dsResult.Tables(0).Rows.Count - 1
                sum = sum + IIf(dsResult.Tables(0).Rows(i).Item(j) Is System.DBNull.Value, 0, dsResult.Tables(0).Rows(i).Item(j))
            Next
            If sum > 0 Then
                Me.c1dbg.Columns.Item(j).FooterText = sum
            End If
        Next
        caption()
        columnswidth()
    End Sub

    Private Sub btnCancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancle.Click
        Me.Close()
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Dim PathStr As String
        Dim FilePath As String

        export = True
        printed = False

        PathStr = CurDir()
        Try
            FileCopy(PathStr + "\zwxConStat.xls", PathStr + "\copy_zwxConStat.xls")
            FilePath = PathStr + "\copy_zwxConStat.xls"
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)

            funcMorePage()

        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub
 
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        '记录EXCEL进程
        RecordExcelProcess()

        Dim PathStr As String
        Dim FilePath As String

        export = False
        printed = True

        PathStr = CurDir()
        Try
            FileCopy(PathStr + "\zwxConStat.xls", PathStr + "\copy_zwxConStat.xls")
            FilePath = PathStr + "\copy_zwxConStat.xls"
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)

            funcMorePage()

            '清除EXCEL进程
            KillExcelProcess()
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub funcMorePage()
        xlApp.DisplayAlerts = False
        Dim j As Integer
        Dim dataCount As Integer '当前页打印的数据条数
        Dim dsRow As Integer ''当前页打印的数据在数据集中的行数
        '判断是否有打印页
        If PageNumber > 0 Then
            '翻页循环
            dataCount = 28
            For j = 1 To PageNumber
                If j < PageNumber Then
                    '第一页
                    If j = 1 Then
                        xlSheet = CType(xlBook.Worksheets("结算统计1"), Excel.Worksheet)

                        If export = True Then
                            xlSheet.Application.Visible = True
                            xlBook.Worksheets("结算统计1").select()
                        End If
                        If printed = True Then
                            xlSheet.Application.Visible = False
                        End If
                    End If
                    '第二页
                    If j = 2 Then
                        xlSheet = CType(xlBook.Worksheets("结算统计2"), Excel.Worksheet)

                        If export = True Then
                            xlSheet.Application.Visible = True
                            xlBook.Worksheets("结算统计2").select()
                        End If
                        If printed = True Then
                            xlSheet.Application.Visible = False
                        End If
                    End If
                    '第二页
                    If j = 3 Then
                        xlSheet = CType(xlBook.Worksheets("结算统计3"), Excel.Worksheet)

                        If export = True Then
                            xlSheet.Application.Visible = True
                            xlBook.Worksheets("结算统计3").select()
                        End If
                        If printed = True Then
                            xlSheet.Application.Visible = False
                        End If
                    End If
                    row = 0 '写数据
                    For dsRow = dataCount * (j - 1) To dataCount * j - 1 '数据
                        '数据
                        row = row + 1
                        For col = 0 To Me.c1dbg.Columns.Count - 1
                            xlSheet.Cells(row + 6, col + 2) = dsResult.Tables(0).Rows(dsRow).Item(col)
                        Next col
                    Next dsRow
                Else
                    '最后一页
                    xlSheet = CType(xlBook.Worksheets("结算统计4"), Excel.Worksheet)

                    If export = True Then
                        xlSheet.Application.Visible = True
                        xlBook.Worksheets("结算统计4").select()
                    End If
                    If printed = True Then
                        xlSheet.Application.Visible = False
                    End If
                    row = 0 '写数据
                    For dsRow = dataCount * (j - 1) To dsResult.Tables(0).Rows.Count - 1  '数据
                        '数据
                        row = row + 1
                        For col = 0 To Me.c1dbg.Columns.Count - 1
                            xlSheet.Cells(row + 6, col + 2) = dsResult.Tables(0).Rows(dsRow).Item(col)
                        Next col
                    Next dsRow
                    '写合计TOTAL
                    For i = 1 To Me.c1dbg.Columns.Count - 1
                        xlSheet.Cells(35, i + 2) = Me.c1dbg.Columns.Item(i).FooterText
                    Next
                    '统计员
                    xlSheet.Cells(37, 3) = G_User
                    '部门主管
                    xlSheet.Cells(37, 12) = Me.cbManager.Text
                    '制单日期
                    xlSheet.Cells(37, 23) = Today
                End If
                '装箱类型.
                xlSheet.Cells(2, 3) = Me.cbPayType.Text
                '统计期限开始时间
                xlSheet.Cells(2, 12) = Me.dtStart.Value
                '结束时间
                xlSheet.Cells(2, 17) = Me.dtEnd.Value
                '第几页
                xlSheet.Cells(2, 25) = j
                '共几页
                xlSheet.Cells(2, 28) = PageNumber

                If printed = True Then
                    xlSheet.PrintOut()
                End If
            Next '翻页循环
        End If
    End Sub

End Class
