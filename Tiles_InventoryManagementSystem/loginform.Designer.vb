<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginform))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        btn_signin = New CustomControls.RJControls.RoundedButton()
        RoundedPanel1 = New RoundedPanel()
        PictureBox2 = New PictureBox()
        txtusername = New RoundedTextBox()
        RoundedPanel2 = New RoundedPanel()
        PictureBox3 = New PictureBox()
        txtpassword = New RoundedTextBox()
        Label1 = New Label()
        lblregister = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(699, 495)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(699, 495)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' btn_signin
        ' 
        btn_signin.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btn_signin.BackColor = Color.Black
        btn_signin.BackgroundColor = Color.Black
        btn_signin.BorderColor = Color.Transparent
        btn_signin.BorderRadius = 9
        btn_signin.BorderSize = 0
        btn_signin.Cursor = Cursors.Hand
        btn_signin.FlatAppearance.BorderSize = 0
        btn_signin.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btn_signin.FlatStyle = FlatStyle.Flat
        btn_signin.ForeColor = Color.White
        btn_signin.Location = New Point(755, 361)
        btn_signin.Name = "btn_signin"
        btn_signin.Size = New Size(320, 58)
        btn_signin.TabIndex = 1
        btn_signin.Text = "Sign In"
        btn_signin.TextColor = Color.White
        btn_signin.UseVisualStyleBackColor = False
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RoundedPanel1.BackColor = SystemColors.ButtonHighlight
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderThickness = 2
        RoundedPanel1.Controls.Add(PictureBox2)
        RoundedPanel1.Controls.Add(txtusername)
        RoundedPanel1.Location = New Point(755, 206)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(320, 40)
        RoundedPanel1.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(14, 11)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(23, 19)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' txtusername
        ' 
        txtusername.BackColor = SystemColors.ButtonHighlight
        txtusername.BorderColor = Color.Black
        txtusername.BorderThickness = 2
        txtusername.Location = New Point(41, 4)
        txtusername.Name = "txtusername"
        txtusername.PlaceholderText = "ID Number"
        txtusername.Size = New Size(265, 31)
        txtusername.TabIndex = 3
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RoundedPanel2.BackColor = SystemColors.ButtonHighlight
        RoundedPanel2.BorderColor = Color.Black
        RoundedPanel2.BorderThickness = 2
        RoundedPanel2.Controls.Add(PictureBox3)
        RoundedPanel2.Controls.Add(txtpassword)
        RoundedPanel2.Location = New Point(755, 271)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(320, 40)
        RoundedPanel2.TabIndex = 4
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(14, 11)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(23, 19)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' txtpassword
        ' 
        txtpassword.BackColor = SystemColors.ButtonHighlight
        txtpassword.BorderColor = Color.Black
        txtpassword.BorderThickness = 2
        txtpassword.Location = New Point(41, 4)
        txtpassword.Name = "txtpassword"
        txtpassword.PlaceholderText = "Password"
        txtpassword.Size = New Size(265, 31)
        txtpassword.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(775, 429)
        Label1.Name = "Label1"
        Label1.Size = New Size(214, 25)
        Label1.TabIndex = 5
        Label1.Text = "Doesn't have an account?"
        ' 
        ' lblregister
        ' 
        lblregister.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lblregister.AutoSize = True
        lblregister.Cursor = Cursors.Hand
        lblregister.ForeColor = Color.SteelBlue
        lblregister.Location = New Point(983, 429)
        lblregister.Name = "lblregister"
        lblregister.Size = New Size(75, 25)
        lblregister.TabIndex = 6
        lblregister.Text = "Register"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F)
        Label2.Location = New Point(782, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(264, 50)
        Label2.TabIndex = 7
        Label2.Text = "Welcome to the " & vbCrLf & "Inventory Management System!"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F)
        Label3.Location = New Point(774, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(281, 75)
        Label3.TabIndex = 8
        Label3.Text = "Empowering you to " & vbCrLf & "manage and track your " & vbCrLf & "inventory with ease and efficiency."
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.Location = New Point(732, 337)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(372, 170)
        Panel2.TabIndex = 9
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.Location = New Point(732, 12)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(372, 310)
        Panel3.TabIndex = 10
        ' 
        ' loginform
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1116, 519)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblregister)
        Controls.Add(Label1)
        Controls.Add(RoundedPanel2)
        Controls.Add(RoundedPanel1)
        Controls.Add(btn_signin)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "loginform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory Management System"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_signin As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents txtusername As RoundedTextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtpassword As RoundedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblregister As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel

End Class
