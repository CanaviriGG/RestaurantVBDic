Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class Visor_de_mesas
    Dim PanelConfiguracionesVER As New Panel
    Dim Estado_de_herramientas As Integer = 0
    Public idmesa As Integer
    Dim id_salon As Integer
    Dim estado As String
    Public nombre_mesa As String
    Dim estado_de_mesa As String
    Dim Paso As Integer = 0
    Dim idmesa_Origen As Integer
    Dim idmesa_Destino As Integer
    Dim id_venta_mesa_origen As Integer
    Dim id_venta_mesa_destino As Integer
    Dim Union_de_mesas As String
    Private Sub Visor_de_mesas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dibujarSalones()
        Union_de_mesas = "INACTIVO"
        PanelBienvenida.Visible = True
        PanelBienvenida.Dock = DockStyle.Fill
        PanelMesas.Visible = False
        PanelMesas.Dock = DockStyle.None

    End Sub

    Sub dibujarSalones()
        FlowLayoutPanel1.Controls.Clear()
        Try
            abrir()
            Dim query As String = "Select * from SALON Where Estado='ACTIVO'"
            Dim cmd As New SqlCommand(query, conexion)

            Dim rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read()

                Dim b As New Button()
                Dim panelC1 As New Panel
                Dim panelLATERAL As New Panel

                b.Text = rdr("Salon").ToString()
                b.Name = rdr("Id_salon").ToString()
                b.Tag = rdr("Estado").ToString()
                b.Dock = DockStyle.Fill
                b.BackColor = Color.Transparent
                b.Font = New System.Drawing.Font(10, 12)
                b.FlatStyle = FlatStyle.Flat
                b.FlatAppearance.BorderSize = 0
                b.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64)
                b.FlatAppearance.MouseOverBackColor = Color.FromArgb(43, 43, 43)

                b.TextAlign = ContentAlignment.MiddleLeft
                b.Tag = rdr("Estado").ToString()

                panelC1.Size = New System.Drawing.Size(244, 58)
                panelC1.Name = rdr("Id_salon").ToString()

                panelLATERAL.Size = New System.Drawing.Size(3, 58)
                panelLATERAL.Dock = DockStyle.Left
                panelLATERAL.BackColor = Color.Transparent
                panelLATERAL.Name = rdr("Id_salon").ToString()

                Dim estado As String
                estado = rdr("Estado").ToString()
                If estado = "ELIMINADO" Then
                    b.Text = rdr("Salon").ToString() & " - Eliminado"
                    b.ForeColor = Color.FromArgb(231, 63, 67)
                Else
                    b.ForeColor = Color.White
                End If
                panelC1.Controls.Add(b)
                panelC1.Controls.Add(panelLATERAL)
                FlowLayoutPanel1.Controls.Add(panelC1)

                b.BringToFront()
                panelLATERAL.SendToBack()

                AddHandler b.Click, AddressOf miEvento_salon_button
            End While
            Cerrar()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Sub miEvento_salon_button(ByVal sender As System.Object, ByVal e As EventArgs)


        Try
            ocultar_panel_configuraciones()
            PanelMesas.Visible = True
            PanelMesas.Dock = DockStyle.Fill
            id_salon = DirectCast(sender, Button).Name
            estado = DirectCast(sender, Button).Tag
            PanelBienvenida.Visible = False
            PanelBienvenida.Dock = DockStyle.None
            PanelMesas.Visible = True
            PanelMesas.Dock = DockStyle.Fill
            dibujarMESAS()

        Catch ex As Exception

        End Try



        For Each panelC2 In FlowLayoutPanel1.Controls
            If TypeOf panelC2 Is Panel Then
                For Each panelLATERAL2 In panelC2.Controls
                    If TypeOf panelLATERAL2 Is Panel Then
                        panelLATERAL2.BackColor = Color.Transparent
                        panelC2.Backcolor = Color.Transparent
                        Exit For
                        Exit For
                    End If
                Next
            End If
        Next


        Dim NOMBRE As String = DirectCast(sender, Button).Name
        For Each panelC1 In FlowLayoutPanel1.Controls
            If TypeOf panelC1 Is Panel Then

                For Each panelLATERAL In panelC1.Controls
                    If TypeOf panelLATERAL Is Panel Then
                        If panelLATERAL.Name = NOMBRE Then
                            panelLATERAL.BackColor = Color.OrangeRed
                            panelC1.BackColor = Color.FromArgb(43, 43, 43)
                            Exit For
                            Exit For
                        End If
                    End If
                Next

            End If
        Next


    End Sub
    Public Sub mostrar_mozo_por_mesa()
        Try
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("mostrar_mozo_por_mesa", conexion)
            abrir()
            da.Fill(dt)
            datalistadoUsuariosMesas.DataSource = dt
            Cerrar()
        Catch ex As Exception

        End Try
    End Sub
    Sub dibujarMESAS()
        mostrar_mozo_por_mesa()
        PanelMesas.Controls.Clear()
        Try
            abrir()
            Dim query As String = "mostrar_mesas_por_salon"
            Dim cmd As New SqlCommand(query, conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@id_salon", id_salon)
            Dim rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read()

                Dim b As New Button()
                Dim panel As New Panel
                Dim LabelMozo As New Label
                Dim panelContienea_b_label As New Panel

                Dim alto As Integer = rdr("y").ToString()
                Dim ancho As Integer = rdr("x").ToString()
                Dim tamanio_letra As Integer = rdr("Tamanio_letra").ToString()
                Dim tamanio As Point = New Point(ancho, alto)

                panel.BackgroundImageLayout = ImageLayout.Stretch
                panel.Tag = rdr("Id_mesa").ToString()
                panel.Size = New System.Drawing.Size(tamanio)

                b.Text = rdr("Mesa").ToString()
                b.Name = rdr("Id_mesa").ToString()
                b.Tag = rdr("Estado_de_Disponibilidad").ToString()
                b.BackColor = Color.Transparent
                b.Dock = DockStyle.Fill
                b.TextAlign = ContentAlignment.MiddleCenter
                b.FlatAppearance.MouseDownBackColor = Color.Transparent
                b.FlatAppearance.MouseOverBackColor = Color.Transparent
                panelContienea_b_label.BackgroundImageLayout = ImageLayout.Stretch

                If b.Tag = "LIBRE" Then
                    panelContienea_b_label.BackgroundImage = My.Resources.verde
                Else
                    panelContienea_b_label.BackgroundImage = My.Resources.Rojo

                    LabelMozo.Size = New System.Drawing.Size(120, 30)
                    LabelMozo.BackColor = Color.Transparent
                    For Each row As DataGridViewRow In datalistadoUsuariosMesas.Rows
                        Dim usuario As String = Convert.ToString(row.Cells("Login").Value)
                        Dim mesa As String = Convert.ToString(row.Cells("Mesa").Value)
                        If mesa = b.Text Then
                            LabelMozo.Text = usuario
                        End If
                    Next
                    LabelMozo.Dock = DockStyle.Bottom
                    LabelMozo.TextAlign = ContentAlignment.MiddleCenter
                    LabelMozo.ForeColor = Color.White
                    LabelMozo.Font = New System.Drawing.Font("Segoe UI", 9, FontStyle.Regular Or FontStyle.Bold)
                    panelContienea_b_label.Controls.Add(LabelMozo)
                End If

                If b.Text <> "NULO" Then
                    b.Font = New System.Drawing.Font(10, tamanio_letra)
                    b.FlatStyle = FlatStyle.Flat
                    b.FlatAppearance.BorderSize = 0
                    b.ForeColor = Color.White
                    b.Cursor = Cursors.Hand
                    panelContienea_b_label.Size = New System.Drawing.Size(tamanio)
                    panelContienea_b_label.Controls.Add(b)
                    PanelMesas.Controls.Add(panelContienea_b_label)
                Else
                    PanelMesas.Controls.Add(panel)
                End If
                b.BringToFront()
                AddHandler b.Click, AddressOf miEvento_buton_mesa
            End While
            Cerrar()
        Catch ex As Exception
            Cerrar()
        End Try


    End Sub

    Sub MOSTRAR_ESTADO_OCUPADO_MESAS()
        Dim dtDATALISTADO_AGREGANDO As New DataTable
        Dim daListarpresentacionesagregadas As SqlDataAdapter
        Try
            abrir()
            daListarpresentacionesagregadas = New SqlDataAdapter("SELECT Estado_de_Disponibilidad,Id_mesa   FROM Mesas where Estado_de_Disponibilidad ='OCUPADO'", conexion)

            daListarpresentacionesagregadas.Fill(dtDATALISTADO_AGREGANDO)
            DATALISTADO_PRODUCTOS_OKA.DataSource = dtDATALISTADO_AGREGANDO

            Cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub MOSTRAR_ESTADO_LIBRE_MESAS()
        Dim dtDATALISTADO_AGREGANDO As New DataTable
        Dim daListarpresentacionesagregadas As SqlDataAdapter
        Try
            abrir()
            daListarpresentacionesagregadas = New SqlDataAdapter("SELECT Estado_de_Disponibilidad,Id_mesa   FROM Mesas where Estado_de_Disponibilidad ='LIBRE'", conexion)

            daListarpresentacionesagregadas.Fill(dtDATALISTADO_AGREGANDO)
            DATALISTADO_PRODUCTOS_OKA_libre.DataSource = dtDATALISTADO_AGREGANDO

            Cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Sub Dibujar_estado_De_mesas_OCUPADAS_en_vivo()
        'Dim NOMBRE As String = DirectCast(sender, Button).Name
        MOSTRAR_ESTADO_OCUPADO_MESAS()
        'For Each fila As DataGridViewRow In DATALISTADO_PRODUCTOS_OKA.Rows
        '    fila.Cells(0).Value = True
        'Next
        Dim idmesaDATAGRID As Integer
        For Each row As DataGridViewRow In DATALISTADO_PRODUCTOS_OKA.Rows
            idmesaDATAGRID = Convert.ToInt32(row.Cells("Id_mesa").Value)
            For Each panelC2 In PanelMesas.Controls
                If TypeOf panelC2 Is Button Then
                    Dim idmesaDIBUJADO As String
                    idmesaDIBUJADO = panelC2.name
                    'idmesaDIBUJADO = panelC2.Equals("Name")
                    'DataGridView1.DataSource = idmesaDIBUJADO
                    'ComboBox1.Items.Add(idmesaDIBUJADO)
                    If idmesaDIBUJADO = idmesaDATAGRID Then
                        panelC2.BackColor = Color.Firebrick
                        Exit For
                        Exit For
                        'ElseIf panelC2.name <> idmesaDATAGRID
                        '    panelC2.BackColor = Color.FromArgb(5, 179, 90)
                    End If
                    TextBox1.Text = idmesaDIBUJADO
                End If

            Next
        Next
        'Next
        'id_mesaOk = DirectCast(panelC2, Button).Name

        'Next

    End Sub
    Sub Dibujar_estado_De_mesas_LIBRES_en_vivo()
        'Dim NOMBRE As String = DirectCast(sender, Button).Name
        MOSTRAR_ESTADO_LIBRE_MESAS()
        'For Each fila As DataGridViewRow In DATALISTADO_PRODUCTOS_OKA.Rows
        '    fila.Cells(0).Value = True
        'Next
        Dim idmesaDATAGRID As Integer
        For Each row As DataGridViewRow In DATALISTADO_PRODUCTOS_OKA_libre.Rows
            idmesaDATAGRID = Convert.ToInt32(row.Cells("Id_mesa").Value)
            For Each panelC2 In PanelMesas.Controls
                If TypeOf panelC2 Is Button Then
                    Dim idmesaDIBUJADO As String
                    idmesaDIBUJADO = panelC2.name
                    'idmesaDIBUJADO = panelC2.Equals("Name")
                    'DataGridView1.DataSource = idmesaDIBUJADO
                    'ComboBox1.Items.Add(idmesaDIBUJADO)
                    If idmesaDIBUJADO = idmesaDATAGRID Then
                        panelC2.BackColor = Color.FromArgb(5, 179, 90)
                        Exit For
                        Exit For
                        'ElseIf panelC2.name <> idmesaDATAGRID
                        '    panelC2.BackColor = Color.FromArgb(5, 179, 90)
                    End If
                    TextBox2.Text = idmesaDIBUJADO
                End If

            Next
        Next
        'Next
        'id_mesaOk = DirectCast(panelC2, Button).Name

        'Next

    End Sub



    Sub ocultar_panel_configuraciones()

        PanelHerramientasC.Visible = False
        PanelConfiguracionesVER.Visible = False
        Estado_de_herramientas = 0


    End Sub
    Sub mostrar_Formulario_en_panel()
        ocultar_panel_configuraciones()
        PanelSalones.Visible = False
        PanelMesas.Visible = False
        PanelBienvenida.Visible = False

        Punto_de_venta.TopLevel = False
        Punto_de_venta.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        panel_PARA_MOSTRAR_FORMULARIOS.Controls.Add(Punto_de_venta)
        Punto_de_venta.Show()

    End Sub
    Sub Ocultar_formulario_en_panel()
        PanelSalones.Visible = True
        PanelMesas.Visible = True
        panel_PARA_MOSTRAR_FORMULARIOS.Controls.Remove(Punto_de_venta)
        Punto_de_venta.Dispose()
    End Sub

    Sub MOSTRAR_ESTADO_DE_MESA()


        Dim importe As String
        Dim com As New SqlCommand("mostrar_estado_de_mesa", conexion)
        com.CommandType = 4
        com.Parameters.AddWithValue("@idmesa", idmesa)
        Try
            abrir()
            estado_de_mesa = (com.ExecuteScalar())
            Cerrar()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub miEvento_buton_mesa(ByVal sender As System.Object, ByVal e As EventArgs)

        If Union_de_mesas = "INACTIVO" Then
            Try
                idmesa = DirectCast(sender, Button).Name
                nombre_mesa = DirectCast(sender, Button).Text

                mostrar_Formulario_en_panel()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf Union_de_mesas = "ACTIVADO" Then
            Timer1.Stop()
            idmesa = DirectCast(sender, Button).Name
            MOSTRAR_ESTADO_DE_MESA()
            If estado_de_mesa = "OCUPADO" Then
                Paso += 1
                Label1.Text = "PASO 2 

                Seleccione la Mesa de Destino"
                txtpaso.Text = Paso
                If Paso = 1 Then
                    idmesa_Origen = idmesa
                    mostrar_id_venta_por_mesa_ORIGEN()
                End If
                For Each panelC1 In PanelMesas.Controls
                    If TypeOf panelC1 Is Button Then
                        If panelC1.Name = idmesa Then
                            panelC1.BackColor = Color.FromArgb(20, 20, 20)
                        End If
                    End If
                Next
                If Paso = 2 Then
                    idmesa_Destino = idmesa
                    Terminar_cambio_de_mesa()
                    mostrar_id_venta_por_mesa_DESTINO()
                    Editar_detalle_venta_para_cambio_De_mesa()
                    Cambio_de_Estado_de_mesa_de_origen()
                    Timer1.Start()
                    Paso = 0
                End If
            ElseIf estado_de_mesa = "LIBRE" And Paso = 1 Then
                Paso += 1
                txtpaso.Text = Paso

                If Paso = 2 Then
                    idmesa_Destino = idmesa
                    Terminar_cambio_de_mesa()
                    editar_mesa_en_la_tabla_ventas()
                    Cambio_de_Estado_de_mesa_de_origen()
                    Cambio_de_Estado_de_mesa_de_DESTINO()
                    Timer1.Start()
                    Paso = 0
                End If
            End If
        End If
    End Sub


    Sub mostrar_id_venta_por_mesa_ORIGEN()
        Dim com As New SqlCommand("mostrar_id_venta_por_mesa_ORIGEN", conexion)
        com.CommandType = 4
        com.Parameters.AddWithValue("@idmesa", idmesa_Origen)
        Try
            abrir()
            id_venta_mesa_origen = (com.ExecuteScalar())
            Cerrar()
        Catch ex As Exception
            MessageBox.Show("fallo mostrar_id_venta_por_mesa_ORIGEN")

        End Try
    End Sub
    Sub mostrar_id_venta_por_mesa_DESTINO()
        Dim com As New SqlCommand("mostrar_id_venta_por_mesa_DESTINO", conexion)
        com.CommandType = 4
        com.Parameters.AddWithValue("@idmesa", idmesa_Destino)
        Try
            abrir()
            id_venta_mesa_destino = (com.ExecuteScalar())
            Cerrar()
        Catch ex As Exception
            MessageBox.Show("mostrar_id_venta_por_mesa_DESTINO")
        End Try
    End Sub
    Sub Editar_detalle_venta_para_cambio_De_mesa()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("Editar_detalle_venta_para_cambio_De_mesa", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@id_venta_destino", id_venta_mesa_destino)
            cmd.Parameters.AddWithValue("@id_venta_origen", id_venta_mesa_origen)

            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub editar_mesa_en_la_tabla_ventas()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("editar_mesa_en_la_tabla_ventas", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_mesa", idmesa_Destino)
            cmd.Parameters.AddWithValue("@Idventa", id_venta_mesa_origen)

            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            MsgBox("editar_mesa_en_la_tabla_ventas")
        End Try
    End Sub
    Sub Cambio_de_Estado_de_mesa_de_origen()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("Cambio_de_mesa_a_otra", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Idmesa", idmesa_Origen)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            MsgBox("Cambio_de_Estado_de_mesa_de_origen")
        End Try
    End Sub
    Sub Cambio_de_Estado_de_mesa_de_DESTINO()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("Cambio_de_mesa_a_otra_DESTINO_OCUPADO", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Idmesa", idmesa_Destino)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            MsgBox("Cambio_de_Estado_de_mesa_de_DESTINO")
        End Try
    End Sub
    Sub editar_estado_de_mesa_a_ocupado()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("Editar_estado_de_mesa_a_OCUPADO", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Idmesa", idmesa)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Visor_de_mesas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

        mostrar_Formulario_en_panel()

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dibujar_estado_De_mesas_OCUPADAS_en_vivo()
        Dibujar_estado_De_mesas_LIBRES_en_vivo()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dibujar_estado_De_mesas_OCUPADAS_en_vivo()
        Dibujar_estado_De_mesas_LIBRES_en_vivo()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'PanelMesas.BackColor = Color.FromArgb(20, 20, 20)
        Panelbotones.Visible = False
        PanelUNIONMesas.Visible = True
        PanelUNIONMesas.Dock = DockStyle.Fill
        FlowLayoutPanel1.Visible = False
        Union_de_mesas = "ACTIVADO"
        Label1.Text = "PASO 1 Seleccione una mesa de Origen"
        Paso = 0
    End Sub
    Sub Terminar_cambio_de_mesa()
        PanelMesas.BackColor = Color.Black
        Panelbotones.Visible = True
        PanelUNIONMesas.Visible = False
        PanelUNIONMesas.Dock = DockStyle.None
        FlowLayoutPanel1.Visible = True
        Union_de_mesas = "INACTIVO"
        Paso = 0
        Timer1.Start()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Terminar_cambio_de_mesa()
    End Sub

    Private Sub panel_PARA_MOSTRAR_FORMULARIOS_Paint(sender As Object, e As PaintEventArgs) Handles panel_PARA_MOSTRAR_FORMULARIOS.Paint

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btndelibery.Click

    End Sub

    Private Sub btnHerramientas_Click(sender As Object, e As EventArgs) Handles btnHerramientas.Click
        dibujar_panel_configuraciones()
    End Sub
    Sub dibujar_panel_configuraciones()
        If Estado_de_herramientas = 1 Then
            PanelHerramientasC.Visible = False
            PanelConfiguracionesVER.Visible = False
            Estado_de_herramientas = 0
        ElseIf Estado_de_herramientas = 0 Then
            PanelConfiguracionesVER.Visible = True
            PanelConfiguracionesVER.Size = New System.Drawing.Size(700, 125)
            PanelConfiguracionesVER.Location = New Point(Panel3.Location.X, Panelbotones.Location.Y + btnHerramientas.Location.Y)
            PanelHerramientasC.Dock = DockStyle.Fill
            PanelConfiguracionesVER.Controls.Add(PanelHerramientasC)
            Me.Controls.Add(PanelConfiguracionesVER)
            PanelHerramientasC.Visible = True
            PanelConfiguracionesVER.BringToFront()
            Estado_de_herramientas = 1
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click

    End Sub

    Private Sub btnadministrar_Click(sender As Object, e As EventArgs) Handles btnadministrar.Click
        Dispose()
        Menu_de_configuraciones.Formulario_de_llamado = "Visor de mesas"
        Menu_de_configuraciones.ShowDialog()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub BtnCambiomesa_Click(sender As Object, e As EventArgs) Handles btnCambiomesa.Click

    End Sub
End Class