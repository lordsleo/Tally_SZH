Imports TALLY.DBControl
Public Class FrmOperationManage_Add
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_TableName As System.Windows.Forms.TextBox
    Friend WithEvents tb_SQL As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tb_TableName = New System.Windows.Forms.TextBox
        Me.tb_SQL = New System.Windows.Forms.TextBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(94, 156)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(65, 24)
        Me.btnSave.TabIndex = 131
        Me.btnSave.Text = "确认"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 23)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "表 名"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 23)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "SQL语句"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_TableName
        '
        Me.tb_TableName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_TableName.Location = New System.Drawing.Point(76, 6)
        Me.tb_TableName.Name = "tb_TableName"
        Me.tb_TableName.Size = New System.Drawing.Size(238, 21)
        Me.tb_TableName.TabIndex = 129
        Me.tb_TableName.Text = ""
        '
        'tb_SQL
        '
        Me.tb_SQL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_SQL.Location = New System.Drawing.Point(76, 38)
        Me.tb_SQL.Multiline = True
        Me.tb_SQL.Name = "tb_SQL"
        Me.tb_SQL.Size = New System.Drawing.Size(238, 110)
        Me.tb_SQL.TabIndex = 130
        Me.tb_SQL.Text = ""
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(238, 156)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(65, 24)
        Me.btnClose.TabIndex = 132
        Me.btnClose.Text = "关闭"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(166, 156)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(65, 24)
        Me.btnClear.TabIndex = 133
        Me.btnClear.Text = "清空"
        '
        'FrmOperationManage_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(346, 184)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.tb_SQL)
        Me.Controls.Add(Me.tb_TableName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOperationManage_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "数据库操作_增加"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        Me.StartPosition = FormStartPosition.CenterScreen
        sql = "select * from szh_client_updateinfo where update_id=" & ID
        Updatedata(sqlda, sql, ds)
        Me.tb_TableName.Text = ds.Tables(0).Rows(0).Item("update_table_info")
        Me.tb_SQL.Text = ds.Tables(0).Rows(0).Item("update_text")
        Me.tb_TableName.Focus()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Trim(Me.tb_TableName.Text) = "" Or Trim(Me.tb_SQL.Text) = "" Then
                MsgBox("请填写完整的信息!")
                Exit Sub
            End If

            Dim str As String
            str = "您要保存的SQL语句如下:" & Chr(13) & Trim(Me.tb_SQL.Text) & Chr(13) & "请检查正确性后确认。"
            If MsgBox(str, MsgBoxStyle.OKCancel) = MsgBoxResult.OK Then
                str = Trim(Me.tb_SQL.Text)
                str = str.Replace("'", "''")
                CodeOperation(Trim(Me.tb_TableName.Text), str)
                MsgBox("保存成功!")
                Me.Close()
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.tb_TableName.Text() = ""
        Me.tb_SQL.Text = ""
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub tb_TableName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_TableName.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.tb_SQL.Focus()
        End If
    End Sub

    Private Sub tb_SQL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_SQL.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btnSave.Focus()
        End If
    End Sub
End Class
