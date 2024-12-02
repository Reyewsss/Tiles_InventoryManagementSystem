Public Class loginform

    ' This is the event handler for the Form Load event
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Any code to initialize the form goes here
    End Sub

    ' This is the event handler for the btnsignin button click event
    Private Sub btnsignin_Click(sender As Object, e As EventArgs) Handles btn_signin.Click
        ' Open the RegisterForm


    End Sub

    Private Sub lblregister_Click(sender As Object, e As EventArgs) Handles lblregister.Click
        registerform.Show()
    End Sub
End Class
