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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Colegiaturas")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Inscripcion")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Articulos")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Adeudos Articulos")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Adeudos Colegiaturas/Inscripcion")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Adeudos", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PADRE))
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Modificar Alumno")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Modificar Tutor")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pagos Alumnos")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Detalle Tutores")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Detalle Alumnos")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pedido Uniformes")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reimpresion Folio o Recibo")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Corte Diario por Fecha")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Actividad de Usuario")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Clientes Piden Factura")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pedidos de Uniformes")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Becas Asignadas")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Costos de Productos")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Creacion Reportes", New System.Windows.Forms.TreeNode() {TreeNode14, TreeNode15, TreeNode16, TreeNode17, TreeNode18, TreeNode19})
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Adeudo Alumnos")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("General", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8, TreeNode9, TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode20, TreeNode21})
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Asignar Becas")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Eliminar Movimientos")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Modificar Productos")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Crear Producto")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Edicion Usuarios")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Modificar Pagos")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Modificar Facturas")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reporte Facturas")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Crear Nuevo Ciclo")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Administrativo", New System.Windows.Forms.TreeNode() {TreeNode23, TreeNode24, TreeNode25, TreeNode26, TreeNode27, TreeNode28, TreeNode29, TreeNode30, TreeNode31})
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Corte Diario")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Lista Alumnos")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Lista Cumpleaños")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Lista Asistencia")
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Lista Correos")
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reportes Academicos", New System.Windows.Forms.TreeNode() {TreeNode34, TreeNode35, TreeNode36, TreeNode37})
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TSRELOJ = New System.Windows.Forms.ToolStripLabel()
        Me.TSFECHA = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel8 = New System.Windows.Forms.ToolStripLabel()
        Me.TSCICLOESCOLAR = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.tsImpresoraTi = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.tsImpresora = New System.Windows.Forms.ToolStripLabel()
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
        Me.TSBCORTEDIARIO = New System.Windows.Forms.ToolStripButton()
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
        Me.tlsCobros = New System.Windows.Forms.ToolStripButton()
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
        Me.tvCobros = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tvAdministrativo = New System.Windows.Forms.TreeView()
        Me.tvAcademico = New System.Windows.Forms.TreeView()
        Me.msPrincipal = New System.Windows.Forms.MenuStrip()
        Me.AbrirSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegresarCorteDiarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Impresora = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ticket = New System.Windows.Forms.ToolStripMenuItem()
        Me.TValidarCierre = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.TSVARIOS.SuspendLayout()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECIONARFECHASERVIDORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARCICLOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TSMENUACADEMICO.SuspendLayout()
        Me.msPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.TSRELOJ, Me.TSFECHA, Me.ToolStripLabel8, Me.TSCICLOESCOLAR, Me.ToolStripLabel7, Me.ToolStripSeparator5, Me.ToolStripSeparator6, Me.ToolStripSeparator9, Me.ToolStripSeparator11, Me.ToolStripSeparator10, Me.ToolStripLabel3, Me.tsImpresoraTi, Me.ToolStripSeparator2, Me.ToolStripLabel4, Me.tsImpresora})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 708)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1012, 25)
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
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(102, 22)
        Me.ToolStripLabel3.Text = "Impresora Tickets:"
        '
        'tsImpresoraTi
        '
        Me.tsImpresoraTi.Name = "tsImpresoraTi"
        Me.tsImpresoraTi.Size = New System.Drawing.Size(87, 22)
        Me.tsImpresoraTi.Text = "ToolStripLabel4"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(63, 15)
        Me.ToolStripLabel4.Text = "Impresora:"
        '
        'tsImpresora
        '
        Me.tsImpresora.Name = "tsImpresora"
        Me.tsImpresora.Size = New System.Drawing.Size(87, 15)
        Me.tsImpresora.Text = "ToolStripLabel5"
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
        Me.TSVARIOS.Location = New System.Drawing.Point(875, 24)
        Me.TSVARIOS.Name = "TSVARIOS"
        Me.TSVARIOS.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.TSVARIOS.Size = New System.Drawing.Size(137, 684)
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
        Me.ToolStripLabel6.Visible = False
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
        Me.TSBCOBROS.Visible = False
        '
        'TSBADEUDOSARTICULOS
        '
        Me.TSBADEUDOSARTICULOS.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSBADEUDOSARTICULOS.Image = Global.SAC.My.Resources.Resources.EMPEÑO
        Me.TSBADEUDOSARTICULOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TSBADEUDOSARTICULOS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBADEUDOSARTICULOS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBADEUDOSARTICULOS.Name = "TSBADEUDOSARTICULOS"
        Me.TSBADEUDOSARTICULOS.Size = New System.Drawing.Size(134, 54)
        Me.TSBADEUDOSARTICULOS.Text = "ADEUDOS"
        Me.TSBADEUDOSARTICULOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TSBADEUDOSARTICULOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TSBADEUDOSARTICULOS.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(134, 6)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(134, 23)
        Me.ToolStripLabel2.Text = "OTROS"
        '
        'TSPROMOCIONES
        '
        Me.TSPROMOCIONES.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSPROMOCIONES.Image = Global.SAC.My.Resources.Resources.DARBAJA
        Me.TSPROMOCIONES.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSPROMOCIONES.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSPROMOCIONES.Name = "TSPROMOCIONES"
        Me.TSPROMOCIONES.Size = New System.Drawing.Size(134, 54)
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
        Me.TSCAMBIARCICLO.Size = New System.Drawing.Size(134, 54)
        Me.TSCAMBIARCICLO.Text = "CAMBIAR CICLO"
        Me.TSCAMBIARCICLO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TSBCORTEDIARIO
        '
        Me.TSBCORTEDIARIO.Image = Global.SAC.My.Resources.Resources.SIMULADOR
        Me.TSBCORTEDIARIO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBCORTEDIARIO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBCORTEDIARIO.Name = "TSBCORTEDIARIO"
        Me.TSBCORTEDIARIO.Size = New System.Drawing.Size(134, 54)
        Me.TSBCORTEDIARIO.Text = "CORTE DIARIO"
        Me.TSBCORTEDIARIO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TSBCORTEDIARIO.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(134, 6)
        '
        'TSBSOPORTE
        '
        Me.TSBSOPORTE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSBSOPORTE.Image = Global.SAC.My.Resources.Resources.SOPORTE
        Me.TSBSOPORTE.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TSBSOPORTE.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBSOPORTE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBSOPORTE.Name = "TSBSOPORTE"
        Me.TSBSOPORTE.Size = New System.Drawing.Size(134, 54)
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
        Me.TBSSALIR.Size = New System.Drawing.Size(134, 54)
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
        Me.TSMENUACADEMICO.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSLALUMNOS, Me.TSNUEVOINGRESO, Me.TSREINSCRIPCION, Me.ToolStripSeparator7, Me.TSLCOBROS, Me.tlsCobros, Me.TSCOLEGIATURAS, Me.TSINSCRIPCION, Me.TSADEUDOS, Me.ToolStripSeparator4, Me.TSLACADEMICOS, Me.TSREPORTESACADEMICOS, Me.ToolStripSeparator8, Me.TSLADMINISTRATIVO, Me.TSADMINISTRATIVO, Me.TSSOPORTE, Me.TSSALIR})
        Me.TSMENUACADEMICO.Location = New System.Drawing.Point(0, 24)
        Me.TSMENUACADEMICO.Name = "TSMENUACADEMICO"
        Me.TSMENUACADEMICO.Size = New System.Drawing.Size(164, 684)
        Me.TSMENUACADEMICO.TabIndex = 14
        Me.TSMENUACADEMICO.Text = "ToolStrip3"
        '
        'TSLALUMNOS
        '
        Me.TSLALUMNOS.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSLALUMNOS.Name = "TSLALUMNOS"
        Me.TSLALUMNOS.Size = New System.Drawing.Size(161, 23)
        Me.TSLALUMNOS.Text = "ALUMNOS"
        '
        'TSNUEVOINGRESO
        '
        Me.TSNUEVOINGRESO.Image = Global.SAC.My.Resources.Resources.ALUMNONUEVO
        Me.TSNUEVOINGRESO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSNUEVOINGRESO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSNUEVOINGRESO.Name = "TSNUEVOINGRESO"
        Me.TSNUEVOINGRESO.Size = New System.Drawing.Size(161, 54)
        Me.TSNUEVOINGRESO.Text = "NUEVO INGRESO"
        Me.TSNUEVOINGRESO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TSNUEVOINGRESO.ToolTipText = "ESTE APARTADO SE UTILIZA APRA REGISTRAR UN ALUMNO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "QUE NO HAYA ESTADO INSCRIO EN " &
    "EL COLEGIO."
        '
        'TSREINSCRIPCION
        '
        Me.TSREINSCRIPCION.Image = Global.SAC.My.Resources.Resources.Deleket_Soft_Scraps_User_Group
        Me.TSREINSCRIPCION.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSREINSCRIPCION.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSREINSCRIPCION.Name = "TSREINSCRIPCION"
        Me.TSREINSCRIPCION.Size = New System.Drawing.Size(161, 54)
        Me.TSREINSCRIPCION.Text = "REINSCRIPCION"
        Me.TSREINSCRIPCION.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TSREINSCRIPCION.ToolTipText = "ESTE APARADO SE UTILIZA PARA REINSCRIBIR UN ALUMNO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PARA ELLO EL ALUNO DEBIO ESTA" &
    "R INSCRITO EN CICLOS PASADOS."
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(161, 6)
        '
        'TSLCOBROS
        '
        Me.TSLCOBROS.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSLCOBROS.Name = "TSLCOBROS"
        Me.TSLCOBROS.Size = New System.Drawing.Size(161, 23)
        Me.TSLCOBROS.Text = "COBROS"
        '
        'tlsCobros
        '
        Me.tlsCobros.Image = Global.SAC.My.Resources.Resources.Aha_Soft_Business_Toolbar_Payment
        Me.tlsCobros.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tlsCobros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tlsCobros.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsCobros.Name = "tlsCobros"
        Me.tlsCobros.Size = New System.Drawing.Size(161, 54)
        Me.tlsCobros.Text = "COBROS"
        Me.tlsCobros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TSCOLEGIATURAS
        '
        Me.TSCOLEGIATURAS.Image = Global.SAC.My.Resources.Resources.Aha_Soft_Business_Toolbar_Payment
        Me.TSCOLEGIATURAS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSCOLEGIATURAS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSCOLEGIATURAS.Name = "TSCOLEGIATURAS"
        Me.TSCOLEGIATURAS.Size = New System.Drawing.Size(161, 54)
        Me.TSCOLEGIATURAS.Text = "COLEGIATURAS"
        Me.TSCOLEGIATURAS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TSCOLEGIATURAS.ToolTipText = "EN ESTE APARTADO SE COBRAN SOLAMENTE LAS " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "COLEGIATURAS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TSCOLEGIATURAS.Visible = False
        '
        'TSINSCRIPCION
        '
        Me.TSINSCRIPCION.Image = Global.SAC.My.Resources.Resources.Aha_Soft_Business_Toolbar_Payment
        Me.TSINSCRIPCION.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TSINSCRIPCION.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSINSCRIPCION.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSINSCRIPCION.Name = "TSINSCRIPCION"
        Me.TSINSCRIPCION.Size = New System.Drawing.Size(161, 54)
        Me.TSINSCRIPCION.Text = "INSCRIPCION"
        Me.TSINSCRIPCION.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TSINSCRIPCION.ToolTipText = "EN ESTE APARTADO SE COBRA LA INSCRIPCION SOLAMENTE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TSINSCRIPCION.Visible = False
        '
        'TSADEUDOS
        '
        Me.TSADEUDOS.Image = Global.SAC.My.Resources.Resources.Aha_Soft_Business_Toolbar_Payment
        Me.TSADEUDOS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSADEUDOS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSADEUDOS.Name = "TSADEUDOS"
        Me.TSADEUDOS.Size = New System.Drawing.Size(161, 54)
        Me.TSADEUDOS.Text = "ADEUDOS"
        Me.TSADEUDOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TSADEUDOS.ToolTipText = "EN ESTE APARTADO SE COBRAN LOS ADEDUSO QUE TIENE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "EL ALUMNO EN CUANTO A COLEGIATU" &
    "RAS O INSCRIPCION."
        Me.TSADEUDOS.Visible = False
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(161, 6)
        '
        'TSLACADEMICOS
        '
        Me.TSLACADEMICOS.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSLACADEMICOS.Name = "TSLACADEMICOS"
        Me.TSLACADEMICOS.Size = New System.Drawing.Size(161, 23)
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
        Me.TSREPORTESACADEMICOS.Size = New System.Drawing.Size(161, 54)
        Me.TSREPORTESACADEMICOS.Text = "REPORTES "
        Me.TSREPORTESACADEMICOS.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.TSREPORTESACADEMICOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TSREPORTESACADEMICOS.ToolTipText = "Se Desplegara una ventana para imrimir los reportes academicos que" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "necesita"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(161, 6)
        '
        'TSLADMINISTRATIVO
        '
        Me.TSLADMINISTRATIVO.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSLADMINISTRATIVO.Name = "TSLADMINISTRATIVO"
        Me.TSLADMINISTRATIVO.Size = New System.Drawing.Size(161, 23)
        Me.TSLADMINISTRATIVO.Text = "ADMINISTRATIVO"
        '
        'TSADMINISTRATIVO
        '
        Me.TSADMINISTRATIVO.Image = Global.SAC.My.Resources.Resources.Iconshock_Real_Vista_General_Administrator
        Me.TSADMINISTRATIVO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSADMINISTRATIVO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSADMINISTRATIVO.Name = "TSADMINISTRATIVO"
        Me.TSADMINISTRATIVO.Size = New System.Drawing.Size(161, 54)
        Me.TSADMINISTRATIVO.Text = "ADMINISTRATIVO"
        Me.TSADMINISTRATIVO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TSSOPORTE
        '
        Me.TSSOPORTE.Image = Global.SAC.My.Resources.Resources.SOPORTE
        Me.TSSOPORTE.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSSOPORTE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSSOPORTE.Name = "TSSOPORTE"
        Me.TSSOPORTE.Size = New System.Drawing.Size(161, 54)
        Me.TSSOPORTE.Text = "SOPORTE"
        Me.TSSOPORTE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TSSALIR
        '
        Me.TSSALIR.Image = Global.SAC.My.Resources.Resources.Visualpharm_Must_Have_Log_Out
        Me.TSSALIR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSSALIR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSSALIR.Name = "TSSALIR"
        Me.TSSALIR.Size = New System.Drawing.Size(161, 54)
        Me.TSSALIR.Text = "SALIR"
        Me.TSSALIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SELECCIONARCICLOTableAdapter
        '
        Me.SELECCIONARCICLOTableAdapter.ClearBeforeFill = True
        '
        'tvCobros
        '
        Me.tvCobros.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvCobros.ImageKey = "EMPEÑO.ico"
        Me.tvCobros.ImageList = Me.ImageList1
        Me.tvCobros.Location = New System.Drawing.Point(182, 179)
        Me.tvCobros.Name = "tvCobros"
        TreeNode1.Name = "NTodos"
        TreeNode1.Text = "Colegiaturas"
        TreeNode2.Name = "NUsuarios"
        TreeNode2.Text = "Inscripcion"
        TreeNode3.Name = "NAdministrador"
        TreeNode3.Text = "Articulos"
        TreeNode4.Name = "Nodo1"
        TreeNode4.Text = "Adeudos Articulos"
        TreeNode5.Name = "Nodo2"
        TreeNode5.Text = "Adeudos Colegiaturas/Inscripcion"
        TreeNode6.Name = "Nodo0"
        TreeNode6.Text = "Adeudos"
        Me.tvCobros.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode6})
        Me.tvCobros.SelectedImageIndex = 0
        Me.tvCobros.Size = New System.Drawing.Size(442, 129)
        Me.tvCobros.TabIndex = 16
        Me.tvCobros.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Iconshock-Real-Vista-General-Administrator.ico")
        Me.ImageList1.Images.SetKeyName(1, "PRINTER.ico")
        Me.ImageList1.Images.SetKeyName(2, "REPORTE.ico")
        Me.ImageList1.Images.SetKeyName(3, "EMPEÑO.ico")
        Me.ImageList1.Images.SetKeyName(4, "Custom-Icon-Design-Pretty-Office-3-Product-sales-report.ico")
        '
        'tvAdministrativo
        '
        Me.tvAdministrativo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvAdministrativo.ImageKey = "Iconshock-Real-Vista-General-Administrator.ico"
        Me.tvAdministrativo.ImageList = Me.ImageList1
        Me.tvAdministrativo.Location = New System.Drawing.Point(182, 314)
        Me.tvAdministrativo.Name = "tvAdministrativo"
        TreeNode7.Name = "Nodo3"
        TreeNode7.NodeFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode7.Text = "Modificar Alumno"
        TreeNode8.Name = "Nodo0"
        TreeNode8.Text = "Modificar Tutor"
        TreeNode9.Name = "Nodo1"
        TreeNode9.Text = "Pagos Alumnos"
        TreeNode10.Name = "Nodo2"
        TreeNode10.Text = "Detalle Tutores"
        TreeNode11.Name = "Nodo3"
        TreeNode11.Text = "Detalle Alumnos"
        TreeNode12.Name = "Nodo4"
        TreeNode12.Text = "Pedido Uniformes"
        TreeNode13.Name = "Nodo5"
        TreeNode13.Text = "Reimpresion Folio o Recibo"
        TreeNode14.ImageIndex = 1
        TreeNode14.Name = "Nodo1"
        TreeNode14.Text = "Corte Diario por Fecha"
        TreeNode15.ImageIndex = 1
        TreeNode15.Name = "Nodo2"
        TreeNode15.Text = "Actividad de Usuario"
        TreeNode16.ImageIndex = 1
        TreeNode16.Name = "Nodo3"
        TreeNode16.Text = "Clientes Piden Factura"
        TreeNode17.ImageIndex = 1
        TreeNode17.Name = "Nodo4"
        TreeNode17.Text = "Pedidos de Uniformes"
        TreeNode18.ImageIndex = 1
        TreeNode18.Name = "Nodo5"
        TreeNode18.Text = "Becas Asignadas"
        TreeNode19.ImageIndex = 1
        TreeNode19.Name = "Nodo6"
        TreeNode19.Text = "Costos de Productos"
        TreeNode20.ImageIndex = 1
        TreeNode20.Name = "Nodo21"
        TreeNode20.Text = "Creacion Reportes"
        TreeNode21.Name = "Nodo22"
        TreeNode21.Text = "Adeudo Alumnos"
        TreeNode22.Name = "NTodos"
        TreeNode22.Text = "General"
        TreeNode23.Name = "Nodo13"
        TreeNode23.Text = "Asignar Becas"
        TreeNode24.Name = "Nodo14"
        TreeNode24.Text = "Eliminar Movimientos"
        TreeNode25.Name = "Nodo15"
        TreeNode25.Text = "Modificar Productos"
        TreeNode26.Name = "Nodo16"
        TreeNode26.Text = "Crear Producto"
        TreeNode27.Name = "Nodo17"
        TreeNode27.Text = "Edicion Usuarios"
        TreeNode28.Name = "Nodo18"
        TreeNode28.Text = "Modificar Pagos"
        TreeNode29.Name = "Nodo19"
        TreeNode29.Text = "Modificar Facturas"
        TreeNode30.Name = "Nodo20"
        TreeNode30.Text = "Reporte Facturas"
        TreeNode31.Name = "Nodo23"
        TreeNode31.Text = "Crear Nuevo Ciclo"
        TreeNode32.Name = "NUsuarios"
        TreeNode32.Text = "Administrativo"
        TreeNode33.ImageIndex = 2
        TreeNode33.Name = "NAdministrador"
        TreeNode33.Text = "Corte Diario"
        Me.tvAdministrativo.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode22, TreeNode32, TreeNode33})
        Me.tvAdministrativo.SelectedImageIndex = 0
        Me.tvAdministrativo.Size = New System.Drawing.Size(442, 129)
        Me.tvAdministrativo.TabIndex = 17
        Me.tvAdministrativo.Visible = False
        '
        'tvAcademico
        '
        Me.tvAcademico.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvAcademico.ImageKey = "Custom-Icon-Design-Pretty-Office-3-Product-sales-report.ico"
        Me.tvAcademico.ImageList = Me.ImageList1
        Me.tvAcademico.Location = New System.Drawing.Point(182, 44)
        Me.tvAcademico.Name = "tvAcademico"
        TreeNode34.Name = "Nodo3"
        TreeNode34.Text = "Lista Alumnos"
        TreeNode35.Name = "Nodo0"
        TreeNode35.Text = "Lista Cumpleaños"
        TreeNode36.Name = "Nodo1"
        TreeNode36.Text = "Lista Asistencia"
        TreeNode37.Name = "Nodo2"
        TreeNode37.Text = "Lista Correos"
        TreeNode38.Name = "NTodos"
        TreeNode38.Text = "Reportes Academicos"
        Me.tvAcademico.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode38})
        Me.tvAcademico.SelectedImageIndex = 0
        Me.tvAcademico.Size = New System.Drawing.Size(442, 129)
        Me.tvAcademico.TabIndex = 18
        Me.tvAcademico.Visible = False
        '
        'msPrincipal
        '
        Me.msPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirSesionToolStripMenuItem, Me.CerrarSesionToolStripMenuItem, Me.ConfiguracionSistemaToolStripMenuItem})
        Me.msPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.msPrincipal.Name = "msPrincipal"
        Me.msPrincipal.Size = New System.Drawing.Size(1012, 24)
        Me.msPrincipal.TabIndex = 20
        Me.msPrincipal.Text = "MenuStrip1"
        '
        'AbrirSesionToolStripMenuItem
        '
        Me.AbrirSesionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.AbrirSesionToolStripMenuItem.Name = "AbrirSesionToolStripMenuItem"
        Me.AbrirSesionToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.AbrirSesionToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegresarCorteDiarioToolStripMenuItem})
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.CerrarSesionToolStripMenuItem.Text = "Opciones"
        '
        'RegresarCorteDiarioToolStripMenuItem
        '
        Me.RegresarCorteDiarioToolStripMenuItem.Name = "RegresarCorteDiarioToolStripMenuItem"
        Me.RegresarCorteDiarioToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.RegresarCorteDiarioToolStripMenuItem.Text = "Regresar Corte Diario"
        '
        'ConfiguracionSistemaToolStripMenuItem
        '
        Me.ConfiguracionSistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Impresora, Me.Ticket})
        Me.ConfiguracionSistemaToolStripMenuItem.Name = "ConfiguracionSistemaToolStripMenuItem"
        Me.ConfiguracionSistemaToolStripMenuItem.Size = New System.Drawing.Size(139, 20)
        Me.ConfiguracionSistemaToolStripMenuItem.Text = "Configuracion Sistema"
        '
        'Impresora
        '
        Me.Impresora.Name = "Impresora"
        Me.Impresora.Size = New System.Drawing.Size(204, 22)
        Me.Impresora.Text = "Definir Impresora"
        '
        'Ticket
        '
        Me.Ticket.Name = "Ticket"
        Me.Ticket.Size = New System.Drawing.Size(204, 22)
        Me.Ticket.Text = "Definir Impresora Tickets"
        '
        'TValidarCierre
        '
        Me.TValidarCierre.Enabled = True
        Me.TValidarCierre.Interval = 7000
        '
        'PADRE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 733)
        Me.ControlBox = False
        Me.Controls.Add(Me.tvAcademico)
        Me.Controls.Add(Me.tvAdministrativo)
        Me.Controls.Add(Me.tvCobros)
        Me.Controls.Add(Me.TSMENUACADEMICO)
        Me.Controls.Add(Me.LBLCICLO)
        Me.Controls.Add(Me.LBLIDCICLO)
        Me.Controls.Add(Me.FECHASERLabel1)
        Me.Controls.Add(Me.TSVARIOS)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.msPrincipal)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.msPrincipal
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PADRE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ": : : : COLEGIO DUMONT Versión 21.6.23 : : : :"
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
        Me.msPrincipal.ResumeLayout(False)
        Me.msPrincipal.PerformLayout()
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
    Friend WithEvents tvCobros As System.Windows.Forms.TreeView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents tvAdministrativo As System.Windows.Forms.TreeView
    Friend WithEvents tvAcademico As System.Windows.Forms.TreeView
    Friend WithEvents tlsCobros As System.Windows.Forms.ToolStripButton
    Friend WithEvents msPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents AbrirSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionSistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ticket As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Impresora As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsImpresoraTi As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsImpresora As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TValidarCierre As System.Windows.Forms.Timer
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegresarCorteDiarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
End Class
