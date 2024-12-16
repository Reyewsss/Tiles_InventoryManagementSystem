Imports ClosedXML.Excel
Imports MySql.Data.MySqlClient

Public Class Inventory_Reports
    Public Sub InventoryReportsLoadData()
        DataGridView1.Rows.Clear()

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Retrieve both old and current price
            Dim query As String = "SELECT item_code, item_description, item_type, item_size, stock_quantity, item_current_price, item_old_price FROM tbl_products"
            cmd = New MySqlCommand(query, conn)
            dr = cmd.ExecuteReader()

            ' Loop through the data reader and add rows to DataGridView
            While dr.Read()
                DataGridView1.Rows.Add(
                dr("item_code").ToString(),          ' Column 1: item_code
                dr("item_description").ToString(),   ' Column 2: item_description
                dr("item_type").ToString(),          ' Column 3: item_type
                dr("item_size").ToString(),          ' Column 4: item_size
                 dr("item_old_price").ToString(), ' Column 5: item_current_price
                 dr("item_current_price").ToString(), ' Column 6: item_current_price
                dr("stock_quantity").ToString()    ' Column 7: stock_quantity
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

    Private Sub Inventory_Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        InventoryReportsLoadData()
    End Sub

    '-------------------------------------------------------------------------------------------
    'EXPORT BUTTON
    Private Sub Export()
        ' Check if the DataGridView has any data
        If DataGridView1.Rows.Count = 0 OrElse DataGridView1.Columns.Count = 0 Then
            MessageBox.Show("No data to export. Please add data to the grid.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Exit the method if there's no data to export
        End If

        ' Proceed with exporting data to Excel
        Using sfd As New SaveFileDialog()
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx" ' Fixed the filter here
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    ' Create a new Excel workbook
                    Using workbook As New XLWorkbook()
                        ' Create a DataTable from the DataGridView (you need to add the code to copy the DataGridView data to DataTable)
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


    Private Sub RoundedButton1_Click_1(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        Export()
    End Sub
End Class