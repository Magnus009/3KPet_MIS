<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.mnuDashboard = New System.Windows.Forms.MenuStrip()
        Me.PATIENTSRECORDSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RECORDSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ARCHIVEToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SCHEDULESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MEDICALHISTORIESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INVENTORYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.AUDITTRAILToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACCOUNTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TREATMENTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRODUCTTYPEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SERVICESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.MEDICALHISTORYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSACTIONSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAccount = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACCOUNTSETTINGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.datSchedules = New System.Windows.Forms.DataGridView()
        Me.pnlHeader.SuspendLayout()
        Me.mnuDashboard.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        CType(Me.datSchedules, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Purple
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Controls.Add(Me.mnuDashboard)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(825, 101)
        Me.pnlHeader.TabIndex = 1
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(12, 46)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(328, 33)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "INFORMATION DASHBOARD"
        '
        'mnuDashboard
        '
        Me.mnuDashboard.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuDashboard.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuDashboard.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PATIENTSRECORDSToolStripMenuItem, Me.SCHEDULESToolStripMenuItem, Me.MEDICALHISTORIESToolStripMenuItem, Me.INVENTORYToolStripMenuItem, Me.tsmSettings, Me.tsmReports, Me.mnuAccount, Me.ToolStripMenuItem1})
        Me.mnuDashboard.Location = New System.Drawing.Point(0, 0)
        Me.mnuDashboard.Name = "mnuDashboard"
        Me.mnuDashboard.Size = New System.Drawing.Size(825, 32)
        Me.mnuDashboard.TabIndex = 1
        Me.mnuDashboard.Text = "MenuStrip1"
        '
        'PATIENTSRECORDSToolStripMenuItem
        '
        Me.PATIENTSRECORDSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RECORDSToolStripMenuItem, Me.ARCHIVEToolStripMenuItem1})
        Me.PATIENTSRECORDSToolStripMenuItem.Name = "PATIENTSRECORDSToolStripMenuItem"
        Me.PATIENTSRECORDSToolStripMenuItem.Size = New System.Drawing.Size(124, 28)
        Me.PATIENTSRECORDSToolStripMenuItem.Text = "PATIENT'S RECORDS"
        '
        'RECORDSToolStripMenuItem
        '
        Me.RECORDSToolStripMenuItem.Name = "RECORDSToolStripMenuItem"
        Me.RECORDSToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.RECORDSToolStripMenuItem.Text = "RECORDS"
        '
        'ARCHIVEToolStripMenuItem1
        '
        Me.ARCHIVEToolStripMenuItem1.Name = "ARCHIVEToolStripMenuItem1"
        Me.ARCHIVEToolStripMenuItem1.Size = New System.Drawing.Size(124, 22)
        Me.ARCHIVEToolStripMenuItem1.Text = "ARCHIVE"
        '
        'SCHEDULESToolStripMenuItem
        '
        Me.SCHEDULESToolStripMenuItem.Name = "SCHEDULESToolStripMenuItem"
        Me.SCHEDULESToolStripMenuItem.Size = New System.Drawing.Size(80, 28)
        Me.SCHEDULESToolStripMenuItem.Text = "SCHEDULES"
        '
        'MEDICALHISTORIESToolStripMenuItem
        '
        Me.MEDICALHISTORIESToolStripMenuItem.Name = "MEDICALHISTORIESToolStripMenuItem"
        Me.MEDICALHISTORIESToolStripMenuItem.Size = New System.Drawing.Size(125, 28)
        Me.MEDICALHISTORIESToolStripMenuItem.Text = "MEDICAL HISTORIES"
        '
        'INVENTORYToolStripMenuItem
        '
        Me.INVENTORYToolStripMenuItem.Name = "INVENTORYToolStripMenuItem"
        Me.INVENTORYToolStripMenuItem.Size = New System.Drawing.Size(83, 28)
        Me.INVENTORYToolStripMenuItem.Text = "INVENTORY"
        '
        'tsmSettings
        '
        Me.tsmSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AUDITTRAILToolStripMenuItem, Me.ACCOUNTSToolStripMenuItem, Me.TREATMENTSToolStripMenuItem, Me.PRODUCTTYPEToolStripMenuItem, Me.SERVICESToolStripMenuItem})
        Me.tsmSettings.Name = "tsmSettings"
        Me.tsmSettings.Size = New System.Drawing.Size(69, 28)
        Me.tsmSettings.Text = "SETTINGS"
        '
        'AUDITTRAILToolStripMenuItem
        '
        Me.AUDITTRAILToolStripMenuItem.Name = "AUDITTRAILToolStripMenuItem"
        Me.AUDITTRAILToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.AUDITTRAILToolStripMenuItem.Text = "AUDIT TRAIL"
        '
        'ACCOUNTSToolStripMenuItem
        '
        Me.ACCOUNTSToolStripMenuItem.Name = "ACCOUNTSToolStripMenuItem"
        Me.ACCOUNTSToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ACCOUNTSToolStripMenuItem.Text = "ACCOUNTS"
        '
        'TREATMENTSToolStripMenuItem
        '
        Me.TREATMENTSToolStripMenuItem.Name = "TREATMENTSToolStripMenuItem"
        Me.TREATMENTSToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.TREATMENTSToolStripMenuItem.Text = "TREATMENTS"
        '
        'PRODUCTTYPEToolStripMenuItem
        '
        Me.PRODUCTTYPEToolStripMenuItem.Name = "PRODUCTTYPEToolStripMenuItem"
        Me.PRODUCTTYPEToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.PRODUCTTYPEToolStripMenuItem.Text = "PRODUCT TYPE"
        '
        'SERVICESToolStripMenuItem
        '
        Me.SERVICESToolStripMenuItem.Name = "SERVICESToolStripMenuItem"
        Me.SERVICESToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SERVICESToolStripMenuItem.Text = "SERVICES"
        '
        'tsmReports
        '
        Me.tsmReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MEDICALHISTORYToolStripMenuItem, Me.TRANSACTIONSToolStripMenuItem})
        Me.tsmReports.Name = "tsmReports"
        Me.tsmReports.Size = New System.Drawing.Size(67, 28)
        Me.tsmReports.Text = "REPORTS"
        '
        'MEDICALHISTORYToolStripMenuItem
        '
        Me.MEDICALHISTORYToolStripMenuItem.Name = "MEDICALHISTORYToolStripMenuItem"
        Me.MEDICALHISTORYToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.MEDICALHISTORYToolStripMenuItem.Text = "MEDICAL HISTORY"
        '
        'TRANSACTIONSToolStripMenuItem
        '
        Me.TRANSACTIONSToolStripMenuItem.Name = "TRANSACTIONSToolStripMenuItem"
        Me.TRANSACTIONSToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.TRANSACTIONSToolStripMenuItem.Text = "TRANSACTIONS"
        '
        'mnuAccount
        '
        Me.mnuAccount.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ACCOUNTSETTINGToolStripMenuItem, Me.LOGOUTToolStripMenuItem})
        Me.mnuAccount.Image = Global._3KPet_MIS.My.Resources.Resources.user_Black_
        Me.mnuAccount.Name = "mnuAccount"
        Me.mnuAccount.Size = New System.Drawing.Size(36, 28)
        '
        'ACCOUNTSETTINGToolStripMenuItem
        '
        Me.ACCOUNTSETTINGToolStripMenuItem.Name = "ACCOUNTSETTINGToolStripMenuItem"
        Me.ACCOUNTSETTINGToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ACCOUNTSETTINGToolStripMenuItem.Text = "ACCOUNT SETTING"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.LOGOUTToolStripMenuItem.Text = "LOG OUT"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 28)
        '
        'pnlContent
        '
        Me.pnlContent.Controls.Add(Me.datSchedules)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 101)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(825, 383)
        Me.pnlContent.TabIndex = 2
        '
        'datSchedules
        '
        Me.datSchedules.AllowUserToAddRows = False
        Me.datSchedules.AllowUserToDeleteRows = False
        Me.datSchedules.AllowUserToResizeColumns = False
        Me.datSchedules.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datSchedules.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datSchedules.DefaultCellStyle = DataGridViewCellStyle2
        Me.datSchedules.Location = New System.Drawing.Point(9, 6)
        Me.datSchedules.Name = "datSchedules"
        Me.datSchedules.ReadOnly = True
        Me.datSchedules.RowHeadersVisible = False
        Me.datSchedules.Size = New System.Drawing.Size(805, 365)
        Me.datSchedules.TabIndex = 0
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(825, 484)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuDashboard
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "3K Pet Solution Management Information System"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.mnuDashboard.ResumeLayout(False)
        Me.mnuDashboard.PerformLayout()
        Me.pnlContent.ResumeLayout(False)
        CType(Me.datSchedules, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents mnuDashboard As System.Windows.Forms.MenuStrip
    Friend WithEvents PATIENTSRECORDSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RECORDSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SCHEDULESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MEDICALHISTORIESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AUDITTRAILToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ACCOUNTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TREATMENTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents datSchedules As System.Windows.Forms.DataGridView
    Friend WithEvents mnuAccount As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ARCHIVEToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents INVENTORYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmReports As ToolStripMenuItem
    Friend WithEvents tsmSettings As ToolStripMenuItem
    Friend WithEvents ACCOUNTSETTINGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PRODUCTTYPEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SERVICESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MEDICALHISTORYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRANSACTIONSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
