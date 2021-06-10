Imports System.Data.SqlClient
Imports System.Data
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
        My.Forms.ADMINISTRATIVO.MdiParent = Me
        My.Forms.ADMINISTRATIVO.Show()
    End Sub

    Private Sub TSREPORTESACADEMICOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSREPORTESACADEMICOS.Click
        My.Forms.REPORTESACADEMICOS.MdiParent = Me
        My.Forms.REPORTESACADEMICOS.Show()
    End Sub

    Private Sub TSNUEVOINGRESO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSNUEVOINGRESO.Click
        My.Forms.NUEVOALUMNO.MdiParent = Me
        My.Forms.NUEVOALUMNO.Show()

    End Sub

    Private Sub TSREINSCRIPCION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSREINSCRIPCION.Click
        My.Forms.REINSCRIBIRGRUPO.MdiParent = Me
        My.Forms.REINSCRIBIRGRUPO.Show()
    End Sub

    Private Sub TSCAMBIARCICLO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSCAMBIARCICLO.Click
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
End Class