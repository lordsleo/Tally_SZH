Imports TALLY.DBControl
Public Class FrmFinishShipStatistics_Deal
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
    Friend WithEvents dtpTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbDepart As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.cbDepart = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(116, 58)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 295
        Me.btQuit.Text = "ȡ��"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(48, 58)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 294
        Me.btSave.Text = "ȷ��"
        '
        'dtpTime
        '
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTime.Location = New System.Drawing.Point(86, 30)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.Size = New System.Drawing.Size(130, 21)
        Me.dtpTime.TabIndex = 293
        Me.dtpTime.Value = New Date(2004, 3, 24, 0, 0, 0, 0)
        '
        'cbDepart
        '
        Me.cbDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepart.Location = New System.Drawing.Point(86, 8)
        Me.cbDepart.Name = "cbDepart"
        Me.cbDepart.Size = New System.Drawing.Size(130, 20)
        Me.cbDepart.TabIndex = 291
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 290
        Me.Label3.Text = "ͳ������"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 288
        Me.Label1.Text = "�������"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmFinishShipStatistics_Deal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(224, 87)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btQuit, Me.btSave, Me.dtpTime, Me.cbDepart, Me.Label3, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFinishShipStatistics_Deal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "�ֲ����괬���ͳ�Ʊ���Ϣ ����"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Shared Flag As Boolean = False

    Private Sub FrmFinishShipStatistics_Deal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpTime.CustomFormat = "yyyy�� MM��"

        Dim sqlDepart As String = "SELECT DEPT_CODE, DEPT_NAME FROM DEPARTMENT WHERE TallyDept = '1' OR DEPT_CODE = '00' ORDER BY DEPT_CODE"
        Dim dvDepart As New DataView()
        dvDepart = Filldata(sqlDepart)
        Me.cbDepart.DataSource = dvDepart
        Me.cbDepart.DisplayMember = "DEPT_NAME"
        Me.cbDepart.ValueMember = "DEPT_CODE"

        If G_DeptCode Like "26.11*" Or G_DeptCode = "26" Then
            If G_DeptCode = "26.11" Or G_DeptCode = "26" Then
                Me.cbDepart.Enabled = True
            Else
                Me.cbDepart.Enabled = False
                Me.cbDepart.SelectedValue = G_DeptCode
            End If
        Else
            MessageBox.Show("����ز��ţ����ܴ���")
            Me.cbDepart.Enabled = False
            Me.dtpTime.Enabled = False
            Me.btSave.Enabled = False
        End If
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Flag = True
        Me.Close()
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Flag = False
        Me.Close()
    End Sub

    Private Sub cbDepart_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbDepart.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.dtpTime.Focus()
        End If
    End Sub

    Private Sub dtpTime_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpTime.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btSave.Focus()
        End If
    End Sub
End Class
