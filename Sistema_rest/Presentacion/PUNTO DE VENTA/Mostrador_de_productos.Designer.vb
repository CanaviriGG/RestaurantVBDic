<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mostrador_de_productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mostrador_de_productos))
        Me.PanelProductos = New System.Windows.Forms.FlowLayoutPanel()
        Me.paginaMaxima = New System.Windows.Forms.TextBox()
        Me.paginaInicio = New System.Windows.Forms.TextBox()
        Me.UI_GradientPanel3 = New UIDC.UI_GradientPanel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnadelante = New System.Windows.Forms.Button()
        Me.btnatras = New System.Windows.Forms.Button()
        Me.UI_GradientPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelProductos
        '
        Me.PanelProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelProductos.Location = New System.Drawing.Point(0, 35)
        Me.PanelProductos.Name = "PanelProductos"
        Me.PanelProductos.Size = New System.Drawing.Size(706, 478)
        Me.PanelProductos.TabIndex = 0
        '
        'paginaMaxima
        '
        Me.paginaMaxima.Location = New System.Drawing.Point(134, 12)
        Me.paginaMaxima.Name = "paginaMaxima"
        Me.paginaMaxima.Size = New System.Drawing.Size(101, 20)
        Me.paginaMaxima.TabIndex = 564
        Me.paginaMaxima.Text = "15"
        '
        'paginaInicio
        '
        Me.paginaInicio.Location = New System.Drawing.Point(62, 12)
        Me.paginaInicio.Name = "paginaInicio"
        Me.paginaInicio.Size = New System.Drawing.Size(47, 20)
        Me.paginaInicio.TabIndex = 565
        Me.paginaInicio.Text = "1"
        '
        'UI_GradientPanel3
        '
        Me.UI_GradientPanel3.BackColor = System.Drawing.Color.White
        Me.UI_GradientPanel3.Controls.Add(Me.Label16)
        Me.UI_GradientPanel3.Controls.Add(Me.btnadelante)
        Me.UI_GradientPanel3.Controls.Add(Me.btnatras)
        Me.UI_GradientPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.UI_GradientPanel3.Location = New System.Drawing.Point(0, 0)
        Me.UI_GradientPanel3.Name = "UI_GradientPanel3"
        Me.UI_GradientPanel3.Size = New System.Drawing.Size(706, 35)
        Me.UI_GradientPanel3.TabIndex = 566
        Me.UI_GradientPanel3.UIBackColor = System.Drawing.Color.Navy
        Me.UI_GradientPanel3.UIBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UI_GradientPanel3.UIBottomRight = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UI_GradientPanel3.UIForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UI_GradientPanel3.UIPrimerColor = System.Drawing.Color.MidnightBlue
        Me.UI_GradientPanel3.UIStyle = UIDC.UI_GradientPanel.GradientStyle.Corners
        Me.UI_GradientPanel3.UITopLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UI_GradientPanel3.UITopRight = System.Drawing.Color.Black
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(141, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(424, 35)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "PRODUCTOS"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnadelante
        '
        Me.btnadelante.BackColor = System.Drawing.Color.Transparent
        Me.btnadelante.BackgroundImage = Global.ProyRestaurantVB.My.Resources.Resources.fecha_derecha
        Me.btnadelante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnadelante.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnadelante.FlatAppearance.BorderSize = 0
        Me.btnadelante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnadelante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnadelante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadelante.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadelante.ForeColor = System.Drawing.Color.White
        Me.btnadelante.Location = New System.Drawing.Point(565, 0)
        Me.btnadelante.Name = "btnadelante"
        Me.btnadelante.Size = New System.Drawing.Size(141, 35)
        Me.btnadelante.TabIndex = 7
        Me.btnadelante.UseVisualStyleBackColor = False
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.Color.Transparent
        Me.btnatras.BackgroundImage = Global.ProyRestaurantVB.My.Resources.Resources.fecha_izquierda
        Me.btnatras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnatras.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnatras.FlatAppearance.BorderSize = 0
        Me.btnatras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnatras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnatras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnatras.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnatras.ForeColor = System.Drawing.Color.White
        Me.btnatras.Location = New System.Drawing.Point(0, 0)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(141, 35)
        Me.btnatras.TabIndex = 6
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'Mostrador_de_productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 513)
        Me.Controls.Add(Me.PanelProductos)
        Me.Controls.Add(Me.UI_GradientPanel3)
        Me.Controls.Add(Me.paginaMaxima)
        Me.Controls.Add(Me.paginaInicio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Mostrador_de_productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mostrador_de_productos"
        Me.UI_GradientPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelProductos As FlowLayoutPanel
    Friend WithEvents paginaMaxima As TextBox
    Friend WithEvents paginaInicio As TextBox
    Friend WithEvents UI_GradientPanel3 As UIDC.UI_GradientPanel
    Friend WithEvents Label16 As Label
    Friend WithEvents btnadelante As Button
    Friend WithEvents btnatras As Button
End Class
