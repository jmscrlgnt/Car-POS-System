<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckoutNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckoutNew))
        Me.cbColours = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCar = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbMethod = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblVAT = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtMI = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.vat = New System.Windows.Forms.TextBox()
        Me.txttotalcost = New System.Windows.Forms.TextBox()
        Me.txtcalprice = New System.Windows.Forms.TextBox()
        Me.txtbalance = New System.Windows.Forms.TextBox()
        Me.calpricevat = New System.Windows.Forms.TextBox()
        Me.txtdatetime = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbColours
        '
        Me.cbColours.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cbColours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbColours.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbColours.ForeColor = System.Drawing.Color.White
        Me.cbColours.FormattingEnabled = True
        Me.cbColours.Location = New System.Drawing.Point(184, 245)
        Me.cbColours.Name = "cbColours"
        Me.cbColours.Size = New System.Drawing.Size(210, 24)
        Me.cbColours.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(456, 58)
        Me.Panel1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(338, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 42)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "< Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Register your Car"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(39, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Car:"
        '
        'lblCar
        '
        Me.lblCar.AutoSize = True
        Me.lblCar.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCar.ForeColor = System.Drawing.Color.White
        Me.lblCar.Location = New System.Drawing.Point(181, 93)
        Me.lblCar.Name = "lblCar"
        Me.lblCar.Size = New System.Drawing.Size(53, 18)
        Me.lblCar.TabIndex = 3
        Me.lblCar.Text = "lblCar"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(39, 131)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(52, 18)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Price:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel2.Controls.Add(Me.cbMethod)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.lblChange)
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Controls.Add(Me.lblVAT)
        Me.Panel2.Controls.Add(Me.lblPrice)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txtCash)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.label3)
        Me.Panel2.Controls.Add(Me.lblCar)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cbColours)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 309)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(456, 487)
        Me.Panel2.TabIndex = 5
        '
        'cbMethod
        '
        Me.cbMethod.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMethod.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbMethod.ForeColor = System.Drawing.Color.White
        Me.cbMethod.FormattingEnabled = True
        Me.cbMethod.Location = New System.Drawing.Point(185, 287)
        Me.cbMethod.Name = "cbMethod"
        Me.cbMethod.Size = New System.Drawing.Size(210, 24)
        Me.cbMethod.TabIndex = 23
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(42, 290)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 18)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Payment:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(0, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(455, 71)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Proceed to Checkout"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.Color.White
        Me.lblChange.Location = New System.Drawing.Point(181, 375)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(82, 18)
        Me.lblChange.TabIndex = 20
        Me.lblChange.Text = "lblChange"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(182, 209)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(65, 18)
        Me.lblTotal.TabIndex = 19
        Me.lblTotal.Text = "lblTotal"
        '
        'lblVAT
        '
        Me.lblVAT.AutoSize = True
        Me.lblVAT.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVAT.ForeColor = System.Drawing.Color.White
        Me.lblVAT.Location = New System.Drawing.Point(181, 168)
        Me.lblVAT.Name = "lblVAT"
        Me.lblVAT.Size = New System.Drawing.Size(56, 18)
        Me.lblVAT.TabIndex = 18
        Me.lblVAT.Text = "lblVAT"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.White
        Me.lblPrice.Location = New System.Drawing.Point(181, 131)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(66, 18)
        Me.lblPrice.TabIndex = 17
        Me.lblPrice.Text = "lblPrice"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(40, 375)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 18)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Change:"
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCash.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCash.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtCash.ForeColor = System.Drawing.Color.White
        Me.txtCash.Location = New System.Drawing.Point(184, 332)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(210, 19)
        Me.txtCash.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(42, 332)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 18)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Cash:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(40, 250)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 18)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Color:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(39, 209)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 18)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Total:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(39, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 18)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "VAT (10%):"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel3.Controls.Add(Me.DateTimePicker1)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(456, 64)
        Me.Panel3.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(228, 22)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 4
        Me.DateTimePicker1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(24, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 23)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Purchase Info"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(39, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "First Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(40, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Last Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(39, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "M.I.:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(39, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 18)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Address:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(39, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 18)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Contact No.:"
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLastName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtLastName.ForeColor = System.Drawing.Color.White
        Me.txtLastName.Location = New System.Drawing.Point(184, 85)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(210, 19)
        Me.txtLastName.TabIndex = 10
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirstName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtFirstName.ForeColor = System.Drawing.Color.White
        Me.txtFirstName.Location = New System.Drawing.Point(184, 127)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(210, 19)
        Me.txtFirstName.TabIndex = 11
        '
        'txtMI
        '
        Me.txtMI.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtMI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMI.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtMI.ForeColor = System.Drawing.Color.White
        Me.txtMI.Location = New System.Drawing.Point(184, 171)
        Me.txtMI.MaxLength = 2
        Me.txtMI.Name = "txtMI"
        Me.txtMI.Size = New System.Drawing.Size(210, 19)
        Me.txtMI.TabIndex = 12
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddress.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtAddress.ForeColor = System.Drawing.Color.White
        Me.txtAddress.Location = New System.Drawing.Point(184, 214)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(210, 19)
        Me.txtAddress.TabIndex = 13
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContact.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtContact.ForeColor = System.Drawing.Color.White
        Me.txtContact.Location = New System.Drawing.Point(184, 261)
        Me.txtContact.MaxLength = 11
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(210, 19)
        Me.txtContact.TabIndex = 14
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(690, 154)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(100, 20)
        Me.txtprice.TabIndex = 15
        '
        'vat
        '
        Me.vat.Location = New System.Drawing.Point(690, 191)
        Me.vat.Name = "vat"
        Me.vat.Size = New System.Drawing.Size(100, 20)
        Me.vat.TabIndex = 16
        '
        'txttotalcost
        '
        Me.txttotalcost.Location = New System.Drawing.Point(690, 232)
        Me.txttotalcost.Name = "txttotalcost"
        Me.txttotalcost.Size = New System.Drawing.Size(100, 20)
        Me.txttotalcost.TabIndex = 17
        '
        'txtcalprice
        '
        Me.txtcalprice.Location = New System.Drawing.Point(690, 109)
        Me.txtcalprice.Name = "txtcalprice"
        Me.txtcalprice.Size = New System.Drawing.Size(100, 20)
        Me.txtcalprice.TabIndex = 18
        '
        'txtbalance
        '
        Me.txtbalance.Location = New System.Drawing.Point(816, 109)
        Me.txtbalance.Name = "txtbalance"
        Me.txtbalance.Size = New System.Drawing.Size(100, 20)
        Me.txtbalance.TabIndex = 19
        Me.txtbalance.Text = "0"
        '
        'calpricevat
        '
        Me.calpricevat.Location = New System.Drawing.Point(816, 154)
        Me.calpricevat.Name = "calpricevat"
        Me.calpricevat.Size = New System.Drawing.Size(100, 20)
        Me.calpricevat.TabIndex = 20
        '
        'txtdatetime
        '
        Me.txtdatetime.Location = New System.Drawing.Point(816, 191)
        Me.txtdatetime.Name = "txtdatetime"
        Me.txtdatetime.Size = New System.Drawing.Size(100, 20)
        Me.txtdatetime.TabIndex = 21
        '
        'CheckoutNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(456, 796)
        Me.Controls.Add(Me.txtdatetime)
        Me.Controls.Add(Me.calpricevat)
        Me.Controls.Add(Me.txtbalance)
        Me.Controls.Add(Me.txtcalprice)
        Me.Controls.Add(Me.txttotalcost)
        Me.Controls.Add(Me.vat)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtMI)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CheckoutNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Checkout"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbColours As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCar As Label
    Friend WithEvents label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lblChange As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblVAT As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtCash As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMI As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents cbMethod As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtprice As TextBox
    Friend WithEvents vat As TextBox
    Friend WithEvents txttotalcost As TextBox
    Friend WithEvents txtcalprice As TextBox
    Friend WithEvents txtbalance As TextBox
    Friend WithEvents calpricevat As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtdatetime As TextBox
End Class
