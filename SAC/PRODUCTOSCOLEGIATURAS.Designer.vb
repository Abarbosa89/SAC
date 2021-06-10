<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRODUCTOSCOLEGIATURAS
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
        Me.LBLIDPRODUC = New System.Windows.Forms.Label()
        Me.SACDataSet = New SAC.SACDataSet()
        Me.TXTMONTO = New System.Windows.Forms.TextBox()
        Me.DTFECHAVENCI = New System.Windows.Forms.DateTimePicker()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.CMDGUARDAR = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.CBOGRADO = New System.Windows.Forms.ComboBox()
        Me.SELECCIONARGRADOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CBOCICLO = New System.Windows.Forms.ComboBox()
        Me.SELECCIONARCICLOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARGRADOTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARGRADOTableAdapter()
        Me.SELECCIONARCICLOSTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARCICLOSTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CMDOK = New System.Windows.Forms.Button()
        Me.IdLabel1 = New System.Windows.Forms.Label()
        Me.SELECCIONARPRODUCTOSCOLEGIATURASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARPRODUCTOSCOLEGIATURASTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARPRODUCTOSCOLEGIATURASTableAdapter()
        Me.SELECCIONARPRODUCTOSCOLEGIATURASDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LBLIDFECHAVENCI = New System.Windows.Forms.Label()
        MontoLabel = New System.Windows.Forms.Label()
        FechavenciLabel = New System.Windows.Forms.Label()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARGRADOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARCICLOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARPRODUCTOSCOLEGIATURASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARPRODUCTOSCOLEGIATURASDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MontoLabel
        '
        MontoLabel.AutoSize = True
        MontoLabel.Location = New System.Drawing.Point(12, 313)
        MontoLabel.Name = "MontoLabel"
        MontoLabel.Size = New System.Drawing.Size(69, 18)
        MontoLabel.TabIndex = 2
        MontoLabel.Text = "MONTO:"
        '
        'FechavenciLabel
        '
        FechavenciLabel.AutoSize = True
        FechavenciLabel.Location = New System.Drawing.Point(382, 318)
        FechavenciLabel.Name = "FechavenciLabel"
        FechavenciLabel.Size = New System.Drawing.Size(173, 18)
        FechavenciLabel.TabIndex = 4
        FechavenciLabel.Text = "FECHA VENCIMIENTO"
        '
        'LBLIDPRODUC
        '
        Me.LBLIDPRODUC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARPRODUCTOSCOLEGIATURASBindingSource, "idproduc", True))
        Me.LBLIDPRODUC.Location = New System.Drawing.Point(12, 439)
        Me.LBLIDPRODUC.Name = "LBLIDPRODUC"
        Me.LBLIDPRODUC.Size = New System.Drawing.Size(100, 23)
        Me.LBLIDPRODUC.TabIndex = 2
        Me.LBLIDPRODUC.Text = "IDPRODUC"
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TXTMONTO
        '
        Me.TXTMONTO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARPRODUCTOSCOLEGIATURASBindingSource, "monto", True))
        Me.TXTMONTO.Enabled = False
        Me.TXTMONTO.Location = New System.Drawing.Point(87, 310)
        Me.TXTMONTO.Name = "TXTMONTO"
        Me.TXTMONTO.Size = New System.Drawing.Size(226, 26)
        Me.TXTMONTO.TabIndex = 3
        '
        'DTFECHAVENCI
        '
        Me.DTFECHAVENCI.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SELECCIONARPRODUCTOSCOLEGIATURASBindingSource, "FECHAVENCIMIENTO", True))
        Me.DTFECHAVENCI.Enabled = False
        Me.DTFECHAVENCI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFECHAVENCI.Location = New System.Drawing.Point(561, 313)
        Me.DTFECHAVENCI.Name = "DTFECHAVENCI"
        Me.DTFECHAVENCI.Size = New System.Drawing.Size(200, 26)
        Me.DTFECHAVENCI.TabIndex = 5
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Image = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR.Location = New System.Drawing.Point(427, 380)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(102, 61)
        Me.CMDCANCELAR.TabIndex = 15
        Me.CMDCANCELAR.Text = "CERRAR"
        Me.CMDCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'CMDGUARDAR
        '
        Me.CMDGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDGUARDAR.Enabled = False
        Me.CMDGUARDAR.Image = Global.SAC.My.Resources.Resources.GUARDAR_REGISTRO1
        Me.CMDGUARDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDGUARDAR.Location = New System.Drawing.Point(299, 380)
        Me.CMDGUARDAR.Name = "CMDGUARDAR"
        Me.CMDGUARDAR.Size = New System.Drawing.Size(100, 61)
        Me.CMDGUARDAR.TabIndex = 14
        Me.CMDGUARDAR.Text = "GUARDAR"
        Me.CMDGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDGUARDAR.UseVisualStyleBackColor = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CBOGRADO
        '
        Me.CBOGRADO.DataSource = Me.SELECCIONARGRADOBindingSource
        Me.CBOGRADO.DisplayMember = "escolaridad"
        Me.CBOGRADO.FormattingEnabled = True
        Me.CBOGRADO.Location = New System.Drawing.Point(87, 22)
        Me.CBOGRADO.Name = "CBOGRADO"
        Me.CBOGRADO.Size = New System.Drawing.Size(243, 26)
        Me.CBOGRADO.TabIndex = 18
        Me.CBOGRADO.ValueMember = "idnivel"
        '
        'SELECCIONARGRADOBindingSource
        '
        Me.SELECCIONARGRADOBindingSource.DataMember = "SELECCIONARGRADO"
        Me.SELECCIONARGRADOBindingSource.DataSource = Me.SACDataSet
        '
        'CBOCICLO
        '
        Me.CBOCICLO.DataSource = Me.SELECCIONARCICLOSBindingSource
        Me.CBOCICLO.DisplayMember = "CICLO"
        Me.CBOCICLO.FormattingEnabled = True
        Me.CBOCICLO.Location = New System.Drawing.Point(486, 22)
        Me.CBOCICLO.Name = "CBOCICLO"
        Me.CBOCICLO.Size = New System.Drawing.Size(243, 26)
        Me.CBOCICLO.TabIndex = 19
        Me.CBOCICLO.ValueMember = "IDCICLO"
        '
        'SELECCIONARCICLOSBindingSource
        '
        Me.SELECCIONARCICLOSBindingSource.DataMember = "SELECCIONARCICLOS"
        Me.SELECCIONARCICLOSBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARGRADOTableAdapter
        '
        Me.SELECCIONARGRADOTableAdapter.ClearBeforeFill = True
        '
        'SELECCIONARCICLOSTableAdapter
        '
        Me.SELECCIONARCICLOSTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(424, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "CICLO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "GRADO"
        '
        'CMDOK
        '
        Me.CMDOK.BackgroundImage = Global.SAC.My.Resources.Resources.ok
        Me.CMDOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDOK.Location = New System.Drawing.Point(735, 23)
        Me.CMDOK.Name = "CMDOK"
        Me.CMDOK.Size = New System.Drawing.Size(27, 25)
        Me.CMDOK.TabIndex = 22
        Me.CMDOK.UseVisualStyleBackColor = True
        '
        'IdLabel1
        '
        Me.IdLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARPRODUCTOSCOLEGIATURASBindingSource, "id", True))
        Me.IdLabel1.Location = New System.Drawing.Point(9, 416)
        Me.IdLabel1.Name = "IdLabel1"
        Me.IdLabel1.Size = New System.Drawing.Size(100, 23)
        Me.IdLabel1.TabIndex = 23
        Me.IdLabel1.Text = "Label3"
        '
        'SELECCIONARPRODUCTOSCOLEGIATURASBindingSource
        '
        Me.SELECCIONARPRODUCTOSCOLEGIATURASBindingSource.DataMember = "SELECCIONARPRODUCTOSCOLEGIATURAS"
        Me.SELECCIONARPRODUCTOSCOLEGIATURASBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARPRODUCTOSCOLEGIATURASTableAdapter
        '
        Me.SELECCIONARPRODUCTOSCOLEGIATURASTableAdapter.ClearBeforeFill = True
        '
        'SELECCIONARPRODUCTOSCOLEGIATURASDataGridView
        '
        Me.SELECCIONARPRODUCTOSCOLEGIATURASDataGridView.AllowUserToAddRows = False
        Me.SELECCIONARPRODUCTOSCOLEGIATURASDataGridView.AllowUserToDeleteRows = False
        Me.SELECCIONARPRODUCTOSCOLEGIATURASDataGridView.AutoGenerateColumns = False
        Me.SELECCIONARPRODUCTOSCOLEGIATURASDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SELECCIONARPRODUCTOSCOLEGIATURASDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SELECCIONARPRODUCTOSCOLEGIATURASDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7})
        Me.SELECCIONARPRODUCTOSCOLEGIATURASDataGridView.DataSource = Me.SELECCIONARPRODUCTOSCOLEGIATURASBindingSource
        Me.SELECCIONARPRODUCTOSCOLEGIATURASDataGridView.Location = New System.Drawing.Point(12, 66)
        Me.SELECCIONARPRODUCTOSCOLEGIATURASDataGridView.Name = "SELECCIONARPRODUCTOSCOLEGIATURASDataGridView"
        Me.SELECCIONARPRODUCTOSCOLEGIATURASDataGridView.ReadOnly = True
        Me.SELECCIONARPRODUCTOSCOLEGIATURASDataGridView.Size = New System.Drawing.Size(797, 220)
        Me.SELECCIONARPRODUCTOSCOLEGIATURASDataGridView.TabIndex = 24
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DESCRI"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "escolaridad"
        Me.DataGridViewTextBoxColumn3.HeaderText = "GRADO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "monto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "MONTO"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FECHAVENCIMIENTO"
        Me.DataGridViewTextBoxColumn7.HeaderText = "FECHAVENCIMIENTO"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'LBLIDFECHAVENCI
        '
        Me.LBLIDFECHAVENCI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARPRODUCTOSCOLEGIATURASBindingSource, "Expr1", True))
        Me.LBLIDFECHAVENCI.Location = New System.Drawing.Point(9, 393)
        Me.LBLIDFECHAVENCI.Name = "LBLIDFECHAVENCI"
        Me.LBLIDFECHAVENCI.Size = New System.Drawing.Size(100, 23)
        Me.LBLIDFECHAVENCI.TabIndex = 25
        Me.LBLIDFECHAVENCI.Text = "IDFECHAVENCI"
        '
        'PRODUCTOSCOLEGIATURAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 482)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBLIDFECHAVENCI)
        Me.Controls.Add(Me.SELECCIONARPRODUCTOSCOLEGIATURASDataGridView)
        Me.Controls.Add(Me.IdLabel1)
        Me.Controls.Add(Me.CMDOK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBOCICLO)
        Me.Controls.Add(Me.CBOGRADO)
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.CMDGUARDAR)
        Me.Controls.Add(FechavenciLabel)
        Me.Controls.Add(Me.DTFECHAVENCI)
        Me.Controls.Add(MontoLabel)
        Me.Controls.Add(Me.TXTMONTO)
        Me.Controls.Add(Me.LBLIDPRODUC)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PRODUCTOSCOLEGIATURAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRODUCTOSCOLEGIATURAS"
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARGRADOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARCICLOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARPRODUCTOSCOLEGIATURASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARPRODUCTOSCOLEGIATURASDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLIDPRODUC As System.Windows.Forms.Label
    Friend WithEvents TXTMONTO As System.Windows.Forms.TextBox
    Friend WithEvents DTFECHAVENCI As System.Windows.Forms.DateTimePicker
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents CMDGUARDAR As System.Windows.Forms.Button
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CBOGRADO As System.Windows.Forms.ComboBox
    Friend WithEvents CBOCICLO As System.Windows.Forms.ComboBox
    Friend WithEvents SELECCIONARGRADOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARGRADOTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARGRADOTableAdapter
    Friend WithEvents SELECCIONARCICLOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARCICLOSTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARCICLOSTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CMDOK As System.Windows.Forms.Button
    Friend WithEvents IdLabel1 As System.Windows.Forms.Label
    Friend WithEvents SELECCIONARPRODUCTOSCOLEGIATURASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARPRODUCTOSCOLEGIATURASTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARPRODUCTOSCOLEGIATURASTableAdapter
    Friend WithEvents SELECCIONARPRODUCTOSCOLEGIATURASDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LBLIDFECHAVENCI As System.Windows.Forms.Label
End Class
