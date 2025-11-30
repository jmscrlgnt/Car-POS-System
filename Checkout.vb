Public Class CheckoutNew
    Dim invalid As String = "Invalid or Missing Parameters!"
    Dim insufficient As String = "Insufficient Cash!"
    Dim monthly As String = 0.083
    Dim tax As Double = 0.1
    Dim totalCost As Double
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        Dim cash As Double
        Dim totalCost As Double

        If Double.TryParse(txtCash.Text, cash) Then
            Dim totalText As String = lblTotal.Text.Replace(" / Month", "")
            If Double.TryParse(totalText, totalCost) Then
                Dim change As Double = cash - totalCost
                If change < 0 Then
                    lblChange.Text = "Insufficient Cash!"
                Else
                    lblChange.Text = change.ToString()
                End If
            Else
                lblChange.Text = "Invalid total cost"
            End If
        Else
            lblChange.Text = "Invalid input"
        End If
    End Sub

    Private Sub CheckoutNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblChange.Text = "Insufficient Cash!"
        cbMethod.Items.Add("Monthly (12 Months)")
        cbMethod.Items.Add("Full")
        txtcalprice.Text = txtprice.Text
        cbMethod.SelectedItem = "Full"
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Value = DateTime.Now
        txtdatetime.Text = DateTime.Today.ToString("MM/dd/yyyy")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Main.Show()
        txtLastName.Clear()
        txtFirstName.Clear()
        txtMI.Clear()
        txtAddress.Clear()
        txtCash.Clear()
        txtContact.Clear()
        cbColours.Items.Clear()
        Main.btnMenu.BackColor = Color.FromArgb(40, 40, 40)
        Main.btnNewCars.BackColor = Color.FromArgb(30, 30, 30)
        Main.btnUsedCars.BackColor = Color.FromArgb(40, 40, 40)
        Main.Panelbottom.Height = 0
        Main.Panelfill.Height = 579
        Main.Panelfill.Location = New Point(0, 117)
        While Main.Panelfill.Controls.Count > 0
            Main.Panelfill.Controls(0).Dispose()
        End While
        Dim nf As New FormNewCars With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.WindowState = FormWindowState.Maximized
        nf.FormBorderStyle = FormBorderStyle.None
        nf.Dock = DockStyle.Fill
        Main.Panelfill.Controls.Add(nf)
        nf.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtLastName.Text = "" Then
            MessageBox.Show(invalid)
        ElseIf txtFirstName.Text = "" Then
            MessageBox.Show(invalid)
        ElseIf txtMI.Text = "" Then
            MessageBox.Show(invalid)
        ElseIf txtAddress.Text = "" Then
            MessageBox.Show(invalid)
        ElseIf txtcontact.Text = "" Then
            MessageBox.Show(invalid)
        ElseIf cbColours.Text = "" Then
            MessageBox.Show(invalid)
        ElseIf lblChange.Text = "Insufficient Cash!" Then
            MessageBox.Show(insufficient)
        ElseIf lblChange.text = "Invalid input" Or lblChange.Text = "Invalid total cost" Then
            MessageBox.Show(invalid)
        ElseIf txtContact.TextLength < 11 Then
            MessageBox.Show("Contact number required length is 11")
        Else
            MessageBox.Show("Payment Successful!", "Notice")
            Me.Hide()
            TransactionSummary.Show()
            TransactionSummary.txtCash.Text = txtCash.Text
            TransactionSummary.txtdatetimesummary.Text = txtdatetime.Text
            TransactionSummary.fullname.Text = txtLastName.Text
            TransactionSummary.fullname.AppendText(", ")
            TransactionSummary.fullname.AppendText(txtFirstName.Text)
            TransactionSummary.fullname.AppendText(" ")
            TransactionSummary.fullname.AppendText(txtMI.Text)
            TransactionSummary.lblFullName.Text = TransactionSummary.fullname.Text
            TransactionSummary.lblAddress.Text = txtAddress.Text
            TransactionSummary.lblContact.Text = txtContact.Text
            TransactionSummary.lblCar.Text = lblCar.Text
            TransactionSummary.lblcolor.Text = cbColours.Text
            TransactionSummary.lblchange.Text = lblChange.Text
            Dim monprice As Double = txttotalcost.Text.Replace(" / Month", "")
            Dim fullprice As Double = calpricevat.Text
            txtbalance.Text = fullprice - monprice
            TransactionSummary.lblBalance.Text = txtbalance.Text
            txtLastName.Clear()
            txtFirstName.Clear()
            txtMI.Clear()
            txtAddress.Clear()
            txtCash.Clear()
            txtContact.Clear()
            cbColours.Items.Clear()
        End If
    End Sub

    Private Sub txtContact_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " " Then
        e.Handled = True
        End If
    End Sub

    Private Sub cbMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMethod.SelectedIndexChanged
        If cbMethod.SelectedItem = "Full" Then
            txtcalprice.Text = txtprice.Text
            CalculateCost()
            lblPrice.Text = txtcalprice.Text
            lblVAT.Text = vat.Text
            lblTotal.Text = txttotalcost.Text
        ElseIf cbMethod.SelectedItem = "Monthly (12 Months)" Then
            txtcalprice.Text = txtprice.Text * monthly
            CalculateCost()
            txttotalcost.AppendText(" / Month")
            lblPrice.Text = txtcalprice.Text
            lblVAT.Text = vat.Text
            lblTotal.Text = txttotalcost.Text
        End If
    End Sub
    Private Sub CalculateCost()
        totalCost = txtcalprice.Text
        Dim taxAmount As Double = totalCost * tax
        totalCost += taxAmount
        vat.Text = taxAmount
        txttotalcost.Text = totalCost
    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.TextChanged
        My.Settings.balthismonth = lblTotal.Text.Replace(" / Month", "")
        My.Settings.Save()
    End Sub

    Private Sub lblTotal_Click_1(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub
End Class