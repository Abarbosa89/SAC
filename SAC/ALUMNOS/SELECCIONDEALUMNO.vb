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
        LBLGRADO.Hide()
        LBLSEXO.Hide()
        LBLIDGRADO.Hide()
        LBLMATRI.Hide()
        LBLIDNIVEL.Hide()
        LBLPORCBECA.Hide()
        CBBECA.Hide()
        CBBECASEP.Hide()
        CBBECAINSC.Hide()
        LBLPORCENINSC.Hide()
        ' LBLPORCBECASEP.Hide()
        ' CBREQFACTURA.Hide()

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

                My.Forms.MSGBOXX.MdiParent = PADRE
                My.Forms.MSGBOXX.Show()
                Me.Hide()
            ElseIf BANDERACOBRO = 2 Then
                My.Forms.COBROSPRODUCTOS.MdiParent = PADRE
                My.Forms.COBROSPRODUCTOS.Show()
                Me.Hide()
            ElseIf BANDERACOBRO = 3 Then
                Me.SELECCIONARTUTORESTableAdapter.Fill(Me.SACDataSet.SELECCIONARTUTORES, New System.Nullable(Of Integer)(CType(CBOALUMNO.SelectedValue, Integer)))
                If SELECCIONARTUTORESBindingSource.Count = 0 Then
                    If MsgBox("ESTE ALUMNO NO TIENE TUTORES ASIGANDOS, ¿DESEA AGREGAR TUTORES?", MsgBoxStyle.YesNo, "AVISO") = MsgBoxResult.Yes Then
                        BANDTUTOR = 1
                        My.Forms.NUEVOTUTOR.MdiParent = PADRE
                        My.Forms.NUEVOTUTOR.Show()
                        Me.Hide()
                    Else
                        Me.Close()
                    End If
                Else
                    My.Forms.MODIFICARTUTORES.MdiParent = PADRE
                    My.Forms.MODIFICARTUTORES.Show()
                    Me.Hide()
                End If

            ElseIf BANDERACOBRO = 4 Then
                My.Forms.ADEUDOSPRODUCTOS.MdiParent = PADRE
                My.Forms.ADEUDOSPRODUCTOS.Show()
                Me.Hide()
            ElseIf BANDERACOBRO = 5 Then
                My.Forms.PAGOSREALZADOSALUMNO.MdiParent = PADRE
                My.Forms.PAGOSREALZADOSALUMNO.Show()
                Me.Hide()
            ElseIf BANDERACOBRO = 6 Then
                My.Forms.ADEUDOSPORALUMNO.MdiParent = PADRE
                My.Forms.ADEUDOSPORALUMNO.Show()
                Me.Hide()
            ElseIf BANDERACOBRO = 7 Then
                My.Forms.PAGOCOLEGIATURA.MdiParent = PADRE
                My.Forms.PAGOCOLEGIATURA.Show()
                Me.Hide()
            ElseIf BANDERACOBRO = 8 Then
                My.Forms.PAGODEINSCRIPCION.MdiParent = PADRE
                My.Forms.PAGODEINSCRIPCION.Show()
                Me.Hide()
            ElseIf BANDERACOBRO = 9 Then
                My.Forms.PAGARADEUDOS.MdiParent = PADRE
                My.Forms.PAGARADEUDOS.Show()
                Me.Hide()
            ElseIf BANDERACOBRO = 10 Then
                My.Forms.RANGOFECHASPARAFACTURACION.MdiParent = PADRE
                My.Forms.RANGOFECHASPARAFACTURACION.Show()
                Me.Hide()
            End If


        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

    End Sub
End Class