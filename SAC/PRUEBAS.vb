Public Class PRUEBAS

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
     
    End Sub

    Private Sub PRUEBAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SACDataSet.REPORTEDEPAGOS' table. You can move, or remove it, as needed.
        Me.REPORTEDEPAGOSTableAdapter.Fill(Me.SACDataSet.REPORTEDEPAGOS)

        Dim RPT As New REPORTEPRUEBAS
        RPT.SetDataSource(SACDataSet)
        CrystalReportViewer1.ReportSource = RPT

    End Sub
End Class