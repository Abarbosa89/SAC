Public Class RANGOFECHASPARAFACTURACION

    Private Sub CDMREPORTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CDMREPORTE.Click
        My.Forms.PAGOSALUMNOPARAFACTURAA.MdiParent = PADRE
        My.Forms.PAGOSALUMNOPARAFACTURAA.Show()
        Me.Hide()
    End Sub
End Class