<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Readme
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Readme))
        Me.txtReadme = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtReadme
        '
        Me.txtReadme.BackColor = System.Drawing.Color.White
        Me.txtReadme.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReadme.Location = New System.Drawing.Point(12, 12)
        Me.txtReadme.Multiline = True
        Me.txtReadme.Name = "txtReadme"
        Me.txtReadme.ReadOnly = True
        Me.txtReadme.Size = New System.Drawing.Size(828, 536)
        Me.txtReadme.TabIndex = 0
        Me.txtReadme.Text = resources.GetString("txtReadme.Text")
        '
        'Readme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(852, 560)
        Me.Controls.Add(Me.txtReadme)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Readme"
        Me.Text = "Readme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtReadme As System.Windows.Forms.TextBox
End Class
