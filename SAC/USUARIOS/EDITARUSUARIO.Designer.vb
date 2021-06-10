<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EDITARUSUARIO
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
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim NomcomLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBOUSUARIOS = New System.Windows.Forms.ComboBox()
        Me.SELECCIONARUSARIOSPORRANGOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SACDataSet = New SAC.SACDataSet()
        Me.SELECCIONARUSUARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.NomcomTextBox = New System.Windows.Forms.TextBox()
        Me.StatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.CMDGUARDAR = New System.Windows.Forms.Button()
        Me.CMDEDITAR1 = New System.Windows.Forms.Button()
        Me.CMDEDITAR2 = New System.Windows.Forms.Button()
        Me.SELECCIONARUSUARIOTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARUSUARIOTableAdapter()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.SELECCIONARUSARIOSPORRANGOTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARUSARIOSPORRANGOTableAdapter()
        Me.IdusLabel1 = New System.Windows.Forms.Label()
        UsuarioLabel = New System.Windows.Forms.Label()
        NomcomLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        CType(Me.SELECCIONARUSARIOSPORRANGOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARUSUARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Location = New System.Drawing.Point(100, 103)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(82, 18)
        UsuarioLabel.TabIndex = 3
        UsuarioLabel.Text = "USUARIO:"
        '
        'NomcomLabel
        '
        NomcomLabel.AutoSize = True
        NomcomLabel.Location = New System.Drawing.Point(13, 135)
        NomcomLabel.Name = "NomcomLabel"
        NomcomLabel.Size = New System.Drawing.Size(174, 18)
        NomcomLabel.TabIndex = 5
        NomcomLabel.Text = "NOMBRE COMPLETO:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(115, 161)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(72, 18)
        StatusLabel.TabIndex = 11
        StatusLabel.Text = "STATUS:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(155, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SELECCIONE USUARIO"
        '
        'CBOUSUARIOS
        '
        Me.CBOUSUARIOS.DataSource = Me.SELECCIONARUSARIOSPORRANGOBindingSource
        Me.CBOUSUARIOS.DisplayMember = "usuario"
        Me.CBOUSUARIOS.FormattingEnabled = True
        Me.CBOUSUARIOS.Location = New System.Drawing.Point(158, 30)
        Me.CBOUSUARIOS.Name = "CBOUSUARIOS"
        Me.CBOUSUARIOS.Size = New System.Drawing.Size(182, 26)
        Me.CBOUSUARIOS.TabIndex = 1
        Me.CBOUSUARIOS.ValueMember = "usuario"
        '
        'SELECCIONARUSARIOSPORRANGOBindingSource
        '
        Me.SELECCIONARUSARIOSPORRANGOBindingSource.DataMember = "SELECCIONARUSARIOSPORRANGO"
        Me.SELECCIONARUSARIOSPORRANGOBindingSource.DataSource = Me.SACDataSet
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SELECCIONARUSUARIOBindingSource
        '
        Me.SELECCIONARUSUARIOBindingSource.DataMember = "SELECCIONARUSUARIO"
        Me.SELECCIONARUSUARIOBindingSource.DataSource = Me.SACDataSet
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.BackColor = System.Drawing.Color.Gold
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.SELECCIONARUSUARIOBindingSource, "usuario", True))
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARUSUARIOBindingSource, "usuario", True))
        Me.UsuarioTextBox.Location = New System.Drawing.Point(188, 100)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.ReadOnly = True
        Me.UsuarioTextBox.Size = New System.Drawing.Size(240, 26)
        Me.UsuarioTextBox.TabIndex = 4
        '
        'NomcomTextBox
        '
        Me.NomcomTextBox.BackColor = System.Drawing.Color.Gold
        Me.NomcomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARUSUARIOBindingSource, "nomcom", True))
        Me.NomcomTextBox.Location = New System.Drawing.Point(188, 132)
        Me.NomcomTextBox.Name = "NomcomTextBox"
        Me.NomcomTextBox.ReadOnly = True
        Me.NomcomTextBox.Size = New System.Drawing.Size(240, 26)
        Me.NomcomTextBox.TabIndex = 6
        '
        'StatusCheckBox
        '
        Me.StatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SELECCIONARUSUARIOBindingSource, "status", True))
        Me.StatusCheckBox.Location = New System.Drawing.Point(304, 161)
        Me.StatusCheckBox.Name = "StatusCheckBox"
        Me.StatusCheckBox.Size = New System.Drawing.Size(36, 24)
        Me.StatusCheckBox.TabIndex = 12
        Me.StatusCheckBox.UseVisualStyleBackColor = True
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImage = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Location = New System.Drawing.Point(256, 201)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(42, 40)
        Me.CMDCANCELAR.TabIndex = 14
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'CMDGUARDAR
        '
        Me.CMDGUARDAR.BackgroundImage = Global.SAC.My.Resources.Resources.GUARDAR_REGISTRO1
        Me.CMDGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDGUARDAR.Location = New System.Drawing.Point(188, 201)
        Me.CMDGUARDAR.Name = "CMDGUARDAR"
        Me.CMDGUARDAR.Size = New System.Drawing.Size(42, 40)
        Me.CMDGUARDAR.TabIndex = 13
        Me.CMDGUARDAR.UseVisualStyleBackColor = True
        '
        'CMDEDITAR1
        '
        Me.CMDEDITAR1.BackgroundImage = Global.SAC.My.Resources.Resources.Pencil
        Me.CMDEDITAR1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDEDITAR1.Location = New System.Drawing.Point(434, 103)
        Me.CMDEDITAR1.Name = "CMDEDITAR1"
        Me.CMDEDITAR1.Size = New System.Drawing.Size(26, 23)
        Me.CMDEDITAR1.TabIndex = 15
        Me.CMDEDITAR1.UseVisualStyleBackColor = True
        '
        'CMDEDITAR2
        '
        Me.CMDEDITAR2.BackgroundImage = Global.SAC.My.Resources.Resources.Pencil
        Me.CMDEDITAR2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDEDITAR2.Location = New System.Drawing.Point(434, 133)
        Me.CMDEDITAR2.Name = "CMDEDITAR2"
        Me.CMDEDITAR2.Size = New System.Drawing.Size(26, 23)
        Me.CMDEDITAR2.TabIndex = 16
        Me.CMDEDITAR2.UseVisualStyleBackColor = True
        '
        'SELECCIONARUSUARIOTableAdapter
        '
        Me.SELECCIONARUSUARIOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SELECCIONARUSARIOSPORRANGOTableAdapter
        '
        Me.SELECCIONARUSARIOSPORRANGOTableAdapter.ClearBeforeFill = True
        '
        'IdusLabel1
        '
        Me.IdusLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARUSUARIOBindingSource, "idus", True))
        Me.IdusLabel1.Location = New System.Drawing.Point(12, 236)
        Me.IdusLabel1.Name = "IdusLabel1"
        Me.IdusLabel1.Size = New System.Drawing.Size(100, 23)
        Me.IdusLabel1.TabIndex = 17
        Me.IdusLabel1.Text = "Label2"
        '
        'EDITARUSUARIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.IdusLabel1)
        Me.Controls.Add(Me.CMDEDITAR2)
        Me.Controls.Add(Me.CMDEDITAR1)
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.CMDGUARDAR)
        Me.Controls.Add(UsuarioLabel)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(NomcomLabel)
        Me.Controls.Add(Me.NomcomTextBox)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusCheckBox)
        Me.Controls.Add(Me.CBOUSUARIOS)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "EDITARUSUARIO"
        Me.Text = "EDITARUSUARIO"
        CType(Me.SELECCIONARUSARIOSPORRANGOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARUSUARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBOUSUARIOS As System.Windows.Forms.ComboBox
    Friend WithEvents UsuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomcomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents CMDGUARDAR As System.Windows.Forms.Button
    Friend WithEvents CMDEDITAR1 As System.Windows.Forms.Button
    Friend WithEvents CMDEDITAR2 As System.Windows.Forms.Button
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents SELECCIONARUSUARIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARUSUARIOTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARUSUARIOTableAdapter
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SELECCIONARUSARIOSPORRANGOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARUSARIOSPORRANGOTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARUSARIOSPORRANGOTableAdapter
    Friend WithEvents IdusLabel1 As System.Windows.Forms.Label
End Class
