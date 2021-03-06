<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForgetPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmForgetPassword))
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.picOP = New System.Windows.Forms.PictureBox()
        Me.lblOP = New System.Windows.Forms.Label()
        Me.txtOldPass = New System.Windows.Forms.TextBox()
        Me.picCNP = New System.Windows.Forms.PictureBox()
        Me.picNP = New System.Windows.Forms.PictureBox()
        Me.lblCNPassword = New System.Windows.Forms.Label()
        Me.txtConfirmNewPass = New System.Windows.Forms.TextBox()
        Me.lblNP = New System.Windows.Forms.Label()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.picChangePass = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblSecurityFrame = New System.Windows.Forms.Label()
        Me.txtAnswer_1 = New System.Windows.Forms.TextBox()
        Me.lblA1 = New System.Windows.Forms.Label()
        Me.txtAnswer_2 = New System.Windows.Forms.TextBox()
        Me.lblA2 = New System.Windows.Forms.Label()
        Me.lblQ1 = New System.Windows.Forms.Label()
        Me.lblQ2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.txtQuestion_2 = New System.Windows.Forms.TextBox()
        Me.txtQuestion_1 = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.datUserInfo = New System.Windows.Forms.DataGridView()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.pnlLeft.SuspendLayout()
        CType(Me.picOP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCNP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChangePass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRight.SuspendLayout()
        CType(Me.datUserInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.Purple
        Me.pnlLeft.Controls.Add(Me.btnConfirm)
        Me.pnlLeft.Controls.Add(Me.picOP)
        Me.pnlLeft.Controls.Add(Me.lblOP)
        Me.pnlLeft.Controls.Add(Me.txtOldPass)
        Me.pnlLeft.Controls.Add(Me.picCNP)
        Me.pnlLeft.Controls.Add(Me.picNP)
        Me.pnlLeft.Controls.Add(Me.lblCNPassword)
        Me.pnlLeft.Controls.Add(Me.txtConfirmNewPass)
        Me.pnlLeft.Controls.Add(Me.lblNP)
        Me.pnlLeft.Controls.Add(Me.txtNewPass)
        Me.pnlLeft.Controls.Add(Me.picChangePass)
        Me.pnlLeft.Controls.Add(Me.btnBack)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(438, 316)
        Me.pnlLeft.TabIndex = 2
        '
        'btnConfirm
        '
        Me.btnConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirm.BackColor = System.Drawing.Color.Green
        Me.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(257, 241)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(120, 31)
        Me.btnConfirm.TabIndex = 4
        Me.btnConfirm.Text = "&CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'picOP
        '
        Me.picOP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picOP.BackColor = System.Drawing.Color.White
        Me.picOP.Image = Global._3KPet_MIS.My.Resources.Resources.show
        Me.picOP.Location = New System.Drawing.Point(349, 165)
        Me.picOP.Name = "picOP"
        Me.picOP.Size = New System.Drawing.Size(20, 17)
        Me.picOP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOP.TabIndex = 44
        Me.picOP.TabStop = False
        Me.picOP.Visible = False
        '
        'lblOP
        '
        Me.lblOP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOP.AutoSize = True
        Me.lblOP.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOP.ForeColor = System.Drawing.Color.White
        Me.lblOP.Location = New System.Drawing.Point(88, 167)
        Me.lblOP.Name = "lblOP"
        Me.lblOP.Size = New System.Drawing.Size(86, 13)
        Me.lblOP.TabIndex = 43
        Me.lblOP.Text = "OLD PASSWORD : "
        Me.lblOP.Visible = False
        '
        'txtOldPass
        '
        Me.txtOldPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOldPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOldPass.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldPass.Location = New System.Drawing.Point(180, 163)
        Me.txtOldPass.MaxLength = 20
        Me.txtOldPass.Name = "txtOldPass"
        Me.txtOldPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtOldPass.Size = New System.Drawing.Size(197, 21)
        Me.txtOldPass.TabIndex = 1
        Me.txtOldPass.Tag = "*Old Password"
        Me.txtOldPass.Text = "- - -"
        Me.txtOldPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtOldPass.Visible = False
        '
        'picCNP
        '
        Me.picCNP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picCNP.BackColor = System.Drawing.Color.White
        Me.picCNP.Image = Global._3KPet_MIS.My.Resources.Resources.show
        Me.picCNP.Location = New System.Drawing.Point(349, 217)
        Me.picCNP.Name = "picCNP"
        Me.picCNP.Size = New System.Drawing.Size(20, 17)
        Me.picCNP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCNP.TabIndex = 41
        Me.picCNP.TabStop = False
        '
        'picNP
        '
        Me.picNP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picNP.BackColor = System.Drawing.Color.White
        Me.picNP.Image = Global._3KPet_MIS.My.Resources.Resources.show
        Me.picNP.Location = New System.Drawing.Point(349, 191)
        Me.picNP.Name = "picNP"
        Me.picNP.Size = New System.Drawing.Size(20, 17)
        Me.picNP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picNP.TabIndex = 40
        Me.picNP.TabStop = False
        '
        'lblCNPassword
        '
        Me.lblCNPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCNPassword.AutoSize = True
        Me.lblCNPassword.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCNPassword.ForeColor = System.Drawing.Color.White
        Me.lblCNPassword.Location = New System.Drawing.Point(40, 219)
        Me.lblCNPassword.Name = "lblCNPassword"
        Me.lblCNPassword.Size = New System.Drawing.Size(134, 13)
        Me.lblCNPassword.TabIndex = 39
        Me.lblCNPassword.Text = "CONFIRM NEW PASSWORD : "
        '
        'txtConfirmNewPass
        '
        Me.txtConfirmNewPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConfirmNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmNewPass.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmNewPass.Location = New System.Drawing.Point(180, 215)
        Me.txtConfirmNewPass.MaxLength = 20
        Me.txtConfirmNewPass.Name = "txtConfirmNewPass"
        Me.txtConfirmNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtConfirmNewPass.Size = New System.Drawing.Size(197, 21)
        Me.txtConfirmNewPass.TabIndex = 3
        Me.txtConfirmNewPass.Tag = "*Confirm New Password"
        Me.txtConfirmNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNP
        '
        Me.lblNP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNP.AutoSize = True
        Me.lblNP.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNP.ForeColor = System.Drawing.Color.White
        Me.lblNP.Location = New System.Drawing.Point(85, 193)
        Me.lblNP.Name = "lblNP"
        Me.lblNP.Size = New System.Drawing.Size(89, 13)
        Me.lblNP.TabIndex = 38
        Me.lblNP.Text = "NEW PASSWORD : "
        '
        'txtNewPass
        '
        Me.txtNewPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewPass.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPass.Location = New System.Drawing.Point(180, 189)
        Me.txtNewPass.MaxLength = 20
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtNewPass.Size = New System.Drawing.Size(197, 21)
        Me.txtNewPass.TabIndex = 2
        Me.txtNewPass.Tag = "*New Password"
        Me.txtNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picChangePass
        '
        Me.picChangePass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picChangePass.Image = CType(resources.GetObject("picChangePass.Image"), System.Drawing.Image)
        Me.picChangePass.Location = New System.Drawing.Point(156, 20)
        Me.picChangePass.Name = "picChangePass"
        Me.picChangePass.Size = New System.Drawing.Size(135, 130)
        Me.picChangePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChangePass.TabIndex = 35
        Me.picChangePass.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Location = New System.Drawing.Point(43, 275)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(98, 31)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "&BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblSecurityFrame
        '
        Me.lblSecurityFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSecurityFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSecurityFrame.Location = New System.Drawing.Point(30, 144)
        Me.lblSecurityFrame.Name = "lblSecurityFrame"
        Me.lblSecurityFrame.Size = New System.Drawing.Size(371, 128)
        Me.lblSecurityFrame.TabIndex = 29
        '
        'txtAnswer_1
        '
        Me.txtAnswer_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnswer_1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer_1.Location = New System.Drawing.Point(120, 186)
        Me.txtAnswer_1.Name = "txtAnswer_1"
        Me.txtAnswer_1.Size = New System.Drawing.Size(262, 21)
        Me.txtAnswer_1.TabIndex = 5
        Me.txtAnswer_1.Tag = "*Answer 1"
        '
        'lblA1
        '
        Me.lblA1.AutoSize = True
        Me.lblA1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA1.Location = New System.Drawing.Point(53, 190)
        Me.lblA1.Name = "lblA1"
        Me.lblA1.Size = New System.Drawing.Size(61, 13)
        Me.lblA1.TabIndex = 24
        Me.lblA1.Text = "ANSWER 1 : "
        '
        'txtAnswer_2
        '
        Me.txtAnswer_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnswer_2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer_2.Location = New System.Drawing.Point(120, 245)
        Me.txtAnswer_2.Name = "txtAnswer_2"
        Me.txtAnswer_2.Size = New System.Drawing.Size(262, 21)
        Me.txtAnswer_2.TabIndex = 7
        Me.txtAnswer_2.Tag = "*Answer 2"
        '
        'lblA2
        '
        Me.lblA2.AutoSize = True
        Me.lblA2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA2.Location = New System.Drawing.Point(53, 249)
        Me.lblA2.Name = "lblA2"
        Me.lblA2.Size = New System.Drawing.Size(61, 13)
        Me.lblA2.TabIndex = 25
        Me.lblA2.Text = "ANSWER 2 : "
        '
        'lblQ1
        '
        Me.lblQ1.AutoSize = True
        Me.lblQ1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ1.Location = New System.Drawing.Point(46, 165)
        Me.lblQ1.Name = "lblQ1"
        Me.lblQ1.Size = New System.Drawing.Size(68, 13)
        Me.lblQ1.TabIndex = 26
        Me.lblQ1.Text = "QUESTION 1 : "
        '
        'lblQ2
        '
        Me.lblQ2.AutoSize = True
        Me.lblQ2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ2.Location = New System.Drawing.Point(46, 224)
        Me.lblQ2.Name = "lblQ2"
        Me.lblQ2.Size = New System.Drawing.Size(68, 13)
        Me.lblQ2.TabIndex = 27
        Me.lblQ2.Text = "QUESTION 2 : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 15)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "SECURITY QUESTION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlRight
        '
        Me.pnlRight.Controls.Add(Me.txtQuestion_2)
        Me.pnlRight.Controls.Add(Me.txtQuestion_1)
        Me.pnlRight.Controls.Add(Me.btnSearch)
        Me.pnlRight.Controls.Add(Me.btnSubmit)
        Me.pnlRight.Controls.Add(Me.datUserInfo)
        Me.pnlRight.Controls.Add(Me.lblSearch)
        Me.pnlRight.Controls.Add(Me.txtSearch)
        Me.pnlRight.Controls.Add(Me.Label1)
        Me.pnlRight.Controls.Add(Me.lblQ2)
        Me.pnlRight.Controls.Add(Me.lblQ1)
        Me.pnlRight.Controls.Add(Me.lblA2)
        Me.pnlRight.Controls.Add(Me.txtAnswer_2)
        Me.pnlRight.Controls.Add(Me.lblA1)
        Me.pnlRight.Controls.Add(Me.txtAnswer_1)
        Me.pnlRight.Controls.Add(Me.lblSecurityFrame)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRight.Location = New System.Drawing.Point(438, 0)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(12, 316)
        Me.pnlRight.TabIndex = 1
        '
        'txtQuestion_2
        '
        Me.txtQuestion_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuestion_2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion_2.Location = New System.Drawing.Point(120, 220)
        Me.txtQuestion_2.Name = "txtQuestion_2"
        Me.txtQuestion_2.ReadOnly = True
        Me.txtQuestion_2.Size = New System.Drawing.Size(262, 21)
        Me.txtQuestion_2.TabIndex = 6
        '
        'txtQuestion_1
        '
        Me.txtQuestion_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuestion_1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion_1.Location = New System.Drawing.Point(120, 161)
        Me.txtQuestion_1.Name = "txtQuestion_1"
        Me.txtQuestion_1.ReadOnly = True
        Me.txtQuestion_1.Size = New System.Drawing.Size(262, 21)
        Me.txtQuestion_1.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Purple
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(303, 20)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(79, 24)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Green
        Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(316, 275)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(98, 31)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "&SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'datUserInfo
        '
        Me.datUserInfo.AllowUserToAddRows = False
        Me.datUserInfo.AllowUserToDeleteRows = False
        Me.datUserInfo.AllowUserToResizeRows = False
        Me.datUserInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datUserInfo.Location = New System.Drawing.Point(20, 49)
        Me.datUserInfo.MultiSelect = False
        Me.datUserInfo.Name = "datUserInfo"
        Me.datUserInfo.ReadOnly = True
        Me.datUserInfo.RowHeadersVisible = False
        Me.datUserInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datUserInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datUserInfo.Size = New System.Drawing.Size(394, 85)
        Me.datUserInfo.TabIndex = 3
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(47, 26)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(47, 13)
        Me.lblSearch.TabIndex = 31
        Me.lblSearch.Text = "SEARCH: "
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(100, 22)
        Me.txtSearch.MaxLength = 20
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(197, 21)
        Me.txtSearch.TabIndex = 1
        '
        'frmForgetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(450, 316)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlLeft)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmForgetPassword"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forgot Password"
        Me.TopMost = True
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        CType(Me.picOP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCNP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChangePass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        CType(Me.datUserInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents lblSecurityFrame As System.Windows.Forms.Label
    Friend WithEvents txtAnswer_1 As System.Windows.Forms.TextBox
    Friend WithEvents lblA1 As System.Windows.Forms.Label
    Friend WithEvents txtAnswer_2 As System.Windows.Forms.TextBox
    Friend WithEvents lblA2 As System.Windows.Forms.Label
    Friend WithEvents lblQ1 As System.Windows.Forms.Label
    Friend WithEvents lblQ2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents datUserInfo As System.Windows.Forms.DataGridView
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txtQuestion_2 As System.Windows.Forms.TextBox
    Friend WithEvents txtQuestion_1 As System.Windows.Forms.TextBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents picChangePass As System.Windows.Forms.PictureBox
    Friend WithEvents picOP As System.Windows.Forms.PictureBox
    Friend WithEvents lblOP As System.Windows.Forms.Label
    Friend WithEvents txtOldPass As System.Windows.Forms.TextBox
    Friend WithEvents picCNP As System.Windows.Forms.PictureBox
    Friend WithEvents picNP As System.Windows.Forms.PictureBox
    Friend WithEvents lblCNPassword As System.Windows.Forms.Label
    Friend WithEvents txtConfirmNewPass As System.Windows.Forms.TextBox
    Friend WithEvents lblNP As System.Windows.Forms.Label
    Friend WithEvents txtNewPass As System.Windows.Forms.TextBox
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
End Class
