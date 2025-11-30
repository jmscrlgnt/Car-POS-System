
Public Class Registerform

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Txtusername.Text = ""
        txtpassword.Text = ""
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        If Txtusername.Text = "" Then
            MsgBox("Username cannot be empty!", vbInformation,)
        ElseIf Txtusername.Text.Length < 8 Then
            MsgBox("Username must have atleast 8 characters long")
        ElseIf txtpassword.Text = "" Then
            MsgBox("Password cannot be empty!", vbInformation)
        ElseIf txtconfirmpassword.Text = "" Then
            MsgBox("Please confirm your password", vbInformation)
        ElseIf ValidatePassword(txtpassword.Text) = False Then
            MsgBox("Passwords must have 8-10 characters long with atleast one numeric number and upper and lowercase letters", vbInformation)
        ElseIf txtpassword.Text Like txtconfirmpassword.Text Then
            MsgBox("Account Registration Successful")
            My.Settings.Username = Txtusername.Text
            My.Settings.Password = txtpassword.Text
            My.Settings.UserBal = 0
            Main.txtBalance.Text = 0
            My.Settings.FullName = ""
            My.Settings.Car = ""
            My.Settings.Address = ""
            My.Settings.Contact = ""
            My.Settings.balthismonth = 0
            My.Settings.Save()
            Txtusername.Text = ""
            txtpassword.Text = ""
            txtconfirmpassword.Text = ""
            Me.Hide()
            Login.Show()

        Else
            MsgBox("Password and Confirm Password Mismatch", vbInformation)
        End If
    End Sub
    Private Function ValidatePassword(ByVal Password) As Boolean

        If Password.Length < 8 Then
            Return False
        End If

        Dim regEx
        regEx = CreateObject("vbscript.regexp")

        regEx.pattern = "(?=.*\d)(?=.*[a-z]).{8,}"
        ValidatePassword = regEx.Test(Password)

        regEx = Nothing
    End Function

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Txtusername.Text = ""
        txtpassword.Text = ""
        txtconfirmpassword.Text = ""
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Registerform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class