Imports System.Data.SqlClient


Public Class MENUPRINCIPALMATRICULAS
    Dim idalumno As Integer

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MENUPRINCIPALMATRICULAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dispose()
        Matriculas.ShowDialog()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoCURSO_GRADO.CellContentClick

    End Sub

    Private Sub lblBUSQUEDA_Click(sender As Object, e As EventArgs) Handles lblBUSQUEDA.Click
        txtbuscar.Text = ""
        txtbuscar.Focus()

    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        If txtbuscar.Text = "" Then
            lblBUSQUEDA.Visible = True
            datalistadoalumnos.Visible = False
        ElseIf txtbuscar.Text <> "" Then
            lblBUSQUEDA.Visible = False
            datalistadoalumnos.Visible = True
            buscar_alumnos()

        End If
    End Sub
    Sub buscar_alumnos()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("buscar_alumnos_por_nombre", conexion)
        Try
            abrir()
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", txtbuscar.Text)
            da.Fill(dt)
            datalistadoalumnos.DataSource = dt
            datalistadoalumnos.Columns(1).Visible = False
            datalistadoalumnos.Columns(2).Width = datalistadoalumnos.Width

            cerrar()

        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Private Sub datalistadoalumnos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoalumnos.CellContentClick

    End Sub

    Private Sub datalistadoalumnos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoalumnos.CellClick
        Try
            idalumno = datalistadoalumnos.SelectedCells.Item(1).Value
            txtbuscar.Text = datalistadoalumnos.SelectedCells.Item(2).Value


        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
        MOSTRAR_MATRICULAS_POR_GRADO_Y_ALUMNO()
    End Sub
    Sub MOSTRAR_MATRICULAS_POR_GRADO_Y_ALUMNO()

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("MOSTRAR_MATRICULAS_POR_GRADO_Y_ALUMNO", conexion)
        Try
            abrir()
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@idalumno", idalumno)
            da.Fill(dt)
            datalistadoCURSO_GRADO.DataSource = dt
            datalistadoCURSO_GRADO.Columns(1).Visible = False
            datalistadoCURSO_GRADO.Columns(3).Visible = False
            datalistadoCURSO_GRADO.Columns(4).Visible = False
            datalistadoCURSO_GRADO.Columns(5).Visible = False
            datalistadoCURSO_GRADO.Columns(2).Width = 340
            Multilinea(datalistadoCURSO_GRADO)
            cerrar()

        Catch ex As Exception

        End Try
    End Sub
End Class