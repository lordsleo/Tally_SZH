Imports Tally.DBControl
Public Class FrmSShip_Dept
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        AddHandler TxtCHI_VESSEL.KeyDown, AddressOf FrmSShip_Dept_KeyDown
        AddHandler TxtENG_VESSEL.KeyDown, AddressOf FrmSShip_Dept_KeyDown
        AddHandler TxtVOYAGE.KeyDown, AddressOf FrmSShip_Dept_KeyDown
        AddHandler CmbDEPT_CODE.KeyDown, AddressOf FrmSShip_Dept_KeyDown

    End Sub

    '窗体重写 dispose 以清理组件列表。
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

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents TxtVOYAGE As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCHI_VESSEL As System.Windows.Forms.TextBox
    Friend WithEvents TxtENG_VESSEL As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CmbDEPT_CODE As System.Windows.Forms.ComboBox
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TxtVOYAGE = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtCHI_VESSEL = New System.Windows.Forms.TextBox
        Me.TxtENG_VESSEL = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.CmbDEPT_CODE = New System.Windows.Forms.ComboBox
        Me.btnQuit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TxtVOYAGE
        '
        Me.TxtVOYAGE.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TxtVOYAGE.Location = New System.Drawing.Point(72, 56)
        Me.TxtVOYAGE.MaxLength = 17
        Me.TxtVOYAGE.Name = "TxtVOYAGE"
        Me.TxtVOYAGE.ReadOnly = True
        Me.TxtVOYAGE.Size = New System.Drawing.Size(118, 21)
        Me.TxtVOYAGE.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "航次"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCHI_VESSEL
        '
        Me.TxtCHI_VESSEL.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TxtCHI_VESSEL.Location = New System.Drawing.Point(72, 7)
        Me.TxtCHI_VESSEL.MaxLength = 40
        Me.TxtCHI_VESSEL.Name = "TxtCHI_VESSEL"
        Me.TxtCHI_VESSEL.ReadOnly = True
        Me.TxtCHI_VESSEL.Size = New System.Drawing.Size(118, 21)
        Me.TxtCHI_VESSEL.TabIndex = 3
        '
        'TxtENG_VESSEL
        '
        Me.TxtENG_VESSEL.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TxtENG_VESSEL.Location = New System.Drawing.Point(72, 32)
        Me.TxtENG_VESSEL.MaxLength = 50
        Me.TxtENG_VESSEL.Name = "TxtENG_VESSEL"
        Me.TxtENG_VESSEL.ReadOnly = True
        Me.TxtENG_VESSEL.Size = New System.Drawing.Size(118, 21)
        Me.TxtENG_VESSEL.TabIndex = 4
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(9, 32)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(64, 19)
        Me.Label26.TabIndex = 80
        Me.Label26.Text = "英文船名"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(9, 7)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 21)
        Me.Label27.TabIndex = 81
        Me.Label27.Text = "中文船名"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(10, 80)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 20)
        Me.Label22.TabIndex = 84
        Me.Label22.Text = "所属理货站"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbDEPT_CODE
        '
        Me.CmbDEPT_CODE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDEPT_CODE.Location = New System.Drawing.Point(72, 80)
        Me.CmbDEPT_CODE.Name = "CmbDEPT_CODE"
        Me.CmbDEPT_CODE.Size = New System.Drawing.Size(120, 20)
        Me.CmbDEPT_CODE.TabIndex = 0
        '
        'btnQuit
        '
        Me.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuit.Location = New System.Drawing.Point(103, 110)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(62, 23)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "取消"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(34, 110)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(62, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "确定"
        '
        'FrmSShip_Dept
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btnQuit
        Me.ClientSize = New System.Drawing.Size(234, 150)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.CmbDEPT_CODE)
        Me.Controls.Add(Me.TxtVOYAGE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCHI_VESSEL)
        Me.Controls.Add(Me.TxtENG_VESSEL)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSShip_Dept"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "变更理货站"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public blSave As Boolean    '保存标志
    Public strDept As String

    Private Sub FrmSShip_Dept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet
        sqldc = "select DEPT_CODE,DEPT_NAME from DEPARTMENT where dept_code like '26.11.1%' or dept_code='26.12'  or dept_code='27' "
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbDEPT_CODE.DataSource = dvc
        Me.CmbDEPT_CODE.DisplayMember = "DEPT_NAME"
        Me.CmbDEPT_CODE.ValueMember = "DEPT_CODE"
        Me.CmbDEPT_CODE.SelectedValue = strDept
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If MessageBox.Show("确定要变更吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            Dim sqlUpdate As String
            sqlUpdate = "update SSHIP set DEPT_CODE='" & Me.CmbDEPT_CODE.SelectedValue & "' where SHIP_ID=" & ID
            ExecSql(sqlUpdate)
            blSave = True
            Me.Close()
        End If
    End Sub

    Private Sub FrmSShip_Dept_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Me.TxtCHI_VESSEL.Focused Then
            Me.TxtENG_VESSEL.Focus()
        ElseIf Me.TxtENG_VESSEL.Focused Then
            Me.TxtVOYAGE.Focus()
        ElseIf Me.TxtVOYAGE.Focused Then
            Me.CmbDEPT_CODE.Focus()
        ElseIf Me.CmbDEPT_CODE.Focused Then
            Me.btnSave.Focus()
        End If
    End Sub
End Class
