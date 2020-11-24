Imports System.IO
Imports System.Drawing
Imports System.Drawing.Printing
Public Class frm_Viewer

    Public Property dgv As DataGridView
    Public Property discount As String
    Public Property tDue As String
    Public Property cash As String
    Public Property chage As String

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim str As String
        Dim fon As Font
        fon = New Font(FontFamily.GenericSerif, 15, FontStyle.Bold)
        Dim strings As New StringFormat
        Dim p As Point
        Dim y As Integer
        Dim bm As Bitmap

        printHeaders(e)

        str = "Date : " & frm_PosSystem.transactionTime.ToString
        p = New Point(20, 200)
        e.Graphics.DrawString(str, fon, Brushes.Black, p, strings)

        str = "Employee Name : " & LoginForm1.user_info
        p = New Point(835 - e.Graphics.MeasureString(str, fon).Width(), 200)
        e.Graphics.DrawString(str, fon, Brushes.Black, p, strings)

        str = "Invoice NO. : " & frm_PosSystem.invoiceID
        p = New Point(20, 200 + e.Graphics.MeasureString(str, fon).Height + 5)
        e.Graphics.DrawString(str, fon, Brushes.Black, p, strings)

        str = "Employee ID : " & LoginForm1.user_id
        p = New Point(835 - e.Graphics.MeasureString(str, fon).Width, 200 + e.Graphics.MeasureString(str, fon).Height + 5)
        e.Graphics.DrawString(str, fon, Brushes.Black, p, strings)

        bm = New Bitmap(dgv.Width, dgv.Height)
        Dim rec As New Rectangle(20, 270, dgv.Width, dgv.Height)
        'dgv.DrawToBitmap(bm, rec)
        'e.Graphics.DrawImage(bm, 0, 0)

        Dim xPos As Integer = 0
        Dim width As Integer = 0
        Dim height As Integer = 0
        Dim endPos As Integer = 0
        For x = 0 To dgv.ColumnCount - 1
            xPos = xPos + 20 + width
            e.Graphics.DrawString(dgv.Columns(x).HeaderText, fon, Brushes.DarkKhaki, xPos, 270, strings)
            width = dgv.Rows(y).Cells(x).Size.Width
        Next


        Dim yPos As Integer = 290
        For y = 0 To dgv.RowCount - 1
            xPos = 0
            width = 0
            yPos = yPos + 10 + height
            For x = 0 To dgv.Rows(y).Cells.Count - 1
                xPos = xPos + 20 + width
                e.Graphics.DrawString(dgv.Rows(y).Cells(x).Value.ToString, fon, Brushes.Black, xPos, yPos, strings)
                width = dgv.Rows(y).Cells(x).Size.Width
            Next
            height = dgv.Rows(y).Height
            endPos = yPos
        Next

        str = "Discount :   ₱ " & discount
        y = rec.X + endPos + 20
        p = New Point(20, y)
        e.Graphics.DrawString(str, fon, Brushes.RoyalBlue, p, strings)

        str = "Total Due :  ₱ " & tDue
        y = y + e.Graphics.MeasureString(str, fon).Height
        p = New Point(20, y)
        e.Graphics.DrawString(str, fon, Brushes.RoyalBlue, p, strings)

        str = "Cash :       ₱ " & cash
        y = y + e.Graphics.MeasureString(str, fon).Height
        p = New Point(20, y)
        e.Graphics.DrawString(str, fon, Brushes.RoyalBlue, p, strings)

        str = "Change :       ₱ " & chage
        y = y + e.Graphics.MeasureString(str, fon).Height
        p = New Point(20, y)
        e.Graphics.DrawString(str, fon, Brushes.RoyalBlue, p, strings)

        str = " Thank you for shopping with us"
        y = y + e.Graphics.MeasureString(str, fon).Height
        p = New Point(280, y + 50)
        e.Graphics.DrawString(str, fon, Brushes.DarkGray, p, strings)
    End Sub

    Private Sub printHeaders(e As Printing.PrintPageEventArgs)
        Dim str As String
        Dim fon As Font
        Dim strings As New StringFormat
        Dim p As Point

        str = "Neneng's Mart"
        fon = New Font(FontFamily.GenericSerif, 40, FontStyle.Bold)
        p = New Point(250, 50)
        e.Graphics.DrawString(str, fon, Brushes.Blue, p, strings)

        str = "Sales Receipt"
        fon = New Font(FontFamily.GenericSerif, 20, FontStyle.Regular)
        p = New Point(340, 120)
        e.Graphics.DrawString(str, fon, Brushes.Black, p, strings)
    End Sub

    Private Sub txbtn_zoomin_Click(sender As Object, e As EventArgs) Handles txbtn_zoomin.Click
        PrintPreviewControl1.Zoom = PrintPreviewControl1.Zoom + 0.2
    End Sub

    Private Sub tsbtn_zoomout_Click(sender As Object, e As EventArgs) Handles tsbtn_zoomout.Click
        PrintPreviewControl1.AutoZoom = True
    End Sub

    Private Sub PrintDocument1_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        PrintDocument1.DefaultPageSettings.Margins = New Margins(20, 20, 20, 20)
    End Sub

    Private Sub tsbtn_print_Click(sender As Object, e As EventArgs) Handles tsbtn_print.Click
        PrintDialog1.ShowDialog()
    End Sub
End Class