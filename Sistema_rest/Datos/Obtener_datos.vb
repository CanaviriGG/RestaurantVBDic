Imports System.Data.SqlClient
Module Obtener_datos
    Dim serialPc As String

    Sub Obtener_idusurio_por_sesion(ByRef idusuario As Integer)
        Obtener_serialPc(serialPc)
        Try
            abrir()
            Dim com = New SqlCommand("mostrar_inicio_De_sesion", conexion)
            com.CommandType = 4
            com.Parameters.AddWithValue("@id_serial_pc", serialPc)
            idusuario = com.ExecuteScalar()
            Cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Obtener_id_caja_PorSerial(ByRef idcaja As Integer)
        Obtener_serialPc(serialPc)
        Try
            abrir()
            Dim com = New SqlCommand("mostrar_id_caja_por_serial", conexion)
            com.CommandType = 4
            com.Parameters.AddWithValue("@Serial", serialPc)
            idcaja = com.ExecuteScalar()
            Cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
