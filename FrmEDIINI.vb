Imports TALLY.DBControl
Imports System.IO
Public Class FrmEDIINI
    Inherits System.Windows.Forms.Form
    Dim PathStr As String
    Dim FilePath As String
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
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSendFile As System.Windows.Forms.TextBox
    Friend WithEvents OpenSFile As System.Windows.Forms.Button
    Friend WithEvents OpenBFile As System.Windows.Forms.Button
    Friend WithEvents txtReceiveFile As System.Windows.Forms.TextBox
    Friend WithEvents OpenRFile As System.Windows.Forms.Button
    Friend WithEvents txtBackUpFile As System.Windows.Forms.TextBox
    Friend WithEvents btResure As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.txtSendFile = New System.Windows.Forms.TextBox()
        Me.OpenSFile = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBackUpFile = New System.Windows.Forms.TextBox()
        Me.OpenBFile = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtReceiveFile = New System.Windows.Forms.TextBox()
        Me.OpenRFile = New System.Windows.Forms.Button()
        Me.btResure = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSendFile
        '
        Me.txtSendFile.Location = New System.Drawing.Point(58, 24)
        Me.txtSendFile.Name = "txtSendFile"
        Me.txtSendFile.Size = New System.Drawing.Size(322, 21)
        Me.txtSendFile.TabIndex = 18
        Me.txtSendFile.Text = ""
        '
        'OpenSFile
        '
        Me.OpenSFile.Location = New System.Drawing.Point(382, 24)
        Me.OpenSFile.Name = "OpenSFile"
        Me.OpenSFile.Size = New System.Drawing.Size(32, 20)
        Me.OpenSFile.TabIndex = 17
        Me.OpenSFile.Text = "..."
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "发送目录"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "备份目录"
        '
        'txtBackUpFile
        '
        Me.txtBackUpFile.Location = New System.Drawing.Point(58, 108)
        Me.txtBackUpFile.Name = "txtBackUpFile"
        Me.txtBackUpFile.Size = New System.Drawing.Size(322, 21)
        Me.txtBackUpFile.TabIndex = 21
        Me.txtBackUpFile.Text = ""
        '
        'OpenBFile
        '
        Me.OpenBFile.Location = New System.Drawing.Point(382, 108)
        Me.OpenBFile.Name = "OpenBFile"
        Me.OpenBFile.Size = New System.Drawing.Size(32, 20)
        Me.OpenBFile.TabIndex = 20
        Me.OpenBFile.Text = "..."
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "接收目录"
        '
        'txtReceiveFile
        '
        Me.txtReceiveFile.Location = New System.Drawing.Point(58, 62)
        Me.txtReceiveFile.Name = "txtReceiveFile"
        Me.txtReceiveFile.Size = New System.Drawing.Size(322, 21)
        Me.txtReceiveFile.TabIndex = 24
        Me.txtReceiveFile.Text = ""
        '
        'OpenRFile
        '
        Me.OpenRFile.Location = New System.Drawing.Point(382, 62)
        Me.OpenRFile.Name = "OpenRFile"
        Me.OpenRFile.Size = New System.Drawing.Size(32, 20)
        Me.OpenRFile.TabIndex = 23
        Me.OpenRFile.Text = "..."
        '
        'btResure
        '
        Me.btResure.Location = New System.Drawing.Point(177, 140)
        Me.btResure.Name = "btResure"
        Me.btResure.Size = New System.Drawing.Size(65, 24)
        Me.btResure.TabIndex = 26
        Me.btResure.Text = "确认"
        '
        'FrmEDIINI
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(418, 173)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btResure, Me.Label3, Me.txtReceiveFile, Me.OpenRFile, Me.Label2, Me.txtBackUpFile, Me.OpenBFile, Me.Label1, Me.txtSendFile, Me.OpenSFile})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEDIINI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EDI 路径设置"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmEDIINI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim str As String
        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        Try
            FilePath = PathStr + "EDIINI.INI"
            Dim sr As New StreamReader(FilePath) '打开报文文件
            txtSendFile.Text = sr.ReadLine()
            txtReceiveFile.Text = sr.ReadLine()
            txtBackUpFile.Text = sr.ReadLine()
            sr.Close()
        Catch
        End Try
    End Sub


    Private Sub OpenSFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenSFile.Click
        OpenFileDialog.AddExtension = True
        OpenFileDialog.DefaultExt = "*.*"
        OpenFileDialog.InitialDirectory = txtSendFile.Text
        OpenFileDialog.ShowDialog()
        txtSendFile.Text = OpenFileDialog.FileName
    End Sub

    Private Sub OpenRFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenRFile.Click
        OpenFileDialog.AddExtension = True
        OpenFileDialog.DefaultExt = "*.*"
        OpenFileDialog.InitialDirectory = txtReceiveFile.Text
        OpenFileDialog.ShowDialog()
        txtReceiveFile.Text = OpenFileDialog.FileName
    End Sub

    Private Sub OpenBFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenBFile.Click
        OpenFileDialog.AddExtension = True
        OpenFileDialog.DefaultExt = "*.*"
        OpenFileDialog.InitialDirectory = txtBackUpFile.Text
        OpenFileDialog.ShowDialog()
        txtBackUpFile.Text = OpenFileDialog.FileName
    End Sub

    Private Sub btResure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResure.Click
        File.Delete(FilePath)
        Dim sw As New StreamWriter(FilePath, FileMode.OpenOrCreate) '打开报文文件
        sw.WriteLine(txtSendFile.Text)
        sw.WriteLine(txtReceiveFile.Text)
        sw.WriteLine(txtBackUpFile.Text)
        sw.Close()
        Me.Close()
    End Sub
End Class
