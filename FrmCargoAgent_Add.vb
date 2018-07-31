Imports TALLY.DBControl
Public Class FrmCargoAgent_Add
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
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
    Friend WithEvents txtAccount As System.Windows.Forms.TextBox
    Friend WithEvents txtLinkMan As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBank As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEMail As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtENG As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCHA As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtShort As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtAccount = New System.Windows.Forms.TextBox()
        Me.txtLinkMan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBank = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEMail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtENG = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCHA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtShort = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAccount
        '
        Me.txtAccount.Location = New System.Drawing.Point(296, 90)
        Me.txtAccount.MaxLength = 40
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(178, 21)
        Me.txtAccount.TabIndex = 146
        Me.txtAccount.Text = ""
        '
        'txtLinkMan
        '
        Me.txtLinkMan.Location = New System.Drawing.Point(296, 118)
        Me.txtLinkMan.MaxLength = 10
        Me.txtLinkMan.Name = "txtLinkMan"
        Me.txtLinkMan.Size = New System.Drawing.Size(178, 21)
        Me.txtLinkMan.TabIndex = 145
        Me.txtLinkMan.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(244, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 18)
        Me.Label6.TabIndex = 144
        Me.Label6.Text = "联系人"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(244, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 18)
        Me.Label7.TabIndex = 143
        Me.Label7.Text = "帐号"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBank
        '
        Me.txtBank.Location = New System.Drawing.Point(296, 60)
        Me.txtBank.MaxLength = 40
        Me.txtBank.Name = "txtBank"
        Me.txtBank.Size = New System.Drawing.Size(178, 21)
        Me.txtBank.TabIndex = 142
        Me.txtBank.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(244, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 18)
        Me.Label8.TabIndex = 141
        Me.Label8.Text = "开户行"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEMail
        '
        Me.txtEMail.Location = New System.Drawing.Point(296, 30)
        Me.txtEMail.MaxLength = 40
        Me.txtEMail.Name = "txtEMail"
        Me.txtEMail.Size = New System.Drawing.Size(178, 21)
        Me.txtEMail.TabIndex = 140
        Me.txtEMail.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(244, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 18)
        Me.Label9.TabIndex = 139
        Me.Label9.Text = "E_MAIL"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(296, 2)
        Me.txtFax.MaxLength = 20
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(178, 21)
        Me.txtFax.TabIndex = 138
        Me.txtFax.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(244, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 18)
        Me.Label10.TabIndex = 137
        Me.Label10.Text = "传真"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(62, 90)
        Me.txtAddress.MaxLength = 40
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(178, 21)
        Me.txtAddress.TabIndex = 136
        Me.txtAddress.Text = ""
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(274, 178)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 134
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(206, 178)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 133
        Me.btSave.Text = "确认"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(138, 178)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(65, 24)
        Me.btAdd.TabIndex = 132
        Me.btAdd.Text = "清空"
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(62, 118)
        Me.txtTelephone.MaxLength = 40
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(178, 21)
        Me.txtTelephone.TabIndex = 131
        Me.txtTelephone.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(2, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 18)
        Me.Label5.TabIndex = 130
        Me.Label5.Text = "电话"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(2, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 18)
        Me.Label4.TabIndex = 129
        Me.Label4.Text = "地址"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtENG
        '
        Me.txtENG.Location = New System.Drawing.Point(62, 60)
        Me.txtENG.MaxLength = 40
        Me.txtENG.Name = "txtENG"
        Me.txtENG.Size = New System.Drawing.Size(178, 21)
        Me.txtENG.TabIndex = 128
        Me.txtENG.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 18)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "英文名称"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCHA
        '
        Me.txtCHA.Location = New System.Drawing.Point(62, 30)
        Me.txtCHA.MaxLength = 40
        Me.txtCHA.Name = "txtCHA"
        Me.txtCHA.Size = New System.Drawing.Size(178, 21)
        Me.txtCHA.TabIndex = 126
        Me.txtCHA.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "中文名称"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(62, 2)
        Me.txtCode.MaxLength = 2
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(178, 21)
        Me.txtCode.TabIndex = 124
        Me.txtCode.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 18)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "代码"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 135
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'txtShort
        '
        Me.txtShort.Location = New System.Drawing.Point(62, 146)
        Me.txtShort.Name = "txtShort"
        Me.txtShort.Size = New System.Drawing.Size(178, 21)
        Me.txtShort.TabIndex = 152
        Me.txtShort.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(2, 146)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 22)
        Me.Label11.TabIndex = 151
        Me.Label11.Text = "简称"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCargoAgent_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(476, 207)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtShort, Me.Label11, Me.txtAccount, Me.txtLinkMan, Me.Label6, Me.Label7, Me.txtBank, Me.Label8, Me.txtEMail, Me.Label9, Me.txtFax, Me.Label10, Me.txtAddress, Me.btQuit, Me.btSave, Me.btAdd, Me.txtTelephone, Me.Label5, Me.Label4, Me.txtENG, Me.Label3, Me.txtCHA, Me.Label2, Me.txtCode, Me.Label1, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargoAgent_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "货物代理信息_增加"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        If e.KeyChar = Chr(13) Then
            txtCHA.Focus()
        End If
    End Sub
    Private Sub txtCHA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCHA.KeyPress
        If e.KeyChar = Chr(13) Then
            txtENG.Focus()
        End If
    End Sub
    Private Sub txtENG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtENG.KeyPress
        If e.KeyChar = Chr(13) Then
            txtAddress.Focus()
        End If
    End Sub

    Private Sub txtAddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAddress.KeyPress
        If e.KeyChar = Chr(13) Then
            txtTelephone.Focus()
        End If
    End Sub

    Private Sub txtTelephone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelephone.KeyPress
        If e.KeyChar = Chr(13) Then
            txtShort.Focus()
        End If
    End Sub

    Private Sub txtShort_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtShort.KeyPress
        If e.KeyChar = Chr(13) Then
            txtFax.Focus()
        End If
    End Sub

    Private Sub txtFax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFax.KeyPress
        If e.KeyChar = Chr(13) Then
            txtEMail.Focus()
        End If
    End Sub

    Private Sub txtEMail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEMail.KeyPress
        If e.KeyChar = Chr(13) Then
            txtBank.Focus()
        End If
    End Sub

    Private Sub txtBank_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBank.KeyPress
        If e.KeyChar = Chr(13) Then
            txtAccount.Focus()
        End If
    End Sub

    Private Sub txtAccount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAccount.KeyPress
        If e.KeyChar = Chr(13) Then
            txtLinkMan.Focus()
        End If
    End Sub

    Private Sub txtLink_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLinkMan.KeyPress
        If e.KeyChar = Chr(13) Then
            btSave.Focus()
        End If
    End Sub

    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen

        sqlstr = "select * from Code_Cargo_Agent where Cargo_Agent_ID=" & ID & ""

        dw = Updatedata(sqlda, sqlstr, ds)
        If dw.Count > 0 Then

            txtID.Text = ds.Tables(0).Rows(0).Item("Cargo_Agent_ID")
            txtCode.Text = ds.Tables(0).Rows(0).Item("Code_Cargo_Agent")
            txtCHA.Text = ds.Tables(0).Rows(0).Item("CargoAGENT_CHA")
            txtENG.Text = ds.Tables(0).Rows(0).Item("CargoAGENT_Eng")
            txtAddress.Text = ds.Tables(0).Rows(0).Item("ADDRESS")
            txtTelephone.Text = ds.Tables(0).Rows(0).Item("TELEPHONE")
            txtFax.Text = ds.Tables(0).Rows(0).Item("FAX")
            txtEMail.Text = ds.Tables(0).Rows(0).Item("E_MAIL")
            txtBank.Text = ds.Tables(0).Rows(0).Item("BANK_OPEN")
            txtAccount.Text = ds.Tables(0).Rows(0).Item("ACCOUNT")
            txtLinkMan.Text = ds.Tables(0).Rows(0).Item("LINKMAN")
            txtShort.Text = ds.Tables(0).Rows(0).Item("CARGOAGENT_SHORT")
        End If

        txtCode.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        txtCHA.Text = ""
        txtENG.Text = ""
        txtAddress.Text = ""
        txtTelephone.Text = ""
        txtFax.Text = ""
        txtCode.Text = ""
        txtEMail.Text = ""
        txtBank.Text = ""
        txtAccount.Text = ""
        txtLinkMan.Text = ""
        txtShort.Text = ""
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            Dim dsSave As New DataSet()
            If Getdata("select * from CODE_CARGO_AGENT where CODE_CARGO_AGENT='" & Trim(txtCode.Text) & "'", dsSave).Count > 0 Then
                MsgBox("可能已存在此货物代理信息,请注意检查!")
                Exit Sub
            End If
            If Len(Trim(txtCode.Text)) > 0 And Len(Trim(txtCHA.Text)) > 0 Then
                Dim row As DataRow
                row = ds.Tables(0).NewRow()

                row("CODE_Cargo_AGENT") = Trim(txtCode.Text)
                row("CargoAGENT_CHA") = Trim(txtCHA.Text)
                row("CargoAGENT_ENG") = Trim(txtENG.Text)
                row("ADDRESS") = Trim(txtAddress.Text)
                row("TELEPHONE") = Trim(txtTelephone.Text)
                row("FAX") = Trim(txtFax.Text)
                row("E_MAIL") = Trim(txtEMail.Text)
                row("BANK_OPEN") = Trim(txtBank.Text)
                row("ACCOUNT") = Trim(txtAccount.Text)
                row("LINKMAN") = Trim(txtLinkMan.Text)
                row("CARGOAGENT_SHORT") = Trim(txtShort.Text)
                row("User_Name") = Trim(G_User)

                ds.Tables(0).Rows.Add(row)
                sqlda.Update(ds)
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
