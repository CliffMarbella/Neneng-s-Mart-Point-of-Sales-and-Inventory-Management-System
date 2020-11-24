<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_PosSystem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_PosSystem))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_changeQuantity = New System.Windows.Forms.Button()
        Me.btn_recieve = New System.Windows.Forms.Button()
        Me.btn_reciept = New System.Windows.Forms.Button()
        Me.btn_calculator = New System.Windows.Forms.Button()
        Me.btn_closeTransc = New System.Windows.Forms.Button()
        Me.btn_editTransaction = New System.Windows.Forms.Button()
        Me.btn_newTransc = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_saveTransaction = New System.Windows.Forms.Button()
        Me.btn_discardTransaction = New System.Windows.Forms.Button()
        Me.btn_loadTransc = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_totalDue = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_vat = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_subTotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.btn_bCode = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_change = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_amount = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dgv_pos = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_invoiceNo = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_transcNo = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl_transctime = New System.Windows.Forms.Label()
        Me.txt_discount = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgv_pos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(878, 101)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(23, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(118, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 44)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Retail POS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel2.Controls.Add(Me.Label32)
        Me.Panel2.Controls.Add(Me.Label31)
        Me.Panel2.Controls.Add(Me.Label30)
        Me.Panel2.Controls.Add(Me.Label29)
        Me.Panel2.Controls.Add(Me.Label28)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btn_changeQuantity)
        Me.Panel2.Controls.Add(Me.btn_recieve)
        Me.Panel2.Controls.Add(Me.btn_reciept)
        Me.Panel2.Controls.Add(Me.btn_calculator)
        Me.Panel2.Controls.Add(Me.btn_closeTransc)
        Me.Panel2.Controls.Add(Me.btn_editTransaction)
        Me.Panel2.Controls.Add(Me.btn_newTransc)
        Me.Panel2.Controls.Add(Me.btn_add)
        Me.Panel2.Controls.Add(Me.btn_saveTransaction)
        Me.Panel2.Controls.Add(Me.btn_discardTransaction)
        Me.Panel2.Controls.Add(Me.btn_loadTransc)
        Me.Panel2.Location = New System.Drawing.Point(3, 105)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 551)
        Me.Panel2.TabIndex = 2
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label32.ForeColor = System.Drawing.Color.Khaki
        Me.Label32.Location = New System.Drawing.Point(166, 519)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(25, 13)
        Me.Label32.TabIndex = 81
        Me.Label32.Text = "F11"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label31.ForeColor = System.Drawing.Color.Khaki
        Me.Label31.Location = New System.Drawing.Point(166, 469)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(25, 13)
        Me.Label31.TabIndex = 80
        Me.Label31.Text = "F10"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label30.ForeColor = System.Drawing.Color.Khaki
        Me.Label30.Location = New System.Drawing.Point(166, 419)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(19, 13)
        Me.Label30.TabIndex = 79
        Me.Label30.Text = "F9"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label29.ForeColor = System.Drawing.Color.Khaki
        Me.Label29.Location = New System.Drawing.Point(166, 369)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(19, 13)
        Me.Label29.TabIndex = 78
        Me.Label29.Text = "F8"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label28.ForeColor = System.Drawing.Color.Khaki
        Me.Label28.Location = New System.Drawing.Point(166, 319)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(19, 13)
        Me.Label28.TabIndex = 77
        Me.Label28.Text = "F7"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label27.ForeColor = System.Drawing.Color.Khaki
        Me.Label27.Location = New System.Drawing.Point(166, 269)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(19, 13)
        Me.Label27.TabIndex = 76
        Me.Label27.Text = "F6"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label26.ForeColor = System.Drawing.Color.Khaki
        Me.Label26.Location = New System.Drawing.Point(166, 219)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(19, 13)
        Me.Label26.TabIndex = 75
        Me.Label26.Text = "F5"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label25.ForeColor = System.Drawing.Color.Khaki
        Me.Label25.Location = New System.Drawing.Point(166, 169)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(19, 13)
        Me.Label25.TabIndex = 74
        Me.Label25.Text = "F4"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label24.ForeColor = System.Drawing.Color.Khaki
        Me.Label24.Location = New System.Drawing.Point(166, 119)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(19, 13)
        Me.Label24.TabIndex = 73
        Me.Label24.Text = "F3"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label23.ForeColor = System.Drawing.Color.Khaki
        Me.Label23.Location = New System.Drawing.Point(166, 69)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(19, 13)
        Me.Label23.TabIndex = 72
        Me.Label23.Text = "F2"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label22.ForeColor = System.Drawing.Color.Khaki
        Me.Label22.Location = New System.Drawing.Point(166, 19)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(19, 13)
        Me.Label22.TabIndex = 71
        Me.Label22.Text = "F1"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label21.ImageIndex = 16
        Me.Label21.ImageList = Me.ImageList1
        Me.Label21.Location = New System.Drawing.Point(22, 509)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(127, 32)
        Me.Label21.TabIndex = 70
        Me.Label21.Text = "Recieve Payment"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "newT.png")
        Me.ImageList1.Images.SetKeyName(1, "newT2.png")
        Me.ImageList1.Images.SetKeyName(2, "newT3.png")
        Me.ImageList1.Images.SetKeyName(3, "newT3.png")
        Me.ImageList1.Images.SetKeyName(4, "findItem.png")
        Me.ImageList1.Images.SetKeyName(5, "findItem2.jpg")
        Me.ImageList1.Images.SetKeyName(6, "findItem2.jpg")
        Me.ImageList1.Images.SetKeyName(7, "findItem2.jpg")
        Me.ImageList1.Images.SetKeyName(8, "remove.png")
        Me.ImageList1.Images.SetKeyName(9, "quantty.jpg")
        Me.ImageList1.Images.SetKeyName(10, "save.jpg")
        Me.ImageList1.Images.SetKeyName(11, "load.png")
        Me.ImageList1.Images.SetKeyName(12, "discard.jpg")
        Me.ImageList1.Images.SetKeyName(13, "close.png")
        Me.ImageList1.Images.SetKeyName(14, "calc.png")
        Me.ImageList1.Images.SetKeyName(15, "receipt.png")
        Me.ImageList1.Images.SetKeyName(16, "recieve.png")
        Me.ImageList1.Images.SetKeyName(17, "search.png")
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label20.ImageIndex = 15
        Me.Label20.ImageList = Me.ImageList1
        Me.Label20.Location = New System.Drawing.Point(20, 459)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(128, 32)
        Me.Label20.TabIndex = 69
        Me.Label20.Text = "Generate Receipt"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label19.ImageIndex = 14
        Me.Label19.ImageList = Me.ImageList1
        Me.Label19.Location = New System.Drawing.Point(20, 409)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(101, 32)
        Me.Label19.TabIndex = 68
        Me.Label19.Text = "Calculator"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label18.ImageIndex = 13
        Me.Label18.ImageList = Me.ImageList1
        Me.Label18.Location = New System.Drawing.Point(19, 359)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(131, 32)
        Me.Label18.TabIndex = 67
        Me.Label18.Text = "Close Transaction"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label11.ImageIndex = 12
        Me.Label11.ImageList = Me.ImageList1
        Me.Label11.Location = New System.Drawing.Point(22, 309)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 32)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Discard Transaction"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.ImageIndex = 11
        Me.Label8.ImageList = Me.ImageList1
        Me.Label8.Location = New System.Drawing.Point(20, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 32)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Load Transaction"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.ImageIndex = 10
        Me.Label7.ImageList = Me.ImageList1
        Me.Label7.Location = New System.Drawing.Point(20, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 32)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Save Transaction"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.ImageIndex = 9
        Me.Label6.ImageList = Me.ImageList1
        Me.Label6.Location = New System.Drawing.Point(17, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 32)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Change Quantity"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.ImageIndex = 8
        Me.Label5.ImageList = Me.ImageList1
        Me.Label5.Location = New System.Drawing.Point(20, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 32)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Delete Row"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.ImageIndex = 17
        Me.Label4.ImageList = Me.ImageList1
        Me.Label4.Location = New System.Drawing.Point(18, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 32)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Find Item"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.ImageIndex = 3
        Me.Label3.ImageList = Me.ImageList1
        Me.Label3.Location = New System.Drawing.Point(18, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 32)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "New Transaction"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_changeQuantity
        '
        Me.btn_changeQuantity.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_changeQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_changeQuantity.Location = New System.Drawing.Point(3, 150)
        Me.btn_changeQuantity.Name = "btn_changeQuantity"
        Me.btn_changeQuantity.Size = New System.Drawing.Size(194, 50)
        Me.btn_changeQuantity.TabIndex = 59
        Me.btn_changeQuantity.UseVisualStyleBackColor = False
        '
        'btn_recieve
        '
        Me.btn_recieve.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_recieve.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_recieve.Location = New System.Drawing.Point(3, 500)
        Me.btn_recieve.Name = "btn_recieve"
        Me.btn_recieve.Size = New System.Drawing.Size(194, 50)
        Me.btn_recieve.TabIndex = 53
        Me.btn_recieve.UseVisualStyleBackColor = False
        '
        'btn_reciept
        '
        Me.btn_reciept.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_reciept.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reciept.Location = New System.Drawing.Point(3, 450)
        Me.btn_reciept.Name = "btn_reciept"
        Me.btn_reciept.Size = New System.Drawing.Size(194, 50)
        Me.btn_reciept.TabIndex = 55
        Me.btn_reciept.UseVisualStyleBackColor = False
        '
        'btn_calculator
        '
        Me.btn_calculator.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_calculator.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calculator.Location = New System.Drawing.Point(3, 400)
        Me.btn_calculator.Name = "btn_calculator"
        Me.btn_calculator.Size = New System.Drawing.Size(194, 50)
        Me.btn_calculator.TabIndex = 56
        Me.btn_calculator.UseVisualStyleBackColor = False
        '
        'btn_closeTransc
        '
        Me.btn_closeTransc.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_closeTransc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_closeTransc.Location = New System.Drawing.Point(3, 350)
        Me.btn_closeTransc.Name = "btn_closeTransc"
        Me.btn_closeTransc.Size = New System.Drawing.Size(194, 50)
        Me.btn_closeTransc.TabIndex = 58
        Me.btn_closeTransc.UseVisualStyleBackColor = False
        '
        'btn_editTransaction
        '
        Me.btn_editTransaction.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_editTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editTransaction.Location = New System.Drawing.Point(3, 100)
        Me.btn_editTransaction.Name = "btn_editTransaction"
        Me.btn_editTransaction.Size = New System.Drawing.Size(194, 50)
        Me.btn_editTransaction.TabIndex = 49
        Me.btn_editTransaction.UseVisualStyleBackColor = False
        '
        'btn_newTransc
        '
        Me.btn_newTransc.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_newTransc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newTransc.ImageList = Me.ImageList1
        Me.btn_newTransc.Location = New System.Drawing.Point(3, 0)
        Me.btn_newTransc.Name = "btn_newTransc"
        Me.btn_newTransc.Size = New System.Drawing.Size(194, 50)
        Me.btn_newTransc.TabIndex = 57
        Me.btn_newTransc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_newTransc.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(3, 50)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(194, 50)
        Me.btn_add.TabIndex = 51
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btn_saveTransaction
        '
        Me.btn_saveTransaction.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_saveTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_saveTransaction.Location = New System.Drawing.Point(3, 200)
        Me.btn_saveTransaction.Name = "btn_saveTransaction"
        Me.btn_saveTransaction.Size = New System.Drawing.Size(194, 50)
        Me.btn_saveTransaction.TabIndex = 54
        Me.btn_saveTransaction.UseVisualStyleBackColor = False
        '
        'btn_discardTransaction
        '
        Me.btn_discardTransaction.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_discardTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_discardTransaction.Location = New System.Drawing.Point(3, 300)
        Me.btn_discardTransaction.Name = "btn_discardTransaction"
        Me.btn_discardTransaction.Size = New System.Drawing.Size(194, 50)
        Me.btn_discardTransaction.TabIndex = 50
        Me.btn_discardTransaction.UseVisualStyleBackColor = False
        '
        'btn_loadTransc
        '
        Me.btn_loadTransc.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_loadTransc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_loadTransc.Location = New System.Drawing.Point(3, 250)
        Me.btn_loadTransc.Name = "btn_loadTransc"
        Me.btn_loadTransc.Size = New System.Drawing.Size(194, 50)
        Me.btn_loadTransc.TabIndex = 52
        Me.btn_loadTransc.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(486, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 15)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Transaction No. :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(227, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 15)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Invoice No. :"
        '
        'txt_totalDue
        '
        Me.txt_totalDue.BackColor = System.Drawing.SystemColors.Control
        Me.txt_totalDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalDue.Location = New System.Drawing.Point(308, 630)
        Me.txt_totalDue.Name = "txt_totalDue"
        Me.txt_totalDue.ReadOnly = True
        Me.txt_totalDue.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_totalDue.Size = New System.Drawing.Size(195, 20)
        Me.txt_totalDue.TabIndex = 44
        Me.txt_totalDue.Text = "0.00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(223, 631)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 15)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "Total Due :"
        '
        'txt_vat
        '
        Me.txt_vat.BackColor = System.Drawing.SystemColors.Control
        Me.txt_vat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_vat.Location = New System.Drawing.Point(308, 604)
        Me.txt_vat.Name = "txt_vat"
        Me.txt_vat.ReadOnly = True
        Me.txt_vat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_vat.Size = New System.Drawing.Size(195, 20)
        Me.txt_vat.TabIndex = 41
        Me.txt_vat.Text = "0.00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(222, 605)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 15)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "VAT (12%) :"
        '
        'txt_subTotal
        '
        Me.txt_subTotal.BackColor = System.Drawing.SystemColors.Control
        Me.txt_subTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subTotal.Location = New System.Drawing.Point(308, 551)
        Me.txt_subTotal.Name = "txt_subTotal"
        Me.txt_subTotal.ReadOnly = True
        Me.txt_subTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_subTotal.Size = New System.Drawing.Size(195, 20)
        Me.txt_subTotal.TabIndex = 42
        Me.txt_subTotal.Text = "0.00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(223, 552)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 15)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Sub Total  :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(227, 578)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 15)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Discount. :"
        '
        'txt_id
        '
        Me.txt_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_id.BackColor = System.Drawing.SystemColors.Control
        Me.txt_id.Location = New System.Drawing.Point(319, 135)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(154, 20)
        Me.txt_id.TabIndex = 46
        '
        'btn_bCode
        '
        Me.btn_bCode.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_bCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bCode.Location = New System.Drawing.Point(225, 131)
        Me.btn_bCode.Name = "btn_bCode"
        Me.btn_bCode.Size = New System.Drawing.Size(88, 27)
        Me.btn_bCode.TabIndex = 47
        Me.btn_bCode.Text = "Barcode"
        Me.btn_bCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_bCode.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.txt_change)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.txt_amount)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Location = New System.Drawing.Point(509, 550)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(365, 100)
        Me.Panel3.TabIndex = 48
        '
        'txt_change
        '
        Me.txt_change.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txt_change.Location = New System.Drawing.Point(166, 59)
        Me.txt_change.Name = "txt_change"
        Me.txt_change.ReadOnly = True
        Me.txt_change.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_change.Size = New System.Drawing.Size(170, 20)
        Me.txt_change.TabIndex = 52
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(34, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(126, 15)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "Amount Recieved :"
        '
        'txt_amount
        '
        Me.txt_amount.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txt_amount.Location = New System.Drawing.Point(166, 24)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.ReadOnly = True
        Me.txt_amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_amount.Size = New System.Drawing.Size(170, 20)
        Me.txt_amount.TabIndex = 50
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(96, 59)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 15)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "Change :"
        '
        'dgv_pos
        '
        Me.dgv_pos.AllowUserToAddRows = False
        Me.dgv_pos.AllowUserToDeleteRows = False
        Me.dgv_pos.AllowUserToResizeColumns = False
        Me.dgv_pos.AllowUserToResizeRows = False
        Me.dgv_pos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_pos.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv_pos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_pos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pos.Location = New System.Drawing.Point(206, 164)
        Me.dgv_pos.Name = "dgv_pos"
        Me.dgv_pos.ReadOnly = True
        Me.dgv_pos.RowHeadersVisible = False
        Me.dgv_pos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_pos.Size = New System.Drawing.Size(668, 381)
        Me.dgv_pos.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(486, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 15)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Transaction Time :"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.lbl_invoiceNo)
        Me.Panel4.Location = New System.Drawing.Point(319, 110)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(154, 20)
        Me.Panel4.TabIndex = 52
        '
        'lbl_invoiceNo
        '
        Me.lbl_invoiceNo.AutoSize = True
        Me.lbl_invoiceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_invoiceNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_invoiceNo.Location = New System.Drawing.Point(3, 3)
        Me.lbl_invoiceNo.Name = "lbl_invoiceNo"
        Me.lbl_invoiceNo.Size = New System.Drawing.Size(0, 15)
        Me.lbl_invoiceNo.TabIndex = 55
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.lbl_transcNo)
        Me.Panel5.Location = New System.Drawing.Point(618, 110)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(154, 20)
        Me.Panel5.TabIndex = 53
        '
        'lbl_transcNo
        '
        Me.lbl_transcNo.AutoSize = True
        Me.lbl_transcNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_transcNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_transcNo.Location = New System.Drawing.Point(3, 3)
        Me.lbl_transcNo.Name = "lbl_transcNo"
        Me.lbl_transcNo.Size = New System.Drawing.Size(0, 15)
        Me.lbl_transcNo.TabIndex = 56
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Control
        Me.Panel6.Controls.Add(Me.lbl_transctime)
        Me.Panel6.Location = New System.Drawing.Point(618, 135)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(154, 20)
        Me.Panel6.TabIndex = 54
        '
        'lbl_transctime
        '
        Me.lbl_transctime.AutoSize = True
        Me.lbl_transctime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_transctime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_transctime.Location = New System.Drawing.Point(3, 1)
        Me.lbl_transctime.Name = "lbl_transctime"
        Me.lbl_transctime.Size = New System.Drawing.Size(0, 15)
        Me.lbl_transctime.TabIndex = 36
        '
        'txt_discount
        '
        Me.txt_discount.BackColor = System.Drawing.SystemColors.Control
        Me.txt_discount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_discount.Location = New System.Drawing.Point(308, 577)
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.ReadOnly = True
        Me.txt_discount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_discount.Size = New System.Drawing.Size(195, 20)
        Me.txt_discount.TabIndex = 55
        Me.txt_discount.Text = "0.00"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label33.ForeColor = System.Drawing.Color.Khaki
        Me.Label33.Location = New System.Drawing.Point(284, 138)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(25, 13)
        Me.Label33.TabIndex = 82
        Me.Label33.Text = "F12"
        '
        'frm_PosSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(880, 659)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.txt_discount)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv_pos)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btn_bCode)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.txt_totalDue)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_vat)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_subTotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(880, 659)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(880, 659)
        Me.Name = "frm_PosSystem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgv_pos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_totalDue As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_vat As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_subTotal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents btn_bCode As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_change As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_amount As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btn_recieve As Button
    Friend WithEvents btn_reciept As Button
    Friend WithEvents btn_calculator As Button
    Friend WithEvents btn_closeTransc As Button
    Friend WithEvents btn_editTransaction As Button
    Friend WithEvents btn_newTransc As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_saveTransaction As Button
    Friend WithEvents btn_discardTransaction As Button
    Friend WithEvents btn_loadTransc As Button
    Friend WithEvents dgv_pos As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl_invoiceNo As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_transcNo As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lbl_transctime As Label
    Friend WithEvents txt_discount As TextBox
    Friend WithEvents btn_changeQuantity As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label33 As Label
End Class
