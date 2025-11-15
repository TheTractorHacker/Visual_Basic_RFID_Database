Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop.Excel

Public Class Remov_Stud
    Private tagID As String
    Private userName As String
    Private tNumber As String
    Private selected As String = ""

    Private Sub rbTagID_CheckedChanged(sender As Object, e As EventArgs) Handles rbTagID.CheckedChanged
        If rbTagID.Checked Then
            tagID = txtSum.Text.ToString()
            selected = tagID
        End If
    End Sub

    Private Sub rbUserName_CheckedChanged(sender As Object, e As EventArgs) Handles rbUsername.CheckedChanged
        If rbUsername.Checked Then
            userName = txtSum.Text.ToString()
            selected = userName
        End If
    End Sub

    Private Sub rbTNumber_CheckedChanged(sender As Object, e As EventArgs) Handles rbTNumber.CheckedChanged
        If rbTNumber.Checked Then
            tNumber = txtSum.Text.ToString()
            selected = tNumber
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If String.IsNullOrEmpty(tagID) AndAlso String.IsNullOrEmpty(userName) AndAlso String.IsNullOrEmpty(tNumber) Then
            MessageBox.Show("No value selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit if no value is selected
        End If

        Dim oExcel As Application = Nothing
        Dim oBook As Workbook = Nothing
        Dim oSheet As Worksheet = Nothing

        Try
            Dim Efile As String = "C:\Users\" & Environment.UserName & "\AppData\Roaming\RFID Attend App\Database.xlsx"
            oExcel = New Application()
            oBook = oExcel.Workbooks.Open(Efile)
            oSheet = CType(oBook.Worksheets(1), Worksheet)

            ' Variables to hold the search criteria
            Dim tagIDToRemove As String = tagID
            Dim userNameToRemove As String = userName
            Dim tNumberToRemove As String = "T-" & tNumber

            ' Find the Tag ID, User Name, or T-number in the range A2:C22
            Dim cellToRemove As Range = oSheet.Range("A2:A22").Find(What:=tagIDToRemove, LookIn:=XlFindLookIn.xlValues)
            If cellToRemove Is Nothing Then
                cellToRemove = oSheet.Range("B2:B22").Find(What:=userNameToRemove, LookIn:=XlFindLookIn.xlValues)
            End If
            If cellToRemove Is Nothing Then
                cellToRemove = oSheet.Range("C2:C22").Find(What:=tNumberToRemove, LookIn:=XlFindLookIn.xlValues)
            End If

            If cellToRemove IsNot Nothing Then
                ' Clear the row containing the found entry
                oSheet.Rows(cellToRemove.Row).ClearContents()

                ' Save changes to the Excel file
                oBook.Save()

                ' Display success message
                MessageBox.Show($"Student {selected} removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                ' Display error message if the entry was not found
                MessageBox.Show("User not found in the Excel file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            ' Handle any errors that occur during the process
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Ensure that Excel objects are properly disposed of
            If oBook IsNot Nothing Then oBook.Close(False)
            If oExcel IsNot Nothing Then oExcel.Quit()
            If oSheet IsNot Nothing Then Marshal.ReleaseComObject(oSheet)
            If oBook IsNot Nothing Then Marshal.ReleaseComObject(oBook)
            If oExcel IsNot Nothing Then Marshal.ReleaseComObject(oExcel)
        End Try
    End Sub

    Private Sub btnCancle_Click(sender As Object, e As EventArgs) Handles btnCancle.Click
        Me.Close()
    End Sub
End Class
