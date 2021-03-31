Public Class frmPurchasedProducts
    Public strID As String

    Private Sub frmPurchasedProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        getProducts(strID)
    End Sub

    Public Sub getProducts(strTransactionID As String)
        Try
            Dim dsProducts As New DataSet

            sqlQuery = ""
            sqlQuery += "SELECT DISTINCT PP.ProductID, P.Description, PT.Description as Type, PP.QTY, PP.TotatlPrice FROM PurschasedProducts PP" & vbCrLf
            sqlQuery += "INNER JOIN Products P ON PP.ProductID = P.ProductID" & vbCrLf
            sqlQuery += "INNER JOIN ProductTypes PT ON P.TypeID = PT.TypeID" & vbCrLf
            sqlQuery += "WHERE PP.TransactionID = '" + strTransactionID + "'" & vbCrLf
            dsProducts = SQLPetMIS(sqlQuery)

            datPurchasedProducts.DataSource = dsProducts.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
  
End Class