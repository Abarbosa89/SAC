<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRODUCTOSVARIOS
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
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SACDataSet = New SAC.SACDataSet()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.LBLIDPRODUC = New System.Windows.Forms.Label()
        Me.SELECCIONARPRODUCTOSVARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TXTMONTO = New System.Windows.Forms.TextBox()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.CMDGUARDAR = New System.Windows.Forms.Button()
        Me.TXTDESCRIPCION = New System.Windows.Forms.TextBox()
        Me.SELECCIONARCICLOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARCICLOSTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARCICLOSTableAdapter()
        Me.SELECCIONARGRADOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARGRADOTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARGRADOTableAdapter()
        Me.CMDOK = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBOCICLO = New System.Windows.Forms.ComboBox()
        Me.CBOGRADO = New System.Windows.Forms.ComboBox()
        Me.SELECCIONARPRODUCTOSVARIOSTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARPRODUCTOSVARIOSTableAdapter()
        Me.SELECCIONARPRODUCTOSVARIOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.LBLID = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        MontoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARPRODUCTOSVARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARCICLOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARGRADOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARPRODUCTOSVARIOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MontoLabel
        '
        MontoLabel.AutoSize = True
        MontoLabel.Location = New System.Drawing.Point(233, 403)
        MontoLabel.Name = "MontoLabel"
        MontoLabel.Size = New System.Drawing.Size(69, 18)
        MontoLabel.TabIndex = 3
        MontoLabel.Text = "MONTO:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(138, 359)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(117, 18)
        DescripcionLabel.TabIndex = 19
        DescripcionLabel.Text = "DESCRIPCION"
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
        Me.LBLIDPRODUC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARPRODUCTOSVARIOSBindingSource, "idproduc", True))
        Me.LBLIDPRODUC.Location = New System.Drawing.Point(9, 317)
        Me.LBLIDPRODUC.Name = "LBLIDPRODUC"
        Me.LBLIDPRODUC.Size = New System.Drawing.Size(200, 23)
        Me.LBLIDPRODUC.TabIndex = 2
        Me.LBLIDPRODUC.Text = "IDPRODUC"
        '
        'SELECCIONARPRODUCTOSVARIOSBindingSource
        '
        Me.SELECCIONARPRODUCTOSVARIOSBindingSource.DataMember = "SELECCIONARPRODUCTOSVARIOS"
        Me.SELECCIONARPRODUCTOSVARIOSBindingSource.DataSource = Me.SACDataSet
        '
        'TXTMONTO
        '
        Me.TXTMONTO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARPRODUCTOSVARIOSBindingSource, "monto", True))
        Me.TXTMONTO.Location = New System.Drawing.Point(325, 400)
        Me.TXTMONTO.Name = "TXTMONTO"
        Me.TXTMONTO.Size = New System.Drawing.Size(200, 26)
        Me.TXTMONTO.TabIndex = 4
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Image = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR.Location = New System.Drawing.Point(396, 443)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(102, 61)
        Me.CMDCANCELAR.TabIndex = 19
        Me.CMDCANCELAR.Text = "CERRAR"
        Me.CMDCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'CMDGUARDAR
        '
        Me.CMDGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDGUARDAR.Image = Global.SAC.My.Resources.Resources.GUARDAR_REGISTRO1
        Me.CMDGUARDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDGUARDAR.Location = New System.Drawing.Point(268, 443)
        Me.CMDGUARDAR.Name = "CMDGUARDAR"
        Me.CMDGUARDAR.Size = New System.Drawing.Size(100, 61)
        Me.CMDGUARDAR.TabIndex = 18
        Me.CMDGUARDAR.Text = "GUARDAR"
        Me.CMDGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDGUARDAR.UseVisualStyleBackColor = True
        '
        'TXTDESCRIPCION
        '
        Me.TXTDESCRIPCION.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARPRODUCTOSVARIOSBindingSource, "descripcion", True))
        Me.TXTDESCRIPCION.Location = New System.Drawing.Point(261, 356)
        Me.TXTDESCRIPCION.Name = "TXTDESCRIPCION"
        Me.TXTDESCRIPCION.Size = New System.Drawing.Size(358, 26)
        Me.TXTDESCRIPCION.TabIndex = 20
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
        Me.CMDOK.Location = New System.Drawing.Point(749, 24)
        Me.CMDOK.Name = "CMDOK"
        Me.CMDOK.Size = New System.Drawing.Size(27, 25)
        Me.CMDOK.TabIndex = 27
        Me.CMDOK.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "GRADO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(438, 26)
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
        Me.CBOCICLO.Location = New System.Drawing.Point(500, 23)
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
        Me.CBOGRADO.Location = New System.Drawing.Point(101, 23)
        Me.CBOGRADO.Name = "CBOGRADO"
        Me.CBOGRADO.Size = New System.Drawing.Size(243, 26)
        Me.CBOGRADO.TabIndex = 23
        Me.CBOGRADO.ValueMember = "idnivel"
        '
        'SELECCIONARPRODUCTOSVARIOSTableAdapter
        '
        Me.SELECCIONARPRODUCTOSVARIOSTableAdapter.ClearBeforeFill = True
        '
        'SELECCIONARPRODUCTOSVARIOSDataGridView
        '
        Me.SELECCIONARPRODUCTOSVARIOSDataGridView.AllowUserToAddRows = False
        Me.SELECCIONARPRODUCTOSVARIOSDataGridView.AllowUserToDeleteRows = False
        Me.SELECCIONARPRODUCTOSVARIOSDataGridView.AutoGenerateColumns = False
        Me.SELECCIONARPRODUCTOSVARIOSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SELECCIONARPRODUCTOSVARIOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SELECCIONARPRODUCTOSVARIOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6})
        Me.SELECCIONARPRODUCTOSVARIOSDataGridView.DataSource = Me.SELECCIONARPRODUCTOSVARIOSBindingSource
        Me.SELECCIONARPRODUCTOSVARIOSDataGridView.Location = New System.Drawing.Point(12, 75)
        Me.SELECCIONARPRODUCTOSVARIOSDataGridView.Name = "SELECCIONARPRODUCTOSVARIOSDataGridView"
        Me.SELECCIONARPRODUCTOSVARIOSDataGridView.ReadOnly = True
        Me.SELECCIONARPRODUCTOSVARIOSDataGridView.Size = New System.Drawing.Size(785, 220)
        Me.SELECCIONARPRODUCTOSVARIOSDataGridView.TabIndex = 28
        '
        'LBLID
        '
        Me.LBLID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARPRODUCTOSVARIOSBindingSource, "id", True))
        Me.LBLID.Location = New System.Drawing.Point(9, 340)
        Me.LBLID.Name = "LBLID"
        Me.LBLID.Size = New System.Drawing.Size(100, 23)
        Me.LBLID.TabIndex = 29
        Me.LBLID.Text = "ID"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DESCRIPCION"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "escolaridad"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ESCOLARIDAD"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "monto"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn6.HeaderText = "MONTO"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'PRODUCTOSVARIOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 524)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBLID)
        Me.Controls.Add(Me.SELECCIONARPRODUCTOSVARIOSDataGridView)
        Me.Controls.Add(Me.CMDOK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBOCICLO)
        Me.Controls.Add(Me.CBOGRADO)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.TXTDESCRIPCION)
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.CMDGUARDAR)
        Me.Controls.Add(Me.LBLIDPRODUC)
        Me.Controls.Add(MontoLabel)
        Me.Controls.Add(Me.TXTMONTO)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PRODUCTOSVARIOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRODUCTOSVARIOS"
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARPRODUCTOSVARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARCICLOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARGRADOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARPRODUCTOSVARIOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LBLIDPRODUC As System.Windows.Forms.Label
    Friend WithEvents TXTMONTO As System.Windows.Forms.TextBox
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents CMDGUARDAR As System.Windows.Forms.Button
    Friend WithEvents TXTDESCRIPCION As System.Windows.Forms.TextBox
    Friend WithEvents SELECCIONARCICLOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARCICLOSTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARCICLOSTableAdapter
    Friend WithEvents SELECCIONARGRADOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARGRADOTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARGRADOTableAdapter
    Friend WithEvents CMDOK As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBOCICLO As System.Windows.Forms.ComboBox
    Friend WithEvents CBOGRADO As System.Windows.Forms.ComboBox
    Friend WithEvents SELECCIONARPRODUCTOSVARIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARPRODUCTOSVARIOSTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARPRODUCTOSVARIOSTableAdapter
    Friend WithEvents SELECCIONARPRODUCTOSVARIOSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents LBLID As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
