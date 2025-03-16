Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class Matriculas
    Dim idAlumno As Integer
    Dim idGrado As Integer
    Dim LocacionPanelMatriculasX As Integer
    Dim LocacionPanelMatriculasy As Integer
    Dim TamañoPanelMatriculasX As Integer
    Dim TamañoPanelMatriculasy As Integer

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoalumnos.CellContentClick

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Matriculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LocacionPanelMatriculasX = PanelMATRICULAS.Location.X
        LocacionPanelMatriculasy = PanelMATRICULAS.Location.Y
        TamañoPanelMatriculasX = PanelMATRICULAS.Width
        TamañoPanelMatriculasy = PanelMATRICULAS.Height
        mostrar_Tipo_de_documentos_para_insertar_en_MATRICULAS()
        datalistadoalumnos.Size = New Point(PanelMATRICULAS.Width, PanelMATRICULAS.Height)
        datalistadoalumnos.Location = New Point(LocacionPanelMatriculasX, LocacionPanelMatriculasy)

        PanelPrincipal.Location = New Point((Width - PanelPrincipal.Width) / 2, (Height - PanelPrincipal.Height) / 2)

    End Sub
    Sub mostrar_Tipo_de_documentos_para_insertar_en_MATRICULAS()
        Dim dtComprobante As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_Tipo_de_documentos_para_insertar_en_MATRICULAS", conexion)
            da.Fill(dtComprobante)
            TXTCOMPROBANTE.DisplayMember = "COMPROBANTE"
            TXTCOMPROBANTE.ValueMember = "Id_serializacion"
            TXTCOMPROBANTE.DataSource = dtComprobante
            cerrar()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TXTCOMPROBANTE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXTCOMPROBANTE.SelectedIndexChanged
        mostrar_numero_de_recibo()
    End Sub
    Sub mostrar_numero_de_recibo()
        Buscar_Tipo_de_documentos_para_insertar_en_MATRICULAS()
        Try
            TXTNUMERODERECIBO.Text = datalistadoNumero_de_recibo.SelectedCells.Item(5).Value
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub Buscar_Tipo_de_documentos_para_insertar_en_MATRICULAS()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("Buscar_Tipo_de_documentos_para_insertar_en_MATRICULAS", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Tipo_de_comprobante", TXTCOMPROBANTE.Text)
            da.Fill(dt)
            datalistadoNumero_de_recibo.DataSource = dt
            cerrar()
            TXTNUMERODERECIBO.Text = dt.Rows(0)(4).ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        If txtbuscar.Text = "" Then
            lblBUSQUEDA.Visible = True
            datalistadoalumnos.Visible = True
            datalistadoalumnos.Size = New Point(PanelMATRICULAS.Width, PanelMATRICULAS.Height)
            datalistadoalumnos.Location = New Point(PanelMATRICULAS.Location.X, PanelMATRICULAS.Location.Y)
        ElseIf txtbuscar.Text <> "" Then
            lblBUSQUEDA.Visible = False
            datalistadoalumnos.Visible = True
            datalistadoalumnos.Size = New Point(PanelMATRICULAS.Width, PanelMATRICULAS.Height)
            datalistadoalumnos.Location = New Point(PanelMATRICULAS.Location.X, PanelMATRICULAS.Location.Y)

            buscar_alumnos()
        End If
    End Sub
    Sub buscar_alumnos()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter


        Try
            abrir()
            da = New SqlDataAdapter("buscar_alumnos", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", txtbuscar.Text)
            da.Fill(dt)
            datalistadoalumnos.DataSource = dt
            datalistadoalumnos.Columns(0).Visible = False
            datalistadoalumnos.Columns(1).Visible = False
            datalistadoalumnos.Columns(2).Visible = False
            datalistadoalumnos.Columns(3).Visible = False
            datalistadoalumnos.Columns(4).Width = datalistadoalumnos.Width
            datalistadoalumnos.Columns(5).Visible = False
            datalistadoalumnos.Columns(6).Visible = False


        Catch ex As Exception

        End Try

    End Sub

    Private Sub datalistadoalumnos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoalumnos.CellClick
        Try
            idAlumno = datalistadoalumnos.SelectedCells.Item(1).Value
            txtbuscar.Text = datalistadoalumnos.SelectedCells.Item(4).Value
            datalistadoalumnos.Visible = False
            CargarGRADOS()
            mostrar_SECCIONES()
            mostrar_HORARIOS()
            mostrar_COSTO_MATRICULA()
            mostrar_Precio_de_PENSION()
            mostrar_MATRICULAS_YA_HECHAS()
            PanelMATRICULAS.Visible = True
            PanelOBSERVACION.Visible = False
            PanelMAtricula_ya_hecha.Visible = False

        Catch ex As Exception

        End Try
    End Sub


    Sub mostrar_MATRICULAS_YA_HECHAS()
        Dim importe As Double
        Dim com As New SqlCommand("mostrar_MATRICULAS_YA_HECHAS", conexion)
        com.CommandType = 4
        com.Parameters.AddWithValue("@Grado", TXTGRADO.Text)
        com.Parameters.AddWithValue("@Id_alumno", idAlumno)
        Try
            abrir()
            importe = com.ExecuteScalar()
            cerrar()
            idGrado = importe

        Catch ex As Exception

        End Try
    End Sub
    Sub mostrar_Precio_de_PENSION()
        Dim importe As Double
        Dim com As New SqlCommand("mostrar_Precio_de_PENSION", conexion)
        com.CommandType = 4
        com.Parameters.AddWithValue("@Grado", TXTGRADO.Text)
        Try
            abrir()
            importe = com.ExecuteScalar()
            cerrar()
            TXTCOSTO_PENSION.Text = importe
        Catch ex As Exception

        End Try
    End Sub
    Sub CargarGRADOS()
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_GRADOS", conexion)
            da.Fill(dt)
            TXTGRADO.DisplayMember = "Grado"
            TXTGRADO.ValueMember = "Grado"
            TXTGRADO.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub mostrar_SECCIONES()
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_SECCIONES", conexion)
            da.Fill(dt)
            TXTSECCION.DisplayMember = "Seccion"
            TXTSECCION.ValueMember = "Seccion"
            TXTSECCION.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub mostrar_HORARIOS()
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_HORARIOS", conexion)
            da.Fill(dt)
            txthorario.DisplayMember = "Horario"
            txthorario.ValueMember = "Horario"
            txthorario.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub mostrar_COSTO_MATRICULA()
        Dim importe As Double
        Dim com As New SqlCommand("mostrar_Precio_de_MATRICULA", conexion)
        com.CommandType = 4
        com.Parameters.AddWithValue("@Grado", TXTGRADO.Text)
        Try
            abrir()
            importe = com.ExecuteScalar()
            cerrar()
            txtcosto_MATRICULA.Text = importe
        Catch ex As Exception

        End Try
    End Sub





    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        SERIALIZACION.ShowDialog()
    End Sub

    Private Sub GUARDARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GUARDARToolStripMenuItem.Click
        mostrar_MATRICULAS_YA_HECHAS()
        If idGrado = 0 Then
            Dim nCuotas As Integer
            nCuotas = TXTCANTIDAD_DE_CUOTAS.Text * 1
            Dim x As Integer

            For x = 1 To nCuotas
                Try
                    Dim cmd As New SqlCommand
                    abrir()
                    cmd = New SqlCommand("insertar_MATRICULA", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@Grado", TXTGRADO.Text)
                    cmd.Parameters.AddWithValue("@Descripcion", "PENSION" & " " & x)
                    cmd.Parameters.AddWithValue("@Fecha", DateAdd(DateInterval.Month, x, TXTFECHA.Value))
                    cmd.Parameters.AddWithValue("@N_recibo", "-")
                    cmd.Parameters.AddWithValue("@Id_alumno", idAlumno)
                    cmd.Parameters.AddWithValue("@Saldo", TXTCOSTO_PENSION.Text * 1)
                    cmd.Parameters.AddWithValue("@Estado", "DEBE")
                    cmd.Parameters.AddWithValue("@Pension", TXTCOSTO_PENSION.Text * 1)
                    cmd.Parameters.AddWithValue("@Seccion", TXTSECCION.Text)
                    cmd.Parameters.AddWithValue("@Numero_de_pension", "Pension" & " " & x)
                    cmd.Parameters.AddWithValue("@Tipo_de_Institucion", "COLEGIO CEBA")
                    cmd.Parameters.AddWithValue("@Estado_de_matricula", "-")
                    cmd.Parameters.AddWithValue("@Saldo_de_matricula", 0)
                    cmd.Parameters.AddWithValue("@Horario", txthorario.Text)
                    cmd.Parameters.AddWithValue("@Observacion", "_")
                    cmd.Parameters.AddWithValue("@Prioridad", x)
                    cmd.ExecuteNonQuery()
                    cerrar()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Next
            INSERTAR_MATRICULA()
            actualizar_serie_mas_uno()
            insertar_detalle_cobro()
        Else
            PanelMAtricula_ya_hecha.Visible = True
            PanelMAtricula_ya_hecha.Location = New Point(PanelMATRICULAS.Location.X, PanelMATRICULAS.Location.Y)
            PanelMAtricula_ya_hecha.Size = New Point(PanelMATRICULAS.Size.Width, PanelMATRICULAS.Size.Height)
            PanelMATRICULAS.Visible = False
            datalistadoalumnos.BringToFront()
        End If
    End Sub


    Sub actualizar_serie_mas_uno()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("actualizar_serializacion_mas_uno", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idserie", datalistadoNumero_de_recibo.SelectedCells.Item(4).Value)
            cmd.Parameters.AddWithValue("@numerofin", datalistadoNumero_de_recibo.SelectedCells.Item(3).Value)
            cmd.ExecuteNonQuery()
            cerrar()
        Catch ex As Exception

        End Try
    End Sub
    Sub insertar_detalle_cobro()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_DETALLE_CONTROL_DE_COBROS", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_Alumno", idAlumno)
            cmd.Parameters.AddWithValue("@Pago_realizado", txtimporte.Text)
            cmd.Parameters.AddWithValue("@Fecha_que_pago", Now())
            cmd.Parameters.AddWithValue("@Nro_comprobante", TXTNUMERODERECIBO.Text)
            cmd.Parameters.AddWithValue("@Grado", "Grado " & TXTGRADO.Text)
            cmd.Parameters.AddWithValue("@Detalle", "PAGO DE MATRICULA")
            cmd.Parameters.AddWithValue("@Id_usuario", 1)
            cmd.ExecuteNonQuery()
            cerrar()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub INSERTAR_MATRICULA()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_MATRICULA", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Grado", TXTGRADO.Text)
            cmd.Parameters.AddWithValue("@Descripcion", "MATRICULA")
            cmd.Parameters.AddWithValue("@Fecha", TXTFECHA.Value)
            cmd.Parameters.AddWithValue("@N_recibo", TXTNUMERODERECIBO.Text)
            cmd.Parameters.AddWithValue("@Id_alumno", idAlumno)
            cmd.Parameters.AddWithValue("@Saldo", txtsaldo.Text)
            cmd.Parameters.AddWithValue("@Estado", "DEBE")
            cmd.Parameters.AddWithValue("@Pension", txtcosto_MATRICULA.Text * 1)

            cmd.Parameters.AddWithValue("@Seccion", TXTSECCION.Text)
            cmd.Parameters.AddWithValue("@Numero_de_pension", "MATRICULA")
            cmd.Parameters.AddWithValue("@Tipo_de_Institucion", "COLEGIO CEBA")
            cmd.Parameters.AddWithValue("@Estado_de_matricula", "DEBE")
            cmd.Parameters.AddWithValue("@Saldo_de_matricula", txtcosto_MATRICULA.Text * 1)
            cmd.Parameters.AddWithValue("@Horario", txthorario.Text)
            cmd.Parameters.AddWithValue("@Observacion", "_")
            cmd.Parameters.AddWithValue("@Prioridad", 0)
            cmd.ExecuteNonQuery()
            cerrar()
            MessageBox.Show("Datos guardados correctamente", "Guardando", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PanelMATRICULAS.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtimporte_TextChanged(sender As Object, e As EventArgs) Handles txtimporte.TextChanged
        RemoveHandler txtsaldo.TextChanged, AddressOf txtsaldo_TextChanged

        Try
            txtsaldo.Text = txtcosto_MATRICULA.Text * 1 - txtimporte.Text * 1

        Catch ex As Exception
            txtsaldo.Text = 0
        End Try
        AddHandler txtsaldo.TextChanged, AddressOf txtsaldo_TextChanged

    End Sub

    Private Sub txtsaldo_TextChanged(sender As Object, e As EventArgs) Handles txtsaldo.TextChanged
        RemoveHandler txtimporte.TextChanged, AddressOf txtimporte_TextChanged
        Try
            txtimporte.Text = txtcosto_MATRICULA.Text * 1 - txtsaldo.Text * 1
        Catch ex As Exception
            txtimporte.Text = 0
        End Try
        AddHandler txtimporte.TextChanged, AddressOf txtimporte_TextChanged

    End Sub

    Private Sub TXTGRADO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXTGRADO.SelectedIndexChanged
        mostrar_COSTO_MATRICULA()
        mostrar_Precio_de_PENSION()
    End Sub

    Private Sub PanelMAtricula_ya_hecha_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TXTNUMERODERECIBO_TextChanged(sender As Object, e As EventArgs) Handles TXTNUMERODERECIBO.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PanelOBSERVACION.Visible = True
        PanelMATRICULAS.Visible = False
        txtObservacion.Clear()

        txtObservacion.Focus()
        PanelOBSERVACION.Location = New Point(LocacionPanelMatriculasX, LocacionPanelMatriculasy)
        PanelOBSERVACION.Size = New Point(TamañoPanelMatriculasX, TamañoPanelMatriculasy)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PanelOBSERVACION.Visible = False
        PanelMATRICULAS.Visible = True
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Try
            If txtObservacion.Text = "" Then txtObservacion.Text = "Grado gestionado en Otra Institucion"
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_MATRICULA", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Grado", TXTGRADO.Text)
            cmd.Parameters.AddWithValue("@Descripcion", "OMITIDO")
            cmd.Parameters.AddWithValue("@Fecha", TXTFECHA.Value)
            cmd.Parameters.AddWithValue("@N_recibo", "-")
            cmd.Parameters.AddWithValue("@Id_alumno", idAlumno)
            cmd.Parameters.AddWithValue("@Saldo", 0)
            cmd.Parameters.AddWithValue("@Estado", "Ninguno")
            cmd.Parameters.AddWithValue("@Pension", 0)
            cmd.Parameters.AddWithValue("@Seccion", 0)
            cmd.Parameters.AddWithValue("@Numero_de_pension", 0)
            cmd.Parameters.AddWithValue("@Tipo_de_Institucion", "-")
            cmd.Parameters.AddWithValue("@Estado_de_matricula", "-")
            cmd.Parameters.AddWithValue("@Saldo_de_matricula", 0)
            cmd.Parameters.AddWithValue("@Horario", "Ninguno")
            cmd.Parameters.AddWithValue("@Observacion", "_")
            cmd.Parameters.AddWithValue("@Prioridad", "OMITIDO")
            cmd.ExecuteNonQuery()
            cerrar()
            PanelOBSERVACION.Visible = False
            PanelMATRICULAS.Visible = False

            MessageBox.Show("Datos guardados correctamente", "Guardando", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub datalistadoNumero_de_recibo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoNumero_de_recibo.CellContentClick

    End Sub

    Private Sub PanelMATRICULAS_Paint(sender As Object, e As PaintEventArgs) Handles PanelMATRICULAS.Paint

    End Sub

    Private Sub PanelMAtricula_ya_hecha_Paint_1(sender As Object, e As PaintEventArgs) Handles PanelMAtricula_ya_hecha.Paint

    End Sub

    Private Sub PanelPrincipal_Paint(sender As Object, e As PaintEventArgs) Handles PanelPrincipal.Paint

    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Alumnos_form.ShowDialog()
    End Sub

    Private Sub Matriculas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
        MENUPRINCIPALMATRICULAS.ShowDialog()

    End Sub
End Class
