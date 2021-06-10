<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ESCOLARES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ESCOLARES))
        Me.CMDCUOTASYPAGOS = New System.Windows.Forms.Button()
        Me.CMDINSCRIPCION = New System.Windows.Forms.Button()
        Me.CMDSALIR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CMDCUOTASYPAGOS
        '
        Me.CMDCUOTASYPAGOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCUOTASYPAGOS.Image = Global.SAC.My.Resources.Resources.Aha_Soft_Business_Toolbar_Payment
        Me.CMDCUOTASYPAGOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCUOTASYPAGOS.Location = New System.Drawing.Point(195, 28)
        Me.CMDCUOTASYPAGOS.Name = "CMDCUOTASYPAGOS"
        Me.CMDCUOTASYPAGOS.Size = New System.Drawing.Size(105, 62)
        Me.CMDCUOTASYPAGOS.TabIndex = 10
        Me.CMDCUOTASYPAGOS.Text = "COBROS"
        Me.CMDCUOTASYPAGOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCUOTASYPAGOS.UseVisualStyleBackColor = True
        '
        'CMDINSCRIPCION
        '
        Me.CMDINSCRIPCION.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CMDINSCRIPCION.Image = Global.SAC.My.Resources.Resources.Deleket_Soft_Scraps_User_Group
        Me.CMDINSCRIPCION.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDINSCRIPCION.Location = New System.Drawing.Point(65, 28)
        Me.CMDINSCRIPCION.Name = "CMDINSCRIPCION"
        Me.CMDINSCRIPCION.Size = New System.Drawing.Size(105, 62)
        Me.CMDINSCRIPCION.TabIndex = 9
        Me.CMDINSCRIPCION.Text = "ALUMNOS"
        Me.CMDINSCRIPCION.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDINSCRIPCION.UseVisualStyleBackColor = True
        '
        'CMDSALIR
        '
        Me.CMDSALIR.BackgroundImage = Global.SAC.My.Resources.Resources.Visualpharm_Must_Have_Log_Out
        Me.CMDSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDSALIR.Location = New System.Drawing.Point(327, 80)
        Me.CMDSALIR.Name = "CMDSALIR"
        Me.CMDSALIR.Size = New System.Drawing.Size(40, 37)
        Me.CMDSALIR.TabIndex = 11
        Me.CMDSALIR.UseVisualStyleBackColor = True
        '
        'ESCOLARES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 129)
        Me.ControlBox = False
        Me.Controls.Add(Me.CMDSALIR)
        Me.Controls.Add(Me.CMDCUOTASYPAGOS)
        Me.Controls.Add(Me.CMDINSCRIPCION)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ESCOLARES"
        Me.Text = "ESCOLARES"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMDINSCRIPCION As System.Windows.Forms.Button
    Friend WithEvents CMDCUOTASYPAGOS As System.Windows.Forms.Button
    Friend WithEvents CMDSALIR As System.Windows.Forms.Button
End Class
