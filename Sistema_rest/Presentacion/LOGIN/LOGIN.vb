Imports System.Data.SqlClient
Imports System.Management
Imports System.Xml
Imports System.Net.Mail
Imports System.Net
Public Class LOGIN
    Dim contador_de_usuario As Integer
    Dim Indicador_de_existencia_de_base_de_datos As String
    Dim login As String
    Dim idusuario As Integer
    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        centrar_paneles()
        mostrar_usuarios_registrados()
        validar_existencia_de_usuarios()
    End Sub
    Sub validar_existencia_de_usuarios()
        If Indicador_de_existencia_de_base_de_datos = "CORRECTO" Then
            If contador_de_usuario = 0 Then
                Dispose()
                Eleccion_Servidor_o_remoto.ShowDialog()
            Else
                dibujarUSUARIOS()
            End If
        Else
            Dispose()
            Eleccion_Servidor_o_remoto.ShowDialog()
        End If
    End Sub
    Sub dibujarUSUARIOS()
        Panel_USUARIOS.Controls.Clear()
        Try
            abrir()
            Dim query As String = "select * from USUARIO2 Where Estado = 'ACTIVO'"
            Dim cmd As New SqlCommand(query, conexion)
            Dim rdr As SqlDataReader = cmd.ExecuteReader()
            While rdr.Read()
                Dim b As New Label()
                Dim p1 As New Panel
                Dim I1 As New PictureBox
                b.Text = rdr("Login").ToString()
                b.Name = rdr("idUsuario").ToString()
                b.Size = New System.Drawing.Size(175, 25)
                b.Font = New System.Drawing.Font("Microsoft Sans Serif", 13)
                b.BackColor = Color.Transparent
                b.ForeColor = Color.White
                b.Dock = DockStyle.Bottom
                b.TextAlign = ContentAlignment.MiddleCenter
                b.Cursor = Cursors.Hand

                p1.Size = New System.Drawing.Size(155, 167)
                p1.BorderStyle = BorderStyle.None
                p1.BackColor = Color.Transparent

                I1.Size = New System.Drawing.Size(175, 132)
                I1.Dock = DockStyle.Fill
                I1.BackgroundImage = Nothing
                Dim bi() As Byte = rdr("Icono")
                Dim ms As New IO.MemoryStream(bi)
                I1.Image = Image.FromStream(ms)
                I1.SizeMode = PictureBoxSizeMode.Zoom
                I1.Tag = rdr("Login").ToString
                I1.Cursor = Cursors.Hand

                p1.Controls.Add(b)
                p1.Controls.Add(I1)
                I1.BringToFront()
                Panel_USUARIOS.Controls.Add(p1)
                AddHandler b.Click, AddressOf miEventoLabel
                AddHandler I1.Click, AddressOf miEventoImagen
            End While
            Cerrar()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub miEventoImagen(sender As Object, e As EventArgs)
        Try
            login = DirectCast(sender, PictureBox).Tag
            centrar_panel_de_contraseña()
        Catch ex As Exception

        End Try
    End Sub
    Sub centrar_panel_de_contraseña()
        PanelVisorDeUsuarios.Visible = False
        PanelContraseña.Visible = True
        PanelContraseña.Dock = DockStyle.Fill
        PanelContraseña.BringToFront()
        PanelIngresarContraseña.Location = New Point((Panel20.Width - PanelIngresarContraseña.Width) / 2, (Panel20.Height - PanelIngresarContraseña.Height) / 2)
    End Sub
    Private Sub miEventoLabel(sender As Object, e As EventArgs)
        Try
            login = DirectCast(sender, Label).Text
            centrar_panel_de_contraseña()
        Catch ex As Exception

        End Try
    End Sub


    Sub mostrar_usuarios_registrados()
        Try
            Dim da = New SqlCommand("Select Count(idUsuario) From USUARIO2", conexion)
            abrir()
            contador_de_usuario = da.ExecuteScalar()
            Cerrar()
            Indicador_de_existencia_de_base_de_datos = "CORRECTO"
        Catch ex As Exception
            contador_de_usuario = 0
            Indicador_de_existencia_de_base_de_datos = "INCORRECTO"
        End Try
    End Sub
    Sub centrar_paneles()
        PanelVisorDeUsuarios.Visible = True
        PanelVisorDeUsuarios.Dock = DockStyle.Fill
        PanelVisorDeUsuarios.BringToFront()

        PanelContraseña.Visible = False

        PanelRestaurarCuenta.Visible = False

        PanelUsuarios.Dock = DockStyle.Fill
        PanelUsuarios.BringToFront()

        btnOlvidecontraseña.Location = New Point((Panel17.Width - btnOlvidecontraseña.Width) / 2, (Panel17.Height - btnOlvidecontraseña.Height) / 2)

        PanelIngresarContraseña.Location = New Point((Panel20.Width - PanelIngresarContraseña.Width) / 2, (Panel20.Height - PanelIngresarContraseña.Height) / 2)

    End Sub

    Private Sub txt_contraseña_TextChanged(sender As Object, e As EventArgs) Handles txt_contraseña.TextChanged
        validar_usuario()
        If idusuario > 0 Then
            editar_inicio_De_sesion()
            Dispose()
            Visor_de_mesas.ShowDialog()
        End If
    End Sub
    Sub editar_inicio_De_sesion()
        Try
            abrir()
            Dim cmd = New SqlCommand("editar_inicio_De_sesion", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_serial_Pc", lblIDSERIAL.Text)
            cmd.Parameters.AddWithValue("@id_usuario", idusuario)
            cmd.ExecuteNonQuery()
            Cerrar()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub validar_usuario()
        Try
            abrir()
            Dim da = New SqlCommand("validar_usuario", conexion)
            da.CommandType = 4
            da.Parameters.AddWithValue("@password", Encriptar(txt_contraseña.Text))
            da.Parameters.AddWithValue("@login", login)
            idusuario = da.ExecuteScalar()
            Cerrar()

        Catch ex As Exception
            idusuario = 0
        End Try
    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        MessageBox.Show("Usuario o contraseña Incorrectos", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txt_contraseña.Text = txt_contraseña.Text & "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txt_contraseña.Text = txt_contraseña.Text & "2"

    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txt_contraseña.Text = txt_contraseña.Text & "3"

    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txt_contraseña.Text = txt_contraseña.Text & "4"

    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txt_contraseña.Text = txt_contraseña.Text & "5"

    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txt_contraseña.Text = txt_contraseña.Text & "6"

    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txt_contraseña.Text = txt_contraseña.Text & "7"

    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txt_contraseña.Text = txt_contraseña.Text & "8"

    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txt_contraseña.Text = txt_contraseña.Text & "9"

    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txt_contraseña.Text = txt_contraseña.Text & "0"

    End Sub

    Private Sub btnborrartodo_Click(sender As Object, e As EventArgs) Handles btnborrartodo.Click
        txt_contraseña.Clear()

    End Sub

    Private Sub btnborrarderecha_Click(sender As Object, e As EventArgs) Handles btnborrarderecha.Click
        Try
            Dim largo As Integer
            If txt_contraseña.Text <> "" Then

                largo = txt_contraseña.Text.Length
                txt_contraseña.Text = Mid(txt_contraseña.Text, 1, largo - 1)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tver_Click(sender As Object, e As EventArgs) Handles tver.Click
        txt_contraseña.PasswordChar = ""
        tocultar.Visible = True
        tver.Visible = False
    End Sub

    Private Sub tocultar_Click(sender As Object, e As EventArgs) Handles tocultar.Click
        txt_contraseña.PasswordChar = "*"
        tocultar.Visible = False
        tver.Visible = True
    End Sub
End Class