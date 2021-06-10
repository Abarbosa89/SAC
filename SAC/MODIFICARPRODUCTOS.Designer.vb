<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MODIFICARPRODUCTOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MODIFICARPRODUCTOS))
        Me.CMDPRODUCUNIFORM = New System.Windows.Forms.Button()
        Me.CMDPRODUCTOSVARIOS = New System.Windows.Forms.Button()
        Me.CMDPRODUCTOSINSC = New System.Windows.Forms.Button()
        Me.CMDPRODUCTOSCOLE = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CMDPRODUCUNIFORM
        '
        Me.CMDPRODUCUNIFORM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDPRODUCUNIFORM.Image = CType(resources.GetObject("CMDPRODUCUNIFORM.Image"), System.Drawing.Image)
        Me.CMDPRODUCUNIFORM.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDPRODUCUNIFORM.Location = New System.Drawing.Point(161, 87)
        Me.CMDPRODUCUNIFORM.Name = "CMDPRODUCUNIFORM"
        Me.CMDPRODUCUNIFORM.Size = New System.Drawing.Size(141, 67)
        Me.CMDPRODUCUNIFORM.TabIndex = 18
        Me.CMDPRODUCUNIFORM.Text = "UNIFORMES"
        Me.CMDPRODUCUNIFORM.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDPRODUCUNIFORM.UseVisualStyleBackColor = True
        '
        'CMDPRODUCTOSVARIOS
        '
        Me.CMDPRODUCTOSVARIOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDPRODUCTOSVARIOS.Image = CType(resources.GetObject("CMDPRODUCTOSVARIOS.Image"), System.Drawing.Image)
        Me.CMDPRODUCTOSVARIOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDPRODUCTOSVARIOS.Location = New System.Drawing.Point(14, 85)
        Me.CMDPRODUCTOSVARIOS.Name = "CMDPRODUCTOSVARIOS"
        Me.CMDPRODUCTOSVARIOS.Size = New System.Drawing.Size(141, 69)
        Me.CMDPRODUCTOSVARIOS.TabIndex = 17
        Me.CMDPRODUCTOSVARIOS.Text = "VARIOS"
        Me.CMDPRODUCTOSVARIOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDPRODUCTOSVARIOS.UseVisualStyleBackColor = True
        '
        'CMDPRODUCTOSINSC
        '
        Me.CMDPRODUCTOSINSC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDPRODUCTOSINSC.Image = CType(resources.GetObject("CMDPRODUCTOSINSC.Image"), System.Drawing.Image)
        Me.CMDPRODUCTOSINSC.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDPRODUCTOSINSC.Location = New System.Drawing.Point(161, 12)
        Me.CMDPRODUCTOSINSC.Name = "CMDPRODUCTOSINSC"
        Me.CMDPRODUCTOSINSC.Size = New System.Drawing.Size(141, 69)
        Me.CMDPRODUCTOSINSC.TabIndex = 16
        Me.CMDPRODUCTOSINSC.Text = "INSCRIPCION"
        Me.CMDPRODUCTOSINSC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDPRODUCTOSINSC.UseVisualStyleBackColor = True
        '
        'CMDPRODUCTOSCOLE
        '
        Me.CMDPRODUCTOSCOLE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDPRODUCTOSCOLE.Image = CType(resources.GetObject("CMDPRODUCTOSCOLE.Image"), System.Drawing.Image)
        Me.CMDPRODUCTOSCOLE.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDPRODUCTOSCOLE.Location = New System.Drawing.Point(14, 12)
        Me.CMDPRODUCTOSCOLE.Name = "CMDPRODUCTOSCOLE"
        Me.CMDPRODUCTOSCOLE.Size = New System.Drawing.Size(141, 69)
        Me.CMDPRODUCTOSCOLE.TabIndex = 15
        Me.CMDPRODUCTOSCOLE.Text = "COLEGIATURAS"
        Me.CMDPRODUCTOSCOLE.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDPRODUCTOSCOLE.UseVisualStyleBackColor = True
        '
        'MODIFICARPRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 167)
        Me.Controls.Add(Me.CMDPRODUCUNIFORM)
        Me.Controls.Add(Me.CMDPRODUCTOSVARIOS)
        Me.Controls.Add(Me.CMDPRODUCTOSINSC)
        Me.Controls.Add(Me.CMDPRODUCTOSCOLE)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MODIFICARPRODUCTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MODIFICARPRODUCTOS"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMDPRODUCTOSVARIOS As System.Windows.Forms.Button
    Friend WithEvents CMDPRODUCTOSINSC As System.Windows.Forms.Button
    Friend WithEvents CMDPRODUCTOSCOLE As System.Windows.Forms.Button
    Friend WithEvents CMDPRODUCUNIFORM As System.Windows.Forms.Button
End Class
