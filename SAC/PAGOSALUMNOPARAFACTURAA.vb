Public Class PAGOSALUMNOPARAFACTURAA

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
     

    End Sub

    Private Sub PAGOSALUMNOPARAFACTURAA_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        RANGOFECHASPARAFACTURACION.Close()
        SELECCIONDEALUMNO.Close()
    End Sub

    Private Sub PAGOSALUMNOPARAFACTURAA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SELECCIONARPAGOSDEALUMNOPARAFACTURATableAdapter.Fill(Me.SACDataSet.SELECCIONARPAGOSDEALUMNOPARAFACTURA, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.CBOALUMNO.SelectedValue, Integer)), New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)), New System.Nullable(Of Date)(CType(RANGOFECHASPARAFACTURACION.DTDESDE.Value, Date)), New System.Nullable(Of Date)(CType(RANGOFECHASPARAFACTURACION.DTHASTA.Value, Date)))
        Catch ex As System.Exception

        End Try

        Dim rpt As New PAGOSALUMNOPARAFACTURA
        rpt.SetDataSource(SACDataSet)
        CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class