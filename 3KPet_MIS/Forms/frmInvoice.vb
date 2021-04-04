Public Class frmInvoice
    Public strTransID As String
    Dim dsInvoice As New DataSet

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub getInvoice(strTID As String)
        Try

            sqlQuery = ""
            sqlQuery += "SELECT TransactionID, VisitDate, ProductAmount, ServicesAmount, DiscountedAmount, TotalAmount FROM TransactionHeader" & vbCrLf
            sqlQuery += "WHERE TransactionID = '" + strTID + "'"
            dsInvoice = SQLPetMIS(sqlQuery)

            lblTransID.Text = dsInvoice.Tables(0).Rows(0)("TransactionID")
            lblVisitDate.Text = dsInvoice.Tables(0).Rows(0)("VisitDate")
            lblServiceAmount.Text = IIf(IsDBNull(dsInvoice.Tables(0).Rows(0)("ServicesAmount")), "00.00", dsInvoice.Tables(0).Rows(0)("ServicesAmount"))
            lblTotalProd.Text = IIf(IsDBNull(dsInvoice.Tables(0).Rows(0)("ProductAmount")), "00.00", dsInvoice.Tables(0).Rows(0)("ProductAmount"))
            txtDiscount.Text = IIf(IsDBNull(dsInvoice.Tables(0).Rows(0)("DiscountedAmount")), "00.00", dsInvoice.Tables(0).Rows(0)("DiscountedAmount"))
            lblTotal.Text = IIf(IsDBNull(dsInvoice.Tables(0).Rows(0)("TotalAmount")), "00.00", dsInvoice.Tables(0).Rows(0)("TotalAmount"))

            AddHandler txtDiscount.TextChanged, AddressOf txtDiscountChanged
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'AddHandler txtDiscount.KeyPress, AddressOf numericOnly
        getInvoice(strTransID)
    End Sub


    Private Sub txtDiscountChanged(sender As Object, e As EventArgs)
        Try
            Dim intTotal As Integer
            If txtDiscount.Text <> "00.00" And txtDiscount.Text <> "" Then
                intTotal = Convert.ToInt32(dsInvoice.Tables(0).Rows(0)("TotalAmount"))
                intTotal = intTotal - Convert.ToInt32(txtDiscount.Text)
                lblTotal.Text = intTotal.ToString
            Else
                lblTotal.Text = IIf(IsDBNull(dsInvoice.Tables(0).Rows(0)("TotalAmount")), "00.00", dsInvoice.Tables(0).Rows(0)("TotalAmount"))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim blnExecute As Boolean
            If MsgBox("Are you sure you want to save?", vbYesNo + vbQuestion) = vbYes Then
                sqlQuery = ""
                sqlQuery += "UPDATE dbo.TransactionHeader" & vbCrLf
                sqlQuery += "SET DiscountedAmount =" + txtDiscount.Text & vbCrLf
                sqlQuery += ", TotalAmount =" + lblTotal.Text & vbCrLf
                sqlQuery += ", UpdatedDate = getdate()" & vbCrLf
                sqlQuery += ", UpdatedBy = '" + _gbAccountID + "'" & vbCrLf
                sqlQuery += "WHERE TransactionID = '" + lblTransID.Text + "'" & vbCrLf
                blnExecute = sqlExecute(sqlQuery)

                If blnExecute Then
                    MsgBox("Record saved successfully!", vbOKOnly + vbInformation)
                    txtDiscount.Text = ""
                    Me.Hide()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class