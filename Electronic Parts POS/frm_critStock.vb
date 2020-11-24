Public Class frm_critStock
    Private Sub frm_critStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fill_dgv_product()
    End Sub

    Private Sub fill_dgv_product()
        '私の一生の中で最も難しい質問
        Dim query As String
        query = "select distinct(product.bar_code) as 'Barcode', product.product_name as 'Product Name', product.stock as 'Stock', 
	                  (select count(items.exp_date) from db_pos.items where timestampdiff(month, curdate(), items.exp_date) < 6 and items.bar_code = product.bar_code) 
                      as 'Nearly Expired items' from db_pos.product left join db_pos.items on product.bar_code = items.bar_code where CONVERT(SUBSTRING_INDEX(stock,'-',-1), decimal(13, 2)) < 2.00
                      or timestampdiff(month, curdate(), items.exp_date) < 6 order by product.bar_code;"
        PosFunction.fill_dgv(dgv_product, query)
    End Sub

    Private Sub fill_dgv_items(bCode As String)
        Dim query As String
        query = "select item_id as 'Item Code', exp_date as 'Expiration Date' from db_pos.items where bar_code = '" & bCode & "' and timestampdiff(month, curdate(), exp_date) < 6"
        PosFunction.fill_dgv(dgv_item, query)
    End Sub

    Private Sub dgv_product_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_product.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgv_product.Rows(e.RowIndex)
            fill_dgv_items(row.Cells("Barcode").Value.ToString)
        End If
    End Sub
End Class