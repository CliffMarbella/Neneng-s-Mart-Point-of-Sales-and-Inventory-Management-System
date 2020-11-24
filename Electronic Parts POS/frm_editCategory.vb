Public Class frm_editCategory

    Public Shared form_shown As Boolean
    Public Shared selected As String
    Public Shared editCategory_query As String = "select category_code as 'Category Code', category_name as 'Category' from db_pos.category"

    Private Sub frm_editCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        form_shown = True
        fill_dgv()
    End Sub

    Private Sub fill_dgv()
        Dim query As String = editCategory_query
        PosFunction.fill_dgv(dgv_category, query)
        resize_columns(dgv_category)
        PosFunction.fillAutoComplete(txt_category, "select category_name from db_pos.category")
    End Sub

    Public Shared Sub resize_columns(dgv As DataGridView)
        Dim id As New DataGridViewColumn
        id = dgv.Columns(0)
        dgv.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        id.Width = 100
    End Sub

    Private Sub dgv_category_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_category.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgv_category.Rows(e.RowIndex)
            txt_category.Text = row.Cells("Category").Value.ToString
            selected = row.Cells("Category Code").Value.ToString
        End If
    End Sub

    Private Sub btn_addCategory_Click(sender As Object, e As EventArgs) Handles btn_addCategory.Click
        If Not String.IsNullOrWhiteSpace(txt_category.Text) Then
            If frm_main.connected Then
                Dim ctgry As String = txt_category.Text
                Dim query As String = "select category_code from category where category_name = '" & ctgry & "'"
                If PosFunction.noMatchFound(query) Then
                    Dim addQuery As String = "insert into category (category_name) values ('" & txt_category.Text & "')"
                    PosFunction.alterTable(addQuery)
                    If PosFunction.alterSuccess Then
                        PosFunction.fillCbx(frm_InvMngt.cbx_cCode, "select category_name from db_pos.category")
                        fill_dgv()
                        MsgBox("Entry Successfully Added")
                    Else
                        MsgBox("Adding Failed: " & PosFunction.alterMessage)
                    End If
                Else
                    MsgBox("Category Already Exist!")
                End If
            Else
                MsgBox("Error Connection")
            End If
        Else
            MsgBox("Empty Entry!")
        End If
    End Sub

    Private Sub frm_editCategory_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        form_shown = False
    End Sub

    Private Sub btn_searchCategory_Click(sender As Object, e As EventArgs) Handles btn_searchCategory.Click
        If Not String.IsNullOrWhiteSpace(txt_category.Text) Then
            Dim query As String
            query = "select category_code as 'Category Code', category_name as 'Category' from category where category_name = '" & txt_category.Text & "'"
            PosFunction.fill_dgv(dgv_category, query)
            Dim id As New DataGridViewColumn
            id = dgv_category.Columns(0)
            dgv_category.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            id.Width = 100
        Else
            MsgBox("Empty Value!")
        End If
    End Sub

    Private Sub txt_category_TextChanged(sender As Object, e As EventArgs) Handles txt_category.TextChanged
        If String.IsNullOrWhiteSpace(txt_category.Text) Then
            fill_dgv()
        End If
    End Sub

    Private Sub btn_deleteCategory_Click(sender As Object, e As EventArgs) Handles btn_deleteCategory.Click
        If Not String.IsNullOrWhiteSpace(selected) And Not PosFunction.noMatchFound("select * from db_pos.category where category_code = '" & selected & "'") Then
            Dim query As String = "select * from category where category_name = '" & txt_category.Text & "'"
            If PosFunction.noMatchFound(query) = False Then
                Dim ans As String
                ans = MsgBox("All products of this category will also be deleted, Are you sure you want to delete this category? ", vbYesNo + MsgBoxStyle.Exclamation)
                If ans = vbYes Then
                    Dim delCategoryQuery, delProductQuery, delItemQuery As String
                    Dim arr() As Integer = PosFunction.getId("product", "name_code", "category_code", PosFunction.getElement("category", "category_name", txt_category.Text, "category_code"))
                    delCategoryQuery = "insert into db_pos.category_archive (category_code, category_name) values ('" & PosFunction.getElement("category", "category_name", txt_category.Text, "category_code") & "', '" & txt_category.Text & "')"
                    PosFunction.alterTable(delCategoryQuery)
                    For x = 0 To arr.Length - 1
                        delProductQuery = "insert into db_pos.product_archive (name_code, bar_code, category_code, product_name, price, stock, quantity, factory_price, vat_exempted, zero_rated, pcs_per_item) 
                                                  values ('" & arr(x) & "', '" & PosFunction.getElement("product", "name_code", arr(x), "bar_code") & "', '" & PosFunction.getElement("product", "name_code", arr(x), "category_code") & "', '" & PosFunction.getElement("product", "name_code", arr(x), "product_name") & "',
                                                  '" & PosFunction.getElement("product", "name_code", arr(x), "price") & "', '" & PosFunction.getElement("product", "name_code", arr(x), "stock") & "',
                                                  '" & PosFunction.getElement("product", "name_code", arr(x), "quantity") & "', '" & PosFunction.getElement("product", "name_code", arr(x), "factory_price") & "',
                                                  '" & PosFunction.getElement("product", "name_code", arr(x), "vat_exempted") & "', '" & PosFunction.getElement("product", "name_code", arr(x), "zero_rated") & "',
                                                  '" & PosFunction.getElement("product", "name_code", arr(x), "pcs_per_item") & "')"
                        PosFunction.alterTable(delProductQuery)
                    Next
                    delCategoryQuery = "delete from db_pos.category where category_code = '" & PosFunction.getElement("category", "category_name", txt_category.Text, "category_code") & "'"
                    delProductQuery = "delete from db_pos.product where category_code = '" & PosFunction.getElement("category", "category_name", txt_category.Text, "category_code") & "'"
                    delItemQuery = "delete from db_pos.items where category_code = '" & PosFunction.getElement("category", "category_name", txt_category.Text, "category_code") & "'"
                    PosFunction.alterTable(delCategoryQuery)
                    PosFunction.alterTable(delProductQuery)
                    PosFunction.alterTable(delItemQuery)
                    If PosFunction.alterSuccess Then
                        PosFunction.fillCbx(frm_InvMngt.cbx_cCode, "select category_name from db_pos.category")
                        fill_dgv()
                        query = "select bar_code as 'Barcode', category_code as 'Category Code', product_name as 'Product Name',
                                       price as 'Price', stock as 'Stocks', quantity as 'Quantity', factory_price as 'Factory Price' 
                                       from db_pos.product"
                        PosFunction.fill_dgv(frm_InvMngt.dgv_product, query)
                        PosFunction.fillAutoComplete(frm_InvMngt.txt_nameSearch, "select product_name from db_pos.product")
                        PosFunction.fillAutoComplete(frm_InvMngt.txt_idSearch, "select bar_code from db_pos.product")
                        MsgBox("Category Succesfully Deleted")
                    Else
                        MsgBox("Delete Failed! " & PosFunction.alterMessage)
                    End If
                End If
            Else
                MsgBox("Category Not Found!")
            End If
        Else
            MsgBox("Select Category!")
        End If
    End Sub

    Private Sub btn_editCategory_Click(sender As Object, e As EventArgs) Handles btn_editCategory.Click
        If Not String.IsNullOrWhiteSpace(selected) And Not PosFunction.noMatchFound("select * from db_pos.category where category_code = '" & selected & "'") Then
            Dim obj As New frm_editItem
            obj.edit = "category"
            obj.TopMost = True
            Me.Close()
            obj.ShowDialog()
        Else
            MsgBox("Select Category!")
        End If
    End Sub
End Class