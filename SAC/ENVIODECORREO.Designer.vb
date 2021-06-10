<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ENVIODECORREO
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
        Me.txttexto = New System.Windows.Forms.TextBox()
        Me.txtasunto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CMDENVIAR = New System.Windows.Forms.Button()
        Me.CMDCERRAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txttexto
        '
        Me.txttexto.Location = New System.Drawing.Point(28, 94)
        Me.txttexto.Multiline = True
        Me.txttexto.Name = "txttexto"
        Me.txttexto.Size = New System.Drawing.Size(397, 173)
        Me.txttexto.TabIndex = 10
        '
        'txtasunto
        '
        Me.txtasunto.Location = New System.Drawing.Point(105, 12)
        Me.txtasunto.Name = "txtasunto"
        Me.txtasunto.Size = New System.Drawing.Size(240, 26)
        Me.txtasunto.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ASUNTO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "MENSAJE"
        '
        'CMDENVIAR
        '
        Me.CMDENVIAR.Image = Global.SAC.My.Resources.Resources.ENVIAR
        Me.CMDENVIAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDENVIAR.Location = New System.Drawing.Point(105, 273)
        Me.CMDENVIAR.Name = "CMDENVIAR"
        Me.CMDENVIAR.Size = New System.Drawing.Size(91, 61)
        Me.CMDENVIAR.TabIndex = 11
        Me.CMDENVIAR.Text = "ENVIAR"
        Me.CMDENVIAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDENVIAR.UseVisualStyleBackColor = True
        '
        'CMDCERRAR
        '
        Me.CMDCERRAR.Image = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCERRAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCERRAR.Location = New System.Drawing.Point(213, 273)
        Me.CMDCERRAR.Name = "CMDCERRAR"
        Me.CMDCERRAR.Size = New System.Drawing.Size(91, 61)
        Me.CMDCERRAR.TabIndex = 14
        Me.CMDCERRAR.Text = "CERRAR"
        Me.CMDCERRAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCERRAR.UseVisualStyleBackColor = True
        '
        'ENVIODECORREO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.CMDCERRAR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CMDENVIAR)
        Me.Controls.Add(Me.txttexto)
        Me.Controls.Add(Me.txtasunto)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ENVIODECORREO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ENVIODECORREO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDENVIAR As System.Windows.Forms.Button
    Friend WithEvents txttexto As System.Windows.Forms.TextBox
    Friend WithEvents txtasunto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CMDCERRAR As System.Windows.Forms.Button
End Class
