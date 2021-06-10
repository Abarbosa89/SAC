<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REPORTESCOSTOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REPORTESCOSTOS))
        Me.CMDCOSTOSPRODUCTOS = New System.Windows.Forms.Button()
        Me.CMDCOSTOSUNIFORMES = New System.Windows.Forms.Button()
        Me.CMDSALIR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CMDCOSTOSPRODUCTOS
        '
        Me.CMDCOSTOSPRODUCTOS.Image = CType(resources.GetObject("CMDCOSTOSPRODUCTOS.Image"), System.Drawing.Image)
        Me.CMDCOSTOSPRODUCTOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCOSTOSPRODUCTOS.Location = New System.Drawing.Point(12, 12)
        Me.CMDCOSTOSPRODUCTOS.Name = "CMDCOSTOSPRODUCTOS"
        Me.CMDCOSTOSPRODUCTOS.Size = New System.Drawing.Size(123, 80)
        Me.CMDCOSTOSPRODUCTOS.TabIndex = 16
        Me.CMDCOSTOSPRODUCTOS.Text = "COSTOS PRODUCTOS"
        Me.CMDCOSTOSPRODUCTOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCOSTOSPRODUCTOS.UseVisualStyleBackColor = True
        '
        'CMDCOSTOSUNIFORMES
        '
        Me.CMDCOSTOSUNIFORMES.Image = CType(resources.GetObject("CMDCOSTOSUNIFORMES.Image"), System.Drawing.Image)
        Me.CMDCOSTOSUNIFORMES.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCOSTOSUNIFORMES.Location = New System.Drawing.Point(201, 12)
        Me.CMDCOSTOSUNIFORMES.Name = "CMDCOSTOSUNIFORMES"
        Me.CMDCOSTOSUNIFORMES.Size = New System.Drawing.Size(123, 80)
        Me.CMDCOSTOSUNIFORMES.TabIndex = 17
        Me.CMDCOSTOSUNIFORMES.Text = "COSTOS UNFORMES"
        Me.CMDCOSTOSUNIFORMES.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCOSTOSUNIFORMES.UseVisualStyleBackColor = True
        '
        'CMDSALIR
        '
        Me.CMDSALIR.BackgroundImage = Global.SAC.My.Resources.Resources.Visualpharm_Must_Have_Log_Out
        Me.CMDSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDSALIR.Location = New System.Drawing.Point(293, 104)
        Me.CMDSALIR.Name = "CMDSALIR"
        Me.CMDSALIR.Size = New System.Drawing.Size(40, 37)
        Me.CMDSALIR.TabIndex = 18
        Me.CMDSALIR.UseVisualStyleBackColor = True
        '
        'REPORTESCOSTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 146)
        Me.ControlBox = False
        Me.Controls.Add(Me.CMDSALIR)
        Me.Controls.Add(Me.CMDCOSTOSUNIFORMES)
        Me.Controls.Add(Me.CMDCOSTOSPRODUCTOS)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "REPORTESCOSTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORTESCOSTOS"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMDCOSTOSPRODUCTOS As System.Windows.Forms.Button
    Friend WithEvents CMDCOSTOSUNIFORMES As System.Windows.Forms.Button
    Friend WithEvents CMDSALIR As System.Windows.Forms.Button
End Class
