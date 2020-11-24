Public Class frm_settings

    Dim db_server, db_port, db_name, db_user, db_pass, mysql_bin, authentication, selected As String
    Public intInputBoxCancel As Integer

    Private Sub frm_settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tc_settings.SelectedIndex = 0
        intInputBoxCancel = frm_main.StrPtr(String.Empty)
        setConfig()
    End Sub

#Region "panels"

    Private Sub pnl_config_MouseEnter(sender As Object, e As EventArgs) Handles pnl_config.MouseEnter
        pnl_config.BackColor = SystemColors.Control
    End Sub

    Private Sub pnl_config_MouseLeave(sender As Object, e As EventArgs) Handles pnl_config.MouseLeave
        pnl_config.BackColor = SystemColors.Window
    End Sub

    Private Sub pnl_secSetting_MouseEnter(sender As Object, e As EventArgs) Handles pnl_secSetting.MouseEnter
        pnl_secSetting.BackColor = SystemColors.Control
    End Sub

    Private Sub pnl_secSetting_MouseLeave(sender As Object, e As EventArgs) Handles pnl_secSetting.MouseLeave
        pnl_secSetting.BackColor = SystemColors.Window
    End Sub

    Private Sub pnl_help_MouseEnter(sender As Object, e As EventArgs) Handles pnl_help.MouseEnter
        pnl_help.BackColor = SystemColors.Control
    End Sub

    Private Sub pnl_help_MouseLeave(sender As Object, e As EventArgs) Handles pnl_help.MouseLeave
        pnl_help.BackColor = SystemColors.Window
    End Sub

    Private Sub pnl_about_MouseEnter(sender As Object, e As EventArgs) Handles pnl_about.MouseEnter
        pnl_about.BackColor = SystemColors.Control
    End Sub

    Private Sub pnl_about_MouseLeave(sender As Object, e As EventArgs) Handles pnl_about.MouseLeave
        pnl_about.BackColor = SystemColors.Window
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        pnl_config.BackColor = SystemColors.Control
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        pnl_config.BackColor = SystemColors.Window
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        pnl_secSetting.BackColor = SystemColors.Control
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        pnl_secSetting.BackColor = SystemColors.Window
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        pnl_help.BackColor = SystemColors.Control
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        pnl_help.BackColor = SystemColors.Window
    End Sub

    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles Label5.MouseEnter
        pnl_about.BackColor = SystemColors.Control
    End Sub

    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave
        pnl_about.BackColor = SystemColors.Window
    End Sub
#End Region

#Region "panel functions"

    Private Sub pnl_config_Click(sender As Object, e As EventArgs) Handles pnl_config.Click
        tc_settings.SelectedIndex = 0
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        pnl_config_Click(sender, e)
    End Sub

    Private Sub pnl_secSetting_Click(sender As Object, e As EventArgs) Handles pnl_secSetting.Click
        tc_settings.SelectedIndex = 1
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        pnl_secSetting_Click(sender, e)
    End Sub

    Private Sub pnl_help_Click(sender As Object, e As EventArgs) Handles pnl_help.Click
        tc_settings.SelectedIndex = 2
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        pnl_help_Click(sender, e)
    End Sub

    Private Sub pnl_about_Click(sender As Object, e As EventArgs) Handles pnl_about.Click
        tc_settings.SelectedIndex = 3
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        pnl_about_Click(sender, e)
    End Sub

#End Region

#Region "tab load"

    Private Sub tc_settings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tc_settings.SelectedIndexChanged
        If tc_settings.SelectedIndex = 0 Then
            setConfig()
        ElseIf tc_settings.SelectedIndex = 1 Then
            fill_dgv_admin()
            If LoginForm1.authentication.Equals("041599") Then
                cbx_pin.SelectedIndex = 0
                pnl_pin.Enabled = False
                txt_pin.Text = vbNullString
                txt_confPin.Text = vbNullString
            Else
                cbx_pin.SelectedIndex = 1
                pnl_pin.Enabled = True
                txt_pin.UseSystemPasswordChar = True
                txt_confPin.UseSystemPasswordChar = True
                txt_pin.Text = LoginForm1.authentication
                txt_confPin.Text = LoginForm1.authentication
            End If
        End If
    End Sub

#End Region

