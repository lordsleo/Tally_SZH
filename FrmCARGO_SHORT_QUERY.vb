Imports TALLY.DBControl
Public Class FrmCARGO_SHORT_QUERY
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dw As New DataView()
    Dim dsgoods As New DataSet()
    Dim dsclerk As New DataSet()
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
    Friend WithEvents TxtOVERSHORT_REMARK As System.Windows.Forms.TextBox
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents CombWORK_NO As System.Windows.Forms.ComboBox
    Friend WithEvents CombCODE_GOODS As System.Windows.Forms.ComboBox
    Friend WithEvents TxtTALLY_AMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents TxtMARK As System.Windows.Forms.TextBox
    Friend WithEvents TxtHATCH_PACK As System.Windows.Forms.TextBox
    Friend WithEvents TxtBLNO As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtAMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtGOODS_CHA As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TxtOVERSHORT_REMARK = New System.Windows.Forms.TextBox()
        Me.BTQUIT = New System.Windows.Forms.Button()
        Me.CombWORK_NO = New System.Windows.Forms.ComboBox()
        Me.CombCODE_GOODS = New System.Windows.Forms.ComboBox()
        Me.TxtTALLY_AMOUNT = New System.Windows.Forms.TextBox()
        Me.TxtMARK = New System.Windows.Forms.TextBox()
        Me.TxtHATCH_PACK = New System.Windows.Forms.TextBox()
        Me.TxtBLNO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtAMOUNT = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtGOODS_CHA = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtOVERSHORT_REMARK
        '
        Me.TxtOVERSHORT_REMARK.Enabled = False
        Me.TxtOVERSHORT_REMARK.Location = New System.Drawing.Point(264, 62)
        Me.TxtOVERSHORT_REMARK.Name = "TxtOVERSHORT_REMARK"
        Me.TxtOVERSHORT_REMARK.Size = New System.Drawing.Size(110, 21)
        Me.TxtOVERSHORT_REMARK.TabIndex = 104
        Me.TxtOVERSHORT_REMARK.Text = ""
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(160, 152)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 103
        Me.BTQUIT.Text = "取消"
        '
        'CombWORK_NO
        '
        Me.CombWORK_NO.Enabled = False
        Me.CombWORK_NO.Location = New System.Drawing.Point(264, 114)
        Me.CombWORK_NO.Name = "CombWORK_NO"
        Me.CombWORK_NO.Size = New System.Drawing.Size(110, 20)
        Me.CombWORK_NO.TabIndex = 101
        '
        'CombCODE_GOODS
        '
        Me.CombCODE_GOODS.Enabled = False
        Me.CombCODE_GOODS.Location = New System.Drawing.Point(90, 62)
        Me.CombCODE_GOODS.Name = "CombCODE_GOODS"
        Me.CombCODE_GOODS.Size = New System.Drawing.Size(112, 20)
        Me.CombCODE_GOODS.TabIndex = 100
        '
        'TxtTALLY_AMOUNT
        '
        Me.TxtTALLY_AMOUNT.Enabled = False
        Me.TxtTALLY_AMOUNT.Location = New System.Drawing.Point(264, 36)
        Me.TxtTALLY_AMOUNT.Name = "TxtTALLY_AMOUNT"
        Me.TxtTALLY_AMOUNT.Size = New System.Drawing.Size(110, 21)
        Me.TxtTALLY_AMOUNT.TabIndex = 99
        Me.TxtTALLY_AMOUNT.Text = ""
        '
        'TxtMARK
        '
        Me.TxtMARK.Enabled = False
        Me.TxtMARK.Location = New System.Drawing.Point(90, 36)
        Me.TxtMARK.Name = "TxtMARK"
        Me.TxtMARK.Size = New System.Drawing.Size(112, 21)
        Me.TxtMARK.TabIndex = 98
        Me.TxtMARK.Text = ""
        '
        'TxtHATCH_PACK
        '
        Me.TxtHATCH_PACK.Enabled = False
        Me.TxtHATCH_PACK.Location = New System.Drawing.Point(264, 10)
        Me.TxtHATCH_PACK.Name = "TxtHATCH_PACK"
        Me.TxtHATCH_PACK.Size = New System.Drawing.Size(112, 21)
        Me.TxtHATCH_PACK.TabIndex = 97
        Me.TxtHATCH_PACK.Text = ""
        '
        'TxtBLNO
        '
        Me.TxtBLNO.Enabled = False
        Me.TxtBLNO.Location = New System.Drawing.Point(90, 10)
        Me.TxtBLNO.Name = "TxtBLNO"
        Me.TxtBLNO.Size = New System.Drawing.Size(112, 21)
        Me.TxtBLNO.TabIndex = 96
        Me.TxtBLNO.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(206, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 20)
        Me.Label7.TabIndex = 95
        Me.Label7.Text = "理货组长"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(206, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "溢短标志"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(206, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 20)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "理货件数"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(206, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "舱单件数"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "货名"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "标志"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "提单号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtAMOUNT
        '
        Me.TxtAMOUNT.Enabled = False
        Me.TxtAMOUNT.Location = New System.Drawing.Point(264, 88)
        Me.TxtAMOUNT.Name = "TxtAMOUNT"
        Me.TxtAMOUNT.Size = New System.Drawing.Size(110, 21)
        Me.TxtAMOUNT.TabIndex = 106
        Me.TxtAMOUNT.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(206, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 20)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "数量"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtGOODS_CHA
        '
        Me.TxtGOODS_CHA.Enabled = False
        Me.TxtGOODS_CHA.Location = New System.Drawing.Point(90, 86)
        Me.TxtGOODS_CHA.MaxLength = 30
        Me.TxtGOODS_CHA.Name = "TxtGOODS_CHA"
        Me.TxtGOODS_CHA.Size = New System.Drawing.Size(112, 21)
        Me.TxtGOODS_CHA.TabIndex = 108
        Me.TxtGOODS_CHA.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 20)
        Me.Label9.TabIndex = 107
        Me.Label9.Text = "货物中文描述"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCARGO_SHORT_QUERY
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(384, 189)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TxtGOODS_CHA, Me.Label9, Me.TxtAMOUNT, Me.Label8, Me.TxtOVERSHORT_REMARK, Me.BTQUIT, Me.CombWORK_NO, Me.CombCODE_GOODS, Me.TxtTALLY_AMOUNT, Me.TxtMARK, Me.TxtHATCH_PACK, Me.TxtBLNO, Me.Label7, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCARGO_SHORT_QUERY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "溢短单_查看"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCARGO_SHORT_QUERY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        dw = Getdata("select CODE_GOODS,GOODS_CHA+' '+ISNULL(GOODS_ENG,' ') as goods from code_cargo order by code_goods", dsgoods)
        CombCODE_GOODS.DataSource = dsgoods.Tables(0).DefaultView
        CombCODE_GOODS.DisplayMember = "goods"
        CombCODE_GOODS.ValueMember = "CODE_GOODS"

        dw = Getdata("select work_no,name from TALLY_CLERK order by name", dsclerk)
        CombWORK_NO.DataSource = dsclerk.Tables(0).DefaultView
        CombWORK_NO.DisplayMember = "name"
        CombWORK_NO.ValueMember = "work_no"

        dw = Updatedata(sqlda, "select * from cargo_short where cargo_short_id='" & ID & "'", ds)
        If ds.Tables(0).Rows.Count > 0 Then
            TxtBLNO.Text = ds.Tables(0).Rows(0).Item("blno")
            TxtMARK.Text = ds.Tables(0).Rows(0).Item("mark")
            CombCODE_GOODS.SelectedValue = ds.Tables(0).Rows(0).Item("code_goods")
            TxtHATCH_PACK.Text = ds.Tables(0).Rows(0).Item("hatch_pack")
            TxtTALLY_AMOUNT.Text = ds.Tables(0).Rows(0).Item("tally_amount")
            TxtOVERSHORT_REMARK.Text = ds.Tables(0).Rows(0).Item("OVERSHORT_REMARK")
            CombWORK_NO.SelectedValue = ds.Tables(0).Rows(0).Item("work_no")
            TxtAMOUNT.Text = ds.Tables(0).Rows(0).Item("AMOUNT")
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
