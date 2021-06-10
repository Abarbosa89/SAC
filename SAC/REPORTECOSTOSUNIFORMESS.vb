Public Class REPORTECOSTOSUNIFORMESS

    Private Sub REPORTECOSTOSUNIFORMESS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARCOSTOSUNIFORMES' table. You can move, or remove it, as needed.
        Me.SELECCIONARCOSTOSUNIFORMESTableAdapter.Fill(Me.SACDataSet.SELECCIONARCOSTOSUNIFORMES)

        Dim rpt As New REPORTECOSTOSUNIFORMES
        rpt.SetDataSource(SACDataSet)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class