Partial Class Ticket_precuenta

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim TableGroup1 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup2 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup3 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup4 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.ReportHeaderSection1 = New Telerik.Reporting.ReportHeaderSection()
        Me.Panel5 = New Telerik.Reporting.Panel()
        Me.Panel4 = New Telerik.Reporting.Panel()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.Panel1 = New Telerik.Reporting.Panel()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.Panel2 = New Telerik.Reporting.Panel()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.Panel3 = New Telerik.Reporting.Panel()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.Table1 = New Telerik.Reporting.Table()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TextBox8
        '
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6272624731063843R), Telerik.Reporting.Drawing.Unit.Cm(0.64953809976577759R))
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox8.Value = "Cant"
        '
        'TextBox10
        '
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.7454752922058105R), Telerik.Reporting.Drawing.Unit.Cm(0.64953809976577759R))
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox10.Value = "Producto"
        '
        'TextBox12
        '
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6272624731063843R), Telerik.Reporting.Drawing.Unit.Cm(0.64953809976577759R))
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox12.Value = "Importe"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0R)
        Me.detail.Name = "detail"
        '
        'ReportHeaderSection1
        '
        Me.ReportHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(5.0R)
        Me.ReportHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel5})
        Me.ReportHeaderSection1.Name = "ReportHeaderSection1"
        '
        'Panel5
        '
        Me.Panel5.Docking = Telerik.Reporting.DockingStyle.Fill
        Me.Panel5.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel4, Me.Panel1, Me.TextBox1, Me.TextBox2, Me.Panel2, Me.Panel3, Me.TextBox7, Me.Table1})
        Me.Panel5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.0R), Telerik.Reporting.Drawing.Unit.Cm(5.0R))
        '
        'Panel4
        '
        Me.Panel4.Docking = Telerik.Reporting.DockingStyle.Bottom
        Me.Panel4.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox14, Me.TextBox15})
        Me.Panel4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(4.1999998092651367R))
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.0R), Telerik.Reporting.Drawing.Unit.Cm(0.800000011920929R))
        '
        'TextBox14
        '
        Me.TextBox14.Docking = Telerik.Reporting.DockingStyle.Left
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0R), Telerik.Reporting.Drawing.Unit.Cm(0.800000011920929R))
        Me.TextBox14.Style.Font.Bold = True
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox14.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox14.Value = "TOTAL:"
        '
        'TextBox15
        '
        Me.TextBox15.Docking = Telerik.Reporting.DockingStyle.Fill
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.0R), Telerik.Reporting.Drawing.Unit.Cm(0.800000011920929R))
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox15.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox15.Value = "=Fields.Total"
        '
        'Panel1
        '
        Me.Panel1.Docking = Telerik.Reporting.DockingStyle.Top
        Me.Panel1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.0R), Telerik.Reporting.Drawing.Unit.Cm(0.13229167461395264R))
        '
        'TextBox1
        '
        Me.TextBox1.Docking = Telerik.Reporting.DockingStyle.Top
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0.13229167461395264R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.0R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox1.Value = "PRE CUENTA"
        '
        'TextBox2
        '
        Me.TextBox2.Docking = Telerik.Reporting.DockingStyle.Top
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0.73229175806045532R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.0R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "=Fields.Empresa"
        '
        'Panel2
        '
        Me.Panel2.Docking = Telerik.Reporting.DockingStyle.Top
        Me.Panel2.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox3, Me.TextBox4})
        Me.Panel2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(1.332291841506958R))
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.0R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        '
        'TextBox3
        '
        Me.TextBox3.Docking = Telerik.Reporting.DockingStyle.Left
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3999998569488525R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox3.Value = "Cajero(a):"
        '
        'TextBox4
        '
        Me.TextBox4.Docking = Telerik.Reporting.DockingStyle.Fill
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.3999998569488525R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.5999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox4.Value = "=Fields.Usuario"
        '
        'Panel3
        '
        Me.Panel3.Docking = Telerik.Reporting.DockingStyle.Top
        Me.Panel3.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox5, Me.TextBox6})
        Me.Panel3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(1.9322919845581055R))
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.0R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        '
        'TextBox5
        '
        Me.TextBox5.Docking = Telerik.Reporting.DockingStyle.Left
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3999998569488525R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox5.Value = "Fecha:"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = False
        Me.TextBox6.CanShrink = False
        Me.TextBox6.Docking = Telerik.Reporting.DockingStyle.Fill
        Me.TextBox6.KeepTogether = True
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.3999998569488525R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.5999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox6.Value = "=Fields.fecha"
        '
        'TextBox7
        '
        Me.TextBox7.Docking = Telerik.Reporting.DockingStyle.Top
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(2.5322918891906738R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.0R), Telerik.Reporting.Drawing.Unit.Cm(0.29999983310699463R))
        Me.TextBox7.Style.Font.Bold = True
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox7.Value = "------------------------------"
        '
        'Table1
        '
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(1.6272624731063843R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(4.7454752922058105R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(1.6272624731063843R)))
        Me.Table1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.71817010641098022R)))
        Me.Table1.Body.SetCellContent(0, 0, Me.TextBox9)
        Me.Table1.Body.SetCellContent(0, 1, Me.TextBox11)
        Me.Table1.Body.SetCellContent(0, 2, Me.TextBox13)
        TableGroup1.Name = "tableGroup"
        TableGroup1.ReportItem = Me.TextBox8
        TableGroup2.Name = "tableGroup1"
        TableGroup2.ReportItem = Me.TextBox10
        TableGroup3.Name = "tableGroup2"
        TableGroup3.ReportItem = Me.TextBox12
        Me.Table1.ColumnGroups.Add(TableGroup1)
        Me.Table1.ColumnGroups.Add(TableGroup2)
        Me.Table1.ColumnGroups.Add(TableGroup3)
        Me.Table1.Docking = Telerik.Reporting.DockingStyle.Fill
        Me.Table1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox9, Me.TextBox11, Me.TextBox13, Me.TextBox8, Me.TextBox10, Me.TextBox12})
        Me.Table1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666R), Telerik.Reporting.Drawing.Unit.Cm(2.8324921131134033R))
        Me.Table1.Name = "Table1"
        TableGroup4.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup4.Name = "detailTableGroup"
        Me.Table1.RowGroups.Add(TableGroup4)
        Me.Table1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.0R), Telerik.Reporting.Drawing.Unit.Cm(1.3677082061767578R))
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = False
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6272624731063843R), Telerik.Reporting.Drawing.Unit.Cm(0.71817010641098022R))
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox9.Value = "=Fields.Cant"
        '
        'TextBox11
        '
        Me.TextBox11.CanGrow = False
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.7454752922058105R), Telerik.Reporting.Drawing.Unit.Cm(0.71817010641098022R))
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox11.Value = "=Fields.Producto"
        '
        'TextBox13
        '
        Me.TextBox13.CanGrow = False
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6272624731063843R), Telerik.Reporting.Drawing.Unit.Cm(0.71817010641098022R))
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox13.Value = "=Fields.Importe"
        '
        'Ticket_precuenta
        '
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.detail, Me.ReportHeaderSection1})
        Me.Name = "Ticket_precuenta"
        Me.PageNumberingStyle = Telerik.Reporting.PageNumberingStyle.ResetNumbering
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PageSettings.PaperSize = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.0R), Telerik.Reporting.Drawing.Unit.Cm(5.0R))
        Me.Style.Font.Name = "Courier New"
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(8.0R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents ReportHeaderSection1 As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents Panel4 As Telerik.Reporting.Panel
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents Panel1 As Telerik.Reporting.Panel
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents Panel2 As Telerik.Reporting.Panel
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents Panel3 As Telerik.Reporting.Panel
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents Table1 As Telerik.Reporting.Table
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents Panel5 As Telerik.Reporting.Panel
End Class