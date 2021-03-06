<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScheduleInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScheduleInfo))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCustomerCode = New System.Windows.Forms.TextBox()
        Me.lblCustomerCD = New System.Windows.Forms.Label()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.tabPetInfo = New System.Windows.Forms.TabControl()
        Me.tabPet = New System.Windows.Forms.TabPage()
        Me.grpTreatment = New System.Windows.Forms.GroupBox()
        Me.chkTreatments = New System.Windows.Forms.CheckedListBox()
        Me.grpVaccinations = New System.Windows.Forms.GroupBox()
        Me.chkVaccinations = New System.Windows.Forms.CheckedListBox()
        Me.grpHistory = New System.Windows.Forms.GroupBox()
        Me.dtpNextVisit = New System.Windows.Forms.DateTimePicker()
        Me.lblNextVist = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.txtDX = New System.Windows.Forms.TextBox()
        Me.lblDX = New System.Windows.Forms.Label()
        Me.txtTemp = New System.Windows.Forms.TextBox()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.txtWT = New System.Windows.Forms.TextBox()
        Me.lblWT = New System.Windows.Forms.Label()
        Me.dtpVisitDate = New System.Windows.Forms.DateTimePicker()
        Me.lblVisitDate = New System.Windows.Forms.Label()
        Me.datHistory = New System.Windows.Forms.DataGridView()
        Me.btnAddPet = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAddRecord = New System.Windows.Forms.Button()
        Me.tabPetInfo.SuspendLayout()
        Me.tabPet.SuspendLayout()
        Me.grpTreatment.SuspendLayout()
        Me.grpVaccinations.SuspendLayout()
        Me.grpHistory.SuspendLayout()
        CType(Me.datHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Purple
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(25, 570)
        Me.pnlHeader.TabIndex = 0
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.Location = New System.Drawing.Point(80, 50)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(67, 15)
        Me.lblCustomer.TabIndex = 3
        Me.lblCustomer.Text = "CUSTOMER"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(428, 23)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(55, 15)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "ADDRESS"
        '
        'txtCustomer
        '
        Me.txtCustomer.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomer.Location = New System.Drawing.Point(153, 46)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(209, 22)
        Me.txtCustomer.TabIndex = 5
        Me.txtCustomer.Tag = "*Customer"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(489, 20)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(239, 22)
        Me.txtAddress.TabIndex = 6
        Me.txtAddress.Tag = "*Address"
        '
        'txtCustomerCode
        '
        Me.txtCustomerCode.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerCode.Location = New System.Drawing.Point(153, 18)
        Me.txtCustomerCode.Name = "txtCustomerCode"
        Me.txtCustomerCode.ReadOnly = True
        Me.txtCustomerCode.Size = New System.Drawing.Size(239, 22)
        Me.txtCustomerCode.TabIndex = 8
        '
        'lblCustomerCD
        '
        Me.lblCustomerCD.AutoSize = True
        Me.lblCustomerCD.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerCD.Location = New System.Drawing.Point(47, 20)
        Me.lblCustomerCD.Name = "lblCustomerCD"
        Me.lblCustomerCD.Size = New System.Drawing.Size(100, 15)
        Me.lblCustomerCD.TabIndex = 7
        Me.lblCustomerCD.Text = "CUSTOMER CODE"
        '
        'lblContactNo
        '
        Me.lblContactNo.AutoSize = True
        Me.lblContactNo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNo.Location = New System.Drawing.Point(407, 53)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(76, 15)
        Me.lblContactNo.TabIndex = 18
        Me.lblContactNo.Text = "CONTACT NO"
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.Purple
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Location = New System.Drawing.Point(362, 46)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(31, 22)
        Me.btnView.TabIndex = 22
        Me.btnView.Text = "..."
        Me.btnView.UseVisualStyleBackColor = False
        '
        'txtContactNo
        '
        Me.txtContactNo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.Location = New System.Drawing.Point(489, 51)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(239, 22)
        Me.txtContactNo.TabIndex = 19
        Me.txtContactNo.Tag = "*Contact No"
        '
        'tabPetInfo
        '
        Me.tabPetInfo.Controls.Add(Me.tabPet)
        Me.tabPetInfo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPetInfo.Location = New System.Drawing.Point(33, 95)
        Me.tabPetInfo.Name = "tabPetInfo"
        Me.tabPetInfo.SelectedIndex = 0
        Me.tabPetInfo.Size = New System.Drawing.Size(735, 463)
        Me.tabPetInfo.TabIndex = 23
        '
        'tabPet
        '
        Me.tabPet.Controls.Add(Me.btnAddRecord)
        Me.tabPet.Controls.Add(Me.btnSave)
        Me.tabPet.Controls.Add(Me.grpTreatment)
        Me.tabPet.Controls.Add(Me.grpVaccinations)
        Me.tabPet.Controls.Add(Me.grpHistory)
        Me.tabPet.Controls.Add(Me.datHistory)
        Me.tabPet.Location = New System.Drawing.Point(4, 23)
        Me.tabPet.Name = "tabPet"
        Me.tabPet.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPet.Size = New System.Drawing.Size(727, 436)
        Me.tabPet.TabIndex = 0
        Me.tabPet.Text = "PET"
        Me.tabPet.UseVisualStyleBackColor = True
        '
        'grpTreatment
        '
        Me.grpTreatment.Controls.Add(Me.chkTreatments)
        Me.grpTreatment.Location = New System.Drawing.Point(492, 182)
        Me.grpTreatment.Name = "grpTreatment"
        Me.grpTreatment.Size = New System.Drawing.Size(229, 176)
        Me.grpTreatment.TabIndex = 3
        Me.grpTreatment.TabStop = False
        Me.grpTreatment.Text = "TREATMENTS"
        '
        'chkTreatments
        '
        Me.chkTreatments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chkTreatments.CheckOnClick = True
        Me.chkTreatments.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTreatments.FormattingEnabled = True
        Me.chkTreatments.Items.AddRange(New Object() {"Deworm", "Bra", "Bela", "Bac", "Bay", "Pen", "Cer"})
        Me.chkTreatments.Location = New System.Drawing.Point(21, 32)
        Me.chkTreatments.Name = "chkTreatments"
        Me.chkTreatments.Size = New System.Drawing.Size(186, 126)
        Me.chkTreatments.TabIndex = 1
        '
        'grpVaccinations
        '
        Me.grpVaccinations.Controls.Add(Me.chkVaccinations)
        Me.grpVaccinations.Location = New System.Drawing.Point(252, 179)
        Me.grpVaccinations.Name = "grpVaccinations"
        Me.grpVaccinations.Size = New System.Drawing.Size(234, 179)
        Me.grpVaccinations.TabIndex = 2
        Me.grpVaccinations.TabStop = False
        Me.grpVaccinations.Text = "VACCINATIONS"
        '
        'chkVaccinations
        '
        Me.chkVaccinations.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chkVaccinations.CheckOnClick = True
        Me.chkVaccinations.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVaccinations.FormattingEnabled = True
        Me.chkVaccinations.Items.AddRange(New Object() {"P/D", "2 in 1", "9 in 1", "K/C", "R", "M"})
        Me.chkVaccinations.Location = New System.Drawing.Point(23, 32)
        Me.chkVaccinations.Name = "chkVaccinations"
        Me.chkVaccinations.Size = New System.Drawing.Size(186, 144)
        Me.chkVaccinations.TabIndex = 0
        '
        'grpHistory
        '
        Me.grpHistory.Controls.Add(Me.dtpNextVisit)
        Me.grpHistory.Controls.Add(Me.lblNextVist)
        Me.grpHistory.Controls.Add(Me.txtAmount)
        Me.grpHistory.Controls.Add(Me.lblAmount)
        Me.grpHistory.Controls.Add(Me.txtDX)
        Me.grpHistory.Controls.Add(Me.lblDX)
        Me.grpHistory.Controls.Add(Me.txtTemp)
        Me.grpHistory.Controls.Add(Me.lblTemp)
        Me.grpHistory.Controls.Add(Me.txtWT)
        Me.grpHistory.Controls.Add(Me.lblWT)
        Me.grpHistory.Controls.Add(Me.dtpVisitDate)
        Me.grpHistory.Controls.Add(Me.lblVisitDate)
        Me.grpHistory.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHistory.Location = New System.Drawing.Point(252, 6)
        Me.grpHistory.Name = "grpHistory"
        Me.grpHistory.Size = New System.Drawing.Size(469, 170)
        Me.grpHistory.TabIndex = 1
        Me.grpHistory.TabStop = False
        Me.grpHistory.Text = "VISIT INFORMATION"
        '
        'dtpNextVisit
        '
        Me.dtpNextVisit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNextVisit.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNextVisit.Location = New System.Drawing.Point(312, 113)
        Me.dtpNextVisit.Name = "dtpNextVisit"
        Me.dtpNextVisit.Size = New System.Drawing.Size(135, 23)
        Me.dtpNextVisit.TabIndex = 15
        '
        'lblNextVist
        '
        Me.lblNextVist.AutoSize = True
        Me.lblNextVist.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNextVist.Location = New System.Drawing.Point(246, 117)
        Me.lblNextVist.Name = "lblNextVist"
        Me.lblNextVist.Size = New System.Drawing.Size(65, 15)
        Me.lblNextVist.TabIndex = 14
        Me.lblNextVist.Text = "Next Visit :"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(74, 113)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(160, 23)
        Me.txtAmount.TabIndex = 13
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(6, 116)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(62, 15)
        Me.lblAmount.TabIndex = 12
        Me.lblAmount.Text = "AMOUNT :"
        '
        'txtDX
        '
        Me.txtDX.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDX.Location = New System.Drawing.Point(74, 84)
        Me.txtDX.Name = "txtDX"
        Me.txtDX.Size = New System.Drawing.Size(373, 23)
        Me.txtDX.TabIndex = 7
        '
        'lblDX
        '
        Me.lblDX.AutoSize = True
        Me.lblDX.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDX.Location = New System.Drawing.Point(41, 89)
        Me.lblDX.Name = "lblDX"
        Me.lblDX.Size = New System.Drawing.Size(28, 15)
        Me.lblDX.TabIndex = 6
        Me.lblDX.Text = "DX :"
        '
        'txtTemp
        '
        Me.txtTemp.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemp.Location = New System.Drawing.Point(287, 55)
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(160, 23)
        Me.txtTemp.TabIndex = 5
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemp.Location = New System.Drawing.Point(237, 60)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(41, 15)
        Me.lblTemp.TabIndex = 4
        Me.lblTemp.Text = "Temp :"
        '
        'txtWT
        '
        Me.txtWT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWT.Location = New System.Drawing.Point(74, 55)
        Me.txtWT.Name = "txtWT"
        Me.txtWT.Size = New System.Drawing.Size(160, 23)
        Me.txtWT.TabIndex = 3
        '
        'lblWT
        '
        Me.lblWT.AutoSize = True
        Me.lblWT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWT.Location = New System.Drawing.Point(41, 60)
        Me.lblWT.Name = "lblWT"
        Me.lblWT.Size = New System.Drawing.Size(31, 15)
        Me.lblWT.TabIndex = 2
        Me.lblWT.Text = "WT :"
        '
        'dtpVisitDate
        '
        Me.dtpVisitDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVisitDate.Location = New System.Drawing.Point(74, 27)
        Me.dtpVisitDate.Name = "dtpVisitDate"
        Me.dtpVisitDate.Size = New System.Drawing.Size(106, 23)
        Me.dtpVisitDate.TabIndex = 1
        '
        'lblVisitDate
        '
        Me.lblVisitDate.AutoSize = True
        Me.lblVisitDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisitDate.Location = New System.Drawing.Point(33, 31)
        Me.lblVisitDate.Name = "lblVisitDate"
        Me.lblVisitDate.Size = New System.Drawing.Size(39, 15)
        Me.lblVisitDate.TabIndex = 0
        Me.lblVisitDate.Text = "DATE :"
        '
        'datHistory
        '
        Me.datHistory.AllowUserToAddRows = False
        Me.datHistory.AllowUserToDeleteRows = False
        Me.datHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datHistory.Location = New System.Drawing.Point(6, 6)
        Me.datHistory.Name = "datHistory"
        Me.datHistory.ReadOnly = True
        Me.datHistory.Size = New System.Drawing.Size(240, 424)
        Me.datHistory.TabIndex = 0
        '
        'btnAddPet
        '
        Me.btnAddPet.BackColor = System.Drawing.Color.Purple
        Me.btnAddPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPet.ForeColor = System.Drawing.Color.White
        Me.btnAddPet.Location = New System.Drawing.Point(668, 79)
        Me.btnAddPet.Name = "btnAddPet"
        Me.btnAddPet.Size = New System.Drawing.Size(93, 33)
        Me.btnAddPet.TabIndex = 24
        Me.btnAddPet.Text = "ADD PET"
        Me.btnAddPet.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Purple
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(624, 382)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(97, 36)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnAddRecord
        '
        Me.btnAddRecord.BackColor = System.Drawing.Color.Purple
        Me.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRecord.ForeColor = System.Drawing.Color.White
        Me.btnAddRecord.Location = New System.Drawing.Point(524, 382)
        Me.btnAddRecord.Name = "btnAddRecord"
        Me.btnAddRecord.Size = New System.Drawing.Size(97, 36)
        Me.btnAddRecord.TabIndex = 5
        Me.btnAddRecord.Text = "ADD RECORD"
        Me.btnAddRecord.UseVisualStyleBackColor = False
        '
        'frmScheduleInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(780, 570)
        Me.Controls.Add(Me.btnAddPet)
        Me.Controls.Add(Me.tabPetInfo)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.txtContactNo)
        Me.Controls.Add(Me.lblContactNo)
        Me.Controls.Add(Me.txtCustomerCode)
        Me.Controls.Add(Me.lblCustomerCD)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmScheduleInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule Information"
        Me.tabPetInfo.ResumeLayout(False)
        Me.tabPet.ResumeLayout(False)
        Me.grpTreatment.ResumeLayout(False)
        Me.grpVaccinations.ResumeLayout(False)
        Me.grpHistory.ResumeLayout(False)
        Me.grpHistory.PerformLayout()
        CType(Me.datHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerCode As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerCD As System.Windows.Forms.Label
    Friend WithEvents lblContactNo As System.Windows.Forms.Label
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents txtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents tabPetInfo As System.Windows.Forms.TabControl
    Friend WithEvents btnAddPet As System.Windows.Forms.Button
    Friend WithEvents tabPet As System.Windows.Forms.TabPage
    Friend WithEvents grpTreatment As System.Windows.Forms.GroupBox
    Friend WithEvents chkTreatments As System.Windows.Forms.CheckedListBox
    Friend WithEvents grpVaccinations As System.Windows.Forms.GroupBox
    Friend WithEvents chkVaccinations As System.Windows.Forms.CheckedListBox
    Friend WithEvents grpHistory As System.Windows.Forms.GroupBox
    Friend WithEvents dtpNextVisit As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNextVist As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents txtDX As System.Windows.Forms.TextBox
    Friend WithEvents lblDX As System.Windows.Forms.Label
    Friend WithEvents txtTemp As System.Windows.Forms.TextBox
    Friend WithEvents lblTemp As System.Windows.Forms.Label
    Friend WithEvents txtWT As System.Windows.Forms.TextBox
    Friend WithEvents lblWT As System.Windows.Forms.Label
    Friend WithEvents dtpVisitDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblVisitDate As System.Windows.Forms.Label
    Friend WithEvents datHistory As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddRecord As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
