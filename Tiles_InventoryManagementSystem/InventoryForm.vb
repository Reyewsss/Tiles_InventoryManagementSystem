Imports System.Windows.Forms.VisualStyles
Imports MySql.Data.MySqlClient

Public Class InventoryForm
    ' Load form and data
    Private Sub Inventory_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        InventoryLoadData()

        ' Set DataGridView properties
        DataGridView1.ReadOnly = True ' Initially, DataGridView is read-only
        DataGridView1.AllowUserToAddRows = False
    End Sub

    ' Method to load data into DataGridView
    Public Sub InventoryLoadData()
        DataGridView1.Rows.Clear()

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Corrected SQL query (removed extra comma)
            cmd = New MySqlCommand("SELECT item_code, item_description, item_size, item_type, stock_quantity, item_current_price FROM tbl_products", conn)
            dr = cmd.ExecuteReader()

            ' Loop through the data reader and add rows to DataGridView
            While dr.Read()
                ' Ensure data matches the correct column order
                DataGridView1.Rows.Add(
                dr("item_code").ToString(),       ' Column 1: item_code
                dr("item_description").ToString(), ' Column 2: item_description
                dr("item_type").ToString(),
                dr("item_size").ToString(),  ' Column 4: item_type (changed order)
                dr("stock_quantity").ToString(),   ' Column 5: stock_quantity (changed order)
                dr("item_current_price").ToString() ' Column 6: item_current_price
            )
            End While

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    '---------------------------------------------------------------------------------------------------------------------

    Public Sub AddProduct()
        ' Retrieve data from form controls (e.g., TextBoxes)
        Dim itemCode As String = TextBox1.Text.Trim()
        Dim description As String = TextBox2.Text.Trim()
        Dim itemType As String = ComboBox1.Text.Trim()
        Dim size As String = ComboBox2.Text.Trim()
        Dim quantity As Integer = TextBox3.Text.Trim()
        Dim currentPrice As Decimal = TextBox4.Text.Trim()

        ' Check if fields are not empty
        If String.IsNullOrWhiteSpace(itemCode) OrElse String.IsNullOrWhiteSpace(description) OrElse
           String.IsNullOrWhiteSpace(size) OrElse String.IsNullOrWhiteSpace(itemType) OrElse
           quantity <= 0 OrElse currentPrice <= 0 Then
            MsgBox("All fields are required and must have valid values.", vbExclamation)
            Return
        End If

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' SQL INSERT command to add a new product
            cmd = New MySqlCommand("INSERT INTO tbl_products (item_code, item_description, item_size, item_type, stock_quantity, item_current_price) 
                                VALUES (@itemCode, @description, @size, @itemType, @quantity, @currentPrice)", conn)

            ' Add parameters to the query
            cmd.Parameters.AddWithValue("@itemCode", itemCode)
            cmd.Parameters.AddWithValue("@description", description)
            cmd.Parameters.AddWithValue("@size", size)
            cmd.Parameters.AddWithValue("@itemType", itemType)
            cmd.Parameters.AddWithValue("@quantity", quantity)
            cmd.Parameters.AddWithValue("@price", currentPrice)

            ' Execute the query
            Dim result = cmd.ExecuteNonQuery()

            If result > 0 Then
                MsgBox("Product added successfully.", vbInformation)
                InventoryLoadData() ' Refresh DataGridView with new data
            Else
                MsgBox("Failed to add product.", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbExclamation)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        ' Call the AddProduct method to add the product
        AddProduct()

        ' Clear the text boxes
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

        ' Reset ComboBoxes (use SelectedIndex for ComboBoxes)
        ComboBox1.SelectedIndex = -1 ' Resets ComboBox1 to no selection
        ComboBox2.SelectedIndex = -1 ' Resets ComboBox2 to no selection
    End Sub

    '---------------------------------------------------------------------------------------------------------------------

    ' Declare a variable to store the selected item code (item_code) for updating the record
    Private selectedItemCode As Integer

    ' Handle DataGridView row click to populate the TextBoxes and ComboBoxes
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Ensure a row is clicked (not the header)
        If e.RowIndex >= 0 Then
            ' Get the item code from the selected row
            selectedItemCode = DataGridView1.Rows(e.RowIndex).Cells("item_code").Value

            ' Populate the fields with the data from the selected row
            TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells("item_code").Value.ToString()
            TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells("item_description").Value.ToString()
            ComboBox1.SelectedItem = DataGridView1.Rows(e.RowIndex).Cells("item_type").Value.ToString()
            ComboBox2.SelectedItem = DataGridView1.Rows(e.RowIndex).Cells("item_size").Value.ToString()
            TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells("stock_quantity").Value.ToString()
            TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells("item_current_price").Value.ToString()
        End If
    End Sub

    ' Handle the update button click
    Private Sub RoundedButton2_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        ' Retrieve values from the form controls
        Dim itemCode As Integer = TextBox1.Text
        Dim itemName As String = TextBox2.Text
        Dim itemType As String = ComboBox1.SelectedItem.ToString()
        Dim itemSize As String = ComboBox2.SelectedItem.ToString()
        Dim stockQuantity As Integer = Convert.ToInt32(TextBox3.Text)
        Dim itemPrice As Decimal = Convert.ToDecimal(TextBox4.Text)

        ' Validate that all fields are filled
        If validateFields("Edit") Then
            MessageBox.Show("All fields are required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            ' Get the database connection
            Dim con As New MySqlConnection("Your_Connection_String_Here")
            con.Open()

            ' Prepare the SQL query for updating product data
            Dim query As String = "UPDATE tbl_products SET item_name = @itemName, item_type = @itemType, item_size = @itemSize, " &
                                   "stock_quantity = @stockQuantity, item_current_price = @itemPrice WHERE item_code = @itemCode"

            ' Use a prepared statement to prevent SQL injection
            Using ps As New MySqlCommand(query, con)
                ' Add parameters to the SQL query
                ps.Parameters.AddWithValue("@itemCode", itemCode)
                ps.Parameters.AddWithValue("@itemName", itemName)
                ps.Parameters.AddWithValue("@itemType", itemType)
                ps.Parameters.AddWithValue("@itemSize", itemSize)
                ps.Parameters.AddWithValue("@stockQuantity", stockQuantity)
                ps.Parameters.AddWithValue("@itemPrice", itemPrice)

                ' Execute the query
                ps.ExecuteNonQuery()
            End Using

            ' Success message
            MessageBox.Show("Product updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh DataGridView to show the updated data (this method should load the data again from the database)
            InventoryLoadData()

        Catch ex As Exception
            ' Display error message if something goes wrong
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection if it's open
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Validate fields (This is a placeholder function, replace with your actual validation logic)
    Private Function validateFields(action As String) As Boolean
        ' Example validation check - ensure that none of the required fields are empty
        If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse String.IsNullOrWhiteSpace(TextBox2.Text) OrElse
           String.IsNullOrWhiteSpace(ComboBox1.SelectedItem.ToString()) OrElse String.IsNullOrWhiteSpace(ComboBox2.SelectedItem.ToString()) OrElse
           String.IsNullOrWhiteSpace(TextBox3.Text) OrElse String.IsNullOrWhiteSpace(TextBox4.Text) Then
            Return True
        End If
        Return False
    End Function



End Class
