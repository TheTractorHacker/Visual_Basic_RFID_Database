Imports System.Xml

Public Class ResetPassword
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Get the new password from the textbox
        Dim newPassword As String = txtNewPassword.Text
        Dim RePassword As String = txtRePass.Text
        Dim filePath As String = "C:\Users\" & Environment.UserName & "\AppData\Roaming\RFID Attend App\credentials.xml"

        If RePassword = newPassword Then
            Dim result As DialogResult
            result = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Try

                    ' Encrypt the new password
                    Dim encryptedPassword As String = EncryptionHelper.Encrypt(newPassword)

                    ' Load the XML file
                    Dim doc As New XmlDocument()
                    doc.Load(filePath)



                    ' Find the Password node and update its value
                    Dim passwordNode As XmlNode = doc.SelectSingleNode("/Credentials/User/Password")
                    If passwordNode IsNot Nothing Then
                        passwordNode.InnerText = encryptedPassword
                    Else
                        ' If the Password node is not found, create it
                        Dim userNode As XmlNode = doc.SelectSingleNode("/Credentials/User")
                        If userNode IsNot Nothing Then
                            passwordNode = doc.CreateElement("Password")
                            passwordNode.InnerText = encryptedPassword
                            userNode.AppendChild(passwordNode)
                        End If
                    End If

                    ' Save the changes to the XML file
                    doc.Save(filePath)

                    ' Notify the user that the password has been reset
                    MessageBox.Show("Password has been reset successfully!", "Password Change", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message)
                End Try

                Me.Close()
                Main.Show()
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Operation Canceled!", "Pass Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNewPassword.Clear() : txtRePass.Clear()
                txtNewPassword.PasswordChar = ControlChars.NullChar : txtRePass.PasswordChar = ControlChars.NullChar
                txtNewPassword.Text = "New Password" : txtRePass.Text = "Re-Enter Pass"
            End If

        Else
            MessageBox.Show("Passwords Don't Match! " & Environment.NewLine & "Please Re-Enter Password", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)

            txtNewPassword.Clear() : txtRePass.Clear()
            txtNewPassword.PasswordChar = ControlChars.NullChar : txtRePass.PasswordChar = ControlChars.NullChar
            txtNewPassword.Text = "New Password" : txtRePass.Text = "Re-Enter Pass"
        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()
        Main.Show()
    End Sub

    Private Sub txtNewPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewPassword.KeyPress
        txtNewPassword.PasswordChar = "*"c
    End Sub

    Private Sub txtRePass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRePass.KeyPress
        txtRePass.PasswordChar = "*"c
    End Sub

    Private Sub txtNewPassword_MouseHover(sender As Object, e As EventArgs) Handles txtNewPassword.MouseHover
        txtNewPassword.PasswordChar = ""
    End Sub

    Private Sub txtNewPassword_MouseLeave(sender As Object, e As EventArgs) Handles txtNewPassword.MouseLeave
        txtRePass.PasswordChar = "*"c
    End Sub

    Private Sub txtPassword_MouseHover(sender As Object, e As EventArgs) Handles txtRePass.MouseHover
        txtRePass.PasswordChar = ""
    End Sub

    Private Sub NewPassword_MouseLeave(sender As Object, e As EventArgs) Handles txtRePass.MouseLeave
        txtRePass.PasswordChar = "*"c
    End Sub
End Class
