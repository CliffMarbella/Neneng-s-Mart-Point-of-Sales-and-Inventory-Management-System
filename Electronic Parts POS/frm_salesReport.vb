Imports MySql.Data.MySqlClient

Public Class frm_salesReport

    Public Shared connection As New MySqlConnection
    Dim finishLoading As Boolean
    Public Shared month As String

#Region "Form Load"
    Private Sub frm_salesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tc_salesReport.SelectedIndex = 0
        fillLabels()
        fillCharts()
    End Sub

    Private Sub tc_salesReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tc_salesReport.SelectedIndexChanged
        If tc_salesReport.SelectedIndex = 2 Then
            fill_T_dgv()
            cbx_mnth.SelectedIndex = 0
            cbx_day.SelectedIndex = 0
        ElseIf tc_salesReport.SelectedIndex = 0 Then
            fillLabels()
            fillCharts()
        ElseIf tc_salesReport.SelectedIndex = 1 Then
            startUp()
            fillMonthCharts()
            fillMonthLabels()
        End If
    End Sub

    Public Shared Sub dbConnect()
        Dim conString As String = "server=" & LoginForm1.server_address & "; port=" & LoginForm1.server_port & "; userId=" & LoginForm1.user_name & "; password=" & LoginForm1.pass_word & "; database=" & LoginForm1.schema_name & ";"
        connection.ConnectionString = conString
    End Sub
#End Region

#Region "Tab Transaction"

    Private Sub fill_T_dgv()
        finishLoading = False
        Dim query As String
        query = "select transaction_id as 'Transaction ID', transaction_datetime as 'Date And Time',
                        invoice_no as 'Invoice ID', transaction_profit as 'Profit', cost_due as 'Cost Due',
                        quantity_sold as 'Quantity', discount as 'Discount' from db_pos.transaction"
        PosFunction.fill_dgv(dgv_transaction, query)
        finishLoading = True
        Dim qty, disc As DataGridViewColumn
        qty = dgv_transaction.Columns(5)
        disc = dgv_transaction.Columns(6)
        dgv_transaction.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_transaction.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        qty.Width = 66
        disc.Width = 71
    End Sub

    Private Sub fill_IS_dgv(tId As String)
        Dim query As String
        query = "select product_name as 'Product Name', quantity as 'Quantity' from db_pos.product_sold where transaction_id = '" & tId & "'"
        PosFunction.fill_dgv(dgv_pSold, query)
        Dim qty As DataGridViewColumn
        qty = dgv_pSold.Columns(1)
        dgv_pSold.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        qty.Width = 66
    End Sub

    Private Sub dgv_transaction_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_transaction.RowEnter
        If finishLoading Then
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.dgv_transaction.Rows(e.RowIndex)
                lbl_tId.Text = "Transaction ID : " & row.Cells("Transaction ID").Value.ToString
                lbl_dateTime.Text = "Date And Time : " & row.Cells("Date And Time").Value.ToString
                fill_IS_dgv(row.Cells("Transaction ID").Value.ToString)
            End If
        End If
    End Sub

    Private Sub btn_id_Click(sender As Object, e As EventArgs) Handles btn_id.Click
        finishLoading = False
        Dim query As String
        query = "select transaction_id as 'Transaction ID', transaction_datetime as 'Date And Time',
                        invoice_no as 'Invoice ID', transaction_profit as 'Profit', cost_due as 'Cost Due',
                        quantity_sold as 'Quantity', discount as 'Discount' from db_pos.transaction
                         where transaction_id = '" & txt_id.Text & "'"
        PosFunction.fill_dgv(dgv_transaction, query)
        finishLoading = True
        Dim qty, disc As DataGridViewColumn
        qty = dgv_transaction.Columns(5)
        disc = dgv_transaction.Columns(6)
        dgv_transaction.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_transaction.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        qty.Width = 66
        disc.Width = 71
    End Sub

    Private Sub txt_id_TextChanged(sender As Object, e As EventArgs) Handles txt_id.TextChanged
        If String.IsNullOrWhiteSpace(txt_id.Text) Then
            fill_T_dgv()
        End If
    End Sub

    Private Sub btn_report_Click(sender As Object, e As EventArgs) Handles btn_report.Click
        If cbx_mnth.SelectedIndex <> 0 And cbx_day.SelectedIndex <> 0 Then
            Dim obj As New frm_dailyReport
            obj.TopMost = True
            obj.dgv = dgv_transaction
            obj.Show()
        End If
    End Sub

