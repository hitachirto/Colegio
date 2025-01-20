Imports System.Data.SqlClient
Public Class Matriculas
    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoalumnos.CellContentClick

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Matriculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class