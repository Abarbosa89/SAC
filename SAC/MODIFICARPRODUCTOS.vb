Public Class MODIFICARPRODUCTOS

    Private Sub CMDPRODUCTOSCOLE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDPRODUCTOSCOLE.Click
        My.Forms.PRODUCTOSCOLEGIATURAS.MdiParent = PADRE
        My.Forms.PRODUCTOSCOLEGIATURAS.Show()
        Me.Close()
    End Sub

    Private Sub CMDPRODUCTOSINSC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDPRODUCTOSINSC.Click
        My.Forms.PRODUCTOSINSCRIPCION.MdiParent = PADRE
        My.Forms.PRODUCTOSINSCRIPCION.Show()
        Me.Close()
    End Sub

    Private Sub CMDPRODUCTOSVARIOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDPRODUCTOSVARIOS.Click
        My.Forms.PRODUCTOSVARIOS.MdiParent = PADRE
        My.Forms.PRODUCTOSVARIOS.Show()
        Me.Close()
    End Sub

    Private Sub CMDPRODUCUNIFORM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDPRODUCUNIFORM.Click
        My.Forms.PRODUCTOSUNIFORMES.MdiParent = PADRE
        My.Forms.PRODUCTOSUNIFORMES.Show()
        Me.Close()
    End Sub
End Class