
Public Class frm_InvMngt

#Region "initialize variable"
    Public intInputBoxCancel As Integer
    Delegate Sub ComboDelegate()
    Public Shared selected As String
#End Region

#Region "for connection"
    Private Sub messageBox()
        MsgBox("Error Connection! Please conatact your administrator")
    End Sub
#End Region

#Region "form load"
    Private Sub frm_InvMngt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frm_main.connected Then
            intInputBoxCancel = frm_main.StrPtr(String.Empty)
            fillPTable()
            setContextMenu()
        Else
            messageBox()
        End If
    End Sub

    Private Sub setContextMenu()
        Dim ctxtMenu As New ContextMenu
        cbx_cCode.ContextMenu = ctxtMenu
        cbx_pCode.ContextMenu = ctxtMenu
    End Sub

    Private Sub fillPTable()
        Dim query As String = "select bar_code as 'Barcode', category_code as 'Category Code', product_name as 'Product Name',
                                       price as 'Price', stock as 'Stocks', quantity as 'Quantity', factory_price as 'Factory Price' 
                                       from db_pos.product"
        PosFunction.fill_dgv(dgv_product, query)
        PosFunction.fillCbx(cbx_cCode, "select category_name from db_pos.category")
        PosFunction.fillAutoComplete(txt_nameSearch, "select product_name from db_pos.product")
        PosFunction.fillAutoComplete(txt_idSearch, "select bar_code from db_pos.product")
    End Sub
#End Region

#Region "for cbx"

#Region "for cbx pcode"
    Private Sub cbx_pCode_KeyDown(sender As Object, e As KeyEventArgs) Handles cbx_pCode.KeyDown
        e.SuppressKeyPress = True
    End Sub

    Private Sub cbx_pCode_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbx_pCode.SelectionChangeCommitted
        If cbx_pCode.SelectedIndex <> 0 Then
            BeginInvoke(New ComboDelegate(AddressOf resetCbxPcode))
        End If
    End Sub

    Private Sub resetCbxPcode()
        Dim str As String = PosFunction.getElement("product", "product_name", cbx_pCode.Text, "bar_code")
        With cbx_pCode
            .SelectedIndex = -1
            .Text = str
            .Focus()
        End With
    End Sub

    Private Sub cbx_pCode_TextChanged(sender As Object, e As EventArgs) Handles cbx_pCode.TextChanged
        If cbx_pCode.SelectedIndex <> 0 Then
            Dim query As String
            query = "select bar_code as 'Barcode', category_code as 'Category Code', product_name as 'Product Name',
                                       price as 'Price', stock as 'Stocks', quantity as 'Quantity', factory_price as 'Factory Price' 
                                       from db_pos.product where category_code = '" & cbx_cCode.Text & "' and bar_code = '" & cbx_pCode.Text & "'"
            PosFunction.fill_dgv(dgv_product, query)
        Else
            Dim query As String
            query = "select bar_code as 'Barcode', category_code as 'Category Code', product_name as 'Product Name',
                                       price as 'Price', stock as 'Stocks', quantity as 'Quantity', factory_price as 'Factory Price' 
                                       from db_pos.product where category_code = '" & cbx_cCode.Text & "'"
            PosFunction.fill_dgv(dgv_product, query)
        End If
    End Sub
#End Region

