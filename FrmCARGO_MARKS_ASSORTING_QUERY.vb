Imports TALLY.DBControl
Public Class FrmCARGO_MARKS_ASSORTING_QUERY
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dw As New DataView()
    Dim dsgoods As New DataSet()
    Dim dspack As New DataSet()
    Dim dspack2 As New DataSet()
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
    Friend WithEvents TxtAMOUNT_SHORT As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtAMOUNT_OVER As System.Windows.Forms.TextBox
    Friend WithEvents CombPACK_ASSORT As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CombCODE_PACK As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtNO As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents CombCODE_GOODS As System.Windows.Forms.ComboBox
    Friend WithEvents TxtAMOUNT_ASSORT As System.Windows.Forms.TextBox
    Friend WithEvents TxtMARK As System.Windows.Forms.TextBox
    Friend WithEvents TxtAMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents TxtBLNO As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtGOODS_CHA As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtTALLY_AMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TxtAMOUNT_SHORT = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtAMOUNT_OVER = New System.Windows.Forms.TextBox()
        Me.CombPACK_ASSORT = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CombCODE_PACK = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNO = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTQUIT = New System.Windows.Forms.Button()
        Me.CombCODE_GOODS = New System.Windows.Forms.ComboBox()
        Me.TxtAMOUNT_ASSORT = New System.Windows.Forms.TextBox()
        Me.TxtMARK = New System.Windows.Forms.TextBox()
        Me.TxtAMOUNT = New System.Windows.Forms.TextBox()
        Me.TxtBLNO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtGOODS_CHA = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtTALLY_AMOUNT = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtAMOUNT_SHORT
        '
        Me.TxtAMOUNT_SHORT.Enabled = False
        Me.TxtAMOUNT_SHORT.Location = New System.Drawing.Point(280, 140)
        Me.TxtAMOUNT_SHORT.Name = "TxtAMOUNT_SHORT"
        Me.TxtAMOUNT_SHORT.Size = New System.Drawing.Size(110, 21)
        Me.TxtAMOUNT_SHORT.TabIndex = 138
        Me.TxtAMOUNT_SHORT.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(210, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 20)
        Me.Label10.TabIndex = 137
        Me.Label10.Text = "短件数"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(210, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 20)
        Me.Label9.TabIndex = 136
        Me.Label9.Text = "溢件数"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtAMOUNT_OVER
        '
        Me.TxtAMOUNT_OVER.Enabled = False
        Me.TxtAMOUNT_OVER.Location = New System.Drawing.Point(280, 114)
        Me.TxtAMOUNT_OVER.Name = "TxtAMOUNT_OVER"
        Me.TxtAMOUNT_OVER.Size = New System.Drawing.Size(110, 21)
        Me.TxtAMOUNT_OVER.TabIndex = 135
        Me.TxtAMOUNT_OVER.Text = ""
        '
        'CombPACK_ASSORT
        '
        Me.CombPACK_ASSORT.Enabled = False
        Me.CombPACK_ASSORT.Location = New System.Drawing.Point(280, 88)
        Me.CombPACK_ASSORT.Name = "CombPACK_ASSORT"
        Me.CombPACK_ASSORT.Size = New System.Drawing.Size(110, 20)
        Me.CombPACK_ASSORT.TabIndex = 134
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(210, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 20)
        Me.Label8.TabIndex = 133
        Me.Label8.Text = "分标志包装"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CombCODE_PACK
        '
        Me.CombCODE_PACK.Enabled = False
        Me.CombCODE_PACK.Location = New System.Drawing.Point(94, 140)
        Me.CombCODE_PACK.Name = "CombCODE_PACK"
        Me.CombCODE_PACK.Size = New System.Drawing.Size(112, 20)
        Me.CombCODE_PACK.TabIndex = 132
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(10, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 20)
        Me.Label7.TabIndex = 131
        Me.Label7.Text = "舱单包装"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtNO
        '
        Me.TxtNO.Enabled = False
        Me.TxtNO.Location = New System.Drawing.Point(94, 12)
        Me.TxtNO.MaxLength = 10
        Me.TxtNO.Name = "TxtNO"
        Me.TxtNO.Size = New System.Drawing.Size(112, 21)
        Me.TxtNO.TabIndex = 130
        Me.TxtNO.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(10, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 129
        Me.Label6.Text = "编号"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(168, 176)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 128
        Me.BTQUIT.Text = "取消"
        '
        'CombCODE_GOODS
        '
        Me.CombCODE_GOODS.Enabled = False
        Me.CombCODE_GOODS.Location = New System.Drawing.Point(94, 90)
        Me.CombCODE_GOODS.Name = "CombCODE_GOODS"
        Me.CombCODE_GOODS.Size = New System.Drawing.Size(112, 20)
        Me.CombCODE_GOODS.TabIndex = 126
        '
        'TxtAMOUNT_ASSORT
        '
        Me.TxtAMOUNT_ASSORT.Enabled = False
        Me.TxtAMOUNT_ASSORT.Location = New System.Drawing.Point(280, 62)
        Me.TxtAMOUNT_ASSORT.Name = "TxtAMOUNT_ASSORT"
        Me.TxtAMOUNT_ASSORT.Size = New System.Drawing.Size(110, 21)
        Me.TxtAMOUNT_ASSORT.TabIndex = 125
        Me.TxtAMOUNT_ASSORT.Text = ""
        '
        'TxtMARK
        '
        Me.TxtMARK.Enabled = False
        Me.TxtMARK.Location = New System.Drawing.Point(94, 64)
        Me.TxtMARK.Name = "TxtMARK"
        Me.TxtMARK.Size = New System.Drawing.Size(112, 21)
        Me.TxtMARK.TabIndex = 124
        Me.TxtMARK.Text = ""
        '
        'TxtAMOUNT
        '
        Me.TxtAMOUNT.Enabled = False
        Me.TxtAMOUNT.Location = New System.Drawing.Point(280, 14)
        Me.TxtAMOUNT.Name = "TxtAMOUNT"
        Me.TxtAMOUNT.Size = New System.Drawing.Size(110, 21)
        Me.TxtAMOUNT.TabIndex = 123
        Me.TxtAMOUNT.Text = ""
        '
        'TxtBLNO
        '
        Me.TxtBLNO.Enabled = False
        Me.TxtBLNO.Location = New System.Drawing.Point(94, 38)
        Me.TxtBLNO.Name = "TxtBLNO"
        Me.TxtBLNO.Size = New System.Drawing.Size(112, 21)
        Me.TxtBLNO.TabIndex = 122
        Me.TxtBLNO.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(210, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "分标志件数"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(210, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "舱单件数"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "货名"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "标志"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "提单号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtGOODS_CHA
        '
        Me.TxtGOODS_CHA.Enabled = False
        Me.TxtGOODS_CHA.Location = New System.Drawing.Point(94, 114)
        Me.TxtGOODS_CHA.MaxLength = 30
        Me.TxtGOODS_CHA.Name = "TxtGOODS_CHA"
        Me.TxtGOODS_CHA.Size = New System.Drawing.Size(112, 21)
        Me.TxtGOODS_CHA.TabIndex = 140
        Me.TxtGOODS_CHA.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(10, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 20)
        Me.Label11.TabIndex = 139
        Me.Label11.Text = "货物中文描述"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTALLY_AMOUNT
        '
        Me.TxtTALLY_AMOUNT.Enabled = False
        Me.TxtTALLY_AMOUNT.Location = New System.Drawing.Point(280, 38)
        Me.TxtTALLY_AMOUNT.Name = "TxtTALLY_AMOUNT"
        Me.TxtTALLY_AMOUNT.Size = New System.Drawing.Size(110, 21)
        Me.TxtTALLY_AMOUNT.TabIndex = 142
        Me.TxtTALLY_AMOUNT.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(210, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 20)
        Me.Label12.TabIndex = 141
        Me.Label12.Text = "理货件数"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCARGO_MARKS_ASSORTING_QUERY
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(400, 215)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TxtTALLY_AMOUNT, Me.Label12, Me.TxtGOODS_CHA, Me.Label11, Me.TxtAMOUNT_SHORT, Me.Label10, Me.Label9, Me.TxtAMOUNT_OVER, Me.CombPACK_ASSORT, Me.Label8, Me.CombCODE_PACK, Me.Label7, Me.TxtNO, Me.Label6, Me.BTQUIT, Me.CombCODE_GOODS, Me.TxtAMOUNT_ASSORT, Me.TxtMARK, Me.TxtAMOUNT, Me.TxtBLNO, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCARGO_MARKS_ASSORTING_QUERY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "分标志单_查看"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCARGO_MARKS_ASSORTING_QUERY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        dw = Getdata("select CODE_GOODS,GOODS_CHA+' '+ISNULL(GOODS_ENG,' ') as goods from code_cargo order by code_goods", dsgoods)
        CombCODE_GOODS.DataSource = dsgoods.Tables(0).DefaultView
        CombCODE_GOODS.DisplayMember = "goods"
        CombCODE_GOODS.ValueMember = "CODE_GOODS"

        dw = Getdata("select code_pack,pack_cha+' '+isnull(pack_eng,' ') as pack from code_pack order by px ", dspack)
        CombCODE_PACK.DataSource = dspack.Tables(0).DefaultView
        CombCODE_PACK.DisplayMember = "pack"
        CombCODE_PACK.ValueMember = "code_pack"

        dw = Getdata("select code_pack,pack_cha+' '+isnull(pack_eng,' ') as pack from code_pack order by px ", dspack2)
        CombPACK_ASSORT.DataSource = dspack2.Tables(0).DefaultView
        CombPACK_ASSORT.DisplayMember = "pack"
        CombPACK_ASSORT.ValueMember = "code_pack"

        dw = Updatedata(sqlda, "select * from CARGO_MARKS_ASSORTING where CARGO_MARKS_id='" & ID & "'", ds)
        If ds.Tables(0).Rows.Count > 0 Then
            TxtNO.Text = ds.Tables(0).Rows(0).Item("no")
            TxtBLNO.Text = ds.Tables(0).Rows(0).Item("blno")
            TxtMARK.Text = ds.Tables(0).Rows(0).Item("mark")
            CombCODE_GOODS.SelectedValue = ds.Tables(0).Rows(0).Item("code_goods")
            TxtAMOUNT.Text = ds.Tables(0).Rows(0).Item("amount")
            TxtTALLY_AMOUNT.Text = ds.Tables(0).Rows(0).Item("TALLY_amount")
            TxtAMOUNT_ASSORT.Text = ds.Tables(0).Rows(0).Item("AMOUNT_assort")
            TxtAMOUNT_OVER.Text = ds.Tables(0).Rows(0).Item("amount_OVER")
            TxtAMOUNT_SHORT.Text = ds.Tables(0).Rows(0).Item("amount_short")
            CombCODE_PACK.SelectedValue = ds.Tables(0).Rows(0).Item("code_pack")
            CombPACK_ASSORT.SelectedValue = ds.Tables(0).Rows(0).Item("pack_assort")
            TxtGOODS_CHA.Text = ds.Tables(0).Rows(0).Item("goods_cha")
        End If

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub
End Class
