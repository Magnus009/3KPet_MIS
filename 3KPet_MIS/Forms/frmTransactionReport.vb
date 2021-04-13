

Public Class frmTransactionReport

    Private Sub frmTransactionReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'getTransactionsReport()
        Me.rpvTrans.RefreshReport()
    End Sub
    'Private Sub getTransactionsReport()
    '    Try
    '        Dim dtTrans As New DataTable

    '        sqlQuery = ""
    '        sqlQuery += "SELECT TH.VisitDate, TH.TransactionID, PR.Product 'ProductName', PR.QTY 'ProductQTY', PR.TotatlPrice 'ProdAmount'," & vbCrLf
    '        sqlQuery += "VX.Vaccine, VX.QTY 'VXQTY',VX.TotatlPrice 'VXAmount',TD.Treatment, TH.ProductAmount, TH.ServicesAmount, TH.DiscountedAmount, " & vbCrLf
    '        sqlQuery += "TH.TotalAmount FROM TransactionHeader TH" & vbCrLf
    '        sqlQuery += "INNER JOIN TransactionDetails TD ON TH.TransactionID = TD.TransactionID" & vbCrLf
    '        sqlQuery += "LEFT JOIN (" & vbCrLf
    '        sqlQuery += "SELECT PP.TransactionID, P.ProductID, P.Description 'Product', PP.QTY, PP.TotatlPrice FROM PurschasedProducts PP" & vbCrLf
    '        sqlQuery += "INNER JOIN Products P ON PP.ProductID = P.ProductID" & vbCrLf
    '        sqlQuery += "AND P.TypeID <> 2" & vbCrLf
    '        sqlQuery += ") AS PR ON TD.TransactionID = PR.TransactionID" & vbCrLf
    '        sqlQuery += "LEFT JOIN (" & vbCrLf
    '        sqlQuery += "SELECT PP.TransactionID, P.ProductID, P.Description 'Vaccine', PP.QTY, PP.TotatlPrice FROM PurschasedProducts PP" & vbCrLf
    '        sqlQuery += "	INNER JOIN Products P ON PP.ProductID = P.ProductID" & vbCrLf
    '        sqlQuery += "AND P.TypeID = 2" & vbCrLf
    '        sqlQuery += ") AS VX ON TD.TransactionID = VX.TransactionID" & vbCrLf
    '        dtTrans = SQLPetMIS(sqlQuery).Tables(0)

    '        Me.rpvTrans.RefreshReport()
    '        With rpvTrans
    '            .LocalReport.DataSources.Clear()
    '            '.LocalReport.ReportPath = "C:\Users\training\Desktop\WYANE\Exploring\System\VS2013\3KPet_MIS\3KPet_MIS\Reports\rpTransactions.rdlc"
    '            .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsTransaction", dtTrans))
    '            .SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    '            .ZoomMode = ZoomMode.Percent
    '            .ZoomPercent = 100
    '        End With

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
End Class