Imports TALLY.DBControl
Public Class FrmNationality_Add
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
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents txtENG As System.Windows.Forms.TextBox
    Friend WithEvents txtCHA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtEnglish As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.txtENG = New System.Windows.Forms.TextBox()
        Me.txtCHA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtEnglish = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(167, 92)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 106
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(99, 92)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 105
        Me.btSave.Text = "确认"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(31, 92)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(65, 24)
        Me.btAdd.TabIndex = 104
        Me.btAdd.Text = "清空"
        '
        'txtENG
        '
        Me.txtENG.Location = New System.Drawing.Point(84, 4)
        Me.txtENG.MaxLength = 4
        Me.txtENG.Name = "txtENG"
        Me.txtENG.Size = New System.Drawing.Size(176, 21)
        Me.txtENG.TabIndex = 103
        Me.txtENG.Text = ""
        '
        'txtCHA
        '
        Me.txtCHA.Location = New System.Drawing.Point(84, 32)
        Me.txtCHA.MaxLength = 20
        Me.txtCHA.Name = "txtCHA"
        Me.txtCHA.Size = New System.Drawing.Size(176, 21)
        Me.txtCHA.TabIndex = 102
        Me.txtCHA.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "国籍代码"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "国籍中文描述"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(8, 0)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(18, 21)
        Me.txtID.TabIndex = 107
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'txtEnglish
        '
        Me.txtEnglish.Location = New System.Drawing.Point(84, 60)
        Me.txtEnglish.MaxLength = 100
        Me.txtEnglish.Name = "txtEnglish"
        Me.txtEnglish.Size = New System.Drawing.Size(176, 21)
        Me.txtEnglish.TabIndex = 109
        Me.txtEnglish.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "国籍英文描述"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmNationality_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(262, 125)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtEnglish, Me.Label1, Me.btQuit, Me.btSave, Me.btAdd, Me.txtENG, Me.txtCHA, Me.Label3, Me.Label2, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNationality_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "国籍信息_增加"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen
        sqlstr = "select * from Code_Nationality where Nationality_ID=" & ID & ""

        dw = Updatedata(sqlda, sqlstr, ds)
        If dw.Count > 0 Then

            txtID.Text = ds.Tables(0).Rows(0).Item("Nationality_ID")
            txtCHA.Text = ds.Tables(0).Rows(0).Item("Nationality_Cha")
            txtENG.Text = ds.Tables(0).Rows(0).Item("Nationality_Eng")
            txtEnglish.Text = ds.Tables(0).Rows(0).Item("Nationality_English")
        End If

        txtENG.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        txtCHA.Text = ""
        txtENG.Text = ""
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            Dim dsSave As New DataSet()
            If Getdata("select * from code_Nationality where Nationality_ENG='" & Trim(txtENG.Text) & "'", dsSave).Count > 0 Then
                MsgBox("可能已存在此国籍信息,请注意检查!")
                Exit Sub
            End If
            If Len(Trim(txtENG.Text)) > 0 Then
                Dim row As DataRow
                row = ds.Tables(0).NewRow()

                row("Nationality_CHA") = Trim(txtCHA.Text)
                row("Nationality_ENG") = Trim(txtENG.Text)
                row("Nationality_English") = Trim(txtEnglish.Text)
                ds.Tables(0).Rows.Add(row)
                sqlda.Update(ds)

                Dim updatetxt As String
                updatetxt = "insert into code_nationality(nationality_eng,nationality_cha,nationality_english)values(''" & Trim(txtCHA.Text) & "'',''" & Trim(txtENG.Text) & "'',''" & Trim(txtEnglish.Text) & "'')"
                CodeOperation("code_nationality", updatetxt)

                Me.Close()
            Else
                MsgBox("国籍代码不能为空!", MsgBoxStyle.Critical, "提示")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub


    Private Sub txtCHA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCHA.KeyPress
        If e.KeyChar = Chr(13) Then
            txtENG.Focus()
        End If
    End Sub
    Private Sub txtENG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtENG.KeyPress
        If e.KeyChar = Chr(13) Then
            txtEnglish.Focus()
        End If
    End Sub
    Private Sub txtEnglish_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEnglish.KeyPress
        If e.KeyChar = Chr(13) Then
            btSave.Focus()
        End If
    End Sub
End Class
