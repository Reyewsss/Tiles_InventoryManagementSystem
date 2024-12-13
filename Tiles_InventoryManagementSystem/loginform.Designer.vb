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
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label1 = New Label()
        lblregister = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        RoundedButton1 = New CustomControls.RJControls.RoundedButton()
        Panel3 = New Panel()
        RoundedPanel4 = New RoundedPanel()
        PictureBox5 = New PictureBox()
        TextBox2 = New TextBox()
        RoundedPanel3 = New RoundedPanel()
        PictureBox4 = New PictureBox()
        TextBox1 = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        RoundedPanel4.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel3.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(8, 7)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(561, 394)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(561, 394)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
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
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(616, 354)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 15)
        Label1.TabIndex = 5
        Label1.Text = "Doesn't have an account?"
        ' 
        ' lblregister
        ' 
        lblregister.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lblregister.AutoSize = True
        lblregister.Cursor = Cursors.Hand
        lblregister.ForeColor = Color.SteelBlue
        lblregister.Location = New Point(755, 354)
        lblregister.Margin = New Padding(2, 0, 2, 0)
        lblregister.Name = "lblregister"
        lblregister.Size = New Size(49, 15)
        lblregister.TabIndex = 6
        lblregister.Text = "Register"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9.0F)
        Label2.Location = New Point(619, 37)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(175, 30)
        Label2.TabIndex = 7
        Label2.Text = "Welcome to the " & vbCrLf & "Inventory Management System!"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9.0F)
        Label3.Location = New Point(614, 67)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(189, 45)
        Label3.TabIndex = 8
        Label3.Text = "Empowering you to " & vbCrLf & "manage and track your " & vbCrLf & "inventory with ease and efficiency."
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.Controls.Add(RoundedButton1)
        Panel2.Location = New Point(512, 202)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(332, 199)
        Panel2.TabIndex = 9
        ' 
        ' RoundedButton1
        ' 
        RoundedButton1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        RoundedButton1.BackColor = Color.Black
        RoundedButton1.BackgroundColor = Color.Black
        RoundedButton1.BorderColor = Color.PaleVioletRed
        RoundedButton1.BorderRadius = 9
        RoundedButton1.BorderSize = 0
        RoundedButton1.Cursor = Cursors.Hand
        RoundedButton1.FlatAppearance.BorderSize = 0
        RoundedButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        RoundedButton1.FlatStyle = FlatStyle.Flat
        RoundedButton1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton1.ForeColor = Color.White
        RoundedButton1.Location = New Point(112, 105)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.Size = New Size(171, 40)
        RoundedButton1.TabIndex = 0
        RoundedButton1.Text = "SIGN IN"
        RoundedButton1.TextColor = Color.White
        RoundedButton1.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.Controls.Add(RoundedPanel4)
        Panel3.Controls.Add(RoundedPanel3)
        Panel3.Location = New Point(512, 7)
        Panel3.Margin = New Padding(2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(332, 283)
        Panel3.TabIndex = 10
        ' 
        ' RoundedPanel4
        ' 
        RoundedPanel4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RoundedPanel4.BorderColor = Color.Black
        RoundedPanel4.BorderThickness = 2
        RoundedPanel4.Controls.Add(PictureBox5)
        RoundedPanel4.Controls.Add(TextBox2)
        RoundedPanel4.Location = New Point(101, 202)
        RoundedPanel4.Name = "RoundedPanel4"
        RoundedPanel4.Size = New Size(189, 40)
        RoundedPanel4.TabIndex = 1
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(9, 8)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(18, 23)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 3
        PictureBox5.TabStop = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Location = New Point(32, 12)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Password"
        TextBox2.Size = New Size(147, 16)
        TextBox2.TabIndex = 1
        ' 
        ' RoundedPanel3
        ' 
        RoundedPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RoundedPanel3.BorderColor = Color.Black
        RoundedPanel3.BorderThickness = 2
        RoundedPanel3.Controls.Add(PictureBox4)
        RoundedPanel3.Controls.Add(TextBox1)
        RoundedPanel3.Location = New Point(100, 150)
        RoundedPanel3.Name = "RoundedPanel3"
        RoundedPanel3.Size = New Size(190, 40)
        RoundedPanel3.TabIndex = 0
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(10, 8)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(18, 23)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 2
        PictureBox4.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(33, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "ID Number"
        TextBox1.Size = New Size(147, 16)
        TextBox1.TabIndex = 0
        ' 
        ' loginform
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(853, 408)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblregister)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2)
        Name = "loginform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory Management System"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        RoundedPanel4.ResumeLayout(False)
        RoundedPanel4.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel3.ResumeLayout(False)
        RoundedPanel3.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RoundedButton1 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedPanel4 As RoundedPanel
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox

End Class
