Public Class frmProductType

    Private Sub frmProductType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getProductTypes()
    End Sub

    Private Sub getProductTypes()
        Try
            Dim dsProductType As New DataSet

            sqlQuery = ""
            sqlQuery += "SELECT TypeID as ID, Description FROM ProductTypes" & vbCrLf
            sqlQuery += "WHERE DeletedDate IS NULL" & vbCrLf
            If txtSearch.Text <> "" Then
                sqlQuery += "AND ( Description LIKE '%" + txtSearch.Text + "%')" & vbCrLf
            End If
            dsProductType = SQLPetMIS(sqlQuery)

            datProductType.DataSource = dsProductType.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim isExecute As Boolean

            If MsgBox("Are you sure you want to save?", vbYesNo + vbQuestion) Then
                sqlQuery = ""
                sqlQuery += "INSERT INTO dbo.ProductTypes " & vbCrLf
                sqlQuery += "(" & vbCrLf
                sqlQuery += "Description," & vbCrLf
                sqlQuery += "CreatedDate," & vbCrLf
                sqlQuery += "UpdatedDate," & vbCrLf
                sqlQuery += "DeletedDate, " & vbCrLf
                sqlQuery += "UpdatedBy" & vbCrLf
                sqlQuery += ")" & vbCrLf
                sqlQuery += "VALUES" & vbCrLf
                sqlQuery += "(" & vbCrLf
                sqlQuery += "'" + txtType.Text + "'," & vbCrLf
                sqlQuery += "getdate()," & vbCrLf
                sqlQuery += "getdate()," & vbCrLf
                sqlQuery += "null, " & vbCrLf
                sqlQuery += "'" + _gbAccountID + "'" & vbCrLf
                sqlQuery += ")" & vbCrLf
                isExecute = sqlExecute(sqlQuery)

                If isExecute Then
                    MsgBox("Record successfully save!", vbOKOnly + vbInformation)
                    txtType.Text = ""
                    getProductTypes()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        getProductTypes()
    End Sub
End Class