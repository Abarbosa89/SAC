<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADEUDOSPORALUMNO
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SACDataSet = New SAC.SACDataSet()
        Me.ADEUDOSPORALUMNOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ADEUDOSPORALUMNOTableAdapter = New SAC.SACDataSetTableAdapters.ADEUDOSPORALUMNOTableAdapter()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.ADEUDOSPORALUMNODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADEUDOSPORALUMNOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADEUDOSPORALUMNODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ADEUDOSPORALUMNOBindingSource
        '
        Me.ADEUDOSPORALUMNOBindingSource.DataMember = "ADEUDOSPORALUMNO"
        Me.ADEUDOSPORALUMNOBindingSource.DataSource = Me.SACDataSet
        '
        'ADEUDOSPORALUMNOTableAdapter
        '
        Me.ADEUDOSPORALUMNOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ADEUDOSPORALUMNODataGridView
        '
        Me.ADEUDOSPORALUMNODataGridView.AllowUserToAddRows = False
        Me.ADEUDOSPORALUMNODataGridView.AllowUserToDeleteRows = False
        Me.ADEUDOSPORALUMNODataGridView.AutoGenerateColumns = False
        Me.ADEUDOSPORALUMNODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ADEUDOSPORALUMNODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ADEUDOSPORALUMNODataGridView.DataSource = Me.ADEUDOSPORALUMNOBindingSource
        Me.ADEUDOSPORALUMNODataGridView.Location = New System.Drawing.Point(12, 21)
        Me.ADEUDOSPORALUMNODataGridView.Name = "ADEUDOSPORALUMNODataGridView"
        Me.ADEUDOSPORALUMNODataGridView.ReadOnly = True
        Me.ADEUDOSPORALUMNODataGridView.Size = New System.Drawing.Size(738, 294)
        Me.ADEUDOSPORALUMNODataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "matri"
        Me.DataGridViewTextBoxColumn1.HeaderText = "MATRI"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ALUMNO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ALUMNO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DESCRIPCION"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "abono"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn4.HeaderText = "ABONO"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "resta"
        DataGridViewCellStyle4.Format = "C2"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn5.HeaderText = "RESTA"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn6.HeaderText = "FECHA"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Image = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR.Location = New System.Drawing.Point(317, 321)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(101, 59)
        Me.CMDCANCELAR.TabIndex = 39
        Me.CMDCANCELAR.Text = "CERRAR"
        Me.CMDCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'ADEUDOSPORALUMNO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 392)
        Me.ControlBox = False
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.ADEUDOSPORALUMNODataGridView)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ADEUDOSPORALUMNO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADEUDOS POR ALUMNO"
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADEUDOSPORALUMNOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADEUDOSPORALUMNODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents ADEUDOSPORALUMNOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ADEUDOSPORALUMNOTableAdapter As SAC.SACDataSetTableAdapters.ADEUDOSPORALUMNOTableAdapter
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ADEUDOSPORALUMNODataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
End Class
