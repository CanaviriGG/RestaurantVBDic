Public Class Configuracion_de_propiedades_de_mesas
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click

        ColorDialog1.ShowDialog()
        CR = ColorDialog1.Color.R
        CG = ColorDialog1.Color.G
        CB = ColorDialog1.Color.B
        txtmesa.BackColor = Color.FromArgb(CR, CG, CB)
    End Sub
    Dim CR As String
    Dim CG As String
    Dim CB As String
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        ColorDialog1.ShowDialog()
        CR = ColorDialog1.Color.R
        CG = ColorDialog1.Color.G
        CB = ColorDialog1.Color.B
        txtmesa.BackColor = Color.FromArgb(CR, CG, CB)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub
End Class