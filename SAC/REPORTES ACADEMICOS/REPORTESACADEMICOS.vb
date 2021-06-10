Public Class REPORTESACADEMICOS

    Private Sub CMDLISTAALUMNOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDLISTAALUMNOS.Click
        BANDERAREPORTE = 1
        My.Forms.SELECCIONARESCOLARIDAD.MdiParent = PADRE
        My.Forms.SELECCIONARESCOLARIDAD.Show()
        Me.Close()

    End Sub

    Private Sub CMDSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSALIR.Click
        Me.Close()
    End Sub

    Private Sub CMDLISTAASISTENCIA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDLISTAASISTENCIA.Click
        BANDERAREPORTE = 2
        My.Forms.SELECCIONARESCOLARIDAD.MdiParent = PADRE
        My.Forms.SELECCIONARESCOLARIDAD.Show()
        Me.Close()
    End Sub

    Private Sub CMDLISTACORREOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDLISTACORREOS.Click
        BANDERAREPORTE = 3
        My.Forms.SELECCIONARESCOLARIDAD.MdiParent = PADRE
        My.Forms.SELECCIONARESCOLARIDAD.Show()
        Me.Close()
    End Sub

    Private Sub CMDLISTACUMPLE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDLISTACUMPLE.Click
        BANDERAREPORTE = 4
        My.Forms.SELECCIONARESCOLARIDAD.MdiParent = PADRE
        My.Forms.SELECCIONARESCOLARIDAD.Show()
        Me.Close()
    End Sub
End Class