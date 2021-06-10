Imports System.Data.SqlClient
Imports System.Data
Public Class UNIFORMES
    Dim CANTIDAD As Integer
    Dim com As SqlCommand = con.CreateCommand()


    Private Sub UNIFORMES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SACDataSet.SELECCIONARPRINTMAXIMO' table. You can move, or remove it, as needed.
        Try
            Me.SELECCIONARUNIFORMESPORSEXOTableAdapter.Fill(Me.SACDataSet.SELECCIONARUNIFORMESPORSEXO, SELECCIONDEALUMNO.LBLSEXO.Text, New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.SELECCIONARPRINTMAXIMOTableAdapter.Fill(Me.SACDataSet.SELECCIONARPRINTMAXIMO)
        CONTADOR2 = 0
        LBLIDPRINTMAX.Hide()
        LBLIDPRINTNEW.Hide()
        LBLIDPRODUC1.Hide()
        LBLIDPRODUC2.Hide()
        LBLIDPRODUC3.Hide()
        LBLIDPRODUC4.Hide()
        LBLIDPRODUC5.Hide()
        LBLIDPRODUC6.Hide()
        LBLIDPRODUC7.Hide()
        LBLIDPRODUC8.Hide()
        LBLIDPRINTNEW.Text = CInt(LBLIDPRINTMAX.Text) + 1
       
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Try
            CANTIDAD = InputBox("CANTIDAD QUE DESEA DE ESTA PRENDA?", "CANTIDAD", 1)

            If CONTADOR2 > 8 Then
                CONTADOR2 = 0
            Else
                CONTADOR2 = CONTADOR2 + 1
            End If

            If CONTADOR2 = 1 Then
                LBLCONCEPTO1.Text = CBOUNIFORMES.Text
                LBLMONTO1.Text = CDec(LBLMONTOBASE.Text) * CANTIDAD
                LBLMONTO1.Text = FormatCurrency(LBLMONTO1.Text)
                LBLIDPRODUC1.Text = CBOUNIFORMES.SelectedValue
                LBLCANT1.Text = CANTIDAD
                CMDGUARDAR1.Enabled = True
                CMDCANCELAR1.Enabled = True
                LBLTOTAL.Text = CDec(LBLMONTO1.Text) + CDec(LBLTOTAL.Text)
            ElseIf CONTADOR2 = 2 Then
                LBLCONCEPTO2.Text = CBOUNIFORMES.Text
                LBLMONTO2.Text = CDec(LBLMONTOBASE.Text) * CANTIDAD
                LBLMONTO2.Text = FormatCurrency(LBLMONTO2.Text)
                LBLIDPRODUC2.Text = CBOUNIFORMES.SelectedValue
                LBLCANT2.Text = CANTIDAD
                CMDGUARDAR2.Enabled = True
                CMDCANCELAR2.Enabled = True
                LBLTOTAL.Text = CDec(LBLMONTO2.Text) + CDec(LBLTOTAL.Text)
            ElseIf CONTADOR2 = 3 Then
                LBLCONCEPTO3.Text = CBOUNIFORMES.Text
                LBLMONTO3.Text = CDec(LBLMONTOBASE.Text) * CANTIDAD
                LBLMONTO3.Text = FormatCurrency(LBLMONTO3.Text)
                LBLIDPRODUC3.Text = CBOUNIFORMES.SelectedValue
                LBLCANT3.Text = CANTIDAD
                CMDGUARDAR3.Enabled = True
                CMDCANCELAR3.Enabled = True
                LBLTOTAL.Text = CDec(LBLMONTO3.Text) + CDec(LBLTOTAL.Text)
            ElseIf CONTADOR2 = 4 Then
                LBLCONCEPTO4.Text = CBOUNIFORMES.Text
                LBLMONTO4.Text = CDec(LBLMONTOBASE.Text) * CANTIDAD
                LBLMONTO4.Text = FormatCurrency(LBLMONTO4.Text)
                LBLIDPRODUC4.Text = CBOUNIFORMES.SelectedValue
                LBLCANT4.Text = CANTIDAD
                CMDGUARDAR4.Enabled = True
                CMDCANCELAR4.Enabled = True
                LBLTOTAL.Text = CDec(LBLMONTO4.Text) + CDec(LBLTOTAL.Text)
            ElseIf CONTADOR2 = 5 Then
                LBLCONCEPTO5.Text = CBOUNIFORMES.Text
                LBLMONTO5.Text = CDec(LBLMONTOBASE.Text) * CANTIDAD
                LBLMONTO5.Text = FormatCurrency(LBLMONTO5.Text)
                LBLIDPRODUC5.Text = CBOUNIFORMES.SelectedValue
                LBLCANT5.Text = CANTIDAD
                CMDGUARDAR5.Enabled = True
                CMDCANCELAR5.Enabled = True
                LBLTOTAL.Text = CDec(LBLMONTO5.Text) + CDec(LBLTOTAL.Text)
            ElseIf CONTADOR2 = 6 Then
                LBLCONCEPTO6.Text = CBOUNIFORMES.Text
                LBLMONTO6.Text = CDec(LBLMONTOBASE.Text) * CANTIDAD
                LBLMONTO6.Text = FormatCurrency(LBLMONTO6.Text)
                LBLIDPRODUC6.Text = CBOUNIFORMES.SelectedValue
                LBLCANT6.Text = CANTIDAD
                CMDGUARDAR6.Enabled = True
                CMDCANCELAR6.Enabled = True
                LBLTOTAL.Text = CDec(LBLMONTO6.Text) + CDec(LBLTOTAL.Text)
            ElseIf CONTADOR2 = 7 Then
                LBLCONCEPTO7.Text = CBOUNIFORMES.Text
                LBLMONTO7.Text = CDec(LBLMONTOBASE.Text) * CANTIDAD
                LBLMONTO7.Text = FormatCurrency(LBLMONTO7.Text)
                LBLIDPRODUC7.Text = CBOUNIFORMES.SelectedValue
                LBLCANT7.Text = CANTIDAD
                CMDGUARDAR7.Enabled = True
                CMDCANCELAR7.Enabled = True
                LBLTOTAL.Text = CDec(LBLMONTO7.Text) + CDec(LBLTOTAL.Text)
            ElseIf CONTADOR2 = 8 Then
                LBLCONCEPTO8.Text = CBOUNIFORMES.Text
                LBLMONTO8.Text = CDec(LBLMONTOBASE.Text) * CANTIDAD
                LBLMONTO8.Text = FormatCurrency(LBLMONTO8.Text)
                LBLIDPRODUC8.Text = CBOUNIFORMES.SelectedValue
                LBLCANT8.Text = CANTIDAD
                CMDGUARDAR8.Enabled = True
                CMDCANCELAR8.Enabled = True
                LBLTOTAL.Text = CDec(LBLMONTO8.Text) + CDec(LBLTOTAL.Text)
            End If
            CBOUNIFORMES.Enabled = False
            LBLTOTAL.Text = FormatCurrency(LBLTOTAL.Text)
        Catch

        End Try

    End Sub

    Private Sub CMDGUARDAR1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR1.Click
        Try

            con.Open()
            com = New SqlCommand("INSERTARDETALLES", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@CANTI", SqlDbType.Money).Value = LBLCANT1.Text
            com.Parameters.Add("@MONTO", SqlDbType.Money).Value = LBLMONTO1.Text
            com.Parameters.Add("@IDUNIFORM", SqlDbType.Money).Value = CBOUNIFORMES.SelectedValue
            com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.Parameters.Add("@IDPRINT", SqlDbType.Int).Value = LBLIDPRINTNEW.Text
            com.ExecuteNonQuery()
            con.Close()


            con.Open()
            com = New SqlCommand("REGISTRODEACTIVIDAD", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
            com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "REGISTRO DE " & CBOUNIFORMES.Text & "AL ALUMNO " & SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.ExecuteNonQuery()
            con.Close()

            CMDGUARDAR1.Enabled = False
            CMDIMPRIMIR.Enabled = True
            CBOUNIFORMES.Enabled = True
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub CMDGUARDAR2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR2.Click
        Try

            con.Open()
            com = New SqlCommand("INSERTARDETALLES", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@CANTI", SqlDbType.Money).Value = LBLCANT2.Text
            com.Parameters.Add("@MONTO", SqlDbType.Money).Value = LBLMONTO2.Text
            com.Parameters.Add("@IDUNIFORM", SqlDbType.Money).Value = CBOUNIFORMES.SelectedValue
            com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.Parameters.Add("@IDPRINT", SqlDbType.Int).Value = LBLIDPRINTNEW.Text
            com.ExecuteNonQuery()
            con.Close()


            con.Open()
            com = New SqlCommand("REGISTRODEACTIVIDAD", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
            com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "REGISTRO DE " & CBOUNIFORMES.Text & "AL ALUMNO " & SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.ExecuteNonQuery()
            con.Close()

            CMDGUARDAR2.Enabled = False
            CMDIMPRIMIR.Enabled = True
            CBOUNIFORMES.Enabled = True
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub CMDGUARDAR3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR3.Click
        Try

            con.Open()
            com = New SqlCommand("INSERTARDETALLES", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@CANTI", SqlDbType.Money).Value = LBLCANT3.Text
            com.Parameters.Add("@MONTO", SqlDbType.Money).Value = LBLMONTO3.Text
            com.Parameters.Add("@IDUNIFORM", SqlDbType.Money).Value = CBOUNIFORMES.SelectedValue
            com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.Parameters.Add("@IDPRINT", SqlDbType.Int).Value = LBLIDPRINTNEW.Text
            com.ExecuteNonQuery()
            con.Close()


            con.Open()
            com = New SqlCommand("REGISTRODEACTIVIDAD", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
            com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "REGISTRO DE " & CBOUNIFORMES.Text & "AL ALUMNO " & SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.ExecuteNonQuery()
            con.Close()

            CMDGUARDAR3.Enabled = False
            CMDIMPRIMIR.Enabled = True
            CBOUNIFORMES.Enabled = True
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub CMDGUARDAR4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR4.Click
        Try

            con.Open()
            com = New SqlCommand("INSERTARDETALLES", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@CANTI", SqlDbType.Money).Value = LBLCANT4.Text
            com.Parameters.Add("@MONTO", SqlDbType.Money).Value = LBLMONTO4.Text
            com.Parameters.Add("@IDUNIFORM", SqlDbType.Money).Value = CBOUNIFORMES.SelectedValue
            com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.Parameters.Add("@IDPRINT", SqlDbType.Int).Value = LBLIDPRINTNEW.Text
            com.ExecuteNonQuery()
            con.Close()


            con.Open()
            com = New SqlCommand("REGISTRODEACTIVIDAD", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
            com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "REGISTRO DE " & CBOUNIFORMES.Text & "AL ALUMNO " & SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.ExecuteNonQuery()
            con.Close()

            CMDGUARDAR4.Enabled = False
            CMDIMPRIMIR.Enabled = True
            CBOUNIFORMES.Enabled = True
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub CMDGUARDAR5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR5.Click
        Try

            con.Open()
            com = New SqlCommand("INSERTARDETALLES", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@CANTI", SqlDbType.Money).Value = LBLCANT5.Text
            com.Parameters.Add("@MONTO", SqlDbType.Money).Value = LBLMONTO5.Text
            com.Parameters.Add("@IDUNIFORM", SqlDbType.Money).Value = CBOUNIFORMES.SelectedValue
            com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.Parameters.Add("@IDPRINT", SqlDbType.Int).Value = LBLIDPRINTNEW.Text
            com.ExecuteNonQuery()
            con.Close()


            con.Open()
            com = New SqlCommand("REGISTRODEACTIVIDAD", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
            com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "REGISTRO DE " & CBOUNIFORMES.Text & "AL ALUMNO " & SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.ExecuteNonQuery()
            con.Close()

            CMDGUARDAR5.Enabled = False
            CMDIMPRIMIR.Enabled = True
            CBOUNIFORMES.Enabled = True
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub CMDGUARDAR6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR6.Click
        Try

            con.Open()
            com = New SqlCommand("INSERTARDETALLES", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@CANTI", SqlDbType.Money).Value = LBLCANT6.Text
            com.Parameters.Add("@MONTO", SqlDbType.Money).Value = LBLMONTO6.Text
            com.Parameters.Add("@IDUNIFORM", SqlDbType.Money).Value = CBOUNIFORMES.SelectedValue
            com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.Parameters.Add("@IDPRINT", SqlDbType.Int).Value = LBLIDPRINTNEW.Text
            com.ExecuteNonQuery()
            con.Close()


            con.Open()
            com = New SqlCommand("REGISTRODEACTIVIDAD", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
            com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "REGISTRO DE " & CBOUNIFORMES.Text & "AL ALUMNO " & SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.ExecuteNonQuery()
            con.Close()

            CMDGUARDAR6.Enabled = False
            CMDIMPRIMIR.Enabled = True
            CBOUNIFORMES.Enabled = True
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub CMDGUARDAR7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR7.Click
        Try
            con.Open()
            com = New SqlCommand("INSERTARDETALLES", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@CANTI", SqlDbType.Money).Value = LBLCANT7.Text
            com.Parameters.Add("@MONTO", SqlDbType.Money).Value = LBLMONTO7.Text
            com.Parameters.Add("@IDUNIFORM", SqlDbType.Money).Value = CBOUNIFORMES.SelectedValue
            com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.Parameters.Add("@IDPRINT", SqlDbType.Int).Value = LBLIDPRINTNEW.Text
            com.ExecuteNonQuery()
            con.Close()


            con.Open()
            com = New SqlCommand("REGISTRODEACTIVIDAD", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
            com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "REGISTRO DE " & CBOUNIFORMES.Text & "AL ALUMNO " & SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.ExecuteNonQuery()
            con.Close()

            CMDGUARDAR7.Enabled = False
            CMDIMPRIMIR.Enabled = True
            CBOUNIFORMES.Enabled = True
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub CMDGUARDAR8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGUARDAR8.Click
        Try

            con.Open()
            com = New SqlCommand("INSERTARDETALLES", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@CANTI", SqlDbType.Money).Value = LBLCANT8.Text
            com.Parameters.Add("@MONTO", SqlDbType.Money).Value = LBLMONTO8.Text
            com.Parameters.Add("@IDUNIFORM", SqlDbType.Money).Value = CBOUNIFORMES.SelectedValue
            com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.Parameters.Add("@IDPRINT", SqlDbType.Int).Value = LBLIDPRINTNEW.Text
            com.ExecuteNonQuery()
            con.Close()


            con.Open()
            com = New SqlCommand("REGISTRODEACTIVIDAD", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDUS", SqlDbType.Int).Value = Intro.IdusLabel1.Text
            com.Parameters.Add("@ACTIVIDAD", SqlDbType.NVarChar).Value = "REGISTRO DE " & CBOUNIFORMES.Text & "AL ALUMNO " & SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.ExecuteNonQuery()
            con.Close()

            CMDGUARDAR8.Enabled = False
            CMDIMPRIMIR.Enabled = True
            CBOUNIFORMES.Enabled = True
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub CMDCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR.Click
        Try
            con.Open()
            com = New SqlCommand("ELIMINARUNIFORMES", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.Parameters.Add("@FECHA", SqlDbType.Date).Value = CDate(PADRE.TSFECHA.Text)
            com.Parameters.Add("@IDPRINT", SqlDbType.Int).Value = LBLIDPRINTNEW.Text
            com.ExecuteNonQuery()
            con.Close()

            My.Forms.COBROSPRODUCTOS.Show()
            Me.Close()

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub CMDIMPRIMIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDIMPRIMIR.Click

        If CONTADOR = 1 Then
            COBROSPRODUCTOS.LBLMONTO1.Text = LBLTOTAL.Text
            COBROSPRODUCTOS.LBLMONTO1.Text = FormatCurrency(COBROSPRODUCTOS.LBLMONTO1.Text)
            My.Forms.COBROSPRODUCTOS.Show()
            Me.Close()
        ElseIf CONTADOR = 2 Then
            COBROSPRODUCTOS.LBLMONTO2.Text = LBLTOTAL.Text
            COBROSPRODUCTOS.LBLMONTO2.Text = FormatCurrency(COBROSPRODUCTOS.LBLMONTO2.Text)
            My.Forms.COBROSPRODUCTOS.Show()
            Me.Close()
        ElseIf CONTADOR = 3 Then
            COBROSPRODUCTOS.LBLMONTO3.Text = LBLTOTAL.Text
            COBROSPRODUCTOS.LBLMONTO3.Text = FormatCurrency(COBROSPRODUCTOS.LBLMONTO3.Text)
            My.Forms.COBROSPRODUCTOS.Show()
            Me.Close()
        ElseIf CONTADOR = 4 Then
            COBROSPRODUCTOS.LBLMONTO4.Text = LBLTOTAL.Text
            COBROSPRODUCTOS.LBLMONTO4.Text = FormatCurrency(COBROSPRODUCTOS.LBLMONTO4.Text)
            My.Forms.COBROSPRODUCTOS.Show()
            Me.Close()
        ElseIf CONTADOR = 5 Then
            COBROSPRODUCTOS.LBLMONTO5.Text = LBLTOTAL.Text
            COBROSPRODUCTOS.LBLMONTO5.Text = FormatCurrency(COBROSPRODUCTOS.LBLMONTO5.Text)
            My.Forms.COBROSPRODUCTOS.Show()
            Me.Close()
        End If


    End Sub

    Private Sub CMDCANCELAR1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR1.Click
        Try
            LBLTOTAL.Text = CDec(LBLTOTAL.Text) - CDec(LBLMONTO1.Text)
            LBLTOTAL.Text = FormatCurrency(LBLTOTAL.Text)

            con.Open()
            com = New SqlCommand("ELIMINARUNIFORME", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDUNIFORM", SqlDbType.Int).Value = LBLIDPRODUC1.Text
            com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.Parameters.Add("@FECHA", SqlDbType.Date).Value = CDate(PADRE.TSFECHA.Text)
            com.Parameters.Add("@IDPRINT", SqlDbType.Int).Value = LBLIDPRINTNEW.Text
            com.ExecuteNonQuery()
            con.Close()

            LBLCONCEPTO1.Text = ""
            LBLMONTO1.Text = ""
            LBLCANT1.Text = ""
            CBOUNIFORMES.Enabled = True
            CONTADOR2 = 0

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub CMDCANCELAR2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR2.Click
        Try
            LBLTOTAL.Text = CDec(LBLTOTAL.Text) - CDec(LBLMONTO2.Text)
            LBLTOTAL.Text = FormatCurrency(LBLTOTAL.Text)

            con.Open()
            com = New SqlCommand("ELIMINARUNIFORME", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDUNIFORM", SqlDbType.Int).Value = LBLIDPRODUC2.Text
            com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.Parameters.Add("@FECHA", SqlDbType.Date).Value = CDate(PADRE.TSFECHA.Text)
            com.Parameters.Add("@IDPRINT", SqlDbType.Int).Value = LBLIDPRINTNEW.Text
            com.ExecuteNonQuery()
            con.Close()

            LBLCONCEPTO2.Text = ""
            LBLMONTO2.Text = ""
            LBLCANT2.Text = ""
            CBOUNIFORMES.Enabled = True
            CONTADOR2 = 1
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub CMDCANCELAR3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR3.Click
        Try
            LBLTOTAL.Text = CDec(LBLTOTAL.Text) - CDec(LBLMONTO3.Text)
            LBLTOTAL.Text = FormatCurrency(LBLTOTAL.Text)

            con.Open()
            com = New SqlCommand("ELIMINARUNIFORME", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDUNIFORM", SqlDbType.Int).Value = LBLIDPRODUC3.Text
            com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.Parameters.Add("@FECHA", SqlDbType.Date).Value = CDate(PADRE.TSFECHA.Text)
            com.Parameters.Add("@IDPRINT", SqlDbType.Int).Value = LBLIDPRINTNEW.Text
            com.ExecuteNonQuery()
            con.Close()

            LBLCONCEPTO3.Text = ""
            LBLMONTO3.Text = ""
            LBLCANT3.Text = ""
            CBOUNIFORMES.Enabled = True
            CONTADOR2 = 2
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub CMDCANCELAR4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR4.Click
        Try
            LBLTOTAL.Text = CDec(LBLTOTAL.Text) - CDec(LBLMONTO4.Text)
            LBLTOTAL.Text = FormatCurrency(LBLTOTAL.Text)

            con.Open()
            com = New SqlCommand("ELIMINARUNIFORME", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDUNIFORM", SqlDbType.Int).Value = LBLIDPRODUC4.Text
            com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.Parameters.Add("@FECHA", SqlDbType.Date).Value = CDate(PADRE.TSFECHA.Text)
            com.Parameters.Add("@IDPRINT", SqlDbType.Int).Value = LBLIDPRINTNEW.Text
            com.ExecuteNonQuery()
            con.Close()

            LBLCONCEPTO4.Text = ""
            LBLMONTO4.Text = ""
            LBLCANT1.Text = ""
            CBOUNIFORMES.Enabled = True
            CONTADOR2 = 3
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub CMDCANCELAR5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR5.Click
        Try
            LBLTOTAL.Text = CDec(LBLTOTAL.Text) - CDec(LBLMONTO5.Text)
            LBLTOTAL.Text = FormatCurrency(LBLTOTAL.Text)

            con.Open()
            com = New SqlCommand("ELIMINARUNIFORME", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDUNIFORM", SqlDbType.Int).Value = LBLIDPRODUC5.Text
            com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.Parameters.Add("@FECHA", SqlDbType.Date).Value = CDate(PADRE.TSFECHA.Text)
            com.Parameters.Add("@IDPRINT", SqlDbType.Int).Value = LBLIDPRINTNEW.Text
            com.ExecuteNonQuery()
            con.Close()

            LBLCONCEPTO5.Text = ""
            LBLMONTO5.Text = ""
            LBLCANT5.Text = ""
            CBOUNIFORMES.Enabled = True
            CONTADOR2 = 4
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub CMDCANCELAR6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR6.Click
        Try
            LBLTOTAL.Text = CDec(LBLTOTAL.Text) - CDec(LBLMONTO6.Text)
            LBLTOTAL.Text = FormatCurrency(LBLTOTAL.Text)

            con.Open()
            com = New SqlCommand("ELIMINARUNIFORME", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDUNIFORM", SqlDbType.Int).Value = LBLIDPRODUC6.Text
            com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.Parameters.Add("@FECHA", SqlDbType.Date).Value = CDate(PADRE.TSFECHA.Text)
            com.Parameters.Add("@IDPRINT", SqlDbType.Int).Value = LBLIDPRINTNEW.Text
            com.ExecuteNonQuery()
            con.Close()

            LBLCONCEPTO6.Text = ""
            LBLMONTO6.Text = ""
            LBLCANT6.Text = ""
            CBOUNIFORMES.Enabled = True
            CONTADOR2 = 5
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub CMDCANCELAR7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR7.Click
        Try
            LBLTOTAL.Text = CDec(LBLTOTAL.Text) - CDec(LBLMONTO7.Text)
            LBLTOTAL.Text = FormatCurrency(LBLTOTAL.Text)

            con.Open()
            com = New SqlCommand("ELIMINARUNIFORME", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDUNIFORM", SqlDbType.Int).Value = LBLIDPRODUC7.Text
            com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.Parameters.Add("@FECHA", SqlDbType.Date).Value = CDate(PADRE.TSFECHA.Text)
            com.Parameters.Add("@IDPRINT", SqlDbType.Int).Value = LBLIDPRINTNEW.Text
            com.ExecuteNonQuery()
            con.Close()

            LBLCONCEPTO7.Text = ""
            LBLMONTO7.Text = ""
            LBLCANT7.Text = ""
            CBOUNIFORMES.Enabled = True
            CONTADOR2 = 6
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub CMDCANCELAR8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCELAR8.Click
        Try
            LBLTOTAL.Text = CDec(LBLTOTAL.Text) - CDec(LBLMONTO8.Text)
            LBLTOTAL.Text = FormatCurrency(LBLTOTAL.Text)

            con.Open()
            com = New SqlCommand("ELIMINARUNIFORME", con)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@IDUNIFORM", SqlDbType.Int).Value = LBLIDPRODUC8.Text
            com.Parameters.Add("@MATRI", SqlDbType.Int).Value = SELECCIONDEALUMNO.CBOALUMNO.SelectedValue
            com.Parameters.Add("@FECHA", SqlDbType.Date).Value = CDate(PADRE.TSFECHA.Text)
            com.Parameters.Add("@IDPRINT", SqlDbType.Int).Value = LBLIDPRINTNEW.Text
            com.ExecuteNonQuery()
            con.Close()

            LBLCONCEPTO8.Text = ""
            LBLMONTO8.Text = ""
            LBLCANT8.Text = ""
            CBOUNIFORMES.Enabled = True
            CONTADOR2 = 7
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub CBOUNIFORMES_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOUNIFORMES.SelectedIndexChanged
        CMDIMPRIMIR.Enabled = False
    End Sub

    Private Sub CMDIMPRIMIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDIMPRIMIT.Click
        My.Forms.RELACIONUNIFORMESS.MdiParent = PADRE
        My.Forms.RELACIONUNIFORMESS.Show()
    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.SELECCIONARUNIFORMESPORSEXOTableAdapter.Fill(Me.SACDataSet.SELECCIONARUNIFORMESPORSEXO, SELECCIONDEALUMNO.LBLSEXO.Text, New System.Nullable(Of Integer)(CType(PADRE.LBLIDCICLO.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class