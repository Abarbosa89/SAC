<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LISTAALUMNOPORGRUPOO
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
        Me.SELECCIONARLISTAPORGRUPOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECCIONARLISTAPORGRUPOTableAdapter = New SAC.SACDataSetTableAdapters.SELECCIONARLISTAPORGRUPOTableAdapter()
        Me.TableAdapterManager = New SAC.SACDataSetTableAdapters.TableAdapterManager()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECCIONARLISTAPORGRUPOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SACDataSet
        '
        Me.SACDataSet.DataSetName = "SACDataSet"
        Me.SACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SELECCIONARLISTAPORGRUPOBindingSource
        '
        Me.SELECCIONARLISTAPORGRUPOBindingSource.DataMember = "SELECCIONARLISTAPORGRUPO"
        Me.SELECCIONARLISTAPORGRUPOBindingSource.DataSource = Me.SACDataSet
        '
        'SELECCIONARLISTAPORGRUPOTableAdapter
        '
        Me.SELECCIONARLISTAPORGRUPOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAC.SACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(595, 504)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'LISTAALUMNOPORGRUPOO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 504)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "LISTAALUMNOPORGRUPOO"
        Me.Text = "LISTAALUMNOPORGRUPOO"
        CType(Me.SACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECCIONARLISTAPORGRUPOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SACDataSet As SAC.SACDataSet
    Friend WithEvents SELECCIONARLISTAPORGRUPOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECCIONARLISTAPORGRUPOTableAdapter As SAC.SACDataSetTableAdapters.SELECCIONARLISTAPORGRUPOTableAdapter
    Friend WithEvents TableAdapterManager As SAC.SACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
