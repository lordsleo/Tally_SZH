Imports TALLY.DBControl
Public Class FrmSealIn_Add
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
    Friend WithEvents txtSealNOEnd As System.Windows.Forms.TextBox
    Friend WithEvents txtSealNOBegin As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeIn As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtRuKuRen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtManufact = New System.Windows.Forms.TextBox()
        Me.txtSealNOEnd = New System.Windows.Forms.TextBox()
        Me.txtSealNOBegin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTimeIn = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'txtRuKuRen
        '
        Me.txtRuKuRen.Location = New System.Drawing.Point(82, 128)
        Me.txtRuKuRen.MaxLength = 10
        Me.txtRuKuRen.Name = "txtRuKuRen"
        Me.txtRuKuRen.Size = New System.Drawing.Size(130, 21)
        Me.txtRuKuRen.TabIndex = 4
        Me.txtRuKuRen.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "入库人"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtManufact
        '
        Me.txtManufact.Location = New System.Drawing.Point(82, 98)
        Me.txtManufact.MaxLength = 30
        Me.txtManufact.Name = "txtManufact"
        Me.txtManufact.Size = New System.Drawing.Size(130, 21)
        Me.txtManufact.TabIndex = 3
        Me.txtManufact.Text = ""
        '
        'txtSealNOEnd
        '
        Me.txtSealNOEnd.Location = New System.Drawing.Point(82, 38)
        Me.txtSealNOEnd.MaxLength = 20
        Me.txtSealNOEnd.Name = "txtSealNOEnd"
        Me.txtSealNOEnd.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNOEnd.TabIndex = 1
        Me.txtSealNOEnd.Text = ""
        '
        'txtSealNOBegin
        '
        Me.txtSealNOBegin.Location = New System.Drawing.Point(82, 8)
        Me.txtSealNOBegin.MaxLength = 20
        Me.txtSealNOBegin.Name = "txtSealNOBegin"
        Me.txtSealNOBegin.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNOBegin.TabIndex = 0
        Me.txtSealNOBegin.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "供货商"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "铅封止号"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 10)
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
        Me.btQuit.Location = New System.Drawing.Point(146, 156)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 7
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(78, 156)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 6
        Me.btSave.Text = "确认"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(10, 156)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(65, 24)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "清空"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 183
        Me.Label3.Text = "入库日期"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeIn
        '
        Me.dtpTimeIn.Location = New System.Drawing.Point(82, 68)
        Me.dtpTimeIn.Name = "dtpTimeIn"
        Me.dtpTimeIn.Size = New System.Drawing.Size(130, 21)
        Me.dtpTimeIn.TabIndex = 2
        Me.dtpTimeIn.Value = New Date(2003, 12, 10, 0, 0, 0, 0)
        '
        'FrmSealIn_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(218, 183)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.dtpTimeIn, Me.Label3, Me.btQuit, Me.btSave, Me.btnClear, Me.txtRuKuRen, Me.Label5, Me.txtManufact, Me.txtSealNOEnd, Me.txtSealNOBegin, Me.Label4, Me.Label2, Me.Label1, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSealIn_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "铅封入库信息 增加"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmSealIn_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            'txtSealTimeIn.Text = ds.Tables(0).Rows(0).Item("TIME_IN")
            dtpTimeIn.Value = ds.Tables(0).Rows(0).Item("TIME_IN")
            txtManufact.Text = ds.Tables(0).Rows(0).Item("MANUFACTURER")
            txtRuKuRen.Text = ds.Tables(0).Rows(0).Item("INWAREHOUSE_PERSON")
        End If

        txtSealNOBegin.Focus()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Function VerifySealNOInput(ByVal strSealNOBegin As String, ByVal strSealNOEnd As String) As Boolean
        '铅封号格式验证
        Dim i, j, iLength1, iLength2 As Short
        Dim strSealNO, strNOBegin, strNOEnd As String
        Dim c1, c2 As Char
        Dim flag As Boolean = False
        iLength1 = Len(strSealNOBegin)
        iLength2 = Len(strSealNOEnd)

        If iLength1 = iLength2 And iLength1 > 0 Then
            For i = iLength1 To 1 Step -1
                c1 = Mid(strSealNOBegin, i, 1)
                c2 = Mid(strSealNOEnd, i, 1)
                If (c1 >= "0" And c1 <= "9") And (c2 >= "0" And c2 <= "9") Then

                Else
                    If (c1 >= "A" And c1 <= "Z") And (c2 >= "A" And c2 <= "Z") Then
                        Exit For
                    Else
                        MessageBox.Show("铅封号不合法！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        Return False
                        Exit Function
                    End If
                End If
            Next

            If i >= 1 And i < iLength1 Then
                If Mid(strSealNOBegin, i + 1) <= Mid(strSealNOEnd, i + 1) Then
                    '后部通过验证
                Else
                    MessageBox.Show("铅封起号必须位于止号之前！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Return False
                    Exit Function
                End If
            ElseIf i < 1 Then
                MessageBox.Show("铅封号不能全为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Return False
                Exit Function
            ElseIf i = iLength1 Then
                MessageBox.Show("铅封号后部不能为字母！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Return False
                Exit Function
            End If

            For j = 1 To i
                c1 = Mid(strSealNOBegin, j, 1)
                c2 = Mid(strSealNOEnd, j, 1)
                If (c1 >= "A" And c1 <= "Z") And (c2 >= "A" And c2 <= "Z") Then

                Else
                    If (c1 >= "0" And c1 <= "9") And (c2 >= "0" And c2 <= "9") Then

                    Else
                        MessageBox.Show("铅封号不合法！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        Return False
                        Exit Function
                    End If
                End If
            Next

            If StrComp(Mid(strSealNOBegin, 1, i), Mid(strSealNOEnd, 1, i), CompareMethod.Text) = 0 Then
                flag = True             '全部通过验证
                Return flag
                'Return CType((Mid(strSealNOEnd, i + 1) - Mid(strSealNOBegin, i + 1) + 1), Short) '返回入库铅封个数
            Else
                MessageBox.Show("铅封起止号前部不一致！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Return False
                Exit Function
            End If
        Else
            If iLength1 <> iLength2 Then
                MessageBox.Show("铅封起止号长度不一致！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
            If iLength1 <= 0 Then
                MessageBox.Show("铅封起号不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
            Return False
            Exit Function
        End If

    End Function

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim strSealNOBegin, strSealNOEnd, strManufact, strRuKuRen As String
        Dim iFlag As Short

        strSealNOBegin = UCase(Trim(txtSealNOBegin.Text))
        strSealNOEnd = UCase(Trim(txtSealNOEnd.Text))
        If strSealNOEnd = "" Then
            strSealNOEnd = strSealNOBegin
        End If
        strManufact = Trim(txtManufact.Text)
        strRuKuRen = Trim(txtRuKuRen.Text)
        Try
            'Dim InDate As Date = CDate(Trim(txtSealTimeIn.Text))

            If VerifySealNOInput(strSealNOBegin, strSealNOEnd) Then  '铅封号输入格式通过验证
                'MessageBox.Show("count=" & iRowCountYuan, "111")
                'Dim dsSave As New DataSet()
                'If Getdata("select * from SEAL_RECORD where SEALNO='" & Trim(txtSealNOBegin.Text) & "'", dsSave).Count > 0 Then
                'MsgBox("已存在此铅封信息,请注意检查!")   '要修改
                '    Exit Sub
                'End If
                If Len(strRuKuRen) > 0 Then
                    iFlag = UpdateSealRecord("spInsertSealRecord", strSealNOBegin, strSealNOEnd)
                    If iFlag = 2 Then '正常入库
                        Dim row As DataRow
                        row = ds.Tables(0).NewRow()

                        row("SEALNO_BEGIN") = strSealNOBegin
                        row("SEALNO_END") = strSealNOEnd
                        row("MANUFACTURER") = strManufact
                        row("INWAREHOUSE_PERSON") = strRuKuRen
                        row("TIME_IN") = dtpTimeIn.Value.Date
                        row("USER_NAME") = G_User

                        ds.Tables(0).Rows.Add(row)
                        sqlda.Update(ds)

                        Me.Close()
                    Else
                        If iFlag = 0 Then
                            MessageBox.Show("此批铅封已有在库，不能入库！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        Else    'iFlag=1
                            MessageBox.Show("入库时发生数据库错误，入库失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        End If
                    End If
                Else
                    MsgBox("入库人不能为空!", MsgBoxStyle.Critical, "提示")
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function UpdateSealRecord(ByVal storeproc As String, ByVal strSealNOBegin As String, ByVal strSealNOEnd As String) As Short
        Dim iFlag As Short
        Dim sqlcmd As New SqlClient.SqlCommand(storeproc, sqlconn)
        Dim prmSealNOBegin, prmSealNOEnd, prmUserName, prmFlag As SqlClient.SqlParameter

        sqlcmd.CommandType = CommandType.StoredProcedure

        prmSealNOBegin = sqlcmd.Parameters.Add("@strSealNOBegin", SqlDbType.VarChar, 20)
        prmSealNOEnd = sqlcmd.Parameters.Add("@strSealNOEnd", SqlDbType.VarChar, 20)
        prmUserName = sqlcmd.Parameters.Add("@strUserName", SqlDbType.VarChar, 10)
        prmFlag = sqlcmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int)

        prmSealNOBegin.Direction = ParameterDirection.Input
        prmSealNOEnd.Direction = ParameterDirection.Input
        prmUserName.Direction = ParameterDirection.Input
        prmFlag.Direction = ParameterDirection.ReturnValue

        prmSealNOBegin.Value = strSealNOBegin
        prmSealNOEnd.Value = strSealNOEnd
        prmUserName.Value = G_User

        sqlconn.Open()
        sqlcmd.ExecuteNonQuery()
        iFlag = CType(prmFlag.Value, Short)
        sqlconn.Close()
        Return iFlag
    End Function

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtSealNOBegin.Text = ""
        txtSealNOEnd.Text = ""
        txtManufact.Text = ""
        txtRuKuRen.Text = ""
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub txtSealNOBegin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSealNOBegin.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtSealNOEnd.Focus()
        End If
    End Sub

    Private Sub txtSealNOEnd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSealNOEnd.KeyPress
        If e.KeyChar = Chr(13) Then
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
