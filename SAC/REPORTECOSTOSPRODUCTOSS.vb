Public Class REPORTECOSTOSPRODUCTOSS

    Private Sub REPORTECOSTOSPRODUCTOSS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARCOSTOSPRODUCTOS' table. You can move, or remove it, as needed.
        Me.SELECCIONARCOSTOSPRODUCTOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARCOSTOSPRODUCTOS)

        Dim rpt As New REPORTECOSTOSPRODUCTOS
        rpt.SetDataSource(SACDataSet)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class