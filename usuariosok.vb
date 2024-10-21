Imports System.Data.SqlClient
Public Class usuariosok
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub usuariosok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel4.Visible = False
        MOSTRAR()


    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel4.Visible = True

    End Sub

    Private Sub GUARDARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GUARDARToolStripMenuItem.Click

        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_usuario", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Nombres", txtNOMBRE.Text)
            cmd.Parameters.AddWithValue("@Login", txtLogin.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            cmd.ExecuteNonQuery()
            cerrar()
            MOSTRAR()
            Panel4.Visible = False


        Catch ex As Exception : MsgBox(ex.Message)

        End Try


    End Sub
    Sub MOSTRAR()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_usuario", conexion)
            da.Fill(dt)
            datalistado.DataSource = dt
            cerrar()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        Try
            Panel4.Visible = True
            GUARDARToolStripMenuItem.Visible = False
            GUARDARCAMBIOSToolStripMenuItem.Visible = True
            txtNOMBRE.Text = datalistado.SelectedCells.Item(1).Value
            txtLogin.Text = datalistado.SelectedCells.Item(2).Value
            txtPassword.Text = datalistado.SelectedCells.Item(3).Value
            Lblidusuario.Text = datalistado.SelectedCells.Item(0).Value


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Lblidusuario.Click

    End Sub

    Private Sub GUARDARCAMBIOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GUARDARCAMBIOSToolStripMenuItem.Click
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("editar_usuario", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idusuario", Lblidusuario.Text)
            cmd.Parameters.AddWithValue("@Nombres", txtNOMBRE.Text)
            cmd.Parameters.AddWithValue("@Login", txtLogin.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            cmd.ExecuteNonQuery()
            cerrar()
            MOSTRAR()
            Panel4.Visible = False


        Catch ex As Exception : MsgBox(ex.Message)

        End Try
    End Sub
End Class