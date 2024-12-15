Imports System.Transactions
Imports MySql.Data.MySqlClient

Public Class OrderForm
    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        OrderLoadData()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Ensure the clicked row is not the header row
        If e.RowIndex >= 0 Then
            ' Get the clicked row using e.RowIndex
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Retrieve data from the selected row and assign to the form controls
            TextBox1.Text = selectedRow.Cells(0).Value?.ToString()
            TextBox7.Text = selectedRow.Cells(1).Value?.ToString()
            TextBox8.Text = selectedRow.Cells(2).Value?.ToString()
            TextBox9.Text = selectedRow.Cells(3).Value?.ToString()
            TextBox10.Text = selectedRow.Cells(4).Value?.ToString()
            TextBox11.Text = selectedRow.Cells(5).Value?.ToString()
            ComboBox1.SelectedItem = selectedRow.Cells(6).Value?.ToString()
            ComboBox2.SelectedItem = selectedRow.Cells(7).Value?.ToString()
            TextBox12.Text = selectedRow.Cells(8).Value?.ToString()
            TextBox13.Text = selectedRow.Cells(9).Value?.ToString()

            ' Assuming DateTimePicker1 expects a DateTime value
            If DateTime.TryParse(selectedRow.Cells(11).Value?.ToString(), Nothing) Then
                DateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells(11).Value)
            End If
        End If
    End Sub


    '----------------------------------------------------------------------------------------------------
    'SAVE BUTTON
    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        ' Retrieve data from form controls
        Dim firstName As String = TextBox1.Text.Trim()
        Dim middleName As String = TextBox2.Text.Trim()
        Dim lastName As String = TextBox5.Text.Trim()
        Dim suffix As String = TextBox6.Text.Trim()
        Dim address As String = TextBox7.Text.Trim()
        Dim phoneNumber As String = TextBox8.Text.Trim()
        Dim emailAddress As String = TextBox9.Text.Trim()
        Dim itemCode As String = TextBox10.Text.Trim()
        Dim itemName As String = TextBox11.Text.Trim()
        Dim itemType As String = ComboBox1.Text.Trim()
        Dim size As String = ComboBox2.Text.Trim()
        Dim quantity As Integer
        Dim price As Decimal
        Dim dateAdded As Date = DateTimePicker1.Value.Date

        ' Validate required fields
        If String.IsNullOrWhiteSpace(firstName) OrElse String.IsNullOrWhiteSpace(lastName) OrElse
    String.IsNullOrWhiteSpace(itemCode) OrElse String.IsNullOrWhiteSpace(itemName) OrElse
    Not Integer.TryParse(TextBox12.Text.Trim(), quantity) OrElse quantity <= 0 OrElse
    Not Decimal.TryParse(TextBox13.Text.Trim(), price) OrElse price <= 0 Then
            MessageBox.Show("Please fill all required fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Calculate the total price
        Dim totalPrice As Decimal = quantity * price

        ' Declare the transaction variable outside the Try block
        Dim transaction As MySqlTransaction = Nothing

        Try
            ' Open the database connection if it's not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Start a new transaction
            transaction = conn.BeginTransaction()

            ' Step 1: Retrieve the current stock of the product
            Dim queryStock As String = "SELECT stock_quantity FROM tbl_products WHERE item_code = @itemCode"
            Dim currentStock As Integer = 0
            Using cmdStock As New MySqlCommand(queryStock, conn, transaction)
                cmdStock.Parameters.AddWithValue("@itemCode", itemCode)
                ' Execute the query and read the result
                Using drStock As MySqlDataReader = cmdStock.ExecuteReader()
                    If drStock.HasRows Then
                        drStock.Read()
                        currentStock = Convert.ToInt32(drStock("stock_quantity"))
                    End If
                End Using
            End Using

            ' Step 2: Check if there's enough stock
            If quantity > currentStock Then
                MessageBox.Show("Insufficient stock. Available stock: " & currentStock, "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Step 3: Insert customer data into tbl_customer
            Dim queryCustomer As String = "INSERT INTO tbl_customer (customer_fname, customer_mname, customer_lname, customer_suffix, customer_address, customer_phone, customer_email) " &
                               "VALUES (@firstName, @middleName, @lastName, @suffix, @address, @phoneNumber, @emailAddress)"

            Dim customerId As Integer
            Using cmdCustomer As New MySqlCommand(queryCustomer, conn, transaction)
                cmdCustomer.Parameters.AddWithValue("@firstName", firstName)
                cmdCustomer.Parameters.AddWithValue("@middleName", middleName)
                cmdCustomer.Parameters.AddWithValue("@lastName", lastName)
                cmdCustomer.Parameters.AddWithValue("@suffix", suffix)
                cmdCustomer.Parameters.AddWithValue("@address", address)
                cmdCustomer.Parameters.AddWithValue("@phoneNumber", phoneNumber)
                cmdCustomer.Parameters.AddWithValue("@emailAddress", emailAddress)

                ' Execute the command and retrieve the customer_id (AutoIncremented)
                cmdCustomer.ExecuteNonQuery()

                ' Get the last inserted customer_id
                customerId = Convert.ToInt32(cmdCustomer.LastInsertedId)
            End Using

            ' Step 4: Insert order data into tbl_order, including the total price
            Dim queryOrder As String = "INSERT INTO tbl_order (customer_id, item_code, item_name, item_type, item_size, item_quantity, item_price, save_date, order_total_value) " &
                                   "VALUES (@customerId, @itemCode, @itemName, @type, @size, @quantity, @price, @dateAdded, @totalPrice)"

            Using cmdOrder As New MySqlCommand(queryOrder, conn, transaction)
                cmdOrder.Parameters.AddWithValue("@customerId", customerId) ' Add customer_id from the first query
                cmdOrder.Parameters.AddWithValue("@itemCode", itemCode)
                cmdOrder.Parameters.AddWithValue("@itemName", itemName)
                cmdOrder.Parameters.AddWithValue("@type", itemType)
                cmdOrder.Parameters.AddWithValue("@size", size)
                cmdOrder.Parameters.AddWithValue("@quantity", quantity)
                cmdOrder.Parameters.AddWithValue("@price", price)
                cmdOrder.Parameters.AddWithValue("@totalPrice", totalPrice) ' Store the calculated total price
                cmdOrder.Parameters.AddWithValue("@dateAdded", dateAdded)

                ' Execute the command to insert the order
                cmdOrder.ExecuteNonQuery()
            End Using

            ' Step 5: Deduct the stock from tbl_products
            Dim queryUpdateStock As String = "UPDATE tbl_products SET stock_quantity = stock_quantity - @quantity WHERE item_code = @itemCode"
            Using cmdUpdateStock As New MySqlCommand(queryUpdateStock, conn, transaction)
                cmdUpdateStock.Parameters.AddWithValue("@itemCode", itemCode)
                cmdUpdateStock.Parameters.AddWithValue("@quantity", quantity)
                cmdUpdateStock.ExecuteNonQuery() ' Update stock
            End Using

            ' Commit the transaction if everything was successful
            transaction.Commit()

            ' Refresh DataGridView or other UI updates
            OrderLoadData()

            MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            ' Rollback the transaction if an error occurs
            If transaction IsNot Nothing Then
                transaction.Rollback()
            End If
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Ensure the connection is closed
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    '-----------------------------------------------------------------------------------------------------------------------------

    ' Method to load data into DataGridView (customer and order data)
    Public Sub OrderLoadData()
        DataGridView1.Rows.Clear()

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Retrieve data from the database
            Dim query As String = "SELECT CONCAT(c.customer_fname, ' ', " &
                      "IFNULL(c.customer_mname, ''), ' ', " &
                      "c.customer_lname, ' ', " &
                      "IFNULL(c.customer_suffix, '')) AS customer_name, " &
                      "c.customer_address, c.customer_phone, c.customer_email, " &
                      "o.item_code, o.item_name, o.item_type, o.item_size, " &
                      "o.item_quantity, o.item_price, o.save_date, o.order_total_value " &
                      "FROM tbl_order o " &
                      "INNER JOIN tbl_customer c ON o.customer_id = c.customer_id"
            cmd = New MySqlCommand(query, conn)
            dr = cmd.ExecuteReader()


            ' Debugging: Check if data is returned
            If Not dr.HasRows Then
                MessageBox.Show("No data found.", "Data Check", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' Loop through the data reader and add rows to DataGridView
            While dr.Read()
                DataGridView1.Rows.Add(
                    dr("customer_fname").ToString(),
                    dr("customer_address").ToString(),
                    dr("customer_phone").ToString(),
                    dr("customer_email").ToString(),
                    dr("item_code").ToString(),
                    dr("item_name").ToString(),
                    dr("item_type").ToString(),
                    dr("item_size").ToString(),
                    dr("item_quantity").ToString(),
                    dr("item_price").ToString(),
                    Convert.ToDateTime(dr("save_date")).ToString("MM/dd/yyyy"),
                    If(IsDBNull(dr("order_total_value")), 0D, Convert.ToDecimal(dr("order_total_value"))) ' Handle DBNull for total price
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

    '----------------------------------------------------------------------------------------------------------------------------------

    Private Sub TextBox10_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox10.KeyDown
        ' Check if the user pressed the Enter key
        If e.KeyCode = Keys.Enter Then
            ' Get the item code from the TextBox
            Dim itemCode As String = TextBox10.Text.Trim()

            ' If TextBox10 is empty, clear other controls
            If String.IsNullOrWhiteSpace(itemCode) Then
                TextBox11.Clear()
                ComboBox1.SelectedIndex = -1
                ComboBox2.SelectedIndex = -1
                TextBox13.Clear()
            Else
                ' Proceed to load product data if item code is entered
                LoadProductData(itemCode)
            End If
        End If
    End Sub

    Private Sub LoadProductData(itemCode As String)
        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Query to retrieve product data based on itemCode
            Dim query As String = "SELECT item_description, item_type, item_size, item_current_price FROM tbl_products WHERE item_code = @itemCode"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@itemCode", itemCode)

                ' Execute the query and read the results
                Dim dr As MySqlDataReader = cmd.ExecuteReader()

                ' If data is found, populate the textboxes and comboboxes
                If dr.HasRows Then
                    dr.Read() ' Read the first row
                    TextBox11.Text = dr("item_description").ToString() ' itemName
                    ComboBox1.Text = dr("item_type").ToString() ' itemType
                    ComboBox2.Text = dr("item_size").ToString() ' size
                    TextBox13.Text = dr("item_current_price").ToString() ' itemPrice

                Else
                    ' If no data is found, clear the fields
                    TextBox11.Clear()
                    ComboBox1.SelectedIndex = -1
                    ComboBox2.SelectedIndex = -1
                    TextBox13.Clear()
                    MessageBox.Show("Item code not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    '----------------------------------------------------------------------------------------------------------------------------
    'CLEAR BUTTON
    Private Sub RoundedButton4_Click(sender As Object, e As EventArgs) Handles RoundedButton4.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
    End Sub

    '------------------------------------------------------------------------------------------------------------------------------
    'UPDATE BUTTON
    Private Sub RoundedButton2_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        ' Retrieve values from the form controls (OrderForm)
        Dim firstName As String = TextBox1.Text.Trim()
        Dim middleName As String = TextBox2.Text.Trim()
        Dim lastName As String = TextBox5.Text.Trim()
        Dim suffix As String = TextBox6.Text.Trim()
        Dim address As String = TextBox7.Text.Trim()
        Dim phoneNumber As String = TextBox8.Text.Trim()
        Dim emailAddress As String = TextBox9.Text.Trim()
        Dim itemCode As String = TextBox10.Text.Trim()
        Dim itemName As String = TextBox11.Text.Trim()
        Dim itemType As String = ComboBox1.Text.Trim()
        Dim size As String = ComboBox2.Text.Trim()
        Dim stockQuantity As Integer
        Dim itemPrice As Decimal

        ' Validate fields
        If String.IsNullOrWhiteSpace(firstName) OrElse
           String.IsNullOrWhiteSpace(lastName) OrElse
           String.IsNullOrWhiteSpace(itemCode) OrElse
           String.IsNullOrWhiteSpace(itemName) OrElse
           String.IsNullOrWhiteSpace(itemType) OrElse
           String.IsNullOrWhiteSpace(size) OrElse
           Not Integer.TryParse(TextBox12.Text.Trim(), stockQuantity) OrElse
           stockQuantity <= 0 OrElse
           Not Decimal.TryParse(TextBox13.Text.Trim(), itemPrice) OrElse
           itemPrice <= 0 Then

            MessageBox.Show("Please fill all required fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            ' Open the database connection if it's not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Retrieve original data for the selected item_code
            Dim queryCheck As String = "SELECT item_description, item_type, item_size, stock_quantity, item_current_price 
                                    FROM tbl_products 
                                    WHERE item_code = @itemCode"
            Dim originalData As New MySqlCommand(queryCheck, conn)
            originalData.Parameters.AddWithValue("@itemCode", itemCode)
            Dim reader As MySqlDataReader = originalData.ExecuteReader()

            If reader.Read() Then
                ' Compare current form values with the original values in the database
                If reader("item_description").ToString() = itemName AndAlso
                   reader("item_type").ToString() = itemType AndAlso
                   reader("item_size").ToString() = size AndAlso
                   reader("stock_quantity").ToString() = stockQuantity.ToString() AndAlso
                   reader("item_current_price").ToString() = itemPrice.ToString() Then

                    ' If no changes detected, prompt the user and exit
                    MessageBox.Show("No changes detected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    reader.Close()
                    Return
                End If
            End If

            reader.Close()

            ' Update item_old_price with the current price, and then update the current price
            Dim queryUpdate As String = "UPDATE tbl_products 
                                     SET item_old_price = item_current_price, 
                                         item_description = @itemName, 
                                         item_type = @itemType, 
                                         item_size = @itemSize, 
                                         stock_quantity = @stockQuantity, 
                                         item_current_price = @itemPrice 
                                     WHERE item_code = @itemCode"

            ' Use a prepared statement to prevent SQL injection
            Using ps As New MySqlCommand(queryUpdate, conn)
                ps.Parameters.AddWithValue("@itemCode", itemCode)
                ps.Parameters.AddWithValue("@itemName", itemName)
                ps.Parameters.AddWithValue("@itemType", itemType)
                ps.Parameters.AddWithValue("@itemSize", size)
                ps.Parameters.AddWithValue("@stockQuantity", stockQuantity)
                ps.Parameters.AddWithValue("@itemPrice", itemPrice)

                Dim rowsAffected As Integer = ps.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Product updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Refresh DataGridView to show the updated data
                    OrderLoadData()
                Else
                    MessageBox.Show("No changes were made to the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    '-------------------------------------------------------------------------------------------------------------------
    'REMOVE BUTTON

    Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Get the selected row and its itemCode (or relevant unique identifier)
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim itemCode As String = selectedRow.Cells(7).Value.ToString() ' Assuming itemCode is in column 7

            ' Confirm the deletion action
            Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If confirmation = DialogResult.Yes Then
                Try
                    ' Open the database connection if it's not open
                    If conn.State <> ConnectionState.Open Then
                        conn.Open()
                    End If

                    ' Prepare the DELETE query
                    Dim queryDelete As String = "DELETE FROM tbl_products WHERE item_code = @itemCode"
                    Using deleteCommand As New MySqlCommand(queryDelete, conn)
                        deleteCommand.Parameters.AddWithValue("@itemCode", itemCode)

                        ' Execute the DELETE query
                        Dim rowsAffected As Integer = deleteCommand.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Refresh DataGridView to show updated data
                            OrderLoadData() ' This function reloads data from the database to the DataGridView
                        Else
                            MessageBox.Show("Item deletion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                End Try
            End If
        Else
            MessageBox.Show("Please select an item to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
