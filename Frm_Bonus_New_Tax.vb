Imports TALLY.DBControl
Public Class Frm_Bonus_New_Tax
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet
    Dim dsBonus As New DataSet
    Dim dwBonus As New DataView
    Dim sqlda As New SqlClient.SqlDataAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBonus As System.Windows.Forms.ComboBox
    Dim ColNum As Integer

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
    Friend WithEvents txtDept As System.Windows.Forms.ComboBox
    Friend WithEvents c1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Bonus_New_Tax))
        Me.txtDept = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.c1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnQuit = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBonus = New System.Windows.Forms.ComboBox
        CType(Me.c1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDept
        '
        Me.txtDept.Location = New System.Drawing.Point(74, 10)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(170, 20)
        Me.txtDept.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "部门名称"
        '
        'c1DBG
        '
        Me.c1DBG.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveDown
        Me.c1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1DBG.Images.Add(CType(resources.GetObject("c1DBG.Images"), System.Drawing.Image))
        Me.c1DBG.Location = New System.Drawing.Point(3, 37)
        Me.c1DBG.Name = "c1DBG"
        Me.c1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1DBG.PreviewInfo.ZoomFactor = 75
        Me.c1DBG.PrintInfo.PageSettings = CType(resources.GetObject("c1DBG.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1DBG.Size = New System.Drawing.Size(752, 412)
        Me.c1DBG.TabIndex = 2
        Me.c1DBG.PropBag = resources.GetString("c1DBG.PropBag")
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(12, 455)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(121, 24)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "确认"
        Me.btnSave.Visible = False
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(334, 455)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(90, 24)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "返  回"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(291, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "奖金名称"
        '
        'txtBonus
        '
        Me.txtBonus.Location = New System.Drawing.Point(350, 10)
        Me.txtBonus.Name = "txtBonus"
        Me.txtBonus.Size = New System.Drawing.Size(170, 20)
        Me.txtBonus.TabIndex = 5
        '
        'Frm_Bonus_New_Tax
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(758, 481)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBonus)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.c1DBG)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDept)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frm_Bonus_New_Tax"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "缴税记录"
        CType(Me.c1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Frm_Bonus_New_Tax_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView
        Dim sqlstr As String
        Dim dsDept As New DataSet

        Me.StartPosition = FormStartPosition.CenterScreen
        FillBONUS_CODE()

        Dim depttmp As String
        depttmp = "2_" + G_DeptCode.Substring(2)
        sqlstr = "select dept_code,dept_name from department where rtrim(dept_code)<>'00' and dept_code like '" & depttmp & "%' Order by dept_code"
        'sqlstr = "select dept_code,dept_name from department where rtrim(dept_code)<>'00' and dept_code like '" & G_DeptCode & "%' Order by dept_code"
        dw = Getdata(sqlstr, dsDept)
        txtDept.DataSource = dsDept.Tables(0).DefaultView
        txtDept.DisplayMember = "dept_name"
        txtDept.ValueMember = "dept_code"
        ColNum = 2
        txtDept_SelectionChangeCommitted(sender, e)
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub FillBONUS_CODE()
        Dim sqldc As String
        Dim dsc As New DataSet
        Dim dvc As New DataView
        sqldc = "select bonus_id,bonus_name from bonus_name where bonus_id in (select bonus_name_id from bonus_tax) "
        dvc = DBControl.Getdata(sqldc, dsc)
        txtBonus.DataSource = dvc
        txtBonus.DisplayMember = "bonus_name"
        txtBonus.ValueMember = "bonus_id"
    End Sub

    Private Sub txtDept_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDept.SelectionChangeCommitted, txtBonus.SelectionChangeCommitted
        Dim sqlstr As String
        Dim Dept_Code As String
        Dept_Code = txtDept.SelectedValue
        sqlstr = "select * from VIEW_Bonus_New_Tax where dept_code='" & Dept_Code & "' and id='" & txtBonus.SelectedValue & "' Order by id desc,dept_code,xuhao "
        dwBonus = Getdata(sqlstr, dsBonus)
        Me.c1DBG.DataSource = dwBonus
        Me.c1DBG.Splits(0).DisplayColumns.Item(0).Visible = False
        Me.c1DBG.Splits(0).DisplayColumns.Item(1).Visible = False
        Me.c1DBG.Splits(0).DisplayColumns.Item(2).Visible = False
        Me.c1DBG.Splits(0).DisplayColumns.Item(3).Visible = False
        Me.c1DBG.Splits(0).DisplayColumns.Item(8).Visible = False
        'Me.c1DBG.Splits(0).DisplayColumns.Item(4).AllowFocus = False
        Call SetColumnCaption()
        Me.c1DBG.Columns.Item(4).Caption = "名称"
        Me.c1DBG.Columns.Item(5).Caption = "开始时间"
        Me.c1DBG.Columns.Item(6).Caption = "结束时间"
        Me.c1DBG.Columns.Item(10).Caption = "金额"
        Me.c1DBG.Columns.Item(11).Caption = "已扣税额"
        Me.c1DBG.Columns.Item(12).Caption = "当前税额"
        Me.c1DBG.Columns.Item(13).Caption = "税后奖金"
        Call SetColumnWidth()
    End Sub

    Private Sub SetColumnCaption()
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Try
            str = "select Field_Eng,Field_Cha From Field_Att where Table_Name='" & Table_Name & "'"
            sqlconn.ConnectionString = conn_rs
            sqlc.Connection = sqlconn
            sqlc.CommandText = str
            sqla.SelectCommand = sqlc
            dset.Reset()
            sqla.Fill(dset)
            i = ColNum

            Do While i < Me.c1DBG.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.c1DBG.Columns.Item(i).DataField.ToString)) Then
                        Me.c1DBG.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
                        Exit For
                    End If
                Next
                i = i + 1
            Loop
            sqlconn.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnWidth()
        Dim j As Integer
        For j = 0 To Me.c1DBG.Columns.Count - 1
            Me.c1DBG.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.c1DBG.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.c1DBG.Splits(0).DisplayColumns.Item(j).Width < 40 Then
                Me.c1DBG.Splits(0).DisplayColumns.Item(j).Width = 40
            Else
                If Me.c1DBG.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.c1DBG.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If
        Next
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim i As Int16
        Dim dw As New DataView
        Dim sqlstr As String
        Dim WorkNo As String
        Dim bonusid As Int16
        Try
            If MsgBox("你确认要保存吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                For i = 0 To dwBonus.Count - 1
                    bonusid = dwBonus(i).Item("id")
                    WorkNo = dwBonus(i).Item("work_no")
                    sqlstr = "update rs_bonus set bonus='" & dwBonus(i).Item("bonus") & "' where work_no='" & WorkNo & "' and bonus_name_id=" & bonusid & ""
                    ExecSql(sqlstr)
                    'dw = Updatedata(sqlda, sqlstr, ds)
                    'If ds.Tables(0).Rows.Count > 0 Then
                    '    ds.Tables(0).Rows(0).Item("bonus") = dwBonus(i).Item("bonus")
                    '    ds.Tables(0).Rows(0).Item("bonus1") = dwBonus(i).Item("bonus1")
                    '    ds.Tables(0).Rows(0).Item("bonus2") = dwBonus(i).Item("bonus2")
                    '    ds.Tables(0).Rows(0).Item("bonus3") = dwBonus(i).Item("bonus3")
                    '    sqlda.Update(ds)
                    'End If
                Next
                MsgBox("保存完毕！")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
 
End Class
