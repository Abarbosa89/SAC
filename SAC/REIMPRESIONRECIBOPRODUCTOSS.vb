Public Class REIMPRESIONRECIBOPRODUCTOSS


    Private Sub REIMPRESIONRECIBOPRODUCTOSS_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Forms.REIMPRESIONRECFOL.Close()
    End Sub

    Private Sub REIMPRESIONRECIBOPRODUCTOSS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.REIMPRESIONDERECIBOTableAdapter.Fill(Me.SACDataSet.REIMPRESIONDERECIBO, New System.Nullable(Of Integer)(CType(REIMPRESIONRECFOL.LBLNUMRECIBO.Text, Integer)))
        Catch ex As System.Exception

        End Try

        Dim rpt As New REIMPRESIONRECIBODEPRODUCTOS
        rpt.SetDataSource(SACDataSet)
        CrystalReportViewer1.ReportSource = rpt
    End Sub

End Class