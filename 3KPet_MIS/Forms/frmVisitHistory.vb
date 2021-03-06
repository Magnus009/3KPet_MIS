Public Class frmVisitHistory


    Private Sub frmVisitHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub getVisitLogs()
        Try
            Dim dsVisitLogs As New DataSet

            sqlQuery = ""
            sqlQuery += "SELECT V.CustomerID, V.VisitDate,V.OwnerID, O.LastName + O.FirstName AS 'OwnerName', P.Name  FROM VisitHistory V" & vbCrLf
            sqlQuery += "INNER JOIN Owners O ON V.OwnerID = O.OwnerID " & vbCrLf
            sqlQuery += "INNER JOIN Pets P ON V.PetID = P.PetID " & vbCrLf
        Catch ex As Exception

        End Try
    End Sub
End Class