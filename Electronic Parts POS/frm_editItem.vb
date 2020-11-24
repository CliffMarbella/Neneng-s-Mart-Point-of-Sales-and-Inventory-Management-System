
Public Class frm_editItem

    Public Property edit As String
    Public Property cCode As String
    Public Property cName As String
    Public Property pCode As String
    Public Property pName As String
    Public Property price As String
    Public Property zRated As String
    Public Property vExempted As String
    Public Property pcs As String
    Public Property iCode As String
    Public Property eDate As String
    Public Property fPrice As String
    Public Property cbx As New ComboBox
    Public Property previousForm As Form



    Delegate Sub ComboDelegate()
    Public Shared edi, cC, cN, pC, pN, pr, zR, vE, ppi, iC, eD, fP As String
    Public Shared save As Boolean
    Public Shared form_shown As Boolean

    Dim tempStock

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim ans As String
        ans = MsgBox("Confirm Editting?", vbYesNo)
        edi = edit
        If ans = vbYes Then
            save = True
            If edit = "category" Then
                If Not String.IsNullOrWhiteSpace(txt_cName.Text) Then
                    Dim query As String = "update db_pos.category set category_name = '" & txt_cName.Text & "' where category_code = '" & txt_cCode.Text & "'"
                    PosFunction.alterTable(query)
                    If PosFunction.alterSuccess Then
                        PosFunction.fillCbx(frm_InvMngt.cbx_cCode, "select category_name from db_pos.category")
                        MsgBox("Update Successful")
                        Dim obj As New frm_editCategory
                        obj.TopMost = True
                        obj.Show()
                    Else
                        MsgBox("Update Failed: " & PosFunction.alterMessage)
                    End If
                Else
                    messagebox()
                End If
            ElseIf edit = "product" Then
                If Not String.IsNullOrWhiteSpace(txt_pName.Text) And Not String.IsNullOrWhiteSpace(txt_price.Text) And Not String.IsNullOrWhiteSpace(cbx_vExempted.Text) And Not String.IsNullOrWhiteSpace(cbx_zRated.Text) And Not String.IsNullOrWhiteSpace(cbx_cCode.Text) And Not String.IsNullOrWhiteSpace(txt_pcs.Text) And Not String.IsNullOrWhiteSpace(txt_fPrice.Text) And Not String.IsNullOrWhiteSpace(txt_bCode.Text) Then
                    Try
                        Dim x As Integer = CInt(txt_price.Text)
                        Dim y As Integer = CInt(txt_fPrice.Text)
                        If x < y Then
                            MsgBox("ERROR: Selling Price Can't be Greater than Capital Price")
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MsgBox("Invalid Price Input!")
                        Exit Sub
                    End Try
                    Dim query As String
                    query = "Update db_pos.product set bar_code = '" & txt_bCode.Text & "', category_code = '" & cbx_cCode.Text & "', product_name = '" & txt_pName.Text & "',
                                    price = '" & txt_price.Text & "', vat_exempted = '" & cbx_vExempted.SelectedItem & "', zero_rated = '" & cbx_zRated.SelectedItem & "',
                                    pcs_per_item = '" & txt_pcs.Text & "', factory_price = '" & txt_fPrice.Text & "' where name_code = '" & txt_pCode.Text & "'"
                    PosFunction.alterTable(query)
                    If PosFunction.alterSuccess Then
                        Dim quantity = CInt(txt_pcs.Text) * CInt(PosFunction.getElement("product", "name_code", txt_pCode.Text, "stock").Replace("items", ""))
                        query = "update db_pos.product set quantity = '" & quantity & " pcs' where name_code = '" & txt_pCode.Text & "'"
                        PosFunction.alterTable(query)
                        MsgBox("Update Successful")
                        If Not PosFunction.alterSuccess Then
                            MsgBox(PosFunction.alterMessage)
                        End If
                        query = "select bar_code as 'Barcode', category_code as 'Category Code', product_name as 'Product Name',
                                       price as 'Price', stock as 'Stocks', quantity as 'Quantity', factory_price as 'Factory Price' 
                                       from db_pos.product"
                        PosFunction.fill_dgv(frm_InvMngt.dgv_product, query)
                        PosFunction.fillAutoComplete(frm_InvMngt.txt_nameSearch, "select product_name from db_pos.product")
                        PosFunction.fillAutoComplete(frm_InvMngt.txt_idSearch, "select bar_code from db_pos.product")
                    Else
                        MsgBox("Update Failed: " & PosFunction.alterMessage)
                    End If
                Else
                    messagebox()
                End If
            ElseIf edit = "item" Then
                If Not String.IsNullOrWhiteSpace(cbx_pCode.Text) And Not String.IsNullOrWhiteSpace(cbx_cCodeItem.Text) And Not txt_eDate.Text = "YYYY-MM-DD" Then
                    If Not tempStock.Equals(cbx_pCode.Text) Then
                        PosFunction.decrementStock(tempStock)
                        Dim query As String
                        query = "update db_pos.items set category_code = '" & cbx_cCodeItem.Text & "', bar_code = '" & cbx_pCode.Text & "', exp_date = '" & txt_eDate.Text & "' where item_id = '" & txt_iCode.Text & "'"
                        PosFunction.alterTable(query)
                        If PosFunction.alterSuccess Then
                            Dim stock = CType(PosFunction.getElement("product", "bar_code", cbx_pCode.Text, "stock").Replace("items", ""), Double) + 1
                            Dim quantity = stock * CInt(PosFunction.getElement("product", "bar_code", cbx_pCode.Text, "pcs_per_item"))
                            query = "update db_pos.product set stock = '" & stock & " items', quantity = '" & quantity & " pcs' where bar_code = '" & cbx_pCode.Text & "'"
                            PosFunction.alterTable(query)
                            If Not PosFunction.alterSuccess Then
                                MsgBox(PosFunction.alterMessage)
                            End If
                            frm_manageStock.fill_dgv()
                            query = "select bar_code as 'Barcode', category_code as 'Category Code', product_name as 'Product Name',
                                       price as 'Price', stock as 'Stocks', quantity as 'Quantity', factory_price as 'Factory Price' 
                                       from db_pos.product"
                            PosFunction.fill_dgv(frm_InvMngt.dgv_product, query)
                            MsgBox("Update Successful")
                        Else
                            MsgBox("Update Failed: " & PosFunction.alterMessage)
                        End If
                    Else
                        Dim query As String
                        query = "update db_pos.items set exp_date = '" & txt_eDate.Text & "' where item_id = '" & txt_iCode.Text & "'"
                        PosFunction.alterTable(query)
                        If PosFunction.alterSuccess Then
                            frm_manageStock.fill_dgv()
                            query = "select bar_code as 'Barcode', category_code as 'Category Code', product_name as 'Product Name',
                                       price as 'Price', stock as 'Stocks', quantity as 'Quantity', factory_price as 'Factory Price' 
                                       from db_pos.product"
                            PosFunction.fill_dgv(frm_InvMngt.dgv_product, query)
                            MsgBox("Update Successful")
                        Else
                            MsgBox("Update Failed: " & PosFunction.alterMessage)
                        End If
                    End If
                Else
                    messagebox()
                End If
            End If
            Me.Close()
        End If
    End Sub

    Private Sub messagebox()
        MsgBox("Incomplete Entry!")
    End Sub

    Public Sub frm_editItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        form_shown = True
        Dim ctxtMenu As New ContextMenu
        txt_eDate.ContextMenu = ctxtMenu
        save = False
        If edit = "category" Then
            pnl_product.Enabled = False
            pnl_item.Enabled = False
            txt_cCode.Text = frm_editCategory.selected
            txt_cName.Text = PosFunction.getElement("category", "category_code", frm_editCategory.selected, "category_name")
        ElseIf edit = "product" Then
            PosFunction.fillCbx(cbx_cCode, "select category_name from db_pos.category")
            pnl_category.Enabled = False
            pnl_item.Enabled = False
            txt_pCode.Text = PosFunction.getElement("product", "bar_code", frm_InvMngt.lbl_productC.Text, "name_code")
            txt_bCode.Text = frm_InvMngt.lbl_productC.Text
            txt_pName.Text = frm_InvMngt.lbl_productN.Text
            cbx_cCode.Text = PosFunction.getElement("category", "category_name", frm_InvMngt.lbl_categoryN.Text, "category_code")
            txt_price.Text = frm_InvMngt.lbl_price.Text
            cbx_zRated.SelectedItem = PosFunction.getElement("product", "name_code", txt_pCode.Text, "zero_rated")
            txt_pcs.Text = PosFunction.getElement("product", "name_code", txt_pCode.Text, "pcs_per_item")
            cbx_vExempted.SelectedItem = PosFunction.getElement("product", "name_code", txt_pCode.Text, "vat_exempted")
            txt_fPrice.Text = PosFunction.getElement("product", "name_code", txt_pCode.Text, "factory_price")
        ElseIf edit = "item" Then
            For x = 0 To frm_manageStock.cbxItemCount - 1
                cbx_cCodeItem.Items.Add(frm_manageStock.cbx.Items(x))
            Next
            pnl_category.Enabled = False
            pnl_product.Enabled = False
            txt_iCode.Text = frm_manageStock.selected
            cbx_cCodeItem.Text = PosFunction.getElement("items", "item_id", frm_manageStock.selected, "category_code")
            cbx_pCode.Text = PosFunction.getElement("items", "item_id", frm_manageStock.selected, "bar_code")
            tempStock = cbx_pCode.Text
            txt_eDate.Text = PosFunction.convertDate(PosFunction.getElement("items", "item_id", frm_manageStock.selected, "exp_date"))
        End If
    End Sub

    Private Sub frm_editItem_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        form_shown = False
    End Sub


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

