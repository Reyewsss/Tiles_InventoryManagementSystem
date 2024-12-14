Public Class ReportsForm
    Public Sub LoadForm(ByVal form As Form)
        If Me.Panel1.Controls.Count > 0 Then
            Me.Panel1.Controls.RemoveAt(0) ' Remove existing control
        End If

        form.TopLevel = False
        form.Dock = DockStyle.Fill
        Me.Panel1.Controls.Add(form)
        Me.Panel1.Tag = form
        form.Show() ' Show the new form
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoadForm(New Inventory_Reports())
        Panel2.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadForm(New Transaction_Reports())
        Panel2.Hide()
    End Sub
End Class