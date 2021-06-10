Public Class REPORTESCOSTOS

    Private Sub CMDSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSALIR.Click
        Me.Close()

    End Sub

    Private Sub CMDCOSTOSPRODUCTOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCOSTOSPRODUCTOS.Click
        My.Forms.REPORTECOSTOSPRODUCTOSS.MdiParent = PADRE
        My.Forms.REPORTECOSTOSPRODUCTOSS.Show()
        Me.Close()
    End Sub

    Private Sub CMDCOSTOSUNIFORMES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCOSTOSUNIFORMES.Click
        My.Forms.REPORTECOSTOSUNIFORMESS.MdiParent = PADRE
        My.Forms.REPORTECOSTOSUNIFORMESS.Show()
        Me.Close()
    End Sub
End Class