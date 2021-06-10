<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NUEVOPASSWORD
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
        Me.CMDRESETEAR = New System.Windows.Forms.Button()
        Me.SACDataSet = New SAC.SACDataSet()
        Me.SELECCIONARUSUARIOSPASSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARUSUARIOSPASSTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARUSUARIOSPASSTableAdapter()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARUSUARIOSPASSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CMDRESETEAR
        '
        Me.CMDRESETEAR.Location = New System.Drawing.Point(182, 59)
        Me.CMDRESETEAR.Name = "CMDRESETEAR"
        Me.CMDRESETEAR.Size = New System.Drawing.Size(109, 56)
        Me.CMDRESETEAR.TabIndex = 1
        Me.CMDRESETEAR.Text = "RESETEAR"
        Me.CMDRESETEAR.UseVisualStyleBackColor = True
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SELECCIONARUSUARIOSPASSBindingSource
        '
        Me.SELECCIONARUSUARIOSPASSBindingSource.DataMember = "SELECCIONARUSUARIOSPASS"
        Me.SELECCIONARUSUARIOSPASSBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARUSUARIOSPASSTableAdapter
        '
        Me.SELECCIONARUSUARIOSPASSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.SELECCIONARUSUARIOSPASSBindingSource
        Me.ComboBox1.DisplayMember = "usuario"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(107, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(266, 26)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "idus"
        '
        'NUEVOPASSWORD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 137)
        Me.Controls.Add(Me.CMDRESETEAR)
        Me.Controls.Add(Me.ComboBox1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NUEVOPASSWORD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NUEVO PASSWORD"
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARUSUARIOSPASSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMDRESETEAR As System.Windows.Forms.Button
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents SELECCIONARUSUARIOSPASSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARUSUARIOSPASSTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARUSUARIOSPASSTableAdapter
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
