Imports System.Data.SqlClient
Imports System.Data
Public Class PRODUCTOSUNIFORMES

    Private Sub PRODUCTOSUNIFORMES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARCICLOS' table. You can move, or remove it, as needed.
        Me.SELECCIONARCICLOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARCICLOS)
        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARUNIFORMES' table. You can move, or remove it, as needed.

        LBLIDUNIFORM.Hide()
    End Sub

    Private Sub CMDGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR.Click
        Try
            Dim com As SqlCommand = con.CreateCommand()
            con.Open()
            com = New SqlCommand("MODIFICARUNIFORMES", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@MONTO", SqlDbType.Money).Value = TXTMONTO.Text
            com.Parameters.Add("@ID", SqlDbType.Int).Value = LBLID.Text
            com.ExecuteNonQuery()
            con.Close()

            con.Open()
            com = New SqlCommand("REGISTRODEACTIVIDAD", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
            com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "MODIFICACION DE PRODUCTO CON ID " & LBLIDUNIFORM.Text
            com.ExecuteNonQuery()
            con.Close()

            MsgBox("PRODUCTO MODIFICADO", MsgBoxStyle.Information, "GRACIAS")
            Me.SELECCIONARUNIFORMESTableAdapter.Fill(Me.SACDataSet.SELECCIONARUNIFORMES, New System.Nullable(Of Integer)(CType(ComboBox1.SelectedValue, Integer)))

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        My.Forms.MODIFICARPRODUCTOS.MdiParent = PADRE
        My.Forms.MODIFICARPRODUCTOS.Show()
        Me.Close()
    End Sub


    Private Sub CMDOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDOK.Click
        Try
            Me.SELECCIONARUNIFORMESTableAdapter.Fill(Me.SACDataSet.SELECCIONARUNIFORMES, New System.Nullable(Of Integer)(CType(ComboBox1.SelectedValue, Integer)))


        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class