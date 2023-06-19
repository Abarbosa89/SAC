Imports System.Data.SqlClient
Imports System.Data
Imports System.Drawing.Printing
Imports System
Public Class PADRE
    Dim sSQL As String = ""
    Dim D1 As New DataTable
    Dim dImpresoras As New DataTable
    Dim DR1 As DataRow
    Private Sub PADRE_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub PADRE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try


            Me.SELECIONARFECHASERVIDORTableAdapter.Fill(Me.SACDataSet.SELECIONARFECHASERVIDOR)
            Me.SELECCIONARCICLOTableAdapter.Fill(Me.SACDataSet.SELECCIONARCICLO, New System.Nullable(Of Date)(CType(FECHASERLabel1.Text, Date)))
            LBLIDCICLO.Hide()
            LBLCICLO.Hide()
            FECHASERLabel1.Hide()
            If Intro.UsuarioLabel1.Text = "Academico" Then
                TSVARIOS.Visible = False
            ElseIf Intro.UsuarioLabel1.Text = "Articulos" Then
                TSMENUACADEMICO.Visible = False
            Else
                TSBSOPORTE.Visible = False
                TBSSALIR.Visible = False

            End If

            If Intro.IdRangoLabel1.Text = 5 Then
                TSPROMOCIONES.Visible = False
                TSLCOBROS.Visible = False
                TSCOLEGIATURAS.Visible = False
                TSINSCRIPCION.Visible = False
                TSADEUDOS.Visible = False
                TSBCOBROS.Visible = False
                TSBINVENTARIOS.Visible = False
                TSLACADEMICOS.Visible = False
                TSREPORTESACADEMICOS.Visible = False
                TSBADEUDOSARTICULOS.Visible = False
            End If

            TINABILITAR.Enabled = True
            TSFECHA.Text = FECHASERLabel1.Text
            TSCICLOESCOLAR.Text = LBLCICLO.Text
            FechaActual = Mid(TSFECHA.Text, 7, 4) & "-" & Mid(TSFECHA.Text, 4, 2) & "-" & Mid(TSFECHA.Text, 1, 2)


            AgregaImpresoras()
            AgregaImpresorasTicket()
            CargoImpresoras()

            Me.Text = ": : : : COLEGIO DUMONT Versión  " & My.Application.Info.Version.ToString & " : : : :" & "                   Fecha de Ultimo Corte: " & DameFechaUltimoCorte()

            FechaCIerre = DameFechaUltimoCorte()

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TSRELOJ.Text = Date.Now.ToLongTimeString
    End Sub



    Private Sub TSBCOBROS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSBCOBROS.Click
        TINABILITAR.Enabled = False
        TINABILITAR2.Enabled = True
        BANDERACOBRO = 2
        BANDERARECFOLFAC = 2
        My.Forms.SELECCIONDEALUMNO.MdiParent = Me
        My.Forms.SELECCIONDEALUMNO.Show()

    End Sub



    Private Sub TBSSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBSSALIR.Click
        My.Forms.Intro.Show()
        Intro.TXTPASS.Text = ""
        Me.Close()
    End Sub



    Private Sub TSBSOPORTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSBSOPORTE.Click
        TINABILITAR.Enabled = False
        TINABILITAR2.Enabled = True
        My.Forms.SOPORTE.MdiParent = Me
        My.Forms.SOPORTE.Show()
    End Sub

    Private Sub TSBADEUDOSARTICULOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSBADEUDOSARTICULOS.Click
        TINABILITAR.Enabled = False
        TINABILITAR2.Enabled = True

        BANDERACOBRO = 4
        BANDERARECFOLFAC = 3
        My.Forms.SELECCIONDEALUMNO.MdiParent = Me
        My.Forms.SELECCIONDEALUMNO.Show()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSPROMOCIONES.Click
        MuestraMenu("Sin Menu")
        TINABILITAR.Enabled = False
        TINABILITAR2.Enabled = True
        My.Forms.PROMOCIONES.MdiParent = Me
        My.Forms.PROMOCIONES.Show()
    End Sub


    Private Sub TSCOLEGIATURAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSCOLEGIATURAS.Click
        BANDERAPAGO = 2
        BANDERACOBRO = 7
        BANDERARECFOLFAC = 1
        My.Forms.SELECCIONDEALUMNO.MdiParent = Me
        My.Forms.SELECCIONDEALUMNO.Show()
    End Sub

    Private Sub TSINSCRIPCION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSINSCRIPCION.Click

        BANDERAPAGO = 1
        BANDERACOBRO = 8
        BANDERARECFOLFAC = 1
        My.Forms.SELECCIONDEALUMNO.MdiParent = Me
        My.Forms.SELECCIONDEALUMNO.Show()
    End Sub

    Private Sub TSADEUDOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSADEUDOS.Click
        BANDERACOBRO = 9
        BANDERAPAGO = 3
        BANDERARECFOLFAC = 1
        My.Forms.SELECCIONDEALUMNO.MdiParent = Me
        My.Forms.SELECCIONDEALUMNO.Show()
    End Sub

    Private Sub TSSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSSALIR.Click
        My.Forms.Intro.Show()
        Intro.TXTPASS.Text = ""
        Me.Close()
    End Sub

    Private Sub TSSOPORTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSSOPORTE.Click
        My.Forms.SOPORTE.MdiParent = Me
        My.Forms.SOPORTE.Show()
    End Sub

    Private Sub TSADMINISTRATIVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSADMINISTRATIVO.Click
        'My.Forms.ADMINISTRATIVO.MdiParent = Me
        'My.Forms.ADMINISTRATIVO.Show()
        MuestraMenu("Administrativo")
    End Sub

    Private Sub TSREPORTESACADEMICOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSREPORTESACADEMICOS.Click
        'My.Forms.REPORTESACADEMICOS.MdiParent = Me
        'My.Forms.REPORTESACADEMICOS.Show()
        MuestraMenu("Academico")
    End Sub

    Private Sub TSNUEVOINGRESO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSNUEVOINGRESO.Click
        MuestraMenu("Sin Menu")
        My.Forms.NUEVOALUMNO.MdiParent = Me
        My.Forms.NUEVOALUMNO.Show()

    End Sub

    Private Sub TSREINSCRIPCION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSREINSCRIPCION.Click
        MuestraMenu("Sin Menu")
        My.Forms.REINSCRIBIRGRUPO.MdiParent = Me
        My.Forms.REINSCRIBIRGRUPO.Show()
    End Sub

    Private Sub TSCAMBIARCICLO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSCAMBIARCICLO.Click
        MuestraMenu("Sin Menu")
        My.Forms.CAMBIARCICLO.ShowDialog()
    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub TSBCORTEDIARIO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSBCORTEDIARIO.Click
        'Try
        '    ' RESPALDAR BASE DE DATOS
        '    Dim fecha As String
        '    fecha = TSFECHA.Text
        '    fecha = fecha.Replace("/", "-")
        '    Dim com As SqlCommand = con.CreateCommand()
        '    con.Open()
        '    com = New SqlCommand("BACKUPSAC", con)
        '    com.CommandType = CommandType.StoredProcedure
        '    com.Parameters.Add("@FECHA", SqlDbType.NVarChar).Value = fecha
        '    com.ExecuteNonQuery()
        '    con.Close()

        'Catch
        '    con.Close()
        'End Try

        My.Forms.CORTEDIARIOO.MdiParent = Me
        My.Forms.CORTEDIARIOO.Show()
    End Sub


    Private Sub MuestraMenu(ByVal Opcion As String)
        Select Case Opcion
            Case "Administrativo"
                If tvCobros.Visible = True Then
                    tvCobros.Visible = False
                    tvAcademico.Visible = False
                    tvAdministrativo.Visible = True
                Else
                    tvAdministrativo.Height = Me.Height - 95
                    tvAdministrativo.Width = Me.Width - 363
                    tvAdministrativo.Location = New Point(167, 27)
                    tvAdministrativo.Visible = True
                    tvAcademico.Visible = False
                    tvCobros.Visible = False

                End If
            Case "Cobros"
                If tvCobros.Visible = True Then
                    tvAdministrativo.Visible = False
                    tvAcademico.Visible = False
                    tvCobros.Visible = True
                Else
                    tvCobros.Height = Me.Height - 95
                    tvCobros.Width = Me.Width - 363
                    tvCobros.Location = New Point(167, 27)
                    tvCobros.Visible = True
                    tvAcademico.Visible = False
                    tvAdministrativo.Visible = False
                End If
            Case "Academico"
                If tvCobros.Visible = True Then
                    tvCobros.Visible = False
                    tvAcademico.Visible = True
                    tvAdministrativo.Visible = False
                Else
                    tvAcademico.Height = Me.Height - 95
                    tvAcademico.Width = Me.Width - 363
                    tvAcademico.Location = New Point(167, 27)
                    tvAcademico.Visible = True
                    tvCobros.Visible = False
                    tvAdministrativo.Visible = False
                End If
            Case Else
                tvCobros.Visible = False
                tvAcademico.Visible = False
                tvAdministrativo.Visible = False
        End Select
    End Sub



    Private Sub tvAdministrativo_DoubleClick1(sender As Object, e As EventArgs) Handles tvAdministrativo.DoubleClick
        Select Case tvAdministrativo.SelectedNode.Text
            Case "Modificar Alumno"
                tvAdministrativo.Visible = False
                My.Forms.MODIFICARALUMNO.ShowDialog()
            Case "Modificar Tutor"
                BANDERACOBRO = 3
                tvAdministrativo.Visible = False
                My.Forms.SELECCIONDEALUMNO.ShowDialog()
            Case "Pagos Alumnos"
                BANDERACOBRO = 5
                tvAdministrativo.Visible = False
                My.Forms.SELECCIONDEALUMNO.ShowDialog()
            Case "Detalle Tutores"
                tvAdministrativo.Visible = False
                My.Forms.DETALLESTUTORES.ShowDialog()
            Case "Detalle Alumnos"
                tvAdministrativo.Visible = False
                My.Forms.DETALLESALUMNOS.ShowDialog()

            Case "Pedido Uniformes"
                tvAdministrativo.Visible = False
                My.Forms.PEDIDOSUNIFORMES.ShowDialog()
            Case "Reimpresion Folio o Recibo"
                tvAdministrativo.Visible = False
                My.Forms.REIMPRESIONRECFOL.ShowDialog()
            Case "Creacion Reportes"
                tvAdministrativo.Visible = False
                My.Forms.REPORTES.ShowDialog()
            Case "Adeudo Alumnos"
                BANDERACOBRO = 6
                tvAdministrativo.Visible = False
                My.Forms.SELECCIONDEALUMNO.ShowDialog()
            Case "Asignar Becas"
                tvAdministrativo.Visible = False
                My.Forms.ASIGNACIONDEBECA.ShowDialog()
            Case "Eliminar Movimientos"
                tvAdministrativo.Visible = False
                My.Forms.ELIMINARMOVIMIENTOS.ShowDialog()
            Case "Modificar Productos"
                tvAdministrativo.Visible = False
                My.Forms.MODIFICARPRODUCTOS.ShowDialog()
            Case "Edicion Usuarios"
                tvAdministrativo.Visible = False
                My.Forms.USUARIOS.ShowDialog()
            Case "Modificar Pagos"
                tvAdministrativo.Visible = False
                My.Forms.MODIFICARMOVIMIENTOS.ShowDialog()
            Case "Modificar Facturas"
                tvAdministrativo.Visible = False
                My.Forms.DATOSFACTURA.ShowDialog()
            Case "Reporte Facturas"
                BANDERACOBRO = 10
                tvAdministrativo.Visible = False
                My.Forms.SELECCIONDEALUMNO.ShowDialog()
            Case "Crear Nuevo Ciclo"
                tvAdministrativo.Visible = False
                My.Forms.AgregarNuevoCiclo.ShowDialog()
            Case "Corte Diario"
                If FechaActual = FechaCIerre Then
                    MsgBox("La fecha actual, ya se encuentra cerrada, no se puede realizar el Corte Diario.", MsgBoxStyle.Information, Me.Text)
                Else
                    If MsgBox("Va a realizar el Corte Diario, tenga en cuenta que al realizar esta accion ya no podra realizar movimientos." & vbCrLf & vbCrLf & "Desea realizar el Corte Diario?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                        'Try
                        '    ' RESPALDAR BASE DE DATOS
                        '    Dim fecha As String
                        '    fecha = TSFECHA.Text
                        '    fecha = fecha.Replace("/", "-")
                        '    Dim com As SqlCommand = con.CreateCommand()
                        '    con.Open()
                        '    com = New SqlCommand("BACKUPSAC", con)
                        '    com.CommandType = CommandType.StoredProcedure
                        '    com.Parameters.Add("@FECHA", SqlDbType.NVarChar).Value = fecha
                        '    com.ExecuteNonQuery()
                        '    con.Close()

                        'Catch
                        '    con.Close()
                        'End Try

                        D1 = New DataTable
                        sSQL = "SELECT SUM(total) AS TOTAL FROM MOVIMIENTOS "
                        sSQL = sSQL & "WHERE idmov <> 1 AND fecha = CONVERT(DATETIME, '" & Mid(TSFECHA.Text, 7, 4) & "-" & Mid(TSFECHA.Text, 4, 2) & "-" & Mid(TSFECHA.Text, 1, 2) & " 00:00:00', 102)"
                        D1 = sqlServer.ExecSQLReturnDT(sSQL)
                        If Not D1 Is Nothing AndAlso D1.Rows.Count > 0 Then
                            DR1 = D1.Rows(0)
                            sSQL = "INSERT INTO CIERREDIARIO (FechaCorte, Total, Usuario) "
                            sSQL = sSQL & "VALUES ('" & Mid(TSFECHA.Text, 7, 4) & "-" & Mid(TSFECHA.Text, 4, 2) & "-" & Mid(TSFECHA.Text, 1, 2) & "'," & IIf(IsDBNull(DR1("TOTAL")), 0, DR1("TOTAL")) & "," & Intro.IdusLabel1.Text & ")"
                            sqlServer.ExecSQL(sSQL)
                        Else

                        End If
                        tvAdministrativo.Visible = False
                        My.Forms.CORTEDIARIOO.ShowDialog()


                    Else


                    End If
                End If


            Case "Corte Diario por Fecha"
                tvAdministrativo.Visible = False
                My.Forms.FECHASCORTEPORFECHAS.ShowDialog()
            Case "Actividad de Usuario"
                tvAdministrativo.Visible = False
                My.Forms.ACTIVIDADUSUARIOS.ShowDialog()
            Case "Clientes Piden Factura"
                tvAdministrativo.Visible = False
                My.Forms.FECHASPIDENFACTURA.ShowDialog()
            Case "Pedidos de Uniformes"
                tvAdministrativo.Visible = False
                My.Forms.RANGOFECHASPEDIDOUNIFORMES.ShowDialog()
            Case "Becas Asignadas"
                tvAdministrativo.Visible = False
                My.Forms.BECASASIGNADASS.ShowDialog()
            Case "Costos de Productos"
                tvAdministrativo.Visible = False
                My.Forms.REPORTESCOSTOS.ShowDialog()
        End Select
    End Sub

    Private Sub tlsCobros_Click(sender As Object, e As EventArgs) Handles tlsCobros.Click
        If FechaActual = FechaCIerre Then
            MsgBox("La fecha actual, ya se encuentra cerrada, no se pueden realizar movimientos.", MsgBoxStyle.Information, Me.Text)
        Else
            MuestraMenu("Cobros")
        End If
    End Sub

    Private Sub tvCobros_DoubleClick(sender As Object, e As EventArgs) Handles tvCobros.DoubleClick
        Select Case tvCobros.SelectedNode.Text
            Case "Colegiaturas"
                BANDERAPAGO = 2
                BANDERACOBRO = 7
                BANDERARECFOLFAC = 1
                tvCobros.Visible = False
                My.Forms.SELECCIONDEALUMNO.ShowDialog()

            Case "Inscripcion"
                BANDERAPAGO = 1
                BANDERACOBRO = 8
                BANDERARECFOLFAC = 1
                tvCobros.Visible = False
                My.Forms.SELECCIONDEALUMNO.ShowDialog()
            Case "Articulos"
                BANDERACOBRO = 2
                BANDERARECFOLFAC = 2
                tvCobros.Visible = False
                My.Forms.SELECCIONDEALUMNO.ShowDialog()
            Case "Adeudos Articulos"
                BANDERACOBRO = 4
                BANDERARECFOLFAC = 3
                tvCobros.Visible = False
                My.Forms.SELECCIONDEALUMNO.ShowDialog()
            Case "Adeudos Colegiaturas/Inscripcion"
                BANDERACOBRO = 9
                BANDERAPAGO = 3
                BANDERARECFOLFAC = 1
                tvCobros.Visible = False
                My.Forms.SELECCIONDEALUMNO.ShowDialog()
        End Select
    End Sub



    Private Sub tvAcademico_DoubleClick(sender As Object, e As EventArgs) Handles tvAcademico.DoubleClick
        Select Case tvAcademico.SelectedNode.Text
            Case "Lista Alumnos"
                BANDERAREPORTE = 1
                tvAcademico.Visible = False
                My.Forms.SELECCIONARESCOLARIDAD.ShowDialog()
            Case "Lista Cumpleaños"
                BANDERAREPORTE = 4
                tvAcademico.Visible = False
                My.Forms.SELECCIONARESCOLARIDAD.ShowDialog()
            Case "Lista Asistencia"
                BANDERAREPORTE = 2
                tvAcademico.Visible = False
                My.Forms.SELECCIONARESCOLARIDAD.ShowDialog()
            Case "Lista Correos"
                BANDERAREPORTE = 3
                tvAcademico.Visible = False
                My.Forms.SELECCIONARESCOLARIDAD.ShowDialog()
        End Select
    End Sub

    Private Sub TINABILITAR_Tick(sender As Object, e As EventArgs) Handles TINABILITAR.Tick

    End Sub

    Private Sub AgregaImpresorasTicket()
        '----- Agrego Todas las Impresoras disponibles en Windows
        Dim P As String
        Dim J As Integer
        Dim i As Integer = 0
        '----- Cargo Impresoras Disponibles
        For Each P In PrinterSettings.InstalledPrinters
            '----- Incremento Número de Impresora
            i = i + 1
            '----- Valido si es mayor de 15
            If i <= 15 Then
                '----- Asigno Nombre de Impresora a Menú
                Ticket.DropDownItems.Add(J).Text = P
            End If
        Next
        '----- Hago no visibles las no Utilizadas
        For J = i + 1 To 15
            Ticket.DropDownItems.Add(J).Visible = False
        Next J
        'If i = 0 Then SwESCAPE = True
        'Exit Sub

        If Err.Number = 3709 Or Err.Number = 387 Then

        End If
    End Sub
    Private Sub CargoImpresoras()
        '----- Agrego Todas las Impresoras disponibles en Windows
        dImpresoras = New DataTable
        sSQL = "SELECT * FROM IMPRESORAS "
        dImpresoras = sqlServer.ExecSQLReturnDT(sSQL)
        Dim drImpresoras As DataRow
        If DataVacio(dImpresoras) = False Then
            Dim x As Integer
            For x = 0 To dImpresoras.Rows.Count - 1
                drImpresoras = dImpresoras.Rows(x)
                If drImpresoras("Tipo") = 1 Then
                    ImpTicketGLOBAL = drImpresoras("Impresora")
                    tsImpresoraTi.Text = ImpTicketGLOBAL
                Else
                    ImpresoraGLOBAL = drImpresoras("Impresora")
                    tsImpresora.Text = ImpresoraGLOBAL
                End If
            Next
        Else
            MsgBox("No hay impresoras seleccionadas.", MsgBoxStyle.Information, Me.Text)
        End If

    End Sub

    Private Sub AgregaImpresoras()
        '----- Agrego Todas las Impresoras disponibles en Windows
        Dim P As String
        Dim J As Integer
        Dim i As Integer = 0
        '----- Cargo Impresoras Disponibles
        For Each P In PrinterSettings.InstalledPrinters
            '----- Incremento Número de Impresora
            i = i + 1
            '----- Valido si es mayor de 15
            If i <= 15 Then
                '----- Asigno Nombre de Impresora a Menú
                Impresora.DropDownItems.Add(J).Text = P
                Impresora.DropDownItems.Item(J).Name = P
            End If
        Next
        '----- Hago no visibles las no Utilizadas
        For J = i + 1 To 15
            Impresora.DropDownItems.Add(J).Visible = False
        Next J
        'If i = 0 Then SwESCAPE = True
        'Exit Sub

        If Err.Number = 3709 Or Err.Number = 387 Then

        End If
    End Sub

    Private Sub Impresora_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Impresora.DropDownItemClicked
        ImpresoraGLOBAL = e.ClickedItem.Text
        tsImpresora.Text = ImpresoraGLOBAL

        dImpresoras = New DataTable
        sSQL = "SELECT * FROM IMPRESORAS WHERE Tipo = 2"
        dImpresoras = sqlServer.ExecSQLReturnDT(sSQL)
        If DataVacio(dImpresoras) = True Then
            sSQL = "INSERT INTO IMPRESORAS (Impresora, Tickets, Tipo) " & _
                   "VALUES ('" & ImpresoraGLOBAL & "',0,2) "
            sqlServer.ExecSQL(sSQL)
        Else
            sSQL = "UPDATE IMPRESORAS SET Impresora = '" & ImpresoraGLOBAL & "' WHERE Tipo = 2"
            sqlServer.ExecSQL(sSQL)
        End If

    End Sub

    Private Sub Ticket_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Ticket.DropDownItemClicked
        ImpTicketGLOBAL = e.ClickedItem.Text
        tsImpresoraTi.Text = ImpTicketGLOBAL

        dImpresoras = New DataTable
        sSQL = "SELECT * FROM IMPRESORAS WHERE Tipo = 1"
        dImpresoras = sqlServer.ExecSQLReturnDT(sSQL)
        If DataVacio(dImpresoras) = True Then
            sSQL = "INSERT INTO IMPRESORAS (Impresora, Tickets, Tipo) " & _
                   "VALUES ('" & ImpTicketGLOBAL & "',1,1) "
            sqlServer.ExecSQL(sSQL)
        Else
            sSQL = "UPDATE IMPRESORAS SET Impresora = '" & ImpTicketGLOBAL & "' WHERE Tipo = 1"
            sqlServer.ExecSQL(sSQL)
        End If
    End Sub

    Private Sub TValidarCierre_Tick(sender As Object, e As EventArgs) Handles TValidarCierre.Tick
        Me.Text = ": : : : COLEGIO DUMONT Versión  " & My.Application.Info.Version.ToString & " : : : :" & "                   Fecha de Ultimo Corte: " & DameFechaUltimoCorte()
        FechaCIerre = DameFechaUltimoCorte()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub RegresarCorteDiarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarCorteDiarioToolStripMenuItem.Click
        Dim sSQL As String = ""

        If MsgBox("Desea regresar el Corte Diario del " & FechaCIerre & "?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            sSQL = "DELETE FROM CIERREDIARIO WHERE FechaCorte = '" & FechaCIerre & "'"
            sqlServer.ExecSQL(sSQL)
            MsgBox("Se ah regresado el Corte Diario", MsgBoxStyle.Information, Me.Text)
        Else

        End If
    End Sub

    Private Sub Impresora_Click(sender As Object, e As EventArgs) Handles Impresora.Click

    End Sub

    Private Sub tvAcademico_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvAcademico.AfterSelect

    End Sub

    Private Sub tvCobros_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvCobros.AfterSelect

    End Sub
End Class