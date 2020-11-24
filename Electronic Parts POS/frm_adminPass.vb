Public Class frm_adminPass
    Private Sub btn_enter_Click(sender As Object, e As EventArgs) Handles btn_enter.Click
        If String.IsNullOrWhiteSpace(LoginForm1.authentication) Then
            Dim pin As String
            pin = "041599"
            If txt_pass.Text = pin Then
                frm_dbSettings.Show()
                txt_pass.Text = ""
                Me.Hide()
            Else
                Me.Close()
                MsgBox("Access Denied!", MsgBoxStyle.Critical)
            End If
        Else
            If txt_pass.Text = LoginForm1.authentication Then
                frm_dbSettings.Show()
                txt_pass.Text = ""
                Me.Hide()
            Else
                Me.Close()
                MsgBox("Access Denied!", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub frm_adminPass_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        LoginForm1.Enabled = True
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class