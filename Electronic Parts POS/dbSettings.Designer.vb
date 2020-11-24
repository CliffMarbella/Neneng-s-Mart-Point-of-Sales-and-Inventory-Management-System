<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_dbSettings
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_connect = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.txt_MSSB = New System.Windows.Forms.TextBox()
        Me.txt_PW = New System.Windows.Forms.TextBox()
        Me.txt_UN = New System.Windows.Forms.TextBox()
        Me.txt_ScN = New System.Windows.Forms.TextBox()
        Me.txt_SP = New System.Windows.Forms.TextBox()
        Me.txt_SA = New System.Windows.Forms.TextBox()
        Me.btn_ffd = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft NeoGothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Database Settings"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Server Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Server Port:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Schema Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 322)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "My Sql Sever Bin:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "User Name:"
        '
        'btn_connect
        '
        Me.btn_connect.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_connect.Location = New System.Drawing.Point(153, 366)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(92, 30)
        Me.btn_connect.TabIndex = 7
        Me.btn_connect.Text = "Connect"
        Me.btn_connect.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_cancel.Location = New System.Drawing.Point(251, 366)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(90, 30)
        Me.btn_cancel.TabIndex = 8
        Me.btn_cancel.Text = "Back"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'txt_MSSB
        '
        Me.txt_MSSB.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_MSSB.Location = New System.Drawing.Point(158, 323)
        Me.txt_MSSB.Name = "txt_MSSB"
        Me.txt_MSSB.Size = New System.Drawing.Size(146, 20)
        Me.txt_MSSB.TabIndex = 9
        '
        'txt_PW
        '
        Me.txt_PW.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_PW.Location = New System.Drawing.Point(143, 266)
        Me.txt_PW.Name = "txt_PW"
        Me.txt_PW.Size = New System.Drawing.Size(198, 20)
        Me.txt_PW.TabIndex = 10
        '
        'txt_UN
        '
        Me.txt_UN.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_UN.Location = New System.Drawing.Point(143, 223)
        Me.txt_UN.Name = "txt_UN"
        Me.txt_UN.Size = New System.Drawing.Size(198, 20)
        Me.txt_UN.TabIndex = 11
        '
        'txt_ScN
        '
        Me.txt_ScN.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_ScN.Location = New System.Drawing.Point(143, 179)
        Me.txt_ScN.Name = "txt_ScN"
        Me.txt_ScN.Size = New System.Drawing.Size(198, 20)
        Me.txt_ScN.TabIndex = 12
        '
        'txt_SP
        '
        Me.txt_SP.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_SP.Location = New System.Drawing.Point(143, 137)
        Me.txt_SP.Name = "txt_SP"
        Me.txt_SP.Size = New System.Drawing.Size(198, 20)
        Me.txt_SP.TabIndex = 13
        '
        'txt_SA
        '
        Me.txt_SA.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_SA.Location = New System.Drawing.Point(143, 99)
        Me.txt_SA.Name = "txt_SA"
        Me.txt_SA.Size = New System.Drawing.Size(198, 20)
        Me.txt_SA.TabIndex = 14
        '
        'btn_ffd
        '
        Me.btn_ffd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_ffd.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ffd.Location = New System.Drawing.Point(310, 321)
        Me.btn_ffd.Name = "btn_ffd"
        Me.btn_ffd.Size = New System.Drawing.Size(31, 23)
        Me.btn_ffd.TabIndex = 15
        Me.btn_ffd.Text = "...."
        Me.btn_ffd.UseVisualStyleBackColor = False
        '
        'frm_dbSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(363, 408)
        Me.Controls.Add(Me.btn_ffd)
        Me.Controls.Add(Me.txt_SA)
        Me.Controls.Add(Me.txt_SP)
        Me.Controls.Add(Me.txt_ScN)
        Me.Controls.Add(Me.txt_UN)
        Me.Controls.Add(Me.txt_PW)
        Me.Controls.Add(Me.txt_MSSB)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_connect)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(379, 447)
        Me.MinimumSize = New System.Drawing.Size(379, 447)
        Me.Name = "frm_dbSettings"
        Me.Text = "Database Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_connect As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents txt_MSSB As TextBox
    Friend WithEvents txt_PW As TextBox
    Friend WithEvents txt_UN As TextBox
    Friend WithEvents txt_ScN As TextBox
    Friend WithEvents txt_SP As TextBox
    Friend WithEvents txt_SA As TextBox
    Friend WithEvents btn_ffd As Button
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
End Class