#Region "For cbx_cCodeItem"
    Private Sub cbx_cCodeItem_KeyDown(sender As Object, e As KeyEventArgs) Handles cbx_cCodeItem.KeyDown
        e.SuppressKeyPress = True
    End Sub

    Private Sub cbx_cCodeItem_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbx_cCodeItem.SelectionChangeCommitted
        If cbx_cCodeItem.SelectedIndex <> 0 Then
            BeginInvoke(New ComboDelegate(AddressOf ResetCbxCcodeItem))
        End If
    End Sub

    Private Sub ResetCbxCcodeItem()
        Dim str As String = PosFunction.getElement("category", "category_name", cbx_cCodeItem.SelectedItem, "category_code")
        With cbx_cCodeItem
            .SelectedIndex = -1
            .Text = str
            .Focus()
        End With
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub frm_editItem_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        Me.BringToFront()
    End Sub

    Private Sub txt_pCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bCode.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cbx_cCodeItem_TextChanged(sender As Object, e As EventArgs) Handles cbx_cCodeItem.TextChanged
        cbx_pCode.SelectedItem = ""
        If cbx_cCodeItem.SelectedIndex <> 0 Then
            Dim query As String = "select product_name from db_pos.product where category_code = '" & cbx_cCodeItem.Text & "'"
            PosFunction.fillCbx(cbx_pCode, query)
        Else
            cbx_pCode.Text = ""
            cbx_pCode.Items.Clear()
        End If
    End Sub
