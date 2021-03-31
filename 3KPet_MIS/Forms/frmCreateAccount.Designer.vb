<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreateAccount))
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.lblDeact = New System.Windows.Forms.Label()
        Me.btnDeactivate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblUserInfo = New System.Windows.Forms.Label()
        Me.grpUserInfo = New System.Windows.Forms.GroupBox()
        Me.cboLevel = New System.Windows.Forms.ComboBox()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.picHideShowConfirmPassword = New System.Windows.Forms.PictureBox()
        Me.picHideShowPassword = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboQuestion_2 = New System.Windows.Forms.ComboBox()
        Me.cboQuestion_1 = New System.Windows.Forms.ComboBox()
        Me.lblQ2 = New System.Windows.Forms.Label()
        Me.lblQ1 = New System.Windows.Forms.Label()
        Me.lblA2 = New System.Windows.Forms.Label()
        Me.txtAnswer_2 = New System.Windows.Forms.TextBox()
        Me.lblA1 = New System.Windows.Forms.Label()
        Me.txtAnswer_1 = New System.Windows.Forms.TextBox()
        Me.lblCPassword = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblSecurityFrame = New System.Windows.Forms.Label()
        Me.lblMName = New System.Windows.Forms.Label()
        Me.txtMName = New System.Windows.Forms.TextBox()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.pnlContent.SuspendLayout()
        Me.grpUserInfo.SuspendLayout()
        CType(Me.picHideShowConfirmPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHideShowPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContent
        '
        Me.pnlContent.Controls.Add(Me.lblDeact)
        Me.pnlContent.Controls.Add(Me.btnDeactivate)
        Me.pnlContent.Controls.Add(Me.btnSave)
        Me.pnlContent.Controls.Add(Me.lblUserInfo)
        Me.pnlContent.Controls.Add(Me.grpUserInfo)
        Me.pnlContent.Controls.Add(Me.lblMName)
        Me.pnlContent.Controls.Add(Me.txtMName)
        Me.pnlContent.Controls.Add(Me.lblFName)
        Me.pnlContent.Controls.Add(Me.txtFName)
        Me.pnlContent.Controls.Add(Me.lblLName)
        Me.pnlContent.Controls.Add(Me.txtLName)
        Me.pnlContent.Controls.Add(Me.lblUserID)
        Me.pnlContent.Controls.Add(Me.txtUserID)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(25, 0)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(416, 499)
        Me.pnlContent.TabIndex = 7
        '
        'lblDeact
        '
        Me.lblDeact.AutoSize = True
        Me.lblDeact.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblDeact.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeact.ForeColor = System.Drawing.Color.Red
        Me.lblDeact.Location = New System.Drawing.Point(90, 9)
        Me.lblDeact.Name = "lblDeact"
        Me.lblDeact.Size = New System.Drawing.Size(226, 15)
        Me.lblDeact.TabIndex = 12
        Me.lblDeact.Text = "YOUR ACCOUNT HAS BEEN DEACTIVATED"
        Me.lblDeact.Visible = False
        '
        'btnDeactivate
        '
        Me.btnDeactivate.BackColor = System.Drawing.Color.Purple
        Me.btnDeactivate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDeactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeactivate.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeactivate.ForeColor = System.Drawing.Color.White
        Me.btnDeactivate.Location = New System.Drawing.Point(202, 458)
        Me.btnDeactivate.Name = "btnDeactivate"
        Me.btnDeactivate.Size = New System.Drawing.Size(98, 31)
        Me.btnDeactivate.TabIndex = 11
        Me.btnDeactivate.Text = "&DEACTIVATE"
        Me.btnDeactivate.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Purple
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(306, 458)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(98, 31)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "&SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblUserInfo
        '
        Me.lblUserInfo.AutoSize = True
        Me.lblUserInfo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserInfo.Location = New System.Drawing.Point(8, 32)
        Me.lblUserInfo.Name = "lblUserInfo"
        Me.lblUserInfo.Size = New System.Drawing.Size(116, 15)
        Me.lblUserInfo.TabIndex = 9
        Me.lblUserInfo.Text = "USER INFORMATION"
        Me.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpUserInfo
        '
        Me.grpUserInfo.Controls.Add(Me.cboLevel)
        Me.grpUserInfo.Controls.Add(Me.lblLevel)
        Me.grpUserInfo.Controls.Add(Me.picHideShowConfirmPassword)
        Me.grpUserInfo.Controls.Add(Me.picHideShowPassword)
        Me.grpUserInfo.Controls.Add(Me.Label1)
        Me.grpUserInfo.Controls.Add(Me.cboQuestion_2)
        Me.grpUserInfo.Controls.Add(Me.cboQuestion_1)
        Me.grpUserInfo.Controls.Add(Me.lblQ2)
        Me.grpUserInfo.Controls.Add(Me.lblQ1)
        Me.grpUserInfo.Controls.Add(Me.lblA2)
        Me.grpUserInfo.Controls.Add(Me.txtAnswer_2)
        Me.grpUserInfo.Controls.Add(Me.lblA1)
        Me.grpUserInfo.Controls.Add(Me.txtAnswer_1)
        Me.grpUserInfo.Controls.Add(Me.lblCPassword)
        Me.grpUserInfo.Controls.Add(Me.txtConfirmPassword)
        Me.grpUserInfo.Controls.Add(Me.lblPassword)
        Me.grpUserInfo.Controls.Add(Me.txtPassword)
        Me.grpUserInfo.Controls.Add(Me.lblUserName)
        Me.grpUserInfo.Controls.Add(Me.txtUserName)
        Me.grpUserInfo.Controls.Add(Me.lblSecurityFrame)
        Me.grpUserInfo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUserInfo.Location = New System.Drawing.Point(11, 161)
        Me.grpUserInfo.Name = "grpUserInfo"
        Me.grpUserInfo.Size = New System.Drawing.Size(393, 291)
        Me.grpUserInfo.TabIndex = 4
        Me.grpUserInfo.TabStop = False
        Me.grpUserInfo.Text = "ACCOUNT INFORMATION"
        '
        'cboLevel
        '
        Me.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLevel.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLevel.FormattingEnabled = True
        Me.cboLevel.Location = New System.Drawing.Point(132, 97)
        Me.cboLevel.Name = "cboLevel"
        Me.cboLevel.Size = New System.Drawing.Size(118, 21)
        Me.cboLevel.TabIndex = 3
        Me.cboLevel.Tag = "*User Level"
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.Location = New System.Drawing.Point(61, 101)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(65, 13)
        Me.lblLevel.TabIndex = 22
        Me.lblLevel.Text = "USER LEVEL : "
        '
        'picHideShowConfirmPassword
        '
        Me.picHideShowConfirmPassword.BackColor = System.Drawing.Color.White
        Me.picHideShowConfirmPassword.Image = Global._3KPet_MIS.My.Resources.Resources.show
        Me.picHideShowConfirmPassword.Location = New System.Drawing.Point(306, 73)
        Me.picHideShowConfirmPassword.Name = "picHideShowConfirmPassword"
        Me.picHideShowConfirmPassword.Size = New System.Drawing.Size(20, 17)
        Me.picHideShowConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHideShowConfirmPassword.TabIndex = 21
        Me.picHideShowConfirmPassword.TabStop = False
        '
        'picHideShowPassword
        '
        Me.picHideShowPassword.BackColor = System.Drawing.Color.White
        Me.picHideShowPassword.Image = Global._3KPet_MIS.My.Resources.Resources.show
        Me.picHideShowPassword.Location = New System.Drawing.Point(306, 47)
        Me.picHideShowPassword.Name = "picHideShowPassword"
        Me.picHideShowPassword.Size = New System.Drawing.Size(20, 17)
        Me.picHideShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHideShowPassword.TabIndex = 20
        Me.picHideShowPassword.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "SECURITY QUESTION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboQuestion_2
        '
        Me.cboQuestion_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQuestion_2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQuestion_2.FormattingEnabled = True
        Me.cboQuestion_2.Location = New System.Drawing.Point(109, 229)
        Me.cboQuestion_2.Name = "cboQuestion_2"
        Me.cboQuestion_2.Size = New System.Drawing.Size(262, 21)
        Me.cboQuestion_2.TabIndex = 6
        '
        'cboQuestion_1
        '
        Me.cboQuestion_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQuestion_1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQuestion_1.FormattingEnabled = True
        Me.cboQuestion_1.Location = New System.Drawing.Point(109, 170)
        Me.cboQuestion_1.Name = "cboQuestion_1"
        Me.cboQuestion_1.Size = New System.Drawing.Size(262, 21)
        Me.cboQuestion_1.TabIndex = 4
        '
        'lblQ2
        '
        Me.lblQ2.AutoSize = True
        Me.lblQ2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ2.Location = New System.Drawing.Point(35, 233)
        Me.lblQ2.Name = "lblQ2"
        Me.lblQ2.Size = New System.Drawing.Size(68, 13)
        Me.lblQ2.TabIndex = 13
        Me.lblQ2.Text = "QUESTION 2 : "
        '
        'lblQ1
        '
        Me.lblQ1.AutoSize = True
        Me.lblQ1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ1.Location = New System.Drawing.Point(35, 174)
        Me.lblQ1.Name = "lblQ1"
        Me.lblQ1.Size = New System.Drawing.Size(68, 13)
        Me.lblQ1.TabIndex = 12
        Me.lblQ1.Text = "QUESTION 1 : "
        '
        'lblA2
        '
        Me.lblA2.AutoSize = True
        Me.lblA2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA2.Location = New System.Drawing.Point(42, 258)
        Me.lblA2.Name = "lblA2"
        Me.lblA2.Size = New System.Drawing.Size(61, 13)
        Me.lblA2.TabIndex = 11
        Me.lblA2.Text = "ANSWER 2 : "
        '
        'txtAnswer_2
        '
        Me.txtAnswer_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnswer_2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer_2.Location = New System.Drawing.Point(109, 254)
        Me.txtAnswer_2.Name = "txtAnswer_2"
        Me.txtAnswer_2.Size = New System.Drawing.Size(262, 21)
        Me.txtAnswer_2.TabIndex = 7
        Me.txtAnswer_2.Tag = "*Answer 2"
        '
        'lblA1
        '
        Me.lblA1.AutoSize = True
        Me.lblA1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA1.Location = New System.Drawing.Point(42, 199)
        Me.lblA1.Name = "lblA1"
        Me.lblA1.Size = New System.Drawing.Size(61, 13)
        Me.lblA1.TabIndex = 9
        Me.lblA1.Text = "ANSWER 1 : "
        '
        'txtAnswer_1
        '
        Me.txtAnswer_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnswer_1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer_1.Location = New System.Drawing.Point(109, 195)
        Me.txtAnswer_1.Name = "txtAnswer_1"
        Me.txtAnswer_1.Size = New System.Drawing.Size(262, 21)
        Me.txtAnswer_1.TabIndex = 5
        Me.txtAnswer_1.Tag = "*Answer 1"
        '
        'lblCPassword
        '
        Me.lblCPassword.AutoSize = True
        Me.lblCPassword.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPassword.Location = New System.Drawing.Point(16, 75)
        Me.lblCPassword.Name = "lblCPassword"
        Me.lblCPassword.Size = New System.Drawing.Size(110, 13)
        Me.lblCPassword.TabIndex = 7
        Me.lblCPassword.Text = "CONFIRM PASSWORD : "
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(132, 71)
        Me.txtConfirmPassword.MaxLength = 20
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(197, 21)
        Me.txtConfirmPassword.TabIndex = 2
        Me.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(61, 49)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(65, 13)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "PASSWORD : "
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(132, 45)
        Me.txtPassword.MaxLength = 20
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(197, 21)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.Tag = "*Password"
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(60, 23)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(66, 13)
        Me.lblUserName.TabIndex = 3
        Me.lblUserName.Text = "USER NAME : "
        '
        'txtUserName
        '
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(132, 19)
        Me.txtUserName.MaxLength = 20
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(197, 21)
        Me.txtUserName.TabIndex = 0
        Me.txtUserName.Tag = "*User Name"
        Me.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSecurityFrame
        '
        Me.lblSecurityFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSecurityFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSecurityFrame.Location = New System.Drawing.Point(12, 143)
        Me.lblSecurityFrame.Name = "lblSecurityFrame"
        Me.lblSecurityFrame.Size = New System.Drawing.Size(371, 138)
        Me.lblSecurityFrame.TabIndex = 19
        '
        'lblMName
        '
        Me.lblMName.AutoSize = True
        Me.lblMName.Location = New System.Drawing.Point(20, 137)
        Me.lblMName.Name = "lblMName"
        Me.lblMName.Size = New System.Drawing.Size(81, 13)
        Me.lblMName.TabIndex = 7
        Me.lblMName.Text = "MIDDLE NAME  : "
        Me.lblMName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMName
        '
        Me.txtMName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMName.Location = New System.Drawing.Point(104, 133)
        Me.txtMName.MaxLength = 50
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(202, 21)
        Me.txtMName.TabIndex = 3
        Me.txtMName.Tag = "*Middle Name"
        Me.txtMName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Location = New System.Drawing.Point(34, 110)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(67, 13)
        Me.lblFName.TabIndex = 5
        Me.lblFName.Text = "FIRST NAME : "
        Me.lblFName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFName
        '
        Me.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFName.Location = New System.Drawing.Point(104, 106)
        Me.txtFName.MaxLength = 50
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(202, 21)
        Me.txtFName.TabIndex = 2
        Me.txtFName.Tag = "*First Name"
        Me.txtFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Location = New System.Drawing.Point(37, 83)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(64, 13)
        Me.lblLName.TabIndex = 3
        Me.lblLName.Text = "LAST NAME : "
        Me.lblLName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLName
        '
        Me.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLName.Location = New System.Drawing.Point(104, 79)
        Me.txtLName.MaxLength = 50
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(202, 21)
        Me.txtLName.TabIndex = 1
        Me.txtLName.Tag = "*Last Name"
        Me.txtLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Location = New System.Drawing.Point(52, 56)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(49, 13)
        Me.lblUserID.TabIndex = 1
        Me.lblUserID.Text = "USER ID : "
        Me.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUserID
        '
        Me.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserID.Location = New System.Drawing.Point(104, 52)
        Me.txtUserID.MaxLength = 10
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(100, 21)
        Me.txtUserID.TabIndex = 0
        Me.txtUserID.Text = "- - -"
        Me.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Purple
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(25, 499)
        Me.pnlHeader.TabIndex = 6
        '
        'frmCreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(441, 499)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCreateAccount"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration"
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.grpUserInfo.ResumeLayout(False)
        Me.grpUserInfo.PerformLayout()
        CType(Me.picHideShowConfirmPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHideShowPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents cboQuestion_2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboQuestion_1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblQ2 As System.Windows.Forms.Label
    Friend WithEvents lblQ1 As System.Windows.Forms.Label
    Friend WithEvents lblA2 As System.Windows.Forms.Label
    Friend WithEvents txtAnswer_2 As System.Windows.Forms.TextBox
    Friend WithEvents lblA1 As System.Windows.Forms.Label
    Friend WithEvents txtAnswer_1 As System.Windows.Forms.TextBox
    Friend WithEvents lblCPassword As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblMName As System.Windows.Forms.Label
    Friend WithEvents txtMName As System.Windows.Forms.TextBox
    Friend WithEvents lblFName As System.Windows.Forms.Label
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents lblLName As System.Windows.Forms.Label
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents grpUserInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lblUserInfo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSecurityFrame As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents picHideShowPassword As System.Windows.Forms.PictureBox
    Friend WithEvents picHideShowConfirmPassword As System.Windows.Forms.PictureBox
    Friend WithEvents cboLevel As System.Windows.Forms.ComboBox
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents btnDeactivate As System.Windows.Forms.Button
    Friend WithEvents lblDeact As System.Windows.Forms.Label
End Class
