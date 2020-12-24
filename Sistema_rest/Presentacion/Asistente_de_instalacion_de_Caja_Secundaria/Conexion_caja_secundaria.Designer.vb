<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conexion_caja_secundaria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a hide para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Conexion_caja_secundaria))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtCnString = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.datalistado_movimientos_validar = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtBasededatos = New System.Windows.Forms.TextBox()
        Me.txtservidor = New System.Windows.Forms.TextBox()
        Me.txtcontraseñaBd = New System.Windows.Forms.TextBox()
        Me.txtusuarioBd = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datalistado_movimientos_validar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCnString
        '
        Me.txtCnString.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtCnString.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCnString.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtCnString.ForeColor = System.Drawing.Color.White
        Me.txtCnString.Location = New System.Drawing.Point(23, 56)
        Me.txtCnString.Name = "txtCnString"
        Me.txtCnString.Size = New System.Drawing.Size(494, 25)
        Me.txtCnString.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(373, 27)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Ingrese la IP de la Caja Principal"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.ImageKey = "disk.png"
        Me.btnSave.Location = New System.Drawing.Point(23, 101)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(252, 36)
        Me.btnSave.TabIndex = 36
        Me.btnSave.Text = "Conectar"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(23, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(494, 2)
        Me.Panel1.TabIndex = 37
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtCnString)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Location = New System.Drawing.Point(192, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(630, 578)
        Me.Panel2.TabIndex = 38
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(34, 249)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(580, 324)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(594, 23)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "¿Como Conectar una Computadora Secundaria a la Principal?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 27)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Pregunta Frecuente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 688)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 27)
        Me.Label4.TabIndex = 618
        Me.Label4.Text = "Volver atras"
        '
        'datalistado_movimientos_validar
        '
        Me.datalistado_movimientos_validar.AllowUserToAddRows = False
        Me.datalistado_movimientos_validar.AllowUserToDeleteRows = False
        Me.datalistado_movimientos_validar.AllowUserToResizeRows = False
        Me.datalistado_movimientos_validar.BackgroundColor = System.Drawing.Color.White
        Me.datalistado_movimientos_validar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_movimientos_validar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistado_movimientos_validar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado_movimientos_validar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn5})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datalistado_movimientos_validar.DefaultCellStyle = DataGridViewCellStyle2
        Me.datalistado_movimientos_validar.Location = New System.Drawing.Point(12, 28)
        Me.datalistado_movimientos_validar.Name = "datalistado_movimientos_validar"
        Me.datalistado_movimientos_validar.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_movimientos_validar.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datalistado_movimientos_validar.RowHeadersVisible = False
        Me.datalistado_movimientos_validar.RowHeadersWidth = 5
        Me.datalistado_movimientos_validar.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.ForestGreen
        Me.datalistado_movimientos_validar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado_movimientos_validar.Size = New System.Drawing.Size(174, 192)
        Me.datalistado_movimientos_validar.TabIndex = 619
        '
        'DataGridViewCheckBoxColumn5
        '
        Me.DataGridViewCheckBoxColumn5.DataPropertyName = "Activo"
        Me.DataGridViewCheckBoxColumn5.HeaderText = "Activo"
        Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
        Me.DataGridViewCheckBoxColumn5.ReadOnly = True
        '
        'txtBasededatos
        '
        Me.txtBasededatos.Location = New System.Drawing.Point(40, 72)
        Me.txtBasededatos.Name = "txtBasededatos"
        Me.txtBasededatos.Size = New System.Drawing.Size(105, 20)
        Me.txtBasededatos.TabIndex = 620
        '
        'txtservidor
        '
        Me.txtservidor.Location = New System.Drawing.Point(40, 98)
        Me.txtservidor.Name = "txtservidor"
        Me.txtservidor.Size = New System.Drawing.Size(105, 20)
        Me.txtservidor.TabIndex = 621
        '
        'txtcontraseñaBd
        '
        Me.txtcontraseñaBd.Location = New System.Drawing.Point(40, 125)
        Me.txtcontraseñaBd.Name = "txtcontraseñaBd"
        Me.txtcontraseñaBd.Size = New System.Drawing.Size(105, 20)
        Me.txtcontraseñaBd.TabIndex = 622
        '
        'txtusuarioBd
        '
        Me.txtusuarioBd.Location = New System.Drawing.Point(41, 165)
        Me.txtusuarioBd.Name = "txtusuarioBd"
        Me.txtusuarioBd.Size = New System.Drawing.Size(105, 20)
        Me.txtusuarioBd.TabIndex = 622
        Me.txtusuarioBd.Text = "txtusuarioBd"
        '
        'Conexion_caja_secundaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1064, 715)
        Me.Controls.Add(Me.txtusuarioBd)
        Me.Controls.Add(Me.txtcontraseñaBd)
        Me.Controls.Add(Me.txtservidor)
        Me.Controls.Add(Me.txtBasededatos)
        Me.Controls.Add(Me.datalistado_movimientos_validar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Conexion_caja_secundaria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datalistado_movimientos_validar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCnString As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Public WithEvents datalistado_movimientos_validar As DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn5 As DataGridViewCheckBoxColumn
    Friend WithEvents txtBasededatos As TextBox
    Friend WithEvents txtservidor As TextBox
    Friend WithEvents txtcontraseñaBd As TextBox
    Friend WithEvents txtusuarioBd As TextBox
End Class
