Imports MySql.Data.MySqlClient

Public Class frm_dbSettings

    Public Shared db_server, db_port, db_name, db_user, db_pass, mysql_bin, authentication As String

    Private Sub btn_ffd_Click(sender As Object, e As EventArgs) Handles btn_ffd.Click
        FolderBrowserDialog.ShowDialog()
        txt_MSSB.Text = FolderBrowserDialog.SelectedPath
    End Sub

    Private Sub frm_dbSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_SA.Text = LoginForm1.server_address
        txt_SP.Text = LoginForm1.server_port
        txt_ScN.Text = LoginForm1.schema_name
        txt_UN.Text = LoginForm1.user_name
        txt_PW.Text = LoginForm1.pass_word
        txt_MSSB.Text = LoginForm1.mysql_bin
        If Not String.IsNullOrWhiteSpace(LoginForm1.authentication) Then
            authentication = LoginForm1.authentication
        Else
            authentication = "041599"
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub frm_adminPass_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        LoginForm1.Enabled = True
    End Sub

    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_connect.Click
        db_server = txt_SA.Text
        db_port = txt_SP.Text
        db_name = txt_ScN.Text
        db_user = txt_UN.Text
        db_pass = txt_PW.Text
        mysql_bin = txt_MSSB.Text
        If Not mysql_bin = vbNullString Then
            If connect() Then
                Dim str As String
                str = db_server & vbNewLine & db_port & vbNewLine & db_name & vbNewLine & db_user & vbNewLine & db_pass & vbNewLine & mysql_bin & vbNewLine & authentication
                DatabaseEncryption.writeFileBase64(str, False)
                LoginForm1.server_address = db_server
                LoginForm1.server_port = db_port
                LoginForm1.schema_name = db_name
                LoginForm1.user_name = db_user
                LoginForm1.pass_word = db_pass
                LoginForm1.mysql_bin = mysql_bin
                LoginForm1.authentication = authentication
                MsgBox("Successfully Connected!")
            Else
                MsgBox("Connection Failed!")
            End If
        Else
            MsgBox("Warning: By leaving Mysql Server bin empty you will not be able to use some features such as database import and export", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Function connect() As Boolean
        Dim connection As New MySqlConnection
        Dim conString As String = "server=" & db_server & "; port=" & db_port & "; userId=" & db_user & "; password=" & db_pass & "; database=" & db_name & ";"
        connection.ConnectionString = conString
        Try
            connection.Open()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class