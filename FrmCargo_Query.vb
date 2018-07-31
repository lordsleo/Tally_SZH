Imports TALLY.DBControl
Public Class FrmCargo_Query
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
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
    Friend WithEvents txtCargo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtGoods As System.Windows.Forms.ComboBox
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents txtShort As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtENG As System.Windows.Forms.TextBox
    Friend WithEvents txtCHA As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtCargo = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtGoods = New System.Windows.Forms.ComboBox
        Me.btQuit = New System.Windows.Forms.Button
        Me.txtShort = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtENG = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCHA = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(86, 94)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(232, 20)
        Me.txtCargo.TabIndex = 160
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(10, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 159
        Me.Label6.Text = "理货货类"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGoods
        '
        Me.txtGoods.Location = New System.Drawing.Point(86, 72)
        Me.txtGoods.Name = "txtGoods"
        Me.txtGoods.Size = New System.Drawing.Size(232, 20)
        Me.txtGoods.TabIndex = 158
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(129, 142)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 156
        Me.btQuit.Text = "返回"
        '
        'txtShort
        '
        Me.txtShort.Location = New System.Drawing.Point(86, 116)
        Me.txtShort.MaxLength = 4
        Me.txtShort.Name = "txtShort"
        Me.txtShort.Size = New System.Drawing.Size(232, 21)
        Me.txtShort.TabIndex = 154
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 152
        Me.Label4.Text = "计费货类"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtENG
        '
        Me.txtENG.Location = New System.Drawing.Point(86, 48)
        Me.txtENG.MaxLength = 30
        Me.txtENG.Name = "txtENG"
        Me.txtENG.Size = New System.Drawing.Size(232, 21)
        Me.txtENG.TabIndex = 151
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "货物英文描述"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCHA
        '
        Me.txtCHA.Location = New System.Drawing.Point(86, 24)
        Me.txtCHA.MaxLength = 30
        Me.txtCHA.Name = "txtCHA"
        Me.txtCHA.Size = New System.Drawing.Size(232, 21)
        Me.txtCHA.TabIndex = 149
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 148
        Me.Label2.Text = "货物中文描述"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.Enabled = False
        Me.txtCode.Location = New System.Drawing.Point(86, 0)
        Me.txtCode.MaxLength = 12
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(232, 21)
        Me.txtCode.TabIndex = 147
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 18)
        Me.Label1.TabIndex = 146
        Me.Label1.Text = "货物代码"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(4, 0)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 157
        Me.txtID.Visible = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(10, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 18)
        Me.Label5.TabIndex = 161
        Me.Label5.Text = "重点货种"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCargo_Query
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(322, 171)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCargo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtGoods)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.txtShort)
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
        Me.Name = "FrmCargo_Query"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "货物代码_查看"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim ds1 As New DataSet()
        Dim ds2 As New DataSet()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen

        sqlstr = "select Code_Goods_Type,Goods_Type from Code_Goods_Type Order by Code_Goods_Type"
        dw = Getdata(sqlstr, ds1)
        txtGoods.DataSource = ds1.Tables(0).DefaultView
        txtGoods.DisplayMember = "Goods_Type"
        txtGoods.ValueMember = "Code_Goods_Type"

        sqlstr = "select Code_Cargo_Type,Cargo_Type from Code_Cargo_Type Order by convert(int,Code_Cargo_Type)"
        dw = Getdata(sqlstr, ds2)
        txtCargo.DataSource = ds2.Tables(0).DefaultView
        txtCargo.DisplayMember = "Cargo_Type"
        txtCargo.ValueMember = "Code_Cargo_Type"

        sqlstr = "select * from codegoods where ID=" & ID & ""

        dw = Updatedata(sqlda, sqlstr, ds)
        If dw.Count > 0 Then

            txtID.Text = ds.Tables(0).Rows(0).Item("ID")
            txtCode.Text = ds.Tables(0).Rows(0).Item("Code")
            txtCHA.Text = ds.Tables(0).Rows(0).Item("Goods")
            txtENG.Text = ds.Tables(0).Rows(0).Item("Goods_ENG")
            txtGoods.SelectedValue = ds.Tables(0).Rows(0).Item("Code_Goods_Type")
            txtCargo.SelectedValue = ds.Tables(0).Rows(0).Item("Code_Cargo_Type")
            txtShort.Text = ds.Tables(0).Rows(0).Item("Goods_Short")
        End If


        txtCode.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
