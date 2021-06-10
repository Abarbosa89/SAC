Public Class FECHASPIDENFACTURA

    Private Sub CMDSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSALIR.Click
        Me.Close()
    End Sub

    Private Sub CDMREPORTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CDMREPORTE.Click
        My.Forms.ALUMNOSPIDEFACTURAA.MdiParent = PADRE
        My.Forms.ALUMNOSPIDEFACTURAA.Show()
        Me.Close()
    End Sub

  

End Class