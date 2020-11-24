<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_help
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
        Me.pb_pic = New System.Windows.Forms.PictureBox()
        Me.txt_info = New System.Windows.Forms.TextBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        CType(Me.pb_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_pic
        '
        Me.pb_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_pic.Location = New System.Drawing.Point(12, 30)
        Me.pb_pic.Name = "pb_pic"
        Me.pb_pic.Size = New System.Drawing.Size(506, 336)
        Me.pb_pic.TabIndex = 0
        Me.pb_pic.TabStop = False
        '
        'txt_info
        '
        Me.txt_info.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_info.ForeColor = System.Drawing.SystemColors.Info
        Me.txt_info.Location = New System.Drawing.Point(12, 372)
        Me.txt_info.Multiline = True
        Me.txt_info.Name = "txt_info"
        Me.txt_info.Size = New System.Drawing.Size(506, 63)
        Me.txt_info.TabIndex = 1
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.SystemColors.Info
        Me.lbl_title.Location = New System.Drawing.Point(12, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(49, 16)
        Me.lbl_title.TabIndex = 2
        Me.lbl_title.Text = "Label1"
        '
        'frm_help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(530, 479)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.txt_info)
        Me.Controls.Add(Me.pb_pic)
        Me.Name = "frm_help"
        Me.Text = "frm_help"
        CType(Me.pb_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb_pic As PictureBox
    Friend WithEvents txt_info As TextBox
    Friend WithEvents lbl_title As Label
End Class
