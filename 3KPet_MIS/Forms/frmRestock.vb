Public Class frmRestock
    Public intMaxQTY As Integer
    Public intBatchNo As Integer

    Private Sub btnRestock_Click(sender As Object, e As EventArgs) Handles btnRestock.Click
        Try
            Dim blnResult As Boolean

            If txtQTY.Text = "" Then
                MsgBox("Please enter product quantity!", vbOKOnly + vbExclamation)
            Else
                If intMaxQTY < Convert.ToInt32(txtQTY.Text) Then
                    MsgBox("Stocks are more than the Max QTY", vbOKOnly + vbExclamation)
                Else
                    If MsgBox("Are you sure you want to save?", vbYesNo + vbQuestion) = vbYes Then


                        sqlQuery = ""
                        sqlQuery += "UPDATE dbo.ProductInventory" & vbCrLf
                        sqlQuery += "SET Stocks = " + txtQTY.Text & vbCrLf
                        sqlQuery += ", UpdatedDate = getdate()" & vbCrLf
                        sqlQuery += "WHERE ProductID = '" + txtProductID.Text + "'" & vbCrLf
                        sqlQuery += "AND BatchNo =" + intBatchNo.ToString & vbCrLf
                        blnResult = sqlExecute(sqlQuery)

                        If blnResult Then
                            MsgBox("Product restocked!", vbOKOnly + vbInformation)
                            saveLogs(2, "Restock product with ID of :" + txtProductID.Text)
                            frmInventory.getProducts()
                            Me.Hide()
                        End If
                    End If
                End If
               
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmRestock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler txtQTY.KeyPress, AddressOf numericOnly
    End Sub

End Class