#Region "For Cbx"
    Private Function getMonth(mnth As String) As Integer
        Select Case mnth
            Case "Jan"
                Return 1
            Case "Feb"
                Return 2
            Case "Mar"
                Return 3
            Case "Apr"
                Return 4
            Case "May"
                Return 5
            Case "Jun"
                Return 6
            Case "Jul"
                Return 7
            Case "Aug"
                Return 8
            Case "Sep"
                Return 9
            Case "Oct"
                Return 10
            Case "Nov"
                Return 11
            Case "Dec"
                Return 12
            Case Else
                Return 0
        End Select
    End Function

    Private Sub fliter_dgv_T(query As String)
        finishLoading = False
        PosFunction.fill_dgv(dgv_transaction, query)
        finishLoading = True
        Dim qty, disc As DataGridViewColumn
        qty = dgv_transaction.Columns(5)
        disc = dgv_transaction.Columns(6)
        dgv_transaction.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgv_transaction.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        qty.Width = 66
        disc.Width = 71
    End Sub

    Private Sub cbx_mnth_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbx_mnth.SelectionChangeCommitted
        Dim query As String
        If Not cbx_mnth.SelectedIndex = 0 Then
            If Not cbx_day.SelectedIndex = 0 Then
                query = "select transaction_id as 'Transaction ID', transaction_datetime as 'Date And Time', invoice_no as 'Invoice ID',
                                transaction_profit as 'Profit', cost_due as 'Cost Due', quantity_sold as 'Quantity', discount as 'Discount' 
                                from db_pos.transaction where Month(transaction_datetime) = '" & getMonth(cbx_mnth.SelectedItem) & "' 
                                and day(transaction_datetime) = '" & CInt(cbx_day.SelectedItem) & "'"
                fliter_dgv_T(query)
            Else
                query = "select transaction_id as 'Transaction ID', transaction_datetime as 'Date And Time', invoice_no as 'Invoice ID', 
                                transaction_profit as 'Profit', cost_due as 'Cost Due', quantity_sold as 'Quantity', discount as 'Discount'
                                from db_pos.transaction where Month(transaction_datetime) = '" & getMonth(cbx_mnth.SelectedItem) & "'"
                fliter_dgv_T(query)
            End If
        Else
            If Not cbx_day.SelectedIndex = 0 Then
                query = "select transaction_id as 'Transaction ID', transaction_datetime as 'Date And Time', invoice_no as 'Invoice ID',
                                transaction_profit as 'Profit', cost_due as 'Cost Due', quantity_sold as 'Quantity', discount as 'Discount'
                                from db_pos.transaction where Day(transaction_datetime) = '" & CInt(cbx_day.SelectedItem) & "'"
                fliter_dgv_T(query)
            Else
                fill_T_dgv()
            End If
        End If
    End Sub

    Private Sub cbx_day_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbx_day.SelectionChangeCommitted
        Dim query As String
        If Not cbx_day.SelectedIndex = 0 Then
            If Not cbx_mnth.SelectedIndex = 0 Then
                query = "select transaction_id as 'Transaction ID', transaction_datetime as 'Date And Time', invoice_no as 'Invoice ID',
                                transaction_profit as 'Profit', cost_due as 'Cost Due', quantity_sold as 'Quantity', discount as 'Discount'
                                from db_pos.transaction where Month(transaction_datetime) = '" & getMonth(cbx_mnth.SelectedItem) & "' 
                                and day(transaction_datetime) = '" & CInt(cbx_day.SelectedItem) & "'"
                fliter_dgv_T(query)
            Else
                query = "select transaction_id as 'Transaction ID', transaction_datetime as 'Date And Time', invoice_no as 'Invoice ID',
                                transaction_profit as 'Profit', cost_due as 'Cost Due', quantity_sold as 'Quantity', discount as 'Discount'
                                from db_pos.transaction where Day(transaction_datetime) = '" & CInt(cbx_day.SelectedItem) & "'"
                fliter_dgv_T(query)
            End If
        Else
            If Not cbx_mnth.SelectedIndex = 0 Then
                query = "select transaction_id as 'Transaction ID', transaction_datetime as 'Date And Time', invoice_no as 'Invoice ID',
                                transaction_profit as 'Profit', cost_due as 'Cost Due', quantity_sold as 'Quantity', discount as 'Discount'
                                from db_pos.transaction where Month(transaction_datetime) = '" & getMonth(cbx_mnth.SelectedItem) & "'"
                fliter_dgv_T(query)
            Else
                fill_T_dgv()
            End If
        End If
    End Sub
#End Region

#End Region

