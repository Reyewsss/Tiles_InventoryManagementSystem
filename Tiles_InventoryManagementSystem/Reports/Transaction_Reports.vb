
Imports MySql.Data.MySqlClient
Imports ClosedXML.Excel

Public Class Transaction_Reports
    Private Sub Transaction_Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        TransactionLoadData()
    End Sub

    Public Sub TransactionLoadData()
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
                            o.item_code, o.item_name, o.item_type, o.item_size, 
                            o.item_quantity, o.item_price, o.save_date, o.order_total_value 
                            FROM tbl_order o 
                            INNER JOIN tbl_customer c ON o.customer_id = c.customer_id"
            cmd = New MySqlCommand(query, conn)
            dr = cmd.ExecuteReader()

            ' Populate DataGridView
            While dr.Read()
                Dim customerName As String = dr("customer_name").ToString().Trim()
                DataGridView1.Rows.Add(
                customerName,
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

    '--------------------------------------------------------------------------------------------------------------------
    'EXPORT TO EXCEL

    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        Export() ' Calls the Export method when the button is clicked
    End Sub

    Private Sub Export()
        ' Check if the DataGridView has any data
        If DataGridView1.Rows.Count = 0 OrElse DataGridView1.Columns.Count = 0 Then
            MessageBox.Show("No data to export. Please add data to the grid.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Exit the method if there's no data to export
        End If

        ' Proceed with exporting data to Excel
        Using sfd As New SaveFileDialog()
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx" ' Filter for Excel file type
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    ' Create a new Excel workbook
                    Using workbook As New XLWorkbook()
                        ' Create a DataTable from the DataGridView
                        Dim dataTable As New DataTable()

                        ' Add DataGridView columns to DataTable
                        For Each column As DataGridViewColumn In DataGridView1.Columns
                            dataTable.Columns.Add(column.HeaderText)
                        Next

                        ' Add rows to DataTable
                        For Each row As DataGridViewRow In DataGridView1.Rows
                            If Not row.IsNewRow Then
                                Dim dataRow As DataRow = dataTable.NewRow()
                                For i As Integer = 0 To DataGridView1.ColumnCount - 1
                                    dataRow(i) = row.Cells(i).Value
                                Next
                                dataTable.Rows.Add(dataRow)
                            End If
                        Next

                        ' Add DataTable to the Excel worksheet
                        workbook.Worksheets.Add(dataTable, "Products")

                        ' Save the workbook
                        workbook.SaveAs(sfd.FileName)
                    End Using

                    ' Success message
                    MessageBox.Show("You have successfully exported your data to an Excel file.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    ' Error message for exporting to Excel
                    MessageBox.Show("Error: " & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

End Class
