Imports System.IO
Imports System.Security.AccessControl

Public Class DatabaseEncryption

    Shared folder As String = "POS"
    Shared filePath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\" & folder
    Shared fileName As String = "PosConfig"
    Shared saveType As String = ".cfg"

    Public Shared Sub createFolder()
        If Not Directory.Exists(filePath) Then
            Dim sr As New DirectorySecurity
            sr.SetAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Allow))
            Dim di As DirectoryInfo = Directory.CreateDirectory(filePath, sr)
        End If
    End Sub

    Public Shared Sub writeFileBase64(str As String, append As Boolean)
        Dim tobytes = System.Text.Encoding.UTF8.GetBytes(str)
        Dim saveString = System.Convert.ToBase64String(tobytes)
        Dim pathString = filePath & "\" & fileName & saveType
        Dim file As System.IO.FileStream

        If Not System.IO.File.Exists(pathString) Then
            createFolder()
            Try
                file = System.IO.File.Create(pathString)
                file.Close()
            Catch e As Exception
                MsgBox("File write error! Error code: " & e.Message, MsgBoxStyle.Critical)
            End Try
        End If
        Try
            My.Computer.FileSystem.WriteAllText(pathString, saveString, append)
        Catch e As Exception
            MsgBox("File write error! Error code: " & e.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Shared Function readFileBase64()
        Dim savestring As String
        Dim pathString = filePath & "\" & fileName & saveType

        Try
            If System.IO.File.Exists(pathString) = True Then
                Dim fromtext = My.Computer.FileSystem.ReadAllText(pathString)
                Dim frombyte = System.Convert.FromBase64String(fromtext)
                savestring = System.Text.ASCIIEncoding.ASCII.GetString(frombyte)
                Return savestring
            End If
        Catch e As Exception
            MsgBox("File read error! Error code: " & e.Message, MsgBoxStyle.Critical)
        End Try
        Return vbNullString
    End Function
End Class
