Imports TALLY.DBControl
Public Class FrmSealIn_Delete
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
    Friend WithEvents txtRuKuRen As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtManufact As System.Windows.Forms.TextBox
    Friend WithEvents txtSealTimeIn As System.Windows.Forms.TextBox
    Friend WithEvents txtSealNOEnd As System.Windows.Forms.TextBox
    Friend WithEvents txtSealNOBegin As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btnResure As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtRuKuRen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtManufact = New System.Windows.Forms.TextBox()
        Me.txtSealTimeIn = New System.Windows.Forms.TextBox()
        Me.txtSealNOEnd = New System.Windows.Forms.TextBox()
        Me.txtSealNOBegin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btnResure = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtRuKuRen
        '
        Me.txtRuKuRen.Location = New System.Drawing.Point(82, 130)
        Me.txtRuKuRen.MaxLength = 10
        Me.txtRuKuRen.Name = "txtRuKuRen"
        Me.txtRuKuRen.Size = New System.Drawing.Size(130, 21)
        Me.txtRuKuRen.TabIndex = 151
        Me.txtRuKuRen.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 150
        Me.Label5.Text = "入库人"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtManufact
        '
        Me.txtManufact.Location = New System.Drawing.Point(82, 100)
        Me.txtManufact.MaxLength = 30
        Me.txtManufact.Name = "txtManufact"
        Me.txtManufact.Size = New System.Drawing.Size(130, 21)
        Me.txtManufact.TabIndex = 149
        Me.txtManufact.Text = ""
        '
        'txtSealTimeIn
        '
        Me.txtSealTimeIn.Location = New System.Drawing.Point(82, 70)
        Me.txtSealTimeIn.MaxLength = 20
        Me.txtSealTimeIn.Name = "txtSealTimeIn"
        Me.txtSealTimeIn.Size = New System.Drawing.Size(130, 21)
        Me.txtSealTimeIn.TabIndex = 148
        Me.txtSealTimeIn.Text = ""
        '
        'txtSealNOEnd
        '
        Me.txtSealNOEnd.Enabled = False
        Me.txtSealNOEnd.Location = New System.Drawing.Point(82, 40)
        Me.txtSealNOEnd.MaxLength = 20
        Me.txtSealNOEnd.Name = "txtSealNOEnd"
        Me.txtSealNOEnd.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNOEnd.TabIndex = 147
        Me.txtSealNOEnd.Text = ""
        '
        'txtSealNOBegin
        '
        Me.txtSealNOBegin.Enabled = False
        Me.txtSealNOBegin.Location = New System.Drawing.Point(82, 10)
        Me.txtSealNOBegin.MaxLength = 20
        Me.txtSealNOBegin.Name = "txtSealNOBegin"
        Me.txtSealNOBegin.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNOBegin.TabIndex = 146
        Me.txtSealNOBegin.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "供货商"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "进库日期"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "铅封止号"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "铅封起号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 141
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'btQuit
        '
        Me.btQuit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.btQuit.Location = New System.Drawing.Point(112, 158)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 170
        Me.btQuit.Text = "取消"
        '
        'btnResure
        '
        Me.btnResure.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.btnResure.Location = New System.Drawing.Point(44, 158)
        Me.btnResure.Name = "btnResure"
        Me.btnResure.Size = New System.Drawing.Size(65, 24)
        Me.btnResure.TabIndex = 169
        Me.btnResure.Text = "确认"
        '
        'FrmSealIn_Delete
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(218, 185)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btQuit, Me.btnResure, Me.txtRuKuRen, Me.Label5, Me.txtManufact, Me.txtSealTimeIn, Me.txtSealNOEnd, Me.txtSealNOBegin, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSealIn_Delete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "铅封入库信息 删除"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmSealIn_Delete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen
        sqlstr = "select * from SEAL_IN where SEAL_IN_ID=" & ID & ""

        'dw = Getdata(sqlstr, ds)
        dw = Updatedata(sqlda, sqlstr, ds)

        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("ID")
            txtSealNOBegin.Text = ds.Tables(0).Rows(0).Item("SEALNO_BEGIN")
            txtSealNOEnd.Text = ds.Tables(0).Rows(0).Item("SEALNO_END")
            txtSealTimeIn.Text = ds.Tables(0).Rows(0).Item("TIME_IN")
            txtManufact.Text = ds.Tables(0).Rows(0).Item("MANUFACTURER")
            txtRuKuRen.Text = ds.Tables(0).Rows(0).Item("INWAREHOUSE_PERSON")
            'txtUserName.Text = ds.Tables(0).Rows(0).Item("USER_NAME")
        End If

        btQuit.Focus()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btnResure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResure.Click
        Dim iFlag As Short
        Try
            If MsgBox("确认要删除吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then

                '删除每个铅封记录
                iFlag = DeleteSealRecord("spDeleteSealRecord", txtSealNOBegin.Text, txtSealNOEnd.Text)
                If iFlag = 2 Then   '删除成功
                    '记录操作日志
                    Call OperateHistory(G_DeptName, Now, G_User, "删除", "SEAL_IN", Trim(txtID.Text), "SEAL_IN_ID")
                    '删除此铅封入库记录
                    ds.Tables(0).Rows(0).Delete()
                    sqlda.Update(ds)

                    Me.Close()
                Else
                    If iFlag = 1 Then
                        MessageBox.Show("存在断号情况或者有些铅封不存在，请检查。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, _
                        MessageBoxDefaultButton.Button1)
                    Else    'iFlag=0
                        MessageBox.Show("铅封状态不允许删除，请检查。", "错误提示", MessageBoxButtons.OK, _
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    End If
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function DeleteSealRecord(ByVal storeproc As String, ByVal strSealNOBegin As String, ByVal strSealNOEnd As String) As Short
        Dim sqlcmd As New SqlClient.SqlCommand(storeproc, sqlconn)

        Dim prmSealNOBegin, prmSealNOEnd, prmRowCount, prmFlag As SqlClient.SqlParameter
        Dim iFlag As Short  'iFlag标记此段铅封是否顺利删除

        sqlcmd.CommandType = CommandType.StoredProcedure

        prmSealNOBegin = sqlcmd.Parameters.Add("@strSealNOBegin", SqlDbType.VarChar, 20)
        prmSealNOEnd = sqlcmd.Parameters.Add("@strSealNOEnd", SqlDbType.VarChar, 20)
        prmRowCount = sqlcmd.Parameters.Add("@rowcount", SqlDbType.Int)
        prmFlag = sqlcmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int)

        prmSealNOBegin.Direction = ParameterDirection.Input
        prmSealNOEnd.Direction = ParameterDirection.Input
        prmRowCount.Direction = ParameterDirection.Output
        prmFlag.Direction = ParameterDirection.ReturnValue

        prmSealNOBegin.Value = strSealNOBegin
        prmSealNOEnd.Value = strSealNOEnd

        sqlconn.Open()
        sqlcmd.ExecuteNonQuery()
        'iRowCount = CType(prmRowCount.Value, Short)
        iFlag = CType(prmFlag.Value, Short)
        sqlconn.Close()
        'MessageBox.Show("iRowCount=" & iRowCount & " iFlag=" & iFlag, "test")
        Return iFlag
    End Function

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

End Class
