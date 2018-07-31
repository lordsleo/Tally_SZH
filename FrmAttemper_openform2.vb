Imports TALLY.DBControl
Public Class FrmAttemper_openform2
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
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbDEPT_CODE1 As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDEPT_CODE As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.CmbDEPT_CODE1 = New System.Windows.Forms.ComboBox()
        Me.CmbDEPT_CODE = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(94, 62)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(65, 24)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "取消"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(26, 62)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(65, 24)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "确认"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(8, 7)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 20)
        Me.Label22.TabIndex = 73
        Me.Label22.Text = "原属理货站"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbDEPT_CODE1
        '
        Me.CmbDEPT_CODE1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbDEPT_CODE1.Location = New System.Drawing.Point(76, 7)
        Me.CmbDEPT_CODE1.Name = "CmbDEPT_CODE1"
        Me.CmbDEPT_CODE1.Size = New System.Drawing.Size(100, 20)
        Me.CmbDEPT_CODE1.TabIndex = 0
        '
        'CmbDEPT_CODE
        '
        Me.CmbDEPT_CODE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDEPT_CODE.Location = New System.Drawing.Point(76, 33)
        Me.CmbDEPT_CODE.Name = "CmbDEPT_CODE"
        Me.CmbDEPT_CODE.Size = New System.Drawing.Size(100, 20)
        Me.CmbDEPT_CODE.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "调至"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmAttemper_openform2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(184, 93)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnQuit, Me.btnSave, Me.Label22, Me.CmbDEPT_CODE1, Me.CmbDEPT_CODE, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAttemper_openform2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "调整站属"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As New DataSet()
    Dim dw As New DataView()
    Dim sqlda As New SqlClient.SqlDataAdapter()

    Private Sub FrmAttemper_openform2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillDEPT_CODE()
        On Error GoTo Err
        Dim sqlstr As String
        sqlstr = "select SHIP_ID,DEPT_CODE from SShip where SHIP_ID=" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)
        If dw.Count > 0 Then
            CmbDEPT_CODE1.SelectedValue = ds.Tables(0).Rows(0).Item("DEPT_CODE")
        End If
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If CmbDEPT_CODE.SelectedValue <> "00" Then
                If MsgBox("你确认要修改吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
                    ds.Tables(0).Rows(0).Item("DEPT_CODE") = CmbDEPT_CODE.SelectedValue
                    sqlda.Update(ds)
                    GL_Str = 1
                    Me.Close()
                Else
                    GL_Str = 0
                End If
            Else
                MsgBox("部门代码不能为空！")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub FillDEPT_CODE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        Dim dsc1 As New DataSet()
        sqldc = "select DEPT_CODE,DEPT_NAME from DEPARTMENT where DEPT_CODE like '26.11%' "
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbDEPT_CODE.DataSource = dvc
        Me.CmbDEPT_CODE.DisplayMember = "DEPT_NAME"
        Me.CmbDEPT_CODE.ValueMember = "DEPT_CODE"
        dvc = DBControl.Getdata(sqldc, dsc1)
        Me.CmbDEPT_CODE1.DataSource = dvc
        Me.CmbDEPT_CODE1.DisplayMember = "DEPT_NAME"
        Me.CmbDEPT_CODE1.ValueMember = "DEPT_CODE"
    End Sub

End Class
