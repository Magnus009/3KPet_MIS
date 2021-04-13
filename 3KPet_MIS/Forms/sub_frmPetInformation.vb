Public Class sub_frmPetInformation
    Dim dsPetInfo As New DataSet
    Dim strTransactionCode As String
    Dim dsVax As New DataSet


    Public Sub loadPetsInformation(strOwner As String)
        Try
            'load Pet
            Dim dtPets As New DataTable("Pets")
            sqlQuery = ""
            sqlQuery = "SELECT * FROM Pets" & vbCrLf
            sqlQuery += "WHERE OwnerID ='" + strOwner + "'" & vbCrLf
            dtPets = SQLPetMIS(sqlQuery).Tables(0)

            'cboPet.DataSource = Nothing
            cboPet.DataSource = dtPets
            cboPet.DisplayMember = "Name"
            cboPet.ValueMember = "PetID"

            AddHandler cboPet.SelectedIndexChanged, AddressOf petSelect
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub loadTransactionDetails(strTransactionID As String)
        Try
            strTransactionCode = strTransactionID
            Dim dtTransHeader As New DataTable("TransactionHeader")
            Dim dtTransDetails As New DataTable("TransactionDetails")
            Dim dtPurchased As New DataTable("PurchasedProducts")
            Dim dsVaccines As New DataSet

            'Get transaction Header
            sqlQuery = "SELECT * FROM TransactionHeader" + vbCrLf
            sqlQuery += "WHERE TransactionID = '" + strTransactionID + "'" + vbCrLf
            'sqlQuery += "AND PetID = '" + cboPet.SelectedValue + "'" & vbCrLf
            sqlQuery += "ORDER BY VisitDate"
            dtTransHeader = SQLPetMIS(sqlQuery).Tables(0)

            'Get Transaction Details
            sqlQuery = ""
            sqlQuery += "select TD.TransactionID, TD.Treatment from TransactionDetails TD" & vbCrLf
            sqlQuery += "WHERE TransactionID = '" + strTransactionID + "'" + vbCrLf
            dtTransDetails = SQLPetMIS(sqlQuery).Tables(0)

            'Get Products
            sqlQuery = ""
            sqlQuery += "SELECT PP.ProductID, Description, QTY, TotatlPrice FROM PurschasedProducts PP" & vbCrLf
            sqlQuery += "INNER JOIN Products P ON PP.ProductID = P.ProductID" & vbCrLf
            sqlQuery += "WHERE PP.TransactionID = '" + strTransactionID + "' AND TypeID <>2" & vbCrLf
            dtPurchasedProd = SQLPetMIS(sqlQuery).Tables(0)

            'setGridColumns()

            datProduct.DataSource = dtPurchasedProd
            setGridProperties()

            If dtTransHeader.Rows.Count <> 0 Then
                dtpVisitDate.Value = dtTransHeader.Rows(0)("VisitDate")
                txtWT.Text = dtTransHeader.Rows(0)("WT")
                txtTemp.Text = dtTransHeader.Rows(0)("Temp")
                txtTemp.Text += "°C"
                txtDX.Text = dtTransHeader.Rows(0)("Diagnostic")
                'txtAmount.Text = IIf(dtTransHeader.Rows(0)("TotalAmount")
                txtTX.Text = dtTransDetails.Rows(0)("Treatment")
                txtTXAmount.Text = Convert.ToDecimal(dtTransHeader.Rows(0)("ServicesAmount"))
                txtNextVisit.Text = Format(dtTransHeader.Rows(0)("NextVisit"), "yyyy/MM/dd")

                'clearFields(grpTreatment)
                'For Each row As DataRow In dtTransDetails.Rows
                '    'For Each row1 As DataRow In datTreatment.Rows
                '    With datTreatment
                '        For i As Integer = 0 To .Rows.Count - 1
                '            If .Item(0, i).Value = row.Item("Treatment") Then
                '                .Item(3, i).Value = True
                '            End If
                '        Next
                '    End With
                'Next

                'get Vaccines
                sqlQuery = ""
                sqlQuery += "SELECT PP.ProductID, Description, QTY, TotatlPrice FROM PurschasedProducts PP" & vbCrLf
                sqlQuery += "INNER JOIN Products P ON PP.ProductID = P.ProductID" & vbCrLf
                sqlQuery += "WHERE PP.TransactionID = '" + strTransactionID + "' and TypeID = 2" & vbCrLf
                dsVaccines = SQLPetMIS(sqlQuery)

                For Each row As DataRow In dsVaccines.Tables(0).Rows
                    'For Each row1 As DataRow In datTreatment.Rows
                    With datVaccine
                        For i As Integer = 0 To .Rows.Count - 1
                            If .Item(0, i).Value = row.Item("ProductID") Then
                                .Item(3, i).Value = True
                            End If
                        Next
                    End With
                Next


                'History
                datHistory.Columns.Clear()
                Dim dtPetMedHistory As New DataTable("PetMedHistory")
                sqlQuery = "SELECT TransactionID, VisitDate FROM TransactionHeader" + vbCrLf
                sqlQuery += "WHERE PetID = '" + cboPet.SelectedValue + "'"
                dtPetMedHistory = SQLPetMIS(sqlQuery).Tables(0)
                datHistory.DataSource = dtPetMedHistory

                'view Button
                Dim btnView As New DataGridViewButtonColumn
                btnView.Text = "•••"
                btnView.Name = "VIEW"
                btnView.UseColumnTextForButtonValue = True
                btnView.Width = datHistory.Width * 0.15
                datHistory.Columns.Add(btnView)

                btnSave.Enabled = False
                btnPurchase.Enabled = False
                btnAddRecord.Enabled = True
            Else
                btnSave.Enabled = True
                btnPurchase.Enabled = True
                btnAddRecord.Enabled = False
                dtpVisitDate.Value = Today
                txtWT.Text = ""
                txtTemp.Text = ""
                txtDX.Text = ""
                'txtAmount.Text = ""
                'dtpNextVisit.Value = Today
                datHistory.Columns.Clear()
                datProduct.Columns.Clear()
                dtPurchasedProd.Clear()
                setGridColumns()
                setGridProperties()
            End If
            cboPet.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    'Private Sub cboPet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPet.SelectedIndexChanged

    '    loadVisitHistory()
    '    If strTransactionCode <> "" Then
    '        datProduct.Columns.Clear()
    '        dtPurchasedProd.Clear()
    '        setGridColumns()
    '        setGridProperties()
    '        datTreatment.Columns.Clear()
    '        datVaccine.Columns.Clear()
    '        setTreatments()
    '        setVaccines()
    '        loadTransactionDetails(strTransactionCode)
    '    Else
    '        datProduct.Columns.Clear()
    '        dtPurchasedProd.Clear()
    '        setGridColumns()
    '        setGridProperties()
    '        datTreatment.Columns.Clear()
    '        datVaccine.Columns.Clear()
    '        setTreatments()
    '        setVaccines()
    '    End If



    'End Sub

    Private Sub petSelect(sender As Object, e As EventArgs)
        loadVisitHistory()
        If strTransactionCode <> "" Then
            datProduct.Columns.Clear()
            dtPurchasedProd.Clear()
            setGridColumns()
            setGridProperties()
            'datTreatment.Columns.Clear()
            datVaccine.Columns.Clear()
            'setTreatments()
            setVaccines()
            loadTransactionDetails(strTransactionCode)
        Else
            datProduct.Columns.Clear()
            dtPurchasedProd.Clear()
            setGridColumns()
            setGridProperties()
            'datTreatment.Columns.Clear()
            datVaccine.Columns.Clear()
            'setTreatments()
            setVaccines()
        End If
    End Sub

    Private Sub loadVisitHistory()
        Try
            Dim dtVisitHistory As New DataTable

            sqlQuery = "SELECT TransactionID, VisitDate FROM TransactionHeader" + vbCrLf
            sqlQuery += "WHERE PetID = '" + cboPet.SelectedValue + "'"
            dtVisitHistory = SQLPetMIS(sqlQuery).Tables(0)

            datHistory.Columns.Clear()
            datHistory.DataSource = dtVisitHistory

            'view Button
            Dim btnView As New DataGridViewButtonColumn
            btnView.Text = "•••"
            btnView.Name = "VIEW"
            btnView.UseColumnTextForButtonValue = True
            btnView.Width = datHistory.Width * 0.15
            datHistory.Columns.Add(btnView)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub datHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datHistory.CellContentClick

        If datHistory.Columns(e.ColumnIndex).Name = "VIEW" Then
            With frmInvoice
                .strTransID = datHistory.Rows(e.RowIndex).Cells("TransactionID").Value
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub txtNextVisit_Click(sender As Object, e As EventArgs) Handles txtNextVisit.Click
        With frmScheduleReservation
            .txtCustomer.Text = dsOwnerInfo.Tables(0).Rows(0)("LastName") + ", " + dsOwnerInfo.Tables(0).Rows(0)("FirstName")
            .txtContact.Text = dsOwnerInfo.Tables(0).Rows(0)("Address")
            .txtAddress.Text = dsOwnerInfo.Tables(0).Rows(0)("ContactNo")
            '.chkCancel.Enabled = False
            '.chkIsArrived.Enabled = False
        End With
        frmScheduleReservation.ShowDialog()
        txtNextVisit.Text = strNextvisit
    End Sub
    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        frmProducts.ShowDialog()
        Call setGridProperties()
    End Sub

    Private Sub setGridColumns()
        Try
            With dtPurchasedProd
                .Columns.Clear()
                .Columns.Add("ProductID")
                .Columns.Add("Description")
                .Columns.Add("QTY")
                .Columns.Add("TotatlPrice")

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub setGridProperties()
        datProduct.DataSource = dtPurchasedProd
        With datProduct
            .Columns("ProductID").Visible = False
            .Columns("Description").Width = .Width * 0.4
            .Columns("QTY").Width = .Width * 0.3
            .Columns("TotatlPrice").Width = .Width * 0.28
        End With
    End Sub

    'Private Sub loadVaccine()
    '    Try
    '        Dim dtVX As New DataTable
    '        sqlQuery = "SELECT VXID, VXDesvription FROM Vaccinations WHERE DeletedDate IS NULL"
    '        dtVX = SQLPetMIS(sqlQuery).Tables(0)

    '        chkVaccinations.Items.Clear()
    '        chkVaccinations.DataSource = dtVX
    '        chkVaccinations.DisplayMember = "VXDesvription"
    '        chkVaccinations.ValueMember = "VXID"
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '    End Try
    'End Sub

    Private Sub sub_frmPetInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'setVaccines()
        'setTreatments()
        'Call setGridColumns()
        If fn_CheckRequire(grpHistory) = True Then
            btnAddRecord.Enabled = False
            btnSave.Enabled = True
            btnPurchase.Enabled = True
        Else
            btnSave.Enabled = True
            btnAddRecord.Enabled = False
            btnPurchase.Enabled = True
        End If
        'loadVaccine()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim dsTransactionID As New DataSet
            Dim strTransID As String
            Dim strServiceAmount As String
            Dim strProdAmount As String
            Dim strTotalPrice As String

            If MsgBox("Are you sure you want to save?", vbYesNo + vbQuestion) = vbYes Then
                '//Get Transaction ID
                sqlQuery = ""
                sqlQuery += "SELECT dbo.fn_colID ('T')"
                dsTransactionID = SQLPetMIS(sqlQuery)
                strTransID = dsTransactionID.Tables(0).Rows(0)(0)

                strServiceAmount = "0"
                'For Each row As DataGridViewRow In datTreatment.Rows
                'If row.Cells(3).Value = True Then
                '//Insert into transaction details
                sqlQuery = ""
                sqlQuery += "INSERT INTO dbo.TransactionDetails " & vbCrLf
                sqlQuery += "( " & vbCrLf
                sqlQuery += "TransactionID," & vbCrLf
                sqlQuery += "Treatment," & vbCrLf
                sqlQuery += "Vaccine," & vbCrLf
                sqlQuery += "CreatedDate, " & vbCrLf
                sqlQuery += "UpdatedDate, " & vbCrLf
                sqlQuery += "DeletedDate," & vbCrLf
                sqlQuery += "UpdatedBy " & vbCrLf
                sqlQuery += ") " & vbCrLf
                sqlQuery += "VALUES" & vbCrLf
                sqlQuery += "( " & vbCrLf
                sqlQuery += "'" + strTransID + "'," & vbCrLf
                sqlQuery += "'" + txtTX.Text + "'," & vbCrLf
                sqlQuery += "null," & vbCrLf
                sqlQuery += "getdate(), " & vbCrLf
                sqlQuery += "getdate(), " & vbCrLf
                sqlQuery += "null," & vbCrLf
                sqlQuery += "'" + _gbAccountID + "' " & vbCrLf
                sqlQuery += ") "
                sqlExecute(sqlQuery)

                'strServiceAmount = (Convert.ToInt32(strServiceAmount) + Convert.ToInt32(row.Cells(2).Value))
                'End If
                'Next

                strProdAmount = "0"
                For Each row As DataGridViewRow In datVaccine.Rows

                    If row.Cells(3).Value = True Then
                        strTotalPrice = Convert.ToDouble(row.Cells(2).Value) * Convert.ToDouble(row.Cells(3).Value)
                        sqlQuery = ""
                        sqlQuery += "INSERT INTO dbo.PurschasedProducts " & vbCrLf
                        sqlQuery += "( " & vbCrLf
                        sqlQuery += "TransactionID," & vbCrLf
                        sqlQuery += "ProductID," & vbCrLf
                        sqlQuery += "QTY," & vbCrLf
                        sqlQuery += "TotatlPrice," & vbCrLf
                        sqlQuery += "CreatedDate, " & vbCrLf
                        sqlQuery += "UpdatedDate, " & vbCrLf
                        sqlQuery += "DeletedDate," & vbCrLf
                        sqlQuery += "UpdatedBy " & vbCrLf
                        sqlQuery += ") " & vbCrLf
                        sqlQuery += "VALUES" & vbCrLf
                        sqlQuery += "( " & vbCrLf
                        sqlQuery += "'" + strTransID + "'," & vbCrLf
                        sqlQuery += "'" + row.Cells(0).Value.ToString + "'," & vbCrLf
                        sqlQuery += "1," & vbCrLf
                        sqlQuery += strTotalPrice + "," & vbCrLf
                        sqlQuery += "getdate(), " & vbCrLf
                        sqlQuery += "getdate(), " & vbCrLf
                        sqlQuery += "null," & vbCrLf
                        sqlQuery += "'" + _gbAccountID + "' " & vbCrLf
                        sqlQuery += ") "
                        sqlExecute(sqlQuery)

                        sqlQuery = ""
                        sqlQuery += "UPDATE dbo.ProductInventory" & vbCrLf
                        sqlQuery += "SET Stocks = Stocks - 1" & vbCrLf
                        sqlQuery += "WHERE ProductID = '" + row.Cells(0).Value.ToString + "'" & vbCrLf
                        sqlQuery += "AND BatchNo = (SELECT min(BatchNo) FROM ProductInventory" & vbCrLf
                        sqlQuery += "WHERE ProductID = '" + row.Cells(0).Value.ToString + "' AND Stocks <> 0)" & vbCrLf
                        sqlExecute(sqlQuery)

                        strProdAmount = (Convert.ToInt32(strProdAmount) + Convert.ToInt32(row.Cells(2).Value))
                    End If


                Next

                strTotalPrice = "0"
                For Each row As DataGridViewRow In datProduct.Rows
                    Dim strTotal As String
                    strTotal = Convert.ToDouble(row.Cells(2).Value) * Convert.ToDouble(row.Cells(3).Value)
                    strTotalPrice = Convert.ToDouble(row.Cells(2).Value) * Convert.ToDouble(row.Cells(3).Value)
                    sqlQuery = ""
                    sqlQuery += "INSERT INTO dbo.PurschasedProducts " & vbCrLf
                    sqlQuery += "( " & vbCrLf
                    sqlQuery += "TransactionID," & vbCrLf
                    sqlQuery += "ProductID," & vbCrLf
                    sqlQuery += "QTY," & vbCrLf
                    sqlQuery += "TotatlPrice," & vbCrLf
                    sqlQuery += "CreatedDate, " & vbCrLf
                    sqlQuery += "UpdatedDate, " & vbCrLf
                    sqlQuery += "DeletedDate," & vbCrLf
                    sqlQuery += "UpdatedBy " & vbCrLf
                    sqlQuery += ") " & vbCrLf
                    sqlQuery += "VALUES" & vbCrLf
                    sqlQuery += "( " & vbCrLf
                    sqlQuery += "'" + strTransID + "'," & vbCrLf
                    sqlQuery += "'" + row.Cells(0).Value.ToString + "'," & vbCrLf
                    sqlQuery += row.Cells(2).Value.ToString + "," & vbCrLf
                    sqlQuery += strTotal + "," & vbCrLf
                    sqlQuery += "getdate(), " & vbCrLf
                    sqlQuery += "getdate(), " & vbCrLf
                    sqlQuery += "null," & vbCrLf
                    sqlQuery += "'" + _gbAccountID + "' " & vbCrLf
                    sqlQuery += ") "
                    sqlExecute(sqlQuery)

                    sqlQuery = ""
                    sqlQuery += "UPDATE dbo.ProductInventory" & vbCrLf
                    sqlQuery += "SET Stocks = Stocks - " + row.Cells(2).Value.ToString & vbCrLf
                    sqlQuery += "WHERE ProductID = '" + row.Cells(0).Value.ToString + "'" & vbCrLf
                    sqlQuery += "AND BatchNo = (SELECT min(BatchNo) FROM ProductInventory" & vbCrLf
                    sqlQuery += "WHERE ProductID = '" + row.Cells(0).Value.ToString + "' AND Stocks >=" + row.Cells(2).Value.ToString + ")" & vbCrLf
                    sqlExecute(sqlQuery)
                Next
                strTotalPrice = (Convert.ToInt32(strTotalPrice) + Convert.ToInt32(strProdAmount))
                '//Insert into Transaction Header
                sqlQuery = ""
                sqlQuery += "INSERT INTO dbo.TransactionHeader " & vbCrLf
                sqlQuery += "(" & vbCrLf
                sqlQuery += "TransactionID," & vbCrLf
                sqlQuery += "OwnerID," & vbCrLf
                sqlQuery += "PetID, " & vbCrLf
                sqlQuery += "VisitDate, " & vbCrLf
                sqlQuery += "WT, " & vbCrLf
                sqlQuery += "Temp, " & vbCrLf
                sqlQuery += "Diagnostic, " & vbCrLf
                sqlQuery += "Others, " & vbCrLf
                sqlQuery += "ProductAmount, " & vbCrLf
                sqlQuery += "ServicesAmount, " & vbCrLf
                sqlQuery += "TotalAmount, " & vbCrLf
                sqlQuery += "NextVisit, " & vbCrLf
                sqlQuery += "CreatedDate, " & vbCrLf
                sqlQuery += "UpdatedDate, " & vbCrLf
                sqlQuery += "DeletedDate, " & vbCrLf
                sqlQuery += "UpdatedBy " & vbCrLf
                sqlQuery += ") " & vbCrLf
                sqlQuery += "VALUES " & vbCrLf
                sqlQuery += "(" & vbCrLf
                sqlQuery += "'" + strTransID + "'," & vbCrLf
                sqlQuery += "'" + dsOwnerInfo.Tables(0).Rows(0)("OwnerID") + "'," & vbCrLf
                sqlQuery += "'" + cboPet.SelectedValue + "', " & vbCrLf
                sqlQuery += "'" + Format(dtpVisitDate.Value, "yyyy/MM/dd") + "', " & vbCrLf
                sqlQuery += "'" + txtWT.Text + "', " & vbCrLf
                sqlQuery += txtTemp.Text + ", " & vbCrLf
                sqlQuery += "'" + txtDX.Text + "', " & vbCrLf
                sqlQuery += "Null, " & vbCrLf
                sqlQuery += strTotalPrice + ", " & vbCrLf
                sqlQuery += txtTXAmount.Text + ", " & vbCrLf
                sqlQuery += (Convert.ToInt32(strTotalPrice) + Convert.ToInt32(strServiceAmount)).ToString + ", " & vbCrLf
                sqlQuery += "'" + txtNextVisit.Text + "', " & vbCrLf
                sqlQuery += "getdate(), " & vbCrLf
                sqlQuery += "getdate(), " & vbCrLf
                sqlQuery += "null, " & vbCrLf
                sqlQuery += "'" + _gbAccountID + "' " & vbCrLf
                sqlQuery += ") " & vbCrLf
                sqlExecute(sqlQuery)

                MsgBox("Record saved successfully!", vbInformation)
                Call loadTransactionDetails(strTransID)
                Call clearFields(grpHistory)
                'Call clearFields(grpTreatment)
                datProduct.Columns.Clear()
                'setTreatments()
                setVaccines()
                btnSave.Enabled = False
                btnPurchase.Enabled = False
                btnAddRecord.Enabled = True
                frmVisitHistory.getVisitLogs()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click
        Try
            Call clearFields(grpHistory)
            'Call clearFields(grpTreatment)
            btnSave.Enabled = True
            btnPurchase.Enabled = True
            btnAddRecord.Enabled = False
            datProduct.Columns.Clear()
            dtPurchasedProd.Clear()
            setGridColumns()
            setGridProperties()
            'datTreatment.Columns.Clear()
            datVaccine.Columns.Clear()
            setVaccines()
            'setTreatments()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub datProduct_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles datProduct.CellValueChanged
        Try
            If e.ColumnIndex = 2 Then
                datProduct.Rows(e.RowIndex).Cells(3).Value = (Convert.ToInt32(datProduct.Rows(e.RowIndex).Cells(2).Value) * Convert.ToInt32(datProduct.Rows(e.RowIndex).Cells(3).Value))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub setVaccines()
        Try
            sqlQuery = ""
            sqlQuery += "SELECT P.ProductID,Description, Price FROM Products P" & vbCrLf
            sqlQuery += "INNER JOIN ProductInventory PI ON P.ProductID = PI.ProductID" & vbCrLf
            sqlQuery += "WHERE TypeID = 2"
            dsVax = SQLPetMIS(sqlQuery)

            datVaccine.Columns.Clear()
            With datVaccine
                .DataSource = dsVax.Tables(0)
                .Columns(0).Visible = False

                Dim chkVX As New DataGridViewCheckBoxColumn
                chkVX.Width = .Width * 0.09
                .Columns.Add(chkVX)
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub setTreatments()
    '    Try
    '        Dim dsTreatments As New DataSet

    '        sqlQuery = ""
    '        sqlQuery += "SELECT TRID, TRDescription, Price FROM Treatments" & vbCrLf
    '        dsTreatments = SQLPetMIS(sqlQuery)

    '        datTreatment.Columns.Clear()

    '        With datTreatment
    '            .DataSource = dsTreatments.Tables(0)
    '            .Columns(0).Visible = False
    '            .Columns(2).Width = .Width * 0.36

    '            Dim chkTX As New DataGridViewCheckBoxColumn
    '            chkTX.Width = .Width * 0.09
    '            chkTX.Name = "Status"
    '            .Columns.Add(chkTX)
    '            .Columns("Status").HeaderText = ""

    '        End With
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub datHistory_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datHistory.CellContentDoubleClick
        Try
            If e.ColumnIndex <> 2 Then
                loadTransactionDetails(datHistory.Rows(e.RowIndex).Cells(0).Value)
                btnAddRecord.Enabled = True
                btnPurchase.Enabled = False
                btnSave.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub datHistory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datHistory.CellClick
    '    If datHistory.Columns(e.ColumnIndex).Name = "VIEW" Then
    '        MsgBox(datHistory.Rows(e.RowIndex).Cells("TransactionID").Value)
    '    End If
    'End Sub

   
    Private Sub grpHistory_Enter(sender As Object, e As EventArgs) Handles grpHistory.Enter

    End Sub
End Class