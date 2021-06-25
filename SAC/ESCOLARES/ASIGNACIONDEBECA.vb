Imports System.Data.SqlClient
Imports System.Data
Public Class ASIGNACIONDEBECA
    Dim PORCE As Decimal
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBMATRICULA.CheckedChanged
        If RBMATRICULA.Checked = True Then
            GBDATOS.Visible = True
            TXTMATRICULA.Visible = True
            GBBECA.Visible = True
            CMDCONFIRMAR.Visible = True
            NOMALUMNOTextBox.Visible = True
        Else

            GBDATOS.Visible = False
            TXTMATRICULA.Visible = False
            CMDCONFIRMAR.Visible = False
            NOMALUMNOTextBox.Visible = False

            CBOPORCENTAJE.Enabled = False
            CMDGUARDAR.Enabled = False
        End If
    End Sub

    Private Sub RBNOMBRE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBNOMBRE.CheckedChanged
        If RBNOMBRE.Checked = True Then
            Me.SELECCIONARESCOLARIDADTableAdapter.Fill(Me.SACDataSet.SELECCIONARESCOLARIDAD)
            GBDATOS.Visible = True
            CBOALUMNOS.Visible = True
            CBOESCOLARIDAD.Visible = True
            ALUMNOTextBox.Visible = True
            GBBECA.Visible = True
        Else
            GBDATOS.Visible = False
            CBOALUMNOS.Visible = False
            ALUMNOTextBox.Visible = False

            CBOPORCENTAJE.Enabled = False
            CMDGUARDAR.Enabled = False
            CBOESCOLARIDAD.Visible = False
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub TXTMATRICULA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTMATRICULA.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub



    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        My.Forms.ADMINISTRATIVO.MdiParent = PADRE
        My.Forms.ADMINISTRATIVO.Show()
        Me.Close()
    End Sub

    Private Sub CMDGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR.Click
        Try
            Dim com As SqlCommand = con.CreateCommand()
            If RBMATRICULA.Checked = True Then
                If RBBECAINTERNA.Checked = True Then

                    con.Open()
                    com = New SqlCommand("ASIGNARBECA", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = TXTMATRICULA.Text
                    com.Parameters.Add("@BECA", SqlDbType.Bit).Value = 1
                    com.Parameters.Add("@TIPOBECA", SqlDbType.NVarChar).Value = ""
                    com.Parameters.Add("@PORCENTAJE", SqlDbType.Real).Value = LBLPORCENTAJE.Text
                    com.ExecuteNonQuery()
                    con.Close()

                ElseIf RBBECASEP.Checked = True Then

                    con.Open()
                    com = New SqlCommand("ASIGNARBECASEP", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = TXTMATRICULA.Text
                    com.Parameters.Add("@BECA", SqlDbType.Bit).Value = 1
                    com.Parameters.Add("@PORCENTAJE", SqlDbType.Real).Value = LBLPORCENTAJE.Text
                    com.ExecuteNonQuery()
                    con.Close()

                ElseIf RBBECAINSCRI.Checked = True Then

                    con.Open()
                    com = New SqlCommand("ASIGNARBECAINSCR", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = TXTMATRICULA.Text
                    com.Parameters.Add("@BECA", SqlDbType.Bit).Value = 1
                    com.Parameters.Add("@PORCENTAJE", SqlDbType.Real).Value = LBLPORCENTAJE.Text
                    com.ExecuteNonQuery()
                    con.Close()
                End If

                If CBOPORCENTAJE.Text = "OTRO" Then
                    con.Open()
                    com = New SqlCommand("REGISTRODEACTIVIDAD", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                    com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "ASIGNO BECA " & " DEL " & PORCE & "% AL ALUMNO CON MATRICULA " & TXTMATRICULA.Text
                    com.ExecuteNonQuery()
                    con.Close()
                Else
                    con.Open()
                    com = New SqlCommand("REGISTRODEACTIVIDAD", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                    com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "ASIGNO BECA " & " DEL " & CBOPORCENTAJE.Text & "% AL ALUMNO CON MATRICULA " & TXTMATRICULA.Text
                    com.ExecuteNonQuery()
                    con.Close()
                End If

                MsgBox("BECA ASIGNADA", MsgBoxStyle.Information, "CONFIRMACION")
                My.Forms.ADMINISTRATIVO.MdiParent = PADRE
                My.Forms.ADMINISTRATIVO.Show()
                Me.Close()

            End If

            If RBNOMBRE.Checked = True Then

                If RBBECAINTERNA.Checked = True Then

                    con.Open()
                    com = New SqlCommand("ASIGNARBECA", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = CBOALUMNOS.SelectedValue
                    com.Parameters.Add("@BECA", SqlDbType.Bit).Value = 1
                    com.Parameters.Add("@TIPOBECA", SqlDbType.NVarChar).Value = ""
                    com.Parameters.Add("@PORCENTAJE", SqlDbType.Real).Value = LBLPORCENTAJE.Text
                    com.ExecuteNonQuery()
                    con.Close()

                ElseIf RBBECASEP.Checked = True Then

                    con.Open()
                    com = New SqlCommand("ASIGNARBECASEP", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = CBOALUMNOS.SelectedValue
                    com.Parameters.Add("@BECA", SqlDbType.Bit).Value = 1
                    com.Parameters.Add("@PORCENTAJE", SqlDbType.Real).Value = LBLPORCENTAJE.Text
                    com.ExecuteNonQuery()
                    con.Close()

                ElseIf RBBECAINSCRI.Checked = True Then

                    con.Open()
                    com = New SqlCommand("ASIGNARBECAINSCR", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = CBOALUMNOS.SelectedValue
                    com.Parameters.Add("@BECA", SqlDbType.Bit).Value = 1
                    com.Parameters.Add("@PORCENTAJE", SqlDbType.Real).Value = LBLPORCENTAJE.Text
                    com.ExecuteNonQuery()
                    con.Close()

                End If

                If CBOPORCENTAJE.Text = "OTRO" Then
                    con.Open()
                    com = New SqlCommand("REGISTRODEACTIVIDAD", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                    com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "ASIGNO BECA " & " DEL " & PORCE & "% AL ALUMNO CON MATRICULA " & CBOALUMNOS.SelectedValue
                    com.ExecuteNonQuery()
                    con.Close()
                Else
                    con.Open()
                    com = New SqlCommand("REGISTRODEACTIVIDAD", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                    com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "ASIGNO BECA " & " DEL " & CBOPORCENTAJE.Text & "% AL ALUMNO CON MATRICULA " & CBOALUMNOS.SelectedValue
                    com.ExecuteNonQuery()
                    con.Close()
                End If

                MsgBox("BECA ASIGNADA", MsgBoxStyle.Information, "CONFIRMACION")
                My.Forms.ADMINISTRATIVO.MdiParent = PADRE
                My.Forms.ADMINISTRATIVO.Show()
                Me.Close()


            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub ASIGNACIONDEBECA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'GPINSCRIPCIONES.Hide()
        'GPMENSUALIDADES.Hide()
        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARESCOLARIDAD' table. You can move, or remove it, as needed.
        Me.SELECCIONARESCOLARIDADTableAdapter.Fill(Me.SACDataSet.SELECCIONARESCOLARIDAD)

        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARALUMNOSATIVOS' table. You can move, or remove it, as needed.
        LBLPORCENTAJE.Hide()


    End Sub

    Private Sub CMDCONFIRMAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCONFIRMAR.Click
        Try
            Me.SELECCIONARALUMNOPORMATRICULATableAdapter.Fill(Me.SACDataSet.SELECCIONARALUMNOPORMATRICULA, New System.Nullable(Of Integer)(CType(TXTMATRICULA.Text, Integer)))

            Try
                Me.MESESABONADOSPARABECASEPTableAdapter.Fill(Me.SACDataSet.MESESABONADOSPARABECASEP, New System.Nullable(Of Integer)(CType(TXTMATRICULA.Text, Integer)))
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

            Try
                Me.MESESLIQUIDADOSPARABECASEPTableAdapter.Fill(Me.SACDataSet.MESESLIQUIDADOSPARABECASEP, New System.Nullable(Of Integer)(CType(TXTMATRICULA.Text, Integer)))
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

            Try
                Me.INCRIPCIONABONADASBECASEPTableAdapter.Fill(Me.SACDataSet.INCRIPCIONABONADASBECASEP, New System.Nullable(Of Integer)(CType(TXTMATRICULA.Text, Integer)))
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

            Try
                Me.INCRIPCIONLIQUIDADABECASEPTableAdapter.Fill(Me.SACDataSet.INCRIPCIONLIQUIDADABECASEP, New System.Nullable(Of Integer)(CType(TXTMATRICULA.Text, Integer)))
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try


            CBOPORCENTAJE.Enabled = True
            CMDGUARDAR.Enabled = True
        Catch ex As System.Exception
            MsgBox("MATRICULA NO EXISTENTE", MsgBoxStyle.Critical, "ERROR")
            TXTMATRICULA.Focus()
            con.Close()
        End Try
        

    End Sub

  

    Private Sub CBOPORCENTAJE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOPORCENTAJE.SelectedIndexChanged
        If CBOPORCENTAJE.Text = "OTRO" Then

            PORCE = InputBox("PORCENTA DE BECA?", "PORCENTAJE BECA", 0)
            LBLPORCENTAJE.Text = PORCE / 100
        Else
            LBLPORCENTAJE.Text = CDec(CBOPORCENTAJE.Text) / 100
            CBOPORCENTAJE.Text = CBOPORCENTAJE.Text & "%"
        End If
        
    End Sub

    Private Sub CBOALUMNOS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOALUMNOS.SelectedIndexChanged

        CBOPORCENTAJE.Enabled = True
        CMDGUARDAR.Enabled = True
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOESCOLARIDAD.SelectedIndexChanged
        Try
            Me.SELECCIONARALUMNOSATIVOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARALUMNOSATIVOS, CBOESCOLARIDAD.SelectedValue, New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub CBOALUMNOS_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBOALUMNOS.Validated
        Try
            Me.MESESABONADOSPARABECASEPTableAdapter.Fill(Me.SACDataSet.MESESABONADOSPARABECASEP, New System.Nullable(Of Integer)(CType(CBOALUMNOS.SelectedValue, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Try
            Me.MESESLIQUIDADOSPARABECASEPTableAdapter.Fill(Me.SACDataSet.MESESLIQUIDADOSPARABECASEP, New System.Nullable(Of Integer)(CType(CBOALUMNOS.SelectedValue, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Try
            Me.INCRIPCIONABONADASBECASEPTableAdapter.Fill(Me.SACDataSet.INCRIPCIONABONADASBECASEP, New System.Nullable(Of Integer)(CType(CBOALUMNOS.SelectedValue, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Try
            Me.INCRIPCIONLIQUIDADABECASEPTableAdapter.Fill(Me.SACDataSet.INCRIPCIONLIQUIDADABECASEP, New System.Nullable(Of Integer)(CType(CBOALUMNOS.SelectedValue, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RBBECAINTERNA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBBECAINTERNA.CheckedChanged

        CBOPORCENTAJE.Items.Clear()
        CBOPORCENTAJE.Items.Add("10")
        CBOPORCENTAJE.Items.Add("20")
        CBOPORCENTAJE.Items.Add("30")
        CBOPORCENTAJE.Items.Add("40")
        CBOPORCENTAJE.Items.Add("50")
        CBOPORCENTAJE.Items.Add("60")
        CBOPORCENTAJE.Items.Add("70")
        CBOPORCENTAJE.Items.Add("OTRO")


    End Sub

    Private Sub RBBECASEP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBBECASEP.CheckedChanged
        CBOPORCENTAJE.Items.Clear()
        CBOPORCENTAJE.Items.Add("5")
        CBOPORCENTAJE.Items.Add("10")
        CBOPORCENTAJE.Items.Add("15")
        CBOPORCENTAJE.Items.Add("20")
        CBOPORCENTAJE.Items.Add("25")
        CBOPORCENTAJE.Items.Add("30")
        CBOPORCENTAJE.Items.Add("35")
        CBOPORCENTAJE.Items.Add("40")
        CBOPORCENTAJE.Items.Add("45")
        CBOPORCENTAJE.Items.Add("50")
        CBOPORCENTAJE.Items.Add("55")
        CBOPORCENTAJE.Items.Add("60")
        CBOPORCENTAJE.Items.Add("OTRO")
    End Sub

    Private Sub RBBECAINSCRI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBBECAINSCRI.CheckedChanged
        CBOPORCENTAJE.Items.Clear()
        CBOPORCENTAJE.Items.Add("10")
        CBOPORCENTAJE.Items.Add("20")
        CBOPORCENTAJE.Items.Add("30")
        CBOPORCENTAJE.Items.Add("40")
        CBOPORCENTAJE.Items.Add("50")
        CBOPORCENTAJE.Items.Add("OTRO")
    End Sub
End Class