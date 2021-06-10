Public Class REIMPRESIONRECFOL
    Dim BANDERA As Integer = 0
    Private Sub REIMPRESIONRECFOL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Intro.IdRangoLabel1.Text < 2 Then
            DTHASTA.Visible = True
            DTDESDE.Visible = True
            BANDERA = 2
        Else
            BANDERA = 1
            DTHASTA.Visible = False
            DTDESDE.Visible = False
        End If

        Try
            Me.SELCCIONARMOVPARAREIMPRSIONTableAdapter.Fill(Me.SACDataSet.SELCCIONARMOVPARAREIMPRSION, New System.Nullable(Of Integer)(CType(BANDERA, Integer)), New System.Nullable(Of Date)(CType(PADRE.TSFECHA.Text, Date)), New System.Nullable(Of Date)(CType(DTDESDE.Value, Date)), New System.Nullable(Of Date)(CType(DTHASTA.Value, Date)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        LBLNUMFOLIO.Hide()
        LBLNUMRECIBO.Hide()
    End Sub

    Private Sub CDMCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CDMCERRAR.Click
        Me.Close()
    End Sub

    Private Sub DTDESDE_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTDESDE.ValueChanged
        Try
            Me.SELCCIONARMOVPARAREIMPRSIONTableAdapter.Fill(Me.SACDataSet.SELCCIONARMOVPARAREIMPRSION, New System.Nullable(Of Integer)(CType(BANDERA, Integer)), New System.Nullable(Of Date)(CType(PADRE.TSFECHA.Text, Date)), New System.Nullable(Of Date)(CType(DTDESDE.Value, Date)), New System.Nullable(Of Date)(CType(DTHASTA.Value, Date)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DTHASTA_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTHASTA.ValueChanged
        Try
            Me.SELCCIONARMOVPARAREIMPRSIONTableAdapter.Fill(Me.SACDataSet.SELCCIONARMOVPARAREIMPRSION, New System.Nullable(Of Integer)(CType(BANDERA, Integer)), New System.Nullable(Of Date)(CType(PADRE.TSFECHA.Text, Date)), New System.Nullable(Of Date)(CType(DTDESDE.Value, Date)), New System.Nullable(Of Date)(CType(DTHASTA.Value, Date)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CMDREIMPRESION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDREIMPRESION.Click
        If LBLNUMFOLIO.Text = 0 Then
            If LBLNUMRECIBO.Text = 0 Then
                MsgBox("SELECCIONE EL REGISTRO QUE DESEA REIMPRIMIR")
            Else
                My.Forms.REIMPRESIONRECIBOPRODUCTOSS.MdiParent = PADRE
                My.Forms.REIMPRESIONRECIBOPRODUCTOSS.Show()
                Me.Hide()
            End If
        Else
            My.Forms.REIMPRSIONRECIBOCOLEGIATURAA.MdiParent = PADRE
            My.Forms.REIMPRSIONRECIBOCOLEGIATURAA.Show()
            Me.Hide()
        End If
    End Sub
End Class