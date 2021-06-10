Public Class DETALLESALUMNOS
    Dim banderita As Integer = 0

    Private Sub DETALLESALUMNOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTAPPAT.TextChanged
        SELECCIONARALUMNOSINSCRITOSNOINSCRITOSBindingSource.Filter = String.Format("appat LIKE '%" & TXTAPPAT.Text & "%'")
    End Sub

    Private Sub TXTAPMAT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTAPMAT.TextChanged
        SELECCIONARALUMNOSINSCRITOSNOINSCRITOSBindingSource.Filter = String.Format("apmat LIKE '%" & TXTAPMAT.Text & "%'")
    End Sub

    Private Sub TXTNOMBRE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTNOMBRE.TextChanged
        SELECCIONARALUMNOSINSCRITOSNOINSCRITOSBindingSource.Filter = String.Format("nombre LIKE '%" & TXTNOMBRE.Text & "%'")
    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        My.Forms.SELECCIONDEALUMNO.Close()
        Me.Close()
    End Sub

    Private Sub TXTMATRICULA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTMATRICULA.TextChanged

    End Sub


    Private Sub RBMATRICULA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBMATRICULA.CheckedChanged
        banderita = 2
        TXTMATRICULA.Visible = True
        LBLMATRI.Visible = True
        CMDOK.Visible = True
        LBLNOMBRE.Visible = False
        TXTNOMBRE.Visible = False
        LBLAPPATERNO.Visible = False
        TXTAPPAT.Visible = False
        LBLAPMAT.Visible = False
        TXTAPMAT.Visible = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBNOMBRE.CheckedChanged
        banderita = 1
        TXTMATRICULA.Visible = False
        LBLMATRI.Visible = False
        CMDOK.Visible = False
        LBLNOMBRE.Visible = True
        TXTNOMBRE.Visible = True
        LBLAPPATERNO.Visible = True
        TXTAPPAT.Visible = True
        LBLAPMAT.Visible = True
        TXTAPMAT.Visible = True

        Try
            Me.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARALUMNOSINSCRITOSNOINSCRITOS, New System.Nullable(Of Integer)(CType(banderita, Integer)), New System.Nullable(Of Integer)(CType(0, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CMDOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDOK.Click
        Try
            Me.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARALUMNOSINSCRITOSNOINSCRITOS, New System.Nullable(Of Integer)(CType(banderita, Integer)), New System.Nullable(Of Integer)(CType(TXTMATRICULA.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class