#End Region

#Region "For cbx_pCode"

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
#End Region

    Private Sub txt_eDate_Enter(sender As Object, e As EventArgs) Handles txt_eDate.Enter
        If txt_eDate.Text = "YYYY-MM-DD" Then
            txt_eDate.Text = vbNullString
        End If
    End Sub

    Private Sub txt_eDate_Leave(sender As Object, e As EventArgs) Handles txt_eDate.Leave
        If String.IsNullOrWhiteSpace(txt_eDate.Text) Then
            txt_eDate.Text = "YYYY-MM-DD"
        End If
    End Sub

    Private Sub txt_eDate_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_eDate.KeyDown
        If e.KeyCode.Equals(Keys.Left) Or e.KeyCode.Equals(Keys.Right) Or e.KeyCode.Equals(Keys.Up) Or e.KeyCode.Equals(Keys.Down) Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txt_eDate_MouseCaptureChanged(sender As Object, e As EventArgs) Handles txt_eDate.MouseCaptureChanged
        txt_eDate.SelectionStart = txt_eDate.Text.Length
    End Sub

    Private Sub txt_eDate_TextChanged(sender As Object, e As EventArgs) Handles txt_eDate.TextChanged
        If txt_eDate.Text.Length = 10 And Not txt_eDate.Text = "YYYY-MM-DD" Then
            Dim arr() = txt_eDate.Text.ToCharArray
            Dim x = CInt(CType(arr(8) & arr(9), String))
            If x > 31 Then
                Dim con = ""
                For x = 0 To arr.Length - 1
                    If x = 8 Then
                        txt_eDate.Text = con & "3"
                    ElseIf x = 9 Then
                        txt_eDate.Text = con & "1"
                    Else
                        txt_eDate.Text = con & arr(x)
                    End If
                    con = txt_eDate.Text
                Next
            End If
            txt_eDate.SelectionStart = 10
        End If
    End Sub

    Private Sub txt_eDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_eDate.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            Dim arr() = txt_eDate.Text.ToCharArray
            If txt_eDate.Text.Length = 4 And Char.IsNumber(e.KeyChar) Then
                txt_eDate.Text = txt_eDate.Text & "-"
                txt_eDate.SelectionStart = 5
            End If
            If txt_eDate.Text.Length = 7 And Char.IsNumber(e.KeyChar) Then
                Dim x = CInt(CType(arr(5) & arr(6), String))
                If x > 12 Then
                    Dim con = ""
                    For x = 0 To arr.Length - 1
                        If x = 5 Then
                            txt_eDate.Text = con & "1"
                        ElseIf x = 6 Then
                            txt_eDate.Text = con & "2"
                        Else
                            txt_eDate.Text = con & arr(x)
                        End If
                        con = txt_eDate.Text
                    Next
                End If
                txt_eDate.Text = txt_eDate.Text & "-"
                txt_eDate.SelectionStart = 8
            End If
            If txt_eDate.Text.Length = 10 And Char.IsNumber(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_pcs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pcs.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class

