Imports System.Data.SqlClient

Public Class Productos_rest
    Private Sub Productos_rest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dibujarGrupos()
        PanelBienvienida.Visible = True
        PanelBienvienida.Dock = DockStyle.Fill

    End Sub

    Sub destruir_sub_formularios()
        Registro_de_productos.Dispose()
        Grupos_De_productos.Dispose()

        TopMost = True
        TopMost = False

    End Sub
    Sub dibujarGrupos()
        Panel_grupos.Controls.Clear()

        Try

            abrir()
            Dim query As String = "select * from Grupo_de_Productos"
            Dim cmd As New SqlCommand(query, conexion)
            Dim rdr As SqlDataReader = cmd.ExecuteReader()

            While rdr.Read()

                Dim b As New Label
                Dim p1 As New Panel
                Dim p2 As New Panel
                Dim I1 As New PictureBox

                b.Text = rdr("Grupo").ToString()
                b.Name = rdr("Idline").ToString()



                b.Size = New System.Drawing.Size(119, 25)
                b.Font = New System.Drawing.Font(10, 13)


                b.BackColor = Color.Transparent
                b.ForeColor = Color.White
                b.Dock = DockStyle.Fill
                b.TextAlign = ContentAlignment.MiddleCenter
                b.Cursor = Cursors.Hand



                p1.Size = New System.Drawing.Size(140, 133)
                p1.BorderStyle = BorderStyle.FixedSingle
                p1.Dock = DockStyle.Bottom
                p1.BackColor = Color.FromArgb(43, 43, 43)
                p1.Name = rdr("Idline").ToString()

                p2.Size = New System.Drawing.Size(140, 25)
                p2.Dock = DockStyle.Top
                p2.BackColor = Color.Transparent
                p2.BorderStyle = BorderStyle.None

                'P2.Size = New System.Drawing.Size(246, 22)
                'P2.Dock = DockStyle.Top
                'P2.BackColor = Color.FromArgb(r.[Next](0, 255), r.[Next](0, 255), r.[Next](0, 255))

                I1.Size = New System.Drawing.Size(140, 76)
                I1.Dock = DockStyle.Top
                I1.BackgroundImage = Nothing
                Dim bi() As Byte = rdr("Icono")
                Dim ms As New IO.MemoryStream(bi)
                I1.Image = Image.FromStream(ms)
                I1.SizeMode = PictureBoxSizeMode.Zoom
                I1.Cursor = Cursors.Hand
                I1.Tag = rdr("Idline").ToString()





                'pendiente de explicacion
                Dim Menustrip As New MenuStrip
                Menustrip.BackColor = Color.Transparent
                Menustrip.AutoSize = False
                Menustrip.Size = New System.Drawing.Size(28, 24)
                Menustrip.Dock = DockStyle.Right
                Menustrip.Name = rdr("Idline").ToString()
                Dim ToolStripPRINCIPAL As New ToolStripMenuItem
                Dim ToolStripEDITAR As New ToolStripMenuItem
                Dim ToolStripELIMINAR As New ToolStripMenuItem
                Dim ToolStripRESTAURAR As New ToolStripMenuItem

                ToolStripPRINCIPAL.Image = My.Resources.menuCajas_claro
                ToolStripPRINCIPAL.BackColor = Color.Transparent
                ToolStripEDITAR.Text = "Editar"
                ToolStripEDITAR.Name = rdr("Grupo").ToString()
                ToolStripEDITAR.Tag = rdr("Idline").ToString()

                ToolStripELIMINAR.Text = "Eliminar"
                ToolStripELIMINAR.Tag = rdr("Idline").ToString()

                ToolStripRESTAURAR.Text = "Restaurar"
                ToolStripRESTAURAR.Tag = rdr("Idline").ToString()


                Menustrip.Items.Add(ToolStripPRINCIPAL)
                ToolStripPRINCIPAL.DropDownItems.Add(ToolStripEDITAR)
                ToolStripPRINCIPAL.DropDownItems.Add(ToolStripELIMINAR)
                ToolStripPRINCIPAL.DropDownItems.Add(ToolStripRESTAURAR)

                p2.Controls.Add(Menustrip)





                p1.Controls.Add(b)
                If rdr("Estado_de_icono").ToString() <> "VACIO" Then
                    p1.Controls.Add(I1)
                End If
                p1.Controls.Add(p2)

                'p1.Controls.Add(P3)
                'P2.SendToBack()
                b.BringToFront()
                'I1.SendToBack()
                p2.SendToBack()
                'P3.SendToBack()
                Panel_grupos.Controls.Add(p1)

                AddHandler b.Click, AddressOf miEventoLabel

                AddHandler I1.Click, AddressOf miEventoImagen

            End While
            Cerrar()
        Catch ex As Exception

        End Try

    End Sub

    Sub dibujarProductos()
        PanelProductos.Controls.Clear()
        Try

            abrir()
            Dim query As String = "mostrar_Productos_por_grupo"
            Dim cmd As New SqlCommand(query, conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@id_grupo", id_grupo)
            Dim rdr As SqlDataReader = cmd.ExecuteReader()

            While rdr.Read()

                Dim b As New Label
                Dim p1 As New Panel
                Dim p2 As New Panel
                Dim I1 As New PictureBox

                b.Text = rdr("Descripcion").ToString()
                b.Name = rdr("Id_Producto1").ToString()



                b.Size = New System.Drawing.Size(119, 25)
                b.Font = New System.Drawing.Font(10, 13)


                b.BackColor = Color.Transparent
                b.ForeColor = Color.White
                b.Dock = DockStyle.Fill
                b.TextAlign = ContentAlignment.MiddleCenter
                b.Cursor = Cursors.Hand



                p1.Size = New System.Drawing.Size(140, 133)
                p1.BorderStyle = BorderStyle.FixedSingle
                p1.Dock = DockStyle.Bottom
                p1.BackColor = Color.FromArgb(43, 43, 43)

                p2.Size = New System.Drawing.Size(140, 25)
                p2.Dock = DockStyle.Top
                p2.BackColor = Color.Transparent
                p2.BorderStyle = BorderStyle.None

                'P2.Size = New System.Drawing.Size(246, 22)
                'P2.Dock = DockStyle.Top
                'P2.BackColor = Color.FromArgb(r.[Next](0, 255), r.[Next](0, 255), r.[Next](0, 255))




                I1.Size = New System.Drawing.Size(140, 76)
                I1.Dock = DockStyle.Top
                I1.BackgroundImage = Nothing
                Dim bi() As Byte = rdr("Imagen")
                Dim ms As New IO.MemoryStream(bi)
                I1.Image = Image.FromStream(ms)
                I1.SizeMode = PictureBoxSizeMode.Zoom
                I1.Cursor = Cursors.Hand
                I1.Tag = rdr("Id_Producto1").ToString()



                'pendiente de explicacion
                Dim Menustrip As New MenuStrip
                Menustrip.BackColor = Color.Transparent
                Menustrip.AutoSize = False
                Menustrip.Size = New System.Drawing.Size(28, 24)
                Menustrip.Dock = DockStyle.Right
                Menustrip.Name = rdr("Id_Producto1").ToString()
                Dim ToolStripPRINCIPAL As New ToolStripMenuItem
                Dim ToolStripEDITAR As New ToolStripMenuItem
                Dim ToolStripELIMINAR As New ToolStripMenuItem
                Dim ToolStripRESTAURAR As New ToolStripMenuItem

                ToolStripPRINCIPAL.Image = My.Resources.menuCajas_claro
                ToolStripPRINCIPAL.BackColor = Color.Transparent
                ToolStripEDITAR.Text = "Editar"
                ToolStripEDITAR.Name = rdr("Descripcion").ToString()
                ToolStripEDITAR.Tag = rdr("Id_Producto1").ToString()

                ToolStripELIMINAR.Text = "Eliminar"
                ToolStripELIMINAR.Tag = rdr("Id_Producto1").ToString()

                ToolStripRESTAURAR.Text = "Restaurar"
                ToolStripRESTAURAR.Tag = rdr("Id_Producto1").ToString()


                Menustrip.Items.Add(ToolStripPRINCIPAL)
                ToolStripPRINCIPAL.DropDownItems.Add(ToolStripEDITAR)
                ToolStripPRINCIPAL.DropDownItems.Add(ToolStripELIMINAR)
                ToolStripPRINCIPAL.DropDownItems.Add(ToolStripRESTAURAR)

                p2.Controls.Add(Menustrip)





                p1.Controls.Add(b)
                If rdr("Estado_imagen").ToString() <> "VACIO" Then
                    p1.Controls.Add(I1)
                End If
                p1.Controls.Add(p2)

                'p1.Controls.Add(P3)
                'P2.SendToBack()
                b.BringToFront()
                'I1.SendToBack()
                p2.SendToBack()
                'P3.SendToBack()
                PanelProductos.Controls.Add(p1)

                ''AddHandler b.Click, AddressOf miEventoLabel

                ''AddHandler I1.Click, AddressOf miEventoImagen

            End While
            Cerrar()
        Catch ex As Exception
            Cerrar()
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub miEventoLabel(ByVal sender As Object, ByVal e As EventArgs)
        Try
            id_grupo = DirectCast(sender, Label).Name
            ver_productos_por_grupo()
            Seleccionar_Deseleccionar_grupos()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public id_grupo As Integer
    Sub ver_productos_por_grupo()
        PanelBienvienida.Visible = False
        Panel10.Visible = True
        Panel10.Dock = DockStyle.Fill
        Panel7.Dock = DockStyle.Fill
        dibujarProductos()

    End Sub
    Private Sub miEventoImagen(ByVal sender As System.Object, ByVal e As EventArgs)
        Try
            id_grupo = DirectCast(sender, PictureBox).Tag
            ver_productos_por_grupo()
            Seleccionar_Deseleccionar_grupos()
        Catch ex As Exception
        End Try
    End Sub
    Sub Seleccionar_Deseleccionar_grupos()
        Try
            'sin Seleccionar 
            For Each panelP1 In Panel_grupos.Controls
                If TypeOf panelP1 Is Panel Then
                    For Each PanLateral2 In panelP1.controls
                        If TypeOf PanLateral2 Is Panel Then
                            panelP1.Backcolor = Color.FromArgb(43, 43, 43)
                            Exit For
                            Exit For
                        End If
                    Next
                End If
            Next

            'Seleccionado

            For Each PanelP2 In Panel_grupos.Controls
                If TypeOf PanelP2 Is Panel Then
                    For Each PanelLateral In PanelP2.Controls
                        If TypeOf PanelLateral Is Panel Then
                            If PanelP2.name = id_grupo Then
                                PanelP2.Backcolor = Color.Black
                            End If
                        End If
                    Next
                End If

            Next


        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        Registro_de_productos.ShowDialog()

    End Sub



    Private Sub BTNEliminar_Click(sender As Object, e As EventArgs) Handles BTNEliminar.Click
        Grupos_De_productos.ShowDialog()
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs)
        For Each controlll As Control In Panel_grupos.Controls
            Dim marcado As String = Convert.ToString(controlll.Controls(DirectCast(sender, Label).Text))

            'txtlogin.Text = DirectCast(sender, Label).Text

            MsgBox(marcado)
            'If controlll.Name = 1 Then
            '    controlll.BackColor = Color.AliceBlue
            'End If
        Next
    End Sub

End Class