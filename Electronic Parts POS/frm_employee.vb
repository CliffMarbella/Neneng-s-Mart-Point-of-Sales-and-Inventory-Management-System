Public Class frm_employee

    Dim selected As String

    Private Sub frm_employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbx_views.SelectedIndex = 0
        fill_dgv_account()
    End Sub

    Public Sub fill_dgv_account()
        Dim query As String
        query = "select user_id as 'User ID', user_control as 'Access Type', user_fullName as 'Full Name', user_contactNo as 'Contact No.' from  db_pos.accounts"
        PosFunction.fill_dgv(dgv_account, query)
        resizeColumn()
    End Sub

    Public Sub resizeColumn()
        Dim idClmn, controlClmn, NoClmn As DataGridViewColumn
        idClmn = dgv_account.Columns(0)
        controlClmn = dgv_account.Columns(1)
        NoClmn = dgv_account.Columns(3)
        dgv_account.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_account.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_account.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        idClmn.Width = 180
        controlClmn.Width = 180
        NoClmn.Width = 250
    End Sub

    Private Sub dgv_account_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_account.RowEnter
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgv_account.Rows(e.RowIndex)
            lbl_name.Text = "Name : " & row.Cells("Full Name").Value.ToString
            selected = row.Cells("User ID").Value.ToString
            If row.Cells("Access Type").Value.ToString.Equals("admin") Then
                lbl_user.Text = "Admin : " & row.Cells("User ID").Value.ToString
            Else
                lbl_user.Text = "User : " & row.Cells("User ID").Value.ToString
            End If
        End If
    End Sub

    Private Sub cbx_views_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbx_views.SelectionChangeCommitted
        Dim query As String
        If cbx_views.SelectedIndex = 0 Then
            query = "select user_id as 'User ID', user_control as 'Access Type', user_fullName as 'Full Name', user_contactNo as 'Contact No.' from  db_pos.accounts"
        ElseIf cbx_views.SelectedIndex = 1 Then
            query = "select user_id as 'User ID', user_control as 'Access Type', user_fullName as 'Full Name', user_contactNo as 'Contact No.' from  db_pos.accounts where user_control = 'admin'"
        Else
            query = "select user_id as 'User ID', user_control as 'Access Type', user_fullName as 'Full Name', user_contactNo as 'Contact No.' from  db_pos.accounts where user_control = 'user'"
        End If
        PosFunction.fill_dgv(dgv_account, query)
        resizeColumn()
    End Sub

    Private Sub txt_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_id.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If frm_main.connected Then
            If Not String.IsNullOrWhiteSpace(txt_id.Text) Then
                Dim query As String
                query = "select user_id as 'User ID', user_control as 'Access Type', user_fullName as 'Full Name', user_contactNo as 'Contact No.' from  db_pos.accounts where user_id = '" & txt_id.Text & "'"
                PosFunction.fill_dgv(dgv_account, query)
                resizeColumn()
            End If
        End If
    End Sub

    Private Sub txt_id_TextChanged(sender As Object, e As EventArgs) Handles txt_id.TextChanged
        If String.IsNullOrWhiteSpace(txt_id.Text) Then
            fill_dgv_account()
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If frm_main.connected Then
            If LoginForm1.user_level.Equals("admin") Then
                Dim obj As New frm_account
                obj.toDo = "create"
                obj.admin = False
                obj.ShowDialog()
                If frm_account.success Then
                    fill_dgv_account()
                End If
            Else
                MsgBox("Administrator Priviledges Required")
            End If
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If frm_main.connected Then
            If PosFunction.getElement("accounts", "user_id", selected, "user_control").Equals("user") Then
                Dim obj As New frm_account
                obj.toDo = "edit"
                obj.id = selected
                obj.ShowDialog()
                If frm_account.success Then
                    fill_dgv_account()
                End If
            Else
                MsgBox("Administrator Priviledges Required")
            End If
        End If
    End Sub

    Private Sub archiveUser()
        Dim query As String
        query = "insert into db_pos.account_archive (user_id, user_name, user_pass, user_control, user_fullName, user_contactNo) values ('" & selected & "', '" & PosFunction.getElement("accounts", "user_id", selected, "user_name") & "', '" & PosFunction.getElement("accounts", "user_id", selected, "user_pass") & "', 'user', '" & PosFunction.getElement("accounts", "user_id", selected, "user_fullName") & "', '" & PosFunction.getElement("accounts", "user_id", selected, "user_contactNo") & "')"
        PosFunction.alterTable(query)
        If PosFunction.alterSuccess Then
            query = "insert into db_pos.name_archive (name_id, user_id, first_name, middle_name, last_name) values ('" & PosFunction.getElement("names", "user_id", selected, "name_id") & "', '" & selected & "', '" & PosFunction.getElement("names", "user_id", selected, "first_name") & "', '" & PosFunction.getElement("names", "user_id", selected, "middle_name") & "', '" & PosFunction.getElement("names", "user_id", selected, "last_name") & "')"
            PosFunction.alterTable(query)
            If Not PosFunction.alterSuccess Then
                MsgBox(PosFunction.alterMessage)
            End If
        Else
            MsgBox(PosFunction.alterMessage)
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If frm_main.connected Then
            If PosFunction.getElement("accounts", "user_id", selected, "user_control").Equals("user") Then
                Dim ans = MsgBox("Delete User - " & selected & " ?", vbYesNo)
                If ans = vbYes Then
                    archiveUser()
                    Dim query As String = "delete from db_pos.accounts where user_id = '" & selected & "'"
                    PosFunction.alterTable(query)
                    If PosFunction.alterSuccess Then
                        query = "delete from db_pos.names where user_id = '" & selected & "'"
                        PosFunction.alterTable(query)
                        If PosFunction.alterSuccess Then
                            fill_dgv_account()
                            MsgBox("Successfully Deleted")
                        Else
                            MsgBox(PosFunction.alterMessage)
                        End If
                    Else
                        MsgBox(PosFunction.alterMessage)
                    End If
                End If
            Else
                MsgBox("Administrator Priviledges Required")
            End If
        End If
    End Sub
End Class