Imports TALLY.DBControl
Public Class FrmINVOICE_MANAGE_Delete
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents CmbDEPT_CODE As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtINVOICENO_BEGIN As System.Windows.Forms.TextBox
    Friend WithEvents TxtINVOICENO_END As System.Windows.Forms.TextBox
    Friend WithEvents TxtINVOICENO As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.CmbDEPT_CODE = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtINVOICENO_BEGIN = New System.Windows.Forms.TextBox()
        Me.TxtINVOICENO_END = New System.Windows.Forms.TextBox()
        Me.TxtINVOICENO = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(93, 113)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 1
        Me.btQuit.Text = "ȡ��"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(25, 113)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "ȷ��"
        '
        'CmbDEPT_CODE
        '
        Me.CmbDEPT_CODE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbDEPT_CODE.Enabled = False
        Me.CmbDEPT_CODE.Location = New System.Drawing.Point(86, 8)
        Me.CmbDEPT_CODE.Name = "CmbDEPT_CODE"
        Me.CmbDEPT_CODE.Size = New System.Drawing.Size(90, 20)
        Me.CmbDEPT_CODE.TabIndex = 2
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(8, 8)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 20)
        Me.Label22.TabIndex = 106
        Me.Label22.Text = "��������"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "��ʼ��Ʊ��"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "������Ʊ��"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "��ǰ��Ʊ��"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtINVOICENO_BEGIN
        '
        Me.TxtINVOICENO_BEGIN.Location = New System.Drawing.Point(86, 32)
        Me.TxtINVOICENO_BEGIN.Name = "TxtINVOICENO_BEGIN"
        Me.TxtINVOICENO_BEGIN.Size = New System.Drawing.Size(90, 21)
        Me.TxtINVOICENO_BEGIN.TabIndex = 3
        Me.TxtINVOICENO_BEGIN.Text = ""
        '
        'TxtINVOICENO_END
        '
        Me.TxtINVOICENO_END.Location = New System.Drawing.Point(86, 56)
        Me.TxtINVOICENO_END.Name = "TxtINVOICENO_END"
        Me.TxtINVOICENO_END.Size = New System.Drawing.Size(90, 21)
        Me.TxtINVOICENO_END.TabIndex = 4
        Me.TxtINVOICENO_END.Text = ""
        '
        'TxtINVOICENO
        '
        Me.TxtINVOICENO.Location = New System.Drawing.Point(86, 80)
        Me.TxtINVOICENO.Name = "TxtINVOICENO"
        Me.TxtINVOICENO.Size = New System.Drawing.Size(90, 21)
        Me.TxtINVOICENO.TabIndex = 5
        Me.TxtINVOICENO.Text = ""
        '
        'FrmINVOICE_MANAGE_Delete
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(182, 147)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TxtINVOICENO, Me.TxtINVOICENO_END, Me.TxtINVOICENO_BEGIN, Me.Label3, Me.Label2, Me.Label1, Me.Label22, Me.CmbDEPT_CODE, Me.btQuit, Me.btSave})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmINVOICE_MANAGE_Delete"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "��Ʊ�Ź���_ɾ��"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As New DataSet()
    Dim dw As New DataView()
    Dim sqlda As New SqlClient.SqlDataAdapter()

    Private Sub FrmINVOICE_MANAGE_Delete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err

        Call FillDEPT_CODE()
        Dim sqlstr As String
        sqlstr = "select * from INVOICE_MANAGE where INVOICE_MANAGE_ID=" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        If dw.Count > 0 Then

            CmbDEPT_CODE.SelectedValue = ds.Tables(0).Rows(0).Item("DEPT_CODE")
            TxtINVOICENO_BEGIN.Text = ds.Tables(0).Rows(0).Item("INVOICENO_BEGIN")
            TxtINVOICENO_END.Text = ds.Tables(0).Rows(0).Item("INVOICENO_END")
            TxtINVOICENO.Text = ds.Tables(0).Rows(0).Item("INVOICENO")

        End If
        CmbDEPT_CODE.Focus()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            If MsgBox("��ȷ��Ҫɾ�����鷢Ʊ����", MsgBoxStyle.YesNo + vbExclamation, "��ʾ") = MsgBoxResult.Yes Then
                Call OperateHistory(G_DeptName, Now, G_User, "ɾ��", "INVOICE_MANAGE", Trim(ID), "INVOICE_MANAGE_ID")

                ds.Tables(0).Rows(0).Delete()
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

    Private Sub FillDEPT_CODE()
        Dim sqldc As String
        Dim dvc As New DataView()
        Dim dsc As New DataSet()
        sqldc = "select DEPT_CODE,DEPT_NAME from DEPARTMENT"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbDEPT_CODE.DataSource = dvc
        Me.CmbDEPT_CODE.DisplayMember = "DEPT_NAME"
        Me.CmbDEPT_CODE.ValueMember = "DEPT_CODE"
    End Sub

End Class
