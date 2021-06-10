<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REINSCRIPCION
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim AppatLabel As System.Windows.Forms.Label
        Dim ApmatLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim LugnacLabel As System.Windows.Forms.Label
        Dim CurpLabel As System.Windows.Forms.Label
        Dim DompartLabel As System.Windows.Forms.Label
        Dim TelcelLabel As System.Windows.Forms.Label
        Dim TelcasaLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim DiaLabel As System.Windows.Forms.Label
        Dim MesLabel As System.Windows.Forms.Label
        Dim AñoLabel As System.Windows.Forms.Label
        Me.CBOALUMNO = New System.Windows.Forms.ComboBox()
        Me.SELECCIONARALUMNOSINACTIVOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SACDataSet = New SAC.SACDataSet()
        Me.CBOESCOLARIDAD = New System.Windows.Forms.ComboBox()
        Me.SELECCIONARESCOLARIDADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.SELECCIONARESCOLARIDADTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARESCOLARIDADTableAdapter()
        Me.SELECCIONARALUMNOSINACTIVOSTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARALUMNOSINACTIVOSTableAdapter()
        Me.SELECCIONARALUMNOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARALUMNOTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARALUMNOTableAdapter()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.AppatTextBox = New System.Windows.Forms.TextBox()
        Me.ApmatTextBox = New System.Windows.Forms.TextBox()
        Me.SexoTextBox = New System.Windows.Forms.TextBox()
        Me.LugnacTextBox = New System.Windows.Forms.TextBox()
        Me.CurpTextBox = New System.Windows.Forms.TextBox()
        Me.DompartTextBox = New System.Windows.Forms.TextBox()
        Me.TelcelTextBox = New System.Windows.Forms.TextBox()
        Me.TelcasaTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.MatriLabel1 = New System.Windows.Forms.Label()
        Me.DiaTextBox = New System.Windows.Forms.TextBox()
        Me.MesTextBox = New System.Windows.Forms.TextBox()
        Me.AñoTextBox = New System.Windows.Forms.TextBox()
        Me.LBLMENSAJE = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.CMDREINSCRIBIR = New System.Windows.Forms.Button()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.ReprobadoCheckBox = New System.Windows.Forms.CheckBox()
        NombreLabel = New System.Windows.Forms.Label()
        AppatLabel = New System.Windows.Forms.Label()
        ApmatLabel = New System.Windows.Forms.Label()
        SexoLabel = New System.Windows.Forms.Label()
        LugnacLabel = New System.Windows.Forms.Label()
        CurpLabel = New System.Windows.Forms.Label()
        DompartLabel = New System.Windows.Forms.Label()
        TelcelLabel = New System.Windows.Forms.Label()
        TelcasaLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        DiaLabel = New System.Windows.Forms.Label()
        MesLabel = New System.Windows.Forms.Label()
        AñoLabel = New System.Windows.Forms.Label()
        CType(Me.SELECCIONARALUMNOSINACTIVOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARESCOLARIDADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARALUMNOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(12, 72)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(81, 18)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "NOMBRE:"
        '
        'AppatLabel
        '
        AppatLabel.AutoSize = True
        AppatLabel.Location = New System.Drawing.Point(315, 72)
        AppatLabel.Name = "AppatLabel"
        AppatLabel.Size = New System.Drawing.Size(110, 18)
        AppatLabel.TabIndex = 5
        AppatLabel.Text = "AP. PATERNO"
        '
        'ApmatLabel
        '
        ApmatLabel.AutoSize = True
        ApmatLabel.Location = New System.Drawing.Point(655, 72)
        ApmatLabel.Name = "ApmatLabel"
        ApmatLabel.Size = New System.Drawing.Size(113, 18)
        ApmatLabel.TabIndex = 7
        ApmatLabel.Text = "AP. MATERNO"
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Location = New System.Drawing.Point(515, 114)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(53, 18)
        SexoLabel.TabIndex = 9
        SexoLabel.Text = "SEXO"
        '
        'LugnacLabel
        '
        LugnacLabel.AutoSize = True
        LugnacLabel.Location = New System.Drawing.Point(15, 155)
        LugnacLabel.Name = "LugnacLabel"
        LugnacLabel.Size = New System.Drawing.Size(100, 18)
        LugnacLabel.TabIndex = 11
        LugnacLabel.Text = "LUGAR NAC"
        '
        'CurpLabel
        '
        CurpLabel.AutoSize = True
        CurpLabel.Location = New System.Drawing.Point(344, 155)
        CurpLabel.Name = "CurpLabel"
        CurpLabel.Size = New System.Drawing.Size(53, 18)
        CurpLabel.TabIndex = 13
        CurpLabel.Text = "CURP"
        '
        'DompartLabel
        '
        DompartLabel.AutoSize = True
        DompartLabel.Location = New System.Drawing.Point(10, 234)
        DompartLabel.Name = "DompartLabel"
        DompartLabel.Size = New System.Drawing.Size(147, 18)
        DompartLabel.TabIndex = 15
        DompartLabel.Text = "DOM PARTICULAR"
        '
        'TelcelLabel
        '
        TelcelLabel.AutoSize = True
        TelcelLabel.Location = New System.Drawing.Point(15, 196)
        TelcelLabel.Name = "TelcelLabel"
        TelcelLabel.Size = New System.Drawing.Size(72, 18)
        TelcelLabel.TabIndex = 17
        TelcelLabel.Text = "TEL CEL"
        '
        'TelcasaLabel
        '
        TelcasaLabel.AutoSize = True
        TelcasaLabel.Location = New System.Drawing.Point(664, 155)
        TelcasaLabel.Name = "TelcasaLabel"
        TelcasaLabel.Size = New System.Drawing.Size(85, 18)
        TelcasaLabel.TabIndex = 19
        TelcasaLabel.Text = "TEL CASA"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(269, 196)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(55, 18)
        EmailLabel.TabIndex = 21
        EmailLabel.Text = "EMAIL"
        '
        'DiaLabel
        '
        DiaLabel.AutoSize = True
        DiaLabel.Location = New System.Drawing.Point(12, 114)
        DiaLabel.Name = "DiaLabel"
        DiaLabel.Size = New System.Drawing.Size(34, 18)
        DiaLabel.TabIndex = 25
        DiaLabel.Text = "DIA"
        '
        'MesLabel
        '
        MesLabel.AutoSize = True
        MesLabel.Location = New System.Drawing.Point(160, 114)
        MesLabel.Name = "MesLabel"
        MesLabel.Size = New System.Drawing.Size(43, 18)
        MesLabel.TabIndex = 27
        MesLabel.Text = "MES"
        '
        'AñoLabel
        '
        AñoLabel.AutoSize = True
        AñoLabel.Location = New System.Drawing.Point(361, 114)
        AñoLabel.Name = "AñoLabel"
        AñoLabel.Size = New System.Drawing.Size(42, 18)
        AñoLabel.TabIndex = 29
        AñoLabel.Text = "AÑO"
        '
        'CBOALUMNO
        '
        Me.CBOALUMNO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CBOALUMNO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBOALUMNO.DataSource = Me.SELECCIONARALUMNOSINACTIVOSBindingSource
        Me.CBOALUMNO.DisplayMember = "ALUMNO"
        Me.CBOALUMNO.FormattingEnabled = True
        Me.CBOALUMNO.Location = New System.Drawing.Point(121, 12)
        Me.CBOALUMNO.Name = "CBOALUMNO"
        Me.CBOALUMNO.Size = New System.Drawing.Size(540, 26)
        Me.CBOALUMNO.TabIndex = 0
        Me.CBOALUMNO.ValueMember = "matri"
        '
        'SELECCIONARALUMNOSINACTIVOSBindingSource
        '
        Me.SELECCIONARALUMNOSINACTIVOSBindingSource.DataMember = "SELECCIONARALUMNOSINACTIVOS"
        Me.SELECCIONARALUMNOSINACTIVOSBindingSource.DataSource = Me.SACDataSet
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
        Me.CBOESCOLARIDAD.Location = New System.Drawing.Point(667, 12)
        Me.CBOESCOLARIDAD.Name = "CBOESCOLARIDAD"
        Me.CBOESCOLARIDAD.Size = New System.Drawing.Size(162, 26)
        Me.CBOESCOLARIDAD.TabIndex = 1
        Me.CBOESCOLARIDAD.ValueMember = "escolaridad"
        '
        'SELECCIONARESCOLARIDADBindingSource
        '
        Me.SELECCIONARESCOLARIDADBindingSource.DataMember = "SELECCIONARESCOLARIDAD"
        Me.SELECCIONARESCOLARIDADBindingSource.DataSource = Me.SACDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SELECCIONARESCOLARIDADTableAdapter
        '
        Me.SELECCIONARESCOLARIDADTableAdapter.ClearBeforeFill = True
        '
        'SELECCIONARALUMNOSINACTIVOSTableAdapter
        '
        Me.SELECCIONARALUMNOSINACTIVOSTableAdapter.ClearBeforeFill = True
        '
        'SELECCIONARALUMNOBindingSource
        '
        Me.SELECCIONARALUMNOBindingSource.DataMember = "SELECCIONARALUMNO"
        Me.SELECCIONARALUMNOBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARALUMNOTableAdapter
        '
        Me.SELECCIONARALUMNOTableAdapter.ClearBeforeFill = True
        '
        'NombreTextBox
        '
        Me.NombreTextBox.BackColor = System.Drawing.Color.Gold
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(97, 69)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.ReadOnly = True
        Me.NombreTextBox.Size = New System.Drawing.Size(212, 26)
        Me.NombreTextBox.TabIndex = 4
        '
        'AppatTextBox
        '
        Me.AppatTextBox.BackColor = System.Drawing.Color.Gold
        Me.AppatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "appat", True))
        Me.AppatTextBox.Location = New System.Drawing.Point(431, 69)
        Me.AppatTextBox.Name = "AppatTextBox"
        Me.AppatTextBox.ReadOnly = True
        Me.AppatTextBox.Size = New System.Drawing.Size(218, 26)
        Me.AppatTextBox.TabIndex = 6
        '
        'ApmatTextBox
        '
        Me.ApmatTextBox.BackColor = System.Drawing.Color.Gold
        Me.ApmatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "apmat", True))
        Me.ApmatTextBox.Location = New System.Drawing.Point(774, 69)
        Me.ApmatTextBox.Name = "ApmatTextBox"
        Me.ApmatTextBox.ReadOnly = True
        Me.ApmatTextBox.Size = New System.Drawing.Size(199, 26)
        Me.ApmatTextBox.TabIndex = 8
        '
        'SexoTextBox
        '
        Me.SexoTextBox.BackColor = System.Drawing.Color.Gold
        Me.SexoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "sexo", True))
        Me.SexoTextBox.Location = New System.Drawing.Point(572, 111)
        Me.SexoTextBox.Name = "SexoTextBox"
        Me.SexoTextBox.ReadOnly = True
        Me.SexoTextBox.Size = New System.Drawing.Size(180, 26)
        Me.SexoTextBox.TabIndex = 10
        '
        'LugnacTextBox
        '
        Me.LugnacTextBox.BackColor = System.Drawing.Color.Gold
        Me.LugnacTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "lugnac", True))
        Me.LugnacTextBox.Location = New System.Drawing.Point(121, 152)
        Me.LugnacTextBox.Name = "LugnacTextBox"
        Me.LugnacTextBox.ReadOnly = True
        Me.LugnacTextBox.Size = New System.Drawing.Size(203, 26)
        Me.LugnacTextBox.TabIndex = 12
        '
        'CurpTextBox
        '
        Me.CurpTextBox.BackColor = System.Drawing.Color.Gold
        Me.CurpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "curp", True))
        Me.CurpTextBox.Location = New System.Drawing.Point(403, 152)
        Me.CurpTextBox.Name = "CurpTextBox"
        Me.CurpTextBox.ReadOnly = True
        Me.CurpTextBox.Size = New System.Drawing.Size(250, 26)
        Me.CurpTextBox.TabIndex = 14
        '
        'DompartTextBox
        '
        Me.DompartTextBox.BackColor = System.Drawing.Color.Gold
        Me.DompartTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "dompart", True))
        Me.DompartTextBox.Location = New System.Drawing.Point(163, 231)
        Me.DompartTextBox.Name = "DompartTextBox"
        Me.DompartTextBox.ReadOnly = True
        Me.DompartTextBox.Size = New System.Drawing.Size(722, 26)
        Me.DompartTextBox.TabIndex = 16
        '
        'TelcelTextBox
        '
        Me.TelcelTextBox.BackColor = System.Drawing.Color.Gold
        Me.TelcelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "telcel", True))
        Me.TelcelTextBox.Location = New System.Drawing.Point(91, 193)
        Me.TelcelTextBox.Name = "TelcelTextBox"
        Me.TelcelTextBox.ReadOnly = True
        Me.TelcelTextBox.Size = New System.Drawing.Size(162, 26)
        Me.TelcelTextBox.TabIndex = 18
        '
        'TelcasaTextBox
        '
        Me.TelcasaTextBox.BackColor = System.Drawing.Color.Gold
        Me.TelcasaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "telcasa", True))
        Me.TelcasaTextBox.Location = New System.Drawing.Point(755, 152)
        Me.TelcasaTextBox.Name = "TelcasaTextBox"
        Me.TelcasaTextBox.ReadOnly = True
        Me.TelcasaTextBox.Size = New System.Drawing.Size(203, 26)
        Me.TelcasaTextBox.TabIndex = 20
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.Color.Gold
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(330, 193)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.ReadOnly = True
        Me.EmailTextBox.Size = New System.Drawing.Size(273, 26)
        Me.EmailTextBox.TabIndex = 22
        '
        'MatriLabel1
        '
        Me.MatriLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "matri", True))
        Me.MatriLabel1.Location = New System.Drawing.Point(1, 0)
        Me.MatriLabel1.Name = "MatriLabel1"
        Me.MatriLabel1.Size = New System.Drawing.Size(100, 23)
        Me.MatriLabel1.TabIndex = 24
        Me.MatriLabel1.Text = "Label1"
        '
        'DiaTextBox
        '
        Me.DiaTextBox.BackColor = System.Drawing.Color.Gold
        Me.DiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "dia", True))
        Me.DiaTextBox.Location = New System.Drawing.Point(52, 111)
        Me.DiaTextBox.Name = "DiaTextBox"
        Me.DiaTextBox.ReadOnly = True
        Me.DiaTextBox.Size = New System.Drawing.Size(100, 26)
        Me.DiaTextBox.TabIndex = 26
        '
        'MesTextBox
        '
        Me.MesTextBox.BackColor = System.Drawing.Color.Gold
        Me.MesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "mes", True))
        Me.MesTextBox.Location = New System.Drawing.Point(206, 111)
        Me.MesTextBox.Name = "MesTextBox"
        Me.MesTextBox.ReadOnly = True
        Me.MesTextBox.Size = New System.Drawing.Size(149, 26)
        Me.MesTextBox.TabIndex = 28
        '
        'AñoTextBox
        '
        Me.AñoTextBox.BackColor = System.Drawing.Color.Gold
        Me.AñoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "año", True))
        Me.AñoTextBox.Location = New System.Drawing.Point(409, 111)
        Me.AñoTextBox.Name = "AñoTextBox"
        Me.AñoTextBox.ReadOnly = True
        Me.AñoTextBox.Size = New System.Drawing.Size(100, 26)
        Me.AñoTextBox.TabIndex = 30
        '
        'LBLMENSAJE
        '
        Me.LBLMENSAJE.Location = New System.Drawing.Point(15, 260)
        Me.LBLMENSAJE.Name = "LBLMENSAJE"
        Me.LBLMENSAJE.Size = New System.Drawing.Size(962, 43)
        Me.LBLMENSAJE.TabIndex = 31
        Me.LBLMENSAJE.Text = "IR A EDICION Y RELLENAR LOS CAMPOS FALTANTES"
        Me.LBLMENSAJE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'CMDREINSCRIBIR
        '
        Me.CMDREINSCRIBIR.BackgroundImage = Global.SAC.My.Resources.Resources.GUARDAR_REGISTRO1
        Me.CMDREINSCRIBIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDREINSCRIBIR.Location = New System.Drawing.Point(453, 306)
        Me.CMDREINSCRIBIR.Name = "CMDREINSCRIBIR"
        Me.CMDREINSCRIBIR.Size = New System.Drawing.Size(44, 40)
        Me.CMDREINSCRIBIR.TabIndex = 33
        Me.CMDREINSCRIBIR.UseVisualStyleBackColor = True
        Me.CMDREINSCRIBIR.Visible = False
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImage = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Location = New System.Drawing.Point(503, 306)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(42, 40)
        Me.CMDCANCELAR.TabIndex = 36
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'ReprobadoCheckBox
        '
        Me.ReprobadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SELECCIONARALUMNOBindingSource, "reprobado", True))
        Me.ReprobadoCheckBox.Location = New System.Drawing.Point(4, 26)
        Me.ReprobadoCheckBox.Name = "ReprobadoCheckBox"
        Me.ReprobadoCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ReprobadoCheckBox.TabIndex = 37
        Me.ReprobadoCheckBox.Text = "CheckBox1"
        Me.ReprobadoCheckBox.UseVisualStyleBackColor = True
        '
        'REINSCRIPCION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 366)
        Me.ControlBox = False
        Me.Controls.Add(Me.ReprobadoCheckBox)
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.CMDREINSCRIBIR)
        Me.Controls.Add(Me.LBLMENSAJE)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(AppatLabel)
        Me.Controls.Add(Me.AppatTextBox)
        Me.Controls.Add(ApmatLabel)
        Me.Controls.Add(Me.ApmatTextBox)
        Me.Controls.Add(SexoLabel)
        Me.Controls.Add(Me.SexoTextBox)
        Me.Controls.Add(LugnacLabel)
        Me.Controls.Add(Me.LugnacTextBox)
        Me.Controls.Add(CurpLabel)
        Me.Controls.Add(Me.CurpTextBox)
        Me.Controls.Add(DompartLabel)
        Me.Controls.Add(Me.DompartTextBox)
        Me.Controls.Add(TelcelLabel)
        Me.Controls.Add(Me.TelcelTextBox)
        Me.Controls.Add(TelcasaLabel)
        Me.Controls.Add(Me.TelcasaTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.MatriLabel1)
        Me.Controls.Add(DiaLabel)
        Me.Controls.Add(Me.DiaTextBox)
        Me.Controls.Add(MesLabel)
        Me.Controls.Add(Me.MesTextBox)
        Me.Controls.Add(AñoLabel)
        Me.Controls.Add(Me.AñoTextBox)
        Me.Controls.Add(Me.CBOESCOLARIDAD)
        Me.Controls.Add(Me.CBOALUMNO)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "REINSCRIPCION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REINSCRIPCION"
        CType(Me.SELECCIONARALUMNOSINACTIVOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARESCOLARIDADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARALUMNOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CBOALUMNO As System.Windows.Forms.ComboBox
    Friend WithEvents CBOESCOLARIDAD As System.Windows.Forms.ComboBox
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents SELECCIONARESCOLARIDADBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARESCOLARIDADTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARESCOLARIDADTableAdapter
    Friend WithEvents SELECCIONARALUMNOSINACTIVOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARALUMNOSINACTIVOSTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARALUMNOSINACTIVOSTableAdapter
    Friend WithEvents SELECCIONARALUMNOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARALUMNOTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARALUMNOTableAdapter
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AppatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApmatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SexoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LugnacTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CurpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DompartTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelcelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelcasaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MatriLabel1 As System.Windows.Forms.Label
    Friend WithEvents DiaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AñoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LBLMENSAJE As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents CMDREINSCRIBIR As System.Windows.Forms.Button
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents ReprobadoCheckBox As System.Windows.Forms.CheckBox
End Class
