Imports TALLY.DBControl
Public Class FrmTransferYardCargo_Delete
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dsSubTable As New DataSet()
    Dim sqlSubTableda As New SqlClient.SqlDataAdapter()

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    '������д��������������б�
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows ����������������
    Private components As System.ComponentModel.IContainer

    'ע�⣺���¹����� Windows ����������������
    '����ʹ�� Windows ����������޸Ĵ˹��̡�
    '��Ҫʹ�ô���༭���޸�����
    Friend WithEvents btnDelete As System.Windows.Forms.Button
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
    Friend WithEvents btnMainDel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmTransferYardCargo_Delete))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.btnDelete = New System.Windows.Forms.Button()
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
        Me.btnMainDel = New System.Windows.Forms.Button()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(176, 392)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(65, 24)
        Me.btnDelete.TabIndex = 373
        Me.btnDelete.Text = "��ɾ��"
        '
        'cbGoodsName
        '
        Me.cbGoodsName.Location = New System.Drawing.Point(262, 60)
        Me.cbGoodsName.MaxDropDownItems = 20
        Me.cbGoodsName.Name = "cbGoodsName"
        Me.cbGoodsName.Size = New System.Drawing.Size(110, 20)
        Me.cbGoodsName.TabIndex = 372
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(192, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 20)
        Me.Label10.TabIndex = 371
        Me.Label10.Text = "����"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpPassTime
        '
        Me.dtpPassTime.Location = New System.Drawing.Point(76, 34)
        Me.dtpPassTime.Name = "dtpPassTime"
        Me.dtpPassTime.Size = New System.Drawing.Size(110, 21)
        Me.dtpPassTime.TabIndex = 370
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 349
        Me.Label1.Text = "���е���"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 369
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'cbYardName
        '
        Me.cbYardName.Location = New System.Drawing.Point(76, 60)
        Me.cbYardName.Name = "cbYardName"
        Me.cbYardName.Size = New System.Drawing.Size(110, 20)
        Me.cbYardName.TabIndex = 368
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(312, 392)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 367
        Me.btQuit.Text = "ȡ��"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(244, 392)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 366
        Me.btSave.Text = "ȷ��"
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
        Me.C1DBG.TabIndex = 365
        Me.C1DBG.PropBag = CType(resources.GetObject("C1DBG.PropBag"), String)
        '
        'txtTallyTons
        '
        Me.txtTallyTons.Enabled = False
        Me.txtTallyTons.Location = New System.Drawing.Point(448, 74)
        Me.txtTallyTons.Name = "txtTallyTons"
        Me.txtTallyTons.TabIndex = 364
        Me.txtTallyTons.Text = ""
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(262, 34)
        Me.txtVoyage.MaxLength = 6
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(110, 21)
        Me.txtVoyage.TabIndex = 363
        Me.txtVoyage.Text = ""
        '
        'txtPassAmount
        '
        Me.txtPassAmount.Location = New System.Drawing.Point(448, 8)
        Me.txtPassAmount.Name = "txtPassAmount"
        Me.txtPassAmount.TabIndex = 362
        Me.txtPassAmount.Text = ""
        '
        'txtPassTons
        '
        Me.txtPassTons.Location = New System.Drawing.Point(448, 52)
        Me.txtPassTons.Name = "txtPassTons"
        Me.txtPassTons.TabIndex = 361
        Me.txtPassTons.Text = ""
        '
        'txtTallyAmount
        '
        Me.txtTallyAmount.Enabled = False
        Me.txtTallyAmount.Location = New System.Drawing.Point(448, 30)
        Me.txtTallyAmount.Name = "txtTallyAmount"
        Me.txtTallyAmount.TabIndex = 360
        Me.txtTallyAmount.Text = ""
        '
        'txtVessel
        '
        Me.txtVessel.Location = New System.Drawing.Point(262, 8)
        Me.txtVessel.MaxLength = 40
        Me.txtVessel.Name = "txtVessel"
        Me.txtVessel.Size = New System.Drawing.Size(110, 21)
        Me.txtVessel.TabIndex = 359
        Me.txtVessel.Text = ""
        '
        'txtPassNo
        '
        Me.txtPassNo.Location = New System.Drawing.Point(76, 8)
        Me.txtPassNo.MaxLength = 10
        Me.txtPassNo.Name = "txtPassNo"
        Me.txtPassNo.Size = New System.Drawing.Size(110, 21)
        Me.txtPassNo.TabIndex = 358
        Me.txtPassNo.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(378, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 20)
        Me.Label8.TabIndex = 357
        Me.Label8.Text = "�������"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(378, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 20)
        Me.Label9.TabIndex = 356
        Me.Label9.Text = "�������"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(378, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 20)
        Me.Label7.TabIndex = 355
        Me.Label7.Text = "���ж���"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(378, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 20)
        Me.Label6.TabIndex = 354
        Me.Label6.Text = "���м���"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(192, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 353
        Me.Label5.Text = "����"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(192, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 352
        Me.Label4.Text = "����"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 351
        Me.Label3.Text = "��վ��"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 350
        Me.Label2.Text = "����ʱ��"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnMainDel
        '
        Me.btnMainDel.Location = New System.Drawing.Point(54, 392)
        Me.btnMainDel.Name = "btnMainDel"
        Me.btnMainDel.Size = New System.Drawing.Size(65, 24)
        Me.btnMainDel.TabIndex = 374
        Me.btnMainDel.Text = "ȫ��ɾ��"
        '
        'FrmTransferYardCargo_Delete
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(558, 421)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnMainDel, Me.btnDelete, Me.cbGoodsName, Me.Label10, Me.dtpPassTime, Me.Label1, Me.txtID, Me.cbYardName, Me.btQuit, Me.btSave, Me.C1DBG, Me.txtTallyTons, Me.txtVoyage, Me.txtPassAmount, Me.txtPassTons, Me.txtTallyAmount, Me.txtVessel, Me.txtPassNo, Me.Label8, Me.Label9, Me.Label7, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label2})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTransferYardCargo_Delete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ɢ��ת����Ϣ ɾ��"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmTransferYardCargo_Delete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.txtPassNo.Enabled = False

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
        InitSubTable(ID)     '��ʼ���ӱ�c1grid
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

            Me.C1DBG.Columns.Item("TallyNo").Caption = "��������"
            Me.C1DBG.Columns.Item("ArriveTime").Caption = "����ʱ��"
            Me.C1DBG.Columns.Item("EngineNo").Caption = "����"
            Me.C1DBG.Columns.Item("TicketNo").Caption = "СƱ��"
            Me.C1DBG.Columns.Item("PackCode").Caption = "��װ"
            Me.C1DBG.Columns.Item("Amount").Caption = "����"
            Me.C1DBG.Columns.Item("Tons").Caption = "����"

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
            Dim sqlCodePack As String = "SELECT CODE_PACK, PACK_CHA, PACK_ENG FROM CODE_PACK ORDER BY CODE_PACK"
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
            Me.C1DBG.Columns("TallyNo").FooterText = "�ϼ�" & dsSubTable.Tables(0).Rows.Count & "��"
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

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            If MessageBox.Show("ȷ�����϶��ӱ��ɾ��������", "������ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                sqlSubTableda.Update(dsSubTable)    '�����ӱ�
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub OperateSubTable()

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

    Private Sub btnMainDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainDel.Click
        Try
            If MessageBox.Show("�˲�����ɾ����ǰ���е����ݣ�ȷ��Ҫɾ����", "������ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                '��¼������־
                Call OperateHistory(G_DeptName, Now, G_User, "ɾ��", "TransferYard_Cargo", Trim(txtID.Text), "TransferYard_Cargo_ID")
                ds.Tables(0).Rows(0).Delete()
                sqlda.Update(ds)
                '������ɾ���ӱ�
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
