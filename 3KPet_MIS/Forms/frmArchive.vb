Public Class frmArchive

    Private Sub frmArchive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getRecords()
    End Sub

    Private Sub getRecords()
        Try
            Dim dsRecords As New DataSet

            sqlQuery = ""
            sqlQuery += "SELECT P.OwnerID, LastNAme + ', '+ FirstName AS OwnerName, P.PetID, P.Name, P.Breed, P.PetColor, P.Age, P.Gender FROM Pets P" & vbCrLf
            sqlQuery += "INNER JOIN Owners O ON P.OwnerID = O.OwnerID " & vbCrLf
            sqlQuery += "WHERE P.isDeceased = 1" & vbCrLf
            If txtSearch.Text <> "" Then
                sqlQuery += "AND (O.OwnerID LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR O.LastName  LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR O.FirstName LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR P.PetID  LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR P.Name LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR P.Breed  LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR P.PetColor  LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR P.Age  LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR P.Gender  LIKE '%" + txtSearch.Text + "%')" & vbCrLf
            End If

            dsRecords = SQLPetMIS(sqlQuery)

            With datRecords
                .Columns.Clear()
                .Columns.Add("colOwnerID", "OWNER ID") : .Columns("colOwnerID").Width = .Width * 0.15
                .Columns.Add("colOwner", "OWNER NAME") : .Columns("colOwner").Width = .Width * 0.2
                .Columns.Add("colPetID", "PET ID") : .Columns("colPetID").Width = .Width * 0.15
                .Columns.Add("colPetName", "PET NAME") : .Columns("colPetName").Width = .Width * 0.2
                .Columns.Add("colBreed", "BREED") : .Columns("colBreed").Width = .Width * 0.1
                .Columns.Add("colColor", "COLOR") : .Columns("colColor").Width = .Width * 0.1
                .Columns.Add("colAge", "AGE") : .Columns("colAge").Width = .Width * 0.05
                .Columns.Add("colGender", "SEX") : .Columns("colGender").Width = .Width * 0.04

                For Each row As DataRow In dsRecords.Tables(0).Rows
                    .Rows.Add()
                    .Rows(.RowCount - 1).Cells(0).Value = row.Item("OwnerID")
                    .Rows(.RowCount - 1).Cells(1).Value = row.Item("OwnerName")
                    .Rows(.RowCount - 1).Cells(2).Value = row.Item("PetID")
                    .Rows(.RowCount - 1).Cells(3).Value = row.Item("Name")
                    .Rows(.RowCount - 1).Cells(4).Value = row.Item("Breed")
                    .Rows(.RowCount - 1).Cells(5).Value = row.Item("PetColor")
                    .Rows(.RowCount - 1).Cells(6).Value = row.Item("Age")
                    .Rows(.RowCount - 1).Cells(7).Value = row.Item("Gender")
                Next

            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Call getRecords()
    End Sub
End Class