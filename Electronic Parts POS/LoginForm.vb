Imports MySql.Data.MySqlClient

Public Class LoginForm1

    Public Shared server_address As String = vbNullString
    Public Shared server_port As String = vbNullString
    Public Shared schema_name As String = vbNullString
    Public Shared user_name As String = vbNullString
    Public Shared pass_word As String = vbNullString
    Public Shared mysql_bin As String = vbNullString
    Public Shared authentication As String = vbNullString
    Public Shared user_info As String = vbNullString
    Public Shared user_level As String = vbNullString
    Public Shared user_id As String = vbNullString
    Public Shared contact_no As String = vbNullString
    Public Shared log As String
    Dim connection As New MySqlConnection

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If Not connected() Then
            Dim ans As String
            ans = MsgBox("Error Connection, Would you like to configure database settings? ", vbYesNo)
            If ans = vbYes Then
                Me.Enabled = False
                frm_adminPass.Show()
            End If
        Else
            If txt_user.Text = "ctrl_admin" And txt_pass.Text = authentication Then
                Me.Enabled = False
                frm_dbSettings.Show()
            Else
                If validCredential(txt_user.Text, txt_pass.Text) Then
                    If user_level = "admin" Then
                        MsgBox("Welcome Admin: " & user_id, MsgBoxStyle.Information)
                    Else
                        MsgBox("Welcome User: " & user_id, MsgBoxStyle.Information)
                    End If
                    txt_pass.Text = ""
                    log = log & vbNewLine & DateTime.Now.ToString & " : " & "User " & user_id & " Logged in"
                    Me.Hide()
                    frm_welcome.Show()
                Else
                    MsgBox("Invalid Credentials!")
                End If
            End If
        End If
    End Sub

    Private Function validCredential(user As String, pass As String) As Boolean
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim querry As String

        dbConnect()
        Try
            connection.Open()
            querry = "select * from accounts where user_name='" & user & "' and user_pass='" & pass & "'"
            command = New MySqlCommand(querry, connection)
            reader = command.ExecuteReader()
            If reader.Read() Then
                user_info = reader("user_fullName")
                user_level = reader("user_control")
                user_id = reader("user_id")
                contact_no = reader("user_contactNo")
                Return True
            Else
                Return False
            End If
            reader.Close()
        Catch ex As Exception
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Function connected() As Boolean
        dbConnect()
        sslb_status.Text = "Connecting..."
        Try
            connection.Open()
            sslb_status.Text = "Connected"
            connection.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub dbConnect()
        Dim conString As String = "server=" & server_address & "; port=" & server_port & "; userId=" & user_name & "; password=" & pass_word & "; database=" & schema_name & ";"
        connection.ConnectionString = conString
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not connected() Then
            sslb_status.Text = "Connection Falied"
        End If
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conString As String
        conString = DatabaseEncryption.readFileBase64
        If Not conString = vbNullString Then
            Dim arrstr() = conString.Split(vbNewLine)
            server_address = arrstr(0).Replace(vbNewLine, "").Replace(vbLf, "")
            server_port = arrstr(1).Replace(vbNewLine, "").Replace(vbLf, "")
            schema_name = arrstr(2).Replace(vbNewLine, "").Replace(vbLf, "")
            user_name = arrstr(3).Replace(vbNewLine, "").Replace(vbLf, "")
            pass_word = arrstr(4).Replace(vbNewLine, "").Replace(vbLf, "")
            mysql_bin = arrstr(5).Replace(vbNewLine, "").Replace(vbLf, "")
            authentication = arrstr(6).Replace(vbNewLine, "").Replace(vbLf, "")
        End If
        If Not connected() Then
            Dim ans As String
            ans = MsgBox("Error Connection, Would you like to configure database settings? ", vbYesNo)
            If ans = vbYes Then
                Me.Enabled = False
                frm_adminPass.Show()
            End If
        End If
    End Sub
End Class
