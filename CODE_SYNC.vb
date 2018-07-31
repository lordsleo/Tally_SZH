Imports TALLY.DBControl

Public Class CODE_SYNC

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            sync_port()
            sync_pack()
            sync_nation()

            MsgBox("代码同步成功！")
        Catch ex As Exception
            MsgBox("代码同步异常！")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub sync_port()
        ExecSql("insert into tally_szh..code_port select * from code_port where code_port not in (select code_port from tally_szh..code_port)")
    End Sub

    Private Sub sync_pack()
        ExecSql("insert into tally_szh..code_pack select * from code_pack where code_pack not in (select code_pack from tally_szh..code_pack)")
    End Sub

    Private Sub sync_nation()
        ExecSql("insert into tally_szh..code_nationality select * from code_nationality where nationality_eng not in (select nationality_eng from tally_szh..code_nationality)")
    End Sub


End Class