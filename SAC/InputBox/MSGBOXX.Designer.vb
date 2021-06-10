<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MSGBOXX
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
        Me.CMDINSCRIPCION = New System.Windows.Forms.Button()
        Me.CMDOCLEGIATURA = New System.Windows.Forms.Button()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.CMDADEUDOS = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(418, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUE DESEA PAGAR INSCRIPCION O COLEGIATURA?"
        '
        'CMDINSCRIPCION
        '
        Me.CMDINSCRIPCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDINSCRIPCION.Image = Global.SAC.My.Resources.Resources.EMPEÑO
        Me.CMDINSCRIPCION.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDINSCRIPCION.Location = New System.Drawing.Point(133, 46)
        Me.CMDINSCRIPCION.Name = "CMDINSCRIPCION"
        Me.CMDINSCRIPCION.Size = New System.Drawing.Size(111, 56)
        Me.CMDINSCRIPCION.TabIndex = 2
        Me.CMDINSCRIPCION.Text = "INSCRIPCION"
        Me.CMDINSCRIPCION.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDINSCRIPCION.UseVisualStyleBackColor = True
        '
        'CMDOCLEGIATURA
        '
        Me.CMDOCLEGIATURA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDOCLEGIATURA.Image = Global.SAC.My.Resources.Resources.EMPEÑO
        Me.CMDOCLEGIATURA.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDOCLEGIATURA.Location = New System.Drawing.Point(16, 46)
        Me.CMDOCLEGIATURA.Name = "CMDOCLEGIATURA"
        Me.CMDOCLEGIATURA.Size = New System.Drawing.Size(111, 56)
        Me.CMDOCLEGIATURA.TabIndex = 1
        Me.CMDOCLEGIATURA.Text = "COLEGIATURA"
        Me.CMDOCLEGIATURA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDOCLEGIATURA.UseVisualStyleBackColor = True
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImage = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Location = New System.Drawing.Point(389, 62)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(42, 40)
        Me.CMDCANCELAR.TabIndex = 41
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'CMDADEUDOS
        '
        Me.CMDADEUDOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDADEUDOS.Image = Global.SAC.My.Resources.Resources.EMPEÑO
        Me.CMDADEUDOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDADEUDOS.Location = New System.Drawing.Point(250, 46)
        Me.CMDADEUDOS.Name = "CMDADEUDOS"
        Me.CMDADEUDOS.Size = New System.Drawing.Size(111, 56)
        Me.CMDADEUDOS.TabIndex = 42
        Me.CMDADEUDOS.Text = "ADEUDOS"
        Me.CMDADEUDOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDADEUDOS.UseVisualStyleBackColor = True
        '
        'MSGBOXX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 114)
        Me.ControlBox = False
        Me.Controls.Add(Me.CMDADEUDOS)
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.CMDINSCRIPCION)
        Me.Controls.Add(Me.CMDOCLEGIATURA)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "MSGBOXX"
        Me.Text = "INSCRIPCION O COLEGIATURA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CMDOCLEGIATURA As System.Windows.Forms.Button
    Friend WithEvents CMDINSCRIPCION As System.Windows.Forms.Button
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents CMDADEUDOS As System.Windows.Forms.Button
End Class
