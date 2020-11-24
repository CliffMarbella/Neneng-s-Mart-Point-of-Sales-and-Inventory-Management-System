<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssl_status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssl_user = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssl_level = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssl_lvl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_tLogged = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_EM = New System.Windows.Forms.Button()
        Me.btn_CM = New System.Windows.Forms.Button()
        Me.btn_SP = New System.Windows.Forms.Button()
        Me.btn_IM = New System.Windows.Forms.Button()
        Me.btn_Pos = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RwtwrtwToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_myAccount = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Time = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(14, 714)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssl_status, Me.tssl_user, Me.tssl_level, Me.tssl_lvl})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 665)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1348, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssl_status
        '
        Me.tssl_status.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tssl_status.Name = "tssl_status"
        Me.tssl_status.Size = New System.Drawing.Size(45, 17)
        Me.tssl_status.Text = "Status: "
        '
        'tssl_user
        '
        Me.tssl_user.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tssl_user.Name = "tssl_user"
        Me.tssl_user.Size = New System.Drawing.Size(33, 17)
        Me.tssl_user.Text = "User:"
        '
        'tssl_level
        '
        Me.tssl_level.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tssl_level.Name = "tssl_level"
        Me.tssl_level.Size = New System.Drawing.Size(0, 17)
        '
        'tssl_lvl
        '
        Me.tssl_lvl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tssl_lvl.Name = "tssl_lvl"
        Me.tssl_lvl.Size = New System.Drawing.Size(77, 17)
        Me.tssl_lvl.Text = "Access Type: "
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lbl_tLogged)
        Me.Panel1.Controls.Add(Me.lbl_time)
        Me.Panel1.Controls.Add(Me.lbl_date)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(1026, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 661)
        Me.Panel1.TabIndex = 4
        '
        'lbl_tLogged
        '
        Me.lbl_tLogged.AutoSize = True
        Me.lbl_tLogged.Location = New System.Drawing.Point(18, 634)
        Me.lbl_tLogged.Name = "lbl_tLogged"
        Me.lbl_tLogged.Size = New System.Drawing.Size(0, 13)
        Me.lbl_tLogged.TabIndex = 8
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Location = New System.Drawing.Point(171, 610)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(96, 13)
        Me.lbl_time.TabIndex = 6
        Me.lbl_time.Text = "Time: 12:00 PM"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Location = New System.Drawing.Point(18, 610)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(96, 13)
        Me.lbl_date.TabIndex = 5
        Me.lbl_date.Text = "Date: 04/15/99"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_EM)
        Me.GroupBox1.Controls.Add(Me.btn_CM)
        Me.GroupBox1.Controls.Add(Me.btn_SP)
        Me.GroupBox1.Controls.Add(Me.btn_IM)
        Me.GroupBox1.Controls.Add(Me.btn_Pos)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 224)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(275, 374)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Main Menu"
        '
        'btn_EM
        '
        Me.btn_EM.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_EM.Location = New System.Drawing.Point(18, 234)
        Me.btn_EM.Name = "btn_EM"
        Me.btn_EM.Size = New System.Drawing.Size(238, 62)
        Me.btn_EM.TabIndex = 6
        Me.btn_EM.Text = "Employee Management"
        Me.btn_EM.UseVisualStyleBackColor = False
        '
        'btn_CM
        '
        Me.btn_CM.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_CM.Location = New System.Drawing.Point(18, 302)
        Me.btn_CM.Name = "btn_CM"
        Me.btn_CM.Size = New System.Drawing.Size(238, 62)
        Me.btn_CM.TabIndex = 7
        Me.btn_CM.Text = "Settings"
        Me.btn_CM.UseVisualStyleBackColor = False
        '
        'btn_SP
        '
        Me.btn_SP.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_SP.Location = New System.Drawing.Point(18, 166)
        Me.btn_SP.Name = "btn_SP"
        Me.btn_SP.Size = New System.Drawing.Size(238, 62)
        Me.btn_SP.TabIndex = 8
        Me.btn_SP.Text = "Sales Report"
        Me.btn_SP.UseVisualStyleBackColor = False
        '
        'btn_IM
        '
        Me.btn_IM.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_IM.Location = New System.Drawing.Point(18, 98)
        Me.btn_IM.Name = "btn_IM"
        Me.btn_IM.Size = New System.Drawing.Size(238, 62)
        Me.btn_IM.TabIndex = 9
        Me.btn_IM.Text = "Inventory Management"
        Me.btn_IM.UseVisualStyleBackColor = False
        '
        'btn_Pos
        '
        Me.btn_Pos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_Pos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btn_Pos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_Pos.Location = New System.Drawing.Point(18, 33)
        Me.btn_Pos.Name = "btn_Pos"
        Me.btn_Pos.Size = New System.Drawing.Size(238, 62)
        Me.btn_Pos.TabIndex = 10
        Me.btn_Pos.Text = "POS"
        Me.btn_Pos.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(54, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 191)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RwtwrtwToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(318, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RwtwrtwToolStripMenuItem
        '
        Me.RwtwrtwToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText
        Me.RwtwrtwToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_myAccount, Me.LogOutToolStripMenuItem})
        Me.RwtwrtwToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RwtwrtwToolStripMenuItem.Name = "RwtwrtwToolStripMenuItem"
        Me.RwtwrtwToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.RwtwrtwToolStripMenuItem.Text = "Menu ▼"
        '
        'tsmi_myAccount
        '
        Me.tsmi_myAccount.Name = "tsmi_myAccount"
        Me.tsmi_myAccount.Size = New System.Drawing.Size(138, 22)
        Me.tsmi_myAccount.Text = "My Account"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'Time
        '
        Me.Time.Enabled = True
        Me.Time.Interval = 1000
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1348, 687)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1364, 726)
        Me.MinimumSize = New System.Drawing.Size(1364, 726)
        Me.Name = "frm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS System"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_time As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents btn_IM As Button
    Friend WithEvents btn_Pos As Button
    Friend WithEvents btn_EM As Button
    Friend WithEvents btn_CM As Button
    Friend WithEvents btn_SP As Button
    Friend WithEvents tssl_status As ToolStripStatusLabel
    Friend WithEvents tssl_user As ToolStripStatusLabel
    Friend WithEvents tssl_level As ToolStripStatusLabel
    Friend WithEvents tssl_lvl As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Time As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RwtwrtwToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmi_myAccount As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_tLogged As Label
End Class
