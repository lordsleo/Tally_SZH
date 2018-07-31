Imports TALLY.DBControl
Public Class FrmBILL_RECEIVABLE_Delete
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btResume As System.Windows.Forms.Button
    Friend WithEvents txtACCONT_ARREARAGE As System.Windows.Forms.TextBox
    Friend WithEvents txtACCOUNT_OCCUR As System.Windows.Forms.TextBox
    Friend WithEvents txtACCOUNT_LAST As System.Windows.Forms.TextBox
    Friend WithEvents CmbACCOUNT_COMPANY As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtACCOUNT_IN As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtACCONT_ARREARAGE = New System.Windows.Forms.TextBox()
        Me.txtACCOUNT_OCCUR = New System.Windows.Forms.TextBox()
        Me.txtACCOUNT_LAST = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btResume = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.CmbACCOUNT_COMPANY = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtACCOUNT_IN = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtACCONT_ARREARAGE
        '
        Me.txtACCONT_ARREARAGE.Location = New System.Drawing.Point(80, 101)
        Me.txtACCONT_ARREARAGE.MaxLength = 10
        Me.txtACCONT_ARREARAGE.Name = "txtACCONT_ARREARAGE"
        Me.txtACCONT_ARREARAGE.Size = New System.Drawing.Size(130, 21)
        Me.txtACCONT_ARREARAGE.TabIndex = 6
        Me.txtACCONT_ARREARAGE.Text = ""
        '
        'txtACCOUNT_OCCUR
        '
        Me.txtACCOUNT_OCCUR.Location = New System.Drawing.Point(80, 53)
        Me.txtACCOUNT_OCCUR.MaxLength = 10
        Me.txtACCOUNT_OCCUR.Name = "txtACCOUNT_OCCUR"
        Me.txtACCOUNT_OCCUR.Size = New System.Drawing.Size(130, 21)
        Me.txtACCOUNT_OCCUR.TabIndex = 4
        Me.txtACCOUNT_OCCUR.Text = ""
        '
        'txtACCOUNT_LAST
        '
        Me.txtACCOUNT_LAST.Location = New System.Drawing.Point(80, 29)
        Me.txtACCOUNT_LAST.MaxLength = 10
        Me.txtACCOUNT_LAST.Name = "txtACCOUNT_LAST"
        Me.txtACCOUNT_LAST.Size = New System.Drawing.Size(130, 21)
        Me.txtACCOUNT_LAST.TabIndex = 3
        Me.txtACCOUNT_LAST.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "本月到款"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "本月发生"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "上月欠款"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "往来单位"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(114, 132)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 1
        Me.btQuit.Text = "取消"
        '
        'btResume
        '
        Me.btResume.Location = New System.Drawing.Point(46, 132)
        Me.btResume.Name = "btResume"
        Me.btResume.Size = New System.Drawing.Size(65, 24)
        Me.btResume.TabIndex = 0
        Me.btResume.Text = "确认"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(18, 132)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(20, 21)
        Me.txtID.TabIndex = 103
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'CmbACCOUNT_COMPANY
        '
        Me.CmbACCOUNT_COMPANY.Location = New System.Drawing.Point(80, 6)
        Me.CmbACCOUNT_COMPANY.Name = "CmbACCOUNT_COMPANY"
        Me.CmbACCOUNT_COMPANY.Size = New System.Drawing.Size(130, 20)
        Me.CmbACCOUNT_COMPANY.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "现在欠款"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtACCOUNT_IN
        '
        Me.TxtACCOUNT_IN.Location = New System.Drawing.Point(80, 77)
        Me.TxtACCOUNT_IN.MaxLength = 10
        Me.TxtACCOUNT_IN.Name = "TxtACCOUNT_IN"
        Me.TxtACCOUNT_IN.Size = New System.Drawing.Size(130, 21)
        Me.TxtACCOUNT_IN.TabIndex = 5
        Me.TxtACCOUNT_IN.Text = ""
        '
        'FrmBILL_RECEIVABLE_Delete
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(216, 165)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TxtACCOUNT_IN, Me.CmbACCOUNT_COMPANY, Me.txtACCONT_ARREARAGE, Me.txtACCOUNT_OCCUR, Me.txtACCOUNT_LAST, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.btQuit, Me.btResume, Me.txtID, Me.Label5})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBILL_RECEIVABLE_Delete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "应收款管理_删除"
        Me.ResumeLayout(False)

    End Sub

#End Region
    
    Private Sub FrmBILL_RECEIVABLE_Delete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen
        Call FillACCOUNT_COMPANY()
        sqlstr = "select * from BILL_RECEIVABLE where BILL_RECEIVABLE_ID=" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        If dw.Count > 0 Then

            txtID.Text = ds.Tables(0).Rows(0).Item("BILL_RECEIVABLE_ID")
            CmbACCOUNT_COMPANY.SelectedValue = ds.Tables(0).Rows(0).Item("ACCOUNT_COMPANY")
            txtACCOUNT_LAST.Text = ds.Tables(0).Rows(0).Item("ACCOUNT_LAST")
            txtACCOUNT_OCCUR.Text = ds.Tables(0).Rows(0).Item("ACCOUNT_OCCUR")
            TxtACCOUNT_IN.Text = ds.Tables(0).Rows(0).Item("ACCOUNT_IN")
            txtACCONT_ARREARAGE.Text = ds.Tables(0).Rows(0).Item("ACCONT_ARREARAGE")

        End If
        CmbACCOUNT_COMPANY.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResume.Click
        Try
            If MsgBox("你确认要删除吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                Call OperateHistory(G_DeptName, Now, G_User, "删除", "BILL_RECEIVABLE", Trim(txtID.Text), "BILL_RECEIVABLE_ID")

                'ds.Tables(0).Rows(0).Item("ACCOUNT_COMPANY") = CmbACCOUNT_COMPANY.SelectedValue
                'ds.Tables(0).Rows(0).Item("ACCOUNT_LAST") = txtACCOUNT_LAST.Text
                'ds.Tables(0).Rows(0).Item("ACCOUNT_OCCUR") = txtACCOUNT_OCCUR.Text
                'ds.Tables(0).Rows(0).Item("ACCOUNT_IN") = TxtACCOUNT_IN.Text
                'ds.Tables(0).Rows(0).Item("ACCONT_ARREARAGE") = txtACCONT_ARREARAGE.Text
                'ds.Tables(0).Rows(0).Item("USER_NAME") = G_User

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

    Private Sub FillACCOUNT_COMPANY()
        Dim sqldc As String
        Dim dvc As New DataView()
        Dim dsc As New DataSet()
        sqldc = "select CODE_SHIP_AGENT,SHIPAGENT_SHORT from CODE_SHIP_AGENT"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbACCOUNT_COMPANY.DataSource = dvc
        Me.CmbACCOUNT_COMPANY.DisplayMember = "SHIPAGENT_SHORT"
        Me.CmbACCOUNT_COMPANY.ValueMember = "CODE_SHIP_AGENT"
    End Sub

End Class
