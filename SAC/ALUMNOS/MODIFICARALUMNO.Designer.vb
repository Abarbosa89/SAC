<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MODIFICARALUMNO
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
        Dim FecnacLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim LugnacLabel As System.Windows.Forms.Label
        Dim CurpLabel As System.Windows.Forms.Label
        Dim DompartLabel As System.Windows.Forms.Label
        Dim TelcelLabel As System.Windows.Forms.Label
        Dim TelcasaLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim ActivoLabel As System.Windows.Forms.Label
        Me.CBOALUMNO = New System.Windows.Forms.ComboBox()
        Me.SACDataSet = New SAC.SACDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.SELECCIONARALUMNOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppatTextBox = New System.Windows.Forms.TextBox()
        Me.ApmatTextBox = New System.Windows.Forms.TextBox()
        Me.SexoTextBox = New System.Windows.Forms.TextBox()
        Me.LugnacTextBox = New System.Windows.Forms.TextBox()
        Me.CurpTextBox = New System.Windows.Forms.TextBox()
        Me.DompartTextBox = New System.Windows.Forms.TextBox()
        Me.TelcelTextBox = New System.Windows.Forms.TextBox()
        Me.TelcasaTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.GPDATOSPERS = New System.Windows.Forms.GroupBox()
        Me.TXTAÑO = New System.Windows.Forms.TextBox()
        Me.TXTMES = New System.Windows.Forms.TextBox()
        Me.TXTDIA = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CMDEDITAR1 = New System.Windows.Forms.Button()
        Me.GPOTROSDATO = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ActivoCheckBox = New System.Windows.Forms.CheckBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.CMDGUARDAR = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.CBOESCOLARIDAD = New System.Windows.Forms.ComboBox()
        Me.SELECCIONARESCOLARIDADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARESCOLARIDADTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARESCOLARIDADTableAdapter()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.SELECCIONARALUMNOTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARALUMNOTableAdapter()
        Me.SELECCIONARALUMNOSACTIVOSYINACTIVOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARALUMNOSACTIVOSYINACTIVOSTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARALUMNOSACTIVOSYINACTIVOSTableAdapter()
        NombreLabel = New System.Windows.Forms.Label()
        AppatLabel = New System.Windows.Forms.Label()
        ApmatLabel = New System.Windows.Forms.Label()
        FecnacLabel = New System.Windows.Forms.Label()
        SexoLabel = New System.Windows.Forms.Label()
        LugnacLabel = New System.Windows.Forms.Label()
        CurpLabel = New System.Windows.Forms.Label()
        DompartLabel = New System.Windows.Forms.Label()
        TelcelLabel = New System.Windows.Forms.Label()
        TelcasaLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        ActivoLabel = New System.Windows.Forms.Label()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARALUMNOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPDATOSPERS.SuspendLayout()
        Me.GPOTROSDATO.SuspendLayout()
        CType(Me.SELECCIONARESCOLARIDADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARALUMNOSACTIVOSYINACTIVOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(104, 21)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(87, 19)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "NOMBRE:"
        '
        'AppatLabel
        '
        AppatLabel.AutoSize = True
        AppatLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AppatLabel.Location = New System.Drawing.Point(17, 53)
        AppatLabel.Name = "AppatLabel"
        AppatLabel.Size = New System.Drawing.Size(177, 19)
        AppatLabel.TabIndex = 5
        AppatLabel.Text = "APELLIDO PATERNO:"
        '
        'ApmatLabel
        '
        ApmatLabel.AutoSize = True
        ApmatLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApmatLabel.Location = New System.Drawing.Point(14, 86)
        ApmatLabel.Name = "ApmatLabel"
        ApmatLabel.Size = New System.Drawing.Size(180, 19)
        ApmatLabel.TabIndex = 7
        ApmatLabel.Text = "APELLIDO MATERNO:"
        '
        'FecnacLabel
        '
        FecnacLabel.AutoSize = True
        FecnacLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FecnacLabel.Location = New System.Drawing.Point(61, 118)
        FecnacLabel.Name = "FecnacLabel"
        FecnacLabel.Size = New System.Drawing.Size(132, 19)
        FecnacLabel.TabIndex = 9
        FecnacLabel.Text = "F. NACIMIENTO:"
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SexoLabel.Location = New System.Drawing.Point(128, 148)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(60, 19)
        SexoLabel.TabIndex = 11
        SexoLabel.Text = "SEXO:"
        '
        'LugnacLabel
        '
        LugnacLabel.AutoSize = True
        LugnacLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LugnacLabel.Location = New System.Drawing.Point(40, 22)
        LugnacLabel.Name = "LugnacLabel"
        LugnacLabel.Size = New System.Drawing.Size(128, 19)
        LugnacLabel.TabIndex = 13
        LugnacLabel.Text = "L. NACIMIENTO"
        '
        'CurpLabel
        '
        CurpLabel.AutoSize = True
        CurpLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CurpLabel.Location = New System.Drawing.Point(104, 51)
        CurpLabel.Name = "CurpLabel"
        CurpLabel.Size = New System.Drawing.Size(62, 19)
        CurpLabel.TabIndex = 15
        CurpLabel.Text = "CURP:"
        '
        'DompartLabel
        '
        DompartLabel.AutoSize = True
        DompartLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DompartLabel.Location = New System.Drawing.Point(10, 83)
        DompartLabel.Name = "DompartLabel"
        DompartLabel.Size = New System.Drawing.Size(158, 19)
        DompartLabel.TabIndex = 17
        DompartLabel.Text = "DOM. PARTICULAR"
        '
        'TelcelLabel
        '
        TelcelLabel.AutoSize = True
        TelcelLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelcelLabel.Location = New System.Drawing.Point(42, 118)
        TelcelLabel.Name = "TelcelLabel"
        TelcelLabel.Size = New System.Drawing.Size(126, 19)
        TelcelLabel.TabIndex = 19
        TelcelLabel.Text = "TEL. CELULAR"
        '
        'TelcasaLabel
        '
        TelcasaLabel.AutoSize = True
        TelcasaLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelcasaLabel.Location = New System.Drawing.Point(71, 150)
        TelcasaLabel.Name = "TelcasaLabel"
        TelcasaLabel.Size = New System.Drawing.Size(93, 19)
        TelcasaLabel.TabIndex = 21
        TelcasaLabel.Text = "TEL. CASA"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(102, 182)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(64, 19)
        EmailLabel.TabIndex = 23
        EmailLabel.Text = "EMAIL:"
        '
        'ActivoLabel
        '
        ActivoLabel.AutoSize = True
        ActivoLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ActivoLabel.Location = New System.Drawing.Point(99, 215)
        ActivoLabel.Name = "ActivoLabel"
        ActivoLabel.Size = New System.Drawing.Size(69, 19)
        ActivoLabel.TabIndex = 43
        ActivoLabel.Text = "ACTIVO"
        '
        'CBOALUMNO
        '
        Me.CBOALUMNO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBOALUMNO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBOALUMNO.DataSource = Me.SELECCIONARALUMNOSACTIVOSYINACTIVOSBindingSource
        Me.CBOALUMNO.DisplayMember = "ALUMNO"
        Me.CBOALUMNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOALUMNO.FormattingEnabled = True
        Me.CBOALUMNO.Location = New System.Drawing.Point(58, 37)
        Me.CBOALUMNO.Name = "CBOALUMNO"
        Me.CBOALUMNO.Size = New System.Drawing.Size(584, 26)
        Me.CBOALUMNO.TabIndex = 0
        Me.CBOALUMNO.ValueMember = "matri"
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SELECCIONE AL ALUMNO"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.BackColor = System.Drawing.Color.Gold
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(198, 17)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.ReadOnly = True
        Me.NombreTextBox.Size = New System.Drawing.Size(246, 26)
        Me.NombreTextBox.TabIndex = 4
        '
        'SELECCIONARALUMNOBindingSource
        '
        Me.SELECCIONARALUMNOBindingSource.DataMember = "SELECCIONARALUMNO"
        Me.SELECCIONARALUMNOBindingSource.DataSource = Me.SACDataSet
        '
        'AppatTextBox
        '
        Me.AppatTextBox.BackColor = System.Drawing.Color.Gold
        Me.AppatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "appat", True))
        Me.AppatTextBox.Location = New System.Drawing.Point(198, 49)
        Me.AppatTextBox.Name = "AppatTextBox"
        Me.AppatTextBox.ReadOnly = True
        Me.AppatTextBox.Size = New System.Drawing.Size(246, 26)
        Me.AppatTextBox.TabIndex = 6
        '
        'ApmatTextBox
        '
        Me.ApmatTextBox.BackColor = System.Drawing.Color.Gold
        Me.ApmatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.SELECCIONARALUMNOBindingSource, "apmat", True))
        Me.ApmatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "apmat", True))
        Me.ApmatTextBox.Location = New System.Drawing.Point(198, 81)
        Me.ApmatTextBox.Name = "ApmatTextBox"
        Me.ApmatTextBox.ReadOnly = True
        Me.ApmatTextBox.Size = New System.Drawing.Size(246, 26)
        Me.ApmatTextBox.TabIndex = 8
        '
        'SexoTextBox
        '
        Me.SexoTextBox.BackColor = System.Drawing.Color.Gold
        Me.SexoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "sexo", True))
        Me.SexoTextBox.Location = New System.Drawing.Point(198, 145)
        Me.SexoTextBox.Name = "SexoTextBox"
        Me.SexoTextBox.ReadOnly = True
        Me.SexoTextBox.Size = New System.Drawing.Size(246, 26)
        Me.SexoTextBox.TabIndex = 12
        '
        'LugnacTextBox
        '
        Me.LugnacTextBox.BackColor = System.Drawing.Color.Gold
        Me.LugnacTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "lugnac", True))
        Me.LugnacTextBox.Location = New System.Drawing.Point(174, 19)
        Me.LugnacTextBox.Name = "LugnacTextBox"
        Me.LugnacTextBox.ReadOnly = True
        Me.LugnacTextBox.Size = New System.Drawing.Size(246, 26)
        Me.LugnacTextBox.TabIndex = 14
        '
        'CurpTextBox
        '
        Me.CurpTextBox.BackColor = System.Drawing.Color.Gold
        Me.CurpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "curp", True))
        Me.CurpTextBox.Location = New System.Drawing.Point(174, 51)
        Me.CurpTextBox.Name = "CurpTextBox"
        Me.CurpTextBox.ReadOnly = True
        Me.CurpTextBox.Size = New System.Drawing.Size(246, 26)
        Me.CurpTextBox.TabIndex = 16
        '
        'DompartTextBox
        '
        Me.DompartTextBox.BackColor = System.Drawing.Color.Gold
        Me.DompartTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "dompart", True))
        Me.DompartTextBox.Location = New System.Drawing.Point(174, 83)
        Me.DompartTextBox.Name = "DompartTextBox"
        Me.DompartTextBox.ReadOnly = True
        Me.DompartTextBox.Size = New System.Drawing.Size(246, 26)
        Me.DompartTextBox.TabIndex = 18
        '
        'TelcelTextBox
        '
        Me.TelcelTextBox.BackColor = System.Drawing.Color.Gold
        Me.TelcelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "telcel", True))
        Me.TelcelTextBox.Location = New System.Drawing.Point(174, 115)
        Me.TelcelTextBox.Name = "TelcelTextBox"
        Me.TelcelTextBox.ReadOnly = True
        Me.TelcelTextBox.Size = New System.Drawing.Size(246, 26)
        Me.TelcelTextBox.TabIndex = 20
        '
        'TelcasaTextBox
        '
        Me.TelcasaTextBox.BackColor = System.Drawing.Color.Gold
        Me.TelcasaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "telcasa", True))
        Me.TelcasaTextBox.Location = New System.Drawing.Point(174, 147)
        Me.TelcasaTextBox.Name = "TelcasaTextBox"
        Me.TelcasaTextBox.ReadOnly = True
        Me.TelcasaTextBox.Size = New System.Drawing.Size(246, 26)
        Me.TelcasaTextBox.TabIndex = 22
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.Color.Gold
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(174, 179)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.ReadOnly = True
        Me.EmailTextBox.Size = New System.Drawing.Size(246, 26)
        Me.EmailTextBox.TabIndex = 24
        '
        'GPDATOSPERS
        '
        Me.GPDATOSPERS.Controls.Add(Me.TXTAÑO)
        Me.GPDATOSPERS.Controls.Add(Me.TXTMES)
        Me.GPDATOSPERS.Controls.Add(Me.TXTDIA)
        Me.GPDATOSPERS.Controls.Add(Me.Button4)
        Me.GPDATOSPERS.Controls.Add(Me.Button3)
        Me.GPDATOSPERS.Controls.Add(Me.Button2)
        Me.GPDATOSPERS.Controls.Add(Me.Button1)
        Me.GPDATOSPERS.Controls.Add(Me.CMDEDITAR1)
        Me.GPDATOSPERS.Controls.Add(NombreLabel)
        Me.GPDATOSPERS.Controls.Add(Me.NombreTextBox)
        Me.GPDATOSPERS.Controls.Add(AppatLabel)
        Me.GPDATOSPERS.Controls.Add(Me.AppatTextBox)
        Me.GPDATOSPERS.Controls.Add(ApmatLabel)
        Me.GPDATOSPERS.Controls.Add(Me.ApmatTextBox)
        Me.GPDATOSPERS.Controls.Add(FecnacLabel)
        Me.GPDATOSPERS.Controls.Add(SexoLabel)
        Me.GPDATOSPERS.Controls.Add(Me.SexoTextBox)
        Me.GPDATOSPERS.Location = New System.Drawing.Point(12, 82)
        Me.GPDATOSPERS.Name = "GPDATOSPERS"
        Me.GPDATOSPERS.Size = New System.Drawing.Size(487, 177)
        Me.GPDATOSPERS.TabIndex = 32
        Me.GPDATOSPERS.TabStop = False
        Me.GPDATOSPERS.Text = "DATOS PERSONALES"
        '
        'TXTAÑO
        '
        Me.TXTAÑO.BackColor = System.Drawing.Color.Gold
        Me.TXTAÑO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "año", True))
        Me.TXTAÑO.Location = New System.Drawing.Point(381, 112)
        Me.TXTAÑO.Name = "TXTAÑO"
        Me.TXTAÑO.ReadOnly = True
        Me.TXTAÑO.Size = New System.Drawing.Size(63, 26)
        Me.TXTAÑO.TabIndex = 38
        '
        'TXTMES
        '
        Me.TXTMES.BackColor = System.Drawing.Color.Gold
        Me.TXTMES.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "mes", True))
        Me.TXTMES.Location = New System.Drawing.Point(253, 112)
        Me.TXTMES.Name = "TXTMES"
        Me.TXTMES.ReadOnly = True
        Me.TXTMES.Size = New System.Drawing.Size(122, 26)
        Me.TXTMES.TabIndex = 37
        '
        'TXTDIA
        '
        Me.TXTDIA.BackColor = System.Drawing.Color.Gold
        Me.TXTDIA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARALUMNOBindingSource, "dia", True))
        Me.TXTDIA.Location = New System.Drawing.Point(199, 112)
        Me.TXTDIA.Name = "TXTDIA"
        Me.TXTDIA.ReadOnly = True
        Me.TXTDIA.Size = New System.Drawing.Size(48, 26)
        Me.TXTDIA.TabIndex = 36
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.SAC.My.Resources.Resources.Pencil
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(450, 111)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(26, 23)
        Me.Button4.TabIndex = 35
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.SAC.My.Resources.Resources.Pencil
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(450, 145)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(26, 23)
        Me.Button3.TabIndex = 34
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.SAC.My.Resources.Resources.Pencil
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(450, 82)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(26, 23)
        Me.Button2.TabIndex = 33
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.SAC.My.Resources.Resources.Pencil
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(450, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 23)
        Me.Button1.TabIndex = 32
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CMDEDITAR1
        '
        Me.CMDEDITAR1.BackgroundImage = Global.SAC.My.Resources.Resources.Pencil
        Me.CMDEDITAR1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDEDITAR1.Location = New System.Drawing.Point(450, 19)
        Me.CMDEDITAR1.Name = "CMDEDITAR1"
        Me.CMDEDITAR1.Size = New System.Drawing.Size(26, 23)
        Me.CMDEDITAR1.TabIndex = 31
        Me.CMDEDITAR1.UseVisualStyleBackColor = True
        '
        'GPOTROSDATO
        '
        Me.GPOTROSDATO.Controls.Add(Me.Button6)
        Me.GPOTROSDATO.Controls.Add(ActivoLabel)
        Me.GPOTROSDATO.Controls.Add(Me.ActivoCheckBox)
        Me.GPOTROSDATO.Controls.Add(Me.Button12)
        Me.GPOTROSDATO.Controls.Add(Me.Button11)
        Me.GPOTROSDATO.Controls.Add(Me.Button10)
        Me.GPOTROSDATO.Controls.Add(Me.Button9)
        Me.GPOTROSDATO.Controls.Add(Me.Button8)
        Me.GPOTROSDATO.Controls.Add(Me.Button7)
        Me.GPOTROSDATO.Controls.Add(LugnacLabel)
        Me.GPOTROSDATO.Controls.Add(Me.LugnacTextBox)
        Me.GPOTROSDATO.Controls.Add(CurpLabel)
        Me.GPOTROSDATO.Controls.Add(Me.EmailTextBox)
        Me.GPOTROSDATO.Controls.Add(Me.CurpTextBox)
        Me.GPOTROSDATO.Controls.Add(DompartLabel)
        Me.GPOTROSDATO.Controls.Add(Me.DompartTextBox)
        Me.GPOTROSDATO.Controls.Add(TelcelLabel)
        Me.GPOTROSDATO.Controls.Add(Me.TelcelTextBox)
        Me.GPOTROSDATO.Controls.Add(TelcasaLabel)
        Me.GPOTROSDATO.Controls.Add(Me.TelcasaTextBox)
        Me.GPOTROSDATO.Controls.Add(EmailLabel)
        Me.GPOTROSDATO.Location = New System.Drawing.Point(518, 82)
        Me.GPOTROSDATO.Name = "GPOTROSDATO"
        Me.GPOTROSDATO.Size = New System.Drawing.Size(472, 249)
        Me.GPOTROSDATO.TabIndex = 33
        Me.GPOTROSDATO.TabStop = False
        Me.GPOTROSDATO.Text = "OTROS DATOS"
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.SAC.My.Resources.Resources.Pencil
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Location = New System.Drawing.Point(426, 213)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(26, 23)
        Me.Button6.TabIndex = 45
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ActivoCheckBox
        '
        Me.ActivoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SELECCIONARALUMNOBindingSource, "activo", True))
        Me.ActivoCheckBox.Enabled = False
        Me.ActivoCheckBox.Location = New System.Drawing.Point(174, 212)
        Me.ActivoCheckBox.Name = "ActivoCheckBox"
        Me.ActivoCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ActivoCheckBox.TabIndex = 44
        Me.ActivoCheckBox.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.BackgroundImage = Global.SAC.My.Resources.Resources.Pencil
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.Location = New System.Drawing.Point(426, 180)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(26, 23)
        Me.Button12.TabIndex = 43
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.BackgroundImage = Global.SAC.My.Resources.Resources.Pencil
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.Location = New System.Drawing.Point(426, 148)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(26, 23)
        Me.Button11.TabIndex = 42
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.BackgroundImage = Global.SAC.My.Resources.Resources.Pencil
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.Location = New System.Drawing.Point(426, 117)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(26, 23)
        Me.Button10.TabIndex = 41
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackgroundImage = Global.SAC.My.Resources.Resources.Pencil
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.Location = New System.Drawing.Point(426, 84)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(26, 23)
        Me.Button9.TabIndex = 40
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = Global.SAC.My.Resources.Resources.Pencil
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.Location = New System.Drawing.Point(426, 51)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(26, 23)
        Me.Button8.TabIndex = 39
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.SAC.My.Resources.Resources.Pencil
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.Location = New System.Drawing.Point(426, 20)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(26, 23)
        Me.Button7.TabIndex = 38
        Me.Button7.UseVisualStyleBackColor = True
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImage = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Location = New System.Drawing.Point(258, 276)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(42, 40)
        Me.CMDCANCELAR.TabIndex = 35
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'CMDGUARDAR
        '
        Me.CMDGUARDAR.BackgroundImage = Global.SAC.My.Resources.Resources.GUARDAR_REGISTRO1
        Me.CMDGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDGUARDAR.Location = New System.Drawing.Point(194, 276)
        Me.CMDGUARDAR.Name = "CMDGUARDAR"
        Me.CMDGUARDAR.Size = New System.Drawing.Size(44, 40)
        Me.CMDGUARDAR.TabIndex = 34
        Me.CMDGUARDAR.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.BackgroundImage = Global.SAC.My.Resources.Resources.ok
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button13.Location = New System.Drawing.Point(844, 40)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(26, 23)
        Me.Button13.TabIndex = 1
        Me.Button13.UseVisualStyleBackColor = True
        '
        'CBOESCOLARIDAD
        '
        Me.CBOESCOLARIDAD.DataSource = Me.SELECCIONARESCOLARIDADBindingSource
        Me.CBOESCOLARIDAD.DisplayMember = "escolaridad"
        Me.CBOESCOLARIDAD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOESCOLARIDAD.FormattingEnabled = True
        Me.CBOESCOLARIDAD.Location = New System.Drawing.Point(648, 37)
        Me.CBOESCOLARIDAD.Name = "CBOESCOLARIDAD"
        Me.CBOESCOLARIDAD.Size = New System.Drawing.Size(190, 26)
        Me.CBOESCOLARIDAD.TabIndex = 36
        Me.CBOESCOLARIDAD.ValueMember = "escolaridad"
        '
        'SELECCIONARESCOLARIDADBindingSource
        '
        Me.SELECCIONARESCOLARIDADBindingSource.DataMember = "SELECCIONARESCOLARIDAD"
        Me.SELECCIONARESCOLARIDADBindingSource.DataSource = Me.SACDataSet
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
        'SELECCIONARALUMNOTableAdapter
        '
        Me.SELECCIONARALUMNOTableAdapter.ClearBeforeFill = True
        '
        'SELECCIONARALUMNOSACTIVOSYINACTIVOSBindingSource
        '
        Me.SELECCIONARALUMNOSACTIVOSYINACTIVOSBindingSource.DataMember = "SELECCIONARALUMNOSACTIVOSYINACTIVOS"
        Me.SELECCIONARALUMNOSACTIVOSYINACTIVOSBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARALUMNOSACTIVOSYINACTIVOSTableAdapter
        '
        Me.SELECCIONARALUMNOSACTIVOSYINACTIVOSTableAdapter.ClearBeforeFill = True
        '
        'MODIFICARALUMNO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 346)
        Me.ControlBox = False
        Me.Controls.Add(Me.CBOESCOLARIDAD)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.CMDGUARDAR)
        Me.Controls.Add(Me.GPOTROSDATO)
        Me.Controls.Add(Me.GPDATOSPERS)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBOALUMNO)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MODIFICARALUMNO"
        Me.Text = "MODIFICAR ALUMNO"
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARALUMNOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GPDATOSPERS.ResumeLayout(False)
        Me.GPDATOSPERS.PerformLayout()
        Me.GPOTROSDATO.ResumeLayout(False)
        Me.GPOTROSDATO.PerformLayout()
        CType(Me.SELECCIONARESCOLARIDADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARALUMNOSACTIVOSYINACTIVOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBOALUMNO As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
    Friend WithEvents GPDATOSPERS As System.Windows.Forms.GroupBox
    Friend WithEvents GPOTROSDATO As System.Windows.Forms.GroupBox
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents CMDGUARDAR As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CMDEDITAR1 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ActivoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CBOESCOLARIDAD As System.Windows.Forms.ComboBox
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents SELECCIONARESCOLARIDADBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARESCOLARIDADTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARESCOLARIDADTableAdapter
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SELECCIONARALUMNOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARALUMNOTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARALUMNOTableAdapter
    Friend WithEvents TXTAÑO As System.Windows.Forms.TextBox
    Friend WithEvents TXTMES As System.Windows.Forms.TextBox
    Friend WithEvents TXTDIA As System.Windows.Forms.TextBox
    Friend WithEvents SELECCIONARALUMNOSACTIVOSYINACTIVOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARALUMNOSACTIVOSYINACTIVOSTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARALUMNOSACTIVOSYINACTIVOSTableAdapter
End Class
