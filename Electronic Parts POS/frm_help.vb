Public Class frm_help
    Public Property description As String
    Public Property pic As Image
    Public Property title As String

    Private Sub frm_help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_info.Text = description
        lbl_title.Text = title
        pb_pic.Image = pic
    End Sub
End Class