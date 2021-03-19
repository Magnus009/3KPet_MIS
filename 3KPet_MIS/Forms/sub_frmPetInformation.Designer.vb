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
        Me.btnAddRecord = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
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
        Me.cboPet = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpTreatment.SuspendLayout()
        Me.grpVaccinations.SuspendLayout()
        Me.grpHistory.SuspendLayout()
        CType(Me.datHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddRecord
        '
        Me.btnAddRecord.BackColor = System.Drawing.Color.Purple
        Me.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRecord.ForeColor = System.Drawing.Color.White
        Me.btnAddRecord.Location = New System.Drawing.Point(518, 376)
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
        Me.btnSave.Location = New System.Drawing.Point(621, 376)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(97, 36)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'grpTreatment
        '
        Me.grpTreatment.Controls.Add(Me.chkTreatments)
        Me.grpTreatment.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTreatment.Location = New System.Drawing.Point(489, 192)
        Me.grpTreatment.Name = "grpTreatment"
        Me.grpTreatment.Size = New System.Drawing.Size(229, 176)
        Me.grpTreatment.TabIndex = 4
        Me.grpTreatment.TabStop = False
        Me.grpTreatment.Text = "TREATMENTS"
        '
        'chkTreatments
        '
        Me.chkTreatments.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.chkTreatments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chkTreatments.CheckOnClick = True
        Me.chkTreatments.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTreatments.FormattingEnabled = True
        Me.chkTreatments.Items.AddRange(New Object() {"Deworm", "Bra", "Bela", "Bac", "Bay", "Pen", "Cer"})
        Me.chkTreatments.Location = New System.Drawing.Point(22, 32)
        Me.chkTreatments.Name = "chkTreatments"
        Me.chkTreatments.Size = New System.Drawing.Size(186, 126)
        Me.chkTreatments.TabIndex = 1
        '
        'grpVaccinations
        '
        Me.grpVaccinations.Controls.Add(Me.chkVaccinations)
        Me.grpVaccinations.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpVaccinations.Location = New System.Drawing.Point(249, 189)
        Me.grpVaccinations.Name = "grpVaccinations"
        Me.grpVaccinations.Size = New System.Drawing.Size(234, 179)
        Me.grpVaccinations.TabIndex = 3
        Me.grpVaccinations.TabStop = False
        Me.grpVaccinations.Text = "VACCINATIONS"
        '
        'chkVaccinations
        '
        Me.chkVaccinations.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.chkVaccinations.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chkVaccinations.CheckOnClick = True
        Me.chkVaccinations.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVaccinations.FormattingEnabled = True
        Me.chkVaccinations.Items.AddRange(New Object() {"P/D", "2 in 1", "9 in 1", "K/C", "R", "M"})
        Me.chkVaccinations.Location = New System.Drawing.Point(24, 32)
        Me.chkVaccinations.Name = "chkVaccinations"
        Me.chkVaccinations.Size = New System.Drawing.Size(186, 144)
        Me.chkVaccinations.TabIndex = 1
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
        Me.grpHistory.Location = New System.Drawing.Point(249, 16)
        Me.grpHistory.Name = "grpHistory"
        Me.grpHistory.Size = New System.Drawing.Size(469, 170)
        Me.grpHistory.TabIndex = 2
        Me.grpHistory.TabStop = False
        Me.grpHistory.Text = "VISIT INFORMATION"
        '
        'dtpNextVisit
        '
        Me.dtpNextVisit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNextVisit.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNextVisit.Location = New System.Drawing.Point(313, 113)
        Me.dtpNextVisit.Name = "dtpNextVisit"
        Me.dtpNextVisit.Size = New System.Drawing.Size(135, 23)
        Me.dtpNextVisit.TabIndex = 6
        '
        'lblNextVist
        '
        Me.lblNextVist.AutoSize = True
        Me.lblNextVist.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNextVist.Location = New System.Drawing.Point(247, 117)
        Me.lblNextVist.Name = "lblNextVist"
        Me.lblNextVist.Size = New System.Drawing.Size(65, 15)
        Me.lblNextVist.TabIndex = 14
        Me.lblNextVist.Text = "Next Visit :"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(75, 113)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(160, 23)
        Me.txtAmount.TabIndex = 5
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(7, 116)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(62, 15)
        Me.lblAmount.TabIndex = 12
        Me.lblAmount.Text = "AMOUNT :"
        '
        'txtDX
        '
        Me.txtDX.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDX.Location = New System.Drawing.Point(75, 84)
        Me.txtDX.Name = "txtDX"
        Me.txtDX.Size = New System.Drawing.Size(373, 23)
        Me.txtDX.TabIndex = 4
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
        Me.dtpVisitDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
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
        Me.datHistory.Location = New System.Drawing.Point(3, 61)
        Me.datHistory.Name = "datHistory"
        Me.datHistory.ReadOnly = True
        Me.datHistory.RowHeadersVisible = False
        Me.datHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datHistory.Size = New System.Drawing.Size(240, 351)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "PET NAME :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 18)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "VISIT HISTORY"
        '
        'sub_frmPetInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(721, 430)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboPet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddRecord)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpTreatment)
        Me.Controls.Add(Me.grpVaccinations)
        Me.Controls.Add(Me.grpHistory)
        Me.Controls.Add(Me.datHistory)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "sub_frmPetInformation"
        Me.grpTreatment.ResumeLayout(False)
        Me.grpVaccinations.ResumeLayout(False)
        Me.grpHistory.ResumeLayout(False)
        Me.grpHistory.PerformLayout()
        CType(Me.datHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddRecord As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
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
    Friend WithEvents cboPet As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
