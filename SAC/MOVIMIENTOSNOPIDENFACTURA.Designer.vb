<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MOVIMIENTOSNOPIDENFACTURA
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
        Dim FacturaLabel As System.Windows.Forms.Label
        Dim DigitoscuentaLabel As System.Windows.Forms.Label
        Dim FechafacturaLabel As System.Windows.Forms.Label
        Me.SACDataSet = New SAC.SACDataSet()
        Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURATableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARMOVIMIENTOSNOPIDENFACTURATableAdapter()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURADataGridView = New System.Windows.Forms.DataGridView()
        Me.CBFACTURA = New System.Windows.Forms.CheckBox()
        Me.TXTDIGITOSCUENTA = New System.Windows.Forms.TextBox()
        Me.DTFECHAFACTURA = New System.Windows.Forms.DateTimePicker()
        Me.LBLIDMOV = New System.Windows.Forms.Label()
        Me.DTFEHCAINI = New System.Windows.Forms.DateTimePicker()
        Me.DTFECHAFIN = New System.Windows.Forms.DateTimePicker()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.CMDGUARDAR = New System.Windows.Forms.Button()
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
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        FacturaLabel = New System.Windows.Forms.Label()
        DigitoscuentaLabel = New System.Windows.Forms.Label()
        FechafacturaLabel = New System.Windows.Forms.Label()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FacturaLabel
        '
        FacturaLabel.AutoSize = True
        FacturaLabel.Location = New System.Drawing.Point(12, 306)
        FacturaLabel.Name = "FacturaLabel"
        FacturaLabel.Size = New System.Drawing.Size(89, 20)
        FacturaLabel.TabIndex = 2
        FacturaLabel.Text = "FACTURA:"
        '
        'DigitoscuentaLabel
        '
        DigitoscuentaLabel.AutoSize = True
        DigitoscuentaLabel.Location = New System.Drawing.Point(285, 306)
        DigitoscuentaLabel.Name = "DigitoscuentaLabel"
        DigitoscuentaLabel.Size = New System.Drawing.Size(145, 20)
        DigitoscuentaLabel.TabIndex = 3
        DigitoscuentaLabel.Text = "DIGITOS CUENTA"
        '
        'FechafacturaLabel
        '
        FechafacturaLabel.AutoSize = True
        FechafacturaLabel.Location = New System.Drawing.Point(533, 306)
        FechafacturaLabel.Name = "FechafacturaLabel"
        FechafacturaLabel.Size = New System.Drawing.Size(144, 20)
        FechafacturaLabel.TabIndex = 5
        FechafacturaLabel.Text = "FECHA FACTURA"
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SELECCIONARMOVIMIENTOSNOPIDENFACTURABindingSource
        '
        Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURABindingSource.DataMember = "SELECCIONARMOVIMIENTOSNOPIDENFACTURA"
        Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURABindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARMOVIMIENTOSNOPIDENFACTURATableAdapter
        '
        Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SELECCIONARMOVIMIENTOSNOPIDENFACTURADataGridView
        '
        Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURADataGridView.AllowUserToAddRows = False
        Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURADataGridView.AllowUserToDeleteRows = False
        Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURADataGridView.AutoGenerateColumns = False
        Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURADataGridView.DataSource = Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURABindingSource
        Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURADataGridView.Location = New System.Drawing.Point(16, 71)
        Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURADataGridView.Name = "SELECCIONARMOVIMIENTOSNOPIDENFACTURADataGridView"
        Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURADataGridView.ReadOnly = True
        Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURADataGridView.Size = New System.Drawing.Size(767, 220)
        Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURADataGridView.TabIndex = 2
        '
        'CBFACTURA
        '
        Me.CBFACTURA.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURABindingSource, "factura", True))
        Me.CBFACTURA.Location = New System.Drawing.Point(16, 329)
        Me.CBFACTURA.Name = "CBFACTURA"
        Me.CBFACTURA.Size = New System.Drawing.Size(104, 24)
        Me.CBFACTURA.TabIndex = 3
        Me.CBFACTURA.Text = "FACTURA"
        Me.CBFACTURA.UseVisualStyleBackColor = True
        '
        'TXTDIGITOSCUENTA
        '
        Me.TXTDIGITOSCUENTA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURABindingSource, "digitoscuenta", True))
        Me.TXTDIGITOSCUENTA.Location = New System.Drawing.Point(289, 332)
        Me.TXTDIGITOSCUENTA.Name = "TXTDIGITOSCUENTA"
        Me.TXTDIGITOSCUENTA.Size = New System.Drawing.Size(158, 26)
        Me.TXTDIGITOSCUENTA.TabIndex = 4
        '
        'DTFECHAFACTURA
        '
        Me.DTFECHAFACTURA.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURABindingSource, "fechafactura", True))
        Me.DTFECHAFACTURA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFECHAFACTURA.Location = New System.Drawing.Point(537, 329)
        Me.DTFECHAFACTURA.Name = "DTFECHAFACTURA"
        Me.DTFECHAFACTURA.Size = New System.Drawing.Size(200, 26)
        Me.DTFECHAFACTURA.TabIndex = 6
        '
        'LBLIDMOV
        '
        Me.LBLIDMOV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURABindingSource, "idmov", True))
        Me.LBLIDMOV.Location = New System.Drawing.Point(12, 441)
        Me.LBLIDMOV.Name = "LBLIDMOV"
        Me.LBLIDMOV.Size = New System.Drawing.Size(100, 23)
        Me.LBLIDMOV.TabIndex = 8
        Me.LBLIDMOV.Text = "Label1"
        '
        'DTFEHCAINI
        '
        Me.DTFEHCAINI.Location = New System.Drawing.Point(16, 24)
        Me.DTFEHCAINI.Name = "DTFEHCAINI"
        Me.DTFEHCAINI.Size = New System.Drawing.Size(200, 26)
        Me.DTFEHCAINI.TabIndex = 9
        '
        'DTFECHAFIN
        '
        Me.DTFECHAFIN.Location = New System.Drawing.Point(583, 24)
        Me.DTFECHAFIN.Name = "DTFECHAFIN"
        Me.DTFECHAFIN.Size = New System.Drawing.Size(200, 26)
        Me.DTFECHAFIN.TabIndex = 10
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Image = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR.Location = New System.Drawing.Point(401, 390)
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
        Me.CMDGUARDAR.Image = Global.SAC.My.Resources.Resources.GUARDAR_REGISTRO1
        Me.CMDGUARDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDGUARDAR.Location = New System.Drawing.Point(273, 390)
        Me.CMDGUARDAR.Name = "CMDGUARDAR"
        Me.CMDGUARDAR.Size = New System.Drawing.Size(100, 61)
        Me.CMDGUARDAR.TabIndex = 14
        Me.CMDGUARDAR.Text = "GUARDAR"
        Me.CMDGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDGUARDAR.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FECHA"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "hora"
        Me.DataGridViewTextBoxColumn3.HeaderText = "HORA"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "abono"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ABONO"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "resta"
        Me.DataGridViewTextBoxColumn5.HeaderText = "RESTA"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "total"
        Me.DataGridViewTextBoxColumn6.HeaderText = "TOTAL"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "DESCRIPCION"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 200
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "numrecibo"
        Me.DataGridViewTextBoxColumn8.HeaderText = "# REC"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "numfolio"
        Me.DataGridViewTextBoxColumn9.HeaderText = "# FOL"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "numfactura"
        Me.DataGridViewTextBoxColumn10.HeaderText = "# FACTURA"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "matri"
        Me.DataGridViewTextBoxColumn11.HeaderText = "MATRI"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "factura"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "FACTURA"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "digitoscuenta"
        Me.DataGridViewTextBoxColumn12.HeaderText = "D. CUENTA"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "fechafactura"
        Me.DataGridViewTextBoxColumn13.HeaderText = "F. FACTURA"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'MOVIMIENTOSNOPIDENFACTURA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 473)
        Me.ControlBox = False
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.CMDGUARDAR)
        Me.Controls.Add(Me.DTFECHAFIN)
        Me.Controls.Add(Me.DTFEHCAINI)
        Me.Controls.Add(Me.LBLIDMOV)
        Me.Controls.Add(FechafacturaLabel)
        Me.Controls.Add(Me.DTFECHAFACTURA)
        Me.Controls.Add(DigitoscuentaLabel)
        Me.Controls.Add(Me.TXTDIGITOSCUENTA)
        Me.Controls.Add(FacturaLabel)
        Me.Controls.Add(Me.CBFACTURA)
        Me.Controls.Add(Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURADataGridView)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MOVIMIENTOSNOPIDENFACTURA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MOVIMIENTOSNOPIDENFACTURA"
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARMOVIMIENTOSNOPIDENFACTURADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents SELECCIONARMOVIMIENTOSNOPIDENFACTURABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARMOVIMIENTOSNOPIDENFACTURATableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARMOVIMIENTOSNOPIDENFACTURATableAdapter
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SELECCIONARMOVIMIENTOSNOPIDENFACTURADataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CBFACTURA As System.Windows.Forms.CheckBox
    Friend WithEvents TXTDIGITOSCUENTA As System.Windows.Forms.TextBox
    Friend WithEvents DTFECHAFACTURA As System.Windows.Forms.DateTimePicker
    Friend WithEvents LBLIDMOV As System.Windows.Forms.Label
    Friend WithEvents DTFEHCAINI As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTFECHAFIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents CMDGUARDAR As System.Windows.Forms.Button
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
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
