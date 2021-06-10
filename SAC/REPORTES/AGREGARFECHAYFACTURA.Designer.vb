<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AGREGARFECHAYFACTURA
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
        Dim FechafacturaLabel As System.Windows.Forms.Label
        Dim NumfacturaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AGREGARFECHAYFACTURA))
        Me.SACDataSet = New SAC.SACDataSet()
        Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARMOVPARFACTURAPORALUMNOTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARMOVPARFACTURAPORALUMNOTableAdapter()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.FechafacturaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NumfacturaTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionLabel1 = New System.Windows.Forms.Label()
        Me.LBLIDMOV = New System.Windows.Forms.Label()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.CMDGUARDAR = New System.Windows.Forms.Button()
        FechafacturaLabel = New System.Windows.Forms.Label()
        NumfacturaLabel = New System.Windows.Forms.Label()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'FechafacturaLabel
        '
        FechafacturaLabel.AutoSize = True
        FechafacturaLabel.Location = New System.Drawing.Point(46, 132)
        FechafacturaLabel.Name = "FechafacturaLabel"
        FechafacturaLabel.Size = New System.Drawing.Size(140, 18)
        FechafacturaLabel.TabIndex = 1
        FechafacturaLabel.Text = "FECHA FACTURA"
        '
        'NumfacturaLabel
        '
        NumfacturaLabel.AutoSize = True
        NumfacturaLabel.Location = New System.Drawing.Point(82, 97)
        NumfacturaLabel.Name = "NumfacturaLabel"
        NumfacturaLabel.Size = New System.Drawing.Size(95, 18)
        NumfacturaLabel.TabIndex = 3
        NumfacturaLabel.Text = "# FACTURA"
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SELECCIONARMOVPARFACTURAPORALUMNOBindingSource
        '
        Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingSource.DataMember = "SELECCIONARMOVPARFACTURAPORALUMNO"
        Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARMOVPARFACTURAPORALUMNOTableAdapter
        '
        Me.SELECCIONARMOVPARFACTURAPORALUMNOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator
        '
        Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator.AddNewItem = Nothing
        Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator.BindingSource = Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingSource
        Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator.DeleteItem = Nothing
        Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator.Location = New System.Drawing.Point(153, 9)
        Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator.Name = "SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator"
        Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator.Size = New System.Drawing.Size(208, 25)
        Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator.TabIndex = 0
        Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator.Text = "BindingNavigator1"
        '
        'FechafacturaDateTimePicker
        '
        Me.FechafacturaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingSource, "fechafactura", True))
        Me.FechafacturaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechafacturaDateTimePicker.Location = New System.Drawing.Point(192, 126)
        Me.FechafacturaDateTimePicker.Name = "FechafacturaDateTimePicker"
        Me.FechafacturaDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.FechafacturaDateTimePicker.TabIndex = 2
        '
        'NumfacturaTextBox
        '
        Me.NumfacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingSource, "numfactura", True))
        Me.NumfacturaTextBox.Location = New System.Drawing.Point(192, 94)
        Me.NumfacturaTextBox.Name = "NumfacturaTextBox"
        Me.NumfacturaTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NumfacturaTextBox.TabIndex = 4
        '
        'DescripcionLabel1
        '
        Me.DescripcionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingSource, "descripcion", True))
        Me.DescripcionLabel1.Location = New System.Drawing.Point(82, 41)
        Me.DescripcionLabel1.Name = "DescripcionLabel1"
        Me.DescripcionLabel1.Size = New System.Drawing.Size(187, 23)
        Me.DescripcionLabel1.TabIndex = 6
        Me.DescripcionLabel1.Text = "DESCRIPCION"
        '
        'LBLIDMOV
        '
        Me.LBLIDMOV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingSource, "idmov", True))
        Me.LBLIDMOV.Location = New System.Drawing.Point(370, 219)
        Me.LBLIDMOV.Name = "LBLIDMOV"
        Me.LBLIDMOV.Size = New System.Drawing.Size(100, 23)
        Me.LBLIDMOV.TabIndex = 8
        Me.LBLIDMOV.Text = "IDMOV"
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Image = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR.Location = New System.Drawing.Point(250, 172)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(114, 60)
        Me.CMDCANCELAR.TabIndex = 18
        Me.CMDCANCELAR.Text = "CERRAR"
        Me.CMDCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'CMDGUARDAR
        '
        Me.CMDGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDGUARDAR.Image = Global.SAC.My.Resources.Resources.GUARDAR_REGISTRO1
        Me.CMDGUARDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDGUARDAR.Location = New System.Drawing.Point(130, 172)
        Me.CMDGUARDAR.Name = "CMDGUARDAR"
        Me.CMDGUARDAR.Size = New System.Drawing.Size(114, 60)
        Me.CMDGUARDAR.TabIndex = 17
        Me.CMDGUARDAR.Text = "GUARDAR"
        Me.CMDGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDGUARDAR.UseVisualStyleBackColor = True
        '
        'AGREGARFECHAYFACTURA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 252)
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.CMDGUARDAR)
        Me.Controls.Add(Me.LBLIDMOV)
        Me.Controls.Add(Me.DescripcionLabel1)
        Me.Controls.Add(NumfacturaLabel)
        Me.Controls.Add(Me.NumfacturaTextBox)
        Me.Controls.Add(FechafacturaLabel)
        Me.Controls.Add(Me.FechafacturaDateTimePicker)
        Me.Controls.Add(Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AGREGARFECHAYFACTURA"
        Me.Text = "AGREGARFECHAYFACTURA"
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator.ResumeLayout(False)
        Me.SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents SELECCIONARMOVPARFACTURAPORALUMNOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARMOVPARFACTURAPORALUMNOTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARMOVPARFACTURAPORALUMNOTableAdapter
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SELECCIONARMOVPARFACTURAPORALUMNOBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents FechafacturaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NumfacturaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionLabel1 As System.Windows.Forms.Label
    Friend WithEvents LBLIDMOV As System.Windows.Forms.Label
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents CMDGUARDAR As System.Windows.Forms.Button
End Class
