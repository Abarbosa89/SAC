Public Class LISTACUMPLEAÑOSS

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    

    End Sub

    Private Sub LISTACUMPLEAÑOSS_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Forms.SELECCIONARMES.Close()
    End Sub

    Private Sub LISTACUMPLEAÑOSS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SELECCIONARLISTAPORGRUPOTableAdapter.Fill(Me.SACDataSet.SELECCIONARLISTAPORGRUPO, New System.Nullable(Of Integer)(CType(SELECCIONARESCOLARIDAD.CBOESCOLARIDAD.SelectedValue, Integer)), New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))


            Dim rpt As New LISTACUMPLEAÑOS
            rpt.SetDataSource(SACDataSet)
            CrystalReportViewer1.ReportSource = rpt


        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

   
End Class