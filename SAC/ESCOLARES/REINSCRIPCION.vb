Imports System.Data.SqlClient
Imports System.Data
Public Class REINSCRIPCION

    Private Sub REINSCRIPCION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARESCOLARIDAD' table. You can move, or remove it, as needed.
        Me.SELECCIONARESCOLARIDADTableAdapter.Fill(Me.SACDataSet.SELECCIONARESCOLARIDAD)
        MatriLabel1.Hide()
        LBLMENSAJE.Hide()
        ReprobadoCheckBox.Hide()

    End Sub


    Private Sub CBOESCOLARIDAD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOESCOLARIDAD.SelectedIndexChanged
        Try
            Me.SELECCIONARALUMNOSINACTIVOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARALUMNOSINACTIVOS, CBOESCOLARIDAD.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LBLMENSAJE.ForeColor = Color.Gold

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        LBLMENSAJE.ForeColor = Color.Black

    End Sub

    Private Sub CBOALUMNO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOALUMNO.SelectedIndexChanged
        Try
            Me.SELECCIONARALUMNOTableAdapter.Fill(Me.SACDataSet.SELECCIONARALUMNO, New System.Nullable(Of Integer)(CType(CBOALUMNO.SelectedValue, Integer)))
            CMDREINSCRIBIR.Visible = True

            If LugnacTextBox.Text = "" Or EmailTextBox.Text = "" Or TelcasaTextBox.Text = "" Or TelcelTextBox.Text = "" Then
                Timer1.Enabled = True
                Timer2.Enabled = True
                LBLMENSAJE.Show()
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CMDREINSCRIBIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDREINSCRIBIR.Click
        Try
            Dim com As SqlCommand = con.CreateCommand()
            If ReprobadoCheckBox.Checked = True Then

                con.Open()
                com = New SqlCommand("REINSCRIBIRALUMNO", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = MatriLabel1.Text
                com.ExecuteNonQuery()
                con.Close()


                con.Open()
                com = New SqlCommand("REGISTRODEACTIVIDAD", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "REINSCRIPCION DE ALUMNO MATRICULA " & MatriLabel1.Text
                com.ExecuteNonQuery()
                con.Close()

            Else

                con.Open()
                com = New SqlCommand("REINSCRIBIRALUMNO", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = MatriLabel1.Text
                com.ExecuteNonQuery()
                con.Close()

                Select Case CBOESCOLARIDAD.Text

                    Case "PRE1"
                        con.Open()
                        com = New SqlCommand("REINSCRIBIRALUMNOGRUPO", con)
                        com.CommandType = CommandType.StoredProcedure
                        com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = MatriLabel1.Text
                        com.Parameters.Add("@IDNIVEL", SqlDbType.Int).Value = 2
                        com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 2
                        com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                        com.Parameters.Add("@CILOANT", SqlDbType.NVarChar).Value = PADRE.LBLCICLO.Text
                        com.ExecuteNonQuery()
                        con.Close()
                    Case "PRE2"
                        con.Open()
                        com = New SqlCommand("REINSCRIBIRALUMNOGRUPO", con)
                        com.CommandType = CommandType.StoredProcedure
                        com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = MatriLabel1.Text
                        com.Parameters.Add("@IDNIVEL", SqlDbType.Int).Value = 3
                        com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 3
                        com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                        com.Parameters.Add("@CILOANT", SqlDbType.NVarChar).Value = PADRE.LBLCICLO.Text
                        com.ExecuteNonQuery()
                        con.Close()

                    Case "PRE3"
                        con.Open()
                        com = New SqlCommand("REINSCRIBIRALUMNOGRUPO", con)
                        com.CommandType = CommandType.StoredProcedure
                        com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = MatriLabel1.Text
                        com.Parameters.Add("@IDNIVEL", SqlDbType.Int).Value = 4
                        com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 1
                        com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                        com.Parameters.Add("@CILOANT", SqlDbType.NVarChar).Value = PADRE.LBLCICLO.Text
                        com.ExecuteNonQuery()
                        con.Close()
                    Case "PRIM1"
                        con.Open()
                        com = New SqlCommand("REINSCRIBIRALUMNOGRUPO", con)
                        com.CommandType = CommandType.StoredProcedure
                        com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = MatriLabel1.Text
                        com.Parameters.Add("@IDNIVEL", SqlDbType.Int).Value = 5
                        com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 2
                        com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                        com.Parameters.Add("@CILOANT", SqlDbType.NVarChar).Value = PADRE.LBLCICLO.Text
                        com.ExecuteNonQuery()
                        con.Close()
                    Case "PRIM2"
                        con.Open()
                        com = New SqlCommand("REINSCRIBIRALUMNOGRUPO", con)
                        com.CommandType = CommandType.StoredProcedure
                        com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = MatriLabel1.Text
                        com.Parameters.Add("@IDNIVEL", SqlDbType.Int).Value = 6
                        com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 3
                        com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                        com.Parameters.Add("@CILOANT", SqlDbType.NVarChar).Value = PADRE.LBLCICLO.Text
                        com.ExecuteNonQuery()
                        con.Close()
                    Case "PRIM3"
                        con.Open()
                        com = New SqlCommand("REINSCRIBIRALUMNOGRUPO", con)
                        com.CommandType = CommandType.StoredProcedure
                        com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = MatriLabel1.Text
                        com.Parameters.Add("@IDNIVEL", SqlDbType.Int).Value = 7
                        com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 4
                        com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                        com.Parameters.Add("@CILOANT", SqlDbType.NVarChar).Value = PADRE.LBLCICLO.Text
                        com.ExecuteNonQuery()
                        con.Close()
                    Case "PRIM4"
                        con.Open()
                        com = New SqlCommand("REINSCRIBIRALUMNOGRUPO", con)
                        com.CommandType = CommandType.StoredProcedure
                        com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = MatriLabel1.Text
                        com.Parameters.Add("@IDNIVEL", SqlDbType.Int).Value = 8
                        com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 5
                        com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                        com.Parameters.Add("@CILOANT", SqlDbType.NVarChar).Value = PADRE.LBLCICLO.Text
                        com.ExecuteNonQuery()
                        con.Close()
                    Case "PRIM5"
                        con.Open()
                        com = New SqlCommand("REINSCRIBIRALUMNOGRUPO", con)
                        com.CommandType = CommandType.StoredProcedure
                        com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = MatriLabel1.Text
                        com.Parameters.Add("@IDNIVEL", SqlDbType.Int).Value = 9
                        com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 6
                        com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                        com.Parameters.Add("@CILOANT", SqlDbType.NVarChar).Value = PADRE.LBLCICLO.Text
                        com.ExecuteNonQuery()
                        con.Close()
                    Case "PRIM6"
                        con.Open()
                        com = New SqlCommand("REINSCRIBIRALUMNOGRUPO", con)
                        com.CommandType = CommandType.StoredProcedure
                        com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = MatriLabel1.Text
                        com.Parameters.Add("@IDNIVEL", SqlDbType.Int).Value = 10
                        com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 1
                        com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                        com.Parameters.Add("@CILOANT", SqlDbType.NVarChar).Value = PADRE.LBLCICLO.Text
                        com.ExecuteNonQuery()
                        con.Close()
                    Case "SEC1"
                        con.Open()
                        com = New SqlCommand("REINSCRIBIRALUMNOGRUPO", con)
                        com.CommandType = CommandType.StoredProcedure
                        com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = MatriLabel1.Text
                        com.Parameters.Add("@IDNIVEL", SqlDbType.Int).Value = 11
                        com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 2
                        com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                        com.Parameters.Add("@CILOANT", SqlDbType.NVarChar).Value = PADRE.LBLCICLO.Text
                        com.ExecuteNonQuery()
                        con.Close()
                    Case "SEC2"
                        con.Open()
                        com = New SqlCommand("REINSCRIBIRALUMNOGRUPO", con)
                        com.CommandType = CommandType.StoredProcedure
                        com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = MatriLabel1.Text
                        com.Parameters.Add("@IDNIVEL", SqlDbType.Int).Value = 12
                        com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 3
                        com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                        com.Parameters.Add("@CILOANT", SqlDbType.NVarChar).Value = PADRE.LBLCICLO.Text
                        com.ExecuteNonQuery()
                        con.Close()
                    Case "SEC3"
                        con.Open()
                        com = New SqlCommand("REINSCRIBIRALUMNOGRUPO", con)
                        com.CommandType = CommandType.StoredProcedure
                        com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = MatriLabel1.Text
                        com.Parameters.Add("@IDNIVEL", SqlDbType.Int).Value = 12
                        com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 3
                        com.ExecuteNonQuery()
                        con.Close()
                End Select

                con.Open()
                com = New SqlCommand("REGISTRODEACTIVIDAD", con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
                com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "REINSCRIPCION DE ALUMNO MATRICULA " & MatriLabel1.Text
                com.ExecuteNonQuery()
                con.Close()
            End If

            MsgBox("ALUMNO REINSCRITO SATISFACTORIAMENTE", MsgBoxStyle.Information, "GRACIAS")
            My.Forms.ESCOLARES.MdiParent = PADRE
            My.Forms.ESCOLARES.Show()
            Me.Close()

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        My.Forms.ESCOLARES.MdiParent = PADRE
        My.Forms.ESCOLARES.Show()
        Me.Close()
    End Sub

End Class