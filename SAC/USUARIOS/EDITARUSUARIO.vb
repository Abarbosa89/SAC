Imports System.Data.SqlClient
Imports System.Data
Public Class EDITARUSUARIO

    Private Sub EDITARUSUARIO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SELECCIONARUSARIOSPORRANGOTableAdapter.Fill(Me.SACDataSet.SELECCIONARUSARIOSPORRANGO, New System.Nullable(Of Integer)(CType(Intro.IdRangoLabel1.Text, Integer)))
            IdusLabel1.Hide()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub CMDEDITAR1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEDITAR1.Click
        UsuarioTextBox.BackColor = Color.White
        UsuarioTextBox.ReadOnly = False

    End Sub

    Private Sub CMDEDITAR2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEDITAR2.Click
        NomcomTextBox.BackColor = Color.White
        NomcomTextBox.ReadOnly = False
    End Sub


    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        My.Forms.USUARIOS.MdiParent = PADRE
        My.Forms.USUARIOS.Show()
        Me.Close()
    End Sub

    Private Sub CMDGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR.Click
        Try
            Dim com As SqlCommand = con.CreateCommand()
            con.Open()
            com = New SqlCommand("EDITARUSUARIO", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDUS", SqlDbType.Int).Value = IdusLabel1.Text
            com.Parameters.Add("@USUARIO", SqlDbType.NVarChar).Value = UsuarioTextBox.Text
            com.Parameters.Add("@NOMCOM", SqlDbType.NVarChar).Value = NomcomTextBox.Text
            com.Parameters.Add("@STATUS", SqlDbType.Bit).Value = StatusCheckBox.Checked
            com.ExecuteNonQuery()
            con.Close()

            con.Open()
            com = New SqlCommand("REGISTRODEACTIVIDAD", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
            com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "REALIZO LA MODIFICACION DE EL USARIO " & CBOUSUARIOS.Text
            com.ExecuteNonQuery()
            con.Close()
            Intro.USUARIOSACTIVOSTableAdapter.Fill(Intro.SACDataSet.USUARIOSACTIVOS)
            MsgBox("USUARIO MODIFICADO", MsgBoxStyle.Information, "AVISO")
        Catch
            con.Close()
            MsgBox("OCURRIO UN ERROR PORFAVOR CONTACTE A SU ADMINISTRADOR", MsgBoxStyle.Information, "AVISO")
        End Try

    End Sub


    Private Sub CBOUSUARIOS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOUSUARIOS.SelectedIndexChanged
        Try
            Me.SELECCIONARUSUARIOTableAdapter.Fill(Me.SACDataSet.SELECCIONARUSUARIO, CBOUSUARIOS.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class