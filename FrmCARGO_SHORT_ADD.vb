Imports TALLY.DBControl
Public Class FrmCARGO_SHORT_ADD
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dw As New DataView()
    Dim dsgoods As New DataSet()
    Dim dsclerk As New DataSet
    Dim dss As New DataSet


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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BTADD As System.Windows.Forms.Button
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents BTOK As System.Windows.Forms.Button
    Friend WithEvents TxtBLNO As System.Windows.Forms.TextBox
    Friend WithEvents TxtMARK As System.Windows.Forms.TextBox
    Friend WithEvents CombCODE_GOODS As System.Windows.Forms.ComboBox
    Friend WithEvents TxtHATCH_PACK As System.Windows.Forms.TextBox
    Friend WithEvents TxtTALLY_AMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents CombWORK_NO As System.Windows.Forms.ComboBox
    Friend WithEvents TxtOVERSHORT_REMARK As System.Windows.Forms.TextBox
    Friend WithEvents TxtAMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtGOODS_CHA As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtBLNO = New System.Windows.Forms.TextBox()
        Me.TxtHATCH_PACK = New System.Windows.Forms.TextBox()
        Me.TxtMARK = New System.Windows.Forms.TextBox()
        Me.TxtTALLY_AMOUNT = New System.Windows.Forms.TextBox()
        Me.CombCODE_GOODS = New System.Windows.Forms.ComboBox()
        Me.CombWORK_NO = New System.Windows.Forms.ComboBox()
        Me.BTADD = New System.Windows.Forms.Button()
        Me.BTQUIT = New System.Windows.Forms.Button()
        Me.BTOK = New System.Windows.Forms.Button()
        Me.TxtOVERSHORT_REMARK = New System.Windows.Forms.TextBox()
        Me.TxtAMOUNT = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtGOODS_CHA = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "提单号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "标志"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "货名"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(212, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "舱单件数"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(212, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "理货件数"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(212, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "溢短标志"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(212, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "理货组长"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtBLNO
        '
        Me.TxtBLNO.Location = New System.Drawing.Point(94, 8)
        Me.TxtBLNO.Name = "TxtBLNO"
        Me.TxtBLNO.Size = New System.Drawing.Size(112, 21)
        Me.TxtBLNO.TabIndex = 7
        Me.TxtBLNO.Text = ""
        '
        'TxtHATCH_PACK
        '
        Me.TxtHATCH_PACK.Location = New System.Drawing.Point(270, 6)
        Me.TxtHATCH_PACK.Name = "TxtHATCH_PACK"
        Me.TxtHATCH_PACK.Size = New System.Drawing.Size(112, 21)
        Me.TxtHATCH_PACK.TabIndex = 8
        Me.TxtHATCH_PACK.Text = ""
        '
        'TxtMARK
        '
        Me.TxtMARK.Location = New System.Drawing.Point(94, 34)
        Me.TxtMARK.Name = "TxtMARK"
        Me.TxtMARK.Size = New System.Drawing.Size(112, 21)
        Me.TxtMARK.TabIndex = 9
        Me.TxtMARK.Text = ""
        '
        'TxtTALLY_AMOUNT
        '
        Me.TxtTALLY_AMOUNT.Location = New System.Drawing.Point(270, 30)
        Me.TxtTALLY_AMOUNT.Name = "TxtTALLY_AMOUNT"
        Me.TxtTALLY_AMOUNT.Size = New System.Drawing.Size(112, 21)
        Me.TxtTALLY_AMOUNT.TabIndex = 10
        Me.TxtTALLY_AMOUNT.Text = ""
        '
        'CombCODE_GOODS
        '
        Me.CombCODE_GOODS.Location = New System.Drawing.Point(94, 60)
        Me.CombCODE_GOODS.Name = "CombCODE_GOODS"
        Me.CombCODE_GOODS.Size = New System.Drawing.Size(112, 20)
        Me.CombCODE_GOODS.TabIndex = 11
        '
        'CombWORK_NO
        '
        Me.CombWORK_NO.Location = New System.Drawing.Point(270, 104)
        Me.CombWORK_NO.Name = "CombWORK_NO"
        Me.CombWORK_NO.Size = New System.Drawing.Size(112, 20)
        Me.CombWORK_NO.TabIndex = 13
        '
        'BTADD
        '
        Me.BTADD.Location = New System.Drawing.Point(110, 138)
        Me.BTADD.Name = "BTADD"
        Me.BTADD.Size = New System.Drawing.Size(65, 24)
        Me.BTADD.TabIndex = 70
        Me.BTADD.Text = "清空"
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(256, 138)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 69
        Me.BTQUIT.Text = "取消"
        '
        'BTOK
        '
        Me.BTOK.Location = New System.Drawing.Point(184, 138)
        Me.BTOK.Name = "BTOK"
        Me.BTOK.Size = New System.Drawing.Size(65, 24)
        Me.BTOK.TabIndex = 68
        Me.BTOK.Text = "确认"
        '
        'TxtOVERSHORT_REMARK
        '
        Me.TxtOVERSHORT_REMARK.Enabled = False
        Me.TxtOVERSHORT_REMARK.Location = New System.Drawing.Point(270, 54)
        Me.TxtOVERSHORT_REMARK.Name = "TxtOVERSHORT_REMARK"
        Me.TxtOVERSHORT_REMARK.Size = New System.Drawing.Size(112, 21)
        Me.TxtOVERSHORT_REMARK.TabIndex = 71
        Me.TxtOVERSHORT_REMARK.Text = ""
        '
        'TxtAMOUNT
        '
        Me.TxtAMOUNT.Enabled = False
        Me.TxtAMOUNT.Location = New System.Drawing.Point(270, 78)
        Me.TxtAMOUNT.Name = "TxtAMOUNT"
        Me.TxtAMOUNT.Size = New System.Drawing.Size(112, 21)
        Me.TxtAMOUNT.TabIndex = 73
        Me.TxtAMOUNT.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(212, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 20)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "数量"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtGOODS_CHA
        '
        Me.TxtGOODS_CHA.Location = New System.Drawing.Point(94, 84)
        Me.TxtGOODS_CHA.MaxLength = 30
        Me.TxtGOODS_CHA.Name = "TxtGOODS_CHA"
        Me.TxtGOODS_CHA.Size = New System.Drawing.Size(112, 21)
        Me.TxtGOODS_CHA.TabIndex = 75
        Me.TxtGOODS_CHA.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 20)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "货物中文描述"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCARGO_SHORT_ADD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(394, 175)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TxtGOODS_CHA, Me.Label9, Me.TxtAMOUNT, Me.Label8, Me.TxtOVERSHORT_REMARK, Me.BTADD, Me.BTQUIT, Me.BTOK, Me.CombWORK_NO, Me.CombCODE_GOODS, Me.TxtTALLY_AMOUNT, Me.TxtMARK, Me.TxtHATCH_PACK, Me.TxtBLNO, Me.Label7, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCARGO_SHORT_ADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "溢短单_增加"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCARGO_SHORT_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        dw = Getdata("select CODE,GOODS from codegoods order by code ", dsgoods)
        CombCODE_GOODS.DataSource = dsgoods.Tables(0).DefaultView
        CombCODE_GOODS.DisplayMember = "GOODS"
        CombCODE_GOODS.ValueMember = "CODE"

        dw = Getdata("select work_no,name from TALLY_CLERK order by name", dsclerk)
        CombWORK_NO.DataSource = dsclerk.Tables(0).DefaultView
        CombWORK_NO.DisplayMember = "name"
        CombWORK_NO.ValueMember = "work_no"
        'Call WORK_NO()

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
        Else
            CombWORK_NO.SelectedValue = ""
        End If

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub BTADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTADD.Click
        TxtBLNO.Text = ""
        TxtMARK.Text = "N/M"
        CombCODE_GOODS.SelectedValue = "0000"
        TxtHATCH_PACK.Text = "0"
        TxtTALLY_AMOUNT.Text = "0"
        TxtOVERSHORT_REMARK.Text = ""
        TxtAMOUNT.Text = "0"
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

                        If Len(Trim(TxtOVERSHORT_REMARK.Text)) > 0 Then
                            Dim dskey As New DataSet()
                            dw = Getdata("select * from cargo_short where  blno='" & Trim(TxtBLNO.Text) & "' and mark='" & Trim(TxtMARK.Text) & "' and ship_id='" & Ship_ID & "' ", dskey)
                            If dskey.Tables(0).Rows.Count > 0 Then
                                MsgBox("此溢短单在数据库中已存在！")
                            Else
                                Dim row As DataRow
                                row = ds.Tables(0).NewRow
                                row("SHIP_ID") = Trim(Ship_ID)
                                row("BLNO") = Trim(TxtBLNO.Text)
                                row("MARK") = Trim(TxtMARK.Text)
                                row("CODE_GOODS") = IIf(Len(Trim(CombCODE_GOODS.SelectedValue)) > 0, Trim(CombCODE_GOODS.SelectedValue), "0000")
                                row("HATCH_PACK") = Trim(TxtHATCH_PACK.Text)
                                row("TALLY_AMOUNT") = Trim(TxtTALLY_AMOUNT.Text)
                                row("OVERSHORT_REMARK") = Trim(TxtOVERSHORT_REMARK.Text)
                                row("WORK_NO") = IIf(Len(Trim(CombWORK_NO.SelectedValue)) > 0, Trim(CombWORK_NO.SelectedValue), "")
                                row("USER_NAME") = Trim(G_User)
                                row("amount") = Trim(TxtAMOUNT.Text)
                                row("goods_cha") = Trim(TxtGOODS_CHA.Text)
                                ds.Tables(0).Rows.Add(row)
                                sqlda.Update(ds)
                                Call BTQUIT_Click(sender, e)
                            End If
                        Else
                            MsgBox("舱单件数与理货件数相等！没有溢短！")
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


    Private Sub TxtHATCH_PACK_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtHATCH_PACK.TextChanged
        Call OVER()
    End Sub

    Private Sub TxtTALLY_AMOUNT_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTALLY_AMOUNT.TextChanged
        Call OVER()
    End Sub
    Private Sub OVER()
        Dim amount As Integer
        amount = CType(IIf(Len(Trim(TxtHATCH_PACK.Text)) > 0, Trim(TxtHATCH_PACK.Text), "0"), Integer) - CType(IIf(Len(Trim(TxtTALLY_AMOUNT.Text)) > 0, Trim(TxtTALLY_AMOUNT.Text), "0"), Integer)
        If amount > 0 Then
            TxtOVERSHORT_REMARK.Text = "短卸"
            TxtAMOUNT.Text = amount
        End If
        If amount < 0 Then
            TxtOVERSHORT_REMARK.Text = "溢卸"
            TxtAMOUNT.Text = 0 - amount
        End If
        If amount = 0 Then
            TxtOVERSHORT_REMARK.Text = ""
            TxtAMOUNT.Text = "0"

        End If
    End Sub

    'Private Sub CombWORK_NO_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CombWORK_NO.MouseDown
    '    Call WORK_NO()
    'End Sub

    'Private Sub CombWORK_NO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CombWORK_NO.KeyDown
    '    Call WORK_NO()
    'End Sub
    Private Sub WORK_NO()
        dw = Getdata("select work_no,name from view_work_no where ship_id='" & Ship_ID & "'", dsclerk)
        CombWORK_NO.DataSource = dsclerk.Tables(0).DefaultView
        CombWORK_NO.DisplayMember = "name"
        CombWORK_NO.ValueMember = "work_no"
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
            TxtHATCH_PACK.Focus()
        End If
    End Sub
    Private Sub TxtHATCH_PACK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtHATCH_PACK.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtTALLY_AMOUNT.Focus()
        End If
    End Sub
    Private Sub TxtTALLY_AMOUNT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTALLY_AMOUNT.KeyPress
        If e.KeyChar = Chr(13) Then
            CombWORK_NO.Focus()
        End If
    End Sub
    Private Sub CombWORK_NO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombWORK_NO.KeyPress
        If e.KeyChar = Chr(13) Then
            BTOK.Focus()
        End If
    End Sub

    Private Sub CombWORK_NO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CombWORK_NO.Leave
        Dim str As String

        If CombWORK_NO.Text.Trim().Length > 0 Then
            If (Asc(Mid(CombWORK_NO.Text.Trim(), 1, 1)) >= Asc("a") And Asc(Mid(CombWORK_NO.Text.Trim(), 1, 1)) <= Asc("z")) Or (Asc(Mid(CombWORK_NO.Text.Trim(), 1, 1)) >= Asc("A") And Asc(Mid(CombWORK_NO.Text.Trim(), 1, 1)) <= Asc("Z")) Then
                dss.Reset()
                str = "SELECT NAME, WORK_NO,Tally_Short FROM TALLY_CLERK where Tally_Short='" & CombWORK_NO.Text.Trim() & "'  order by NAME"
                dw = Getdata(str, dss)
                If dw.Count > 0 Then
                    'CombTALLY_CLERK1.DataSource = dsclerk.Tables(0).DefaultView
                    'CombTALLY_CLERK1.DisplayMember = "NAME"
                    'CombTALLY_CLERK1.ValueMember = "WORK_NO"
                    CombWORK_NO.SelectedValue = dss.Tables(0).Rows(0)("WORK_NO")
                End If
            End If
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
