<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_trail
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
        Me.txt_trail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_trail
        '
        Me.txt_trail.Location = New System.Drawing.Point(12, 12)
        Me.txt_trail.Multiline = True
        Me.txt_trail.Name = "txt_trail"
        Me.txt_trail.ReadOnly = True
        Me.txt_trail.Size = New System.Drawing.Size(365, 368)
        Me.txt_trail.TabIndex = 0
        '
        'frm_trail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 392)
        Me.Controls.Add(Me.txt_trail)
        Me.Name = "frm_trail"
        Me.Text = "frm_trail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_trail As TextBox
End Class
