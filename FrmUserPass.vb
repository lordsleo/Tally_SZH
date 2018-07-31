Imports TALLY.DBControl
Public Class FrmUserPass
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Txt_password As System.Windows.Forms.TextBox
    Friend WithEvents Txt_pwd As System.Windows.Forms.TextBox
    Friend WithEvents CMD_Save As System.Windows.Forms.Button
    Friend WithEvents CMD_Cance As System.Windows.Forms.Button
    Friend WithEvents txtOldPass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_password = New System.Windows.Forms.TextBox()
        Me.Txt_pwd = New System.Windows.Forms.TextBox()
        Me.CMD_Save = New System.Windows.Forms.Button()
        Me.CMD_Cance = New System.Windows.Forms.Button()
        Me.txtOldPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(36, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "新密码"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(36, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "确认新密码"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt_password
        '
        Me.Txt_password.Location = New System.Drawing.Point(118, 51)
        Me.Txt_password.MaxLength = 15
        Me.Txt_password.Name = "Txt_password"
        Me.Txt_password.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.Txt_password.Size = New System.Drawing.Size(122, 21)
        Me.Txt_password.TabIndex = 0
        Me.Txt_password.Text = ""
        '
        'Txt_pwd
        '
        Me.Txt_pwd.Location = New System.Drawing.Point(118, 88)
        Me.Txt_pwd.MaxLength = 15
        Me.Txt_pwd.Name = "Txt_pwd"
        Me.Txt_pwd.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.Txt_pwd.Size = New System.Drawing.Size(122, 21)
        Me.Txt_pwd.TabIndex = 1
        Me.Txt_pwd.Text = ""
        '
        'CMD_Save
        '
        Me.CMD_Save.BackColor = System.Drawing.Color.Transparent
        Me.CMD_Save.Location = New System.Drawing.Point(62, 130)
        Me.CMD_Save.Name = "CMD_Save"
        Me.CMD_Save.Size = New System.Drawing.Size(65, 24)
        Me.CMD_Save.TabIndex = 2
        Me.CMD_Save.Text = "确认"
        '
        'CMD_Cance
        '
        Me.CMD_Cance.BackColor = System.Drawing.Color.Transparent
        Me.CMD_Cance.Location = New System.Drawing.Point(134, 130)
        Me.CMD_Cance.Name = "CMD_Cance"
        Me.CMD_Cance.Size = New System.Drawing.Size(65, 24)
        Me.CMD_Cance.TabIndex = 3
        Me.CMD_Cance.Text = "取消"
        '
        'txtOldPass
        '
        Me.txtOldPass.Location = New System.Drawing.Point(118, 14)
        Me.txtOldPass.MaxLength = 15
        Me.txtOldPass.Name = "txtOldPass"
        Me.txtOldPass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPass.Size = New System.Drawing.Size(122, 21)
        Me.txtOldPass.TabIndex = 5
        Me.txtOldPass.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(36, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "原密码"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmUserPass
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(260, 169)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label3, Me.txtOldPass, Me.CMD_Cance, Me.CMD_Save, Me.Txt_pwd, Me.Txt_password, Me.Label2, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUserPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "系统管理——密码修改"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CMD_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_Save.Click
        Dim sqlstr As String
        Dim ds As New DataSet()
        Dim dw As New DataView()
        'MsgBox(G_User_Serial)
        Try
            If Trim(Me.Txt_password.Text) = Trim(Me.Txt_pwd.Text) Then
                sqlstr = "select * from SYSTEM_USER_TABLE where Dept_Code='" & Trim(G_DeptCode) & "' and  SERIAL_NAM='" & G_User_Serial & "' and Password='" & txtOldPass.Text & "'"
                dw = Getdata(sqlstr, ds)
                If dw.Count = 1 Then
                    sqlstr = "update SYSTEM_USER_TABLE set password ='" & Me.Txt_password.Text & "' where Dept_Code='" & Trim(G_DeptCode) & "' and  SERIAL_NAM='" & G_User_Serial & "'"
                    ExecSql(sqlstr)
                    MsgBox("密码修改成功！")
                    Me.Close()
                Else
                    MsgBox("旧密码不正确！")
                End If
            Else
                MsgBox("两次输入新密码不一样，请重新输入！")
                Me.Txt_password.Text = ""
                Me.Txt_pwd.Text = ""
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly)
        End Try

    End Sub

    Private Sub CMD_Cance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_Cance.Click
        Me.Close()
    End Sub

    Private Sub Txt_password_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Txt_pwd.Focus()
        End If
    End Sub

    Private Sub Txt_pwd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_pwd.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.CMD_Save.Focus()
            Call Me.CMD_Save_Click(sender, e)
        End If
    End Sub

    Private Sub FrmUserPass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "当前用户—" & G_User & "—密码修改"
    End Sub
End Class
