<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScheduleReservation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScheduleReservation))
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.chkCancel = New System.Windows.Forms.CheckBox()
        Me.chkIsArrived = New System.Windows.Forms.CheckBox()
        Me.btnOwner = New System.Windows.Forms.Button()
        Me.dtpDateSched = New System.Windows.Forms.DateTimePicker()
        Me.lblDateSched = New System.Windows.Forms.Label()
        Me.cboServices = New System.Windows.Forms.ComboBox()
        Me.lblService = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtPurpose = New System.Windows.Forms.TextBox()
        Me.lblPurpose = New System.Windows.Forms.Label()
        Me.lblReservationDetails = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblVisitorInfo = New System.Windows.Forms.Label()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.lblVisitCode = New System.Windows.Forms.Label()
        Me.txtSchedCode = New System.Windows.Forms.TextBox()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.pnlContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContent
        '
        Me.pnlContent.Controls.Add(Me.chkCancel)
        Me.pnlContent.Controls.Add(Me.chkIsArrived)
        Me.pnlContent.Controls.Add(Me.btnOwner)
        Me.pnlContent.Controls.Add(Me.dtpDateSched)
        Me.pnlContent.Controls.Add(Me.lblDateSched)
        Me.pnlContent.Controls.Add(Me.cboServices)
        Me.pnlContent.Controls.Add(Me.lblService)
        Me.pnlContent.Controls.Add(Me.btnSave)
        Me.pnlContent.Controls.Add(Me.txtPurpose)
        Me.pnlContent.Controls.Add(Me.lblPurpose)
        Me.pnlContent.Controls.Add(Me.lblReservationDetails)
        Me.pnlContent.Controls.Add(Me.lblContact)
        Me.pnlContent.Controls.Add(Me.lblAddress)
        Me.pnlContent.Controls.Add(Me.txtContact)
        Me.pnlContent.Controls.Add(Me.txtAddress)
        Me.pnlContent.Controls.Add(Me.lblVisitorInfo)
        Me.pnlContent.Controls.Add(Me.lblCustomer)
        Me.pnlContent.Controls.Add(Me.txtCustomer)
        Me.pnlContent.Controls.Add(Me.lblVisitCode)
        Me.pnlContent.Controls.Add(Me.txtSchedCode)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(25, 0)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(328, 373)
        Me.pnlContent.TabIndex = 7
        '
        'chkCancel
        '
        Me.chkCancel.AutoSize = True
        Me.chkCancel.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCancel.Location = New System.Drawing.Point(203, 290)
        Me.chkCancel.Name = "chkCancel"
        Me.chkCancel.Size = New System.Drawing.Size(61, 17)
        Me.chkCancel.TabIndex = 31
        Me.chkCancel.Text = "CANCEL"
        Me.chkCancel.UseVisualStyleBackColor = True
        Me.chkCancel.Visible = False
        '
        'chkIsArrived
        '
        Me.chkIsArrived.AutoSize = True
        Me.chkIsArrived.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIsArrived.Location = New System.Drawing.Point(105, 290)
        Me.chkIsArrived.Name = "chkIsArrived"
        Me.chkIsArrived.Size = New System.Drawing.Size(65, 17)
        Me.chkIsArrived.TabIndex = 30
        Me.chkIsArrived.Text = "ARRIVED"
        Me.chkIsArrived.UseVisualStyleBackColor = True
        Me.chkIsArrived.Visible = False
        '
        'btnOwner
        '
        Me.btnOwner.BackColor = System.Drawing.Color.Purple
        Me.btnOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOwner.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOwner.ForeColor = System.Drawing.Color.White
        Me.btnOwner.Location = New System.Drawing.Point(277, 69)
        Me.btnOwner.Name = "btnOwner"
        Me.btnOwner.Size = New System.Drawing.Size(36, 23)
        Me.btnOwner.TabIndex = 29
        Me.btnOwner.Text = "•••"
        Me.btnOwner.UseVisualStyleBackColor = False
        '
        'dtpDateSched
        '
        Me.dtpDateSched.CustomFormat = "yyyy/MM/dd"
        Me.dtpDateSched.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateSched.Location = New System.Drawing.Point(105, 189)
        Me.dtpDateSched.Name = "dtpDateSched"
        Me.dtpDateSched.Size = New System.Drawing.Size(90, 21)
        Me.dtpDateSched.TabIndex = 6
        '
        'lblDateSched
        '
        Me.lblDateSched.AutoSize = True
        Me.lblDateSched.Location = New System.Drawing.Point(10, 193)
        Me.lblDateSched.Name = "lblDateSched"
        Me.lblDateSched.Size = New System.Drawing.Size(92, 13)
        Me.lblDateSched.TabIndex = 28
        Me.lblDateSched.Text = "SCHEDULED DATE : "
        Me.lblDateSched.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboServices
        '
        Me.cboServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboServices.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboServices.FormattingEnabled = True
        Me.cboServices.Location = New System.Drawing.Point(105, 216)
        Me.cboServices.Name = "cboServices"
        Me.cboServices.Size = New System.Drawing.Size(118, 21)
        Me.cboServices.TabIndex = 9
        Me.cboServices.Tag = "*Service"
        '
        'lblService
        '
        Me.lblService.AutoSize = True
        Me.lblService.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblService.Location = New System.Drawing.Point(52, 220)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(50, 13)
        Me.lblService.TabIndex = 27
        Me.lblService.Text = "SERVICE : "
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Purple
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(229, 334)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(78, 31)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "&SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtPurpose
        '
        Me.txtPurpose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPurpose.Location = New System.Drawing.Point(105, 243)
        Me.txtPurpose.MaxLength = 500
        Me.txtPurpose.Multiline = True
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(202, 41)
        Me.txtPurpose.TabIndex = 10
        Me.txtPurpose.Tag = "*Purpose"
        '
        'lblPurpose
        '
        Me.lblPurpose.AutoSize = True
        Me.lblPurpose.Location = New System.Drawing.Point(46, 247)
        Me.lblPurpose.Name = "lblPurpose"
        Me.lblPurpose.Size = New System.Drawing.Size(56, 13)
        Me.lblPurpose.TabIndex = 25
        Me.lblPurpose.Text = "PURPOSE : "
        Me.lblPurpose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReservationDetails
        '
        Me.lblReservationDetails.AutoSize = True
        Me.lblReservationDetails.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservationDetails.Location = New System.Drawing.Point(14, 168)
        Me.lblReservationDetails.Name = "lblReservationDetails"
        Me.lblReservationDetails.Size = New System.Drawing.Size(125, 15)
        Me.lblReservationDetails.TabIndex = 19
        Me.lblReservationDetails.Text = "RESERVATION DETAILS"
        Me.lblReservationDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Location = New System.Drawing.Point(29, 148)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(73, 13)
        Me.lblContact.TabIndex = 16
        Me.lblContact.Text = "CONTACT No. : "
        Me.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(47, 101)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(55, 13)
        Me.lblAddress.TabIndex = 16
        Me.lblAddress.Text = "ADDRESS : "
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContact
        '
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact.Location = New System.Drawing.Point(105, 144)
        Me.txtContact.MaxLength = 20
        Me.txtContact.Name = "txtContact"
        Me.txtContact.ReadOnly = True
        Me.txtContact.Size = New System.Drawing.Size(111, 21)
        Me.txtContact.TabIndex = 5
        Me.txtContact.Tag = "*Contact No"
        Me.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Location = New System.Drawing.Point(105, 97)
        Me.txtAddress.MaxLength = 500
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(208, 41)
        Me.txtAddress.TabIndex = 4
        Me.txtAddress.Tag = "*Address"
        '
        'lblVisitorInfo
        '
        Me.lblVisitorInfo.AutoSize = True
        Me.lblVisitorInfo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisitorInfo.Location = New System.Drawing.Point(9, 18)
        Me.lblVisitorInfo.Name = "lblVisitorInfo"
        Me.lblVisitorInfo.Size = New System.Drawing.Size(149, 15)
        Me.lblVisitorInfo.TabIndex = 14
        Me.lblVisitorInfo.Text = "CUSTOMER INFORMATION"
        Me.lblVisitorInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(38, 74)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(64, 13)
        Me.lblCustomer.TabIndex = 13
        Me.lblCustomer.Text = "CUSTOMER : "
        Me.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCustomer
        '
        Me.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomer.Location = New System.Drawing.Point(105, 70)
        Me.txtCustomer.MaxLength = 100
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.ReadOnly = True
        Me.txtCustomer.Size = New System.Drawing.Size(170, 21)
        Me.txtCustomer.TabIndex = 2
        Me.txtCustomer.Tag = "*Customer Name"
        Me.txtCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblVisitCode
        '
        Me.lblVisitCode.AutoSize = True
        Me.lblVisitCode.Location = New System.Drawing.Point(14, 47)
        Me.lblVisitCode.Name = "lblVisitCode"
        Me.lblVisitCode.Size = New System.Drawing.Size(88, 13)
        Me.lblVisitCode.TabIndex = 12
        Me.lblVisitCode.Text = "SCHEDULE CODE : "
        Me.lblVisitCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSchedCode
        '
        Me.txtSchedCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSchedCode.Location = New System.Drawing.Point(105, 43)
        Me.txtSchedCode.MaxLength = 10
        Me.txtSchedCode.Name = "txtSchedCode"
        Me.txtSchedCode.ReadOnly = True
        Me.txtSchedCode.Size = New System.Drawing.Size(100, 21)
        Me.txtSchedCode.TabIndex = 1
        Me.txtSchedCode.Text = "- - -"
        Me.txtSchedCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Purple
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(25, 373)
        Me.pnlHeader.TabIndex = 6
        '
        'frmScheduleReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(353, 373)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmScheduleReservation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule Reservation"
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblVisitorInfo As System.Windows.Forms.Label
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents lblVisitCode As System.Windows.Forms.Label
    Friend WithEvents txtSchedCode As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblContact As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents lblReservationDetails As System.Windows.Forms.Label
    Friend WithEvents txtPurpose As System.Windows.Forms.TextBox
    Friend WithEvents lblPurpose As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cboServices As System.Windows.Forms.ComboBox
    Friend WithEvents lblService As System.Windows.Forms.Label
    Friend WithEvents dtpDateSched As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDateSched As System.Windows.Forms.Label
    Friend WithEvents btnOwner As Button
    Friend WithEvents chkCancel As CheckBox
    Friend WithEvents chkIsArrived As CheckBox
End Class
