<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTIVIDADUSUARIOS
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
        Me.CMDGLOBAL = New System.Windows.Forms.Button()
        Me.CMDPORFECHA = New System.Windows.Forms.Button()
        Me.CMDSALIR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CMDGLOBAL
        '
        Me.CMDGLOBAL.Location = New System.Drawing.Point(12, 12)
        Me.CMDGLOBAL.Name = "CMDGLOBAL"
        Me.CMDGLOBAL.Size = New System.Drawing.Size(109, 51)
        Me.CMDGLOBAL.TabIndex = 1
        Me.CMDGLOBAL.Text = "GLOBAL"
        Me.CMDGLOBAL.UseVisualStyleBackColor = True
        '
        'CMDPORFECHA
        '
        Me.CMDPORFECHA.Location = New System.Drawing.Point(143, 12)
        Me.CMDPORFECHA.Name = "CMDPORFECHA"
        Me.CMDPORFECHA.Size = New System.Drawing.Size(109, 51)
        Me.CMDPORFECHA.TabIndex = 2
        Me.CMDPORFECHA.Text = "POR FECHAS"
        Me.CMDPORFECHA.UseVisualStyleBackColor = True
        '
        'CMDSALIR
        '
        Me.CMDSALIR.BackgroundImage = Global.SAC.My.Resources.Resources.Visualpharm_Must_Have_Log_Out
        Me.CMDSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDSALIR.Location = New System.Drawing.Point(291, 33)
        Me.CMDSALIR.Name = "CMDSALIR"
        Me.CMDSALIR.Size = New System.Drawing.Size(40, 37)
        Me.CMDSALIR.TabIndex = 13
        Me.CMDSALIR.UseVisualStyleBackColor = True
        '
        'ACTIVIDADUSUARIOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 82)
        Me.ControlBox = False
        Me.Controls.Add(Me.CMDSALIR)
        Me.Controls.Add(Me.CMDPORFECHA)
        Me.Controls.Add(Me.CMDGLOBAL)
        Me.Name = "ACTIVIDADUSUARIOS"
        Me.Text = "ACTIVIDADUSUARIOS"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMDGLOBAL As System.Windows.Forms.Button
    Friend WithEvents CMDPORFECHA As System.Windows.Forms.Button
    Friend WithEvents CMDSALIR As System.Windows.Forms.Button
End Class
