Imports System.Data.SqlClient
Imports System.Data
Public Class PRODUCTOSVARIOS

    Private Sub PRODUCTOSVARIOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARGRADO' table. You can move, or remove it, as needed.
        Me.SELECCIONARGRADOTableAdapter.Fill(Me.SACDataSet.SELECCIONARGRADO)
        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARCICLOS' table. You can move, or remove it, as needed.
        Me.SELECCIONARCICLOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARCICLOS)
        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARPRODUCTOSVARIOS' table. You can move, or remove it, as needed.
        LBLID.Hide()
        LBLIDPRODUC.Hide()

    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        My.Forms.MODIFICARPRODUCTOS.MdiParent = PADRE
        My.Forms.MODIFICARPRODUCTOS.Show()
        Me.Close()
    End Sub

    Private Sub CMDGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR.Click
        Try
           Dim com As SqlCommand = con.CreateCommand()
            con.Open()
            com = New SqlCommand("MODIFICARPRODUCTOSCOLEGIATURA", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@MONTO", SqlDbType.Money).Value = TXTMONTO.Text
            com.Parameters.Add("@ID", SqlDbType.Int).Value = LBLID.Text
            com.ExecuteNonQuery()
            con.Close()

            con.Open()
            com = New SqlCommand("REGISTRODEACTIVIDAD", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
            com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "MODIFICACION DE PRODUCTO CON ID " & LBLIDPRODUC.Text
            com.ExecuteNonQuery()
            con.Close()

            MsgBox("PRODUCTO MODIFICADO", MsgBoxStyle.Information, "GRACIAS")
            Me.SELECCIONARPRODUCTOSVARIOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARPRODUCTOSVARIOS, New System.Nullable(Of Integer)(CType(CBOGRADO.SelectedValue, Integer)), New System.Nullable(Of Integer)(CType(CBOCICLO.SelectedValue, Integer)))

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

    End Sub

    Private Sub CMDOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDOK.Click
        Try
            Me.SELECCIONARPRODUCTOSVARIOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARPRODUCTOSVARIOS, New System.Nullable(Of Integer)(CType(CBOGRADO.SelectedValue, Integer)), New System.Nullable(Of Integer)(CType(CBOCICLO.SelectedValue, Integer)))


        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class