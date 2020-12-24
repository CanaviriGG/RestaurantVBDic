Imports System.Data.SqlClient
Public Class Mostrador_de_productos
    Public idproducto As Integer
    Dim cantidad_de_productos As Integer
    Public precio_de_venta As Double
    Private Sub Mostrador_de_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dibujarProductos()
        contar_cantidad_de_productos()

    End Sub


    Sub contar_cantidad_de_productos()
        Try
            Dim com As New SqlCommand("contar_productos_por_grupo", conexion)
            com.CommandType = 4
            com.Parameters.AddWithValue("@idgrupo", Punto_de_venta.id_grupo)
            Try
                abrir()
                cantidad_de_productos = (com.ExecuteScalar())
                Cerrar()

            Catch ex As Exception
                cantidad_de_productos = 0
            End Try
        Catch ex As Exception

        End Try
    End Sub
    Sub dibujarProductos()
        PanelProductos.Controls.Clear()

        Try
            abrir()
            Dim query As String = "paginar_Productos_por_grupo"
            Dim cmd As New SqlCommand(query, conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@id_grupo", Punto_de_venta.id_grupo)
            cmd.Parameters.AddWithValue("@Desde", paginaInicio.Text)
            cmd.Parameters.AddWithValue("@Hasta", paginaMaxima.Text)
            Dim rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read()
                Dim b As New Label
                Dim p1 As New Panel
                Dim I1 As New PictureBox
                b.Text = rdr("Descripcion").ToString()
                b.Name = rdr("Id_Producto1").ToString()
                b.Tag = rdr("Precio_de_venta").ToString()
                b.Size = New System.Drawing.Size(119, 20)
                b.Font = New System.Drawing.Font("Microsoft Sans Serif", 7, FontStyle.Regular Or
      FontStyle.Bold)
                b.BackColor = Color.Transparent
                b.ForeColor = Color.White
                b.Dock = DockStyle.Fill
                b.TextAlign = ContentAlignment.MiddleCenter
                b.Cursor = Cursors.Hand

                p1.Size = New System.Drawing.Size(147, 75)
                p1.BorderStyle = BorderStyle.None
                p1.Dock = DockStyle.Bottom
                p1.BackColor = Color.Transparent
                p1.BackgroundImage = My.Resources.azul
                p1.BackgroundImageLayout = BackgroundImageLayout.Stretch

                I1.Size = New System.Drawing.Size(140, 42)
                I1.Dock = DockStyle.Top
                Dim bi() As Byte = rdr("Imagen")
                Dim ms As New IO.MemoryStream(bi)
                I1.Image = Image.FromStream(ms)
                I1.SizeMode = PictureBoxSizeMode.Zoom
                I1.Cursor = Cursors.Hand
                I1.Tag = rdr("Precio_de_venta").ToString()
                I1.Name = rdr("Id_Producto1").ToString()
                I1.BackColor = Color.Transparent

                p1.Controls.Add(b)
                If rdr("Estado_imagen").ToString() <> "VACIO" Then
                    p1.Controls.Add(I1)
                End If
                b.BringToFront()
                PanelProductos.Controls.Add(p1)
                AddHandler b.Click, AddressOf miEventoLabel_PRODUCTO
                AddHandler I1.Click, AddressOf miEventoImagen_PRODUCTO

            End While
            Cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub miEventoImagen_PRODUCTO(sender As Object, e As EventArgs)
        Try
            idproducto = DirectCast(sender, PictureBox).Name
            precio_de_venta = DirectCast(sender, Label).Tag
            Punto_de_venta.insertar_venta()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub miEventoLabel_PRODUCTO(sender As Object, e As EventArgs)
        Try
            idproducto = DirectCast(sender, Label).Name
            precio_de_venta = DirectCast(sender, Label).Tag
            Punto_de_venta.insertar_venta()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnadelante_Click(sender As Object, e As EventArgs) Handles btnadelante.Click
        contar_cantidad_de_productos()
        If cantidad_de_productos > paginaMaxima.Text Then
            paginaInicio.Text += 15
            paginaMaxima.Text += 15
            dibujarProductos()
        End If

    End Sub

    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnatras.Click

        If paginaInicio.Text > 1 Then
            paginaInicio.Text -= 15
            paginaMaxima.Text -= 15
            dibujarProductos()
        End If
    End Sub
End Class