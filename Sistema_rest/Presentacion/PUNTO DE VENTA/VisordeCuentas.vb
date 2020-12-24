Imports System.Data.SqlClient
Public Class VisordeCuentas
    Dim idmesa As Integer
    Dim MesaV As String
    Private Sub VisordeCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarPedidos()
    End Sub
    Public Sub mostrarPedidos()
        datalistadoPedidos.Rows.Clear()
        Dim filas As Integer = 0
        Dim dtmesas As New DataTable()
        abrir()
        Dim consulta1 As New SqlDataAdapter("mostrar_cuentas_soloMesas", conexion)
        consulta1.Fill(dtmesas)
        Cerrar()

        For Each row As DataRow In dtmesas.Rows
            MesaV = row.Item("Mesa").ToString()
            idmesa = row.Item("Id_mesa").ToString()
            datalistadoPedidos.Rows.Add()
            datalistadoPedidos.Item(0, filas).Value = MesaV
            datalistadoPedidos.Item(1, filas).Value = "# Pedido"
            datalistadoPedidos.Item(2, filas).Value = "Donde consumir"
            datalistadoPedidos.Rows(filas).DefaultCellStyle.BackColor = Color.Gainsboro
            datalistadoPedidos.Rows(filas).DefaultCellStyle.Font = New Drawing.Font("Microsoft Sans Serif", 9, FontStyle.Bold)

            Dim dtpedido As New DataTable()
            Dim consulta2 As New SqlDataAdapter("mostrar_cuentas", conexion)
            consulta2.SelectCommand.CommandType = 4
            consulta2.SelectCommand.Parameters.AddWithValue("@idmesa", idmesa)
            consulta2.Fill(dtpedido)
            filas += 1
            For Each row2 As DataRow In dtpedido.Rows
                Dim idventa As String = row2.Item("idventa").ToString()
                Dim consumo As String = row2.Item("Donde_se_consumira").ToString()
                datalistadoPedidos.Rows.Add()
                datalistadoPedidos.Item(1, filas).Value = idventa
                datalistadoPedidos.Item(2, filas).Value = consumo
                filas += 1
            Next

        Next
        Multilinea(datalistadoPedidos)

    End Sub
End Class