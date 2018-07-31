Imports TALLY.DBControl
Public Class FrmFinishShipStatistics
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim SqlStr As String  '�������
    Dim SelectStr As String
    Dim DynaStr As String '�ɱ���������
    Dim FirmStr As String '������������
    Dim ColNum As Integer '����ʾ������

    Dim strDept As String
    Dim statDate As Date
    Dim OffsetTime As Integer = 6   'ʱ��ƫ������Сʱ��

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮�������κγ�ʼ��

    End Sub

    '������д��������������б���
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows ����������������
    Private components As System.ComponentModel.IContainer

    'ע�⣺���¹����� Windows ����������������
    '����ʹ�� Windows ����������޸Ĵ˹��̡�
    '��Ҫʹ�ô���༭���޸�����
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents tbbtnFind As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuery As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnAdd As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnEdit As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnDelete As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnPrint As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnExport As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuit As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents mnuQuery As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrint As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExport As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAdd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFind As System.Windows.Forms.MenuItem
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCompile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmFinishShipStatistics))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.ToolBar = New System.Windows.Forms.ToolBar()
        Me.tbbtnFind = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnQuery = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnSep1 = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnAdd = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnEdit = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnDelete = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnSep2 = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnPrint = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnExport = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnSep3 = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnQuit = New System.Windows.Forms.ToolBarButton()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.mnuQuery = New System.Windows.Forms.MenuItem()
        Me.mnuEdit = New System.Windows.Forms.MenuItem()
        Me.mnuSep1 = New System.Windows.Forms.MenuItem()
        Me.mnuPrint = New System.Windows.Forms.MenuItem()
        Me.mnuExport = New System.Windows.Forms.MenuItem()
        Me.mnuSep2 = New System.Windows.Forms.MenuItem()
        Me.mnuAdd = New System.Windows.Forms.MenuItem()
        Me.mnuQuit = New System.Windows.Forms.MenuItem()
        Me.mnuFind = New System.Windows.Forms.MenuItem()
        Me.MainMenu = New System.Windows.Forms.MainMenu()
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuCompile = New System.Windows.Forms.MenuItem()
        Me.mnuDelete = New System.Windows.Forms.MenuItem()
        Me.mnuHelp = New System.Windows.Forms.MenuItem()
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnFind, Me.tbbtnQuery, Me.tbbtnSep1, Me.tbbtnAdd, Me.tbbtnEdit, Me.tbbtnDelete, Me.tbbtnSep2, Me.tbbtnPrint, Me.tbbtnExport, Me.tbbtnSep3, Me.tbbtnQuit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(712, 38)
        Me.ToolBar.TabIndex = 16
        '
        'tbbtnFind
        '
        Me.tbbtnFind.ImageIndex = 0
        Me.tbbtnFind.Text = "����"
        Me.tbbtnFind.ToolTipText = "����"
        '
        'tbbtnQuery
        '
        Me.tbbtnQuery.ImageIndex = 1
        Me.tbbtnQuery.Text = "�鿴"
        Me.tbbtnQuery.ToolTipText = "�鿴"
        Me.tbbtnQuery.Visible = False
        '
        'tbbtnSep1
        '
        Me.tbbtnSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnAdd
        '
        Me.tbbtnAdd.ImageIndex = 2
        Me.tbbtnAdd.Text = "����"
        Me.tbbtnAdd.ToolTipText = "����"
        '
        'tbbtnEdit
        '
        Me.tbbtnEdit.ImageIndex = 3
        Me.tbbtnEdit.Text = "�༭"
        Me.tbbtnEdit.ToolTipText = "�༭"
        Me.tbbtnEdit.Visible = False
        '
        'tbbtnDelete
        '
        Me.tbbtnDelete.ImageIndex = 4
        Me.tbbtnDelete.Text = "ɾ��"
        Me.tbbtnDelete.ToolTipText = "ɾ��"
        Me.tbbtnDelete.Visible = False
        '
        'tbbtnSep2
        '
        Me.tbbtnSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnPrint
        '
        Me.tbbtnPrint.ImageIndex = 5
        Me.tbbtnPrint.Text = "��ӡ"
        Me.tbbtnPrint.ToolTipText = "��ӡ"
        '
        'tbbtnExport
        '
        Me.tbbtnExport.ImageIndex = 6
        Me.tbbtnExport.Text = "����"
        Me.tbbtnExport.ToolTipText = "����Excel"
        '
        'tbbtnSep3
        '
        Me.tbbtnSep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnQuit
        '
        Me.tbbtnQuit.ImageIndex = 7
        Me.tbbtnQuit.Text = "�˳�"
        Me.tbbtnQuit.ToolTipText = "�˳�"
        '
        'ImageList
        '
        Me.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'mnuQuery
        '
        Me.mnuQuery.Index = 1
        Me.mnuQuery.Text = "�鿴(&Q)"
        Me.mnuQuery.Visible = False
        '
        'mnuEdit
        '
        Me.mnuEdit.Index = 1
        Me.mnuEdit.Text = "�༭(&E)"
        Me.mnuEdit.Visible = False
        '
        'mnuSep1
        '
        Me.mnuSep1.Index = 2
        Me.mnuSep1.Text = "-"
        '
        'mnuPrint
        '
        Me.mnuPrint.Index = 3
        Me.mnuPrint.Text = "��ӡ(&P)..."
        '
        'mnuExport
        '
        Me.mnuExport.Index = 4
        Me.mnuExport.Text = "����(&E)"
        '
        'mnuSep2
        '
        Me.mnuSep2.Index = 5
        Me.mnuSep2.Text = "-"
        '
        'mnuAdd
        '
        Me.mnuAdd.Index = 0
        Me.mnuAdd.Text = "����(&A)"
        '
        'mnuQuit
        '
        Me.mnuQuit.Index = 6
        Me.mnuQuit.Text = "�˳�(&X)"
        '
        'mnuFind
        '
        Me.mnuFind.Index = 0
        Me.mnuFind.Text = "����(&F)"
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuCompile, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFind, Me.mnuQuery, Me.mnuSep1, Me.mnuPrint, Me.mnuExport, Me.mnuSep2, Me.mnuQuit})
        Me.mnuFile.Text = "�ļ�(&F)"
        '
        'mnuCompile
        '
        Me.mnuCompile.Index = 1
        Me.mnuCompile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAdd, Me.mnuEdit, Me.mnuDelete})
        Me.mnuCompile.Text = "�༭(&E)"
        '
        'mnuDelete
        '
        Me.mnuDelete.Index = 2
        Me.mnuDelete.Text = "ɾ��(&D)"
        Me.mnuDelete.Visible = False
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.Text = "����(&H)"
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.AllowSort = True
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.CollapseColor = System.Drawing.Color.Black
        Me.C1DBG.DataChanged = False
        Me.C1DBG.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBG.ExpandColor = System.Drawing.Color.Black
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1DBG.Location = New System.Drawing.Point(0, 38)
        Me.C1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.ShowOptionsDialog = False
        Me.C1DBG.RecordSelectorWidth = 16
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG.RowDivider = GridLines1
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG.ScrollTips = False
        Me.C1DBG.Size = New System.Drawing.Size(712, 379)
        Me.C1DBG.TabIndex = 17
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = CType(resources.GetObject("C1DBG.PropBag"), String)
        '
        'FrmFinishShipStatistics
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 417)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.C1DBG, Me.ToolBar})
        Me.Menu = Me.MainMenu
        Me.Name = "FrmFinishShipStatistics"
        Me.Text = "�ֲ����괬���ͳ�Ʊ���Ϣ"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmFinishShipStatistics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call preview("WL10_8") '*****************Ȩ����� '*************Ҫ�޸�ģ���
        Me.Text = Me.Text & "_" & G_DeptName
        'FirmStr = " Order by ID DESC"  '" Use_Comp Like '" & Trim(G_DeptCode) & "%' and Hide_Company Like '" & Trim(G_Company) & "%' order by ID DESC" 
        DynaStr = " 2>1 " '���������ʼ����    �ڼ�������Ҫ������ ***************Ҫ�޸� �� ��������
        strDept = G_DeptName
        statDate = DateAdd(DateInterval.Month, -1, Now)
        DynaStr = " DEPT_CODE like '" & G_DeptCode & "%' and datediff(yy, '" & statDate & "', dateAdd(hh, " & OffsetTime & ", WORKTIME_END))=0 and datediff(mm, '" & statDate & "', dateAdd(hh, " & OffsetTime & ", WORKTIME_END))=0 order by DEPT_CODE, WORKTIME_END "
        'DynaStr = "1=1 order by DEPT_CODE, WORKTIME_END "   'Ĭ�ϵ��������
        Call myDataGrid()
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '���ѡ���¼��ɫ
    End Sub

    Private Sub myDataGrid()
        Dim strsql As String
        Dim i As Integer
        Try
            '����ʾ����������ǰ��
            strsql = "select * from View_FinishVessel where " & DynaStr '******Ҫ�޸�

            Me.C1DBG.DataSource = Getdata(strsql, ds)  ' class dbcontrol getdata fuction
            ColNum = 6 '����ʾ������ '******Ҫ�޸�
            Table_Name = "View_FinishVessel" '���������ݿ���� ''******Ҫ�޸�

            For i = 0 To ColNum - 1 '�趨����ʾ������
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Visible = False
            Next

            Call SetColumnCaption() '����б���
            Call SetColumnWidth() '����п���
            If ds.Tables(0).Rows.Count > 0 Then
                Call SetColumnSum("1=1") '��ƺϼ���
            End If
            'Me.C1DBG.FetchRowStyles = True
            Me.C1DBG.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaption()

        Me.C1DBG.Columns("SHIPAGENT_CHA").Caption = "������˾"
        Me.C1DBG.Columns("Trade").Caption = "����ó"
        Me.C1DBG.Columns("StatDate").Caption = "ͳ������"
        Me.C1DBG.Columns("FILE_NO").Caption = "���"
        Me.C1DBG.Columns("BERTHNO").Caption = "��λ��"
        Me.C1DBG.Columns("CHI_VESSEL").Caption = "����"
        Me.C1DBG.Columns("NATIONALITY_CHA").Caption = "����"
        Me.C1DBG.Columns("GOODS").Caption = "����"
        Me.C1DBG.Columns("InOutPort_Name").Caption = "������"
        Me.C1DBG.Columns("FromPort").Caption = "��һ����"
        Me.C1DBG.Columns("ToPort").Caption = "��һ����"
        Me.C1DBG.Columns("YuanPeiAmount1").Caption = "��װ��ԭ�����"
        Me.C1DBG.Columns("YuanPeiAmount2").Caption = "���ӻ�ԭ�����"

        Me.C1DBG.Columns("YuanPeiTons1").Caption = "��װ��ԭ�����"
        Me.C1DBG.Columns("YuanPeiTons2").Caption = "���ӻ�ԭ�����"
        Me.C1DBG.Columns("YuanPeiTons3").Caption = "ɢ��ԭ�����"
        Me.C1DBG.Columns("WanChuanAmount1").Caption = "��װ���괬����"
        Me.C1DBG.Columns("WanChuanAmount2").Caption = "���ӻ��괬����"
        Me.C1DBG.Columns("WanChuanAmount3").Caption = "ɢ���괬����"

        Me.C1DBG.Columns("WanChuanTons2").Caption = "���ӻ��괬����"
        Me.C1DBG.Columns("WanChuanTons3").Caption = "ɢ���괬����"
        Me.C1DBG.Columns("WORKTIME_BEGIN").Caption = "����ʱ��"
        Me.C1DBG.Columns("WORKTIME_END").Caption = "�괬ʱ��"
        Me.C1DBG.Columns("Money").Caption = "����"
        Me.C1DBG.Columns("DEPT_NAME").Caption = "��������"
        Me.C1DBG.Splits(0).DisplayColumns("InOutPort_Name").Visible = False

        'Dim sqla As New SqlClient.SqlDataAdapter()
        'Dim sqlc As New SqlClient.SqlCommand()
        'Dim dset As New DataSet()
        'Dim str As String
        'Dim i As Integer
        'Dim j As Integer
        'Try
        '    str = "select Field_Eng,Field_Cha From Field_Att where Table_Name='" & Table_Name & "'"
        '    sqlconn.ConnectionString = conn
        '    sqlc.Connection = sqlconn
        '    sqlc.CommandText = str
        '    sqla.SelectCommand = sqlc
        '    dset.Reset()
        '    sqla.Fill(dset)
        '    i = ColNum

        '    Do While i < Me.C1DBG.Columns.Count
        '        j = 0
        '        For j = 0 To dset.Tables(0).Rows.Count - 1

        '            If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = _
        '                Upper(Trim(Me.C1DBG.Columns.Item(i).DataField.ToString)) Then
        '                Me.C1DBG.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
        '                Exit For
        '            End If
        '        Next
        '        i = i + 1
        '    Loop
        '    sqlconn.Close()
        'Catch ex As System.Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub SetColumnSum(ByVal sql As String)
        On Error GoTo Err
        Dim sqla As New SqlClient.SqlDataAdapter()
        Dim sqlc As New SqlClient.SqlCommand()
        Dim dset As New DataSet()
        Dim dset2 As New DataSet()
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Dim m As Integer
        Dim num As Double
        str = "select Field_Eng,Field_Type,IsOrNoSum From Field_Att where Table_Name='" & Trim(Table_Name) & "'"
        sqlconn.ConnectionString = conn
        sqlc.Connection = sqlconn
        sqlc.CommandText = str
        sqla.SelectCommand = sqlc
        dset.Reset()
        sqla.Fill(dset)

        i = ColNum
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBG.Columns.Item(ColNum).FooterText = "�ϼ� ��" & ds.Tables(0).Rows.Count & "��"
        Do While i < Me.C1DBG.Columns.Count
            j = 0
            For j = 0 To dset.Tables(0).Rows.Count - 1

                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBG.Columns.Item(i).DataField.ToString)) _
                    And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then

                    num = 0
                    For m = 0 To ds.Tables(0).Rows.Count - 1
                        num = num + ds.Tables(0).Rows(m)(i)
                    Next
                    Me.C1DBG.Columns.Item(i).FooterText = CType(num, String)
                    Exit For
                End If
            Next
            i = i + 1
        Loop

        sqlconn.Close()
        Exit Sub
