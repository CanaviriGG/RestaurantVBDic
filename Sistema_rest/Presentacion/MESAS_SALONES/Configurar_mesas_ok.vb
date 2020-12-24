Imports System.Data.SqlClient
Public Class Configurar_mesas_ok
    Private Sub Configurar_mesas_ok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dibujarSalones()
        PanelBienvienida.Visible = True
        PanelBienvienida.Dock = DockStyle.Fill
        PanelMesas.Visible = False
        PanelMesas.Dock = DockStyle.None


    End Sub

    Sub dibujarMESAS()
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
                Dim alto As Integer = rdr("y").ToString()
                Dim ancho As Integer = rdr("x").ToString()
                Dim tamanio_letra As Integer = rdr("Tamanio_letra").ToString()

                Dim tamanio As Point = New Point(ancho, alto)

                panel.BackgroundImage = My.Resources.mesa_vacia
                panel.BackgroundImageLayout = ImageLayout.Zoom
                panel.Cursor = Cursors.Hand
                panel.Tag = rdr("Id_mesa").ToString()

                b.Text = rdr("Mesa").ToString()
                b.Name = rdr("Id_mesa").ToString()


                panel.Size = New System.Drawing.Size(tamanio)

                If b.Text <> "NULO" Then
                    b.Size = New System.Drawing.Size(tamanio)

                    b.BackColor = Color.FromArgb(5, 179, 90)

                    b.Font = New System.Drawing.Font(10, tamanio_letra)

                    b.FlatStyle = FlatStyle.Flat
                    b.FlatAppearance.BorderSize = 0
                    b.ForeColor = Color.White
                    PanelMesas.Controls.Add(b)
                Else
                    PanelMesas.Controls.Add(panel)
                End If
                AddHandler panel.Click, AddressOf miEventopanel_click
                AddHandler b.Click, AddressOf miEvento
            End While
            Cerrar()
        Catch ex As Exception
            Cerrar()
        End Try

    End Sub
    Public idmesa As Integer
    Public nombre_mesa As String
    Private Sub miEvento(ByVal sender As System.Object, ByVal e As EventArgs)
        Try
            nombre_mesa = DirectCast(sender, Button).Text
            idmesa = DirectCast(sender, Button).Name

            Agregar_mesa_ok.txtmesaedicion.Text = nombre_mesa
            Agregar_mesa_ok.Timer1.Start()
            Agregar_mesa_ok.ShowDialog()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub miEventopanel_click(ByVal sender As System.Object, ByVal e As EventArgs)
        Try
            idmesa = DirectCast(sender, Panel).Tag

            Agregar_mesa_ok.txtmesaedicion.Clear()
            Agregar_mesa_ok.Timer1.Start()
            Agregar_mesa_ok.ShowDialog()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub dibujarSalones()
        FlowLayoutPanel1.Controls.Clear()
        Try
            abrir()
            Dim query As String = "mostrar_SALON"
            Dim cmd As New SqlCommand(query, conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@buscar", txtsalon.Text)
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
    Dim id_salon As Integer
    Dim estado As String
    Private Sub miEvento_salon_button(ByVal sender As System.Object, ByVal e As EventArgs)

        Try


            PanelBienvienida.Visible = False
            PanelBienvienida.Dock = DockStyle.None
            PanelMesas.Visible = True
            PanelMesas.Dock = DockStyle.Fill



            id_salon = DirectCast(sender, Button).Name
            estado = DirectCast(sender, Button).Tag
            If estado = "ELIMINADO" Then
                Dim pregunta As DialogResult
                pregunta = MessageBox.Show("¿Realmente desea Restaurar este Salon?", "Restauracion de Salon", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If pregunta = DialogResult.OK Then
                    Restaurar_salon()
                End If

            Else
                dibujarMESAS()
            End If

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

    Private Sub btnNuevoGrupo_Click(sender As Object, e As EventArgs) Handles btnNuevoGrupo.Click
        Salones.ShowDialog()

    End Sub

    Private Sub txtsalon_TextChanged(sender As Object, e As EventArgs) Handles txtsalon.TextChanged
        dibujarSalones()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        lblmedidaFlow2.Text = "Ancho=" & PanelMesas.Size.Width & "alto= " & PanelMesas.Size.Height


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
    Sub aumentar_tamaño_mesa()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("aumentar_tamanio_mesa", conexion)
            cmd.ExecuteNonQuery()
            Cerrar()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub disminuir_tamaño_mesa()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("disminuir_tamanio_mesa", conexion)
            cmd.ExecuteNonQuery()
            Cerrar()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        aumentar_tamaño_mesa()
        dibujarMESAS()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        disminuir_tamaño_mesa()
        dibujarMESAS()

    End Sub
    Sub aumentar_tamanio_letra()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("aumentar_tamanio_letra", conexion)

            cmd.ExecuteNonQuery()
            Cerrar()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub disminuir_tamanio_letra()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("disminuir_tamanio_letra", conexion)

            cmd.ExecuteNonQuery()
            Cerrar()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        aumentar_tamanio_letra()
        dibujarMESAS()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        disminuir_tamanio_letra()
        dibujarMESAS()
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub FlowLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles PanelMesas.Paint

    End Sub
    Sub eliminar_salon()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("eliminar_salon", conexion)
            cmd.CommandType = 4

            cmd.Parameters.AddWithValue("@id_salon", id_salon)

            cmd.ExecuteNonQuery()
            Cerrar()
            dibujarSalones()
            id_salon = 0
            dibujarMESAS()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Restaurar_salon()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("restaurar_salon", conexion)
            cmd.CommandType = 4

            cmd.Parameters.AddWithValue("@id_salon", id_salon)

            cmd.ExecuteNonQuery()
            Cerrar()
            dibujarSalones()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BTNEliminar_Click(sender As Object, e As EventArgs) Handles BTNEliminar.Click
        eliminar_salon()

    End Sub


End Class