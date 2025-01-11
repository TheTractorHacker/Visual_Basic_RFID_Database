Public Class chgUser
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        ' Path to your XML file
        Dim filePath As String = "C:\Users\" & Environment.UserName & "\AppData\Roaming\SQL-Attend\Configs\credentials.xml"

        Try
            ' Load the XML file
            Dim xDoc As XDocument = XDocument.Load(filePath)

            ' Find the Username element
            Dim usernameElement As XElement = xDoc.Descendants("Username").FirstOrDefault()

            ' If the Username element is found, update its value
            If usernameElement IsNot Nothing Then
                usernameElement.Value = txtName.Text

                ' Save the changes back to the XML file
                xDoc.Save(filePath)

                MessageBox.Show($"Username updated successfully. Name: {txtName.Text.ToString}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Close()

            Else
                MessageBox.Show("Username element not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show($"Error updating XML file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub chgUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Focus()
        txtName.SelectAll()
    End Sub
End Class