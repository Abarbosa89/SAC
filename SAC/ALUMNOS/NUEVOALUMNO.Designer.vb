<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NUEVOALUMNO
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
        Me.LBNOMBRE = New System.Windows.Forms.LinkLabel()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.TXTMATRICULA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTLUGARNAC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBOSEXO = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTCURP = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TXTDOMPARTICULA = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTEMAIL = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTTELCEL = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTTELCASA = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CBOAÑO = New System.Windows.Forms.ComboBox()
        Me.CBOMES = New System.Windows.Forms.ComboBox()
        Me.CBODIA = New System.Windows.Forms.ComboBox()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.LBLMATRI = New System.Windows.Forms.Label()
        Me.NUEVAMATRICULABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SACDataSet = New SAC.SACDataSet()
        Me.CMDGUARDAR = New System.Windows.Forms.Button()
        Me.NUEVAMATRICULATableAdapter = New SAC.SACDataSetTableAdapters.NUEVAMATRICULATableAdapter()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CBOCICLO = New System.Windows.Forms.ComboBox()
        Me.SELECIONARNIVELBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBOGRUPO = New System.Windows.Forms.ComboBox()
        Me.CBOGRADO = New System.Windows.Forms.ComboBox()
        Me.SELECIONARGRADOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CBONIVEL = New System.Windows.Forms.ComboBox()
        Me.SELECCIONARRANGOSTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARRANGOSTableAdapter()
        Me.SELECIONARGRADOTableAdapter = New SAC.SACDataSetTableAdapters.SELECIONARGRADOTableAdapter()
        Me.SELECIONARNIVELTableAdapter = New SAC.SACDataSetTableAdapters.SELECIONARNIVELTableAdapter()
        Me.SELECCIONARCICLOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARCICLOSTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARCICLOSTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NUEVAMATRICULABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SELECIONARNIVELBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECIONARGRADOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARCICLOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBNOMBRE
        '
        Me.LBNOMBRE.AutoSize = True
        Me.LBNOMBRE.Location = New System.Drawing.Point(93, 72)
        Me.LBNOMBRE.Name = "LBNOMBRE"
        Me.LBNOMBRE.Size = New System.Drawing.Size(64, 18)
        Me.LBNOMBRE.TabIndex = 0
        Me.LBNOMBRE.TabStop = True
        Me.LBNOMBRE.Text = "Nombre"
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.BackColor = System.Drawing.Color.Gold
        Me.TXTNOMBRE.Location = New System.Drawing.Point(163, 69)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.ReadOnly = True
        Me.TXTNOMBRE.Size = New System.Drawing.Size(418, 26)
        Me.TXTNOMBRE.TabIndex = 2
        '
        'TXTMATRICULA
        '
        Me.TXTMATRICULA.BackColor = System.Drawing.Color.Gold
        Me.TXTMATRICULA.Location = New System.Drawing.Point(163, 31)
        Me.TXTMATRICULA.Name = "TXTMATRICULA"
        Me.TXTMATRICULA.ReadOnly = True
        Me.TXTMATRICULA.Size = New System.Drawing.Size(171, 26)
        Me.TXTMATRICULA.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Matricula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha Nacimiento"
        '
        'TXTLUGARNAC
        '
        Me.TXTLUGARNAC.Location = New System.Drawing.Point(163, 138)
        Me.TXTLUGARNAC.Name = "TXTLUGARNAC"
        Me.TXTLUGARNAC.Size = New System.Drawing.Size(243, 26)
        Me.TXTLUGARNAC.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Lugar Nacimiento"
        '
        'CBOSEXO
        '
        Me.CBOSEXO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOSEXO.FormattingEnabled = True
        Me.CBOSEXO.Items.AddRange(New Object() {"M", "F"})
        Me.CBOSEXO.Location = New System.Drawing.Point(163, 170)
        Me.CBOSEXO.Name = "CBOSEXO"
        Me.CBOSEXO.Size = New System.Drawing.Size(243, 26)
        Me.CBOSEXO.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(113, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Sexo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(104, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "CURP"
        '
        'TXTCURP
        '
        Me.TXTCURP.Location = New System.Drawing.Point(163, 205)
        Me.TXTCURP.Name = "TXTCURP"
        Me.TXTCURP.Size = New System.Drawing.Size(243, 26)
        Me.TXTCURP.TabIndex = 7
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(13, 246)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(144, 18)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Domicilio Particular"
        '
        'TXTDOMPARTICULA
        '
        Me.TXTDOMPARTICULA.BackColor = System.Drawing.Color.Gold
        Me.TXTDOMPARTICULA.Location = New System.Drawing.Point(163, 243)
        Me.TXTDOMPARTICULA.Name = "TXTDOMPARTICULA"
        Me.TXTDOMPARTICULA.ReadOnly = True
        Me.TXTDOMPARTICULA.Size = New System.Drawing.Size(418, 26)
        Me.TXTDOMPARTICULA.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TXTEMAIL)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TXTTELCEL)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TXTTELCASA)
        Me.GroupBox1.Location = New System.Drawing.Point(637, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 145)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Otros Datos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 18)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Email"
        '
        'TXTEMAIL
        '
        Me.TXTEMAIL.Location = New System.Drawing.Point(93, 98)
        Me.TXTEMAIL.Name = "TXTEMAIL"
        Me.TXTEMAIL.Size = New System.Drawing.Size(210, 26)
        Me.TXTEMAIL.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Tel Celular"
        '
        'TXTTELCEL
        '
        Me.TXTTELCEL.Location = New System.Drawing.Point(93, 66)
        Me.TXTTELCEL.MaxLength = 10
        Me.TXTTELCEL.Name = "TXTTELCEL"
        Me.TXTTELCEL.Size = New System.Drawing.Size(210, 26)
        Me.TXTTELCEL.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 18)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Tel Casa"
        '
        'TXTTELCASA
        '
        Me.TXTTELCASA.Location = New System.Drawing.Point(93, 34)
        Me.TXTTELCASA.MaxLength = 10
        Me.TXTTELCASA.Name = "TXTTELCASA"
        Me.TXTTELCASA.Size = New System.Drawing.Size(210, 26)
        Me.TXTTELCASA.TabIndex = 9
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CBOAÑO)
        Me.GroupBox3.Controls.Add(Me.CBOMES)
        Me.GroupBox3.Controls.Add(Me.CBODIA)
        Me.GroupBox3.Controls.Add(Me.TXTDOMPARTICULA)
        Me.GroupBox3.Controls.Add(Me.LinkLabel1)
        Me.GroupBox3.Controls.Add(Me.TXTCURP)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.CBOSEXO)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TXTLUGARNAC)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TXTMATRICULA)
        Me.GroupBox3.Controls.Add(Me.TXTNOMBRE)
        Me.GroupBox3.Controls.Add(Me.LBNOMBRE)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(619, 322)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Personales"
        '
        'CBOAÑO
        '
        Me.CBOAÑO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CBOAÑO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBOAÑO.FormattingEnabled = True
        Me.CBOAÑO.Items.AddRange(New Object() {"1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025"})
        Me.CBOAÑO.Location = New System.Drawing.Point(333, 109)
        Me.CBOAÑO.Name = "CBOAÑO"
        Me.CBOAÑO.Size = New System.Drawing.Size(73, 26)
        Me.CBOAÑO.TabIndex = 16
        Me.CBOAÑO.Text = "YYYY"
        '
        'CBOMES
        '
        Me.CBOMES.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CBOMES.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBOMES.FormattingEnabled = True
        Me.CBOMES.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.CBOMES.Location = New System.Drawing.Point(220, 109)
        Me.CBOMES.Name = "CBOMES"
        Me.CBOMES.Size = New System.Drawing.Size(107, 26)
        Me.CBOMES.TabIndex = 15
        Me.CBOMES.Text = "MM"
        '
        'CBODIA
        '
        Me.CBODIA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CBODIA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBODIA.FormattingEnabled = True
        Me.CBODIA.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.CBODIA.Location = New System.Drawing.Point(163, 109)
        Me.CBODIA.Name = "CBODIA"
        Me.CBODIA.Size = New System.Drawing.Size(51, 26)
        Me.CBODIA.TabIndex = 14
        Me.CBODIA.Text = "DD"
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Image = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR.Location = New System.Drawing.Point(521, 340)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(114, 60)
        Me.CMDCANCELAR.TabIndex = 16
        Me.CMDCANCELAR.Text = "CERRAR"
        Me.CMDCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'LBLMATRI
        '
        Me.LBLMATRI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NUEVAMATRICULABindingSource, "matri", True))
        Me.LBLMATRI.Location = New System.Drawing.Point(295, 355)
        Me.LBLMATRI.Name = "LBLMATRI"
        Me.LBLMATRI.Size = New System.Drawing.Size(100, 23)
        Me.LBLMATRI.TabIndex = 27
        Me.LBLMATRI.Text = "Label9"
        '
        'NUEVAMATRICULABindingSource
        '
        Me.NUEVAMATRICULABindingSource.DataMember = "NUEVAMATRICULA"
        Me.NUEVAMATRICULABindingSource.DataSource = Me.SACDataSet
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CMDGUARDAR
        '
        Me.CMDGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDGUARDAR.Image = Global.SAC.My.Resources.Resources.GUARDAR_REGISTRO1
        Me.CMDGUARDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDGUARDAR.Location = New System.Drawing.Point(401, 340)
        Me.CMDGUARDAR.Name = "CMDGUARDAR"
        Me.CMDGUARDAR.Size = New System.Drawing.Size(114, 60)
        Me.CMDGUARDAR.TabIndex = 15
        Me.CMDGUARDAR.Text = "GUARDAR"
        Me.CMDGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDGUARDAR.UseVisualStyleBackColor = True
        '
        'NUEVAMATRICULATableAdapter
        '
        Me.NUEVAMATRICULATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.CBOCICLO)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.CBOGRUPO)
        Me.GroupBox2.Controls.Add(Me.CBOGRADO)
        Me.GroupBox2.Controls.Add(Me.CBONIVEL)
        Me.GroupBox2.Location = New System.Drawing.Point(637, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(323, 166)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Escolar"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 127)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 18)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Ciclo"
        '
        'CBOCICLO
        '
        Me.CBOCICLO.DataSource = Me.SELECCIONARCICLOSBindingSource
        Me.CBOCICLO.DisplayMember = "CICLO"
        Me.CBOCICLO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCICLO.FormattingEnabled = True
        Me.CBOCICLO.Location = New System.Drawing.Point(66, 124)
        Me.CBOCICLO.Name = "CBOCICLO"
        Me.CBOCICLO.Size = New System.Drawing.Size(210, 26)
        Me.CBOCICLO.TabIndex = 25
        Me.CBOCICLO.ValueMember = "IDCICLO"
        '
        'SELECIONARNIVELBindingSource
        '
        Me.SELECIONARNIVELBindingSource.DataMember = "SELECIONARNIVEL"
        Me.SELECIONARNIVELBindingSource.DataSource = Me.SACDataSet
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 18)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Grupo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 18)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Grado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 18)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Nivel"
        '
        'CBOGRUPO
        '
        Me.CBOGRUPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOGRUPO.FormattingEnabled = True
        Me.CBOGRUPO.Items.AddRange(New Object() {"A", "B", "C"})
        Me.CBOGRUPO.Location = New System.Drawing.Point(66, 94)
        Me.CBOGRUPO.Name = "CBOGRUPO"
        Me.CBOGRUPO.Size = New System.Drawing.Size(76, 26)
        Me.CBOGRUPO.TabIndex = 2
        '
        'CBOGRADO
        '
        Me.CBOGRADO.DataSource = Me.SELECIONARGRADOBindingSource
        Me.CBOGRADO.DisplayMember = "grado"
        Me.CBOGRADO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOGRADO.FormattingEnabled = True
        Me.CBOGRADO.Location = New System.Drawing.Point(66, 61)
        Me.CBOGRADO.Name = "CBOGRADO"
        Me.CBOGRADO.Size = New System.Drawing.Size(76, 26)
        Me.CBOGRADO.TabIndex = 1
        Me.CBOGRADO.ValueMember = "idgrado"
        '
        'SELECIONARGRADOBindingSource
        '
        Me.SELECIONARGRADOBindingSource.DataMember = "SELECIONARGRADO"
        Me.SELECIONARGRADOBindingSource.DataSource = Me.SACDataSet
        '
        'CBONIVEL
        '
        Me.CBONIVEL.DataSource = Me.SELECIONARNIVELBindingSource
        Me.CBONIVEL.DisplayMember = "escolaridad"
        Me.CBONIVEL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBONIVEL.FormattingEnabled = True
        Me.CBONIVEL.Location = New System.Drawing.Point(66, 29)
        Me.CBONIVEL.Name = "CBONIVEL"
        Me.CBONIVEL.Size = New System.Drawing.Size(210, 26)
        Me.CBONIVEL.TabIndex = 0
        Me.CBONIVEL.ValueMember = "escolaridad"
        '
        'SELECCIONARRANGOSTableAdapter
        '
        Me.SELECCIONARRANGOSTableAdapter.ClearBeforeFill = True
        '
        'SELECIONARGRADOTableAdapter
        '
        Me.SELECIONARGRADOTableAdapter.ClearBeforeFill = True
        '
        'SELECIONARNIVELTableAdapter
        '
        Me.SELECIONARNIVELTableAdapter.ClearBeforeFill = True
        '
        'SELECCIONARCICLOSBindingSource
        '
        Me.SELECCIONARCICLOSBindingSource.DataMember = "SELECCIONARCICLOS"
        Me.SELECCIONARCICLOSBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARCICLOSTableAdapter
        '
        Me.SELECCIONARCICLOSTableAdapter.ClearBeforeFill = True
        '
        'NUEVOALUMNO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 412)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LBLMATRI)
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CMDGUARDAR)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NUEVOALUMNO"
        Me.Text = "NUEVO INGRESO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.NUEVAMATRICULABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SELECIONARNIVELBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECIONARGRADOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARCICLOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LBNOMBRE As System.Windows.Forms.LinkLabel
    Friend WithEvents TXTNOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents TXTMATRICULA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTLUGARNAC As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBOSEXO As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXTCURP As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents TXTDOMPARTICULA As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXTEMAIL As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXTTELCEL As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXTTELCASA As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CMDGUARDAR As System.Windows.Forms.Button
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents NUEVAMATRICULABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NUEVAMATRICULATableAdapter As SAC.SACDataSetTableAdapters.NUEVAMATRICULATableAdapter
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LBLMATRI As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CBOGRUPO As System.Windows.Forms.ComboBox
    Friend WithEvents CBOGRADO As System.Windows.Forms.ComboBox
    Friend WithEvents CBONIVEL As System.Windows.Forms.ComboBox
    Friend WithEvents SELECCIONARRANGOSTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARRANGOSTableAdapter
    Friend WithEvents CBOAÑO As System.Windows.Forms.ComboBox
    Friend WithEvents CBOMES As System.Windows.Forms.ComboBox
    Friend WithEvents CBODIA As System.Windows.Forms.ComboBox
    Friend WithEvents SELECIONARGRADOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECIONARGRADOTableAdapter As SAC.SACDataSetTableAdapters.SELECIONARGRADOTableAdapter
    Friend WithEvents SELECIONARNIVELBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECIONARNIVELTableAdapter As SAC.SACDataSetTableAdapters.SELECIONARNIVELTableAdapter
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CBOCICLO As System.Windows.Forms.ComboBox
    Friend WithEvents SELECCIONARCICLOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARCICLOSTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARCICLOSTableAdapter
End Class
