Public Class RANGOFECHAS

    Private Sub CDMREPORTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CDMREPORTE.Click
        My.Forms.ACTIVIDADUSUARIOSPORFECHA.MdiParent = PADRE
        My.Forms.ACTIVIDADUSUARIOSPORFECHA.Show()
        Me.Close()
    End Sub

    Private Sub CMDSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSALIR.Click
        Me.Close()
    End Sub
End Class