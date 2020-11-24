<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_archive
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
        Me.cbx_filter = New System.Windows.Forms.ComboBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.btn_restore = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_archive = New System.Windows.Forms.DataGridView()
        Me.btn_delete = New System.Windows.Forms.Button()
        CType(Me.dgv_archive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbx_filter
        '
        Me.cbx_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_filter.FormattingEnabled = True
        Me.cbx_filter.Items.AddRange(New Object() {"Category", "Product"})
        Me.cbx_filter.Location = New System.Drawing.Point(14, 33)
        Me.cbx_filter.Name = "cbx_filter"
        Me.cbx_filter.Size = New System.Drawing.Size(140, 21)
        Me.cbx_filter.TabIndex = 1
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.SystemColors.Control
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btn_back.Location = New System.Drawing.Point(602, 445)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(113, 32)
        Me.btn_back.TabIndex = 2
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'txt_id
        '
        Me.txt_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_id.Location = New System.Drawing.Point(14, 452)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(222, 20)
        Me.txt_id.TabIndex = 3
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.SystemColors.Control
        Me.btn_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btn_search.Location = New System.Drawing.Point(244, 445)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(113, 32)
        Me.btn_search.TabIndex = 4
        Me.btn_search.Text = "Name Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'btn_restore
        '
        Me.btn_restore.BackColor = System.Drawing.SystemColors.Control
        Me.btn_restore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_restore.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btn_restore.Location = New System.Drawing.Point(363, 445)
        Me.btn_restore.Name = "btn_restore"
        Me.btn_restore.Size = New System.Drawing.Size(113, 32)
        Me.btn_restore.TabIndex = 5
        Me.btn_restore.Text = "Restore"
        Me.btn_restore.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(318, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Archive"
        '
        'dgv_archive
        '
        Me.dgv_archive.AllowUserToAddRows = False
        Me.dgv_archive.AllowUserToDeleteRows = False
        Me.dgv_archive.AllowUserToResizeColumns = False
        Me.dgv_archive.AllowUserToResizeRows = False
        Me.dgv_archive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_archive.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_archive.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_archive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_archive.Location = New System.Drawing.Point(12, 60)
        Me.dgv_archive.MultiSelect = False
        Me.dgv_archive.Name = "dgv_archive"
        Me.dgv_archive.ReadOnly = True
        Me.dgv_archive.RowHeadersVisible = False
        Me.dgv_archive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_archive.Size = New System.Drawing.Size(704, 374)
        Me.dgv_archive.TabIndex = 11
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.SystemColors.Control
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btn_delete.Location = New System.Drawing.Point(483, 445)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(113, 32)
        Me.btn_delete.TabIndex = 12
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'frm_archive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(728, 480)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.dgv_archive)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_restore)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.cbx_filter)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_archive"
        Me.Text = "frm_archive"
        CType(Me.dgv_archive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbx_filter As ComboBox
    Friend WithEvents btn_back As Button
    Friend WithEvents txt_id As TextBox
    Friend WithEvents btn_search As Button
    Friend WithEvents btn_restore As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_archive As DataGridView
    Friend WithEvents btn_delete As Button
End Class
