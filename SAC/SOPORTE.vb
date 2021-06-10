Public Class SOPORTE

    Private Sub CMDSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSALIR.Click
        Me.Close()
    End Sub

    Private Sub CMDENVIARAZAEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDENVIARAZAEL.Click
        CORREO = 1
        My.Forms.ENVIODECORREO.MdiParent = PADRE
        My.Forms.ENVIODECORREO.Show()
    End Sub

    Private Sub CMDENVIARVARGAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDENVIARVARGAS.Click
        CORREO = 2
        My.Forms.ENVIODECORREO.MdiParent = PADRE
        My.Forms.ENVIODECORREO.Show()
    End Sub
End Class