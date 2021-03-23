Public Class frmProducts
    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getProducts()
    End Sub

    Private Sub getProducts()
        Try
            Dim dsProducts As New DataSet

            sqlQuery = ""
            sqlQuery += "SELECT ProductID, Description, Price FROM Products" & vbCrLf
            sqlQuery += "WHERE DeletedDate is null" & vbCrLf
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
            With dtPurchasedProd
                .Rows.Add(datProducts.Rows(e.RowIndex).Cells(0).Value, datProducts.Rows(e.RowIndex).Cells(1).Value, datProducts.Rows(e.RowIndex).Cells(2).Value, 1)
            End With
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class