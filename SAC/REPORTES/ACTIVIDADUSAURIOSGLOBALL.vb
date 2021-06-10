Public Class ACTIVIDADUSAURIOSGLOBALL

    Private Sub ACTIVIDADUSAURIOSGLOBALL_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Forms.ACTIVIDADUSUARIOS.MdiParent = PADRE
        My.Forms.ACTIVIDADUSUARIOS.Show()

    End Sub

    Private Sub ACTIVIDADUSAURIOSGLOBALL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SACDataSet.ACTIVIDADUSUARIOSGLOBAL' table. You can move, or remove it, as needed.
        Me.ACTIVIDADUSUARIOSGLOBALTableAdapter.Fill(Me.SACDataSet.ACTIVIDADUSUARIOSGLOBAL)
        Dim rpt As New ACTIVIDADUSUARIOSGLOBAL
        rpt.SetDataSource(SACDataSet)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class