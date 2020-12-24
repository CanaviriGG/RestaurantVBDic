Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class Agregar_mesa_ok
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtmesaedicion.Text <> "" Then
            editar_mesa()
        Else
            MessageBox.Show("Datos Incompletos", "Faltan ingresar Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If


    End Sub
    Sub editar_mesa()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("editar_mesa", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@mesa", txtmesaedicion.Text)

            cmd.Parameters.AddWithValue("@id_mesa", Configurar_mesas_ok.idmesa)

            cmd.ExecuteNonQuery()
            Cerrar()
            Configurar_mesas_ok.dibujarMESAS()

            Dispose()


        Catch ex As Exception

            MessageBox.Show(ex.Message)
            txtmesaedicion.SelectAll()
            txtmesaedicion.Focus()

        End Try
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dispose()


    End Sub

    Private Sub Agregar_mesa_ok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtmesaedicion.Text = "" Then
            BTNEliminar.Visible = False
        Else
            BTNEliminar.Visible = True
        End If

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtmesaedicion.Focus()
        Timer1.Stop()
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Dispose()
    End Sub
    Sub eliminar_mesa()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("eliminar_mesa", conexion)
            cmd.CommandType = 4


            cmd.Parameters.AddWithValue("@id_mesa", Configurar_mesas_ok.idmesa)

            cmd.ExecuteNonQuery()
            Cerrar()
            Configurar_mesas_ok.dibujarMESAS()
            Me.Dispose()



        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTNEliminar.Click
        eliminar_mesa()
    End Sub

    Private Sub Agregar_mesa_ok_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub Agregar_mesa_ok_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try

            Dispose()
        Catch ex As Exception

        End Try
    End Sub
End Class