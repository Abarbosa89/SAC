Public Class VENTANAEMERGENTE
    Dim sSQL As String = ""
    Dim D1 As New DataTable
    Dim ds As DataSet
    Dim dr1 As DataRow
    Dim aParam(5) As String
    Private Sub VENTANAEMERGENTE_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Forms.COBROSPRODUCTOS.Close()
        My.Forms.ADEUDOSPRODUCTOS.Close()
        My.Forms.PAGODEINSCRIPCION.Close()
        My.Forms.PAGARADEUDOS.Close()
        My.Forms.PAGOCOLEGIATURA.Close()
        My.Forms.SELECCIONDEALUMNO.Close()
        My.Forms.INSCRIPCIONCNPROMOCION.Close()
    End Sub

    Private Sub VENTANAEMERGENTE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CMDIMPRIMIRTICKETS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDIMPRIMIRTICKETS.Click
        Try

 
            If ImpTicketGLOBAL = "" Then
                MsgBox("NO tiene ninguna impresora de tickets seleccionada", MsgBoxStyle.Information, "iMPRESION")
                Exit Sub
            End If

            If IMPRESION = 1 Then
                If BANDERAPAGO = 1 Then
                    If BAND = 1 Then
                        Dim RPT As New RECIBOCOLEGIATURA
                        RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
                        RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                        RPT.SetParameterValue("DIGITOSCUENTA", PAGODEINSCRIPCION.TXT4DIGITOSCUENTA.Text)
                        ' RPT.SetParameterValue("CONCEPTO", PAGODEINSCRIPCION.ComboBox1.SelectedValue)
                        RPT.SetParameterValue("DESCRIPCION", "ABONO A " & PAGODEINSCRIPCION.ComboBox1.Text & "CICLO " & PADRE.LBLCICLO.Text)
                        RPT.SetParameterValue("IMPORTE", PAGODEINSCRIPCION.LBLABONO.Text)
                        RPT.SetParameterValue("RESTA", PAGODEINSCRIPCION.LBLRESTA.Text)
                        RPT.SetParameterValue("TOTAL", PAGODEINSCRIPCION.LBLABONO.Text)
                        RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                        RPT.SetParameterValue("FOLIO", PAGODEINSCRIPCION.LBLNOFOLIOMAX.Text)
                        RPT.SetParameterValue("CICLOESCOLAR", 0)
                        RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                        RPT.SetParameterValue("TIPOPAGO", PAGODEINSCRIPCION.CBOTIPOPAGO.Text)
                        RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                        RPT.PrintOptions.PrinterName = "\\192.168.1.66\RECIBOS"
                        RPT.PrintToPrinter(1, False, 0, 0)

                        'CrystalReportViewer1.ReportSource = RPT
                    End If
                    If BAND = 2 Then
                        Dim RPT As New RECIBOCOLEGIATURA
                        RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
                        RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                        RPT.SetParameterValue("DIGITOSCUENTA", PAGODEINSCRIPCION.TXT4DIGITOSCUENTA.Text)
                        ' RPT.SetParameterValue("CONCEPTO", PAGODEINSCRIPCION.ComboBox1.SelectedValue)
                        RPT.SetParameterValue("DESCRIPCION", "LIQUIDACION DE " & PAGODEINSCRIPCION.ComboBox1.Text & "CICLO " & PADRE.LBLCICLO.Text)
                        RPT.SetParameterValue("IMPORTE", PAGODEINSCRIPCION.LBLMONTO.Text)
                        RPT.SetParameterValue("RESTA", 0)
                        RPT.SetParameterValue("TOTAL", PAGODEINSCRIPCION.LBLMONTO.Text)
                        RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                        RPT.SetParameterValue("FOLIO", PAGODEINSCRIPCION.LBLNOFOLIOMAX.Text)
                        RPT.SetParameterValue("CICLOESCOLAR", 0)
                        RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                        RPT.SetParameterValue("TIPOPAGO", PAGODEINSCRIPCION.CBOTIPOPAGO.Text)
                        RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                        RPT.PrintOptions.PrinterName = "\\192.168.1.66\RECIBOS"
                        RPT.PrintToPrinter(1, False, 0, 0)

                        'CrystalReportViewer1.ReportSource = RPT
                    End If

                End If

                If BANDERAPAGO = 3 Then
                    If BAND = 1 Then
                        If RECARGO = 1 Then
                            Dim RPT As New RECIBOCOLEGIATURA
                            RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
                            RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                            RPT.SetParameterValue("DIGITOSCUENTA", PAGARADEUDOS.TXT4DIGITOSCUENTA.Text)
                            ' RPT.SetParameterValue("CONCEPTO", "ABONO")
                            RPT.SetParameterValue("DESCRIPCION", "ABONO CON RECARGO DE " & PAGARADEUDOS.CBOADEUDOS.Text)
                            RPT.SetParameterValue("IMPORTE", PAGARADEUDOS.LBLNVOABONO.Text)
                            RPT.SetParameterValue("RESTA", PAGARADEUDOS.LBLABONORECARG.Text)
                            RPT.SetParameterValue("TOTAL", PAGARADEUDOS.LBLNVOABONO.Text)
                            RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                            RPT.SetParameterValue("FOLIO", PAGARADEUDOS.LBLNONVOFOLIO.Text)
                            RPT.SetParameterValue("CICLOESCOLAR", 0)
                            RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                            RPT.SetParameterValue("TIPOPAGO", PAGARADEUDOS.CBOTIPOPAGO.Text)
                            RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                            RPT.PrintOptions.PrinterName = "\\192.168.1.66\RECIBOS"
                            RPT.PrintToPrinter(1, False, 0, 0)

                            'CrystalReportViewer1.ReportSource = RPT
                        End If

                        If RECARGO = 2 Then
                            Dim RPT As New RECIBOCOLEGIATURA
                            RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
                            RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                            RPT.SetParameterValue("DIGITOSCUENTA", PAGARADEUDOS.TXT4DIGITOSCUENTA.Text)
                            ' RPT.SetParameterValue("CONCEPTO", "ABONO")
                            RPT.SetParameterValue("DESCRIPCION", "ABONO A " & PAGARADEUDOS.CBOADEUDOS.Text)
                            RPT.SetParameterValue("IMPORTE", PAGARADEUDOS.LBLNVOABONO.Text)
                            RPT.SetParameterValue("RESTA", PAGARADEUDOS.LBLNVARESTA.Text)
                            RPT.SetParameterValue("TOTAL", PAGARADEUDOS.LBLNVOABONO.Text)
                            RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                            RPT.SetParameterValue("FOLIO", PAGARADEUDOS.LBLNONVOFOLIO.Text)
                            RPT.SetParameterValue("CICLOESCOLAR", 0)
                            RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                            RPT.SetParameterValue("TIPOPAGO", PAGARADEUDOS.CBOTIPOPAGO.Text)
                            RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                            RPT.PrintOptions.PrinterName = "\\192.168.1.66\RECIBOS"
                            RPT.PrintToPrinter(1, False, 0, 0)

                            'CrystalReportViewer1.ReportSource = RPT
                        End If

                    End If

                    If BAND = 2 Then
                        If RECARGO = 1 Then
                            Dim RPT As New RECIBOCOLEGIATURA
                            RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
                            RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                            RPT.SetParameterValue("DIGITOSCUENTA", PAGARADEUDOS.TXT4DIGITOSCUENTA.Text)
                            ' RPT.SetParameterValue("CONCEPTO", "LIQUIDACION")
                            RPT.SetParameterValue("DESCRIPCION", "LIQUIDACION CON RECARGO DE " & PAGARADEUDOS.CBOADEUDOS.Text)
                            RPT.SetParameterValue("IMPORTE", PAGARADEUDOS.LBLABONORECARG.Text)
                            RPT.SetParameterValue("RESTA", "0")
                            RPT.SetParameterValue("TOTAL", PAGARADEUDOS.LBLABONORECARG.Text)
                            RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                            RPT.SetParameterValue("FOLIO", PAGARADEUDOS.LBLNONVOFOLIO.Text)
                            RPT.SetParameterValue("CICLOESCOLAR", 0)
                            RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                            RPT.SetParameterValue("TIPOPAGO", PAGARADEUDOS.CBOTIPOPAGO.Text)
                            RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                            RPT.PrintOptions.PrinterName = "\\192.168.1.66\RECIBOS"
                            RPT.PrintToPrinter(1, False, 0, 0)

                            ' CrystalReportViewer1.ReportSource = RPT
                        End If

                        If RECARGO = 2 Then
                            Dim RPT As New RECIBOCOLEGIATURA
                            RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
                            RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                            RPT.SetParameterValue("DIGITOSCUENTA", PAGARADEUDOS.TXT4DIGITOSCUENTA.Text)
                            ' RPT.SetParameterValue("CONCEPTO", "LIQUIDACION")
                            RPT.SetParameterValue("DESCRIPCION", "LIQUIDACION DE " & PAGARADEUDOS.CBOADEUDOS.Text)
                            RPT.SetParameterValue("IMPORTE", PAGARADEUDOS.LBLRESTA.Text)
                            RPT.SetParameterValue("RESTA", "0")
                            RPT.SetParameterValue("TOTAL", PAGARADEUDOS.LBLRESTA.Text)
                            RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                            RPT.SetParameterValue("FOLIO", PAGARADEUDOS.LBLNONVOFOLIO.Text)
                            RPT.SetParameterValue("CICLOESCOLAR", 0)
                            RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                            RPT.SetParameterValue("TIPOPAGO", PAGARADEUDOS.CBOTIPOPAGO.Text)
                            RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                            RPT.PrintOptions.PrinterName = "\\192.168.1.66\RECIBOS"
                            RPT.PrintToPrinter(1, False, 0, 0)

                            'CrystalReportViewer1.ReportSource = RPT
                        End If
                    End If
                End If

                If BANDERAPAGO = 2 Then
                    If BAND = 1 Then
                        If RECARGO = 1 Then
                            Dim RPT As New RECIBOCOLEGIATURA
                            RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
                            RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                            RPT.SetParameterValue("DIGITOSCUENTA", PAGOCOLEGIATURA.TXT4DIGITOSCUENTA.Text)
                            ' RPT.SetParameterValue("CONCEPTO", "ABONO")
                            RPT.SetParameterValue("DESCRIPCION", "ABONO CON RECARGO A " & PAGOCOLEGIATURA.CBOCOLEGIATURAS.Text & " " & TEXTO)
                            RPT.SetParameterValue("IMPORTE", PAGOCOLEGIATURA.LBLABONO.Text)
                            RPT.SetParameterValue("RESTA", PAGOCOLEGIATURA.LBLRESTA.Text)
                            RPT.SetParameterValue("TOTAL", PAGOCOLEGIATURA.LBLABONO.Text)
                            RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                            RPT.SetParameterValue("FOLIO", PAGOCOLEGIATURA.LBLNVOFOLIO.Text)
                            RPT.SetParameterValue("CICLOESCOLAR", 0)
                            RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                            RPT.SetParameterValue("TIPOPAGO", PAGOCOLEGIATURA.CBOTIPOPAGO.Text)
                            RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                            RPT.PrintOptions.PrinterName = "\\192.168.1.66\RECIBOS"
                            RPT.PrintToPrinter(1, False, 0, 0)

                            ' CrystalReportViewer1.ReportSource = RPT
                        End If

                        If RECARGO = 2 Then
                            Dim RPT As New RECIBOCOLEGIATURA
                            RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)

                            RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                            RPT.SetParameterValue("DIGITOSCUENTA", PAGOCOLEGIATURA.TXT4DIGITOSCUENTA.Text)
                            ' RPT.SetParameterValue("CONCEPTO", "ABONO")
                            RPT.SetParameterValue("DESCRIPCION", "ABONO A " & PAGOCOLEGIATURA.CBOCOLEGIATURAS.Text & " " & TEXTO)
                            RPT.SetParameterValue("IMPORTE", PAGOCOLEGIATURA.LBLABONO.Text)
                            RPT.SetParameterValue("RESTA", PAGOCOLEGIATURA.LBLRESTA.Text)
                            RPT.SetParameterValue("TOTAL", PAGOCOLEGIATURA.LBLABONO.Text)
                            RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                            RPT.SetParameterValue("FOLIO", PAGOCOLEGIATURA.LBLNVOFOLIO.Text)
                            RPT.SetParameterValue("CICLOESCOLAR", 0)
                            RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                            RPT.SetParameterValue("TIPOPAGO", PAGOCOLEGIATURA.CBOTIPOPAGO.Text)
                            RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                            RPT.PrintOptions.PrinterName = "\\192.168.1.66\RECIBOS"
                            RPT.PrintToPrinter(1, False, 0, 0)


                            'CrystalReportViewer1.ReportSource = RPT
                        End If

                    End If

                    If BAND = 2 Then
                        If RECARGO = 1 Then
                            Dim RPT As New RECIBOCOLEGIATURA
                            RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
                            RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                            RPT.SetParameterValue("DIGITOSCUENTA", PAGOCOLEGIATURA.TXT4DIGITOSCUENTA.Text)
                            ' RPT.SetParameterValue("CONCEPTO", "LIQUIDACION")
                            RPT.SetParameterValue("DESCRIPCION", "LIQUIDACION CON RECARGO DE " & PAGOCOLEGIATURA.CBOCOLEGIATURAS.Text & " " & TEXTO)
                            RPT.SetParameterValue("IMPORTE", PAGOCOLEGIATURA.LBLABONORECARG.Text)
                            RPT.SetParameterValue("RESTA", "0")
                            RPT.SetParameterValue("TOTAL", PAGOCOLEGIATURA.LBLABONORECARG.Text)
                            RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                            RPT.SetParameterValue("FOLIO", PAGOCOLEGIATURA.LBLNVOFOLIO.Text)
                            RPT.SetParameterValue("CICLOESCOLAR", 0)
                            RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                            RPT.SetParameterValue("TIPOPAGO", PAGOCOLEGIATURA.CBOTIPOPAGO.Text)
                            RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                            RPT.PrintOptions.PrinterName = "\\192.168.1.66\RECIBOS"
                            RPT.PrintToPrinter(1, False, 0, 0)


                            ' CrystalReportViewer1.ReportSource = RPT
                        End If

                        If RECARGO = 2 Then
                            Dim RPT As New RECIBOCOLEGIATURA
                            RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
                            RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                            RPT.SetParameterValue("DIGITOSCUENTA", PAGOCOLEGIATURA.TXT4DIGITOSCUENTA.Text)
                            ' RPT.SetParameterValue("CONCEPTO", "LIQUIDACION")
                            RPT.SetParameterValue("DESCRIPCION", "LIQUIDACION DE " & PAGOCOLEGIATURA.CBOCOLEGIATURAS.Text & " " & TEXTO)
                            RPT.SetParameterValue("IMPORTE", PAGOCOLEGIATURA.LBLMONTO.Text)
                            RPT.SetParameterValue("RESTA", "0")
                            RPT.SetParameterValue("TOTAL", PAGOCOLEGIATURA.LBLMONTO.Text)
                            RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                            RPT.SetParameterValue("FOLIO", PAGOCOLEGIATURA.LBLNVOFOLIO.Text)
                            RPT.SetParameterValue("CICLOESCOLAR", 0)
                            RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                            RPT.SetParameterValue("TIPOPAGO", PAGOCOLEGIATURA.CBOTIPOPAGO.Text)
                            RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                            RPT.PrintOptions.PrinterName = "\\192.168.1.66\RECIBOS"
                            RPT.PrintToPrinter(1, False, 0, 0)


                            'CrystalReportViewer1.ReportSource = RPT
                        End If
                    End If



                End If

                If BANDERAPAGO = 4 Then
                    Dim RPT As New RECIBOCOLEGIATURA
                    RPT.SetParameterValue("NOMBRE", INSCRIPCIONCNPROMOCION.CBOALUMNOS.Text)
                    RPT.SetParameterValue("NIVEL", INSCRIPCIONCNPROMOCION.EscolaridadLabel1.Text)
                    ' RPT.SetParameterValue("CONCEPTO", "LIQUIDACION")
                    RPT.SetParameterValue("DIGITOSCUENTA", "")
                    RPT.SetParameterValue("DESCRIPCION", "LIQUIDACION DE " & INSCRIPCIONCNPROMOCION.LBLDESCRIPCION.Text)
                    RPT.SetParameterValue("IMPORTE", INSCRIPCIONCNPROMOCION.LBLMONTO.Text)
                    RPT.SetParameterValue("RESTA", "0")
                    RPT.SetParameterValue("TOTAL", INSCRIPCIONCNPROMOCION.LBLMONTO.Text)
                    RPT.SetParameterValue("MATRICULA", INSCRIPCIONCNPROMOCION.CBOALUMNOS.SelectedValue)
                    RPT.SetParameterValue("FOLIO", INSCRIPCIONCNPROMOCION.LBLNVOFOLIO.Text)
                    RPT.SetParameterValue("CICLOESCOLAR", 0)
                    RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                    RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                    ' CrystalReportViewer1.ReportSource = RPT

                End If


            ElseIf IMPRESION = 2 Then
                Dim RPT As New RECIBODEPRODUCTOSTICKETS

                If BANDERAREPORTE2 = 1 Then

                    sSQL = "SELECT * FROM COBROPRODUCTOS WHERE NORECIBO = " & COBROSPRODUCTOS.LBLNVORECIBO.Text
                    Dim DA = New OleDb.OleDbDataAdapter(sSQL, conBuffer)
                    D1 = New DataTable
                    DA.Fill(D1)
                    If DataVacio(D1) = False Then
                        Dim x As Integer
                        For x = 0 To D1.Rows.Count - 1
                            dr1 = D1.Rows(x)

                            aParam(1) = "CONCEPTO" & x + 1
                            aParam(2) = "RESTA" & x + 1
                            aParam(3) = "IMPORTE" & x + 1
                            aParam(4) = "CANTIDAD" & x + 1

                            RPT.SetParameterValue(aParam(1), dr1("DESCRIPCION"))
                            RPT.SetParameterValue(aParam(2), dr1("RESTA"))
                            RPT.SetParameterValue(aParam(3), IIf(dr1("RESTA") = 0, dr1("TOTAL"), dr1("ABONO")))
                            RPT.SetParameterValue(aParam(4), dr1("CANTIDAD"))
                        Next

                        For x = x + 1 To 5
                            aParam(1) = "CONCEPTO" & x
                            aParam(2) = "RESTA" & x
                            aParam(3) = "IMPORTE" & x
                            aParam(4) = "CANTIDAD" & x

                            RPT.SetParameterValue(aParam(1), "")
                            RPT.SetParameterValue(aParam(2), 0)
                            RPT.SetParameterValue(aParam(3), 0)
                            RPT.SetParameterValue(aParam(4), 0)
                        Next
                    Else

                    End If

                    'If BANDERABONO1 = 1 Then
                    '    RPT.SetParameterValue("CONCEPTO1", COBROSPRODUCTOS.LBLCONCEPTO1.Text)
                    '    RPT.SetParameterValue("RESTA1", COBROSPRODUCTOS.LBLRESTA1.Text)
                    '    RPT.SetParameterValue("IMPORTE1", COBROSPRODUCTOS.LBLABONO1.Text)
                    '    RPT.SetParameterValue("CANTIDAD1", COBROSPRODUCTOS.LBLCANT1.Text)
                    'End If

                    'If BANDERALIQ1 = 1 Then
                    '    RPT.SetParameterValue("CONCEPTO1", COBROSPRODUCTOS.LBLCONCEPTO1.Text)
                    '    RPT.SetParameterValue("RESTA1", COBROSPRODUCTOS.LBLRESTA1.Text)
                    '    RPT.SetParameterValue("IMPORTE1", COBROSPRODUCTOS.LBLMONTO1.Text)
                    '    RPT.SetParameterValue("CANTIDAD1", COBROSPRODUCTOS.LBLCANT1.Text)
                    'End If


                    'If BANDERABONO2 = 1 Then
                    '    RPT.SetParameterValue("CONCEPTO2", COBROSPRODUCTOS.LBLCONCEPTO2.Text)
                    '    RPT.SetParameterValue("RESTA2", COBROSPRODUCTOS.LBLRESTA2.Text)
                    '    RPT.SetParameterValue("IMPORTE2", COBROSPRODUCTOS.LBLABONO2.Text)
                    '    RPT.SetParameterValue("CANTIDAD2", COBROSPRODUCTOS.LBLCANT2.Text)
                    'ElseIf BANDERALIQ2 = 1 Then
                    '    RPT.SetParameterValue("CONCEPTO2", COBROSPRODUCTOS.LBLCONCEPTO2.Text)
                    '    RPT.SetParameterValue("RESTA2", COBROSPRODUCTOS.LBLRESTA2.Text)
                    '    RPT.SetParameterValue("IMPORTE2", COBROSPRODUCTOS.LBLMONTO2.Text)
                    '    RPT.SetParameterValue("CANTIDAD2", COBROSPRODUCTOS.LBLCANT2.Text)
                    'Else
                    '    RPT.SetParameterValue("CONCEPTO2", COBROSPRODUCTOS.LBLCONCEPTO2.Text)
                    '    RPT.SetParameterValue("RESTA2", COBROSPRODUCTOS.LBLRESTA2.Text)
                    '    RPT.SetParameterValue("IMPORTE2", COBROSPRODUCTOS.LBLMONTO2.Text)
                    '    RPT.SetParameterValue("CANTIDAD2", COBROSPRODUCTOS.LBLCANT2.Text)
                    'End If

                    'If BANDERABONO3 = 1 Then
                    '    RPT.SetParameterValue("CONCEPTO3", COBROSPRODUCTOS.LBLCONCEPTO3.Text)
                    '    RPT.SetParameterValue("RESTA3", COBROSPRODUCTOS.LBLRESTA3.Text)
                    '    RPT.SetParameterValue("IMPORTE3", COBROSPRODUCTOS.LBLABONO3.Text)
                    '    RPT.SetParameterValue("CANTIDAD3", COBROSPRODUCTOS.LBLCANT3.Text)
                    'ElseIf BANDERALIQ3 = 1 Then
                    '    RPT.SetParameterValue("CONCEPTO3", COBROSPRODUCTOS.LBLCONCEPTO3.Text)
                    '    RPT.SetParameterValue("RESTA3", COBROSPRODUCTOS.LBLRESTA3.Text)
                    '    RPT.SetParameterValue("IMPORTE3", COBROSPRODUCTOS.LBLMONTO3.Text)
                    '    RPT.SetParameterValue("CANTIDAD3", COBROSPRODUCTOS.LBLCANT3.Text)
                    'Else
                    '    RPT.SetParameterValue("CONCEPTO3", COBROSPRODUCTOS.LBLCONCEPTO3.Text)
                    '    RPT.SetParameterValue("RESTA3", COBROSPRODUCTOS.LBLRESTA3.Text)
                    '    RPT.SetParameterValue("IMPORTE3", COBROSPRODUCTOS.LBLMONTO3.Text)
                    '    RPT.SetParameterValue("CANTIDAD3", COBROSPRODUCTOS.LBLCANT3.Text)
                    'End If

                    'If BANDERABONO4 = 1 Then
                    '    RPT.SetParameterValue("CONCEPTO4", COBROSPRODUCTOS.LBLCONCEPTO4.Text)
                    '    RPT.SetParameterValue("RESTA4", COBROSPRODUCTOS.LBLRESTA4.Text)
                    '    RPT.SetParameterValue("IMPORTE4", COBROSPRODUCTOS.LBLABONO4.Text)
                    '    RPT.SetParameterValue("CANTIDAD4", COBROSPRODUCTOS.LBLCANT4.Text)
                    'ElseIf BANDERALIQ4 = 1 Then
                    '    RPT.SetParameterValue("CONCEPTO4", COBROSPRODUCTOS.LBLCONCEPTO4.Text)
                    '    RPT.SetParameterValue("RESTA4", COBROSPRODUCTOS.LBLRESTA4.Text)
                    '    RPT.SetParameterValue("IMPORTE4", COBROSPRODUCTOS.LBLMONTO4.Text)
                    '    RPT.SetParameterValue("CANTIDAD4", COBROSPRODUCTOS.LBLCANT4.Text)
                    'Else
                    '    RPT.SetParameterValue("CONCEPTO4", COBROSPRODUCTOS.LBLCONCEPTO4.Text)
                    '    RPT.SetParameterValue("RESTA4", COBROSPRODUCTOS.LBLRESTA4.Text)
                    '    RPT.SetParameterValue("IMPORTE4", COBROSPRODUCTOS.LBLMONTO4.Text)
                    '    RPT.SetParameterValue("CANTIDAD4", COBROSPRODUCTOS.LBLCANT4.Text)
                    'End If

                    'If BANDERABONO5 = 1 Then
                    '    RPT.SetParameterValue("CONCEPTO5", COBROSPRODUCTOS.LBLCONCEPTO5.Text)
                    '    RPT.SetParameterValue("RESTA5", COBROSPRODUCTOS.LBLRESTA5.Text)
                    '    RPT.SetParameterValue("IMPORTE5", COBROSPRODUCTOS.LBLABONO5.Text)
                    '    RPT.SetParameterValue("CANTIDAD5", COBROSPRODUCTOS.LBLCANT5.Text)
                    'ElseIf BANDERALIQ5 = 1 Then
                    '    RPT.SetParameterValue("CONCEPTO5", COBROSPRODUCTOS.LBLCONCEPTO5.Text)
                    '    RPT.SetParameterValue("RESTA5", COBROSPRODUCTOS.LBLRESTA5.Text)
                    '    RPT.SetParameterValue("IMPORTE5", COBROSPRODUCTOS.LBLMONTO5.Text)
                    '    RPT.SetParameterValue("CANTIDAD5", COBROSPRODUCTOS.LBLCANT5.Text)
                    'Else
                    '    RPT.SetParameterValue("CONCEPTO5", COBROSPRODUCTOS.LBLCONCEPTO5.Text)
                    '    RPT.SetParameterValue("RESTA5", COBROSPRODUCTOS.LBLRESTA5.Text)
                    '    RPT.SetParameterValue("IMPORTE5", COBROSPRODUCTOS.LBLMONTO5.Text)
                    '    RPT.SetParameterValue("CANTIDAD5", COBROSPRODUCTOS.LBLCANT5.Text)
                    'End If

                    RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
                    RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                    RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                    RPT.SetParameterValue("FOLIO", COBROSPRODUCTOS.LBLNVORECIBO.Text)
                    RPT.SetParameterValue("TIPOPAGO", COBROSPRODUCTOS.CBOTIPOPAGO.Text)
                    RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                    RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                    RPT.PrintOptions.PrinterName = "\\192.168.1.66\RECIBOS"
                    RPT.PrintToPrinter(1, False, 0, 0)
                    ' CrystalReportViewer1.ReportSource = RPT

                ElseIf BANDERAREPORTE2 = 2 Then

                    If BAND = 1 Then
                        RPT.SetParameterValue("CONCEPTO1", "ABONO AL ADEUDO " & ADEUDOSPRODUCTOS.CBOPRODUCTOS.Text)
                        RPT.SetParameterValue("RESTA1", ADEUDOSPRODUCTOS.LBLNVARESTA.Text)
                        RPT.SetParameterValue("IMPORTE1", ADEUDOSPRODUCTOS.LBLNVOABONO.Text)
                        RPT.SetParameterValue("CANTIDAD1", 1)

                        RPT.SetParameterValue("CONCEPTO2", " ")
                        RPT.SetParameterValue("RESTA2", 0)
                        RPT.SetParameterValue("IMPORTE2", 0)
                        RPT.SetParameterValue("CANTIDAD2", 0)

                        RPT.SetParameterValue("CONCEPTO3", " ")
                        RPT.SetParameterValue("RESTA3", 0)
                        RPT.SetParameterValue("IMPORTE3", 0)
                        RPT.SetParameterValue("CANTIDAD3", 0)

                        RPT.SetParameterValue("CONCEPTO4", " ")
                        RPT.SetParameterValue("RESTA4", 0)
                        RPT.SetParameterValue("IMPORTE4", 0)
                        RPT.SetParameterValue("CANTIDAD4", 0)

                        RPT.SetParameterValue("CONCEPTO5", " ")
                        RPT.SetParameterValue("RESTA5", 0)
                        RPT.SetParameterValue("IMPORTE5", 0)
                        RPT.SetParameterValue("CANTIDAD5", 0)

                        RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
                        RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                        RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                        RPT.SetParameterValue("FOLIO", ADEUDOSPRODUCTOS.LBLNVORECIBO.Text)
                        RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                        RPT.SetParameterValue("TIPOPAGO", "EFECTIVO")
                        RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                        RPT.PrintOptions.PrinterName = "\\192.168.1.66\RECIBOS"
                        RPT.PrintToPrinter(1, False, 0, 0)
                        ' CrystalReportViewer1.ReportSource = RPT

                    ElseIf BAND = 2 Then

                        RPT.SetParameterValue("CONCEPTO1", "LIQUIDACION AL ADEUDO " & ADEUDOSPRODUCTOS.CBOPRODUCTOS.Text)
                        RPT.SetParameterValue("RESTA1", ADEUDOSPRODUCTOS.LBLNVARESTA.Text)
                        RPT.SetParameterValue("IMPORTE1", ADEUDOSPRODUCTOS.LBLRESTAANT.Text)
                        RPT.SetParameterValue("CANTIDAD1", 1)

                        RPT.SetParameterValue("CONCEPTO2", " ")
                        RPT.SetParameterValue("RESTA2", 0)
                        RPT.SetParameterValue("IMPORTE2", 0)
                        RPT.SetParameterValue("CANTIDAD2", 0)

                        RPT.SetParameterValue("CONCEPTO3", " ")
                        RPT.SetParameterValue("RESTA3", 0)
                        RPT.SetParameterValue("IMPORTE3", 0)
                        RPT.SetParameterValue("CANTIDAD3", 0)

                        RPT.SetParameterValue("CONCEPTO4", " ")
                        RPT.SetParameterValue("RESTA4", 0)
                        RPT.SetParameterValue("IMPORTE4", 0)
                        RPT.SetParameterValue("CANTIDAD4", 0)

                        RPT.SetParameterValue("CONCEPTO5", " ")
                        RPT.SetParameterValue("RESTA5", 0)
                        RPT.SetParameterValue("IMPORTE5", 0)
                        RPT.SetParameterValue("CANTIDAD5", 0)

                        RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
                        RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                        RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                        RPT.SetParameterValue("FOLIO", ADEUDOSPRODUCTOS.LBLNVORECIBO.Text)
                        RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                        RPT.SetParameterValue("TIPOPAGO", "EFECTIVO")
                        RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                        RPT.PrintOptions.PrinterName = "\\192.168.1.66\RECIBOS"
                        RPT.PrintToPrinter(1, False, 0, 0)
                        'CrystalReportViewer1.ReportSource = RPT
                    End If

                End If


            End If

            Me.Close()
        Catch ex As Exception
            MsgBox("Error en la impresion, favor de validar que la impresora seleccionada este instalada en el equipo", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CMDIMPRIMIRSHARP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDIMPRIMIRSHARP.Click
        Try
            If ImpresoraGLOBAL = "" Then
                MsgBox("NO tiene ninguna impresora seleccionada", MsgBoxStyle.Information, "iMPRESION")
                Exit Sub
            End If

            If IMPRESION = 1 Then
                If BANDERAPAGO = 1 Then
                    If BAND = 1 Then
                        Dim RPT As New RECIBOCOLEGIATURASHARP
                        RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
                        RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                        RPT.SetParameterValue("DIGITOSCUENTA", PAGODEINSCRIPCION.TXT4DIGITOSCUENTA.Text)
                        ' RPT.SetParameterValue("CONCEPTO", PAGODEINSCRIPCION.ComboBox1.SelectedValue)
                        RPT.SetParameterValue("DESCRIPCION", "ABONO A " & PAGODEINSCRIPCION.ComboBox1.Text & "CICLO " & PADRE.LBLCICLO.Text)
                        RPT.SetParameterValue("IMPORTE", PAGODEINSCRIPCION.LBLABONO.Text)
                        RPT.SetParameterValue("RESTA", PAGODEINSCRIPCION.LBLRESTA.Text)
                        RPT.SetParameterValue("TOTAL", PAGODEINSCRIPCION.LBLABONO.Text)
                        RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                        RPT.SetParameterValue("FOLIO", PAGODEINSCRIPCION.LBLNOFOLIOMAX.Text)
                        RPT.SetParameterValue("CICLOESCOLAR", 0)
                        RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                        RPT.SetParameterValue("TIPOPAGO", PAGODEINSCRIPCION.CBOTIPOPAGO.Text)
                        RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                        RPT.PrintOptions.PrinterName = ImpresoraGLOBAL
                        RPT.PrintToPrinter(1, False, 0, 0)

                        'CrystalReportViewer1.ReportSource = RPT
                    End If
                    If BAND = 2 Then
                        Dim RPT As New RECIBOCOLEGIATURASHARP
                        RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
                        RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                        RPT.SetParameterValue("DIGITOSCUENTA", PAGODEINSCRIPCION.TXT4DIGITOSCUENTA.Text)
                        ' RPT.SetParameterValue("CONCEPTO", PAGODEINSCRIPCION.ComboBox1.SelectedValue)
                        RPT.SetParameterValue("DESCRIPCION", "LIQUIDACION DE " & PAGODEINSCRIPCION.ComboBox1.Text & "CICLO " & PADRE.LBLCICLO.Text)
                        RPT.SetParameterValue("IMPORTE", PAGODEINSCRIPCION.LBLMONTO.Text)
                        RPT.SetParameterValue("RESTA", 0)
                        RPT.SetParameterValue("TOTAL", PAGODEINSCRIPCION.LBLMONTO.Text)
                        RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                        RPT.SetParameterValue("FOLIO", PAGODEINSCRIPCION.LBLNOFOLIOMAX.Text)
                        RPT.SetParameterValue("CICLOESCOLAR", 0)
                        RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                        RPT.SetParameterValue("TIPOPAGO", PAGODEINSCRIPCION.CBOTIPOPAGO.Text)
                        RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                        RPT.PrintOptions.PrinterName = ImpresoraGLOBAL
                        RPT.PrintToPrinter(1, False, 0, 0)

                        'CrystalReportViewer1.ReportSource = RPT
                    End If

                End If

                If BANDERAPAGO = 3 Then
                    If BAND = 1 Then
                        If RECARGO = 1 Then
                            Dim RPT As New RECIBOCOLEGIATURASHARP
                            RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
                            RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                            RPT.SetParameterValue("DIGITOSCUENTA", PAGARADEUDOS.TXT4DIGITOSCUENTA.Text)
                            ' RPT.SetParameterValue("CONCEPTO", "ABONO")
                            RPT.SetParameterValue("DESCRIPCION", "ABONO CON RECARGO DE " & PAGARADEUDOS.CBOADEUDOS.Text)
                            RPT.SetParameterValue("IMPORTE", PAGARADEUDOS.LBLNVOABONO.Text)
                            RPT.SetParameterValue("RESTA", PAGARADEUDOS.LBLABONORECARG.Text)
                            RPT.SetParameterValue("TOTAL", PAGARADEUDOS.LBLNVOABONO.Text)
                            RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                            RPT.SetParameterValue("FOLIO", PAGARADEUDOS.LBLNONVOFOLIO.Text)
                            RPT.SetParameterValue("CICLOESCOLAR", 0)
                            RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                            RPT.SetParameterValue("TIPOPAGO", PAGARADEUDOS.CBOTIPOPAGO.Text)
                            RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                            RPT.PrintOptions.PrinterName = ImpresoraGLOBAL
                            RPT.PrintToPrinter(1, False, 0, 0)

                            'CrystalReportViewer1.ReportSource = RPT
                        End If

                        If RECARGO = 2 Then
                            Dim RPT As New RECIBOCOLEGIATURASHARP
                            RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
                            RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                            RPT.SetParameterValue("DIGITOSCUENTA", PAGARADEUDOS.TXT4DIGITOSCUENTA.Text)
                            ' RPT.SetParameterValue("CONCEPTO", "ABONO")
                            RPT.SetParameterValue("DESCRIPCION", "ABONO A " & PAGARADEUDOS.CBOADEUDOS.Text)
                            RPT.SetParameterValue("IMPORTE", PAGARADEUDOS.LBLNVOABONO.Text)
                            RPT.SetParameterValue("RESTA", PAGARADEUDOS.LBLNVARESTA.Text)
                            RPT.SetParameterValue("TOTAL", PAGARADEUDOS.LBLNVOABONO.Text)
                            RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                            RPT.SetParameterValue("FOLIO", PAGARADEUDOS.LBLNONVOFOLIO.Text)
                            RPT.SetParameterValue("CICLOESCOLAR", 0)
                            RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                            RPT.SetParameterValue("TIPOPAGO", PAGARADEUDOS.CBOTIPOPAGO.Text)
                            RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                            RPT.PrintOptions.PrinterName = ImpresoraGLOBAL
                            RPT.PrintToPrinter(1, False, 0, 0)

                            'CrystalReportViewer1.ReportSource = RPT
                        End If

                    End If

                    If BAND = 2 Then
                        If RECARGO = 1 Then
                            Dim RPT As New RECIBOCOLEGIATURASHARP
                            RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
                            RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                            RPT.SetParameterValue("DIGITOSCUENTA", PAGARADEUDOS.TXT4DIGITOSCUENTA.Text)
                            ' RPT.SetParameterValue("CONCEPTO", "LIQUIDACION")
                            RPT.SetParameterValue("DESCRIPCION", "LIQUIDACION CON RECARGO DE " & PAGARADEUDOS.CBOADEUDOS.Text)
                            RPT.SetParameterValue("IMPORTE", PAGARADEUDOS.LBLABONORECARG.Text)
                            RPT.SetParameterValue("RESTA", "0")
                            RPT.SetParameterValue("TOTAL", PAGARADEUDOS.LBLABONORECARG.Text)
                            RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                            RPT.SetParameterValue("FOLIO", PAGARADEUDOS.LBLNONVOFOLIO.Text)
                            RPT.SetParameterValue("CICLOESCOLAR", 0)
                            RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                            RPT.SetParameterValue("TIPOPAGO", PAGARADEUDOS.CBOTIPOPAGO.Text)
                            RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                            RPT.PrintOptions.PrinterName = ImpresoraGLOBAL
                            RPT.PrintToPrinter(1, False, 0, 0)

                            ' CrystalReportViewer1.ReportSource = RPT
                        End If

                        If RECARGO = 2 Then
                            Dim RPT As New RECIBOCOLEGIATURASHARP
                            RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
                            RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                            RPT.SetParameterValue("DIGITOSCUENTA", PAGARADEUDOS.TXT4DIGITOSCUENTA.Text)
                            ' RPT.SetParameterValue("CONCEPTO", "LIQUIDACION")
                            RPT.SetParameterValue("DESCRIPCION", "LIQUIDACION DE " & PAGARADEUDOS.CBOADEUDOS.Text)
                            RPT.SetParameterValue("IMPORTE", PAGARADEUDOS.LBLRESTA.Text)
                            RPT.SetParameterValue("RESTA", "0")
                            RPT.SetParameterValue("TOTAL", PAGARADEUDOS.LBLRESTA.Text)
                            RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                            RPT.SetParameterValue("FOLIO", PAGARADEUDOS.LBLNONVOFOLIO.Text)
                            RPT.SetParameterValue("CICLOESCOLAR", 0)
                            RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                            RPT.SetParameterValue("TIPOPAGO", PAGARADEUDOS.CBOTIPOPAGO.Text)
                            RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                            RPT.PrintOptions.PrinterName = ImpresoraGLOBAL
                            RPT.PrintToPrinter(1, False, 0, 0)

                            'CrystalReportViewer1.ReportSource = RPT
                        End If
                    End If
                End If

                If BANDERAPAGO = 2 Then
                    If BAND = 1 Then
                        If RECARGO = 1 Then
                            Dim RPT As New RECIBOCOLEGIATURASHARP
                            RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
                            RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                            RPT.SetParameterValue("DIGITOSCUENTA", PAGOCOLEGIATURA.TXT4DIGITOSCUENTA.Text)
                            ' RPT.SetParameterValue("CONCEPTO", "ABONO")
                            RPT.SetParameterValue("DESCRIPCION", "ABONO CON RECARGO A " & PAGOCOLEGIATURA.CBOCOLEGIATURAS.Text & " " & TEXTO)
                            RPT.SetParameterValue("IMPORTE", PAGOCOLEGIATURA.LBLABONO.Text)
                            RPT.SetParameterValue("RESTA", PAGOCOLEGIATURA.LBLRESTA.Text)
                            RPT.SetParameterValue("TOTAL", PAGOCOLEGIATURA.LBLABONO.Text)
                            RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                            RPT.SetParameterValue("FOLIO", PAGOCOLEGIATURA.LBLNVOFOLIO.Text)
                            RPT.SetParameterValue("CICLOESCOLAR", 0)
                            RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                            RPT.SetParameterValue("TIPOPAGO", PAGOCOLEGIATURA.CBOTIPOPAGO.Text)
                            RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                            RPT.PrintOptions.PrinterName = ImpresoraGLOBAL
                            RPT.PrintToPrinter(1, False, 0, 0)

                            ' CrystalReportViewer1.ReportSource = RPT
                        End If

                        If RECARGO = 2 Then
                            Dim RPT As New RECIBOCOLEGIATURASHARP
                            RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
                            RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                            RPT.SetParameterValue("DIGITOSCUENTA", PAGOCOLEGIATURA.TXT4DIGITOSCUENTA.Text)
                            ' RPT.SetParameterValue("CONCEPTO", "ABONO")
                            RPT.SetParameterValue("DESCRIPCION", "ABONO A " & PAGOCOLEGIATURA.CBOCOLEGIATURAS.Text & " " & TEXTO)
                            RPT.SetParameterValue("IMPORTE", PAGOCOLEGIATURA.LBLABONO.Text)
                            RPT.SetParameterValue("RESTA", PAGOCOLEGIATURA.LBLRESTA.Text)
                            RPT.SetParameterValue("TOTAL", PAGOCOLEGIATURA.LBLABONO.Text)
                            RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                            RPT.SetParameterValue("FOLIO", PAGOCOLEGIATURA.LBLNVOFOLIO.Text)
                            RPT.SetParameterValue("CICLOESCOLAR", 0)
                            RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                            RPT.SetParameterValue("TIPOPAGO", PAGOCOLEGIATURA.CBOTIPOPAGO.Text)
                            RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                            RPT.PrintOptions.PrinterName = ImpresoraGLOBAL
                            RPT.PrintToPrinter(1, False, 0, 0)


                            'CrystalReportViewer1.ReportSource = RPT
                        End If

                    End If

                    If BAND = 2 Then
                        If RECARGO = 1 Then
                            Dim RPT As New RECIBOCOLEGIATURASHARP
                            RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
                            RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                            RPT.SetParameterValue("DIGITOSCUENTA", PAGOCOLEGIATURA.TXT4DIGITOSCUENTA.Text)
                            ' RPT.SetParameterValue("CONCEPTO", "LIQUIDACION")
                            RPT.SetParameterValue("DESCRIPCION", "LIQUIDACION CON RECARGO DE " & PAGOCOLEGIATURA.CBOCOLEGIATURAS.Text & " " & TEXTO)
                            RPT.SetParameterValue("IMPORTE", PAGOCOLEGIATURA.LBLABONORECARG.Text)
                            RPT.SetParameterValue("RESTA", "0")
                            RPT.SetParameterValue("TOTAL", PAGOCOLEGIATURA.LBLABONORECARG.Text)
                            RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                            RPT.SetParameterValue("FOLIO", PAGOCOLEGIATURA.LBLNVOFOLIO.Text)
                            RPT.SetParameterValue("CICLOESCOLAR", 0)
                            RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                            RPT.SetParameterValue("TIPOPAGO", PAGOCOLEGIATURA.CBOTIPOPAGO.Text)
                            RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                            RPT.PrintOptions.PrinterName = ImpresoraGLOBAL
                            RPT.PrintToPrinter(1, False, 0, 0)


                            ' CrystalReportViewer1.ReportSource = RPT
                        End If

                        If RECARGO = 2 Then
                            Dim RPT As New RECIBOCOLEGIATURASHARP
                            RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
                            RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                            RPT.SetParameterValue("DIGITOSCUENTA", PAGOCOLEGIATURA.TXT4DIGITOSCUENTA.Text)
                            ' RPT.SetParameterValue("CONCEPTO", "LIQUIDACION")
                            RPT.SetParameterValue("DESCRIPCION", "LIQUIDACION DE " & PAGOCOLEGIATURA.CBOCOLEGIATURAS.Text & " " & TEXTO)
                            RPT.SetParameterValue("IMPORTE", PAGOCOLEGIATURA.LBLMONTO.Text)
                            RPT.SetParameterValue("RESTA", "0")
                            RPT.SetParameterValue("TOTAL", PAGOCOLEGIATURA.LBLMONTO.Text)
                            RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                            RPT.SetParameterValue("FOLIO", PAGOCOLEGIATURA.LBLNVOFOLIO.Text)
                            RPT.SetParameterValue("CICLOESCOLAR", 0)
                            RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                            RPT.SetParameterValue("TIPOPAGO", PAGOCOLEGIATURA.CBOTIPOPAGO.Text)
                            RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                            RPT.PrintOptions.PrinterName = ImpresoraGLOBAL
                            RPT.PrintToPrinter(1, False, 0, 0)


                            'CrystalReportViewer1.ReportSource = RPT
                        End If
                    End If



                End If

                If BANDERAPAGO = 4 Then
                    Dim RPT As New RECIBOCOLEGIATURASHARP
                    RPT.SetParameterValue("NOMBRE", INSCRIPCIONCNPROMOCION.CBOALUMNOS.Text)
                    RPT.SetParameterValue("NIVEL", INSCRIPCIONCNPROMOCION.EscolaridadLabel1.Text)
                    ' RPT.SetParameterValue("CONCEPTO", "LIQUIDACION")
                    RPT.SetParameterValue("DIGITOSCUENTA", "")
                    RPT.SetParameterValue("DESCRIPCION", "LIQUIDACION DE " & INSCRIPCIONCNPROMOCION.LBLDESCRIPCION.Text)
                    RPT.SetParameterValue("IMPORTE", INSCRIPCIONCNPROMOCION.LBLMONTO.Text)
                    RPT.SetParameterValue("RESTA", "0")
                    RPT.SetParameterValue("TOTAL", INSCRIPCIONCNPROMOCION.LBLMONTO.Text)
                    RPT.SetParameterValue("MATRICULA", INSCRIPCIONCNPROMOCION.CBOALUMNOS.SelectedValue)
                    RPT.SetParameterValue("FOLIO", INSCRIPCIONCNPROMOCION.LBLNVOFOLIO.Text)
                    RPT.SetParameterValue("CICLOESCOLAR", 0)
                    RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                    RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                    ' CrystalReportViewer1.ReportSource = RPT
                    RPT.PrintOptions.PrinterName = ImpresoraGLOBAL
                    RPT.PrintToPrinter(1, False, 0, 0)
                End If
            ElseIf IMPRESION = 2 Then
                Dim RPT As New RECIBODEPRODUCTOS

                If BANDERAREPORTE2 = 1 Then

                    sSQL = "SELECT * FROM COBROPRODUCTOS WHERE NORECIBO = " & COBROSPRODUCTOS.LBLNVORECIBO.Text
                    Dim DA = New OleDb.OleDbDataAdapter(sSQL, conBuffer)
                    D1 = New DataTable
                    DA.Fill(D1)
                    If DataVacio(D1) = False Then
                        Dim x As Integer
                        For x = 0 To D1.Rows.Count - 1
                            dr1 = D1.Rows(x)

                            aParam(1) = "CONCEPTO" & x + 1
                            aParam(2) = "RESTA" & x + 1
                            aParam(3) = "IMPORTE" & x + 1
                            aParam(4) = "CANTIDAD" & x + 1

                            RPT.SetParameterValue(aParam(1), dr1("DESCRIPCION"))
                            RPT.SetParameterValue(aParam(2), dr1("RESTA"))
                            RPT.SetParameterValue(aParam(3), IIf(dr1("RESTA") = 0, dr1("TOTAL"), dr1("ABONO")))
                            RPT.SetParameterValue(aParam(4), dr1("CANTIDAD"))
                        Next

                        For x = x + 1 To 5
                            aParam(1) = "CONCEPTO" & x
                            aParam(2) = "RESTA" & x
                            aParam(3) = "IMPORTE" & x
                            aParam(4) = "CANTIDAD" & x

                            RPT.SetParameterValue(aParam(1), "")
                            RPT.SetParameterValue(aParam(2), 0)
                            RPT.SetParameterValue(aParam(3), 0)
                            RPT.SetParameterValue(aParam(4), 0)
                        Next

                    Else

                    End If


                    'If BANDERABONO1 = 1 Then
                    '    RPT.SetParameterValue("CONCEPTO1", COBROSPRODUCTOS.LBLCONCEPTO1.Text)
                    '    RPT.SetParameterValue("RESTA1", COBROSPRODUCTOS.LBLRESTA1.Text)
                    '    RPT.SetParameterValue("IMPORTE1", COBROSPRODUCTOS.LBLABONO1.Text)
                    '    RPT.SetParameterValue("CANTIDAD1", COBROSPRODUCTOS.LBLCANT1.Text)
                    'End If

                    'If BANDERALIQ1 = 1 Then
                    '    RPT.SetParameterValue("CONCEPTO1", COBROSPRODUCTOS.LBLCONCEPTO1.Text)
                    '    RPT.SetParameterValue("RESTA1", COBROSPRODUCTOS.LBLRESTA1.Text)
                    '    RPT.SetParameterValue("IMPORTE1", COBROSPRODUCTOS.LBLMONTO1.Text)
                    '    RPT.SetParameterValue("CANTIDAD1", COBROSPRODUCTOS.LBLCANT1.Text)
                    'End If


                    'If BANDERABONO2 = 1 Then
                    '    RPT.SetParameterValue("CONCEPTO2", COBROSPRODUCTOS.LBLCONCEPTO2.Text)
                    '    RPT.SetParameterValue("RESTA2", COBROSPRODUCTOS.LBLRESTA2.Text)
                    '    RPT.SetParameterValue("IMPORTE2", COBROSPRODUCTOS.LBLABONO2.Text)
                    '    RPT.SetParameterValue("CANTIDAD2", COBROSPRODUCTOS.LBLCANT2.Text)
                    'ElseIf BANDERALIQ2 = 1 Then
                    '    RPT.SetParameterValue("CONCEPTO2", COBROSPRODUCTOS.LBLCONCEPTO2.Text)
                    '    RPT.SetParameterValue("RESTA2", COBROSPRODUCTOS.LBLRESTA2.Text)
                    '    RPT.SetParameterValue("IMPORTE2", COBROSPRODUCTOS.LBLMONTO2.Text)
                    '    RPT.SetParameterValue("CANTIDAD2", COBROSPRODUCTOS.LBLCANT2.Text)
                    'Else
                    '    RPT.SetParameterValue("CONCEPTO2", COBROSPRODUCTOS.LBLCONCEPTO2.Text)
                    '    RPT.SetParameterValue("RESTA2", COBROSPRODUCTOS.LBLRESTA2.Text)
                    '    RPT.SetParameterValue("IMPORTE2", COBROSPRODUCTOS.LBLMONTO2.Text)
                    '    RPT.SetParameterValue("CANTIDAD2", COBROSPRODUCTOS.LBLCANT2.Text)
                    'End If

                    'If BANDERABONO3 = 1 Then
                    '    RPT.SetParameterValue("CONCEPTO3", COBROSPRODUCTOS.LBLCONCEPTO3.Text)
                    '    RPT.SetParameterValue("RESTA3", COBROSPRODUCTOS.LBLRESTA3.Text)
                    '    RPT.SetParameterValue("IMPORTE3", COBROSPRODUCTOS.LBLABONO3.Text)
                    '    RPT.SetParameterValue("CANTIDAD3", COBROSPRODUCTOS.LBLCANT3.Text)
                    'ElseIf BANDERALIQ3 = 1 Then
                    '    RPT.SetParameterValue("CONCEPTO3", COBROSPRODUCTOS.LBLCONCEPTO3.Text)
                    '    RPT.SetParameterValue("RESTA3", COBROSPRODUCTOS.LBLRESTA3.Text)
                    '    RPT.SetParameterValue("IMPORTE3", COBROSPRODUCTOS.LBLMONTO3.Text)
                    '    RPT.SetParameterValue("CANTIDAD3", COBROSPRODUCTOS.LBLCANT3.Text)
                    'Else
                    '    RPT.SetParameterValue("CONCEPTO3", COBROSPRODUCTOS.LBLCONCEPTO3.Text)
                    '    RPT.SetParameterValue("RESTA3", COBROSPRODUCTOS.LBLRESTA3.Text)
                    '    RPT.SetParameterValue("IMPORTE3", COBROSPRODUCTOS.LBLMONTO3.Text)
                    '    RPT.SetParameterValue("CANTIDAD3", COBROSPRODUCTOS.LBLCANT3.Text)
                    'End If

                    'If BANDERABONO4 = 1 Then
                    '    RPT.SetParameterValue("CONCEPTO4", COBROSPRODUCTOS.LBLCONCEPTO4.Text)
                    '    RPT.SetParameterValue("RESTA4", COBROSPRODUCTOS.LBLRESTA4.Text)
                    '    RPT.SetParameterValue("IMPORTE4", COBROSPRODUCTOS.LBLABONO4.Text)
                    '    RPT.SetParameterValue("CANTIDAD4", COBROSPRODUCTOS.LBLCANT4.Text)
                    'ElseIf BANDERALIQ4 = 1 Then
                    '    RPT.SetParameterValue("CONCEPTO4", COBROSPRODUCTOS.LBLCONCEPTO4.Text)
                    '    RPT.SetParameterValue("RESTA4", COBROSPRODUCTOS.LBLRESTA4.Text)
                    '    RPT.SetParameterValue("IMPORTE4", COBROSPRODUCTOS.LBLMONTO4.Text)
                    '    RPT.SetParameterValue("CANTIDAD4", COBROSPRODUCTOS.LBLCANT4.Text)
                    'Else
                    '    RPT.SetParameterValue("CONCEPTO4", COBROSPRODUCTOS.LBLCONCEPTO4.Text)
                    '    RPT.SetParameterValue("RESTA4", COBROSPRODUCTOS.LBLRESTA4.Text)
                    '    RPT.SetParameterValue("IMPORTE4", COBROSPRODUCTOS.LBLMONTO4.Text)
                    '    RPT.SetParameterValue("CANTIDAD4", COBROSPRODUCTOS.LBLCANT4.Text)
                    'End If

                    'If BANDERABONO5 = 1 Then
                    '    RPT.SetParameterValue("CONCEPTO5", COBROSPRODUCTOS.LBLCONCEPTO5.Text)
                    '    RPT.SetParameterValue("RESTA5", COBROSPRODUCTOS.LBLRESTA5.Text)
                    '    RPT.SetParameterValue("IMPORTE5", COBROSPRODUCTOS.LBLABONO5.Text)
                    '    RPT.SetParameterValue("CANTIDAD5", COBROSPRODUCTOS.LBLCANT5.Text)
                    'ElseIf BANDERALIQ5 = 1 Then
                    '    RPT.SetParameterValue("CONCEPTO5", COBROSPRODUCTOS.LBLCONCEPTO5.Text)
                    '    RPT.SetParameterValue("RESTA5", COBROSPRODUCTOS.LBLRESTA5.Text)
                    '    RPT.SetParameterValue("IMPORTE5", COBROSPRODUCTOS.LBLMONTO5.Text)
                    '    RPT.SetParameterValue("CANTIDAD5", COBROSPRODUCTOS.LBLCANT5.Text)
                    'Else
                    '    RPT.SetParameterValue("CONCEPTO5", COBROSPRODUCTOS.LBLCONCEPTO5.Text)
                    '    RPT.SetParameterValue("RESTA5", COBROSPRODUCTOS.LBLRESTA5.Text)
                    '    RPT.SetParameterValue("IMPORTE5", COBROSPRODUCTOS.LBLMONTO5.Text)
                    '    RPT.SetParameterValue("CANTIDAD5", COBROSPRODUCTOS.LBLCANT5.Text)
                    'End If

                    RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
                    RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                    RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                    RPT.SetParameterValue("FOLIO", COBROSPRODUCTOS.LBLNVORECIBO.Text)
                    RPT.SetParameterValue("TIPOPAGO", COBROSPRODUCTOS.CBOTIPOPAGO.Text)
                    RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                    RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                    RPT.PrintOptions.PrinterName = ImpresoraGLOBAL
                    RPT.PrintToPrinter(1, False, 0, 0)

                    'CrystalReportViewer1.ReportSource = RPT

                ElseIf BANDERAREPORTE2 = 2 Then

                    If BAND = 1 Then
                        RPT.SetParameterValue("CONCEPTO1", "ABONO AL ADEUDO " & ADEUDOSPRODUCTOS.CBOPRODUCTOS.Text)
                        RPT.SetParameterValue("RESTA1", ADEUDOSPRODUCTOS.LBLNVARESTA.Text)
                        RPT.SetParameterValue("IMPORTE1", ADEUDOSPRODUCTOS.LBLNVOABONO.Text)
                        RPT.SetParameterValue("CANTIDAD1", 1)

                        RPT.SetParameterValue("CONCEPTO2", " ")
                        RPT.SetParameterValue("RESTA2", 0)
                        RPT.SetParameterValue("IMPORTE2", 0)
                        RPT.SetParameterValue("CANTIDAD2", 0)

                        RPT.SetParameterValue("CONCEPTO3", " ")
                        RPT.SetParameterValue("RESTA3", 0)
                        RPT.SetParameterValue("IMPORTE3", 0)
                        RPT.SetParameterValue("CANTIDAD3", 0)

                        RPT.SetParameterValue("CONCEPTO4", " ")
                        RPT.SetParameterValue("RESTA4", 0)
                        RPT.SetParameterValue("IMPORTE4", 0)
                        RPT.SetParameterValue("CANTIDAD4", 0)

                        RPT.SetParameterValue("CONCEPTO5", " ")
                        RPT.SetParameterValue("RESTA5", 0)
                        RPT.SetParameterValue("IMPORTE5", 0)
                        RPT.SetParameterValue("CANTIDAD5", 0)

                        RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
                        RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                        RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                        RPT.SetParameterValue("FOLIO", ADEUDOSPRODUCTOS.LBLNVORECIBO.Text)
                        RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                        RPT.SetParameterValue("TIPOPAGO", "EFECTIVO")
                        RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                        RPT.PrintOptions.PrinterName = ImpresoraGLOBAL
                        RPT.PrintToPrinter(1, False, 0, 0)
                        'CrystalReportViewer1.ReportSource = RPT

                    ElseIf BAND = 2 Then

                        RPT.SetParameterValue("CONCEPTO1", "LIQUIDACION AL ADEUDO " & ADEUDOSPRODUCTOS.CBOPRODUCTOS.Text)
                        RPT.SetParameterValue("RESTA1", ADEUDOSPRODUCTOS.LBLNVARESTA.Text)
                        RPT.SetParameterValue("IMPORTE1", ADEUDOSPRODUCTOS.LBLRESTAANT.Text)
                        RPT.SetParameterValue("CANTIDAD1", 1)

                        RPT.SetParameterValue("CONCEPTO2", " ")
                        RPT.SetParameterValue("RESTA2", 0)
                        RPT.SetParameterValue("IMPORTE2", 0)
                        RPT.SetParameterValue("CANTIDAD2", 0)

                        RPT.SetParameterValue("CONCEPTO3", " ")
                        RPT.SetParameterValue("RESTA3", 0)
                        RPT.SetParameterValue("IMPORTE3", 0)
                        RPT.SetParameterValue("CANTIDAD3", 0)

                        RPT.SetParameterValue("CONCEPTO4", " ")
                        RPT.SetParameterValue("RESTA4", 0)
                        RPT.SetParameterValue("IMPORTE4", 0)
                        RPT.SetParameterValue("CANTIDAD4", 0)

                        RPT.SetParameterValue("CONCEPTO5", " ")
                        RPT.SetParameterValue("RESTA5", 0)
                        RPT.SetParameterValue("IMPORTE5", 0)
                        RPT.SetParameterValue("CANTIDAD5", 0)

                        RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
                        RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
                        RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
                        RPT.SetParameterValue("FOLIO", ADEUDOSPRODUCTOS.LBLNVORECIBO.Text)
                        RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
                        RPT.SetParameterValue("TIPOPAGO", "EFECTIVO")
                        RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
                        RPT.PrintOptions.PrinterName = ImpresoraGLOBAL
                        RPT.PrintToPrinter(1, False, 0, 0)
                        'CrystalReportViewer1.ReportSource = RPT
                    End If

                End If


            End If

            IMPRESION = 0
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
End Class