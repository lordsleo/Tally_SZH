Imports TALLY.DBControl
Public Class FrmSealKill_query
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()

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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents cbDept As System.Windows.Forms.ComboBox
    Friend WithEvents txtPerson As System.Windows.Forms.TextBox
    Friend WithEvents txtSealTime As System.Windows.Forms.TextBox
    Friend WithEvents txtSealNO As System.Windows.Forms.TextBox
    Friend WithEvents txtKillReason As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cbDept = New System.Windows.Forms.ComboBox()
        Me.txtPerson = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.txtSealTime = New System.Windows.Forms.TextBox()
        Me.txtSealNO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtKillReason = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbDept
        '
        Me.cbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDept.Location = New System.Drawing.Point(64, 32)
        Me.cbDept.Name = "cbDept"
        Me.cbDept.Size = New System.Drawing.Size(124, 20)
        Me.cbDept.TabIndex = 191
        '
        'txtPerson
        '
        Me.txtPerson.Location = New System.Drawing.Point(64, 58)
        Me.txtPerson.MaxLength = 10
        Me.txtPerson.Name = "txtPerson"
        Me.txtPerson.Size = New System.Drawing.Size(124, 21)
        Me.txtPerson.TabIndex = 190
        Me.txtPerson.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(2, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 18)
        Me.Label5.TabIndex = 189
        Me.Label5.Text = "������"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(64, 204)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 188
        Me.btQuit.Text = "����"
        '
        'txtSealTime
        '
        Me.txtSealTime.Location = New System.Drawing.Point(64, 84)
        Me.txtSealTime.MaxLength = 20
        Me.txtSealTime.Name = "txtSealTime"
        Me.txtSealTime.Size = New System.Drawing.Size(124, 21)
        Me.txtSealTime.TabIndex = 187
        Me.txtSealTime.Text = ""
        '
        'txtSealNO
        '
        Me.txtSealNO.Location = New System.Drawing.Point(64, 6)
        Me.txtSealNO.MaxLength = 20
        Me.txtSealNO.Name = "txtSealNO"
        Me.txtSealNO.Size = New System.Drawing.Size(124, 21)
        Me.txtSealNO.TabIndex = 186
        Me.txtSealNO.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(2, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 18)
        Me.Label4.TabIndex = 185
        Me.Label4.Text = "����"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 18)
        Me.Label3.TabIndex = 184
        Me.Label3.Text = "����"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 18)
        Me.Label1.TabIndex = 183
        Me.Label1.Text = "Ǧ���"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 182
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'txtKillReason
        '
        Me.txtKillReason.Location = New System.Drawing.Point(6, 132)
        Me.txtKillReason.MaxLength = 30
        Me.txtKillReason.Multiline = True
        Me.txtKillReason.Name = "txtKillReason"
        Me.txtKillReason.Size = New System.Drawing.Size(180, 66)
        Me.txtKillReason.TabIndex = 202
        Me.txtKillReason.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 18)
        Me.Label2.TabIndex = 203
        Me.Label2.Text = "ע��ԭ��"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmSealKill_query
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(194, 231)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtKillReason, Me.Label2, Me.cbDept, Me.txtPerson, Me.Label5, Me.btQuit, Me.txtSealTime, Me.txtSealNO, Me.Label4, Me.Label3, Me.Label1, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSealKill_query"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ǧ��ע����Ϣ �鿴"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmSealKill_query_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim dvDept As New DataView()

        Dim sqlstr, sqlDept As String
        Me.StartPosition = FormStartPosition.CenterScreen
        sqlstr = "select * from SEAL_RECORD where SEAL_RECORD_ID=" & ID & ""
        sqlDept = "select dept_code,dept_name from department where dept_code<>'00' "

        dvDept = Filldata(sqlDept)
        cbDept.DataSource = dvDept
        cbDept.DisplayMember = "dept_name"
        cbDept.ValueMember = "dept_code"

        dw = Getdata(sqlstr, ds)

        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("ID")
            txtSealNO.Text = ds.Tables(0).Rows(0).Item("SEALNO")
            txtSealTime.Text = ds.Tables(0).Rows(0).Item("SEALDATE")
            cbDept.SelectedValue = ds.Tables(0).Rows(0).Item("Dept_Code")
            txtPerson.Text = ds.Tables(0).Rows(0).Item("USER_PERSON")
            txtKillReason.Text = ds.Tables(0).Rows(0).Item("LOGOFF_REASON")
        End If
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
