Imports TALLY.DBControl
Imports Microsoft.VisualBasic

Public Class FRMCARGO_MONTH
    Inherits System.Windows.Forms.Form
    Dim dsShip As New DataSet() '船舶数据集
    Dim SqlStrShip As String  '船舶条件语句
    Dim FirmShip As String
    Dim SortShip As String
    Dim inoutstr As String
    Dim dw As New DataView()

    Dim ds As New DataSet()
    Dim SqlStr As String  '条件语句
    Dim SelectStr As String
    Dim DynaStr As String '可变的条件设计
    Dim FirmStr As String '不变的条件设计
    Dim ColNum As Integer '不显示的列数
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
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFind As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuery As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrint As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExport As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCompile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAdd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tbbtnDO As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnPrint As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuit As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRMCARGO_MONTH))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.MainMenu = New System.Windows.Forms.MainMenu
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuFind = New System.Windows.Forms.MenuItem
        Me.mnuQuery = New System.Windows.Forms.MenuItem
        Me.mnuSep1 = New System.Windows.Forms.MenuItem
        Me.mnuPrint = New System.Windows.Forms.MenuItem
        Me.mnuExport = New System.Windows.Forms.MenuItem
        Me.mnuSep2 = New System.Windows.Forms.MenuItem
        Me.mnuQuit = New System.Windows.Forms.MenuItem
        Me.mnuCompile = New System.Windows.Forms.MenuItem
        Me.mnuAdd = New System.Windows.Forms.MenuItem
        Me.mnuEdit = New System.Windows.Forms.MenuItem
        Me.mnuDelete = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.tbbtnDO = New System.Windows.Forms.ToolBarButton
        Me.tbbtnPrint = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuit = New System.Windows.Forms.ToolBarButton
        Me.ToolBar = New System.Windows.Forms.ToolBar
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList
        '
        Me.ImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuCompile, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFind, Me.mnuQuery, Me.mnuSep1, Me.mnuPrint, Me.mnuExport, Me.mnuSep2, Me.mnuQuit})
        Me.mnuFile.Text = "文件(&F)"
        '
        'mnuFind
        '
        Me.mnuFind.Enabled = False
        Me.mnuFind.Index = 0
        Me.mnuFind.Text = "检索(&F)"
        '
        'mnuQuery
        '
        Me.mnuQuery.Enabled = False
        Me.mnuQuery.Index = 1
        Me.mnuQuery.Text = "查看(&Q)"
        '
        'mnuSep1
        '
        Me.mnuSep1.Index = 2
        Me.mnuSep1.Text = "-"
        '
        'mnuPrint
        '
        Me.mnuPrint.Enabled = False
        Me.mnuPrint.Index = 3
        Me.mnuPrint.Text = "打印(&P)..."
        '
        'mnuExport
        '
        Me.mnuExport.Enabled = False
        Me.mnuExport.Index = 4
        Me.mnuExport.Text = "导出(&E)"
        '
        'mnuSep2
        '
        Me.mnuSep2.Index = 5
        Me.mnuSep2.Text = "-"
        '
        'mnuQuit
        '
        Me.mnuQuit.Index = 6
        Me.mnuQuit.Text = "退出(&X)"
        '
        'mnuCompile
        '
        Me.mnuCompile.Index = 1
        Me.mnuCompile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAdd, Me.mnuEdit, Me.mnuDelete})
        Me.mnuCompile.Text = "编辑(&E)"
        '
        'mnuAdd
        '
        Me.mnuAdd.Enabled = False
        Me.mnuAdd.Index = 0
        Me.mnuAdd.Text = "增加(&A)"
        '
        'mnuEdit
        '
        Me.mnuEdit.Enabled = False
        Me.mnuEdit.Index = 1
        Me.mnuEdit.Text = "编辑(&E)"
        '
        'mnuDelete
        '
        Me.mnuDelete.Enabled = False
        Me.mnuDelete.Index = 2
        Me.mnuDelete.Text = "删除(&D)"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.Text = "帮助(&H)"
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.AllowSort = True
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.CollapseColor = System.Drawing.Color.Black
        Me.C1DBG.DataChanged = False
        Me.C1DBG.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBG.ExpandColor = System.Drawing.Color.Black
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 41)
        Me.C1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.ShowOptionsDialog = False
        Me.C1DBG.RecordSelectorWidth = 17
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG.RowDivider = GridLines1
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG.ScrollTips = False
        Me.C1DBG.Size = New System.Drawing.Size(642, 358)
        Me.C1DBG.TabIndex = 10
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Center;Borde" & _
        "r:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView Name="""" AllowRowSizing=""None"" CaptionHeight=""18"" ColumnC" & _
        "aptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" Record" & _
        "SelectorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" HorizontalScrollG" & _
        "roup=""1""><ClientRect>0, 0, 638, 354</ClientRect><BorderSide>0</BorderSide><Capti" & _
        "onStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" " & _
        "/><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar" & _
        """ me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""" & _
        "Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRow" & _
        "Style parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""S" & _
        "tyle4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=" & _
        """RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><" & _
        "Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><Na" & _
        "medStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><" & _
        "Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Sty" & _
        "le parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Styl" & _
        "e parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Styl" & _
        "e parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style par" & _
        "ent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Sty" & _
        "le parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSp" & _
        "lits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</DefaultRecSelWid" & _
        "th><ClientArea>0, 0, 638, 354</ClientArea></Blob>"
        '
        'tbbtnDO
        '
        Me.tbbtnDO.ImageIndex = 3
        Me.tbbtnDO.Text = "处理"
        Me.tbbtnDO.ToolTipText = "处理"
        '
        'tbbtnPrint
        '
        Me.tbbtnPrint.ImageIndex = 5
        Me.tbbtnPrint.Text = "打印"
        Me.tbbtnPrint.ToolTipText = "打印"
        '
        'tbbtnQuit
        '
        Me.tbbtnQuit.ImageIndex = 7
        Me.tbbtnQuit.Text = "退出"
        Me.tbbtnQuit.ToolTipText = "退出"
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnDO, Me.tbbtnPrint, Me.tbbtnQuit})
        Me.ToolBar.ButtonSize = New System.Drawing.Size(31, 35)
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(642, 41)
        Me.ToolBar.TabIndex = 9
        '
        'FRMCARGO_MONTH
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(642, 399)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.ToolBar)
        Me.Menu = Me.MainMenu
        Me.Name = "FRMCARGO_MONTH"
        Me.Text = "分部门件杂货理货类别统计表"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRMCARGO_MONTH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        'Call preview("WL1_1") '*****************权限设计 '*************要修改模块号
        Me.Text = Me.Text & "_" & G_DeptName
        FirmStr = " Order by ID "  '" Use_Comp Like '" & Trim(G_DeptCode) & "%' and Hide_Company Like '" & Trim(G_Company) & "%' order by ID DESC" '设计初始条件  在检索后不改变的条件  '***************要修改 或 2>1
        DynaStr = " 2>1 " '设计其它初始条件    在检索后不需要的条件 ***************要修改 或 其它条件
        SelectStr = " " ' " Top 20 "
        SqlStr = " (" & DynaStr & ")  " & FirmStr
        DS_DO.Reset()
        dw = Getdata("exec spcargo_month '" & Now & "','" & G_DeptCode & "'", DS_DO)
        LISTTIME = Now
        LIST_DEPTNAME = G_DeptName
        Call myDataGrid(SelectStr, SqlStr)
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色
    End Sub

    Private Sub myDataGrid(ByVal SelStr As String, ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try

            C1DBG.Visible = True
            C1DBG.DataSource = DS_DO.Tables(0).DefaultView
            C1DBG.Refresh()
            Me.C1DBG.Columns.Item("number").Caption = "序号"
            Me.C1DBG.Columns.Item("code_goods").Caption = "货名"
            Me.C1DBG.Columns.Item("amount").Caption = "本月件数"
            Me.C1DBG.Columns.Item("amounttotal").Caption = "累计件数"
            Me.C1DBG.Columns.Item("tons").Caption = "本月吨数"
            Me.C1DBG.Columns.Item("tonstotal").Caption = "累计吨数"
            Me.C1DBG.Columns.Item("tonspercent").Caption = "吨数占总量的比例%"


            Call SetColumnWidth()

            Me.C1DBG.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaption()
        Dim sqla As New SqlClient.SqlDataAdapter()
        Dim sqlc As New SqlClient.SqlCommand()
        Dim dset As New DataSet()
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Try
            str = "select Field_Eng,Field_Cha From Field_Att where Table_Name='" & Table_Name & "'"
            sqlconn.ConnectionString = conn
            sqlc.Connection = sqlconn
            sqlc.CommandText = str
            sqla.SelectCommand = sqlc
            dset.Reset()
            sqla.Fill(dset)
            i = ColNum

            Do While i < Me.C1DBG.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBG.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBG.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
                        Exit For
                    End If
                Next
                i = i + 1
            Loop
            sqlconn.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnWidth()
        Dim j As Integer
        For j = 0 To Me.C1DBG.Columns.Count - 1
            Me.C1DBG.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.C1DBG.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width < 40 Then
                Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width = 40
            Else
                If Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If

        Next
    End Sub
    Private Sub SetColumnSum(ByVal sql As String)
        On Error GoTo Err
        Dim sqla As New SqlClient.SqlDataAdapter()
        Dim sqlc As New SqlClient.SqlCommand()
        Dim dset As New DataSet()
        Dim dset2 As New DataSet()
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Dim m As Integer
        Dim num As Double
        str = "select Field_Eng,Field_Type,IsOrNoSum From Field_Att where Table_Name='" & Trim(Table_Name) & "'"
        sqlconn.ConnectionString = conn
        sqlc.Connection = sqlconn
        sqlc.CommandText = str
        sqla.SelectCommand = sqlc
        dset.Reset()
        sqla.Fill(dset)

        i = ColNum
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBG.Columns.Item(ColNum).FooterText = "合计 共" & ds.Tables(0).Rows.Count & "条"
        Do While i < Me.C1DBG.Columns.Count
            j = 0
            For j = 0 To dset.Tables(0).Rows.Count - 1

                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBG.Columns.Item(i).DataField.ToString)) And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then

                    num = 0
                    For m = 0 To ds.Tables(0).Rows.Count - 1
                        num = num + ds.Tables(0).Rows(m)(i)
                    Next
                    Me.C1DBG.Columns.Item(i).FooterText = CType(num, String)
                    Exit For
                End If
            Next
            i = i + 1
        Loop

        sqlconn.Close()
        Exit Sub
