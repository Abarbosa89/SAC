Public Class PEDIDOSUNIFORMESPORFECHASS


    Private Sub PEDIDOSUNIFORMESPORFECHASS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.PEDIDOSUNIFORMESPORFECHATableAdapter.Fill(Me.SACDataSet.PEDIDOSUNIFORMESPORFECHA, New System.Nullable(Of Date)(CType(RANGOFECHASPEDIDOUNIFORMES.DTDESDE.Value, Date)), New System.Nullable(Of Date)(CType(RANGOFECHASPEDIDOUNIFORMES.DTHASTA.Value, Date)))
        Catch ex As System.Exception

        End Try

        Dim rpt As New PEDIDOSUNIFORMESPORFECHAS
        rpt.SetDataSource(SACDataSet)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class