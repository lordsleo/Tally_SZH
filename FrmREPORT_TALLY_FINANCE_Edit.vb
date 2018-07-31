Imports TALLY.DBControl
Public Class FrmREPORT_TALLY_FINANCE_Edit
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
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmbCODE_TALLY_FINANCE As System.Windows.Forms.ComboBox
    Friend WithEvents DTPYEARMONTH As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtCOMPLETE_LASTYEAR As System.Windows.Forms.TextBox
    Friend WithEvents TxtCOMPLETE_MONTH As System.Windows.Forms.TextBox
    Friend WithEvents TxtDEMO As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtCOMPLETE_LASTYEAR = New System.Windows.Forms.TextBox
        Me.TxtDEMO = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DTPYEARMONTH = New System.Windows.Forms.DateTimePicker
        Me.CmbCODE_TALLY_FINANCE = New System.Windows.Forms.ComboBox
        Me.TxtCOMPLETE_MONTH = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(102, 141)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 6
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(34, 141)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 5
        Me.btSave.Text = "确认"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(8, 58)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(82, 20)
        Me.Label22.TabIndex = 106
        Me.Label22.Text = "本月完成"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "去年同期完成"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "备注"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCOMPLETE_LASTYEAR
        '
        Me.TxtCOMPLETE_LASTYEAR.Location = New System.Drawing.Point(94, 83)
        Me.TxtCOMPLETE_LASTYEAR.Name = "TxtCOMPLETE_LASTYEAR"
        Me.TxtCOMPLETE_LASTYEAR.Size = New System.Drawing.Size(114, 21)
        Me.TxtCOMPLETE_LASTYEAR.TabIndex = 3
        Me.TxtCOMPLETE_LASTYEAR.Text = ""
        '
        'TxtDEMO
        '
        Me.TxtDEMO.Location = New System.Drawing.Point(94, 109)
        Me.TxtDEMO.Name = "TxtDEMO"
        Me.TxtDEMO.Size = New System.Drawing.Size(114, 21)
        Me.TxtDEMO.TabIndex = 4
        Me.TxtDEMO.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "时间"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 20)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "财务项目"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTPYEARMONTH
        '
        Me.DTPYEARMONTH.CustomFormat = "yyyy年  MM月"
        Me.DTPYEARMONTH.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPYEARMONTH.Location = New System.Drawing.Point(94, 6)
        Me.DTPYEARMONTH.Name = "DTPYEARMONTH"
        Me.DTPYEARMONTH.Size = New System.Drawing.Size(114, 21)
        Me.DTPYEARMONTH.TabIndex = 0
        '
        'CmbCODE_TALLY_FINANCE
        '
        Me.CmbCODE_TALLY_FINANCE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCODE_TALLY_FINANCE.Location = New System.Drawing.Point(94, 32)
        Me.CmbCODE_TALLY_FINANCE.Name = "CmbCODE_TALLY_FINANCE"
        Me.CmbCODE_TALLY_FINANCE.Size = New System.Drawing.Size(114, 20)
        Me.CmbCODE_TALLY_FINANCE.TabIndex = 1
        '
        'TxtCOMPLETE_MONTH
        '
        Me.TxtCOMPLETE_MONTH.Location = New System.Drawing.Point(94, 57)
        Me.TxtCOMPLETE_MONTH.Name = "TxtCOMPLETE_MONTH"
        Me.TxtCOMPLETE_MONTH.Size = New System.Drawing.Size(114, 21)
        Me.TxtCOMPLETE_MONTH.TabIndex = 2
        Me.TxtCOMPLETE_MONTH.Text = ""
        '
        'FrmREPORT_TALLY_FINANCE_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(214, 173)
        Me.Controls.Add(Me.CmbCODE_TALLY_FINANCE)
        Me.Controls.Add(Me.DTPYEARMONTH)
        Me.Controls.Add(Me.TxtDEMO)
        Me.Controls.Add(Me.TxtCOMPLETE_LASTYEAR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtCOMPLETE_MONTH)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmREPORT_TALLY_FINANCE_Edit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "理货财务统计月报_编辑"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As New DataSet()
    Dim dw As New DataView()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim COMPLETE_MONTH As String
    Dim COMPLETE_QUARTER As String
    Dim COMPLETE_YEAR As String

    Private Sub FrmREPORT_TALLY_FINANCE_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err

        Call FillCODE_TALLY_FINANCE()
        Dim sqlstr As String
        sqlstr = "select * from REPORT_TALLY_FINANCE where REPORT_TALLY_FINANCE_ID=" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        If dw.Count > 0 Then
            DTPYEARMONTH.Value = ds.Tables(0).Rows(0).Item("YEARMONTH")
            CmbCODE_TALLY_FINANCE.SelectedValue = ds.Tables(0).Rows(0).Item("Code_ITEM")
            TxtCOMPLETE_MONTH.Text = ds.Tables(0).Rows(0).Item("COMPLETE_MONTH")
            COMPLETE_MONTH = ds.Tables(0).Rows(0).Item("COMPLETE_MONTH")
            COMPLETE_QUARTER = ds.Tables(0).Rows(0).Item("COMPLETE_QUARTER")
            COMPLETE_YEAR = ds.Tables(0).Rows(0).Item("COMPLETE_YEAR")
            TxtCOMPLETE_LASTYEAR.Text = ds.Tables(0).Rows(0).Item("COMPLETE_LASTYEAR")
            TxtDEMO.Text = ds.Tables(0).Rows(0).Item("DEMO")
        End If
        CmbCODE_TALLY_FINANCE.Focus()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            If MsgBox("你确认要修改数据吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then

                If Len(Trim(TxtCOMPLETE_MONTH.Text)) > 0 Then
                    If IsNumeric(Trim(TxtCOMPLETE_MONTH.Text)) Then
                        TxtCOMPLETE_MONTH.Text = Trim(TxtCOMPLETE_MONTH.Text)
                    Else
                        MsgBox("本月完成一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                        Exit Sub
                    End If
                Else
                    TxtCOMPLETE_MONTH.Text = 0
                End If
                If Len(Trim(TxtCOMPLETE_LASTYEAR.Text)) > 0 Then
                    If IsNumeric(Trim(TxtCOMPLETE_LASTYEAR.Text)) Then
                        TxtCOMPLETE_LASTYEAR.Text = Trim(TxtCOMPLETE_LASTYEAR.Text)
                    Else
                        MsgBox("去年同期完成一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                        Exit Sub
                    End If
                Else
                    TxtCOMPLETE_LASTYEAR.Text = 0
                End If

                Call OperateHistory(G_DeptName, Now, G_User, "修改", "REPORT_TALLY_FINANCE", Trim(ID), "REPORT_TALLY_FINANCE_ID")

                'Dim j As Integer
                'j = (Month(DTPYEARMONTH.Value) + 1) / 3.0

                COMPLETE_MONTH = CType(TxtCOMPLETE_MONTH.Text, Double) - CType(COMPLETE_MONTH, Double)
                COMPLETE_QUARTER = CType(COMPLETE_QUARTER, Double) + CType(COMPLETE_MONTH, Double)
                COMPLETE_YEAR = CType(COMPLETE_YEAR, Double) + CType(COMPLETE_MONTH, Double)

                ds.Tables(0).Rows(0).Item("COMPLETE_MONTH") = IIf(Len(Trim(TxtCOMPLETE_MONTH.Text)) > 0, Trim(TxtCOMPLETE_MONTH.Text), 0)
                ds.Tables(0).Rows(0).Item("COMPLETE_QUARTER") = COMPLETE_QUARTER
                ds.Tables(0).Rows(0).Item("COMPLETE_YEAR") = COMPLETE_YEAR
                ds.Tables(0).Rows(0).Item("COMPLETE_LASTYEAR") = IIf(Len(Trim(TxtCOMPLETE_LASTYEAR.Text)) > 0, Trim(TxtCOMPLETE_LASTYEAR.Text), 0)
                ds.Tables(0).Rows(0).Item("DEMO") = Trim(TxtDEMO.Text)
                sqlda.Update(ds)

                'ExecSql("UPDATE [REPORT_TALLY_FINANCE] SET COMPLETE_QUARTER='" & COMPLETE_QUARTER & "' WHERE datediff(yy,YearMonth,'" & DTPYEARMONTH.Value & "')=0 and (month(YearMonth)+2)/3='" & j & "' and code_item='" & CmbCODE_TALLY_FINANCE.SelectedValue & "'")
                'ExecSql("UPDATE [REPORT_TALLY_FINANCE] SET COMPLETE_YEAR='" & COMPLETE_YEAR & "' WHERE datediff(yy,YearMonth,'" & DTPYEARMONTH.Value & "')=0 and code_item='" & CmbCODE_TALLY_FINANCE.SelectedValue & "'")

                Me.Close()
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub FillCODE_TALLY_FINANCE()
        Dim sqldc As String
        Dim dvc As New DataView()
        Dim dsc As New DataSet()
        sqldc = "select CODE_ITEM,ITEM from CODE_TALLY_FINANCE"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbCODE_TALLY_FINANCE.DataSource = dvc
        Me.CmbCODE_TALLY_FINANCE.DisplayMember = "ITEM"
        Me.CmbCODE_TALLY_FINANCE.ValueMember = "CODE_ITEM"
    End Sub
    Private Sub DTPYEARMONTH_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DTPYEARMONTH.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbCODE_TALLY_FINANCE.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbCODE_TALLY_FINANCE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbCODE_TALLY_FINANCE.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbCODE_TALLY_FINANCE.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtCOMPLETE_MONTH_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCOMPLETE_MONTH.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtCOMPLETE_LASTYEAR.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtCOMPLETE_LASTYEAR_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCOMPLETE_LASTYEAR.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDEMO.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtDEMO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDEMO.KeyDown
        If e.KeyCode = Keys.Enter Then
            btSave.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btSave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btSave.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class
