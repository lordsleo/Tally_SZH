Imports TALLY.DBControl
Public Class FrmSealIn_Edit
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
    Friend WithEvents txtRuKuRen As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtManufact As System.Windows.Forms.TextBox
    Friend WithEvents txtSealNOEnd As System.Windows.Forms.TextBox
    Friend WithEvents txtSealNOBegin As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeIn As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.txtRuKuRen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtManufact = New System.Windows.Forms.TextBox()
        Me.txtSealNOEnd = New System.Windows.Forms.TextBox()
        Me.txtSealNOBegin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTimeIn = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.btQuit.Location = New System.Drawing.Point(112, 156)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 4
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.btSave.Location = New System.Drawing.Point(44, 156)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 3
        Me.btSave.Text = "确认"
        '
        'txtRuKuRen
        '
        Me.txtRuKuRen.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.txtRuKuRen.Location = New System.Drawing.Point(82, 128)
        Me.txtRuKuRen.MaxLength = 10
        Me.txtRuKuRen.Name = "txtRuKuRen"
        Me.txtRuKuRen.Size = New System.Drawing.Size(130, 21)
        Me.txtRuKuRen.TabIndex = 2
        Me.txtRuKuRen.Text = ""
        '
        'Label5
        '
        Me.Label5.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.Label5.Location = New System.Drawing.Point(8, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 165
        Me.Label5.Text = "入库人"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtManufact
        '
        Me.txtManufact.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.txtManufact.Location = New System.Drawing.Point(82, 98)
        Me.txtManufact.MaxLength = 30
        Me.txtManufact.Name = "txtManufact"
        Me.txtManufact.Size = New System.Drawing.Size(130, 21)
        Me.txtManufact.TabIndex = 1
        Me.txtManufact.Text = ""
        '
        'txtSealNOEnd
        '
        Me.txtSealNOEnd.Enabled = False
        Me.txtSealNOEnd.Location = New System.Drawing.Point(82, 38)
        Me.txtSealNOEnd.MaxLength = 20
        Me.txtSealNOEnd.Name = "txtSealNOEnd"
        Me.txtSealNOEnd.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNOEnd.TabIndex = 163
        Me.txtSealNOEnd.Text = ""
        '
        'txtSealNOBegin
        '
        Me.txtSealNOBegin.Enabled = False
        Me.txtSealNOBegin.Location = New System.Drawing.Point(82, 8)
        Me.txtSealNOBegin.MaxLength = 20
        Me.txtSealNOBegin.Name = "txtSealNOBegin"
        Me.txtSealNOBegin.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNOBegin.TabIndex = 162
        Me.txtSealNOBegin.Text = ""
        '
        'Label4
        '
        Me.Label4.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.Label4.Location = New System.Drawing.Point(8, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 161
        Me.Label4.Text = "供货商"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 160
        Me.Label2.Text = "铅封止号"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "铅封起号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 158
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 185
        Me.Label3.Text = "入库日期"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeIn
        '
        Me.dtpTimeIn.Location = New System.Drawing.Point(82, 68)
        Me.dtpTimeIn.Name = "dtpTimeIn"
        Me.dtpTimeIn.Size = New System.Drawing.Size(130, 21)
        Me.dtpTimeIn.TabIndex = 0
        Me.dtpTimeIn.Value = New Date(2003, 12, 10, 0, 0, 0, 0)
        '
        'FrmSealIn_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(218, 183)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.dtpTimeIn, Me.Label3, Me.btQuit, Me.btSave, Me.txtRuKuRen, Me.Label5, Me.txtManufact, Me.txtSealNOEnd, Me.txtSealNOBegin, Me.Label4, Me.Label2, Me.Label1, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSealIn_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "铅封入库信息 修改"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmSealIn_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen
        sqlstr = "select * from SEAL_IN where SEAL_IN_ID=" & ID & ""

        dw = Updatedata(sqlda, sqlstr, ds)

        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("ID")
            txtSealNOBegin.Text = ds.Tables(0).Rows(0).Item("SEALNO_BEGIN")
            txtSealNOEnd.Text = ds.Tables(0).Rows(0).Item("SEALNO_END")
            dtpTimeIn.Value = ds.Tables(0).Rows(0).Item("TIME_IN")
            txtManufact.Text = ds.Tables(0).Rows(0).Item("MANUFACTURER")
            txtRuKuRen.Text = ds.Tables(0).Rows(0).Item("INWAREHOUSE_PERSON")
        End If

        dtpTimeIn.Focus()
        Exit Sub

Err:
        Resume Next

    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            'Dim EditDate As Date = CDate(Trim(txtSealTimeIn.Text))

            If Len(Trim(txtRuKuRen.Text)) > 0 Then
                If MsgBox("确认要修改吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                    Call OperateHistory(G_DeptName, Now, G_User, "修改", "SEAL_IN", Trim(txtID.Text), "SEAL_IN_ID")
                    'ds.Tables(0).Rows(0).Item("SEALNO_BEGIN") = Trim(txtSealNOBegin.Text)
                    'If txtSealNOEnd.Text = "" Then
                    '    txtSealNOEnd.Text = txtSealNOBegin.Text
                    'End If
                    'ds.Tables(0).Rows(0).Item("SEALNO_END") = Trim(txtSealNOEnd.Text)
                    ds.Tables(0).Rows(0).Item("MANUFACTURER") = Trim(txtManufact.Text)
                    ds.Tables(0).Rows(0).Item("INWAREHOUSE_PERSON") = Trim(txtRuKuRen.Text)
                    ds.Tables(0).Rows(0).Item("TIME_IN") = dtpTimeIn.Value.Date

                    sqlda.Update(ds)
                    Me.Close()

                End If
            Else
                MsgBox("领用人不能为空!", MsgBoxStyle.Critical, "提示")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub txtSealNOBegin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSealNOBegin.KeyPress
        If e.KeyChar() = Chr(13) Then
            Me.txtSealNOEnd.Focus()
        End If
    End Sub

    Private Sub txtSealNOEnd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSealNOEnd.KeyPress
        If e.KeyChar() = Chr(13) Then
            Me.dtpTimeIn.Focus()
        End If
    End Sub

    Private Sub dtpTimeIn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpTimeIn.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtManufact.Focus()
        End If
    End Sub

    Private Sub txtManufact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtManufact.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtRuKuRen.Focus()
        End If
    End Sub

    Private Sub txtRuKuRen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRuKuRen.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btSave.Focus()
        End If
    End Sub

    Private Sub btSave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btSave.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Me.btSave_Click(sender, e)
        End If
    End Sub
End Class
