Public Class frmTransactions
    Dim blnIsFIlter As Boolean = False

    Private Sub frmTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getTransactions()

    End Sub

    Private Sub getTransactions()
        Try
            Dim dsHeader As New DataSet
            Dim dsDetails As New DataSet
            Dim dsTreatments As New DataSet
            Dim dsVaccines As New DataSet
            Dim dsPurchasedProd As New DataSet
            Dim dtVaccine As New DataTable
            Dim dtProducts As New DataTable
            'Dim strOthers As String

            '/Get Transaction Header
            sqlQuery = ""
            sqlQuery += "SELECT TransactionID, LastName + ', ' + FirstNAme as OwnerName, Amount, Others, VisitDate FROM TransactionHeader TH" & vbCrLf
            sqlQuery += "INNER JOIN Owners O ON O.OwnerID = TH.OwnerID" & vbCrLf
            sqlQuery += "WHERE TH.DeletedDate IS NULL" & vbCrLf
            If txtSearch.Text <> "" Then
                sqlQuery += "AND TransactionID LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR LastName LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR FirstNAme LIKE '%" + txtSearch.Text + "%'" & vbCrLf
            End If
            If blnIsFIlter Then
                sqlQuery += "AND VisitDate " & vbCrLf
                sqlQuery += "BETWEEN '" + dtpFrom.Text + " 00:00:00' " & vbCrLf
                sqlQuery += "and '" + dtpTo.Text + " 23:59:59' " & vbCrLf
            Else
                sqlQuery += "AND convert(VARCHAR, VisitDate, 1) = convert(VARCHAR, getdate(), 1)" & vbCrLf
            End If
            sqlQuery += "ORDER BY VisitDate DESC" & vbCrLf
            dsHeader = SQLPetMIS(sqlQuery)

            


            '/Get treatment
            sqlQuery = ""
            sqlQuery += "SELECT TRID, TRDescription FROM Treatments " & vbCrLf
            sqlQuery += "WHERE DeletedDate IS NULL" & vbCrLf
            dsTreatments = SQLPetMIS(sqlQuery)

            sqlQuery = ""
            sqlQuery += "SELECT ProductID,Description FROM Products" & vbCrLf
            sqlQuery += "WHERE TypeID = 2 AND DeletedDate IS null" & vbCrLf
            dsVaccines = SQLPetMIS(sqlQuery)

            With datTransactions
                .Columns.Clear()
                .Columns.Add("colTransactionID", "ID")
                .Columns("colTransactionID").Frozen = True
                .Columns("colTransactionID").Width = .Width * 0.1
                .Columns.Add("colOwnerName", "Owner")
                .Columns("colOwnerName").Frozen = True
                .Columns("colOwnerName").Width = .Width * 0.15

                For Each row As DataRow In dsVaccines.Tables(0).Rows
                    Dim chkVax As New DataGridViewCheckBoxColumn
                    chkVax.Width = 20
                    chkVax.HeaderText = row.Item(1)
                    chkVax.Name = row.Item(1)
                    .Columns.Add(chkVax)
                    .Columns(row.Item(1)).ReadOnly = True
                    '.Columns.Add("col" + row.Item(1), row.Item(1))
                Next
                For Each row As DataRow In dsTreatments.Tables(0).Rows
                    Dim chkTX As New DataGridViewCheckBoxColumn
                    chkTX.HeaderText = row.Item(1)
                    chkTX.Name = row.Item(1)
                    .Columns.Add(chkTX)
                    .Columns(row.Item(1)).ReadOnly = True
                Next

                .Columns.Add("colVisitDate", "VISIT DATE")
                .Columns("colVisitDate").Width = .Width * 0.1

                Dim btnSelect As New DataGridViewButtonColumn
                btnSelect.Text = "•••"
                btnSelect.UseColumnTextForButtonValue = True
                btnSelect.Width = .Width * 0.1
                .Columns.Add(btnSelect)
                btnSelect.Name = "colOthers"
                btnSelect.HeaderText = "OTHERS"
                btnSelect.FlatStyle = FlatStyle.Flat
                btnSelect.DefaultCellStyle.BackColor = Color.Purple
                btnSelect.DefaultCellStyle.ForeColor = Color.White
                '.Columns("colOthers").Width = .Width * 0.1

                .Columns.Add("colAmount", "Amount")
                .Columns("colAmount").Width = .Width * 0.1
                .Columns("colAmount").Frozen = True

                .Columns(1).ReadOnly = True

                For Each row As DataRow In dsHeader.Tables(0).Rows
                    .Rows.Add()
                    .Rows(.RowCount - 1).Cells("colTransactionID").Value = row.Item("TransactionID")
                    .Rows(.RowCount - 1).Cells("colOwnerName").Value = row.Item("OwnerName")
                    .Rows(.RowCount - 1).Cells("colVisitDate").Value = Format(row.Item("VisitDate"), "Short Date")
                    '.Rows(.RowCount - 1).Cells("colOthers").Value =
                    .Rows(.RowCount - 1).Cells("colAmount").Value = row.Item("Amount")

                    '/Transaction Details
                    sqlQuery = ""
                    sqlQuery += "SELECT Distinct TransactionID, Treatment,TRDescription FROM TransactionDetails TD" & vbCrLf
                    sqlQuery += "INNER JOIN Treatments T ON TD.Treatment = T.TRID" & vbCrLf
                    sqlQuery += "WHERE TransactionID = '" + row.Item("TransactionID") + "'"
                    If txtSearch.Text <> "" Then
                        sqlQuery += "AND (TRDescription LIKE '%" + txtSearch.Text + "%')" & vbCrLf
                    End If
                    dsDetails = SQLPetMIS(sqlQuery)

                    'Purchased Product
                    sqlQuery = ""
                    sqlQuery += "SELECT PP.ProductID,Description, TypeID FROM PurschasedProducts PP" & vbCrLf
                    sqlQuery += "INNER JOIN Products P ON PP.ProductID = P.ProductID" & vbCrLf
                    sqlQuery += "WHERE pp.DeletedDate IS NULL" & vbCrLf
                    sqlQuery += "and TransactionID = '" + row.Item("TransactionID") + "'"
                    If txtSearch.Text <> "" Then
                        sqlQuery += "AND (TRDescription LIKE '%" + txtSearch.Text + "%')" & vbCrLf
                    End If
                    dsPurchasedProd = SQLPetMIS(sqlQuery)

                    'If dsPurchasedProd.Tables(0).Select("TypeID <> 2").Count <> 0 Then
                    '    dtProducts = dsPurchasedProd.Tables(0).Select("TypeID <> 2").CopyToDataTable
                    '    strOthers = ""
                    '    For Each row3 As DataRow In dtProducts.Rows
                    '        strOthers += row3.Item("Description") + ", "
                    '    Next

                    '    .Rows(.RowCount - 1).Cells("colOthers").Value = strOthers.Remove(strOthers.Count() - 1, 1)
                    'End If

                    If dsPurchasedProd.Tables(0).Select("TypeID = 2").Count <> 0 Then

                        dtVaccine = dsPurchasedProd.Tables(0).Select("TypeID = 2").CopyToDataTable
                    End If


                    For Each row1 As DataRow In dtVaccine.Rows
                        For Each row2 As DataRow In dsVaccines.Tables(0).Rows
                            If row2.Item("Description") = row1.Item("Description") Then
                                .Rows(.RowCount - 1).Cells(row1.Item("Description")).Value = True
                            End If
                        Next
                    Next
                    For Each row1 As DataRow In dsDetails.Tables(0).Rows
                        For Each row2 As DataRow In dsTreatments.Tables(0).Rows
                            If row2.Item("TRDescription") = row1.Item("TRDescription") Then
                                .Rows(.RowCount - 1).Cells(row1.Item("TRDescription")).Value = True
                            End If
                        Next
                    Next


                Next
            End With

            blnIsFIlter = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Call getTransactions()
    End Sub

    Private Sub btnFIlter_Click(sender As Object, e As EventArgs) Handles btnFIlter.Click
        blnIsFIlter = True
        Call getTransactions()
    End Sub
    Private Sub datTransactions_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles datTransactions.CellEndEdit
        Try

            sqlQuery = ""
            sqlQuery += "UPDATE dbo.TransactionHeader" & vbCrLf
            sqlQuery += "SET Others = '" + datTransactions.Rows(e.RowIndex).Cells("colOthers").Value + "'" & vbCrLf
            sqlQuery += ", Amount = " + datTransactions.Rows(e.RowIndex).Cells("colAmount").Value.ToString & vbCrLf
            sqlQuery += "WHERE TransactionID = '" + datTransactions.Rows(e.RowIndex).Cells("colTransactionID").Value + "'" & vbCrLf
            sqlExecute(sqlQuery)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub datTransactions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datTransactions.CellContentClick
        Try
            If datTransactions.Columns(e.ColumnIndex).Name = "colOthers" Then
                frmPurchasedProducts.strID = datTransactions.Rows(e.RowIndex).Cells("colTransactionID").Value
                frmPurchasedProducts.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class