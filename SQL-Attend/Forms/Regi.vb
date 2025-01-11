Imports MySql.Data.MySqlClient

Public Class Regi

    Private keepOpen As Boolean = False

    Private Sub Adduser_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Retrieve user input
        Dim name As String = txtFirst.Text.Trim() & " " & txtLast.Text.Trim()
        Dim tag As String = txtTag.Text.Trim()
        Dim tnum As String = txtTnum.Text.Trim()

        ' Validate user input
        If String.IsNullOrWhiteSpace(name) OrElse String.IsNullOrWhiteSpace(tag) OrElse String.IsNullOrWhiteSpace(tnum) Then
            MessageBox.Show("Please fill in all fields before adding a user.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' SQL query with parameter placeholders
        Dim query As String = "INSERT INTO students (name, TNumber, RFID) VALUES (@name, @tnum, @tag_id);"

        ' Open MySQL connection and execute the query
        Using conn As MySqlConnection = Main.GetConnection()
            Try
                ' Prepare and execute the SQL command
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@tnum", tnum)
                    cmd.Parameters.AddWithValue("@tag_id", tag)

                    ' Execute the INSERT statement
                    cmd.ExecuteNonQuery()

                    ' Inform the user that the operation was successful
                    MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            Catch ex As MySqlException When ex.Number = 1062 ' Handle duplicate entry errors (MySQL error code 1062)
                MessageBox.Show("A user with this TNumber or RFID already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As MySqlException
                ' Handle any other MySQL-related errors
                MessageBox.Show("MySQL error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                ' Handle any other potential errors
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        ' Ask the user if they want to register for classes
        Dim regiResult As DialogResult = MessageBox.Show("Would you like to register for classes?", "Student Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If regiResult = DialogResult.Yes Then
            AddSToClass.Show()
            If Not keepOpen Then Me.Close()
        ElseIf regiResult = DialogResult.No Then
            If Not keepOpen Then Me.Close()
        End If
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub txtTag_TextChanged(sender As Object, e As EventArgs) Handles txtTag.GotFocus
        ' Automatically select all text in the txtTag textbox when focused
        txtTag.SelectAll()
    End Sub

    Private Sub tsMulti_CheckedChanged(sender As Object, e As EventArgs) Handles tsMulti.CheckedChanged
        ' Toggle the keepOpen flag based on the Multi-Add toggle switch
        keepOpen = tsMulti.Checked
    End Sub

    Private Sub btnRegi_Click(sender As Object, e As EventArgs) Handles btnRegi.Click
        ' Show the AddSToClass form, and optionally close the current form based on keepOpen
        AddSToClass.Show()
        If Not keepOpen Then Me.Close()
    End Sub
End Class
