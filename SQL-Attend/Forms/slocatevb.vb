Public Class slocatevb
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtip.Text = "" Then

        Else
            My.Settings.serverip = txtip.Text
        End If

        If txtUser.Text = "" Then

        Else
            My.Settings.serveruser = txtUser.Text
        End If

        If txtPass.Text = "" Then

        Else
            My.Settings.serverpass = txtPass.Text
        End If

        If txtData.Text = "" Then

        Else
            My.Settings.serverdata = txtData.Text
        End If

        My.Settings.Save()

        MessageBox.Show("SQL Server Settings have been saved!", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim ina As DialogResult = MessageBox.Show("Would you like to restart application to apply settings?", "App Retstart", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If ina = DialogResult.Yes Then
            Application.Restart()

        ElseIf ina = DialogResult.No Then
            Me.Close()
        End If
    End Sub

    Private Sub slocatevb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblIP.Text = "Server IP: " & My.Settings.serverip
        lblUser.Text = "Username: " & My.Settings.serveruser
        lblData.Text = "Database: " & My.Settings.serverdata
        lblPass.Text = "Password: " & My.Settings.serverpass
    End Sub
End Class