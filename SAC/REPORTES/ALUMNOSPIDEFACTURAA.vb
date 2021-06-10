Public Class ALUMNOSPIDEFACTURAA

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

    End Sub

    Private Sub ALUMNOSPIDEFACTURAA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SELECCIONARALUMNOSPIDENFACTURATableAdapter.Fill(Me.SACDataSet.SELECCIONARALUMNOSPIDENFACTURA, New System.Nullable(Of Date)(CType(FECHASPIDENFACTURA.DTDESDE.Value, Date)), New System.Nullable(Of Date)(CType(FECHASPIDENFACTURA.DTHASTA.Value, Date)))
        Catch ex As System.Exception

        End Try

        Dim rpt As New ALUMNOSPIDEFACTURA
        rpt.SetDataSource(SACDataSet)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class