Imports System.Data.SqlClient
Imports Telerik.Reporting.Drawing
Public Class VistaPreciaPrecuenta
    Dim contador_de_items_ventas As Integer
    Private Sub VistaPreciaPrecuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contador_de_items_ventas = Punto_de_venta.datalistadoDetalledeventa.RowCount
        mostrar_precuenta()

    End Sub
    Public Sub mostrar_precuenta()
        Try
            Dim dt As New DataTable
            Dim da As SqlDataAdapter
            abrir()
            da = New SqlDataAdapter("mostrar_pre_cuenta", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@idventa", Punto_de_venta.idventa)
            da.SelectCommand.Parameters.AddWithValue("@idmesa", Punto_de_venta.idmesa)
            da.Fill(dt)
            Cerrar()

            Dim rpt As New Ticket_precuenta()
            rpt = New Ticket_precuenta
            rpt.Table1.DataSource = dt
            rpt.DataSource = dt
            ReportViewer1.Report = rpt
            Dim ancho As Unit = rpt.PageSettings.PaperSize.Width
            Dim alto As Unit = rpt.PageSettings.PaperSize.Height
            rpt.PageSettings.PaperSize = New SizeU(ancho, alto + Unit.Cm(0.72 * contador_de_items_ventas))
            ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try



    End Sub
End Class