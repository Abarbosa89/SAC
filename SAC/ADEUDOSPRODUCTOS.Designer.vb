<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADEUDOSPRODUCTOS
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
        Dim AbonoLabel As System.Windows.Forms.Label
        Dim RestaLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.CBOPRODUCTOS = New System.Windows.Forms.ComboBox()
        Me.SELECCIONARADEUDOSARTICULOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SACDataSet = New SAC.SACDataSet()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.CMDIMPRIMIR = New System.Windows.Forms.Button()
        Me.CMDLIQUIDAR = New System.Windows.Forms.Button()
        Me.CMDABONO = New System.Windows.Forms.Button()
        Me.SELECCIONARADEUDOSARTICULOSTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARADEUDOSARTICULOSTableAdapter()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.NUEVORECIBOFOLIOFACTURABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NUEVORECIBOFOLIOFACTURATableAdapter = New SAC.SACDataSetTableAdapters.NUEVORECIBOFOLIOFACTURATableAdapter()
        Me.LBLRECIBOMAX = New System.Windows.Forms.Label()
        Me.LBLNVORECIBO = New System.Windows.Forms.Label()
        Me.LBLABONOANT = New System.Windows.Forms.Label()
        Me.LBLRESTAANT = New System.Windows.Forms.Label()
        Me.LBLNVARESTA = New System.Windows.Forms.Label()
        Me.LBLNVOABONO = New System.Windows.Forms.Label()
        Me.LBLIDPRODUC = New System.Windows.Forms.Label()
        Me.LBLCONCEPTO = New System.Windows.Forms.Label()
        AbonoLabel = New System.Windows.Forms.Label()
        RestaLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.SELECCIONARADEUDOSARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUEVORECIBOFOLIOFACTURABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AbonoLabel
        '
        AbonoLabel.AutoSize = True
        AbonoLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AbonoLabel.Location = New System.Drawing.Point(13, 74)
        AbonoLabel.Name = "AbonoLabel"
        AbonoLabel.Size = New System.Drawing.Size(104, 19)
        AbonoLabel.TabIndex = 51
        AbonoLabel.Text = "ABONO ANT"
        '
        'RestaLabel
        '
        RestaLabel.AutoSize = True
        RestaLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RestaLabel.Location = New System.Drawing.Point(145, 74)
        RestaLabel.Name = "RestaLabel"
        RestaLabel.Size = New System.Drawing.Size(98, 19)
        RestaLabel.TabIndex = 52
        RestaLabel.Text = "RESTA ANT"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(489, 74)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(99, 19)
        Label1.TabIndex = 55
        Label1.Text = "NVA RESTA"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(357, 74)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(106, 19)
        Label2.TabIndex = 54
        Label2.Text = "NVO ABONO"
        '
        'CBOPRODUCTOS
        '
        Me.CBOPRODUCTOS.DataSource = Me.SELECCIONARADEUDOSARTICULOSBindingSource
        Me.CBOPRODUCTOS.DisplayMember = "descripcion"
        Me.CBOPRODUCTOS.FormattingEnabled = True
        Me.CBOPRODUCTOS.Location = New System.Drawing.Point(17, 12)
        Me.CBOPRODUCTOS.Name = "CBOPRODUCTOS"
        Me.CBOPRODUCTOS.Size = New System.Drawing.Size(568, 26)
        Me.CBOPRODUCTOS.TabIndex = 0
        Me.CBOPRODUCTOS.ValueMember = "idmov"
        '
        'SELECCIONARADEUDOSARTICULOSBindingSource
        '
        Me.SELECCIONARADEUDOSARTICULOSBindingSource.DataMember = "SELECCIONARADEUDOSARTICULOS"
        Me.SELECCIONARADEUDOSARTICULOSBindingSource.DataSource = Me.SACDataSet
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Image = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR.Location = New System.Drawing.Point(477, 181)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(100, 57)
        Me.CMDCANCELAR.TabIndex = 48
        Me.CMDCANCELAR.Text = "CERRAR"
        Me.CMDCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'CMDIMPRIMIR
        '
        Me.CMDIMPRIMIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDIMPRIMIR.Image = Global.SAC.My.Resources.Resources.PRINTER
        Me.CMDIMPRIMIR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDIMPRIMIR.Location = New System.Drawing.Point(371, 181)
        Me.CMDIMPRIMIR.Name = "CMDIMPRIMIR"
        Me.CMDIMPRIMIR.Size = New System.Drawing.Size(100, 57)
        Me.CMDIMPRIMIR.TabIndex = 47
        Me.CMDIMPRIMIR.Text = "IMPRIMIR"
        Me.CMDIMPRIMIR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDIMPRIMIR.UseVisualStyleBackColor = True
        '
        'CMDLIQUIDAR
        '
        Me.CMDLIQUIDAR.Image = Global.SAC.My.Resources.Resources.Aha_Soft_Business_Toolbar_Payment
        Me.CMDLIQUIDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDLIQUIDAR.Location = New System.Drawing.Point(118, 181)
        Me.CMDLIQUIDAR.Name = "CMDLIQUIDAR"
        Me.CMDLIQUIDAR.Size = New System.Drawing.Size(100, 57)
        Me.CMDLIQUIDAR.TabIndex = 46
        Me.CMDLIQUIDAR.Text = "LIQUIDAR"
        Me.CMDLIQUIDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDLIQUIDAR.UseVisualStyleBackColor = True
        '
        'CMDABONO
        '
        Me.CMDABONO.Image = Global.SAC.My.Resources.Resources.Aha_Soft_Business_Toolbar_Payment
        Me.CMDABONO.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDABONO.Location = New System.Drawing.Point(12, 181)
        Me.CMDABONO.Name = "CMDABONO"
        Me.CMDABONO.Size = New System.Drawing.Size(100, 57)
        Me.CMDABONO.TabIndex = 45
        Me.CMDABONO.Text = "ABONO"
        Me.CMDABONO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDABONO.UseVisualStyleBackColor = True
        '
        'SELECCIONARADEUDOSARTICULOSTableAdapter
        '
        Me.SELECCIONARADEUDOSARTICULOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NUEVORECIBOFOLIOFACTURABindingSource
        '
        Me.NUEVORECIBOFOLIOFACTURABindingSource.DataMember = "NUEVORECIBOFOLIOFACTURA"
        Me.NUEVORECIBOFOLIOFACTURABindingSource.DataSource = Me.SACDataSet
        '
        'NUEVORECIBOFOLIOFACTURATableAdapter
        '
        Me.NUEVORECIBOFOLIOFACTURATableAdapter.ClearBeforeFill = True
        '
        'LBLRECIBOMAX
        '
        Me.LBLRECIBOMAX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NUEVORECIBOFOLIOFACTURABindingSource, "NOFOLIO", True))
        Me.LBLRECIBOMAX.Location = New System.Drawing.Point(244, 181)
        Me.LBLRECIBOMAX.Name = "LBLRECIBOMAX"
        Me.LBLRECIBOMAX.Size = New System.Drawing.Size(100, 23)
        Me.LBLRECIBOMAX.TabIndex = 50
        Me.LBLRECIBOMAX.Text = "RECIBOMAX"
        '
        'LBLNVORECIBO
        '
        Me.LBLNVORECIBO.AutoSize = True
        Me.LBLNVORECIBO.Location = New System.Drawing.Point(239, 204)
        Me.LBLNVORECIBO.Name = "LBLNVORECIBO"
        Me.LBLNVORECIBO.Size = New System.Drawing.Size(102, 18)
        Me.LBLNVORECIBO.TabIndex = 51
        Me.LBLNVORECIBO.Text = "NVORECIBO"
        '
        'LBLABONOANT
        '
        Me.LBLABONOANT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARADEUDOSARTICULOSBindingSource, "abono", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.LBLABONOANT.Location = New System.Drawing.Point(13, 99)
        Me.LBLABONOANT.Name = "LBLABONOANT"
        Me.LBLABONOANT.Size = New System.Drawing.Size(100, 23)
        Me.LBLABONOANT.TabIndex = 52
        Me.LBLABONOANT.Text = "ABONO"
        '
        'LBLRESTAANT
        '
        Me.LBLRESTAANT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARADEUDOSARTICULOSBindingSource, "resta", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.LBLRESTAANT.Location = New System.Drawing.Point(145, 99)
        Me.LBLRESTAANT.Name = "LBLRESTAANT"
        Me.LBLRESTAANT.Size = New System.Drawing.Size(100, 23)
        Me.LBLRESTAANT.TabIndex = 53
        Me.LBLRESTAANT.Text = "RESTA"
        '
        'LBLNVARESTA
        '
        Me.LBLNVARESTA.AutoSize = True
        Me.LBLNVARESTA.Location = New System.Drawing.Point(497, 99)
        Me.LBLNVARESTA.Name = "LBLNVARESTA"
        Me.LBLNVARESTA.Size = New System.Drawing.Size(92, 18)
        Me.LBLNVARESTA.TabIndex = 57
        Me.LBLNVARESTA.Text = "NVARESTA"
        '
        'LBLNVOABONO
        '
        Me.LBLNVOABONO.AutoSize = True
        Me.LBLNVOABONO.Location = New System.Drawing.Point(364, 99)
        Me.LBLNVOABONO.Name = "LBLNVOABONO"
        Me.LBLNVOABONO.Size = New System.Drawing.Size(99, 18)
        Me.LBLNVOABONO.TabIndex = 56
        Me.LBLNVOABONO.Text = "NVOABONO"
        '
        'LBLIDPRODUC
        '
        Me.LBLIDPRODUC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARADEUDOSARTICULOSBindingSource, "idproduc", True))
        Me.LBLIDPRODUC.Location = New System.Drawing.Point(239, 222)
        Me.LBLIDPRODUC.Name = "LBLIDPRODUC"
        Me.LBLIDPRODUC.Size = New System.Drawing.Size(100, 23)
        Me.LBLIDPRODUC.TabIndex = 58
        Me.LBLIDPRODUC.Text = "IDPRODUC"
        '
        'LBLCONCEPTO
        '
        Me.LBLCONCEPTO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARADEUDOSARTICULOSBindingSource, "concep", True))
        Me.LBLCONCEPTO.Location = New System.Drawing.Point(14, 238)
        Me.LBLCONCEPTO.Name = "LBLCONCEPTO"
        Me.LBLCONCEPTO.Size = New System.Drawing.Size(100, 23)
        Me.LBLCONCEPTO.TabIndex = 59
        Me.LBLCONCEPTO.Text = "CONCEPT"
        '
        'ADEUDOSPRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 256)
        Me.Controls.Add(Me.LBLCONCEPTO)
        Me.Controls.Add(Me.LBLIDPRODUC)
        Me.Controls.Add(Me.LBLNVARESTA)
        Me.Controls.Add(Me.LBLNVOABONO)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(RestaLabel)
        Me.Controls.Add(Me.LBLRESTAANT)
        Me.Controls.Add(AbonoLabel)
        Me.Controls.Add(Me.LBLABONOANT)
        Me.Controls.Add(Me.LBLNVORECIBO)
        Me.Controls.Add(Me.LBLRECIBOMAX)
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.CMDIMPRIMIR)
        Me.Controls.Add(Me.CMDLIQUIDAR)
        Me.Controls.Add(Me.CMDABONO)
        Me.Controls.Add(Me.CBOPRODUCTOS)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ADEUDOSPRODUCTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADEUDOSPRODUCTOS"
        CType(Me.SELECCIONARADEUDOSARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUEVORECIBOFOLIOFACTURABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBOPRODUCTOS As System.Windows.Forms.ComboBox
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents CMDIMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents CMDLIQUIDAR As System.Windows.Forms.Button
    Friend WithEvents CMDABONO As System.Windows.Forms.Button
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents SELECCIONARADEUDOSARTICULOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARADEUDOSARTICULOSTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARADEUDOSARTICULOSTableAdapter
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NUEVORECIBOFOLIOFACTURABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NUEVORECIBOFOLIOFACTURATableAdapter As SAC.SACDataSetTableAdapters.NUEVORECIBOFOLIOFACTURATableAdapter
    Friend WithEvents LBLRECIBOMAX As System.Windows.Forms.Label
    Friend WithEvents LBLNVORECIBO As System.Windows.Forms.Label
    Friend WithEvents LBLABONOANT As System.Windows.Forms.Label
    Friend WithEvents LBLRESTAANT As System.Windows.Forms.Label
    Friend WithEvents LBLNVARESTA As System.Windows.Forms.Label
    Friend WithEvents LBLNVOABONO As System.Windows.Forms.Label
    Friend WithEvents LBLIDPRODUC As System.Windows.Forms.Label
    Friend WithEvents LBLCONCEPTO As System.Windows.Forms.Label
End Class
