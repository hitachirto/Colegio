Imports System.Data.SqlClient
Public Class Alumnos_form
    Private Sub Alumnos_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MOSTRAR()
        Panel4.Visible = False
        txtbuscar.Text = "buscar alumnos..."


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
            If dt.Rows.Count > 0 Then

            End If

            Multilinea(datalistado)
                If datalistado.Columns.Count > 1 Then

                    datalistado.Columns(1).Visible = False
                End If


        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        For Each row As DataGridViewRow In datalistado.Rows
            If row.Cells("Estado").Value = "ELIMINADO" Then
                row.DefaultCellStyle.Font = New Font("segoe UI", 10, FontStyle.Strikeout Or FontStyle.Bold)
                row.DefaultCellStyle.ForeColor = Color.Red
            End If
        Next

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
            cmd.Parameters.AddWithValue("@Estado", "ACTIVO")
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
    Dim estado As String
    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        Try

            id_alumno = datalistado.SelectedCells.Item(1).Value
            txtapellidoPaterno.Text = datalistado.SelectedCells.Item(2).Value
            txtapellidoMaterno.Text = datalistado.SelectedCells.Item(3).Value
            txtnombres.Text = datalistado.SelectedCells.Item(4).Value
            txtdocumento.Text = datalistado.SelectedCells.Item(5).Value
            estado = datalistado.SelectedCells.Item(6).Value
            If estado = "ELIMINADO" Then
                restaurar_alumno()
            Else
                Panel4.Visible = True

            End If

        Catch ex As Exception

        End Try
    End Sub
    Sub restaurar_alumno()
        Dim result As DialogResult

        result = MessageBox.Show("este alumno se elimino ¿desea volver a habilitar?", "Restauracion de registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Dim cmd As SqlCommand
            Try
                For Each row As DataGridViewRow In datalistado.SelectedRows
                    Dim idalumnoSeleccionado As Integer = Convert.ToInt32(row.Cells("idalumno").Value)
                    Try
                        abrir()
                        cmd = New SqlCommand("Restaurar_alumno", conexion)
                        cmd.CommandType = 4
                        cmd.Parameters.AddWithValue("@idalumno", idalumnoSeleccionado)
                        cmd.ExecuteNonQuery()
                        cerrar()

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)

                    End Try
                Next

                Call MOSTRAR()

            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel4.Visible = False
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eli").Index Then
            Dim result As DialogResult
            result = MessageBox.Show("¿realmente desea eliminar a este alumno?", "Eliminando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                Dim cmd As SqlCommand
                Try
                    For Each row As DataGridViewRow In datalistado.SelectedRows
                        Dim idalumnoSeleccionado As Integer = Convert.ToInt32(row.Cells("idalumno").Value)
                        Try
                            abrir()
                            cmd = New SqlCommand("Eliminar_alumno", conexion)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@idalumno", idalumnoSeleccionado)
                            cmd.ExecuteNonQuery()
                            cerrar()

                        Catch ex As Exception
                            MessageBox.Show(ex.Message)

                        End Try
                    Next
                    Call MOSTRAR()

                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    Private Sub RestaurarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestaurarToolStripMenuItem.Click
        Try

            id_alumno = datalistado.SelectedCells.Item(1).Value
            txtapellidoPaterno.Text = datalistado.SelectedCells.Item(2).Value
            txtapellidoMaterno.Text = datalistado.SelectedCells.Item(3).Value
            txtnombres.Text = datalistado.SelectedCells.Item(4).Value
            txtdocumento.Text = datalistado.SelectedCells.Item(5).Value
            estado = datalistado.SelectedCells.Item(6).Value
            If estado = "ELIMINADO" Then
                restaurar_alumno()
            End If

        Catch ex As Exception

        End Try
    End Sub
    Sub buscar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("buscar_alumnos", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", txtbuscar.Text)

            da.Fill(dt)
            datalistado.DataSource = dt
            cerrar()

            Multilinea(datalistado)
            datalistado.Columns(1).Visible = True

        Catch ex As Exception


        End Try
        For Each row As DataGridViewRow In datalistado.Rows
            If row.Cells("Estado").Value = "ELIMINADO" Then
                row.DefaultCellStyle.Font = New Font("segoe UI", 10, FontStyle.Strikeout Or FontStyle.Bold)
                row.DefaultCellStyle.ForeColor = Color.Red
            End If
        Next


    End Sub
    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        If txtbuscar.Text <> "" And txtbuscar.Text <> "buscar alumnos..." Then

            buscar()
        Else
            MOSTRAR()

        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub txtbuscar_Click(sender As Object, e As EventArgs) Handles txtbuscar.Click

        txtbuscar.SelectAll()

    End Sub
End Class