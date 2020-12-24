<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Impresoras
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PanelImpresoras = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel_Bienvenida = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Telerik.ReportViewer.WinForms.ReportViewer()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelImpresoras.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panel_Bienvenida.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btn1)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn2)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn3)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn4)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 43)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(306, 448)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btn1
        '
        Me.btn1.FlatAppearance.BorderSize = 0
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.Color.White
        Me.btn1.Location = New System.Drawing.Point(3, 3)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(295, 43)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Impresora para Envios de Pedidos"
        Me.btn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.FlatAppearance.BorderSize = 0
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.Color.White
        Me.btn2.Location = New System.Drawing.Point(3, 52)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(295, 43)
        Me.btn2.TabIndex = 1
        Me.btn2.Text = "Impresora para Pre-cuenta"
        Me.btn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.FlatAppearance.BorderSize = 0
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.ForeColor = System.Drawing.Color.White
        Me.btn3.Location = New System.Drawing.Point(3, 101)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(295, 43)
        Me.btn3.TabIndex = 2
        Me.btn3.Text = "Impresora para CAJA"
        Me.btn3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.FlatAppearance.BorderSize = 0
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.ForeColor = System.Drawing.Color.White
        Me.btn4.Location = New System.Drawing.Point(3, 150)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(295, 43)
        Me.btn4.TabIndex = 3
        Me.btn4.Text = "Impresora para Reportes"
        Me.btn4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn4.UseVisualStyleBackColor = True
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.AllowUserToOrderColumns = True
        Me.datalistado.BackgroundColor = System.Drawing.Color.White
        Me.datalistado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datalistado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datalistado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.datalistado.EnableHeadersVisualStyles = False
        Me.datalistado.GridColor = System.Drawing.Color.LightGray
        Me.datalistado.Location = New System.Drawing.Point(37, 46)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.RowHeadersVisible = False
        Me.datalistado.RowHeadersWidth = 5
        Me.datalistado.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.datalistado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray
        Me.datalistado.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datalistado.RowTemplate.Height = 60
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(126, 102)
        Me.datalistado.TabIndex = 626
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Visible = False
        '
        'PanelImpresoras
        '
        Me.PanelImpresoras.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.PanelImpresoras.Controls.Add(Me.Panel2)
        Me.PanelImpresoras.Location = New System.Drawing.Point(423, 193)
        Me.PanelImpresoras.Name = "PanelImpresoras"
        Me.PanelImpresoras.Size = New System.Drawing.Size(480, 491)
        Me.PanelImpresoras.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(160, 158)
        Me.Panel2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Label2"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(306, 491)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Impresoras"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel_Bienvenida
        '
        Me.panel_Bienvenida.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.panel_Bienvenida.Controls.Add(Me.Label3)
        Me.panel_Bienvenida.Controls.Add(Me.datalistado)
        Me.panel_Bienvenida.Controls.Add(Me.ReportViewer1)
        Me.panel_Bienvenida.Location = New System.Drawing.Point(351, 22)
        Me.panel_Bienvenida.Name = "panel_Bienvenida"
        Me.panel_Bienvenida.Size = New System.Drawing.Size(260, 296)
        Me.panel_Bienvenida.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 296)
        Me.Label3.TabIndex = 627
        Me.Label3.Text = "Elije una Opcion para Empezar"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(64, 64)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(121, 71)
        Me.ReportViewer1.TabIndex = 628
        '
        'Impresoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 491)
        Me.Controls.Add(Me.panel_Bienvenida)
        Me.Controls.Add(Me.PanelImpresoras)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Impresoras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelImpresoras.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.panel_Bienvenida.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents PanelImpresoras As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents panel_Bienvenida As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ReportViewer1 As Telerik.ReportViewer.WinForms.ReportViewer
End Class
