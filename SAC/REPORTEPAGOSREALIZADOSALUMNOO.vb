Public Class REPORTEPAGOSREALIZADOSALUMNOO

    Private Sub REPORTEPAGOSREALIZADOSALUMNOO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SELECCIONARPAGOSREALIZADOSPORALUMNOTableAdapter.Fill(Me.SACDataSet.SELECCIONARPAGOSREALIZADOSPORALUMNO, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.CBOALUMNO.SelectedValue, Integer)), New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Dim rpt As New REPORTEPAGOSREALIZADOSALUMNO
        rpt.SetDataSource(SACDataSet)
        CrystalReportViewer1.ReportSource = rpt
    End Sub

End Class