Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FrmCargo_hatch_sheet_doprint
    Inherits System.Windows.Forms.Form
    Dim dw As New DataView()
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dsok As New DataSet()
    Dim dsname As New DataSet()



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
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents BTOK As System.Windows.Forms.Button
    Friend WithEvents RB1 As System.Windows.Forms.RadioButton
    Friend WithEvents RB2 As System.Windows.Forms.RadioButton
    Friend WithEvents RB3 As System.Windows.Forms.RadioButton
    Friend WithEvents RB4 As System.Windows.Forms.RadioButton
    Friend WithEvents RB5 As System.Windows.Forms.RadioButton
    Friend WithEvents RB6 As System.Windows.Forms.RadioButton
    Friend WithEvents RB7 As System.Windows.Forms.RadioButton
    Friend WithEvents RB8 As System.Windows.Forms.RadioButton
    Friend WithEvents RB9 As System.Windows.Forms.RadioButton
    Friend WithEvents RB10 As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.RB1 = New System.Windows.Forms.RadioButton()
        Me.RB2 = New System.Windows.Forms.RadioButton()
        Me.RB3 = New System.Windows.Forms.RadioButton()
        Me.RB4 = New System.Windows.Forms.RadioButton()
        Me.RB5 = New System.Windows.Forms.RadioButton()
        Me.RB6 = New System.Windows.Forms.RadioButton()
        Me.RB7 = New System.Windows.Forms.RadioButton()
        Me.RB8 = New System.Windows.Forms.RadioButton()
        Me.RB9 = New System.Windows.Forms.RadioButton()
        Me.RB10 = New System.Windows.Forms.RadioButton()
        Me.BTQUIT = New System.Windows.Forms.Button()
        Me.BTOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RB1
        '
        Me.RB1.Enabled = False
        Me.RB1.Location = New System.Drawing.Point(16, 10)
        Me.RB1.Name = "RB1"
        Me.RB1.Size = New System.Drawing.Size(98, 22)
        Me.RB1.TabIndex = 0
        '
        'RB2
        '
        Me.RB2.Enabled = False
        Me.RB2.Location = New System.Drawing.Point(16, 38)
        Me.RB2.Name = "RB2"
        Me.RB2.Size = New System.Drawing.Size(98, 22)
        Me.RB2.TabIndex = 1
        '
        'RB3
        '
        Me.RB3.Enabled = False
        Me.RB3.Location = New System.Drawing.Point(16, 66)
        Me.RB3.Name = "RB3"
        Me.RB3.Size = New System.Drawing.Size(98, 22)
        Me.RB3.TabIndex = 2
        '
        'RB4
        '
        Me.RB4.Enabled = False
        Me.RB4.Location = New System.Drawing.Point(16, 94)
        Me.RB4.Name = "RB4"
        Me.RB4.Size = New System.Drawing.Size(98, 22)
        Me.RB4.TabIndex = 3
        '
        'RB5
        '
        Me.RB5.Enabled = False
        Me.RB5.Location = New System.Drawing.Point(16, 122)
        Me.RB5.Name = "RB5"
        Me.RB5.Size = New System.Drawing.Size(98, 22)
        Me.RB5.TabIndex = 4
        '
        'RB6
        '
        Me.RB6.Enabled = False
        Me.RB6.Location = New System.Drawing.Point(126, 10)
        Me.RB6.Name = "RB6"
        Me.RB6.Size = New System.Drawing.Size(98, 22)
        Me.RB6.TabIndex = 5
        '
        'RB7
        '
        Me.RB7.Enabled = False
        Me.RB7.Location = New System.Drawing.Point(126, 38)
        Me.RB7.Name = "RB7"
        Me.RB7.Size = New System.Drawing.Size(98, 22)
        Me.RB7.TabIndex = 6
        '
        'RB8
        '
        Me.RB8.Enabled = False
        Me.RB8.Location = New System.Drawing.Point(126, 66)
        Me.RB8.Name = "RB8"
        Me.RB8.Size = New System.Drawing.Size(98, 22)
        Me.RB8.TabIndex = 7
        '
        'RB9
        '
        Me.RB9.Enabled = False
        Me.RB9.Location = New System.Drawing.Point(126, 94)
        Me.RB9.Name = "RB9"
        Me.RB9.Size = New System.Drawing.Size(98, 22)
        Me.RB9.TabIndex = 8
        '
        'RB10
        '
        Me.RB10.Enabled = False
        Me.RB10.Location = New System.Drawing.Point(126, 122)
        Me.RB10.Name = "RB10"
        Me.RB10.Size = New System.Drawing.Size(98, 22)
        Me.RB10.TabIndex = 9
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(124, 164)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 71
        Me.BTQUIT.Text = "取消"
        '
        'BTOK
        '
        Me.BTOK.Location = New System.Drawing.Point(50, 164)
        Me.BTOK.Name = "BTOK"
        Me.BTOK.Size = New System.Drawing.Size(65, 24)
        Me.BTOK.TabIndex = 70
        Me.BTOK.Text = "打印"
        '
        'FrmCargo_hatch_sheet_doprint
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(238, 205)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.BTQUIT, Me.BTOK, Me.RB10, Me.RB9, Me.RB8, Me.RB7, Me.RB6, Me.RB5, Me.RB4, Me.RB3, Me.RB2, Me.RB1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargo_hatch_sheet_doprint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "装卸货物理货分仓单_打印"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCargo_hatch_sheet_doprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dw = Getdata("select * from cargo_hatch_name where ship_id='" & Ship_ID & "'", ds)
        If ds.Tables(0).DefaultView.Count > 0 Then
            If Len(Trim(ds.Tables(0).Rows(0).Item("hatch_a"))) > 0 And IsDBNull(ds.Tables(0).Rows(0).Item("hatch_a")) = False Then
                RB1.Enabled = True
                RB1.Text = ds.Tables(0).Rows(0).Item("hatch_a")
                RB1.Checked = True
                If Len(Trim(ds.Tables(0).Rows(0).Item("hatch_b"))) > 0 And IsDBNull(ds.Tables(0).Rows(0).Item("hatch_b")) = False Then
                    RB2.Enabled = True
                    RB2.Text = ds.Tables(0).Rows(0).Item("hatch_b")
                    If Len(Trim(ds.Tables(0).Rows(0).Item("hatch_c"))) > 0 And IsDBNull(ds.Tables(0).Rows(0).Item("hatch_c")) = False Then
                        RB3.Enabled = True
                        RB3.Text = ds.Tables(0).Rows(0).Item("hatch_c")
                        If Len(Trim(ds.Tables(0).Rows(0).Item("hatch_d"))) > 0 And IsDBNull(ds.Tables(0).Rows(0).Item("hatch_d")) = False Then
                            RB4.Enabled = True
                            RB4.Text = ds.Tables(0).Rows(0).Item("hatch_d")
                            If Len(Trim(ds.Tables(0).Rows(0).Item("hatch_e"))) > 0 And IsDBNull(ds.Tables(0).Rows(0).Item("hatch_e")) = False Then
                                RB5.Enabled = True
                                RB5.Text = ds.Tables(0).Rows(0).Item("hatch_e")
                                If Len(Trim(ds.Tables(0).Rows(0).Item("hatch_f"))) > 0 And IsDBNull(ds.Tables(0).Rows(0).Item("hatch_f")) = False Then
                                    RB6.Enabled = True
                                    RB6.Text = ds.Tables(0).Rows(0).Item("hatch_f")
                                    If Len(Trim(ds.Tables(0).Rows(0).Item("hatch_g"))) > 0 And IsDBNull(ds.Tables(0).Rows(0).Item("hatch_g")) = False Then
                                        RB7.Enabled = True
                                        RB7.Text = ds.Tables(0).Rows(0).Item("hatch_g")
                                        If Len(Trim(ds.Tables(0).Rows(0).Item("hatch_h"))) > 0 And IsDBNull(ds.Tables(0).Rows(0).Item("hatch_h")) = False Then
                                            RB8.Enabled = True
                                            RB8.Text = ds.Tables(0).Rows(0).Item("hatch_h")
                                            If Len(Trim(ds.Tables(0).Rows(0).Item("hatch_i"))) > 0 And IsDBNull(ds.Tables(0).Rows(0).Item("hatch_i")) = False Then
                                                RB9.Enabled = True
                                                RB9.Text = ds.Tables(0).Rows(0).Item("hatch_i")
                                                If Len(Trim(ds.Tables(0).Rows(0).Item("hatch_j"))) > 0 And IsDBNull(ds.Tables(0).Rows(0).Item("hatch_j")) = False Then
                                                    RB10.Enabled = True
                                                    RB10.Text = ds.Tables(0).Rows(0).Item("hatch_j")

                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Else
                MsgBox("舱口名未定义！请先定义舱口名称")
            End If
        Else
            MsgBox("舱口名未定义！请先定义舱口名称")
            Call BTQUIT_Click(sender, e)

        End If

        dw = Getdata("select * from VIEW_SHIPNAME where ship_id='" & Ship_ID & "'", dsname)
    End Sub

    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub

    Private Sub BTOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOK.Click
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer
        Dim hatch As String
        Try
            If RB1.Checked = True Then
                dw = Getdata("exec sp_hatch_sheet_doprint '" & Ship_ID & "','a'", dsok)
                hatch = RB1.Text
            End If
            If RB2.Checked = True Then
                dw = Getdata("exec sp_hatch_sheet_doprint '" & Ship_ID & "','b'", dsok)
                hatch = RB2.Text
            End If
            If RB3.Checked = True Then
                dw = Getdata("exec sp_hatch_sheet_doprint '" & Ship_ID & "','c'", dsok)
                hatch = RB3.Text
            End If
            If RB4.Checked = True Then
                dw = Getdata("exec sp_hatch_sheet_doprint '" & Ship_ID & "','d'", dsok)
                hatch = RB4.Text
            End If
            If RB5.Checked = True Then
                dw = Getdata("exec sp_hatch_sheet_doprint '" & Ship_ID & "','e'", dsok)
                hatch = RB5.Text
            End If
            If RB6.Checked = True Then
                dw = Getdata("exec sp_hatch_sheet_doprint '" & Ship_ID & "','f'", dsok)
                hatch = RB6.Text
            End If
            If RB7.Checked = True Then
                dw = Getdata("exec sp_hatch_sheet_doprint '" & Ship_ID & "','g'", dsok)
                hatch = RB7.Text
            End If
            If RB8.Checked = True Then
                dw = Getdata("exec sp_hatch_sheet_doprint '" & Ship_ID & "','h'", dsok)
                hatch = RB8.Text
            End If
            If RB9.Checked = True Then
                dw = Getdata("exec sp_hatch_sheet_doprint '" & Ship_ID & "','i'", dsok)
                hatch = RB9.Text
            End If
            If RB10.Checked = True Then
                dw = Getdata("exec sp_hatch_sheet_doprint '" & Ship_ID & "','j'", dsok)
                hatch = RB10.Text
            End If

            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "Report_zlp.xls", pathstr + "Report.xls")
            Filepath = pathstr + "report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("装卸货物理货分仓单"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = True

            xlsheet.Cells(2, 1) = "船名：" & dsname.Tables(0).Rows(0).Item("CHI_VESSEL")
            xlsheet.Cells(2, 3) = "国籍：" & dsname.Tables(0).Rows(0).Item("NATIONALITY_CHA")
            xlsheet.Cells(2, 6) = "制单：" & Year(Now) & "年" & Month(Now) & "月" & Day(Now) & "日"
            xlsheet.Cells(2, 9) = hatch
            For row = 0 To dsok.Tables(0).Rows.Count - 1
                For col = 0 To 7
                    xlsheet.Cells(4 + row, col + 1) = dsok.Tables(0).Rows(row)(col)
                Next col
            Next row

            xlsheet.Cells(dsok.Tables(0).Rows.Count + 4, 1) = "备注："
            For row = 2 To dsok.Tables(0).Rows.Count + 4 '*画行
                xlsheet.Range(xlsheet.Cells(row, 1), xlsheet.Cells(row, 9)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 7
            Next row
            For col = 1 To 10 '* 画列
                xlsheet.Range(xlsheet.Cells(3, col), xlsheet.Cells(dsok.Tables(0).Rows.Count + 3, col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7
            Next col
            xlsheet.Range(xlsheet.Cells(dsok.Tables(0).Rows.Count + 4, 1), xlsheet.Cells(dsok.Tables(0).Rows.Count + 4, 1)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7
            xlsheet.Range(xlsheet.Cells(dsok.Tables(0).Rows.Count + 4, 10), xlsheet.Cells(dsok.Tables(0).Rows.Count + 4, 10)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7

            xlsheet.PrintPreview()

        Catch
            xlapp.Quit()
            SendKeys.Send("n")
        End Try
    End Sub
End Class
