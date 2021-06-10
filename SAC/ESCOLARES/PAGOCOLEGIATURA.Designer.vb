<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAGOCOLEGIATURA
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
        Me.SACDataSet = New SAC.SACDataSet()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.CBOCOLEGIATURAS = New System.Windows.Forms.ComboBox()
        Me.COBRODECOLEGIATURABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NUEVORECIBOFOLIOFACTURABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NUEVORECIBOFOLIOFACTURATableAdapter = New SAC.SACDataSetTableAdapters.NUEVORECIBOFOLIOFACTURATableAdapter()
        Me.LBLNVOFOLIO = New System.Windows.Forms.Label()
        Me.LBLNOFOLIOMAX = New System.Windows.Forms.Label()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.CMDIMPRIMIR = New System.Windows.Forms.Button()
        Me.CMDLIQUIDAR = New System.Windows.Forms.Button()
        Me.CMDABONO = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LBLABONO = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLRESTA = New System.Windows.Forms.Label()
        Me.LBLMONTOBASE = New System.Windows.Forms.Label()
        Me.CBRECARGO = New System.Windows.Forms.CheckBox()
        Me.LBLIDPRODUC = New System.Windows.Forms.Label()
        Me.LBLPORCENTAJE = New System.Windows.Forms.Label()
        Me.LBLABONORECARG = New System.Windows.Forms.Label()
        Me.LBLLIQUIDADO = New System.Windows.Forms.Label()
        Me.INSCRIPCIONYCOLEGIATURASLIQUIDADASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LBLABONADO = New System.Windows.Forms.Label()
        Me.INSCRIPCIONESOCOLEGIATURASABONADASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button13 = New System.Windows.Forms.Button()
        Me.LBLMONTO = New System.Windows.Forms.Label()
        Me.LBLNOPAGARCOLEADE = New System.Windows.Forms.Label()
        Me.CBOTIPOPAGO = New System.Windows.Forms.ComboBox()
        Me.TIPOSDEPAGOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBLSCOPORBECA = New System.Windows.Forms.Label()
        Me.LBLDESCONBECA = New System.Windows.Forms.Label()
        Me.TIPOSDEPAGOTableAdapter = New SAC.SACDataSetTableAdapters.TIPOSDEPAGOTableAdapter()
        Me.NOPAGARCOLEGIATURASADELANTADASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NOPAGARCOLEGIATURASADELANTADASTableAdapter = New SAC.SACDataSetTableAdapters.NOPAGARCOLEGIATURASADELANTADASTableAdapter()
        Me.LBLCOLEANTERIOR = New System.Windows.Forms.Label()
        Me.TXT4DIGITOSCUENTA = New System.Windows.Forms.TextBox()
        Me.LBL4DIGITOSCUENTA = New System.Windows.Forms.Label()
        Me.DTFECHAADMIN = New System.Windows.Forms.DateTimePicker()
        Me.GPBECA = New System.Windows.Forms.GroupBox()
        Me.GPFACTURACION = New System.Windows.Forms.GroupBox()
        Me.GPFECHATRANS = New System.Windows.Forms.GroupBox()
        Me.GPRETIRARRECARG = New System.Windows.Forms.GroupBox()
        Me.TXTPASS = New System.Windows.Forms.TextBox()
        Me.INSCRIPCIONESOCOLEGIATURASABONADASTableAdapter = New SAC.SACDataSetTableAdapters.INSCRIPCIONESOCOLEGIATURASABONADASTableAdapter()
        Me.INSCRIPCIONYCOLEGIATURASLIQUIDADASTableAdapter = New SAC.SACDataSetTableAdapters.INSCRIPCIONYCOLEGIATURASLIQUIDADASTableAdapter()
        Me.SELECCIONARPROMOCIONCOLEGIATURABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARPROMOCIONCOLEGIATURATableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARPROMOCIONCOLEGIATURATableAdapter()
        Me.LBLDESCRIPCIONPROMO = New System.Windows.Forms.Label()
        Me.LBLPORCENTPROMO = New System.Windows.Forms.Label()
        Me.CBOPROMOCION = New System.Windows.Forms.ComboBox()
        Me.CBPROMOCION = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXTPROMOCION = New System.Windows.Forms.TextBox()
        Me.TXTCODIGOPROMO = New System.Windows.Forms.TextBox()
        Me.SELECCIONARFECHAVENCIPORCICLOYPRODUCTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARFECHAVENCIPORCICLOYPRODUCTOTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARFECHAVENCIPORCICLOYPRODUCTOTableAdapter()
        Me.LBLFECHAVENCI = New System.Windows.Forms.Label()
        Me.COBRODECOLEGIATURATableAdapter = New SAC.SACDataSetTableAdapters.COBRODECOLEGIATURATableAdapter()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COBRODECOLEGIATURABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUEVORECIBOFOLIOFACTURABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INSCRIPCIONYCOLEGIATURASLIQUIDADASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INSCRIPCIONESOCOLEGIATURASABONADASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPOSDEPAGOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NOPAGARCOLEGIATURASADELANTADASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPBECA.SuspendLayout()
        Me.GPFACTURACION.SuspendLayout()
        Me.GPFECHATRANS.SuspendLayout()
        Me.GPRETIRARRECARG.SuspendLayout()
        CType(Me.SELECCIONARPROMOCIONCOLEGIATURABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SELECCIONARFECHAVENCIPORCICLOYPRODUCTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CBOCOLEGIATURAS
        '
        Me.CBOCOLEGIATURAS.DataSource = Me.COBRODECOLEGIATURABindingSource
        Me.CBOCOLEGIATURAS.DisplayMember = "descripcion"
        Me.CBOCOLEGIATURAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCOLEGIATURAS.FormattingEnabled = True
        Me.CBOCOLEGIATURAS.Location = New System.Drawing.Point(12, 12)
        Me.CBOCOLEGIATURAS.Name = "CBOCOLEGIATURAS"
        Me.CBOCOLEGIATURAS.Size = New System.Drawing.Size(641, 26)
        Me.CBOCOLEGIATURAS.TabIndex = 12
        Me.CBOCOLEGIATURAS.ValueMember = "concep"
        '
        'COBRODECOLEGIATURABindingSource
        '
        Me.COBRODECOLEGIATURABindingSource.DataMember = "COBRODECOLEGIATURA"
        Me.COBRODECOLEGIATURABindingSource.DataSource = Me.SACDataSet
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
        'LBLNVOFOLIO
        '
        Me.LBLNVOFOLIO.AutoSize = True
        Me.LBLNVOFOLIO.Location = New System.Drawing.Point(242, 399)
        Me.LBLNVOFOLIO.Name = "LBLNVOFOLIO"
        Me.LBLNVOFOLIO.Size = New System.Drawing.Size(88, 18)
        Me.LBLNVOFOLIO.TabIndex = 13
        Me.LBLNVOFOLIO.Text = "NVOFOLIO"
        '
        'LBLNOFOLIOMAX
        '
        Me.LBLNOFOLIOMAX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NUEVORECIBOFOLIOFACTURABindingSource, "NOFOLIO", True))
        Me.LBLNOFOLIOMAX.Location = New System.Drawing.Point(223, 417)
        Me.LBLNOFOLIOMAX.Name = "LBLNOFOLIOMAX"
        Me.LBLNOFOLIOMAX.Size = New System.Drawing.Size(100, 23)
        Me.LBLNOFOLIOMAX.TabIndex = 14
        Me.LBLNOFOLIOMAX.Text = "NOFOLIO"
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Image = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR.Location = New System.Drawing.Point(532, 354)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(100, 57)
        Me.CMDCANCELAR.TabIndex = 46
        Me.CMDCANCELAR.Text = "CERRAR"
        Me.CMDCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'CMDIMPRIMIR
        '
        Me.CMDIMPRIMIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDIMPRIMIR.Image = Global.SAC.My.Resources.Resources.PRINTER
        Me.CMDIMPRIMIR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDIMPRIMIR.Location = New System.Drawing.Point(426, 354)
        Me.CMDIMPRIMIR.Name = "CMDIMPRIMIR"
        Me.CMDIMPRIMIR.Size = New System.Drawing.Size(100, 57)
        Me.CMDIMPRIMIR.TabIndex = 45
        Me.CMDIMPRIMIR.Text = "IMPRIMIR"
        Me.CMDIMPRIMIR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDIMPRIMIR.UseVisualStyleBackColor = True
        Me.CMDIMPRIMIR.Visible = False
        '
        'CMDLIQUIDAR
        '
        Me.CMDLIQUIDAR.Image = Global.SAC.My.Resources.Resources.Aha_Soft_Business_Toolbar_Payment
        Me.CMDLIQUIDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDLIQUIDAR.Location = New System.Drawing.Point(136, 354)
        Me.CMDLIQUIDAR.Name = "CMDLIQUIDAR"
        Me.CMDLIQUIDAR.Size = New System.Drawing.Size(100, 57)
        Me.CMDLIQUIDAR.TabIndex = 44
        Me.CMDLIQUIDAR.Text = "LIQUIDAR"
        Me.CMDLIQUIDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDLIQUIDAR.UseVisualStyleBackColor = True
        Me.CMDLIQUIDAR.Visible = False
        '
        'CMDABONO
        '
        Me.CMDABONO.Image = Global.SAC.My.Resources.Resources.Aha_Soft_Business_Toolbar_Payment
        Me.CMDABONO.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDABONO.Location = New System.Drawing.Point(30, 354)
        Me.CMDABONO.Name = "CMDABONO"
        Me.CMDABONO.Size = New System.Drawing.Size(100, 57)
        Me.CMDABONO.TabIndex = 43
        Me.CMDABONO.Text = "ABONO"
        Me.CMDABONO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDABONO.UseVisualStyleBackColor = True
        Me.CMDABONO.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 19)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "ABONO"
        '
        'LBLABONO
        '
        Me.LBLABONO.AutoSize = True
        Me.LBLABONO.Location = New System.Drawing.Point(27, 79)
        Me.LBLABONO.Name = "LBLABONO"
        Me.LBLABONO.Size = New System.Drawing.Size(65, 18)
        Me.LBLABONO.TabIndex = 50
        Me.LBLABONO.Text = "ABONO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(201, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "MONTO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(379, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 19)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "RESTA"
        '
        'LBLRESTA
        '
        Me.LBLRESTA.AutoSize = True
        Me.LBLRESTA.Location = New System.Drawing.Point(379, 79)
        Me.LBLRESTA.Name = "LBLRESTA"
        Me.LBLRESTA.Size = New System.Drawing.Size(60, 18)
        Me.LBLRESTA.TabIndex = 47
        Me.LBLRESTA.Text = "RESTA"
        '
        'LBLMONTOBASE
        '
        Me.LBLMONTOBASE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COBRODECOLEGIATURABindingSource, "monto", True))
        Me.LBLMONTOBASE.Location = New System.Drawing.Point(242, 371)
        Me.LBLMONTOBASE.Name = "LBLMONTOBASE"
        Me.LBLMONTOBASE.Size = New System.Drawing.Size(100, 23)
        Me.LBLMONTOBASE.TabIndex = 52
        Me.LBLMONTOBASE.Text = "MONTO"
        '
        'CBRECARGO
        '
        Me.CBRECARGO.Location = New System.Drawing.Point(412, 414)
        Me.CBRECARGO.Name = "CBRECARGO"
        Me.CBRECARGO.Size = New System.Drawing.Size(104, 24)
        Me.CBRECARGO.TabIndex = 54
        Me.CBRECARGO.Text = "RECARGO"
        Me.CBRECARGO.UseVisualStyleBackColor = True
        '
        'LBLIDPRODUC
        '
        Me.LBLIDPRODUC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COBRODECOLEGIATURABindingSource, "idproduc", True))
        Me.LBLIDPRODUC.Location = New System.Drawing.Point(309, 418)
        Me.LBLIDPRODUC.Name = "LBLIDPRODUC"
        Me.LBLIDPRODUC.Size = New System.Drawing.Size(100, 23)
        Me.LBLIDPRODUC.TabIndex = 55
        Me.LBLIDPRODUC.Text = "IDPRODUC"
        '
        'LBLPORCENTAJE
        '
        Me.LBLPORCENTAJE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COBRODECOLEGIATURABindingSource, "porcent", True))
        Me.LBLPORCENTAJE.Location = New System.Drawing.Point(117, 417)
        Me.LBLPORCENTAJE.Name = "LBLPORCENTAJE"
        Me.LBLPORCENTAJE.Size = New System.Drawing.Size(100, 23)
        Me.LBLPORCENTAJE.TabIndex = 56
        Me.LBLPORCENTAJE.Text = "PORCENT"
        '
        'LBLABONORECARG
        '
        Me.LBLABONORECARG.AutoSize = True
        Me.LBLABONORECARG.Location = New System.Drawing.Point(636, 394)
        Me.LBLABONORECARG.Name = "LBLABONORECARG"
        Me.LBLABONORECARG.Size = New System.Drawing.Size(133, 18)
        Me.LBLABONORECARG.TabIndex = 57
        Me.LBLABONORECARG.Text = "ABONORECARG"
        '
        'LBLLIQUIDADO
        '
        Me.LBLLIQUIDADO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INSCRIPCIONYCOLEGIATURASLIQUIDADASBindingSource, "LIQUIDADO", True))
        Me.LBLLIQUIDADO.Location = New System.Drawing.Point(11, 417)
        Me.LBLLIQUIDADO.Name = "LBLLIQUIDADO"
        Me.LBLLIQUIDADO.Size = New System.Drawing.Size(100, 23)
        Me.LBLLIQUIDADO.TabIndex = 59
        Me.LBLLIQUIDADO.Text = "LIQUIDADO"
        '
        'INSCRIPCIONYCOLEGIATURASLIQUIDADASBindingSource
        '
        Me.INSCRIPCIONYCOLEGIATURASLIQUIDADASBindingSource.DataMember = "INSCRIPCIONYCOLEGIATURASLIQUIDADAS"
        Me.INSCRIPCIONYCOLEGIATURASLIQUIDADASBindingSource.DataSource = Me.SACDataSet
        '
        'LBLABONADO
        '
        Me.LBLABONADO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INSCRIPCIONESOCOLEGIATURASABONADASBindingSource, "LIQUIDADO", True))
        Me.LBLABONADO.Location = New System.Drawing.Point(513, 415)
        Me.LBLABONADO.Name = "LBLABONADO"
        Me.LBLABONADO.Size = New System.Drawing.Size(100, 23)
        Me.LBLABONADO.TabIndex = 61
        Me.LBLABONADO.Text = "ABONADO"
        '
        'INSCRIPCIONESOCOLEGIATURASABONADASBindingSource
        '
        Me.INSCRIPCIONESOCOLEGIATURASABONADASBindingSource.DataMember = "INSCRIPCIONESOCOLEGIATURASABONADAS"
        Me.INSCRIPCIONESOCOLEGIATURASABONADASBindingSource.DataSource = Me.SACDataSet
        '
        'Button13
        '
        Me.Button13.BackgroundImage = Global.SAC.My.Resources.Resources.ok
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button13.Location = New System.Drawing.Point(658, 11)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(28, 28)
        Me.Button13.TabIndex = 62
        Me.Button13.UseVisualStyleBackColor = True
        '
        'LBLMONTO
        '
        Me.LBLMONTO.AutoSize = True
        Me.LBLMONTO.Location = New System.Drawing.Point(201, 79)
        Me.LBLMONTO.Name = "LBLMONTO"
        Me.LBLMONTO.Size = New System.Drawing.Size(65, 18)
        Me.LBLMONTO.TabIndex = 63
        Me.LBLMONTO.Text = "MONTO"
        '
        'LBLNOPAGARCOLEADE
        '
        Me.LBLNOPAGARCOLEADE.Location = New System.Drawing.Point(636, 417)
        Me.LBLNOPAGARCOLEADE.Name = "LBLNOPAGARCOLEADE"
        Me.LBLNOPAGARCOLEADE.Size = New System.Drawing.Size(100, 23)
        Me.LBLNOPAGARCOLEADE.TabIndex = 65
        Me.LBLNOPAGARCOLEADE.Text = "NOPAGARCOLEADELANTADA"
        '
        'CBOTIPOPAGO
        '
        Me.CBOTIPOPAGO.DataSource = Me.TIPOSDEPAGOBindingSource
        Me.CBOTIPOPAGO.DisplayMember = "tipopago"
        Me.CBOTIPOPAGO.FormattingEnabled = True
        Me.CBOTIPOPAGO.Location = New System.Drawing.Point(495, 76)
        Me.CBOTIPOPAGO.Name = "CBOTIPOPAGO"
        Me.CBOTIPOPAGO.Size = New System.Drawing.Size(189, 26)
        Me.CBOTIPOPAGO.TabIndex = 66
        Me.CBOTIPOPAGO.ValueMember = "idtipopago"
        '
        'TIPOSDEPAGOBindingSource
        '
        Me.TIPOSDEPAGOBindingSource.DataMember = "TIPOSDEPAGO"
        Me.TIPOSDEPAGOBindingSource.DataSource = Me.SACDataSet
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(520, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 19)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "TIPO DE PAGO"
        '
        'LBLSCOPORBECA
        '
        Me.LBLSCOPORBECA.AutoSize = True
        Me.LBLSCOPORBECA.Location = New System.Drawing.Point(77, 65)
        Me.LBLSCOPORBECA.Name = "LBLSCOPORBECA"
        Me.LBLSCOPORBECA.Size = New System.Drawing.Size(17, 18)
        Me.LBLSCOPORBECA.TabIndex = 69
        Me.LBLSCOPORBECA.Text = "0"
        '
        'LBLDESCONBECA
        '
        Me.LBLDESCONBECA.AutoSize = True
        Me.LBLDESCONBECA.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDESCONBECA.Location = New System.Drawing.Point(26, 43)
        Me.LBLDESCONBECA.Name = "LBLDESCONBECA"
        Me.LBLDESCONBECA.Size = New System.Drawing.Size(145, 19)
        Me.LBLDESCONBECA.TabIndex = 68
        Me.LBLDESCONBECA.Text = "DESC CON BECA"
        '
        'TIPOSDEPAGOTableAdapter
        '
        Me.TIPOSDEPAGOTableAdapter.ClearBeforeFill = True
        '
        'NOPAGARCOLEGIATURASADELANTADASBindingSource
        '
        Me.NOPAGARCOLEGIATURASADELANTADASBindingSource.DataMember = "NOPAGARCOLEGIATURASADELANTADAS"
        Me.NOPAGARCOLEGIATURASADELANTADASBindingSource.DataSource = Me.SACDataSet
        '
        'NOPAGARCOLEGIATURASADELANTADASTableAdapter
        '
        Me.NOPAGARCOLEGIATURASADELANTADASTableAdapter.ClearBeforeFill = True
        '
        'LBLCOLEANTERIOR
        '
        Me.LBLCOLEANTERIOR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NOPAGARCOLEGIATURASADELANTADASBindingSource, "COLEABONADO", True))
        Me.LBLCOLEANTERIOR.Location = New System.Drawing.Point(636, 369)
        Me.LBLCOLEANTERIOR.Name = "LBLCOLEANTERIOR"
        Me.LBLCOLEANTERIOR.Size = New System.Drawing.Size(100, 23)
        Me.LBLCOLEANTERIOR.TabIndex = 70
        Me.LBLCOLEANTERIOR.Text = "Label5"
        '
        'TXT4DIGITOSCUENTA
        '
        Me.TXT4DIGITOSCUENTA.Location = New System.Drawing.Point(40, 65)
        Me.TXT4DIGITOSCUENTA.MaxLength = 4
        Me.TXT4DIGITOSCUENTA.Name = "TXT4DIGITOSCUENTA"
        Me.TXT4DIGITOSCUENTA.Size = New System.Drawing.Size(157, 26)
        Me.TXT4DIGITOSCUENTA.TabIndex = 72
        Me.TXT4DIGITOSCUENTA.Visible = False
        '
        'LBL4DIGITOSCUENTA
        '
        Me.LBL4DIGITOSCUENTA.AutoSize = True
        Me.LBL4DIGITOSCUENTA.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL4DIGITOSCUENTA.Location = New System.Drawing.Point(36, 43)
        Me.LBL4DIGITOSCUENTA.Name = "LBL4DIGITOSCUENTA"
        Me.LBL4DIGITOSCUENTA.Size = New System.Drawing.Size(158, 19)
        Me.LBL4DIGITOSCUENTA.TabIndex = 73
        Me.LBL4DIGITOSCUENTA.Text = "4 DIGITOS CUENTA"
        Me.LBL4DIGITOSCUENTA.Visible = False
        '
        'DTFECHAADMIN
        '
        Me.DTFECHAADMIN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFECHAADMIN.Location = New System.Drawing.Point(20, 23)
        Me.DTFECHAADMIN.Name = "DTFECHAADMIN"
        Me.DTFECHAADMIN.Size = New System.Drawing.Size(169, 26)
        Me.DTFECHAADMIN.TabIndex = 74
        '
        'GPBECA
        '
        Me.GPBECA.Controls.Add(Me.LBLDESCONBECA)
        Me.GPBECA.Controls.Add(Me.LBLSCOPORBECA)
        Me.GPBECA.Location = New System.Drawing.Point(17, 113)
        Me.GPBECA.Name = "GPBECA"
        Me.GPBECA.Size = New System.Drawing.Size(200, 130)
        Me.GPBECA.TabIndex = 75
        Me.GPBECA.TabStop = False
        Me.GPBECA.Text = "BECA"
        '
        'GPFACTURACION
        '
        Me.GPFACTURACION.Controls.Add(Me.LBL4DIGITOSCUENTA)
        Me.GPFACTURACION.Controls.Add(Me.TXT4DIGITOSCUENTA)
        Me.GPFACTURACION.Location = New System.Drawing.Point(245, 113)
        Me.GPFACTURACION.Name = "GPFACTURACION"
        Me.GPFACTURACION.Size = New System.Drawing.Size(244, 130)
        Me.GPFACTURACION.TabIndex = 76
        Me.GPFACTURACION.TabStop = False
        Me.GPFACTURACION.Text = "FACTURACION"
        '
        'GPFECHATRANS
        '
        Me.GPFECHATRANS.Controls.Add(Me.DTFECHAADMIN)
        Me.GPFECHATRANS.Location = New System.Drawing.Point(495, 113)
        Me.GPFECHATRANS.Name = "GPFECHATRANS"
        Me.GPFECHATRANS.Size = New System.Drawing.Size(200, 62)
        Me.GPFECHATRANS.TabIndex = 77
        Me.GPFECHATRANS.TabStop = False
        Me.GPFECHATRANS.Text = "FECHA TRANSF"
        '
        'GPRETIRARRECARG
        '
        Me.GPRETIRARRECARG.Controls.Add(Me.TXTPASS)
        Me.GPRETIRARRECARG.Location = New System.Drawing.Point(495, 181)
        Me.GPRETIRARRECARG.Name = "GPRETIRARRECARG"
        Me.GPRETIRARRECARG.Size = New System.Drawing.Size(200, 62)
        Me.GPRETIRARRECARG.TabIndex = 78
        Me.GPRETIRARRECARG.TabStop = False
        Me.GPRETIRARRECARG.Text = "QUITAR RECARGO"
        '
        'TXTPASS
        '
        Me.TXTPASS.Location = New System.Drawing.Point(21, 25)
        Me.TXTPASS.MaxLength = 1000
        Me.TXTPASS.Name = "TXTPASS"
        Me.TXTPASS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTPASS.Size = New System.Drawing.Size(157, 26)
        Me.TXTPASS.TabIndex = 74
        '
        'INSCRIPCIONESOCOLEGIATURASABONADASTableAdapter
        '
        Me.INSCRIPCIONESOCOLEGIATURASABONADASTableAdapter.ClearBeforeFill = True
        '
        'INSCRIPCIONYCOLEGIATURASLIQUIDADASTableAdapter
        '
        Me.INSCRIPCIONYCOLEGIATURASLIQUIDADASTableAdapter.ClearBeforeFill = True
        '
        'SELECCIONARPROMOCIONCOLEGIATURABindingSource
        '
        Me.SELECCIONARPROMOCIONCOLEGIATURABindingSource.DataMember = "SELECCIONARPROMOCIONCOLEGIATURA"
        Me.SELECCIONARPROMOCIONCOLEGIATURABindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARPROMOCIONCOLEGIATURATableAdapter
        '
        Me.SELECCIONARPROMOCIONCOLEGIATURATableAdapter.ClearBeforeFill = True
        '
        'LBLDESCRIPCIONPROMO
        '
        Me.LBLDESCRIPCIONPROMO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARPROMOCIONCOLEGIATURABindingSource, "descripcion", True))
        Me.LBLDESCRIPCIONPROMO.Location = New System.Drawing.Point(14, 440)
        Me.LBLDESCRIPCIONPROMO.Name = "LBLDESCRIPCIONPROMO"
        Me.LBLDESCRIPCIONPROMO.Size = New System.Drawing.Size(100, 23)
        Me.LBLDESCRIPCIONPROMO.TabIndex = 79
        Me.LBLDESCRIPCIONPROMO.Text = "DESCPROMO"
        Me.LBLDESCRIPCIONPROMO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LBLPORCENTPROMO
        '
        Me.LBLPORCENTPROMO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARPROMOCIONCOLEGIATURABindingSource, "porcedescuento", True))
        Me.LBLPORCENTPROMO.Location = New System.Drawing.Point(145, 440)
        Me.LBLPORCENTPROMO.Name = "LBLPORCENTPROMO"
        Me.LBLPORCENTPROMO.Size = New System.Drawing.Size(100, 23)
        Me.LBLPORCENTPROMO.TabIndex = 80
        Me.LBLPORCENTPROMO.Text = "PORCENTPROMO"
        '
        'CBOPROMOCION
        '
        Me.CBOPROMOCION.Enabled = False
        Me.CBOPROMOCION.FormattingEnabled = True
        Me.CBOPROMOCION.Items.AddRange(New Object() {"5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70", "75", "80", "85", "90", "95", "100"})
        Me.CBOPROMOCION.Location = New System.Drawing.Point(458, 53)
        Me.CBOPROMOCION.Name = "CBOPROMOCION"
        Me.CBOPROMOCION.Size = New System.Drawing.Size(198, 26)
        Me.CBOPROMOCION.TabIndex = 81
        '
        'CBPROMOCION
        '
        Me.CBPROMOCION.AutoSize = True
        Me.CBPROMOCION.Enabled = False
        Me.CBPROMOCION.Location = New System.Drawing.Point(229, 25)
        Me.CBPROMOCION.Name = "CBPROMOCION"
        Me.CBPROMOCION.Size = New System.Drawing.Size(140, 17)
        Me.CBPROMOCION.TabIndex = 74
        Me.CBPROMOCION.Text = "APLICAR PROMOCION"
        Me.CBPROMOCION.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXTPROMOCION)
        Me.GroupBox1.Controls.Add(Me.TXTCODIGOPROMO)
        Me.GroupBox1.Controls.Add(Me.CBPROMOCION)
        Me.GroupBox1.Controls.Add(Me.CBOPROMOCION)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 249)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(678, 88)
        Me.GroupBox1.TabIndex = 82
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PROMOCION"
        '
        'TXTPROMOCION
        '
        Me.TXTPROMOCION.Enabled = False
        Me.TXTPROMOCION.Location = New System.Drawing.Point(229, 53)
        Me.TXTPROMOCION.MaxLength = 1000
        Me.TXTPROMOCION.Name = "TXTPROMOCION"
        Me.TXTPROMOCION.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTPROMOCION.Size = New System.Drawing.Size(223, 26)
        Me.TXTPROMOCION.TabIndex = 84
        '
        'TXTCODIGOPROMO
        '
        Me.TXTCODIGOPROMO.Location = New System.Drawing.Point(14, 53)
        Me.TXTCODIGOPROMO.MaxLength = 1000
        Me.TXTCODIGOPROMO.Name = "TXTCODIGOPROMO"
        Me.TXTCODIGOPROMO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTCODIGOPROMO.Size = New System.Drawing.Size(196, 26)
        Me.TXTCODIGOPROMO.TabIndex = 83
        '
        'SELECCIONARFECHAVENCIPORCICLOYPRODUCTOBindingSource
        '
        Me.SELECCIONARFECHAVENCIPORCICLOYPRODUCTOBindingSource.DataMember = "SELECCIONARFECHAVENCIPORCICLOYPRODUCTO"
        Me.SELECCIONARFECHAVENCIPORCICLOYPRODUCTOBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARFECHAVENCIPORCICLOYPRODUCTOTableAdapter
        '
        Me.SELECCIONARFECHAVENCIPORCICLOYPRODUCTOTableAdapter.ClearBeforeFill = True
        '
        'LBLFECHAVENCI
        '
        Me.LBLFECHAVENCI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARFECHAVENCIPORCICLOYPRODUCTOBindingSource, "FECHAVENCIMIENTO", True))
        Me.LBLFECHAVENCI.Location = New System.Drawing.Point(316, 440)
        Me.LBLFECHAVENCI.Name = "LBLFECHAVENCI"
        Me.LBLFECHAVENCI.Size = New System.Drawing.Size(100, 23)
        Me.LBLFECHAVENCI.TabIndex = 74
        Me.LBLFECHAVENCI.Text = "FECHAVENCI"
        '
        'COBRODECOLEGIATURATableAdapter
        '
        Me.COBRODECOLEGIATURATableAdapter.ClearBeforeFill = True
        '
        'PAGOCOLEGIATURA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 471)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBLFECHAVENCI)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LBLPORCENTPROMO)
        Me.Controls.Add(Me.LBLDESCRIPCIONPROMO)
        Me.Controls.Add(Me.GPRETIRARRECARG)
        Me.Controls.Add(Me.GPFECHATRANS)
        Me.Controls.Add(Me.GPFACTURACION)
        Me.Controls.Add(Me.GPBECA)
        Me.Controls.Add(Me.LBLCOLEANTERIOR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBOTIPOPAGO)
        Me.Controls.Add(Me.LBLNOPAGARCOLEADE)
        Me.Controls.Add(Me.LBLMONTO)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.LBLABONADO)
        Me.Controls.Add(Me.LBLLIQUIDADO)
        Me.Controls.Add(Me.LBLABONORECARG)
        Me.Controls.Add(Me.LBLPORCENTAJE)
        Me.Controls.Add(Me.LBLIDPRODUC)
        Me.Controls.Add(Me.CBRECARGO)
        Me.Controls.Add(Me.LBLMONTOBASE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LBLABONO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBLRESTA)
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.CMDIMPRIMIR)
        Me.Controls.Add(Me.CMDLIQUIDAR)
        Me.Controls.Add(Me.CMDABONO)
        Me.Controls.Add(Me.LBLNOFOLIOMAX)
        Me.Controls.Add(Me.LBLNVOFOLIO)
        Me.Controls.Add(Me.CBOCOLEGIATURAS)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PAGOCOLEGIATURA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAGO COLEGIATURA"
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COBRODECOLEGIATURABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUEVORECIBOFOLIOFACTURABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INSCRIPCIONYCOLEGIATURASLIQUIDADASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INSCRIPCIONESOCOLEGIATURASABONADASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPOSDEPAGOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NOPAGARCOLEGIATURASADELANTADASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GPBECA.ResumeLayout(False)
        Me.GPBECA.PerformLayout()
        Me.GPFACTURACION.ResumeLayout(False)
        Me.GPFACTURACION.PerformLayout()
        Me.GPFECHATRANS.ResumeLayout(False)
        Me.GPRETIRARRECARG.ResumeLayout(False)
        Me.GPRETIRARRECARG.PerformLayout()
        CType(Me.SELECCIONARPROMOCIONCOLEGIATURABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SELECCIONARFECHAVENCIPORCICLOYPRODUCTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CBOCOLEGIATURAS As System.Windows.Forms.ComboBox
    Friend WithEvents NUEVORECIBOFOLIOFACTURABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NUEVORECIBOFOLIOFACTURATableAdapter As SAC.SACDataSetTableAdapters.NUEVORECIBOFOLIOFACTURATableAdapter
    Friend WithEvents LBLNVOFOLIO As System.Windows.Forms.Label
    Friend WithEvents LBLNOFOLIOMAX As System.Windows.Forms.Label
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents CMDIMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents CMDLIQUIDAR As System.Windows.Forms.Button
    Friend WithEvents CMDABONO As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LBLABONO As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LBLRESTA As System.Windows.Forms.Label
    Friend WithEvents LBLMONTOBASE As System.Windows.Forms.Label
    Friend WithEvents CBRECARGO As System.Windows.Forms.CheckBox
    Friend WithEvents LBLIDPRODUC As System.Windows.Forms.Label
    Friend WithEvents LBLPORCENTAJE As System.Windows.Forms.Label
    Friend WithEvents LBLABONORECARG As System.Windows.Forms.Label
    Friend WithEvents LBLLIQUIDADO As System.Windows.Forms.Label
    Friend WithEvents LBLABONADO As System.Windows.Forms.Label
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents LBLMONTO As System.Windows.Forms.Label
    Friend WithEvents LBLNOPAGARCOLEADE As System.Windows.Forms.Label
    Friend WithEvents CBOTIPOPAGO As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LBLSCOPORBECA As System.Windows.Forms.Label
    Friend WithEvents LBLDESCONBECA As System.Windows.Forms.Label
    Friend WithEvents TIPOSDEPAGOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TIPOSDEPAGOTableAdapter As SAC.SACDataSetTableAdapters.TIPOSDEPAGOTableAdapter
    Friend WithEvents NOPAGARCOLEGIATURASADELANTADASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NOPAGARCOLEGIATURASADELANTADASTableAdapter As SAC.SACDataSetTableAdapters.NOPAGARCOLEGIATURASADELANTADASTableAdapter
    Friend WithEvents LBLCOLEANTERIOR As System.Windows.Forms.Label
    Friend WithEvents TXT4DIGITOSCUENTA As System.Windows.Forms.TextBox
    Friend WithEvents LBL4DIGITOSCUENTA As System.Windows.Forms.Label
    Friend WithEvents DTFECHAADMIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents GPBECA As System.Windows.Forms.GroupBox
    Friend WithEvents GPFACTURACION As System.Windows.Forms.GroupBox
    Friend WithEvents GPFECHATRANS As System.Windows.Forms.GroupBox
    Friend WithEvents GPRETIRARRECARG As System.Windows.Forms.GroupBox
    Friend WithEvents TXTPASS As System.Windows.Forms.TextBox
    Friend WithEvents INSCRIPCIONESOCOLEGIATURASABONADASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents INSCRIPCIONESOCOLEGIATURASABONADASTableAdapter As SAC.SACDataSetTableAdapters.INSCRIPCIONESOCOLEGIATURASABONADASTableAdapter
    Friend WithEvents INSCRIPCIONYCOLEGIATURASLIQUIDADASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents INSCRIPCIONYCOLEGIATURASLIQUIDADASTableAdapter As SAC.SACDataSetTableAdapters.INSCRIPCIONYCOLEGIATURASLIQUIDADASTableAdapter
    Friend WithEvents SELECCIONARPROMOCIONCOLEGIATURABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARPROMOCIONCOLEGIATURATableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARPROMOCIONCOLEGIATURATableAdapter
    Friend WithEvents LBLDESCRIPCIONPROMO As System.Windows.Forms.Label
    Friend WithEvents LBLPORCENTPROMO As System.Windows.Forms.Label
    Friend WithEvents CBOPROMOCION As System.Windows.Forms.ComboBox
    Friend WithEvents CBPROMOCION As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SELECCIONARFECHAVENCIPORCICLOYPRODUCTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARFECHAVENCIPORCICLOYPRODUCTOTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARFECHAVENCIPORCICLOYPRODUCTOTableAdapter
    Friend WithEvents LBLFECHAVENCI As System.Windows.Forms.Label
    Friend WithEvents COBRODECOLEGIATURABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COBRODECOLEGIATURATableAdapter As SAC.SACDataSetTableAdapters.COBRODECOLEGIATURATableAdapter
    Friend WithEvents TXTPROMOCION As System.Windows.Forms.TextBox
    Friend WithEvents TXTCODIGOPROMO As System.Windows.Forms.TextBox
End Class
