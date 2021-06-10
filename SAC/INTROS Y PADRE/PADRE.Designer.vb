<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PADRE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PADRE))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TSRELOJ = New System.Windows.Forms.ToolStripLabel()
        Me.TSFECHA = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel8 = New System.Windows.Forms.ToolStripLabel()
        Me.TSCICLOESCOLAR = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TSVARIOS = New System.Windows.Forms.ToolStrip()
        Me.TSBINVENTARIOS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBCOBROS = New System.Windows.Forms.ToolStripButton()
        Me.TSBADEUDOSARTICULOS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.TSPROMOCIONES = New System.Windows.Forms.ToolStripButton()
        Me.TSCAMBIARCICLO = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSBSOPORTE = New System.Windows.Forms.ToolStripButton()
        Me.TBSSALIR = New System.Windows.Forms.ToolStripButton()
        Me.TINABILITAR2 = New System.Windows.Forms.Timer(Me.components)
        Me.TINABILITAR = New System.Windows.Forms.Timer(Me.components)
        Me.SACDataSet = New SAC.SACDataSet()
        Me.SELECIONARFECHASERVIDORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECIONARFECHASERVIDORTableAdapter = New SAC.SACDataSetTableAdapters.SELECIONARFECHASERVIDORTableAdapter()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.FECHASERLabel1 = New System.Windows.Forms.Label()
        Me.LBLIDCICLO = New System.Windows.Forms.Label()
        Me.SELECCIONARCICLOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LBLCICLO = New System.Windows.Forms.Label()
        Me.TSMENUACADEMICO = New System.Windows.Forms.ToolStrip()
        Me.TSLALUMNOS = New System.Windows.Forms.ToolStripLabel()
        Me.TSNUEVOINGRESO = New System.Windows.Forms.ToolStripButton()
        Me.TSREINSCRIPCION = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSLCOBROS = New System.Windows.Forms.ToolStripLabel()
        Me.TSCOLEGIATURAS = New System.Windows.Forms.ToolStripButton()
        Me.TSINSCRIPCION = New System.Windows.Forms.ToolStripButton()
        Me.TSADEUDOS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSLACADEMICOS = New System.Windows.Forms.ToolStripLabel()
        Me.TSREPORTESACADEMICOS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSLADMINISTRATIVO = New System.Windows.Forms.ToolStripLabel()
        Me.TSADMINISTRATIVO = New System.Windows.Forms.ToolStripButton()
        Me.TSSOPORTE = New System.Windows.Forms.ToolStripButton()
        Me.TSSALIR = New System.Windows.Forms.ToolStripButton()
        Me.SELECCIONARCICLOTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARCICLOTableAdapter()
        Me.TSBCORTEDIARIO = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.TSVARIOS.SuspendLayout()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECIONARFECHASERVIDORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARCICLOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TSMENUACADEMICO.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.TSRELOJ, Me.TSFECHA, Me.ToolStripLabel8, Me.TSCICLOESCOLAR, Me.ToolStripLabel7})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 713)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1379, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(275, 22)
        Me.ToolStripLabel1.Text = "Sistema Administrativo Colegial"
        '
        'TSRELOJ
        '
        Me.TSRELOJ.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TSRELOJ.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSRELOJ.Name = "TSRELOJ"
        Me.TSRELOJ.Size = New System.Drawing.Size(75, 22)
        Me.TSRELOJ.Text = "00:00:00"
        '
        'TSFECHA
        '
        Me.TSFECHA.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TSFECHA.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFECHA.Name = "TSFECHA"
        Me.TSFECHA.Size = New System.Drawing.Size(129, 22)
        Me.TSFECHA.Text = "ToolStripLabel2"
        '
        'ToolStripLabel8
        '
        Me.ToolStripLabel8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel8.Name = "ToolStripLabel8"
        Me.ToolStripLabel8.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripLabel8.Text = "FECHA:"
        '
        'TSCICLOESCOLAR
        '
        Me.TSCICLOESCOLAR.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TSCICLOESCOLAR.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSCICLOESCOLAR.Name = "TSCICLOESCOLAR"
        Me.TSCICLOESCOLAR.Size = New System.Drawing.Size(138, 22)
        Me.TSCICLOESCOLAR.Text = "ToolStripLabel8"
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(65, 22)
        Me.ToolStripLabel7.Text = "CICLO:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'TSVARIOS
        '
        Me.TSVARIOS.Dock = System.Windows.Forms.DockStyle.Right
        Me.TSVARIOS.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSVARIOS.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TSVARIOS.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TSVARIOS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBINVENTARIOS, Me.ToolStripLabel6, Me.TSBCOBROS, Me.TSBADEUDOSARTICULOS, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.TSPROMOCIONES, Me.TSCAMBIARCICLO, Me.TSBCORTEDIARIO, Me.ToolStripSeparator3, Me.TSBSOPORTE, Me.TBSSALIR})
        Me.TSVARIOS.Location = New System.Drawing.Point(1205, 0)
        Me.TSVARIOS.Name = "TSVARIOS"
        Me.TSVARIOS.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.TSVARIOS.Size = New System.Drawing.Size(174, 713)
        Me.TSVARIOS.Stretch = True
        Me.TSVARIOS.TabIndex = 5
        Me.TSVARIOS.Text = "ToolStrip2"
        '
        'TSBINVENTARIOS
        '
        Me.TSBINVENTARIOS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSBINVENTARIOS.Image = Global.SAC.My.Resources.Resources.INVENTARIO
        Me.TSBINVENTARIOS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBINVENTARIOS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBINVENTARIOS.Name = "TSBINVENTARIOS"
        Me.TSBINVENTARIOS.Size = New System.Drawing.Size(171, 52)
        Me.TSBINVENTARIOS.Text = "INVENTARIOS"
        Me.TSBINVENTARIOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TSBINVENTARIOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TSBINVENTARIOS.Visible = False
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(171, 23)
        Me.ToolStripLabel6.Text = "ARTICULOS"
        '
        'TSBCOBROS
        '
        Me.TSBCOBROS.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSBCOBROS.Image = Global.SAC.My.Resources.Resources.Aha_Soft_Business_Toolbar_Payment
        Me.TSBCOBROS.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TSBCOBROS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBCOBROS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBCOBROS.Name = "TSBCOBROS"
        Me.TSBCOBROS.Size = New System.Drawing.Size(171, 54)
        Me.TSBCOBROS.Text = "COBROS ARTICULOS"
        Me.TSBCOBROS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TSBADEUDOSARTICULOS
        '
        Me.TSBADEUDOSARTICULOS.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSBADEUDOSARTICULOS.Image = Global.SAC.My.Resources.Resources.EMPEÑO
        Me.TSBADEUDOSARTICULOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TSBADEUDOSARTICULOS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBADEUDOSARTICULOS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBADEUDOSARTICULOS.Name = "TSBADEUDOSARTICULOS"
        Me.TSBADEUDOSARTICULOS.Size = New System.Drawing.Size(171, 54)
        Me.TSBADEUDOSARTICULOS.Text = "ADEUDOS"
        Me.TSBADEUDOSARTICULOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TSBADEUDOSARTICULOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(171, 6)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(171, 23)
        Me.ToolStripLabel2.Text = "OTROS"
        '
        'TSPROMOCIONES
        '
        Me.TSPROMOCIONES.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSPROMOCIONES.Image = Global.SAC.My.Resources.Resources.DARBAJA
        Me.TSPROMOCIONES.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSPROMOCIONES.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSPROMOCIONES.Name = "TSPROMOCIONES"
        Me.TSPROMOCIONES.Size = New System.Drawing.Size(171, 54)
        Me.TSPROMOCIONES.Text = "PROMOCIONES"
        Me.TSPROMOCIONES.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TSCAMBIARCICLO
        '
        Me.TSCAMBIARCICLO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSCAMBIARCICLO.Image = Global.SAC.My.Resources.Resources.Aha_Soft_Standard_City_School
        Me.TSCAMBIARCICLO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSCAMBIARCICLO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSCAMBIARCICLO.Name = "TSCAMBIARCICLO"
        Me.TSCAMBIARCICLO.Size = New System.Drawing.Size(171, 54)
        Me.TSCAMBIARCICLO.Text = "CAMBIAR CICLO"
        Me.TSCAMBIARCICLO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(171, 6)
        '
        'TSBSOPORTE
        '
        Me.TSBSOPORTE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSBSOPORTE.Image = Global.SAC.My.Resources.Resources.SOPORTE
        Me.TSBSOPORTE.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TSBSOPORTE.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBSOPORTE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBSOPORTE.Name = "TSBSOPORTE"
        Me.TSBSOPORTE.Size = New System.Drawing.Size(171, 54)
        Me.TSBSOPORTE.Text = "SOPORTE"
        Me.TSBSOPORTE.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TSBSOPORTE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TBSSALIR
        '
        Me.TBSSALIR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBSSALIR.Image = Global.SAC.My.Resources.Resources.Visualpharm_Must_Have_Log_Out
        Me.TBSSALIR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TBSSALIR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBSSALIR.Name = "TBSSALIR"
        Me.TBSSALIR.Size = New System.Drawing.Size(171, 54)
        Me.TBSSALIR.Text = "SALIR"
        Me.TBSSALIR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TBSSALIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TINABILITAR2
        '
        Me.TINABILITAR2.Interval = 3000
        '
        'TINABILITAR
        '
        Me.TINABILITAR.Interval = 10805
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SELECIONARFECHASERVIDORBindingSource
        '
        Me.SELECIONARFECHASERVIDORBindingSource.DataMember = "SELECIONARFECHASERVIDOR"
        Me.SELECIONARFECHASERVIDORBindingSource.DataSource = Me.SACDataSet
        '
        'SELECIONARFECHASERVIDORTableAdapter
        '
        Me.SELECIONARFECHASERVIDORTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FECHASERLabel1
        '
        Me.FECHASERLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECIONARFECHASERVIDORBindingSource, "FECHASER", True))
        Me.FECHASERLabel1.Location = New System.Drawing.Point(1085, 670)
        Me.FECHASERLabel1.Name = "FECHASERLabel1"
        Me.FECHASERLabel1.Size = New System.Drawing.Size(100, 23)
        Me.FECHASERLabel1.TabIndex = 7
        Me.FECHASERLabel1.Text = "Label1"
        '
        'LBLIDCICLO
        '
        Me.LBLIDCICLO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARCICLOBindingSource, "IDCICLO", True))
        Me.LBLIDCICLO.Location = New System.Drawing.Point(1085, 635)
        Me.LBLIDCICLO.Name = "LBLIDCICLO"
        Me.LBLIDCICLO.Size = New System.Drawing.Size(100, 23)
        Me.LBLIDCICLO.TabIndex = 9
        Me.LBLIDCICLO.Text = "Label1"
        '
        'SELECCIONARCICLOBindingSource
        '
        Me.SELECCIONARCICLOBindingSource.DataMember = "SELECCIONARCICLO"
        Me.SELECCIONARCICLOBindingSource.DataSource = Me.SACDataSet
        '
        'LBLCICLO
        '
        Me.LBLCICLO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARCICLOBindingSource, "CICLO", True))
        Me.LBLCICLO.Location = New System.Drawing.Point(1085, 594)
        Me.LBLCICLO.Name = "LBLCICLO"
        Me.LBLCICLO.Size = New System.Drawing.Size(100, 23)
        Me.LBLCICLO.TabIndex = 12
        Me.LBLCICLO.Text = "Label1"
        '
        'TSMENUACADEMICO
        '
        Me.TSMENUACADEMICO.Dock = System.Windows.Forms.DockStyle.Left
        Me.TSMENUACADEMICO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMENUACADEMICO.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSLALUMNOS, Me.TSNUEVOINGRESO, Me.TSREINSCRIPCION, Me.ToolStripSeparator7, Me.TSLCOBROS, Me.TSCOLEGIATURAS, Me.TSINSCRIPCION, Me.TSADEUDOS, Me.ToolStripSeparator4, Me.TSLACADEMICOS, Me.TSREPORTESACADEMICOS, Me.ToolStripSeparator8, Me.TSLADMINISTRATIVO, Me.TSADMINISTRATIVO, Me.TSSOPORTE, Me.TSSALIR})
        Me.TSMENUACADEMICO.Location = New System.Drawing.Point(0, 0)
        Me.TSMENUACADEMICO.Name = "TSMENUACADEMICO"
        Me.TSMENUACADEMICO.Size = New System.Drawing.Size(166, 713)
        Me.TSMENUACADEMICO.TabIndex = 14
        Me.TSMENUACADEMICO.Text = "ToolStrip3"
        '
        'TSLALUMNOS
        '
        Me.TSLALUMNOS.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSLALUMNOS.Name = "TSLALUMNOS"
        Me.TSLALUMNOS.Size = New System.Drawing.Size(163, 23)
        Me.TSLALUMNOS.Text = "ALUMNOS"
        '
        'TSNUEVOINGRESO
        '
        Me.TSNUEVOINGRESO.Image = Global.SAC.My.Resources.Resources.ALUMNONUEVO
        Me.TSNUEVOINGRESO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSNUEVOINGRESO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSNUEVOINGRESO.Name = "TSNUEVOINGRESO"
        Me.TSNUEVOINGRESO.Size = New System.Drawing.Size(163, 54)
        Me.TSNUEVOINGRESO.Text = "NUEVO INGRESO"
        Me.TSNUEVOINGRESO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TSNUEVOINGRESO.ToolTipText = "ESTE APARTADO SE UTILIZA APRA REGISTRAR UN ALUMNO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "QUE NO HAYA ESTADO INSCRIO EN " & _
            "EL COLEGIO."
        '
        'TSREINSCRIPCION
        '
        Me.TSREINSCRIPCION.Image = Global.SAC.My.Resources.Resources.Deleket_Soft_Scraps_User_Group
        Me.TSREINSCRIPCION.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSREINSCRIPCION.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSREINSCRIPCION.Name = "TSREINSCRIPCION"
        Me.TSREINSCRIPCION.Size = New System.Drawing.Size(163, 54)
        Me.TSREINSCRIPCION.Text = "REINSCRIPCION"
        Me.TSREINSCRIPCION.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TSREINSCRIPCION.ToolTipText = "ESTE APARADO SE UTILIZA PARA REINSCRIBIR UN ALUMNO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PARA ELLO EL ALUNO DEBIO ESTA" & _
            "R INSCRITO EN CICLOS PASADOS."
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(163, 6)
        '
        'TSLCOBROS
        '
        Me.TSLCOBROS.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSLCOBROS.Name = "TSLCOBROS"
        Me.TSLCOBROS.Size = New System.Drawing.Size(163, 23)
        Me.TSLCOBROS.Text = "COBROS"
        '
        'TSCOLEGIATURAS
        '
        Me.TSCOLEGIATURAS.Image = Global.SAC.My.Resources.Resources.Aha_Soft_Business_Toolbar_Payment
        Me.TSCOLEGIATURAS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSCOLEGIATURAS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSCOLEGIATURAS.Name = "TSCOLEGIATURAS"
        Me.TSCOLEGIATURAS.Size = New System.Drawing.Size(163, 54)
        Me.TSCOLEGIATURAS.Text = "COLEGIATURAS"
        Me.TSCOLEGIATURAS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TSCOLEGIATURAS.ToolTipText = "EN ESTE APARTADO SE COBRAN SOLAMENTE LAS " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "COLEGIATURAS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TSINSCRIPCION
        '
        Me.TSINSCRIPCION.Image = Global.SAC.My.Resources.Resources.Aha_Soft_Business_Toolbar_Payment
        Me.TSINSCRIPCION.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TSINSCRIPCION.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSINSCRIPCION.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSINSCRIPCION.Name = "TSINSCRIPCION"
        Me.TSINSCRIPCION.Size = New System.Drawing.Size(163, 54)
        Me.TSINSCRIPCION.Text = "INSCRIPCION"
        Me.TSINSCRIPCION.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TSINSCRIPCION.ToolTipText = "EN ESTE APARTADO SE COBRA LA INSCRIPCION SOLAMENTE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TSADEUDOS
        '
        Me.TSADEUDOS.Image = Global.SAC.My.Resources.Resources.Aha_Soft_Business_Toolbar_Payment
        Me.TSADEUDOS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSADEUDOS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSADEUDOS.Name = "TSADEUDOS"
        Me.TSADEUDOS.Size = New System.Drawing.Size(163, 54)
        Me.TSADEUDOS.Text = "ADEUDOS"
        Me.TSADEUDOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TSADEUDOS.ToolTipText = "EN ESTE APARTADO SE COBRAN LOS ADEDUSO QUE TIENE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "EL ALUMNO EN CUANTO A COLEGIATU" & _
            "RAS O INSCRIPCION."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(163, 6)
        '
        'TSLACADEMICOS
        '
        Me.TSLACADEMICOS.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSLACADEMICOS.Name = "TSLACADEMICOS"
        Me.TSLACADEMICOS.Size = New System.Drawing.Size(163, 23)
        Me.TSLACADEMICOS.Text = "ACADEMICO"
        '
        'TSREPORTESACADEMICOS
        '
        Me.TSREPORTESACADEMICOS.AutoToolTip = False
        Me.TSREPORTESACADEMICOS.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSREPORTESACADEMICOS.Image = Global.SAC.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_3_Product_sales_report
        Me.TSREPORTESACADEMICOS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSREPORTESACADEMICOS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSREPORTESACADEMICOS.Name = "TSREPORTESACADEMICOS"
        Me.TSREPORTESACADEMICOS.RightToLeftAutoMirrorImage = True
        Me.TSREPORTESACADEMICOS.Size = New System.Drawing.Size(163, 54)
        Me.TSREPORTESACADEMICOS.Text = "REPORTES "
        Me.TSREPORTESACADEMICOS.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.TSREPORTESACADEMICOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TSREPORTESACADEMICOS.ToolTipText = "Se Desplegara una ventana para imrimir los reportes academicos que" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "necesita"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(163, 6)
        '
        'TSLADMINISTRATIVO
        '
        Me.TSLADMINISTRATIVO.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSLADMINISTRATIVO.Name = "TSLADMINISTRATIVO"
        Me.TSLADMINISTRATIVO.Size = New System.Drawing.Size(163, 23)
        Me.TSLADMINISTRATIVO.Text = "ADMINISTRATIVO"
        '
        'TSADMINISTRATIVO
        '
        Me.TSADMINISTRATIVO.Image = Global.SAC.My.Resources.Resources.Iconshock_Real_Vista_General_Administrator
        Me.TSADMINISTRATIVO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSADMINISTRATIVO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSADMINISTRATIVO.Name = "TSADMINISTRATIVO"
        Me.TSADMINISTRATIVO.Size = New System.Drawing.Size(163, 54)
        Me.TSADMINISTRATIVO.Text = "ADMINISTRATIVO"
        Me.TSADMINISTRATIVO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TSSOPORTE
        '
        Me.TSSOPORTE.Image = Global.SAC.My.Resources.Resources.SOPORTE
        Me.TSSOPORTE.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSSOPORTE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSSOPORTE.Name = "TSSOPORTE"
        Me.TSSOPORTE.Size = New System.Drawing.Size(163, 54)
        Me.TSSOPORTE.Text = "SOPORTE"
        Me.TSSOPORTE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TSSALIR
        '
        Me.TSSALIR.Image = Global.SAC.My.Resources.Resources.Visualpharm_Must_Have_Log_Out
        Me.TSSALIR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSSALIR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSSALIR.Name = "TSSALIR"
        Me.TSSALIR.Size = New System.Drawing.Size(163, 54)
        Me.TSSALIR.Text = "SALIR"
        Me.TSSALIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SELECCIONARCICLOTableAdapter
        '
        Me.SELECCIONARCICLOTableAdapter.ClearBeforeFill = True
        '
        'TSBCORTEDIARIO
        '
        Me.TSBCORTEDIARIO.Image = Global.SAC.My.Resources.Resources.SIMULADOR
        Me.TSBCORTEDIARIO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBCORTEDIARIO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBCORTEDIARIO.Name = "TSBCORTEDIARIO"
        Me.TSBCORTEDIARIO.Size = New System.Drawing.Size(171, 54)
        Me.TSBCORTEDIARIO.Text = "CORTE DIARIO"
        Me.TSBCORTEDIARIO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PADRE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1379, 738)
        Me.ControlBox = False
        Me.Controls.Add(Me.TSMENUACADEMICO)
        Me.Controls.Add(Me.LBLCICLO)
        Me.Controls.Add(Me.LBLIDCICLO)
        Me.Controls.Add(Me.FECHASERLabel1)
        Me.Controls.Add(Me.TSVARIOS)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PADRE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COLEGIO DUMONT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TSVARIOS.ResumeLayout(False)
        Me.TSVARIOS.PerformLayout()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECIONARFECHASERVIDORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARCICLOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TSMENUACADEMICO.ResumeLayout(False)
        Me.TSMENUACADEMICO.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TSRELOJ As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TSFECHA As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TSVARIOS As System.Windows.Forms.ToolStrip
    Friend WithEvents TSBCOBROS As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSBINVENTARIOS As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSBSOPORTE As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBSSALIR As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel6 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TSBADEUDOSARTICULOS As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSPROMOCIONES As System.Windows.Forms.ToolStripButton
    Friend WithEvents TINABILITAR2 As System.Windows.Forms.Timer
    Friend WithEvents TINABILITAR As System.Windows.Forms.Timer
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents SELECIONARFECHASERVIDORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECIONARFECHASERVIDORTableAdapter As SAC.SACDataSetTableAdapters.SELECIONARFECHASERVIDORTableAdapter
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FECHASERLabel1 As System.Windows.Forms.Label
    Friend WithEvents TSCICLOESCOLAR As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel7 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LBLIDCICLO As System.Windows.Forms.Label
    Friend WithEvents LBLCICLO As System.Windows.Forms.Label
    Friend WithEvents ToolStripLabel8 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TSMENUACADEMICO As System.Windows.Forms.ToolStrip
    Friend WithEvents TSLALUMNOS As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TSNUEVOINGRESO As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSREINSCRIPCION As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TSLCOBROS As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TSCOLEGIATURAS As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSINSCRIPCION As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSADEUDOS As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TSLACADEMICOS As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TSREPORTESACADEMICOS As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TSLADMINISTRATIVO As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TSADMINISTRATIVO As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSSOPORTE As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSSALIR As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSCAMBIARCICLO As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents SELECCIONARCICLOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARCICLOTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARCICLOTableAdapter
    Friend WithEvents TSBCORTEDIARIO As System.Windows.Forms.ToolStripButton
End Class
