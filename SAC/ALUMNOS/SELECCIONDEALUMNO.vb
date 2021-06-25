Public Class SELECCIONDEALUMNO

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        PADRE.TINABILITAR2.Enabled = False
        PADRE.TINABILITAR.Enabled = True
        Me.Close()
    End Sub

    Private Sub SELECCIONDEALUMNO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARESCOLARIDAD' table. You can move, or remove it, as needed.
        Me.SELECCIONARESCOLARIDADTableAdapter.Fill(Me.SACDataSet.SELECCIONARESCOLARIDAD)
        BANDTUTOR = 0

    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOESCOLARIDAD.SelectedIndexChanged
        Try
            Me.SELECCIONARALUMNOSATIVOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARALUMNOSATIVOS, CBOESCOLARIDAD.SelectedValue, New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CMDSELECCIONAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSELECCIONAR.Click
        Try
            PADRE.TINABILITAR2.Enabled = False
            If BANDERACOBRO = 1 Then

                My.Forms.MSGBOXX.ShowDialog()
            ElseIf BANDERACOBRO = 2 Then

                My.Forms.COBROSPRODUCTOS.ShowDialog()
            ElseIf BANDERACOBRO = 3 Then
                Me.SELECCIONARTUTORESTableAdapter.Fill(Me.SACDataSet.SELECCIONARTUTORES, New System.Nullable(Of Integer)(CType(CBOALUMNO.SelectedValue, Integer)))
                If SELECCIONARTUTORESBindingSource.Count = 0 Then
                    If MsgBox("ESTE ALUMNO NO TIENE TUTORES ASIGANDOS, ¿DESEA AGREGAR TUTORES?", MsgBoxStyle.YesNo, "AVISO") = MsgBoxResult.Yes Then
                        BANDTUTOR = 1

                        My.Forms.NUEVOTUTOR.ShowDialog()
                    Else
                        Me.Close()
                    End If
                Else

                    My.Forms.MODIFICARTUTORES.ShowDialog()
                End If

            ElseIf BANDERACOBRO = 4 Then
                My.Forms.ADEUDOSPRODUCTOS.ShowDialog()
            ElseIf BANDERACOBRO = 5 Then

                My.Forms.PAGOSREALZADOSALUMNO.ShowDialog()
            ElseIf BANDERACOBRO = 6 Then
                My.Forms.ADEUDOSPORALUMNO.ShowDialog()
            ElseIf BANDERACOBRO = 7 Then
                My.Forms.PAGOCOLEGIATURA.ShowDialog()
            ElseIf BANDERACOBRO = 8 Then
                My.Forms.PAGODEINSCRIPCION.ShowDialog()
            ElseIf BANDERACOBRO = 9 Then
                My.Forms.PAGARADEUDOS.ShowDialog()
            ElseIf BANDERACOBRO = 10 Then

                My.Forms.RANGOFECHASPARAFACTURACION.ShowDialog()
            End If


        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

    End Sub
End Class