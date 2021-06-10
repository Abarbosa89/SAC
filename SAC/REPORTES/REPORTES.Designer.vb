<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REPORTES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REPORTES))
        Me.CMDCOSTOS = New System.Windows.Forms.Button()
        Me.CMDBECASASIGNADAS = New System.Windows.Forms.Button()
        Me.CMDPEDIDOUNIFORM = New System.Windows.Forms.Button()
        Me.CMDSALIR = New System.Windows.Forms.Button()
        Me.CMDPIDENFACTURA = New System.Windows.Forms.Button()
        Me.CMDACTUSUARIO = New System.Windows.Forms.Button()
        Me.CMDCORTESEMANAL = New System.Windows.Forms.Button()
        Me.CMDCORTEDIARIO = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CMDCOSTOS
        '
        Me.CMDCOSTOS.Image = CType(resources.GetObject("CMDCOSTOS.Image"), System.Drawing.Image)
        Me.CMDCOSTOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCOSTOS.Location = New System.Drawing.Point(262, 107)
        Me.CMDCOSTOS.Name = "CMDCOSTOS"
        Me.CMDCOSTOS.Size = New System.Drawing.Size(109, 80)
        Me.CMDCOSTOS.TabIndex = 15
        Me.CMDCOSTOS.Text = "COSTOS "
        Me.CMDCOSTOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCOSTOS.UseVisualStyleBackColor = True
        '
        'CMDBECASASIGNADAS
        '
        Me.CMDBECASASIGNADAS.Image = CType(resources.GetObject("CMDBECASASIGNADAS.Image"), System.Drawing.Image)
        Me.CMDBECASASIGNADAS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDBECASASIGNADAS.Location = New System.Drawing.Point(136, 107)
        Me.CMDBECASASIGNADAS.Name = "CMDBECASASIGNADAS"
        Me.CMDBECASASIGNADAS.Size = New System.Drawing.Size(109, 80)
        Me.CMDBECASASIGNADAS.TabIndex = 14
        Me.CMDBECASASIGNADAS.Text = "BECAS ASIGNADAS"
        Me.CMDBECASASIGNADAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDBECASASIGNADAS.UseVisualStyleBackColor = True
        '
        'CMDPEDIDOUNIFORM
        '
        Me.CMDPEDIDOUNIFORM.Image = CType(resources.GetObject("CMDPEDIDOUNIFORM.Image"), System.Drawing.Image)
        Me.CMDPEDIDOUNIFORM.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDPEDIDOUNIFORM.Location = New System.Drawing.Point(12, 107)
        Me.CMDPEDIDOUNIFORM.Name = "CMDPEDIDOUNIFORM"
        Me.CMDPEDIDOUNIFORM.Size = New System.Drawing.Size(109, 80)
        Me.CMDPEDIDOUNIFORM.TabIndex = 13
        Me.CMDPEDIDOUNIFORM.Text = "PEDIDOS UNIFORMES"
        Me.CMDPEDIDOUNIFORM.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDPEDIDOUNIFORM.UseVisualStyleBackColor = True
        '
        'CMDSALIR
        '
        Me.CMDSALIR.BackgroundImage = Global.SAC.My.Resources.Resources.Visualpharm_Must_Have_Log_Out
        Me.CMDSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDSALIR.Location = New System.Drawing.Point(465, 156)
        Me.CMDSALIR.Name = "CMDSALIR"
        Me.CMDSALIR.Size = New System.Drawing.Size(40, 37)
        Me.CMDSALIR.TabIndex = 12
        Me.CMDSALIR.UseVisualStyleBackColor = True
        '
        'CMDPIDENFACTURA
        '
        Me.CMDPIDENFACTURA.Image = CType(resources.GetObject("CMDPIDENFACTURA.Image"), System.Drawing.Image)
        Me.CMDPIDENFACTURA.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDPIDENFACTURA.Location = New System.Drawing.Point(387, 12)
        Me.CMDPIDENFACTURA.Name = "CMDPIDENFACTURA"
        Me.CMDPIDENFACTURA.Size = New System.Drawing.Size(109, 80)
        Me.CMDPIDENFACTURA.TabIndex = 5
        Me.CMDPIDENFACTURA.Text = "PIDEN FACTURA"
        Me.CMDPIDENFACTURA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDPIDENFACTURA.UseVisualStyleBackColor = True
        '
        'CMDACTUSUARIO
        '
        Me.CMDACTUSUARIO.Image = CType(resources.GetObject("CMDACTUSUARIO.Image"), System.Drawing.Image)
        Me.CMDACTUSUARIO.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDACTUSUARIO.Location = New System.Drawing.Point(262, 12)
        Me.CMDACTUSUARIO.Name = "CMDACTUSUARIO"
        Me.CMDACTUSUARIO.Size = New System.Drawing.Size(109, 80)
        Me.CMDACTUSUARIO.TabIndex = 4
        Me.CMDACTUSUARIO.Text = "ACTIVIDAD USUARIO"
        Me.CMDACTUSUARIO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDACTUSUARIO.UseVisualStyleBackColor = True
        '
        'CMDCORTESEMANAL
        '
        Me.CMDCORTESEMANAL.Image = CType(resources.GetObject("CMDCORTESEMANAL.Image"), System.Drawing.Image)
        Me.CMDCORTESEMANAL.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCORTESEMANAL.Location = New System.Drawing.Point(136, 12)
        Me.CMDCORTESEMANAL.Name = "CMDCORTESEMANAL"
        Me.CMDCORTESEMANAL.Size = New System.Drawing.Size(109, 80)
        Me.CMDCORTESEMANAL.TabIndex = 1
        Me.CMDCORTESEMANAL.Text = "CORTE POR FECHA"
        Me.CMDCORTESEMANAL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCORTESEMANAL.UseVisualStyleBackColor = True
        '
        'CMDCORTEDIARIO
        '
        Me.CMDCORTEDIARIO.Image = CType(resources.GetObject("CMDCORTEDIARIO.Image"), System.Drawing.Image)
        Me.CMDCORTEDIARIO.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCORTEDIARIO.Location = New System.Drawing.Point(12, 12)
        Me.CMDCORTEDIARIO.Name = "CMDCORTEDIARIO"
        Me.CMDCORTEDIARIO.Size = New System.Drawing.Size(109, 80)
        Me.CMDCORTEDIARIO.TabIndex = 0
        Me.CMDCORTEDIARIO.Text = "CORTE DIARIO"
        Me.CMDCORTEDIARIO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCORTEDIARIO.UseVisualStyleBackColor = True
        '
        'REPORTES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 198)
        Me.ControlBox = False
        Me.Controls.Add(Me.CMDCOSTOS)
        Me.Controls.Add(Me.CMDBECASASIGNADAS)
        Me.Controls.Add(Me.CMDPEDIDOUNIFORM)
        Me.Controls.Add(Me.CMDSALIR)
        Me.Controls.Add(Me.CMDPIDENFACTURA)
        Me.Controls.Add(Me.CMDACTUSUARIO)
        Me.Controls.Add(Me.CMDCORTESEMANAL)
        Me.Controls.Add(Me.CMDCORTEDIARIO)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "REPORTES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORTES"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMDCORTEDIARIO As System.Windows.Forms.Button
    Friend WithEvents CMDCORTESEMANAL As System.Windows.Forms.Button
    Friend WithEvents CMDACTUSUARIO As System.Windows.Forms.Button
    Friend WithEvents CMDPIDENFACTURA As System.Windows.Forms.Button
    Friend WithEvents CMDSALIR As System.Windows.Forms.Button
    Friend WithEvents CMDPEDIDOUNIFORM As System.Windows.Forms.Button
    Friend WithEvents CMDBECASASIGNADAS As System.Windows.Forms.Button
    Friend WithEvents CMDCOSTOS As System.Windows.Forms.Button
End Class
