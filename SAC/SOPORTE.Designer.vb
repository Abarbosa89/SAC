<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SOPORTE
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CMDSALIR = New System.Windows.Forms.Button()
        Me.CMDENVIARAZAEL = New System.Windows.Forms.Button()
        Me.CMDENVIARVARGAS = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(524, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PARA CUALQUIER PROBLEMA O ACLARACION COMUNICARSE CON:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ING. AZAEL BARBOSA RODRIGUEZ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(380, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(311, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ING. DAVID TOMAS VARGAS REQUENA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "aza_link@hotmail.com"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(458, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "dtvargasr@hotmail.com"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(201, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(304, 38)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "SISTEMA ADMINISTRATIVO COLEGIAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SAC"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CMDSALIR
        '
        Me.CMDSALIR.BackgroundImage = Global.SAC.My.Resources.Resources.Visualpharm_Must_Have_Log_Out
        Me.CMDSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDSALIR.Location = New System.Drawing.Point(651, 215)
        Me.CMDSALIR.Name = "CMDSALIR"
        Me.CMDSALIR.Size = New System.Drawing.Size(40, 37)
        Me.CMDSALIR.TabIndex = 15
        Me.CMDSALIR.UseVisualStyleBackColor = True
        '
        'CMDENVIARAZAEL
        '
        Me.CMDENVIARAZAEL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDENVIARAZAEL.Image = Global.SAC.My.Resources.Resources.ENVIAR
        Me.CMDENVIARAZAEL.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDENVIARAZAEL.Location = New System.Drawing.Point(102, 147)
        Me.CMDENVIARAZAEL.Name = "CMDENVIARAZAEL"
        Me.CMDENVIARAZAEL.Size = New System.Drawing.Size(80, 53)
        Me.CMDENVIARAZAEL.TabIndex = 16
        Me.CMDENVIARAZAEL.Text = "ENVIAR"
        Me.CMDENVIARAZAEL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDENVIARAZAEL.UseVisualStyleBackColor = True
        '
        'CMDENVIARVARGAS
        '
        Me.CMDENVIARVARGAS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDENVIARVARGAS.Image = Global.SAC.My.Resources.Resources.ENVIAR
        Me.CMDENVIARVARGAS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDENVIARVARGAS.Location = New System.Drawing.Point(504, 147)
        Me.CMDENVIARVARGAS.Name = "CMDENVIARVARGAS"
        Me.CMDENVIARVARGAS.Size = New System.Drawing.Size(80, 53)
        Me.CMDENVIARVARGAS.TabIndex = 17
        Me.CMDENVIARVARGAS.Text = "ENVIAR"
        Me.CMDENVIARVARGAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDENVIARVARGAS.UseVisualStyleBackColor = True
        '
        'SOPORTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 264)
        Me.Controls.Add(Me.CMDENVIARVARGAS)
        Me.Controls.Add(Me.CMDENVIARAZAEL)
        Me.Controls.Add(Me.CMDSALIR)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SOPORTE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SOPORTE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CMDSALIR As System.Windows.Forms.Button
    Friend WithEvents CMDENVIARAZAEL As System.Windows.Forms.Button
    Friend WithEvents CMDENVIARVARGAS As System.Windows.Forms.Button
End Class
