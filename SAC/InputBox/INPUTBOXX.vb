Public Class INPUTBOXX

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        Me.Close()

    End Sub

    Private Sub CMDACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDACEPTAR.Click
        PASSWORD = TXTPASSWORD.Text
        INPUTBOXX2.Show()
        Me.Close()
    End Sub
End Class