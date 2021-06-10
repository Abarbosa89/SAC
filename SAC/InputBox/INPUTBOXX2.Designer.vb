<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INPUTBOXX2
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
        Me.LBLTEXTO = New System.Windows.Forms.Label()
        Me.TXTPASSWORD = New System.Windows.Forms.TextBox()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.CMDACEPTAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBLTEXTO
        '
        Me.LBLTEXTO.AutoSize = True
        Me.LBLTEXTO.Location = New System.Drawing.Point(12, 18)
        Me.LBLTEXTO.Name = "LBLTEXTO"
        Me.LBLTEXTO.Size = New System.Drawing.Size(220, 13)
        Me.LBLTEXTO.TabIndex = 7
        Me.LBLTEXTO.Text = "PORFAVOR CONFIRME SU CONTRASEÑA"
        '
        'TXTPASSWORD
        '
        Me.TXTPASSWORD.Location = New System.Drawing.Point(12, 79)
        Me.TXTPASSWORD.Name = "TXTPASSWORD"
        Me.TXTPASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTPASSWORD.Size = New System.Drawing.Size(315, 20)
        Me.TXTPASSWORD.TabIndex = 1
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.Location = New System.Drawing.Point(257, 42)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(70, 24)
        Me.CMDCANCELAR.TabIndex = 3
        Me.CMDCANCELAR.Text = "Cancelar"
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'CMDACEPTAR
        '
        Me.CMDACEPTAR.Location = New System.Drawing.Point(257, 12)
        Me.CMDACEPTAR.Name = "CMDACEPTAR"
        Me.CMDACEPTAR.Size = New System.Drawing.Size(70, 24)
        Me.CMDACEPTAR.TabIndex = 2
        Me.CMDACEPTAR.Text = "Aceptar"
        Me.CMDACEPTAR.UseVisualStyleBackColor = True
        '
        'INPUTBOXX2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 111)
        Me.Controls.Add(Me.LBLTEXTO)
        Me.Controls.Add(Me.TXTPASSWORD)
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.CMDACEPTAR)
        Me.Name = "INPUTBOXX2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INPUTBOXX2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLTEXTO As System.Windows.Forms.Label
    Friend WithEvents TXTPASSWORD As System.Windows.Forms.TextBox
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents CMDACEPTAR As System.Windows.Forms.Button
End Class
