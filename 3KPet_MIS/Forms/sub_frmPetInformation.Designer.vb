<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sub_frmPetInformation
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAddRecord = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grpHistory = New System.Windows.Forms.GroupBox()
        Me.txtNextVisit = New System.Windows.Forms.TextBox()
        Me.lblNextVist = New System.Windows.Forms.Label()
        Me.txtDX = New System.Windows.Forms.TextBox()
        Me.lblDX = New System.Windows.Forms.Label()
        Me.txtTemp = New System.Windows.Forms.TextBox()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.txtWT = New System.Windows.Forms.TextBox()
        Me.lblWT = New System.Windows.Forms.Label()
        Me.dtpVisitDate = New System.Windows.Forms.DateTimePicker()
        Me.lblVisitDate = New System.Windows.Forms.Label()
        Me.datHistory = New System.Windows.Forms.DataGridView()
        Me.cboPet = New System.Windows.Forms.ComboBox()
        Me.lblPetName = New System.Windows.Forms.Label()
        Me.lblVisitHistory = New System.Windows.Forms.Label()
        Me.lblproduct = New System.Windows.Forms.Label()
        Me.datProduct = New System.Windows.Forms.DataGridView()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.datVaccine = New System.Windows.Forms.DataGridView()
        Me.lblVax = New System.Windows.Forms.Label()
        Me.datTreatment = New System.Windows.Forms.DataGridView()
        Me.lblTreatment = New System.Windows.Forms.Label()
        Me.grpHistory.SuspendLayout()
        CType(Me.datHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datVaccine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datTreatment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddRecord
        '
        Me.btnAddRecord.BackColor = System.Drawing.Color.Purple
        Me.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRecord.ForeColor = System.Drawing.Color.White
        Me.btnAddRecord.Location = New System.Drawing.Point(616, 386)
        Me.btnAddRecord.Name = "btnAddRecord"
        Me.btnAddRecord.Size = New System.Drawing.Size(97, 36)
        Me.btnAddRecord.TabIndex = 5
        Me.btnAddRecord.Text = "ADD RECORD"
        Me.btnAddRecord.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Purple
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(517, 386)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(97, 36)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'grpHistory
        '
        Me.grpHistory.Controls.Add(Me.txtNextVisit)
        Me.grpHistory.Controls.Add(Me.lblNextVist)
        Me.grpHistory.Controls.Add(Me.txtDX)
        Me.grpHistory.Controls.Add(Me.lblDX)
        Me.grpHistory.Controls.Add(Me.txtTemp)
        Me.grpHistory.Controls.Add(Me.lblTemp)
        Me.grpHistory.Controls.Add(Me.txtWT)
        Me.grpHistory.Controls.Add(Me.lblWT)
        Me.grpHistory.Controls.Add(Me.dtpVisitDate)
        Me.grpHistory.Controls.Add(Me.lblVisitDate)
        Me.grpHistory.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHistory.Location = New System.Drawing.Point(249, 16)
        Me.grpHistory.Name = "grpHistory"
        Me.grpHistory.Size = New System.Drawing.Size(469, 184)
        Me.grpHistory.TabIndex = 2
        Me.grpHistory.TabStop = False
        Me.grpHistory.Text = "VISIT INFORMATION"
        '
        'txtNextVisit
        '
        Me.txtNextVisit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNextVisit.Location = New System.Drawing.Point(75, 146)
        Me.txtNextVisit.Name = "txtNextVisit"
        Me.txtNextVisit.ReadOnly = True
        Me.txtNextVisit.Size = New System.Drawing.Size(130, 23)
        Me.txtNextVisit.TabIndex = 15
        Me.txtNextVisit.Tag = "*NextVisit"
        '
        'lblNextVist
        '
        Me.lblNextVist.AutoSize = True
        Me.lblNextVist.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNextVist.Location = New System.Drawing.Point(5, 149)
        Me.lblNextVist.Name = "lblNextVist"
        Me.lblNextVist.Size = New System.Drawing.Size(65, 15)
        Me.lblNextVist.TabIndex = 14
        Me.lblNextVist.Text = "Next Visit :"
        '
        'txtDX
        '
        Me.txtDX.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDX.Location = New System.Drawing.Point(75, 84)
        Me.txtDX.Multiline = True
        Me.txtDX.Name = "txtDX"
        Me.txtDX.Size = New System.Drawing.Size(373, 56)
        Me.txtDX.TabIndex = 4
        Me.txtDX.Tag = "*DX"
        '
        'lblDX
        '
        Me.lblDX.AutoSize = True
        Me.lblDX.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDX.Location = New System.Drawing.Point(42, 89)
        Me.lblDX.Name = "lblDX"
        Me.lblDX.Size = New System.Drawing.Size(28, 15)
        Me.lblDX.TabIndex = 6
        Me.lblDX.Text = "DX :"
        '
        'txtTemp
        '
        Me.txtTemp.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemp.Location = New System.Drawing.Point(288, 55)
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(160, 23)
        Me.txtTemp.TabIndex = 3
        Me.txtTemp.Tag = "*Temp"
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemp.Location = New System.Drawing.Point(238, 60)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(41, 15)
        Me.lblTemp.TabIndex = 4
        Me.lblTemp.Text = "Temp :"
        '
        'txtWT
        '
        Me.txtWT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWT.Location = New System.Drawing.Point(75, 55)
        Me.txtWT.Name = "txtWT"
        Me.txtWT.Size = New System.Drawing.Size(160, 23)
        Me.txtWT.TabIndex = 2
        Me.txtWT.Tag = "*WT"
        '
        'lblWT
        '
        Me.lblWT.AutoSize = True
        Me.lblWT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWT.Location = New System.Drawing.Point(42, 60)
        Me.lblWT.Name = "lblWT"
        Me.lblWT.Size = New System.Drawing.Size(31, 15)
        Me.lblWT.TabIndex = 2
        Me.lblWT.Text = "WT :"
        '
        'dtpVisitDate
        '
        Me.dtpVisitDate.CustomFormat = "yyyy/MM/dd"
        Me.dtpVisitDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpVisitDate.Location = New System.Drawing.Point(75, 27)
        Me.dtpVisitDate.Name = "dtpVisitDate"
        Me.dtpVisitDate.Size = New System.Drawing.Size(106, 23)
        Me.dtpVisitDate.TabIndex = 1
        '
        'lblVisitDate
        '
        Me.lblVisitDate.AutoSize = True
        Me.lblVisitDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisitDate.Location = New System.Drawing.Point(34, 31)
        Me.lblVisitDate.Name = "lblVisitDate"
        Me.lblVisitDate.Size = New System.Drawing.Size(39, 15)
        Me.lblVisitDate.TabIndex = 0
        Me.lblVisitDate.Text = "DATE :"
        '
        'datHistory
        '
        Me.datHistory.AllowUserToAddRows = False
        Me.datHistory.AllowUserToDeleteRows = False
        Me.datHistory.AllowUserToResizeColumns = False
        Me.datHistory.AllowUserToResizeRows = False
        Me.datHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datHistory.DefaultCellStyle = DataGridViewCellStyle2
        Me.datHistory.Location = New System.Drawing.Point(3, 51)
        Me.datHistory.Name = "datHistory"
        Me.datHistory.ReadOnly = True
        Me.datHistory.RowHeadersVisible = False
        Me.datHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datHistory.Size = New System.Drawing.Size(240, 173)
        Me.datHistory.TabIndex = 1
        '
        'cboPet
        '
        Me.cboPet.FormattingEnabled = True
        Me.cboPet.Location = New System.Drawing.Point(79, 5)
        Me.cboPet.Name = "cboPet"
        Me.cboPet.Size = New System.Drawing.Size(121, 21)
        Me.cboPet.TabIndex = 27
        '
        'lblPetName
        '
        Me.lblPetName.AutoSize = True
        Me.lblPetName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPetName.Location = New System.Drawing.Point(6, 9)
        Me.lblPetName.Name = "lblPetName"
        Me.lblPetName.Size = New System.Drawing.Size(67, 15)
        Me.lblPetName.TabIndex = 28
        Me.lblPetName.Text = "PET NAME :"
        '
        'lblVisitHistory
        '
        Me.lblVisitHistory.AutoSize = True
        Me.lblVisitHistory.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisitHistory.Location = New System.Drawing.Point(6, 30)
        Me.lblVisitHistory.Name = "lblVisitHistory"
        Me.lblVisitHistory.Size = New System.Drawing.Size(95, 18)
        Me.lblVisitHistory.TabIndex = 29
        Me.lblVisitHistory.Text = "VISIT HISTORY"
        '
        'lblproduct
        '
        Me.lblproduct.AutoSize = True
        Me.lblproduct.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproduct.Location = New System.Drawing.Point(0, 227)
        Me.lblproduct.Name = "lblproduct"
        Me.lblproduct.Size = New System.Drawing.Size(146, 18)
        Me.lblproduct.TabIndex = 30
        Me.lblproduct.Text = "PURCHASED PRODUCT"
        '
        'datProduct
        '
        Me.datProduct.AllowUserToAddRows = False
        Me.datProduct.AllowUserToDeleteRows = False
        Me.datProduct.AllowUserToResizeColumns = False
        Me.datProduct.AllowUserToResizeRows = False
        Me.datProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datProduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datProduct.DefaultCellStyle = DataGridViewCellStyle4
        Me.datProduct.Location = New System.Drawing.Point(3, 248)
        Me.datProduct.Name = "datProduct"
        Me.datProduct.RowHeadersVisible = False
        Me.datProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datProduct.Size = New System.Drawing.Size(240, 134)
        Me.datProduct.TabIndex = 31
        '
        'btnPurchase
        '
        Me.btnPurchase.BackColor = System.Drawing.Color.Purple
        Me.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPurchase.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurchase.ForeColor = System.Drawing.Color.White
        Me.btnPurchase.Location = New System.Drawing.Point(3, 386)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(97, 36)
        Me.btnPurchase.TabIndex = 32
        Me.btnPurchase.Text = "PURCHASE"
        Me.btnPurchase.UseVisualStyleBackColor = False
        '
        'datVaccine
        '
        Me.datVaccine.AllowUserToAddRows = False
        Me.datVaccine.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datVaccine.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.datVaccine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datVaccine.DefaultCellStyle = DataGridViewCellStyle6
        Me.datVaccine.Location = New System.Drawing.Point(254, 231)
        Me.datVaccine.Name = "datVaccine"
        Me.datVaccine.RowHeadersVisible = False
        Me.datVaccine.Size = New System.Drawing.Size(225, 151)
        Me.datVaccine.TabIndex = 33
        '
        'lblVax
        '
        Me.lblVax.AutoSize = True
        Me.lblVax.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVax.Location = New System.Drawing.Point(251, 206)
        Me.lblVax.Name = "lblVax"
        Me.lblVax.Size = New System.Drawing.Size(69, 18)
        Me.lblVax.TabIndex = 34
        Me.lblVax.Text = "VACCINES"
        '
        'datTreatment
        '
        Me.datTreatment.AllowUserToAddRows = False
        Me.datTreatment.AllowUserToDeleteRows = False
        Me.datTreatment.AllowUserToResizeColumns = False
        Me.datTreatment.AllowUserToResizeRows = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datTreatment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.datTreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datTreatment.DefaultCellStyle = DataGridViewCellStyle8
        Me.datTreatment.Location = New System.Drawing.Point(485, 232)
        Me.datTreatment.Name = "datTreatment"
        Me.datTreatment.RowHeadersVisible = False
        Me.datTreatment.Size = New System.Drawing.Size(228, 150)
        Me.datTreatment.TabIndex = 35
        '
        'lblTreatment
        '
        Me.lblTreatment.AutoSize = True
        Me.lblTreatment.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTreatment.Location = New System.Drawing.Point(487, 206)
        Me.lblTreatment.Name = "lblTreatment"
        Me.lblTreatment.Size = New System.Drawing.Size(89, 18)
        Me.lblTreatment.TabIndex = 36
        Me.lblTreatment.Text = "TREATMENTS"
        '
        'sub_frmPetInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(721, 430)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTreatment)
        Me.Controls.Add(Me.datTreatment)
        Me.Controls.Add(Me.lblVax)
        Me.Controls.Add(Me.datVaccine)
        Me.Controls.Add(Me.btnPurchase)
        Me.Controls.Add(Me.datProduct)
        Me.Controls.Add(Me.lblproduct)
        Me.Controls.Add(Me.lblVisitHistory)
        Me.Controls.Add(Me.cboPet)
        Me.Controls.Add(Me.lblPetName)
        Me.Controls.Add(Me.btnAddRecord)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpHistory)
        Me.Controls.Add(Me.datHistory)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "sub_frmPetInformation"
        Me.grpHistory.ResumeLayout(False)
        Me.grpHistory.PerformLayout()
        CType(Me.datHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datVaccine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datTreatment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddRecord As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents grpHistory As System.Windows.Forms.GroupBox
    Friend WithEvents lblNextVist As System.Windows.Forms.Label
    Friend WithEvents txtDX As System.Windows.Forms.TextBox
    Friend WithEvents lblDX As System.Windows.Forms.Label
    Friend WithEvents txtTemp As System.Windows.Forms.TextBox
    Friend WithEvents lblTemp As System.Windows.Forms.Label
    Friend WithEvents txtWT As System.Windows.Forms.TextBox
    Friend WithEvents lblWT As System.Windows.Forms.Label
    Friend WithEvents dtpVisitDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblVisitDate As System.Windows.Forms.Label
    Friend WithEvents datHistory As System.Windows.Forms.DataGridView
    Friend WithEvents cboPet As System.Windows.Forms.ComboBox
    Friend WithEvents lblPetName As System.Windows.Forms.Label
    Friend WithEvents lblVisitHistory As System.Windows.Forms.Label
    Friend WithEvents txtNextVisit As TextBox
    Friend WithEvents lblproduct As Label
    Friend WithEvents datProduct As DataGridView
    Friend WithEvents btnPurchase As Button
    Friend WithEvents datVaccine As DataGridView
    Friend WithEvents lblVax As Label
    Friend WithEvents datTreatment As DataGridView
    Friend WithEvents lblTreatment As Label
End Class
