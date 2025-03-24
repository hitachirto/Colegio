Imports System.Data.SqlClient


Public Class MENUPRINCIPALMATRICULAS
    Public idalumno As Integer
    Public grado As String
    Dim Tipo_de_pago As String
    Dim estado As String
    Dim prioridad As Integer
    Dim lblsaldoarriba As Double
    Dim estadoarriba As String
    Dim indexarriba As Integer
    Public idmatricula As Integer
    Public descripcion As String
    Public total As Double
    Public saldo As Double
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

            datalistadoalumnos.Visible = False
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

    Private Sub TPAGOS_Click(sender As Object, e As EventArgs) Handles TPAGOS.Click
        MOSTRAR_PANELES()

    End Sub
    Sub MOSTRAR_PANELES()
        PanelPAGOS.Visible = True
        PanelPAGOS.Dock = DockStyle.Fill
    End Sub


    Sub MOSTRAR_detalle_MATRICULAS_POR_GRADO_Y_ALUMNO()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("MOSTRAR_detalle_MATRICULAS_POR_GRADO_Y_ALUMNO", conexion)
        Try
            abrir()
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", grado)
            da.SelectCommand.Parameters.AddWithValue("@idalumno", idalumno)
            da.Fill(dt)
            datalistado_detalle_de_matricula.DataSource = dt
            datalistado_detalle_de_matricula.Columns(2).Visible = False
            datalistado_detalle_de_matricula.Columns(3).Width = 400
            datalistado_detalle_de_matricula.Columns(4).Visible = False
            datalistado_detalle_de_matricula.Columns(5).Visible = False
            datalistado_detalle_de_matricula.Columns(10).Visible = False
            datalistado_detalle_de_matricula.Columns(11).Visible = False
            datalistado_detalle_de_matricula.Columns(12).Visible = False
            Multilinea(datalistado_detalle_de_matricula)
            cerrar()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub datalistadoCURSO_GRADO_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoCURSO_GRADO.CellClick
        Try
            grado = datalistadoCURSO_GRADO.SelectedCells.Item(3).Value
            Tipo_de_pago = datalistadoCURSO_GRADO.SelectedCells.Item(4).Value

        Catch ex As Exception

        End Try
        If Tipo_de_pago = "MATRICULA" Then
            MOSTRAR_detalle_MATRICULAS_POR_GRADO_Y_ALUMNO()
            MOSTRAR_PANELES()
        ElseIf Tipo_de_pago = "OMITIDO" Then

        End If
    End Sub

    Private Sub datalistado_detalle_de_matricula_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado_detalle_de_matricula.CellContentClick

    End Sub

    Private Sub datalistado_detalle_de_matricula_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado_detalle_de_matricula.CellClick
        If e.ColumnIndex = datalistado_detalle_de_matricula.Columns.Item("S").Index Then
            estado = datalistado_detalle_de_matricula.SelectedCells.Item(9).Value
            prioridad = datalistado_detalle_de_matricula.SelectedCells.Item(12).Value
            idmatricula = datalistado_detalle_de_matricula.SelectedCells.Item(2).Value
            descripcion = datalistado_detalle_de_matricula.SelectedCells.Item(3).Value
            total = datalistado_detalle_de_matricula.SelectedCells.Item(6).Value
            saldo = datalistado_detalle_de_matricula.SelectedCells.Item(8).Value
            Try
                lblsaldoarriba = datalistado_detalle_de_matricula.SelectedCells.Item(8).Value
                indexarriba = datalistado_detalle_de_matricula.Rows(e.RowIndex - 1).Cells(12).Value
                estadoarriba = datalistado_detalle_de_matricula.Rows(e.RowIndex - 1).Cells(9).Value


            Catch ex As Exception

            End Try
            If prioridad = 0 And estado = "DEBE" Then
                PAGAR_PENSIONES.ShowDialog()

            End If
            If prioridad > indexarriba And estadoarriba = "CANCELADO" And lblsaldoarriba <> 0 Then
                PAGAR_PENSIONES.ShowDialog()

            End If
        End If
    End Sub
End Class