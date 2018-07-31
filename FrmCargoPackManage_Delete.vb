Imports TALLY.DBControl
Public Class FrmCargoPackManage_Delete
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()

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
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtProvider As System.Windows.Forms.TextBox
    Friend WithEvents txtLeader As System.Windows.Forms.TextBox
    Friend WithEvents dtpTimeLead As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtRecedeAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtPackNum As System.Windows.Forms.TextBox
    Friend WithEvents txtLeadAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbGoodsCode As System.Windows.Forms.ComboBox
    Friend WithEvents txtMargin As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTeam As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtProvider = New System.Windows.Forms.TextBox
        Me.txtLeader = New System.Windows.Forms.TextBox
        Me.dtpTimeLead = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txtRecedeAmount = New System.Windows.Forms.TextBox
        Me.txtPackNum = New System.Windows.Forms.TextBox
        Me.txtLeadAmount = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cbGoodsCode = New System.Windows.Forms.ComboBox
        Me.txtMargin = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtTeam = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtpTimeEnd = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtpTimeBegin = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(110, 254)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 378
        Me.btQuit.Text = "ȡ��"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(44, 254)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 377
        Me.btSave.Text = "ȷ��"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(8, 8)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 20)
        Me.Label17.TabIndex = 365
        Me.Label17.Text = "�ᵥ"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtProvider
        '
        Me.txtProvider.Location = New System.Drawing.Point(82, 226)
        Me.txtProvider.MaxLength = 10
        Me.txtProvider.Name = "txtProvider"
        Me.txtProvider.Size = New System.Drawing.Size(128, 21)
        Me.txtProvider.TabIndex = 375
        Me.txtProvider.Text = ""
        '
        'txtLeader
        '
        Me.txtLeader.Location = New System.Drawing.Point(82, 204)
        Me.txtLeader.MaxLength = 10
        Me.txtLeader.Name = "txtLeader"
        Me.txtLeader.Size = New System.Drawing.Size(128, 21)
        Me.txtLeader.TabIndex = 374
        Me.txtLeader.Text = ""
        '
        'dtpTimeLead
        '
        Me.dtpTimeLead.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeLead.Location = New System.Drawing.Point(82, 94)
        Me.dtpTimeLead.Name = "dtpTimeLead"
        Me.dtpTimeLead.Size = New System.Drawing.Size(128, 21)
        Me.dtpTimeLead.TabIndex = 372
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 373
        Me.Label1.Text = "����ʱ��"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 371
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'txtRecedeAmount
        '
        Me.txtRecedeAmount.Location = New System.Drawing.Point(82, 138)
        Me.txtRecedeAmount.MaxLength = 10
        Me.txtRecedeAmount.Name = "txtRecedeAmount"
        Me.txtRecedeAmount.Size = New System.Drawing.Size(128, 21)
        Me.txtRecedeAmount.TabIndex = 358
        Me.txtRecedeAmount.Text = ""
        '
        'txtPackNum
        '
        Me.txtPackNum.Location = New System.Drawing.Point(82, 160)
        Me.txtPackNum.MaxLength = 10
        Me.txtPackNum.Name = "txtPackNum"
        Me.txtPackNum.Size = New System.Drawing.Size(128, 21)
        Me.txtPackNum.TabIndex = 359
        Me.txtPackNum.Text = ""
        '
        'txtLeadAmount
        '
        Me.txtLeadAmount.Location = New System.Drawing.Point(82, 116)
        Me.txtLeadAmount.MaxLength = 10
        Me.txtLeadAmount.Name = "txtLeadAmount"
        Me.txtLeadAmount.Size = New System.Drawing.Size(128, 21)
        Me.txtLeadAmount.TabIndex = 357
        Me.txtLeadAmount.Text = ""
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(8, 118)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 20)
        Me.Label19.TabIndex = 370
        Me.Label19.Text = "����"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(8, 228)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 20)
        Me.Label18.TabIndex = 367
        Me.Label18.Text = "������"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 206)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 20)
        Me.Label14.TabIndex = 366
        Me.Label14.Text = "������"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbGoodsCode
        '
        Me.cbGoodsCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGoodsCode.Location = New System.Drawing.Point(82, 6)
        Me.cbGoodsCode.Name = "cbGoodsCode"
        Me.cbGoodsCode.Size = New System.Drawing.Size(128, 20)
        Me.cbGoodsCode.TabIndex = 353
        '
        'txtMargin
        '
        Me.txtMargin.Location = New System.Drawing.Point(82, 182)
        Me.txtMargin.MaxLength = 10
        Me.txtMargin.Name = "txtMargin"
        Me.txtMargin.Size = New System.Drawing.Size(128, 21)
        Me.txtMargin.TabIndex = 360
        Me.txtMargin.Text = ""
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 184)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 20)
        Me.Label15.TabIndex = 364
        Me.Label15.Text = "���"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTeam
        '
        Me.txtTeam.Location = New System.Drawing.Point(82, 28)
        Me.txtTeam.MaxLength = 20
        Me.txtTeam.Name = "txtTeam"
        Me.txtTeam.Size = New System.Drawing.Size(128, 21)
        Me.txtTeam.TabIndex = 354
        Me.txtTeam.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 20)
        Me.Label9.TabIndex = 363
        Me.Label9.Text = "�������"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeEnd
        '
        Me.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeEnd.Location = New System.Drawing.Point(82, 72)
        Me.dtpTimeEnd.Name = "dtpTimeEnd"
        Me.dtpTimeEnd.Size = New System.Drawing.Size(128, 21)
        Me.dtpTimeEnd.TabIndex = 356
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 362
        Me.Label8.Text = "��ҵֹʱ"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeBegin
        '
        Me.dtpTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeBegin.Location = New System.Drawing.Point(82, 50)
        Me.dtpTimeBegin.Name = "dtpTimeBegin"
        Me.dtpTimeBegin.Size = New System.Drawing.Size(128, 21)
        Me.dtpTimeBegin.TabIndex = 355
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 361
        Me.Label7.Text = "��ҵ��ʱ"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(8, 162)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 20)
        Me.Label20.TabIndex = 369
        Me.Label20.Text = "�����"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(8, 140)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 20)
        Me.Label21.TabIndex = 368
        Me.Label21.Text = "����"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCargoPackManage_Delete
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(216, 281)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtProvider)
        Me.Controls.Add(Me.txtLeader)
        Me.Controls.Add(Me.dtpTimeLead)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtRecedeAmount)
        Me.Controls.Add(Me.txtPackNum)
        Me.Controls.Add(Me.txtLeadAmount)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbGoodsCode)
        Me.Controls.Add(Me.txtMargin)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtTeam)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtpTimeEnd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpTimeBegin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargoPackManage_Delete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ɢ����Ƥ������Ϣ ɾ��"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCargoPackManage_Delete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Dim dvCodeGoods As New DataView()
        Dim sqlCodeGoods As String

        'sqlCodeGoods = "SELECT CARGO_GOODS.SHIP_ID, CARGO_GOODS.CODE_GOODS, CODEGOODS.GOODS FROM CARGO_GOODS LEFT OUTER JOIN CODEGOODS ON CARGO_GOODS.CODE_GOODS = CODEGOODS.CODE where CARGO_GOODS.SHIP_ID = '" & Ship_ID & "'"
        ' ��Ϊ�ᵥ
        sqlCodeGoods = "SELECT BLNO FROM CARGO_GOODS  where SHIP_ID = '" & Ship_ID & "'"
        dvCodeGoods = Filldata(sqlCodeGoods)
        cbGoodsCode.DataSource = dvCodeGoods
        cbGoodsCode.DisplayMember = "BLNO"
        cbGoodsCode.ValueMember = "BLNO"

        sqlstr = "select * from CARGO_PACK_MANAGE where PACK_MANAGE_ID =" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        dtpTimeBegin.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"
        dtpTimeEnd.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"
        dtpTimeLead.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"
        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("PACK_MANAGE_ID")
            txtTeam.Text = ds.Tables(0).Rows(0).Item("TEAM")
            txtLeader.Text = ds.Tables(0).Rows(0).Item("BAG_LEADER")
            txtProvider.Text = ds.Tables(0).Rows(0).Item("PROVIDER")

            If Not IsDBNull(ds.Tables(0).Rows(0).Item("LEAD_AMOUNT")) Then
                txtLeadAmount.Text = ds.Tables(0).Rows(0).Item("LEAD_AMOUNT")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("RECEDE_AMOUNT")) Then
                txtRecedeAmount.Text = ds.Tables(0).Rows(0).Item("RECEDE_AMOUNT")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("PACK_NUMBER")) Then
                txtPackNum.Text = ds.Tables(0).Rows(0).Item("PACK_NUMBER")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("MARGIN")) Then
                txtMargin.Text = ds.Tables(0).Rows(0).Item("MARGIN")
            End If

            dtpTimeBegin.Value = ds.Tables(0).Rows(0).Item("TIME_FROM")
            dtpTimeEnd.Value = ds.Tables(0).Rows(0).Item("TIME_TO")
            dtpTimeLead.Value = ds.Tables(0).Rows(0).Item("TIME_LEAD_RECEDE")

            cbGoodsCode.SelectedValue = ds.Tables(0).Rows(0).Item("GOODS_CODE")
        End If
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            If MessageBox.Show("ȷ��Ҫɾ����", "������ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                '��¼������־
                Call OperateHistory(G_DeptName, Now, G_User, "ɾ��", "CARGO_PACK_MANAGE", Trim(txtID.Text), "PACK_MANAGE_ID")

                ds.Tables(0).Rows(0).Delete()
                sqlda.Update(ds)
            End If
            Me.Close()
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class