<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewTransaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewTransaction))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.dtpTransDate = New System.Windows.Forms.DateTimePicker()
        Me.cboServices = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTransactionCode = New System.Windows.Forms.Label()
        Me.txtTransCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.datSchedules = New System.Windows.Forms.DataGridView()
        Me.colProductCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOrderedPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlContent.SuspendLayout()
        CType(Me.datSchedules, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Purple
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(27, 331)
        Me.pnlHeader.TabIndex = 4
        '
        'pnlContent
        '
        Me.pnlContent.Controls.Add(Me.TextBox1)
        Me.pnlContent.Controls.Add(Me.Label1)
        Me.pnlContent.Controls.Add(Me.btnConfirm)
        Me.pnlContent.Controls.Add(Me.lblRemarks)
        Me.pnlContent.Controls.Add(Me.txtRemarks)
        Me.pnlContent.Controls.Add(Me.dtpTransDate)
        Me.pnlContent.Controls.Add(Me.cboServices)
        Me.pnlContent.Controls.Add(Me.Label3)
        Me.pnlContent.Controls.Add(Me.lblTransactionCode)
        Me.pnlContent.Controls.Add(Me.txtTransCode)
        Me.pnlContent.Controls.Add(Me.Label2)
        Me.pnlContent.Controls.Add(Me.lblLName)
        Me.pnlContent.Controls.Add(Me.txtCustomer)
        Me.pnlContent.Controls.Add(Me.datSchedules)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(27, 0)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(555, 331)
        Me.pnlContent.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(454, 243)
        Me.TextBox1.MaxLength = 100
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(91, 27)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.Text = "100.00"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(385, 249)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "TOTAL : "
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.Purple
        Me.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(416, 291)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(129, 31)
        Me.btnConfirm.TabIndex = 7
        Me.btnConfirm.Text = "&CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'lblRemarks
        '
        Me.lblRemarks.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemarks.Location = New System.Drawing.Point(23, 244)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(84, 18)
        Me.lblRemarks.TabIndex = 13
        Me.lblRemarks.Text = "REMARKS : "
        Me.lblRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRemarks
        '
        Me.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemarks.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(113, 243)
        Me.txtRemarks.MaxLength = 250
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(256, 40)
        Me.txtRemarks.TabIndex = 6
        '
        'dtpTransDate
        '
        Me.dtpTransDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTransDate.Location = New System.Drawing.Point(372, 15)
        Me.dtpTransDate.Name = "dtpTransDate"
        Me.dtpTransDate.Size = New System.Drawing.Size(90, 21)
        Me.dtpTransDate.TabIndex = 3
        '
        'cboServices
        '
        Me.cboServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboServices.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboServices.FormattingEnabled = True
        Me.cboServices.Location = New System.Drawing.Point(372, 42)
        Me.cboServices.Name = "cboServices"
        Me.cboServices.Size = New System.Drawing.Size(118, 21)
        Me.cboServices.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(333, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "DATE : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTransactionCode
        '
        Me.lblTransactionCode.AutoSize = True
        Me.lblTransactionCode.Location = New System.Drawing.Point(7, 19)
        Me.lblTransactionCode.Name = "lblTransactionCode"
        Me.lblTransactionCode.Size = New System.Drawing.Size(104, 13)
        Me.lblTransactionCode.TabIndex = 9
        Me.lblTransactionCode.Text = "TRANSACTION CODE : "
        Me.lblTransactionCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTransCode
        '
        Me.txtTransCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTransCode.Location = New System.Drawing.Point(113, 15)
        Me.txtTransCode.MaxLength = 10
        Me.txtTransCode.Name = "txtTransCode"
        Me.txtTransCode.ReadOnly = True
        Me.txtTransCode.Size = New System.Drawing.Size(109, 21)
        Me.txtTransCode.TabIndex = 1
        Me.txtTransCode.Text = "- - -"
        Me.txtTransCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(319, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "SERVICE : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Location = New System.Drawing.Point(47, 46)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(64, 13)
        Me.lblLName.TabIndex = 7
        Me.lblLName.Text = "CUSTOMER : "
        Me.lblLName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCustomer
        '
        Me.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomer.Location = New System.Drawing.Point(113, 42)
        Me.txtCustomer.MaxLength = 100
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(186, 21)
        Me.txtCustomer.TabIndex = 2
        Me.txtCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'datSchedules
        '
        Me.datSchedules.AllowUserToAddRows = False
        Me.datSchedules.AllowUserToDeleteRows = False
        Me.datSchedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datSchedules.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datSchedules.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colProductCode, Me.colProductName, Me.colItemPrice, Me.colQty, Me.colOrderedPrice, Me.colDelete})
        Me.datSchedules.Location = New System.Drawing.Point(10, 69)
        Me.datSchedules.MultiSelect = False
        Me.datSchedules.Name = "datSchedules"
        Me.datSchedules.ReadOnly = True
        Me.datSchedules.RowHeadersVisible = False
        Me.datSchedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datSchedules.Size = New System.Drawing.Size(535, 166)
        Me.datSchedules.TabIndex = 5
        '
        'colProductCode
        '
        Me.colProductCode.FillWeight = 80.0!
        Me.colProductCode.HeaderText = "CODE"
        Me.colProductCode.MaxInputLength = 10
        Me.colProductCode.Name = "colProductCode"
        Me.colProductCode.ReadOnly = True
        Me.colProductCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colProductName
        '
        Me.colProductName.FillWeight = 150.0!
        Me.colProductName.HeaderText = "PRODUCT"
        Me.colProductName.MaxInputLength = 100
        Me.colProductName.Name = "colProductName"
        Me.colProductName.ReadOnly = True
        '
        'colItemPrice
        '
        Me.colItemPrice.HeaderText = "PRICE"
        Me.colItemPrice.Name = "colItemPrice"
        Me.colItemPrice.ReadOnly = True
        '
        'colQty
        '
        Me.colQty.HeaderText = "QTY"
        Me.colQty.Name = "colQty"
        Me.colQty.ReadOnly = True
        '
        'colOrderedPrice
        '
        Me.colOrderedPrice.HeaderText = "ORDERED PRICE"
        Me.colOrderedPrice.Name = "colOrderedPrice"
        Me.colOrderedPrice.ReadOnly = True
        '
        'colDelete
        '
        Me.colDelete.FillWeight = 40.0!
        Me.colDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colDelete.HeaderText = ""
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ReadOnly = True
        '
        'frmNewTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(582, 331)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewTransaction"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        CType(Me.datSchedules, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents datSchedules As System.Windows.Forms.DataGridView
    Friend WithEvents lblLName As System.Windows.Forms.Label
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents colProductCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colProductName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOrderedPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTransactionCode As System.Windows.Forms.Label
    Friend WithEvents txtTransCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpTransDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboServices As System.Windows.Forms.ComboBox
    Friend WithEvents lblRemarks As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
End Class
