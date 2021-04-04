<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.datRecords = New System.Windows.Forms.DataGridView()
        Me.grpProduct = New System.Windows.Forms.GroupBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtAvailableQTY = New System.Windows.Forms.TextBox()
        Me.lblAvailableQTY = New System.Windows.Forms.Label()
        Me.txtTotalQTY = New System.Windows.Forms.TextBox()
        Me.lblTotalQTY = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lblOrange = New System.Windows.Forms.Label()
        Me.lblCritical = New System.Windows.Forms.Label()
        Me.lblOut = New System.Windows.Forms.Label()
        Me.lblRed = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.datRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProduct.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.Controls.Add(Me.lblHeader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(853, 73)
        Me.Panel1.TabIndex = 0
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(23, 20)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(155, 36)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "INVENTORY"
        '
        'datRecords
        '
        Me.datRecords.AllowUserToAddRows = False
        Me.datRecords.AllowUserToDeleteRows = False
        Me.datRecords.AllowUserToResizeColumns = False
        Me.datRecords.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datRecords.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datRecords.ColumnHeadersHeight = 20
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datRecords.DefaultCellStyle = DataGridViewCellStyle2
        Me.datRecords.Location = New System.Drawing.Point(296, 108)
        Me.datRecords.Name = "datRecords"
        Me.datRecords.ReadOnly = True
        Me.datRecords.RowHeadersVisible = False
        Me.datRecords.Size = New System.Drawing.Size(545, 334)
        Me.datRecords.TabIndex = 1
        '
        'grpProduct
        '
        Me.grpProduct.Controls.Add(Me.btnUpdate)
        Me.grpProduct.Controls.Add(Me.btnCancel)
        Me.grpProduct.Controls.Add(Me.btnSave)
        Me.grpProduct.Controls.Add(Me.txtPrice)
        Me.grpProduct.Controls.Add(Me.lblPrice)
        Me.grpProduct.Controls.Add(Me.txtAvailableQTY)
        Me.grpProduct.Controls.Add(Me.lblAvailableQTY)
        Me.grpProduct.Controls.Add(Me.txtTotalQTY)
        Me.grpProduct.Controls.Add(Me.lblTotalQTY)
        Me.grpProduct.Controls.Add(Me.cboType)
        Me.grpProduct.Controls.Add(Me.lblType)
        Me.grpProduct.Controls.Add(Me.txtDescription)
        Me.grpProduct.Controls.Add(Me.lblDescription)
        Me.grpProduct.Controls.Add(Me.txtID)
        Me.grpProduct.Controls.Add(Me.lblProductID)
        Me.grpProduct.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProduct.Location = New System.Drawing.Point(12, 79)
        Me.grpProduct.Name = "grpProduct"
        Me.grpProduct.Size = New System.Drawing.Size(270, 363)
        Me.grpProduct.TabIndex = 2
        Me.grpProduct.TabStop = False
        Me.grpProduct.Text = "INFORMATION"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Purple
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(25, 256)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(106, 40)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(140, 256)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(106, 40)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Purple
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(25, 256)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(106, 40)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "ADD"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(13, 219)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(114, 23)
        Me.txtPrice.TabIndex = 11
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(8, 201)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(38, 15)
        Me.lblPrice.TabIndex = 10
        Me.lblPrice.Text = "PRICE"
        '
        'txtAvailableQTY
        '
        Me.txtAvailableQTY.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableQTY.Location = New System.Drawing.Point(154, 176)
        Me.txtAvailableQTY.Name = "txtAvailableQTY"
        Me.txtAvailableQTY.Size = New System.Drawing.Size(110, 23)
        Me.txtAvailableQTY.TabIndex = 9
        '
        'lblAvailableQTY
        '
        Me.lblAvailableQTY.AutoSize = True
        Me.lblAvailableQTY.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailableQTY.Location = New System.Drawing.Point(149, 158)
        Me.lblAvailableQTY.Name = "lblAvailableQTY"
        Me.lblAvailableQTY.Size = New System.Drawing.Size(84, 15)
        Me.lblAvailableQTY.TabIndex = 8
        Me.lblAvailableQTY.Text = "AVAILABLE QTY"
        '
        'txtTotalQTY
        '
        Me.txtTotalQTY.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalQTY.Location = New System.Drawing.Point(13, 176)
        Me.txtTotalQTY.Name = "txtTotalQTY"
        Me.txtTotalQTY.Size = New System.Drawing.Size(114, 23)
        Me.txtTotalQTY.TabIndex = 7
        '
        'lblTotalQTY
        '
        Me.lblTotalQTY.AutoSize = True
        Me.lblTotalQTY.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalQTY.Location = New System.Drawing.Point(8, 158)
        Me.lblTotalQTY.Name = "lblTotalQTY"
        Me.lblTotalQTY.Size = New System.Drawing.Size(63, 15)
        Me.lblTotalQTY.TabIndex = 6
        Me.lblTotalQTY.Text = "TOTAL QTY"
        '
        'cboType
        '
        Me.cboType.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(13, 133)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(251, 23)
        Me.cboType.TabIndex = 5
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(8, 116)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(32, 15)
        Me.lblType.TabIndex = 4
        Me.lblType.Text = "TYPE"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(11, 90)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(253, 23)
        Me.txtDescription.TabIndex = 3
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(8, 73)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(39, 15)
        Me.lblDescription.TabIndex = 2
        Me.lblDescription.Text = "NAME"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(11, 47)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(170, 23)
        Me.txtID.TabIndex = 1
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductID.Location = New System.Drawing.Point(8, 29)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(74, 15)
        Me.lblProductID.TabIndex = 0
        Me.lblProductID.Text = "PRODUCT ID"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(355, 79)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(244, 23)
        Me.txtSearch.TabIndex = 3
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(295, 82)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(54, 15)
        Me.lblSearch.TabIndex = 4
        Me.lblSearch.Text = "SEARCH :"
        '
        'lblOrange
        '
        Me.lblOrange.AutoSize = True
        Me.lblOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblOrange.Location = New System.Drawing.Point(618, 83)
        Me.lblOrange.Name = "lblOrange"
        Me.lblOrange.Size = New System.Drawing.Size(16, 15)
        Me.lblOrange.TabIndex = 5
        Me.lblOrange.Text = "   "
        '
        'lblCritical
        '
        Me.lblCritical.AutoSize = True
        Me.lblCritical.Location = New System.Drawing.Point(640, 83)
        Me.lblCritical.Name = "lblCritical"
        Me.lblCritical.Size = New System.Drawing.Size(85, 15)
        Me.lblCritical.TabIndex = 6
        Me.lblCritical.Text = "LOW/CRITICAL"
        '
        'lblOut
        '
        Me.lblOut.AutoSize = True
        Me.lblOut.Location = New System.Drawing.Point(753, 83)
        Me.lblOut.Name = "lblOut"
        Me.lblOut.Size = New System.Drawing.Size(92, 15)
        Me.lblOut.TabIndex = 8
        Me.lblOut.Text = "OUT OF STOCKS"
        '
        'lblRed
        '
        Me.lblRed.AutoSize = True
        Me.lblRed.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblRed.Location = New System.Drawing.Point(735, 83)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(16, 15)
        Me.lblRed.TabIndex = 7
        Me.lblRed.Text = "   "
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(853, 458)
        Me.Controls.Add(Me.lblOut)
        Me.Controls.Add(Me.lblRed)
        Me.Controls.Add(Me.lblCritical)
        Me.Controls.Add(Me.lblOrange)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.grpProduct)
        Me.Controls.Add(Me.datRecords)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INVENTORY"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.datRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProduct.ResumeLayout(False)
        Me.grpProduct.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents datRecords As System.Windows.Forms.DataGridView
    Friend WithEvents grpProduct As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblProductID As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents txtAvailableQTY As System.Windows.Forms.TextBox
    Friend WithEvents lblAvailableQTY As System.Windows.Forms.Label
    Friend WithEvents txtTotalQTY As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalQTY As System.Windows.Forms.Label
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lblOrange As Label
    Friend WithEvents lblCritical As Label
    Friend WithEvents lblOut As Label
    Friend WithEvents lblRed As Label
End Class
