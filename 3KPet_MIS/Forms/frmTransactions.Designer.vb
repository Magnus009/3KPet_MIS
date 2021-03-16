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
        Me.btnFIlter = New System.Windows.Forms.Button()
        Me.lblDash = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblVistDate = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.datTransactions = New System.Windows.Forms.DataGridView()
        Me.colView = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlHeader.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        CType(Me.datTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlHeader.Size = New System.Drawing.Size(940, 57)
        Me.pnlHeader.TabIndex = 4
        '
        'pnlContent
        '
        Me.pnlContent.Controls.Add(Me.btnFIlter)
        Me.pnlContent.Controls.Add(Me.lblDash)
        Me.pnlContent.Controls.Add(Me.dtpTo)
        Me.pnlContent.Controls.Add(Me.btnAddNew)
        Me.pnlContent.Controls.Add(Me.dtpFrom)
        Me.pnlContent.Controls.Add(Me.lblVistDate)
        Me.pnlContent.Controls.Add(Me.txtSearch)
        Me.pnlContent.Controls.Add(Me.lblSearch)
        Me.pnlContent.Controls.Add(Me.datTransactions)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 57)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(940, 531)
        Me.pnlContent.TabIndex = 5
        '
        'btnFIlter
        '
        Me.btnFIlter.BackColor = System.Drawing.Color.Purple
        Me.btnFIlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFIlter.ForeColor = System.Drawing.Color.White
        Me.btnFIlter.Location = New System.Drawing.Point(658, 8)
        Me.btnFIlter.Name = "btnFIlter"
        Me.btnFIlter.Size = New System.Drawing.Size(75, 23)
        Me.btnFIlter.TabIndex = 11
        Me.btnFIlter.Text = "FILTER"
        Me.btnFIlter.UseVisualStyleBackColor = False
        '
        'lblDash
        '
        Me.lblDash.AutoSize = True
        Me.lblDash.Location = New System.Drawing.Point(542, 12)
        Me.lblDash.Name = "lblDash"
        Me.lblDash.Size = New System.Drawing.Size(10, 13)
        Me.lblDash.TabIndex = 10
        Me.lblDash.Text = "-"
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(557, 9)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(95, 21)
        Me.dtpTo.TabIndex = 9
        '
        'btnAddNew
        '
        Me.btnAddNew.BackColor = System.Drawing.Color.Purple
        Me.btnAddNew.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNew.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.ForeColor = System.Drawing.Color.White
        Me.btnAddNew.Location = New System.Drawing.Point(817, 4)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(111, 27)
        Me.btnAddNew.TabIndex = 8
        Me.btnAddNew.Text = "&ADD NEW"
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(442, 9)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(95, 21)
        Me.dtpFrom.TabIndex = 7
        '
        'lblVistDate
        '
        Me.lblVistDate.AutoSize = True
        Me.lblVistDate.Location = New System.Drawing.Point(362, 13)
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
        'datTransactions
        '
        Me.datTransactions.AllowUserToAddRows = False
        Me.datTransactions.AllowUserToDeleteRows = False
        Me.datTransactions.AllowUserToResizeColumns = False
        Me.datTransactions.AllowUserToResizeRows = False
        Me.datTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datTransactions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datTransactions.ColumnHeadersHeight = 30
        Me.datTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datTransactions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colView})
        Me.datTransactions.Location = New System.Drawing.Point(12, 36)
        Me.datTransactions.MultiSelect = False
        Me.datTransactions.Name = "datTransactions"
        Me.datTransactions.RowHeadersVisible = False
        Me.datTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datTransactions.Size = New System.Drawing.Size(916, 483)
        Me.datTransactions.TabIndex = 0
        '
        'colView
        '
        Me.colView.FillWeight = 40.0!
        Me.colView.HeaderText = ""
        Me.colView.Name = "colView"
        '
        'frmTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(940, 588)
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
        CType(Me.datTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents datTransactions As System.Windows.Forms.DataGridView
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblVistDate As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents colView As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents lblDash As System.Windows.Forms.Label
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnFIlter As System.Windows.Forms.Button
End Class
