Imports TALLY.DBControl
Public Class FrmFinishVesselStatistics_Deal
    Inherits System.Windows.Forms.Form

    Public Shared strAgent, strTrade As String
    Public Shared statDate As Date
    Public Shared Flag As Boolean = False

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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbAgent As System.Windows.Forms.ComboBox
    Friend WithEvents cbTrade As System.Windows.Forms.ComboBox
    Friend WithEvents dtpTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbAgent = New System.Windows.Forms.ComboBox()
        Me.cbTrade = New System.Windows.Forms.ComboBox()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "船代公司"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "内外贸"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "统计年月"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbAgent
        '
        Me.cbAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAgent.Location = New System.Drawing.Point(84, 8)
        Me.cbAgent.Name = "cbAgent"
        Me.cbAgent.Size = New System.Drawing.Size(130, 20)
        Me.cbAgent.TabIndex = 3
        '
        'cbTrade
        '
        Me.cbTrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTrade.Location = New System.Drawing.Point(84, 30)
        Me.cbTrade.Name = "cbTrade"
        Me.cbTrade.Size = New System.Drawing.Size(130, 20)
        Me.cbTrade.TabIndex = 4
        '
        'dtpTime
        '
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTime.Location = New System.Drawing.Point(84, 52)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.Size = New System.Drawing.Size(130, 21)
        Me.dtpTime.TabIndex = 5
        Me.dtpTime.Value = New Date(2004, 3, 24, 0, 0, 0, 0)
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(114, 80)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 287
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(46, 80)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 286
        Me.btSave.Text = "确认"
        '
        'FrmFinishVesselStatistics_Deal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(224, 109)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btQuit, Me.btSave, Me.dtpTime, Me.cbTrade, Me.cbAgent, Me.Label3, Me.Label2, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFinishVesselStatistics_Deal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "分船代完船情况统计表信息 处理"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmFinishVesselStatistics_Deal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sqlAgent As String = "SELECT CODE_SHIP_AGENT, SHIPAGENT_CHA, SHIPAGENT_ENG FROM CODE_SHIP_AGENT ORDER BY CODE_SHIP_AGENT"
        Dim dvAgent As New DataView()
        dvAgent = Filldata(sqlAgent)
        Me.cbAgent.DataSource = dvAgent
        Me.cbAgent.DisplayMember = "SHIPAGENT_CHA"
        Me.cbAgent.ValueMember = "CODE_SHIP_AGENT"

        Dim sqlTrade As String = "SELECT S_Trade, Trade FROM Code_Trade ORDER BY S_Trade"
        Dim dvTrade As New DataView()
        dvTrade = Filldata(sqlTrade)
        Me.cbTrade.DataSource = dvTrade
        Me.cbTrade.DisplayMember = "Trade"
        Me.cbTrade.ValueMember = "S_Trade"

        Me.dtpTime.CustomFormat = "yyyy年 MM月"
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        strAgent = Me.cbAgent.SelectedValue
        strTrade = Me.cbTrade.SelectedValue
        statDate = Me.dtpTime.Value
        Flag = True
        Me.Close()
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Flag = False
        Me.Close()
    End Sub

    Private Sub cbAgent_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbAgent.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.cbTrade.Focus()
        End If
    End Sub

    Private Sub cbTrade_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbTrade.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.dtpTime.Focus()
        End If
    End Sub

    Private Sub dtpTime_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpTime.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btSave.Focus()
        End If
    End Sub
End Class
