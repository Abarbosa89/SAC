Public Class DOMPARTALUMNO

    Private Sub CMDGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR.Click
        NUEVOALUMNO.TXTDOMPARTICULA.Text = TXTCALLE.Text & ", " & TXTNUMERO.Text & ", " & TXTCOLONIA.Text & ", " & TXTCP.Text & ", " & TXTCIUDAD.Text & ", " & TXTESTADO.Text
        Me.Hide()

    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        Me.Close()

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

    Private Sub TXTCP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTCP.TextChanged

    End Sub
End Class