Public Class frm_welcome

    Public Shared initialAmount As Double

    Private Sub txt_input_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_input.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub frm_welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_name.Text = LoginForm1.user_info
        lbl_time.Text = TimeOfDay.ToString("h:mm tt")
        lbl_control.Text = LoginForm1.user_level
        lbl_id.Text = LoginForm1.user_id
        txt_input.Select()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub frm_welcome_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LoginForm1.Show()
    End Sub

    Private Sub btn_enter_Click(sender As Object, e As EventArgs) Handles btn_enter.Click
        If Not String.IsNullOrWhiteSpace(txt_input.Text) Then
            initialAmount = txt_input.Text
            LoginForm1.log = LoginForm1.log & vbNewLine & DateTime.Now.ToString & " : " & "Initial amount entered: " & txt_input.Text
            Me.Hide()
            frm_main.Show()
        End If
    End Sub
End Class