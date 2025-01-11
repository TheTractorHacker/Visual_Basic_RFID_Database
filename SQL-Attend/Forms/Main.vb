Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports System.Windows.Forms


Public Class Main
    Private dataTable As Data.DataTable
    Public databaseForm As Database

    Private Epath As String
    Private oExcel As Excel.Application
    Private oBook As Excel.Workbook

    Public timeArray As New List(Of String)

    Private scannedTags As New HashSet(Of String)()

    ' Checking if export button has been pressed
    Dim expBtn As Boolean = True

    ' Connection to SQL
    Private connectionString As String = $"Server={My.Settings.serverip};Database={My.Settings.serverdata};User Id={My.Settings.serveruser};Password={My.Settings.serverpass};"
    Public Function GetConnection() As MySqlConnection
        If String.IsNullOrWhiteSpace(My.Settings.serverip) Then
            ' Show the server location form if the server IP is not set
            slocatevb.ShowDialog() ' Use ShowDialog to halt Main.vb until resolved
        Else
            Dim connection As New MySqlConnection(connectionString)

            Try
                connection.Open()
                Return connection ' Return the connection if successful
            Catch ex As MySqlException
                ' Show error message and open server location form if connection fails
                MessageBox.Show("Error: " & ex.Message)
                slocatevb.ShowDialog() ' Use ShowDialog to halt Main.vb until resolved
                Return Nothing ' Return Nothing if connection fails
            End Try
        End If
        Return Nothing
    End Function

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtTag.Focus()

        InitializeDataTable()
        ClassList()
    End Sub

    Private Sub txtTag_TextChanged(sender As Object, e As EventArgs) Handles txtTag.TextChanged
        ' Event handler for processing RFID tags or T-Numbers entered in txtTag TextBox
        Dim trimmedTag As String = txtTag.Text.Trim()

        ' Check if the trimmed tag length is valid for processing
        If (trimmedTag.Length = 10) Or (txtTag.Text.Contains("T") AndAlso trimmedTag.Length = 9) Then

            ' Process the RFID tag
            ProcessRFIDTag(trimmedTag)

            txtTag.Clear() ' Clear the textbox after processing each tag
        End If
    End Sub

    Private Sub ProcessRFIDTag(tag As String)
        ' Process the RFID tag or T-Number
        Dim name As String = VerifyTagID(tag)
        Dim tnum As String = FindT(tag)
        Dim timestamp As DateTime = DateTime.Now

        If name <> "Unknown" Then
            AcceptS()
            PBox.Image = My.Resources.No_Verified

            ' Update the record in the DataTable for the scanned tag
            For Each row As DataRow In dataTable.Rows
                If row("RFIDTag").ToString() = tag Or row("TNumber").ToString() = tag Then
                    row("Attendance") = "P" ' Mark as present
                    row("Timestamp") = timestamp ' Set the timestamp
                    Exit For
                End If
            Next
        Else
            ' Handle unknown tag case (if necessary)
            MessageBox.Show("Error: Name not found for this tag.", "Tag Information", MessageBoxButtons.OK, MessageBoxIcon.Error)

            WrongS()
            PBox.Image = My.Resources.No_Warning
        End If
    End Sub


    Private Function VerifyTagID(tag As String) As String
        ' Initialize the name to "Unknown"
        Dim foundName As String = "Unknown"

        ' Query for students
        Dim query As String = "SELECT Name FROM students WHERE RFID = @tag_id OR TNumber = @tag_id;"

        Using conn As MySqlConnection = GetConnection()

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@tag_ID", tag)
                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot Nothing Then
                    foundName = result.ToString()
                End If
            End Using

        End Using

        Return foundName
    End Function

    Private Sub AddAbsent()
        ' Iterate through the DataTable rows
        For Each row As DataRow In dataTable.Rows
            If row.IsNull("Timestamp") Then
                ' Mark rows with a null Timestamp as absent
                row("Attendance") = "X"
            Else
                ' Mark rows with a valid Timestamp as present
                row("Attendance") = "P"
            End If
        Next
    End Sub

    Private Function FindT(tag As String) As String
        ' Initialize the name to "Unknown"
        Dim Tnum As String = "Unknown"

        ' Query for students
        Dim query As String = "SELECT TNUmber FROM students WHERE RFID = @tag_id OR TNumber = @tag_id;"

        Using conn As MySqlConnection = GetConnection()

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@tag_ID", tag)
                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot Nothing Then
                    Tnum = result.ToString()
                End If
            End Using

        End Using

        Return Tnum
    End Function

    Private Sub UpdateRecord(tag As String, name As String, timestamp As DateTime, attend As String, tnum As String)
        ' Update or add new record to the DataTable
        Dim existingRow As DataRow = dataTable.Rows.Cast(Of DataRow)().FirstOrDefault(Function(row) row("RFIDTag").ToString() = tag OrElse row("TNumber").ToString() = tag)

        If existingRow IsNot Nothing Then
            existingRow("Timestamp") = timestamp
        Else
            Dim newRow As DataRow = dataTable.NewRow()
            newRow("ID") = dataTable.Rows.Count + 1
            newRow("RFIDTag") = If(tag.Length = 10, tag, DBNull.Value)
            newRow("TNumber") = If(tag.Contains("T-") AndAlso tag.Length = 11, tag, tnum)
            newRow("Name") = name
            newRow("Attendance") = attend
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

    Public Sub InitializeDataTable()
        ' Initialize the DataTable
        dataTable = New Data.DataTable("Attend")
        dataTable.Columns.Add("ID", GetType(Integer))
        dataTable.Columns.Add("RFIDTag", GetType(String))
        dataTable.Columns.Add("Name", GetType(String))
        dataTable.Columns.Add("Attendance", GetType(String))
        dataTable.Columns.Add("TNumber", GetType(String))
        dataTable.Columns.Add("Timestamp", GetType(DateTime))

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

        ClassList()

        cbClasses.SelectedIndex = -1

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
        Export()
        expBtn = True
    End Sub

    Sub Export()
        Dim selectedClassId As Integer = cbClasses.SelectedValue ' Get the selected class ID
        SaveAttendance() ' Call the function to save attendance
        Me.Show()
        expBtn = False
    End Sub

    Private Sub ClassList()
        Using connection As MySqlConnection = GetConnection()
            Dim query As String = "SELECT StartTime, ClassName FROM classes"
            Using command As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    cbClasses.Items.Clear()
                    While reader.Read()
                        Dim className As String = reader("ClassName").ToString()
                        Dim classTime As String = reader("StartTime").ToString()
                        timeArray.Add(classTime)
                        cbClasses.Items.Add(className)
                    End While
                End Using
            End Using
        End Using
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
        If cbClasses.Items.Count = 0 Then
            Me.Show()
            ' If the file is empty or only contains comments, exit the subroutine
            Dim input As DialogResult = MessageBox.Show("The Classes.cfg file is empty or only contains comments.", "File Empty", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)

            If input = DialogResult.Yes Then
                Process.Start("notepad.exe", Epath)
            End If
            Return
        End If
    End Sub

    Private Sub cbClass_Click(sender As Object, e As EventArgs) Handles cbClasses.Click
        If cbClasses.SelectedIndex = -1 Then
            ' Inform the user to select a class first
        Else
            If Not expBtn Then
                ' Prompt user to export first
                Dim exportPrompt As DialogResult = MessageBox.Show("Would you like to export attandance?" & vbNewLine & "Yes: Exports Attendance" & vbNewLine & "No: Does Nothing", "Export Required", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

                Select Case exportPrompt
                    Case DialogResult.Yes
                        ' Perform the export
                        Export()
                        expBtn = True
                    Case DialogResult.No
                        ' Inform the user that export is required
                        MessageBox.Show("Please complete the export before proceeding.", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Case DialogResult.Cancel
                        ' User cancels, do nothing
                        MessageBox.Show("Action canceled by the user.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Select
            End If
        End If

    End Sub


    Private Sub btnAttend_Click(sender As Object, e As EventArgs) Handles btnAttend.Click
        Dim filepath As String = My.Settings.vpath ' Or My.Settings.webLocation for a web URL

        ' Check if the filepath is a valid web URL
        If filepath.StartsWith("http://") OrElse filepath.StartsWith("https://") Then
            ' Open the web page in the default browser
            Process.Start(filepath)
        Else
            ' Handle invalid or file paths
            MessageBox.Show("The stored location is not a valid web URL.", "Invalid URL", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub cbClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClasses.SelectedIndexChanged
        If expBtn = True Then
            LoadStudentsForClass()
        End If
        expBtn = False
    End Sub

    Private Sub LoadStudentsForClass()
        Dim selectedClassID As Integer = cbClasses.SelectedIndex + 1 ' Adjusted to match 1-based ClassID

        ' Clear existing data in the DataTable if necessary
        dataTable.Clear()

        Using connection As MySqlConnection = GetConnection()
            ' SQL query to get students for the selected class
            Dim query As String = "SELECT s.TNumber, s.Name, s.RFID " &
                              "FROM enrollment e " &
                              "JOIN students s ON e.TNumber = s.TNumber " &
                              "WHERE e.ClassID = @ClassID;"

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@ClassID", selectedClassID) ' Use ClassID for the parameter

                Using reader As MySqlDataReader = command.ExecuteReader()
                    Dim rowIndex As Integer = 1
                    While reader.Read()
                        Dim studentId As String = reader("TNumber").ToString()
                        Dim studentName As String = reader("Name").ToString()
                        Dim rfid As String = reader("RFID").ToString()

                        ' Add student data to the DataTable, defaulting Attendance to "X"
                        Dim newRow As DataRow = dataTable.NewRow()
                        newRow("ID") = rowIndex
                        newRow("RFIDTag") = rfid
                        newRow("Name") = studentName
                        newRow("Attendance") = "X" ' Default to "X" (absent)
                        newRow("TNumber") = studentId
                        newRow("Timestamp") = DBNull.Value ' No timestamp initially
                        dataTable.Rows.Add(newRow)

                        rowIndex += 1
                    End While
                End Using
            End Using
        End Using
    End Sub


    Private Sub SaveAttendance()
        Dim selectedClassID As Integer = cbClasses.SelectedIndex + 1 ' Adjusted for 1-based ClassID

        Using connection As MySqlConnection = GetConnection()
            Try
                ' SQL query to insert attendance data
                Dim query As String = "INSERT INTO attendance (TNumber, ClassID, Date, Status) VALUES (@TNumber, @ClassID, @Date, @Status)"

                Using command As New MySqlCommand(query, connection)
                    ' Iterate through each row in the DataTable
                    For Each row As DataRow In dataTable.Rows
                        Dim studentId As String = row("TNumber").ToString()
                        Dim attendanceStatus As String = row("Attendance").ToString() ' Ensure column name matches case

                        ' Add parameters for the query
                        command.Parameters.Clear() ' Clear parameters for each iteration
                        command.Parameters.AddWithValue("@TNumber", studentId)
                        command.Parameters.AddWithValue("@ClassID", selectedClassID)
                        command.Parameters.AddWithValue("@Date", DateTime.Now.Date) ' Current date for the attendance record
                        command.Parameters.AddWithValue("@Status", attendanceStatus) ' Attendance status

                        command.ExecuteNonQuery() ' Execute the insert command
                    Next
                End Using
            Catch ex As Exception
                ' Handle exceptions and display an error message
                MessageBox.Show("An error occurred while saving attendance: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class