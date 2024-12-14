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

            ' Retrieve both old and current price
            Dim query As String = "SELECT item_code, item_description, item_type, item_size, stock_quantity, item_old_price, item_current_price FROM tbl_products"
            cmd = New MySqlCommand(query, conn)
            dr = cmd.ExecuteReader()

            ' Loop through the data reader and add rows to DataGridView
            While dr.Read()
                DataGridView1.Rows.Add(
                dr("item_code").ToString(),          ' Column 1: item_code
                dr("item_description").ToString(),   ' Column 2: item_description
                dr("item_type").ToString(),          ' Column 3: item_type
                dr("item_size").ToString(),          ' Column 4: item_size
                dr("stock_quantity").ToString(),     ' Column 5: stock_quantity
                dr("item_old_price").ToString(),     ' Column 6: item_old_price
                dr("item_current_price").ToString()  ' Column 7: item_current_price
            )
            End While

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Dim quantity As Integer
        Dim OldPrice As Decimal

        ' Validate fields
        If String.IsNullOrWhiteSpace(itemCode) OrElse String.IsNullOrWhiteSpace(description) OrElse
       String.IsNullOrWhiteSpace(size) OrElse String.IsNullOrWhiteSpace(itemType) Then
            MsgBox("All fields are required.", vbExclamation)
            Return
        End If

        ' Validate numeric fields
        If Not Integer.TryParse(TextBox3.Text.Trim(), quantity) OrElse quantity <= 0 Then
            MsgBox("Please enter a valid quantity.", vbExclamation)
            Return
        End If

        If Not Decimal.TryParse(TextBox4.Text.Trim(), OldPrice) OrElse OldPrice <= 0 Then
            MsgBox("Please enter a valid price.", vbExclamation)
            Return
        End If

        Try
            ' Open the database connection if it's not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' SQL INSERT command to add a new product
            cmd = New MySqlCommand("INSERT INTO tbl_products (item_code, item_description, item_size, item_type, stock_quantity, item_old_price) 
                                VALUES (@itemCode, @description, @size, @itemType, @quantity, @price)", conn)

            ' Add parameters to the query
            cmd.Parameters.AddWithValue("@itemCode", itemCode)
            cmd.Parameters.AddWithValue("@description", description)
            cmd.Parameters.AddWithValue("@size", size)
            cmd.Parameters.AddWithValue("@itemType", itemType)
            cmd.Parameters.AddWithValue("@quantity", quantity)
            cmd.Parameters.AddWithValue("@price", OldPrice)

            ' Execute the query
            Dim result = cmd.ExecuteNonQuery()

            If result > 0 Then
                MsgBox("Product added successfully.", vbInformation)
                InventoryLoadData() ' Refresh DataGridView with new data
            Else
                MsgBox("Failed to add product.", vbExclamation)
            End If

        Catch ex As MySqlException
            ' Handle SQL exceptions specifically
            MsgBox("Database error: " & ex.Message, vbExclamation)
        Catch ex As Exception
            ' Catch any other unexpected exceptions
            MsgBox("Error: " & ex.Message, vbExclamation)
        Finally
            ' Ensure the connection is closed
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.CurrentRow IsNot Nothing Then
            Dim i As Integer = DataGridView1.CurrentRow.Index

            ' Populate TextBoxes and ComboBoxes with the values from the selected row
            TextBox1.Text = DataGridView1.Item(0, i).Value?.ToString() ' Item Code
            TextBox2.Text = DataGridView1.Item(1, i).Value?.ToString() ' Item Name
            ComboBox1.SelectedItem = DataGridView1.Item(2, i).Value?.ToString() ' Item Type
            ComboBox2.SelectedItem = DataGridView1.Item(3, i).Value?.ToString() ' Item Size
            TextBox3.Text = DataGridView1.Item(4, i).Value?.ToString() ' Stock Quantity
            TextBox4.Text = DataGridView1.Item(5, i).Value?.ToString() ' Item Price
        End If
    End Sub

    Private Sub RoundedButton2_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        ' Retrieve values from the form controls
        Dim itemCode As String = TextBox1.Text
        Dim itemName As String = TextBox2.Text
        Dim itemType As String = If(ComboBox1.SelectedItem IsNot Nothing, ComboBox1.SelectedItem.ToString(), String.Empty)
        Dim itemSize As String = If(ComboBox2.SelectedItem IsNot Nothing, ComboBox2.SelectedItem.ToString(), String.Empty)
        Dim stockQuantity As Integer
        Dim itemPrice As Decimal

        ' Validate fields
        If String.IsNullOrWhiteSpace(itemCode) OrElse
       String.IsNullOrWhiteSpace(itemName) OrElse
       String.IsNullOrWhiteSpace(itemType) OrElse
       String.IsNullOrWhiteSpace(itemSize) OrElse
       Not Integer.TryParse(TextBox3.Text, stockQuantity) OrElse
       Not Decimal.TryParse(TextBox4.Text, itemPrice) Then

            MessageBox.Show("All fields are required and must be valid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Update item_old_price with the current price, and then update the current price
            Dim query As String = "UPDATE tbl_products " &
                              "SET item_current_price = item_old_price, " &
                              "    item_description = @itemName, " &
                              "    item_type = @itemType, " &
                              "    item_size = @itemSize, " &
                              "    stock_quantity = @stockQuantity, " &
                              "    item_current_price = @itemPrice " &
                              "WHERE item_code = @itemCode"

            ' Use a prepared statement to prevent SQL injection
            Using ps As New MySqlCommand(query, conn)
                ps.Parameters.AddWithValue("@itemCode", itemCode)
                ps.Parameters.AddWithValue("@itemName", itemName)
                ps.Parameters.AddWithValue("@itemType", itemType)
                ps.Parameters.AddWithValue("@itemSize", itemSize)
                ps.Parameters.AddWithValue("@stockQuantity", stockQuantity)
                ps.Parameters.AddWithValue("@itemPrice", itemPrice)

                ps.ExecuteNonQuery()
            End Using

            MessageBox.Show("Product updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh DataGridView to show the updated data
            InventoryLoadData()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    '-----------------------------------------------------------------------------------------------------------

    Private Sub RoundedButton4_Click(sender As Object, e As EventArgs) Handles RoundedButton4.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

        ' Reset ComboBoxes (use SelectedIndex for ComboBoxes)
        ComboBox1.SelectedIndex = -1 ' Resets ComboBox1 to no selection
        ComboBox2.SelectedIndex = -1 ' Resets ComboBox2 to no selection
    End Sub

    '-----------------------------------------------------------------------------------------------------------

    Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        ' Ensure a row is selected in the DataGridView
        If DataGridView1.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a row to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the item_code from the selected row (assuming item_code is in the first column)
        Dim itemCode As String = DataGridView1.CurrentRow.Cells(0).Value.ToString()

        ' Confirm deletion
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Return
        End If

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Prepare the SQL query for deleting the product data
            Dim query As String = "DELETE FROM tbl_products WHERE item_code = @itemCode"

            Using ps As New MySqlCommand(query, conn)
                ' Add the item_code parameter to the SQL query
                ps.Parameters.AddWithValue("@itemCode", itemCode)

                ' Execute the query
                Dim rowsAffected As Integer = ps.ExecuteNonQuery()

                ' Check if the deletion was successful
                If rowsAffected > 0 Then
                    MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Refresh DataGridView to show updated data
                    InventoryLoadData()
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox3.Clear()
                    TextBox4.Clear()

                    ' Reset ComboBoxes (use SelectedIndex for ComboBoxes)
                    ComboBox1.SelectedIndex = -1 ' Resets ComboBox1 to no selection
                    ComboBox2.SelectedIndex = -1 ' Resets ComboBox2 to no selection
                Else
                    MessageBox.Show("No item found with the provided item code.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            ' Display error message if something goes wrong
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
End Class
