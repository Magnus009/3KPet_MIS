<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMedHistReport
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMedHistReport))
        Me.dtMedHisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsMedHis = New _3KPet_MIS.dsMedHis()
        Me.dtPetInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rpvMedHistory = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rpvAllHistory = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.dtMedHisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsMedHis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtPetInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtMedHisBindingSource
        '
        Me.dtMedHisBindingSource.DataMember = "dtMedHis"
        Me.dtMedHisBindingSource.DataSource = Me.dsMedHis
        '
        'dsMedHis
        '
        Me.dsMedHis.DataSetName = "dsMedHis"
        Me.dsMedHis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtPetInfoBindingSource
        '
        Me.dtPetInfoBindingSource.DataMember = "dtPetInfo"
        Me.dtPetInfoBindingSource.DataSource = Me.dsMedHis
        '
        'rpvMedHistory
        '
        Me.rpvMedHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "dsMedicalHistory"
        ReportDataSource1.Value = Me.dtMedHisBindingSource
        ReportDataSource2.Name = "dsPetInfo"
        ReportDataSource2.Value = Me.dtPetInfoBindingSource
        Me.rpvMedHistory.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvMedHistory.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rpvMedHistory.LocalReport.ReportEmbeddedResource = "_3KPet_MIS.rpMedicalHistory.rdlc"
        Me.rpvMedHistory.Location = New System.Drawing.Point(8, 8)
        Me.rpvMedHistory.Margin = New System.Windows.Forms.Padding(2)
        Me.rpvMedHistory.Name = "rpvMedHistory"
        Me.rpvMedHistory.Size = New System.Drawing.Size(783, 414)
        Me.rpvMedHistory.TabIndex = 0
        '
        'rpvAllHistory
        '
        Me.rpvAllHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource3.Name = "dsMedicalHistory"
        ReportDataSource3.Value = Me.dtMedHisBindingSource
        ReportDataSource4.Name = "dsPetInfo"
        ReportDataSource4.Value = Me.dtPetInfoBindingSource
        Me.rpvAllHistory.LocalReport.DataSources.Add(ReportDataSource3)
        Me.rpvAllHistory.LocalReport.DataSources.Add(ReportDataSource4)
        Me.rpvAllHistory.LocalReport.ReportEmbeddedResource = "_3KPet_MIS.rpMedicalHistory_All.rdlc"
        Me.rpvAllHistory.Location = New System.Drawing.Point(9, 10)
        Me.rpvAllHistory.Margin = New System.Windows.Forms.Padding(2)
        Me.rpvAllHistory.Name = "rpvAllHistory"
        Me.rpvAllHistory.Size = New System.Drawing.Size(783, 414)
        Me.rpvAllHistory.TabIndex = 1
        '
        'frmMedHistReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 429)
        Me.Controls.Add(Me.rpvAllHistory)
        Me.Controls.Add(Me.rpvMedHistory)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMedHistReport"
        Me.Text = "Medical History Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtMedHisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsMedHis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtPetInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rpvMedHistory As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtMedHisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsMedHis As _3KPet_MIS.dsMedHis
    Friend WithEvents dtPetInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents rpvAllHistory As Microsoft.Reporting.WinForms.ReportViewer
End Class
