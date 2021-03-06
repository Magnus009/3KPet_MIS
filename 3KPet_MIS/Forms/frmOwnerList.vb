Public Class frmOwnerList

    Private Sub OwnerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getOwnerList()
    End Sub

    Private Sub getOwnerList()
        Try
            Dim dsRecords As DataSet

            sqlQuery = ""
            sqlQuery += "SELECT Owners.OwnerID, PetID, LastName + ', ' + FirstName AS OwnerName, Name AS 'PetName' FROM Owners" & vbCrLf
            sqlQuery += "INNER JOIN Pets ON Owners.OwnerID = Pets.OwnerID" & vbCrLf
            If txtSearch.Text <> "" Then
                sqlQuery += "WHERE LastName LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR FirstName LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR Name LIKE LIKE '%" + txtSearch.Text + "%'" & vbCrLf

            End If
            sqlQuery += "ORDER BY Owners.OwnerID" & vbCrLf

            dsRecords = SQLPetMIS(sqlQuery)
            With datData
                .DataSource = dsRecords
                .DataMember = "Table"
                .Columns(0).Visible = False
                .Columns(1).Visible = False
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub datData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datData.CellContentClick

    End Sub
End Class