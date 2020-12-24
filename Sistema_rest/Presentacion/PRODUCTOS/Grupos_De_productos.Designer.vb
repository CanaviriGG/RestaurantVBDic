<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grupos_De_productos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Grupos_De_productos))
        Me.PanelEDICION = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ImagenGrupo = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtgrupo = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.BTNEliminar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.dlg = New System.Windows.Forms.OpenFileDialog()
        Me.PanelEDICION.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEDICION
        '
        Me.PanelEDICION.Controls.Add(Me.Panel1)
        Me.PanelEDICION.Controls.Add(Me.ImagenGrupo)
        Me.PanelEDICION.Controls.Add(Me.Panel3)
        Me.PanelEDICION.Controls.Add(Me.txtgrupo)
        Me.PanelEDICION.Controls.Add(Me.Button9)
        Me.PanelEDICION.Controls.Add(Me.BTNEliminar)
        Me.PanelEDICION.Controls.Add(Me.Button1)
        Me.PanelEDICION.Location = New System.Drawing.Point(3, 68)
        Me.PanelEDICION.Name = "PanelEDICION"
        Me.PanelEDICION.Size = New System.Drawing.Size(328, 378)
        Me.PanelEDICION.TabIndex = 627
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(155, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(170, 120)
        Me.Panel1.TabIndex = 631
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(105, 92)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(53, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 630
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 99)
        Me.Label2.TabIndex = 629
        Me.Label2.Text = "Agregar Icono" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Opcional)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImagenGrupo
        '
        Me.ImagenGrupo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImagenGrupo.Image = Global.ProyRestaurantVB.My.Resources.Resources.advertencia
        Me.ImagenGrupo.Location = New System.Drawing.Point(9, 98)
        Me.ImagenGrupo.Name = "ImagenGrupo"
        Me.ImagenGrupo.Size = New System.Drawing.Size(140, 96)
        Me.ImagenGrupo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImagenGrupo.TabIndex = 628
        Me.ImagenGrupo.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(19, 79)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(284, 1)
        Me.Panel3.TabIndex = 1
        '
        'txtgrupo
        '
        Me.txtgrupo.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.txtgrupo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtgrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtgrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgrupo.ForeColor = System.Drawing.Color.White
        Me.txtgrupo.Location = New System.Drawing.Point(20, 42)
        Me.txtgrupo.Name = "txtgrupo"
        Me.txtgrupo.Size = New System.Drawing.Size(283, 31)
        Me.txtgrupo.TabIndex = 1
        Me.txtgrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button9
        '
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Gray
        Me.Button9.Location = New System.Drawing.Point(37, 327)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(244, 38)
        Me.Button9.TabIndex = 619
        Me.Button9.Text = "Volver"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'BTNEliminar
        '
        Me.BTNEliminar.BackColor = System.Drawing.Color.Transparent
        Me.BTNEliminar.FlatAppearance.BorderSize = 0
        Me.BTNEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTNEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.BTNEliminar.ForeColor = System.Drawing.Color.White
        Me.BTNEliminar.Location = New System.Drawing.Point(37, 283)
        Me.BTNEliminar.Name = "BTNEliminar"
        Me.BTNEliminar.Size = New System.Drawing.Size(244, 38)
        Me.BTNEliminar.TabIndex = 619
        Me.BTNEliminar.Text = "Eliminar"
        Me.BTNEliminar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(37, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(244, 38)
        Me.Button1.TabIndex = 619
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(125, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 37)
        Me.Label1.TabIndex = 626
        Me.Label1.Text = "Grupo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(298, 12)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(33, 33)
        Me.Button7.TabIndex = 625
        Me.Button7.Text = "X"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'dlg
        '
        Me.dlg.FileName = "OpenFileDialog1"
        '
        'Grupos_De_productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(344, 449)
        Me.Controls.Add(Me.PanelEDICION)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Grupos_De_productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grupos_De_productos"
        Me.PanelEDICION.ResumeLayout(False)
        Me.PanelEDICION.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelEDICION As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtgrupo As TextBox
    Friend WithEvents Button9 As Button
    Friend WithEvents BTNEliminar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents ImagenGrupo As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dlg As OpenFileDialog
End Class