#Region "For cbx_cCode"
    Private Sub cbx_cCode_KeyDown(sender As Object, e As KeyEventArgs) Handles cbx_cCode.KeyDown
        e.SuppressKeyPress = True
    End Sub

    Private Sub cbx_cCode_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbx_cCode.SelectionChangeCommitted
        If cbx_cCode.SelectedIndex <> 0 Then
            BeginInvoke(New ComboDelegate(AddressOf ResetCbxCcode))
        End If
    End Sub

    Private Sub ResetCbxCcode()
        Dim str As String = PosFunction.getElement("category", "category_name", cbx_cCode.SelectedItem, "category_code")
        With cbx_cCode
            .SelectedIndex = -1
            .Text = str
            .Focus()
        End With
    End Sub

    Private Sub cbx_cCodeItem_TextChanged(sender As Object, e As EventArgs) Handles cbx_cCode.TextChanged
        cbx_pCode.SelectedItem = ""
        If cbx_cCode.SelectedIndex <> 0 Then
            Dim query As String = "select product_name from db_pos.product where category_code = '" & cbx_cCode.Text & "'"
            PosFunction.fillCbx(cbx_pCode, query)
            query = "select bar_code as 'Barcode', category_code as 'Category Code', product_name as 'Product Name',
                                       price as 'Price', stock as 'Stocks', quantity as 'Quantity', factory_price as 'Factory Price' 
                                       from db_pos.product where category_code = '" & cbx_cCode.Text & "'"
            PosFunction.fill_dgv(dgv_product, query)
        Else
            cbx_pCode.Text = ""
            cbx_pCode.Items.Clear()
        End If
        clearItbx()
    End Sub

    Private Sub clearItbx()
        If String.IsNullOrWhiteSpace(cbx_cCode.Text) And String.IsNullOrWhiteSpace(cbx_pCode.Text) Then
            Dim query As String = "select bar_code as 'Barcode', category_code as 'Category Code', product_name as 'Product Name',
                                       price as 'Price', stock as 'Stocks', quantity as 'Quantity', factory_price as 'Factory Price' 
                                       from db_pos.product"
            PosFunction.fill_dgv(dgv_product, query)
        End If
    End Sub
#End Region

#End Region

#Region "for dgv"

    Private Sub dgv_product_cellclick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_product.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            Dim con As String
            row = Me.dgv_product.Rows(e.RowIndex)
            con = row.Cells("Product Name").Value.ToString
            lbl_productN.Text = con
            selected = PosFunction.getElement("product", "product_name", con, "name_code")
            lbl_productC.Text = PosFunction.getElement("product", "product_name", con, "bar_code")
            lbl_categoryN.Text = PosFunction.getElement("category", "category_code", PosFunction.getElement("product", "product_name", con, "category_code"), "category_name")
            lbl_price.Text = PosFunction.getElement("product", "product_name", con, "price")
            lbl_stock.Text = PosFunction.getElement("product", "product_name", con, "stock")
            lbl_productQ.Text = PosFunction.getElement("product", "product_name", con, "quantity")
        End If
    End Sub

    Private Sub btn_nameSearch_Click(sender As Object, e As EventArgs) Handles btn_nameSearch.Click
        If Not String.IsNullOrWhiteSpace(txt_nameSearch.Text) Then
            txt_idSearch.Text = ""
            Dim query As String = "select bar_code as 'Barcode', category_code as 'Category Code', product_name as 'Product Name',
                                       price as 'Price', stock as 'Stocks', quantity as 'Quantity', factory_price as 'Factory Price' 
                                       from db_pos.product where product_name = '" & txt_nameSearch.Text & "'"
            PosFunction.fill_dgv(dgv_product, query)
        End If
    End Sub

    Private Sub txt_nameSearch_TextChanged(sender As Object, e As EventArgs) Handles txt_nameSearch.TextChanged
        If String.IsNullOrWhiteSpace(txt_nameSearch.Text) Then
            Dim query As String = "select bar_code as 'Barcode', category_code as 'Category Code', product_name as 'Product Name',
                                       price as 'Price', stock as 'Stocks', quantity as 'Quantity', factory_price as 'Factory Price' 
                                       from db_pos.product"
            PosFunction.fill_dgv(dgv_product, query)
        End If
    End Sub

    Private Sub btn_idSearch_Click(sender As Object, e As EventArgs) Handles btn_idSearch.Click
        If Not String.IsNullOrWhiteSpace(txt_idSearch.Text) Then
            txt_nameSearch.Text = ""
            Dim query As String = "select bar_code as 'Barcode', category_code as 'Category Code', product_name as 'Product Name',
                                       price as 'Price', stock as 'Stocks', quantity as 'Quantity', factory_price as 'Factory Price' 
                                       from db_pos.product where bar_code = '" & txt_idSearch.Text & "'"
            PosFunction.fill_dgv(dgv_product, query)
        End If
    End Sub

    Private Sub txt_idSearch_TextChanged(sender As Object, e As EventArgs) Handles txt_idSearch.TextChanged
        If String.IsNullOrWhiteSpace(txt_idSearch.Text) Then
            Dim query As String = "select bar_code as 'Barcode', category_code as 'Category Code', product_name as 'Product Name',
                                       price as 'Price', stock as 'Stocks', quantity as 'Quantity', factory_price as 'Factory Price' 
                                       from db_pos.product"
            PosFunction.fill_dgv(dgv_product, query)
        End If
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Dim query As String = "select bar_code as 'Barcode', category_code as 'Category Code', product_name as 'Product Name',
                                       price as 'Price', stock as 'Stocks', quantity as 'Quantity', factory_price as 'Factory Price' 
                                       from db_pos.product"
        PosFunction.fill_dgv(dgv_product, query)
    End Sub
