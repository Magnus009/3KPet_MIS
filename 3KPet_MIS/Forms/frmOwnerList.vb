Public Class frmOwnerList

    Private Sub OwnerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getOwnerList()
    End Sub

    Private Sub getOwnerList()
        Try
            Dim dsRecords As DataSet

            sqlQuery = ""
            sqlQuery += "SELECT Owners.OwnerID, LastName + ', ' + FirstName AS OwnerName, Address, ContactNo FROM Owners" & vbCrLf
            If txtSearch.Text <> "" Then
                sqlQuery += "WHERE LastName LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR FirstName LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR Name LIKE LIKE '%" + txtSearch.Text + "%'" & vbCrLf

            End If
            sqlQuery += "GROUP BY OwnerID, LastName, FirstName, Address, ContactNo" & vbCrLf
            sqlQuery += "ORDER BY Owners.OwnerID" & vbCrLf

            dsRecords = SQLPetMIS(sqlQuery)
            With datData
                .DataSource = dsRecords
                .DataMember = "Table"
                .Columns("Address").Visible = False
                .Columns("ContactNo").Visible = False
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub datData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datData.CellContentClick
        Try
            With frmScheduleInfo
                .txtOwnerID.Text = datData.Rows(e.RowIndex).Cells(0).Value
                .txtCustomer.Text = datData.Rows(e.RowIndex).Cells(1).Value
                .txtAddress.Text = datData.Rows(e.RowIndex).Cells(2).Value
                .txtContactNo.Text = datData.Rows(e.RowIndex).Cells(3).Value

                Me.Hide()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class