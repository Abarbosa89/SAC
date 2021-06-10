Imports System.Data.SqlClient
Imports System.Data
Public Class MODIFICARTUTORES


    Private Sub MODIFICARTUTORES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Me.SELECCIONARTUTORESTableAdapter.Fill(Me.SACDataSet.SELECCIONARTUTORES, New System.Nullable(Of Integer)(CType(SELECCIONDEALUMNO.CBOALUMNO.SelectedValue, Integer)))
            LBLIDTUT.Hide()

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        My.Forms.ADMINISTRATIVO.MdiParent = PADRE
        My.Forms.ADMINISTRATIVO.Show()
        My.Forms.SELECCIONDEALUMNO.Close()
        Me.Close()
    End Sub

    Private Sub CMDEDITARDTOSPER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEDITARDTOSPER.Click
        GPODATOSPER.Enabled = True
        TXTNOMBRE.BackColor = Color.White
        TXTAPPMAT.BackColor = Color.White
        TXTAPPPAT.BackColor = Color.White
        TXTSEXO.BackColor = Color.White
        TXTDOMPART.BackColor = Color.White

    End Sub

    Private Sub CMDEDITAROTROSDATOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEDITAROTROSDATOS.Click
        GPOOTROSDATOS.Enabled = True
        TXTEMAIL.BackColor = Color.White
        TXTEMAILLAB.BackColor = Color.White
        TXTTELCEL.BackColor = Color.White
        TXTTELCAS.BackColor = Color.White
        TXTRADIO.BackColor = Color.White
        TXTTELTRAB.BackColor = Color.White
    End Sub

    Private Sub CMDEDITARFACTURA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEDITARFACTURA.Click
        GPOFACTURACION.Enabled = True
        TXTCALLE.BackColor = Color.White
        TXTCIUDAD.BackColor = Color.White
        TXTCOLONIA.BackColor = Color.White
        TXTCP.BackColor = Color.White
        TXTDENOMSOCIAL.BackColor = Color.White
        TXTESTADO.BackColor = Color.White
        TXTNUMERO.BackColor = Color.White
        TXTPAIS.BackColor = Color.White
        TXTRFC.BackColor = Color.White

    End Sub

    Private Sub CMDGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR.Click
        Try
            Dim com As SqlCommand = con.CreateCommand()
            con.Open()
            com = New SqlCommand("MODIFICARTUTOR", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDTUT", SqlDbType.Int).Value = LBLIDTUT.Text
            com.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = TXTNOMBRE.Text
            com.Parameters.Add("@APPAT", SqlDbType.NVarChar).Value = TXTAPPPAT.Text
            com.Parameters.Add("@APMAT", SqlDbType.NVarChar).Value = TXTAPPMAT.Text
            com.Parameters.Add("@SEXO", SqlDbType.NVarChar).Value = TXTSEXO.Text
            com.Parameters.Add("@RFC", SqlDbType.NVarChar).Value = TXTRFC.Text
            com.Parameters.Add("@DENOMSOCIAL", SqlDbType.NVarChar).Value = TXTDENOMSOCIAL.Text
            com.Parameters.Add("@CALLE", SqlDbType.NVarChar).Value = TXTCALLE.Text
            com.Parameters.Add("@NUMERO", SqlDbType.NVarChar).Value = TXTNUMERO.Text
            com.Parameters.Add("@COLONIA", SqlDbType.NVarChar).Value = TXTCOLONIA.Text
            com.Parameters.Add("@CIUDAD", SqlDbType.NVarChar).Value = TXTCIUDAD.Text
            com.Parameters.Add("@ESTADO", SqlDbType.NVarChar).Value = TXTESTADO.Text
            com.Parameters.Add("@PAIS", SqlDbType.NVarChar).Value = TXTPAIS.Text
            com.Parameters.Add("@CP", SqlDbType.NVarChar).Value = TXTCP.Text
            com.Parameters.Add("@DOMPART", SqlDbType.NVarChar).Value = TXTDOMPART.Text
            com.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = TXTEMAIL.Text
            com.Parameters.Add("@EMAILLAB", SqlDbType.NVarChar).Value = TXTEMAILLAB.Text
            com.Parameters.Add("@TELCASA", SqlDbType.NVarChar).Value = TXTTELCAS.Text
            com.Parameters.Add("@TELTRAB", SqlDbType.NVarChar).Value = TXTTELTRAB.Text
            com.Parameters.Add("@TELCEL", SqlDbType.NVarChar).Value = TXTTELCEL.Text
            com.Parameters.Add("@RADIO", SqlDbType.NVarChar).Value = TXTRADIO.Text
            com.Parameters.Add("@RECFACTURA", SqlDbType.Bit).Value = CBREQUIEREFACT.Checked
            com.ExecuteNonQuery()
            con.Close()

            con.Open()
            com = New SqlCommand("REGISTRODEACTIVIDAD", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
            com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "MODIFICO TUTOR DEL ALUMNO CON MATRICULA " & SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.ExecuteNonQuery()
            con.Close()

            MsgBox("TUTOR MODIFICADO", MsgBoxStyle.Information, "CONFIRMACION")
            My.Forms.ADMINISTRATIVO.MdiParent = PADRE
            My.Forms.ADMINISTRATIVO.Show()
            Me.Close()

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub CMDAGREGARTUTOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDAGREGARTUTOR.Click
        BANDTUTOR = 1
        My.Forms.NUEVOTUTOR.MdiParent = PADRE
        My.Forms.NUEVOTUTOR.Show()
        Me.Close()
    End Sub
End Class