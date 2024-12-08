Imports System.Data.Common
Imports System.Data.SqlClient
Public Class LOGIN
    Private Sub Button1_Click(sender As Object, e As EventArgs)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cargarusuarios()
        If datalistado.RowCount > 0 Then
            Dispose()
            MENUPRINCIPALMATRICULAS.ShowDialog()
        Else
            MessageBox.Show("verifique su usuario y contraseña", "control de acceso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
    Sub cargarusuarios()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("validar_usuario", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@login", txtlogin.Text)
            da.SelectCommand.Parameters.AddWithValue("@password", txtpassword.Text)
            da.Fill(dt)
            datalistado.Datasource = dt
            cerrar()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
