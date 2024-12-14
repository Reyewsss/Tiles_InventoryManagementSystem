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
        RoundedPanel2 = New RoundedPanel()
        TextBox1 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        RoundedPanel3 = New RoundedPanel()
        TextBox5 = New TextBox()
        Label1 = New Label()
        RoundedPanel1 = New RoundedPanel()
        RoundedPanel4 = New RoundedPanel()
        TextBox4 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        RoundedPanel5 = New RoundedPanel()
        TextBox6 = New TextBox()
        Label6 = New Label()
        RoundedPanel6 = New RoundedPanel()
        TextBox7 = New TextBox()
        Label7 = New Label()
        RoundedPanel7 = New RoundedPanel()
        RoundedPanel2.SuspendLayout()
        RoundedPanel3.SuspendLayout()
        RoundedPanel1.SuspendLayout()
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
        btn_register.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_register.ForeColor = Color.White
        btn_register.Location = New Point(131, 341)
        btn_register.Margin = New Padding(2)
        btn_register.Name = "btn_register"
        btn_register.Size = New Size(171, 40)
        btn_register.TabIndex = 2
        btn_register.Text = "REGISTER"
        btn_register.TextColor = Color.White
        btn_register.UseVisualStyleBackColor = False
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.Anchor = AnchorStyles.Top
        RoundedPanel2.BorderColor = Color.Black
        RoundedPanel2.BorderThickness = 2
        RoundedPanel2.Controls.Add(TextBox1)
        RoundedPanel2.Location = New Point(58, 37)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(155, 29)
        RoundedPanel2.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(5, 6)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(144, 16)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Location = New Point(5, 6)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(144, 16)
        TextBox3.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Location = New Point(5, 6)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(144, 16)
        TextBox2.TabIndex = 0
        ' 
        ' RoundedPanel3
        ' 
        RoundedPanel3.Anchor = AnchorStyles.Top
        RoundedPanel3.BorderColor = Color.Black
        RoundedPanel3.BorderThickness = 2
        RoundedPanel3.Controls.Add(TextBox2)
        RoundedPanel3.Location = New Point(219, 37)
        RoundedPanel3.Name = "RoundedPanel3"
        RoundedPanel3.Size = New Size(155, 29)
        RoundedPanel3.TabIndex = 5
        ' 
        ' TextBox5
        ' 
        TextBox5.BorderStyle = BorderStyle.None
        TextBox5.Location = New Point(6, 6)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(302, 16)
        TextBox5.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(64, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 6
        Label1.Text = "First Name"
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.Anchor = AnchorStyles.Top
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderThickness = 2
        RoundedPanel1.Controls.Add(TextBox3)
        RoundedPanel1.Location = New Point(58, 101)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(155, 29)
        RoundedPanel1.TabIndex = 6
        ' 
        ' RoundedPanel4
        ' 
        RoundedPanel4.Anchor = AnchorStyles.Top
        RoundedPanel4.BorderColor = Color.Black
        RoundedPanel4.BorderThickness = 2
        RoundedPanel4.Controls.Add(TextBox4)
        RoundedPanel4.Location = New Point(219, 101)
        RoundedPanel4.Name = "RoundedPanel4"
        RoundedPanel4.Size = New Size(79, 29)
        RoundedPanel4.TabIndex = 7
        ' 
        ' TextBox4
        ' 
        TextBox4.BorderStyle = BorderStyle.None
        TextBox4.Location = New Point(5, 6)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(68, 16)
        TextBox4.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(227, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 15)
        Label2.TabIndex = 8
        Label2.Text = "Middle Name"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(64, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 15)
        Label3.TabIndex = 9
        Label3.Text = "Last Name"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(227, 83)
        Label4.Name = "Label4"
        Label4.Size = New Size(38, 15)
        Label4.TabIndex = 10
        Label4.Text = "Suffix"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(66, 150)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 15)
        Label5.TabIndex = 12
        Label5.Text = "ID Number"
        ' 
        ' RoundedPanel5
        ' 
        RoundedPanel5.Anchor = AnchorStyles.Top
        RoundedPanel5.BorderColor = Color.Black
        RoundedPanel5.BorderThickness = 2
        RoundedPanel5.Controls.Add(TextBox5)
        RoundedPanel5.Location = New Point(60, 168)
        RoundedPanel5.Name = "RoundedPanel5"
        RoundedPanel5.Size = New Size(314, 29)
        RoundedPanel5.TabIndex = 11
        ' 
        ' TextBox6
        ' 
        TextBox6.BorderStyle = BorderStyle.None
        TextBox6.Location = New Point(6, 6)
        TextBox6.Name = "TextBox6"
        TextBox6.PasswordChar = "*"c
        TextBox6.Size = New Size(302, 16)
        TextBox6.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(68, 212)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 15)
        Label6.TabIndex = 14
        Label6.Text = "Password"
        ' 
        ' RoundedPanel6
        ' 
        RoundedPanel6.Anchor = AnchorStyles.Top
        RoundedPanel6.BorderColor = Color.Black
        RoundedPanel6.BorderThickness = 2
        RoundedPanel6.Controls.Add(TextBox6)
        RoundedPanel6.Location = New Point(62, 230)
        RoundedPanel6.Name = "RoundedPanel6"
        RoundedPanel6.Size = New Size(314, 29)
        RoundedPanel6.TabIndex = 13
        ' 
        ' TextBox7
        ' 
        TextBox7.BorderStyle = BorderStyle.None
        TextBox7.Location = New Point(6, 6)
        TextBox7.Name = "TextBox7"
        TextBox7.PasswordChar = "*"c
        TextBox7.Size = New Size(302, 16)
        TextBox7.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(68, 277)
        Label7.Name = "Label7"
        Label7.Size = New Size(103, 15)
        Label7.TabIndex = 16
        Label7.Text = "Confirm Password"
        ' 
        ' RoundedPanel7
        ' 
        RoundedPanel7.Anchor = AnchorStyles.Top
        RoundedPanel7.BorderColor = Color.Black
        RoundedPanel7.BorderThickness = 2
        RoundedPanel7.Controls.Add(TextBox7)
        RoundedPanel7.Location = New Point(62, 295)
        RoundedPanel7.Name = "RoundedPanel7"
        RoundedPanel7.Size = New Size(314, 29)
        RoundedPanel7.TabIndex = 15
        ' 
        ' registerform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(437, 403)
        Controls.Add(Label7)
        Controls.Add(RoundedPanel7)
        Controls.Add(Label6)
        Controls.Add(RoundedPanel6)
        Controls.Add(Label5)
        Controls.Add(RoundedPanel5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(RoundedPanel4)
        Controls.Add(RoundedPanel1)
        Controls.Add(Label1)
        Controls.Add(RoundedPanel3)
        Controls.Add(RoundedPanel2)
        Controls.Add(btn_register)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2)
        Name = "registerform"
        StartPosition = FormStartPosition.CenterScreen
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel2.PerformLayout()
        RoundedPanel3.ResumeLayout(False)
        RoundedPanel3.PerformLayout()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
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
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents RoundedPanel4 As RoundedPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RoundedPanel5 As RoundedPanel
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RoundedPanel6 As RoundedPanel
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents RoundedPanel7 As RoundedPanel
End Class
