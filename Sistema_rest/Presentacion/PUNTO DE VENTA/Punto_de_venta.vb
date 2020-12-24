Imports System.Data.SqlClient
Public Class Punto_de_venta
    Public id_grupo As Integer
    Dim contadorControlesGrupos As Integer
    Dim cantidad_grupos As Integer
    Dim ventagenerada As String
    Public idventa As Integer
    Public idmesa As Integer
    Dim SerialPc As String
    Dim idusuario As Integer
    Dim idcaja As Integer
    Dim panelConfiguraciones As New Panel()
    Dim Estado_de_herramientas = 0
    Dim vuelto As Double
    Dim iddetalleventa As Integer
    Dim Estado_venta As String
    Dim paginaInicio As Integer = 1
    Dim paginaMaxima As Integer = 10
    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs) Handles Panel10.Paint

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtnumero.Text = txtnumero.Text & "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtnumero.Text = txtnumero.Text & "2"

    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtnumero.Text = txtnumero.Text & "3"

    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtnumero.Text = txtnumero.Text & "4"

    End Sub
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtnumero.Text = txtnumero.Text & "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtnumero.Text = txtnumero.Text & "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtnumero.Text = txtnumero.Text & "7"


    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtnumero.Text = txtnumero.Text & "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtnumero.Text = txtnumero.Text & "9"
    End Sub

    Private Sub btnborrartodo_Click(sender As Object, e As EventArgs) Handles btnborrartodo.Click
        txtnumero.Clear()
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtnumero.Text = txtnumero.Text & "0"
    End Sub

    Private Sub btnborrarderecha_Click(sender As Object, e As EventArgs) Handles btnborrarderecha.Click
        Try
            Dim largo As Integer
            If txtnumero.Text <> "" Then
                largo = txtnumero.Text.Length
                txtnumero.Text = Mid(txtnumero.Text, 1, largo - 1)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Punto_de_venta_cambio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambio_idioma_regional()
        mostrar_fecha_del_sistema()
        Obtener_serialPc(SerialPc)
        Obtener_idusurio_por_sesion(idusuario)
        Obtener_id_caja_PorSerial(idcaja)
        eliminar_venta_incompletas()
        dibujarGrupos()
        contar_cantidad_de_grupos()
        obteneridmesa()
        listarventas()
        Listarproductosagregados()

    End Sub
    Sub mostrar_fecha_del_sistema()
        lblfecha.Text = DateTime.Now.ToShortDateString()
    End Sub
    Public Sub sumar()
        Dim totalpagar As Double = 0
        For Each fila As DataGridViewRow In datalistadoDetalledeventa.Rows
            totalpagar += (fila.Cells("Importe").Value)
        Next
        txtTotal.Text = totalpagar
        formatodinero(txtTotal.Text)
    End Sub
    Public Sub eliminar_venta_incompletas()
        Try
            abrir()
            Dim cmd = New SqlCommand("eliminar_venta_incompletas", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idCAJA", idcaja)
            cmd.ExecuteNonQuery()
            Cerrar()

        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try

    End Sub
    Sub insertar_venta()

        If ventagenerada = "VENTA NUEVA" Then
            Try
                abrir()
                Dim cmd = New SqlCommand("insertar_venta", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("idcliente", 1)
                cmd.Parameters.AddWithValue("@fecha_venta", Now())
                cmd.Parameters.AddWithValue("@nume_documento", 0)
                cmd.Parameters.AddWithValue("@montototal", 0)
                cmd.Parameters.AddWithValue("@Tipo_de_pago", "-")
                cmd.Parameters.AddWithValue("@estado", "SIN CONFIRMAR")
                cmd.Parameters.AddWithValue("@IGV", 0)
                cmd.Parameters.AddWithValue("@Comprobante", "Ticket")
                cmd.Parameters.AddWithValue("@id_usuario", idusuario)
                cmd.Parameters.AddWithValue("@Fecha_de_pago", Now())
                cmd.Parameters.AddWithValue("@ACCION", "VENTA")
                cmd.Parameters.AddWithValue("@Saldo", 0)
                cmd.Parameters.AddWithValue("@Pago_con", 0)
                cmd.Parameters.AddWithValue("@Porcentaje_IGV", 18)
                cmd.Parameters.AddWithValue("@Id_caja", idcaja)
                cmd.Parameters.AddWithValue("@Referencia_tarjeta", "NULO")
                cmd.Parameters.AddWithValue("@Id_mesa", idmesa)
                cmd.Parameters.AddWithValue("@Numero_personas", 1)
                cmd.ExecuteNonQuery()
                Cerrar()
                listarventas()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
        If ventagenerada = "VENTA GENERADA" Then
            insertar_detalle_venta()
        End If
    End Sub
    Sub insertar_detalle_venta()
        Try
            abrir()
            Dim cmd = New SqlCommand("insertar_detalle_venta", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idventa", idventa)
            cmd.Parameters.AddWithValue("@Id_producto", Mostrador_de_productos.idproducto)
            cmd.Parameters.AddWithValue("@cantidad", 1)
            cmd.Parameters.AddWithValue("@preciounitario", Mostrador_de_productos.precio_de_venta)
            cmd.Parameters.AddWithValue("@moneda", "S/.")
            cmd.Parameters.AddWithValue("@unidades", "Unidad")
            cmd.Parameters.AddWithValue("@Cantidad_mostrada", 1)
            cmd.Parameters.AddWithValue("@Estado", "EN ESPERA")
            cmd.Parameters.AddWithValue("@Costo", 0)
            cmd.Parameters.AddWithValue("@Estado_de_pago", "DEBE")
            cmd.ExecuteNonQuery()
            Cerrar()
            Listarproductosagregados()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Listarproductosagregados()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As SqlDataAdapter
            da = New SqlDataAdapter("mostrar_productos_agregados_a_venta", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@idventa", idventa)
            da.SelectCommand.Parameters.AddWithValue("@Id_mesa", idmesa)
            da.Fill(dt)
            datalistadoDetalledeventa.DataSource = dt
            Cerrar()
            Otorgar_tamaños_a_columnas_de_datalistadoDetalledeventa()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        sumar()
    End Sub
    Sub Otorgar_tamaños_a_columnas_de_datalistadoDetalledeventa()
        datalistadoDetalledeventa.Columns(0).Width = 50
        datalistadoDetalledeventa.Columns(1).Width = 50
        datalistadoDetalledeventa.Columns(2).Width = 50
        datalistadoDetalledeventa.Columns(3).Visible = False
        datalistadoDetalledeventa.Columns(4).Width = 150
        datalistadoDetalledeventa.Columns(5).Width = 60
        datalistadoDetalledeventa.Columns(6).Width = 60
        datalistadoDetalledeventa.Columns(7).Width = 60
        datalistadoDetalledeventa.Columns(8).Visible = False
        datalistadoDetalledeventa.Columns(9).Visible = False
        datalistadoDetalledeventa.Columns(10).Visible = False
        datalistadoDetalledeventa.Columns(11).Visible = False
        datalistadoDetalledeventa.Columns(12).Visible = False



    End Sub
    Sub obteneridmesa()
        idmesa = Visor_de_mesas.idmesa
    End Sub
    Sub listarventas()
        Try
            Dim com As New SqlCommand("mostrar_id_venta_existente", conexion)
            com.CommandType = 4
            com.Parameters.AddWithValue("@Id_mesa", idmesa)
            abrir()
            idventa = com.ExecuteScalar()
            Cerrar()
            If idventa > 0 Then
                ventagenerada = "VENTA GENERADA"
            Else
                ventagenerada = "VENTA NUEVA"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            abrir()
            Dim cmd = New SqlCommand("mostrar_estado_de_venta_por_id", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idventa", idventa)
            Estado_venta = cmd.ExecuteScalar()
            Cerrar()
        Catch ex As Exception

        End Try
    End Sub


    Sub contar_cantidad_de_grupos()
        Try
            Dim com As New SqlCommand("select count(Idline) from Grupo_de_Productos", conexion)
            abrir()
            cantidad_grupos = com.ExecuteScalar()
            Cerrar()
        Catch ex As Exception
            cantidad_grupos = 0
        End Try
    End Sub
    Sub dibujarGrupos()
        Panel_grupos.Controls.Clear()
        Try
            abrir()
            Dim query As String = "Paginar_grupos"
            Dim cmd As New SqlCommand(query, conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Desde", paginaInicio)
            cmd.Parameters.AddWithValue("@Hasta", paginaMaxima)

            Dim rdr As SqlDataReader = cmd.ExecuteReader()

            While rdr.Read()

                Dim b As New Label
                Dim p1 As New Panel

                Dim I1 As New PictureBox
                b.Text = rdr("Grupo").ToString()
                b.Name = rdr("Idline").ToString()



                b.Size = New System.Drawing.Size(119, 25)
                b.Font = New System.Drawing.Font(10, 11)


                b.BackColor = Color.Transparent
                b.ForeColor = Color.White
                b.Dock = DockStyle.Fill
                b.TextAlign = ContentAlignment.MiddleCenter
                b.Cursor = Cursors.Hand
                b.Font = New System.Drawing.Font("Microsoft Sans Serif", 7, FontStyle.Regular Or
        FontStyle.Bold)


                p1.Size = New System.Drawing.Size(110, 75)
                p1.BorderStyle = BorderStyle.None
                p1.Dock = DockStyle.Bottom
                p1.BackColor = Color.Transparent
                p1.Name = rdr("Idline").ToString()
                p1.BackgroundImage = My.Resources.naranja
                p1.BackgroundImageLayout = BackgroundImageLayout.Stretch


                I1.Size = New System.Drawing.Size(140, 50)
                I1.Dock = DockStyle.Top
                I1.BackgroundImage = Nothing
                Dim bi() As Byte = rdr("Icono")
                Dim ms As New IO.MemoryStream(bi)
                I1.Image = Image.FromStream(ms)
                I1.SizeMode = PictureBoxSizeMode.Zoom
                I1.Cursor = Cursors.Hand
                I1.Tag = rdr("Idline").ToString()
                I1.BackColor = Color.Transparent




                p1.Controls.Add(b)
                If rdr("Estado_de_icono").ToString() <> "VACIO" Then
                    p1.Controls.Add(I1)
                End If
                b.BringToFront()
                Panel_grupos.Controls.Add(p1)

                AddHandler b.Click, AddressOf miEventoLabel
                AddHandler I1.Click, AddressOf miEventoImagen

            End While
            Cerrar()


        Catch ex As Exception

        End Try
    End Sub
    Private Sub miEventoImagen(sender As Object, e As EventArgs)
        Try
            id_grupo = DirectCast(sender, PictureBox).Tag
            Seleccionar_Deseleccionar_grupos()
            mostrar_Formulario_en_panel()
        Catch ex As Exception

        End Try
    End Sub
    Sub Seleccionar_Deseleccionar_grupos()
        Try
            For Each panelP1 In Panel_grupos.Controls
                If TypeOf panelP1 Is System.Windows.Forms.Panel Then
                    For Each PanLateral2 In panelP1.controls
                        panelP1.Backcolor = Color.Transparent
                        panelP1.BackgroundImage = My.Resources.naranja
                        panelP1.BackgroundImageLayout = BackgroundImageLayout.Stretch
                        Exit For
                        Exit For
                    Next
                End If
            Next

            For Each PanelP2 In Panel_grupos.Controls
                If TypeOf PanelP2 Is System.Windows.Forms.Panel Then
                    If PanelP2.name = id_grupo Then
                        PanelP2.Backcolor = Color.Transparent
                        PanelP2.BackgroundImage = My.Resources.azul
                        PanelP2.BackgroundImageLayout = BackgroundImageLayout.Stretch
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub miEventoLabel(sender As Object, e As EventArgs)
        Try
            id_grupo = DirectCast(sender, Label).Name
            Seleccionar_Deseleccionar_grupos()
            mostrar_Formulario_en_panel()
        Catch ex As Exception

        End Try
    End Sub
    Sub mostrar_Formulario_en_panel()
        Mostrador_de_productos.Dispose()
        Mostrador_de_productos.TopLevel = False
        Mostrador_de_productos.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Mostrador_de_productos.Dock = DockStyle.Fill
        PanelProductos.Controls.Add(Mostrador_de_productos)
        Mostrador_de_productos.Show()
    End Sub

    Private Sub btnGrupoadelante_Click(sender As Object, e As EventArgs) Handles btnGrupoadelante.Click
        contar_cantidad_de_grupos()
        If cantidad_grupos > paginaMaxima Then
            paginaInicio += 10
            paginaMaxima += 10
            dibujarGrupos()
        End If

    End Sub

    Private Sub btngrupoAtras_Click(sender As Object, e As EventArgs) Handles btngrupoAtras.Click

        If paginaInicio > 1 Then
            paginaInicio -= 10
            paginaMaxima -= 10
            dibujarGrupos()
        End If

    End Sub

    Private Sub btnVermesas_Click(sender As Object, e As EventArgs) Handles btnVermesas.Click
        volver_al_visor_de_mesas()
    End Sub
    Public Sub volver_al_visor_de_mesas()
        Visor_de_mesas.Ocultar_formulario_en_panel()
        Visor_de_mesas.dibujarMESAS()
    End Sub
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        volver_al_login()
    End Sub
    Public Sub volver_al_login()
        Mostrador_de_productos.Dispose()
        Dispose()
        Visor_de_mesas.Dispose()
        LOGIN.ShowDialog()
    End Sub

    Private Sub btnEnviarpedido_Click(sender As Object, e As EventArgs) Handles btnEnviarpedido.Click
        If datalistadoDetalledeventa.RowCount > 0 Then
            editar_estado_de_mesa_a_ocupado()
            editar_estado_de_Venta_ENESPERA()
            Visor_de_mesas.dibujarMESAS()
            volver_al_visor_de_mesas()
        Else
            MessageBox.Show("Agrege productos a la venta", "Sin Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Sub editar_estado_de_Venta_ENESPERA()
        Try
            abrir()
            Dim cmd = New SqlCommand("editar_estado_de_Venta_ENESPERA", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idventa", idventa)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub
    Public Sub editar_estado_de_mesa_a_ocupado()
        Try
            abrir()
            Dim cmd = New SqlCommand("Editar_estado_de_mesa_a_OCUPADO", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Idmesa", idmesa)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Private Sub btnherramientas_Click(sender As Object, e As EventArgs) Handles btnherramientas.Click
        dibujar_panel_configuraciones()

    End Sub
    Public Sub dibujar_panel_configuraciones()
        If Estado_de_herramientas = 1 Then
            PanelHerramientasC.Visible = False
            panelConfiguraciones.Visible = False
            Estado_de_herramientas = 0
        Else
            panelConfiguraciones.Visible = True
            panelConfiguraciones.BackColor = Color.Transparent
            panelConfiguraciones.Size = New System.Drawing.Size(125, 506)
            panelConfiguraciones.Location = New Point(FlowLayoutPanel2.Location.X + btnherramientas.Location.X, Panel5.Location.Y - panelConfiguraciones.Height)
            PanelHerramientasC.Dock = DockStyle.Fill
            panelConfiguraciones.Controls.Add(PanelHerramientasC)
            Me.Controls.Add(panelConfiguraciones)
            PanelHerramientasC.Visible = True
            panelConfiguraciones.BringToFront()
            Estado_de_herramientas = 1
        End If

    End Sub

    Private Sub btncocina_Click(sender As Object, e As EventArgs) Handles btncocina.Click
        dibujar_panel_configuraciones()
        Pedidos_en_pantalla.ShowDialog()
    End Sub
    Public Sub calcular_vuelto_y_efectivo()
        If datalistadoDetalledeventa.RowCount > 0 Then

            validar_venta_por_mesa()
            End If
    End Sub
    Public Sub validar_venta_por_mesa()
        If Estado_venta <> "SIN CONFIRMAR" Then
            Dim total As Double
            Dim acumulado As Double
            PanelAcumulado.Visible = True
            If txtacumulado.Text = "" Then txtacumulado.Text = 0
            If txtTotal.Text = "" Then txtTotal.Text = 0
            total = txtTotal.Text
            acumulado = txtacumulado.Text

            If acumulado >= total Then
                vuelto = acumulado - total
                editar_estado_detalle_venta_COMPLETO()
                Confirmar_venta_efectivo()
                editar_estado_de_mesa_a_libre()
                volver_al_visor_de_mesas()

            End If
        Else
            MessageBox.Show("Envie el pedido Primero", "Pedido sin enviar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    Public Sub editar_estado_de_mesa_a_libre()
        Try
            abrir()
            Dim cmd = New SqlCommand("Editar_estado_de_mesa_a_LIBRE", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Idmesa", idmesa)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            MsgBox(ex.StackTrace)
        End Try
    End Sub
    Public Sub Confirmar_venta_efectivo()
        Try
            abrir()
            Dim cmd = New SqlCommand("Confirmar_venta", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idventa", idventa)
            cmd.Parameters.AddWithValue("@montototal", txtTotal.Text)
            cmd.Parameters.AddWithValue("@IGV", 0)
            cmd.Parameters.AddWithValue("@Saldo", 0)
            cmd.Parameters.AddWithValue("@Tipo_de_pago", "EFECTIVO")
            cmd.Parameters.AddWithValue("@idcliente ", 1)
            cmd.Parameters.AddWithValue("@Comprobante ", "Ticket")
            cmd.Parameters.AddWithValue("@Numero_de_doc", 0)
            cmd.Parameters.AddWithValue("@fecha_venta", Now())
            cmd.Parameters.AddWithValue("@ACCION", "VENTA")
            cmd.Parameters.AddWithValue("@Fecha_de_pago", "PAGO AL CONTADO")
            cmd.Parameters.AddWithValue("@Pago_con", txtacumulado.Text)
            cmd.Parameters.AddWithValue("@Referencia_tarjeta", "NULO")
            cmd.Parameters.AddWithValue("@Vuelto", vuelto)
            cmd.Parameters.AddWithValue("@Efectivo", txtTotal.Text)
            cmd.Parameters.AddWithValue("@Credito", 0)
            cmd.Parameters.AddWithValue("@Tarjeta", 0)
            cmd.Parameters.AddWithValue("@Donde_se_consumira", 0)
            cmd.Parameters.AddWithValue("@Estado", "TERMINADO")
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub editar_estado_detalle_venta_COMPLETO()
        For Each row As DataGridViewRow In datalistadoDetalledeventa.Rows
            Dim id As Integer = Convert.ToInt32(row.Cells("iddetalle_venta").Value)
            iddetalleventa = id
            editar_estado_de_detalle_de_venta()
        Next
    End Sub
    Public Sub editar_estado_de_detalle_de_venta()
        Try
            abrir()
            Dim cmd As New SqlCommand("editar_estado_de_detalle_de_venta", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@iddetalleventa", iddetalleventa)
            cmd.ExecuteNonQuery()
            Cerrar()

        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)

        End Try
    End Sub
    Private Sub Bn1_Click(sender As Object, e As EventArgs) Handles Bn1.Click
        txtacumulado.Text += 1
        calcular_vuelto_y_efectivo()
    End Sub

    Private Sub Bn5_Click(sender As Object, e As EventArgs) Handles Bn5.Click
        txtacumulado.Text += 5
        calcular_vuelto_y_efectivo()
    End Sub

    Private Sub Bn10_Click(sender As Object, e As EventArgs) Handles Bn10.Click
        txtacumulado.Text += 10
        calcular_vuelto_y_efectivo()
    End Sub

    Private Sub Bn20_Click(sender As Object, e As EventArgs) Handles Bn20.Click
        txtacumulado.Text += 20
        calcular_vuelto_y_efectivo()
    End Sub

    Private Sub Bn50_Click(sender As Object, e As EventArgs) Handles Bn50.Click
        txtacumulado.Text += 50
        calcular_vuelto_y_efectivo()
    End Sub

    Private Sub Bn100_Click(sender As Object, e As EventArgs) Handles Bn100.Click
        txtacumulado.Text += 100
        calcular_vuelto_y_efectivo()
    End Sub

    Private Sub BnExacto_Click(sender As Object, e As EventArgs) Handles BnExacto.Click
        txtacumulado.Text = txtTotal.Text
        calcular_vuelto_y_efectivo()
    End Sub

    Private Sub btnPrecuenta_Click(sender As Object, e As EventArgs) Handles btnPrecuenta.Click
        VistaPreciaPrecuenta.ShowDialog()
    End Sub

    Private Sub TimerHora_Tick(sender As Object, e As EventArgs) Handles TimerHora.Tick
        lblhora.Text = DateTime.Now.ToString("hh:mm:ss")

    End Sub

    Private Sub datalistadoDetalledeventa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoDetalledeventa.CellContentClick

    End Sub

    Private Sub datalistadoDetalledeventa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadoDetalledeventa.CellClick
        Obtener_datos_del_detalleVenta()
        If e.ColumnIndex = datalistadoDetalledeventa.Columns.Item("EL").Index Then
            eliminar_detalle_venta()
            Listarproductosagregados()
            Eliminar_venta_y_cambiar_estado_de_mesa_de_ocupado_a_libre()
        End If
        If e.ColumnIndex = datalistadoDetalledeventa.Columns.Item("S").Index Then
            editar_detalle_venta_sumar()
            Listarproductosagregados()
        End If
        If e.ColumnIndex = datalistadoDetalledeventa.Columns.Item("R").Index Then
            editar_detalle_venta_restar()
            Listarproductosagregados()
            Eliminar_venta_y_cambiar_estado_de_mesa_de_ocupado_a_libre()
        End If
    End Sub
    Public Sub eliminar_detalle_venta()
        Try
            abrir()
            Dim cmd = New SqlCommand("eliminar_detalle_venta", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@iddetalleventa", iddetalleventa)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub
    Public Sub Obtener_datos_del_detalleVenta()
        Try
            iddetalleventa = datalistadoDetalledeventa.SelectedCells.Item(8).Value
        Catch ex As Exception

        End Try
    End Sub
    Public Sub Eliminar_venta_y_cambiar_estado_de_mesa_de_ocupado_a_libre()
        If txtTotal.Text = 0 Then
            Try
                abrir()
                Dim cmd = New SqlCommand("eliminar_venta", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@idventa", idventa)
                cmd.ExecuteNonQuery()
                Cerrar()

                ventagenerada = "VENTA NUEVA"

                abrir()
                cmd = New SqlCommand("Editar_estado_de_mesa_a_LIBRE", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@Idmesa", idmesa)
                cmd.ExecuteNonQuery()
                Cerrar()


            Catch ex As Exception
                MessageBox.Show(ex.StackTrace)
            End Try
        End If

    End Sub
    Public Sub editar_detalle_venta_restar()
        Try
            abrir()
            Dim cmd = New SqlCommand("editar_detalle_venta_restar", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@iddetalle_venta", iddetalleventa)
            cmd.Parameters.AddWithValue("@Id_venta", idventa)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)

        End Try
    End Sub
    Public Sub editar_detalle_venta_sumar()
        Try
            abrir()
            Dim cmd = New SqlCommand("editar_detalle_venta_sumar", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@iddetalle_venta", iddetalleventa)
            cmd.Parameters.AddWithValue("@Id_venta", idventa)
            cmd.ExecuteNonQuery()
            Cerrar()

        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

    End Sub
End Class