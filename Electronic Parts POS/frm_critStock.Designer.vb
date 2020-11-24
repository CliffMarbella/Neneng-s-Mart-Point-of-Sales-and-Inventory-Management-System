<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_critStock
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
        Me.dgv_product = New System.Windows.Forms.DataGridView()
        Me.dgv_item = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgv_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_item, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_product
        '
        Me.dgv_product.AllowUserToAddRows = False
        Me.dgv_product.AllowUserToDeleteRows = False
        Me.dgv_product.AllowUserToResizeColumns = False
        Me.dgv_product.AllowUserToResizeRows = False
        Me.dgv_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_product.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_product.Location = New System.Drawing.Point(12, 53)
        Me.dgv_product.MultiSelect = False
        Me.dgv_product.Name = "dgv_product"
        Me.dgv_product.ReadOnly = True
        Me.dgv_product.RowHeadersVisible = False
        Me.dgv_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_product.Size = New System.Drawing.Size(449, 374)
        Me.dgv_product.TabIndex = 12
        '
        'dgv_item
        '
        Me.dgv_item.AllowUserToAddRows = False
        Me.dgv_item.AllowUserToDeleteRows = False
        Me.dgv_item.AllowUserToResizeColumns = False
        Me.dgv_item.AllowUserToResizeRows = False
        Me.dgv_item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_item.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_item.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_item.Location = New System.Drawing.Point(467, 53)
        Me.dgv_item.MultiSelect = False
        Me.dgv_item.Name = "dgv_item"
        Me.dgv_item.ReadOnly = True
        Me.dgv_item.RowHeadersVisible = False
        Me.dgv_item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_item.Size = New System.Drawing.Size(249, 374)
        Me.dgv_item.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Critical Stocks"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(464, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nearly Expired Stocks"
        '
        'frm_critStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(728, 480)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_item)
        Me.Controls.Add(Me.dgv_product)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frm_critStock"
        CType(Me.dgv_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_item, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_product As DataGridView
    Friend WithEvents dgv_item As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
