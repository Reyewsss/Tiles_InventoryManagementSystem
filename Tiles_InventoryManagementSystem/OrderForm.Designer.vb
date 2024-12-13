<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderForm
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
        Column7 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        RoundedPanel1 = New RoundedPanel()
        TextBox1 = New TextBox()
        RoundedPanel2 = New RoundedPanel()
        RoundedPanel3 = New RoundedPanel()
        TextBox3 = New TextBox()
        RoundedPanel4 = New RoundedPanel()
        TextBox4 = New TextBox()
        TextBox2 = New TextBox()
        RoundedPanel5 = New RoundedPanel()
        TextBox5 = New TextBox()
        RoundedPanel6 = New RoundedPanel()
        TextBox6 = New TextBox()
        RoundedPanel7 = New RoundedPanel()
        TextBox7 = New TextBox()
        RoundedPanel8 = New RoundedPanel()
        TextBox8 = New TextBox()
        RoundedPanel9 = New RoundedPanel()
        TextBox9 = New TextBox()
        RoundedButton2 = New CustomControls.RJControls.RoundedButton()
        RoundedButton1 = New CustomControls.RJControls.RoundedButton()
        RoundedButton3 = New CustomControls.RJControls.RoundedButton()
        Label1 = New Label()
        RoundedPanel11 = New RoundedPanel()
        TextBox11 = New TextBox()
        RoundedPanel13 = New RoundedPanel()
        TextBox13 = New TextBox()
        RoundedPanel14 = New RoundedPanel()
        TextBox14 = New TextBox()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        RoundedPanel10 = New RoundedPanel()
        TextBox10 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        RoundedPanel2.SuspendLayout()
        RoundedPanel3.SuspendLayout()
        RoundedPanel4.SuspendLayout()
        RoundedPanel5.SuspendLayout()
        RoundedPanel6.SuspendLayout()
        RoundedPanel7.SuspendLayout()
        RoundedPanel8.SuspendLayout()
        RoundedPanel9.SuspendLayout()
        RoundedPanel11.SuspendLayout()
        RoundedPanel13.SuspendLayout()
        RoundedPanel14.SuspendLayout()
        RoundedPanel10.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column7, Column1, Column2, Column9, Column8, Column3, Column4, Column5, Column6})
        DataGridView1.Location = New Point(12, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.Size = New Size(885, 226)
        DataGridView1.TabIndex = 0
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column7.HeaderText = "Customer Name"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "Item Code"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 80
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Item Name"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Type"
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Item Size"
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Quantity"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 78
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Price"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 58
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "Total Value"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 81
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "Order Date"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 82
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.Anchor = AnchorStyles.Bottom
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderThickness = 2
        RoundedPanel1.Controls.Add(TextBox1)
        RoundedPanel1.Location = New Point(42, 287)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(193, 29)
        RoundedPanel1.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(7, 6)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "First Name"
        TextBox1.Size = New Size(183, 16)
        TextBox1.TabIndex = 2
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.Anchor = AnchorStyles.Bottom
        RoundedPanel2.BorderColor = Color.Black
        RoundedPanel2.BorderThickness = 2
        RoundedPanel2.Controls.Add(RoundedPanel3)
        RoundedPanel2.Controls.Add(RoundedPanel4)
        RoundedPanel2.Controls.Add(TextBox2)
        RoundedPanel2.Location = New Point(241, 287)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(193, 29)
        RoundedPanel2.TabIndex = 3
        ' 
        ' RoundedPanel3
        ' 
        RoundedPanel3.BorderColor = Color.Black
        RoundedPanel3.BorderThickness = 2
        RoundedPanel3.Controls.Add(TextBox3)
        RoundedPanel3.Location = New Point(0, 25)
        RoundedPanel3.Name = "RoundedPanel3"
        RoundedPanel3.Size = New Size(193, 29)
        RoundedPanel3.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(7, 3)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(183, 23)
        TextBox3.TabIndex = 2
        ' 
        ' RoundedPanel4
        ' 
        RoundedPanel4.BorderColor = Color.Black
        RoundedPanel4.BorderThickness = 2
        RoundedPanel4.Controls.Add(TextBox4)
        RoundedPanel4.Location = New Point(0, -26)
        RoundedPanel4.Name = "RoundedPanel4"
        RoundedPanel4.Size = New Size(193, 29)
        RoundedPanel4.TabIndex = 4
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(7, 3)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(183, 23)
        TextBox4.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Location = New Point(7, 6)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Middle Name"
        TextBox2.Size = New Size(183, 16)
        TextBox2.TabIndex = 2
        ' 
        ' RoundedPanel5
        ' 
        RoundedPanel5.Anchor = AnchorStyles.Bottom
        RoundedPanel5.BorderColor = Color.Black
        RoundedPanel5.BorderThickness = 2
        RoundedPanel5.Controls.Add(TextBox5)
        RoundedPanel5.Location = New Point(241, 339)
        RoundedPanel5.Name = "RoundedPanel5"
        RoundedPanel5.Size = New Size(97, 29)
        RoundedPanel5.TabIndex = 5
        ' 
        ' TextBox5
        ' 
        TextBox5.BorderStyle = BorderStyle.None
        TextBox5.Location = New Point(7, 6)
        TextBox5.Name = "TextBox5"
        TextBox5.PlaceholderText = "Suffix"
        TextBox5.Size = New Size(87, 16)
        TextBox5.TabIndex = 2
        ' 
        ' RoundedPanel6
        ' 
        RoundedPanel6.Anchor = AnchorStyles.Bottom
        RoundedPanel6.BorderColor = Color.Black
        RoundedPanel6.BorderThickness = 2
        RoundedPanel6.Controls.Add(TextBox6)
        RoundedPanel6.Location = New Point(42, 339)
        RoundedPanel6.Name = "RoundedPanel6"
        RoundedPanel6.Size = New Size(193, 29)
        RoundedPanel6.TabIndex = 4
        ' 
        ' TextBox6
        ' 
        TextBox6.BorderStyle = BorderStyle.None
        TextBox6.Location = New Point(7, 6)
        TextBox6.Name = "TextBox6"
        TextBox6.PlaceholderText = "Last Name"
        TextBox6.Size = New Size(183, 16)
        TextBox6.TabIndex = 2
        ' 
        ' RoundedPanel7
        ' 
        RoundedPanel7.Anchor = AnchorStyles.Bottom
        RoundedPanel7.BorderColor = Color.Black
        RoundedPanel7.BorderThickness = 2
        RoundedPanel7.Controls.Add(TextBox7)
        RoundedPanel7.Location = New Point(42, 391)
        RoundedPanel7.Name = "RoundedPanel7"
        RoundedPanel7.Size = New Size(389, 29)
        RoundedPanel7.TabIndex = 5
        ' 
        ' TextBox7
        ' 
        TextBox7.BorderStyle = BorderStyle.None
        TextBox7.Location = New Point(7, 6)
        TextBox7.Name = "TextBox7"
        TextBox7.PlaceholderText = "Address"
        TextBox7.Size = New Size(379, 16)
        TextBox7.TabIndex = 2
        ' 
        ' RoundedPanel8
        ' 
        RoundedPanel8.Anchor = AnchorStyles.Bottom
        RoundedPanel8.BorderColor = Color.Black
        RoundedPanel8.BorderThickness = 2
        RoundedPanel8.Controls.Add(TextBox8)
        RoundedPanel8.Location = New Point(42, 443)
        RoundedPanel8.Name = "RoundedPanel8"
        RoundedPanel8.Size = New Size(247, 29)
        RoundedPanel8.TabIndex = 6
        ' 
        ' TextBox8
        ' 
        TextBox8.BorderStyle = BorderStyle.None
        TextBox8.Location = New Point(7, 6)
        TextBox8.Name = "TextBox8"
        TextBox8.PlaceholderText = "Phone Number"
        TextBox8.Size = New Size(237, 16)
        TextBox8.TabIndex = 2
        ' 
        ' RoundedPanel9
        ' 
        RoundedPanel9.Anchor = AnchorStyles.Bottom
        RoundedPanel9.BorderColor = Color.Black
        RoundedPanel9.BorderThickness = 2
        RoundedPanel9.Controls.Add(TextBox9)
        RoundedPanel9.Location = New Point(42, 495)
        RoundedPanel9.Name = "RoundedPanel9"
        RoundedPanel9.Size = New Size(247, 29)
        RoundedPanel9.TabIndex = 7
        ' 
        ' TextBox9
        ' 
        TextBox9.BorderStyle = BorderStyle.None
        TextBox9.Location = New Point(7, 6)
        TextBox9.Name = "TextBox9"
        TextBox9.PlaceholderText = "Email"
        TextBox9.Size = New Size(237, 16)
        TextBox9.TabIndex = 2
        ' 
        ' RoundedButton2
        ' 
        RoundedButton2.Anchor = AnchorStyles.Bottom
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
        RoundedButton2.Location = New Point(380, 546)
        RoundedButton2.Name = "RoundedButton2"
        RoundedButton2.Size = New Size(150, 40)
        RoundedButton2.TabIndex = 9
        RoundedButton2.Text = "EDIT"
        RoundedButton2.TextColor = Color.White
        RoundedButton2.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton1
        ' 
        RoundedButton1.Anchor = AnchorStyles.Bottom
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
        RoundedButton1.Location = New Point(211, 546)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.Size = New Size(150, 40)
        RoundedButton1.TabIndex = 8
        RoundedButton1.Text = "SAVE"
        RoundedButton1.TextColor = Color.White
        RoundedButton1.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton3
        ' 
        RoundedButton3.Anchor = AnchorStyles.Bottom
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
        RoundedButton3.Location = New Point(548, 546)
        RoundedButton3.Name = "RoundedButton3"
        RoundedButton3.Size = New Size(150, 40)
        RoundedButton3.TabIndex = 15
        RoundedButton3.Text = "REMOVE"
        RoundedButton3.TextColor = Color.White
        RoundedButton3.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(122, 252)
        Label1.Name = "Label1"
        Label1.Size = New Size(199, 20)
        Label1.TabIndex = 16
        Label1.Text = "CUSTOMER INFORMATION"
        ' 
        ' RoundedPanel11
        ' 
        RoundedPanel11.Anchor = AnchorStyles.Bottom
        RoundedPanel11.BorderColor = Color.Black
        RoundedPanel11.BorderThickness = 2
        RoundedPanel11.Controls.Add(TextBox11)
        RoundedPanel11.Location = New Point(481, 459)
        RoundedPanel11.Name = "RoundedPanel11"
        RoundedPanel11.Size = New Size(119, 29)
        RoundedPanel11.TabIndex = 20
        ' 
        ' TextBox11
        ' 
        TextBox11.BorderStyle = BorderStyle.None
        TextBox11.Location = New Point(7, 6)
        TextBox11.Name = "TextBox11"
        TextBox11.PlaceholderText = "Quantity"
        TextBox11.Size = New Size(109, 16)
        TextBox11.TabIndex = 2
        ' 
        ' RoundedPanel13
        ' 
        RoundedPanel13.Anchor = AnchorStyles.Bottom
        RoundedPanel13.BorderColor = Color.Black
        RoundedPanel13.BorderThickness = 2
        RoundedPanel13.Controls.Add(TextBox13)
        RoundedPanel13.Location = New Point(680, 343)
        RoundedPanel13.Name = "RoundedPanel13"
        RoundedPanel13.Size = New Size(193, 29)
        RoundedPanel13.TabIndex = 18
        ' 
        ' TextBox13
        ' 
        TextBox13.BorderStyle = BorderStyle.None
        TextBox13.Location = New Point(7, 6)
        TextBox13.Name = "TextBox13"
        TextBox13.PlaceholderText = "Item Name"
        TextBox13.Size = New Size(183, 16)
        TextBox13.TabIndex = 2
        ' 
        ' RoundedPanel14
        ' 
        RoundedPanel14.Anchor = AnchorStyles.Bottom
        RoundedPanel14.BorderColor = Color.Black
        RoundedPanel14.BorderThickness = 2
        RoundedPanel14.Controls.Add(TextBox14)
        RoundedPanel14.Location = New Point(481, 343)
        RoundedPanel14.Name = "RoundedPanel14"
        RoundedPanel14.Size = New Size(193, 29)
        RoundedPanel14.TabIndex = 17
        ' 
        ' TextBox14
        ' 
        TextBox14.BorderStyle = BorderStyle.None
        TextBox14.Location = New Point(7, 6)
        TextBox14.Name = "TextBox14"
        TextBox14.PlaceholderText = "Item Code"
        TextBox14.Size = New Size(183, 16)
        TextBox14.TabIndex = 2
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Bottom
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(481, 413)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(181, 23)
        ComboBox1.TabIndex = 22
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Anchor = AnchorStyles.Bottom
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(680, 413)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(181, 23)
        ComboBox2.TabIndex = 23
        ' 
        ' RoundedPanel10
        ' 
        RoundedPanel10.Anchor = AnchorStyles.Bottom
        RoundedPanel10.BorderColor = Color.Black
        RoundedPanel10.BorderThickness = 2
        RoundedPanel10.Controls.Add(TextBox10)
        RoundedPanel10.Location = New Point(616, 459)
        RoundedPanel10.Name = "RoundedPanel10"
        RoundedPanel10.Size = New Size(119, 29)
        RoundedPanel10.TabIndex = 21
        ' 
        ' TextBox10
        ' 
        TextBox10.BorderStyle = BorderStyle.None
        TextBox10.Location = New Point(7, 6)
        TextBox10.Name = "TextBox10"
        TextBox10.PlaceholderText = "Price"
        TextBox10.Size = New Size(109, 16)
        TextBox10.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(592, 296)
        Label2.Name = "Label2"
        Label2.Size = New Size(170, 20)
        Label2.TabIndex = 24
        Label2.Text = "ORDER INFORMATION"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(480, 390)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 20)
        Label3.TabIndex = 25
        Label3.Text = "Tile Type"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(680, 390)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 20)
        Label4.TabIndex = 26
        Label4.Text = "Size"
        ' 
        ' OrderForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(909, 598)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(RoundedPanel10)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(RoundedPanel11)
        Controls.Add(RoundedPanel13)
        Controls.Add(RoundedPanel14)
        Controls.Add(Label1)
        Controls.Add(RoundedButton3)
        Controls.Add(RoundedButton2)
        Controls.Add(RoundedButton1)
        Controls.Add(RoundedPanel9)
        Controls.Add(RoundedPanel8)
        Controls.Add(RoundedPanel7)
        Controls.Add(RoundedPanel5)
        Controls.Add(RoundedPanel6)
        Controls.Add(RoundedPanel2)
        Controls.Add(RoundedPanel1)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Name = "OrderForm"
        Text = "OrderForm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
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
        RoundedPanel8.ResumeLayout(False)
        RoundedPanel8.PerformLayout()
        RoundedPanel9.ResumeLayout(False)
        RoundedPanel9.PerformLayout()
        RoundedPanel11.ResumeLayout(False)
        RoundedPanel11.PerformLayout()
        RoundedPanel13.ResumeLayout(False)
        RoundedPanel13.PerformLayout()
        RoundedPanel14.ResumeLayout(False)
        RoundedPanel14.PerformLayout()
        RoundedPanel10.ResumeLayout(False)
        RoundedPanel10.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents RoundedPanel4 As RoundedPanel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents RoundedPanel5 As RoundedPanel
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents RoundedPanel6 As RoundedPanel
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents RoundedPanel7 As RoundedPanel
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents RoundedPanel8 As RoundedPanel
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents RoundedPanel9 As RoundedPanel
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents RoundedButton2 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton1 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton3 As CustomControls.RJControls.RoundedButton
    Friend WithEvents Label1 As Label
    Friend WithEvents RoundedPanel11 As RoundedPanel
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents RoundedPanel13 As RoundedPanel
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents RoundedPanel14 As RoundedPanel
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents RoundedPanel10 As RoundedPanel
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
