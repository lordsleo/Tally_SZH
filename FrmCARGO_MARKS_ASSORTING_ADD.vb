Imports TALLY.DBControl
Public Class FrmCARGO_MARKS_ASSORTING_ADD
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
    Friend WithEvents BTADD As System.Windows.Forms.Button
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents BTOK As System.Windows.Forms.Button
    Friend WithEvents CombCODE_GOODS As System.Windows.Forms.ComboBox
    Friend WithEvents TxtMARK As System.Windows.Forms.TextBox
    Friend WithEvents TxtBLNO As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNO As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CombCODE_PACK As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtAMOUNT_ASSORT As System.Windows.Forms.TextBox
    Friend WithEvents TxtAMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents CombPACK_ASSORT As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtAMOUNT_OVER As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtAMOUNT_SHORT As System.Windows.Forms.TextBox
    Friend WithEvents TxtGOODS_CHA As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtTALLY_AMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BTADD = New System.Windows.Forms.Button()
        Me.BTQUIT = New System.Windows.Forms.Button()
        Me.BTOK = New System.Windows.Forms.Button()
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
        Me.TxtNO = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CombCODE_PACK = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CombPACK_ASSORT = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtAMOUNT_OVER = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtAMOUNT_SHORT = New System.Windows.Forms.TextBox()
        Me.TxtGOODS_CHA = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtTALLY_AMOUNT = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTADD
        '
        Me.BTADD.Location = New System.Drawing.Point(108, 174)
        Me.BTADD.Name = "BTADD"
        Me.BTADD.Size = New System.Drawing.Size(65, 24)
        Me.BTADD.TabIndex = 83
        Me.BTADD.Text = "清空"
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(254, 174)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 82
        Me.BTQUIT.Text = "取消"
        '
        'BTOK
        '
        Me.BTOK.Location = New System.Drawing.Point(182, 174)
        Me.BTOK.Name = "BTOK"
        Me.BTOK.Size = New System.Drawing.Size(65, 24)
        Me.BTOK.TabIndex = 81
        Me.BTOK.Text = "确认"
        '
        'CombCODE_GOODS
        '
        Me.CombCODE_GOODS.Location = New System.Drawing.Point(96, 90)
        Me.CombCODE_GOODS.Name = "CombCODE_GOODS"
        Me.CombCODE_GOODS.Size = New System.Drawing.Size(112, 20)
        Me.CombCODE_GOODS.TabIndex = 80
        '
        'TxtAMOUNT_ASSORT
        '
        Me.TxtAMOUNT_ASSORT.Location = New System.Drawing.Point(282, 62)
        Me.TxtAMOUNT_ASSORT.Name = "TxtAMOUNT_ASSORT"
        Me.TxtAMOUNT_ASSORT.Size = New System.Drawing.Size(110, 21)
        Me.TxtAMOUNT_ASSORT.TabIndex = 79
        Me.TxtAMOUNT_ASSORT.Text = ""
        '
        'TxtMARK
        '
        Me.TxtMARK.Location = New System.Drawing.Point(96, 64)
        Me.TxtMARK.Name = "TxtMARK"
        Me.TxtMARK.Size = New System.Drawing.Size(112, 21)
        Me.TxtMARK.TabIndex = 78
        Me.TxtMARK.Text = ""
        '
        'TxtAMOUNT
        '
        Me.TxtAMOUNT.Location = New System.Drawing.Point(282, 12)
        Me.TxtAMOUNT.Name = "TxtAMOUNT"
        Me.TxtAMOUNT.Size = New System.Drawing.Size(110, 21)
        Me.TxtAMOUNT.TabIndex = 77
        Me.TxtAMOUNT.Text = ""
        '
        'TxtBLNO
        '
        Me.TxtBLNO.Location = New System.Drawing.Point(96, 38)
        Me.TxtBLNO.Name = "TxtBLNO"
        Me.TxtBLNO.Size = New System.Drawing.Size(112, 21)
        Me.TxtBLNO.TabIndex = 76
        Me.TxtBLNO.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(212, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "分标志件数"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(212, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "舱单件数"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "货名"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "标志"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "提单号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtNO
        '
        Me.TxtNO.Location = New System.Drawing.Point(96, 12)
        Me.TxtNO.MaxLength = 10
        Me.TxtNO.Name = "TxtNO"
        Me.TxtNO.Size = New System.Drawing.Size(112, 21)
        Me.TxtNO.TabIndex = 85
        Me.TxtNO.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(10, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "编号"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CombCODE_PACK
        '
        Me.CombCODE_PACK.Location = New System.Drawing.Point(96, 140)
        Me.CombCODE_PACK.Name = "CombCODE_PACK"
        Me.CombCODE_PACK.Size = New System.Drawing.Size(112, 20)
        Me.CombCODE_PACK.TabIndex = 87
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(10, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 20)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "舱单包装"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CombPACK_ASSORT
        '
        Me.CombPACK_ASSORT.Location = New System.Drawing.Point(282, 88)
        Me.CombPACK_ASSORT.Name = "CombPACK_ASSORT"
        Me.CombPACK_ASSORT.Size = New System.Drawing.Size(110, 20)
        Me.CombPACK_ASSORT.TabIndex = 89
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(212, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 20)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "分标志包装"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtAMOUNT_OVER
        '
        Me.TxtAMOUNT_OVER.Enabled = False
        Me.TxtAMOUNT_OVER.Location = New System.Drawing.Point(282, 114)
        Me.TxtAMOUNT_OVER.Name = "TxtAMOUNT_OVER"
        Me.TxtAMOUNT_OVER.Size = New System.Drawing.Size(110, 21)
        Me.TxtAMOUNT_OVER.TabIndex = 90
        Me.TxtAMOUNT_OVER.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(212, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 20)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "溢件数"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(212, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 20)
        Me.Label10.TabIndex = 92
        Me.Label10.Text = "短件数"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtAMOUNT_SHORT
        '
        Me.TxtAMOUNT_SHORT.Enabled = False
        Me.TxtAMOUNT_SHORT.Location = New System.Drawing.Point(282, 140)
        Me.TxtAMOUNT_SHORT.Name = "TxtAMOUNT_SHORT"
        Me.TxtAMOUNT_SHORT.Size = New System.Drawing.Size(110, 21)
        Me.TxtAMOUNT_SHORT.TabIndex = 93
        Me.TxtAMOUNT_SHORT.Text = ""
        '
        'TxtGOODS_CHA
        '
        Me.TxtGOODS_CHA.Location = New System.Drawing.Point(96, 114)
        Me.TxtGOODS_CHA.MaxLength = 30
        Me.TxtGOODS_CHA.Name = "TxtGOODS_CHA"
        Me.TxtGOODS_CHA.Size = New System.Drawing.Size(112, 21)
        Me.TxtGOODS_CHA.TabIndex = 95
        Me.TxtGOODS_CHA.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(10, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 20)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "货物中文描述"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTALLY_AMOUNT
        '
        Me.TxtTALLY_AMOUNT.Location = New System.Drawing.Point(282, 36)
        Me.TxtTALLY_AMOUNT.Name = "TxtTALLY_AMOUNT"
        Me.TxtTALLY_AMOUNT.Size = New System.Drawing.Size(110, 21)
        Me.TxtTALLY_AMOUNT.TabIndex = 97
        Me.TxtTALLY_AMOUNT.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(212, 38)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 20)
        Me.Label12.TabIndex = 96
        Me.Label12.Text = "理货件数"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCARGO_MARKS_ASSORTING_ADD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(402, 211)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TxtTALLY_AMOUNT, Me.Label12, Me.TxtGOODS_CHA, Me.Label11, Me.TxtAMOUNT_SHORT, Me.Label10, Me.Label9, Me.TxtAMOUNT_OVER, Me.CombPACK_ASSORT, Me.Label8, Me.CombCODE_PACK, Me.Label7, Me.TxtNO, Me.Label6, Me.BTADD, Me.BTQUIT, Me.BTOK, Me.CombCODE_GOODS, Me.TxtAMOUNT_ASSORT, Me.TxtMARK, Me.TxtAMOUNT, Me.TxtBLNO, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCARGO_MARKS_ASSORTING_ADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "分标志_增加"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCARGO_MARKS_ASSORTING_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        dw = Getdata("select CODE,GOODS from codegoods order by code ", dsgoods)
        CombCODE_GOODS.DataSource = dsgoods.Tables(0).DefaultView
        CombCODE_GOODS.DisplayMember = "GOODS"
        CombCODE_GOODS.ValueMember = "CODE"

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
    Private Sub BTADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTADD.Click
        TxtNO.Text = ""
        TxtBLNO.Text = ""
        TxtMARK.Text = "N/M"
        CombCODE_GOODS.SelectedValue = "0000"
        TxtAMOUNT.Text = "0"
        TxtTALLY_AMOUNT.Text = "0"
        TxtAMOUNT_ASSORT.Text = "0"
        TxtAMOUNT_OVER.Text = ""
        TxtAMOUNT_SHORT.Text = ""
        CombCODE_PACK.SelectedValue = "000"
        CombPACK_ASSORT.SelectedValue = "000"
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

                        If Len(Trim(TxtNO.Text)) > 0 Then
                            Dim dskey As New DataSet()
                            dw = Getdata("select * from CARGO_MARKS_ASSORTING where  blno='" & Trim(TxtBLNO.Text) & "' and mark='" & Trim(TxtMARK.Text) & "' and ship_id='" & Ship_ID & "' ", dskey)
                            If dskey.Tables(0).Rows.Count > 0 Then
                                MsgBox("此分标志单在数据库中已存在！")
                            Else
                                Dim row As DataRow
                                row = ds.Tables(0).NewRow
                                row("SHIP_ID") = Trim(Ship_ID)
                                row("NO") = Trim(TxtNO.Text)
                                row("BLNO") = Trim(TxtBLNO.Text)
                                row("MARK") = Trim(TxtMARK.Text)
                                row("CODE_GOODS") = IIf(Len(Trim(CombCODE_GOODS.SelectedValue)) > 0, Trim(CombCODE_GOODS.SelectedValue), "0000")
                                row("code_PACK") = IIf(Len(Trim(CombCODE_PACK.SelectedValue)) > 0, Trim(CombCODE_PACK.SelectedValue), "000")
                                row("PACK_assort") = IIf(Len(Trim(CombPACK_ASSORT.SelectedValue)) > 0, Trim(CombPACK_ASSORT.SelectedValue), "000")
                                row("AMOUNT") = Trim(TxtAMOUNT.Text)
                                row("TALLY_AMOUNT") = Trim(TxtTALLY_AMOUNT.Text)
                                row("AMOUNT_assort") = Trim(TxtAMOUNT_ASSORT.Text)
                                row("amount_over") = Trim(TxtAMOUNT_OVER.Text)
                                row("amount_short") = Trim(TxtAMOUNT_SHORT.Text)
                                row("USER_NAME") = Trim(G_User)
                                row("goods_cha") = Trim(TxtGOODS_CHA.Text)
                                ds.Tables(0).Rows.Add(row)
                                sqlda.Update(ds)
                                Call BTQUIT_Click(sender, e)
                            End If
                        Else
                            MsgBox("编号不能为空！")
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


   
    Private Sub OVER()
        Dim amount As Integer
        amount = CType(IIf(Len(Trim(TxtAMOUNT.Text)) > 0, Trim(TxtAMOUNT.Text), "0"), Integer) - CType(IIf(Len(Trim(TxtTALLY_AMOUNT.Text)) > 0, Trim(TxtTALLY_AMOUNT.Text), "0"), Integer)
        If amount > 0 Then
            TxtAMOUNT_OVER.Text = "0"
            TxtAMOUNT_SHORT.Text = CType(amount, String)
        End If
        If amount < 0 Then
            TxtAMOUNT_OVER.Text = CType(amount, String)
            TxtAMOUNT_SHORT.Text = "0"
        End If
        If amount = 0 Then
            TxtAMOUNT_OVER.Text = "0"
            TxtAMOUNT_SHORT.Text = "0"
        End If
    End Sub

    Private Sub TxtAMOUNT_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtAMOUNT.TextChanged
        Call OVER()
    End Sub

    Private Sub Txttally_AMOUNT_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTALLY_AMOUNT.TextChanged
        Call OVER()
    End Sub

    Private Sub TxtNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNO.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtBLNO.Focus()
        End If
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
    Private Sub TXTGOODS_CHA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGOODS_CHA.KeyPress
        If e.KeyChar = Chr(13) Then
            CombCODE_PACK.Focus()
        End If
    End Sub
    Private Sub CombCODE_PACK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombCODE_PACK.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtAMOUNT.Focus()
        End If
    End Sub
    Private Sub TxtAMOUNT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAMOUNT.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtTALLY_AMOUNT.Focus()
        End If
    End Sub
    Private Sub Txttally_AMOUNT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTALLY_AMOUNT.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtAMOUNT_ASSORT.Focus()
        End If
    End Sub
    Private Sub TxtAMOUNT_ASSORT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAMOUNT_ASSORT.KeyPress
        If e.KeyChar = Chr(13) Then
            CombPACK_ASSORT.Focus()
        End If
    End Sub
    Private Sub CombPACK_ASSORT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombPACK_ASSORT.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtAMOUNT_OVER.Focus()
        End If
    End Sub
    Private Sub TxtAMOUNT_OVER_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAMOUNT_OVER.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtAMOUNT_SHORT.Focus()
        End If
    End Sub
    Private Sub TxtAMOUNT_SHORT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAMOUNT_SHORT.KeyPress
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
