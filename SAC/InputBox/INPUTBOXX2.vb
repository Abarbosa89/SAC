Imports System.Data.SqlClient
Imports System.Data
Public Class INPUTBOXX2

    Private Sub CMDACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDACEPTAR.Click
        CONFIRMPASS = TXTPASSWORD.Text
        If PASSWORD = CONFIRMPASS Then
            Dim com As SqlCommand = con.CreateCommand()
            con.Open()
            com = New SqlCommand("PASSCAMBIADO", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
            com.Parameters.Add("@PASS", SqlDbType.NVarChar).Value = CONFIRMPASS
            com.ExecuteNonQuery()
            con.Close()
            Intro.SELECCIONARUSUARIOTableAdapter.Fill(Intro.SACDataSet.SELECCIONARUSUARIO, Intro.CBOUSUARIO.Text)
            MsgBox("NUEVA CONTRASEÑA REGISTRADA", MsgBoxStyle.Information, "GRACIAS")
        Else
            MsgBox("LAS CONTRASEÑAS NO COINCIDEN, VUELVA A SELECCIONAR SU USUARIO", MsgBoxStyle.Information, "ATENCION")
        End If
        Me.Close()
    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        Me.Close()
    End Sub
End Class