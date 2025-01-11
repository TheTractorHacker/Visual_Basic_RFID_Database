Imports System.IO
Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop

Public Class Database
    Private WithEvents datamine As DataGridView
    Private dataTable As DataTable
    Private MainInstance As Main

    Public Sub New(Main As Main)
        InitializeComponent()
        MainInstance = Main
        InitializeDataTable()
        BindData()
    End Sub

    Public Sub New(dt As DataTable)
        InitializeComponent()
        Me.dataTable = dt
        BindData()
    End Sub

    Private Sub BindData()
        ' Initialize datamine if not already initialized
        If datamine Is Nothing Then
            datamine = New DataGridView()
            datamine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            datamine.Dock = DockStyle.Fill
            Me.Controls.Add(datamine)
        End If

        ' Bind the DataTable to the DataGridView
        datamine.DataSource = dataTable
    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToExcelToolStripMenuItem.Click
        ' Define the base folder path
        Dim folderPath As String = "C:\Users\" & Environment.UserName & "\AppData\Roaming\RFID Attend App\Database.xlsx"
        Dim classes As String = InputBox("Please Enter Current Class!!", "Class Attendance")

        ' Initialize SaveFileDialog
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.InitialDirectory = folderPath
        saveFileDialog.Filter = "Excel Files|*.xlsx"
        saveFileDialog.Title = "Save Attendance File"
        saveFileDialog.FileName = $"{classes}_Attendance_{DateTime.Now.ToString("MM_dd_yyyy")}.xlsx"

        ' Show the SaveFileDialog and get user input
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName

            ' Check if the folder path exists; if not, create it
            Dim selectedFolderPath As String = Path.GetDirectoryName(filePath)
            If Not Directory.Exists(selectedFolderPath) Then
                Directory.CreateDirectory(selectedFolderPath)
            End If

            ' Delete rows without a timestamp
            RemoveRowsWithoutTimestamp()

            ' Create Excel application and workbook
            Dim excelApp As Excel.Application = Nothing
            Dim workbook As Excel.Workbook = Nothing
            Dim worksheet As Excel.Worksheet = Nothing

            Try
                excelApp = New Excel.Application()
                workbook = excelApp.Workbooks.Add()
                worksheet = CType(workbook.Sheets(1), Excel.Worksheet)

                ' Add column headers
                For col As Integer = 0 To dataTable.Columns.Count - 1
                    worksheet.Cells(1, col + 1) = dataTable.Columns(col).ColumnName
                Next

                ' Add rows
                For row As Integer = 0 To dataTable.Rows.Count - 1
                    For col As Integer = 0 To dataTable.Columns.Count - 1
                        worksheet.Cells(row + 2, col + 1) = dataTable.Rows(row)(col)
                    Next
                Next

                ' Save the Excel file
                workbook.SaveAs(filePath)
                MessageBox.Show($"Data exported to Excel successfully. File saved at {filePath}", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error exporting to Excel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clean up Excel resources
                ReleaseObject(worksheet)
                If workbook IsNot Nothing Then
                    workbook.Close(False)
                    ReleaseObject(workbook)
                End If
                If excelApp IsNot Nothing Then
                    excelApp.Quit()
                    ReleaseObject(excelApp)
                End If
            End Try
        End If
    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            If obj IsNot Nothing Then
                Marshal.ReleaseComObject(obj)
                obj = Nothing
            End If
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub RemoveRowsWithoutTimestamp()
        ' Collect rows without a timestamp
        Dim rowsToDelete As New List(Of DataRow)()

        For Each row As DataRow In dataTable.Rows
            If row.IsNull("Timestamp") Then
                rowsToDelete.Add(row)
            End If
        Next

        ' Delete collected rows
        For Each row As DataRow In rowsToDelete
            dataTable.Rows.Remove(row)
        Next
    End Sub

    Public Sub UpdateTable(dt As DataTable)
        ' Update the DataTable
        Me.dataTable = dt
        ' Rebind data to DataGridView
        BindData()
    End Sub

    Private Sub ClearDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearDatabaseToolStripMenuItem.Click
        ' Clear the DataTable
        dataTable.Clear()
        ' Update the DataGridView
        BindData()
    End Sub

    Private Sub AddToDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToDatabaseToolStripMenuItem.Click
        Regi.Show()
    End Sub

    Private Sub HomeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem1.Click
        Me.Close()
        Main.Show()
        Main.Focus()
        Main.txtTag.Focus()
    End Sub

    Private Sub ReloadToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        InitDataTable.InitializeDataTable() ' Call method on Main instance
    End Sub

    Private Sub Database_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.Hide()
        Me.Focus()
    End Sub
End Class