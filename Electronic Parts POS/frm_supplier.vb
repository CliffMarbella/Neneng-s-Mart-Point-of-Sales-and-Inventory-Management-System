Public Class frm_supplier

    Private Sub frm_supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fill_dgv()
    End Sub

    Private Sub fill_dgv()
        Dim query As String
        query = "select supplier_code as 'Supplier Code', supplier_name as 'Supplier', supplier_address as 'Address'
                        from db_pos.supplier"
        PosFunction.alterTable("alter table db_pos.supplier auto_increment = 10001")
        PosFunction.fill_dgv(dgv_supplier, query)
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim query As String
        If Not String.IsNullOrWhiteSpace(txt_address.Text) And Not String.IsNullOrWhiteSpace(txt_supplier.Text) Then
            query = "insert into db_pos.supplier(supplier_name, supplier_address) values ('" & txt_supplier.Text & "', '" & txt_address.Text & "')"
            PosFunction.alterTable(query)
            If PosFunction.alterSuccess Then
                fill_dgv()
                MsgBox("Successfully Added", MsgBoxStyle.Information)
            Else
                MsgBox(PosFunction.alterMessage)
            End If
        Else
            MsgBox("Incomplete Entry!", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class