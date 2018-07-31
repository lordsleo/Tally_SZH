Imports TALLY.DBControl
Public Class Frmattendancerecords_ADD
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim dw As New DataView()
    Dim sqlda As New SqlClient.SqlDataAdapter()

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
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbDEPT_CODE As System.Windows.Forms.ComboBox
    Friend WithEvents DTPWATCHDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmbDAYNIGHTMARK As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmbWORK_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frmattendancerecords_ADD))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbDEPT_CODE = New System.Windows.Forms.ComboBox
        Me.DTPWATCHDATE = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.CmbDAYNIGHTMARK = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.CmbWORK_TYPE = New System.Windows.Forms.ComboBox
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.GB = New System.Windows.Forms.GroupBox
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB.SuspendLayout()
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(163, 348)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 6
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(93, 348)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 5
        Me.btSave.Text = "确认"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "部门"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbDEPT_CODE
        '
        Me.CmbDEPT_CODE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbDEPT_CODE.Enabled = False
        Me.CmbDEPT_CODE.Location = New System.Drawing.Point(65, 2)
        Me.CmbDEPT_CODE.Name = "CmbDEPT_CODE"
        Me.CmbDEPT_CODE.Size = New System.Drawing.Size(92, 21)
        Me.CmbDEPT_CODE.TabIndex = 0
        '
        'DTPWATCHDATE
        '
        Me.DTPWATCHDATE.CustomFormat = "yyyy/MM/dd"
        Me.DTPWATCHDATE.Enabled = False
        Me.DTPWATCHDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPWATCHDATE.Location = New System.Drawing.Point(224, 2)
        Me.DTPWATCHDATE.Name = "DTPWATCHDATE"
        Me.DTPWATCHDATE.Size = New System.Drawing.Size(92, 21)
        Me.DTPWATCHDATE.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(162, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "日期"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbDAYNIGHTMARK
        '
        Me.CmbDAYNIGHTMARK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbDAYNIGHTMARK.Enabled = False
        Me.CmbDAYNIGHTMARK.Location = New System.Drawing.Point(224, 26)
        Me.CmbDAYNIGHTMARK.Name = "CmbDAYNIGHTMARK"
        Me.CmbDAYNIGHTMARK.Size = New System.Drawing.Size(92, 20)
        Me.CmbDAYNIGHTMARK.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "班次"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(162, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "班别"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbWORK_TYPE
        '
        Me.CmbWORK_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbWORK_TYPE.Enabled = False
        Me.CmbWORK_TYPE.Location = New System.Drawing.Point(65, 26)
        Me.CmbWORK_TYPE.Name = "CmbWORK_TYPE"
        Me.CmbWORK_TYPE.Size = New System.Drawing.Size(92, 20)
        Me.CmbWORK_TYPE.TabIndex = 1
        '
        'C1DBG
        '
        Me.C1DBG.AllowColMove = False
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
        Me.C1DBG.Location = New System.Drawing.Point(4, 14)
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
        Me.C1DBG.Size = New System.Drawing.Size(310, 280)
        Me.C1DBG.TabIndex = 0
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Bord" & _
        "er:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView AllowColMove=""False"" Name="""" CaptionHeight=""18"" ColumnCa" & _
        "ptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordS" & _
        "electorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGr" & _
        "oup=""1""><ClientRect>0, 0, 306, 276</ClientRect><BorderSide>0</BorderSide><Captio" & _
        "nStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /" & _
        "><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar""" & _
        " me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""G" & _
        "roup"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowS" & _
        "tyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""St" & _
        "yle4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""" & _
        "RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><S" & _
        "tyle parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><Nam" & _
        "edStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><S" & _
        "tyle parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Styl" & _
        "e parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style" & _
        " parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style" & _
        " parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style pare" & _
        "nt=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Styl" & _
        "e parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSpl" & _
        "its>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidt" & _
        "h><ClientArea>0, 0, 306, 276</ClientArea></Blob>"
        '
        'GB
        '
        Me.GB.Controls.Add(Me.C1DBG)
        Me.GB.Location = New System.Drawing.Point(1, 48)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(317, 296)
        Me.GB.TabIndex = 4
        Me.GB.TabStop = False
        '
        'Frmattendancerecords_ADD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(320, 383)
        Me.Controls.Add(Me.CmbDAYNIGHTMARK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CmbWORK_TYPE)
        Me.Controls.Add(Me.DTPWATCHDATE)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CmbDEPT_CODE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.GB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmattendancerecords_ADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "考勤记录"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Frmattendancerecords_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim sqlstr As String
        'sqlstr = "select DEPT_CODE,WORK_NO,DAYNIGHTMARK+10 as Code_HOLIDAY_TYPE,Code_workstat from ABSENT where DEPT_CODE Like '" & G_DeptCode & "' and DAYNIGHTMARK='" & GL_Str & "' and datediff(dd,ABSENTDATE,'" & GL_Time & "')=0  ORDER BY DEPT_CODE ,Code_HOLIDAY_TYPE "
        sqlstr = "select * from ABSENT where DEPT_CODE Like '" & G_DeptCode & "' and DAYNIGHTMARK='" & GL_Str & "' and datediff(dd,ABSENTDATE,'" & GL_Time & "')=0  ORDER BY DEPT_CODE ,Code_HOLIDAY_TYPE "
        dw = Updatedata(sqlda, sqlstr, ds)

        Call FillDAYNIGHTMARK()
        Call FillDEPT_CODE()

        If dw.Count > 0 Then
            CmbDEPT_CODE.SelectedValue = ds.Tables(0).Rows(0).Item("DEPT_CODE")
            DTPWATCHDATE.Value = ds.Tables(0).Rows(0).Item("ABSENTDATE")
            CmbWORK_TYPE.Text = ds.Tables(0).Rows(0).Item("WORK_TYPE")
            CmbDAYNIGHTMARK.SelectedValue = ds.Tables(0).Rows(0).Item("DAYNIGHTMARK")

            '***************定义子表
            Dim i As Integer
            Dim dst As New DataSet()
            Dim sqla As New SqlClient.SqlDataAdapter()
            Dim sqlc As New SqlClient.SqlCommand()

            Me.C1DBG.DataSource = dw

            For i = 0 To Me.C1DBG.Columns.Count - 1
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Me.C1DBG.Splits(0).DisplayColumns.Item("dept_code").Visible = True
            Me.C1DBG.Splits(0).DisplayColumns.Item("WORK_NO").Visible = True
            Me.C1DBG.Splits(0).DisplayColumns.Item("Code_HOLIDAY_TYPE").Visible = True

            Me.C1DBG.Splits(0).DisplayColumns.Item("Code_workstat").Visible = True


            Me.C1DBG.Columns.Item("WORK_NO").Caption = "姓名"
            Me.C1DBG.Columns.Item("Code_HOLIDAY_TYPE").Caption = "假别"
            Me.C1DBG.Columns.Item("dept_code").Caption = "部门"
            Me.C1DBG.Columns.Item("Code_workstat").Caption = "工作状态"

            Me.C1DBG.Splits(0).DisplayColumns("dept_code").Width = 40
            Me.C1DBG.Splits(0).DisplayColumns("WORK_NO").Width = 70
            Me.C1DBG.Splits(0).DisplayColumns("Code_HOLIDAY_TYPE").Width = 80
            Me.C1DBG.Splits(0).DisplayColumns("Code_workstat").Width = 80
            Me.C1DBG.Refresh()

            '***************姓名
            Me.C1DBG.Columns.Item("WORK_NO").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns.Item("WORK_NO").ValueItems.Translate = True
            Me.C1DBG.Columns.Item("WORK_NO").ValueItems.Validate = True
            Me.C1DBG.Splits(0).DisplayColumns.Item("WORK_NO").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT NAME, WORK_NO FROM TALLY_CLERK"
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("NAME"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("WORK_NO"))
                Me.C1DBG.Columns.Item("WORK_NO").ValueItems.Values.Add(vi)
            Next

            '***************假别
            Me.C1DBG.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Translate = True
            Me.C1DBG.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Validate = True
            If G_DeptCode = "26.11" Then
                Me.C1DBG.Splits(0).DisplayColumns.Item("Code_HOLIDAY_TYPE").AllowFocus = False
            End If
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT Code_Holiday_Type,Holiday_Type FROM Code_Holiday_Type where Code_Holiday_Type<98 order by convert(int,Code_Holiday_Type) "
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("Holiday_Type"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("Code_Holiday_Type"))
                Me.C1DBG.Columns.Item("Code_HOLIDAY_TYPE").ValueItems.Values.Add(vi)
            Next
            '***************理货部
            Me.C1DBG.Columns.Item("dept_code").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns.Item("dept_code").ValueItems.Translate = True
            Me.C1DBG.Columns.Item("dept_code").ValueItems.Validate = True
            Me.C1DBG.Splits(0).DisplayColumns.Item("dept_code").AllowFocus = False
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT DEPT_CODE, DEPT_SHORT FROM DEPARTMENT"
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("DEPT_SHORT"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("DEPT_CODE"))
                Me.C1DBG.Columns.Item("DEPT_CODE").ValueItems.Values.Add(vi)
            Next
            '***************状态
            Me.C1DBG.Columns.Item("Code_workstat").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns.Item("Code_workstat").ValueItems.Translate = True
            Me.C1DBG.Columns.Item("Code_workstat").ValueItems.Validate = True
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
                Me.C1DBG.Columns.Item("Code_workstat").ValueItems.Values.Add(vi)
            Next
        End If

            CmbDEPT_CODE.Focus()
            If G_DeptCode = "26.11" Then
                btSave.Enabled = False
                CmbDEPT_CODE.Text = "所有理货人员"
            End If
            Exit Sub
Err:
            Resume Next
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            If MsgBox("你确认要修改吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
                sqlda.Update(ds)
                Me.Close()
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FillDAYNIGHTMARK()
        Dim sqldc As String
        Dim dvc As New DataView()
        Dim dsc As New DataSet()
        sqldc = "SELECT Code_WorkTime,WorkTime FROM Code_WorkTime"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbDAYNIGHTMARK.DataSource = dvc
        Me.CmbDAYNIGHTMARK.DisplayMember = "WorkTime"
        Me.CmbDAYNIGHTMARK.ValueMember = "Code_WorkTime"
    End Sub

    Private Sub FillDEPT_CODE()
        Dim sqldc As String
        Dim dvc As New DataView()
        Dim dsc As New DataSet()
        sqldc = "select DEPT_CODE,DEPT_NAME from DEPARTMENT"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbDEPT_CODE.DataSource = dvc
        Me.CmbDEPT_CODE.DisplayMember = "DEPT_NAME"
        Me.CmbDEPT_CODE.ValueMember = "DEPT_CODE"
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

End Class
