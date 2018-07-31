Imports TALLY.DBControl
Public Class FrmCropEconomyStatistics_Check
    Inherits System.Windows.Forms.Form

    Public Shared Flag As Boolean = False
    Public Shared iYear, iMonth As Integer

    Dim sqlYear, sqlMonth As String
    Dim dvYear As New DataView()
    Dim dvMonth As New DataView()

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
    Public WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents cbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cbMonth As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.cbMonth = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "选择统计年月"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbYear
        '
        Me.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbYear.Location = New System.Drawing.Point(98, 8)
        Me.cbYear.MaxDropDownItems = 20
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(70, 20)
        Me.cbYear.TabIndex = 1
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(121, 40)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 422
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(53, 40)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 421
        Me.btSave.Text = "确认"
        '
        'cbMonth
        '
        Me.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonth.Location = New System.Drawing.Point(168, 8)
        Me.cbMonth.MaxDropDownItems = 20
        Me.cbMonth.Name = "cbMonth"
        Me.cbMonth.Size = New System.Drawing.Size(50, 20)
        Me.cbMonth.TabIndex = 423
        '
        'FrmCropEconomyStatistics_Check
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(228, 71)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbMonth, Me.btQuit, Me.btSave, Me.cbYear, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCropEconomyStatistics_Check"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "局经济效果指标统计表信息 查询"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCropEconomyStatistics_Check_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sqlYear = "SELECT DISTINCT YEAR(YEARMONTH) AS ValueYear, cast(YEAR(YEARMONTH) AS varchar(4)) + '年' AS NameYear FROM REPORT_ECONOMY_TARGET order by ValueYear "
        dvYear = Filldata(sqlYear)
        cbYear.DataSource = dvYear
        cbYear.DisplayMember = "NameYear"
        cbYear.ValueMember = "ValueYear"
        sqlMonth = "SELECT DISTINCT MONTH(YEARMONTH) AS ValueMonth, CAST(MONTH(YEARMONTH) AS varchar(4)) + '月' AS NameMonth FROM REPORT_ECONOMY_TARGET order by ValueMonth "
        dvMonth = Filldata(sqlMonth)
        cbMonth.DataSource = dvMonth
        cbMonth.DisplayMember = "NameMonth"
        cbMonth.ValueMember = "ValueMonth"
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        If cbYear.SelectedValue <> Nothing Then
            iYear = Me.cbYear.SelectedValue
            iMonth = Me.cbMonth.SelectedValue
            Flag = True
            Me.Close()
        End If
    End Sub

    Private Sub cbYear_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbYear.Leave
        sqlMonth = "SELECT DISTINCT MONTH(YEARMONTH) AS ValueMonth, CAST(MONTH(YEARMONTH) AS varchar(4)) + '月' AS NameMonth FROM REPORT_ECONOMY_TARGET where YEAR(YEARMONTH)='" & cbYear.SelectedValue & "' order by ValueMonth "
        dvMonth = Filldata(sqlMonth)
        cbMonth.DataSource = dvMonth
        cbMonth.DisplayMember = "NameMonth"
        cbMonth.ValueMember = "ValueMonth"
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Flag = False
        Me.Close()
    End Sub

    Private Sub cbYear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbYear.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.cbMonth.Focus()
        End If
    End Sub

    Private Sub cbMonth_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbMonth.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btSave.Focus()
        End If
    End Sub
End Class
