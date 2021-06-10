Public Class ACTIVIDADUSUARIOSPORFECHA

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      

    End Sub

    Private Sub ACTIVIDADUSUARIOSPORFECHA_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Forms.ACTIVIDADUSUARIOS.MdiParent = PADRE
        My.Forms.ACTIVIDADUSUARIOS.Show()

    End Sub

    Private Sub ACTIVIDADUSUARIOSPORFECHA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.ACTIVIDADUSUARIOSPORFECHATableAdapter.Fill(Me.SACDataSet.ACTIVIDADUSUARIOSPORFECHA, New System.Nullable(Of Date)(CType(RANGOFECHAS.DTDESDE.Value, Date)), New System.Nullable(Of Date)(CType(RANGOFECHAS.DTHASTA.Value, Date)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Dim rpt As New ACTIVIDADUSUARIOSPORFECHAA
        rpt.SetDataSource(SACDataSet)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class