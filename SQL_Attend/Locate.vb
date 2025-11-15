' Import necessary namespaces at the top of your form
Imports System.IO

Public Class Locate
    Private Sub Attend_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Using folderDialog As New FolderBrowserDialog()
            ' Set the description of the dialog
            folderDialog.Description = "Select the folder you want to save"

            ' Show the dialog and check if the user pressed OK
            If folderDialog.ShowDialog() = DialogResult.OK Then
                ' Get the selected folder path
                Dim selectedPath As String = folderDialog.SelectedPath

                ' Define the full path to the Attendance directory
                Dim attendancePath As String = Path.Combine(selectedPath, "Attendance")

                ' Check if the Attendance directory exists; if not, create it
                If Not Directory.Exists(attendancePath) Then
                    Directory.CreateDirectory(attendancePath)
                End If

                ' Display the selected path in a message box (optional)
                MessageBox.Show("Selected folder: " & attendancePath)

                ' Save the selected path to My.Settings with Attendance directory
                My.Settings.vpath = attendancePath
                My.Settings.Save() ' Save the settings persistently
            End If
        End Using
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
End Class