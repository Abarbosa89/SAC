<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INSCRIPCIONCNPROMOCION
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
        Dim MatriLabel As System.Windows.Forms.Label
        Dim GradoLabel As System.Windows.Forms.Label
        Dim EscolaridadLabel As System.Windows.Forms.Label
        Dim GrupoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.CBOALUMNOS = New System.Windows.Forms.ComboBox()
        Me.SELECCIONARTODOSALUMNOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SACDataSet = New SAC.SACDataSet()
        Me.SELECCIONARTODOSALUMNOSTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARTODOSALUMNOSTableAdapter()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.MatriLabel1 = New System.Windows.Forms.Label()
        Me.GradoLabel1 = New System.Windows.Forms.Label()
        Me.EscolaridadLabel1 = New System.Windows.Forms.Label()
        Me.GrupoLabel1 = New System.Windows.Forms.Label()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.CMDIMPRIMIR = New System.Windows.Forms.Button()
        Me.SELECCIONARMONTOCOLEGPORNIVELBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARMONTOCOLEGPORNIVELTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARMONTOCOLEGPORNIVELTableAdapter()
        Me.LBLMONTOCOLE = New System.Windows.Forms.Label()
        Me.LBLMONTO = New System.Windows.Forms.Label()
        Me.PROMOCIONINSCRIPCIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROMOCIONINSCRIPCIONTableAdapter = New SAC.SACDataSetTableAdapters.PROMOCIONINSCRIPCIONTableAdapter()
        Me.LBLIDPRODUC = New System.Windows.Forms.Label()
        Me.LBLDESCRIPCION = New System.Windows.Forms.Label()
        Me.LBLPORCENTAJE = New System.Windows.Forms.Label()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.NUEVORECIBOFOLIOFACTURABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NUEVORECIBOFOLIOFACTURATableAdapter = New SAC.SACDataSetTableAdapters.NUEVORECIBOFOLIOFACTURATableAdapter()
        Me.LBLNOFOLIO = New System.Windows.Forms.Label()
        Me.LBLNVOFOLIO = New System.Windows.Forms.Label()
        Me.CBOPROMOCION = New System.Windows.Forms.ComboBox()
        Me.LBLFECHAINI = New System.Windows.Forms.Label()
        Me.LBLFECHAFIN = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LBLCONCEPTO = New System.Windows.Forms.Label()
        Me.LBLIDCOLEG = New System.Windows.Forms.Label()
        Me.SELECCIONARMONTOCOLEGIATURAPORNIVELBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARMONTOCOLEGIATURAPORNIVELTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARMONTOCOLEGIATURAPORNIVELTableAdapter()
        Me.LBLMONTOCOLEG = New System.Windows.Forms.Label()
        MatriLabel = New System.Windows.Forms.Label()
        GradoLabel = New System.Windows.Forms.Label()
        EscolaridadLabel = New System.Windows.Forms.Label()
        GrupoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.SELECCIONARTODOSALUMNOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARMONTOCOLEGPORNIVELBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROMOCIONINSCRIPCIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUEVORECIBOFOLIOFACTURABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARMONTOCOLEGIATURAPORNIVELBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MatriLabel
        '
        MatriLabel.AutoSize = True
        MatriLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatriLabel.Location = New System.Drawing.Point(23, 110)
        MatriLabel.Name = "MatriLabel"
        MatriLabel.Size = New System.Drawing.Size(64, 19)
        MatriLabel.TabIndex = 1
        MatriLabel.Text = "MATRI:"
        '
        'GradoLabel
        '
        GradoLabel.AutoSize = True
        GradoLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GradoLabel.Location = New System.Drawing.Point(193, 110)
        GradoLabel.Name = "GradoLabel"
        GradoLabel.Size = New System.Drawing.Size(74, 19)
        GradoLabel.TabIndex = 3
        GradoLabel.Text = "GRADO:"
        '
        'EscolaridadLabel
        '
        EscolaridadLabel.AutoSize = True
        EscolaridadLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EscolaridadLabel.Location = New System.Drawing.Point(410, 110)
        EscolaridadLabel.Name = "EscolaridadLabel"
        EscolaridadLabel.Size = New System.Drawing.Size(63, 19)
        EscolaridadLabel.TabIndex = 5
        EscolaridadLabel.Text = "NIVEL:"
        '
        'GrupoLabel
        '
        GrupoLabel.AutoSize = True
        GrupoLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GrupoLabel.Location = New System.Drawing.Point(216, 156)
        GrupoLabel.Name = "GrupoLabel"
        GrupoLabel.Size = New System.Drawing.Size(74, 19)
        GrupoLabel.TabIndex = 7
        GrupoLabel.Text = "GRUPO:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(268, 201)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(74, 19)
        Label1.TabIndex = 66
        Label1.Text = "MONTO:"
        '
        'CBOALUMNOS
        '
        Me.CBOALUMNOS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBOALUMNOS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBOALUMNOS.DataSource = Me.SELECCIONARTODOSALUMNOSBindingSource
        Me.CBOALUMNOS.DisplayMember = "ALUMNO"
        Me.CBOALUMNOS.Enabled = False
        Me.CBOALUMNOS.FormattingEnabled = True
        Me.CBOALUMNOS.Location = New System.Drawing.Point(26, 61)
        Me.CBOALUMNOS.Name = "CBOALUMNOS"
        Me.CBOALUMNOS.Size = New System.Drawing.Size(566, 26)
        Me.CBOALUMNOS.TabIndex = 0
        Me.CBOALUMNOS.ValueMember = "matri"
        '
        'SELECCIONARTODOSALUMNOSBindingSource
        '
        Me.SELECCIONARTODOSALUMNOSBindingSource.DataMember = "SELECCIONARTODOSALUMNOS"
        Me.SELECCIONARTODOSALUMNOSBindingSource.DataSource = Me.SACDataSet
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SELECCIONARTODOSALUMNOSTableAdapter
        '
        Me.SELECCIONARTODOSALUMNOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MatriLabel1
        '
        Me.MatriLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARTODOSALUMNOSBindingSource, "matri", True))
        Me.MatriLabel1.Location = New System.Drawing.Point(87, 110)
        Me.MatriLabel1.Name = "MatriLabel1"
        Me.MatriLabel1.Size = New System.Drawing.Size(100, 23)
        Me.MatriLabel1.TabIndex = 2
        Me.MatriLabel1.Text = "Label1"
        '
        'GradoLabel1
        '
        Me.GradoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARTODOSALUMNOSBindingSource, "grado", True))
        Me.GradoLabel1.Location = New System.Drawing.Point(269, 110)
        Me.GradoLabel1.Name = "GradoLabel1"
        Me.GradoLabel1.Size = New System.Drawing.Size(100, 23)
        Me.GradoLabel1.TabIndex = 4
        Me.GradoLabel1.Text = "Label1"
        '
        'EscolaridadLabel1
        '
        Me.EscolaridadLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARTODOSALUMNOSBindingSource, "escolaridad", True))
        Me.EscolaridadLabel1.Location = New System.Drawing.Point(473, 110)
        Me.EscolaridadLabel1.Name = "EscolaridadLabel1"
        Me.EscolaridadLabel1.Size = New System.Drawing.Size(100, 23)
        Me.EscolaridadLabel1.TabIndex = 6
        Me.EscolaridadLabel1.Text = "Label1"
        '
        'GrupoLabel1
        '
        Me.GrupoLabel1.Location = New System.Drawing.Point(291, 156)
        Me.GrupoLabel1.Name = "GrupoLabel1"
        Me.GrupoLabel1.Size = New System.Drawing.Size(100, 23)
        Me.GrupoLabel1.TabIndex = 8
        Me.GrupoLabel1.Text = "Label1"
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Image = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR.Location = New System.Drawing.Point(339, 243)
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
        Me.CMDIMPRIMIR.Location = New System.Drawing.Point(220, 243)
        Me.CMDIMPRIMIR.Name = "CMDIMPRIMIR"
        Me.CMDIMPRIMIR.Size = New System.Drawing.Size(100, 57)
        Me.CMDIMPRIMIR.TabIndex = 47
        Me.CMDIMPRIMIR.Text = "IMPRIMIR"
        Me.CMDIMPRIMIR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDIMPRIMIR.UseVisualStyleBackColor = True
        Me.CMDIMPRIMIR.Visible = False
        '
        'SELECCIONARMONTOCOLEGPORNIVELBindingSource
        '
        Me.SELECCIONARMONTOCOLEGPORNIVELBindingSource.DataMember = "SELECCIONARMONTOCOLEGPORNIVEL"
        Me.SELECCIONARMONTOCOLEGPORNIVELBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARMONTOCOLEGPORNIVELTableAdapter
        '
        Me.SELECCIONARMONTOCOLEGPORNIVELTableAdapter.ClearBeforeFill = True
        '
        'LBLMONTOCOLE
        '
        Me.LBLMONTOCOLE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARMONTOCOLEGPORNIVELBindingSource, "monto", True))
        Me.LBLMONTOCOLE.Location = New System.Drawing.Point(114, 243)
        Me.LBLMONTOCOLE.Name = "LBLMONTOCOLE"
        Me.LBLMONTOCOLE.Size = New System.Drawing.Size(100, 23)
        Me.LBLMONTOCOLE.TabIndex = 49
        Me.LBLMONTOCOLE.Text = "MONTO"
        '
        'LBLMONTO
        '
        Me.LBLMONTO.AutoSize = True
        Me.LBLMONTO.Location = New System.Drawing.Point(348, 201)
        Me.LBLMONTO.Name = "LBLMONTO"
        Me.LBLMONTO.Size = New System.Drawing.Size(17, 18)
        Me.LBLMONTO.TabIndex = 51
        Me.LBLMONTO.Text = "0"
        '
        'PROMOCIONINSCRIPCIONBindingSource
        '
        Me.PROMOCIONINSCRIPCIONBindingSource.DataMember = "PROMOCIONINSCRIPCION"
        Me.PROMOCIONINSCRIPCIONBindingSource.DataSource = Me.SACDataSet
        '
        'PROMOCIONINSCRIPCIONTableAdapter
        '
        Me.PROMOCIONINSCRIPCIONTableAdapter.ClearBeforeFill = True
        '
        'LBLIDPRODUC
        '
        Me.LBLIDPRODUC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARMONTOCOLEGPORNIVELBindingSource, "idproduc", True))
        Me.LBLIDPRODUC.Location = New System.Drawing.Point(445, 289)
        Me.LBLIDPRODUC.Name = "LBLIDPRODUC"
        Me.LBLIDPRODUC.Size = New System.Drawing.Size(100, 23)
        Me.LBLIDPRODUC.TabIndex = 53
        Me.LBLIDPRODUC.Text = "IDPRODUC"
        '
        'LBLDESCRIPCION
        '
        Me.LBLDESCRIPCION.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMOCIONINSCRIPCIONBindingSource, "descripcion", True))
        Me.LBLDESCRIPCION.Location = New System.Drawing.Point(445, 266)
        Me.LBLDESCRIPCION.Name = "LBLDESCRIPCION"
        Me.LBLDESCRIPCION.Size = New System.Drawing.Size(100, 23)
        Me.LBLDESCRIPCION.TabIndex = 55
        Me.LBLDESCRIPCION.Text = "DESCRIPCION"
        Me.LBLDESCRIPCION.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLPORCENTAJE
        '
        Me.LBLPORCENTAJE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMOCIONINSCRIPCIONBindingSource, "porcedescuento", True))
        Me.LBLPORCENTAJE.Location = New System.Drawing.Point(445, 243)
        Me.LBLPORCENTAJE.Name = "LBLPORCENTAJE"
        Me.LBLPORCENTAJE.Size = New System.Drawing.Size(100, 23)
        Me.LBLPORCENTAJE.TabIndex = 57
        Me.LBLPORCENTAJE.Text = "DESC"
        '
        'Button13
        '
        Me.Button13.BackgroundImage = Global.SAC.My.Resources.Resources.ok
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button13.Enabled = False
        Me.Button13.Location = New System.Drawing.Point(598, 64)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(26, 23)
        Me.Button13.TabIndex = 63
        Me.Button13.UseVisualStyleBackColor = True
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
        'LBLNOFOLIO
        '
        Me.LBLNOFOLIO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NUEVORECIBOFOLIOFACTURABindingSource, "NOFOLIO", True))
        Me.LBLNOFOLIO.Location = New System.Drawing.Point(104, 268)
        Me.LBLNOFOLIO.Name = "LBLNOFOLIO"
        Me.LBLNOFOLIO.Size = New System.Drawing.Size(100, 23)
        Me.LBLNOFOLIO.TabIndex = 64
        Me.LBLNOFOLIO.Text = "NOFOLIO"
        '
        'LBLNVOFOLIO
        '
        Me.LBLNVOFOLIO.AutoSize = True
        Me.LBLNVOFOLIO.Location = New System.Drawing.Point(103, 294)
        Me.LBLNVOFOLIO.Name = "LBLNVOFOLIO"
        Me.LBLNVOFOLIO.Size = New System.Drawing.Size(88, 18)
        Me.LBLNVOFOLIO.TabIndex = 65
        Me.LBLNVOFOLIO.Text = "NVOFOLIO"
        '
        'CBOPROMOCION
        '
        Me.CBOPROMOCION.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBOPROMOCION.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBOPROMOCION.DataSource = Me.PROMOCIONINSCRIPCIONBindingSource
        Me.CBOPROMOCION.DisplayMember = "descripcion"
        Me.CBOPROMOCION.FormattingEnabled = True
        Me.CBOPROMOCION.Location = New System.Drawing.Point(27, 12)
        Me.CBOPROMOCION.Name = "CBOPROMOCION"
        Me.CBOPROMOCION.Size = New System.Drawing.Size(566, 26)
        Me.CBOPROMOCION.TabIndex = 67
        Me.CBOPROMOCION.ValueMember = "porcedescuento"
        '
        'LBLFECHAINI
        '
        Me.LBLFECHAINI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMOCIONINSCRIPCIONBindingSource, "fechinicio", True))
        Me.LBLFECHAINI.Location = New System.Drawing.Point(8, 243)
        Me.LBLFECHAINI.Name = "LBLFECHAINI"
        Me.LBLFECHAINI.Size = New System.Drawing.Size(100, 23)
        Me.LBLFECHAINI.TabIndex = 68
        Me.LBLFECHAINI.Text = "FECHAINI"
        '
        'LBLFECHAFIN
        '
        Me.LBLFECHAFIN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMOCIONINSCRIPCIONBindingSource, "fechafin", True))
        Me.LBLFECHAFIN.Location = New System.Drawing.Point(524, 243)
        Me.LBLFECHAFIN.Name = "LBLFECHAFIN"
        Me.LBLFECHAFIN.Size = New System.Drawing.Size(100, 23)
        Me.LBLFECHAFIN.TabIndex = 69
        Me.LBLFECHAFIN.Text = "FECHAFIN"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.SAC.My.Resources.Resources.ok
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(599, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 23)
        Me.Button1.TabIndex = 70
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LBLCONCEPTO
        '
        Me.LBLCONCEPTO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMOCIONINSCRIPCIONBindingSource, "concep", True))
        Me.LBLCONCEPTO.Location = New System.Drawing.Point(197, 303)
        Me.LBLCONCEPTO.Name = "LBLCONCEPTO"
        Me.LBLCONCEPTO.Size = New System.Drawing.Size(100, 23)
        Me.LBLCONCEPTO.TabIndex = 71
        Me.LBLCONCEPTO.Text = "CONVEP"
        '
        'LBLIDCOLEG
        '
        Me.LBLIDCOLEG.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMOCIONINSCRIPCIONBindingSource, "idmensualidad", True))
        Me.LBLIDCOLEG.Location = New System.Drawing.Point(315, 303)
        Me.LBLIDCOLEG.Name = "LBLIDCOLEG"
        Me.LBLIDCOLEG.Size = New System.Drawing.Size(100, 23)
        Me.LBLIDCOLEG.TabIndex = 72
        Me.LBLIDCOLEG.Text = "IDCOLEG"
        '
        'SELECCIONARMONTOCOLEGIATURAPORNIVELBindingSource
        '
        Me.SELECCIONARMONTOCOLEGIATURAPORNIVELBindingSource.DataMember = "SELECCIONARMONTOCOLEGIATURAPORNIVEL"
        Me.SELECCIONARMONTOCOLEGIATURAPORNIVELBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARMONTOCOLEGIATURAPORNIVELTableAdapter
        '
        Me.SELECCIONARMONTOCOLEGIATURAPORNIVELTableAdapter.ClearBeforeFill = True
        '
        'LBLMONTOCOLEG
        '
        Me.LBLMONTOCOLEG.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARMONTOCOLEGIATURAPORNIVELBindingSource, "monto", True))
        Me.LBLMONTOCOLEG.Location = New System.Drawing.Point(8, 266)
        Me.LBLMONTOCOLEG.Name = "LBLMONTOCOLEG"
        Me.LBLMONTOCOLEG.Size = New System.Drawing.Size(100, 23)
        Me.LBLMONTOCOLEG.TabIndex = 74
        Me.LBLMONTOCOLEG.Text = "MONTOCOLEG"
        '
        'INSCRIPCIONCNPROMOCION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 346)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBLMONTOCOLEG)
        Me.Controls.Add(Me.LBLIDCOLEG)
        Me.Controls.Add(Me.LBLCONCEPTO)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LBLFECHAFIN)
        Me.Controls.Add(Me.LBLFECHAINI)
        Me.Controls.Add(Me.CBOPROMOCION)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.LBLNVOFOLIO)
        Me.Controls.Add(Me.LBLNOFOLIO)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.LBLIDPRODUC)
        Me.Controls.Add(Me.LBLDESCRIPCION)
        Me.Controls.Add(Me.LBLPORCENTAJE)
        Me.Controls.Add(Me.LBLMONTO)
        Me.Controls.Add(Me.LBLMONTOCOLE)
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.CMDIMPRIMIR)
        Me.Controls.Add(MatriLabel)
        Me.Controls.Add(Me.MatriLabel1)
        Me.Controls.Add(GradoLabel)
        Me.Controls.Add(Me.GradoLabel1)
        Me.Controls.Add(EscolaridadLabel)
        Me.Controls.Add(Me.EscolaridadLabel1)
        Me.Controls.Add(GrupoLabel)
        Me.Controls.Add(Me.GrupoLabel1)
        Me.Controls.Add(Me.CBOALUMNOS)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "INSCRIPCIONCNPROMOCION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INSCRIPCION CON PROMOCION"
        CType(Me.SELECCIONARTODOSALUMNOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARMONTOCOLEGPORNIVELBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROMOCIONINSCRIPCIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUEVORECIBOFOLIOFACTURABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARMONTOCOLEGIATURAPORNIVELBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBOALUMNOS As System.Windows.Forms.ComboBox
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents SELECCIONARTODOSALUMNOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARTODOSALUMNOSTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARTODOSALUMNOSTableAdapter
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MatriLabel1 As System.Windows.Forms.Label
    Friend WithEvents GradoLabel1 As System.Windows.Forms.Label
    Friend WithEvents EscolaridadLabel1 As System.Windows.Forms.Label
    Friend WithEvents GrupoLabel1 As System.Windows.Forms.Label
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents CMDIMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents SELECCIONARMONTOCOLEGPORNIVELBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARMONTOCOLEGPORNIVELTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARMONTOCOLEGPORNIVELTableAdapter
    Friend WithEvents LBLMONTOCOLE As System.Windows.Forms.Label
    Friend WithEvents LBLMONTO As System.Windows.Forms.Label
    Friend WithEvents PROMOCIONINSCRIPCIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROMOCIONINSCRIPCIONTableAdapter As SAC.SACDataSetTableAdapters.PROMOCIONINSCRIPCIONTableAdapter
    Friend WithEvents LBLIDPRODUC As System.Windows.Forms.Label
    Friend WithEvents LBLDESCRIPCION As System.Windows.Forms.Label
    Friend WithEvents LBLPORCENTAJE As System.Windows.Forms.Label
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents NUEVORECIBOFOLIOFACTURABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NUEVORECIBOFOLIOFACTURATableAdapter As SAC.SACDataSetTableAdapters.NUEVORECIBOFOLIOFACTURATableAdapter
    Friend WithEvents LBLNOFOLIO As System.Windows.Forms.Label
    Friend WithEvents LBLNVOFOLIO As System.Windows.Forms.Label
    Friend WithEvents CBOPROMOCION As System.Windows.Forms.ComboBox
    Friend WithEvents LBLFECHAINI As System.Windows.Forms.Label
    Friend WithEvents LBLFECHAFIN As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LBLCONCEPTO As System.Windows.Forms.Label
    Friend WithEvents LBLIDCOLEG As System.Windows.Forms.Label
    Friend WithEvents SELECCIONARMONTOCOLEGIATURAPORNIVELBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARMONTOCOLEGIATURAPORNIVELTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARMONTOCOLEGIATURAPORNIVELTableAdapter
    Friend WithEvents LBLMONTOCOLEG As System.Windows.Forms.Label
End Class
