<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfoDialog
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
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnAddPet = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.Purple
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Location = New System.Drawing.Point(104, 57)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(174, 46)
        Me.btnView.TabIndex = 0
        Me.btnView.Text = "VIEW"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnAddPet
        '
        Me.btnAddPet.BackColor = System.Drawing.Color.Purple
        Me.btnAddPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPet.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPet.ForeColor = System.Drawing.Color.White
        Me.btnAddPet.Location = New System.Drawing.Point(104, 109)
        Me.btnAddPet.Name = "btnAddPet"
        Me.btnAddPet.Size = New System.Drawing.Size(174, 46)
        Me.btnAddPet.TabIndex = 1
        Me.btnAddPet.Text = "ADD PET"
        Me.btnAddPet.UseVisualStyleBackColor = False
        '
        'frmInfoDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(389, 209)
        Me.Controls.Add(Me.btnAddPet)
        Me.Controls.Add(Me.btnView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInfoDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnAddPet As System.Windows.Forms.Button
End Class
