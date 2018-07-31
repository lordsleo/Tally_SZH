Imports TALLY.DBControl
Public Class FrmPreview
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
    Friend WithEvents DG_DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents CMD_Cance As System.Windows.Forms.Button
    Friend WithEvents CMD_Save As System.Windows.Forms.Button
    Friend WithEvents CMD_LL As System.Windows.Forms.Button
    Friend WithEvents btAll As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPreview))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.DG_DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.CMD_Cance = New System.Windows.Forms.Button()
        Me.CMD_Save = New System.Windows.Forms.Button()
        Me.CMD_LL = New System.Windows.Forms.Button()
        Me.btAll = New System.Windows.Forms.Button()
        CType(Me.DG_DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG_DBG
        '
        Me.DG_DBG.AllowFilter = True
        Me.DG_DBG.AllowRowSelect = False
        Me.DG_DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.DG_DBG.AllowSort = True
        Me.DG_DBG.CaptionHeight = 18
        Me.DG_DBG.CollapseColor = System.Drawing.Color.Black
        Me.DG_DBG.DataChanged = False
        Me.DG_DBG.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.DG_DBG.ExpandColor = System.Drawing.Color.Black
        Me.DG_DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.DG_DBG.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.DG_DBG.Location = New System.Drawing.Point(5, 4)
        Me.DG_DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.DG_DBG.Name = "DG_DBG"
        Me.DG_DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DG_DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DG_DBG.PreviewInfo.ZoomFactor = 75
        Me.DG_DBG.PrintInfo.ShowOptionsDialog = False
        Me.DG_DBG.RecordSelectorWidth = 16
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.DG_DBG.RowDivider = GridLines1
        Me.DG_DBG.RowHeight = 16
        Me.DG_DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.DG_DBG.ScrollTips = False
        Me.DG_DBG.Size = New System.Drawing.Size(544, 488)
        Me.DG_DBG.TabIndex = 0
        Me.DG_DBG.Text = "C1TrueDBGrid1"
        Me.DG_DBG.PropBag = CType(resources.GetObject("DG_DBG.PropBag"), String)
        '
        'CMD_Cance
        '
        Me.CMD_Cance.BackColor = System.Drawing.Color.Transparent
        Me.CMD_Cance.Location = New System.Drawing.Point(349, 500)
        Me.CMD_Cance.Name = "CMD_Cance"
        Me.CMD_Cance.Size = New System.Drawing.Size(65, 24)
        Me.CMD_Cance.TabIndex = 22
        Me.CMD_Cance.Text = "取消"
        '
        'CMD_Save
        '
        Me.CMD_Save.BackColor = System.Drawing.Color.Transparent
        Me.CMD_Save.Location = New System.Drawing.Point(279, 500)
        Me.CMD_Save.Name = "CMD_Save"
        Me.CMD_Save.Size = New System.Drawing.Size(65, 24)
        Me.CMD_Save.TabIndex = 21
        Me.CMD_Save.Text = "确认"
        '
        'CMD_LL
        '
        Me.CMD_LL.Location = New System.Drawing.Point(209, 500)
        Me.CMD_LL.Name = "CMD_LL"
        Me.CMD_LL.Size = New System.Drawing.Size(65, 24)
        Me.CMD_LL.TabIndex = 23
        Me.CMD_LL.Text = "全部浏览"
        '
        'btAll
        '
        Me.btAll.BackColor = System.Drawing.Color.Transparent
        Me.btAll.Location = New System.Drawing.Point(139, 500)
        Me.btAll.Name = "btAll"
        Me.btAll.Size = New System.Drawing.Size(65, 24)
        Me.btAll.TabIndex = 24
        Me.btAll.Text = "全部权限"
        '
        'FrmPreview
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(552, 527)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btAll, Me.CMD_LL, Me.CMD_Cance, Me.CMD_Save, Me.DG_DBG})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPreview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "系统设置——角色权限管理"
        CType(Me.DG_DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim sqlstr As String
    Dim dv As DataView
    Dim ds As New DataSet()
    Dim sql As String
    Dim dset As New DataSet()
    Dim sqlt As String
    Dim dst As New DataSet()
    Dim dvbz As DataView
    Dim dsbz As New DataSet()
    Private Sub FrmPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sqld As String

        sqlstr = "SELECT E_I_ID,FUNC_CODE as 模块名称, FUNC_CODE_View as 模块可见, FUNC_CODE_Add as 能否添加, FUNC_CODE_Change as 能否修改, FUNC_CODE_Del as 能否删除  FROM PREVIEW  where Part_id =" & G_Part_Id & " order by FUNC_CODE"
        dvbz = DBControl.Getdata(sqlstr, dsbz)

        sqlstr = "SELECT E_I_ID,FUNC_CODE as 模块名称, FUNC_CODE_View as 模块可见, FUNC_CODE_Add as 能否添加, FUNC_CODE_Change as 能否修改, FUNC_CODE_Del as 能否删除  FROM PREVIEW  where Part_id =" & ID & " order by FUNC_CODE"

        Fill(sqlstr)
        
            CMD_LL.Enabled = True
            CMD_Save.Enabled = True

    End Sub

    Private Sub Fill(ByVal sqlstr As String)

        dv = Getdata(sqlstr, ds)
        Me.DG_DBG.DataSource = dv
        Me.DG_DBG.Splits(0).DisplayColumns.Item(0).Visible = False

        Me.DG_DBG.Columns.Item(1).ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.Normal
        Me.DG_DBG.Columns.Item(1).ValueItems.Translate = True
        sql = "SELECT FUNC_CODE, FUNC_NAME FROM SYS_FUNC"
        Getdata(sql, dset)
        Dim i As Integer
        For i = 0 To dset.Tables(0).Rows.Count - 1
            Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
            vi.DisplayValue = Trim(dset.Tables(0).Rows(i)("FUNC_NAME"))
            vi.Value = Trim(dset.Tables(0).Rows(i)("FUNC_CODE"))
            Me.DG_DBG.Columns.Item(1).ValueItems.Values.Add(vi)
        Next
        sqlt = "SELECT Value, Descri FROM True"
        Getdata(sqlt, dst)
        Me.DG_DBG.Columns.Item(2).ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
        Me.DG_DBG.Columns.Item(2).ValueItems.Translate = True
        For i = 0 To dst.Tables(0).Rows.Count - 1
            Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
            vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("Descri"))
            vi.Value = Trim(dst.Tables(0).Rows(i)("Value"))
            Me.DG_DBG.Columns.Item(2).ValueItems.Values.Add(vi)
        Next
        Me.DG_DBG.Columns.Item(3).ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
        Me.DG_DBG.Columns.Item(3).ValueItems.Translate = True
        For i = 0 To dst.Tables(0).Rows.Count - 1
            Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
            vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("Descri"))
            vi.Value = Trim(dst.Tables(0).Rows(i)("Value"))
            Me.DG_DBG.Columns.Item(3).ValueItems.Values.Add(vi)
        Next
        Me.DG_DBG.Columns.Item(4).ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
        Me.DG_DBG.Columns.Item(4).ValueItems.Translate = True
        For i = 0 To dst.Tables(0).Rows.Count - 1
            Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
            vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("Descri"))
            vi.Value = Trim(dst.Tables(0).Rows(i)("Value"))
            Me.DG_DBG.Columns.Item(4).ValueItems.Values.Add(vi)
        Next
        Me.DG_DBG.Columns.Item(5).ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
        Me.DG_DBG.Columns.Item(5).ValueItems.Translate = True
        For i = 0 To dst.Tables(0).Rows.Count - 1
            Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
            vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("Descri"))
            vi.Value = Trim(dst.Tables(0).Rows(i)("Value"))
            Me.DG_DBG.Columns.Item(5).ValueItems.Values.Add(vi)
        Next

    End Sub

    Private Sub CMD_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_Save.Click
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        k = 0
        Try
            If ID <> 1 Then
                For j = 0 To dvbz.Count - 1
                    For i = 2 To Me.DG_DBG.Columns.Count - 1
                        If dvbz(j)(i) = 0 Then
                            dv(j)(i) = 0
                            k = k + 1
                        End If
                    Next
                Next
            End If

            RunUpdata(sqlstr, ds)
            Fill(sqlstr)
            If k > 0 Then
                MsgBox("因为您某项权限没有，所以无发对该项目受权！", MsgBoxStyle.OKOnly)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly)
        End Try

    End Sub



    Private Sub CMD_LL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_LL.Click
        Try
            Dim sqlstr As String
            sqlstr = "update PREVIEW set FUNC_CODE_View = 1 , FUNC_CODE_Add = 0 , FUNC_CODE_Change=0 , FUNC_CODE_Del=0 where  Part_id =" & ID & ""
            ExecSql(sqlstr)
            sqlstr = "SELECT E_I_ID,FUNC_CODE as 模块名称, FUNC_CODE_View as 模块可见, FUNC_CODE_Add as 能否添加, FUNC_CODE_Change as 能否修改, FUNC_CODE_Del as 能否删除  FROM PREVIEW  where Part_id =" & ID & " order by FUNC_CODE"
            Fill(sqlstr)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly)
        End Try
    End Sub

    Private Sub CMD_Cance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_Cance.Click
        Me.Close()
    End Sub

    Private Sub btAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAll.Click
        Try
            Dim sqlstr As String
            sqlstr = "update PREVIEW set FUNC_CODE_View = 1 , FUNC_CODE_Add = 1 , FUNC_CODE_Change=1 , FUNC_CODE_Del=1 where  Part_id =" & ID & ""
            ExecSql(sqlstr)
            sqlstr = "SELECT E_I_ID,FUNC_CODE as 模块名称, FUNC_CODE_View as 模块可见, FUNC_CODE_Add as 能否添加, FUNC_CODE_Change as 能否修改, FUNC_CODE_Del as 能否删除  FROM PREVIEW  where Part_id =" & ID & " order by FUNC_CODE"
            Fill(sqlstr)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly)
        End Try
    End Sub
End Class
