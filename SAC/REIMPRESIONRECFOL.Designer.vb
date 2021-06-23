<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REIMPRESIONRECFOL
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SACDataSet = New SAC.SACDataSet()
        Me.SELCCIONARMOVPARAREIMPRSIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELCCIONARMOVPARAREIMPRSIONTableAdapter = New SAC.SACDataSetTableAdapters.SELCCIONARMOVPARAREIMPRSIONTableAdapter()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.SELCCIONARMOVPARAREIMPRSIONDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTDESDE = New System.Windows.Forms.DateTimePicker()
        Me.DTHASTA = New System.Windows.Forms.DateTimePicker()
        Me.CDMCERRAR = New System.Windows.Forms.Button()
        Me.CMDREIMPRESION = New System.Windows.Forms.Button()
        Me.LBLNUMFOLIO = New System.Windows.Forms.Label()
        Me.LBLNUMRECIBO = New System.Windows.Forms.Label()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELCCIONARMOVPARAREIMPRSIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELCCIONARMOVPARAREIMPRSIONDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SELCCIONARMOVPARAREIMPRSIONBindingSource
        '
        Me.SELCCIONARMOVPARAREIMPRSIONBindingSource.DataMember = "SELCCIONARMOVPARAREIMPRSION"
        Me.SELCCIONARMOVPARAREIMPRSIONBindingSource.DataSource = Me.SACDataSet
        '
        'SELCCIONARMOVPARAREIMPRSIONTableAdapter
        '
        Me.SELCCIONARMOVPARAREIMPRSIONTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SELCCIONARMOVPARAREIMPRSIONDataGridView
        '
        Me.SELCCIONARMOVPARAREIMPRSIONDataGridView.AllowUserToAddRows = False
        Me.SELCCIONARMOVPARAREIMPRSIONDataGridView.AllowUserToDeleteRows = False
        Me.SELCCIONARMOVPARAREIMPRSIONDataGridView.AutoGenerateColumns = False
        Me.SELCCIONARMOVPARAREIMPRSIONDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SELCCIONARMOVPARAREIMPRSIONDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.SELCCIONARMOVPARAREIMPRSIONDataGridView.DataSource = Me.SELCCIONARMOVPARAREIMPRSIONBindingSource
        Me.SELCCIONARMOVPARAREIMPRSIONDataGridView.Location = New System.Drawing.Point(12, 67)
        Me.SELCCIONARMOVPARAREIMPRSIONDataGridView.Name = "SELCCIONARMOVPARAREIMPRSIONDataGridView"
        Me.SELCCIONARMOVPARAREIMPRSIONDataGridView.ReadOnly = True
        Me.SELCCIONARMOVPARAREIMPRSIONDataGridView.Size = New System.Drawing.Size(788, 220)
        Me.SELCCIONARMOVPARAREIMPRSIONDataGridView.TabIndex = 2
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
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn4.HeaderText = "FECHA"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "hora"
        Me.DataGridViewTextBoxColumn5.HeaderText = "HORA"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn9.HeaderText = "DESC"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "abono"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn6.HeaderText = "ABONO"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "resta"
        DataGridViewCellStyle2.Format = "C2"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn7.HeaderText = "RESTA"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "total"
        DataGridViewCellStyle3.Format = "C2"
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn8.HeaderText = "TOTAL"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DTDESDE
        '
        Me.DTDESDE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDESDE.Location = New System.Drawing.Point(37, 17)
        Me.DTDESDE.Name = "DTDESDE"
        Me.DTDESDE.Size = New System.Drawing.Size(200, 22)
        Me.DTDESDE.TabIndex = 3
        '
        'DTHASTA
        '
        Me.DTHASTA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTHASTA.Location = New System.Drawing.Point(555, 17)
        Me.DTHASTA.Name = "DTHASTA"
        Me.DTHASTA.Size = New System.Drawing.Size(200, 22)
        Me.DTHASTA.TabIndex = 4
        '
        'CDMCERRAR
        '
        Me.CDMCERRAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CDMCERRAR.Image = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CDMCERRAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CDMCERRAR.Location = New System.Drawing.Point(446, 305)
        Me.CDMCERRAR.Name = "CDMCERRAR"
        Me.CDMCERRAR.Size = New System.Drawing.Size(114, 63)
        Me.CDMCERRAR.TabIndex = 18
        Me.CDMCERRAR.Text = "CERRAR"
        Me.CDMCERRAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CDMCERRAR.UseVisualStyleBackColor = True
        '
        'CMDREIMPRESION
        '
        Me.CMDREIMPRESION.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDREIMPRESION.Image = Global.SAC.My.Resources.Resources.PRINTER
        Me.CMDREIMPRESION.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDREIMPRESION.Location = New System.Drawing.Point(285, 305)
        Me.CMDREIMPRESION.Name = "CMDREIMPRESION"
        Me.CMDREIMPRESION.Size = New System.Drawing.Size(114, 63)
        Me.CMDREIMPRESION.TabIndex = 17
        Me.CMDREIMPRESION.Text = "REIMPRESION"
        Me.CMDREIMPRESION.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDREIMPRESION.UseVisualStyleBackColor = True
        '
        'LBLNUMFOLIO
        '
        Me.LBLNUMFOLIO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELCCIONARMOVPARAREIMPRSIONBindingSource, "numfolio", True))
        Me.LBLNUMFOLIO.Location = New System.Drawing.Point(9, 478)
        Me.LBLNUMFOLIO.Name = "LBLNUMFOLIO"
        Me.LBLNUMFOLIO.Size = New System.Drawing.Size(100, 23)
        Me.LBLNUMFOLIO.TabIndex = 19
        Me.LBLNUMFOLIO.Text = "#FOLIO"
        '
        'LBLNUMRECIBO
        '
        Me.LBLNUMRECIBO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELCCIONARMOVPARAREIMPRSIONBindingSource, "numrecibo", True))
        Me.LBLNUMRECIBO.Location = New System.Drawing.Point(9, 501)
        Me.LBLNUMRECIBO.Name = "LBLNUMRECIBO"
        Me.LBLNUMRECIBO.Size = New System.Drawing.Size(100, 23)
        Me.LBLNUMRECIBO.TabIndex = 20
        Me.LBLNUMRECIBO.Text = "#RECIBO"
        '
        'REIMPRESIONRECFOL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 385)
        Me.Controls.Add(Me.LBLNUMRECIBO)
        Me.Controls.Add(Me.LBLNUMFOLIO)
        Me.Controls.Add(Me.CDMCERRAR)
        Me.Controls.Add(Me.CMDREIMPRESION)
        Me.Controls.Add(Me.DTHASTA)
        Me.Controls.Add(Me.DTDESDE)
        Me.Controls.Add(Me.SELCCIONARMOVPARAREIMPRSIONDataGridView)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "REIMPRESIONRECFOL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REIMPRESIONRECFOL"
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELCCIONARMOVPARAREIMPRSIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELCCIONARMOVPARAREIMPRSIONDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents SELCCIONARMOVPARAREIMPRSIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELCCIONARMOVPARAREIMPRSIONTableAdapter As SAC.SACDataSetTableAdapters.SELCCIONARMOVPARAREIMPRSIONTableAdapter
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SELCCIONARMOVPARAREIMPRSIONDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DTDESDE As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTHASTA As System.Windows.Forms.DateTimePicker
    Friend WithEvents CDMCERRAR As System.Windows.Forms.Button
    Friend WithEvents CMDREIMPRESION As System.Windows.Forms.Button
    Friend WithEvents LBLNUMFOLIO As System.Windows.Forms.Label
    Friend WithEvents LBLNUMRECIBO As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
