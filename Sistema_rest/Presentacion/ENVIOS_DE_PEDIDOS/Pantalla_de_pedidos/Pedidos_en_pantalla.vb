Imports System.Data.SqlClient
Public Class Pedidos_en_pantalla
    Dim idventa1 As Integer
    Dim idventa2 As Integer
    Dim idventa3 As Integer
    Dim idventa4 As Integer
    Dim idventa5 As Integer
    Dim idventa6 As Integer
    Dim IddetalleVentaGeneral As Integer
    Dim idventaGeneral As Integer
    Dim cantidad_de_ventas_Pedidos_nuevos As Integer
    Dim contador_minutero As Integer
    Private Sub Pedidos_en_pantalla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_id_de_venta()
        obtener_datos()
        TimerNUEVOSPEDIDOS.Start()
    End Sub
    Sub obtener_datos()
        mostrar_detalle_venta1()
    End Sub
    Sub mostrar_detalle_venta1()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("mostrar_productos_EN_ESPERA_COCINA", conexion)
        da.SelectCommand.CommandType = 4
        da.SelectCommand.Parameters.AddWithValue("@idventa", idventa1)
        Try
            abrir()
            da.Fill(dt)
            datalistadoDetalledeventa1.DataSource = dt
            Cerrar()
            datalistadoDetalledeventa1.EnableHeadersVisualStyles = False
            datalistadoDetalledeventa1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
            styCabeceras.BackColor = Color.FromArgb(49, 49, 49)
            styCabeceras.ForeColor = Color.White
            styCabeceras.Font = New Font("Segoe UI", 10, FontStyle.Regular Or
          FontStyle.Bold)
            datalistadoDetalledeventa1.ColumnHeadersDefaultCellStyle = styCabeceras
            datalistadoDetalledeventa1.Columns(2).Visible = False
            datalistadoDetalledeventa1.Columns(3).Visible = False
            datalistadoDetalledeventa1.Columns(6).Visible = False
            datalistadoDetalledeventa1.Columns(7).Visible = False
            datalistadoDetalledeventa1.Columns(8).Visible = False
            datalistadoDetalledeventa1.Columns(9).Visible = False
            datalistadoDetalledeventa1.Columns(10).Visible = False
            datalistadoDetalledeventa1.Columns(11).Visible = False
            datalistadoDetalledeventa1.Columns(12).Visible = False
            datalistadoDetalledeventa1.Columns(13).Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try

        For Each rows As DataGridViewRow In datalistadoDetalledeventa1.Rows
            Dim estado As String = Convert.ToString(rows.Cells("Estado").Value)
            Dim hora As String = Convert.ToString(rows.Cells("Hora").Value)
            Dim Mozo As String = Convert.ToString(rows.Cells("Mozo").Value)
            Dim Mesa As String = Convert.ToString(rows.Cells("Mesa").Value)
            Dim Minutos_transcurridos As String = Convert.ToString(rows.Cells("Minutos_transcurridos").Value)
            If estado = "EN ESPERA" Then
                rows.Cells.Item(0).Value = "Preparar"
                rows.Cells(1).Value = ""
                rows.DefaultCellStyle.BackColor = Color.FromArgb(49, 49, 49)
                rows.DefaultCellStyle.SelectionBackColor = Color.FromArgb(49, 49, 49)
            ElseIf estado = "EN PREPARACION" Then
                rows.Cells.Item(0).Value = "Despachar"
                rows.Cells(1).Value = "Volver"
                rows.DefaultCellStyle.BackColor = Color.SeaGreen
                rows.DefaultCellStyle.SelectionBackColor = Color.SeaGreen
            End If
            lblmesa1.Text = Mesa
            lblMozo1.Text = Mozo
            lblfecha1.Text = hora
            lblminutos1.Text = Minutos_transcurridos
        Next
        TimerP1.Start()
    End Sub

    Sub mostrar_id_de_venta()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select idventa,ROW_NUMBER() OVER(ORDER BY idventa ASC) as Orden  from ventas where Estado='EN ESPERA'", conexion)
        Try
            abrir()
            da.Fill(dt)
            datalistadoventas.DataSource = dt
            Cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        For Each rows As DataGridViewRow In datalistadoventas.Rows
            Dim Orden As Integer = Convert.ToInt32(rows.Cells("Orden").Value)
            If Orden = 1 Then
                idventa1 = rows.Cells.Item(1).Value
            End If
            If Orden = 2 Then
                idventa2 = rows.Cells.Item(1).Value
            End If
            If Orden = 3 Then idventa3 = rows.Cells.Item(1).Value
            If Orden = 4 Then idventa4 = rows.Cells.Item(1).Value
            If Orden = 5 Then idventa5 = rows.Cells.Item(1).Value
            If Orden = 6 Then idventa6 = rows.Cells.Item(1).Value
        Next
        ocultar_paneles_de_pedidos()
    End Sub
    Sub ocultar_paneles_de_pedidos()
        Dim contador As Integer = datalistadoventas.RowCount

        If contador = 0 Then
            PSinpedidos.Visible = True
            PSinpedidos.BringToFront()
            PSinpedidos.Dock = DockStyle.Fill
            P1.Visible = False
            P2.Visible = False
        End If
        If contador > 0 Then
            PSinpedidos.Visible = False
            PSinpedidos.Dock = DockStyle.None
        End If
        If contador = 1 Then
            P1.Visible = True
            P2.Visible = False
        End If
        If contador = 2 Then
            P1.Visible = True
            P2.Visible = True
        End If
    End Sub

    Private Sub datalistadoDetalledeventa1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoDetalledeventa1.CellContentClick

    End Sub

    Private Sub datalistadoDetalledeventa1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoDetalledeventa1.CellClick
        Dim iddetalle As Integer = datalistadoDetalledeventa1.SelectedCells.Item(6).Value
        If e.ColumnIndex = datalistadoDetalledeventa1.Columns.Item("Accion1").Index Then
            For Each rows As DataGridViewRow In datalistadoDetalledeventa1.Rows
                Dim Accion As String = Convert.ToString(rows.Cells("Accion1").Value)
                Dim iddetalleventa As Integer = Convert.ToInt32(rows.Cells("iddetalle_venta").Value)
                IddetalleVentaGeneral = iddetalle
                If Accion = "Despachar" Then
                    editar_estado_de_pedido_a_DESPACHADO()
                    If datalistadoDetalledeventa1.RowCount = 1 Then
                        idventaGeneral = idventa1
                        editar_estado_de_Venta_DESPACHADO()
                    End If
                    Try
                        If iddetalle = iddetalleventa Then
                            datalistadoDetalledeventa1.Rows.Remove(datalistadoDetalledeventa1.CurrentRow)
                            mostrar_id_de_venta()
                            obtener_datos()
                        End If

                    Catch ex As Exception

                    End Try
                End If
                If Accion = "Preparar" Then
                    If iddetalle = iddetalleventa Then
                        rows.Cells(0).Value = "Despachar"
                        rows.Cells(1).Value = "Volver"
                        rows.Cells(7).Value = "EN PREPARACION"
                        rows.DefaultCellStyle.BackColor = Color.SeaGreen
                        rows.DefaultCellStyle.SelectionBackColor = Color.SeaGreen
                        editar_estado_de_pedido_a_ENPREPARACION()
                    End If
                End If
            Next
        End If
        If e.ColumnIndex = Me.datalistadoDetalledeventa1.Columns.Item("Volver1").Index Then
            For Each rows As DataGridViewRow In datalistadoDetalledeventa1.Rows
                Dim Accion As String = Convert.ToString(rows.Cells("Accion1").Value)
                Dim iddetalleventa As Integer = Convert.ToInt32(rows.Cells("iddetalle_venta").Value)
                IddetalleVentaGeneral = iddetalle
                If Accion = "Despachar" Then
                    If iddetalle = iddetalleventa Then
                        editar_estado_de_pedido_a_ENESPERA()
                        rows.Cells(0).Value = "Preparar"
                        rows.Cells(1).Value = ""
                        rows.Cells(7).Value = "EN ESPERA"
                        rows.DefaultCellStyle.BackColor = Color.FromArgb(49, 49, 49)
                        rows.DefaultCellStyle.SelectionBackColor = Color.FromArgb(49, 49, 49)

                    End If
                End If

            Next

        End If
    End Sub
    Sub editar_estado_de_pedido_a_ENESPERA()
        Dim cmd As New SqlCommand("editar_estado_de_pedido_a_ENESPERA", conexion)
        cmd.CommandType = 4
        cmd.Parameters.AddWithValue("@Iddetalleventa", IddetalleVentaGeneral)
        Try
            abrir()
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub
    Sub editar_estado_de_pedido_a_ENPREPARACION()
        Dim cmd As New SqlCommand("editar_estado_de_pedido_a_ENPREPARACION", conexion)
        cmd.CommandType = 4
        cmd.Parameters.AddWithValue("@Iddetalleventa", IddetalleVentaGeneral)
        Try
            abrir()
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try

    End Sub
    Sub editar_estado_de_Venta_DESPACHADO()
        Dim cmd As New SqlCommand("editar_estado_de_Venta_DESPACHADO", conexion)
        cmd.CommandType = 4
        cmd.Parameters.AddWithValue("@idventa", idventaGeneral)
        Try
            abrir()
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub
    Sub editar_estado_de_pedido_a_DESPACHADO()
        Dim cmd As New SqlCommand("editar_estado_de_pedido_a_DESPACHADO", conexion)
        cmd.CommandType = 4
        cmd.Parameters.AddWithValue("@Iddetalleventa", IddetalleVentaGeneral)
        Try
            abrir()
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Private Sub TimerNUEVOSPEDIDOS_Tick(sender As Object, e As EventArgs) Handles TimerNUEVOSPEDIDOS.Tick
        mostrar_si_hay_nuevos_pedidos_ventas()
        If cantidad_de_ventas_Pedidos_nuevos > datalistadoventas.RowCount Then
            TimerActualizador.Start()
        End If
    End Sub
    Sub mostrar_si_hay_nuevos_pedidos_ventas()
        Dim dt As New DataTable
        Dim da As New SqlCommand("select count( idventa) from ventas where Estado='EN ESPERA'", conexion)
        Try
            abrir()
            cantidad_de_ventas_Pedidos_nuevos = da.ExecuteScalar()
            Cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Private Sub TimerActualizador_Tick(sender As Object, e As EventArgs) Handles TimerActualizador.Tick
        mostrar_id_de_venta()
        obtener_datos()
        TimerActualizador.Stop()
    End Sub

    Private Sub TimerP1_Tick(sender As Object, e As EventArgs) Handles TimerP1.Tick
        If idventa1 <> 0 Then
            contador_minutero += 1
            If contador_minutero = 60 Then
                Dim minutos_transcurridosEn_vivo As String
                Dim dt As New DataTable
                Dim da As New SqlCommand("mostrar_minutos_transcurridos_por_pedido", conexion)
                da.CommandType = 4
                da.Parameters.AddWithValue("idventa", idventa1)
                Try
                    abrir()
                    minutos_transcurridosEn_vivo = da.ExecuteScalar
                    lblminutos1.Text = minutos_transcurridosEn_vivo
                    Cerrar()
                    If lblminutos1.Text = "" Then
                        TimerP1.Stop()

                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.StackTrace)
                End Try
                contador_minutero = 0
            End If
        Else
            TimerP1.Stop()

        End If
    End Sub

    Private Sub btnPrepararTodos1_Click(sender As Object, e As EventArgs) Handles btnPrepararTodos1.Click
        For Each rows As DataGridViewRow In datalistadoDetalledeventa1.Rows
            Dim Accion As String = Convert.ToString(rows.Cells("Accion1").Value)
            Dim iddetalleventa As Integer = Convert.ToInt32(rows.Cells("iddetalle_venta").Value)
            If Accion = "Preparar" Then
                IddetalleVentaGeneral = iddetalleventa
                rows.Cells(0).Value = "Despachar"
                rows.Cells(1).Value = "Volver"
                rows.Cells(7).Value = "EN PREPARACION"
                rows.DefaultCellStyle.BackColor = Color.SeaGreen
                rows.DefaultCellStyle.SelectionBackColor = Color.SeaGreen
                editar_estado_de_pedido_a_ENPREPARACION()
            End If
        Next
    End Sub

    Private Sub btnDespacharTodos1_Click(sender As Object, e As EventArgs) Handles btnDespacharTodos1.Click
        idventaGeneral = idventa1
        editar_estado_de_Venta_DESPACHADO()
        For Each rows As DataGridViewRow In datalistadoDetalledeventa1.Rows
            Dim iddetalleventa As Integer = Convert.ToInt32(rows.Cells("iddetalle_venta").Value)
            IddetalleVentaGeneral = iddetalleventa
            editar_estado_de_pedido_a_DESPACHADO()
        Next
        mostrar_id_de_venta()
        obtener_datos()
    End Sub

End Class