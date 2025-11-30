Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.txtBalance.Text = My.Settings.UserBal
        If Main.txtBalance.Text > 0 Then
            Adminform.lblstatus.Text = "Incomplete"
        Else
            Adminform.lblstatus.Text = "Paid"
        End If
        If txtUsername.Text = "" Then
            MsgBox("Username cannot be empty!", vbInformation,)
        ElseIf txtPassword.Text = "" Then
            MsgBox("Password cannot be empty!", vbInformation)
        ElseIf txtUsername.Text = My.Settings.Username AndAlso txtPassword.Text = My.Settings.Password Then
            MsgBox("Login Successful")
            Main.lblUsername.Text = txtUsername.Text
            txtUsername.Text = ""
            txtPassword.Text = ""
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
        ElseIf txtUsername.Text = "Admin" AndAlso txtPassword.Text = "Admin123" Then
            MsgBox("Logged in as Admin", vbInformation)
            txtUsername.Text = ""
            txtPassword.Text = ""
            Me.Hide()
            Adminform.Show()
        Else
            MsgBox("Invalid Credentials!", vbExclamation)
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Registerform.Show()
        txtUsername.Text = ""
        txtPassword.Text = ""
        Me.Hide()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class
