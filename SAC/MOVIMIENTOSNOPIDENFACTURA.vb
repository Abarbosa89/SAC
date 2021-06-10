Imports System.Data.SqlClient
Imports System.Data
Public Class MOVIMIENTOSNOPIDENFACTURA


    Private Sub DTFEHCAINI_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTFEHCAINI.ValueChanged
        Try
            Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURATableAdapter.Fill(Me.SACDataSet.SELECCIONARMOVIMIENTOSNOPIDENFACTURA, New System.Nullable(Of Date)(CType(DTFEHCAINI.Value, Date)), New System.Nullable(Of Date)(CType(DTFECHAFIN.Value, Date)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DTFECHAFIN_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTFECHAFIN.ValueChanged
        Try
            Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURATableAdapter.Fill(Me.SACDataSet.SELECCIONARMOVIMIENTOSNOPIDENFACTURA, New System.Nullable(Of Date)(CType(DTFEHCAINI.Value, Date)), New System.Nullable(Of Date)(CType(DTFECHAFIN.Value, Date)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CMDGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR.Click
        Try
            Dim com As SqlCommand = con.CreateCommand()
            con.Open()
            com = New SqlCommand("MODIFICARMOVIMIENTOSAPIDENFACTURA ", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@DIGITOS", SqlDbType.Int).Value = TXTDIGITOSCUENTA.Text
            com.Parameters.Add("@FECHAFAC", SqlDbType.Date).Value = DTFECHAFACTURA.Value
            com.Parameters.Add("@FACTURA", SqlDbType.Bit).Value = CBFACTURA.Checked
            com.Parameters.Add("@IDMOV", SqlDbType.Int).Value = LBLIDMOV.Text
            com.ExecuteNonQuery()
            con.Close()

            con.Open()
            com = New SqlCommand("REGISTRODEACTIVIDAD", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
            com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "MODIFICACION DEL MOVIMIENTO CON ID " & LBLIDMOV.Text
            com.ExecuteNonQuery()
            con.Close()

            MsgBox("MOVIMIENTO MODIFICADO", MsgBoxStyle.Information, "GRACIAS")


        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        My.Forms.ADMINISTRATIVO.MdiParent = PADRE
        My.Forms.ADMINISTRATIVO.Show()
        Me.Close()

    End Sub
End Class