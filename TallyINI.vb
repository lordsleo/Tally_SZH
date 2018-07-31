Imports TALLY.DBControl
Imports System.IO

Public Class TallyINI
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btResure As System.Windows.Forms.Button
    Friend WithEvents txtdownload As System.Windows.Forms.TextBox
    Friend WithEvents OpenDown As System.Windows.Forms.Button
    Friend WithEvents txtupload As System.Windows.Forms.TextBox
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents OpenUpload As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtdownload = New System.Windows.Forms.TextBox
        Me.OpenDown = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtupload = New System.Windows.Forms.TextBox
        Me.OpenUpload = New System.Windows.Forms.Button
        Me.btResure = New System.Windows.Forms.Button
        Me.btCancel = New System.Windows.Forms.Button
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.SuspendLayout()
        '
        'txtdownload
        '
        Me.txtdownload.Location = New System.Drawing.Point(83, 40)
        Me.txtdownload.Name = "txtdownload"
        Me.txtdownload.Size = New System.Drawing.Size(322, 21)
        Me.txtdownload.TabIndex = 18
        Me.txtdownload.Text = ""
        '
        'OpenDown
        '
        Me.OpenDown.Location = New System.Drawing.Point(409, 40)
        Me.OpenDown.Name = "OpenDown"
        Me.OpenDown.Size = New System.Drawing.Size(32, 20)
        Me.OpenDown.TabIndex = 17
        Me.OpenDown.Text = "..."
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(27, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "下载目录"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(27, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "上传目录"
        '
        'txtupload
        '
        Me.txtupload.Location = New System.Drawing.Point(83, 96)
        Me.txtupload.Name = "txtupload"
        Me.txtupload.Size = New System.Drawing.Size(322, 21)
        Me.txtupload.TabIndex = 24
        Me.txtupload.Text = ""
        '
        'OpenUpload
        '
        Me.OpenUpload.Location = New System.Drawing.Point(409, 96)
        Me.OpenUpload.Name = "OpenUpload"
        Me.OpenUpload.Size = New System.Drawing.Size(32, 20)
        Me.OpenUpload.TabIndex = 23
        Me.OpenUpload.Text = "..."
        '
        'btResure
        '
        Me.btResure.Location = New System.Drawing.Point(149, 144)
        Me.btResure.Name = "btResure"
        Me.btResure.Size = New System.Drawing.Size(65, 24)
        Me.btResure.TabIndex = 26
        Me.btResure.Text = "确认"
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(253, 144)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(65, 24)
        Me.btCancel.TabIndex = 26
        Me.btCancel.Text = "取消"
        '
        'FolderBrowserDialog1
        '
        '
        'TallyINI
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(466, 207)
        Me.Controls.Add(Me.btResure)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtupload)
        Me.Controls.Add(Me.txtdownload)
        Me.Controls.Add(Me.OpenUpload)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OpenDown)
        Me.Controls.Add(Me.btCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TallyINI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "路径设置"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub TallyINI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        readpath()
    End Sub

    Private Sub readpath()
        Dim strinfo As String
        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        FilePath = PathStr + "Tally.ini"

        Try
            Dim sr As New StreamReader(FilePath)
            Do While sr.Peek() > 0
                strinfo = sr.ReadLine()
                If strinfo = "[upload]" Then
                    strinfo = sr.ReadLine()
                    txtupload.Text = strinfo
                End If
                If strinfo = "[download]" Then
                    strinfo = sr.ReadLine()
                    txtdownload.Text = strinfo
                End If
            Loop
            sr.Close()
        Catch
            MsgBox("读取设置文件信息出错，请检查！", MsgBoxStyle.OKOnly, "提示")
            saveini()
        End Try
    End Sub

    Private Sub OpenDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenDown.Click
        'OpenFileDialog.AddExtension = True
        'OpenFileDialog.Filter = "All files (*.*)|*.*"
        'OpenFileDialog.InitialDirectory = txtdownload.Text

        'Dim mFileInfo As IO.FileInfo
        'With OpenFileDialog.ShowDialog = DialogResult.OK
        '    mFileInfo = New IO.FileInfo(OpenFileDialog.FileName)
        '    txtdownload.Text = mFileInfo.DirectoryName
        'End With

        With FolderBrowserDialog1.ShowDialog = DialogResult.OK
            txtdownload.Text = FolderBrowserDialog1.SelectedPath
        End With
    End Sub

    Private Sub OpenUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenUpload.Click
        'OpenFileDialog.AddExtension = True
        'OpenFileDialog.Filter = "All files (*.*)|*.*"
        'OpenFileDialog.InitialDirectory = txtupload.Text
        'Dim mFileInfo As IO.FileInfo
        'With OpenFileDialog.ShowDialog = DialogResult.Yes
        '    mFileInfo = New IO.FileInfo(OpenFileDialog.FileName)
        '    txtupload.Text = mFileInfo.DirectoryName
        'End With

        With FolderBrowserDialog1.ShowDialog = DialogResult.OK
            txtupload.Text = FolderBrowserDialog1.SelectedPath
        End With
    End Sub

    Private Sub btResure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResure.Click
        saveini()
        Me.Close()
    End Sub

    Private Sub saveini()
        File.Delete(FilePath)
        Dim sw As New StreamWriter(FilePath, FileMode.OpenOrCreate)
        sw.WriteLine("[upload]")
        If txtupload.Text.Length > 0 Then
            sw.WriteLine(txtupload.Text)
        Else
            sw.WriteLine("d:\")
        End If
        sw.WriteLine()
        sw.WriteLine("[download]")
        If txtdownload.Text.Length > 0 Then
            sw.WriteLine(txtdownload.Text)
        Else
            sw.WriteLine("d:\")
        End If
        sw.Close()
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        Me.Close()
    End Sub

End Class
