Imports System.IO
Imports System.Xml
Imports System.Text
Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Cryptography
Imports System.Web.Services
Imports System.Xml.Serialization
Imports System.Net.Mail
Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Net.Security
Module main
    Public Sub ConectaBD()
        Dim sSQL As String = ""
        Dim dtPaso As New DataTable
        Try
            'se establecen los parametros de conexión a la sucursal y se inicializa
            sqlServer.Init(, "SAC", "192.168.3.211", "sa", "masterkey")

            'se ejecuta una consulta para probar la conexión
            sqlServer.ExecSQL("USE SAC")

            'obteniendo el numero de la sucursal
            sSQL = "SELECT TOP 1 * FROM SAC.dbo.CICLOSESCOLARES"
            dtPaso = sqlServer.ExecSQLReturnDT(sSQL)
            If Not dtPaso Is Nothing AndAlso dtPaso.Rows.Count > 0 Then

            End If
        Catch ex As Exception
            MsgBox("Error al intentar conectar al servidor, por favor avise a sistemas!", MsgBoxStyle.Exclamation, "Facturación")
            End
        End Try

    End Sub
End Module
