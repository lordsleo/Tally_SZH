Imports TALLY.DBControl
Public Class FrmEmailName_Edit
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim sqlda_sub As New SqlClient.SqlDataAdapter()
    Dim ds_sub As New DataSet()
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
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEMail As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btResume As System.Windows.Forms.Button
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btDelete As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEmailName_Edit))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEMail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.btResume = New System.Windows.Forms.Button()
        Me.btDelete = New System.Windows.Forms.Button()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(146, 96)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 122
        Me.btQuit.Text = "ȡ��"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(78, 96)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 121
        Me.btSave.Text = "ȷ��"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 0)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 123
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(100, 66)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(192, 21)
        Me.txtCode.TabIndex = 129
        Me.txtCode.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "�ͻ�����"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEMail
        '
        Me.txtEMail.Location = New System.Drawing.Point(100, 38)
        Me.txtEMail.MaxLength = 100
        Me.txtEMail.Name = "txtEMail"
        Me.txtEMail.Size = New System.Drawing.Size(192, 21)
        Me.txtEMail.TabIndex = 127
        Me.txtEMail.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 18)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "����E_Mail��ַ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(100, 6)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(192, 21)
        Me.txtName.TabIndex = 125
        Me.txtName.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 18)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "�ͻ�������"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1DBG
        '
        Me.C1DBG.AllowAddNew = True
        Me.C1DBG.AllowDelete = True
        Me.C1DBG.AllowFilter = True
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1DBG.AllowSort = True
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.CollapseColor = System.Drawing.Color.Black
        Me.C1DBG.DataChanged = False
        Me.C1DBG.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBG.ExpandColor = System.Drawing.Color.Black
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1DBG.Location = New System.Drawing.Point(6, 128)
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
        Me.C1DBG.Size = New System.Drawing.Size(286, 122)
        Me.C1DBG.TabIndex = 130
        Me.C1DBG.PropBag = CType(resources.GetObject("C1DBG.PropBag"), String)
        '
        'btResume
        '
        Me.btResume.Location = New System.Drawing.Point(150, 256)
        Me.btResume.Name = "btResume"
        Me.btResume.Size = New System.Drawing.Size(65, 24)
        Me.btResume.TabIndex = 131
        Me.btResume.Text = "ȷ��"
        '
        'btDelete
        '
        Me.btDelete.Location = New System.Drawing.Point(80, 256)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(66, 24)
        Me.btDelete.TabIndex = 132
        Me.btDelete.Text = "�ӱ�ɾ��"
        '
        'FrmEmailName_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(298, 283)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btDelete, Me.btResume, Me.C1DBG, Me.txtCode, Me.Label3, Me.txtEMail, Me.Label2, Me.txtName, Me.Label1, Me.btQuit, Me.btSave, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEmailName_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "�ͻ�E_Mail��Ϣ_�༭"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim str As String
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen
        sqlstr = "select * from EMail_Cust where ID=" & ID & ""

        dw = Updatedata(sqlda, sqlstr, ds)
        If dw.Count > 0 Then

            txtID.Text = ds.Tables(0).Rows(0).Item("ID")
            txtName.Text = ds.Tables(0).Rows(0).Item("E_Name")
            txtEMail.Text = ds.Tables(0).Rows(0).Item("E_Mail")
            txtCode.Text = ds.Tables(0).Rows(0).Item("E_Code")
        End If


        txtCode.Focus()
        '****************��ش���˾�ۿڴ����
        Str = "select * from EMail_Cust_Detail where EMail_ID=" & ID & ""
        ds_sub.Reset()
        dw = Updatedata(sqlda_sub, Str, ds_sub)
        Me.C1DBG.DataSource = dw
        Me.C1DBG.Refresh()
        If ds_sub.Tables(0).Rows.Count = 0 Then
            Me.C1DBG.Select()
            Me.C1DBG.Row = Me.C1DBG.Row + 1
            Me.C1DBG.Columns.Item("EMail_ID").Value = Trim(txtID.Text)
        End If

        
        '***************��ʼ��
        Me.C1DBG.Splits(0).DisplayColumns.Item(0).Visible = False
        Me.C1DBG.Splits(0).DisplayColumns.Item(1).Visible = False
        Me.C1DBG.Columns.Item(2).Caption = "�ͻ�����"
        Me.C1DBG.Columns.Item(3).Caption = "�����ʼ���ַ"

        Me.C1DBG.Refresh()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            If MsgBox("��ȷ��Ҫ�޸���", MsgBoxStyle.YesNo, "��ʾ") = MsgBoxResult.Yes Then
                Call OperateHistory(G_DeptName, Now, G_User, "�޸�", "Email_Cust", Trim(txtID.Text), "ID")


                ds.Tables(0).Rows(0).Item("E_Name") = Trim(txtName.Text)
                ds.Tables(0).Rows(0).Item("E_Mail") = Trim(txtEMail.Text)
                ds.Tables(0).Rows(0).Item("E_Code") = Trim(txtCode.Text)

                sqlda.Update(ds)
                Call btQuit_Click(sender, e)

            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub btResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResume.Click
        Try
            sqlda_sub.Update(ds_sub)
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        Me.Close()
    End Sub

    Private Sub C1DBG_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles C1DBG.RowColChange
        Try
            If Me.C1DBG.Columns.Item("EMail_ID").Text = "" Then
                Me.C1DBG.Columns.Item("EMail_ID").Value = Trim(txtID.Text)
                Me.C1DBG.Refresh()
            End If
        Catch ex As System.Exception
        End Try
    End Sub

    Private Sub btDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDelete.Click
        Me.C1DBG.Delete()
    End Sub
End Class
