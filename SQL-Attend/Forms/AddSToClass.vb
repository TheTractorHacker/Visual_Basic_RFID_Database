Imports MySql.Data.MySqlClient

Public Class AddSToClass
    Private Sub AddSToClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClassNames()
    End Sub

    Private Sub LoadClassNames()
        ' Database query to fetch class names
        Using connection As MySqlConnection = Main.GetConnection()
            Dim query As String = "SELECT ClassName FROM classes"
            Using command As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    cbClass.Items.Clear()
                    While reader.Read()
                        Dim className As String = reader("ClassName").ToString()
                        cbClass.Items.Add(className)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnADDS_Click(sender As Object, e As EventArgs) Handles btnADDS.Click
        ' Ensure a student ID is provided
        If String.IsNullOrWhiteSpace(txtTNumber.Text) Then
            MessageBox.Show("Please enter a valid TNumber.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the student ID from txtTNumber
        Dim studentId As String = txtTNumber.Text.Trim()

        ' Ensure at least one class is selected
        If cbClass.CheckedItems.Count = 0 Then
            MessageBox.Show("Please select at least one class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Loop through selected items in cbClass (CheckedListBox)
        For Each selectedClass As String In cbClass.CheckedItems
            Try
                ' Find and directly use the ClassID
                Dim classId As Integer = GetClassIdByName(selectedClass)

                ' If ClassID is found, insert the enrollment record
                If classId >= 0 Then
                    AddStudentToEnrollment(studentId, classId)
                Else
                    MessageBox.Show($"Class '{selectedClass}' not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As MySqlException When ex.Number = 1062
                ' Handle duplicate enrollment error (MySQL error code 1062)
                MessageBox.Show($"Student '{studentId}' is already enrolled in '{selectedClass}'.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Catch ex As Exception
                ' Handle any other errors
                MessageBox.Show($"An error occurred while enrolling the student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Next

        MessageBox.Show("Student(s) successfully enrolled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Ask if the user wants to continue registering more students
        Dim continueResult As DialogResult = MessageBox.Show("Would you like to register more students?", "Student Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If continueResult = DialogResult.No Then
            Me.Close()
        End If
    End Sub

    ' Function to get the ClassID based on the class name, without modifying the ClassID
    Private Function GetClassIdByName(className As String) As Integer
        Dim classId As Integer = -1
        Using connection As MySqlConnection = Main.GetConnection()
            Dim query As String = "SELECT ClassID FROM classes WHERE ClassName = @ClassName"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@ClassName", className)
                Dim result = command.ExecuteScalar()
                If result IsNot Nothing Then
                    classId = Convert.ToInt32(result) ' Get the ClassID but don't change it
                End If
            End Using
        End Using
        Return classId
    End Function

    ' Function to add a student to the enrollment table using the ClassID
    Private Sub AddStudentToEnrollment(studentId As String, classId As Integer)
        Using connection As MySqlConnection = Main.GetConnection()
            Dim query As String = "INSERT INTO enrollment (TNumber, ClassID) VALUES (@StudentID, @ClassID)"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@StudentID", studentId)
                command.Parameters.AddWithValue("@ClassID", classId)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
