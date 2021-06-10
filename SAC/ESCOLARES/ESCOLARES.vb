Public Class ESCOLARES

    Private Sub CMDSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSALIR.Click
        PADRE.TINABILITAR.Enabled = True
        PADRE.TINABILITAR2.Enabled = False
        Me.Close()
    End Sub

    Private Sub CMDUSUARIOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Forms.ADMINISTRATIVO.MdiParent = PADRE
        My.Forms.ADMINISTRATIVO.Show()
        Me.Close()
    End Sub

    Private Sub CMDINSCRIPCION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDINSCRIPCION.Click
        PADRE.TINABILITAR2.Enabled = False
        My.Forms.PREGUNTA.MdiParent = PADRE
        My.Forms.PREGUNTA.Show()

    End Sub

    Private Sub CMDCUOTASYPAGOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCUOTASYPAGOS.Click
        PADRE.TINABILITAR2.Enabled = False
        BANDERACOBRO = 1
        My.Forms.SELECCIONDEALUMNO.MdiParent = PADRE
        My.Forms.SELECCIONDEALUMNO.Show()
        Me.Close()
    End Sub

    Private Sub CMDPRODUCTOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BANDERACOBRO = 2
        My.Forms.SELECCIONDEALUMNO.MdiParent = PADRE
        My.Forms.SELECCIONDEALUMNO.Show()
        Me.Close()
    End Sub

    Private Sub ESCOLARES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       If Intro.IdRangoLabel1.Text = 5 Then
            CMDCUOTASYPAGOS.Visible = False
 
        End If
    End Sub
End Class