<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarNuevoCiclo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarNuevoCiclo))
        Me.cboCicloIni = New System.Windows.Forms.ComboBox()
        Me.cbdCicloFin = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtFInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtFFinal = New System.Windows.Forms.DateTimePicker()
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboCicloIni
        '
        Me.cboCicloIni.FormattingEnabled = True
        Me.cboCicloIni.Items.AddRange(New Object() {"2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035"})
        Me.cboCicloIni.Location = New System.Drawing.Point(61, 12)
        Me.cboCicloIni.Name = "cboCicloIni"
        Me.cboCicloIni.Size = New System.Drawing.Size(146, 28)
        Me.cboCicloIni.TabIndex = 0
        '
        'cbdCicloFin
        '
        Me.cbdCicloFin.FormattingEnabled = True
        Me.cbdCicloFin.Items.AddRange(New Object() {"2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035"})
        Me.cbdCicloFin.Location = New System.Drawing.Point(238, 12)
        Me.cbdCicloFin.Name = "cbdCicloFin"
        Me.cbdCicloFin.Size = New System.Drawing.Size(146, 28)
        Me.cbdCicloFin.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ciclo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(213, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "al"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha Inicio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(199, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fecha Fin:"
        '
        'dtFInicio
        '
        Me.dtFInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFInicio.Location = New System.Drawing.Point(92, 58)
        Me.dtFInicio.Name = "dtFInicio"
        Me.dtFInicio.Size = New System.Drawing.Size(101, 26)
        Me.dtFInicio.TabIndex = 6
        '
        'dtFFinal
        '
        Me.dtFFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFFinal.Location = New System.Drawing.Point(277, 58)
        Me.dtFFinal.Name = "dtFFinal"
        Me.dtFFinal.Size = New System.Drawing.Size(107, 26)
        Me.dtFFinal.TabIndex = 7
        '
        'cmdCrear
        '
        Me.cmdCrear.Location = New System.Drawing.Point(156, 90)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.Size = New System.Drawing.Size(88, 35)
        Me.cmdCrear.TabIndex = 8
        Me.cmdCrear.Text = "Crear Ciclo"
        Me.cmdCrear.UseVisualStyleBackColor = True
        '
        'AgregarNuevoCiclo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 137)
        Me.Controls.Add(Me.cmdCrear)
        Me.Controls.Add(Me.dtFFinal)
        Me.Controls.Add(Me.dtFInicio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbdCicloFin)
        Me.Controls.Add(Me.cboCicloIni)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AgregarNuevoCiclo"
        Me.Text = "Nuevo Ciclo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboCicloIni As System.Windows.Forms.ComboBox
    Friend WithEvents cbdCicloFin As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtFInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdCrear As System.Windows.Forms.Button
End Class
