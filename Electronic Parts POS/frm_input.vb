Public Class frm_input

    Public Shared input As String
    Private Sub frm_input_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        input = vbNullString
        txt_input.Select()
        Me.KeyPreview = True
    End Sub

    Private Sub txt_input_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_input.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub frm_input_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not String.IsNullOrWhiteSpace(txt_input.Text) Then
                input = txt_input.Text
            Else
                input = 0
            End If
            Me.Close()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class