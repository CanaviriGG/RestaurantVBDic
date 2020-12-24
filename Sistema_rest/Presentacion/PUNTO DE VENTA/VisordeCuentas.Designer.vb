<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisordeCuentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VisordeCuentas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.datalistadoPedidos = New System.Windows.Forms.DataGridView()
        Me.TMesa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Consumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.datalistadoPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.datalistadoPedidos)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(369, 498)
        Me.Panel1.TabIndex = 0
        '
        'datalistadoPedidos
        '
        Me.datalistadoPedidos.AllowUserToAddRows = False
        Me.datalistadoPedidos.AllowUserToDeleteRows = False
        Me.datalistadoPedidos.BackgroundColor = System.Drawing.Color.White
        Me.datalistadoPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datalistadoPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistadoPedidos.ColumnHeadersVisible = False
        Me.datalistadoPedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TMesa, Me.Pedido, Me.Consumo})
        Me.datalistadoPedidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datalistadoPedidos.GridColor = System.Drawing.Color.WhiteSmoke
        Me.datalistadoPedidos.Location = New System.Drawing.Point(0, 38)
        Me.datalistadoPedidos.Name = "datalistadoPedidos"
        Me.datalistadoPedidos.ReadOnly = True
        Me.datalistadoPedidos.RowTemplate.Height = 45
        Me.datalistadoPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistadoPedidos.Size = New System.Drawing.Size(369, 460)
        Me.datalistadoPedidos.TabIndex = 636
        '
        'TMesa
        '
        Me.TMesa.HeaderText = "Mesa"
        Me.TMesa.Name = "TMesa"
        Me.TMesa.ReadOnly = True
        '
        'Pedido
        '
        Me.Pedido.HeaderText = "Pedido"
        Me.Pedido.Name = "Pedido"
        Me.Pedido.ReadOnly = True
        '
        'Consumo
        '
        Me.Consumo.HeaderText = "Consumo"
        Me.Consumo.Name = "Consumo"
        Me.Consumo.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 38)
        Me.Label1.TabIndex = 635
        Me.Label1.Text = "Cuentas abiertas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(369, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(431, 498)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 498)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 67)
        Me.Panel3.TabIndex = 2
        '
        'VisordeCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 565)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VisordeCuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VisordeCuentas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.datalistadoPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents datalistadoPedidos As DataGridView
    Friend WithEvents Mesa As DataGridViewTextBoxColumn
    Friend WithEvents TMesa As DataGridViewTextBoxColumn
    Friend WithEvents Pedido As DataGridViewTextBoxColumn
    Friend WithEvents Consumo As DataGridViewTextBoxColumn
End Class
