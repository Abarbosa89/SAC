<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAGODEINSCRIPCION
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.COBROINSCRIPCIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SACDataSet = New SAC.SACDataSet()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.LBLRESTA = New System.Windows.Forms.Label()
        Me.CMDABONO = New System.Windows.Forms.Button()
        Me.CMDLIQUIDAR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBLMONTOBASE = New System.Windows.Forms.Label()
        Me.LBLABONO = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.CMDIMPRIMIR = New System.Windows.Forms.Button()
        Me.NUEVORECIBOFOLIOFACTURABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NUEVORECIBOFOLIOFACTURATableAdapter = New SAC.SACDataSetTableAdapters.NUEVORECIBOFOLIOFACTURATableAdapter()
        Me.LBLNOFOLIOMAX = New System.Windows.Forms.Label()
        Me.LBLNONUEVOFOLIO = New System.Windows.Forms.Label()
        Me.LBLIDPRODUC = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBOTIPOPAGO = New System.Windows.Forms.ComboBox()
        Me.TIPOSDEPAGOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIPOSDEPAGOTableAdapter = New SAC.SACDataSetTableAdapters.TIPOSDEPAGOTableAdapter()
        Me.LBLMONTO = New System.Windows.Forms.Label()
        Me.GPBECA = New System.Windows.Forms.GroupBox()
        Me.LBLDESCONBECA = New System.Windows.Forms.Label()
        Me.LBLSCOPORBECA = New System.Windows.Forms.Label()
        Me.GPFECHATRANS = New System.Windows.Forms.GroupBox()
        Me.DTFECHAADMIN = New System.Windows.Forms.DateTimePicker()
        Me.GPFACTURACION = New System.Windows.Forms.GroupBox()
        Me.LBL4DIGITOSCUENTA = New System.Windows.Forms.Label()
        Me.TXT4DIGITOSCUENTA = New System.Windows.Forms.TextBox()
        Me.LBLINSABON = New System.Windows.Forms.Label()
        Me.INSCRIPCIONABONADABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LBLINSCLIQ = New System.Windows.Forms.Label()
        Me.INSCRIPCIONLIQUIDADABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INSCRIPCIONABONADATableAdapter = New SAC.SACDataSetTableAdapters.INSCRIPCIONABONADATableAdapter()
        Me.INSCRIPCIONLIQUIDADATableAdapter = New SAC.SACDataSetTableAdapters.INSCRIPCIONLIQUIDADATableAdapter()
        Me.COBROINSCRIPCIONTableAdapter = New SAC.SACDataSetTableAdapters.COBROINSCRIPCIONTableAdapter()
        CType(Me.COBROINSCRIPCIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUEVORECIBOFOLIOFACTURABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPOSDEPAGOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPBECA.SuspendLayout()
        Me.GPFECHATRANS.SuspendLayout()
        Me.GPFACTURACION.SuspendLayout()
        CType(Me.INSCRIPCIONABONADABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INSCRIPCIONLIQUIDADABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.COBROINSCRIPCIONBindingSource
        Me.ComboBox1.DisplayMember = "concep"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(51, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(552, 28)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "concep"
        '
        'COBROINSCRIPCIONBindingSource
        '
        Me.COBROINSCRIPCIONBindingSource.DataMember = "COBROINSCRIPCION"
        Me.COBROINSCRIPCIONBindingSource.DataSource = Me.SACDataSet
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
        'LBLRESTA
        '
        Me.LBLRESTA.AutoSize = True
        Me.LBLRESTA.Location = New System.Drawing.Point(341, 87)
        Me.LBLRESTA.Name = "LBLRESTA"
        Me.LBLRESTA.Size = New System.Drawing.Size(63, 20)
        Me.LBLRESTA.TabIndex = 1
        Me.LBLRESTA.Text = "RESTA"
        '
        'CMDABONO
        '
        Me.CMDABONO.Image = Global.SAC.My.Resources.Resources.Aha_Soft_Business_Toolbar_Payment
        Me.CMDABONO.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDABONO.Location = New System.Drawing.Point(19, 258)
        Me.CMDABONO.Name = "CMDABONO"
        Me.CMDABONO.Size = New System.Drawing.Size(100, 57)
        Me.CMDABONO.TabIndex = 2
        Me.CMDABONO.Text = "ABONO"
        Me.CMDABONO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDABONO.UseVisualStyleBackColor = True
        '
        'CMDLIQUIDAR
        '
        Me.CMDLIQUIDAR.Image = Global.SAC.My.Resources.Resources.Aha_Soft_Business_Toolbar_Payment
        Me.CMDLIQUIDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDLIQUIDAR.Location = New System.Drawing.Point(125, 258)
        Me.CMDLIQUIDAR.Name = "CMDLIQUIDAR"
        Me.CMDLIQUIDAR.Size = New System.Drawing.Size(100, 57)
        Me.CMDLIQUIDAR.TabIndex = 3
        Me.CMDLIQUIDAR.Text = "LIQUIDAR"
        Me.CMDLIQUIDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDLIQUIDAR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(341, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "RESTA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "MONTO"
        '
        'LBLMONTOBASE
        '
        Me.LBLMONTOBASE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COBROINSCRIPCIONBindingSource, "monto", True))
        Me.LBLMONTOBASE.Location = New System.Drawing.Point(337, 281)
        Me.LBLMONTOBASE.Name = "LBLMONTOBASE"
        Me.LBLMONTOBASE.Size = New System.Drawing.Size(100, 23)
        Me.LBLMONTOBASE.TabIndex = 7
        Me.LBLMONTOBASE.Text = "MONTO"
        '
        'LBLABONO
        '
        Me.LBLABONO.AutoSize = True
        Me.LBLABONO.Location = New System.Drawing.Point(47, 87)
        Me.LBLABONO.Name = "LBLABONO"
        Me.LBLABONO.Size = New System.Drawing.Size(66, 20)
        Me.LBLABONO.TabIndex = 8
        Me.LBLABONO.Text = "ABONO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "ABONO"
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Image = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR.Location = New System.Drawing.Point(531, 258)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(100, 57)
        Me.CMDCANCELAR.TabIndex = 42
        Me.CMDCANCELAR.Text = "CERRAR"
        Me.CMDCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'CMDIMPRIMIR
        '
        Me.CMDIMPRIMIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDIMPRIMIR.Image = Global.SAC.My.Resources.Resources.PRINTER
        Me.CMDIMPRIMIR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDIMPRIMIR.Location = New System.Drawing.Point(425, 258)
        Me.CMDIMPRIMIR.Name = "CMDIMPRIMIR"
        Me.CMDIMPRIMIR.Size = New System.Drawing.Size(100, 57)
        Me.CMDIMPRIMIR.TabIndex = 41
        Me.CMDIMPRIMIR.Text = "IMPRIMIR"
        Me.CMDIMPRIMIR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDIMPRIMIR.UseVisualStyleBackColor = True
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
        'LBLNOFOLIOMAX
        '
        Me.LBLNOFOLIOMAX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NUEVORECIBOFOLIOFACTURABindingSource, "NOFOLIO", True))
        Me.LBLNOFOLIOMAX.Location = New System.Drawing.Point(231, 281)
        Me.LBLNOFOLIOMAX.Name = "LBLNOFOLIOMAX"
        Me.LBLNOFOLIOMAX.Size = New System.Drawing.Size(100, 23)
        Me.LBLNOFOLIOMAX.TabIndex = 43
        Me.LBLNOFOLIOMAX.Text = "NOFOLIO"
        '
        'LBLNONUEVOFOLIO
        '
        Me.LBLNONUEVOFOLIO.AutoSize = True
        Me.LBLNONUEVOFOLIO.Location = New System.Drawing.Point(231, 304)
        Me.LBLNONUEVOFOLIO.Name = "LBLNONUEVOFOLIO"
        Me.LBLNONUEVOFOLIO.Size = New System.Drawing.Size(114, 20)
        Me.LBLNONUEVOFOLIO.TabIndex = 44
        Me.LBLNONUEVOFOLIO.Text = "NUEVOFOLIO"
        '
        'LBLIDPRODUC
        '
        Me.LBLIDPRODUC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COBROINSCRIPCIONBindingSource, "idproduc", True))
        Me.LBLIDPRODUC.Location = New System.Drawing.Point(231, 258)
        Me.LBLIDPRODUC.Name = "LBLIDPRODUC"
        Me.LBLIDPRODUC.Size = New System.Drawing.Size(100, 23)
        Me.LBLIDPRODUC.TabIndex = 45
        Me.LBLIDPRODUC.Text = "IDPRODUC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(464, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 20)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "TIPO DE PAGO"
        '
        'CBOTIPOPAGO
        '
        Me.CBOTIPOPAGO.DataSource = Me.TIPOSDEPAGOBindingSource
        Me.CBOTIPOPAGO.DisplayMember = "tipopago"
        Me.CBOTIPOPAGO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOTIPOPAGO.FormattingEnabled = True
        Me.CBOTIPOPAGO.Location = New System.Drawing.Point(439, 84)
        Me.CBOTIPOPAGO.Name = "CBOTIPOPAGO"
        Me.CBOTIPOPAGO.Size = New System.Drawing.Size(189, 28)
        Me.CBOTIPOPAGO.TabIndex = 68
        Me.CBOTIPOPAGO.ValueMember = "idtipopago"
        '
        'TIPOSDEPAGOBindingSource
        '
        Me.TIPOSDEPAGOBindingSource.DataMember = "TIPOSDEPAGO"
        Me.TIPOSDEPAGOBindingSource.DataSource = Me.SACDataSet
        '
        'TIPOSDEPAGOTableAdapter
        '
        Me.TIPOSDEPAGOTableAdapter.ClearBeforeFill = True
        '
        'LBLMONTO
        '
        Me.LBLMONTO.AutoSize = True
        Me.LBLMONTO.Location = New System.Drawing.Point(186, 87)
        Me.LBLMONTO.Name = "LBLMONTO"
        Me.LBLMONTO.Size = New System.Drawing.Size(66, 20)
        Me.LBLMONTO.TabIndex = 70
        Me.LBLMONTO.Text = "MONTO"
        '
        'GPBECA
        '
        Me.GPBECA.Controls.Add(Me.LBLDESCONBECA)
        Me.GPBECA.Controls.Add(Me.LBLSCOPORBECA)
        Me.GPBECA.Location = New System.Drawing.Point(19, 123)
        Me.GPBECA.Name = "GPBECA"
        Me.GPBECA.Size = New System.Drawing.Size(200, 120)
        Me.GPBECA.TabIndex = 76
        Me.GPBECA.TabStop = False
        Me.GPBECA.Text = "BECA"
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
        'LBLSCOPORBECA
        '
        Me.LBLSCOPORBECA.AutoSize = True
        Me.LBLSCOPORBECA.Location = New System.Drawing.Point(58, 62)
        Me.LBLSCOPORBECA.Name = "LBLSCOPORBECA"
        Me.LBLSCOPORBECA.Size = New System.Drawing.Size(18, 20)
        Me.LBLSCOPORBECA.TabIndex = 69
        Me.LBLSCOPORBECA.Text = "0"
        '
        'GPFECHATRANS
        '
        Me.GPFECHATRANS.Controls.Add(Me.DTFECHAADMIN)
        Me.GPFECHATRANS.Location = New System.Drawing.Point(447, 123)
        Me.GPFECHATRANS.Name = "GPFECHATRANS"
        Me.GPFECHATRANS.Size = New System.Drawing.Size(200, 120)
        Me.GPFECHATRANS.TabIndex = 79
        Me.GPFECHATRANS.TabStop = False
        Me.GPFECHATRANS.Text = "FECHA TRANSF"
        '
        'DTFECHAADMIN
        '
        Me.DTFECHAADMIN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFECHAADMIN.Location = New System.Drawing.Point(20, 51)
        Me.DTFECHAADMIN.Name = "DTFECHAADMIN"
        Me.DTFECHAADMIN.Size = New System.Drawing.Size(169, 26)
        Me.DTFECHAADMIN.TabIndex = 74
        '
        'GPFACTURACION
        '
        Me.GPFACTURACION.Controls.Add(Me.LBL4DIGITOSCUENTA)
        Me.GPFACTURACION.Controls.Add(Me.TXT4DIGITOSCUENTA)
        Me.GPFACTURACION.Location = New System.Drawing.Point(225, 123)
        Me.GPFACTURACION.Name = "GPFACTURACION"
        Me.GPFACTURACION.Size = New System.Drawing.Size(216, 120)
        Me.GPFACTURACION.TabIndex = 78
        Me.GPFACTURACION.TabStop = False
        Me.GPFACTURACION.Text = "FACTURACION"
        '
        'LBL4DIGITOSCUENTA
        '
        Me.LBL4DIGITOSCUENTA.AutoSize = True
        Me.LBL4DIGITOSCUENTA.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL4DIGITOSCUENTA.Location = New System.Drawing.Point(21, 43)
        Me.LBL4DIGITOSCUENTA.Name = "LBL4DIGITOSCUENTA"
        Me.LBL4DIGITOSCUENTA.Size = New System.Drawing.Size(158, 19)
        Me.LBL4DIGITOSCUENTA.TabIndex = 73
        Me.LBL4DIGITOSCUENTA.Text = "4 DIGITOS CUENTA"
        Me.LBL4DIGITOSCUENTA.Visible = False
        '
        'TXT4DIGITOSCUENTA
        '
        Me.TXT4DIGITOSCUENTA.Location = New System.Drawing.Point(25, 65)
        Me.TXT4DIGITOSCUENTA.MaxLength = 4
        Me.TXT4DIGITOSCUENTA.Name = "TXT4DIGITOSCUENTA"
        Me.TXT4DIGITOSCUENTA.Size = New System.Drawing.Size(157, 26)
        Me.TXT4DIGITOSCUENTA.TabIndex = 72
        Me.TXT4DIGITOSCUENTA.Text = "0"
        Me.TXT4DIGITOSCUENTA.Visible = False
        '
        'LBLINSABON
        '
        Me.LBLINSABON.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INSCRIPCIONABONADABindingSource, "ABON", True))
        Me.LBLINSABON.Location = New System.Drawing.Point(351, 304)
        Me.LBLINSABON.Name = "LBLINSABON"
        Me.LBLINSABON.Size = New System.Drawing.Size(100, 23)
        Me.LBLINSABON.TabIndex = 81
        Me.LBLINSABON.Text = "INSCABON"
        '
        'INSCRIPCIONABONADABindingSource
        '
        Me.INSCRIPCIONABONADABindingSource.DataMember = "INSCRIPCIONABONADA"
        Me.INSCRIPCIONABONADABindingSource.DataSource = Me.SACDataSet
        '
        'LBLINSCLIQ
        '
        Me.LBLINSCLIQ.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INSCRIPCIONLIQUIDADABindingSource, "LIQ", True))
        Me.LBLINSCLIQ.Location = New System.Drawing.Point(337, 258)
        Me.LBLINSCLIQ.Name = "LBLINSCLIQ"
        Me.LBLINSCLIQ.Size = New System.Drawing.Size(100, 23)
        Me.LBLINSCLIQ.TabIndex = 83
        Me.LBLINSCLIQ.Text = "INSCLIQ"
        '
        'INSCRIPCIONLIQUIDADABindingSource
        '
        Me.INSCRIPCIONLIQUIDADABindingSource.DataMember = "INSCRIPCIONLIQUIDADA"
        Me.INSCRIPCIONLIQUIDADABindingSource.DataSource = Me.SACDataSet
        '
        'INSCRIPCIONABONADATableAdapter
        '
        Me.INSCRIPCIONABONADATableAdapter.ClearBeforeFill = True
        '
        'INSCRIPCIONLIQUIDADATableAdapter
        '
        Me.INSCRIPCIONLIQUIDADATableAdapter.ClearBeforeFill = True
        '
        'COBROINSCRIPCIONTableAdapter
        '
        Me.COBROINSCRIPCIONTableAdapter.ClearBeforeFill = True
        '
        'PAGODEINSCRIPCION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 337)
        Me.ControlBox = False
        Me.Controls.Add(Me.CMDIMPRIMIR)
        Me.Controls.Add(Me.LBLINSCLIQ)
        Me.Controls.Add(Me.LBLINSABON)
        Me.Controls.Add(Me.GPFECHATRANS)
        Me.Controls.Add(Me.GPFACTURACION)
        Me.Controls.Add(Me.GPBECA)
        Me.Controls.Add(Me.LBLMONTO)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBOTIPOPAGO)
        Me.Controls.Add(Me.LBLIDPRODUC)
        Me.Controls.Add(Me.LBLNONUEVOFOLIO)
        Me.Controls.Add(Me.LBLNOFOLIOMAX)
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LBLABONO)
        Me.Controls.Add(Me.LBLMONTOBASE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CMDLIQUIDAR)
        Me.Controls.Add(Me.CMDABONO)
        Me.Controls.Add(Me.LBLRESTA)
        Me.Controls.Add(Me.ComboBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "PAGODEINSCRIPCION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAGO DE INSCRIPCION"
        CType(Me.COBROINSCRIPCIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUEVORECIBOFOLIOFACTURABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPOSDEPAGOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GPBECA.ResumeLayout(False)
        Me.GPBECA.PerformLayout()
        Me.GPFECHATRANS.ResumeLayout(False)
        Me.GPFACTURACION.ResumeLayout(False)
        Me.GPFACTURACION.PerformLayout()
        CType(Me.INSCRIPCIONABONADABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INSCRIPCIONLIQUIDADABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LBLRESTA As System.Windows.Forms.Label
    Friend WithEvents CMDABONO As System.Windows.Forms.Button
    Friend WithEvents CMDLIQUIDAR As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LBLMONTOBASE As System.Windows.Forms.Label
    Friend WithEvents LBLABONO As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents CMDIMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents NUEVORECIBOFOLIOFACTURABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NUEVORECIBOFOLIOFACTURATableAdapter As SAC.SACDataSetTableAdapters.NUEVORECIBOFOLIOFACTURATableAdapter
    Friend WithEvents LBLNOFOLIOMAX As System.Windows.Forms.Label
    Friend WithEvents LBLNONUEVOFOLIO As System.Windows.Forms.Label
    Friend WithEvents LBLIDPRODUC As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBOTIPOPAGO As System.Windows.Forms.ComboBox
    Friend WithEvents TIPOSDEPAGOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TIPOSDEPAGOTableAdapter As SAC.SACDataSetTableAdapters.TIPOSDEPAGOTableAdapter
    Friend WithEvents LBLMONTO As System.Windows.Forms.Label
    Friend WithEvents GPBECA As System.Windows.Forms.GroupBox
    Friend WithEvents LBLDESCONBECA As System.Windows.Forms.Label
    Friend WithEvents LBLSCOPORBECA As System.Windows.Forms.Label
    Friend WithEvents GPFECHATRANS As System.Windows.Forms.GroupBox
    Friend WithEvents DTFECHAADMIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents GPFACTURACION As System.Windows.Forms.GroupBox
    Friend WithEvents LBL4DIGITOSCUENTA As System.Windows.Forms.Label
    Friend WithEvents TXT4DIGITOSCUENTA As System.Windows.Forms.TextBox
    Friend WithEvents LBLINSABON As System.Windows.Forms.Label
    Friend WithEvents LBLINSCLIQ As System.Windows.Forms.Label
    Friend WithEvents INSCRIPCIONABONADABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents INSCRIPCIONABONADATableAdapter As SAC.SACDataSetTableAdapters.INSCRIPCIONABONADATableAdapter
    Friend WithEvents INSCRIPCIONLIQUIDADABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents INSCRIPCIONLIQUIDADATableAdapter As SAC.SACDataSetTableAdapters.INSCRIPCIONLIQUIDADATableAdapter
    Friend WithEvents COBROINSCRIPCIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COBROINSCRIPCIONTableAdapter As SAC.SACDataSetTableAdapters.COBROINSCRIPCIONTableAdapter
End Class
