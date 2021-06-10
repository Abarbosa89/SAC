<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAGOSREALZADOSALUMNO
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
        Dim ALUMNOLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PAGOSREALZADOSALUMNO))
        Me.ALUMNOLabel1 = New System.Windows.Forms.Label()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.CMDIMPRIMIR = New System.Windows.Forms.Button()
        Me.SACDataSet = New SAC.SACDataSet()
        Me.SELECCIONARPAGOSREALIZADOSPORALUMNOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARPAGOSREALIZADOSPORALUMNOTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARPAGOSREALIZADOSPORALUMNOTableAdapter()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.SELECCIONARPAGOSREALIZADOSPORALUMNODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ALUMNOLabel = New System.Windows.Forms.Label()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARPAGOSREALIZADOSPORALUMNOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARPAGOSREALIZADOSPORALUMNODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ALUMNOLabel
        '
        ALUMNOLabel.AutoSize = True
        ALUMNOLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ALUMNOLabel.Location = New System.Drawing.Point(26, 20)
        ALUMNOLabel.Name = "ALUMNOLabel"
        ALUMNOLabel.Size = New System.Drawing.Size(85, 19)
        ALUMNOLabel.TabIndex = 2
        ALUMNOLabel.Text = "ALUMNO:"
        '
        'ALUMNOLabel1
        '
        Me.ALUMNOLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARPAGOSREALIZADOSPORALUMNOBindingSource, "ALUMNO", True))
        Me.ALUMNOLabel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALUMNOLabel1.Location = New System.Drawing.Point(74, 56)
        Me.ALUMNOLabel1.Name = "ALUMNOLabel1"
        Me.ALUMNOLabel1.Size = New System.Drawing.Size(589, 23)
        Me.ALUMNOLabel1.TabIndex = 3
        Me.ALUMNOLabel1.Text = "Label1"
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Image = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR.Location = New System.Drawing.Point(247, 343)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(100, 59)
        Me.CMDCANCELAR.TabIndex = 66
        Me.CMDCANCELAR.Text = "CERRAR"
        Me.CMDCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'CMDIMPRIMIR
        '
        Me.CMDIMPRIMIR.Image = CType(resources.GetObject("CMDIMPRIMIR.Image"), System.Drawing.Image)
        Me.CMDIMPRIMIR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDIMPRIMIR.Location = New System.Drawing.Point(353, 343)
        Me.CMDIMPRIMIR.Name = "CMDIMPRIMIR"
        Me.CMDIMPRIMIR.Size = New System.Drawing.Size(104, 59)
        Me.CMDIMPRIMIR.TabIndex = 67
        Me.CMDIMPRIMIR.Text = "IMPRIMIR"
        Me.CMDIMPRIMIR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDIMPRIMIR.UseVisualStyleBackColor = True
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SELECCIONARPAGOSREALIZADOSPORALUMNOBindingSource
        '
        Me.SELECCIONARPAGOSREALIZADOSPORALUMNOBindingSource.DataMember = "SELECCIONARPAGOSREALIZADOSPORALUMNO"
        Me.SELECCIONARPAGOSREALIZADOSPORALUMNOBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARPAGOSREALIZADOSPORALUMNOTableAdapter
        '
        Me.SELECCIONARPAGOSREALIZADOSPORALUMNOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SELECCIONARPAGOSREALIZADOSPORALUMNODataGridView
        '
        Me.SELECCIONARPAGOSREALIZADOSPORALUMNODataGridView.AllowUserToAddRows = False
        Me.SELECCIONARPAGOSREALIZADOSPORALUMNODataGridView.AllowUserToDeleteRows = False
        Me.SELECCIONARPAGOSREALIZADOSPORALUMNODataGridView.AutoGenerateColumns = False
        Me.SELECCIONARPAGOSREALIZADOSPORALUMNODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SELECCIONARPAGOSREALIZADOSPORALUMNODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.SELECCIONARPAGOSREALIZADOSPORALUMNODataGridView.DataSource = Me.SELECCIONARPAGOSREALIZADOSPORALUMNOBindingSource
        Me.SELECCIONARPAGOSREALIZADOSPORALUMNODataGridView.Location = New System.Drawing.Point(12, 91)
        Me.SELECCIONARPAGOSREALIZADOSPORALUMNODataGridView.Name = "SELECCIONARPAGOSREALIZADOSPORALUMNODataGridView"
        Me.SELECCIONARPAGOSREALIZADOSPORALUMNODataGridView.ReadOnly = True
        Me.SELECCIONARPAGOSREALIZADOSPORALUMNODataGridView.Size = New System.Drawing.Size(688, 246)
        Me.SELECCIONARPAGOSREALIZADOSPORALUMNODataGridView.TabIndex = 69
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn6.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn1.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "hora"
        Me.DataGridViewTextBoxColumn2.HeaderText = "hora"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "abono"
        Me.DataGridViewTextBoxColumn3.HeaderText = "abono"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "resta"
        Me.DataGridViewTextBoxColumn4.HeaderText = "resta"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "total"
        Me.DataGridViewTextBoxColumn5.HeaderText = "total"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "nomov"
        Me.DataGridViewTextBoxColumn7.HeaderText = "nomov"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "numfolio"
        Me.DataGridViewTextBoxColumn9.HeaderText = "numfolio"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "numrecibo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "numrecibo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'PAGOSREALZADOSALUMNO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 422)
        Me.ControlBox = False
        Me.Controls.Add(Me.SELECCIONARPAGOSREALIZADOSPORALUMNODataGridView)
        Me.Controls.Add(Me.CMDIMPRIMIR)
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(ALUMNOLabel)
        Me.Controls.Add(Me.ALUMNOLabel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "PAGOSREALZADOSALUMNO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAGOS REALZADOS ALUMNO"
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARPAGOSREALIZADOSPORALUMNOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARPAGOSREALIZADOSPORALUMNODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ALUMNOLabel1 As System.Windows.Forms.Label
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents CMDIMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents SELECCIONARPAGOSREALIZADOSPORALUMNOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARPAGOSREALIZADOSPORALUMNOTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARPAGOSREALIZADOSPORALUMNOTableAdapter
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SELECCIONARPAGOSREALIZADOSPORALUMNODataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
