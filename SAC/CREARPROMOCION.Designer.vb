<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CREARPROMOCION
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
        Me.TXTDESCRIPCION = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBOPORCENTAJE = New System.Windows.Forms.ComboBox()
        Me.LBLPORCENTAJE = New System.Windows.Forms.Label()
        Me.DTFECHAINI = New System.Windows.Forms.DateTimePicker()
        Me.DTFECHAFIN = New System.Windows.Forms.DateTimePicker()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.CMDGUARDAR = New System.Windows.Forms.Button()
        Me.CBOCONCEPTO = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DESCRIPCION"
        '
        'TXTDESCRIPCION
        '
        Me.TXTDESCRIPCION.Location = New System.Drawing.Point(127, 55)
        Me.TXTDESCRIPCION.Multiline = True
        Me.TXTDESCRIPCION.Name = "TXTDESCRIPCION"
        Me.TXTDESCRIPCION.Size = New System.Drawing.Size(372, 58)
        Me.TXTDESCRIPCION.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "FECHA INICIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(296, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "FECHA FIN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "DESCUENTO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "CONCEPTO"
        '
        'CBOPORCENTAJE
        '
        Me.CBOPORCENTAJE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOPORCENTAJE.FormattingEnabled = True
        Me.CBOPORCENTAJE.Items.AddRange(New Object() {"10", "20", "30", "40", "50", "OTRO"})
        Me.CBOPORCENTAJE.Location = New System.Drawing.Point(136, 194)
        Me.CBOPORCENTAJE.Name = "CBOPORCENTAJE"
        Me.CBOPORCENTAJE.Size = New System.Drawing.Size(220, 26)
        Me.CBOPORCENTAJE.TabIndex = 40
        '
        'LBLPORCENTAJE
        '
        Me.LBLPORCENTAJE.AutoSize = True
        Me.LBLPORCENTAJE.Location = New System.Drawing.Point(12, 274)
        Me.LBLPORCENTAJE.Name = "LBLPORCENTAJE"
        Me.LBLPORCENTAJE.Size = New System.Drawing.Size(114, 18)
        Me.LBLPORCENTAJE.TabIndex = 41
        Me.LBLPORCENTAJE.Text = "PORCENTAJE"
        '
        'DTFECHAINI
        '
        Me.DTFECHAINI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFECHAINI.Location = New System.Drawing.Point(135, 132)
        Me.DTFECHAINI.Name = "DTFECHAINI"
        Me.DTFECHAINI.Size = New System.Drawing.Size(115, 26)
        Me.DTFECHAINI.TabIndex = 42
        '
        'DTFECHAFIN
        '
        Me.DTFECHAFIN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFECHAFIN.Location = New System.Drawing.Point(392, 132)
        Me.DTFECHAFIN.Name = "DTFECHAFIN"
        Me.DTFECHAFIN.Size = New System.Drawing.Size(120, 26)
        Me.DTFECHAFIN.TabIndex = 43
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Image = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR.Location = New System.Drawing.Point(280, 236)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(114, 60)
        Me.CMDCANCELAR.TabIndex = 45
        Me.CMDCANCELAR.Text = "CERRAR"
        Me.CMDCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'CMDGUARDAR
        '
        Me.CMDGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDGUARDAR.Image = Global.SAC.My.Resources.Resources.GUARDAR_REGISTRO1
        Me.CMDGUARDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDGUARDAR.Location = New System.Drawing.Point(160, 236)
        Me.CMDGUARDAR.Name = "CMDGUARDAR"
        Me.CMDGUARDAR.Size = New System.Drawing.Size(114, 60)
        Me.CMDGUARDAR.TabIndex = 44
        Me.CMDGUARDAR.Text = "GUARDAR"
        Me.CMDGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDGUARDAR.UseVisualStyleBackColor = True
        '
        'CBOCONCEPTO
        '
        Me.CBOCONCEPTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCONCEPTO.FormattingEnabled = True
        Me.CBOCONCEPTO.Items.AddRange(New Object() {"COLEGIATURA"})
        Me.CBOCONCEPTO.Location = New System.Drawing.Point(127, 21)
        Me.CBOCONCEPTO.Name = "CBOCONCEPTO"
        Me.CBOCONCEPTO.Size = New System.Drawing.Size(240, 26)
        Me.CBOCONCEPTO.TabIndex = 46
        '
        'CREARPROMOCION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 309)
        Me.ControlBox = False
        Me.Controls.Add(Me.CBOCONCEPTO)
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.CMDGUARDAR)
        Me.Controls.Add(Me.DTFECHAFIN)
        Me.Controls.Add(Me.DTFECHAINI)
        Me.Controls.Add(Me.LBLPORCENTAJE)
        Me.Controls.Add(Me.CBOPORCENTAJE)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTDESCRIPCION)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CREARPROMOCION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CREARPROMOCION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTDESCRIPCION As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CBOPORCENTAJE As System.Windows.Forms.ComboBox
    Friend WithEvents LBLPORCENTAJE As System.Windows.Forms.Label
    Friend WithEvents DTFECHAINI As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTFECHAFIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents CMDGUARDAR As System.Windows.Forms.Button
    Friend WithEvents CBOCONCEPTO As System.Windows.Forms.ComboBox
End Class
