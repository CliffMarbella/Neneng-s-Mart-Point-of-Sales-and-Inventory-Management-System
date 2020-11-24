<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_restoreCategory
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_nMatchC = New System.Windows.Forms.Label()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_restore = New System.Windows.Forms.Button()
        Me.txt_category = New System.Windows.Forms.TextBox()
        Me.dgv_category = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_category, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_nMatchC)
        Me.GroupBox3.Controls.Add(Me.btn_new)
        Me.GroupBox3.Controls.Add(Me.btn_restore)
        Me.GroupBox3.Controls.Add(Me.txt_category)
        Me.GroupBox3.Controls.Add(Me.dgv_category)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox3.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(337, 227)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Select Restore Point"
        '
        'lbl_nMatchC
        '
        Me.lbl_nMatchC.AutoSize = True
        Me.lbl_nMatchC.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nMatchC.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_nMatchC.Location = New System.Drawing.Point(204, 17)
        Me.lbl_nMatchC.Name = "lbl_nMatchC"
        Me.lbl_nMatchC.Size = New System.Drawing.Size(127, 15)
        Me.lbl_nMatchC.TabIndex = 38
        Me.lbl_nMatchC.Text = "No Matches Found"
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(209, 165)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(108, 27)
        Me.btn_new.TabIndex = 22
        Me.btn_new.Text = "New Category"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_restore
        '
        Me.btn_restore.Location = New System.Drawing.Point(209, 196)
        Me.btn_restore.Name = "btn_restore"
        Me.btn_restore.Size = New System.Drawing.Size(108, 25)
        Me.btn_restore.TabIndex = 20
        Me.btn_restore.Text = "Enter"
        Me.btn_restore.UseVisualStyleBackColor = True
        '
        'txt_category
        '
        Me.txt_category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_category.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_category.Location = New System.Drawing.Point(18, 167)
        Me.txt_category.Name = "txt_category"
        Me.txt_category.Size = New System.Drawing.Size(185, 21)
        Me.txt_category.TabIndex = 19
        '
        'dgv_category
        '
        Me.dgv_category.AllowUserToAddRows = False
        Me.dgv_category.AllowUserToDeleteRows = False
        Me.dgv_category.AllowUserToResizeColumns = False
        Me.dgv_category.AllowUserToResizeRows = False
        Me.dgv_category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_category.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_category.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgv_category.Location = New System.Drawing.Point(18, 35)
        Me.dgv_category.MultiSelect = False
        Me.dgv_category.Name = "dgv_category"
        Me.dgv_category.ReadOnly = True
        Me.dgv_category.RowHeadersVisible = False
        Me.dgv_category.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_category.Size = New System.Drawing.Size(299, 126)
        Me.dgv_category.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(113, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 15)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Category List"
        '
        'frm_restoreCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(343, 230)
        Me.Controls.Add(Me.GroupBox3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(359, 269)
        Me.MinimumSize = New System.Drawing.Size(359, 269)
        Me.Name = "frm_restoreCategory"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_category, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbl_nMatchC As Label
    Friend WithEvents btn_new As Button
    Friend WithEvents btn_restore As Button
    Friend WithEvents txt_category As TextBox
    Friend WithEvents dgv_category As DataGridView
    Friend WithEvents Label12 As Label
End Class
