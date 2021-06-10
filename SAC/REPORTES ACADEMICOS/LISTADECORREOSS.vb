Public Class LISTADECORREOSS

  

    Private Sub LISTADECORREOSS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SELECCIONARLISTAPORGRUPOTableAdapter.Fill(Me.SACDataSet.SELECCIONARLISTAPORGRUPO, New System.Nullable(Of Integer)(CType(SELECCIONARESCOLARIDAD.CBOESCOLARIDAD.SelectedValue, Integer)), New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))


            Dim rpt As New LISTADECORREOS
            rpt.SetDataSource(SACDataSet)
            CrystalReportViewer1.ReportSource = rpt

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    
End Class