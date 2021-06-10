Imports System.Data.SqlClient
Imports System.Data
Public Class MODIFICARALUMNO

    Private Sub MODIFICARALUMNO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARESCOLARIDAD' table. You can move, or remove it, as needed.
        Me.SELECCIONARESCOLARIDADTableAdapter.Fill(Me.SACDataSet.SELECCIONARESCOLARIDAD)


        GPOTROSDATO.Hide()
        GPDATOSPERS.Hide()

        CMDGUARDAR.Hide()

        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARALUMNOSATIVOS' table. You can move, or remove it, as needed.



    End Sub


    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If SELECCIONARALUMNOSACTIVOSYINACTIVOSBindingSource.Count = 0 Then
            MsgBox("PORFACOR SELECCIONE EL NIVEL", MsgBoxStyle.Information, "AVISO")
        Else
            CBOALUMNO.Enabled = False
            GPOTROSDATO.Show()
            GPDATOSPERS.Show()
            CMDGUARDAR.Show()
            CMDCANCELAR.Show()
        End If
      
    End Sub

    Private Sub CMDEDITAR1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEDITAR1.Click
        NombreTextBox.ReadOnly = False
        NombreTextBox.BackColor = Color.White
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AppatTextBox.ReadOnly = False
        AppatTextBox.BackColor = Color.White
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ApmatTextBox.ReadOnly = False
        ApmatTextBox.BackColor = Color.White
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        SexoTextBox.ReadOnly = False
        SexoTextBox.BackColor = Color.White
    End Sub




    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        LugnacTextBox.ReadOnly = False
        LugnacTextBox.BackColor = Color.White
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        CurpTextBox.ReadOnly = False
        CurpTextBox.BackColor = Color.White
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        DompartTextBox.ReadOnly = False
        DompartTextBox.BackColor = Color.White
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TelcelTextBox.ReadOnly = False
        TelcelTextBox.BackColor = Color.White
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        TelcasaTextBox.ReadOnly = False
        TelcasaTextBox.BackColor = Color.White
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        EmailTextBox.ReadOnly = False
        EmailTextBox.BackColor = Color.White
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TXTDIA.ReadOnly = False
        TXTMES.ReadOnly = False
        TXTAÑO.ReadOnly = False
        TXTDIA.BackColor = Color.White
        TXTMES.BackColor = Color.White
        TXTAÑO.BackColor = Color.White


    End Sub



    Private Sub CMDGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR.Click
        Try
            Dim com As SqlCommand = con.CreateCommand()
            con.Open()
            com = New SqlCommand("MODIFICARALUMNO", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = NombreTextBox.Text
            com.Parameters.Add("@APPATERNO", SqlDbType.NVarChar).Value = AppatTextBox.Text
            com.Parameters.Add("@APMATERNO", SqlDbType.NVarChar).Value = ApmatTextBox.Text
            com.Parameters.Add("@DIA", SqlDbType.Int).Value = TXTDIA.Text
            com.Parameters.Add("@MES", SqlDbType.NVarChar).Value = TXTMES.Text
            com.Parameters.Add("@AÑO", SqlDbType.Int).Value = TXTAÑO.Text
            com.Parameters.Add("@LUGARNAC", SqlDbType.NVarChar).Value = LugnacTextBox.Text
            com.Parameters.Add("@SEXO", SqlDbType.NVarChar).Value = SexoTextBox.Text
            com.Parameters.Add("@CURP", SqlDbType.NVarChar).Value = CurpTextBox.Text
            com.Parameters.Add("@DOMPART", SqlDbType.NVarChar).Value = DompartTextBox.Text
            com.Parameters.Add("@TELCEL", SqlDbType.NVarChar).Value = TelcelTextBox.Text
            com.Parameters.Add("@TELCASA", SqlDbType.NVarChar).Value = TelcasaTextBox.Text
            com.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = EmailTextBox.Text
            com.Parameters.Add("@ACTIVO", SqlDbType.Bit).Value = ActivoCheckBox.Checked
            com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = CBOALUMNO.SelectedValue
            com.ExecuteNonQuery()
            con.Close()

            con.Open()
            com = New SqlCommand("REGISTRODEACTIVIDAD", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
            com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "MODIFICO AL ALUMNO CON MATRICULA " & CBOALUMNO.SelectedValue
            com.ExecuteNonQuery()
            con.Close()

            MsgBox("ALUMNO MODIFICADO", MsgBoxStyle.Information, "CONFIRMACION")
            CBOALUMNO.Enabled = True
            GPOTROSDATO.Hide()
            GPDATOSPERS.Hide()
            CMDGUARDAR.Hide()
            CMDCANCELAR.Show()


        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ActivoCheckBox.Enabled = True
    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click

        My.Forms.ADMINISTRATIVO.MdiParent = PADRE
        My.Forms.ADMINISTRATIVO.Show()
        Me.Close()

    End Sub


    Private Sub CBOESCOLARIDAD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOESCOLARIDAD.SelectedIndexChanged
        Try
            Me.SELECCIONARALUMNOSACTIVOSYINACTIVOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARALUMNOSACTIVOSYINACTIVOS, New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)), CBOESCOLARIDAD.SelectedValue)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub CBOALUMNO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOALUMNO.SelectedIndexChanged
        Try
            Me.SELECCIONARALUMNOTableAdapter.Fill(Me.SACDataSet.SELECCIONARALUMNO, New System.Nullable(Of Integer)(CType(CBOALUMNO.SelectedValue, Integer)))
        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.SELECCIONARALUMNOSACTIVOSYINACTIVOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARALUMNOSACTIVOSYINACTIVOS, New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)), CBOESCOLARIDAD.SelectedValue)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class