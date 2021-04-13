Public Class frmInventory
    Dim blnResult As Boolean = False
    Dim blnVax As Boolean = False
    Dim dsRegProducts As DataSet

    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getProducts()
        getRegisteredProducts()
        'Call getProductType()
        txtAvailableQTY.Enabled = False
        btnUpdate.Visible = False
    End Sub

    Public Sub getProducts()
        Try
            Dim dsProducts As New DataSet

            sqlQuery = ""
            sqlQuery += "SELECT P.ProductID, P.Description, PT.Description as Type, PI.TotalQTY, PI.Stocks, PI.Price, PI.ExpirationDate   FROM Products P" & vbCrLf
            sqlQuery += "INNER JOIN ProductInventory PI ON PI.ProductID = P.ProductID" & vbCrLf
            sqlQuery += "INNER JOIN ProductTypes PT ON PT.TypeID = P.TypeID" & vbCrLf
            sqlQuery += "WHERE P.DeletedDate IS NULL " & vbCrLf
            If txtSearch.Text <> "" Then
                sqlQuery += "AND (P.ProductID LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR P.Description LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR PT.Description LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR PI.TotalQTY  LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR PI.Stocks  LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR PI.Price  LIKE '%" + txtSearch.Text + "%')" & vbCrLf
            End If

            dsProducts = SQLPetMIS(sqlQuery)

            With datProducts
                .Columns.Clear()
                .Columns.Add("colProductID", "PRODUCT ID") : .Columns("colProductID").Width = .Width * 0.15
                .Columns.Add("colProdName", "NAME") : .Columns("colProdName").Width = .Width * 0.2
                .Columns.Add("colProdType", "TYPE") : .Columns("colProdType").Width = .Width * 0.1
                .Columns.Add("colTotalQTY", "TOTAL QTY") : .Columns("colTotalQTY").Width = .Width * 0.1
                .Columns.Add("colAvail", "AVAILABLE QTY") : .Columns("colAvail").Width = .Width * 0.1
                .Columns.Add("colPrice", "PRICE") : .Columns("colPrice").Width = .Width * 0.1
                .Columns.Add("colExpiry", "EXPIRATION") : .Columns("colExpiry").Width = .Width * 0.13
                .Columns.Add("colStatus", "STATUS") : .Columns("colStatus").Visible = False

                Dim btnSelect As New DataGridViewButtonColumn
                btnSelect.Text = "RESTOCK"
                btnSelect.UseColumnTextForButtonValue = True
                btnSelect.Width = .Width * 0.11
                .Columns.Add(btnSelect)

                For Each row As DataRow In dsProducts.Tables(0).Rows
                    .Rows.Add()
                    .Rows(.RowCount - 1).Cells(0).Value = row.Item("ProductID")
                    .Rows(.RowCount - 1).Cells(1).Value = row.Item("Description")
                    .Rows(.RowCount - 1).Cells(2).Value = row.Item("Type")
                    .Rows(.RowCount - 1).Cells(3).Value = row.Item("TotalQTY")
                    .Rows(.RowCount - 1).Cells(4).Value = row.Item("Stocks")
                    .Rows(.RowCount - 1).Cells(5).Value = row.Item("Price")
                    .Rows(.RowCount - 1).Cells(6).Value = Format(row.Item("ExpirationDate"), "yyyy/MM/dd")
                    If row.Item("Stocks") <= 3 And row.Item("Stocks") > 0 Then
                        .Rows(.RowCount - 1).Cells(7).Value = "deactivated"
                    ElseIf row.Item("Stocks") = 0 Then
                        .Rows(.RowCount - 1).Cells(7).Value = "deleted"
                    End If

                Next
                AddHandler .CellFormatting, AddressOf subCellFormat
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Private Sub getProductType()
    '    Try
    '        Dim dsProdType As New DataSet

    '        sqlQuery = ""
    '        sqlQuery += "SELECT TypeID, Description FROM ProductTypes" & vbCrLf
    '        sqlQuery += "WHERE DeletedDate IS null" & vbCrLf
    '        dsProdType = SQLPetMIS(sqlQuery)

    '        cboType.DataSource = dsProdType.Tables(0)
    '        cboType.ValueMember = "TypeID"
    '        cboType.DisplayMember = "Description"

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub getRegisteredProducts()
        Try
            sqlQuery = ""
            sqlQuery += "SELECT * FROM Products"
            cboDataBinding(cboRegProducts, sqlQuery, "SELECT PRODUCT")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Call getProducts()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim dsID As New DataSet
            Dim strID As String
            Dim blnSaved As Boolean
            Dim intBatchNo As Integer

            If blnResult = False Then
                If MsgBox("Are you sure you want to add new product?", vbYesNo + vbQuestion) Then

                    sqlQuery = ""
                    sqlQuery += "SELECT coalesce(max(BatchNo), 0) + 1 as 'Batch No' FROM ProductInventory" & vbCrLf
                    sqlQuery += "WHERE ProductID = '" + txtID.Text + "'"
                    intBatchNo = SQLPetMIS(sqlQuery).Tables(0).Rows(0)(0)

                    sqlQuery = ""
                    sqlQuery += "INSERT INTO dbo.ProductInventory " & vbCrLf
                    sqlQuery += "( " & vbCrLf
                    sqlQuery += "BatchNo," & vbCrLf
                    sqlQuery += "ProductID," & vbCrLf
                    sqlQuery += "TotalQTY," & vbCrLf
                    sqlQuery += "Stocks," & vbCrLf
                    sqlQuery += "Price," & vbCrLf
                    sqlQuery += "ExpirationDate," & vbCrLf
                    sqlQuery += "CreatedDate," & vbCrLf
                    sqlQuery += "UpdatedDate," & vbCrLf
                    sqlQuery += "DeletedDate," & vbCrLf
                    sqlQuery += "UpdatedBy" & vbCrLf
                    sqlQuery += ")" & vbCrLf
                    sqlQuery += "VALUES " & vbCrLf
                    sqlQuery += "(" & vbCrLf
                    sqlQuery += intBatchNo.ToString + "," & vbCrLf
                    sqlQuery += "'" + txtID.Text + "'," & vbCrLf
                    sqlQuery += txtTotalQTY.Text + "," & vbCrLf
                    If txtAvailableQTY.Text = "" Then
                        sqlQuery += "0," & vbCrLf
                    Else
                        sqlQuery += txtAvailableQTY.Text + "," & vbCrLf
                    End If

                    sqlQuery += "'" + txtPrice.Text + "'," & vbCrLf
                    sqlQuery += "'" + dtpExpiration.Value + "'," & vbCrLf
                    sqlQuery += "getdate()," & vbCrLf
                    sqlQuery += "getdate()," & vbCrLf
                    sqlQuery += "null," & vbCrLf
                    sqlQuery += "'" + _gbAccountID + "')" & vbCrLf
                    blnSaved = sqlExecute(sqlQuery)


                    If blnSaved Then
                        Call saveLogs(1, "Added batch of products with code of " + txtID.Text)
                        MsgBox("Saved Succesfully", vbOKOnly + vbInformation)
                        Call getProducts()
                    End If
                End If
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call clearFields(grpProduct)
        btnSave.Visible = True
        btnUpdate.Visible = False
        txtAvailableQTY.Enabled = False
    End Sub

    Private Sub datRecords_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datProducts.CellContentClick
        Try
            If e.ColumnIndex = 8 Then
                clearFields(frmRestock)
                With frmRestock
                    .txtProductID.Text = datProducts.Rows(e.RowIndex).Cells(0).Value
                    .txtProductName.Text = datProducts.Rows(e.RowIndex).Cells(1).Value
                    .intMaxQTY = datProducts.Rows(e.RowIndex).Cells(3).Value
                    .ShowDialog()
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim blnSaved As Boolean

            If blnResult = False Then
                If MsgBox("Are you sure you want to update?", vbYesNo + vbQuestion) Then

                    'sqlQuery = ""
                    'sqlQuery += "UPDATE dbo.Products" & vbCrLf
                    'sqlQuery += "SET Description ='" + cboVal(cboRegProducts) + "'," & vbCrLf
                    'sqlQuery += "TypeID ='" + txtType.Text + "'," & vbCrLf
                    'sqlQuery += "UpdatedDate =getdate()" & vbCrLf
                    'sqlQuery += "WHERE ProductID ='" + txtID.Text + "'" & vbCrLf
                    'blnSaved = sqlExecute(sqlQuery)
                    '0:
                    sqlQuery = ""
                    sqlQuery += "UPDATE dbo.ProductInventory" & vbCrLf
                    sqlQuery += "SET TotalQTY ='" + txtTotalQTY.Text + "'," & vbCrLf
                    sqlQuery += "Stocks ='" + txtAvailableQTY.Text + "'," & vbCrLf
                    sqlQuery += "Price ='" + txtPrice.Text + "'," & vbCrLf
                    sqlQuery += "UpdatedDate =getdate()" & vbCrLf
                    sqlQuery += "WHERE ProductID ='" + txtID.Text + "'" & vbCrLf
                    blnSaved = sqlExecute(sqlQuery)

                    If blnSaved Then
                        Call clearFields(grpProduct)
                        Call getProducts()
                        Call saveLogs(2, "Updated product information with product ID of " + txtID.Text)
                        txtAvailableQTY.Enabled = False
                        MsgBox("Product information updated!", vbOKOnly + vbInformation)
                    End If


                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub datRecords_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datProducts.CellDoubleClick
        Try
            Dim strExpiration As String

            If e.ColumnIndex() <> 8 Then
                txtID.Text = datProducts.Rows(e.RowIndex).Cells(0).Value
                cboRegProducts.SelectedValue = datProducts.Rows(e.RowIndex).Cells(0).Value
                txtType.Text = datProducts.Rows(e.RowIndex).Cells(2).Value
                txtTotalQTY.Text = datProducts.Rows(e.RowIndex).Cells(3).Value
                txtAvailableQTY.Text = datProducts.Rows(e.RowIndex).Cells(4).Value
                txtPrice.Text = datProducts.Rows(e.RowIndex).Cells(5).Value
                dtpExpiration.Value = datProducts.Rows(e.RowIndex).Cells(6).Value

                txtAvailableQTY.Enabled = True
                btnSave.Visible = False
                btnUpdate.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtAvailableQTY_Leave(sender As Object, e As EventArgs) Handles txtAvailableQTY.Leave
        checkMaxStocks()
    End Sub

    Private Sub txtAvailableQTY_TextChanged(sender As Object, e As EventArgs) Handles txtAvailableQTY.TextChanged
        txtAvailableQTY.ForeColor = Color.Black
        blnResult = False
    End Sub

    Private Sub checkMaxStocks()

        If txtAvailableQTY.Text > txtTotalQTY.Text Then
            MsgBox("Stocks are more than the Max QTY", vbOKOnly + vbExclamation)
            txtAvailableQTY.ForeColor = Color.Red
            blnResult = True

        End If
    End Sub

    Private Sub cboType_SelectedIndexChanged(sender As Object, e As EventArgs)
        'If cboType.SelectedValue = 2 Then
        '    blnVax = True
        '    dtpExpiration.Enabled = True
        'Else
        '    blnVax = False
        '    dtpExpiration.Enabled = False
        'End If
    End Sub

    Private Sub cboRegProducts_Click(sender As Object, e As EventArgs) Handles cboRegProducts.Click
        'MsgBox(cboVal(cboRegProducts).ToString)


    End Sub

    Private Sub cboRegProducts_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboRegProducts.SelectedValueChanged
        Try
            Dim dsProductInfo As New DataSet

            If cboRegProducts.SelectedValue <> "-1" Then
                sqlQuery = ""
                sqlQuery += "SELECT ProductID,P.Description,PT.Description AS 'Type' FROM Products P" & vbCrLf
                sqlQuery += "INNER JOIN ProductTypes PT ON P.TypeID = PT.TypeID" & vbCrLf
                sqlQuery += "WHERE ProductID = '" + cboRegProducts.SelectedValue + "'"
                dsProductInfo = SQLPetMIS(sqlQuery)

                txtID.Text = dsProductInfo.Tables(0).Rows(0)("ProductID")
                txtType.Text = dsProductInfo.Tables(0).Rows(0)("Type")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class