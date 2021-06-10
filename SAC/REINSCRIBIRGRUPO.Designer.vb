<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REINSCRIBIRGRUPO
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SELECCIONARALUMNOSATIVOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.SELECCIONARALUMNOSATIVOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SACDataSet = New SAC.SACDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CICLO = New System.Windows.Forms.Label()
        Me.CBOGRADO = New System.Windows.Forms.ComboBox()
        Me.SELECCIONARESCOLARIDADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CBOCICLOESCOLAR = New System.Windows.Forms.ComboBox()
        Me.SELECCIONARCICLOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GPO2 = New System.Windows.Forms.GroupBox()
        Me.SELECCIONARALUMNOSREINSCRITOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.SELECCIONARALUMNOSREINSCRITOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARCICLOSTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARCICLOSTableAdapter()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.SELECCIONARESCOLARIDADTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARESCOLARIDADTableAdapter()
        Me.SELECCIONARALUMNOSATIVOSTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARALUMNOSATIVOSTableAdapter()
        Me.CMDGRUPO = New System.Windows.Forms.Button()
        Me.CMDINDIVIDUAL = New System.Windows.Forms.Button()
        Me.SELECCIONARALUMNOSREINSCRITOSTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARALUMNOSREINSCRITOSTableAdapter()
        Me.MatriLabel1 = New System.Windows.Forms.Label()
        Me.SELECCIONARALUMNOSACTIVOS2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARALUMNOSACTIVOS2TableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARALUMNOSACTIVOS2TableAdapter()
        Me.SELECCIONARALUMNOSACTIVOS2DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SELECCIONARALUMNOSATIVOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARALUMNOSATIVOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARESCOLARIDADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARCICLOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPO2.SuspendLayout()
        CType(Me.SELECCIONARALUMNOSREINSCRITOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARALUMNOSREINSCRITOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARALUMNOSACTIVOS2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARALUMNOSACTIVOS2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.SELECCIONARALUMNOSATIVOSDataGridView)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CICLO)
        Me.GroupBox1.Controls.Add(Me.CBOGRADO)
        Me.GroupBox1.Controls.Add(Me.CBOCICLOESCOLAR)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(481, 572)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CICLO ESCOLAR"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.SAC.My.Resources.Resources.ok
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(413, 28)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 30)
        Me.Button3.TabIndex = 4
        Me.Button3.UseVisualStyleBackColor = True
        '
        'SELECCIONARALUMNOSATIVOSDataGridView
        '
        Me.SELECCIONARALUMNOSATIVOSDataGridView.AllowUserToAddRows = False
        Me.SELECCIONARALUMNOSATIVOSDataGridView.AllowUserToDeleteRows = False
        Me.SELECCIONARALUMNOSATIVOSDataGridView.AutoGenerateColumns = False
        Me.SELECCIONARALUMNOSATIVOSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SELECCIONARALUMNOSATIVOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SELECCIONARALUMNOSATIVOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3})
        Me.SELECCIONARALUMNOSATIVOSDataGridView.DataSource = Me.SELECCIONARALUMNOSATIVOSBindingSource
        Me.SELECCIONARALUMNOSATIVOSDataGridView.Location = New System.Drawing.Point(6, 79)
        Me.SELECCIONARALUMNOSATIVOSDataGridView.Name = "SELECCIONARALUMNOSATIVOSDataGridView"
        Me.SELECCIONARALUMNOSATIVOSDataGridView.ReadOnly = True
        Me.SELECCIONARALUMNOSATIVOSDataGridView.Size = New System.Drawing.Size(469, 487)
        Me.SELECCIONARALUMNOSATIVOSDataGridView.TabIndex = 4
        '
        'SELECCIONARALUMNOSATIVOSBindingSource
        '
        Me.SELECCIONARALUMNOSATIVOSBindingSource.DataMember = "SELECCIONARALUMNOSATIVOS"
        Me.SELECCIONARALUMNOSATIVOSBindingSource.DataSource = Me.SACDataSet
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(211, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "GRADO"
        '
        'CICLO
        '
        Me.CICLO.AutoSize = True
        Me.CICLO.Location = New System.Drawing.Point(21, 33)
        Me.CICLO.Name = "CICLO"
        Me.CICLO.Size = New System.Drawing.Size(57, 20)
        Me.CICLO.TabIndex = 2
        Me.CICLO.Text = "CICLO"
        '
        'CBOGRADO
        '
        Me.CBOGRADO.DataSource = Me.SELECCIONARESCOLARIDADBindingSource
        Me.CBOGRADO.DisplayMember = "escolaridad"
        Me.CBOGRADO.FormattingEnabled = True
        Me.CBOGRADO.Location = New System.Drawing.Point(286, 30)
        Me.CBOGRADO.Name = "CBOGRADO"
        Me.CBOGRADO.Size = New System.Drawing.Size(121, 28)
        Me.CBOGRADO.TabIndex = 1
        Me.CBOGRADO.ValueMember = "idgrado"
        '
        'SELECCIONARESCOLARIDADBindingSource
        '
        Me.SELECCIONARESCOLARIDADBindingSource.DataMember = "SELECCIONARESCOLARIDAD"
        Me.SELECCIONARESCOLARIDADBindingSource.DataSource = Me.SACDataSet
        '
        'CBOCICLOESCOLAR
        '
        Me.CBOCICLOESCOLAR.DataSource = Me.SELECCIONARCICLOSBindingSource
        Me.CBOCICLOESCOLAR.DisplayMember = "CICLO"
        Me.CBOCICLOESCOLAR.FormattingEnabled = True
        Me.CBOCICLOESCOLAR.Location = New System.Drawing.Point(84, 30)
        Me.CBOCICLOESCOLAR.Name = "CBOCICLOESCOLAR"
        Me.CBOCICLOESCOLAR.Size = New System.Drawing.Size(121, 28)
        Me.CBOCICLOESCOLAR.TabIndex = 0
        Me.CBOCICLOESCOLAR.ValueMember = "IDCICLO"
        '
        'SELECCIONARCICLOSBindingSource
        '
        Me.SELECCIONARCICLOSBindingSource.DataMember = "SELECCIONARCICLOS"
        Me.SELECCIONARCICLOSBindingSource.DataSource = Me.SACDataSet
        '
        'GPO2
        '
        Me.GPO2.Controls.Add(Me.SELECCIONARALUMNOSACTIVOS2DataGridView)
        Me.GPO2.Controls.Add(Me.SELECCIONARALUMNOSREINSCRITOSDataGridView)
        Me.GPO2.Location = New System.Drawing.Point(639, 12)
        Me.GPO2.Name = "GPO2"
        Me.GPO2.Size = New System.Drawing.Size(481, 572)
        Me.GPO2.TabIndex = 1
        Me.GPO2.TabStop = False
        '
        'SELECCIONARALUMNOSREINSCRITOSDataGridView
        '
        Me.SELECCIONARALUMNOSREINSCRITOSDataGridView.AllowUserToAddRows = False
        Me.SELECCIONARALUMNOSREINSCRITOSDataGridView.AllowUserToDeleteRows = False
        Me.SELECCIONARALUMNOSREINSCRITOSDataGridView.AutoGenerateColumns = False
        Me.SELECCIONARALUMNOSREINSCRITOSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SELECCIONARALUMNOSREINSCRITOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SELECCIONARALUMNOSREINSCRITOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6})
        Me.SELECCIONARALUMNOSREINSCRITOSDataGridView.DataSource = Me.SELECCIONARALUMNOSREINSCRITOSBindingSource
        Me.SELECCIONARALUMNOSREINSCRITOSDataGridView.Location = New System.Drawing.Point(6, 79)
        Me.SELECCIONARALUMNOSREINSCRITOSDataGridView.Name = "SELECCIONARALUMNOSREINSCRITOSDataGridView"
        Me.SELECCIONARALUMNOSREINSCRITOSDataGridView.ReadOnly = True
        Me.SELECCIONARALUMNOSREINSCRITOSDataGridView.Size = New System.Drawing.Size(469, 487)
        Me.SELECCIONARALUMNOSREINSCRITOSDataGridView.TabIndex = 0
        '
        'SELECCIONARALUMNOSREINSCRITOSBindingSource
        '
        Me.SELECCIONARALUMNOSREINSCRITOSBindingSource.DataMember = "SELECCIONARALUMNOSREINSCRITOS"
        Me.SELECCIONARALUMNOSREINSCRITOSBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARCICLOSTableAdapter
        '
        Me.SELECCIONARCICLOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SELECCIONARESCOLARIDADTableAdapter
        '
        Me.SELECCIONARESCOLARIDADTableAdapter.ClearBeforeFill = True
        '
        'SELECCIONARALUMNOSATIVOSTableAdapter
        '
        Me.SELECCIONARALUMNOSATIVOSTableAdapter.ClearBeforeFill = True
        '
        'CMDGRUPO
        '
        Me.CMDGRUPO.Enabled = False
        Me.CMDGRUPO.Location = New System.Drawing.Point(508, 360)
        Me.CMDGRUPO.Name = "CMDGRUPO"
        Me.CMDGRUPO.Size = New System.Drawing.Size(116, 32)
        Me.CMDGRUPO.TabIndex = 2
        Me.CMDGRUPO.Text = "GRUPO"
        Me.CMDGRUPO.UseVisualStyleBackColor = True
        '
        'CMDINDIVIDUAL
        '
        Me.CMDINDIVIDUAL.Enabled = False
        Me.CMDINDIVIDUAL.Location = New System.Drawing.Point(508, 299)
        Me.CMDINDIVIDUAL.Name = "CMDINDIVIDUAL"
        Me.CMDINDIVIDUAL.Size = New System.Drawing.Size(116, 32)
        Me.CMDINDIVIDUAL.TabIndex = 3
        Me.CMDINDIVIDUAL.Text = "INDIVIDUAL"
        Me.CMDINDIVIDUAL.UseVisualStyleBackColor = True
        '
        'SELECCIONARALUMNOSREINSCRITOSTableAdapter
        '
        Me.SELECCIONARALUMNOSREINSCRITOSTableAdapter.ClearBeforeFill = True
        '
        'MatriLabel1
        '
        Me.MatriLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOSATIVOSBindingSource, "matri", True))
        Me.MatriLabel1.Location = New System.Drawing.Point(14, 587)
        Me.MatriLabel1.Name = "MatriLabel1"
        Me.MatriLabel1.Size = New System.Drawing.Size(100, 23)
        Me.MatriLabel1.TabIndex = 5
        Me.MatriLabel1.Text = "Label2"
        '
        'SELECCIONARALUMNOSACTIVOS2BindingSource
        '
        Me.SELECCIONARALUMNOSACTIVOS2BindingSource.DataMember = "SELECCIONARALUMNOSACTIVOS2"
        Me.SELECCIONARALUMNOSACTIVOS2BindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARALUMNOSACTIVOS2TableAdapter
        '
        Me.SELECCIONARALUMNOSACTIVOS2TableAdapter.ClearBeforeFill = True
        '
        'SELECCIONARALUMNOSACTIVOS2DataGridView
        '
        Me.SELECCIONARALUMNOSACTIVOS2DataGridView.AllowUserToAddRows = False
        Me.SELECCIONARALUMNOSACTIVOS2DataGridView.AllowUserToDeleteRows = False
        Me.SELECCIONARALUMNOSACTIVOS2DataGridView.AutoGenerateColumns = False
        Me.SELECCIONARALUMNOSACTIVOS2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SELECCIONARALUMNOSACTIVOS2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9})
        Me.SELECCIONARALUMNOSACTIVOS2DataGridView.DataSource = Me.SELECCIONARALUMNOSACTIVOS2BindingSource
        Me.SELECCIONARALUMNOSACTIVOS2DataGridView.Location = New System.Drawing.Point(6, 79)
        Me.SELECCIONARALUMNOSACTIVOS2DataGridView.Name = "SELECCIONARALUMNOSACTIVOS2DataGridView"
        Me.SELECCIONARALUMNOSACTIVOS2DataGridView.ReadOnly = True
        Me.SELECCIONARALUMNOSACTIVOS2DataGridView.Size = New System.Drawing.Size(469, 487)
        Me.SELECCIONARALUMNOSACTIVOS2DataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "matri"
        Me.DataGridViewTextBoxColumn8.HeaderText = "MATRI"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ALUMNO"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ALUMNO"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "grado"
        Me.DataGridViewTextBoxColumn9.HeaderText = "GRADO"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "matri"
        Me.DataGridViewTextBoxColumn5.HeaderText = "MATRI"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ALUMNO"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ALUMNO"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "grado"
        Me.DataGridViewTextBoxColumn6.HeaderText = "GRADO"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "matri"
        Me.DataGridViewTextBoxColumn2.HeaderText = "MATRI"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ALUMNO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ALUMNO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "grado"
        Me.DataGridViewTextBoxColumn3.HeaderText = "GRADO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'REINSCRIBIRGRUPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 630)
        Me.Controls.Add(Me.MatriLabel1)
        Me.Controls.Add(Me.CMDINDIVIDUAL)
        Me.Controls.Add(Me.CMDGRUPO)
        Me.Controls.Add(Me.GPO2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "REINSCRIBIRGRUPO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REINSCRIBIRGRUPO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SELECCIONARALUMNOSATIVOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARALUMNOSATIVOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARESCOLARIDADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARCICLOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GPO2.ResumeLayout(False)
        CType(Me.SELECCIONARALUMNOSREINSCRITOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARALUMNOSREINSCRITOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARALUMNOSACTIVOS2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARALUMNOSACTIVOS2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GPO2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CICLO As System.Windows.Forms.Label
    Friend WithEvents CBOGRADO As System.Windows.Forms.ComboBox
    Friend WithEvents CBOCICLOESCOLAR As System.Windows.Forms.ComboBox
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents SELECCIONARCICLOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARCICLOSTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARCICLOSTableAdapter
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SELECCIONARESCOLARIDADBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARESCOLARIDADTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARESCOLARIDADTableAdapter
    Friend WithEvents SELECCIONARALUMNOSATIVOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARALUMNOSATIVOSTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARALUMNOSATIVOSTableAdapter
    Friend WithEvents SELECCIONARALUMNOSATIVOSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CMDGRUPO As System.Windows.Forms.Button
    Friend WithEvents CMDINDIVIDUAL As System.Windows.Forms.Button
    Friend WithEvents SELECCIONARALUMNOSREINSCRITOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARALUMNOSREINSCRITOSTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARALUMNOSREINSCRITOSTableAdapter
    Friend WithEvents SELECCIONARALUMNOSREINSCRITOSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents MatriLabel1 As System.Windows.Forms.Label
    Friend WithEvents SELECCIONARALUMNOSACTIVOS2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARALUMNOSACTIVOS2TableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARALUMNOSACTIVOS2TableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SELECCIONARALUMNOSACTIVOS2DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
