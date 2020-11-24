Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Security.AccessControl
Imports System.Text

Public Class SystemFunction

    Public Shared connection As New MySqlConnection
    Public Shared filePath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Public Shared mysqlPath As String

    Private Shared Sub dbConnect()
        Dim conString As String = "server=" & LoginForm1.server_address & "; port=" & LoginForm1.server_port & "; userId=" & LoginForm1.user_name & "; password=" & LoginForm1.pass_word & "; database=" & LoginForm1.schema_name & ";"
        connection.ConnectionString = conString
    End Sub

    Public Shared Sub checkCreateFolder(path As String)
        If Not Directory.Exists(path) Then
            Dim sr As New DirectorySecurity
            sr.SetAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Allow))
            Dim di As DirectoryInfo = Directory.CreateDirectory(path, sr)
        End If
    End Sub

#Region "For Export Database"

    Public Shared Sub ExportFolder(sDialog As SaveFileDialog)
        Dim path = filePath & "\" & "POS Database"
        checkCreateFolder(path)
        sDialog.Filter = "SQL Dump file (*.sql)|*.sql|All files (*.*)|*.*"
        sDialog.InitialDirectory = path
        sDialog.FileName = "DataExport-" & DateTime.Now.ToString("MM-dd-yyyy") + ".sql"
        sDialog.ShowDialog()
    End Sub

    Public Shared Sub ExportDatabase(filename As String)
        mysqlPath = LoginForm1.mysql_bin
        If Not mysqlPath = vbNullString Then
            dbConnect()
            Try
                connection.Open()
                Dim dbFileName As String = filename
                Dim exportProcess As New Process
                exportProcess.StartInfo.FileName = "cmd.exe"
                exportProcess.StartInfo.UseShellExecute = False
                exportProcess.StartInfo.WorkingDirectory = mysqlPath
                exportProcess.StartInfo.RedirectStandardInput = True
                exportProcess.StartInfo.RedirectStandardOutput = True
                exportProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                exportProcess.StartInfo.CreateNoWindow = True
                exportProcess.Start()
                Dim exportStream As StreamWriter = exportProcess.StandardInput
                Dim streamReader As StreamReader = exportProcess.StandardOutput
                Dim str = "mysqldump --user=" & LoginForm1.user_name & " --password=" & LoginForm1.pass_word & " -h " & LoginForm1.server_address & " " & LoginForm1.schema_name & " > """ & dbFileName & """"
                exportStream.WriteLine(str)
                exportStream.Close()
                exportProcess.WaitForExit()
                exportProcess.Close()
                MsgBox("Database backup successful", MsgBoxStyle.Information, "Database Backup")
            Catch ex As Exception
                MsgBox("Export Database: Error " & ex.Message)
            Finally
                connection.Close()
            End Try
        Else
            MsgBox("Error: MySql bin path has not been set " & vbCrLf & "Additional info: login as ctr_admin and set mySql bin path", MsgBoxStyle.Exclamation, "Error 404 Mysql bin path not found")
        End If
    End Sub
#End Region

#Region "For Import Database"
    Public Shared Sub ImportFolder(ofd As OpenFileDialog)
        Dim path = filePath
        checkCreateFolder(path)
        ofd.Filter = "SQL Dump file (*.sql)|*.sql|All files (*.*)|*.*"
        ofd.InitialDirectory = path
        ofd.ShowDialog()
    End Sub

    Public Shared Sub ImportDatabase(filename As String)
        mysqlPath = LoginForm1.mysql_bin
        If Not mysqlPath = vbNullString Then
            dbConnect()
            Try
                connection.Open()
                Dim dbFileName As String = filename
                Dim importProcess As New Process
                importProcess.StartInfo.FileName = "cmd.exe"
                importProcess.StartInfo.UseShellExecute = False
                importProcess.StartInfo.WorkingDirectory = mysqlPath
                importProcess.StartInfo.RedirectStandardInput = True
                importProcess.StartInfo.RedirectStandardOutput = True
                importProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                importProcess.StartInfo.CreateNoWindow = True
                importProcess.Start()
                Dim exportStream As StreamWriter = importProcess.StandardInput
                Dim streamReader As StreamReader = importProcess.StandardOutput
                createDBRegistrar(connection)
                Dim str = "mysql --user=" & LoginForm1.user_name & " --password=" & LoginForm1.pass_word & " -h " & LoginForm1.server_address & " " & LoginForm1.schema_name & " < """ & dbFileName & """"
                exportStream.WriteLine(str)
                exportStream.Close()
                importProcess.WaitForExit()
                importProcess.Close()
                MsgBox("Database Restore successful", MsgBoxStyle.Information, "Database Restore")
            Catch ex As Exception
                MsgBox("Import Database: Error " & ex.Message)
            Finally
                connection.Close()
            End Try
        Else
            MsgBox("Error: MySql bin path has not been set " & vbCrLf & "Additional info: login as ctr_admin and set mySql bin path", MsgBoxStyle.Exclamation, "Error 404 Mysql bin path not found")
        End If
    End Sub

    Public Shared Sub createDBRegistrar(connection As MySqlConnection)
        Try
            Dim reader As MySqlDataReader
            Dim str As String
            str = "CREATE SCHEMA " & LoginForm1.schema_name & ";"
            Dim Command As New MySqlCommand(str, connection)
            reader = Command.ExecuteReader
            reader.Close()
        Catch ex As MySqlException
            ''if db_registrar already exist then do not create another this catch has no function no error either
        End Try
    End Sub
#End Region

End Class
