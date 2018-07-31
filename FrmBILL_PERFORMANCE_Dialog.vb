Imports TALLY.DBControl
Public Class FrmBILL_PERFORMANCE_Dialog
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btResume As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbDEPT_CODE As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTPTIME_FROM As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPTIME_TO As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DTPTIME_FROM = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        Me.btResume = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbDEPT_CODE = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DTPTIME_TO = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'DTPTIME_FROM
        '
        Me.DTPTIME_FROM.CustomFormat = "yyyy年  MM月"
        Me.DTPTIME_FROM.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPTIME_FROM.Location = New System.Drawing.Point(71, 30)
        Me.DTPTIME_FROM.Name = "DTPTIME_FROM"
        Me.DTPTIME_FROM.Size = New System.Drawing.Size(105, 21)
        Me.DTPTIME_FROM.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(11, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 18)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "起始时间"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(98, 85)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 4
        Me.btQuit.Text = "取消"
        '
        'btResume
        '
        Me.btResume.Location = New System.Drawing.Point(30, 85)
        Me.btResume.Name = "btResume"
        Me.btResume.Size = New System.Drawing.Size(65, 24)
        Me.btResume.TabIndex = 3
        Me.btResume.Text = "确认"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "部门"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbDEPT_CODE
        '
        Me.CmbDEPT_CODE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDEPT_CODE.Location = New System.Drawing.Point(71, 5)
        Me.CmbDEPT_CODE.Name = "CmbDEPT_CODE"
        Me.CmbDEPT_CODE.Size = New System.Drawing.Size(105, 20)
        Me.CmbDEPT_CODE.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 18)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "截止时间"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTPTIME_TO
        '
        Me.DTPTIME_TO.CustomFormat = "yyyy年  MM月"
        Me.DTPTIME_TO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPTIME_TO.Location = New System.Drawing.Point(71, 56)
        Me.DTPTIME_TO.Name = "DTPTIME_TO"
        Me.DTPTIME_TO.Size = New System.Drawing.Size(105, 21)
        Me.DTPTIME_TO.TabIndex = 2
        '
        'FrmBILL_PERFORMANCE_Dialog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(192, 117)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbDEPT_CODE)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btResume)
        Me.Controls.Add(Me.DTPTIME_FROM)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTPTIME_TO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBILL_PERFORMANCE_Dialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "杂项费收统计_处理"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillDEPT_CODE()

    End Sub

    Private Sub btResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResume.Click
        If MsgBox("你确认要处理杂项费收数据吗？", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "提示") = MsgBoxResult.Yes Then

            ExecSql("exec sp_BILL_PERFORMANCE '" & DTPTIME_FROM.Value & "','" & DTPTIME_TO.Value & "','" & G_DeptCode & "'")
            GL_Date = DTPTIME_FROM.Value
            GL_Date1 = DTPTIME_TO.Value
            Me.Close()
        End If
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub FillDEPT_CODE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "select DEPT_CODE,DEPT_NAME from DEPARTMENT where DEPT_CODE LIKE '" & G_DeptCode & "%' "
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbDEPT_CODE.DataSource = dvc
        Me.CmbDEPT_CODE.DisplayMember = "DEPT_NAME"
        Me.CmbDEPT_CODE.ValueMember = "DEPT_CODE"
    End Sub

End Class
