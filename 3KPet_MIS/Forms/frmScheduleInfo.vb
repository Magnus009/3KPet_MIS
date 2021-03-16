Public Class frmScheduleInfo
    Dim tabName As String
    Dim dsTransactionHeader As New DataSet
    Dim dsTransactionDetails As New DataSet
    Dim dsTreatments As New DataSet
    Dim dsVaccinations As New DataSet

 
    Private Sub btnAddPet_Click(sender As Object, e As EventArgs) Handles btnAddPet.Click
        Call addTabPage()
    End Sub
    Public Sub getInfo()
        Try
            Dim dsPet As New DataSet

            sqlQuery = ""
            sqlQuery = "SELECT * FROM Pets" & vbCrLf
            sqlQuery += "WHERE OwnerID ='" + txtOwnerID.Text + "'" & vbCrLf

            dsPet = SQLPetMIS(sqlQuery)

            For Each row As DataRow In dsPet.Tables(0).Rows
                tabName = row.Item("Name")
                Call getTreatments()
                Call getVaccinations()
                Call getTransactions(row.Item("PetID"))
                Call addTabPage()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub getTransactions(strPetID As String)
        Try
            sqlQuery = ""
            sqlQuery += "SELECT * FROM TransactionHeader" & vbCrLf
            sqlQuery += "WHERE OwnerID ='" + txtOwnerID.Text + "'" & vbCrLf
            sqlQuery += "AND PetID ='" + strPetID + "'" & vbCrLf
            sqlQuery += "ORDER BY VisitDate DESC" & vbCrLf

            dsTransactionHeader = SQLPetMIS(sqlQuery)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub addTabPage()
        tabPetInfo.Show()
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
        datHistory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        datHistory.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        datHistory.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 9, FontStyle.Bold)
        datHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        datHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        datHistory.ColumnHeadersHeight = 35
        datHistory.DefaultCellStyle.Font = New Font("Calibri", 9, FontStyle.Regular)
        datHistory.AllowUserToResizeColumns = False
        datHistory.AllowUserToResizeRows = False
        datHistory.RowHeadersVisible = False

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
        txtAmount.Location = New System.Drawing.Point(74, 113)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New System.Drawing.Size(160, 23)
        txtAmount.TabIndex = 13
        '
        'lblAmount
        Dim lblAmount As New Label
        lblAmount.AutoSize = True
        lblAmount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblAmount.Location = New System.Drawing.Point(6, 116)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New System.Drawing.Size(62, 15)
        lblAmount.TabIndex = 12
        lblAmount.Text = "AMOUNT :"

        'dtpNextVisit
        Dim dtpNextVisit As New DateTimePicker
        dtpNextVisit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        dtpNextVisit.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        dtpNextVisit.Location = New System.Drawing.Point(312, 113)
        dtpNextVisit.Name = "dtpNextVisit"
        dtpNextVisit.Size = New System.Drawing.Size(135, 23)
        dtpNextVisit.TabIndex = 15
        '
        'lblNextVist
        Dim lblNextVist As New Label
        lblNextVist.AutoSize = True
        lblNextVist.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblNextVist.Location = New System.Drawing.Point(246, 117)
        lblNextVist.Name = "lblNextVist"
        lblNextVist.Size = New System.Drawing.Size(65, 15)
        lblNextVist.TabIndex = 14
        lblNextVist.Text = "Next Visit :"

        'btnAddRecord
        '
        Dim btnAddRecord As New Button
        btnAddRecord.BackColor = System.Drawing.Color.Purple
        btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnAddRecord.ForeColor = System.Drawing.Color.White
        btnAddRecord.Location = New System.Drawing.Point(524, 382)
        btnAddRecord.Name = "btnAddRecord"
        btnAddRecord.Size = New System.Drawing.Size(97, 36)
        btnAddRecord.TabIndex = 5
        btnAddRecord.Text = "ADD RECORD"
        btnAddRecord.UseVisualStyleBackColor = False
        AddHandler btnAddRecord.Click, AddressOf AddRecord

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
        grpHistory.Size = New System.Drawing.Size(469, 170)
        grpHistory.TabIndex = 1
        grpHistory.TabStop = False
        grpHistory.Text = "VISIT INFORMATION"

        'chkVaccinations
        Dim chkVaccinations As New CheckedListBox
        chkVaccinations.BorderStyle = System.Windows.Forms.BorderStyle.None
        chkVaccinations.CheckOnClick = True
        chkVaccinations.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        chkVaccinations.FormattingEnabled = True
        'chkVaccinations.Items.AddRange(New Object() {"P/D", "2 in 1", "9 in 1", "K/C", "R", "M"})
        chkVaccinations.Location = New System.Drawing.Point(23, 32)
        chkVaccinations.Name = "chkVaccinations"
        chkVaccinations.Size = New System.Drawing.Size(186, 144)
        chkVaccinations.TabIndex = 0

        For Each row As DataRow In dsVaccinations.Tables(0).Rows
            chkVaccinations.Items.Add(row.Item("VXDesvription"))
        Next
        'grpVaccinations
        Dim grpVaccinations As New GroupBox
        grpVaccinations.Controls.Add(chkVaccinations)
        grpVaccinations.Location = New System.Drawing.Point(252, 179)
        grpVaccinations.Name = "grpVaccinations"
        grpVaccinations.Size = New System.Drawing.Size(234, 179)
        grpVaccinations.TabIndex = 2
        grpVaccinations.TabStop = False
        grpVaccinations.Text = "VACCINATIONS"
        '

        'chkTreatments
        Dim chkTreatments As New CheckedListBox
        chkTreatments.BorderStyle = System.Windows.Forms.BorderStyle.None
        chkTreatments.CheckOnClick = True
        chkTreatments.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        chkTreatments.FormattingEnabled = True
        'chkTreatments.Items.AddRange(New Object() {"Deworm", "Bra", "Bela", "Bac", "Bay", "Pen", "Cer"})
        chkTreatments.Location = New System.Drawing.Point(21, 32)
        chkTreatments.Name = "chkTreatments"
        chkTreatments.Size = New System.Drawing.Size(186, 126)
        chkTreatments.TabIndex = 1

        For Each row As DataRow In dsTreatments.Tables(0).Rows
            chkTreatments.Items.Add(row.Item("TRDescription"))
        Next


        'grpTreatment
        Dim grpTreatment As New GroupBox
        grpTreatment.Controls.Add(chkTreatments)
        grpTreatment.Location = New System.Drawing.Point(492, 182)
        grpTreatment.Name = "grpTreatment"
        grpTreatment.Size = New System.Drawing.Size(229, 176)
        grpTreatment.TabIndex = 3
        grpTreatment.TabStop = False
        grpTreatment.Text = "TREATMENTS"
        '

        'tabPet
        Dim tabPet As New TabPage
        tabPet.Controls.Add(grpTreatment)
        tabPet.Controls.Add(grpVaccinations)
        tabPet.Controls.Add(grpHistory)
        tabPet.Controls.Add(datHistory)
        tabPet.Controls.Add(btnAddRecord)
        tabPet.Controls.Add(btnSave)
        tabPet.Location = New System.Drawing.Point(4, 23)
        tabPet.Name = "tabPet"
        tabPet.Padding = New System.Windows.Forms.Padding(3)
        tabPet.Size = New System.Drawing.Size(727, 436)
        tabPet.TabIndex = 0
        tabPet.Text = tabName
        tabPet.UseVisualStyleBackColor = True

        With datHistory
            '.Columns.Clear()
            .Columns.Add("colTransactionID", "TRANSACTION")
            .Columns("colTransactionID").Width = .Width * 0.4
            .Columns.Add("colVisitDate", "VISIT DATE")
            .Columns("colVisitDate").Width = .Width * 0.4

            Dim btnSelect As New DataGridViewButtonColumn
            btnSelect.Text = "•••"
            btnSelect.UseColumnTextForButtonValue = True
            btnSelect.Width = .Width * 0.18
            .Columns.Add(btnSelect)


            For Each row As DataRow In dsTransactionHeader.Tables(0).Rows
                .Rows.Add()
                .Rows(.RowCount - 1).Cells(0).Value = row.Item("TransactionID")
                .Rows(.RowCount - 1).Cells(1).Value = Format(row.Item("VisitDate"), "Short Date")
                Call getTransactionDetails(row.Item("TransactionID"))
                If .RowCount = 1 Then

                    dtpVisitDate.Text = row.Item("VisitDate")
                    txtWT.Text = row.Item("WT")
                    txtTemp.Text = row.Item("Temp")
                    txtDX.Text = row.Item("Diagnostic")
                    txtAmount.Text = row.Item("Amount")
                    dtpNextVisit.Text = row.Item("NextVisit")

                    If dsTransactionDetails.Tables(0).Rows.Count <> 0 Then
                        For Each row1 As DataRow In dsTransactionDetails.Tables(0).Rows
                            chkVaccinations.SetItemChecked(Convert.ToInt32(row1.Item("Vaccine")) - 1, True)
                            chkTreatments.SetItemChecked(Convert.ToInt32(row1.Item("Treatment")) - 1, True)
                        Next
                    End If

                End If
            Next
        End With

        'tabPetInfo
        tabPetInfo.Controls.Add(tabPet)
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        frmOwnerList.ShowDialog()
    End Sub

    Private Sub getTransactionDetails(strTransactionID As String)
        Try
            sqlQuery = ""
            sqlQuery += "SELECT * FROM TransactionDetails " & vbCrLf
            sqlQuery += "WHERE TransactionID = '" + strTransactionID + "'"

            dsTransactionDetails = SQLPetMIS(sqlQuery)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getTreatments()
        Try
            sqlQuery = ""
            sqlQuery += "SELECT * FROM Treatments"

            dsTreatments = SQLPetMIS(sqlQuery)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getVaccinations()
        Try
            sqlQuery = ""
            sqlQuery += "SELECT * FROM Vaccinations"

            dsVaccinations = SQLPetMIS(sqlQuery)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddRecord(sender As Object, e As EventArgs)
        Call clearFields(grpHistory)
        Call clearFields(grpTreatment)
        Call clearFields(grpVaccinations)
    End Sub

End Class