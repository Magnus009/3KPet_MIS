<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRestock))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblHead = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.grpProd = New System.Windows.Forms.GroupBox()
        Me.txtQTY = New System.Windows.Forms.TextBox()
        Me.lblQTY = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.btnRestock = New System.Windows.Forms.Button()
        Me.grpProd.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(31, 255)
        Me.Panel1.TabIndex = 0
        '
        'lblHead
        '
        Me.lblHead.AutoSize = True
        Me.lblHead.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead.Location = New System.Drawing.Point(56, 27)
        Me.lblHead.Name = "lblHead"
        Me.lblHead.Size = New System.Drawing.Size(152, 26)
        Me.lblHead.TabIndex = 1
        Me.lblHead.Text = "Restock Product"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(58, 53)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(191, 18)
        Me.lblHeader.TabIndex = 2
        Me.lblHeader.Text = "Please enter product quantity"
        '
        'grpProd
        '
        Me.grpProd.Controls.Add(Me.txtQTY)
        Me.grpProd.Controls.Add(Me.lblQTY)
        Me.grpProd.Controls.Add(Me.txtProductName)
        Me.grpProd.Controls.Add(Me.lblName)
        Me.grpProd.Controls.Add(Me.txtProductID)
        Me.grpProd.Controls.Add(Me.lblProductID)
        Me.grpProd.Location = New System.Drawing.Point(61, 84)
        Me.grpProd.Name = "grpProd"
        Me.grpProd.Size = New System.Drawing.Size(324, 122)
        Me.grpProd.TabIndex = 3
        Me.grpProd.TabStop = False
        '
        'txtQTY
        '
        Me.txtQTY.Location = New System.Drawing.Point(99, 81)
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(68, 22)
        Me.txtQTY.TabIndex = 5
        '
        'lblQTY
        '
        Me.lblQTY.AutoSize = True
        Me.lblQTY.Location = New System.Drawing.Point(42, 84)
        Me.lblQTY.Name = "lblQTY"
        Me.lblQTY.Size = New System.Drawing.Size(51, 14)
        Me.lblQTY.TabIndex = 4
        Me.lblQTY.Text = "STOCKS :"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(99, 53)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.ReadOnly = True
        Me.txtProductName.Size = New System.Drawing.Size(207, 22)
        Me.txtProductName.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(49, 56)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 14)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "NAME :"
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(99, 25)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.ReadOnly = True
        Me.txtProductID.Size = New System.Drawing.Size(147, 22)
        Me.txtProductID.TabIndex = 1
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Location = New System.Drawing.Point(16, 28)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(77, 14)
        Me.lblProductID.TabIndex = 0
        Me.lblProductID.Text = "PRODUCT ID :"
        '
        'btnRestock
        '
        Me.btnRestock.BackColor = System.Drawing.Color.Purple
        Me.btnRestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestock.ForeColor = System.Drawing.Color.White
        Me.btnRestock.Location = New System.Drawing.Point(293, 212)
        Me.btnRestock.Name = "btnRestock"
        Me.btnRestock.Size = New System.Drawing.Size(93, 32)
        Me.btnRestock.TabIndex = 4
        Me.btnRestock.Text = "RESTOCK"
        Me.btnRestock.UseVisualStyleBackColor = False
        '
        'frmRestock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(411, 255)
        Me.Controls.Add(Me.btnRestock)
        Me.Controls.Add(Me.grpProd)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lblHead)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRestock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restock Product"
        Me.grpProd.ResumeLayout(False)
        Me.grpProd.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblHead As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents grpProd As GroupBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents lblProductID As Label
    Friend WithEvents txtQTY As TextBox
    Friend WithEvents lblQTY As Label
    Friend WithEvents btnRestock As Button
End Class
