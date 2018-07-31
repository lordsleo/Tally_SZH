Imports TALLY.DBControl
Public Class FrmPort_Edit
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim sqlda_sub As New SqlClient.SqlDataAdapter()
    Dim ds_sub As New DataSet()
    Dim dw As New DataView
    Dim txt1, txt2, txt3, txt4, txt5 As String '检查是否真正的修改了数据
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
    Friend WithEvents txtShort As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNationality As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtENG As System.Windows.Forms.TextBox
    Friend WithEvents txtCHA As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btResume As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnResume As System.Windows.Forms.Button
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPort_Edit))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Me.txtShort = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtNationality = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtENG = New System.Windows.Forms.TextBox
        Me.txtCHA = New System.Windows.Forms.TextBox
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        Me.btResume = New System.Windows.Forms.Button
        Me.txtID = New System.Windows.Forms.TextBox
        Me.btnResume = New System.Windows.Forms.Button
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btnDelete = New System.Windows.Forms.Button
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtShort
        '
        Me.txtShort.Location = New System.Drawing.Point(84, 98)
        Me.txtShort.MaxLength = 4
        Me.txtShort.Name = "txtShort"
        Me.txtShort.Size = New System.Drawing.Size(276, 21)
        Me.txtShort.TabIndex = 144
        Me.txtShort.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 18)
        Me.Label6.TabIndex = 141
        Me.Label6.Text = "助记码"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNationality
        '
        Me.txtNationality.Location = New System.Drawing.Point(84, 74)
        Me.txtNationality.Name = "txtNationality"
        Me.txtNationality.Size = New System.Drawing.Size(276, 20)
        Me.txtNationality.TabIndex = 138
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "所属国家"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtENG
        '
        Me.txtENG.Location = New System.Drawing.Point(84, 50)
        Me.txtENG.MaxLength = 60
        Me.txtENG.Name = "txtENG"
        Me.txtENG.Size = New System.Drawing.Size(276, 21)
        Me.txtENG.TabIndex = 135
        Me.txtENG.Text = ""
        '
        'txtCHA
        '
        Me.txtCHA.Location = New System.Drawing.Point(84, 26)
        Me.txtCHA.MaxLength = 40
        Me.txtCHA.Name = "txtCHA"
        Me.txtCHA.Size = New System.Drawing.Size(276, 21)
        Me.txtCHA.TabIndex = 134
        Me.txtCHA.Text = ""
        '
        'txtCode
        '
        Me.txtCode.Enabled = False
        Me.txtCode.Location = New System.Drawing.Point(84, 2)
        Me.txtCode.MaxLength = 6
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(276, 21)
        Me.txtCode.TabIndex = 133
        Me.txtCode.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "港口英文描述"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "港口中文描述"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 129
        Me.Label1.Text = "港口代码"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(196, 124)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 128
        Me.btQuit.Text = "取消"
        '
        'btResume
        '
        Me.btResume.Location = New System.Drawing.Point(128, 124)
        Me.btResume.Name = "btResume"
        Me.btResume.Size = New System.Drawing.Size(65, 24)
        Me.btResume.TabIndex = 127
        Me.btResume.Text = "确认"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 0)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 125
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'btnResume
        '
        Me.btnResume.Location = New System.Drawing.Point(184, 342)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(65, 24)
        Me.btnResume.TabIndex = 146
        Me.btnResume.Text = "确认"
        '
        'C1DBG
        '
        Me.C1DBG.AllowAddNew = True
        Me.C1DBG.AllowDelete = True
        Me.C1DBG.AllowFilter = True
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1DBG.AllowSort = True
        Me.C1DBG.Caption = "相关船公司港口代码表"
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.CollapseColor = System.Drawing.Color.Black
        Me.C1DBG.DataChanged = False
        Me.C1DBG.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBG.ExpandColor = System.Drawing.Color.Black
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 152)
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
        Me.C1DBG.Size = New System.Drawing.Size(360, 182)
        Me.C1DBG.TabIndex = 145
        Me.C1DBG.Text = "C1TrueDBGrid1"
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        ", 18, 356, 160</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style" & _
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
        "356, 178</ClientArea></Blob>"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(116, 342)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(65, 24)
        Me.btnDelete.TabIndex = 147
        Me.btnDelete.Text = "子表删除"
        '
        'FrmPort_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(364, 369)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnResume)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.txtShort)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNationality)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtENG)
        Me.Controls.Add(Me.txtCHA)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btResume)
        Me.Controls.Add(Me.txtID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPort_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "港口信息_编辑"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        If e.KeyChar = Chr(13) Then
            txtCHA.Focus()
        End If
    End Sub
    Private Sub txtCHA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCHA.KeyPress
        If e.KeyChar = Chr(13) Then
            txtENG.Focus()
        End If
    End Sub
    Private Sub txtENG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtENG.KeyPress
        If e.KeyChar = Chr(13) Then
            txtNationality.Focus()
        End If
    End Sub

    Private Sub txtNationality_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNationality.KeyPress
        If e.KeyChar = Chr(13) Then
            txtShort.Focus()
        End If
    End Sub

    Private Sub txtShort_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtShort.KeyPress
        If e.KeyChar = Chr(13) Then
            btResume.Focus()
        End If
    End Sub

    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim ds1 As New DataSet()
        Dim ds2 As New DataSet()
        Dim sqlstr As String
        Dim sqla As New SqlClient.SqlDataAdapter()
        Dim sqlc As New SqlClient.SqlCommand()
        Dim str As String
        Dim i As Integer
        Me.StartPosition = FormStartPosition.CenterScreen
        sqlstr = "select NATIONALITY_ENG,NATIONALITY_CHA from Code_Nationality Order by NATIONALITY_CHA"
        dw = Getdata(sqlstr, ds2)
        txtNationality.DataSource = ds2.Tables(0).DefaultView
        txtNationality.DisplayMember = "NATIONALITY_CHA"
        txtNationality.ValueMember = "NATIONALITY_ENG"

        sqlstr = "select * from code_Port where Port_ID=" & ID & ""

        dw = Updatedata(sqlda, sqlstr, ds)
        If dw.Count > 0 Then

            txtID.Text = ds.Tables(0).Rows(0).Item("Port_ID")
            txtCode.Text = ds.Tables(0).Rows(0).Item("code_port")
            txtCHA.Text = ds.Tables(0).Rows(0).Item("Port_Cha")
            txtENG.Text = ds.Tables(0).Rows(0).Item("Port_Eng")
            txtNationality.SelectedValue = ds.Tables(0).Rows(0).Item("Code_Nationality")
            txtShort.Text = ds.Tables(0).Rows(0).Item("Port_Short")

            'txt1 = ds.Tables(0).Rows(0).Item("code_port")
            txt2 = ds.Tables(0).Rows(0).Item("Port_Cha")
            txt3 = ds.Tables(0).Rows(0).Item("Port_Eng")
            txt4 = ds.Tables(0).Rows(0).Item("Code_Nationality")
            txt5 = ds.Tables(0).Rows(0).Item("Port_Short")
        End If


        txtCHA.Focus()
        '****************相关船公司港口代码表
        Str = "select * from Code_Port_Relation where Code_Port='" & Trim(txtCode.Text) & "'"
        ds_sub.Reset()
        dw = Updatedata(sqlda_sub, Str, ds_sub)
        Me.C1DBG.DataSource = dw
        Me.C1DBG.Refresh()
        If ds_sub.Tables(0).Rows.Count = 0 Then
            Me.C1DBG.Select()
            Me.C1DBG.Row = Me.C1DBG.Row + 1
            Me.C1DBG.Columns.Item("Code_Port").Value = Trim(txtCode.Text)
        End If
        '************船公司代码
        Me.C1DBG.Columns.Item(2).ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
        Me.C1DBG.Columns.Item(2).ValueItems.Translate = True
        Me.C1DBG.Columns.Item(2).ValueItems.Validate = True

        sqlc.Connection = sqlconn

        sqlc.CommandText = "select * from CODE_SHIP_OWNER order by SHIPOWNER_SHORT"

        sqla.SelectCommand = sqlc
        ds1.Reset()
        sqla.Fill(ds1)
        For i = 0 To ds1.Tables(0).Rows.Count - 1
            Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
            vi.DisplayValue = Trim(ds1.Tables(0).Rows(i)("SHIPOWNER_SHORT"))
            vi.Value = Trim(ds1.Tables(0).Rows(i)("CODE_SHIPOWNER"))

            Me.C1DBG.Columns.Item(2).ValueItems.Values.Add(vi)
        Next
        '***************初始化
        Me.C1DBG.Splits(0).DisplayColumns.Item(0).Visible = False
        Me.C1DBG.Splits(0).DisplayColumns.Item(1).Visible = False
        Me.C1DBG.Columns.Item(2).Caption = "船公司"
        Me.C1DBG.Columns.Item(3).Caption = "港口代码"
        Me.C1DBG.Columns.Item(4).Caption = "港口描述"

        Me.C1DBG.Refresh()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResume.Click
        Try
            If MsgBox("你确认要修改吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                Call OperateHistory(G_DeptName, Now, G_User, "修改", "Code_port", Trim(txtID.Text), "Port_ID")

                'ds.Tables(0).Rows(0).Item("Code_Port") = Trim(txtCode.Text)
                ds.Tables(0).Rows(0).Item("port_cha") = Trim(txtCHA.Text)
                ds.Tables(0).Rows(0).Item("port_eng") = Trim(txtENG.Text)
                ds.Tables(0).Rows(0).Item("Code_Nationality") = Trim(txtNationality.SelectedValue)
                ds.Tables(0).Rows(0).Item("Port_Short") = Trim(txtShort.Text)

                sqlda.Update(ds)

                If Not (txt2 = Trim(txtCHA.Text) And txt3 = Trim(txtENG.Text) And txt4 = Trim(txtNationality.SelectedValue) And txt5 = Trim(txtShort.Text)) Then
                    Dim updatetxt As String
                    updatetxt = "update code_port set port_cha=''" & Trim(txtCHA.Text) & "'',port_eng=''" & Trim(txtENG.Text) & "'',code_nationality=''" & Trim(txtNationality.SelectedValue) & "'',port_short=''" & Trim(txtENG.Text) & "'' where code_port=''" & Trim(txtCode.Text) & "''"
                    CodeOperation("code_port", updatetxt)
                End If

                'Call btQuit_Click(sender, e)
                txtCode.Enabled = False
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
    Private Sub btnResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResume.Click
        Try
            sqlda_sub.Update(ds_sub)
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        Me.Close()
    End Sub

    Private Sub C1DBG_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles C1DBG.RowColChange
        Try
            If Me.C1DBG.Columns.Item("Code_Port").Text = "" Then
                Me.C1DBG.Columns.Item("Code_Port").Value = Trim(txtCode.Text)
                Me.C1DBG.Refresh()
            End If
        Catch ex As System.Exception
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Me.C1DBG.Delete()
    End Sub
End Class
