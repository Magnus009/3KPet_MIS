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
        Me.pnlPetInfo = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Purple
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(25, 538)
        Me.pnlHeader.TabIndex = 0
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.Location = New System.Drawing.Point(54, 54)
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
        Me.txtCustomer.Location = New System.Drawing.Point(168, 50)
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
        Me.txtOwnerID.Location = New System.Drawing.Point(168, 20)
        Me.txtOwnerID.Name = "txtOwnerID"
        Me.txtOwnerID.ReadOnly = True
        Me.txtOwnerID.Size = New System.Drawing.Size(239, 22)
        Me.txtOwnerID.TabIndex = 1
        '
        'lblCustomerCD
        '
        Me.lblCustomerCD.AutoSize = True
        Me.lblCustomerCD.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerCD.Location = New System.Drawing.Point(92, 24)
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
        Me.btnView.Location = New System.Drawing.Point(377, 50)
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
        'pnlPetInfo
        '
        Me.pnlPetInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPetInfo.Location = New System.Drawing.Point(39, 90)
        Me.pnlPetInfo.Name = "pnlPetInfo"
        Me.pnlPetInfo.Size = New System.Drawing.Size(726, 436)
        Me.pnlPetInfo.TabIndex = 8
        '
        'frmScheduleInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(780, 538)
        Me.Controls.Add(Me.pnlPetInfo)
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
    Friend WithEvents pnlPetInfo As System.Windows.Forms.Panel
End Class
