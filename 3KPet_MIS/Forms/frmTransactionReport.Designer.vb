﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransactionReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransactionReport))
        Me.rpvTrans = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dsTransactions = New _3KPet_MIS.dsTransactions()
        Me.dtTransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dsTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rpvTrans
        '
        Me.rpvTrans.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rpvTrans.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReportDataSource1.Name = "dsTransaction"
        ReportDataSource1.Value = Me.dtTransactionBindingSource
        Me.rpvTrans.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvTrans.LocalReport.ReportEmbeddedResource = "_3KPet_MIS.rpTransactions.rdlc"
        Me.rpvTrans.Location = New System.Drawing.Point(11, 11)
        Me.rpvTrans.Name = "rpvTrans"
        Me.rpvTrans.Size = New System.Drawing.Size(1147, 634)
        Me.rpvTrans.TabIndex = 0
        '
        'dsTransactions
        '
        Me.dsTransactions.DataSetName = "dsTransactions"
        Me.dsTransactions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtTransactionBindingSource
        '
        Me.dtTransactionBindingSource.DataMember = "dtTransaction"
        Me.dtTransactionBindingSource.DataSource = Me.dsTransactions
        '
        'frmTransactionReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 650)
        Me.Controls.Add(Me.rpvTrans)
        Me.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTransactionReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dsTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rpvTrans As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtTransactionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsTransactions As _3KPet_MIS.dsTransactions
End Class