Err:
        Resume Next


    End Sub

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        Me.Close()
    End Sub

    Private Sub ToolBar_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar.ButtonClick
        Select Case Me.ToolBar.Buttons.IndexOf(e.Button)
            Case 0
                Try
                    Dim frm As New FRMCARGO_MONTH_DO()
                    frm.ShowDialog()
                    Call myDataGrid(SelectStr, SqlStr)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case 1
                Call mnuPrint_Click(sender, e)
            Case 2
                'Call mnuExport_Click(sender, e)
                Me.Close()
            Case 3

        End Select
    End Sub
    Private Sub C1DBG_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            If Me.C1DBG.Col = Me.C1DBG.Columns.Count - 1 And Me.C1DBG.Row < ds.Tables(0).Rows.Count - 1 Then
                Me.C1DBG.Row = Me.C1DBG.Row + 1
                Me.C1DBG.Col = ColNum
            End If
        End If
    End Sub

    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
        Call PrintExcel()
    End Sub

    Private Sub mnuExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExport.Click
        Call ExportExcel()
    End Sub
    Private Sub ExportExcel() '导出Excel        
        'Call MakeExcel()
    End Sub
    Private Sub PrintExcel() '打印到Excel        

        Try
            Call china()
        Catch
            xlApp.Quit()
            SendKeys.Send("n")
        End Try

    End Sub
    Private Sub china()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer

        Try
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "Report_zlp.xls", pathstr + "report_zlp2.xls")
            Filepath = pathstr + "report_zlp2.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("件杂货理货类别统计表"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = True

            If Len(LISTTIME) > 0 Then
                xlsheet.Cells(2, 1) = Year(LISTTIME) & "年" & Month(LISTTIME) & "月"
            End If
            If Len(LIST_DEPTNAME) > 0 Then
                xlsheet.Cells(2, 3) = LIST_DEPTNAME
            End If

            For row = 0 To DS_DO.Tables(0).Rows.Count - 1
                For col = 0 To 6
                    xlsheet.Cells(5 + row, col + 1) = DS_DO.Tables(0).Rows(row)(col)
                Next col
            Next row

            xlsheet.Cells(5 + DS_DO.Tables(0).Rows.Count + 1, 1) = "部门：" & G_DeptName
            xlsheet.Cells(5 + DS_DO.Tables(0).Rows.Count + 1, 5) = "统计员：" & G_User
            xlsheet.Cells(5 + DS_DO.Tables(0).Rows.Count + 1, 7) = "统3"

            For row = 5 To DS_DO.Tables(0).Rows.Count + 4 '*画行
                xlsheet.Range(xlsheet.Cells(row, 1), xlsheet.Cells(row, 7)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 7
            Next row
            For col = 1 To 8 '* 画列
                xlsheet.Range(xlsheet.Cells(5, col), xlsheet.Cells(DS_DO.Tables(0).Rows.Count + 4, col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7
            Next col

            xlsheet.PrintPreview()

        Catch
            xlapp.Quit()
            SendKeys.Send("n")
        End Try
    End Sub

    'Private Sub MakeExcel()
    '    Dim PathStr As String
    '    Dim FilePath As String
    '    Dim Row As Integer
    '    Dim Col As Integer
    '    PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
    '    PathStr = substr(PathStr)
    '    Try
    '        FilePath = PathStr + "Report.xls"
    '        xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
    '        xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)
    '        xlSheet = CType(xlBook.Worksheets(1), Excel.Worksheet)
    '        xlApp.DisplayAlerts = False
    '        xlSheet.Application.Visible = True

    '        xlSheet.Cells(1, 1) = Me.Text() '标题

    '        For Col = ColNum To Me.C1DBG.Columns.Count - 1 '列标题
    '            xlSheet.Cells(3, Col - ColNum + 1) = Me.C1DBG.Columns(Col).Caption

    '        Next Col
    '        Me.C1DBG.MoveFirst()
    '        For Row = 0 To ds.Tables(0).Rows.Count - 1 '数据
    '            For Col = ColNum To Me.C1DBG.Columns.Count - 1
    '                xlSheet.Cells(Row + 4, Col - ColNum + 1) = Me.C1DBG.Columns(Col).Text.ToString      'ds.Tables(0).Rows(Row)(Col)
    '            Next Col
    '            Me.C1DBG.MoveNext()
    '        Next Row
    '        If Me.C1DBG.ColumnFooters = True Then '合计项
    '            For Col = ColNum To Me.C1DBG.Columns.Count - 1
    '                xlSheet.Cells(ds.Tables(0).Rows.Count + 4, Col - ColNum + 1) = Me.C1DBG.Columns(Col).FooterText
    '            Next Col
    '        End If
    '    Catch
    '        xlApp.Quit()
    '        SendKeys.Send("N")
    '    End Try

    'End Sub

    'Private Sub preview(ByVal Func As String) '***************权限设计
    '    Dim sqlstr As String
    '    Dim Previewdv As DataView
    '    Dim Previewds As New DataSet()
    '    Dim i As Integer
    '    sqlstr = " select FUNC_CODE_Add,FUNC_CODE_Change,FUNC_CODE_Del from View_UserPreview where PART_ID=" & G_Part_Id & " and FUNC_CODE='" & Upper(Func) & "' "
    '    Previewdv = Getdata(sqlstr, Previewds)
    '    If Previewdv.Count > 0 Then
    '        If Previewdv(i)("FUNC_CODE_Add") = 1 Then 'ADD 按钮可见
    '            ToolBar.Buttons.Item(3).Enabled = True
    '            mnuAdd.Enabled = True
    '        Else                                      'ADD 按钮不可见
    '            Me.ToolBar.Buttons.Item(3).Enabled = False
    '            mnuAdd.Enabled = False
    '        End If
    '        If Previewdv(i)("FUNC_CODE_Change") = 1 Then '修改 按钮可见
    '            Me.ToolBar.Buttons.Item(4).Enabled = True
    '            mnuEdit.Enabled = True
    '        Else                                          '修改 按钮不可见
    '            Me.ToolBar.Buttons.Item(4).Enabled = False
    '            mnuEdit.Enabled = False
    '        End If
    '        If Previewdv(i)("FUNC_CODE_Del") = 1 Then '删除 按钮可见
    '            Me.ToolBar.Buttons.Item(5).Enabled = True
    '            mnuDelete.Enabled = True
    '        Else                                     '删除按钮不可见
    '            Me.ToolBar.Buttons.Item(5).Enabled = False
    '            mnuDelete.Enabled = False
    '        End If
    '    End If

    'End Sub
    Private Sub C1DBG_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        If Me.C1DBG.Columns("Logic").CellValue(e.Row) = 1 Then
            e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
        End If

    End Sub

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        TBar = 1
        Mnu = 1
    End Sub
End Class
