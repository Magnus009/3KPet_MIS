<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintProducts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintProducts))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.cboFilter = New System.Windows.Forms.ComboBox()
        Me.grp = New System.Windows.Forms.GroupBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.cboFil = New System.Windows.Forms.ComboBox()
        Me.lblFilterlabel = New System.Windows.Forms.Label()
        Me.dtpDay = New System.Windows.Forms.DateTimePicker()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.grp.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(20, 169)
        Me.Panel1.TabIndex = 0
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilter.Location = New System.Drawing.Point(30, 14)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(59, 14)
        Me.lblFilter.TabIndex = 1
        Me.lblFilter.Text = "PRINT BY :"
        '
        'cboFilter
        '
        Me.cboFilter.FormattingEnabled = True
        Me.cboFilter.Location = New System.Drawing.Point(95, 12)
        Me.cboFilter.Name = "cboFilter"
        Me.cboFilter.Size = New System.Drawing.Size(121, 21)
        Me.cboFilter.TabIndex = 2
        '
        'grp
        '
        Me.grp.Controls.Add(Me.txtYear)
        Me.grp.Controls.Add(Me.cboFil)
        Me.grp.Controls.Add(Me.lblFilterlabel)
        Me.grp.Controls.Add(Me.dtpDay)
        Me.grp.Location = New System.Drawing.Point(29, 36)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(261, 87)
        Me.grp.TabIndex = 3
        Me.grp.TabStop = False
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(96, 37)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(105, 21)
        Me.txtYear.TabIndex = 3
        Me.txtYear.Visible = False
        '
        'cboFil
        '
        Me.cboFil.FormattingEnabled = True
        Me.cboFil.Location = New System.Drawing.Point(96, 37)
        Me.cboFil.Name = "cboFil"
        Me.cboFil.Size = New System.Drawing.Size(105, 21)
        Me.cboFil.TabIndex = 2
        Me.cboFil.Visible = False
        '
        'lblFilterlabel
        '
        Me.lblFilterlabel.AutoSize = True
        Me.lblFilterlabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilterlabel.Location = New System.Drawing.Point(44, 41)
        Me.lblFilterlabel.Name = "lblFilterlabel"
        Me.lblFilterlabel.Size = New System.Drawing.Size(39, 14)
        Me.lblFilterlabel.TabIndex = 1
        Me.lblFilterlabel.Text = "DATE :"
        '
        'dtpDay
        '
        Me.dtpDay.Location = New System.Drawing.Point(96, 37)
        Me.dtpDay.Name = "dtpDay"
        Me.dtpDay.Size = New System.Drawing.Size(105, 21)
        Me.dtpDay.TabIndex = 0
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Purple
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(215, 132)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 32)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'frmPrintTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(302, 169)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.grp)
        Me.Controls.Add(Me.cboFilter)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrintTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRINT PRODUCTS"
        Me.grp.ResumeLayout(False)
        Me.grp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblFilter As System.Windows.Forms.Label
    Friend WithEvents cboFilter As System.Windows.Forms.ComboBox
    Friend WithEvents grp As System.Windows.Forms.GroupBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents cboFil As System.Windows.Forms.ComboBox
    Friend WithEvents lblFilterlabel As System.Windows.Forms.Label
    Friend WithEvents dtpDay As System.Windows.Forms.DateTimePicker
End Class
