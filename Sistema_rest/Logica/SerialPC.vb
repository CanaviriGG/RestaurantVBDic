Imports System.Management
Module SerialPC
    Public Sub Obtener_serialPc(ByRef serial As String)
        Dim serialDD As New ManagementObject("Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'")
        serial = serialDD.Properties("SerialNumber").Value.ToString
        serial = Encriptar(serial.Trim())
    End Sub
End Module
