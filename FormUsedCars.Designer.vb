<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUsedCars
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUsedCars))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.back2 = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.price = New System.Windows.Forms.TextBox()
        Me.vat = New System.Windows.Forms.TextBox()
        Me.total = New System.Windows.Forms.TextBox()
        Me.btnProceedused = New System.Windows.Forms.Button()
        Me.car = New System.Windows.Forms.TextBox()
        Me.colorc = New System.Windows.Forms.TextBox()
        Me.paneladdcar = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPri = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCondition = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpow = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCar = New System.Windows.Forms.TextBox()
        Me.txtPower = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtkilometer = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.paneladdcar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel2.Controls.Add(Me.back2)
        Me.Panel2.Controls.Add(Me.btnBack)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1251, 53)
        Me.Panel2.TabIndex = 8
        '
        'back2
        '
        Me.back2.BackColor = System.Drawing.Color.Transparent
        Me.back2.FlatAppearance.BorderSize = 0
        Me.back2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.back2.ForeColor = System.Drawing.Color.White
        Me.back2.Location = New System.Drawing.Point(1128, 4)
        Me.back2.Name = "back2"
        Me.back2.Size = New System.Drawing.Size(108, 42)
        Me.back2.TabIndex = 5
        Me.back2.Text = "< Back"
        Me.back2.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(1139, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(108, 42)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "< Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Used Car Line Up"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.White
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 52)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1250, 529)
        Me.ListView1.TabIndex = 9
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'price
        '
        Me.price.Location = New System.Drawing.Point(1341, 98)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(100, 20)
        Me.price.TabIndex = 10
        '
        'vat
        '
        Me.vat.Location = New System.Drawing.Point(1341, 144)
        Me.vat.Name = "vat"
        Me.vat.Size = New System.Drawing.Size(100, 20)
        Me.vat.TabIndex = 11
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(1341, 190)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(100, 20)
        Me.total.TabIndex = 12
        '
        'btnProceedused
        '
        Me.btnProceedused.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnProceedused.FlatAppearance.BorderSize = 0
        Me.btnProceedused.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProceedused.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnProceedused.ForeColor = System.Drawing.Color.White
        Me.btnProceedused.Location = New System.Drawing.Point(1, 519)
        Me.btnProceedused.Name = "btnProceedused"
        Me.btnProceedused.Size = New System.Drawing.Size(1262, 62)
        Me.btnProceedused.TabIndex = 13
        Me.btnProceedused.Text = "Proceed"
        Me.btnProceedused.UseVisualStyleBackColor = False
        Me.btnProceedused.Visible = False
        '
        'car
        '
        Me.car.Location = New System.Drawing.Point(1341, 251)
        Me.car.Name = "car"
        Me.car.Size = New System.Drawing.Size(100, 20)
        Me.car.TabIndex = 14
        '
        'colorc
        '
        Me.colorc.Location = New System.Drawing.Point(1341, 318)
        Me.colorc.Name = "colorc"
        Me.colorc.Size = New System.Drawing.Size(100, 20)
        Me.colorc.TabIndex = 15
        '
        'paneladdcar
        '
        Me.paneladdcar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.paneladdcar.Controls.Add(Me.Button2)
        Me.paneladdcar.Controls.Add(Me.Button1)
        Me.paneladdcar.Controls.Add(Me.Label9)
        Me.paneladdcar.Controls.Add(Me.txtPri)
        Me.paneladdcar.Controls.Add(Me.Label8)
        Me.paneladdcar.Controls.Add(Me.txtCondition)
        Me.paneladdcar.Controls.Add(Me.Label7)
        Me.paneladdcar.Controls.Add(Me.txtMiles)
        Me.paneladdcar.Controls.Add(Me.Label5)
        Me.paneladdcar.Controls.Add(Me.txtpow)
        Me.paneladdcar.Controls.Add(Me.Label4)
        Me.paneladdcar.Controls.Add(Me.txtColor)
        Me.paneladdcar.Controls.Add(Me.Label3)
        Me.paneladdcar.Controls.Add(Me.txtModel)
        Me.paneladdcar.Controls.Add(Me.Label6)
        Me.paneladdcar.Controls.Add(Me.txtCar)
        Me.paneladdcar.Location = New System.Drawing.Point(0, 421)
        Me.paneladdcar.Name = "paneladdcar"
        Me.paneladdcar.Size = New System.Drawing.Size(1251, 160)
        Me.paneladdcar.TabIndex = 16
        Me.paneladdcar.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(3, 162)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(1247, 62)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Use a preset (for demo)"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(0, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1247, 62)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Add Car"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(1093, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 18)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Price:"
        '
        'txtPri
        '
        Me.txtPri.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtPri.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPri.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtPri.ForeColor = System.Drawing.Color.White
        Me.txtPri.Location = New System.Drawing.Point(1096, 19)
        Me.txtPri.MaxLength = 12
        Me.txtPri.Name = "txtPri"
        Me.txtPri.Size = New System.Drawing.Size(119, 19)
        Me.txtPri.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(920, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 18)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Condition:"
        '
        'txtCondition
        '
        Me.txtCondition.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtCondition.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCondition.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtCondition.ForeColor = System.Drawing.Color.White
        Me.txtCondition.Location = New System.Drawing.Point(923, 19)
        Me.txtCondition.Name = "txtCondition"
        Me.txtCondition.Size = New System.Drawing.Size(119, 19)
        Me.txtCondition.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(746, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 18)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Miles Driven:"
        '
        'txtMiles
        '
        Me.txtMiles.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtMiles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMiles.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtMiles.ForeColor = System.Drawing.Color.White
        Me.txtMiles.Location = New System.Drawing.Point(749, 19)
        Me.txtMiles.MaxLength = 8
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(119, 19)
        Me.txtMiles.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(600, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 18)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Max Power:"
        '
        'txtpow
        '
        Me.txtpow.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtpow.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpow.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtpow.ForeColor = System.Drawing.Color.White
        Me.txtpow.Location = New System.Drawing.Point(603, 19)
        Me.txtpow.MaxLength = 4
        Me.txtpow.Name = "txtpow"
        Me.txtpow.Size = New System.Drawing.Size(93, 19)
        Me.txtpow.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(425, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 18)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Color:"
        '
        'txtColor
        '
        Me.txtColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtColor.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtColor.ForeColor = System.Drawing.Color.White
        Me.txtColor.Location = New System.Drawing.Point(428, 19)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(119, 19)
        Me.txtColor.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(259, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 18)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Model Year:"
        '
        'txtModel
        '
        Me.txtModel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtModel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtModel.ForeColor = System.Drawing.Color.White
        Me.txtModel.Location = New System.Drawing.Point(262, 19)
        Me.txtModel.MaxLength = 4
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(119, 19)
        Me.txtModel.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(14, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 18)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Model:"
        '
        'txtCar
        '
        Me.txtCar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtCar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCar.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtCar.ForeColor = System.Drawing.Color.White
        Me.txtCar.Location = New System.Drawing.Point(17, 19)
        Me.txtCar.Name = "txtCar"
        Me.txtCar.Size = New System.Drawing.Size(196, 19)
        Me.txtCar.TabIndex = 22
        '
        'txtPower
        '
        Me.txtPower.Location = New System.Drawing.Point(923, 75)
        Me.txtPower.Name = "txtPower"
        Me.txtPower.Size = New System.Drawing.Size(100, 20)
        Me.txtPower.TabIndex = 17
        Me.txtPower.Visible = False
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(923, 110)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 18
        Me.txtPrice.Visible = False
        '
        'txtkilometer
        '
        Me.txtkilometer.Location = New System.Drawing.Point(923, 155)
        Me.txtkilometer.Name = "txtkilometer"
        Me.txtkilometer.Size = New System.Drawing.Size(100, 20)
        Me.txtkilometer.TabIndex = 19
        Me.txtkilometer.Visible = False
        '
        'FormUsedCars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1248, 581)
        Me.Controls.Add(Me.txtkilometer)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtPower)
        Me.Controls.Add(Me.paneladdcar)
        Me.Controls.Add(Me.colorc)
        Me.Controls.Add(Me.car)
        Me.Controls.Add(Me.btnProceedused)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.vat)
        Me.Controls.Add(Me.price)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormUsedCars"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUsedCars"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.paneladdcar.ResumeLayout(False)
        Me.paneladdcar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents price As TextBox
    Friend WithEvents vat As TextBox
    Friend WithEvents total As TextBox
    Friend WithEvents btnProceedused As Button
    Friend WithEvents car As TextBox
    Friend WithEvents colorc As TextBox
    Friend WithEvents paneladdcar As Panel
    Friend WithEvents txtCar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtColor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtpow As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMiles As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCondition As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPri As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents back2 As Button
    Friend WithEvents txtPower As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtkilometer As TextBox
End Class
