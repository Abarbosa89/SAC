Imports System.Data.SqlClient
Imports System.Data

Public Class REINSCRIBIRGRUPO
    Dim ESCOLARIDAD As String
    Dim GRADOS As String
    Private Sub REINSCRIBIRGRUPO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARESCOLARIDAD' table. You can move, or remove it, as needed.
        Me.SELECCIONARESCOLARIDADTableAdapter.Fill(Me.SACDataSet.SELECCIONARESCOLARIDAD)
        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARCICLOS' table. You can move, or remove it, as needed.
        Me.SELECCIONARCICLOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARCICLOS)
        GPO2.Text = "CICLO ESCOLAR " & PADRE.LBLCICLO.Text
    End Sub




    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles CMDGRUPO.Click
        Try
            Dim com As SqlCommand = con.CreateCommand()

            con.Open()
            com = New SqlCommand("[CREACIONTABLAALUMNOSACTIVOSREINS]", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = CBOCICLOESCOLAR.SelectedValue
            com.Parameters.Add("@ESCOLARIDAD", SqlDbType.NVarChar).Value = CBOGRADO.Text
            com.ExecuteNonQuery()
            con.Close()


            Select Case CBOGRADO.Text
                Case "MAT1"
                    con.Open()
                    com = New SqlCommand("ACTUALIZARREINSCRIPCIONGRUPO", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                    com.Parameters.Add("@IDGRADO", SqlDbType.Int).Value = 1
                    com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 1
                    com.ExecuteNonQuery()
                    con.Close()
                    ESCOLARIDAD = "PRE1"
                Case "PRE1"
                    con.Open()
                    com = New SqlCommand("ACTUALIZARREINSCRIPCIONGRUPO", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                    com.Parameters.Add("@IDGRADO", SqlDbType.Int).Value = 2
                    com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 2
                    com.ExecuteNonQuery()
                    con.Close()
                    ESCOLARIDAD = "PRE2"
                Case "PRE2"
                    con.Open()
                    com = New SqlCommand("ACTUALIZARREINSCRIPCIONGRUPO", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                    com.Parameters.Add("@IDGRADO", SqlDbType.Int).Value = 3
                    com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 3
                    com.ExecuteNonQuery()
                    con.Close()
                    ESCOLARIDAD = "PRE3"
                Case "PRE3"
                    con.Open()
                    com = New SqlCommand("ACTUALIZARREINSCRIPCIONGRUPO", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                    com.Parameters.Add("@IDGRADO", SqlDbType.Int).Value = 4
                    com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 1
                    com.ExecuteNonQuery()
                    con.Close()
                    ESCOLARIDAD = "PRIM1"
                Case "PRIM1"
                    con.Open()
                    com = New SqlCommand("ACTUALIZARREINSCRIPCIONGRUPO", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                    com.Parameters.Add("@IDGRADO", SqlDbType.Int).Value = 5
                    com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 2
                    com.ExecuteNonQuery()
                    con.Close()
                    ESCOLARIDAD = "PRIM2"

                Case "PRIM2"
                    con.Open()
                    com = New SqlCommand("ACTUALIZARREINSCRIPCIONGRUPO", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                    com.Parameters.Add("@IDGRADO", SqlDbType.Int).Value = 6
                    com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 3
                    com.ExecuteNonQuery()
                    con.Close()
                    ESCOLARIDAD = "PRIM3"
                Case "PRIM3"
                    con.Open()
                    com = New SqlCommand("ACTUALIZARREINSCRIPCIONGRUPO", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                    com.Parameters.Add("@IDGRADO", SqlDbType.Int).Value = 7
                    com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 4
                    com.ExecuteNonQuery()
                    con.Close()
                    ESCOLARIDAD = "PRIM4"
                Case "PRIM4"
                    con.Open()
                    com = New SqlCommand("ACTUALIZARREINSCRIPCIONGRUPO", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                    com.Parameters.Add("@@IDGRADO", SqlDbType.Int).Value = 8
                    com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 5
                    com.ExecuteNonQuery()
                    con.Close()
                    ESCOLARIDAD = "PRIM5"
                Case "PRIM5"
                    con.Open()
                    com = New SqlCommand("ACTUALIZARREINSCRIPCIONGRUPO", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                    com.Parameters.Add("@@IDGRADO", SqlDbType.Int).Value = 9
                    com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 6
                    com.ExecuteNonQuery()
                    con.Close()
                    ESCOLARIDAD = "PRIM6"
                Case "PRIM6"
                    con.Open()
                    com = New SqlCommand("ACTUALIZARREINSCRIPCIONGRUPO", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                    com.Parameters.Add("@@IDGRADO", SqlDbType.Int).Value = 10
                    com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 1
                    com.ExecuteNonQuery()
                    con.Close()
                    ESCOLARIDAD = "SEC1"
                Case "SEC1"
                    con.Open()
                    com = New SqlCommand("ACTUALIZARREINSCRIPCIONGRUPO", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                    com.Parameters.Add("@IDGRADO", SqlDbType.Int).Value = 11
                    com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 2
                    com.ExecuteNonQuery()
                    con.Close()
                    ESCOLARIDAD = "SEC2"
                Case "SEC2"
                    con.Open()
                    com = New SqlCommand("ACTUALIZARREINSCRIPCIONGRUPO", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                    com.Parameters.Add("@IDGRADO", SqlDbType.Int).Value = 12
                    com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 3
                    com.ExecuteNonQuery()
                    con.Close()
                    ESCOLARIDAD = "SEC3"
                Case "SEC3"
                    con.Open()
                    com = New SqlCommand("ACTUALIZARREINSCRIPCIONGRUPO", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                    com.Parameters.Add("@IDGRADO", SqlDbType.Int).Value = 14
                    com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 0
                    com.ExecuteNonQuery()
                    con.Close()
                    ESCOLARIDAD = "GRADUADOS"
            End Select

            con.Open()
            com = New SqlCommand("INSERTARGRUPOENGRUPOS", con)
            com.CommandType = CommandType.StoredProcedure
            com.ExecuteNonQuery()
            con.Close()

            con.Open()
            com = New SqlCommand("TRUNCARGRUPOSTEMPORALES", con)
            com.CommandType = CommandType.StoredProcedure
            com.ExecuteNonQuery()
            con.Close()

            Me.SELECCIONARALUMNOSREINSCRITOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARALUMNOSREINSCRITOS, ESCOLARIDAD, New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))
            Me.SELECCIONARALUMNOSACTIVOS2TableAdapter.Fill(Me.SACDataSet.SELECCIONARALUMNOSACTIVOS2, GRADOS, New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))
            If MsgBox("GRUPO REINSCRITO DESEA REINSCRIBIR OTRO GRUPO?", MsgBoxStyle.YesNo, "ATENCION") = MsgBoxResult.Yes Then
                CMDINDIVIDUAL.Enabled = False
                CMDGRUPO.Enabled = False
                CBOCICLOESCOLAR.Enabled = True
                CBOGRADO.Enabled = True
                Button3.Enabled = True
            Else
                Me.Close()
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try

    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Try
            Me.SELECCIONARALUMNOSATIVOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARALUMNOSATIVOS, CBOGRADO.Text, New System.Nullable(Of Integer)(CType(CBOCICLOESCOLAR.SelectedValue, Integer)))
            CMDINDIVIDUAL.Enabled = True
            CMDGRUPO.Enabled = True
           

            Select Case CBOGRADO.Text
                Case "MAT1"
                    GRADOS = "PRE1"
                Case "PRE1"
                    GRADOS = "PRE2"
                Case "PRE2"
                    GRADOS = "PRE3"
                Case "PRE3"
                    GRADOS = "PRIM1"
                Case "PRIM1"
                    GRADOS = "PRIM2"
                Case "PRIM2"
                    GRADOS = "PRIM3"
                Case "PRIM3"
                    GRADOS = "PRIM4"
                Case "PRIM4"
                    GRADOS = "PRIM5"
                Case "PRIM5"
                    GRADOS = "PRIM6"
                Case "PRIM6"
                    GRADOS = "SEC1"
                Case "SEC1"
                    GRADOS = "SEC2"
                Case "SEC2"
                    GRADOS = "SEC3"
                Case "SEC3"
                    GRADOS = "GRADUADO"
            End Select


            Me.SELECCIONARALUMNOSACTIVOS2TableAdapter.Fill(Me.SACDataSet.SELECCIONARALUMNOSACTIVOS2, GRADOS, New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CMDINDIVIDUAL_Click(sender As System.Object, e As System.EventArgs) Handles CMDINDIVIDUAL.Click
        Try
            Dim com As SqlCommand = con.CreateCommand()
            Select Case CBOGRADO.Text

                Case "MAT1"
                    con.Open()
                    com = New SqlCommand("REINSCRIBIRALUMNOGRUPO", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = MatriLabel1.Text
                    com.Parameters.Add("@IDNIVEL", SqlDbType.Int).Value = 1
                    com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 1
                    com.Parameters.Add("@IDCICLO", SqlDbType.Int).Value = PADRE.LBLIDCICLO.Text
                    com.Parameters.Add("@CILOANT", SqlDbType.NVarChar).Value = PADRE.LBLCICLO.Text
                    com.ExecuteNonQuery()
                    con.Close()
                    ESCOLARIDAD = "PRE1"
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
                    ESCOLARIDAD = "PRE2"
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
                    ESCOLARIDAD = "PRE3"
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
                    ESCOLARIDAD = "PRIM1"
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
                    ESCOLARIDAD = "PRIM2"
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
                    ESCOLARIDAD = "PRIM3"
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
                    ESCOLARIDAD = "PRIM4"
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
                    ESCOLARIDAD = "PRIM5"
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
                    ESCOLARIDAD = "PRIM6"
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
                    ESCOLARIDAD = "SEC1"
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
                    ESCOLARIDAD = "SEC2"
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
                    ESCOLARIDAD = "SEC3"
                Case "SEC3"
                    con.Open()
                    com = New SqlCommand("REINSCRIBIRALUMNOGRUPO", con)
                    com.CommandType = CommandType.StoredProcedure
                    com.Parameters.Add("@MATRICULA", SqlDbType.Int).Value = MatriLabel1.Text
                    com.Parameters.Add("@IDNIVEL", SqlDbType.Int).Value = 14
                    com.Parameters.Add("@GRADO", SqlDbType.Int).Value = 0
                    com.ExecuteNonQuery()
                    con.Close()
                    ESCOLARIDAD = "GRADUADOS"
            End Select

            Me.SELECCIONARALUMNOSREINSCRITOSTableAdapter.Fill(Me.SACDataSet.SELECCIONARALUMNOSREINSCRITOS, ESCOLARIDAD, New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))
            Me.SELECCIONARALUMNOSACTIVOS2TableAdapter.Fill(Me.SACDataSet.SELECCIONARALUMNOSACTIVOS2, GRADOS, New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))
            If MsgBox("ALUMNO REINSCRITO DESEA REINSCRIBIR OTRO ALUMNO?", MsgBoxStyle.YesNo, "ATENCION") = MsgBoxResult.Yes Then
                CMDINDIVIDUAL.Enabled = False
                CMDGRUPO.Enabled = False
                CBOCICLOESCOLAR.Enabled = True
                CBOGRADO.Enabled = True
                Button3.Enabled = True
            Else
                Me.Close()
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      

    End Sub
End Class