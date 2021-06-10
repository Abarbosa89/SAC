Imports System.Data.SqlClient
Imports System.Data
Public Class PAGARADEUDOS
    Dim ABONO As Decimal
    Dim RECARG As Decimal
    Dim TOTAL As Decimal


    Private Sub PAGARADEUDOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SACDataSet.TIPOSDEPAGO' table. You can move, or remove it, as needed.
        Me.TIPOSDEPAGOTableAdapter.Fill(Me.SACDataSet.TIPOSDEPAGO)
        BAND = 0
        LBLNVOABONO.Text = 0
        LBLNVARESTA.Text = 0
        LBLPORCENTAJE.Hide()
        LBLABONORECARG.Hide()
        LBLIDPRODUC.Hide()
        LBLNOFOLIOMAX.Hide()
        LBLNONVOFOLIO.Hide()
        LBLFECHAVENCI.Hide()

        Try
            Me.NUEVORECIBOFOLIOFACTURATableAdapter.Fill(Me.SACDataSet.NUEVORECIBOFOLIOFACTURA, New System.Nullable(Of Integer)(CType(BANDERARECFOLFAC, Integer)))
            LBLNONVOFOLIO.Text = CInt(LBLNOFOLIOMAX.Text) + 1
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Try
            Me.SELECCIONARADEUDOSALUMNOTableAdapter.Fill(Me.SACDataSet.SELECCIONARADEUDOSALUMNO, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.CBOALUMNO.SelectedValue, Integer)))
        Catch ex As System.Exception
            con.Close()
            MsgBox("SE ENCONTRO UN PROBLEMA PONGANSE EN CONTACTO CON SU ADMINISTRADOR", MsgBoxStyle.Information, "AVISO")
        End Try
    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click

        My.Forms.SELECCIONDEALUMNO.Close()
        Me.Close()
    End Sub

    Private Sub CMDLIQUIDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDLIQUIDAR.Click
        Try
            BAND = 2
            ' If CDate(PADRE.TSFECHA.Text) > CDate(LBLFECHAVENCI.Text) Then
            'RECARGO = 1
            ' MsgBox("EL ABONO TENDRA UN RECARGO DEL 10% AVISAR AL TUTOR", MsgBoxStyle.Information, "AVISO")
            ' LBLNVARESTA.Text = 0
            ' LBLNVOABONO.Text = 0
            ' RECARG = CDec(LBLRESTA.Text) * CDec(LBLPORCENTAJE.Text)
            ' TOTAL = CDec(LBLRESTA.Text) + RECARG
            ' LBLABONORECARG.Text = TOTAL
            ' LBLABONORECARG.Text = FormatCurrency(LBLABONORECARG.Text)
            ' Else
            RECARGO = 2
            LBLNVARESTA.Text = 0
            LBLNVOABONO.Text = 0
            LBLRESTA.Text = FormatCurrency(LBLRESTA.Text)
            LBLABONO.Text = FormatCurrency(LBLABONO.Text)
            'End If
            LBL4DIGITOSCUENTA.Visible = True
            TXT4DIGITOSCUENTA.Visible = True
            CBFACTURA.Visible = True
        Catch ex As System.Exception
            con.Close()
            MsgBox("SE ENCONTRO UN PROBLEMA PONGANSE EN CONTACTO CON SU ADMINISTRADOR", MsgBoxStyle.Information, "AVISO")
        End Try
    End Sub


    Private Sub CMDABONO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDABONO.Click
        Try
            BAND = 1
            'If CDate(PADRE.TSFECHA.Text) > CDate(LBLFECHAVENCI.Text) Then
            'RECARGO = 1
            'MsgBox("EL ABONO TENDRA UN RECARGO DEL 10% AVISAR AL TUTOR", MsgBoxStyle.Information, "AVISO")
            ' ABONO = InputBox("CUANTO ES LO QUE DESEA ABONAR?", "ABONO", 0)
            ' If ABONO > CDec(LBLRESTA.Text) Then
            ' MsgBox("EL ABONO ES MAYOR QUE LA DIFERENCIA", MsgBoxStyle.Exclamation, "AVISO")
            ' Else
            ' LBLNVOABONO.Text = ABONO
            ' RECARG = CDec(LBLRESTA.Text) * CDec(LBLPORCENTAJE.Text)
            ' TOTAL = RECARG + LBLRESTA.Text
            'LBLNVARESTA.Text = CDec(TOTAL) - CDec(LBLNVOABONO.Text)
            'LBLABONORECARG.Text = TOTAL
            ' LBLABONORECARG.Text = FormatCurrency(LBLABONORECARG.Text)
            ' LBLNVOABONO.Text = FormatCurrency(LBLNVOABONO.Text)
            ' LBLNVARESTA.Text = FormatCurrency(LBLNVARESTA.Text)
            ' End If
            ' Else
            RECARGO = 2
            ABONO = InputBox("CUANTO ES LO QUE DESEA ABONAR?", "ABONO", 0)
            If ABONO > CDec(LBLRESTA.Text) Then
                MsgBox("EL ABONO ES MAYOR QUE LA DIFERENCIA", MsgBoxStyle.Exclamation, "AVISO")
            Else

                LBLNVOABONO.Text = ABONO
                LBLNVARESTA.Text = CDec(LBLRESTA.Text) - CDec(LBLNVOABONO.Text)
                LBLNVOABONO.Text = FormatCurrency(LBLNVOABONO.Text)
                LBLNVARESTA.Text = FormatCurrency(LBLNVARESTA.Text)
            End If
            ' End If

        Catch ex As System.Exception
            con.Close()

        End Try

    End Sub

    Private Sub CMDIMPRIMIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDIMPRIMIR.Click
        Try
            IMPRESION = 0
            Dim com As SqlCommand = con.CreateCommand()
            If BAND = 1 Then
                If RECARGO = 1 Then
                    con.Open()
                    com = New SqlCommand("MODIFICARMOVIMIENTODEABONOS", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@IDMOV", SqlDbType.Int).Value = CBOADEUDOS.SelectedValue
                    com.ExecuteNonQuery()
                    con.Close()

                    con.Open()
                    com = New SqlCommand("MOVIMIENTOCOLEGIATURA", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@NOMOV", SqlDbType.Int).Value = 1
                    com.Parameters.Add("@RESTA", SqlDbType.Money).Value = LBLNVARESTA.Text
                    com.Parameters.Add("@TOTAL", SqlDbType.Money).Value = LBLNVOABONO.Text
                    com.Parameters.Add("@ABONO", SqlDbType.Money).Value = LBLNVOABONO.Text
                    com.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = "ABONO DEL ADEUDO CON RECARGO DE " & CBOADEUDOS.Text
                    com.Parameters.Add("@NOFACTURA", SqlDbType.Int).Value = 0
                    com.Parameters.Add("@NORECIBO", SqlDbType.Int).Value = 0
                    com.Parameters.Add("@NOFOLIO", SqlDbType.Int).Value = LBLNONVOFOLIO.Text
                    com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                    com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
                    com.Parameters.Add("@IDPRODUC", SqlDbType.Int).Value = LBLIDPRODUC.Text
                    com.Parameters.Add("@IDTIPOPAGO", SqlDbType.Int).Value = CBOTIPOPAGO.SelectedValue
                    com.Parameters.Add("@FACTURA", SqlDbType.Bit).Value = 0
                    com.Parameters.Add("@DIGITOSCUENTA", SqlDbType.NVarChar).Value = 0
                    com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                    com.ExecuteNonQuery()
                    con.Close()

                    con.Open()
                    com = New SqlCommand("REGISTRODEACTIVIDAD", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                    com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "ABONO DEL ADEUDO CON RECARGO CON FOLIO " & LBLNONVOFOLIO.Text
                    com.ExecuteNonQuery()
                    con.Close()

                    IMPRESION = 1
                    My.Forms.VENTANAEMERGENTE.MdiParent = PADRE
                    My.Forms.VENTANAEMERGENTE.Show()
                    Me.Enabled = False

                ElseIf RECARGO = 2 Then
                    con.Open()
                    com = New SqlCommand("MODIFICARMOVIMIENTODEABONOS", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@IDMOV", SqlDbType.Int).Value = CBOADEUDOS.SelectedValue
                    com.ExecuteNonQuery()
                    con.Close()

                    con.Open()
                    com = New SqlCommand("MOVIMIENTOCOLEGIATURA", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@NOMOV", SqlDbType.Int).Value = 1
                    com.Parameters.Add("@RESTA", SqlDbType.Money).Value = LBLNVARESTA.Text
                    com.Parameters.Add("@TOTAL", SqlDbType.Money).Value = LBLNVOABONO.Text
                    com.Parameters.Add("@ABONO", SqlDbType.Money).Value = LBLNVOABONO.Text
                    com.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = "ABONO DEL ADEUDO DE " & CBOADEUDOS.Text
                    com.Parameters.Add("@NOFACTURA", SqlDbType.Int).Value = 0
                    com.Parameters.Add("@NORECIBO", SqlDbType.Int).Value = 0
                    com.Parameters.Add("@NOFOLIO", SqlDbType.Int).Value = LBLNONVOFOLIO.Text
                    com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                    com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
                    com.Parameters.Add("@IDPRODUC", SqlDbType.Int).Value = LBLIDPRODUC.Text
                    com.Parameters.Add("@IDTIPOPAGO", SqlDbType.Int).Value = CBOTIPOPAGO.SelectedValue
                    com.Parameters.Add("@FACTURA", SqlDbType.Bit).Value = 0
                    com.Parameters.Add("@DIGITOSCUENTA", SqlDbType.NVarChar).Value = 0
                    com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                    com.ExecuteNonQuery()
                    con.Close()

                    con.Open()
                    com = New SqlCommand("REGISTRODEACTIVIDAD", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                    com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "ABONO DEL ADEUDO CON FOLIO " & LBLNONVOFOLIO.Text
                    com.ExecuteNonQuery()
                    con.Close()

                    IMPRESION = 1
                    My.Forms.VENTANAEMERGENTE.MdiParent = PADRE
                    My.Forms.VENTANAEMERGENTE.Show()
                    Me.Enabled = False

                End If

            End If


            If BAND = 2 Then

                con.Open()
                com = New SqlCommand("MODIFICARMOVIMIENTODEABONOS", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@IDMOV", SqlDbType.Int).Value = CBOADEUDOS.SelectedValue
                com.ExecuteNonQuery()
                con.Close()

                con.Open()
                com = New SqlCommand("MOVIMIENTOCOLEGIATURA", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@NOMOV", SqlDbType.Int).Value = 2
                com.Parameters.Add("@RESTA", SqlDbType.Money).Value = 0
                com.Parameters.Add("@TOTAL", SqlDbType.Money).Value = LBLRESTA.Text
                com.Parameters.Add("@ABONO", SqlDbType.Money).Value = 0
                com.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = "LIQUIDACION DEL ADEUDO DE " & CBOADEUDOS.Text
                com.Parameters.Add("@NOFACTURA", SqlDbType.Int).Value = 0
                com.Parameters.Add("@NORECIBO", SqlDbType.Int).Value = 0
                com.Parameters.Add("@NOFOLIO", SqlDbType.Int).Value = LBLNONVOFOLIO.Text
                com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
                com.Parameters.Add("@IDPRODUC", SqlDbType.Int).Value = LBLIDPRODUC.Text
                com.Parameters.Add("@IDTIPOPAGO", SqlDbType.Int).Value = CBOTIPOPAGO.SelectedValue
                com.Parameters.Add("@FACTURA", SqlDbType.Bit).Value = CBFACTURA.Checked
                com.Parameters.Add("@DIGITOSCUENTA", SqlDbType.NVarChar).Value = TXT4DIGITOSCUENTA.Text
                com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                com.ExecuteNonQuery()
                con.Close()

                con.Open()
                com = New SqlCommand("REGISTRODEACTIVIDAD", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "LIQUIDACION DEL ADEUDO CON FOLIO " & LBLNONVOFOLIO.Text
                com.ExecuteNonQuery()
                con.Close()
                IMPRESION = 1
                My.Forms.VENTANAEMERGENTE.MdiParent = PADRE
                My.Forms.VENTANAEMERGENTE.Show()
                Me.Enabled = False
            End If
        Catch ex As System.Exception
            con.Close()
            MsgBox("SE ENCONTRO UN PROBLEMA PONGANSE EN CONTACTO CON SU ADMINISTRADOR", MsgBoxStyle.Information, "AVISO")
        End Try
    End Sub


    Private Sub TXT4DIGITOSCUENTA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT4DIGITOSCUENTA.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TXT4DIGITOSCUENTA_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT4DIGITOSCUENTA.Leave
        If TXT4DIGITOSCUENTA.TextLength > 0 And TXT4DIGITOSCUENTA.TextLength < 4 Then
            MsgBox("EL NUMERO DE CUENTA DEBE DE CONSTAR DE 4 DIGITOS", MsgBoxStyle.Critical, "ERROR")
            TXT4DIGITOSCUENTA.Focus()
        End If
    End Sub

End Class