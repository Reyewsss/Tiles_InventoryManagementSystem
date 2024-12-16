<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory_Reports
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
        Column7 = New DataGridViewTextBoxColumn()
        RoundedButton1 = New CustomControls.RJControls.RoundedButton()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.Size = New Size(885, 455)
        DataGridView1.TabIndex = 1
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
        Column5.HeaderText = "Old Price"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 80
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "Current Price"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 101
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column7.HeaderText = "Quantity"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 78
        ' 
        ' RoundedButton1
        ' 
        RoundedButton1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        RoundedButton1.BackColor = Color.SteelBlue
        RoundedButton1.BackgroundColor = Color.SteelBlue
        RoundedButton1.BorderColor = Color.PaleVioletRed
        RoundedButton1.BorderRadius = 9
        RoundedButton1.BorderSize = 0
        RoundedButton1.FlatAppearance.BorderSize = 0
        RoundedButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        RoundedButton1.FlatStyle = FlatStyle.Flat
        RoundedButton1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton1.ForeColor = Color.White
        RoundedButton1.Location = New Point(723, 467)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.Size = New Size(150, 40)
        RoundedButton1.TabIndex = 3
        RoundedButton1.Text = "EXPORT"
        RoundedButton1.TextColor = Color.White
        RoundedButton1.UseVisualStyleBackColor = False
        ' 
        ' Inventory_Reports
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(885, 524)
        Controls.Add(RoundedButton1)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Inventory_Reports"
        Text = "Inventory_Reports"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents RoundedButton1 As CustomControls.RJControls.RoundedButton
End Class
