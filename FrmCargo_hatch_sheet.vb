Imports TALLY.DBControl
Public Class FrmCargo_hatch_sheet
    Inherits System.Windows.Forms.Form
    Dim dsShip As New DataSet '�������ݼ�
    Dim SqlStrShip As String  '�����������
    Dim FirmShip As String
    Dim SortShip As String
    Dim dsSShip As New DataSet
    Dim info As String
    Dim ds As New DataSet
    Dim SqlStr As String  '�������
    Dim SelectStr As String
    Dim DynaStr As String '�ɱ���������
    Dim FirmStr As String '������������
    Dim ColNum As Integer '����ʾ������

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    '������д��������������б�
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
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFind As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuery As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrint As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExport As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCompile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents GBV As System.Windows.Forms.GroupBox
    Friend WithEvents ToolBarV As System.Windows.Forms.ToolBar
    Friend WithEvents C1DBGV As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents S1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnOK As System.Windows.Forms.ToolBarButton
    Friend WithEvents S2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSearch As System.Windows.Forms.ToolBarButton
    Friend WithEvents S3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSort As System.Windows.Forms.ToolBarButton
    Friend WithEvents S4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnEng As System.Windows.Forms.ToolBarButton
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents tbbtnFind As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuery As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnEdit As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnPrint As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnExport As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuit As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtndefine As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnDoprint As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnudefine As System.Windows.Forms.MenuItem
    Friend WithEvents mnudoprint As System.Windows.Forms.MenuItem
    Friend WithEvents btResure As System.Windows.Forms.Button
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCargo_hatch_sheet))
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.MainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuFind = New System.Windows.Forms.MenuItem
        Me.mnuQuery = New System.Windows.Forms.MenuItem
        Me.mnuSep1 = New System.Windows.Forms.MenuItem
        Me.mnuPrint = New System.Windows.Forms.MenuItem
        Me.mnuExport = New System.Windows.Forms.MenuItem
        Me.mnuSep2 = New System.Windows.Forms.MenuItem
        Me.mnuQuit = New System.Windows.Forms.MenuItem
        Me.mnuCompile = New System.Windows.Forms.MenuItem
        Me.mnudefine = New System.Windows.Forms.MenuItem
        Me.mnuEdit = New System.Windows.Forms.MenuItem
        Me.mnudoprint = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.GBV = New System.Windows.Forms.GroupBox
        Me.btResure = New System.Windows.Forms.Button
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolBarV = New System.Windows.Forms.ToolBar
        Me.S1 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnOK = New System.Windows.Forms.ToolBarButton
        Me.S2 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSearch = New System.Windows.Forms.ToolBarButton
        Me.S3 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSort = New System.Windows.Forms.ToolBarButton
        Me.S4 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnEng = New System.Windows.Forms.ToolBarButton
        Me.C1DBGV = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.GB = New System.Windows.Forms.GroupBox
        Me.Label = New System.Windows.Forms.Label
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.ToolBar = New System.Windows.Forms.ToolBar
        Me.tbbtnFind = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuery = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep1 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnEdit = New System.Windows.Forms.ToolBarButton
        Me.tbbtndefine = New System.Windows.Forms.ToolBarButton
        Me.tbbtnDoprint = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep2 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnPrint = New System.Windows.Forms.ToolBarButton
        Me.tbbtnExport = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep3 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuit = New System.Windows.Forms.ToolBarButton
        Me.GBV.SuspendLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB.SuspendLayout()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "")
        Me.ImageList.Images.SetKeyName(1, "")
        Me.ImageList.Images.SetKeyName(2, "")
        Me.ImageList.Images.SetKeyName(3, "")
        Me.ImageList.Images.SetKeyName(4, "")
        Me.ImageList.Images.SetKeyName(5, "")
        Me.ImageList.Images.SetKeyName(6, "")
        Me.ImageList.Images.SetKeyName(7, "")
        Me.ImageList.Images.SetKeyName(8, "")
        Me.ImageList.Images.SetKeyName(9, "")
        Me.ImageList.Images.SetKeyName(10, "")
        Me.ImageList.Images.SetKeyName(11, "")
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
        'mnuFind
        '
        Me.mnuFind.Enabled = False
        Me.mnuFind.Index = 0
        Me.mnuFind.Text = "����(&F)"
        '
        'mnuQuery
        '
        Me.mnuQuery.Enabled = False
        Me.mnuQuery.Index = 1
        Me.mnuQuery.Text = "�鿴(&Q)"
        '
        'mnuSep1
        '
        Me.mnuSep1.Index = 2
        Me.mnuSep1.Text = "-"
        '
        'mnuPrint
        '
        Me.mnuPrint.Enabled = False
        Me.mnuPrint.Index = 3
        Me.mnuPrint.Text = "��ӡ(&P)..."
        '
        'mnuExport
        '
        Me.mnuExport.Enabled = False
        Me.mnuExport.Index = 4
        Me.mnuExport.Text = "����(&E)"
        '
        'mnuSep2
        '
        Me.mnuSep2.Index = 5
        Me.mnuSep2.Text = "-"
        '
        'mnuQuit
        '
        Me.mnuQuit.Index = 6
        Me.mnuQuit.Text = "�˳�(&X)"
        '
        'mnuCompile
        '
        Me.mnuCompile.Index = 1
        Me.mnuCompile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnudefine, Me.mnuEdit, Me.mnudoprint})
        Me.mnuCompile.Text = "�༭(&E)"
        '
        'mnudefine
        '
        Me.mnudefine.Enabled = False
        Me.mnudefine.Index = 0
        Me.mnudefine.Text = "����(&A)"
        '
        'mnuEdit
        '
        Me.mnuEdit.Enabled = False
        Me.mnuEdit.Index = 1
        Me.mnuEdit.Text = "�༭(&E)"
        '
        'mnudoprint
        '
        Me.mnudoprint.Enabled = False
        Me.mnudoprint.Index = 2
        Me.mnudoprint.Text = "�б�(&D)"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.Text = "����(&H)"
        '
        'GBV
        '
        Me.GBV.Controls.Add(Me.btResure)
        Me.GBV.Controls.Add(Me.txtVoyage)
        Me.GBV.Controls.Add(Me.Label2)
        Me.GBV.Controls.Add(Me.txtShipName)
        Me.GBV.Controls.Add(Me.Label1)
        Me.GBV.Controls.Add(Me.ToolBarV)
        Me.GBV.Controls.Add(Me.C1DBGV)
        Me.GBV.Dock = System.Windows.Forms.DockStyle.Left
        Me.GBV.Location = New System.Drawing.Point(0, 0)
        Me.GBV.Name = "GBV"
        Me.GBV.Size = New System.Drawing.Size(174, 436)
        Me.GBV.TabIndex = 1
        Me.GBV.TabStop = False
        '
        'btResure
        '
        Me.btResure.Location = New System.Drawing.Point(128, 332)
        Me.btResure.Name = "btResure"
        Me.btResure.Size = New System.Drawing.Size(42, 22)
        Me.btResure.TabIndex = 16
        Me.btResure.Text = "��ѯ"
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(38, 332)
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(88, 21)
        Me.txtVoyage.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 14)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "����"
        '
        'txtShipName
        '
        Me.txtShipName.Location = New System.Drawing.Point(38, 308)
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.Size = New System.Drawing.Size(132, 21)
        Me.txtShipName.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 310)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "����"
        '
        'ToolBarV
        '
        Me.ToolBarV.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.S1, Me.tbbtnOK, Me.S2, Me.tbbtnSearch, Me.S3, Me.tbbtnSort, Me.S4, Me.tbbtnEng})
        Me.ToolBarV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBarV.DropDownArrows = True
        Me.ToolBarV.ImageList = Me.ImageList
        Me.ToolBarV.Location = New System.Drawing.Point(3, 392)
        Me.ToolBarV.Name = "ToolBarV"
        Me.ToolBarV.ShowToolTips = True
        Me.ToolBarV.Size = New System.Drawing.Size(168, 41)
        Me.ToolBarV.TabIndex = 1
        '
        'S1
        '
        Me.S1.Name = "S1"
        Me.S1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnOK
        '
        Me.tbbtnOK.ImageIndex = 8
        Me.tbbtnOK.Name = "tbbtnOK"
        Me.tbbtnOK.Text = "����"
        '
        'S2
        '
        Me.S2.Name = "S2"
        Me.S2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnSearch
        '
        Me.tbbtnSearch.ImageIndex = 9
        Me.tbbtnSearch.Name = "tbbtnSearch"
        Me.tbbtnSearch.Text = "����"
        '
        'S3
        '
        Me.S3.Name = "S3"
        Me.S3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnSort
        '
        Me.tbbtnSort.ImageIndex = 10
        Me.tbbtnSort.Name = "tbbtnSort"
        Me.tbbtnSort.Text = "����"
        '
        'S4
        '
        Me.S4.Name = "S4"
        Me.S4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnEng
        '
        Me.tbbtnEng.ImageIndex = 11
        Me.tbbtnEng.Name = "tbbtnEng"
        Me.tbbtnEng.Text = "Ӣ��"
        '
        'C1DBGV
        '
        Me.C1DBGV.AllowUpdate = False
        Me.C1DBGV.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1DBGV.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGV.Images.Add(CType(resources.GetObject("C1DBGV.Images"), System.Drawing.Image))
        Me.C1DBGV.Location = New System.Drawing.Point(3, 17)
        Me.C1DBGV.Name = "C1DBGV"
        Me.C1DBGV.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGV.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGV.PreviewInfo.ZoomFactor = 75
        Me.C1DBGV.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGV.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGV.Size = New System.Drawing.Size(168, 289)
        Me.C1DBGV.TabIndex = 0
        Me.C1DBGV.Text = "C1TrueDBGrid1"
        Me.C1DBGV.PropBag = resources.GetString("C1DBGV.PropBag")
        '
        'GB
        '
        Me.GB.Controls.Add(Me.Label)
        Me.GB.Controls.Add(Me.C1DBG)
        Me.GB.Controls.Add(Me.ToolBar)
        Me.GB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB.Location = New System.Drawing.Point(174, 0)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(542, 436)
        Me.GB.TabIndex = 2
        Me.GB.TabStop = False
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.SystemColors.Control
        Me.Label.Location = New System.Drawing.Point(6, 58)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(530, 32)
        Me.Label.TabIndex = 11
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("C1DBG.Images"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(3, 92)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG.Size = New System.Drawing.Size(532, 336)
        Me.C1DBG.TabIndex = 10
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = resources.GetString("C1DBG.PropBag")
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnFind, Me.tbbtnQuery, Me.tbbtnSep1, Me.tbbtnEdit, Me.tbbtndefine, Me.tbbtnDoprint, Me.tbbtnSep2, Me.tbbtnPrint, Me.tbbtnExport, Me.tbbtnSep3, Me.tbbtnQuit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.Enabled = False
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(3, 17)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(536, 41)
        Me.ToolBar.TabIndex = 9
        '
        'tbbtnFind
        '
        Me.tbbtnFind.ImageIndex = 0
        Me.tbbtnFind.Name = "tbbtnFind"
        Me.tbbtnFind.Text = "����"
        Me.tbbtnFind.ToolTipText = "����"
        '
        'tbbtnQuery
        '
        Me.tbbtnQuery.ImageIndex = 1
        Me.tbbtnQuery.Name = "tbbtnQuery"
        Me.tbbtnQuery.Text = "�鿴"
        Me.tbbtnQuery.ToolTipText = "�鿴"
        '
        'tbbtnSep1
        '
        Me.tbbtnSep1.Name = "tbbtnSep1"
        Me.tbbtnSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnEdit
        '
        Me.tbbtnEdit.ImageIndex = 3
        Me.tbbtnEdit.Name = "tbbtnEdit"
        Me.tbbtnEdit.Text = "�༭"
        Me.tbbtnEdit.ToolTipText = "�༭"
        '
        'tbbtndefine
        '
        Me.tbbtndefine.ImageIndex = 2
        Me.tbbtndefine.Name = "tbbtndefine"
        Me.tbbtndefine.Text = "����"
        Me.tbbtndefine.ToolTipText = "����"
        '
        'tbbtnDoprint
        '
        Me.tbbtnDoprint.ImageIndex = 4
        Me.tbbtnDoprint.Name = "tbbtnDoprint"
        Me.tbbtnDoprint.Text = "�б�"
        Me.tbbtnDoprint.ToolTipText = "ɾ��"
        '
        'tbbtnSep2
        '
        Me.tbbtnSep2.Name = "tbbtnSep2"
        Me.tbbtnSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnPrint
        '
        Me.tbbtnPrint.ImageIndex = 5
        Me.tbbtnPrint.Name = "tbbtnPrint"
        Me.tbbtnPrint.Text = "��ӡ"
        Me.tbbtnPrint.ToolTipText = "��ӡ"
        '
        'tbbtnExport
        '
        Me.tbbtnExport.ImageIndex = 6
        Me.tbbtnExport.Name = "tbbtnExport"
        Me.tbbtnExport.Text = "����"
        Me.tbbtnExport.ToolTipText = "����Excel"
        '
        'tbbtnSep3
        '
        Me.tbbtnSep3.Name = "tbbtnSep3"
        Me.tbbtnSep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnQuit
        '
        Me.tbbtnQuit.ImageIndex = 7
        Me.tbbtnQuit.Name = "tbbtnQuit"
        Me.tbbtnQuit.Text = "�˳�"
        Me.tbbtnQuit.ToolTipText = "�˳�"
        '
        'FrmCargo_hatch_sheet
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(716, 436)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.GBV)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu
        Me.MinimizeBox = False
        Me.Name = "FrmCargo_hatch_sheet"
        Me.Text = "��ҵ�ֲյ�"
        Me.GBV.ResumeLayout(False)
        Me.GBV.PerformLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCargo_hatch_sheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Text = Me.Text & "_" & G_DeptName

        SortShip = " Order by Ship_Statu,Dept_Code,id desc " 'Ĭ�ϵ����� 
        FirmShip = "where DEPT_CODE LIKE '" & G_DeptCode & "%' and code_goods<>'2' " '����������������

        SqlStrShip = "where (DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('2','3')) and code_goods<>'2' " ' OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0) "
        Call myDataGridShip(SqlStrShip & SortShip)   '*****************���ú�����Ϣ
        Me.C1DBGV.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        txtShipName.Text = G_ShipName
        txtVoyage.Text = G_Voyage
        Call btResure_Click(sender, e)
    End Sub

    Private Sub myDataGridShip(ByVal Sql As String) '**************������Ϣ
        Dim strsql As String
        Dim i As Integer
        strsql = "select SHIP_ID as ID ,SHIP_STATU,INOUTPORT,DEPT_CODE,ENG_VESSEL,CHI_VESSEL,VOYAGE,InOutPort_Name,Dept_Short from View_SSHip " '����������� ���Ĳ���
        strsql = strsql & Sql
        Try
            Me.C1DBGV.DataSource = Getdata(strsql, dsShip)
            For i = 0 To 4 '��Ʋ���ʾ����
                Me.C1DBGV.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Call SetColumnCaptionShip() '����б���
            Call SetColumnWidthShip() '����п��
            If dsShip.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumShip(5)  '��ƺϼ���
            End If
            Me.C1DBGV.FetchRowStyles = True
            Me.C1DBGV.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaptionShip() '*****************���α���
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Try
            str = "select Field_Eng,Field_Cha From Field_Att where Table_Name='View_SSHip'"
            sqlconn.ConnectionString = conn
            sqlc.Connection = sqlconn
            sqlc.CommandText = str
            sqla.SelectCommand = sqlc
            dset.Reset()
            sqla.Fill(dset)
            i = 4

            Do While i < Me.C1DBGV.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGV.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBGV.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
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

    Private Sub SetColumnWidthShip() '************�����п�
        Dim i As Integer
        Try
            Me.C1DBGV.Splits(0).DisplayColumns.Item(4).Width = Me.C1DBGV.Width / 2 - 25
            Me.C1DBGV.Splits(0).DisplayColumns.Item(5).Width = Me.C1DBGV.Width / 2 - 25
            Me.C1DBGV.Splits(0).DisplayColumns.Item(6).Width = 35
            Me.C1DBGV.Splits(0).DisplayColumns.Item(7).Width = 24
            Me.C1DBGV.Splits(0).DisplayColumns.Item(8).Width = 18
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnSumShip(ByVal Col As Integer) '****************���λ�����
        Me.C1DBGV.ColumnFooters = True
        Me.C1DBGV.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGV.Columns.Item(Col).FooterText = "�� " & dsShip.Tables(0).Rows.Count & " ��"
    End Sub

    Private Sub ToolBarV_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBarV.ButtonClick
        Select Case Me.ToolBarV.Buttons.IndexOf(e.Button)
            Case 1
                SqlStrShip = "where (DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('2','3')) and code_goods<>'2' " ' OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0) " '�����ɱ���������

                SortShip = " Order by Ship_Statu,Dept_Code,id desc "
                Call myDataGridShip(SqlStrShip & " " & SortShip)

            Case 3
                Dim FrmFind As New FrmFind
                Table_Name = "SSHIP"
                FrmFind.ShowDialog()

                If Flag = 0 Then
                    Call myDataGridShip(FirmShip & "and (" & Sql_Find & ")  " & SortShip)    '����Ҫ�޸�
                    SqlStrShip = FirmStr & "and (" & Sql_Find & ")  "    '����Ҫ�޸�
                ElseIf Flag = 2 Then
                    SqlStrShip = "where (DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','4')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)  and code_goods<>'2' "
                    '����Ҫ�޸�
                    Call myDataGridShip(SqlStrShip & " " & SortShip)   '����Ҫ�޸�
                End If

            Case 5
                Dim FrmSort As New FrmSort
                FrmSort.ShowDialog()
                If Len(Trim(SortStr)) > 0 Then
                    SortShip = " Order by " & SortStr
                End If
                Call myDataGridShip(SqlStrShip & " " & SortShip)

            Case 7
                Me.C1DBGV.Splits(0).DisplayColumns.Item(4).Visible = True
                Me.C1DBGV.Splits(0).DisplayColumns.Item(5).Visible = False
                If dsShip.Tables(0).Rows.Count > 0 Then
                    Call SetColumnSumShip(4)  '��ƺϼ���
                End If
                Me.C1DBGV.FetchRowStyles = True
                Me.C1DBGV.Refresh()
        End Select
    End Sub

    Private Sub C1DBGV_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBGV.FetchRowStyle
        If Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 1 Then
            e.CellStyle.BackColor = System.Drawing.Color.White
        ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 2 Then
            e.CellStyle.BackColor = System.Drawing.Color.PaleGreen
        ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 3 Then
            e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
        ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 4 Then
            e.CellStyle.BackColor = System.Drawing.Color.Pink
        End If
    End Sub

    Private Sub C1DBGV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBGV.DoubleClick
        On Error GoTo Err

        Dim strsql As String
        Dim dw As New DataView
        Ship_ID = CType(Me.C1DBGV.Columns.Item("ID").Text.ToString, Integer)
        strsql = "select * from View_SSHIP where SHIP_ID=" & Ship_ID
        dw = Getdata(strsql, dsSShip)
        Label.Text = ""
        If dsSShip.Tables(0).DefaultView.Count > 0 Then
            If Len(Trim(dsSShip.Tables(0).Rows(0).Item("CHI_VESSEL"))) > 0 Then
                Label.Text = Label.Text & "���Ĵ���:" & Trim(dsSShip.Tables(0).Rows(0).Item("CHI_VESSEL")) & " "
                G_ShipName = Trim(dsSShip.Tables(0).Rows(0).Item("CHI_VESSEL"))
                txtShipName.Text = Trim(dsSShip.Tables(0).Rows(0).Item("CHI_VESSEL"))
            End If
            If Len(Trim(dsSShip.Tables(0).Rows(0).Item("ENG_VESSEL"))) > 0 Then
                Label.Text = Label.Text & "Ӣ�Ĵ���:" & Trim(dsSShip.Tables(0).Rows(0).Item("ENG_VESSEL")) & " "
            End If
            If Len(Trim(dsSShip.Tables(0).Rows(0).Item("Voyage"))) > 0 Then
                Label.Text = Label.Text & "����:" & Trim(dsSShip.Tables(0).Rows(0).Item("Voyage")) & " "
                G_Voyage = Trim(dsSShip.Tables(0).Rows(0).Item("Voyage"))
                txtVoyage.Text = Trim(dsSShip.Tables(0).Rows(0).Item("Voyage"))
            End If
            If Len(Trim(dsSShip.Tables(0).Rows(0).Item("InOutPort_Name"))) > 0 Then
                Label.Text = Label.Text & "������:" & Trim(dsSShip.Tables(0).Rows(0).Item("InOutPort_Name")) & " "
            End If
            info = Label.Text
            If Len(Trim(dsSShip.Tables(0).Rows(0).Item("Trade"))) > 0 Then
                Label.Text = Label.Text & "����ó:" & Trim(dsSShip.Tables(0).Rows(0).Item("Trade")) & " "
            End If
            If Len(Trim(dsSShip.Tables(0).Rows(0).Item("SHIP_TYPE"))) > 0 Then
                Label.Text = Label.Text & "������:" & Trim(dsSShip.Tables(0).Rows(0).Item("SHIP_TYPE")) & " "
            End If
            If Len(Trim(dsSShip.Tables(0).Rows(0).Item("SHIPAGENT_CHAE"))) > 0 Then
                Label.Text = Label.Text & "����:" & Trim(dsSShip.Tables(0).Rows(0).Item("SHIPAGENT_CHA")) & " "
            End If
            If Len(Trim(dsSShip.Tables(0).Rows(0).Item("GOODS"))) > 0 Then
                Label.Text = Label.Text & "����:" & Trim(dsSShip.Tables(0).Rows(0).Item("GOODS")) & " "
            End If
            If Len(Trim(dsSShip.Tables(0).Rows(0).Item("Tons"))) > 0 Then
                Label.Text = Label.Text & "����:" & Trim(dsSShip.Tables(0).Rows(0).Item("Tons")) & " "
            End If
            If Len(Trim(dsSShip.Tables(0).Rows(0).Item("BerthNo"))) > 0 Then
                Label.Text = Label.Text & "��λ:" & Trim(dsSShip.Tables(0).Rows(0).Item("BerthNo")) & " "
            End If
            If Len(Trim(dsSShip.Tables(0).Rows(0).Item("File_No"))) > 0 Then
                Label.Text = Label.Text & "������:" & Trim(dsSShip.Tables(0).Rows(0).Item("File_No")) & " "
            End If
        End If
        If Trim(dsSShip.Tables(0).Rows(0).Item("InOutPort_Name")) = "����" Then
            Hatch_in = 1
        Else
            Hatch_in = 0
        End If
        FirmStr = " and Ship_ID=" & Ship_ID  '��Ƴ�ʼ����  �ڼ����󲻸ı������  '***************Ҫ�޸� �� 2>1
        DynaStr = " 2>1 " '���������ʼ����    �ڼ�������Ҫ������ ***************Ҫ�޸� �� ��������
        SelectStr = " " ' " Top 20 "
        SqlStr = " (" & DynaStr & ")  " & FirmStr
        Me.ToolBar.Enabled = True
        Me.mnudefine.Enabled = True
        Me.mnudoprint.Enabled = True
        Me.mnuEdit.Enabled = True
        Me.mnuExport.Enabled = True
        Me.mnuFind.Enabled = True
        Me.mnuPrint.Enabled = True
        Me.mnuQuery.Enabled = True
        Call preview("WL4_3") '*****************Ȩ����� '*************Ҫ�޸�ģ���
        ExecSql("exec sp_cargo_hatch_sheet '" & Ship_ID & "','" & G_User & "'")
        Call myDataGrid(SelectStr, SqlStr)
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '���ѡ���¼��ɫ
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub myDataGrid(ByVal SelStr As String, ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Dim dscup As New DataSet
        Dim dw As New DataView
        Dim dsp As New DataSet
        Dim p As Integer

        Try
            '����ʾ����������ǰ��
            If Hatch_in = 1 Then
                strsql = "select " & SelStr & " SHIP_ID, ID,UNLOAD_PORT_ENG, BLNO, GOODS_ENG, PACK_ENG, cast(GROSS_WEIGHT/1000.0 as dec(20,6)) as GROSS_WEIGHT, cast(cast(jz as dec(20,4))/1000 as dec(20,4)) as jz, MARK, AMOUNT from view_cargo_hatch_sheet where " & Sql & " Order by unload_port_eng,blno " '******Ҫ�޸�
            Else
                strsql = "select " & SelStr & " SHIP_ID, ID,LOAD_PORT_ENG, BLNO, GOODS_ENG, PACK_ENG, cast(GROSS_WEIGHT/1000.0 as dec(20,6)) as GROSS_WEIGHT, cast(cast(jz as dec(20,4))/1000 as dec(20,4)) as jz, MARK, AMOUNT from view_cargo_hatch_sheet where " & Sql & " Order by LOAD_PORT_ENG,blno " '******Ҫ�޸�
            End If
            Me.C1DBG.DataSource = Getdata(strsql, ds)  ' class dbcontrol getdata fuction
            ColNum = 2 '����ʾ������ '******Ҫ�޸�
            Table_Name = "view_cargo_hatch_sheet" '���������ݿ���� ''******Ҫ�޸�

            For i = 0 To ColNum - 1 '��Ʋ���ʾ����
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            dw = Getdata("exec sp_calcup '" & Ship_ID & "'", dsp)
            'p = dsp.Tables(0).Rows(0).Item("p")
            'For i = 10 + 2 * p To 29
            '    Me.C1DBG.Splits(0).DisplayColumns.Item(i).Visible = False
            'Next
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Translate = True
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Validate = True
            'Me.C1DBG.Splits(0).DisplayColumns.Item("Logic").Visible = False
            'Me.C1DBG.Columns.Item("Make_Date").NumberFormat = "yyyy/MM/dd"

            Call SetColumnCaption() '����б���
            'Me.C1DBG.Columns.Item("jz").NumberFormat = CType(Me.C1DBG.Columns.Item("jz").Text, Double)
            'Me.C1DBG.Columns.Item("jz").NumberFormat = CType(Me.C1DBG.Columns.Item("jz"), String)
            'Me.C1DBG.Columns.Item("UNLOAD_PORT_ENG").Caption = "ж����"

            'dw = Getdata("select * from cargo_hatch_name where ship_id='" & Ship_ID & "'", dscup)
            'If dscup.Tables(0).DefaultView.Count > 0 Then

            '    Me.C1DBG.Columns.Item("PIECE_A").Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_a")), "a��", dscup.Tables(0).Rows(0).Item("hatch_a")) & "����"
            '    Me.C1DBG.Columns.Item("PIECE_B").Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_b")), "b��", dscup.Tables(0).Rows(0).Item("hatch_b")) & "����"
            '    Me.C1DBG.Columns.Item("PIECE_C").Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_c")), "c��", dscup.Tables(0).Rows(0).Item("hatch_c")) & "����"
            '    Me.C1DBG.Columns.Item("PIECE_D").Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_d")), "d��", dscup.Tables(0).Rows(0).Item("hatch_d")) & "����"
            '    Me.C1DBG.Columns.Item("PIECE_E").Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_e")), "e��", dscup.Tables(0).Rows(0).Item("hatch_e")) & "����"
            '    Me.C1DBG.Columns.Item("PIECE_F").Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_f")), "f��", dscup.Tables(0).Rows(0).Item("hatch_f")) & "����"
            '    Me.C1DBG.Columns.Item("PIECE_G").Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_g")), "g��", dscup.Tables(0).Rows(0).Item("hatch_g")) & "����"
            '    Me.C1DBG.Columns.Item("PIECE_H").Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_h")), "h��", dscup.Tables(0).Rows(0).Item("hatch_h")) & "����"
            '    Me.C1DBG.Columns.Item("PIECE_I").Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_i")), "i��", dscup.Tables(0).Rows(0).Item("hatch_i")) & "����"
            '    Me.C1DBG.Columns.Item("PIECE_J").Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_j")), "j��", dscup.Tables(0).Rows(0).Item("hatch_j")) & "����"

            '    Me.C1DBG.Columns.Item("HATCH_POSITION_A").Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_a")), "a��", dscup.Tables(0).Rows(0).Item("hatch_a")) & "λ��"
            '    Me.C1DBG.Columns.Item("HATCH_POSITION_B").Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_b")), "b��", dscup.Tables(0).Rows(0).Item("hatch_b")) & "λ��"
            '    Me.C1DBG.Columns.Item("HATCH_POSITION_C").Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_c")), "c��", dscup.Tables(0).Rows(0).Item("hatch_c")) & "λ��"
            '    Me.C1DBG.Columns.Item("HATCH_POSITION_D").Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_d")), "d��", dscup.Tables(0).Rows(0).Item("hatch_d")) & "λ��"
            '    Me.C1DBG.Columns.Item("HATCH_POSITION_E").Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_e")), "e��", dscup.Tables(0).Rows(0).Item("hatch_e")) & "λ��"
            '    Me.C1DBG.Columns.Item("HATCH_POSITION_F").Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_f")), "f��", dscup.Tables(0).Rows(0).Item("hatch_f")) & "λ��"
            '    Me.C1DBG.Columns.Item("HATCH_POSITION_G").Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_g")), "g��", dscup.Tables(0).Rows(0).Item("hatch_g")) & "λ��"
            '    Me.C1DBG.Columns.Item("HATCH_POSITION_H").Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_h")), "h��", dscup.Tables(0).Rows(0).Item("hatch_h")) & "λ��"
            '    Me.C1DBG.Columns.Item("HATCH_POSITION_I").Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_i")), "i��", dscup.Tables(0).Rows(0).Item("hatch_i")) & "λ��"
            '    Me.C1DBG.Columns.Item("HATCH_POSITION_J").Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_j")), "j��", dscup.Tables(0).Rows(0).Item("hatch_j")) & "λ��"

            '    'Me.C1DBG.Columns.Item(9).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_a")), "a��", dscup.Tables(0).Rows(0).Item("hatch_a")) & "����"
            '    'Me.C1DBG.Columns.Item(11).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_b")), "b��", dscup.Tables(0).Rows(0).Item("hatch_b")) & "����"
            '    'Me.C1DBG.Columns.Item(13).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_c")), "c��", dscup.Tables(0).Rows(0).Item("hatch_c")) & "����"
            '    'Me.C1DBG.Columns.Item(15).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_d")), "d��", dscup.Tables(0).Rows(0).Item("hatch_d")) & "����"
            '    'Me.C1DBG.Columns.Item(17).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_e")), "e��", dscup.Tables(0).Rows(0).Item("hatch_e")) & "����"
            '    'Me.C1DBG.Columns.Item(19).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_f")), "f��", dscup.Tables(0).Rows(0).Item("hatch_f")) & "����"
            '    'Me.C1DBG.Columns.Item(21).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_g")), "g��", dscup.Tables(0).Rows(0).Item("hatch_g")) & "����"
            '    'Me.C1DBG.Columns.Item(23).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_h")), "h��", dscup.Tables(0).Rows(0).Item("hatch_h")) & "����"
            '    'Me.C1DBG.Columns.Item(25).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_i")), "i��", dscup.Tables(0).Rows(0).Item("hatch_i")) & "����"
            '    'Me.C1DBG.Columns.Item(27).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_j")), "j��", dscup.Tables(0).Rows(0).Item("hatch_j")) & "����"

            '    'Me.C1DBG.Columns.Item(10).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_a")), "a��", dscup.Tables(0).Rows(0).Item("hatch_a")) & "λ��"
            '    'Me.C1DBG.Columns.Item(12).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_b")), "b��", dscup.Tables(0).Rows(0).Item("hatch_b")) & "λ��"
            '    'Me.C1DBG.Columns.Item(14).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_c")), "c��", dscup.Tables(0).Rows(0).Item("hatch_c")) & "λ��"
            '    'Me.C1DBG.Columns.Item(16).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_d")), "d��", dscup.Tables(0).Rows(0).Item("hatch_d")) & "λ��"
            '    'Me.C1DBG.Columns.Item(18).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_e")), "e��", dscup.Tables(0).Rows(0).Item("hatch_e")) & "λ��"
            '    'Me.C1DBG.Columns.Item(20).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_f")), "f��", dscup.Tables(0).Rows(0).Item("hatch_f")) & "λ��"
            '    'Me.C1DBG.Columns.Item(22).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_g")), "g��", dscup.Tables(0).Rows(0).Item("hatch_g")) & "λ��"
            '    'Me.C1DBG.Columns.Item(24).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_h")), "h��", dscup.Tables(0).Rows(0).Item("hatch_h")) & "λ��"
            '    'Me.C1DBG.Columns.Item(26).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_i")), "i��", dscup.Tables(0).Rows(0).Item("hatch_i")) & "λ��"
            '    'Me.C1DBG.Columns.Item(28).Caption = IIf(IsDBNull(dscup.Tables(0).Rows(0).Item("hatch_j")), "j��", dscup.Tables(0).Rows(0).Item("hatch_j")) & "λ��"


            'End If
            Call SetColumnWidth() '����п��
            If ds.Tables(0).Rows.Count > 0 Then
                Call SetColumnSum(Sql) '��ƺϼ���
            End If
            'Me.C1DBG.FetchRowStyles = True
            Me.C1DBG.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
            sqlconn.ConnectionString = conn
            sqlc.Connection = sqlconn
            sqlc.CommandText = str
            sqla.SelectCommand = sqlc
            dset.Reset()
            sqla.Fill(dset)
            i = ColNum

            Do While i < Me.C1DBG.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBG.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBG.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
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
    Private Sub SetColumnSum(ByVal sql As String)
        On Error GoTo Err
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
        Dim dset2 As New DataSet
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

                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBG.Columns.Item(i).DataField.ToString)) And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then

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

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        Me.Close()
    End Sub

    Private Sub ToolBar_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar.ButtonClick
        Select Case Me.ToolBar.Buttons.IndexOf(e.Button)
            Case 0
                Call mnuFind_Click(sender, e)
            Case 1
                Call mnuQuery_Click(sender, e)
            Case 2

            Case 3
                Call mnuEdit_Click(sender, e)
            Case 4
                Call mnudefine_Click(sender, e)
            Case 5
                Call mnudoprint_Click(sender, e)
            Case 6

            Case 7
                Call mnuPrint_Click(sender, e)
            Case 8
                Call mnuExport_Click(sender, e)
            Case 9

            Case 10
                Me.Close()
        End Select
    End Sub
    Private Sub mnuFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFind.Click
        Dim FrmFind As New FrmFind
        Table_Name = "View_Cargo_hatch_sheet" '����Ҫ�޸�
        FrmFind.ShowDialog()

        If Flag = 0 Then
            SelectStr = ""
            Call myDataGrid(SelectStr, " (" & Sql_Find & ")  " & FirmStr)  '����Ҫ�޸�
            SqlStr = " (" & Sql_Find & ")  " & FirmStr '����Ҫ�޸�
        ElseIf Flag = 2 Then
            SelectStr = ""
            Call myDataGrid(SelectStr, DynaStr & FirmStr)  '����Ҫ�޸�
            SqlStr = DynaStr & FirmStr '����Ҫ�޸�
        End If
    End Sub

    'Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnudoprint.Click
    '    If ds.Tables(0).Rows.Count > 0 Then
    '        Dim FrmDelete As New FrmCargo_hatch_list_delete() '***********Ҫ�޸�

    '        ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
    '        FrmDelete.ShowDialog()
    '        Try
    '            Call myDataGrid(SelectStr, SqlStr)


    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End If
    'End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        If ds.Tables(0).Rows.Count > 0 Then
            Dim FrmEdit As New FrmCargo_hatch_sheet_EDIT   '***********Ҫ�޸�
            Dim Row As Integer

            ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
            Row = Me.C1DBG.Row
            FrmEdit.ShowDialog()
            Try
                Call myDataGrid(SelectStr, SqlStr)
                Me.C1DBG.Row = Row

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    'Private Sub mnuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdd.Click
    '    Dim FrmAdd As New FrmCargo_hatch_list_add() '***********Ҫ�޸�
    '    If ds.Tables(0).Rows.Count > 0 Then
    '        ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
    '    Else
    '        ID = -1
    '    End If
    '    FrmAdd.ShowDialog()
    '    Try
    '        Call myDataGrid(SelectStr, SqlStr)

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    'End Sub

    Private Sub C1DBG_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.DoubleClick
        Call mnuQuery_Click(sender, e)
    End Sub

    Private Sub C1DBG_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            If Me.C1DBG.Col = Me.C1DBG.Columns.Count - 1 And Me.C1DBG.Row < ds.Tables(0).Rows.Count - 1 Then
                Me.C1DBG.Row = Me.C1DBG.Row + 1
                Me.C1DBG.Col = ColNum
            End If
        End If
    End Sub

    Private Sub mnuQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuery.Click
        If ds.Tables(0).Rows.Count > 0 Then
            Dim FrmQuery As New FrmCargo_hatch_sheet_QUERY   '***********Ҫ�޸�
            ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
            FrmQuery.ShowDialog()
        End If
    End Sub

    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
        Call PrintExcel()
    End Sub

    Private Sub mnuExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExport.Click
        Call ExportExcel()
    End Sub

    Private Sub ExportExcel() '����Excel        
        Call MakeExcel()
    End Sub

    Private Sub PrintExcel() '��ӡ��Excel        
        Dim PathStr As String
        Dim FilePath As String
        Dim Row As Integer
        Dim Col As Integer
        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        Try
            FilePath = PathStr + "Report_CARGO.xls"
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)
            xlSheet = CType(xlBook.Worksheets("װж��������ֲֵ�"), Excel.Worksheet)
            xlApp.DisplayAlerts = False
            xlSheet.Application.Visible = True
            xlBook.Worksheets("װж��������ֲֵ�").select()
            'xlSheet.Cells(1, 1) = Me.Text() '����
            xlSheet.Cells(2, 3) = dsSShip.Tables(0).Rows(0).Item("CHI_VESSEL")
            xlSheet.Cells(2, 6) = dsSShip.Tables(0).Rows(0).Item("ENG_VESSEL")
            xlSheet.Cells(2, 9) = "'" & dsSShip.Tables(0).Rows(0).Item("Voyage")
            xlSheet.Cells(2, 11) = dsSShip.Tables(0).Rows(0).Item("InOutPort_Name")


            'For Col = ColNum To Me.C1DBG.Columns.Count - 1 '�б���
            '    xlSheet.Cells(3, Col - ColNum + 1) = Me.C1DBG.Columns(Col).Caption
            'Next Col
            Me.C1DBG.MoveFirst()

            'For Row = 0 To ds.Tables(0).Rows.Count - 1 '����
            '    For Col = ColNum To Me.C1DBG.Columns.Count - 1
            '        xlSheet.Cells(Row + 5, Col - ColNum + 1) = Me.C1DBG.Columns(Col).Text.ToString      'ds.Tables(0).Rows(Row)(Col)
            '    Next Col
            '    Me.C1DBG.MoveNext()
            'Next Row

            Dim i As Integer
            Dim j As Integer
            Dim q As Integer
            If ds.Tables(0).Rows.Count <= 19 Then  '����
                For Row = 0 To ds.Tables(0).Rows.Count - 1
                    For Col = 2 To 9
                        xlSheet.Cells(Row + 5, Col - 1) = ds.Tables(0).Rows(Row)(Col)
                    Next Col
                Next Row
                If Me.C1DBG.ColumnFooters = True Then '�ϼ���
                    For Col = ColNum To Me.C1DBG.Columns.Count - 1
                        xlSheet.Cells(24, Col - 1) = Me.C1DBG.Columns(Col).FooterText
                    Next Col
                End If
                xlSheet.PrintOut()
            Else  '����
                j = (ds.Tables(0).Rows.Count - ds.Tables(0).Rows.Count Mod 19) / 19  '������
                q = ds.Tables(0).Rows.Count - j * 19   '����ϼ��У�ʣ�µ�����
                If q > 0 Then
                    For i = 0 To j - 1
                        For Row = 0 To 18
                            For Col = 2 To 9
                                xlSheet.Cells(Row + 5, Col - 1) = ""
                            Next Col
                        Next Row
                        For Row = 0 To 18
                            For Col = 2 To 9
                                xlSheet.Cells(Row + 5, Col - 1) = ds.Tables(0).Rows(Row + i * 19)(Col)
                            Next Col
                        Next Row
                        xlSheet.PrintOut()
                    Next i
                    'ʣ�����һ������
                    For Row = 0 To 19
                        For Col = 2 To 9
                            xlSheet.Cells(Row + 5, Col - 1) = ""
                        Next Col
                    Next Row
                    For Row = 0 To q - 1
                        For Col = 2 To 9
                            xlSheet.Cells(Row + 5, Col - 1) = ds.Tables(0).Rows(Row + i * 19)(Col)
                        Next Col
                    Next Row
                    If Me.C1DBG.ColumnFooters = True Then '�ϼ���
                        For Col = ColNum To Me.C1DBG.Columns.Count - 1
                            xlSheet.Cells(24, Col - 1) = Me.C1DBG.Columns(Col).FooterText
                        Next Col
                    End If
                    xlSheet.PrintOut()
                Else 'û������
                    For i = 0 To j - 2
                        For Row = 0 To 19
                            For Col = 2 To 9
                                xlSheet.Cells(Row + 5, Col - 1) = ""
                            Next Col
                        Next Row
                        For Row = 0 To 19
                            For Col = 2 To 9
                                xlSheet.Cells(Row + 5, Col - 1) = ds.Tables(0).Rows(Row + i * 19)(Col)
                            Next Col
                        Next Row
                        xlSheet.PrintOut()
                    Next i
                    For Row = 0 To 19
                        For Col = 2 To 9
                            xlSheet.Cells(Row + 5, Col - 1) = ""
                        Next Col
                    Next Row
                    For Row = 0 To 19
                        For Col = 2 To 9
                            xlSheet.Cells(Row + 5, Col - 1) = ds.Tables(0).Rows(Row + i * 19)(Col)
                        Next Col
                    Next Row
                    If Me.C1DBG.ColumnFooters = True Then '�ϼ���
                        For Col = ColNum To Me.C1DBG.Columns.Count - 1
                            xlSheet.Cells(24, Col - 1) = Me.C1DBG.Columns(Col).FooterText
                        Next Col
                    End If
                    xlSheet.PrintOut()
                End If
            End If

            KillExcelProcess()
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub MakeExcel()
        Dim PathStr As String
        Dim FilePath As String
        Dim Row As Integer
        Dim Col As Integer
        Dim sheet As String
        Try
            RecordExcelProcess()
            PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
            PathStr = substr(PathStr)
            FileCopy(PathStr + "װж��������ֲֵ�.xls", PathStr + "Report.xls")
            FilePath = PathStr + "Report.xls"
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)
            sheet = "Sheet1"
            xlSheet = CType(xlBook.Worksheets("sheet1"), Excel.Worksheet)
            xlApp.DisplayAlerts = True
            xlSheet.Application.Visible = True
            xlBook.Worksheets("sheet1").select()

            'xlSheet.Cells(1, 1) = Me.Text() '����
            xlSheet.Cells(2, 3) = dsSShip.Tables(0).Rows(0).Item("CHI_VESSEL")
            xlSheet.Cells(2, 6) = dsSShip.Tables(0).Rows(0).Item("ENG_VESSEL")
            xlSheet.Cells(2, 9) = "'" & dsSShip.Tables(0).Rows(0).Item("Voyage")
            xlSheet.Cells(2, 11) = dsSShip.Tables(0).Rows(0).Item("InOutPort_Name")

            'For Col = ColNum To Me.C1DBG.Columns.Count - 1 '�б���
            '    xlSheet.Cells(3, Col - ColNum + 1) = Me.C1DBG.Columns(Col).Caption
            'Next Col
            Me.C1DBG.MoveFirst()

            'For Row = 0 To ds.Tables(0).Rows.Count - 1 '����
            '    For Col = ColNum To Me.C1DBG.Columns.Count - 1
            '        xlSheet.Cells(Row + 5, Col - ColNum + 1) = Me.C1DBG.Columns(Col).Text.ToString      'ds.Tables(0).Rows(Row)(Col)
            '    Next Col
            '    Me.C1DBG.MoveNext()
            'Next Row

            Dim i As Integer
            Dim j As Integer
            Dim q As Integer
            If ds.Tables(0).Rows.Count <= 19 Then  '����
                For Row = 0 To ds.Tables(0).Rows.Count - 1
                    For Col = 2 To 9
                        xlSheet.Cells(Row + 5, Col - 1) = ds.Tables(0).Rows(Row)(Col)
                    Next Col
                Next Row
                If Me.C1DBG.ColumnFooters = True Then '�ϼ���
                    For Col = ColNum To Me.C1DBG.Columns.Count - 1
                        xlSheet.Cells(24, Col - 1) = Me.C1DBG.Columns(Col).FooterText
                    Next Col
                End If
                xlSheet.PrintPreview()
            Else  '����
                j = (ds.Tables(0).Rows.Count - ds.Tables(0).Rows.Count Mod 19) / 19  '������
                q = ds.Tables(0).Rows.Count - j * 19   '����ϼ��У�ʣ�µ�����
                If q > 0 Then
                    For i = 0 To j - 1
                        sheet = "Sheet" & System.Convert.ToString(i + 1)
                        xlSheet = CType(xlBook.Worksheets("" & sheet & ""), Excel.Worksheet)
                        xlSheet.Select()
                        xlSheet.Cells(2, 3) = dsSShip.Tables(0).Rows(0).Item("CHI_VESSEL")
                        xlSheet.Cells(2, 6) = dsSShip.Tables(0).Rows(0).Item("ENG_VESSEL")
                        xlSheet.Cells(2, 9) = "'" & dsSShip.Tables(0).Rows(0).Item("Voyage")
                        xlSheet.Cells(2, 11) = dsSShip.Tables(0).Rows(0).Item("InOutPort_Name")
                        For Row = 0 To 18
                            For Col = 2 To 9
                                xlSheet.Cells(Row + 5, Col - 1) = ""
                            Next Col
                        Next Row
                        For Row = 0 To 18
                            For Col = 2 To 9
                                xlSheet.Cells(Row + 5, Col - 1) = ds.Tables(0).Rows(Row + i * 19)(Col)
                            Next Col
                        Next Row
                        'xlSheet.PrintOut()
                    Next i
                    'ʣ�����һ������
                    sheet = "Sheet" & System.Convert.ToString(j + 1)
                    xlSheet = CType(xlBook.Worksheets("" & sheet & ""), Excel.Worksheet)
                    xlSheet.Select()
                    xlSheet.Cells(2, 3) = dsSShip.Tables(0).Rows(0).Item("CHI_VESSEL")
                    xlSheet.Cells(2, 6) = dsSShip.Tables(0).Rows(0).Item("ENG_VESSEL")
                    xlSheet.Cells(2, 9) = "'" & dsSShip.Tables(0).Rows(0).Item("Voyage")
                    xlSheet.Cells(2, 11) = dsSShip.Tables(0).Rows(0).Item("InOutPort_Name")
                    For Row = 0 To 19
                        For Col = 2 To 9
                            xlSheet.Cells(Row + 5, Col - 1) = ""
                        Next Col
                    Next Row
                    For Row = 0 To q - 1
                        For Col = 2 To 9
                            xlSheet.Cells(Row + 5, Col - 1) = ds.Tables(0).Rows(Row + i * 19)(Col)
                        Next Col
                    Next Row
                    If Me.C1DBG.ColumnFooters = True Then '�ϼ���
                        For Col = ColNum To Me.C1DBG.Columns.Count - 1
                            xlSheet.Cells(24, Col - 1) = Me.C1DBG.Columns(Col).FooterText
                        Next Col
                    End If
                    'xlSheet.PrintOut()
                Else 'û������
                    For i = 0 To j - 1
                        sheet = "Sheet" & System.Convert.ToString(i + 1)
                        xlSheet = CType(xlBook.Worksheets("" & sheet & ""), Excel.Worksheet)
                        xlSheet.Select()
                        xlSheet.Cells(2, 3) = dsSShip.Tables(0).Rows(0).Item("CHI_VESSEL")
                        xlSheet.Cells(2, 6) = dsSShip.Tables(0).Rows(0).Item("ENG_VESSEL")
                        xlSheet.Cells(2, 9) = "'" & dsSShip.Tables(0).Rows(0).Item("Voyage")
                        xlSheet.Cells(2, 11) = dsSShip.Tables(0).Rows(0).Item("InOutPort_Name")
                        For Row = 0 To 19
                            For Col = 2 To 9
                                xlSheet.Cells(Row + 5, Col - 1) = ""
                            Next Col
                        Next Row
                        For Row = 0 To 19
                            For Col = 2 To 9
                                xlSheet.Cells(Row + 5, Col - 1) = ds.Tables(0).Rows(Row + i * 19)(Col)
                            Next Col
                        Next Row
                        xlSheet.PrintOut()
                    Next i
                    For Row = 0 To 19
                        For Col = 2 To 9
                            xlSheet.Cells(Row + 5, Col - 1) = ""
                        Next Col
                    Next Row
                    For Row = 0 To 19
                        For Col = 2 To 9
                            xlSheet.Cells(Row + 5, Col - 1) = ds.Tables(0).Rows(Row + i * 19)(Col)
                        Next Col
                    Next Row
                    If Me.C1DBG.ColumnFooters = True Then '�ϼ���
                        For Col = ColNum To Me.C1DBG.Columns.Count - 1
                            xlSheet.Cells(24, Col - 1) = Me.C1DBG.Columns(Col).FooterText
                        Next Col
                    End If
                    'xlSheet.PrintOut()
                End If
            End If

        Catch
            xlApp.Quit()
            SendKeys.Send("N")
            KillExcelProcess()
        End Try

    End Sub

    Private Sub preview(ByVal Func As String) '***************Ȩ�����
        Dim sqlstr As String
        Dim Previewdv As DataView
        Dim Previewds As New DataSet
        Dim i As Integer
        sqlstr = " select FUNC_CODE_Add,FUNC_CODE_Change,FUNC_CODE_Del from View_UserPreview where PART_ID=" & G_Part_Id & " and FUNC_CODE='" & Upper(Func) & "' "
        Previewdv = Getdata(sqlstr, Previewds)
        If Previewdv.Count > 0 Then
            If Previewdv(i)("FUNC_CODE_Add") = 1 Then 'ADD ��ť�ɼ�
                ToolBar.Buttons.Item(3).Enabled = True
                mnudefine.Enabled = True
            Else                                      'ADD ��ť���ɼ�
                Me.ToolBar.Buttons.Item(3).Enabled = False
                mnudefine.Enabled = False
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
                mnudoprint.Enabled = True
            Else                                     'ɾ����ť���ɼ�
                Me.ToolBar.Buttons.Item(5).Enabled = False
                mnudoprint.Enabled = False
            End If
        End If

    End Sub
    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        If Me.C1DBG.Columns("Logic").CellValue(e.Row) = 1 Then
            e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
        End If

    End Sub

    Private Sub Frm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.C1DBGV.Height = Me.Height - 140
        Me.C1DBG.Height = Me.Height - 140
        Me.C1DBG.Width = Me.GB.Width - 5
        Me.Label.Width = Me.C1DBG.Width - 3
        Me.Label1.Top = Me.C1DBGV.Height + 20
        Me.txtShipName.Top = Me.C1DBGV.Height + 20
        Me.Label2.Top = Me.C1DBGV.Height + 40
        Me.txtVoyage.Top = Me.C1DBGV.Height + 40
        Me.btResure.Top = Me.C1DBGV.Height + 40
    End Sub

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        TBar = 1
        Mnu = 1
    End Sub

    Private Sub btResure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResure.Click
        SqlStrShip = "where (((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('2','3')) ) and Voyage like '" & Trim(txtVoyage.Text) & "%' and (ENG_VESSEL Like '" & Trim(txtShipName.Text) & "%' OR CHI_VESSEL like '" & Trim(txtShipName.Text) & "%' ))  and code_goods<>'2' "
        '����Ҫ�޸�
        G_ShipName = Trim(txtShipName.Text)
        G_Voyage = Trim(txtVoyage.Text)
        Call myDataGridShip(SqlStrShip & SortShip)   '����Ҫ�޸�
        Call C1DBGV_DoubleClick(sender, e)
    End Sub

    Private Sub mnudefine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnudefine.Click
        Dim frm As New FrmCargo_hatch_sheet_define
        'frm.MdiParent = Me
        frm.ShowDialog()
        Try
            Call myDataGrid(SelectStr, SqlStr)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnudoprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnudoprint.Click
        Dim frm As New FrmCargo_hatch_sheet_doprint
        frm.ShowDialog()
        Try
            Call myDataGrid(SelectStr, SqlStr)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtShipName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtShipName.KeyPress
        If e.KeyChar = Chr(13) Then
            txtVoyage.Focus()
        End If
    End Sub
    Private Sub txtVoyage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVoyage.KeyPress
        If e.KeyChar = Chr(13) Then
            Call btResure_Click(sender, e)
        End If
    End Sub
End Class
