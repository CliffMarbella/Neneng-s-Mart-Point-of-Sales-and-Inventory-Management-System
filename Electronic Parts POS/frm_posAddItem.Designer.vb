<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_posAddItem
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nameSearch = New System.Windows.Forms.TextBox()
        Me.btn_nameSearch = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.cbx_discount = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dgv_item = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_pName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_pCode = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_cName = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_pPrice = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_zRated = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl_vExempted = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        CType(Me.dgv_item, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(309, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 15)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "VAT Exempted:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(310, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 15)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Zero Rated:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(310, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Price: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(3, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Item Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(3, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Category: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(3, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Barcode: "
        '
        'txt_nameSearch
        '
        Me.txt_nameSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_nameSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nameSearch.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txt_nameSearch.Location = New System.Drawing.Point(112, 86)
        Me.txt_nameSearch.Name = "txt_nameSearch"
        Me.txt_nameSearch.Size = New System.Drawing.Size(239, 20)
        Me.txt_nameSearch.TabIndex = 26
        '
        'btn_nameSearch
        '
        Me.btn_nameSearch.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_nameSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nameSearch.Location = New System.Drawing.Point(6, 79)
        Me.btn_nameSearch.Name = "btn_nameSearch"
        Me.btn_nameSearch.Size = New System.Drawing.Size(100, 33)
        Me.btn_nameSearch.TabIndex = 48
        Me.btn_nameSearch.Text = "Name Search"
        Me.btn_nameSearch.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(404, 417)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(100, 33)
        Me.btn_add.TabIndex = 49
        Me.btn_add.Text = "      Add Item"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'cbx_discount
        '
        Me.cbx_discount.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cbx_discount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_discount.FormattingEnabled = True
        Me.cbx_discount.Items.AddRange(New Object() {"", "10%", "15%", "20%"})
        Me.cbx_discount.Location = New System.Drawing.Point(289, 424)
        Me.cbx_discount.Name = "cbx_discount"
        Me.cbx_discount.Size = New System.Drawing.Size(109, 21)
        Me.cbx_discount.TabIndex = 51
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(192, 425)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 15)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "Add Discount"
        '
        'dgv_item
        '
        Me.dgv_item.AllowUserToAddRows = False
        Me.dgv_item.AllowUserToDeleteRows = False
        Me.dgv_item.AllowUserToResizeColumns = False
        Me.dgv_item.AllowUserToResizeRows = False
        Me.dgv_item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_item.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_item.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgv_item.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgv_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_item.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_item.Location = New System.Drawing.Point(6, 118)
        Me.dgv_item.MultiSelect = False
        Me.dgv_item.Name = "dgv_item"
        Me.dgv_item.ReadOnly = True
        Me.dgv_item.RowHeadersVisible = False
        Me.dgv_item.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_item.Size = New System.Drawing.Size(500, 293)
        Me.dgv_item.TabIndex = 52
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.lbl_pName)
        Me.Panel1.Location = New System.Drawing.Point(90, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(214, 20)
        Me.Panel1.TabIndex = 53
        '
        'lbl_pName
        '
        Me.lbl_pName.AutoSize = True
        Me.lbl_pName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_pName.Location = New System.Drawing.Point(3, 1)
        Me.lbl_pName.Name = "lbl_pName"
        Me.lbl_pName.Size = New System.Drawing.Size(0, 15)
        Me.lbl_pName.TabIndex = 58
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel2.Controls.Add(Me.lbl_pCode)
        Me.Panel2.Location = New System.Drawing.Point(90, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(214, 20)
        Me.Panel2.TabIndex = 54
        '
        'lbl_pCode
        '
        Me.lbl_pCode.AutoSize = True
        Me.lbl_pCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_pCode.Location = New System.Drawing.Point(3, 1)
        Me.lbl_pCode.Name = "lbl_pCode"
        Me.lbl_pCode.Size = New System.Drawing.Size(0, 15)
        Me.lbl_pCode.TabIndex = 59
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel3.Controls.Add(Me.lbl_cName)
        Me.Panel3.Location = New System.Drawing.Point(90, 53)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(214, 20)
        Me.Panel3.TabIndex = 54
        '
        'lbl_cName
        '
        Me.lbl_cName.AutoSize = True
        Me.lbl_cName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_cName.Location = New System.Drawing.Point(3, 1)
        Me.lbl_cName.Name = "lbl_cName"
        Me.lbl_cName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_cName.Size = New System.Drawing.Size(0, 15)
        Me.lbl_cName.TabIndex = 60
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel4.Controls.Add(Me.lbl_pPrice)
        Me.Panel4.Location = New System.Drawing.Point(418, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(86, 20)
        Me.Panel4.TabIndex = 55
        '
        'lbl_pPrice
        '
        Me.lbl_pPrice.AutoSize = True
        Me.lbl_pPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_pPrice.Location = New System.Drawing.Point(3, 1)
        Me.lbl_pPrice.Name = "lbl_pPrice"
        Me.lbl_pPrice.Size = New System.Drawing.Size(0, 15)
        Me.lbl_pPrice.TabIndex = 61
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel5.Controls.Add(Me.lbl_zRated)
        Me.Panel5.Location = New System.Drawing.Point(418, 29)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(86, 20)
        Me.Panel5.TabIndex = 56
        '
        'lbl_zRated
        '
        Me.lbl_zRated.AutoSize = True
        Me.lbl_zRated.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_zRated.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_zRated.Location = New System.Drawing.Point(3, 1)
        Me.lbl_zRated.Name = "lbl_zRated"
        Me.lbl_zRated.Size = New System.Drawing.Size(0, 15)
        Me.lbl_zRated.TabIndex = 62
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel6.Controls.Add(Me.lbl_vExempted)
        Me.Panel6.Location = New System.Drawing.Point(418, 53)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(86, 20)
        Me.Panel6.TabIndex = 57
        '
        'lbl_vExempted
        '
        Me.lbl_vExempted.AutoSize = True
        Me.lbl_vExempted.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vExempted.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_vExempted.Location = New System.Drawing.Point(3, 1)
        Me.lbl_vExempted.Name = "lbl_vExempted"
        Me.lbl_vExempted.Size = New System.Drawing.Size(0, 15)
        Me.lbl_vExempted.TabIndex = 63
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label22.ForeColor = System.Drawing.Color.Khaki
        Me.Label22.Location = New System.Drawing.Point(415, 427)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(19, 13)
        Me.Label22.TabIndex = 72
        Me.Label22.Text = "F1"
        '
        'frm_posAddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(512, 454)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv_item)
        Me.Controls.Add(Me.cbx_discount)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_nameSearch)
        Me.Controls.Add(Me.txt_nameSearch)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Location = New System.Drawing.Point(800, 100)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(528, 493)
        Me.MinimumSize = New System.Drawing.Size(528, 493)
        Me.Name = "frm_posAddItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frm_posAddItem"
        CType(Me.dgv_item, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_nameSearch As TextBox
    Friend WithEvents btn_nameSearch As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents cbx_discount As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents dgv_item As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_pName As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_pCode As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_cName As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl_pPrice As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_zRated As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lbl_vExempted As Label
    Friend WithEvents Label22 As Label
End Class
