Imports System.Data.SqlClient
Imports System.Data
Public Class DATOSPERTUTOR

    Private Sub CMDGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR.Click
        Try
            NUEVOTUTOR.TXTNOMBRE.Text = TXTNOMBRE.Text & " " & TXTAPPATERNO.Text & " " & TXTAPMATERNO.Text
            Dim com As SqlCommand = con.CreateCommand()
            con.Open()
            com = New SqlCommand("NUEVOTUTOR", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = TXTNOMBRE.Text
            com.Parameters.Add("@APPATERNO", SqlDbType.NVarChar).Value = TXTAPPATERNO.Text
            com.Parameters.Add("@APMATERNO", SqlDbType.NVarChar).Value = TXTAPMATERNO.Text
            com.ExecuteNonQuery()
            con.Close()
            NUEVOTUTOR.LBNOMBRE.Enabled = False
            Me.IDTUTORTableAdapter.Fill(Me.SACDataSet.IDTUTOR)
            NUEVOTUTOR.LBLIDTUTOR.Text = IdtutLabel1.Text
            NUEVOTUTOR.Focus()
            Me.Close()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub DATOSPERTUTOR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SACDataSet.IDTUTOR' table. You can move, or remove it, as needed.
        IdtutLabel1.Hide()



    End Sub

    Private Sub TXTAPPATERNO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTAPPATERNO.TextChanged
        TXTAPPATERNO.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TXTNOMBRE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTNOMBRE.TextChanged
        TXTNOMBRE.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TXTAPMATERNO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTAPMATERNO.TextChanged
        TXTAPMATERNO.CharacterCasing = CharacterCasing.Upper
    End Sub
End Class