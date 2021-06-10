Imports System.Data.SqlClient
Imports System.Data
Public Class PRODUCTOSCOLEGIATURAS

    Private Sub PRODUCTOSCOLEGIATURAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARCICLOS' table. You can move, or remove it, as needed.
        Me.SELECCIONARCICLOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARCICLOS)
        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARGRADO' table. You can move, or remove it, as needed.
        Me.SELECCIONARGRADOTableAdapter.Fill(Me.SACDataSet.SELECCIONARGRADO)
        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARPRODUCTOSCOLEGIATURAS' table. You can move, or remove it, as needed.


    End Sub

    Private Sub CMDGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR.Click
        Try
            Dim com As SqlCommand = con.CreateCommand()
            con.Open()
            com = New SqlCommand("MODIFICARPRODUCTOSCOLEGIATURA", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@MONTO", SqlDbType.Money).Value = TXTMONTO.Text
            com.Parameters.Add("@ID", SqlDbType.Int).Value = IdLabel1.Text
            com.ExecuteNonQuery()
            con.Close()

            con.Open()
            com = New SqlCommand("MODIFICARFECHAVENCI", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@FECHAVENCI", SqlDbType.Date).Value = DTFECHAVENCI.Value
            com.Parameters.Add("@ID", SqlDbType.Int).Value = LBLIDFECHAVENCI.Text
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
            Me.SELECCIONARPRODUCTOSCOLEGIATURASTableAdapter.Fill(Me.SACDataSet.SELECCIONARPRODUCTOSCOLEGIATURAS, New System.Nullable(Of Integer)(CType(CBOGRADO.SelectedValue, Integer)), New System.Nullable(Of Integer)(CType(CBOCICLO.SelectedValue, Integer)))
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
        Me.SELECCIONARPRODUCTOSCOLEGIATURASTableAdapter.Fill(Me.SACDataSet.SELECCIONARPRODUCTOSCOLEGIATURAS, New System.Nullable(Of Integer)(CType(CBOGRADO.SelectedValue, Integer)), New System.Nullable(Of Integer)(CType(CBOCICLO.SelectedValue, Integer)))
        TXTMONTO.Enabled = True
        DTFECHAVENCI.Enabled = True
        CMDGUARDAR.Enabled = True
    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.SELECCIONARPRODUCTOSCOLEGIATURASTableAdapter.Fill(Me.SACDataSet.SELECCIONARPRODUCTOSCOLEGIATURAS, New System.Nullable(Of Integer)(CType(CBOGRADO.SelectedValue, Integer)), New System.Nullable(Of Integer)(CType(CBOCICLO.SelectedValue, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class