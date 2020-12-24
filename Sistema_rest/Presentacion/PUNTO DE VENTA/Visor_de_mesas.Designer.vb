<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Visor_de_mesas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Visor_de_mesas))
        Me.PanelMesas = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelSalones = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panelbotones = New System.Windows.Forms.Panel()
        Me.btnserviciorapido = New System.Windows.Forms.Button()
        Me.btnHerramientas = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnCambiomesa = New System.Windows.Forms.Button()
        Me.btnvercuentas = New System.Windows.Forms.Button()
        Me.btndelibery = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.datalistadoUsuariosMesas = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DATALISTADO_PRODUCTOS_OKA_libre = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DATALISTADO_PRODUCTOS_OKA = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn9 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PanelUNIONMesas = New System.Windows.Forms.Panel()
        Me.txtpaso = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panel_PARA_MOSTRAR_FORMULARIOS = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelHerramientasC = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnadministrar = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.PanelBienvenida = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelSalones.SuspendLayout()
        Me.Panelbotones.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.datalistadoUsuariosMesas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DATALISTADO_PRODUCTOS_OKA_libre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DATALISTADO_PRODUCTOS_OKA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelUNIONMesas.SuspendLayout()
        Me.panel_PARA_MOSTRAR_FORMULARIOS.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelHerramientasC.SuspendLayout()
        Me.PanelBienvenida.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMesas
        '
        Me.PanelMesas.BackColor = System.Drawing.Color.Black
        Me.PanelMesas.Location = New System.Drawing.Point(113, 196)
        Me.PanelMesas.Name = "PanelMesas"
        Me.PanelMesas.Size = New System.Drawing.Size(725, 541)
        Me.PanelMesas.TabIndex = 2
        Me.PanelMesas.Visible = False
        '
        'PanelSalones
        '
        Me.PanelSalones.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.PanelSalones.Controls.Add(Me.FlowLayoutPanel1)
        Me.PanelSalones.Controls.Add(Me.Panelbotones)
        Me.PanelSalones.Controls.Add(Me.PanelUNIONMesas)
        Me.PanelSalones.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSalones.Location = New System.Drawing.Point(0, 0)
        Me.PanelSalones.Name = "PanelSalones"
        Me.PanelSalones.Size = New System.Drawing.Size(279, 606)
        Me.PanelSalones.TabIndex = 3
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(279, 288)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Panelbotones
        '
        Me.Panelbotones.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Panelbotones.Controls.Add(Me.btnserviciorapido)
        Me.Panelbotones.Controls.Add(Me.btnHerramientas)
        Me.Panelbotones.Controls.Add(Me.btnsalir)
        Me.Panelbotones.Controls.Add(Me.btnCambiomesa)
        Me.Panelbotones.Controls.Add(Me.btnvercuentas)
        Me.Panelbotones.Controls.Add(Me.btndelibery)
        Me.Panelbotones.Controls.Add(Me.Panel1)
        Me.Panelbotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panelbotones.Location = New System.Drawing.Point(0, 288)
        Me.Panelbotones.Name = "Panelbotones"
        Me.Panelbotones.Size = New System.Drawing.Size(279, 318)
        Me.Panelbotones.TabIndex = 2
        '
        'btnserviciorapido
        '
        Me.btnserviciorapido.BackColor = System.Drawing.Color.Transparent
        Me.btnserviciorapido.BackgroundImage = Global.ProyRestaurantVB.My.Resources.Resources.verde
        Me.btnserviciorapido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnserviciorapido.FlatAppearance.BorderSize = 0
        Me.btnserviciorapido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnserviciorapido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnserviciorapido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnserviciorapido.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnserviciorapido.ForeColor = System.Drawing.Color.White
        Me.btnserviciorapido.Location = New System.Drawing.Point(135, 68)
        Me.btnserviciorapido.Name = "btnserviciorapido"
        Me.btnserviciorapido.Size = New System.Drawing.Size(131, 77)
        Me.btnserviciorapido.TabIndex = 641
        Me.btnserviciorapido.Text = "Servicio Rapido"
        Me.btnserviciorapido.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnserviciorapido.UseVisualStyleBackColor = False
        '
        'btnHerramientas
        '
        Me.btnHerramientas.BackColor = System.Drawing.Color.Transparent
        Me.btnHerramientas.BackgroundImage = Global.ProyRestaurantVB.My.Resources.Resources.Rojo
        Me.btnHerramientas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHerramientas.FlatAppearance.BorderSize = 0
        Me.btnHerramientas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHerramientas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHerramientas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHerramientas.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHerramientas.ForeColor = System.Drawing.Color.White
        Me.btnHerramientas.Location = New System.Drawing.Point(135, 235)
        Me.btnHerramientas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.btnHerramientas.Name = "btnHerramientas"
        Me.btnHerramientas.Size = New System.Drawing.Size(131, 75)
        Me.btnHerramientas.TabIndex = 640
        Me.btnHerramientas.Text = "Herramientas"
        Me.btnHerramientas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHerramientas.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.Transparent
        Me.btnsalir.BackgroundImage = Global.ProyRestaurantVB.My.Resources.Resources.naranja
        Me.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsalir.FlatAppearance.BorderSize = 0
        Me.btnsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalir.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.Color.White
        Me.btnsalir.Location = New System.Drawing.Point(8, 233)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(117, 77)
        Me.btnsalir.TabIndex = 639
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'btnCambiomesa
        '
        Me.btnCambiomesa.BackColor = System.Drawing.Color.Transparent
        Me.btnCambiomesa.BackgroundImage = Global.ProyRestaurantVB.My.Resources.Resources.verde
        Me.btnCambiomesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCambiomesa.FlatAppearance.BorderSize = 0
        Me.btnCambiomesa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCambiomesa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCambiomesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiomesa.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiomesa.ForeColor = System.Drawing.Color.White
        Me.btnCambiomesa.Location = New System.Drawing.Point(135, 150)
        Me.btnCambiomesa.Name = "btnCambiomesa"
        Me.btnCambiomesa.Size = New System.Drawing.Size(131, 77)
        Me.btnCambiomesa.TabIndex = 638
        Me.btnCambiomesa.Text = "Cambio de mesa"
        Me.btnCambiomesa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCambiomesa.UseVisualStyleBackColor = False
        '
        'btnvercuentas
        '
        Me.btnvercuentas.BackColor = System.Drawing.Color.Transparent
        Me.btnvercuentas.BackgroundImage = Global.ProyRestaurantVB.My.Resources.Resources.verde
        Me.btnvercuentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnvercuentas.FlatAppearance.BorderSize = 0
        Me.btnvercuentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnvercuentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnvercuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnvercuentas.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvercuentas.ForeColor = System.Drawing.Color.White
        Me.btnvercuentas.Location = New System.Drawing.Point(8, 152)
        Me.btnvercuentas.Name = "btnvercuentas"
        Me.btnvercuentas.Size = New System.Drawing.Size(117, 77)
        Me.btnvercuentas.TabIndex = 636
        Me.btnvercuentas.Text = "Ver cuentas"
        Me.btnvercuentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnvercuentas.UseVisualStyleBackColor = False
        '
        'btndelibery
        '
        Me.btndelibery.BackColor = System.Drawing.Color.Transparent
        Me.btndelibery.BackgroundImage = Global.ProyRestaurantVB.My.Resources.Resources.verde
        Me.btndelibery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btndelibery.FlatAppearance.BorderSize = 0
        Me.btndelibery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btndelibery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btndelibery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelibery.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelibery.ForeColor = System.Drawing.Color.White
        Me.btndelibery.Location = New System.Drawing.Point(8, 67)
        Me.btndelibery.Name = "btndelibery"
        Me.btndelibery.Size = New System.Drawing.Size(117, 77)
        Me.btndelibery.TabIndex = 637
        Me.btndelibery.Text = "Delibery"
        Me.btndelibery.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndelibery.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.datalistadoUsuariosMesas)
        Me.Panel1.Controls.Add(Me.DATALISTADO_PRODUCTOS_OKA_libre)
        Me.Panel1.Controls.Add(Me.DATALISTADO_PRODUCTOS_OKA)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 10)
        Me.Panel1.TabIndex = 498
        '
        'datalistadoUsuariosMesas
        '
        Me.datalistadoUsuariosMesas.AllowUserToAddRows = False
        Me.datalistadoUsuariosMesas.AllowUserToDeleteRows = False
        Me.datalistadoUsuariosMesas.AllowUserToResizeRows = False
        Me.datalistadoUsuariosMesas.BackgroundColor = System.Drawing.Color.White
        Me.datalistadoUsuariosMesas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.datalistadoUsuariosMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistadoUsuariosMesas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn3})
        Me.datalistadoUsuariosMesas.EnableHeadersVisualStyles = False
        Me.datalistadoUsuariosMesas.Location = New System.Drawing.Point(-12, 28)
        Me.datalistadoUsuariosMesas.Name = "datalistadoUsuariosMesas"
        Me.datalistadoUsuariosMesas.ReadOnly = True
        Me.datalistadoUsuariosMesas.RowHeadersVisible = False
        Me.datalistadoUsuariosMesas.RowHeadersWidth = 9
        Me.datalistadoUsuariosMesas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.datalistadoUsuariosMesas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datalistadoUsuariosMesas.RowTemplate.Height = 40
        Me.datalistadoUsuariosMesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistadoUsuariosMesas.Size = New System.Drawing.Size(267, 74)
        Me.datalistadoUsuariosMesas.TabIndex = 624
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "Marcar"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Marcar"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.ReadOnly = True
        Me.DataGridViewCheckBoxColumn3.Visible = False
        '
        'DATALISTADO_PRODUCTOS_OKA_libre
        '
        Me.DATALISTADO_PRODUCTOS_OKA_libre.AllowUserToAddRows = False
        Me.DATALISTADO_PRODUCTOS_OKA_libre.AllowUserToDeleteRows = False
        Me.DATALISTADO_PRODUCTOS_OKA_libre.AllowUserToResizeRows = False
        Me.DATALISTADO_PRODUCTOS_OKA_libre.BackgroundColor = System.Drawing.Color.White
        Me.DATALISTADO_PRODUCTOS_OKA_libre.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DATALISTADO_PRODUCTOS_OKA_libre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATALISTADO_PRODUCTOS_OKA_libre.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn2})
        Me.DATALISTADO_PRODUCTOS_OKA_libre.EnableHeadersVisualStyles = False
        Me.DATALISTADO_PRODUCTOS_OKA_libre.Location = New System.Drawing.Point(18, 30)
        Me.DATALISTADO_PRODUCTOS_OKA_libre.Name = "DATALISTADO_PRODUCTOS_OKA_libre"
        Me.DATALISTADO_PRODUCTOS_OKA_libre.ReadOnly = True
        Me.DATALISTADO_PRODUCTOS_OKA_libre.RowHeadersVisible = False
        Me.DATALISTADO_PRODUCTOS_OKA_libre.RowHeadersWidth = 9
        Me.DATALISTADO_PRODUCTOS_OKA_libre.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DATALISTADO_PRODUCTOS_OKA_libre.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DATALISTADO_PRODUCTOS_OKA_libre.RowTemplate.Height = 40
        Me.DATALISTADO_PRODUCTOS_OKA_libre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DATALISTADO_PRODUCTOS_OKA_libre.Size = New System.Drawing.Size(165, 173)
        Me.DATALISTADO_PRODUCTOS_OKA_libre.TabIndex = 495
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Marcar"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Marcar"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        Me.DataGridViewCheckBoxColumn2.Visible = False
        '
        'DATALISTADO_PRODUCTOS_OKA
        '
        Me.DATALISTADO_PRODUCTOS_OKA.AllowUserToAddRows = False
        Me.DATALISTADO_PRODUCTOS_OKA.AllowUserToDeleteRows = False
        Me.DATALISTADO_PRODUCTOS_OKA.AllowUserToResizeRows = False
        Me.DATALISTADO_PRODUCTOS_OKA.BackgroundColor = System.Drawing.Color.White
        Me.DATALISTADO_PRODUCTOS_OKA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DATALISTADO_PRODUCTOS_OKA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATALISTADO_PRODUCTOS_OKA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn9})
        Me.DATALISTADO_PRODUCTOS_OKA.EnableHeadersVisualStyles = False
        Me.DATALISTADO_PRODUCTOS_OKA.Location = New System.Drawing.Point(-55, 30)
        Me.DATALISTADO_PRODUCTOS_OKA.Name = "DATALISTADO_PRODUCTOS_OKA"
        Me.DATALISTADO_PRODUCTOS_OKA.ReadOnly = True
        Me.DATALISTADO_PRODUCTOS_OKA.RowHeadersVisible = False
        Me.DATALISTADO_PRODUCTOS_OKA.RowHeadersWidth = 9
        Me.DATALISTADO_PRODUCTOS_OKA.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DATALISTADO_PRODUCTOS_OKA.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DATALISTADO_PRODUCTOS_OKA.RowTemplate.Height = 40
        Me.DATALISTADO_PRODUCTOS_OKA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DATALISTADO_PRODUCTOS_OKA.Size = New System.Drawing.Size(165, 173)
        Me.DATALISTADO_PRODUCTOS_OKA.TabIndex = 495
        '
        'DataGridViewCheckBoxColumn9
        '
        Me.DataGridViewCheckBoxColumn9.DataPropertyName = "Marcar"
        Me.DataGridViewCheckBoxColumn9.HeaderText = "Marcar"
        Me.DataGridViewCheckBoxColumn9.Name = "DataGridViewCheckBoxColumn9"
        Me.DataGridViewCheckBoxColumn9.ReadOnly = True
        Me.DataGridViewCheckBoxColumn9.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(33, 47)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(124, 21)
        Me.ComboBox1.TabIndex = 497
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(18, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 72)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(3, 30)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(110, 20)
        Me.TextBox2.TabIndex = 496
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(18, 30)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 9
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(70, 103)
        Me.DataGridView1.TabIndex = 495
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Marcar"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Marcar"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(0, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(110, 20)
        Me.TextBox1.TabIndex = 496
        '
        'PanelUNIONMesas
        '
        Me.PanelUNIONMesas.BackColor = System.Drawing.Color.Black
        Me.PanelUNIONMesas.Controls.Add(Me.txtpaso)
        Me.PanelUNIONMesas.Controls.Add(Me.Label1)
        Me.PanelUNIONMesas.Controls.Add(Me.Button3)
        Me.PanelUNIONMesas.Controls.Add(Me.Panel2)
        Me.PanelUNIONMesas.Location = New System.Drawing.Point(17, 22)
        Me.PanelUNIONMesas.Name = "PanelUNIONMesas"
        Me.PanelUNIONMesas.Size = New System.Drawing.Size(262, 271)
        Me.PanelUNIONMesas.TabIndex = 3
        '
        'txtpaso
        '
        Me.txtpaso.AutoSize = True
        Me.txtpaso.ForeColor = System.Drawing.Color.White
        Me.txtpaso.Location = New System.Drawing.Point(44, 62)
        Me.txtpaso.Name = "txtpaso"
        Me.txtpaso.Size = New System.Drawing.Size(41, 13)
        Me.txtpaso.TabIndex = 500
        Me.txtpaso.Text = "txtpaso"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 126)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PASO 1 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Seleccione una mesa de Origen"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 126)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(262, 75)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Cancelar la UNION"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 201)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(262, 70)
        Me.Panel2.TabIndex = 9
        '
        'panel_PARA_MOSTRAR_FORMULARIOS
        '
        Me.panel_PARA_MOSTRAR_FORMULARIOS.Controls.Add(Me.Panel3)
        Me.panel_PARA_MOSTRAR_FORMULARIOS.Controls.Add(Me.PanelSalones)
        Me.panel_PARA_MOSTRAR_FORMULARIOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_PARA_MOSTRAR_FORMULARIOS.Location = New System.Drawing.Point(0, 0)
        Me.panel_PARA_MOSTRAR_FORMULARIOS.Name = "panel_PARA_MOSTRAR_FORMULARIOS"
        Me.panel_PARA_MOSTRAR_FORMULARIOS.Size = New System.Drawing.Size(1188, 606)
        Me.panel_PARA_MOSTRAR_FORMULARIOS.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PanelHerramientasC)
        Me.Panel3.Controls.Add(Me.PanelBienvenida)
        Me.Panel3.Controls.Add(Me.PanelMesas)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(279, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(909, 606)
        Me.Panel3.TabIndex = 624
        '
        'PanelHerramientasC
        '
        Me.PanelHerramientasC.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.PanelHerramientasC.Controls.Add(Me.btnadministrar)
        Me.PanelHerramientasC.Controls.Add(Me.Button21)
        Me.PanelHerramientasC.Controls.Add(Me.Button4)
        Me.PanelHerramientasC.Controls.Add(Me.Button5)
        Me.PanelHerramientasC.Controls.Add(Me.Button6)
        Me.PanelHerramientasC.Controls.Add(Me.Button8)
        Me.PanelHerramientasC.Location = New System.Drawing.Point(30, 492)
        Me.PanelHerramientasC.Name = "PanelHerramientasC"
        Me.PanelHerramientasC.Size = New System.Drawing.Size(755, 84)
        Me.PanelHerramientasC.TabIndex = 623
        Me.PanelHerramientasC.Visible = False
        '
        'btnadministrar
        '
        Me.btnadministrar.BackColor = System.Drawing.Color.Transparent
        Me.btnadministrar.BackgroundImage = Global.ProyRestaurantVB.My.Resources.Resources.azul
        Me.btnadministrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnadministrar.FlatAppearance.BorderSize = 0
        Me.btnadministrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnadministrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnadministrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadministrar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadministrar.ForeColor = System.Drawing.Color.White
        Me.btnadministrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnadministrar.Location = New System.Drawing.Point(3, 3)
        Me.btnadministrar.Name = "btnadministrar"
        Me.btnadministrar.Size = New System.Drawing.Size(117, 77)
        Me.btnadministrar.TabIndex = 0
        Me.btnadministrar.Text = "Administrar"
        Me.btnadministrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnadministrar.UseVisualStyleBackColor = False
        '
        'Button21
        '
        Me.Button21.BackColor = System.Drawing.Color.Transparent
        Me.Button21.BackgroundImage = Global.ProyRestaurantVB.My.Resources.Resources.azul
        Me.Button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button21.FlatAppearance.BorderSize = 0
        Me.Button21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button21.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.ForeColor = System.Drawing.Color.White
        Me.Button21.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button21.Location = New System.Drawing.Point(126, 3)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(117, 77)
        Me.Button21.TabIndex = 9
        Me.Button21.Text = "Cocina"
        Me.Button21.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button21.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.ProyRestaurantVB.My.Resources.Resources.Rojo
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(249, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 77)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Cerrar Todo"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = Global.ProyRestaurantVB.My.Resources.Resources.azul
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(372, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 77)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Ver Ultima Venta"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = Global.ProyRestaurantVB.My.Resources.Resources.azul
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(495, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 77)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Cerrar Caja"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.BackgroundImage = Global.ProyRestaurantVB.My.Resources.Resources.azul
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button8.Location = New System.Drawing.Point(618, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(117, 77)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "MIS VENTAS"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button8.UseVisualStyleBackColor = False
        '
        'PanelBienvenida
        '
        Me.PanelBienvenida.BackColor = System.Drawing.Color.Black
        Me.PanelBienvenida.Controls.Add(Me.Label3)
        Me.PanelBienvenida.Location = New System.Drawing.Point(30, 28)
        Me.PanelBienvenida.Name = "PanelBienvenida"
        Me.PanelBienvenida.Size = New System.Drawing.Size(193, 162)
        Me.PanelBienvenida.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 162)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Elija un Salon Para Iniciar "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Visor_de_mesas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 606)
        Me.Controls.Add(Me.panel_PARA_MOSTRAR_FORMULARIOS)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Visor_de_mesas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visor de mesas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelSalones.ResumeLayout(False)
        Me.Panelbotones.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.datalistadoUsuariosMesas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DATALISTADO_PRODUCTOS_OKA_libre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DATALISTADO_PRODUCTOS_OKA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelUNIONMesas.ResumeLayout(False)
        Me.PanelUNIONMesas.PerformLayout()
        Me.panel_PARA_MOSTRAR_FORMULARIOS.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.PanelHerramientasC.ResumeLayout(False)
        Me.PanelBienvenida.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMesas As FlowLayoutPanel
    Friend WithEvents PanelSalones As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panelbotones As Panel
    Friend WithEvents panel_PARA_MOSTRAR_FORMULARIOS As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents DATALISTADO_PRODUCTOS_OKA As DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn9 As DataGridViewCheckBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DATALISTADO_PRODUCTOS_OKA_libre As DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelUNIONMesas As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtpaso As Label
    Friend WithEvents PanelBienvenida As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnserviciorapido As Button
    Friend WithEvents btnHerramientas As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnCambiomesa As Button
    Friend WithEvents btnvercuentas As Button
    Friend WithEvents btndelibery As Button
    Friend WithEvents PanelHerramientasC As FlowLayoutPanel
    Friend WithEvents btnadministrar As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents datalistadoUsuariosMesas As DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
End Class
