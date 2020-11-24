Public Class frm_addProduct

    Delegate Sub ComboDelegate()
    Public Shared form_shown As Boolean

    Private Sub frm_addProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctxt As New ContextMenu
        cbx_cCode.ContextMenu = ctxt
        form_shown = True
        PosFunction.fillCbx(cbx_cCode, "select category_name from db_pos.category")
    End Sub

    Private Function noEmptyTbx() As Boolean
        Dim arr(7) As String
        arr(0) = txt_pName.Text
        arr(1) = txt_fPrice.Text
        arr(2) = txt_mPrice.Text
        arr(3) = cbx_cCode.Text
        arr(4) = txt_pcs.Text
        arr(5) = cbx_vExempted.SelectedItem
        arr(6) = cbx_zRated.SelectedItem
        arr(7) = txt_bCode.Text
        For x = 0 To arr.Length - 1
            If String.IsNullOrWhiteSpace(arr(x)) Then
                Return False
            End If
        Next
        Return True
    End Function

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
#End Region

    Private Sub bnt_add_Click(sender As Object, e As EventArgs) Handles bnt_add.Click
        If noEmptyTbx() Then
            Dim query As String
            query = "select * from db_pos.product where product_name = '" & txt_pName.Text & "'"
            Try
                Dim x As Integer = CInt(txt_mPrice.Text)
                Dim y As Integer = CInt(txt_fPrice.Text)
                If x < y Then
                    MsgBox("ERROR: Selling Price Can't be Greater than Capital Price")
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox("Invalid Price Input!")
                Exit Sub
            End Try
            If PosFunction.noMatchFound(query) Then
                Dim addQuery As String
                addQuery = "insert into db_pos.product (bar_code, category_code, product_name, price, stock, quantity, vat_exempted, zero_rated, pcs_per_item, factory_price) values ('" & txt_bCode.Text & "', '" & cbx_cCode.Text & "', '" & txt_pName.Text & "', '" & txt_mPrice.Text & "', '0 items', '0 pcs', '" & cbx_vExempted.Text & "', '" & cbx_zRated.Text & "', '" & txt_pcs.Text & "', '" & txt_fPrice.Text & "')"
                PosFunction.alterTable(addQuery)
                If PosFunction.alterSuccess Then
                    MsgBox("Succesfully Added")
                Else
                    MsgBox("Adding Failed " & PosFunction.alterMessage)
                End If
                query = "select bar_code as 'Barcode', category_code as 'Category Code', product_name as 'Product Name',
                                       price as 'Price', stock as 'Stocks', quantity as 'Quantity', factory_price as 'Factory Price' 
                                       from db_pos.product"
                PosFunction.fill_dgv(frm_InvMngt.dgv_product, query)
                PosFunction.fillAutoComplete(frm_InvMngt.txt_nameSearch, "select product_name from db_pos.product")
                PosFunction.fillAutoComplete(frm_InvMngt.txt_idSearch, "select bar_code from db_pos.product")
            Else
                MsgBox("Product Already exist!")
            End If
        Else
            MsgBox("Incomplete Entry")
        End If
    End Sub

    Private Sub frm_addProduct_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        form_shown = False
    End Sub

    Private Sub txt_pcs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pcs.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_bCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bCode.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class