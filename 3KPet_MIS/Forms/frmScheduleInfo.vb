Public Class frmScheduleInfo
    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        Try

        Catch ex As Exception

        End Try
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnView.Click
        frmOwnerList.ShowDialog()
    End Sub

    Private Sub btnAddPet_Click(sender As Object, e As EventArgs) Handles btnAddPet.Click
        Call addTabPage()
    End Sub

    Private Sub addTabPage()
        'datHistory
        Dim datHistory As New DataGridView
        datHistory.AllowUserToAddRows = False
        datHistory.AllowUserToDeleteRows = False
        datHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        datHistory.Location = New System.Drawing.Point(6, 6)
        datHistory.Name = "datHistory"
        datHistory.ReadOnly = True
        datHistory.Size = New System.Drawing.Size(240, 424)
        datHistory.TabIndex = 0

        'lblVisitDate
        Dim lblVisitDate As New Label
        lblVisitDate.AutoSize = True
        lblVisitDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblVisitDate.Location = New System.Drawing.Point(33, 31)
        lblVisitDate.Name = "lblVisitDate"
        lblVisitDate.Size = New System.Drawing.Size(39, 15)
        lblVisitDate.TabIndex = 0
        lblVisitDate.Text = "DATE :"

        'dtpVisitDate
        Dim dtpVisitDate As New DateTimePicker
        dtpVisitDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        dtpVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        dtpVisitDate.Location = New System.Drawing.Point(74, 27)
        dtpVisitDate.Name = "dtpVisitDate"
        dtpVisitDate.Size = New System.Drawing.Size(106, 23)
        dtpVisitDate.TabIndex = 1

        'lblWT
        Dim lblWT As New Label
        lblWT.AutoSize = True
        lblWT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblWT.Location = New System.Drawing.Point(41, 60)
        lblWT.Name = "lblWT"
        lblWT.Size = New System.Drawing.Size(31, 15)
        lblWT.TabIndex = 2
        lblWT.Text = "WT :"

        'txtWT
        Dim txtWT As New TextBox
        txtWT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtWT.Location = New System.Drawing.Point(74, 55)
        txtWT.Name = "txtWT"
        txtWT.Size = New System.Drawing.Size(160, 23)
        txtWT.TabIndex = 3

        'txtTemp
        Dim txtTemp As New TextBox
        txtTemp.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtTemp.Location = New System.Drawing.Point(287, 55)
        txtTemp.Name = "txtTemp"
        txtTemp.Size = New System.Drawing.Size(160, 23)
        txtTemp.TabIndex = 5

        'lblTemp
        Dim lblTemp As New Label
        lblTemp.AutoSize = True
        lblTemp.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTemp.Location = New System.Drawing.Point(237, 60)
        lblTemp.Name = "lblTemp"
        lblTemp.Size = New System.Drawing.Size(41, 15)
        lblTemp.TabIndex = 4
        lblTemp.Text = "Temp :"

        'txtDX
        Dim txtDX As New TextBox
        txtDX.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtDX.Location = New System.Drawing.Point(74, 84)
        txtDX.Name = "txtDX"
        txtDX.Size = New System.Drawing.Size(373, 23)
        txtDX.TabIndex = 7

        'lblDX
        Dim lblDX As New Label
        lblDX.AutoSize = True
        lblDX.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDX.Location = New System.Drawing.Point(41, 89)
        lblDX.Name = "lblDX"
        lblDX.Size = New System.Drawing.Size(28, 15)
        lblDX.TabIndex = 6
        lblDX.Text = "DX :"

   
        'txtAmount
        Dim txtAmount As New TextBox
        txtAmount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtAmount.Location = New System.Drawing.Point(74, 171)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New System.Drawing.Size(160, 23)
        txtAmount.TabIndex = 13

        'lblAmount
        Dim lblAmount As New Label
        lblAmount.AutoSize = True
        lblAmount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblAmount.Location = New System.Drawing.Point(6, 174)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New System.Drawing.Size(62, 15)
        lblAmount.TabIndex = 12
        lblAmount.Text = "AMOUNT :"

        'dtpNextVisit
        Dim dtpNextVisit As New DateTimePicker
        dtpNextVisit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        dtpNextVisit.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        dtpNextVisit.Location = New System.Drawing.Point(312, 171)
        dtpNextVisit.Name = "dtpNextVisit"
        dtpNextVisit.Size = New System.Drawing.Size(135, 23)
        dtpNextVisit.TabIndex = 15

        'lblNextVist
        Dim lblNextVist As New Label
        lblNextVist.AutoSize = True
        lblNextVist.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblNextVist.Location = New System.Drawing.Point(246, 175)
        lblNextVist.Name = "lblNextVist"
        lblNextVist.Size = New System.Drawing.Size(65, 15)
        lblNextVist.TabIndex = 14
        lblNextVist.Text = "Next Visit :"

        'btnSave
        Dim btnSave As New Button
        btnSave.BackColor = System.Drawing.Color.Purple
        btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnSave.ForeColor = System.Drawing.Color.White
        btnSave.Location = New System.Drawing.Point(624, 382)
        btnSave.Name = "btnSave"
        btnSave.Size = New System.Drawing.Size(97, 36)
        btnSave.TabIndex = 4
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = False
        '
        'grpHistory
        Dim grpHistory As New GroupBox
        grpHistory.Controls.Add(dtpNextVisit)
        grpHistory.Controls.Add(lblNextVist)
        grpHistory.Controls.Add(txtAmount)
        grpHistory.Controls.Add(lblAmount)
        grpHistory.Controls.Add(txtDX)
        grpHistory.Controls.Add(lblDX)
        grpHistory.Controls.Add(txtTemp)
        grpHistory.Controls.Add(lblTemp)
        grpHistory.Controls.Add(txtWT)
        grpHistory.Controls.Add(lblWT)
        grpHistory.Controls.Add(dtpVisitDate)
        grpHistory.Controls.Add(lblVisitDate)
        grpHistory.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        grpHistory.Location = New System.Drawing.Point(252, 6)
        grpHistory.Name = "grpHistory"
        grpHistory.Size = New System.Drawing.Size(469, 205)
        grpHistory.TabIndex = 1
        grpHistory.TabStop = False
        grpHistory.Text = "VISIT INFORMATION"

        'chkVaccinations
        Dim chkVaccinations As New CheckedListBox
        chkVaccinations.BorderStyle = System.Windows.Forms.BorderStyle.None
        chkVaccinations.CheckOnClick = True
        chkVaccinations.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        chkVaccinations.FormattingEnabled = True
        chkVaccinations.Items.AddRange(New Object() {"P/D", "2 in 1", "9 in 1", "K/C", "R", "M"})
        chkVaccinations.Location = New System.Drawing.Point(23, 32)
        chkVaccinations.Name = "chkVaccinations"
        chkVaccinations.Size = New System.Drawing.Size(186, 144)
        chkVaccinations.TabIndex = 0

        'grpVaccinations
        Dim grpVaccinations As New GroupBox
        grpVaccinations.Controls.Add(chkVaccinations)
        grpVaccinations.Location = New System.Drawing.Point(252, 217)
        grpVaccinations.Name = "grpVaccinations"
        grpVaccinations.Size = New System.Drawing.Size(234, 213)
        grpVaccinations.TabIndex = 2
        grpVaccinations.TabStop = False
        grpVaccinations.Text = "VACCINATIONS"

        'chkTreatments
        Dim chkTreatments As New CheckedListBox
        chkTreatments.BorderStyle = System.Windows.Forms.BorderStyle.None
        chkTreatments.CheckOnClick = True
        chkTreatments.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        chkTreatments.FormattingEnabled = True
        chkTreatments.Items.AddRange(New Object() {"Deworm", "Bra", "Bela", "Bac", "Bay", "Pen", "Cer"})
        chkTreatments.Location = New System.Drawing.Point(21, 29)
        chkTreatments.Name = "chkTreatments"
        chkTreatments.Size = New System.Drawing.Size(186, 144)
        chkTreatments.TabIndex = 1


        'grpTreatment
        Dim grpTreatment As New GroupBox
        grpTreatment.Controls.Add(chkTreatments)
        grpTreatment.Location = New System.Drawing.Point(492, 220)
        grpTreatment.Name = "grpTreatment"
        grpTreatment.Size = New System.Drawing.Size(229, 213)
        grpTreatment.TabIndex = 3
        grpTreatment.TabStop = False
        grpTreatment.Text = "TREATMENTS"

        'tabPet
        Dim tabPet As New TabPage
        tabPet.Controls.Add(grpTreatment)
        tabPet.Controls.Add(grpVaccinations)
        tabPet.Controls.Add(grpHistory)
        tabPet.Controls.Add(datHistory)
        tabPet.Location = New System.Drawing.Point(4, 23)
        tabPet.Name = "tabPet"
        tabPet.Padding = New System.Windows.Forms.Padding(3)
        tabPet.Size = New System.Drawing.Size(727, 436)
        tabPet.TabIndex = 0
        tabPet.Text = "PET"
        tabPet.UseVisualStyleBackColor = True


        'tabPetInfo
        tabPetInfo.Controls.Add(tabPet)
    End Sub

    Private Sub frmScheduleInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabPetInfo.TabPages.Remove(tabPet)
    End Sub
End Class