<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SELECCIONARESCOLARIDAD
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
        Me.CBOESCOLARIDAD = New System.Windows.Forms.ComboBox()
        Me.SELECCIONARESCOLARIDADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SACDataSet = New SAC.SACDataSet()
        Me.SELECCIONARESCOLARIDADTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARESCOLARIDADTableAdapter()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.CMDSALIR = New System.Windows.Forms.Button()
        Me.CDMREPORTE = New System.Windows.Forms.Button()
        CType(Me.SELECCIONARESCOLARIDADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBOESCOLARIDAD
        '
        Me.CBOESCOLARIDAD.DataSource = Me.SELECCIONARESCOLARIDADBindingSource
        Me.CBOESCOLARIDAD.DisplayMember = "escolaridad"
        Me.CBOESCOLARIDAD.FormattingEnabled = True
        Me.CBOESCOLARIDAD.Location = New System.Drawing.Point(84, 12)
        Me.CBOESCOLARIDAD.Name = "CBOESCOLARIDAD"
        Me.CBOESCOLARIDAD.Size = New System.Drawing.Size(193, 26)
        Me.CBOESCOLARIDAD.TabIndex = 0
        Me.CBOESCOLARIDAD.ValueMember = "idgrado"
        '
        'SELECCIONARESCOLARIDADBindingSource
        '
        Me.SELECCIONARESCOLARIDADBindingSource.DataMember = "SELECCIONARESCOLARIDAD"
        Me.SELECCIONARESCOLARIDADBindingSource.DataSource = Me.SACDataSet
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SELECCIONARESCOLARIDADTableAdapter
        '
        Me.SELECCIONARESCOLARIDADTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CMDSALIR
        '
        Me.CMDSALIR.BackgroundImage = Global.SAC.My.Resources.Resources.Visualpharm_Must_Have_Log_Out
        Me.CMDSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDSALIR.Location = New System.Drawing.Point(297, 90)
        Me.CMDSALIR.Name = "CMDSALIR"
        Me.CMDSALIR.Size = New System.Drawing.Size(40, 37)
        Me.CMDSALIR.TabIndex = 28
        Me.CMDSALIR.UseVisualStyleBackColor = True
        '
        'CDMREPORTE
        '
        Me.CDMREPORTE.Image = Global.SAC.My.Resources.Resources.REPORTE_PRELIMINAR
        Me.CDMREPORTE.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CDMREPORTE.Location = New System.Drawing.Point(110, 60)
        Me.CDMREPORTE.Name = "CDMREPORTE"
        Me.CDMREPORTE.Size = New System.Drawing.Size(136, 61)
        Me.CDMREPORTE.TabIndex = 27
        Me.CDMREPORTE.Text = "VER REPORTE"
        Me.CDMREPORTE.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CDMREPORTE.UseVisualStyleBackColor = True
        '
        'SELECCIONARESCOLARIDAD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 139)
        Me.ControlBox = False
        Me.Controls.Add(Me.CMDSALIR)
        Me.Controls.Add(Me.CDMREPORTE)
        Me.Controls.Add(Me.CBOESCOLARIDAD)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SELECCIONARESCOLARIDAD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SELECCIONA RESCOLARIDAD"
        CType(Me.SELECCIONARESCOLARIDADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CBOESCOLARIDAD As System.Windows.Forms.ComboBox
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents SELECCIONARESCOLARIDADBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARESCOLARIDADTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARESCOLARIDADTableAdapter
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CMDSALIR As System.Windows.Forms.Button
    Friend WithEvents CDMREPORTE As System.Windows.Forms.Button
End Class
