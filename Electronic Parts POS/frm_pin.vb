Public Class frm_pin

    Public Shared canceled As Boolean
    Public Shared authenticated As Boolean
    Dim keyEnter As Boolean

    Private Sub frm_pin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        canceled = False
        authenticated = False
        keyEnter = False
        txt_pin.Select()
        Me.KeyPreview = True
    End Sub

    Private Sub txt_pin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pin.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub frm_pin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            keyEnter = True
            If txt_pin.Text.Equals(LoginForm1.authentication) Then
                authenticated = True
            Else
                authenticated = False
            End If
            Me.Close()
        ElseIf e.KeyCode = Keys.Escape Then
            keyEnter = False
            Me.Close()
        End If
    End Sub

    Private Sub frm_pin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If Not keyEnter Then
            canceled = True
        End If
    End Sub
End Class