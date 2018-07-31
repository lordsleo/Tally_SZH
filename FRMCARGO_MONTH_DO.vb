Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FRMCARGO_MONTH_DO
    Inherits System.Windows.Forms.Form
    Dim dw As New DataView()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dswork_time As New DataSet()
    Dim dsdeptcode As New DataSet()

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents BTOK As System.Windows.Forms.Button
    Friend WithEvents CombDEPTCODE As System.Windows.Forms.ComboBox
    Friend WithEvents DTPMonth As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CombDEPTCODE = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTQUIT = New System.Windows.Forms.Button()
        Me.BTOK = New System.Windows.Forms.Button()
        Me.DTPMonth = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'CombDEPTCODE
        '
        Me.CombDEPTCODE.Location = New System.Drawing.Point(83, 40)
        Me.CombDEPTCODE.Name = "CombDEPTCODE"
        Me.CombDEPTCODE.Size = New System.Drawing.Size(110, 20)
        Me.CombDEPTCODE.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(21, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "月份"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(21, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "部门"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(114, 76)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 43
        Me.BTQUIT.Text = "取消"
        '
        'BTOK
        '
        Me.BTOK.Location = New System.Drawing.Point(36, 76)
        Me.BTOK.Name = "BTOK"
        Me.BTOK.Size = New System.Drawing.Size(65, 24)
        Me.BTOK.TabIndex = 42
        Me.BTOK.Text = "确认"
        '
        'DTPMonth
        '
        Me.DTPMonth.CustomFormat = "yyyy-MM-dd"
        Me.DTPMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPMonth.Location = New System.Drawing.Point(83, 13)
        Me.DTPMonth.Name = "DTPMonth"
        Me.DTPMonth.Size = New System.Drawing.Size(110, 21)
        Me.DTPMonth.TabIndex = 44
        Me.DTPMonth.Value = New Date(2004, 3, 30, 0, 0, 0, 0)
        '
        'FRMCARGO_MONTH_DO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(214, 113)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.DTPMonth, Me.BTQUIT, Me.BTOK, Me.Label2, Me.Label1, Me.CombDEPTCODE})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMCARGO_MONTH_DO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "件杂货理货类别统计表_处理"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRMCARGO_MONTH_DO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dw = Getdata("select DEPT_CODE,dept_name from department where dept_code like '" & G_DeptCode & "%'", dsdeptcode)
            CombDEPTCODE.DataSource = dsdeptcode.Tables(0).DefaultView
            CombDEPTCODE.DisplayMember = "dept_name"
            CombDEPTCODE.ValueMember = "DEPT_CODE"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOK.Click
        DS_DO.Reset()
        dw = Getdata("exec spcargo_month '" & DTPMonth.Value & "','" & CombDEPTCODE.SelectedValue & "'", DS_DO)
        LISTTIME = DTPMonth.Value
        LIST_DEPTNAME = CombDEPTCODE.Text
        Call BTQUIT_Click(sender, e)
    End Sub

    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub

    
End Class
