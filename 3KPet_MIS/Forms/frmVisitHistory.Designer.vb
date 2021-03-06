<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisitHistory
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DataGridView()
        Me.lblDateVisit = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblDash = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dtpTo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.Controls.Add(Me.lblHeader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(819, 65)
        Me.Panel1.TabIndex = 0
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(22, 19)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(172, 33)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "VISIT HISTORY"
        '
        'dtpTo
        '
        Me.dtpTo.AllowUserToAddRows = False
        Me.dtpTo.AllowUserToDeleteRows = False
        Me.dtpTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtpTo.Location = New System.Drawing.Point(12, 132)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.ReadOnly = True
        Me.dtpTo.Size = New System.Drawing.Size(795, 386)
        Me.dtpTo.TabIndex = 1
        '
        'lblDateVisit
        '
        Me.lblDateVisit.AutoSize = True
        Me.lblDateVisit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblDateVisit.Location = New System.Drawing.Point(372, 93)
        Me.lblDateVisit.Name = "lblDateVisit"
        Me.lblDateVisit.Size = New System.Drawing.Size(69, 15)
        Me.lblDateVisit.TabIndex = 2
        Me.lblDateVisit.Text = "DATE VISIT :"
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(447, 89)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(106, 23)
        Me.dtpFrom.TabIndex = 3
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(25, 93)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(54, 15)
        Me.lblSearch.TabIndex = 4
        Me.lblSearch.Text = "SEARCH :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(85, 89)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(256, 23)
        Me.TextBox1.TabIndex = 5
        '
        'lblDash
        '
        Me.lblDash.AutoSize = True
        Me.lblDash.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblDash.Location = New System.Drawing.Point(559, 93)
        Me.lblDash.Name = "lblDash"
        Me.lblDash.Size = New System.Drawing.Size(11, 15)
        Me.lblDash.TabIndex = 6
        Me.lblDash.Text = "-"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(576, 89)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(106, 23)
        Me.DateTimePicker1.TabIndex = 7
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.Purple
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.ForeColor = System.Drawing.Color.White
        Me.btnFilter.Location = New System.Drawing.Point(688, 89)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(75, 23)
        Me.btnFilter.TabIndex = 8
        Me.btnFilter.Text = "FILTER"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'frmVisitHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(819, 530)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblDash)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.lblDateVisit)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVisitHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visit History"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtpTo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents dtpTo As System.Windows.Forms.DataGridView
    Friend WithEvents lblDateVisit As System.Windows.Forms.Label
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblDash As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnFilter As System.Windows.Forms.Button
End Class
