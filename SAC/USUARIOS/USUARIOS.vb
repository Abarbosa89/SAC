Public Class USUARIOS

    Private Sub CMDSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSALIR.Click
        My.Forms.ADMINISTRATIVO.MdiParent = PADRE
        My.Forms.ADMINISTRATIVO.Show()
        Me.Close()

    End Sub

    Private Sub CMDNUEVOUSUARIO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDNUEVOUSUARIO.Click
        My.Forms.NUEVOUSUARIO.MdiParent = PADRE
        My.Forms.NUEVOUSUARIO.Show()
        Me.Close()
    End Sub


    Private Sub CMDEDITARUSUARIO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEDITARUSUARIO.Click
        My.Forms.EDITARUSUARIO.MdiParent = PADRE
        My.Forms.EDITARUSUARIO.Show()
        Me.Close()
    End Sub

    Private Sub CMDPASSWORD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDPASSWORD.Click
        My.Forms.NUEVOPASSWORD.MdiParent = PADRE
        My.Forms.NUEVOPASSWORD.Show()
    End Sub
End Class