Public Class frmServices
    Private Sub frmServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getServices()
    End Sub

    Private Sub getServices()
        Try
            Dim dsServices As New DataSet

            sqlQuery = ""
            sqlQuery += "SELECT  ServiceID, Description FROM Services" & vbCrLf
            If txtSearch.Text <> "" Then
                sqlQuery += "WHERE ServiceID LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR Description LIKE '%" + txtSearch.Text + "%'" & vbCrLf
            End If
            dsServices = SQLPetMIS(sqlQuery)

            datServices.DataSource = dsServices.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim strServiceID As String
            Dim blnResult As Boolean

            sqlQuery = ""
            sqlQuery += "SELECT dbo.fn_colID ('v')"
            strServiceID = SQLPetMIS(sqlQuery).Tables(0).Rows(0)(0)
            If txtName.Text <> "" Then
                If MsgBox("Are you sure you want to save?", vbYesNo + vbQuestion) = vbYes Then
                    sqlQuery = ""
                    sqlQuery += "INSERT INTO dbo.Services " & vbCrLf
                    sqlQuery += "(" & vbCrLf
                    sqlQuery += "ServiceID," & vbCrLf
                    sqlQuery += "Description," & vbCrLf
                    sqlQuery += "CreatedDate," & vbCrLf
                    sqlQuery += "UpdatedDate," & vbCrLf
                    sqlQuery += "DeletedDate," & vbCrLf
                    sqlQuery += "UpdatedBy" & vbCrLf
                    sqlQuery += ")" & vbCrLf
                    sqlQuery += "VALUES" & vbCrLf
                    sqlQuery += "(" & vbCrLf
                    sqlQuery += "'" + strServiceID + "'," & vbCrLf
                    sqlQuery += "'" + txtName.Text + "'," & vbCrLf
                    sqlQuery += "getdate()," & vbCrLf
                    sqlQuery += "getdate()," & vbCrLf
                    sqlQuery += "null," & vbCrLf
                    sqlQuery += "'" + _gbAccountID + "'" & vbCrLf
                    sqlQuery += ")" & vbCrLf
                    blnResult = sqlExecute(sqlQuery)

                    If blnResult Then
                        MsgBox("Record saved successfully!", vbOKOnly + vbInformation)
                        txtName.Text = ""
                        getServices()
                        saveLogs(1, "Add new services")
                    End If
                Else
                    'do nothing
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        getServices()
    End Sub
End Class