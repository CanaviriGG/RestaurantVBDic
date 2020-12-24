Imports System.Data.SqlClient

Public Class Eleccion_Servidor_o_remoto
    Dim indicador_de_conexion As String
    Sub comprobar_existencia_de_empresa()
        Try
            Dim da = New SqlCommand("select * from Empresa", conexion)
            abrir()
            indicador_de_conexion = da.ExecuteScalar()
            Cerrar()
            indicador_de_conexion = "CONECTADO"
        Catch ex As Exception
            indicador_de_conexion = "NO CONECTADO"
        End Try
    End Sub
    Private Sub Eleccion_Servidor_o_remoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comprobar_existencia_de_empresa()
        comprobar_conexion()
        Centrar_paneles()
    End Sub
    Sub comprobar_conexion()
        If indicador_de_conexion = "CONECTADO" Then
            Dispose()
            REGISTRO_DE_EMPRESA.ShowDialog()
        End If
    End Sub

    Sub Centrar_paneles()
        Panel4.Location = New Point((Width - Panel4.Width) / 2, (Height - Panel4.Height) / 2)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
        Instalacion_del_servidorSQL.ShowDialog()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dispose()
        Conexion_caja_secundaria.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class