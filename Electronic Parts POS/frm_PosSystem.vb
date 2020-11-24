Public Class frm_PosSystem

#Region "initialize variables"
    Public Shared transactionLoaded As Boolean
    Public Shared transactionAdded As Boolean
    Public Shared transactionSaved As Boolean
    Public Shared cashEntered As Boolean
    Public Shared itemAdded As Boolean
    Public Shared transactionTime As DateTime
    Public Shared transactionID, invoiceID As String
    Public Shared selected As String
    Public Shared registrarCash As Double

    Public Shared dgv_query As String
    Public Shared cash As Double = 0

#End Region

#Region "form load"
    Private Sub frm_PosSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inital_dgv_load(dgv_pos)
        PosFunction.fillAutoComplete(txt_id, "Select bar_code from db_pos.product")
        registrarCash = frm_welcome.initialAmount
        Me.KeyPreview = True
    End Sub

    Public Shared Sub inital_dgv_load(dgv As DataGridView)
        Dim query As String
        Dim maxId As Integer
        maxId = PosFunction.getAggregate("Select max(transaction_id) As 'column' from db_pos.transaction", "column")
        query = "select product.bar_code as 'Barcode', product.product_name as 'Description', product_sold.price
                  as 'Price', product_sold.quantity as 'Quantity' from db_pos.product left join db_pos.product_sold on
                  product.product_name = product_sold.product_name where product_sold.transaction_id = '" & maxId + 1 & "'"
        PosFunction.fill_dgv(dgv, query)
        resize_column(dgv)
    End Sub
#End Region

