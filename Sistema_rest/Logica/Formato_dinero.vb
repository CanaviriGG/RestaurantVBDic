Module Formato_dinero
    Public Sub formatodinero(ByRef resultado As String)
        resultado = Format(CType(resultado, Decimal), "##0.00")
    End Sub
End Module
