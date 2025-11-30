Public Class TransactionSummary
    Private listViewItems As New List(Of ListViewItem)
    Private Sub TransactionSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm()
        lblFullName.Text = fullname.Text
        txtUserName.Text = My.Settings.Username
        ListView1.View = View.Details
        ListView1.FullRowSelect = True
        ListView1.MultiSelect = False
        ListView1.Columns.Add("User", 120, HorizontalAlignment.Center)
        ListView1.Columns.Add("Name", 170, HorizontalAlignment.Center)
        ListView1.Columns.Add("Model", 160, HorizontalAlignment.Center)
        ListView1.Columns.Add("Color", 120, HorizontalAlignment.Center)
        ListView1.Columns.Add("Cash", 120, HorizontalAlignment.Center)
        ListView1.Columns.Add("Change", 120, HorizontalAlignment.Center)
        ListView1.Columns.Add("Date", 135, HorizontalAlignment.Center)
        ListView1.Columns.Add("Balance", 120, HorizontalAlignment.Center)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newItem As New ListViewItem({txtUserName.Text, lblFullName.Text, lblCar.Text, lblcolor.Text, txtCash.Text, lblchange.Text, txtdatetimesummary.Text, lblBalance.Text})
        ListView1.Items.Add(newItem)
        listViewItems.Add(newItem)
        Formpay.lblFullName.Text = lblFullName.Text
        Formpay.lblAddress.Text = lblAddress.Text
        Formpay.lblBalance.Text = lblBalance.Text
        Formpay.lblCar.Text = lblCar.Text
        Formpay.lblContact.Text = lblContact.Text
        Main.txtBalance.Text = lblBalance.Text
        My.Settings.FullName = lblFullName.Text
        My.Settings.Address = lblAddress.Text
        My.Settings.Contact = lblContact.Text
        My.Settings.Car = lblCar.Text
        My.Settings.UserBal = Main.txtBalance.Text
        My.Settings.Save()
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

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Width = 583
        Height = 505
        Me.Hide()
        Main.Show()
        Label6.Visible = True
        lblFullName.Visible = True
        Label2.Visible = True
        lblAddress.Visible = True
        Label3.Visible = True
        lblContact.Visible = True
        Label4.Visible = True
        lblCar.Visible = True
        Label5.Visible = True
        lblcolor.Visible = True
        Label7.Visible = True
        lblBalance.Visible = True
        Label11.Visible = True
        lblchange.Visible = True
        Label1.Text = "Transaction Summary"
        ListView1.Visible = False
        Button1.Visible = True
        Button2.Visible = False
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        CenterForm()
    End Sub

    Private Sub CenterForm()
        Dim centerX As Integer = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2
        Dim centerY As Integer = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) \ 2

        Me.Location = New Point(centerX, centerY)
    End Sub
End Class