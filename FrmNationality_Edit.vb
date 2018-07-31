Imports TALLY.DBControl
Public Class FrmNationality_Edit
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter
    Dim txt1, txt2, txt3 As String '检查是否真正的修改了数据
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
    Friend WithEvents btResume As System.Windows.Forms.Button
    Friend WithEvents txtENG As System.Windows.Forms.TextBox
    Friend WithEvents txtCHA As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtEnglish As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btResume = New System.Windows.Forms.Button()
        Me.txtENG = New System.Windows.Forms.TextBox()
        Me.txtCHA = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtEnglish = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(133, 90)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 114
        Me.btQuit.Text = "取消"
        '
        'btResume
        '
        Me.btResume.Location = New System.Drawing.Point(65, 90)
        Me.btResume.Name = "btResume"
        Me.btResume.Size = New System.Drawing.Size(65, 24)
        Me.btResume.TabIndex = 113
        Me.btResume.Text = "确认"
        '
        'txtENG
        '
        Me.txtENG.Enabled = False
        Me.txtENG.Location = New System.Drawing.Point(84, 2)
        Me.txtENG.MaxLength = 4
        Me.txtENG.Name = "txtENG"
        Me.txtENG.Size = New System.Drawing.Size(176, 21)
        Me.txtENG.TabIndex = 111
        Me.txtENG.Text = ""
        '
        'txtCHA
        '
        Me.txtCHA.Location = New System.Drawing.Point(84, 30)
        Me.txtCHA.MaxLength = 20
        Me.txtCHA.Name = "txtCHA"
        Me.txtCHA.Size = New System.Drawing.Size(176, 21)
        Me.txtCHA.TabIndex = 110
        Me.txtCHA.Text = ""
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(10, 0)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(18, 21)
        Me.txtID.TabIndex = 115
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'txtEnglish
        '
        Me.txtEnglish.Location = New System.Drawing.Point(84, 58)
        Me.txtEnglish.MaxLength = 100
        Me.txtEnglish.Name = "txtEnglish"
        Me.txtEnglish.Size = New System.Drawing.Size(176, 21)
        Me.txtEnglish.TabIndex = 119
        Me.txtEnglish.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "国籍英文描述"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "国籍代码"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "国籍中文描述"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmNationality_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(262, 121)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtEnglish, Me.Label1, Me.Label3, Me.Label2, Me.btQuit, Me.btResume, Me.txtENG, Me.txtCHA, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNationality_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "国籍信息_编辑"
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

            txt1 = ds.Tables(0).Rows(0).Item("Nationality_Cha")
            'txt2 = ds.Tables(0).Rows(0).Item("Nationality_Eng")
            txt3 = ds.Tables(0).Rows(0).Item("Nationality_English")
        End If

        txtCHA.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResume.Click
        Try
            If MsgBox("你确认要修改吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                Call OperateHistory(G_DeptName, Now, G_User, "修改", "Code_Nationality", Trim(txtID.Text), "Nationality_ID")

                ds.Tables(0).Rows(0).Item("Nationality_CHA") = txtCHA.Text
                'ds.Tables(0).Rows(0).Item("Nationality_ENG") = txtENG.Text
                ds.Tables(0).Rows(0).Item("Nationality_English") = txtEnglish.Text
                sqlda.Update(ds)

                If Not (txt1 = Trim(txtCHA.Text) And txt3 = Trim(txtEnglish.Text)) Then
                    Dim updatetxt As String
                    updatetxt = "update code_nationality set nationality_cha=''" & Trim(txtCHA.Text) & "'',nationality_english=''" & Trim(txtEnglish.Text) & "'' where nationality_eng=''" & Trim(txtENG.Text) & "''"
                    CodeOperation("code_nationality", updatetxt)
                End If

                Call btQuit_Click(sender, e)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub


    Private Sub txtEnglish_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEnglish.KeyPress
        If e.KeyChar = Chr(13) Then
            btResume.Focus()
        End If
    End Sub

    Private Sub txtENG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtENG.KeyPress
        If e.KeyChar = Chr(13) Then
            txtCHA.Focus()
        End If
    End Sub

    Private Sub txtCHA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCHA.KeyPress
        If e.KeyChar = Chr(13) Then
            txtEnglish.Focus()
        End If
    End Sub
End Class
