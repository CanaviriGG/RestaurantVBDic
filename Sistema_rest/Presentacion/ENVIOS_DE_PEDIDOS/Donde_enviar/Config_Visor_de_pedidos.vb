Imports System.Drawing.Printing
Imports System.Data.SqlClient
Imports Telerik.Reporting.Processing
Public Class Config_Visor_de_pedidos
    Dim indicador As Integer
    Dim impresora As String
    Dim area As String
    Dim idarea As Integer
    Dim DOCUMENTO As PrintDocument
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mostrar_impresoras_para_pedidos()
        dibujar_impresoras()
        Button2.BackColor = Color.OrangeRed
        PanelAticketera.Visible = True
        PanelAticketera.Dock = DockStyle.Fill
    End Sub
    Sub dibujar_impresoras()
        PanelImpresoras.Controls.Clear()
        For I = 0 To PrinterSettings.InstalledPrinters.Count - 1
            Dim b As New System.Windows.Forms.Button
            Dim panel As New System.Windows.Forms.Panel
            Dim a As New System.Windows.Forms.Button
            b.Text = PrinterSettings.InstalledPrinters.Item(I)
            b.Name = PrinterSettings.InstalledPrinters.Item(I)
            b.Dock = DockStyle.Fill
            b.Font = New System.Drawing.Font(10, 10)
            b.BackColor = Color.FromArgb(27, 27, 27)
            b.FlatStyle = FlatStyle.Flat
            b.FlatAppearance.BorderSize = 0
            b.ForeColor = Color.White
            b.Cursor = Cursors.Hand



            panel.Size = New System.Drawing.Size(160, 158)
            panel.BackColor = Color.Transparent
            a.Text = "Probar"
            a.Name = PrinterSettings.InstalledPrinters.Item(I)
            a.Dock = DockStyle.Bottom
            a.Font = New System.Drawing.Font(10, 9)
            a.BackColor = Color.OrangeRed
            a.ForeColor = Color.White
            a.FlatStyle = FlatStyle.Flat
            a.FlatAppearance.BorderSize = 0
            a.Cursor = Cursors.Hand
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    If row.Cells("Impresora").Value = b.Text Then
                        b.BackColor = Color.OrangeRed
                    End If
                Next
            Catch ex As Exception
                MessageBox.Show(ex.StackTrace)
            End Try
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    If row.Cells("Impresora").Value = b.Text Then
                        panel.Controls.Add(a)
                    End If
                Next
            Catch ex As Exception

            End Try

            panel.Controls.Add(b)
            PanelImpresoras.Controls.Add(panel)
            b.BringToFront()
            AddHandler b.Click, AddressOf miEvento
            AddHandler a.Click, AddressOf miEvento_probar_impresora
        Next
    End Sub
    Private Sub miEvento_probar_impresora(ByVal sender As System.Object, ByVal e As EventArgs)
        Try
            impresora = DirectCast(sender, System.Windows.Forms.Button).Name
            probar_impresoras()
        Catch ex As Exception

        End Try
    End Sub
    Sub probar_impresoras()
        mostrar_ticket_lleno()
        Try
            DOCUMENTO = New PrintDocument
            DOCUMENTO.PrinterSettings.PrinterName = impresora
            If DOCUMENTO.PrinterSettings.IsValid Then
                Dim printerSettins As PrinterSettings = New PrinterSettings()
                printerSettins.PrinterName = impresora
                Dim reportProccessor As New ReportProcessor()
                reportProccessor.PrintReport(ReportViewer1.ReportSource, printerSettins)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub mostrar_ticket_lleno()
        Dim rpt As New Ticket_pedido_listo()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("probar_impresora", conexion)
            da.Fill(dt)
            Cerrar()
            rpt = New Ticket_pedido_listo
            rpt.Table1.DataSource = dt
            rpt.DataSource = dt
            ReportViewer1.Report = rpt
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub
    Private Sub miEvento(ByVal sender As System.Object, ByVal e As EventArgs)
        Try
            impresora = DirectCast(sender, System.Windows.Forms.Button).Name
            For Each panelC1 In PanelImpresoras.Controls
                If TypeOf panelC1 Is System.Windows.Forms.Panel Then
                    For Each boton In panelC1.controls
                        If TypeOf boton Is System.Windows.Forms.Button Then
                            If boton.name = impresora Then
                                boton.Backcolor = Color.OrangeRed
                                Exit For
                                Exit For
                            End If

                        End If
                    Next
                End If
            Next
            Insertar_Impresoras_por_Area()
            mostrar_impresoras_para_pedidos()
            dibujar_impresoras()
        Catch ex As Exception

        End Try
    End Sub
    Sub Insertar_Impresoras_por_Area()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("Insertar_Impresoras_para_pedidos", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Impresora", impresora)
            cmd.Parameters.AddWithValue("@idcaja", 1)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("eliminar_impresora_para_pedidos", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Impresora", impresora)
            cmd.Parameters.AddWithValue("@idCaja", 1)
            cmd.ExecuteNonQuery()
            Cerrar()
            mostrar_impresoras_para_pedidos()
            dibujar_impresoras()
        End Try
    End Sub
    Sub mostrar_impresoras_para_pedidos()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_impresoras_para_pedidos", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@idcaja", 1)
            da.Fill(dt)
            datalistado.DataSource = dt
            Cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub
    Private Sub Config_Visor_de_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class