#Region "for config"

    Private Sub btn_saveConfig_Click(sender As Object, e As EventArgs) Handles btn_saveConfig.Click
        Dim ans As String = MsgBox("Warning! changing system config might disconnect the system from database, do you wish to continue?", MsgBoxStyle.Exclamation + vbYesNo)
        If ans = vbYes Then
            db_server = txt_SA.Text
            db_port = txt_SP.Text
            db_name = txt_ScN.Text
            db_user = txt_UN.Text
            db_pass = txt_PW.Text
            mysql_bin = txt_MSSB.Text
            PosFunction.showAuthentication()
            If Not frm_pin.canceled Then
                If frm_pin.authenticated Then
                    If Not mysql_bin = vbNullString Then
                        Dim str As String
                        str = db_server & vbNewLine & db_port & vbNewLine & db_name & vbNewLine & db_user & vbNewLine & db_pass & vbNewLine & mysql_bin & vbNewLine & authentication
                        DatabaseEncryption.writeFileBase64(str, False)
                        ans = MsgBox("Config Succeessfully Updated, Restart Application ? ", vbYesNo + MsgBoxStyle.Information)
                        If ans = vbYes Then
                            Application.Restart()
                        End If
                    Else
                        MsgBox("Warning: By leaving Mysql Server bin empty you will not be able to use some features such as database import and export", MsgBoxStyle.Critical)
                    End If
                Else
                    MsgBox("Incorrect Authentication Pin", MsgBoxStyle.Exclamation)
                End If
            End If
        End If
    End Sub

    Private Sub setConfig()
        txt_SA.Text = LoginForm1.server_address
        txt_SP.Text = LoginForm1.server_port
        txt_ScN.Text = LoginForm1.schema_name
        txt_UN.Text = LoginForm1.user_name
        txt_PW.Text = LoginForm1.pass_word
        txt_MSSB.Text = LoginForm1.mysql_bin
        authentication = LoginForm1.authentication
    End Sub

    Private Sub btn_backup_Click(sender As Object, e As EventArgs) Handles btn_backup.Click
        PosFunction.showAuthentication()
        If Not frm_pin.canceled Then
            If frm_pin.authenticated Then
                SystemFunction.ExportFolder(sfd_backup)
            Else
                MsgBox("Incorrect Authentication Pin", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub sfd_backup_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles sfd_backup.FileOk
        SystemFunction.ExportDatabase(sfd_backup.FileName)
    End Sub

    Private Sub btn_ffd_Click(sender As Object, e As EventArgs) Handles btn_ffd.Click
        FolderBrowserDialog.ShowDialog()
        txt_MSSB.Text = FolderBrowserDialog.SelectedPath
    End Sub

    Private Sub btn_restore_Click(sender As Object, e As EventArgs) Handles btn_restore.Click
        PosFunction.showAuthentication()
        If Not frm_pin.canceled Then
            If frm_pin.authenticated Then
                SystemFunction.ImportFolder(ofd_restore)
            Else
                MsgBox("Incorrect Authentication Pin", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub ofd_restore_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofd_restore.FileOk
        Dim m As Integer = MsgBox("Do you want to create restore point?", MsgBoxStyle.YesNo, "Data Import")
        If m = DialogResult.Yes Then
            Dim fileName As String = "DataExport-" & DateTime.Now.ToString("MM-dd-yyyy") + ".sql"
            SystemFunction.ExportDatabase(SystemFunction.filePath & "\" & "POS Database" & "\" & fileName)
        End If
        SystemFunction.ImportDatabase(ofd_restore.FileName)
    End Sub
#End Region

#Region "for security settings"

    Private Sub fill_dgv_admin()
        PosFunction.fill_dgv(dgv_adminAcc, "select user_id as 'ID', user_fullName as 'Name' from db_pos.accounts where user_control = 'admin'")
        Dim id As New DataGridViewColumn
        id = dgv_adminAcc.Columns(0)
        dgv_adminAcc.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        id.Width = 80
    End Sub

    Private Sub dgv_adminAcc_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_adminAcc.RowEnter
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgv_adminAcc.Rows(e.RowIndex)
            selected = row.Cells("ID").Value.ToString
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        PosFunction.showAuthentication()
        If Not frm_pin.canceled Then
            If frm_pin.authenticated Then
                Dim obj As New frm_account
                obj.toDo = "create"
                obj.admin = True
                obj.ShowDialog()
                If frm_account.success Then
                    fill_dgv_admin()
                End If
            Else
                MsgBox("Incorrect Authentication Pin", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        PosFunction.showAuthentication()
        If Not frm_pin.canceled Then
            If frm_pin.authenticated Then
                Dim obj As New frm_account
                obj.toDo = "edit"
                obj.id = selected
                obj.ShowDialog()
                If frm_account.success Then
                    fill_dgv_admin()
                End If
            Else
                MsgBox("Incorrect Authentication Pin", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim ans As String = MsgBox("Delete Admin - " & selected & " ?", vbYesNo)
        If ans = vbYes Then
            PosFunction.showAuthentication()
            If Not frm_pin.canceled Then
                If frm_pin.authenticated Then
                    Dim query As String
                    query = "delete from db_pos.accounts where user_id = '" & selected & "'"
                    PosFunction.alterTable(query)
                    If PosFunction.alterSuccess Then
                        MsgBox("Successfully deleted")
                        fill_dgv_admin()
                    Else
                        MsgBox("Delete Failed! Additional Info : " & PosFunction.alterMessage)
                    End If
                Else
                    MsgBox("Incorrect Authentication Pin", MsgBoxStyle.Exclamation)
                End If
            End If
        End If
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If Not String.IsNullOrWhiteSpace(txt_id.Text) Then
            Dim query As String
            query = "Select user_id As 'ID', user_fullName as 'Name' from db_pos.accounts where user_control = 'admin' and user_id = '" & txt_id.Text & "'"
            PosFunction.fill_dgv(dgv_adminAcc, query)
            Dim id As New DataGridViewColumn
            id = dgv_adminAcc.Columns(0)
            dgv_adminAcc.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            id.Width = 80
        End If
    End Sub

    Private Sub txt_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_id.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_id_TextChanged(sender As Object, e As EventArgs) Handles txt_id.TextChanged
        If String.IsNullOrWhiteSpace(txt_id.Text) Then
            fill_dgv_admin()
        End If
    End Sub

    Private Sub btn_archive_Click(sender As Object, e As EventArgs) Handles btn_archive.Click
        frm_accountArchive.TopMost = True
        frm_accountArchive.Show()
    End Sub

    Private Sub btn_audit_Click(sender As Object, e As EventArgs) Handles btn_audit.Click
        frm_trail.Show()
    End Sub

    Private Sub cbx_pin_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbx_pin.SelectionChangeCommitted
        If cbx_pin.SelectedIndex = 0 Then
            changePin("041599")
            txt_pin.Text = vbNullString
            txt_confPin.Text = vbNullString
            pnl_pin.Enabled = False
        Else
            pnl_pin.Enabled = True
        End If
    End Sub

    Private Sub changePin(pin As String)
        Dim str As String
        str = LoginForm1.server_address & vbNewLine & LoginForm1.server_port & vbNewLine & LoginForm1.schema_name & vbNewLine & LoginForm1.user_name & vbNewLine & LoginForm1.pass_word & vbNewLine & LoginForm1.mysql_bin & vbNewLine & pin
        DatabaseEncryption.writeFileBase64(str, False)
        LoginForm1.authentication = pin
    End Sub

    Private Sub btn_secSave_Click(sender As Object, e As EventArgs) Handles btn_secSave.Click
        If Not String.IsNullOrWhiteSpace(txt_pin.Text) And Not String.IsNullOrWhiteSpace(txt_confPin.Text) Then
            If Not CInt(txt_pin.Text.Length) < 5 Then
                If txt_pin.Text.Equals(txt_confPin.Text) Then
                    changePin(txt_pin.Text)
                    MsgBox("Pin Updated", MsgBoxStyle.Information)
                Else
                    lbl_error.Text = "Pin doesn't match"
                    lbl_error.ForeColor = Color.Red
                End If
            Else
                lbl_error.Text = "Enter more than 5 digit pin"
                lbl_error.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub txt_pin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pin.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_pin_Enter(sender As Object, e As EventArgs) Handles txt_pin.Enter
        lbl_error.ForeColor = SystemColors.Control
        lbl_error.Text = vbNullString
    End Sub

    Private Sub txt_confPin_Enter(sender As Object, e As EventArgs) Handles txt_confPin.Enter
        lbl_error.ForeColor = SystemColors.Control
        lbl_error.Text = vbNullString
    End Sub

    Private Sub pb_pass_Click(sender As Object, e As EventArgs) Handles pb_pass.Click
        If txt_pin.UseSystemPasswordChar Then
            txt_pin.UseSystemPasswordChar = False
            txt_confPin.UseSystemPasswordChar = False
        Else
            txt_pin.UseSystemPasswordChar = True
            txt_confPin.UseSystemPasswordChar = True
        End If
    End Sub
#End Region

End Class