Imports TALLY.DBControl
Public Class FrmTransferYardCargo_Add
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dsSubTable As New DataSet()
    Dim sqlSubTableda As New SqlClient.SqlDataAdapter()
    Dim row As DataRow

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��
        AddHandler txtPassNo.KeyDown, AddressOf FrmTransferYardCargo_Add_KeyDown
        AddHandler dtpPassTime.KeyDown, AddressOf FrmTransferYardCargo_Add_KeyDown
        AddHandler cbYardName.KeyDown, AddressOf FrmTransferYardCargo_Add_KeyDown
        AddHandler txtVessel.KeyDown, AddressOf FrmTransferYardCargo_Add_KeyDown
        AddHandler txtVoyage.KeyDown, AddressOf FrmTransferYardCargo_Add_KeyDown
        AddHandler cbGoodsName.KeyDown, AddressOf FrmTransferYardCargo_Add_KeyDown
        AddHandler txtPassAmount.KeyDown, AddressOf FrmTransferYardCargo_Add_KeyDown
        AddHandler txtTallyAmount.KeyDown, AddressOf FrmTransferYardCargo_Add_KeyDown
        AddHandler txtPassTons.KeyDown, AddressOf FrmTransferYardCargo_Add_KeyDown
        AddHandler txtTallyTons.KeyDown, AddressOf FrmTransferYardCargo_Add_KeyDown
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
    Friend WithEvents dtpPassTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents cbYardName As System.Windows.Forms.ComboBox
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents txtPassNo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbGoodsName As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents txtVessel As System.Windows.Forms.TextBox
    Friend WithEvents txtTallyTons As System.Windows.Forms.TextBox
    Friend WithEvents txtPassAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtPassTons As System.Windows.Forms.TextBox
    Friend WithEvents txtTallyAmount As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmTransferYardCargo_Add))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.dtpPassTime = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cbYardName = New System.Windows.Forms.ComboBox()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
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
        Me.cbGoodsName = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpPassTime
        '
        Me.dtpPassTime.Location = New System.Drawing.Point(76, 34)
        Me.dtpPassTime.Name = "dtpPassTime"
        Me.dtpPassTime.Size = New System.Drawing.Size(110, 21)
        Me.dtpPassTime.TabIndex = 319
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 292
        Me.Label1.Text = "���е���"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 318
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'cbYardName
        '
        Me.cbYardName.Location = New System.Drawing.Point(76, 60)
        Me.cbYardName.Name = "cbYardName"
        Me.cbYardName.Size = New System.Drawing.Size(110, 20)
        Me.cbYardName.TabIndex = 317
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(312, 92)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 315
        Me.btQuit.Text = "ȡ��"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(244, 92)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 314
        Me.btSave.Text = "ȷ��"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(176, 92)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(65, 24)
        Me.btAdd.TabIndex = 313
        Me.btAdd.Text = "���"
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(246, 412)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(65, 24)
        Me.btnCommit.TabIndex = 316
        Me.btnCommit.Text = "����"
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
        Me.C1DBG.Location = New System.Drawing.Point(0, 122)
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
        Me.C1DBG.TabIndex = 312
        Me.C1DBG.PropBag = CType(resources.GetObject("C1DBG.PropBag"), String)
        '
        'txtTallyTons
        '
        Me.txtTallyTons.Enabled = False
        Me.txtTallyTons.Location = New System.Drawing.Point(448, 74)
        Me.txtTallyTons.Name = "txtTallyTons"
        Me.txtTallyTons.TabIndex = 311
        Me.txtTallyTons.Text = ""
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(262, 34)
        Me.txtVoyage.MaxLength = 6
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(110, 21)
        Me.txtVoyage.TabIndex = 308
        Me.txtVoyage.Text = ""
        '
        'txtPassAmount
        '
        Me.txtPassAmount.Location = New System.Drawing.Point(448, 8)
        Me.txtPassAmount.Name = "txtPassAmount"
        Me.txtPassAmount.TabIndex = 307
        Me.txtPassAmount.Text = ""
        '
        'txtPassTons
        '
        Me.txtPassTons.Location = New System.Drawing.Point(448, 52)
        Me.txtPassTons.Name = "txtPassTons"
        Me.txtPassTons.TabIndex = 306
        Me.txtPassTons.Text = ""
        '
        'txtTallyAmount
        '
        Me.txtTallyAmount.Enabled = False
        Me.txtTallyAmount.Location = New System.Drawing.Point(448, 30)
        Me.txtTallyAmount.Name = "txtTallyAmount"
        Me.txtTallyAmount.TabIndex = 305
        Me.txtTallyAmount.Text = ""
        '
        'txtVessel
        '
        Me.txtVessel.Location = New System.Drawing.Point(262, 8)
        Me.txtVessel.MaxLength = 40
        Me.txtVessel.Name = "txtVessel"
        Me.txtVessel.Size = New System.Drawing.Size(110, 21)
        Me.txtVessel.TabIndex = 304
        Me.txtVessel.Text = ""
        '
        'txtPassNo
        '
        Me.txtPassNo.Location = New System.Drawing.Point(76, 8)
        Me.txtPassNo.MaxLength = 10
        Me.txtPassNo.Name = "txtPassNo"
        Me.txtPassNo.Size = New System.Drawing.Size(110, 21)
        Me.txtPassNo.TabIndex = 303
        Me.txtPassNo.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(378, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 20)
        Me.Label8.TabIndex = 302
        Me.Label8.Text = "�������"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(378, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 20)
        Me.Label9.TabIndex = 301
        Me.Label9.Text = "�������"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(378, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 20)
        Me.Label7.TabIndex = 298
        Me.Label7.Text = "���ж���"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(378, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 20)
        Me.Label6.TabIndex = 297
        Me.Label6.Text = "���м���"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(192, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 296
        Me.Label5.Text = "����"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(192, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 295
        Me.Label4.Text = "����"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 294
        Me.Label3.Text = "��վ��"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 293
        Me.Label2.Text = "����ʱ��"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbGoodsName
        '
        Me.cbGoodsName.Location = New System.Drawing.Point(262, 60)
        Me.cbGoodsName.MaxDropDownItems = 20
        Me.cbGoodsName.Name = "cbGoodsName"
        Me.cbGoodsName.Size = New System.Drawing.Size(110, 20)
        Me.cbGoodsName.TabIndex = 321
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(192, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 20)
        Me.Label10.TabIndex = 320
        Me.Label10.Text = "����"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmTransferYardCargo_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(558, 441)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbGoodsName, Me.Label10, Me.dtpPassTime, Me.Label1, Me.txtID, Me.cbYardName, Me.btQuit, Me.btSave, Me.btAdd, Me.btnCommit, Me.C1DBG, Me.txtTallyTons, Me.txtVoyage, Me.txtPassAmount, Me.txtPassTons, Me.txtTallyAmount, Me.txtVessel, Me.txtPassNo, Me.Label8, Me.Label9, Me.Label7, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label2})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTransferYardCargo_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ɢ��ת����Ϣ ����"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmTransferYardCargo_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.C1DBG.Enabled = False
        Me.btnCommit.Enabled = False

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
        row = ds.Tables(0).NewRow()
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

            Call FieldFill()
            SetColumnWidth()
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FieldFill()
        Dim i As Integer
        Try
            Dim sqlCodePack As String = "SELECT CODE_PACK, PACK_CHA, PACK_ENG FROM CODE_PACK  order by px"
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

    Private Function SetNumValue(ByVal strNumColumn As String, ByVal strNumValue As String, Optional ByVal message As String = "����") As Boolean
        Dim flag As Boolean = True
        If Trim(strNumValue) <> "" Then     '
            If IsNumeric(Trim(strNumValue)) Then
                row.Item(strNumColumn) = Trim(strNumValue)
            Else
                MessageBox.Show(message + "ӦΪ���֣�", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                flag = False
            End If
        Else    '��������
        End If
        Return flag
    End Function

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim sqlExist As String
        Try
            If Trim(txtPassNo.Text) <> "" And cbYardName.SelectedValue <> "00" Then
                If SetNumValue("PassAmount", txtPassAmount.Text, "���м���") = False Then
                    txtPassAmount.Focus()
                    Exit Sub
                ElseIf SetNumValue("PassTons", txtPassTons.Text, "���ж���") = False Then
                    txtPassTons.Focus()
                    Exit Sub
                End If
                sqlExist = "SELECT PassNo FROM TransferYard_Cargo WHERE PassNo = '" & Trim(txtPassNo.Text) & "'"
                If Filldata(sqlExist).Count = 0 Then
                    Me.C1DBG.Enabled = True
                    Me.btnCommit.Enabled = True
                    Me.C1DBG.Focus()
                    Call InitSubTable(-1)

                    row.Item("PassNo") = Trim(txtPassNo.Text)
                    row.Item("PassTime") = dtpPassTime.Value
                    row.Item("YardName") = cbYardName.SelectedValue
                    row.Item("Vessel_Cha") = Trim(txtVessel.Text)
                    row.Item("Voyage") = Trim(txtVoyage.Text)
                    row.Item("GoodsName") = Trim(Me.cbGoodsName.Text)

                    row.Item("Dept_Code") = G_DeptCode
                    row.Item("USER_NAME") = G_User

                    Me.txtTallyAmount.Clear()
                    Me.txtTallyTons.Clear()
                Else
                    MessageBox.Show("���е��Ų����ظ���", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("���е��� ��վ�� ����Ϊ�ա�", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function CheckConNO(ByVal sm As String) As Integer 'return 0 ����д� 1 У���д� 2 У����ȷ
        Dim S() As Integer = {10, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 34, 35, 36, 37, 38}
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim l As Integer
        i = 0
        str = UCase(sm)
        If Len(Trim(str)) = 12 And Mid(Trim(str), 5, 1) = " " Then
            str = Mid(Trim(str), 1, 4) & Mid(Trim(str), 6, 7)
        ElseIf Len(Trim(str)) <> 11 Then
            Return 0
        End If
        k = 1
        For j = 1 To 4
            If Asc(Mid(Trim(str), j, 1)) >= Asc("A") And Asc(Mid(Trim(str), j, 1)) <= Asc("Z") Then
                i = i + S(Asc(Mid(Trim(str), j, 1).ToUpper) - Asc("A")) * System.Math.Pow(2, k - 1)
            Else
                Return 0
            End If

            k = k + 1
        Next

        For j = 5 To 10
            If Asc(Mid(Trim(str), j, 1)) >= Asc("0") And Asc(Mid(Trim(str), j, 1)) <= Asc("9") Then
                i = i + CInt(Mid(Trim(str), j, 1)) * System.Math.Pow(2, k - 1)
            Else
                Return 0
            End If

            k = k + 1
        Next
        If i Mod 11 = CInt(Mid(Trim(str), 11, 1)) Or (i Mod 11) - 10 = CInt(Mid(Trim(str), 11, 1)) Then
            Return 2
        Else
            Return 1
        End If
    End Function

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        Dim strContainer, strSealNO, strConsign, sqlMainID, sqlBeing As String
        Dim mainConSubID As Integer
        Dim i, j, count As Short
        Dim iConCheck, iBeingCount As Integer
        Dim dv As New DataView()
        Dim TallyAmount, PassAmount As Integer
        Dim TallyTons, PassTons As Double

        sqlMainID = "SELECT TransferYard_Cargo_ID FROM TransferYard_Cargo WHERE PassNo = '" & Trim(txtPassNo.Text) & "'"
        Try
            count = Me.C1DBG.Row
            Me.C1DBG.Row = Me.C1DBG.Row + 1
            While count <> Me.C1DBG.Row     '����c1grid��ǰ����
                count = Me.C1DBG.Row
                Me.C1DBG.Row = Me.C1DBG.Row + 1
            End While
            count = Me.C1DBG.Row

            For i = 0 To count - 1
                If Me.C1DBG.Columns("TallyNo").CellText(i) = "" Then
                    MessageBox.Show("�������Ų���Ϊ��.", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                        MessageBox.Show("�������������������", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
                If TallyTons > 0 Then
                    Me.txtTallyTons.Text = TallyTons
                    If TallyTons > PassTons Then
                        MessageBox.Show("������������������������", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If

                ds.Tables(0).Rows.Add(row)
                sqlda.Update(ds)            '��������

                dv = Filldata(sqlMainID)    'ȡ������ǰ������ID
                If dv.Count = 1 Then        '�������ɹ�
                    mainConSubID = CType(dv.Item(0)(0), Integer)
                    For i = 0 To count - 1
                        Me.dsSubTable.Tables(0).Rows(i)(1) = mainConSubID   'д������ǰ������ID
                    Next

                    sqlSubTableda.Update(dsSubTable)    '�����ӱ�
                    Me.Close()
                Else
                    MessageBox.Show("����δ���������£��洢ʧ�ܣ�", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

            Me.C1DBG.Columns("TallyNo").Text = Me.C1DBG.Columns("TallyNo").CellText(Me.C1DBG.Row - 1)
            Me.C1DBG.Columns("ArriveTime").Text = Me.C1DBG.Columns("ArriveTime").CellText(Me.C1DBG.Row - 1)
            Me.C1DBG.Columns("EngineNo").Text = Me.C1DBG.Columns("EngineNo").CellText(Me.C1DBG.Row - 1)
            Me.C1DBG.Columns("TicketNo").Text = Me.C1DBG.Columns("TicketNo").CellText(Me.C1DBG.Row - 1)
            Me.C1DBG.Columns("PackCode").Value = Me.C1DBG.Columns("PackCode").CellValue(Me.C1DBG.Row - 1)
            Me.C1DBG.Columns("Amount").Text = Me.C1DBG.Columns("Amount").CellText(Me.C1DBG.Row - 1)
            Me.C1DBG.Columns("Tons").Text = Me.C1DBG.Columns("Tons").CellText(Me.C1DBG.Row - 1)
        End If
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        Me.txtPassNo.Clear()
        Me.dtpPassTime.Value = Now
        Me.cbYardName.SelectedValue = "00"
        Me.txtVessel.Clear()
        Me.txtVoyage.Clear()
        Me.cbGoodsName.Text = ""
        Me.txtPassAmount.Clear()
        Me.txtPassTons.Clear()
        Me.txtTallyAmount.Clear()
        Me.txtTallyTons.Clear()
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub FrmTransferYardCargo_Add_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
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
            Me.btSave.Focus()
        End If
    End Sub
End Class
