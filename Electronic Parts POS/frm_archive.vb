Public Class frm_archive

    Dim selected As String

    Private Sub frm_archive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbx_filter.SelectedIndex = 0
        loadCategory("")
    End Sub

    Private Sub loadProduct(where As String)
        Dim query As String
        query = "select p_archive_id as 'Archive ID', bar_code as 'Barcode', category_code as 'Category ID', product_name as 'Product Name'
                        from db_pos.product_archive"
        If Not where.Equals("") Then
            query = query & " where product_name = '" & where & "'"
        End If
        PosFunction.fill_dgv(dgv_archive, query)
        Dim clm1, clm2, clm3 As DataGridViewColumn
        clm1 = dgv_archive.Columns(0)
        clm2 = dgv_archive.Columns(1)
        clm3 = dgv_archive.Columns(2)
        dgv_archive.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_archive.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_archive.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        clm1.Width = 100
        clm2.Width = 150
        clm3.Width = 100
        query = "select product_name from db_pos.product_archive"
        PosFunction.fillAutoComplete(txt_id, query)
    End Sub

    Private Sub loadCategory(where As String)
        Dim query As String
        query = "select c_archive_id as 'Archive ID', category_code as 'Category ID', category_name as 'Category' from
                        db_pos.category_archive"
        If Not where.Equals("") Then
            query = query & " where category_name = '" & where & "'"
        End If
        PosFunction.fill_dgv(dgv_archive, query)
        Dim clm1, clm2 As DataGridViewColumn
        clm1 = dgv_archive.Columns(0)
        clm2 = dgv_archive.Columns(1)
        dgv_archive.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_archive.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        clm1.Width = 100
        clm2.Width = 100
        query = "select category_name from db_pos.category_archive"
        PosFunction.fillAutoComplete(txt_id, query)
    End Sub

    Private Sub cbx_filter_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbx_filter.SelectionChangeCommitted
        If cbx_filter.SelectedIndex = 0 Then
            loadCategory("")
        ElseIf cbx_filter.SelectedIndex = 1 Then
            loadProduct("")
        End If
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If cbx_filter.SelectedIndex = 0 Then
            loadCategory(txt_id.Text)
        ElseIf cbx_filter.SelectedIndex = 1 Then
            loadProduct(txt_id.Text)
        End If
    End Sub

    Private Sub txt_id_TextChanged(sender As Object, e As EventArgs) Handles txt_id.TextChanged
        If String.IsNullOrWhiteSpace(txt_id.Text) Then
            If cbx_filter.SelectedIndex = 0 Then
                loadCategory("")
            ElseIf cbx_filter.SelectedIndex = 1 Then
                loadProduct("")
            End If
        End If
    End Sub

    Private Sub dgv_archive_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_archive.RowEnter
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgv_archive.Rows(e.RowIndex)
            selected = row.Cells("Archive ID").Value.ToString
        End If
    End Sub

    Private Sub btn_restore_Click(sender As Object, e As EventArgs) Handles btn_restore.Click
        If cbx_filter.SelectedIndex = 0 Then
            If PosFunction.noMatchFound("select * from db_pos.category where category_code = '" & PosFunction.getElement("category_archive", "c_archive_id", selected, "category_code") & "'") Then
                If PosFunction.noMatchFound("select * from db_pos.category where category_name = '" & PosFunction.getElement("category_archive", "c_archive_id", selected, "category_name") & "'") Then
                    restoreCategory(selected)
                Else
                    MsgBox("Restoration Failed: the same Category already exist in the database!", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Restoration Failed: the same Category ID already exist in the database!", MsgBoxStyle.Exclamation)
            End If
        ElseIf cbx_filter.SelectedIndex = 1 Then
            If PosFunction.noMatchFound("select * from db_pos.product where bar_code = '" & PosFunction.getElement("product_archive", "p_archive_id", selected, "bar_code") & "'") Then
                If PosFunction.noMatchFound("select * from db_pos.product where product_name = '" & PosFunction.getElement("product_archive", "p_archive_id", selected, "product_name") & "'") Then
                    If PosFunction.noMatchFound("select * from db_pos.category where category_code = '" & PosFunction.getElement("product_archive", "p_archive_id", selected, "category_code") & "'") Then
                        Dim id = selected
                        If PosFunction.noMatchFound("select * from db_pos.category_archive where category_code = '" & PosFunction.getElement("product_archive", "p_archive_id", selected, "category_code") & "'") Then
                            PosFunction.alterTable("insert into db_pos.category (category_code, category_name) values ('" & PosFunction.getElement("product_archive", "p_archive_id", selected, "category_code") & "', '" & PosFunction.getElement("product_archive", "p_archive_id", selected, "product_name") & " Category')")
                        Else
                            restoreCategory(PosFunction.getElement("category_archive", "category_code", PosFunction.getElement("product_archive", "p_archive_id", selected, "category_code"), "c_archive_id"))
                        End If
                        restoreProduct(id)
                    Else
                        restoreProduct(selected)
                    End If
                Else
                    MsgBox("Restoration Failed: the same Product Name exist in the database!", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Restoration Failed: the same Barcode already exist in the database!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub restoreCategory(id As String)
        Dim query, category_name, category_code As String
        category_name = PosFunction.getElement("category_archive", "c_archive_id", id, "category_name")
        category_code = PosFunction.getElement("category_archive", "c_archive_id", id, "category_code")
        query = "insert into db_pos.category (category_code, category_name) values ('" & category_code & "', '" & category_name & "')"
        PosFunction.alterTable(query)
        If PosFunction.alterSuccess Then
            query = "delete from db_pos.category_archive where c_archive_id = '" & id & "'"
            PosFunction.alterTable(query)
            If PosFunction.alterSuccess Then
                loadCategory("")
                MsgBox("Successfully Restored!", MsgBoxStyle.Information)
            Else
                MsgBox(PosFunction.alterMessage)
            End If
        Else
            MsgBox(PosFunction.alterMessage)
        End If
    End Sub

    Private Sub restoreProduct(id As String)
        Dim bar_code, category_code, product_name, price, factory_price, vat_exempted, zero_rated, pcs_per_item, query As String
        bar_code = PosFunction.getElement("product_archive", "p_archive_id", id, "bar_code")
        category_code = PosFunction.getElement("product_archive", "p_archive_id", id, "category_code")
        MsgBox(category_code)
        product_name = PosFunction.getElement("product_archive", "p_archive_id", id, "product_name")
        price = PosFunction.getElement("product_archive", "p_archive_id", id, "price")
        factory_price = PosFunction.getElement("product_archive", "p_archive_id", id, "factory_price")
        vat_exempted = PosFunction.getElement("product_archive", "p_archive_id", id, "vat_exempted")
        zero_rated = PosFunction.getElement("product_archive", "p_archive_id", id, "zero_rated")
        pcs_per_item = PosFunction.getElement("product_archive", "p_archive_id", id, "pcs_per_item")
        query = "insert into db_pos.product (bar_code, category_code, product_name, price, stock, quantity, factory_price, vat_exempted, zero_rated, pcs_per_item) values ('" & bar_code & "',
                                    '" & category_code & "', '" & product_name & "', '" & price & "', '0 items', '0 pcs', '" & factory_price & "', '" & vat_exempted & "', '" & zero_rated & "',
                                    '" & pcs_per_item & "')"
        PosFunction.alterTable(query)
        If PosFunction.alterSuccess Then
            query = "delete from db_pos.product_archive where p_archive_id = '" & id & "'"
            PosFunction.alterTable(query)
            If PosFunction.alterSuccess Then
                loadCategory("")
                MsgBox("Successfully Restored!", MsgBoxStyle.Information)
            Else
                MsgBox(PosFunction.alterMessage)
            End If
        Else
            MsgBox(PosFunction.alterMessage)
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim query As String
        Dim ans = MsgBox(selected & " will be permanently deleted, are you sure you want to continue?", MsgBoxStyle.Exclamation + vbYesNo)
        If ans = vbYes Then
            If cbx_filter.SelectedIndex = 0 Then
                query = "delete from db_pos.category_archive where c_archive_id = '" & selected & "'"
                PosFunction.alterTable(query)
                If PosFunction.alterSuccess Then
                    loadCategory("")
                    MsgBox("Successfully Deleted!", MsgBoxStyle.Information)
                Else
                    MsgBox(PosFunction.alterMessage)
                End If
            ElseIf cbx_filter.SelectedIndex = 1 Then
                query = "delete from db_pos.product_archive where p_archive_id = '" & selected & "'"
                PosFunction.alterTable(query)
                If PosFunction.alterSuccess Then
                    loadProduct("")
                    MsgBox("Successfully Deleted!", MsgBoxStyle.Information)
                Else
                    MsgBox(PosFunction.alterMessage)
                End If
            End If
        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()
    End Sub
End Class