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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.pnlNav = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.picDrawer = New System.Windows.Forms.PictureBox()
        Me.btnAddRecord = New System.Windows.Forms.Button()
        Me.btnUpdateRecord = New System.Windows.Forms.Button()
        Me.btnSchedule = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.picMenu = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.tabInformations = New System.Windows.Forms.TabControl()
        Me.tabOwner = New System.Windows.Forms.TabPage()
        Me.lblOwnerSearch = New System.Windows.Forms.Label()
        Me.txtOwnerSearch = New System.Windows.Forms.TextBox()
        Me.datOwnerInfo = New System.Windows.Forms.DataGridView()
        Me.tabPet = New System.Windows.Forms.TabPage()
        Me.lblPetSearch = New System.Windows.Forms.Label()
        Me.txtPetSearch = New System.Windows.Forms.TextBox()
        Me.datPetInfo = New System.Windows.Forms.DataGridView()
        Me.btnAccounts = New System.Windows.Forms.Button()
        Me.btnMaintenance = New System.Windows.Forms.Button()
        Me.pnlNav.SuspendLayout()
        CType(Me.picDrawer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContent.SuspendLayout()
        Me.tabInformations.SuspendLayout()
        Me.tabOwner.SuspendLayout()
        CType(Me.datOwnerInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPet.SuspendLayout()
        CType(Me.datPetInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlNav
        '
        Me.pnlNav.BackColor = System.Drawing.Color.White
        Me.pnlNav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlNav.Controls.Add(Me.btnMaintenance)
        Me.pnlNav.Controls.Add(Me.btnAccounts)
        Me.pnlNav.Controls.Add(Me.btnLogout)
        Me.pnlNav.Controls.Add(Me.picDrawer)
        Me.pnlNav.Controls.Add(Me.btnAddRecord)
        Me.pnlNav.Controls.Add(Me.btnUpdateRecord)
        Me.pnlNav.Controls.Add(Me.btnSchedule)
        Me.pnlNav.Controls.Add(Me.btnHistory)
        Me.pnlNav.Controls.Add(Me.btnTransaction)
        Me.pnlNav.Controls.Add(Me.btnHide)
        Me.pnlNav.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlNav.Location = New System.Drawing.Point(0, 0)
        Me.pnlNav.Name = "pnlNav"
        Me.pnlNav.Size = New System.Drawing.Size(206, 484)
        Me.pnlNav.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Black
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(9, 446)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(183, 28)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "LOG OUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'picDrawer
        '
        Me.picDrawer.Image = Global._3KPet_MIS.My.Resources.Resources.logo
        Me.picDrawer.Location = New System.Drawing.Point(10, 38)
        Me.picDrawer.Name = "picDrawer"
        Me.picDrawer.Size = New System.Drawing.Size(181, 70)
        Me.picDrawer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDrawer.TabIndex = 6
        Me.picDrawer.TabStop = False
        '
        'btnAddRecord
        '
        Me.btnAddRecord.BackColor = System.Drawing.Color.Purple
        Me.btnAddRecord.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRecord.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRecord.ForeColor = System.Drawing.Color.White
        Me.btnAddRecord.Location = New System.Drawing.Point(9, 126)
        Me.btnAddRecord.Name = "btnAddRecord"
        Me.btnAddRecord.Size = New System.Drawing.Size(183, 35)
        Me.btnAddRecord.TabIndex = 1
        Me.btnAddRecord.Text = "ADD RECORD"
        Me.btnAddRecord.UseVisualStyleBackColor = False
        '
        'btnUpdateRecord
        '
        Me.btnUpdateRecord.BackColor = System.Drawing.Color.Purple
        Me.btnUpdateRecord.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnUpdateRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateRecord.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateRecord.ForeColor = System.Drawing.Color.White
        Me.btnUpdateRecord.Location = New System.Drawing.Point(9, 165)
        Me.btnUpdateRecord.Name = "btnUpdateRecord"
        Me.btnUpdateRecord.Size = New System.Drawing.Size(183, 35)
        Me.btnUpdateRecord.TabIndex = 2
        Me.btnUpdateRecord.Text = "UPDATE RECORD"
        Me.btnUpdateRecord.UseVisualStyleBackColor = False
        '
        'btnSchedule
        '
        Me.btnSchedule.BackColor = System.Drawing.Color.Purple
        Me.btnSchedule.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSchedule.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSchedule.ForeColor = System.Drawing.Color.White
        Me.btnSchedule.Location = New System.Drawing.Point(9, 204)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Size = New System.Drawing.Size(183, 35)
        Me.btnSchedule.TabIndex = 3
        Me.btnSchedule.Text = "SCHEDULE"
        Me.btnSchedule.UseVisualStyleBackColor = False
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.Color.Purple
        Me.btnHistory.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistory.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.Color.White
        Me.btnHistory.Location = New System.Drawing.Point(9, 282)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(183, 35)
        Me.btnHistory.TabIndex = 4
        Me.btnHistory.Text = "VISIT'S HISTORY"
        Me.btnHistory.UseVisualStyleBackColor = False
        '
        'btnTransaction
        '
        Me.btnTransaction.BackColor = System.Drawing.Color.Purple
        Me.btnTransaction.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaction.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaction.ForeColor = System.Drawing.Color.White
        Me.btnTransaction.Location = New System.Drawing.Point(9, 243)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(183, 35)
        Me.btnTransaction.TabIndex = 3
        Me.btnTransaction.Text = "TRANSACTIONS"
        Me.btnTransaction.UseVisualStyleBackColor = False
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHide.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.ForeColor = System.Drawing.Color.White
        Me.btnHide.Location = New System.Drawing.Point(9, 412)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(183, 28)
        Me.btnHide.TabIndex = 5
        Me.btnHide.Text = "HIDE"
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Purple
        Me.pnlHeader.Controls.Add(Me.picMenu)
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(206, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(707, 63)
        Me.pnlHeader.TabIndex = 1
        '
        'picMenu
        '
        Me.picMenu.Image = Global._3KPet_MIS.My.Resources.Resources.MENU
        Me.picMenu.Location = New System.Drawing.Point(7, 12)
        Me.picMenu.Name = "picMenu"
        Me.picMenu.Size = New System.Drawing.Size(39, 38)
        Me.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMenu.TabIndex = 1
        Me.picMenu.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(44, 15)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(328, 33)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "INFORMATION DASHBOARD"
        '
        'pnlContent
        '
        Me.pnlContent.Controls.Add(Me.tabInformations)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(206, 63)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(707, 421)
        Me.pnlContent.TabIndex = 2
        '
        'tabInformations
        '
        Me.tabInformations.Controls.Add(Me.tabOwner)
        Me.tabInformations.Controls.Add(Me.tabPet)
        Me.tabInformations.Location = New System.Drawing.Point(7, 13)
        Me.tabInformations.Name = "tabInformations"
        Me.tabInformations.SelectedIndex = 0
        Me.tabInformations.Size = New System.Drawing.Size(688, 396)
        Me.tabInformations.TabIndex = 0
        '
        'tabOwner
        '
        Me.tabOwner.Controls.Add(Me.lblOwnerSearch)
        Me.tabOwner.Controls.Add(Me.txtOwnerSearch)
        Me.tabOwner.Controls.Add(Me.datOwnerInfo)
        Me.tabOwner.Location = New System.Drawing.Point(4, 22)
        Me.tabOwner.Name = "tabOwner"
        Me.tabOwner.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOwner.Size = New System.Drawing.Size(680, 370)
        Me.tabOwner.TabIndex = 0
        Me.tabOwner.Text = "Owner Information"
        Me.tabOwner.UseVisualStyleBackColor = True
        '
        'lblOwnerSearch
        '
        Me.lblOwnerSearch.AutoSize = True
        Me.lblOwnerSearch.Location = New System.Drawing.Point(6, 13)
        Me.lblOwnerSearch.Name = "lblOwnerSearch"
        Me.lblOwnerSearch.Size = New System.Drawing.Size(47, 13)
        Me.lblOwnerSearch.TabIndex = 2
        Me.lblOwnerSearch.Text = "SEARCH :"
        '
        'txtOwnerSearch
        '
        Me.txtOwnerSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOwnerSearch.Location = New System.Drawing.Point(59, 9)
        Me.txtOwnerSearch.Name = "txtOwnerSearch"
        Me.txtOwnerSearch.Size = New System.Drawing.Size(203, 21)
        Me.txtOwnerSearch.TabIndex = 1
        '
        'datOwnerInfo
        '
        Me.datOwnerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datOwnerInfo.Location = New System.Drawing.Point(6, 36)
        Me.datOwnerInfo.Name = "datOwnerInfo"
        Me.datOwnerInfo.Size = New System.Drawing.Size(668, 324)
        Me.datOwnerInfo.TabIndex = 2
        '
        'tabPet
        '
        Me.tabPet.Controls.Add(Me.lblPetSearch)
        Me.tabPet.Controls.Add(Me.txtPetSearch)
        Me.tabPet.Controls.Add(Me.datPetInfo)
        Me.tabPet.Location = New System.Drawing.Point(4, 22)
        Me.tabPet.Name = "tabPet"
        Me.tabPet.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPet.Size = New System.Drawing.Size(685, 353)
        Me.tabPet.TabIndex = 1
        Me.tabPet.Text = "Pet Information"
        Me.tabPet.UseVisualStyleBackColor = True
        '
        'lblPetSearch
        '
        Me.lblPetSearch.AutoSize = True
        Me.lblPetSearch.Location = New System.Drawing.Point(6, 13)
        Me.lblPetSearch.Name = "lblPetSearch"
        Me.lblPetSearch.Size = New System.Drawing.Size(47, 13)
        Me.lblPetSearch.TabIndex = 5
        Me.lblPetSearch.Text = "SEARCH :"
        '
        'txtPetSearch
        '
        Me.txtPetSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPetSearch.Location = New System.Drawing.Point(59, 9)
        Me.txtPetSearch.Name = "txtPetSearch"
        Me.txtPetSearch.Size = New System.Drawing.Size(203, 21)
        Me.txtPetSearch.TabIndex = 1
        '
        'datPetInfo
        '
        Me.datPetInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datPetInfo.Location = New System.Drawing.Point(6, 36)
        Me.datPetInfo.Name = "datPetInfo"
        Me.datPetInfo.Size = New System.Drawing.Size(675, 311)
        Me.datPetInfo.TabIndex = 2
        '
        'btnAccounts
        '
        Me.btnAccounts.BackColor = System.Drawing.Color.Purple
        Me.btnAccounts.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccounts.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccounts.ForeColor = System.Drawing.Color.White
        Me.btnAccounts.Location = New System.Drawing.Point(9, 321)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Size = New System.Drawing.Size(183, 35)
        Me.btnAccounts.TabIndex = 7
        Me.btnAccounts.Text = "ACCOUNTS"
        Me.btnAccounts.UseVisualStyleBackColor = False
        '
        'btnMaintenance
        '
        Me.btnMaintenance.BackColor = System.Drawing.Color.Purple
        Me.btnMaintenance.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaintenance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaintenance.ForeColor = System.Drawing.Color.White
        Me.btnMaintenance.Location = New System.Drawing.Point(9, 360)
        Me.btnMaintenance.Name = "btnMaintenance"
        Me.btnMaintenance.Size = New System.Drawing.Size(183, 35)
        Me.btnMaintenance.TabIndex = 8
        Me.btnMaintenance.Text = "MAINTENANCE"
        Me.btnMaintenance.UseVisualStyleBackColor = False
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(913, 484)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlNav)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "3K Pet Solution Management Information System"
        Me.pnlNav.ResumeLayout(False)
        CType(Me.picDrawer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContent.ResumeLayout(False)
        Me.tabInformations.ResumeLayout(False)
        Me.tabOwner.ResumeLayout(False)
        Me.tabOwner.PerformLayout()
        CType(Me.datOwnerInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPet.ResumeLayout(False)
        Me.tabPet.PerformLayout()
        CType(Me.datPetInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlNav As System.Windows.Forms.Panel
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents btnAddRecord As System.Windows.Forms.Button
    Friend WithEvents btnUpdateRecord As System.Windows.Forms.Button
    Friend WithEvents btnSchedule As System.Windows.Forms.Button
    Friend WithEvents btnHistory As System.Windows.Forms.Button
    Friend WithEvents btnTransaction As System.Windows.Forms.Button
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents tabInformations As System.Windows.Forms.TabControl
    Friend WithEvents tabOwner As System.Windows.Forms.TabPage
    Friend WithEvents txtOwnerSearch As System.Windows.Forms.TextBox
    Friend WithEvents datOwnerInfo As System.Windows.Forms.DataGridView
    Friend WithEvents tabPet As System.Windows.Forms.TabPage
    Friend WithEvents lblOwnerSearch As System.Windows.Forms.Label
    Friend WithEvents lblPetSearch As System.Windows.Forms.Label
    Friend WithEvents txtPetSearch As System.Windows.Forms.TextBox
    Friend WithEvents datPetInfo As System.Windows.Forms.DataGridView
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents picMenu As System.Windows.Forms.PictureBox
    Friend WithEvents picDrawer As System.Windows.Forms.PictureBox
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnAccounts As System.Windows.Forms.Button
    Friend WithEvents btnMaintenance As System.Windows.Forms.Button
End Class
