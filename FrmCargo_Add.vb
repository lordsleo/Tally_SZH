Imports TALLY.DBControl
Public Class FrmCargo_Add
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Friend WithEvents txtShort As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Dim sqlda As New SqlClient.SqlDataAdapter()
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
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtGoods As System.Windows.Forms.ComboBox
    Friend WithEvents txtShort1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCargo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtENG As System.Windows.Forms.TextBox
    Friend WithEvents txtCHA As System.Windows.Forms.TextBox
    Friend WithEvents txt_px As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtGoods = New System.Windows.Forms.ComboBox
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.btAdd = New System.Windows.Forms.Button
        Me.txtShort1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtENG = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCHA = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txtCargo = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_px = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtShort = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtGoods
        '
        Me.txtGoods.Location = New System.Drawing.Point(86, 74)
        Me.txtGoods.Name = "txtGoods"
        Me.txtGoods.Size = New System.Drawing.Size(182, 20)
        Me.txtGoods.TabIndex = 112
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(181, 176)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 110
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(113, 176)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 109
        Me.btSave.Text = "确认"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(45, 176)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(65, 24)
        Me.btAdd.TabIndex = 108
        Me.btAdd.Text = "清空"
        '
        'txtShort1
        '
        Me.txtShort1.Location = New System.Drawing.Point(4, 179)
        Me.txtShort1.MaxLength = 10
        Me.txtShort1.Name = "txtShort1"
        Me.txtShort1.Size = New System.Drawing.Size(24, 21)
        Me.txtShort1.TabIndex = 107
        Me.txtShort1.Visible = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "计费货类"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtENG
        '
        Me.txtENG.Location = New System.Drawing.Point(86, 50)
        Me.txtENG.MaxLength = 30
        Me.txtENG.Name = "txtENG"
        Me.txtENG.Size = New System.Drawing.Size(182, 21)
        Me.txtENG.TabIndex = 104
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "货物英文描述"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCHA
        '
        Me.txtCHA.Location = New System.Drawing.Point(86, 26)
        Me.txtCHA.MaxLength = 30
        Me.txtCHA.Name = "txtCHA"
        Me.txtCHA.Size = New System.Drawing.Size(182, 21)
        Me.txtCHA.TabIndex = 102
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "货物中文描述"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(86, 2)
        Me.txtCode.MaxLength = 12
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(182, 21)
        Me.txtCode.TabIndex = 100
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 18)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "货物代码"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(4, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 111
        Me.txtID.Visible = False
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(86, 96)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(182, 20)
        Me.txtCargo.TabIndex = 114
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(10, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "理货货类"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_px
        '
        Me.txt_px.Location = New System.Drawing.Point(86, 144)
        Me.txt_px.MaxLength = 4
        Me.txt_px.Name = "txt_px"
        Me.txt_px.Size = New System.Drawing.Size(182, 21)
        Me.txt_px.TabIndex = 125
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 18)
        Me.Label7.TabIndex = 124
        Me.Label7.Text = "排列顺序"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShort
        '
        Me.txtShort.Location = New System.Drawing.Point(86, 120)
        Me.txtShort.Name = "txtShort"
        Me.txtShort.Size = New System.Drawing.Size(182, 20)
        Me.txtShort.TabIndex = 126
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 18)
        Me.Label5.TabIndex = 127
        Me.Label5.Text = "重点货种"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCargo_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(290, 216)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtShort)
        Me.Controls.Add(Me.txt_px)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCargo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtGoods)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.txtShort1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtENG)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCHA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargo_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "货物代码_增加"
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
            Call btSave_Click(sender, e)
            txtCode.Focus()
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
            txtENG.Text = ds.Tables(0).Rows(0).Item("Goods_Eng")
            txtGoods.SelectedValue = ds.Tables(0).Rows(0).Item("Code_Goods_Type")
            txtCargo.SelectedValue = ds.Tables(0).Rows(0).Item("Code_Cargo_Type")
            txtShort.SelectedValue = ds.Tables(0).Rows(0).Item("Goods_Short")
            'txtShort1.Text = ds.Tables(0).Rows(0).Item("Goods_Short")
            txt_px.Text = ds.Tables(0).Rows(0).Item("Flag_Px")
        End If

        txtCode.Focus()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        txtCode.Text = ""
        txtCHA.Text = ""
        txtENG.Text = ""
        txtShort1.Text = ""
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            Dim dsSave As New DataSet()
            If Getdata("select * from Codegoods where Code='" & Trim(txtCode.Text) & "'", dsSave).Count > 0 Then
                MsgBox("可能已存在此货物代码信息,请注意检查!")
                Exit Sub
            End If
            If Len(Trim(txtCode.Text)) > 0 And Len(Trim(txtCHA.Text)) > 0 Then
                Dim row As DataRow
                row = ds.Tables(0).NewRow()

                row("Code") = Trim(txtCode.Text)
                row("Goods") = Trim(txtCHA.Text)
                row("Goods_ENG") = Trim(txtENG.Text)
                row("Code_Goods_Type") = Trim(txtGoods.SelectedValue)
                row("Code_Cargo_Type") = Trim(txtCargo.SelectedValue)
                row("Goods_Short") = Trim(txtShort.SelectedValue)
                row("Flag_Px") = txt_px.Text
                row("Flag_Type") = "1"
                row("Flag_Dept") = "1"
                'row("User_Name") = Trim(G_User)

                ds.Tables(0).Rows.Add(row)
                sqlda.Update(ds)

                Dim updatetxt As String
                updatetxt = "insert into codegoods(code,goods,goods_eng,goods_short,Code_Goods_Type,Code_Cargo_Type,Flag_Type,Flag_Dept,Flag_Px) values(''" & Trim(txtCode.Text) & "'',''" & Trim(txtCHA.Text) & "'',''" & Trim(txtENG.Text) & "'',''" & Trim(txtShort.SelectedValue) & "'',''" & Trim(txtGoods.SelectedValue) & "'',''" & Trim(txtCargo.SelectedValue) & "'',''1'',''1'',''" & Trim(txt_px.Text) & "'')"
                CodeOperation("codegoods", updatetxt)

                Me.Close()
            Else
                MsgBox("代码,名称不能为空!", MsgBoxStyle.Critical, "提示")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
