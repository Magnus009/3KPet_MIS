<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVaccine
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.chkisUpdate = New System.Windows.Forms.CheckBox()
        Me.datVaccine = New System.Windows.Forms.DataGridView()
        CType(Me.datVaccine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(24, 471)
        Me.Panel1.TabIndex = 0
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(37, 19)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(57, 13)
        Me.lblSearch.TabIndex = 11
        Me.lblSearch.Text = "SEARCH :"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(104, 16)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(232, 20)
        Me.txtSearch.TabIndex = 10
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Purple
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(261, 73)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 28)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(37, 45)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(300, 20)
        Me.txtName.TabIndex = 8
        '
        'chkisUpdate
        '
        Me.chkisUpdate.AutoSize = True
        Me.chkisUpdate.Location = New System.Drawing.Point(47, 78)
        Me.chkisUpdate.Name = "chkisUpdate"
        Me.chkisUpdate.Size = New System.Drawing.Size(70, 17)
        Me.chkisUpdate.TabIndex = 7
        Me.chkisUpdate.Text = "UPDATE"
        Me.chkisUpdate.UseVisualStyleBackColor = True
        '
        'datVaccine
        '
        Me.datVaccine.AllowUserToAddRows = False
        Me.datVaccine.AllowUserToDeleteRows = False
        Me.datVaccine.AllowUserToResizeColumns = False
        Me.datVaccine.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datVaccine.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datVaccine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datVaccine.DefaultCellStyle = DataGridViewCellStyle2
        Me.datVaccine.Location = New System.Drawing.Point(37, 104)
        Me.datVaccine.Name = "datVaccine"
        Me.datVaccine.ReadOnly = True
        Me.datVaccine.RowHeadersVisible = False
        Me.datVaccine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datVaccine.Size = New System.Drawing.Size(300, 354)
        Me.datVaccine.TabIndex = 6
        '
        'frmVaccine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(348, 471)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.chkisUpdate)
        Me.Controls.Add(Me.datVaccine)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmVaccine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmVaccine"
        CType(Me.datVaccine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents chkisUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents datVaccine As System.Windows.Forms.DataGridView
End Class
