Public Class DETALLESTUTORES

 

    Private Sub CMDOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDOK.Click
        Try
            Me.SELECCIONARTUTORESALUMNOTableAdapter.Fill(Me.SACDataSet.SELECCIONARTUTORESALUMNO, New System.Nullable(Of Integer)(CType(TXTMATRICULA.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub FillToolStripButton_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.SELECCIONARALUMNOSATIVOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARALUMNOSATIVOS, CBOESCOLARIDAD.Text, New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DETALLESTUTORES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARESCOLARIDAD' table. You can move, or remove it, as needed.
        Me.SELECCIONARESCOLARIDADTableAdapter.Fill(Me.SACDataSet.SELECCIONARESCOLARIDAD)

    End Sub

    Private Sub RBMATRICULA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBMATRICULA.CheckedChanged
        TXTMATRICULA.Visible = True
        CMDOK.Visible = True
        LBLMATRI.Visible = True
        CBOESCOLARIDAD.Visible = False
        CBOALUMNO.Visible = False
        Button1.Visible = False
    End Sub

    Private Sub RBNOMBRE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBNOMBRE.CheckedChanged
        TXTMATRICULA.Text = Visible = False
        CMDOK.Visible = False
        LBLMATRI.Visible = False
        CBOESCOLARIDAD.Visible = True
        CBOALUMNO.Visible = True
        Button1.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.SELECCIONARTUTORESALUMNOTableAdapter.Fill(Me.SACDataSet.SELECCIONARTUTORESALUMNO, New System.Nullable(Of Integer)(CType(CBOALUMNO.SelectedValue, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CBOESCOLARIDAD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOESCOLARIDAD.SelectedIndexChanged
        Try
            Me.SELECCIONARALUMNOSATIVOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARALUMNOSATIVOS, CBOESCOLARIDAD.Text, New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class