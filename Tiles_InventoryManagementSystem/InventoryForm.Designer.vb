<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryForm
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
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        RoundedPanel1 = New RoundedPanel()
        TextBox1 = New TextBox()
        RoundedPanel2 = New RoundedPanel()
        TextBox2 = New TextBox()
        ComboBox1 = New ComboBox()
        RoundedPanel4 = New RoundedPanel()
        TextBox3 = New TextBox()
        RoundedPanel5 = New RoundedPanel()
        TextBox4 = New TextBox()
        RoundedButton1 = New CustomControls.RJControls.RoundedButton()
        RoundedButton2 = New CustomControls.RJControls.RoundedButton()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        RoundedButton3 = New CustomControls.RJControls.RoundedButton()
        RoundedButton4 = New CustomControls.RJControls.RoundedButton()
        ComboBox2 = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        RoundedPanel2.SuspendLayout()
        RoundedPanel4.SuspendLayout()
        RoundedPanel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        DataGridView1.Location = New Point(12, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.Size = New Size(521, 574)
        DataGridView1.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "Item Code"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 87
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Item Name"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Type"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 56
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Size"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 52
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "Quantity"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 78
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "Current Price"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 101
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.Anchor = AnchorStyles.Right
        RoundedPanel1.BackColor = Color.Transparent
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderThickness = 2
        RoundedPanel1.Controls.Add(TextBox1)
        RoundedPanel1.Location = New Point(565, 66)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(124, 34)
        RoundedPanel1.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(8, 9)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(113, 16)
        TextBox1.TabIndex = 17
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.Anchor = AnchorStyles.Right
        RoundedPanel2.BackColor = Color.Transparent
        RoundedPanel2.BorderColor = Color.Black
        RoundedPanel2.BorderThickness = 2
        RoundedPanel2.Controls.Add(TextBox2)
        RoundedPanel2.Location = New Point(565, 138)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(241, 34)
        RoundedPanel2.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Location = New Point(8, 9)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(230, 16)
        TextBox2.TabIndex = 18
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Right
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"WALL TILE", "DECORE TILE", "VITRIFIED TILE"})
        ComboBox1.Location = New Point(565, 210)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(181, 23)
        ComboBox1.TabIndex = 4
        ' 
        ' RoundedPanel4
        ' 
        RoundedPanel4.Anchor = AnchorStyles.Right
        RoundedPanel4.BackColor = Color.Transparent
        RoundedPanel4.BorderColor = Color.Black
        RoundedPanel4.BorderThickness = 2
        RoundedPanel4.Controls.Add(TextBox3)
        RoundedPanel4.Location = New Point(565, 332)
        RoundedPanel4.Name = "RoundedPanel4"
        RoundedPanel4.Size = New Size(182, 34)
        RoundedPanel4.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Location = New Point(8, 9)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(171, 16)
        TextBox3.TabIndex = 19
        ' 
        ' RoundedPanel5
        ' 
        RoundedPanel5.Anchor = AnchorStyles.Right
        RoundedPanel5.BackColor = Color.Transparent
        RoundedPanel5.BorderColor = Color.Black
        RoundedPanel5.BorderThickness = 2
        RoundedPanel5.Controls.Add(TextBox4)
        RoundedPanel5.Location = New Point(565, 404)
        RoundedPanel5.Name = "RoundedPanel5"
        RoundedPanel5.Size = New Size(182, 34)
        RoundedPanel5.TabIndex = 5
        ' 
        ' TextBox4
        ' 
        TextBox4.BorderStyle = BorderStyle.None
        TextBox4.Location = New Point(8, 9)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(171, 16)
        TextBox4.TabIndex = 20
        ' 
        ' RoundedButton1
        ' 
        RoundedButton1.Anchor = AnchorStyles.Right
        RoundedButton1.BackColor = Color.Green
        RoundedButton1.BackgroundColor = Color.Green
        RoundedButton1.BorderColor = Color.PaleVioletRed
        RoundedButton1.BorderRadius = 9
        RoundedButton1.BorderSize = 0
        RoundedButton1.Cursor = Cursors.Hand
        RoundedButton1.FlatAppearance.BorderSize = 0
        RoundedButton1.FlatAppearance.MouseOverBackColor = Color.LimeGreen
        RoundedButton1.FlatStyle = FlatStyle.Flat
        RoundedButton1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton1.ForeColor = Color.White
        RoundedButton1.Location = New Point(561, 462)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.Size = New Size(150, 40)
        RoundedButton1.TabIndex = 6
        RoundedButton1.Text = "SAVE"
        RoundedButton1.TextColor = Color.White
        RoundedButton1.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton2
        ' 
        RoundedButton2.Anchor = AnchorStyles.Right
        RoundedButton2.BackColor = Color.Orange
        RoundedButton2.BackgroundColor = Color.Orange
        RoundedButton2.BorderColor = Color.PaleVioletRed
        RoundedButton2.BorderRadius = 9
        RoundedButton2.BorderSize = 0
        RoundedButton2.Cursor = Cursors.Hand
        RoundedButton2.FlatAppearance.BorderSize = 0
        RoundedButton2.FlatAppearance.MouseOverBackColor = Color.SandyBrown
        RoundedButton2.FlatStyle = FlatStyle.Flat
        RoundedButton2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton2.ForeColor = Color.White
        RoundedButton2.Location = New Point(730, 462)
        RoundedButton2.Name = "RoundedButton2"
        RoundedButton2.Size = New Size(150, 40)
        RoundedButton2.TabIndex = 7
        RoundedButton2.Text = "UPDATE"
        RoundedButton2.TextColor = Color.White
        RoundedButton2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(564, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 20)
        Label1.TabIndex = 8
        Label1.Text = "Item Code"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(564, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 20)
        Label2.TabIndex = 9
        Label2.Text = "Item Name"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(564, 181)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 20)
        Label3.TabIndex = 10
        Label3.Text = "Tile Type"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(564, 242)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 20)
        Label4.TabIndex = 11
        Label4.Text = "Size"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(564, 303)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 20)
        Label5.TabIndex = 12
        Label5.Text = "Quantity"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(564, 375)
        Label6.Name = "Label6"
        Label6.Size = New Size(43, 20)
        Label6.TabIndex = 13
        Label6.Text = "Price"
        ' 
        ' RoundedButton3
        ' 
        RoundedButton3.Anchor = AnchorStyles.Right
        RoundedButton3.BackColor = Color.Red
        RoundedButton3.BackgroundColor = Color.Red
        RoundedButton3.BorderColor = Color.PaleVioletRed
        RoundedButton3.BorderRadius = 9
        RoundedButton3.BorderSize = 0
        RoundedButton3.Cursor = Cursors.Hand
        RoundedButton3.FlatAppearance.BorderSize = 0
        RoundedButton3.FlatAppearance.MouseOverBackColor = Color.LightCoral
        RoundedButton3.FlatStyle = FlatStyle.Flat
        RoundedButton3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton3.ForeColor = Color.White
        RoundedButton3.Location = New Point(561, 519)
        RoundedButton3.Name = "RoundedButton3"
        RoundedButton3.Size = New Size(150, 40)
        RoundedButton3.TabIndex = 14
        RoundedButton3.Text = "REMOVE"
        RoundedButton3.TextColor = Color.White
        RoundedButton3.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton4
        ' 
        RoundedButton4.Anchor = AnchorStyles.Right
        RoundedButton4.BackColor = Color.SteelBlue
        RoundedButton4.BackgroundColor = Color.SteelBlue
        RoundedButton4.BorderColor = Color.PaleVioletRed
        RoundedButton4.BorderRadius = 9
        RoundedButton4.BorderSize = 0
        RoundedButton4.Cursor = Cursors.Hand
        RoundedButton4.FlatAppearance.BorderSize = 0
        RoundedButton4.FlatAppearance.MouseOverBackColor = Color.LightBlue
        RoundedButton4.FlatStyle = FlatStyle.Flat
        RoundedButton4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton4.ForeColor = Color.White
        RoundedButton4.Location = New Point(730, 519)
        RoundedButton4.Name = "RoundedButton4"
        RoundedButton4.Size = New Size(150, 40)
        RoundedButton4.TabIndex = 15
        RoundedButton4.Text = "CLEAR"
        RoundedButton4.TextColor = Color.White
        RoundedButton4.UseVisualStyleBackColor = False
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Anchor = AnchorStyles.Right
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"20x20", "45x45", "50x50", "60x60", "35x35"})
        ComboBox2.Location = New Point(564, 271)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(181, 23)
        ComboBox2.TabIndex = 16
        ' 
        ' InventoryForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(909, 598)
        Controls.Add(ComboBox2)
        Controls.Add(RoundedButton4)
        Controls.Add(RoundedButton3)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(RoundedButton2)
        Controls.Add(RoundedButton1)
        Controls.Add(RoundedPanel5)
        Controls.Add(RoundedPanel4)
        Controls.Add(ComboBox1)
        Controls.Add(RoundedPanel2)
        Controls.Add(RoundedPanel1)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Name = "InventoryForm"
        Text = "InventoryForm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel2.PerformLayout()
        RoundedPanel4.ResumeLayout(False)
        RoundedPanel4.PerformLayout()
        RoundedPanel5.ResumeLayout(False)
        RoundedPanel5.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RoundedPanel4 As RoundedPanel
    Friend WithEvents RoundedPanel5 As RoundedPanel
    Friend WithEvents RoundedButton1 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton2 As CustomControls.RJControls.RoundedButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RoundedButton3 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton4 As CustomControls.RJControls.RoundedButton
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
