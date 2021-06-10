Public Class CAMBIARCICLO

    Private Sub CAMBIARCICLO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARCICLOS' table. You can move, or remove it, as needed.
        Me.SELECCIONARCICLOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARCICLOS)

    End Sub

    Private Sub CMDGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR.Click
        PADRE.LBLIDCICLO.Text = CBOCICLO.SelectedValue
        PADRE.TSCICLOESCOLAR.Text = CBOCICLO.Text
        PADRE.LBLCICLO.Text = CBOCICLO.Text
        MsgBox("AHORA ESTA EN EL CICLO " & CBOCICLO.Text, MsgBoxStyle.Information, "CAMBIO")
        Me.Close()
    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        Me.Close()
    End Sub
End Class