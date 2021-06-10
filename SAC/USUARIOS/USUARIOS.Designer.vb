<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USUARIOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(USUARIOS))
        Me.CMDPASSWORD = New System.Windows.Forms.Button()
        Me.CMDSALIR = New System.Windows.Forms.Button()
        Me.CMDEDITARUSUARIO = New System.Windows.Forms.Button()
        Me.CMDNUEVOUSUARIO = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CMDPASSWORD
        '
        Me.CMDPASSWORD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDPASSWORD.Image = Global.SAC.My.Resources.Resources._20638_bubka_Security_vista
        Me.CMDPASSWORD.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDPASSWORD.Location = New System.Drawing.Point(240, 12)
        Me.CMDPASSWORD.Name = "CMDPASSWORD"
        Me.CMDPASSWORD.Size = New System.Drawing.Size(112, 81)
        Me.CMDPASSWORD.TabIndex = 13
        Me.CMDPASSWORD.Text = "RESETEAR PASSWORD"
        Me.CMDPASSWORD.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDPASSWORD.UseVisualStyleBackColor = True
        '
        'CMDSALIR
        '
        Me.CMDSALIR.BackgroundImage = Global.SAC.My.Resources.Resources.Visualpharm_Must_Have_Log_Out
        Me.CMDSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDSALIR.Location = New System.Drawing.Point(312, 99)
        Me.CMDSALIR.Name = "CMDSALIR"
        Me.CMDSALIR.Size = New System.Drawing.Size(40, 37)
        Me.CMDSALIR.TabIndex = 12
        Me.CMDSALIR.UseVisualStyleBackColor = True
        '
        'CMDEDITARUSUARIO
        '
        Me.CMDEDITARUSUARIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDEDITARUSUARIO.Image = Global.SAC.My.Resources.Resources.Pencil
        Me.CMDEDITARUSUARIO.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDEDITARUSUARIO.Location = New System.Drawing.Point(122, 12)
        Me.CMDEDITARUSUARIO.Name = "CMDEDITARUSUARIO"
        Me.CMDEDITARUSUARIO.Size = New System.Drawing.Size(112, 81)
        Me.CMDEDITARUSUARIO.TabIndex = 2
        Me.CMDEDITARUSUARIO.Text = "MODIFICAR USUARIO"
        Me.CMDEDITARUSUARIO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDEDITARUSUARIO.UseVisualStyleBackColor = True
        '
        'CMDNUEVOUSUARIO
        '
        Me.CMDNUEVOUSUARIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CMDNUEVOUSUARIO.Image = Global.SAC.My.Resources.Resources.ALUMNONUEVO
        Me.CMDNUEVOUSUARIO.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDNUEVOUSUARIO.Location = New System.Drawing.Point(4, 12)
        Me.CMDNUEVOUSUARIO.Name = "CMDNUEVOUSUARIO"
        Me.CMDNUEVOUSUARIO.Size = New System.Drawing.Size(112, 81)
        Me.CMDNUEVOUSUARIO.TabIndex = 1
        Me.CMDNUEVOUSUARIO.Text = "NUEVO USUARIO"
        Me.CMDNUEVOUSUARIO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDNUEVOUSUARIO.UseVisualStyleBackColor = True
        '
        'USUARIOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 143)
        Me.ControlBox = False
        Me.Controls.Add(Me.CMDPASSWORD)
        Me.Controls.Add(Me.CMDSALIR)
        Me.Controls.Add(Me.CMDEDITARUSUARIO)
        Me.Controls.Add(Me.CMDNUEVOUSUARIO)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "USUARIOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USUARIOS"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMDNUEVOUSUARIO As System.Windows.Forms.Button
    Friend WithEvents CMDEDITARUSUARIO As System.Windows.Forms.Button
    Friend WithEvents CMDSALIR As System.Windows.Forms.Button
    Friend WithEvents CMDPASSWORD As System.Windows.Forms.Button
End Class