Err:
        Resume Next

    End Sub

    Private Sub mnuFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFind.Click
        'Dim FrmFind As New FrmFind()
        'FrmFind.ShowDialog()
        'If Flag = 0 Then
        '    SelectStr = ""
        '    Call myDataGrid(SelectStr, " (" & Sql_Find & ")  " & FirmStr)  '����Ҫ�޸�
        '    SqlStr = " (" & Sql_Find & ")  " & FirmStr '����Ҫ�޸�
        'ElseIf Flag = 2 Then
        '    SelectStr = ""
        '    Call myDataGrid(SelectStr, DynaStr & FirmStr)  '����Ҫ�޸�
        '    SqlStr = DynaStr & FirmStr '����Ҫ�޸�
        'End If
    End Sub

    Private Sub mnuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdd.Click
        Dim FrmDeal As New FrmFinishShipStatistics_Deal()  '***********Ҫ�޸�
        Try
            FrmDeal.ShowDialog()
            If FrmDeal.Flag = True Then
                DynaStr = " DEPT_CODE='" & FrmDeal.cbDepart.SelectedValue & "' and datediff(yy, '" & FrmDeal.dtpTime.Value & "', dateAdd(hh, " & OffsetTime & ", WORKTIME_END))=0 and datediff(mm, '" & FrmDeal.dtpTime.Value & "', dateAdd(hh, " & OffsetTime & ", WORKTIME_END))=0 order by DEPT_CODE, WORKTIME_END "
                statDate = FrmDeal.dtpTime.Value
                strDept = FrmDeal.cbDepart.Text

                Call myDataGrid()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
        Call PrintExcel()
    End Sub

    Private Sub PrintExcel() '��ӡ��Excel        

        Dim Row As Integer
        Dim Col As Integer

        Try
            Call MakeExcel()

            Row = ds.Tables(0).Rows.Count + 4
            Col = Me.C1DBG.Columns.Count - ColNum
            '**************���߿�
            For Row = 2 To ds.Tables(0).Rows.Count + 4 '����
                xlSheet.Range(xlSheet.Cells(Row, 1), xlSheet.Cells(Row, C1DBG.Columns.Count - ColNum)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 7
            Next Row
            For Col = 1 To C1DBG.Columns.Count - ColNum + 1 '����
                xlSheet.Range(xlSheet.Cells(3, Col), xlSheet.Cells(ds.Tables(0).Rows.Count + 4, Col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7
            Next Col

        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try

    End Sub

    Private Sub GetSheetExcel()
        Dim PathStr As String
        Dim FilePath As String
        Dim Row As Integer
        Dim Col As Integer
        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        Try
            FilePath = PathStr + "ReportCopy.xls"
            FileCopy(PathStr & "Report_Pan.xls", FilePath)

            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)
            xlSheet = CType(xlBook.Worksheets(14), Excel.Worksheet)
            xlSheet.Select(14)
            xlApp.DisplayAlerts = False
            xlSheet.Application.Visible = True

            Dim i As Integer = 0

            For Row = 0 To ds.Tables(0).Rows.Count - 1  '��װ���
                If IsNumeric(C1DBG.Columns("YuanPeiAmount1").CellText(Row)) Or IsNumeric(C1DBG.Columns("YuanPeiTons1").CellText(Row)) Or IsNumeric(C1DBG.Columns("WanChuanAmount1").CellText(Row)) Then
                    xlSheet.Cells(6 + i, 2) = Me.C1DBG.Columns("FILE_NO").CellText(Row)
                    xlSheet.Cells(6 + i, 3) = Me.C1DBG.Columns("BERTHNO").CellText(Row)
                    xlSheet.Cells(6 + i, 4) = Me.C1DBG.Columns("CHI_VESSEL").CellText(Row)
                    xlSheet.Cells(6 + i, 5) = Me.C1DBG.Columns("NATIONALITY_CHA").CellText(Row)
                    xlSheet.Cells(6 + i, 6) = Me.C1DBG.Columns("GOODS").CellText(Row)
                    xlSheet.Cells(6 + i, 7) = Me.C1DBG.Columns("InOutPort_Name").CellText(Row)
                    If Me.C1DBG.Columns("InOutPort_Name").CellText(Row) = "����" Then
                        xlSheet.Cells(6 + i, 8) = Me.C1DBG.Columns("ToPort").CellText(Row)
                    Else
                        xlSheet.Cells(6 + i, 8) = Me.C1DBG.Columns("FromPort").CellText(Row)
                    End If
                    xlSheet.Cells(6 + i, 9) = Me.C1DBG.Columns("YuanPeiAmount1").CellText(Row)
                    xlSheet.Cells(6 + i, 10) = Me.C1DBG.Columns("YuanPeiTons1").CellText(Row)
                    xlSheet.Cells(6 + i, 11) = Me.C1DBG.Columns("WanChuanAmount1").CellText(Row)
                    xlSheet.Cells(6 + i, 13) = Me.C1DBG.Columns("WORKTIME_BEGIN").CellText(Row)
                    xlSheet.Cells(6 + i, 14) = Me.C1DBG.Columns("WORKTIME_END").CellText(Row)
                    xlSheet.Cells(6 + i, 15) = Me.C1DBG.Columns("SHIPAGENT_CHA").CellText(Row)
                    xlSheet.Cells(6 + i, 16) = Me.C1DBG.Columns("Money").CellText(Row)

                    xlSheet.Cells(6 + i, 1) = i + 1
                    i += 1
                End If
            Next
            For Row = 0 To ds.Tables(0).Rows.Count - 1      '���ӻ���
                If IsNumeric(C1DBG.Columns("YuanPeiAmount2").CellText(Row)) Or IsNumeric(C1DBG.Columns("YuanPeiTons2").CellText(Row)) Or IsNumeric(C1DBG.Columns("WanChuanAmount2").CellText(Row)) Or IsNumeric(C1DBG.Columns("WanChuanTons2").CellText(Row)) Then
                    xlSheet.Cells(6 + i, 2) = Me.C1DBG.Columns("FILE_NO").CellText(Row)
                    xlSheet.Cells(6 + i, 3) = Me.C1DBG.Columns("BERTHNO").CellText(Row)
                    xlSheet.Cells(6 + i, 4) = Me.C1DBG.Columns("CHI_VESSEL").CellText(Row)
                    xlSheet.Cells(6 + i, 5) = Me.C1DBG.Columns("NATIONALITY_CHA").CellText(Row)
                    xlSheet.Cells(6 + i, 6) = Me.C1DBG.Columns("GOODS").CellText(Row)
                    xlSheet.Cells(6 + i, 7) = Me.C1DBG.Columns("InOutPort_Name").CellText(Row)
                    If Me.C1DBG.Columns("InOutPort_Name").CellText(Row) = "����" Then
                        xlSheet.Cells(6 + i, 8) = Me.C1DBG.Columns("ToPort").CellText(Row)
                    Else
                        xlSheet.Cells(6 + i, 8) = Me.C1DBG.Columns("FromPort").CellText(Row)
                    End If
                    xlSheet.Cells(6 + i, 9) = Me.C1DBG.Columns("YuanPeiAmount2").CellText(Row)
                    xlSheet.Cells(6 + i, 10) = Me.C1DBG.Columns("YuanPeiTons2").CellText(Row)
                    xlSheet.Cells(6 + i, 11) = Me.C1DBG.Columns("WanChuanAmount2").CellText(Row)
                    xlSheet.Cells(6 + i, 12) = Me.C1DBG.Columns("WanChuanTons2").CellText(Row)
                    xlSheet.Cells(6 + i, 13) = Me.C1DBG.Columns("WORKTIME_BEGIN").CellText(Row)
                    xlSheet.Cells(6 + i, 14) = Me.C1DBG.Columns("WORKTIME_END").CellText(Row)
                    xlSheet.Cells(6 + i, 15) = Me.C1DBG.Columns("SHIPAGENT_CHA").CellText(Row)
                    xlSheet.Cells(6 + i, 16) = Me.C1DBG.Columns("Money").CellText(Row)

                    xlSheet.Cells(6 + i, 1) = i + 1
                    i += 1
                End If
            Next
            For Row = 0 To ds.Tables(0).Rows.Count - 1      'ɢ����
                If IsNumeric(C1DBG.Columns("YuanPeiTons3").CellText(Row)) Or IsNumeric(C1DBG.Columns("WanChuanAmount3").CellText(Row)) Or IsNumeric(C1DBG.Columns("WanChuanTons3").CellText(Row)) Then
                    xlSheet.Cells(6 + i, 2) = Me.C1DBG.Columns("FILE_NO").CellText(Row)
                    xlSheet.Cells(6 + i, 3) = Me.C1DBG.Columns("BERTHNO").CellText(Row)
                    xlSheet.Cells(6 + i, 4) = Me.C1DBG.Columns("CHI_VESSEL").CellText(Row)
                    xlSheet.Cells(6 + i, 5) = Me.C1DBG.Columns("NATIONALITY_CHA").CellText(Row)
                    xlSheet.Cells(6 + i, 6) = Me.C1DBG.Columns("GOODS").CellText(Row)
                    xlSheet.Cells(6 + i, 7) = Me.C1DBG.Columns("InOutPort_Name").CellText(Row)
                    If Me.C1DBG.Columns("InOutPort_Name").CellText(Row) = "����" Then
                        xlSheet.Cells(6 + i, 8) = Me.C1DBG.Columns("ToPort").CellText(Row)
                    Else
                        xlSheet.Cells(6 + i, 8) = Me.C1DBG.Columns("FromPort").CellText(Row)
                    End If
                    xlSheet.Cells(6 + i, 10) = Me.C1DBG.Columns("YuanPeiTons3").CellText(Row)
                    xlSheet.Cells(6 + i, 11) = Me.C1DBG.Columns("WanChuanAmount3").CellText(Row)
                    xlSheet.Cells(6 + i, 12) = Me.C1DBG.Columns("WanChuanTons3").CellText(Row)
                    xlSheet.Cells(6 + i, 13) = Me.C1DBG.Columns("WORKTIME_BEGIN").CellText(Row)
                    xlSheet.Cells(6 + i, 14) = Me.C1DBG.Columns("WORKTIME_END").CellText(Row)
                    xlSheet.Cells(6 + i, 15) = Me.C1DBG.Columns("SHIPAGENT_CHA").CellText(Row)
                    xlSheet.Cells(6 + i, 16) = Me.C1DBG.Columns("Money").CellText(Row)

                    xlSheet.Cells(6 + i, 1) = i + 1
                    i += 1
                End If
            Next
            For Row = 0 To ds.Tables(0).Rows.Count - 1      'ȫ�յ�
                If Not IsNumeric(C1DBG.Columns("YuanPeiAmount1").CellText(Row)) And Not IsNumeric(C1DBG.Columns("YuanPeiTons1").CellText(Row)) And Not IsNumeric(C1DBG.Columns("WanChuanAmount1").CellText(Row)) And Not IsNumeric(C1DBG.Columns("YuanPeiAmount2").CellText(Row)) And Not IsNumeric(C1DBG.Columns("YuanPeiTons2").CellText(Row)) And Not IsNumeric(C1DBG.Columns("WanChuanAmount2").CellText(Row)) And Not IsNumeric(C1DBG.Columns("WanChuanTons2").CellText(Row)) And Not IsNumeric(C1DBG.Columns("YuanPeiTons3").CellText(Row)) And Not IsNumeric(C1DBG.Columns("WanChuanAmount3").CellText(Row)) And Not IsNumeric(C1DBG.Columns("WanChuanTons3").CellText(Row)) Then
                    xlSheet.Cells(6 + i, 2) = Me.C1DBG.Columns("FILE_NO").CellText(Row)
                    xlSheet.Cells(6 + i, 3) = Me.C1DBG.Columns("BERTHNO").CellText(Row)
                    xlSheet.Cells(6 + i, 4) = Me.C1DBG.Columns("CHI_VESSEL").CellText(Row)
                    xlSheet.Cells(6 + i, 5) = Me.C1DBG.Columns("NATIONALITY_CHA").CellText(Row)
                    xlSheet.Cells(6 + i, 6) = Me.C1DBG.Columns("GOODS").CellText(Row)
                    xlSheet.Cells(6 + i, 7) = Me.C1DBG.Columns("InOutPort_Name").CellText(Row)
                    If Me.C1DBG.Columns("InOutPort_Name").CellText(Row) = "����" Then
                        xlSheet.Cells(6 + i, 8) = Me.C1DBG.Columns("ToPort").CellText(Row)
                    Else
                        xlSheet.Cells(6 + i, 8) = Me.C1DBG.Columns("FromPort").CellText(Row)
                    End If

                    xlSheet.Cells(6 + i, 13) = Me.C1DBG.Columns("WORKTIME_BEGIN").CellText(Row)
                    xlSheet.Cells(6 + i, 14) = Me.C1DBG.Columns("WORKTIME_END").CellText(Row)
                    xlSheet.Cells(6 + i, 15) = Me.C1DBG.Columns("SHIPAGENT_CHA").CellText(Row)
                    xlSheet.Cells(6 + i, 16) = Me.C1DBG.Columns("Money").CellText(Row)

                    xlSheet.Cells(6 + i, 1) = i + 1
                    i += 1
                End If
            Next

            For Row = 1 To i    '������
                If Row Mod 15 = 0 Or Row = i Then
                    xlSheet.Range(xlSheet.Cells(Row + 5, 1), xlSheet.Cells(Row + 5, 17)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 12
                Else
                    xlSheet.Range(xlSheet.Cells(Row + 5, 1), xlSheet.Cells(Row + 5, 17)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 1
                End If
            Next
            For Col = 1 To 18       '������
                If Col = 1 Or Col = 18 Then
                    xlSheet.Range(xlSheet.Cells(6, Col), xlSheet.Cells(i + 5, Col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 12
                Else
                    xlSheet.Range(xlSheet.Cells(6, Col), xlSheet.Cells(i + 5, Col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 1
                End If
            Next
            xlSheet.Cells(2, 1) = strDept
            Dim strDate As String
            strDate = statDate.Year & "�� " & statDate.Month & "��"
            xlSheet.Cells(2, 6) = strDate
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub mnuExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExport.Click
        'Call ExportExcel()
        Call GetSheetExcel()
    End Sub

    Private Sub ExportExcel() '����Excel        
        Call MakeExcel()
    End Sub

    Private Sub MakeExcel()
        Dim PathStr As String
        Dim FilePath As String
        Dim Row As Integer
        Dim Col As Integer
        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        Try
            FilePath = PathStr + "Report.xls"
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)
            xlSheet = CType(xlBook.Worksheets(1), Excel.Worksheet)
            xlApp.DisplayAlerts = False
            xlSheet.Application.Visible = True

            xlSheet.Cells(1, 1) = Me.Text() '����

            For Col = ColNum To Me.C1DBG.Columns.Count - 1 '�б���
                xlSheet.Cells(3, Col - ColNum + 1) = Me.C1DBG.Columns(Col).Caption

            Next Col
            Me.C1DBG.MoveFirst()
            For Row = 0 To ds.Tables(0).Rows.Count - 1 '����
                For Col = ColNum To Me.C1DBG.Columns.Count - 1
                    xlSheet.Cells(Row + 4, Col - ColNum + 1) = Me.C1DBG.Columns(Col).Text.ToString      'ds.Tables(0).Rows(Row)(Col)
                Next Col
                Me.C1DBG.MoveNext()
            Next Row
            If Me.C1DBG.ColumnFooters = True Then '�ϼ���
                For Col = ColNum To Me.C1DBG.Columns.Count - 1
                    xlSheet.Cells(ds.Tables(0).Rows.Count + 4, Col - ColNum + 1) = Me.C1DBG.Columns(Col).FooterText
                Next Col
            End If
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try

    End Sub

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        TBar = 1
        Mnu = 1
        Me.Close()
    End Sub

    Private Sub ToolBar_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar.ButtonClick
        Select Case Me.ToolBar.Buttons.IndexOf(e.Button)
            Case 0
                mnuFind_Click(sender, e)
                'Case 1
                '    Call mnuQuery_Click(sender, e)
            Case 2

            Case 3
                Call mnuAdd_Click(sender, e)
                'Case 4
                '    Call mnuEdit_Click(sender, e)
                'Case 5
                '    Call mnuDelete_Click(sender, e)
            Case 6

            Case 7
                Call mnuPrint_Click(sender, e)
            Case 8
                Call mnuExport_Click(sender, e)
            Case 9

            Case 10
                Call mnuQuit_Click(sender, e)
        End Select
    End Sub

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        TBar = 1
        Mnu = 1
    End Sub

    Private Sub SetColumnWidth()
        Try
            Dim j As Integer
            For j = 0 To Me.C1DBG.Columns.Count - 1
                Me.C1DBG.Splits(0).DisplayColumns.Item(j).AutoSize()
                Me.C1DBG.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                If Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width < 65 Then
                    Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width = 65
                Else
                    If Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width > 130 Then
                        Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width = 130
                    End If
                End If
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub preview(ByVal Func As String) '***************Ȩ�����
        Dim sqlstr As String
        Dim Previewdv As DataView
        Dim Previewds As New DataSet()
        Dim i As Integer
        sqlstr = " select FUNC_CODE_Add,FUNC_CODE_Change,FUNC_CODE_Del from View_UserPreview where PART_ID=" & G_Part_Id & " and FUNC_CODE='" & Upper(Func) & "' "
        Previewdv = Getdata(sqlstr, Previewds)
        If Previewdv.Count > 0 Then
            If Previewdv(i)("FUNC_CODE_Add") = 1 Then 'ADD ��ť�ɼ�
                ToolBar.Buttons.Item(3).Enabled = True
                mnuAdd.Enabled = True
            Else                                      'ADD ��ť���ɼ�
                Me.ToolBar.Buttons.Item(3).Enabled = False
                mnuAdd.Enabled = False
            End If
            If Previewdv(i)("FUNC_CODE_Change") = 1 Then '�޸� ��ť�ɼ�
                Me.ToolBar.Buttons.Item(4).Enabled = True
                mnuEdit.Enabled = True
            Else                                          '�޸� ��ť���ɼ�
                Me.ToolBar.Buttons.Item(4).Enabled = False
                mnuEdit.Enabled = False
            End If
            If Previewdv(i)("FUNC_CODE_Del") = 1 Then 'ɾ�� ��ť�ɼ�
                Me.ToolBar.Buttons.Item(5).Enabled = True
                mnuDelete.Enabled = True
            Else                                     'ɾ�� ��ť���ɼ�
                Me.ToolBar.Buttons.Item(5).Enabled = False
                mnuDelete.Enabled = False
            End If
        End If

    End Sub

End Class