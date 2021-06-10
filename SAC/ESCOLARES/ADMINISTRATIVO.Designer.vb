<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMINISTRATIVO
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
        Me.GPADMINISTRADOR = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CMDMODIFICARFACTURAS = New System.Windows.Forms.Button()
        Me.CMDBECAS = New System.Windows.Forms.Button()
        Me.CMDELIMINARMOV = New System.Windows.Forms.Button()
        Me.CMDMODIFICARPRODUCTOS = New System.Windows.Forms.Button()
        Me.CMDCRARPRDUCTO = New System.Windows.Forms.Button()
        Me.CMDMOFICIARMOV = New System.Windows.Forms.Button()
        Me.CMDUSUARIOS = New System.Windows.Forms.Button()
        Me.GPUSER = New System.Windows.Forms.GroupBox()
        Me.CMDREPORTES = New System.Windows.Forms.Button()
        Me.CMDADEUDOALUMNO = New System.Windows.Forms.Button()
        Me.GPTODOS = New System.Windows.Forms.GroupBox()
        Me.CMDDETALLESTUTOTES = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CMDPAGOSALUM = New System.Windows.Forms.Button()
        Me.CMDALUMNOS = New System.Windows.Forms.Button()
        Me.CMDTUTORES = New System.Windows.Forms.Button()
        Me.CMDREIMPRESION = New System.Windows.Forms.Button()
        Me.CMDDETALLESALUM = New System.Windows.Forms.Button()
        Me.CMDPEDIDOUNIFORM = New System.Windows.Forms.Button()
        Me.CMDFLASHPAGOSALUM = New System.Windows.Forms.Button()
        Me.CMDFLASHDETALLESALUM = New System.Windows.Forms.Button()
        Me.CMDSALIR = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GPADMINISTRADOR.SuspendLayout()
        Me.GPUSER.SuspendLayout()
        Me.GPTODOS.SuspendLayout()
        Me.SuspendLayout()
        '
        'GPADMINISTRADOR
        '
        Me.GPADMINISTRADOR.Controls.Add(Me.Button3)
        Me.GPADMINISTRADOR.Controls.Add(Me.Button1)
        Me.GPADMINISTRADOR.Controls.Add(Me.CMDMODIFICARFACTURAS)
        Me.GPADMINISTRADOR.Controls.Add(Me.CMDBECAS)
        Me.GPADMINISTRADOR.Controls.Add(Me.CMDELIMINARMOV)
        Me.GPADMINISTRADOR.Controls.Add(Me.CMDMODIFICARPRODUCTOS)
        Me.GPADMINISTRADOR.Controls.Add(Me.CMDCRARPRDUCTO)
        Me.GPADMINISTRADOR.Controls.Add(Me.CMDMOFICIARMOV)
        Me.GPADMINISTRADOR.Controls.Add(Me.CMDUSUARIOS)
        Me.GPADMINISTRADOR.Location = New System.Drawing.Point(439, 12)
        Me.GPADMINISTRADOR.Name = "GPADMINISTRADOR"
        Me.GPADMINISTRADOR.Size = New System.Drawing.Size(413, 378)
        Me.GPADMINISTRADOR.TabIndex = 31
        Me.GPADMINISTRADOR.TabStop = False
        Me.GPADMINISTRADOR.Text = "ADMINISTRADOR"
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Image = Global.SAC.My.Resources.Resources.Pencil
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(145, 193)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 78)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "REPORTE FACTURA "
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CMDMODIFICARFACTURAS
        '
        Me.CMDMODIFICARFACTURAS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDMODIFICARFACTURAS.Image = Global.SAC.My.Resources.Resources.Pencil
        Me.CMDMODIFICARFACTURAS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDMODIFICARFACTURAS.Location = New System.Drawing.Point(6, 193)
        Me.CMDMODIFICARFACTURAS.Name = "CMDMODIFICARFACTURAS"
        Me.CMDMODIFICARFACTURAS.Size = New System.Drawing.Size(123, 78)
        Me.CMDMODIFICARFACTURAS.TabIndex = 26
        Me.CMDMODIFICARFACTURAS.Text = "MODIFICAR FACTURAS"
        Me.CMDMODIFICARFACTURAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDMODIFICARFACTURAS.UseVisualStyleBackColor = True
        '
        'CMDBECAS
        '
        Me.CMDBECAS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDBECAS.Image = Global.SAC.My.Resources.Resources.SIMULADOR
        Me.CMDBECAS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDBECAS.Location = New System.Drawing.Point(6, 25)
        Me.CMDBECAS.Name = "CMDBECAS"
        Me.CMDBECAS.Size = New System.Drawing.Size(123, 78)
        Me.CMDBECAS.TabIndex = 7
        Me.CMDBECAS.Text = "ASIGNAR BECAS"
        Me.CMDBECAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDBECAS.UseVisualStyleBackColor = True
        '
        'CMDELIMINARMOV
        '
        Me.CMDELIMINARMOV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDELIMINARMOV.Image = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDELIMINARMOV.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDELIMINARMOV.Location = New System.Drawing.Point(145, 25)
        Me.CMDELIMINARMOV.Name = "CMDELIMINARMOV"
        Me.CMDELIMINARMOV.Size = New System.Drawing.Size(123, 78)
        Me.CMDELIMINARMOV.TabIndex = 12
        Me.CMDELIMINARMOV.Text = "ELIMINAR MOV"
        Me.CMDELIMINARMOV.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDELIMINARMOV.UseVisualStyleBackColor = True
        '
        'CMDMODIFICARPRODUCTOS
        '
        Me.CMDMODIFICARPRODUCTOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDMODIFICARPRODUCTOS.Image = Global.SAC.My.Resources.Resources.Pencil
        Me.CMDMODIFICARPRODUCTOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDMODIFICARPRODUCTOS.Location = New System.Drawing.Point(282, 25)
        Me.CMDMODIFICARPRODUCTOS.Name = "CMDMODIFICARPRODUCTOS"
        Me.CMDMODIFICARPRODUCTOS.Size = New System.Drawing.Size(123, 78)
        Me.CMDMODIFICARPRODUCTOS.TabIndex = 28
        Me.CMDMODIFICARPRODUCTOS.Text = "MODIFICAR PRODUCTOS"
        Me.CMDMODIFICARPRODUCTOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDMODIFICARPRODUCTOS.UseVisualStyleBackColor = True
        '
        'CMDCRARPRDUCTO
        '
        Me.CMDCRARPRDUCTO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCRARPRDUCTO.Image = Global.SAC.My.Resources.Resources._19764_bubka_Add_vista
        Me.CMDCRARPRDUCTO.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCRARPRDUCTO.Location = New System.Drawing.Point(6, 109)
        Me.CMDCRARPRDUCTO.Name = "CMDCRARPRDUCTO"
        Me.CMDCRARPRDUCTO.Size = New System.Drawing.Size(123, 78)
        Me.CMDCRARPRDUCTO.TabIndex = 13
        Me.CMDCRARPRDUCTO.Text = "CREAR PRODUCTO"
        Me.CMDCRARPRDUCTO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCRARPRDUCTO.UseVisualStyleBackColor = True
        '
        'CMDMOFICIARMOV
        '
        Me.CMDMOFICIARMOV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDMOFICIARMOV.Image = Global.SAC.My.Resources.Resources.Pencil
        Me.CMDMOFICIARMOV.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDMOFICIARMOV.Location = New System.Drawing.Point(282, 109)
        Me.CMDMOFICIARMOV.Name = "CMDMOFICIARMOV"
        Me.CMDMOFICIARMOV.Size = New System.Drawing.Size(123, 78)
        Me.CMDMOFICIARMOV.TabIndex = 27
        Me.CMDMOFICIARMOV.Text = "MODIFICAR PAGOS"
        Me.CMDMOFICIARMOV.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDMOFICIARMOV.UseVisualStyleBackColor = True
        '
        'CMDUSUARIOS
        '
        Me.CMDUSUARIOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CMDUSUARIOS.Image = Global.SAC.My.Resources.Resources.group
        Me.CMDUSUARIOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDUSUARIOS.Location = New System.Drawing.Point(145, 109)
        Me.CMDUSUARIOS.Name = "CMDUSUARIOS"
        Me.CMDUSUARIOS.Size = New System.Drawing.Size(123, 78)
        Me.CMDUSUARIOS.TabIndex = 3
        Me.CMDUSUARIOS.Text = "EDICION USUARIOS"
        Me.CMDUSUARIOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDUSUARIOS.UseVisualStyleBackColor = True
        '
        'GPUSER
        '
        Me.GPUSER.Controls.Add(Me.CMDREPORTES)
        Me.GPUSER.Controls.Add(Me.CMDADEUDOALUMNO)
        Me.GPUSER.Location = New System.Drawing.Point(300, 12)
        Me.GPUSER.Name = "GPUSER"
        Me.GPUSER.Size = New System.Drawing.Size(133, 378)
        Me.GPUSER.TabIndex = 32
        Me.GPUSER.TabStop = False
        Me.GPUSER.Text = "USUARIO"
        '
        'CMDREPORTES
        '
        Me.CMDREPORTES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDREPORTES.Image = Global.SAC.My.Resources.Resources.REPORTE
        Me.CMDREPORTES.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDREPORTES.Location = New System.Drawing.Point(6, 21)
        Me.CMDREPORTES.Name = "CMDREPORTES"
        Me.CMDREPORTES.Size = New System.Drawing.Size(114, 82)
        Me.CMDREPORTES.TabIndex = 6
        Me.CMDREPORTES.Text = "CREAR REPORTES"
        Me.CMDREPORTES.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDREPORTES.UseVisualStyleBackColor = True
        '
        'CMDADEUDOALUMNO
        '
        Me.CMDADEUDOALUMNO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDADEUDOALUMNO.Image = Global.SAC.My.Resources.Resources.COBRANZA
        Me.CMDADEUDOALUMNO.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDADEUDOALUMNO.Location = New System.Drawing.Point(6, 109)
        Me.CMDADEUDOALUMNO.Name = "CMDADEUDOALUMNO"
        Me.CMDADEUDOALUMNO.Size = New System.Drawing.Size(114, 82)
        Me.CMDADEUDOALUMNO.TabIndex = 25
        Me.CMDADEUDOALUMNO.Text = "ADEUDOS ALUMNO"
        Me.CMDADEUDOALUMNO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDADEUDOALUMNO.UseVisualStyleBackColor = True
        '
        'GPTODOS
        '
        Me.GPTODOS.Controls.Add(Me.CMDDETALLESTUTOTES)
        Me.GPTODOS.Controls.Add(Me.Button2)
        Me.GPTODOS.Controls.Add(Me.CMDPAGOSALUM)
        Me.GPTODOS.Controls.Add(Me.CMDALUMNOS)
        Me.GPTODOS.Controls.Add(Me.CMDTUTORES)
        Me.GPTODOS.Controls.Add(Me.CMDREIMPRESION)
        Me.GPTODOS.Controls.Add(Me.CMDDETALLESALUM)
        Me.GPTODOS.Controls.Add(Me.CMDPEDIDOUNIFORM)
        Me.GPTODOS.Controls.Add(Me.CMDFLASHPAGOSALUM)
        Me.GPTODOS.Controls.Add(Me.CMDFLASHDETALLESALUM)
        Me.GPTODOS.Location = New System.Drawing.Point(12, 12)
        Me.GPTODOS.Name = "GPTODOS"
        Me.GPTODOS.Size = New System.Drawing.Size(282, 378)
        Me.GPTODOS.TabIndex = 33
        Me.GPTODOS.TabStop = False
        Me.GPTODOS.Text = "TODOS"
        '
        'CMDDETALLESTUTOTES
        '
        Me.CMDDETALLESTUTOTES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDDETALLESTUTOTES.Image = Global.SAC.My.Resources.Resources.USERS__2_
        Me.CMDDETALLESTUTOTES.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDDETALLESTUTOTES.Location = New System.Drawing.Point(153, 105)
        Me.CMDDETALLESTUTOTES.Name = "CMDDETALLESTUTOTES"
        Me.CMDDETALLESTUTOTES.Size = New System.Drawing.Size(114, 82)
        Me.CMDDETALLESTUTOTES.TabIndex = 31
        Me.CMDDETALLESTUTOTES.Text = "DETALLES TUTORES"
        Me.CMDDETALLESTUTOTES.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDDETALLESTUTOTES.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Image = Global.SAC.My.Resources.Resources.REPORTE
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(6, 278)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 82)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "CORTE DIARIO"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CMDPAGOSALUM
        '
        Me.CMDPAGOSALUM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDPAGOSALUM.Image = Global.SAC.My.Resources.Resources.EMPEÑO
        Me.CMDPAGOSALUM.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDPAGOSALUM.Location = New System.Drawing.Point(6, 105)
        Me.CMDPAGOSALUM.Name = "CMDPAGOSALUM"
        Me.CMDPAGOSALUM.Size = New System.Drawing.Size(114, 82)
        Me.CMDPAGOSALUM.TabIndex = 14
        Me.CMDPAGOSALUM.Text = "PAGOS ALUMNO"
        Me.CMDPAGOSALUM.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDPAGOSALUM.UseVisualStyleBackColor = True
        '
        'CMDALUMNOS
        '
        Me.CMDALUMNOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDALUMNOS.Image = Global.SAC.My.Resources.Resources.Deleket_Soft_Scraps_User_Group
        Me.CMDALUMNOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDALUMNOS.Location = New System.Drawing.Point(6, 23)
        Me.CMDALUMNOS.Name = "CMDALUMNOS"
        Me.CMDALUMNOS.Size = New System.Drawing.Size(114, 78)
        Me.CMDALUMNOS.TabIndex = 4
        Me.CMDALUMNOS.Text = "MODIFICAR ALUMNO"
        Me.CMDALUMNOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDALUMNOS.UseVisualStyleBackColor = True
        '
        'CMDTUTORES
        '
        Me.CMDTUTORES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDTUTORES.Image = Global.SAC.My.Resources.Resources.USERS__2_
        Me.CMDTUTORES.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDTUTORES.Location = New System.Drawing.Point(153, 23)
        Me.CMDTUTORES.Name = "CMDTUTORES"
        Me.CMDTUTORES.Size = New System.Drawing.Size(114, 78)
        Me.CMDTUTORES.TabIndex = 5
        Me.CMDTUTORES.Text = "MODIFICAR TUTOR"
        Me.CMDTUTORES.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDTUTORES.UseVisualStyleBackColor = True
        '
        'CMDREIMPRESION
        '
        Me.CMDREIMPRESION.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDREIMPRESION.Image = Global.SAC.My.Resources.Resources.PRINTER
        Me.CMDREIMPRESION.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDREIMPRESION.Location = New System.Drawing.Point(153, 278)
        Me.CMDREIMPRESION.Name = "CMDREIMPRESION"
        Me.CMDREIMPRESION.Size = New System.Drawing.Size(114, 82)
        Me.CMDREIMPRESION.TabIndex = 30
        Me.CMDREIMPRESION.Text = "REIMPRIMIR REC O FOL"
        Me.CMDREIMPRESION.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDREIMPRESION.UseVisualStyleBackColor = True
        '
        'CMDDETALLESALUM
        '
        Me.CMDDETALLESALUM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDDETALLESALUM.Image = Global.SAC.My.Resources.Resources.Deleket_Soft_Scraps_User_Group
        Me.CMDDETALLESALUM.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDDETALLESALUM.Location = New System.Drawing.Point(6, 193)
        Me.CMDDETALLESALUM.Name = "CMDDETALLESALUM"
        Me.CMDDETALLESALUM.Size = New System.Drawing.Size(114, 82)
        Me.CMDDETALLESALUM.TabIndex = 15
        Me.CMDDETALLESALUM.Text = "DETALLES ALUMNOS"
        Me.CMDDETALLESALUM.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDDETALLESALUM.UseVisualStyleBackColor = True
        '
        'CMDPEDIDOUNIFORM
        '
        Me.CMDPEDIDOUNIFORM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDPEDIDOUNIFORM.Image = Global.SAC.My.Resources.Resources.Iconshock_Real_Vista_General_Administrator
        Me.CMDPEDIDOUNIFORM.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDPEDIDOUNIFORM.Location = New System.Drawing.Point(153, 193)
        Me.CMDPEDIDOUNIFORM.Name = "CMDPEDIDOUNIFORM"
        Me.CMDPEDIDOUNIFORM.Size = New System.Drawing.Size(114, 82)
        Me.CMDPEDIDOUNIFORM.TabIndex = 29
        Me.CMDPEDIDOUNIFORM.Text = "PEDIDOS UNIFORMES"
        Me.CMDPEDIDOUNIFORM.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDPEDIDOUNIFORM.UseVisualStyleBackColor = True
        '
        'CMDFLASHPAGOSALUM
        '
        Me.CMDFLASHPAGOSALUM.BackgroundImage = Global.SAC.My.Resources.Resources.AYUDA
        Me.CMDFLASHPAGOSALUM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDFLASHPAGOSALUM.Location = New System.Drawing.Point(126, 167)
        Me.CMDFLASHPAGOSALUM.Name = "CMDFLASHPAGOSALUM"
        Me.CMDFLASHPAGOSALUM.Size = New System.Drawing.Size(20, 20)
        Me.CMDFLASHPAGOSALUM.TabIndex = 16
        Me.CMDFLASHPAGOSALUM.UseVisualStyleBackColor = True
        '
        'CMDFLASHDETALLESALUM
        '
        Me.CMDFLASHDETALLESALUM.BackgroundImage = Global.SAC.My.Resources.Resources.AYUDA
        Me.CMDFLASHDETALLESALUM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDFLASHDETALLESALUM.Location = New System.Drawing.Point(126, 252)
        Me.CMDFLASHDETALLESALUM.Name = "CMDFLASHDETALLESALUM"
        Me.CMDFLASHDETALLESALUM.Size = New System.Drawing.Size(20, 20)
        Me.CMDFLASHDETALLESALUM.TabIndex = 17
        Me.CMDFLASHDETALLESALUM.UseVisualStyleBackColor = True
        '
        'CMDSALIR
        '
        Me.CMDSALIR.BackgroundImage = Global.SAC.My.Resources.Resources.Visualpharm_Must_Have_Log_Out
        Me.CMDSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDSALIR.Location = New System.Drawing.Point(12, 425)
        Me.CMDSALIR.Name = "CMDSALIR"
        Me.CMDSALIR.Size = New System.Drawing.Size(40, 37)
        Me.CMDSALIR.TabIndex = 11
        Me.CMDSALIR.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Image = Global.SAC.My.Resources.Resources.SIMULADOR
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(282, 193)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 78)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "NUEVO CICLO"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ADMINISTRATIVO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(861, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.GPTODOS)
        Me.Controls.Add(Me.GPUSER)
        Me.Controls.Add(Me.GPADMINISTRADOR)
        Me.Controls.Add(Me.CMDSALIR)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ADMINISTRATIVO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADMINISTRATIVO"
        Me.GPADMINISTRADOR.ResumeLayout(False)
        Me.GPUSER.ResumeLayout(False)
        Me.GPTODOS.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMDUSUARIOS As System.Windows.Forms.Button
    Friend WithEvents CMDALUMNOS As System.Windows.Forms.Button
    Friend WithEvents CMDTUTORES As System.Windows.Forms.Button
    Friend WithEvents CMDREPORTES As System.Windows.Forms.Button
    Friend WithEvents CMDBECAS As System.Windows.Forms.Button
    Friend WithEvents CMDSALIR As System.Windows.Forms.Button
    Friend WithEvents CMDELIMINARMOV As System.Windows.Forms.Button
    Friend WithEvents CMDCRARPRDUCTO As System.Windows.Forms.Button
    Friend WithEvents CMDPAGOSALUM As System.Windows.Forms.Button
    Friend WithEvents CMDDETALLESALUM As System.Windows.Forms.Button
    Friend WithEvents CMDFLASHPAGOSALUM As System.Windows.Forms.Button
    Friend WithEvents CMDFLASHDETALLESALUM As System.Windows.Forms.Button
    Friend WithEvents CMDADEUDOALUMNO As System.Windows.Forms.Button
    Friend WithEvents CMDMODIFICARFACTURAS As System.Windows.Forms.Button
    Friend WithEvents CMDMOFICIARMOV As System.Windows.Forms.Button
    Friend WithEvents CMDMODIFICARPRODUCTOS As System.Windows.Forms.Button
    Friend WithEvents CMDPEDIDOUNIFORM As System.Windows.Forms.Button
    Friend WithEvents CMDREIMPRESION As System.Windows.Forms.Button
    Friend WithEvents GPADMINISTRADOR As System.Windows.Forms.GroupBox
    Friend WithEvents GPUSER As System.Windows.Forms.GroupBox
    Friend WithEvents GPTODOS As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CMDDETALLESTUTOTES As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
