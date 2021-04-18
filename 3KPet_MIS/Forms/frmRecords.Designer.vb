<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRecords
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecords))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.btnNewRecord = New System.Windows.Forms.Button()
        Me.grpPetInfo = New System.Windows.Forms.GroupBox()
        Me.txtProfilePath = New System.Windows.Forms.TextBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.picPet = New System.Windows.Forms.PictureBox()
        Me.chkBirthday = New System.Windows.Forms.CheckBox()
        Me.dtpBirthday = New System.Windows.Forms.DateTimePicker()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.chkisDeceased = New System.Windows.Forms.CheckBox()
        Me.optFemale = New System.Windows.Forms.RadioButton()
        Me.optMale = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblPetAge = New System.Windows.Forms.Label()
        Me.txtPetAge = New System.Windows.Forms.TextBox()
        Me.lblPetColor = New System.Windows.Forms.Label()
        Me.txtPetColor = New System.Windows.Forms.TextBox()
        Me.lblBreed = New System.Windows.Forms.Label()
        Me.txtPetBreed = New System.Windows.Forms.TextBox()
        Me.lblpetName = New System.Windows.Forms.Label()
        Me.txtPetName = New System.Windows.Forms.TextBox()
        Me.lblPetID = New System.Windows.Forms.Label()
        Me.txtPetID = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.grpOwnerInfo = New System.Windows.Forms.GroupBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtOwnerAddress = New System.Windows.Forms.TextBox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.txtOwnerContactNo = New System.Windows.Forms.TextBox()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.txtOwnerFName = New System.Windows.Forms.TextBox()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.txtOwnerLName = New System.Windows.Forms.TextBox()
        Me.lblOwnerID = New System.Windows.Forms.Label()
        Me.txtOwnerID = New System.Windows.Forms.TextBox()
        Me.datInformation = New System.Windows.Forms.DataGridView()
        Me.colOwnerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOwnerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPetName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSelect = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlHeader.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.grpPetInfo.SuspendLayout()
        CType(Me.picPet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOwnerInfo.SuspendLayout()
        CType(Me.datInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Purple
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(819, 57)
        Me.pnlHeader.TabIndex = 3
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(12, 12)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(120, 33)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "RECORDS"
        '
        'pnlContent
        '
        Me.pnlContent.Controls.Add(Me.btnNewRecord)
        Me.pnlContent.Controls.Add(Me.grpPetInfo)
        Me.pnlContent.Controls.Add(Me.btnConfirm)
        Me.pnlContent.Controls.Add(Me.txtSearch)
        Me.pnlContent.Controls.Add(Me.lblSearch)
        Me.pnlContent.Controls.Add(Me.grpOwnerInfo)
        Me.pnlContent.Controls.Add(Me.datInformation)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 57)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(819, 496)
        Me.pnlContent.TabIndex = 4
        '
        'btnNewRecord
        '
        Me.btnNewRecord.BackColor = System.Drawing.Color.Purple
        Me.btnNewRecord.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewRecord.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRecord.ForeColor = System.Drawing.Color.White
        Me.btnNewRecord.Location = New System.Drawing.Point(559, 448)
        Me.btnNewRecord.Name = "btnNewRecord"
        Me.btnNewRecord.Size = New System.Drawing.Size(121, 35)
        Me.btnNewRecord.TabIndex = 5
        Me.btnNewRecord.Text = "&NEW RECORD"
        Me.btnNewRecord.UseVisualStyleBackColor = False
        '
        'grpPetInfo
        '
        Me.grpPetInfo.Controls.Add(Me.txtProfilePath)
        Me.grpPetInfo.Controls.Add(Me.btnUpload)
        Me.grpPetInfo.Controls.Add(Me.picPet)
        Me.grpPetInfo.Controls.Add(Me.chkBirthday)
        Me.grpPetInfo.Controls.Add(Me.dtpBirthday)
        Me.grpPetInfo.Controls.Add(Me.lblBirthday)
        Me.grpPetInfo.Controls.Add(Me.chkisDeceased)
        Me.grpPetInfo.Controls.Add(Me.optFemale)
        Me.grpPetInfo.Controls.Add(Me.optMale)
        Me.grpPetInfo.Controls.Add(Me.Label10)
        Me.grpPetInfo.Controls.Add(Me.lblPetAge)
        Me.grpPetInfo.Controls.Add(Me.txtPetAge)
        Me.grpPetInfo.Controls.Add(Me.lblPetColor)
        Me.grpPetInfo.Controls.Add(Me.txtPetColor)
        Me.grpPetInfo.Controls.Add(Me.lblBreed)
        Me.grpPetInfo.Controls.Add(Me.txtPetBreed)
        Me.grpPetInfo.Controls.Add(Me.lblpetName)
        Me.grpPetInfo.Controls.Add(Me.txtPetName)
        Me.grpPetInfo.Controls.Add(Me.lblPetID)
        Me.grpPetInfo.Controls.Add(Me.txtPetID)
        Me.grpPetInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpPetInfo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPetInfo.Location = New System.Drawing.Point(474, 207)
        Me.grpPetInfo.Name = "grpPetInfo"
        Me.grpPetInfo.Size = New System.Drawing.Size(330, 235)
        Me.grpPetInfo.TabIndex = 3
        Me.grpPetInfo.TabStop = False
        Me.grpPetInfo.Text = "PET INFORMATION"
        '
        'txtProfilePath
        '
        Me.txtProfilePath.Font = New System.Drawing.Font("Calibri", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfilePath.Location = New System.Drawing.Point(335, 18)
        Me.txtProfilePath.Name = "txtProfilePath"
        Me.txtProfilePath.Size = New System.Drawing.Size(116, 18)
        Me.txtProfilePath.TabIndex = 17
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.Purple
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Font = New System.Drawing.Font("Calibri", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.ForeColor = System.Drawing.Color.White
        Me.btnUpload.Location = New System.Drawing.Point(228, 93)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(84, 23)
        Me.btnUpload.TabIndex = 16
        Me.btnUpload.Text = "UPLOAD"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'picPet
        '
        Me.picPet.BackColor = System.Drawing.Color.LightGray
        Me.picPet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPet.Image = Global._3KPet_MIS.My.Resources.Resources.no_profile
        Me.picPet.Location = New System.Drawing.Point(228, 18)
        Me.picPet.Name = "picPet"
        Me.picPet.Size = New System.Drawing.Size(84, 75)
        Me.picPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPet.TabIndex = 15
        Me.picPet.TabStop = False
        '
        'chkBirthday
        '
        Me.chkBirthday.AutoSize = True
        Me.chkBirthday.Location = New System.Drawing.Point(152, 151)
        Me.chkBirthday.Name = "chkBirthday"
        Me.chkBirthday.Size = New System.Drawing.Size(15, 14)
        Me.chkBirthday.TabIndex = 14
        Me.chkBirthday.UseVisualStyleBackColor = True
        '
        'dtpBirthday
        '
        Me.dtpBirthday.CustomFormat = "yyyy/MM/dd"
        Me.dtpBirthday.Enabled = False
        Me.dtpBirthday.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBirthday.Location = New System.Drawing.Point(68, 147)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(82, 22)
        Me.dtpBirthday.TabIndex = 13
        '
        'lblBirthday
        '
        Me.lblBirthday.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthday.Location = New System.Drawing.Point(6, 149)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(61, 18)
        Me.lblBirthday.TabIndex = 12
        Me.lblBirthday.Text = "BIRTHDAY :"
        Me.lblBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkisDeceased
        '
        Me.chkisDeceased.AutoSize = True
        Me.chkisDeceased.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkisDeceased.Location = New System.Drawing.Point(212, 177)
        Me.chkisDeceased.Name = "chkisDeceased"
        Me.chkisDeceased.Size = New System.Drawing.Size(78, 19)
        Me.chkisDeceased.TabIndex = 11
        Me.chkisDeceased.Text = "Deceased"
        Me.chkisDeceased.UseVisualStyleBackColor = True
        '
        'optFemale
        '
        Me.optFemale.AutoSize = True
        Me.optFemale.BackColor = System.Drawing.Color.Transparent
        Me.optFemale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optFemale.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFemale.Location = New System.Drawing.Point(267, 150)
        Me.optFemale.Name = "optFemale"
        Me.optFemale.Size = New System.Drawing.Size(59, 17)
        Me.optFemale.TabIndex = 6
        Me.optFemale.Text = "&Female"
        Me.optFemale.UseVisualStyleBackColor = False
        '
        'optMale
        '
        Me.optMale.AutoSize = True
        Me.optMale.BackColor = System.Drawing.Color.Transparent
        Me.optMale.CausesValidation = False
        Me.optMale.Checked = True
        Me.optMale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optMale.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMale.Location = New System.Drawing.Point(212, 150)
        Me.optMale.Name = "optMale"
        Me.optMale.Size = New System.Drawing.Size(48, 17)
        Me.optMale.TabIndex = 5
        Me.optMale.TabStop = True
        Me.optMale.Text = "&Male"
        Me.optMale.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(234, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 18)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "GENDER : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPetAge
        '
        Me.lblPetAge.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPetAge.Location = New System.Drawing.Point(6, 177)
        Me.lblPetAge.Name = "lblPetAge"
        Me.lblPetAge.Size = New System.Drawing.Size(61, 18)
        Me.lblPetAge.TabIndex = 9
        Me.lblPetAge.Text = "AGE : "
        Me.lblPetAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPetAge
        '
        Me.txtPetAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPetAge.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPetAge.Location = New System.Drawing.Point(68, 176)
        Me.txtPetAge.MaxLength = 3
        Me.txtPetAge.Name = "txtPetAge"
        Me.txtPetAge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPetAge.Size = New System.Drawing.Size(48, 21)
        Me.txtPetAge.TabIndex = 4
        Me.txtPetAge.Tag = ""
        '
        'lblPetColor
        '
        Me.lblPetColor.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPetColor.Location = New System.Drawing.Point(6, 122)
        Me.lblPetColor.Name = "lblPetColor"
        Me.lblPetColor.Size = New System.Drawing.Size(61, 18)
        Me.lblPetColor.TabIndex = 7
        Me.lblPetColor.Text = "PET COLOR : "
        Me.lblPetColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPetColor
        '
        Me.txtPetColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPetColor.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPetColor.Location = New System.Drawing.Point(68, 121)
        Me.txtPetColor.MaxLength = 20
        Me.txtPetColor.Name = "txtPetColor"
        Me.txtPetColor.Size = New System.Drawing.Size(82, 21)
        Me.txtPetColor.TabIndex = 3
        Me.txtPetColor.Tag = "*Pet Color"
        '
        'lblBreed
        '
        Me.lblBreed.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBreed.Location = New System.Drawing.Point(6, 95)
        Me.lblBreed.Name = "lblBreed"
        Me.lblBreed.Size = New System.Drawing.Size(61, 18)
        Me.lblBreed.TabIndex = 5
        Me.lblBreed.Text = "BREED : "
        Me.lblBreed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPetBreed
        '
        Me.txtPetBreed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPetBreed.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPetBreed.Location = New System.Drawing.Point(68, 94)
        Me.txtPetBreed.MaxLength = 50
        Me.txtPetBreed.Name = "txtPetBreed"
        Me.txtPetBreed.Size = New System.Drawing.Size(100, 21)
        Me.txtPetBreed.TabIndex = 2
        Me.txtPetBreed.Tag = "*Breed"
        '
        'lblpetName
        '
        Me.lblpetName.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpetName.Location = New System.Drawing.Point(6, 68)
        Me.lblpetName.Name = "lblpetName"
        Me.lblpetName.Size = New System.Drawing.Size(61, 18)
        Me.lblpetName.TabIndex = 3
        Me.lblpetName.Text = "NAME : "
        Me.lblpetName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPetName
        '
        Me.txtPetName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPetName.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPetName.Location = New System.Drawing.Point(68, 67)
        Me.txtPetName.MaxLength = 100
        Me.txtPetName.Name = "txtPetName"
        Me.txtPetName.Size = New System.Drawing.Size(138, 21)
        Me.txtPetName.TabIndex = 1
        Me.txtPetName.Tag = "*Pet Name"
        '
        'lblPetID
        '
        Me.lblPetID.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPetID.Location = New System.Drawing.Point(24, 41)
        Me.lblPetID.Name = "lblPetID"
        Me.lblPetID.Size = New System.Drawing.Size(43, 18)
        Me.lblPetID.TabIndex = 1
        Me.lblPetID.Text = "ID : "
        Me.lblPetID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPetID
        '
        Me.txtPetID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPetID.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPetID.Location = New System.Drawing.Point(68, 40)
        Me.txtPetID.MaxLength = 10
        Me.txtPetID.Name = "txtPetID"
        Me.txtPetID.ReadOnly = True
        Me.txtPetID.Size = New System.Drawing.Size(82, 21)
        Me.txtPetID.TabIndex = 0
        Me.txtPetID.Text = "- - -"
        Me.txtPetID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnConfirm
        '
        Me.btnConfirm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirm.BackColor = System.Drawing.Color.Purple
        Me.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(683, 448)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(121, 35)
        Me.btnConfirm.TabIndex = 4
        Me.btnConfirm.Text = "&CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(65, 15)
        Me.txtSearch.MaxLength = 50
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(265, 21)
        Me.txtSearch.TabIndex = 0
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(12, 18)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(47, 13)
        Me.lblSearch.TabIndex = 3
        Me.lblSearch.Text = "SEARCH :"
        '
        'grpOwnerInfo
        '
        Me.grpOwnerInfo.Controls.Add(Me.lblAddress)
        Me.grpOwnerInfo.Controls.Add(Me.txtOwnerAddress)
        Me.grpOwnerInfo.Controls.Add(Me.lblContact)
        Me.grpOwnerInfo.Controls.Add(Me.txtOwnerContactNo)
        Me.grpOwnerInfo.Controls.Add(Me.lblFName)
        Me.grpOwnerInfo.Controls.Add(Me.txtOwnerFName)
        Me.grpOwnerInfo.Controls.Add(Me.lblLName)
        Me.grpOwnerInfo.Controls.Add(Me.txtOwnerLName)
        Me.grpOwnerInfo.Controls.Add(Me.lblOwnerID)
        Me.grpOwnerInfo.Controls.Add(Me.txtOwnerID)
        Me.grpOwnerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpOwnerInfo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOwnerInfo.Location = New System.Drawing.Point(474, 15)
        Me.grpOwnerInfo.Name = "grpOwnerInfo"
        Me.grpOwnerInfo.Size = New System.Drawing.Size(330, 186)
        Me.grpOwnerInfo.TabIndex = 2
        Me.grpOwnerInfo.TabStop = False
        Me.grpOwnerInfo.Text = "OWNER INFORMATION"
        '
        'lblAddress
        '
        Me.lblAddress.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(6, 136)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(84, 18)
        Me.lblAddress.TabIndex = 9
        Me.lblAddress.Text = "ADDRESS : "
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOwnerAddress
        '
        Me.txtOwnerAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOwnerAddress.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOwnerAddress.Location = New System.Drawing.Point(96, 135)
        Me.txtOwnerAddress.MaxLength = 250
        Me.txtOwnerAddress.Multiline = True
        Me.txtOwnerAddress.Name = "txtOwnerAddress"
        Me.txtOwnerAddress.Size = New System.Drawing.Size(222, 40)
        Me.txtOwnerAddress.TabIndex = 4
        Me.txtOwnerAddress.Tag = "*Address"
        '
        'lblContact
        '
        Me.lblContact.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(6, 109)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(84, 18)
        Me.lblContact.TabIndex = 7
        Me.lblContact.Text = "CONTACT No. : "
        Me.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOwnerContactNo
        '
        Me.txtOwnerContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOwnerContactNo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOwnerContactNo.Location = New System.Drawing.Point(96, 108)
        Me.txtOwnerContactNo.MaxLength = 20
        Me.txtOwnerContactNo.Name = "txtOwnerContactNo"
        Me.txtOwnerContactNo.Size = New System.Drawing.Size(128, 21)
        Me.txtOwnerContactNo.TabIndex = 3
        Me.txtOwnerContactNo.Tag = "*Contact No"
        '
        'lblFName
        '
        Me.lblFName.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFName.Location = New System.Drawing.Point(6, 82)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(84, 18)
        Me.lblFName.TabIndex = 5
        Me.lblFName.Text = "FIRST NAME : "
        Me.lblFName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOwnerFName
        '
        Me.txtOwnerFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOwnerFName.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOwnerFName.Location = New System.Drawing.Point(96, 81)
        Me.txtOwnerFName.MaxLength = 50
        Me.txtOwnerFName.Name = "txtOwnerFName"
        Me.txtOwnerFName.Size = New System.Drawing.Size(222, 21)
        Me.txtOwnerFName.TabIndex = 2
        Me.txtOwnerFName.Tag = "*First Name"
        '
        'lblLName
        '
        Me.lblLName.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLName.Location = New System.Drawing.Point(6, 55)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(84, 18)
        Me.lblLName.TabIndex = 3
        Me.lblLName.Text = "LAST NAME : "
        Me.lblLName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOwnerLName
        '
        Me.txtOwnerLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOwnerLName.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOwnerLName.Location = New System.Drawing.Point(96, 54)
        Me.txtOwnerLName.MaxLength = 50
        Me.txtOwnerLName.Name = "txtOwnerLName"
        Me.txtOwnerLName.Size = New System.Drawing.Size(222, 21)
        Me.txtOwnerLName.TabIndex = 1
        Me.txtOwnerLName.Tag = "*Last Name"
        '
        'lblOwnerID
        '
        Me.lblOwnerID.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOwnerID.Location = New System.Drawing.Point(47, 28)
        Me.lblOwnerID.Name = "lblOwnerID"
        Me.lblOwnerID.Size = New System.Drawing.Size(43, 18)
        Me.lblOwnerID.TabIndex = 1
        Me.lblOwnerID.Text = "ID : "
        Me.lblOwnerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOwnerID
        '
        Me.txtOwnerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOwnerID.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOwnerID.Location = New System.Drawing.Point(96, 27)
        Me.txtOwnerID.MaxLength = 10
        Me.txtOwnerID.Name = "txtOwnerID"
        Me.txtOwnerID.ReadOnly = True
        Me.txtOwnerID.Size = New System.Drawing.Size(100, 21)
        Me.txtOwnerID.TabIndex = 0
        Me.txtOwnerID.Text = "- - -"
        Me.txtOwnerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'datInformation
        '
        Me.datInformation.AllowUserToAddRows = False
        Me.datInformation.AllowUserToDeleteRows = False
        Me.datInformation.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datInformation.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datInformation.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datInformation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colOwnerID, Me.colOwnerName, Me.colPetName, Me.colSelect})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datInformation.DefaultCellStyle = DataGridViewCellStyle3
        Me.datInformation.Location = New System.Drawing.Point(17, 42)
        Me.datInformation.MultiSelect = False
        Me.datInformation.Name = "datInformation"
        Me.datInformation.ReadOnly = True
        Me.datInformation.RowHeadersVisible = False
        Me.datInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datInformation.Size = New System.Drawing.Size(451, 414)
        Me.datInformation.TabIndex = 1
        '
        'colOwnerID
        '
        Me.colOwnerID.HeaderText = "Owner ID"
        Me.colOwnerID.Name = "colOwnerID"
        Me.colOwnerID.ReadOnly = True
        Me.colOwnerID.Width = 109
        '
        'colOwnerName
        '
        Me.colOwnerName.HeaderText = "Owner Name"
        Me.colOwnerName.Name = "colOwnerName"
        Me.colOwnerName.ReadOnly = True
        Me.colOwnerName.Width = 109
        '
        'colPetName
        '
        Me.colPetName.HeaderText = "Pet Name"
        Me.colPetName.Name = "colPetName"
        Me.colPetName.ReadOnly = True
        Me.colPetName.Width = 109
        '
        'colSelect
        '
        Me.colSelect.FillWeight = 40.0!
        Me.colSelect.HeaderText = ""
        Me.colSelect.Name = "colSelect"
        Me.colSelect.ReadOnly = True
        Me.colSelect.Width = 44
        '
        'frmRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(819, 553)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRecords"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Records"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.grpPetInfo.ResumeLayout(False)
        Me.grpPetInfo.PerformLayout()
        CType(Me.picPet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOwnerInfo.ResumeLayout(False)
        Me.grpOwnerInfo.PerformLayout()
        CType(Me.datInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents grpOwnerInfo As System.Windows.Forms.GroupBox
    Friend WithEvents datInformation As System.Windows.Forms.DataGridView
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents grpPetInfo As System.Windows.Forms.GroupBox
    Friend WithEvents optFemale As System.Windows.Forms.RadioButton
    Friend WithEvents optMale As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblPetAge As System.Windows.Forms.Label
    Friend WithEvents lblPetColor As System.Windows.Forms.Label
    Friend WithEvents txtPetColor As System.Windows.Forms.TextBox
    Friend WithEvents lblBreed As System.Windows.Forms.Label
    Friend WithEvents txtPetBreed As System.Windows.Forms.TextBox
    Friend WithEvents lblpetName As System.Windows.Forms.Label
    Friend WithEvents txtPetName As System.Windows.Forms.TextBox
    Friend WithEvents lblPetID As System.Windows.Forms.Label
    Friend WithEvents txtPetID As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtOwnerAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblContact As System.Windows.Forms.Label
    Friend WithEvents txtOwnerContactNo As System.Windows.Forms.TextBox
    Friend WithEvents lblFName As System.Windows.Forms.Label
    Friend WithEvents txtOwnerFName As System.Windows.Forms.TextBox
    Friend WithEvents lblLName As System.Windows.Forms.Label
    Friend WithEvents txtOwnerLName As System.Windows.Forms.TextBox
    Friend WithEvents lblOwnerID As System.Windows.Forms.Label
    Friend WithEvents txtOwnerID As System.Windows.Forms.TextBox
    Friend WithEvents colOwnerID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOwnerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPetName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSelect As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnNewRecord As System.Windows.Forms.Button
    Friend WithEvents txtPetAge As System.Windows.Forms.TextBox
    Friend WithEvents chkisDeceased As System.Windows.Forms.CheckBox
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents lblBirthday As Label
    Friend WithEvents chkBirthday As CheckBox
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents picPet As System.Windows.Forms.PictureBox
    Friend WithEvents txtProfilePath As System.Windows.Forms.TextBox
End Class
