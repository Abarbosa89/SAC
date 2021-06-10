Imports System.Data.SqlClient
Imports System.Data
Public Class MODIFICARMOVIMIENTOS

    Private Sub MODIFICARMOVIMIENTOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARMOVIMIENTOS' table. You can move, or remove it, as needed.
        Me.SELECCIONARMOVIMIENTOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARMOVIMIENTOS)
        LBLIDMOV.Hide()
    End Sub

    Private Sub TXTAPPAT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTAPPAT.TextChanged
        SELECCIONARMOVIMIENTOSBindingSource.Filter = String.Format("appat LIKE '%" & TXTAPPAT.Text & "%'")
    End Sub

    Private Sub TXTAPMAT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTAPMAT.TextChanged
        SELECCIONARMOVIMIENTOSBindingSource.Filter = String.Format("apmat LIKE '%" & TXTAPMAT.Text & "%'")
    End Sub

    Private Sub TXTNOMBRE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTNOMBRE.TextChanged
        SELECCIONARMOVIMIENTOSBindingSource.Filter = String.Format("nombre LIKE '%" & TXTNOMBRE.Text & "%'")
    End Sub

    Private Sub CMDGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR.Click
        Try
            Dim com As SqlCommand = con.CreateCommand()
            con.Open()
            com = New SqlCommand("MODIFICARMOVIMIENTOS", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@MONTO", SqlDbType.Money).Value = TXTMONTO.Text
            com.Parameters.Add("@FECHA", SqlDbType.Date).Value = DTFECHA.Value
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
            Me.SELECCIONARMOVIMIENTOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARMOVIMIENTOS)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        Me.Close()
    End Sub
End Class