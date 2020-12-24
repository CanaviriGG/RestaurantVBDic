Imports System.Data.SqlClient
Public Class Salones
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        insertar_Salon()

    End Sub
    Sub insertar_Salon()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_Salon", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Salon", txtSalonedicion.Text)
            cmd.Parameters.AddWithValue("@Estado", "ACTIVO")

            cmd.ExecuteNonQuery()
            Cerrar()
            Configurar_mesas_ok.dibujarSalones()
            Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dispose()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dispose()
    End Sub
End Class