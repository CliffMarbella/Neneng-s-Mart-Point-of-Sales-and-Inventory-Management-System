Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class PosFunction

#Region "initialize variable"
    Shared connection As New MySqlConnection
    Public Shared alterSuccess As Boolean
    Public Shared alterMessage As String
#End Region

#Region "for connection"
    Private Shared Sub dbConnect()
        Dim conString As String = "server=" & LoginForm1.server_address & "; port=" & LoginForm1.server_port & "; userId=" & LoginForm1.user_name & "; password=" & LoginForm1.pass_word & "; database=" & LoginForm1.schema_name & ";"
        connection.ConnectionString = conString
    End Sub
#End Region

    Public Shared Sub fillAutoComplete(txt As TextBox, query As String)
        Dim command As MySqlCommand
        Dim adapter As MySqlDataAdapter
        Dim table As New DataTable
        dbConnect()
        Try
            connection.Open()
            command = New MySqlCommand(query, connection)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(table)
            txt.AutoCompleteCustomSource.Clear()
            For i = 0 To table.Rows.Count - 1
                txt.AutoCompleteCustomSource.Add(table.Rows(i).Item(0).ToString)
            Next
            adapter.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message & "fill auto complete")
        Finally
            connection.Close()
        End Try
    End Sub

    Public Shared Sub fillCbx(cbx As ComboBox, query As String)
        Dim command As MySqlCommand
        Dim adapter As MySqlDataAdapter
        Dim table As New DataTable
        dbConnect()
        Try
            connection.Open()
            command = New MySqlCommand(query, connection)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(table)
            cbx.Items.Clear()
            cbx.Items.Add("")
            For i = 0 To table.Rows.Count - 1
                cbx.Items.Add(table.Rows(i).Item(0).ToString)
            Next
            adapter.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message & "fill cbx")
        Finally
            connection.Close()
        End Try
    End Sub

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
            Return vbNullString
        Finally
            connection.Close()
        End Try
    End Function

    Public Shared Function noMatchFound(query As String) As Boolean
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        dbConnect()
        Try
            connection.Open()
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader()
            If reader.Read() Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return True
        Finally
            connection.Close()
        End Try
    End Function

    Public Shared Function getId(tbl As String, thisClmn As String, whereClmn As String, clmnElmnt As String) As Integer()
        Dim max As Integer
        Dim min As Integer
        Dim counter As Integer
        Dim arr(CInt(getAggregate("select count(" & thisClmn & ") as 'column' from db_pos." & tbl & " where " & whereClmn & " = '" & clmnElmnt & "'", "column")) - 1) As Integer
        Dim query As String
        max = getAggregate("select max(" & thisClmn & ") as 'column' from db_pos." & tbl & " where " & whereClmn & " = '" & clmnElmnt & "'", "column")
        min = getAggregate("select min(" & thisClmn & ") as 'column' from db_pos." & tbl & " where " & whereClmn & " = '" & clmnElmnt & "'", "column")
        counter = 0
        For y = min To max
            query = "select * from db_pos." & tbl & " where " & thisClmn & " = '" & y & "' and " & whereClmn & " = '" & clmnElmnt & "'"
            If Not noMatchFound(query) Then
                arr(counter) = y
                counter = counter + 1
            End If
        Next
        Return arr
    End Function

    Public Shared Sub alterTable(query As String)
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        dbConnect()
        Try
            connection.Open()
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            alterSuccess = True
            reader.Close()
        Catch ex As Exception
            alterMessage = ex.Message & "alter t able"
            alterSuccess = False
        Finally
            connection.Close()
        End Try
    End Sub

    Public Shared Sub decrementStock(pCode As String)
        If Not CInt(getElement("product", "bar_code", pCode, "stock").Replace("items", "")) = 0 Then
            Dim stock = CType(getElement("product", "bar_code", pCode, "stock").Replace("items", ""), Double) - 1
            Dim quantity = stock * CInt(getElement("product", "bar_code", pCode, "pcs_per_item"))
            Dim query As String = "update db_pos.product set stock = '" & stock & " items', quantity = '" & quantity & " pcs' where bar_code = '" & pCode & "'"
            alterTable(query)
            If Not alterSuccess Then
                MsgBox(alterMessage)
            End If
        End If
    End Sub

    Public Shared Function getAggregate(query As String, column As String) As Integer
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        dbConnect()
        Try
            connection.Open()
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            If reader.Read Then
                Return CInt(reader(column))
            Else
                Return 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        Finally
            connection.Close()
        End Try
    End Function

    Public Shared Function dateAggregate(query As String, column As String) As Date
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        dbConnect()
        Try
            connection.Open()
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            If reader.Read Then
                Return reader(column)
            Else
                Return ""
            End If
        Catch ex As Exception
            Return ""
        Finally
            connection.Close()
        End Try
    End Function

    Public Shared Sub fill_dgv(dgv As DataGridView, query As String)
        Dim command As MySqlCommand
        Dim adapter As MySqlDataAdapter
        Dim bindsource As New BindingSource
        Dim table As New DataTable
        dbConnect()
        Try
            connection.Open()
            command = New MySqlCommand(query, connection)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(table)
            bindsource.DataSource = table
            dgv.DataSource = bindsource
            adapter.Update(table)
            adapter.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message & "fill dgv")
        Finally
            connection.Close()
        End Try
    End Sub

    Public Shared Function convertDate(str As String) As String
        Dim arr() = str.ToCharArray
        Return arr(6) & arr(7) & arr(8) & arr(9) & "-" & arr(3) & arr(4) & "-" & arr(0) & arr(1)
    End Function

    Public Shared Function incrementId(query As String) As String()
        Dim arr() As String
        Dim command As MySqlCommand
        Dim adapter As MySqlDataAdapter
        Dim table As New DataTable
        dbConnect()
        Try
            connection.Open()
            command = New MySqlCommand(query, connection)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(table)
            ReDim arr(table.Rows.Count - 1)
            For i = 0 To table.Rows.Count - 1
                arr(i) = (table.Rows(i).Item(0).ToString)
            Next
            adapter.Dispose()
            Return arr
        Catch ex As Exception
            Dim arrDummy() As String = {"", ""}
            Return arrDummy
            MsgBox(ex.Message & "increment id")
        Finally
            connection.Close()
        End Try
    End Function

    Public Shared Function outOfStock(quantity As Integer, pCode As String) As Boolean
        Dim pcs As Integer = CInt(getElement("product", "bar_code", pCode, "quantity").Replace("pcs", ""))
        If pcs <> 0 Then
            If pcs > quantity Then
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function

    Public Shared Sub showAuthentication()
        Dim obj As New frm_pin
        obj.ShowDialog()
    End Sub

    Public Shared Sub fillChart(chrt As Chart, series As String, query As String, clmnX As String, clmnY As String)
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        dbConnect()
        Try
            connection.Open()
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            While reader.Read
                chrt.Series(series).Points.AddXY(CType(reader(clmnX), DateTime), reader.GetDouble(clmnY))
            End While
            reader.Close()
        Catch ex As Exception

        Finally
            connection.Close()
        End Try
    End Sub

    Public Shared Sub filTestChart(chrt As Chart, series As String, query As String, clmnX As String, clmnY As String)
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        dbConnect()
        Try
            connection.Open()
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            While reader.Read
                chrt.Series(series).Points.Add(0)
                chrt.Series(series).Points.Add(1)
                chrt.Series(series).Points(0).LegendText = "Profit Margin"
                chrt.Series(series).Points(1).LegendText = "Cost"
                chrt.Series(series).Points(0).YValues(0) = reader.GetDouble(clmnX)
                chrt.Series(series).Points(1).YValues(0) = reader.GetDouble(clmnY)
            End While
            reader.Close()
        Catch ex As Exception

        Finally
            connection.Close()
        End Try
    End Sub

    Public Shared Function boxEmpty(pcs_per_item As Integer, quantity As Integer) As Boolean
        If quantity Mod pcs_per_item <> 0 Then
            Return False
        Else
            Return True
        End If
    End Function
End Class