#Region "universal method"
    Public Shared Sub resize_column(dgv As DataGridView)
        Dim id, quantity, price As DataGridViewColumn
        id = dgv.Columns(0)
        quantity = dgv.Columns(2)
        price = dgv.Columns(3)
        dgv.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        id.Width = 150
        quantity.Width = 150
        price.Width = 150
    End Sub

    Public Shared Function getQuantity(tId As String) As Integer
        Dim query As String
        query = "select sum(quantity) as 'column' from db_pos.product_sold where transaction_id = '" & tId & "'"
        Return PosFunction.getAggregate(query, "column")
    End Function

    Public Shared Function getUnitCapital(tId As String) As Double
        Dim val As Double
        Dim query As String
        query = "select product_name from db_pos.product_sold where transaction_id = '" & tId & "'"
        val = CType(PosFunction.getAggregate("select sum(factory_price) as 'column' from db_pos.product where product_name in (" & query & ")", "column"), Double)
        Return val
    End Function

    Public Shared Sub fill_dgv(dgv As DataGridView)
        Dim query As String
        query = dgv_query
        PosFunction.fill_dgv(dgv, query)
        resize_column(dgv)
    End Sub

    Public Shared Sub decrementQuantity(id As String, quantity As Integer)
        Dim query As String
        Dim newQty As Integer
        Dim newStock As Double
        newQty = CInt(PosFunction.getElement("product", "name_code", id, "quantity").Replace("pcs", "")) - quantity
        newStock = newQty / CInt(PosFunction.getElement("product", "name_code", id, "pcs_per_item"))
        query = "update db_pos.product set quantity = '" & newQty & " pcs', stock = '" & newStock.ToString("#,##0.00") & " items' where name_code = '" & id & "'"
        PosFunction.alterTable(query)
        If PosFunction.alterSuccess Then
            If PosFunction.boxEmpty(CInt(PosFunction.getElement("product", "name_code", id, "pcs_per_item")), newQty) Then
                Dim minExpDate = PosFunction.dateAggregate("select min(exp_date) as 'c' from db_pos.items where bar_code = '" & PosFunction.getElement("product", "name_code", id, "bar_code") & "'", "c")
                Dim item_id = PosFunction.getAggregate("select item_id as 'c' from db_pos.items where exp_date = '" & minExpDate.ToString("yyyy-MM-dd") & "' and bar_code = '" & PosFunction.getElement("product", "name_code", id, "bar_code") & "' order by rand() limit 1", "c")
                query = "delete from db_pos.items where item_id = '" & item_id & "'"
                PosFunction.alterTable(query)
                If Not PosFunction.alterSuccess Then
                    MsgBox(PosFunction.alterMessage)
                End If
            End If
        Else
            MsgBox(PosFunction.alterMessage)
        End If
    End Sub

    Private Sub incrementQuantity(id As String, quantity As Integer)
        Dim query As String
        Dim newQty As Integer
        Dim newStock As Double
        newQty = CInt(PosFunction.getElement("product", "name_code", id, "quantity").Replace("pcs", "")) + quantity
        newStock = newQty / CInt(PosFunction.getElement("product", "name_code", id, "pcs_per_item"))
        query = "update db_pos.product set quantity = '" & newQty & " pcs', stock = '" & newStock.ToString("#,##0.00") & " items' where name_code = '" & id & "'"
        PosFunction.alterTable(query)
        If Not PosFunction.alterSuccess Then
            MsgBox(PosFunction.alterMessage)
        End If
    End Sub

    Public Shared Sub compute(vat As Double, disc As Double, subT As Double, price As Double, txtSubT As TextBox, txtVat As TextBox, txtDisc As TextBox, txtTdue As TextBox)
        txtSubT.Text = (CType(txtSubT.Text, Double) + subT).ToString("#,##0.00")
        txtDisc.Text = (CType(txtDisc.Text, Double) + disc).ToString("#,##0.00")
        txtVat.Text = (CType(txtVat.Text, Double) + vat).ToString("#,##0.00")
        txtTdue.Text = (CType(txtTdue.Text, Double) + price).ToString("#,##0.00")
    End Sub

    Public Shared Sub reCompute(vat As Double, disc As Double, subT As Double, price As Double, txtSubT As TextBox, txtVat As TextBox, txtDisc As TextBox, txtTdue As TextBox)
        txtSubT.Text = (CType(txtSubT.Text, Double) - subT).ToString("#,##0.00")
        txtDisc.Text = (CType(txtDisc.Text, Double) - disc).ToString("#,##0.00")
        txtVat.Text = (CType(txtVat.Text, Double) - vat).ToString("#,##0.00")
        txtTdue.Text = (CType(txtTdue.Text, Double) - price).ToString("#,##0.00")
    End Sub

    Public Shared Function getSold_id(pName As String, tId As String) As String
        Return PosFunction.getAggregate("select sold_id from db_pos.product_sold where product_name = '" & pName & "' and transaction_id = '" & tId & "'", "sold_id")
    End Function

    Public Shared Sub addItem(discount As Double, quantity As Integer, transaction As String, id As String, dgv As DataGridView, txtSubT As TextBox, txtVat As TextBox, txtDisc As TextBox, txtTdue As TextBox, txtAmount As TextBox, txtChange As TextBox)
        If cashEntered Then
            Dim ans = MsgBox("Do you want to edit current transaction?", vbYesNo + MsgBoxStyle.ApplicationModal)
            If ans = vbYes Then
                addRow(discount, quantity, transaction, id, dgv, txtSubT, txtVat, txtDisc, txtTdue)
                transactionSaved = False
                cashEntered = False
                cash = 0
                txtAmount.Text = ""
                txtChange.Text = ""
            End If
        Else
            addRow(discount, quantity, transaction, id, dgv, txtSubT, txtVat, txtDisc, txtTdue)
        End If
    End Sub

    Public Shared Sub addRow(discount As Double, quantity As Integer, transaction As String, id As String, dgv As DataGridView, txtSubT As TextBox, txtVat As TextBox, txtDisc As TextBox, txtTdue As TextBox)
        Dim price, disc, subT, vat, initialPrice, initialDisc, initialSubT, initialVat As Double
        Dim query As String
        query = "select * from db_pos.product_sold where transaction_id = '" & transaction & "' and product_name =
                                      '" & PosFunction.getElement("product", "name_code", id, "product_name") & "'"
        If PosFunction.noMatchFound(query) Then
            disc = (quantity * CType(PosFunction.getElement("product", "name_code", id, "price"), Double)) * discount
            price = quantity * CType(PosFunction.getElement("product", "name_code", id, "price"), Double) - disc
            vat = (price + disc) * 0.12
            subT = (price + disc) - vat
            query = "insert into db_pos.product_sold (transaction_id, product_name, quantity, price, discount) values 
                            ('" & transaction & "', '" & PosFunction.getElement("product", "name_code", id, "product_name") & "', 
                            '" & quantity & "', '" & price & "', '" & discount & "')"
        Else
            query = "select quantity from db_pos.product_sold where transaction_id = '" & transaction & "' and 
                            product_name = '" & PosFunction.getElement("product", "name_code", id, "product_name") & "'"
            Dim initialQty As Integer = CInt(PosFunction.getAggregate(query, "quantity"))
            disc = ((initialQty + quantity) * CType(PosFunction.getElement("product", "name_code", id, "price"), Double)) * discount
            price = (initialQty + quantity) * CType(PosFunction.getElement("product", "name_code", id, "price"), Double) - disc
            vat = (price + disc) * 0.12
            subT = (price + disc) - vat
            initialDisc = initialQty * CType(PosFunction.getElement("product", "name_code", id, "price"), Double) * CType(PosFunction.getElement("product_sold", "sold_id", getSold_id(PosFunction.getElement("product", "name_code", id, "product_name"), transaction), "discount"), Double)
            initialPrice = (initialQty * CType(PosFunction.getElement("product", "name_code", id, "price"), Double)) - initialDisc
            initialVat = (initialPrice + initialDisc) * 0.12
            initialSubT = (initialPrice + initialDisc) - initialVat
            query = "update db_pos.product_sold set quantity = '" & initialQty + quantity & "', price = '" & price & "', discount = '" & discount & "' where transaction_id = '" & transaction & "'
                             and product_name = '" & PosFunction.getElement("product", "name_code", id, "product_name") & "'"
            reCompute(initialVat, initialDisc, initialSubT, initialPrice, txtSubT, txtVat, txtDisc, txtTdue)
        End If
        PosFunction.alterTable(query)
        If PosFunction.alterSuccess Then
            compute(vat, disc, subT, price, txtSubT, txtVat, txtDisc, txtTdue)
            decrementQuantity(id, quantity)
            fill_dgv(dgv)
            itemAdded = True
        Else
            MsgBox(PosFunction.alterMessage)
        End If
    End Sub

    Private Sub removeItem(tId As String, sold_id As String, qty As Integer, pName As String)
        Dim price, disc, subT, vat As Double
        Dim query As String
        query = "delete from db_pos.product_sold where sold_id = '" & sold_id & "'"
        disc = CType(PosFunction.getElement("product_sold", "sold_id", sold_id, "discount"), Double) * CInt(PosFunction.getElement("product_sold", "sold_id", sold_id, "quantity")) * CType(PosFunction.getElement("product", "product_name", pName, "price"), Double)
        price = CType(PosFunction.getElement("product_sold", "sold_id", sold_id, "price"), Double)
        vat = (price + disc) * 0.12
        subT = (price + disc) - vat
        PosFunction.alterTable(query)
        If PosFunction.alterSuccess Then
            reCompute(vat, disc, subT, price, txt_subTotal, txt_vat, txt_discount, txt_totalDue)
            incrementQuantity(PosFunction.getElement("product", "product_name", pName, "name_code"), qty)
            fill_dgv(dgv_pos)
            MsgBox("Successfully Removed", MsgBoxStyle.Information)
        Else
            MsgBox(PosFunction.alterMessage)
        End If
    End Sub

    Private Sub deleteRow()
        Dim ans = MsgBox("Delete Item " & selected & "?", vbYesNo + MsgBoxStyle.Exclamation)
        If ans = vbYes Then
            PosFunction.showAuthentication()
            If Not frm_pin.canceled Then
                If frm_pin.authenticated Then
                    Dim pName As String = PosFunction.getElement("product", "name_code", selected, "product_name")
                    Dim sold_id As String = getSold_id(pName, transactionID)
                    Dim pQty As Integer = CInt(PosFunction.getElement("product_sold", "sold_id", sold_id, "quantity"))
                    removeItem(transactionID, sold_id, pQty, pName)
                    If PosFunction.noMatchFound("select * from db_pos.product_sold where transaction_id = '" & transactionID & "'") Then
                        itemAdded = False
                    End If
                Else
                    MsgBox("Incorrect Authentication Pin", MsgBoxStyle.Exclamation)
                End If
            End If
        End If
    End Sub

    Public Shared Sub saveTransaction(txtTdue As TextBox, txtDisc As TextBox)
        Dim profit, c_due, discount As Double
        Dim qty_sold, qty_disc As Integer
        Dim query, dateStr As String
        profit = CType(txtTdue.Text, Double) - getUnitCapital(transactionID)
        c_due = CType(txtTdue.Text, Double)
        discount = CType(txtDisc.Text, Double)
        qty_sold = getQuantity(transactionID)
        qty_disc = PosFunction.getAggregate("select count(*) as 'clm' from db_pos.product_sold where transaction_id = '" & transactionID & "' and discount <> '0'", "clm")
        dateStr = transactionTime.ToString("yyyy-MM-dd HH:mm:ss")
        query = "update db_pos.transaction set transaction_datetime = '" & dateStr & "', invoice_no = '" & invoiceID & "', transaction_profit = '" & profit & "',
                                cost_due = '" & c_due & "', quantity_sold = '" & qty_sold & "', discount = '" & discount & "', discounted_sales = '" & qty_disc & "',
                                cash = '" & cash & "' where transaction_id = '" & transactionID & "'"
        PosFunction.alterTable(query)
        If PosFunction.alterSuccess Then
            transactionSaved = True
            MsgBox("Transaction Saved", MsgBoxStyle.Information)
        Else
            MsgBox("Falied: " & PosFunction.alterMessage, MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub changeQuantity()
        showInput("Enter Quantity")
        If Not String.IsNullOrWhiteSpace(frm_input.input) Then
            Dim query As String
            Dim initialQty, newQty As Integer
            Dim initialPrice, initialDisc, initialSubT, initialVat, newPrice, newDisc, newSubT, newVat As Double
            Dim pName As String = PosFunction.getElement("product", "name_code", selected, "product_name")
            initialQty = CInt(PosFunction.getElement("product_sold", "sold_id", getSold_id(pName, transactionID), "quantity"))
            newQty = CInt(frm_input.input)
            newDisc = newQty * CType(PosFunction.getElement("product", "name_code", selected, "price"), Double) * CType(PosFunction.getElement("product_sold", "sold_id", getSold_id(pName, transactionID), "discount"), Double)
            newPrice = (newQty * CType(PosFunction.getElement("product", "name_code", selected, "price"), Double)) - newDisc
            newVat = (newPrice + newDisc) * 0.12
            newSubT = (newPrice + newDisc) - newVat
            initialDisc = initialQty * CType(PosFunction.getElement("product", "name_code", selected, "price"), Double) * CType(PosFunction.getElement("product_sold", "sold_id", getSold_id(pName, transactionID), "discount"), Double)
            initialPrice = CType(PosFunction.getElement("product_sold", "sold_id", getSold_id(pName, transactionID), "price"), Double)
            initialVat = (initialPrice + initialDisc) * 0.12
            initialSubT = (initialPrice + initialDisc) - initialVat
            query = "update db_pos.product_sold set quantity = '" & newQty & "', price = '" & newPrice & "' where sold_id = '" & getSold_id(pName, transactionID) & "'"
            PosFunction.alterTable(query)
            If PosFunction.alterSuccess Then
                If newQty <> 0 Then
                    If newQty > initialQty Then
                        reCompute(initialVat, initialDisc, initialSubT, initialPrice, txt_subTotal, txt_vat, txt_discount, txt_totalDue)
                        compute(newVat, newDisc, newSubT, newPrice, txt_subTotal, txt_vat, txt_discount, txt_totalDue)
                        decrementQuantity(selected, newQty - initialQty)
                    ElseIf newQty < initialQty Then
                        compute(newVat, newDisc, newSubT, newPrice, txt_subTotal, txt_vat, txt_discount, txt_totalDue)
                        reCompute(initialVat, initialDisc, initialSubT, initialPrice, txt_subTotal, txt_vat, txt_discount, txt_totalDue)
                        incrementQuantity(selected, initialQty - newQty)
                    End If
                    fill_dgv(dgv_pos)
                Else
                    deleteRow()
                End If
            End If
        End If
    End Sub

    Public Shared Sub discardTransaction(tId As String)
        'ここにバグがあります
        'バグを破棄する --> アイテムは復元されません
        Dim newQunatity As Integer
        Dim newStock As Double
        Dim sold_id As String
        Dim query As String
        query = "select name_code from db_pos.product where product_name in (select product_name from db_pos.product_sold where transaction_id = '" & tId & "')"
        Dim arr() = PosFunction.incrementId(query)
        For x = 0 To arr.Length - 1
            sold_id = getSold_id(PosFunction.getElement("product", "name_code", arr(x), "product_name"), tId)
            newQunatity = CInt(PosFunction.getElement("product", "name_code", arr(x), "quantity").Replace("pcs", "")) + CInt(PosFunction.getElement("product_sold", "sold_id", sold_id, "quantity"))
            newStock = newQunatity / CInt(PosFunction.getElement("product", "name_code", arr(x), "pcs_per_item"))
            query = "update db_pos.product set quantity = '" & newQunatity & " pcs', stock = '" & newStock.ToString("#,##0.00") & " items' where name_code = '" & arr(x) & "'"
            PosFunction.alterTable(query)
            If Not PosFunction.alterSuccess Then
                MsgBox(PosFunction.alterMessage)
            End If
        Next
        query = "delete from db_pos.product_sold where transaction_id = '" & tId & "'"
        PosFunction.alterTable(query)
        If PosFunction.alterSuccess Then
            query = "delete from db_pos.transaction where transaction_id = '" & tId & "'"
            PosFunction.alterTable(query)
            If Not PosFunction.alterSuccess Then
                MsgBox(PosFunction.alterMessage)
            End If
        Else
            MsgBox(PosFunction.alterMessage)
        End If
    End Sub

    Public Shared Sub closeTransaction()
        transactionLoaded = False
        transactionAdded = False
        transactionSaved = False
        cashEntered = False
        itemAdded = False
        cash = 0
        transactionID = vbNullString
        invoiceID = vbNullString
        selected = vbNullString
    End Sub

    Public Shared Sub clear_dgv(dgv As DataGridView)
        inital_dgv_load(dgv)
    End Sub

    Public Shared Sub clearLbl(lblTranscId As Label, lblInvId As Label, lblTranscT As Label)
        lblTranscId.Text = vbNullString
        lblTranscT.Text = vbNullString
        lblInvId.Text = vbNullString
    End Sub

    Public Shared Sub clearTbx(txtSubT As TextBox, txtVat As TextBox, txtDisc As TextBox, txtTdue As TextBox, txtAmnt As TextBox, txtChng As TextBox)
        txtSubT.Text = 0.ToString("#,##0.00")
        txtVat.Text = 0.ToString("#,##0.00")
        txtDisc.Text = 0.ToString("#,##0.00")
        txtTdue.Text = 0.ToString("#,##0.00")
        txtAmnt.Text = vbNullString
        txtChng.Text = vbNullString
    End Sub

    Private Sub showInput(str As String)
        Dim obj As New frm_input
        obj.TopMost = True
        obj.lbl_enterInput.Text = str
        obj.ShowDialog()
    End Sub

    Private Sub addTransaction()
        Dim transaction As Integer
        Dim invoice As String
        Dim query As String
        transactionTime = DateTime.Now
        query = "alter table db_pos.transaction auto_increment = 10001"
        PosFunction.alterTable(query)
        query = "insert into db_pos.transaction (transaction_datetime) values ('" & transactionTime.ToString("yyyy-MM-dd HH:mm:ss") & "')"
        PosFunction.alterTable(query)
        transaction = PosFunction.getElement("transaction", "transaction_datetime", transactionTime.ToString("yyyy-MM-dd HH:mm:ss"), "transaction_id")
        invoice = "NV " & transaction
        lbl_transctime.Text = transactionTime
        lbl_invoiceNo.Text = invoice
        lbl_transcNo.Text = transaction
        transactionID = transaction
        invoiceID = invoice
        dgv_query = "select product.bar_code as 'Barcode', product.product_name as 'Description', product_sold.price
                  as 'Price', product_sold.quantity as 'Quantity' from db_pos.product left join db_pos.product_sold on
                  product.product_name = product_sold.product_name where transaction_id = '" & transaction & "'"
        transactionAdded = True
        MsgBox("Transaction " & transactionID & " added", MsgBoxStyle.Information)
    End Sub

    Private Sub loadTransaction(tId As String)
        If Not PosFunction.noMatchFound("select * from db_pos.transaction where transaction_id = '" & tId & "'") Then
            transactionID = tId
            invoiceID = PosFunction.getElement("transaction", "transaction_id", tId, "invoice_no")
            transactionTime = PosFunction.getElement("transaction", "transaction_id", tId, "transaction_datetime")
            lbl_transctime.Text = transactionTime
            lbl_invoiceNo.Text = invoiceID
            lbl_transcNo.Text = transactionID
            dgv_query = "select product.bar_code as 'Barcode', product.product_name as 'Description', product_sold.price
                  as 'Price', product_sold.quantity as 'Quantity' from db_pos.product left join db_pos.product_sold on
                  product.product_name = product_sold.product_name where transaction_id = '" & tId & "'"
            fill_dgv(dgv_pos)
            txt_totalDue.Text = getPrice(tId).ToString("#,##0.00")
            txt_discount.Text = getDisc(tId).ToString("#,##0.00")
            txt_vat.Text = ((getPrice(tId) + getDisc(tId)) * 0.12).ToString("#,##0.00")
            txt_subTotal.Text = ((getPrice(tId) + getDisc(tId)) - CType(txt_vat.Text, Double)).ToString("#,##0.00")
            txt_amount.Text = CType(PosFunction.getElement("transaction", "transaction_id", tId, "cash"), Double).ToString("#,##0.00")
            txt_change.Text = (CType(PosFunction.getElement("transaction", "transaction_id", tId, "cash"), Double) - CType(PosFunction.getElement("transaction", "transaction_id", tId, "cost_due"), Double)).ToString("#,##0.00")
            cash = CType(txt_amount.Text, Double)
            itemAdded = True
            transactionAdded = True
            cashEntered = True
            transactionSaved = True
            transactionLoaded = True
        Else
            MsgBox("Transaction Not Found!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Function getPrice(tId As String) As Double
        Dim arr() = PosFunction.incrementId("select sold_id from db_pos.product_sold where transaction_id = '" & tId & "'")
        Dim con As Double = 0
        For x = 0 To arr.Length - 1
            con = con + CType(PosFunction.getElement("product_sold", "sold_id", arr(x), "price"), Double)
        Next
        Return con
    End Function

    Private Function getDisc(tId As String) As Double
        Dim arr() = PosFunction.incrementId("select sold_id from db_pos.product_sold where transaction_id = '" & tId & "'")
        Dim disc As Double
        Dim con As Double = 0
        For x = 0 To arr.Length - 1
            disc = (CType(PosFunction.getElement("product_sold", "sold_id", arr(x), "price"), Double) * CType(PosFunction.getElement("product_sold", "sold_id", arr(x), "discount"), Double)) / (1 - CType(PosFunction.getElement("product_sold", "sold_id", arr(x), "discount"), Double))
            con = con + disc
        Next
        Return con
    End Function

#End Region

    Private Sub dgv_pos_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pos.RowEnter
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgv_pos.Rows(e.RowIndex)
            selected = frm_salesReport.getElement("product", "bar_code", row.Cells("Barcode").Value.ToString, "name_code")
        End If
    End Sub

    Private Sub btn_newTransc_Click(sender As Object, e As EventArgs) Handles btn_newTransc.Click
        If Not transactionAdded Then
            addTransaction()
        Else
            If transactionSaved Then
                closeTransaction()
                clear_dgv(dgv_pos)
                clearLbl(lbl_transcNo, lbl_invoiceNo, lbl_transctime)
                clearTbx(txt_subTotal, txt_vat, txt_discount, txt_totalDue, txt_amount, txt_change)
                addTransaction()
            Else
                If cashEntered Then
                    Dim ans As String = MsgBox("Do you want to save current transaction?", vbYesNoCancel + MsgBoxStyle.Information)
                    If ans = vbYes Then
                        saveTransaction(txt_totalDue, txt_discount)
                        closeTransaction()
                        clear_dgv(dgv_pos)
                        clearLbl(lbl_transcNo, lbl_invoiceNo, lbl_transctime)
                        clearTbx(txt_subTotal, txt_vat, txt_discount, txt_totalDue, txt_amount, txt_change)
                        addTransaction()
                    ElseIf ans = vbNo Then
                        discardTransaction(transactionID)
                        closeTransaction()
                        clear_dgv(dgv_pos)
                        clearLbl(lbl_transcNo, lbl_invoiceNo, lbl_transctime)
                        clearTbx(txt_subTotal, txt_vat, txt_discount, txt_totalDue, txt_amount, txt_change)
                        addTransaction()
                    End If
                Else
                    discardTransaction(transactionID)
                    closeTransaction()
                    clear_dgv(dgv_pos)
                    clearLbl(lbl_transcNo, lbl_invoiceNo, lbl_transctime)
                    clearTbx(txt_subTotal, txt_vat, txt_discount, txt_totalDue, txt_amount, txt_change)
                    addTransaction()
                End If
            End If
            End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If transactionAdded Then
            If Not frm_posAddItem.form_shown Then
                Dim obj As New frm_posAddItem
                obj.transaction = transactionID
                obj.TopMost = True
                obj.Show()
            End If
        Else
            MsgBox("Please Create A Transaction", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btn_recieve_Click(sender As Object, e As EventArgs) Handles btn_recieve.Click
        If itemAdded Then
            showInput("Enter Cash")
            If Not String.IsNullOrWhiteSpace(frm_input.input) Then
                If CType(frm_input.input, Double) >= CType(txt_totalDue.Text, Double) Then
                    cash = CType(frm_input.input, Double)
                    Dim change As Double = cash - CType(txt_totalDue.Text, Double)
                    While registrarCash <= change
                        MsgBox("Insufficient Initial Amount Input!", MsgBoxStyle.Exclamation)
                        showInput("Enter Initial Amount")
                        If Not String.IsNullOrWhiteSpace(frm_input.input) Then
                            registrarCash = frm_input.input
                        Else
                            Exit Sub
                        End If
                    End While
                    txt_amount.Text = cash.ToString("#,##0.00")
                    txt_change.Text = change.ToString("#,##0.00")
                    transactionSaved = False
                    cashEntered = True
                Else
                    MsgBox("Invalid Amount", MsgBoxStyle.Exclamation)
                End If
            End If
        Else
            MsgBox("Please Add An Item!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btn_editTransaction_Click(sender As Object, e As EventArgs) Handles btn_editTransaction.Click
        If itemAdded Then
            If Not String.IsNullOrWhiteSpace(selected) Then
                If Not cashEntered Then
                    deleteRow()
                Else
                    Dim ans = MsgBox("Do you want to edit current transaction?", vbYesNo + MsgBoxStyle.ApplicationModal)
                    If ans = vbYes Then
                        deleteRow()
                        If Not frm_pin.canceled Then
                            If frm_pin.authenticated Then
                                transactionSaved = False
                                cashEntered = False
                                cash = 0
                                txt_amount.Text = ""
                                txt_change.Text = ""
                            End If
                        End If
                    End If
                End If
            Else
                    MsgBox("No Item Selected!", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("No Items Found!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btn_discardTransaction_Click(sender As Object, e As EventArgs) Handles btn_discardTransaction.Click
        If transactionAdded Then
            If transactionSaved Then
                closeTransaction()
                clear_dgv(dgv_pos)
                clearLbl(lbl_transcNo, lbl_invoiceNo, lbl_transctime)
                clearTbx(txt_subTotal, txt_vat, txt_discount, txt_totalDue, txt_amount, txt_change)
                MsgBox("Transaction Closed", MsgBoxStyle.Information)
            Else
                Dim ans = MsgBox("Are you sure you want to discard this transaction?", vbYesNo + MsgBoxStyle.Exclamation)
                If ans = vbYes Then
                    discardTransaction(transactionID)
                    closeTransaction()
                    clear_dgv(dgv_pos)
                    clearLbl(lbl_transcNo, lbl_invoiceNo, lbl_transctime)
                    clearTbx(txt_subTotal, txt_vat, txt_discount, txt_totalDue, txt_amount, txt_change)
                    MsgBox("Transaction Discarded", MsgBoxStyle.Information)
                End If
            End If
        Else
            MsgBox("Add Transaction!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btn_changeQuantity_Click(sender As Object, e As EventArgs) Handles btn_changeQuantity.Click
        If itemAdded Then
            If Not String.IsNullOrWhiteSpace(selected) Then
                If Not cashEntered Then
                    PosFunction.showAuthentication()
                    If Not frm_pin.canceled Then
                        If frm_pin.authenticated Then
                            changeQuantity()
                        Else
                            MsgBox("Incorrect Authentication Pin", MsgBoxStyle.Exclamation)
                        End If
                    End If
                Else
                    Dim ans = MsgBox("Do you want to edit current transaction?", vbYesNo + MsgBoxStyle.ApplicationModal)
                    If ans = vbYes Then
                        PosFunction.showAuthentication()
                        If Not frm_pin.canceled Then
                            If frm_pin.authenticated Then
                                changeQuantity()
                                transactionSaved = False
                                cashEntered = False
                                cash = 0
                                txt_amount.Text = ""
                                txt_change.Text = ""
                            Else
                                MsgBox("Incorrect Authentication Pin", MsgBoxStyle.Exclamation)
                            End If
                        End If
                    End If
                End If
            Else
                MsgBox("No Item Selected!", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("No Items Found!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btn_closeTransc_Click(sender As Object, e As EventArgs) Handles btn_closeTransc.Click
        If transactionAdded Then
            If transactionSaved Then
                If Not transactionLoaded Then
                    registrarCash = registrarCash + CType(txt_totalDue.Text, Double)
                End If
                closeTransaction()
                clear_dgv(dgv_pos)
                clearLbl(lbl_transcNo, lbl_invoiceNo, lbl_transctime)
                clearTbx(txt_subTotal, txt_vat, txt_discount, txt_totalDue, txt_amount, txt_change)
                MsgBox("Transaction Closed", MsgBoxStyle.Information)
            Else
                If cashEntered Then
                    Dim ans = MsgBox("Do you want to save current transaction?", vbYesNoCancel + MsgBoxStyle.Information)
                    If ans = vbYes Then
                        If Not transactionLoaded Then
                            registrarCash = registrarCash + CType(txt_totalDue.Text, Double)
                        End If
                        saveTransaction(txt_totalDue, txt_discount)
                        closeTransaction()
                        clear_dgv(dgv_pos)
                        clearLbl(lbl_transcNo, lbl_invoiceNo, lbl_transctime)
                        clearTbx(txt_subTotal, txt_vat, txt_discount, txt_totalDue, txt_amount, txt_change)
                    ElseIf ans = vbNo Then
                        discardTransaction(transactionID)
                        closeTransaction()
                        clear_dgv(dgv_pos)
                        clearLbl(lbl_transcNo, lbl_invoiceNo, lbl_transctime)
                        clearTbx(txt_subTotal, txt_vat, txt_discount, txt_totalDue, txt_amount, txt_change)
                        MsgBox("Transaction Closed", MsgBoxStyle.Information)
                    End If
                Else
                    discardTransaction(transactionID)
                    closeTransaction()
                    clear_dgv(dgv_pos)
                    clearLbl(lbl_transcNo, lbl_invoiceNo, lbl_transctime)
                    clearTbx(txt_subTotal, txt_vat, txt_discount, txt_totalDue, txt_amount, txt_change)
                    MsgBox("Transaction Closed", MsgBoxStyle.Information)
                End If
            End If
        Else
            MsgBox("Add Transaction!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btn_loadTransc_Click(sender As Object, e As EventArgs) Handles btn_loadTransc.Click
        PosFunction.showAuthentication()
        If Not frm_pin.canceled Then
            If frm_pin.authenticated Then
                If Not transactionAdded Then
                    showInput("Enter Transaction ID")
                    If Not String.IsNullOrWhiteSpace(frm_input.input) Then
                        loadTransaction(frm_input.input)
                    End If
                Else
                    If transactionSaved Then
                        showInput("Enter Transaction ID")
                        If Not String.IsNullOrWhiteSpace(frm_input.input) Then
                            loadTransaction(frm_input.input)
                        End If
                    Else
                        If cashEntered Then
                            Dim ans = MsgBox("Do you want to save current transaction?", vbYesNoCancel + MsgBoxStyle.Information)
                            If ans = vbYes Then
                                saveTransaction(txt_totalDue, txt_discount)
                                showInput("Enter Transaction ID")
                                If Not String.IsNullOrWhiteSpace(frm_input.input) Then
                                    loadTransaction(frm_input.input)
                                End If
                            ElseIf ans = vbNo Then
                                discardTransaction(transactionID)
                                showInput("Enter Transaction ID")
                                If Not String.IsNullOrWhiteSpace(frm_input.input) Then
                                    loadTransaction(frm_input.input)
                                End If
                            End If
                        Else
                            discardTransaction(transactionID)
                            showInput("Enter Transaction ID")
                            If Not String.IsNullOrWhiteSpace(frm_input.input) Then
                                loadTransaction(frm_input.input)
                            End If
                        End If
                    End If
                End If
            Else
                MsgBox("Incorrect Authentication Pin", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub btn_calculator_Click(sender As Object, e As EventArgs) Handles btn_calculator.Click
        frm_calculator.Show()
    End Sub

    Private Sub btn_reciept_Click(sender As Object, e As EventArgs) Handles btn_reciept.Click
        If cashEntered Then
            Dim obj As New frm_Viewer
            obj.dgv = dgv_pos
            obj.discount = txt_discount.Text
            obj.tDue = txt_totalDue.Text
            obj.cash = txt_amount.Text
            obj.chage = txt_change.Text
            obj.TopMost = True
            obj.Show()
        Else
            MsgBox("Enter Payment!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btn_bCode_Click(sender As Object, e As EventArgs) Handles btn_bCode.Click
        If transactionAdded Then
            If Not PosFunction.noMatchFound("select * from db_pos.product where bar_code = '" & txt_id.Text & "'") Then
                showInput("Enter Quantity")
                If Not String.IsNullOrWhiteSpace(frm_input.input) Then
                    If Not PosFunction.outOfStock(CInt(frm_input.input), txt_id.Text) Then
                        Dim discount As Double
                        Dim sold_id As String = getSold_id(PosFunction.getElement("product", "bar_code", txt_id.Text, "product_name"), transactionID)
                        If Not PosFunction.noMatchFound("select * from db_pos.product_sold where sold_id = '" & sold_id & "'") Then
                            discount = CType(PosFunction.getElement("product_sold", "sold_id", sold_id, "discount"), Double)
                        Else
                            discount = 0
                        End If
                        If CInt(frm_input.input) <> 0 Then
                            frm_PosSystem.addItem(discount, CInt(frm_input.input), transactionID, PosFunction.getElement("product", "bar_code", txt_id.Text, "name_code"), dgv_pos, txt_subTotal, txt_vat, txt_discount, txt_totalDue, txt_amount, txt_change)
                        End If
                    Else
                        MsgBox("Out Of Stock", MsgBoxStyle.Exclamation)
                    End If
                End If
            Else
                MsgBox("Item Not Found!", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Please Create A Transaction", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btn_saveTransaction_Click(sender As Object, e As EventArgs) Handles btn_saveTransaction.Click
        If Not transactionSaved Then
            If cashEntered Then
                saveTransaction(txt_totalDue, txt_discount)
            Else
                MsgBox("No Cash Entered!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

#Region "hotkeys"

    Private Sub frm_PosSystem_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                btn_newTransc_Click(sender, e)
            Case Keys.F2
                btn_add_Click(sender, e)
            Case Keys.F3
                btn_editTransaction_Click(sender, e)
            Case Keys.F4
                btn_changeQuantity_Click(sender, e)
            Case Keys.F5
                btn_saveTransaction_Click(sender, e)
            Case Keys.F6
                btn_loadTransc_Click(sender, e)
            Case Keys.F7
                btn_discardTransaction_Click(sender, e)
            Case Keys.F8
                btn_closeTransc_Click(sender, e)
            Case Keys.F9
                btn_calculator_Click(sender, e)
            Case Keys.F10
                btn_reciept_Click(sender, e)
            Case Keys.F11
                btn_recieve_Click(sender, e)
            Case Keys.F12
                btn_bCode_Click(sender, e)
        End Select
    End Sub
#End Region
End Class