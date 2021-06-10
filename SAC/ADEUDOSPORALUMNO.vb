Public Class ADEUDOSPORALUMNO

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

    End Sub

    Private Sub ADEUDOSPORALUMNO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.ADEUDOSPORALUMNOTableAdapter.Fill(Me.SACDataSet.ADEUDOSPORALUMNO, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.CBOALUMNO.SelectedValue, Integer)))
        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        My.Forms.SELECCIONDEALUMNO.Close()
        Me.Close()
    End Sub
End Class