
Imports Microsoft.Reporting.WinForms

Public Class frmMedHistReport
    Public strOwnerID As String
    Public strPetID As String

    Private Sub frmMedHistReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadReport()
        Me.rpvMedHistory.RefreshReport()
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
            sqlQuery += "WHERE P.OwnerID = '" + strOwnerID + "'" & vbCrLf
            sqlQuery += "AND P.PetID  = '" + strPetID + "'" & vbCrLf
            dtPetInfo = SQLPetMIS(sqlQuery).Tables(0)

            Me.rpvMedHistory.RefreshReport()
            sqlQuery = ""
            sqlQuery += "SELECT TransactionID, VisitDate, WT AS 'Weight', Temp AS 'Tempereture', Diagnostic FROM TransactionHeader" & vbCrLf
            sqlQuery += "WHERE OwnerID = '" + strOwnerID + "'" & vbCrLf
            sqlQuery += "AND PetID  = '" + strPetID + "'" & vbCrLf
            dt = SQLPetMIS(sqlQuery).Tables(0)

            With rpvMedHistory.LocalReport
                .DataSources.Clear()
                .ReportPath = "C:\Users\Brian\Desktop\3KPet_MIS\3KPet_MIS\Reports\rpMedicalHistory.rdlc"
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsMedicalHistory", dt))
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsPetInfo", dtPetInfo))
            End With

            'rpDS = New ReportDataSource("dsMedHis", ds)
            With rpvMedHistory
                .SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                .ZoomMode = ZoomMode.Percent
                .ZoomPercent = 100
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class