Public Class FormMenu
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Main.btnMenu.BackColor = Color.FromArgb(40, 40, 40)
        Main.btnNewCars.BackColor = Color.FromArgb(30, 30, 30)
        Main.btnUsedCars.BackColor = Color.FromArgb(40, 40, 40)
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

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Main.txtBalance.Text > 0 Then
            PictureBox1.Enabled = False
        Else
            PictureBox1.Enabled = True
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Main.Hide()
        Formpay.Show()
    End Sub
End Class