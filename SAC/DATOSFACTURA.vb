Imports System.Data.SqlClient
Imports System.Data
Public Class DATOSFACTURA

    Private Sub DATOSFACTURA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SACDataSet.ALUMNOSPIDENFACTURA' table. You can move, or remove it, as needed.
        Me.ALUMNOSPIDENFACTURATableAdapter.Fill(Me.SACDataSet.ALUMNOSPIDENFACTURA)
        'TODO: This line of code loads data into the 'SACDataSet.ALUMNOSPIDENFACTURA' table. You can move, or remove it, as needed.
        LBLIDMOV.Hide()
     
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTDIGITOSCUENTA.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TXTFACTURA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTFACTURA.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub CMDIMPRIMIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDIMPRIMIR.Click
        Try

            Dim com As SqlCommand = con.CreateCommand()
            con.Open()
            com = New SqlCommand("MOVIMIENTOCOLEGIATURA", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@DIGCUENTA", SqlDbType.Int).Value = TXTDIGITOSCUENTA.Text
            com.Parameters.Add("@FECHAFAC", SqlDbType.Date).Value = DTFECHAFAC.Value
            com.Parameters.Add("@NUMFACTU", SqlDbType.Int).Value = TXTFACTURA.Text
            com.Parameters.Add("@IDMOV", SqlDbType.Int).Value = LBLIDMOV.Text
            com.ExecuteNonQuery()
            con.Close()

            MsgBox("FACTURA AGREGADA", MsgBoxStyle.Information, "FACTURA")

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        Me.Close()
    End Sub
End Class