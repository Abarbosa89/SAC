<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REPORTESACADEMICOS
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
        Me.CMDLISTAALUMNOS = New System.Windows.Forms.Button()
        Me.CMDLISTACUMPLE = New System.Windows.Forms.Button()
        Me.CMDLISTAASISTENCIA = New System.Windows.Forms.Button()
        Me.CMDLISTACORREOS = New System.Windows.Forms.Button()
        Me.CMDSALIR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CMDLISTAALUMNOS
        '
        Me.CMDLISTAALUMNOS.Image = Global.SAC.My.Resources.Resources.REPORTE
        Me.CMDLISTAALUMNOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDLISTAALUMNOS.Location = New System.Drawing.Point(12, 12)
        Me.CMDLISTAALUMNOS.Name = "CMDLISTAALUMNOS"
        Me.CMDLISTAALUMNOS.Size = New System.Drawing.Size(135, 75)
        Me.CMDLISTAALUMNOS.TabIndex = 9
        Me.CMDLISTAALUMNOS.Text = "LISTA ALUMNOS"
        Me.CMDLISTAALUMNOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDLISTAALUMNOS.UseVisualStyleBackColor = True
        '
        'CMDLISTACUMPLE
        '
        Me.CMDLISTACUMPLE.Image = Global.SAC.My.Resources.Resources.REPORTE
        Me.CMDLISTACUMPLE.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDLISTACUMPLE.Location = New System.Drawing.Point(164, 12)
        Me.CMDLISTACUMPLE.Name = "CMDLISTACUMPLE"
        Me.CMDLISTACUMPLE.Size = New System.Drawing.Size(135, 75)
        Me.CMDLISTACUMPLE.TabIndex = 8
        Me.CMDLISTACUMPLE.Text = "LISTA CUMPLEAÑOS"
        Me.CMDLISTACUMPLE.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDLISTACUMPLE.UseVisualStyleBackColor = True
        '
        'CMDLISTAASISTENCIA
        '
        Me.CMDLISTAASISTENCIA.Image = Global.SAC.My.Resources.Resources.REPORTE
        Me.CMDLISTAASISTENCIA.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDLISTAASISTENCIA.Location = New System.Drawing.Point(317, 12)
        Me.CMDLISTAASISTENCIA.Name = "CMDLISTAASISTENCIA"
        Me.CMDLISTAASISTENCIA.Size = New System.Drawing.Size(135, 75)
        Me.CMDLISTAASISTENCIA.TabIndex = 7
        Me.CMDLISTAASISTENCIA.Text = "LISTA ASISTENCIA"
        Me.CMDLISTAASISTENCIA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDLISTAASISTENCIA.UseVisualStyleBackColor = True
        '
        'CMDLISTACORREOS
        '
        Me.CMDLISTACORREOS.Image = Global.SAC.My.Resources.Resources.REPORTE
        Me.CMDLISTACORREOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDLISTACORREOS.Location = New System.Drawing.Point(11, 104)
        Me.CMDLISTACORREOS.Name = "CMDLISTACORREOS"
        Me.CMDLISTACORREOS.Size = New System.Drawing.Size(136, 75)
        Me.CMDLISTACORREOS.TabIndex = 6
        Me.CMDLISTACORREOS.Text = "LISTA CORREOS"
        Me.CMDLISTACORREOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDLISTACORREOS.UseVisualStyleBackColor = True
        '
        'CMDSALIR
        '
        Me.CMDSALIR.BackgroundImage = Global.SAC.My.Resources.Resources.Visualpharm_Must_Have_Log_Out
        Me.CMDSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDSALIR.Location = New System.Drawing.Point(412, 148)
        Me.CMDSALIR.Name = "CMDSALIR"
        Me.CMDSALIR.Size = New System.Drawing.Size(40, 37)
        Me.CMDSALIR.TabIndex = 29
        Me.CMDSALIR.UseVisualStyleBackColor = True
        '
        'REPORTESACADEMICOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 191)
        Me.ControlBox = False
        Me.Controls.Add(Me.CMDSALIR)
        Me.Controls.Add(Me.CMDLISTAALUMNOS)
        Me.Controls.Add(Me.CMDLISTACUMPLE)
        Me.Controls.Add(Me.CMDLISTAASISTENCIA)
        Me.Controls.Add(Me.CMDLISTACORREOS)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "REPORTESACADEMICOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "REPORTES ACADEMICOS"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMDLISTAALUMNOS As System.Windows.Forms.Button
    Friend WithEvents CMDLISTACUMPLE As System.Windows.Forms.Button
    Friend WithEvents CMDLISTAASISTENCIA As System.Windows.Forms.Button
    Friend WithEvents CMDLISTACORREOS As System.Windows.Forms.Button
    Friend WithEvents CMDSALIR As System.Windows.Forms.Button
End Class
