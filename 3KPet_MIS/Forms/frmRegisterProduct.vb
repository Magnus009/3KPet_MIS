Public Class frmRegisterProduct

    Private Sub frmRegisterProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getProductType()
    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            Dim dsID As New DataSet
            Dim strID As String
            Dim blnSaved As Boolean

            If MsgBox("Are you sure you want to save?", vbYesNo + vbQuestion) = vbYes Then
                sqlQuery = ""
                sqlQuery += "SELECT dbo.fn_colID ('I')" & vbCrLf
                dsID = SQLPetMIS(sqlQuery)
                strID = dsID.Tables(0).Rows(0)(0)


                sqlQuery = ""
                sqlQuery += "INSERT INTO dbo.Products " & vbCrLf
                sqlQuery += "( " & vbCrLf
                sqlQuery += "ProductID," & vbCrLf
                sqlQuery += "Description," & vbCrLf
                sqlQuery += "TypeID," & vbCrLf
                sqlQuery += "CreatedDate," & vbCrLf
                sqlQuery += "UpdatedDate," & vbCrLf
                sqlQuery += "DeletedDate," & vbCrLf
                sqlQuery += "UpdatedBy" & vbCrLf
                sqlQuery += ")" & vbCrLf
                sqlQuery += "VALUES " & vbCrLf
                sqlQuery += "(" & vbCrLf
                sqlQuery += "'" + strID + "'," & vbCrLf
                sqlQuery += "'" + txtProdName.Text + "'," & vbCrLf
                sqlQuery += "'" + cboType.SelectedValue.ToString + "'," & vbCrLf
                sqlQuery += "getdate()," & vbCrLf
                sqlQuery += "getdate()," & vbCrLf
                sqlQuery += "null," & vbCrLf
                sqlQuery += "'" + _gbAccountID + "')" & vbCrLf
                blnSaved = sqlExecute(sqlQuery)

                If blnSaved Then
                    Call saveLogs(1, "New product added with product code of " + strID)
                    MsgBox("Saved Succesfully", vbOKOnly + vbInformation)
                    Me.Hide()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getProductType()
        Try
            Dim dsProdType As New DataSet

            sqlQuery = ""
            sqlQuery += "SELECT TypeID, Description FROM ProductTypes" & vbCrLf
            sqlQuery += "WHERE DeletedDate IS null" & vbCrLf
            dsProdType = SQLPetMIS(sqlQuery)

            cboType.DataSource = dsProdType.Tables(0)
            cboType.ValueMember = "TypeID"
            cboType.DisplayMember = "Description"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearFields(Me)
        Me.Hide()
    End Sub
End Class