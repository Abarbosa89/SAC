Imports System.Data.SqlClient
Imports System.Data
Public Class AgregarNuevoCiclo
    Dim vUltimoCiclo As Integer
    Private Sub Limpiar()
        vUltimoCiclo = 0
    End Sub
    Private Sub AgregarNuevoCiclo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdCrear_Click(sender As Object, e As EventArgs) Handles cmdCrear.Click
        Dim sSQL As String = ""
        Dim dtDatos As New DataTable
        Dim drDatos As DataRow
        Dim vUltimoCiclo As Integer
        Dim vUltimoCicloNvo As Integer
        Try
            If cboCicloIni.Text = "" Or cbdCicloFin.Text = "" Then
                MsgBox("Debe selecciona un Ciclo", MsgBoxStyle.Exclamation, Me.Text)
            Else
                sSQL = "SELECT MAX(IDCICLO) AS CICLO FROM CICLOSESCOLARES"
                dtDatos = sqlServer.ExecSQLReturnDT(sSQL, "CICLOSESCOLARES")

                drDatos = dtDatos.Rows(0)
                vUltimoCiclo = drDatos("CICLO").ToString

                Dim com As SqlCommand = con.CreateCommand()
                con.Open()
                com = New SqlCommand("CREARCICLO", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@CICLO", SqlDbType.NVarChar).Value = cboCicloIni.Text & "-" & cbdCicloFin.Text
                com.Parameters.Add("@FECHAINI", SqlDbType.Date).Value = dtFInicio.Value
                com.Parameters.Add("@FECHAFIN", SqlDbType.Date).Value = dtFFinal.Value
                com.ExecuteNonQuery()
                con.Close()

                sSQL = "SELECT MAX(IDCICLO) AS CICLO FROM CICLOSESCOLARES"
                dtDatos = sqlServer.ExecSQLReturnDT(sSQL, "CICLOSESCOLARES")

                drDatos = dtDatos.Rows(0)
                vUltimoCicloNvo = drDatos("CICLO").ToString

                sSQL = "SELECT id, idproduct, idciclo, monto FROM COSTOSPRODCICLO WHERE idciclo = " & vUltimoCiclo
                dtDatos = sqlServer.ExecSQLReturnDT(sSQL, "CICLOSESCOLARES")
                If dtDatos Is Nothing OrElse dtDatos.Rows.Count <= 0 Then
                    MsgBox("No se pueden obtener los parámetros! Por favor avise a sistemas!", MsgBoxStyle.Exclamation, "Facturacion")
                    Exit Sub
                Else
                    drDatos = dtDatos.Rows(0)
                    For x = 0 To dtDatos.Rows.Count
                        sSQL = "INSERT INTO COSTOSPRODCICLO (idproduct, idciclo, monto) "
                        sSQL = sSQL & "VALUES (" & drDatos("idproduct").ToString & "," & vUltimoCicloNvo & "," & drDatos("monto").ToString & ") "
                    Next

                End If

                con.Open()
                com = New SqlCommand("REGISTRODEACTIVIDAD", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "CREACION DE CICLO " & cboCicloIni.Text & "-" & cbdCicloFin.Text
                com.ExecuteNonQuery()
                con.Close()

                MsgBox("Nuevo Ciclo Creado", MsgBoxStyle.Information, Me.Text)
                Me.Close()
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub
End Class