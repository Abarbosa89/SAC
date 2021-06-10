Public Class SELECCIONARMES

    Private Sub CMDSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSALIR.Click
        Me.Close()

    End Sub

    Private Sub CDMREPORTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CDMREPORTE.Click
        My.Forms.LISTACUMPLEAÑOSS.MdiParent = PADRE
        My.Forms.LISTACUMPLEAÑOSS.Show()

    End Sub
End Class