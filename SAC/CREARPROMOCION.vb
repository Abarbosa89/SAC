Imports System.Data.SqlClient
Imports System.Data
Public Class CREARPROMOCION
    Dim PORCE As Decimal
    Private Sub CBOPORCENTAJE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOPORCENTAJE.SelectedIndexChanged
        If CBOPORCENTAJE.Text = "OTRO" Then

            PORCE = InputBox("PORCENTA DE BECA?", "PORCENTAJE BECA", 0)
            LBLPORCENTAJE.Text = PORCE / 100
        Else
            LBLPORCENTAJE.Text = CDec(CBOPORCENTAJE.Text) / 100
            CBOPORCENTAJE.Text = CBOPORCENTAJE.Text & "%"
        End If
    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        Me.Close()

    End Sub

    Private Sub CMDGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR.Click
        Try
            If TXTDESCRIPCION.Text = "" Then
                MsgBox("AGRUEGUE LA DESCRIPCION", MsgBoxStyle.Exclamation, "AVISO")
            ElseIf CBOCONCEPTO.Text = "" Then
                MsgBox("SELECCIONE EL CONCEPTO", MsgBoxStyle.Exclamation, "AVISO")
            ElseIf CBOPORCENTAJE.Text = "" Then
                MsgBox("SELECCIONE EL PORCENTAJE", MsgBoxStyle.Exclamation, "AVISO")
            Else
                Dim com As SqlCommand = con.CreateCommand()
                con.Open()
                com = New SqlCommand("CREARPROMOCION", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@DESC", SqlDbType.NVarChar).Value = TXTDESCRIPCION.Text
                com.Parameters.Add("@FECHAINI", SqlDbType.Date).Value = DTFECHAINI.Value
                com.Parameters.Add("@FECHAFIN", SqlDbType.Date).Value = DTFECHAFIN.Value
                com.Parameters.Add("@PORCENTAJE", SqlDbType.Real).Value = LBLPORCENTAJE.Text
                com.Parameters.Add("@CONCEP", SqlDbType.NVarChar).Value = CBOCONCEPTO.Text
                com.ExecuteNonQuery()
                con.Close()

                con.Open()
                com = New SqlCommand("REGISTRODEACTIVIDAD", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "CREACION DE PROMOCION " & TXTDESCRIPCION.Text
                com.ExecuteNonQuery()
                con.Close()

                MsgBox("PROMOCION CREADA", MsgBoxStyle.Information, "GRACIAS")
                Me.Close()
            End If
           

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub CREARPROMOCION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LBLPORCENTAJE.Hide()
    End Sub
End Class