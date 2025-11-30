Public Class Formpay
    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        Dim cash As Double
        Dim balance As Double
        Dim inv As Double = -1

        If Double.TryParse(txtCash.Text, cash) Then
            If Double.TryParse(lblBalance.Text, balance) Then
                lblReBal.Text = balance - cash
                lblChange.Text = lblReBal.Text * inv
                If lblChange.Text < 0 Then
                    lblChange.Text = "0"
                ElseIf lblReBal.Text < 0 Then
                    lblReBal.Text = "0"
                End If
            End If
        End If
    End Sub

    Private Sub Formpay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblbalthismonth.Text = My.Settings.balthismonth
        lblFullName.Text = My.Settings.FullName
        lblAddress.Text = My.Settings.Address
        lblContact.Text = My.Settings.Contact
        lblCar.Text = My.Settings.Car
        lblBalance.Text = Main.txtBalance.Text
        lblReBal.Text = lblBalance.Text
        lblChange.Text = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.txtBalance.Text = lblReBal.Text
        lblBalance.Text = lblReBal.Text
        My.Settings.UserBal = Main.txtBalance.Text
        My.Settings.Save()
        txtCash.Clear()
        MessageBox.Show("Successfully Updated your Balance!", "Notice")
        Me.Hide()
        Main.Show()
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
    End Sub
End Class