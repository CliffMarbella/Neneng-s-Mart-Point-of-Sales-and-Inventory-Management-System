Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices

Public Class frm_main

    Public intInputBoxCancel As Integer
    Dim connection As New MySqlConnection
    Dim currentForm As Form
    Dim hour As Integer = 0
    Dim minute As Integer = 0
    Dim second As Integer = 0

    Private Sub dbConnect()
        Dim conString As String = "server=" & LoginForm1.server_address & "; port=" & LoginForm1.server_port & "; userId=" & LoginForm1.user_name & "; password=" & LoginForm1.pass_word & "; database=" & LoginForm1.schema_name & ";"
        connection.ConnectionString = conString
    End Sub

    Public Function connected() As Boolean
        dbConnect()
        tssl_status.Text = "Status: Connecting...   "
        Try
            connection.Open()
            tssl_status.Text = "Status: Connected   "
            connection.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Protected Overloads Overrides Sub WndProc(ByRef m As Message)
        Const WM_NCLBUTTONDOWN As Integer = 161
        Const WM_SYSCOMMAND As Integer = 274
        Const HTCAPTION As Integer = 2
        Const SC_MOVE As Integer = 61456
        If (m.Msg = WM_SYSCOMMAND) AndAlso (m.WParam.ToInt32() = SC_MOVE) Then
            Exit Sub
        End If
        If (m.Msg = WM_NCLBUTTONDOWN) AndAlso (m.WParam.ToInt32() = HTCAPTION) Then
            Exit Sub
        End If
        MyBase.WndProc(m)
    End Sub

    Public Function StrPtr(ByVal obj As Object) As Integer
        Dim Handle As GCHandle = GCHandle.Alloc(obj, GCHandleType.Pinned)
        Dim intReturn As Integer = Handle.AddrOfPinnedObject.ToInt32
        Handle.Free()
        Return intReturn
    End Function

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        startup()
        intInputBoxCancel = StrPtr(String.Empty)
        tssl_user.Text = "User: " & LoginForm1.user_id & "   "
        currentForm = frm_PosSystem
        If LoginForm1.user_level = "admin" Then
            tssl_lvl.Text = "Access Type: Admin   "
        Else
            tssl_lvl.Text = "Access Type: User   "
        End If
    End Sub

    Private Sub startup()
        frm_PosSystem.MdiParent = Me
        frm_PosSystem.Show()
        btn_Pos.BackColor = SystemColors.Highlight
        If LoginForm1.user_level.Equals("user") Then
            btn_CM.Enabled = False
            btn_IM.Enabled = False
            btn_EM.Enabled = False
            btn_SP.Enabled = False
        End If
        If Not connected() Then
            errorBox()
        End If
    End Sub

    Private Sub errorBox()
        MsgBox("Error connection! Please contact your administrator.")
    End Sub

    Private Sub btn_Pos_Click(sender As Object, e As EventArgs) Handles btn_Pos.Click
        btn_SP.BackColor = SystemColors.ActiveCaption
        btn_CM.BackColor = SystemColors.ActiveCaption
        btn_IM.BackColor = SystemColors.ActiveCaption
        btn_EM.BackColor = SystemColors.ActiveCaption
        btn_Pos.BackColor = SystemColors.Highlight
        If Not currentForm.Equals(frm_PosSystem) Then
            currentForm.Hide()
            currentForm = frm_PosSystem
            frm_PosSystem.MdiParent = Me
            frm_PosSystem.Show()
        End If
    End Sub

    Private Sub btn_IM_Click(sender As Object, e As EventArgs) Handles btn_IM.Click
        btn_SP.BackColor = SystemColors.ActiveCaption
        btn_CM.BackColor = SystemColors.ActiveCaption
        btn_Pos.BackColor = SystemColors.ActiveCaption
        btn_EM.BackColor = SystemColors.ActiveCaption
        btn_IM.BackColor = SystemColors.Highlight
        If Not currentForm.Equals(frm_InvMngt) Then
            currentForm.Hide()
            currentForm = frm_InvMngt
            frm_InvMngt.MdiParent = Me
            frm_InvMngt.Show()
        End If
    End Sub

    Private Sub btn_SP_Click(sender As Object, e As EventArgs) Handles btn_SP.Click
        btn_Pos.BackColor = SystemColors.ActiveCaption
        btn_CM.BackColor = SystemColors.ActiveCaption
        btn_IM.BackColor = SystemColors.ActiveCaption
        btn_EM.BackColor = SystemColors.ActiveCaption
        btn_SP.BackColor = SystemColors.Highlight
        If Not currentForm.Equals(frm_salesReport) Then
            currentForm.Hide()
            currentForm = frm_salesReport
            frm_salesReport.MdiParent = Me
            frm_salesReport.Show()
        End If
    End Sub

    Private Sub btn_CM_Click(sender As Object, e As EventArgs) Handles btn_CM.Click
        btn_SP.BackColor = SystemColors.ActiveCaption
        btn_Pos.BackColor = SystemColors.ActiveCaption
        btn_IM.BackColor = SystemColors.ActiveCaption
        btn_EM.BackColor = SystemColors.ActiveCaption
        btn_CM.BackColor = SystemColors.Highlight
        If Not currentForm.Equals(frm_settings) Then
            currentForm.Hide()
            currentForm = frm_settings
            frm_settings.MdiParent = Me
            frm_settings.Show()
        End If
    End Sub

    Private Sub btn_EM_Click(sender As Object, e As EventArgs) Handles btn_EM.Click
        btn_SP.BackColor = SystemColors.ActiveCaption
        btn_CM.BackColor = SystemColors.ActiveCaption
        btn_IM.BackColor = SystemColors.ActiveCaption
        btn_Pos.BackColor = SystemColors.ActiveCaption
        btn_EM.BackColor = SystemColors.Highlight
        If Not currentForm.Equals(frm_employee) Then
            currentForm.Hide()
            currentForm = frm_employee
            frm_employee.MdiParent = Me
            frm_employee.Show()
        End If
    End Sub

    Private Sub frm_main_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        discardTransaction()
        LoginForm1.Show()
        My.Application.OpenForms.Cast(Of Form)() _
              .Except({LoginForm1, Me}) _
              .ToList() _
              .ForEach(Sub(form) form.Close())
    End Sub

    Private Sub discardTransaction()
        If frm_PosSystem.transactionAdded Then
            If frm_PosSystem.cashEntered Then
                If Not frm_PosSystem.transactionSaved Then
                    Dim ans = MsgBox("Current Transaction will be Discarded, Do you want to Save?", MsgBoxStyle.Exclamation + vbYesNo)
                    If ans.Equals(vbYes) Then
                        frm_PosSystem.saveTransaction(frm_PosSystem.txt_totalDue, frm_PosSystem.txt_discount)
                    Else
                        frm_PosSystem.discardTransaction(frm_PosSystem.transactionID)
                    End If
                End If
            Else
                frm_PosSystem.discardTransaction(frm_PosSystem.transactionID)
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not connected() Then
            tssl_status.Text = "Status: Connection Falied   "
        End If
    End Sub

    Private Sub Time_Tick(sender As Object, e As EventArgs) Handles Time.Tick
        lbl_date.Text = "Date: " & DateTime.Now.ToString("MM-dd-yyyy")
        lbl_time.Text = "Time: " & TimeOfDay.ToString("h:mm tt")
        lbl_tLogged.Text = "Time Logged In - " & hour & "hr : " & minute & "min : " & second & "sec"
        second = second + 1
        If second = 60 Then
            second = 0
            minute = minute + 1
            If minute = 60 Then
                minute = 0
                hour = hour + 1
            End If
        End If
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub tsmi_myAccount_Click(sender As Object, e As EventArgs) Handles tsmi_myAccount.Click
        PosFunction.showAuthentication()
        If Not frm_pin.canceled Then
            If frm_pin.authenticated Then
                Dim obj As New frm_account
                obj.toDo = "edit"
                obj.id = LoginForm1.user_id
                obj.ShowDialog()
            Else
                MsgBox("Incorrect Authentication Pin", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub
End Class
