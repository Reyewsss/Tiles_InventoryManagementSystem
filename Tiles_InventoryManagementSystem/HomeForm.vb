Public Class HomeForm
    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")
    End Sub
End Class