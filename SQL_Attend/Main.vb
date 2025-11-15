Imports System.IO
Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel

Public Class Main
    Private dataTable As Data.DataTable
    Public databaseForm As Database

    Private oExcel As Excel.Application
    Private oBook As Excel.Workbook

    Private Epath As String

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeDataTable()
        ClassList()
    End Sub

    Private Sub txtTag_TextChanged(sender As Object, e As EventArgs) Handles txtTag.TextChanged
        ' Event handler for processing RFID tags or T-Numbers entered in txtTag TextBox
        Dim trimmedTag As String = txtTag.Text.Trim()

        ' Check if the trimmed tag length is valid for processing
        If (trimmedTag.Length = 10) Or (txtTag.Text.Contains("T") AndAlso trimmedTag.Length = 9) Then
            ProcessRFIDTag(trimmedTag)
            txtTag.Clear() ' Clear the textbox after processing each tag
        End If
    End Sub

    Private Sub ProcessRFIDTag(tag As String)
        ' Process the RFID tag or T-Number: check if it exists, update or add to DataTable, and update Database form
        Dim name As String = VerifyTagID(tag)
        Dim timestamp As DateTime = DateTime.Now

        If name <> "Unknown" Then
            UpdateRecord(tag, name, timestamp)
            MessageBox.Show($"Name found: {name}", "Tag Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PBox.Image = My.Resources.No_Verified
            AcceptS()
        Else
            MessageBox.Show("Error: Name not found for this tag.", "Tag Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PBox.Image = My.Resources.No_Warning
            WrongS()
        End If

        ' Remove rows without a timestamp
        RemoveRowsWithoutTimestamp()

        ' Update the database form if open
        UpdateDatabaseForm()

        ' Load data from Excel to refresh DataTable if needed
        LoadDataFromExcel()
    End Sub

    Private Function VerifyTagID(tag As String) As String
        ' Initialize the name to "Unknown"
        Dim foundName As String = "Unknown"

        ' Check if the tag exists in the DataTable in the RFIDTag or TNumber column
        Dim foundRow As DataRow = dataTable.Rows.Cast(Of DataRow)().FirstOrDefault(Function(row) row("RFIDTag").ToString() = tag)

        ' If foundRow is not Nothing, get the name from the appropriate column
        If foundRow IsNot Nothing Then
            foundName = foundRow("Name").ToString()
        Else
            ' If RFIDTag is not found, check the TNumber column with the expected format
            Dim TRow As DataRow = dataTable.Rows.Cast(Of DataRow)().FirstOrDefault(Function(row) row("TNumber").ToString() = tag)

            ' If TRow is not Nothing, get the name from TNumber column
            If TRow IsNot Nothing Then
                foundName = TRow("Name").ToString()
            End If
        End If

        Return foundName
    End Function

    Private Sub UpdateRecord(tag As String, name As String, timestamp As DateTime)
        ' Update or add new record to the DataTable
        Dim existingRow As DataRow = dataTable.Rows.Cast(Of DataRow)().FirstOrDefault(Function(row) row("RFIDTag").ToString() = tag OrElse row("TNumber").ToString() = tag)

        If existingRow IsNot Nothing Then
            existingRow("Timestamp") = timestamp
        Else
            Dim newRow As DataRow = dataTable.NewRow()
            newRow("ID") = dataTable.Rows.Count + 1
            newRow("RFIDTag") = If(tag.Length = 10, tag, DBNull.Value)
            newRow("TNumber") = If(tag.Contains("T-") AndAlso tag.Length = 11, tag, DBNull.Value)
            newRow("Name") = name
            newRow("Timestamp") = timestamp
            dataTable.Rows.Add(newRow)
        End If
    End Sub

    Private Sub AddNewRecord(rfidTag As String, timestamp As DateTime)
        ' Add new record to the DataTable
        Dim newRow As DataRow = dataTable.NewRow()
        newRow("ID") = dataTable.Rows.Count + 1
        newRow("RFIDTag") = rfidTag
        newRow("Name") = "Unknown"
        newRow("Timestamp") = timestamp
        dataTable.Rows.Add(newRow)
    End Sub



    Public Sub ShowDatabase()
        Dim db As New Database(Me) ' Pass reference to this Main instance
        db.Show()
    End Sub

    Public Sub LoadDataFromExcel()
        ' Load initial data from Excel into the DataTable
        Dim excelFile As String = "C:\Users\" & Environment.UserName & "\AppData\Roaming\RFID Attend App\Database.xlsx"

        Try
            oExcel = New Excel.Application()
            oBook = oExcel.Workbooks.Open(excelFile)

            Dim oSheet As Excel.Worksheet = DirectCast(oBook.Sheets(1), Excel.Worksheet)
            Dim range As Excel.Range = oSheet.UsedRange

            For row As Integer = 2 To range.Rows.Count
                Dim rfidTag As String = CStr(oSheet.Cells(row, 1).Value)
                Dim name As String = CStr(oSheet.Cells(row, 2).Value)
                Dim Tnumber As String = CStr(oSheet.Cells(row, 3).Value)

                ' Add initial data without timestamp to DataTable
                dataTable.Rows.Add(row - 1, rfidTag, name, Tnumber)
            Next

        Catch ex As Exception
            MessageBox.Show("Error accessing Excel file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Release Excel resources
            If oBook IsNot Nothing Then
                oBook.Close(False)
                Marshal.ReleaseComObject(oBook)
                oBook = Nothing
            End If

            If oExcel IsNot Nothing Then
                oExcel.Quit()
                Marshal.ReleaseComObject(oExcel)
                oExcel = Nothing
            End If
        End Try
    End Sub

    Public Sub InitializeDataTable()
        ' Initialize the DataTable
        dataTable = New Data.DataTable("RFIDData")
        dataTable.Columns.Add("ID", GetType(Integer))
        dataTable.Columns.Add("RFIDTag", GetType(String))
        dataTable.Columns.Add("Name", GetType(String))
        dataTable.Columns.Add("TNumber", GetType(String))
        dataTable.Columns.Add("Timestamp", GetType(DateTime))

        ' Load data from Excel
        LoadDataFromExcel()
    End Sub

    Private Sub RemoveRowsWithoutTimestamp()
        ' Remove rows from DataTable where Timestamp is DBNull
        Dim rowsToDelete As New List(Of DataRow)()

        For Each row As DataRow In dataTable.Rows
            If row.IsNull("Timestamp") Then
                rowsToDelete.Add(row)
            End If
        Next

        For Each row As DataRow In rowsToDelete
            dataTable.Rows.Remove(row)
        Next
    End Sub

    Private Sub UpdateDatabaseForm()
        ' Update the Database form with the current DataTable
        If databaseForm IsNot Nothing AndAlso Not databaseForm.IsDisposed Then
            databaseForm.UpdateTable(dataTable)
        End If
    End Sub

    Private Sub MainClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Close Excel application and release resources
        If oBook IsNot Nothing Then
            oBook.Close(False)
            Marshal.ReleaseComObject(oBook)
            oBook = Nothing
        End If

        If oExcel IsNot Nothing Then
            oExcel.Quit()
            Marshal.ReleaseComObject(oExcel)
            oExcel = Nothing
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        PBox.Image = My.Resources.No_Tap
    End Sub


    Private Sub PasswordRToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ResetPassword.Show()
    End Sub

    Private Sub btnDa_Click(sender As Object, e As EventArgs) Handles btnDa.Click
        Me.Hide()
        If databaseForm Is Nothing OrElse databaseForm.IsDisposed Then
            databaseForm = New Database(dataTable)
        End If
        databaseForm.Show()
        Login.Show()
    End Sub

    Private Sub btnRel_Click(sender As Object, e As EventArgs) Handles btnRel.Click
        InitializeDataTable()
        PBox.Image = My.Resources.No_Tap
        cbClass.SelectedIndex = -1
        txtTag.Focus()
        ClassList()

    End Sub

    Private Sub Cool_Click(sender As Object, e As EventArgs) Handles Cool.Click
        End
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Settt.Show()
    End Sub

    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTag.Clear()
        txtTag.Focus()
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Confirm if the user really wants to close the application
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then
            ' Cancel the closing event
            e.Cancel = True
        Else
            ' Perform cleanup actions before closing the form
            If oBook IsNot Nothing Then
                oBook.Close(False)
                Marshal.ReleaseComObject(oBook)
                oBook = Nothing
            End If

            If oExcel IsNot Nothing Then
                oExcel.Quit()
                Marshal.ReleaseComObject(oExcel)
                oExcel = Nothing
            End If

            ' Other cleanup code if necessary
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If Not Vpathc() Then
            MsgBox("The path is not set or is incorrect. Please configure the location.")
            Dim result As DialogResult = MessageBox.Show("Would you like to configure the path now?", "Configure Path", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Open the settings dialog or form to let the user correct the path
                Locate.Show()  ' Replace with your actual settings form or dialog
            End If
        Else
            ' If Vpathc returns True, proceed with exporting to Excel
            EXPORTEXCEL()
        End If

    End Sub

    Private Sub EXPORTEXCEL()
        ' Define the base folder path
        Dim baseFolderPath As String = My.Settings.vpath

        ' Get the current class name from the user
        Dim classes As String = InputBox("Please Enter Current Class!!", "Class Attendance", cbClass.Text)

        ' Define the path for the class-specific directory
        Dim classFolderPath As String = Path.Combine(baseFolderPath, classes)

        ' Check if the class directory exists; if not, create it
        If Not Directory.Exists(classFolderPath) Then
            Directory.CreateDirectory(classFolderPath)
        End If

        ' Initialize SaveFileDialog
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.InitialDirectory = classFolderPath
        saveFileDialog.Filter = "Excel Files|*.xlsx"
        saveFileDialog.Title = "Save Attendance File"
        saveFileDialog.FileName = $"{classes}_Attendance_{DateTime.Now.ToString("MM_dd_yyyy")}.xlsx"

        ' Show the SaveFileDialog and get user input
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName

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

    Private Sub ClassList()
        ' Path to the Classes.cfg file
        Dim filePath As String = "C:\Users\" & Environment.UserName & "\AppData\Roaming\RFID Attend App\Configs\Classes.cfg"

        Epath = filePath

        ' Check if the file exists
        If System.IO.File.Exists(filePath) Then
            ' Read all lines from the file
            Dim lines() As String = System.IO.File.ReadAllLines(filePath)

            ' Add non-comment lines to the ComboBox
            cbClass.Items.Clear() ' Clear existing items
            For Each line As String In lines
                If Not String.IsNullOrWhiteSpace(line) AndAlso Not line.Trim().StartsWith("#") Then
                    cbClass.Items.Add(line.Trim())
                End If
            Next
        Else
            MessageBox.Show("Classes.cfg file not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Sub AcceptS()
        ' Play the WAV file
        My.Computer.Audio.Play(My.Resources.Success, AudioPlayMode.Background)
    End Sub

    Sub WrongS()
        ' Play the WAV file
        My.Computer.Audio.Play(My.Resources.Wrong, AudioPlayMode.Background)
    End Sub

    Private Sub ArayC()
        ' Check if the file is empty or contains only comments
        If cbClass.Items.Count = 0 Then
            Me.Show()
            ' If the file is empty or only contains comments, exit the subroutine
            Dim input As DialogResult = MessageBox.Show("The Classes.cfg file is empty or only contains comments.", "File Empty", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)

            If input = DialogResult.Yes Then
                Process.Start("notepad.exe", Epath)
            End If
            Return
        End If
    End Sub

    Private Sub cbClass_Click(sender As Object, e As EventArgs) Handles cbClass.Click
        ArayC()
    End Sub

    Function Vpathc() As Boolean
        ' Check if vpath is empty or not
        If String.IsNullOrWhiteSpace(My.Settings.vpath) Then
            Return False
        End If
        Return True
    End Function

    Private Sub btnAttend_Click(sender As Object, e As EventArgs) Handles btnAttend.Click
        Dim filepath As String = My.Settings.vpath

        Process.Start("explorer.exe", filepath)
    End Sub
End Class
