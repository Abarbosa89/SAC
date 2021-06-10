<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRODUCTOSUNIFORMES
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
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim MontoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.SACDataSet = New SAC.SACDataSet()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.LBLIDUNIFORM = New System.Windows.Forms.Label()
        Me.TXTDESCRIPCION = New System.Windows.Forms.TextBox()
        Me.TXTMONTO = New System.Windows.Forms.TextBox()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.CMDGUARDAR = New System.Windows.Forms.Button()
        Me.SELECCIONARCICLOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARCICLOSTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARCICLOSTableAdapter()
        Me.SELECCIONARUNIFORMESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARUNIFORMESTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARUNIFORMESTableAdapter()
        Me.SELECCIONARUNIFORMESDataGridView = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LBLID = New System.Windows.Forms.Label()
        Me.CMDOK = New System.Windows.Forms.Button()
        DescripcionLabel = New System.Windows.Forms.Label()
        MontoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARCICLOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARUNIFORMESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARUNIFORMESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(12, 332)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(120, 20)
        DescripcionLabel.TabIndex = 3
        DescripcionLabel.Text = "DESCRIPCION"
        '
        'MontoLabel
        '
        MontoLabel.AutoSize = True
        MontoLabel.Location = New System.Drawing.Point(549, 332)
        MontoLabel.Name = "MontoLabel"
        MontoLabel.Size = New System.Drawing.Size(66, 20)
        MontoLabel.TabIndex = 5
        MontoLabel.Text = "MONTO"
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
        'LBLIDUNIFORM
        '
        Me.LBLIDUNIFORM.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARUNIFORMESBindingSource, "iduniform", True))
        Me.LBLIDUNIFORM.Location = New System.Drawing.Point(12, 436)
        Me.LBLIDUNIFORM.Name = "LBLIDUNIFORM"
        Me.LBLIDUNIFORM.Size = New System.Drawing.Size(100, 23)
        Me.LBLIDUNIFORM.TabIndex = 2
        Me.LBLIDUNIFORM.Text = "IDUNIFORM"
        '
        'TXTDESCRIPCION
        '
        Me.TXTDESCRIPCION.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARUNIFORMESBindingSource, "descripcion", True))
        Me.TXTDESCRIPCION.Location = New System.Drawing.Point(138, 329)
        Me.TXTDESCRIPCION.Name = "TXTDESCRIPCION"
        Me.TXTDESCRIPCION.Size = New System.Drawing.Size(405, 26)
        Me.TXTDESCRIPCION.TabIndex = 4
        '
        'TXTMONTO
        '
        Me.TXTMONTO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARUNIFORMESBindingSource, "MONTO", True))
        Me.TXTMONTO.Location = New System.Drawing.Point(613, 329)
        Me.TXTMONTO.Name = "TXTMONTO"
        Me.TXTMONTO.Size = New System.Drawing.Size(110, 26)
        Me.TXTMONTO.TabIndex = 6
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Image = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR.Location = New System.Drawing.Point(404, 376)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(102, 61)
        Me.CMDCANCELAR.TabIndex = 21
        Me.CMDCANCELAR.Text = "CERRAR"
        Me.CMDCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'CMDGUARDAR
        '
        Me.CMDGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDGUARDAR.Image = Global.SAC.My.Resources.Resources.GUARDAR_REGISTRO1
        Me.CMDGUARDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDGUARDAR.Location = New System.Drawing.Point(276, 376)
        Me.CMDGUARDAR.Name = "CMDGUARDAR"
        Me.CMDGUARDAR.Size = New System.Drawing.Size(100, 61)
        Me.CMDGUARDAR.TabIndex = 20
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
        'SELECCIONARUNIFORMESBindingSource
        '
        Me.SELECCIONARUNIFORMESBindingSource.DataMember = "SELECCIONARUNIFORMES"
        Me.SELECCIONARUNIFORMESBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARUNIFORMESTableAdapter
        '
        Me.SELECCIONARUNIFORMESTableAdapter.ClearBeforeFill = True
        '
        'SELECCIONARUNIFORMESDataGridView
        '
        Me.SELECCIONARUNIFORMESDataGridView.AllowUserToAddRows = False
        Me.SELECCIONARUNIFORMESDataGridView.AllowUserToDeleteRows = False
        Me.SELECCIONARUNIFORMESDataGridView.AutoGenerateColumns = False
        Me.SELECCIONARUNIFORMESDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SELECCIONARUNIFORMESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SELECCIONARUNIFORMESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7})
        Me.SELECCIONARUNIFORMESDataGridView.DataSource = Me.SELECCIONARUNIFORMESBindingSource
        Me.SELECCIONARUNIFORMESDataGridView.Location = New System.Drawing.Point(16, 68)
        Me.SELECCIONARUNIFORMESDataGridView.Name = "SELECCIONARUNIFORMESDataGridView"
        Me.SELECCIONARUNIFORMESDataGridView.ReadOnly = True
        Me.SELECCIONARUNIFORMESDataGridView.Size = New System.Drawing.Size(735, 220)
        Me.SELECCIONARUNIFORMESDataGridView.TabIndex = 22
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.SELECCIONARCICLOSBindingSource
        Me.ComboBox1.DisplayMember = "CICLO"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(246, 17)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(249, 28)
        Me.ComboBox1.TabIndex = 23
        Me.ComboBox1.ValueMember = "IDCICLO"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DESCRIPCION"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "sexo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SEXO"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "MONTO"
        Me.DataGridViewTextBoxColumn7.HeaderText = "MONTO"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'LBLID
        '
        Me.LBLID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARUNIFORMESBindingSource, "ID", True))
        Me.LBLID.Location = New System.Drawing.Point(12, 413)
        Me.LBLID.Name = "LBLID"
        Me.LBLID.Size = New System.Drawing.Size(100, 23)
        Me.LBLID.TabIndex = 24
        Me.LBLID.Text = "ID"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(183, 20)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(57, 20)
        Label1.TabIndex = 25
        Label1.Text = "CICLO"
        '
        'CMDOK
        '
        Me.CMDOK.BackgroundImage = Global.SAC.My.Resources.Resources.ok
        Me.CMDOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDOK.Location = New System.Drawing.Point(501, 18)
        Me.CMDOK.Name = "CMDOK"
        Me.CMDOK.Size = New System.Drawing.Size(27, 25)
        Me.CMDOK.TabIndex = 26
        Me.CMDOK.UseVisualStyleBackColor = True
        '
        'PRODUCTOSUNIFORMES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 479)
        Me.ControlBox = False
        Me.Controls.Add(Me.CMDOK)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.LBLID)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.SELECCIONARUNIFORMESDataGridView)
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.CMDGUARDAR)
        Me.Controls.Add(Me.LBLIDUNIFORM)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.TXTDESCRIPCION)
        Me.Controls.Add(MontoLabel)
        Me.Controls.Add(Me.TXTMONTO)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "PRODUCTOSUNIFORMES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRODUCTOSUNIFORMES"
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARCICLOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARUNIFORMESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARUNIFORMESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LBLIDUNIFORM As System.Windows.Forms.Label
    Friend WithEvents TXTDESCRIPCION As System.Windows.Forms.TextBox
    Friend WithEvents TXTMONTO As System.Windows.Forms.TextBox
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents CMDGUARDAR As System.Windows.Forms.Button
    Friend WithEvents SELECCIONARCICLOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARCICLOSTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARCICLOSTableAdapter
    Friend WithEvents SELECCIONARUNIFORMESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARUNIFORMESTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARUNIFORMESTableAdapter
    Friend WithEvents SELECCIONARUNIFORMESDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LBLID As System.Windows.Forms.Label
    Friend WithEvents CMDOK As System.Windows.Forms.Button
End Class
