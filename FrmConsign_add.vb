Imports TALLY.DBControl
Public Class FrmConsign_add
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
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents DTPCONSIGN_DATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbCONSIGN_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents txtREMARK As System.Windows.Forms.TextBox
    Friend WithEvents txtITEM As System.Windows.Forms.TextBox
    Friend WithEvents txtCLIENT As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents txtSHIP_CONSIGN_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtSHIP_ID As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.DTPCONSIGN_DATE = New System.Windows.Forms.DateTimePicker()
        Me.CmbCONSIGN_TYPE = New System.Windows.Forms.ComboBox()
        Me.txtREMARK = New System.Windows.Forms.TextBox()
        Me.txtITEM = New System.Windows.Forms.TextBox()
        Me.txtCLIENT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.txtSHIP_CONSIGN_ID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSHIP_ID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(73, 181)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(65, 24)
        Me.btAdd.TabIndex = 6
        Me.btAdd.Text = "���"
        '
        'DTPCONSIGN_DATE
        '
        Me.DTPCONSIGN_DATE.CustomFormat = "yyyy/MM/dd"
        Me.DTPCONSIGN_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DTPCONSIGN_DATE.Location = New System.Drawing.Point(239, 13)
        Me.DTPCONSIGN_DATE.Name = "DTPCONSIGN_DATE"
        Me.DTPCONSIGN_DATE.Size = New System.Drawing.Size(102, 21)
        Me.DTPCONSIGN_DATE.TabIndex = 1
        '
        'CmbCONSIGN_TYPE
        '
        Me.CmbCONSIGN_TYPE.Location = New System.Drawing.Point(63, 13)
        Me.CmbCONSIGN_TYPE.Name = "CmbCONSIGN_TYPE"
        Me.CmbCONSIGN_TYPE.Size = New System.Drawing.Size(102, 20)
        Me.CmbCONSIGN_TYPE.TabIndex = 0
        '
        'txtREMARK
        '
        Me.txtREMARK.Location = New System.Drawing.Point(63, 130)
        Me.txtREMARK.MaxLength = 100
        Me.txtREMARK.Multiline = True
        Me.txtREMARK.Name = "txtREMARK"
        Me.txtREMARK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtREMARK.Size = New System.Drawing.Size(278, 44)
        Me.txtREMARK.TabIndex = 4
        Me.txtREMARK.Text = ""
        '
        'txtITEM
        '
        Me.txtITEM.Location = New System.Drawing.Point(63, 84)
        Me.txtITEM.MaxLength = 200
        Me.txtITEM.Multiline = True
        Me.txtITEM.Name = "txtITEM"
        Me.txtITEM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtITEM.Size = New System.Drawing.Size(278, 44)
        Me.txtITEM.TabIndex = 3
        Me.txtITEM.Text = ""
        '
        'txtCLIENT
        '
        Me.txtCLIENT.Location = New System.Drawing.Point(63, 38)
        Me.txtCLIENT.MaxLength = 50
        Me.txtCLIENT.Multiline = True
        Me.txtCLIENT.Name = "txtCLIENT"
        Me.txtCLIENT.Size = New System.Drawing.Size(278, 44)
        Me.txtCLIENT.TabIndex = 2
        Me.txtCLIENT.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ί�����"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 42)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "ί������"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(182, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "ί��ʱ��"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 42)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ί����"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(211, 181)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 7
        Me.btQuit.Text = "ȡ��"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(142, 181)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 5
        Me.btSave.Text = "ȷ��"
        '
        'txtSHIP_CONSIGN_ID
        '
        Me.txtSHIP_CONSIGN_ID.Location = New System.Drawing.Point(301, 181)
        Me.txtSHIP_CONSIGN_ID.Name = "txtSHIP_CONSIGN_ID"
        Me.txtSHIP_CONSIGN_ID.ReadOnly = True
        Me.txtSHIP_CONSIGN_ID.Size = New System.Drawing.Size(28, 21)
        Me.txtSHIP_CONSIGN_ID.TabIndex = 9
        Me.txtSHIP_CONSIGN_ID.Text = ""
        Me.txtSHIP_CONSIGN_ID.Visible = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 42)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "��ע"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtSHIP_ID
        '
        Me.TxtSHIP_ID.Location = New System.Drawing.Point(15, 181)
        Me.TxtSHIP_ID.Name = "TxtSHIP_ID"
        Me.TxtSHIP_ID.ReadOnly = True
        Me.TxtSHIP_ID.Size = New System.Drawing.Size(28, 21)
        Me.TxtSHIP_ID.TabIndex = 8
        Me.TxtSHIP_ID.Text = ""
        Me.TxtSHIP_ID.Visible = False
        '
        'FrmConsign_add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(348, 217)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.DTPCONSIGN_DATE, Me.CmbCONSIGN_TYPE, Me.txtREMARK, Me.txtITEM, Me.txtCLIENT, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.btQuit, Me.btSave, Me.txtSHIP_CONSIGN_ID, Me.Label5, Me.TxtSHIP_ID, Me.btAdd})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConsign_add"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "��ҵί����_����"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim sqlstr As String
    Dim ds As New DataSet()
    Dim dw As New DataView()
    Dim sqlda As New SqlClient.SqlDataAdapter()

    Private Sub FrmConsign_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCLIENT.Focus()
        TxtSHIP_ID.Text = ID
        Call FillCONSIGN_TYPE()
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        txtCLIENT.Text = ""
        DTPCONSIGN_DATE.Value = Now
        Call FillCONSIGN_TYPE()
        txtITEM.Text = ""
        txtREMARK.Text = ""
    End Sub

    Private Sub FillCONSIGN_TYPE()
        Dim sqldc As String
        Dim dvc As DataView
        Dim dsc As New DataSet()
        sqldc = "select CODE_CONSIGN_TYPE,CONSIGN_NAME from CODE_CONSIGN_TYPE"
        dvc = DBControl.Getdata(sqldc, dsc)
        Me.CmbCONSIGN_TYPE.DataSource = dvc
        Me.CmbCONSIGN_TYPE.DisplayMember = "CONSIGN_NAME"
        Me.CmbCONSIGN_TYPE.ValueMember = "CODE_CONSIGN_TYPE"
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            sqlstr = "select * from SHIP_CONSIGN"
            dw = Updatedata(sqlda, sqlstr, ds)
            If Len(Trim(txtCLIENT.Text)) > 0 Then
                If Len(Trim(CmbCONSIGN_TYPE.Text)) > 0 Then
                    If Len(Trim(txtITEM.Text)) > 0 Then
                        If MsgBox("��ȷ��Ҫ���������", MsgBoxStyle.YesNo + vbExclamation, "��ʾ") = MsgBoxResult.Yes Then
                            Dim row As DataRow
                            row = ds.Tables(0).NewRow()
                            row("SHIP_ID") = TxtSHIP_ID.Text
                            row("CLIENT") = Trim(txtCLIENT.Text)
                            row("CONSIGN_DATE") = DTPCONSIGN_DATE.Value
                            row("CONSIGN_TYPE") = CmbCONSIGN_TYPE.SelectedValue
                            row("ITEM") = Trim(txtITEM.Text)
                            If Len(Trim(txtREMARK.Text)) > 0 Then
                                row("REMARK") = Trim(txtREMARK.Text)
                            End If
                            row("User_Name") = Trim(G_User)

                            ds.Tables(0).Rows.Add(row)
                            sqlda.Update(ds)
                            Me.Close()
                        End If
                    Else
                        MsgBox("ί�������Ϊ��!", MsgBoxStyle.Critical, "��ʾ")
                    End If
                Else
                    MsgBox("ί�������Ϊ��!", MsgBoxStyle.Critical, "��ʾ")
                End If
            Else
                MsgBox("ί���˲���Ϊ��!", MsgBoxStyle.Critical, "��ʾ")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub CmbCONSIGN_TYPE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbCONSIGN_TYPE.KeyDown
        If e.KeyCode = Keys.Enter Then
            DTPCONSIGN_DATE.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub DTPCONSIGN_DATE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DTPCONSIGN_DATE.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCLIENT.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txtCLIENT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCLIENT.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtITEM.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txtITEM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtITEM.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtREMARK.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txtREMARK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtREMARK.KeyDown
        If e.KeyCode = Keys.Enter Then
            btSave.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btSave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btSave.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btSave_Click(sender, e)
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btAdd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btAdd.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btAdd_Click(sender, e)
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btQuit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btQuit.KeyDown
        If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Enter Then
            Me.Close()
        End If
    End Sub
End Class
