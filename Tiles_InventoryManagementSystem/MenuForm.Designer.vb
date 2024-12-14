<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuForm))
        Panel1 = New Panel()
        IconButton3 = New FontAwesome.Sharp.IconButton()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        Button1 = New Button()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        Panel5 = New Panel()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        Label1 = New Label()
        IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Panel4 = New Panel()
        Panel6 = New Panel()
        PictureBox3 = New PictureBox()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        Panel6.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(IconButton3)
        Panel1.Controls.Add(IconButton2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(IconButton1)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(219, 669)
        Panel1.TabIndex = 0
        ' 
        ' IconButton3
        ' 
        IconButton3.Cursor = Cursors.Hand
        IconButton3.FlatAppearance.BorderSize = 0
        IconButton3.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        IconButton3.FlatStyle = FlatStyle.Flat
        IconButton3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IconButton3.ForeColor = Color.White
        IconButton3.IconChar = FontAwesome.Sharp.IconChar.Clipboard
        IconButton3.IconColor = Color.White
        IconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton3.IconSize = 40
        IconButton3.ImageAlign = ContentAlignment.MiddleLeft
        IconButton3.Location = New Point(3, 281)
        IconButton3.Name = "IconButton3"
        IconButton3.Padding = New Padding(10, 0, 20, 0)
        IconButton3.Size = New Size(213, 50)
        IconButton3.TabIndex = 7
        IconButton3.Text = "REPORTS"
        IconButton3.TextAlign = ContentAlignment.MiddleLeft
        IconButton3.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton3.UseVisualStyleBackColor = True
        ' 
        ' IconButton2
        ' 
        IconButton2.Cursor = Cursors.Hand
        IconButton2.FlatAppearance.BorderSize = 0
        IconButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        IconButton2.FlatStyle = FlatStyle.Flat
        IconButton2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IconButton2.ForeColor = Color.White
        IconButton2.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag
        IconButton2.IconColor = Color.White
        IconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton2.IconSize = 40
        IconButton2.ImageAlign = ContentAlignment.MiddleLeft
        IconButton2.Location = New Point(3, 213)
        IconButton2.Name = "IconButton2"
        IconButton2.Padding = New Padding(10, 0, 20, 0)
        IconButton2.Size = New Size(213, 50)
        IconButton2.TabIndex = 6
        IconButton2.Text = "ORDER"
        IconButton2.TextAlign = ContentAlignment.MiddleLeft
        IconButton2.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(28, 611)
        Button1.Name = "Button1"
        Button1.Size = New Size(164, 42)
        Button1.TabIndex = 5
        Button1.Text = "SIGN OUT"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' IconButton1
        ' 
        IconButton1.Cursor = Cursors.Hand
        IconButton1.FlatAppearance.BorderSize = 0
        IconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IconButton1.ForeColor = Color.White
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed
        IconButton1.IconColor = Color.White
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.IconSize = 40
        IconButton1.ImageAlign = ContentAlignment.MiddleLeft
        IconButton1.Location = New Point(3, 145)
        IconButton1.Name = "IconButton1"
        IconButton1.Padding = New Padding(10, 0, 20, 0)
        IconButton1.Size = New Size(213, 50)
        IconButton1.TabIndex = 2
        IconButton1.Text = "INVENTORY"
        IconButton1.TextAlign = ContentAlignment.MiddleLeft
        IconButton1.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(PictureBox2)
        Panel5.Location = New Point(0, 39)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(219, 100)
        Panel5.TabIndex = 1
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(27, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(164, 97)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(219, 34)
        Panel2.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Dock = DockStyle.Right
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(181, 0)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(38, 34)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Black
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(IconPictureBox1)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(219, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(909, 71)
        Panel3.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(58, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 17)
        Label1.TabIndex = 1
        Label1.Text = "HOME"
        ' 
        ' IconPictureBox1
        ' 
        IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.House
        IconPictureBox1.IconColor = Color.White
        IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox1.Location = New Point(20, 19)
        IconPictureBox1.Name = "IconPictureBox1"
        IconPictureBox1.Size = New Size(32, 32)
        IconPictureBox1.TabIndex = 0
        IconPictureBox1.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(Panel6)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(219, 71)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(909, 598)
        Panel4.TabIndex = 2
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.Controls.Add(PictureBox3)
        Panel6.Location = New Point(213, 161)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(482, 276)
        Panel6.TabIndex = 0
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(38, 0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(406, 211)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 10
        ' 
        ' MenuForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1128, 669)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2)
        Name = "MenuForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory Management System"
        Panel1.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Button1 As Button
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox3 As PictureBox
End Class
