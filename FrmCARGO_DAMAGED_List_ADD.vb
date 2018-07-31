Imports TALLY.DBControl
Public Class FrmCARGO_DAMAGED_List_ADD
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dw As New DataView()
    Dim dsgoods As New DataSet()
    Dim dspack As New DataSet
    Dim dsss As New DataSet

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
    Friend WithEvents BTADD As System.Windows.Forms.Button
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents BTOK As System.Windows.Forms.Button
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
        Me.BTADD = New System.Windows.Forms.Button()
        Me.BTQUIT = New System.Windows.Forms.Button()
        Me.BTOK = New System.Windows.Forms.Button()
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
        'BTADD
        '
        Me.BTADD.Location = New System.Drawing.Point(110, 144)
        Me.BTADD.Name = "BTADD"
        Me.BTADD.Size = New System.Drawing.Size(65, 24)
        Me.BTADD.TabIndex = 87
        Me.BTADD.Text = "清空"
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(256, 144)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 86
        Me.BTQUIT.Text = "取消"
        '
        'BTOK
        '
        Me.BTOK.Location = New System.Drawing.Point(184, 144)
        Me.BTOK.Name = "BTOK"
        Me.BTOK.Size = New System.Drawing.Size(65, 24)
        Me.BTOK.TabIndex = 85
        Me.BTOK.Text = "确认"
        '
        'CombCODE_PACK
        '
        Me.CombCODE_PACK.Location = New System.Drawing.Point(272, 66)
        Me.CombCODE_PACK.Name = "CombCODE_PACK"
        Me.CombCODE_PACK.Size = New System.Drawing.Size(112, 20)
        Me.CombCODE_PACK.TabIndex = 84
        '
        'CombCODE_GOODS
        '
        Me.CombCODE_GOODS.Location = New System.Drawing.Point(272, 14)
        Me.CombCODE_GOODS.Name = "CombCODE_GOODS"
        Me.CombCODE_GOODS.Size = New System.Drawing.Size(112, 20)
        Me.CombCODE_GOODS.TabIndex = 83
        '
        'TxtDAMAGED_CONDITION
        '
        Me.TxtDAMAGED_CONDITION.Location = New System.Drawing.Point(72, 92)
        Me.TxtDAMAGED_CONDITION.MaxLength = 40
        Me.TxtDAMAGED_CONDITION.Multiline = True
        Me.TxtDAMAGED_CONDITION.Name = "TxtDAMAGED_CONDITION"
        Me.TxtDAMAGED_CONDITION.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDAMAGED_CONDITION.Size = New System.Drawing.Size(312, 36)
        Me.TxtDAMAGED_CONDITION.TabIndex = 82
        Me.TxtDAMAGED_CONDITION.Text = ""
        '
        'TxtMARK
        '
        Me.TxtMARK.Location = New System.Drawing.Point(70, 38)
        Me.TxtMARK.MaxLength = 20
        Me.TxtMARK.Name = "TxtMARK"
        Me.TxtMARK.Size = New System.Drawing.Size(112, 21)
        Me.TxtMARK.TabIndex = 81
        Me.TxtMARK.Text = ""
        '
        'TxtDAMAGED_AMOUNT
        '
        Me.TxtDAMAGED_AMOUNT.Location = New System.Drawing.Point(72, 64)
        Me.TxtDAMAGED_AMOUNT.Name = "TxtDAMAGED_AMOUNT"
        Me.TxtDAMAGED_AMOUNT.Size = New System.Drawing.Size(112, 21)
        Me.TxtDAMAGED_AMOUNT.TabIndex = 80
        Me.TxtDAMAGED_AMOUNT.Text = ""
        '
        'TxtBLNO
        '
        Me.TxtBLNO.Location = New System.Drawing.Point(70, 12)
        Me.TxtBLNO.MaxLength = 20
        Me.TxtBLNO.Name = "TxtBLNO"
        Me.TxtBLNO.Size = New System.Drawing.Size(112, 21)
        Me.TxtBLNO.TabIndex = 79
        Me.TxtBLNO.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(186, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 20)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "包装"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(14, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 20)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "残损情况"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(14, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "残损件数"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(186, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "货名"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "标志"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "提单号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtGOODS_CHA
        '
        Me.TxtGOODS_CHA.Location = New System.Drawing.Point(272, 40)
        Me.TxtGOODS_CHA.MaxLength = 30
        Me.TxtGOODS_CHA.Name = "TxtGOODS_CHA"
        Me.TxtGOODS_CHA.Size = New System.Drawing.Size(112, 21)
        Me.TxtGOODS_CHA.TabIndex = 89
        Me.TxtGOODS_CHA.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(186, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 20)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "货物中文描述"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCARGO_DAMAGED_List_ADD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(396, 181)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TxtGOODS_CHA, Me.Label9, Me.BTADD, Me.BTQUIT, Me.BTOK, Me.CombCODE_PACK, Me.CombCODE_GOODS, Me.TxtDAMAGED_CONDITION, Me.TxtMARK, Me.TxtDAMAGED_AMOUNT, Me.TxtBLNO, Me.Label7, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCARGO_DAMAGED_List_ADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "残损单_增加"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCARGO_DAMAGED_List_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        dw = Getdata("select CODE,GOODS from codegoods order by code ", dsgoods)
        CombCODE_GOODS.DataSource = dsgoods.Tables(0).DefaultView
        CombCODE_GOODS.DisplayMember = "GOODS"
        CombCODE_GOODS.ValueMember = "CODE"

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
    Private Sub BTADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTADD.Click
        TxtBLNO.Text = ""
        TxtMARK.Text = "N/M"
        CombCODE_GOODS.SelectedValue = "0000"
        CombCODE_GOODS.SelectedValue = "000"
        TxtDAMAGED_AMOUNT.Text = "0"
        TxtDAMAGED_CONDITION.Text = ""
        TxtGOODS_CHA.Text = ""


    End Sub

    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub

    Private Sub BTOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOK.Click
        Try
            If Len(Trim(TxtBLNO.Text)) > 0 Then
                If Len(Trim(TxtMARK.Text)) > 0 Then
                    If Len(Trim(CombCODE_GOODS.SelectedValue)) > 0 Then

                        Dim dskey As New DataSet()
                        dw = Getdata("select * from CARGO_DAMAGED_List where  blno='" & Trim(TxtBLNO.Text) & "' and mark='" & Trim(TxtMARK.Text) & "' and ship_id='" & Ship_ID & "' and CODE_GOODS='" & CombCODE_GOODS.SelectedValue & "' and DAMAGED_CONDITION='" & TxtDAMAGED_CONDITION.Text & "' and CODE_PACK='" & CombCODE_PACK.SelectedValue & "' and DAMAGED_AMOUNT='" & TxtDAMAGED_AMOUNT.Text & "' ", dskey)
                        If dskey.Tables(0).Rows.Count > 0 Then
                            MsgBox("此残损单在数据库中已存在！")
                        Else
                            Dim row As DataRow
                            row = ds.Tables(0).NewRow
                            row("SHIP_ID") = Trim(Ship_ID)
                            row("BLNO") = Trim(TxtBLNO.Text)
                            row("MARK") = Trim(TxtMARK.Text)
                            row("CODE_GOODS") = IIf(Len(Trim(CombCODE_GOODS.SelectedValue)) > 0, Trim(CombCODE_GOODS.SelectedValue), "0000")
                            row("DAMAGED_AMOUNT") = IIf(Len(Trim(TxtDAMAGED_AMOUNT.Text)) > 0, Trim(TxtDAMAGED_AMOUNT.Text), "0")
                            row("DAMAGED_CONDITION") = Trim(TxtDAMAGED_CONDITION.Text)
                            row("code_PACK") = IIf(Len(Trim(CombCODE_PACK.SelectedValue)) > 0, Trim(CombCODE_PACK.SelectedValue), "000")
                            row("goods_cha") = Trim(TxtGOODS_CHA.Text)
                            row("USER_NAME") = Trim(G_User)

                            ds.Tables(0).Rows.Add(row)
                            sqlda.Update(ds)
                            Call BTQUIT_Click(sender, e)
                        End If
                    
                Else
                        MsgBox("货名不能为空！")
                    End If
                Else
                    MsgBox("标志不能为空！")
                End If
            Else
                MsgBox("提单号不能为空！")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub TxtBLNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBLNO.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtMARK.Focus()
        End If
    End Sub
    Private Sub TxtMARK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMARK.KeyPress
        If e.KeyChar = Chr(13) Then
            CombCODE_GOODS.Focus()
        End If
    End Sub
    Private Sub CombCODE_GOODS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombCODE_GOODS.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtGOODS_CHA.Focus()
        End If
    End Sub
    Private Sub txtGOODS_cha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGOODS_CHA.KeyPress
        If e.KeyChar = Chr(13) Then
            CombCODE_PACK.Focus()
        End If
    End Sub
    Private Sub CombCODE_PACK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombCODE_PACK.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtDAMAGED_AMOUNT.Focus()
        End If
    End Sub
    Private Sub TxtDAMAGED_AMOUNT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDAMAGED_AMOUNT.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtDAMAGED_CONDITION.Focus()
        End If
    End Sub
    Private Sub TxtDAMAGED_CONDITION_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDAMAGED_CONDITION.KeyPress
        If e.KeyChar = Chr(13) Then
            BTOK.Focus()
        End If
    End Sub

    Private Sub CombCODE_GOODS_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CombCODE_GOODS.Leave
        Dim dsss As New DataSet
        If CombCODE_GOODS.Text.Trim().Length() > 0 Then
            Getdata("select * from CODEGOODS where code like '%" & CombCODE_GOODS.Text.Trim() & "%' or goods like '%" & CombCODE_GOODS.Text.Trim() & "%' or goods_eng like '%" & CombCODE_GOODS.Text.Trim() & "%' or goods_short like '%" & CombCODE_GOODS.Text.Trim() & "%'", dsss)
            If dsss.Tables(0).DefaultView.Count > 0 Then
                CombCODE_GOODS.SelectedValue = dsss.Tables(0).Rows(0)("code")
                'TxtGOODS_ENG.Text = IIf(IsDBNull(dsss.Tables(0).Rows(0)("Goods_Eng")), "", dsss.Tables(0).Rows(0)("Goods_Eng"))
                TxtGOODS_CHA.Text = CombCODE_GOODS.Text.Trim()
            End If

        End If
    End Sub
End Class
