Public Class frmProducts
    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getProducts()
    End Sub

    Private Sub getProducts()
        Try
            Dim dsProducts As New DataSet

            sqlQuery = ""
            sqlQuery += "SELECT P.ProductID, P.Description, Price FROM Products P" & vbCrLf
            sqlQuery += "INNER JOIN ProductInventory PI ON PI.ProductID = P.ProductID" & vbCrLf
            sqlQuery += "WHERE P.DeletedDate is null AND Stocks <> 0 " & vbCrLf
            If txtSearch.Text <> "" Then
                sqlQuery += "AND (Description LIKE '%" + txtSearch.Text + "%')" & vbCrLf
            End If
            dsProducts = SQLPetMIS(sqlQuery)

            datProducts.DataSource = dsProducts.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub datProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datProducts.CellContentClick
        Try
            Dim dt As New DataTable
            Dim dr As DataRow
            Dim strFilter As String

            strFilter = "ProductID = '" + datProducts.Rows(e.RowIndex).Cells(0).Value + "'"

            If dtPurchasedProd.Select(strFilter).Count.Equals(0) Then
                With dtPurchasedProd
                    .Rows.Add(datProducts.Rows(e.RowIndex).Cells(0).Value, datProducts.Rows(e.RowIndex).Cells(1).Value, 1, datProducts.Rows(e.RowIndex).Cells(2).Value)
                End With
            Else
                dr = dtPurchasedProd.Select(strFilter)(0)
                'dr = dt.Rows(0)
                dr(2) = Convert.ToInt32(dr(2)) + 1
                dr(3) = Convert.ToInt32(dr(3)) * Convert.ToInt32(dr(2))
            End If

            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class