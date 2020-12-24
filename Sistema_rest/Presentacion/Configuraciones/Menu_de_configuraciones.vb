Public Class Menu_de_configuraciones
    Public Formulario_de_llamado As String = ""
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) 

    End Sub

    Private Sub Menu_de_configuraciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelContenedor.Location = New Point((Panel8.Width - PanelContenedor.Width) / 2, (Panel8.Height - PanelContenedor.Height) / 2)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnmesas.Click
        Configurar_mesas_ok.ShowDialog()
    End Sub

    Private Sub btnproductos_Click(sender As Object, e As EventArgs) Handles btnproductos.Click
        Productos_rest.ShowDialog()
    End Sub

    Private Sub Menu_de_configuraciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Formulario_de_llamado = "Visor de mesas" Then
            Dispose()
            Visor_de_mesas.ShowDialog()
        End If
    End Sub
End Class