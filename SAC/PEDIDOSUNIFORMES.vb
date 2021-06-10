Public Class PEDIDOSUNIFORMES

  

    Private Sub DTDESDE_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTDESDE.ValueChanged
        Try
            Me.PEDIDOSUNIFORMESPORFECHATableAdapter.Fill(Me.SACDataSet.PEDIDOSUNIFORMESPORFECHA, New System.Nullable(Of Date)(CType(DTDESDE.Value, Date)), New System.Nullable(Of Date)(CType(DTHASTA.Value, Date)))
        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub DTHASTA_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTHASTA.ValueChanged
        Try
            Me.PEDIDOSUNIFORMESPORFECHATableAdapter.Fill(Me.SACDataSet.PEDIDOSUNIFORMESPORFECHA, New System.Nullable(Of Date)(CType(DTDESDE.Value, Date)), New System.Nullable(Of Date)(CType(DTHASTA.Value, Date)))
        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        PEDIDOSUNIFORMESPORFECHABindingSource.Filter = String.Format("ALUMNO LIKE '%" & TextBox1.Text & "%'")
    End Sub
End Class