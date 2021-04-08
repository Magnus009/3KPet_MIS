<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductsReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductsReport))
        Me.rpvProducts = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dsPurchasedProd = New _3KPet_MIS.dsPurchasedProd()
        Me.dtProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dsPurchasedProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rpvProducts
        '
        Me.rpvProducts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "dsPurchasedProd"
        ReportDataSource1.Value = Me.dtProductsBindingSource
        Me.rpvProducts.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvProducts.LocalReport.ReportEmbeddedResource = "_3KPet_MIS.rpProducts.rdlc"
        Me.rpvProducts.Location = New System.Drawing.Point(1, 3)
        Me.rpvProducts.Name = "rpvProducts"
        Me.rpvProducts.Size = New System.Drawing.Size(660, 345)
        Me.rpvProducts.TabIndex = 0
        '
        'dsPurchasedProd
        '
        Me.dsPurchasedProd.DataSetName = "dsPurchasedProd"
        Me.dsPurchasedProd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtProductsBindingSource
        '
        Me.dtProductsBindingSource.DataMember = "dtProducts"
        Me.dtProductsBindingSource.DataSource = Me.dsPurchasedProd
        '
        'frmProductsReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 350)
        Me.Controls.Add(Me.rpvProducts)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductsReport"
        Me.Text = "Product Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dsPurchasedProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rpvProducts As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsPurchasedProd As _3KPet_MIS.dsPurchasedProd
End Class
