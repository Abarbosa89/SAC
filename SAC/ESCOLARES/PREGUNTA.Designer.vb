<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PREGUNTA
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
        Me.CMDNUEVOINGRESO = New System.Windows.Forms.Button()
        Me.CMDREINSCRIPCION = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¿El alumno es de nuevo ingreso o Resincripcion?"
        '
        'CMDNUEVOINGRESO
        '
        Me.CMDNUEVOINGRESO.Location = New System.Drawing.Point(63, 48)
        Me.CMDNUEVOINGRESO.Name = "CMDNUEVOINGRESO"
        Me.CMDNUEVOINGRESO.Size = New System.Drawing.Size(112, 52)
        Me.CMDNUEVOINGRESO.TabIndex = 1
        Me.CMDNUEVOINGRESO.Text = "Nuevo Ingreso"
        Me.CMDNUEVOINGRESO.UseVisualStyleBackColor = True
        '
        'CMDREINSCRIPCION
        '
        Me.CMDREINSCRIPCION.Location = New System.Drawing.Point(192, 48)
        Me.CMDREINSCRIPCION.Name = "CMDREINSCRIPCION"
        Me.CMDREINSCRIPCION.Size = New System.Drawing.Size(114, 52)
        Me.CMDREINSCRIPCION.TabIndex = 2
        Me.CMDREINSCRIPCION.Text = "Reinscripcion"
        Me.CMDREINSCRIPCION.UseVisualStyleBackColor = True
        '
        'PREGUNTA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 112)
        Me.Controls.Add(Me.CMDREINSCRIPCION)
        Me.Controls.Add(Me.CMDNUEVOINGRESO)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PREGUNTA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUE DESEA HACER?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CMDNUEVOINGRESO As System.Windows.Forms.Button
    Friend WithEvents CMDREINSCRIPCION As System.Windows.Forms.Button
End Class
