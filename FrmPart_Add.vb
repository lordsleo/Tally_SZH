Imports TALLY.DBControl
Public Class FrmPart_Add
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_PART_NAME As System.Windows.Forms.TextBox
    Friend WithEvents CMD_Cance As System.Windows.Forms.Button
    Friend WithEvents CMD_ADD As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescr As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_PART_NAME = New System.Windows.Forms.TextBox()
        Me.CMD_Cance = New System.Windows.Forms.Button()
        Me.CMD_ADD = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescr = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(2, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "角色名称"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt_PART_NAME
        '
        Me.Txt_PART_NAME.Location = New System.Drawing.Point(62, 8)
        Me.Txt_PART_NAME.MaxLength = 30
        Me.Txt_PART_NAME.Name = "Txt_PART_NAME"
        Me.Txt_PART_NAME.Size = New System.Drawing.Size(156, 21)
        Me.Txt_PART_NAME.TabIndex = 1
        Me.Txt_PART_NAME.Text = ""
        '
        'CMD_Cance
        '
        Me.CMD_Cance.BackColor = System.Drawing.Color.Transparent
        Me.CMD_Cance.Location = New System.Drawing.Point(112, 70)
        Me.CMD_Cance.Name = "CMD_Cance"
        Me.CMD_Cance.Size = New System.Drawing.Size(65, 24)
        Me.CMD_Cance.TabIndex = 20
        Me.CMD_Cance.Text = "取消"
        '
        'CMD_ADD
        '
        Me.CMD_ADD.BackColor = System.Drawing.Color.Transparent
        Me.CMD_ADD.Location = New System.Drawing.Point(44, 70)
        Me.CMD_ADD.Name = "CMD_ADD"
        Me.CMD_ADD.Size = New System.Drawing.Size(65, 24)
        Me.CMD_ADD.TabIndex = 19
        Me.CMD_ADD.Text = "确认"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 14)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "描述"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDescr
        '
        Me.txtDescr.Location = New System.Drawing.Point(62, 40)
        Me.txtDescr.MaxLength = 100
        Me.txtDescr.Name = "txtDescr"
        Me.txtDescr.Size = New System.Drawing.Size(156, 21)
        Me.txtDescr.TabIndex = 22
        Me.txtDescr.Text = ""
        '
        'FrmPart_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(222, 101)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtDescr, Me.Label2, Me.CMD_Cance, Me.CMD_ADD, Me.Txt_PART_NAME, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPart_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "角色设置——角色添加"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()

    Private Sub FrmPart_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim sqlstr As String
        sqlstr = "SELECT * FROM SYSTEM_PART where Part_ID=" & ID
        Dim dv As DataView = Updatedata(sqlda, sqlstr, ds)
        Txt_PART_NAME.Text = ds.Tables(0).Rows(0).Item("Part_Name")
        txtDescr.Text = ds.Tables(0).Rows(0).Item("DESCR")
Err:
        Resume Next
    End Sub


    Private Sub CMD_ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_ADD.Click
        Try
            Dim dsSave As New DataSet()
            If Getdata("SELECT * FROM SYSTEM_PART where Part_Name= '" & Trim(Txt_PART_NAME.Text) & "'", dsSave).Count > 0 Then
                MsgBox("可能已存在此角色信息,请注意检查!")
                Exit Sub
            End If
            If Len(Trim(Txt_PART_NAME.Text)) > 0 Then
                Dim row As DataRow
                row = ds.Tables(0).NewRow()
                row("PART_NAME") = Trim(Me.Txt_PART_NAME.Text)
                row("DESCR") = Trim(txtDescr.Text)
                ds.Tables(0).Rows.Add(row)
                sqlda.Update(ds)
                Me.Close()
            Else
                MsgBox("角色名称不能为空!,请注意检查!")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly)
        End Try

    End Sub

    Private Sub CMD_Cance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_Cance.Click
        Me.Close()
    End Sub
End Class
