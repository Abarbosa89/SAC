Public Class ACTIVIDADUSUARIOS

    Private Sub CMDGLOBAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGLOBAL.Click
        My.Forms.ACTIVIDADUSAURIOSGLOBALL.MdiParent = PADRE
        My.Forms.ACTIVIDADUSAURIOSGLOBALL.Show()
        Me.Close()

    End Sub

    Private Sub CMDSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSALIR.Click
        My.Forms.REPORTES.MdiParent = PADRE
        My.Forms.REPORTES.Show()
        Me.Close()
    End Sub

    Private Sub CMDPORFECHA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDPORFECHA.Click
        My.Forms.RANGOFECHAS.MdiParent = PADRE
        My.Forms.RANGOFECHAS.Show()
        Me.Close()
    End Sub
End Class