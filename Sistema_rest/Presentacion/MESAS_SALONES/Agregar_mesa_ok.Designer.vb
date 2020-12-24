<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_mesa_ok
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
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelEDICION = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtmesaedicion = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.BTNEliminar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelEDICION.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(316, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(33, 33)
        Me.Button7.TabIndex = 621
        Me.Button7.Text = "X"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(134, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 37)
        Me.Label1.TabIndex = 622
        Me.Label1.Text = "Mesa"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelEDICION
        '
        Me.PanelEDICION.Controls.Add(Me.Panel3)
        Me.PanelEDICION.Controls.Add(Me.txtmesaedicion)
        Me.PanelEDICION.Controls.Add(Me.Button9)
        Me.PanelEDICION.Controls.Add(Me.BTNEliminar)
        Me.PanelEDICION.Controls.Add(Me.Button1)
        Me.PanelEDICION.Location = New System.Drawing.Point(12, 68)
        Me.PanelEDICION.Name = "PanelEDICION"
        Me.PanelEDICION.Size = New System.Drawing.Size(328, 251)
        Me.PanelEDICION.TabIndex = 624
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(19, 79)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(284, 1)
        Me.Panel3.TabIndex = 1
        '
        'txtmesaedicion
        '
        Me.txtmesaedicion.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.txtmesaedicion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmesaedicion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmesaedicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmesaedicion.ForeColor = System.Drawing.Color.White
        Me.txtmesaedicion.Location = New System.Drawing.Point(20, 42)
        Me.txtmesaedicion.Name = "txtmesaedicion"
        Me.txtmesaedicion.Size = New System.Drawing.Size(283, 31)
        Me.txtmesaedicion.TabIndex = 1
        Me.txtmesaedicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button9
        '
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Gray
        Me.Button9.Location = New System.Drawing.Point(39, 182)
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
        Me.BTNEliminar.Location = New System.Drawing.Point(39, 138)
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
        Me.Button1.Location = New System.Drawing.Point(39, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(244, 38)
        Me.Button1.TabIndex = 619
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Agregar_mesa_ok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(352, 335)
        Me.Controls.Add(Me.PanelEDICION)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Agregar_mesa_ok"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar_mesa_ok"
        Me.PanelEDICION.ResumeLayout(False)
        Me.PanelEDICION.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button7 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelEDICION As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtmesaedicion As TextBox
    Friend WithEvents Button9 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents BTNEliminar As Button
End Class
