Imports System.Data.SqlClient
Imports System.Data
Public Class PAGOCOLEGIATURA

    Dim RECARG As Decimal = 0
    Dim TOTAL As Decimal = 0
    Dim ABONO As Decimal = 0
    Dim BECA As Decimal = 0
    Dim BECASEP As Decimal = 0




    Private Sub PAGOCOLEGIATURA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARPROMOCIONCOLEGIATURA' table. You can move, or remove it, as needed.
        Me.SELECCIONARPROMOCIONCOLEGIATURATableAdapter.Fill(Me.SACDataSet.SELECCIONARPROMOCIONCOLEGIATURA)
        'TODO: This line of code loads data into the 'SACDataSet.TIPOSDEPAGO' table. You can move, or remove it, as needed.
        Me.TIPOSDEPAGOTableAdapter.Fill(Me.SACDataSet.TIPOSDEPAGO)
        If SELECCIONDEALUMNO.CBREQFACTURA.Checked = True Then
            TXT4DIGITOSCUENTA.Visible = True
        Else
            TXT4DIGITOSCUENTA.Visible = False
        End If
        If Intro.IdRangoLabel1.Text <= 2 Then
            DTFECHAADMIN.Visible = True
            GPFECHATRANS.Visible = True
        Else
            DTFECHAADMIN.Visible = False
            GPFECHATRANS.Visible = False
        End If
        BAND = 0
        LBLNOPAGARCOLEADE.Hide()
        LBLIDPRODUC.Hide()
        LBLDESCONBECA.Hide()
        LBLSCOPORBECA.Hide()
        ' LBLFECHAVENCI.Hide()
        LBLNVOFOLIO.Hide()
        LBLNOFOLIOMAX.Hide()
        LBLPORCENTAJE.Hide()
        CBRECARGO.Hide()
        LBLABONORECARG.Hide()
        LBLABONADO.Hide()
        LBLLIQUIDADO.Hide()
        LBLMONTOBASE.Hide()
        LBLCOLEANTERIOR.Hide()
        LBLPORCENTPROMO.Hide()
        LBLDESCRIPCIONPROMO.Hide()
        Try
            Me.NUEVORECIBOFOLIOFACTURATableAdapter.Fill(Me.SACDataSet.NUEVORECIBOFOLIOFACTURA, New System.Nullable(Of Integer)(CType(BANDERARECFOLFAC, Integer)))
            LBLNVOFOLIO.Text = CInt(LBLNOFOLIOMAX.Text) + 1
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Try
            Me.COBRODECOLEGIATURATableAdapter.Fill(Me.SACDataSet.COBRODECOLEGIATURA, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.LBLIDNIVEL.Text, Integer)), New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))
        Catch ex As System.Exception
            con.Close()
            MsgBox("SE ENCONTRO UN PROBLEMA PONGANSE EN CONTACTO CON SU ADMINISTRADOR", MsgBoxStyle.Information, "AVISO")
        End Try
    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        My.Forms.SELECCIONDEALUMNO.Close()
        Me.Close()
    End Sub

    Private Sub CMDABONO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDABONO.Click
        Try
            BAND = 1
            If SELECCIONDEALUMNO.CBREQFACTURA.Checked = True Then
                MsgBox("EL PADRE DE FAMILIA REQUIERE FACTURA POR FAVOR INGRESE LOS 4 ULTIMOS DIGITOS DE LA CUENTA PARA CONTINUAR", MsgBoxStyle.Information, "ATENCION")
                TXT4DIGITOSCUENTA.Focus()
            Else
                If Intro.IdRangoLabel1.Text <= 2 Then
                    If CDate(DTFECHAADMIN.Value) > CDate(LBLFECHAVENCI.Text) Then
                        RECARGO = 1
                        MsgBox("EL ABONO TENDRA UN RECARGO DEL 10% AVISAR AL TUTOR", MsgBoxStyle.Information, "AVISO")
                        ABONO = InputBox("CUANTO ES LO QUE DESEA ABONAR?", "ABONO", 0)
                        If ABONO > CDec(LBLMONTOBASE.Text) Then
                            MsgBox("EL ABONO ES MAYOR QUE LA DIFERENCIA", MsgBoxStyle.Exclamation, "AVISO")
                        Else
                            LBLABONO.Text = ABONO
                            RECARG = CDec(LBLMONTO.Text) * CDec(LBLPORCENTAJE.Text)
                            TOTAL = RECARG + LBLMONTO.Text
                            LBLRESTA.Text = CDec(TOTAL) - CDec(LBLABONO.Text)
                            LBLABONORECARG.Text = TOTAL
                            LBLABONORECARG.Text = FormatCurrency(LBLABONORECARG.Text)
                            LBLMONTO.Text = LBLABONORECARG.Text
                            LBLMONTO.Text = FormatCurrency(LBLMONTO.Text)
                            LBLRESTA.Text = FormatCurrency(LBLRESTA.Text)
                            LBLABONO.Text = FormatCurrency(LBLABONO.Text)
                        End If
                    Else
                        RECARGO = 2
                        ABONO = InputBox("CUANTO ES LO QUE DESEA ABONAR?", "ABONO", 0)
                        If ABONO > CDec(LBLMONTOBASE.Text) Then
                            MsgBox("EL ABONO ES MAYOR QUE LA DIFERENCIA", MsgBoxStyle.Exclamation, "AVISO")
                        Else
                            LBLABONO.Text = ABONO
                            LBLRESTA.Text = CDec(LBLMONTO.Text) - CDec(LBLABONO.Text)
                            LBLRESTA.Text = FormatCurrency(LBLRESTA.Text)
                            LBLABONO.Text = FormatCurrency(LBLABONO.Text)
                        End If
                    End If
                Else
                    If CDate(DTFECHAADMIN.Value) > CDate(LBLFECHAVENCI.Text) Then
                        RECARGO = 1
                        MsgBox("EL ABONO TENDRA UN RECARGO DEL 10% AVISAR AL TUTOR", MsgBoxStyle.Information, "AVISO")
                        ABONO = InputBox("CUANTO ES LO QUE DESEA ABONAR?", "ABONO", 0)
                        If ABONO > CDec(LBLMONTOBASE.Text) Then
                            MsgBox("EL ABONO ES MAYOR QUE LA DIFERENCIA", MsgBoxStyle.Exclamation, "AVISO")
                        Else
                            LBLABONO.Text = ABONO
                            RECARG = CDec(LBLMONTOBASE.Text) * CDec(LBLPORCENTAJE.Text)
                            TOTAL = RECARG + LBLMONTOBASE.Text
                            LBLRESTA.Text = CDec(TOTAL) - CDec(LBLABONO.Text)
                            LBLABONORECARG.Text = TOTAL
                            LBLMONTO.Text = LBLABONORECARG.Text
                            LBLMONTO.Text = FormatCurrency(LBLMONTO.Text)
                            LBLABONORECARG.Text = FormatCurrency(LBLABONORECARG.Text)
                            LBLRESTA.Text = FormatCurrency(LBLRESTA.Text)
                            LBLABONO.Text = FormatCurrency(LBLABONO.Text)
                        End If

                    Else
                        RECARGO = 2
                        ABONO = InputBox("CUANTO ES LO QUE DESEA ABONAR?", "ABONO", 0)
                        If ABONO > CDec(LBLMONTOBASE.Text) Then
                            MsgBox("EL ABONO ES MAYOR QUE LA DIFERENCIA", MsgBoxStyle.Exclamation, "AVISO")
                        Else
                            LBLABONO.Text = ABONO
                            LBLRESTA.Text = CDec(LBLMONTOBASE.Text) - CDec(LBLABONO.Text)
                            LBLRESTA.Text = FormatCurrency(LBLRESTA.Text)
                            LBLABONO.Text = FormatCurrency(LBLABONO.Text)
                        End If
                    End If
                End If

            End If

            LBL4DIGITOSCUENTA.Visible = False
            TXT4DIGITOSCUENTA.Visible = False

        Catch ex As System.Exception
            con.Close()
            MsgBox("SE ENCONTRO UN PROBLEMA PONGANSE EN CONTACTO CON SU ADMINISTRADOR", MsgBoxStyle.Information, "AVISO")
        End Try

    End Sub

    Private Sub CMDIMPRIMIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDIMPRIMIR.Click
        Try

            Dim com As SqlCommand = con.CreateCommand()
            IMPRESION = 0
            If BAND = 1 Then
                If RECARGO = 1 Then
                    con.Open()
                    com = New SqlCommand("MOVIMIENTOCOLEGIATURA", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@NOMOV", SqlDbType.Int).Value = 1
                    com.Parameters.Add("@RESTA", SqlDbType.Money).Value = LBLRESTA.Text
                    com.Parameters.Add("@TOTAL", SqlDbType.Money).Value = LBLABONO.Text
                    com.Parameters.Add("@ABONO", SqlDbType.Money).Value = LBLABONO.Text
                    com.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = "ABONO CON RECARGO A " & CBOCOLEGIATURAS.Text
                    com.Parameters.Add("@NOFACTURA", SqlDbType.Int).Value = 0
                    com.Parameters.Add("@NORECIBO", SqlDbType.Int).Value = 0
                    com.Parameters.Add("@NOFOLIO", SqlDbType.Int).Value = LBLNVOFOLIO.Text
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
                    com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "ABONO DE COLEGIATURA CON RECARGO CON FOLIO " & LBLNVOFOLIO.Text
                    com.ExecuteNonQuery()
                    con.Close()
                    IMPRESION = 1
                    My.Forms.VENTANAEMERGENTE.MdiParent = PADRE
                    My.Forms.VENTANAEMERGENTE.Show()
                    Me.Enabled = False

                ElseIf RECARGO = 2 Then
                    con.Open()
                    com = New SqlCommand("MOVIMIENTOCOLEGIATURA", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@NOMOV", SqlDbType.Int).Value = 1
                    com.Parameters.Add("@RESTA", SqlDbType.Money).Value = LBLRESTA.Text
                    com.Parameters.Add("@TOTAL", SqlDbType.Money).Value = LBLABONO.Text
                    com.Parameters.Add("@ABONO", SqlDbType.Money).Value = LBLABONO.Text
                    com.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = "ABONO A " & CBOCOLEGIATURAS.Text
                    com.Parameters.Add("@NOFACTURA", SqlDbType.Int).Value = 0
                    com.Parameters.Add("@NORECIBO", SqlDbType.Int).Value = 0
                    com.Parameters.Add("@NOFOLIO", SqlDbType.Int).Value = LBLNVOFOLIO.Text
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
                    com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "ABONO DE COLEGIATURA CON FOLIO " & LBLNVOFOLIO.Text
                    com.ExecuteNonQuery()
                    con.Close()

                    IMPRESION = 1
                    My.Forms.VENTANAEMERGENTE.MdiParent = PADRE
                    My.Forms.VENTANAEMERGENTE.Show()
                    Me.Enabled = False
                End If
            End If

            If BAND = 2 Then
                If RECARGO = 1 Then
                    con.Open()
                    com = New SqlCommand("MOVIMIENTOCOLEGIATURA", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@NOMOV", SqlDbType.Int).Value = 2
                    com.Parameters.Add("@RESTA", SqlDbType.Money).Value = 0
                    com.Parameters.Add("@TOTAL", SqlDbType.Money).Value = LBLABONORECARG.Text
                    com.Parameters.Add("@ABONO", SqlDbType.Money).Value = 0
                    com.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = "LIQUIDACION CON RECARGO DE " & CBOCOLEGIATURAS.Text
                    com.Parameters.Add("@NOFACTURA", SqlDbType.Int).Value = 0
                    com.Parameters.Add("@NORECIBO", SqlDbType.Int).Value = 0
                    com.Parameters.Add("@NOFOLIO", SqlDbType.Int).Value = LBLNVOFOLIO.Text
                    com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                    com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
                    com.Parameters.Add("@IDPRODUC", SqlDbType.Int).Value = LBLIDPRODUC.Text
                    com.Parameters.Add("@IDTIPOPAGO", SqlDbType.Int).Value = CBOTIPOPAGO.SelectedValue
                    com.Parameters.Add("@FACTURA", SqlDbType.Bit).Value = SELECCIONDEALUMNO.CBREQFACTURA.Checked
                    com.Parameters.Add("@DIGITOSCUENTA", SqlDbType.NVarChar).Value = TXT4DIGITOSCUENTA.Text
                    com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                    com.ExecuteNonQuery()
                    con.Close()

                    con.Open()
                    com = New SqlCommand("REGISTRODEACTIVIDAD", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                    com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "LIQUIDACION DE COLEGIATURA CON RECARGO CON FOLIO " & LBLNVOFOLIO.Text
                    com.ExecuteNonQuery()
                    con.Close()
                    IMPRESION = 1
                    My.Forms.VENTANAEMERGENTE.MdiParent = PADRE
                    My.Forms.VENTANAEMERGENTE.Show()
                    Me.Enabled = False

                ElseIf RECARGO = 2 Then

                    con.Open()
                    com = New SqlCommand("MOVIMIENTOCOLEGIATURA", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@NOMOV", SqlDbType.Int).Value = 2
                    com.Parameters.Add("@RESTA", SqlDbType.Money).Value = 0
                    com.Parameters.Add("@TOTAL", SqlDbType.Money).Value = LBLMONTO.Text
                    com.Parameters.Add("@ABONO", SqlDbType.Money).Value = 0
                    com.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = "LIQUIDACION DE " & CBOCOLEGIATURAS.Text
                    com.Parameters.Add("@NOFACTURA", SqlDbType.Int).Value = 0
                    com.Parameters.Add("@NORECIBO", SqlDbType.Int).Value = 0
                    com.Parameters.Add("@NOFOLIO", SqlDbType.Int).Value = LBLNVOFOLIO.Text
                    com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                    com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
                    com.Parameters.Add("@IDPRODUC", SqlDbType.Int).Value = LBLIDPRODUC.Text
                    com.Parameters.Add("@IDTIPOPAGO", SqlDbType.Int).Value = CBOTIPOPAGO.SelectedValue
                    com.Parameters.Add("@FACTURA", SqlDbType.Bit).Value = SELECCIONDEALUMNO.CBREQFACTURA.Checked
                    com.Parameters.Add("@DIGITOSCUENTA", SqlDbType.NVarChar).Value = TXT4DIGITOSCUENTA.Text
                    com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                    com.ExecuteNonQuery()
                    con.Close()

                    con.Open()
                    com = New SqlCommand("REGISTRODEACTIVIDAD", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                    com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "LIQUIDACION DE COLEGIATURA CON FOLIO " & LBLNVOFOLIO.Text
                    com.ExecuteNonQuery()
                    con.Close()
                    IMPRESION = 1
                    My.Forms.VENTANAEMERGENTE.MdiParent = PADRE
                    My.Forms.VENTANAEMERGENTE.Show()
                    Me.Enabled = False

                End If

            End If


        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
            MsgBox("SE ENCONTRO UN PROBLEMA PONGANSE EN CONTACTO CON SU ADMINISTRADOR", MsgBoxStyle.Information, "AVISO")
        End Try

    End Sub

    Private Sub CMDLIQUIDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDLIQUIDAR.Click
        Try
            BAND = 2
            If SELECCIONDEALUMNO.CBREQFACTURA.Checked = True Then
                MsgBox("EL PADRE DE FAMILIA REQUIERE FACTURA POR FAVOR INGRESE LOS DIGITOS DE LA CUENTA PARA CONTINUAR", MsgBoxStyle.Information, "ATENCION")
                TXT4DIGITOSCUENTA.Focus()
            Else

                If Intro.IdRangoLabel1.Text <= 2 Then

                    If TXTPASS.Text = Intro.PassLabel1.Text Then
                        RECARGO = 2
                        LBLRESTA.Text = 0
                        LBLABONO.Text = 0
                        LBLRESTA.Text = FormatCurrency(LBLRESTA.Text)
                        LBLABONO.Text = FormatCurrency(LBLABONO.Text)
                    Else
                        If CDate(DTFECHAADMIN.Value) > CDate(LBLFECHAVENCI.Text) Then
                            RECARGO = 1
                            MsgBox("LA LIQUIDACION TENDRA UN RECARGO DEL 10% AVISAR AL TUTOR", MsgBoxStyle.Information, "AVISO")
                            LBLRESTA.Text = 0
                            LBLABONO.Text = 0
                            RECARG = CDec(LBLMONTO.Text) * CDec(LBLPORCENTAJE.Text)
                            TOTAL = CDec(LBLMONTO.Text) + RECARG
                            LBLMONTO.Text = TOTAL
                            LBLMONTO.Text = FormatCurrency(LBLMONTO.Text)
                            LBLABONORECARG.Text = TOTAL
                            LBLABONORECARG.Text = FormatCurrency(LBLABONORECARG.Text)
                            LBLRESTA.Text = FormatCurrency(LBLRESTA.Text)
                            LBLABONO.Text = FormatCurrency(LBLABONO.Text)
                        Else
                            RECARGO = 2
                            LBLRESTA.Text = 0
                            LBLABONO.Text = 0
                            LBLRESTA.Text = FormatCurrency(LBLRESTA.Text)
                            LBLABONO.Text = FormatCurrency(LBLABONO.Text)
                        End If
                    End If
                Else

                    If TXTPASS.Text = "02658+4" Then
                        RECARGO = 2
                        LBLRESTA.Text = 0
                        LBLABONO.Text = 0
                        LBLRESTA.Text = FormatCurrency(LBLRESTA.Text)
                        LBLABONO.Text = FormatCurrency(LBLABONO.Text)
                    Else
                        If CDate(PADRE.TSFECHA.Text) > CDate(LBLFECHAVENCI.Text) Then
                            RECARGO = 1
                            MsgBox("LA LIQUIDACION TENDRA UN RECARGO DEL 10% AVISAR AL TUTOR", MsgBoxStyle.Information, "AVISO")
                            LBLRESTA.Text = 0
                            LBLABONO.Text = 0
                            RECARG = CDec(LBLMONTO.Text) * CDec(LBLPORCENTAJE.Text)
                            TOTAL = CDec(LBLMONTO.Text) + RECARG
                            LBLMONTO.Text = TOTAL
                            LBLMONTO.Text = FormatCurrency(LBLMONTO.Text)
                            LBLABONORECARG.Text = TOTAL
                            LBLABONORECARG.Text = FormatCurrency(LBLABONORECARG.Text)
                            LBLRESTA.Text = FormatCurrency(LBLRESTA.Text)
                            LBLABONO.Text = FormatCurrency(LBLABONO.Text)
                        Else
                            RECARGO = 2
                            LBLRESTA.Text = 0
                            LBLABONO.Text = 0
                            LBLRESTA.Text = FormatCurrency(LBLRESTA.Text)
                            LBLABONO.Text = FormatCurrency(LBLABONO.Text)
                        End If

                    End If

                End If
            End If


            LBL4DIGITOSCUENTA.Visible = True
            TXT4DIGITOSCUENTA.Visible = True

            Me.Enabled = False

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
            MsgBox("SE ENCONTRO UN PROBLEMA PONGANSE EN CONTACTO CON SU ADMINISTRADOR", MsgBoxStyle.Information, "AVISO")
        End Try
    End Sub

    Private Sub CBOCOLEGIATURAS_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBOCOLEGIATURAS.Validated
        Try
            Me.INSCRIPCIONESOCOLEGIATURASABONADASTableAdapter.Fill(Me.SACDataSet.INSCRIPCIONESOCOLEGIATURASABONADAS, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.CBOALUMNO.SelectedValue, Integer)), New System.Nullable(Of Integer)(CType(LBLIDPRODUC.Text, Integer)), New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))
            Me.INSCRIPCIONYCOLEGIATURASLIQUIDADASTableAdapter.Fill(Me.SACDataSet.INSCRIPCIONYCOLEGIATURASLIQUIDADAS, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.CBOALUMNO.SelectedValue, Integer)), New System.Nullable(Of Integer)(CType(LBLIDPRODUC.Text, Integer)), New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))
            If LBLABONADO.Text = 1 Then
                MsgBox("ESTE CONCEPTO YA ESTA EN ABONOS", MsgBoxStyle.Information, "AVISO")
                CMDABONO.Enabled = False
                CMDLIQUIDAR.Enabled = False
                CMDIMPRIMIR.Enabled = False
            ElseIf LBLLIQUIDADO.Text = 1 Then
                MsgBox("ESTE CONCEPTO YA ESTA LIQUIDADO", MsgBoxStyle.Information, "AVISO")
                CMDABONO.Enabled = False
                CMDLIQUIDAR.Enabled = False
                CMDIMPRIMIR.Enabled = False
            Else
                CMDABONO.Enabled = True
                CMDLIQUIDAR.Enabled = True
                CMDIMPRIMIR.Enabled = True
            End If

        Catch ex As System.Exception
            con.Close()
            MsgBox("SE ENCONTRO UN PROBLEMA PONGANSE EN CONTACTO CON SU ADMINISTRADOR", MsgBoxStyle.Information, "AVISO")
        End Try
    End Sub


    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Try
            Me.SELECCIONARFECHAVENCIPORCICLOYPRODUCTOTableAdapter.Fill(Me.SACDataSet.SELECCIONARFECHAVENCIPORCICLOYPRODUCTO, New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)), New System.Nullable(Of Integer)(CType(LBLIDPRODUC.Text, Integer)))
        If SELECCIONDEALUMNO.CBBECA.Checked = True Then
            BECA = CDec(LBLMONTOBASE.Text) * CDec(SELECCIONDEALUMNO.LBLPORCBECA.Text)
            LBLSCOPORBECA.Text = CDec(LBLMONTOBASE.Text) - BECA
                LBLSCOPORBECA.Text = FormatCurrency(LBLSCOPORBECA.Text)
                LBLDESCONBECA.Show()
                LBLSCOPORBECA.Show()
                LBLMONTO.Text = LBLSCOPORBECA.Text
                LBLMONTO.Text = FormatCurrency(LBLMONTO.Text)
                CMDABONO.Visible = True
                CMDLIQUIDAR.Visible = True
                CMDIMPRIMIR.Visible = True
                TEXTO = "CON DESCUENTO DE BECA INTERNA"
            ElseIf SELECCIONDEALUMNO.CBBECASEP.Checked = True Then
                BECASEP = CDec(LBLMONTOBASE.Text) * CDec(SELECCIONDEALUMNO.LBLPORCBECASEP.Text)
                LBLSCOPORBECA.Text = CDec(LBLMONTOBASE.Text) - BECASEP
                LBLSCOPORBECA.Text = FormatCurrency(LBLSCOPORBECA.Text)
                LBLDESCONBECA.Show()
                LBLSCOPORBECA.Show()
                LBLMONTO.Text = LBLSCOPORBECA.Text
                LBLMONTO.Text = FormatCurrency(LBLMONTO.Text)
                CMDABONO.Visible = True
                CMDLIQUIDAR.Visible = True
                CMDIMPRIMIR.Visible = True
                TEXTO = "CON DESCUENTO DE BECA SEP"
            Else
                CMDABONO.Visible = True
                CMDLIQUIDAR.Visible = True
                CMDIMPRIMIR.Visible = True
                LBLMONTO.Text = LBLMONTOBASE.Text
                LBLMONTO.Text = FormatCurrency(LBLMONTO.Text)
                TEXTO = ""
            End If

        If SELECCIONDEALUMNO.LBLIDNIVEL.Text = 1 Then
                If LBLIDPRODUC.Text > 1 And LBLIDPRODUC.Text < 12 Then
                    LBLNOPAGARCOLEADE.Text = CInt(LBLIDPRODUC.Text) - 1
                    Me.NOPAGARCOLEGIATURASADELANTADASTableAdapter.Fill(Me.SACDataSet.NOPAGARCOLEGIATURASADELANTADAS, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.CBOALUMNO.SelectedValue, Integer)), New System.Nullable(Of Integer)(CType(LBLNOPAGARCOLEADE.Text, Integer)))
                    If LBLCOLEANTERIOR.Text = 0 Then
                        MsgBox("TIENE COLEGIATURAS PENDIENTES", MsgBoxStyle.Exclamation, "AVISO")
                        CMDIMPRIMIR.Enabled = False
                        CMDABONO.Enabled = False
                        CMDLIQUIDAR.Enabled = False
                    Else
                        CMDIMPRIMIR.Enabled = True
                        CMDABONO.Enabled = True
                        CMDLIQUIDAR.Enabled = True
                    End If
                Else
                    CMDIMPRIMIR.Enabled = True
                    CMDABONO.Enabled = True
                    CMDLIQUIDAR.Enabled = True
                End If
            End If

            If SELECCIONDEALUMNO.LBLIDNIVEL.Text = 2 Then
                If LBLIDPRODUC.Text > 13 And LBLIDPRODUC.Text < 24 Then
                    LBLNOPAGARCOLEADE.Text = CInt(LBLIDPRODUC.Text) - 1
                    Me.NOPAGARCOLEGIATURASADELANTADASTableAdapter.Fill(Me.SACDataSet.NOPAGARCOLEGIATURASADELANTADAS, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.CBOALUMNO.SelectedValue, Integer)), New System.Nullable(Of Integer)(CType(LBLNOPAGARCOLEADE.Text, Integer)))
                    If LBLCOLEANTERIOR.Text = 0 Then
                        MsgBox("TIENE COLEGIATURAS PENDIENTES", MsgBoxStyle.Exclamation, "AVISO")
                        CMDIMPRIMIR.Enabled = False
                        CMDABONO.Enabled = False
                        CMDLIQUIDAR.Enabled = False
                    Else
                        CMDIMPRIMIR.Enabled = True
                        CMDABONO.Enabled = True
                        CMDLIQUIDAR.Enabled = True
                    End If
                Else
                    CMDIMPRIMIR.Enabled = True
                    CMDABONO.Enabled = True
                    CMDLIQUIDAR.Enabled = True
                End If
            End If

            If SELECCIONDEALUMNO.LBLIDNIVEL.Text = 3 Then
                If LBLIDPRODUC.Text > 25 And LBLIDPRODUC.Text < 36 Then
                    LBLNOPAGARCOLEADE.Text = CInt(LBLIDPRODUC.Text) - 1
                    Me.NOPAGARCOLEGIATURASADELANTADASTableAdapter.Fill(Me.SACDataSet.NOPAGARCOLEGIATURASADELANTADAS, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.CBOALUMNO.SelectedValue, Integer)), New System.Nullable(Of Integer)(CType(LBLNOPAGARCOLEADE.Text, Integer)))
                    If LBLCOLEANTERIOR.Text = 0 Then
                        MsgBox("TIENE COLEGIATURAS PENDIENTES", MsgBoxStyle.Exclamation, "AVISO")
                        CMDIMPRIMIR.Enabled = False
                        CMDABONO.Enabled = False
                        CMDLIQUIDAR.Enabled = False
                    Else
                        CMDIMPRIMIR.Enabled = True
                        CMDABONO.Enabled = True
                        CMDLIQUIDAR.Enabled = True
                    End If
                Else
                    CMDIMPRIMIR.Enabled = True
                    CMDABONO.Enabled = True
                    CMDLIQUIDAR.Enabled = True
                End If
            End If

      
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
            MsgBox("SE ENCONTRO UN PROBLEMA PONGANSE EN CONTACTO CON SU ADMINISTRADOR", MsgBoxStyle.Information, "AVISO")
        End Try
    End Sub

    Private Sub CBOCOLEGIATURAS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOCOLEGIATURAS.SelectedIndexChanged
        CMDABONO.Visible = False
        CMDLIQUIDAR.Visible = False
        CMDIMPRIMIR.Visible = False

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

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
         
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CBPROMOCION_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBPROMOCION.CheckedChanged
        If CBPROMOCION.Checked = True Then
            CBOPROMOCION.Enabled = True
        Else
            CBOPROMOCION.Enabled = False
        End If
    End Sub

    Private Sub FillToolStripButton_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.SELECCIONARFECHAVENCIPORCICLOYPRODUCTOTableAdapter.Fill(Me.SACDataSet.SELECCIONARFECHAVENCIPORCICLOYPRODUCTO, New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)), New System.Nullable(Of Integer)(CType(CBOCOLEGIATURAS.SelectedValue, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub FillToolStripButton_Click_5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.COBRODECOLEGIATURATableAdapter.Fill(Me.SACDataSet.COBRODECOLEGIATURA, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.LBLIDNIVEL.Text, Integer)), New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TXTCODIGOPROMO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTCODIGOPROMO.TextChanged
        If TXTCODIGOPROMO.Text = "" Then
            CBPROMOCION.Enabled = True
        Else
            CBPROMOCION.Enabled = False
        End If
    End Sub

End Class