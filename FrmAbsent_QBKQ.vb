Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FrmAbsent_QBKQ
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
    Friend WithEvents btResure As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents C1DBG4 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmAbsent_QBKQ))
        Me.dtp = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.btResure = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.C1DBG4 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btClose = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.C1DBG4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(78, 10)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(108, 21)
        Me.dtp.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "考勤日期:"
        '
        'btResure
        '
        Me.btResure.Location = New System.Drawing.Point(194, 10)
        Me.btResure.Name = "btResure"
        Me.btResure.Size = New System.Drawing.Size(66, 23)
        Me.btResure.TabIndex = 2
        Me.btResure.Text = "确认"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(62, 442)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 117
        Me.btSave.Text = "保存"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.C1DBG4)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 398)
        Me.GroupBox1.TabIndex = 116
        Me.GroupBox1.TabStop = False
        '
        'C1DBG4
        '
        Me.C1DBG4.AllowColMove = False
        Me.C1DBG4.CaptionHeight = 18
        Me.C1DBG4.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG4.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG4.Location = New System.Drawing.Point(4, 12)
        Me.C1DBG4.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG4.Name = "C1DBG4"
        Me.C1DBG4.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG4.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG4.PreviewInfo.ZoomFactor = 75
        Me.C1DBG4.RecordSelectorWidth = 17
        Me.C1DBG4.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1DBG4.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG4.RowHeight = 16
        Me.C1DBG4.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG4.Size = New System.Drawing.Size(256, 382)
        Me.C1DBG4.TabIndex = 0
        Me.C1DBG4.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style14{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" & _
        "tyle9{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Alig" & _
        "nVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView AllowColMove=""False"" Name="""" CaptionHe" & _
        "ight=""18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedC" & _
        "ellBorder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" " & _
        "HorizontalScrollGroup=""1""><ClientRect>0, 0, 252, 378</ClientRect><BorderSide>0</" & _
        "BorderSide><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Edi" & _
        "tor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle " & _
        "parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><Gr" & _
        "oupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2" & _
        """ /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent" & _
        "=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSele" & _
        "ctorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected" & _
        """ me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.Merge" & _
        "View></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal""" & _
        " me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me" & _
        "=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""" & _
        "Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""High" & _
        "lightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""Odd" & _
        "Row"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""" & _
        "FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</v" & _
        "ertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17<" & _
        "/DefaultRecSelWidth><ClientArea>0, 0, 252, 378</ClientArea><PrintPageHeaderStyle" & _
        " parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>" & _
        ""
        '
        'btClose
        '
        Me.btClose.Location = New System.Drawing.Point(130, 442)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(66, 24)
        Me.btClose.TabIndex = 118
        Me.btClose.Text = "返回"
        '
        'FrmAbsent_QBKQ
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(274, 475)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btResure)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmAbsent_QBKQ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "部门当天考勤"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.C1DBG4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim sqlstr As String
    Dim dskq As New DataSet
    Dim dwkq As New DataView
    Dim sqldakq As New SqlClient.SqlDataAdapter
    Private Sub FrmAbsent_QBKQ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp.Value = System.DateTime.Now()
    End Sub
    Private Sub btResure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResure.Click

        GL_Time = dtp.Value
        On Error GoTo Err
        'Dim sqlstr As String

        ''*************
        sqlstr = "select * from ABSENT where (DEPT_CODE = '" & G_DeptCode & "' or  DEPT_CODE ='29." & Mid(Trim(G_DeptCode), 4) & "' )  and  datediff(dd,ABSENTDATE,'" & GL_Time & "')=0  ORDER BY DEPT_CODE ,Code_HOLIDAY_TYPE "
        '
        'MsgBox(sqlstr)
        dwkq = Updatedata(sqldakq, sqlstr, dskq)

        'Call FillDAYNIGHTMARK()
        'Call FillDEPT_CODE()
        If dwkq.Count = 0 Then
            '************* 添加考勤表
            If MsgBox("当班考勤还没有生成，要生成当班考勤记录吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                Dim execsqlstr As String

                execsqlstr = "insert absent(DEPT_CODE, WORK_NO, ABSENTDATE, WORK_TYPE, Code_HOLIDAY_TYPE, "
                execsqlstr = execsqlstr & "Code_HOLIDAY_Back, DAYNIGHTMARK, Code_workstat,USER_NAME) "
                execsqlstr = execsqlstr & "select dept_code,work_no,'" & GL_Time & "', "
                execsqlstr = execsqlstr & "'甲', '11', '11','01','02','" & G_User & "' from tally_clerk "
                execsqlstr = execsqlstr & " where (dept_code='" & G_DeptCode & "' or DEPT_CODE ='29." & Mid(Trim(G_DeptCode), 4) & "')  "

                ExecSql(execsqlstr)
            End If
        Else
            If G_Part_Id = "16" Or G_Part_Id = "1" Or G_Part_Id = "24" Or G_Part_Id = "9" Then

            Else
                Dim dshh As New DataSet
                Getdata("SELECT DATENAME(hour, GETDATE())", dshh)
                If System.Convert.ToInt16(dshh.Tables(0).Rows(0)(0)) < 17 Then
                    MsgBox("当班考勤操作已完成，无法修改！", MsgBoxStyle.OkOnly, "提示")
                    btSave.Enabled = False
                    'Exit Sub
                End If

            End If
        End If

        '******************理货部
        'sqlstr = "select * from ABSENT where WORK_TYPE='管理人员' and (DEPT_CODE = '" & G_DeptCode & "' or  DEPT_CODE ='29." & Mid(Trim(G_DeptCode), 4) & "' )  and  datediff(dd,ABSENTDATE,'" & GL_Time & "')=0  ORDER BY DEPT_CODE ,Code_HOLIDAY_TYPE "
        ''
        ''MsgBox(sqlstr)
        'dwkq = Updatedata(sqldakq, sqlstr, dskq)
        'If dwkq.Count = 0 Then
        '    '************* 添加考勤表
        '    If MsgBox("当班考勤还没有生成，要生成当班考勤记录吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
        '        Dim execsqlstr As String

        '        execsqlstr = "insert absent(DEPT_CODE, WORK_NO, ABSENTDATE, WORK_TYPE, Code_HOLIDAY_TYPE, "
        '        execsqlstr = execsqlstr & "Code_HOLIDAY_Back, DAYNIGHTMARK, Code_workstat,USER_NAME) "
        '        execsqlstr = execsqlstr & "select dept_code,work_no,'" & GL_Time & "', "
        '        execsqlstr = execsqlstr & "tally_team, '11', '11','01','02','" & G_User & "' from tally_clerk "
        '        execsqlstr = execsqlstr & " where tally_team='管理人员' and (dept_code='" & G_DeptCode & "' or DEPT_CODE ='29." & Mid(Trim(G_DeptCode), 4) & "')  "

        '        ExecSql(execsqlstr)
        '    End If
        'Else
        '    If G_Part_Id = "16" Or G_Part_Id = "1" Then

        '    Else
        '        MsgBox("当班考勤操作已完成，无法修改！", MsgBoxStyle.OKOnly, "提示")
        '        btSave.Enabled = False
        '        Return
        '    End If
        'End If
        '******************

        dskq.Reset()
        dwkq = Updatedata(sqldakq, sqlstr, dskq)
        If dwkq.Count > 0 Then
            'CmbDEPT_CODE.SelectedValue = dskq.Tables(0).Rows(0).Item("DEPT_CODE")
            'DTPWATCHDATE.Value = dskq.Tables(0).Rows(0).Item("ABSENTDATE")
            'CmbWORK_TYPE.Text = dskq.Tables(0).Rows(0).Item("WORK_TYPE")
            'CmbDAYNIGHTMARK.SelectedValue = dskq.Tables(0).Rows(0).Item("DAYNIGHTMARK")

            '***************定义子表
            Dim i As Integer
            Dim dst As New DataSet
            Dim sqla As New SqlClient.SqlDataAdapter
            Dim sqlc As New SqlClient.SqlCommand

            Me.C1DBG4.DataSource = dwkq

            For i = 0 To Me.C1DBG4.Columns.Count - 1
                Me.C1DBG4.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Me.C1DBG4.Splits(0).DisplayColumns.Item("dept_code").Visible = True
            Me.C1DBG4.Splits(0).DisplayColumns.Item("WORK_NO").Visible = True
            Me.C1DBG4.Splits(0).DisplayColumns.Item("Code_HOLIDAY_TYPE").Visible = True

            Me.C1DBG4.Splits(0).DisplayColumns.Item("Code_workstat").Visible = False


            Me.C1DBG4.Columns.Item("WORK_NO").Caption = "姓名"
            Me.C1DBG4.Columns.Item("Code_HOLIDAY_TYPE").Caption = "假别"
            Me.C1DBG4.Columns.Item("dept_code").Caption = "部门"
            Me.C1DBG4.Columns.Item("Code_workstat").Caption = "工作状态"

            Me.C1DBG4.Splits(0).DisplayColumns("dept_code").Width = 40
            Me.C1DBG4.Splits(0).DisplayColumns("WORK_NO").Width = 80
            Me.C1DBG4.Splits(0).DisplayColumns("Code_HOLIDAY_TYPE").Width = 100
            Me.C1DBG4.Splits(0).DisplayColumns("Code_workstat").Width = 80
            Me.C1DBG4.Refresh()

            '***************姓名
            Me.C1DBG4.Columns.Item("WORK_NO").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG4.Columns.Item("WORK_NO").ValueItems.Translate = True
            Me.C1DBG4.Columns.Item("WORK_NO").ValueItems.Validate = True
            Me.C1DBG4.Splits(0).DisplayColumns.Item("WORK_NO").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT NAME, WORK_NO FROM TALLY_CLERK"
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("NAME"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("WORK_NO"))
                Me.C1DBG4.Columns.Item("WORK_NO").ValueItems.Values.Add(vi)
            Next

            '***************假别
            Me.C1DBG4.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG4.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Translate = True
            Me.C1DBG4.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Validate = True
            If G_DeptCode = "26.11" Then
                Me.C1DBG4.Splits(0).DisplayColumns.Item("Code_HOLIDAY_TYPE").AllowFocus = False
            End If
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT Code_Holiday_Type,Holiday_Type FROM Code_Holiday_Type where Code_Holiday_Type<98 order by orderby,convert(int,Code_Holiday_Type) "
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("Holiday_Type"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("Code_Holiday_Type"))
                Me.C1DBG4.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Values.Add(vi)
            Next
            '***************理货部
            Me.C1DBG4.Columns.Item("dept_code").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG4.Columns.Item("dept_code").ValueItems.Translate = True
            Me.C1DBG4.Columns.Item("dept_code").ValueItems.Validate = True
            Me.C1DBG4.Splits(0).DisplayColumns.Item("dept_code").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT DEPT_CODE, DEPT_SHORT FROM DEPARTMENT"
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("DEPT_SHORT"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("DEPT_CODE"))
                Me.C1DBG4.Columns.Item("DEPT_CODE").ValueItems.Values.Add(vi)
            Next
            '***************状态
            Me.C1DBG4.Columns.Item("Code_workstat").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG4.Columns.Item("Code_workstat").ValueItems.Translate = True
            Me.C1DBG4.Columns.Item("Code_workstat").ValueItems.Validate = True
            'Me.C1DBG.Splits(0).DisplayColumns.Item("Code_workstat").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT Code_workstat,workstat FROM Code_workstat" ' order by convert(int,Code_workstat) "
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("workstat"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("Code_workstat"))
                Me.C1DBG4.Columns.Item("Code_workstat").ValueItems.Values.Add(vi)
            Next
        End If


        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            If MsgBox("你确认要保存吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
                sqldakq.Update(dskq)
                Me.Close()
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        Me.Close()
    End Sub



End Class
