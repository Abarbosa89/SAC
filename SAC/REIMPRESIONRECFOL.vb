Imports System.Data
Imports System.Data.SqlClient
Public Class REIMPRESIONRECFOL
    Dim BANDERA As Integer = 0
    Dim sSQL As String = ""
    Dim dtDatos As DataTable
    Dim oParam(1) As SqlParameter
    Private Sub REIMPRESIONRECFOL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        If Intro.IdRangoLabel1.Text < 2 Then
            BANDERA = 2
        Else
            BANDERA = 1
        End If

        DTHASTA.Value = Now
        DTDESDE.Value = Now

        dtDatos = New DataTable

        oParam(0) = New SqlParameter("@FECHAINI", DTDESDE.Value)
        oParam(1) = New SqlParameter("@FECHAFIN", DTHASTA.Value)

        dtDatos = sqlServer.ExecSPReturnDT("spsMovimientosReimpresion", oParam)

        dgvDatos.DataSource = dtDatos
        dgvDatos.Refresh()


        'Try
        '    Me.SELCCIONARMOVPARAREIMPRSIONTableAdapter.Fill(Me.SACDataSet.SELCCIONARMOVPARAREIMPRSION, New System.Nullable(Of Integer)(CType(BANDERA, Integer)), New System.Nullable(Of Date)(CType(PADRE.TSFECHA.Text, Date)), New System.Nullable(Of Date)(CType(DTDESDE.Value, Date)), New System.Nullable(Of Date)(CType(DTHASTA.Value, Date)))
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub CDMCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CDMCERRAR.Click
        Me.Close()
    End Sub

    Private Sub DTDESDE_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTDESDE.ValueChanged
        'Try
        '    Me.SELCCIONARMOVPARAREIMPRSIONTableAdapter.Fill(Me.SACDataSet.SELCCIONARMOVPARAREIMPRSION, New System.Nullable(Of Integer)(CType(BANDERA, Integer)), New System.Nullable(Of Date)(CType(PADRE.TSFECHA.Text, Date)), New System.Nullable(Of Date)(CType(DTDESDE.Value, Date)), New System.Nullable(Of Date)(CType(DTHASTA.Value, Date)))
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

        If DTDESDE.Value > DTHASTA.Value Then
            Exit Sub
        End If
        dtDatos = New DataTable

        oParam(0) = New SqlParameter("@FECHAINI", DTDESDE.Value)
        oParam(1) = New SqlParameter("@FECHAFIN", DTHASTA.Value)

        dtDatos = sqlServer.ExecSPReturnDT("spsMovimientosReimpresion", oParam)

        dgvDatos.DataSource = dtDatos
        dgvDatos.Refresh()

    End Sub

    Private Sub DTHASTA_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTHASTA.ValueChanged
        'Try
        '    Me.SELCCIONARMOVPARAREIMPRSIONTableAdapter.Fill(Me.SACDataSet.SELCCIONARMOVPARAREIMPRSION, New System.Nullable(Of Integer)(CType(BANDERA, Integer)), New System.Nullable(Of Date)(CType(PADRE.TSFECHA.Text, Date)), New System.Nullable(Of Date)(CType(DTDESDE.Value, Date)), New System.Nullable(Of Date)(CType(DTHASTA.Value, Date)))
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try
        If DTHASTA.Value > DTDESDE.Value Then
            Exit Sub
        End If

        dtDatos = New DataTable

        oParam(0) = New SqlParameter("@FECHAINI", DTDESDE.Value)
        oParam(1) = New SqlParameter("@FECHAFIN", DTHASTA.Value)

        dtDatos = sqlServer.ExecSPReturnDT("spsMovimientosReimpresion", oParam)

        dgvDatos.DataSource = dtDatos
        dgvDatos.Refresh()

    End Sub

    Private Sub CMDREIMPRESION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDREIMPRESION.Click
        'If SELCCIONARMOVPARAREIMPRSIONDataGridView.RowCount > 0 Then
        '    If LBLNUMFOLIO.Text = 0 Then
        '        If LBLNUMRECIBO.Text = 0 Then
        '            MsgBox("SELECCIONE EL REGISTRO QUE DESEA REIMPRIMIR")
        '        Else
        '            My.Forms.REIMPRESIONRECIBOPRODUCTOSS.ShowDialog()

        '        End If
        '    Else
        '        My.Forms.REIMPRSIONRECIBOCOLEGIATURAA.ShowDialog()

        '    End If
        'End If

        If dgvDatos.Rows.Count > 0 Then
            If dgvDatos.CurrentRow.Cells(6).Value = 2 Then
                LBLNUMFOLIO.Text = dgvDatos.CurrentRow.Cells(4).Value
                My.Forms.REIMPRSIONRECIBOCOLEGIATURAA.ShowDialog()
            ElseIf dgvDatos.CurrentRow.Cells(6).Value = 1 Then
                LBLNUMRECIBO.Text = dgvDatos.CurrentRow.Cells(4).Value
                My.Forms.REIMPRESIONRECIBOPRODUCTOSS.ShowDialog()
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim frmVisRep As New REPORTEGENERAL
        Dim rptTicket As New RECIBODETICKETS
        Dim dtDatos As New DataTable

        If dgvDatos.CurrentRow.Cells(6).Value = 2 Then
            dtDatos = ReimpresionTicket(dgvDatos.CurrentRow.Cells(4).Value, 2)
        ElseIf dgvDatos.CurrentRow.Cells(6).Value = 1 Then
            dtDatos = ReimpresionTicket(dgvDatos.CurrentRow.Cells(4).Value, 1)
        End If

        rptTicket.SetDataSource(dtDatos)
        rptTicket.PrintOptions.PrinterName = ImpTicketGLOBAL
        rptTicket.PrintToPrinter(1, False, 0, 0)

        'frmVisRep.CrystalReportViewer1.ReportSource = rptTicket
        'frmVisRep.Text = "REIMPRESION DE TICKET"
        'frmVisRep.ShowDialog()
        'frmVisRep = Nothing
    End Sub
End Class