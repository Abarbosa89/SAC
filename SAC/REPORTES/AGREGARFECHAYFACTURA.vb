Public Class AGREGARFECHAYFACTURA

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub AGREGARFECHAYFACTURA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SELECCIONARMOVPARFACTURAPORALUMNOTableAdapter.Fill(Me.SACDataSet.SELECCIONARMOVPARFACTURAPORALUMNO, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.CBOALUMNO.SelectedValue, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class