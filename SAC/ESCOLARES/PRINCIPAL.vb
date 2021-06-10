Public Class PRINCIPAL


    Private Sub CMDSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSALIR.Click
        My.Forms.Intro.Show()
        Intro.TXTPASS.Text = ""
        Me.Close()
        PADRE.Close()
    End Sub

    Private Sub CMDESCOLARES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDESCOLARES.Click
        My.Forms.ESCOLARES.MdiParent = PADRE
        My.Forms.ESCOLARES.Show()
        Me.Close()
    End Sub

    Private Sub CMDADMINISTRATIVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDADMINISTRATIVO.Click
        My.Forms.ADMINISTRATIVO.MdiParent = PADRE
        My.Forms.ADMINISTRATIVO.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCOBROS.Click
        BANDERACOBRO = 2
        BANDERARECFOLFAC = 2
        My.Forms.SELECCIONDEALUMNO.MdiParent = PADRE
        My.Forms.SELECCIONDEALUMNO.Show()
        Me.Close()
    End Sub

    Private Sub PRINCIPAL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Intro.IdRangoLabel1.Text = 5 Then
            CMDESCOLARES.Visible = False
            CMDCOBROS.Visible = False
        End If
    End Sub
End Class