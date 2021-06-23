Imports System.Data.SqlClient
Imports System.Data
Public Class COBROSPRODUCTOS
    Dim ABONO As Decimal = 0
    Dim CANTIDAD As Integer = 1
    Dim com As SqlCommand = con.CreateCommand()
    Dim Comando As New OleDb.OleDbCommand
    Dim sSQL As String = ""
    Dim DataSet As DataSet
    Dim registro As Integer
    Dim PrecioT As Decimal
    Dim CantIngre As Decimal




    Private Sub COBROSPRODUCTOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SACDataSet.TIPOSDEPAGO' table. You can move, or remove it, as needed.
        Me.TIPOSDEPAGOTableAdapter.Fill(Me.SACDataSet.TIPOSDEPAGO)
        CONTADOR = 0
        LBLCONCEPTOBASE.Hide()
        LBLMONTOBASE.Hide()
        LBLNORECIBO.Hide()
        LBLNVORECIBO.Hide()
        LBLIDPRODUC.Hide()
        LBLDESCRIPCION.Hide()
        LBLLIQUIDADO.Hide()
        LBLABONADO.Hide()
        LBLIDPRODUC1.Hide()
        LBLIDPRODUC2.Hide()
        LBLIDPRODUC3.Hide()
        LBLIDPRODUC4.Hide()
        LBLIDPRODUC5.Hide()

        Try

            Me.NUEVORECIBOFOLIOFACTURATableAdapter.Fill(Me.SACDataSet.NUEVORECIBOFOLIOFACTURA, New System.Nullable(Of Integer)(CType(2, Integer)))
            LBLNVORECIBO.Text = CInt(LBLNORECIBO.Text) + 1

            Me.COBROSDEPRODUCTOSTableAdapter.Fill(Me.SACDataSet.COBROSDEPRODUCTOS, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.LBLIDNIVEL.Text, Integer)), New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.LBLIDGRADO.Text, Integer)), SELECCIONDEALUMNO.LBLSEXO.Text, New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))


            sSQL = "DELETE FROM CobroProductos"
            Comando.CommandText = sSQL
            Comando.Connection = conBuffer
            Comando.ExecuteNonQuery()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click

        Try

            BAND = 2
            If CONTADOR >= 5 Then
                MsgBox("Solo se permiten 5 Productos para el Ticket", MsgBoxStyle.Information, Me.Text)
                Exit Sub
            Else
                sSQL = "INSERT INTO CobroProductos (RESTA,TOTAL,ABONO,DESCRIPCION,NOFACTURA,NORECIBO,NOFOLIO,IDUS,MATRI,IDPRODUC,IDTIPOPAGO,FACTURA,DIGITOSCUENTA,IDCICLO) " & _
                       "VALUES (0," & CDec(CANTIDAD * CDec(LBLMONTOBASE.Text)) & ",0,'" & LBLDESCRIPCION.Text & "',0," & LBLNVORECIBO.Text & ",0," & Intro.IdusLabel1.Text & "," & SELECCIONDEALUMNO.CBOALUMNO.SelectedValue & "," & CBOPRODUCTOS.SelectedValue & "," & CBOTIPOPAGO.SelectedValue & ",' ',' '," & PADRE.LBLIDCICLO.Text & ")"
                Comando.CommandText = sSQL
                Comando.Connection = conBuffer
                Comando.ExecuteNonQuery()
                Comando.Dispose()
                CONTADOR = CONTADOR + 1
            End If

            Dim DataTable = New OleDb.OleDbDataAdapter("SELECT NOMOV,TOTAL,RESTA,ABONO,DESCRIPCION,MATRI FROM CobroProductos", conBuffer)
            'DataTable.SelectCommand.CommandText = "SELECT * FROM CobroProductos"
            'DataTable.SelectCommand.Connection = conBuffer
            'DataTable.SelectCommand.ExecuteNonQuery()
            Dim DataSet As DataSet
            DataSet = New DataSet
            DataTable.Fill(DataSet)
            DataGridView1.DataSource = DataSet.Tables(0).DefaultView
            DataGridView1.Columns(5).HeaderText = "MATRICULA"
            DataGridView1.Columns(1).DefaultCellStyle.Format = "C2"
            DataGridView1.Columns(2).DefaultCellStyle.Format = "C2"
            DataGridView1.Columns(3).DefaultCellStyle.Format = "C2"

            'If CONTADOR = 1 Then
            '    If CBOPRODUCTOS.SelectedValue = 64 Then
            '        LBLCANT1.Text = CANTIDAD
            '        LBLMONTO1.Text = CANTIDAD * CDec(LBLMONTOBASE.Text)
            '        LBLMONTO1.Text = FormatCurrency(LBLMONTO1.Text)
            '        LBLCONCEPTO1.Text = LBLDESCRIPCION.Text
            '        LBLIDPRODUC1.Text = LBLIDPRODUC.Text
            '        LBABONAR1.Visible = True
            '        CBOPRODUCTOS.Enabled = False
            '    ElseIf CBOPRODUCTOS.SelectedValue = 70 Then
            '        LBLCANT1.Text = CANTIDAD
            '        LBLCONCEPTO1.Text = LBLDESCRIPCION.Text
            '        LBLMONTO1.Text = CANTIDAD * CDec(LBLMONTOBASE.Text)
            '        LBLMONTO1.Text = FormatCurrency(LBLMONTO1.Text)
            '        LBLIDPRODUC1.Text = LBLIDPRODUC.Text
            '        LBABONAR1.Visible = True
            '        CBOPRODUCTOS.Enabled = False
            '    ElseIf CBOPRODUCTOS.SelectedValue = 63 Then
            '        LBLCANT1.Text = CANTIDAD
            '        LBLCONCEPTO1.Text = LBLDESCRIPCION.Text
            '        LBLMONTO1.Text = CANTIDAD * CDec(LBLMONTOBASE.Text)
            '        LBLMONTO1.Text = FormatCurrency(LBLMONTO1.Text)
            '        LBLIDPRODUC1.Text = LBLIDPRODUC.Text
            '        LBABONAR1.Visible = True
            '        CBOPRODUCTOS.Enabled = False
            '    ElseIf CBOPRODUCTOS.SelectedValue = 71 Then
            '        LBLCANT1.Text = CANTIDAD
            '        LBLCONCEPTO1.Text = LBLDESCRIPCION.Text
            '        LBLMONTO1.Text = CANTIDAD * CDec(LBLMONTOBASE.Text)
            '        LBLMONTO1.Text = FormatCurrency(LBLMONTO1.Text)
            '        LBLIDPRODUC1.Text = LBLIDPRODUC.Text
            '        LBABONAR1.Visible = True
            '        CBOPRODUCTOS.Enabled = False
            '    Else
            '        LBLCONCEPTO1.Text = LBLDESCRIPCION.Text
            '        LBLIDPRODUC1.Text = LBLIDPRODUC.Text
            '        LBLMONTO1.Text = LBLMONTOBASE.Text
            '        LBABONAR1.Visible = True
            '        CBOPRODUCTOS.Enabled = False
            '    End If
            '    Button1.Enabled = True
            'End If

            'If CONTADOR = 2 Then
            '    If CBOPRODUCTOS.SelectedValue = 64 Then
            '        LBLCANT2.Text = CANTIDAD
            '        LBLMONTO2.Text = CANTIDAD * CDec(LBLMONTOBASE.Text)
            '        LBLMONTO2.Text = FormatCurrency(LBLMONTO2.Text)
            '        LBLIDPRODUC2.Text = LBLIDPRODUC.Text
            '        LBLCONCEPTO2.Text = LBLDESCRIPCION.Text
            '        CBOPRODUCTOS.Enabled = False
            '        LBABONAR2.Visible = True
            '    ElseIf CBOPRODUCTOS.SelectedValue = 63 Then
            '        LBLCANT2.Text = CANTIDAD
            '        LBLCONCEPTO2.Text = LBLDESCRIPCION.Text
            '        LBLMONTO2.Text = CANTIDAD * CDec(LBLMONTOBASE.Text)
            '        LBLMONTO2.Text = FormatCurrency(LBLMONTO2.Text)
            '        LBLIDPRODUC2.Text = LBLIDPRODUC.Text
            '        LBABONAR2.Visible = True
            '        CBOPRODUCTOS.Enabled = False
            '    ElseIf CBOPRODUCTOS.SelectedValue = 70 Then
            '        LBLCANT2.Text = CANTIDAD
            '        LBLCONCEPTO2.Text = LBLDESCRIPCION.Text
            '        LBLMONTO2.Text = CANTIDAD * CDec(LBLMONTOBASE.Text)
            '        LBLMONTO2.Text = FormatCurrency(LBLMONTO2.Text)
            '        LBLIDPRODUC2.Text = LBLIDPRODUC.Text
            '        LBABONAR2.Visible = True
            '        CBOPRODUCTOS.Enabled = False
            '    ElseIf CBOPRODUCTOS.SelectedValue = 71 Then
            '        LBLCANT2.Text = CANTIDAD
            '        LBLCONCEPTO2.Text = LBLDESCRIPCION.Text
            '        LBLMONTO2.Text = CANTIDAD * CDec(LBLMONTOBASE.Text)
            '        LBLIDPRODUC2.Text = LBLIDPRODUC.Text
            '        LBLMONTO2.Text = FormatCurrency(LBLMONTO2.Text)
            '        LBABONAR2.Visible = True
            '        CBOPRODUCTOS.Enabled = False
            '    Else
            '        LBLCONCEPTO2.Text = LBLDESCRIPCION.Text
            '        LBLIDPRODUC2.Text = LBLIDPRODUC.Text
            '        LBLMONTO2.Text = LBLMONTOBASE.Text
            '        LBABONAR2.Visible = True
            '        CBOPRODUCTOS.Enabled = False

            '    End If
            '    Button2.Enabled = True
            'End If

            'If CONTADOR = 3 Then
            '    If CBOPRODUCTOS.SelectedValue = 64 Then
            '        LBLCANT3.Text = CANTIDAD
            '        LBLMONTO3.Text = CANTIDAD * CDec(LBLMONTOBASE.Text)
            '        LBLIDPRODUC3.Text = LBLIDPRODUC.Text
            '        LBLMONTO3.Text = FormatCurrency(LBLMONTO3.Text)
            '        LBLCONCEPTO3.Text = LBLDESCRIPCION.Text
            '        LBABONAR3.Visible = True
            '        CBOPRODUCTOS.Enabled = False
            '    ElseIf CBOPRODUCTOS.SelectedValue = 63 Then
            '        LBLCANT3.Text = CANTIDAD
            '        LBLCONCEPTO3.Text = LBLDESCRIPCION.Text
            '        LBLMONTO3.Text = CANTIDAD * CDec(LBLMONTOBASE.Text)
            '        LBLMONTO3.Text = FormatCurrency(LBLMONTO3.Text)
            '        LBLIDPRODUC3.Text = LBLIDPRODUC.Text
            '        LBABONAR3.Visible = True
            '        CBOPRODUCTOS.Enabled = False
            '    ElseIf CBOPRODUCTOS.SelectedValue = 70 Then
            '        LBLCANT3.Text = CANTIDAD
            '        LBLCONCEPTO3.Text = LBLDESCRIPCION.Text
            '        LBLMONTO3.Text = CANTIDAD * CDec(LBLMONTOBASE.Text)
            '        LBLIDPRODUC3.Text = LBLIDPRODUC.Text
            '        LBLMONTO3.Text = FormatCurrency(LBLMONTO3.Text)
            '        LBABONAR3.Visible = True
            '        CBOPRODUCTOS.Enabled = False
            '    ElseIf CBOPRODUCTOS.SelectedValue = 71 Then
            '        LBLCANT3.Text = CANTIDAD
            '        LBLCONCEPTO3.Text = LBLDESCRIPCION.Text
            '        LBLMONTO3.Text = CANTIDAD * CDec(LBLMONTOBASE.Text)
            '        LBLIDPRODUC3.Text = LBLIDPRODUC.Text
            '        LBLMONTO3.Text = FormatCurrency(LBLMONTO3.Text)
            '        LBABONAR3.Visible = True
            '        CBOPRODUCTOS.Enabled = False
            '    Else
            '        LBLCONCEPTO3.Text = LBLDESCRIPCION.Text
            '        LBLIDPRODUC3.Text = LBLIDPRODUC.Text
            '        LBLMONTO3.Text = LBLMONTOBASE.Text
            '        LBABONAR3.Visible = True
            '        CBOPRODUCTOS.Enabled = False
            '    End If

            '    Button3.Enabled = True

            'End If

            'If CONTADOR = 4 Then
            '    If CBOPRODUCTOS.SelectedValue = 64 Then
            '        LBLCANT4.Text = CANTIDAD
            '        LBLMONTO4.Text = CANTIDAD * CDec(LBLMONTOBASE.Text)
            '        LBLIDPRODUC4.Text = LBLIDPRODUC.Text
            '        LBLMONTO4.Text = FormatCurrency(LBLMONTO4.Text)
            '        LBLCONCEPTO4.Text = LBLDESCRIPCION.Text
            '        CBOPRODUCTOS.Enabled = False
            '        LBABONAR4.Visible = True
            '    ElseIf CBOPRODUCTOS.SelectedValue = 63 Then
            '        LBLCANT4.Text = CANTIDAD
            '        LBLCONCEPTO4.Text = LBLDESCRIPCION.Text
            '        LBLMONTO4.Text = CANTIDAD * CDec(LBLMONTOBASE.Text)
            '        LBLMONTO4.Text = FormatCurrency(LBLMONTO4.Text)
            '        LBLIDPRODUC4.Text = LBLIDPRODUC.Text
            '        LBABONAR4.Visible = True
            '        CBOPRODUCTOS.Enabled = False
            '    ElseIf CBOPRODUCTOS.SelectedValue = 70 Then
            '        LBLCANT4.Text = CANTIDAD
            '        LBLCONCEPTO4.Text = LBLDESCRIPCION.Text
            '        LBLMONTO4.Text = CANTIDAD * CDec(LBLMONTOBASE.Text)
            '        LBLIDPRODUC4.Text = LBLIDPRODUC.Text
            '        LBLMONTO4.Text = FormatCurrency(LBLMONTO4.Text)
            '        LBABONAR4.Visible = True
            '        CBOPRODUCTOS.Enabled = False
            '    ElseIf CBOPRODUCTOS.SelectedValue = 71 Then
            '        LBLCANT4.Text = CANTIDAD
            '        LBLCONCEPTO4.Text = LBLDESCRIPCION.Text
            '        LBLMONTO4.Text = CANTIDAD * CDec(LBLMONTOBASE.Text)
            '        LBLIDPRODUC4.Text = LBLIDPRODUC.Text
            '        LBLMONTO4.Text = FormatCurrency(LBLMONTO4.Text)
            '        LBABONAR4.Visible = True
            '        CBOPRODUCTOS.Enabled = False
            '    Else
            '        LBLCONCEPTO4.Text = LBLDESCRIPCION.Text
            '        LBLIDPRODUC4.Text = LBLIDPRODUC.Text
            '        LBLMONTO4.Text = LBLMONTOBASE.Text
            '        LBABONAR4.Visible = True
            '        CBOPRODUCTOS.Enabled = False
            '    End If

            '    Button4.Enabled = True

            'End If

            'If CONTADOR = 5 Then
            '    If CBOPRODUCTOS.SelectedValue = 64 Then
            '        LBLCANT5.Text = CANTIDAD
            '        LBLMONTO5.Text = CANTIDAD * CDec(LBLMONTOBASE.Text)
            '        LBLMONTO5.Text = FormatCurrency(LBLMONTO5.Text)
            '        LBLIDPRODUC5.Text = LBLIDPRODUC.Text
            '        LBLCONCEPTO5.Text = LBLDESCRIPCION.Text
            '        CBOPRODUCTOS.Enabled = False
            '        LBABONAR5.Visible = True
            '    ElseIf CBOPRODUCTOS.SelectedValue = 63 Then
            '        LBLCANT5.Text = CANTIDAD
            '        LBLCONCEPTO5.Text = LBLDESCRIPCION.Text
            '        LBLMONTO5.Text = CANTIDAD * CDec(LBLMONTOBASE.Text)
            '        LBLMONTO5.Text = FormatCurrency(LBLMONTO5.Text)
            '        LBLIDPRODUC5.Text = LBLIDPRODUC.Text
            '        LBABONAR5.Visible = True
            '        CBOPRODUCTOS.Enabled = False
            '    ElseIf CBOPRODUCTOS.SelectedValue = 70 Then
            '        LBLCANT5.Text = CANTIDAD
            '        LBLCONCEPTO5.Text = LBLDESCRIPCION.Text
            '        LBLMONTO5.Text = CANTIDAD * CDec(LBLMONTOBASE.Text)
            '        LBLIDPRODUC5.Text = LBLIDPRODUC.Text
            '        LBLMONTO5.Text = FormatCurrency(LBLMONTO5.Text)
            '        LBABONAR5.Visible = True
            '        CBOPRODUCTOS.Enabled = False
            '    ElseIf CBOPRODUCTOS.SelectedValue = 71 Then
            '        LBLCANT5.Text = CANTIDAD
            '        LBLCONCEPTO5.Text = LBLDESCRIPCION.Text
            '        LBLMONTO5.Text = CANTIDAD * CDec(LBLMONTOBASE.Text)
            '        LBLIDPRODUC5.Text = LBLIDPRODUC.Text
            '        LBLMONTO5.Text = FormatCurrency(LBLMONTO5.Text)
            '        LBABONAR5.Visible = True
            '        CBOPRODUCTOS.Enabled = False
            '    Else
            '        LBLCONCEPTO5.Text = LBLDESCRIPCION.Text
            '        LBLMONTO5.Text = LBLMONTOBASE.Text
            '        LBLIDPRODUC5.Text = LBLIDPRODUC.Text
            '        LBABONAR5.Visible = True
            '        CBOPRODUCTOS.Enabled = False
            '    End If

            '    Button5.Enabled = True

            'End If

            If CBOPRODUCTOS.SelectedValue = 240 Then
                'My.Forms.UNIFORMES.MdiParent = PADRE
                My.Forms.UNIFORMES.ShowDialog()

            End If

            LBLMONTO1.Text = FormatCurrency(LBLMONTO1.Text)
            LBLMONTO2.Text = FormatCurrency(LBLMONTO2.Text)
            LBLMONTO3.Text = FormatCurrency(LBLMONTO3.Text)
            LBLMONTO4.Text = FormatCurrency(LBLMONTO4.Text)
            LBLMONTO5.Text = FormatCurrency(LBLMONTO5.Text)
        Catch ex As System.Exception
            con.Close()
            MsgBox("SE ENCONTRO UN PROBLEMA PONGANSE EN CONTACTO CON SU ADMINISTRADOR", MsgBoxStyle.Information, "AVISO")
        End Try

    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        My.Forms.SELECCIONDEALUMNO.Close()
        Me.Close()
    End Sub

    Private Sub CBOPRODUCTOS_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBOPRODUCTOS.Validated
        Try
            CANTIDAD = 1
            If CBOPRODUCTOS.SelectedValue = 64 Then
                CANTIDAD = InputBox("CANTIDAD DE HORAS?", "CANTIDAD")
            ElseIf CBOPRODUCTOS.SelectedValue = 70 Then
                CANTIDAD = InputBox("NUMEROS DE INVITADOS?", "INVITADOS")
            ElseIf CBOPRODUCTOS.SelectedValue = 71 Then
                CANTIDAD = InputBox("NUMEROS DE PLATILLOS?", "PLATILLOS")
            ElseIf CBOPRODUCTOS.SelectedValue = 63 Then
                CANTIDAD = InputBox("NUMEROS DE DIAS?", "DIAS")
            End If

        Catch ex As System.Exception
            
        End Try

    End Sub

    Private Sub LBABONAR1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LBABONAR1.LinkClicked
        Try
            BAND = 1

            ABONO = InputBox("CUANTO ES LO QUE DESEA ABONAR?", "ABONO", 0)

            LBLRESTA1.Text = CDec(LBLMONTO1.Text) - ABONO
            LBLRESTA1.Text = FormatCurrency(LBLRESTA1.Text)
            LBLABONO1.Text = ABONO
            LBLABONO1.Text = FormatCurrency(LBLABONO1.Text)

        Catch
        End Try

    End Sub

    Private Sub LBABONAR2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LBABONAR2.LinkClicked
        Try
            BAND = 1

            ABONO = InputBox("CUANTO ES LO QUE DESEA ABONAR?", "ABONO", 0)
            LBLRESTA2.Text = CDec(LBLMONTO2.Text) - ABONO
            LBLRESTA2.Text = FormatCurrency(LBLRESTA2.Text)
            LBLABONO2.Text = ABONO
            LBLABONO2.Text = FormatCurrency(LBLABONO2.Text)
        Catch
        End Try

    End Sub

    Private Sub LBABONAR3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LBABONAR3.LinkClicked
        Try

            BAND = 1

            ABONO = InputBox("CUANTO ES LO QUE DESEA ABONAR?", "ABONO", 0)
            LBLRESTA3.Text = CDec(LBLMONTO3.Text) - ABONO
            LBLRESTA3.Text = FormatCurrency(LBLRESTA3.Text)
            LBLABONO3.Text = ABONO
            LBLABONO3.Text = FormatCurrency(LBLABONO3.Text)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub LBABONAR4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LBABONAR4.LinkClicked
        Try
            BAND = 1

            ABONO = InputBox("CUANTO ES LO QUE DESEA ABONAR?", "ABONO", 0)
            LBLRESTA4.Text = CDec(LBLMONTO4.Text) - ABONO
            LBLRESTA4.Text = FormatCurrency(LBLRESTA4.Text)
            LBLABONO4.Text = ABONO
            LBLABONO4.Text = FormatCurrency(LBLABONO4.Text)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub LBLABONAR5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LBABONAR5.LinkClicked
        Try
            BAND = 1

            ABONO = InputBox("CUANTO ES LO QUE DESEA ABONAR?", "ABONO", 0)
            LBLRESTA5.Text = CDec(LBLMONTO5.Text) - ABONO
            LBLRESTA5.Text = FormatCurrency(LBLRESTA5.Text)
            LBLABONO5.Text = ABONO
            LBLABONO5.Text = FormatCurrency(LBLABONO5.Text)
        Catch
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            If BAND = 1 Then
                BANDERABONO1 = 1
                con.Open()
                com = New SqlCommand("MOVIMIENTOCOLEGIATURA", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@NOMOV", SqlDbType.Int).Value = 1
                com.Parameters.Add("@RESTA", SqlDbType.Money).Value = LBLRESTA1.Text
                com.Parameters.Add("@TOTAL", SqlDbType.Money).Value = LBLABONO1.Text
                com.Parameters.Add("@ABONO", SqlDbType.Money).Value = LBLABONO1.Text
                com.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = "ABONO AL " & CBOPRODUCTOS.Text
                com.Parameters.Add("@NOFACTURA", SqlDbType.Int).Value = 0
                com.Parameters.Add("@NORECIBO", SqlDbType.Int).Value = LBLNVORECIBO.Text
                com.Parameters.Add("@NOFOLIO", SqlDbType.Int).Value = 0
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
                com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "ABONO DE PRODUCTO CON RECIBO " & LBLNVORECIBO.Text
                com.ExecuteNonQuery()
                con.Close()

                LBABONAR1.Visible = False
                Button1.Enabled = False
                CMDIMPRIMIR.Enabled = True
                CBOPRODUCTOS.Enabled = True
            End If

            If BAND = 2 Then
                BANDERALIQ1 = 1
                con.Open()
                com = New SqlCommand("MOVIMIENTOCOLEGIATURA", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@NOMOV", SqlDbType.Int).Value = 2
                com.Parameters.Add("@RESTA", SqlDbType.Money).Value = 0
                com.Parameters.Add("@TOTAL", SqlDbType.Money).Value = LBLMONTO1.Text
                com.Parameters.Add("@ABONO", SqlDbType.Money).Value = 0
                com.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = "LIQUIDACION AL " & CBOPRODUCTOS.Text
                com.Parameters.Add("@NOFACTURA", SqlDbType.Int).Value = 0
                com.Parameters.Add("@NORECIBO", SqlDbType.Int).Value = LBLNVORECIBO.Text
                com.Parameters.Add("@NOFOLIO", SqlDbType.Int).Value = 0
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
                com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "LIQUIDACION DE PRODUCTO CON FOLIO " & LBLNVORECIBO.Text
                com.ExecuteNonQuery()
                con.Close()
                LBABONAR1.Visible = False
                Button1.Enabled = False
                CMDIMPRIMIR.Enabled = True
                CBOPRODUCTOS.Enabled = True
            End If
        Catch ex As System.Exception
            con.Close()
            MsgBox("SE ENCONTRO UN PROBLEMA PONGANSE EN CONTACTO CON SU ADMINISTRADOR", MsgBoxStyle.Information, "AVISO")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try

            If BAND = 1 Then
                BANDERABONO2 = 1
                con.Open()
                com = New SqlCommand("MOVIMIENTOCOLEGIATURA", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@NOMOV", SqlDbType.Int).Value = 1
                com.Parameters.Add("@RESTA", SqlDbType.Money).Value = LBLRESTA2.Text
                com.Parameters.Add("@TOTAL", SqlDbType.Money).Value = LBLABONO2.Text
                com.Parameters.Add("@ABONO", SqlDbType.Money).Value = LBLABONO2.Text
                com.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = "ABONO AL " & CBOPRODUCTOS.Text
                com.Parameters.Add("@NOFACTURA", SqlDbType.Int).Value = 0
                com.Parameters.Add("@NORECIBO", SqlDbType.Int).Value = LBLNVORECIBO.Text
                com.Parameters.Add("@NOFOLIO", SqlDbType.Int).Value = 0
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
                com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "ABONO DE PRODUCTO CON RECIBO " & LBLNVORECIBO.Text
                com.ExecuteNonQuery()
                con.Close()
                LBABONAR2.Visible = False
                Button2.Enabled = False
                CMDIMPRIMIR.Enabled = True
                CBOPRODUCTOS.Enabled = True
            End If

            If BAND = 2 Then
                BANDERALIQ2 = 1
                con.Open()
                com = New SqlCommand("MOVIMIENTOCOLEGIATURA", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@NOMOV", SqlDbType.Int).Value = 2
                com.Parameters.Add("@RESTA", SqlDbType.Money).Value = 0
                com.Parameters.Add("@TOTAL", SqlDbType.Money).Value = LBLMONTO2.Text
                com.Parameters.Add("@ABONO", SqlDbType.Money).Value = 0
                com.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = "LIQUIDACION AL " & CBOPRODUCTOS.Text
                com.Parameters.Add("@NOFACTURA", SqlDbType.Int).Value = 0
                com.Parameters.Add("@NORECIBO", SqlDbType.Int).Value = LBLNVORECIBO.Text
                com.Parameters.Add("@NOFOLIO", SqlDbType.Int).Value = 0
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
                com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "LIQUIDACION DE PRODUCTO CON FOLIO " & LBLNVORECIBO.Text
                com.ExecuteNonQuery()
                con.Close()
                LBABONAR2.Visible = False
                Button2.Enabled = False
                CMDIMPRIMIR.Enabled = True
                CBOPRODUCTOS.Enabled = True
            End If
        Catch ex As System.Exception
            con.Close()
            MsgBox("SE ENCONTRO UN PROBLEMA PONGANSE EN CONTACTO CON SU ADMINISTRADOR", MsgBoxStyle.Information, "AVISO")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try

            If BAND = 1 Then
                BANDERABONO3 = 1
                con.Open()
                com = New SqlCommand("MOVIMIENTOCOLEGIATURA", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@NOMOV", SqlDbType.Int).Value = 1
                com.Parameters.Add("@RESTA", SqlDbType.Money).Value = LBLRESTA3.Text
                com.Parameters.Add("@TOTAL", SqlDbType.Money).Value = LBLABONO3.Text
                com.Parameters.Add("@ABONO", SqlDbType.Money).Value = LBLABONO3.Text
                com.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = "ABONO AL " & CBOPRODUCTOS.Text
                com.Parameters.Add("@NOFACTURA", SqlDbType.Int).Value = 0
                com.Parameters.Add("@NORECIBO", SqlDbType.Int).Value = LBLNVORECIBO.Text
                com.Parameters.Add("@NOFOLIO", SqlDbType.Int).Value = 0
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
                com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "ABONO DE PRODUCTO CON RECIBO " & LBLNVORECIBO.Text
                com.ExecuteNonQuery()
                con.Close()
                LBABONAR3.Visible = False
                Button3.Enabled = False
                CMDIMPRIMIR.Enabled = True
                CBOPRODUCTOS.Enabled = True
            End If

            If BAND = 2 Then
                BANDERALIQ3 = 1
                con.Open()
                com = New SqlCommand("MOVIMIENTOCOLEGIATURA", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@NOMOV", SqlDbType.Int).Value = 2
                com.Parameters.Add("@RESTA", SqlDbType.Money).Value = 0
                com.Parameters.Add("@TOTAL", SqlDbType.Money).Value = LBLMONTO3.Text
                com.Parameters.Add("@ABONO", SqlDbType.Money).Value = 0
                com.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = "LIQUIDACION AL " & CBOPRODUCTOS.Text
                com.Parameters.Add("@NOFACTURA", SqlDbType.Int).Value = 0
                com.Parameters.Add("@NORECIBO", SqlDbType.Int).Value = LBLNVORECIBO.Text
                com.Parameters.Add("@NOFOLIO", SqlDbType.Int).Value = 0
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
                com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "LIQUIDACION DE PRODUCTO CON FOLIO " & LBLNVORECIBO.Text
                com.ExecuteNonQuery()
                con.Close()
                LBABONAR3.Visible = False
                Button3.Enabled = False
                CMDIMPRIMIR.Enabled = True
                CBOPRODUCTOS.Enabled = True
            End If
        Catch ex As System.Exception
            con.Close()
            MsgBox("SE ENCONTRO UN PROBLEMA PONGANSE EN CONTACTO CON SU ADMINISTRADOR", MsgBoxStyle.Information, "AVISO")
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try

            If BAND = 1 Then
                BANDERABONO4 = 1
                con.Open()
                com = New SqlCommand("MOVIMIENTOCOLEGIATURA", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@NOMOV", SqlDbType.Int).Value = 1
                com.Parameters.Add("@RESTA", SqlDbType.Money).Value = LBLRESTA4.Text
                com.Parameters.Add("@TOTAL", SqlDbType.Money).Value = LBLABONO4.Text
                com.Parameters.Add("@ABONO", SqlDbType.Money).Value = LBLABONO4.Text
                com.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = "ABONO AL " & CBOPRODUCTOS.Text
                com.Parameters.Add("@NOFACTURA", SqlDbType.Int).Value = 0
                com.Parameters.Add("@NORECIBO", SqlDbType.Int).Value = LBLNVORECIBO.Text
                com.Parameters.Add("@NOFOLIO", SqlDbType.Int).Value = 0
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
                com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "ABONO DE PRODUCTO CON RECIBO " & LBLNVORECIBO.Text
                com.ExecuteNonQuery()
                con.Close()
                LBABONAR4.Visible = False
                Button4.Enabled = False
                CMDIMPRIMIR.Enabled = True
                CBOPRODUCTOS.Enabled = True
            End If

            If BAND = 2 Then
                BANDERALIQ4 = 1
                con.Open()
                com = New SqlCommand("MOVIMIENTOCOLEGIATURA", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@NOMOV", SqlDbType.Int).Value = 2
                com.Parameters.Add("@RESTA", SqlDbType.Money).Value = 0
                com.Parameters.Add("@TOTAL", SqlDbType.Money).Value = LBLMONTO4.Text
                com.Parameters.Add("@ABONO", SqlDbType.Money).Value = 0
                com.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = "LIQUIDACION AL " & CBOPRODUCTOS.Text
                com.Parameters.Add("@NOFACTURA", SqlDbType.Int).Value = 0
                com.Parameters.Add("@NORECIBO", SqlDbType.Int).Value = LBLNVORECIBO.Text
                com.Parameters.Add("@NOFOLIO", SqlDbType.Int).Value = 0
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
                com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "LIQUIDACION DE PRODUCTO CON FOLIO " & LBLNVORECIBO.Text
                com.ExecuteNonQuery()
                con.Close()
                LBABONAR4.Visible = False
                Button4.Enabled = False
                CMDIMPRIMIR.Enabled = True
                CBOPRODUCTOS.Enabled = True
            End If
        Catch ex As System.Exception
            con.Close()
            MsgBox("SE ENCONTRO UN PROBLEMA PONGANSE EN CONTACTO CON SU ADMINISTRADOR", MsgBoxStyle.Information, "AVISO")
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try

            If BAND = 1 Then
                BANDERABONO5 = 1
                con.Open()
                com = New SqlCommand("MOVIMIENTOCOLEGIATURA", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@NOMOV", SqlDbType.Int).Value = 1
                com.Parameters.Add("@RESTA", SqlDbType.Money).Value = LBLRESTA5.Text
                com.Parameters.Add("@TOTAL", SqlDbType.Money).Value = LBLABONO5.Text
                com.Parameters.Add("@ABONO", SqlDbType.Money).Value = LBLABONO5.Text
                com.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = "ABONO AL " & CBOPRODUCTOS.Text
                com.Parameters.Add("@NOFACTURA", SqlDbType.Int).Value = 0
                com.Parameters.Add("@NORECIBO", SqlDbType.Int).Value = LBLNVORECIBO.Text
                com.Parameters.Add("@NOFOLIO", SqlDbType.Int).Value = 0
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
                com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "ABONO DE PRODUCTO CON RECIBO " & LBLNVORECIBO.Text
                com.ExecuteNonQuery()
                con.Close()
                LBABONAR5.Visible = False
                Button5.Enabled = False
                CMDIMPRIMIR.Enabled = True
                CBOPRODUCTOS.Enabled = True
            End If

            If BAND = 2 Then
                BANDERALIQ5 = 1
                con.Open()
                com = New SqlCommand("MOVIMIENTOCOLEGIATURA", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@NOMOV", SqlDbType.Int).Value = 2
                com.Parameters.Add("@RESTA", SqlDbType.Money).Value = 0
                com.Parameters.Add("@TOTAL", SqlDbType.Money).Value = LBLMONTO5.Text
                com.Parameters.Add("@ABONO", SqlDbType.Money).Value = 0
                com.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = "LIQUIDACION AL " & CBOPRODUCTOS.Text
                com.Parameters.Add("@NOFACTURA", SqlDbType.Int).Value = 0
                com.Parameters.Add("@NORECIBO", SqlDbType.Int).Value = LBLNVORECIBO.Text
                com.Parameters.Add("@NOFOLIO", SqlDbType.Int).Value = 0
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
                com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "LIQUIDACION DE PRODUCTO CON FOLIO " & LBLNVORECIBO.Text
                com.ExecuteNonQuery()
                con.Close()
                LBABONAR5.Visible = False
                Button5.Enabled = False
                CMDIMPRIMIR.Enabled = True
                CBOPRODUCTOS.Enabled = True
            End If
        Catch ex As System.Exception
            con.Close()
            MsgBox("SE ENCONTRO UN PROBLEMA PONGANSE EN CONTACTO CON SU ADMINISTRADOR", MsgBoxStyle.Information, "AVISO")
        End Try
    End Sub


    Private Sub CMDIMPRIMIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDIMPRIMIR.Click
        BANDERAREPORTE2 = 1
        IMPRESION = 2
        'My.Forms.VENTANAEMERGENTE.MdiParent = PADRE
        My.Forms.VENTANAEMERGENTE.ShowDialog()
        Me.Enabled = False


    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Try

        con.Open()
        com = New SqlCommand("ELIMINARPRODUCTODEMOV", con)
        com.CommandType = CommandType.StoredProcedure
        com.Parameters.Add("@IDPRODUC", SqlDbType.Int).Value = LBLIDPRODUC1.Text
        com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
        com.Parameters.Add("@FECHA", SqlDbType.Date).Value = CDate(PADRE.TSFECHA.Text)
        com.ExecuteNonQuery()
        con.Close()

        LBLCONCEPTO1.Text = ""
        LBLMONTO1.Text = 0
        LBLABONO1.Text = 0
        LBLRESTA1.Text = 0
        LBABONAR1.Visible = False
        CBOPRODUCTOS.Enabled = True
            CONTADOR = 0

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            con.Open()
            com = New SqlCommand("ELIMINARPRODUCTODEMOV", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDPRODUC", SqlDbType.Int).Value = LBLIDPRODUC2.Text
            com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.Parameters.Add("@FECHA", SqlDbType.Date).Value = CDate(PADRE.TSFECHA.Text)
            com.ExecuteNonQuery()
            con.Close()

            LBLCONCEPTO2.Text = ""
            LBLMONTO2.Text = 0
            LBLABONO2.Text = 0
            LBLRESTA2.Text = 0
            LBABONAR2.Visible = False
            CBOPRODUCTOS.Enabled = True
            CONTADOR = 1
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            con.Open()
            com = New SqlCommand("ELIMINARPRODUCTODEMOV", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDPRODUC", SqlDbType.Int).Value = LBLIDPRODUC3.Text
            com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.Parameters.Add("@FECHA", SqlDbType.Date).Value = CDate(PADRE.TSFECHA.Text)
            com.ExecuteNonQuery()
            con.Close()

            LBLCONCEPTO3.Text = ""
            LBLMONTO3.Text = 0
            LBLABONO3.Text = 0
            LBLRESTA3.Text = 0
            LBABONAR3.Visible = False
            CBOPRODUCTOS.Enabled = True
            CONTADOR = 2
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            con.Open()
            com = New SqlCommand("ELIMINARPRODUCTODEMOV", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDPRODUC", SqlDbType.Int).Value = LBLIDPRODUC4.Text
            com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.Parameters.Add("@FECHA", SqlDbType.Date).Value = CDate(PADRE.TSFECHA.Text)
            com.ExecuteNonQuery()
            con.Close()

            LBLCONCEPTO4.Text = ""
            LBLMONTO4.Text = 0
            LBLABONO4.Text = 0
            LBLRESTA4.Text = 0
            LBABONAR4.Visible = False
            CBOPRODUCTOS.Enabled = True
            CONTADOR = 3
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            con.Open()
            com = New SqlCommand("ELIMINARPRODUCTODEMOV", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDPRODUC", SqlDbType.Int).Value = LBLIDPRODUC5.Text
            com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.Parameters.Add("@FECHA", SqlDbType.Date).Value = CDate(PADRE.TSFECHA.Text)
            com.ExecuteNonQuery()
            con.Close()

            LBLCONCEPTO5.Text = ""
            LBLMONTO5.Text = 0
            LBLABONO5.Text = 0
            LBLRESTA5.Text = 0
            LBABONAR5.Visible = False
            CBOPRODUCTOS.Enabled = True
            CONTADOR = 4
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub


    Private Sub CBOPRODUCTOS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOPRODUCTOS.SelectedIndexChanged
        CMDIMPRIMIR.Enabled = False
        Try
            Me.PRODUCTOSABONADOSTableAdapter.Fill(Me.SACDataSet.PRODUCTOSABONADOS, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.CBOALUMNO.SelectedValue, Integer)), New System.Nullable(Of Integer)(CType(CBOPRODUCTOS.SelectedValue, Integer)), New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))
            Me.PRODUCTOSLIQUIDADOSTableAdapter.Fill(Me.SACDataSet.PRODUCTOSLIQUIDADOS, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.CBOALUMNO.SelectedValue, Integer)), New System.Nullable(Of Integer)(CType(CBOPRODUCTOS.SelectedValue, Integer)), New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))
            If PRODUCTOSABONADOSBindingSource.Count = 0 Then
                LBLABONADO.Text = 0
            End If
            If PRODUCTOSLIQUIDADOSBindingSource.Count = 0 Then
                LBLLIQUIDADO.Text = 0
            End If

            Select Case CBOPRODUCTOS.SelectedValue

                Case 40 To 59
                    If LBLABONADO.Text = 1 Then
                        MsgBox("ESTE PRODUCTO YA ESTA EN ABONOS", MsgBoxStyle.Information, "ABONOS")
                        Button13.Enabled = False
                    ElseIf LBLLIQUIDADO.Text = 1 Then
                        MsgBox("ESTE PRODUCTO YA ESTA LIQUIDADO", MsgBoxStyle.Information, "ABONOS")
                        Button13.Enabled = False
                    Else
                        Button13.Enabled = True
                    End If
                Case 66
                    If LBLABONADO.Text = 1 Then
                        MsgBox("ESTE PRODUCTO YA ESTA EN ABONOS", MsgBoxStyle.Information, "ABONOS")
                        Button13.Enabled = False
                    ElseIf LBLLIQUIDADO.Text = 1 Then
                        MsgBox("ESTE PRODUCTO YA ESTA LIQUIDADO", MsgBoxStyle.Information, "ABONOS")
                        Button13.Enabled = False
                    Else
                        Button13.Enabled = True
                    End If
                Case 70
                    If LBLABONADO.Text = 1 Then
                        MsgBox("ESTE PRODUCTO YA ESTA EN ABONOS", MsgBoxStyle.Information, "ABONOS")
                        Button13.Enabled = False
                    ElseIf LBLLIQUIDADO.Text = 1 Then
                        MsgBox("ESTE PRODUCTO YA ESTA LIQUIDADO", MsgBoxStyle.Information, "ABONOS")
                        Button13.Enabled = False
                    Else
                        Button13.Enabled = True
                    End If
                Case Else
                    If LBLABONADO.Text = 1 Then
                        MsgBox("ESTE PRODUCTO YA ESTA EN ABONOS, PUEDE COBRAR MAS PRODUCTOS DE ESTE TIPO", MsgBoxStyle.Information, "ABONOS")
                        Button13.Enabled = True
                    End If

            End Select
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GPOPRODUCTOS_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GPOPRODUCTOS.Enter

    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.PRODUCTOSABONADOSTableAdapter.Fill(Me.SACDataSet.PRODUCTOSABONADOS, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.CBOALUMNO.SelectedValue, Integer)), New System.Nullable(Of Integer)(CType(CBOPRODUCTOS.SelectedValue, Integer)), New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))
            Me.PRODUCTOSLIQUIDADOSTableAdapter.Fill(Me.SACDataSet.PRODUCTOSLIQUIDADOS, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.CBOALUMNO.SelectedValue, Integer)), New System.Nullable(Of Integer)(CType(CBOPRODUCTOS.SelectedValue, Integer)), New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.PRODUCTOSLIQUIDADOSTableAdapter.Fill(Me.SACDataSet.PRODUCTOSLIQUIDADOS, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.CBOALUMNO.SelectedValue, Integer)), New System.Nullable(Of Integer)(CType(CBOPRODUCTOS.SelectedValue, Integer)), New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick


    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick


        registro = DataGridView1.CurrentRow.Cells(0).Value

        CantIngre = InputBox("Ingrese cantidad de Pago:", DataGridView1.CurrentRow.Cells(4).Value.ToString, 0)

        If CantIngre < CDec(DataGridView1.CurrentRow.Cells(1).Value) Then
            Comando.CommandText = "UPDATE CobroProductos SET ABONO = " & CantIngre & ", RESTA = " & CDec(DataGridView1.CurrentRow.Cells(1).Value) - CantIngre & " WHERE NOMOV = " & registro
            Comando.Connection = conBuffer
            Comando.ExecuteNonQuery()
            Comando.Dispose()
        End If


    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = 46 Then
            registro = DataGridView1.CurrentRow.Cells(0).Value
            MsgBox("Desea eliminar el registro " & registro, MsgBoxStyle.YesNo, Me.Text)
            If MsgBoxResult.Yes Then

                Comando.CommandText = "DELETE FROM CobroProductos WHERE NOMOV = " & registro
                Comando.Connection = conBuffer
                Comando.ExecuteNonQuery()
                Comando.Dispose()

                Dim DataTable = New OleDb.OleDbDataAdapter("SELECT NOMOV,TOTAL,RESTA,ABONO,DESCRIPCION,MATRI FROM CobroProductos", conBuffer)
                DataSet = New DataSet
                DataTable.Fill(DataSet)
                DataGridView1.DataSource = DataSet.Tables(0).DefaultView
                DataGridView1.Columns(5).HeaderText = "MATRICULA"
                DataGridView1.Columns(1).DefaultCellStyle.Format = "C2"
                DataGridView1.Columns(2).DefaultCellStyle.Format = "C2"
                DataGridView1.Columns(3).DefaultCellStyle.Format = "C2"
            Else

            End If
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class