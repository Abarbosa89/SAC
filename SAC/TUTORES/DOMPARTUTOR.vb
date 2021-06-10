Imports System.Data.SqlClient
Imports System.Data
Public Class DOMPARTUTOR

    Private Sub CMDGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR.Click
        If BANDERA = 1 Then
            Try
                Dim com As SqlCommand = con.CreateCommand()
                con.Open()
                com = New SqlCommand("ACTDATOSTUTOR", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@IDTUTOR", SqlDbType.Int).Value = CInt(NUEVOTUTOR.LBLIDTUTOR.Text)
                com.Parameters.Add("@CALLE", SqlDbType.NVarChar).Value = TXTCALLE.Text
                com.Parameters.Add("@NUMERO", SqlDbType.NVarChar).Value = TXTNUMERO.Text
                com.Parameters.Add("@COLONIA", SqlDbType.NVarChar).Value = TXTCOLONIA.Text
                com.Parameters.Add("@CIUDAD", SqlDbType.NVarChar).Value = TXTCIUDAD.Text
                com.Parameters.Add("@ESTADO", SqlDbType.NVarChar).Value = TXTESTADO.Text
                com.Parameters.Add("@PAIS", SqlDbType.NVarChar).Value = TXTPAIS.Text
                com.Parameters.Add("@CP", SqlDbType.NVarChar).Value = TXTCP.Text
                com.ExecuteNonQuery()
                con.Close()
                NUEVOTUTOR.TXTDOMICILIOFISCAL.Text = TXTCALLE.Text & ", " & TXTNUMERO.Text & ", " & TXTCOLONIA.Text & ", " & TXTCP.Text & ", " & TXTCIUDAD.Text & ", " & TXTESTADO.Text
                Me.Hide()
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
                con.Close()
            End Try
        End If

        If BANDERA = 2 Then
            NUEVOTUTOR.TXTDOMICILIOPART.Text = TXTCALLE.Text & ", " & TXTNUMERO.Text & ", " & TXTCOLONIA.Text & ", " & TXTCP.Text & ", " & TXTCIUDAD.Text & ", " & TXTESTADO.Text
            Me.Hide()
        End If
    End Sub


    Private Sub TXTCP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTCP.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TXTCP_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXTCP.Leave
        If TXTCP.TextLength < 5 Then
            MsgBox("El CP esta conformado por 5 digitos", MsgBoxStyle.Critical, "ERROR")
            TXTCP.Focus()
        End If
    End Sub

    Private Sub TXTCALLE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTCALLE.TextChanged
        TXTCALLE.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TXTNUMERO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTNUMERO.TextChanged
        TXTNUMERO.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TXTCOLONIA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTCOLONIA.TextChanged
        TXTCOLONIA.CharacterCasing = CharacterCasing.Upper
    End Sub



    Private Sub TXTCIUDAD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTCIUDAD.TextChanged
        TXTCIUDAD.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TXTESTADO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTESTADO.TextChanged
        TXTESTADO.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TXTPAIS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTPAIS.TextChanged
        TXTPAIS.CharacterCasing = CharacterCasing.Upper
    End Sub
End Class