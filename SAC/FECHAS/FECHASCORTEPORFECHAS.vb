Public Class FECHASCORTEPORFECHAS

    Private Sub CDMREPORTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CDMREPORTE.Click
        My.Forms.CORTEPORFECHASS.MdiParent = PADRE
        My.Forms.CORTEPORFECHASS.Show()
        Me.Close()
    End Sub

    Private Sub CMDSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSALIR.Click
        Me.Close()
    End Sub
End Class