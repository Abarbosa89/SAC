Imports System.Data.SqlClient
Imports System.Data
Public Class NUEVOTUTOR

    Private Sub LBDOMICILIOFISCAL_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LBDOMICILIOFISCAL.LinkClicked
        BANDERA = 1
        My.Forms.DOMPARTUTOR.MdiParent = PADRE
        My.Forms.DOMPARTUTOR.Show()
    End Sub

    Private Sub LBDOMICILIOPART_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LBDOMICILIOPART.LinkClicked
        BANDERA = 2
        My.Forms.DOMPARTUTOR.MdiParent = PADRE
        My.Forms.DOMPARTUTOR.Show()
    End Sub

    Private Sub LBNOMBRE_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LBNOMBRE.LinkClicked
        BANDERA = 3
        My.Forms.DATOSPERTUTOR.MdiParent = PADRE
        My.Forms.DATOSPERTUTOR.Show()
    End Sub

    Private Sub NUEVOTUTOR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LBLIDTUTOR.Hide()
        BANDERA = 4
    End Sub

    Private Sub CMDGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR.Click
        Try
            If BANDTUTOR = 0 Then
                Dim com As SqlCommand = con.CreateCommand()
                con.Open()
                com = New SqlCommand("ACTDEMASDATOSTUTOR", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@IDTUTOR", SqlDbType.Int).Value = LBLIDTUTOR.Text
                com.Parameters.Add("@SEXO", SqlDbType.NVarChar).Value = CBOSEXO.Text
                com.Parameters.Add("@RFC", SqlDbType.NVarChar).Value = TXTRFC.Text
                com.Parameters.Add("@DEMONSOCIAL", SqlDbType.NVarChar).Value = TXTDENOMSOCIAL.Text
                com.Parameters.Add("@DOMPARTICULAR", SqlDbType.NVarChar).Value = TXTDOMICILIOPART.Text
                com.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = TXTEMAIL.Text
                com.Parameters.Add("@EMAILLAB", SqlDbType.NVarChar).Value = TXTEMAILLAB.Text
                com.Parameters.Add("@TELCASA", SqlDbType.NVarChar).Value = TXTTELCASA.Text
                com.Parameters.Add("@TELCEL", SqlDbType.NVarChar).Value = TXTTELCEL.Text
                com.Parameters.Add("@RADIO", SqlDbType.NVarChar).Value = TXTRADIO.Text
                com.Parameters.Add("@TELTRAB", SqlDbType.NVarChar).Value = TXTTELTRABAJO.Text
                com.Parameters.Add("@RECFACTURA", SqlDbType.NVarChar).Value = CBREQUIEREFACT.Checked
                com.ExecuteNonQuery()
                con.Close()

                con.Open()
                com = New SqlCommand("INSERTARTUTORALUMNO", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@IDTUTOR", SqlDbType.Int).Value = LBLIDTUTOR.Text
                com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = NUEVOALUMNO.TXTMATRICULA.Text
                com.Parameters.Add("@PARENTESCO", SqlDbType.NVarChar).Value = CBOPARENTESCO.Text
                com.ExecuteNonQuery()
                con.Close()

            ElseIf BANDTUTOR = 1 Then
                Dim com As SqlCommand = con.CreateCommand()
                con.Open()
                com = New SqlCommand("ACTDEMASDATOSTUTOR", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@IDTUTOR", SqlDbType.Int).Value = LBLIDTUTOR.Text
                com.Parameters.Add("@SEXO", SqlDbType.NVarChar).Value = CBOSEXO.Text
                com.Parameters.Add("@RFC", SqlDbType.NVarChar).Value = TXTRFC.Text
                com.Parameters.Add("@DEMONSOCIAL", SqlDbType.NVarChar).Value = TXTDENOMSOCIAL.Text
                com.Parameters.Add("@DOMPARTICULAR", SqlDbType.NVarChar).Value = TXTDOMICILIOPART.Text
                com.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = TXTEMAIL.Text
                com.Parameters.Add("@EMAILLAB", SqlDbType.NVarChar).Value = TXTEMAILLAB.Text
                com.Parameters.Add("@TELCASA", SqlDbType.NVarChar).Value = TXTTELCASA.Text
                com.Parameters.Add("@TELCEL", SqlDbType.NVarChar).Value = TXTTELCEL.Text
                com.Parameters.Add("@RADIO", SqlDbType.NVarChar).Value = TXTRADIO.Text
                com.Parameters.Add("@TELTRAB", SqlDbType.NVarChar).Value = TXTTELTRABAJO.Text
                com.Parameters.Add("@RECFACTURA", SqlDbType.NVarChar).Value = CBREQUIEREFACT.Checked
                com.ExecuteNonQuery()
                con.Close()

                con.Open()
                com = New SqlCommand("INSERTARTUTORALUMNO", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@IDTUTOR", SqlDbType.Int).Value = LBLIDTUTOR.Text
                com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
                com.Parameters.Add("@PARENTESCO", SqlDbType.NVarChar).Value = CBOPARENTESCO.Text
                com.ExecuteNonQuery()
                con.Close()
            End If

            DOMPARTUTOR.Close()

            If MsgBox("¿Desea Agregar a otro Tutor?", MsgBoxStyle.YesNo, "Nuevo Tutor") = MsgBoxResult.Yes Then
                LBNOMBRE.Enabled = True
                TXTNOMBRE.Text = ""
                TXTRFC.Text = ""
                TXTDENOMSOCIAL.Text = ""
                TXTDOMICILIOFISCAL.Text = ""
                TXTDOMICILIOPART.Text = ""
                TXTEMAIL.Text = ""
                TXTEMAILLAB.Text = ""
                TXTTELCASA.Text = ""
                TXTTELCEL.Text = ""
                TXTRADIO.Text = ""
                TXTTELTRABAJO.Text = ""

            Else
                MsgBox("Tutor Registrado correctamente", MsgBoxStyle.OkOnly, "Registro Completo")
                My.Forms.NUEVOALUMNO.Close()
                My.Forms.NUEVOALUMNO.Close()
                My.Forms.SELECCIONDEALUMNO.Close()
                Me.Close()

            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub TXTTELCASA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTTELCASA.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub TXTTELCEL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTTELCEL.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TXTTELTRABAJO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTTELTRABAJO.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TXTTELCASA_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXTTELCASA.Leave
        If TXTTELCASA.TextLength > 0 And TXTTELCASA.TextLength < 10 Then
            MsgBox("El telefono debe de estar conformado por 10 digitos", MsgBoxStyle.Critical, "ERROR")
            TXTTELCASA.Focus()
        End If
    End Sub

    Private Sub TXTTELCEL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXTTELCEL.Leave
        If TXTTELCEL.TextLength > 0 And TXTTELCEL.TextLength < 10 Then
            MsgBox("El telefono debe de estar conformado por 10 digitos", MsgBoxStyle.Critical, "ERROR")
            TXTTELCEL.Focus()
        End If
    End Sub

    Private Sub TXTTELTRABAJO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXTTELTRABAJO.Leave
        If TXTTELTRABAJO.TextLength > 0 And TXTTELTRABAJO.TextLength < 10 Then
            MsgBox("El telefono debe de estar conformado por 10 digitos", MsgBoxStyle.Critical, "ERROR")
            TXTTELTRABAJO.Focus()
        End If
    End Sub

    Private Sub TXTRFC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTRFC.TextChanged
        TXTRFC.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TXTDENOMSOCIAL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTDENOMSOCIAL.TextChanged
        TXTDENOMSOCIAL.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        If BANDERA = 1 Or BANDERA = 2 Or BANDERA = 3 Then
            Dim com As SqlCommand = con.CreateCommand()
            con.Open()
            com = New SqlCommand("ELIMINARTUTOR", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDTUT", SqlDbType.Int).Value = LBLIDTUTOR.Text
            com.ExecuteNonQuery()
            con.Close()
            Me.Close()
        End If
        If BANDERA = 4 Then
            NUEVOALUMNO.CMDCANCELAR.Enabled = True
            Me.Close()
        End If

    End Sub
End Class