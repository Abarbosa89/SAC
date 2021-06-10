<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PROMOCIONES
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
        Me.CMDPAGOSALUM = New System.Windows.Forms.Button()
        Me.CMDCRARPRDUCTO = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CMDPAGOSALUM
        '
        Me.CMDPAGOSALUM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDPAGOSALUM.Image = Global.SAC.My.Resources.Resources.EMPEÑO
        Me.CMDPAGOSALUM.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDPAGOSALUM.Location = New System.Drawing.Point(173, 12)
        Me.CMDPAGOSALUM.Name = "CMDPAGOSALUM"
        Me.CMDPAGOSALUM.Size = New System.Drawing.Size(114, 82)
        Me.CMDPAGOSALUM.TabIndex = 16
        Me.CMDPAGOSALUM.Text = "PAGOS PROMOCION"
        Me.CMDPAGOSALUM.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDPAGOSALUM.UseVisualStyleBackColor = True
        '
        'CMDCRARPRDUCTO
        '
        Me.CMDCRARPRDUCTO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCRARPRDUCTO.Image = Global.SAC.My.Resources.Resources._19764_bubka_Add_vista
        Me.CMDCRARPRDUCTO.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCRARPRDUCTO.Location = New System.Drawing.Point(12, 12)
        Me.CMDCRARPRDUCTO.Name = "CMDCRARPRDUCTO"
        Me.CMDCRARPRDUCTO.Size = New System.Drawing.Size(114, 82)
        Me.CMDCRARPRDUCTO.TabIndex = 15
        Me.CMDCRARPRDUCTO.Text = "CREAR PROMOCION"
        Me.CMDCRARPRDUCTO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCRARPRDUCTO.UseVisualStyleBackColor = True
        '
        'PROMOCIONES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 112)
        Me.Controls.Add(Me.CMDPAGOSALUM)
        Me.Controls.Add(Me.CMDCRARPRDUCTO)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "PROMOCIONES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROMOCIONES"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMDPAGOSALUM As System.Windows.Forms.Button
    Friend WithEvents CMDCRARPRDUCTO As System.Windows.Forms.Button
End Class
