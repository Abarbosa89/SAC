<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SELECCIONARMES
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CBOMES = New System.Windows.Forms.ComboBox()
        Me.CMDSALIR = New System.Windows.Forms.Button()
        Me.CDMREPORTE = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CBOMES
        '
        Me.CBOMES.DisplayMember = "escolaridad"
        Me.CBOMES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOMES.FormattingEnabled = True
        Me.CBOMES.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.CBOMES.Location = New System.Drawing.Point(53, 12)
        Me.CBOMES.Name = "CBOMES"
        Me.CBOMES.Size = New System.Drawing.Size(230, 26)
        Me.CBOMES.TabIndex = 29
        Me.CBOMES.ValueMember = "idgrado"
        '
        'CMDSALIR
        '
        Me.CMDSALIR.BackgroundImage = Global.SAC.My.Resources.Resources.Visualpharm_Must_Have_Log_Out
        Me.CMDSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDSALIR.Location = New System.Drawing.Point(266, 90)
        Me.CMDSALIR.Name = "CMDSALIR"
        Me.CMDSALIR.Size = New System.Drawing.Size(40, 37)
        Me.CMDSALIR.TabIndex = 31
        Me.CMDSALIR.UseVisualStyleBackColor = True
        '
        'CDMREPORTE
        '
        Me.CDMREPORTE.Image = Global.SAC.My.Resources.Resources.REPORTE_PRELIMINAR
        Me.CDMREPORTE.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CDMREPORTE.Location = New System.Drawing.Point(79, 60)
        Me.CDMREPORTE.Name = "CDMREPORTE"
        Me.CDMREPORTE.Size = New System.Drawing.Size(136, 61)
        Me.CDMREPORTE.TabIndex = 30
        Me.CDMREPORTE.Text = "VER REPORTE"
        Me.CDMREPORTE.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CDMREPORTE.UseVisualStyleBackColor = True
        '
        'SELECCIONARMES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 143)
        Me.ControlBox = False
        Me.Controls.Add(Me.CMDSALIR)
        Me.Controls.Add(Me.CDMREPORTE)
        Me.Controls.Add(Me.CBOMES)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "SELECCIONARMES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SELECCIONARMES"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMDSALIR As System.Windows.Forms.Button
    Friend WithEvents CDMREPORTE As System.Windows.Forms.Button
    Friend WithEvents CBOMES As System.Windows.Forms.ComboBox
End Class
