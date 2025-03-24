Imports System.Data.SqlClient
Public Class PAGAR_PENSIONES
    Dim idalumno As Integer
    Dim grado As String
    Dim idmatricula As Integer
    Dim descripcion As String
    Private Sub PAGAR_PENSIONES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_Tipo_de_documentos_para_insertar_en_MATRICULAS()
        LBLALUMNO.Text = MENUPRINCIPALMATRICULAS.txtbuscar.Text
        idalumno = MENUPRINCIPALMATRICULAS.idalumno
        grado = MENUPRINCIPALMATRICULAS.grado
        idmatricula = MENUPRINCIPALMATRICULAS.idmatricula
        LBLDESCRIPCION.Text = MENUPRINCIPALMATRICULAS.descripcion
        LBLTOTAL.Text = MENUPRINCIPALMATRICULAS.total
        LBLADEUDADO.Text = MENUPRINCIPALMATRICULAS.saldo

    End Sub
    Sub mostrar_Tipo_de_documentos_para_insertar_en_MATRICULAS()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_Tipo_de_documentos_para_insertar_en_MATRICULAS", conexion)
            da.Fill(dt)
            TXTCOMPROBANTE.DisplayMember = "COMPROBANTE"
            TXTCOMPROBANTE.ValueMember = "id_serializacion"
            TXTCOMPROBANTE.DataSource = dt
            cerrar()

        Catch ex As Exception

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



        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        SERIALIZACION.ShowDialog()

    End Sub

    Private Sub GUARDARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GUARDARToolStripMenuItem.Click
        If LBLSALDO.Text * 1 >= TXTIMPORTE.Text * 1 Then
            insertar_DETALLE_CONTROL_DE_COBROS()
            disminuirSaldoMATRICULA()
        End If
    End Sub
    Sub actualizar_estado_de_matricula()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("actualizar_estado_de_matricula", conexion)
            cmd.ExecuteNonQuery()
            cerrar()

        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub
    Sub disminuirSaldoMATRICULA()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("disminuirSaldoMATRICULA", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_MATRICULA", idmatricula)
            cmd.Parameters.AddWithValue("@montopagado", TXTIMPORTE.Text)
            cmd.Parameters.AddWithValue("@numero_de_recibo", TXTNUMERODERECIBO.Text)
            cmd.ExecuteNonQuery()
            cerrar()


        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub
    Sub insertar_DETALLE_CONTROL_DE_COBROS()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_DETALLE_CONTROL_DE_COBROS", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idAlumno", idalumno)
            cmd.Parameters.AddWithValue("@Pago_realizado", TXTIMPORTE.Text)
            cmd.Parameters.AddWithValue("@Fecha_de_pago", TXTFECHA.Text)
            cmd.Parameters.AddWithValue("@Nro_comprobante", TXTNUMERODERECIBO.Text)
            cmd.Parameters.AddWithValue("@Grado", grado)
            cmd.Parameters.AddWithValue("@Detalle", "PAGO DE " & LBLDESCRIPCION.Text)
            cmd.Parameters.AddWithValue("@Id_usuario", 1011)
            cmd.ExecuteNonQuery()
            cerrar()


        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub
End Class