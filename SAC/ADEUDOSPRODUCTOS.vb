Imports System.Data.SqlClient
Imports System.Data
Public Class ADEUDOSPRODUCTOS
    Dim ABONO As Decimal
    Dim TOTAL As Decimal
    Dim dtPaso As New DataTable
    Dim sSQL As String = ""


    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub ADEUDOSPRODUCTOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Me.SELECCIONARADEUDOSARTICULOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARADEUDOSARTICULOS, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.CBOALUMNO.SelectedValue, Integer)))


            Dim drPaso As DataRow
            sSQL = "EXEC dbo.NUEVORECIBOFOLIOFACTURA 2"
            dtPaso = sqlServer.ExecSQLReturnDT(sSQL)
            drPaso = dtPaso.Rows(0)
            LBLNVORECIBO.Text = CInt(drPaso("NOFOLIO").ToString) + 1

            'Me.NUEVORECIBOFOLIOFACTURATableAdapter.Fill(Me.SACDataSet.NUEVORECIBOFOLIOFACTURA, New System.Nullable(Of Integer)(CType(2, Integer)))
            'LBLNVORECIBO.Text = CInt(LBLRECIBOMAX.Text) + 1

            Me.SELECCIONARADEUDOSARTICULOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARADEUDOSARTICULOS, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.CBOALUMNO.SelectedValue, Integer)))


        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CMDABONO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDABONO.Click
        Try

            BAND = 1
            ABONO = InputBox("Cuanto desea abonar?", "ABONO", 0)
            LBLNVOABONO.Text = ABONO
            LBLNVARESTA.Text = CDec(LBLRESTAANT.Text) - ABONO
            LBLNVOABONO.Text = FormatCurrency(LBLNVOABONO.Text)
            LBLNVARESTA.Text = FormatCurrency(LBLNVARESTA.Text)


        Catch

        End Try
    End Sub

    Private Sub CMDLIQUIDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDLIQUIDAR.Click
        Try

            BAND = 2
            LBLNVOABONO.Text = 0
            LBLNVARESTA.Text = 0
            LBLNVOABONO.Text = FormatCurrency(LBLNVOABONO.Text)
            LBLNVARESTA.Text = FormatCurrency(LBLNVARESTA.Text)


        Catch

        End Try
    End Sub

    Private Sub CMDIMPRIMIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDIMPRIMIR.Click
        Try
            BANDERAREPORTE2 = 2
            Dim com As SqlCommand = con.CreateCommand()
            If BAND = 1 Then
                con.Open()
                com = New SqlCommand("MODIFICARMOVIMIENTODEABONOS", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@IDMOV", SqlDbType.Int).Value = CBOPRODUCTOS.SelectedValue
                com.ExecuteNonQuery()
                con.Close()

                con.Open()
                com = New SqlCommand("MOVIMIENTOCOLEGIATURA", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@NOMOV", SqlDbType.Int).Value = 1
                com.Parameters.Add("@RESTA", SqlDbType.Money).Value = LBLNVARESTA.Text
                com.Parameters.Add("@TOTAL", SqlDbType.Money).Value = LBLNVOABONO.Text
                com.Parameters.Add("@ABONO", SqlDbType.Money).Value = LBLNVOABONO.Text
                com.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = "ABONO AL ADEUDO DE " & CBOPRODUCTOS.Text
                com.Parameters.Add("@NOFACTURA", SqlDbType.Int).Value = 0
                com.Parameters.Add("@NORECIBO", SqlDbType.Int).Value = LBLNVORECIBO.Text
                com.Parameters.Add("@NOFOLIO", SqlDbType.Int).Value = 0
                com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
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
                com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "ABONO AL ADEUDO CON RECIBO " & LBLNVORECIBO.Text
                com.ExecuteNonQuery()
                con.Close()


                My.Forms.RECIBOPRODUCTOSS.ShowDialog()
            ElseIf BAND = 2 Then

                con.Open()
                com = New SqlCommand("MODIFICARMOVIMIENTODEABONOS", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@IDMOV", SqlDbType.Int).Value = CBOPRODUCTOS.SelectedValue
                com.ExecuteNonQuery()
                con.Close()

                con.Open()
                com = New SqlCommand("MOVIMIENTOCOLEGIATURA", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@NOMOV", SqlDbType.Int).Value = 2
                com.Parameters.Add("@RESTA", SqlDbType.Money).Value = 0
                com.Parameters.Add("@TOTAL", SqlDbType.Money).Value = LBLRESTAANT.Text
                com.Parameters.Add("@ABONO", SqlDbType.Money).Value = 0
                com.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = "LIQUIDACION AL ADEUDO DE " & CBOPRODUCTOS.Text
                com.Parameters.Add("@NOFACTURA", SqlDbType.Int).Value = 0
                com.Parameters.Add("@NORECIBO", SqlDbType.Int).Value = LBLNVORECIBO.Text
                com.Parameters.Add("@NOFOLIO", SqlDbType.Int).Value = 0
                com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
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
                com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "LIQUIDACION AL ADEUDO CON RECIBO " & LBLNVORECIBO.Text
                com.ExecuteNonQuery()
                con.Close()

                My.Forms.RECIBOPRODUCTOSS.ShowDialog()

            End If

        Catch ex As System.Exception
            con.Close()
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        My.Forms.SELECCIONDEALUMNO.Close()
        Me.Close()

    End Sub
End Class

