Imports System.Data.SqlClient
Imports System.Xml

Public Class Conexion_caja_secundaria
    Private Sub Conexion_caja_secundaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Location = New Point((Width - Panel2.Width) / 2, (Height - Panel2.Height) / 2)
        LeerXML_con_la_base_de_datos()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        hide()
        Eleccion_Servidor_o_remoto.ShowDialog()

    End Sub
    Dim base_de_datos As String
    Dim servidor As String
    Dim Contraseña_base_de_datos As String

    Public Sub LeerXML_con_la_base_de_datos()
        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load("Base_de_datos.xml")
            Dim root As XmlElement = doc.DocumentElement
            base_de_datos = root.Attributes.Item(0).Value
            txtBasededatos.Text = (aes.Decrypt(base_de_datos, appPwdUnique, Integer.Parse("256")))

        Catch ex As System.Security.Cryptography.CryptographicException

        End Try
    End Sub
    Public Sub LeerXML_servidor()
        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load("Servidor.xml")
            Dim root As XmlElement = doc.DocumentElement
            servidor = root.Attributes.Item(0).Value
            txtservidor.Text = (aes.Decrypt(servidor, appPwdUnique, Integer.Parse("256")))

        Catch ex As System.Security.Cryptography.CryptographicException

        End Try
    End Sub
    Public Sub LeerXML_con_la_contraseña_base_de_datos()
        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load("Passwor_Base_de_datos.xml")
            Dim root As XmlElement = doc.DocumentElement
            Contraseña_base_de_datos = root.Attributes.Item(0).Value
            txtcontraseñaBd.Text = (aes.Decrypt(Contraseña_base_de_datos, appPwdUnique, Integer.Parse("256")))

        Catch ex As System.Security.Cryptography.CryptographicException

        End Try
    End Sub
    Public Sub SavetoXML(ByVal dbcnString)
        Dim doc As XmlDocument = New XmlDocument()
        doc.Load("ConnectionString.xml")
        Dim root As XmlElement = doc.DocumentElement
        root.Attributes.Item(0).Value = dbcnString
        Dim writer As XmlTextWriter = New XmlTextWriter("ConnectionString.xml", Nothing)
        writer.Formatting = Formatting.Indented
        doc.Save(writer)
        writer.Close()
    End Sub
    Private aes As New AES()
    Dim indicador As String

    Sub mostrar_usuario()

        Try
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            da = New SqlDataAdapter("select * from USUARIO2", cadena_de_conexion)
            da.Fill(dt)
            datalistado_movimientos_validar.DataSource = dt

            indicador = "HAY CONEXION"
        Catch ex As Exception
            MessageBox.Show("Conexion Fallida, Revisa de nuevo la Cadena de Conexion o Escribenos para Ayudarte de Inmediato", "Sin Conexion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            indicador = "NO HAY CONEXION"

        End Try


    End Sub
    Public cadena_de_conexion As String

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        cadena_de_conexion = "Data Source=" & txtCnString.Text & ";Initial Catalog=" & txtBasededatos.Text & "; Integrated Security=False; User Id=" & txtusuarioBd.Text & "; Password=" & txtcontraseñaBd.Text
        If txtCnString.Text = "" Then
            MessageBox.Show("Por favor ingrese la cadena de Conexion..", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            SavetoXML(aes.Encrypt(cadena_de_conexion, appPwdUnique, Integer.Parse("256")))
            'MessageBox.Show("Conexion Creada Archivo: ConnectionString.xml", "Encryptacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mostrar_usuario()
            If indicador = "HAY CONEXION" Then
                REGISTRO_DE_CAJA.lblconexion.Text = cadena_de_conexion
                Dispose()
                REGISTRO_DE_CAJA.ShowDialog()
                REGISTRO_DE_CAJA.lblconexion.Text = cadena_de_conexion

            End If
        End If
    End Sub
End Class