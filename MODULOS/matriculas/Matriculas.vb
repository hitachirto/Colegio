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

        ElseIf txtbuscar.Text <> "" Then
            lblBUSQUEDA.Visible = False
            datalistadoalumnos.Visible = True

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

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        SERIALIZACION.ShowDialog()
    End Sub
End Class