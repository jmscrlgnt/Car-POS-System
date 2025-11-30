Public Class CheckoutUsed
    Dim invalid As String = "Invalid or Missing Parameters!"
    Dim insufficient As String = "Insufficient Cash!"
    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
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

    Private Sub CheckoutUsed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblChange.Text = "Insufficient Cash!"
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Value = DateTime.Now
        txtdatetime.Text = DateTime.Today.ToString("MM/dd/yyyy")
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
        ElseIf txtContact.Text = "" Then
            MessageBox.Show(invalid)
        ElseIf lblChange.Text = "Insufficient Cash!" Then
            MessageBox.Show(insufficient)
        ElseIf lblChange.Text = "Invalid input" Or lblChange.Text = "Invalid total cost" Then
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
            TransactionSummary.lblcolor.Text = lblColor.Text
            TransactionSummary.lblBalance.Text = 0
            TransactionSummary.lblchange.Text = lblChange.Text
            txtLastName.Clear()
            txtFirstName.Clear()
            txtMI.Clear()
            txtAddress.Clear()
            txtCash.Clear()
            txtContact.Clear()
            If FormUsedCars.ListView1.SelectedItems.Count > 0 Then
                For Each selectedItem As ListViewItem In FormUsedCars.ListView1.SelectedItems
                    FormUsedCars.ListView1.Items.Remove(selectedItem)
                Next
            End If
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Main.Show()
        txtLastName.Clear()
        txtFirstName.Clear()
        txtMI.Clear()
        txtAddress.Clear()
        txtCash.Clear()
        txtContact.Clear()
        Main.btnMenu.BackColor = Color.FromArgb(40, 40, 40)
        Main.btnNewCars.BackColor = Color.FromArgb(40, 40, 40)
        Main.btnUsedCars.BackColor = Color.FromArgb(30, 30, 30)
        Main.Panelbottom.Height = 0
        Main.Panelfill.Height = 579
        Main.Panelfill.Location = New Point(0, 117)
        While Main.Panelfill.Controls.Count > 0
            Main.Panelfill.Controls(0).Dispose()
        End While
        Dim nf As New FormUsedCars With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.WindowState = FormWindowState.Maximized
        nf.FormBorderStyle = FormBorderStyle.None
        nf.Dock = DockStyle.Fill
        Main.Panelfill.Controls.Add(nf)
        nf.Show()
    End Sub
End Class