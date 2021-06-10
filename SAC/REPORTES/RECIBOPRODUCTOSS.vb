Public Class RECIBOPRODUCTOSS

    Private Sub RECIBOPRODUCTOSS_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Forms.COBROSPRODUCTOS.Close()
        My.Forms.ADEUDOSPRODUCTOS.Close()
        My.Forms.PAGODEINSCRIPCION.Close()
        My.Forms.PAGARADEUDOS.Close()
        My.Forms.PAGOCOLEGIATURA.Close()
        My.Forms.SELECCIONDEALUMNO.Close()
        My.Forms.INSCRIPCIONCNPROMOCION.Close()
    End Sub

    Private Sub RECIBOPRODUCTOSS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim RPT As New RECIBODEPRODUCTOS

        If BANDERAREPORTE2 = 1 Then

            If BANDERABONO1 = 1 Then
                RPT.SetParameterValue("CONCEPTO1", COBROSPRODUCTOS.LBLCONCEPTO1.Text)
                RPT.SetParameterValue("RESTA1", COBROSPRODUCTOS.LBLRESTA1.Text)
                RPT.SetParameterValue("IMPORTE1", COBROSPRODUCTOS.LBLABONO1.Text)
                RPT.SetParameterValue("CANTIDAD1", COBROSPRODUCTOS.LBLCANT1.Text)
            End If

            If BANDERALIQ1 = 1 Then
                RPT.SetParameterValue("CONCEPTO1", COBROSPRODUCTOS.LBLCONCEPTO1.Text)
                RPT.SetParameterValue("RESTA1", COBROSPRODUCTOS.LBLRESTA1.Text)
                RPT.SetParameterValue("IMPORTE1", COBROSPRODUCTOS.LBLMONTO1.Text)
                RPT.SetParameterValue("CANTIDAD1", COBROSPRODUCTOS.LBLCANT1.Text)
            End If


            If BANDERABONO2 = 1 Then
                RPT.SetParameterValue("CONCEPTO2", COBROSPRODUCTOS.LBLCONCEPTO2.Text)
                RPT.SetParameterValue("RESTA2", COBROSPRODUCTOS.LBLRESTA2.Text)
                RPT.SetParameterValue("IMPORTE2", COBROSPRODUCTOS.LBLABONO2.Text)
                RPT.SetParameterValue("CANTIDAD2", COBROSPRODUCTOS.LBLCANT2.Text)
            ElseIf BANDERALIQ2 = 1 Then
                RPT.SetParameterValue("CONCEPTO2", COBROSPRODUCTOS.LBLCONCEPTO2.Text)
                RPT.SetParameterValue("RESTA2", COBROSPRODUCTOS.LBLRESTA2.Text)
                RPT.SetParameterValue("IMPORTE2", COBROSPRODUCTOS.LBLMONTO2.Text)
                RPT.SetParameterValue("CANTIDAD2", COBROSPRODUCTOS.LBLCANT2.Text)
            Else
                RPT.SetParameterValue("CONCEPTO2", COBROSPRODUCTOS.LBLCONCEPTO2.Text)
                RPT.SetParameterValue("RESTA2", COBROSPRODUCTOS.LBLRESTA2.Text)
                RPT.SetParameterValue("IMPORTE2", COBROSPRODUCTOS.LBLMONTO2.Text)
                RPT.SetParameterValue("CANTIDAD2", COBROSPRODUCTOS.LBLCANT2.Text)
            End If

            If BANDERABONO3 = 1 Then
                RPT.SetParameterValue("CONCEPTO3", COBROSPRODUCTOS.LBLCONCEPTO3.Text)
                RPT.SetParameterValue("RESTA3", COBROSPRODUCTOS.LBLRESTA3.Text)
                RPT.SetParameterValue("IMPORTE3", COBROSPRODUCTOS.LBLABONO3.Text)
                RPT.SetParameterValue("CANTIDAD3", COBROSPRODUCTOS.LBLCANT3.Text)
            ElseIf BANDERALIQ3 = 1 Then
                RPT.SetParameterValue("CONCEPTO3", COBROSPRODUCTOS.LBLCONCEPTO3.Text)
                RPT.SetParameterValue("RESTA3", COBROSPRODUCTOS.LBLRESTA3.Text)
                RPT.SetParameterValue("IMPORTE3", COBROSPRODUCTOS.LBLMONTO3.Text)
                RPT.SetParameterValue("CANTIDAD3", COBROSPRODUCTOS.LBLCANT3.Text)
            Else
                RPT.SetParameterValue("CONCEPTO3", COBROSPRODUCTOS.LBLCONCEPTO3.Text)
                RPT.SetParameterValue("RESTA3", COBROSPRODUCTOS.LBLRESTA3.Text)
                RPT.SetParameterValue("IMPORTE3", COBROSPRODUCTOS.LBLMONTO3.Text)
                RPT.SetParameterValue("CANTIDAD3", COBROSPRODUCTOS.LBLCANT3.Text)
            End If

            If BANDERABONO4 = 1 Then
                RPT.SetParameterValue("CONCEPTO4", COBROSPRODUCTOS.LBLCONCEPTO4.Text)
                RPT.SetParameterValue("RESTA4", COBROSPRODUCTOS.LBLRESTA4.Text)
                RPT.SetParameterValue("IMPORTE4", COBROSPRODUCTOS.LBLABONO4.Text)
                RPT.SetParameterValue("CANTIDAD4", COBROSPRODUCTOS.LBLCANT4.Text)
            ElseIf BANDERALIQ4 = 1 Then
                RPT.SetParameterValue("CONCEPTO4", COBROSPRODUCTOS.LBLCONCEPTO4.Text)
                RPT.SetParameterValue("RESTA4", COBROSPRODUCTOS.LBLRESTA4.Text)
                RPT.SetParameterValue("IMPORTE4", COBROSPRODUCTOS.LBLMONTO4.Text)
                RPT.SetParameterValue("CANTIDAD4", COBROSPRODUCTOS.LBLCANT4.Text)
            Else
                RPT.SetParameterValue("CONCEPTO4", COBROSPRODUCTOS.LBLCONCEPTO4.Text)
                RPT.SetParameterValue("RESTA4", COBROSPRODUCTOS.LBLRESTA4.Text)
                RPT.SetParameterValue("IMPORTE4", COBROSPRODUCTOS.LBLMONTO4.Text)
                RPT.SetParameterValue("CANTIDAD4", COBROSPRODUCTOS.LBLCANT4.Text)
            End If

            If BANDERABONO5 = 1 Then
                RPT.SetParameterValue("CONCEPTO5", COBROSPRODUCTOS.LBLCONCEPTO5.Text)
                RPT.SetParameterValue("RESTA5", COBROSPRODUCTOS.LBLRESTA5.Text)
                RPT.SetParameterValue("IMPORTE5", COBROSPRODUCTOS.LBLABONO5.Text)
                RPT.SetParameterValue("CANTIDAD5", COBROSPRODUCTOS.LBLCANT5.Text)
            ElseIf BANDERALIQ5 = 1 Then
                RPT.SetParameterValue("CONCEPTO5", COBROSPRODUCTOS.LBLCONCEPTO5.Text)
                RPT.SetParameterValue("RESTA5", COBROSPRODUCTOS.LBLRESTA5.Text)
                RPT.SetParameterValue("IMPORTE5", COBROSPRODUCTOS.LBLMONTO5.Text)
                RPT.SetParameterValue("CANTIDAD5", COBROSPRODUCTOS.LBLCANT5.Text)
            Else
                RPT.SetParameterValue("CONCEPTO5", COBROSPRODUCTOS.LBLCONCEPTO5.Text)
                RPT.SetParameterValue("RESTA5", COBROSPRODUCTOS.LBLRESTA5.Text)
                RPT.SetParameterValue("IMPORTE5", COBROSPRODUCTOS.LBLMONTO5.Text)
                RPT.SetParameterValue("CANTIDAD5", COBROSPRODUCTOS.LBLCANT5.Text)
            End If

            RPT.SetParameterValue("NOMBRE", SELECCIONDEALUMNO.CBOALUMNO.Text)
            RPT.SetParameterValue("NIVEL", SELECCIONDEALUMNO.CBOESCOLARIDAD.Text)
            RPT.SetParameterValue("MATRICULA", SELECCIONDEALUMNO.CBOALUMNO.SelectedValue)
            RPT.SetParameterValue("FOLIO", COBROSPRODUCTOS.LBLNVORECIBO.Text)
            RPT.SetParameterValue("TIPOPAGO", COBROSPRODUCTOS.CBOTIPOPAGO.Text)
            RPT.SetParameterValue("CICLO", PADRE.LBLCICLO.Text)
            RPT.SetParameterValue("NOMCAJERO", Intro.NomcomLabel1.Text)
            CrystalReportViewer1.ReportSource = RPT

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
                CrystalReportViewer1.ReportSource = RPT

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
                CrystalReportViewer1.ReportSource = RPT
            End If

        End If

      


    End Sub

End Class