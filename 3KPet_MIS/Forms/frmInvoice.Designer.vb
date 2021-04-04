<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoice))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grpInvoice = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalLabel = New System.Windows.Forms.Label()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblTotalProd = New System.Windows.Forms.Label()
        Me.lblProdLabel = New System.Windows.Forms.Label()
        Me.lblServiceAmount = New System.Windows.Forms.Label()
        Me.lblServiceLabel = New System.Windows.Forms.Label()
        Me.lblVisitDate = New System.Windows.Forms.Label()
        Me.lblDateLabel = New System.Windows.Forms.Label()
        Me.lblTransID = New System.Windows.Forms.Label()
        Me.lblIDLabel = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpInvoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(30, 263)
        Me.Panel1.TabIndex = 0
        '
        'grpInvoice
        '
        Me.grpInvoice.Controls.Add(Me.lblTotal)
        Me.grpInvoice.Controls.Add(Me.lblTotalLabel)
        Me.grpInvoice.Controls.Add(Me.lblLine)
        Me.grpInvoice.Controls.Add(Me.txtDiscount)
        Me.grpInvoice.Controls.Add(Me.lblDiscount)
        Me.grpInvoice.Controls.Add(Me.lblTotalProd)
        Me.grpInvoice.Controls.Add(Me.lblProdLabel)
        Me.grpInvoice.Controls.Add(Me.lblServiceAmount)
        Me.grpInvoice.Controls.Add(Me.lblServiceLabel)
        Me.grpInvoice.Controls.Add(Me.lblVisitDate)
        Me.grpInvoice.Controls.Add(Me.lblDateLabel)
        Me.grpInvoice.Controls.Add(Me.lblTransID)
        Me.grpInvoice.Controls.Add(Me.lblIDLabel)
        Me.grpInvoice.Location = New System.Drawing.Point(36, 12)
        Me.grpInvoice.Name = "grpInvoice"
        Me.grpInvoice.Size = New System.Drawing.Size(292, 196)
        Me.grpInvoice.TabIndex = 1
        Me.grpInvoice.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(139, 161)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 14)
        Me.lblTotal.TabIndex = 12
        Me.lblTotal.Text = "00.00"
        '
        'lblTotalLabel
        '
        Me.lblTotalLabel.AutoSize = True
        Me.lblTotalLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLabel.Location = New System.Drawing.Point(29, 161)
        Me.lblTotalLabel.Name = "lblTotalLabel"
        Me.lblTotalLabel.Size = New System.Drawing.Size(96, 20)
        Me.lblTotalLabel.TabIndex = 11
        Me.lblTotalLabel.Text = "TOTAL  AMOUNT:"
        Me.lblTotalLabel.UseCompatibleTextRendering = True
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine.Location = New System.Drawing.Point(13, 140)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(271, 14)
        Me.lblLine.TabIndex = 10
        Me.lblLine.Text = "____________________________________________"
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(142, 117)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(100, 22)
        Me.txtDiscount.TabIndex = 9
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(6, 120)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(119, 20)
        Me.lblDiscount.TabIndex = 8
        Me.lblDiscount.Text = "DISCOUNT AMOUNT  :"
        Me.lblDiscount.UseCompatibleTextRendering = True
        '
        'lblTotalProd
        '
        Me.lblTotalProd.AutoSize = True
        Me.lblTotalProd.Location = New System.Drawing.Point(139, 98)
        Me.lblTotalProd.Name = "lblTotalProd"
        Me.lblTotalProd.Size = New System.Drawing.Size(34, 14)
        Me.lblTotalProd.TabIndex = 7
        Me.lblTotalProd.Text = "00.00"
        '
        'lblProdLabel
        '
        Me.lblProdLabel.AutoSize = True
        Me.lblProdLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdLabel.Location = New System.Drawing.Point(22, 98)
        Me.lblProdLabel.Name = "lblProdLabel"
        Me.lblProdLabel.Size = New System.Drawing.Size(103, 20)
        Me.lblProdLabel.TabIndex = 6
        Me.lblProdLabel.Text = "PRODUCTS TOTAL :"
        Me.lblProdLabel.UseCompatibleTextRendering = True
        '
        'lblServiceAmount
        '
        Me.lblServiceAmount.AutoSize = True
        Me.lblServiceAmount.Location = New System.Drawing.Point(139, 74)
        Me.lblServiceAmount.Name = "lblServiceAmount"
        Me.lblServiceAmount.Size = New System.Drawing.Size(34, 14)
        Me.lblServiceAmount.TabIndex = 5
        Me.lblServiceAmount.Text = "00.00"
        '
        'lblServiceLabel
        '
        Me.lblServiceLabel.AutoSize = True
        Me.lblServiceLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceLabel.Location = New System.Drawing.Point(30, 74)
        Me.lblServiceLabel.Name = "lblServiceLabel"
        Me.lblServiceLabel.Size = New System.Drawing.Size(95, 20)
        Me.lblServiceLabel.TabIndex = 4
        Me.lblServiceLabel.Text = "TREATMENT FEE :"
        Me.lblServiceLabel.UseCompatibleTextRendering = True
        '
        'lblVisitDate
        '
        Me.lblVisitDate.AutoSize = True
        Me.lblVisitDate.Location = New System.Drawing.Point(139, 27)
        Me.lblVisitDate.Name = "lblVisitDate"
        Me.lblVisitDate.Size = New System.Drawing.Size(76, 14)
        Me.lblVisitDate.TabIndex = 3
        Me.lblVisitDate.Text = "YYYY/MM/DD"
        '
        'lblDateLabel
        '
        Me.lblDateLabel.AutoSize = True
        Me.lblDateLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateLabel.Location = New System.Drawing.Point(58, 27)
        Me.lblDateLabel.Name = "lblDateLabel"
        Me.lblDateLabel.Size = New System.Drawing.Size(67, 14)
        Me.lblDateLabel.TabIndex = 2
        Me.lblDateLabel.Text = "VISIT DATE :"
        '
        'lblTransID
        '
        Me.lblTransID.AutoSize = True
        Me.lblTransID.Location = New System.Drawing.Point(139, 51)
        Me.lblTransID.Name = "lblTransID"
        Me.lblTransID.Size = New System.Drawing.Size(95, 14)
        Me.lblTransID.TabIndex = 1
        Me.lblTransID.Text = "TRANSACTION ID"
        '
        'lblIDLabel
        '
        Me.lblIDLabel.AutoSize = True
        Me.lblIDLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDLabel.Location = New System.Drawing.Point(64, 51)
        Me.lblIDLabel.Name = "lblIDLabel"
        Me.lblIDLabel.Size = New System.Drawing.Size(61, 14)
        Me.lblIDLabel.TabIndex = 0
        Me.lblIDLabel.Text = "TRANS ID :"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Purple
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(154, 214)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(82, 39)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(242, 214)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(82, 39)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(336, 263)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpInvoice)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice"
        Me.grpInvoice.ResumeLayout(False)
        Me.grpInvoice.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents grpInvoice As GroupBox
    Friend WithEvents lblIDLabel As Label
    Friend WithEvents lblTransID As Label
    Friend WithEvents lblDateLabel As Label
    Friend WithEvents lblVisitDate As Label
    Friend WithEvents lblServiceAmount As Label
    Friend WithEvents lblServiceLabel As Label
    Friend WithEvents lblTotalProd As Label
    Friend WithEvents lblProdLabel As Label
    Friend WithEvents lblLine As Label
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalLabel As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
