Public Class CORTEPORFECHASS



    Private Sub CORTEPORFECHASS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.CORTEPORFECHATableAdapter.Fill(Me.SACDataSet.CORTEPORFECHA, New System.Nullable(Of Date)(CType(FECHASCORTEPORFECHAS.DTDESDE.Value, Date)), New System.Nullable(Of Date)(CType(FECHASCORTEPORFECHAS.DTHASTA.Value, Date)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Dim rpt As New CORTEPORFECHAS
        rpt.SetDataSource(SACDataSet)
        CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class