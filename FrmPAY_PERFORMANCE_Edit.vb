Imports TALLY.DBControl
Public Class FrmPAY_PERFORMANCE_Edit
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
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btResume As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTPABSENT_Month As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbWORK_NAME As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPERFORMANCE_PAY As System.Windows.Forms.TextBox
    Friend WithEvents TxtPRIZE As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btResume = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.DTPABSENT_Month = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPERFORMANCE_PAY = New System.Windows.Forms.TextBox()
        Me.CmbWORK_NAME = New System.Windows.Forms.ComboBox()
        Me.TxtPRIZE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(89, 108)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 5
        Me.btQuit.Text = "取消"
        '
        'btResume
        '
        Me.btResume.Location = New System.Drawing.Point(21, 108)
        Me.btResume.Name = "btResume"
        Me.btResume.Size = New System.Drawing.Size(65, 24)
        Me.btResume.TabIndex = 4
        Me.btResume.Text = "确认"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(0, 107)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(20, 21)
        Me.txtID.TabIndex = 103
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'DTPABSENT_Month
        '
        Me.DTPABSENT_Month.CustomFormat = "yyyy-MM"
        Me.DTPABSENT_Month.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPABSENT_Month.Location = New System.Drawing.Point(76, 29)
        Me.DTPABSENT_Month.Name = "DTPABSENT_Month"
        Me.DTPABSENT_Month.Size = New System.Drawing.Size(88, 21)
        Me.DTPABSENT_Month.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(10, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 20)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "日期"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "姓名"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "绩效工资"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtPERFORMANCE_PAY
        '
        Me.TxtPERFORMANCE_PAY.Location = New System.Drawing.Point(76, 54)
        Me.TxtPERFORMANCE_PAY.Name = "TxtPERFORMANCE_PAY"
        Me.TxtPERFORMANCE_PAY.Size = New System.Drawing.Size(88, 21)
        Me.TxtPERFORMANCE_PAY.TabIndex = 2
        Me.TxtPERFORMANCE_PAY.Text = ""
        '
        'CmbWORK_NAME
        '
        Me.CmbWORK_NAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbWORK_NAME.Location = New System.Drawing.Point(76, 4)
        Me.CmbWORK_NAME.Name = "CmbWORK_NAME"
        Me.CmbWORK_NAME.Size = New System.Drawing.Size(88, 21)
        Me.CmbWORK_NAME.TabIndex = 0
        '
        'TxtPRIZE
        '
        Me.TxtPRIZE.Location = New System.Drawing.Point(76, 79)
        Me.TxtPRIZE.Name = "TxtPRIZE"
        Me.TxtPRIZE.Size = New System.Drawing.Size(88, 21)
        Me.TxtPRIZE.TabIndex = 3
        Me.TxtPRIZE.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "奖金"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmPAY_PERFORMANCE_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(174, 139)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.CmbWORK_NAME, Me.DTPABSENT_Month, Me.Label5, Me.btQuit, Me.btResume, Me.txtID, Me.Label1, Me.Label2, Me.TxtPERFORMANCE_PAY, Me.TxtPRIZE, Me.Label3})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPAY_PERFORMANCE_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "绩效工资_编辑"
        Me.ResumeLayout(False)

    End Sub

#End Region
    
    Private Sub FrmABSENT_Print_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Call FillWORK_NAME()
        sqlstr = "select * from PAY_PERFORMANCE where ID=" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("ABSENT_history_ID")
            CmbWORK_NAME.SelectedValue = ds.Tables(0).Rows(0).Item("WORK_NO")
            DTPABSENT_Month.Value = ds.Tables(0).Rows(0).Item("YearMonth")
            If Len(Trim(ds.Tables(0).Rows(0).Item("PERFORMANCE_PAY"))) > 0 Then
                TxtPERFORMANCE_PAY.Text = ds.Tables(0).Rows(0).Item("PERFORMANCE_PAY")
            End If
            If Len(Trim(ds.Tables(0).Rows(0).Item("PRIZE"))) > 0 Then
                TxtPRIZE.Text = ds.Tables(0).Rows(0).Item("PRIZE")
            End If
        End If
        TxtPERFORMANCE_PAY.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResume.Click
        Try
            If MsgBox("你确认要修改吗？", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "提示") = MsgBoxResult.Yes Then
                Call OperateHistory(G_DeptName, Now, G_User, "修改", "PAY_PERFORMANCE", Trim(txtID.Text), "ID")
                If Len(Trim(TxtPERFORMANCE_PAY.Text)) > 0 Then

                    If Len(Trim(TxtPERFORMANCE_PAY.Text)) > 0 Then
                        If IsNumeric(Trim(TxtPERFORMANCE_PAY.Text)) Then
                            ds.Tables(0).Rows(0).Item("PERFORMANCE_PAY") = Trim(TxtPERFORMANCE_PAY.Text)
                        Else
                            MsgBox("绩效工资一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                            Exit Sub
                        End If
                    Else
                        ds.Tables(0).Rows(0).Item("PERFORMANCE_PAY") = 0
                    End If
                    If Len(Trim(TxtPRIZE.Text)) > 0 Then
                        If IsNumeric(Trim(TxtPRIZE.Text)) Then
                            ds.Tables(0).Rows(0).Item("PRIZE") = Trim(TxtPRIZE.Text)
                        Else
                            MsgBox("奖金一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                            Exit Sub
                        End If
                    Else
                        ds.Tables(0).Rows(0).Item("PRIZE") = 0
                    End If

                    sqlda.Update(ds)
                    Call btQuit_Click(sender, e)
                End If

            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub FillWORK_NAME()
        Dim sqldc As String
        Dim dvc As New DataView()
        Dim dsc As New DataSet()
        sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE DEPT_CODE='" & G_DeptCode & "' order by NAME "

        Me.CmbWORK_NAME.DataSource = DBControl.Getdata(sqldc, dsc)
        Me.CmbWORK_NAME.DisplayMember = "NAME"
        Me.CmbWORK_NAME.ValueMember = "WORK_NO"
    End Sub

End Class
