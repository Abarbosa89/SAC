Imports System.Data.SqlClient
Imports System.Data
Imports System.Drawing.Printing
Imports System
Public Class PADRE

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

            AgregaImpresoras()
            AgregaImpresorasTicket()

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
        My.Forms.CAMBIARCICLO.MdiParent = Me
        My.Forms.CAMBIARCICLO.Show()
    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub TSBCORTEDIARIO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSBCORTEDIARIO.Click
        Try
            ' RESPALDAR BASE DE DATOS
            Dim fecha As String
            fecha = TSFECHA.Text
            fecha = fecha.Replace("/", "-")
            Dim com As SqlCommand = con.CreateCommand()
            con.Open()
            com = New SqlCommand("BACKUPSAC", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@FECHA", SqlDbType.NVarChar).Value = fecha
            com.ExecuteNonQuery()
            con.Close()

        Catch
            con.Close()
        End Try

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

                My.Forms.MODIFICARALUMNO.ShowDialog()
            Case "Modificar Tutor"
                BANDERACOBRO = 3

                My.Forms.SELECCIONDEALUMNO.ShowDialog()
            Case "Pagos Alumnos"
                BANDERACOBRO = 5

                My.Forms.SELECCIONDEALUMNO.ShowDialog()
            Case "Detalle Tutores"

                My.Forms.DETALLESTUTORES.ShowDialog()
            Case "Detalle Alumnos"

                My.Forms.DETALLESALUMNOS.ShowDialog()
            Case "Pedido Uniformes"

                My.Forms.PEDIDOSUNIFORMES.ShowDialog()
            Case "Reimpresion Folio o Recibo"

                My.Forms.REIMPRESIONRECFOL.ShowDialog()
            Case "Creacion Reportes"

                My.Forms.REPORTES.ShowDialog()
            Case "Adeudo Alumnos"
                BANDERACOBRO = 6

                My.Forms.SELECCIONDEALUMNO.ShowDialog()
            Case "Asignar Becas"

                My.Forms.ASIGNACIONDEBECA.ShowDialog()
            Case "Eliminar Movimientos"

                My.Forms.ELIMINARMOVIMIENTOS.ShowDialog()
            Case "Modificar Productos"

                My.Forms.MODIFICARPRODUCTOS.ShowDialog()
            Case "Edicion Usuarios"

                My.Forms.USUARIOS.ShowDialog()
            Case "Modificar Pagos"

                My.Forms.MODIFICARMOVIMIENTOS.ShowDialog()
            Case "Modificar Facturas"

                My.Forms.DATOSFACTURA.ShowDialog()
            Case "Reporte Facturas"
                BANDERACOBRO = 10

                My.Forms.SELECCIONDEALUMNO.ShowDialog()
            Case "Crear Nuevo Ciclo"
                My.Forms.AgregarNuevoCiclo.ShowDialog()
            Case "Corte Diario"
                Try
                    ' RESPALDAR BASE DE DATOS
                    Dim fecha As String
                    fecha = TSFECHA.Text
                    fecha = fecha.Replace("/", "-")
                    Dim com As SqlCommand = con.CreateCommand()
                    con.Open()
                    com = New SqlCommand("BACKUPSAC", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@FECHA", SqlDbType.NVarChar).Value = fecha
                    com.ExecuteNonQuery()
                    con.Close()

                Catch
                    con.Close()
                End Try


                My.Forms.CORTEDIARIOO.ShowDialog()
        End Select
    End Sub

    Private Sub tlsCobros_Click(sender As Object, e As EventArgs) Handles tlsCobros.Click
        MuestraMenu("Cobros")
    End Sub

    Private Sub tvCobros_DoubleClick(sender As Object, e As EventArgs) Handles tvCobros.DoubleClick
        Select Case tvCobros.SelectedNode.Text
            Case "Colegiaturas"
                BANDERAPAGO = 2
                BANDERACOBRO = 7
                BANDERARECFOLFAC = 1
                My.Forms.SELECCIONDEALUMNO.ShowDialog()
            Case "Inscripcion"
                BANDERAPAGO = 1
                BANDERACOBRO = 8
                BANDERARECFOLFAC = 1
                My.Forms.SELECCIONDEALUMNO.ShowDialog()
            Case "Articulos"
                BANDERACOBRO = 2
                BANDERARECFOLFAC = 2
                My.Forms.SELECCIONDEALUMNO.ShowDialog()
            Case "Adeudos Articulos"
                BANDERACOBRO = 4
                BANDERARECFOLFAC = 3
                My.Forms.SELECCIONDEALUMNO.ShowDialog()
            Case "Adeudos Colegiaturas/Inscripcion"

                BANDERACOBRO = 9
                BANDERAPAGO = 3
                BANDERARECFOLFAC = 1
                My.Forms.SELECCIONDEALUMNO.ShowDialog()

        End Select
    End Sub



    Private Sub tvAcademico_DoubleClick(sender As Object, e As EventArgs) Handles tvAcademico.DoubleClick
        Select Case tvAcademico.SelectedNode.Text
            Case "Lista Alumnos"
                BANDERAREPORTE = 1
                My.Forms.SELECCIONARESCOLARIDAD.ShowDialog()
            Case "Lista Cumpleaños"
                BANDERAREPORTE = 4
                My.Forms.SELECCIONARESCOLARIDAD.ShowDialog()

            Case "Lista Asistencia"
                BANDERAREPORTE = 2
                My.Forms.SELECCIONARESCOLARIDAD.ShowDialog()

            Case "Lista Correos"
                BANDERAREPORTE = 3
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
    End Sub

    Private Sub Ticket_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Ticket.DropDownItemClicked
        ImpTicketGLOBAL = e.ClickedItem.Text
        tsImpresoraTi.Text = ImpTicketGLOBAL
    End Sub
End Class