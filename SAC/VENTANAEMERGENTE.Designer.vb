<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VENTANAEMERGENTE
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
        Me.CMDIMPRIMIRTICKETS = New System.Windows.Forms.Button()
        Me.CMDIMPRIMIRSHARP = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CMDIMPRIMIRTICKETS
        '
        Me.CMDIMPRIMIRTICKETS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDIMPRIMIRTICKETS.Image = Global.SAC.My.Resources.Resources.PRINTER
        Me.CMDIMPRIMIRTICKETS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDIMPRIMIRTICKETS.Location = New System.Drawing.Point(77, 51)
        Me.CMDIMPRIMIRTICKETS.Name = "CMDIMPRIMIRTICKETS"
        Me.CMDIMPRIMIRTICKETS.Size = New System.Drawing.Size(100, 57)
        Me.CMDIMPRIMIRTICKETS.TabIndex = 46
        Me.CMDIMPRIMIRTICKETS.Text = "TICKETS"
        Me.CMDIMPRIMIRTICKETS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDIMPRIMIRTICKETS.UseVisualStyleBackColor = True
        '
        'CMDIMPRIMIRSHARP
        '
        Me.CMDIMPRIMIRSHARP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDIMPRIMIRSHARP.Image = Global.SAC.My.Resources.Resources.PRINTER
        Me.CMDIMPRIMIRSHARP.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDIMPRIMIRSHARP.Location = New System.Drawing.Point(209, 51)
        Me.CMDIMPRIMIRSHARP.Name = "CMDIMPRIMIRSHARP"
        Me.CMDIMPRIMIRSHARP.Size = New System.Drawing.Size(100, 57)
        Me.CMDIMPRIMIRSHARP.TabIndex = 47
        Me.CMDIMPRIMIRSHARP.Text = "SHARP"
        Me.CMDIMPRIMIRSHARP.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDIMPRIMIRSHARP.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 20)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Seleccione la impresora.."
        '
        'VENTANAEMERGENTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 133)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CMDIMPRIMIRSHARP)
        Me.Controls.Add(Me.CMDIMPRIMIRTICKETS)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VENTANAEMERGENTE"
        Me.Text = "VENTANAEMERGENTE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDIMPRIMIRTICKETS As System.Windows.Forms.Button
    Friend WithEvents CMDIMPRIMIRSHARP As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
