Imports TALLY.DBControl
Public Class FrmPart_Del
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
    Friend WithEvents CMD_Cance As System.Windows.Forms.Button
    Friend WithEvents CMD_Save As System.Windows.Forms.Button
    Friend WithEvents txtDescr As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_PART_NAME As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CMD_Cance = New System.Windows.Forms.Button()
        Me.CMD_Save = New System.Windows.Forms.Button()
        Me.txtDescr = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_PART_NAME = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CMD_Cance
        '
        Me.CMD_Cance.BackColor = System.Drawing.Color.Transparent
        Me.CMD_Cance.Location = New System.Drawing.Point(115, 72)
        Me.CMD_Cance.Name = "CMD_Cance"
        Me.CMD_Cance.Size = New System.Drawing.Size(65, 24)
        Me.CMD_Cance.TabIndex = 20
        Me.CMD_Cance.Text = "取消"
        '
        'CMD_Save
        '
        Me.CMD_Save.BackColor = System.Drawing.Color.Transparent
        Me.CMD_Save.Location = New System.Drawing.Point(45, 72)
        Me.CMD_Save.Name = "CMD_Save"
        Me.CMD_Save.Size = New System.Drawing.Size(65, 24)
        Me.CMD_Save.TabIndex = 19
        Me.CMD_Save.Text = "确认"
        '
        'txtDescr
        '
        Me.txtDescr.Location = New System.Drawing.Point(66, 40)
        Me.txtDescr.MaxLength = 100
        Me.txtDescr.Name = "txtDescr"
        Me.txtDescr.Size = New System.Drawing.Size(156, 21)
        Me.txtDescr.TabIndex = 26
        Me.txtDescr.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 14)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "描述"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt_PART_NAME
        '
        Me.Txt_PART_NAME.Location = New System.Drawing.Point(66, 8)
        Me.Txt_PART_NAME.MaxLength = 30
        Me.Txt_PART_NAME.Name = "Txt_PART_NAME"
        Me.Txt_PART_NAME.Size = New System.Drawing.Size(156, 21)
        Me.Txt_PART_NAME.TabIndex = 24
        Me.Txt_PART_NAME.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(6, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "角色名称"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmPart_Del
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(224, 103)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtDescr, Me.Label2, Me.Txt_PART_NAME, Me.Label1, Me.CMD_Cance, Me.CMD_Save})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPart_Del"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "角色设置——角色删除"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As New DataSet()
    Dim dsw As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dv As DataView
    Dim sqlstr As String
    Private Sub FrmPart_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err

        sqlstr = "select * from SYSTEM_PART where PART_ID=" & ID & ""
        dv = DBControl.Updatedata(sqlda, sqlstr, ds)

        Me.Txt_PART_NAME.Text = dv(0)("PART_NAME")
        Me.txtDescr.Text = dv(0)("Descr")
        If ID = 1 Then
            CMD_Save.Enabled = False
        Else
            CMD_Save.Enabled = True
        End If
Err:
        Resume Next
    End Sub



    Private Sub CMD_Cance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_Cance.Click
        Me.Close()
    End Sub


    Private Sub CMD_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_Save.Click
        Try
            If MsgBox("你确认要删除吗？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call OperateHistory(G_DeptName, Now, G_User, "删除", "SYSTEM_PART", ID, "PART_ID")
                dv(0).Delete()
                sqlda.Update(ds)
                Me.Close()
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly)
        End Try
    End Sub
End Class
