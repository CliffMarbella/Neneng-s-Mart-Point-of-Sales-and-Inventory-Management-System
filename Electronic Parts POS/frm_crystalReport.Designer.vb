<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_crystalReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_crystalReport))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_print = New System.Windows.Forms.ToolStripButton()
        Me.btn_zoomIn = New System.Windows.Forms.ToolStripButton()
        Me.btn_zoomOut = New System.Windows.Forms.ToolStripButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_print, Me.btn_zoomIn, Me.btn_zoomOut})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(709, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_print
        '
        Me.btn_print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_print.Image = CType(resources.GetObject("btn_print.Image"), System.Drawing.Image)
        Me.btn_print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(23, 22)
        Me.btn_print.Text = "Print"
        '
        'btn_zoomIn
        '
        Me.btn_zoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_zoomIn.Image = CType(resources.GetObject("btn_zoomIn.Image"), System.Drawing.Image)
        Me.btn_zoomIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_zoomIn.Name = "btn_zoomIn"
        Me.btn_zoomIn.Size = New System.Drawing.Size(23, 22)
        Me.btn_zoomIn.Text = "Zoom In"
        '
        'btn_zoomOut
        '
        Me.btn_zoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_zoomOut.Image = CType(resources.GetObject("btn_zoomOut.Image"), System.Drawing.Image)
        Me.btn_zoomOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_zoomOut.Name = "btn_zoomOut"
        Me.btn_zoomOut.Size = New System.Drawing.Size(23, 22)
        Me.btn_zoomOut.Text = "Zoom Out"
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.AutoZoom = False
        Me.PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintPreviewControl1.Document = Me.PrintDocument1
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(0, 25)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(709, 526)
        Me.PrintPreviewControl1.TabIndex = 1
        Me.PrintPreviewControl1.Zoom = 0.67909090909090908R
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "final icon.ico")
        Me.ImageList1.Images.SetKeyName(1, "final icon.png")
        '
        'frm_crystalReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 551)
        Me.Controls.Add(Me.PrintPreviewControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frm_crystalReport"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_print As ToolStripButton
    Friend WithEvents btn_zoomIn As ToolStripButton
    Friend WithEvents btn_zoomOut As ToolStripButton
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewControl1 As PrintPreviewControl
    Friend WithEvents ImageList1 As ImageList
End Class
