Imports TALLY.DBControl
Public Class FrmTransferYardCon_Add
    Inherits System.Windows.Forms.Form

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��
        AddHandler txtPassNo.KeyDown, AddressOf FrmTransferYardCon_Add_KeyDown
        AddHandler dtpPassTime.KeyDown, AddressOf FrmTransferYardCon_Add_KeyDown
        AddHandler cbYardName.KeyDown, AddressOf FrmTransferYardCon_Add_KeyDown
        AddHandler txtPass20Num.KeyDown, AddressOf FrmTransferYardCon_Add_KeyDown
        AddHandler txtPass40Num.KeyDown, AddressOf FrmTransferYardCon_Add_KeyDown
        AddHandler txtPass45Num.KeyDown, AddressOf FrmTransferYardCon_Add_KeyDown
        AddHandler txtPass58Num.KeyDown, AddressOf FrmTransferYardCon_Add_KeyDown
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents txtPassNo As System.Windows.Forms.TextBox
    Friend WithEvents txtPass20Num As System.Windows.Forms.TextBox
    Friend WithEvents txtPass40Num As System.Windows.Forms.TextBox
    Friend WithEvents txtPass45Num As System.Windows.Forms.TextBox
    Friend WithEvents txtPass58Num As System.Windows.Forms.TextBox
    Friend WithEvents txtTally20Num As System.Windows.Forms.TextBox
    Friend WithEvents txtTally40Num As System.Windows.Forms.TextBox
    Friend WithEvents txtTally45Num As System.Windows.Forms.TextBox
    Friend WithEvents txtTally58Num As System.Windows.Forms.TextBox
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents cbYardName As System.Windows.Forms.ComboBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents dtpPassTime As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmTransferYardCon_Add))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPassNo = New System.Windows.Forms.TextBox()
        Me.txtPass20Num = New System.Windows.Forms.TextBox()
        Me.txtPass40Num = New System.Windows.Forms.TextBox()
        Me.txtPass45Num = New System.Windows.Forms.TextBox()
        Me.txtPass58Num = New System.Windows.Forms.TextBox()
        Me.txtTally20Num = New System.Windows.Forms.TextBox()
        Me.txtTally40Num = New System.Windows.Forms.TextBox()
        Me.txtTally45Num = New System.Windows.Forms.TextBox()
        Me.txtTally58Num = New System.Windows.Forms.TextBox()
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.cbYardName = New System.Windows.Forms.ComboBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.dtpPassTime = New System.Windows.Forms.DateTimePicker()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "���е���"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "����ʱ��"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "��վ��"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(218, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "����20'��"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(218, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "����40'��"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(218, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "����45'��"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(218, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "����58'��"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(396, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "����20'��"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(396, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "����40'��"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(396, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 20)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "����45'��"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(396, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 20)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "����58'��"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPassNo
        '
        Me.txtPassNo.Location = New System.Drawing.Point(80, 8)
        Me.txtPassNo.MaxLength = 10
        Me.txtPassNo.Name = "txtPassNo"
        Me.txtPassNo.Size = New System.Drawing.Size(130, 21)
        Me.txtPassNo.TabIndex = 11
        Me.txtPassNo.Text = ""
        '
        'txtPass20Num
        '
        Me.txtPass20Num.Location = New System.Drawing.Point(288, 8)
        Me.txtPass20Num.Name = "txtPass20Num"
        Me.txtPass20Num.TabIndex = 14
        Me.txtPass20Num.Text = ""
        '
        'txtPass40Num
        '
        Me.txtPass40Num.Location = New System.Drawing.Point(288, 30)
        Me.txtPass40Num.Name = "txtPass40Num"
        Me.txtPass40Num.TabIndex = 18
        Me.txtPass40Num.Text = ""
        '
        'txtPass45Num
        '
        Me.txtPass45Num.Location = New System.Drawing.Point(288, 52)
        Me.txtPass45Num.Name = "txtPass45Num"
        Me.txtPass45Num.TabIndex = 17
        Me.txtPass45Num.Text = ""
        '
        'txtPass58Num
        '
        Me.txtPass58Num.Location = New System.Drawing.Point(288, 74)
        Me.txtPass58Num.Name = "txtPass58Num"
        Me.txtPass58Num.TabIndex = 16
        Me.txtPass58Num.Text = ""
        '
        'txtTally20Num
        '
        Me.txtTally20Num.Enabled = False
        Me.txtTally20Num.Location = New System.Drawing.Point(466, 8)
        Me.txtTally20Num.Name = "txtTally20Num"
        Me.txtTally20Num.TabIndex = 15
        Me.txtTally20Num.Text = ""
        '
        'txtTally40Num
        '
        Me.txtTally40Num.Enabled = False
        Me.txtTally40Num.Location = New System.Drawing.Point(466, 30)
        Me.txtTally40Num.Name = "txtTally40Num"
        Me.txtTally40Num.TabIndex = 22
        Me.txtTally40Num.Text = ""
        '
        'txtTally45Num
        '
        Me.txtTally45Num.Enabled = False
        Me.txtTally45Num.Location = New System.Drawing.Point(466, 52)
        Me.txtTally45Num.Name = "txtTally45Num"
        Me.txtTally45Num.TabIndex = 21
        Me.txtTally45Num.Text = ""
        '
        'txtTally58Num
        '
        Me.txtTally58Num.Enabled = False
        Me.txtTally58Num.Location = New System.Drawing.Point(466, 74)
        Me.txtTally58Num.Name = "txtTally58Num"
        Me.txtTally58Num.TabIndex = 20
        Me.txtTally58Num.Text = ""
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
        Me.C1DBG.Location = New System.Drawing.Point(0, 132)
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
        Me.C1DBG.TabIndex = 284
        Me.C1DBG.PropBag = CType(resources.GetObject("C1DBG.PropBag"), String)
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(324, 102)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 287
        Me.btQuit.Text = "ȡ��"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(256, 102)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 286
        Me.btSave.Text = "ȷ��"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(188, 102)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(65, 24)
        Me.btAdd.TabIndex = 285
        Me.btAdd.Text = "���"
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(256, 422)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(65, 24)
        Me.btnCommit.TabIndex = 288
        Me.btnCommit.Text = "����"
        '
        'cbYardName
        '
        Me.cbYardName.Location = New System.Drawing.Point(80, 60)
        Me.cbYardName.Name = "cbYardName"
        Me.cbYardName.Size = New System.Drawing.Size(130, 20)
        Me.cbYardName.TabIndex = 289
        '
        'txtID
        '
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 290
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'dtpPassTime
        '
        Me.dtpPassTime.Location = New System.Drawing.Point(80, 34)
        Me.dtpPassTime.Name = "dtpPassTime"
        Me.dtpPassTime.Size = New System.Drawing.Size(130, 21)
        Me.dtpPassTime.TabIndex = 291
        '
        'FrmTransferYardCon_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(580, 451)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.dtpPassTime, Me.Label1, Me.txtID, Me.cbYardName, Me.btQuit, Me.btSave, Me.btAdd, Me.btnCommit, Me.C1DBG, Me.txtTally40Num, Me.txtTally45Num, Me.txtTally58Num, Me.txtPass40Num, Me.txtPass45Num, Me.txtPass58Num, Me.txtTally20Num, Me.txtPass20Num, Me.txtPassNo, Me.Label8, Me.Label9, Me.Label10, Me.Label11, Me.Label7, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label2})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTransferYardCon_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "��װ��ת����Ϣ ����"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dsSubTable As New DataSet()
    Dim sqlSubTableda As New SqlClient.SqlDataAdapter()
    Dim row As DataRow

    Private Sub FrmTransferYardCon_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.C1DBG.Enabled = False
        Me.btnCommit.Enabled = False

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
        row = ds.Tables(0).NewRow()
        InitSubTable(ID)     '��ʼ���ӱ�c1grid
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
    
            Me.C1DBG.Columns.Item("TallyNo").Caption = "�������"
            Me.C1DBG.Columns.Item("Vessel_Cha").Caption = "���Ĵ���"
            Me.C1DBG.Columns.Item("Voyage").Caption = "����"
            Me.C1DBG.Columns.Item("BillNo").Caption = "�ᵥ��"
            Me.C1DBG.Columns.Item("ContainerNo").Caption = "��װ���"
            Me.C1DBG.Columns.Item("ContainerSize").Caption = "��ߴ�"
            Me.C1DBG.Columns.Item("SealNo").Caption = "Ǧ���"
            Me.C1DBG.Columns.Item("SealState").Caption = "Ǧ�����"
            Me.C1DBG.Columns.Item("ArriveMark").Caption = "�������"
            Me.C1DBG.Columns.Item("ArriveTime").Caption = "����ʱ��"

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
            'v1.DisplayValue = "��"
            'v1.Value = 1
            'Me.C1DBG.Columns.Item("ArriveMark").ValueItems.Values.Add(v1)
            'Dim v2 As New C1.Win.C1TrueDBGrid.ValueItem()
            'v2.DisplayValue = "��"
            'v2.Value = 0
            'Me.C1DBG.Columns.Item("ArriveMark").ValueItems.Values.Add(v2)

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
                If SetNumValue("Pass20Num", txtPass20Num.Text, "����20'��") = False Then
                    txtPass20Num.Focus()
                    Exit Sub
                ElseIf SetNumValue("Pass40Num", txtPass40Num.Text, "����40'��") = False Then
                    txtPass40Num.Focus()
                    Exit Sub
                ElseIf SetNumValue("Pass45Num", txtPass45Num.Text, "����45'��") = False Then
                    txtPass45Num.Focus()
                    Exit Sub
                ElseIf SetNumValue("Pass58Num", txtPass58Num.Text, "����58'��") = False Then
                    txtPass58Num.Focus()
                    Exit Sub
                End If
                sqlExist = "SELECT PassNo FROM TransferYard_Con WHERE PassNo = '" & Trim(txtPassNo.Text) & "'"
                If Filldata(sqlExist).Count = 0 Then
                    Me.C1DBG.Enabled = True
                    Me.btnCommit.Enabled = True
                    Me.C1DBG.Focus()
                    Call InitSubTable(-1)

                    row.Item("PassNo") = Trim(txtPassNo.Text)
                    row.Item("PassTime") = dtpPassTime.Value
                    row.Item("YardName") = cbYardName.SelectedValue

                    row.Item("Dept_Code") = G_DeptCode
                    row.Item("USER_NAME") = G_User

                    Me.txtTally20Num.Clear()
                    Me.txtTally40Num.Clear()
                    Me.txtTally45Num.Clear()
                    Me.txtTally58Num.Clear()
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
        Dim Con20Num, Con40Num, Con45Num, Con58Num, ConOtherNum As Integer

        sqlMainID = "SELECT TransferYard_Con_ID FROM TransferYard_Con WHERE PassNo = '" & Trim(txtPassNo.Text) & "'"
        Try
            count = Me.C1DBG.Row
            Me.C1DBG.Row = Me.C1DBG.Row + 1
            While count <> Me.C1DBG.Row     '����c1grid��ǰ����
                count = Me.C1DBG.Row
                Me.C1DBG.Row = Me.C1DBG.Row + 1
            End While
            count = Me.C1DBG.Row


            For i = 0 To count - 1          '�������
                strContainer = Trim(C1DBG.Columns("ContainerNo").CellText(i))
                strSealNO = Trim(C1DBG.Columns("SealNo").CellText(i))
                If strContainer <> "" Then
                    iConCheck = CheckConNO(strContainer)
                    sqlBeing = "SELECT CONTAINER_NO FROM CON_CRITERION WHERE CONTAINER_NO = '" & strContainer & "'"
                    iBeingCount = Filldata(sqlBeing).Count
                    If iBeingCount = 1 Or iConCheck = 2 Or iConCheck = 1 Then   '���ͨ������
                        If iBeingCount = 0 And iConCheck = 1 Then   '��������ûͨ��У�� ������ʾ
                            If MessageBox.Show("��װ��� " & strContainer & " У�鲻��ȷ��ȷ��������", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                Me.C1DBG.Row = i
                                Exit Sub
                            End If
                        End If
                        For j = i + 1 To count - 1
                            If strContainer = Trim(C1DBG.Columns("ContainerNo").CellText(j)) Then
                                MessageBox.Show("��װ��Ų����ظ���", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Me.C1DBG.Row = i
                                Exit Sub
                            Else
                                If strSealNO = "" Or strSealNO <> Trim(C1DBG.Columns("SealNo").CellText(j)) Then
                                    '����ͬ��Ų�ͬǦ��ţ��������
                                Else
                                    MessageBox.Show("��ͬ����Ų�������ͬ��Ǧ��ţ�", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Me.C1DBG.Row = i
                                    Exit Sub
                                End If
                            End If
                        Next
                        Select Case Trim(Me.C1DBG.Columns("ContainerSize").CellText(i))
                            Case 20
                                Con20Num += 1
                            Case 40
                                Con40Num += 1
                            Case 45
                                Con45Num += 1
                            Case 58
                                Con58Num += 1
                            Case Else
                                ConOtherNum += 1
                        End Select
                    Else
                        MessageBox.Show("��װ��Ų��淶��", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.C1DBG.Row = i
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("��װ��Ų���Ϊ�գ�", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.C1DBG.Row = i
                    Exit For
                End If
            Next
            '��ʵ��������޷��ж��Ƿ������ݿ��ظ�����Ϊ������ƴ�䣬ͬһ�������䲻�ظ�ƴ��϶��ظ������Բ����


            ''������Ƿ������ݿ��������ظ������ᵥ�²����ظ����˴����¿��ظ�������ƴ�䣩
            'Dim sqlRepeat As String
            'Dim dvRepeat As New DataView()
            'If i >= count Then
            '    For i = 0 To count - 1
            '        'sqlRepeat = "SELECT CON_LOAD_TALLY_LIST.CONTAINER_NO FROM CON_LOAD_TALLY_LIST LEFT OUTER JOIN CON_LOAD_TALLY ON CON_LOAD_TALLY_LIST.CON_LOAD_TALLY_ID = CON_LOAD_TALLY.CON_LOAD_TALLY_ID WHERE CON_LOAD_TALLY.CHI_VESSEL = '" & Trim(txtShip.Text) & "' AND CON_LOAD_TALLY.Voyage = '" & Trim(txtVoyage.Text) & "' AND CONTAINER_NO='" & Trim(Me.C1DBG.Columns("CONTAINER_NO").CellText(i)) & "' and (CON_LOAD_TALLY_LIST.CODE_TALLY_TYPE <> '2' or '" & Trim(Me.C1DBG.Columns("CODE_TALLY_TYPE").CellValue(i)) & "'<> '2')"
            '        sqlRepeat = "SELECT CON_LOAD_TALLY_LIST.CONTAINER_NO FROM CON_LOAD_TALLY_LIST LEFT OUTER JOIN CON_LOAD_TALLY ON CON_LOAD_TALLY_LIST.CON_LOAD_TALLY_ID = CON_LOAD_TALLY.CON_LOAD_TALLY_ID WHERE CON_LOAD_TALLY.CHI_VESSEL = '" & Trim(txtShip.Text) & "' AND CON_LOAD_TALLY.Voyage = '" & Trim(txtVoyage.Text) & "' AND CON_LOAD_TALLY.BLNO = '" & Trim(txtBillNO.Text) & "' AND CONTAINER_NO='" & Trim(Me.C1DBG.Columns("CONTAINER_NO").CellText(i)) & "'"
            '        dvRepeat = Filldata(sqlRepeat)
            '        If dvRepeat.Count > 0 Then  '������ظ�
            '            MessageBox.Show("�ô��δ��ᵥ�´�������ظ�����������", "������ʾ")
            '            Me.C1DBG.Row = i
            '            Exit Sub
            '        End If
            '    Next
            'End If

            If i >= count Then      '��ż���ͨ��
                Dim Pass20, Pass40, Pass45, Pass58, PassOther As Integer
                If Trim(txtPass20Num.Text) <> "" Then
                    Pass20 = Trim(txtPass20Num.Text)
                End If
                If Trim(txtPass40Num.Text) <> "" Then
                    Pass40 = Trim(txtPass40Num.Text)
                End If
                If Trim(txtPass45Num.Text) <> "" Then
                    Pass45 = Trim(txtPass45Num.Text)
                End If
                If Trim(txtPass58Num.Text) <> "" Then
                    Pass58 = Trim(txtPass58Num.Text)
                End If

                If Con20Num > 0 Then
                    txtTally20Num.Text = Con20Num
                    If Con20Num <= Pass20 Then
                        row.Item("Tally20Num") = Con20Num
                    Else
                        MessageBox.Show("20Ӣ���䵽����������������", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
                If Con40Num > 0 Then
                    txtTally40Num.Text = Con40Num
                    If Con40Num <= Pass40 Then
                        row.Item("Tally40Num") = Con40Num
                    Else
                        MessageBox.Show("40Ӣ���䵽����������������", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
                If Con45Num > 0 Then
                    txtTally45Num.Text = Con45Num
                    If Con45Num <= Pass45 Then
                        row.Item("Tally45Num") = Con45Num
                    Else
                        MessageBox.Show("45Ӣ���䵽����������������", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
                If Con58Num > 0 Then
                    txtTally58Num.Text = Con58Num
                    If Con58Num <= Pass58 Then
                        row.Item("Tally58Num") = Con58Num
                    Else
                        MessageBox.Show("58Ӣ���䵽����������������", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
                If ConOtherNum > 0 Then
                    If MessageBox.Show("���ڲ���������ߴ磬����������", "������ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                        row.Item("TallyOtherNum") = ConOtherNum
                    Else
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
                        If Me.C1DBG.Columns("ArriveMark").CellText(i) = "True" Then
                            dsSubTable.Tables(0).Rows(i)("ArriveMark") = "1"
                        ElseIf Me.C1DBG.Columns("ArriveMark").CellText(i) = "False" Then
                            dsSubTable.Tables(0).Rows(i)("ArriveMark") = "0"
                        End If
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
        If e.KeyCode = Keys.Return And Me.C1DBG.Col = 11 Then
            Me.C1DBG.Row += 1
            Me.C1DBG.Col = 2
            SendKeys.Send("{LEFT}")

            Me.C1DBG.Columns("TallyNo").Text = Me.C1DBG.Columns("TallyNo").CellText(Me.C1DBG.Row - 1)
            Me.C1DBG.Columns("Vessel_Cha").Text = Me.C1DBG.Columns("Vessel_Cha").CellText(Me.C1DBG.Row - 1)
            Me.C1DBG.Columns("Voyage").Text = Me.C1DBG.Columns("Voyage").CellText(Me.C1DBG.Row - 1)
            Me.C1DBG.Columns("BillNo").Text = Me.C1DBG.Columns("BillNo").CellText(Me.C1DBG.Row - 1)          
            Me.C1DBG.Columns("ContainerNo").Text = Me.C1DBG.Columns("ContainerNo").CellText(Me.C1DBG.Row - 1)
            Me.C1DBG.Columns("ContainerSize").Text = Me.C1DBG.Columns("ContainerSize").CellText(Me.C1DBG.Row - 1)

            Me.C1DBG.Columns("SealNo").Text = Me.C1DBG.Columns("SealNo").CellText(Me.C1DBG.Row - 1)
            Me.C1DBG.Columns("SealState").Value = Me.C1DBG.Columns("SealState").CellValue(Me.C1DBG.Row - 1)
            Me.C1DBG.Columns("ArriveMark").Value = Me.C1DBG.Columns("ArriveMark").CellValue(Me.C1DBG.Row - 1)
            Me.C1DBG.Columns("ArriveTime").Text = Me.C1DBG.Columns("ArriveTime").CellText(Me.C1DBG.Row - 1)
        End If
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        Me.txtPassNo.Clear()
        Me.dtpPassTime.Value = Now
        Me.cbYardName.SelectedValue = "00"
        Me.txtPass20Num.Clear()
        Me.txtPass40Num.Clear()
        Me.txtPass45Num.Clear()
        Me.txtPass58Num.Clear()
        Me.txtTally20Num.Clear()
        Me.txtTally40Num.Clear()
        Me.txtTally45Num.Clear()
        Me.txtTally58Num.Clear()

    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub FrmTransferYardCon_Add_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Me.txtPassNo.Focused Then
            Me.dtpPassTime.Focus()
        ElseIf Me.dtpPassTime.Focused Then
            Me.cbYardName.Focus()
        ElseIf Me.cbYardName.Focused Then
            Me.txtPass20Num.Focus()
        ElseIf Me.txtPass20Num.Focused Then
            Me.txtPass40Num.Focus()
        ElseIf Me.txtPass40Num.Focused Then
            Me.txtPass45Num.Focus()
        ElseIf Me.txtPass45Num.Focused Then
            Me.txtPass58Num.Focus()
        ElseIf Me.txtPass58Num.Focused Then
            Me.btSave.Focus()
        End If
    End Sub
End Class
