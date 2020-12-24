
Imports System.Data.SqlClient

Imports System.Management

Public Class CIERRE_DE_CAJA


    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Cierre_de_turno.ShowDialog()

    End Sub
    Sub REPORT_VENTAS_por_TURNOS_en_EFECTIVO()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("REPORT_VENTAS_por_TURNOS_en_EFECTIVO", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@id_caja", lblidcaja.Text)
            da.SelectCommand.Parameters.AddWithValue("@fi", fechainicial)
            da.SelectCommand.Parameters.AddWithValue("@ff", lblfechaActual.Value)
            da.Fill(dt)
            DATALISTADO_VENTAS_Efectivo.DataSource = dt
            Cerrar()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub REPORT_VENTAS_por_TURNOS_Por_tarjeta()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("REPORT_VENTAS_por_TURNOS_Por_tarjeta", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@id_caja", lblidcaja.Text)
            da.SelectCommand.Parameters.AddWithValue("@fi", fechainicial)
            da.SelectCommand.Parameters.AddWithValue("@ff", lblfechaActual.Value)
            da.Fill(dt)
            DATALISTADO_VENTAS_Tarjeta.DataSource = dt
            Cerrar()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub REPORT_VENTAS_por_TURNOS_Por_Credito()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("REPORT_VENTAS_por_TURNOS_Por_Credito", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@id_caja", lblidcaja.Text)
            da.SelectCommand.Parameters.AddWithValue("@fi", fechainicial)
            da.SelectCommand.Parameters.AddWithValue("@ff", lblfechaActual.Value)
            da.Fill(dt)
            DATALISTADO_VENTAS_Credito.DataSource = dt
            Cerrar()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub REPORT_GASTOS_VARIOS_por_turnos()
        Try
            Dim importe As Double
            Dim com As New SqlCommand("REPORT_GASTOS_VARIOS_por_turnos", conexion)
            com.CommandType = 4
            com.Parameters.AddWithValue("@id_caja", lblidcaja.Text)
            com.Parameters.AddWithValue("@fi", fechainicial)
            com.Parameters.AddWithValue("@ff", lblfechaActual.Value)

            Try
                abrir()
                importe = (com.ExecuteScalar())
                Cerrar()
                lblsalidasvarias.Text = importe

            Catch ex As Exception
                lblsalidasvarias.Text = 0
            End Try
        Catch ex As Exception

        End Try



    End Sub
    Sub REPORT_GANANCIAS_DE_VENTAS_por_TURNOS()
        Try
            Dim importe As Double
            Dim com As New SqlCommand("REPORT_GANANCIAS_DE_VENTAS_por_TURNOS", conexion)
            com.CommandType = 4
            com.Parameters.AddWithValue("@id_caja", lblidcaja.Text)
            com.Parameters.AddWithValue("@fi", fechainicial)
            com.Parameters.AddWithValue("@ff", lblfechaActual.Value)

            Try
                abrir()
                importe = (com.ExecuteScalar())
                Cerrar()
                lblgananciasVentas.Text = importe

            Catch ex As Exception
                lblgananciasVentas.Text = 0
            End Try
        Catch ex As Exception

        End Try



    End Sub
    Sub REPORT_INGRESOS_VARIOS_por_turnos()
        Try
            Dim importe As Double
            Dim com As New SqlCommand("REPORT_INGRESOS_VARIOS_por_turnos", conexion)
            com.CommandType = 4
            com.Parameters.AddWithValue("@id_caja", lblidcaja.Text)
            com.Parameters.AddWithValue("@fi", fechainicial)
            com.Parameters.AddWithValue("@ff", lblfechaActual.Value)
            Try
                abrir()
                importe = (com.ExecuteScalar())
                Cerrar()
                LBLENTRADASVARIAS.Text = importe

            Catch ex As Exception
                LBLENTRADASVARIAS.Text = 0
            End Try

        Catch ex As Exception

        End Try


    End Sub
    Sub REPORT_COBROS_EN_EFECTIVO_por_turnos()
        Try
            Dim importe As Double
            Dim com As New SqlCommand("REPORT_COBROS_EN_EFECTIVO_por_turnos", conexion)
            com.CommandType = 4
            com.Parameters.AddWithValue("@id_caja", lblidcaja.Text)
            com.Parameters.AddWithValue("@fi", fechainicial)
            com.Parameters.AddWithValue("@ff", lblfechaActual.Value)

            Try
                abrir()
                importe = (com.ExecuteScalar())
                Cerrar()
                lblabonosEfectivo.Text = importe

            Catch ex As Exception
                lblabonosEfectivo.Text = 0
            End Try
        Catch ex As Exception

        End Try



    End Sub

    Sub REPORT_COBROS_EN_Tarjeta_por_turnos()
        Try
            Dim importe As Double
            Dim com As New SqlCommand("REPORT_COBROS_EN_TARJETA_por_turnos", conexion)
            com.CommandType = 4
            com.Parameters.AddWithValue("@id_caja", lblidcaja.Text)
            com.Parameters.AddWithValue("@fi", fechainicial)
            com.Parameters.AddWithValue("@ff", lblfechaActual.Value)

            Try
                abrir()
                importe = (com.ExecuteScalar())
                Cerrar()
                lblabonosTarjeta.Text = importe

            Catch ex As Exception
                lblabonosTarjeta.Text = 0
            End Try
        Catch ex As Exception

        End Try



    End Sub
    Sub REPORT_PAGOS_EN_EFECTIVO_por_turnos()
        Try
            Dim importe As Double
            Dim com As New SqlCommand("REPORT_PAGOS_EN_EFECTIVO_por_turnos", conexion)
            com.CommandType = 4
            com.Parameters.AddWithValue("@id_caja", lblidcaja.Text)
            com.Parameters.AddWithValue("@fi", fechainicial)
            com.Parameters.AddWithValue("@ff", lblfechaActual.Value)

            Try
                abrir()
                importe = (com.ExecuteScalar())
                Cerrar()
                lblPAGOSEfectivo.Text = importe
            Catch ex As Exception
                ': MessageBox.Show(ex.Message)
                lblPAGOSEfectivo.Text = 0
            End Try

        Catch ex As Exception

        End Try


    End Sub
    Sub MOSTRAR_FONDO_DE_CAJA()
        Try
            Dim importe As String
            Dim com As New SqlCommand("MOSTRAR_FONDO_DE_CAJA_INICIAL", conexion)
            com.CommandType = 4
            com.Parameters.AddWithValue("@id_caja", lblidcaja.Text)
            com.Parameters.AddWithValue("@fi", fechainicial)
            com.Parameters.AddWithValue("@ff", lblfechaActual.Value)

            Try
                abrir()
                importe = (com.ExecuteScalar()) 'asignamos el valor del importe
                Cerrar()
                lblfondodeCaja.Text = importe

            Catch ex As Exception
                lblfondodeCaja.Text = 0
            End Try
        Catch ex As Exception

        End Try

    End Sub

    Sub MOSTRAR_CIERRE_DE_CAJA_PENDIENTE()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("MOSTRAR_CIERRE_DE_CAJA_PENDIENTE", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@serial", lblIDSERIAL.Text)

            da.Fill(dt)
            datalistado_CIERRE_DE_CAJA_PENDIENTE.DataSource = dt
            Cerrar()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public fechainicial As String

    Sub MOSTRAR_CAJA_POR_SERIAL()


        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_cajas_por_Serial_de_DiscoDuro", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Serial", lblIDSERIAL.Text)

            da.Fill(dt)
            datalistado_caja.DataSource = dt
            Cerrar()

        Catch ex As Exception ': MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub CIERRE_DE_CAJA_MAGBRI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-ES")
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
        'lbldescripciondeCierre.Text = "Corte de " & VENTAS_MENU_PRINCIPAL.lblLogin.Text & " al "
        Dim serialDD As New ManagementObject("Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'")
        lblIDSERIAL.Text = serialDD.Properties("SerialNumber").Value.ToString
        lblIDSERIAL.Text = lblIDSERIAL.Text.Trim()
        MOSTRAR_CAJA_POR_SERIAL()
        Try
            lblidcaja.Text = datalistado_caja.SelectedCells.Item(1).Value
            lblcaja.Text = datalistado_caja.SelectedCells.Item(2).Value

        Catch ex As Exception

        End Try
        MOSTRAR_CIERRE_DE_CAJA_PENDIENTE()

        Try
            fechainicial = datalistado_CIERRE_DE_CAJA_PENDIENTE.SelectedCells.Item(1).Value
            'lbldesdehasta.Text = "Corte de " & VENTAS_MENU_PRINCIPAL.lblLogin.Text & " Desde " & fechainicial & " hasta " & lblfechaActual.Value

        Catch ex As Exception

        End Try
        'REPORT_GASTOS_VARIOS_por_turnos()
        'REPORT_INGRESOS_VARIOS_por_turnos()
        'REPORT_COBROS_EN_EFECTIVO_por_turnos()
        'REPORT_PAGOS_EN_EFECTIVO_por_turnos()
        'REPORT_VENTAS_por_TURNOS_en_EFECTIVO()
        'REPORT_VENTAS_por_TURNOS_Por_tarjeta()
        'REPORT_VENTAS_por_TURNOS_Por_Credito()
        'REPORT_GANANCIAS_DE_VENTAS_por_TURNOS()
        ''Try
        'Try
        '    LBLTOTALVENTAS.Text = DATALISTADO_VENTAS_Efectivo.SelectedCells.Item(1).Value

        'Catch ex As Exception
        '    LBLTOTALVENTAS.Text = 0
        'End Try
        'LBLVENTASenEfectivo.Text = LBLTOTALVENTAS.Text
        'LBLVentasEnEfectivo2.Text = LBLVENTASenEfectivo.Text
        'Try
        '    lblventas_Tarjeta.Text = DATALISTADO_VENTAS_Tarjeta.SelectedCells.Item(1).Value

        'Catch ex As Exception
        '    lblventas_Tarjeta.Text = 0
        'End Try
        'Try
        '    lblVentasAcredito.Text = DATALISTADO_VENTAS_Credito.SelectedCells.Item(1).Value

        'Catch ex As Exception
        '    lblVentasAcredito.Text = 0
        'End Try

        ''Catch ex As Exception
        ''    LBLTOTALVENTAS.Text = 0
        ''    LBLVENTASenEfectivo.Text = 0
        ''    LBLVentasEnEfectivo2.Text = 0
        ''    lblventas_Tarjeta.Text = 0
        ''    lblVentasAcredito.Text = 0
        ''End Try

        'MOSTRAR_FONDO_DE_CAJA()
        'Try
        '    lblDineroEncajaTurno.Text = lblfondodeCaja.Text * 1 + LBLVENTASenEfectivo.Text * 1 + lblabonosEfectivo.Text * 1 - lblPAGOSEfectivo.Text * 1 + LBLENTRADASVARIAS.Text * 1 - lblsalidasvarias.Text * 1
        '    lblDineroEncajaTurnoTOTAL.Text = lblDineroEncajaTurno.Text
        '    lblVentas_suma.Text = LBLVentasEnEfectivo2.Text * 1 + lblventas_Tarjeta.Text * 1 + lblVentasAcredito.Text * 1
        'Catch ex As Exception

        'End Try
        'btnCortedeTurno.BackColor = Color.FromArgb(255, 204, 1)
        'btnresumenDia.BackColor = Color.WhiteSmoke

        'Timer1.Start()
        'Panel2.Visible = False

        'CircularProgressBar1.Value = 0
        'CircularProgressBar1.Text = 0
        'TimerCIERRETURNO.Start()
        calculos_cierre_turno()
        TimerCIERRETURNO.Start()

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles lblVentasAcredito.Click, lblVentas_suma.Click, lblabonosEfectivo.Click, LBLENTRADASVARIAS.Click, lblsalidasvarias.Click, lblDineroEncajaTurno.Click, lblPAGOSEfectivo.Click, lblabonosTarjeta.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

        Me.Close()

    End Sub
    Sub calculos_cierre_turno()
        'calcular_cierre_de_turno_ok()
        'btnCortedeTurno.BackColor = Color.FromArgb(255, 204, 1)
        'btnresumenDia.BackColor = Color.WhiteSmoke
        'btnresumenDia.ForeColor = Color.Black
        TimerCIERRETURNO.Start()
        calcular_cierre_de_turno_ok()
    End Sub
    Sub calcular_cierre_de_turno_ok()
        'lbldescripciondeCierre.Text = "Corte de " & VENTAS_MENU_PRINCIPAL.lblLogin.Text & " del "
        MOSTRAR_CIERRE_DE_CAJA_PENDIENTE()
        'lblcaja.Text = VENTAS_MENU_PRINCIPAL.lblcaja.Text

        Try
            lbldesdehasta.Text = "Desde " & fechainicial & " hasta " & lblfechaActual.Value

        Catch ex As Exception

        End Try
        REPORT_GASTOS_VARIOS_por_turnos()
        REPORT_INGRESOS_VARIOS_por_turnos()
        REPORT_COBROS_EN_EFECTIVO_por_turnos()
        REPORT_COBROS_EN_Tarjeta_por_turnos()
        REPORT_PAGOS_EN_EFECTIVO_por_turnos()
        REPORT_VENTAS_por_TURNOS_en_EFECTIVO()
        REPORT_VENTAS_por_TURNOS_Por_tarjeta()
        REPORT_VENTAS_por_TURNOS_Por_Credito()
        REPORT_GANANCIAS_DE_VENTAS_por_TURNOS()
        'Try
        Try
            LBLTOTALVENTAS.Text = DATALISTADO_VENTAS_Efectivo.SelectedCells.Item(1).Value

        Catch ex As Exception
            LBLTOTALVENTAS.Text = 0
        End Try
        LBLVENTASenEfectivo.Text = LBLTOTALVENTAS.Text
        LBLVentasEnEfectivo2.Text = LBLVENTASenEfectivo.Text
        Try
            lblventas_Tarjeta.Text = DATALISTADO_VENTAS_Tarjeta.SelectedCells.Item(1).Value

        Catch ex As Exception
            lblventas_Tarjeta.Text = 0
        End Try
        Try
            lblVentasAcredito.Text = DATALISTADO_VENTAS_Credito.SelectedCells.Item(1).Value

        Catch ex As Exception
            lblVentasAcredito.Text = 0
        End Try

        'Catch ex As Exception
        '    LBLTOTALVENTAS.Text = 0
        '    LBLVENTASenEfectivo.Text = 0
        '    LBLVentasEnEfectivo2.Text = 0
        '    lblventas_Tarjeta.Text = 0
        '    lblVentasAcredito.Text = 0
        'End Try

        MOSTRAR_FONDO_DE_CAJA()
        Try
            lblDineroEncajaTurno.Text = lblfondodeCaja.Text * 1 + LBLVENTASenEfectivo.Text * 1 + lblabonosEfectivo.Text * 1 + lblabonosTarjeta.Text * 1 - lblPAGOSEfectivo.Text * 1 + LBLENTRADASVARIAS.Text * 1 - lblsalidasvarias.Text * 1
            lblDineroEncajaTurnoTOTAL.Text = lblDineroEncajaTurno.Text
            lblVentas_suma.Text = LBLVentasEnEfectivo2.Text * 1 + lblventas_Tarjeta.Text * 1 + lblVentasAcredito.Text * 1
        Catch ex As Exception

        End Try
        LBLTOTALVENTAS.Text = lblVentas_suma.Text

    End Sub
    Private Sub BTNLECTORA_Click(sender As Object, e As EventArgs)

        calculos_cierre_turno()
    End Sub


    Private Sub MenuStrip9_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub



    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel12_Paint(sender As Object, e As PaintEventArgs) Handles Panel12.Paint

    End Sub



    Private Sub lbldesdehasta_Click(sender As Object, e As EventArgs) Handles lbldesdehasta.Click

    End Sub





    Private Sub CircularProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblfechaActual_ValueChanged(sender As Object, e As EventArgs) Handles lblfechaActual.ValueChanged

    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        reporte_cierre_de_caja_form.ShowDialog()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub TimerCIERRETURNO_Tick(sender As Object, e As EventArgs) Handles TimerCIERRETURNO.Tick
        calculos_cierre_turno()
        TimerCIERRETURNO.Stop()
    End Sub
End Class