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
        Me.txtOwnerID = New System.Windows.Forms.TextBox()
        Me.lblCustomerCD = New System.Windows.Forms.Label()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.btnAddPet = New System.Windows.Forms.Button()
        Me.pnlPetInfo = New System.Windows.Forms.Panel()
        Me.txtTransactionID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.lblCustomer.Location = New System.Drawing.Point(52, 84)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(108, 15)
        Me.lblCustomer.TabIndex = 3
        Me.lblCustomer.Text = "CUSTOMER NAME :"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(435, 24)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(61, 15)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "ADDRESS :"
        '
        'txtCustomer
        '
        Me.txtCustomer.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomer.Location = New System.Drawing.Point(166, 80)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.ReadOnly = True
        Me.txtCustomer.Size = New System.Drawing.Size(209, 22)
        Me.txtCustomer.TabIndex = 2
        Me.txtCustomer.Tag = "*Customer"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(502, 20)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(239, 22)
        Me.txtAddress.TabIndex = 4
        Me.txtAddress.Tag = "*Address"
        '
        'txtOwnerID
        '
        Me.txtOwnerID.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOwnerID.Location = New System.Drawing.Point(166, 50)
        Me.txtOwnerID.Name = "txtOwnerID"
        Me.txtOwnerID.ReadOnly = True
        Me.txtOwnerID.Size = New System.Drawing.Size(239, 22)
        Me.txtOwnerID.TabIndex = 1
        '
        'lblCustomerCD
        '
        Me.lblCustomerCD.AutoSize = True
        Me.lblCustomerCD.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerCD.Location = New System.Drawing.Point(90, 54)
        Me.lblCustomerCD.Name = "lblCustomerCD"
        Me.lblCustomerCD.Size = New System.Drawing.Size(70, 15)
        Me.lblCustomerCD.TabIndex = 7
        Me.lblCustomerCD.Text = "OWNER ID :"
        '
        'lblContactNo
        '
        Me.lblContactNo.AutoSize = True
        Me.lblContactNo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNo.Location = New System.Drawing.Point(413, 54)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(83, 15)
        Me.lblContactNo.TabIndex = 18
        Me.lblContactNo.Text = "CONTACT No. :"
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.Purple
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Location = New System.Drawing.Point(375, 80)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(31, 22)
        Me.btnView.TabIndex = 3
        Me.btnView.Text = "..."
        Me.btnView.UseVisualStyleBackColor = False
        '
        'txtContactNo
        '
        Me.txtContactNo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.Location = New System.Drawing.Point(502, 50)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.ReadOnly = True
        Me.txtContactNo.Size = New System.Drawing.Size(239, 22)
        Me.txtContactNo.TabIndex = 5
        Me.txtContactNo.Tag = "*Contact No"
        '
        'btnAddPet
        '
        Me.btnAddPet.BackColor = System.Drawing.Color.Purple
        Me.btnAddPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPet.ForeColor = System.Drawing.Color.White
        Me.btnAddPet.Location = New System.Drawing.Point(648, 75)
        Me.btnAddPet.Name = "btnAddPet"
        Me.btnAddPet.Size = New System.Drawing.Size(93, 33)
        Me.btnAddPet.TabIndex = 7
        Me.btnAddPet.Text = "ADD PET"
        Me.btnAddPet.UseVisualStyleBackColor = False
        '
        'pnlPetInfo
        '
        Me.pnlPetInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPetInfo.Location = New System.Drawing.Point(39, 117)
        Me.pnlPetInfo.Name = "pnlPetInfo"
        Me.pnlPetInfo.Size = New System.Drawing.Size(726, 436)
        Me.pnlPetInfo.TabIndex = 8
        '
        'txtTransactionID
        '
        Me.txtTransactionID.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionID.Location = New System.Drawing.Point(167, 20)
        Me.txtTransactionID.Name = "txtTransactionID"
        Me.txtTransactionID.ReadOnly = True
        Me.txtTransactionID.Size = New System.Drawing.Size(239, 22)
        Me.txtTransactionID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "TRANSACTION ID :"
        '
        'frmScheduleInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(780, 570)
        Me.Controls.Add(Me.txtTransactionID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlPetInfo)
        Me.Controls.Add(Me.btnAddPet)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.txtContactNo)
        Me.Controls.Add(Me.lblContactNo)
        Me.Controls.Add(Me.txtOwnerID)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtOwnerID As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerCD As System.Windows.Forms.Label
    Friend WithEvents lblContactNo As System.Windows.Forms.Label
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents txtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents btnAddPet As System.Windows.Forms.Button
    Friend WithEvents pnlPetInfo As System.Windows.Forms.Panel
    Friend WithEvents txtTransactionID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
