
Imports Microsoft.Reporting.WinForms
Public Class frmHistoryReport
    Public strOwnerID As String
    Public strPetID As String
    Dim isSingle As Boolean = False

    Private Sub frmHistoryReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getRecords()
    End Sub

    Private Sub getRecords()
        Try
            Dim dsRecords As New DataSet

            sqlQuery = ""
            sqlQuery += "SELECT O.OwnerID, LastName + ', ' + FirstName AS OwnerName, PetId, P.Name FROM Owners O" & vbCrLf
            sqlQuery += "INNER JOIN Pets P ON O.OwnerID = P.OwnerID" & vbCrLf
            If txtSearch.Text <> "" Then
                sqlQuery += "WHERE O.OwnerID LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR O.LastName LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR O.FirstName LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR P.PetID LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR P.Name LIKE '%" + txtSearch.Text + "%'" & vbCrLf
            End If
            sqlQuery += "ORDER BY O.OwnerID"
            dsRecords = SQLPetMIS(sqlQuery)
            datRecords.Columns.Clear()
            datRecords.DataSource = dsRecords.Tables(0)

            Dim btnSelect As New DataGridViewButtonColumn
            btnSelect.Text = "PRINT"
            btnSelect.UseColumnTextForButtonValue = True
            btnSelect.Width = datRecords.Width * 0.1
            datRecords.Columns.Add(btnSelect)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub datRecords_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datRecords.CellContentClick
        If e.ColumnIndex = 4 Then
            With frmMedHistReport
                strOwnerID = datRecords.Rows(e.RowIndex).Cells(0).Value
                strPetID = datRecords.Rows(e.RowIndex).Cells(2).Value
                isSingle = True
                loadReport()
            End With
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        getRecords()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        loadReport()
    End Sub

    Private Sub loadReport()
        Try
            'Dim rpDS As ReportDataSource
            Dim ds As New dsMedHis
            Dim dt As New DataTable
            Dim dtPetInfo As New DataTable


            sqlQuery = ""
            sqlQuery += "SELECT LastName + ', ' + FirstName AS 'OwnerName', P.Name AS 'PetName',P.Breed, P.PetColor, P.Age, P.Gender,P.Birthday FROM Pets P" & vbCrLf
            sqlQuery += "INNER JOIN Owners O ON  P.OwnerID = O.OwnerID" & vbCrLf
            If isSingle Then
                sqlQuery += "WHERE P.OwnerID = '" + strOwnerID + "'" & vbCrLf
                sqlQuery += "AND P.PetID  = '" + strPetID + "'" & vbCrLf
            End If
            dtPetInfo = SQLPetMIS(sqlQuery).Tables(0)

            frmMedHistReport.rpvMedHistory.RefreshReport()
            sqlQuery = ""
            sqlQuery += "SELECT TransactionID, VisitDate, WT AS 'Weight', Temp AS 'Temperature', Diagnostic FROM TransactionHeader" & vbCrLf
            If isSingle Then
                sqlQuery += "WHERE OwnerID = '" + strOwnerID + "'" & vbCrLf
                sqlQuery += "AND PetID  = '" + strPetID + "'" & vbCrLf
            End If
            dt = SQLPetMIS(sqlQuery).Tables(0)
            If isSingle Then
                With frmMedHistReport.rpvMedHistory.LocalReport
                    .DataSources.Clear()
                    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsMedicalHistory", dt))
                    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsPetInfo", dtPetInfo))

                End With

                'rpDS = New ReportDataSource("dsMedHis", ds)
                With frmMedHistReport.rpvMedHistory
                    .SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                    .ZoomMode = ZoomMode.Percent
                    .ZoomPercent = 100
                    .Visible = True
                End With
                frmMedHistReport.rpvAllHistory.Visible = False
            Else
                With frmMedHistReport.rpvAllHistory
                    .LocalReport.DataSources.Clear()
                    .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsMedicalHistory", dt))
                    .SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                    .ZoomMode = ZoomMode.Percent
                    .ZoomPercent = 30
                    .Visible = True
                End With
                frmMedHistReport.rpvMedHistory.Visible = False
            End If
            isSingle = False
            frmMedHistReport.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class