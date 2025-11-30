Public Class Adminform
    Private Sub Adminform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Username = "" Then
            Return
        Else
            lbluser.Text = My.Settings.Username
        End If
        If My.Settings.FullName = "" Then
            Return
        Else
            lblname.Text = My.Settings.FullName
        End If

        If My.Settings.Car = "" Then
            Return
        Else
            lblcar.Text = My.Settings.Car
        End If
        If My.Settings.Contact = "" Then
            Return
        Else
            lblcontact.Text = My.Settings.Contact
        End If
        If My.Settings.Address = "" Then
            Return
        Else
            lbladdress.Text = My.Settings.Address
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Main.txtBalance.Text > 0 Then
            MsgBox("Successfully possessed a car from a customer!")
            My.Settings.UserBal = 0
            Main.txtBalance.Text = 0
            lblstatus.Text = "Unavailable"
            My.Settings.Car = ""
            My.Settings.balthismonth = 0
            My.Settings.Save()
            If My.Settings.Car = "" Then
                lblcar.Text = "N/A"
            Else
                lblcar.Text = My.Settings.Car
            End If
        ElseIf lblstatus.Text = "Unavailable" Then
            Return
        Else
            MsgBox("You can't repossess a paid customer!", vbInformation)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        FormUsedCars.Show()
        FormUsedCars.paneladdcar.Visible = True
        FormUsedCars.btnBack.Visible = True
        FormUsedCars.back2.Visible = False
    End Sub
End Class