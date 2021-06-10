Public Class RECIBOCOLEGIATURAA

    Private Sub RECIBOCOLEGIATURAA_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("DESEA REALIZAR OTRO COBRO?", MsgBoxStyle.YesNo, "COBRANZA") = MsgBoxResult.Yes Then
            If BANDERAPAGO = 1 Then
                My.Forms.PAGODEINSCRIPCION.Show()
            End If
            If BANDERAPAGO = 2 Then
                My.Forms.PAGOCOLEGIATURA.Show()
                My.Forms.PAGOCOLEGIATURA.Enabled = True
            End If
            If BANDERAPAGO = 3 Then
                My.Forms.PAGARADEUDOS.Show()
            End If
        Else
            My.Forms.PAGODEINSCRIPCION.Close()
            My.Forms.PAGARADEUDOS.Close()
            My.Forms.PAGOCOLEGIATURA.Close()
            My.Forms.SELECCIONDEALUMNO.Close()
            My.Forms.INSCRIPCIONCNPROMOCION.Close()
        End If
        
    End Sub

    Private Sub RECIBOCOLEGIATURAA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                RPT.PrintOptions.PrinterName = "\\WIN-Q0V4IV8J5P2\RECIBOS"
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
                RPT.PrintOptions.PrinterName = "\\WIN-Q0V4IV8J5P2\RECIBOS"
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
                    RPT.PrintOptions.PrinterName = "\\WIN-Q0V4IV8J5P2\RECIBOS"
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
                    RPT.PrintOptions.PrinterName = "\\WIN-Q0V4IV8J5P2\RECIBOS"
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
                    RPT.PrintOptions.PrinterName = "\\WIN-Q0V4IV8J5P2\RECIBOS"
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
                    RPT.PrintOptions.PrinterName = "\\WIN-Q0V4IV8J5P2\RECIBOS"
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
                    RPT.PrintOptions.PrinterName = "\\WIN-Q0V4IV8J5P2\RECIBOS"
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
                    RPT.PrintOptions.PrinterName = "\\WIN-Q0V4IV8J5P2\RECIBOS"
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
                    RPT.PrintOptions.PrinterName = "\\WIN-Q0V4IV8J5P2\RECIBOS"
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
                    RPT.PrintOptions.PrinterName = "\\WIN-Q0V4IV8J5P2\RECIBOS"
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
            CrystalReportViewer1.ReportSource = RPT

        End If

    End Sub
End Class