Public Class sub_frmPetInformation
    Dim dsPetInfo As New DataSet
    Dim strTransactionCode As String


    Public Sub loadPetsInformation(strOwner As String)
        Try
            'load Pet
            Dim dtPets As New DataTable("Pets")
            sqlQuery = ""
            sqlQuery = "SELECT * FROM Pets" & vbCrLf
            sqlQuery += "WHERE OwnerID ='" + strOwner + "'" & vbCrLf
            dtPets = SQLPetMIS(sqlQuery).Tables(0)

            cboPet.DataSource = Nothing
            cboPet.DataSource = dtPets
            cboPet.DisplayMember = "Name"
            cboPet.ValueMember = "PetID"

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

            sqlQuery = "SELECT * FROM TransactionHeader" + vbCrLf
            sqlQuery += "WHERE TransactionID = '" + strTransactionID + "'" + vbCrLf
            sqlQuery += "AND PetID = '" + cboPet.SelectedValue + "'" & vbCrLf
            sqlQuery += "ORDER BY VisitDate"
            dtTransHeader = SQLPetMIS(sqlQuery).Tables(0)

            sqlQuery = ""
            sqlQuery += "select TD.TransactionID, TD.Treatment, TRDescription from TransactionDetails TD" & vbCrLf
            sqlQuery += "inner join Treatments T on TD.Treatment = T.TRID" & vbCrLf
            sqlQuery += "WHERE TransactionID = '" + strTransactionID + "'" + vbCrLf
            dtTransDetails = SQLPetMIS(sqlQuery).Tables(0)

            sqlQuery = ""
            sqlQuery += "SELECT PP.ProductID, Description, QTY, TotatlPrice FROM PurschasedProducts PP" & vbCrLf
            sqlQuery += "INNER JOIN Products P ON PP.ProductID = P.ProductID" & vbCrLf
            sqlQuery += "WHERE PP.TransactionID = '" + strTransactionID + "'" & vbCrLf
            dtPurchasedProd = SQLPetMIS(sqlQuery).Tables(0)

            datProduct.DataSource = dtPurchasedProd
            Call setGridProperties()

            If dtTransHeader.Rows.Count <> 0 Then
                dtpVisitDate.Value = dtTransHeader.Rows(0)("VisitDate")
                txtWT.Text = dtTransHeader.Rows(0)("WT")
                txtTemp.Text = dtTransHeader.Rows(0)("Temp")
                txtTemp.Text += "°C"
                txtDX.Text = dtTransHeader.Rows(0)("Diagnostic")
                txtAmount.Text = dtTransHeader.Rows(0)("Amount")
                txtNextVisit.Text = Format(dtTransHeader.Rows(0)("NextVisit"), "yyyy/MM/dd")

                For Each row As DataRow In dtTransDetails.Rows
                    chkTreatments.SetItemChecked(row.Item("Treatment"), True)
                    'chkVaccinations.SetItemChecked(row.Item("Vaccine"), True)

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
                btnView.UseColumnTextForButtonValue = True
                btnView.Width = datHistory.Width * 0.15
                datHistory.Columns.Add(btnView)

            Else
                dtpVisitDate.Value = Today
                txtWT.Text = ""
                txtTemp.Text = ""
                txtDX.Text = ""
                txtAmount.Text = ""
                'dtpNextVisit.Value = Today
                datHistory.Columns.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cboPet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPet.SelectedIndexChanged
        If strTransactionCode <> "" Then
            loadTransactionDetails(strTransactionCode)
        End If
    End Sub

    Private Sub datHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datHistory.CellContentClick
        If e.ColumnIndex = 2 Then
            loadTransactionDetails(datHistory.Rows(e.RowIndex).Cells(0).Value)
            btnAddRecord.Enabled = True
        End If
    End Sub

    Private Sub txtNextVisit_Click(sender As Object, e As EventArgs) Handles txtNextVisit.Click
        With frmScheduleReservation
            .txtCustomer.Text = dsOwnerInfo.Tables(0).Rows(0)("LastName") + ", " + dsOwnerInfo.Tables(0).Rows(0)("FirstName")
            .txtContact.Text = dsOwnerInfo.Tables(0).Rows(0)("Address")
            .txtAddress.Text = dsOwnerInfo.Tables(0).Rows(0)("ContactNo")
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
                .Columns.Add("colID")
                .Columns.Add("colName")
                .Columns.Add("colPrice")
                .Columns.Add("colQTY")
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub setGridProperties()
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
        Call setGridColumns()
        If (fn_CheckRequire(Me) = False) Then
            btnAddRecord.Enabled = True
            btnSave.Enabled = False
        Else
            btnSave.Enabled = True
            btnAddRecord.Enabled = False
        End If
        'loadVaccine()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim dsTransactionID As New DataSet
            Dim strTransID As String

            If MsgBox("Are you sure you want to save?", vbYesNo + vbQuestion) Then
                '//Get Transaction ID
                sqlQuery = ""
                sqlQuery += "SELECT dbo.fn_colID ('T')"
                dsTransactionID = SQLPetMIS(sqlQuery)
                strTransID = dsTransactionID.Tables(0).Rows(0)(0)

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
                sqlQuery += "Amount, " & vbCrLf
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
                sqlQuery += txtAmount.Text + ", " & vbCrLf
                sqlQuery += "'" + txtNextVisit.Text + "', " & vbCrLf
                sqlQuery += "getdate(), " & vbCrLf
                sqlQuery += "getdate(), " & vbCrLf
                sqlQuery += "null, " & vbCrLf
                sqlQuery += "'" + _gbAccountID + "' " & vbCrLf
                sqlQuery += ") " & vbCrLf
                sqlExecute(sqlQuery)

                '//Insert into transaction details
                'For Each chkIndex In chkVaccinations.CheckedIndices
                '    sqlQuery = ""
                '    sqlQuery += "INSERT INTO dbo.TransactionDetails " & vbCrLf
                '    sqlQuery += "( " & vbCrLf
                '    sqlQuery += "TransactionID," & vbCrLf
                '    sqlQuery += "Treatment," & vbCrLf
                '    sqlQuery += "Vaccine," & vbCrLf
                '    sqlQuery += "CreatedDate, " & vbCrLf
                '    sqlQuery += "UpdatedDate, " & vbCrLf
                '    sqlQuery += "DeletedDate," & vbCrLf
                '    sqlQuery += "UpdatedBy " & vbCrLf
                '    sqlQuery += ") " & vbCrLf
                '    sqlQuery += "VALUES" & vbCrLf
                '    sqlQuery += "( " & vbCrLf
                '    sqlQuery += "'" + strTransID + "'," & vbCrLf
                '    sqlQuery += "null," & vbCrLf
                '    sqlQuery += (chkIndex + 1).ToString + "," & vbCrLf
                '    sqlQuery += "getdate(), " & vbCrLf
                '    sqlQuery += "getdate(), " & vbCrLf
                '    sqlQuery += "null," & vbCrLf
                '    sqlQuery += "'" + _gbAccountID + "' " & vbCrLf
                '    sqlQuery += ") "
                '    sqlExecute(sqlQuery)

                'Next
                For Each chkIndex In chkTreatments.CheckedIndices
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
                    sqlQuery += (chkIndex + 1).ToString + "," & vbCrLf
                    sqlQuery += "null," & vbCrLf
                    sqlQuery += "getdate(), " & vbCrLf
                    sqlQuery += "getdate(), " & vbCrLf
                    sqlQuery += "null," & vbCrLf
                    sqlQuery += "'" + _gbAccountID + "' " & vbCrLf
                    sqlQuery += ") "
                    sqlExecute(sqlQuery)

                Next

                For Each row As DataGridViewRow In datProduct.Rows
                    Dim strTotalPrice As String
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
                    sqlQuery += row.Cells(3).Value.ToString + "," & vbCrLf
                    sqlQuery += strTotalPrice + "," & vbCrLf
                    sqlQuery += "getdate(), " & vbCrLf
                    sqlQuery += "getdate(), " & vbCrLf
                    sqlQuery += "null," & vbCrLf
                    sqlQuery += "'" + _gbAccountID + "' " & vbCrLf
                    sqlQuery += ") "
                    sqlExecute(sqlQuery)

                    sqlQuery = ""
                    sqlQuery += "UPDATE dbo.Products" & vbCrLf
                    sqlQuery += "SET AvailableQTY = AvailableQTY - " + row.Cells(3).Value.ToString & vbCrLf
                    sqlQuery += "WHERE ProductID = '" + row.Cells(0).Value.ToString + "'" & vbCrLf
                    sqlExecute(sqlQuery)
                Next
                MsgBox("Record saved successfully!", vbInformation)
                Call loadTransactionDetails(strTransID)
                Call clearFields(Me)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click
        Try
            Call clearFields(grpHistory)
            Call clearFields(grpTreatment)
            datProduct.Columns.Clear()
            btnSave.Enabled = True
            btnAddRecord.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

  
  
End Class