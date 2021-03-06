<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransactions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransactions))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.dtpVisitDate = New System.Windows.Forms.DateTimePicker()
        Me.lblVistDate = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.datTransaction = New System.Windows.Forms.DataGridView()
        Me.colVisitationCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTransDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colService = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colView = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlHeader.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        CType(Me.datTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(12, 12)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(189, 33)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "TRANSACTIONS"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Purple
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(900, 57)
        Me.pnlHeader.TabIndex = 4
        '
        'pnlContent
        '
        Me.pnlContent.Controls.Add(Me.btnAddNew)
        Me.pnlContent.Controls.Add(Me.dtpVisitDate)
        Me.pnlContent.Controls.Add(Me.lblVistDate)
        Me.pnlContent.Controls.Add(Me.txtSearch)
        Me.pnlContent.Controls.Add(Me.lblSearch)
        Me.pnlContent.Controls.Add(Me.datTransaction)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 57)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(900, 531)
        Me.pnlContent.TabIndex = 5
        '
        'btnAddNew
        '
        Me.btnAddNew.BackColor = System.Drawing.Color.Purple
        Me.btnAddNew.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNew.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.ForeColor = System.Drawing.Color.White
        Me.btnAddNew.Location = New System.Drawing.Point(777, 4)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(111, 27)
        Me.btnAddNew.TabIndex = 8
        Me.btnAddNew.Text = "&ADD NEW"
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'dtpVisitDate
        '
        Me.dtpVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVisitDate.Location = New System.Drawing.Point(479, 9)
        Me.dtpVisitDate.Name = "dtpVisitDate"
        Me.dtpVisitDate.Size = New System.Drawing.Size(95, 21)
        Me.dtpVisitDate.TabIndex = 7
        '
        'lblVistDate
        '
        Me.lblVistDate.AutoSize = True
        Me.lblVistDate.Location = New System.Drawing.Point(399, 13)
        Me.lblVistDate.Name = "lblVistDate"
        Me.lblVistDate.Size = New System.Drawing.Size(74, 13)
        Me.lblVistDate.TabIndex = 6
        Me.lblVistDate.Text = "DATE OF VISIT : "
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(70, 9)
        Me.txtSearch.MaxLength = 50
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(265, 21)
        Me.txtSearch.TabIndex = 4
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(17, 13)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(47, 13)
        Me.lblSearch.TabIndex = 5
        Me.lblSearch.Text = "SEARCH :"
        '
        'datTransaction
        '
        Me.datTransaction.AllowUserToAddRows = False
        Me.datTransaction.AllowUserToDeleteRows = False
        Me.datTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datTransaction.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datTransaction.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colVisitationCode, Me.colCustomer, Me.colTransDate, Me.colService, Me.colRemarks, Me.colView})
        Me.datTransaction.Location = New System.Drawing.Point(12, 36)
        Me.datTransaction.MultiSelect = False
        Me.datTransaction.Name = "datTransaction"
        Me.datTransaction.ReadOnly = True
        Me.datTransaction.RowHeadersVisible = False
        Me.datTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datTransaction.Size = New System.Drawing.Size(876, 483)
        Me.datTransaction.TabIndex = 0
        '
        'colVisitationCode
        '
        Me.colVisitationCode.FillWeight = 50.0!
        Me.colVisitationCode.HeaderText = "CODE"
        Me.colVisitationCode.Name = "colVisitationCode"
        Me.colVisitationCode.ReadOnly = True
        '
        'colCustomer
        '
        Me.colCustomer.FillWeight = 150.0!
        Me.colCustomer.HeaderText = "CUSTOMER"
        Me.colCustomer.Name = "colCustomer"
        Me.colCustomer.ReadOnly = True
        '
        'colTransDate
        '
        Me.colTransDate.FillWeight = 80.0!
        Me.colTransDate.HeaderText = "DATE"
        Me.colTransDate.Name = "colTransDate"
        Me.colTransDate.ReadOnly = True
        '
        'colService
        '
        Me.colService.FillWeight = 75.0!
        Me.colService.HeaderText = "SERVICE"
        Me.colService.Name = "colService"
        Me.colService.ReadOnly = True
        '
        'colRemarks
        '
        Me.colRemarks.HeaderText = "REMARKS"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.ReadOnly = True
        '
        'colView
        '
        Me.colView.FillWeight = 40.0!
        Me.colView.HeaderText = ""
        Me.colView.Name = "colView"
        Me.colView.ReadOnly = True
        '
        'frmTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(900, 588)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTransactions"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        CType(Me.datTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents datTransaction As System.Windows.Forms.DataGridView
    Friend WithEvents dtpVisitDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblVistDate As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents colVisitationCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustomer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTransDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colService As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRemarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colView As System.Windows.Forms.DataGridViewButtonColumn
End Class
