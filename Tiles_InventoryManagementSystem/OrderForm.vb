Imports System.Transactions
Imports MySql.Data.MySqlClient

Public Class OrderForm
    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        OrderLoadData()

        DataGridView1.ReadOnly = True ' Initially, DataGridView is read-only
        DataGridView1.AllowUserToAddRows = False
        RoundedButton2.Enabled = False
        RoundedButton1.Enabled = True
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Ensure the clicked row is not the header row
        If e.RowIndex >= 0 Then
            ' Get the clicked row using e.RowIndex
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Retrieve the full customer name using column index
            Dim fullName As String = selectedRow.Cells(0).Value?.ToString() ' Change 0 to the correct column index for the name

            ' Split the full name into parts
            Dim nameParts As String() = fullName?.Split(" "c)

            ' Initialize variables for name components
            Dim firstName As String = ""
            Dim middleName As String = ""
            Dim lastName As String = ""
            Dim suffix As String = ""

            ' Assign values based on the number of parts
            If nameParts IsNot Nothing Then
                If nameParts.Length > 0 Then firstName = nameParts(0) ' First name
                If nameParts.Length > 2 Then
                    middleName = String.Join(" ", nameParts.Skip(1).Take(nameParts.Length - 2)) ' Middle name(s)
                End If
                If nameParts.Length > 1 Then lastName = nameParts(nameParts.Length - 1) ' Last name
                If nameParts.Length > 3 AndAlso IsSuffix(lastName) Then
                    suffix = lastName
                    lastName = nameParts(nameParts.Length - 2) ' Adjust last name if suffix exists
                End If
            End If

            ' Populate the textboxes for customer name components
            TextBox1.Text = firstName
            TextBox2.Text = middleName
            TextBox5.Text = lastName
            TextBox6.Text = suffix

            ' Retrieve and assign additional data to other controls
            TextBox7.Text = selectedRow.Cells(1).Value?.ToString() ' Address

            TextBox8.Text = selectedRow.Cells(2).Value?.ToString() ' Item Code
            TextBox9.Text = selectedRow.Cells(3).Value?.ToString() ' Item Description
            TextBox10.Text = selectedRow.Cells(4).Value?.ToString() ' Item Code
            TextBox11.Text = selectedRow.Cells(5).Value?.ToString() ' Item Description
            ComboBox1.SelectedItem = selectedRow.Cells(6).Value?.ToString() ' Item type
            ComboBox2.SelectedItem = selectedRow.Cells(7).Value?.ToString() ' Item Size
            TextBox12.Text = selectedRow.Cells(8).Value?.ToString() ' Stock Quantity
            TextBox13.Text = selectedRow.Cells(9).Value?.ToString() ' Price

            ' Assign DateTime to DateTimePicker
            If DateTime.TryParse(selectedRow.Cells(9).Value?.ToString(), Nothing) Then
                DateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells(9).Value)
            End If
        End If

        If e.RowIndex >= 0 Then
            RoundedButton2.Enabled = True ' Enable the Update button
            RoundedButton1.Enabled = False ' Disable the Add button
        End If
    End Sub

    ' Function to determine if a name part is a suffix
    Private Function IsSuffix(part As String) As Boolean
        Dim suffixes As String() = {"Jr.", "Sr.", "II", "III", "IV"} ' Add more suffixes if needed
        Return suffixes.Contains(part, StringComparer.OrdinalIgnoreCase)
    End Function


    '----------------------------------------------------------------------------------------------------
    'SAVE BUTTON
    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        ' Retrieve form values
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
        If String.IsNullOrWhiteSpace(firstName) OrElse
       String.IsNullOrWhiteSpace(lastName) OrElse
       String.IsNullOrWhiteSpace(itemCode) OrElse
       String.IsNullOrWhiteSpace(itemName) OrElse
       Not Integer.TryParse(TextBox12.Text.Trim(), quantity) OrElse quantity <= 0 OrElse
       Not Decimal.TryParse(TextBox13.Text.Trim(), price) OrElse price <= 0 Then
            MessageBox.Show("Please fill all required fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate phone number
        If Not phoneNumber.StartsWith("+63") OrElse phoneNumber.Length <> 13 OrElse Not IsNumeric(phoneNumber.Substring(3)) Then
            MessageBox.Show("Please enter a valid phone number starting with +63 and followed by 10 digits.", "Phone Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate email address
        If Not emailAddress.ToLower().EndsWith("@gmail.com") OrElse Not emailAddress.Contains("@") Then
            MessageBox.Show("Please enter a valid email address in the format @gmail.com.", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Calculate total price
        Dim totalPrice As Decimal = quantity * price

        ' Transaction logic for saving order
        Dim transaction As MySqlTransaction = Nothing

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            transaction = conn.BeginTransaction()

            ' Insert customer and retrieve customer_id
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

                cmdCustomer.ExecuteNonQuery()
                customerId = Convert.ToInt32(cmdCustomer.LastInsertedId)
            End Using

            ' Ensure customerId is valid
            If customerId = 0 Then
                Throw New Exception("Failed to retrieve customer ID.")
            End If

            ' Save order details
            Dim queryOrder As String = "INSERT INTO tbl_order (customer_id, item_code, item_name, item_type, item_size, item_quantity, item_price, save_date, order_total_value) " &
                                    "VALUES (@customerId, @itemCode, @itemName, @type, @size, @quantity, @price, @dateAdded, @totalPrice)"
            Using cmdOrder As New MySqlCommand(queryOrder, conn, transaction)
                cmdOrder.Parameters.AddWithValue("@customerId", customerId)
                cmdOrder.Parameters.AddWithValue("@itemCode", itemCode)
                cmdOrder.Parameters.AddWithValue("@itemName", itemName)
                cmdOrder.Parameters.AddWithValue("@type", itemType)
                cmdOrder.Parameters.AddWithValue("@size", size)
                cmdOrder.Parameters.AddWithValue("@quantity", quantity)
                cmdOrder.Parameters.AddWithValue("@price", price)
                cmdOrder.Parameters.AddWithValue("@dateAdded", dateAdded)
                cmdOrder.Parameters.AddWithValue("@totalPrice", totalPrice)

                cmdOrder.ExecuteNonQuery()
            End Using

            ' Commit transaction
            transaction.Commit()

            ' Refresh DataGridView
            OrderLoadData()

            MessageBox.Show("Order saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            If transaction IsNot Nothing Then
                transaction.Rollback()
            End If
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
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

            ' Correct customer name concatenation in the SQL query
            Dim query As String = "SELECT CONCAT(c.customer_fname, ' ', 
                            IFNULL(c.customer_mname, ''), ' ', 
                            c.customer_lname, ' ', 
                            IFNULL(c.customer_suffix, '')) AS customer_name, 
                            c.customer_address, c.customer_phone, c.customer_email, 
                            o.item_code, o.item_name, o.item_type, o.item_size, 
                            o.item_quantity, o.item_price, o.save_date, o.order_total_value 
                            FROM tbl_order o 
                            INNER JOIN tbl_customer c ON o.customer_id = c.customer_id"
            cmd = New MySqlCommand(query, conn)
            dr = cmd.ExecuteReader()

            ' Check if data is available
            If Not dr.HasRows Then
                MessageBox.Show("No data found.", "Data Check", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' Populate DataGridView
            While dr.Read()
                Dim customerName As String = dr("customer_name").ToString().Trim()
                DataGridView1.Rows.Add(
                customerName,
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
                If(IsDBNull(dr("order_total_value")), 0D, Convert.ToDecimal(dr("order_total_value")))
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

                    ' Set TextBox11 and TextBox13 to ReadOnly
                    TextBox11.ReadOnly = True
                    TextBox13.ReadOnly = True

                    ' Optionally, disable user interaction further
                    TextBox11.Enabled = False
                    TextBox13.Enabled = False

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

        RoundedButton2.Enabled = False ' Enable the Update button
        RoundedButton1.Enabled = True ' Disable the Add button

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

            ' Query to retrieve product data based on itemCode
            Dim queryCheck As String = "SELECT item_type, item_size, item_quantity
                              FROM tbl_order
                              WHERE item_code = @itemCode"
            Dim originalData As New MySqlCommand(queryCheck, conn)
            originalData.Parameters.AddWithValue("@itemCode", itemCode)
            Dim reader As MySqlDataReader = originalData.ExecuteReader()

            If reader.Read() Then
                ' Compare current form values with the original values in the database
                If reader("item_type").ToString() = itemType AndAlso
               reader("item_size").ToString() = size AndAlso
               reader("item_quantity").ToString() = stockQuantity.ToString() Then

                    ' Set TextBox11 and TextBox13 as read-only and disable user interaction
                    TextBox11.ReadOnly = True
                    TextBox13.ReadOnly = True

                    ' Optionally, disable user interaction further (if required)
                    TextBox11.Enabled = False
                    TextBox13.Enabled = False

                    ' If no changes detected, prompt the user and exit
                    MessageBox.Show("No changes detected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    reader.Close()
                    Return
                End If
            End If

            reader.Close()

            ' Update item_old_price with the current price, and then update the current price in tbl_order
            Dim queryUpdateOrder As String = "UPDATE tbl_order 
                                          SET item_type = @itemType, 
                                              item_size = @itemSize, 
                                              item_quantity = @stockQuantity
                                          WHERE item_code = @itemCode"

            ' Insert or update the customer data in tbl_customer
            Dim queryUpdateCustomer As String = "INSERT INTO tbl_customer (customer_fname, customer_mname, customer_lname, customer_suffix, customer_address, customer_phone, customer_email, customer_name)
                                             VALUES (@firstName, @middleName, @lastName, @suffix, @address, @phoneNumber, @emailAddress, @customerName)"

            ' Concatenate full name for the customer_name
            Dim fullName As String = firstName & " " & middleName & " " & lastName & " " & suffix

            ' Use a prepared statement to prevent SQL injection
            Using ps As New MySqlCommand(queryUpdateOrder, conn)
                ps.Parameters.AddWithValue("@itemCode", itemCode)
                ps.Parameters.AddWithValue("@itemName", itemName)
                ps.Parameters.AddWithValue("@itemType", itemType)
                ps.Parameters.AddWithValue("@itemSize", size)
                ps.Parameters.AddWithValue("@stockQuantity", stockQuantity)
                ps.Parameters.AddWithValue("@itemPrice", itemPrice)

                Dim rowsAffected As Integer = ps.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    ' Insert/update the customer details
                    Using customerCmd As New MySqlCommand(queryUpdateCustomer, conn)
                        customerCmd.Parameters.AddWithValue("@firstName", firstName)
                        customerCmd.Parameters.AddWithValue("@middleName", middleName)
                        customerCmd.Parameters.AddWithValue("@lastName", lastName)
                        customerCmd.Parameters.AddWithValue("@suffix", suffix)
                        customerCmd.Parameters.AddWithValue("@address", address)
                        customerCmd.Parameters.AddWithValue("@phoneNumber", phoneNumber)
                        customerCmd.Parameters.AddWithValue("@emailAddress", emailAddress)
                        customerCmd.Parameters.AddWithValue("@customerName", fullName)

                        ' Execute the customer update query
                        customerCmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Order and customer details updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Refresh DataGridView to show the updated data
                    OrderLoadData()
                Else
                    MessageBox.Show("No changes were made to the order data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        ' Ensure that a row is selected in the DataGridView
        If DataGridView1.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a row to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the item_code from the selected row (assuming item_code is in column 5, adjust as needed)
        Dim selectedRow As DataGridViewRow = DataGridView1.CurrentRow
        Dim itemname As String = selectedRow.Cells(5).Value.ToString() ' Assuming itemCode is in column 5
        Dim customername As String = selectedRow.Cells(0).Value.ToString() ' Assuming customer_name is in column 

        ' Confirm deletion
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Return
        End If

        Try
            ' Open the database connection if it's not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Start a transaction to ensure both deletes are executed together
            Using transaction As MySqlTransaction = conn.BeginTransaction()
                ' Prepare the DELETE query for tbl_order
                Dim queryDeleteOrder As String = "DELETE FROM tbl_order WHERE item_name = @itemname"
                Using deleteOrderCommand As New MySqlCommand(queryDeleteOrder, conn)
                    deleteOrderCommand.Parameters.AddWithValue("@@itemname", itemname)
                    deleteOrderCommand.Transaction = transaction
                    Dim rowsAffectedOrder As Integer = deleteOrderCommand.ExecuteNonQuery()

                End Using

                ' Prepare the DELETE query for tbl_customer
                Dim queryDeleteCustomer As String = "DELETE FROM tbl_customer WHERE customer_name = @customername"
                Using deleteCustomerCommand As New MySqlCommand(queryDeleteCustomer, conn)
                    deleteCustomerCommand.Parameters.AddWithValue("@customername", customername)
                    deleteCustomerCommand.Transaction = transaction
                    Dim rowsAffectedCustomer As Integer = deleteCustomerCommand.ExecuteNonQuery()
                End Using

                ' Commit the transaction
                transaction.Commit()

                ' Show success message
                MessageBox.Show("Item and customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Refresh DataGridView to show updated data
                OrderLoadData() ' This function reloads data from the database to the DataGridView
                ' Clear the form fields
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

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        ' Check if any row is selected in the DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            ' If a row is selected, disable the Save button and enable the Update button
            RoundedButton1.Enabled = False ' Disable Save button
            RoundedButton2.Enabled = True  ' Enable Update button
        Else
            ' If no row is selected, enable the Save button and disable the Update button
            RoundedButton1.Enabled = True  ' Enable Save button
            RoundedButton2.Enabled = False ' Disable Update button
        End If
    End Sub


End Class
