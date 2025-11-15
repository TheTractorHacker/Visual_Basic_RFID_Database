Imports Microsoft.Office.Interop.Excel

Public Class Regi

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object
        Dim newTagID As String = txtTag.Text
        Dim userName As String
        Dim Efile As Object

        Efile = "C:\Users\" & Environment.UserName & "\AppData\Roaming\RFID Attend App\Database.xlsx"

        oExcel = CreateObject("Excel.Application")
        oBook = oExcel.Workbooks.Open(Efile)

        ' Workbook and Cell data
        oSheet = oBook.Worksheets(1)

        ' Check if the new tag ID already exists in the range A2:A22
        Dim existingCell As Range = oSheet.Range("A2:A22").Find(What:=newTagID, LookIn:=XlFindLookIn.xlValues)

        If existingCell IsNot Nothing Then
            ' Tag ID already exists, show error message
            MessageBox.Show($"Tag ID '{newTagID}' already exists in the Excel file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Find the first empty cell in the range A2:A22
            Dim emptyCell As Range = oSheet.Range("A2:A22").Find(What:="", LookIn:=XlFindLookIn.xlValues)

            If emptyCell IsNot Nothing Then
                ' Get the user name from txtName
                userName = txtFirst.Text & " " & txtLast.Text

                ' Update the empty cell in column A with the new tag ID
                emptyCell.Value = newTagID

                ' Update the corresponding cell in column B with the user name
                oSheet.Cells(emptyCell.Row, 2).Value = userName

                ' Update the corresponding cell in column B with the user name
                oSheet.Cells(emptyCell.Row, 3).Value = txtTnum.Text

                ' Save changes to the Excel file
                oBook.Save()

                oBook.Close()
                oExcel.Quit()

                ' Display success message
                MessageBox.Show($"User Added - Tag ID: {newTagID}, Name: {userName}", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If tsMulti.Checked = True Then
                    MessageBox.Show("You haved enabled multi-user add!", "Multi-Add", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else

                    Me.Close()

                End If


            End If
        End If


    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub txtTag_TextChanged(sender As Object, e As EventArgs) Handles txtTag.GotFocus
        txtTag.SelectAll()
    End Sub
End Class