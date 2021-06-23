Public Class REIMPRSIONRECIBOCOLEGIATURAA

    Private Sub REIMPRSIONRECIBOCOLEGIATURAA_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub


    Private Sub REIMPRSIONRECIBOCOLEGIATURAA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.REIMPRESIONDEFOLIOTableAdapter.Fill(Me.SACDataSet.REIMPRESIONDEFOLIO, New System.Nullable(Of Integer)(CType(REIMPRESIONRECFOL.LBLNUMFOLIO.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


        Dim rpt As New REIMPRESIONRECIBOCOLEGIATURA
        rpt.SetDataSource(SACDataSet)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class