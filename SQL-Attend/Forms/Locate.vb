' Import necessary namespaces at the top of your form
Imports System.IO

Public Class Locate
    Private Sub Attend_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim webLocation As String = InputBox("Enter location for web GUI (e.g., http://example.com):" & vbNewLine & "Currnet webGUI: " & My.Settings.vpath, "Web Location")
        If String.IsNullOrWhiteSpace(webLocation) Then
            MessageBox.Show("No web location entered. Operation cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                ' Save the web location to My.Settings (or process it as needed)
                My.Settings.vpath = webLocation
                My.Settings.Save() ' Save the settings persistently

                ' Notify the user of success
                MessageBox.Show("Web GUI location saved: " & webLocation, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                ' Handle any errors related to saving settings
                MessageBox.Show("An error occurred while saving the web location: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Private Sub btnCla_Click(sender As Object, e As EventArgs) Handles btnCla.Click
        ' Create a new OpenFileDialog instance
        Using fileDialog As New OpenFileDialog()
            ' Set the title and filter for the dialog
            fileDialog.Title = "Select the file you want to use"
            fileDialog.Filter = "Text Files (*.txt)|*.txt" ' You can customize this filter for specific file types

            ' Show the dialog and check if the user pressed OK
            If fileDialog.ShowDialog() = DialogResult.OK Then
                ' Get the selected file path
                Dim selectedFilePath As String = fileDialog.FileName

                ' Display the selected path in a message box (optional)
                MessageBox.Show("Selected file: " & selectedFilePath)

                ' Save the selected file path to My.Settings
                My.Settings.zpath = selectedFilePath
                My.Settings.Save() ' Save the settings persistently
            End If
        End Using
    End Sub

    Private Sub SQ_Click(sender As Object, e As EventArgs) Handles btnSQ.Click
        Me.Hide()
        slocatevb.Show()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        My.Settings.vpath = ""
        My.Settings.zpath = ""
        My.Settings.serverip = ""
        My.Settings.serveruser = ""
        My.Settings.serverpass = ""
        My.Settings.serverdata = ""

        Dim rizz As DialogResult = MessageBox.Show("All location and Server settings will be RESETED!!", "Settings Reset", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

        If rizz = DialogResult.OK Then

            My.Settings.Save()

            MsgBox("All Settings WIPED!!")

        ElseIf rizz = DialogResult.Cancel Then
            MsgBox("Canceld")
        End If


    End Sub
End Class