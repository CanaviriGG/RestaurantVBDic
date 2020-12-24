Imports System.Data.SqlClient
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Public Class Ticket_form
    Private Sub Ticket_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Previsualizar_ticket()
        Dim oldItemX As Unit = rpt.ReportHeaderSection1.Height

        'MessageBox.Show(oldItemX.ToString())
    End Sub
    Dim rpt As New Ticket_pedido_listo()

    Sub Previsualizar_ticket()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_pedido_por_mesa", conexion)
            da.SelectCommand.CommandType = 4
            'da.SelectCommand.Parameters.AddWithValue("@idventa", Punto_de_venta.idventa)
            'da.SelectCommand.Parameters.AddWithValue("@Id_mesa", Punto_de_venta.idmesa)
            da.Fill(dt)
            Cerrar()
            rpt = New Ticket_pedido_listo
            rpt.Table1.DataSource = dt
            rpt.DataSource = dt
            ReportViewer1.Report = rpt
            ReportViewer1.RefreshReport()
            'Dim oldItemX As Unit = 34
            '''''Dim oldItemX As Unit = rpt.Table1.Size.Height

            '''''Dim cantidad As Integer
            '''''cantidad = rpt.Table1.RowGroups.Count()
            '''''MessageBox.Show(rpt.ReportHeaderSection1.Height.ToString())
            '''''rpt.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
            ''''''rpt.PageSettings.PaperSize = New SizeU(Unit.Mm(90), Unit.Mm(30) + Unit.Mm(80) * 0.7)
            '''''rpt.PageSettings.PaperSize = New SizeU(Unit.Mm(90), oldItemX)

        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub
    Sub ajustar()
        'Dim splitter = (rpt).find(".k-splitter").data("kendoSplitter")
        'splitter.options.panes(2).size = "250px"
        'splitter.resize(True)

    End Sub
End Class