#End Region

#Region "panel highlights"

    Private Sub Panel9_MouseEnter(sender As Object, e As EventArgs) Handles pnl_add.MouseEnter
        pnl_add.BackColor = SystemColors.Control
    End Sub

    Private Sub Label10_MouseEnter(sender As Object, e As EventArgs) Handles Label10.MouseEnter
        pnl_add.BackColor = SystemColors.Control
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        pnl_add.BackColor = SystemColors.Control
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        pnl_add.BackColor = SystemColors.Window
    End Sub

    Private Sub pnl_add_MouseLeave(sender As Object, e As EventArgs) Handles pnl_add.MouseLeave
        pnl_add.BackColor = SystemColors.Window
    End Sub

    Private Sub pnl_update_MouseEnter(sender As Object, e As EventArgs) Handles pnl_update.MouseEnter
        pnl_update.BackColor = SystemColors.Control
    End Sub

    Private Sub Label13_MouseEnter(sender As Object, e As EventArgs) Handles Label13.MouseEnter
        pnl_update.BackColor = SystemColors.Control
    End Sub

    Private Sub PictureBox5_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox5.MouseEnter
        pnl_update.BackColor = SystemColors.Control
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        pnl_update.BackColor = SystemColors.Window
    End Sub

    Private Sub pnl_update_MouseLeave(sender As Object, e As EventArgs) Handles pnl_update.MouseLeave
        pnl_update.BackColor = SystemColors.Window
    End Sub

    Private Sub pnl_remove_MouseEnter(sender As Object, e As EventArgs) Handles pnl_remove.MouseEnter
        pnl_remove.BackColor = SystemColors.Control
    End Sub

    Private Sub Label14_MouseEnter(sender As Object, e As EventArgs) Handles Label14.MouseEnter
        pnl_remove.BackColor = SystemColors.Control
    End Sub

    Private Sub PictureBox6_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox6.MouseEnter
        pnl_remove.BackColor = SystemColors.Control
    End Sub

    Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave
        pnl_remove.BackColor = SystemColors.Window
    End Sub

    Private Sub pnl_remove_MouseLeave(sender As Object, e As EventArgs) Handles pnl_remove.MouseLeave
        pnl_remove.BackColor = SystemColors.Window
    End Sub

    Private Sub pnl_category_MouseEnter(sender As Object, e As EventArgs) Handles pnl_category.MouseEnter
        pnl_category.BackColor = SystemColors.Control
    End Sub

    Private Sub Label11_MouseEnter(sender As Object, e As EventArgs) Handles Label11.MouseEnter
        pnl_category.BackColor = SystemColors.Control
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        pnl_category.BackColor = SystemColors.Control
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        pnl_category.BackColor = SystemColors.Window
    End Sub

    Private Sub pnl_category_MouseLeave(sender As Object, e As EventArgs) Handles pnl_category.MouseLeave
        pnl_category.BackColor = SystemColors.Window
    End Sub

    Private Sub pnl_stock_MouseEnter(sender As Object, e As EventArgs) Handles pnl_stock.MouseEnter
        pnl_stock.BackColor = SystemColors.Control
    End Sub

    Private Sub Label12_MouseEnter(sender As Object, e As EventArgs) Handles Label12.MouseEnter
        pnl_stock.BackColor = SystemColors.Control
    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        pnl_stock.BackColor = SystemColors.Control
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        pnl_stock.BackColor = SystemColors.Window
    End Sub

    Private Sub pnl_stock_MouseLeave(sender As Object, e As EventArgs) Handles pnl_stock.MouseLeave
        pnl_stock.BackColor = SystemColors.Window
    End Sub

    Private Sub pnl_critical_MouseEnter(sender As Object, e As EventArgs) Handles pnl_critical.MouseEnter
        pnl_critical.BackColor = SystemColors.Control
    End Sub

    Private Sub Label15_MouseEnter(sender As Object, e As EventArgs) Handles Label15.MouseEnter
        pnl_critical.BackColor = SystemColors.Control
    End Sub

    Private Sub PictureBox7_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox7.MouseEnter
        pnl_critical.BackColor = SystemColors.Control
    End Sub

    Private Sub PictureBox7_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox7.MouseLeave
        pnl_critical.BackColor = SystemColors.Window
    End Sub

    Private Sub pnl_critical_MouseLeave(sender As Object, e As EventArgs) Handles pnl_critical.MouseLeave
        pnl_critical.BackColor = SystemColors.Window
    End Sub

    Private Sub pnl_archive_MouseEnter(sender As Object, e As EventArgs) Handles pnl_archive.MouseEnter
        pnl_archive.BackColor = SystemColors.Control
    End Sub

    Private Sub Label16_MouseEnter(sender As Object, e As EventArgs) Handles Label16.MouseEnter
        pnl_archive.BackColor = SystemColors.Control
    End Sub

    Private Sub PictureBox8_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox8.MouseEnter
        pnl_archive.BackColor = SystemColors.Control
    End Sub

    Private Sub PictureBox8_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox8.MouseLeave
        pnl_archive.BackColor = SystemColors.Window
    End Sub

    Private Sub pnl_archive_MouseLeave(sender As Object, e As EventArgs) Handles pnl_archive.MouseLeave
        pnl_archive.BackColor = SystemColors.Window
    End Sub
