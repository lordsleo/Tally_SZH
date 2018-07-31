Imports TALLY.DBControl
Public Class FrmTransferYardCargo_Edit
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
        AddHandler txtPassNo.KeyDown, AddressOf FrmTransferYardCargo_Edit_KeyDown
        AddHandler dtpPassTime.KeyDown, AddressOf FrmTransferYardCargo_Edit_KeyDown
        AddHandler cbYardName.KeyDown, AddressOf FrmTransferYardCargo_Edit_KeyDown
        AddHandler txtVessel.KeyDown, AddressOf FrmTransferYardCargo_Edit_KeyDown
        AddHandler txtVoyage.KeyDown, AddressOf FrmTransferYardCargo_Edit_KeyDown
        AddHandler cbGoodsName.KeyDown, AddressOf FrmTransferYardCargo_Edit_KeyDown
        AddHandler txtPassAmount.KeyDown, AddressOf FrmTransferYardCargo_Edit_KeyDown
        AddHandler txtTallyAmount.KeyDown, AddressOf FrmTransferYardCargo_Edit_KeyDown
        AddHandler txtPassTons.KeyDown, AddressOf FrmTransferYardCargo_Edit_KeyDown
        AddHandler txtTallyTons.KeyDown, AddressOf FrmTransferYardCargo_Edit_KeyDown
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
    Friend WithEvents cbGoodsName As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpPassTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents cbYardName As System.Windows.Forms.ComboBox
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents txtTallyTons As System.Windows.Forms.TextBox
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents txtPassAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtPassTons As System.Windows.Forms.TextBox
    Friend WithEvents txtTallyAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtVessel As System.Windows.Forms.TextBox
    Friend WithEvents txtPassNo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmTransferYardCargo_Edit))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.cbGoodsName = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpPassTime = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cbYardName = New System.Windows.Forms.ComboBox()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.txtTallyTons = New System.Windows.Forms.TextBox()
        Me.txtVoyage = New System.Windows.Forms.TextBox()
        Me.txtPassAmount = New System.Windows.Forms.TextBox()
        Me.txtPassTons = New System.Windows.Forms.TextBox()
        Me.txtTallyAmount = New System.Windows.Forms.TextBox()
        Me.txtVessel = New System.Windows.Forms.TextBox()
        Me.txtPassNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbGoodsName
        '
        Me.cbGoodsName.Location = New System.Drawing.Point(262, 60)
        Me.cbGoodsName.MaxDropDownItems = 20
        Me.cbGoodsName.Name = "cbGoodsName"
        Me.cbGoodsName.Size = New System.Drawing.Size(110, 20)
        Me.cbGoodsName.TabIndex = 347
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(192, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 20)
        Me.Label10.TabIndex = 346
        Me.Label10.Text = "货名"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpPassTime
        '
        Me.dtpPassTime.Location = New System.Drawing.Point(76, 34)
        Me.dtpPassTime.Name = "dtpPassTime"
        Me.dtpPassTime.Size = New System.Drawing.Size(110, 21)
        Me.dtpPassTime.TabIndex = 345
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 322
        Me.Label1.Text = "放行单号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 344
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'cbYardName
        '
        Me.cbYardName.Location = New System.Drawing.Point(76, 60)
        Me.cbYardName.Name = "cbYardName"
        Me.cbYardName.Size = New System.Drawing.Size(110, 20)
        Me.cbYardName.TabIndex = 343
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(312, 392)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 341
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(244, 392)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 340
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
        Me.C1DBG.Location = New System.Drawing.Point(0, 100)
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
        Me.C1DBG.Size = New System.Drawing.Size(558, 284)
        Me.C1DBG.TabIndex = 338
        Me.C1DBG.PropBag = CType(resources.GetObject("C1DBG.PropBag"), String)
        '
        'txtTallyTons
        '
        Me.txtTallyTons.Enabled = False
        Me.txtTallyTons.Location = New System.Drawing.Point(448, 74)
        Me.txtTallyTons.Name = "txtTallyTons"
        Me.txtTallyTons.TabIndex = 337
        Me.txtTallyTons.Text = ""
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(262, 34)
        Me.txtVoyage.MaxLength = 6
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(110, 21)
        Me.txtVoyage.TabIndex = 336
        Me.txtVoyage.Text = ""
        '
        'txtPassAmount
        '
        Me.txtPassAmount.Location = New System.Drawing.Point(448, 8)
        Me.txtPassAmount.Name = "txtPassAmount"
        Me.txtPassAmount.TabIndex = 335
        Me.txtPassAmount.Text = ""
        '
        'txtPassTons
        '
        Me.txtPassTons.Location = New System.Drawing.Point(448, 52)
        Me.txtPassTons.Name = "txtPassTons"
        Me.txtPassTons.TabIndex = 334
        Me.txtPassTons.Text = ""
        '
        'txtTallyAmount
        '
        Me.txtTallyAmount.Enabled = False
        Me.txtTallyAmount.Location = New System.Drawing.Point(448, 30)
        Me.txtTallyAmount.Name = "txtTallyAmount"
        Me.txtTallyAmount.TabIndex = 333
        Me.txtTallyAmount.Text = ""
        '
        'txtVessel
        '
        Me.txtVessel.Location = New System.Drawing.Point(262, 8)
        Me.txtVessel.MaxLength = 40
        Me.txtVessel.Name = "txtVessel"
        Me.txtVessel.Size = New System.Drawing.Size(110, 21)
        Me.txtVessel.TabIndex = 332
        Me.txtVessel.Text = ""
        '
        'txtPassNo
        '
        Me.txtPassNo.Location = New System.Drawing.Point(76, 8)
        Me.txtPassNo.MaxLength = 10
        Me.txtPassNo.Name = "txtPassNo"
        Me.txtPassNo.Size = New System.Drawing.Size(110, 21)
        Me.txtPassNo.TabIndex = 331
        Me.txtPassNo.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(378, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 20)
        Me.Label8.TabIndex = 330
        Me.Label8.Text = "理货件数"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(378, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 20)
        Me.Label9.TabIndex = 329
        Me.Label9.Text = "理货吨数"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(378, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 20)
        Me.Label7.TabIndex = 328
        Me.Label7.Text = "放行吨数"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(378, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 20)
        Me.Label6.TabIndex = 327
        Me.Label6.Text = "放行件数"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(192, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 326
        Me.Label5.Text = "航次"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(192, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 325
        Me.Label4.Text = "船名"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 324
        Me.Label3.Text = "场站名"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 323
        Me.Label2.Text = "放行时间"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(176, 392)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(65, 24)
        Me.btnDelete.TabIndex = 348
        Me.btnDelete.Text = "删除"
        '
        'FrmTransferYardCargo_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(558, 421)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnDelete, Me.cbGoodsName, Me.Label10, Me.dtpPassTime, Me.Label1, Me.txtID, Me.cbYardName, Me.btQuit, Me.btSave, Me.C1DBG, Me.txtTallyTons, Me.txtVoyage, Me.txtPassAmount, Me.txtPassTons, Me.txtTallyAmount, Me.txtVessel, Me.txtPassNo, Me.Label8, Me.Label9, Me.Label7, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label2})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTransferYardCargo_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "散货转场信息 修改"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmTransferYardCargo_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen

        sqlstr = "select * from TransferYard_Cargo where TransferYard_Cargo_ID =" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        Dim sqlCodeYard As String
        sqlCodeYard = "SELECT Code_Yard_ID, Code_Yard_Name FROM Code_Yard ORDER BY Code_Yard_ID"
        cbYardName.DataSource = Filldata(sqlCodeYard)
        cbYardName.DisplayMember = "Code_Yard_Name"
        cbYardName.ValueMember = "Code_Yard_ID"

        Dim sqlCodeGoods As String = "SELECT CODE, GOODS FROM CODEGOODS ORDER BY CODE"
        cbGoodsName.DataSource = Filldata(sqlCodeGoods)
        cbGoodsName.DisplayMember = "GOODS"
        cbGoodsName.ValueMember = "CODE"

        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("TransferYard_Cargo_ID")
            txtPassNo.Text = ds.Tables(0).Rows(0).Item("PassNo")
            dtpPassTime.Value = ds.Tables(0).Rows(0).Item("PassTime")
            cbYardName.SelectedValue = ds.Tables(0).Rows(0).Item("YardName")
            Me.txtVessel.Text = ds.Tables(0).Rows(0).Item("Vessel_Cha")
            Me.txtVoyage.Text = ds.Tables(0).Rows(0).Item("Voyage")
            Me.cbGoodsName.Text = ds.Tables(0).Rows(0).Item("GoodsName")
            Me.txtPassAmount.Text = ds.Tables(0).Rows(0).Item("PassAmount")
            Me.txtPassTons.Text = ds.Tables(0).Rows(0).Item("PassTons")

            Dim i As Integer
            For i = 0 To FrmTransferYardCargo.ds.Tables(0).Rows.Count - 1
                If FrmTransferYardCargo.ds.Tables(0).Rows(i)("ID") = ID Then
                    Me.txtTallyAmount.Text = FrmTransferYardCargo.ds.Tables(0).Rows(i).Item("TallyAmount")
                    Me.txtTallyTons.Text = FrmTransferYardCargo.ds.Tables(0).Rows(i).Item("TallyTons")
                    Exit For
                End If
            Next
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
            sqlSubTable = "SELECT * FROM TransferYard_Cargo_List WHERE TransferYard_Cargo_ID = " & sqlID & ""
            Me.C1DBG.DataSource = Updatedata(sqlSubTableda, sqlSubTable, dsSubTable)

            Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue

            Me.C1DBG.Splits(0).DisplayColumns.Item(0).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item(1).Visible = False

            Me.C1DBG.Columns.Item("TallyNo").Caption = "计数单号"
            Me.C1DBG.Columns.Item("ArriveTime").Caption = "到场时间"
            Me.C1DBG.Columns.Item("EngineNo").Caption = "车号"
            Me.C1DBG.Columns.Item("TicketNo").Caption = "小票号"
            Me.C1DBG.Columns.Item("PackCode").Caption = "包装"
            Me.C1DBG.Columns.Item("Amount").Caption = "件数"
            Me.C1DBG.Columns.Item("Tons").Caption = "吨数"

            Me.C1DBG.Columns.Item("TransferYard_Cargo_ID").DefaultValue = ID
            Call FieldFill()
            SetColumnWidth()
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FieldFill()
        Dim i As Integer
        Try
            Dim sqlCodePack As String = "SELECT CODE_PACK, PACK_CHA, PACK_ENG FROM CODE_PACK order by px"
            Dim dvCodePack As New DataView()
            dvCodePack = Filldata(sqlCodePack)
            Me.C1DBG.Columns("PackCode").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("PackCode").ValueItems.Translate = True
            For i = 0 To dvCodePack.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                vi.DisplayValue = dvCodePack(i)("PACK_CHA")
                vi.Value = dvCodePack(i)("CODE_PACK")
                Me.C1DBG.Columns.Item("PackCode").ValueItems.Values.Add(vi)
            Next

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
            Me.C1DBG.Splits(0).DisplayColumns("TallyNo").Width = 80
            Me.C1DBG.Splits(0).DisplayColumns("ArriveTime").Width = 60
            Me.C1DBG.Splits(0).DisplayColumns("EngineNo").Width = 60
            Me.C1DBG.Splits(0).DisplayColumns("TicketNo").Width = 60
            Me.C1DBG.Splits(0).DisplayColumns("PackCode").Width = 50

            Me.C1DBG.Splits(0).DisplayColumns("Amount").Width = 70
            Me.C1DBG.Splits(0).DisplayColumns("Tons").Width = 70
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function SetNumValue(ByVal strNumColumn As String, ByVal strNumValue As String, Optional ByVal message As String = "数据") As Boolean
        Dim flag As Boolean = True
        If Trim(strNumValue) <> "" Then     '
            If IsNumeric(Trim(strNumValue)) Then
                ds.Tables(0).Rows(0).Item(strNumColumn) = Trim(strNumValue)
            Else
                MessageBox.Show(message + "应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                flag = False
            End If
        Else    '此列留空
        End If
        Return flag
    End Function

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim sqlExist As String
        Try
            If Trim(txtPassNo.Text) <> "" And cbYardName.SelectedValue <> "00" Then
                If SetNumValue("PassAmount", txtPassAmount.Text, "放行件数") = False Then
                    txtPassAmount.Focus()
                    Exit Sub
                ElseIf SetNumValue("PassTons", txtPassTons.Text, "放行吨数") = False Then
                    txtPassTons.Focus()
                    Exit Sub
                End If
                sqlExist = "SELECT PassNo FROM TransferYard_Cargo WHERE PassNo = '" & Trim(txtPassNo.Text) & "' and TransferYard_Cargo_ID <> '" & ID & "'"
                If Filldata(sqlExist).Count = 0 Then

                    ds.Tables(0).Rows(0).Item("PassNo") = Trim(txtPassNo.Text)
                    ds.Tables(0).Rows(0).Item("PassTime") = dtpPassTime.Value
                    ds.Tables(0).Rows(0).Item("YardName") = cbYardName.SelectedValue
                    ds.Tables(0).Rows(0).Item("Vessel_Cha") = Trim(txtVessel.Text)
                    ds.Tables(0).Rows(0).Item("Voyage") = Trim(txtVoyage.Text)
                    ds.Tables(0).Rows(0).Item("GoodsName") = Trim(Me.cbGoodsName.Text)
                    ds.Tables(0).Rows(0).Item("Dept_Code") = G_DeptCode

                    Me.txtTallyAmount.Clear()
                    Me.txtTallyTons.Clear()

                    Call OperateSubTable()
                Else
                    MessageBox.Show("放行单号不可重复！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("放行单号 场站名 不能为空。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub OperateSubTable()
        Dim sqlBeing As String
        Dim i, j, count As Short
        Dim iConCheck, iBeingCount As Integer
        Dim dv As New DataView()
        Dim TallyAmount, PassAmount As Integer
        Dim TallyTons, PassTons As Double
        Try
            count = Me.C1DBG.Row
            Me.C1DBG.Row = Me.C1DBG.Row + 1
            While count <> Me.C1DBG.Row     '计算c1grid当前行数
                count = Me.C1DBG.Row
                Me.C1DBG.Row = Me.C1DBG.Row + 1
            End While
            count = Me.C1DBG.Row

            For i = 0 To count - 1
                If Me.C1DBG.Columns("TallyNo").CellText(i) = "" Then
                    MessageBox.Show("计数单号不能为空.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.C1DBG.Row = i
                    Exit For
                End If
                If IsNumeric(Trim(Me.C1DBG.Columns("Amount").CellText(i))) Then
                    TallyAmount += Trim(Me.C1DBG.Columns("Amount").CellText(i))
                End If
                If IsNumeric(Trim(Me.C1DBG.Columns("Tons").CellText(i))) Then
                    TallyTons += Trim(Me.C1DBG.Columns("Tons").CellText(i))
                End If
            Next

            If i >= count Then
                If Trim(txtPassAmount.Text) <> "" Then
                    PassAmount = Trim(txtPassAmount.Text)
                End If
                If Trim(txtPassTons.Text) <> "" Then
                    PassTons = Trim(txtPassTons.Text)
                End If
                If TallyAmount > 0 Then
                    Me.txtTallyAmount.Text = TallyAmount
                    If TallyAmount > PassAmount Then
                        MessageBox.Show("货物件数超过放行数。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
                If TallyTons > 0 Then
                    Me.txtTallyTons.Text = TallyTons
                    If TallyTons > PassTons Then
                        MessageBox.Show("货物重量吨数超过放行数。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
                If MessageBox.Show("确定对以上数据的修改操作吗？", "警告提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                    '记录操作日志
                    Call OperateHistory(G_DeptName, Now, G_User, "修改", "TransferYard_Cargo", Trim(txtID.Text), "TransferYard_Cargo_ID")

                    sqlda.Update(ds)            '更新主表
                    sqlSubTableda.Update(dsSubTable)    '更新子表
                    Me.Close()
                End If
            Else
            End If
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub C1DBG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1DBG.KeyDown
        If e.KeyCode = Keys.Return And Me.C1DBG.Col = 8 Then
            Me.C1DBG.Row += 1
            Me.C1DBG.Col = 2
            SendKeys.Send("{LEFT}")
        End If
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

    Private Sub FrmTransferYardCargo_Edit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Me.txtPassNo.Focused Then
            Me.dtpPassTime.Focus()
        ElseIf Me.dtpPassTime.Focused Then
            Me.cbYardName.Focus()
        ElseIf Me.cbYardName.Focused Then
            Me.txtVessel.Focus()
        ElseIf Me.txtVessel.Focused Then
            Me.txtVoyage.Focus()
        ElseIf Me.txtVoyage.Focused Then
            Me.cbGoodsName.Focus()
        ElseIf Me.cbGoodsName.Focused Then
            Me.txtPassAmount.Focus()
        ElseIf Me.txtPassAmount.Focused Then
            '    Me.txtTallyAmount.Focus()
            'ElseIf Me.txtTallyAmount.Focused Then
            Me.txtPassTons.Focus()
        ElseIf Me.txtPassTons.Focused Then
            '    Me.txtTallyTons.Focus()
            'ElseIf Me.txtTallyTons.Focused Then
            Me.C1DBG.Focus()
        End If
    End Sub
End Class
