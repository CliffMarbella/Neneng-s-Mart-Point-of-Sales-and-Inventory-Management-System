Public Class frm_dailyReport

    Public Property dgv As DataGridView

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim p As Point
        Dim strings As New StringFormat
        Dim str As String
        Dim fon As Font

        fon = New Font(FontFamily.GenericSerif, 25, FontStyle.Bold)
        p = New Point(50, 50)
        str = "Intitial Amount " & DateTime.Now.ToString("yyyy-MM-dd") & " : " & frm_welcome.initialAmount
        e.Graphics.DrawString(str, fon, Brushes.Black, p, strings)

        Dim y As Integer
        Dim xPos As Integer = 0
        Dim width As Integer = 0
        Dim height As Integer = 0
        Dim endPos As Integer = 0
        fon = New Font(FontFamily.GenericSerif, 10, FontStyle.Regular)
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
    End Sub

    Private Sub btn_zoomIn_Click(sender As Object, e As EventArgs) 

    End Sub
End Class