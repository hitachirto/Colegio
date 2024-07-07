Public Class LOGIN
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtlogin.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles txtlogin.Click
        txtlogin.Text = ""
        txtlogin.Focus()

    End Sub

    Private Sub txtpassword_Click(sender As Object, e As EventArgs) Handles txtpassword.Click
        txtpassword.Text = ""
        txtpassword.Focus()



    End Sub
End Class
