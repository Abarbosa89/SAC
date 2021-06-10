Imports System.Data.SqlClient
Imports System.Data
Public Class REPORTES

    Private Sub CMDCORTEDIARIO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCORTEDIARIO.Click
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
        Me.Close()

    End Sub

    Private Sub REPORTES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Intro.IdRangoLabel1.Text >= 3 Then
            CMDACTUSUARIO.Visible = False
            CMDPIDENFACTURA.Visible = False
            CMDCORTESEMANAL.Visible = False
            CMDPEDIDOUNIFORM.Visible = False
            CMDBECASASIGNADAS.Visible = False
        End If
    End Sub

    Private Sub CMDSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSALIR.Click
        My.Forms.ADMINISTRATIVO.MdiParent = PADRE
        My.Forms.ADMINISTRATIVO.Show()
        Me.Close()
    End Sub

    Private Sub CMDACTUSUARIO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDACTUSUARIO.Click
        My.Forms.ACTIVIDADUSUARIOS.MdiParent = PADRE
        My.Forms.ACTIVIDADUSUARIOS.Show()
        Me.Close()
    End Sub

    Private Sub CMDCORTESEMANAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCORTESEMANAL.Click
        My.Forms.FECHASCORTEPORFECHAS.MdiParent = PADRE
        My.Forms.FECHASCORTEPORFECHAS.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDPIDENFACTURA.Click
        My.Forms.FECHASPIDENFACTURA.MdiParent = PADRE
        My.Forms.FECHASPIDENFACTURA.Show()
        Me.Close()
    End Sub

    Private Sub CMDPEDIDOUNIFORM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDPEDIDOUNIFORM.Click
        My.Forms.RANGOFECHASPEDIDOUNIFORMES.MdiParent = PADRE
        My.Forms.RANGOFECHASPEDIDOUNIFORMES.Show()
        Me.Close()
    End Sub

    Private Sub CMDBECASASIGNADAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDBECASASIGNADAS.Click
        My.Forms.BECASASIGNADASS.MdiParent = PADRE
        My.Forms.BECASASIGNADASS.Show()
        Me.Close()
    End Sub

    Private Sub CMDCOSTOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCOSTOS.Click
        My.Forms.REPORTESCOSTOS.MdiParent = PADRE
        My.Forms.REPORTESCOSTOS.Show()
        Me.Close()
    End Sub
End Class