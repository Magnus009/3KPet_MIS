<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchedules
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchedules))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.dtpVisitDateTo = New System.Windows.Forms.DateTimePicker()
        Me.lblSep = New System.Windows.Forms.Label()
        Me.btnReservation = New System.Windows.Forms.Button()
        Me.dtpVisitDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblVistDate = New System.Windows.Forms.Label()
        Me.datSchedules = New System.Windows.Forms.DataGridView()
        Me.colSchedCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colService = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPurpose = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSchedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colView = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.pnlContent.SuspendLayout()
        CType(Me.datSchedules, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(12, 12)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(144, 33)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "SCHEDULES"
        '
        'pnlContent
        '
        Me.pnlContent.Controls.Add(Me.btnFilter)
        Me.pnlContent.Controls.Add(Me.dtpVisitDateTo)
        Me.pnlContent.Controls.Add(Me.lblSep)
        Me.pnlContent.Controls.Add(Me.btnReservation)
        Me.pnlContent.Controls.Add(Me.dtpVisitDateFrom)
        Me.pnlContent.Controls.Add(Me.lblVistDate)
        Me.pnlContent.Controls.Add(Me.datSchedules)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 57)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(708, 379)
        Me.pnlContent.TabIndex = 7
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.Purple
        Me.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFilter.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.ForeColor = System.Drawing.Color.White
        Me.btnFilter.Location = New System.Drawing.Point(339, 6)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(69, 24)
        Me.btnFilter.TabIndex = 3
        Me.btnFilter.Text = "FILTER"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'dtpVisitDateTo
        '
        Me.dtpVisitDateTo.CustomFormat = "yyyy/MM/dd"
        Me.dtpVisitDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpVisitDateTo.Location = New System.Drawing.Point(228, 8)
        Me.dtpVisitDateTo.Name = "dtpVisitDateTo"
        Me.dtpVisitDateTo.Size = New System.Drawing.Size(105, 21)
        Me.dtpVisitDateTo.TabIndex = 2
        '
        'lblSep
        '
        Me.lblSep.AutoSize = True
        Me.lblSep.Location = New System.Drawing.Point(208, 12)
        Me.lblSep.Name = "lblSep"
        Me.lblSep.Size = New System.Drawing.Size(14, 13)
        Me.lblSep.TabIndex = 9
        Me.lblSep.Text = " - "
        Me.lblSep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReservation
        '
        Me.btnReservation.BackColor = System.Drawing.Color.Purple
        Me.btnReservation.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReservation.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservation.ForeColor = System.Drawing.Color.White
        Me.btnReservation.Location = New System.Drawing.Point(567, 342)
        Me.btnReservation.Name = "btnReservation"
        Me.btnReservation.Size = New System.Drawing.Size(129, 31)
        Me.btnReservation.TabIndex = 5
        Me.btnReservation.Text = "&RESERVATION"
        Me.btnReservation.UseVisualStyleBackColor = False
        '
        'dtpVisitDateFrom
        '
        Me.dtpVisitDateFrom.CustomFormat = "yyyy/MM/dd"
        Me.dtpVisitDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpVisitDateFrom.Location = New System.Drawing.Point(97, 8)
        Me.dtpVisitDateFrom.Name = "dtpVisitDateFrom"
        Me.dtpVisitDateFrom.Size = New System.Drawing.Size(105, 21)
        Me.dtpVisitDateFrom.TabIndex = 1
        '
        'lblVistDate
        '
        Me.lblVistDate.AutoSize = True
        Me.lblVistDate.Location = New System.Drawing.Point(17, 12)
        Me.lblVistDate.Name = "lblVistDate"
        Me.lblVistDate.Size = New System.Drawing.Size(74, 13)
        Me.lblVistDate.TabIndex = 6
        Me.lblVistDate.Text = "DATE OF VISIT : "
        '
        'datSchedules
        '
        Me.datSchedules.AllowUserToAddRows = False
        Me.datSchedules.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.datSchedules.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datSchedules.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datSchedules.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSchedCode, Me.colCustomer, Me.colService, Me.colPurpose, Me.colSchedDate, Me.colView})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datSchedules.DefaultCellStyle = DataGridViewCellStyle3
        Me.datSchedules.Location = New System.Drawing.Point(12, 36)
        Me.datSchedules.MultiSelect = False
        Me.datSchedules.Name = "datSchedules"
        Me.datSchedules.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datSchedules.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datSchedules.RowHeadersVisible = False
        Me.datSchedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datSchedules.Size = New System.Drawing.Size(684, 302)
        Me.datSchedules.TabIndex = 4
        '
        'colSchedCode
        '
        Me.colSchedCode.FillWeight = 80.0!
        Me.colSchedCode.HeaderText = "CODE"
        Me.colSchedCode.MaxInputLength = 10
        Me.colSchedCode.Name = "colSchedCode"
        Me.colSchedCode.ReadOnly = True
        Me.colSchedCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colSchedCode.Width = 72
        '
        'colCustomer
        '
        Me.colCustomer.FillWeight = 150.0!
        Me.colCustomer.HeaderText = "CUSTOMER"
        Me.colCustomer.MaxInputLength = 100
        Me.colCustomer.Name = "colCustomer"
        Me.colCustomer.ReadOnly = True
        Me.colCustomer.Width = 136
        '
        'colService
        '
        Me.colService.HeaderText = "SERVICE"
        Me.colService.Name = "colService"
        Me.colService.ReadOnly = True
        Me.colService.Width = 90
        '
        'colPurpose
        '
        Me.colPurpose.FillWeight = 200.0!
        Me.colPurpose.HeaderText = "PURPOSE"
        Me.colPurpose.Name = "colPurpose"
        Me.colPurpose.ReadOnly = True
        Me.colPurpose.Width = 181
        '
        'colSchedDate
        '
        Me.colSchedDate.FillWeight = 120.0!
        Me.colSchedDate.HeaderText = "DATE"
        Me.colSchedDate.Name = "colSchedDate"
        Me.colSchedDate.ReadOnly = True
        Me.colSchedDate.Width = 108
        '
        'colView
        '
        Me.colView.FillWeight = 40.0!
        Me.colView.HeaderText = ""
        Me.colView.Name = "colView"
        Me.colView.ReadOnly = True
        Me.colView.Width = 36
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Purple
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(708, 57)
        Me.pnlHeader.TabIndex = 6
        '
        'frmSchedules
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(708, 436)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSchedules"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedules"
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        CType(Me.datSchedules, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents btnReservation As System.Windows.Forms.Button
    Friend WithEvents dtpVisitDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblVistDate As System.Windows.Forms.Label
    Friend WithEvents datSchedules As System.Windows.Forms.DataGridView
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents dtpVisitDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSep As System.Windows.Forms.Label
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents colSchedCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustomer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colService As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPurpose As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSchedDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colView As System.Windows.Forms.DataGridViewButtonColumn
End Class
