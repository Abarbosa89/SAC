Imports System.Data.SqlClient
Imports System.Data
Public Class DATOSPERALUMNO

    Private Sub CMDGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR.Click
        Try

            NUEVOALUMNO.TXTNOMBRE.Text = TXTNOMBRE.Text & " " & TXTAPPATERNO.Text & " " & TXTAPMATERNO.Text
            Dim com As SqlCommand = con.CreateCommand()
            con.Open()
            com = New SqlCommand("ACTDATOSPERSALUMNO", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = NUEVOALUMNO.TXTMATRICULA.Text
            com.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = TXTNOMBRE.Text
            com.Parameters.Add("@APPATERNO", SqlDbType.NVarChar).Value = TXTAPPATERNO.Text
            com.Parameters.Add("@APMATERNO", SqlDbType.NVarChar).Value = TXTAPMATERNO.Text
            com.ExecuteNonQuery()
            con.Close()
            Me.Hide()

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        Me.Close()
    End Sub

    Private Sub TXTNOMBRE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTNOMBRE.TextChanged
        TXTNOMBRE.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TXTAPMATERNO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTAPMATERNO.TextChanged
        TXTAPMATERNO.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TXTAPPATERNO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTAPPATERNO.TextChanged
        TXTAPPATERNO.CharacterCasing = CharacterCasing.Upper
    End Sub
End Class