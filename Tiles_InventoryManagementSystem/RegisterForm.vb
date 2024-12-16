Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class RegisterForm
    ' Encrypt Password using AES (AES-256)
    Private Function EncryptPassword(ByVal password As String) As String
        Dim key As String = "EncryptionKey123?" ' Secure key (better if fetched securely)
        Dim aes As Aes = Aes.Create()
        Dim keyBytes As Byte() = Encoding.UTF8.GetBytes(key.PadRight(32)) ' Ensure key is 32 bytes for AES-256
        aes.Key = keyBytes
        aes.Mode = CipherMode.CBC
        aes.Padding = PaddingMode.PKCS7
        aes.GenerateIV()

        Using encryptor As ICryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV)
            Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim encryptedBytes As Byte() = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length)
            Dim result As Byte() = aes.IV.Concat(encryptedBytes).ToArray()
            Return Convert.ToBase64String(result)
        End Using
    End Function

    ' Register User when Register button is clicked
    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        Dim employee_fname = TextBox1.Text.Trim()
        Dim employee_mname = TextBox2.Text.Trim()
        Dim employee_lname = TextBox3.Text.Trim()
        Dim employee_suffix = TextBox4.Text.Trim()
        Dim employee_id = TextBox5.Text.Trim()
        Dim password = TextBox6.Text.Trim()
        Dim confirm_password = TextBox7.Text.Trim()

        ' Validate inputs
        If String.IsNullOrWhiteSpace(employee_id) OrElse
           String.IsNullOrWhiteSpace(password) OrElse
           String.IsNullOrWhiteSpace(confirm_password) OrElse
           String.IsNullOrWhiteSpace(employee_fname) OrElse
           String.IsNullOrWhiteSpace(employee_lname) Then
            MsgBox("All fields are required", vbExclamation)
            Return
        End If

        ' Check if the employee_id matches the required format (XX-YYYY)
        Dim idPattern As String = "^\d{2}-\d{4}$"
        If Not System.Text.RegularExpressions.Regex.IsMatch(employee_id, idPattern) Then
            MsgBox("Invalid Employee ID format. It must be in the format 'XX-YYYY'.", vbExclamation)
            Return
        End If

        ' Validate password
        If password.Length < 8 OrElse Not password.Any(Function(c) Char.IsUpper(c)) OrElse Not password.Any(Function(c) Char.IsDigit(c)) Then
            MsgBox("Password must be at least 8 characters long, include an uppercase letter, and a number.", vbExclamation)
            Return
        End If

        ' Validate confirm password
        If password <> confirm_password Then
            MsgBox("Passwords do not match", vbExclamation)
            Return
        End If

        ' Encrypt the password
        Dim encryptedPassword = EncryptPassword(password)

        Try
            ' Initialize database connection
            Using conn As New MySqlConnection("server=localhost;username=root;password=;database=db_inventorysystem")
                conn.Open()

                ' Insert the employee data into the database
                Dim query As String = "INSERT INTO tbl_user (upassword, employee_id, employee_fname, employee_mname, employee_lname, employee_suffix) 
                                   VALUES (@upass, @empid, @fname, @mname, @lname, @suffix)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@upass", encryptedPassword)
                    cmd.Parameters.AddWithValue("@empid", employee_id)
                    cmd.Parameters.AddWithValue("@fname", employee_fname)
                    cmd.Parameters.AddWithValue("@mname", If(String.IsNullOrWhiteSpace(employee_mname), DBNull.Value, employee_mname))
                    cmd.Parameters.AddWithValue("@lname", employee_lname)
                    cmd.Parameters.AddWithValue("@suffix", If(String.IsNullOrWhiteSpace(employee_suffix), DBNull.Value, employee_suffix))

                    Dim status = cmd.ExecuteNonQuery()
                    If status > 0 Then
                        MsgBox("Registered Successfully", vbInformation)
                        Me.Hide()
                    Else
                        MsgBox("Registration Unsuccessful", vbExclamation)
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MsgBox("Database error: " & ex.Message, vbExclamation)
        Catch ex As Exception
            MsgBox("Unexpected error: " & ex.Message, vbExclamation)
        End Try
    End Sub



End Class
