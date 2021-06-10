<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FECHASPIDENFACTURA
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
        Me.DTHASTA = New System.Windows.Forms.DateTimePicker()
        Me.DTDESDE = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMDSALIR = New System.Windows.Forms.Button()
        Me.CDMREPORTE = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DTHASTA
        '
        Me.DTHASTA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTHASTA.Location = New System.Drawing.Point(87, 60)
        Me.DTHASTA.Name = "DTHASTA"
        Me.DTHASTA.Size = New System.Drawing.Size(200, 26)
        Me.DTHASTA.TabIndex = 24
        '
        'DTDESDE
        '
        Me.DTDESDE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDESDE.Location = New System.Drawing.Point(87, 3)
        Me.DTDESDE.Name = "DTDESDE"
        Me.DTDESDE.Size = New System.Drawing.Size(200, 26)
        Me.DTDESDE.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "HASTA:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "DESDE:"
        '
        'CMDSALIR
        '
        Me.CMDSALIR.BackgroundImage = Global.SAC.My.Resources.Resources.Visualpharm_Must_Have_Log_Out
        Me.CMDSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDSALIR.Location = New System.Drawing.Point(283, 126)
        Me.CMDSALIR.Name = "CMDSALIR"
        Me.CMDSALIR.Size = New System.Drawing.Size(40, 37)
        Me.CMDSALIR.TabIndex = 26
        Me.CMDSALIR.UseVisualStyleBackColor = True
        '
        'CDMREPORTE
        '
        Me.CDMREPORTE.Image = Global.SAC.My.Resources.Resources.REPORTE_PRELIMINAR
        Me.CDMREPORTE.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CDMREPORTE.Location = New System.Drawing.Point(101, 96)
        Me.CDMREPORTE.Name = "CDMREPORTE"
        Me.CDMREPORTE.Size = New System.Drawing.Size(136, 61)
        Me.CDMREPORTE.TabIndex = 25
        Me.CDMREPORTE.Text = "VER REPORTE"
        Me.CDMREPORTE.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CDMREPORTE.UseVisualStyleBackColor = True
        '
        'FECHASPIDENFACTURA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 170)
        Me.ControlBox = False
        Me.Controls.Add(Me.CMDSALIR)
        Me.Controls.Add(Me.CDMREPORTE)
        Me.Controls.Add(Me.DTHASTA)
        Me.Controls.Add(Me.DTDESDE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FECHASPIDENFACTURA"
        Me.Text = "FECHASPIDENFACTURA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDSALIR As System.Windows.Forms.Button
    Friend WithEvents CDMREPORTE As System.Windows.Forms.Button
    Friend WithEvents DTHASTA As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTDESDE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
