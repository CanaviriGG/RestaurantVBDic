
Imports System.Net
Imports System.Data
Imports System.Data.SqlClient

Imports System.Globalization
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Data.OleDb

Imports System.IO
Imports System.Management
Imports System.Xml
Imports System.AppDomainManagerInitializationOptions
Imports System.MarshalByRefObject
Imports System.Configuration
Public Class USUARIOS_AUTORIZADOS_AL_SISTEMA
    Private MisDiscos As New ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard")
    Private DiscInfo As New ManagementObject

    Sub insertar_inicio_De_sesion()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_inicio_De_sesion", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_serial_Pc", lblIDSERIAL.Text)

            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Dim idsalon As Integer
    Sub obtener_id_de_salon()
        Try

            Dim com As New SqlCommand("Select Id_salon from SALON", conexion)

            Try
                abrir()
                idsalon = (com.ExecuteScalar())
                Cerrar()


            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try

    End Sub

    Sub insertar_mesas_por_defecto()
        Dim NMesas As Integer = 80
        For i = 1 To NMesas
            Try
                Dim cmd As New SqlCommand
                abrir()
                cmd = New SqlCommand("insertar_mesa", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@mesa", "NULO")
                cmd.Parameters.AddWithValue("@id_salon", idsalon)
                cmd.ExecuteNonQuery()
                Cerrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If txtnombre.Text <> "" And TXTCONTRASEÑA.Text <> "" And TXTUSUARIO.Text <> "" Then

            If TXTCONTRASEÑA.Text = txtconfirmarcontraseña.Text Then
                Dim contraseña_encryptada As String
                contraseña_encryptada = Encriptar(Me.TXTCONTRASEÑA.Text.Trim)

                Try
                    Dim cmd As New SqlCommand
                    abrir()
                    cmd = New SqlCommand("insertar_usuario", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@Login", TXTUSUARIO.Text)
                    cmd.Parameters.AddWithValue("@Password", contraseña_encryptada)
                    cmd.Parameters.AddWithValue("@nombres", txtnombre.Text)

                    Dim ms As New IO.MemoryStream()
                    If Not PictureBox2.Image Is Nothing Then
                        PictureBox2.Image.Save(ms, PictureBox2.Image.RawFormat)
                    Else
                        PictureBox2.Image = My.Resources.candado
                        PictureBox2.Image.Save(ms, PictureBox2.Image.RawFormat)
                    End If
                    cmd.Parameters.AddWithValue("@Icono", ms.GetBuffer)
                    cmd.Parameters.AddWithValue("@Nombre_de_icono", "Ada_369")
                    cmd.Parameters.AddWithValue("@Correo", REGISTRO_DE_EMPRESA.txtcorreo.Text)
                    cmd.Parameters.AddWithValue("@Rol", "Administrador (Control total)")
                    cmd.Parameters.AddWithValue("@Estado", "ACTIVO")

                    cmd.ExecuteNonQuery()
                    Cerrar()

                    Insertar_licencia_de_prueba_30_dias()
                    insertar_cliente_standar()
                    insertar_inicio_De_sesion()
                    Insertar_propiedades_de_mesas()
                    insertar_Salon_por_defecto()
                    obtener_id_de_salon()
                    insertar_mesas_por_defecto()
                    Insertar_modulos()
                    insertar_mesa_estandar()
                    MessageBox.Show("!LISTO! RECUERDA que para Iniciar Sesión tu Usuario es: " & TXTUSUARIO.Text & " y tu Contraseña es: " & TXTCONTRASEÑA.Text, "Registro Exitoso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                    Dispose()
                    LOGIN.ShowDialog()


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


            Else
                MessageBox.Show("Las contraseñas no Coinciden", "Contraseñas Incompatibles", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

            End If
        Else
            MessageBox.Show("Falta ingresar Datos", "Datos incompletos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        End If


    End Sub
    Sub insertar_mesa_estandar()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_mesa_estandar", conexion)
            cmd.ExecuteNonQuery()
            Cerrar()

        Catch ex As Exception

        End Try

    End Sub
    Sub Insertar_modulos()
        Dim modulo1 As String = "VENTAS"
        Dim modulo2 As String = "CAJA"
        Dim modulo3 As String = "USUARIOS"
        Dim modulo4 As String = "REPORTES"
        Dim modulo5 As String = "PRODUCTOS"
        Dim modulo6 As String = "CONFIGURAR"
        Dim modulo7 As String = "CLIENTES"
        Dim modulo8 As String = "ELIMINAR VENTAS"
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("Insertar_modulos", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Modulo", modulo1)
            Cerrar()

            abrir()
            cmd = New SqlCommand("Insertar_modulos", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Modulo", modulo2)
            cmd.ExecuteNonQuery()
            Cerrar()

            abrir()
            cmd = New SqlCommand("Insertar_modulos", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Modulo", modulo3)
            cmd.ExecuteNonQuery()
            Cerrar()

            abrir()
            cmd = New SqlCommand("Insertar_modulos", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Modulo", modulo4)
            cmd.ExecuteNonQuery()
            Cerrar()

            abrir()
            cmd = New SqlCommand("Insertar_modulos", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Modulo", modulo5)
            cmd.ExecuteNonQuery()
            Cerrar()

            abrir()
            cmd = New SqlCommand("Insertar_modulos", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Modulo", modulo6)
            cmd.ExecuteNonQuery()
            Cerrar()

            abrir()
            cmd = New SqlCommand("Insertar_modulos", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Modulo", modulo7)
            cmd.ExecuteNonQuery()
            Cerrar()

            abrir()
            cmd = New SqlCommand("Insertar_modulos", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Modulo", modulo8)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception

        End Try

    End Sub
    Sub Insertar_propiedades_de_mesas()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("Insertar_propiedades_de_mesas", conexion)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception

        End Try
    End Sub
    Sub insertar_Salon_por_defecto()

        Try
                Dim cmd As New SqlCommand
                abrir()
                cmd = New SqlCommand("insertar_Salon", conexion)
                cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Salon", "SALON 1")
            cmd.Parameters.AddWithValue("@Estado", "ACTIVO")

                cmd.ExecuteNonQuery()
                Cerrar()
            Catch ex As Exception

            End Try


    End Sub

    Sub INSERTAR_VENTA_BASE()
        'Try
        '    Dim cmd As New SqlCommand
        '    abrir()
        '    cmd = New SqlCommand("insertar_venta_BASE", conexion)
        '    cmd.CommandType = 4
        '    cmd.Parameters.AddWithValue("@idcliente", 0)
        '    cmd.Parameters.AddWithValue("@ACCION", 0)
        '    cmd.Parameters.AddWithValue("@fecha_venta", Now())
        '    cmd.Parameters.AddWithValue("@Fecha_de_pago", Now())
        '    cmd.Parameters.AddWithValue("@Comprobante", 0)
        '    cmd.Parameters.AddWithValue("@nume_documento", 0)
        '    cmd.Parameters.AddWithValue("@montototal", 0)
        '    cmd.Parameters.AddWithValue("@IGV", 0)

        '    cmd.Parameters.AddWithValue("@estado", 0)
        '    cmd.Parameters.AddWithValue("@Tipo_de_pago", "-")
        '    cmd.Parameters.AddWithValue("@Saldo", 0)
        '    cmd.Parameters.AddWithValue("@Pago_con", 0)
        '    cmd.Parameters.AddWithValue("@Porcentaje_IGV", 0)
        '    cmd.Parameters.AddWithValue("@Id_caja", 0)
        '    cmd.Parameters.AddWithValue("@Referencia_tarjeta", "NULO")
        '    cmd.ExecuteNonQuery()

        '    Cerrar()

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
    Sub insertar_cliente_standar()
        Try
            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("insertar_cliente", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Nombre", "GENERICO")
            cmd.Parameters.AddWithValue("@Direccion_para_factura", 0)
            cmd.Parameters.AddWithValue("@Ruc ", 0)
            cmd.Parameters.AddWithValue("@movil", 0)
            cmd.Parameters.AddWithValue("@Cliente ", "NEUTRO")
            cmd.Parameters.AddWithValue("@Proveedor", "NEUTRO")

            cmd.Parameters.AddWithValue("@Estado", 0)
            cmd.Parameters.AddWithValue("@Saldo", 0)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub mostrar_NUEVOS()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("SELECT*FROM USUARIO2 ORDER BY idUsuario desc", conexion)
            da.Fill(dt)
            DATALISTADOUSUARIOSSNUEVOS.DataSource = dt

        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        Cerrar()
    End Sub


    Private Sub USUARIOS_AUTORIZADOS_AL_SISTEMA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Location = New Point((Width - Panel2.Width) / 2, (Height - Panel2.Height) / 2)

        Obtener_serialPc(lblIDSERIAL.Text)

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)
        End
    End Sub
    Sub Insertar_licencia_de_prueba_30_dias()
        Dim SERIALpC As String
        SERIALpC = (lblIDSERIAL.Text.Trim)
        txtfechaFinal.Text = DateAdd(DateInterval.Day, 30, txtfechaInicio.Value)
        Dim FECHA_FINAL As String
        FECHA_FINAL = Encriptar(Me.txtfechaFinal.Text.Trim)
        Dim estado As String
        estado = Encriptar("?ACTIVO?")
        Dim fecha_activacion
        fecha_activacion = Encriptar(Me.txtfechaInicio.Text.Trim)
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("Insertar_marcan", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@s", SERIALpC)
            cmd.Parameters.AddWithValue("@f", FECHA_FINAL)
            cmd.Parameters.AddWithValue("@e", estado)
            cmd.Parameters.AddWithValue("@fa", fecha_activacion)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TXTCONTRASEÑA_TextChanged(sender As Object, e As EventArgs) Handles TXTCONTRASEÑA.TextChanged
        LBLcontador_de_contraseña.Text = Len(TXTCONTRASEÑA.Text)
    End Sub

    Private Sub TXTCONTRASEÑA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCONTRASEÑA.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(TXTCONTRASEÑA, e)

    End Sub
    Public Sub NumerosyDecimal(ByVal CajaTexto As System.Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If


    End Sub

    Private Sub txtconfirmarcontraseña_TextChanged(sender As Object, e As EventArgs) Handles txtconfirmarcontraseña.TextChanged
        LBLcontador_de_contraseña2.Text = Len(txtconfirmarcontraseña.Text)
    End Sub

    Private Sub txtconfirmarcontraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtconfirmarcontraseña.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosyDecimal(txtconfirmarcontraseña, e)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click


    End Sub
End Class