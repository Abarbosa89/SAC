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
            sqlServer.Init(, "SAC", "192.168.3.204", "sa", "masterkey")

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

    Public Sub ConectaBDBuffer()
        Dim sSQL As String = ""
        Try
            sSQL = "INSERT INTO CobroProductos (RESTA, TOTAL, ABONO, DESCRIPCION, NOFACTURA, NORECIBO, NOFOLIO, IDUS, MATRI, IDPRODUC, IDTIPOPAGO, FACTURA, DIGITOSCUENTA, IDCICLO) "
            sSQL = sSQL & "VALUES (0,0,0,'HOLA',0,0,0,0,0,0,0,'NEL','NEL',1020)"
            conBuffer = New OleDb.OleDbConnection
            conBuffer.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Buffer\SACBuffer.mdb"
            conBuffer.Open()
            Dim da = New OleDb.OleDbCommand(sSQL, conBuffer)
            da.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al intentar conectar al Buffer, por favor avise a sistemas!", MsgBoxStyle.Exclamation, "Facturación")
            End
        End Try

    End Sub
End Module
