<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Viewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Viewer))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtn_print = New System.Windows.Forms.ToolStripButton()
        Me.txbtn_zoomin = New System.Windows.Forms.ToolStripButton()
        Me.tsbtn_zoomout = New System.Windows.Forms.ToolStripButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtn_print, Me.txbtn_zoomin, Me.tsbtn_zoomout})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(709, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtn_print
        '
        Me.tsbtn_print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtn_print.Image = CType(resources.GetObject("tsbtn_print.Image"), System.Drawing.Image)
        Me.tsbtn_print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtn_print.Name = "tsbtn_print"
        Me.tsbtn_print.Size = New System.Drawing.Size(23, 22)
        Me.tsbtn_print.Text = "Print"
        '
        'txbtn_zoomin
        '
        Me.txbtn_zoomin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.txbtn_zoomin.Image = CType(resources.GetObject("txbtn_zoomin.Image"), System.Drawing.Image)
        Me.txbtn_zoomin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.txbtn_zoomin.Name = "txbtn_zoomin"
        Me.txbtn_zoomin.Size = New System.Drawing.Size(23, 22)
        Me.txbtn_zoomin.Text = "Zoom In"
        '
        'tsbtn_zoomout
        '
        Me.tsbtn_zoomout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtn_zoomout.Image = CType(resources.GetObject("tsbtn_zoomout.Image"), System.Drawing.Image)
        Me.tsbtn_zoomout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtn_zoomout.Name = "tsbtn_zoomout"
        Me.tsbtn_zoomout.Size = New System.Drawing.Size(23, 22)
        Me.tsbtn_zoomout.Text = "Zoom Out"
        Me.tsbtn_zoomout.ToolTipText = "Zoom Out"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintPreviewControl1.Document = Me.PrintDocument1
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(0, 25)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(709, 526)
        Me.PrintPreviewControl1.TabIndex = 1
        Me.PrintPreviewControl1.Zoom = 0.47909090909090907R
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'frm_Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 551)
        Me.Controls.Add(Me.PrintPreviewControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frm_Viewer"
        Me.Text = "frm_Viewer"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbtn_print As ToolStripButton
    Friend WithEvents txbtn_zoomin As ToolStripButton
    Friend WithEvents tsbtn_zoomout As ToolStripButton
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewControl1 As PrintPreviewControl
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
