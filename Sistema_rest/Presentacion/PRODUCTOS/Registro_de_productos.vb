Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Data.SqlClient
Imports System.Management
Public Class Registro_de_productos
    Private Sub Label38_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem19_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtdescripcion_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtdescripcion_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnGenerarCodigo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem11_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub TimerCalcular_precio_venta_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Registro_de_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CO")
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","

        txtdescripcion.AutoCompleteCustomSource = DataHelper.LoadAutoComplete
        txtdescripcion.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtdescripcion.AutoCompleteSource = AutoCompleteSource.CustomSource
        indicador = "Apagado"
        lblindiscador.Text = indicador
        PANELINVENTARIO.Size = New System.Drawing.Size(0, 105)
        ESTADO_IMAGEN = "VACIO"
    End Sub
    Dim ESTADO_IMAGEN As String

    Private Sub Registro_de_productos_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If indicador = "Apagado" Then
            Timer1.Start()
        ElseIf indicador = "Encendido" Then
            Timer2.Start()
        End If
        lblindiscador.Text = indicador



    End Sub

    Private Sub PictureBox2_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox2.Paint


        Dim figura As GraphicsPath = New GraphicsPath
        Dim x, y, ancho, alto As Integer
        ancho = 30
        alto = 30
        x = (PictureBox2.Width - ancho) / 2
        y = (PictureBox2.Height - alto) / 2
        figura.AddEllipse(New Rectangle(x, y, ancho, alto))
        PictureBox2.Region = New Region(figura)

    End Sub

    Private Sub Encendido_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
    'Dim x As Integer = 0
    Dim xActual As Integer
    Dim xmovimiento As Integer
    Dim indicador As String
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        xActual = PictureBox2.Location.X
        Timer4.Start()
        xmovimiento = (xActual - 5)
        lblActual.Text = xmovimiento
        lblNuevo.Text = PictureBox1.Location.X - 22
        PictureBox2.Location = New Point(xmovimiento, PictureBox2.Location.Y)
        If PictureBox2.Location.X < (PictureBox1.Location.X - 22) Then
            Timer1.Stop()
            PictureBox2.BackColor = Color.FromArgb(20, 20, 20)
            indicador = "Encendido"
        End If



    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        xActual = PictureBox2.Location.X
        xmovimiento = (xActual + 5)
        lblActual.Text = xmovimiento
        lblNuevo.Text = PictureBox1.Location.X + 22
        PictureBox2.Location = New Point(xmovimiento, PictureBox2.Location.Y)


        If PictureBox2.Location.X > (PictureBox1.Location.X + 22) Then
            Timer2.Stop()
            PictureBox2.BackColor = Color.DodgerBlue
            indicador = "Apagado"
            Timer3.Start()

        End If



    End Sub
    Dim tamañoPanelInventario As Integer
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        tamañoPanelInventario += 40
        PANELINVENTARIO.Size = New System.Drawing.Size(tamañoPanelInventario, 105)
        If tamañoPanelInventario > 465 Then
            Timer3.Stop()
        End If
    End Sub

    Private Sub PANELDEPARTAMENTO_Paint(sender As Object, e As PaintEventArgs) Handles PANELDEPARTAMENTO.Paint

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        tamañoPanelInventario -= 40
        PANELINVENTARIO.Size = New System.Drawing.Size(tamañoPanelInventario, 105)
        If tamañoPanelInventario <= 0 Then
            Timer4.Stop()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Dispose()
    End Sub
    Sub destruir()
        Productos_rest.destruir_sub_formularios()

    End Sub
    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Productos_rest.destruir_sub_formularios()
    End Sub

    Dim contador As Integer

    Private Sub txtdescripcion_TextChanged_1(sender As Object, e As EventArgs) Handles txtdescripcion.TextChanged
        'mostrar_descripcion_producto_sin_repetir()
        'contar()
        'If contador = 0 Then
        '    DATALISTADO_PRODUCTOS_OKA.Visible = False
        'End If
        'If contador > 0 Then
        '    DATALISTADO_PRODUCTOS_OKA.Visible = True
        'End If
        'If BtnGuardar.Visible = False Then
        '    DATALISTADO_PRODUCTOS_OKA.Visible = False
        'End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If txtdescripcion.Text <> "" Then
            If TXTPRECIODEVENTA.Text <> "" Then
                insertar_producto()

            Else

            End If
        Else

        End If
    End Sub
    Sub insertar_producto()
        Dim CMD As SqlCommand
        Try
            abrir()

            CMD = New SqlCommand("insertar_Producto", conexion)
            CMD.CommandType = 4
            CMD.Parameters.AddWithValue("@Descripcion", txtdescripcion.Text)

            Dim ms As New IO.MemoryStream()
            ImagenGrupo.Image.Save(ms, ImagenGrupo.Image.RawFormat)
            CMD.Parameters.AddWithValue("@Imagen", ms.GetBuffer)

            CMD.Parameters.AddWithValue("@Precio_de_venta", TXTPRECIODEVENTA.Text)
            CMD.Parameters.AddWithValue("@Id_grupo", Productos_rest.id_grupo)
            CMD.Parameters.AddWithValue("@Estado_imagen", ESTADO_IMAGEN)
            CMD.ExecuteNonQuery()
            Cerrar()

            Productos_rest.dibujarProductos()
            Productos_rest.destruir_sub_formularios()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub agregar_imagen()

        With dlg
            .InitialDirectory = ""
            .Filter = "Imagenes|*.jpg;*.png"
            .FilterIndex = 2
            .Title = "Cargador de Imagenes ADA 369"

        End With
        If dlg.ShowDialog() = DialogResult.OK Then
            ImagenGrupo.BackgroundImage = Nothing
            ImagenGrupo.Image = New Bitmap(dlg.FileName)
            ImagenGrupo.SizeMode = PictureBoxSizeMode.Zoom
            Panel5.Visible = False
            ESTADO_IMAGEN = "LLENO"
        End If

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        agregar_imagen()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        agregar_imagen()
    End Sub

    Private Sub TXTPRECIODEVENTA_TextChanged(sender As Object, e As EventArgs) Handles TXTPRECIODEVENTA.TextChanged

    End Sub

    Private Sub TXTPRECIODEVENTA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTPRECIODEVENTA.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then

            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)
        End If
        Separador_de_Numeros(TXTPRECIODEVENTA, e)
    End Sub

    Private Sub DATALISTADO_PRODUCTOS_OKA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub
End Class