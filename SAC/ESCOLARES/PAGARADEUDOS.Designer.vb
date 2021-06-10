<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAGARADEUDOS
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
        Me.SELECCIONARADEUDOSALUMNOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARADEUDOSALUMNOTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARADEUDOSALUMNOTableAdapter()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.CBOADEUDOS = New System.Windows.Forms.ComboBox()
        Me.LBLFECHAVENCI = New System.Windows.Forms.Label()
        Me.LBLPORCENTAJE = New System.Windows.Forms.Label()
        Me.LBLABONO = New System.Windows.Forms.Label()
        Me.LBLRESTA = New System.Windows.Forms.Label()
        Me.LBLTOTAL = New System.Windows.Forms.Label()
        Me.LBLNOFOLIO = New System.Windows.Forms.Label()
        Me.LBLNORECIBO = New System.Windows.Forms.Label()
        Me.LBLNVOABONO = New System.Windows.Forms.Label()
        Me.LBLNVARESTA = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CMDLIQUIDAR = New System.Windows.Forms.Button()
        Me.CMDABONO = New System.Windows.Forms.Button()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.CMDIMPRIMIR = New System.Windows.Forms.Button()
        Me.NUEVORECIBOFOLIOFACTURABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NUEVORECIBOFOLIOFACTURATableAdapter = New SAC.SACDataSetTableAdapters.NUEVORECIBOFOLIOFACTURATableAdapter()
        Me.LBLIDPRODUC = New System.Windows.Forms.Label()
        Me.LBLNOFOLIOMAX = New System.Windows.Forms.Label()
        Me.LBLNONVOFOLIO = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LBLABONORECARG = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBOTIPOPAGO = New System.Windows.Forms.ComboBox()
        Me.TIPOSDEPAGOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIPOSDEPAGOTableAdapter = New SAC.SACDataSetTableAdapters.TIPOSDEPAGOTableAdapter()
        Me.LBL4DIGITOSCUENTA = New System.Windows.Forms.Label()
        Me.TXT4DIGITOSCUENTA = New System.Windows.Forms.TextBox()
        Me.CBFACTURA = New System.Windows.Forms.CheckBox()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARADEUDOSALUMNOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUEVORECIBOFOLIOFACTURABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPOSDEPAGOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SELECCIONARADEUDOSALUMNOBindingSource
        '
        Me.SELECCIONARADEUDOSALUMNOBindingSource.DataMember = "SELECCIONARADEUDOSALUMNO"
        Me.SELECCIONARADEUDOSALUMNOBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARADEUDOSALUMNOTableAdapter
        '
        Me.SELECCIONARADEUDOSALUMNOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CBOADEUDOS
        '
        Me.CBOADEUDOS.DataSource = Me.SELECCIONARADEUDOSALUMNOBindingSource
        Me.CBOADEUDOS.DisplayMember = "descripcion"
        Me.CBOADEUDOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOADEUDOS.FormattingEnabled = True
        Me.CBOADEUDOS.Location = New System.Drawing.Point(12, 12)
        Me.CBOADEUDOS.Name = "CBOADEUDOS"
        Me.CBOADEUDOS.Size = New System.Drawing.Size(601, 26)
        Me.CBOADEUDOS.TabIndex = 0
        Me.CBOADEUDOS.ValueMember = "idmov"
        '
        'LBLFECHAVENCI
        '
        Me.LBLFECHAVENCI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARADEUDOSALUMNOBindingSource, "fechavenci", True))
        Me.LBLFECHAVENCI.Location = New System.Drawing.Point(135, 264)
        Me.LBLFECHAVENCI.Name = "LBLFECHAVENCI"
        Me.LBLFECHAVENCI.Size = New System.Drawing.Size(100, 23)
        Me.LBLFECHAVENCI.TabIndex = 2
        Me.LBLFECHAVENCI.Text = "FECHAVENCI"
        '
        'LBLPORCENTAJE
        '
        Me.LBLPORCENTAJE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARADEUDOSALUMNOBindingSource, "porcent", True))
        Me.LBLPORCENTAJE.Location = New System.Drawing.Point(406, 264)
        Me.LBLPORCENTAJE.Name = "LBLPORCENTAJE"
        Me.LBLPORCENTAJE.Size = New System.Drawing.Size(100, 23)
        Me.LBLPORCENTAJE.TabIndex = 4
        Me.LBLPORCENTAJE.Text = "PORCENTAJE"
        '
        'LBLABONO
        '
        Me.LBLABONO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARADEUDOSALUMNOBindingSource, "abono", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.LBLABONO.Location = New System.Drawing.Point(12, 117)
        Me.LBLABONO.Name = "LBLABONO"
        Me.LBLABONO.Size = New System.Drawing.Size(100, 23)
        Me.LBLABONO.TabIndex = 6
        Me.LBLABONO.Text = "ABONO"
        '
        'LBLRESTA
        '
        Me.LBLRESTA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARADEUDOSALUMNOBindingSource, "resta", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.LBLRESTA.Location = New System.Drawing.Point(135, 117)
        Me.LBLRESTA.Name = "LBLRESTA"
        Me.LBLRESTA.Size = New System.Drawing.Size(100, 23)
        Me.LBLRESTA.TabIndex = 8
        Me.LBLRESTA.Text = "RESTA"
        '
        'LBLTOTAL
        '
        Me.LBLTOTAL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARADEUDOSALUMNOBindingSource, "total", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.LBLTOTAL.Location = New System.Drawing.Point(541, 46)
        Me.LBLTOTAL.Name = "LBLTOTAL"
        Me.LBLTOTAL.Size = New System.Drawing.Size(100, 23)
        Me.LBLTOTAL.TabIndex = 10
        Me.LBLTOTAL.Text = "TOTAL"
        '
        'LBLNOFOLIO
        '
        Me.LBLNOFOLIO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARADEUDOSALUMNOBindingSource, "numfolio", True))
        Me.LBLNOFOLIO.Location = New System.Drawing.Point(135, 44)
        Me.LBLNOFOLIO.Name = "LBLNOFOLIO"
        Me.LBLNOFOLIO.Size = New System.Drawing.Size(100, 23)
        Me.LBLNOFOLIO.TabIndex = 12
        Me.LBLNOFOLIO.Text = "NOFOLIO"
        Me.LBLNOFOLIO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLNORECIBO
        '
        Me.LBLNORECIBO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARADEUDOSALUMNOBindingSource, "numrecibo", True))
        Me.LBLNORECIBO.Location = New System.Drawing.Point(372, 46)
        Me.LBLNORECIBO.Name = "LBLNORECIBO"
        Me.LBLNORECIBO.Size = New System.Drawing.Size(100, 23)
        Me.LBLNORECIBO.TabIndex = 14
        Me.LBLNORECIBO.Text = "NORECIBO"
        '
        'LBLNVOABONO
        '
        Me.LBLNVOABONO.AutoSize = True
        Me.LBLNVOABONO.Location = New System.Drawing.Point(406, 117)
        Me.LBLNVOABONO.Name = "LBLNVOABONO"
        Me.LBLNVOABONO.Size = New System.Drawing.Size(99, 18)
        Me.LBLNVOABONO.TabIndex = 15
        Me.LBLNVOABONO.Text = "NVOABONO"
        '
        'LBLNVARESTA
        '
        Me.LBLNVARESTA.AutoSize = True
        Me.LBLNVARESTA.Location = New System.Drawing.Point(539, 117)
        Me.LBLNVARESTA.Name = "LBLNVARESTA"
        Me.LBLNVARESTA.Size = New System.Drawing.Size(92, 18)
        Me.LBLNVARESTA.TabIndex = 16
        Me.LBLNVARESTA.Text = "NVARESTA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 19)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "ABONO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "RESTANTE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(394, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 19)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "NUEVO ABONO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(539, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 19)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "RESTANTE"
        '
        'CMDLIQUIDAR
        '
        Me.CMDLIQUIDAR.Image = Global.SAC.My.Resources.Resources.Aha_Soft_Business_Toolbar_Payment
        Me.CMDLIQUIDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDLIQUIDAR.Location = New System.Drawing.Point(145, 198)
        Me.CMDLIQUIDAR.Name = "CMDLIQUIDAR"
        Me.CMDLIQUIDAR.Size = New System.Drawing.Size(100, 57)
        Me.CMDLIQUIDAR.TabIndex = 22
        Me.CMDLIQUIDAR.Text = "LIQUIDAR"
        Me.CMDLIQUIDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDLIQUIDAR.UseVisualStyleBackColor = True
        '
        'CMDABONO
        '
        Me.CMDABONO.Image = Global.SAC.My.Resources.Resources.Aha_Soft_Business_Toolbar_Payment
        Me.CMDABONO.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDABONO.Location = New System.Drawing.Point(39, 198)
        Me.CMDABONO.Name = "CMDABONO"
        Me.CMDABONO.Size = New System.Drawing.Size(100, 57)
        Me.CMDABONO.TabIndex = 21
        Me.CMDABONO.Text = "ABONO"
        Me.CMDABONO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDABONO.UseVisualStyleBackColor = True
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Image = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR.Location = New System.Drawing.Point(504, 198)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(100, 57)
        Me.CMDCANCELAR.TabIndex = 44
        Me.CMDCANCELAR.Text = "CERRAR"
        Me.CMDCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'CMDIMPRIMIR
        '
        Me.CMDIMPRIMIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDIMPRIMIR.Image = Global.SAC.My.Resources.Resources.PRINTER
        Me.CMDIMPRIMIR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDIMPRIMIR.Location = New System.Drawing.Point(398, 198)
        Me.CMDIMPRIMIR.Name = "CMDIMPRIMIR"
        Me.CMDIMPRIMIR.Size = New System.Drawing.Size(100, 57)
        Me.CMDIMPRIMIR.TabIndex = 43
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
        'LBLIDPRODUC
        '
        Me.LBLIDPRODUC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARADEUDOSALUMNOBindingSource, "idproduc", True))
        Me.LBLIDPRODUC.Location = New System.Drawing.Point(275, 232)
        Me.LBLIDPRODUC.Name = "LBLIDPRODUC"
        Me.LBLIDPRODUC.Size = New System.Drawing.Size(100, 23)
        Me.LBLIDPRODUC.TabIndex = 45
        Me.LBLIDPRODUC.Text = "IDPRODUC"
        '
        'LBLNOFOLIOMAX
        '
        Me.LBLNOFOLIOMAX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NUEVORECIBOFOLIOFACTURABindingSource, "NOFOLIO", True))
        Me.LBLNOFOLIOMAX.Location = New System.Drawing.Point(517, 258)
        Me.LBLNOFOLIOMAX.Name = "LBLNOFOLIOMAX"
        Me.LBLNOFOLIOMAX.Size = New System.Drawing.Size(124, 23)
        Me.LBLNOFOLIOMAX.TabIndex = 46
        Me.LBLNOFOLIOMAX.Text = "NOFOLIOMAX"
        '
        'LBLNONVOFOLIO
        '
        Me.LBLNONVOFOLIO.AutoSize = True
        Me.LBLNONVOFOLIO.Location = New System.Drawing.Point(276, 198)
        Me.LBLNONVOFOLIO.Name = "LBLNONVOFOLIO"
        Me.LBLNONVOFOLIO.Size = New System.Drawing.Size(88, 18)
        Me.LBLNONVOFOLIO.TabIndex = 47
        Me.LBLNONVOFOLIO.Text = "NVOFOLIO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 18)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "FOLIO ACTUAL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(242, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 18)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "RECIBO ACTUAL"
        '
        'LBLABONORECARG
        '
        Me.LBLABONORECARG.AutoSize = True
        Me.LBLABONORECARG.Location = New System.Drawing.Point(6, 264)
        Me.LBLABONORECARG.Name = "LBLABONORECARG"
        Me.LBLABONORECARG.Size = New System.Drawing.Size(133, 18)
        Me.LBLABONORECARG.TabIndex = 58
        Me.LBLABONORECARG.Text = "ABONORECARG"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(242, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 19)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "TIPO DE PAGO"
        '
        'CBOTIPOPAGO
        '
        Me.CBOTIPOPAGO.DataSource = Me.TIPOSDEPAGOBindingSource
        Me.CBOTIPOPAGO.DisplayMember = "tipopago"
        Me.CBOTIPOPAGO.FormattingEnabled = True
        Me.CBOTIPOPAGO.Location = New System.Drawing.Point(231, 109)
        Me.CBOTIPOPAGO.Name = "CBOTIPOPAGO"
        Me.CBOTIPOPAGO.Size = New System.Drawing.Size(144, 26)
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
        'LBL4DIGITOSCUENTA
        '
        Me.LBL4DIGITOSCUENTA.AutoSize = True
        Me.LBL4DIGITOSCUENTA.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL4DIGITOSCUENTA.Location = New System.Drawing.Point(277, 163)
        Me.LBL4DIGITOSCUENTA.Name = "LBL4DIGITOSCUENTA"
        Me.LBL4DIGITOSCUENTA.Size = New System.Drawing.Size(158, 19)
        Me.LBL4DIGITOSCUENTA.TabIndex = 76
        Me.LBL4DIGITOSCUENTA.Text = "4 DIGITOS CUENTA"
        Me.LBL4DIGITOSCUENTA.Visible = False
        '
        'TXT4DIGITOSCUENTA
        '
        Me.TXT4DIGITOSCUENTA.Location = New System.Drawing.Point(441, 160)
        Me.TXT4DIGITOSCUENTA.MaxLength = 4
        Me.TXT4DIGITOSCUENTA.Name = "TXT4DIGITOSCUENTA"
        Me.TXT4DIGITOSCUENTA.Size = New System.Drawing.Size(157, 26)
        Me.TXT4DIGITOSCUENTA.TabIndex = 75
        Me.TXT4DIGITOSCUENTA.Visible = False
        '
        'CBFACTURA
        '
        Me.CBFACTURA.AutoSize = True
        Me.CBFACTURA.Location = New System.Drawing.Point(63, 160)
        Me.CBFACTURA.Name = "CBFACTURA"
        Me.CBFACTURA.Size = New System.Drawing.Size(186, 22)
        Me.CBFACTURA.TabIndex = 74
        Me.CBFACTURA.Text = "REQUIERE FACTURA"
        Me.CBFACTURA.UseVisualStyleBackColor = True
        Me.CBFACTURA.Visible = False
        '
        'PAGARADEUDOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 284)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBL4DIGITOSCUENTA)
        Me.Controls.Add(Me.TXT4DIGITOSCUENTA)
        Me.Controls.Add(Me.CBFACTURA)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CBOTIPOPAGO)
        Me.Controls.Add(Me.LBLABONORECARG)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LBLNONVOFOLIO)
        Me.Controls.Add(Me.LBLNOFOLIOMAX)
        Me.Controls.Add(Me.LBLIDPRODUC)
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.CMDIMPRIMIR)
        Me.Controls.Add(Me.CMDLIQUIDAR)
        Me.Controls.Add(Me.CMDABONO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBLNVARESTA)
        Me.Controls.Add(Me.LBLNVOABONO)
        Me.Controls.Add(Me.LBLNORECIBO)
        Me.Controls.Add(Me.LBLNOFOLIO)
        Me.Controls.Add(Me.LBLTOTAL)
        Me.Controls.Add(Me.LBLRESTA)
        Me.Controls.Add(Me.LBLABONO)
        Me.Controls.Add(Me.LBLPORCENTAJE)
        Me.Controls.Add(Me.LBLFECHAVENCI)
        Me.Controls.Add(Me.CBOADEUDOS)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PAGARADEUDOS"
        Me.Text = "PAGAR ADEUDOS"
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARADEUDOSALUMNOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUEVORECIBOFOLIOFACTURABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPOSDEPAGOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents SELECCIONARADEUDOSALUMNOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARADEUDOSALUMNOTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARADEUDOSALUMNOTableAdapter
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CBOADEUDOS As System.Windows.Forms.ComboBox
    Friend WithEvents LBLFECHAVENCI As System.Windows.Forms.Label
    Friend WithEvents LBLPORCENTAJE As System.Windows.Forms.Label
    Friend WithEvents LBLABONO As System.Windows.Forms.Label
    Friend WithEvents LBLRESTA As System.Windows.Forms.Label
    Friend WithEvents LBLTOTAL As System.Windows.Forms.Label
    Friend WithEvents LBLNOFOLIO As System.Windows.Forms.Label
    Friend WithEvents LBLNORECIBO As System.Windows.Forms.Label
    Friend WithEvents LBLNVOABONO As System.Windows.Forms.Label
    Friend WithEvents LBLNVARESTA As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CMDLIQUIDAR As System.Windows.Forms.Button
    Friend WithEvents CMDABONO As System.Windows.Forms.Button
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents CMDIMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents NUEVORECIBOFOLIOFACTURABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NUEVORECIBOFOLIOFACTURATableAdapter As SAC.SACDataSetTableAdapters.NUEVORECIBOFOLIOFACTURATableAdapter
    Friend WithEvents LBLIDPRODUC As System.Windows.Forms.Label
    Friend WithEvents LBLNOFOLIOMAX As System.Windows.Forms.Label
    Friend WithEvents LBLNONVOFOLIO As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LBLABONORECARG As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CBOTIPOPAGO As System.Windows.Forms.ComboBox
    Friend WithEvents TIPOSDEPAGOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TIPOSDEPAGOTableAdapter As SAC.SACDataSetTableAdapters.TIPOSDEPAGOTableAdapter
    Friend WithEvents LBL4DIGITOSCUENTA As System.Windows.Forms.Label
    Friend WithEvents TXT4DIGITOSCUENTA As System.Windows.Forms.TextBox
    Friend WithEvents CBFACTURA As System.Windows.Forms.CheckBox
End Class
