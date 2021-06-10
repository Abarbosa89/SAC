Public Class MSGBOXX

    Private Sub CMDINSCRIPCION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDINSCRIPCION.Click
        BANDERARECFOLFAC = 1
        BANDERAPAGO = 1
        My.Forms.PAGODEINSCRIPCION.MdiParent = PADRE
        My.Forms.PAGODEINSCRIPCION.Show()
        Me.Close()

    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        My.Forms.ESCOLARES.MdiParent = PADRE
        My.Forms.ESCOLARES.Show()
        My.Forms.SELECCIONDEALUMNO.Close()
        Me.Close()
    End Sub

    Private Sub CMDADEUDOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDADEUDOS.Click
        BANDERARECFOLFAC = 1
        BANDERAPAGO = 3
        My.Forms.PAGARADEUDOS.MdiParent = PADRE
        My.Forms.PAGARADEUDOS.Show()
        Me.Close()
    End Sub

    Private Sub CMDOCLEGIATURA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDOCLEGIATURA.Click
        BANDERARECFOLFAC = 1
        BANDERAPAGO = 2
        My.Forms.PAGOCOLEGIATURA.MdiParent = PADRE
        My.Forms.PAGOCOLEGIATURA.Show()
        Me.Close()
    End Sub
End Class