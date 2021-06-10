<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DATOSFACTURA
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTDIGITOSCUENTA = New System.Windows.Forms.TextBox()
        Me.TXTFACTURA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTFECHAFAC = New System.Windows.Forms.DateTimePicker()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.CMDIMPRIMIR = New System.Windows.Forms.Button()
        Me.LBLIDMOV = New System.Windows.Forms.Label()
        Me.SACDataSet = New SAC.SACDataSet()
        Me.ALUMNOSPIDENFACTURABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALUMNOSPIDENFACTURATableAdapter = New SAC.SACDataSetTableAdapters.ALUMNOSPIDENFACTURATableAdapter()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.ALUMNOSPIDENFACTURADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALUMNOSPIDENFACTURABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALUMNOSPIDENFACTURADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 265)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DIGITOS CUENTA"
        '
        'TXTDIGITOSCUENTA
        '
        Me.TXTDIGITOSCUENTA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUMNOSPIDENFACTURABindingSource, "digitoscuenta", True))
        Me.TXTDIGITOSCUENTA.Location = New System.Drawing.Point(15, 286)
        Me.TXTDIGITOSCUENTA.Name = "TXTDIGITOSCUENTA"
        Me.TXTDIGITOSCUENTA.Size = New System.Drawing.Size(182, 26)
        Me.TXTDIGITOSCUENTA.TabIndex = 3
        '
        'TXTFACTURA
        '
        Me.TXTFACTURA.Location = New System.Drawing.Point(287, 286)
        Me.TXTFACTURA.Name = "TXTFACTURA"
        Me.TXTFACTURA.Size = New System.Drawing.Size(179, 26)
        Me.TXTFACTURA.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "# FACTURA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(538, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "FECHA FACTURA"
        '
        'DTFECHAFAC
        '
        Me.DTFECHAFAC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFECHAFAC.Location = New System.Drawing.Point(541, 286)
        Me.DTFECHAFAC.Name = "DTFECHAFAC"
        Me.DTFECHAFAC.Size = New System.Drawing.Size(200, 26)
        Me.DTFECHAFAC.TabIndex = 7
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Image = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR.Location = New System.Drawing.Point(427, 356)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(100, 57)
        Me.CMDCANCELAR.TabIndex = 50
        Me.CMDCANCELAR.Text = "CERRAR"
        Me.CMDCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'CMDIMPRIMIR
        '
        Me.CMDIMPRIMIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDIMPRIMIR.Image = Global.SAC.My.Resources.Resources.GUARDAR_REGISTRO1
        Me.CMDIMPRIMIR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDIMPRIMIR.Location = New System.Drawing.Point(308, 356)
        Me.CMDIMPRIMIR.Name = "CMDIMPRIMIR"
        Me.CMDIMPRIMIR.Size = New System.Drawing.Size(100, 57)
        Me.CMDIMPRIMIR.TabIndex = 49
        Me.CMDIMPRIMIR.Text = "GUARDAR"
        Me.CMDIMPRIMIR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDIMPRIMIR.UseVisualStyleBackColor = True
        '
        'LBLIDMOV
        '
        Me.LBLIDMOV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUMNOSPIDENFACTURABindingSource, "idmov", True))
        Me.LBLIDMOV.Location = New System.Drawing.Point(202, 356)
        Me.LBLIDMOV.Name = "LBLIDMOV"
        Me.LBLIDMOV.Size = New System.Drawing.Size(100, 23)
        Me.LBLIDMOV.TabIndex = 51
        Me.LBLIDMOV.Text = "IDMOV"
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ALUMNOSPIDENFACTURABindingSource
        '
        Me.ALUMNOSPIDENFACTURABindingSource.DataMember = "ALUMNOSPIDENFACTURA"
        Me.ALUMNOSPIDENFACTURABindingSource.DataSource = Me.SACDataSet
        '
        'ALUMNOSPIDENFACTURATableAdapter
        '
        Me.ALUMNOSPIDENFACTURATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ALUMNOSPIDENFACTURADataGridView
        '
        Me.ALUMNOSPIDENFACTURADataGridView.AllowUserToAddRows = False
        Me.ALUMNOSPIDENFACTURADataGridView.AllowUserToDeleteRows = False
        Me.ALUMNOSPIDENFACTURADataGridView.AutoGenerateColumns = False
        Me.ALUMNOSPIDENFACTURADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ALUMNOSPIDENFACTURADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8})
        Me.ALUMNOSPIDENFACTURADataGridView.DataSource = Me.ALUMNOSPIDENFACTURABindingSource
        Me.ALUMNOSPIDENFACTURADataGridView.Location = New System.Drawing.Point(15, 12)
        Me.ALUMNOSPIDENFACTURADataGridView.Name = "ALUMNOSPIDENFACTURADataGridView"
        Me.ALUMNOSPIDENFACTURADataGridView.ReadOnly = True
        Me.ALUMNOSPIDENFACTURADataGridView.Size = New System.Drawing.Size(808, 220)
        Me.ALUMNOSPIDENFACTURADataGridView.TabIndex = 52
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
        Me.DataGridViewTextBoxColumn3.HeaderText = "DESC"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "tipopago"
        Me.DataGridViewTextBoxColumn4.HeaderText = "TIPO PAGO"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "total"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn6.HeaderText = "MONTO"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "digitoscuenta"
        Me.DataGridViewTextBoxColumn8.HeaderText = "CUENTA"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DATOSFACTURA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 433)
        Me.ControlBox = False
        Me.Controls.Add(Me.ALUMNOSPIDENFACTURADataGridView)
        Me.Controls.Add(Me.LBLIDMOV)
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.CMDIMPRIMIR)
        Me.Controls.Add(Me.DTFECHAFAC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXTFACTURA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTDIGITOSCUENTA)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DATOSFACTURA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DATOSFACTURA"
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALUMNOSPIDENFACTURABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALUMNOSPIDENFACTURADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTDIGITOSCUENTA As System.Windows.Forms.TextBox
    Friend WithEvents TXTFACTURA As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DTFECHAFAC As System.Windows.Forms.DateTimePicker
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents CMDIMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents LBLIDMOV As System.Windows.Forms.Label
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents ALUMNOSPIDENFACTURABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ALUMNOSPIDENFACTURATableAdapter As SAC.SACDataSetTableAdapters.ALUMNOSPIDENFACTURATableAdapter
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ALUMNOSPIDENFACTURADataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
