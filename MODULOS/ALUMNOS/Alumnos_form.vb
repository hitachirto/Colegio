Imports System.Data.SqlClient
Public Class Alumnos_form
    Private Sub Alumnos_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MOSTRAR()
        Panel4.Visible = False

    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Sub MOSTRAR()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_alumnos", conexion)
            da.Fill(dt)
            datalistado.DataSource = dt
            cerrar()
            Multilinea(datalistado)
            datalistado.Columns(1).Visible = False

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub GUARDARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GUARDARToolStripMenuItem.Click
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_alumnos", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Apellido_Paterno", txtapellidoPaterno.Text)
            cmd.Parameters.AddWithValue("@Apellido_Materno", txtapellidoMaterno.Text)
            cmd.Parameters.AddWithValue("@Nombres", txtnombres.Text)
            cmd.Parameters.AddWithValue("@Nro_de_documento", txtdocumento.Text)
            cmd.ExecuteNonQuery()
            cerrar()
            MOSTRAR()
            Panel4.Visible = False


        Catch ex As Exception : MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Panel4.Visible = True
        txtapellidoPaterno.Clear()
        txtapellidoMaterno.Clear()
        txtnombres.Clear()
        txtdocumento.Clear()
        GUARDARToolStripMenuItem.Visible = True
        GUARDARCAMBIOSToolStripMenuItem.Visible = False

    End Sub

    Private Sub GUARDARCAMBIOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GUARDARCAMBIOSToolStripMenuItem.Click
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("editar_ALUMNO", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Apellido_Paterno", txtapellidoPaterno.Text)
            cmd.Parameters.AddWithValue("@Apellido_Materno", txtapellidoMaterno.Text)
            cmd.Parameters.AddWithValue("@Nombres", txtnombres.Text)

            cmd.Parameters.AddWithValue("@Nro_de_documento", txtdocumento.Text)
            cmd.Parameters.AddWithValue("@idalumno", id_alumno)

            cmd.ExecuteNonQuery()
            cerrar()
            MOSTRAR()
            Panel4.Visible = False


        Catch ex As Exception : MsgBox(ex.Message)

        End Try
    End Sub
    Dim id_alumno As Integer
    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        Try
            Panel4.Visible = True
            id_alumno = datalistado.SelectedCells.Item(1).Value
            txtapellidoPaterno.Text = datalistado.SelectedCells.Item(2).Value
            txtapellidoMaterno.Text = datalistado.SelectedCells.Item(3).Value
            txtnombres.Text = datalistado.SelectedCells.Item(4).Value
            txtdocumento.Text = datalistado.SelectedCells.Item(5).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel4.Visible = False
    End Sub
End Class