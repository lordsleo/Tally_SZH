Imports TALLY.DBControl
Public Class FrmINVOICE_MANAGE_ADD
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
    Friend WithEvents btAdd As System.Windows.Forms.Button
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
        Me.btAdd = New System.Windows.Forms.Button()
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
        Me.btQuit.Location = New System.Drawing.Point(151, 113)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 5
        Me.btQuit.Text = "ȡ��"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(83, 113)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 4
        Me.btSave.Text = "ȷ��"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(15, 113)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(65, 24)
        Me.btAdd.TabIndex = 6
        Me.btAdd.Text = "���"
        '
        'CmbDEPT_CODE
        '
        Me.CmbDEPT_CODE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbDEPT_CODE.Enabled = False
        Me.CmbDEPT_CODE.Location = New System.Drawing.Point(104, 8)
        Me.CmbDEPT_CODE.Name = "CmbDEPT_CODE"
        Me.CmbDEPT_CODE.Size = New System.Drawing.Size(90, 20)
        Me.CmbDEPT_CODE.TabIndex = 0
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(24, 8)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 20)
        Me.Label22.TabIndex = 106
        Me.Label22.Text = "��������"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "��ʼ��Ʊ��"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "������Ʊ��"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "��ǰ��Ʊ��"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtINVOICENO_BEGIN
        '
        Me.TxtINVOICENO_BEGIN.Location = New System.Drawing.Point(104, 32)
        Me.TxtINVOICENO_BEGIN.Name = "TxtINVOICENO_BEGIN"
        Me.TxtINVOICENO_BEGIN.Size = New System.Drawing.Size(90, 21)
        Me.TxtINVOICENO_BEGIN.TabIndex = 1
        Me.TxtINVOICENO_BEGIN.Text = ""
        '
        'TxtINVOICENO_END
        '
        Me.TxtINVOICENO_END.Location = New System.Drawing.Point(104, 57)
        Me.TxtINVOICENO_END.Name = "TxtINVOICENO_END"
        Me.TxtINVOICENO_END.Size = New System.Drawing.Size(90, 21)
        Me.TxtINVOICENO_END.TabIndex = 2
        Me.TxtINVOICENO_END.Text = ""
        '
        'TxtINVOICENO
        '
        Me.TxtINVOICENO.Location = New System.Drawing.Point(104, 82)
        Me.TxtINVOICENO.Name = "TxtINVOICENO"
        Me.TxtINVOICENO.Size = New System.Drawing.Size(90, 21)
        Me.TxtINVOICENO.TabIndex = 3
        Me.TxtINVOICENO.Text = ""
        '
        'FrmINVOICE_MANAGE_ADD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(230, 147)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TxtINVOICENO, Me.TxtINVOICENO_END, Me.TxtINVOICENO_BEGIN, Me.Label3, Me.Label2, Me.Label1, Me.Label22, Me.CmbDEPT_CODE, Me.btQuit, Me.btSave, Me.btAdd})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmINVOICE_MANAGE_ADD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "��Ʊ�Ź���_����"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As New DataSet()
    Dim dw As New DataView()
    Dim sqlda As New SqlClient.SqlDataAdapter()

    Private Sub FrmINVOICE_MANAGE_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err

        Call FillDEPT_CODE()

        CmbDEPT_CODE.SelectedValue = G_DeptCode
        CmbDEPT_CODE.Focus()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            Dim begin_no As Integer
            Dim end_no As Integer
           
            If Len(Trim(TxtINVOICENO_BEGIN.Text)) > 0 Then
                If IsNumeric(Trim(TxtINVOICENO_BEGIN.Text)) Then
                    begin_no = Trim(TxtINVOICENO_BEGIN.Text)
                Else
                    MsgBox("��ʼ��Ʊ��һ��Ӧ���������������ݣ�", MsgBoxStyle.Exclamation, "��ʾ")
                    Exit Sub
                End If
            Else
                MsgBox("��ʼ��Ʊ��һ��Ӧ���������������ݣ�", MsgBoxStyle.Exclamation, "��ʾ")
                Exit Sub
            End If
            If Len(Trim(TxtINVOICENO_END.Text)) > 0 Then
                If IsNumeric(Trim(TxtINVOICENO_END.Text)) Then
                    end_no = Trim(TxtINVOICENO_END.Text)
                Else
                    MsgBox("������Ʊ��һ��Ӧ���������������ݣ�", MsgBoxStyle.Exclamation, "��ʾ")
                    Exit Sub
                End If
            Else
                MsgBox("������Ʊ��һ��Ӧ���������������ݣ�", MsgBoxStyle.Exclamation, "��ʾ")
                Exit Sub
            End If

            If MsgBox("��ȷ��Ҫ��ӱ��鷢Ʊ��", MsgBoxStyle.YesNo + vbExclamation, "��ʾ") = MsgBoxResult.Yes Then
                If Len(Trim(TxtINVOICENO_BEGIN.Text)) > 0 And Len(Trim(TxtINVOICENO_END.Text)) > 0 Then
                    If end_no - begin_no > 0 Then
                        Dim row As DataRow
                        Dim sqlstr As String
                        sqlstr = "select * from INVOICE_MANAGE "
                        dw = Updatedata(sqlda, sqlstr, ds)
                        row = ds.Tables(0).NewRow()
                        row("Dept_Code") = CmbDEPT_CODE.SelectedValue

                        row("INVOICENO_BEGIN") = Trim(TxtINVOICENO_BEGIN.Text)
                        row("INVOICENO_END") = Trim(TxtINVOICENO_END.Text)
                        row("INVOICENO") = Trim(TxtINVOICENO.Text)
                        row("User_Name") = Trim(G_User)

                        ds.Tables(0).Rows.Add(row)
                        sqlda.Update(ds)
                        Me.Close()
                    Else
                        MsgBox("��ֹ��Ʊ��Ӧ���ڳ�ʼ��Ʊ�ţ�", MsgBoxStyle.Exclamation, "��ʾ")
                        Exit Sub
                    End If
                Else
                    MsgBox("��Ʊ�Ų���Ϊ��!", MsgBoxStyle.Exclamation, "��ʾ")
                    Exit Sub
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click

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

    Private Sub TxtINVOICENO_BEGIN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtINVOICENO_BEGIN.TextChanged
        TxtINVOICENO.Text = TxtINVOICENO_BEGIN.Text
    End Sub
End Class
