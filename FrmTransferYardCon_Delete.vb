Imports TALLY.DBControl
Public Class FrmTransferYardCon_Delete
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dsSubTable As New DataSet()
    Dim sqlSubTableda As New SqlClient.SqlDataAdapter()

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
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents dtpPassTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents cbYardName As System.Windows.Forms.ComboBox
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents txtTally40Num As System.Windows.Forms.TextBox
    Friend WithEvents txtTally45Num As System.Windows.Forms.TextBox
    Friend WithEvents txtTally58Num As System.Windows.Forms.TextBox
    Friend WithEvents txtPass40Num As System.Windows.Forms.TextBox
    Friend WithEvents txtPass45Num As System.Windows.Forms.TextBox
    Friend WithEvents txtPass58Num As System.Windows.Forms.TextBox
    Friend WithEvents txtTally20Num As System.Windows.Forms.TextBox
    Friend WithEvents txtPass20Num As System.Windows.Forms.TextBox
    Friend WithEvents txtPassNo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnMainDel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmTransferYardCon_Delete))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dtpPassTime = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cbYardName = New System.Windows.Forms.ComboBox()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.txtTally40Num = New System.Windows.Forms.TextBox()
        Me.txtTally45Num = New System.Windows.Forms.TextBox()
        Me.txtTally58Num = New System.Windows.Forms.TextBox()
        Me.txtPass40Num = New System.Windows.Forms.TextBox()
        Me.txtPass45Num = New System.Windows.Forms.TextBox()
        Me.txtPass58Num = New System.Windows.Forms.TextBox()
        Me.txtTally20Num = New System.Windows.Forms.TextBox()
        Me.txtPass20Num = New System.Windows.Forms.TextBox()
        Me.txtPassNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMainDel = New System.Windows.Forms.Button()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(190, 394)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(65, 24)
        Me.btnDelete.TabIndex = 351
        Me.btnDelete.Text = "箱删除"
        '
        'dtpPassTime
        '
        Me.dtpPassTime.Location = New System.Drawing.Point(80, 34)
        Me.dtpPassTime.Name = "dtpPassTime"
        Me.dtpPassTime.Size = New System.Drawing.Size(130, 21)
        Me.dtpPassTime.TabIndex = 350
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 325
        Me.Label1.Text = "放行单号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 349
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'cbYardName
        '
        Me.cbYardName.Location = New System.Drawing.Point(80, 60)
        Me.cbYardName.Name = "cbYardName"
        Me.cbYardName.Size = New System.Drawing.Size(130, 20)
        Me.cbYardName.TabIndex = 348
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(326, 394)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 347
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(258, 394)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 346
        Me.btSave.Text = "确认"
        '
        'C1DBG
        '
        Me.C1DBG.AllowAddNew = True
        Me.C1DBG.AllowDelete = True
        Me.C1DBG.AllowFilter = True
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1DBG.AllowSort = True
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.CollapseColor = System.Drawing.Color.Black
        Me.C1DBG.DataChanged = False
        Me.C1DBG.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBG.ExpandColor = System.Drawing.Color.Black
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1DBG.Location = New System.Drawing.Point(0, 104)
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
        Me.C1DBG.Size = New System.Drawing.Size(580, 284)
        Me.C1DBG.TabIndex = 345
        Me.C1DBG.PropBag = CType(resources.GetObject("C1DBG.PropBag"), String)
        '
        'txtTally40Num
        '
        Me.txtTally40Num.Enabled = False
        Me.txtTally40Num.Location = New System.Drawing.Point(466, 30)
        Me.txtTally40Num.Name = "txtTally40Num"
        Me.txtTally40Num.TabIndex = 344
        Me.txtTally40Num.Text = ""
        '
        'txtTally45Num
        '
        Me.txtTally45Num.Enabled = False
        Me.txtTally45Num.Location = New System.Drawing.Point(466, 52)
        Me.txtTally45Num.Name = "txtTally45Num"
        Me.txtTally45Num.TabIndex = 343
        Me.txtTally45Num.Text = ""
        '
        'txtTally58Num
        '
        Me.txtTally58Num.Enabled = False
        Me.txtTally58Num.Location = New System.Drawing.Point(466, 74)
        Me.txtTally58Num.Name = "txtTally58Num"
        Me.txtTally58Num.TabIndex = 342
        Me.txtTally58Num.Text = ""
        '
        'txtPass40Num
        '
        Me.txtPass40Num.Location = New System.Drawing.Point(288, 30)
        Me.txtPass40Num.Name = "txtPass40Num"
        Me.txtPass40Num.TabIndex = 341
        Me.txtPass40Num.Text = ""
        '
        'txtPass45Num
        '
        Me.txtPass45Num.Location = New System.Drawing.Point(288, 52)
        Me.txtPass45Num.Name = "txtPass45Num"
        Me.txtPass45Num.TabIndex = 340
        Me.txtPass45Num.Text = ""
        '
        'txtPass58Num
        '
        Me.txtPass58Num.Location = New System.Drawing.Point(288, 74)
        Me.txtPass58Num.Name = "txtPass58Num"
        Me.txtPass58Num.TabIndex = 339
        Me.txtPass58Num.Text = ""
        '
        'txtTally20Num
        '
        Me.txtTally20Num.Enabled = False
        Me.txtTally20Num.Location = New System.Drawing.Point(466, 8)
        Me.txtTally20Num.Name = "txtTally20Num"
        Me.txtTally20Num.TabIndex = 338
        Me.txtTally20Num.Text = ""
        '
        'txtPass20Num
        '
        Me.txtPass20Num.Location = New System.Drawing.Point(288, 8)
        Me.txtPass20Num.Name = "txtPass20Num"
        Me.txtPass20Num.TabIndex = 337
        Me.txtPass20Num.Text = ""
        '
        'txtPassNo
        '
        Me.txtPassNo.Location = New System.Drawing.Point(80, 8)
        Me.txtPassNo.MaxLength = 10
        Me.txtPassNo.Name = "txtPassNo"
        Me.txtPassNo.Size = New System.Drawing.Size(130, 21)
        Me.txtPassNo.TabIndex = 336
        Me.txtPassNo.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(396, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 20)
        Me.Label8.TabIndex = 335
        Me.Label8.Text = "到达20'数"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(396, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 20)
        Me.Label9.TabIndex = 334
        Me.Label9.Text = "到达40'数"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(396, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 20)
        Me.Label10.TabIndex = 333
        Me.Label10.Text = "到达45'数"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(396, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 20)
        Me.Label11.TabIndex = 332
        Me.Label11.Text = "到达58'数"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(218, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 20)
        Me.Label7.TabIndex = 331
        Me.Label7.Text = "放行58'数"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(218, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 20)
        Me.Label6.TabIndex = 330
        Me.Label6.Text = "放行45'数"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(218, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 329
        Me.Label5.Text = "放行40'数"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(218, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 328
        Me.Label4.Text = "放行20'数"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 327
        Me.Label3.Text = "场站名"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 326
        Me.Label2.Text = "放行时间"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnMainDel
        '
        Me.btnMainDel.Location = New System.Drawing.Point(68, 394)
        Me.btnMainDel.Name = "btnMainDel"
        Me.btnMainDel.Size = New System.Drawing.Size(65, 24)
        Me.btnMainDel.TabIndex = 365
        Me.btnMainDel.Text = "全部删除"
        '
        'FrmTransferYardCon_Delete
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(580, 423)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnMainDel, Me.btnDelete, Me.dtpPassTime, Me.Label1, Me.txtID, Me.cbYardName, Me.btQuit, Me.btSave, Me.C1DBG, Me.txtTally40Num, Me.txtTally45Num, Me.txtTally58Num, Me.txtPass40Num, Me.txtPass45Num, Me.txtPass58Num, Me.txtTally20Num, Me.txtPass20Num, Me.txtPassNo, Me.Label8, Me.Label9, Me.Label10, Me.Label11, Me.Label7, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label2})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTransferYardCon_Delete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集装箱转场信息 删除"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmTransferYardCon_Delete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.txtPassNo.Enabled = False

        sqlstr = "select * from TransferYard_Con where TransferYard_Con_ID =" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        Dim sqlCodeYard As String
        sqlCodeYard = "SELECT Code_Yard_ID, Code_Yard_Name FROM Code_Yard ORDER BY Code_Yard_ID"
        cbYardName.DataSource = Filldata(sqlCodeYard)
        cbYardName.DisplayMember = "Code_Yard_Name"
        cbYardName.ValueMember = "Code_Yard_ID"

        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("TransferYard_Con_ID")
            txtPassNo.Text = ds.Tables(0).Rows(0).Item("PassNo")
            dtpPassTime.Value = ds.Tables(0).Rows(0).Item("PassTime")
            cbYardName.SelectedValue = ds.Tables(0).Rows(0).Item("YardName")
            txtPass20Num.Text = ds.Tables(0).Rows(0).Item("Pass20Num")
            txtPass40Num.Text = ds.Tables(0).Rows(0).Item("Pass40Num")
            txtPass45Num.Text = ds.Tables(0).Rows(0).Item("Pass45Num")
            txtPass58Num.Text = ds.Tables(0).Rows(0).Item("Pass58Num")
            txtTally20Num.Text = ds.Tables(0).Rows(0).Item("Tally20Num")
            txtTally40Num.Text = ds.Tables(0).Rows(0).Item("Tally40Num")
            txtTally45Num.Text = ds.Tables(0).Rows(0).Item("Tally45Num")
            txtTally58Num.Text = ds.Tables(0).Rows(0).Item("Tally58Num")
        End If
        txtPassNo.Focus()
        InitSubTable(ID)     '初始化子表c1grid
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub InitSubTable(ByVal sqlID As String)
        Try
            Dim sqlSubTable As String
            sqlSubTable = "SELECT * FROM TransferYard_Con_List WHERE TransferYard_Con_ID = " & sqlID & ""
            Me.C1DBG.DataSource = Updatedata(sqlSubTableda, sqlSubTable, dsSubTable)

            Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue

            Me.C1DBG.Splits(0).DisplayColumns.Item(0).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item(1).Visible = False

            Me.C1DBG.Columns.Item("TallyNo").Caption = "理货单号"
            Me.C1DBG.Columns.Item("Vessel_Cha").Caption = "中文船名"
            Me.C1DBG.Columns.Item("Voyage").Caption = "航次"
            Me.C1DBG.Columns.Item("BillNo").Caption = "提单号"
            Me.C1DBG.Columns.Item("ContainerNo").Caption = "集装箱号"
            Me.C1DBG.Columns.Item("ContainerSize").Caption = "箱尺寸"
            Me.C1DBG.Columns.Item("SealNo").Caption = "铅封号"
            Me.C1DBG.Columns.Item("SealState").Caption = "铅封情况"
            Me.C1DBG.Columns.Item("ArriveMark").Caption = "到场标记"
            Me.C1DBG.Columns.Item("ArriveTime").Caption = "到场时间"

            Call FieldFill()
            SetColumnWidth()
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FieldFill()
        Dim i As Integer
        Try
            'Dim sqlPack As String = "SELECT CODE_PACK, PACK_CHA, PACK_ENG FROM CODE_PACK ORDER BY CODE_PACK"
            'Dim dvPack As New DataView()
            'dvPack = Filldata(sqlPack)
            'Me.C1DBG.Columns("PACK_CHA").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            'Me.C1DBG.Columns("PACK_CHA").ValueItems.Translate = True
            'For i = 0 To dvPack.Count - 1
            '    Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
            '    vi.DisplayValue = dvPack(i)("PACK_CHA")
            '    vi.Value = dvPack(i)("CODE_PACK")
            '    Me.C1DBG.Columns.Item("PACK_CHA").ValueItems.Values.Add(vi)
            'Next

            Dim sqlSealState As String = "SELECT Code_SealCircs, SealCircs_CHI, SealCircs_Eng FROM Code_SealCircs ORDER BY Code_SealCircs"
            Dim dvSealState As New DataView()
            dvSealState = Filldata(sqlSealState)
            Me.C1DBG.Columns("SealState").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("SealState").ValueItems.Translate = True
            For i = 0 To dvSealState.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                vi.DisplayValue = dvSealState(i)("SealCircs_CHI")
                vi.Value = dvSealState(i)("Code_SealCircs")
                Me.C1DBG.Columns.Item("SealState").ValueItems.Values.Add(vi)
            Next

            Me.C1DBG.Columns("ArriveMark").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
            Me.C1DBG.Columns("ArriveMark").ValueItems.Translate = True
            'Dim v1 As New C1.Win.C1TrueDBGrid.ValueItem()
            'v1.DisplayValue = "是"
            'v1.Value = 1
            'Me.C1DBG.Columns.Item("ArriveMark").ValueItems.Values.Add(v1)
            'Dim v2 As New C1.Win.C1TrueDBGrid.ValueItem()
            'v2.DisplayValue = "否"
            'v2.Value = 0
            'Me.C1DBG.Columns.Item("ArriveMark").ValueItems.Values.Add(v2)

            Me.C1DBG.ColumnFooters = True
            Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
            Me.C1DBG.Columns("TallyNo").FooterText = "合计" & dsSubTable.Tables(0).Rows.Count & "条"
        Catch ex As System.Exception
            MsgBox(ex.Message)
        Finally
            sqlconn.Close()
        End Try
    End Sub

    Private Sub SetColumnWidth()
        Dim i As Integer
        Try
            'i = 2
            'Do While i < Me.C1DBG.Columns.Count
            '    Me.C1DBG.Splits(0).DisplayColumns.Item(i).Width = ((Me.C1DBG.Width - 25) / 10)
            '    i = i + 1
            'Loop
            Me.C1DBG.Splits(0).DisplayColumns("TallyNo").Width = 60
            Me.C1DBG.Splits(0).DisplayColumns("Vessel_Cha").Width = 80
            Me.C1DBG.Splits(0).DisplayColumns("BillNo").Width = 80
            Me.C1DBG.Splits(0).DisplayColumns("ContainerNo").Width = 80
            Me.C1DBG.Splits(0).DisplayColumns("SealNo").Width = 80

            Me.C1DBG.Splits(0).DisplayColumns("Voyage").Width = 60
            Me.C1DBG.Splits(0).DisplayColumns("ContainerSize").Width = 30
            Me.C1DBG.Splits(0).DisplayColumns("SealState").Width = 50
            Me.C1DBG.Splits(0).DisplayColumns("ArriveMark").Width = 30
            Me.C1DBG.Splits(0).DisplayColumns("ArriveTime").Width = 60
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            If MessageBox.Show("确定以上对子表的删除操作吗？", "警告提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                sqlSubTableda.Update(dsSubTable)    '更新子表
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Me.C1DBG.Delete()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnMainDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainDel.Click
        Try
            If MessageBox.Show("此操作将删除当前所有的数据，确定要删除吗？", "警告提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                '记录操作日志
                Call OperateHistory(G_DeptName, Now, G_User, "删除", "TransferYard_Con", Trim(txtID.Text), "TransferYard_Con_ID")
                ds.Tables(0).Rows(0).Delete()
                sqlda.Update(ds)
                '触发器删除子表
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
