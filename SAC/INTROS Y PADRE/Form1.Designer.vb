<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Intro
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBOUSUARIO = New System.Windows.Forms.ComboBox()
        Me.USUARIOSACTIVOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SACDataSet = New SAC.SACDataSet()
        Me.TXTPASS = New System.Windows.Forms.TextBox()
        Me.CMDENTRAR = New System.Windows.Forms.Button()
        Me.USUARIOSACTIVOSTableAdapter = New SAC.SACDataSetTableAdapters.USUARIOSACTIVOSTableAdapter()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.CMDSALIR = New System.Windows.Forms.Button()
        Me.SELECCIONARUSUARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARUSUARIOTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARUSUARIOTableAdapter()
        Me.UsuarioLabel1 = New System.Windows.Forms.Label()
        Me.NomcomLabel1 = New System.Windows.Forms.Label()
        Me.IdRangoLabel1 = New System.Windows.Forms.Label()
        Me.PassLabel1 = New System.Windows.Forms.Label()
        Me.IdusLabel1 = New System.Windows.Forms.Label()
        Me.PassperdiCheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.USUARIOSACTIVOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARUSUARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "USUARIO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CONTRASEÑA:"
        '
        'CBOUSUARIO
        '
        Me.CBOUSUARIO.DataSource = Me.USUARIOSACTIVOSBindingSource
        Me.CBOUSUARIO.DisplayMember = "usuario"
        Me.CBOUSUARIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOUSUARIO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOUSUARIO.FormattingEnabled = True
        Me.CBOUSUARIO.Location = New System.Drawing.Point(137, 73)
        Me.CBOUSUARIO.Name = "CBOUSUARIO"
        Me.CBOUSUARIO.Size = New System.Drawing.Size(167, 26)
        Me.CBOUSUARIO.TabIndex = 3
        Me.CBOUSUARIO.ValueMember = "usuario"
        '
        'USUARIOSACTIVOSBindingSource
        '
        Me.USUARIOSACTIVOSBindingSource.DataMember = "USUARIOSACTIVOS"
        Me.USUARIOSACTIVOSBindingSource.DataSource = Me.SACDataSet
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TXTPASS
        '
        Me.TXTPASS.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPASS.Location = New System.Drawing.Point(137, 102)
        Me.TXTPASS.Name = "TXTPASS"
        Me.TXTPASS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTPASS.Size = New System.Drawing.Size(167, 26)
        Me.TXTPASS.TabIndex = 4
        '
        'CMDENTRAR
        '
        Me.CMDENTRAR.Location = New System.Drawing.Point(165, 146)
        Me.CMDENTRAR.Name = "CMDENTRAR"
        Me.CMDENTRAR.Size = New System.Drawing.Size(75, 23)
        Me.CMDENTRAR.TabIndex = 5
        Me.CMDENTRAR.Text = "ENTRAR"
        Me.CMDENTRAR.UseVisualStyleBackColor = True
        '
        'USUARIOSACTIVOSTableAdapter
        '
        Me.USUARIOSACTIVOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CMDSALIR
        '
        Me.CMDSALIR.BackgroundImage = Global.SAC.My.Resources.Resources.Visualpharm_Must_Have_Log_Out
        Me.CMDSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDSALIR.Location = New System.Drawing.Point(264, 132)
        Me.CMDSALIR.Name = "CMDSALIR"
        Me.CMDSALIR.Size = New System.Drawing.Size(40, 37)
        Me.CMDSALIR.TabIndex = 15
        Me.CMDSALIR.UseVisualStyleBackColor = True
        Me.CMDSALIR.Visible = False
        '
        'SELECCIONARUSUARIOBindingSource
        '
        Me.SELECCIONARUSUARIOBindingSource.DataMember = "SELECCIONARUSUARIO"
        Me.SELECCIONARUSUARIOBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARUSUARIOTableAdapter
        '
        Me.SELECCIONARUSUARIOTableAdapter.ClearBeforeFill = True
        '
        'UsuarioLabel1
        '
        Me.UsuarioLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARUSUARIOBindingSource, "usuario", True))
        Me.UsuarioLabel1.Location = New System.Drawing.Point(12, 306)
        Me.UsuarioLabel1.Name = "UsuarioLabel1"
        Me.UsuarioLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UsuarioLabel1.TabIndex = 19
        Me.UsuarioLabel1.Text = "Label3"
        '
        'NomcomLabel1
        '
        Me.NomcomLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARUSUARIOBindingSource, "nomcom", True))
        Me.NomcomLabel1.Location = New System.Drawing.Point(12, 283)
        Me.NomcomLabel1.Name = "NomcomLabel1"
        Me.NomcomLabel1.Size = New System.Drawing.Size(100, 23)
        Me.NomcomLabel1.TabIndex = 20
        Me.NomcomLabel1.Text = "Label3"
        '
        'IdRangoLabel1
        '
        Me.IdRangoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARUSUARIOBindingSource, "IdRango", True))
        Me.IdRangoLabel1.Location = New System.Drawing.Point(508, 138)
        Me.IdRangoLabel1.Name = "IdRangoLabel1"
        Me.IdRangoLabel1.Size = New System.Drawing.Size(100, 23)
        Me.IdRangoLabel1.TabIndex = 21
        Me.IdRangoLabel1.Text = "Label3"
        '
        'PassLabel1
        '
        Me.PassLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARUSUARIOBindingSource, "pass", True))
        Me.PassLabel1.Location = New System.Drawing.Point(12, 260)
        Me.PassLabel1.Name = "PassLabel1"
        Me.PassLabel1.Size = New System.Drawing.Size(100, 23)
        Me.PassLabel1.TabIndex = 22
        Me.PassLabel1.Text = "Label3"
        '
        'IdusLabel1
        '
        Me.IdusLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARUSUARIOBindingSource, "idus", True))
        Me.IdusLabel1.Location = New System.Drawing.Point(508, 115)
        Me.IdusLabel1.Name = "IdusLabel1"
        Me.IdusLabel1.Size = New System.Drawing.Size(100, 23)
        Me.IdusLabel1.TabIndex = 23
        Me.IdusLabel1.Text = "Label3"
        '
        'PassperdiCheckBox
        '
        Me.PassperdiCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SELECCIONARUSUARIOBindingSource, "passperdi", True))
        Me.PassperdiCheckBox.Location = New System.Drawing.Point(504, 156)
        Me.PassperdiCheckBox.Name = "PassperdiCheckBox"
        Me.PassperdiCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.PassperdiCheckBox.TabIndex = 24
        Me.PassperdiCheckBox.Text = "passperdido"
        Me.PassperdiCheckBox.UseVisualStyleBackColor = True
        '
        'Intro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 179)
        Me.Controls.Add(Me.PassperdiCheckBox)
        Me.Controls.Add(Me.IdusLabel1)
        Me.Controls.Add(Me.PassLabel1)
        Me.Controls.Add(Me.IdRangoLabel1)
        Me.Controls.Add(Me.NomcomLabel1)
        Me.Controls.Add(Me.UsuarioLabel1)
        Me.Controls.Add(Me.CMDSALIR)
        Me.Controls.Add(Me.CMDENTRAR)
        Me.Controls.Add(Me.TXTPASS)
        Me.Controls.Add(Me.CBOUSUARIO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Intro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COLEGIO DUMON v21.6.13"
        CType(Me.USUARIOSACTIVOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARUSUARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CBOUSUARIO As System.Windows.Forms.ComboBox
    Friend WithEvents TXTPASS As System.Windows.Forms.TextBox
    Friend WithEvents CMDENTRAR As System.Windows.Forms.Button
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents USUARIOSACTIVOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents USUARIOSACTIVOSTableAdapter As SAC.SACDataSetTableAdapters.USUARIOSACTIVOSTableAdapter
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CMDSALIR As System.Windows.Forms.Button
    Friend WithEvents SELECCIONARUSUARIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARUSUARIOTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARUSUARIOTableAdapter
    Friend WithEvents UsuarioLabel1 As System.Windows.Forms.Label
    Friend WithEvents NomcomLabel1 As System.Windows.Forms.Label
    Friend WithEvents IdRangoLabel1 As System.Windows.Forms.Label
    Friend WithEvents PassLabel1 As System.Windows.Forms.Label
    Friend WithEvents IdusLabel1 As System.Windows.Forms.Label
    Friend WithEvents PassperdiCheckBox As System.Windows.Forms.CheckBox

End Class
