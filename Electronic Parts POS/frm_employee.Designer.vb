<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_employee
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgv_account = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.cbx_views = New System.Windows.Forms.ComboBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_account, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(880, 102)
        Me.Panel1.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS Reference Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(12, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(443, 44)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = " Employee Management"
        '
        'dgv_account
        '
        Me.dgv_account.AllowUserToAddRows = False
        Me.dgv_account.AllowUserToDeleteRows = False
        Me.dgv_account.AllowUserToResizeColumns = False
        Me.dgv_account.AllowUserToResizeRows = False
        Me.dgv_account.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_account.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv_account.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_account.Location = New System.Drawing.Point(12, 184)
        Me.dgv_account.Name = "dgv_account"
        Me.dgv_account.ReadOnly = True
        Me.dgv_account.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_account.ShowEditingIcon = False
        Me.dgv_account.Size = New System.Drawing.Size(856, 426)
        Me.dgv_account.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(373, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Account List"
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_user.Location = New System.Drawing.Point(18, 137)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(49, 15)
        Me.lbl_user.TabIndex = 12
        Me.lbl_user.Text = "User : "
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_name.Location = New System.Drawing.Point(18, 159)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(53, 15)
        Me.lbl_name.TabIndex = 13
        Me.lbl_name.Text = "Name :"
        '
        'cbx_views
        '
        Me.cbx_views.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_views.FormattingEnabled = True
        Me.cbx_views.Items.AddRange(New Object() {"All", "Admin", "User"})
        Me.cbx_views.Location = New System.Drawing.Point(776, 153)
        Me.cbx_views.Name = "cbx_views"
        Me.cbx_views.Size = New System.Drawing.Size(92, 21)
        Me.cbx_views.TabIndex = 14
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_id.Location = New System.Drawing.Point(21, 626)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(221, 20)
        Me.txt_id.TabIndex = 20
        '
        'btn_search
        '
        Me.btn_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_search.Location = New System.Drawing.Point(254, 620)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(120, 31)
        Me.btn_search.TabIndex = 21
        Me.btn_search.Text = "ID Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_delete.Location = New System.Drawing.Point(719, 620)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(149, 31)
        Me.btn_delete.TabIndex = 22
        Me.btn_delete.Text = "Delete Account"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_add.Location = New System.Drawing.Point(409, 620)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(149, 31)
        Me.btn_add.TabIndex = 24
        Me.btn_add.Text = "Add Account"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_edit.Location = New System.Drawing.Point(564, 620)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(149, 31)
        Me.btn_edit.TabIndex = 25
        Me.btn_edit.Text = "Edit Account"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'frm_employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(880, 659)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.cbx_views)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgv_account)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(880, 659)
        Me.MinimumSize = New System.Drawing.Size(880, 659)
        Me.Name = "frm_employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "v"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_account, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents dgv_account As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_user As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents cbx_views As ComboBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents btn_search As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_edit As Button
End Class
