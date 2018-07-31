Imports TALLY.DBControl
Public Class FrmREPORT_TALLY_QUALITY_Edit
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
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DTPYEARMONTH As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CmbCODE_TALLY_QUALITY As System.Windows.Forms.ComboBox
    Friend WithEvents TxtITEMB As System.Windows.Forms.TextBox
    Friend WithEvents TxtITEMA As System.Windows.Forms.TextBox
    Friend WithEvents TxtITEMD As System.Windows.Forms.TextBox
    Friend WithEvents TxtITEME As System.Windows.Forms.TextBox
    Friend WithEvents TxtITEMH As System.Windows.Forms.TextBox
    Friend WithEvents TxtITEMG As System.Windows.Forms.TextBox
    Friend WithEvents TxtITEMJ As System.Windows.Forms.TextBox
    Friend WithEvents TxtITEMK As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtITEMB = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DTPYEARMONTH = New System.Windows.Forms.DateTimePicker
        Me.CmbCODE_TALLY_QUALITY = New System.Windows.Forms.ComboBox
        Me.TxtITEMA = New System.Windows.Forms.TextBox
        Me.TxtITEMD = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtITEME = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtITEMH = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtITEMG = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtITEMJ = New System.Windows.Forms.TextBox
        Me.TxtITEMK = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(228, 144)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 11
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(160, 144)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 10
        Me.btSave.Text = "确认"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(8, 34)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(94, 20)
        Me.Label22.TabIndex = 106
        Me.Label22.Text = "数字准确艘次"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "理货总艘次"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtITEMB
        '
        Me.TxtITEMB.Location = New System.Drawing.Point(107, 60)
        Me.TxtITEMB.Name = "TxtITEMB"
        Me.TxtITEMB.Size = New System.Drawing.Size(114, 21)
        Me.TxtITEMB.TabIndex = 3
        Me.TxtITEMB.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 20)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "时间"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(228, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 20)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "项目名称"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTPYEARMONTH
        '
        Me.DTPYEARMONTH.CustomFormat = "yyyy年  MM月"
        Me.DTPYEARMONTH.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPYEARMONTH.Location = New System.Drawing.Point(107, 6)
        Me.DTPYEARMONTH.Name = "DTPYEARMONTH"
        Me.DTPYEARMONTH.Size = New System.Drawing.Size(114, 21)
        Me.DTPYEARMONTH.TabIndex = 0
        '
        'CmbCODE_TALLY_QUALITY
        '
        Me.CmbCODE_TALLY_QUALITY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCODE_TALLY_QUALITY.Location = New System.Drawing.Point(327, 6)
        Me.CmbCODE_TALLY_QUALITY.Name = "CmbCODE_TALLY_QUALITY"
        Me.CmbCODE_TALLY_QUALITY.Size = New System.Drawing.Size(114, 20)
        Me.CmbCODE_TALLY_QUALITY.TabIndex = 1
        '
        'TxtITEMA
        '
        Me.TxtITEMA.Location = New System.Drawing.Point(107, 33)
        Me.TxtITEMA.Name = "TxtITEMA"
        Me.TxtITEMA.Size = New System.Drawing.Size(114, 21)
        Me.TxtITEMA.TabIndex = 2
        Me.TxtITEMA.Text = ""
        '
        'TxtITEMD
        '
        Me.TxtITEMD.Location = New System.Drawing.Point(327, 33)
        Me.TxtITEMD.Name = "TxtITEMD"
        Me.TxtITEMD.Size = New System.Drawing.Size(114, 21)
        Me.TxtITEMD.TabIndex = 6
        Me.TxtITEMD.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(228, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "到数艘次"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtITEME
        '
        Me.TxtITEME.Location = New System.Drawing.Point(327, 60)
        Me.TxtITEME.Name = "TxtITEME"
        Me.TxtITEME.Size = New System.Drawing.Size(114, 21)
        Me.TxtITEME.TabIndex = 7
        Me.TxtITEME.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(228, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "进口理货总艘次"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtITEMH
        '
        Me.TxtITEMH.Location = New System.Drawing.Point(107, 115)
        Me.TxtITEMH.Name = "TxtITEMH"
        Me.TxtITEMH.Size = New System.Drawing.Size(114, 21)
        Me.TxtITEMH.TabIndex = 5
        Me.TxtITEMH.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "符合标准单证数"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 20)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "单证总数"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(228, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 20)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "发出意见书总数"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtITEMG
        '
        Me.TxtITEMG.Location = New System.Drawing.Point(107, 88)
        Me.TxtITEMG.Name = "TxtITEMG"
        Me.TxtITEMG.Size = New System.Drawing.Size(114, 21)
        Me.TxtITEMG.TabIndex = 4
        Me.TxtITEMG.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(228, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 20)
        Me.Label9.TabIndex = 106
        Me.Label9.Text = "意见书满意数"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtITEMJ
        '
        Me.TxtITEMJ.Location = New System.Drawing.Point(327, 88)
        Me.TxtITEMJ.Name = "TxtITEMJ"
        Me.TxtITEMJ.Size = New System.Drawing.Size(114, 21)
        Me.TxtITEMJ.TabIndex = 8
        Me.TxtITEMJ.Text = ""
        '
        'TxtITEMK
        '
        Me.TxtITEMK.Location = New System.Drawing.Point(327, 115)
        Me.TxtITEMK.Name = "TxtITEMK"
        Me.TxtITEMK.Size = New System.Drawing.Size(114, 21)
        Me.TxtITEMK.TabIndex = 9
        Me.TxtITEMK.Text = ""
        '
        'FrmREPORT_TALLY_QUALITY_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(452, 175)
        Me.Controls.Add(Me.CmbCODE_TALLY_QUALITY)
        Me.Controls.Add(Me.DTPYEARMONTH)
        Me.Controls.Add(Me.TxtITEMB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtITEMA)
        Me.Controls.Add(Me.TxtITEMD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtITEME)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtITEMH)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtITEMG)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtITEMJ)
        Me.Controls.Add(Me.TxtITEMK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmREPORT_TALLY_QUALITY_Edit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "理货质量统计月报_编辑"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As New DataSet()
    Dim dw As New DataView()
    Dim sqlda As New SqlClient.SqlDataAdapter()
   
    Private Sub FrmREPORT_TALLY_QUALITY_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err

        Call FillCODE_TALLY_QUALITY()
        Dim sqlstr As String
        sqlstr = "select * from REPORT_TALLY_QUALITY where REPORT_TALLY_QUALITY_ID=" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        If dw.Count > 0 Then
            DTPYEARMONTH.Value = ds.Tables(0).Rows(0).Item("YEARMONTH")
            CmbCODE_TALLY_QUALITY.SelectedValue = ds.Tables(0).Rows(0).Item("Code_ITEM")

            TxtITEMA.Text = ds.Tables(0).Rows(0).Item("ITEMA")
            TxtITEMB.Text = ds.Tables(0).Rows(0).Item("ITEMB")
            TxtITEMD.Text = ds.Tables(0).Rows(0).Item("ITEMD")
            TxtITEME.Text = ds.Tables(0).Rows(0).Item("ITEME")
            TxtITEMG.Text = ds.Tables(0).Rows(0).Item("ITEMG")
            TxtITEMH.Text = ds.Tables(0).Rows(0).Item("ITEMH")
            TxtITEMJ.Text = ds.Tables(0).Rows(0).Item("ITEMJ")
            TxtITEMK.Text = ds.Tables(0).Rows(0).Item("ITEMK")
        End If
        CmbCODE_TALLY_QUALITY.Focus()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            If MsgBox("你确认要修改数据吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
                Call OperateHistory(G_DeptName, Now, G_User, "修改", "REPORT_TALLY_QUALITY", Trim(ID), "REPORT_TALLY_QUALITY_ID")


                If Len(Trim(TxtITEMA.Text)) > 0 Then
                    If IsNumeric(Trim(TxtITEMA.Text)) Then
                        ds.Tables(0).Rows(0).Item("ITEMA") = Trim(TxtITEMA.Text)
                    Else
                        MsgBox("数字准确艘次一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                        Exit Sub
                    End If
                Else
                    ds.Tables(0).Rows(0).Item("ITEMA") = 0
                End If
                If Len(Trim(TxtITEMB.Text)) > 0 Then
                    If IsNumeric(Trim(TxtITEMB.Text)) Then
                        ds.Tables(0).Rows(0).Item("ITEMB") = Trim(TxtITEMB.Text)
                    Else
                        MsgBox("理货总艘次一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                        Exit Sub
                    End If
                Else
                    ds.Tables(0).Rows(0).Item("ITEMB") = 0
                End If
                ds.Tables(0).Rows(0).Item("ITEMC") = Trim(TxtITEMA.Text) / Trim(TxtITEMB.Text)


                If Len(Trim(TxtITEMD.Text)) > 0 Then
                    If IsNumeric(Trim(TxtITEMD.Text)) Then
                        ds.Tables(0).Rows(0).Item("ITEMD") = Trim(TxtITEMD.Text)
                    Else
                        MsgBox("到数艘次一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                        Exit Sub
                    End If
                Else
                    ds.Tables(0).Rows(0).Item("ITEMD") = 0
                End If
                If Len(Trim(TxtITEME.Text)) > 0 Then
                    If IsNumeric(Trim(TxtITEME.Text)) Then
                        ds.Tables(0).Rows(0).Item("ITEME") = Trim(TxtITEME.Text)
                    Else
                        MsgBox("进口理货总艘次一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                        Exit Sub
                    End If
                Else
                    ds.Tables(0).Rows(0).Item("ITEME") = 0
                End If
                ds.Tables(0).Rows(0).Item("ITEMF") = Trim(TxtITEMD.Text) / Trim(TxtITEME.Text)


                If Len(Trim(TxtITEMG.Text)) > 0 Then
                    If IsNumeric(Trim(TxtITEMG.Text)) Then
                        ds.Tables(0).Rows(0).Item("ITEMG") = Trim(TxtITEMG.Text)
                    Else
                        MsgBox("符合标准单证数一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                        Exit Sub
                    End If
                Else
                    ds.Tables(0).Rows(0).Item("ITEMG") = 0
                End If
                If Len(Trim(TxtITEMH.Text)) > 0 Then
                    If IsNumeric(Trim(TxtITEMH.Text)) Then
                        ds.Tables(0).Rows(0).Item("ITEMH") = Trim(TxtITEMH.Text)
                    Else
                        MsgBox("单证总数一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                        Exit Sub
                    End If
                Else
                    ds.Tables(0).Rows(0).Item("ITEMH") = 0
                End If
                ds.Tables(0).Rows(0).Item("ITEMI") = Trim(TxtITEMG.Text) / Trim(TxtITEMH.Text)


                If Len(Trim(TxtITEMJ.Text)) > 0 Then
                    If IsNumeric(Trim(TxtITEMJ.Text)) Then
                        ds.Tables(0).Rows(0).Item("ITEMJ") = Trim(TxtITEMJ.Text)
                    Else
                        MsgBox("意见书满意数一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                        Exit Sub
                    End If
                Else
                    ds.Tables(0).Rows(0).Item("ITEMJ") = 0
                End If
                If Len(Trim(TxtITEMK.Text)) > 0 Then
                    If IsNumeric(Trim(TxtITEMK.Text)) Then
                        ds.Tables(0).Rows(0).Item("ITEMK") = Trim(TxtITEMK.Text)
                    Else
                        MsgBox("发出意见书总数一栏应填入数字类型数据！", MsgBoxStyle.Exclamation, "提示")
                        Exit Sub
                    End If
                Else
                    ds.Tables(0).Rows(0).Item("ITEMK") = 0
                End If
                ds.Tables(0).Rows(0).Item("ITEML") = Trim(TxtITEMJ.Text) / Trim(TxtITEMK.Text)


                sqlda.Update(ds)
                Me.Close()
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub FillCODE_TALLY_QUALITY()
        Dim sqldc As String
        Dim dvc As New DataView()
        Dim dsc As New DataSet()
        sqldc = "select CODE_ITEM,ITEM from CODE_TALLY_QUALITY"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbCODE_TALLY_QUALITY.DataSource = dvc
        Me.CmbCODE_TALLY_QUALITY.DisplayMember = "ITEM"
        Me.CmbCODE_TALLY_QUALITY.ValueMember = "CODE_ITEM"
    End Sub

    Private Sub DTPYEARMONTH_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DTPYEARMONTH.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbCODE_TALLY_QUALITY.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CmbCODE_TALLY_QUALITY_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbCODE_TALLY_QUALITY.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtITEMA.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtITEMA_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtITEMA.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtITEMB.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtITEMB_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtITEMB.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtITEMG.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtITEMG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtITEMG.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtITEMH.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtITEMH_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtITEMH.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtITEMD.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtITEMD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtITEMD.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtITEME.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtITEME_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtITEME.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtITEMJ.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtITEMJ_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtITEMJ.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtITEMK.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtITEMK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtITEMK.KeyDown
        If e.KeyCode = Keys.Enter Then
            btSave.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btSave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btSave.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btQuit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btQuit.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class
