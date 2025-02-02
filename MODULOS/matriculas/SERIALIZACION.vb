Imports System.Data.SqlClient

Public Class SERIALIZACION
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtimporte_TextChanged(sender As Object, e As EventArgs) Handles txtnumeroinicio.TextChanged

    End Sub

    Private Sub txtcosto_MATRICULA_TextChanged(sender As Object, e As EventArgs) Handles TXTCOMPRO.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtnumerofin.TextChanged

    End Sub

    Private Sub GUARDARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_Serializacion", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Serie", txtserie.Text)
            cmd.Parameters.AddWithValue("@numeroinicio", txtnumeroinicio.Text)
            cmd.Parameters.AddWithValue("@numerofin", txtnumerofin.Text)
            cmd.Parameters.AddWithValue("@Tipo_de_comprobante", TXTCOMPRO.Text)
            cmd.ExecuteNonQuery()
            cerrar()
            listar()
            Panel2.Visible = False


        Catch ex As Exception

        End Try
    End Sub
    Sub listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_Tipo_de_documentos_para_insertar_estos_mismos", conexion)
            da.Fill(dt)
            datalistado.DataSource = dt
            cerrar()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            datalistado.Columns(4).Visible = False
            datalistado.Columns(5).Width = 120
            datalistado.Columns(6).Width = 120
        Catch ex As Exception

        End Try
        Me.datalistado.EnableHeadersVisualStyles = False

        'estilo para las cabeceras
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
        styCabeceras.BackColor = Color.White
        styCabeceras.ForeColor = Color.Black
        styCabeceras.Font = New Font("Segoe UI", 10, FontStyle.Regular Or
                                     FontStyle.Bold)
        'asignar estilo al grid
        Me.datalistado.ColumnHeadersDefaultCellStyle = styCabeceras




    End Sub
    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub GUARDARCAMBIOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GUARDARCAMBIOS.Click
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("editar_serializacion", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Serie", txtserie.Text)
            cmd.Parameters.AddWithValue("@numeroinicio", txtnumeroinicio.Text)
            cmd.Parameters.AddWithValue("@numerofin", txtnumerofin.Text)
            cmd.Parameters.AddWithValue("@Tipo_de_comprobante", TXTCOMPRO.Text)
            cmd.Parameters.AddWithValue("@Id_serie", datalistado.SelectedCells.Item(4).Value)
            cmd.ExecuteNonQuery()
            cerrar()
            listar()
            Panel2.Visible = False



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Panel2.Visible = True
        GUARDAR.Visible = True
        GUARDARCAMBIOS.Visible = False
        limpìar()


    End Sub
    Sub limpìar()
        TXTCOMPRO.Clear()
        txtserie.Clear()
        txtnumerofin.Clear()
        txtnumeroinicio.Clear()


    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles VOLVEROK.Click
        Panel2.Visible = False

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim result As DialogResult
        Dim cmd As SqlCommand
        result = MessageBox.Show("¿realmente desea eliminar los registros selecionados?", "eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.SelectedRows
                    Dim onekey As Integer = Convert.ToInt32(row.Cells("Id_serializacion").Value)
                    Try
                        abrir()
                        cmd = New SqlCommand("eliminar_serializacion", conexion)
                        cmd.CommandType = 4
                        cmd.Parameters.AddWithValue("@id", onekey)

                        cmd.ExecuteNonQuery()
                    Catch ex As Exception : MsgBox(ex.Message)

                    End Try
                    cerrar()

                Next
                Call listar()

            Catch ex As Exception

            End Try
        Else
            MessageBox.Show("cancelando eliminacion de registros", "eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question
                            )
        End If
    End Sub

    Private Sub SERIALIZACION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Visible = False
        listar()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()


    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        Panel2.Visible = True
        Try
            TXTCOMPRO.Text = datalistado.SelectedCells.Item(6).Value
            txtnumeroinicio.Text = datalistado.SelectedCells.Item(2).Value
            txtnumerofin.Text = datalistado.SelectedCells.Item(3).Value
            txtserie.Text = datalistado.SelectedCells.Item(1).Value
            GUARDAR.Visible = False
            GUARDARCAMBIOS.Visible = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtnumeroinicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumeroinicio.KeyPress
        NumerosyDecimales(txtnumeroinicio, e)

    End Sub
    Public Sub NumerosyDecimales(ByVal Cajatexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        ElseIf e.KeyChar = "." And Not Cajatexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "," Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = True
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtnumerofin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumerofin.KeyPress
        NumerosyDecimales(txtnumerofin, e)

    End Sub
End Class