#End Region

#Region "add product"
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        pnl_add_Click(sender, e)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        pnl_add_Click(sender, e)
    End Sub

    Private Sub pnl_add_Click(sender As Object, e As EventArgs) Handles pnl_add.Click
        If Not frm_addProduct.form_shown Then
            Dim obj As New frm_addProduct
            obj.TopMost = True
            obj.Show()
        End If
    End Sub

#End Region

#Region "update product"

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        pnl_update_Click(sender, e)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        pnl_update_Click(sender, e)
    End Sub

    Private Sub pnl_update_Click(sender As Object, e As EventArgs) Handles pnl_update.Click
        If Not String.IsNullOrWhiteSpace(selected) And Not PosFunction.noMatchFound("select * from db_pos.product where name_code = '" & selected & "'") Then
            If Not frm_editItem.form_shown Then
                Dim obj As New frm_editItem
                obj.edit = "product"
                obj.ShowDialog()
            End If
        Else
            MsgBox("No product selected!")
        End If
    End Sub
#End Region

#Region "delete product"

    Private Sub pnl_remove_Click(sender As Object, e As EventArgs) Handles pnl_remove.Click
        PictureBox6_Click(sender, e)
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        PictureBox6_Click(sender, e)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        deleteProduct()
    End Sub

    Private Sub deleteProduct()
        If Not String.IsNullOrWhiteSpace(selected) And Not PosFunction.noMatchFound("select * from db_pos.product where name_code = '" & selected & "'") Then
            Dim ans As String
            ans = MsgBox("All the item under this product will also be deleted, Are you sure you want to delete this product?", vbYesNo + MsgBoxStyle.Exclamation)
            If ans = vbYes Then
                Dim delProductQuery, delItemQuery As String
                delProductQuery = "insert into db_pos.product_archive (name_code, bar_code, category_code, product_name, price, stock, quantity, factory_price,
                                          vat_exempted, zero_rated, pcs_per_item) values ('" & PosFunction.getElement("product", "product_name", lbl_productN.Text, "name_code") & "', '" & PosFunction.getElement("product", "product_name", lbl_productN.Text, "bar_code") & "',
                                          '" & PosFunction.getElement("product", "product_name", lbl_productN.Text, "category_code") & "', '" & lbl_productN.Text & "',
                                          '" & PosFunction.getElement("product", "product_name", lbl_productN.Text, "price") & "', '" & PosFunction.getElement("product", "product_name", lbl_productN.Text, "stock") & "',
                                          '" & PosFunction.getElement("product", "product_name", lbl_productN.Text, "quantity") & "', '" & PosFunction.getElement("product", "product_name", lbl_productN.Text, "factory_price") & "',
                                          '" & PosFunction.getElement("product", "product_name", lbl_productN.Text, "vat_exempted") & "', '" & PosFunction.getElement("product", "product_name", lbl_productN.Text, "zero_rated") & "',
                                          '" & PosFunction.getElement("product", "product_name", lbl_productN.Text, "pcs_per_item") & "')"
                PosFunction.alterTable(delProductQuery)
                delProductQuery = "delete from db_pos.product where name_code = '" & PosFunction.getElement("product", "product_name", lbl_productN.Text, "name_code") & "'"
                delItemQuery = "delete from db_pos.items where bar_code = '" & PosFunction.getElement("product", "product_name", lbl_productN.Text, "bar_code") & "'"
                PosFunction.alterTable(delProductQuery)
                PosFunction.alterTable(delItemQuery)
                If PosFunction.alterSuccess Then
                    fillPTable()
                    MsgBox("Successfuly Deleted")
                Else
                    MsgBox("Delete Fail " & PosFunction.alterMessage)
                End If
            End If
        Else
            MsgBox("No product selected!")
        End If
    End Sub

