<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DOMPARTUTOR
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
        Me.TXTESTADO = New System.Windows.Forms.TextBox()
        Me.TXTCIUDAD = New System.Windows.Forms.TextBox()
        Me.TXTCP = New System.Windows.Forms.TextBox()
        Me.TXTCOLONIA = New System.Windows.Forms.TextBox()
        Me.TXTNUMERO = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTCALLE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.CMDGUARDAR = New System.Windows.Forms.Button()
        Me.TXTPAIS = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TXTESTADO
        '
        Me.TXTESTADO.Location = New System.Drawing.Point(99, 230)
        Me.TXTESTADO.Name = "TXTESTADO"
        Me.TXTESTADO.Size = New System.Drawing.Size(308, 26)
        Me.TXTESTADO.TabIndex = 6
        '
        'TXTCIUDAD
        '
        Me.TXTCIUDAD.Location = New System.Drawing.Point(99, 187)
        Me.TXTCIUDAD.Name = "TXTCIUDAD"
        Me.TXTCIUDAD.Size = New System.Drawing.Size(308, 26)
        Me.TXTCIUDAD.TabIndex = 5
        '
        'TXTCP
        '
        Me.TXTCP.Location = New System.Drawing.Point(99, 145)
        Me.TXTCP.MaxLength = 5
        Me.TXTCP.Name = "TXTCP"
        Me.TXTCP.Size = New System.Drawing.Size(308, 26)
        Me.TXTCP.TabIndex = 4
        '
        'TXTCOLONIA
        '
        Me.TXTCOLONIA.Location = New System.Drawing.Point(99, 107)
        Me.TXTCOLONIA.Name = "TXTCOLONIA"
        Me.TXTCOLONIA.Size = New System.Drawing.Size(308, 26)
        Me.TXTCOLONIA.TabIndex = 3
        '
        'TXTNUMERO
        '
        Me.TXTNUMERO.Location = New System.Drawing.Point(99, 66)
        Me.TXTNUMERO.Name = "TXTNUMERO"
        Me.TXTNUMERO.Size = New System.Drawing.Size(308, 26)
        Me.TXTNUMERO.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(52, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 19)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "C.P."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 19)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Estado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 19)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Ciudad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 19)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Colonia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Numero"
        '
        'TXTCALLE
        '
        Me.TXTCALLE.Location = New System.Drawing.Point(99, 22)
        Me.TXTCALLE.Name = "TXTCALLE"
        Me.TXTCALLE.Size = New System.Drawing.Size(308, 26)
        Me.TXTCALLE.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 19)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Calle"
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImage = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Location = New System.Drawing.Point(246, 304)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(42, 40)
        Me.CMDCANCELAR.TabIndex = 43
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'CMDGUARDAR
        '
        Me.CMDGUARDAR.BackgroundImage = Global.SAC.My.Resources.Resources.GUARDAR_REGISTRO1
        Me.CMDGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDGUARDAR.Location = New System.Drawing.Point(162, 304)
        Me.CMDGUARDAR.Name = "CMDGUARDAR"
        Me.CMDGUARDAR.Size = New System.Drawing.Size(44, 40)
        Me.CMDGUARDAR.TabIndex = 42
        Me.CMDGUARDAR.UseVisualStyleBackColor = True
        '
        'TXTPAIS
        '
        Me.TXTPAIS.Location = New System.Drawing.Point(99, 272)
        Me.TXTPAIS.Name = "TXTPAIS"
        Me.TXTPAIS.Size = New System.Drawing.Size(308, 26)
        Me.TXTPAIS.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(50, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 19)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Pais"
        '
        'DOMPARTUTOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 361)
        Me.ControlBox = False
        Me.Controls.Add(Me.TXTPAIS)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.CMDGUARDAR)
        Me.Controls.Add(Me.TXTESTADO)
        Me.Controls.Add(Me.TXTCIUDAD)
        Me.Controls.Add(Me.TXTCP)
        Me.Controls.Add(Me.TXTCOLONIA)
        Me.Controls.Add(Me.TXTNUMERO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTCALLE)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DOMPARTUTOR"
        Me.Text = "DOMICILIO PARCIAL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents CMDGUARDAR As System.Windows.Forms.Button
    Friend WithEvents TXTESTADO As System.Windows.Forms.TextBox
    Friend WithEvents TXTCIUDAD As System.Windows.Forms.TextBox
    Friend WithEvents TXTCP As System.Windows.Forms.TextBox
    Friend WithEvents TXTCOLONIA As System.Windows.Forms.TextBox
    Friend WithEvents TXTNUMERO As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTCALLE As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTPAIS As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
