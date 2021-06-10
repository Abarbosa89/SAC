Imports System.Data.SqlClient
Imports System.Data
Public Class ELIMINARMOVIMIENTOS


    Private Sub ELIMINARMOVIMIENTOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.ELIMINARMOVIMIENTOSTableAdapter.Fill(Me.SACDataSet.ELIMINARMOVIMIENTOS, New System.Nullable(Of Date)(CType(DTFECHA.Value, Date)))
            LBLIDMOV.Hide()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CMDGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR.Click
        Try

            If MsgBox("Esta Seguro de Eliminar este Movimiento", MsgBoxStyle.YesNo, "AVISO") = MsgBoxResult.Yes Then

                Dim com As SqlCommand = con.CreateCommand()
                con.Open()
                com = New SqlCommand("ELIMINARMOV", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@IDMOV", SqlDbType.Int).Value = LBLIDMOV.Text
                com.ExecuteNonQuery()
                con.Close()

                con.Open()
                com = New SqlCommand("REGISTRODEACTIVIDAD", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "ELIMINO MOVIMIENTO"
                com.ExecuteNonQuery()
                con.Close()

                MsgBox("MOVIMIENTO ELIMINADO", MsgBoxStyle.Information, "AVISO")
                Me.ELIMINARMOVIMIENTOSTableAdapter.Fill(Me.SACDataSet.ELIMINARMOVIMIENTOS, New System.Nullable(Of Date)(CType(PADRE.TSFECHA.Text, Date)))

            Else


            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            MsgBox("OCURRIO UN PROBLEMA CONTACTE A SU ADMINISTRADOR", MsgBoxStyle.Information, "AVISO")
            con.Close()
        End Try

    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        Me.Close()

    End Sub

    Private Sub DTFECHA_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTFECHA.ValueChanged
        Try
            Me.ELIMINARMOVIMIENTOSTableAdapter.Fill(Me.SACDataSet.ELIMINARMOVIMIENTOS, New System.Nullable(Of Date)(CType(DTFECHA.Value, Date)))
            LBLIDMOV.Hide()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class