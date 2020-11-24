Imports System.Text.RegularExpressions

Public Class frm_account

    Public Property toDo As String
    Public Property id As String
    Public Property admin As Boolean
    Public Shared success As Boolean
    Private Sub frm_account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        success = False
        resetErrorcode()
        If toDo.Equals("create") Then
            lbl_user.Text = "Create Account"
            btn_ok.Text = "Create"
        ElseIf toDo.Equals("edit") Then
            lbl_user.Text = "User - " & id
            btn_ok.Text = "Save"
            txt_fname.Text = PosFunction.getElement("names", "user_id", id, "first_name")
            txt_lname.Text = PosFunction.getElement("names", "user_id", id, "last_name")
            txt_mname.Text = PosFunction.getElement("names", "user_id", id, "middle_name")
            txt_cNo.Text = PosFunction.getElement("accounts", "user_id", id, "user_contactNo")
            txt_user.Text = PosFunction.getElement("accounts", "user_id", id, "user_name")
            txt_pass.Text = PosFunction.getElement("accounts", "user_id", id, "user_pass")
            txt_cpass.Text = PosFunction.getElement("accounts", "user_id", id, "user_pass")
        End If
    End Sub

    Private Sub resetErrorcode()
        lbl_noError.ForeColor = SystemColors.GradientActiveCaption
        lbl_userError.ForeColor = SystemColors.GradientActiveCaption
        lbl_pwError.ForeColor = SystemColors.GradientActiveCaption
    End Sub

    Private Function getMI(str As String) As Char
        Dim arr = str.ToCharArray
        Return upperCase(arr(0))
    End Function

    Private Function upperCase(str As String) As String
        Dim arr() = str.ToCharArray
        arr(0) = Char.ToUpper(arr(0))
        Return New String(arr)
    End Function

    Private Function validNo(str As String) As Boolean
        Dim arr() = str.ToCharArray
        Dim c1, c2 As String
        c1 = arr(0).ToString
        c2 = arr(1).ToString
        If CInt(c1) <> 0 Or CInt(c2) <> 9 Or arr.Length <> 11 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function noSpecialChar(str As String) As Boolean
        Dim regexItem As Regex = New Regex("^[a-zA-Z0-9 ]*$")
        If regexItem.IsMatch(str) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function lessThan15Char(str As String) As Boolean
        Dim arr() = str.ToCharArray
        If arr.Length <= 15 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function moreThan5char(str As String) As Boolean
        Dim arr = str.ToCharArray
        If arr.Length >= 5 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function validUser(user As String) As Boolean
        If noSpecialChar(user) Then
            If lessThan15Char(user) Then
                If moreThan5char(user) Then
                    If toDo.Equals("create") Then
                        If PosFunction.noMatchFound("select * from db_pos.accounts where user_name = '" & user & "'") Then
                            Return True
                        Else
                            lbl_userError.Text = "Username already taken!"
                            lbl_userError.ForeColor = Color.Red
                            Return False
                        End If
                    ElseIf toDo.Equals("edit") Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    lbl_userError.Text = "Enter atleast 5 characters user"
                    lbl_userError.ForeColor = Color.Red
                    Return False
                End If
            Else
                lbl_userError.Text = "Username can't be more than 15 characters!"
                lbl_userError.ForeColor = Color.Red
                Return False
            End If
        Else
            lbl_userError.Text = "Username can't contain special characters!"
            lbl_userError.ForeColor = Color.Red
            Return False
        End If
    End Function

    Private Function validPass(pass As String) As Boolean
        If lessThan15Char(pass) Then
            If moreThan5char(pass) Then
                If noSpecialChar(pass) Then
                    If toDo.Equals("create") Then
                        If PosFunction.noMatchFound("select * from db_pos.accounts where user_pass = '" & pass & "'") Then
                            If txt_pass.Text.Equals(txt_cpass.Text) Then
                                Return True
                            Else
                                lbl_pwError.Text = "Password don't match!"
                                lbl_pwError.ForeColor = Color.Red
                                Return False
                            End If
                        Else
                            lbl_pwError.Text = "Password already taken!"
                            lbl_pwError.ForeColor = Color.Red
                            Return False
                        End If
                    ElseIf toDo.Equals("edit") Then
                        If txt_pass.Text.Equals(txt_cpass.Text) Then
                            Return True
                        Else
                            lbl_pwError.Text = "Password don't match!"
                            lbl_pwError.ForeColor = Color.Red
                            Return False
                        End If
                    Else
                        Return False
                    End If
                Else
                    lbl_pwError.Text = "Password can't contain special characters!"
                    lbl_pwError.ForeColor = Color.Red
                    Return False
                End If
            Else
                lbl_pwError.Text = "Enter atleast 5 characters password"
                lbl_pwError.ForeColor = Color.Red
                Return False
            End If
        Else
            lbl_pwError.Text = "Password can't be more than 15 characters!"
            lbl_pwError.ForeColor = Color.Red
            Return False
        End If
    End Function

    Private Function getQuery(bln As Boolean) As String
        Dim query As String
        Dim fname As String = upperCase(txt_fname.Text)
        Dim lname As String = upperCase(txt_lname.Text)
        Dim mname As String = getMI(txt_mname.Text)
        If bln Then
            query = "insert into db_pos.accounts (user_name, user_pass, user_control, user_fullName, user_contactNo) values ('" & txt_user.Text & "', '" & txt_pass.Text & "', 'admin', '" & lname & ", " & fname & " " & mname & "." & "', '" & txt_cNo.Text & "')"
        Else
            query = "insert into db_pos.accounts (user_name, user_pass, user_control, user_fullName, user_contactNo) values ('" & txt_user.Text & "', '" & txt_pass.Text & "', 'user', '" & lname & ", " & fname & " " & mname & "." & "', '" & txt_cNo.Text & "')"
        End If
        Return query
    End Function

    Private Sub create()
        If Not String.IsNullOrWhiteSpace(txt_user.Text) And Not String.IsNullOrWhiteSpace(txt_pass.Text) And Not String.IsNullOrWhiteSpace(txt_cpass.Text) Then
            If validUser(txt_user.Text) Then
                If validPass(txt_pass.Text) Then
                    Dim fname As String = upperCase(txt_fname.Text)
                    Dim lname As String = upperCase(txt_lname.Text)
                    Dim query As String
                    query = getQuery(admin)
                    PosFunction.alterTable(query)
                    If PosFunction.alterSuccess Then
                        Dim maxId = PosFunction.getAggregate("select max(user_id) as 'column' from db_pos.accounts", "column")
                        query = "insert into db_pos.names (user_id, first_name, middle_name, last_name) values ('" & maxId & "', '" & fname & "', '" & upperCase(txt_mname.Text) & "', '" & lname & "')"
                        PosFunction.alterTable(query)
                        If PosFunction.alterSuccess Then
                            success = True
                            MsgBox("Successfully added")
                            Me.Close()
                        Else
                            MsgBox(PosFunction.alterMessage)
                        End If
                    Else
                        MsgBox(PosFunction.alterMessage)
                    End If
                End If
            End If
        Else
            MsgBox("Incomplete Entry")
        End If
    End Sub

    Private Sub edit()
        If Not String.IsNullOrWhiteSpace(txt_user.Text) And Not String.IsNullOrWhiteSpace(txt_pass.Text) And Not String.IsNullOrWhiteSpace(txt_cpass.Text) Then
            If validUser(txt_user.Text) Then
                If validPass(txt_pass.Text) Then
                    Dim fname As String = upperCase(txt_fname.Text)
                    Dim lname As String = upperCase(txt_lname.Text)
                    Dim mname As String = getMI(txt_mname.Text)
                    Dim query As String
                    query = "update db_pos.accounts set user_name = '" & txt_user.Text & "', user_pass = '" & txt_pass.Text & "', user_fullName = '" & lname & ", " & fname & " " & mname & "." & "', user_contactNo = '" & txt_cNo.Text & "' where user_id = '" & id & "'"
                    PosFunction.alterTable(query)
                    If PosFunction.alterSuccess Then
                        query = "update db_pos.names set first_name = '" & fname & "', middle_name = '" & upperCase(txt_mname.Text) & "', last_name = '" & lname & "' where user_id = '" & id & "'"
                        PosFunction.alterTable(query)
                        If PosFunction.alterSuccess Then
                            If id.Equals(LoginForm1) Then
                                LoginForm1.user_info = PosFunction.getElement("accounts", "user_id", id, "user_fullName")
                                LoginForm1.contact_no = PosFunction.getElement("accounts", "user_id", id, "user_contactNo")
                            End If
                            success = True
                            MsgBox("Changes Saved")
                            Me.Close()
                        Else
                            MsgBox(PosFunction.alterMessage)
                        End If
                    Else
                        MsgBox(PosFunction.alterMessage)
                    End If
                End If
            End If
        Else
            MsgBox("Incomplete Entry")
        End If
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If Not String.IsNullOrWhiteSpace(txt_fname.Text) And Not String.IsNullOrWhiteSpace(txt_lname.Text) And Not String.IsNullOrWhiteSpace(txt_mname.Text) And Not String.IsNullOrWhiteSpace(txt_cNo.Text) Then
            If validNo(txt_cNo.Text) Then
                If toDo.Equals("create") Then
                    create()
                ElseIf toDo.Equals("edit") Then
                    edit()
                End If
            End If
        Else
            MsgBox("Incomplete Entry!")
        End If
    End Sub

    Private Sub txt_cNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cNo.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cNo_Leave(sender As Object, e As EventArgs) Handles txt_cNo.Leave
        If Not String.IsNullOrWhiteSpace(txt_cNo.Text) Then
            If Not validNo(txt_cNo.Text) Then
                lbl_noError.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub txt_cNo_Enter(sender As Object, e As EventArgs) Handles txt_cNo.Enter
        lbl_noError.ForeColor = SystemColors.GradientActiveCaption
    End Sub

    Private Sub txt_user_Leave(sender As Object, e As EventArgs) Handles txt_user.Leave
        If toDo.Equals("create") Then
            If Not String.IsNullOrWhiteSpace(txt_user.Text) Then
                If Not PosFunction.noMatchFound("select * from db_pos.accounts where user_name = '" & txt_user.Text & "'") Then
                    lbl_userError.ForeColor = Color.Red
                End If
            End If
        End If
    End Sub

    Private Sub txt_user_Enter(sender As Object, e As EventArgs) Handles txt_user.Enter
        lbl_userError.ForeColor = SystemColors.GradientActiveCaption
    End Sub

    Private Sub txt_pass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pass.KeyPress
        Dim arr = txt_pass.Text.ToCharArray
        If arr.Length > 15 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_pass_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_pass.KeyDown
        If e.KeyCode = Keys.Back Then
            Dim arr = txt_pass.Text.ToCharArray
            If arr.Length > 15 Then
                arr(arr.Length - 1) = ""
                txt_pass.Text = New String(arr)
                txt_pass.SelectionStart = arr.Length
            End If
        End If
    End Sub

    Private Sub pbx_pass_Click(sender As Object, e As EventArgs) Handles pbx_pass.Click
        If txt_pass.UseSystemPasswordChar Then
            txt_pass.UseSystemPasswordChar = False
            txt_cpass.UseSystemPasswordChar = False
        Else
            txt_pass.UseSystemPasswordChar = True
            txt_cpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txt_pass_Enter(sender As Object, e As EventArgs) Handles txt_pass.Enter
        lbl_pwError.ForeColor = SystemColors.GradientActiveCaption
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class