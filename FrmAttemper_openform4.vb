Imports TALLY.DBControl
Public Class FrmAttemper_openform4
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
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TxtBERTHNO As System.Windows.Forms.TextBox
    Friend WithEvents CmbDEPT_CODE As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabBERTHNO As System.Windows.Forms.Label
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtBERTHNO = New System.Windows.Forms.TextBox()
        Me.CmbDEPT_CODE = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabBERTHNO = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(94, 7)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 20)
        Me.Label20.TabIndex = 72
        Me.Label20.Text = "现泊位号："
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(7, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 20)
        Me.Label22.TabIndex = 73
        Me.Label22.Text = "所属理货站"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtBERTHNO
        '
        Me.TxtBERTHNO.Location = New System.Drawing.Point(160, 7)
        Me.TxtBERTHNO.MaxLength = 2
        Me.TxtBERTHNO.Name = "TxtBERTHNO"
        Me.TxtBERTHNO.Size = New System.Drawing.Size(54, 21)
        Me.TxtBERTHNO.TabIndex = 0
        Me.TxtBERTHNO.Text = ""
        '
        'CmbDEPT_CODE
        '
        Me.CmbDEPT_CODE.Location = New System.Drawing.Point(77, 32)
        Me.CmbDEPT_CODE.Name = "CmbDEPT_CODE"
        Me.CmbDEPT_CODE.Size = New System.Drawing.Size(138, 20)
        Me.CmbDEPT_CODE.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "原泊位号："
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabBERTHNO
        '
        Me.LabBERTHNO.Location = New System.Drawing.Point(70, 7)
        Me.LabBERTHNO.Name = "LabBERTHNO"
        Me.LabBERTHNO.Size = New System.Drawing.Size(20, 20)
        Me.LabBERTHNO.TabIndex = 4
        Me.LabBERTHNO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(113, 59)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(65, 24)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "取消"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(44, 59)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(65, 24)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "确认"
        '
        'FrmAttemper_openform4
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(222, 89)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnQuit, Me.btnSave, Me.Label20, Me.Label22, Me.TxtBERTHNO, Me.CmbDEPT_CODE, Me.Label1, Me.LabBERTHNO})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAttemper_openform4"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "移泊"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As New DataSet()
    Dim dw As New DataView()
    Dim sqlda As New SqlClient.SqlDataAdapter()

    Private Sub FrmAttemper_openform4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillDEPT_CODE()
        On Error GoTo Err
        Dim sqlstr As String
        sqlstr = "select SHIP_ID,BERTHNO,DEPT_CODE from SShip where SHIP_ID=" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)
        If dw.Count > 0 Then
            LabBERTHNO.Text = ds.Tables(0).Rows(0).Item("BERTHNO")
            CmbDEPT_CODE.SelectedValue = ds.Tables(0).Rows(0).Item("DEPT_CODE")
        End If
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Len(Trim(TxtBERTHNO.Text)) > 0 Then
                If MsgBox("你确认要修改吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
                    If IsNumeric(Trim(TxtBERTHNO.Text)) Then
                        ds.Tables(0).Rows(0).Item("BERTHNO") = Trim(TxtBERTHNO.Text)
                    Else
                        MsgBox("泊位号一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                        Exit Sub
                    End If
                    ds.Tables(0).Rows(0).Item("DEPT_CODE") = CmbDEPT_CODE.SelectedValue
                    sqlda.Update(ds)
                    GL_Str = 1
                    Me.Close()
                Else
                    GL_Str = 0
                End If
            Else
                MsgBox("泊位号不能为空！")
            End If
            'GL_Str = Trim(TxtBERTHNO.Text)
            ' GL_Time = DTPBERTH_TIME.Value
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FillDEPT_CODE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "select DEPT_CODE,DEPT_NAME from DEPARTMENT where DEPT_CODE like '26.11%' "
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbDEPT_CODE.DataSource = dvc
        Me.CmbDEPT_CODE.DisplayMember = "DEPT_NAME"
        Me.CmbDEPT_CODE.ValueMember = "DEPT_CODE"
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub TxtBERTHNO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBERTHNO.TextChanged
        Dim sqldc As String
        Dim sqldv As String
        Dim dvc As DataView
        Dim dsc As New DataSet()

        sqldv = "SELECT DEPT_CODE FROM CODE_BERTH WHERE CODE_BERTH = '" & TxtBERTHNO.Text & "' "
        dvc = Getdata(sqldv, dsc)
        If dsc.Tables(0).DefaultView.Count > 0 Then
            Me.CmbDEPT_CODE.SelectedValue = dsc.Tables(0).Rows(0).Item("Dept_Code")
        End If
    End Sub
End Class
