<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DETALLESTUTORES
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
        Me.SELECCIONARTUTORESALUMNODataGridView = New System.Windows.Forms.DataGridView()
        Me.CMDOK = New System.Windows.Forms.Button()
        Me.LBLMATRI = New System.Windows.Forms.Label()
        Me.TXTMATRICULA = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SELECCIONARTUTORESALUMNOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SACDataSet = New SAC.SACDataSet()
        Me.SELECCIONARTUTORESALUMNOTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARTUTORESALUMNOTableAdapter()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.RBNOMBRE = New System.Windows.Forms.RadioButton()
        Me.RBMATRICULA = New System.Windows.Forms.RadioButton()
        Me.CBOALUMNO = New System.Windows.Forms.ComboBox()
        Me.SELECCIONARALUMNOSATIVOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARALUMNOSATIVOSTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARALUMNOSATIVOSTableAdapter()
        Me.SELECCIONARESCOLARIDADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARESCOLARIDADTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARESCOLARIDADTableAdapter()
        Me.CBOESCOLARIDAD = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.SELECCIONARTUTORESALUMNODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARTUTORESALUMNOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARALUMNOSATIVOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARESCOLARIDADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SELECCIONARTUTORESALUMNODataGridView
        '
        Me.SELECCIONARTUTORESALUMNODataGridView.AllowUserToAddRows = False
        Me.SELECCIONARTUTORESALUMNODataGridView.AllowUserToDeleteRows = False
        Me.SELECCIONARTUTORESALUMNODataGridView.AutoGenerateColumns = False
        Me.SELECCIONARTUTORESALUMNODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SELECCIONARTUTORESALUMNODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.SELECCIONARTUTORESALUMNODataGridView.DataSource = Me.SELECCIONARTUTORESALUMNOBindingSource
        Me.SELECCIONARTUTORESALUMNODataGridView.Location = New System.Drawing.Point(12, 108)
        Me.SELECCIONARTUTORESALUMNODataGridView.Name = "SELECCIONARTUTORESALUMNODataGridView"
        Me.SELECCIONARTUTORESALUMNODataGridView.ReadOnly = True
        Me.SELECCIONARTUTORESALUMNODataGridView.Size = New System.Drawing.Size(634, 213)
        Me.SELECCIONARTUTORESALUMNODataGridView.TabIndex = 2
        '
        'CMDOK
        '
        Me.CMDOK.BackgroundImage = Global.SAC.My.Resources.Resources.ok
        Me.CMDOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDOK.Location = New System.Drawing.Point(168, 67)
        Me.CMDOK.Name = "CMDOK"
        Me.CMDOK.Size = New System.Drawing.Size(27, 23)
        Me.CMDOK.TabIndex = 48
        Me.CMDOK.UseVisualStyleBackColor = True
        Me.CMDOK.Visible = False
        '
        'LBLMATRI
        '
        Me.LBLMATRI.AutoSize = True
        Me.LBLMATRI.Location = New System.Drawing.Point(232, 52)
        Me.LBLMATRI.Name = "LBLMATRI"
        Me.LBLMATRI.Size = New System.Drawing.Size(69, 13)
        Me.LBLMATRI.TabIndex = 47
        Me.LBLMATRI.Text = "MATRICULA"
        Me.LBLMATRI.Visible = False
        '
        'TXTMATRICULA
        '
        Me.TXTMATRICULA.Location = New System.Drawing.Point(235, 68)
        Me.TXTMATRICULA.Name = "TXTMATRICULA"
        Me.TXTMATRICULA.Size = New System.Drawing.Size(203, 20)
        Me.TXTMATRICULA.TabIndex = 46
        Me.TXTMATRICULA.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NOMBRE"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "APPAT"
        Me.DataGridViewTextBoxColumn2.HeaderText = "APPAT"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "APMAT"
        Me.DataGridViewTextBoxColumn3.HeaderText = "APMAT"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn4.HeaderText = "email"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "emailab"
        Me.DataGridViewTextBoxColumn5.HeaderText = "emailab"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "teltrab"
        Me.DataGridViewTextBoxColumn6.HeaderText = "teltrab"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "telcel"
        Me.DataGridViewTextBoxColumn7.HeaderText = "telcel"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "telcasa"
        Me.DataGridViewTextBoxColumn8.HeaderText = "telcasa"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "radio"
        Me.DataGridViewTextBoxColumn9.HeaderText = "radio"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "parent"
        Me.DataGridViewTextBoxColumn10.HeaderText = "parent"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'SELECCIONARTUTORESALUMNOBindingSource
        '
        Me.SELECCIONARTUTORESALUMNOBindingSource.DataMember = "SELECCIONARTUTORESALUMNO"
        Me.SELECCIONARTUTORESALUMNOBindingSource.DataSource = Me.SACDataSet
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SELECCIONARTUTORESALUMNOTableAdapter
        '
        Me.SELECCIONARTUTORESALUMNOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RBNOMBRE
        '
        Me.RBNOMBRE.AutoSize = True
        Me.RBNOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBNOMBRE.Location = New System.Drawing.Point(370, 12)
        Me.RBNOMBRE.Name = "RBNOMBRE"
        Me.RBNOMBRE.Size = New System.Drawing.Size(103, 24)
        Me.RBNOMBRE.TabIndex = 50
        Me.RBNOMBRE.TabStop = True
        Me.RBNOMBRE.Text = "NOMBRE"
        Me.RBNOMBRE.UseVisualStyleBackColor = True
        '
        'RBMATRICULA
        '
        Me.RBMATRICULA.AutoSize = True
        Me.RBMATRICULA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBMATRICULA.Location = New System.Drawing.Point(161, 12)
        Me.RBMATRICULA.Name = "RBMATRICULA"
        Me.RBMATRICULA.Size = New System.Drawing.Size(129, 24)
        Me.RBMATRICULA.TabIndex = 49
        Me.RBMATRICULA.TabStop = True
        Me.RBMATRICULA.Text = "MATRICULA"
        Me.RBMATRICULA.UseVisualStyleBackColor = True
        '
        'CBOALUMNO
        '
        Me.CBOALUMNO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBOALUMNO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBOALUMNO.DataSource = Me.SELECCIONARALUMNOSATIVOSBindingSource
        Me.CBOALUMNO.DisplayMember = "ALUMNO"
        Me.CBOALUMNO.FormattingEnabled = True
        Me.CBOALUMNO.Location = New System.Drawing.Point(201, 68)
        Me.CBOALUMNO.Name = "CBOALUMNO"
        Me.CBOALUMNO.Size = New System.Drawing.Size(328, 21)
        Me.CBOALUMNO.TabIndex = 51
        Me.CBOALUMNO.ValueMember = "matri"
        Me.CBOALUMNO.Visible = False
        '
        'SELECCIONARALUMNOSATIVOSBindingSource
        '
        Me.SELECCIONARALUMNOSATIVOSBindingSource.DataMember = "SELECCIONARALUMNOSATIVOS"
        Me.SELECCIONARALUMNOSATIVOSBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARALUMNOSATIVOSTableAdapter
        '
        Me.SELECCIONARALUMNOSATIVOSTableAdapter.ClearBeforeFill = True
        '
        'SELECCIONARESCOLARIDADBindingSource
        '
        Me.SELECCIONARESCOLARIDADBindingSource.DataMember = "SELECCIONARESCOLARIDAD"
        Me.SELECCIONARESCOLARIDADBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARESCOLARIDADTableAdapter
        '
        Me.SELECCIONARESCOLARIDADTableAdapter.ClearBeforeFill = True
        '
        'CBOESCOLARIDAD
        '
        Me.CBOESCOLARIDAD.DataSource = Me.SELECCIONARESCOLARIDADBindingSource
        Me.CBOESCOLARIDAD.DisplayMember = "escolaridad"
        Me.CBOESCOLARIDAD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOESCOLARIDAD.FormattingEnabled = True
        Me.CBOESCOLARIDAD.Location = New System.Drawing.Point(76, 68)
        Me.CBOESCOLARIDAD.Name = "CBOESCOLARIDAD"
        Me.CBOESCOLARIDAD.Size = New System.Drawing.Size(119, 21)
        Me.CBOESCOLARIDAD.TabIndex = 52
        Me.CBOESCOLARIDAD.ValueMember = "idgrado"
        Me.CBOESCOLARIDAD.Visible = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.SAC.My.Resources.Resources.ok
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(535, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 23)
        Me.Button1.TabIndex = 53
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'DETALLESTUTORES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 326)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CBOESCOLARIDAD)
        Me.Controls.Add(Me.CBOALUMNO)
        Me.Controls.Add(Me.RBNOMBRE)
        Me.Controls.Add(Me.RBMATRICULA)
        Me.Controls.Add(Me.CMDOK)
        Me.Controls.Add(Me.LBLMATRI)
        Me.Controls.Add(Me.TXTMATRICULA)
        Me.Controls.Add(Me.SELECCIONARTUTORESALUMNODataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "DETALLESTUTORES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DETALLESTUTORES"
        CType(Me.SELECCIONARTUTORESALUMNODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARTUTORESALUMNOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARALUMNOSATIVOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARESCOLARIDADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents SELECCIONARTUTORESALUMNOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARTUTORESALUMNOTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARTUTORESALUMNOTableAdapter
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SELECCIONARTUTORESALUMNODataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMDOK As System.Windows.Forms.Button
    Friend WithEvents LBLMATRI As System.Windows.Forms.Label
    Friend WithEvents TXTMATRICULA As System.Windows.Forms.TextBox
    Friend WithEvents RBNOMBRE As System.Windows.Forms.RadioButton
    Friend WithEvents RBMATRICULA As System.Windows.Forms.RadioButton
    Friend WithEvents CBOALUMNO As System.Windows.Forms.ComboBox
    Friend WithEvents SELECCIONARALUMNOSATIVOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARALUMNOSATIVOSTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARALUMNOSATIVOSTableAdapter
    Friend WithEvents SELECCIONARESCOLARIDADBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARESCOLARIDADTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARESCOLARIDADTableAdapter
    Friend WithEvents CBOESCOLARIDAD As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
