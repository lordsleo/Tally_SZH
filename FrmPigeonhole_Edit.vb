Imports TALLY.DBControl
Public Class FrmPigeonhole_Edit
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim dw As New DataView()
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
    Friend WithEvents TxtVOYAGE As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtBERTHNO As System.Windows.Forms.TextBox
    Friend WithEvents TxtSHIP_ID As System.Windows.Forms.TextBox
    Friend WithEvents TXTV_ID As System.Windows.Forms.TextBox
    Friend WithEvents TxtCHI_VESSEL As System.Windows.Forms.TextBox
    Friend WithEvents TxtENG_VESSEL As System.Windows.Forms.TextBox
    Friend WithEvents TxtUSER_NAME As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TxtFILE_NO As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTPFile_Time As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TxtVOYAGE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtBERTHNO = New System.Windows.Forms.TextBox()
        Me.TxtSHIP_ID = New System.Windows.Forms.TextBox()
        Me.TXTV_ID = New System.Windows.Forms.TextBox()
        Me.TxtCHI_VESSEL = New System.Windows.Forms.TextBox()
        Me.TxtENG_VESSEL = New System.Windows.Forms.TextBox()
        Me.TxtUSER_NAME = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TxtFILE_NO = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.DTPFile_Time = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtVOYAGE
        '
        Me.TxtVOYAGE.Location = New System.Drawing.Point(212, 3)
        Me.TxtVOYAGE.MaxLength = 6
        Me.TxtVOYAGE.Name = "TxtVOYAGE"
        Me.TxtVOYAGE.ReadOnly = True
        Me.TxtVOYAGE.Size = New System.Drawing.Size(94, 21)
        Me.TxtVOYAGE.TabIndex = 6
        Me.TxtVOYAGE.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(157, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "航次"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(158, 81)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(65, 24)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "取消"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(88, 81)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(65, 24)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "确定"
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(157, 27)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 20)
        Me.Label20.TabIndex = 63
        Me.Label20.Text = "泊位号"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtBERTHNO
        '
        Me.TxtBERTHNO.Location = New System.Drawing.Point(212, 26)
        Me.TxtBERTHNO.MaxLength = 2
        Me.TxtBERTHNO.Name = "TxtBERTHNO"
        Me.TxtBERTHNO.ReadOnly = True
        Me.TxtBERTHNO.Size = New System.Drawing.Size(94, 21)
        Me.TxtBERTHNO.TabIndex = 7
        Me.TxtBERTHNO.Text = ""
        '
        'TxtSHIP_ID
        '
        Me.TxtSHIP_ID.Location = New System.Drawing.Point(12, 84)
        Me.TxtSHIP_ID.MaxLength = 4
        Me.TxtSHIP_ID.Name = "TxtSHIP_ID"
        Me.TxtSHIP_ID.ReadOnly = True
        Me.TxtSHIP_ID.Size = New System.Drawing.Size(22, 21)
        Me.TxtSHIP_ID.TabIndex = 37
        Me.TxtSHIP_ID.TabStop = False
        Me.TxtSHIP_ID.Text = ""
        Me.TxtSHIP_ID.Visible = False
        '
        'TXTV_ID
        '
        Me.TXTV_ID.Location = New System.Drawing.Point(34, 84)
        Me.TXTV_ID.MaxLength = 4
        Me.TXTV_ID.Name = "TXTV_ID"
        Me.TXTV_ID.ReadOnly = True
        Me.TXTV_ID.Size = New System.Drawing.Size(22, 21)
        Me.TXTV_ID.TabIndex = 38
        Me.TXTV_ID.TabStop = False
        Me.TXTV_ID.Text = ""
        Me.TXTV_ID.Visible = False
        '
        'TxtCHI_VESSEL
        '
        Me.TxtCHI_VESSEL.Location = New System.Drawing.Point(59, 3)
        Me.TxtCHI_VESSEL.MaxLength = 40
        Me.TxtCHI_VESSEL.Name = "TxtCHI_VESSEL"
        Me.TxtCHI_VESSEL.ReadOnly = True
        Me.TxtCHI_VESSEL.Size = New System.Drawing.Size(94, 21)
        Me.TxtCHI_VESSEL.TabIndex = 3
        Me.TxtCHI_VESSEL.TabStop = False
        Me.TxtCHI_VESSEL.Text = ""
        '
        'TxtENG_VESSEL
        '
        Me.TxtENG_VESSEL.Location = New System.Drawing.Point(59, 26)
        Me.TxtENG_VESSEL.MaxLength = 50
        Me.TxtENG_VESSEL.Name = "TxtENG_VESSEL"
        Me.TxtENG_VESSEL.ReadOnly = True
        Me.TxtENG_VESSEL.Size = New System.Drawing.Size(94, 21)
        Me.TxtENG_VESSEL.TabIndex = 4
        Me.TxtENG_VESSEL.TabStop = False
        Me.TxtENG_VESSEL.Text = ""
        '
        'TxtUSER_NAME
        '
        Me.TxtUSER_NAME.Location = New System.Drawing.Point(56, 84)
        Me.TxtUSER_NAME.Name = "TxtUSER_NAME"
        Me.TxtUSER_NAME.ReadOnly = True
        Me.TxtUSER_NAME.Size = New System.Drawing.Size(22, 21)
        Me.TxtUSER_NAME.TabIndex = 39
        Me.TxtUSER_NAME.TabStop = False
        Me.TxtUSER_NAME.Text = ""
        Me.TxtUSER_NAME.Visible = False
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(4, 28)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(54, 20)
        Me.Label26.TabIndex = 75
        Me.Label26.Text = "英文船名"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(4, 4)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(54, 20)
        Me.Label27.TabIndex = 76
        Me.Label27.Text = "中文船名"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtFILE_NO
        '
        Me.TxtFILE_NO.Location = New System.Drawing.Point(59, 50)
        Me.TxtFILE_NO.MaxLength = 10
        Me.TxtFILE_NO.Multiline = True
        Me.TxtFILE_NO.Name = "TxtFILE_NO"
        Me.TxtFILE_NO.Size = New System.Drawing.Size(94, 21)
        Me.TxtFILE_NO.TabIndex = 5
        Me.TxtFILE_NO.Text = ""
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(4, 52)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(54, 20)
        Me.Label28.TabIndex = 65
        Me.Label28.Text = "档案号"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTPFile_Time
        '
        Me.DTPFile_Time.CustomFormat = "yyyy/MM/dd"
        Me.DTPFile_Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFile_Time.Location = New System.Drawing.Point(212, 50)
        Me.DTPFile_Time.Name = "DTPFile_Time"
        Me.DTPFile_Time.Size = New System.Drawing.Size(94, 21)
        Me.DTPFile_Time.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(157, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "归档时间"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmPigeonhole_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(310, 111)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.DTPFile_Time, Me.TxtVOYAGE, Me.Label1, Me.btnQuit, Me.btnSave, Me.Label20, Me.TxtBERTHNO, Me.TxtSHIP_ID, Me.TXTV_ID, Me.TxtCHI_VESSEL, Me.TxtENG_VESSEL, Me.TxtUSER_NAME, Me.Label26, Me.Label27, Me.TxtFILE_NO, Me.Label28, Me.Label2})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPigeonhole_Edit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "资料归档_归档"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmSShip_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim sqlstr As String

        sqlstr = "select * from SShip where SHIP_ID=" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        If dw.Count > 0 Then
            TxtCHI_VESSEL.Text = ds.Tables(0).Rows(0).Item("CHI_VESSEL")
            TxtENG_VESSEL.Text = ds.Tables(0).Rows(0).Item("ENG_VESSEL")
            TxtVOYAGE.Text = ds.Tables(0).Rows(0).Item("VOYAGE")
            TxtBERTHNO.Text = ds.Tables(0).Rows(0).Item("BERTHNO")
            TxtFILE_NO.Text = ds.Tables(0).Rows(0).Item("FILE_NO")
        End If

        DTPFile_Time.Focus()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Len(Trim(TxtFILE_NO.Text)) > 0 Then
                If IsNumeric(Trim(TxtFILE_NO.Text)) Then
                Else
                    MsgBox("档案号栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                    Exit Sub
                End If
                If MsgBox("你确认要归档吗？", MsgBoxStyle.YesNo + vbInformation, "提示") = MsgBoxResult.Yes Then

                    ds.Tables(0).Rows(0).Item("SHIP_STATU") = "4"
                    ds.Tables(0).Rows(0).Item("File_Time") = DTPFile_Time.Value
                    ds.Tables(0).Rows(0).Item("FILE_NO") = Trim(TxtFILE_NO.Text)
                    sqlda.Update(ds)
                    Me.Close()
                End If
            Else
                MsgBox("档案号不能为空！", MsgBoxStyle.Exclamation, "提示")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

End Class
