Imports Microsoft.Reporting.WinForms

Public Class frmTransactionReport

    Private Sub frmTransactionReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getTransactionsReport()
        Me.rpvTrans.RefreshReport()
    End Sub
    Private Sub getTransactionsReport()
        Try
            Dim dtTrans As New DataTable

            sqlQuery = ""
            sqlQuery += "SELECT TH.TransactionID," & vbCrLf
            sqlQuery += "CASE WHEN P.TypeID <> 2 THEN" & vbCrLf
            sqlQuery += "P.Description END  AS 'PRODUCTS'," & vbCrLf
            sqlQuery += "CASE WHEN P.TypeID <> 2 THEN" & vbCrLf
            sqlQuery += "PP.QTY END  AS 'ProdQTY'," & vbCrLf
            sqlQuery += "CASE WHEN P.TypeID = 2 THEN" & vbCrLf
            sqlQuery += "P.Description END  AS 'VACCINES'," & vbCrLf
            sqlQuery += "CASE WHEN P.TypeID = 2 THEN" & vbCrLf
            sqlQuery += "PP.QTY END  AS 'VXQTY'," & vbCrLf
            sqlQuery += "CASE WHEN T.TRDescription IS NOT NULL THEN " & vbCrLf
            sqlQuery += "T.TRDescription" & vbCrLf
            sqlQuery += "ELSE NULL END AS 'TREATMENTS'," & vbCrLf
            sqlQuery += "TH.ProductAmount, TH.ServicesAmount,TH.DiscountedAmount,TH.TotalAmount,TH.VisitDate" & vbCrLf
            sqlQuery += "FROM TransactionHeader TH" & vbCrLf
            sqlQuery += "Left JOIN TransactionDetails TD ON TH.TransactionID = TD.TransactionID" & vbCrLf
            sqlQuery += "LEFT JOIN PurschasedProducts PP ON TH.TransactionID = Pp.TransactionID" & vbCrLf
            sqlQuery += "INNER JOIN Products P ON PP.ProductID = P.ProductID " & vbCrLf
            sqlQuery += "INNER JOIN Treatments T ON TD.Treatment = T.TRID" & vbCrLf
            dtTrans = SQLPetMIS(sqlQuery).Tables(0)

            Me.rpvTrans.RefreshReport()
            With rpvTrans
                .LocalReport.DataSources.Clear()
                .LocalReport.ReportPath = "C:\Users\Brian\Desktop\3KPet_MIS\3KPet_MIS\Reports\rpTransactions.rdlc"
                .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsTransHistory", dtTrans))
                .SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                .ZoomMode = ZoomMode.Percent
                .ZoomPercent = 100
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class