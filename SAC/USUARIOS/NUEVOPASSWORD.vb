Imports System.Data.SqlClient
Imports System.Data
Public Class NUEVOPASSWORD


    Private Sub CMDRESETEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDRESETEAR.Click
        Try
            Dim com As SqlCommand = con.CreateCommand()
            con.Open()
            com = New SqlCommand("REACTIVARPASSWORD", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDUS", SqlDbType.Int).Value = ComboBox1.SelectedValue
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("CONTRASEÑA RESETEADA", MsgBoxStyle.Information, "CONTRASEÑA")
            Me.Close()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub NUEVOPASSWORD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SELECCIONARUSUARIOSPASSTableAdapter.Fill(Me.SACDataSet.SELECCIONARUSUARIOSPASS, New System.Nullable(Of Integer)(CType(Intro.IdRangoLabel1.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class