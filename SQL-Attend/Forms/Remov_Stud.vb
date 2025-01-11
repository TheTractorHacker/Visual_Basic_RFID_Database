Imports MySql.Data.MySqlClient

Public Class Remov_Stud
    Private selected As String = ""

    ' RadioButton CheckedChanged event handlers
    Private Sub rbTagID_CheckedChanged(sender As Object, e As EventArgs) Handles rbTagID.CheckedChanged
        If rbTagID.Checked Then
            selected = "RFID" ' Indicate that RFID will be used for the query
        End If
    End Sub

    Private Sub rbUserName_CheckedChanged(sender As Object, e As EventArgs) Handles rbUsername.CheckedChanged
        If rbUsername.Checked Then
            selected = "name" ' Indicate that name will be used for the query
        End If
    End Sub

    Private Sub rbTNumber_CheckedChanged(sender As Object, e As EventArgs) Handles rbTNumber.CheckedChanged
        If rbTNumber.Checked Then
            selected = "TNumber" ' Indicate that TNumber will be used for the query
        End If
    End Sub

    ' Remove button click handler
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        ' Ensure the user has selected an option and entered text
        If String.IsNullOrWhiteSpace(txtSum.Text) OrElse String.IsNullOrWhiteSpace(selected) Then
            MessageBox.Show("Please enter a value and select a search option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate input length based on selection
        Select Case selected
            Case "TNumber"
                If txtSum.Text.Trim().Length <> 9 Then
                    MessageBox.Show("TNumber must be exactly 9 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            Case "RFID"
                If txtSum.Text.Trim().Length <> 10 Then
                    MessageBox.Show("RFID must be exactly 10 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            Case "name"
                ' No length restriction for name
        End Select

        ' Get the TNumber based on the selected criteria (RFID or Name)
        Dim studentTNumber As String = GetTNumberByCriteria(selected, txtSum.Text.Trim())

        If String.IsNullOrEmpty(studentTNumber) Then
            MessageBox.Show("No matching user found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' SQL DELETE query to remove from enrollment
        Dim enrollmentQuery As String = "DELETE FROM enrollment WHERE TNumber = @TNumber;"

        ' SQL DELETE query to remove from students
        Dim studentQuery As String = "DELETE FROM students WHERE TNumber = @TNumber;"

        ' Open MySQL connection and execute the query
        Using conn As MySqlConnection = Main.GetConnection()
            Try
                ' Remove from enrollment table first
                Using cmd As New MySqlCommand(enrollmentQuery, conn)
                    cmd.Parameters.AddWithValue("@TNumber", studentTNumber) ' Use the TNumber found
                    cmd.ExecuteNonQuery()
                End Using

                ' Then remove from students table
                Using cmd As New MySqlCommand(studentQuery, conn)
                    cmd.Parameters.AddWithValue("@TNumber", studentTNumber) ' Use the TNumber found
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        ' Inform the user that the operation was successful
                        MessageBox.Show("User removed successfully!")
                    Else
                        ' Inform the user that no records were found to delete
                        MessageBox.Show("No matching user found in the students table.")
                    End If
                End Using

            Catch ex As MySqlException
                ' Handle any MySQL-related errors
                MessageBox.Show("MySQL error: " & ex.Message)
            Catch ex As Exception
                ' Handle any other potential errors
                MessageBox.Show("Error: " & ex.Message)
            Finally
                ' Ensure that the connection is closed
                If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End Using


        Dim Con As DialogResult = MessageBox.Show("Would you like to remove more student(s)?", "More Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If DialogResult.Yes Then
            txtSum.Clear()
            rbTagID.Select()
        Else
            Me.Close()
        End If

    End Sub

    ' Function to get the TNumber based on the selected criteria
    Private Function GetTNumberByCriteria(criteria As String, value As String) As String
        Dim tNumber As String = String.Empty
        Dim query As String = ""

        ' Determine the query based on the criteria
        If criteria = "RFID" Then
            query = "SELECT TNumber FROM students WHERE RFID = @value;"
        ElseIf criteria = "name" Then
            query = "SELECT TNumber FROM students WHERE name = @value;"
        End If

        ' Open MySQL connection and execute the query
        Using conn As MySqlConnection = Main.GetConnection()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@value", value)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    tNumber = result.ToString()
                End If
            End Using
        End Using

        Return tNumber
    End Function

    ' Cancel button click handler
    Private Sub btnCancle_Click(sender As Object, e As EventArgs) Handles btnCancle.Click
        Me.Close()
    End Sub
End Class
