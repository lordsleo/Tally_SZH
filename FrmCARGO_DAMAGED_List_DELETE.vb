Imports TALLY.DBControl
Public Class FrmCARGO_DAMAGED_List_DELETE
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dw As New DataView()
    Dim dsgoods As New DataSet()
    Dim dspack As New DataSet()
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
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents BTDELETE As System.Windows.Forms.Button
    Friend WithEvents CombCODE_PACK As System.Windows.Forms.ComboBox
    Friend WithEvents CombCODE_GOODS As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDAMAGED_CONDITION As System.Windows.Forms.TextBox
    Friend WithEvents TxtMARK As System.Windows.Forms.TextBox
    Friend WithEvents TxtDAMAGED_AMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents TxtBLNO As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtGOODS_CHA As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BTQUIT = New System.Windows.Forms.Button()
        Me.BTDELETE = New System.Windows.Forms.Button()
        Me.CombCODE_PACK = New System.Windows.Forms.ComboBox()
        Me.CombCODE_GOODS = New System.Windows.Forms.ComboBox()
        Me.TxtDAMAGED_CONDITION = New System.Windows.Forms.TextBox()
        Me.TxtMARK = New System.Windows.Forms.TextBox()
        Me.TxtDAMAGED_AMOUNT = New System.Windows.Forms.TextBox()
        Me.TxtBLNO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtGOODS_CHA = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(201, 142)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 115
        Me.BTQUIT.Text = "ȡ��"
        '
        'BTDELETE
        '
        Me.BTDELETE.Location = New System.Drawing.Point(129, 142)
        Me.BTDELETE.Name = "BTDELETE"
        Me.BTDELETE.Size = New System.Drawing.Size(65, 24)
        Me.BTDELETE.TabIndex = 114
        Me.BTDELETE.Text = "ȷ��"
        '
        'CombCODE_PACK
        '
        Me.CombCODE_PACK.Enabled = False
        Me.CombCODE_PACK.Location = New System.Drawing.Point(272, 62)
        Me.CombCODE_PACK.Name = "CombCODE_PACK"
        Me.CombCODE_PACK.Size = New System.Drawing.Size(112, 20)
        Me.CombCODE_PACK.TabIndex = 113
        '
        'CombCODE_GOODS
        '
        Me.CombCODE_GOODS.Enabled = False
        Me.CombCODE_GOODS.Location = New System.Drawing.Point(272, 12)
        Me.CombCODE_GOODS.Name = "CombCODE_GOODS"
        Me.CombCODE_GOODS.Size = New System.Drawing.Size(112, 20)
        Me.CombCODE_GOODS.TabIndex = 112
        '
        'TxtDAMAGED_CONDITION
        '
        Me.TxtDAMAGED_CONDITION.Enabled = False
        Me.TxtDAMAGED_CONDITION.Location = New System.Drawing.Point(70, 90)
        Me.TxtDAMAGED_CONDITION.MaxLength = 40
        Me.TxtDAMAGED_CONDITION.Multiline = True
        Me.TxtDAMAGED_CONDITION.Name = "TxtDAMAGED_CONDITION"
        Me.TxtDAMAGED_CONDITION.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDAMAGED_CONDITION.Size = New System.Drawing.Size(312, 36)
        Me.TxtDAMAGED_CONDITION.TabIndex = 111
        Me.TxtDAMAGED_CONDITION.Text = ""
        '
        'TxtMARK
        '
        Me.TxtMARK.Enabled = False
        Me.TxtMARK.Location = New System.Drawing.Point(68, 36)
        Me.TxtMARK.MaxLength = 20
        Me.TxtMARK.Name = "TxtMARK"
        Me.TxtMARK.Size = New System.Drawing.Size(112, 21)
        Me.TxtMARK.TabIndex = 110
        Me.TxtMARK.Text = ""
        '
        'TxtDAMAGED_AMOUNT
        '
        Me.TxtDAMAGED_AMOUNT.Enabled = False
        Me.TxtDAMAGED_AMOUNT.Location = New System.Drawing.Point(70, 62)
        Me.TxtDAMAGED_AMOUNT.Name = "TxtDAMAGED_AMOUNT"
        Me.TxtDAMAGED_AMOUNT.Size = New System.Drawing.Size(112, 21)
        Me.TxtDAMAGED_AMOUNT.TabIndex = 109
        Me.TxtDAMAGED_AMOUNT.Text = ""
        '
        'TxtBLNO
        '
        Me.TxtBLNO.Enabled = False
        Me.TxtBLNO.Location = New System.Drawing.Point(68, 10)
        Me.TxtBLNO.MaxLength = 20
        Me.TxtBLNO.Name = "TxtBLNO"
        Me.TxtBLNO.Size = New System.Drawing.Size(112, 21)
        Me.TxtBLNO.TabIndex = 108
        Me.TxtBLNO.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(186, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 20)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "��װ"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 20)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "�������"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "�������"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(186, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "����"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "��־"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "�ᵥ��"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtGOODS_CHA
        '
        Me.TxtGOODS_CHA.Enabled = False
        Me.TxtGOODS_CHA.Location = New System.Drawing.Point(272, 36)
        Me.TxtGOODS_CHA.MaxLength = 30
        Me.TxtGOODS_CHA.Name = "TxtGOODS_CHA"
        Me.TxtGOODS_CHA.Size = New System.Drawing.Size(112, 21)
        Me.TxtGOODS_CHA.TabIndex = 117
        Me.TxtGOODS_CHA.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(186, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 20)
        Me.Label9.TabIndex = 116
        Me.Label9.Text = "������������"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCARGO_DAMAGED_List_DELETE
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(394, 181)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TxtGOODS_CHA, Me.Label9, Me.BTQUIT, Me.BTDELETE, Me.CombCODE_PACK, Me.CombCODE_GOODS, Me.TxtDAMAGED_CONDITION, Me.TxtMARK, Me.TxtDAMAGED_AMOUNT, Me.TxtBLNO, Me.Label7, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCARGO_DAMAGED_List_DELETE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "����_ɾ��"
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Sub FrmCARGO_DAMAGED_List_DELETE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        dw = Getdata("select CODE_GOODS,GOODS_CHA+' '+ISNULL(GOODS_ENG,' ') as goods from code_cargo order by code_goods", dsgoods)
        CombCODE_GOODS.DataSource = dsgoods.Tables(0).DefaultView
        CombCODE_GOODS.DisplayMember = "goods"
        CombCODE_GOODS.ValueMember = "CODE_GOODS"

        dw = Getdata("select code_pack,pack_cha+' '+isnull(pack_eng,' ') as pack from code_pack order by pack ", dspack)
        CombCODE_PACK.DataSource = dspack.Tables(0).DefaultView
        CombCODE_PACK.DisplayMember = "pack"
        CombCODE_PACK.ValueMember = "code_pack"

        dw = Updatedata(sqlda, "select * from CARGO_DAMAGED_List where CARGO_DAMAGED_ID='" & ID & "'", ds)
        If ds.Tables(0).Rows.Count > 0 Then
            TxtBLNO.Text = ds.Tables(0).Rows(0).Item("blno")
            TxtMARK.Text = ds.Tables(0).Rows(0).Item("mark")
            CombCODE_GOODS.SelectedValue = ds.Tables(0).Rows(0).Item("code_goods")
            TxtDAMAGED_AMOUNT.Text = ds.Tables(0).Rows(0).Item("DAMAGED_AMOUNT")
            TxtDAMAGED_CONDITION.Text = ds.Tables(0).Rows(0).Item("DAMAGED_CONDITION")
            CombCODE_PACK.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_PACK")
            TxtGOODS_CHA.Text = ds.Tables(0).Rows(0).Item("goods_cha")
        End If

        Exit Sub
Err:
        Resume Next
    End Sub
    Private Sub BTDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTDELETE.Click
        If MsgBox("ȷ��Ҫɾ����", MsgBoxStyle.YesNo, "��ʾ") = MsgBoxResult.Yes Then

            Call OperateHistory(G_DeptName, Now, G_User, "ɾ��", "CARGO_DAMAGED_List", ID, "CARGO_DAMAGED_List_id")
            ds.Tables(0).Rows(0).Delete()
            sqlda.Update(ds)
            Call BTQUIT_Click(sender, e)

        End If
    End Sub
    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub
End Class
