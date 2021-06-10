<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DATOSPERALUMNO
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.TXTAPPATERNO = New System.Windows.Forms.TextBox()
        Me.TXTAPMATERNO = New System.Windows.Forms.TextBox()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.CMDGUARDAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre(s)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido Paterno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido Materno"
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Location = New System.Drawing.Point(140, 20)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(349, 26)
        Me.TXTNOMBRE.TabIndex = 1
        '
        'TXTAPPATERNO
        '
        Me.TXTAPPATERNO.Location = New System.Drawing.Point(140, 64)
        Me.TXTAPPATERNO.Name = "TXTAPPATERNO"
        Me.TXTAPPATERNO.Size = New System.Drawing.Size(349, 26)
        Me.TXTAPPATERNO.TabIndex = 2
        '
        'TXTAPMATERNO
        '
        Me.TXTAPMATERNO.Location = New System.Drawing.Point(140, 112)
        Me.TXTAPMATERNO.Name = "TXTAPMATERNO"
        Me.TXTAPMATERNO.Size = New System.Drawing.Size(349, 26)
        Me.TXTAPMATERNO.TabIndex = 3
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImage = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Location = New System.Drawing.Point(282, 154)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(42, 40)
        Me.CMDCANCELAR.TabIndex = 5
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'CMDGUARDAR
        '
        Me.CMDGUARDAR.BackgroundImage = Global.SAC.My.Resources.Resources.GUARDAR_REGISTRO1
        Me.CMDGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDGUARDAR.Location = New System.Drawing.Point(214, 154)
        Me.CMDGUARDAR.Name = "CMDGUARDAR"
        Me.CMDGUARDAR.Size = New System.Drawing.Size(44, 40)
        Me.CMDGUARDAR.TabIndex = 4
        Me.CMDGUARDAR.UseVisualStyleBackColor = True
        '
        'DATOSPERALUMNO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 206)
        Me.ControlBox = False
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.CMDGUARDAR)
        Me.Controls.Add(Me.TXTAPMATERNO)
        Me.Controls.Add(Me.TXTAPPATERNO)
        Me.Controls.Add(Me.TXTNOMBRE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DATOSPERALUMNO"
        Me.Text = "DATOS PERSONALES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXTNOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents TXTAPPATERNO As System.Windows.Forms.TextBox
    Friend WithEvents TXTAPMATERNO As System.Windows.Forms.TextBox
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents CMDGUARDAR As System.Windows.Forms.Button
End Class
