Imports System.Data.SqlClient
Imports System.Data
Public Class NUEVOUSUARIO
    Private Sub CMDGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR.Click
        Try
            If TXTPASS.Text = TXTREPASS.Text Then
                Dim com As SqlCommand = con.CreateCommand()
                con.Open()
                com = New SqlCommand("INSERTARUSUARIO", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@USUARIO", SqlDbType.NVarChar).Value = TXTUSUARIO.Text
                com.Parameters.Add("@NOMCOM", SqlDbType.NVarChar).Value = TXTNOMCOM.Text
                com.Parameters.Add("@NIVEL", SqlDbType.NVarChar).Value = CBONIVEL.SelectedValue
                com.Parameters.Add("@PASS", SqlDbType.NVarChar).Value = TXTREPASS.Text
                com.ExecuteNonQuery()
                con.Close()

                con.Open()
                com = New SqlCommand("REGISTRODEACTIVIDAD", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "REALICO LA CREACION DE UN NUEVO USARIO " & TXTUSUARIO.Text
                com.ExecuteNonQuery()
                con.Close()

                If MsgBox("Nuevo Usuario Creado, ¿Desea crear un nuevo usuario?", MsgBoxStyle.YesNo, "GUARDADO") = MsgBoxResult.Yes Then
                    TXTUSUARIO.Text = ""
                    TXTNOMCOM.Text = ""
                    TXTREPASS.Text = ""
                    TXTPASS.Text = ""
                Else
                    Me.Close()

                End If
            Else
                MsgBox("Error Contraseñas no coinciden, favor de verificar", MsgBoxStyle.Critical, "ERROR")
                TXTPASS.Focus()

            End If
        Catch

            con.Close()
        End Try

    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        My.Forms.USUARIOS.MdiParent = PADRE
        My.Forms.USUARIOS.Show()
        Me.Close()

    End Sub

    Private Sub TXTUSUARIO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTUSUARIO.TextChanged
        TXTUSUARIO.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TXTNOMCOM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTNOMCOM.TextChanged
        TXTNOMCOM.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub NUEVOUSUARIO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SELECCIONARRANGOSTableAdapter1.Fill(Me.SACDataSet.SELECCIONARRANGOS, New System.Nullable(Of Integer)(CType(Intro.IdRangoLabel1.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

End Class