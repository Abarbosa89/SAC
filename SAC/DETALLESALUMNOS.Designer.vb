<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DETALLESALUMNOS
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
        Me.TXTAPPAT = New System.Windows.Forms.TextBox()
        Me.LBLAPPATERNO = New System.Windows.Forms.Label()
        Me.LBLAPMAT = New System.Windows.Forms.Label()
        Me.TXTAPMAT = New System.Windows.Forms.TextBox()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.LBLNOMBRE = New System.Windows.Forms.Label()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.LBLMATRI = New System.Windows.Forms.Label()
        Me.TXTMATRICULA = New System.Windows.Forms.TextBox()
        Me.SACDataSet = New SAC.SACDataSet()
        Me.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSTableAdapter()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.RBMATRICULA = New System.Windows.Forms.RadioButton()
        Me.RBNOMBRE = New System.Windows.Forms.RadioButton()
        Me.CMDOK = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "BUSCAR POR:"
        '
        'TXTAPPAT
        '
        Me.TXTAPPAT.Location = New System.Drawing.Point(63, 127)
        Me.TXTAPPAT.Name = "TXTAPPAT"
        Me.TXTAPPAT.Size = New System.Drawing.Size(203, 26)
        Me.TXTAPPAT.TabIndex = 3
        Me.TXTAPPAT.Visible = False
        '
        'LBLAPPATERNO
        '
        Me.LBLAPPATERNO.AutoSize = True
        Me.LBLAPPATERNO.Location = New System.Drawing.Point(74, 104)
        Me.LBLAPPATERNO.Name = "LBLAPPATERNO"
        Me.LBLAPPATERNO.Size = New System.Drawing.Size(110, 20)
        Me.LBLAPPATERNO.TabIndex = 4
        Me.LBLAPPATERNO.Text = "AP PATERNO"
        Me.LBLAPPATERNO.Visible = False
        '
        'LBLAPMAT
        '
        Me.LBLAPMAT.AutoSize = True
        Me.LBLAPMAT.Location = New System.Drawing.Point(291, 104)
        Me.LBLAPMAT.Name = "LBLAPMAT"
        Me.LBLAPMAT.Size = New System.Drawing.Size(113, 20)
        Me.LBLAPMAT.TabIndex = 5
        Me.LBLAPMAT.Text = "AP MATERNO"
        Me.LBLAPMAT.Visible = False
        '
        'TXTAPMAT
        '
        Me.TXTAPMAT.Location = New System.Drawing.Point(288, 127)
        Me.TXTAPMAT.Name = "TXTAPMAT"
        Me.TXTAPMAT.Size = New System.Drawing.Size(190, 26)
        Me.TXTAPMAT.TabIndex = 6
        Me.TXTAPMAT.Visible = False
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Location = New System.Drawing.Point(511, 127)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(221, 26)
        Me.TXTNOMBRE.TabIndex = 7
        Me.TXTNOMBRE.Visible = False
        '
        'LBLNOMBRE
        '
        Me.LBLNOMBRE.AutoSize = True
        Me.LBLNOMBRE.Location = New System.Drawing.Point(514, 104)
        Me.LBLNOMBRE.Name = "LBLNOMBRE"
        Me.LBLNOMBRE.Size = New System.Drawing.Size(79, 20)
        Me.LBLNOMBRE.TabIndex = 8
        Me.LBLNOMBRE.Text = "NOMBRE"
        Me.LBLNOMBRE.Visible = False
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Image = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR.Location = New System.Drawing.Point(315, 391)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(101, 59)
        Me.CMDCANCELAR.TabIndex = 38
        Me.CMDCANCELAR.Text = "CERRAR"
        Me.CMDCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'LBLMATRI
        '
        Me.LBLMATRI.AutoSize = True
        Me.LBLMATRI.Location = New System.Drawing.Point(74, 45)
        Me.LBLMATRI.Name = "LBLMATRI"
        Me.LBLMATRI.Size = New System.Drawing.Size(102, 20)
        Me.LBLMATRI.TabIndex = 40
        Me.LBLMATRI.Text = "MATRICULA"
        Me.LBLMATRI.Visible = False
        '
        'TXTMATRICULA
        '
        Me.TXTMATRICULA.Location = New System.Drawing.Point(63, 68)
        Me.TXTMATRICULA.Name = "TXTMATRICULA"
        Me.TXTMATRICULA.Size = New System.Drawing.Size(203, 26)
        Me.TXTMATRICULA.TabIndex = 39
        Me.TXTMATRICULA.Visible = False
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SELECCIONARALUMNOSINSCRITOSNOINSCRITOSBindingSource
        '
        Me.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSBindingSource.DataMember = "SELECCIONARALUMNOSINSCRITOSNOINSCRITOS"
        Me.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARALUMNOSINSCRITOSNOINSCRITOSTableAdapter
        '
        Me.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SELECCIONARALUMNOSINSCRITOSNOINSCRITOSDataGridView
        '
        Me.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSDataGridView.AllowUserToAddRows = False
        Me.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSDataGridView.AllowUserToDeleteRows = False
        Me.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSDataGridView.AutoGenerateColumns = False
        Me.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewCheckBoxColumn1})
        Me.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSDataGridView.DataSource = Me.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSBindingSource
        Me.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSDataGridView.Location = New System.Drawing.Point(16, 162)
        Me.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSDataGridView.Name = "SELECCIONARALUMNOSINSCRITOSNOINSCRITOSDataGridView"
        Me.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSDataGridView.ReadOnly = True
        Me.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSDataGridView.Size = New System.Drawing.Size(742, 220)
        Me.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSDataGridView.TabIndex = 42
        '
        'RBMATRICULA
        '
        Me.RBMATRICULA.AutoSize = True
        Me.RBMATRICULA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBMATRICULA.Location = New System.Drawing.Point(203, 8)
        Me.RBMATRICULA.Name = "RBMATRICULA"
        Me.RBMATRICULA.Size = New System.Drawing.Size(129, 24)
        Me.RBMATRICULA.TabIndex = 43
        Me.RBMATRICULA.TabStop = True
        Me.RBMATRICULA.Text = "MATRICULA"
        Me.RBMATRICULA.UseVisualStyleBackColor = True
        '
        'RBNOMBRE
        '
        Me.RBNOMBRE.AutoSize = True
        Me.RBNOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBNOMBRE.Location = New System.Drawing.Point(412, 8)
        Me.RBNOMBRE.Name = "RBNOMBRE"
        Me.RBNOMBRE.Size = New System.Drawing.Size(103, 24)
        Me.RBNOMBRE.TabIndex = 44
        Me.RBNOMBRE.TabStop = True
        Me.RBNOMBRE.Text = "NOMBRE"
        Me.RBNOMBRE.UseVisualStyleBackColor = True
        '
        'CMDOK
        '
        Me.CMDOK.BackgroundImage = Global.SAC.My.Resources.Resources.ok
        Me.CMDOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDOK.Location = New System.Drawing.Point(272, 70)
        Me.CMDOK.Name = "CMDOK"
        Me.CMDOK.Size = New System.Drawing.Size(27, 23)
        Me.CMDOK.TabIndex = 45
        Me.CMDOK.UseVisualStyleBackColor = True
        Me.CMDOK.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "matri"
        Me.DataGridViewTextBoxColumn2.HeaderText = "MATRI"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "appat"
        Me.DataGridViewTextBoxColumn4.HeaderText = "AP PAT"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "apmat"
        Me.DataGridViewTextBoxColumn3.HeaderText = "AP MAT"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn5.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "escolaridad"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NIVEL"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "telcasa"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CASA"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "telcel"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CEL"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn8.HeaderText = "CORREO"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "INSCRITO"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "INSCRITO"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'DETALLESALUMNOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 462)
        Me.ControlBox = False
        Me.Controls.Add(Me.CMDOK)
        Me.Controls.Add(Me.RBNOMBRE)
        Me.Controls.Add(Me.RBMATRICULA)
        Me.Controls.Add(Me.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSDataGridView)
        Me.Controls.Add(Me.LBLMATRI)
        Me.Controls.Add(Me.TXTMATRICULA)
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.LBLNOMBRE)
        Me.Controls.Add(Me.TXTNOMBRE)
        Me.Controls.Add(Me.TXTAPMAT)
        Me.Controls.Add(Me.LBLAPMAT)
        Me.Controls.Add(Me.LBLAPPATERNO)
        Me.Controls.Add(Me.TXTAPPAT)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "DETALLESALUMNOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DETALLESALUMNOS"
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTAPPAT As System.Windows.Forms.TextBox
    Friend WithEvents LBLAPPATERNO As System.Windows.Forms.Label
    Friend WithEvents LBLAPMAT As System.Windows.Forms.Label
    Friend WithEvents TXTAPMAT As System.Windows.Forms.TextBox
    Friend WithEvents TXTNOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents LBLNOMBRE As System.Windows.Forms.Label
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents LBLMATRI As System.Windows.Forms.Label
    Friend WithEvents TXTMATRICULA As System.Windows.Forms.TextBox
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents SELECCIONARALUMNOSINSCRITOSNOINSCRITOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARALUMNOSINSCRITOSNOINSCRITOSTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARALUMNOSINSCRITOSNOINSCRITOSTableAdapter
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SELECCIONARALUMNOSINSCRITOSNOINSCRITOSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents RBMATRICULA As System.Windows.Forms.RadioButton
    Friend WithEvents RBNOMBRE As System.Windows.Forms.RadioButton
    Friend WithEvents CMDOK As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
