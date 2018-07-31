Imports TALLY.DBControl
Public Class FrmOperationManage
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
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents tbbtnFind As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuery As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnAdd As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnEdit As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnDelete As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnPrint As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnExport As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuit As System.Windows.Forms.ToolBarButton
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tbbtnDeleteAll As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmOperationManage))
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
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar = New System.Windows.Forms.ToolBar
        Me.tbbtnFind = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuery = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep1 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnAdd = New System.Windows.Forms.ToolBarButton
        Me.tbbtnEdit = New System.Windows.Forms.ToolBarButton
        Me.tbbtnDelete = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep2 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnPrint = New System.Windows.Forms.ToolBarButton
        Me.tbbtnExport = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep3 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuit = New System.Windows.Forms.ToolBarButton
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.tbbtnDeleteAll = New System.Windows.Forms.ToolBarButton
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.mnuFind.Index = 0
        Me.mnuFind.Text = "检索(&F)"
        '
        'mnuQuery
        '
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
        Me.mnuPrint.Index = 3
        Me.mnuPrint.Text = "打印(&P)..."
        '
        'mnuExport
        '
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
        Me.mnuAdd.Index = 0
        Me.mnuAdd.Text = "增加(&A)"
        '
        'mnuEdit
        '
        Me.mnuEdit.Index = 1
        Me.mnuEdit.Text = "编辑(&E)"
        '
        'mnuDelete
        '
        Me.mnuDelete.Index = 2
        Me.mnuDelete.Text = "删除(&D)"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.Text = "帮助(&H)"
        '
        'ImageList
        '
        Me.ImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnFind, Me.tbbtnQuery, Me.tbbtnSep1, Me.tbbtnAdd, Me.tbbtnEdit, Me.tbbtnDelete, Me.tbbtnDeleteAll, Me.tbbtnSep2, Me.tbbtnPrint, Me.tbbtnExport, Me.tbbtnSep3, Me.tbbtnQuit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(400, 41)
        Me.ToolBar.TabIndex = 14
        '
        'tbbtnFind
        '
        Me.tbbtnFind.ImageIndex = 0
        Me.tbbtnFind.Text = "检索"
        Me.tbbtnFind.ToolTipText = "检索"
        '
        'tbbtnQuery
        '
        Me.tbbtnQuery.ImageIndex = 1
        Me.tbbtnQuery.Text = "查看"
        Me.tbbtnQuery.ToolTipText = "查看"
        '
        'tbbtnSep1
        '
        Me.tbbtnSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnAdd
        '
        Me.tbbtnAdd.ImageIndex = 2
        Me.tbbtnAdd.Text = "增加"
        Me.tbbtnAdd.ToolTipText = "增加"
        '
        'tbbtnEdit
        '
        Me.tbbtnEdit.ImageIndex = 3
        Me.tbbtnEdit.Text = "编辑"
        Me.tbbtnEdit.ToolTipText = "编辑"
        '
        'tbbtnDelete
        '
        Me.tbbtnDelete.ImageIndex = 4
        Me.tbbtnDelete.Text = "删除"
        Me.tbbtnDelete.ToolTipText = "删除"
        '
        'tbbtnSep2
        '
        Me.tbbtnSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnPrint
        '
        Me.tbbtnPrint.ImageIndex = 5
        Me.tbbtnPrint.Text = "打印"
        Me.tbbtnPrint.ToolTipText = "打印"
        '
        'tbbtnExport
        '
        Me.tbbtnExport.ImageIndex = 6
        Me.tbbtnExport.Text = "导出"
        Me.tbbtnExport.ToolTipText = "导出Excel"
        '
        'tbbtnSep3
        '
        Me.tbbtnSep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnQuit
        '
        Me.tbbtnQuit.ImageIndex = 7
        Me.tbbtnQuit.Text = "退出"
        Me.tbbtnQuit.ToolTipText = "退出"
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 41)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.Size = New System.Drawing.Size(400, 244)
        Me.C1DBG.TabIndex = 15
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" AllowRowSizing=""None"" CaptionH" & _
        "eight=""18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""Dotted" & _
        "CellBorder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1""" & _
        " HorizontalScrollGroup=""1""><Height>240</Height><CaptionStyle parent=""Style2"" me=" & _
        """Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""Eve" & _
        "nRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterSty" & _
        "le parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><Head" & _
        "ingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow""" & _
        " me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle paren" & _
        "t=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style1" & _
        "1"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""S" & _
        "tyle1"" /><ClientRect>0, 0, 396, 240</ClientRect><BorderSide>0</BorderSide><Borde" & _
        "rStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles" & _
        "><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style par" & _
        "ent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style parent" & _
        "=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=" & _
        """Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=" & _
        """Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Head" & _
        "ing"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent" & _
        "=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</h" & _
        "orzSplits><Layout>None</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth><Clien" & _
        "tArea>0, 0, 396, 240</ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" />" & _
        "<PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'tbbtnDeleteAll
        '
        Me.tbbtnDeleteAll.ImageIndex = 4
        Me.tbbtnDeleteAll.Text = "全删"
        '
        'FrmOperationManage
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(400, 285)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.ToolBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu
        Me.MinimizeBox = False
        Me.Name = "FrmOperationManage"
        Me.Text = "数据库操作管理"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As New DataSet
    Dim ColNum As Integer '不显示的列数
    Private Sub Frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call preview("WL1_7") '权限设计
        Me.ToolBar.Buttons.Item(0).Enabled = False
        Me.ToolBar.Buttons.Item(1).Enabled = False
        Me.ToolBar.Buttons.Item(2).Enabled = False
        Me.ToolBar.Buttons.Item(4).Enabled = False
        Me.ToolBar.Buttons.Item(7).Enabled = False
        Me.ToolBar.Buttons.Item(8).Enabled = False
        Me.ToolBar.Buttons.Item(9).Enabled = False
        Me.ToolBar.Buttons.Item(10).Enabled = False
        Me.Text = Me.Text & "_" & G_DeptName
        Call myDataGrid()
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色
    End Sub

    Private Sub myDataGrid()
        Dim strsql As String
        Dim i As Integer
        Try
            '不显示的列名在最前面
            strsql = "select top 30 update_id,update_table_info,client_hdinfo,update_text,operate_date,update_date,update_mark from szh_client_updateinfo order by update_id desc"
            Me.C1DBG.DataSource = Getdata(strsql, ds)

            ColNum = 1  '不显示的列数
            Table_Name = "szh_client_updateinfo" '操作的数据库表名

            For i = 0 To ColNum - 1 '设计不显示的列
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Visible = False
            Next

            Call SetColumnCaption() '设计列标题
            Call SetColumnWidth()

            Me.C1DBG.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaption()
        Try
            Me.C1DBG.Columns.Item(0).Caption = "数据库ID"
            Me.C1DBG.Columns.Item(1).Caption = "数据库表名"
            Me.C1DBG.Columns.Item(2).Caption = "客户端信息"
            Me.C1DBG.Columns.Item(3).Caption = "操作SQL语句"
            Me.C1DBG.Columns.Item(4).Caption = "操作日期"
            Me.C1DBG.Columns.Item(5).Caption = "更新日期"
            Me.C1DBG.Columns.Item(6).Caption = "更新标志"
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnWidth()
        Dim i As Integer
        Try
            i = ColNum
            Do While i < Me.C1DBG.Columns.Count
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).AutoSize()
                'Me.C1DBG.Splits(0).DisplayColumns.Item(i).Width = ((Me.C1DBG.Width - 50) / (Me.C1DBG.Columns.Count - 1))
                i = i + 1
            Loop

            Me.C1DBG.Splits(0).DisplayColumns.Item(3).Width = 580
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnSum(ByVal sql As String)
        '        On Error GoTo Err
        '        Dim sqla As New SqlClient.SqlDataAdapter
        '        Dim sqlc As New SqlClient.SqlCommand
        '        Dim dset As New DataSet
        '        Dim dset2 As New DataSet
        '        Dim str As String
        '        Dim i As Integer
        '        Dim j As Integer
        '        Dim m As Integer
        '        Dim num As Double
        '        str = "select Field_Eng,Field_Type,IsOrNoSum From Field_Att where Table_Name='" & Trim(Table_Name) & "'"
        '        sqlconn.ConnectionString = conn
        '        sqlc.Connection = sqlconn
        '        sqlc.CommandText = str
        '        sqla.SelectCommand = sqlc
        '        dset.Reset()
        '        sqla.Fill(dset)

        '        i = ColNum
        '        Me.C1DBG.ColumnFooters = True
        '        Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        '        Me.C1DBG.Columns.Item(ColNum).FooterText = "合计 共" & ds.Tables(0).Rows.Count & "条"
        '        Do While i < Me.C1DBG.Columns.Count
        '            j = 0
        '            For j = 0 To dset.Tables(0).Rows.Count - 1

        '                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBG.Columns.Item(i).DataField.ToString)) And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then

        '                    num = 0
        '                    For m = 0 To ds.Tables(0).Rows.Count - 1
        '                        num = num + ds.Tables(0).Rows(m)(i)
        '                    Next
        '                    Me.C1DBG.Columns.Item(i).FooterText = CType(num, String)
        '                    Exit For
        '                End If
        '            Next
        '            i = i + 1
        '        Loop

        '        sqlconn.Close()
        '        Exit Sub
        'Err:
        '        Resume Next
    End Sub

    Private Sub ToolBar_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar.ButtonClick
        Select Case Me.ToolBar.Buttons.IndexOf(e.Button)
            Case 0
                Call mnuFind_Click(sender, e)
            Case 1
                Call mnuQuery_Click(sender, e)
            Case 2

            Case 3
                Call mnuAdd_Click(sender, e)
            Case 4
                Call mnuEdit_Click(sender, e)
            Case 5
                Delete(Me.ToolBar.Buttons.IndexOf(e.Button))
                'Call mnuDelete_Click(sender, e)
            Case 6
                Delete(Me.ToolBar.Buttons.IndexOf(e.Button))
            Case 7

            Case 8
                Call mnuPrint_Click(sender, e)

            Case 9
                Call mnuExport_Click(sender, e)
            Case 10

            Case 11
                Me.Close()
        End Select
    End Sub

    Private Sub mnuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdd.Click
        Dim FrmAdd As New FrmOperationManage_Add
        If ds.Tables(0).Rows.Count > 0 Then
            ID = CType(Me.C1DBG.Columns.Item("update_id").Text.ToString, Integer)
        Else
            ID = -1
        End If
        FrmAdd.ShowDialog()

        Try
            Call myDataGrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        Me.Close()
    End Sub

    Private Sub C1DBG_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.DoubleClick
        Call mnuQuery_Click(sender, e)
    End Sub

    Private Sub C1DBG_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            If Me.C1DBG.Col = Me.C1DBG.Columns.Count - 1 And Me.C1DBG.Row < ds.Tables(0).Rows.Count - 1 Then
                Me.C1DBG.Row = Me.C1DBG.Row + 1
                Me.C1DBG.Col = ColNum
            End If
        End If
    End Sub

    Private Sub preview(ByVal Func As String) '***************权限设计
        Dim sqlstr As String
        Dim Previewdv As DataView
        Dim Previewds As New DataSet
        Dim i As Integer
        sqlstr = " select FUNC_CODE_Add,FUNC_CODE_Change,FUNC_CODE_Del from View_UserPreview where PART_ID=" & G_Part_Id & " and FUNC_CODE='" & Upper(Func) & "' "
        Previewdv = Getdata(sqlstr, Previewds)
        If Previewdv.Count > 0 Then
            If Previewdv(i)("FUNC_CODE_Add") = 1 Then 'ADD 按钮可见
                ToolBar.Buttons.Item(3).Enabled = True
                mnuAdd.Enabled = True
            Else                                      'ADD 按钮不可见
                Me.ToolBar.Buttons.Item(3).Enabled = False
                mnuAdd.Enabled = False
            End If
            If Previewdv(i)("FUNC_CODE_Change") = 1 Then '修改 按钮可见
                Me.ToolBar.Buttons.Item(4).Enabled = True
                mnuEdit.Enabled = True
            Else                                          '修改 按钮不可见
                Me.ToolBar.Buttons.Item(4).Enabled = False
                mnuEdit.Enabled = False
            End If
            If Previewdv(i)("FUNC_CODE_Del") = 1 Then '删除 按钮可见
                Me.ToolBar.Buttons.Item(5).Enabled = True
                mnuDelete.Enabled = True
            Else                                     '删除按钮不可见
                Me.ToolBar.Buttons.Item(5).Enabled = False
                mnuDelete.Enabled = False
            End If
        End If
    End Sub

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        'If Me.C1DBG.Columns("Logic").CellValue(e.Row) = 1 Then
        '    e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
        'End If
    End Sub

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        TBar = 1
        Mnu = 1
    End Sub

    Private Sub mnuFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFind.Click
        'Dim FrmFind As New FrmFind
        'FrmFind.ShowDialog()
        'If Flag = 0 Then
        '    SelectStr = ""
        '    Call myDataGrid(SelectStr, " (" & Sql_Find & ")  " & FirmStr)  '可能要修改
        '    SqlStr = " (" & Sql_Find & ")  " & FirmStr '可能要修改
        'ElseIf Flag = 2 Then
        '    SelectStr = ""
        '    Call myDataGrid(SelectStr, DynaStr & FirmStr)  '可能要修改
        '    SqlStr = DynaStr & FirmStr '可能要修改
        'End If
    End Sub

    Private Sub mnuQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuery.Click
        'If ds.Tables(0).Rows.Count > 0 Then
        '    Dim FrmQuery As New FrmOperationManage_Query   '***********要修改
        '    ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
        '    FrmQuery.ShowDialog()
        'End If
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        'If ds.Tables(0).Rows.Count > 0 Then
        '    Dim FrmEdit As New FrmOperationManage_Edit   '***********要修改

        '    Dim Row As Integer

        '    ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
        '    Row = Me.C1DBG.Row
        '    FrmEdit.ShowDialog()
        '    Try
        '        Call myDataGrid(SelectStr, SqlStr)
        '        Me.C1DBG.Row = Row

        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        'End If
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        'If ds.Tables(0).Rows.Count > 0 Then
        '    Dim FrmDelete As New FrmOperationManage_Delete   '***********要修改

        '    ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
        '    FrmDelete.ShowDialog()
        '    Try
        '        Call myDataGrid(SelectStr, SqlStr)


        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        'End If
    End Sub

    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
        'Call PrintExcel()
    End Sub

    Private Sub PrintExcel() '打印到Excel        

        'Dim Row As Integer
        'Dim Col As Integer

        'Try
        '    Call MakeExcel()

        '    Row = ds.Tables(0).Rows.Count + 4
        '    Col = Me.C1DBG.Columns.Count - ColNum
        '    '**************画边框
        '    For Row = 2 To ds.Tables(0).Rows.Count + 4 '画列
        '        xlSheet.Range(xlSheet.Cells(Row, 1), xlSheet.Cells(Row, C1DBG.Columns.Count - ColNum)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 7
        '    Next Row
        '    For Col = 1 To C1DBG.Columns.Count - ColNum + 1 '画行
        '        xlSheet.Range(xlSheet.Cells(3, Col), xlSheet.Cells(ds.Tables(0).Rows.Count + 4, Col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7
        '    Next Col

        'Catch
        '    xlApp.Quit()
        '    SendKeys.Send("N")
        'End Try

    End Sub

    Private Sub mnuExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExport.Click
        'Call ExportExcel()
    End Sub

    Private Sub ExportExcel() '导出Excel        
        'Call MakeExcel()
    End Sub

    Private Sub MakeExcel()
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

    End Sub

    Private Sub Delete(ByVal index As Integer)
        Dim mark As Integer
        Dim sql As String
        Dim dstemp As New DataSet
        If index = 5 Then
            mark = CType(Me.C1DBG.Columns.Item("update_mark").Text, Integer)
            If mark = 0 Then
                If MsgBox("您要删除的记录没有更新。" & Chr(13) & "确认删除吗？", MsgBoxStyle.OKCancel) = MsgBoxResult.OK Then
                    sql = "delete from szh_client_updateinfo where update_id=" & CType(Me.C1DBG.Columns.Item("update_id").Text, Integer)
                    ExecSql(sql)
                End If
            Else
                If MsgBox("确认删除吗？", MsgBoxStyle.OKCancel) = MsgBoxResult.OK Then
                    sql = "delete from szh_client_updateinfo where update_id=" & CType(Me.C1DBG.Columns.Item("update_id").Text, Integer)
                    ExecSql(sql)
                End If
            End If
        ElseIf index = 6 Then
            sql = Me.C1DBG.Columns.Item("update_text").Text.Replace("'", "''")
            sql = "select update_mark from szh_client_updateinfo where update_table_info='" & Trim(Me.C1DBG.Columns.Item("update_table_info").Text) & "' and update_text='" & Trim(sql) & "'"
            Getdata(sql, dstemp)
            For mark = 0 To dstemp.Tables(0).Rows.Count - 1
                If CType(dstemp.Tables(0).Rows(mark).Item(0), Integer) = 0 Then
                    Exit For
                End If
            Next
            If mark = dstemp.Tables(0).Rows.Count Then
                If MsgBox("确认删除吗？", MsgBoxStyle.OKCancel) = MsgBoxResult.OK Then
                    sql = Me.C1DBG.Columns.Item("update_text").Text.Replace("'", "''")
                    sql = "delete from szh_client_updateinfo where update_table_info='" & Trim(Me.C1DBG.Columns.Item("update_table_info").Text) & "' and update_text='" & Trim(sql) & "'"
                    ExecSql(sql)
                End If
            ElseIf MsgBox("存在没有更新的记录。" & Chr(13) & "确认删除吗？", MsgBoxStyle.OKCancel) = MsgBoxResult.OK Then
                sql = Me.C1DBG.Columns.Item("update_text").Text.Replace("'", "''")
                sql = "delete from szh_client_updateinfo where update_table_info='" & Trim(Me.C1DBG.Columns.Item("update_table_info").Text) & "' and update_text='" & Trim(sql) & "'"
                ExecSql(sql)
            End If
        End If
        myDataGrid()
    End Sub
End Class