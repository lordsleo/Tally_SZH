Public Class FrmCargoWater_Judge
    Inherits System.Windows.Forms.Form
    Public markFc, markAc, markCf, markShip As Boolean

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
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbRear As System.Windows.Forms.RadioButton
    Friend WithEvents rbHead As System.Windows.Forms.RadioButton
    Friend WithEvents cbRear As System.Windows.Forms.CheckBox
    Friend WithEvents cbHead As System.Windows.Forms.CheckBox
    Friend WithEvents rbPiaoHind As System.Windows.Forms.RadioButton
    Friend WithEvents rbPiaoFront As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbEmpty As System.Windows.Forms.RadioButton
    Friend WithEvents rbHeavy As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btSave = New System.Windows.Forms.Button()
        Me.rbRear = New System.Windows.Forms.RadioButton()
        Me.rbHead = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbRear = New System.Windows.Forms.CheckBox()
        Me.cbHead = New System.Windows.Forms.CheckBox()
        Me.rbPiaoHind = New System.Windows.Forms.RadioButton()
        Me.rbPiaoFront = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbEmpty = New System.Windows.Forms.RadioButton()
        Me.rbHeavy = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(66, 158)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 476
        Me.btSave.Text = "ȷ��"
        '
        'rbRear
        '
        Me.rbRear.Checked = True
        Me.rbRear.Location = New System.Drawing.Point(6, 12)
        Me.rbRear.Name = "rbRear"
        Me.rbRear.Size = New System.Drawing.Size(88, 20)
        Me.rbRear.TabIndex = 478
        Me.rbRear.TabStop = True
        Me.rbRear.Text = "β����(��)"
        '
        'rbHead
        '
        Me.rbHead.Location = New System.Drawing.Point(96, 12)
        Me.rbHead.Name = "rbHead"
        Me.rbHead.Size = New System.Drawing.Size(88, 20)
        Me.rbHead.TabIndex = 479
        Me.rbHead.Text = "������(��)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbRear, Me.rbHead, Me.rbRear, Me.cbHead})
        Me.GroupBox1.Location = New System.Drawing.Point(4, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(188, 78)
        Me.GroupBox1.TabIndex = 480
        Me.GroupBox1.TabStop = False
        '
        'cbRear
        '
        Me.cbRear.Location = New System.Drawing.Point(6, 56)
        Me.cbRear.Name = "cbRear"
        Me.cbRear.Size = New System.Drawing.Size(178, 20)
        Me.cbRear.TabIndex = 482
        Me.cbRear.Text = "��βˮ���ڴ�β����ǰ"
        '
        'cbHead
        '
        Me.cbHead.Location = New System.Drawing.Point(6, 34)
        Me.cbHead.Name = "cbHead"
        Me.cbHead.Size = New System.Drawing.Size(178, 20)
        Me.cbHead.TabIndex = 481
        Me.cbHead.Text = "����ˮ���ڴ��״���ǰ"
        '
        'rbPiaoHind
        '
        Me.rbPiaoHind.Location = New System.Drawing.Point(96, 12)
        Me.rbPiaoHind.Name = "rbPiaoHind"
        Me.rbPiaoHind.Size = New System.Drawing.Size(88, 20)
        Me.rbPiaoHind.TabIndex = 482
        Me.rbPiaoHind.Text = "Ư�Ĵ��к�"
        '
        'rbPiaoFront
        '
        Me.rbPiaoFront.Checked = True
        Me.rbPiaoFront.Location = New System.Drawing.Point(6, 12)
        Me.rbPiaoFront.Name = "rbPiaoFront"
        Me.rbPiaoFront.Size = New System.Drawing.Size(88, 20)
        Me.rbPiaoFront.TabIndex = 481
        Me.rbPiaoFront.TabStop = True
        Me.rbPiaoFront.Text = "Ư�Ĵ���ǰ"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbPiaoHind, Me.rbPiaoFront})
        Me.GroupBox2.Location = New System.Drawing.Point(4, 82)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(188, 34)
        Me.GroupBox2.TabIndex = 485
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbEmpty, Me.rbHeavy})
        Me.GroupBox3.Location = New System.Drawing.Point(4, 118)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(188, 34)
        Me.GroupBox3.TabIndex = 486
        Me.GroupBox3.TabStop = False
        '
        'rbEmpty
        '
        Me.rbEmpty.Location = New System.Drawing.Point(96, 12)
        Me.rbEmpty.Name = "rbEmpty"
        Me.rbEmpty.Size = New System.Drawing.Size(88, 20)
        Me.rbEmpty.TabIndex = 482
        Me.rbEmpty.Text = "�մ�"
        '
        'rbHeavy
        '
        Me.rbHeavy.Checked = True
        Me.rbHeavy.Location = New System.Drawing.Point(6, 12)
        Me.rbHeavy.Name = "rbHeavy"
        Me.rbHeavy.Size = New System.Drawing.Size(88, 20)
        Me.rbHeavy.TabIndex = 481
        Me.rbHeavy.TabStop = True
        Me.rbHeavy.Text = "�ش�"
        '
        'FrmCargoWater_Judge
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(196, 185)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox3, Me.GroupBox2, Me.btSave, Me.GroupBox1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargoWater_Judge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "�������"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        If rbRear.Checked Then
            If cbHead.Checked Then
                markFc = True   '+Fc
            Else
                markFc = False  '-Fc
            End If
            If cbRear.Checked Then
                markAc = True   '+Ac
            Else
                markAc = False  '-Ac
            End If
        ElseIf rbHead.Checked Then
            If cbHead.Checked Then
                markFc = False
            Else
                markFc = True
            End If
            If cbRear.Checked Then
                markAc = False
            Else
                markAc = True
            End If
        End If
        If rbPiaoFront.Checked = True Then
            markCf = True   'CfΪ��
        Else
            markCf = False  'CfΪ��
        End If
        If rbHeavy.Checked = True Then
            markShip = True '�ش�
        Else
            markShip = False    '�մ�
        End If
        Me.Close()
    End Sub

    Private Sub FrmCargoWater_Judge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
