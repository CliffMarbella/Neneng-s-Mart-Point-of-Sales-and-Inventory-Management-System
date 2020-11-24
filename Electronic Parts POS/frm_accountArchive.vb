Public Class frm_accountArchive

    Dim selected As String

    Private Sub frm_accountArchive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fill_dgv()
    End Sub

    Private Sub fill_dgv()
        Dim query As String
        query = "select user_id as 'User ID', user_name as 'User Name', user_control as 'Control' from db_pos.account_archive"
        PosFunction.fill_dgv(dgv_account, query)
    End Sub

    Private Sub dgv_account_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_account.RowEnter
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgv_account.Rows(e.RowIndex)
            selected = row.Cells("User ID").Value.ToString
        End If
    End Sub

    Private Sub btn_restore_Click(sender As Object, e As EventArgs) Handles btn_restore.Click
        Dim query As String
        If PosFunction.noMatchFound("select * from db_pos.accounts where user_id = '" & selected & "'") Then
            Dim user_name, user_pass, user_control, user_fullName, user_contactNo As String
            user_name = PosFunction.getElement("account_archive", "user_id", selected, "user_name")
            user_pass = PosFunction.getElement("account_archive", "user_id", selected, "user_pass")
            user_control = PosFunction.getElement("account_archive", "user_id", selected, "user_control")
            user_fullName = PosFunction.getElement("account_archive", "user_id", selected, "user_fullName")
            user_contactNo = PosFunction.getElement("account_archive", "user_id", selected, "user_contactNo")
            query = "insert into db_pos.accounts (user_id, user_name, user_pass, user_control, user_fullName, user_contactNo)
                            values ('" & selected & "', '" & user_name & "', '" & user_pass & "', '" & user_control & "', '" & user_fullName & "',
                            '" & user_contactNo & "')"
            PosFunction.alterTable(query)
            If PosFunction.alterSuccess Then
                Dim name_id, first_name, middle_name, last_name As String
                name_id = PosFunction.getElement("name_archive", "user_id", selected, "name_id")
                first_name = PosFunction.getElement("name_archive", "user_id", selected, "first_name")
                middle_name = PosFunction.getElement("name_archive", "user_id", selected, "middle_name")
                last_name = PosFunction.getElement("name_archive", "user_id", selected, "last_name")
                query = "insert into db_pos.names (name_id, user_id, first_name, middle_name, last_name) values ('" & name_id & "', 
                                '" & selected & "', '" & first_name & "', '" & middle_name & "', '" & last_name & "')"
                PosFunction.alterTable(query)
                If PosFunction.alterSuccess Then
                    query = "delete from db_pos.account_archive where user_id = '" & selected & "'"
                    PosFunction.alterTable(query)
                    query = "delete from db_pos.name_archive where user_id = '" & selected & "'"
                    PosFunction.alterTable(query)
                    fill_dgv()
                    MsgBox("Successfully Restored!", MsgBoxStyle.Information)
                Else
                    MsgBox(PosFunction.alterMessage)
                End If
            Else
                MsgBox(PosFunction.alterMessage)
            End If
        Else
            MsgBox("Restoration Failed: the same user id already exist in the database!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        Dim ans = MsgBox("This account will be permanently deleted, Do you want to continue?", vbYesNo + MsgBoxStyle.Exclamation)
        If ans = vbYes Then
            Dim query As String
            query = "delete from db_pos.account_archive where user_id = '" & selected & "'"
            PosFunction.alterTable(query)
            If PosFunction.alterSuccess Then
                query = "delete from db_pos.name_archive where user_id = '" & selected & "'"
                PosFunction.alterTable(query)
                If PosFunction.alterSuccess Then
                    fill_dgv()
                    MsgBox("Account deleted", MsgBoxStyle.Information)
                Else
                    MsgBox(PosFunction.alterMessage)
                End If
            Else
                MsgBox(PosFunction.alterMessage)
            End If
        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()
    End Sub
End Class