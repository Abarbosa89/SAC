<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SELECCIONDEALUMNO
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
        Me.CBOALUMNO = New System.Windows.Forms.ComboBox()
        Me.SELECCIONARALUMNOSATIVOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SACDataSet = New SAC.SACDataSet()
        Me.CBOESCOLARIDAD = New System.Windows.Forms.ComboBox()
        Me.SELECCIONARESCOLARIDADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.SELECCIONARESCOLARIDADTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARESCOLARIDADTableAdapter()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.LBLMATRI = New System.Windows.Forms.Label()
        Me.LBLGRADO = New System.Windows.Forms.Label()
        Me.LBLSEXO = New System.Windows.Forms.Label()
        Me.LBLIDGRADO = New System.Windows.Forms.Label()
        Me.CMDSELECCIONAR = New System.Windows.Forms.Button()
        Me.LBLIDNIVEL = New System.Windows.Forms.Label()
        Me.LBLPORCBECA = New System.Windows.Forms.Label()
        Me.CBBECA = New System.Windows.Forms.CheckBox()
        Me.SELECCIONARTUTORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARTUTORESTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARTUTORESTableAdapter()
        Me.CBBECASEP = New System.Windows.Forms.CheckBox()
        Me.LBLPORCBECASEP = New System.Windows.Forms.Label()
        Me.CBBECAINSC = New System.Windows.Forms.CheckBox()
        Me.LBLPORCENINSC = New System.Windows.Forms.Label()
        Me.SELECCIONARALUMNOSATIVOSTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARALUMNOSATIVOSTableAdapter()
        Me.CBREQFACTURA = New System.Windows.Forms.CheckBox()
        CType(Me.SELECCIONARALUMNOSATIVOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARESCOLARIDADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARTUTORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBOALUMNO
        '
        Me.CBOALUMNO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBOALUMNO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBOALUMNO.DataSource = Me.SELECCIONARALUMNOSATIVOSBindingSource
        Me.CBOALUMNO.DisplayMember = "ALUMNO"
        Me.CBOALUMNO.FormattingEnabled = True
        Me.CBOALUMNO.Location = New System.Drawing.Point(143, 12)
        Me.CBOALUMNO.Name = "CBOALUMNO"
        Me.CBOALUMNO.Size = New System.Drawing.Size(381, 26)
        Me.CBOALUMNO.TabIndex = 0
        Me.CBOALUMNO.ValueMember = "matri"
        '
        'SELECCIONARALUMNOSATIVOSBindingSource
        '
        Me.SELECCIONARALUMNOSATIVOSBindingSource.DataMember = "SELECCIONARALUMNOSATIVOS"
        Me.SELECCIONARALUMNOSATIVOSBindingSource.DataSource = Me.SACDataSet
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CBOESCOLARIDAD
        '
        Me.CBOESCOLARIDAD.DataSource = Me.SELECCIONARESCOLARIDADBindingSource
        Me.CBOESCOLARIDAD.DisplayMember = "escolaridad"
        Me.CBOESCOLARIDAD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOESCOLARIDAD.FormattingEnabled = True
        Me.CBOESCOLARIDAD.Location = New System.Drawing.Point(15, 12)
        Me.CBOESCOLARIDAD.Name = "CBOESCOLARIDAD"
        Me.CBOESCOLARIDAD.Size = New System.Drawing.Size(122, 26)
        Me.CBOESCOLARIDAD.TabIndex = 1
        Me.CBOESCOLARIDAD.ValueMember = "escolaridad"
        '
        'SELECCIONARESCOLARIDADBindingSource
        '
        Me.SELECCIONARESCOLARIDADBindingSource.DataMember = "SELECCIONARESCOLARIDAD"
        Me.SELECCIONARESCOLARIDADBindingSource.DataSource = Me.SACDataSet
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Image = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR.Location = New System.Drawing.Point(309, 53)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(91, 62)
        Me.CMDCANCELAR.TabIndex = 41
        Me.CMDCANCELAR.Text = "CERRAR"
        Me.CMDCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
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
        'LBLMATRI
        '
        Me.LBLMATRI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOSATIVOSBindingSource, "matri", True))
        Me.LBLMATRI.Location = New System.Drawing.Point(12, 53)
        Me.LBLMATRI.Name = "LBLMATRI"
        Me.LBLMATRI.Size = New System.Drawing.Size(100, 23)
        Me.LBLMATRI.TabIndex = 42
        Me.LBLMATRI.Text = "MATRI"
        '
        'LBLGRADO
        '
        Me.LBLGRADO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOSATIVOSBindingSource, "grado", True))
        Me.LBLGRADO.Location = New System.Drawing.Point(109, 53)
        Me.LBLGRADO.Name = "LBLGRADO"
        Me.LBLGRADO.Size = New System.Drawing.Size(100, 23)
        Me.LBLGRADO.TabIndex = 43
        Me.LBLGRADO.Text = "GRADO"
        '
        'LBLSEXO
        '
        Me.LBLSEXO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOSATIVOSBindingSource, "sexo", True))
        Me.LBLSEXO.Location = New System.Drawing.Point(109, 76)
        Me.LBLSEXO.Name = "LBLSEXO"
        Me.LBLSEXO.Size = New System.Drawing.Size(100, 23)
        Me.LBLSEXO.TabIndex = 44
        Me.LBLSEXO.Text = "SEXO"
        '
        'LBLIDGRADO
        '
        Me.LBLIDGRADO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOSATIVOSBindingSource, "idgrado", True))
        Me.LBLIDGRADO.Location = New System.Drawing.Point(12, 77)
        Me.LBLIDGRADO.Name = "LBLIDGRADO"
        Me.LBLIDGRADO.Size = New System.Drawing.Size(100, 23)
        Me.LBLIDGRADO.TabIndex = 45
        Me.LBLIDGRADO.Text = "IDGRADO"
        '
        'CMDSELECCIONAR
        '
        Me.CMDSELECCIONAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CMDSELECCIONAR.Image = Global.SAC.My.Resources.Resources.BUSCAR_REGISTRO
        Me.CMDSELECCIONAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDSELECCIONAR.Location = New System.Drawing.Point(210, 53)
        Me.CMDSELECCIONAR.Name = "CMDSELECCIONAR"
        Me.CMDSELECCIONAR.Size = New System.Drawing.Size(93, 62)
        Me.CMDSELECCIONAR.TabIndex = 46
        Me.CMDSELECCIONAR.Text = "BUSCAR"
        Me.CMDSELECCIONAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDSELECCIONAR.UseVisualStyleBackColor = True
        '
        'LBLIDNIVEL
        '
        Me.LBLIDNIVEL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOSATIVOSBindingSource, "idnivel", True))
        Me.LBLIDNIVEL.Location = New System.Drawing.Point(12, 99)
        Me.LBLIDNIVEL.Name = "LBLIDNIVEL"
        Me.LBLIDNIVEL.Size = New System.Drawing.Size(100, 23)
        Me.LBLIDNIVEL.TabIndex = 47
        Me.LBLIDNIVEL.Text = "IDNIVEL"
        '
        'LBLPORCBECA
        '
        Me.LBLPORCBECA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOSATIVOSBindingSource, "porcent", True))
        Me.LBLPORCBECA.Location = New System.Drawing.Point(109, 100)
        Me.LBLPORCBECA.Name = "LBLPORCBECA"
        Me.LBLPORCBECA.Size = New System.Drawing.Size(100, 23)
        Me.LBLPORCBECA.TabIndex = 48
        Me.LBLPORCBECA.Text = "%BECA"
        '
        'CBBECA
        '
        Me.CBBECA.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SELECCIONARALUMNOSATIVOSBindingSource, "beca", True))
        Me.CBBECA.Location = New System.Drawing.Point(435, 100)
        Me.CBBECA.Name = "CBBECA"
        Me.CBBECA.Size = New System.Drawing.Size(104, 24)
        Me.CBBECA.TabIndex = 49
        Me.CBBECA.Text = "BECA"
        Me.CBBECA.UseVisualStyleBackColor = True
        '
        'SELECCIONARTUTORESBindingSource
        '
        Me.SELECCIONARTUTORESBindingSource.DataMember = "SELECCIONARTUTORES"
        Me.SELECCIONARTUTORESBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARTUTORESTableAdapter
        '
        Me.SELECCIONARTUTORESTableAdapter.ClearBeforeFill = True
        '
        'CBBECASEP
        '
        Me.CBBECASEP.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SELECCIONARALUMNOSATIVOSBindingSource, "becasep", True))
        Me.CBBECASEP.Location = New System.Drawing.Point(435, 75)
        Me.CBBECASEP.Name = "CBBECASEP"
        Me.CBBECASEP.Size = New System.Drawing.Size(104, 24)
        Me.CBBECASEP.TabIndex = 50
        Me.CBBECASEP.Text = "BECASEP"
        Me.CBBECASEP.UseVisualStyleBackColor = True
        '
        'LBLPORCBECASEP
        '
        Me.LBLPORCBECASEP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOSATIVOSBindingSource, "porcentsep", True))
        Me.LBLPORCBECASEP.Location = New System.Drawing.Point(432, 53)
        Me.LBLPORCBECASEP.Name = "LBLPORCBECASEP"
        Me.LBLPORCBECASEP.Size = New System.Drawing.Size(100, 23)
        Me.LBLPORCBECASEP.TabIndex = 51
        Me.LBLPORCBECASEP.Text = "%BECASEP"
        '
        'CBBECAINSC
        '
        Me.CBBECAINSC.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SELECCIONARALUMNOSATIVOSBindingSource, "becainscr", True))
        Me.CBBECAINSC.Location = New System.Drawing.Point(199, 117)
        Me.CBBECAINSC.Name = "CBBECAINSC"
        Me.CBBECAINSC.Size = New System.Drawing.Size(104, 24)
        Me.CBBECAINSC.TabIndex = 52
        Me.CBBECAINSC.Text = "BECAINSC"
        Me.CBBECAINSC.UseVisualStyleBackColor = True
        '
        'LBLPORCENINSC
        '
        Me.LBLPORCENINSC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOSATIVOSBindingSource, "porcentinscr", True))
        Me.LBLPORCENINSC.Location = New System.Drawing.Point(329, 118)
        Me.LBLPORCENINSC.Name = "LBLPORCENINSC"
        Me.LBLPORCENINSC.Size = New System.Drawing.Size(100, 23)
        Me.LBLPORCENINSC.TabIndex = 53
        Me.LBLPORCENINSC.Text = "%BECAINSC"
        '
        'SELECCIONARALUMNOSATIVOSTableAdapter
        '
        Me.SELECCIONARALUMNOSATIVOSTableAdapter.ClearBeforeFill = True
        '
        'CBREQFACTURA
        '
        Me.CBREQFACTURA.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SELECCIONARALUMNOSATIVOSBindingSource, "reqfactura", True))
        Me.CBREQFACTURA.Location = New System.Drawing.Point(428, 130)
        Me.CBREQFACTURA.Name = "CBREQFACTURA"
        Me.CBREQFACTURA.Size = New System.Drawing.Size(104, 24)
        Me.CBREQFACTURA.TabIndex = 54
        Me.CBREQFACTURA.Text = "CheckBox1"
        Me.CBREQFACTURA.UseVisualStyleBackColor = True
        '
        'SELECCIONDEALUMNO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 149)
        Me.ControlBox = False
        Me.Controls.Add(Me.CBREQFACTURA)
        Me.Controls.Add(Me.LBLPORCENINSC)
        Me.Controls.Add(Me.CBBECAINSC)
        Me.Controls.Add(Me.LBLPORCBECASEP)
        Me.Controls.Add(Me.CBBECASEP)
        Me.Controls.Add(Me.CBBECA)
        Me.Controls.Add(Me.LBLPORCBECA)
        Me.Controls.Add(Me.LBLIDNIVEL)
        Me.Controls.Add(Me.CMDSELECCIONAR)
        Me.Controls.Add(Me.LBLIDGRADO)
        Me.Controls.Add(Me.LBLSEXO)
        Me.Controls.Add(Me.LBLGRADO)
        Me.Controls.Add(Me.LBLMATRI)
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.CBOESCOLARIDAD)
        Me.Controls.Add(Me.CBOALUMNO)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SELECCIONDEALUMNO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SELECCIONDEALUMNO"
        CType(Me.SELECCIONARALUMNOSATIVOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARESCOLARIDADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARTUTORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CBOALUMNO As System.Windows.Forms.ComboBox
    Friend WithEvents CBOESCOLARIDAD As System.Windows.Forms.ComboBox
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents SELECCIONARESCOLARIDADBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARESCOLARIDADTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARESCOLARIDADTableAdapter
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LBLMATRI As System.Windows.Forms.Label
    Friend WithEvents LBLGRADO As System.Windows.Forms.Label
    Friend WithEvents LBLSEXO As System.Windows.Forms.Label
    Friend WithEvents LBLIDGRADO As System.Windows.Forms.Label
    Friend WithEvents CMDSELECCIONAR As System.Windows.Forms.Button
    Friend WithEvents LBLIDNIVEL As System.Windows.Forms.Label
    Friend WithEvents LBLPORCBECA As System.Windows.Forms.Label
    Friend WithEvents CBBECA As System.Windows.Forms.CheckBox
    Friend WithEvents SELECCIONARTUTORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARTUTORESTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARTUTORESTableAdapter
    Friend WithEvents CBBECASEP As System.Windows.Forms.CheckBox
    Friend WithEvents LBLPORCBECASEP As System.Windows.Forms.Label
    Friend WithEvents CBBECAINSC As System.Windows.Forms.CheckBox
    Friend WithEvents LBLPORCENINSC As System.Windows.Forms.Label
    Friend WithEvents SELECCIONARALUMNOSATIVOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARALUMNOSATIVOSTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARALUMNOSATIVOSTableAdapter
    Friend WithEvents CBREQFACTURA As System.Windows.Forms.CheckBox
End Class
