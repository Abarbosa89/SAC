<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRINCIPAL
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
        Me.CMDADMINISTRATIVO = New System.Windows.Forms.Button()
        Me.CMDSALIR = New System.Windows.Forms.Button()
        Me.CMDCOBROS = New System.Windows.Forms.Button()
        Me.CMDESCOLARES = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CMDADMINISTRATIVO
        '
        Me.CMDADMINISTRATIVO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDADMINISTRATIVO.Image = Global.SAC.My.Resources.Resources.Iconshock_Real_Vista_General_Administrator
        Me.CMDADMINISTRATIVO.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDADMINISTRATIVO.Location = New System.Drawing.Point(278, 12)
        Me.CMDADMINISTRATIVO.Name = "CMDADMINISTRATIVO"
        Me.CMDADMINISTRATIVO.Size = New System.Drawing.Size(146, 66)
        Me.CMDADMINISTRATIVO.TabIndex = 4
        Me.CMDADMINISTRATIVO.Text = "ADMINISTRATIVO"
        Me.CMDADMINISTRATIVO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDADMINISTRATIVO.UseVisualStyleBackColor = True
        '
        'CMDSALIR
        '
        Me.CMDSALIR.BackgroundImage = Global.SAC.My.Resources.Resources.Visualpharm_Must_Have_Log_Out
        Me.CMDSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDSALIR.Location = New System.Drawing.Point(373, 84)
        Me.CMDSALIR.Name = "CMDSALIR"
        Me.CMDSALIR.Size = New System.Drawing.Size(40, 37)
        Me.CMDSALIR.TabIndex = 3
        Me.CMDSALIR.UseVisualStyleBackColor = True
        '
        'CMDCOBROS
        '
        Me.CMDCOBROS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CMDCOBROS.Image = Global.SAC.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_3_Product_sales_report
        Me.CMDCOBROS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCOBROS.Location = New System.Drawing.Point(145, 12)
        Me.CMDCOBROS.Name = "CMDCOBROS"
        Me.CMDCOBROS.Size = New System.Drawing.Size(127, 66)
        Me.CMDCOBROS.TabIndex = 1
        Me.CMDCOBROS.Text = "COBROS"
        Me.CMDCOBROS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCOBROS.UseVisualStyleBackColor = True
        '
        'CMDESCOLARES
        '
        Me.CMDESCOLARES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CMDESCOLARES.Image = Global.SAC.My.Resources.Resources.Aha_Soft_Standard_City_School
        Me.CMDESCOLARES.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDESCOLARES.Location = New System.Drawing.Point(12, 12)
        Me.CMDESCOLARES.Name = "CMDESCOLARES"
        Me.CMDESCOLARES.Size = New System.Drawing.Size(127, 66)
        Me.CMDESCOLARES.TabIndex = 0
        Me.CMDESCOLARES.Text = "ESCOLARES"
        Me.CMDESCOLARES.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDESCOLARES.UseVisualStyleBackColor = True
        '
        'PRINCIPAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 135)
        Me.ControlBox = False
        Me.Controls.Add(Me.CMDADMINISTRATIVO)
        Me.Controls.Add(Me.CMDSALIR)
        Me.Controls.Add(Me.CMDCOBROS)
        Me.Controls.Add(Me.CMDESCOLARES)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PRINCIPAL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRINCIPAL"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMDESCOLARES As System.Windows.Forms.Button
    Friend WithEvents CMDCOBROS As System.Windows.Forms.Button
    Friend WithEvents CMDSALIR As System.Windows.Forms.Button
    Friend WithEvents CMDADMINISTRATIVO As System.Windows.Forms.Button
End Class
