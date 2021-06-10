Public Class BECASASIGNADASS

    Private Sub BECASASIGNADASS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SACDataSet.BECASASIGNADAS' table. You can move, or remove it, as needed.
        Me.BECASASIGNADASTableAdapter.Fill(Me.SACDataSet.BECASASIGNADAS)
        Dim rpt As New BECASASIGNADAS
        rpt.SetDataSource(SACDataSet)
        CrystalReportViewer1.ReportSource = rpt



    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class