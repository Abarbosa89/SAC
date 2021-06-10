<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DATOSPERTUTOR
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
        Me.CMDCANCELAR = New System.Windows.Forms.Button()
        Me.CMDGUARDAR = New System.Windows.Forms.Button()
        Me.TXTAPMATERNO = New System.Windows.Forms.TextBox()
        Me.TXTAPPATERNO = New System.Windows.Forms.TextBox()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SACDataSet = New SAC.SACDataSet()
        Me.IDTUTORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDTUTORTableAdapter = New SAC.SACDataSetTableAdapters.IDTUTORTableAdapter()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.IdtutLabel1 = New System.Windows.Forms.Label()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDTUTORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CMDCANCELAR
        '
        Me.CMDCANCELAR.BackgroundImage = Global.SAC.My.Resources.Resources.ELIMINAR_REGISTRO
        Me.CMDCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCANCELAR.Location = New System.Drawing.Point(282, 152)
        Me.CMDCANCELAR.Name = "CMDCANCELAR"
        Me.CMDCANCELAR.Size = New System.Drawing.Size(42, 40)
        Me.CMDCANCELAR.TabIndex = 35
        Me.CMDCANCELAR.UseVisualStyleBackColor = True
        '
        'CMDGUARDAR
        '
        Me.CMDGUARDAR.BackgroundImage = Global.SAC.My.Resources.Resources.GUARDAR_REGISTRO1
        Me.CMDGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDGUARDAR.Location = New System.Drawing.Point(214, 152)
        Me.CMDGUARDAR.Name = "CMDGUARDAR"
        Me.CMDGUARDAR.Size = New System.Drawing.Size(44, 40)
        Me.CMDGUARDAR.TabIndex = 34
        Me.CMDGUARDAR.UseVisualStyleBackColor = True
        '
        'TXTAPMATERNO
        '
        Me.TXTAPMATERNO.Location = New System.Drawing.Point(140, 110)
        Me.TXTAPMATERNO.Name = "TXTAPMATERNO"
        Me.TXTAPMATERNO.Size = New System.Drawing.Size(349, 26)
        Me.TXTAPMATERNO.TabIndex = 3
        '
        'TXTAPPATERNO
        '
        Me.TXTAPPATERNO.Location = New System.Drawing.Point(140, 62)
        Me.TXTAPPATERNO.Name = "TXTAPPATERNO"
        Me.TXTAPPATERNO.Size = New System.Drawing.Size(349, 26)
        Me.TXTAPPATERNO.TabIndex = 2
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Location = New System.Drawing.Point(140, 18)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(349, 26)
        Me.TXTNOMBRE.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 18)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Apellido Materno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 18)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Apellido Paterno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 18)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Nombre(s)"
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IDTUTORBindingSource
        '
        Me.IDTUTORBindingSource.DataMember = "IDTUTOR"
        Me.IDTUTORBindingSource.DataSource = Me.SACDataSet
        '
        'IDTUTORTableAdapter
        '
        Me.IDTUTORTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdtutLabel1
        '
        Me.IdtutLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDTUTORBindingSource, "idtut", True))
        Me.IdtutLabel1.Location = New System.Drawing.Point(397, 152)
        Me.IdtutLabel1.Name = "IdtutLabel1"
        Me.IdtutLabel1.Size = New System.Drawing.Size(100, 23)
        Me.IdtutLabel1.TabIndex = 37
        Me.IdtutLabel1.Text = "Label4"
        '
        'DATOSPERTUTOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 202)
        Me.ControlBox = False
        Me.Controls.Add(Me.IdtutLabel1)
        Me.Controls.Add(Me.CMDCANCELAR)
        Me.Controls.Add(Me.CMDGUARDAR)
        Me.Controls.Add(Me.TXTAPMATERNO)
        Me.Controls.Add(Me.TXTAPPATERNO)
        Me.Controls.Add(Me.TXTNOMBRE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DATOSPERTUTOR"
        Me.Text = "DATOSPERTUTOR"
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDTUTORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDCANCELAR As System.Windows.Forms.Button
    Friend WithEvents CMDGUARDAR As System.Windows.Forms.Button
    Friend WithEvents TXTAPMATERNO As System.Windows.Forms.TextBox
    Friend WithEvents TXTAPPATERNO As System.Windows.Forms.TextBox
    Friend WithEvents TXTNOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents IDTUTORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IDTUTORTableAdapter As SAC.SACDataSetTableAdapters.IDTUTORTableAdapter
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdtutLabel1 As System.Windows.Forms.Label
End Class