#Region "Universal method"

    Public Shared Function getElement(tbl As String, col As String, row As String, find As String) As String
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim query As String = "select * from db_pos." & tbl & " where " & col & " = '" & row & "'"
        Dim temp As String
        dbConnect()
        Try
            connection.Open()
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            If reader.Read() Then
                temp = reader(find)
                Return temp
            Else
                Return vbNullString
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "get element")
            Return vbNullString
        Finally
            connection.Close()
        End Try
    End Function

    Private Function getTranscElement(query As String, clmn As String) As Double
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        dbConnect()
        Try
            connection.Open()
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            If reader.Read Then
                Return reader(clmn)
            Else
                Return vbNullString
            End If
        Catch ex As Exception
            Return vbNullString
        Finally
            connection.Close()
        End Try
    End Function

#End Region

#Region "Today sales"
    Private Sub fillCharts()
        Dim query As String
        chrt_tSales.Series(0).Points.Clear()
        chrt_tTransc.Series(0).Points.Clear()
        chrt_profit.Series(0).Points.Clear()
        chrt_iSold.Series(0).Points.Clear()
        query = "select cost_due as 'cy', DATE_FORMAT(transaction_datetime,'%h:%i %p') as 'cx' from db_pos.transaction where date(transaction_datetime) = '" & DateTime.Now().ToString("yyyy-MM-dd") & "'"
        PosFunction.fillChart(chrt_tSales, "sr_tSales", query, "cx", "cy")
        query = "select count(*) as 'cy', DATE_FORMAT(transaction_datetime,'%h:%00 %p') as 'cx' from db_pos.transaction where date(transaction_datetime) = '" & DateTime.Now().ToString("yyyy-MM-dd") & "' group by cx;"
        PosFunction.fillChart(chrt_tTransc, "sr_tTransc", query, "cx", "cy")
        query = "select transaction_profit as 'cy', DATE_FORMAT(transaction_datetime,'%h:%i %p') as 'cx' from db_pos.transaction where date(transaction_datetime) = '" & DateTime.Now().ToString("yyyy-MM-dd") & "'"
        PosFunction.fillChart(chrt_profit, "sr_profit", query, "cx", "cy")
        query = "select sum(quantity_sold) as 'cy', DATE_FORMAT(transaction_datetime,'%h:%00 %p') as 'cx' from db_pos.transaction where date(transaction_datetime) = '" & DateTime.Now().ToString("yyyy-MM-dd") & "' group by cx;"
        PosFunction.fillChart(chrt_iSold, "sr_iSold", query, "cx", "cy")
    End Sub

    Private Sub fillLabels()
        Dim query As String
        query = "select sum(cost_due) as 'clmn' from db_pos.transaction where date(transaction_datetime) = '" & DateTime.Now.ToString("yyyy-MM-dd") & "'"
        lbl_rev.Text = getTranscElement(query, "clmn").ToString("#,##0.00")
        query = "select sum(transaction_profit) as 'clmn' from db_pos.transaction where date(transaction_datetime) = '" & DateTime.Now.ToString("yyyy-MM-dd") & "'"
        lbl_prof.Text = getTranscElement(query, "clmn").ToString("#,##0.00")
        query = "select count(*) as 'clmn' from db_pos.transaction where date(transaction_datetime) = '" & DateTime.Now.ToString("yyyy-MM-dd") & "'"
        lbl_transc.Text = getTranscElement(query, "clmn")
        query = "select sum(discount) as 'clmn' from db_pos.transaction where date(transaction_datetime) = '" & DateTime.Now.ToString("yyyy-MM-dd") & "'"
        lbl_disc.Text = getTranscElement(query, "clmn").ToString("#,##0.00")
        query = "select sum(quantity_sold) as 'clmn' from db_pos.transaction where date(transaction_datetime) = '" & DateTime.Now.ToString("yyyy-MM-dd") & "'"
        lbl_item.Text = getTranscElement(query, "clmn")
    End Sub
#End Region

