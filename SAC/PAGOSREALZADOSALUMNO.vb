Public Class PAGOSREALZADOSALUMNO


    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        My.Forms.SELECCIONDEALUMNO.Close()
        Me.Close()
    End Sub

    Private Sub PAGOSREALZADOSALUMNO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SELECCIONARPAGOSREALIZADOSPORALUMNOTableAdapter.Fill(Me.SACDataSet.SELECCIONARPAGOSREALIZADOSPORALUMNO, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.CBOALUMNO.SelectedValue, Integer)), New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CMDIMPRIMIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDIMPRIMIR.Click
        My.Forms.REPORTEPAGOSREALIZADOSALUMNOO.MdiParent = PADRE
        My.Forms.REPORTEPAGOSREALIZADOSALUMNOO.Show()
    End Sub

End Class