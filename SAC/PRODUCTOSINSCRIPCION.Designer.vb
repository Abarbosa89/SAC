<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRODUCTOSINSCRIPCION
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
        Dim MontoLabel As System.Windows.Forms.Label
        Dim FechavenciLabel As System.Windows.Forms.Label
        Me.SACDataSet = New SAC.SACDataSet()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.LBLIDPRODUC = New System.Windows.Forms.Label()
        Me.SELECCIONARPRODUCTOSINSCRIPCIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TXTMONTO = New System.Windows.Forms.TextBox()
        Me.DTFECHAVENCI = New System.Windows.Forms.DateTimePicker()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.CMDGUARDAR = New System.Windows.Forms.Button()
        Me.SELECCIONARCICLOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARCICLOSTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARCICLOSTableAdapter()
        Me.SELECCIONARGRADOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARGRADOTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARGRADOTableAdapter()
        Me.CMDOK = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBOCICLO = New System.Windows.Forms.ComboBox()
        Me.CBOGRADO = New System.Windows.Forms.ComboBox()
        Me.SELECCIONARPRODUCTOSINSCRIPCIONTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARPRODUCTOSINSCRIPCIONTableAdapter()
        Me.SELECCIONARPRODUCTOSINSCRIPCIONDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdLabel1 = New System.Windows.Forms.Label()
        MontoLabel = New System.Windows.Forms.Label()
        FechavenciLabel = New System.Windows.Forms.Label()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARPRODUCTOSINSCRIPCIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARCICLOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARGRADOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARPRODUCTOSINSCRIPCIONDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MontoLabel
        '
        MontoLabel.AutoSize = True
        MontoLabel.Location = New System.Drawing.Point(40, 415)
        MontoLabel.Name = "MontoLabel"
        MontoLabel.Size = New System.Drawing.Size(69, 18)
        MontoLabel.TabIndex = 3
        MontoLabel.Text = "MONTO:"
        '
        'FechavenciLabel
        '
        FechavenciLabel.AutoSize = True
        FechavenciLabel.Location = New System.Drawing.Point(356, 415)
        FechavenciLabel.Name = "FechavenciLabel"
        FechavenciLabel.Size = New System.Drawing.Size(173, 18)
        FechavenciLabel.TabIndex = 5
        FechavenciLabel.Text = "FECHA VENCIMIENTO"
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LBLIDPRODUC
        '
        Me.LBLIDPRODUC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARPRODUCTOSINSCRIPCIONBindingSource, "idproduc", True))
        Me.LBLIDPRODUC.Location = New System.Drawing.Point(12, 366)
        Me.LBLIDPRODUC.Name = "LBLIDPRODUC"
        Me.LBLIDPRODUC.Size = New System.Drawing.Size(200, 23)
        Me.LBLIDPRODUC.TabIndex = 2
        Me.LBLIDPRODUC.Text = "IDPRODUC"
        '
        'SELECCIONARPRODUCTOSINSCRIPCIONBindingSource
        '
        Me.SELECCIONARPRODUCTOSINSCRIPCIONBindingSource.DataMember = "SELECCIONARPRODUCTOSINSCRIPCION"
        Me.SELECCIONARPRODUCTOSINSCRIPCIONBindingSource.DataSource = Me.SACDataSet
        '
        'TXTMONTO
        '
        Me.TXTMONTO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARPRODUCTOSINSCRIPCIONBindingSource, "monto", True))
        Me.TXTMONTO.Location = New System.Drawing.Point(132, 412)
        Me.TXTMONTO.Name = "TXTMONTO"
        Me.TXTMONTO.Size = New System.Drawing.Size(200, 26)
        Me.TXTMONTO.TabIndex = 4
        '
        'DTFECHAVENCI
        '
        Me.DTFECHAVENCI.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SELECCIONARPRODUCTOSINSCRIPCIONBindingSource, "fechavenci", True))
        Me.DTFECHAVENCI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFECHAVENCI.Location = New System.Drawing.Point(535, 412)
        Me.DTFECHAVENCI.Name = "DTFECHAVENCI"
        Me.DTFECHAVENCI.Size = New System.Drawing.Size(200, 26)
        Me.DTFECHAVENCI.TabIndex = 6
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Image = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR.Location = New System.Drawing.Point(405, 449)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(102, 61)
        Me.CMDCANCELAR.TabIndex = 17
        Me.CMDCANCELAR.Text = "CERRAR"
        Me.CMDCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'CMDGUARDAR
        '
        Me.CMDGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDGUARDAR.Image = Global.SAC.My.Resources.Resources.GUARDAR_REGISTRO1
        Me.CMDGUARDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDGUARDAR.Location = New System.Drawing.Point(277, 449)
        Me.CMDGUARDAR.Name = "CMDGUARDAR"
        Me.CMDGUARDAR.Size = New System.Drawing.Size(100, 61)
        Me.CMDGUARDAR.TabIndex = 16
        Me.CMDGUARDAR.Text = "GUARDAR"
        Me.CMDGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDGUARDAR.UseVisualStyleBackColor = True
        '
        'SELECCIONARCICLOSBindingSource
        '
        Me.SELECCIONARCICLOSBindingSource.DataMember = "SELECCIONARCICLOS"
        Me.SELECCIONARCICLOSBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARCICLOSTableAdapter
        '
        Me.SELECCIONARCICLOSTableAdapter.ClearBeforeFill = True
        '
        'SELECCIONARGRADOBindingSource
        '
        Me.SELECCIONARGRADOBindingSource.DataMember = "SELECCIONARGRADO"
        Me.SELECCIONARGRADOBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARGRADOTableAdapter
        '
        Me.SELECCIONARGRADOTableAdapter.ClearBeforeFill = True
        '
        'CMDOK
        '
        Me.CMDOK.BackgroundImage = Global.SAC.My.Resources.Resources.ok
        Me.CMDOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDOK.Location = New System.Drawing.Point(737, 26)
        Me.CMDOK.Name = "CMDOK"
        Me.CMDOK.Size = New System.Drawing.Size(27, 25)
        Me.CMDOK.TabIndex = 27
        Me.CMDOK.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "GRADO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(426, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 18)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "CICLO"
        '
        'CBOCICLO
        '
        Me.CBOCICLO.DataSource = Me.SELECCIONARCICLOSBindingSource
        Me.CBOCICLO.DisplayMember = "CICLO"
        Me.CBOCICLO.FormattingEnabled = True
        Me.CBOCICLO.Location = New System.Drawing.Point(488, 25)
        Me.CBOCICLO.Name = "CBOCICLO"
        Me.CBOCICLO.Size = New System.Drawing.Size(243, 26)
        Me.CBOCICLO.TabIndex = 24
        Me.CBOCICLO.ValueMember = "IDCICLO"
        '
        'CBOGRADO
        '
        Me.CBOGRADO.DataSource = Me.SELECCIONARGRADOBindingSource
        Me.CBOGRADO.DisplayMember = "escolaridad"
        Me.CBOGRADO.FormattingEnabled = True
        Me.CBOGRADO.Location = New System.Drawing.Point(89, 25)
        Me.CBOGRADO.Name = "CBOGRADO"
        Me.CBOGRADO.Size = New System.Drawing.Size(243, 26)
        Me.CBOGRADO.TabIndex = 23
        Me.CBOGRADO.ValueMember = "idnivel"
        '
        'SELECCIONARPRODUCTOSINSCRIPCIONTableAdapter
        '
        Me.SELECCIONARPRODUCTOSINSCRIPCIONTableAdapter.ClearBeforeFill = True
        '
        'SELECCIONARPRODUCTOSINSCRIPCIONDataGridView
        '
        Me.SELECCIONARPRODUCTOSINSCRIPCIONDataGridView.AllowUserToAddRows = False
        Me.SELECCIONARPRODUCTOSINSCRIPCIONDataGridView.AllowUserToDeleteRows = False
        Me.SELECCIONARPRODUCTOSINSCRIPCIONDataGridView.AutoGenerateColumns = False
        Me.SELECCIONARPRODUCTOSINSCRIPCIONDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SELECCIONARPRODUCTOSINSCRIPCIONDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SELECCIONARPRODUCTOSINSCRIPCIONDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6})
        Me.SELECCIONARPRODUCTOSINSCRIPCIONDataGridView.DataSource = Me.SELECCIONARPRODUCTOSINSCRIPCIONBindingSource
        Me.SELECCIONARPRODUCTOSINSCRIPCIONDataGridView.Location = New System.Drawing.Point(12, 78)
        Me.SELECCIONARPRODUCTOSINSCRIPCIONDataGridView.Name = "SELECCIONARPRODUCTOSINSCRIPCIONDataGridView"
        Me.SELECCIONARPRODUCTOSINSCRIPCIONDataGridView.ReadOnly = True
        Me.SELECCIONARPRODUCTOSINSCRIPCIONDataGridView.Size = New System.Drawing.Size(813, 274)
        Me.SELECCIONARPRODUCTOSINSCRIPCIONDataGridView.TabIndex = 28
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "escolaridad"
        Me.DataGridViewTextBoxColumn3.HeaderText = "escolaridad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fechavenci"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fechavenci"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "monto"
        Me.DataGridViewTextBoxColumn6.HeaderText = "monto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'IdLabel1
        '
        Me.IdLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARPRODUCTOSINSCRIPCIONBindingSource, "id", True))
        Me.IdLabel1.Location = New System.Drawing.Point(17, 389)
        Me.IdLabel1.Name = "IdLabel1"
        Me.IdLabel1.Size = New System.Drawing.Size(100, 23)
        Me.IdLabel1.TabIndex = 29
        Me.IdLabel1.Text = "Label3"
        '
        'PRODUCTOSINSCRIPCION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 533)
        Me.ControlBox = False
        Me.Controls.Add(Me.IdLabel1)
        Me.Controls.Add(Me.SELECCIONARPRODUCTOSINSCRIPCIONDataGridView)
        Me.Controls.Add(Me.CMDOK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBOCICLO)
        Me.Controls.Add(Me.CBOGRADO)
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.CMDGUARDAR)
        Me.Controls.Add(Me.LBLIDPRODUC)
        Me.Controls.Add(MontoLabel)
        Me.Controls.Add(Me.TXTMONTO)
        Me.Controls.Add(FechavenciLabel)
        Me.Controls.Add(Me.DTFECHAVENCI)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PRODUCTOSINSCRIPCION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRODUCTOSINSCRIPCION"
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARPRODUCTOSINSCRIPCIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARCICLOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARGRADOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARPRODUCTOSINSCRIPCIONDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LBLIDPRODUC As System.Windows.Forms.Label
    Friend WithEvents TXTMONTO As System.Windows.Forms.TextBox
    Friend WithEvents DTFECHAVENCI As System.Windows.Forms.DateTimePicker
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents CMDGUARDAR As System.Windows.Forms.Button
    Friend WithEvents SELECCIONARCICLOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARCICLOSTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARCICLOSTableAdapter
    Friend WithEvents SELECCIONARGRADOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARGRADOTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARGRADOTableAdapter
    Friend WithEvents CMDOK As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBOCICLO As System.Windows.Forms.ComboBox
    Friend WithEvents CBOGRADO As System.Windows.Forms.ComboBox
    Friend WithEvents SELECCIONARPRODUCTOSINSCRIPCIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARPRODUCTOSINSCRIPCIONTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARPRODUCTOSINSCRIPCIONTableAdapter
    Friend WithEvents SELECCIONARPRODUCTOSINSCRIPCIONDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdLabel1 As System.Windows.Forms.Label
End Class
