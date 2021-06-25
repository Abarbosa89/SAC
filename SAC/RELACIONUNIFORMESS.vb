Public Class RELACIONUNIFORMESS
    Public ID As Integer
  

    Private Sub RELACIONUNIFORMESS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SELECCIONARUNIFORMESINSTANTETableAdapter.Fill(Me.SACDataSet.SELECCIONARUNIFORMESINSTANTE, New System.Nullable(Of Integer)(CType(ID, Integer)))
        Catch ex As System.Exception

        End Try

        Dim rpt As New RELACIONUNIFORMES
        rpt.SetDataSource(SACDataSet)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class