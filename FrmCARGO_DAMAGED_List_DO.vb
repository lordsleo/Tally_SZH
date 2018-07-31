Imports TALLY.DBControl
Public Class FrmCARGO_DAMAGED_List_DO
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dw As New DataView()
    Dim dssp As New DataSet()
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
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents BTOK As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCARGO_DAMAGED_List_DO))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.BTQUIT = New System.Windows.Forms.Button()
        Me.BTOK = New System.Windows.Forms.Button()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = True
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1DBG.AllowSort = True
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.CollapseColor = System.Drawing.Color.Black
        Me.C1DBG.DataChanged = False
        Me.C1DBG.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBG.ExpandColor = System.Drawing.Color.Black
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1DBG.Location = New System.Drawing.Point(8, 10)
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
        Me.C1DBG.Size = New System.Drawing.Size(448, 150)
        Me.C1DBG.TabIndex = 1
        Me.C1DBG.Text = "C1TrueDBGrid1"
        Me.C1DBG.PropBag = CType(resources.GetObject("C1DBG.PropBag"), String)
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(237, 176)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 41
        Me.BTQUIT.Text = "取消"
        '
        'BTOK
        '
        Me.BTOK.Location = New System.Drawing.Point(163, 176)
        Me.BTOK.Name = "BTOK"
        Me.BTOK.Size = New System.Drawing.Size(65, 24)
        Me.BTOK.TabIndex = 40
        Me.BTOK.Text = "确认"
        '
        'FrmCARGO_DAMAGED_List_DO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(464, 219)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.BTQUIT, Me.BTOK, Me.C1DBG})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCARGO_DAMAGED_List_DO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "残损单_处理"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCARGO_DAMAGED_List_DO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        dw = Getdata("exec sp_CARGO_DAMAGED_List  '" & Ship_ID & "'", dssp)
        If dssp.Tables(0).Rows.Count > 0 Then
            Me.C1DBG.DataSource = dssp.Tables(0).DefaultView
            Me.C1DBG.Splits(0).DisplayColumns.Item("code_goods").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("code_pack").Visible = False
            Me.C1DBG.Columns.Item("blno").Caption = "提单号"
            Me.C1DBG.Columns.Item("mark").Caption = "标志"
            Me.C1DBG.Columns.Item("code_goods_cha").Caption = "货类"
            Me.C1DBG.Columns.Item("goods_cha").Caption = "货物中文描述"
            Me.C1DBG.Columns.Item("DAMAGED_AMOUNT").Caption = "残损件数"
            Me.C1DBG.Columns.Item("pack_cha").Caption = "包装"
            Me.C1DBG.Columns.Item("DAMAGED_CONDITION").Caption = "残损情况"
            Call SetColumnWidth() '设计列宽度
            Me.C1DBG.Refresh()
        Else
            MsgBox("没有残损！")
            Me.BTOK.Enabled = False
        End If
        Exit Sub
Err:
        Resume Next
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
    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub

    Private Sub BTOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOK.Click
        Try
            Dim i As Integer
            Dim row As DataRow
            If MsgBox("确认要生成残损单吗？这将删除以前本航次的残损单！", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                dw = Updatedata(sqlda, "select * from CARGO_DAMAGED_List where ship_id='" & Ship_ID & "'", ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    For i = 0 To ds.Tables(0).Rows.Count - 1
                        Call OperateHistory(G_DeptName, Now, G_User, "删除", "CARGO_DAMAGED_List", ds.Tables(0).Rows(i).Item("CARGO_DAMAGED_ID"), "CARGO_DAMAGED_ID")
                        ExecSql("delete from CARGO_DAMAGED_List where CARGO_DAMAGED_ID='" & ds.Tables(0).Rows(i).Item("CARGO_DAMAGED_ID") & "'")
                        sqlda.Update(ds)
                    Next
                End If
                For i = 0 To dssp.Tables(0).Rows.Count - 1
                    row = ds.Tables(0).NewRow
                    row("ship_id") = Trim(Ship_ID)
                    row("BLNO") = dssp.Tables(0).Rows(i).Item("BLNO")
                    row("MARK") = dssp.Tables(0).Rows(i).Item("MARK")
                    row("CODE_GOODS") = dssp.Tables(0).Rows(i).Item("CODE_GOODS")
                    row("code_PACK") = dssp.Tables(0).Rows(i).Item("code_PACK")
                    row("DAMAGED_AMOUNT") = dssp.Tables(0).Rows(i).Item("DAMAGED_AMOUNT")
                    row("GOODS_cha") = dssp.Tables(0).Rows(i).Item("GOODS_cha")
                    row("DAMAGED_CONDITION") = dssp.Tables(0).Rows(i).Item("DAMAGED_CONDITION")
                    row("USER_NAME") = Trim(G_User)
                    ds.Tables(0).Rows.Add(row)
                    sqlda.Update(ds)
                Next
                Call BTQUIT_Click(sender, e)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class