#Region "Monthly Sales"

    Private Sub startUp()
        month = DateTime.Now.ToString("yyyy-MM")
        lbl_month.Text = "Sales Report As Of " & DateTime.Now.ToString("y").Replace("/", " ")
        cbx_month.SelectedItem = DateTime.Now.ToString("MM")
    End Sub

    Private Sub fillMonthCharts()
        Dim query As String
        chrt_1.Series(0).Points.Clear()
        chrt_1.Series(1).Points.Clear()
        chrt_1.Series(2).Points.Clear()
        chrt_1.Series(3).Points.Clear()
        chrt_2.Series(0).Points.Clear()
        chrt_2.Series(1).Points.Clear()
        chrt_3.Series(0).Points.Clear()

        query = "select sum(transaction_profit) as 'cy', date_format(transaction_datetime, '%d/%c/%Y') as 'cx' from db_pos.transaction where date_format(transaction_datetime, '%Y-%c') = '" & month & "' group by cx"
        PosFunction.fillChart(chrt_1, "sr_profit", query, "cx", "cy")
        query = "select sum(cost_due) as 'cy', date_format(transaction_datetime, '%d/%c/%Y') as 'cx' from db_pos.transaction where date_format(transaction_datetime, '%Y-%c') = '" & month & "' group by cx"
        PosFunction.fillChart(chrt_1, "sr_revenue", query, "cx", "cy")
        query = "select sum(discount) as 'cy', date_format(transaction_datetime, '%d/%c/%Y') as 'cx' from db_pos.transaction where date_format(transaction_datetime, '%Y-%c') = '" & month & "' group by cx"
        PosFunction.fillChart(chrt_1, "sr_discount", query, "cx", "cy")
        query = "select avg(cost_due) as 'cy', date_format(transaction_datetime, '%d/%c/%Y') as 'cx' from db_pos.transaction where date_format(transaction_datetime, '%Y-%c') = '" & month & "' group by cx"
        PosFunction.fillChart(chrt_1, "sr_average", query, "cx", "cy")
        query = "select count(*) as 'cy', date_format(transaction_datetime, '%d/%c/%Y') as 'cx' from db_pos.transaction where date_format(transaction_datetime, '%Y-%c') = '" & month & "' group by cx"
        PosFunction.fillChart(chrt_2, "sr_transc", query, "cx", "cy")
        query = "select sum(quantity_sold) as 'cy', date_format(transaction_datetime, '%d/%c/%Y') as 'cx' from db_pos.transaction where date_format(transaction_datetime, '%Y-%c') = '" & month & "' group by cx"
        PosFunction.fillChart(chrt_2, "sr_item", query, "cx", "cy")
        query = "select sum(transaction_profit) * 100 / sum(cost_due) as 'cy', (1 - ( sum(transaction_profit) / sum(cost_due))) * 100 as 'cx'  from db_pos.transaction where date_format(transaction_datetime, '%Y-%c') = '" & month & "';"
        PosFunction.filTestChart(chrt_3, "sr_margin", query, "cx", "cy")
    End Sub

    Private Sub fillMonthLabels()
        Dim query As String
        query = "select sum(cost_due) as 'clmn' from db_pos.transaction where date_format(transaction_datetime, '%Y-%c') = '" & month & "'"
        lbl_sRev.Text = getTranscElement(query, "clmn").ToString("#,##")
        query = "select sum(cost_due) / count(cost_due) as 'clmn' from db_pos.transaction where date_format(transaction_datetime, '%Y-%c') = '" & month & "'"
        lbl_aSales.Text = getTranscElement(query, "clmn").ToString("#,##")
        query = "select count(*) as 'clmn' from db_pos.transaction where date_format(transaction_datetime, '%Y-%c') = '" & month & "'"
        lbl_mTransc.Text = getTranscElement(query, "clmn")
        query = "select sum(discount) as 'clmn' from db_pos.transaction where date_format(transaction_datetime, '%Y-%c') = '" & month & "'"
        lbl_mDisc.Text = getTranscElement(query, "clmn").ToString("#,##")
        query = "select sum(quantity_sold) as 'clmn' from db_pos.transaction where date_format(transaction_datetime, '%Y-%c') = '" & month & "'"
        lbl_mIsold.Text = getTranscElement(query, "clmn")
        query = "select sum(transaction_profit) as 'clmn' from db_pos.transaction where date_format(transaction_datetime, '%Y-%c') = '" & month & "'"
        lbl_gProfit.Text = getTranscElement(query, "clmn").ToString("#,##")
    End Sub

    Private Sub cbx_month_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbx_month.SelectionChangeCommitted
        month = DateTime.Now.ToString("yyyy") & "-" & cbx_month.SelectedItem
        lbl_month.Text = "Sales Report As Of " & getMnth(CInt(cbx_month.SelectedItem)) & " " & DateTime.Now.ToString("yyyy")
        fillMonthCharts()
        fillMonthLabels()
    End Sub

    Private Function getMnth(mnt As Integer) As String
        Select Case mnt
            Case 1
                Return "January"
            Case 2
                Return "February"
            Case 3
                Return "March"
            Case 4
                Return "April"
            Case 5
                Return "May"
            Case 6
                Return "June"
            Case 7
                Return "July"
            Case 8
                Return "August"
            Case 9
                Return "September"
            Case 10
                Return "October"
            Case 11
                Return "November"
            Case 12
                Return "December"
            Case Else
                Return vbNullString
        End Select
    End Function

    Private Sub btn_crystalReport_Click(sender As Object, e As EventArgs) Handles btn_crystalReport.Click
        frm_crystalReport.TopMost = True
        frm_crystalReport.Show()
    End Sub
#End Region

End Class