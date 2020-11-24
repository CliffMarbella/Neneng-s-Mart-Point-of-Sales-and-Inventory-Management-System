<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addProduct
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
        Me.txt_fPrice = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_pcs = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbx_vExempted = New System.Windows.Forms.ComboBox()
        Me.cbx_zRated = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_mPrice = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbx_cCode = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_pName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bnt_add = New System.Windows.Forms.Button()
        Me.txt_bCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_fPrice
        '
        Me.txt_fPrice.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_fPrice.Location = New System.Drawing.Point(119, 149)
        Me.txt_fPrice.Name = "txt_fPrice"
        Me.txt_fPrice.Size = New System.Drawing.Size(146, 20)
        Me.txt_fPrice.TabIndex = 55
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label22.Location = New System.Drawing.Point(7, 150)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(74, 15)
        Me.Label22.TabIndex = 54
        Me.Label22.Text = "Unit Price:"
        '
        'txt_pcs
        '
        Me.txt_pcs.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_pcs.Location = New System.Drawing.Point(119, 212)
        Me.txt_pcs.Name = "txt_pcs"
        Me.txt_pcs.Size = New System.Drawing.Size(146, 20)
        Me.txt_pcs.TabIndex = 53
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label21.Location = New System.Drawing.Point(7, 213)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 15)
        Me.Label21.TabIndex = 52
        Me.Label21.Text = "Pcs / Box: "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(7, 243)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(103, 15)
        Me.Label20.TabIndex = 51
        Me.Label20.Text = "VAT Exempted:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label19.Location = New System.Drawing.Point(7, 277)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 15)
        Me.Label19.TabIndex = 50
        Me.Label19.Text = "Zero Rated:"
        '
        'cbx_vExempted
        '
        Me.cbx_vExempted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_vExempted.FormattingEnabled = True
        Me.cbx_vExempted.Items.AddRange(New Object() {"", "True", "False"})
        Me.cbx_vExempted.Location = New System.Drawing.Point(119, 243)
        Me.cbx_vExempted.Name = "cbx_vExempted"
        Me.cbx_vExempted.Size = New System.Drawing.Size(146, 21)
        Me.cbx_vExempted.TabIndex = 49
        '
        'cbx_zRated
        '
        Me.cbx_zRated.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_zRated.FormattingEnabled = True
        Me.cbx_zRated.Items.AddRange(New Object() {"", "True", "False"})
        Me.cbx_zRated.Location = New System.Drawing.Point(119, 276)
        Me.cbx_zRated.Name = "cbx_zRated"
        Me.cbx_zRated.Size = New System.Drawing.Size(146, 21)
        Me.cbx_zRated.TabIndex = 48
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(7, 182)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 15)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "Retail Price: "
        '
        'txt_mPrice
        '
        Me.txt_mPrice.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_mPrice.Location = New System.Drawing.Point(119, 181)
        Me.txt_mPrice.Name = "txt_mPrice"
        Me.txt_mPrice.Size = New System.Drawing.Size(146, 20)
        Me.txt_mPrice.TabIndex = 45
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(7, 117)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 15)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "Category Code:"
        '
        'cbx_cCode
        '
        Me.cbx_cCode.DropDownHeight = 100
        Me.cbx_cCode.FormattingEnabled = True
        Me.cbx_cCode.IntegralHeight = False
        Me.cbx_cCode.Location = New System.Drawing.Point(119, 116)
        Me.cbx_cCode.Name = "cbx_cCode"
        Me.cbx_cCode.Size = New System.Drawing.Size(146, 21)
        Me.cbx_cCode.Sorted = True
        Me.cbx_cCode.TabIndex = 46
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(7, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 15)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Product Name: "
        '
        'txt_pName
        '
        Me.txt_pName.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_pName.Location = New System.Drawing.Point(119, 53)
        Me.txt_pName.Name = "txt_pName"
        Me.txt_pName.Size = New System.Drawing.Size(246, 20)
        Me.txt_pName.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 24)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Add Product"
        '
        'bnt_add
        '
        Me.bnt_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_add.ForeColor = System.Drawing.SystemColors.Highlight
        Me.bnt_add.Location = New System.Drawing.Point(290, 301)
        Me.bnt_add.Name = "bnt_add"
        Me.bnt_add.Size = New System.Drawing.Size(75, 23)
        Me.bnt_add.TabIndex = 57
        Me.bnt_add.Text = "Add"
        Me.bnt_add.UseVisualStyleBackColor = True
        '
        'txt_bCode
        '
        Me.txt_bCode.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_bCode.Location = New System.Drawing.Point(119, 85)
        Me.txt_bCode.Name = "txt_bCode"
        Me.txt_bCode.Size = New System.Drawing.Size(146, 20)
        Me.txt_bCode.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(7, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Barcode: "
        '
        'frm_addProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(371, 323)
        Me.Controls.Add(Me.txt_bCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bnt_add)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_fPrice)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txt_pcs)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cbx_vExempted)
        Me.Controls.Add(Me.cbx_zRated)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txt_mPrice)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cbx_cCode)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_pName)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(387, 362)
        Me.MinimumSize = New System.Drawing.Size(387, 362)
        Me.Name = "frm_addProduct"
        Me.Text = "frm_addProduct"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_fPrice As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txt_pcs As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cbx_vExempted As ComboBox
    Friend WithEvents cbx_zRated As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_mPrice As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cbx_cCode As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_pName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bnt_add As Button
    Friend WithEvents txt_bCode As TextBox
    Friend WithEvents Label2 As Label
End Class
