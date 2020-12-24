Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class Ticket_pedido_listo
    Inherits Telerik.Reporting.Report
    Public Sub New()

        InitializeComponent()
        'Report1()

    End Sub
    Public Function Report1()
        ' Required for telerik Reporting designer support
        Dim oldItemX As Unit = Me.Table1.Size.Height
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        'rpt.PageSettings.PaperSize = New SizeU(Unit.Mm(90), Unit.Mm(30) + Unit.Mm(80) * 0.7)
        Me.PageSettings.PaperSize = New SizeU(Unit.Mm(90), oldItemX)
        'Dim cantidad As Integer
        'cantidad = Me.Table1.RowGroups.Count()
        MessageBox.Show(ReportHeaderSection1.Height.ToString())


        'Dim heigtFactor As Double = 6
        'Me.SetReportWidth(heigtFactor)
        'Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        'Me.PageSettings.PaperSize = New SizeU(Unit.Mm(90), Unit.Mm(45))
        'detail.Height = Unit.Mm(300)
        'detail.w = Unit.Mm(1)
    End Function

    Private Sub SetReportWidth(heigtFactor As Double)
        ' This will effectively resize each report section as well

        'Me.w *= heigtFactor
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Dim oldPaperSize As SizeU = Me.PageSettings.PaperSize
        Dim newPaperSize As New SizeU(oldPaperSize.Height, oldPaperSize.Height * heigtFactor)
        Me.PageSettings.PaperSize = newPaperSize
        Me.UpdateItemWidthAndLocation(Me, heigtFactor)

    End Sub

    Private Sub UpdateItemWidthAndLocation(reportItem As ReportItemBase, widthFactor As Double)

        Try
            If reportItem Is reportItem Then
                Dim item As ReportItem = CType(reportItem, ReportItem)
                item.Width *= widthFactor
                Dim oldItemX As Unit = item.Location.X
                Dim xValue As Double = oldItemX.Value * widthFactor
                Dim newItemX As New Unit(xValue, oldItemX.Type)
                item.Location = New PointU(newItemX, item.Location.Y)

            End If
        Catch ex As Exception

        End Try


        For Each item As ReportItemBase In reportItem.Items
            Me.UpdateItemWidthAndLocation(item, widthFactor)

        Next

    End Sub



End Class