Imports TALLY.DBControl
Public Class FrmCargo_Edit
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter
    Dim txt1, txt2, txt3, txt4, txt5, txt6 As String
    Friend WithEvents txtShort As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label '检查是否真正的修改了数据
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
    Friend WithEvents txtCargo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtGoods As System.Windows.Forms.ComboBox
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btResume As System.Windows.Forms.Button
    Friend WithEvents txtShort1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtENG As System.Windows.Forms.TextBox
    Friend WithEvents txtCHA As System.Windows.Forms.TextBox
    Friend WithEvents txt_px As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtCargo = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtGoods = New System.Windows.Forms.ComboBox
        Me.btQuit = New System.Windows.Forms.Button
        Me.btResume = New System.Windows.Forms.Button
        Me.txtShort1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtENG = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCHA = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txt_px = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtShort = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(84, 98)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(218, 20)
        Me.txtCargo.TabIndex = 130
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 129
        Me.Label6.Text = "理货货类"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGoods
        '
        Me.txtGoods.Location = New System.Drawing.Point(84, 76)
        Me.txtGoods.Name = "txtGoods"
        Me.txtGoods.Size = New System.Drawing.Size(218, 20)
        Me.txtGoods.TabIndex = 128
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(169, 192)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 126
        Me.btQuit.Text = "取消"
        '
        'btResume
        '
        Me.btResume.Location = New System.Drawing.Point(89, 192)
        Me.btResume.Name = "btResume"
        Me.btResume.Size = New System.Drawing.Size(65, 24)
        Me.btResume.TabIndex = 125
        Me.btResume.Text = "确认"
        '
        'txtShort1
        '
        Me.txtShort1.Location = New System.Drawing.Point(12, 195)
        Me.txtShort1.MaxLength = 10
        Me.txtShort1.Name = "txtShort1"
        Me.txtShort1.Size = New System.Drawing.Size(37, 21)
        Me.txtShort1.TabIndex = 123
        Me.txtShort1.Visible = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "计费货类"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtENG
        '
        Me.txtENG.Location = New System.Drawing.Point(84, 52)
        Me.txtENG.MaxLength = 30
        Me.txtENG.Name = "txtENG"
        Me.txtENG.Size = New System.Drawing.Size(218, 21)
        Me.txtENG.TabIndex = 120
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "货物英文描述"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCHA
        '
        Me.txtCHA.Location = New System.Drawing.Point(84, 28)
        Me.txtCHA.MaxLength = 30
        Me.txtCHA.Name = "txtCHA"
        Me.txtCHA.Size = New System.Drawing.Size(218, 21)
        Me.txtCHA.TabIndex = 118
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "货物中文描述"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.Enabled = False
        Me.txtCode.Location = New System.Drawing.Point(84, 4)
        Me.txtCode.MaxLength = 12
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(218, 21)
        Me.txtCode.TabIndex = 116
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 18)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "货物代码"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 127
        Me.txtID.Visible = False
        '
        'txt_px
        '
        Me.txt_px.Location = New System.Drawing.Point(84, 148)
        Me.txt_px.MaxLength = 4
        Me.txt_px.Name = "txt_px"
        Me.txt_px.Size = New System.Drawing.Size(218, 21)
        Me.txt_px.TabIndex = 123
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 18)
        Me.Label7.TabIndex = 122
        Me.Label7.Text = "排列顺序"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShort
        '
        Me.txtShort.Location = New System.Drawing.Point(84, 121)
        Me.txtShort.Name = "txtShort"
        Me.txtShort.Size = New System.Drawing.Size(218, 20)
        Me.txtShort.TabIndex = 131
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 18)
        Me.Label5.TabIndex = 132
        Me.Label5.Text = "重点货种"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCargo_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(322, 240)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtShort)
        Me.Controls.Add(Me.txtCargo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtGoods)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btResume)
        Me.Controls.Add(Me.txtShort1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtENG)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCHA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txt_px)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargo_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "货物代码_编辑"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        If e.KeyChar = Chr(13) Then
            txtCHA.Focus()
        End If
    End Sub
    Private Sub txtCHA_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtENG.KeyPress
        If e.KeyChar = Chr(13) Then
            txtENG.Focus()
        End If
    End Sub
    Private Sub txtENG_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCHA.KeyPress
        If e.KeyChar = Chr(13) Then
            txtGoods.Focus()
        End If
    End Sub

    Private Sub txtGoods_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGoods.KeyPress
        If e.KeyChar = Chr(13) Then
            txtCargo.Focus()
        End If
    End Sub

    Private Sub txtCargo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCargo.KeyPress
        If e.KeyChar = Chr(13) Then
            txtCargo.Focus()
        End If
    End Sub

    Private Sub txtShort_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtShort1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call btResume_Click(sender, e)
            txtCHA.Focus()
        End If
    End Sub

    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim ds1 As New DataSet()
        Dim ds2 As New DataSet()
        Dim ds3 As New DataSet()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen

        sqlstr = "select Code_Goods_Type,Goods_Type from Code_Goods_Type Order by Code_Goods_Type"
        dw = Getdata(sqlstr, ds1)
        txtGoods.DataSource = ds1.Tables(0).DefaultView
        txtGoods.DisplayMember = "Goods_Type"
        txtGoods.ValueMember = "Code_Goods_Type"

        sqlstr = "select goods_type_code,goods_type_name from newcodegoodstype Order by sequence"
        dw = Getdata(sqlstr, ds2)
        txtCargo.DataSource = ds2.Tables(0).DefaultView
        txtCargo.DisplayMember = "goods_type_name"
        txtCargo.ValueMember = "goods_type_code"

        sqlstr = "select goodstype,goodstypename from CODEGOODS_zdhz order by px "
        dw = Getdata(sqlstr, ds3)
        txtShort.DataSource = ds3.Tables(0).DefaultView
        txtShort.DisplayMember = "goodstypename"
        txtShort.ValueMember = "goodstype"

        sqlstr = "select * from codegoods where ID=" & ID & ""

        dw = Updatedata(sqlda, sqlstr, ds)
        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("ID")
            txtCode.Text = ds.Tables(0).Rows(0).Item("Code")
            txtCHA.Text = ds.Tables(0).Rows(0).Item("Goods")
            txtENG.Text = ds.Tables(0).Rows(0).Item("Goods_ENG")
            txtGoods.SelectedValue = ds.Tables(0).Rows(0).Item("Code_Goods_Type")
            txtCargo.SelectedValue = ds.Tables(0).Rows(0).Item("Code_Cargo_Type")
            txtShort.SelectedValue = ds.Tables(0).Rows(0).Item("Goods_Short")
            'txtShort1.Text = ds.Tables(0).Rows(0).Item("Goods_Short")
            txt_px.Text = ds.Tables(0).Rows(0).Item("Flag_Px")

            txt1 = ds.Tables(0).Rows(0).Item("Goods")
            txt2 = ds.Tables(0).Rows(0).Item("Goods_ENG")
            txt3 = ds.Tables(0).Rows(0).Item("Code_Goods_Type")
            txt4 = ds.Tables(0).Rows(0).Item("Code_Cargo_Type")
            txt5 = ds.Tables(0).Rows(0).Item("Goods_Short")
            txt6 = ds.Tables(0).Rows(0).Item("Flag_Px")
        End If
        txtCode.Focus()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResume.Click
        Try
            If MsgBox("你确认要修改吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                Call OperateHistory(G_DeptName, Now, G_User, "修改", "Codegoods", Trim(txtID.Text), "ID")

                'ds.Tables(0).Rows(0).Item("Code") = txtCode.Text
                ds.Tables(0).Rows(0).Item("Goods") = Trim(txtCHA.Text)
                ds.Tables(0).Rows(0).Item("Goods_ENG") = Trim(txtENG.Text)
                ds.Tables(0).Rows(0).Item("Code_Goods_Type") = Trim(txtGoods.SelectedValue)
                ds.Tables(0).Rows(0).Item("Code_Cargo_Type") = Trim(txtCargo.SelectedValue)
                ds.Tables(0).Rows(0).Item("Goods_Short") = Trim(txtShort.SelectedValue)
                ds.Tables(0).Rows(0).Item("Flag_Px") = txt_px.Text
                ds.Tables(0).Rows(0).Item("Flag_Dept") = "1"

                If Not (txt1 = Trim(txtCHA.Text) And txt2 = Trim(txtENG.Text) And txt3 = Trim(txtGoods.SelectedValue) And txt4 = Trim(txtCargo.SelectedValue) And txt5 = Trim(txtShort.SelectedValue) And txt6 = Trim(txt_px.Text)) Then
                    Dim updatetxt As String
                    updatetxt = "update codegoods set goods=''" & Trim(txtCHA.Text) & "'',goods_eng=''" & Trim(txtENG.Text) & "'',Code_Goods_Type=''" & Trim(txtGoods.SelectedValue) & "'',Code_Cargo_Type=''" & Trim(txtCargo.SelectedValue) & "'',Goods_Short=''" & Trim(txtShort.SelectedValue) & "'',Flag_Px=''" & Trim(txt_px.Text) & "'',Flag_Dept=''1'' where code=''" & Trim(txtCode.Text) & "''"
                    CodeOperation("codegoods", updatetxt)
                End If

                sqlda.Update(ds)
                Call btQuit_Click(sender, e)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
