Imports System.Data.SqlClient
Imports System.Data
Public Class INSCRIPCIONCNPROMOCION
    Dim BANDERA As Integer = 0
    Private Sub INSCRIPCIONCNPROMOCION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LBLMONTOCOLE.Hide()
        LBLNVOFOLIO.Hide()
        LBLNOFOLIO.Hide()
        LBLPORCENTAJE.Hide()
        LBLDESCRIPCION.Hide()
        LBLIDPRODUC.Hide()
        LBLFECHAFIN.Hide()
        LBLFECHAINI.Hide()
        LBLIDCOLEG.Hide()
        LBLMONTOCOLEG.Hide()
        LBLCONCEPTO.Hide()
        'TODO: This line of code loads data into the 'SACDataSet.PROMOCIONINSCRIPCION' table. You can move, or remove it, as needed.
        Me.PROMOCIONINSCRIPCIONTableAdapter.Fill(Me.SACDataSet.PROMOCIONINSCRIPCION)
        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARTODOSALUMNOS' table. You can move, or remove it, as needed.
        Me.SELECCIONARTODOSALUMNOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARTODOSALUMNOS)
        CBOALUMNOS.Enabled = False
        Button13.Enabled = False
    End Sub


    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click

        Try
            BANDERAPAGO = 4
            Me.NUEVORECIBOFOLIOFACTURATableAdapter.Fill(Me.SACDataSet.NUEVORECIBOFOLIOFACTURA, New System.Nullable(Of Integer)(CType(BANDERARECFOLFAC, Integer)))
            LBLNVOFOLIO.Text = CInt(LBLNOFOLIO.Text) + 1

            If LBLCONCEPTO.Text = "INSCRIPCION" Then
                Me.SELECCIONARMONTOCOLEGPORNIVELTableAdapter.Fill(Me.SACDataSet.SELECCIONARMONTOCOLEGPORNIVEL, EscolaridadLabel1.Text)
                LBLMONTO.Text = CDec(LBLMONTOCOLE.Text) - (CDec(LBLMONTOCOLE.Text) * CDec(LBLPORCENTAJE.Text))
                LBLMONTO.Text = FormatCurrency(LBLMONTO.Text)
            End If

            If LBLCONCEPTO.Text = "COLEGIATURA" Then
                Me.SELECCIONARMONTOCOLEGIATURAPORNIVELTableAdapter.Fill(Me.SACDataSet.SELECCIONARMONTOCOLEGIATURAPORNIVEL, EscolaridadLabel1.Text)
                LBLMONTO.Text = CDec(LBLMONTOCOLEG.Text) - (CDec(LBLMONTOCOLEG.Text) * CDec(LBLPORCENTAJE.Text))
                LBLMONTO.Text = FormatCurrency(LBLMONTO.Text)
            End If

            CMDIMPRIMIR.Visible = True

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CMDIMPRIMIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDIMPRIMIR.Click
        Try
            If BANDERA = 1 Then
                Dim com As SqlCommand = con.CreateCommand()
                con.Open()
                com = New SqlCommand("MOVIMIENTOCOLEGIATURA", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@NOMOV", SqlDbType.Int).Value = 2
                com.Parameters.Add("@RESTA", SqlDbType.Money).Value = 0
                com.Parameters.Add("@TOTAL", SqlDbType.Money).Value = LBLMONTO.Text
                com.Parameters.Add("@ABONO", SqlDbType.Money).Value = LBLMONTO.Text
                com.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = "LIQUIDACION DE " & LBLDESCRIPCION.Text
                com.Parameters.Add("@NOFACTURA", SqlDbType.Int).Value = 0
                com.Parameters.Add("@NORECIBO", SqlDbType.Int).Value = 0
                com.Parameters.Add("@NOFOLIO", SqlDbType.Int).Value = LBLNVOFOLIO.Text
                com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                com.Parameters.Add("@MATRI", SqlDbType.Int).Value = CBOALUMNOS.SelectedValue
                com.Parameters.Add("@IDPRODUC", SqlDbType.Int).Value = LBLIDPRODUC.Text
                com.Parameters.Add("@IDTIPOPAGO", SqlDbType.Int).Value = 1
                com.Parameters.Add("@FACTURA", SqlDbType.Bit).Value = 0
                com.Parameters.Add("@DIGITOSCUENTA", SqlDbType.NVarChar).Value = 0
                com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                com.ExecuteNonQuery()
                con.Close()

                con.Open()
                com = New SqlCommand("REGISTRODEACTIVIDAD", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "ABONO DE COLEGIATURA CON RECARGO CON FOLIO " & LBLNVOFOLIO.Text
                com.ExecuteNonQuery()
                con.Close()
            End If

            If BANDERA = 2 Then
                Dim com As SqlCommand = con.CreateCommand()
                con.Open()
                com = New SqlCommand("MOVIMIENTOCOLEGIATURA", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@NOMOV", SqlDbType.Int).Value = 2
                com.Parameters.Add("@RESTA", SqlDbType.Money).Value = 0
                com.Parameters.Add("@TOTAL", SqlDbType.Money).Value = LBLMONTO.Text
                com.Parameters.Add("@ABONO", SqlDbType.Money).Value = LBLMONTO.Text
                com.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = "LIQUIDACION DE " & LBLDESCRIPCION.Text
                com.Parameters.Add("@NOFACTURA", SqlDbType.Int).Value = 0
                com.Parameters.Add("@NORECIBO", SqlDbType.Int).Value = 0
                com.Parameters.Add("@NOFOLIO", SqlDbType.Int).Value = LBLNVOFOLIO.Text
                com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                com.Parameters.Add("@MATRI", SqlDbType.Int).Value = CBOALUMNOS.SelectedValue
                com.Parameters.Add("@IDPRODUC", SqlDbType.Int).Value = LBLIDCOLEG.Text
                com.Parameters.Add("@IDTIPOPAGO", SqlDbType.Int).Value = 1
                com.Parameters.Add("@FACTURA", SqlDbType.Bit).Value = 0
                com.Parameters.Add("@DIGITOSCUENTA", SqlDbType.NVarChar).Value = 0
                com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                com.ExecuteNonQuery()
                con.Close()

                con.Open()
                com = New SqlCommand("REGISTRODEACTIVIDAD", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "ABONO DE COLEGIATURA CON RECARGO CON FOLIO " & LBLNVOFOLIO.Text
                com.ExecuteNonQuery()
                con.Close()

            End If

            My.Forms.RECIBOCOLEGIATURAA.MdiParent = PADRE
            My.Forms.RECIBOCOLEGIATURAA.Show()
            Me.Enabled = False

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CBOALUMNOS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOALUMNOS.SelectedIndexChanged
        CMDIMPRIMIR.Visible = False
    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        Me.Close()
    End Sub


    Private Sub CBOPROMOCION_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBOPROMOCION.Validated
      


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CDate(PADRE.TSFECHA.Text) > CDate(LBLFECHAFIN.Text) Then
            MsgBox("PROMOCION VENCIDA", MsgBoxStyle.Information, "PROMOCIONES")
            CBOALUMNOS.Enabled = False
            Button13.Enabled = False
            CMDIMPRIMIR.Visible = False
        Else
            CBOALUMNOS.Enabled = True
            Button13.Enabled = True
        End If
    End Sub


    Private Sub LBLCONCEPTO_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LBLCONCEPTO.TextChanged
        If LBLCONCEPTO.Text = "INSCRIPCION" Then
            BANDERA = 1
        ElseIf LBLCONCEPTO.Text = "COLEGIATURA" Then
            BANDERA = 2
        End If
    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class