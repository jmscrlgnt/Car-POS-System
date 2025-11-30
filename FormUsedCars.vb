Public Class FormUsedCars
    Dim tax As Double = 0.1
    Dim totalCost As Double
    Public Property ListViewItems As ListViewItem()
    Public Function GetListViewItems() As ListViewItem()
        Dim items As New List(Of ListViewItem)
        For Each item As ListViewItem In ListView1.Items
            items.Add(item)
        Next
        Return items.ToArray()
    End Function

    Private Sub AddListViewItems()
        If ListViewItems IsNot Nothing Then
            For Each item As ListViewItem In ListViewItems
                ListView1.Items.Add(item.Clone())
            Next
        End If
    End Sub

    Private Sub FormUsedCars_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddListViewItems()
        ListView1.View = View.Details
        ListView1.FullRowSelect = True
        ListView1.MultiSelect = False
        ListView1.Columns.Add("Model", 269, HorizontalAlignment.Center)
        ListView1.Columns.Add("Year", 160, HorizontalAlignment.Center)
        ListView1.Columns.Add("Color", 160, HorizontalAlignment.Center)
        ListView1.Columns.Add("Max Power/HP", 160, HorizontalAlignment.Center)
        ListView1.Columns.Add("Kilometers Driven", 160, HorizontalAlignment.Center)
        ListView1.Columns.Add("Condition", 160, HorizontalAlignment.Center)
        ListView1.Columns.Add("Price", 170, HorizontalAlignment.Center)
        ListView1.SelectedItems.Clear()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            If ListView1.SelectedItems(0).SubItems.Count > 0 Then
                car.Text = ListView1.SelectedItems(0).SubItems(0).Text
            Else
                car.Text = ListView1.SelectedItems(0).Text
            End If
        End If

        If ListView1.SelectedItems.Count > 0 Then
            If ListView1.SelectedItems(0).SubItems.Count > 0 Then
                colorc.Text = ListView1.SelectedItems(0).SubItems(2).Text
            Else
                colorc.Text = ListView1.SelectedItems(0).Text
            End If
        End If

        If ListView1.SelectedItems.Count > 0 Then
            If ListView1.SelectedItems(0).SubItems.Count > 0 Then
                price.Text = ListView1.SelectedItems(0).SubItems(6).Text.Replace("PHP ", "").Replace(",", "")
                totalCost = ListView1.SelectedItems(0).SubItems(6).Text.Replace("PHP ", "").Replace(",", "")
                btnProceedused.Visible = True
            Else
                price.Text = ListView1.SelectedItems(0).Text
                totalCost = ListView1.SelectedItems(0).Text
            End If
        Else
            btnProceedused.Visible = False
        End If
        Dim taxAmount As Double = totalCost * tax
        totalCost += taxAmount
        vat.Text = taxAmount
        total.Text = totalCost
        Return
    End Sub

    Private Sub price_TextChanged(sender As Object, e As EventArgs) Handles price.TextChanged
        CheckoutUsed.lblPrice.Text = price.Text
    End Sub

    Private Sub vat_TextChanged(sender As Object, e As EventArgs) Handles vat.TextChanged
        CheckoutUsed.lblVAT.Text = vat.Text
    End Sub

    Private Sub total_TextChanged(sender As Object, e As EventArgs) Handles total.TextChanged
        CheckoutUsed.lblTotal.Text = total.Text
    End Sub

    Private Sub btnProceedused_Click(sender As Object, e As EventArgs) Handles btnProceedused.Click
        If Me.ListView1.SelectedItems.Count > 0 Then
            Me.ListView1.Items.Remove(ListView1.SelectedItems(0))
        End If
        Me.Hide()
        CheckoutUsed.Show()
    End Sub

    Private Sub car_TextChanged(sender As Object, e As EventArgs) Handles car.TextChanged
        CheckoutUsed.lblCar.Text = car.Text
    End Sub

    Private Sub color_TextChanged(sender As Object, e As EventArgs) Handles colorc.TextChanged
        CheckoutUsed.lblColor.Text = colorc.Text
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With ListView1.Items.Add("MR-2 GTS")
            .SubItems.Add("1996")
            .SubItems.Add("Silver")
            .SubItems.Add("241 HP")
            .SubItems.Add("39222 KM")
            .SubItems.Add("Fair")
            .SubItems.Add("PHP 1145776")
        End With
        With ListView1.Items.Add("Vios")
            .SubItems.Add("2007")
            .SubItems.Add("Dark Red")
            .SubItems.Add("87 HP")
            .SubItems.Add("110976 KM")
            .SubItems.Add("Fair")
            .SubItems.Add("PHP 101079")
        End With
        With ListView1.Items.Add("CALDINA GT-T")
            .SubItems.Add("1998")
            .SubItems.Add("Super White")
            .SubItems.Add("212 HP")
            .SubItems.Add("133536 KM")
            .SubItems.Add("Fair")
            .SubItems.Add("PHP 1107746")
        End With
        With ListView1.Items.Add("MR-2 GTS")
            .SubItems.Add("1999")
            .SubItems.Add("Super White II")
            .SubItems.Add("246 HP")
            .SubItems.Add("39222 KM")
            .SubItems.Add("Fair")
            .SubItems.Add("PHP 997491")
        End With
        With ListView1.Items.Add("A80 Supra SZ-R")
            .SubItems.Add("1996")
            .SubItems.Add("Blue Mica")
            .SubItems.Add("226 HP")
            .SubItems.Add("97961 KM")
            .SubItems.Add("Good")
            .SubItems.Add("PHP 1436263")
        End With
        With ListView1.Items.Add("Prius")
            .SubItems.Add("2004")
            .SubItems.Add("Silver")
            .SubItems.Add("86 HP")
            .SubItems.Add("100769 KM")
            .SubItems.Add("Fair")
            .SubItems.Add("PHP 227923")
        End With
        With ListView1.Items.Add("Tacoma")
            .SubItems.Add("1997")
            .SubItems.Add("Dark Blue")
            .SubItems.Add("237 HP")
            .SubItems.Add("567006 KM")
            .SubItems.Add("Fair")
            .SubItems.Add("PHP 127464")
        End With
        With ListView1.Items.Add("A80 Supra SZ-R")
            .SubItems.Add("1998")
            .SubItems.Add("Super White II")
            .SubItems.Add("226 HP")
            .SubItems.Add("67497 KM")
            .SubItems.Add("Fair")
            .SubItems.Add("PHP 1067199")
        End With
        With ListView1.Items.Add("Aristo")
            .SubItems.Add("1998")
            .SubItems.Add("Silver")
            .SubItems.Add("260 HP")
            .SubItems.Add("116693 KM")
            .SubItems.Add("Fair")
            .SubItems.Add("PHP 175892")
        End With
        With ListView1.Items.Add("JZA70 Supra Twinturbo R")
            .SubItems.Add("1991")
            .SubItems.Add("Super Black")
            .SubItems.Add("270 HP")
            .SubItems.Add("158660 KM")
            .SubItems.Add("Fair")
            .SubItems.Add("PHP 608414")
        End With
        With ListView1.Items.Add("Vitz-F")
            .SubItems.Add("1999")
            .SubItems.Add("Blue Mica")
            .SubItems.Add("98 HP")
            .SubItems.Add("61220 KM")
            .SubItems.Add("Good")
            .SubItems.Add("PHP 177970")
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        paneladdcar.Visible = False
        btnBack.Visible = False
        back2.Visible = True
        Me.Hide()
        Adminform.Show()
    End Sub

    Private Sub back2_Click(sender As Object, e As EventArgs) Handles back2.Click
        Main.btnMenu.BackColor = Color.FromArgb(30, 30, 30)
        Main.btnNewCars.BackColor = Color.FromArgb(40, 40, 40)
        Main.btnUsedCars.BackColor = Color.FromArgb(40, 40, 40)
        Main.Panelbottom.Height = 0
        Main.Panelfill.Height = 647
        Main.Panelfill.Location = New Point(0, 50)
        While Main.Panelfill.Controls.Count > 0
            Main.Panelfill.Controls(0).Dispose()
        End While
        Dim nf As New FormMenu With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.WindowState = FormWindowState.Maximized
        nf.FormBorderStyle = FormBorderStyle.None
        nf.Dock = DockStyle.Fill
        Main.Panelfill.Controls.Add(nf)
        nf.Show()
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtCar.Text = "" Then
            MessageBox.Show("Invalid or Missing Parameters!", "Error")
        ElseIf txtmodel.Text = "" Then
            MessageBox.Show("Invalid or Missing Parameters!", "Error")
        ElseIf txtcolor.Text = "" Then
            MessageBox.Show("Invalid or Missing Parameters!", "Error")
        ElseIf txtpow.Text = "" Then
            MessageBox.Show("Invalid or Missing Parameters!", "Error")
        ElseIf txtmiles.Text = "" Then
            MessageBox.Show("Invalid or Missing Parameters!", "Error")
        ElseIf txtcondition.Text = "" Then
            MessageBox.Show("Invalid or Missing Parameters!", "Error")
        ElseIf txtpri.Text = "" Then
            MessageBox.Show("Invalid or Missing Parameters!", "Error")
        Else
            txtPrice.Text = "PHP " & txtPri.Text
            txtPower.Text = txtpow.Text & " HP"
            txtkilometer.Text = txtMiles.Text & " KM"
            Dim newItem As New ListViewItem({txtCar.Text, txtModel.Text, txtColor.Text, txtPower.Text, txtkilometer.Text, txtCondition.Text, txtPrice.Text})
            ListView1.Items.Add(newItem)
            txtCar.Clear()
            txtModel.Clear()
            txtColor.Clear()
            txtPower.Clear()
            txtkilometer.Clear()
            txtCondition.Clear()
            txtPrice.Clear()
            txtPri.Clear()
            txtpow.Clear()
            txtMiles.Clear()
        End If
    End Sub

    Private Sub txtpow_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtpow.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMiles_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtMiles.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPri_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtPri.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtModel_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtModel.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class