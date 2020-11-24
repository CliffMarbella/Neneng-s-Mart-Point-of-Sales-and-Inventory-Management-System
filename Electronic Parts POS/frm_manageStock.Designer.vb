<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_manageStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_manageStock))
        Me.dgv_item = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_clearItem = New System.Windows.Forms.Button()
        Me.pb_date = New System.Windows.Forms.PictureBox()
        Me.btn_searchItem = New System.Windows.Forms.Button()
        Me.btn_deleteItem = New System.Windows.Forms.Button()
        Me.btn_editItem = New System.Windows.Forms.Button()
        Me.btn_addItem = New System.Windows.Forms.Button()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbx_cCodeItem = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbx_pCode = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_eDate = New System.Windows.Forms.TextBox()
        CType(Me.dgv_item, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.pb_date, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_item
        '
        Me.dgv_item.AllowUserToAddRows = False
        Me.dgv_item.AllowUserToDeleteRows = False
        Me.dgv_item.AllowUserToResizeColumns = False
        Me.dgv_item.AllowUserToResizeRows = False
        Me.dgv_item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_item.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_item.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgv_item.Location = New System.Drawing.Point(18, 35)
        Me.dgv_item.MultiSelect = False
        Me.dgv_item.Name = "dgv_item"
        Me.dgv_item.ReadOnly = True
        Me.dgv_item.RowHeadersVisible = False
        Me.dgv_item.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_item.Size = New System.Drawing.Size(370, 200)
        Me.dgv_item.TabIndex = 18
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_clearItem)
        Me.GroupBox4.Controls.Add(Me.dgv_item)
        Me.GroupBox4.Controls.Add(Me.pb_date)
        Me.GroupBox4.Controls.Add(Me.btn_searchItem)
        Me.GroupBox4.Controls.Add(Me.btn_deleteItem)
        Me.GroupBox4.Controls.Add(Me.btn_editItem)
        Me.GroupBox4.Controls.Add(Me.btn_addItem)
        Me.GroupBox4.Controls.Add(Me.txt_quantity)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.cbx_cCodeItem)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.cbx_pCode)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txt_eDate)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox4.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(409, 390)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Manage Stock"
        '
        'btn_clearItem
        '
        Me.btn_clearItem.Location = New System.Drawing.Point(305, 361)
        Me.btn_clearItem.Name = "btn_clearItem"
        Me.btn_clearItem.Size = New System.Drawing.Size(64, 23)
        Me.btn_clearItem.TabIndex = 38
        Me.btn_clearItem.Text = "Clear"
        Me.btn_clearItem.UseVisualStyleBackColor = True
        '
        'pb_date
        '
        Me.pb_date.BackColor = System.Drawing.Color.Transparent
        Me.pb_date.BackgroundImage = CType(resources.GetObject("pb_date.BackgroundImage"), System.Drawing.Image)
        Me.pb_date.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pb_date.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_date.Location = New System.Drawing.Point(281, 331)
        Me.pb_date.Name = "pb_date"
        Me.pb_date.Size = New System.Drawing.Size(22, 21)
        Me.pb_date.TabIndex = 40
        Me.pb_date.TabStop = False
        '
        'btn_searchItem
        '
        Me.btn_searchItem.Location = New System.Drawing.Point(175, 361)
        Me.btn_searchItem.Name = "btn_searchItem"
        Me.btn_searchItem.Size = New System.Drawing.Size(64, 23)
        Me.btn_searchItem.TabIndex = 23
        Me.btn_searchItem.Text = "Search"
        Me.btn_searchItem.UseVisualStyleBackColor = True
        '
        'btn_deleteItem
        '
        Me.btn_deleteItem.Location = New System.Drawing.Point(240, 361)
        Me.btn_deleteItem.Name = "btn_deleteItem"
        Me.btn_deleteItem.Size = New System.Drawing.Size(64, 23)
        Me.btn_deleteItem.TabIndex = 30
        Me.btn_deleteItem.Text = "Delete"
        Me.btn_deleteItem.UseVisualStyleBackColor = True
        '
        'btn_editItem
        '
        Me.btn_editItem.Location = New System.Drawing.Point(110, 361)
        Me.btn_editItem.Name = "btn_editItem"
        Me.btn_editItem.Size = New System.Drawing.Size(64, 23)
        Me.btn_editItem.TabIndex = 29
        Me.btn_editItem.Text = "Edit"
        Me.btn_editItem.UseVisualStyleBackColor = True
        '
        'btn_addItem
        '
        Me.btn_addItem.Location = New System.Drawing.Point(45, 361)
        Me.btn_addItem.Name = "btn_addItem"
        Me.btn_addItem.Size = New System.Drawing.Size(64, 23)
        Me.btn_addItem.TabIndex = 26
        Me.btn_addItem.Text = "Add"
        Me.btn_addItem.UseVisualStyleBackColor = True
        '
        'txt_quantity
        '
        Me.txt_quantity.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_quantity.Location = New System.Drawing.Point(158, 304)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(145, 21)
        Me.txt_quantity.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(172, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 15)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = " Item List"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(15, 249)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Category Code: "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(15, 307)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 15)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Quantity:"
        '
        'cbx_cCodeItem
        '
        Me.cbx_cCodeItem.FormattingEnabled = True
        Me.cbx_cCodeItem.Location = New System.Drawing.Point(158, 246)
        Me.cbx_cCodeItem.Name = "cbx_cCodeItem"
        Me.cbx_cCodeItem.Size = New System.Drawing.Size(145, 23)
        Me.cbx_cCodeItem.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(15, 278)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 15)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Barode: "
        '
        'cbx_pCode
        '
        Me.cbx_pCode.FormattingEnabled = True
        Me.cbx_pCode.Location = New System.Drawing.Point(158, 275)
        Me.cbx_pCode.Name = "cbx_pCode"
        Me.cbx_pCode.Size = New System.Drawing.Size(145, 23)
        Me.cbx_pCode.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(15, 334)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 15)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Expiration Date :"
        '
        'txt_eDate
        '
        Me.txt_eDate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_eDate.Location = New System.Drawing.Point(158, 331)
        Me.txt_eDate.Name = "txt_eDate"
        Me.txt_eDate.Size = New System.Drawing.Size(117, 21)
        Me.txt_eDate.TabIndex = 13
        Me.txt_eDate.Text = "YYYY-MM-DD"
        '
        'frm_manageStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(417, 393)
        Me.Controls.Add(Me.GroupBox4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(433, 432)
        Me.MinimumSize = New System.Drawing.Size(433, 432)
        Me.Name = "frm_manageStock"
        Me.Text = "frm_manageStock"
        CType(Me.dgv_item, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.pb_date, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_item As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btn_clearItem As Button
    Friend WithEvents pb_date As PictureBox
    Friend WithEvents btn_searchItem As Button
    Friend WithEvents btn_deleteItem As Button
    Friend WithEvents btn_editItem As Button
    Friend WithEvents btn_addItem As Button
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cbx_cCodeItem As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbx_pCode As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_eDate As TextBox
End Class
