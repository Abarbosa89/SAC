<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UNIFORMES
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
        Dim MontoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UNIFORMES))
        Me.SACDataSet = New SAC.SACDataSet()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.CBOUNIFORMES = New System.Windows.Forms.ComboBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.LBLCANT5 = New System.Windows.Forms.Label()
        Me.LBLCANT4 = New System.Windows.Forms.Label()
        Me.LBLCANT3 = New System.Windows.Forms.Label()
        Me.LBLCANT2 = New System.Windows.Forms.Label()
        Me.LBLCANT1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBLMONTO5 = New System.Windows.Forms.Label()
        Me.LBLMONTO4 = New System.Windows.Forms.Label()
        Me.LBLMONTO3 = New System.Windows.Forms.Label()
        Me.LBLMONTO2 = New System.Windows.Forms.Label()
        Me.LBLMONTO1 = New System.Windows.Forms.Label()
        Me.LBLCONCEPTO5 = New System.Windows.Forms.Label()
        Me.LBLCONCEPTO4 = New System.Windows.Forms.Label()
        Me.LBLCONCEPTO3 = New System.Windows.Forms.Label()
        Me.LBLCONCEPTO2 = New System.Windows.Forms.Label()
        Me.LBLCONCEPTO1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLCANT8 = New System.Windows.Forms.Label()
        Me.LBLCANT7 = New System.Windows.Forms.Label()
        Me.LBLCANT6 = New System.Windows.Forms.Label()
        Me.LBLMONTO8 = New System.Windows.Forms.Label()
        Me.LBLMONTO7 = New System.Windows.Forms.Label()
        Me.LBLMONTO6 = New System.Windows.Forms.Label()
        Me.LBLCONCEPTO8 = New System.Windows.Forms.Label()
        Me.LBLCONCEPTO7 = New System.Windows.Forms.Label()
        Me.LBLCONCEPTO6 = New System.Windows.Forms.Label()
        Me.CMDCANCELAR5 = New System.Windows.Forms.Button()
        Me.CMDCANCELAR4 = New System.Windows.Forms.Button()
        Me.CMDCANCELAR3 = New System.Windows.Forms.Button()
        Me.CMDCANCELAR2 = New System.Windows.Forms.Button()
        Me.CMDCANCELAR1 = New System.Windows.Forms.Button()
        Me.CMDGUARDAR5 = New System.Windows.Forms.Button()
        Me.CMDGUARDAR4 = New System.Windows.Forms.Button()
        Me.CMDGUARDAR3 = New System.Windows.Forms.Button()
        Me.CMDGUARDAR2 = New System.Windows.Forms.Button()
        Me.CMDGUARDAR1 = New System.Windows.Forms.Button()
        Me.CMDCANCELAR8 = New System.Windows.Forms.Button()
        Me.CMDCANCELAR7 = New System.Windows.Forms.Button()
        Me.CMDCANCELAR6 = New System.Windows.Forms.Button()
        Me.CMDGUARDAR8 = New System.Windows.Forms.Button()
        Me.CMDGUARDAR7 = New System.Windows.Forms.Button()
        Me.CMDGUARDAR6 = New System.Windows.Forms.Button()
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.CMDIMPRIMIR = New System.Windows.Forms.Button()
        Me.LBLMONTOBASE = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBLTOTAL = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LBLIDPRODUC8 = New System.Windows.Forms.Label()
        Me.LBLIDPRODUC7 = New System.Windows.Forms.Label()
        Me.LBLIDPRODUC6 = New System.Windows.Forms.Label()
        Me.LBLIDPRODUC5 = New System.Windows.Forms.Label()
        Me.LBLIDPRODUC4 = New System.Windows.Forms.Label()
        Me.LBLIDPRODUC3 = New System.Windows.Forms.Label()
        Me.LBLIDPRODUC1 = New System.Windows.Forms.Label()
        Me.LBLIDPRODUC2 = New System.Windows.Forms.Label()
        Me.SELECCIONARPRINTMAXIMOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARPRINTMAXIMOTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARPRINTMAXIMOTableAdapter()
        Me.LBLIDPRINTMAX = New System.Windows.Forms.Label()
        Me.LBLIDPRINTNEW = New System.Windows.Forms.Label()
        Me.CMDIMPRIMIT = New System.Windows.Forms.Button()
        Me.SELECCIONARUNIFORMESPORSEXOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARUNIFORMESPORSEXOTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARUNIFORMESPORSEXOTableAdapter()
        MontoLabel = New System.Windows.Forms.Label()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SELECCIONARPRINTMAXIMOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARUNIFORMESPORSEXOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MontoLabel
        '
        MontoLabel.AutoSize = True
        MontoLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MontoLabel.Location = New System.Drawing.Point(239, 51)
        MontoLabel.Name = "MontoLabel"
        MontoLabel.Size = New System.Drawing.Size(123, 19)
        MontoLabel.TabIndex = 138
        MontoLabel.Text = "MONTO BASE:"
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
        'CBOUNIFORMES
        '
        Me.CBOUNIFORMES.DataSource = Me.SELECCIONARUNIFORMESPORSEXOBindingSource
        Me.CBOUNIFORMES.DisplayMember = "descripcion"
        Me.CBOUNIFORMES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOUNIFORMES.FormattingEnabled = True
        Me.CBOUNIFORMES.Location = New System.Drawing.Point(69, 12)
        Me.CBOUNIFORMES.Name = "CBOUNIFORMES"
        Me.CBOUNIFORMES.Size = New System.Drawing.Size(572, 26)
        Me.CBOUNIFORMES.TabIndex = 0
        Me.CBOUNIFORMES.ValueMember = "iduniform"
        '
        'Button13
        '
        Me.Button13.BackgroundImage = Global.SAC.My.Resources.Resources.ok
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button13.Location = New System.Drawing.Point(647, 13)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(26, 23)
        Me.Button13.TabIndex = 64
        Me.Button13.UseVisualStyleBackColor = True
        '
        'LBLCANT5
        '
        Me.LBLCANT5.AutoSize = True
        Me.LBLCANT5.Location = New System.Drawing.Point(392, 184)
        Me.LBLCANT5.Name = "LBLCANT5"
        Me.LBLCANT5.Size = New System.Drawing.Size(0, 18)
        Me.LBLCANT5.TabIndex = 111
        '
        'LBLCANT4
        '
        Me.LBLCANT4.AutoSize = True
        Me.LBLCANT4.Location = New System.Drawing.Point(392, 149)
        Me.LBLCANT4.Name = "LBLCANT4"
        Me.LBLCANT4.Size = New System.Drawing.Size(0, 18)
        Me.LBLCANT4.TabIndex = 110
        '
        'LBLCANT3
        '
        Me.LBLCANT3.AutoSize = True
        Me.LBLCANT3.Location = New System.Drawing.Point(392, 112)
        Me.LBLCANT3.Name = "LBLCANT3"
        Me.LBLCANT3.Size = New System.Drawing.Size(0, 18)
        Me.LBLCANT3.TabIndex = 109
        '
        'LBLCANT2
        '
        Me.LBLCANT2.AutoSize = True
        Me.LBLCANT2.Location = New System.Drawing.Point(392, 77)
        Me.LBLCANT2.Name = "LBLCANT2"
        Me.LBLCANT2.Size = New System.Drawing.Size(0, 18)
        Me.LBLCANT2.TabIndex = 108
        '
        'LBLCANT1
        '
        Me.LBLCANT1.AutoSize = True
        Me.LBLCANT1.Location = New System.Drawing.Point(392, 45)
        Me.LBLCANT1.Name = "LBLCANT1"
        Me.LBLCANT1.Size = New System.Drawing.Size(0, 18)
        Me.LBLCANT1.TabIndex = 107
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(371, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "CANT"
        '
        'LBLMONTO5
        '
        Me.LBLMONTO5.AutoSize = True
        Me.LBLMONTO5.Location = New System.Drawing.Point(451, 184)
        Me.LBLMONTO5.Name = "LBLMONTO5"
        Me.LBLMONTO5.Size = New System.Drawing.Size(0, 18)
        Me.LBLMONTO5.TabIndex = 105
        '
        'LBLMONTO4
        '
        Me.LBLMONTO4.AutoSize = True
        Me.LBLMONTO4.Location = New System.Drawing.Point(451, 149)
        Me.LBLMONTO4.Name = "LBLMONTO4"
        Me.LBLMONTO4.Size = New System.Drawing.Size(0, 18)
        Me.LBLMONTO4.TabIndex = 104
        '
        'LBLMONTO3
        '
        Me.LBLMONTO3.AutoSize = True
        Me.LBLMONTO3.Location = New System.Drawing.Point(451, 112)
        Me.LBLMONTO3.Name = "LBLMONTO3"
        Me.LBLMONTO3.Size = New System.Drawing.Size(0, 18)
        Me.LBLMONTO3.TabIndex = 103
        '
        'LBLMONTO2
        '
        Me.LBLMONTO2.AutoSize = True
        Me.LBLMONTO2.Location = New System.Drawing.Point(451, 77)
        Me.LBLMONTO2.Name = "LBLMONTO2"
        Me.LBLMONTO2.Size = New System.Drawing.Size(0, 18)
        Me.LBLMONTO2.TabIndex = 102
        '
        'LBLMONTO1
        '
        Me.LBLMONTO1.AutoSize = True
        Me.LBLMONTO1.Location = New System.Drawing.Point(451, 45)
        Me.LBLMONTO1.Name = "LBLMONTO1"
        Me.LBLMONTO1.Size = New System.Drawing.Size(0, 18)
        Me.LBLMONTO1.TabIndex = 101
        '
        'LBLCONCEPTO5
        '
        Me.LBLCONCEPTO5.AutoSize = True
        Me.LBLCONCEPTO5.Location = New System.Drawing.Point(52, 184)
        Me.LBLCONCEPTO5.Name = "LBLCONCEPTO5"
        Me.LBLCONCEPTO5.Size = New System.Drawing.Size(0, 18)
        Me.LBLCONCEPTO5.TabIndex = 100
        '
        'LBLCONCEPTO4
        '
        Me.LBLCONCEPTO4.AutoSize = True
        Me.LBLCONCEPTO4.Location = New System.Drawing.Point(52, 149)
        Me.LBLCONCEPTO4.Name = "LBLCONCEPTO4"
        Me.LBLCONCEPTO4.Size = New System.Drawing.Size(0, 18)
        Me.LBLCONCEPTO4.TabIndex = 99
        '
        'LBLCONCEPTO3
        '
        Me.LBLCONCEPTO3.AutoSize = True
        Me.LBLCONCEPTO3.Location = New System.Drawing.Point(52, 112)
        Me.LBLCONCEPTO3.Name = "LBLCONCEPTO3"
        Me.LBLCONCEPTO3.Size = New System.Drawing.Size(0, 18)
        Me.LBLCONCEPTO3.TabIndex = 98
        '
        'LBLCONCEPTO2
        '
        Me.LBLCONCEPTO2.AutoSize = True
        Me.LBLCONCEPTO2.Location = New System.Drawing.Point(52, 77)
        Me.LBLCONCEPTO2.Name = "LBLCONCEPTO2"
        Me.LBLCONCEPTO2.Size = New System.Drawing.Size(0, 18)
        Me.LBLCONCEPTO2.TabIndex = 97
        '
        'LBLCONCEPTO1
        '
        Me.LBLCONCEPTO1.AutoSize = True
        Me.LBLCONCEPTO1.Location = New System.Drawing.Point(52, 45)
        Me.LBLCONCEPTO1.Name = "LBLCONCEPTO1"
        Me.LBLCONCEPTO1.Size = New System.Drawing.Size(0, 18)
        Me.LBLCONCEPTO1.TabIndex = 96
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(450, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "MONTO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "CONCEPTO"
        '
        'LBLCANT8
        '
        Me.LBLCANT8.AutoSize = True
        Me.LBLCANT8.Location = New System.Drawing.Point(392, 290)
        Me.LBLCANT8.Name = "LBLCANT8"
        Me.LBLCANT8.Size = New System.Drawing.Size(0, 18)
        Me.LBLCANT8.TabIndex = 120
        '
        'LBLCANT7
        '
        Me.LBLCANT7.AutoSize = True
        Me.LBLCANT7.Location = New System.Drawing.Point(392, 255)
        Me.LBLCANT7.Name = "LBLCANT7"
        Me.LBLCANT7.Size = New System.Drawing.Size(0, 18)
        Me.LBLCANT7.TabIndex = 119
        '
        'LBLCANT6
        '
        Me.LBLCANT6.AutoSize = True
        Me.LBLCANT6.Location = New System.Drawing.Point(392, 218)
        Me.LBLCANT6.Name = "LBLCANT6"
        Me.LBLCANT6.Size = New System.Drawing.Size(0, 18)
        Me.LBLCANT6.TabIndex = 118
        '
        'LBLMONTO8
        '
        Me.LBLMONTO8.AutoSize = True
        Me.LBLMONTO8.Location = New System.Drawing.Point(451, 290)
        Me.LBLMONTO8.Name = "LBLMONTO8"
        Me.LBLMONTO8.Size = New System.Drawing.Size(0, 18)
        Me.LBLMONTO8.TabIndex = 117
        '
        'LBLMONTO7
        '
        Me.LBLMONTO7.AutoSize = True
        Me.LBLMONTO7.Location = New System.Drawing.Point(451, 255)
        Me.LBLMONTO7.Name = "LBLMONTO7"
        Me.LBLMONTO7.Size = New System.Drawing.Size(0, 18)
        Me.LBLMONTO7.TabIndex = 116
        '
        'LBLMONTO6
        '
        Me.LBLMONTO6.AutoSize = True
        Me.LBLMONTO6.Location = New System.Drawing.Point(451, 218)
        Me.LBLMONTO6.Name = "LBLMONTO6"
        Me.LBLMONTO6.Size = New System.Drawing.Size(0, 18)
        Me.LBLMONTO6.TabIndex = 115
        '
        'LBLCONCEPTO8
        '
        Me.LBLCONCEPTO8.AutoSize = True
        Me.LBLCONCEPTO8.Location = New System.Drawing.Point(52, 290)
        Me.LBLCONCEPTO8.Name = "LBLCONCEPTO8"
        Me.LBLCONCEPTO8.Size = New System.Drawing.Size(0, 18)
        Me.LBLCONCEPTO8.TabIndex = 114
        '
        'LBLCONCEPTO7
        '
        Me.LBLCONCEPTO7.AutoSize = True
        Me.LBLCONCEPTO7.Location = New System.Drawing.Point(52, 255)
        Me.LBLCONCEPTO7.Name = "LBLCONCEPTO7"
        Me.LBLCONCEPTO7.Size = New System.Drawing.Size(0, 18)
        Me.LBLCONCEPTO7.TabIndex = 113
        '
        'LBLCONCEPTO6
        '
        Me.LBLCONCEPTO6.AutoSize = True
        Me.LBLCONCEPTO6.Location = New System.Drawing.Point(52, 218)
        Me.LBLCONCEPTO6.Name = "LBLCONCEPTO6"
        Me.LBLCONCEPTO6.Size = New System.Drawing.Size(0, 18)
        Me.LBLCONCEPTO6.TabIndex = 112
        '
        'CMDCANCELAR5
        '
        Me.CMDCANCELAR5.BackgroundImage = CType(resources.GetObject("CMDCANCELAR5.BackgroundImage"), System.Drawing.Image)
        Me.CMDCANCELAR5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR5.Enabled = False
        Me.CMDCANCELAR5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR5.Location = New System.Drawing.Point(633, 179)
        Me.CMDCANCELAR5.Name = "CMDCANCELAR5"
        Me.CMDCANCELAR5.Size = New System.Drawing.Size(27, 23)
        Me.CMDCANCELAR5.TabIndex = 130
        Me.CMDCANCELAR5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR5.UseVisualStyleBackColor = True
        '
        'CMDCANCELAR4
        '
        Me.CMDCANCELAR4.BackgroundImage = CType(resources.GetObject("CMDCANCELAR4.BackgroundImage"), System.Drawing.Image)
        Me.CMDCANCELAR4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR4.Enabled = False
        Me.CMDCANCELAR4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR4.Location = New System.Drawing.Point(632, 144)
        Me.CMDCANCELAR4.Name = "CMDCANCELAR4"
        Me.CMDCANCELAR4.Size = New System.Drawing.Size(27, 23)
        Me.CMDCANCELAR4.TabIndex = 129
        Me.CMDCANCELAR4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR4.UseVisualStyleBackColor = True
        '
        'CMDCANCELAR3
        '
        Me.CMDCANCELAR3.BackgroundImage = CType(resources.GetObject("CMDCANCELAR3.BackgroundImage"), System.Drawing.Image)
        Me.CMDCANCELAR3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR3.Enabled = False
        Me.CMDCANCELAR3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR3.Location = New System.Drawing.Point(633, 111)
        Me.CMDCANCELAR3.Name = "CMDCANCELAR3"
        Me.CMDCANCELAR3.Size = New System.Drawing.Size(27, 23)
        Me.CMDCANCELAR3.TabIndex = 128
        Me.CMDCANCELAR3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR3.UseVisualStyleBackColor = True
        '
        'CMDCANCELAR2
        '
        Me.CMDCANCELAR2.BackgroundImage = CType(resources.GetObject("CMDCANCELAR2.BackgroundImage"), System.Drawing.Image)
        Me.CMDCANCELAR2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR2.Enabled = False
        Me.CMDCANCELAR2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR2.Location = New System.Drawing.Point(632, 76)
        Me.CMDCANCELAR2.Name = "CMDCANCELAR2"
        Me.CMDCANCELAR2.Size = New System.Drawing.Size(27, 23)
        Me.CMDCANCELAR2.TabIndex = 127
        Me.CMDCANCELAR2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR2.UseVisualStyleBackColor = True
        '
        'CMDCANCELAR1
        '
        Me.CMDCANCELAR1.BackgroundImage = CType(resources.GetObject("CMDCANCELAR1.BackgroundImage"), System.Drawing.Image)
        Me.CMDCANCELAR1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR1.Enabled = False
        Me.CMDCANCELAR1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR1.Location = New System.Drawing.Point(633, 40)
        Me.CMDCANCELAR1.Name = "CMDCANCELAR1"
        Me.CMDCANCELAR1.Size = New System.Drawing.Size(27, 23)
        Me.CMDCANCELAR1.TabIndex = 126
        Me.CMDCANCELAR1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR1.UseVisualStyleBackColor = True
        '
        'CMDGUARDAR5
        '
        Me.CMDGUARDAR5.BackgroundImage = CType(resources.GetObject("CMDGUARDAR5.BackgroundImage"), System.Drawing.Image)
        Me.CMDGUARDAR5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDGUARDAR5.Enabled = False
        Me.CMDGUARDAR5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDGUARDAR5.Location = New System.Drawing.Point(600, 179)
        Me.CMDGUARDAR5.Name = "CMDGUARDAR5"
        Me.CMDGUARDAR5.Size = New System.Drawing.Size(27, 23)
        Me.CMDGUARDAR5.TabIndex = 125
        Me.CMDGUARDAR5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDGUARDAR5.UseVisualStyleBackColor = True
        '
        'CMDGUARDAR4
        '
        Me.CMDGUARDAR4.BackgroundImage = CType(resources.GetObject("CMDGUARDAR4.BackgroundImage"), System.Drawing.Image)
        Me.CMDGUARDAR4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDGUARDAR4.Enabled = False
        Me.CMDGUARDAR4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDGUARDAR4.Location = New System.Drawing.Point(599, 144)
        Me.CMDGUARDAR4.Name = "CMDGUARDAR4"
        Me.CMDGUARDAR4.Size = New System.Drawing.Size(27, 23)
        Me.CMDGUARDAR4.TabIndex = 124
        Me.CMDGUARDAR4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDGUARDAR4.UseVisualStyleBackColor = True
        '
        'CMDGUARDAR3
        '
        Me.CMDGUARDAR3.BackgroundImage = CType(resources.GetObject("CMDGUARDAR3.BackgroundImage"), System.Drawing.Image)
        Me.CMDGUARDAR3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDGUARDAR3.Enabled = False
        Me.CMDGUARDAR3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDGUARDAR3.Location = New System.Drawing.Point(600, 111)
        Me.CMDGUARDAR3.Name = "CMDGUARDAR3"
        Me.CMDGUARDAR3.Size = New System.Drawing.Size(27, 23)
        Me.CMDGUARDAR3.TabIndex = 123
        Me.CMDGUARDAR3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDGUARDAR3.UseVisualStyleBackColor = True
        '
        'CMDGUARDAR2
        '
        Me.CMDGUARDAR2.BackgroundImage = CType(resources.GetObject("CMDGUARDAR2.BackgroundImage"), System.Drawing.Image)
        Me.CMDGUARDAR2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDGUARDAR2.Enabled = False
        Me.CMDGUARDAR2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDGUARDAR2.Location = New System.Drawing.Point(599, 76)
        Me.CMDGUARDAR2.Name = "CMDGUARDAR2"
        Me.CMDGUARDAR2.Size = New System.Drawing.Size(27, 23)
        Me.CMDGUARDAR2.TabIndex = 122
        Me.CMDGUARDAR2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDGUARDAR2.UseVisualStyleBackColor = True
        '
        'CMDGUARDAR1
        '
        Me.CMDGUARDAR1.BackgroundImage = CType(resources.GetObject("CMDGUARDAR1.BackgroundImage"), System.Drawing.Image)
        Me.CMDGUARDAR1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDGUARDAR1.Enabled = False
        Me.CMDGUARDAR1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDGUARDAR1.Location = New System.Drawing.Point(600, 40)
        Me.CMDGUARDAR1.Name = "CMDGUARDAR1"
        Me.CMDGUARDAR1.Size = New System.Drawing.Size(27, 23)
        Me.CMDGUARDAR1.TabIndex = 121
        Me.CMDGUARDAR1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDGUARDAR1.UseVisualStyleBackColor = True
        '
        'CMDCANCELAR8
        '
        Me.CMDCANCELAR8.BackgroundImage = CType(resources.GetObject("CMDCANCELAR8.BackgroundImage"), System.Drawing.Image)
        Me.CMDCANCELAR8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR8.Enabled = False
        Me.CMDCANCELAR8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR8.Location = New System.Drawing.Point(633, 285)
        Me.CMDCANCELAR8.Name = "CMDCANCELAR8"
        Me.CMDCANCELAR8.Size = New System.Drawing.Size(27, 23)
        Me.CMDCANCELAR8.TabIndex = 136
        Me.CMDCANCELAR8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR8.UseVisualStyleBackColor = True
        '
        'CMDCANCELAR7
        '
        Me.CMDCANCELAR7.BackgroundImage = CType(resources.GetObject("CMDCANCELAR7.BackgroundImage"), System.Drawing.Image)
        Me.CMDCANCELAR7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR7.Enabled = False
        Me.CMDCANCELAR7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR7.Location = New System.Drawing.Point(631, 246)
        Me.CMDCANCELAR7.Name = "CMDCANCELAR7"
        Me.CMDCANCELAR7.Size = New System.Drawing.Size(27, 23)
        Me.CMDCANCELAR7.TabIndex = 135
        Me.CMDCANCELAR7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR7.UseVisualStyleBackColor = True
        '
        'CMDCANCELAR6
        '
        Me.CMDCANCELAR6.BackgroundImage = CType(resources.GetObject("CMDCANCELAR6.BackgroundImage"), System.Drawing.Image)
        Me.CMDCANCELAR6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR6.Enabled = False
        Me.CMDCANCELAR6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR6.Location = New System.Drawing.Point(632, 213)
        Me.CMDCANCELAR6.Name = "CMDCANCELAR6"
        Me.CMDCANCELAR6.Size = New System.Drawing.Size(27, 23)
        Me.CMDCANCELAR6.TabIndex = 134
        Me.CMDCANCELAR6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR6.UseVisualStyleBackColor = True
        '
        'CMDGUARDAR8
        '
        Me.CMDGUARDAR8.BackgroundImage = CType(resources.GetObject("CMDGUARDAR8.BackgroundImage"), System.Drawing.Image)
        Me.CMDGUARDAR8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDGUARDAR8.Enabled = False
        Me.CMDGUARDAR8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDGUARDAR8.Location = New System.Drawing.Point(600, 285)
        Me.CMDGUARDAR8.Name = "CMDGUARDAR8"
        Me.CMDGUARDAR8.Size = New System.Drawing.Size(27, 23)
        Me.CMDGUARDAR8.TabIndex = 133
        Me.CMDGUARDAR8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDGUARDAR8.UseVisualStyleBackColor = True
        '
        'CMDGUARDAR7
        '
        Me.CMDGUARDAR7.BackgroundImage = CType(resources.GetObject("CMDGUARDAR7.BackgroundImage"), System.Drawing.Image)
        Me.CMDGUARDAR7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDGUARDAR7.Enabled = False
        Me.CMDGUARDAR7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDGUARDAR7.Location = New System.Drawing.Point(598, 246)
        Me.CMDGUARDAR7.Name = "CMDGUARDAR7"
        Me.CMDGUARDAR7.Size = New System.Drawing.Size(27, 23)
        Me.CMDGUARDAR7.TabIndex = 132
        Me.CMDGUARDAR7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDGUARDAR7.UseVisualStyleBackColor = True
        '
        'CMDGUARDAR6
        '
        Me.CMDGUARDAR6.BackgroundImage = CType(resources.GetObject("CMDGUARDAR6.BackgroundImage"), System.Drawing.Image)
        Me.CMDGUARDAR6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDGUARDAR6.Enabled = False
        Me.CMDGUARDAR6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDGUARDAR6.Location = New System.Drawing.Point(599, 213)
        Me.CMDGUARDAR6.Name = "CMDGUARDAR6"
        Me.CMDGUARDAR6.Size = New System.Drawing.Size(27, 23)
        Me.CMDGUARDAR6.TabIndex = 131
        Me.CMDGUARDAR6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDGUARDAR6.UseVisualStyleBackColor = True
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Image = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDCANCELAR.Location = New System.Drawing.Point(301, 422)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(100, 57)
        Me.CMDCANCELAR.TabIndex = 138
        Me.CMDCANCELAR.Text = "CERRAR"
        Me.CMDCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'CMDIMPRIMIR
        '
        Me.CMDIMPRIMIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDIMPRIMIR.Enabled = False
        Me.CMDIMPRIMIR.Image = Global.SAC.My.Resources.Resources.GUARDAR_REGISTRO1
        Me.CMDIMPRIMIR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDIMPRIMIR.Location = New System.Drawing.Point(195, 422)
        Me.CMDIMPRIMIR.Name = "CMDIMPRIMIR"
        Me.CMDIMPRIMIR.Size = New System.Drawing.Size(100, 57)
        Me.CMDIMPRIMIR.TabIndex = 137
        Me.CMDIMPRIMIR.Text = "GUARDAR"
        Me.CMDIMPRIMIR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDIMPRIMIR.UseVisualStyleBackColor = True
        '
        'LBLMONTOBASE
        '
        Me.LBLMONTOBASE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARUNIFORMESPORSEXOBindingSource, "MONTO", True))
        Me.LBLMONTOBASE.Location = New System.Drawing.Point(362, 51)
        Me.LBLMONTOBASE.Name = "LBLMONTOBASE"
        Me.LBLMONTOBASE.Size = New System.Drawing.Size(100, 23)
        Me.LBLMONTOBASE.TabIndex = 139
        Me.LBLMONTOBASE.Text = "MONTO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(385, 394)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "TOTAL:"
        '
        'LBLTOTAL
        '
        Me.LBLTOTAL.AutoSize = True
        Me.LBLTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTOTAL.Location = New System.Drawing.Point(465, 394)
        Me.LBLTOTAL.Name = "LBLTOTAL"
        Me.LBLTOTAL.Size = New System.Drawing.Size(19, 20)
        Me.LBLTOTAL.TabIndex = 141
        Me.LBLTOTAL.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LBLIDPRODUC8)
        Me.GroupBox1.Controls.Add(Me.LBLIDPRODUC7)
        Me.GroupBox1.Controls.Add(Me.LBLIDPRODUC6)
        Me.GroupBox1.Controls.Add(Me.LBLIDPRODUC5)
        Me.GroupBox1.Controls.Add(Me.LBLIDPRODUC4)
        Me.GroupBox1.Controls.Add(Me.LBLIDPRODUC3)
        Me.GroupBox1.Controls.Add(Me.LBLIDPRODUC1)
        Me.GroupBox1.Controls.Add(Me.LBLIDPRODUC2)
        Me.GroupBox1.Controls.Add(Me.CMDCANCELAR8)
        Me.GroupBox1.Controls.Add(Me.CMDCANCELAR7)
        Me.GroupBox1.Controls.Add(Me.CMDCANCELAR6)
        Me.GroupBox1.Controls.Add(Me.CMDGUARDAR8)
        Me.GroupBox1.Controls.Add(Me.CMDGUARDAR7)
        Me.GroupBox1.Controls.Add(Me.CMDGUARDAR6)
        Me.GroupBox1.Controls.Add(Me.CMDCANCELAR5)
        Me.GroupBox1.Controls.Add(Me.CMDCANCELAR4)
        Me.GroupBox1.Controls.Add(Me.CMDCANCELAR3)
        Me.GroupBox1.Controls.Add(Me.CMDCANCELAR2)
        Me.GroupBox1.Controls.Add(Me.CMDCANCELAR1)
        Me.GroupBox1.Controls.Add(Me.CMDGUARDAR5)
        Me.GroupBox1.Controls.Add(Me.CMDGUARDAR4)
        Me.GroupBox1.Controls.Add(Me.CMDGUARDAR3)
        Me.GroupBox1.Controls.Add(Me.CMDGUARDAR2)
        Me.GroupBox1.Controls.Add(Me.CMDGUARDAR1)
        Me.GroupBox1.Controls.Add(Me.LBLCANT8)
        Me.GroupBox1.Controls.Add(Me.LBLCANT7)
        Me.GroupBox1.Controls.Add(Me.LBLCANT6)
        Me.GroupBox1.Controls.Add(Me.LBLMONTO8)
        Me.GroupBox1.Controls.Add(Me.LBLMONTO7)
        Me.GroupBox1.Controls.Add(Me.LBLMONTO6)
        Me.GroupBox1.Controls.Add(Me.LBLCONCEPTO8)
        Me.GroupBox1.Controls.Add(Me.LBLCONCEPTO7)
        Me.GroupBox1.Controls.Add(Me.LBLCONCEPTO6)
        Me.GroupBox1.Controls.Add(Me.LBLCANT5)
        Me.GroupBox1.Controls.Add(Me.LBLCANT4)
        Me.GroupBox1.Controls.Add(Me.LBLCANT3)
        Me.GroupBox1.Controls.Add(Me.LBLCANT2)
        Me.GroupBox1.Controls.Add(Me.LBLCANT1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LBLMONTO5)
        Me.GroupBox1.Controls.Add(Me.LBLMONTO4)
        Me.GroupBox1.Controls.Add(Me.LBLMONTO3)
        Me.GroupBox1.Controls.Add(Me.LBLMONTO2)
        Me.GroupBox1.Controls.Add(Me.LBLMONTO1)
        Me.GroupBox1.Controls.Add(Me.LBLCONCEPTO5)
        Me.GroupBox1.Controls.Add(Me.LBLCONCEPTO4)
        Me.GroupBox1.Controls.Add(Me.LBLCONCEPTO3)
        Me.GroupBox1.Controls.Add(Me.LBLCONCEPTO2)
        Me.GroupBox1.Controls.Add(Me.LBLCONCEPTO1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(689, 321)
        Me.GroupBox1.TabIndex = 142
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "UNIFORMES "
        '
        'LBLIDPRODUC8
        '
        Me.LBLIDPRODUC8.AutoSize = True
        Me.LBLIDPRODUC8.Location = New System.Drawing.Point(6, 290)
        Me.LBLIDPRODUC8.Name = "LBLIDPRODUC8"
        Me.LBLIDPRODUC8.Size = New System.Drawing.Size(23, 18)
        Me.LBLIDPRODUC8.TabIndex = 144
        Me.LBLIDPRODUC8.Text = "ID"
        '
        'LBLIDPRODUC7
        '
        Me.LBLIDPRODUC7.AutoSize = True
        Me.LBLIDPRODUC7.Location = New System.Drawing.Point(6, 255)
        Me.LBLIDPRODUC7.Name = "LBLIDPRODUC7"
        Me.LBLIDPRODUC7.Size = New System.Drawing.Size(23, 18)
        Me.LBLIDPRODUC7.TabIndex = 143
        Me.LBLIDPRODUC7.Text = "ID"
        '
        'LBLIDPRODUC6
        '
        Me.LBLIDPRODUC6.AutoSize = True
        Me.LBLIDPRODUC6.Location = New System.Drawing.Point(6, 218)
        Me.LBLIDPRODUC6.Name = "LBLIDPRODUC6"
        Me.LBLIDPRODUC6.Size = New System.Drawing.Size(23, 18)
        Me.LBLIDPRODUC6.TabIndex = 142
        Me.LBLIDPRODUC6.Text = "ID"
        '
        'LBLIDPRODUC5
        '
        Me.LBLIDPRODUC5.AutoSize = True
        Me.LBLIDPRODUC5.Location = New System.Drawing.Point(6, 184)
        Me.LBLIDPRODUC5.Name = "LBLIDPRODUC5"
        Me.LBLIDPRODUC5.Size = New System.Drawing.Size(23, 18)
        Me.LBLIDPRODUC5.TabIndex = 141
        Me.LBLIDPRODUC5.Text = "ID"
        '
        'LBLIDPRODUC4
        '
        Me.LBLIDPRODUC4.AutoSize = True
        Me.LBLIDPRODUC4.Location = New System.Drawing.Point(6, 149)
        Me.LBLIDPRODUC4.Name = "LBLIDPRODUC4"
        Me.LBLIDPRODUC4.Size = New System.Drawing.Size(23, 18)
        Me.LBLIDPRODUC4.TabIndex = 140
        Me.LBLIDPRODUC4.Text = "ID"
        '
        'LBLIDPRODUC3
        '
        Me.LBLIDPRODUC3.AutoSize = True
        Me.LBLIDPRODUC3.Location = New System.Drawing.Point(6, 112)
        Me.LBLIDPRODUC3.Name = "LBLIDPRODUC3"
        Me.LBLIDPRODUC3.Size = New System.Drawing.Size(23, 18)
        Me.LBLIDPRODUC3.TabIndex = 139
        Me.LBLIDPRODUC3.Text = "ID"
        '
        'LBLIDPRODUC1
        '
        Me.LBLIDPRODUC1.AutoSize = True
        Me.LBLIDPRODUC1.Location = New System.Drawing.Point(6, 45)
        Me.LBLIDPRODUC1.Name = "LBLIDPRODUC1"
        Me.LBLIDPRODUC1.Size = New System.Drawing.Size(23, 18)
        Me.LBLIDPRODUC1.TabIndex = 137
        Me.LBLIDPRODUC1.Text = "ID"
        '
        'LBLIDPRODUC2
        '
        Me.LBLIDPRODUC2.AutoSize = True
        Me.LBLIDPRODUC2.Location = New System.Drawing.Point(6, 77)
        Me.LBLIDPRODUC2.Name = "LBLIDPRODUC2"
        Me.LBLIDPRODUC2.Size = New System.Drawing.Size(23, 18)
        Me.LBLIDPRODUC2.TabIndex = 138
        Me.LBLIDPRODUC2.Text = "ID"
        '
        'SELECCIONARPRINTMAXIMOBindingSource
        '
        Me.SELECCIONARPRINTMAXIMOBindingSource.DataMember = "SELECCIONARPRINTMAXIMO"
        Me.SELECCIONARPRINTMAXIMOBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARPRINTMAXIMOTableAdapter
        '
        Me.SELECCIONARPRINTMAXIMOTableAdapter.ClearBeforeFill = True
        '
        'LBLIDPRINTMAX
        '
        Me.LBLIDPRINTMAX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECCIONARPRINTMAXIMOBindingSource, "IDPRINT", True))
        Me.LBLIDPRINTMAX.Location = New System.Drawing.Point(11, 469)
        Me.LBLIDPRINTMAX.Name = "LBLIDPRINTMAX"
        Me.LBLIDPRINTMAX.Size = New System.Drawing.Size(100, 23)
        Me.LBLIDPRINTMAX.TabIndex = 143
        Me.LBLIDPRINTMAX.Text = "IDPRINTMAX"
        '
        'LBLIDPRINTNEW
        '
        Me.LBLIDPRINTNEW.AutoSize = True
        Me.LBLIDPRINTNEW.Location = New System.Drawing.Point(11, 440)
        Me.LBLIDPRINTNEW.Name = "LBLIDPRINTNEW"
        Me.LBLIDPRINTNEW.Size = New System.Drawing.Size(68, 18)
        Me.LBLIDPRINTNEW.TabIndex = 144
        Me.LBLIDPRINTNEW.Text = "IDPRINT"
        '
        'CMDIMPRIMIT
        '
        Me.CMDIMPRIMIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDIMPRIMIT.Image = Global.SAC.My.Resources.Resources.PRINTER
        Me.CMDIMPRIMIT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMDIMPRIMIT.Location = New System.Drawing.Point(409, 422)
        Me.CMDIMPRIMIT.Name = "CMDIMPRIMIT"
        Me.CMDIMPRIMIT.Size = New System.Drawing.Size(100, 57)
        Me.CMDIMPRIMIT.TabIndex = 145
        Me.CMDIMPRIMIT.Text = "IMPRIMIR"
        Me.CMDIMPRIMIT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CMDIMPRIMIT.UseVisualStyleBackColor = True
        '
        'SELECCIONARUNIFORMESPORSEXOBindingSource
        '
        Me.SELECCIONARUNIFORMESPORSEXOBindingSource.DataMember = "SELECCIONARUNIFORMESPORSEXO"
        Me.SELECCIONARUNIFORMESPORSEXOBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARUNIFORMESPORSEXOTableAdapter
        '
        Me.SELECCIONARUNIFORMESPORSEXOTableAdapter.ClearBeforeFill = True
        '
        'UNIFORMES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 509)
        Me.Controls.Add(Me.CMDIMPRIMIT)
        Me.Controls.Add(Me.LBLIDPRINTNEW)
        Me.Controls.Add(Me.LBLIDPRINTMAX)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LBLTOTAL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(MontoLabel)
        Me.Controls.Add(Me.LBLMONTOBASE)
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.CMDIMPRIMIR)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.CBOUNIFORMES)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UNIFORMES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UNIFORMES"
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SELECCIONARPRINTMAXIMOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARUNIFORMESPORSEXOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CBOUNIFORMES As System.Windows.Forms.ComboBox
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents LBLCANT5 As System.Windows.Forms.Label
    Friend WithEvents LBLCANT4 As System.Windows.Forms.Label
    Friend WithEvents LBLCANT3 As System.Windows.Forms.Label
    Friend WithEvents LBLCANT2 As System.Windows.Forms.Label
    Friend WithEvents LBLCANT1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LBLMONTO5 As System.Windows.Forms.Label
    Friend WithEvents LBLMONTO4 As System.Windows.Forms.Label
    Friend WithEvents LBLMONTO3 As System.Windows.Forms.Label
    Friend WithEvents LBLMONTO2 As System.Windows.Forms.Label
    Friend WithEvents LBLMONTO1 As System.Windows.Forms.Label
    Friend WithEvents LBLCONCEPTO5 As System.Windows.Forms.Label
    Friend WithEvents LBLCONCEPTO4 As System.Windows.Forms.Label
    Friend WithEvents LBLCONCEPTO3 As System.Windows.Forms.Label
    Friend WithEvents LBLCONCEPTO2 As System.Windows.Forms.Label
    Friend WithEvents LBLCONCEPTO1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LBLCANT8 As System.Windows.Forms.Label
    Friend WithEvents LBLCANT7 As System.Windows.Forms.Label
    Friend WithEvents LBLCANT6 As System.Windows.Forms.Label
    Friend WithEvents LBLMONTO8 As System.Windows.Forms.Label
    Friend WithEvents LBLMONTO7 As System.Windows.Forms.Label
    Friend WithEvents LBLMONTO6 As System.Windows.Forms.Label
    Friend WithEvents LBLCONCEPTO8 As System.Windows.Forms.Label
    Friend WithEvents LBLCONCEPTO7 As System.Windows.Forms.Label
    Friend WithEvents LBLCONCEPTO6 As System.Windows.Forms.Label
    Friend WithEvents CMDCANCELAR5 As System.Windows.Forms.Button
    Friend WithEvents CMDCANCELAR4 As System.Windows.Forms.Button
    Friend WithEvents CMDCANCELAR3 As System.Windows.Forms.Button
    Friend WithEvents CMDCANCELAR2 As System.Windows.Forms.Button
    Friend WithEvents CMDCANCELAR1 As System.Windows.Forms.Button
    Friend WithEvents CMDGUARDAR5 As System.Windows.Forms.Button
    Friend WithEvents CMDGUARDAR4 As System.Windows.Forms.Button
    Friend WithEvents CMDGUARDAR3 As System.Windows.Forms.Button
    Friend WithEvents CMDGUARDAR2 As System.Windows.Forms.Button
    Friend WithEvents CMDGUARDAR1 As System.Windows.Forms.Button
    Friend WithEvents CMDCANCELAR8 As System.Windows.Forms.Button
    Friend WithEvents CMDCANCELAR7 As System.Windows.Forms.Button
    Friend WithEvents CMDCANCELAR6 As System.Windows.Forms.Button
    Friend WithEvents CMDGUARDAR8 As System.Windows.Forms.Button
    Friend WithEvents CMDGUARDAR7 As System.Windows.Forms.Button
    Friend WithEvents CMDGUARDAR6 As System.Windows.Forms.Button
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents CMDIMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents LBLMONTOBASE As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LBLTOTAL As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LBLIDPRODUC8 As System.Windows.Forms.Label
    Friend WithEvents LBLIDPRODUC7 As System.Windows.Forms.Label
    Friend WithEvents LBLIDPRODUC6 As System.Windows.Forms.Label
    Friend WithEvents LBLIDPRODUC5 As System.Windows.Forms.Label
    Friend WithEvents LBLIDPRODUC4 As System.Windows.Forms.Label
    Friend WithEvents LBLIDPRODUC3 As System.Windows.Forms.Label
    Friend WithEvents LBLIDPRODUC1 As System.Windows.Forms.Label
    Friend WithEvents LBLIDPRODUC2 As System.Windows.Forms.Label
    Friend WithEvents SELECCIONARPRINTMAXIMOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARPRINTMAXIMOTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARPRINTMAXIMOTableAdapter
    Friend WithEvents LBLIDPRINTMAX As System.Windows.Forms.Label
    Friend WithEvents LBLIDPRINTNEW As System.Windows.Forms.Label
    Friend WithEvents CMDIMPRIMIT As System.Windows.Forms.Button
    Friend WithEvents SELECCIONARUNIFORMESPORSEXOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARUNIFORMESPORSEXOTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARUNIFORMESPORSEXOTableAdapter
End Class
