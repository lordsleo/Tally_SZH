Imports TALLY.DBControl
Public Class FrmRs_Salary_In
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
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents rbInput As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbFormal As System.Windows.Forms.RadioButton
    Friend WithEvents btExport As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cbMonth As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmRs_Salary_In))
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.rbInput = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.rbFormal = New System.Windows.Forms.RadioButton
        Me.btExport = New System.Windows.Forms.Button
        Me.cbYear = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbMonth = New System.Windows.Forms.ComboBox
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1DBG
        '
        Me.C1DBG.AllowColMove = False
        Me.C1DBG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FetchRowStyles = True
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(16, 72)
        Me.C1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.RecordSelectorWidth = 17
        Me.C1DBG.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1DBG.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG.Size = New System.Drawing.Size(312, 360)
        Me.C1DBG.TabIndex = 284
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView AllowColMove=""False"" Name="""" CaptionHe" & _
        "ight=""18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" FetchRowStyles=""True""" & _
        " MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" Ve" & _
        "rticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRect>0, 0, 308, 356</Clie" & _
        "ntRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2"" me=""Style10"" /><E" & _
        "ditorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Styl" & _
        "e8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Foo" & _
        "ter"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle paren" & _
        "t=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /" & _
        "><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=" & _
        """Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><Selected" & _
        "Style parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /></C1." & _
        "Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" />" & _
        "<Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Sty" & _
        "le parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Styl" & _
        "e parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style pa" & _
        "rent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style p" & _
        "arent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Styl" & _
        "e parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedS" & _
        "tyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><" & _
        "DefaultRecSelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 308, 356</ClientArea" & _
        "><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" " & _
        "me=""Style15"" /></Blob>"
        '
        'btQuit
        '
        Me.btQuit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(248, 440)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 286
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btSave.Location = New System.Drawing.Point(168, 440)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 285
        Me.btSave.Text = "确认"
        '
        'rbInput
        '
        Me.rbInput.Location = New System.Drawing.Point(16, 16)
        Me.rbInput.Name = "rbInput"
        Me.rbInput.Size = New System.Drawing.Size(104, 20)
        Me.rbInput.TabIndex = 287
        Me.rbInput.Text = "录入"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(16, 40)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(104, 20)
        Me.RadioButton2.TabIndex = 288
        Me.RadioButton2.Text = "查看"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.rbInput)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 64)
        Me.GroupBox1.TabIndex = 289
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.rbFormal)
        Me.GroupBox2.Location = New System.Drawing.Point(152, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(128, 64)
        Me.GroupBox2.TabIndex = 290
        Me.GroupBox2.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(16, 40)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(104, 20)
        Me.RadioButton1.TabIndex = 288
        Me.RadioButton1.Text = "外聘"
        '
        'rbFormal
        '
        Me.rbFormal.Location = New System.Drawing.Point(16, 16)
        Me.rbFormal.Name = "rbFormal"
        Me.rbFormal.Size = New System.Drawing.Size(104, 20)
        Me.rbFormal.TabIndex = 287
        Me.rbFormal.Text = "正式"
        '
        'btExport
        '
        Me.btExport.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btExport.Location = New System.Drawing.Point(88, 440)
        Me.btExport.Name = "btExport"
        Me.btExport.Size = New System.Drawing.Size(65, 24)
        Me.btExport.TabIndex = 291
        Me.btExport.Text = "导出"
        '
        'cbYear
        '
        Me.cbYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbYear.Items.AddRange(New Object() {"2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015"})
        Me.cbYear.Location = New System.Drawing.Point(8, 432)
        Me.cbYear.MaxDropDownItems = 12
        Me.cbYear.MaxLength = 4
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(48, 20)
        Me.cbYear.TabIndex = 292
        Me.cbYear.Text = "2008"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(56, 432)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 20)
        Me.Label1.TabIndex = 293
        Me.Label1.Text = "年"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(56, 448)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 20)
        Me.Label2.TabIndex = 295
        Me.Label2.Text = "月"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbMonth
        '
        Me.cbMonth.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbMonth.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cbMonth.Location = New System.Drawing.Point(20, 448)
        Me.cbMonth.MaxDropDownItems = 12
        Me.cbMonth.MaxLength = 2
        Me.cbMonth.Name = "cbMonth"
        Me.cbMonth.Size = New System.Drawing.Size(36, 20)
        Me.cbMonth.TabIndex = 294
        Me.cbMonth.Text = "01"
        '
        'FrmRs_Salary_In
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(344, 478)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbMonth)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbYear)
        Me.Controls.Add(Me.btExport)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.C1DBG)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRs_Salary_In"
        Me.ShowInTaskbar = False
        Me.Text = "人事工资录入"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim dsGetWorkNo As New DataSet
    Dim daGetWorkNo As New SqlClient.SqlDataAdapter
    Dim dvGetWorkNo As DataView

    Private Sub FrmRs_Salary_In_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '外聘部门代码
            Dim strEngageDeptCode As String
            strEngageDeptCode = "29" & G_DeptCode.Substring(2)
            '初始化数据库表
            Dim sqlUpdateWorkDept As String
            sqlUpdateWorkDept = "update A set Dept_Code=B.DEPT_CODE from rs_khgz A join TALLY_CLERK B on A.work_no=B.Work_No where (B.DEPT_CODE='" & G_DeptCode & "' or B.DEPT_CODE='" & strEngageDeptCode & "')"
            Dim sqlInsertWorkNo As String
            sqlInsertWorkNo = "insert into rs_khgz (Dept_Code,work_no,Name) select Dept_Code,Work_No,Name from TALLY_CLERK where (DEPT_CODE='" & G_DeptCode & "' or DEPT_CODE='" & strEngageDeptCode & "') and Work_No not in (select work_no from rs_khgz)"
            Dim sqlDelWorkNo As String
            sqlDelWorkNo = "delete from rs_khgz where (DEPT_CODE='" & G_DeptCode & "' or DEPT_CODE='" & strEngageDeptCode & "') and work_no not in (select Work_No from TALLY_CLERK where DEPT_CODE='" & G_DeptCode & "' or DEPT_CODE='" & strEngageDeptCode & "')"
            ExecSql(sqlUpdateWorkDept & " " & sqlInsertWorkNo & " " & sqlDelWorkNo)
            '初始化录入界面
            Dim sqlGetWorkNo As String
            sqlGetWorkNo = "select ID,Dept_Code,work_no,Name,salary_kh,mark from rs_khgz where work_no in (select Work_No from TALLY_CLERK where DEPT_CODE='" & G_DeptCode & "' or DEPT_CODE='" & strEngageDeptCode & "')"
            dvGetWorkNo = Updatedata(daGetWorkNo, sqlGetWorkNo, dsGetWorkNo)
            Me.C1DBG.DataSource = dvGetWorkNo
            Me.C1DBG.Columns("work_no").Caption = "工号"
            Me.C1DBG.Columns("Name").Caption = "姓名"
            Me.C1DBG.Columns("salary_kh").Caption = "薪资"
            Me.C1DBG.Splits(0).DisplayColumns("ID").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("Dept_Code").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("work_no").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("Name").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("mark").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("ID").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns("Dept_Code").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns("mark").Visible = False
            Dim i As Integer
            For i = 2 To 4
                Me.C1DBG.Splits(0).DisplayColumns(i).Width = (Me.C1DBG.Width - 50) / 3
            Next
            Me.rbInput.Checked = True
            Me.rbFormal.Checked = True
            Me.C1DBG.FooterStyle.BackColor = Color.GhostWhite
            Me.cbYear.Text = Now.Year
            Me.cbMonth.Text = Now.Month.ToString("00")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Dim strFilter1, strFilter2 As String

    Private Sub rbInput_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbInput.CheckedChanged
        If Me.rbInput.Checked Then
            Me.C1DBG.AllowUpdate = True
            strFilter1 = "mark='0'"
        Else
            Me.C1DBG.AllowUpdate = False
            strFilter1 = ""
        End If
        DataFilter()
    End Sub

    Private Sub rbFormal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFormal.CheckedChanged
        If Me.rbFormal.Checked Then
            strFilter2 = "Dept_Code like '26%'"
        Else
            strFilter2 = "Dept_Code like '29%'"
        End If
        DataFilter()
    End Sub

    Private Sub DataFilter()
        If strFilter1 <> "" Then
            If strFilter2 <> "" Then
                dvGetWorkNo.RowFilter = strFilter1 & " and " & strFilter2
            Else
                dvGetWorkNo.RowFilter = strFilter1
            End If
        Else
            If strFilter2 <> "" Then
                dvGetWorkNo.RowFilter = strFilter2
            Else
                dvGetWorkNo.RowFilter = strFilter1
            End If
        End If
        Me.C1DBG.Columns("Name").FooterText = dvGetWorkNo.Count & "人"
        Me.C1DBG.Columns("salary_kh").FooterText = GetDataSum(dvGetWorkNo, "salary_kh") & "元"
    End Sub

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        If Me.C1DBG.Columns("mark").CellText(e.Row) = "1" Then
            e.CellStyle.BackColor = Color.Wheat
        End If
        If Me.C1DBG.Columns("Dept_Code").CellText(e.Row) Like "29*" Then
            e.CellStyle.ForeColor = Color.Green
        End If
    End Sub

    Private Sub C1DBG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1DBG.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.C1DBG.Columns(Me.C1DBG.Col).DataField = "salary_kh" Then
                Me.C1DBG.Row += 1
            End If
        End If
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            daGetWorkNo.Update(dsGetWorkNo)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub btExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExport.Click
        '改为查看模式
        If Me.rbInput.Checked Then
            Me.RadioButton2.Checked = True
        End If
        If dvGetWorkNo.Count > 0 Then
            If Me.cbYear.Text Like "20##" Or Me.cbYear.Text Like "##" Then
                If Me.cbMonth.Text Like "0[1-9]" Or Me.cbMonth.Text Like "[1-9]" Or Me.cbMonth.Text Like "1[0-2]" Then
                    Dim strYearMonth As String
                    strYearMonth = Me.cbYear.Text & "年" & Me.cbMonth.Text & "月"
                    If MessageBox.Show("确定导出月份是 " & strYearMonth & " 吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                        ExportSalary(strYearMonth)
                        System.GC.Collect()
                    End If
                Else
                    Me.cbMonth.Focus()
                    MessageBox.Show("请输入正确的月份", "提示")
                End If
            Else
                Me.cbYear.Focus()
                MessageBox.Show("请输入正确的年份", "提示")
            End If
        End If
    End Sub

    Private Sub ExportSalary(ByVal strYearMonth As String)
        Try
            Dim strDeptName As String
            strDeptName = G_DeptName
            If Me.rbFormal.Checked = False Then
                strDeptName += "外聘"
            End If

            Dim path As String
            Dim svPath As New SaveFileDialog
            svPath.RestoreDirectory = True
            svPath.AddExtension = True
            svPath.DefaultExt = "xls"
            svPath.Filter = "Excel文件(*.xls)|*.xls"
            svPath.InitialDirectory = "d:\report\"
            svPath.FileName = strDeptName & strYearMonth & "岗位工资"
            If svPath.ShowDialog = DialogResult.OK Then
                path = svPath.FileName
            Else
                Exit Sub
            End If

            Dim PathStr As String
            Dim FilePath As String
            PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
            PathStr = substr(PathStr)
            FileCopy(PathStr & "部门岗位工资单.xls", path)

            Dim xlApp As Excel.Application
            Dim xlBook As Excel.Workbook
            Dim xlSheet As Excel.Worksheet
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            xlBook = CType(xlApp.Workbooks.Open("" & path & ""), Excel.Workbook)
            xlSheet = CType(xlBook.Worksheets("GWGZ"), Excel.Worksheet)
            xlBook.Worksheets("GWGZ").select()
            'xlApp.DisplayAlerts = False

            xlSheet.Cells(2, "C") = strDeptName
            xlSheet.Cells(2, "G") = strYearMonth
            Dim i As Integer
            Dim iStart As Integer = 4 'excel开始行
            Dim iMaxRowSum As Integer = 37 '一列最大行数
            Dim iFactRowSum As Integer  '本列实际行数
            iFactRowSum = IIf(dvGetWorkNo.Count <= iMaxRowSum, dvGetWorkNo.Count, iMaxRowSum)
            For i = 0 To iFactRowSum - 1
                xlSheet.Cells(i + iStart, "B") = Me.C1DBG.Columns("Name").CellText(i)
                xlSheet.Cells(i + iStart, "C") = Me.C1DBG.Columns("salary_kh").CellText(i)
            Next
            '人数大于最大行数时填入第二列
            If dvGetWorkNo.Count > iMaxRowSum Then
                iFactRowSum = dvGetWorkNo.Count - iMaxRowSum
                For i = 0 To iFactRowSum - 1
                    xlSheet.Cells(i + iStart, "F") = Me.C1DBG.Columns("Name").CellText(i + iMaxRowSum)
                    xlSheet.Cells(i + iStart, "G") = Me.C1DBG.Columns("salary_kh").CellText(i + iMaxRowSum)
                Next
            End If
            xlSheet.Cells(41, "F") = MakeBigWord(GetDataSum(dvGetWorkNo, "salary_kh"))
            xlSheet.Cells(42, "G") = G_User
            xlBook.Save()
            xlApp.Quit()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub C1DBG_AfterColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1DBG.AfterColEdit
        Me.C1DBG.Columns("salary_kh").FooterText = GetDataSum(dvGetWorkNo, "salary_kh") & "元"
    End Sub
End Class
