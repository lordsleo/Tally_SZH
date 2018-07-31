Imports TALLY.DBControl
Public Class FrmCARGO_DAMAGED_List_QUERY
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dw As New DataView()
    Dim dsgoods As New DataSet()
    Dim dspack As New DataSet()
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
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
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
        Me.BTQUIT.Location = New System.Drawing.Point(166, 144)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 129
        Me.BTQUIT.Text = "取消"
        '
        'CombCODE_PACK
        '
        Me.CombCODE_PACK.Enabled = False
        Me.CombCODE_PACK.Location = New System.Drawing.Point(272, 64)
        Me.CombCODE_PACK.Name = "CombCODE_PACK"
        Me.CombCODE_PACK.Size = New System.Drawing.Size(112, 20)
        Me.CombCODE_PACK.TabIndex = 127
        '
        'CombCODE_GOODS
        '
        Me.CombCODE_GOODS.Enabled = False
        Me.CombCODE_GOODS.Location = New System.Drawing.Point(272, 14)
        Me.CombCODE_GOODS.Name = "CombCODE_GOODS"
        Me.CombCODE_GOODS.Size = New System.Drawing.Size(112, 20)
        Me.CombCODE_GOODS.TabIndex = 126
        '
        'TxtDAMAGED_CONDITION
        '
        Me.TxtDAMAGED_CONDITION.Enabled = False
        Me.TxtDAMAGED_CONDITION.Location = New System.Drawing.Point(72, 92)
        Me.TxtDAMAGED_CONDITION.MaxLength = 40
        Me.TxtDAMAGED_CONDITION.Multiline = True
        Me.TxtDAMAGED_CONDITION.Name = "TxtDAMAGED_CONDITION"
        Me.TxtDAMAGED_CONDITION.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDAMAGED_CONDITION.Size = New System.Drawing.Size(312, 36)
        Me.TxtDAMAGED_CONDITION.TabIndex = 125
        Me.TxtDAMAGED_CONDITION.Text = ""
        '
        'TxtMARK
        '
        Me.TxtMARK.Enabled = False
        Me.TxtMARK.Location = New System.Drawing.Point(70, 38)
        Me.TxtMARK.MaxLength = 20
        Me.TxtMARK.Name = "TxtMARK"
        Me.TxtMARK.Size = New System.Drawing.Size(112, 21)
        Me.TxtMARK.TabIndex = 124
        Me.TxtMARK.Text = ""
        '
        'TxtDAMAGED_AMOUNT
        '
        Me.TxtDAMAGED_AMOUNT.Enabled = False
        Me.TxtDAMAGED_AMOUNT.Location = New System.Drawing.Point(72, 64)
        Me.TxtDAMAGED_AMOUNT.Name = "TxtDAMAGED_AMOUNT"
        Me.TxtDAMAGED_AMOUNT.Size = New System.Drawing.Size(112, 21)
        Me.TxtDAMAGED_AMOUNT.TabIndex = 123
        Me.TxtDAMAGED_AMOUNT.Text = ""
        '
        'TxtBLNO
        '
        Me.TxtBLNO.Enabled = False
        Me.TxtBLNO.Location = New System.Drawing.Point(70, 12)
        Me.TxtBLNO.MaxLength = 20
        Me.TxtBLNO.Name = "TxtBLNO"
        Me.TxtBLNO.Size = New System.Drawing.Size(112, 21)
        Me.TxtBLNO.TabIndex = 122
        Me.TxtBLNO.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(186, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 20)
        Me.Label7.TabIndex = 121
        Me.Label7.Text = "包装"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(14, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 20)
        Me.Label5.TabIndex = 120
        Me.Label5.Text = "残损情况"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(14, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 119
        Me.Label4.Text = "残损件数"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(186, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "货名"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "标志"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "提单号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtGOODS_CHA
        '
        Me.TxtGOODS_CHA.Enabled = False
        Me.TxtGOODS_CHA.Location = New System.Drawing.Point(272, 38)
        Me.TxtGOODS_CHA.MaxLength = 30
        Me.TxtGOODS_CHA.Name = "TxtGOODS_CHA"
        Me.TxtGOODS_CHA.Size = New System.Drawing.Size(112, 21)
        Me.TxtGOODS_CHA.TabIndex = 131
        Me.TxtGOODS_CHA.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(186, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 20)
        Me.Label9.TabIndex = 130
        Me.Label9.Text = "货物中文描述"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCARGO_DAMAGED_List_QUERY
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(396, 185)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TxtGOODS_CHA, Me.Label9, Me.BTQUIT, Me.CombCODE_PACK, Me.CombCODE_GOODS, Me.TxtDAMAGED_CONDITION, Me.TxtMARK, Me.TxtDAMAGED_AMOUNT, Me.TxtBLNO, Me.Label7, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCARGO_DAMAGED_List_QUERY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "残损单_查看"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub

    Private Sub FrmCARGO_DAMAGED_List_QUERY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
End Class
