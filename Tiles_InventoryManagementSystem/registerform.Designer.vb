<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registerform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registerform))
        btn_register = New CustomControls.RJControls.RoundedButton()
        RoundedPanel1 = New RoundedPanel()
        RoundedTextBox1 = New RoundedTextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        RoundedPanel2 = New RoundedPanel()
        RoundedTextBox2 = New RoundedTextBox()
        RoundedPanel3 = New RoundedPanel()
        RoundedTextBox3 = New RoundedTextBox()
        RoundedPanel4 = New RoundedPanel()
        RoundedTextBox4 = New RoundedTextBox()
        RoundedPanel5 = New RoundedPanel()
        RoundedTextBox5 = New RoundedTextBox()
        Label5 = New Label()
        RoundedPanel6 = New RoundedPanel()
        RoundedTextBox6 = New RoundedTextBox()
        Label6 = New Label()
        RoundedPanel7 = New RoundedPanel()
        RoundedTextBox7 = New RoundedTextBox()
        Label7 = New Label()
        Panel1 = New Panel()
        RoundedPanel1.SuspendLayout()
        RoundedPanel2.SuspendLayout()
        RoundedPanel3.SuspendLayout()
        RoundedPanel4.SuspendLayout()
        RoundedPanel5.SuspendLayout()
        RoundedPanel6.SuspendLayout()
        RoundedPanel7.SuspendLayout()
        SuspendLayout()
        ' 
        ' btn_register
        ' 
        btn_register.Anchor = AnchorStyles.Bottom
        btn_register.BackColor = Color.Black
        btn_register.BackgroundColor = Color.Black
        btn_register.BorderColor = Color.Transparent
        btn_register.BorderRadius = 9
        btn_register.BorderSize = 0
        btn_register.Cursor = Cursors.Hand
        btn_register.FlatAppearance.BorderSize = 0
        btn_register.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btn_register.FlatStyle = FlatStyle.Flat
        btn_register.ForeColor = Color.White
        btn_register.Location = New Point(155, 419)
        btn_register.Name = "btn_register"
        btn_register.Size = New Size(320, 58)
        btn_register.TabIndex = 2
        btn_register.Text = "Register"
        btn_register.TextColor = Color.White
        btn_register.UseVisualStyleBackColor = False
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.Anchor = AnchorStyles.Top
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderThickness = 2
        RoundedPanel1.Controls.Add(RoundedTextBox1)
        RoundedPanel1.Location = New Point(103, 62)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(203, 42)
        RoundedPanel1.TabIndex = 3
        ' 
        ' RoundedTextBox1
        ' 
        RoundedTextBox1.BorderColor = Color.Black
        RoundedTextBox1.BorderThickness = 2
        RoundedTextBox1.Location = New Point(9, 5)
        RoundedTextBox1.Name = "RoundedTextBox1"
        RoundedTextBox1.Size = New Size(188, 31)
        RoundedTextBox1.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(103, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 28)
        Label1.TabIndex = 4
        Label1.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(103, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 28)
        Label2.TabIndex = 5
        Label2.Text = "Last Name"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(323, 31)
        Label3.Name = "Label3"
        Label3.Size = New Size(135, 28)
        Label3.TabIndex = 6
        Label3.Text = "Middle Name"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(332, 108)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 28)
        Label4.TabIndex = 7
        Label4.Text = "Suffix"
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.Anchor = AnchorStyles.Top
        RoundedPanel2.BorderColor = Color.Black
        RoundedPanel2.BorderThickness = 2
        RoundedPanel2.Controls.Add(RoundedTextBox2)
        RoundedPanel2.Location = New Point(323, 62)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(203, 42)
        RoundedPanel2.TabIndex = 5
        ' 
        ' RoundedTextBox2
        ' 
        RoundedTextBox2.BorderColor = Color.Black
        RoundedTextBox2.BorderThickness = 2
        RoundedTextBox2.Location = New Point(9, 5)
        RoundedTextBox2.Name = "RoundedTextBox2"
        RoundedTextBox2.Size = New Size(188, 31)
        RoundedTextBox2.TabIndex = 4
        ' 
        ' RoundedPanel3
        ' 
        RoundedPanel3.Anchor = AnchorStyles.Top
        RoundedPanel3.BorderColor = Color.Black
        RoundedPanel3.BorderThickness = 2
        RoundedPanel3.Controls.Add(RoundedTextBox3)
        RoundedPanel3.Location = New Point(103, 139)
        RoundedPanel3.Name = "RoundedPanel3"
        RoundedPanel3.Size = New Size(203, 42)
        RoundedPanel3.TabIndex = 6
        ' 
        ' RoundedTextBox3
        ' 
        RoundedTextBox3.BorderColor = Color.Black
        RoundedTextBox3.BorderThickness = 2
        RoundedTextBox3.Location = New Point(9, 5)
        RoundedTextBox3.Name = "RoundedTextBox3"
        RoundedTextBox3.Size = New Size(188, 31)
        RoundedTextBox3.TabIndex = 4
        ' 
        ' RoundedPanel4
        ' 
        RoundedPanel4.Anchor = AnchorStyles.Top
        RoundedPanel4.BorderColor = Color.Black
        RoundedPanel4.BorderThickness = 2
        RoundedPanel4.Controls.Add(RoundedTextBox4)
        RoundedPanel4.Location = New Point(323, 139)
        RoundedPanel4.Name = "RoundedPanel4"
        RoundedPanel4.Size = New Size(135, 42)
        RoundedPanel4.TabIndex = 7
        ' 
        ' RoundedTextBox4
        ' 
        RoundedTextBox4.BorderColor = Color.Black
        RoundedTextBox4.BorderThickness = 2
        RoundedTextBox4.Location = New Point(9, 5)
        RoundedTextBox4.Name = "RoundedTextBox4"
        RoundedTextBox4.Size = New Size(111, 31)
        RoundedTextBox4.TabIndex = 4
        ' 
        ' RoundedPanel5
        ' 
        RoundedPanel5.Anchor = AnchorStyles.Top
        RoundedPanel5.BorderColor = Color.Black
        RoundedPanel5.BorderThickness = 2
        RoundedPanel5.Controls.Add(RoundedTextBox5)
        RoundedPanel5.Location = New Point(103, 212)
        RoundedPanel5.Name = "RoundedPanel5"
        RoundedPanel5.Size = New Size(423, 42)
        RoundedPanel5.TabIndex = 8
        ' 
        ' RoundedTextBox5
        ' 
        RoundedTextBox5.BorderColor = Color.Black
        RoundedTextBox5.BorderThickness = 2
        RoundedTextBox5.Location = New Point(9, 5)
        RoundedTextBox5.Name = "RoundedTextBox5"
        RoundedTextBox5.Size = New Size(408, 31)
        RoundedTextBox5.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(103, 181)
        Label5.Name = "Label5"
        Label5.Size = New Size(113, 28)
        Label5.TabIndex = 7
        Label5.Text = "ID Number"
        ' 
        ' RoundedPanel6
        ' 
        RoundedPanel6.Anchor = AnchorStyles.Top
        RoundedPanel6.BorderColor = Color.Black
        RoundedPanel6.BorderThickness = 2
        RoundedPanel6.Controls.Add(RoundedTextBox6)
        RoundedPanel6.Location = New Point(103, 285)
        RoundedPanel6.Name = "RoundedPanel6"
        RoundedPanel6.Size = New Size(423, 42)
        RoundedPanel6.TabIndex = 10
        ' 
        ' RoundedTextBox6
        ' 
        RoundedTextBox6.BorderColor = Color.Black
        RoundedTextBox6.BorderThickness = 2
        RoundedTextBox6.Location = New Point(9, 5)
        RoundedTextBox6.Name = "RoundedTextBox6"
        RoundedTextBox6.Size = New Size(408, 31)
        RoundedTextBox6.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(103, 254)
        Label6.Name = "Label6"
        Label6.Size = New Size(97, 28)
        Label6.TabIndex = 9
        Label6.Text = "Password"
        ' 
        ' RoundedPanel7
        ' 
        RoundedPanel7.Anchor = AnchorStyles.Top
        RoundedPanel7.BorderColor = Color.Black
        RoundedPanel7.BorderThickness = 2
        RoundedPanel7.Controls.Add(RoundedTextBox7)
        RoundedPanel7.Location = New Point(103, 357)
        RoundedPanel7.Name = "RoundedPanel7"
        RoundedPanel7.Size = New Size(423, 42)
        RoundedPanel7.TabIndex = 12
        ' 
        ' RoundedTextBox7
        ' 
        RoundedTextBox7.BorderColor = Color.Black
        RoundedTextBox7.BorderThickness = 2
        RoundedTextBox7.Location = New Point(9, 5)
        RoundedTextBox7.Name = "RoundedTextBox7"
        RoundedTextBox7.Size = New Size(408, 31)
        RoundedTextBox7.TabIndex = 4
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(103, 326)
        Label7.Name = "Label7"
        Label7.Size = New Size(176, 28)
        Label7.TabIndex = 11
        Label7.Text = "Confirm Password"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top
        Panel1.Location = New Point(59, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(507, 479)
        Panel1.TabIndex = 13
        ' 
        ' registerform
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(624, 503)
        Controls.Add(RoundedPanel7)
        Controls.Add(Label7)
        Controls.Add(RoundedPanel6)
        Controls.Add(Label6)
        Controls.Add(RoundedPanel5)
        Controls.Add(Label5)
        Controls.Add(RoundedPanel4)
        Controls.Add(RoundedPanel3)
        Controls.Add(RoundedPanel2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(RoundedPanel1)
        Controls.Add(btn_register)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "registerform"
        StartPosition = FormStartPosition.CenterScreen
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel2.PerformLayout()
        RoundedPanel3.ResumeLayout(False)
        RoundedPanel3.PerformLayout()
        RoundedPanel4.ResumeLayout(False)
        RoundedPanel4.PerformLayout()
        RoundedPanel5.ResumeLayout(False)
        RoundedPanel5.PerformLayout()
        RoundedPanel6.ResumeLayout(False)
        RoundedPanel6.PerformLayout()
        RoundedPanel7.ResumeLayout(False)
        RoundedPanel7.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_register As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents RoundedTextBox1 As RoundedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents RoundedTextBox2 As RoundedTextBox
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents RoundedTextBox3 As RoundedTextBox
    Friend WithEvents RoundedPanel4 As RoundedPanel
    Friend WithEvents RoundedTextBox4 As RoundedTextBox
    Friend WithEvents RoundedPanel5 As RoundedPanel
    Friend WithEvents RoundedTextBox5 As RoundedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RoundedPanel6 As RoundedPanel
    Friend WithEvents RoundedTextBox6 As RoundedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RoundedPanel7 As RoundedPanel
    Friend WithEvents RoundedTextBox7 As RoundedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
End Class
