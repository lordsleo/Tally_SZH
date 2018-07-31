Imports TALLY.DBControl

Public Class Frm_His

    Dim sqlstr As String
    Dim dshis As New DataSet
    Dim dvhis As New DataView

    Private Sub Frm_His_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If G_User_Serial = "WLGCH" Then
            Label2.Visible = True
            CmbTbname.Visible = True
        End If

        FillTableName()
        CmbTbname.Text = ""

        sqlstr = "select top 30 * from szh_History where deptcode='" & G_DeptCode & "' Order by id desc "
        dvhis = Getdata(sqlstr, dshis)
        fillc1(sqlstr)

        DateTimePicker1.Value = Now.AddDays(-1)

        'c1DBG.Height = Panel2.Height - 40
        'btnQuit.Top = c1DBG.Height + 5
        'btnQuit.Left = (c1DBG.Width - btnQuit.Width) / 2
        Panel3.Left = (c1DBG.Width - Panel3.Width) / 2
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If CmbTbname.Text.Trim().Length > 0 Then
            sqlstr = "select * from szh_History where deptcode='" & G_DeptCode & "' and datediff(mi,'" & DateTimePicker1.Value.ToString() & "',his_date)>0 and datediff(mi,'" & DateTimePicker2.Value.ToString() & "',his_date)<0 and his_tablename='" & CmbTbname.Text & "' "
        Else
            sqlstr = "select * from szh_History where deptcode='" & G_DeptCode & "' and datediff(mi,'" & DateTimePicker1.Value.ToString() & "',his_date)>0 and datediff(mi,'" & DateTimePicker2.Value.ToString() & "',his_date)<0 "
        End If
        dshis.Reset()
        dvhis = Getdata(sqlstr, dshis)
        fillc1(sqlstr)
    End Sub

    Private Sub fillc1(ByVal strque As String)
        Me.c1DBG.DataSource = dvhis
        Me.c1DBG.Splits(0).DisplayColumns.Item(0).Visible = False
        Me.c1DBG.Splits(0).DisplayColumns.Item(1).Visible = False
        Me.c1DBG.Splits(0).DisplayColumns.Item(3).Visible = False
        Me.c1DBG.Columns.Item(2).Caption = "操作时间"
        Me.c1DBG.Columns.Item(4).Caption = "操作人"
        Me.c1DBG.Columns.Item(5).Caption = "操作类别"
        Me.c1DBG.Columns.Item(6).Caption = "操作对象"
        Me.c1DBG.Columns.Item(7).Caption = "操作前记录"
        Me.c1DBG.Columns.Item(8).Caption = "操作后记录"
        Me.c1DBG.Columns.Item(2).NumberFormat = "yyyy/MM/dd hh:mm"
        SetColumnWidth()

    End Sub

    Private Sub FillTableName()
        Dim sqldc As String
        Dim dsc As New DataSet
        Dim dvc As New DataView
        sqldc = "select distinct his_tablename from szh_History order by his_tablename "
        dvc = DBControl.Getdata(sqldc, dsc)
        CmbTbname.DataSource = dvc
        CmbTbname.DisplayMember = "his_tablename"
        CmbTbname.ValueMember = "his_tablename"
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Close()
    End Sub

    Private Sub SetColumnWidth()
        Dim j As Integer
        For j = 0 To Me.c1DBG.Columns.Count - 1
            Me.c1DBG.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.c1DBG.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.c1DBG.Splits(0).DisplayColumns.Item(j).Width < 30 Then
                Me.c1DBG.Splits(0).DisplayColumns.Item(j).Width = 30
            Else
                If Me.c1DBG.Splits(0).DisplayColumns.Item(j).Width > 300 Then
                    Me.c1DBG.Splits(0).DisplayColumns.Item(j).Width = 300
                End If
            End If
        Next
    End Sub

    Private Sub c1DBG_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1DBG.DoubleClick
        Panel3.Left = (c1DBG.Width - Panel3.Width) / 2
        Panel3.Visible = True
        TextBox1.Text = c1DBG.Columns(2).CellText(c1DBG.Row)
        TextBox2.Text = c1DBG.Columns(4).CellText(c1DBG.Row)
        TextBox3.Text = c1DBG.Columns(5).CellText(c1DBG.Row)
        TextBox4.Text = c1DBG.Columns(6).CellText(c1DBG.Row)
        rtbold.Text = c1DBG.Columns(7).CellText(c1DBG.Row)
        rtbnew.Text = c1DBG.Columns(8).CellText(c1DBG.Row)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Panel3.Visible = False
    End Sub

    Dim plMove As Boolean = False
    Dim plPoint As New Point
    Dim plOldPoint As New Point

    Private Sub Panel3_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseDown
        plMove = True
        plPoint.X = e.X
        plPoint.Y = e.Y
        plOldPoint.X = Me.Panel3.Location.X
        plOldPoint.Y = Me.Panel3.Location.Y
    End Sub

    Private Sub Panel3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.MouseEnter
        Me.Cursor = Cursors.SizeAll
    End Sub

    Private Sub Panel3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub Panel3_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseUp
        If plMove = True Then
            Me.Panel3.Location = New Point(plOldPoint.X + (e.X - plPoint.X), plOldPoint.Y + (e.Y - plPoint.Y))
        End If
        plMove = False
    End Sub
 
End Class