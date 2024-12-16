Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private loginAttempts As Integer = 0
    Private Const MaxAttempts As Integer = 3

    ' Load event for the form
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    ' Decrypts an encrypted password using AES
    Private Function DecryptPassword(ByVal encryptedPassword As String) As String
        Try
            Dim key As String = "EncryptionKey123?" ' Same key as encryption
            Dim aes As Aes = Aes.Create()
            Dim keyBytes As Byte() = Encoding.UTF8.GetBytes(key.PadRight(32)) ' Ensure key is 32 bytes
            aes.Key = keyBytes
            aes.Mode = CipherMode.CBC
            aes.Padding = PaddingMode.PKCS7

            Dim encryptedBytes As Byte() = Convert.FromBase64String(encryptedPassword)
            Dim iv As Byte() = encryptedBytes.Take(16).ToArray() ' Extract IV
            Dim cipherText As Byte() = encryptedBytes.Skip(16).ToArray() ' Extract cipher text
            aes.IV = iv

            Using decryptor As ICryptoTransform = aes.CreateDecryptor(aes.Key, aes.IV)
                Dim decryptedBytes As Byte() = decryptor.TransformFinalBlock(cipherText, 0, cipherText.Length)
                Return Encoding.UTF8.GetString(decryptedBytes)
            End Using
        Catch ex As Exception
            MsgBox("Decryption error: " & ex.Message, vbExclamation)
            Return String.Empty
        End Try
    End Function

    '-------------------------------------------------------------------------------------------------------------------------

    Public Property LoggedInEmployeeId As String

    Private Sub RoundedButton1_Click_1(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        Dim employee_id = TextBox1.Text.Trim()
        Dim password = TextBox2.Text.Trim()

        If String.IsNullOrWhiteSpace(employee_id) OrElse String.IsNullOrWhiteSpace(password) Then
            MsgBox("All fields are required", vbExclamation)
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' Query to retrieve password and employee_lname for the given employee_id
            Using cmd As New MySqlCommand("SELECT upassword, employee_lname FROM tbl_user WHERE employee_id = @empid", conn)
                cmd.Parameters.AddWithValue("@empid", employee_id)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    ' Read the data from the database
                    reader.Read()
                    Dim storedPassword As String = reader("upassword").ToString()
                    Dim employee_lname As String = reader("employee_lname").ToString()

                    ' Close the reader before executing the update
                    reader.Close()

                    ' Decrypt the stored password (if encrypted) and compare it with the entered password
                    Dim decryptedPassword = DecryptPassword(storedPassword)

                    If password = decryptedPassword Then
                        MsgBox("Logged In Successfully", vbInformation)
                        Me.LoggedInEmployeeId = employee_id ' Store the employee_id of the logged-in user
                        loginAttempts = 0
                        Hide()  ' Hide LoginForm
                        MenuForm.Show()  ' Show MenuForm
                        CheckIfDataExists()

                        ' Pass the employee_lname to MenuForm and set Label3
                        MenuForm.Label3.Text = "Logged in as: " & employee_lname

                        ' Call the function to update the last_login_time in the database
                        UpdateLoginTime(employee_id)

                    Else
                        HandleFailedLogin()  ' Handle failed login
                    End If
                Else
                    MsgBox("Incorrect Credentials.", vbExclamation)
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbExclamation)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Function to update the last_login_time for the user in the database
    Private Sub UpdateLoginTime(employee_id As String)
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' Update the last_login_time field with the current time for the logged-in user
            Using cmd As New MySqlCommand("UPDATE tbl_user SET user_time_in = NOW() WHERE employee_id = @empid", conn)
                cmd.Parameters.AddWithValue("@empid", employee_id)
                cmd.ExecuteNonQuery()  ' Execute the update query
            End Using
        Catch ex As Exception
            MsgBox("Error updating login time: " & ex.Message, vbExclamation)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub





    '----------------------------------------------------------------------------------------------------------------------------


    ' Handle failed login attempts
    Private Sub HandleFailedLogin()
        loginAttempts += 1
        MsgBox("Incorrect Credentials.", vbExclamation)
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox1.Focus()

        If loginAttempts >= MaxAttempts Then
            MsgBox("Maximum login attempts reached.", vbExclamation)
            Close()
        End If
    End Sub

    ' Check if data exists in inventory
    Private Sub CheckIfDataExists()
        Try
            Dim inventoryForm As New InventoryForm()

            If Not DataExistsInDatabase() OrElse inventoryForm.DataGridView1.Rows.Count = 3 Then
                MsgBox("Stocks are low", vbExclamation)
                If MessageBox.Show("Proceed to Inventory?", "Notification", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    ' Load InventoryForm into the panel in MenuForm
                    LoadFormInPanel(MenuForm.Panel4, inventoryForm)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbExclamation)
        End Try
    End Sub

    ' Helper method to load a form into a panel
    Private Sub LoadFormInPanel(panel As Panel, form As Form)
        panel.Controls.Clear() ' Clear any existing controls
        form.TopLevel = False
        form.Dock = DockStyle.Fill
        panel.Controls.Add(form)
        form.Show()
    End Sub

    ' Check if records exist in the database
    Private Function DataExistsInDatabase() As Boolean
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Using cmd As New MySqlCommand("SELECT COUNT(*) FROM tbl_products", conn)
                Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbExclamation)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Private Sub lblregister_Click(sender As Object, e As EventArgs) Handles lblregister.Click
        registerform.Show()
    End Sub

End Class
