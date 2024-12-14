Imports FontAwesome.Sharp

Public Class MenuForm

    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    Dim sidebar As String = "Close"

    ' Constructor
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 50)
        Panel1.Controls.Add(leftBorderBtn)
    End Sub

    ' Methods to manage button styling and behavior
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()

            ' If the sender is an IconButton, handle it accordingly
            If TypeOf senderBtn Is IconButton Then
                currentBtn = CType(senderBtn, IconButton)
                currentBtn.BackColor = Color.FromArgb(64, 64, 64)
                currentBtn.ForeColor = customColor
                currentBtn.IconColor = customColor
                currentBtn.TextAlign = ContentAlignment.MiddleCenter
                currentBtn.ImageAlign = ContentAlignment.MiddleRight
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

                ' Left border styling
                leftBorderBtn.BackColor = customColor
                leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
                leftBorderBtn.Visible = True
                leftBorderBtn.BringToFront()

                ' Update current form's icon
                IconPictureBox1.IconChar = currentBtn.IconChar
                IconPictureBox1.IconColor = customColor

                ' Update Label1 text based on the button clicked
                If currentBtn.Name = "IconButton1" Then
                    Label1.Text = "INVENTORY" ' Set text when IconButton1 is clicked
                ElseIf currentBtn.Name = "IconButton2" Then
                    Label1.Text = "ORDER" ' Set text when IconButton2 is clicked
                ElseIf currentBtn.Name = "IconButton3" Then
                    Label1.Text = "REPORTS" ' Set text when IconButton3 is clicked
                End If
            ElseIf senderBtn Is PictureBox2 Then
                ' Handle PictureBox2 click
                Label1.Text = "HOME"
                IconPictureBox1.IconChar = IconChar.Home ' Set text when PictureBox2 is clicked
            End If
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.Black
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        IconPictureBox1.IconChar = IconChar.Home
        IconPictureBox1.IconColor = Color.DarkGray
        Panel3.Text = "Home"
    End Sub

    ' Timer to handle sidebar toggle animation and hide/show button
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If sidebar = "Open" Then
            Panel1.Width += 25
            If Panel1.Width >= 219 Then
                sidebar = "Close"
                IconButton1.Visible = True
                IconButton2.Visible = True
                IconButton3.Visible = True
                Button1.Visible = True ' Show the button when sidebar is open
                Timer1.Stop()
            End If
        Else
            Panel1.Width -= 25
            If Panel1.Width <= 50 Then
                sidebar = "Open"
                IconButton1.Visible = False
                IconButton2.Visible = False
                IconButton3.Visible = False
                Button1.Visible = False ' Hide the button when sidebar is minimized
                Timer1.Stop()
            End If
        End If
    End Sub

    ' Toggle the sidebar when clicking the PictureBox
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Timer1.Start()
    End Sub

    ' Button click to activate the button style and set the label text
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        ActivateButton(sender, Color.White)
        LoadForm(New InventoryForm())
        Panel6.Hide()
    End Sub

    ' Button2 click to activate and set label text
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        ActivateButton(sender, Color.White)
        LoadForm(New OrderForm())
        Panel6.Hide()
    End Sub

    ' Button3 click to activate and set label text
    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        ActivateButton(sender, Color.White)
        LoadForm(New ReportsForm())
        Panel6.Hide()
    End Sub

    ' Button click to show login form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loginform.Show()
        Me.Hide()
    End Sub

    ' PictureBox2 click event
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ActivateButton(sender, Color.White)
        LoadForm(New HomeForm)
        Reset()
        Panel6.Hide()
    End Sub

    Public Sub LoadForm(ByVal form As Form)
        If Me.Panel4.Controls.Count > 0 Then
            Me.Panel4.Controls.RemoveAt(0) ' Remove existing control
        End If

        form.TopLevel = False
        form.Dock = DockStyle.Fill
        Me.Panel4.Controls.Add(form)
        Me.Panel4.Tag = form
        form.Show() ' Show the new form
    End Sub

    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
