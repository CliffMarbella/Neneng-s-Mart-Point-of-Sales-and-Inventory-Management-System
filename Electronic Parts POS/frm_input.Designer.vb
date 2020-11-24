<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_input
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
        Me.txt_input = New System.Windows.Forms.TextBox()
        Me.lbl_enterInput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_input
        '
        Me.txt_input.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_input.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_input.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_input.ForeColor = System.Drawing.Color.Lime
        Me.txt_input.Location = New System.Drawing.Point(5, 37)
        Me.txt_input.Name = "txt_input"
        Me.txt_input.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_input.Size = New System.Drawing.Size(373, 55)
        Me.txt_input.TabIndex = 0
        '
        'lbl_enterInput
        '
        Me.lbl_enterInput.AutoSize = True
        Me.lbl_enterInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_enterInput.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_enterInput.Location = New System.Drawing.Point(12, 9)
        Me.lbl_enterInput.Name = "lbl_enterInput"
        Me.lbl_enterInput.Size = New System.Drawing.Size(112, 24)
        Me.lbl_enterInput.TabIndex = 1
        Me.lbl_enterInput.Text = "Enter Input"
        '
        'frm_input
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(383, 98)
        Me.Controls.Add(Me.lbl_enterInput)
        Me.Controls.Add(Me.txt_input)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_input"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_input As TextBox
    Friend WithEvents lbl_enterInput As Label
End Class
