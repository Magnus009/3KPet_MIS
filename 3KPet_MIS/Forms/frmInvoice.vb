Imports Microsoft.Reporting.WinForms
Public Class frmInvoice
    Public strTransID As String
    Dim dsInvoice As New DataSet

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub getInvoice(strTID As String)
        Try

            sqlQuery = ""
            sqlQuery += "SELECT TransactionID, LastName +', '+ FirstNAme AS Name, ProductAmount, ServicesAmount, DiscountedAmount, TotalAmount,VisitDate FROM TransactionHeader TH" & vbCrLf
            sqlQuery += "INNER JOIN Owners O ON TH.OwnerID = O.OwnerID" & vbCrLf
            sqlQuery += "WHERE TransactionID = '" + strTID + "'"
            dsInvoice = SQLPetMIS(sqlQuery)

            lblTransID.Text = dsInvoice.Tables(0).Rows(0)("TransactionID")
            lblVisitDate.Text = dsInvoice.Tables(0).Rows(0)("VisitDate")
            lblServiceAmount.Text = IIf(IsDBNull(dsInvoice.Tables(0).Rows(0)("ServicesAmount")), "00.00", dsInvoice.Tables(0).Rows(0)("ServicesAmount"))
            lblTotalProd.Text = IIf(IsDBNull(dsInvoice.Tables(0).Rows(0)("ProductAmount")), "00.00", dsInvoice.Tables(0).Rows(0)("ProductAmount"))
            txtDiscount.Text = IIf(IsDBNull(dsInvoice.Tables(0).Rows(0)("DiscountedAmount")), "00.00", dsInvoice.Tables(0).Rows(0)("DiscountedAmount"))

            If IsDBNull(dsInvoice.Tables(0).Rows(0)("TotalAmount")) Then
                lblTotal.Text = "00.00"
                chkDiscount.Checked = False
            Else
                lblTotal.Text = dsInvoice.Tables(0).Rows(0)("TotalAmount")
                chkDiscount.Checked = True
            End If
            AddHandler txtDiscount.TextChanged, AddressOf txtDiscountChanged

            With frmInvoiceReport.rpvInvoice
                .LocalReport.DataSources.Clear()
                .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsInvoice", dsInvoice.Tables(0)))
                .SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                .ZoomMode = ZoomMode.Percent
                .ZoomPercent = 100
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        getInvoice(strTransID)
    End Sub


    Private Sub txtDiscountChanged(sender As Object, e As EventArgs)
        Try
            Dim intTotal As Integer
            If txtDiscount.Text <> "00.00" And txtDiscount.Text <> "" Then
                intTotal = Convert.ToDouble(dsInvoice.Tables(0).Rows(0)("TotalAmount"))
                intTotal = intTotal - Convert.ToDouble(txtDiscount.Text)
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
                sqlQuery += "SET DiscountedAmount =" + IIf(chkDiscount.Checked = True, txtDiscount.Text, 0) & vbCrLf
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

    Private Sub chkDiscount_CheckedChanged(sender As Object, e As EventArgs) Handles chkDiscount.CheckedChanged
        If chkDiscount.Checked Then
            txtDiscount.Enabled = True
        Else
            txtDiscount.Enabled = False
            txtDiscount.Text = 0
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        frmInvoiceReport.ShowDialog()
    End Sub
End Class