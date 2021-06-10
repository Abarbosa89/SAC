Public Class SELECCIONARESCOLARIDAD

    Private Sub SELECCIONARESCOLARIDAD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARESCOLARIDAD' table. You can move, or remove it, as needed.
        Me.SELECCIONARESCOLARIDADTableAdapter.Fill(Me.SACDataSet.SELECCIONARESCOLARIDAD)

    End Sub

    Private Sub CMDSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSALIR.Click
        Me.Close()
    End Sub

    Private Sub CDMREPORTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CDMREPORTE.Click

        If BANDERAREPORTE = 1 Then
            My.Forms.LISTAALUMNOPORGRUPOO.MdiParent = PADRE
            My.Forms.LISTAALUMNOPORGRUPOO.Show()
        ElseIf BANDERAREPORTE = 2 Then
            My.Forms.LISTAASISTENCIAA.MdiParent = PADRE
            My.Forms.LISTAASISTENCIAA.Show()
        ElseIf BANDERAREPORTE = 3 Then
            My.Forms.LISTADECORREOSS.MdiParent = PADRE
            My.Forms.LISTADECORREOSS.Show()
        ElseIf BANDERAREPORTE = 4 Then
            My.Forms.LISTACUMPLEAÑOSS.MdiParent = PADRE
            My.Forms.LISTACUMPLEAÑOSS.Show()
        End If

    End Sub
End Class