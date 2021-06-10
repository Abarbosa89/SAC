<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NUEVOUSUARIO
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
        Me.components = New System.ComponentModel.Container()
        Me.TXTUSUARIO = New System.Windows.Forms.TextBox()
        Me.TXTNOMCOM = New System.Windows.Forms.TextBox()
        Me.TXTPASS = New System.Windows.Forms.TextBox()
        Me.TXTREPASS = New System.Windows.Forms.TextBox()
        Me.CBONIVEL = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.CMDGUARDAR = New System.Windows.Forms.Button()
        Me.SACDataSet = New SAC.SACDataSet()
        Me.SELECCIONARRANGOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARRANGOSTableAdapter1 = New SAC.SACDataSetTableAdapters.SELECCIONARRANGOSTableAdapter()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARRANGOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXTUSUARIO
        '
        Me.TXTUSUARIO.Location = New System.Drawing.Point(219, 24)
        Me.TXTUSUARIO.Name = "TXTUSUARIO"
        Me.TXTUSUARIO.Size = New System.Drawing.Size(204, 26)
        Me.TXTUSUARIO.TabIndex = 0
        '
        'TXTNOMCOM
        '
        Me.TXTNOMCOM.Location = New System.Drawing.Point(219, 56)
        Me.TXTNOMCOM.Name = "TXTNOMCOM"
        Me.TXTNOMCOM.Size = New System.Drawing.Size(433, 26)
        Me.TXTNOMCOM.TabIndex = 1
        '
        'TXTPASS
        '
        Me.TXTPASS.Location = New System.Drawing.Point(219, 120)
        Me.TXTPASS.Name = "TXTPASS"
        Me.TXTPASS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTPASS.Size = New System.Drawing.Size(204, 26)
        Me.TXTPASS.TabIndex = 2
        '
        'TXTREPASS
        '
        Me.TXTREPASS.Location = New System.Drawing.Point(219, 152)
        Me.TXTREPASS.Name = "TXTREPASS"
        Me.TXTREPASS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTREPASS.Size = New System.Drawing.Size(204, 26)
        Me.TXTREPASS.TabIndex = 3
        '
        'CBONIVEL
        '
        Me.CBONIVEL.DataSource = Me.SELECCIONARRANGOSBindingSource
        Me.CBONIVEL.DisplayMember = "Rango"
        Me.CBONIVEL.FormattingEnabled = True
        Me.CBONIVEL.Location = New System.Drawing.Point(219, 88)
        Me.CBONIVEL.Name = "CBONIVEL"
        Me.CBONIVEL.Size = New System.Drawing.Size(204, 26)
        Me.CBONIVEL.TabIndex = 4
        Me.CBONIVEL.ValueMember = "IdRango"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "NOMBRE DE USUARIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "NOMBRE COMPLETO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "NIVEL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(112, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "PASSWORD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "CONFIRMAR PASSWORD"
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Image = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR.Location = New System.Drawing.Point(347, 184)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(102, 61)
        Me.CMDCANCELAR.TabIndex = 11
        Me.CMDCANCELAR.Text = "CERRAR"
        Me.CMDCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'CMDGUARDAR
        '
        Me.CMDGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDGUARDAR.Image = Global.SAC.My.Resources.Resources.GUARDAR_REGISTRO1
        Me.CMDGUARDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDGUARDAR.Location = New System.Drawing.Point(219, 184)
        Me.CMDGUARDAR.Name = "CMDGUARDAR"
        Me.CMDGUARDAR.Size = New System.Drawing.Size(100, 61)
        Me.CMDGUARDAR.TabIndex = 10
        Me.CMDGUARDAR.Text = "GUARDAR"
        Me.CMDGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDGUARDAR.UseVisualStyleBackColor = True
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SELECCIONARRANGOSBindingSource
        '
        Me.SELECCIONARRANGOSBindingSource.DataMember = "SELECCIONARRANGOS"
        Me.SELECCIONARRANGOSBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARRANGOSTableAdapter1
        '
        Me.SELECCIONARRANGOSTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NUEVOUSUARIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 259)
        Me.ControlBox = False
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.CMDGUARDAR)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBONIVEL)
        Me.Controls.Add(Me.TXTREPASS)
        Me.Controls.Add(Me.TXTPASS)
        Me.Controls.Add(Me.TXTNOMCOM)
        Me.Controls.Add(Me.TXTUSUARIO)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NUEVOUSUARIO"
        Me.Text = "NUEVO USUARIO"
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARRANGOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXTUSUARIO As System.Windows.Forms.TextBox
    Friend WithEvents TXTNOMCOM As System.Windows.Forms.TextBox
    Friend WithEvents TXTPASS As System.Windows.Forms.TextBox
    Friend WithEvents TXTREPASS As System.Windows.Forms.TextBox
    Friend WithEvents CBONIVEL As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CMDGUARDAR As System.Windows.Forms.Button
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents SELECCIONARRANGOSTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARRANGOSTableAdapter
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents SELECCIONARRANGOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARRANGOSTableAdapter1 As SAC.SACDataSetTableAdapters.SELECCIONARRANGOSTableAdapter
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
End Class
