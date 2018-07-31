Imports TALLY.DBControl
Public Class FrmUser_Edit
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
    Friend WithEvents CMD_Cance As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DC_Part As System.Windows.Forms.ComboBox
    Friend WithEvents CMD_Save As System.Windows.Forms.Button
    Friend WithEvents Txt_SERIAL_NAM As System.Windows.Forms.TextBox
    Friend WithEvents Txt_PASSWORD As System.Windows.Forms.TextBox
    Friend WithEvents Txt_NAME As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Pwd As System.Windows.Forms.TextBox
    Friend WithEvents txtworkNo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CMD_Cance = New System.Windows.Forms.Button
        Me.CMD_Save = New System.Windows.Forms.Button
        Me.Txt_SERIAL_NAM = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Txt_PASSWORD = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Txt_NAME = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.DC_Part = New System.Windows.Forms.ComboBox
        Me.Txt_Pwd = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtworkNo = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'CMD_Cance
        '
        Me.CMD_Cance.BackColor = System.Drawing.Color.Transparent
        Me.CMD_Cance.Location = New System.Drawing.Point(112, 158)
        Me.CMD_Cance.Name = "CMD_Cance"
        Me.CMD_Cance.Size = New System.Drawing.Size(65, 24)
        Me.CMD_Cance.TabIndex = 7
        Me.CMD_Cance.Text = "取消"
        '
        'CMD_Save
        '
        Me.CMD_Save.BackColor = System.Drawing.Color.Transparent
        Me.CMD_Save.Location = New System.Drawing.Point(40, 158)
        Me.CMD_Save.Name = "CMD_Save"
        Me.CMD_Save.Size = New System.Drawing.Size(65, 24)
        Me.CMD_Save.TabIndex = 6
        Me.CMD_Save.Text = "修改"
        '
        'Txt_SERIAL_NAM
        '
        Me.Txt_SERIAL_NAM.Location = New System.Drawing.Point(86, 4)
        Me.Txt_SERIAL_NAM.MaxLength = 12
        Me.Txt_SERIAL_NAM.Name = "Txt_SERIAL_NAM"
        Me.Txt_SERIAL_NAM.Size = New System.Drawing.Size(130, 21)
        Me.Txt_SERIAL_NAM.TabIndex = 1
        Me.Txt_SERIAL_NAM.Text = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(4, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "用户登录标识"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(4, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "用户角色"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt_PASSWORD
        '
        Me.Txt_PASSWORD.Location = New System.Drawing.Point(86, 56)
        Me.Txt_PASSWORD.MaxLength = 20
        Me.Txt_PASSWORD.Name = "Txt_PASSWORD"
        Me.Txt_PASSWORD.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.Txt_PASSWORD.Size = New System.Drawing.Size(130, 21)
        Me.Txt_PASSWORD.TabIndex = 3
        Me.Txt_PASSWORD.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(4, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "用户密码"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt_NAME
        '
        Me.Txt_NAME.Location = New System.Drawing.Point(86, 30)
        Me.Txt_NAME.MaxLength = 10
        Me.Txt_NAME.Name = "Txt_NAME"
        Me.Txt_NAME.Size = New System.Drawing.Size(130, 21)
        Me.Txt_NAME.TabIndex = 2
        Me.Txt_NAME.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(4, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "用户名称"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DC_Part
        '
        Me.DC_Part.Location = New System.Drawing.Point(86, 108)
        Me.DC_Part.Name = "DC_Part"
        Me.DC_Part.Size = New System.Drawing.Size(130, 20)
        Me.DC_Part.TabIndex = 5
        '
        'Txt_Pwd
        '
        Me.Txt_Pwd.Location = New System.Drawing.Point(86, 82)
        Me.Txt_Pwd.MaxLength = 20
        Me.Txt_Pwd.Name = "Txt_Pwd"
        Me.Txt_Pwd.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Pwd.Size = New System.Drawing.Size(130, 21)
        Me.Txt_Pwd.TabIndex = 4
        Me.Txt_Pwd.Text = ""
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(4, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "确认密码"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtworkNo
        '
        Me.txtworkNo.Location = New System.Drawing.Point(86, 132)
        Me.txtworkNo.Name = "txtworkNo"
        Me.txtworkNo.Size = New System.Drawing.Size(130, 21)
        Me.txtworkNo.TabIndex = 17
        Me.txtworkNo.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(4, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 22)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "工号"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmUser_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(218, 187)
        Me.Controls.Add(Me.txtworkNo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Txt_Pwd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DC_Part)
        Me.Controls.Add(Me.CMD_Cance)
        Me.Controls.Add(Me.CMD_Save)
        Me.Controls.Add(Me.Txt_SERIAL_NAM)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txt_PASSWORD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txt_NAME)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUser_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "用户设置——用户修改"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As New DataSet()
    Dim dsw As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dv As DataView
    Dim sqlstr As String
    Private Sub FrmUser_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FillPart()
        On Error GoTo Err

        sqlstr = "select * from SYSTEM_USER_TABLE where USER_ID=" & ID & ""
        dv = DBControl.Updatedata(sqlda, sqlstr, ds)

        Me.Txt_SERIAL_NAM.Text = dv(0)("SERIAL_NAM")
        Me.Txt_NAME.Text = dv(0)("NAME")
        Me.Txt_PASSWORD.Text = dv(0)("PASSWORD")
        Me.Txt_Pwd.Text = dv(0)("PASSWORD")
        Me.DC_Part.SelectedValue = dv(0)("PART_ID")
        Me.txtworkNo.Text = dv(0)("Work_No")

Err:
        Resume Next
    End Sub

    Private Sub FillPart()
        Dim sqlP As String
        Dim dvP As DataView
        Dim dsP As New DataSet()
        sqlP = "SELECT PART_NAME, PART_ID FROM SYSTEM_PART "
        dvP = DBControl.Getdata(sqlP, dsP)
        Me.DC_Part.DataSource = dvP
        Me.DC_Part.DisplayMember = "PART_NAME"
        Me.DC_Part.ValueMember = "PART_ID"
    End Sub


    Private Sub CMD_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_Save.Click
        Try
            If MsgBox("你确认要修改吗？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If Trim(Me.Txt_PASSWORD.Text) = Trim(Me.Txt_Pwd.Text) Then
                    Call DBControl.OperateHistory(G_DeptName, Now, G_User, "修改", "SYSTEM_USER_TABLE", ID, "USER_ID")
                    dv(0)("SERIAL_NAM") = Me.Txt_SERIAL_NAM.Text
                    dv(0)("NAME") = Me.Txt_NAME.Text
                    dv(0)("PASSWORD") = Me.Txt_PASSWORD.Text
                    dv(0)("PART_ID") = Me.DC_Part.SelectedValue
                    dv(0)("Work_No") = Me.txtworkNo.Text

                    sqlda.Update(ds)
                    Me.Close()
                Else
                    MsgBox("密码不一至！请重新输入！", MsgBoxStyle.OKOnly)
                    Me.Txt_PASSWORD.Text = ""
                    Me.Txt_Pwd.Text = ""
                    Me.Txt_PASSWORD.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly)
        End Try
    End Sub

    Private Sub CMD_Cance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_Cance.Click
        Me.Close()
    End Sub
End Class
