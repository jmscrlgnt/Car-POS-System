<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransactionSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransactionSummary))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.fullname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCar = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblcolor = New System.Windows.Forms.Label()
        Me.lblchange = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.txtdatetimesummary = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(583, 56)
        Me.Panel1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(463, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 42)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "< Back"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Transaction Summary"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(25, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Registered Name:"
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.Color.White
        Me.lblFullName.Location = New System.Drawing.Point(188, 91)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(98, 18)
        Me.lblFullName.TabIndex = 8
        Me.lblFullName.Text = "lblFullName"
        '
        'fullname
        '
        Me.fullname.Location = New System.Drawing.Point(965, 120)
        Me.fullname.Name = "fullname"
        Me.fullname.Size = New System.Drawing.Size(100, 20)
        Me.fullname.TabIndex = 9
        Me.fullname.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Address:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.White
        Me.lblAddress.Location = New System.Drawing.Point(188, 133)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(87, 18)
        Me.lblAddress.TabIndex = 11
        Me.lblAddress.Text = "lblAddress"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(25, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Contact No.:"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.Color.White
        Me.lblContact.Location = New System.Drawing.Point(188, 180)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(84, 18)
        Me.lblContact.TabIndex = 13
        Me.lblContact.Text = "lblContact"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(25, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 18)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Car:"
        '
        'lblCar
        '
        Me.lblCar.AutoSize = True
        Me.lblCar.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCar.ForeColor = System.Drawing.Color.White
        Me.lblCar.Location = New System.Drawing.Point(188, 225)
        Me.lblCar.Name = "lblCar"
        Me.lblCar.Size = New System.Drawing.Size(53, 18)
        Me.lblCar.TabIndex = 15
        Me.lblCar.Text = "lblCar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(25, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 18)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Color:"
        '
        'lblcolor
        '
        Me.lblcolor.AutoSize = True
        Me.lblcolor.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcolor.ForeColor = System.Drawing.Color.White
        Me.lblcolor.Location = New System.Drawing.Point(188, 272)
        Me.lblcolor.Name = "lblcolor"
        Me.lblcolor.Size = New System.Drawing.Size(67, 18)
        Me.lblcolor.TabIndex = 17
        Me.lblcolor.Text = "lblColor"
        '
        'lblchange
        '
        Me.lblchange.AutoSize = True
        Me.lblchange.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchange.ForeColor = System.Drawing.Color.White
        Me.lblchange.Location = New System.Drawing.Point(188, 376)
        Me.lblchange.Name = "lblchange"
        Me.lblchange.Size = New System.Drawing.Size(82, 18)
        Me.lblchange.TabIndex = 20
        Me.lblchange.Text = "lblChange"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(25, 376)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 18)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Change:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(0, 435)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(583, 71)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Back to Home"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(25, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Balance:"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.ForeColor = System.Drawing.Color.White
        Me.lblBalance.Location = New System.Drawing.Point(188, 325)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(86, 18)
        Me.lblBalance.TabIndex = 24
        Me.lblBalance.Text = "lblBalance"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.ListView1.ForeColor = System.Drawing.Color.White
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 56)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1086, 539)
        Me.ListView1.TabIndex = 25
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.Visible = False
        '
        'txtdatetimesummary
        '
        Me.txtdatetimesummary.Location = New System.Drawing.Point(463, 180)
        Me.txtdatetimesummary.Name = "txtdatetimesummary"
        Me.txtdatetimesummary.Size = New System.Drawing.Size(100, 20)
        Me.txtdatetimesummary.TabIndex = 26
        Me.txtdatetimesummary.Visible = False
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(463, 223)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(100, 20)
        Me.txtUserName.TabIndex = 27
        Me.txtUserName.Visible = False
        '
        'txtCash
        '
        Me.txtCash.Location = New System.Drawing.Point(463, 273)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(100, 20)
        Me.txtCash.TabIndex = 28
        Me.txtCash.Visible = False
        '
        'TransactionSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(583, 505)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.txtdatetimesummary)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblchange)
        Me.Controls.Add(Me.lblcolor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fullname)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TransactionSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summary"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents fullname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCar As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblcolor As Label
    Friend WithEvents lblchange As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button2 As Button
    Friend WithEvents txtdatetimesummary As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtCash As TextBox
End Class
