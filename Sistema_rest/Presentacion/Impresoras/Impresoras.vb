Imports System.Drawing.Printing
Imports System.Data.SqlClient
Imports Telerik.Reporting.Processing
Public Class Impresoras
    Dim indicador As Integer
    Dim impresora As String
    Dim area As String
    Dim idarea As Integer
    Dim DOCUMENTO As PrintDocument
    Private Sub Impresoras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panel_Bienvenida.Visible = True
        panel_Bienvenida.Dock = DockStyle.Fill
        PanelImpresoras.Visible = False

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
            mostrar_impresoras_agregadas_por_area()
            dibujar_impresoras()
        Catch ex As Exception

        End Try
    End Sub
    Sub Insertar_Impresoras_por_Area()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("Insertar_Impresoras_por_Area", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_areas_de_impresion", idarea)
            cmd.Parameters.AddWithValue("@Impresora", impresora)
            cmd.Parameters.AddWithValue("@idcaja", 1)
            cmd.ExecuteNonQuery()
            Cerrar()
        Catch ex As Exception
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("eliminar_impresora_por_area", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_areas_de_impresion", idarea)
            cmd.Parameters.AddWithValue("@Impresora", impresora)
            cmd.Parameters.AddWithValue("@idCaja", 1)
            cmd.ExecuteNonQuery()
            Cerrar()
            mostrar_impresoras_agregadas_por_area()
            dibujar_impresoras()
        End Try
    End Sub

    Sub Seleccionar_boton()
        Select Case indicador
            Case 1
                btn1.BackColor = Color.OrangeRed
                btn2.BackColor = Color.FromArgb(31, 31, 31)
                btn3.BackColor = Color.FromArgb(31, 31, 31)
                btn4.BackColor = Color.FromArgb(31, 31, 31)
            Case 2
                btn1.BackColor = Color.FromArgb(31, 31, 31)
                btn2.BackColor = Color.OrangeRed
                btn3.BackColor = Color.FromArgb(31, 31, 31)
                btn4.BackColor = Color.FromArgb(31, 31, 31)
            Case 3
                btn1.BackColor = Color.FromArgb(31, 31, 31)
                btn2.BackColor = Color.FromArgb(31, 31, 31)
                btn3.BackColor = Color.OrangeRed
                btn4.BackColor = Color.FromArgb(31, 31, 31)
            Case 4
                btn1.BackColor = Color.FromArgb(31, 31, 31)
                btn2.BackColor = Color.FromArgb(31, 31, 31)
                btn3.BackColor = Color.FromArgb(31, 31, 31)
                btn4.BackColor = Color.OrangeRed
        End Select

        mostrar_id_por_area()
        mostrar_impresoras_agregadas_por_area()
        dibujar_impresoras()

        panel_Bienvenida.Visible = False
        panel_Bienvenida.Dock = DockStyle.None
        PanelImpresoras.Visible = True
        PanelImpresoras.Dock = DockStyle.Fill

    End Sub
    Sub mostrar_impresoras_agregadas_por_area()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_impresoras_agregadas_por_area", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@idarea", idarea)
            da.SelectCommand.Parameters.AddWithValue("@idcaja", 1)
            da.Fill(dt)
            datalistado.DataSource = dt
            Cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub
    Sub mostrar_id_por_area()
        Try
            Dim com As New SqlCommand("mostrar_id_por_area", conexion)
            com.CommandType = 4
            com.Parameters.AddWithValue("@Area", area)
            Try
                abrir()
                idarea = com.ExecuteScalar()
                Cerrar()
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        indicador = 1
        area = btn1.Text
        Seleccionar_boton()

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        indicador = 2
        area = btn2.Text

        Seleccionar_boton()
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        indicador = 3
        area = btn3.Text
        Seleccionar_boton()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        indicador = 4
        area = btn4.Text
        Seleccionar_boton()
    End Sub
End Class