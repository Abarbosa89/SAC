Public Class PROMOCIONES

    Private Sub CMDCRARPRDUCTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCRARPRDUCTO.Click
        My.Forms.CREARPROMOCION.MdiParent = PADRE
        My.Forms.CREARPROMOCION.Show()
        Me.Close()

    End Sub

    Private Sub CMDPAGOSALUM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDPAGOSALUM.Click
        BANDERARECFOLFAC = 1
        My.Forms.INSCRIPCIONCNPROMOCION.MdiParent = PADRE
        My.Forms.INSCRIPCIONCNPROMOCION.Show()
        Me.Close()
    End Sub
End Class