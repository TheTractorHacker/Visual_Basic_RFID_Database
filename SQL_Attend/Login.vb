Imports System.Xml

Public Class Login


    Private Function ValidateCredentials(username As String, password As String) As Boolean
        Try
            Dim doc As New XmlDocument()
            Dim filePath As String = "C:\Users\" & Environment.UserName & "\AppData\Roaming\RFID Attend App\credentials.xml"
            doc.Load(filePath)

            Dim xmlUsername As String = doc.SelectSingleNode("/Credentials/User/Username").InnerText
            Dim encryptedPassword As String = doc.SelectSingleNode("/Credentials/User/Password").InnerText
            Dim decryptedPassword As String = EncryptionHelper.Decrypt(encryptedPassword)

            Return username = xmlUsername AndAlso password = decryptedPassword
        Catch ex As Exception
            MessageBox.Show("An error occurred while reading the XML file: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.databaseForm.Hide()
    End Sub

    Private Sub Clo_Form(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Main.Show()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs)
        Main.databaseForm.Close()
        Main.Show()
        Me.Close()
    End Sub

    Private Sub txtPassword_MouseHover(sender As Object, e As EventArgs) Handles txtPassword.MouseHover
        txtPassword.PasswordChar = ""
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        txtPassword.PasswordChar = "*"c
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim username As String = txtUsername.Text
            Dim password As String = txtPassword.Text

            If ValidateCredentials(username, password) Then
                MessageBox.Show("Login successful!")

                Main.databaseForm.Show()
                Me.Close()

            Else
                MessageBox.Show("Invalid username or password.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Main.databaseForm.Close()
        Main.Show()
        Me.Close()
    End Sub

    Private Sub txtUsername_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        Focus()
        txtUsername.SelectAll()
    End Sub

    Private Sub txtPassword_Click(sender As Object, e As EventArgs) Handles txtPassword.Click
        Focus()
        txtPassword.SelectAll()
    End Sub
End Class