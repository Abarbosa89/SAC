<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MODIFICARMOVIMIENTOS
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
        Dim FechaLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SACDataSet = New SAC.SACDataSet()
        Me.SELECCIONARMOVIMIENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARMOVIMIENTOSTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARMOVIMIENTOSTableAdapter()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.SELECCIONARMOVIMIENTOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DTFECHA = New System.Windows.Forms.DateTimePicker()
        Me.TXTMONTO = New System.Windows.Forms.TextBox()
        Me.LBLIDMOV = New System.Windows.Forms.Label()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.CMDGUARDAR = New System.Windows.Forms.Button()
        Me.LBLNOMBRE = New System.Windows.Forms.Label()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.TXTAPMAT = New System.Windows.Forms.TextBox()
        Me.LBLAPMAT = New System.Windows.Forms.Label()
        Me.LBLAPPATERNO = New System.Windows.Forms.Label()
        Me.TXTAPPAT = New System.Windows.Forms.TextBox()
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
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        FechaLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARMOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARMOVIMIENTOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(12, 301)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(63, 18)
        FechaLabel.TabIndex = 1
        FechaLabel.Text = "FECHA"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(355, 301)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(65, 18)
        TotalLabel.TabIndex = 3
        TotalLabel.Text = "MONTO"
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SELECCIONARMOVIMIENTOSBindingSource
        '
        Me.SELECCIONARMOVIMIENTOSBindingSource.DataMember = "SELECCIONARMOVIMIENTOS"
        Me.SELECCIONARMOVIMIENTOSBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARMOVIMIENTOSTableAdapter
        '
        Me.SELECCIONARMOVIMIENTOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SELECCIONARMOVIMIENTOSDataGridView
        '
        Me.SELECCIONARMOVIMIENTOSDataGridView.AllowUserToAddRows = False
        Me.SELECCIONARMOVIMIENTOSDataGridView.AllowUserToDeleteRows = False
        Me.SELECCIONARMOVIMIENTOSDataGridView.AutoGenerateColumns = False
        Me.SELECCIONARMOVIMIENTOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SELECCIONARMOVIMIENTOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.SELECCIONARMOVIMIENTOSDataGridView.DataSource = Me.SELECCIONARMOVIMIENTOSBindingSource
        Me.SELECCIONARMOVIMIENTOSDataGridView.Location = New System.Drawing.Point(12, 61)
        Me.SELECCIONARMOVIMIENTOSDataGridView.Name = "SELECCIONARMOVIMIENTOSDataGridView"
        Me.SELECCIONARMOVIMIENTOSDataGridView.ReadOnly = True
        Me.SELECCIONARMOVIMIENTOSDataGridView.Size = New System.Drawing.Size(707, 237)
        Me.SELECCIONARMOVIMIENTOSDataGridView.TabIndex = 1
        '
        'DTFECHA
        '
        Me.DTFECHA.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SELECCIONARMOVIMIENTOSBindingSource, "fecha", True))
        Me.DTFECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFECHA.Location = New System.Drawing.Point(15, 322)
        Me.DTFECHA.Name = "DTFECHA"
        Me.DTFECHA.Size = New System.Drawing.Size(200, 26)
        Me.DTFECHA.TabIndex = 2
        '
        'TXTMONTO
        '
        Me.TXTMONTO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARMOVIMIENTOSBindingSource, "total", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.TXTMONTO.Location = New System.Drawing.Point(358, 322)
        Me.TXTMONTO.Name = "TXTMONTO"
        Me.TXTMONTO.Size = New System.Drawing.Size(187, 26)
        Me.TXTMONTO.TabIndex = 4
        '
        'LBLIDMOV
        '
        Me.LBLIDMOV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARMOVIMIENTOSBindingSource, "idmov", True))
        Me.LBLIDMOV.Location = New System.Drawing.Point(619, 301)
        Me.LBLIDMOV.Name = "LBLIDMOV"
        Me.LBLIDMOV.Size = New System.Drawing.Size(100, 23)
        Me.LBLIDMOV.TabIndex = 6
        Me.LBLIDMOV.Text = "IDMOV"
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Image = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR.Location = New System.Drawing.Point(376, 377)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(102, 61)
        Me.CMDCANCELAR.TabIndex = 13
        Me.CMDCANCELAR.Text = "CERRAR"
        Me.CMDCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'CMDGUARDAR
        '
        Me.CMDGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDGUARDAR.Image = Global.SAC.My.Resources.Resources.GUARDAR_REGISTRO1
        Me.CMDGUARDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDGUARDAR.Location = New System.Drawing.Point(248, 377)
        Me.CMDGUARDAR.Name = "CMDGUARDAR"
        Me.CMDGUARDAR.Size = New System.Drawing.Size(100, 61)
        Me.CMDGUARDAR.TabIndex = 12
        Me.CMDGUARDAR.Text = "GUARDAR"
        Me.CMDGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDGUARDAR.UseVisualStyleBackColor = True
        '
        'LBLNOMBRE
        '
        Me.LBLNOMBRE.AutoSize = True
        Me.LBLNOMBRE.Location = New System.Drawing.Point(463, 7)
        Me.LBLNOMBRE.Name = "LBLNOMBRE"
        Me.LBLNOMBRE.Size = New System.Drawing.Size(77, 18)
        Me.LBLNOMBRE.TabIndex = 19
        Me.LBLNOMBRE.Text = "NOMBRE"
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Location = New System.Drawing.Point(460, 30)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(221, 26)
        Me.TXTNOMBRE.TabIndex = 18
        '
        'TXTAPMAT
        '
        Me.TXTAPMAT.Location = New System.Drawing.Point(237, 30)
        Me.TXTAPMAT.Name = "TXTAPMAT"
        Me.TXTAPMAT.Size = New System.Drawing.Size(190, 26)
        Me.TXTAPMAT.TabIndex = 17
        '
        'LBLAPMAT
        '
        Me.LBLAPMAT.AutoSize = True
        Me.LBLAPMAT.Location = New System.Drawing.Point(240, 7)
        Me.LBLAPMAT.Name = "LBLAPMAT"
        Me.LBLAPMAT.Size = New System.Drawing.Size(111, 18)
        Me.LBLAPMAT.TabIndex = 16
        Me.LBLAPMAT.Text = "AP MATERNO"
        '
        'LBLAPPATERNO
        '
        Me.LBLAPPATERNO.AutoSize = True
        Me.LBLAPPATERNO.Location = New System.Drawing.Point(23, 7)
        Me.LBLAPPATERNO.Name = "LBLAPPATERNO"
        Me.LBLAPPATERNO.Size = New System.Drawing.Size(108, 18)
        Me.LBLAPPATERNO.TabIndex = 15
        Me.LBLAPPATERNO.Text = "AP PATERNO"
        '
        'TXTAPPAT
        '
        Me.TXTAPPAT.Location = New System.Drawing.Point(12, 30)
        Me.TXTAPPAT.Name = "TXTAPPAT"
        Me.TXTAPPAT.Size = New System.Drawing.Size(203, 26)
        Me.TXTAPPAT.TabIndex = 14
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "appat"
        Me.DataGridViewTextBoxColumn2.HeaderText = "AP PAT"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "apmat"
        Me.DataGridViewTextBoxColumn3.HeaderText = "AP MAT"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn5.HeaderText = "FECHA"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "hora"
        Me.DataGridViewTextBoxColumn6.HeaderText = "HORA"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "total"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn7.HeaderText = "TOTAL"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "DESCRP"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "concep"
        Me.DataGridViewTextBoxColumn9.HeaderText = "CONCEPTO"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "numfolio"
        Me.DataGridViewTextBoxColumn10.HeaderText = "# FOL"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "numrecibo"
        Me.DataGridViewTextBoxColumn11.HeaderText = "# REC"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'MODIFICARMOVIMIENTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 449)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBLNOMBRE)
        Me.Controls.Add(Me.TXTNOMBRE)
        Me.Controls.Add(Me.TXTAPMAT)
        Me.Controls.Add(Me.LBLAPMAT)
        Me.Controls.Add(Me.LBLAPPATERNO)
        Me.Controls.Add(Me.TXTAPPAT)
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.CMDGUARDAR)
        Me.Controls.Add(Me.LBLIDMOV)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TXTMONTO)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.DTFECHA)
        Me.Controls.Add(Me.SELECCIONARMOVIMIENTOSDataGridView)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MODIFICARMOVIMIENTOS"
        Me.Text = "MODIFICARMOVIMIENTOS"
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARMOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARMOVIMIENTOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents SELECCIONARMOVIMIENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARMOVIMIENTOSTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARMOVIMIENTOSTableAdapter
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SELECCIONARMOVIMIENTOSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DTFECHA As System.Windows.Forms.DateTimePicker
    Friend WithEvents TXTMONTO As System.Windows.Forms.TextBox
    Friend WithEvents LBLIDMOV As System.Windows.Forms.Label
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents CMDGUARDAR As System.Windows.Forms.Button
    Friend WithEvents LBLNOMBRE As System.Windows.Forms.Label
    Friend WithEvents TXTNOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents TXTAPMAT As System.Windows.Forms.TextBox
    Friend WithEvents LBLAPMAT As System.Windows.Forms.Label
    Friend WithEvents LBLAPPATERNO As System.Windows.Forms.Label
    Friend WithEvents TXTAPPAT As System.Windows.Forms.TextBox
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
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
