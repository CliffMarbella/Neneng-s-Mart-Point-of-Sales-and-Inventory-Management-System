Public Class frm_manageStock

    Public Shared form_shown As Boolean
    Delegate Sub ComboDelegate()
    Public Shared selected As String
    Public Shared cbxItemCount As Integer
    Public Shared cbx As ComboBox

    Private Sub frm_manageStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        form_shown = True
        fill_dgv()
        PosFunction.fillCbx(cbx_cCodeItem, "select category_name from db_pos.category")
        cbxItemCount = cbx_cCodeItem.Items.Count
        cbx = cbx_cCodeItem
    End Sub

    Public Sub fill_dgv()
        Dim query As String
        query = "select item_id as 'Item ID', bar_code as 'Barcode', category_code as 'Category Code', 
                                       DATE_FORMAT(exp_date,""%Y-%m-%d"") as 'Expiration Date' from db_pos.items"
        PosFunction.fill_dgv(dgv_item, query)
    End Sub

    Private Sub frm_manageStock_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        form_shown = False
    End Sub

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

    Private Sub cbx_cCodeItem_TextChanged(sender As Object, e As EventArgs) Handles cbx_cCodeItem.TextChanged
        cbx_pCode.SelectedItem = ""
        If cbx_cCodeItem.SelectedIndex <> 0 Then
            Dim query As String = "select product_name from db_pos.product where category_code = '" & cbx_cCodeItem.Text & "'"
            PosFunction.fillCbx(cbx_pCode, query)
        Else
            cbx_pCode.Text = ""
            cbx_pCode.Items.Clear()
        End If
        clearItbx()
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

    Private Sub clearItbx()
        If String.IsNullOrWhiteSpace(cbx_cCodeItem.Text) And String.IsNullOrWhiteSpace(cbx_pCode.Text) And txt_eDate.Text = "YYYY-MM-DD" Then
            fill_dgv()
        End If
    End Sub

    Private Sub txt_quantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_quantity.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgv_item_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_item.CellClick
        If e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow
            row = Me.dgv_item.Rows(e.RowIndex)
            cbx_cCodeItem.Text = row.Cells("Category Code").Value.ToString
            cbx_pCode.Text = row.Cells("Barcode").Value.ToString
            txt_eDate.Text = row.Cells("Expiration Date").Value.ToString.Replace("12:00:00 AM", "")
            selected = row.Cells("Item ID").Value.ToString
        End If
    End Sub

    Private Sub cbx_pCode_TextChanged(sender As Object, e As EventArgs) Handles cbx_pCode.TextChanged
        clearItbx()
    End Sub

    Private Sub txt_eDate_TextChanged(sender As Object, e As EventArgs) Handles txt_eDate.TextChanged
        clearItbx()
    End Sub

    Private Sub pb_date_Click(sender As Object, e As EventArgs) Handles pb_date.Click
        MsgBox("Date Format (YYYY-MM-DD) Ex: 1999-04-15", MsgBoxStyle.Information, "Help")
    End Sub

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

    Private Sub btn_addItem_Click(sender As Object, e As EventArgs) Handles btn_addItem.Click
        If frm_main.connected Then
            If Not String.IsNullOrWhiteSpace(cbx_cCodeItem.Text) And Not String.IsNullOrWhiteSpace(cbx_pCode.Text) And Not String.IsNullOrWhiteSpace(txt_quantity.Text) And Not txt_eDate.Text = "YYYY-MM-DD" Then
                Dim addQuery As String = "insert into db_pos.items (bar_code, category_code, exp_date) values ('" & cbx_pCode.Text & "', '" & cbx_cCodeItem.Text & "', '" & txt_eDate.Text & "')"
                Dim stock = CType(PosFunction.getElement("product", "bar_code", cbx_pCode.Text, "stock").Replace("items", ""), Double) + CInt(txt_quantity.Text)
                Dim updateQuery As String = "update db_pos.product set stock = '" & stock & " items', quantity = '" & stock * CInt(PosFunction.getElement("product", "bar_code", cbx_pCode.Text, "pcs_per_item")) & " pcs' where bar_code = '" & cbx_pCode.Text & "'"
                For x = 1 To CInt(txt_quantity.Text)
                    PosFunction.alterTable(addQuery)
                Next
                If PosFunction.alterSuccess Then
                    MsgBox("Successfuly Added")
                    PosFunction.alterTable(updateQuery)
                    If Not PosFunction.alterSuccess Then
                        MsgBox(PosFunction.alterMessage)
                    End If
                    fill_dgv()
                    Dim query As String = "select bar_code as 'Barcode', category_code as 'Category Code', product_name as 'Product Name',
                                       price as 'Price', stock as 'Stocks', quantity as 'Quantity', factory_price as 'Factory Price' 
                                       from db_pos.product"
                    PosFunction.fill_dgv(frm_InvMngt.dgv_product, query)
                    cbx_cCodeItem.Text = ""
                    cbx_pCode.Text = ""
                    txt_quantity.Text = ""
                    txt_eDate.Text = "YYYY-MM-DD"
                Else
                    MsgBox("Invalid Date Format!")
                End If

            Else
                MsgBox("Incomplete Entry!")
            End If
        Else
            MsgBox("Error connection")
        End If
    End Sub

    Private Sub btn_deleteItem_Click(sender As Object, e As EventArgs) Handles btn_deleteItem.Click
        If frm_main.connected Then
            Dim itemID As String = selected
            If Not PosFunction.noMatchFound("select * from db_pos.items where item_id = '" & itemID & "'") Then
                Dim ans = MsgBox("Are you sure you want to delete item - " & itemID & "?", vbYesNo + MsgBoxStyle.Exclamation)
                If ans = vbYes Then
                    Dim query As String = "delete from db_pos.items where item_id = '" & itemID & "'"
                    Dim con = PosFunction.getElement("items", "item_id", itemID, "bar_code")
                    PosFunction.alterTable(query)
                    If PosFunction.alterSuccess Then
                        PosFunction.decrementStock(con)
                        fill_dgv()
                        query = "select bar_code as 'Barcode', category_code as 'Category Code', product_name as 'Product Name',
                                       price as 'Price', stock as 'Stocks', quantity as 'Quantity', factory_price as 'Factory Price' 
                                       from db_pos.product"
                        PosFunction.fill_dgv(frm_InvMngt.dgv_product, query)
                        MsgBox("Delete Successful")
                    Else
                        MsgBox("Deleting Failed: " & PosFunction.alterMessage)
                    End If
                End If
            Else
                MsgBox("Item Not Found")
            End If
        Else
            MsgBox("Error connection")
        End If
    End Sub

    Private Sub btn_clearItem_Click(sender As Object, e As EventArgs) Handles btn_clearItem.Click
        cbx_cCodeItem.Text = ""
        cbx_pCode.Text = ""
        txt_eDate.Text = "YYYY-MM-DD"
    End Sub

    Private Sub btn_editItem_Click(sender As Object, e As EventArgs) Handles btn_editItem.Click
        If Not String.IsNullOrWhiteSpace(selected) And Not PosFunction.noMatchFound("select * from db_pos.items where item_id = '" & selected & "'") Then
            Dim obj As New frm_editItem
            obj.edit = "item"
            obj.TopMost = True
            obj.ShowDialog()
        Else
            MsgBox("No item seleccted")
        End If
    End Sub

    Private Sub btn_searchItem_Click(sender As Object, e As EventArgs) Handles btn_searchItem.Click
        If frm_main.connected Then
            Dim query As String
            Dim tbl As String = "item"
            query = "select item_id as 'Item ID', bar_code as 'Barcode', category_code as 'Category Code', 
                           DATE_FORMAT(exp_date,""%Y-%m-%d"") as 'Expiration Date' from db_pos.items where bar_code = '" & cbx_pCode.Text & "' and/*0*/ 
                            category_code = '" & cbx_cCodeItem.Text & "' and/*1*/ exp_date = '" & txt_eDate.Text & "'"
            If String.IsNullOrWhiteSpace(cbx_cCodeItem.Text) And String.IsNullOrWhiteSpace(cbx_pCode.Text) And txt_eDate.Text.Equals("YYYY-MM-DD") Then
                MsgBox("Please Enter Any Value")
            Else
                PosFunction.fill_dgv(dgv_item, filteredItem(query))
            End If
        Else
            MsgBox("Error Connection")
        End If
    End Sub

    Private Function filteredItem(query As String) As String
        Dim blnArr(3) As Boolean
        Dim strArr(3) As String
        strArr(0) = "bar_code = '' and/*0*/ "
        strArr(1) = "category_code = '' and/*1*/ "
        strArr(2) = "exp_date = 'YYYY-MM-DD'"

        If String.IsNullOrWhiteSpace(cbx_pCode.Text) Then
            blnArr(0) = False
        Else
            blnArr(0) = True
        End If

        If String.IsNullOrWhiteSpace(cbx_cCodeItem.Text) Then
            blnArr(1) = False
        Else
            blnArr(1) = True
        End If

        If txt_eDate.Text = "YYYY-MM-DD" Then
            blnArr(2) = False
        Else
            blnArr(2) = True
        End If

        For x = 0 To 2
            query = query.Replace(strArr(x), vbNullString)
        Next

        If blnArr(2) = False Then
            Dim hgst As Integer
            For x = 0 To 1
                If blnArr(x) = True Then
                    hgst = x
                End If
            Next
            If hgst = 0 Then
                query = query.Replace("and/*0*/", vbNullString)
            ElseIf hgst = 1 Then
                query = query.Replace("and/*1*/", vbNullString)
            End If
        End If
        Return query
    End Function
End Class