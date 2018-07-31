Imports TALLY.DBControl
Public Class FrmBILL_RECEIVABLE_Export
    Inherits System.Windows.Forms.Form

    Dim sqlstr As String
    Dim ds As New DataSet()
    Dim dw As New DataView()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btResume As System.Windows.Forms.Button
    Friend WithEvents CmbACCOUNT_COMPANY As System.Windows.Forms.ComboBox
    Friend WithEvents TxtACCOUNT_IN As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btResume = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.CmbACCOUNT_COMPANY = New System.Windows.Forms.ComboBox()
        Me.TxtACCOUNT_IN = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "本月到款"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.btQuit.Location = New System.Drawing.Point(114, 58)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 3
        Me.btQuit.Text = "取消"
        '
        'btResume
        '
        Me.btResume.Location = New System.Drawing.Point(46, 58)
        Me.btResume.Name = "btResume"
        Me.btResume.Size = New System.Drawing.Size(65, 24)
        Me.btResume.TabIndex = 2
        Me.btResume.Text = "确认"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(18, 58)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(20, 21)
        Me.txtID.TabIndex = 103
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'CmbACCOUNT_COMPANY
        '
        Me.CmbACCOUNT_COMPANY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbACCOUNT_COMPANY.Location = New System.Drawing.Point(80, 6)
        Me.CmbACCOUNT_COMPANY.Name = "CmbACCOUNT_COMPANY"
        Me.CmbACCOUNT_COMPANY.Size = New System.Drawing.Size(130, 20)
        Me.CmbACCOUNT_COMPANY.TabIndex = 0
        '
        'TxtACCOUNT_IN
        '
        Me.TxtACCOUNT_IN.Location = New System.Drawing.Point(80, 28)
        Me.TxtACCOUNT_IN.MaxLength = 10
        Me.TxtACCOUNT_IN.Name = "TxtACCOUNT_IN"
        Me.TxtACCOUNT_IN.Size = New System.Drawing.Size(130, 21)
        Me.TxtACCOUNT_IN.TabIndex = 1
        Me.TxtACCOUNT_IN.Text = ""
        '
        'FrmBILL_RECEIVABLE_Export
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(216, 89)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TxtACCOUNT_IN, Me.CmbACCOUNT_COMPANY, Me.Label4, Me.Label1, Me.btQuit, Me.btResume, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBILL_RECEIVABLE_Export"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "应收款管理_到款录入"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmBILL_RECEIVABLE_Export_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err

        Me.StartPosition = FormStartPosition.CenterScreen
        Call FillACCOUNT_COMPANY()

        'If dw.Count > 0 Then
        '    txtID.Text = ds.Tables(0).Rows(0).Item("BILL_RECEIVABLE_ID")
        '    CmbACCOUNT_COMPANY.SelectedValue = ds.Tables(0).Rows(0).Item("ACCOUNT_COMPANY")
        '    TxtACCOUNT_IN.Text = ds.Tables(0).Rows(0).Item("ACCOUNT_IN")
        'End If
        CmbACCOUNT_COMPANY.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResume.Click
        Try
            If MsgBox("你确认要修改吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                If CmbACCOUNT_COMPANY.SelectedValue <> "00" Then
                    sqlstr = "select * from BILL_RECEIVABLE where ACCOUNT_COMPANY=" & CmbACCOUNT_COMPANY.SelectedValue & ""
                    dw = Updatedata(sqlda, sqlstr, ds)
                    ds.Tables(0).Rows(0).Item("ACCOUNT_COMPANY") = CmbACCOUNT_COMPANY.SelectedValue
                    Dim MONEY As String
                    Dim ACCOUNT As String
                    If Len(Trim(TxtACCOUNT_IN.Text)) > 0 Then
                        If IsNumeric(Trim(TxtACCOUNT_IN.Text)) Then
                            MONEY = ds.Tables(0).Rows(0).Item("ACCOUNT_IN")
                            ACCOUNT = CType(MONEY, Double) + CType(TxtACCOUNT_IN.Text, Double)
                            ds.Tables(0).Rows(0).Item("ACCOUNT_IN") = ACCOUNT

                            MONEY = ds.Tables(0).Rows(0).Item("ACCONT_ARREARAGE")
                            ACCOUNT = CType(MONEY, Double) - CType(TxtACCOUNT_IN.Text, Double)
                            ds.Tables(0).Rows(0).Item("ACCONT_ARREARAGE") = ACCOUNT
                        Else
                            MsgBox("本月到款一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                            Exit Sub
                        End If
                    End If
                    ds.Tables(0).Rows(0).Item("USER_NAME") = G_User
                    sqlda.Update(ds)
                    Call btQuit_Click(sender, e)
                Else
                    MsgBox("请选择往来单位！", MsgBoxStyle.Information, "提示")
                End If

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
