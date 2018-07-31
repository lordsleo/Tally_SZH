Imports TALLY.DBControl
Public Class FrmFind
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
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
    Friend WithEvents DT As System.Windows.Forms.DateTimePicker
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnMakeSql As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmFind))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.DT = New System.Windows.Forms.DateTimePicker()
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.btnMakeSql = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(402, 206)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(65, 24)
        Me.btnCancel.TabIndex = 60
        Me.btnCancel.Text = "取消(&C)"
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Location = New System.Drawing.Point(192, 206)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(65, 24)
        Me.btnSelectAll.TabIndex = 59
        Me.btnSelectAll.Text = "全选(&S)"
        '
        'DT
        '
        Me.DT.CustomFormat = "yyyy/mm/dd"
        Me.DT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT.Location = New System.Drawing.Point(408, 24)
        Me.DT.Name = "DT"
        Me.DT.Size = New System.Drawing.Size(18, 21)
        Me.DT.TabIndex = 58
        Me.DT.Value = New Date(2003, 4, 29, 0, 0, 0, 0)
        Me.DT.Visible = False
        '
        'C1DBG
        '
        Me.C1DBG.AllowAddNew = True
        Me.C1DBG.AllowDelete = True
        Me.C1DBG.AllowFilter = True
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1DBG.AllowSort = False
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.CollapseColor = System.Drawing.Color.Black
        Me.C1DBG.DataChanged = False
        Me.C1DBG.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBG.ExpandColor = System.Drawing.Color.Black
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1DBG.Location = New System.Drawing.Point(2, 2)
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
        Me.C1DBG.Size = New System.Drawing.Size(648, 198)
        Me.C1DBG.TabIndex = 57
        Me.C1DBG.PropBag = CType(resources.GetObject("C1DBG.PropBag"), String)
        '
        'btnMakeSql
        '
        Me.btnMakeSql.Location = New System.Drawing.Point(332, 206)
        Me.btnMakeSql.Name = "btnMakeSql"
        Me.btnMakeSql.Size = New System.Drawing.Size(65, 24)
        Me.btnMakeSql.TabIndex = 56
        Me.btnMakeSql.Text = "确认(&R)"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(32, 208)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 24)
        Me.btnAdd.TabIndex = 55
        Me.btnAdd.Text = "增加(&A)"
        Me.btnAdd.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(262, 206)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(65, 24)
        Me.btnDelete.TabIndex = 54
        Me.btnDelete.Text = "删除(&D)"
        '
        'FrmFind
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(652, 233)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCancel, Me.btnSelectAll, Me.DT, Me.C1DBG, Me.btnMakeSql, Me.btnAdd, Me.btnDelete})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFind"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "检索"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As New DataSet()
    Dim Act_Flag As Integer
    Dim row As Integer
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Me.C1DBG.MoveLast()
        Me.C1DBG.Row = Me.C1DBG.Row + 1
        Me.C1DBG.Select()
        Me.C1DBG.Col = 1

    End Sub

    Private Sub C1DBG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C1DBG.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.C1DBG.Col = 6 Then
                Me.C1DBG.Row = Me.C1DBG.Row + 1
                Me.C1DBG.Col = 1
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Me.C1DBG.Delete()
    End Sub
    Private Sub FrmFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        row = -1
        DT.Value = Today()
        Flag = 0
        Call C1DBGFill() '提充 C1TRUEDBGRID        

        Call FiledFill(Table_Name) '提充 字段列
    End Sub
    Private Sub C1DBGFill()
        Dim strsql As String
        Dim s As String
        Dim i As Integer
        Try
            strsql = "select * from Find_Temp where 1>2" '******要修改

            Me.C1DBG.DataSource = Getdata(strsql, ds)  ' class dbcontrol getdata fuction
            Me.C1DBG.Splits(0).DisplayColumns.Item(0).Visible = False '不显示的列名在最前面
            Me.C1DBG.Columns.Item(1).Caption = "左括号"
            Me.C1DBG.Columns.Item(2).Caption = "字段"
            Me.C1DBG.Columns.Item(3).Caption = "关系"
            Me.C1DBG.Columns.Item(4).Caption = "值"
            Me.C1DBG.Columns.Item(5).Caption = "右括号"
            Me.C1DBG.Columns.Item(6).Caption = "逻辑关系"

            Me.C1DBG.Columns.Item(1).ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            s = ""
            For i = 0 To 5
                s = s & "("
                Dim vi1 As New C1.Win.C1TrueDBGrid.ValueItem()
                vi1.DisplayValue = s
                vi1.Value = s
                Me.C1DBG.Columns.Item(1).ValueItems.Values.Add(vi1)
            Next i
            Dim vi11 As New C1.Win.C1TrueDBGrid.ValueItem()
            vi11.DisplayValue = ""
            vi11.Value = ""
            Me.C1DBG.Columns.Item(1).ValueItems.Values.Add(vi11)

            Me.C1DBG.Columns.Item(2).ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns.Item(2).ValueItems.Translate = True
            Me.C1DBG.Columns.Item(3).ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Dim vi37 As New C1.Win.C1TrueDBGrid.ValueItem()
            vi37.DisplayValue = "Like"
            vi37.Value = "Like"
            Me.C1DBG.Columns.Item(3).ValueItems.Values.Add(vi37)

            Dim vi31 As New C1.Win.C1TrueDBGrid.ValueItem()
            vi31.DisplayValue = ">"
            vi31.Value = ">"
            Me.C1DBG.Columns.Item(3).ValueItems.Values.Add(vi31)
            Dim vi32 As New C1.Win.C1TrueDBGrid.ValueItem()
            vi32.DisplayValue = "<"
            vi32.Value = "<"
            Me.C1DBG.Columns.Item(3).ValueItems.Values.Add(vi32)
            Dim vi33 As New C1.Win.C1TrueDBGrid.ValueItem()
            vi33.DisplayValue = ">="
            vi33.Value = ">="
            Me.C1DBG.Columns.Item(3).ValueItems.Values.Add(vi33)
            Dim vi34 As New C1.Win.C1TrueDBGrid.ValueItem()
            vi34.DisplayValue = "<="
            vi34.Value = "<="
            Me.C1DBG.Columns.Item(3).ValueItems.Values.Add(vi34)
            Dim vi35 As New C1.Win.C1TrueDBGrid.ValueItem()
            vi35.DisplayValue = "="
            vi35.Value = "="
            Me.C1DBG.Columns.Item(3).ValueItems.Values.Add(vi35)
            Dim vi36 As New C1.Win.C1TrueDBGrid.ValueItem()
            vi36.DisplayValue = "<>"
            vi36.Value = "<>"
            Me.C1DBG.Columns.Item(3).ValueItems.Values.Add(vi36)
            
            Dim vi38 As New C1.Win.C1TrueDBGrid.ValueItem()
            vi38.DisplayValue = ""
            vi38.Value = ""
            Me.C1DBG.Columns.Item(3).ValueItems.Values.Add(vi38)

            Me.C1DBG.Columns.Item(5).ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            s = ""
            For i = 0 To 5
                s = s & ")"
                Dim vi5 As New C1.Win.C1TrueDBGrid.ValueItem()
                vi5.DisplayValue = s
                vi5.Value = s
                Me.C1DBG.Columns.Item(5).ValueItems.Values.Add(vi5)
            Next i
            Dim vi51 As New C1.Win.C1TrueDBGrid.ValueItem()
            vi51.DisplayValue = ""
            vi51.Value = ""
            Me.C1DBG.Columns.Item(5).ValueItems.Values.Add(vi51)


            Me.C1DBG.Columns.Item(6).ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Dim vi61 As New C1.Win.C1TrueDBGrid.ValueItem()
            vi61.DisplayValue = "与"
            vi61.Value = "And"
            Me.C1DBG.Columns.Item(6).ValueItems.Values.Add(vi61)
            Dim vi62 As New C1.Win.C1TrueDBGrid.ValueItem()
            vi62.DisplayValue = "或"
            vi62.Value = "Or"
            Me.C1DBG.Columns.Item(6).ValueItems.Values.Add(vi62)
            Dim vi63 As New C1.Win.C1TrueDBGrid.ValueItem()
            vi63.DisplayValue = ""
            vi63.Value = ""
            Me.C1DBG.Columns.Item(6).ValueItems.Values.Add(vi63)



            Me.C1DBG.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        '**************
    End Sub
    Private Sub FiledFill(ByVal TableName As String)

        Dim sqla As New SqlClient.SqlDataAdapter()
        Dim sqlc As New SqlClient.SqlCommand()
        Dim ds As New DataSet()
        Dim i As Integer
        Try
            sqlc.Connection = sqlconn
            sqlc.CommandText = "select * from Field_Att where Table_Name='" & TableName & "' order by ID"
            sqla.SelectCommand = sqlc
            ds.Reset()
            sqla.Fill(ds)
            For i = 0 To ds.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                If Len(Trim(ds.Tables(0).Rows(i)("Field_Exp"))) > 0 Then
                    vi.DisplayValue = Trim(ds.Tables(0).Rows(i)("Field_Cha"))
                    vi.Value = Trim(ds.Tables(0).Rows(i)("Field_Exp"))
                Else
                    vi.DisplayValue = Trim(ds.Tables(0).Rows(i)("Field_Cha"))
                    vi.Value = Trim(ds.Tables(0).Rows(i)("Field_Eng"))
                End If
                Me.C1DBG.Columns.Item("Field").ValueItems.Values.Add(vi)
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        Finally
            sqlconn.Close()
        End Try

    End Sub

    Private Sub DT_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT.ValueChanged
        Try
            If Act_Flag = 1 Then Me.C1DBG.Columns.Item("Result").Value = CType(Year(DT.Value), String) & "/" & CType(Month(DT.Value), String) & "/" & CType(Microsoft.VisualBasic.Day(DT.Value), String)
            Me.C1DBG.Refresh()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub C1DBG_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles C1DBG.RowColChange

        Dim sqla As New SqlClient.SqlDataAdapter()
        Dim sqlc As New SqlClient.SqlCommand()
        Dim ds As New DataSet()
        Dim i As Integer


        If e.LastCol = 2 Or e.LastRow <> row Then
            'row = e.LastRow
            Try
                sqlc.Connection = sqlconn
                sqlc.CommandText = "select * from Field_Att where Table_Name='" & Table_Name & "' and Field_Eng='" & Me.C1DBG.Columns.Item("Field").Value & "'"
                sqla.SelectCommand = sqlc
                ds.Reset()
                sqla.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    If Upper(Trim(ds.Tables(0).Rows(0)("Field_Type"))) = "N" Then

                        Me.C1DBG.Splits(0).DisplayColumns("Result").Button = False
                        DT.Visible = False

                    ElseIf Upper(Trim(ds.Tables(0).Rows(0)("Field_Type"))) = "D" Then

                        Me.C1DBG.Splits(0).DisplayColumns("Result").Button = False
                        If Me.C1DBG.Col = 4 Then
                            DT.Visible = True
                            DT.Top = Me.C1DBG.Top + 20 + Me.C1DBG.Row() * 16
                            DT.Left = 404
                            DT.Refresh()
                        End If
                    ElseIf Upper(Trim(ds.Tables(0).Rows(0)("Field_Type"))) = "C" Then

                        DT.Visible = False

                        If Len(Trim(ds.Tables(0).Rows(0)("Code_Table"))) > 0 Then
                            Me.C1DBG.Splits(0).DisplayColumns("Result").Button = True

                        Else
                            Me.C1DBG.Splits(0).DisplayColumns("Result").Button = False
                        End If

                    End If
                End If
            Catch ex As System.Exception
                MsgBox(ex.Message)
            Finally
                sqlconn.Close()
            End Try

        End If

    End Sub


    Private Sub btnMakeSql_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMakeSql.Click

        Dim sqla As New SqlClient.SqlDataAdapter()
        Dim sqlc As New SqlClient.SqlCommand()
        Dim ds As New DataSet()

        Dim s As String
        Dim temp As String
        Dim i As Integer
        Try
            temp = ""
            s = ""
            i = -1
            Me.C1DBG.MoveFirst()
            Do
                If i < Me.C1DBG.Row() Then
                    If Len(Trim(Me.C1DBG.Columns.Item("Field").Value.ToString)) > 0 And Len(Trim(Me.C1DBG.Columns.Item("LogicExpress").Value.ToString)) > 0 And Len(Trim(Me.C1DBG.Columns.Item("Result").Value.ToString)) > 0 Then
                        If Trim(Me.C1DBG.Columns.Item("LogicExpress").Value.ToString) = "Like" Then
                            s = s & Me.C1DBG.Columns.Item("LBracket").Value.ToString & " " & Me.C1DBG.Columns.Item("Field").Value.ToString & " " & Me.C1DBG.Columns.Item("LogicExpress").Value.ToString & " '%" & Me.C1DBG.Columns.Item("Result").Value.ToString & "%' " & Me.C1DBG.Columns.Item("RBracket").Value.ToString & " " & Me.C1DBG.Columns.Item("LogicRelation").Value.ToString & " "
                        Else
                            sqlc.Connection = sqlconn
                            sqlc.CommandText = "select * from Field_Att where Table_Name='" & Table_Name & "' and Field_Eng='" & Me.C1DBG.Columns.Item("Field").Value & "'"
                            sqla.SelectCommand = sqlc
                            ds.Reset()
                            sqla.Fill(ds)
                            If ds.Tables(0).Rows.Count > 0 Then
                                If Upper(Trim(ds.Tables(0).Rows(0)("Field_Type"))) = "N" Then

                                    s = s & Me.C1DBG.Columns.Item("LBracket").Value.ToString & " " & Me.C1DBG.Columns.Item("Field").Value.ToString & " " & Me.C1DBG.Columns.Item("LogicExpress").Value.ToString & " " & Me.C1DBG.Columns.Item("Result").Value.ToString & " " & Me.C1DBG.Columns.Item("RBracket").Value.ToString & " " & Me.C1DBG.Columns.Item("LogicRelation").Value.ToString & " "


                                ElseIf Upper(Trim(ds.Tables(0).Rows(0)("Field_Type"))) = "D" Then

                                    s = s & Me.C1DBG.Columns.Item("LBracket").Value.ToString & " " & Me.C1DBG.Columns.Item("Field").Value.ToString & " " & Me.C1DBG.Columns.Item("LogicExpress").Value.ToString & " '" & Me.C1DBG.Columns.Item("Result").Value.ToString & "' " & Me.C1DBG.Columns.Item("RBracket").Value.ToString & " " & Me.C1DBG.Columns.Item("LogicRelation").Value.ToString & " "

                                ElseIf Upper(Trim(ds.Tables(0).Rows(0)("Field_Type"))) = "C" Then

                                    If Len(Trim(ds.Tables(0).Rows(0)("Query_Field"))) > 0 Then
                                        s = s & Me.C1DBG.Columns.Item("LBracket").Value.ToString & " " & ds.Tables(0).Rows(0)("Query_Field") & " " & Me.C1DBG.Columns.Item("LogicExpress").Value.ToString & " '" & Me.C1DBG.Columns.Item("Result").Value.ToString & "' " & Me.C1DBG.Columns.Item("RBracket").Value.ToString & " " & Me.C1DBG.Columns.Item("LogicRelation").Value.ToString & " "

                                    Else
                                        s = s & Me.C1DBG.Columns.Item("LBracket").Value.ToString & " " & Me.C1DBG.Columns.Item("Field").Value.ToString & " " & Me.C1DBG.Columns.Item("LogicExpress").Value.ToString & " '" & Me.C1DBG.Columns.Item("Result").Value.ToString & "' " & Me.C1DBG.Columns.Item("RBracket").Value.ToString & " " & Me.C1DBG.Columns.Item("LogicRelation").Value.ToString & " "

                                    End If
                                End If
                            End If
                        End If
                        temp = Trim(Me.C1DBG.Columns.Item("LogicRelation").Value.ToString)
                    Else
                        Flag = 1
                        MsgBox("条件设置有错误！")
                        Exit Sub
                    End If
                    If Len(Trim(Me.C1DBG.Columns.Item("LogicRelation").Value.ToString)) = 0 Then
                        i = Me.C1DBG.Row()
                        Me.C1DBG.MoveNext()

                        '*************
                        If i >= 0 And i < Me.C1DBG.Row() And Len(Trim(temp)) = 0 Then
                            Flag = 1
                            MsgBox("逻辑关系不正确！")
                            Exit Sub
                        End If
                        '**************
                        Flag = 0
                        Exit Do
                    Else
                        i = Me.C1DBG.Row()
                        Me.C1DBG.MoveNext()
                    End If

                Else
                    Flag = 1
                    MsgBox("最后一行不能设置逻辑关系！")
                    Exit Sub
                End If
            Loop
            Sql_Find = s

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub C1DBG_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1DBG.ButtonClick
        Dim sqla As New SqlClient.SqlDataAdapter()
        Dim sqlc As New SqlClient.SqlCommand()
        Dim ds As New DataSet()
        Dim ds2 As New DataSet()
        Dim i As Integer
        Try
            sqlc.Connection = sqlconn
            sqlc.CommandText = "select * from Field_Att where Table_Name='" & Table_Name & "' and Field_Eng='" & Me.C1DBG.Columns.Item("Field").Value & "'"
            sqla.SelectCommand = sqlc
            ds.Reset()
            sqla.Fill(ds)

            If e.ColIndex = 4 Then
                ''If Upper(Trim(ds.Tables(0).Rows(0)("Field_Type"))) = "D" Then

                ''    'Me.C1DBG.Columns.Item("Result").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.Normal
                ''    'Me.C1DBG.Columns.Item("Result").ValueItems.Translate = false
                ''    DT.Visible = True
                ''    DT.Top = Me.C1DBG.Top + 20 + Me.C1DBG.Row() * 16
                ''    DT.Left = 404
                ''    DT.Refresh()

                ''    'Me.C1DBG.Refresh()
                ''End If
                If Upper(Trim(ds.Tables(0).Rows(0)("Field_Type"))) = "C" Then
                    DT.Visible = False

                    If Len(Trim(ds.Tables(0).Rows(0)("Code_Table"))) > 0 Then

                        sqla.SelectCommand.Connection = sqlconn
                        If ds.Tables(0).Rows(0)("IsCompany") = "1" Then
                            sqla.SelectCommand.CommandText = "select value=" & Trim(ds.Tables(0).Rows(0)("Code_Field")) & ",Descr=" & Trim(ds.Tables(0).Rows(0)("Des_Field")) & "  from " & Trim(ds.Tables(0).Rows(0)("Code_Table")) & " where Hide_Company Like '" & G_DeptCode & "%'"
                        Else
                            sqla.SelectCommand.CommandText = "select value=" & Trim(ds.Tables(0).Rows(0)("Code_Field")) & ",Descr=" & Trim(ds.Tables(0).Rows(0)("Des_Field")) & "  from " & Trim(ds.Tables(0).Rows(0)("Code_Table"))
                        End If

                        If Upper(Trim(ds.Tables(0).Rows(0)("Code_Table"))) = "DEPARTMENT" Then
                            sqla.SelectCommand.CommandText = "select value=" & Trim(ds.Tables(0).Rows(0)("Code_Field")) & ",Descr=" & Trim(ds.Tables(0).Rows(0)("Des_Field")) & "  from " & Trim(ds.Tables(0).Rows(0)("Code_Table")) & " where Dept_Code Like '" & G_DeptCode & "%'"
                        End If
                        ds2.Reset()
                        sqla.Fill(ds2)
                        If ds2.Tables(0).Rows.Count > 0 Then
                            Me.C1DBG.Columns.Item("Result").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
                            Me.C1DBG.Columns.Item("Result").ValueItems.Translate = True
                            Do While Me.C1DBG.Columns.Item("Result").ValueItems.Values.Count > 0
                                Me.C1DBG.Columns.Item("Result").ValueItems.Values.RemoveAt(0)
                            Loop
                            For i = 0 To ds2.Tables(0).Rows.Count - 1
                                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                                vi.DisplayValue = ds2.Tables(0).Rows(i)("Descr")
                                vi.Value = ds2.Tables(0).Rows(i)("Value")
                                Me.C1DBG.Columns.Item("Result").ValueItems.Values.Add(vi)
                            Next
                        End If

                    End If
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmFind_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Act_Flag = 1
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Flag = 1
        Me.Close()
    End Sub

    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click
        Flag = 2
        Me.Close()
    End Sub

    Private Sub Frm_Find_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        If Flag = 0 Then
            Call btnMakeSql_Click(sender, e)
        End If
    End Sub

    Private Sub C1DBG_ColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1DBG.ColEdit
        If e.ColIndex = 2 And Len(Trim(Me.C1DBG.Columns.Item(2).Text)) > 0 Then
            row = Me.C1DBG.Row
        End If
    End Sub
End Class
