Imports System.Data.SqlClient
Imports System.Data
Public Class NUEVOALUMNO


    Private Property TXTTIPOBECA As Object

    Private Sub LBNOMBRE_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LBNOMBRE.LinkClicked
        My.Forms.DATOSPERALUMNO.MdiParent = PADRE
        My.Forms.DATOSPERALUMNO.Show()
    End Sub

    Private Sub NUEVOALUMNO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARCICLOS' table. You can move, or remove it, as needed.
        Me.SELECCIONARCICLOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARCICLOS)
        'TODO: This line of code loads data into the 'SACDataSet.SELECIONARNIVEL' table. You can move, or remove it, as needed.
        Me.SELECIONARNIVELTableAdapter.Fill(Me.SACDataSet.SELECIONARNIVEL)
        BANDTUTOR = 0
        Try
            'Con esto traemos la ultima matricula creada
            Me.NUEVAMATRICULATableAdapter.Fill(Me.SACDataSet.NUEVAMATRICULA)
            LBLMATRI.Hide()
            'Se suma 1 a la ultima matricula creada y procede a crear el registro
            TXTMATRICULA.Text = CInt(LBLMATRI.Text) + 1
            Dim com As SqlCommand = con.CreateCommand()
            con.Open()
            com = New SqlCommand("NUEVOINGRESO", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = TXTMATRICULA.Text
            com.ExecuteNonQuery()
            con.Close()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub CMDGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR.Click
        Try
            If TXTNOMBRE.Text = "" Then
                MsgBox("PORFAVOR ASIGNE EL NOMBRE DEL ALUMNO", MsgBoxStyle.Exclamation, "ATENCION")
            ElseIf TXTDOMPARTICULA.Text = "" Then
                MsgBox("PORFAVOR ASIGNE EL DOMICILIO DEL ALUMNO", MsgBoxStyle.Exclamation, "ATENCION")
            ElseIf CBOSEXO.Text = "" Then
                MsgBox("PORFAVOR ASIGNE EL SEXO DEL ALUMNO", MsgBoxStyle.Exclamation, "ATENCION")
            ElseIf TXTTELCASA.Text = "" And TXTTELCEL.Text = "" Then
                MsgBox("PORFAVOR DEBE AL MENOS INGRESAR UN TELEFONO", MsgBoxStyle.Exclamation, "ATENCION")
            ElseIf CBOGRADO.Text = "" Or CBOGRUPO.Text = "" Or CBONIVEL.Text = "" Then
                MsgBox("PORFAVOR ASIGNE EL GRUPO", MsgBoxStyle.Exclamation, "ATENCION")
            Else
                'Actualizamos los datos del alumno mediante su matricula
                Dim com As SqlCommand = con.CreateCommand()
                con.Open()
                com = New SqlCommand("ACTDATOSALUMNO", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = TXTMATRICULA.Text
                com.Parameters.Add("@DIA", SqlDbType.Int).Value = CBODIA.Text
                com.Parameters.Add("@MES", SqlDbType.NVarChar).Value = CBOMES.Text
                com.Parameters.Add("@AÑO", SqlDbType.Int).Value = CBOAÑO.Text
                com.Parameters.Add("@LUGARNAC", SqlDbType.NVarChar).Value = TXTLUGARNAC.Text
                com.Parameters.Add("@SEXO", SqlDbType.NVarChar).Value = CBOSEXO.Text
                com.Parameters.Add("@CURP", SqlDbType.NVarChar).Value = TXTCURP.Text
                com.Parameters.Add("@DOMPARTICULAR", SqlDbType.NVarChar).Value = TXTDOMPARTICULA.Text
                com.Parameters.Add("@TELCEL", SqlDbType.NVarChar).Value = TXTTELCEL.Text
                com.Parameters.Add("@TELCASA", SqlDbType.NVarChar).Value = TXTTELCASA.Text
                com.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = TXTEMAIL.Text
                com.ExecuteNonQuery()
                con.Close()

                'Registramos el Grupo al que el alumno ira
                con.Open()
                com = New SqlCommand("REISTRODEGRUPO", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@IDNIVEL", SqlDbType.Int).Value = CBOGRADO.SelectedValue
                com.Parameters.Add("@GRADO", SqlDbType.NVarChar).Value = CBOGRADO.Text
                com.Parameters.Add("@GRUPO", SqlDbType.NVarChar).Value = CBOGRUPO.Text
                com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = TXTMATRICULA.Text
                com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = CBOCICLO.SelectedValue
                com.ExecuteNonQuery()
                con.Close()

                'Registra la actividad a la tabla REGISTROUSUARIOS
                con.Open()
                com = New SqlCommand("REGISTRODEACTIVIDAD", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "REGISTRO ALUMNO CON MATRICULA " & TXTMATRICULA.Text
                com.ExecuteNonQuery()
                con.Close()
                'Cerramos las formas para llenar datos externos
                DATOSPERALUMNO.Close()
                DOMPARTALUMNO.Close()
                'Colocamos todo en "SOLO LECTURA" para ya no modificar nada
                TXTLUGARNAC.ReadOnly = True
                TXTLUGARNAC.BackColor = Color.Gold
                CBOSEXO.Enabled = False
                CBOGRADO.Enabled = False
                CBONIVEL.Enabled = False
                CBOGRUPO.Enabled = False
                TXTTELCASA.ReadOnly = True
                TXTTELCASA.BackColor = Color.Gold
                TXTTELCEL.ReadOnly = True
                TXTTELCEL.BackColor = Color.Gold
                TXTCURP.ReadOnly = True
                TXTCURP.BackColor = Color.Gold
                TXTEMAIL.ReadOnly = True
                TXTEMAIL.BackColor = Color.Gold
                CMDGUARDAR.Enabled = False
                CMDCANCELAR.Enabled = False
                LBNOMBRE.Enabled = False
                LinkLabel1.Enabled = False

                'Mostramos la forma para registrar al tutor
                My.Forms.NUEVOTUTOR.MdiParent = PADRE
                My.Forms.NUEVOTUTOR.Show()
                Me.Hide()
            End If
            'En caso de error nos arrojara dicho error
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try


    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        Try
            'Para eliminar el registro creado en caso de cancelar 
            Dim com As SqlCommand = con.CreateCommand()
            con.Open()
            com = New SqlCommand("ELIMINARALUMNO", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = TXTMATRICULA.Text
            com.ExecuteNonQuery()
            con.Close()
            'My.Forms.ESCOLARES.MdiParent = PADRE
            'My.Forms.ESCOLARES.Show()
            Me.Close()
        Catch
            con.Close()
        End Try


    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        My.Forms.DOMPARTALUMNO.MdiParent = PADRE
        My.Forms.DOMPARTALUMNO.Show()
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


    Private Sub TXTTELCASA_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXTTELCASA.Leave
        If TXTTELCASA.TextLength > 0 And TXTTELCASA.TextLength < 10 Then
            MsgBox("El telefono debe de estar conformado por 10 digitos", MsgBoxStyle.Critical, "ERROR")
            TXTTELCASA.Focus()
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



    Private Sub TXTTELCEL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXTTELCEL.Leave
        If TXTTELCEL.TextLength > 0 And TXTTELCEL.TextLength < 10 Then
            MsgBox("El telefono debe de estar conformado por 10 digitos", MsgBoxStyle.Critical, "ERROR")
            TXTTELCEL.Focus()
        End If

    End Sub

    Private Sub TXTLUGARNAC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTLUGARNAC.TextChanged
        TXTLUGARNAC.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TXTCURP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTCURP.TextChanged
        TXTCURP.CharacterCasing = CharacterCasing.Upper
    End Sub


    Private Sub CBONIVEL_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBONIVEL.SelectedIndexChanged
        Try
            Me.SELECIONARGRADOTableAdapter.Fill(Me.SACDataSet.SELECIONARGRADO, CBONIVEL.SelectedValue)
        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub TXTTELCEL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTTELCEL.TextChanged

    End Sub
End Class