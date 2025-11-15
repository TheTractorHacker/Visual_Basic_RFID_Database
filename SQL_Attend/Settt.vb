Public Class Settt
    Private Sub btnLocate_Click(sender As Object, e As EventArgs) Handles btnLocate.Click
        Me.Close()
        Locate.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
        ResetPassword.Show()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Regi.Show()
        Me.Close()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        chgUser.Show()
        Me.Close()
    End Sub

    Private Sub rmStudent_Click(sender As Object, e As EventArgs) Handles rmStudent.Click
        Remov_Stud.Show()
        Me.Close()
    End Sub
End Class