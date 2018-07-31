Public Class FrmSort
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CB1 As System.Windows.Forms.CheckBox
    Friend WithEvents CB2 As System.Windows.Forms.CheckBox
    Friend WithEvents CB3 As System.Windows.Forms.CheckBox
    Friend WithEvents CB4 As System.Windows.Forms.CheckBox
    Friend WithEvents CB5 As System.Windows.Forms.CheckBox
    Friend WithEvents CB6 As System.Windows.Forms.CheckBox
    Friend WithEvents CB7 As System.Windows.Forms.CheckBox
    Friend WithEvents CB8 As System.Windows.Forms.CheckBox
    Friend WithEvents CB88 As System.Windows.Forms.CheckBox
    Friend WithEvents CB77 As System.Windows.Forms.CheckBox
    Friend WithEvents CB66 As System.Windows.Forms.CheckBox
    Friend WithEvents CB55 As System.Windows.Forms.CheckBox
    Friend WithEvents CB44 As System.Windows.Forms.CheckBox
    Friend WithEvents CB33 As System.Windows.Forms.CheckBox
    Friend WithEvents CB22 As System.Windows.Forms.CheckBox
    Friend WithEvents CB11 As System.Windows.Forms.CheckBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCacel As System.Windows.Forms.Button
    Friend WithEvents CB80 As System.Windows.Forms.CheckBox
    Friend WithEvents CB70 As System.Windows.Forms.CheckBox
    Friend WithEvents CB60 As System.Windows.Forms.CheckBox
    Friend WithEvents CB50 As System.Windows.Forms.CheckBox
    Friend WithEvents CB40 As System.Windows.Forms.CheckBox
    Friend WithEvents CB30 As System.Windows.Forms.CheckBox
    Friend WithEvents CB20 As System.Windows.Forms.CheckBox
    Friend WithEvents CB10 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CB88 = New System.Windows.Forms.CheckBox()
        Me.CB77 = New System.Windows.Forms.CheckBox()
        Me.CB66 = New System.Windows.Forms.CheckBox()
        Me.CB55 = New System.Windows.Forms.CheckBox()
        Me.CB44 = New System.Windows.Forms.CheckBox()
        Me.CB33 = New System.Windows.Forms.CheckBox()
        Me.CB22 = New System.Windows.Forms.CheckBox()
        Me.CB11 = New System.Windows.Forms.CheckBox()
        Me.CB8 = New System.Windows.Forms.CheckBox()
        Me.CB7 = New System.Windows.Forms.CheckBox()
        Me.CB6 = New System.Windows.Forms.CheckBox()
        Me.CB5 = New System.Windows.Forms.CheckBox()
        Me.CB4 = New System.Windows.Forms.CheckBox()
        Me.CB3 = New System.Windows.Forms.CheckBox()
        Me.CB2 = New System.Windows.Forms.CheckBox()
        Me.CB1 = New System.Windows.Forms.CheckBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCacel = New System.Windows.Forms.Button()
        Me.CB80 = New System.Windows.Forms.CheckBox()
        Me.CB70 = New System.Windows.Forms.CheckBox()
        Me.CB60 = New System.Windows.Forms.CheckBox()
        Me.CB50 = New System.Windows.Forms.CheckBox()
        Me.CB40 = New System.Windows.Forms.CheckBox()
        Me.CB30 = New System.Windows.Forms.CheckBox()
        Me.CB20 = New System.Windows.Forms.CheckBox()
        Me.CB10 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.CB80, Me.CB70, Me.CB60, Me.CB50, Me.CB40, Me.CB30, Me.CB20, Me.CB10, Me.CB88, Me.CB77, Me.CB66, Me.CB55, Me.CB44, Me.CB33, Me.CB22, Me.CB11, Me.CB8, Me.CB7, Me.CB6, Me.CB5, Me.CB4, Me.CB3, Me.CB2, Me.CB1})
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 276)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "请选择排序字段"
        '
        'CB88
        '
        Me.CB88.Location = New System.Drawing.Point(196, 236)
        Me.CB88.Name = "CB88"
        Me.CB88.Size = New System.Drawing.Size(52, 22)
        Me.CB88.TabIndex = 15
        Me.CB88.Text = "降序"
        '
        'CB77
        '
        Me.CB77.Location = New System.Drawing.Point(196, 206)
        Me.CB77.Name = "CB77"
        Me.CB77.Size = New System.Drawing.Size(52, 22)
        Me.CB77.TabIndex = 14
        Me.CB77.Text = "降序"
        '
        'CB66
        '
        Me.CB66.Location = New System.Drawing.Point(196, 176)
        Me.CB66.Name = "CB66"
        Me.CB66.Size = New System.Drawing.Size(52, 22)
        Me.CB66.TabIndex = 13
        Me.CB66.Text = "降序"
        '
        'CB55
        '
        Me.CB55.Location = New System.Drawing.Point(196, 146)
        Me.CB55.Name = "CB55"
        Me.CB55.Size = New System.Drawing.Size(52, 22)
        Me.CB55.TabIndex = 12
        Me.CB55.Text = "降序"
        '
        'CB44
        '
        Me.CB44.Location = New System.Drawing.Point(196, 116)
        Me.CB44.Name = "CB44"
        Me.CB44.Size = New System.Drawing.Size(52, 22)
        Me.CB44.TabIndex = 11
        Me.CB44.Text = "降序"
        '
        'CB33
        '
        Me.CB33.Location = New System.Drawing.Point(196, 86)
        Me.CB33.Name = "CB33"
        Me.CB33.Size = New System.Drawing.Size(52, 22)
        Me.CB33.TabIndex = 10
        Me.CB33.Text = "降序"
        '
        'CB22
        '
        Me.CB22.Location = New System.Drawing.Point(196, 56)
        Me.CB22.Name = "CB22"
        Me.CB22.Size = New System.Drawing.Size(52, 22)
        Me.CB22.TabIndex = 9
        Me.CB22.Text = "降序"
        '
        'CB11
        '
        Me.CB11.Location = New System.Drawing.Point(196, 26)
        Me.CB11.Name = "CB11"
        Me.CB11.Size = New System.Drawing.Size(52, 22)
        Me.CB11.TabIndex = 8
        Me.CB11.Text = "降序"
        '
        'CB8
        '
        Me.CB8.Location = New System.Drawing.Point(12, 236)
        Me.CB8.Name = "CB8"
        Me.CB8.Size = New System.Drawing.Size(106, 22)
        Me.CB8.TabIndex = 7
        Me.CB8.Text = "开工时间"
        '
        'CB7
        '
        Me.CB7.Location = New System.Drawing.Point(12, 206)
        Me.CB7.Name = "CB7"
        Me.CB7.Size = New System.Drawing.Size(106, 22)
        Me.CB7.TabIndex = 6
        Me.CB7.Text = "货名"
        '
        'CB6
        '
        Me.CB6.Location = New System.Drawing.Point(12, 176)
        Me.CB6.Name = "CB6"
        Me.CB6.Size = New System.Drawing.Size(106, 22)
        Me.CB6.TabIndex = 5
        Me.CB6.Text = "国轮外轮"
        '
        'CB5
        '
        Me.CB5.Location = New System.Drawing.Point(12, 146)
        Me.CB5.Name = "CB5"
        Me.CB5.Size = New System.Drawing.Size(106, 22)
        Me.CB5.TabIndex = 4
        Me.CB5.Text = "船舶状态"
        '
        'CB4
        '
        Me.CB4.Location = New System.Drawing.Point(12, 116)
        Me.CB4.Name = "CB4"
        Me.CB4.Size = New System.Drawing.Size(106, 22)
        Me.CB4.TabIndex = 3
        Me.CB4.Text = "理货部"
        '
        'CB3
        '
        Me.CB3.Location = New System.Drawing.Point(12, 86)
        Me.CB3.Name = "CB3"
        Me.CB3.Size = New System.Drawing.Size(106, 22)
        Me.CB3.TabIndex = 2
        Me.CB3.Text = "进出口"
        '
        'CB2
        '
        Me.CB2.Location = New System.Drawing.Point(12, 56)
        Me.CB2.Name = "CB2"
        Me.CB2.Size = New System.Drawing.Size(106, 22)
        Me.CB2.TabIndex = 1
        Me.CB2.Text = "英文船名"
        '
        'CB1
        '
        Me.CB1.Location = New System.Drawing.Point(12, 26)
        Me.CB1.Name = "CB1"
        Me.CB1.Size = New System.Drawing.Size(106, 22)
        Me.CB1.TabIndex = 0
        Me.CB1.Text = "中文船名"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(60, 296)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(65, 24)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "确认"
        '
        'btnCacel
        '
        Me.btnCacel.Location = New System.Drawing.Point(136, 296)
        Me.btnCacel.Name = "btnCacel"
        Me.btnCacel.Size = New System.Drawing.Size(65, 24)
        Me.btnCacel.TabIndex = 2
        Me.btnCacel.Text = "取消"
        '
        'CB80
        '
        Me.CB80.Location = New System.Drawing.Point(138, 236)
        Me.CB80.Name = "CB80"
        Me.CB80.Size = New System.Drawing.Size(52, 22)
        Me.CB80.TabIndex = 23
        Me.CB80.Text = "升序"
        '
        'CB70
        '
        Me.CB70.Location = New System.Drawing.Point(138, 206)
        Me.CB70.Name = "CB70"
        Me.CB70.Size = New System.Drawing.Size(52, 22)
        Me.CB70.TabIndex = 22
        Me.CB70.Text = "升序"
        '
        'CB60
        '
        Me.CB60.Location = New System.Drawing.Point(138, 176)
        Me.CB60.Name = "CB60"
        Me.CB60.Size = New System.Drawing.Size(52, 22)
        Me.CB60.TabIndex = 21
        Me.CB60.Text = "升序"
        '
        'CB50
        '
        Me.CB50.Location = New System.Drawing.Point(138, 146)
        Me.CB50.Name = "CB50"
        Me.CB50.Size = New System.Drawing.Size(52, 22)
        Me.CB50.TabIndex = 20
        Me.CB50.Text = "升序"
        '
        'CB40
        '
        Me.CB40.Location = New System.Drawing.Point(138, 116)
        Me.CB40.Name = "CB40"
        Me.CB40.Size = New System.Drawing.Size(52, 22)
        Me.CB40.TabIndex = 19
        Me.CB40.Text = "升序"
        '
        'CB30
        '
        Me.CB30.Location = New System.Drawing.Point(138, 86)
        Me.CB30.Name = "CB30"
        Me.CB30.Size = New System.Drawing.Size(52, 22)
        Me.CB30.TabIndex = 18
        Me.CB30.Text = "升序"
        '
        'CB20
        '
        Me.CB20.Location = New System.Drawing.Point(138, 56)
        Me.CB20.Name = "CB20"
        Me.CB20.Size = New System.Drawing.Size(52, 22)
        Me.CB20.TabIndex = 17
        Me.CB20.Text = "升序"
        '
        'CB10
        '
        Me.CB10.Location = New System.Drawing.Point(138, 26)
        Me.CB10.Name = "CB10"
        Me.CB10.Size = New System.Drawing.Size(52, 22)
        Me.CB10.TabIndex = 16
        Me.CB10.Text = "升序"
        '
        'FrmSort
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(262, 329)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCacel, Me.btnOK, Me.GroupBox1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSort"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "排序"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        SortStr = " "
        If CB1.Checked = True Then
            SortStr = SortStr & "CHI_VESSEL "
            If CB11.Checked = True Then
                SortStr = SortStr & "DESC,"
            Else
                SortStr = SortStr & ","
            End If
        End If
        If CB2.Checked = True Then
            SortStr = SortStr & "ENG_VESSEL "
            If CB22.Checked = True Then
                SortStr = SortStr & "DESC,"
            Else
                SortStr = SortStr & ","
            End If
        End If
        If CB3.Checked = True Then
            SortStr = SortStr & "InOutPort "
            If CB33.Checked = True Then
                SortStr = SortStr & "DESC,"
            Else
                SortStr = SortStr & ","
            End If
        End If
        If CB4.Checked = True Then
            SortStr = SortStr & "Dept_Code "
            If CB44.Checked = True Then
                SortStr = SortStr & "DESC,"
            Else
                SortStr = SortStr & ","
            End If
        End If
        If CB5.Checked = True Then
            SortStr = SortStr & "SHIP_STATU "
            If CB55.Checked = True Then
                SortStr = SortStr & "DESC,"
            Else
                SortStr = SortStr & ","
            End If
        End If
        If CB6.Checked = True Then
            SortStr = SortStr & "CODE_SHIP_TYPE "
            If CB66.Checked = True Then
                SortStr = SortStr & "DESC,"
            Else
                SortStr = SortStr & ","
            End If
        End If
        If CB7.Checked = True Then
            SortStr = SortStr & "CODE_GOODS "
            If CB77.Checked = True Then
                SortStr = SortStr & "DESC,"
            Else
                SortStr = SortStr & ","
            End If
        End If
        If CB8.Checked = True Then
            SortStr = SortStr & "WORKTIME_BEGIN "
            If CB88.Checked = True Then
                SortStr = SortStr & "DESC,"
            Else
                SortStr = SortStr & ","
            End If
        End If
        If Len(Trim(SortStr)) > 0 Then
            SortStr = Mid(SortStr, 1, Len(SortStr) - 1)
        End If
        Me.Close()
    End Sub

    Private Sub btnCacel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCacel.Click
        SortStr = " "
        Me.Close()
    End Sub

    Private Sub CB1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB1.CheckedChanged
        If CB1.Checked = True Then
            CB10.Checked = True
            CB11.Checked = False
        Else
            CB10.Checked = False
            CB11.Checked = False
        End If
    End Sub

    Private Sub CB10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB10.CheckedChanged
        If CB10.Checked = True Then
            CB11.Checked = False
        End If
    End Sub

    Private Sub CB11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB11.CheckedChanged
        If CB11.Checked = True Then
            CB10.Checked = False
        End If
    End Sub

    Private Sub CB2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB2.CheckedChanged
        If CB2.Checked = True Then
            CB20.Checked = True
            CB22.Checked = False
        Else
            CB20.Checked = False
            CB22.Checked = False
        End If
    End Sub

    Private Sub CB20_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB20.CheckedChanged
        If CB20.Checked = True Then
            CB22.Checked = False
        End If
    End Sub

    Private Sub CB22_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB22.CheckedChanged
        If CB22.Checked = True Then
            CB20.Checked = False
        End If
    End Sub

    Private Sub CB3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB3.CheckedChanged
        If CB3.Checked = True Then
            CB30.Checked = True
            CB33.Checked = False
        Else
            CB30.Checked = False
            CB33.Checked = False
        End If
    End Sub

    Private Sub CB30_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB30.CheckedChanged
        If CB30.Checked = True Then
            CB33.Checked = False
        End If
    End Sub

    Private Sub CB33_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB33.CheckedChanged
        If CB33.Checked = True Then
            CB30.Checked = False
        End If
    End Sub

    Private Sub CB4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB4.CheckedChanged
        If CB4.Checked = True Then
            CB40.Checked = True
            CB44.Checked = False
        Else
            CB40.Checked = False
            CB44.Checked = False
        End If
    End Sub

    Private Sub CB40_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB40.CheckedChanged
        If CB40.Checked = True Then
            CB44.Checked = False
        End If
    End Sub

    Private Sub CB44_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB44.CheckedChanged
        If CB44.Checked = True Then
            CB40.Checked = False
        End If
    End Sub

    Private Sub CB5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB5.CheckedChanged
        If CB5.Checked = True Then
            CB50.Checked = True
            CB55.Checked = False
        Else
            CB50.Checked = False
            CB55.Checked = False
        End If
    End Sub

    Private Sub CB50_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB50.CheckedChanged
        If CB50.Checked = True Then
            CB55.Checked = False
        End If
    End Sub

    Private Sub CB55_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB55.CheckedChanged
        If CB55.Checked = True Then
            CB50.Checked = False
        End If
    End Sub

    Private Sub CB6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB6.CheckedChanged
        If CB6.Checked = True Then
            CB60.Checked = True
            CB66.Checked = False
        Else
            CB60.Checked = False
            CB66.Checked = False
        End If
    End Sub

    Private Sub CB60_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB60.CheckedChanged
        If CB60.Checked = True Then
            CB66.Checked = False
        End If
    End Sub

    Private Sub CB66_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB66.CheckedChanged
        If CB66.Checked = True Then
            CB60.Checked = False
        End If
    End Sub

    Private Sub CB7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB7.CheckedChanged
        If CB7.Checked = True Then
            CB70.Checked = True
            CB77.Checked = False
        Else
            CB70.Checked = False
            CB77.Checked = False
        End If
    End Sub

    Private Sub CB70_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB70.CheckedChanged
        If CB70.Checked = True Then
            CB77.Checked = False
        End If
    End Sub

    Private Sub CB77_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB77.CheckedChanged
        If CB77.Checked = True Then
            CB70.Checked = False
        End If
    End Sub

    Private Sub CB8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB8.CheckedChanged
        If CB8.Checked = True Then
            CB80.Checked = True
            CB88.Checked = False
        Else
            CB80.Checked = False
            CB88.Checked = False
        End If
    End Sub

    Private Sub CB80_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB80.CheckedChanged
        If CB80.Checked = True Then
            CB88.Checked = False
        End If
    End Sub

    Private Sub CB88_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB88.CheckedChanged
        If CB88.Checked = True Then
            CB80.Checked = False
        End If
    End Sub
End Class
