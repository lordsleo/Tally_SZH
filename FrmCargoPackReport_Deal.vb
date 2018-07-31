Imports TALLY.DBControl
Public Class FrmCargoPackReport_Deal
    Inherits System.Windows.Forms.Form
    Public Mark As Boolean
    Public CodeCompany As String
    Public TimeBegin, TimeEnd As Date

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
    Friend WithEvents dtpTimeEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbCompany As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpTimeEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpTimeBegin = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbCompany = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtpTimeEnd
        '
        Me.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeEnd.Location = New System.Drawing.Point(90, 32)
        Me.dtpTimeEnd.Name = "dtpTimeEnd"
        Me.dtpTimeEnd.Size = New System.Drawing.Size(126, 21)
        Me.dtpTimeEnd.TabIndex = 310
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 20)
        Me.Label8.TabIndex = 312
        Me.Label8.Text = "��������ʱ��"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeBegin
        '
        Me.dtpTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeBegin.Location = New System.Drawing.Point(90, 8)
        Me.dtpTimeBegin.Name = "dtpTimeBegin"
        Me.dtpTimeBegin.Size = New System.Drawing.Size(126, 21)
        Me.dtpTimeBegin.TabIndex = 309
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 311
        Me.Label7.Text = "��������ʱ��"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbCompany
        '
        Me.cbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCompany.Location = New System.Drawing.Point(90, 56)
        Me.cbCompany.Name = "cbCompany"
        Me.cbCompany.Size = New System.Drawing.Size(126, 20)
        Me.cbCompany.TabIndex = 324
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(8, 56)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 20)
        Me.Label18.TabIndex = 325
        Me.Label18.Text = "װж��˾"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(116, 84)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 327
        Me.btQuit.Text = "ȡ��"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(48, 84)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 326
        Me.btSave.Text = "ȷ��"
        '
        'FrmCargoPackReport_Deal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(224, 111)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btQuit, Me.btSave, Me.cbCompany, Me.Label18, Me.dtpTimeEnd, Me.Label8, Me.dtpTimeBegin, Me.Label7})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargoPackReport_Deal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ɢ���������ձ� ����"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCargoPackReport_Deal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dwCompany As New DataView()
        Dim sqlCompany As String
        Try
            sqlCompany = "SELECT DISTINCT CompCode, DepartMent FROM View_CargoGoodsPub WHERE SHIP_ID = '" & Ship_ID & "'"
            dwCompany = Filldata(sqlCompany)

            cbCompany.DataSource = dwCompany
            cbCompany.DisplayMember = "DepartMent"
            cbCompany.ValueMember = "CompCode"

            dtpTimeBegin.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"
            dtpTimeEnd.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
     End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        CodeCompany = cbCompany.SelectedValue
        TimeBegin = dtpTimeBegin.Value
        TimeEnd = dtpTimeEnd.Value
        If DateDiff(DateInterval.Hour, TimeBegin, TimeEnd) >= 0 Then
            Mark = True
            Me.Close()
        Else
            MessageBox.Show("��ҵ��ʱ��Ӧ��ֹʱ��֮ǰ��", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub dtpTimeBegin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpTimeBegin.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.dtpTimeEnd.Focus()
        End If
    End Sub

    Private Sub dtpTimeEnd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpTimeEnd.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cbCompany.Focus()
        End If
    End Sub

    Private Sub cbCompany_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbCompany.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btSave.Focus()
        End If
    End Sub

    Private Sub btSave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btSave.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Me.btSave_Click(sender, e)
        End If
    End Sub

End Class
