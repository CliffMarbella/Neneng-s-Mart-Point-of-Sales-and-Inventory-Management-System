<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_supplier
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
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_nMatchC = New System.Windows.Forms.Label()
        Me.txt_supplier = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dgv_supplier = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_address)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.lbl_nMatchC)
        Me.GroupBox3.Controls.Add(Me.txt_supplier)
        Me.GroupBox3.Controls.Add(Me.btn_add)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.dgv_supplier)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox3.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(337, 253)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Add Supplier"
        '
        'txt_address
        '
        Me.txt_address.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_address.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_address.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_address.Location = New System.Drawing.Point(96, 194)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(221, 21)
        Me.txt_address.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(15, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Address :"
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
        'txt_supplier
        '
        Me.txt_supplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_supplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_supplier.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_supplier.Location = New System.Drawing.Point(96, 167)
        Me.txt_supplier.Name = "txt_supplier"
        Me.txt_supplier.Size = New System.Drawing.Size(221, 21)
        Me.txt_supplier.TabIndex = 19
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(254, 221)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(63, 23)
        Me.btn_add.TabIndex = 19
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(15, 170)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 15)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Supplier :"
        '
        'dgv_supplier
        '
        Me.dgv_supplier.AllowUserToAddRows = False
        Me.dgv_supplier.AllowUserToDeleteRows = False
        Me.dgv_supplier.AllowUserToResizeColumns = False
        Me.dgv_supplier.AllowUserToResizeRows = False
        Me.dgv_supplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_supplier.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_supplier.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgv_supplier.Location = New System.Drawing.Point(18, 35)
        Me.dgv_supplier.MultiSelect = False
        Me.dgv_supplier.Name = "dgv_supplier"
        Me.dgv_supplier.ReadOnly = True
        Me.dgv_supplier.RowHeadersVisible = False
        Me.dgv_supplier.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_supplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_supplier.Size = New System.Drawing.Size(299, 126)
        Me.dgv_supplier.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(113, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 15)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Supplier List"
        '
        'frm_supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(343, 257)
        Me.Controls.Add(Me.GroupBox3)
        Me.MaximizeBox = False
        Me.Name = "frm_supplier"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_supplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_nMatchC As Label
    Friend WithEvents txt_supplier As TextBox
    Friend WithEvents btn_add As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents dgv_supplier As DataGridView
    Friend WithEvents Label12 As Label
End Class
