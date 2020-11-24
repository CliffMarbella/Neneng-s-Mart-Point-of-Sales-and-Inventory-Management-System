Public Class frm_restoreCategory

    Dim selected As String

    Private Sub fill_dgv()
        Dim query As String
        query = "select category_code as 'Category Code', category_name as 'Category' from db_pos.category"
        PosFunction.fill_dgv(dgv_category, query)
    End Sub

    Private Sub frm_restoreCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fill_dgv()
    End Sub

    Private Sub dgv_category_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_category.RowEnter
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgv_category.Rows(e.RowIndex)
            selected = row.Cells("Category Code").Value.ToString
        End If
    End Sub
End Class