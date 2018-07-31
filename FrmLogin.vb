Imports TALLY.DBControl
Public Class FrmLogin
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意：以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_user As System.Windows.Forms.TextBox
    Friend WithEvents dc_Company As System.Windows.Forms.ComboBox
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents btResure As System.Windows.Forms.Button
    Friend WithEvents txt_Pwd As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Private WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Txt_user = New System.Windows.Forms.TextBox
        Me.dc_Company = New System.Windows.Forms.ComboBox
        Me.btCancel = New System.Windows.Forms.Button
        Me.btResure = New System.Windows.Forms.Button
        Me.txt_Pwd = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.pictureBox2 = New System.Windows.Forms.PictureBox
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(431, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "密  码:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(431, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "用  户:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(431, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "部  门:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt_user
        '
        Me.Txt_user.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_user.Location = New System.Drawing.Point(483, 304)
        Me.Txt_user.Name = "Txt_user"
        Me.Txt_user.Size = New System.Drawing.Size(143, 21)
        Me.Txt_user.TabIndex = 9
        '
        'dc_Company
        '
        Me.dc_Company.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.dc_Company.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dc_Company.Location = New System.Drawing.Point(483, 280)
        Me.dc_Company.Name = "dc_Company"
        Me.dc_Company.Size = New System.Drawing.Size(143, 20)
        Me.dc_Company.TabIndex = 8
        '
        'btCancel
        '
        Me.btCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btCancel.BackColor = System.Drawing.Color.Transparent
        Me.btCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancel.ForeColor = System.Drawing.Color.Black
        Me.btCancel.Location = New System.Drawing.Point(540, 366)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(60, 24)
        Me.btCancel.TabIndex = 12
        Me.btCancel.Text = "退  出"
        Me.btCancel.UseVisualStyleBackColor = False
        '
        'btResure
        '
        Me.btResure.BackColor = System.Drawing.Color.Transparent
        Me.btResure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btResure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btResure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btResure.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btResure.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btResure.Location = New System.Drawing.Point(449, 366)
        Me.btResure.Name = "btResure"
        Me.btResure.Size = New System.Drawing.Size(59, 24)
        Me.btResure.TabIndex = 11
        Me.btResure.Text = "登  录"
        Me.btResure.UseVisualStyleBackColor = False
        '
        'txt_Pwd
        '
        Me.txt_Pwd.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Pwd.Location = New System.Drawing.Point(483, 327)
        Me.txt_Pwd.Name = "txt_Pwd"
        Me.txt_Pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Pwd.Size = New System.Drawing.Size(143, 21)
        Me.txt_Pwd.TabIndex = 10
        '
        'Timer1
        '
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(263, 412)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(262, 20)
        Me.Label4.TabIndex = 17
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.ErrorImage = Nothing
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(416, 281)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(21, 23)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(416, 325)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(21, 22)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox2.TabIndex = 22
        Me.pictureBox2.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(416, 303)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(21, 22)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 21
        Me.pictureBox1.TabStop = False
        '
        'FrmLogin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.btCancel
        Me.ClientSize = New System.Drawing.Size(930, 565)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btResure)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_user)
        Me.Controls.Add(Me.txt_Pwd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dc_Company)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmLogin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "登录窗口"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim m As Integer
    Dim dsCompany As New DataSet
    Dim TDay As String
    Dim i As Short

    Private Sub btResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResure.Click
        Dim i As Integer
        Dim sqlstr As String
        Dim ds As New DataSet()
        Dim sqlpart As String
        Dim dspart As New DataSet()

        Dim dsVersion As New DataSet()
        Dim PathStr As String
        Dim FilePath As String

        G_DeptCode = dc_Company.SelectedValue
        G_DeptName = dc_Company.Text
        Try
            sqlstr = "select * from SYSTEM_USER_TABLE where Dept_Code= '" & G_DeptCode & "' and SERIAL_NAM='" & Trim(Txt_user.Text) & "'"
            Dim dv As DataView = Getdata(sqlstr, ds)
            If dv.Count > 0 Then
                If txt_Pwd.Text = dv(0)("PASSWORD") Then

                    G_User_Serial = Trim(Txt_user.Text)
                    G_User = dv(0)("NAME")
                    G_Part_Id = dv(0)("part_id")
                    G_WorkNo = IIf(IsDBNull(dv(0)("Work_NO")), "", dv(0)("Work_NO"))
                    Dim FrmMain As New FrmMain()
                    FrmMain.Show()
                    Me.Hide()
                Else
                    If m >= 2 Then
                        MsgBox("用户名或密码错误！，请检查！", MsgBoxStyle.OKOnly, "外轮理货公司业务系统")
                        Me.Close()
                    End If
                    MsgBox("用户名或密码错误！，请检查！", MsgBoxStyle.OKOnly, "外轮理货公司业务系统")
                    m = m + 1
                End If
            Else
                If m >= 2 Then
                    MsgBox("用户名或密码错误！，请检查！", MsgBoxStyle.OKOnly, "外轮理货公司业务系统")
                    Me.Close()
                End If
                MsgBox("用户名或密码错误！，请检查！", MsgBoxStyle.OKOnly, "外轮理货公司业务系统")
                m = m + 1
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connstr = conn
        Dim sqlstr As String
        Me.Timer1.Start()
  
        sqlstr = "select Dept_Code,Dept_Name from DepartMent where dept_code='26.11.11'  or  dept_code='26.11.12' order by Dept_Code"  '连云庙岭
        'sqlstr = "select Dept_Code,Dept_Name from DepartMent where dept_code='26.11.11'  or  dept_code='26.11.12' order by DEPARTMENT_ID"  '连云庙岭
        'sqlstr = "select Dept_Code,Dept_Name from DepartMent where dept_code='26.11'  order by Dept_Code"  '业务部

        Dim dv As DataView = Getdata(sqlstr, dsCompany)
        dc_Company.DataSource = dv
        dc_Company.DisplayMember = "Dept_Name"
        dc_Company.ValueMember = "Dept_Code"


    End Sub

    Private Sub txtpwd_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Pwd.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btResure.Focus()
            Call Me.btResume_Click(sender, e)
        End If
    End Sub

    Private Sub FrmLogin_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        End
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        End
    End Sub

    Private Sub dc_Company_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dc_Company.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_user.Focus()
        End If
    End Sub

    Private Sub Txt_user_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_user.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Pwd.Focus()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        i = Weekday(Today)
        Select Case i
            Case 1
                TDay = "星期日"
            Case 2
                TDay = "星期一"
            Case 3
                TDay = "星期二"
            Case 4
                TDay = "星期三"
            Case 5
                TDay = "星期四"
            Case 6
                TDay = "星期五"
            Case 7
                TDay = "星期六"
        End Select
        Label4.Text = Date.Now() & " — " & TDay
    End Sub

End Class
