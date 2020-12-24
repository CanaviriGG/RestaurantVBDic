<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuracion_de_propiedades_de_mesas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configuracion_de_propiedades_de_mesas))
        Me.txtmesa = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtmesa
        '
        Me.txtmesa.BackColor = System.Drawing.Color.Crimson
        Me.txtmesa.FlatAppearance.BorderSize = 0
        Me.txtmesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtmesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.txtmesa.ForeColor = System.Drawing.Color.White
        Me.txtmesa.Location = New System.Drawing.Point(81, 144)
        Me.txtmesa.Name = "txtmesa"
        Me.txtmesa.Size = New System.Drawing.Size(93, 77)
        Me.txtmesa.TabIndex = 623
        Me.txtmesa.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(220, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 77)
        Me.Button1.TabIndex = 623
        Me.Button1.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton4})
        Me.StatusStrip1.Location = New System.Drawing.Point(81, 102)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(116, 39)
        Me.StatusStrip1.TabIndex = 624
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButton4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(101, 37)
        Me.ToolStripButton4.Text = "Editar Color"
        Me.ToolStripButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(91, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 625
        Me.Label1.Text = "Disponible"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(227, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 625
        Me.Label2.Text = "Ocupado"
        '
        'StatusStrip2
        '
        Me.StatusStrip2.AutoSize = False
        Me.StatusStrip2.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.StatusStrip2.Location = New System.Drawing.Point(220, 102)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(116, 39)
        Me.StatusStrip2.TabIndex = 624
        Me.StatusStrip2.Text = "StatusStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(101, 37)
        Me.ToolStripButton1.Text = "Editar Color"
        Me.ToolStripButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Gray
        Me.Button8.Location = New System.Drawing.Point(81, 262)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(244, 38)
        Me.Button8.TabIndex = 626
        Me.Button8.Text = "Guardar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(25, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(408, 37)
        Me.Label3.TabIndex = 627
        Me.Label3.Text = "Color de los Botones de Mesas"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(426, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(33, 33)
        Me.Button7.TabIndex = 628
        Me.Button7.Text = "X"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Configuracion_de_propiedades_de_mesas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(460, 332)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtmesa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Configuracion_de_propiedades_de_mesas"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuracion_de_propiedades_de_mesas"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtmesa As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Button8 As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents Button7 As Button
End Class
