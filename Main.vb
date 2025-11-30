Public Class Main
    Private IsClosed As Boolean
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = My.Settings.Username
        FormNewCars.optGRSupra.Checked = False
        btnMenu.BackColor = Color.FromArgb(30, 30, 30)
        Panelbottom.Height = 0
        Panelfill.Height = 647
        Panelfill.Location = New Point(0, 50)
        Dim nf As New FormMenu With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.WindowState = FormWindowState.Maximized
        nf.FormBorderStyle = FormBorderStyle.None
        nf.Dock = DockStyle.Fill
        Me.Panelfill.Controls.Add(nf)
        nf.Show()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        btnMenu.BackColor = Color.FromArgb(30, 30, 30)
        btnNewCars.BackColor = Color.FromArgb(40, 40, 40)
        btnUsedCars.BackColor = Color.FromArgb(40, 40, 40)
        Panelbottom.Height = 0
        Panelfill.Height = 647
        Panelfill.Location = New Point(0, 50)
        While Me.Panelfill.Controls.Count > 0
            Me.Panelfill.Controls(0).Dispose()
        End While
        Dim nf As New FormMenu With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.WindowState = FormWindowState.Maximized
        nf.FormBorderStyle = FormBorderStyle.None
        nf.Dock = DockStyle.Fill
        Me.Panelfill.Controls.Add(nf)
        nf.Show()
        FormUsedCars.Hide()
    End Sub

    Private Sub btnNewCars_Click(sender As Object, e As EventArgs) Handles btnNewCars.Click
        btnMenu.BackColor = Color.FromArgb(40, 40, 40)
        btnNewCars.BackColor = Color.FromArgb(30, 30, 30)
        btnUsedCars.BackColor = Color.FromArgb(40, 40, 40)
        Panelbottom.Height = 0
        Panelfill.Height = 579
        Panelfill.Location = New Point(0, 117)
        While Me.Panelfill.Controls.Count > 0
            Me.Panelfill.Controls(0).Dispose()
        End While
        Dim nf As New FormNewCars With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.WindowState = FormWindowState.Maximized
        nf.FormBorderStyle = FormBorderStyle.None
        nf.Dock = DockStyle.Fill
        Me.Panelfill.Controls.Add(nf)
        nf.Show()
        FormUsedCars.Hide()
    End Sub

    Private Sub btnUsedCars_Click(sender As Object, e As EventArgs) Handles btnUsedCars.Click
        btnMenu.BackColor = Color.FromArgb(40, 40, 40)
        btnNewCars.BackColor = Color.FromArgb(40, 40, 40)
        btnUsedCars.BackColor = Color.FromArgb(30, 30, 30)
        Panelbottom.Height = 0
        Me.Hide()
        FormUsedCars.Show()
        FormUsedCars.btnBack.Visible = False
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panelfill.Paint

    End Sub

    Private Sub btnProceednew_Click(sender As Object, e As EventArgs) Handles btnProceednew.Click
        CheckoutNew.cbMethod.SelectedItem = "Full"
        Me.Close()
        CheckoutNew.Show()
    End Sub

    Private Sub txtBalance_TextChanged(sender As Object, e As EventArgs) Handles txtBalance.TextChanged
        If txtBalance.Text > 0 Then
            btnNewCars.Enabled = False
            btnUsedCars.Enabled = False
            Label11.Visible = True
            LinkLabel1.Visible = True
            Adminform.lblstatus.Text = "Incomplete"
        Else
            btnNewCars.Enabled = True
            btnUsedCars.Enabled = True
            Label11.Visible = False
            LinkLabel1.Visible = False

        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Formpay.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtBalance.Text = My.Settings.UserBal
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.UserBal = txtBalance.Text
        My.Settings.Save()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Hide()
            Login.Show()
        Else
            Return
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        TransactionSummary.Width = 1070
        TransactionSummary.Height = 541
        TransactionSummary.Show()
        TransactionSummary.Label6.Visible = False
        TransactionSummary.lblFullName.Visible = False
        TransactionSummary.Label2.Visible = False
        TransactionSummary.lblAddress.Visible = False
        TransactionSummary.Label3.Visible = False
        TransactionSummary.lblContact.Visible = False
        TransactionSummary.Label4.Visible = False
        TransactionSummary.lblCar.Visible = False
        TransactionSummary.Label5.Visible = False
        TransactionSummary.lblcolor.Visible = False
        TransactionSummary.Label7.Visible = False
        TransactionSummary.lblBalance.Visible = False
        TransactionSummary.Label11.Visible = False
        TransactionSummary.lblchange.Visible = False
        TransactionSummary.Label1.Text = "Transaction History"
        TransactionSummary.ListView1.Visible = True
        TransactionSummary.Button1.Visible = False
        TransactionSummary.Button2.Visible = True
        TransactionSummary.Button2.Location = New Point(954, 8)
    End Sub

    Private Sub btnProceedused_Click(sender As Object, e As EventArgs)
        If FormUsedCars.ListView1.SelectedItems.Count > 0 Then
            FormUsedCars.ListView1.Items.Remove(FormUsedCars.ListView1.SelectedItems(0))
            Dim formused As New FormUsedCars()
            Dim listViewItems As ListViewItem() = FormUsedCars.GetListViewItems()
        End If
        'Main.Hide()
        'CheckoutUsed.Show()
    End Sub
End Class