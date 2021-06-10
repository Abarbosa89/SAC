Public Class CORTEDIARIOO

    Private Sub CORTEDIARIOO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.CORTEDIARIOTableAdapter.Fill(Me.SACDataSet.CORTEDIARIO, New System.Nullable(Of Date)(CType(PADRE.TSFECHA.Text, Date)))
        Catch ex As System.Exception

        End Try

        Dim rpt As New CORTEDIARIO
        rpt.SetDataSource(SACDataSet)
        CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub CORTEDIARIOO_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
    
    End Sub
End Class