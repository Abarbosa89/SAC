Public Class PREGUNTA

    Private Sub CMDNUEVOINGRESO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDNUEVOINGRESO.Click
        My.Forms.NUEVOALUMNO.MdiParent = PADRE
        My.Forms.NUEVOALUMNO.Show()
        ESCOLARES.Close()
        Me.Close()

    End Sub


    Private Sub CMDREINSCRIPCION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDREINSCRIPCION.Click
        My.Forms.REINSCRIPCION.MdiParent = PADRE
        My.Forms.REINSCRIPCION.Show()
        ESCOLARES.Close()
        Me.Close()
    End Sub
End Class