Imports System.Data.SqlClient
Imports System.Data
Public Class ADMINISTRATIVO

    Private Sub CMDUSUARIOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDUSUARIOS.Click
        PADRE.TINABILITAR2.Enabled = False
        My.Forms.USUARIOS.MdiParent = PADRE
        My.Forms.USUARIOS.Show()
        Me.Close()
    End Sub

    Private Sub CMDALUMNOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDALUMNOS.Click
        PADRE.TINABILITAR2.Enabled = False
        My.Forms.MODIFICARALUMNO.MdiParent = PADRE
        My.Forms.MODIFICARALUMNO.Show()
        Me.Close()
    End Sub

    Private Sub CMDTUTORES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDTUTORES.Click
        PADRE.TINABILITAR2.Enabled = False
        BANDERACOBRO = 3
        My.Forms.SELECCIONDEALUMNO.MdiParent = PADRE
        My.Forms.SELECCIONDEALUMNO.Show()
        Me.Close()
    End Sub

    Private Sub CMDBECAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDBECAS.Click
        PADRE.TINABILITAR2.Enabled = False
        My.Forms.ASIGNACIONDEBECA.MdiParent = PADRE
        My.Forms.ASIGNACIONDEBECA.Show()
        Me.Close()
    End Sub


    Private Sub CMDSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSALIR.Click
        PADRE.TINABILITAR2.Enabled = False
        PADRE.TINABILITAR.Enabled = True
        Me.Close()
    End Sub


    Private Sub ADMINISTRATIVO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Intro.IdRangoLabel1.Text <= 2 Then
            Me.Width = 872
            Me.Height = 385
        ElseIf Intro.IdRangoLabel1.Text = 4 Then
            Me.Width = 448
            Me.Height = 385
            GPADMINISTRADOR.Visible = False
        ElseIf Intro.IdRangoLabel1.Text >= 5 Then
            Me.Width = 308
            Me.Height = 385
            GPADMINISTRADOR.Visible = False
            GPUSER.Visible = False
        End If

    End Sub

    Private Sub CMDREPORTES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDREPORTES.Click
        PADRE.TINABILITAR2.Enabled = False
        My.Forms.REPORTES.MdiParent = PADRE
        My.Forms.REPORTES.Show()
        Me.Close()
    End Sub


    Private Sub CMDELIMINARMOV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDELIMINARMOV.Click
        PADRE.TINABILITAR2.Enabled = False
        My.Forms.ELIMINARMOVIMIENTOS.MdiParent = PADRE
        My.Forms.ELIMINARMOVIMIENTOS.Show()
        Me.Close()
    End Sub

    Private Sub CMDPAGOSALUM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDPAGOSALUM.Click
        PADRE.TINABILITAR2.Enabled = False
        BANDERACOBRO = 5
        My.Forms.SELECCIONDEALUMNO.MdiParent = PADRE
        My.Forms.SELECCIONDEALUMNO.Show()
        Me.Close()
    End Sub

    Private Sub CMDDETALLESALUM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDETALLESALUM.Click
        PADRE.TINABILITAR2.Enabled = False
        My.Forms.DETALLESALUMNOS.MdiParent = PADRE
        My.Forms.DETALLESALUMNOS.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDFLASHPAGOSALUM.Click
   
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDFLASHDETALLESALUM.Click
    
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDADEUDOALUMNO.Click
        PADRE.TINABILITAR2.Enabled = False
        BANDERACOBRO = 6
        My.Forms.SELECCIONDEALUMNO.MdiParent = PADRE
        My.Forms.SELECCIONDEALUMNO.Show()
        Me.Close()
    End Sub

    Private Sub CMDMODIFICARFACTURAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDMODIFICARFACTURAS.Click
        PADRE.TINABILITAR2.Enabled = False
        My.Forms.DATOSFACTURA.MdiParent = PADRE
        My.Forms.DATOSFACTURA.Show()
        Me.Close()
    End Sub

    Private Sub CMDMOFICIARMOV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDMOFICIARMOV.Click
        PADRE.TINABILITAR2.Enabled = False
        My.Forms.MODIFICARMOVIMIENTOS.MdiParent = PADRE
        My.Forms.MODIFICARMOVIMIENTOS.Show()
        Me.Close()
    End Sub

    Private Sub CMDMODIFICARPRODUCTOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDMODIFICARPRODUCTOS.Click
        My.Forms.MODIFICARPRODUCTOS.MdiParent = PADRE
        My.Forms.MODIFICARPRODUCTOS.Show()
        Me.Close()
    End Sub

    Private Sub CMDPEDIDOUNIFORM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDPEDIDOUNIFORM.Click
        My.Forms.PEDIDOSUNIFORMES.MdiParent = PADRE
        My.Forms.PEDIDOSUNIFORMES.Show()
        Me.Close()
    End Sub

    Private Sub CMDREIMPRESION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDREIMPRESION.Click
        My.Forms.REIMPRESIONRECFOL.MdiParent = PADRE
        My.Forms.REIMPRESIONRECFOL.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Forms.SELECCIONDEALUMNO.MdiParent = PADRE
        My.Forms.SELECCIONDEALUMNO.Show()
        BANDERACOBRO = 10
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            ' RESPALDAR BASE DE DATOS
            Dim fecha As String
            fecha = PADRE.TSFECHA.Text
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

        My.Forms.CORTEDIARIOO.MdiParent = PADRE
        My.Forms.CORTEDIARIOO.Show()

    End Sub

    Private Sub CMDDETALLESTUTOTES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDETALLESTUTOTES.Click
        My.Forms.DETALLESTUTORES.MdiParent = PADRE
        My.Forms.DETALLESTUTORES.Show()
        Me.Close()
    End Sub
End Class