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
            sqlServer.Init(, "SAC", "192.168.1.66", "sa", "MenoVargas45")

            'se ejecuta una consulta para probar la conexión
            sqlServer.ExecSQL("USE SAC")

            'obteniendo el numero de la sucursal
            sSQL = "SELECT TOP 1 * FROM SAC.dbo.CICLOSESCOLARES"
            dtPaso = sqlServer.ExecSQLReturnDT(sSQL)
            If Not dtPaso Is Nothing AndAlso dtPaso.Rows.Count > 0 Then

            End If
        Catch ex As Exception
            MsgBox("Error al intentar conectar al servidor, por favor avise a sistemas!", MsgBoxStyle.Exclamation, "SAC")
            End
        End Try

    End Sub

    Public Sub ConectaBDBuffer()
        Dim sSQL As String = ""
        Try
            conBuffer = New OleDb.OleDbConnection
            conBuffer.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Buffer\SACBuffer.mdb"
            conBuffer.Open()
        Catch ex As Exception
            MsgBox("Error al intentar conectar al Buffer, por favor avise a sistemas!", MsgBoxStyle.Exclamation, "SAC")
            End
        End Try

    End Sub

    Function DameFechaUltimoCorte() As String
        Dim sSQL As String = ""
        Dim dtPaso As New DataTable
        Dim drPaso As DataRow

        sSQL = "SELECT MAX(FechaCorte) AS Fecha FROM CIERREDIARIO"
        dtPaso = sqlServer.ExecSQLReturnDT(sSQL)
        If Not dtPaso Is Nothing AndAlso dtPaso.Rows.Count > 0 Then
            drPaso = dtPaso.Rows(0)
            DameFechaUltimoCorte = drPaso("Fecha").ToString
        Else
            DameFechaUltimoCorte = "SIN FECHA"
        End If

    End Function

    Function DataVacio(ByVal DT As DataTable) As Boolean
        If DT Is Nothing Or DT.Rows.Count = 0 Then
            DataVacio = True
        Else
            DataVacio = False
        End If


    End Function

    Function DataVacioBuffer(ByVal DT As OleDb.OleDbDataAdapter) As Boolean
        If DT Is Nothing Then
            DataVacioBuffer = True
        Else
            DataVacioBuffer = False
        End If
    End Function

    Function ReimpresionTicket(ByVal Folio As Integer, ByVal Tipo As Integer) As DataTable
        'VAriable Tipo: Es para saber si es Recibo Productos = 1 o REcibo Colegiatura/Inscripcion = 2

        Dim sSQL As String = ""
        If Tipo = 1 Then
            sSQL = "SELECT b.nombre + ' ' + b.appat + ' ' + b.apmat AS Alumno, c.CICLO AS Ciclo, ' ' AS Escolaridad, IIF(a.cantidad IS NULL, 1, a.cantidad) AS Cantidad, "
            sSQL = sSQL & "a.descripcion AS Concepto, a.total AS Importe, u.nomcom AS Cajero, a.numrecibo as Folio, a.matri as Matricula, a.resta AS Resta, "
            sSQL = sSQL & "t.tipopago AS TipoPago "
            sSQL = sSQL & "FROM MOVIMIENTOS a "
            sSQL = sSQL & "INNER JOIN ALUMNOS b ON a.matri = b.matri "
            sSQL = sSQL & "INNER JOIN CICLOSESCOLARES c ON a.idciclo = c.IDCICLO "
            sSQL = sSQL & "INNER JOIN USUARIOS u ON a.idus = u.idus "
            sSQL = sSQL & "INNER JOIN TIPOSPAGO t ON a.idtipopago = t.idtipopago "
            sSQL = sSQL & "WHERE a.numrecibo = " & Folio
        ElseIf Tipo = 2 Then
            sSQL = "SELECT b.nombre + ' ' + b.appat + ' ' + b.apmat AS Alumno, c.CICLO AS Ciclo, ' ' AS Escolaridad, IIF(a.cantidad IS NULL, 1, a.cantidad) AS Cantidad, "
            sSQL = sSQL & "a.descripcion AS Concepto, a.total AS Importe, u.nomcom AS Cajero, a.numrecibo as Folio, a.matri as Matricula, a.resta AS Resta, "
            sSQL = sSQL & "t.tipopago AS TipoPago "
            sSQL = sSQL & "FROM MOVIMIENTOS a "
            sSQL = sSQL & "INNER JOIN ALUMNOS b ON a.matri = b.matri "
            sSQL = sSQL & "INNER JOIN CICLOSESCOLARES c ON a.idciclo = c.IDCICLO "
            sSQL = sSQL & "INNER JOIN USUARIOS u ON a.idus = u.idus "
            sSQL = sSQL & "INNER JOIN TIPOSPAGO t ON a.idtipopago = t.idtipopago "
            sSQL = sSQL & "WHERE a.numfolio = " & Folio
        End If

        ReimpresionTicket = sqlServer.ExecSQLReturnDT(sSQL)

    End Function

End Module
