<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_editCategory
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_nMatchC = New System.Windows.Forms.Label()
        Me.btn_searchCategory = New System.Windows.Forms.Button()
        Me.btn_editCategory = New System.Windows.Forms.Button()
        Me.btn_deleteCategory = New System.Windows.Forms.Button()
        Me.txt_category = New System.Windows.Forms.TextBox()
        Me.btn_addCategory = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dgv_category = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_category, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_nMatchC)
        Me.GroupBox3.Controls.Add(Me.btn_searchCategory)
        Me.GroupBox3.Controls.Add(Me.btn_editCategory)
        Me.GroupBox3.Controls.Add(Me.btn_deleteCategory)
        Me.GroupBox3.Controls.Add(Me.txt_category)
        Me.GroupBox3.Controls.Add(Me.btn_addCategory)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.dgv_category)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox3.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(337, 227)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Manage Category"
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
        'btn_searchCategory
        '
        Me.btn_searchCategory.Location = New System.Drawing.Point(173, 194)
        Me.btn_searchCategory.Name = "btn_searchCategory"
        Me.btn_searchCategory.Size = New System.Drawing.Size(64, 23)
        Me.btn_searchCategory.TabIndex = 22
        Me.btn_searchCategory.Text = "Search"
        Me.btn_searchCategory.UseVisualStyleBackColor = True
        '
        'btn_editCategory
        '
        Me.btn_editCategory.Location = New System.Drawing.Point(94, 194)
        Me.btn_editCategory.Name = "btn_editCategory"
        Me.btn_editCategory.Size = New System.Drawing.Size(64, 23)
        Me.btn_editCategory.TabIndex = 21
        Me.btn_editCategory.Text = "Edit"
        Me.btn_editCategory.UseVisualStyleBackColor = True
        '
        'btn_deleteCategory
        '
        Me.btn_deleteCategory.Location = New System.Drawing.Point(253, 194)
        Me.btn_deleteCategory.Name = "btn_deleteCategory"
        Me.btn_deleteCategory.Size = New System.Drawing.Size(64, 23)
        Me.btn_deleteCategory.TabIndex = 20
        Me.btn_deleteCategory.Text = "Delete"
        Me.btn_deleteCategory.UseVisualStyleBackColor = True
        '
        'txt_category
        '
        Me.txt_category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_category.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_category.Location = New System.Drawing.Point(96, 167)
        Me.txt_category.Name = "txt_category"
        Me.txt_category.Size = New System.Drawing.Size(221, 21)
        Me.txt_category.TabIndex = 19
        '
        'btn_addCategory
        '
        Me.btn_addCategory.Location = New System.Drawing.Point(18, 194)
        Me.btn_addCategory.Name = "btn_addCategory"
        Me.btn_addCategory.Size = New System.Drawing.Size(63, 23)
        Me.btn_addCategory.TabIndex = 19
        Me.btn_addCategory.Text = "Add"
        Me.btn_addCategory.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(15, 170)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 15)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Category : "
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
        'frm_editCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(343, 230)
        Me.Controls.Add(Me.GroupBox3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(359, 269)
        Me.MinimumSize = New System.Drawing.Size(359, 269)
        Me.Name = "frm_editCategory"
        Me.Text = "frm_editCategory"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_category, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbl_nMatchC As Label
    Friend WithEvents btn_searchCategory As Button
    Friend WithEvents btn_editCategory As Button
    Friend WithEvents btn_deleteCategory As Button
    Friend WithEvents txt_category As TextBox
    Friend WithEvents btn_addCategory As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents dgv_category As DataGridView
    Friend WithEvents Label12 As Label
End Class
