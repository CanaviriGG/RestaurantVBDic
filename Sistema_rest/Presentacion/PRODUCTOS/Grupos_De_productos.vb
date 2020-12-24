Imports System.Data.SqlClient
Public Class Grupos_De_productos
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        agregar_imagen()
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
            Panel1.Visible = False
            ESTADO_IMAGEN = "LLENO"
        End If

    End Sub

    Private Sub Imagenproducto_Click(sender As Object, e As EventArgs) Handles ImagenGrupo.Click
        agregar_imagen()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        agregar_imagen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        insertar_grupo()
    End Sub
    Dim ESTADO_IMAGEN As String
    Sub insertar_grupo()
        Dim CMD As SqlCommand
        Try
            abrir()
            CMD = New SqlCommand("insertar_Grupo", conexion)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@Grupo", txtgrupo.Text)
            CMD.Parameters.AddWithValue("@Por_defecto", "NO")
            Dim ms As New IO.MemoryStream()
            ImagenGrupo.Image.Save(ms, ImagenGrupo.Image.RawFormat)
            CMD.Parameters.AddWithValue("@Icono", ms.GetBuffer)
            CMD.Parameters.AddWithValue("@Estado", "ACTIVO")

            CMD.Parameters.AddWithValue("@Estado_de_icono", ESTADO_IMAGEN)
            CMD.ExecuteNonQuery()
            Cerrar()
            Productos_rest.dibujarGrupos()
            destruir()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Grupos_De_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ESTADO_IMAGEN = "VACIO"

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        destruir()
    End Sub

    Private Sub BTNEliminar_Click(sender As Object, e As EventArgs) Handles BTNEliminar.Click
        Dim B As Rectangle
        Dim C As Rectangle
        Dim D As GraphicsUnit
        Dim A As PictureBox

        'A = ImagenGrupo.Image

        B = New Rectangle(0, 0, 100, 100)

        c = New Rectangle(160, 15, 160, 150)

        d = GraphicsUnit.Pixel

        ImagenGrupo.CreateGraphics.DrawImage(ImagenGrupo.Image, B, C, D)
        'ImagenGrupo.CreateGraphics.DrawImagePicturebox1.image, New Rectangle(0, 0, 100, 100), New Rectangle(160, 15, 160, 150), GraphicsUnit.Pixel)

    End Sub
    Sub destruir()
        Productos_rest.destruir_sub_formularios()

    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        destruir()
    End Sub

    Private Sub PanelEDICION_Paint(sender As Object, e As PaintEventArgs) Handles PanelEDICION.Paint

    End Sub

    Private Sub dlg_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dlg.FileOk

    End Sub
End Class