#End Region

#Region "manage product"

    Private Sub pnl_category_Click(sender As Object, e As EventArgs) Handles pnl_category.Click
        PictureBox3_Click(sender, e)
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        PictureBox3_Click(sender, e)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If Not frm_editCategory.form_shown Then
            Dim obj As New frm_editCategory
            obj.TopMost = True
            obj.Show()
        End If
    End Sub

#End Region

#Region "manage stock"
    Private Sub pnl_stock_Click(sender As Object, e As EventArgs) Handles pnl_stock.Click
        If Not frm_manageStock.form_shown Then
            Dim obj As New frm_manageStock
            obj.TopMost = True
            obj.Show()
        End If
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        pnl_stock_Click(sender, e)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        pnl_stock_Click(sender, e)
    End Sub

#End Region

#Region "Archive"

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        pnl_archive_Click(sender, e)
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        pnl_archive_Click(sender, e)
    End Sub

    Private Sub pnl_archive_Click(sender As Object, e As EventArgs) Handles pnl_archive.Click
        frm_archive.TopMost = True
        frm_archive.Show()
    End Sub
#End Region

#Region "Critical"

    Private Sub pnl_critical_Click(sender As Object, e As EventArgs) Handles pnl_critical.Click
        frm_critStock.TopMost = True
        frm_critStock.Show()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        pnl_critical_Click(sender, e)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        pnl_critical_Click(sender, e)
    End Sub

#End Region

#Region "Supplier"
    Private Sub pnl_supplier_Click(sender As Object, e As EventArgs) Handles pnl_supplier.Click
        frm_supplier.TopMost = True
        frm_supplier.Show()
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        pnl_supplier_Click(sender, e)
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        pnl_supplier_Click(sender, e)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

#End Region

End Class