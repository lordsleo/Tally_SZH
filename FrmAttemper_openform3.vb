Imports TALLY.DBControl
Public Class FrmAttemper_openform3
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
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DTPWORKTIME_END As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DTPWORKTIME_END = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(99, 36)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(65, 24)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "取消"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(31, 36)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(65, 24)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "确定"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(4, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 23)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "完工时间"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTPWORKTIME_END
        '
        Me.DTPWORKTIME_END.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DTPWORKTIME_END.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPWORKTIME_END.Location = New System.Drawing.Point(66, 5)
        Me.DTPWORKTIME_END.Name = "DTPWORKTIME_END"
        Me.DTPWORKTIME_END.Size = New System.Drawing.Size(122, 21)
        Me.DTPWORKTIME_END.TabIndex = 0
        '
        'FrmAttemper_openform3
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(194, 65)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnQuit, Me.btnSave, Me.Label12, Me.DTPWORKTIME_END})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAttemper_openform3"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "船舶完工"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As New DataSet()
    Dim dw As New DataView()
    Dim sqlda As New SqlClient.SqlDataAdapter()

    Private Sub FrmAttemper_openform3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim sqlstr As String
        sqlstr = "select SHIP_ID,WORKTIME_END,SHIP_STATU from SShip where SHIP_ID=" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)
        If dw.Count > 0 Then
            DTPWORKTIME_END.Value = ds.Tables(0).Rows(0).Item("WORKTIME_END")
        End If
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If MsgBox("你确认要修改吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
                ds.Tables(0).Rows(0).Item("WORKTIME_END") = DTPWORKTIME_END.Value
                ds.Tables(0).Rows(0).Item("SHIP_STATU") = "3"
                sqlda.Update(ds)
                GL_Str = 1
                Me.Close()
            Else
                GL_Str = 0
            End If
            GL_Time = DTPWORKTIME_END.Value
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
End Class
