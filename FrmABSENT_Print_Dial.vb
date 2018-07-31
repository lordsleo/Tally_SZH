Imports TALLY.DBControl
Public Class FrmABSENT_Print_Dial
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
    Friend WithEvents DTPABSENTDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btResume As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbWORK_TYPE As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DTPABSENTDATE = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        Me.btResume = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbWORK_TYPE = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'DTPABSENTDATE
        '
        Me.DTPABSENTDATE.CustomFormat = "yyyy-MM"
        Me.DTPABSENTDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPABSENTDATE.Location = New System.Drawing.Point(60, 30)
        Me.DTPABSENTDATE.Name = "DTPABSENTDATE"
        Me.DTPABSENTDATE.Size = New System.Drawing.Size(88, 21)
        Me.DTPABSENTDATE.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 18)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "日期"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(82, 64)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 3
        Me.btQuit.Text = "取消"
        '
        'btResume
        '
        Me.btResume.Location = New System.Drawing.Point(14, 64)
        Me.btResume.Name = "btResume"
        Me.btResume.Size = New System.Drawing.Size(65, 24)
        Me.btResume.TabIndex = 2
        Me.btResume.Text = "确认"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 18)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "班组"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbWORK_TYPE
        '
        Me.CmbWORK_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbWORK_TYPE.Location = New System.Drawing.Point(60, 6)
        Me.CmbWORK_TYPE.Name = "CmbWORK_TYPE"
        Me.CmbWORK_TYPE.Size = New System.Drawing.Size(88, 20)
        Me.CmbWORK_TYPE.TabIndex = 0
        '
        'FrmABSENT_Print_Dial
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(164, 97)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbWORK_TYPE)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btResume)
        Me.Controls.Add(Me.DTPABSENTDATE)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmABSENT_Print_Dial"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "考勤_打印"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmABSENT_Print_Dialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillWORK_TYPE()

    End Sub

    Private Sub btResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResume.Click
        If Trim(CmbWORK_TYPE.Text) = "管理人员" Then
            GL_Str = "管理人员"
            GL_Date = DTPABSENTDATE.Value
        ElseIf Trim(CmbWORK_TYPE.Text) = "全站人员" Then
            GL_Str = "1"
            GL_Date = DTPABSENTDATE.Value
        Else
            GL_Str = Trim(CmbWORK_TYPE.Text)
            GL_Date = DTPABSENTDATE.Value
        End If
        GL_ID = 1
        Me.Close()
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        GL_ID = -1
        Me.Close()
    End Sub

    Private Sub FillWORK_TYPE()
        Dim i As Integer
        Dim sqldc As String
        Dim dvc As New DataView()
        Dim dsc As New DataSet()

        sqldc = "SELECT WORK_TYPE FROM WORK_BEGIN WHERE DEPT_CODE='" & G_DeptCode & "' ORDER BY TIME_FROM, DayNightMark"
        dvc = DBControl.Getdata(sqldc, dsc)
        'Me.CmbWORK_TYPE.DataSource = dvc
        'Me.CmbWORK_TYPE.DisplayMember = "WORK_TYPE"
        'Me.CmbWORK_TYPE.ValueMember = "WORK_TYPE"
        i = 0
        For i = 0 To dvc.Count - 1
            Me.CmbWORK_TYPE.Items.Add(dvc(i)(0))
        Next
        Me.CmbWORK_TYPE.Items.Add("管理人员")
        If G_DeptCode <> "26.01" Then
            Me.CmbWORK_TYPE.Items.Add("全站人员")
        End If
    End Sub

End Class
