Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop

Module InitDataTable
    Public DataTable As DataTable

    Public Sub InitializeDataTable()
        ' Initialize or load data into the DataTable
        DataTable = New DataTable("RFIDData")
        DataTable.Columns.Add("ID", GetType(Integer))
        DataTable.Columns.Add("RFIDTag", GetType(String))
        DataTable.Columns.Add("Name", GetType(String))
        DataTable.Columns.Add("T-Number", GetType(String))

        ' Load data from Excel
        LoadDataFromExcel()
    End Sub

    Private Sub LoadDataFromExcel()
        ' Load initial data from Excel into the DataTable
        Dim excelFile As String = "C:\Users\" & Environment.UserName & "\AppData\Roaming\RFID Attend App\Database.xlsx"

        Dim oExcel As Excel.Application = Nothing
        Dim oBook As Excel.Workbook = Nothing
        Dim oSheet As Excel.Worksheet = Nothing

        Try
            oExcel = New Excel.Application()
            oBook = oExcel.Workbooks.Open(excelFile)
            oSheet = CType(oBook.Sheets(1), Excel.Worksheet)

            Dim range As Excel.Range = oSheet.UsedRange
            For row As Integer = 2 To range.Rows.Count
                Dim id As Integer = row - 1
                Dim rfidTag As String = CStr(oSheet.Cells(row, 1).Value)
                Dim name As String = CStr(oSheet.Cells(row, 2).Value)
                Dim tNumber As String = CStr(oSheet.Cells(row, 3).Value)

                ' Add row to DataTable
                DataTable.Rows.Add(id, rfidTag, name, tNumber)
            Next

        Catch ex As Exception
            MessageBox.Show("Error accessing Excel file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Release Excel resources
            If oSheet IsNot Nothing Then Marshal.ReleaseComObject(oSheet)
            If oBook IsNot Nothing Then
                oBook.Close(False)
                Marshal.ReleaseComObject(oBook)
            End If
            If oExcel IsNot Nothing Then
                oExcel.Quit()
                Marshal.ReleaseComObject(oExcel)
            End If
        End Try
    End Sub
End Module

