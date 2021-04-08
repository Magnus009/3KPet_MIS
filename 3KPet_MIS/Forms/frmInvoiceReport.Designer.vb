<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoiceReport
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoiceReport))
        Me.rpvInvoice = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dsInvoice = New _3KPet_MIS.dsInvoice()
        Me.dtInvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dsInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtInvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rpvInvoice
        '
        Me.rpvInvoice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "dsInvoice"
        ReportDataSource1.Value = Me.dtInvoiceBindingSource
        Me.rpvInvoice.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvInvoice.LocalReport.ReportEmbeddedResource = "_3KPet_MIS.rpInvoice.rdlc"
        Me.rpvInvoice.Location = New System.Drawing.Point(3, 1)
        Me.rpvInvoice.Name = "rpvInvoice"
        Me.rpvInvoice.Size = New System.Drawing.Size(476, 356)
        Me.rpvInvoice.TabIndex = 0
        '
        'dsInvoice
        '
        Me.dsInvoice.DataSetName = "dsInvoice"
        Me.dsInvoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtInvoiceBindingSource
        '
        Me.dtInvoiceBindingSource.DataMember = "dtInvoice"
        Me.dtInvoiceBindingSource.DataSource = Me.dsInvoice
        '
        'frmInvoiceReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 360)
        Me.Controls.Add(Me.rpvInvoice)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInvoiceReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dsInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtInvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rpvInvoice As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtInvoiceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsInvoice As _3KPet_MIS.dsInvoice
End Class
