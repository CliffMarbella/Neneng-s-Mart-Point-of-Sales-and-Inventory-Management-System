<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_calculator
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
        Me.txt_calcOutp = New System.Windows.Forms.TextBox()
        Me.txt_calcInp = New System.Windows.Forms.TextBox()
        Me.btn_mod = New System.Windows.Forms.Button()
        Me.btn_sqrt = New System.Windows.Forms.Button()
        Me.btn_reciprocal = New System.Windows.Forms.Button()
        Me.btn_square = New System.Windows.Forms.Button()
        Me.btn_clearEntry = New System.Windows.Forms.Button()
        Me.btn_1 = New System.Windows.Forms.Button()
        Me.btn_4 = New System.Windows.Forms.Button()
        Me.btn_7 = New System.Windows.Forms.Button()
        Me.btn_sign = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_divide = New System.Windows.Forms.Button()
        Me.btn_2 = New System.Windows.Forms.Button()
        Me.btn_3 = New System.Windows.Forms.Button()
        Me.btn_multiply = New System.Windows.Forms.Button()
        Me.btn_subtract = New System.Windows.Forms.Button()
        Me.btn_6 = New System.Windows.Forms.Button()
        Me.btn_5 = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_9 = New System.Windows.Forms.Button()
        Me.btn_8 = New System.Windows.Forms.Button()
        Me.btn_equal = New System.Windows.Forms.Button()
        Me.btn_decimal = New System.Windows.Forms.Button()
        Me.btn_0 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.txt_calcOutp)
        Me.Panel1.Controls.Add(Me.txt_calcInp)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(355, 100)
        Me.Panel1.TabIndex = 1
        '
        'txt_calcOutp
        '
        Me.txt_calcOutp.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txt_calcOutp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_calcOutp.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_calcOutp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_calcOutp.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txt_calcOutp.Location = New System.Drawing.Point(10, 11)
        Me.txt_calcOutp.Multiline = True
        Me.txt_calcOutp.Name = "txt_calcOutp"
        Me.txt_calcOutp.ReadOnly = True
        Me.txt_calcOutp.Size = New System.Drawing.Size(335, 20)
        Me.txt_calcOutp.TabIndex = 1
        Me.txt_calcOutp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_calcInp
        '
        Me.txt_calcInp.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txt_calcInp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_calcInp.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_calcInp.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_calcInp.Location = New System.Drawing.Point(3, 46)
        Me.txt_calcInp.MaxLength = 12
        Me.txt_calcInp.Multiline = True
        Me.txt_calcInp.Name = "txt_calcInp"
        Me.txt_calcInp.ReadOnly = True
        Me.txt_calcInp.Size = New System.Drawing.Size(349, 51)
        Me.txt_calcInp.TabIndex = 0
        Me.txt_calcInp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_mod
        '
        Me.btn_mod.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_mod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_mod.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mod.Font = New System.Drawing.Font("Microsoft NeoGothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mod.Location = New System.Drawing.Point(3, 104)
        Me.btn_mod.Name = "btn_mod"
        Me.btn_mod.Size = New System.Drawing.Size(88, 56)
        Me.btn_mod.TabIndex = 2
        Me.btn_mod.Text = "%"
        Me.btn_mod.UseVisualStyleBackColor = False
        '
        'btn_sqrt
        '
        Me.btn_sqrt.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_sqrt.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_sqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sqrt.Font = New System.Drawing.Font("Microsoft NeoGothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sqrt.Location = New System.Drawing.Point(91, 104)
        Me.btn_sqrt.Name = "btn_sqrt"
        Me.btn_sqrt.Size = New System.Drawing.Size(88, 56)
        Me.btn_sqrt.TabIndex = 3
        Me.btn_sqrt.Text = "√"
        Me.btn_sqrt.UseVisualStyleBackColor = False
        '
        'btn_reciprocal
        '
        Me.btn_reciprocal.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_reciprocal.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_reciprocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reciprocal.Location = New System.Drawing.Point(267, 104)
        Me.btn_reciprocal.Name = "btn_reciprocal"
        Me.btn_reciprocal.Size = New System.Drawing.Size(88, 56)
        Me.btn_reciprocal.TabIndex = 4
        Me.btn_reciprocal.Text = "1/x"
        Me.btn_reciprocal.UseVisualStyleBackColor = False
        '
        'btn_square
        '
        Me.btn_square.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_square.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_square.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_square.Location = New System.Drawing.Point(179, 104)
        Me.btn_square.Name = "btn_square"
        Me.btn_square.Size = New System.Drawing.Size(88, 56)
        Me.btn_square.TabIndex = 5
        Me.btn_square.Text = "x²"
        Me.btn_square.UseVisualStyleBackColor = False
        '
        'btn_clearEntry
        '
        Me.btn_clearEntry.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_clearEntry.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_clearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clearEntry.Location = New System.Drawing.Point(3, 160)
        Me.btn_clearEntry.Name = "btn_clearEntry"
        Me.btn_clearEntry.Size = New System.Drawing.Size(88, 56)
        Me.btn_clearEntry.TabIndex = 6
        Me.btn_clearEntry.Text = "CE"
        Me.btn_clearEntry.UseVisualStyleBackColor = False
        '
        'btn_1
        '
        Me.btn_1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_1.Location = New System.Drawing.Point(3, 216)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(88, 56)
        Me.btn_1.TabIndex = 7
        Me.btn_1.Text = "1"
        Me.btn_1.UseVisualStyleBackColor = False
        '
        'btn_4
        '
        Me.btn_4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_4.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_4.Location = New System.Drawing.Point(3, 272)
        Me.btn_4.Name = "btn_4"
        Me.btn_4.Size = New System.Drawing.Size(88, 56)
        Me.btn_4.TabIndex = 8
        Me.btn_4.Text = "4"
        Me.btn_4.UseVisualStyleBackColor = False
        '
        'btn_7
        '
        Me.btn_7.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_7.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_7.Location = New System.Drawing.Point(3, 328)
        Me.btn_7.Name = "btn_7"
        Me.btn_7.Size = New System.Drawing.Size(88, 56)
        Me.btn_7.TabIndex = 9
        Me.btn_7.Text = "7"
        Me.btn_7.UseVisualStyleBackColor = False
        '
        'btn_sign
        '
        Me.btn_sign.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_sign.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_sign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sign.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sign.Location = New System.Drawing.Point(3, 384)
        Me.btn_sign.Name = "btn_sign"
        Me.btn_sign.Size = New System.Drawing.Size(88, 56)
        Me.btn_sign.TabIndex = 10
        Me.btn_sign.Text = "+/-"
        Me.btn_sign.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_clear.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Location = New System.Drawing.Point(91, 160)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_clear.Size = New System.Drawing.Size(88, 56)
        Me.btn_clear.TabIndex = 11
        Me.btn_clear.Text = "C"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_delete.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(179, 160)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(88, 56)
        Me.btn_delete.TabIndex = 12
        Me.btn_delete.Text = "⌂"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_divide
        '
        Me.btn_divide.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_divide.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_divide.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_divide.Location = New System.Drawing.Point(267, 160)
        Me.btn_divide.Name = "btn_divide"
        Me.btn_divide.Size = New System.Drawing.Size(88, 56)
        Me.btn_divide.TabIndex = 13
        Me.btn_divide.Text = "÷"
        Me.btn_divide.UseVisualStyleBackColor = False
        '
        'btn_2
        '
        Me.btn_2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_2.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_2.Location = New System.Drawing.Point(91, 216)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(88, 56)
        Me.btn_2.TabIndex = 14
        Me.btn_2.Text = "2"
        Me.btn_2.UseVisualStyleBackColor = False
        '
        'btn_3
        '
        Me.btn_3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_3.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_3.Location = New System.Drawing.Point(179, 216)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(88, 56)
        Me.btn_3.TabIndex = 15
        Me.btn_3.Text = "3"
        Me.btn_3.UseVisualStyleBackColor = False
        '
        'btn_multiply
        '
        Me.btn_multiply.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_multiply.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_multiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_multiply.Location = New System.Drawing.Point(267, 216)
        Me.btn_multiply.Name = "btn_multiply"
        Me.btn_multiply.Size = New System.Drawing.Size(88, 56)
        Me.btn_multiply.TabIndex = 16
        Me.btn_multiply.Text = "×"
        Me.btn_multiply.UseVisualStyleBackColor = False
        '
        'btn_subtract
        '
        Me.btn_subtract.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_subtract.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_subtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_subtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_subtract.Location = New System.Drawing.Point(267, 272)
        Me.btn_subtract.Name = "btn_subtract"
        Me.btn_subtract.Size = New System.Drawing.Size(88, 56)
        Me.btn_subtract.TabIndex = 17
        Me.btn_subtract.Text = "-"
        Me.btn_subtract.UseVisualStyleBackColor = False
        '
        'btn_6
        '
        Me.btn_6.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_6.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_6.Location = New System.Drawing.Point(179, 272)
        Me.btn_6.Name = "btn_6"
        Me.btn_6.Size = New System.Drawing.Size(88, 56)
        Me.btn_6.TabIndex = 18
        Me.btn_6.Text = "6"
        Me.btn_6.UseVisualStyleBackColor = False
        '
        'btn_5
        '
        Me.btn_5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_5.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_5.Location = New System.Drawing.Point(91, 272)
        Me.btn_5.Name = "btn_5"
        Me.btn_5.Size = New System.Drawing.Size(88, 56)
        Me.btn_5.TabIndex = 19
        Me.btn_5.Text = "5"
        Me.btn_5.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_add.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(267, 328)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(88, 56)
        Me.btn_add.TabIndex = 20
        Me.btn_add.Text = "+"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btn_9
        '
        Me.btn_9.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_9.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_9.Location = New System.Drawing.Point(179, 328)
        Me.btn_9.Name = "btn_9"
        Me.btn_9.Size = New System.Drawing.Size(88, 56)
        Me.btn_9.TabIndex = 21
        Me.btn_9.Text = "9"
        Me.btn_9.UseVisualStyleBackColor = False
        '
        'btn_8
        '
        Me.btn_8.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_8.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_8.Location = New System.Drawing.Point(91, 328)
        Me.btn_8.Name = "btn_8"
        Me.btn_8.Size = New System.Drawing.Size(88, 56)
        Me.btn_8.TabIndex = 22
        Me.btn_8.Text = "8"
        Me.btn_8.UseVisualStyleBackColor = False
        '
        'btn_equal
        '
        Me.btn_equal.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_equal.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_equal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_equal.Location = New System.Drawing.Point(267, 384)
        Me.btn_equal.Name = "btn_equal"
        Me.btn_equal.Size = New System.Drawing.Size(88, 56)
        Me.btn_equal.TabIndex = 23
        Me.btn_equal.Text = "="
        Me.btn_equal.UseVisualStyleBackColor = False
        '
        'btn_decimal
        '
        Me.btn_decimal.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_decimal.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_decimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_decimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_decimal.Location = New System.Drawing.Point(179, 384)
        Me.btn_decimal.Name = "btn_decimal"
        Me.btn_decimal.Size = New System.Drawing.Size(88, 56)
        Me.btn_decimal.TabIndex = 24
        Me.btn_decimal.Text = "."
        Me.btn_decimal.UseVisualStyleBackColor = False
        '
        'btn_0
        '
        Me.btn_0.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_0.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_0.Location = New System.Drawing.Point(91, 384)
        Me.btn_0.Name = "btn_0"
        Me.btn_0.Size = New System.Drawing.Size(88, 56)
        Me.btn_0.TabIndex = 25
        Me.btn_0.Text = "0"
        Me.btn_0.UseVisualStyleBackColor = False
        '
        'frm_calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(358, 442)
        Me.Controls.Add(Me.btn_0)
        Me.Controls.Add(Me.btn_decimal)
        Me.Controls.Add(Me.btn_equal)
        Me.Controls.Add(Me.btn_8)
        Me.Controls.Add(Me.btn_9)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_5)
        Me.Controls.Add(Me.btn_6)
        Me.Controls.Add(Me.btn_subtract)
        Me.Controls.Add(Me.btn_multiply)
        Me.Controls.Add(Me.btn_3)
        Me.Controls.Add(Me.btn_2)
        Me.Controls.Add(Me.btn_divide)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_sign)
        Me.Controls.Add(Me.btn_7)
        Me.Controls.Add(Me.btn_4)
        Me.Controls.Add(Me.btn_1)
        Me.Controls.Add(Me.btn_clearEntry)
        Me.Controls.Add(Me.btn_square)
        Me.Controls.Add(Me.btn_reciprocal)
        Me.Controls.Add(Me.btn_sqrt)
        Me.Controls.Add(Me.btn_mod)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(374, 481)
        Me.MinimumSize = New System.Drawing.Size(374, 481)
        Me.Name = "frm_calculator"
        Me.Text = "frm_calculator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_calcInp As TextBox
    Friend WithEvents txt_calcOutp As TextBox
    Friend WithEvents btn_mod As Button
    Friend WithEvents btn_sqrt As Button
    Friend WithEvents btn_reciprocal As Button
    Friend WithEvents btn_square As Button
    Friend WithEvents btn_clearEntry As Button
    Friend WithEvents btn_1 As Button
    Friend WithEvents btn_4 As Button
    Friend WithEvents btn_7 As Button
    Friend WithEvents btn_sign As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_divide As Button
    Friend WithEvents btn_2 As Button
    Friend WithEvents btn_3 As Button
    Friend WithEvents btn_multiply As Button
    Friend WithEvents btn_subtract As Button
    Friend WithEvents btn_6 As Button
    Friend WithEvents btn_5 As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_9 As Button
    Friend WithEvents btn_8 As Button
    Friend WithEvents btn_equal As Button
    Friend WithEvents btn_decimal As Button
    Friend WithEvents btn_0 As Button
End Class
