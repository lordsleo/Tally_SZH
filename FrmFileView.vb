Imports TALLY.DBControl
Public Class FrmFileView
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
    Friend WithEvents Cmd_Down As System.Windows.Forms.Button
    Friend WithEvents DBG_File As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Cmd_Up As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmFileView))
        Me.DBG_File = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Cmd_Down = New System.Windows.Forms.Button
        Me.Cmd_Up = New System.Windows.Forms.Button
        CType(Me.DBG_File, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DBG_File
        '
        Me.DBG_File.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBG_File.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBG_File.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.DBG_File.Location = New System.Drawing.Point(0, 0)
        Me.DBG_File.Name = "DBG_File"
        Me.DBG_File.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBG_File.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBG_File.PreviewInfo.ZoomFactor = 75
        Me.DBG_File.Size = New System.Drawing.Size(482, 198)
        Me.DBG_File.TabIndex = 0
        Me.DBG_File.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Alig" & _
        "nVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><Height>194</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorSty" & _
        "le parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><F" & _
        "ilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=" & _
        """Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Headi" & _
        "ng"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><Inacti" & _
        "veStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9""" & _
        " /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle pa" & _
        "rent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0" & _
        ", 0, 478, 194</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderS" & _
        "tyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""" & _
        "Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Foot" & _
        "er"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactiv" & _
        "e"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /" & _
        "><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" " & _
        "/><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelecto" & _
        "r"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" " & _
        "/></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None" & _
        "</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 478, 194</" & _
        "ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle " & _
        "parent="""" me=""Style15"" /></Blob>"
        '
        'Cmd_Down
        '
        Me.Cmd_Down.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Down.Location = New System.Drawing.Point(159, 208)
        Me.Cmd_Down.Name = "Cmd_Down"
        Me.Cmd_Down.Size = New System.Drawing.Size(75, 30)
        Me.Cmd_Down.TabIndex = 1
        Me.Cmd_Down.Text = "下   载"
        '
        'Cmd_Up
        '
        Me.Cmd_Up.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Up.Location = New System.Drawing.Point(251, 208)
        Me.Cmd_Up.Name = "Cmd_Up"
        Me.Cmd_Up.Size = New System.Drawing.Size(75, 30)
        Me.Cmd_Up.TabIndex = 2
        Me.Cmd_Up.Text = "上   传"
        '
        'FrmFileView
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(484, 244)
        Me.Controls.Add(Me.Cmd_Up)
        Me.Controls.Add(Me.Cmd_Down)
        Me.Controls.Add(Me.DBG_File)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFileView"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "文件查看"
        CType(Me.DBG_File, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim dv As DataView
    Private Sub FrmFileView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connstr = conn_tally

        FillFile()
        'If filev = 1 Then
        '    Me.Cmd_Up.Enabled = False
        'Else 
        '    Me.Cmd_Down.Enabled = True
        '    Me.Cmd_Up.Enabled = True 
        'End If
    End Sub

    Private Sub FillFile()
        Dim sqlstr As String
        Try
            sqlstr = "SELECT id,file_name,upload_date,MODIFI_DATE,upload_file,user_name FROM ShipGraph_upload where SHIP_ID=" & ID & " order by upload_date desc"
            dv = DBControl.Filldata(sqlstr)
            Me.DBG_File.DataSource = dv
            Me.DBG_File.Splits(0).DisplayColumns.Item(0).Visible = False
            Me.DBG_File.Columns.Item(1).Caption = "文件名"
            Me.DBG_File.Columns.Item(2).Caption = "文件上传时间"
            Me.DBG_File.Columns.Item(3).Caption = "最后操作时间"
            'Me.DBG_File.Columns.Item(3).Caption = "船图文件"
            Me.DBG_File.Columns.Item(4).Caption = "最后操作人员"

            Me.DBG_File.Columns.Item(2).NumberFormat = "yy/MM/dd HH:mm"
            Me.DBG_File.Columns.Item(3).NumberFormat = "yy/MM/dd HH:mm"

            If dv.Table.Rows.Count > 0 Then
                Me.Cmd_Down.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("数据库读取错误！", MsgBoxStyle.OKOnly, "提示")
        End Try
    End Sub

    Private Sub Cmd_Down_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Down.Click
        Dim myStream As System.IO.Stream
        Dim wjbc As New SaveFileDialog
        Try
            wjbc.Title = Me.Text + "——文件保存"
            wjbc.Filter = "Excel文件(*.xls)|*.xls|All files (*.*)|*.*"
            'wjbc.FilterIndex = 2
            wjbc.FileName = dv(Me.DBG_File.Row)("file_name")
            Dim MyData() As Byte
            MyData = dv(Me.DBG_File.Row)("upload_file")
            Dim K As Long
            K = UBound(MyData)
            If wjbc.ShowDialog() = DialogResult.OK Then
                Dim fs As New IO.FileStream(wjbc.FileName, IO.FileMode.OpenOrCreate, IO.FileAccess.Write)
                fs.Write(MyData, 0, K)
                fs.Close()
                fs = Nothing
            End If
            MsgBox("文件下载结束！", MsgBoxStyle.OKOnly, "提示")
        Catch ex As Exception
            MsgBox("文件保存错误，请检查！", MsgBoxStyle.OKOnly, "提示")
        End Try
    End Sub

    Private Sub Cmd_Up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Up.Click
        Dim frm As New FrmUpload
        frm.ShowDialog()
        FillFile()
    End Sub

    Private Sub FrmFileView_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        connstr = conn
        'filev = 0
        'Try
        '    Dim wjbc As String
        '    wjbc = "c:\" + dv(Me.DBG_File.Row)("文件名")
        '    IO.File.Delete("wjbx")
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub DBG_File_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBG_File.DoubleClick
        'Dim myStream As System.IO.Stream
        'Dim wjbc As String
        'Try
        '    wjbc = "d:\" + dv(Me.DBG_File.Row)("file_name")
        '    Dim MyData() As Byte
        '    MyData = dv(Me.DBG_File.Row)("upload_file")
        '    Dim K As Long
        '    K = UBound(MyData)
        '    Dim fs As New IO.FileStream(wjbc, IO.FileMode.OpenOrCreate, IO.FileAccess.Write)
        '    fs.Write(MyData, 0, K)
        '    fs.Close()
        '    fs = Nothing
        '    Try
        '        System.Diagnostics.Process.Start(wjbc)
        '    Catch ex As Exception
        '        MsgBox(ex.Message, MsgBoxStyle.OKOnly, "提示")
        '    End Try

        'Catch ex As Exception
        '    MsgBox("文件保存错误，请检查！", MsgBoxStyle.OKOnly, "提示")
        'End Try
    End Sub
End Class
