Imports TALLY.DBControl
Public Class FrmCargo_hatch_sheet_EDIT
    Inherits System.Windows.Forms.Form
    Dim SqlStr As String  '条件语句
    Dim SelectStr As String
    Dim dw As New DataView()
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim ColNum As Integer '不显示的列数
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
    Friend WithEvents C1dbg As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents BTOK As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCargo_hatch_sheet_EDIT))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.C1dbg = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.BTQUIT = New System.Windows.Forms.Button()
        Me.BTOK = New System.Windows.Forms.Button()
        CType(Me.C1dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1dbg
        '
        Me.C1dbg.AllowFilter = True
        Me.C1dbg.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1dbg.AllowSort = True
        Me.C1dbg.CaptionHeight = 18
        Me.C1dbg.CollapseColor = System.Drawing.Color.Black
        Me.C1dbg.DataChanged = False
        Me.C1dbg.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1dbg.ExpandColor = System.Drawing.Color.Black
        Me.C1dbg.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1dbg.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1dbg.Location = New System.Drawing.Point(4, 14)
        Me.C1dbg.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1dbg.Name = "C1dbg"
        Me.C1dbg.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1dbg.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1dbg.PreviewInfo.ZoomFactor = 75
        Me.C1dbg.PrintInfo.ShowOptionsDialog = False
        Me.C1dbg.RecordSelectorWidth = 16
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1dbg.RowDivider = GridLines1
        Me.C1dbg.RowHeight = 16
        Me.C1dbg.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1dbg.ScrollTips = False
        Me.C1dbg.Size = New System.Drawing.Size(740, 74)
        Me.C1dbg.TabIndex = 0
        Me.C1dbg.Text = "C1TrueDBGrid1"
        Me.C1dbg.PropBag = CType(resources.GetObject("C1dbg.PropBag"), String)
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(405, 106)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 71
        Me.BTQUIT.Text = "取消"
        '
        'BTOK
        '
        Me.BTOK.Location = New System.Drawing.Point(281, 106)
        Me.BTOK.Name = "BTOK"
        Me.BTOK.Size = New System.Drawing.Size(65, 24)
        Me.BTOK.TabIndex = 70
        Me.BTOK.Text = "确认"
        '
        'FrmCargo_hatch_sheet_EDIT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(750, 143)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.BTQUIT, Me.BTOK, Me.C1dbg})
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargo_hatch_sheet_EDIT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "作业分舱单_编辑"
        CType(Me.C1dbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCargo_hatch_sheet_EDIT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dscup As New DataSet()
        Dim dsp As New DataSet()
        Dim p As Integer
        Dim i As Integer

        Try
            Me.C1dbg.DataSource = Updatedata(sqlda, "select blno,goods_cha,PIECE_A,HATCH_POSITION_A,PIECE_B,HATCH_POSITION_B,PIECE_C,HATCH_POSITION_C,PIECE_D,HATCH_POSITION_D,PIECE_E,HATCH_POSITION_E,PIECE_F,HATCH_POSITION_F,PIECE_G,HATCH_POSITION_G,PIECE_H,HATCH_POSITION_H,PIECE_I,HATCH_POSITION_I,PIECE_J,HATCH_POSITION_J from cargo_hatch_sheet where hatch_sheet_id='" & ID & "'", ds)
            dw = Getdata("exec sp_calcup '" & Ship_ID & "'", dsp)
            p = dsp.Tables(0).Rows(0).Item("p")
            For i = 2 + 2 * p To 21
                Me.C1dbg.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Me.C1dbg.Columns.Item("blno").Caption = "提单号"
            Me.C1dbg.Columns.Item("goods_cha").Caption = "货物中文描述"
            Me.C1dbg.Splits(0).DisplayColumns.Item(0).AllowFocus = False
            Me.C1dbg.Splits(0).DisplayColumns.Item(1).AllowFocus = False


            dw = Getdata("select * from cargo_hatch_name where ship_id='" & Ship_ID & "'", dscup)
            If dscup.Tables(0).DefaultView.Count > 0 Then


                Me.C1dbg.Columns.Item(2).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_a")), "a舱", dscup.Tables(0).Rows(0).Item("hatch_a")) & "件数"
                Me.C1dbg.Columns.Item(4).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_b")), "b舱", dscup.Tables(0).Rows(0).Item("hatch_b")) & "件数"
                Me.C1dbg.Columns.Item(6).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_c")), "c舱", dscup.Tables(0).Rows(0).Item("hatch_c")) & "件数"
                Me.C1dbg.Columns.Item(8).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_d")), "d舱", dscup.Tables(0).Rows(0).Item("hatch_d")) & "件数"
                Me.C1dbg.Columns.Item(10).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_e")), "e舱", dscup.Tables(0).Rows(0).Item("hatch_e")) & "件数"
                Me.C1dbg.Columns.Item(12).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_f")), "f舱", dscup.Tables(0).Rows(0).Item("hatch_f")) & "件数"
                Me.C1dbg.Columns.Item(14).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_g")), "g舱", dscup.Tables(0).Rows(0).Item("hatch_g")) & "件数"
                Me.C1dbg.Columns.Item(16).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_h")), "h舱", dscup.Tables(0).Rows(0).Item("hatch_h")) & "件数"
                Me.C1dbg.Columns.Item(18).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_i")), "i舱", dscup.Tables(0).Rows(0).Item("hatch_i")) & "件数"
                Me.C1dbg.Columns.Item(20).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_j")), "j舱", dscup.Tables(0).Rows(0).Item("hatch_j")) & "件数"

                Me.C1dbg.Columns.Item(3).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_a")), "a舱", dscup.Tables(0).Rows(0).Item("hatch_a")) & "位置"
                Me.C1dbg.Columns.Item(5).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_b")), "b舱", dscup.Tables(0).Rows(0).Item("hatch_b")) & "位置"
                Me.C1dbg.Columns.Item(7).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_c")), "c舱", dscup.Tables(0).Rows(0).Item("hatch_c")) & "位置"
                Me.C1dbg.Columns.Item(9).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_d")), "d舱", dscup.Tables(0).Rows(0).Item("hatch_d")) & "位置"
                Me.C1dbg.Columns.Item(11).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_e")), "e舱", dscup.Tables(0).Rows(0).Item("hatch_e")) & "位置"
                Me.C1dbg.Columns.Item(13).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_f")), "f舱", dscup.Tables(0).Rows(0).Item("hatch_f")) & "位置"
                Me.C1dbg.Columns.Item(15).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_g")), "g舱", dscup.Tables(0).Rows(0).Item("hatch_g")) & "位置"
                Me.C1dbg.Columns.Item(17).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_h")), "h舱", dscup.Tables(0).Rows(0).Item("hatch_h")) & "位置"
                Me.C1dbg.Columns.Item(19).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_i")), "i舱", dscup.Tables(0).Rows(0).Item("hatch_i")) & "位置"
                Me.C1dbg.Columns.Item(21).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_j")), "j舱", dscup.Tables(0).Rows(0).Item("hatch_j")) & "位置"


            End If
            Call SetColumnWidth()

            Me.C1dbg.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SetColumnWidth()
        Dim j As Integer
        For j = 0 To Me.C1DBG.Columns.Count - 1
            Me.C1DBG.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.C1DBG.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width < 40 Then
                Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width = 40
            Else
                If Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If

        Next
    End Sub
    Private Sub BTOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOK.Click
        Try
            sqlda.Update(ds)
            Call BTQUIT_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()

    End Sub
End Class
