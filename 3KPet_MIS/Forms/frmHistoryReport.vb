Public Class frmHistoryReport

  
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
                sqlQuery += "WHERE O.OwnerID LIKE '" + txtSearch.Text + "'" & vbCrLf
                sqlQuery += "OR LastName LIKE '" + txtSearch.Text + "'" & vbCrLf
                sqlQuery += "OR FirstName LIKE '" + txtSearch.Text + "'" & vbCrLf
                sqlQuery += "OR P.PetID LIKE '" + txtSearch.Text + "'" & vbCrLf
                sqlQuery += "OR P.Name LIKE '" + txtSearch.Text + "'" & vbCrLf
            End If
            sqlQuery += "ORDER BY O.OwnerID"
            dsRecords = SQLPetMIS(sqlQuery)

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
                .strOwnerID = datRecords.Rows(e.RowIndex).Cells(0).Value
                .strPetID = datRecords.Rows(e.RowIndex).Cells(2).Value
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        getRecords()
    End Sub
End Class