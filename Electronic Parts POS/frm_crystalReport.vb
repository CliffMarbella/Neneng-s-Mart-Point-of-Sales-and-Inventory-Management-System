Imports System.IO
Imports System.Drawing
Imports System.Drawing.Printing
Public Class frm_crystalReport

    Dim bm As Bitmap
    Dim fon As Font
    Dim strings As New StringFormat
    Dim p As Point
    Dim str As String

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim rec As Rectangle

        fillHeaders(e, frm_salesReport.lbl_month.Text)

        rec = New Rectangle(50, 250, 412, 275)
        frm_salesReport.chrt_1.Printing.PrintPaint(e.Graphics, rec)

        rec = New Rectangle(50, 250 + 275 + 50, 412, 275)
        frm_salesReport.chrt_2.Printing.PrintPaint(e.Graphics, rec)

        str = "Sales Revenue"
        fon = New Font(FontFamily.GenericSerif, 15, FontStyle.Regular)
        p = New Point(50 + 412 + 10, 250)
        e.Graphics.DrawString(str, fon, Brushes.Black, p, strings)

        str = "₱  " & frm_salesReport.lbl_sRev.Text
        fon = New Font(FontFamily.GenericSerif, 15, FontStyle.Regular)
        p = New Point(835 - e.Graphics.MeasureString(str, fon).Width - 20, 250)
        e.Graphics.DrawString(str, fon, Brushes.ForestGreen, p, strings)

        str = "Average Sales"
        fon = New Font(FontFamily.GenericSerif, 15, FontStyle.Regular)
        p = New Point(50 + 412 + 10, 280)
        e.Graphics.DrawString(str, fon, Brushes.Black, p, strings)

        str = "₱  " & frm_salesReport.lbl_aSales.Text
        fon = New Font(FontFamily.GenericSerif, 15, FontStyle.Regular)
        p = New Point(835 - e.Graphics.MeasureString(str, fon).Width - 20, 280)
        e.Graphics.DrawString(str, fon, Brushes.ForestGreen, p, strings)

        str = "Discounts"
        fon = New Font(FontFamily.GenericSerif, 15, FontStyle.Regular)
        p = New Point(50 + 412 + 10, 310)
        e.Graphics.DrawString(str, fon, Brushes.Black, p, strings)

        str = "₱  " & frm_salesReport.lbl_mDisc.Text
        fon = New Font(FontFamily.GenericSerif, 15, FontStyle.Regular)
        p = New Point(835 - e.Graphics.MeasureString(str, fon).Width - 20, 310)
        e.Graphics.DrawString(str, fon, Brushes.ForestGreen, p, strings)

        str = "Gross Profit"
        fon = New Font(FontFamily.GenericSerif, 15, FontStyle.Regular)
        p = New Point(50 + 412 + 10, 340)
        e.Graphics.DrawString(str, fon, Brushes.Black, p, strings)

        str = "₱  " & frm_salesReport.lbl_gProfit.Text
        fon = New Font(FontFamily.GenericSerif, 15, FontStyle.Regular)
        p = New Point(835 - e.Graphics.MeasureString(str, fon).Width - 20, 340)
        e.Graphics.DrawString(str, fon, Brushes.ForestGreen, p, strings)

        str = "No. of Transactions"
        fon = New Font(FontFamily.GenericSerif, 15, FontStyle.Regular)
        p = New Point(50 + 412 + 10, 575)
        e.Graphics.DrawString(str, fon, Brushes.Black, p, strings)

        str = frm_salesReport.lbl_mTransc.Text
        fon = New Font(FontFamily.GenericSerif, 15, FontStyle.Regular)
        p = New Point(835 - e.Graphics.MeasureString(str, fon).Width - 20, 575)
        e.Graphics.DrawString(str, fon, Brushes.ForestGreen, p, strings)

        str = "Sold Items"
        fon = New Font(FontFamily.GenericSerif, 15, FontStyle.Regular)
        p = New Point(50 + 412 + 10, 605)
        e.Graphics.DrawString(str, fon, Brushes.Black, p, strings)

        str = frm_salesReport.lbl_mIsold.Text
        fon = New Font(FontFamily.GenericSerif, 15, FontStyle.Regular)
        p = New Point(835 - e.Graphics.MeasureString(str, fon).Width - 20, 605)
        e.Graphics.DrawString(str, fon, Brushes.ForestGreen, p, strings)

    End Sub

    Private Sub fillHeaders(e As Printing.PrintPageEventArgs, dt As String)

        Dim img As Image = ImageList1.Images(1)
        e.Graphics.DrawImage(img, 50, 50)

        str = "Neneng's Mart"
        fon = New Font(FontFamily.GenericSerif, 40, FontStyle.Bold)
        p = New Point(250, 50)
        e.Graphics.DrawString(str, fon, Brushes.Black, p, strings)

        str = "Crystal Report"
        fon = New Font(FontFamily.GenericSerif, 20, FontStyle.Bold)
        p = New Point(330, 50 + e.Graphics.MeasureString(str, New Font(FontFamily.GenericSerif, 40, FontStyle.Bold)).Height)
        e.Graphics.DrawString(str, fon, Brushes.DarkGray, p, strings)

        str = dt
        fon = New Font(FontFamily.GenericSerif, 15, FontStyle.Bold)
        p = New Point(50, 200)
        e.Graphics.DrawString(str, fon, Brushes.RoyalBlue, p, strings)
    End Sub

    Private Sub PrintDocument1_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        PrintDocument1.DefaultPageSettings.Margins = New Margins(20, 20, 20, 20)
    End Sub

    Private Sub btn_zoomIn_Click(sender As Object, e As EventArgs) Handles btn_zoomIn.Click
        PrintPreviewControl1.Zoom = PrintPreviewControl1.Zoom + 0.2
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub btn_zoomOut_Click(sender As Object, e As EventArgs) Handles btn_zoomOut.Click
        PrintPreviewControl1.Zoom = 0.67909090909090908
    End Sub
End Class