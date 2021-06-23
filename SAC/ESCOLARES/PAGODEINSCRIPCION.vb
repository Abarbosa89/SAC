Imports System.Data.SqlClient
Imports System.Data
Public Class PAGODEINSCRIPCION
    Dim ABONO As Decimal
    Dim PORCE As Decimal
    Dim BECA As Decimal = 0
    Dim BECASEP As Decimal = 0


    Private Sub PAGODEINSCRIPCION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'LBLIDPRODUC.Hide()
        'LBLMONTOBASE.Hide()
        'LBLNOFOLIOMAX.Hide()
        'LBLNONUEVOFOLIO.Hide()
        'LBLINSABON.Hide()
        'LBLINSCLIQ.Hide()

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
        'TODO: This line of code loads data into the 'SACDataSet.TIPOSDEPAGO' table. You can move, or remove it, as needed.
        Me.TIPOSDEPAGOTableAdapter.Fill(Me.SACDataSet.TIPOSDEPAGO)
        BAND = 0
        LBLABONO.Text = 0

        Try
            Me.NUEVORECIBOFOLIOFACTURATableAdapter.Fill(Me.SACDataSet.NUEVORECIBOFOLIOFACTURA, New System.Nullable(Of Integer)(CType(BANDERARECFOLFAC, Integer)))
            LBLNONUEVOFOLIO.Text = CInt(LBLNOFOLIOMAX.Text) + 1
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Try
            Me.COBROINSCRIPCIONTableAdapter.Fill(Me.SACDataSet.COBROINSCRIPCION, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.LBLIDNIVEL.Text, Integer)), New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Try
            Me.INSCRIPCIONABONADATableAdapter.Fill(Me.SACDataSet.INSCRIPCIONABONADA, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.LBLMATRI.Text, Integer)), New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))
            Me.INSCRIPCIONLIQUIDADATableAdapter.Fill(Me.SACDataSet.INSCRIPCIONLIQUIDADA, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.LBLMATRI.Text, Integer)), New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))

            If INSCRIPCIONABONADABindingSource.Count = 0 Then
                LBLINSABON.Text = 0
            End If
            If INSCRIPCIONLIQUIDADABindingSource.Count = 0 Then
                LBLINSCLIQ.Text = 0
            End If

            If SELECCIONDEALUMNO.CBBECAINSC.Checked = True Then
                BECA = CDec(LBLMONTOBASE.Text) * CDec(SELECCIONDEALUMNO.LBLPORCENINSC.Text)
                LBLSCOPORBECA.Text = CDec(LBLMONTOBASE.Text) - BECA
                LBLSCOPORBECA.Text = FormatCurrency(LBLSCOPORBECA.Text)
                LBLDESCONBECA.Show()
                LBLSCOPORBECA.Show()
                LBLMONTO.Text = LBLSCOPORBECA.Text
                LBLMONTO.Text = FormatCurrency(LBLMONTO.Text)
                CMDABONO.Visible = True
                CMDLIQUIDAR.Visible = True
                CMDIMPRIMIR.Visible = True
                ' ElseIf SELECCIONDEALUMNO.CBBECASEP.Checked = True Then
                ' BECASEP = CDec(LBLMONTOBASE.Text) * CDec(SELECCIONDEALUMNO.LBLPORCBECASEP.Text)
                ' LBLSCOPORBECA.Text = CDec(LBLMONTOBASE.Text) - BECASEP
                ' LBLSCOPORBECA.Text = FormatCurrency(LBLSCOPORBECA.Text)
                ' LBLDESCONBECA.Show()
                ' LBLSCOPORBECA.Show()
                ' LBLMONTO.Text = LBLSCOPORBECA.Text
                ' LBLMONTO.Text = FormatCurrency(LBLMONTO.Text)
                ' CMDABONO.Visible = True
                ' CMDLIQUIDAR.Visible = True
                ' CMDIMPRIMIR.Visible = True
            Else
                CMDABONO.Visible = True
                CMDLIQUIDAR.Visible = True
                CMDIMPRIMIR.Visible = True
                LBLMONTO.Text = LBLMONTOBASE.Text
                LBLMONTO.Text = FormatCurrency(LBLMONTO.Text)
            End If
            If LBLINSABON.Text = 1 Then
                MsgBox("YA TIENE LA INSCRIPCION ABONADA, PORFAVOR PROCEDA A ADEUDOS PARA ABONAR O LIQUIDAR", MsgBoxStyle.Information, "INSCRIPCION")
                CMDABONO.Enabled = False
                CMDLIQUIDAR.Enabled = False
                CMDIMPRIMIR.Enabled = False
            End If
            If LBLINSCLIQ.Text = 1 Then
                MsgBox("YA TIENE LA INSCRIPCION LIQUIDADA", MsgBoxStyle.Information, "INSCRIPCION")
                CMDABONO.Enabled = False
                CMDLIQUIDAR.Enabled = False
                CMDIMPRIMIR.Enabled = False
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CMDABONO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDABONO.Click
        Try
            BAND = 1
            ABONO = InputBox("CUANTO ES LO QUE DESEA ABONAR?", "ABONO", 0)
            If ABONO > CDec(LBLMONTOBASE.Text) Then
                MsgBox("EL ABONO ES MAYOR QUE LA DIFERENCIA", MsgBoxStyle.Exclamation, "AVISO")
            ElseIf SELECCIONDEALUMNO.CBBECAINSC.Checked = True Then
                LBLABONO.Text = ABONO
                LBLRESTA.Text = CDec(LBLMONTO.Text) - CDec(LBLABONO.Text)
                LBLRESTA.Text = FormatCurrency(LBLRESTA.Text)
                LBLABONO.Text = FormatCurrency(LBLABONO.Text)

            Else
                LBLABONO.Text = ABONO
                LBLRESTA.Text = CDec(LBLMONTOBASE.Text) - CDec(LBLABONO.Text)
                LBLRESTA.Text = FormatCurrency(LBLRESTA.Text)
                LBLABONO.Text = FormatCurrency(LBLABONO.Text)
            End If
        Catch
        End Try

    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click

        Me.Close()

    End Sub

    Private Sub CMDLIQUIDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDLIQUIDAR.Click
        BAND = 2
        If TXT4DIGITOSCUENTA.Text = "" Then
            MsgBox("EL PADRE DE FAMILIA REQUIERE FACTURA POR FAVOR INGRESE LOS DIGITOS DE LA CUENTA PARA CONTINUAR", MsgBoxStyle.Information, "ATENCION")
            TXT4DIGITOSCUENTA.Focus()
        Else

            LBLABONO.Text = 0
            LBLRESTA.Text = 0
            LBLABONO.Text = FormatCurrency(LBLABONO.Text)
            LBLRESTA.Text = FormatCurrency(LBLRESTA.Text)
            LBL4DIGITOSCUENTA.Visible = True
            TXT4DIGITOSCUENTA.Visible = True

            CMDLIQUIDAR.Enabled = False
        End If

    End Sub

    Private Sub CMDIMPRIMIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDIMPRIMIR.Click
        Try
            Dim com As SqlCommand = con.CreateCommand()
            IMPRESION = 0
            If BAND = 1 Then

                    con.Open()
                    com = New SqlCommand("MOVIMIENTOCOLEGIATURA", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@NOMOV", SqlDbType.Int).Value = 1
                    com.Parameters.Add("@RESTA", SqlDbType.Money).Value = LBLRESTA.Text
                    com.Parameters.Add("@TOTAL", SqlDbType.Money).Value = LBLABONO.Text
                    com.Parameters.Add("@ABONO", SqlDbType.Money).Value = LBLABONO.Text
                com.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = "ABONO A " & ComboBox1.Text & "CICLO " & PADRE.LBLCICLO.Text
                    com.Parameters.Add("@NOFACTURA", SqlDbType.Int).Value = 0
                    com.Parameters.Add("@NORECIBO", SqlDbType.Int).Value = 0
                    com.Parameters.Add("@NOFOLIO", SqlDbType.Int).Value = LBLNONUEVOFOLIO.Text
                    com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                    com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
                    com.Parameters.Add("@IDPRODUC", SqlDbType.Int).Value = LBLIDPRODUC.Text
                    com.Parameters.Add("@IDTIPOPAGO", SqlDbType.Int).Value = CBOTIPOPAGO.SelectedValue
                com.Parameters.Add("@FACTURA", SqlDbType.Bit).Value = 0
                com.Parameters.Add("@DIGITOSCUENTA", SqlDbType.Int).Value = 0
                com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                    com.ExecuteNonQuery()
                    con.Close()

                    con.Open()
                    com = New SqlCommand("REGISTRODEACTIVIDAD", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                    com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "ABONO DE INSCRIPCION CON FOLIO " & LBLNONUEVOFOLIO.Text
                    com.ExecuteNonQuery()
                    con.Close()
                IMPRESION = 1

                My.Forms.VENTANAEMERGENTE.ShowDialog()
                Me.Close()

                End If


            If BAND = 2 Then
               

                    con.Open()
                    com = New SqlCommand("MOVIMIENTOCOLEGIATURA", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@NOMOV", SqlDbType.Int).Value = 2
                    com.Parameters.Add("@RESTA", SqlDbType.Money).Value = 0
                com.Parameters.Add("@TOTAL", SqlDbType.Money).Value = LBLMONTO.Text
                    com.Parameters.Add("@ABONO", SqlDbType.Money).Value = 0
                com.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = "LIQUIDACION DE " & ComboBox1.Text & "CICLO " & PADRE.LBLCICLO.Text
                    com.Parameters.Add("@NOFACTURA", SqlDbType.Int).Value = 0
                    com.Parameters.Add("@NORECIBO", SqlDbType.Int).Value = 0
                    com.Parameters.Add("@NOFOLIO", SqlDbType.Int).Value = LBLNONUEVOFOLIO.Text
                    com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                    com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
                    com.Parameters.Add("@IDPRODUC", SqlDbType.Int).Value = LBLIDPRODUC.Text
                    com.Parameters.Add("@IDTIPOPAGO", SqlDbType.Int).Value = CBOTIPOPAGO.SelectedValue
                com.Parameters.Add("@FACTURA", SqlDbType.Bit).Value = SELECCIONDEALUMNO.CBREQFACTURA.Checked
                com.Parameters.Add("@DIGITOSCUENTA", SqlDbType.Int).Value = TXT4DIGITOSCUENTA.Text
                com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                    com.ExecuteNonQuery()
                    con.Close()

                    con.Open()
                    com = New SqlCommand("REGISTRODEACTIVIDAD", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                    com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "LIQUIDACION DE INSCRIPCION CON FOLIO " & LBLNONUEVOFOLIO.Text
                    com.ExecuteNonQuery()
                con.Close()
                IMPRESION = 1
                My.Forms.VENTANAEMERGENTE.ShowDialog()
                Me.Close()

                End If

        Catch
            con.Close()
            MsgBox("PONGANSE EN CONTACTO CON SU ADMINISTRADOR")
        End Try

    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.COBROINSCRIPCIONTableAdapter.Fill(Me.SACDataSet.COBROINSCRIPCION, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.LBLIDNIVEL.Text, Integer)), New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class