Public Class frm_posAddItem

    Public Shared form_shown As Boolean
    Dim selected As String
    Dim dgv_row As Integer
    Dim dgv_column As Integer
    Public Property transaction As String
    Private Sub frm_posAddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        form_shown = True
        dgv_load(sender, e)
        PosFunction.fillAutoComplete(txt_nameSearch, "select product_name from db_pos.product")
        cbx_discount.SelectedIndex = 0
        txt_nameSearch.Select()
        Me.KeyPreview = True
    End Sub

    Private Sub dgv_load(sender As Object, e As EventArgs)
        Dim query As String
        query = "select bar_code as 'Barcode', product_name as 'Product Name', price as 'Price', 
                                      vat_exempted as 'VAT Exempted', zero_rated as 'Zero Rated' 
                                       from db_pos.product"
        PosFunction.fill_dgv(dgv_item, query)
        resize_columns()
        e = New DataGridViewCellEventArgs(dgv_column, dgv_row)
        dgv_item_CellClick(sender, e)
    End Sub

    Private Sub resize_columns()
        Dim idColumn As DataGridViewColumn = dgv_item.Columns(0)
        Dim priceColumn As DataGridViewColumn = dgv_item.Columns(2)
        Dim vExColumn As DataGridViewColumn = dgv_item.Columns(3)
        Dim zRColumn As DataGridViewColumn = dgv_item.Columns(4)
        dgv_item.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_item.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_item.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_item.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        idColumn.Width = 80
        priceColumn.Width = 80
        vExColumn.Width = 70
        zRColumn.Width = 70
    End Sub

    Private Sub frm_posAddItem_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        form_shown = False
    End Sub

    Private Sub dgv_item_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_item.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.dgv_item.Rows(e.RowIndex)
                selected = PosFunction.getElement("Product", "bar_code", row.Cells("Barcode").Value.ToString, "name_code")
                lbl_pCode.Text = row.Cells("Barcode").Value.ToString
                lbl_pName.Text = row.Cells("Product Name").Value.ToString
                lbl_cName.Text = PosFunction.getElement("category", "category_code", PosFunction.getElement("product", "name_code", selected, "category_code"), "category_name")
                lbl_pPrice.Text = row.Cells("Price").Value.ToString
                lbl_zRated.Text = row.Cells("VAT Exempted").Value.ToString
                lbl_vExempted.Text = row.Cells("Zero Rated").Value.ToString
            End If
        Catch
            selected = vbNullString
        End Try
    End Sub

    Private Sub dgv_item_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_item.RowEnter
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            Dim column As DataGridViewColumn
            row = Me.dgv_item.Rows(e.RowIndex)
            column = Me.dgv_item.Columns(e.ColumnIndex)
            dgv_row = row.Index
            dgv_column = column.Index
        End If
    End Sub

    Private Sub btn_nameSearch_Click(sender As Object, e As EventArgs) Handles btn_nameSearch.Click
        If Not String.IsNullOrWhiteSpace(txt_nameSearch.Text) Then
            Dim query As String
            query = "select bar_code as 'Barcode', product_name as 'Product Name', price as 'Price', 
                                      vat_exempted as 'VAT Exempted', zero_rated as 'Zero Rated' 
                                       from db_pos.product where product_name = '" & txt_nameSearch.Text & "'"
            PosFunction.fill_dgv(dgv_item, query)
            resize_columns()
            e = New DataGridViewCellEventArgs(dgv_column, dgv_row)
            dgv_item_CellClick(sender, e)
        End If
    End Sub

    Private Sub txt_nameSearch_TextChanged(sender As Object, e As EventArgs) Handles txt_nameSearch.TextChanged
        If String.IsNullOrWhiteSpace(txt_nameSearch.Text) Then
            dgv_load(sender, e)
        End If
    End Sub

    Private Sub txt_nameSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_nameSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_nameSearch_Click(sender, e)
        End If
    End Sub

    Private Sub showInputItem()
        Dim obj As New frm_input
        obj.TopMost = True
        obj.lbl_enterInput.Text = "Enter Quantity"
        obj.ShowDialog()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If Not String.IsNullOrWhiteSpace(selected) Then
            showInputItem()
            If Not String.IsNullOrWhiteSpace(frm_input.input) Then
                If Not PosFunction.outOfStock(CInt(frm_input.input), PosFunction.getElement("product", "name_code", selected, "bar_code")) Then
                    Dim discount As Double
                    If cbx_discount.SelectedIndex <> 0 Then
                        discount = CInt(cbx_discount.SelectedItem.replace("%", "")) / 100
                    Else
                        discount = 0
                    End If
                    If CInt(frm_input.input) <> 0 Then
                        frm_PosSystem.addItem(discount, CInt(frm_input.input), transaction, selected, frm_PosSystem.dgv_pos, frm_PosSystem.txt_subTotal, frm_PosSystem.txt_vat, frm_PosSystem.txt_discount, frm_PosSystem.txt_totalDue, frm_PosSystem.txt_amount, frm_PosSystem.txt_change)
                    End If
                Else
                    MsgBox("Out Of Stock", MsgBoxStyle.Exclamation)
                End If
            End If
        Else
            MsgBox("No item selected", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub frm_posAddItem_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            btn_add_Click(sender, e)
        End If
    End Sub
End Class