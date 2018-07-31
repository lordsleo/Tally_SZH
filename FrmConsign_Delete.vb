Imports TALLY.DBControl
Public Class FrmConsign_Delete
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
    Friend WithEvents DTPCONSIGN_DATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbCONSIGN_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents txtREMARK As System.Windows.Forms.TextBox
    Friend WithEvents txtITEM As System.Windows.Forms.TextBox
    Friend WithEvents txtCLIENT As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents txtSHIP_CONSIGN_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtSHIP_ID As System.Windows.Forms.TextBox
    Friend WithEvents btQuit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DTPCONSIGN_DATE = New System.Windows.Forms.DateTimePicker()
        Me.CmbCONSIGN_TYPE = New System.Windows.Forms.ComboBox()
        Me.txtREMARK = New System.Windows.Forms.TextBox()
        Me.txtITEM = New System.Windows.Forms.TextBox()
        Me.txtCLIENT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.txtSHIP_CONSIGN_ID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSHIP_ID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'DTPCONSIGN_DATE
        '
        Me.DTPCONSIGN_DATE.CustomFormat = "yyyy/MM/dd"
        Me.DTPCONSIGN_DATE.Enabled = False
        Me.DTPCONSIGN_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DTPCONSIGN_DATE.Location = New System.Drawing.Point(239, 10)
        Me.DTPCONSIGN_DATE.Name = "DTPCONSIGN_DATE"
        Me.DTPCONSIGN_DATE.Size = New System.Drawing.Size(102, 21)
        Me.DTPCONSIGN_DATE.TabIndex = 3
        '
        'CmbCONSIGN_TYPE
        '
        Me.CmbCONSIGN_TYPE.Enabled = False
        Me.CmbCONSIGN_TYPE.Location = New System.Drawing.Point(63, 10)
        Me.CmbCONSIGN_TYPE.Name = "CmbCONSIGN_TYPE"
        Me.CmbCONSIGN_TYPE.Size = New System.Drawing.Size(102, 20)
        Me.CmbCONSIGN_TYPE.TabIndex = 2
        '
        'txtREMARK
        '
        Me.txtREMARK.Enabled = False
        Me.txtREMARK.Location = New System.Drawing.Point(63, 127)
        Me.txtREMARK.MaxLength = 100
        Me.txtREMARK.Multiline = True
        Me.txtREMARK.Name = "txtREMARK"
        Me.txtREMARK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtREMARK.Size = New System.Drawing.Size(278, 44)
        Me.txtREMARK.TabIndex = 6
        Me.txtREMARK.Text = ""
        '
        'txtITEM
        '
        Me.txtITEM.Enabled = False
        Me.txtITEM.Location = New System.Drawing.Point(63, 81)
        Me.txtITEM.MaxLength = 200
        Me.txtITEM.Multiline = True
        Me.txtITEM.Name = "txtITEM"
        Me.txtITEM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtITEM.Size = New System.Drawing.Size(278, 44)
        Me.txtITEM.TabIndex = 5
        Me.txtITEM.Text = ""
        '
        'txtCLIENT
        '
        Me.txtCLIENT.Enabled = False
        Me.txtCLIENT.Location = New System.Drawing.Point(63, 35)
        Me.txtCLIENT.MaxLength = 50
        Me.txtCLIENT.Multiline = True
        Me.txtCLIENT.Name = "txtCLIENT"
        Me.txtCLIENT.Size = New System.Drawing.Size(278, 44)
        Me.txtCLIENT.TabIndex = 4
        Me.txtCLIENT.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "委托类别"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 42)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "委托事项"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(181, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "委托时间"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 42)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "委托人"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(179, 178)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 1
        Me.btQuit.Text = "取 消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(105, 178)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "确 认"
        '
        'txtSHIP_CONSIGN_ID
        '
        Me.txtSHIP_CONSIGN_ID.Location = New System.Drawing.Point(301, 178)
        Me.txtSHIP_CONSIGN_ID.Name = "txtSHIP_CONSIGN_ID"
        Me.txtSHIP_CONSIGN_ID.ReadOnly = True
        Me.txtSHIP_CONSIGN_ID.Size = New System.Drawing.Size(28, 21)
        Me.txtSHIP_CONSIGN_ID.TabIndex = 8
        Me.txtSHIP_CONSIGN_ID.Text = ""
        Me.txtSHIP_CONSIGN_ID.Visible = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 42)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "备注"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtSHIP_ID
        '
        Me.TxtSHIP_ID.Location = New System.Drawing.Point(15, 178)
        Me.TxtSHIP_ID.Name = "TxtSHIP_ID"
        Me.TxtSHIP_ID.ReadOnly = True
        Me.TxtSHIP_ID.Size = New System.Drawing.Size(28, 21)
        Me.TxtSHIP_ID.TabIndex = 7
        Me.TxtSHIP_ID.Text = ""
        Me.TxtSHIP_ID.Visible = False
        '
        'FrmConsign_Delete
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(348, 209)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.DTPCONSIGN_DATE, Me.CmbCONSIGN_TYPE, Me.txtREMARK, Me.txtITEM, Me.txtCLIENT, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.btQuit, Me.btSave, Me.txtSHIP_CONSIGN_ID, Me.Label5, Me.TxtSHIP_ID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConsign_Delete"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "作业委托书_删除"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As New DataSet()
    Dim dw As New DataView()
    Dim sqlda As New SqlClient.SqlDataAdapter()

    Private Sub FrmConsign_Delete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillCONSIGN_TYPE()
        On Error GoTo Err
        Dim sqlstr As String
        sqlstr = "select * from SHIP_CONSIGN where SHIP_CONSIGN_ID=" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)
        If dw.Count > 0 Then
            txtSHIP_CONSIGN_ID.Text = ds.Tables(0).Rows(0).Item("SHIP_CONSIGN_ID")
            TxtSHIP_ID.Text = ds.Tables(0).Rows(0).Item("SHIP_ID")
            txtCLIENT.Text = ds.Tables(0).Rows(0).Item("CLIENT")
            DTPCONSIGN_DATE.Value = ds.Tables(0).Rows(0).Item("CONSIGN_DATE")
            CmbCONSIGN_TYPE.SelectedValue = ds.Tables(0).Rows(0).Item("CONSIGN_TYPE")
            txtITEM.Text = ds.Tables(0).Rows(0).Item("ITEM")
            txtREMARK.Text = ds.Tables(0).Rows(0).Item("REMARK")
        End If
        txtCLIENT.Focus()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub FillCONSIGN_TYPE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "select CODE_CONSIGN_TYPE,CONSIGN_NAME from CODE_CONSIGN_TYPE"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbCONSIGN_TYPE.DataSource = dvc
        Me.CmbCONSIGN_TYPE.DisplayMember = "CONSIGN_NAME"
        Me.CmbCONSIGN_TYPE.ValueMember = "CODE_CONSIGN_TYPE"
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            If MsgBox("你确认要删除吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
                Call OperateHistory(G_DeptName, Now, G_User, "修改", "SHIP_CONSIGN", Trim(txtSHIP_CONSIGN_ID.Text), "SHIP_CONSIGN_ID")
                ds.Tables(0).Rows(0).Delete()
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

    Private Sub CmbCONSIGN_TYPE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbCONSIGN_TYPE.KeyDown
        If e.KeyCode = Keys.Enter Then
            DTPCONSIGN_DATE.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub DTPCONSIGN_DATE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DTPCONSIGN_DATE.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCLIENT.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txtCLIENT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCLIENT.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtITEM.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txtITEM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtITEM.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtREMARK.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txtREMARK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtREMARK.KeyDown
        If e.KeyCode = Keys.Enter Then
            btSave.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btSave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btSave.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btSave_Click(sender, e)
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btQuit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btQuit.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
